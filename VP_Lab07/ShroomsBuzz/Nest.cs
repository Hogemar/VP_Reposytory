using System.Collections;
using System.Xml.Linq;

namespace ShroomsBuzz
{
    public delegate void ShroomsEventHandler();

    public class Nest
    {
        ///*/*/*//*/*/*/* КАК ПРАВИЛЬНО РАЗДЕЛЯТЬ УЧАСТКИ КЛАССА? */**/*//*//*/*///

        //Количество грибов
        private int _stash;//new Random().Next(1, 50);

        //Коллекция грибников на поляне
        private ArrayList _dopers = new();

        // Событие – кончились грибочки
        public event ShroomsEventHandler? OnStashOver;

        // Конструктор без аргументов
        public Nest()
        {
            _stash = 31;
        }

        // Конструктор с количеством грибов
        public Nest(int stashAmount)
        {
            if (stashAmount < 0) throw new Exception("Invalid stash amount!");
            _stash = stashAmount;
        }

        // Принять грибника на поляну
        public void AdmitDoper(Doper doper)
        {
            //if (_stash <= 0)
            //    return false;

            if (_dopers.Contains(doper)) return;

            _dopers.Add(doper);
            OnStashOver += doper.LeaveNest;

            Console.WriteLine($"> На поляну пришёл грибник {doper.Name}. В данный момент на поляне {_stash} грибов.");

            //return true;
        }

        // Отдать грибнику грибочки
        public int DeliverDope(Doper doper, int amount)
        {
            if (amount <= 0) throw new Exception("Invalid dope amount!");

            if(_stash <= amount)
                amount = _stash;

            _stash -= amount;

            Console.WriteLine($"> Грибник {doper.Name} собрал {amount} грибов.");

            if (_stash <= 0)
                OnStashOver?.Invoke();

            return amount;
        }

        // Отпустить грибника с поляны
        public void DismissDoper(Doper doper)
        {
            if (!_dopers.Contains(doper)) throw new Exception("Doper not in this nest!");

            _dopers.Remove(doper);
            Console.WriteLine($"> Грибник {doper.Name} ушёл с поляны. На поляне осталось {_stash} грибов");
        }
    }
}
