using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal class Drinks : Food
    {
        private string name;
        private string ingredients;
        private double price;
        private float calories;
        private string Type;
        private int sizeinLitter;
        public Drinks()
        {
            //Empty Constructor
        }
        public Drinks(string name, string ingredients, double price, float calories, string Type, int sizeinLitter)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Price = price;
            this.Calories = calories;
            this.type = Type;
            this.Size = sizeinLitter;
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
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }
        public int Size
        {
            get { return sizeinLitter; }
            set { sizeinLitter = value; }
        }

        public override void showDetails()
        {
            Console.WriteLine("Drinks:\nName: " + Name);
            Console.WriteLine("Ingredients: " + Ingredients);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Calories: " + Calories);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Size in Litter: " + Size);
        }
    }
}