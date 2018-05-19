// Developer Express Code Central Example:
// How to show info from several properties in the lookup editor when it is closed
// 
// This example is an intermediate workaround for the suggestion. To see how this
// works, open the Order detail view and notice that the Customer editor displays
// more information than usual.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1322

using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Customer obj1 = ObjectSpace.FindObject<Customer>(CriteriaOperator.Parse("Name=?", "Customer1"));
            if (obj1 == null) {
                obj1 = new Customer(Session);
                obj1.Name = "Customer1";
                obj1.Email = "Customer1@company.com";
                obj1.PhoneNumber = "01234";
                obj1.Save();
            }
            Order obj2 = ObjectSpace.FindObject<Order>(CriteriaOperator.Parse("Name=?", "Order1"));
            if (obj2 == null) {
                obj2 = new Order(Session);
                obj2.Name = "Order1";
                obj2.Date = DateTime.Now;
                obj2.Customer = obj1;
                obj2.Save();
            }
        }
    }
}