// // // Complete Cstring operations checklist + exercise questions for practice. Great for exams, assignments, or interview prep.



// // // ✅ CString Operations (Most Common & Important)

// // //  1️⃣ Creating Strings

// // // * String literal
// // // * Using `new string()`

// // //  2️⃣ String Properties

// // // * `.Length`

// // //  3️⃣ Accessing Characters

// // // * Indexing `str[0]`
// // // * Looping through characters

// // //  4️⃣ Concatenation

// // // * `+`
// // // * `String.Concat()`
// // // * `String.Join()`

// // //  5️⃣ String Interpolation

// // // * `$"Hello {name}"`

// // //  6️⃣ Escape Sequences

// // // * `\n`, `\t`, `\\`, `\"`

// // //  7️⃣ Verbatim Strings

// // // * `@"C:\Users\Docs"`

// // //  8️⃣ Comparison

// // // * `==`
// // // * `.Equals()`
// // // * `String.Compare()`
// // // * case-insensitive comparison

// // //  9️⃣ Searching

// // // * `.Contains()`
// // // * `.StartsWith()`
// // // * `.EndsWith()`
// // // * `.IndexOf()`
// // // * `.LastIndexOf()`

// // //  🔟 Substring Operations

// // // * `.Substring(start, length)`

// // //  1️⃣1️⃣ Modifying Strings

// // // * `.Replace()`
// // // * `.Insert()`
// // // * `.Remove()`

// // //  1️⃣2️⃣ Trimming

// // // * `.Trim()`
// // // * `.TrimStart()`
// // // * `.TrimEnd()`

// // //  1️⃣3️⃣ Changing Case

// // // * `.ToUpper()`
// // // * `.ToLower()`

// // //  1️⃣4️⃣ Splitting & Joining

// // // * `.Split()`
// // // * `String.Join()`

// // //  1️⃣5️⃣ Null/Empty Check

// // // * `String.IsNullOrEmpty()`
// // // * `String.IsNullOrWhiteSpace()`

// // //  1️⃣6️⃣ Formatting

// // // * `String.Format()`
// // // * Interpolation
// // // * Composite formatting

// // //  1️⃣7️⃣ Conversion

// // // * `.ToString()`
// // // * `int.Parse()`
// // // * `Convert.To...()`

// // //  1️⃣8️⃣ StringBuilder (Performance)

// // // * `StringBuilder.Append()`
// // // * `StringBuilder.ToString()`

// // //  1️⃣9️⃣ Immutability

// // // * Proving strings cannot be modified in memory

// // //  2️⃣0️⃣ Character Array Conversion

// // // * `.ToCharArray()`



// // // ✅ Exercise Questions (Beginner → Advanced)

// // // Beginner Exercises

// // // 1. Input your name and print its length.
// // // 2. Print the first, middle, and last character of a string.
// // // 3. Convert a sentence to uppercase and lowercase.
// // // 4. Concatenate first name & last name using 3 different methods.
// // // 5. Check whether a string contains the word `"CSharp"`.
// // // 6. Replace `"bad"` with `"good"` in a sentence.
// // // 7. Remove leading and trailing spaces from `"   Hello World   "`.

// // // Intermediate Exercises

// // // 8. Count vowels and consonants in a string.
// // // 9. Reverse a string without using built-in reverse.
// // // 10. Check if a given string is a palindrome.
// // // 11. Extract username and domain from an email.
// // // 12. Split a sentence into words and print each word.
// // // 13. Find index of first and last occurrence of `'a'`.
// // // 14. Remove the first 3 characters from a string.
// // // 15. Compare two strings ignoring case.



// // // Advanced Exercises

// // // 16. Compress a string: `"aaabbcccc"` → `"a3b2c4"`
// // // 17. Find the most frequent character in a string.
// // // 18. Remove duplicate characters: `"programming"` → `"progamin"`
// // // 19. Capitalize the first letter of every word.
// // // 20. Reverse the order of words, not characters.
// // // 21. Validate password strength using string methods.
// // // 22. Demonstrate string immutability (memory addresses).
// // // 23. Convert a paragraph into a list of sentences.
// // // 24. Write your own `Contains()` method.
// // // 25. Measure performance difference between `+` and `StringBuilder`.



