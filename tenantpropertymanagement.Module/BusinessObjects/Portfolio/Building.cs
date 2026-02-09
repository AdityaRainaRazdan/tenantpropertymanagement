using DevExpress.DataAccess.UserConfiguration;
using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;
using Tenant_Property_Management.Module.BusinessObjects.Portfolio;

namespace TenantPropertyManagement.Module.BusinessObjects.Portfolio
{
    [DefaultClassOptions]
    [NavigationItem("Portfolio")]
    public class Building : TenantBaseObject
    {
        public virtual RealEstateProperty Property { get; set; }
        public virtual string Name { get; set; }
        public virtual int Floors { get; set; }
    }
}
