using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace FantasyPet
{
    public class Pet
    {
        private decimal _discount;

        public string Name;
        public string Species;
        public int Age;
        public decimal Price;
        public string MagicPower;
        public decimal Discount;

        // Describes the pet with the name, species, age and power.
        public string describePet(string Name, string Species, int age, string MagicPower) 
        {
            return $"\nThis pet is named {Name}, he is a {Species}, he is {Age} years old, and he {MagicPower}";
        }
    
        // Returns the discounted price based on the random discount. 
        public string discountPrice(decimal Price, decimal Discount)
        {
            return $"\nAll pets are {Discount}% off right now. Your pet would be {Price-Price/100*Discount} dollars.";
        }

        // Returns the pet performing its power.
        public string performMagic(string Name, string MagicPower)
        {
            return $"\n{Name} {MagicPower}";
        }
    }
}