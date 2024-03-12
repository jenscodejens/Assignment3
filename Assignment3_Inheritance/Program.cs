using Assignment3_Inheritance.BirdFiles;

namespace Assignment3_Inheritance
{
    internal class Program
    {
        /*
         * Svaren på frågorna ligger i foldern Solution Items 
         */
        static void Main(string[] args)
        {
            var bird = new Flamingo("Seagull", 15, 2.3f, 7.1f, 60, "Pink");
            //Console.WriteLine(bird.DoSound());
            //Console.WriteLine(bird.AnimalProperties() + "\n");

            var wolf = new Wolf("Snowie", 9, 60.3f, 65.4f, "Artic");
            //Console.WriteLine(wolf.DoSound());
            //Console.WriteLine(wolf.AnimalProperties() + "\n");

            var wolfman = new Wolfman("Wolfie", 56, 78.1f, 183, "Fables");
            //Console.WriteLine(wolfman.DoSound());
            //Console.WriteLine(wolfman.Talk());
            //Console.WriteLine(wolf.AnimalProperties() + "\n"); // Har inga distinkta properties så ärver wolf rakt av

            var dog1 = new Dog("Fido", 15, 35.2f, 14f, "Striped Brown & Black");
            var dog2 = new Dog("Fidolina", 15, 35.2f, 14f, "White");

            List<Animal> animals = new List<Animal>();
            animals.Add(bird);
            animals.Add(wolf);
            animals.Add(wolfman);
            animals.Add(dog1);
            animals.Add(dog2);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.DoSound());
                Console.WriteLine(animal.Stats());
                if (animal is IPerson)
                {
                    Console.WriteLine(wolfman.Talk());
                }
                Console.WriteLine();
            }

            // Blev osäker på om uppgiften vill ha properties per djur nu, eller properties och value.
            // Så ni får properties ovan och för dogs properties + value
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
