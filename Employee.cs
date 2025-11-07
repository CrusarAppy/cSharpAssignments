using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Years { get; set; }

    // Method to calculate bonus percentage
    public double GetBonusPercentage()
    {
        if (Years >= 1 && Years <= 2)
            return 0.05;
        else if (Years >= 3 && Years <= 5)
            return 0.08;
        else if (Years >= 6 && Years <= 10)
            return 0.12;
        else
            return 0.15;
    }

    // Method to calculate bonus amount
    public double GetBonusAmount()
    {
        return Salary * GetBonusPercentage();
    }
}