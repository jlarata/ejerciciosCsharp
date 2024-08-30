class SociosYClientes
{
    static void Main() {
        
        Persona persona1 = crearPersona("ariel", 38);
        Socio socio1 = crearSocio("david", 20);
        Cliente cliente1 = crearCliente("elena");
        cliente1.Edad = 66;

        Console.WriteLine(persona1.Saludar());
        Console.WriteLine(socio1.Saludar());
        Console.WriteLine(cliente1.Saludar());


        static Persona crearPersona(string nombre, int edad) {
            Persona p = new()
            {
                Name = nombre,
                Edad = edad
            };
            return p;
        }
        
        static Socio crearSocio(string nombre, int edad) {
            Socio s = new(){
                Name = nombre,
                Edad = edad,
            };
            return s;
        }
        
        static Cliente crearCliente(string nombre) {
            Cliente c = new(){
                Name = nombre
            };
            return c;
        }

    }

    public class Persona {
        private string name = "";
        private int edad;
        public string Name { get => name; set { name = value; } }
        public int Edad { get => edad; set { edad = value; } }
        public string GetClass(){
            if (this is Socio) {
                return "Socio";
            }
            if (this is Cliente) {
                return "Cliente";
            }
            if (this is not null){
                return "Persona";
            }
            return "error imposible";
        }   
        public string Saludar() {
            return "hola, me lamo "+name+", tengo "+edad+" años y soy de la clase "+GetClass();
        }
    }
    public class Socio : Persona {};
    public class Cliente : Persona {};
}