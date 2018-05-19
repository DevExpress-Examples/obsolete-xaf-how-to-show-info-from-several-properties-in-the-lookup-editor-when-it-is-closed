using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    public class Customer : BaseObject {
        public Customer(Session session) : base(session) { }
        private string name;
        public string Name {
            get { return name; }
            set {
                SetPropertyValue("Name", ref name, value);
            }
        }
        private string email;
        public string Email {
            get {
                return email;
            }
            set {
                SetPropertyValue("Email", ref email, value);
            }
        }
        private string phoneNumber;
        public string PhoneNumber {
            get {
                return phoneNumber;
            }
            set {
                SetPropertyValue("PhoneNumber", ref phoneNumber, value);
            }
        }
        protected string CustomerLookupDisplayText {
            get {
                return String.Format("{0} (Email: {1}, PhoneNumber: {2} )", Name, Email, PhoneNumber);
            }
        }
    }
}