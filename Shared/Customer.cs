using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NewBlazor.Shared
{
    public class Customer : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; OnPropertyChanged(); } 
        }
        private string street;
        public string Street { 
            get { return street; }
            set {street = value; OnPropertyChanged(); }
        }
        private string city;
        public string City {
            get { return city; }
            set { city = value; OnPropertyChanged(); } 
        }

        public bool HasErrors => GetErrors(string.Empty).Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this,
          new PropertyChangedEventArgs(propertyName));
    }
    public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || propertyName == nameof(Name))
            {
                if (string.IsNullOrEmpty(Name))
                {
                    yield return $"A customer's name is mandatory";
                }
                else if (Name.Contains("Pizza"))
                {
                    yield return $"Name should not contain \"Pizza\"";
                }
            }
            if (string.IsNullOrEmpty(propertyName)|| propertyName == nameof(Street))
            {
                if (string.IsNullOrEmpty(Street))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }

            if (string.IsNullOrEmpty(propertyName)|| propertyName == nameof(City))
            {
                if (string.IsNullOrEmpty(City))
                {
                    yield return $"{propertyName} is mandatory";
                }
            }

        }
    }
}
