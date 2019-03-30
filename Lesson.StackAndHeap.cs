using System;

namespace ConsoleApp7
{
    public partial class Lesson
    {   
        public static void FloatTypeExample()
        {
            var number1 = 0.1;
            var number2 = 0.7;

            var result = Math.Floor((number1 + number2) * 10);
        }

        public static void StackAndHeapExample()
        {
            bool    hasPhoto = true;
            int     adultAge = 18;
            int     age = 18;

            string  name = "Olga";
            string  surname = "Pupkina";
            string  address = "Минск, Кропоткина 55, оф. 50";

            string  workingAddress = address;
        }

        public static void TypeFromConvertExample()
        {
            string flat = "34";

            char sex = 'М';

            double percent = 75.5;
            

            int weight = 55;
            double doubleWeith = weight;


            int intPrecent = (int)percent;
        }

        public static void TypeToConvertExample()
        {
            int flat = 34;

            string sex = "М";

            int percent = 75;

            double weight = 55.0f;
        }

        public static void TypeConvertExample()
        {
            string flat = "34";
            char sex = 'М';
            double percent = 75.5;
            int weight = 55;

            int flat2;
            string sex2;
            int precent2;
            double weight2;

            //TODO: Do converting.
        }
    }
}