// // // Real-World Practice Tasks

// // // 26. Extract file name from a full file path.
// // // 27. Mask credit card number except last 4 digits.
// // // 28. Validate Nepal phone number format.
// // // 29. Remove all digits from a given string.
// // // 30. Count occurrences of each word in a paragraph.

// // Absolutely ✅ — Here are complete answers with Csolutions for all 30 string exercises. Clean, simple, exam-friendly, beginner to advanced.

// // 

// // Beginner Exercise Answers

// // 

// // ✅ 1. Input your name and print its length

// // ```csharp
// // Console.Write("Enter your name: ");
// // string name = Console.ReadLine();
// // Console.WriteLine($"Length: {name.Length}");
// // ```

// // 

// // ✅ 2. Print first, middle, last character

// // ```csharp
// // string s = "Programming";

// // char first = s[0];
// // char middle = s[s.Length / 2];
// // char last = s[s.Length - 1];

// // Console.WriteLine(first);
// // Console.WriteLine(middle);
// // Console.WriteLine(last);
// // ```

// // 

// // ✅ 3. Convert sentence to upper & lowercase

// // ```csharp
// // string s = "Hello Csharp";
// // Console.WriteLine(s.ToUpper());
// // Console.WriteLine(s.ToLower());
// // ```

// // 

// // ✅ 4. Concatenate first & last name (3 ways)

// // ```csharp
// // string f = "Apar";
// // string l = "Bhandari";

// // Console.WriteLine(f + " " + l);
// // Console.WriteLine(String.Concat(f, " ", l));
// // Console.WriteLine($"{f} {l}");
// // ```

// // 

// // ✅ 5. Check if string contains `"CSharp"`

// // ```csharp
// // string s = "I am learning CSharp";
// // Console.WriteLine(s.Contains("CSharp"));
// // ```

// // 

// // ✅ 6. Replace `"bad"` with `"good"`

// // ```csharp
// // string s = "Today is a bad day";
// // Console.WriteLine(s.Replace("bad", "good"));
// // ```

// // 

// // ✅ 7. Remove leading & trailing spaces

// // ```csharp
// // string s = "   Hello World   ";
// // Console.WriteLine(s.Trim());
// // ```

// // 

// // Intermediate Exercise Answers

// // 

// // ✅ 8. Count vowels & consonants

// // ```csharp
// // string s = "Hello World";
// // int v = 0, c = 0;
// // string vowels = "aeiou";

// // foreach (char ch in s.ToLower())
// // {
// //     if (char.IsLetter(ch))
// //         if (vowels.Contains(ch)) v++;
// //         else c++;
// // }

// // Console.WriteLine($"Vowels: {v}, Consonants: {c}");
// // ```

// // 

// // ✅ 9. Reverse string (without built-in)

// // ```csharp
// // string s = "Hello";
// // string rev = "";

// // for (int i = s.Length - 1; i >= 0; i--)
// //     rev += s[i];

// // Console.WriteLine(rev);
// // ```

// // 

// // ✅ 10. Palindrome checker

// // ```csharp
// // string s = "level";
// // string rev = new string(s.Reverse().ToArray());

// // Console.WriteLine(s == rev ? "Palindrome" : "Not palindrome");
// // ```

// // 

// // ✅ 11. Extract username & domain from email

// // ```csharp
// // string email = "user@gmail.com";
// // string[] parts = email.Split('@');

// // Console.WriteLine($"Username: {parts[0]}");
// // Console.WriteLine($"Domain: {parts[1]}");
// // ```

// // 

// // ✅ 12. Split sentence into words

// // ```csharp
// // string s = "Learn CSharp Programming";
// // string[] words = s.Split(' ');

// // foreach (string w in words)
// //     Console.WriteLine(w);
// // ```

// // 

