using App_File_Organizations_in_C_.Clases;
using App_File_Organizations_in_C_.Interfaz;
using App_Reporting_Information_in_C_.Class;
using System;
using System.Windows.Forms;

namespace App_File_Organizations_in_C_
{
    public partial class Form1 : Form
    {
        public string filePath;
        public IOrganización Alumnos;

        public Form1()
        {
            InitializeComponent();
            Alumnos = new OrganizaciónSecuencial();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (NombreTXTisNull() && ApellidoTXTisNull())
            {
                return;
            }

            if (Unidad1TXTisNull() && Unidad2TXTisNull() && Unidad3TXTisNull())
            {
                return;
            }

            var alumno = new Alumno();

            alumno.Id = ListFilesData.RowCount;
            alumno.Nombre = NombreTXT.Text;
            alumno.Apellido = ApellidoTXT.Text;
            alumno.Unidad1 = int.Parse(Unidad1TXT.Text);
            alumno.Unidad2 = int.Parse(Unidad2TXT.Text);
            alumno.Unidad3 = int.Parse(Unidad3TXT.Text);

            Alumnos.Add(alumno);

            ListFilesData.Rows.Add(alumno.Id, alumno.Nombre, alumno.Apellido, alumno.Unidad1, alumno.Unidad2, alumno.Unidad3, alumno.Promedio);

            IDTXT.Clear();
            NombreTXT.Clear();
            ApellidoTXT.Clear();
            Unidad1TXT.Clear();
            Unidad2TXT.Clear();
            Unidad3TXT.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDTXT.Text, out int IdDelete))
            {
                Alumnos.Delete(IdDelete);
            }
            else if (Alumnos.Count > 0)
            {
                Alumnos.Delete(Alumnos.Count - 1);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDTXT.Text, out int IdEdit))
            {
                var alumno = new Alumno();

                alumno.Nombre = NombreTXT.Text;
                alumno.Apellido = ApellidoTXT.Text;
                alumno.Unidad1 = int.Parse(Unidad1TXT.Text);
                alumno.Unidad2 = int.Parse(Unidad2TXT.Text);
                alumno.Unidad3 = int.Parse(Unidad3TXT.Text);

                Alumnos.Edit(IdEdit, alumno);

                IDTXT.Clear();
                NombreTXT.Clear();
                ApellidoTXT.Clear();
                Unidad1TXT.Clear();
                Unidad2TXT.Clear();
                Unidad3TXT.Clear();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDTXT.Text, out int IdSearch))
            {
                ListFilesData.Rows.Clear();

                Alumnos.Search(IdSearch, ListFilesData);

                IDTXT.Clear();
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            ListFilesData.Rows.Clear();

            Alumnos.Show(ListFilesData);
        }

        private void SequenciesMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos = new OrganizaciónSecuencial();

            Alumnos.Show(ListFilesData);
        }

        private void HashMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos = new OrganizaciónHash();

            Alumnos.Show(ListFilesData);
        }

        private void AccesoAleatorioMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos = new OrganizaciónAccesoAleatorio();

            Alumnos.Show(ListFilesData);
        }

        public bool Dialog(bool IsOpenOrSave,ref string filePath, string filter)
        {
            if (IsOpenOrSave)
            {
                var fileDialog = new OpenFileDialog
                {
                    Filter = filter
                };

                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return true;
                }

                filePath = fileDialog.FileName;

                return false;
            }
            else
            {
                var saveFileTem = new SaveFileDialog { Filter = filter };

                if (saveFileTem.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show($"Operación Cancelada por el usuario", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return true;
                }

                filePath = saveFileTem.FileName;

                return false;
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            ListFilesData.Rows.Clear();
            ListFilesData.Columns.Clear();

            if (Dialog(true, ref filePath, "Archivos CSV (*.csv)|*.csv"))
            {
                return;
            }

            Open_Save.GetFileExtension(true, ref filePath, ListFilesData);
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (ListFilesData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                if (Dialog(false, ref filePath, "Archivos CSV (*.csv)|*.csv"))
                {
                    return;
                }

                Open_Save.GetFileExtension(false, ref filePath, ListFilesData);
            }
            else
            {
                Open_Save.GetFileExtension(false, ref filePath, ListFilesData);
            }
        }

        private void SaveHowMenuItem_Click(object sender, EventArgs e)
        {
            if (ListFilesData.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Dialog(false, ref filePath, "Archivos CSV (*.csv)|*.csv"))
            {
                return;
            }

            Open_Save.GetFileExtension(false, ref filePath, ListFilesData);
        }

        public bool NombreTXTisNull()
        {
            return string.IsNullOrEmpty(NombreTXT.Text);
        }

        public bool ApellidoTXTisNull()
        {
            return string.IsNullOrEmpty(ApellidoTXT.Text);
        }

        public bool Unidad1TXTisNull()
        {
            return string.IsNullOrEmpty(Unidad1TXT.Text);
        }

        public bool Unidad2TXTisNull()
        {
            return string.IsNullOrEmpty(Unidad2TXT.Text);
        }

        public bool Unidad3TXTisNull()
        {
            return string.IsNullOrEmpty(Unidad3TXT.Text);
        }
    }
}
