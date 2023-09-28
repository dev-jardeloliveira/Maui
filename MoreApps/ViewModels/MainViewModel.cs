using MoreApps.Models;

namespace MoreApps.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        #region field
        private Account account;
        public Account Account
        {
            get => this.account;
            set => this.SetValue(ref account, value);
        }

        private Salutations salutation = new Salutations();
        public Salutations Salutation
        {
            get => this.salutation;
            set => this.SetValue(ref salutation, value);
        }
        #endregion


        public MainViewModel()
        {
            this.Account = new Account
            {
                Id = Guid.NewGuid(),
                Name = "Ísis",
                Value = "240.00",
            };
            Account.Name = $"{Salutation.Salutation} \n <h4>{this.Account.Name}!<h4>";
        }

    }
}

