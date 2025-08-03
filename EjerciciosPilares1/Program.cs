// See https://aka.ms/new-console-template for more information
using EjerciciosPilares1.Clases.Ejercicio1;
class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado();

        empleado.Nombre = "Marvin";
        empleado.Salario = 3500.75;
        Console.WriteLine("-------Empleado-------");
        Console.WriteLine("Nombre del empleado: " + empleado.Nombre);
        Console.WriteLine("Salario del empleado: Q" + empleado.Salario);


        CuentaBancaria cuenta = new CuentaBancaria(500);

        Console.WriteLine("-------Cuenta Bancaria-------");

        cuenta.Depositar(1000);
        Console.WriteLine("Saldo actual: Q" + cuenta.ObtenerSaldo());

        cuenta.Retirar(600);
        Console.WriteLine("Intento de retirar Q600 (mayor al límite): Q" + cuenta.LimiteRetiroDiario);

        cuenta.Retirar(300);
        Console.WriteLine("Retiro de Q300:");

        cuenta.LimiteRetiroDiario = 800;
        Console.WriteLine("Nuevo límite de retiro diario: Q" + cuenta.LimiteRetiroDiario);

        cuenta.Retirar(500);
        Console.WriteLine("Retiro de Q500: Q");


        Console.WriteLine("-------Cuenta Vehiculo-------");

        Vehiculo auto = new Vehiculo();

        Console.WriteLine("¿Está encendido? " + auto.estaEncendido());

        auto.Encender();
        Console.WriteLine("¿Está encendido después de encender? " + auto.estaEncendido());

        auto.Apagar();
        Console.WriteLine("¿Está encendido después de apagar? " + auto.estaEncendido());
    }
}
