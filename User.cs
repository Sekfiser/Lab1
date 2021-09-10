

namespace Lab1
{
    /// <summary>
    /// Abstract class user
    /// </summary>
    abstract class User
    {
        /// <summary>
        /// User login
        /// </summary>
        public string Login { get; private set; }
        /// <summary>
        /// User password
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// New user creation.
        /// </summary>
        /// <param name="login">Login to users account</param>
        /// <param name="password">Password to user account</param>
        public User(string login, string password) 
        {
            Login = login;
            Password = password;
        }
        /// <summary>
        /// Abstract method to check entered password
        /// </summary>
        /// <param name="password">Inputed password</param>
        /// <returns>Returns true if password correct, returns false in other cases.</returns>
        abstract public bool PassCheck(string password); 
    }
}
