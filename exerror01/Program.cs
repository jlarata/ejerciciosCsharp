class ExceptionsDemo
{
    static void Main()
    {
        try {
            string fileName = "WrongTextFile.txt";
            ReadFile(fileName);
        }
        catch (Exception e) {
            throw new ApplicationException("Smth. bad happened", e);
        }
        
    }

    static void ReadFile(string fileName)
    {
       try {
            TextReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
       }
       catch (FileNotFoundException fnfe) {
            // Exception handler for FileNotFoundException
            // We just inform the user that there is no such file
            Console.WriteLine(fnfe.Message);//<- este lo puse yo para probar
            Console.WriteLine("The file '{0}' is not found.", fileName);
        }
        /*catch (IOException ioe) {
            // Exception handler for other input/output exceptions
            // We just print the stack trace on the console
            Console.WriteLine(ioe.StackTrace);
        }*/
        
    }
}