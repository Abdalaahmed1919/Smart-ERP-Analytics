using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class FactEmployeeSnapshot
{
    public DateOnly SnapshotDate { get; set; }

    public int EmployeeKey { get; set; }

    public int? DepartmentKey { get; set; }

    public int? JobKey { get; set; }

    public int? CompanyId { get; set; }

    public bool? IsActive { get; set; }

    public int? Headcount { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual DimDepartment? DepartmentKeyNavigation { get; set; }

    public virtual DimEmployee EmployeeKeyNavigation { get; set; } = null!;

    public virtual DimJob? JobKeyNavigation { get; set; }

    public virtual DimDate SnapshotDateNavigation { get; set; } = null!;
}
