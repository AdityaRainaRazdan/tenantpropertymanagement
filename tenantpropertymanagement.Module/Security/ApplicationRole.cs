using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace Tenant_Property_Management.Module.Security
{
    [DefaultClassOptions]
    [NavigationItem("Security")]

    public class ApplicationRole : PermissionPolicyRole
    {
        public virtual bool IsPlatformAdmin { get; set; }
    }
}
