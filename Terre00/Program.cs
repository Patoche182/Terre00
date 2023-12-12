class Terre00
{
    static void Main()
    {
        string lettreAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char lettre in lettreAlphabet)
        {
            Console.Write(lettre.ToString().ToLower());
        }
        Console.WriteLine();
    }
}

//class Terre00
//{
//    static void Main()
//    {
//        for (char lettre = 'A'; lettre <= 'Z'; lettre++)

//        {
//            Console.Write(lettre.ToString().ToLower() + " ");
//        }
//        Console.WriteLine();
//    }
//}