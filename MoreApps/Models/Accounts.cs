namespace MoreApps.Models
{
    public class Account
    {
        private Guid id;
        private string name;
        private string cash;


        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Value { get => cash; set => cash = value; }
    }
}
