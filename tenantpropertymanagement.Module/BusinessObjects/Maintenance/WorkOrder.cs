using DevExpress.DataAccess.UserConfiguration;
using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects.Base;
using Tenant_Property_Management.Module.BusinessObjects.Portfolio;
using TenantPropertyManagement.Module.BusinessObjects.Portfolio;

namespace TenantPropertyManagement.Module.BusinessObjects.Maintenance
{
    [DefaultClassOptions]
    [NavigationItem("Maintenance")]

    public class WorkOrder : TenantBaseObject
    {
        public virtual RealEstateProperty Property { get; set; }
        public virtual Unit Unit { get; set; }

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        public virtual WorkOrderStatus Status { get; set; }
        public virtual DateTime DueDate { get; set; }
    }

    public enum WorkOrderStatus
    {
        New,
        Assigned,
        InProgress,
        Completed,
        Closed
    }
}
