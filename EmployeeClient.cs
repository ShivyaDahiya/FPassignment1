namespace firstconsoleapp;

class EmployeeClient
{
    public static void Main()
    {
        Permanent p=new Permanent();
        Trainee t=new Trainee();
        p.AcceptDetails();
        p.CalculateSalary();
        p.DisplayDetails();
    }
}