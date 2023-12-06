using ObserversExo.Enums;
using ObserversExo.Events;
using ObserversExo.Interfaces;

namespace ObserversExo.Models;

public class Magazine : IDoubleSubject
{
    public Action<ISubject, MailEventArgs> Subscribes { get; set; }
    public void AddSubscribe(IObserver observer, MailNotificationType type)
    {
        switch (type)
        {
            case MailNotificationType.News:
               Subscribes += observer.Update; 
                break;
            case MailNotificationType.Ads:
                AdsSubscribes += observer.Update;
                break;
        }
        
    }

    public void RemoveSubscribe(IObserver observer, MailNotificationType type)
    {
        switch (type)
        {
            case MailNotificationType.News:
                Subscribes -= observer.Update; 
                break;
            case MailNotificationType.Ads:
                AdsSubscribes -= observer.Update;
                break;
        }
    }

    public void Notify(MailNotificationType type)
    {
        switch (type)
        {
            case MailNotificationType.News:
                Subscribes?.Invoke(this, new MailEventArgs(MailNotificationType.News, "News"));
                break;
            case MailNotificationType.Ads:
                AdsSubscribes?.Invoke(this, new MailEventArgs(MailNotificationType.Ads, "Ads"));
                break;
        }
        
    }

    public Action<ISubject, MailEventArgs> AdsSubscribes { get; set; }
   
}