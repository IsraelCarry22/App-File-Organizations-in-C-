using App_File_Organizations_in_C_.Clases;
using System.Windows.Forms;

namespace App_File_Organizations_in_C_.Interfaz
{
    public interface IOrganización
    {
        int Count { get; }
        void Add(Alumno alumno);
        void Delete(int id);
        void Search(int id, DataGridView dataGridView);
        void Edit(int id, Alumno nuevoAlumno);
        void Show(DataGridView dataGridView);
    }
}
