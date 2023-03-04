//dzień 6 zadanie domowe

using ChalangeAPP;
using System;

Employee employee1 = new Employee("Krzyś", 35, "Noga2");
Employee employee2 = new Employee("Adaś", 22, "Pionek");
Employee employee3 = new Employee("Ilona", 42, "Serduszko");

employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(10);
employee1.AddScore(4);

employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(2);

employee3.AddScore(6);
employee3.AddScore(5);
employee3.AddScore(40);
employee3.AddScore(9);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
}
;

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        employeeWithMaxResult = Employee;
    }
}
//analiza, wynik

if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine("osobą o najlepszym wyniku jest: " + employee1.Name + " _ " + employee1.Surname + "_" + employee1.Age + "_" + "lat; " + "a jego wynik to: " + employee1.Result);

}
else
{
    if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
    {
        Console.WriteLine("osobą o najlepszym wyniku jest: " + employee2.Name + " _ " + employee2.Surname + "_" + employee2.Age + "_" + "lat; " + "a jego wynik to: " + employee2.Result);
    }

    else
    {
        Console.WriteLine("osobą o najlepszym wyniku jest: " + employee3.Name + " _ " + employee3.Surname + "_" + employee3.Age + "_" + "lata; " + "a jej wynik to: " + employee3.Result);
    }
}