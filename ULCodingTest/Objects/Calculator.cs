namespace ULCodingTest.Objects
{
    public class Calculator
    {
        public static decimal Calculate(List<string> expList)
        {
            decimal sum;

            var index = expList.IndexOf("/") == -1 ? expList.IndexOf("*") : expList.IndexOf("/");

            if (index == -1)
            {
                index = expList.IndexOf("+") == -1 ? expList.IndexOf("-") : expList.IndexOf("+");
            }

            var expression = new Expression(Decimal.Parse(expList[index - 1]), Decimal.Parse(expList[index + 1]), expList[index]);

            sum = Evaluate(expression);

            var list = expList;

            UpdateList(ref list, index, sum.ToString());

            if (list.Count != 1)
            {

                return Calculate(list);

            }

            return sum;
        }

        public static void UpdateList(ref List<string> list, int index, string value)
        {
            for (int i = 1; i >= -1; i--)
            {
                list.RemoveAt(index + i);
            }

            list.Insert(index - 1, value.ToString());
        }


        public static decimal Evaluate(Expression expression)
        {
            if (expression.Operator == "*")
            {
                return expression.Left * expression.Right;
            }
            else if (expression.Operator == "/")
            {
                return expression.Left / expression.Right;
            }
            else if (expression.Operator == "+")
            {
                return expression.Left + expression.Right;
            }
            return expression.Left - expression.Right;
        }

    }
}
