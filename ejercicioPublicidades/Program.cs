using System.Collections;
using System.Dynamic;
using System.Runtime.Intrinsics.Arm;

public class EjercicioPublicidades {
    static void Main() {

        //inicializo 3 medios
        IMedio Viva = new Revista();       
        IMedio Clarin = new Diario();
        IMedio Infobae = new Folleto();
        
        //inicializo una publicidad con un medio (de clase diario)
        Publicidad publi01 = new(8.00, 750, Clarin);
        //esperado: costo 800
        Console.WriteLine("El costo para publicar esta publicidad en este diario es de "+publi01.CostoPublicacion());
        
        //cambio el medio  de la publicidad (con uno de clase revista)
        publi01.SetMedio(Viva);
        //esperado: costo 450
        Console.WriteLine("El costo para publicar esta publicidad en esta revista es de "+publi01.CostoPublicacion());
        
        //cambio a otro (de clase folleto)
        publi01.SetMedio(Infobae);
        //esperado: costo 550
        Console.WriteLine("El costo para publicar esta publicidad en este folleto es de "+publi01.CostoPublicacion());
        

    }
    public class Publicidad {
        private double centimetros;
        private int cantCaracteres;
        
        private IMedio medio;

        public Publicidad(double cm, int cc, IMedio m)
        {
            centimetros = cm;
            cantCaracteres = cc;
            medio = m;
            SetConditionOfMedio();
        }

        public void SetMedio(IMedio m) {
            medio = m;
            SetConditionOfMedio();
        }
        /*depentiendo el tipo de medio este método llama al mismo método pero con diferentes
        parámetros (overload) */
        public void SetConditionOfMedio(){
            if (GetMedio() is Revista){
                medio.SetCondition(GetCM());
            }
            if (GetMedio() is Diario) {
                medio.SetCondition(GetCantCar());
            }
            if (medio is Folleto) {
                medio.SetCondition();
            }
        }      

        public double GetCM(){
            return centimetros;
        }
        public int GetCantCar(){
            return cantCaracteres;
        }
        public IMedio GetMedio(){
            return medio;
        }

        public double CostoPublicacion() {
            return 50+medio.CostoTotal();
        }
    }
    public interface IMedio {

        /* por el overload, la interfase selecciona uno de los tres métodos*/
        public void SetCondition(){
        }
        public void SetCondition(double cm){
        }
        public void SetCondition(int cantCar){
        }
        public double CostoTotal(){
            return 0.00;
        }
    }
    
    public class Revista : IMedio {
        private double centimetros;
        /*cada clase que usa la interfase overridea solamente uno de los 3 métodos
        que fue preseleccionado en el método SetConditionOfMedio*/
        public void SetCondition(double cm){
            centimetros = cm;
        }
        public double CostoTotal(){
            return 50*centimetros;
        }
    }
    public class Diario : IMedio {
        private int cantCaracteres;
        public void SetCondition(int cc){
            cantCaracteres = cc;
        }
        public double CostoTotal(){
            return cantCaracteres;
        }
    }

    public class Folleto : IMedio {
        public double CostoTotal(){
            return 500;
        }
    }



}