using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Codigo2024Clase23
{
    /// <summary>
    /// Lógica de interacción para PersonasWindow.xaml
    /// </summary>
    public partial class PersonasWindow : Window
    {
        public PersonasWindow()
        {
            InitializeComponent();
        }
      

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { Apellidos = "SEVILLA", Nombres = "IVAN", Edad = 36 });
            personas.Add(new Persona { Apellidos = "JORGE", Nombres = "BRANDON", Edad = 25 });
            personas.Add(new Persona { Apellidos = "INGA", Nombres = "JHOY", Edad = 25 });
            personas.Add(new Persona { Apellidos = "CUEVAS", Nombres = "RONALD", Edad = 30 });
            personas.Add(new Persona { Apellidos = "TORRICO", Nombres = "HUGO", Edad = 32 });


            lvPersonas.ItemsSource = personas;

        }
    }
}
