﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    class Dog
    {
        //Fields
        private string name;
        private int hairLength;
        private double height;
        private double runningSpeed;
        private double weight;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //constructor
        public Dog()
        {
            //default constructor
        }

        public Dog(int hair, double tall, double speed, double fatness, string tag)
        {
            this.HairLength = hair;
            this.Height = tall;
            this.RunningSpeed = speed;
            this.Weight = fatness;
            this.Name = tag;
        }


        //methods
        public double GetSpeed(int distance)
        {
            RunningSpeed = RunningSpeed * distance;
            GetDetails();
            return RunningSpeed;
        }

        public void GetDetails()
        {
            Console.WriteLine("Your pet's name is {0}. It has {1} inches of hair.", Name, HairLength );
            Console.WriteLine("{0} is {1} inches tall and weighs {1} pounds", Name, Height, Weight);
            Console.WriteLine("{0} can run {1} mph", Name, RunningSpeed);
        }
    }
}
