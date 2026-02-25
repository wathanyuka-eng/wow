using System;

namespace LAB5
{
    public class User
    {
        protected string firstname;
        protected string lastname;
        protected string email;
        protected string phone;

        public void Register(string fname, string lname, string mail, string tel)
        {
            firstname = fname;
            lastname = lname;
            email = mail;
            phone = tel;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {firstname} {lastname}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone: {phone}");
        }
    }
}