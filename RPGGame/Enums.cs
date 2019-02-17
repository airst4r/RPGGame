using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Enums
    {
        /*Цветовая индикация редкости оружия*/
        public enum RareGenerator
        {
            white=0,
            green=50,
            blue=75,
            orange=90,
            red=95,
            violet=100
        }
        

        //Перечисление преффиксов, доступных оружию
        public enum UniquePrefWep
        {
            Quickest=1,     //Самый быстрый
            Strongest=2,    //Самый сильный
            Smashing=3,     //Разящий
            Caustic=4,      //Колкий
            Precision=5     //Точный

        }

        //Перечисление преффиксов, доступных доспехам
        public enum UniquePerfArm
        {
            Impenetrable=1,         //Непробиваемый
            Dodgy=2,                //Изворотливый
            ScourgeOfMagicians=3,   //Бич магов
            Durable=4,              //Прочный
            Tenacious=5             //Живучий

        }
    }
}
