from pathlib import Path

base = Path(r"C:\Users\hp\OneDrive\Documents\c# Ajinkya Ghuge\MyFirstApp\Level2_Arrays_Strings")
base.mkdir(parents=True, exist_ok=True)

programs = [
    ("Program51_ReadAndDisplayArrayElements.cs", "Program51_ReadAndDisplayArrayElements", "using System;"),
    ("Program52_SumAndAverageOfArray.cs", "Program52_SumAndAverageOfArray", "using System;"),
    ("Program53_LargestAndSmallestInArray.cs", "Program53_LargestAndSmallestInArray", "using System;"),
    ("Program54_SortArrayElements.cs", "Program54_SortArrayElements", "using System;"),
    ("Program55_ReverseArray.cs", "Program55_ReverseArray", "using System;"),
    ("Program56_MergeTwoArrays.cs", "Program56_MergeTwoArrays", "using System;"),
    ("Program57_RemoveDuplicatesFromArray.cs", "Program57_RemoveDuplicatesFromArray", "using System;\nusing System.Collections.Generic;"),
    ("Program58_SearchElementInArray.cs", "Program58_SearchElementInArray", "using System;"),
    ("Program59_MatrixAddition.cs", "Program59_MatrixAddition", "using System;"),
    ("Program60_MatrixMultiplication.cs", "Program60_MatrixMultiplication", "using System;"),
    ("Program61_TransposeOfMatrix.cs", "Program61_TransposeOfMatrix", "using System;"),
    ("Program62_CountVowelsInString.cs", "Program62_CountVowelsInString", "using System;"),
    ("Program63_ReverseString.cs", "Program63_ReverseString", "using System;"),
    ("Program64_PalindromeString.cs", "Program64_PalindromeString", "using System;"),
    ("Program65_CountWordsInString.cs", "Program65_CountWordsInString", "using System;"),
    ("Program66_CharacterFrequencyInString.cs", "Program66_CharacterFrequencyInString", "using System;\nusing System.Collections.Generic;"),
    ("Program67_RemoveWhitespacesFromString.cs", "Program67_RemoveWhitespacesFromString", "using System;"),
    ("Program68_ReplaceSubstringInString.cs", "Program68_ReplaceSubstringInString", "using System;"),
    ("Program69_StringBuilderDemo.cs", "Program69_StringBuilderDemo", "using System;\nusing System.Text;"),
    ("Program70_CompareStrings.cs", "Program70_CompareStrings", "using System;"),
    ("Program71_MethodsWithParameters.cs", "Program71_MethodsWithParameters", "using System;"),
    ("Program72_MethodOverloading.cs", "Program72_MethodOverloading", "using System;"),
    ("Program73_RecursionExample.cs", "Program73_RecursionExample", "using System;"),
    ("Program74_FibonacciUsingRecursion.cs", "Program74_FibonacciUsingRecursion", "using System;"),
    ("Program75_FactorialUsingRecursion.cs", "Program75_FactorialUsingRecursion", "using System;"),
    ("Program76_OutAndRefKeywords.cs", "Program76_OutAndRefKeywords", "using System;"),
    ("Program77_ParamsKeyword.cs", "Program77_ParamsKeyword", "using System;"),
    ("Program78_OptionalParameters.cs", "Program78_OptionalParameters", "using System;"),
    ("Program79_NamedArguments.cs", "Program79_NamedArguments", "using System;"),
    ("Program80_StaticMethods.cs", "Program80_StaticMethods", "using System;"),
    ("Program81_PassingArrayToMethod.cs", "Program81_PassingArrayToMethod", "using System;"),
    ("Program82_SecondLargestInArray.cs", "Program82_SecondLargestInArray", "using System;"),
    ("Program83_SplitStringIntoWords.cs", "Program83_SplitStringIntoWords", "using System;"),
    ("Program84_CheckAnagramStrings.cs", "Program84_CheckAnagramStrings", "using System;"),
    ("Program85_RemoveSpecialCharacters.cs", "Program85_RemoveSpecialCharacters", "using System;\nusing System.Text.RegularExpressions;"),
    ("Program86_UppercaseLowercaseConversion.cs", "Program86_UppercaseLowercaseConversion", "using System;"),
    ("Program87_ValidateEmailFormat.cs", "Program87_ValidateEmailFormat", "using System;\nusing System.Text.RegularExpressions;"),
    ("Program88_ValidatePasswordStrength.cs", "Program88_ValidatePasswordStrength", "using System;\nusing System.Text.RegularExpressions;"),
    ("Program89_RegularExpressionsDemo.cs", "Program89_RegularExpressionsDemo", "using System;\nusing System.Text.RegularExpressions;"),
    ("Program90_IndexersDemo.cs", "Program90_IndexersDemo", "using System;"),
    ("Program91_JaggedArraysDemo.cs", "Program91_JaggedArraysDemo", "using System;"),
    ("Program92_MultidimensionalArraysDemo.cs", "Program92_MultidimensionalArraysDemo", "using System;"),
    ("Program93_StringFormattingDemo.cs", "Program93_StringFormattingDemo", "using System;"),
    ("Program94_CommonElementsInTwoArrays.cs", "Program94_CommonElementsInTwoArrays", "using System;\nusing System.Collections.Generic;"),
    ("Program95_MissingNumberInArray.cs", "Program95_MissingNumberInArray", "using System;"),
    ("Program96_DuplicateElementsInArray.cs", "Program96_DuplicateElementsInArray", "using System;\nusing System.Collections.Generic;"),
    ("Program97_SpanAndReadOnlySpanDemo.cs", "Program97_SpanAndReadOnlySpanDemo", "using System;"),
    ("Program98_ValueVsReferenceTypes.cs", "Program98_ValueVsReferenceTypes", "using System;"),
    ("Program99_StringImmutabilityDemo.cs", "Program99_StringImmutabilityDemo", "using System;"),
    ("Program100_MemoryManagementBasics.cs", "Program100_MemoryManagementBasics", "using System;\nusing System.Collections.Generic;"),
]

