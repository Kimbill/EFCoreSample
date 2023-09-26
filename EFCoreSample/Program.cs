// See https://aka.ms/new-console-template for more information
using EFCoreSample;
using EFCoreSample.Models;

Console.WriteLine("Week 6 - EntityFrameworkCore");

Console.WriteLine("Enter your First Name");
var fn = Console.ReadLine();

Console.WriteLine("Enter your Last Name");
var ln = Console.ReadLine();

Console.WriteLine("Enter your Email");
var email = Console.ReadLine();

try
{
    if (fn == null || ln == null || email == null)
        throw new Exception("You inputed a null entry");
    var student = new Student
    {
        Id = Guid.NewGuid().ToString(),
        FirstName = fn,
        LastName = ln,
        Email = email
    };

    if (AddNewUser(student))
    {
        Console.WriteLine("User Successfully Added");
    }

    else
    {
        Console.WriteLine("Operation Unsuccessful");
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

bool AddNewUser(Student entity)
{
    if(entity == null)
        throw new ArgumentNullException("model");
    EFSampleDbContext context = new EFSampleDbContext();
    context.Add(entity);
    var saveRes = context.SaveChanges();
    if (saveRes > 0)
    return true;

    return false;
}


