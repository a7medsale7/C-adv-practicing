using Delegate_prac;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
class Program
{
    #region Prob 1 
    delegate string GreetDelegate(string name);

    void displayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static string ReturnGreeting(string name)
    {
        return $"Hello, {name}!";
    }
    #endregion

    #region Prob 2 
    delegate bool FilterDelegate(int number);
    static void displayItems(List<int> items, FilterDelegate condition)
    {
        foreach (var item in items)
        {
            if (condition(item))
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
    }
    #endregion

    #region Prob 3 
    public delegate string TextProcessor(string text);
    public static string ToUpperCase(string text)
    {
        return text.ToUpper();
    }
    static string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }
    public static string AddBrackets(string text)
    {
        return $"[{text}]";
    }


    static void displayProcessedText(string text, TextProcessor processor)
    {
        foreach (TextProcessor method in processor.GetInvocationList())
        {
            text = method(text);
        }

        Console.WriteLine(text);
    }
    #endregion

    #region Prob 5 
    public static List<int> FilterList(List<int> list, Predicate<int> condition)
    {

        List<int> filteredList = new List<int>();
        foreach (var item in list)
        {
            if (condition(item))
            {
                filteredList.Add(item);
            }
        }
        return filteredList;
    }

    static void DisplayItems(string label, List<int> items)
    {
        Console.Write(label);
        foreach (int item in items)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(); 
    }
    #endregion

    #region Prob 6 
    static void ddisplay(List<int> items, Predicate <int> condition)
    {
        foreach (var item in items)
        {
            if (condition(item))
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
    }


    #endregion




    static void Main()
        {


        #region Prob 1
        GreetDelegate greet = new GreetDelegate(ReturnGreeting);

        Program p = new Program();


        p.displayMessage(greet("Ahmed"));
        p.displayMessage(greet("Sara")); 
        #endregion

        #region Prob 2 
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.Write($"items evev :");
        displayItems(numbers, numbers => numbers % 2 == 0);
        Console.WriteLine($"items > 5 :");
        displayItems(numbers, numbers => numbers > 5);
        #endregion

        #region Prob 3 
        string text = "Hello   World";
        TextProcessor processor = ToUpperCase;
        processor += RemoveSpaces;
        processor += AddBrackets;
        displayProcessedText(text, processor);
        #endregion

        #region Prob 4 
        Action<string> PrintMessage = Console.WriteLine;
        PrintMessage("Welcome to the system.");
        PrintMessage("Processing request...");
        PrintMessage("Done!");
        #endregion

        #region Prob 5 
        List<int> Items = new List<int> { 5, 8, 12, 25, 30, 3, 7 };

        List<int> evens = FilterList(Items, Items => Items % 2 == 0);
        DisplayItems("Even numbers: ", evens);

        List<int> greaterThan10 = FilterList(Items, Items => Items > 10);
        DisplayItems("Greater than 10: ", greaterThan10); 
        #endregion

        #region Prob 6 
        List<string> stringNumbers = new List<string> { "10", "20", "abc", "30", "xyz" };

        Func<string, int> safeParse = stringNumbers =>
        {
            bool success = int.TryParse(stringNumbers, out int result);
            return success ? result : 0;
        };

        Func<int, bool> isGreaterThan15;

        ddisplay(stringNumbers.Select(safeParse).ToList(), number => number > 15);



        #endregion

        #region Prob 7 
        //var inventory = new Inventory<Product>();

        //inventory.Add(new Book { Name = "C# Programming", Price = 500, Author = "John Doe" });
        //inventory.Add(new Phone { Name = "iPhone 14", Price = 15000, Brand = "Apple" });

        //Console.WriteLine("All Products:");

        //foreach (var n in inventory)
        //{
        //    Console.WriteLine($"-{n.GetInfo()}");
        //}

        //Console.WriteLine("\nFiltered (>1000):");
        //var filtered = inventory.Filter(p => p.Price > 1000);
        //foreach (var m in filtered)
        //{
        //    Console.WriteLine("- " + m.GetInfo());
        //}
        //Console.WriteLine("\nSorted:");
        //var sorted = inventory.GetSorted();
        //foreach (var n in sorted)
        //{
        //    Console.WriteLine("- " + n.Name + " - " + n.Price + " EGP");
        //}
        #endregion

        #region Prob 8
        var course = new Course<Student>();

        var s1 = new Student
        {
            Name = "Ali",
            Id = "S1",
            level = 3,
            grade = 85
        };

        var s2 = new Student
        {
            Name = "Mona",
            Id = "S2",
            level = 4,
            grade = 92
        };

        course.AddStudent(s1);
        course.AddStudent(s2);

        Console.WriteLine("📘 Students in course:");
        foreach (var student in course)
        {
            Console.WriteLine("- " + student.GetDetails());
        }

        Console.WriteLine("\n Filtered (Level 4):");
        var filtered1 = course.Filter(s => s.level == 4);
        foreach (var student in filtered1)
        {
            Console.WriteLine("- " + student.GetDetails());
        }

        Console.WriteLine("\n Sorted by Name:");
        var studentsList = new List<Student>();
        foreach (var s in course)
        {
            studentsList.Add(s);
        }
        studentsList.Sort(course);

        foreach (var s in studentsList)
        {
            Console.WriteLine("- " + s.Name);
        }

        Console.WriteLine("\n Student at index 1:");
        Console.WriteLine(course[1].GetDetails());
        #endregion

        #region Prob 9 
        var taskList = new TaskList<TaskItem>();

        taskList.Add(new BugFix("Fix login", 2, false, "Ahmed"));
        taskList.Add(new Feature("Add dark mode", 1, true, DateTime.Now.AddDays(7)));

        Console.WriteLine("All Tasks:");
        foreach (var task in taskList)
            Console.WriteLine(task);

        Console.WriteLine("\nIncomplete Tasks:");
        var incomplete = taskList.Filter(t => !t.IsCompleted);
        foreach (var task in incomplete)
            Console.WriteLine($"- [{task.GetType().Name}] {task.Title}");

        Console.WriteLine("\nSorted by Priority:");
        foreach (var task in taskList.SortedByPriority())
            Console.WriteLine($"- {task.Title}");

        Console.WriteLine("\nLog:");
        taskList.Log(t => t.execute());
    } 
    #endregion
}