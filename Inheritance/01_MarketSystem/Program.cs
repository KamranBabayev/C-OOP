
namespace MarketSystem;

internal class Program
{
    static void Main(string[] args)
    {

        //         🛒 Tapşırıq: Market Employee System

        //Bir market sistemi qurmalısan.

        //### 1. Employee — Base class

        //Aşağıdakı məlumatlar olsun:

        //        *Name
        //        * Surname
        //        * Age
        //        * Salary

        //Constructor vasitəsilə məlumatları qəbul et.

        //Aşağıdakı metod olsun:

        //        text
        //ShowInfo()


        //İşçinin bütün məlumatlarını göstərsin.

        //---

        //### 2. Manager — Employee-dən inherit etsin

        //Əlavə property:

        //        *Department
        //        * Bonus

        //ShowInfo() metodunu *override* et.

        //Manager-in məlumatlarını göstərsin və:

        //text
        //Total Salary = Salary + Bonus


        //hesablansın.

        //---

        //### 3. Cashier — Employee-dən inherit etsin

        //Əlavə property:

        //* CashRegisterNumber
        //* WorkingHours

        //ShowInfo() override olunsun.

        //Əgər WorkingHours > 8 olarsa:

        //text
        //Overtime: Yes


        //əks halda:

        //text
        //Overtime: No


        //göstərsin.

        //---

        //### 4. Developer — Employee-dən inherit etsin

        //Əlavə property:

        //* ProgrammingLanguage
        //* ExperienceYears

        //ShowInfo() override olunsun.

        //Əgər təcrübəsi 3 ildən çoxdursa:

        //text
        //Senior Developer


        //əks halda:

        //text
        //Junior/Mid Developer


        //göstərsin.

        //---

        //## 🔥 Əsas çətin hissə

        //Main() daxilində* Employee tipində array/list* yarat:

        //csharp
        //List<Employee> employees = new List<Employee>();


        //    və içərisinə:

        //* 1 Manager
        //* 2 Cashier
        //* 1 Developer

        //əlavə et.

        //Sonra * yalnız bir foreach* istifadə edərək:

        //csharp
        //foreach (Employee employee in employees)
        //{
        //    employee.ShowInfo();
        //}


        //hamısının məlumatlarını göstər.

        //Burada əsas məqsəd odur ki:

        //> Employee tipində olan dəyişən əslində Manager, Cashier və ya Developer obyekti saxlaya bilsin.

        //Bu artıq* polymorphism + inheritance* birlikdə işlətməkdir.

        //### ⭐ Bonus challenge

        //Employee class-da:

        //text
        //CalculateSalary()


        //metodu yarat.

        //Sonra hər child class öz maaşını fərqli hesablamağa məcbur olsun:

        //* Manager → Salary + Bonus
        //* Cashier → Salary + overtime payment
        //*Developer → Salary + experience bonus

        List<Employee> employeess = new List<Employee>();
        employeess.Add(new Manager("Kamran", "babayev", 20, 750.5, "It departmen", 150.00));
        Console.WriteLine();
        employeess.Add(new Cahsier("kenan", "abdulezimov", 21, 800.00, "104576", 7));
        Console.WriteLine();
        employeess.Add(new Cahsier("bayram", "Huseynov", 20, 600.00, "124576", 8));
        Console.WriteLine();
        employeess.Add(new Developer("Ilkin", "Qocayev", 20, 1000.40, "python", 4));

        foreach (Employee employee in employeess)
        {

            employee.ShowInfo();
            Console.WriteLine($"Calculated Salary: {employee.CalculateSalary()}");

            Console.WriteLine("----------------------------");
        }
    }
}