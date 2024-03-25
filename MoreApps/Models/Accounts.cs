namespace MoreApps.Models
{
    public class Account
    {
        private Guid id;
        private string name;
        private double cash;
        private string bank;
        private string logoBank;
        private double sum;

        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Cash { get => cash; set => cash = value; }
        public string Bank { get => bank; set => bank = value; }
        public string LogoBank { get => logoBank; set => logoBank = value; }
        public double Sum { get => sum; set => sum = value; }


    }
}
