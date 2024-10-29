using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
        ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        public PersonasWindow()
        {
            InitializeComponent();
            lvPersonas.ItemsSource = personas;
        }
      

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {                        

            lvPersonas.ItemsSource = personas;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {

            int edad = Convert.ToInt32(txtEdad.Text);
            SolidColorBrush color = Brushes.Green; ;

            if (edad > 18)
                color = Brushes.Red;

            personas.Add(new Persona { 
                Apellidos = txtApellidos.Text,
                Nombres = txtNombres.Text, 
                Edad = Convert.ToInt32(txtEdad.Text) ,
                MiColor= color
            }            
            );
                              

        }
    }
}
