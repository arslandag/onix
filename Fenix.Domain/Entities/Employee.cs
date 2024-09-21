using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Employee : Shared.Entity<EmployeeId>
{
    private Employee(
        EmployeeId id,
        FullName fullName,
        Description description,
        Photo employeePhoto,
        Category category) : base(id)
    {
        FullName = fullName;
        Description = description;
        EmployeePhoto = employeePhoto;
        Category = category;
    }

    public FullName FullName { get; private set; }
    public Description Description { get; private set; }
    public Photo EmployeePhoto { get; private set; }
    public Category Category { get; private set; }

    public static Result<Employee> Create(
        EmployeeId id,
        FullName fullName,
        Description description,
        Photo employeePhoto,
        Category category)
    {
        return new Employee(
            id,
            fullName,
            description,
            employeePhoto,
            category);
    }
}