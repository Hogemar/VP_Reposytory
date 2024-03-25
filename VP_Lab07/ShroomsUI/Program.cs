using ShroomsBuzz;

Nest nestDeep = new Nest(37);

Doper doperVasya = new("Васисуалий");
Doper doperSenya = new("Палпатин");
Doper doperEgor = new("Билли");

doperVasya.VisitNest(nestDeep);
doperVasya.GetDope(15);
Console.WriteLine();

doperSenya.VisitNest(nestDeep);
doperEgor.VisitNest(nestDeep);
Console.WriteLine();

doperSenya.GetDope(10);
doperSenya.GetDope(5);
Console.WriteLine();

doperEgor.GetDope(12);