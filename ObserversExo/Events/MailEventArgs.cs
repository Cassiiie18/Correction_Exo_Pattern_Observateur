using ObserversExo.Enums;

namespace ObserversExo.Events;

public class MailEventArgs : EventArgs
{
    public MailEventArgs(MailNotificationType type, string message)
    {
        Type = type;
        Message = message;
    }

    public MailNotificationType Type { get; set; }
    
    public string Message { get; set; }
    
    
}