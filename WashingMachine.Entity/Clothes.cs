using System;

namespace WashingMachine.Entity
{
    public class Clothes
    {
        public int IdClothes { get; set; }
        public TypeOfClothing TypeOfClothingInWashingTime { get; private set; }
        public TypeOfClothing InitialTypeOfClothing { get; private set; }

        public Clothes(int idTypeOfClothing)
        {
            InitialTypeOfClothing = setTypeClothes(idTypeOfClothing);
            TypeOfClothingInWashingTime = InitialTypeOfClothing;
        }

        public void setTypeOfClothingInWashingTime(int IdTypeOfClothing)
        {
            TypeOfClothingInWashingTime = setTypeClothes(IdTypeOfClothing);
        }

        private DateTime getWashingTmeForClothing(TypeOfClothing typeOfClothing)
        {
            DateTime time = new DateTime();

            switch (typeOfClothing)
            {
                case TypeOfClothing.Clean:
                   time = time.AddMinutes(1);
                    break;

                case TypeOfClothing.VeryDirty:
                    time = time.AddMinutes(10);
                    break;

                case TypeOfClothing.SlightlyDirty:
                    time = time.AddMinutes(3);
                    break;

                case TypeOfClothing.Dirty:
                    time = time.AddMinutes(6);
                    break;

                default:
                    time = time.AddMinutes(0);
                    break;
            }

            return time;
        }

        public TypeOfClothing setTypeClothes(int idTypeOfClothing)
        {
            return (Enum.IsDefined(typeof(TypeOfClothing), idTypeOfClothing)) ? ((TypeOfClothing)idTypeOfClothing) : ((TypeOfClothing)6);
        }



        public string getWashingTimeForTypeOfClothingInWashingTimeString()
        {
            return getTimeFormatString(getWashingTmeForClothing(TypeOfClothingInWashingTime));
        }

        public DateTime getWashingTimeForTypeOfClothingInWashingTimeDateTime()
        {
            return getWashingTmeForClothing(TypeOfClothingInWashingTime);
        }

        public DateTime getWashingTimeForInitialTypeOfClothingDateTime()
        {
            return getWashingTmeForClothing(InitialTypeOfClothing);
        }

        public string getWashingTimeForInitialTypeOfClothingString()
        {
            return getTimeFormatString(getWashingTmeForClothing(InitialTypeOfClothing));
        }

        public string getTimeFormatString(DateTime time)
        {
           return String.Concat("00:" + getTimeFormat(time.Minute) + ":" + getTimeFormat(time.Second) + " min");
        }

        public string getTimeFormat(int num)
        {
            string formatTime = "";

            if (num < 10) { formatTime = string.Concat("0" + num); } else { formatTime = Convert.ToString(num); }

            return formatTime;
        }
    }
}
