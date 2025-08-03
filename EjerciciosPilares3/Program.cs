// See https://aka.ms/new-console-template for more information
using EjerciciosPilares3.Clases;


class Program
{
    static void Main()
    {
        Console.WriteLine("-------Notificacion-------");
        List<Notificacion> lista = new List<Notificacion>();

        lista.Add(new NotificacionEmail());
        lista.Add(new NotificacionSMS());
        lista.Add(new NotificacionPush());

        foreach (Notificacion n in lista)
        {
            n.Enviar();
        }

        Console.WriteLine("-------Comando de Voz-------");
        static void EjecutarComandos(List<ComandoVoz> comandos)
        {
            foreach (ComandoVoz comando in comandos)
            {
                comando.Ejecutar();
            }
        }

        List<ComandoVoz> comandos = new List<ComandoVoz>();

        comandos.Add(new EncenderLuces());
        comandos.Add(new ReproducirMusica());
        comandos.Add(new MostrarClima());

        EjecutarComandos(comandos);

        Console.WriteLine("-------Pagos-------");
        List<Pago> pagos = new List<Pago>();

        pagos.Add(new PagoConTarjeta());
        pagos.Add(new PagoConEfectivo());
        pagos.Add(new PagoConTransferencia());

        foreach (Pago pago in pagos)
        {
            pago.ProcesarPago();
        }
    }
}
