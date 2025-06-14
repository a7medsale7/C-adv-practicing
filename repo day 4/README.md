🟢 Beginner – Problem 1: Product List Formatter
✅ Concepts: collections, string

Problem:
اكتب كود فيه كلاس Product فيه Name و Price. أنشئ List من المنتجات، واطبعهم بصيغة:

Product: Apple | Price: $2.50
Product: Banana | Price: $1.20
Product: Orange | Price: $3.00
==========================================================
🟡 Intermediate – Problem 2: Generic Storage Box
✅ Concepts: generics, indexers

Problem:
اعمل كلاس generic اسمه StorageBox<T> فيه indexer يخليك تضيف عناصر بأي index، ويطبع كل العناصر بطريقة مرتبة.

Expected Output:

Item at index 0: Book
Item at index 1: Laptop
Item at index 2: Phone
==================================================
🟠 Advanced – Problem 3: Sorted Employee Registry
✅ Concepts: interfaces, IComparable, properties, collections

Problem:
اعمل كلاس Employee فيه Name, Salary, Department. فعّل IComparable عشان ترتب الموظفين حسب Salary تصاعدي، ولو نفس المرتب يبقى حسب الاسم.

Expected Output:

John - $2000
Mona - $2000
Sara - $3000

============================================
🔴 Expert – Problem 4: Multi-Type Library System
✅ Concepts: polymorphism, abstract, IEnumerable, generics, collections

Problem:
اعمل abstract class LibraryItem فيه Title و Year و abstract method GetDetails(). بعدها:

Book فيه Author

Magazine فيه IssueNumber

DVD فيه Duration

استخدم List<LibraryItem> وفعّل IEnumerable في كلاس Library. لما تعمل foreach على المكتبة، اطبع التفاصيل.

Expected Output:

Book: Clean Code by Robert Martin (2008)
Magazine: National Geographic - Issue 120 (2021)
DVD: Inception - 148 mins (2010)
=====================================================================
🔴🔴 Bonus Challenge – Problem 5: Course Tracker
✅ Concepts: indexers, collections, generics, string, properties

Problem:
اعمل كلاس Course فيه Name وList<string> Students. فعّل indexer يخليك توصل لطالب معين في كورس. اعمل كمان method AddStudent و RemoveStudent.

Expected Output:

Course: C# Basics
Student at index 0: Ahmed
Student at index 1: Salma
