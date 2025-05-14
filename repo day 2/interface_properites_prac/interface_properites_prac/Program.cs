namespace interface_properites_prac;
internal class Program
{
    private static void Main(string[] args)
    {

        #region GPA_Prob1
        //Student[] students = new Student[3];
        //students[0] = new Student { Name = "John", GPA = 3.5f };
        //students[1] = new Student { Name = "Jane", GPA = 3.8f };
        //students[2] = new Student { Name = "Bob", GPA = 3.2f };
        //Array.Sort(students);
        //for (int i = 0; i < students.Length; i++)
        //{
        //    Console.WriteLine($"Name: {students[i].Name}, GPA: {students[i].GPA}");
        //} 
        #endregion

        #region Book_laptop_prob2
        //Book[] books = new Book[4];
        //books[0] = new Book { Name = "Book A", price = 100, stock = 5 };
        //books[1] = new Book { Name = "Book B", price = 200, stock = 3 };
        //books[2] = new Book { Name = "Book C", price = 150, stock = 10 };
        //books[3] = new Book { Name = "Book D", price = 50, stock = 8 };
        //Array.Sort(books);
        //for (int i = 0; i < books.Length; i++)
        //{
        //    books[i].display();
        //}

        //Laptop[] laptops = new Laptop[4];
        //laptops[0] = new Laptop { Name = "Laptop A", price = 1000, stock = 5 };
        //laptops[1] = new Laptop { Name = "Laptop B", price = 2000, stock = 3 };
        //laptops[2] = new Laptop { Name = "Laptop C", price = 1500, stock = 10 };
        //laptops[3] = new Laptop { Name = "Laptop D", price = 500, stock = 8 };
        //Array.Sort(laptops);
        //for (int i = 0; i < laptops.Length; i++)
        //{
        //    laptops[i].display();
        //} 
        #endregion

        #region Working_prob3
        PartTimeEmployee[] employees = new PartTimeEmployee[3];
        employees[0] = new PartTimeEmployee { name = "John", baseSalary = 1000, hoursWorked = 20, type = "parttime" };
        employees[1] = new PartTimeEmployee { name = "Jane", baseSalary = 1200, hoursWorked = 15, type = "parttime" };
        employees[2] = new PartTimeEmployee { name = "Bob", baseSalary = 800, hoursWorked = 25, type = "parttime" };
        Array.Sort(employees);
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].GenerateReport();
        }
        Freelancer[] freelancers = new Freelancer[3];
        freelancers[0] = new Freelancer { name = "Alice", baseSalary = 1500, hoursWorked = 10, type = "freelancing" };
        freelancers[1] = new Freelancer { name = "Charlie", baseSalary = 1800, hoursWorked = 12, type = "freelancing" };
        freelancers[2] = new Freelancer { name = "David", baseSalary = 2000, hoursWorked = 8, type = "freelancing" };
        Array.Sort(freelancers);
        for (int i = 0; i < freelancers.Length; i++)
        {
            freelancers[i].GenerateReport();
        }

        FullTimeEmployee[] fullTimeEmployees = new FullTimeEmployee[3];
        fullTimeEmployees[0] = new FullTimeEmployee { name = "Eve", baseSalary = 3000, bonus = 500, type = "fulltime" };
        fullTimeEmployees[1] = new FullTimeEmployee { name = "Frank", baseSalary = 3500, bonus = 700, type = "fulltime" };
        fullTimeEmployees[2] = new FullTimeEmployee { name = "Grace", baseSalary = 4000, bonus = 600, type = "fulltime" };

        Array.Sort(fullTimeEmployees);
        for (int i = 0; i < fullTimeEmployees.Length; i++)
        {
            fullTimeEmployees[i].GenerateReport();
        }
        #endregion

        #region smart_prob4
        SmartLight[] smartLights = new SmartLight[3];
        smartLights[0] = new SmartLight { DeviceName = "Living Room Light", PowerUsageWatts = 10, UsageHoursPerDay = 5 };
        smartLights[1] = new SmartLight { DeviceName = "Bedroom Light", PowerUsageWatts = 15, UsageHoursPerDay = 3 };
        smartLights[2] = new SmartLight { DeviceName = "Kitchen Light", PowerUsageWatts = 20, UsageHoursPerDay = 4 };
        Array.Sort(smartLights);
        for (int i = 0; i < smartLights.Length; i++)
        {
            smartLights[i].DisplayInfo();
        }
        SmartAC[] smartACs = new SmartAC[3];
        smartACs[0] = new SmartAC { DeviceName = "Living Room AC", PowerUsageWatts = 2000, UsageHoursPerDay = 8, RoomSize = 25 };
        smartACs[1] = new SmartAC { DeviceName = "Bedroom AC", PowerUsageWatts = 1500, UsageHoursPerDay = 6, RoomSize = 15 };
        smartACs[2] = new SmartAC { DeviceName = "Kitchen AC", PowerUsageWatts = 2500, UsageHoursPerDay = 10, RoomSize = 30 };
        Array.Sort(smartACs);
        for (int i = 0; i < smartACs.Length; i++)
        {
            smartACs[i].DisplayInfo();
        }

        #endregion












    }
}