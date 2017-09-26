using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class InputTester
    {
        private char comma = ',';
        private char slash = '/';

        public bool IsItAInteger(string UserInput)
        {
            char[] inputArray = UserInput.ToCharArray();
            bool parsedInput = double.TryParse(UserInput, out double number);

            if (inputArray[0] == comma || inputArray[inputArray.Length - 1] == comma)
            {
                return false;
            }
            else
            {
                return parsedInput;
            }
            
        }
        public bool IsItADate(string UserInput)
        {
            CultureInfo culture;
            DateTimeStyles styles;

            // Settings for DateTime since my computers loclaization is in English format
            culture = CultureInfo.CreateSpecificCulture("fi-FI");
            styles = DateTimeStyles.None;
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            bool parsedInput = DateTime.TryParse(UserInput, culture, styles, out DateTime dateValue);
            char[] inputArray = UserInput.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == slash || inputArray[i] == comma)
                {
                    return false;
                }
            }
            return parsedInput;
        }
    }
}
