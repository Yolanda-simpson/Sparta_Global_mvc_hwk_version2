using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace ASPDOTNETCARHWK.Models
{
    public class Rvan
    {
        private string Firstname;
        private string Lastname;
        private int age;
        private string Hiredate;
        private string Vantype;
        private string Duration;
        private string EmailAddress;

        [DisplayName("First Name")]
        public string Firstname1 { get => Firstname; set => Firstname = value; }
        [DisplayName("Last Name")]
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        [DisplayName("Age")]
        public int Age { get => age; set => age = value; }
        [DisplayName("Age")]
        public string Hiredate1 { get => Hiredate; set => Hiredate = value; }
        [DisplayName("Van Type")]
        public string Vantype1 { get => Vantype; set => Vantype = value; }
        [DisplayName("Duration")]
        public string Duration1 { get => Duration; set => Duration = value; }
        [DisplayName("Email Address")]
        public string EmailAddress1 { get => EmailAddress; set => EmailAddress = value; }
    }
}