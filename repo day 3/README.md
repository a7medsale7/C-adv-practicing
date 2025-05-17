🔹 Easy – ColorCollection
Task:
Create a class ColorCollection that contains a list of colors (List<string>).
Make the class implement IEnumerable<string> without using yield.

Expected Output:

Color: Red
Color: Green
Color: Blue
🔸 Medium – NumberRange
Task:
Create a class NumberRange that takes two integers (start, end).
Implement IEnumerable<int> and return numbers from start to end using a manual list and its enumerator (no yield).

Expected Output (start = 3, end = 6):

Number: 3
Number: 4
Number: 5
Number: 6
🔺 Hard – CustomEnumerator
Task:
Create a class LetterCollection that implements IEnumerable<char>.
Implement a custom enumerator class (e.g. LetterEnumerator) that implements IEnumerator<char>.
Use it to iterate over characters in the array ['A', 'B', 'C'].

Expected Output:

Letter: A
Letter: B
Letter: C

🟢 Beginner – Problem 1: Music Playlist
✅ Concepts: IEnumerable, properties
Problem:
Create a Song class with Title and Artist as properties.
Create a Playlist class that contains a private list of songs.
Make Playlist implement IEnumerable so you can iterate over the songs using a foreach loop.

Expected Output:

Now Playing: Shape of You by Ed Sheeran  
Now Playing: Blinding Lights by The Weeknd  
Now Playing: Levitating by Dua Lipa  
🟡 Intermediate – Problem 2: Product Inventory Sorter
✅ Concepts: IComparable, properties
Problem:
Create a Product class with Name, Price, and Stock.
Implement IComparable to sort products by Price (lowest to highest).
Add the products to a list, sort it, and print the results.

Expected Output:

Product: Pen - $1.50  
Product: Notebook - $3.20  
Product: Backpack - $25.00  
🟠 Advanced – Problem 3: Department Employee Directory
✅ Concepts: Abstract class, polymorphism, interfaces, properties
Problem:
Create an abstract class Employee with Name and BaseSalary and an abstract method GetMonthlySalary().
Create classes FullTimeEmployee, PartTimeEmployee, and Freelancer, each overriding GetMonthlySalary() logic.
All classes implement an IReportable interface with GenerateReport() method.
Create a list of mixed employees and call GenerateReport() for each.

Expected Output:

John (Full-Time) earns: $3000  
Sarah (Part-Time) earns: $1200  
Ali (Freelancer) earns: $1800  
🔴 Expert – Problem 4: Movie Collection Organizer
✅ Concepts: IEnumerable, polymorphism, abstract, interface, IComparable
Problem:
Create an abstract class MediaItem with properties like Title, Year and method GetInfo().
Create subclasses Movie, TVShow, and Documentary with extra properties.
Implement IComparable to sort by Year (descending).
Create a MediaLibrary class implementing IEnumerable to hold a collection of MediaItem.
Iterate over sorted library and print info.

Expected Output:

Movie: Oppenheimer (2023)  
Documentary: The Social Dilemma (2020)  
TV Show: Breaking Bad (2008)
