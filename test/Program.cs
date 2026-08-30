namespace test;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Anh", 19, 8.5);
        Student student2 = new Student("Nam", 20, 4.5);

        Console.WriteLine("=== STUDENT 1 ===");
        student1.DisplayInfo();
        Console.WriteLine($"Passed: {student1.IsPassed()}");

        Console.WriteLine();

        Console.WriteLine("=== STUDENT 2 ===");
        student2.DisplayInfo();
        Console.WriteLine($"Passed: {student2.IsPassed()}");
    }
}