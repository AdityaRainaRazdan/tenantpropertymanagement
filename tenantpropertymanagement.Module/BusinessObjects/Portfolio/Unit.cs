using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;

namespace TenantPropertyManagement.Module.BusinessObjects.Portfolio
{
    [DefaultClassOptions]
    [NavigationItem("Portfolio")]
    
    public class Unit : TenantBaseObject
    {
        public virtual Building Building { get; set; }
        public virtual string UnitNumber { get; set; }
        public virtual int Bedrooms { get; set; }
        public virtual int Bathrooms { get; set; }
        public virtual decimal MarketRent { get; set; }
        public virtual UnitStatus Status { get; set; }
    }

    public enum UnitStatus
    {
        Available,
        Occupied,
        Offline
    }
}
