using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Customer obj1 = Session.FindObject<Customer>(CriteriaOperator.Parse("Name=?", "Customer1"));
            if (obj1 == null) {
                obj1 = new Customer(Session);
                obj1.Name = "Customer1";
                obj1.Email = "Customer1@company.com";
                obj1.PhoneNumber = "01234";
                obj1.Save();
            }
            Order obj2 = Session.FindObject<Order>(CriteriaOperator.Parse("Name=?", "Order1"));
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