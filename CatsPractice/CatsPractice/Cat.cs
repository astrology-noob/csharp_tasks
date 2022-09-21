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
            return weight >= minWeight & weight <= maxWeight? true : false;
        }

        public void Meow()
        {
            if (IsAlive())
                weight -= 10;
            else Console.WriteLine("Cat is dead");
        }

        public void Feed(float food)
        {
            if (IsAlive())
            {
                eatenFood += food;
                weight += food;
            }
            else Console.WriteLine("Cat is dead");
        }

        public void Pee()
        {
            if (IsAlive())
                weight -= 20;
            else Console.WriteLine("Cat is dead");
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
