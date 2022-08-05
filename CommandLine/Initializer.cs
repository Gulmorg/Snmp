using System.CommandLine;

namespace Snmp.CommandLine
{
    internal class Initializer
    {
        private readonly Command _walkCommand;

        public Initializer()
        {
            #region Commands
            _walkCommand = new Command("walk", "Walk the specified snmp target");
            #endregion

            #region Handlers
            _walkCommand.SetHandler(() => {
                HandlerActions.Walk();
            });
            #endregion
        }

        internal RootCommand Initialize()
        {
            var rootCommand = new RootCommand("A simple command-line snmp tool."){
                _walkCommand,
            };

            return rootCommand;
        }
    }
}
