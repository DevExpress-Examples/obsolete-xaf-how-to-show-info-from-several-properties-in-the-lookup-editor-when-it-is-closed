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
