using ObserversExo.Events;
using ObserversExo.Interfaces;

namespace ObserversExo.Models;

public class Client : IObserver
{
    public Client(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    
    public void Update(ISubject sender, MailEventArgs e)
    {
        Console.WriteLine($"{Name} à bien recu la notification {e.Type} : {e.Message}");
    }
}