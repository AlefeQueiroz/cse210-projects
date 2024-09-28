public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What did you learn today?",
        "How did you overcome a challenge today?",
        "What made you smile today?",
        "Describe a moment today when you felt at peace.",
        "What is something new you'd like to try this week?",
        "How did you help someone today?",
        "What’s a goal you're currently working on and why?",
        "Write about a fear you faced today.",
        "What’s something you’re looking forward to tomorrow?",
        "What did you learn about yourself today?",
        "How did you practice kindness today?",
        "Describe a recent experience that made you feel proud.",
        "What’s one thing you would like to improve in your daily routine?",
        "What’s a small victory you achieved today?",
        "What is one thing you’re grateful for that you often take for granted?",
        "How did you make time for self-care today?",
        "What’s a challenge you faced today and how did you handle it?",
        "Write about someone who positively impacted your day.",
        "What’s a new perspective or idea you encountered today?"
    };

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
