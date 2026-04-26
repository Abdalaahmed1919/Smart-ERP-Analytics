using System;
using System.Collections.Generic;

namespace Smart_ERP_System.Models;

public partial class DimJob
{
    public int JobKey { get; set; }

    public int? JobId { get; set; }

    public string? JobName { get; set; }

    public int? DepartmentId { get; set; }

    public int? CompanyId { get; set; }

    public int? ContractTypeId { get; set; }

    public int? NoOfRecruitment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DwhLoadedAt { get; set; }

    public virtual ICollection<FactEmployeeSnapshot> FactEmployeeSnapshots { get; set; } = new List<FactEmployeeSnapshot>();
}
