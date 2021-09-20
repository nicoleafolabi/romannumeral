using System;
using System.Collections.Generic;

namespace romannumeral
{
    class Convertor
    {
        public static string toRoman(int number)
        {
            string result = "";

                if(number>3999){
                    return result ="Error: Cannot convert numbers greater than 3999";
                }

                if(number<=0){
                    return result ="Error: Cannot convert numbers less than or equal to 0";
                }
            string numString = number.ToString();

            int digitCount = numString.Length;

            // do this for every digit in the number
            for (int j = 0; j < digitCount; j++)
            {
                // convert char to number
                int digitAtIndex = numString[j] - '0';
                int digitPower = digitCount - j - 1;

                // don't count zeroes
                if (digitAtIndex != 0)
                {
                    if (digitPower == 3) // between 1000-9999 (10 ^ 3 = thousands place)
                    {
                        if (digitAtIndex < 4) // 1-3 (thousands)
                        {
                            for (int i = 0; i < digitAtIndex; i++)
                            {
                                result += "M";
                            }
                        }
                    }
                    else if (digitPower == 2) // between 100-999 (10 ^ 2 = hundreds place)
                    {
                        if (digitAtIndex < 4) // 1-3 (hundreds)
                        {
                            for (int i = 0; i < digitAtIndex; i++)
                            {
                                result += "C";
                            }
                        }
                        else if (digitAtIndex == 4) // 4 (hundreds)
                        {
                            result += "CD";
                        }
                        else if (digitAtIndex < 9) // 5-8 (hundreds)
                        {
                            result += "D";

                            for (int i = 5; i < digitAtIndex; i++)
                            {
                                result += "C";
                            }
                        }
                        else // 9 (hundreds)
                        {
                            result += "CM";
                        }
                    }
                    else if (digitPower == 1) // between 10-99 (10 ^ 1 = tens place)
                    {
                        if (digitAtIndex < 4) // 1-3 (tens)
                        {
                            for (int i = 0; i < digitAtIndex; i++)
                            {
                                result += "X";
                            }
                        }
                        else if (digitAtIndex == 4) // 4 (tens)
                        {
                            result += "XL";
                        }
                        else if (digitAtIndex < 9) // 5-8 (tens)
                        {
                            result += "L";

                            for (int i = 5; i < digitAtIndex; i++)
                            {
                                result += "X";
                            }
                        }
                        else // 9 (tens)
                        {
                            result += "XC";
                        }
                    }
                    else if (digitPower == 0) // between 1-10 (10 ^ 0 = one place)
                    {
                        if (digitAtIndex < 4) // 1-3 (ones)
                        {
                            for (int i = 0; i < digitAtIndex; i++)
                            {
                                result += "I";
                            }
                        }
                        else if (digitAtIndex == 4) // 4 (ones)
                        {
                            result += "IV";
                        }
                        else if (digitAtIndex < 9) // 5-8 (ones)
                        {
                            result += "V";

                            for (int i = 5; i < digitAtIndex; i++)
                            {
                                result += "I";
                            }
                        }
                        else // 9 (ones)
                        {
                            result += "IX";
                        }
                    }
                }
            }

            return result;
        }

        public static int toInteger(string romanNum)
        {
            int result = 0;

            for (int i = 0; i < romanNum.Length; i++)
            {
                if (romanNum[i] == 'I') // 1-3
                {
                    result += 1;
                }
                else if (romanNum[i] == 'V') // 4-8
                {
                    if (i > 0 && romanNum[i - 1] == 'I')
                    {
                        result -= 2;
                    }

                    result += 5;
                }
                else if (romanNum[i] == 'X') // 9-30
                {
                    if (i > 0 && romanNum[i - 1] == 'I')
                    {
                        result -= 2;
                    }

                    result += 10;
                }
                else if (romanNum[i] == 'L') // 40-80
                {
                    if (i > 0 && romanNum[i - 1] == 'X')
                    {
                        result -= 20;
                    }

                    result += 50;
                }
                else if (romanNum[i] == 'C') // 90-300
                {
                    if (i > 0 && romanNum[i - 1] == 'X')
                    {
                        result -= 20;
                    }

                    result += 100;
                }
                else if (romanNum[i] == 'D') // 400-800
                {
                    if (i > 0 && romanNum[i - 1] == 'C')
                    {
                        result -= 200;
                    }

                    result += 500;
                }
                else if (romanNum[i] == 'M') // 900+
                {
                    if (i > 0 && romanNum[i - 1] == 'C')
                    {
                        result -= 200;
                    }

                    result += 1000;
                }
            }

            return result;
        }
    }
}
