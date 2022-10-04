﻿using System.Text.RegularExpressions;

namespace ULCodingTest.ExtensionMethods
{
    public static class StringExtensions
    {
        public static List<string> Parse(this string str)
        {
            var list = new List<string>();
            if (str.Any(x => Char.IsLetter(x) || Char.IsPunctuation(x)))
            {
                return list;
            }
            else
            {
                list = SplitString(str);
                if (!IsCorrectFormat(list))
                {
                    list = new List<string>();
                }
            }
            return list;
        }

        public static List<string> SplitString(string str)
        {
            var pattern = @"([*()\^\/]|(?<!E)[\+\-])";
            
            return RemoveEmptyValues( Regex.Split(str, pattern).ToList());
        }

        public static bool IsCorrectFormat(List<string> list)
        {
            
            var isCorrect = false;

            for(int i = 0; i <= list.Count; i+= 2)
            {
                if (IsOperator(list[i]))
                {
                    isCorrect = false;
                    break;
                }
                if (i != list.Count -1)
                {
                    if(IsOperator(list[i+1]))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }

            }
            return isCorrect;
        }
        public static List<string> RemoveEmptyValues(List<string> strings)
        {
            strings.Remove("");
            return strings;
        }

        public static bool IsOperator(string str)
        {
            return (str == "*" || str == "/" || str == "-" || str == "+");
        }
    }
}