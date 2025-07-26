✅ STEP 1 – Create Person class (Abstract)
📌 What to do:

Create an abstract class named Person

Add properties: Id, Name, Email

Add abstract method DisplayDetails()

✅ STEP 2 – Create Student class
📌 What to do:

Create a class named Student that inherits from Person

Add property: double GPA

Add property: List<Course> EnrolledCourses

Add method: RegisterCourse(Course course)

Add method: ViewCourses()

Implement the abstract DisplayDetails()

Implement IComparable<Student> → compare by GPA

Implement IEnumerable<Course> → allow foreach on EnrolledCourses

✅ STEP 3 – Create Instructor class
📌 What to do:

Create class Instructor that inherits from Person

Add property: List<string> Skills

Add property: List<Course> TeachingCourses

Add method AssignCourse(Course course)

Add method ViewTeachingCourses()

Implement DisplayDetails()

✅ STEP 4 – Create Course class
📌 What to do:

Create class Course

Add properties: string Code, string Title, int CreditHours

Add property Instructor AssignedInstructor

Add method DisplayInfo()

✅ STEP 5 – Create Interface IUser
📌 What to do:

Create an interface named IUser

Add 2 methods:

void Login(string username, string password)

void Logout()

Implement it in both Student and Instructor

✅ STEP 6 – Create StudentManager class
📌 What to do:

Create class StudentManager

Add List<Student> Students

Add method AddStudent(Student s)

Add method DisplayAllStudents()

Add Indexer: access by int index → this[int i]

Add Indexer: access by string name → this[string name]

Add method SortByGPA() → uses IComparable

Add method SortByName() → use IComparer

✅ STEP 7 – Create InstructorManager class
📌 What to do:

Create class InstructorManager

Add List of Instructors

Add methods:

AddInstructor(Instructor i)

GetInstructorById(int id)

DisplayAllInstructors()

✅ STEP 8 – Create CourseManager class
📌 What to do:

Create class CourseManager

Add List of Courses

Add methods:

AddCourse(Course c)

DisplayCourses()

GetByCode(string code)

✅ STEP 9 – Create Interface ISortable<T>
📌 What to do:

Create interface ISortable<T>

Add method: void Sort(List<T> list)

✅ STEP 10 – Create StudentNameSorter class
📌 What to do:

Create class StudentNameSorter that implements IComparer<Student>

Implement method int Compare(Student x, Student y) → compare by Name

✅ STEP 11 – Create StudentCourseCountSorter class
📌 What to do:

Create class StudentCourseCountSorter that implements IComparer<Student>

Compare students by number of enrolled courses

✅ STEP 12 – Create Delegate Logger
📌 What to do:

Create delegate public delegate void LogHandler(string msg);

Create class Logger with:

Method LogToConsole(string msg)

Method LogWithTimestamp(string msg)

Field LogHandler log

Method LogAction(string msg) that invokes log(msg)

✅ STEP 13 – Create Generic Repository
📌 What to do:

Create class Repository<T> (Generic)

Field: List<T> Items

Methods:

void Add(T item)

List<T> GetAll()

T GetByIndex(int i)

✅ STEP 14 – Create Extension Methods
📌 What to do:

Create static class Extensions

Create method:

string GenerateUsername(this string fullName) → ahmedmohamed_stu

bool IsEmailValid(this string email) → check @ and .com

✅ STEP 15 – Final Integration in Program.cs
📌 What to do:

Create test data for Students, Instructors, and Courses

Simulate:

Student registration

Course enrollment

Instructor assignment

Sorting students by GPA or Name

Logging actions

Displaying results using foreach, indexers, etc.

# tips for understanding the code details

var course = Courses.FirstOrDefault(c => c.Code == code);
هنا بتستخدم LINQ (FirstOrDefault) علشان تدور على أول كورس في قائمة Courses اللي:
c.Code == code
يعني الكورس اللي كوده يساوي الكود اللي المستخدم كتبه.

لو لقى الكورس، هيحطه في المتغير course

# لو ملاقاش، هيرجع null

الكلاس Logger مسؤول عن تسجيل أي حدث بيحصل في النظام (زي إضافة طالب – تسجيل كورس – طباعة بيانات).

بدل ما تعمل Console.WriteLine() في كل مكان، بتخلي Logger هو اللي يتكفل بالموضوع.

وبتستخدم Delegate علشان تقدر تختار أكتر من طريقة لعرض الـ log (مثلاً على الكونسول، أو مع توقيت، أو تكتب في ملف… الخ).

✅ شرح الكود سطرًا بسطرًا:
🔷 public LogHandler log;
ده متغير (field) من نوع delegate اسمه LogHandler

النوع LogHandler لازم يكون معمول كـ delegate كده في مكان تاني:

public delegate void LogHandler(string msg);
يعني أي دالة بترجع void وبتاخد string تقدر تتربط بالمتغير ده.

🔷 public void LogToConsole(string msg)
Console.WriteLine("LOG: " + msg);
دي دالة بسيطة بتطبع الرسالة على الكونسول مع كلمة "LOG:" في البداية.

مثال: LOG: Student added.

🔷 public void LogWithTimestamp(string msg)
Console.WriteLine($"[{DateTime.Now}] {msg}");
دي دالة بتضيف التاريخ والوقت قبل الرسالة.

مثال: [7/20/2025 5:24:18 PM] Student added.

🔷 public void LogAction(string msg)
if (log != null)
log(msg);
دي الدالة الرئيسية اللي هتستخدمها في كل البرنامج لتسجيل الأحداث.

لو فيه دوال مرتبطة بالـ log delegate، بتتنفذ كلها.

وده بيسمحلك تسجل الرسالة بأكتر من طريقة (على حسب ما ربطت إيه بالـ delegate)

