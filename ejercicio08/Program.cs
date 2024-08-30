/* Abstract classes
Last updated: 8/23/2020 ⁃ Difficulty: Intermediate

Create a C# program that implements an abstract class Animal that has a Name property of type text and three
 methods SetName (string name), GetName and Eat. The Eat method will be an abstract method of type void.

You will also need to create a Dog class that implements the above Animal class and the Eat method that says
 the dog is Eating.

To test the program ask the user for a dog name and create a new Dog type object from the Main of the program,
 give the Dog object a name, and then execute the GetName and Eat methods.
Input

    Tobby

Output

    Tobby
    Eating*/

using System.Collections;

class Ejercicio08 {

    static void Main() {
        Dog perritus = new();
        Console.WriteLine("Please enter a name for the doge: ");
        perritus.SetName(Console.ReadLine()!);
        perritus.Eat();
    }

    public abstract class Animal {
        private string? name;

        public void SetName(string n){
            name = n;
        }
        public string GetName(){
            return name!;
        }
        abstract public void Eat();
    }

    public class Dog : Animal {
        
        public override void Eat()
        {
            Console.WriteLine($"The dog {GetName()} is eating...");
        }

    }

}