// // ✅ 13. Index of first & last 'a'

// // ```csharp
// // string s = "banana";
// // Console.WriteLine(s.IndexOf('a'));
// // Console.WriteLine(s.LastIndexOf('a'));
// // ```

// // 

// // ✅ 14. Remove first 3 characters

// // ```csharp
// // string s = "Programming";
// // Console.WriteLine(s.Remove(0, 3));
// // ```

// // 

// // ✅ 15. Compare two strings ignoring case

// // ```csharp
// // string a = "Hello";
// // string b = "hello";

// // Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));
// // ```

// // 

// // Advanced Exercise Answers

// // 

// // ✅ 16. String compression

// // ```csharp
// // string s = "aaabbcccc";
// // string result = "";
// // int count = 1;

// // for (int i = 1; i < s.Length; i++)
// // {
// //     if (s[i] == s[i - 1]) count++;
// //     else
// //     {
// //         result += $"{s[i - 1]}{count}";
// //         count = 1;
// //     }
// // }
// // result += $"{s[^1]}{count}";
// // Console.WriteLine(result);
// // ```

// // 

// // ✅ 17. Most frequent character

// // ```csharp
// // string s = "success";
// // char maxChar = '\0';
// // int max = 0;

// // foreach (char c in s)
// // {
// //     int count = s.Count(x => x == c);
// //     if (count > max)
// //     {
// //         max = count;
// //         maxChar = c;
// //     }
// // }

// // Console.WriteLine(maxChar);
// // ```

// // 

// // ✅ 18. Remove duplicate characters

// // ```csharp
// // string s = "programming";
// // string result = "";

// // foreach (char c in s)
// //     if (!result.Contains(c))
// //         result += c;

// // Console.WriteLine(result);
// // ```

// // 

// // ✅ 19. Capitalize first letter of each word

// // ```csharp
// // string s = "hello world from csharp";
// // string[] words = s.Split(' ');

// // for (int i = 0; i < words.Length; i++)
// //     words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);

// // Console.WriteLine(String.Join(" ", words));
// // ```

// // 

// // ✅ 20. Reverse words, not characters

// // ```csharp
// // string s = "I love coding";
// // string[] w = s.Split(' ');
// // Array.Reverse(w);
// // Console.WriteLine(String.Join(" ", w));
// // ```

// // 

// // ✅ 21. Password validation

// // ```csharp
// // string p = "Test@123";

// // bool valid = p.Length >= 8 &&
// //              p.Any(char.IsUpper) &&
// //              p.Any(char.IsLower) &&
// //              p.Any(char.IsDigit) &&
// //              p.Any(ch => !char.IsLetterOrDigit(ch));

// // Console.WriteLine(valid ? "Valid" : "Invalid");
// // ```

// // 

// // ✅ 22. String immutability proof

// // ```csharp
// // string s = "Hello";
// // string t = s;

// // s += " World";

// // Console.WriteLine(ReferenceEquals(s, t)); // False → new memory used
// // ```

// // 

// // ✅ 23. Convert paragraph into sentences

// // ```csharp
// // string p = "I love C#. It is powerful. Very easy too!";
// // string[] sentences = p.Split('.', '!', '?');

// // foreach (string s in sentences)
// //     if (!string.IsNullOrWhiteSpace(s))
// //         Console.WriteLine(s.Trim());
// // ```

// // 

// // ✅ 24. Implement your own Contains()

// // ```csharp
// // bool MyContains(string s, string word)
// // {
// //     return s.IndexOf(word) >= 0;
// // }

// // Console.WriteLine(MyContains("Hello World", "World"));
// // ```

// // 

// // ✅ 25. Compare + vs StringBuilder performance

// // ```csharp
// // using System.Diagnostics;
// // using System.Text;

// // Stopwatch sw = new Stopwatch();

// // // Using +
// // string s = "";
// // sw.Start();
// // for (int i = 0; i < 10000; i++)
// //     s += i;
// // sw.Stop();
// // Console.WriteLine(sw.ElapsedMilliseconds);

