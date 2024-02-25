
namespace ClassLibrary
{
    public class Group
    {
        public int Number { get; }
        private List<Student> _students = new List<Student>();

        public Group(int groupNumber)
        {
            this.Number = groupNumber;
        }

        private void Sort()
        {
            for (int viewedNumber = 0; viewedNumber < _students.Count - 1; viewedNumber++)
            {
                int maxIndex = viewedNumber;

                for (int i = viewedNumber + 1; i < _students.Count; i++)
                {
                    if (_students[i].GetFullName().CompareTo(_students[maxIndex].GetFullName()) < 0)
                        maxIndex = i;
                }

                Student studRef = _students[viewedNumber];
                _students[viewedNumber] = _students[maxIndex];
                _students[maxIndex] = studRef;
            }
        }

        public void Add(Student student)
        {
            _students.Add(student);
            Sort();
        }
        public void Add(int id, string name, string surname, DateOnly birthDate, string address, string phoneNumber, string middleName = null)
        {
            _students.Add(new Student(id, name, surname, birthDate, address, phoneNumber, middleName));
            Sort();
        }

        public bool Remove(int studentId)
        {
            foreach (var student in _students)
            {
                if (student.Id == studentId)
                {
                    _students.Remove(student);
                    return true;
                }
            }
            return false;
        }
        public bool Remove(Student student)
        {
            foreach (var groupStudent in _students)
            {
                if (groupStudent.Equals(student))
                {
                    _students.Remove(student);
                    return true;
                }
            }
            return false;
        }

        public string GetInfo()
        {
            string info = new string("");
            info += Number.ToString();
            info += "\n\n";
            foreach (var student in _students)
            {
                info += student.ToString();
                info += "\n";
            }

            return info;
        }

        public Student? this[int id]
        {
            get
            {
                foreach (var student in _students)
                {
                    if (student.Id == id)
                        return student;
                }
                return null;
            }
        }
    }
}
