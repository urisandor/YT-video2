using System.Numerics;
using System.Security.Cryptography;

namespace YT_video2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Params Keyword
            //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            // double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            // 
            // Console.WriteLine(total);
            // Console.ReadKey();
            // 
            // static double CheckOut(params double[] prices)
            // {
            //     double total = 0;
            // 
            //     foreach (double price in prices)
            //     {
            //         total += price;
            //     }
            //     return total;
            // }
            #endregion

            #region Exception Handling
            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            // int x;
            // int y;
            // double result;
            // 
            // try
            // {
            //     Console.Write("Enter number 1: ");
            //     x = Convert.ToInt32(Console.ReadLine());
            // 
            //     Console.Write("Enter number 2: ");
            //     y = Convert.ToInt32(Console.ReadLine());
            // 
            //     result = x / y;
            // 
            //     Console.WriteLine("result: " + result);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine("Enter ONLY numbers PLEASE!");
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine("You can't divide by zero! IDIOT!");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Something went wrong!");
            // }
            // finally
            // {
            //     Console.WriteLine("Thanks for visiting!");
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Conditional Operator
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            // double temperature = 20;
            // String message;
            // 
            // message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
            // 
            // Console.WriteLine(message);
            // 
            // Console.ReadKey();
            #endregion

            #region String Interpolation
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            // String firstName = "Bro";
            // String lastName = "Code";
            // int age = 21;
            // 
            // Console.WriteLine($"Hello {firstName} {lastName}.");
            // Console.WriteLine($"You are {age,-10} old.");
            // 
            // Console.ReadKey();
            #endregion

            #region Multidimensional Arrays
            //String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
            //                                      { "Corvette", "Camaro", "Silverado" },
            //                                      { "Corolla", "Camry", "Rav4" }
            //                                    };
            //
            // parkingLot[0, 2] = "Fusion";
            // parkingLot[2, 0] = "Tacoma";
            /*
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */
            // for (int i = 0; i < parkingLot.GetLength(0); i++)  ??
            // {
            //     for (int j = 0; j < parkingLot.GetLength(1); j++)  ??  ?1
            //     {
            //         Console.Write(parkingLot[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Classes
            // class = A bundle of related code.
            //              Can be used as a blueprint to create objects (OOP)

            // Messages.Hello();
            // Messages.Waiting();
            // Messages.Bye();
            // 
            // Console.ReadKey();
            #endregion

            #region Objects
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            // Human human1 = new Human();
            // Human human2 = new Human();
            // 
            // human1.name = "Rick";
            // human1.age = 65;
            // 
            // human2.name = "Morty";
            // human2.age = 16;
            // 
            // human1.Eat();
            // human1.Sleep();
            // 
            // human2.Eat();
            // human2.Sleep();
            // 
            // Console.ReadKey();


            #endregion

            #region Constructor
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            //  Car car1 = new Car("Ford", "Mustang", 2022, "red");
            //  Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            // 
            //  car1.Drive();
            //  car2.Drive();
            // 
            //  Console.ReadKey();
            #endregion

            #region Static
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            // Car car1 = new Car("Mustang");
            // Car car2 = new Car("Corvette");
            // Car car3 = new Car("Lambo");
            // 
            // Console.WriteLine(Car.numberOfCars);
            // Car.StartRace();
            // 
            // Console.ReadKey();
            #endregion

            #region OverLoaded Constructors
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            // Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");
            // 
            // Console.ReadKey();
            #endregion

            #region Inheritance
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            // Car car = new Car();
            // Bicycle bicycle = new Bicycle();
            // Boat boat = new Boat();
            // 
            // Console.WriteLine(car.speed);
            // Console.WriteLine(car.wheels);
            // car.go();
            // 
            // Console.WriteLine(bicycle.speed);
            // Console.WriteLine(bicycle.wheels);
            // bicycle.go();
            // 
            // Console.WriteLine(boat.speed);
            // Console.WriteLine(boat.wheels);
            // boat.go();
            // 
            // Console.ReadKey();
            #endregion

            #region Abstract
            // abstract classes =  modifier that indicates missing components or incomplete implementation

            // Car car = new Car();
            // Bicycle bicycle = new Bicycle();
            // Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //can't create a vehicle object


            // Console.ReadKey();
            #endregion

            #region Array of Objects
            // Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };
            // 
            // foreach (Car car in garage)
            // {
            //     Console.WriteLine(car.model);
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region Objects As Arguments
            // Car car1 = new Car("Mustang", "red");
            // 
            // Car car2 = Copy(car1);
            // 
            // Console.WriteLine(car2.color + " " + car2.model);
            // 
            // Console.ReadKey();
            #endregion

            #region Method Overriding
            //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism 

            // Dog dog = new Dog();
            // Cat cat = new Cat();
            // 
            // dog.Speak();
            // cat.Speak();
            // 
            // Console.ReadKey();
            #endregion

            #region ToString method
            //ToString() = converts an object to its string representation so that it is suitable for display

            // Car car = new Car("Chevy", "Corvette", 2022, "blue");
            //
            // Console.WriteLine(car.ToString());
            //
            // Console.ReadKey();
            #endregion

            #region Polymorphism
            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            // Car car = new Car();
            // Bicycle bicycle = new Bicycle();
            // Boat boat = new Boat();
            //
            // Vehicle[] vehicles = { car, bicycle, boat };
            //
            // foreach (Vehicle vehicle in vehicles)
            // {
            //     vehicle.Go();
            // }
            //
            // Console.ReadKey();
            #endregion

            #region Interface
            // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             benefits = security + multiple inheritance + "plug-and-play"

            // Rabbit rabbit = new Rabbit();
            // Hawk hawk = new Hawk();
            // Fish fish = new Fish();
            // 
            // rabbit.Flee();
            // hawk.Hunt();
            // fish.Flee();
            // fish.Hunt();
            // 
            // Console.ReadKey();
            #endregion

            #region Lists
            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size 
            //        using System.Collections.Generic;

            // List<String> food = new List<String>();
            // 
            // food.Add("pizza");
            // food.Add("hamburger");
            // food.Add("hotdog");
            // food.Add("fries");

            //Console.WriteLine(food[0]);
            //Console.WriteLine(food[1]);
            //Console.WriteLine(food[2]);
            //Console.WriteLine(food[3]);

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("fries"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            // foreach (String item in food)
            // {
            //     Console.WriteLine(item);
            // }
            // 
            // Console.ReadKey();
            #endregion

            #region List of objects
            // List<Player> players = new List<Player>();
            //
            // players.Add(new Player("Chad"));
            // players.Add(new Player("Steve"));
            // players.Add(new Player("Karen"));
            //
            // foreach (Player player in players)
            // {
            //     Console.WriteLine(player);
            // }
            //
            // Console.ReadKey();
            #endregion

            #region Getters & Setters
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            // Car car = new Car(400);
            // 
            // car.Speed = 1000000000;
            // 
            // Console.WriteLine(car.Speed);
            // 
            // Console.ReadKey();
            #endregion

            #region  Auto-Implemented Property
            // auto-Implemented property =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property                             

            // Car car = new Car("Porsche");
            // 
            // Console.WriteLine(car.Model);
            // 
            // Console.ReadKey();
            #endregion

            #region Enums 
            // enums = special "class" that contains a set of named integer constants.
            //         Use enums when you have values that you know will not change,
            //         To get the integer value from an item, you must explicitly convert to an int

            //         name = integer

            //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            //  String name = PlanetRadius.Earth.ToString();
            //  int radius = (int)PlanetRadius.Earth;
            //  double volume = Volume(PlanetRadius.Earth);
            // 
            //  Console.WriteLine("planet: " + name);
            //  Console.WriteLine("radius: " + radius + "km");
            //  Console.WriteLine("volume: " + volume + "km^3");
            // 
            //  Console.ReadKey();
            #endregion

            #region Generics
            // generic =  "not specific to a particular data type"
            //            add <T> to: classes, methods, fields, etc.
            //            allows for code reusability for different data types

            // int[] intArray = { 1, 2, 3 };
            // double[] doubleArray = { 1.0, 2.0, 3.0 };
            // String[] stringArray = { "1", "2", "3" };
            // 
            // displayElements(intArray);
            // displayElements(doubleArray);
            // displayElements(stringArray);
            // 
            // Console.ReadKey();
            #endregion

            #region Multithreading
            // thread = an execution path of a program
            //          We can use multiple threads to perform,
            //          different tasks of our program at the same time.
            //          Current thread running is "main" thread
            //          using System.Threading;

            // Thread mainThread = Thread.CurrentThread;
            // mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            // Thread thread1 = new Thread(() => CountDown("Timer #1"));
            // Thread thread2 = new Thread(() => CountUp("Timer #2"));
            // 
            // thread1.Start();
            // thread2.Start();
            // 
            // Console.WriteLine(mainThread.Name + " is complete!");
            // 
            // Console.ReadKey();
            #endregion

        }
        #region Objects
        // class Human
        // {
        //     public String name;
        //     public int age;
        // 
        //     public void Eat()
        //     {
        //         Console.WriteLine(name + " is eating");
        //     }
        //     public void Sleep()
        //     {
        //         Console.WriteLine(name + " is sleeping");
        //     }
        // }
        #endregion

        #region Objects As Arguments
        // public static void ChangeColor(Car car, String color)
        // {
        //     car.color = color;
        // }
        // 
        // public static Car Copy(Car car)
        // {
        //     return new Car(car.model, car.color);
        // }
        #endregion

        #region Enums 
        // public static double Volume(PlanetRadius radius)
        // {
        //     double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        //     return volume;
        // }
        #endregion

        #region Generics
        // public static void displayElements<Thing>(Thing[] array)
        // {
        //     foreach (Thing item in array)
        //     {
        //         Console.Write(item + " ");
        //     }
        //     Console.WriteLine();
        // }
        #endregion

        #region Multithreading 
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
        #endregion 


    }
    #region Constructor
    // class Car
    // {
    //     String make;
    //     String model;
    //     int year;
    //     String color;
    // 
    //     public Car(String make, String model, int year, String color)
    //     {
    //         this.make = make;
    //         this.model = model;
    //         this.year = year;
    //         this.color = color;
    //     }
    // 
    //     public void Drive()
    //     {
    //         Console.WriteLine("You drive the " + make + " " + model);
    //     }
    // }
    #endregion

    #region Static
    // class Car
    // {
    //     String model;
    //     public static int numberOfCars;
    // 
    //     public Car(String model)
    //     {
    //         this.model = model;
    //         numberOfCars++;
    //     }
    // 
    //     public static void StartRace()
    //     {
    //         Console.WriteLine("The race has begun!");
    //     }
    // }
    #endregion

    #region OverLoaded Consructors
    // class Pizza
    // {
    //     String bread;
    //     String sauce;
    //     String cheese;
    //     String topping;
    // 
    //     public Pizza(String bread)
    //     {
    //         this.bread = bread;
    //     }
    //     public Pizza(String bread, String sauce)
    //     {
    //         this.bread = bread;
    //         this.sauce = sauce;
    //     }
    //     public Pizza(String bread, String sauce, String cheese)
    //     {
    //         this.bread = bread;
    //         this.sauce = sauce;
    //         this.cheese = cheese;
    //     }
    //     public Pizza(String bread, String sauce, String cheese, String topping)
    //     {
    //         this.bread = bread;
    //         this.sauce = sauce;
    //         this.cheese = cheese;
    //         this.topping = topping;
    //     }
    // }
    #endregion

    #region Inheritance
    // class Vehicle
    // {
    //     public int speed = 0;
    // 
    //     public void go()
    //     {
    //         Console.WriteLine("This vehicle is moving!");
    //     }
    // }
    // class Car : Vehicle
    // {
    //     public int wheels = 4;
    // }
    // class Bicycle : Vehicle
    // {
    //     public int wheels = 2;
    // }
    // class Boat : Vehicle
    // {
    //     public int wheels = 0;
    // }
    #endregion

    #region Abstract
    // abstract class Vehicle
    // {
    //     public int speed = 0;
    // 
    //     public void go()
    //     {
    //         Console.WriteLine("This vehicle is moving!");
    //     }
    // }
    // class Car : Vehicle
    // {
    //     public int wheels = 4;
    //     int maxSpeed = 500;
    // }
    // class Bicycle : Vehicle
    // {
    //     public int wheels = 2;
    //     int maxSpeed = 50;
    // }
    // class Boat : Vehicle
    // {
    //     public int wheels = 0;
    //     int maxSpeed = 100;
    // }
    #endregion

    #region Array of Objects
    // class Car
    // {
    //     public String model;
    // 
    //     public Car(String model)
    //     {
    //         this.model = model;
    //     }
    // }
    #endregion

    #region Objects As Arguments
    // class Car
    // {
    //     public String model;
    //     public String color;
    // 
    //     public Car(String model, String color)
    //     {
    //         this.model = model;
    //         this.color = color;
    //     }
    // }
    #endregion

    #region  Method Overriding
    // class Animal
    // {
    //     public virtual void Speak()
    //     {
    //         Console.WriteLine("The animal goes *brrr*");
    //     }
    // }
    // class Dog : Animal
    // {
    //     public override void Speak()
    //     {
    //         Console.WriteLine("The dog goes *woof*");
    //     }
    // }
    // class Cat : Animal
    // {
    // 
    // }
    #endregion

    #region ToString method
    // class Car
    // {
    //     String make;
    //     String model;
    //     int year;
    //     String color;
    // 
    //     public Car(String make, String model, int year, String color)
    //     {
    //         this.make = make;
    //         this.model = model;
    //         this.year = year;
    //         this.color = color;
    //     }
    //     public override string ToString()
    //     {
    //         return "This is a " + make + " " + model;
    //     }
    // }
    #endregion

    #region Polymorphism
    // class Vehicle
    // {
    //     public virtual void Go()
    //     {
    // 
    //     }
    // }
    // class Car : Vehicle
    // {
    //     public override void Go()
    //     {
    //         Console.WriteLine("The car is moving!");
    //     }
    // }
    // class Bicycle : Vehicle
    // {
    //     public override void Go()
    //     {
    //         Console.WriteLine("The bicycle is moving!");
    //     }
    // }
    // class Boat : Vehicle
    // {
    //     public override void Go()
    //     {
    //         Console.WriteLine("The boat is moving!");
    //     }
    // }
    #endregion

    #region InterFace
    // interface IPrey
    // {
    //     void Flee();
    // }
    // interface IPredator
    // {
    //     void Hunt();
    // }
    // class Rabbit : IPrey
    // {
    //     public void Flee()
    //     {
    //         Console.WriteLine("The rabbit runs away!");
    //     }
    // }
    // class Hawk : IPredator
    // {
    //     public void Hunt()
    //     {
    //         Console.WriteLine("The hawk is searching for food!");
    //     }
    // }
    // class Fish : IPrey, IPredator
    // {
    //     public void Flee()
    //     {
    //         Console.WriteLine("The fish swims away!");
    //     }
    //     public void Hunt()
    //     {
    //         Console.WriteLine("The fish is searching for smaller fish!");
    //     }
    // }
    #endregion

    #region List of objects
    // class Player
    // {
    //     public String username;
    // 
    //     public Player(String username)
    //     {
    //         this.username = username;
    //     }
    //     public override string ToString()
    //     {
    //         return username;
    //     }
    // }
    #endregion

    #region Getters & Setters
    // class Car
    // {
    //     private int speed;
    // 
    //     public Car(int speed)
    //     {
    //         Speed = speed;
    //     }
    // 
    //     public int Speed
    //     {
    //         get { return speed; }
    //         set
    //         {
    //             if (value > 500)
    //             {
    //                 speed = 500;
    //             }
    //             else
    //             {
    //                 speed = value;
    //             }
    //         }
    //     }
    // 
    // }
    #endregion

    #region Auto implemented Properties
    // class Car
    // {
    //     public String Model { get; set; }
    // 
    //     public Car(String model)
    //     {
    //         this.Model = model;
    //     }
    // }
    #endregion

    #region Enums 
    // enum Planets
    // {
    //     Mercury = 1,
    //     Venus = 2,
    //     Earth = 3,
    //     Mars = 4,
    //     Jupiter = 5,
    //     Saturn = 6,
    //     Uranus = 7,
    //     Neptune = 8,
    //     Pluto = 9
    // }
    // 
    // enum PlanetRadius
    // {
    //     Mercury = 2439,
    //     Venus = 6051,
    //     Earth = 6371,
    //     Mars = 3389,
    //     Jupiter = 69911,
    //     Saturn = 58232,
    //     Uranus = 25362,
    //     Neptune = 24622,
    //     Pluto = 1188
    // }
    #endregion 

}



