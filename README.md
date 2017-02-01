# Instructions

1. Create an `Animals` subdirectory in your project. All of your animal-related classes will be created that directory.

## Namespaces

Using namespaces is another way to organize your classes at the code level. Think of them as simple buckets in which related classes exist.

1. Ensure that each of your animal classes belong to the `Zoolandia.Animals` namespace.

## Making Animals

1. Create your first C# class - the Animal class. Create some simple properties and methods on Animal. You are going to create some derived classes that inherit from Animal, so make sure that the properties/methods you add are general to **all** Animals (e.g. name, height, weight, etc).

    ##### Example property/method definition

    ```cs
    namespace Zoolandia.Animals
    {
        class Animal
        {
            public string name { get; set; }

            public void sleep ()
            {
                Console.WriteLine("ZZzzzzzzz...");
            }
        }
    }
    ```

1. After you are happy with your Animal class, create a derived class that defines a particular species of Animal. Create some properties that apply **only** to that species.

    ```cs
    namespace Zoolandia.Animals
    {
        // The species for a Red Pana
        class AilurusFulgens : Animal
        {
            // Define simple properties for a Red Panda
        }
    }
    ```

1. Create three more classes for species of animals of your choosing. Wikipedia is a great tool to discover species names. Make sure you use a mix of native C# types for your properties.
1. Create some instances of your species.
1. Assign values to the properties of each.
1. Use `Console.WriteLine();` to output the property values of your animals to the console.

    ```cs
    // Example
    Console.WriteLine($"I have a Squirrel named {squirrel.name} who makes a 
    noise that sounds like {squirrel.signatureNoise}. I'd rate its cuteness 
    at {squirrel.cutenessFactor}.");
    ```  
    
-------------------------------------    

### Virtual/Override

1. Choose one of the general methods that you created in the `Animal` class and make it `virtual`.
1. Override that method in all of your species classes, giving each a more specialized implementation. For example, the species may only eat certain kinds of food, or have a limit on how much food can be eaten.
1. Make sure you invoke the parent class' overridden method with the `base` reference (e.g. `base.sleep()`);

### Constructors

1. Create a constructor function for each of your animals. The constructor function should, at the very least, set the initial name of all animals of that type to a name of your choosing.
  
  ```cs
  public MyAnimal ()
  {
    this.name = "Moopsie";
  }
  ```

1. Use `Console.WriteLine();` to output the name of each of your animal instances.

  ```cs
  MyAnimal animalInstance = new MyAnimal();
  Console.WriteLine(animalInstance.name);
  ```
  
1. Add a new, overloaded constructor method to your animal that takes a single string as an argument.
1. Inside the new constructor, using `this`, assign the value of the `name` property with the argument value.
1. Create an instance of your animal like before, but pass in the name of the animal as an argument.

	```
	Squirrel superman = new Squirrel("Sammy");
	Console.Write(superman.name);
	```

1. Add **another** overloaded constructor method that will set the value of one of the `int` typed properties of your animal. Define an integer as an argument and then create another instance of your animal and pass it an integer.
1. Add **ONE MORE** constructor method! This method will accept both an integer and a string as arguments. Set the appropriate property values with the argument values.  

-------------

1. Decide on ~6 species that you would like to include in your zoo and create a class for each species. 
1. Each species should inherit from the appropriate genus (in a class that you create), and each genus should inherit from the `Animal` class.

```cs
// Base animal class
public class Animal 
{
	// add properties and methods
}

// Genus class, inherits from animal class
public class Equus : Animal 
{
	//add properties and methods
}

// Species class, inherits from the corresponding genus class
public class Quagga : Equus
{
    string commonName = "Zebra";
	string scientificName = "Equus quagga";
	// add more properties and methods
}
```  
------------

1. Once you've created all of your species, give them some methods and properties. Include several methods on your Animal and/or genus classes that can be overridden and then override them in your species classes.
1. Create some overloaded methods on some of your species (or genus) classes.

> **Examples:** Here's some ideas on methods you can add to an animal.
> 
> * `walk()` and `walk(double speed)` and `walk(double speed, string destination)`
> * `eat()` and `eat(string food)`
> * `sleep()` and `sleep(int hours)` and `sleep(int hours, string location)`

Is a species a genus?

Is a genus an animal?

Isn't species a *property* of an animal instead?

What if the genus was a property of the species?

Read the [inheritance, composition, and aggregation](../../resources/FND_INHERIT_COMPOSE_AGGREGATE.md) file again and refactor your code to have appropriate `is-a`, `part-of`, and `has-a` relationships.  

-------
Your job is to think about interfaces that can be implemented by groups of your classes. Think about the examples that you were shown in live-coding.

* ICanines
* IFlying
* IAmbulatory
* IInsect
* ISwimming
* etc...
  
-----------------------------------  

For this last Zoolandia exercises for the Foundations Milestone, you need to define all of the Habitats in which all of the animals live. You'll use the [aggregation](../../resources/FND_INHERIT_COMPOSE_AGGREGATE.md#aggregation) pattern to assign animals to each Habitat.

In this example code, I create the parent `Habitat` class that all others will derive from, and since every habitat in my Zoo will have animals in it, each specific habitat class will inherit that `inhabitant` property.

In the derived class, I inherit from `Habitat`, and implement the `IAquaticHabitat` interface. There's a private property that defines if the aquarium is freshwater or saltwater, another private property that will hold a list of employees who are responsible for being in the tank with the animals.

##### Example Habitat Class

```cs
using System.Collections.Generic;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
      // Instantiated a new list, which will contain animals.
      // You will add animals at run time (i.e. in `static void Main()
      // `)
      public List<Animal> inhabitants = new List<Animal>();
      public string public_name { get; set; }
  }

  public interface IAquaticHabitat
  {
    void empty();
    void fill();

    double volume { get; set; }
  }

  public class Aquarium : Habitat, IAquaticHabitat
  {
      private bool _saltwater = false;
      public double volume { get; set; }
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }
      private List<Employee> scubaCrew = new List<Employee>();

      // `public_name`, and `saltwater` properties can only be set when habitat is created
      public Aquarium (string name, bool isSaltwater)
      {
          _saltwater = isSaltwater;
          this.public_name = name;
      }
  }
}
```

Once you have defined all of your habitats, write logic to output the name of each habitat, and the name of each animal it contains to the command line.

##### Example CLI Output

```bash
Habitat: Aquarium
   Dolphin
   Yellow Shark
   Octopus

Habitat: Savannah
   Giraffe
   Zebra
   Hippopotamus
```
