
using ClassLibrary;

string inputString = "Hello, World!";
StringInfo stringInfo = inputString.GetInfo();

Console.WriteLine($"Length: {stringInfo.Length}");
Console.WriteLine($"Digit Count: {stringInfo.DigitCount}");
Console.WriteLine($"Letter Count: {stringInfo.LetterCount}");


Student a = new Student(15, "Артёльф", "Старопопов", new DateOnly(1998, 6, 23), "г. Воронеж, ул. Продольная, д. 16", "79538474252", "Иванов");
Student c = new Student(16, "Стасик", "Янчиков", new DateOnly(2000, 7, 12), "г. Махачкала, ул. Слюпа, д. 5", "79421351826", "Изявич");
Student b = new Student(10, "Бартёльф", "Астольфов", new DateOnly(1998, 6, 23), "г. Ульяновск, ул. Новая, д. 7", "79375273828", "Крягович");




Group group = new Group(340);
group.Add(a);
group.Add(c);
group.Add(b);

Console.WriteLine(group.StudentsNumber());
