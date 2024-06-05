
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace ProgramasCondiciones.Class
{
    public class Imprimir
    {
        public void ProgramasCondiciones()
        {
            float primerNumero = 0;
            float segundoNumero = 0;

            try
            {
              Console.WriteLine($"Ingrese el primer numero: ");
              primerNumero = Convert.ToInt32( Console.ReadLine() );

              Console.WriteLine($"Ingrese el segundo numero: ");
              segundoNumero = Convert.ToInt32( Console.ReadLine() );

                if (primerNumero > segundoNumero) 
                {
                    float resultadoSuma = primerNumero + segundoNumero;
                    float resultadoResta = primerNumero - segundoNumero;

                    Console.WriteLine($"El resultado de la suma de los dos valores es: { resultadoSuma}");
                    Console.WriteLine($"El resultado de la resta de los dos valores es: { resultadoResta}");

                }
                else if (primerNumero < segundoNumero) 
                {
                    float resultadoProducto = primerNumero * segundoNumero;
                    float resultadoDivision = primerNumero / segundoNumero;

                    Console.WriteLine($"El resultado de el producto de los dos valores es: { resultadoProducto}");
                    Console.WriteLine($"El resultado de la division de los dos valores es: { resultadoDivision}");
                }
                else if (primerNumero == segundoNumero) { Console.WriteLine("Los valores son iguales"); }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hubo un eror: { ex.Message}");
            }
        }

        public void PromedioNotas() 
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;

            try
            {
                Console.WriteLine("Ingrese la primera nota: ");
                nota1 = Convert.ToInt32(Console.ReadLine());

                if (nota1 > 10 || nota1 < 0)
                {
                    throw new Exception("Las notas ingresadas deben ser del 1 al 10");
                }

                Console.WriteLine("Ingrese la segunda nota");
                nota2 = Convert.ToInt32(Console.ReadLine());

                if (nota2 > 10 || nota2 < 0)
                {
                    throw new Exception("Las notas ingresadas deben ser del 1 al 10");
                }

                Console.WriteLine("Ingrese la tercera nota");
                nota3 = Convert.ToInt32(Console.ReadLine());

                if (nota3 > 10 || nota3 < 0)
                {
                    throw new Exception("La notas ingresadas deben ser del 1 al 10");
                }

                float totalNotas = (nota1 + nota2 + nota3);
                float promedio = totalNotas / 3;

                if(promedio >= 7) 
                {
                    Console.WriteLine($"Promocionado!!!. Tu promedio es: { promedio}");
                }
                else { Console.WriteLine("Reprobaste. Debes mejorar para la proxima"); }
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }

        }
        public void ProgramaDigitos() 
        {
            int numeroIngresado = 0;

            try
            {
                Console.WriteLine("Ingrese un numero del 1 al 99");
                numeroIngresado = Convert.ToInt32( Console.ReadLine());

                if (numeroIngresado > 99 || numeroIngresado < 1) 
                {
                    throw new Exception("El numero ingresado no esta dentro de los numeros requeriros (1 al 99).");   
                }
                
                if(numeroIngresado / 10 == 0) 
                {
                    Console.WriteLine("El numero ingresado tiene solo 1 digito");
                }
                else
                    Console.WriteLine("El numero ingresado tiene 2 digitos");
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
        }
    }
}
