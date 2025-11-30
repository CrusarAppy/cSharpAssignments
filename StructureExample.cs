
// 📘 STRUCTURES IN C— DETAILED NOTES

// 1.1 Introduction to Structure, Its Features, and Its Necessities

// #Introduction

// A structure (struct) in Cis a user-defined data type that allows you to group different related data items under a single unit.
// It is similar to a class but is primarily used to create lightweight objects and represent small groups of related data.

// Structures are value types, meaning the data is stored directly in the stack, not on the heap.
// They are useful when dealing with small pieces of data that do not require object-oriented features like inheritance.

// #Features of Structures

// 1. Value Type

//    * Stored in stack memory.
//    * Fast access and less memory overhead.

// 2. Cannot Support Inheritance

//    * Structures cannot inherit from another struct or class.
//    * However, they *can implement interfaces*.

// 3. Contain Data Members and Methods

//    * Structures can contain fields, methods, properties, constructors, and indexers.

// 4. No Parameterless Constructor Allowed

//    * You cannot define a default constructor, but you can define parameterized ones.

// 5. Efficient for Small Data

//    * Best suited for representing small units of data (e.g., a point, rectangle, record, etc.)

// 6. Immutability Recommended

//    * Often used to create immutable data types.

// 7. Copying Behavior

//    * Assignment copies the entire value (deep copy), not a reference copy.

// #Necessity of Structures

// Structures are necessary when:

// ✔ 1. You need lightweight objects

// Example: coordinates of a point, RGB color values, date values, etc.

// ✔ 2. You want to avoid heap allocation

// Structs are allocated on the stack, making them faster to access and destroy.

// ✔ 3. Data should be copied, not referenced

// Useful in mathematical or scientific calculations where the original data must remain unchanged.

// ✔ 4. No need for OOP features like inheritance and polymorphism

// ✔ 5. Useful for performance-sensitive applications

// Example: game development, graphics programming, and embedded systems.


// 1.2 Demonstration of Defining a Structure and Its Usage

// A structure is defined using the struct keyword.

// #Syntax of a Structure

// ```csharp
// public struct Student
// {
//     public int Id;
//     public string Name;
//     public int Age;

//     // Parameterized Constructor
//     public Student(int id, string name, int age)
//     {
//         Id = id;
//         Name = name;
//         Age = age;
//     }

//     // Method inside structure
//     public void Display()
//     {
//         Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
//     }
// }
// ```



// #Using the Structure

// ```csharp
// class Program
// {
//     static void Main()
//     {
//         // Creating a structure object
//         Student s1 = new Student(1, "Apar", 20);

//         // Accessing members
//         Console.WriteLine(s1.Name);

//         // Calling method
//         s1.Display();
//     }
// }
// ```



// 1.3 Compare and Evaluate Class vs Structure (with Demonstration)

// Below is a detailed comparison:

// | Feature                  | Class                       | Structure                               |
// |  |  |  |
// | Type                 | Reference Type              | Value Type                              |
// | Memory               | Stored on Heap          | Stored on Stack                     |
// | Performance          | Slightly slower             | Faster for small objects                |
// | Supports Inheritance | Yes                         | No                                      |
// | Default Constructor  | Allowed                     | Not allowed                             |
// | Use Case             | Large objects, OOP concepts | Small data, simple objects              |
// | Copying              | Copies reference            | Copies actual value (deep copy)         |
// | Null Assignment      | Can be null                 | Cannot be null (except nullable struct) |



// #Explanation with Example

// Class Example

// ```csharp
// class Person
// {
//     public string Name;
// }
// ```

// Structure Example

// ```csharp
// struct Point
// {
//     public int X, Y;
// }
// ```


// #Demonstration of Value Type vs Reference Type

// Structure Behavior (Value Type)

// ```csharp
// Point p1 = new Point();
// p1.X = 10;

// Point p2 = p1;  // Copies value
// p2.X = 20;

// Console.WriteLine(p1.X); // Output: 10 (unchanged)
// ```

// ✔ Changes in `p2` do not affect `p1`.


// Class Behavior (Reference Type)

// ```csharp
// Person a = new Person();
// a.Name = "Apar";

// Person b = a; // Copies reference
// b.Name = "Bhandari";

