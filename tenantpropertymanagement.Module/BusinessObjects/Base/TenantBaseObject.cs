using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using Tenant_Property_Management.Module.BusinessObjects;
using tenantpropertymanagement.Module.BusinessObjects;

namespace Tenant_Property_Management.Module.BusinessObjects.Base
{
    [DefaultClassOptions]
    [NavigationItem("Accounting")]

    public abstract class TenantBaseObject : BaseObject
    {
        public TenantBaseObject() { }

        [Browsable(true)]
        public virtual Organization Organization { get; set; }

        public override void OnSaving()
        {
            if (Organization == null)
            {
                var user = SecuritySystem.CurrentUser as ApplicationUser;
                Organization = (Organization)user.Organization;
            }
            base.OnSaving();
        }
    }
}
