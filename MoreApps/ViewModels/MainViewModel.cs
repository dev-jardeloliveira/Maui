using MoreApps.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MoreApps.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        #region field

        private string showOrHideImage = "nexibir.png";

        public string ShowOrHideImage
        {
            get => showOrHideImage;
            set 
            { 
                SetValue(ref showOrHideImage, value);   
            }
        }

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

        public ObservableCollection<Account> listAccount { get; set; }

        public ICommand ShowOrHideCommand { get;set; }
        #endregion


        public MainViewModel()
        {
            ShowOrHideCommand = new Command(()=>ShowOrHide()); ;
            listAccount = new ObservableCollection<Account>();
            this.Account = new Account
            {
                Id = Guid.NewGuid(),
                Name = "Ísis",
                Cash = 40.360,
                Bank = "Banco do Brasil",
                LogoBank = "bb.svg"
            };
            Account.Name = $"{Salutation.Salutation} \n <h4>{this.Account.Name}!<h4>";
            
            listAccount.Add(new Account
            {
                Id = Guid.NewGuid(),
                Name = "Ísis",
                Cash = 40.360,
                Bank = "Banco do Brasil",
                LogoBank = "bb.svg"
            });
            listAccount.Add(new Account
            {
                Id = Guid.NewGuid(),
                Name = "Ísis",
                Cash = 5.001,
                Bank = "Caixa Econômica",
                LogoBank = "bb.png"
            });
            listAccount.Add(new Account
            {
                Id = Guid.NewGuid(),
                Name = "Ísis",
                Cash = 7.333,
                Bank = "Nubank",
                LogoBank = "nubank.svg"
            });
            Account.Sum = listAccount.Sum(it => it.Cash);
        }

        public void ShowOrHide()
        {
            ShowOrHideImage = ShowOrHideImage.Equals("nexibir.png") ? "exibir.png" : "nexibir.png";
        }
    }
}

