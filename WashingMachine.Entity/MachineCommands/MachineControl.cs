using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public class MachineControl
    {
        public Command _Command { get; set; }

        public MachineControl(){ }

        public MachineControl(Command command)
        {
            _Command = command;
        }

        public void SetCommand(Command command)
        {
            _Command = command;
        }

        public void ExecuteCommand(string value)
        {
            _Command.Execute(value);
        }

        public void ExecuteCommand()
        {
            _Command.Execute();
        }

        public async Task ExecuteCommandAsync()
        {
            await _Command.ExecuteAsync();
        }

        public async Task ExecuteCommandAsync(string value)
        {
            await _Command.ExecuteAsync(value);
        }
    }
}
