using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using Tenant_Property_Management.Module.BusinessObjects.Base;

namespace TenantPropertyManagement.Module.BusinessObjects.Leasing
{
    [DefaultClassOptions]
    [Browsable(true)]
    [NavigationItem("Leasing")]

    public class LeaseTenant : TenantBaseObject
    {
        public virtual string FullName { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual LeaseTenantStatus Status { get; set; }
    }

    public enum LeaseTenantStatus
    {
        Applicant,
        Active,
        Former
    }
}
