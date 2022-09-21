namespace CatsPractice
{
    internal class Cat
    {
        private static int catCount = 0;
        
        const int eyesCount = 2;
        const int minWeight = 1000;
        const int maxWeight = 10000;

        private bool IsAlive;
        public float weight { get; private set; }
        public FurColor CatFurColor { get; }
        private bool HasTail;

        public Cat(bool tail, FurColor fur, bool isAlive = true)
        {
            IsAlive = isAlive;
            HasTail = tail;
            CatFurColor = fur;
            if (IsAlive)
                catCount++;
        }

        public Cat(bool tail, FurColor fur, float catWeight, bool isAlive = true) : this(tail, fur, isAlive)
        {
            weight = catWeight;
        }

        public bool GetHasTail()
        {
            return HasTail;
        }

        public FurColor GetFurColor()
        {
            return CatFurColor;
        }

        private float eatenFood = 0;
        public float GetEatenFood()
        {
            return eatenFood;
        }

        public bool GetIsAlive()
        {
            IsAlive = weight >= minWeight & weight <= maxWeight;
            return IsAlive;
        }

        public void Meow()
        {
            if (GetIsAlive())
            {
                weight -= 10;
                if (!GetIsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Meow");
        }

        public void Eat(float food)
        {
            if (GetIsAlive())
            {
                eatenFood += food;
                weight += food;
                if (!GetIsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Eat");
        }

        public void Pee()
        {
            if (GetIsAlive())
            {
                weight -= 20;
                if (!GetIsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Pee");
        }

        public static int GetCatCount()
        {
            return catCount;
        }

        public Cat Clone()
        {
            return (Cat)MemberwiseClone();
        }
    }
}
