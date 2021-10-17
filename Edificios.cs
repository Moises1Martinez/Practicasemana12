using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Practicasemana12
{
    class Edificios
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string cantDepartamentos { get; set; }
        public string depRentados { get; set; }

        private CRUD crud = new CRUD();

        //metodo para retornar los registros de la tabla de estudiantes
        public MySqlDataReader getAllEdificio()
        {
            string query = "SELECT edificio,nombre,cantDepartamentos,depRentados";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditEdificio(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO edificio(nombre, direccion, cantDepartmentos, depRentados )" +
                    "VALUES ('" + nombre + "', '" + direccion + "', '" + cantDepartamentos + "', '" + depRentados +  "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE edificio SET "
                    + "Nombre='" + nombre + "' ,"
                    + "Direccion='" + direccion + "',"
                    + "cantDepartamentos='" + cantDepartamentos + "',"
                    + "depRentados='" + depRentados + "'";
                    

                crud.executeQuery(query);
                return true;
            }

            return false;
        }
        public Boolean deleteEdificio()
        {
            string query = "DELETE FROM edificio WHERE IdStudent='" + nombre + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
