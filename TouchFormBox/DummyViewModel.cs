namespace TouchFormBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Gu.Units;

    using JetBrains.Annotations;

    public class DummyViewModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private Length length;
        private Mass weight;
        private double doubleValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == this.firstName) return;
                this.firstName = value;
                this.OnPropertyChanged();
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == this.lastName) return;
                this.lastName = value;
                this.OnPropertyChanged();
            }
        }

        public double DoubleValue
        {
            get { return doubleValue; }
            set
            {
                if (value.Equals(doubleValue)) return;
                doubleValue = value;
                OnPropertyChanged();
            }
        }

        public Length Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value.Equals(this.length)) return;
                this.length = value;
                this.OnPropertyChanged();
            }
        }

        public Mass Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value.Equals(this.weight)) return;
                this.weight = value;
                this.OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
