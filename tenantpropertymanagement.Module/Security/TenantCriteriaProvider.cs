using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base;
using Tenant_Property_Management.Module.BusinessObjects;
using tenantpropertymanagement.Module.BusinessObjects;

namespace TenantPropertyManagement.Module.Security
{
    [NavigationItem("Security")]
    public static class TenantCriteriaProvider
    {

        public static string GetCriteria(string typeName)
        {
            if (SecuritySystem.CurrentUser is ApplicationUser user)
            {
                // Use OrganizationId instead of Organization?.Oid
                return $"OrganizationId = '{user.Organization}'";
            }
            return "1=0";
        }
    }
}
