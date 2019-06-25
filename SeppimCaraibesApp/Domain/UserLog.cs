namespace SeppimCaraibesApp.Domain
{
    internal class UserLog
    {
        private static UserLog instance = null;


        public int UserId { get; private set; }

        public string Nick { get; private set; }

        public string FullName { get; private set; }

        public string Password { get; private set; }

        public int RoleId { get; private set; }

        public Data.ORM.Role Role { get; private set; }


        #region Singleton
        private UserLog() { }

        public static UserLog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLog();
                }
                return instance;
            }
        }

        public static void Dispose()
        {
            instance = null;
        }
        #endregion


        #region Set
        public int SetUserId
        {
            set
            {
                if (value >= 0)
                {
                    UserId = value;
                }
            }
        }

        public string SetNick
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Nick = value;
                }
            }
        }

        public string SetFullName
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    FullName = value;
                }
            }
        }

        public string SetPassword
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Password = value;
                }
            }
        }

        public int SetRoleId
        {
            set
            {
                if (value >= 0)
                {
                    RoleId = value;
                }
            }
        }

        public Data.ORM.Role SetRole
        {
            set
            {
                if (value != null)
                {
                    Role = value;
                }
            }
        }
        #endregion
    }
}
