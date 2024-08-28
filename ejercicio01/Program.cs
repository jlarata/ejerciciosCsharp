class Ejercicio01
    {     
        static void Main(string[] args) {
        
            Personito[] persons = new Personito[3];

            string[] namesArray = new string[3];     
            
            namesArray = askThreeNames();
            setThreeNames(persons, namesArray);
            printThreeNames(persons);
        }

        static string[] askThreeNames() {
            
            string[] namesArray = new string[3];

            for (int i = 0; i<3; i++){
                Console.WriteLine("Ingrese el nombre Nº {0}: ", i+1);
                namesArray[i] = Console.ReadLine()!;
            }
            return namesArray;
        }

        static void setThreeNames(Personito[] persons, string[] namesArray) {
            for (int i = 0; i<3; i++){
                persons[i] = new Personito();
                persons[i].SetName(namesArray[i]);
            }
        }

        static void printThreeNames(Personito[] persons) {
            for (int i = 0; i<3; i++){
                Console.WriteLine(persons[i].ToString());
            }
        }

        class Personito {
            private string Name = "inicialized without name";
                
            public void SetName(String input){
                Name = input;
            }

            public String GetName(){
                return Name;
            }

                //las clases incluyen un método llamado ToString que devuelve por defecto un string con la clase del objeto
                //en este caso devolvería tres veces "ejercicio01.Person"
                //el ejercicio constaba en overridearlo para obtener la propiedad.
            public override string ToString()
            {
                return "Hola, me llamo "+ GetName();
            }
        }
    }