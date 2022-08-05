using System.CommandLine;

namespace Snmp
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            var initializer = new CommandLine.Initializer();
            var rootCommand = initializer.Initialize();

            return await rootCommand.InvokeAsync(args);
        }
    }
}