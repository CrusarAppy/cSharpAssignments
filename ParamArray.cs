
// 1️⃣ What is a `params` Array in C#?

// A `params` array allows you to pass a variable number of arguments to a method —
// without having to explicitly create an array each time.

// It’s a special keyword used in method parameter lists like this:

// ```csharp
// public void Display(params int[] numbers)
// ```

// This means the method can accept:

// * zero,
// * one,
// * or many integers,
//   without requiring the caller to make an array.

//2️⃣ Why `params` Exists (Purpose)

// Normally, methods require you to pass a fixed number of parameters:

// ```csharp
// void Add(int a, int b)
// ```

// But what if you want to add any number of integers?

// Instead of writing:

// ```csharp
// Add(2, 3);
// Add(2, 3, 4);
// Add(2, 3, 4, 5);
// ```

// and making multiple overloaded versions,
// you can write just one using `params`.

// So the purpose of `params` is:

// > 🟢 To allow variable-length arguments of the same type to be passed to a single method.

// Syntax

// ```csharp
// access_modifier return_type MethodName(params dataType[] parameterName)
// ```

// Example:

// ```csharp
// public void PrintNumbers(params int[] nums)
// {
//     foreach (int n in nums)
//         Console.Write(n + " ");
// }
// ```

//4️⃣ Example: Using `params`

// ```csharp
// using System;

// class Program
// {
//     static void PrintNumbers(params int[] numbers)
//     {
//         Console.WriteLine("Numbers you entered:");
//         foreach (int num in numbers)
//             Console.Write(num + " ");
//         Console.WriteLine();
//     }

//     static void Main()
//     {
//         PrintNumbers();                // no arguments
//         PrintNumbers(10);              // one argument
//         PrintNumbers(1, 2, 3, 4, 5);   // multiple arguments
//     }
// }
// ```

//Output

// ```
// Numbers you entered:

// Numbers you entered:
// 10
// Numbers you entered:
// 1 2 3 4 5
// ```

// 5️⃣ How It Works Internally

// When you write:

// ```csharp
// PrintNumbers(1, 2, 3);
// ```

// The compiler automatically creates an integer array:

// ```csharp
// new int[] { 1, 2, 3 }
// ```

// and passes it to the method.

// So internally, it’s the same as:

// ```csharp
// PrintNumbers(new int[] { 1, 2, 3 });
// ```

// You just don’t have to write the `new int[]` part — that’s the beauty of `params`.

//6️⃣ Example: Passing String Values

// ```csharp
// using System;

// class Program
// {
//     static void ShowNames(params string[] names)
//     {
//         Console.WriteLine("Names entered:");
//         foreach (string name in names)
//             Console.WriteLine(name);
//     }

//     static void Main()
//     {
//         ShowNames("Apar", "Binod", "Sita", "Gita");
//     }
// }
// ```

// 🧾 Output:

// ```
// Names entered:
// Apar
// Binod
// Sita
// Gita
// ```

// ---

//  ⚙️ 7️⃣ Rules of `params`

// | Rule                                                    | Description                                   |
// | ------------------------------------------------------- | --------------------------------------------- |
// | ✅ Only one `params` per method                      | You can’t have two                            |
// | ✅ Must be the last parameter                        | `void Print(string msg, params int[] nums)` ✅ |
// | ✅ Can be any type                                   | `int`, `string`, `object`, even custom class  |
// | 🚫 You can’t have anything after `params` parameter | Compiler error                                |

// ---

// 8️⃣ `params` with Other Parameters

// You can combine it with fixed parameters:

// ```csharp
// static void PrintNames(string message, params string[] names)
// {
//     Console.WriteLine(message);
//     foreach (var n in names)
//         Console.WriteLine(n);
// }
// ```

// Call it like:

// ```csharp
// PrintNames("List of students:", "Apar", "Sita", "Gita");
// ```

// 🧾 Output:

// ```
// List of students:
// Apar
// Sita
// Gita
// ```

// ---

//  🔍 9️⃣ Difference Between Normal Array and `params` Array

// | Feature                  | Normal Array Parameter                        | `params` Array                  |
// | ------------------------ | --------------------------------------------- | ------------------------------- |
// | Declaration              | `void Print(int[] arr)`                       | `void Print(params int[] arr)`  |
// | Call Syntax              | Must create array: `Print(new int[] {1,2,3})` | Just list items: `Print(1,2,3)` |
// | Flexibility              | Fixed number of arguments                     | Variable number of arguments    |
// | Must caller build array? | Yes                                           | No                              |
// | Can pass existing array? | Yes                                           | Yes (same as normal)            |
// | Can be empty?            | No (null error if not created)                | Yes (0-length array allowed)    |

// ---

//  🧠 10️⃣ Another Example (Mixed Types)

// ```csharp
// static void PrintObjects(params object[] values)
// {
//     foreach (object v in values)
//         Console.WriteLine(v);
// }

// static void Main()
// {
//     PrintObjects(1, "Hello", 3.14, true);
// }
// ```

// 🧾 Output:

// ```
// 1
// Hello
// 3.14
// True
// ```

// ✅ Here `object[]` allows mixed data types.

// ---

// 11️⃣ When to Use `params`

// | Situation                         | Example                          |
// | --------------------------------- | -------------------------------- |
// | Variable arguments                | `Sum(1, 2, 3, 4, 5)`             |
// | Logging                           | `Log("Error", 404, "Not Found")` |
// | Displaying multiple strings       | `Print("a", "b", "c")`           |
// | Working with unknown count inputs | `Average(…)`, `Concat(…)`        |

// ---

//  ✅ 12️⃣ Summary

// | Feature         | Description                                              |
// | --------------- | -------------------------------------------------------- |
// | Keyword     | `params`                                                 |
// | Purpose     | Allows a method to take variable number of arguments |
// | Declaration | `void Method(params int[] arr)`                          |
// | Call        | `Method(1, 2, 3)`                                        |
// | Internally  | Compiler builds an array for you                         |
// | Rule        | Only one `params` parameter, must be last                |
// | Difference  | More flexible and user-friendly than normal arrays       |

// ---

// 💡 In Short

// > `params` arrays make your method flexible — so it can accept 0, 1, or many arguments
// > without needing multiple overloads or manually creating arrays.

// ---

