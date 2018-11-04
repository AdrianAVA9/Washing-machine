using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class PauseMachine: Command
    {
        public Washingmachine Machine { get; set; }

        public PauseMachine(Washingmachine machine)
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

        public async override Task ExecuteAsync()
        {
            await Machine.PauseMachine();
        }

        public override Task ExecuteAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
}
