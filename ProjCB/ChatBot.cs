namespace ProjCB;

public class ChatBot
{
    public string SendMessage(string userMessage)
    {
        if((userMessage == null) || (userMessage.Length == 0)) {
            return "I cannot hear you?";
        } 
        if (userMessage.Contains("Hi"))
        {
            return "Hello";
        }
        if (userMessage.Contains("Hello"))
        {
            return "Hello";
        }
        if (userMessage.Contains("Whats your name"))
        {
            return "My Name is Siri";
        }
        return "Sorry I don't understand your question";
    }

}
