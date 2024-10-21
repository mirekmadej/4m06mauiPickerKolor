using Microsoft.Maui.Controls.Platform.Compatibility;

namespace _4m06mauiPickerKolor
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void lvSelected(object sender, EventArgs e)
        {
            vApp.Text = lvColorFont.SelectedItem.ToString();

        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            if(pickerColorFont.SelectedIndex != -1)
            {
                switch(pickerColorFont.SelectedIndex)
                {
                    case 0:
                        vApp.TextColor = Colors.Black;
                        break;
                    case 1:
                        vApp.TextColor = Colors.Red;
                        break;
                    case 2:
                        vApp.TextColor = Colors.Green;
                        break;

                }
            }
        }

        private void onPickerSelected(object sender, EventArgs e)
        {
            var p = (Picker)sender;
            int selectedItem = p.SelectedIndex;

            if(selectedItem != -1)
            {
                switch(selectedItem)
                {
                    case 0:
                        vApp.BackgroundColor = Colors.Red;
                        break;
                    case 1:
                        vApp.BackgroundColor = Colors.Green;
                        break;
                    case 2:
                        vApp.BackgroundColor = Colors.Blue;
                        break;
                    case 3:
                        vApp.BackgroundColor = Colors.Yellow;
                        break;
                }
            }
        }
    }

}
