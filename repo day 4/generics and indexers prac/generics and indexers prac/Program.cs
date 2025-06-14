using generics_and_indexers_prac;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        #region prob1-display
        List<Product> products = new List<Product>
        {
            new Product { name = "Laptop", price = 1000 },
            new Product { name = "Smartphone", price = 500 },
            new Product { name = "Tablet", price = 300 }
        };
        foreach (Product product in products)
        {
            Console.WriteLine($"Product Name: {product.name}, Price: {product.price}");
        }
        #endregion
        Console.WriteLine("==================================================");
        #region prob2-IndexDisplay
        StorageBox<string> box = new StorageBox<string>();
        box[0] = "Book";
        box[2] = "Phone";
        box[1] = "Laptop";
        box[10] = "Laptop";


        box.displayItems();
        #endregion
        Console.WriteLine("==================================================");
        #region sortion
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Department = "HR", Salary = 60000 },
            new Employee { Name = "Bob", Department = "IT", Salary = 80000 },
            new Employee { Name = "Charlie", Department = "Finance", Salary = 70000 }
        };
        employees.Sort();
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
        #endregion
        Console.WriteLine("==================================================");
        #region Ienum-prod4
        List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book { title = "C# Programming", author = "John Doe", year = 2020 },
            new Book { title = "Learning Python", author = "Jane Smith", year = 2019 },
            new Book { title = "Java Fundamentals", author = "Alice Johnson", year = 2021 }
        };
        foreach (LibraryItem libraryItem in libraryItems)
        {
            libraryItem.GetDetails();
        }
        #endregion 
        Console.WriteLine("==================================================");
        #region prob5-courses
        Console.WriteLine("==================================================");

        Course course = new Course { Name = "C# Basics" };
        course.AddStudent("Ahmed");
        course.AddStudent("Salma");
        course.AddStudent("Youssef");

        // Access students using indexer
        Console.WriteLine($"Student at index 0: {course[0]}");
        Console.WriteLine($"Student at index 1: {course[1]}");

        // Update student using indexer
        course[1] = "Sara";

        course.PrintStudents(); 
        #endregion
    }
}