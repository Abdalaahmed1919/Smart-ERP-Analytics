using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimDepartment
{
    public int DepartmentKey { get; set; }

    public int? DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public int? ParentDepartmentId { get; set; }

    public int? ManagerId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactEmployeeSnapshot> FactEmployeeSnapshots { get; set; } = new List<FactEmployeeSnapshot>();
}
