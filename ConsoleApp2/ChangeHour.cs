using System;

namespace Akcesory
{
    class Hours
    {
        private int hour; // ta zmienna posiada właściwość
        private int second;
        

        public int Hour // Definicja właściwość
        {
            get { return hour; }
            set
            {
                if (value >= 0 && value <= 24)
                {
                    hour = value;
                    second = value * 3600;
                }
            }
        }

        public string Info()
        {
            return "Godzina " + hour + ". " + second +
                   "  sekunda tej doby.";
        }
    }
}