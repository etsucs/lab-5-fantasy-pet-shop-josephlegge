namespace FantasyPet
{
    public class Program
    {
        static void Main()
        {
            Pet pet = new Pet();
            Pet pet2 = new Pet();
            //Console.WriteLine(pet.describePet(pet.Name,pet.Species,pet.Age));

            pet.Name = "Rudy";
            pet.Species = "Dinosaur";
            pet.Age = 200;
            pet.Price = 1000M;
            pet.MagicPower = "bite with sharp teeth";
            Console.WriteLine(pet.describePet(pet.Name, pet.Species, pet.Age, pet.MagicPower));
            Console.WriteLine(pet.discountPrice(pet.Price));
            Console.WriteLine(pet.performMagic(pet.MagicPower));

            pet.Name = "Albirdo";
            pet.Species = "Bigbird";
            pet.Age = 12;
            pet.Price = 500M;
            pet.MagicPower = "fly at supersonic speed";
            Console.WriteLine(pet.describePet(pet.Name, pet.Species, pet.Age, pet.MagicPower));
            Console.WriteLine(pet.discountPrice(pet.Price));
            Console.WriteLine(pet.performMagic(pet.MagicPower));


        }

    }
}