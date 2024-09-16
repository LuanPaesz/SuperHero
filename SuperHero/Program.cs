// See https://aka.ms/new-console-template for more information
using SuperHero.Heroes;
using System;

Console.WriteLine("Hello, World!");

string heroName = "SpiderMan";
string realName = "Piter Parker";


Hero p = new Hero();
p.HeroName = heroName;
p.RealName = realName;

Hero p1 = new Hero();
p1.HeroName = "Batman";
p1.RealName = "Bruce Wayne";

Hero p2 = new Hero();
p2.HeroName = "Hulk";
p2.RealName = "David Banner";

List<Hero> list = new List<Hero>();
list.Add(p);
list.Add(p1);
list.Add(p2);

foreach (Hero hero in list)
{
    //Console.WriteLine($"Hello, my hero name is {p1.HeroName}! but, my real name is {p1.RealName}");
    Console.WriteLine(hero);

}

