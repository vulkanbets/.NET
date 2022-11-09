/* 
*  Implement a vector (mutable array with automatic resizing):
*  
*/ 


internal class Program
{
    private static void Main(string[] args)
    {
        var myString = new Vector<char>();

        myString.push('J');
        myString.push('a');
        myString.push('b');
        myString.push('b');
        myString.push('e');
        myString.push('r');
        myString.push('W');
        myString.push('o');
        myString.push('c');
        myString.push('k');
        myString.push('e');
        myString.push('y');

        System.Console.WriteLine("\n\n");
        foreach(char ch in myString.vector)
        {
            System.Console.Write(ch);
        }
        System.Console.WriteLine("\n\n");


    }
}
