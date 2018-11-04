using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class LoadWater: Command
    {
        public Washingmachine Machine { get; set; }

        public LoadWater(Washingmachine machine)
        {
            Machine = machine;
        }

        public void SetWashingMachine(Washingmachine machine)
        {
            Machine = machine;
        }

        public override void Execute(string value)
        {
            throw new NotImplementedException();
        }

        public override async Task ExecuteAsync()
        {
            await Machine.LoadWaterAsync();
        }

        public override Task ExecuteAsync(string value)
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
