using Spectre.Console;

namespace weakiepedia.CodingTracker;

internal class UserInterface
{
    private static string[] menuChoices = { "View all records", "View summary", "Insert a record", "Delete a record", "Update a record", "Exit" }; 
    internal static void Menu()
    {
        while (true)
        {
            Console.Clear();
            AnsiConsole.MarkupLine("[mediumspringgreen]CODING TRACKER[/]");
            var choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("What do you want to do?")
                .AddChoices(menuChoices)
                .HighlightStyle("aquamarine3"));

            switch (choice)
            {
                case "View all records":
                    DatabaseManager.ViewAllRecords();
                    PressAnyKey();
                    break;
                case "View summary":
                    DatabaseManager.ViewSummary();
                    PressAnyKey();
                    break;
                case "Insert a record":
                    DatabaseManager.InsertRecord();
                    PressAnyKey();
                    break;
                case "Delete a record":
                    DatabaseManager.DeleteRecord();
                    PressAnyKey();
                    break;
                case "Update a record":
                    DatabaseManager.UpdateRecord();
                    PressAnyKey();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }
    }
    

    internal static void PressAnyKey()
    {
        AnsiConsole.MarkupLine("[aquamarine1_1]Press any key to continue...[/]");
        Console.ReadKey();
    }
}