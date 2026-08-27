using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spider sp1 = new Spider("Tarantula", "Fluffy", 3, 50.0, 8, false);
            Spider sp2 = new Spider("Black Widow", "Venom", 2, 75.0, 8, false);
            Spider sp3 = new Spider("Jumping Spider", "Jumpy", 1, 30.0, 8, false);
            Dog d1 = new Dog("Labrador", "Buddy", 5, 200.0, 4, false);
            Dog d2 = new Dog("German Shepherd", "Max", 4, 250.0, 4, false);
            Dog d3 = new Dog("Golden Retriever", "Charlie", 3, 300.0, 4, false);
            Snake sn1 = new Snake("Python", "Slytherin", 6, 150.0, 0, true);
            Snake sn2 = new Snake("Cobra", "Naja", 4, 100.0, 0, true);
            Snake sn3 = new Snake("Rattlesnake", "Rattler", 2, 75.0, 0, true);

            List<Spider> spiders = new List<Spider> { sp1, sp2, sp3 };
            List<Dog> dogs = new List<Dog> { d1, d2, d3 };
            List<Snake> snakes = new List<Snake> { sn1, sn2, sn3 };

            double billigstPrisSpider = 99999999999999999;
            double billigstPrisDog = 99999999999999999;
            double billigstPrisSnake = 99999999999999999;
            int billigstPrisSpiderIndex = 0;
            int billigstPrisDogIndex = 0;
            int billigstPrisSnakeIndex = 0;

            for (int i = 0; i < spiders.Count; i++)
            {

                if (spiders[i].getPris() < billigstPrisSpider )
                {
                    billigstPrisSpider = spiders[i].getPris();
                    billigstPrisSpiderIndex = i;
                }
                
            }
            spiders[billigstPrisSpiderIndex].printAll();

            for (int i = 0; i < dogs.Count; i++)
            {

                if (dogs[i].getPris() < billigstPrisDog)
                {
                    billigstPrisDog = dogs[i].getPris();
                    billigstPrisDogIndex = i;
                }

            }
            dogs[billigstPrisDogIndex].printAll();

            for (int i = 0; i < snakes.Count; i++)
            {

                if (snakes[i].getPris() < billigstPrisSnake)
                {
                    billigstPrisSnake = snakes[i].getPris();
                    billigstPrisSnakeIndex = i;
                }

            }
            snakes[billigstPrisSnakeIndex].printAll();



        }
    }   
}
