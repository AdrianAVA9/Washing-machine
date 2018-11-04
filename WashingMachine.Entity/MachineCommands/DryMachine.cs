using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class DryMachine: Command
    {
        public Washingmachine Machine { get; set; }

        public DryMachine(Washingmachine machine)
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

        public override async Task ExecuteAsync()
        {
            await Machine.Dry();
        }

        public override Task ExecuteAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
}
