class Apendice
    {     
        static void Main(string[] args) {

            Genre g1 = new();
            Genre g2 = new();
            Genre g3 = new();

            g1.Name = "Hip Hop";
            g2.Name = "Rock";
            g3.Name = "Country";

            Console.WriteLine ("Genres: {0}, {1}, {2}", g1.Name, g2.Name, g3.Name);
            Console.WriteLine ("clases: {0}, {1}, {2}", g1.ToString(), g2.ToString(), g3.ToString());
        }

    public class Genre
    {
        public string Name { get; set; } = "...";
    }
    }