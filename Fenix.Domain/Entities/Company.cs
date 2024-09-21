using CSharpFunctionalExtensions;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Company : Shared.Entity<CompanyId>
{
    private Company(
        CompanyId id,
        Name name,
        Industry industry,
        Phone companyPhone,
        IEnumerable<Social> socialMedia,
        IEnumerable<Category> productCategories,
        IEnumerable<Category> serviceCategories,
        IEnumerable<Category> employeeCategories) : base(id)
    {
        Name = name;
        Industry = industry;
        CompanyPhone = companyPhone;
        _socialMedias = socialMedia.ToList();
        _productCategories = productCategories.ToList();
        _serviceCategories = serviceCategories.ToList();
        _employeeCategories = employeeCategories.ToList();
    }

    public Name Name { get; private set; }
    public Industry Industry { get; private set; }
    public Phone CompanyPhone { get; private set; }

    public IReadOnlyList<Social> SocialMedias => _socialMedias;
    private readonly List<Social> _socialMedias = [];
    
    public IReadOnlyList<Category> ProductCategories => _productCategories;
    private readonly List<Category> _productCategories = [];
    
    public IReadOnlyList<Category> ServiceCategories => _serviceCategories;
    private readonly List<Category> _serviceCategories = [];
    
    public IReadOnlyList<Category> EmployeeCategories => _employeeCategories;
    private readonly List<Category> _employeeCategories = [];

    public static Result<Company, Error> Create(
        CompanyId id,
        Name name,
        Industry industry,
        Phone companyPhone,
        IEnumerable<Social> socialMedia,
        IEnumerable<Category> productCategories,
        IEnumerable<Category> serviceCategories,
        IEnumerable<Category> employeeCategories)
    {
        return new Company(
            id,
            name,
            industry,
            companyPhone,
            socialMedia,
            productCategories,
            serviceCategories,
            employeeCategories);
    }
}