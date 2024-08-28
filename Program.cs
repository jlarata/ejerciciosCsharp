// See https://aka.ms/new-console-template for more information

namespace Application {
    class Program
    {
        static void Main(string[] args) {
        
        Persona persona1 = crearPersona("ariel", 38);
        Socio socio1 = crearSocio("david", 20);
        Cliente cliente1 = crearCliente("elena");
        cliente1.Edad = 66;

        Console.WriteLine(persona1.saludar());
        Console.WriteLine(socio1.saludar());
        Console.WriteLine(cliente1.saludar());


        Persona crearPersona(string nombre, int edad) {
            Persona p = new Persona();
            p.Name = nombre;
            p.Edad = edad;
            return p;
        }
        Socio crearSocio(string nombre, int edad) {
            Socio s = new Socio();
            s.Name = nombre;
            s.Edad = edad;
            return s;
        }
        Cliente crearCliente(string nombre) {
            Cliente c = new Cliente();
            c.Name = nombre;
            return c;
        }

        }

        public class Persona {
            private string name = "";
            private int edad;
            public string Name { get => name; set { name = value; } }
            public int Edad { get => edad; set { edad = value; } }

            public string saludar() {
                return "hola, me lamo "+name+", tengo "+edad+" años y soy de la clase "+this.GetType();
            }
        }
        public class Socio : Persona {};
        public class Cliente : Persona {};
    }
}

