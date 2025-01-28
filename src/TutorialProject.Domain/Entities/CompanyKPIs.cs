using System;

namespace EntityPlayground.src.TutorialProject.Domain.Entities;

public class CompanyKPIs
{
    private CompanyKPIs()
    {
    }
    public CompanyKPIs(int companyId, int kPIId, decimal value, DateTime measurementDate)
    {
        CompanyId = companyId;
        KPIId = kPIId;
        Value = value;
        MeasurementDate = measurementDate;
    }

    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int KPIId { get; set; }
    public decimal Value { get; set; }
    public DateTime MeasurementDate { get; set; }
    public string? Notes { get; set; }

    public Companies? Companies { get; set; }
    public KPIs? KPIs { get; set; }
    // Bir CompanyKPI yalnızca bir şirkete ait olabilir.
}
