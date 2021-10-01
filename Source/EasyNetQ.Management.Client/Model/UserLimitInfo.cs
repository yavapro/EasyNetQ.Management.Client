namespace EasyNetQ.Management.Client.Model
{
    using System.Collections.Generic;

    public class UserLimitInfo
    {
        public int Value { get; private set; }

        private readonly User user;
        private readonly string limit;

        private readonly ISet<string> limitTypes = new HashSet<string>
        {
            "max-connections", "max-channels"
        };

        public UserLimitInfo(User user, string limit, int value)
        {
            if (!limitTypes.Contains(limit))
            {
                throw new EasyNetQManagementException("Unknown user limit type '{0}', expected one of {1}",
                    limit,
                    string.Join(", ", limitTypes));
            }

            this.user = user;
            this.limit = limit;
            Value = value;
        }

        public string GetUserName()
        {
            return user.Name;
        }

        public string GetLimit()
        {
            return limit;
        }
    }
}
