﻿namespace Wild_farm.Models.Animals
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
    }
}
