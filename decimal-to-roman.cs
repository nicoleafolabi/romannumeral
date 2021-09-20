namespace romannumeral
{
    class Convertor
    { 
       public static string toRoman(int number){
            string result = ""; 
            if (number < 4){
                for (int i = 0; i < number; i++){
                    result += "I";
                }
            }
            else if (number == 4){
                result += "IV";
            }
            else if (number <9){
                result += "V";
                for (int i = 5; i < number; i++){
                    result += "I";
                }
            }
            else {
                result += "IX";
            }
            return result;
        }
    }
}
