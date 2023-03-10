using Strategy;
using Strategy.MyImplementation;

//Стратегия — это поведенческий паттерн проектирования, который определяет семейство схожих алгоритмов и 
//помещает каждый из них в собственный класс, после чего алгоритмы можно взаимозаменять прямо во время исполнения программы.
/*
var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomeBusinessLogic();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomeBusinessLogic();*/

Hero hero = new("Squidward");
hero.Attack();
hero.SetWeapon(new Broom());
hero.Attack();
hero.SetWeapon(new Plunger());
hero.Attack();
Console.Read();