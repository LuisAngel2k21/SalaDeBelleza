using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SalaDeBelleza.Models;
using Firebase.Database;
using SalaDeBelleza.Servicios;
using Firebase.Database.Query;

namespace SalaDeBelleza.ViewModels
{
    internal class VMUsuario
    {
        List<Usuarios> usuarioData = new List<Usuarios> ();

        public async Task<List<Usuarios>> Mostrar_Usuarios()
        {
            var usuario = await ConexionFirebase.FirebaseClient
                .Child("Usuarios")
                .OnceAsync<Usuarios>();

            foreach (var user in usuario)
            {
                Usuarios musuario = new Usuarios();
                musuario.id = user.Key;
                musuario.Nombres = user.Object.Nombres;
                musuario.Correo = user.Object.Correo;
                musuario.Descripcion = user.Object.Descripcion;
                musuario.Foto = user.Object.Foto;

                usuarioData.Add(musuario);

            }
            return usuarioData;

        }

        //insertar nuevo usuario

        public async Task InsertarUsuario(Usuarios parametro)
        {
            await ConexionFirebase.FirebaseClient
                .Child("Usuarios")
                .PutAsync(new Usuarios()
                {
                    Nombres = parametro.Nombres,
                    Correo = parametro.Correo,
                    Descripcion = parametro.Descripcion,
                    Foto = parametro.Foto

                });

        }

    }
}
