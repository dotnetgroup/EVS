using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SignUp_mvc.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class SignUp
    {
        Gender gender;
        
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        private string _UserName;

        [Required]
        [StringLength(50, ErrorMessage = "Name should be less then 51 letters")]
        [RegularExpression("/[A-z]+$")]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _DateOfBirth;

        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _CompanyName;

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _PostalCode;

        public string PostalCode
        {
            get { return _PostalCode; }
            set { _PostalCode = value; }
        }

        private string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        private string _State;

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        private string _Country;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        private string _TelePhoneNo;

        public string TelePhoneNo
        {
            get { return _TelePhoneNo; }
            set { _TelePhoneNo = value; }
        }

        private string _FaxNo;

        public string FaxNo
        {
            get { return _FaxNo; }
            set { _FaxNo = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _ConfirmPassowrd;

        public string ConfirmPassowrd
        {
            get { return _ConfirmPassowrd; }
            set { _ConfirmPassowrd = value; }
        }
    }
}
