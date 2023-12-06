using ObserversExo.Enums;
using ObserversExo.Events;

namespace ObserversExo.Interfaces;

public interface ISubject
{
    protected Action<ISubject, MailEventArgs> Subscribes { get; set; }

    public void AddSubscribe(IObserver observer, MailNotificationType type = MailNotificationType.News);

    public void RemoveSubscribe(IObserver observer, MailNotificationType type = MailNotificationType.News);

    public void Notify(MailNotificationType type = MailNotificationType.News);

}

public interface IDoubleSubject : ISubject
{
    protected Action<ISubject, MailEventArgs> AdsSubscribes { get; set; }
    
}