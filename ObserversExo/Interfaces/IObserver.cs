using ObserversExo.Events;

namespace ObserversExo.Interfaces;

public interface IObserver
{
    public void Update(ISubject sender, MailEventArgs e);
}