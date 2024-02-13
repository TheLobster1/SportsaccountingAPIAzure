using Microsoft.AspNetCore.Identity;
using System;

namespace ConsoleApp2
{
    internal class User
    {
        private String _username;
        private String _firstName;
        private String _lastName;
        private String _email;
        private String _password;
        private String _joinDate;
        private String _userType;


        public User(String username, String firstName, String lastName, String email, String password, String userType)
        {
            this.setUsername(username);
            this.setFirstName(firstName);
            this.setLastName(lastName);
            this.setEmail(email);
            this.setPassword(password);
            this._joinDate = DateTime.Now.ToString();
            this._userType = userType;
        }

        public String getUsername()
        {
            return _username;
        }
        public String setUsername(String username)
        {
            if (username != null && username.Length <= 50)
            {
                this._username = username;
                return username;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The username does not meet the database requirements");
            }
        }
        public String getFirstName()
        {
            return _firstName;
        }
        public String getLastName()
        {
            return _lastName;
        }
        public String setFirstName(String firstName)
        {
            if (firstName != null && firstName.Length <= 20)
            {
                this._firstName = firstName;
                return firstName;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The first name does not meet the database requirements");
            }
        }
        public String setLastName(String lastName)
        {
            if (lastName != null && lastName.Length <= 20)
            {
                this._lastName = lastName;
                return lastName;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The last name does not meet the database requirements");
            }
        }
        public String getEmail()
        {
            return _email;
        }
        public String setEmail(String email)
        {
            if (email != null && email.Length <= 320)
            {
                this._email = email;
                return email;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The email does not meet the database requirements");
            }
        }
        public String getJoinDate()
        {
            return this._joinDate;
        }
        public String getPassword()
        {
            Console.WriteLine(_password); return _password;
        }
        public void setPassword(String password)
        {
            if (password != null && password.Length <= 255)
            {
                this._password = new PasswordHasher<object>().HashPassword(null, password);
            }
        }
        public bool verifyPassword(String password)
        {
            var passwordVerificationResult = new PasswordHasher<object>().VerifyHashedPassword(null, this._password, password);
            switch (passwordVerificationResult)
            {
                case PasswordVerificationResult.Failed:
                    Console.WriteLine("Password is wrong");
                    return false;

                case PasswordVerificationResult.Success:
                    Console.WriteLine("Password is good");
                    return true;

                case PasswordVerificationResult.SuccessRehashNeeded:
                    Console.WriteLine("Password is good but not hashed for some reason");
                    return false;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

}
