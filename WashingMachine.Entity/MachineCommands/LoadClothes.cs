using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class LoadClothes: Command
    {
        public Washingmachine Machine { get; set; }

        public LoadClothes(Washingmachine machine)
        {
            Machine = machine;
        }

        public void SetWashingMachine(Washingmachine machine)
        {
            Machine = machine;
        }

        public override void Execute(string value)
        {   
            Machine.LoadClothes(int.Parse(value));
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override Task ExecuteAsync()
        {
            throw new NotImplementedException();
        }

        public override Task ExecuteAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
}
