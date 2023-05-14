using System;

//--------------------------------------------------------------------------------

public class Program {

    // Klammern bilden einen "Scope"
    public static void Main(string[] args) {

        int[] numbers = new int[11];
        
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = numbers.Length - i - 1;
            Console.WriteLine("Index " + i + ": " + numbers[i]);
        }

        Console.WriteLine("--------------------------------------");

        for (int i = 0; i < numbers.Length/2; i++) {

            int x = numbers[i];
            int y = numbers[numbers.Length - i - 1];

            numbers[i] = y;
            numbers[numbers.Length - i - 1] = x;
        }

        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine("Index " + i + ": " + numbers[i]);
        }





        //int x = 4;
        //int y = 10;
        //
        //Console.WriteLine("BEFORE: -- X: " + x + " | Y: " + y);
        //int backupz = x;
        //x = y;
        //y = backupz;
        //
        //Console.WriteLine("AFTER: -- X: " + x + " | Y: " + y);
    }

    //----------------------------------------------------------------------------

    public static void ArrayTesting() {
        string[] names = new string[6];

        names[0] = "Shy";
        names[1] = "Philipp";
        names[2] = "Mr.B";
        names[3] = "Meerschwein";
        names[4] = "FINN";
        names[5] = "Slang";


        //for-Schleife bei Arrays besser
        for (int i = 0; i < names.Length; i++) {

            Console.WriteLine("Name: " + names[i]);

        }

        //Statt 6 auch names.Length
        int s = 0;
        while (s < 6) {

            Console.WriteLine("Name: " + names[s]);

            s++;
        }
    }

    //--------------------------------------------------------------------------------

    public static void Test() {
        //Printing
        PrintHelloWorld();
        Print("Shy");
        Print("Philipp");

        PrintSum(3, 5);

        int mySum = SumValues(4, 6);

        TestIfElse(2, 4);
        TestIfElse(4, 3);
        TestIfElse(2, 2);

        int a = 8;
        Console.WriteLine(a);

        a = a / 2; // beides gleiche Schreibweise
        a /= 2;
        Console.WriteLine(a);

        a++; // increase by one
        a--; // decrease by one

        a = a / 3;  // devides a by three and sets a to the result
        a /= 3;     // devides a by three and sets a to the result (both the same)

        // For-Loop
        for (int i = 0; i < 13; i += 3) {

            string s = "Index: " + i;
            Console.WriteLine(s);
        }

        int delta = 100;
        // While-Loop
        while (delta >= 50) {

            Console.WriteLine(delta);
            delta = delta - 10;
        }

        Console.WriteLine(ReturnRest(1, 12));
        Console.WriteLine(ReturnRest(1, 1));
        Console.WriteLine(ReturnRest(7, 7));
        Console.WriteLine(ReturnRest(1, 3));
        Console.WriteLine(ReturnRest(-5, 2));
        Console.WriteLine(ReturnRest(8, 2));

        string[] names = new string[2];
        names[0] = "Shy";
        names[1] = "Philipp";

        // For-Loop
        for (int i = 0; i < names.Length; i++) {

            string currentName = names[i];
            Console.WriteLine(currentName);
        }

        // Casting -> Wandelt werte in andere Typen um
        double myDouble = 4.3;
        int myInt = (int)myDouble;

        // Class testing with "Health" example
        Health myHealth = new Health("Shy", 100.0f);
        Health enemyHealth = new Health("Philipp", 100.0f);

        myHealth.Print();
        myHealth.ApplyDamage(20f);
        myHealth.Print();

        enemyHealth.ApplyDamage(20000f);
        enemyHealth.Print();
    }

    //--------------------------------------------------------------------------------

    //// Round braces -> "Übergabebereich"
    public static void PrintHelloWorld() {
        Console.WriteLine("Hello World!");
    }

    //--------------------------------------------------------------------------------

    public static void VariableTesting() {

        // Typ, Name-der-Variable, Zuweisung
        int numA = 2;
        
        byte by = 255; // from 0 - 255
        float numB = 1.33f; // suffix f
        double numC = 1.33d; // suffix d
        
        char character = 'S';
        string name = "Shy";
           
        bool isTrue = ((8 / 2) == 4); // == 'ist gleich'
        bool isAlsoTrue = ((6 / 3) != 4); // != 'ist ungleich'
        Console.WriteLine(isTrue);
        Console.WriteLine(!isTrue);
        Console.WriteLine(isAlsoTrue);
        Console.WriteLine(!isAlsoTrue);
        
        float a = 1.3f;
        float b = 1.7f;
        
        float sum = a + b;

        Console.WriteLine(sum);
    }

    //--------------------------------------------------------------------------------

    public static void Print(string name) {
        Console.WriteLine(name);
    }

    //--------------------------------------------------------------------------------

    public static void PrintSum(int a, int b) {
        Console.WriteLine(a + b);
    }

    //--------------------------------------------------------------------------------

    // Aufbau einer Methode: Zugriffsschutz, statisch, Rückgabetyp, Methodenname, Übergabebereich
    public static int SumValues(int a, int b) {
        return a + b;
    }

    //--------------------------------------------------------------------------------

    public static void TestIfElse(int a, int b) {

        bool isAGreater = a > b;

        if (isAGreater) {
            Console.WriteLine("a is greater");
        }
        else if (a == b) {
            Console.WriteLine("a is b");
        }
        else {
            Console.WriteLine("b is greater");
        }
    }

    //--------------------------------------------------------------------------------

    public static int ReturnRest(int a, int b) {

        int maximum = 0;
        
        while(maximum <= a - b) {
            maximum += b;
        }
        return (a - maximum);
    }

    //--------------------------------------------------------------------------------


}