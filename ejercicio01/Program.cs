static void Main(string[] args) {
        
        Person[] persons = new Person[3];

        string[] namesArray = new string[3];     
        
        namesArray = askThreeNames();
        setThreeNames(persons, namesArray);
        printThreeNames(persons);    
        
        }

        public static string[] askThreeNames() {
            
            string[] namesArray = new string[3];

            for (int i = 0; i<3; i++){
                Console.WriteLine("Ingrese el nombre Nº {0}: ", i+1);
                namesArray[i] = Console.ReadLine();
            }
            return namesArray;
        }

        public static void setThreeNames(Person[] persons, string[] namesArray) {
            for (int i = 0; i<3; i++){
                persons[i] = new Person();
                persons[i].setName(namesArray[i]);
            }
        }

        public static void printThreeNames(Person[] persons) {
            for (int i = 0; i<3; i++){
                Console.WriteLine(persons[i].ToString());
            }
        }
        
    };
    public class Person {
            private string Name;
            
            public void setName(String input){
            Name = input;
            }

            public String getName(){
            return Name;
            }

            //las clases incluyen un método llamado ToString que devuelve por defecto un string con la clase del objeto
            //en este caso devolvería tres veces "ejercicio01.Person"
            //el ejercicio constaba en overridearlo para obtener la propiedad.
            public override string ToString()
            {
                return "Hello, my name is "+ Name;
            }