bodies = {
    "Program51_ReadAndDisplayArrayElements": """
// Program 51: Read and display array elements.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Array elements are:");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
""",
    "Program52_SumAndAverageOfArray": """
// Program 52: Find sum and average of array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    sum += arr[i];
}

double average = n > 0 ? (double)sum / n : 0;
Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"Average = {average}");
""",
    "Program53_LargestAndSmallestInArray": """
// Program 53: Find largest and smallest element in array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int largest = arr[0];
int smallest = arr[0];
for (int i = 1; i < n; i++)
{
    if (arr[i] > largest) largest = arr[i];
    if (arr[i] < smallest) smallest = arr[i];
}

Console.WriteLine($"Largest = {largest}");
Console.WriteLine($"Smallest = {smallest}");
""",
    "Program54_SortArrayElements": """
// Program 54: Sort array elements.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arr);
Console.WriteLine("Sorted array:");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();
""",
    "Program55_ReverseArray": """
// Program 55: Reverse an array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Reverse(arr);
Console.WriteLine("Reversed array:");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();
""",
    "Program56_MergeTwoArrays": """
// Program 56: Merge two arrays.
Console.Write("Enter size of first array: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n1];
for (int i = 0; i < n1; i++)
{
    Console.Write($"A[{i}]: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Enter size of second array: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[] b = new int[n2];
for (int i = 0; i < n2; i++)
{
    Console.Write($"B[{i}]: ");
    b[i] = Convert.ToInt32(Console.ReadLine());
}

int[] merged = new int[n1 + n2];
for (int i = 0; i < n1; i++) merged[i] = a[i];
for (int i = 0; i < n2; i++) merged[n1 + i] = b[i];

Console.WriteLine("Merged array:");
foreach (int item in merged) Console.Write(item + " ");
Console.WriteLine();
""",
    "Program57_RemoveDuplicatesFromArray": """
// Program 57: Remove duplicate elements from array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

HashSet<int> unique = new HashSet<int>();
foreach (int item in arr) unique.Add(item);

Console.WriteLine("Array after removing duplicates:");
foreach (int item in unique) Console.Write(item + " ");
Console.WriteLine();
""",
    "Program58_SearchElementInArray": """
// Program 58: Search an element in array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Enter element to search: ");
int key = Convert.ToInt32(Console.ReadLine());
int index = Array.IndexOf(arr, key);

if (index >= 0) Console.WriteLine($"Element found at index {index}");
else Console.WriteLine("Element not found");
""",
    "Program59_MatrixAddition": """
// Program 59: Matrix addition.
Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[rows, cols];
int[,] b = new int[rows, cols];
int[,] sum = new int[rows, cols];

Console.WriteLine("Enter first matrix:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"A[{i},{j}]: ");
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Enter second matrix:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"B[{i},{j}]: ");
        b[i, j] = Convert.ToInt32(Console.ReadLine());
        sum[i, j] = a[i, j] + b[i, j];
    }
}

Console.WriteLine("Sum matrix:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++) Console.Write(sum[i, j] + " ");
    Console.WriteLine();
}
""",
    "Program60_MatrixMultiplication": """
// Program 60: Matrix multiplication.
Console.Write("Enter rows of first matrix: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns of first matrix: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter rows of second matrix: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns of second matrix: ");
int c2 = Convert.ToInt32(Console.ReadLine());

if (c1 != r2)
{
    Console.WriteLine("Matrix multiplication not possible.");
    return;
}

int[,] a = new int[r1, c1];
int[,] b = new int[r2, c2];
int[,] result = new int[r1, c2];

Console.WriteLine("Enter first matrix:");
for (int i = 0; i < r1; i++)
{
    for (int j = 0; j < c1; j++)
    {
        Console.Write($"A[{i},{j}]: ");
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Enter second matrix:");
for (int i = 0; i < r2; i++)
{
    for (int j = 0; j < c2; j++)
    {
        Console.Write($"B[{i},{j}]: ");
        b[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < r1; i++)
{
    for (int j = 0; j < c2; j++)
    {
        for (int k = 0; k < c1; k++) result[i, j] += a[i, k] * b[k, j];
    }
}

Console.WriteLine("Result matrix:");
for (int i = 0; i < r1; i++)
{
    for (int j = 0; j < c2; j++) Console.Write(result[i, j] + " ");
    Console.WriteLine();
}
""",
    "Program61_TransposeOfMatrix": """
// Program 61: Transpose of matrix.
Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];

Console.WriteLine("Enter matrix:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"M[{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Transpose:");
for (int i = 0; i < cols; i++)
{
    for (int j = 0; j < rows; j++) Console.Write(matrix[j, i] + " ");
    Console.WriteLine();
}
""",
    "Program62_CountVowelsInString": """
// Program 62: Count vowels in a string.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
int count = 0;
foreach (char c in text.ToLower())
{
    if ("aeiou".Contains(c)) count++;
}
Console.WriteLine($"Vowel count = {count}");
""",
    "Program63_ReverseString": """
// Program 63: Reverse a string.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
char[] chars = text.ToCharArray();
Array.Reverse(chars);
Console.WriteLine("Reversed string: " + new string(chars));
""",
    "Program64_PalindromeString": """
// Program 64: Check palindrome string.
Console.Write("Enter a string: ");
string input = Console.ReadLine() ?? "";
string text = input.ToLower().Replace(" ", "");
char[] chars = text.ToCharArray();
Array.Reverse(chars);
string rev = new string(chars);
Console.WriteLine(text == rev ? "Palindrome string" : "Not a palindrome string");
""",
    "Program65_CountWordsInString": """
// Program 65: Count words in a string.
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine() ?? "";
string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Word count = {words.Length}");
""",
    "Program66_CharacterFrequencyInString": """
// Program 66: Character frequency in string.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
Dictionary<char, int> freq = new Dictionary<char, int>();

foreach (char c in text)
{
    if (freq.ContainsKey(c)) freq[c]++;
    else freq[c] = 1;
}

Console.WriteLine("Character frequencies:");
foreach (var pair in freq)
{
    Console.WriteLine($"{pair.Key} : {pair.Value}");
}
""",
    "Program67_RemoveWhitespacesFromString": """
// Program 67: Remove white spaces from string.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
string noSpaces = text.Replace(" ", "");
Console.WriteLine("After removing spaces: " + noSpaces);
""",
    "Program68_ReplaceSubstringInString": """
// Program 68: Replace substring in string.
Console.Write("Enter original string: ");
string text = Console.ReadLine() ?? "";
Console.Write("Enter old substring: ");
string oldValue = Console.ReadLine() ?? "";
Console.Write("Enter new substring: ");
string newValue = Console.ReadLine() ?? "";
Console.WriteLine("Result: " + text.Replace(oldValue, newValue));
""",
    "Program69_StringBuilderDemo": """
// Program 69: Demonstrate StringBuilder.
StringBuilder sb = new StringBuilder();
sb.Append("C#");
sb.Append(" ");
sb.Append("StringBuilder");
sb.AppendLine(" Demo");
sb.Replace("Demo", "Example");
Console.WriteLine(sb.ToString());
""",
    "Program70_CompareStrings": """
// Program 70: Compare strings.
Console.Write("Enter first string: ");
string a = Console.ReadLine() ?? "";
Console.Write("Enter second string: ");
string b = Console.ReadLine() ?? "";

int result = string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
if (result == 0) Console.WriteLine("Strings are equal");
else if (result < 0) Console.WriteLine("First string is smaller");
else Console.WriteLine("First string is greater");
""",
    "Program71_MethodsWithParameters": """
// Program 71: Methods with parameters.
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Add(a, b);

static void Add(int x, int y)
{
    Console.WriteLine($"Sum = {x + y}");
}
""",
    "Program72_MethodOverloading": """
// Program 72: Method overloading.
Console.WriteLine($"Add(int, int) = {Add(5, 10)}");
Console.WriteLine($"Add(double, double) = {Add(5.5, 10.2)}");

static int Add(int a, int b) => a + b;
static double Add(double a, double b) => a + b;
""",
    "Program73_RecursionExample": """
// Program 73: Recursion example (sum from 1 to n).
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum = {SumToN(n)}");

static int SumToN(int x)
{
    if (x <= 0) return 0;
    return x + SumToN(x - 1);
}
""",
    "Program74_FibonacciUsingRecursion": """
// Program 74: Fibonacci using recursion.
Console.Write("Enter number of terms: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci(i) + " ");
}
Console.WriteLine();

static int Fibonacci(int x)
{
    if (x <= 1) return x;
    return Fibonacci(x - 1) + Fibonacci(x - 2);
}
""",
    "Program75_FactorialUsingRecursion": """
// Program 75: Factorial using recursion.
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial = {Factorial(n)}");

static long Factorial(int x)
{
    if (x <= 1) return 1;
    return x * Factorial(x - 1);
}
""",
    "Program76_OutAndRefKeywords": """
// Program 76: Demonstrate out and ref keywords.
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

DoubleValue(ref number);
Console.WriteLine($"After ref method: {number}");

GetSquareAndCube(number, out int square, out int cube);
Console.WriteLine($"Square = {square}, Cube = {cube}");

static void DoubleValue(ref int x)
{
    x = x * 2;
}

static void GetSquareAndCube(int x, out int square, out int cube)
{
    square = x * x;
    cube = x * x * x;
}
""",
    "Program77_ParamsKeyword": """
// Program 77: Demonstrate params keyword.
Console.WriteLine("Sum(1,2,3) = " + Sum(1, 2, 3));
Console.WriteLine("Sum(5,10,15,20) = " + Sum(5, 10, 15, 20));

static int Sum(params int[] numbers)
{
    int total = 0;
    foreach (int n in numbers) total += n;
    return total;
}
""",
    "Program78_OptionalParameters": """
// Program 78: Demonstrate optional parameters.
Greet("Ajinkya");
Greet("Ajinkya", "Good Evening");

static void Greet(string name, string message = "Good Morning")
{
    Console.WriteLine($"{message}, {name}");
}
""",
    "Program79_NamedArguments": """
// Program 79: Demonstrate named arguments.
PrintDetails(name: "Rahul", age: 23, city: "Pune");
PrintDetails(city: "Mumbai", age: 25, name: "Neha");

static void PrintDetails(string name, int age, string city)
{
    Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
}
""",
    "Program80_StaticMethods": """
// Program 80: Demonstrate static methods.
Console.Write("Enter radius: ");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Area of circle = {CalculateArea(r)}");

static double CalculateArea(double radius)
{
    return Math.PI * radius * radius;
}
""",
    "Program81_PassingArrayToMethod": """
// Program 81: Demonstrate passing array to method.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(arr);

static void PrintArray(int[] values)
{
    Console.WriteLine("Array values:");
    foreach (int item in values) Console.Write(item + " ");
    Console.WriteLine();
}
""",
    "Program82_SecondLargestInArray": """
// Program 82: Find second largest element in array.
Console.Write("Enter number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(arr);
Array.Reverse(arr);

int secondLargest = arr[0];
for (int i = 1; i < n; i++)
{
    if (arr[i] != arr[0])
    {
        secondLargest = arr[i];
        break;
    }
}

Console.WriteLine($"Second largest = {secondLargest}");
""",
    "Program83_SplitStringIntoWords": """
// Program 83: Split string into words.
Console.Write("Enter a sentence: ");
string text = Console.ReadLine() ?? "";
string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Words are:");
foreach (string word in words) Console.WriteLine(word);
""",
    "Program84_CheckAnagramStrings": """
// Program 84: Check anagram strings.
Console.Write("Enter first string: ");
string s1 = (Console.ReadLine() ?? "").ToLower().Replace(" ", "");
Console.Write("Enter second string: ");
string s2 = (Console.ReadLine() ?? "").ToLower().Replace(" ", "");

char[] a1 = s1.ToCharArray();
char[] a2 = s2.ToCharArray();
Array.Sort(a1);
Array.Sort(a2);

bool isAnagram = new string(a1) == new string(a2);
Console.WriteLine(isAnagram ? "Anagram strings" : "Not anagram strings");
""",
    "Program85_RemoveSpecialCharacters": """
// Program 85: Remove special characters from string.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
string clean = Regex.Replace(text, "[^a-zA-Z0-9 ]", "");
Console.WriteLine("After removing special characters: " + clean);
""",
    "Program86_UppercaseLowercaseConversion": """
// Program 86: Convert string to uppercase/lowercase.
Console.Write("Enter a string: ");
string text = Console.ReadLine() ?? "";
Console.WriteLine("Uppercase: " + text.ToUpper());
Console.WriteLine("Lowercase: " + text.ToLower());
""",
    "Program87_ValidateEmailFormat": """
// Program 87: Validate email format.
Console.Write("Enter email: ");
string email = Console.ReadLine() ?? "";
string pattern = @"^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$";
bool isValid = Regex.IsMatch(email, pattern);
Console.WriteLine(isValid ? "Valid email format" : "Invalid email format");
""",
    "Program88_ValidatePasswordStrength": """
// Program 88: Validate password strength.
Console.Write("Enter password: ");
string password = Console.ReadLine() ?? "";

// At least 8 chars, 1 uppercase, 1 lowercase, 1 digit, 1 special char.
string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^A-Za-z0-9]).{8,}$";
bool strong = Regex.IsMatch(password, pattern);
Console.WriteLine(strong ? "Strong password" : "Weak password");
""",
    "Program89_RegularExpressionsDemo": """
// Program 89: Demonstrate regular expressions.
Console.Write("Enter a sentence: ");
string text = Console.ReadLine() ?? "";

// Find all words starting with capital letters.
MatchCollection matches = Regex.Matches(text, @"\\b[A-Z][a-zA-Z]*\\b");
Console.WriteLine("Words starting with capital letters:");
foreach (Match m in matches) Console.WriteLine(m.Value);
""",
    "Program90_IndexersDemo": """
// Program 90: Demonstrate indexers.
NumberStore store = new NumberStore(5);
for (int i = 0; i < 5; i++)
{
    store[i] = (i + 1) * 10;
}

Console.WriteLine("Values from indexer:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"store[{i}] = {store[i]}");
}
""",
    "Program91_JaggedArraysDemo": """
// Program 91: Demonstrate jagged arrays.
int[][] jagged = new int[3][];
jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 3, 4, 5 };
jagged[2] = new int[] { 6, 7, 8, 9 };

for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}
""",
    "Program92_MultidimensionalArraysDemo": """
// Program 92: Demonstrate multidimensional arrays.
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
""",
    "Program93_StringFormattingDemo": """
// Program 93: Demonstrate string formatting.
string name = "Amit";
int age = 24;
double salary = 45678.90;

Console.WriteLine("Name: {0}, Age: {1}, Salary: {2:F2}", name, age, salary);
Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:F2}");
""",
    "Program94_CommonElementsInTwoArrays": """
// Program 94: Find common elements in two arrays.
int[] a = { 1, 2, 3, 4, 5 };
int[] b = { 4, 5, 6, 7, 8 };

HashSet<int> set = new HashSet<int>(a);
Console.WriteLine("Common elements:");
foreach (int item in b)
{
    if (set.Contains(item)) Console.Write(item + " ");
}
Console.WriteLine();
""",
    "Program95_MissingNumberInArray": """
// Program 95: Find missing number in array (1 to n).
Console.Write("Enter n (max number): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of elements (n-1): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int actualSum = 0;

for (int i = 0; i < size; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    actualSum += arr[i];
}

int expectedSum = n * (n + 1) / 2;
Console.WriteLine($"Missing number = {expectedSum - actualSum}");
""",
    "Program96_DuplicateElementsInArray": """
// Program 96: Find duplicate elements in array.
int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6, 3 };
HashSet<int> seen = new HashSet<int>();
HashSet<int> duplicates = new HashSet<int>();

foreach (int item in arr)
{
    if (!seen.Add(item)) duplicates.Add(item);
}

Console.WriteLine("Duplicate elements:");
foreach (int item in duplicates) Console.Write(item + " ");
Console.WriteLine();
""",
    "Program97_SpanAndReadOnlySpanDemo": """
// Program 97: Demonstrate Span and ReadOnlySpan.
int[] numbers = { 10, 20, 30, 40, 50 };

// Span can modify underlying array.
Span<int> span = numbers.AsSpan(1, 3);
span[0] = 999;

// ReadOnlySpan allows read-only view.
ReadOnlySpan<int> readOnly = numbers.AsSpan();

Console.WriteLine("Array after Span modification:");
foreach (int n in numbers) Console.Write(n + " ");
Console.WriteLine();

Console.WriteLine("ReadOnlySpan values:");
for (int i = 0; i < readOnly.Length; i++) Console.Write(readOnly[i] + " ");
Console.WriteLine();
""",
    "Program98_ValueVsReferenceTypes": """
// Program 98: Demonstrate value vs reference types.
int a = 10;
int b = a; // Value copy
b = 20;
Console.WriteLine($"Value types -> a: {a}, b: {b}");

int[] x = { 1, 2, 3 };
int[] y = x; // Reference copy
y[0] = 99;
Console.WriteLine($"Reference types -> x[0]: {x[0]}, y[0]: {y[0]}");
""",
    "Program99_StringImmutabilityDemo": """
// Program 99: Demonstrate immutability of strings.
string s1 = "Hello";
string s2 = s1;
s1 = s1 + " World";

Console.WriteLine("s1 = " + s1);
Console.WriteLine("s2 = " + s2);
Console.WriteLine("Original string was not modified, a new string was created.");
""",
    "Program100_MemoryManagementBasics": """
// Program 100: Demonstrate memory management basics.
long before = GC.GetTotalMemory(false);
Console.WriteLine($"Memory before allocation: {before} bytes");

List<byte[]> blocks = new List<byte[]>();
for (int i = 0; i < 20; i++)
{
    // Allocate memory blocks.
    blocks.Add(new byte[1024 * 100]);
}

long afterAlloc = GC.GetTotalMemory(false);
Console.WriteLine($"Memory after allocation: {afterAlloc} bytes");

// Release references and force garbage collection.
blocks = null;
GC.Collect();
GC.WaitForPendingFinalizers();

long afterGc = GC.GetTotalMemory(true);
Console.WriteLine($"Memory after GC: {afterGc} bytes");
""",
}

indexer_helper = """
    // Helper class with indexer.
    public class NumberStore
    {
        private int[] data;

        public NumberStore(int size)
        {
            data = new int[size];
        }

        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
"""

template = """__USINGS__

namespace Level2_Arrays_Strings
{
    public class __CLASS__
    {
        public static void Main()
        {
__BODY__
        }
__EXTRA__
    }
}
"""

for file_name, class_name, usings in programs:
    body = bodies[class_name].strip("\n")
    body_indented = "\n".join("            " + line if line else "" for line in body.splitlines())
    extra = ""
    if class_name == "Program90_IndexersDemo":
        extra = indexer_helper.rstrip()
    content = template.replace("__USINGS__", usings).replace("__CLASS__", class_name).replace("__BODY__", body_indented).replace("__EXTRA__", extra)
    (base / file_name).write_text(content, encoding="utf-8")

print(f"Created {len(programs)} files in {base}")
