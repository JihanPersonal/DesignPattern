using System;

namespace ObserverPattern
{
    public interface ISubject
    {
        void UpdateStatus();
        void NotifyObservers();
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
    }
}
