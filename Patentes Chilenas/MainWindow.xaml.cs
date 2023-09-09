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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Automovil;

namespace Patentes_Chilenas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_Validar_Click(object sender, RoutedEventArgs e)
        {
            ///Trabajo Hecho por Claudio Vergara y Jose Muñoz
            Patentes patente = new Patentes();

            patente.Patente = tb_Validar.Text.Trim();

            

            
            if (patente.Patente.Length == 6)
            {
                string validacion = patente.Validacion();
                if(validacion == "Patente antigua")
                {
                    if (patente.PatenteAntigua() != -1)
                    {
                        if (patente.ValidarNumerosAntiguo() != -1)
                        {
                            if (patente.ValidarCeroAntiguo() > 1000 && patente.ValidarCeroAntiguo() < 9999)
                            {
                                MessageBox.Show("Patente Correcta", "Patente Antigua");

                            }else
                            {
                                MessageBox.Show("Patente Incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Patente Incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Patente Incorrecta");
                    }
                }
                else
                {
                    if (validacion == "Pantente Nueva")
                    {
                        if (patente.PatenteNueva() != -1)
                        {
                            if (patente.ValidarNumerosNuevo() != -1)
                            {
                                if (patente.ValidarCeroNuevo() > 10 && patente.ValidarCeroNuevo() < 99)
                                {
                                    MessageBox.Show("Patente Correcta", "Patente Nueva");

                                }
                                else
                                {
                                    MessageBox.Show("Patente Incorrecta");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Patente Incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Patente Incorrecta");
                        }
                    }
                    else
                    {
                        if (validacion == "Patente Incorrecta")
                        {
                            MessageBox.Show("Patente Incorrecta");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tiene que tener 6 caracteres");
            }
            






















        }
    }
}
