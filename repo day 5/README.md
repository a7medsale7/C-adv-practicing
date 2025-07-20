✅ Problem 1 – Easy: Basic Delegate for Greeting
Problem:
Create a delegate called GreetDelegate that takes a string name and prints a greeting like "Hello, [Name]!".
Use the delegate to greet two names.

Expected Output:

Hello, Ahmed!
Hello, Sara!
================================================================================
✅ Problem 2 – Medium: Delegate for Filtering Numbers
Problem:
Create a delegate called FilterDelegate that takes an integer and returns true if it passes a certain condition.
Write a method FilterList that takes a list of integers and a delegate, and returns only numbers that match the condition.

Use the delegate to:

Filter even numbers

Filter numbers > 50

Expected Output:

Even numbers: 2 4 8
Greater than 50: 99 76
================================================================================

🟢 Part 3: Built-in Delegates – 3 Graded Problems
✅ Problem 14– Easy: Using Action<string> to Print Messages
Problem:
Create an Action<string> called PrintMessage that prints any message passed to it.
Invoke it with three different messages.

Expected Output:

Welcome to the system.
Processing request...
Done!
====================================================================================
✅ Problem
5 – Medium: Using Predicate<int> to Filter List
Problem:
You have a list of integers: {5, 8, 12, 25, 30, 3, 7}
Use Predicate<int> to filter and return:

Even numbers

Numbers greater than 10

Write a method FilterList(List<int> list, Predicate<int> condition) that uses the predicate.

Expected Output:

Even numbers: 8 12 30
Greater than 10: 12 25 30
=================================================================================
✅ Problem 6 – Hard: Using Func<string, int> and Func<int, bool> in Combination
Problem:
Create a list of string numbers: { \"10\", \"20\", \"abc\", \"30\", \"xyz\" }

Use Func<string, int> to safely parse string to int (if invalid, return 0)

Then, use Func<int, bool> to check if the number is greater than 15

Print all valid numbers > 15

Expected Output:

# Parsed numbers > 15: 20 30

🟢 Part 2 – Mixed Concepts (All-in-One Problems)
✅ Problem 7 – Easy: Product Inventory System
Problem Summary:
Create an abstract class Product with properties:

Name, Price

And a method GetInfo().
Create two child classes:

Book: has Author

Phone: has Brand

Use:

IComparable to sort by price.

IEnumerable to allow looping over inventory.

Indexer to access product by index.

Generic Inventory<T> class to hold products.

Func<Product, bool> to filter products over 1000 EGP.

Expected Output:

All Products:

- Book: Clean Code by Robert Martin - 800 EGP
- Phone: iPhone by Apple - 32000 EGP

Filtered (>1000):

- Phone: iPhone by Apple - 32000 EGP

Sorted:

- Book: Clean Code - 800 EGP
- # Phone: iPhone - 32000 EGP
  ✅ Problem 8 – Medium: Student Course Registration System
  Problem Summary:
  Design an abstract class Person with:

Name, ID, and method GetDetails()
Create:

Student class (has Level)

Instructor class (has Department)

Use:

IComparable<Student> to sort by level.

IComparer to sort by name.

Course<T> class holds a list of students (IEnumerable<T>, indexer).

Delegate Predicate<Student> to find students in Level 4.

Use property Grade with validation (0–100).

Expected Output:

Students in course:

- Ali (ID: S1) - Level 3
- Mona (ID: S2) - Level 4

Filtered Level 4:

- Mona (ID: S2)

Sorted by Level:

- Ali
- Mona

Sorted by Name:

- Ali
- # Mona
  ✅ Problem 9 – Hard: Task Management + Reporting System
  Problem Summary:
  Create an abstract class TaskItem with:

Title, Priority, IsCompleted

abstract method Execute()

Subclasses:

BugFix: has Developer

Feature: has Deadline

Use:

IEnumerable<TaskItem> in TaskList<T>

Indexer to access tasks

Func<TaskItem, bool> to filter incomplete tasks

Action<TaskItem> to log task titles

IComparable<TaskItem> to sort by priority

IComparer<TaskItem> to sort by title

Use polymorphism to call Execute() on all tasks

Expected Output:

All Tasks:

- [BugFix] Fix login - Priority 2 - Completed: False
- [Feature] Add dark mode - Priority 1 - Completed: True

Incomplete Tasks:

- [BugFix] Fix login

Sorted by Priority:

- Add dark mode
- Fix login

Log:

- Executing: Fix login
- Executing: Add dark mode
