using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class Washingmachine
    {
        public static int NumMachinesCreated { get; private set; } = 0;
        private int IdMachine { get; set; }
        public int MaxWaterLevel { get; private set; }
        public int MinWaterLevel { get; private set; }
        public int MachineWaterLevel { get; set; }
        public bool WaterSupply { get; private set; }
        public bool TurnOn { get; private set; }
        public const string Model = "Machine";
        public bool Detergent { get; set; }
        public string SerialNumber { get { return String.Concat(Model + "-" + IdMachine); } }
        public Clothes Clothes { get; set; }
        public bool _Motor { get; private set; }
        public DateTime WashingTimeEnterByUser { get; set; }
        private DateTime InternalTimer { get; set; }

        public Washingmachine()
        {
            NumMachinesCreated++;
            IdMachine = NumMachinesCreated;
            MachineWaterLevel = 0;
            MaxWaterLevel = 100;
            MinWaterLevel = 70;
            TurnOn = false;
            Detergent = false;
            WaterSupply = false;
            _Motor = false;
            Clothes = null;
        }

        public void LoadClothes(int idTypeClothes)
        {

            if (_Motor)
                throw new Exception("it is imposible try to change the clothes because the machine is working");

            Clothes = new Clothes(idTypeClothes);
        }

        public void TurnMachineOn()
        {
            TurnOn = true;
        }

        public void TurnMachineOff()
        {
            if (_Motor)
                throw new Exception("You can not turn off the machine because it is washing");

            TurnOn = false;
        }

        public void LoadDetergent()
        {
            Detergent = true;
        }

        public async Task LoadWaterAsync()
        {
            if (MachineWaterLevel < MaxWaterLevel)
            {
                TurnOnWaterSupply();
                await LoadingWaterAsync();
            }
            else
            {
                throw new Exception("The washing - machine is on its maximun water level");
            }
        }

        public void TurnOnWaterSupply()
        {
            WaterSupply = true;
        }

        private async Task LoadingWaterAsync()
        {
            while (WaterSupply)
            {
                await Task.Delay(250).ContinueWith((task) =>
                {
                    if (MachineWaterLevel < MaxWaterLevel)
                    {
                        MachineWaterLevel += 5;
                    }
                    else
                    {
                        TurnOffWaterSupply();
                    }
                });
            }
        }

        public void TurnOffWaterSupply()
        {
            WaterSupply = false;
        }

        public async Task ToWash(string time)
        {
            if (DateTime.TryParse(time, out DateTime timer))
                WashingTimeEnterByUser = timer;
            else
                throw new Exception("Upss!, There is a issue with the system, at the moment to try parse the time");

            IsTheMachineReadyToWash();
            SetUpMachine();
            await StartWashing();
        }

        public void IsTheMachineReadyToWash()
        {
            if (!TurnOn)
                throw new Exception("Please, Before starting to wash turn on the washing-machine");

            if (Clothes == null)
                throw new Exception("You have not selected the type of clothing");

            if (MachineWaterLevel < MinWaterLevel)
                throw new Exception("Please, Before starting to wash, make sure you the level water is on its minimum (70%)");

            if (WashingTimeEnterByUser.Minute < Clothes.getWashingTimeForInitialTypeOfClothingDateTime().Minute)
                throw new Exception("Please, Before starting to wash, make sure you enter the minimum time");

            if (Clothes.InitialTypeOfClothing != TypeOfClothing.Clean && !Detergent)
                throw new Exception("You have not loaded detergent");
        }

        public void SetUpMachine()
        {
            InternalTimer = DateTime.Today;
            _Motor = true;
        }

        public async Task StartWashing()
        {
            int secondsInWashingTime = 60;
            int minutes = InternalTimer.Minute;

            for (minutes = InternalTimer.Minute; minutes <= WashingTimeEnterByUser.Minute && _Motor; minutes++)
            {
                if (minutes == WashingTimeEnterByUser.Minute)
                    secondsInWashingTime = WashingTimeEnterByUser.Second;

                SetTypeOfClothing(minutes);

                for (int seconds = InternalTimer.Second; seconds < secondsInWashingTime && _Motor; seconds++)
                {
                    await Task.Delay(250).ContinueWith((task) =>
                    {
                        InternalTimer = InternalTimer.AddSeconds(1);
                    });
                }
            }

            SetTypeOfClothing(minutes);

            if (_Motor)
                _Motor = false;
        }

        private int GetTimeFromTheNewChangeOfClothesType(int minuteElpased)
        {
            DateTime InitialTime = Clothes.getWashingTimeForInitialTypeOfClothingDateTime();

            return (Clothes.InitialTypeOfClothing == Clothes.TypeOfClothingInWashingTime) ? minuteElpased : (InitialTime.Minute - minuteElpased);
        }

        private void SetTypeOfClothing(int minuteElapsed)
        {
            TypeOfClothing clothing = Clothes.TypeOfClothingInWashingTime;
            int timeElapsed = GetTimeFromTheNewChangeOfClothesType(minuteElapsed);
            int timeNecessary = 0;
            int ClothesId = 0;

            switch (clothing)
            {
                case TypeOfClothing.Clean:
                    timeNecessary = 0;
                    ClothesId = 5;
                    break;

                case TypeOfClothing.SlightlyDirty:
                    timeNecessary = 2;
                    ClothesId = 1;
                    break;

                case TypeOfClothing.Dirty:
                    timeNecessary = 3;
                    ClothesId = 2;
                    break;

                case TypeOfClothing.VeryDirty:
                    timeNecessary = 4;
                    ClothesId = 3;
                    break;
            }

            if (timeElapsed == timeNecessary)
            {
                Clothes.setTypeOfClothingInWashingTime(ClothesId);
            }
        }

        public async Task PauseMachine()
        {
            if (_Motor)
            {
                _Motor = false;
            }
            else
            {
                _Motor = true;
                IsTheMachineReadyToWash();
                await StartWashing();
            }
        }

        public async Task Dry()
        {
            if (_Motor)
                throw new Exception("You can not drain the machine because it is washing");

            while (MachineWaterLevel > 0)
            {
                await Task.Delay(1000).ContinueWith((task) =>
                {
                    MachineWaterLevel -= 5;
                });
            }

            resetMachine();
        }

        private void resetMachine()
        {
            Clothes = null;
            Detergent = false;
            InternalTimer = DateTime.Today;

        }

        public string ShowInitialTimeOfWashing()
        {
            return GetStringFormatOfDateTime(WashingTimeEnterByUser);
        }

        public string ShowStatusOfWashing()
        {
            return GetStringFormatOfDateTime(InternalTimer);
        }

        public string GetStringFormatOfDateTime(DateTime dateTime)
        {
            string formatDateTime = "00:00:00";

            if (Clothes != null)
                if (dateTime != null)
                    formatDateTime = Clothes.getTimeFormatString(dateTime);

            return formatDateTime;
        }

        public override string ToString()
        {
            string message = "";

            message = string.Format(
                "Id_Machine: {0}\nModel: {1} \nSerial Number: {2}\nTimer: {3}\nWater level: {4}\nDetergent: {5}\nTurn on: {6}\n"
                , this.IdMachine, Model, this.SerialNumber, this.ShowStatusOfWashing(), this.MachineWaterLevel,
                this.Detergent, this.TurnOn);

            return message;
        }
    }
}
