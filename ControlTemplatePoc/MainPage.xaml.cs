
using CommunityToolkit.Mvvm.ComponentModel;

namespace ControlTemplatePoc
{
    public partial class MainPage : ContentPage
    {
        private bool _boolean;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public bool Boolean 
        { 
            get => _boolean; 
            set  { _boolean = value; OnPropertyChanged(); } 
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Boolean = !Boolean;
            var ct = frame.ControlTemplate;// = (Boolean ? frame.Resources["First"] : frame.Resources["Second"]) as ControlTemplate;
        }
    }

}
