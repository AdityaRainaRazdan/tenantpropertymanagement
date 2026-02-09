using DevExpress.EntityFrameworkCore.Security;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.EFCore;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Updating;
using Microsoft.EntityFrameworkCore;
using tenantpropertymanagement.Module.BusinessObjects;

namespace tenantpropertymanagement.Blazor.Server
{
    public class tenantpropertymanagementBlazorApplication : BlazorApplication
    {
        public tenantpropertymanagementBlazorApplication()
        {
            ApplicationName = "tenantpropertymanagement";
            CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            DatabaseVersionMismatch += tenantpropertymanagementBlazorApplication_DatabaseVersionMismatch;
        }
        protected override void OnSetupStarted()
        {
            base.OnSetupStarted();

#if DEBUG
            if(System.Diagnostics.Debugger.IsAttached && CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
#endif
        }
        void tenantpropertymanagementBlazorApplication_DatabaseVersionMismatch(object sender, DatabaseVersionMismatchEventArgs e)
        {
#if DEBUG
            e.Updater.Update();
            e.Handled = true;
#else
    throw new InvalidOperationException(
        "The application cannot connect to the specified database. " +
        "Contact your system administrator.");
#endif

        }
    }
}
