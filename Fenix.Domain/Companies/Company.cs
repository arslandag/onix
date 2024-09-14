using CSharpFunctionalExtensions;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Companies;

public class Company : Shared.Entity<CompanyId>
{
    private Company(
        CompanyId id,
        Name name,
        Industry industry,
        Currency currency,
        Phone companyPhone,
        Description description,
        Social telegram,
        Social whatsApp,
        Social instagram,
        Social youTube,
        IEnumerable<DataSolution> dataSolutions,
        IEnumerable<Photo> companyPhotоs,
        IEnumerable<Location> locations,
        IEnumerable<Catalog> catalogs,
        IEnumerable<Service> services,
        IEnumerable<Menu> menus,
        IEnumerable<TimeTable> schedules,
        IEnumerable<Employee> employees) : base(id)
    {
        Name = name;
        Industry = industry;
        Currency = currency;
        CompanyPhone = companyPhone;
        Description = description;
        Telegram = telegram;
        WhatsApp = whatsApp;
        Instagram = instagram;
        YouTube = youTube;
        _dataSolutions = dataSolutions.ToList();
        _companyPhotos = companyPhotоs.ToList();
        _locations = locations.ToList();
        _catalogs = catalogs.ToList();
        _services = services.ToList();
        _menus = menus.ToList();
        _schedules = schedules.ToList();
        _employees = employees.ToList();
    }

    public Name Name { get; private set; }
    public Industry Industry { get; private set; }
    public Currency Currency { get; private set; }
    public Phone CompanyPhone { get; private set; }
    public Description Description { get; private set; }
    public Social Telegram { get; private set; }
    public Social WhatsApp { get; private set; }
    public Social Instagram { get; private set; }
    public Social YouTube { get; private set; }

    public IReadOnlyList<DataSolution> DataSolutions => _dataSolutions;
    private readonly List<DataSolution> _dataSolutions = [];  

    public IReadOnlyList<Photo> CompanyPhotos => _companyPhotos ;
    private readonly List<Photo> _companyPhotos = [];
    
    public IReadOnlyList<Location> Locations => _locations ;
    private readonly List<Location> _locations = [];
    
    public IReadOnlyList<Catalog> Catalogs => _catalogs;
    private readonly List<Catalog> _catalogs = [];
    
    public IReadOnlyList<Service> Services => _services;
    private readonly List<Service> _services = [];
    
    public IReadOnlyList<Menu> Menus => _menus;
    private readonly List<Menu> _menus = [];
    
    public IReadOnlyList<TimeTable> Schedules => _schedules;
    private readonly List<TimeTable> _schedules = [];
    
    public IReadOnlyList<Employee> Employees => _employees;
    private readonly List<Employee> _employees = [];

    public static Result<Company, Error> Create(
        CompanyId id,
        Name name,
        Industry industry,
        Currency currency,
        Phone companyPhone,
        Description description,
        Social telegram,
        Social whatsApp,
        Social instagram,
        Social youTube,
        IEnumerable<DataSolution> dataSolutions,
        IEnumerable<Photo> companyPhotоs,
        IEnumerable<Location> locations,
        IEnumerable<Catalog> catalogs,
        IEnumerable<Service> services,
        IEnumerable<Menu> menus,
        IEnumerable<TimeTable> schedules,
        IEnumerable<Employee> employees)
    {
        return new Company(
            id,
            name,
            industry,
            currency,
            companyPhone,
            description,
            telegram,
            whatsApp,
            instagram,
            youTube,
            dataSolutions,
            companyPhotоs,
            locations,
            catalogs,
            services,
            menus,
            schedules,
            employees);
    }
}