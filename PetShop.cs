using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace FantasyPet
{
    public class PetShop
    {

        public List<object> pets = new List<object>() {};
        
        // Adds a pet to the shop.
        public object addPet(Pet pet)
        {
            pets.Add(pet);
        
            return $"Pet {pet.Name} added!";
        }

        // Lists the pets.
        public object listPets(object i)
        {
            return $"{i}";
        }
    }
}