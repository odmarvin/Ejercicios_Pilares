// See https://aka.ms/new-console-template for more information

using EjerciciosPilares2.Clases;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------Empleado-------");

        Gerente gerente = new Gerente();
        gerente.Nombre = "Marvin";
        gerente.Salario = 8000;
        gerente.TomarDecision();

        Desarrollador dev = new Desarrollador();
        dev.Nombre = "Oliva";
        dev.Salario = 5000;
        dev.Programar();


        Console.WriteLine("-------Vehiculo-------");

        Auto auto = new Auto();
        auto.Encender();
        Console.WriteLine("¿Auto encendido? " + auto.estaEncendido());
        auto.EncenderRadio();
        auto.Apagar();

        Motocicleta moto = new Motocicleta();
        moto.Encender();
        Console.WriteLine("¿Motocicleta encendida? " + moto.estaEncendido());
        moto.EncenderLuces();
        moto.Apagar();

        Console.WriteLine("-------Cuenta Bancaria-------");
        CuentaAhorro ahorro = new CuentaAhorro(3000);
        ahorro.Depositar(2000);
        Console.WriteLine("Cuenta Ahorro - Saldo: Q" + ahorro.ObtenerSaldo());
        Console.WriteLine("Interés generado: Q" + ahorro.CalcularIntereses());

        Console.WriteLine();

        CuentaCorriente corriente = new CuentaCorriente(3000);
        corriente.Depositar(2000);
        Console.WriteLine("Cuenta Corriente - Saldo: Q" + corriente.ObtenerSaldo());
        Console.WriteLine("Interés generado: Q" + corriente.CalcularIntereses());
    }
}
