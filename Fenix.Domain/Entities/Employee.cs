using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.Users.ValueObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Employee : Shared.Entity<EmployeeId>
{
    private Employee(
        EmployeeId id,
        EmployeeFullName fullName,
        Description description,
        Photo employeePhoto,
        Link? link) : base(id)
    {
        FullName = fullName;
        Description = description;
        EmployeePhoto = employeePhoto;
        Link = link;
    }

    public EmployeeFullName FullName { get; private set; }
    public Description? Description { get; private set; }
    public Photo? EmployeePhoto { get; private set; }
    public Link? Link { get; private set; } 

    public static Result<Employee> Create(
        EmployeeId id,
        EmployeeFullName fullName,
        Description description,
        Photo employeePhoto,
        Link? link)
    {
        return new Employee(
            id,
            fullName,
            description,
            employeePhoto,
            link);
    }
}