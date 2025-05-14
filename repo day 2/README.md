🟢 Beginner – Problem 1: Student GPA Sorting
✅ Concepts: IComparable, properties
Problem:
Create a class Student with:

Name (string), GPA (float) — as properties

Implement IComparable<Student> to sort students descending by GPA

Create a list of 3 students, sort them, and print their names with GPAs.

Expected Output:

yaml
Copy
Edit
Ahmed - GPA: 3.9
Laila - GPA: 3.6
Omar - GPA: 3.1

====================================================================
🟡 Intermediate – Problem 2: Product Catalog (Interface & IComparable)
✅ Concepts: Interface, IComparable, polymorphism
Problem:
Create an interface IProduct with:

Name, Price, Stock — properties

Display() method

Create two classes: Book and Laptop that implement IProduct

Also implement IComparable<IProduct> to sort by Price ascending.

Create a list of products, sort them, and display info.

Expected Output:

bash
Copy
Edit
Book: "C# Mastery" - $25.00 - Stock: 10
Laptop: "Dell XPS" - $999.99 - Stock: 5

====================================================================

🔵 Advanced – Problem 3: Employee Payroll System
✅ Concepts: abstract class, interface, polymorphism, IComparable
Problem:
Create:

Abstract class Employee with: Name, BaseSalary, abstract CalculateSalary()

Interface IReportable with method GenerateReport()

Create subclasses:

FullTimeEmployee → fixed bonus

PartTimeEmployee → hourly rate \* hours

Freelancer → per-project payment

Implement IComparable<Employee> to sort by total salary.

Expected Output:

pgsql
Copy
Edit
Omar (Freelancer): $3000.00
Laila (Full-Time): $2800.00
Ahmed (Part-Time): $1800.00
====================================================================
🟣 Expert+ – Problem 5: Smart Home Billing System
✅ Concepts Required:
Interfaces

Abstract Classes

Polymorphism

Properties

IComparable

Casting between interfaces and base types

Sorting based on computed values

🧠 Problem Description:
You are designing a Smart Home Billing System. Every smart device in the home (lights, heater, AC, etc.) consumes energy differently. The billing system should calculate the monthly energy cost for each device and sort them based on total cost (high to low).

🏗️ Structure to Create:

1. Interface: IBillable
   Method: decimal CalculateMonthlyBill()

2. Abstract class: SmartDevice
   Properties:

DeviceName (string)

PowerUsageWatts (float)

UsageHoursPerDay (int)

Abstract method: void DisplayInfo()

3. Subclasses:
   SmartLight
   ➤ Has extra property: IsDimmable (bool)
   ➤ If dimmable, it uses 90% of power

SmartHeater
➤ Has extra property: TemperatureSetting (int)
➤ Cost increases with higher temperatures

SmartAC
➤ Has property: RoomSize (int square meters)
➤ Bigger rooms mean more energy usage

💡 Billing Logic:
All bills are calculated monthly (assume 30 days):

java
Copy
Edit
Monthly kWh = (PowerUsageWatts _ UsageHoursPerDay _ 30) / 1000
Total Bill = Monthly kWh \* RatePerKWh
RatePerKWh = $0.12

SmartLight:

If IsDimmable is true → PowerUsageWatts \*= 0.9

SmartHeater:

Add extra $5 if TemperatureSetting > 25

SmartAC:

If RoomSize > 20, multiply monthly kWh by 1.2

🎯 Your Task:
Create the interface, abstract class, and subclasses.

Each subclass should implement IBillable and IComparable.

Create a list of mixed devices.

Sort by CalculateMonthlyBill() in descending order.

Print each device’s DeviceName and the total bill using DisplayInfo().

🧾 Expected Output:
bash
Copy
Edit
SmartHeater: Living Room Heater - Monthly Bill: $32.40
SmartAC: Bedroom AC - Monthly Bill: $25.92
SmartLight: Kitchen Light - Monthly Bill: $3.24
🧠 Hints:
You’ll need to cast SmartDevice to IBillable in sorting.

Use virtual if you want to define shared logic in base class and override in subclasses.
