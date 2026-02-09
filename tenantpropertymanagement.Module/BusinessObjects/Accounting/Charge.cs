using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;
using TenantPropertyManagement.Module.BusinessObjects.Leasing;

namespace TenantPropertyManagement.Module.BusinessObjects.Accounting
{
    [DefaultClassOptions]
    [NavigationItem("Accounting")]
    public class Charge : TenantBaseObject
    {
        public virtual Lease Lease { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual ChargeStatus Status { get; set; }
    }

    public enum ChargeStatus
    {
        Due,
        Paid,
        Partial,
        Voided
    }
}
