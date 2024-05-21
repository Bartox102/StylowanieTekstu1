using Microsoft.Maui.Controls;

namespace StylowanieTekstu1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderLabel.Text = $"Rozmiar: {e.NewValue:F0}";
        }

        private void OnApplySettingsClicked(object sender, EventArgs e)
        {
          
            double fontSize = slider.Value;

          
            string selectedAlignment = textAlignmentPicker.SelectedItem as string;
            TextAlignment horizontalTextAlignment = TextAlignment.Start;

            if (selectedAlignment == "End")
            {
                horizontalTextAlignment = TextAlignment.End;
            }
            else if (selectedAlignment == "Center")
            {
                horizontalTextAlignment = TextAlignment.Center;
            }

          
            bool isBold = boldSwitch.IsToggled;
            bool isItalic = italicSwitch.IsToggled;

          
            FontAttributes fontAttributes = FontAttributes.None;

            if (isBold)
            {
                fontAttributes |= FontAttributes.Bold;
            }
            if (isItalic)
            {
                fontAttributes |= FontAttributes.Italic;
            }

            
            resultLabel.FontSize = fontSize;
            resultLabel.HorizontalTextAlignment = horizontalTextAlignment;
            resultLabel.FontAttributes = fontAttributes;
        }
    }
}