// // sw.Reset();

// // // Using StringBuilder
// // StringBuilder sb = new StringBuilder();
// // sw.Start();
// // for (int i = 0; i < 10000; i++)
// //     sb.Append(i);
// // sw.Stop();
// // Console.WriteLine(sw.ElapsedMilliseconds);
// // ```

// // 

// // Real-World Task Answers

// // 

// // ✅ 26. Extract filename from file path

// // ```csharp
// // string path = @"C:\Users\Apar\document.pdf";
// // Console.WriteLine(Path.GetFileName(path));
// // ```

// // 

// // ✅ 27. Mask credit card number

// // ```csharp
// // string card = "1234567812345678";
// // Console.WriteLine(new string('*', card.Length - 4) + card[^4..]);
// // ```

// // 

// // ✅ 28. Validate Nepal phone number

// // ```csharp
// // string phone = "9841234567";
// // bool valid = phone.Length == 10 && phone.StartsWith("98") && phone.All(char.IsDigit);
// // Console.WriteLine(valid);
// // ```

// // 

// // ✅ 29. Remove digits from string

// // ```csharp
// // string s = "cs50rocks2025";
// // string result = new string(s.Where(ch => !char.IsDigit(ch)).ToArray());
// // Console.WriteLine(result);
// // ```

// // 

// // ✅ 30. Count occurrences of each word

// // ```csharp
// // string p = "Cis great and Cis powerful";
// // var words = p.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

// // var freq = words.GroupBy(x => x)
// //                 .ToDictionary(g => g.Key, g => g.Count());

// // foreach (var item in freq)
// //     Console.WriteLine($"{item.Key} = {item.Value}");
// // ```


// BEGINNER-LEVEL STRING EXERCISES

// 1️⃣ Print a string using escape sequences (`\n`, `\t`, `\"`, `\\`).
// 2️⃣ Declare a verbatim string (`@""`) representing a Windows file path.
// 3️⃣ Use `.Length` to count characters including spaces.
// 4️⃣ Check if a string is null, empty, or whitespace using `String.IsNullOrWhiteSpace()`.
// 5️⃣ Convert a string to uppercase using `.ToUpperInvariant()`.
// 6️⃣ Check if a string starts with `"Hello"` using `.StartsWith()`.
// 7️⃣ Check if a string ends with `".txt"` using `.EndsWith()`.
// 8️⃣ Print whether a sentence contains `"Nepal"` using `.Contains()`.
// 9️⃣ Find the index of the first comma using `.IndexOf()`.
// 🔟 Find the index of the last space using `.LastIndexOf()`.
// 1️⃣1️⃣ Extract `"World"` from `"Hello World"` using `.Substring()`.
// 1️⃣2️⃣ Convert a string to a `char[]` using `.ToCharArray()`.
// 1️⃣3️⃣ Split a CSV string `"A,B,C,D"` into items using `.Split()`.
// 1️⃣4️⃣ Join an array of strings into a sentence using `String.Join()`.
// 1️⃣5️⃣ Remove trailing spaces using `.TrimEnd()`.


// INTERMEDIATE-LEVEL STRING EXERCISES

// 1️⃣6️⃣ Replace `"blue"` with `"red"` in a paragraph using `.Replace()`.
// 1️⃣7️⃣ Remove the first five characters using `.Remove()`.
// 1️⃣8️⃣ Insert `"awesome "` after `"Cis "` using `.Insert()`.
// 1️⃣9️⃣ Compare two strings using `.Compare()` and display results.
// 2️⃣0️⃣ Perform case-insensitive comparison using `.Equals()` overload.
// 2️⃣1️⃣ Pad a string to 20 characters using `.PadRight()`.
// 2️⃣2️⃣ Pad a number with leading zeros using `.PadLeft()`.
// 2️⃣3️⃣ Check if a sentence contains only digits using `.All(char.IsDigit)`.
// 2️⃣4️⃣ Extract file extension using `.LastIndexOf('.')` and `.Substring()`.
// 2️⃣5️⃣ Count occurrences of `'e'` using `.IndexOf()` in a loop.
// 2️⃣6️⃣ Remove duplicate spaces using `.Split()` and `Join()`.
// 2️⃣7️⃣ Convert an integer to string using `.ToString()` and print its length.
// 2️⃣8️⃣ Use `String.Format()` to format:
// `"Name: John, Age: 22, Country: Nepal"`
// 2️⃣9️⃣ Use `$"{ }"` interpolation with calculations inside.
// 3️⃣0️⃣ Convert string into Title Case using `CultureInfo.TextInfo`.



