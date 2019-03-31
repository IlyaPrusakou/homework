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
            //string StringSex = sex; // can not implicitly convert
            //string StringSexExpilictly = (string)sex; // can not convert
            string StringSexConvert = Convert.ToString(sex);
            Console.WriteLine(StringSexConvert); // "M"



            char place = '3';//to int
            int IntPlace = place;
            Console.WriteLine(IntPlace); //51
            int IntPlaceExp = (int)place;
            Console.WriteLine(IntPlaceExp); //51
            int IntPlaceConvert = Convert.ToInt32(place);
            Console.WriteLine(IntPlaceConvert); //51

            char hasFingerPrints = '0';//to boolean
                                       //bool FirngerBool = hasFingerPrints; // can not implicitly convert
                                       //bool FingerBoolExp = (bool)hasFingerPrints; // can not convert
                                       //bool FingerBoolConvert = Convert.ToBoolean(hasFingerPrints); //System.InvalidCastException



            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean]
            //bool PhotoBool = hasPhotoString; /can not convert
            //bool PhotoBoolExp = (bool)hasPhotoString; //can not convert
            bool PhotoBoolConvert = Convert.ToBoolean(hasPhotoString);
            Console.WriteLine(PhotoBoolConvert); // True

            string flatNumber = "34";//to int
            //int FlatNumberInt = flatNumber; // can not convert
            //int FlatNumberIntExp = (int)flatNumber; // can not convert
            int FlatNumberIntConvert = Convert.ToInt32(flatNumber);
            Console.WriteLine(FlatNumberIntConvert); // 34


            string visaPriceString = "34,23";//to float
            //float VisaFloat = visaPriceString; // can not convert
            //float VisaFloatExp = (float)visaPriceString; // can not convert
            float VisaFloatExpconvert = Convert.ToSingle(visaPriceString);
            Console.WriteLine(VisaFloatExpconvert); //34,23

            string photoPriceString = "7.23";//to float

            //float photoPriceFloat = photoPriceString; // can not convert
            //float photoPriceExp = (float)photoPriceString; // can not convert
            //float photoPriceConvert = Convert.ToSingle(photoPriceString); // неверный формат нужна запятая, а не точка!!!
            //Console.WriteLine(photoPriceConvert);
            string photoPriceFloatReplace = photoPriceString.Replace('.', ',');
            float replacePhotoPriceFloat = Convert.ToSingle(photoPriceFloatReplace);
            Console.WriteLine("заменили точку на запятую   " + replacePhotoPriceFloat); // 7,23

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int

            //to string
            //string freePages = hasFree2Pages; // can not convert
            //string freePagesExp = (string)hasFree2Pages; // can not convert
            string freePagesConvert = Convert.ToString(hasFree2Pages);
            Console.WriteLine(freePagesConvert); //False

            //to char
            //char freePagesChar = hasFree2Pages; // can not convert
            //char freePagesCharExp = (char)hasFree2Pages; // can not convert
            //char freePagesCharConvert = Convert.ToChar(hasFree2Pages); // invalid cast exception!!!
            //Console.WriteLine(freePagesCharConvert);

            // to int


            //int freePagesInt = hasFree2Pages; // can not convert
            //int freePagesIntExp = (int)hasFree2Pages; // can not convert
            int freePagesIntConvert = Convert.ToInt32(hasFree2Pages);
            Console.WriteLine(freePagesIntConvert); // 0

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string

            //to int
            //int visaPriceInt = visaPrice; // can not convert
            int visaPriceIntExp = (int)visaPrice;
            Console.WriteLine(visaPriceIntExp); // 60
            int visaPriceIntConvert = Convert.ToInt32(visaPrice);
            Console.WriteLine(visaPriceIntConvert); // 60

            // to string
            //string visaPriceImp = visaPrice; // can not convert
            //string visaPriceExp = (string)visaPrice; // can not convert
            string visaPriceConvert = Convert.ToString(visaPrice);
            Console.WriteLine("STRING   " + visaPriceConvert); // "60"

            double finterPrintsPrice = 55.2;//to int, to string

            //to int
            //int fingerInt = finterPrintsPrice; // can not convert
            int fingerIntExp = (int)finterPrintsPrice;
            Console.WriteLine("loose data " + fingerIntExp); //55 loose data
            int fingerIntConvert = Convert.ToInt32(finterPrintsPrice);
            Console.WriteLine("loose data " + fingerIntConvert); //55 loose data

            //to string

            //string fingerString = finterPrintsPrice; // can not convert
            //string fingerStringExp = (string)finterPrintsPrice; // can not convert
            string fingerStringConvert = Convert.ToString(finterPrintsPrice);
            Console.WriteLine(fingerStringConvert); // "55,2"


            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char

            // to string

            //string birthString = birthYear; // can not convert
            //string birthStringExp = (string)birthYear; // can not convert
            string birthStringConvert = Convert.ToString(birthYear);
            Console.WriteLine("STRING " + birthStringConvert); // "2000"

            //to double
            double birthDouble = birthYear;
            double birthDoubleExp = (double)birthYear;
            double birthDoubleConvert = Convert.ToDouble(birthYear);
            Console.WriteLine("all variants of conversion are ok ---- " + birthDouble + " " + birthDoubleExp + " " + birthDoubleConvert); // 2000 2000 2000

            //to char
            //char birtChar = birthYear; // can not convert
            char birthCharExp = (char)birthYear;
            char birthCharConvert = Convert.ToChar(birthYear);
            Console.WriteLine(birthCharExp + " " + birthCharConvert); // '?'  '?' double 2000 converts to '?'

            int hasPhotoInt = 1;//to boolean

            //bool hasPhotoBool = hasPhotoInt; // can not convert
            //bool hasPhotoBoolExp = (bool)hasPhotoInt; // can not convert
            bool hasPhotoBoolConvert = Convert.ToBoolean(hasPhotoInt);
            Console.WriteLine(hasPhotoBoolConvert); // true
        }
    }
}
