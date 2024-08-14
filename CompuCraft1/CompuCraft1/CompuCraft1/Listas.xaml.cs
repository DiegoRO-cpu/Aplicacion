using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompuCraft1
{
    public partial class Listas : ContentPage
    {
        public Listas()
        {
            InitializeComponent();
            BindingContext = new StoreListViewModel();
        }
    }

    public class StoreListViewModel : BindableObject
    {
        public ObservableCollection<Store> Stores { get; set; }

        public StoreListViewModel()
        {
            // Inicializamos la lista de tiendas
            Stores = new ObservableCollection<Store>
            {
               new Store { Name = "XTREME PC", Type = "En Línea", Address = "https://www.xtremepc.com.mx/" },
                new Store { Name = "DDTECH", Type = "En Línea", Address = "https://ddtech.mx/" },
                new Store { Name = "Amazon", Type = "En Línea", Address = "https://www.amazon.com.mx/" },
                new Store { Name = "PC GAMER CDMX", Type = "Física", Address = "Av. Insurgentes Sur 300-LOCAL 16, Roma Nte., Cuauhtémoc, 06700 Ciudad de México, CDMX" },
                new Store { Name = "MERCADO lIBRE", Type = "En Linea", Address = "https://www.mercadolibre.com.mx/" },
                new Store { Name = "CYBER PUERTA", Type = "En Línea", Address = "https://www.cyberpuerta.mx/" },
                new Store { Name = "DIGITALIFE", Type = "En Línea", Address = "www.bhphotovideo.com" } 
            };
        }
    }

    public class Store
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
    }
}