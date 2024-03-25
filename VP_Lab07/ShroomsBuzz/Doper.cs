using System.Text;

namespace ShroomsBuzz
{
	public class Doper
	{
		// Поляна пребывания
		private Nest? _currentNest = null;

		// Имя
		public string Name { get; private set; }

		// Конструктор без аргументов
		public Doper()
		{
			StringBuilder nameBuilder = new("Васян");
			nameBuilder.Append(new Random().Next(1000, 9999).ToString());
			Name = nameBuilder.ToString();
		}

		// Конструктор с именем
		public Doper(string name) => Name = name;
			

		// Прийти на полянку
		public void VisitNest(Nest nest)
		{
			nest.AdmitDoper(this);
			this._currentNest = nest;

			//return _currentNest != null;
		}

		// Собрать грибочки
		public int GetDope(int amount)
		{
			if (_currentNest == null) throw new Exception("This doper not in the nest!");

			int gottenAmount = 0;
			try
			{
				gottenAmount = _currentNest.DeliverDope(this, amount);
			}
			catch(Exception ex)
			{
				Console.WriteLine($"> \nSomething went wrong!\n{ex.Message}");
				return -1;
			}

			return gottenAmount;
		}

		// Уйти с полянки
		public void LeaveNest()
		{
			if (_currentNest == null) throw new Exception("This doper not in the nest!");

			try
			{
				_currentNest.DismissDoper(this);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"> \nSomething went wrong!\n{ex.Message}");
			}

			_currentNest = null;
		}
		
	}
}
