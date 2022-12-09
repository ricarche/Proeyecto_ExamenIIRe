﻿using Examen2.Modelos.ConexionBD;
using Examen2.Modelos.Entidades;
using Examen2.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2.Controladores
{
    public class LoginController
    {
        Login vista;

        public LoginController(Login view)
        {
            vista = view;

            vista.AceptarButton.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Email = vista.EmailTextBox.Text;
            user.Clave = EncriptarClave(vista.ClaveTextBox.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");

                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();


            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }

        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}

