using System;
class student
{
    public string name { get; set; } public int age { get; set; } public int id { get; set; } public double gpa { get; set; }

    public student(string name, int age, int id,double gpa)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.gpa = gpa;
    }
    public bool ispassed()
    {
        if (gpa > 2.0)
            return true;
        return false;
    }
    public string rank()
    {
        if(gpa >= 3.5)
            return "A";
        else if (gpa >= 3.0)
            return "B";
        else if (gpa >= 2.5)
            return "C";
        else if (gpa >= 2.0)
            return "D";
        else
            return "F";
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, ID: {id}, GPA: {gpa}");
        if(ispassed())
            Console.WriteLine("The student has passed.");
        else
            Console.WriteLine("The student has failed.");
        Console.WriteLine($"Rank: {rank()}");
    }
   
}
