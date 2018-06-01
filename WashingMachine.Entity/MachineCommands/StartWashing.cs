using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class StartWashing: Command
    {
        public Washingmachine Machine { get; set; }

        public StartWashing(Washingmachine machine)
        {
            Machine = machine;
        }

        public void SetWashingMachine(Washingmachine machine)
        {
            Machine = machine;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override void Execute(string value)
        {
            throw new NotImplementedException();
        }

        public override Task ExecuteAsync()
        {
            throw new NotImplementedException();
        }

        public override async Task ExecuteAsync(string value)
        {
            await Machine.ToWash(value);
        }
    }
}
