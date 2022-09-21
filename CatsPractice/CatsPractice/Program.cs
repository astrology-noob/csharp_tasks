using CatsPractice;

Cat cat1 = Loader.GetKitten(true, Cat.furColor.Black);
Cat cat2 = Loader.GetKitten(false, Cat.furColor.White);

Console.WriteLine("Cat1 Feed to death");
Console.WriteLine("Weight before: {0}", cat1.weight);

while (cat1.IsAlive())
{
    cat1.Feed(100);
}

Console.WriteLine("Weight after: {0}", cat1.weight);
Console.WriteLine("Eaten Food: {0}", cat1.GetEatenFood());

Console.WriteLine("Cat2 Meow to death");
cat2.Feed(200);
Console.WriteLine("Weight before: {0}", cat2.weight);

while (cat2.IsAlive())
{
    cat2.Meow();
}

Console.WriteLine("Weight after: {0}", cat2.weight);
cat2.Pee();

Cat cat3 = (Cat)cat1.Clone();
Console.WriteLine("Cat count: {0}", Cat.GetCatCount());