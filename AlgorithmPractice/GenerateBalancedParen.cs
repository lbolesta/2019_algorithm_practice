using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice
{
    public class GenerateBalancedParen
    {
        private IList strlist = new List<string>();
        public IList GenerateParenthesis(int n)
        {
            GenerateParenthesisHelper(n, n, string.Empty);
            return strlist;
        }

        private void GenerateParenthesisHelper(int left, int right, string result)
        {
            if (left == 0 && right == 0)
            {
                strlist.Add(result);
                return;
            }

            if (left > 0)
            {
                GenerateParenthesisHelper(left - 1, right, result + '(');
            }

            if (right > left)
            {
                GenerateParenthesisHelper(left, right - 1, result + ')');
            }
        }
    }
}
