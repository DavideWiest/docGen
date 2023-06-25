using OpenAI_API;

public class openaiChat {
    public static OpenAIAPI api = new(APIAuthentication.LoadFromEnv());


    public static OpenAI_API.Chat.Conversation getStreamingChat(string systemMsg, string userMsg) {
        var chat = api.Chat.CreateConversation();
        chat.AppendSystemMessage(systemMsg);
        chat.AppendUserInput(userMsg);
        return chat;
    }

    public static string getResponse(string systemMsg, string userMsg) {
        var chat = getStreamingChat(systemMsg, userMsg);
        return chat.GetResponseFromChatbotAsync().Result;
    }

}