using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionFinanciera
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCliente;
            int numeroDeCuenta;
            double saldoCuentaInicial;
            double consignacionCuenta;
            string validacionCaracter;
            double retiroCuenta;
            double saldoTotal;
            Console.WriteLine("Bienvenido querido Cliente, Digite su nombre: ");
            nombreCliente=Console.ReadLine();
            Console.WriteLine("Digite su numero de Cuenta: ");
            numeroDeCuenta=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Establezca su saldo inicial: ");
            saldoCuentaInicial=double.Parse(Console.ReadLine());
            Console.WriteLine(" Desea hacer una consignacion Si(S) o No (N): ");
            validacionCaracter=Console.ReadLine();
            if (validacionCaracter.ToUpper() == "S")
            {
                Console.WriteLine("Digite el monto a consignar: ");
                consignacionCuenta = Double.Parse(Console.ReadLine());
                saldoTotal = saldoCuentaInicial + consignacionCuenta;
            }
            else
            {
               consignacionCuenta = 0;
                saldoTotal = saldoCuentaInicial;
            }
            Console.WriteLine(" Desea hacer un retiro Si(S) o No (N): ");
            validacionCaracter=Console.ReadLine();
            if (validacionCaracter.ToUpper() == "S")
            {
                Console.WriteLine("Digite el monto a consignar: ");
                retiroCuenta = Double.Parse(Console.ReadLine());
                saldoTotal = saldoTotal- retiroCuenta;
            }
            else
            {
                retiroCuenta = 0;
                saldoTotal = saldoCuentaInicial;
            }
            Console.WriteLine($"|||Su nombre es: {nombreCliente} ||| Su numero de cuenta es: {numeroDeCuenta}" +
                $" ||| Su saldo inicial fue de: {saldoCuentaInicial} ||| ");
            Console.WriteLine($"|||Hizo una consignacion de {consignacionCuenta} " +
                $"||| Hizo un retiro de {retiroCuenta} ||| Su saldo final es: {saldoTotal}||| ");
            Console.ReadKey();
        }
    }
}
