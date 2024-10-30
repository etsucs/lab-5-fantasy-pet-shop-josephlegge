using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace FantasyPet
{
    public class Pet
    {


        public string Name;
        public string Species;
        public int Age;
        public decimal Price;
        public string MagicPower;

        private int Discount;

        public string describePet(string Name, string Species, int age, string MagicPower)
        {
            return $"Your pet is named {Name}, it is a {Species}, and it is {Age} years old, and it can {MagicPower}.";
        }
    
        public string discountPrice(decimal Price)
        {
            return $"All pets are 10% off. Your pet would be {Price-Price/100*10}";
        }
        public string performMagic(string MagicPower)
        {
            return "Rudy bites things. With magic.";
        }


    }

}