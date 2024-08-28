public class ConstructorsAndDestructors
    {     
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
                //alternativa: persons[i] = new Person(namesArray[i]);
                persons[i] = new Person("");
                persons[i].Name = namesArray[i];
            }
        }
        public static void printThreeNames(Person[] persons) {
            for (int i = 0; i<3; i++){
                Console.Write(persons[i].Name+" ");
                //Console.Write(persons[i].getName()+" ");
                //Console.WriteLine(persons[i].ToString());
            }
        }        
    };
    public class Person {
            private string _name;
            public Person(string name)
            {
                _name = name;
            }

            public string Name { get {return _name;} set {_name = value;} }

            public override string ToString()
            {
                return "Hello, my name is "+ _name;
            }
            ~Person() {
                _name = string.Empty;
            }
    }