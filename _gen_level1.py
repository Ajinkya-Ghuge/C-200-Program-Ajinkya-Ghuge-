from pathlib import Path

target = Path(r"C:\Users\hp\OneDrive\Documents\c# Ajinkya Ghuge\MyFirstApp\Level1_Basics")
target.mkdir(parents=True, exist_ok=True)

programs = [
    ("Program01_HelloWorld.cs", "Program01_HelloWorld", """// Program 1: Hello World
Console.WriteLine("Hello World");"""),
    ("Program02_UserDetails.cs", "Program02_UserDetails", """// Program 2: Display user details
Console.Write("Enter name: ");
string name = Console.ReadLine() ?? "";
Console.Write("Enter age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter city: ");
string city = Console.ReadLine() ?? "";
Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");"""),
    ("Program03_AddTwoNumbers.cs", "Program03_AddTwoNumbers", """// Program 3: Add two numbers
Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Sum = {a + b}");"""),
    ("Program04_MaximumOfTwoNumbers.cs", "Program04_MaximumOfTwoNumbers", """// Program 4: Maximum of two numbers
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Maximum = {Math.Max(a, b)}");"""),
    ("Program05_EvenOrOdd.cs", "Program05_EvenOrOdd", """// Program 5: Even or odd
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");"""),
    ("Program06_PositiveOrNegative.cs", "Program06_PositiveOrNegative", """// Program 6: Positive or negative
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) Console.WriteLine("Positive");
else if (n < 0) Console.WriteLine("Negative");
else Console.WriteLine("Zero");"""),
    ("Program07_SimpleInterest.cs", "Program07_SimpleInterest", """// Program 7: Simple interest
Console.Write("Principal: ");
double p = Convert.ToDouble(Console.ReadLine());
Console.Write("Rate: ");
double r = Convert.ToDouble(Console.ReadLine());
Console.Write("Time (years): ");
double t = Convert.ToDouble(Console.ReadLine());
double si = (p * r * t) / 100;
Console.WriteLine($"Simple Interest = {si}");"""),
    ("Program08_CompoundInterest.cs", "Program08_CompoundInterest", """// Program 8: Compound interest
Console.Write("Principal: ");
double p = Convert.ToDouble(Console.ReadLine());
Console.Write("Rate (%): ");
double r = Convert.ToDouble(Console.ReadLine());
Console.Write("Time (years): ");
double t = Convert.ToDouble(Console.ReadLine());
double amount = p * Math.Pow(1 + r / 100, t);
Console.WriteLine($"Compound Interest = {amount - p}");"""),
    ("Program09_LargestOfThreeNumbers.cs", "Program09_LargestOfThreeNumbers", """// Program 9: Largest of three numbers
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Largest = {Math.Max(a, Math.Max(b, c))}");"""),
    ("Program10_SwapTwoNumbers.cs", "Program10_SwapTwoNumbers", """// Program 10: Swap two numbers
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int temp = a;
a = b;
b = temp;
Console.WriteLine($"After swap: a = {a}, b = {b}");"""),
    ("Program11_Factorial.cs", "Program11_Factorial", """// Program 11: Factorial of a number
Console.Write("Enter a non-negative integer: ");
int n = Convert.ToInt32(Console.ReadLine());
long fact = 1;
for (int i = 2; i <= n; i++) fact *= i;
Console.WriteLine($"Factorial = {fact}");"""),
    ("Program12_FibonacciSeries.cs", "Program12_FibonacciSeries", """// Program 12: Fibonacci series
Console.Write("Enter number of terms: ");
int terms = Convert.ToInt32(Console.ReadLine());
int a = 0, b = 1;
for (int i = 0; i < terms; i++)
{
    Console.Write(a + " ");
    int next = a + b;
    a = b;
    b = next;
}
Console.WriteLine();"""),
    ("Program13_ReverseNumber.cs", "Program13_ReverseNumber", """// Program 13: Reverse a number
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = Math.Abs(n), rev = 0;
while (num > 0)
{
    rev = rev * 10 + num % 10;
    num /= 10;
}
if (n < 0) rev = -rev;
Console.WriteLine($"Reversed = {rev}");"""),
    ("Program14_PalindromeNumber.cs", "Program14_PalindromeNumber", """// Program 14: Check palindrome number
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int original = n, rev = 0;
while (n > 0)
{
    rev = rev * 10 + n % 10;
    n /= 10;
}
Console.WriteLine(original == rev ? "Palindrome" : "Not Palindrome");"""),
    ("Program15_ArmstrongNumber.cs", "Program15_ArmstrongNumber", """// Program 15: Check Armstrong number
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int original = n, digits = original.ToString().Length, sum = 0;
while (n > 0)
{
    int d = n % 10;
    sum += (int)Math.Pow(d, digits);
    n /= 10;
}
Console.WriteLine(original == sum ? "Armstrong Number" : "Not Armstrong Number");"""),
    ("Program16_SumOfDigits.cs", "Program16_SumOfDigits", """// Program 16: Sum of digits
Console.Write("Enter a number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum = 0;
while (n > 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine($"Sum of digits = {sum}");"""),
    ("Program17_CountDigits.cs", "Program17_CountDigits", """// Program 17: Count digits in a number
Console.Write("Enter a number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = (n == 0) ? 1 : 0;
while (n > 0)
{
    count++;
    n /= 10;
}
Console.WriteLine($"Digit count = {count}");"""),
    ("Program18_MultiplicationTable.cs", "Program18_MultiplicationTable", """// Program 18: Multiplication table
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}"""),
    ("Program19_PrimeNumbersInRange.cs", "Program19_PrimeNumbersInRange", """// Program 19: Prime numbers in a range
Console.Write("Start: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("End: ");
int end = Convert.ToInt32(Console.ReadLine());
for (int n = Math.Max(2, start); n <= end; n++)
{
    bool prime = true;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0) { prime = false; break; }
    }
    if (prime) Console.Write(n + " ");
}
Console.WriteLine();"""),
    ("Program20_CheckPrimeNumber.cs", "Program20_CheckPrimeNumber", """// Program 20: Check prime number
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
bool prime = n >= 2;
for (int i = 2; i <= Math.Sqrt(n) && prime; i++)
{
    if (n % i == 0) prime = false;
}
Console.WriteLine(prime ? "Prime" : "Not Prime");"""),
    ("Program21_GCDAndLCM.cs", "Program21_GCDAndLCM", """// Program 21: GCD and LCM
Console.Write("Enter first number: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("Enter second number: ");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int x = a, y = b;
while (y != 0)
{
    int t = y;
    y = x % y;
    x = t;
}
int gcd = x;
int lcm = (a == 0 || b == 0) ? 0 : (a / gcd) * b;
Console.WriteLine($"GCD = {gcd}");
Console.WriteLine($"LCM = {lcm}");"""),
    ("Program22_CelsiusToFahrenheit.cs", "Program22_CelsiusToFahrenheit", """// Program 22: Celsius to Fahrenheit
Console.Write("Enter Celsius: ");
double c = Convert.ToDouble(Console.ReadLine());
double f = (c * 9 / 5) + 32;
Console.WriteLine($"Fahrenheit = {f}");"""),
    ("Program23_AreaOfCircle.cs", "Program23_AreaOfCircle", """// Program 23: Area of circle
Console.Write("Enter radius: ");
double r = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * r * r;
Console.WriteLine($"Area = {area}");"""),
    ("Program24_AreaOfRectangle.cs", "Program24_AreaOfRectangle", """// Program 24: Area of rectangle
Console.Write("Enter length: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter width: ");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Area = {length * width}");"""),
    ("Program25_ASCIIValue.cs", "Program25_ASCIIValue", """// Program 25: ASCII value of a character
Console.Write("Enter a character: ");
char ch = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"ASCII value of {ch} = {(int)ch}");"""),
    ("Program26_TypeCasting.cs", "Program26_TypeCasting", """// Program 26: Type casting demonstration
int intValue = 25;
double implicitCast = intValue; // Implicit cast
double doubleValue = 12.89;
int explicitCast = (int)doubleValue; // Explicit cast
Console.WriteLine($"Implicit cast: {implicitCast}");
Console.WriteLine($"Explicit cast: {explicitCast}");"""),
    ("Program27_ConstantsAndReadonly.cs", "Program27_ConstantsAndReadonly", """// Program 27: Constants and readonly demonstration
const double pi = 3.14159; // const must be compile-time value
DateTime createdAt = DateTime.Now; // local read-only style variable for demo
Console.WriteLine($"PI constant = {pi}");
Console.WriteLine($"Readonly-like created time = {createdAt}");"""),
    ("Program28_OperatorsDemo.cs", "Program28_OperatorsDemo", """// Program 28: Operators demonstration
int a = 10, b = 3;
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"a % b = {a % b}");
Console.WriteLine($"a > b = {a > b}");
Console.WriteLine($"a == b = {a == b}");
Console.WriteLine($"(a > 5 && b < 5) = {a > 5 && b < 5}");"""),
    ("Program29_ConditionalStatements.cs", "Program29_ConditionalStatements", """// Program 29: Conditional statements demonstration
Console.Write("Enter marks (0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());
if (marks >= 75) Console.WriteLine("Distinction");
else if (marks >= 60) Console.WriteLine("First Class");
else if (marks >= 35) Console.WriteLine("Pass");
else Console.WriteLine("Fail");"""),
    ("Program30_SwitchCase.cs", "Program30_SwitchCase", """// Program 30: Switch-case demonstration
Console.Write("Enter number (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
    default: Console.WriteLine("Invalid"); break;
}"""),
    ("Program31_ForLoop.cs", "Program31_ForLoop", """// Program 31: For loop demonstration
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}"""),
    ("Program32_WhileLoop.cs", "Program32_WhileLoop", """// Program 32: While loop demonstration
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}"""),
    ("Program33_DoWhileLoop.cs", "Program33_DoWhileLoop", """// Program 33: Do-while loop demonstration
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 10);"""),
    ("Program34_BreakAndContinue.cs", "Program34_BreakAndContinue", """// Program 34: Break and continue demonstration
for (int i = 1; i <= 10; i++)
{
    if (i == 5) continue; // Skip 5
    if (i == 9) break;    // Stop at 9
    Console.WriteLine(i);
}"""),
    ("Program35_StarPattern.cs", "Program35_StarPattern", """// Program 35: Star pattern
Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++) Console.Write("*");
    Console.WriteLine();
}"""),
    ("Program36_RandomNumbers.cs", "Program36_RandomNumbers", """// Program 36: Random numbers
Random random = new Random();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(random.Next(1, 101));
}"""),
    ("Program37_PowerOfNumber.cs", "Program37_PowerOfNumber", """// Program 37: Power of a number
Console.Write("Enter base: ");
double baseNum = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter exponent: ");
double exp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Result = {Math.Pow(baseNum, exp)}");"""),
    ("Program38_StudentGrade.cs", "Program38_StudentGrade", """// Program 38: Grade calculation
Console.Write("Enter marks (0-100): ");
int marks = Convert.ToInt32(Console.ReadLine());
char grade = marks >= 90 ? 'A' :
             marks >= 75 ? 'B' :
             marks >= 60 ? 'C' :
             marks >= 35 ? 'D' : 'F';
Console.WriteLine($"Grade = {grade}");"""),
    ("Program39_SalaryWithAllowances.cs", "Program39_SalaryWithAllowances", """// Program 39: Salary with allowances
Console.Write("Enter basic salary: ");
double basic = Convert.ToDouble(Console.ReadLine());
double hra = basic * 0.20; // House rent allowance
double da = basic * 0.10;  // Dearness allowance
double gross = basic + hra + da;
Console.WriteLine($"HRA = {hra}, DA = {da}, Gross Salary = {gross}");"""),
    ("Program40_SumOfNaturalNumbers.cs", "Program40_SumOfNaturalNumbers", """// Program 40: Sum of natural numbers
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = n * (n + 1) / 2; // Formula for first n natural numbers
Console.WriteLine($"Sum = {sum}");"""),
    ("Program41_LeapYear.cs", "Program41_LeapYear", """// Program 41: Leap year check
Console.Write("Enter year: ");
int year = Convert.ToInt32(Console.ReadLine());
bool leap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
Console.WriteLine(leap ? "Leap Year" : "Not Leap Year");"""),
    ("Program42_DaysToYearsMonthsDays.cs", "Program42_DaysToYearsMonthsDays", """// Program 42: Convert days into years, months, days
Console.Write("Enter total days: ");
int totalDays = Convert.ToInt32(Console.ReadLine());
int years = totalDays / 365;
int rem = totalDays % 365;
int months = rem / 30;
int days = rem % 30;
Console.WriteLine($"Years = {years}, Months = {months}, Days = {days}");"""),
    ("Program43_NullableTypes.cs", "Program43_NullableTypes", """// Program 43: Nullable types demonstration
int? number = null; // Nullable int can store null
Console.WriteLine(number.HasValue ? $"Value = {number.Value}" : "Value is null");
number = 10;
Console.WriteLine($"After assignment = {number}");"""),
    ("Program44_VarAndDynamic.cs", "Program44_VarAndDynamic", """// Program 44: var and dynamic demonstration
var text = "Hello"; // var is compile-time typed
dynamic value = 10; // dynamic is runtime typed
Console.WriteLine($"var text = {text}");
Console.WriteLine($"dynamic value = {value}");
value = "Now string";
Console.WriteLine($"dynamic changed = {value}");"""),
    ("Program45_EnumDemo.cs", "Program45_EnumDemo", """// Program 45: Enum demonstration
Day today = Day.Monday;
Console.WriteLine($"Today = {today}");
Console.WriteLine($"Numeric value = {(int)today}");

enum Day
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}"""),
    ("Program46_StructDemo.cs", "Program46_StructDemo", """// Program 46: Struct demonstration
Student s;
s.Id = 1;
s.Name = "Ajinkya";
Console.WriteLine($"Id = {s.Id}, Name = {s.Name}");

struct Student
{
    public int Id;
    public string Name;
}"""),
    ("Program47_TuplesDemo.cs", "Program47_TuplesDemo", """// Program 47: Tuple demonstration
(int id, string name, double marks) student = (101, "Neha", 88.5);
Console.WriteLine($"Id = {student.id}, Name = {student.name}, Marks = {student.marks}");"""),
    ("Program48_StringInterpolation.cs", "Program48_StringInterpolation", """// Program 48: String interpolation demonstration
string name = "Ravi";
int age = 22;
double score = 91.5;
Console.WriteLine($"Name: {name}, Age: {age}, Score: {score}");"""),
    ("Program49_MathClassDemo.cs", "Program49_MathClassDemo", """// Program 49: Math class demonstration
double value = 25.64;
Console.WriteLine($"Sqrt = {Math.Sqrt(value)}");
Console.WriteLine($"Pow(value, 2) = {Math.Pow(value, 2)}");
Console.WriteLine($"Round = {Math.Round(value)}");
Console.WriteLine($"Floor = {Math.Floor(value)}");
Console.WriteLine($"Ceiling = {Math.Ceiling(value)}");
Console.WriteLine($"Abs(-10) = {Math.Abs(-10)}");"""),
    ("Program50_DateTimeClassDemo.cs", "Program50_DateTimeClassDemo", """// Program 50: DateTime class demonstration
DateTime now = DateTime.Now;
Console.WriteLine($"Current Date and Time: {now}");
Console.WriteLine($"Short Date: {now.ToShortDateString()}");
Console.WriteLine($"Long Date: {now.ToLongDateString()}");
Console.WriteLine($"Short Time: {now.ToShortTimeString()}");
Console.WriteLine($"Day of Week: {now.DayOfWeek}");
Console.WriteLine($"After 7 days: {now.AddDays(7).ToShortDateString()}");"""),
]

template = """using System;

namespace CSharpPrograms
{
    public class __CLASS_NAME__
    {
        public static void Main()
        {{
__BODY__
        }}
    }
}
"""

for file_name, class_name, body in programs:
    indented = "\n".join("            " + line if line else "" for line in body.splitlines())
    content = template.replace("__CLASS_NAME__", class_name).replace("__BODY__", indented)
    (target / file_name).write_text(content, encoding="utf-8")

print(f"Created {len(programs)} files in {target}")
