using FamilyCompanion.Models;
using FamilyCompanion.PageModels;

namespace FamilyCompanion.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}