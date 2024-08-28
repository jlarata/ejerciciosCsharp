/** Class person, student and teacher
Last updated: 8/26/2020 ⁃ Difficulty: Intermediate

Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

    Person
    Student
    Professor

The Student and Teacher classes inherit from the Person class.

The Student class will include a public Study() method that will write I'm studying on
 the screen.
The Person class must have two public methods Greet() and SetAge(int age) that will
 assign the age of the person.
The Teacher class will include a public Explain() method that will write I'm explaining
 on the screen.
Also create a public method ShowAge() in the Student class that writes My age is: x years
 old on the screen.
You must create another test class called StudentProfessorTest with a Main method to do
 the following:
    Create a new Person and make him say hello
    Create a new Student, set an age, say hello, and display her age on the screen.
    Create a new Teacher, set an age, say hello and start the explanation.

Input

     *none*

Output

    Hello!
    Hello!
    My age is 21 years old
    I'm studying
    Hello!
    I'm explaining**/

class Ejercicio03
    {     
        static void Main(string[] args) {
            StudentProfessorTest spt = new();
            spt.Main();
        }

        class Persona {

            private int age;
            public void Greet() {
                Console.WriteLine("Holis");
            }
            public int GetAge() {
                return age;
            }
            public void SetAge(int input) {
                this.age = input;
            }
        };
        class Estudiante : Persona {
            public void Study() {
                Console.WriteLine("Estoy estudiando caracho!");
            }
            public void ShowAge() {
                Console.WriteLine($"Tengo {this.GetAge()} añitos");
            }           
        };
        class Profesor : Persona {
            public void Teach() {
                Console.WriteLine("Estoy enseñando caracho!");
            }
        };
        class StudentProfessorTest {
            public void Main() {
                Persona persona = new();
                persona.Greet();
                Estudiante estudiante = new();
                estudiante.Greet();
                estudiante.SetAge(21);
                estudiante.ShowAge();
                estudiante.Study();
                Profesor profesor = new();
                profesor.SetAge(56);
                profesor.Greet();
                profesor.Teach();

            }
        }
    }

    