using System;

namespace binaryConverter
{
    class binaryConverter
    {
        static void Main(string[] args)
        {
            string numberInput = "";
            bool numberType = false; // true = binary; false = decimal;

            string binaryNum ="";
            int decimalNum = 0;


            Console.WriteLine("Is your number in binary of decimal"
            + "(Type 1 for binary and anything else for decimal) ");
            numberInput = Console.ReadLine();
            
            if(numberInput.Equals("1"))
            {
                numberType = true;
            }

            if(numberType)
            {
                Console.WriteLine("Type in your binary number!");
                binaryNum = Console.ReadLine();
                decimalNum = BinaryStringToIntegar(binaryNum);
            }
            else
            {
                Console.WriteLine("Type in your decimal number!");
                string decimalString = Console.ReadLine();
                decimalNum = Convert.ToInt32(decimalString);
                binaryNum = DecimalIntToBinaryString(decimalNum);
            }


            Console.WriteLine("The decimal value is" + decimalNum);
            Console.WriteLine("The binary value is "+ binaryNum);

            Console.ReadKey();
        }

        private static int BinaryStringToIntegar(string binaryValue)
        {
            string binValue = binaryValue;
            int decimalvalue = 0;
            
            for(int i = 0; i < binValue.Length; i++)
            {
                decimalvalue +=  Int32.Parse(binValue[i].ToString()) * Convert.ToInt32(MathF.Pow(2, binValue.Length - 1 - i));
            }
            return decimalvalue;
        }

        private static string DecimalIntToBinaryString(int decimalvalue)
        {
            int decimalnum = decimalvalue;
            string output = "";

            while(decimalnum > 1)
            {
                if(decimalnum % 2 == 1)
                {
                    output = "1" + output;
                    decimalnum = decimalnum/2;
                }
                else
                {
                    output = "0" + output;
                    decimalnum = decimalnum/2;
                }
            }
            
            if(decimalnum == 1)
            {
                output = "1" + output;
            }
            else if(decimalnum == 0)
            {
                output = "0" + output;
            }

            return output;
        }

        
    }
}
