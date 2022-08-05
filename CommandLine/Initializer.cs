using System.CommandLine;

namespace Snmp.CommandLine
{
    internal class Initializer
    {
        internal RootCommand Initialize()
        {
            var rootCommand = new RootCommand("A simple command-line snmp tool.");

            return rootCommand;
        }
    }
}
