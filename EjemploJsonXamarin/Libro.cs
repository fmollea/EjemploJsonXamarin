namespace EjemploJsonXamarin
{
    public class Libro
    {
        public string autor { get; set; }
        public string nombre { get; set; }

        public Libro() { }

        public Libro(string pAutor, string pNombre)
        {
            autor = pAutor;
            nombre = pNombre;
        }

        public override string ToString()
        {
            return "Autor {0}, Nombre {1}";
        }
    }
}