using System;

namespace missing_parenthesesP
{
    public class check_missing
    {
        public char missing(string exp)
        {
            if (exp == null)
            {
                throw new ArgumentNullException();
            }
            Stack<char> st = new Stack<char>();

            char[] expArray = exp.ToCharArray();

            for (int i = 0; i < expArray.Length; i++)
            {
                if (expArray[i] == '(')
                {
                    st.Push(expArray[i]);
                }

                if (expArray[i] == ')')
                {
                    if (st.Count != 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        return '(';
                    }
                }
            }

            if (st.Count != 0)
            {
                return ')';
            }

            return ' ';
        }

        static void Main(string[] args)
        {
            // Instantiate the check_missing class
            check_missing checker = new check_missing();

            // Call the missing method and store the result
            char result1 = checker.missing("(())");
            char result2 = checker.missing("(()");
            char result3 = checker.missing("())");

            // Print or use the result
            Console.WriteLine("Missing parenthesis result 1: " + result1);
            Console.WriteLine("Missing parenthesis result 2: " + result2);
            Console.WriteLine("Missing parenthesis result 3: " + result3);
        }
    }
}
