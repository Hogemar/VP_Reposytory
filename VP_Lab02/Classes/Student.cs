namespace Classes
{
    public class Student
    {
        public int Id { get; }              // Номер зачётной книжки
        public string Name { get; }         // Имя
        public string Surname { get; }      // Фамилия
        public string MiddleName { get; }   // Отчество
        public DateOnly BirthDate { get; }  // Дата рождения
        public string address;              // Адрес
        public char[] phoneNumber;          // Номер телефона

        //public Student(int id)
        //{
        //    _id = id;
        //}
        //public Student(int id, string name, string surname, string middleName, DateOnly birthDate)
        //{
        //    _id = id;
        //    Name=name;
        //    Surname=surname;
        //    MiddleName=middleName;
        //    BirthDate=birthDate;
        //}
        public Student(int id, string name, string surname, DateOnly birthDate, string address, char[] phoneNumber, string middleName = null)
        {
            Id=id;
            Name=name;
            Surname=surname;
            MiddleName=middleName;
            BirthDate=birthDate;
            this.address=address;
            this.phoneNumber=phoneNumber;
        }

        public string GetFullName()
        {
            string fname = new string(Surname);
            fname += ' ';
            fname.Concat(Name);

            if (MiddleName != null)
            {
                fname += ' ';
                fname.Concat(Name);
            }

            return fname;
        }

        public override string ToString() 
        {
            string str = 
                $"Зачётная книжка: {Id}\n" +
                $"Имя: {Surname}\n" +
                $"Фамилия: {Name}\n";

            if (MiddleName != null) str +=
                    $"Отчество: {MiddleName}\n";

            str +=
                $"Дата рождения: {BirthDate}\n" +
                $"Адрес: {address}\n";

            string phoneStr = new string("");
            foreach(var c in phoneNumber)
            {
                phoneStr += c ;
            }
            
            str+= $"Телефон: {phoneStr}\n";

            return str;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;

            return (this.ToString().Equals(obj.ToString()));
        }

    }
}
