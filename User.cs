namespace Project_iPole_01
{
    class User
    {
        private string Name { get; set; }
        private string MemberId { get; set; }
        private string Password { get; set; }
        private bool LoginStatus { get; set; }

        public User (string name, string memberId, string password, bool loginStatus)
        {
            Name = name;
            MemberId = memberId;
            Password = password;
            LoginStatus = loginStatus;
        }

        private bool VerifyLogin()
        {
            return true;
        }
    }
}
