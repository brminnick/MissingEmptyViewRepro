using Xamarin.Forms;

namespace MissingEmptyViewRepro
{
    public class App : Application
    {
        public App() => MainPage = new ContentPage
        {
            Content = new CollectionView
            {
                EmptyView = new Image
                {
                    Source = "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE2r0Th?ver=5b7d"
                }
            }
        };
    }
}
