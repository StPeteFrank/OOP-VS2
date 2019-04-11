using OOP_VS.Classes;
using System;
using System.Collections.Generic;

namespace OOP_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Coordinate();
            point.Latitude = (decimal)-82.34561;
            point.Longitude = (decimal)-27.9674;
            point.Label = "Somewhere you want to be";
            point.Color = "Red";
            Console.WriteLine(point);

            var workPants = new Pants("Haggar", "Blue", 32, 31);
            workPants.Worn("Frank");
            Console.WriteLine(workPants);
           
            var cat = new Pet("King", "Maine Coon");
            cat.Adopt("Frank");
            Console.WriteLine(cat);


            var newCar = new Car("Volkswagen", "Jetta GLI", 2017, true, 90, 29000, 210);
            newCar.Driver("Frank");
            newCar.IncreaseSpeed(10);
            newCar.DecreaseValue(9000);
            newCar.IncreaseHP(15);
            Console.WriteLine(newCar);


            var newCar2 = new Car("Nissan", "Skyline", 1999, true, 110, 150000, 376);
            newCar2.Driver("Carla");
            newCar2.IncreaseSpeed(20);
            newCar2.IncreaseValue(20000);
            newCar2.DecreaseHP(20);
            Console.WriteLine(newCar2);


            var airplane1 = new Airplane("Boeing", "SuperMax 8");   // Passing arguments to this instance of a class.
            airplane1.GroundedPlane(true, "Delta Airlines");        // Passing arguments to this method used in the airplane1 class instance.
            Console.WriteLine(airplane1);


            var airplane2 = new Airplane("Airbus", "A321");
            airplane2.GroundedPlane(false, "Air France");
            Console.WriteLine(airplane2);

            var myPack = new BackPack("Frank", "Red", 12);
            for (var i = 0; i < 3; i++)
            {
                myPack.AddItem();
            }
            var campingPack = new BackPack("Mark", "Blue", 36);
            for (var i = 0; i < 13; i++)
            {
                campingPack.AddItem();
            }
            var purse = new BackPack("Carla", "Green", 6);
            for (var i = 0; i < 10; i++)
            {
                purse.AddItem();
            }
            Console.WriteLine(myPack);
            Console.WriteLine(campingPack);
            Console.WriteLine(purse);

            var pegasus1 = new Pegasus(45, 50);
            pegasus1.IncreaseSpeed(20);
            pegasus1.FlapWings(50);
            Console.WriteLine(pegasus1);

            var bird1 = new Bird(20);
            bird1.FlapWings(10);
            Console.WriteLine(bird1);

            var horse1 = new Horse(30, 30);
            horse1.IncreaseSpeed(40);
            horse1.FlapWings(50);
            Console.WriteLine(horse1);

           /* var animal1 = new Animal {
                 Name = "Wilbur",
                 FavoriteFood = "Slop",
                 Greeting = "Oink"
             };
            animal1.Speak();
            animal1.Eat();
            Console.WriteLine("Hello");*/

            var animal2 = new Mule
            {
                Name = "StubbornDale"
            };
            animal2.Speak();
            animal2.Eat();

            //

            var lancelot = new Knight();
            var legolas = new Archer();
            var merlin = new Wizard();
            

            var army = new List<Warrior>();
            army.Add(lancelot);
            army.Add(legolas);
            army.Add(merlin);

            army.ForEach(fighter => fighter.Attack());

            //

            var lancelot2 = new Knight2();
            var legolas2 = new Archer2();
            var merlin2 = new Wizard2();
            var golem2 = new Giant2();
            var gimmly2 = new Cleric2();
            
            
            var army2 = new List<Warrior2>();
            army2.Add(lancelot2);
            army2.Add(legolas2);
            army2.Add(merlin2);
            army2.Add(golem2);
            army2.Add(gimmly2);
            

            army2.ForEach(fighter => fighter.Attack());

            //
            var mickeyMantel = new BaseballPlayer();
            var michaelJordan = new BasketballPlayer();
            var danMarino = new FootballPlayer();
            var joeMontana = new FootballPlayer();

            var league = new List<ScoringAthlete>();
            league.Add(mickeyMantel);
            league.Add(michaelJordan);
            league.Add(danMarino);
            league.Add(joeMontana);

            league.ForEach(player => player.Score());



            //
            Console.ReadLine();
        }
    }
}