// ADVANCED-LEVEL STRING EXERCISES

// 3️⃣1️⃣ Perform culture-specific comparison (e.g., Turkish `i`) using `StringComparer`.
// 3️⃣2️⃣ Compare strings using `StringComparison.Ordinal` vs `OrdinalIgnoreCase`.
// 3️⃣3️⃣ Normalize Unicode characters using `.Normalize()`.
// 3️⃣4️⃣ Find first vowel using `.IndexOfAny(new[] { 'a','e','i','o','u' })`.
// 3️⃣5️⃣ Remove forbidden characters from filenames using `.Replace()` in a loop.
// 3️⃣6️⃣ Extract numbers from a mixed string using `char.IsDigit()`.
// 3️⃣7️⃣ Generate a URL-friendly slug from a sentence.
// 3️⃣8️⃣ Demonstrate string interning using `String.Intern()`.
// 3️⃣9️⃣ Prove immutability by checking references before and after modification.
// 4️⃣0️⃣ Benchmark `.Replace()` vs `.StringBuilder.Replace()` for large texts.
// 4️⃣1️⃣ Validate email structure using `.Contains('@')` and `.IndexOf('.')`.
// 4️⃣2️⃣ Count words using `.Split(StringSplitOptions.RemoveEmptyEntries)`.
// 4️⃣3️⃣ Extract text between parentheses using `.IndexOf()` and `.Substring()`.
// 4️⃣4️⃣ Reverse words without reversing characters using `.Split()` + `Reverse()`.
// 4️⃣5️⃣ Parse a query string `"id=10&name=Apar"` into a dictionary.



// SUPER-ADVANCED / PROJECT-STYLE STRING TASKS

// 4️⃣6️⃣ Build your own `.Split()` method without using `.Split()`.
// 4️⃣7️⃣ Implement string compression and decompression algorithms.
// 4️⃣8️⃣ Detect palindrome sentences while ignoring punctuation/spaces.
// 4️⃣9️⃣ Create a custom password strength checker using multiple string methods.
// 5️⃣0️⃣ Build a mini log parser that extracts timestamps from log text.



// BONUS — Methods Covered

// ✔ `.Length`
// ✔ `.Substring()`
// ✔ `.Replace()`
// ✔ `.Insert()`
// ✔ `.Remove()`
// ✔ `.Split()` & `String.Join()`
// ✔ `.ToUpper()`, `.ToLower()`, `.ToUpperInvariant()`
// ✔ `.StartsWith()`, `.EndsWith()`, `.Contains()`
// ✔ `.IndexOf()`, `.LastIndexOf()`, `.IndexOfAny()`
// ✔ `.PadLeft()`, `.PadRight()`
// ✔ `.Trim()`, `.TrimStart()`, `.TrimEnd()`
// ✔ `.Equals()`, `Compare()`, `StringComparison`
// ✔ `.Clone()`, `.Intern()`
// ✔ `.Format()` & interpolation
// ✔ `.Normalize()`
// ✔ `.ToCharArray()`
// ✔ `StringBuilder` operations
// ✔ Null/empty checks
// ✔ Escape & verbatim strings


using System;
using System.Globalization;   // For TextInfo (Title Case)

