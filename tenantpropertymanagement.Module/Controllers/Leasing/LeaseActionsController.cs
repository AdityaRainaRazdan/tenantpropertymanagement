using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using TenantPropertyManagement.Module.BusinessObjects.Leasing;
using TenantPropertyManagement.Module.BusinessObjects.Portfolio;

namespace YourApp.Module.Controllers.Leasing
{
    public class LeaseActionsController : ObjectViewController<DetailView, Lease>
    {
        public LeaseActionsController()
        {
            var activate = new SimpleAction(this, "ActivateLease", null)
            {
                Caption = "Activate Lease"
            };
            activate.Execute += Activate_Execute;

            var terminate = new SimpleAction(this, "TerminateLease", null)
            {
                Caption = "Terminate Lease"
            };
            terminate.Execute += Terminate_Execute;
        }

        private void Activate_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var lease = View.CurrentObject as Lease;
            lease.Status = LeaseStatus.Active;
            lease.Unit.Status = UnitStatus.Occupied;
            ObjectSpace.CommitChanges();
        }

        private void Terminate_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var lease = View.CurrentObject as Lease;
            lease.Status = LeaseStatus.Terminated;
            lease.Unit.Status = UnitStatus.Available;
            ObjectSpace.CommitChanges();
        }
    }
}
