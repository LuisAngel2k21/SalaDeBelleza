using SalaDeBelleza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SalaDeBelleza.ViewModels;

namespace SalaDeBelleza.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPerfil : ContentPage
    {
        public MyPerfil()
        {
            InitializeComponent();
        }

        private void btnagregarimagen_Clicked(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {

        }
        
        private async Task guardarContacto()
        {

            Usuarios musuario = new Usuarios();
            VMUsuario metodo = new VMUsuario();

            musuario.Nombres = Nombre.Text;
            musuario.Correo = Correo.Text;  
            musuario.Descripcion = Descripcion.Text;
            musuario.Foto = "--";

            await metodo.InsertarUsuario(musuario);
            await DisplayAlert("alert", "Usuario Guardado Exitosamente", "OK");


        }



        private void btncerrar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            guardarContacto();
        }
    }
}