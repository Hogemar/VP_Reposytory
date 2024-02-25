

namespace ClassLibrary
{
    public class Student
    {
        public int Id { get; }                  // Номер зачётной книжки
        public string Name { get; }             // Имя
        public string Surname { get; }          // Фамилия
        public string? MiddleName { get; }      // Отчество
        public DateOnly BirthDate { get; }      // Дата рождения
        public string Address { get; set; }     // Адрес
        public string PhoneNumber { get; set; } // Номер телефона

        public Student(int id, string name, string surname, DateOnly birthDate, string address, string phoneNumber, string middleName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            BirthDate = birthDate;
            Address = address;
            PhoneNumber = phoneNumber;
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
                $"Адрес: {Address}\n";

            str +=
                $"Телефон: {PhoneNumber}\n";

            return str;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;

            Student studentObject = obj as Student;

            return this.Id == studentObject.Id
                && this.Name == studentObject.Name
                && this.Surname == studentObject.Surname
                && this.BirthDate == studentObject.BirthDate
                && this.Address == studentObject.Address
                && this.PhoneNumber == studentObject.PhoneNumber
                && this.MiddleName == studentObject.MiddleName;
        }

    }
}
