using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace CarouselViewSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            AppearingCommand = new Command(OnAppearing);
        }

        public ICommand OpenWebCommand { get; }

        public ObservableCollection<string> Fruits { get; private set; } = new ObservableCollection<string>();

        private int _FruitPosition;
        public int FruitPosition
        {
            get
            {
                return _FruitPosition;
            }
            set
            {
                if (_FruitPosition == value)
                    return;
                _FruitPosition = value;
                OnPropertyChanged(nameof(FruitPosition));
            }
        }

        private string _CurrentFruit;
        public string CurrentFruit
        {
            get
            {
                return _CurrentFruit;
            }
            set
            {
                if (_CurrentFruit == value)
                    return;
                _CurrentFruit = value;
                OnPropertyChanged(nameof(CurrentFruit));
            }
        }

        public ICommand AppearingCommand { get; private set; }
        private void OnAppearing()
        {
            Fruits.Clear();
            Fruits.Add("Apple");
            Fruits.Add("Orange");
            Fruits.Add("Banana");
            Fruits.Add("Pineapple");
            Fruits.Add("Pear");
            Fruits.Add("Grapes");

            //**DEBUG HERE**
            //HERE THE POSITION = 0 BUT VISUALLY THE CAROUSEL DIFFERS.
            var position = FruitPosition;

            //**DEBUG HERE**
            //ON FIRST INSTANCE SELECTEDFRUIT IS NULL. IT SHOULD BE
            //SET TO APPLE. ON SUBSEQUANT RUNS IT REMAINS APPLE BUT
            //VISUALLY THE CAROUSEL DIFFERS.
            var selectedFruit = CurrentFruit;
        }
    }
}