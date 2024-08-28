// See https://aka.ms/new-console-template for more information


Persona pepe = new Persona{};
pepe.nombre = "pepe";

Console.WriteLine($"bienvenido, {pepe.nombre}");

class Persona {
    public string nombre = "iniciado sin nombre";
}
