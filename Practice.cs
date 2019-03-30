using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
            char hasFingerPrints = '0';//to boolean

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            string flatNumber = "34";//to int
            string visaPriceString = "34,23";//to float
            string photoPriceString = "7.23";//to float

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            double finterPrintsPrice = 55.2;//to int, to string

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            char birhtYearChar = (char)birthYear;

            int hasPhotoInt = 1;//to boolean
        }
    }
}
