using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral
{
    public class ObserverPattern
    {
        public ObserverPattern()
        {
            IObserver observer1 = new Observer();
            IObserver observer2 = new Observer();
            IObserver observer3 = new Observer();
            IObserver observer4 = new Observer();
            IObserver observer5 = new Observer();   

            IObservable observable = new Observable();
            observable.Add(observer1);
            observable.Add(observer2);
            observable.Add(observer3);
            observable.Add(observer4);
            observable.SetData(100);
            observable.SetData(100);
            observable.Add(observer5);
            observable.SetData(400);
            observable.SetData(4000);
        }
    }

    public interface IObservable
    {
        void Add(IObserver observer);
        bool Remove(IObserver observer);
        void Notify();
        void SetData(int value);
    }

    public class Observable : IObservable
    {
        private List<IObserver> listObserver;
        private int value = 10;
        public Observable()
        {
            this.listObserver = new List<IObserver>();
        }
        public void Add(IObserver observer)
        {
            this.listObserver.Add(observer);
        }

        public bool Remove(IObserver observer)
        {
            return this.listObserver.Remove(observer);
        }

        public void SetData(int value)
        {
            if (this.value != value)
            {
                this.value = value;
                Notify();
            }
        }

        public void Notify()
        {
            if (listObserver.Any())
            {
                foreach (IObserver observer in listObserver)
                {
                    observer.Update(value);
                }
            }
        }
    }

    public interface IObserver
    {
        void Update(int data);
    }
    public class Observer : IObserver
    {
        public void Update(int data)
        {
            Console.WriteLine($"Updated value is {data} for {this.GetHashCode()}");
        }
    }

}
