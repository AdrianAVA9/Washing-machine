using System;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class ClientMachine
    {
        private Command turnOn;
        private Command turnOff;
        private Command LoadDetergent;
        private Command Dry;
        private Command StarWashing;
        private Command PauseMachine;
        private Command LoadClothes;
        private Command LoadWater;
        private MachineControl _invoker;
        public static ClientMachine Client;

        public static ClientMachine getClientAndInitializeItsAtributes(Washingmachine machine)
        {
            if (Client == null){ Client = new ClientMachine(machine); }else{ Client.SetMachine(machine); }
            return Client;
        }

        public ClientMachine(Washingmachine machine)
        {
            turnOn = new TurnMachineOn(machine);
            turnOff = new TurnMachineOff(machine);
            LoadDetergent = new LoadDetergent(machine);
            Dry = new DryMachine(machine);
            StarWashing = new StartWashing(machine);
            PauseMachine = new PauseMachine(machine);
            LoadClothes = new LoadClothes(machine);
            LoadWater = new LoadWater(machine);
            _invoker = new MachineControl();

        }

        public void SetMachine(Washingmachine machine)
        {
            ((TurnMachineOn)turnOn).SetWashingMachine(machine);
            ((TurnMachineOff)turnOff).SetWashingMachine(machine);
            ((LoadDetergent)LoadDetergent).SetWashingMachine(machine);
            ((DryMachine)Dry).SetWashingMachine(machine);
            ((StartWashing)StarWashing).SetWashingMachine(machine);
            ((LoadClothes)LoadClothes).SetWashingMachine(machine);
            ((PauseMachine)PauseMachine).SetWashingMachine(machine);
            ((LoadWater)LoadWater).SetWashingMachine(machine);
        }

        public async Task ExecuteCommandAsync(string cmd)
        {
            switch (cmd)
            {
                case "DRY":
                    _invoker.SetCommand(Dry);
                    break;

                case "LOADWATER":
                    _invoker.SetCommand(LoadWater);
                    break;

                case "PAUSE":
                    _invoker.SetCommand(PauseMachine);
                    break;

                default:
                    throw new Exception("The requested command is undefined");
            }
            await _invoker.ExecuteCommandAsync();
        }

        public async Task ExecuteCommandAsync(string cmd, string value)
        {
            switch (cmd)
            {
                case "STARTWASHING":
                    _invoker.SetCommand(StarWashing);
                    break;

                default:
                    throw new Exception("The requested command is undefined");
            }
            await _invoker.ExecuteCommandAsync(value);
        }

        public void ExecuteCommand(string cmd, string value)
        {
            switch (cmd)
            {
                case "LOADCLOTHES":
                    _invoker.SetCommand(LoadClothes);
                    break;

                default:
                    throw new Exception("Invalid command");
            }

            _invoker.ExecuteCommand(value);
        }

        public void ExecuteCommand(string cmd)
        {
            switch (cmd)
            {
                case "ON":
                    _invoker.SetCommand(turnOn);
                    break;

                case "OFF":
                    _invoker.SetCommand(turnOff);
                    break;

                case "LOADDETERGENT":
                    _invoker.SetCommand(LoadDetergent);
                    break;

                case "LOADCLOTHES":
                    _invoker.SetCommand(LoadClothes);
                    break;
                default:
                    throw new Exception("Invalid command");
                    
            }

            _invoker.ExecuteCommand();
        }
    }
}
