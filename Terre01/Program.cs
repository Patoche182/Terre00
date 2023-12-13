class Terre01
{
    static void Main()
    {
        for (char lettre = 'A'; lettre <= 'Z'; lettre++)

        {
            Console.Write(lettre.ToString().ToLower() + " " + "- ");
        }
        Console.WriteLine();
    }
}