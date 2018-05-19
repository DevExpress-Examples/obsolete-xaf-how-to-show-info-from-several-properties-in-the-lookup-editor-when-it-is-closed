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
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    public class Order : BaseObject {
        public Order(Session session) : base(session) { }
        private string name;
        public string Name {
            get { return name; }
            set {
                SetPropertyValue("Name", ref name, value);
            }
        }
        private DateTime date;
        public DateTime Date {
            get { return date; }
            set {
                SetPropertyValue("Date", ref date, value);
            }
        }
        private Customer customer;
        [Custom("LookupProperty", "CustomerLookupDisplayText")]
        public Customer Customer {
            get {
                return customer;
            }
            set {
                SetPropertyValue("Customer", ref customer, value);
            }
        }
    }
}
