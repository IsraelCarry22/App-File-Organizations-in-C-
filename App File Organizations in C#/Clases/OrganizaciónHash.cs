using App_File_Organizations_in_C_.Interfaz;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_File_Organizations_in_C_.Clases
{
    public class OrganizaciónHash : IOrganización
    {
        public int Count => hashTable.Count;
        private Dictionary<int, Alumno> hashTable;

        public OrganizaciónHash()
        {
            hashTable = new Dictionary<int, Alumno>();
        }

        public void Add(Alumno alumno)
        {
            hashTable.Add(alumno.Id, alumno);

            Update();
        }

        public void Delete(int id)
        {
            if (hashTable.ContainsKey(id))
            {
                hashTable.Remove(id);

                Update();
            }
        }

        public void Search(int id, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            if (hashTable.TryGetValue(id, out Alumno alumnoEncontrado))
            {
                dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Nombre, alumnoEncontrado.Apellido, alumnoEncontrado.Unidad1, alumnoEncontrado.Unidad2, alumnoEncontrado.Unidad3, alumnoEncontrado.Promedio);
            }
        }

        public void Edit(int id, Alumno nuevoAlumno)
        {
            if (hashTable.ContainsKey(id))
            {
                hashTable[id] = nuevoAlumno;
            }
        }

        public void Show(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            foreach (var alumno in hashTable.Values)
            {
                dataGridView.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio);
            }
        }

        public void Update()
        {
            int id = 0;
            foreach (var alumno in hashTable.Values)
            {
                alumno.Id = id++;
            }
        }
    }
}
