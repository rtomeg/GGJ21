
using JetBrains.Annotations;

public class EventsManager
{
    public delegate void OnOpenExplorerPath(string path);
    public static OnOpenExplorerPath onOpenExplorerPath;

    public delegate void OnChatLine(string message, MyEnums.Interlocutor interlocutor);
    public static OnChatLine onChatLine;

    public delegate void OnCloseChat(params MyEnums.Interlocutor[] interlocutor);
    public static OnCloseChat onCloseChat;

}