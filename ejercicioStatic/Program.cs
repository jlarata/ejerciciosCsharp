

/* lo que importa es el static field "dogcount" en la clase dog*/

class EjercicioStatic{
    static void Main() {
        Dog dog1 = new("Firulais", 5);
        Dog dog2 = new("violeta", 2);
        Dog dog3 = new("Jazmin",182);
        Dog dog4 = new("India",13);

        Dog[] dogs = new Dog[Dog.dogCount];
        dogs[0] = dog1;
        dogs[1] = dog2;
        dogs[2] = dog3;
        dogs[3] = dog4;

        Console.WriteLine($"there are {Dog.dogCount} dogs instantiated: ");
        
        for (int i = 0; i <Dog.dogCount; i++) {
            Console.WriteLine(dogs[i].Name);
        }
    }

    public class Dog{
        private string name;
        private int age;
        public static int dogCount = 0;
        public Dog(string name, int age){
            this.name = name;
            this.age = age;
            
            Dog.dogCount += 1;
        }
        public string Name {get {return this.name;} }
    }
}