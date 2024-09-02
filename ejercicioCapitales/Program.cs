
class Paises{
    static void Main() {
        /*Provincia asd = new();
        Capital dsa = new("rosario");
        
        Console.WriteLine(asd);
        asd.Capital = dsa;
        Console.WriteLine(asd.Capital.getName());*/

        UnaClaseLoca asd = new();
        Console.WriteLine("1");
        Console.WriteLine(asd.Name);
        Console.WriteLine("2");
        asd.Name = "asd";
        Console.WriteLine(asd.Name);

        //si se invoca asd.Name así nomás, llama al get. pero si se le asigna un valor, toma el set. 
    }
}

public class UnaClaseLoca {
    private string? name;
    public string Name {
        get {
            if (name is not null) {
                 return name;
                 } else {
                 return "no name yet";
                 }
            }
        set {name = value;}}
}

public class Capital { 
    private string name;
    
    public string getName(){
        return name;
    }

    public Capital (string n) {
        name = n;
    }
}

public class Provincia {
    private Capital? capital;

    public Capital Capital {
        get { return capital!;}
        set { capital = value; }
    }
        
}