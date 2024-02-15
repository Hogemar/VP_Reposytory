using Classes;
using System.Numerics;

Student a = new Student(15, "Артёльф", "Старопопов", new DateOnly(1998, 6, 23), "г. Воронеж, ул. Продольная, д. 16", ['7', '9', '5', '3', '8', '4', '7', '4', '2', '5', '2'], "Иванов");
Student c = new Student(16, "Стасик", "Янчиков", new DateOnly(2000, 7, 12), "г. Махачкала, ул. Слюпа, д. 5", ['7', '9', '4', '2', '1', '3', '5', '1', '8', '2', '6'], "Изявич");
Student b = new Student(10, "Бартёльф", "Астольфов", new DateOnly(1998, 6, 23), "г. Ульяновск, ул. Новая, д. 7", ['7', '9', '3', '7', '5', '2', '7', '3', '8', '2', '8'], "Крягович");

//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a.Equals(c));


Group group = new Group(340);
group.Add(a);
group.Add(c); 
group.Add(b);

Student studref = group[16];
if(studref != null)
    Console.WriteLine(studref.ToString());