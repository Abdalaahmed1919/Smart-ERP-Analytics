using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimEmployee
{
    public int EmployeeKey { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public bool? IsActive { get; set; }

    public int? ManagerId { get; set; }

    public int? CoachId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactEmployeeSnapshot> FactEmployeeSnapshots { get; set; } = new List<FactEmployeeSnapshot>();
}
