using System;

//ref link:https://www.youtube.com/watch?v=dWd7O7fffcs&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=56
// this() -- for overload of constructors

class Cow
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    //public Cow(string name, int age = 0)
    public Cow(string name) 
    {
        Console.WriteLine("Cow(name)");
        if (name.Length > 10)
            throw new Exception();
        Name = name;
        //Age = age;

    }
    public Cow(string name, int age) : this(name) // ------------
    {
        Console.WriteLine("Cow(name, age)");
        //if(name.Length > 10)
        //    throw new Exception();
        //Name = name;
        Age = age;
    }
}

class Mainclass
{
    static void Main()
    {
        Cow cow = new Cow("Betsy", 5);
        Console.WriteLine(cow.Name);
        Console.WriteLine(cow.Age);
    }
}