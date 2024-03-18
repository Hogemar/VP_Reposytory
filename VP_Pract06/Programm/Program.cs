using ClassLibrary;
using System;

/*Задание 1*/

/*
Action<Func<int>, char, char> actionFirst = (Func<int> func, char c1, char c2) 
    => Console.Write(c1 + " " + func().ToString() + " " + c2);

Action<Func<int>, char, char> actionSecond = delegate (Func<int> func, char c1, char c2)
{
    for (int i = 0; i < func(); i++)
        Console.Write(c1);
    Console.Write($" Tekila ");
    for (int i = 0; i < func(); i++)
        Console.Write(c2);
};


DelegatesFirst.DoFirst(actionFirst, () => 5, '/', '\\');
DelegatesFirst.DoFirst(actionSecond, delegate () { return 3; }, '+', '*');
*/

//Func<int> f = () => DelegatesFirst.Mul(7);

//Action<Func<int>, char, char> action = DelegatesFirst.Sum;

//action(f, 'a', 'b');


/*Задание2*/

Action<int, int> action = (x, y) => Console.WriteLine($"{x} + {y} = {x+y}! Wow!");

Func<Action<int, int>, bool> funcFirst = (action)
    =>
{
    action(5, 2);
    return (new Random()).Next(2) == 1;
};

Func<Action<int, int>, bool> funcSecond = delegate (Action<int, int> action)
{
    for (int i = 0; i < 3; i++)
    {
        action(2, 2);
        Console.WriteLine();
    }
    return false;
};

DelegatesSecond.DoSecond(funcFirst, action);
DelegatesSecond.DoSecond(funcSecond, action);

//Action<int,int>action =(x,y) => DelegatesSecond.add(x,y);

//Func<Action<int, int>, bool> f =sum=> DelegatesSecond.PositiveOrNot(sum,true);

//bool result = f(action);
//Console.WriteLine($"Результат: {result}");

