namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }

    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void Execute()
        {
            _switchable.PowerOff();
        }
    }

    public class OpenSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void Execute()
        {
            _switchable.PowerOn();
        }
    }

    public class Switch
    {
        ICommand _closedCommand;
        ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            _closedCommand = closedCommand;
            _openedCommand = openedCommand;
        }

        public void Close()
        {
            _closedCommand.Execute();
        }

        public void Open()
        {
            _openedCommand.Execute();
        }
    }
}