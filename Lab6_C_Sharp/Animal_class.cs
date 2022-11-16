using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab6_C_Sharp
{
    public abstract class Animal
    {
		protected float weight;
        protected string color;

        //Paramert Weight type: float
        public float Weight
		{
			get { return weight; }
			set { this.weight = value; }
		}

        //Paramert Color type: string
        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }

        //Constructor Animal
        public Animal(float weight, string color)
        {
            this.weight = Weight;
            this.color = Color;
        }

        //Abstract metod MakeSound type: string
        public abstract string MakeSound();
    }

    //Class AnimalWihtTail : Animal and have parametr TailLeight
    public abstract class AnimalWithTail : Animal
    {
        protected float taillength;

        //Paramert TailLength type: float
        public float TailLength
        {
            get { return taillength; }
            set { this.taillength = value; }
        }

        //Constructor AnimalWithTail
        public AnimalWithTail(float weight, string color, float tailleight) : base(weight, color)
        {
            this.Weight = weight;
            this.Color = color;
            this.TailLength = tailleight;
        }
    }

    //Class Cat : AnimalWithTail and Metods
    public class Cat : AnimalWithTail
    {
        //Constructor Cat
        public Cat(float weight, string color, float tailleight) : base(weight, color, tailleight)
        {
            this.Weight = weight;
            this.Color = color;
            this.TailLength = tailleight;
        }
        
        //Constructot Purr for return
        private string Purr()
        {
            return "purrrrrrrr ";
        }

        //Constructot Meow for return
        private string Meow()
        {
            return "Meow";
        }

        //Metod where Purr + Meow
        public override string MakeSound()
        {
            return Purr() + Meow();
        }

        //Metod ToString
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }

    //Class Dog : AnimalWithTail and Metods
    public class Dog : AnimalWithTail
    {
        //Constructor Dog
        public Dog(float weight, string color, float tailleight) : base(weight, color, tailleight)
        {
            this.Weight = weight;
            this.Color = color;
            this.TailLength = tailleight;
        }

        //Metod where Sound "Woof"
        public override string MakeSound()
        {
            return "Woof";
        }

        //Metod ToString
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
}
