using Microsoft.Extensions.Configuration;
using Spectre.Console;

namespace weakiepedia.CodingTracker;
    
public class Program
{
    static void Main(string[] args)
    {
        DatabaseManager.CreateTableIfNotExists();
        UserInterface.Menu();
    }
}
