using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT6pt1
{
    internal class Burger : Food
    {
        private string name;
        private string ingredients;
        private double price;
        private float calories;
        private int numberofPatty;
        public Burger()
        {
            //Empty Constructor
        }
        public Burger(string name, string ingredients, double price, float calories, int numberofPatty)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Price = price;
            this.Calories = calories;
            this.NumberofPatty = numberofPatty;
        }
        public string Name
        {
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
        public int NumberofPatty
        {
            get { return numberofPatty; }
            set { numberofPatty = value; }
        }
        public override void showDetails()
        {
            Console.WriteLine("Burger:\nName: " + Name);
            Console.WriteLine("Ingredients: " + Ingredients);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Calories: " + Calories);
            Console.WriteLine("Number of Patty: " + NumberofPatty);
        }
    }
}
