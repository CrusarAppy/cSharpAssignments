class ExamQuestionFirstTerm2082
{
    public void Question()
    {
        Employee[] employees = new Employee[3];

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new Employee();

            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Name: ");
            employees[i].Name = Console.ReadLine();

            Console.Write("Annual Salary: ");
            employees[i].Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Years of Service: ");
            employees[i].Years = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n--- Annual Bonus Report ---");

        foreach (var emp in employees)
        {
            double bonus = emp.GetBonusAmount();
            double total = emp.Salary + bonus;

            Console.WriteLine($"\nEmployee: {emp.Name}");
            Console.WriteLine($"Salary: {emp.Salary:C}");
            Console.WriteLine($"Years of Service: {emp.Years}");
            Console.WriteLine($"Bonus ({emp.GetBonusPercentage() * 100}%): {bonus:C}");
            Console.WriteLine($"Total with Bonus: {total:C}");
        }
    }
}