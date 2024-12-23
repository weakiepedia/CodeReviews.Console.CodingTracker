using System.Globalization;
using Spectre.Console;

namespace weakiepedia.CodingTracker;

internal class TimeHelper
{
    internal static DateTime GetUserTimeManually(string text, int number)
    {
        AnsiConsole.Markup(text);
        
        while (true)
        {
            string userInput = Console.ReadLine();
            
            try
            {
                DateTime userTime = DateTime.ParseExact(userInput, "HH:mm", new CultureInfo("en-US"));
                return userTime;
            }
            catch (Exception ex)
            {
                AnsiConsole.Markup("Wrong time format, please try again: ");
            }
        }
    }
    
    internal static string CalculateDuration(DateTime startTime, DateTime endTime)
    {   
        var diff = endTime.Subtract(startTime);
        return String.Format("{0:D2}:{1:D2}", diff.Hours, diff.Minutes);
    }
}