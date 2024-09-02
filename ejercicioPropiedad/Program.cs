

class EjercicioPropiedades {
    static void Main () {
        Rectangulo recti1 = new(3, 6);
        Console.WriteLine($"El área de un rectángulo de {recti1.Width} * {recti1.Heigth} es {recti1.Area}");
    }

    public class Rectangulo{
        private float width;
        private float heigth;

        public float Width {get => this.width; }
        public float Heigth {get => this.heigth; }

        public Rectangulo(float width, float heigth){
            this.width = width;
            this.heigth = heigth;
        }
        /* Nótese que lo que sigue no es un método, sino una propiedad
        nótese también que no guarda su valor en ningún field, cosa que
        perfectamente podría ser (un private float area más arriba) 
        pero que en este caso no es necesaria */
        public float Area {
            get { return this.heigth * this.width; }
        }
    }

}