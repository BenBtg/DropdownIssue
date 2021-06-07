using DropdownIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DropdownIssue.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {

        FirstPageViewModel myViewModel;
        public FirstPage()
        {
            myViewModel = new FirstPageViewModel();
            InitializeComponent();
            BindingContext = myViewModel;
        }
    }
}