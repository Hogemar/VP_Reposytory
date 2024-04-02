using System.Text;

namespace ShroomsBuzz
{
	public class Doper
	{
        // Поляна пребывания
        private Nest? _currentNest = null;

        // Имя
        public string Name { get; private set; }

        // Собранные  грибочки
        public int DopeCollected { get; set; }


        // Конструктор без аргументов
        public Doper()
        {
            StringBuilder nameBuilder = new("Васян");
            nameBuilder.Append(new Random().Next(1000, 9999));
            Name = nameBuilder.ToString();
        }

        // Конструктор с именем
        public Doper(string name)
        {
            Name = name;
        }


        // Событие – грибник пришёл на поляну
        public event EventHandler OnNestVisit;

		// Событие – грибник собрал грибочки
		public event EventHandler<ShroomsEventArgs> OnDopeGet;

		// Событие – грибник покинул поляну
		public event EventHandler OnNestLeave;

		// Аргументы события сбора грибочков
		public class ShroomsEventArgs : EventArgs
		{
			public int ShroomsAmount;

			public ShroomsEventArgs(int shroomsAmount) => this.ShroomsAmount = shroomsAmount;
		}


		// Прийти на полянку
		public void VisitNest(Nest nest)
		{
			if (_currentNest != null) throw new Exception("Doper already in the nest!");

			//nest.AdmitDoper(this);
			this._currentNest = nest;

			OnNestVisit += _currentNest.DoperVisitHandler;
			OnDopeGet += _currentNest.GettingDopeHandler;
			OnNestLeave += _currentNest.DoperLeaveHandler;
			
            OnNestVisit?.Invoke(this, new EventArgs());
		}

		// Собрать грибочки
		public void GetDope(int amount)
		{
			if (_currentNest == null) throw new Exception("This doper not in the nest!");

			OnDopeGet?.Invoke(this, new ShroomsEventArgs(amount));
		}

		// Уйти с полянки
		public void LeaveNest()
		{
            if (_currentNest == null) throw new Exception("This doper not in the nest!");

            OnNestLeave?.Invoke(this, new EventArgs());

            OnNestVisit -= _currentNest.DoperVisitHandler;
            OnDopeGet -= _currentNest.GettingDopeHandler;
            OnNestLeave -= _currentNest.DoperLeaveHandler;

            _currentNest = null;
        }

        // Обработчик события – на поляне кончились грибы
        public void DopeOverHandler(object sender, EventArgs e)
        {
            if (_currentNest != (sender as Nest)) return;

            LeaveNest();
        }
    }
}
