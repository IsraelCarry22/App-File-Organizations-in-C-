namespace App_File_Organizations_in_C_.Clases
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Unidad1 { get; set; }
        public int Unidad2 { get; set; }
        public int Unidad3 { get; set; }

        public decimal Promedio { get { return (Unidad1 + Unidad2 + Unidad3) / 3; } }
    }
}
