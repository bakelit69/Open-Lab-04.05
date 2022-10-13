using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
             string DoubleChars = String.Empty;
            foreach (char x in orig)
            {
                for (int i = 0; i < n; i++)
                {
                    DoubleChars += x;
                }
                
            }
                return DoubleChars;                
        }
    }
}
