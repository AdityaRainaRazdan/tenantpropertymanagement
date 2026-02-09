using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;
using TenantPropertyManagement.Module.BusinessObjects.Leasing;

namespace TenantPropertyManagement.Module.BusinessObjects.Accounting
{
    [DefaultClassOptions]
    [NavigationItem("Accounting")]

    public class Payment : TenantBaseObject
    {
        public virtual Lease Lease { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual string ReferenceNo { get; set; }
    }
}
