using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    public abstract class Command
    {
        public abstract void Execute();

        public abstract void Execute(string value);

        public abstract Task ExecuteAsync();

        public abstract Task ExecuteAsync(string value);
    }
}
