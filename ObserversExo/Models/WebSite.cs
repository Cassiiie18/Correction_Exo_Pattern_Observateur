using ObserversExo.Enums;
using ObserversExo.Events;
using ObserversExo.Interfaces;

namespace ObserversExo.Models;

public class WebSite : ISubject
{
    public Action<ISubject, MailEventArgs> Subscribes { get; set; }

    public void AddSubscribe(IObserver observer, MailNotificationType type = MailNotificationType.News)
    {
        Subscribes += observer.Update;
    }

    public void RemoveSubscribe(IObserver observer, MailNotificationType type = MailNotificationType.News)
    {
        Subscribes -= observer.Update;
    }

    public void Notify(MailNotificationType type = MailNotificationType.News)
    {
        Subscribes?.Invoke(this, new MailEventArgs(MailNotificationType.News, "News"));
    }
}