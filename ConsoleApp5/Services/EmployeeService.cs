namespace ConsoleApp5;

public class EmployeeService : IEmployeeService

{
    private static Employee[] Employees = new Employee[4]
    {
        new Employee(){name="John",surname="Smith",birthdate=new DateTime(1990,1,1),salary=1000},
        new Employee(){name="Travis",surname="Langstaff",birthdate=new DateTime(2001,8,25),salary=8000},
        new Employee(){name="Kit",surname="Maxwell",birthdate=new DateTime(1995,12,1),salary=3500},
        new Employee(){name="Sarah",surname="Evergreen",birthdate=new DateTime(1999,4,1),salary=1400}
    };
    public Employee[] GetEmployees(DateTime date1, DateTime date2)
    {
        Employee[] newEmployees = new Employee[0];
        int counter = default;
        foreach (var item in Employees)
        {
            if(item.birthdate>date1 && item.birthdate<date2 && item.salary>2000)
            {
                Array.Resize(ref newEmployees, newEmployees.Length + 1);
                newEmployees[^1] = item;
                counter++;
            }
        }
        if (counter == 0)
            throw new NotAvailableException("No employees found with the given criteria.");
        return newEmployees;
    }
}