// See https://aka.ms/new-console-template for more information
using System;


class Person
{
    public virtual void Greet()
    {
        Console.WriteLine("Hi! I am a person.");
    }
}

class Employee : Person
{
    public override void Greet()
    {
        Console.WriteLine("Hello! I am an employee.");
    }
}
class program
{
    static void Main()
    {
        Employee e1 = new Employee();
        e1.Greet();
    } 
}