// Console.WriteLine(a.Name); // Output: Bhandari
// ```

// ✔ Changing `b` also changes `a` because both refer to the same object.

// Conclusion

// * Structures are best when dealing with small, simple, memory-efficient data containers.
// * Classes are best when building rich, object-oriented systems that require features like inheritance, polymorphism, and complex behaviors.
// * Both have their own importance based on performance and design needs.

// Level-wise practice questions on Structures in C#, 
// starting from 
// Beginner → Intermediate → Advanced, including coding, theory, comparison,
// and real-world use cases.

// # 🌱 BEGINNER LEVEL QUESTIONS (Basic Understanding)

//  1. Theory Basics

//     1. Define a structure. Why do we use structures in C#?
//     2. List any five features of a structure.
//     3. Write the syntax of a structure in C#.
//     4. Mention the differences between class and structure.
//     5. What do you mean by “structures are value types”?

//  2. Identify Output / True or False

//     6. Structures are stored on the heap. (True/False)
//     7. Structures support inheritance. (True/False)
//     8. Structures can contain methods. (True/False)

//  3. Simple Coding

//     9. Create a structure named Book with fields: Title, Author, Price.
//     Create an object and print the book details.
//     10. Create a structure Point with fields X and Y.
//         Initialize the structure and display coordinate values.

// 🌿 INTERMEDIATE LEVEL QUESTIONS (Application)

//  4. Constructor-Based Questions

//     11. Create a structure Student with fields (Id, Name, Age) and a parameterized constructor.
//         Create two student objects and print the details.
//     12. Create a structure Car with a constructor and a method to calculate the mileage.

//  5. Value Type Behavior

//     13. Write a program to show that structures follow value-type copying (changing one copy does not affect another).
//     14. Show that classes use reference-type behavior while structures use value-type behavior and compare outputs.

//  6. Methods in Structures

//     15. Create a structure Rectangle with Width and Height.
//         Add a method to calculate Area & Perimeter.
//     16. Create a structure Temperature that converts °C to °F using a method.

//  7. Real-Time Examples

//     17. Write a structure Employee with fields (Id, Name, Salary) and a method to increase salary by a given percentage.
//     18. Define a structure Movie with Name, Genre, Rating. Add a method that prints a formatted summary.

// 🌳 ADVANCED LEVEL QUESTIONS (Problem Solving & Design)

//  8. Nested Structures

//     19. Create a structure Address (street, city, country).
//         Create another structure Person containing the Address structure.
//         Display complete details.

//  9. Structure vs Class Evaluation
//     20. Write a program to compare memory behavior of structure and class using multiple objects.
//         Explain which is faster and why.
//     21. When should a structure be preferred over a class? Give 5 real-world examples.

//     10. Passing Structures to Methods

//     22. Create a structure Product.
//         Write a method that takes the structure as a parameter and prints its fields.
//     23. Demonstrate passing a structure by reference using `ref`.

//  11. Array of Structures

//     24. Create an array of 5 Students using structures.
//         Take input for each student and display results.
//     25. Create an array of Point structures and calculate the distance of each point from (0,0).

//  12. Structure With Properties

//     26. Create a structure BankAccount with properties (AccountNumber, HolderName, Balance).
//     Add Deposit() and Withdraw() methods.

//  13. Read-Only Structures

//     27. Create a readonly struct Vector with X and Y.
//     Calculate vector magnitude.

//  14. Real-Life Mini Projects

//     28. Create a structure Laptop with fields (Brand, RAM, Price) and create a filter function to display laptops under 50,000.
//     29. Create a structure GPSCoordinates with Latitude and Longitude.
//         Add a method to compute the distance between two GPS points (formula provided).
//     30. Create a structure Transaction with Date, Amount, Description.
//     Create a program to list all transactions in a formatted table.

// ⭐ BONUS QUESTIONS (Very Advanced / Interview)

// 31. Why is a structure recommended for small immutable data? Explain with examples.
// 32. Can a structure contain a destructor? Explain why/why not.
// 33. Can a structure contain events? Provide an example.
// 34. When should you NEVER use a structure? Explain with scenarios.
// 35. Compare boxing/unboxing behavior with structures and classes.

