/*

DISCLAIMER: mi solución es bastante diferente a la que aparece en la web pero me parece superior aunque
más no sea porque tiene más sentido. forma es una noción abstracta, rectángulos y cuadrados deberían ser
sus implementaciones concretas que overrideen los métodos de cálculo de área y perímetro.


Create a C# program that represents the following UML class diagram. The diagram represents public,
 private, and protected attributes as well as class dependency and inheritance.

class Rectangle
#side1: double
#side2: double

class Shape
#c location
----------
+ToString(): string
+Area(): double
+Perimeter(): double

Class Circle
#radius: double

Dependency? (linea punteada) Location
-x: double
-y: double*/

class Shapes {
    static void Main() {

    }

    public abstract class Shape {
        protected double area;
        protected double perimeter;
        protected Location c = new();
        public abstract double Area();
        public abstract double Perimeter();
        }
    
    public class Location {
            private double x, y;
    }

    public class Rectangle : Shape {
        protected double side1;
        protected double side2;
        public override double Area() {
            return side1*side2;
        }
        public override double Perimeter() {
            return (side1*2)+(side2*2);
        }
    }

    public class Circle : Shape {
        protected double radius;
        public override double Area() {
            return 3.14*(radius*radius);
        }
        public override double Perimeter() {
            return 2*3.14*radius;
        }
    }
}