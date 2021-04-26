﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Negocios
{
    class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //CADENAS PABLO

        string cadenaConexionFede = "data source=DESKTOP-EHB4SN8; initial catalog=CATALOGO_DB; integrated security=TRUE";
        string cadenaConexionPablo = "data source = (local)\\SQLEXPRESS; initial catalog =CATALOGO_DB; integrated security = true;";

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexionPablo); 
            comando = new SqlCommand(); 
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        internal void ejectutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }


    }
}