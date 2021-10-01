namespace EasyNetQ.Management.Client.Model
{
    public class UserLimit
    {
        public string User { get; set; }
        public string Limit { get; set; }

        public int Value { get; set; }
    }
}
