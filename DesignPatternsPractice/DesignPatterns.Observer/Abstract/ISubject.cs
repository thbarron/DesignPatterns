using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Abstract
{
    public interface ISubject
    {
        void RegisterObserver();

        void RemoveObserver();

        void NotifyObservers();

    }
}