class StringExercise
{
    public void StringMethodExample()
    {
        // -
        // RAW INPUT STRING
        // -
        string raw = "   apAr   bhaNdaRi ;  20 ;  Nepal ; apar.bhandari @gmail.com ;  +977-9841 234 567  ;   I love coding in Cand C#.   ";

        // 1️⃣ Trim() → Remove leading & trailing spaces
        string cleaned = raw.Trim();


        // -
        // SPLITTING THE INPUT INTO FIELDS
        // -
        // 2️⃣ Split(";") → break into parts
        string[] parts = cleaned.Split(';');

        // Trim each part to remove extra spaces
        for (int i = 0; i < parts.Length; i++)
            parts[i] = parts[i].Trim();


        // -
        // PART A — NAME FORMATTING (Title Case)
        // -
        string fullName = parts[0].ToLower(); // normalize case first

        // Convert to Title Case using CultureInfo + TextInfo
        TextInfo text = CultureInfo.CurrentCulture.TextInfo;
        fullName = text.ToTitleCase(fullName);  // e.g., "apar bhandari" → "Apar Bhandari"

        Console.WriteLine(fullName);


        // EXTRACT First Name & Last Name using Split()
        string[] nameParts = fullName
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string item in nameParts)
        {
            Console.WriteLine(item);
        }

        string firstName = nameParts[0];
        string lastName = nameParts.Length > 1 ? nameParts[1] : "";

        Console.WriteLine($"lastname {nameParts[1]}");


        // -
        // PART B — AGE & COUNTRY
        // -
        string age = parts[1];
        string country = parts[2];


        // -
        // PART C — EMAIL VALIDATION
        // -
        string email = parts[3].Replace(" ", ""); // Remove accidental internal spaces

        // 3️⃣ Contains() + EndsWith() for validation
        bool isValidEmail = email.Contains("@") && email.EndsWith(".com");

        // Extract email domain using IndexOf() + Substring()
        int atIndex = email.IndexOf("@");      // find '@'
        string emailDomain = email.Substring(atIndex + 1); // after '@'


        // -
        // PART D — PHONE NUMBER
        // -
        string phone = parts[4];

        // Remove spaces and dashes using Replace()
        phone = phone.Replace("-", "").Replace(" ", "");

        // Check StartsWith() for +977
        bool startsWith977 = phone.StartsWith("+977");

        // Remove “+” then combine back to standard format
        string digitsOnly = "";
        foreach (char c in phone)
        {
            if (char.IsDigit(c))  // Extract digits using char method
                digitsOnly += c;
        }

        // Re-append +977
        phone = "+977" + digitsOnly.Substring(3); // remove duplicate 977


        // -
        // PART E — FAVORITE TECH
        // -
        string favTech = parts[5];

        // Count how many times "C#" appears using IndexOf()
        int countCSharp = 0;
        int index = favTech.IndexOf("C#");

        while (index != -1)
        {
            countCSharp++;
            index = favTech.IndexOf("C#", index + 1);
        }

        // Replace("C#", "CSharp")
        string techReplaced = favTech.Replace("C#", "CSharp");


        // -
        // PART F — COUNT VOWELS USING ToCharArray()
        // -
        char[] charArray = cleaned.ToCharArray();

        int vowelCount = 0;
        foreach (char c in charArray)
        {
            char lower = char.ToLower(c);
            if ("aeiou".Contains(lower))
                vowelCount++;
        }


        // -
        // FINAL FORMATTING (String Interpolation)
        // -
        // PadLeft(3, '0') → Age as 3-digit
        string paddedAge = age.PadLeft(3, '0');

        string output =
$@"
===== CLEANED & FORMATTED DATA =====

Full Name      : {fullName}
First Name     : {firstName}
Last Name      : {lastName}

Age            : {paddedAge}
Country        : {country}

Email          : {email}
Valid Email?   : {isValidEmail}
Email Domain   : {emailDomain}

Phone          : {phone}
Starts with +977? : {startsWith977}

Favorite Tech (Original) : {favTech}
'C#' Count     : {countCSharp}
Modified Tech  : {techReplaced}

Vowel Count (entire input) : {vowelCount}

====================================
";

        Console.WriteLine(output);
    }
}
