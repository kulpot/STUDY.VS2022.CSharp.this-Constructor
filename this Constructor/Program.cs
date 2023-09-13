using System;

//ref link:https://www.youtube.com/watch?v=dWd7O7fffcs&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=56
//

class Cow
{
    public string Name { get; set; }
    public Cow(string name)
    {
        Name = name;
    }
}

class Mainclass
{
    static void Main()
    {
        Cow cow = new Cow("Betsy");
        Console.WriteLine(cow.Name);
    }
}