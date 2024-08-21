namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnSubmitClicked(object sender, EventArgs e)
        {
            this.Resources["DynamicSubmissionMessage"] = "Submission Success";
        }

        public void OnClickedDarkMode(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Gray;
            this.Resources["DynamicSubmitButton"] = Colors.Black;
            this.Resources["DynamicSubmitButtonText"] = Colors.White;
        }

        public void OnClickedLightMode(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Teal;
            this.Resources["DynamicSubmitButton"] = Colors.White;
            this.Resources["DynamicSubmitButtonText"] = Colors.Black;
        }

        private void OnNameEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                DynamicNameEntry.Text = e.NewTextValue;
            }
            else
            {
                DynamicNameEntry.Text = (string)this.Resources["DynamicName"];
            }
        }

        private void OnEmailEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                DynamicEmailEntry.Text = e.NewTextValue;
            }
            else
            {
                DynamicEmailEntry.Text = (string)this.Resources["DynamicEmail"];
            }
        }

        private void OnBioEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                DynamicBioEntry.Text = e.NewTextValue;
            }
            else
            {
                DynamicBioEntry.Text = (string)this.Resources["DynamicBio"];
            }
        }

        private void OnDatePickerDateSelected(object sender, DateChangedEventArgs e)
        {
            DynamicDateOfBirthEntry.Text = $"Date of Birth: {e.NewDate:MM/dd/yyyy}";
        }
    }
}
