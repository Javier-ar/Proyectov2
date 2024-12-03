using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Proyecto.Proyecto.Personas;
using System.Collections.Generic;
using System.Linq;
using Proyecto.Proyecto.Eventos;
using Newtonsoft.Json;
using System.IO;

namespace Proyecto
{
    public partial class MainWindow : Window
    {
        private List<Trabajador> list_trabajador = new List<Trabajador>();
        private List<Cliente> list_clientes = new List<Cliente>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Ingresar_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                Cliente miCliente = new Cliente();
                int aux = 0;
                miCliente.IdCliente = aux + 1;
                miCliente.Presupuesto = Convert.ToInt32(this.tbPresupuesto.Text);
                miCliente.Rut = Convert.ToInt32(this.tbRut.Text);
                miCliente.Verificador = Convert.ToInt32(this.tbVerificador.Text);
                miCliente.Nombre = this.tbNombre.Text;
                miCliente.ApellidoPaterno = this.tbApellidoPaterno.Text;
                miCliente.ApellidoMaterno = this.tbApellidoMaterno.Text;
                miCliente.Telefono = Convert.ToInt32(this.tbTelefono.Text);
                string[] array = fechaNacimiento.Text.Split("-");
                miCliente.FechaNacimiento = new DateTime
                (
                    int.Parse(array[2]),
                    int.Parse(array[1]),
                    int.Parse(array[0])
                );
                list_clientes.Add(miCliente);
            }
            catch (ArgumentNullException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (FormatException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (OverflowException ex) 
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Eliminar_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                Cliente miCliente = new Cliente();
                int cliente_borrar = list_clientes.Count();
                list_clientes.RemoveAt(cliente_borrar - 1);
                this.tbkNombre.Text = " Eliminado";
                this.tbkPresupuesto.IsVisible = false;
                this.tbkRut.IsVisible = false;
                this.tbkVerificador.IsVisible = false;
                this.tbkNombre.IsVisible = true;
                this.tbkApellidoPaterno.IsVisible = false;
                this.tbkApellidoMaterno.IsVisible = false;
                this.tbkTelefono.IsVisible = false;
                this.tbkNacimiento.IsVisible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (OverflowException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (ArgumentNullException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }


            }
        public void Mostrar_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                if (list_clientes.Count() > 0)
                {
                    foreach (var miCliente in list_clientes)
                    {
                        this.tbkPresupuesto.Text = "Presupuesto: " + miCliente.Presupuesto;
                        this.tbkRut.Text = "Rut: " + miCliente.Rut + "-" + miCliente.Verificador;
                        this.tbkNombre.Text = "Nombre: " + miCliente.Nombre + " " + miCliente.ApellidoPaterno + " " + miCliente.ApellidoMaterno;
                        this.tbkTelefono.Text = "Telefono: " + miCliente.Telefono;
                        this.tbkNacimiento.Text = "Fecha de Nacimiento: " + " " + miCliente.FechaNacimiento.Day.ToString() + "-" + miCliente.FechaNacimiento.Month.ToString() + "-" + miCliente.FechaNacimiento.Year.ToString();
                        this.tbkPresupuesto.IsVisible = true;
                        this.tbkRut.IsVisible = true;
                        this.tbkVerificador.IsVisible = true;
                        this.tbkNombre.IsVisible = true;
                        this.tbkApellidoPaterno.IsVisible = true;
                        this.tbkApellidoMaterno.IsVisible = true;
                        this.tbkTelefono.IsVisible = true;
                        this.tbkNacimiento.IsVisible = true;
                    }
                }
                else
                {
                    this.tbkNombre.Text = "No hay Clientes,ingresados";
                    this.tbkNombre.IsVisible = true;
                }
                
            }
            catch (OverflowException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (ArgumentNullException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void CheckBox_Checked(object sender, RoutedEventArgs e )
        {
            this.tbkNotificacion.Text = "CheckBox seleccionado! ";
            this.tbkNotificacion.IsVisible = true;
            this.tbkNotificacionn.IsVisible = false;
        }
        public void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.tbkNotificacionn.Text = "CheckBox deseleccionado! ";
            this.tbkNotificacion.IsVisible = false;
            this.tbkNotificacionn.IsVisible = true;
        }
        public void Ingresart_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                Trabajador miTrabajador = new Trabajador();
                int aux = 0;
                miTrabajador.IdTrabajador = aux + 1;
                miTrabajador.Rut = Convert.ToInt32(this.tbRutt.Text);
                miTrabajador.Verificador = Convert.ToInt32(this.tbVerificadort.Text);
                miTrabajador.Nombre = this.tbNombret.Text;
                miTrabajador.ApellidoPaterno = this.tbApellidoPaternot.Text;
                miTrabajador.ApellidoMaterno = this.tbApellidoMaternot.Text;
                miTrabajador.Telefono = Convert.ToInt32(this.tbTelefonot.Text);
                string[] array = fechaNacimientot.Text.Split("-");
                miTrabajador.FechaNacimiento = new DateTime
                (
                    int.Parse(array[2]),
                    int.Parse(array[1]),
                    int.Parse(array[0])
                );

                miTrabajador.Afp = this.tbAfp.Text;
                miTrabajador.SueldoBruto = Convert.ToDouble(this.tbSB.Text);
                miTrabajador.Colacion = Convert.ToDouble(this.tbColacion.Text);
                miTrabajador.Pasaje = Convert.ToDouble(this.tbPasaje.Text);
                miTrabajador.DescuentoAfp = Convert.ToDouble(this.tbDescuentoAfp.Text);
                miTrabajador.Salud = Convert.ToDouble(this.tbDescuentoSalud.Text);
                list_trabajador.Add(miTrabajador);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (OverflowException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (ArgumentNullException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Eliminart_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                int trabajador_borrar = list_trabajador.Count();
                list_trabajador.RemoveAt(trabajador_borrar - 1);
                this.tbkNombre.Text = " Eliminado";
                this.tbkRut.IsVisible = false;
                this.tbkVerificador.IsVisible = false;
                this.tbkNombre.IsVisible = true;
                this.tbkApellidoPaterno.IsVisible = false;
                this.tbkApellidoMaterno.IsVisible = false;
                this.tbkTelefono.IsVisible = false;
                this.tbkNacimiento.IsVisible = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Mostrart_Click(object sender, RoutedEventArgs args)
        {
            foreach (var miTrabajador in list_trabajador)
            {
                
                this.tbkRutt.Text = "Rut: " + miTrabajador.Rut + "-" + miTrabajador.Verificador;
                this.tbkNombret.Text = "Nombre: " + miTrabajador.Nombre + " " + miTrabajador.ApellidoPaterno + " " + miTrabajador.ApellidoMaterno;
                this.tbkTelefonot.Text = "Telefono: " + miTrabajador.Telefono;
                this.tbkNacimientot.Text = "Fecha de Nacimiento: " + " " + miTrabajador.FechaNacimiento.Day.ToString() + "-" + miTrabajador.FechaNacimiento.Month.ToString() + "-" + miTrabajador.FechaNacimiento.Year.ToString();
                this.tbkRutt.IsVisible = true;
                this.tbkVerificadort.IsVisible = true;
                this.tbkNombret.IsVisible = true;
                this.tbkApellidoPaternot.IsVisible = true;
                this.tbkApellidoMaternot.IsVisible = true;
                this.tbkTelefonot.IsVisible = true;
                this.tbkNacimientot.IsVisible = true;
                }
            }

        public void Ingresare_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                Evento miEvento = new Evento();
                miEvento.IdEvento = int.Parse(tbidevento.Text);
                miEvento.Nombre = tbnombrevento.Text;
                string[] array = fechaevento.Text.Split("-");
                miEvento.Fecha = new DateTime
               (
                   int.Parse(array[2]),
                   int.Parse(array[1]),
                   int.Parse(array[0])
               );
                miEvento.Costo = int.Parse(tbcosto.Text);
                mostrar_en_home(miEvento);
            }
            catch (FormatException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (OverflowException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (ArgumentNullException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }

        public void mostrar_en_home(Evento miEvento)
        {
            this.Lista_eventos.IsVisible = true;
            if (this.evento1.IsVisible != true)
            {
                this.evento1.IsVisible = true;
                this.fotoevento1.IsVisible = true;
                this.tbknombreevento1.Text = miEvento.Nombre;
                this.tbknombreevento1.IsVisible = true;
                this.tbkfechaevento1.Text = miEvento.Fecha.ToString();
                this.tbkfechaevento1.IsVisible=true;
                this.btnevento1.IsVisible = true;
            }
            else
            {
                if (this.evento2.IsVisible != true)
                {
                    this.evento2.IsVisible = true;
                    this.fotoevento2.IsVisible = true;
                    this.tbknombreevento2.Text = miEvento.Nombre;
                    this.tbknombreevento2.IsVisible = true;
                    this.tbkfechaevento2.Text = miEvento.Fecha.ToString();
                    this.tbkfechaevento2.IsVisible = true;
                    this.btnevento2.IsVisible = true;
                }
                else
                {
                    this.evento3.IsVisible = true;
                    this.fotoevento3.IsVisible = true;
                    this.tbknombreevento3.Text = miEvento.Nombre;
                    this.tbknombreevento3.IsVisible = true;
                    this.tbkfechaevento3.Text = miEvento.Fecha.ToString();
                    this.tbkfechaevento3.IsVisible = true;
                    this.btnevento3.IsVisible = true;
                }
            }

        }
        private void GuardarDatos()
        {
            string clientesJson = JsonConvert.SerializeObject(list_clientes, Formatting.Indented);
            File.WriteAllText("clientes.json", clientesJson);

            string trabajadoresJson = JsonConvert.SerializeObject(list_trabajador, Formatting.Indented);
            File.WriteAllText("trabajadores.json", trabajadoresJson);
        }

    }

}
