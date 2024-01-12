using System.Security.Cryptography.X509Certificates;

namespace firstconsoleapp;
class Employee
{
    public int EmpID
    {
        get;
        set;
    }
    public string? EmpName
    {
        get;
        set;
    }
    public DateTime DOJ
    {
        get;
        set;
    }
    public int Salary
    {
        get;
        set;
    }
    public void AcceptDetails()
    {
        System.Console.WriteLine("Enter your name: ");
        EmpName=Console.ReadLine();
        System.Console.WriteLine("Enter your Employee ID: ");
        EmpID=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your DOJ: ");
        DOJ=Convert.ToDateTime(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        System.Console.WriteLine("Employee Name: "+EmpName);
        System.Console.WriteLine("Employee ID: "+EmpID);
        System.Console.WriteLine("DOJ: "+DOJ);
        System.Console.WriteLine("Salary: "+Salary);
    }
    public virtual int CalculateSalary()
    {
        System.Console.WriteLine("Enter your salary: ");
        Salary=Convert.ToInt32(Console.ReadLine());
        return Salary;
    }
}

class Permanent: Employee, IEmployee
{
    public int BasicPay
    {
        get;
        set;
    }
    public int HRA
    {
        get;
        set;
    }
    public int DA
    {
        get;
        set;
    }
    public int PF
    {
        get;
        set;
    }

    public void GetDetails()
    {
        System.Console.WriteLine("Enter Basic Pay: ");
        BasicPay=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter HRA: ");
        HRA=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter DA: ");
        DA=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter PF: ");
        PF=Convert.ToInt32(Console.ReadLine());
    }
    public void ShowDetails()
    {
        System.Console.WriteLine("Basic Pay: "+BasicPay);
        System.Console.WriteLine("HRA: "+HRA);
        System.Console.WriteLine("DA: "+DA);
        System.Console.WriteLine("PF: "+PF);
    }

    public override int CalculateSalary()
    {
        Salary=base.CalculateSalary()+BasicPay+HRA+DA-PF;
        return Salary;
    }
}

class Trainee: Employee, IEmployee
{
    public int Bonus
    {
        get;
        set;
    }

    public string? ProjectName
    {
        get;
        set;
    }

    public void GetTraineeDetails()
    {
        System.Console.WriteLine("Enter the bonus: ");
        Bonus=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Project Name: ");
        ProjectName=Console.ReadLine();
    }

    public void ShowTraineeDetails()
    {
        System.Console.WriteLine("Trainee Bonus: "+Bonus);
        System.Console.WriteLine("Trainee Project Name: "+ProjectName);
    }

    public override int CalculateSalary()
    {
        if(ProjectName=="Banking")
        {
            int bonus=(5/100)*base.CalculateSalary();
            Salary=base.CalculateSalary()+bonus;
        }
        else if(ProjectName=="Insurance")
        {
            int bonus=(10/100)*base.CalculateSalary();
            Salary=base.CalculateSalary()+bonus;
        }
        return Salary;
    }
}