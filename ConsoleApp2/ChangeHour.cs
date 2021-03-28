using System;

namespace Akcesory
{
    class Hours
    {
        private int hour; // ta zmienna posiada właściwość
        private int hourPM;
        private int exception;
        //private int second;
        

        public int Hour // Definicja właściwość
        {
            get { return hour; }
            set
            {
                Console.WriteLine("Godzina pocz" + hour + "Value pocz: " + value);
                
                if (value >= 13 && value <=23)
                {
                    hour = value;
                    hourPM = value%12;

                }else if (value >=0 && value < 11)
                {
                    hour = value;
                 
                }else if (value == 12)
                {
                    hour = value;
                 
                }else if (value == 24)
                {
                    hour = value;
                    exception = value % 12;
                }
                else
                {
                    hour = -1;
                }
            }
        }

        
        public override string ToString()
        {
            if (hour >= 0 && hour <= 11)
             {
                 return "Godzina: " + hour + "AM";
             }
             else if (hour >= 13 && hour <= 23)
             {
                 return "Godzina: " + hourPM + "PM";
             }
             else if (hour == 12)
             {
                 return "Godzina: " + hour + "PM";
             }
             else if (hour == 24)
             {
                 return "Godzina: " + exception + "AM";
             }
 
             return "Dotarłeś do końca wszechświata";
        }
    }
}