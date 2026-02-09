using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;

namespace Tenant_Property_Management.Module.BusinessObjects.Portfolio
{
    [DefaultClassOptions]
    [XafDisplayName("Portfolio Property")]
    [NavigationItem("Portfolio")]

    public class RealEstateProperty : TenantBaseObject
    {
        public RealEstateProperty() { }
        public  virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Zip { get; set; }
        public virtual bool IsActive { get; set; } = true;
        public virtual PropertyType PropertyType { get; set; }
    }

    public enum PropertyType
    {
        Residential,
        Commercial,
        Mixed
    }
}
