namespace ULCodingTest.Objects
{
    public class Expression
    {
        public Expression(decimal left, decimal right, string @operator)
        {
            Left = left;
            Operator = @operator;
            Right = right;
        }

        public decimal Left { get; set; }

        public string Operator { get; set; } 
        public decimal Right { get; set; }
    }
}
