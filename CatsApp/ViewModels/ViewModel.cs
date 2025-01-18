using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CatsApp.Data;
using CatsApp.Models;

namespace CatsApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly CatAPI _catAPI;
        private ObservableCollection<Cat> _cats;

        public ObservableCollection<Cat> Cats
        {
            get => _cats;
            set
            {
                _cats = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            _catAPI = new CatAPI();
            _cats = new ObservableCollection<Cat>();
            LoadData();
        }

        private async void LoadData()
        {
            var data = await _catAPI.GetData();
            if (data != null)
            {
                foreach (var cat in data)
                {
                    Cats.Add(cat);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
