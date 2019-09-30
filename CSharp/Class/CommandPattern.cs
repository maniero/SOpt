using static System.Console;

namespace CommandPattern {    
    public interface ICommand {
        void Execute();
    }
    /* The Invoker class */
    public class Switch {
        ICommand closedCommand;
        ICommand openedCommand;
        public Switch(ICommand closedCommand, ICommand openedCommand) {
            this.closedCommand = closedCommand;
            this.openedCommand = openedCommand;
        }
        // Close the circuit / power on
        public void Close() => this.closedCommand.Execute();
        // Open the circuit / power off
        public void Open() => this.openedCommand.Execute();
    }
    /* An interface that defines actions that the receiver can perform */
    public interface ISwitchable {
        void PowerOn();
        void PowerOff();
    }
    /* The Receiver class */
    public class Light : ISwitchable {
        public void PowerOn() => WriteLine("The light is on");
        public void PowerOff() => WriteLine("The light is off");
    }
    /* The Command for turning off the device - ConcreteCommand #1 */
    public class CloseSwitchCommand : ICommand {
        private ISwitchable switchable;
        public CloseSwitchCommand(ISwitchable switchable) this.switchable = switchable;
        public void Execute() => switchable.PowerOff();
    }
    /* The Command for turning on the device - ConcreteCommand #2 */
    public class OpenSwitchCommand : ICommand {
        private ISwitchable switchable;
        public OpenSwitchCommand(ISwitchable switchable) this.switchable = switchable;
        public void Execute() => switchable.PowerOn();
    }
    /* The test class or client */
    internal class Program {
        public static void Main() {
            string argument = arguments.Length > 0 ? arguments[0].ToUpper() : null;
            ISwitchable lamp = new Light();
            // Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);
            // Pass reference to instances of the Command objects to the switch
            var @switch = new Switch(switchClose, switchOpen);
            // Switch (the Invoker) will invoke Execute() on the command object.
            if (argument == "ON") @switch.Open();
            else if (argument == "OFF") @switch.Close();
            else WriteLine("Argument \"ON\" or \"OFF\" is required.");
        }
    }
}

//https://pt.stackoverflow.com/q/412838/101
