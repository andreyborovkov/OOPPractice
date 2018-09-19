using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    class Superhero
    {
        //fields
        private string name;
        private int strength;
        private double speed;
        private bool isTransformed = false;

        //properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public bool IsTransformed
        {
            get { return this.isTransformed; }
            set { this.isTransformed = value; }
        }

        //Constructors
        public Superhero()
        {
            //default
        }

        public Superhero(string name, int strength, double speed, bool isTransformed)
        {
            this.Name = name;
            this.Strength = strength;
            this.Speed = speed;
            this.IsTransformed = isTransformed;
        }

        public Superhero(string name, int strength, double speed)
        {
            this.Name = name;
            this.Strength = strength;
            this.Speed = speed;
        }

        public string GetHulk()
        {
            if (isTransformed != true) { 
            IsTransformed = true;
            Name = "Hulk";
            Strength = Strength * 200;
            Speed = Speed * 100;
        }

            return Name;
        }

        public string GetBruce()
        {
            IsTransformed = false;
            Name = "Bruce";
            Strength = Strength / 200;
            Speed = Speed / 100;


            return Name;
        }

        public void GetDetails()
        {
            Console.WriteLine("My name is " + Name + ". I am " + Strength + "psi strong, " + Speed + "mph fast, and it's " + IsTransformed + " that I am transformed.");
        }

    }
}
