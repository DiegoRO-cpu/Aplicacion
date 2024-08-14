using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompuCraft1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Armado : ContentPage
    {
        public Armado()
        {
            InitializeComponent();
        }

        private void OnCalculateScoreClicked(object sender, EventArgs e)
        {
            // Asignar puntos a cada opción
            int cpuScore = GetOptionScore(CpuPicker.SelectedIndex);
            int motherboardScore = GetOptionScore(MotherboardPicker.SelectedIndex);
            int ramScore = GetOptionScore(RamPicker.SelectedIndex);
            int ssdScore = GetOptionScore(SsdPicker.SelectedIndex);
            int psuScore = GetOptionScore(PsuPicker.SelectedIndex);
            int caseScore = GetOptionScore(CasePicker.SelectedIndex);
            int coolerScore = GetOptionScore(CoolerPicker.SelectedIndex);
            int gpuScore = GetOptionScore(GpuPicker.SelectedIndex);

            // Calcular la puntuación total
            int totalScore = cpuScore + motherboardScore + ramScore + ssdScore +
                             psuScore + caseScore + coolerScore + gpuScore;

            // Mostrar la puntuación en la etiqueta
            ScoreLabel.Text = $"Puntuación: {totalScore}";
        }

        // Método para obtener la puntuación basada en el índice seleccionado
        private int GetOptionScore(int selectedIndex)
        {
            // Asigna puntajes específicos según el índice seleccionado
            // Puedes ajustar los puntajes según el número de opciones que tengas
            switch (selectedIndex)
            {
                case 0: return 10;
                case 1: return 20;
                case 2: return 30;
                case 3: return 40;
                case 4: return 50;
                default: return 0;
            }
        }
    }
}