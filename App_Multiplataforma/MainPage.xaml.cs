using System;

namespace App_Multiplataforma
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Random random = new Random();
        string[] imagenes = { "adam.png", "venom.png", "mantis.png", "bucky.png" };
        string ultimaImagen = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            string nuevaImagen;
            do
            {
                int index = random.Next(imagenes.Length);
                nuevaImagen = imagenes[index];
            } while (nuevaImagen == ultimaImagen);

            MiImagen.Source = nuevaImagen;
            ultimaImagen = nuevaImagen;

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}