using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    /// <summary>
    /// Class BalanceTask.
    /// </summary>
    public static class BalanceTask
    {
        /// <summary>
        /// A method that checks to verify that the brackets are spaced correctly.
        /// </summary>
        /// <param name="str">String for check.</param>
        /// <param name="brackets">List of brackets.</param>
        /// <returns>True if brackets are placed correctly, false otherwise.</returns>
        public static bool Balance(string str, List<Bracket> brackets)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "cannot be null");
            }

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var item in brackets)
                {
                    if (item.Contains(str[i]))
                    {
                        if (item.IsOpen(str[i]))
                        {
                            stack.Push(str[i]);
                        }

                        if (item.IsClose(str[i]))
                        {
                            if (stack.Count != 0)
                            {
                                if (!item.IsOpen(stack.Pop()))
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
