# 🏢 Property Management Solution (PMS)

## 🎓 Advanced Software Architecture Case Study (Modular Monolith)

This repository contains a **Property Management System (PMS)** implemented as a **Modular Monolith** using modern architectural principles suitable for graduate-level study and enterprise systems.

The solution demonstrates:

- **🧠 Domain-Driven Design (DDD)** – Rich domain models that reflect real-world land and property concepts  
- **🧼 Clean Architecture** – Clear separation of concerns and dependency inversion  
- **📦 Modular Monolith** – Independently structured modules deployed as a single application  

---

## 📚 Table of Contents

- [Domain-Driven Design (DDD)](#domain-driven-design-ddd)
- [Clean Architecture](#clean-architecture)
- [Modular Monolith](#modular-monolith)
- [Persistence](#persistence)
- [Project Structure](#project-structure)
- [References](#references)

---

## 🧠 Domain-Driven Design (DDD)

**Definition:**  
Domain-Driven Design focuses on modeling software around the core business domain. The PMS models real-world land and property concepts such as registration, land use, lease periods, and plot details using rich domain objects.

**Concepts Applied:**
- **Entities** – Objects with identity and lifecycle  
- **Value Objects** – Immutable domain concepts (e.g., PlotSize, PropertyNumber)  
- **Aggregates** – Consistency boundaries (e.g., PropertyMaster)  
- **Domain Events** – Capturing meaningful business occurrences  
- **Factory Methods** – Enforcing invariants during creation  

### ✅ Example: Rich Domain Aggregate

**File:**  
`Modules/Modules.Estates.Domain/Entities/Registration/PropertyMaster.cs`

```csharp
public class PropertyMaster : BaseEntity
{
    private readonly List<DomainEvent> _domainEvents = new();

    [Key]
    public int PropertyMasterId { get; private set; }
    public PropertyNumber? PropertyNumber { get; private set; }
    public PlotSize? PlotSize { get; private set; }
    public LeasePeriod? Lease { get; private set; }

    [NotMapped]
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public static Result<PropertyMaster> Create(
        int propertyTypeId, int landUseId, string landUseInitial,
        int landUseTypeId, string landUseTypeInitial,
        int localityId, string localityInitial, int allocationTypeId)
    {
        // Business invariants and validation enforced here
    }

    public Result<PropertyMaster> UpdateLease(DateTime newCommencementDate, int newTerm)
    {
        // Domain behavior
    }
}
````

**Why this matters academically:**
This approach keeps business rules inside the domain model instead of spreading them across controllers or services, aligning with DDD’s principle of placing complexity “in the heart of the software.”

---

## 🧼 Clean Architecture

**Definition:**
Clean Architecture structures the system so that **business rules are independent of frameworks, databases, and UI**. Dependencies flow inward.

**Layer Responsibilities:**

* **Domain** – Business rules and invariants
* **Application** – Use cases and orchestration
* **Infrastructure** – SQL Server, EF Core, repositories
* **Presentation** – API endpoints

### ✅ Example: Application Use Case

**File:**
`Modules/Modules.Estates.Application/UseCases/Registration/Property/PropertyMasterService.cs`

```csharp
public class PropertyMasterService : IPropertyMasterService
{
    private readonly IUnitOfWork _unitOfWork;

    public async Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values)
    {
        var landUse = await _unitOfWork.LandUse.Get(values.LandUseId);
        if (landUse is null)
            return Error("Land Use Id provided does not exist");

        var property = PropertyMaster.Create(...);

        // Infrastructure concern hidden behind abstraction
        await _unitOfWork.PropertyMasters.Add(property);
        await _unitOfWork.SaveChangesAsync();

        return Success();
    }
}
```

**Why this matters academically:**
Use cases coordinate work but **do not contain business rules**, keeping the domain model pure and testable.

---

## 📦 Modular Monolith

**Definition:**
A Modular Monolith is a single deployable application internally divided into well-encapsulated modules. Each PMS module represents a distinct business capability.

**Benefits:**

* Strong boundaries without microservice complexity
* Clear ownership of domain logic
* Easier evolution toward microservices if required

### ✅ PMS Module Example

```
Modules/
└── Estates/
    ├── Domain/
    ├── Application/
    ├── Infrastructure/
    └── Presentation/
```

Each module:

* Owns its **domain model**
* Exposes functionality only through its **application layer**
* Is accessed via **module-specific API controllers**

---

## 🗄️ Persistence

**Definition:**
ersistence concerns are isolated in the **Infrastructure layer**, ensuring the domain and application layers remain database-agnostic.

**Key Principles:**

* Domain entities are **not coupled to EF Core**
* Repositories and Unit of Work abstract the underlying database
* Infrastructure depends on Application, not vice versa

### ✅ Example: Infrastructure Dependency

```csharp
public class PropertyMasterRepository : IPropertyMasterRepository
{
    private readonly EstatesDbContext _context;

    public PropertyMasterRepository(EstatesDbContext context)
    {
        _context = context;
    }

    public async Task Add(PropertyMaster property)
    {
        await _context.PropertyMasters.AddAsync(property);
    }
}
```

---

## 🗂️ Project Structure

```
src/
├── Modules/
│   └── Estates/
│       ├── Domain/
│       ├── Application/
│       ├── Infrastructure/    # EF Core
│       └── Presentation/      # API Controllers
|   └── Common/                # Cross-cutting abstractions
└── Api/                        # Application entry point
```

---

## 📖 References

* Eric Evans – *Domain-Driven Design*
* Robert C. Martin – *Clean Architecture*
* Vaughn Vernon – *Implementing Domain-Driven Design*
* Microsoft – *Architecting Modular Monoliths in .NET*

---

## 🎓 Academic Relevance

This PMS demonstrates how **DDD**, **Clean Architecture**, and **Modular Monolith** principles can be applied to a real-world government-style land/property management domain, balancing **theoretical rigor** with **practical implementation**.

---

## 📄 License

Educational use. Commercial usage subject to approval.
