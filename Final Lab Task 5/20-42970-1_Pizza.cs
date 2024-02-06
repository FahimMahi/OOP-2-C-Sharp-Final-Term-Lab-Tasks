using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal class Pizza : Food
    {
        private string name;
        private string ingredients;
        private double price;
        private float calories;
        private int sizeInInches;
        public Pizza()
        {
            //Empty Constructor
        }
        public Pizza(string name, string ingredients, double price, float calories, int sizeInInches)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.price = price;
            this.calories = calories;
            this.SizeInInches = sizeInInches;
        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public float Calories
        {
            get { return calories; }
            set
            {
                calories = value;
            }
        }
        public int SizeInInches
        {
            get { return sizeInInches; }
            set { sizeInInches = value; }
        }
        public override void showDetails()
        {
            Console.WriteLine("Pizza\nName: " + Name);
            Console.WriteLine("Ingredients: " + Ingredients);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Calories: " + Calories);
            Console.WriteLine("Size in Inches: " + SizeInInches);
        }
    }
}
