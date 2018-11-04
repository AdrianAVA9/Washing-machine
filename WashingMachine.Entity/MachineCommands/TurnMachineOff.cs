using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class TurnMachineOff: Command
    {
        public Washingmachine Machine { get; set; }

        public TurnMachineOff(Washingmachine machine)
        {
            Machine = machine;
        }

        public void SetWashingMachine(Washingmachine machine)
        {
            Machine = machine;
        }

        public override void Execute()
        {
            Machine.TurnMachineOff();
        }

        public override void Execute(string value)
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
