using CatsPractice;

Cat GetKitten(bool hasTail, FurColor furColor)
{
    return new Cat(hasTail, furColor, 1000.0f);
}

Cat cat1 = GetKitten(true, FurColor.Black);
Cat cat2 = GetKitten(false, FurColor.White);
Console.WriteLine("Cat count: {0}", Cat.GetCatCount());

Console.WriteLine("Cat1 Feed to death");
Console.WriteLine("Weight before: {0}", cat1.weight);

while (cat1.GetIsAlive())
{
    cat1.Eat(100);
}

Console.WriteLine("Weight after: {0}", cat1.weight);
Console.WriteLine("Eaten Food: {0}\n", cat1.GetEatenFood());

Console.WriteLine("Cat2 Meow to death");
cat2.Eat(200);
Console.WriteLine("Weight before: {0}", cat2.weight);

while (cat2.GetIsAlive())
{
    cat2.Meow();
}

Console.WriteLine("Weight after: {0}", cat2.weight);
Console.WriteLine("Eaten Food: {0}\n", cat2.GetEatenFood());
cat2.Pee();

Console.WriteLine("Cat count: {0}", Cat.GetCatCount());
Cat cat3 = cat1.Clone();
Console.WriteLine("Cat isAlive: {0}", cat3.GetIsAlive());
Console.WriteLine("Cat count: {0}", Cat.GetCatCount());
Cat cat4 = GetKitten(false, FurColor.White);
Cat cat5 = cat4.Clone();
Console.WriteLine("Cat isAlive: {0}", cat5.GetIsAlive());
Console.WriteLine("Cat count: {0}", Cat.GetCatCount());