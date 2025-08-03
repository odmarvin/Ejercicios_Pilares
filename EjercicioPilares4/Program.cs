// See https://aka.ms/new-console-template for more information
using EjercicioPilares4.Clases;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------Archivo Multimedia-------");
        List<ArchivoMultimedia> lista = new List<ArchivoMultimedia>();
        lista.Add(new Video());
        lista.Add(new Cancion());
        lista.Add(new AudioLibro());

        foreach (ArchivoMultimedia archivo in lista)
        {
            archivo.Reproducir();
        }

        Console.WriteLine("-------Validador-------");
        List<IValidador> validadores = new List<IValidador>();
        validadores.Add(new ValidadorEmail());
        validadores.Add(new ValidadorTelefono());
        validadores.Add(new ValidadorDPI());

        string[] datos = { "usuario@gmail.com", "12345678", "1234567891234", "datoIncorrecto" };

        foreach (string dato in datos)
        {
            Console.WriteLine("\nValidando: " + dato);
            foreach (IValidador validador in validadores)
            {
                Console.WriteLine("- ¿Es válido? " + validador.GetType().Name + ": " + validador.EsValido(dato));
            }
        }

        Console.WriteLine("-------Dispositivo-------");
        List<DispositivoSalida> dispositivos = new List<DispositivoSalida>();
        dispositivos.Add(new Pantalla());
        dispositivos.Add(new Proyector());
        dispositivos.Add(new Impresora());

        foreach (DispositivoSalida d in dispositivos)
        {
            d.MostrarMensaje("Marvin Oliva");
        }
    }
}
