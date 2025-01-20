using System;

namespace App_Multiplataforma
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Random random = new Random();
        string[] images = { "adam.png", "venom.png", "mantis.png", "bucky.png" };

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            // Seleccionar una imagen aleatoria
            int index = random.Next(images.Length);
            MyImage.Source = images[index];

            SemanticScreenReader.Announce(CounterBtn.Text);

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}