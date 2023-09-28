

namespace MoreApps.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isbusy;

        public bool IsBusy
        {
            get => this.isbusy;
            set => this.SetValue(ref this.isbusy, value);
        }


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string? propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }

    }
}
