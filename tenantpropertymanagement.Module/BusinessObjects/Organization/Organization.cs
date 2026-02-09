using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace Tenant_Property_Management.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Organization")]

    public class Organization : BaseObject
    {
        public Organization() { }

        public virtual string Name { get; set; }
        public virtual string Code { get; set; }

        public virtual OrganizationType Type { get; set; }
        public virtual bool IsActive { get; set; } = true;
    }

    public enum OrganizationType
    {
        Residential,
        Commercial,
        Mixed
    }
}
