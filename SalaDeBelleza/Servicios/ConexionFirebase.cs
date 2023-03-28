using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace SalaDeBelleza.Servicios
{
    public class ConexionFirebase
    {
        public static FirebaseClient FirebaseClient = new FirebaseClient("https://sala-de-bellesa-cc0e5-default-rtdb.firebaseio.com");

        
    }
}
