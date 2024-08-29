/* Interfaces
Last updated: 8/26/2020 ⁃ Difficulty: Intermediate

Create a C# program that implements an IVehiculo interface with two methods, one for Drive of type void
 and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline
  to refuel. Then create a Car class with a builder that receives a parameter with the car's starting
   gasoline amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0.
 The Refuel method will increase the gasoline of the car and return true.

To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program 
and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.
Input

    50

Output

    Driving*/

class Interfaces{

    static void Main() {

        IVehiculo autito = new Car(0);
        autito.Drive();
        autito.Refuel(1);
        autito.Drive();
    }

    interface IVehiculo {
        void Drive() {

        }

        bool Refuel(int gasoline) {
            return true;
        }
    }

    class Car(int startingGas) : IVehiculo {
        public int gasoline = startingGas;

        void IVehiculo.Drive() {
            if (gasoline > 0) {
                Console.WriteLine("driving");
            } else {
                Console.WriteLine("not enough gas...");
            }
        }

        bool IVehiculo.Refuel(int gasCharge) {
            gasoline += gasCharge;
            return true;
        }

    }
}