using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Loader;
using System.Drawing;

namespace CatsPractice
{
    static class Loader
    {
        public static Cat GetKitten(bool hasTail, Cat.furColor furColor)
        {
            return new Cat(hasTail, furColor, 1000.0f);
        }
    }

    internal class Cat : ICloneable
    {
        private static int catCount = 0;

        public enum furColor { Black = 0, White = 1, Ginger = 2 }
        
        const int eyesCount = 2;
        const int minWeight = 1000;
        const int maxWeight = 10000;

        private bool isAlive = true;
        public float weight;
        private furColor CatFurColor;
        private bool HasTail;

        public Cat(bool tail, furColor fur)
        {
            CatFurColor = fur;
            HasTail = tail;
            catCount++;
        }

        public Cat(bool tail, furColor fur, float catWeight)
        {
            weight = catWeight;
            catCount++;
        }

        public bool GetaHasTail()
        {
            return HasTail;
        }

        public furColor GetFurColor()
        {
            return CatFurColor;
        }


        private float eatenFood = 0;
        public float GetEatenFood()
        {
            return eatenFood;
        }

        public bool IsAlive()
        {
            isAlive = weight >= minWeight & weight <= maxWeight;
            return isAlive;
        }

        public void Meow()
        {
            if (IsAlive())
            {
                weight -= 10;
                Console.WriteLine("Cat meowed");
                if (!IsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Meow");
        }

        public void Eat(float food)
        {
            if (IsAlive())
            {
                eatenFood += food;
                weight += food;
                Console.WriteLine("Cat ate");
                if (!IsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Eat");
        }

        public void Pee()
        {
            if (IsAlive())
            {
                weight -= 20;
                Console.WriteLine("Cat peed");
                if (!IsAlive()) catCount--;
            }
            else Console.WriteLine("Dead cat can't Pee");
        }

        public static int GetCatCount()
        {
            return catCount;
        }

        public object Clone()
        {
            return new Cat(HasTail, CatFurColor, weight);
        }
    }
}
