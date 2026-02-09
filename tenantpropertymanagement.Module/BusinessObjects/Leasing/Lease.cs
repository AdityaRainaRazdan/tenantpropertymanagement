using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;
using TenantPropertyManagement.Module.BusinessObjects.Portfolio;

namespace TenantPropertyManagement.Module.BusinessObjects.Leasing
{
    [DefaultClassOptions]
    [XafDisplayName("Leases")]
    [NavigationItem("Leasing")]
    public class Lease : TenantBaseObject
    {
        public virtual LeaseTenant Tenant { get; set; }
        public virtual Unit Unit { get; set; }

        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }

        public virtual decimal Rent { get; set; }
        public virtual LeaseStatus Status { get; set; }
    }

    public enum LeaseStatus
    {
        Draft,
        Active,
        EndingSoon,
        Terminated
    }
}