✅ طيب ليه عملته كده؟ إيه الهدف؟
🎯 الهدف:
مرونة: بدل ما تكتب Console.WriteLine() في كل مكان، بتكتب logger.LogAction("...")، وتغير طريقة العرض من مكان واحد.

تعدد الطرق: تقدر تسجل نفس الرسالة بأكتر من طريقة في نفس الوقت (مثلاً: على الكونسول، ومع الوقت، أو حتى في ملف).

فصل المسؤوليات: الكود الخاص بالعرض منفصل عن الكود الخاص بالحدث نفسه.

✅ مثال الاستخدام:

Logger logger = new Logger();

// ربط طريقتين للعرض
logger.log = logger.LogToConsole;
logger.log += logger.LogWithTimestamp;

// تسجيل حدث
logger.LogAction("Ahmed registered a course.");
📤 الإخراج:

LOG: Ahmed registered a course.
[7/20/2025 5:30:12 PM] Ahmed registered a course.
========================================================================================

foreach (var item in items)
{
var property = item.GetType().GetProperty("Id");
if (property != null)
{
int itemId = (int)property.GetValue(item);
if (itemId == id)
return item.ToString();
}
}
return "Item not found.";
🧠 الفكرة العامة:
🔹 بتدور على عنصر في القائمة items، اللي نوعهم عام T
🔹 بتستخدم Reflection علشان تتأكد إن كل عنصر فيه خاصية اسمها "Id"
🔹 لو لقيت عنصر قيمة Id بتاعه = id المطلوب → ترجع العنصر كـ نص
🔹 لو مفيش أي تطابق → ترجع "Item not found."

🪜 الشرح سطرًا بسطر:
🔹 foreach (var item in items)
بتمر على كل عنصر داخل قائمة items (اللي نوعها غالبًا List<T>)

🔹 var property = item.GetType().GetProperty("Id");
item.GetType() بترجع النوع الفعلي للعنصر (مثلاً Student, Course, إلخ)

GetProperty("Id") بتدور في النوع ده على خاصية اسمها "Id" (بـ string)

لو لقيتها، بترجعلك كائن من نوع PropertyInfo بتمثّل خاصية Id

🔹 if (property != null)
بتتأكد إن الخاصية Id موجودة فعلًا في الكائن

🔹 int itemId = (int)property.GetValue(item);
بتستخدم GetValue(item) علشان تجيب قيمة الخاصية Id من العنصر

وبعدين بتحول القيمة لـ int (لأنك متوقع إن الـ Id رقمي)

🔹 if (itemId == id) return item.ToString();
لو قيمة الـ Id بتاعة العنصر = id اللي بتدور عليه

ترجع العنصر على هيئة نص باستخدام ToString()

🔹 return "Item not found.";
لو خلصت اللف على كل العناصر ومفيش تطابق → ترجع رسالة "Item not found."

🎯 مثال واقعي:
افترض إن عندك:

public class Student
{
public int Id { get; set; }
public string Name { get; set; }

    public override string ToString()
    {
        return $"Student: {Name} (ID: {Id})";
    }

}
ولو عندك:

List<Student> students = new List<Student>
{
new Student { Id = 101, Name = "Ahmed" },
new Student { Id = 102, Name = "Sara" }
};
فلو شغّلت:

GetItemById(102);
هترجع:
Student: Sara (ID: 102)

========================================================================================

🔹 int countX = x.EnrolledCourses?.Count ?? 0;
هنا بيحسب عدد الكورسات المسجل فيها x

?.Count يعني: لو EnrolledCourses مش null → هات عددها

?? 0 يعني: لو EnrolledCourses كانت null → اعتبرها 0

========================================================================================get
{
var student = Students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
Students هي قائمة الطلاب

FirstOrDefault بتدور على أول طالب اسمه يساوي name

Equals(..., StringComparison.OrdinalIgnoreCase) بتقارن بدون حساسية لحالة الحروف (يعني "ahmed" = "Ahmed")

if (student == null)
{
throw new KeyNotFoundException($"Student with name '{name}' not found.");
}
لو الطالب مش موجود → يرميلك استثناء من النوع KeyNotFoundException

وبيكتب فيه اسم الطالب اللي مش لاقيه

return student;
لو الطالب اتلاقى، بيرجعه ككائن Student

🔁 مثال عملي:
لو عندك:

List<Student> Students = new List<Student>
{
new Student { Name = "Ahmed", Id = 1 },
new Student { Name = "Sara", Id = 2 }
};
وسألت:
var s = sm["sara"];
Console.WriteLine(s.Id);
هترجعلك الطالب "Sara" رغم إنك كتبت الاسم كله small.

⚠️ لو الطالب مش موجود:
var s = sm["mohamed"];
هيرمي خطأ:

KeyNotFoundException: Student with name 'mohamed' not found.
✅ ليه نستخدم Indexer بالطريقة دي؟
الفائدة التوضيح
🔹 تحسين واجهة الاستخدام (API Design) تقدر توصل للطالب بطريقة سهلة sm["Ahmed"]
🔹 مرونة أكثر بدل ما تعمل FindStudentByName(name) كل مرة
🔹 مقارنة غير حساسة لحالة الحروف OrdinalIgnoreCase يخليك مش مضطر تكتب الاسم بحروف متطابقة بالضبط
🔹 التعامل مع أخطاء البحث بشكل واضح throw بيخليك تعرف إن فيه خطأ بدل ما ترجع null بس

public Student this[string name]
{
get
{
foreach (var student in Students)
{
if (student.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
return student;
}
throw new KeyNotFoundException($"Student with name '{name}' not found.");
}
}
نفس الكود برضه

========================================================================================================
