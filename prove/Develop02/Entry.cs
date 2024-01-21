public class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public Entry(PromptGenerator promptGenerator)
    {
        DateTime currentDate = DateTime.Now;
        Date = currentDate.ToShortDateString();
        PromptText = promptGenerator.GetRandomPrompt();
        
        Console.WriteLine($"Prompt: {PromptText}");
        Console.Write("Your response: ");
        EntryText = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}\n");
    }
}
