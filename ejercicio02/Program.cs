class ConstructorsAndDestructors
    {     
        static void Main(string[] args) {
        
        Person[] persons = new Person[3];

        string[] namesArray = new string[3];     
        
        namesArray = AskThreeNames();
        SetThreeNames(persons, namesArray);
        PrintThreeNames(persons);    
        
        }

        static string[] AskThreeNames() {
            
            string[] namesArray = new string[3];

            for (int i = 0; i<3; i++){
                Console.WriteLine("Ingrese el nombre Nº {0}: ", i+1);
                namesArray[i] = Console.ReadLine();
            }
            return namesArray;
        }

        static void SetThreeNames(Person[] persons, string[] namesArray) {
            for (int i = 0; i<3; i++){
                //alternativa: persons[i] = new Person(namesArray[i]);
                persons[i] = new Person("...");
                persons[i].Name = namesArray[i];
            }
        }
        static void PrintThreeNames(Person[] persons) {
            for (int i = 0; i<3; i++){
                Console.Write(persons[i].Name+" ");
                //Console.Write(persons[i].getName()+" ");
                //Console.WriteLine(persons[i].ToString());
            }
        }        
            class Person {
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
    };
