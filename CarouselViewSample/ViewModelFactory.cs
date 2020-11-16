using CarouselViewSample.ViewModels;
namespace CarouselViewSample
{
    public class ViewModelFactory
    {
        private AboutViewModel aboutViewModel;

        public AboutViewModel AboutViewModel
        {
            get
            {
                if (aboutViewModel == null)
                    aboutViewModel = new AboutViewModel();
                return aboutViewModel;
            }
        }
    }
}