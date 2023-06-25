

public class CallData
{
    private string input;
    private string sysMsg;

    public CallData(string sysMsg, string input) { this.input = input; this.sysMsg = sysMsg; }
    public override string ToString() { return input; }
}

public class CallDataChoices
{
    public static readonly CallData orderByRelevance = new("You are a helpful assistant specializing in text analysis.", "Order this list by relevance. Each item goes into a new line.");
    public static readonly CallData orderByTime = new("You are a helpful assistant specializing in text analysis.", "Order this list by order of execution. Each item goes into a new line.");
    public static readonly CallData summarize = new("You are a helpful assistant specializing in text analysis.", "Summarize this list. Each item has a summary of one sentence and goes into a new line.");
    public static readonly CallData rephrase = new("You are a helpful assistant specializing in text analysis.", "Rephrase this list. Use more appropriate words, make it easier to understand. Each item goes into a new line.");

}

public class PromptBuilder
{
    public static string buildPrompt(string input, CallData instruction)
    {
        return input + "\n\n" + instruction.ToString();
    }

    public static string[] splitOutput(string output)
    {
        return output.Split("\n");
    }
}