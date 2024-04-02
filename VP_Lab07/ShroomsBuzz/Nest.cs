using System.Collections;
using System.Reflection;
using System.Xml.Linq;
using static ShroomsBuzz.Doper;

namespace ShroomsBuzz
{
	public class Nest
	{
		//Количество грибов
		private int _stash;//new Random().Next(1, 50);


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


        // Событие - на поляне кончились грибы
        public static event EventHandler OnDopeOver;


        // Обработчик прихода грибника
        public void DoperVisitHandler (object sender, EventArgs e)
		{
			//if (sender == null) throw new Exception("DoperVisitHandler: sender is null!");

			OnDopeOver += (sender as Doper).DopeOverHandler;
            Console.WriteLine($"> На поляну пришёл грибник {(sender as Doper).Name}. В данный момент на поляне {_stash} грибов.");
        }

		// Обработчик сбора грибов
		public void GettingDopeHandler(object sender, ShroomsEventArgs e)
		{
			int amount = e.ShroomsAmount;

            if (amount <= 0) throw new Exception("Invalid dope amount!");

            if (_stash <= amount)
                amount = _stash;

            _stash -= amount;
			(sender as Doper).DopeCollected += amount;

            Console.WriteLine($"> Грибник {(sender as Doper).Name} собрал {amount} грибов.");

            if (_stash <= 0)
				OnDopeOver(this, new EventArgs());
        }

        // Обработчик ухода грибника
        public void DoperLeaveHandler(object sender, EventArgs e)
		{
            Doper doper = (sender as Doper);
            OnDopeOver -= doper.DopeOverHandler;

            Console.WriteLine($"> Грибник {doper.Name} ушёл с поляны с {doper.DopeCollected} грибами в кармане. На поляне осталось {_stash} грибов");
        }
	}
}
