using System;
using Wild_farm.Models.Foods;

namespace Wild_farm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this.livingRegion; }
            protected set { this.livingRegion = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            string animalType = this.GetType().Name;
            string foodType = food.GetType().Name;

            if ((animalType == "Zebra" || animalType == "Mouse") && foodType != "Vegetable")
            {
                Console.WriteLine($"{animalType}s are not eating that type of food!");
                return;
            }

            if (animalType == "Tiger" && foodType != "Meat")
            {
                Console.WriteLine($"{animalType}s are not eating that type of food!");
                return;
            }

            this.FoodEaten += food.Quantity;
        }
    }
}
