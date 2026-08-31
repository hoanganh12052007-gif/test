using System;
class student
{
    public string name { get; set; } public int age { get; set; } public int id { get; set; }
    public student(string name, int age, int id)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, ID: {id}");
    }
}
