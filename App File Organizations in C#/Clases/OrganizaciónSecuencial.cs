using App_File_Organizations_in_C_.Interfaz;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_File_Organizations_in_C_.Clases
{
    public class OrganizaciónSecuencial : IOrganización
    {
        public int Count => alumnos.Count;
        private List<Alumno> alumnos;

        public OrganizaciónSecuencial()
        {
            alumnos = new List<Alumno>();
        }

        public void Add(Alumno alumno)
        {
            alumnos.Add(alumno);

            Update();
        }

        public void Delete(int id)
        {
            Alumno alumno = alumnos.Find(a => a.Id == id);
            if (alumno != null)
            {
                alumnos.Remove(alumno);

                Update();
            }
        }

        public void Search(int id, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            Alumno alumnoEncontrado = alumnos.Find(a => a.Id == id);
            if (alumnoEncontrado != null)
            {
                dataGridView.Rows.Add(alumnoEncontrado.Id, alumnoEncontrado.Nombre, alumnoEncontrado.Apellido, alumnoEncontrado.Unidad1, alumnoEncontrado.Unidad2, alumnoEncontrado.Unidad3, alumnoEncontrado.Promedio);
            }
        }

        public void Edit(int id, Alumno nuevoAlumno)
        {
            int index = alumnos.FindIndex(a => a.Id == id);
            if (index != -1)
            {
                alumnos[index] = nuevoAlumno;
            }
        }

        public void Show(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            foreach (var alumno in alumnos)
            {
                dataGridView.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio);
            }
        }

        private void Update()
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                alumnos[i].Id = i;
            }
        }
    }
}
