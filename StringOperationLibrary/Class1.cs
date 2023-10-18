using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationLibrary
{
    public class StringOperation
    {
        public delegate void StringOperationHandler(string input, string result);

        
        public event StringOperationHandler OnStringOperation;

        public void MakeFirstCharacterUppercase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                OnStringOperation?.Invoke(input, "Input string is empty.");
                return;
            }

            char[] charArray = input.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
                string result = new string(charArray);
                OnStringOperation?.Invoke(input, result);
            }
            else
            {
                OnStringOperation?.Invoke(input, "First character is already uppercase.");
            }
        }
    }
}