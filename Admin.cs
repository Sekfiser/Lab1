
using System;

namespace Lab1
{
    class Admin : User
    {
        /// <summary>
        /// Count of wrong password inputs.
        /// </summary>
        public int PasswordInputCount { get; private set; }
        /// <summary>
        /// State of users account. True means blocked.
        /// </summary>
        public bool Blocked { get; private set; }

        /// <summary>
        /// New administrator creation.
        /// </summary>
        /// <param name="login">Login to account</param>
        /// <param name="password">Password to account</param>
       
        public Admin(string login, string password) : base(login, password) 
        {
            PasswordInputCount = 0;
            Blocked = false;
        }
        /// <summary>
        /// Method to check entered password.
        /// </summary>
        /// <param name="password">Inputed password</param>
        /// <returns>Returns true if password correct, returns false in other cases. Will block user account in case of 3 wrong inputs.</returns>
        public override bool PassCheck(string password)
        {
            if (Blocked == false && password.Equals(Password))
            {
                PasswordInputCount = 0;
                return true;
            }
            else
            {
                if (Blocked == true)
                {
                    Console.WriteLine("Your account blocked!");
                    return false;
                }
                else
                {
                    PasswordInputCount++;
                    if (PasswordInputCount >= 3)
                    {
                        Blocked = true;
                    }
                    return false;
                }
            }
        }

    }
}
