using System;

namespace App_Multiplataforma
{
    public partial class secundaria : ContentPage
    {
        int count = 0;
        Random random = new Random();
        string[] imagenes = { "adam.png", "venom.png", "mantis.png", "bucky.png" };
        string imagenAhora = string.Empty;
        string ultimaImagen = string.Empty;

        public secundaria()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            ultimaImagen = imagenAhora;

            string nuevaImagen;
            do
            {
                int index = random.Next(imagenes.Length);
                nuevaImagen = imagenes[index];
            } while (nuevaImagen == imagenAhora);

            MiImagen.Source = nuevaImagen;
            imagenAhora = nuevaImagen;

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void boton2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ultimaImagen))
            {
                MiImagen.Source = ultimaImagen;
                imagenAhora = ultimaImagen;
            }
            else
            {
                DisplayAlert("Error", "No hay imagen anterior para mostrar.", "OK");
            }
        }
    }
}