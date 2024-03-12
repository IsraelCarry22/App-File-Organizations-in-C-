using App_File_Organizations_in_C_.Interfaz;
using System.Windows.Forms;

namespace App_File_Organizations_in_C_.Clases
{
    public class OrganizaciónAccesoAleatorio : IOrganización
    {
        public int Count => organizationsHash.Count;
        private OrganizaciónHash organizationsHash;

        public OrganizaciónAccesoAleatorio()
        {
            organizationsHash = new OrganizaciónHash();
        }

        public void Add(Alumno alumno)
        {
            organizationsHash.Add(alumno);

            Update();
        }

        public void Delete(int id)
        {
            organizationsHash.Delete(id);

            Update();
        }

        public void Search(int id, DataGridView dataGridView)
        {
            organizationsHash.Search(id, dataGridView);
        }

        public void Edit(int id, Alumno nuevoAlumno)
        {
            organizationsHash.Edit(id, nuevoAlumno);
        }

        public void Show(DataGridView dataGridView)
        {
            organizationsHash.Show(dataGridView);
        }

        private void Update()
        {
            organizationsHash.Update();
        }
    }
}
