using System.Linq;
using System;
using System.Data;
using System.Collections.Generic;

namespace AccesoDatos.DataBase
{
    
    public class ClassData
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        //Esta instancia/objeto representa la conexión a la base de datos y se utiliza para realizar consultas y actualizaciones.

        /*private string nombreTa bla, mensajeError, valorScalar, nombreDB;
        private bool scalar;

        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public string ValorScalar { get => valorScalar; set => valorScalar = value; }
        public string NombreDB { get => nombreDB; set => nombreDB = value; }
        public bool Scalar { get => scalar; set => scalar = value; }

        public ClassData() 
        {
        }*/

        //DataClasses1DataContext db = new DataClasses1DataContext();

        //var listempleados = from d in db.employees                    
        //select d.department_id; 




        public List<employees> listar()
        {//Este método devuelve una lista de objetos employees. Primero, se obtienen todos los registros de la tabla “employees” de la base de datos (db.employees.ToList()),
         //y luego se devuelven como una lista.
            List<employees> list = db.employees.ToList();
            //Significa que va a ir a la tabla employes de la db y traerá/convertirá los datos en un listado 
            //y lo almacenará en "list"
            return list;
        }
        public employees obtener(int key)
        {//Este método devuelve una lista de objetos employees. Primero, se obtienen todos los registros de la tabla “employees” de la base de datos (db.employees.ToList()),
         //y luego se devuelven como una lista.
            employees list = db.employees.Single(r=>r.employee_id==key);
            //Significa que va a ir a la tabla employes de la db y traerá/convertirá los datos en un listado 
            //y lo almacenará en "list"
            return list;
        }




        //Crear un método para registrar datos
        /*Este método se utiliza para registrar nuevos datos en la tabla “employees”. 
         * El parámetro objprueba es un objeto de tipo employees que contiene los datos a insertar. 
         * La línea db.employees.InsertOnSubmit(objprueba); agrega el objeto a la cola de inserción, 
         * pero aún no se realiza la inserción en la base de datos.
         * */
        public void registrar(employees objprueba)
        {//todo lo que se escriba en "objprueba" se va a registrar en db.employes
            db.employees.InsertOnSubmit(objprueba);
        }
        //Método para actualizar
        /*Este método se utiliza para actualizar datos existentes en la tabla “employees”. 
         * Primero, se busca un registro específico en función del employee_id proporcionado 
         * (employees objactualiza = db.employees.Single(r => r.employee_id == objprueba.employee_id);).
         * Luego, se actualizan las columnas first_name y last_name con los valores del objeto objprueba. 
         * Finalmente, db.SubmitChanges(); confirma los cambios en la base de datos.
         * */
        public void actualizar(employees objprueba) 
        { 
            employees objactualiza = db.employees.Single(r => r.employee_id == objprueba.employee_id);
            //Finalmente, guardamos el registro encontrado a la variable objactualiza.
            //Esto nos permite trabajar con los valores de ese registro específico para realizar actualizaciones o cambios.
            objactualiza.first_name = objprueba.first_name;
            objactualiza.last_name = objprueba.last_name;
            objactualiza.email = objprueba.email;
            objactualiza.phone_number = objprueba.phone_number;
            db.SubmitChanges();//realiza los cambios

            /*En resumen, esta línea busca un empleado específico en la base de datos según su employee_id y 
             * almacena ese registro en la variable objactualiza.
             * Luego, podemos modificar los valores de las columnas (como first_name y last_name) en ese registro si es necesario
             * */
        }

        public void eliminar(int key)
        {
            employees objEliminado = db.employees.Single(r => r.employee_id == key);
            db.employees.DeleteOnSubmit(objEliminado);
            db.SubmitChanges();//realiza los cambios

        }


    }

    

}
