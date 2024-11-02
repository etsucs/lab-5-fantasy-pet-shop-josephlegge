using System.Security.Cryptography;
using System.Xml.Serialization;

namespace FantasyPet
{
    public class Program
    {
        static void Main()
        {
            Random random = new Random();
            decimal Discount = random.Next(1, 500) / 10;
            Console.WriteLine($"All pets are {Discount} percent off right now.");

            PetShop petShop1 = new PetShop();

            // Make Pet Objects
            Pet Rudy = new Pet();
            Pet Albirdo = new Pet();
            Pet Growley = new Pet();

            // Rudy the Dinosaur
            Rudy.Name = "Rudy";
            Rudy.Species = "dinosaur";
            Rudy.Age = 200;
            Rudy.Price = 1000000M;
            Rudy.MagicPower = "grows up to three times his own original size.";

            // Albirdo the Bird
            Albirdo.Name = "Albirdo";
            Albirdo.Species = "laserbeak bird";
            Albirdo.Age = 12;
            Albirdo.Price = 500M;
            Albirdo.MagicPower = "flies at super speed.";

            // Growley
            Growley.Name = "Growley";
            Growley.Species = "werewolf";
            Growley.Age = 54;
            Growley.Price = 10000M;
            Growley.MagicPower = "makes a sonic howl.";

            // Game loop to keep playing until you leave
            bool keepPlaying = true;
            while (keepPlaying == true)
            {

                Console.WriteLine("Select a pet to describe:\n1. Rudy\n2. Albirdo\n3. Growley\n\nOptions:\n4. Add pet to shop\n5. List pets\n6. Leave\n");
                string answer = Console.ReadLine();
                while (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5" && answer != "6")
                {
                    Console.WriteLine("Try again! Enter a number between 1 and 6: ");
                    answer = Console.ReadLine();
                }

                // Pet actions
                if (answer == "1") // Rudy
                {
                    Console.WriteLine($"\nWhat do you want to do with {Rudy.Name}?\n1. Describe pet\n2. Check price\n3. Use pet ability\n");
                    answer = Console.ReadLine();
                    while (answer != "1" && answer != "2" && answer != "3")
                    {
                        Console.WriteLine("Try again! Enter a number between 1 and 3: ");
                        answer = Console.ReadLine();
                    }
                    if (answer == "1") // Describe Pet
                    {
                        Console.WriteLine(Rudy.describePet(Rudy.Name, Rudy.Species, Rudy.Age, Rudy.MagicPower));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "2") // Pet Price
                    {
                        Console.WriteLine(Rudy.discountPrice(Rudy.Price, Discount));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "3") // Pet Power
                    {
                        Console.WriteLine(Rudy.performMagic(Rudy.Name, Rudy.MagicPower));
                        Console.WriteLine("You can hear the floor creak.");
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }

                }
                else if (answer == "2") // Albirdo
                {

                    Console.WriteLine($"\nWhat do you want to do with {Albirdo.Name}?\n1. Describe pet\n2. Check price\n3. Use pet ability\n");
                    answer = Console.ReadLine();
                    while (answer != "1" && answer != "2" && answer != "3")
                    {
                        Console.WriteLine("Try again! Enter a number between 1 and 3: ");
                        answer = Console.ReadLine();
                    }
                    if (answer == "1") // Describe Pet
                    {
                        Console.WriteLine(Albirdo.describePet(Albirdo.Name, Albirdo.Species, Albirdo.Age, Albirdo.MagicPower));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "2") // Pet Price
                    {
                        Console.WriteLine(Albirdo.discountPrice(Albirdo.Price, Discount));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "3") // Pet Power
                    {
                        Console.WriteLine(Albirdo.performMagic(Albirdo.Name, Albirdo.MagicPower));
                        Console.WriteLine("How did he get over there so fast?");
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                }
                else if (answer == "3") // Growley
                {
                    Console.WriteLine($"\nWhat do you want to do with {Growley.Name}?\n1. Describe pet\n2. Check price\n3. Use pet ability\n");
                    answer = Console.ReadLine();
                    while (answer != "1" && answer != "2" && answer != "3")
                    {
                        Console.WriteLine("Try again! Enter a number between 1 and 3: ");
                        answer = Console.ReadLine();
                    }
                    if (answer == "1") // Describe Pet
                    {
                        Console.WriteLine(Growley.describePet(Growley.Name, Growley.Species, Growley.Age, Growley.MagicPower));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "2") // Pet Price
                    {
                        Console.WriteLine(Growley.discountPrice(Growley.Price, Discount));
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                    else if (answer == "3") // Pet Power
                    {
                        Console.WriteLine(Growley.performMagic(Growley.Name, Growley.MagicPower));
                        Console.WriteLine("You cover your ears. It's really loud.");
                        Console.WriteLine("[ Enter to continue ]\n");
                        Console.ReadLine();
                    }
                }

                // Petshop actions
                else if (answer == "4") // Add Pets
                {
                    Console.WriteLine($"\nWhich pet do you add to your shop?\n1. Rudy\n2. Albirdo\n3. Growly");
                    answer = Console.ReadLine();
                    while (answer != "1" && answer != "2" && answer != "3")
                    {
                        Console.WriteLine("Try again! Enter a number between 1 and 3: ");
                        answer = Console.ReadLine();
                    }
                    if (answer == "1") // Add Rudy to the petshop
                    {
                        if (petShop1.pets.Contains(Rudy)) // If he's not in the store yet, add him. Otherwise don't add him.
                        {
                            Console.WriteLine("\nThat pet is already in the shop!");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            petShop1.addPet(Rudy);
                            Console.WriteLine($"\nAdded Rudy to the shop.");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }

                    }
                    else if (answer == "2") // Add Albirdo to the petshop
                    {
                        if (petShop1.pets.Contains(Albirdo)) // If he's not in the store yet, add him. Otherwise don't add him.
                        {
                            Console.WriteLine("\nThat pet is already in the shop!");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            petShop1.addPet(Albirdo);
                            Console.WriteLine($"\nAdded Albirdo to the shop.");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }
                    }
                    else if (answer == "3") // Add Growley to the petshop
                    {
                        if (petShop1.pets.Contains(Growley)) // If he's not in the store yet, add him. Otherwise don't add him.
                        {
                            Console.WriteLine("\nThat pet is already in the shop!");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            petShop1.addPet(Growley);
                            Console.WriteLine($"\nAdded Growley to the shop.");
                            Console.WriteLine("[ Enter to continue ]\n");
                            Console.ReadLine();
                        }
                    }

                }
                else if (answer == "5") // List
                {

                    int petNumber = 0;
                    decimal shopTotal = 0;
                    Console.WriteLine("\nListing Pets: ");

                    foreach (Pet peti in petShop1.pets)
                    {
                        petNumber = petNumber + 1;
                        shopTotal = shopTotal + peti.Price-peti.Price/100*Discount;
                        Console.WriteLine(petShop1.listPets($"{peti.Name} is a {peti.Species} who is {peti.Age} years, his base price is costs {peti.Price} and can {peti.MagicPower}"));
                    }
                    Console.WriteLine($"\nThere are {petNumber} pets in your store. There's {3 - petNumber} more to add, and the shop's current total price is ${shopTotal}.");
                    Console.WriteLine("[ Enter to continue ]\n");
                    Console.ReadLine();
                }
                else if (answer == "6") // Leave
                {
                    Console.WriteLine("Goodbye!");
                    keepPlaying = false;
                }
            }
        }
    }
}