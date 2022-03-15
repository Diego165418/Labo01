using System;

namespace Calculadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int dato;
            do
            {
                Console.WriteLine("\n----------Seleccione operacion: ----------");
                Console.WriteLine("1. suma \n2. resta \n3.multiplicacion \n4.division \n0.Salir del menu.");
                dato = Convert.ToInt32(Console.ReadLine());
                
                switch (dato) 
                {
                case 1:
                    Console.Write("\nIngrese primer numero: ");
                    int dato1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese segundo numero: ");
                    int dato2 = Convert.ToInt32(Console.ReadLine());
                    int suma = dato1 + dato2;
                    Console.WriteLine($"La suma de {dato1} + {dato2} es {suma}");
                    
                    break;
                case 2:
                    Console.WriteLine("\nIngrese primer numero: ");
                    int  resta1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo numero: "); 
                    int  resta2 = Convert.ToInt32(Console.ReadLine());
                    int resta = resta1 - resta2;
                    Console.WriteLine($"La resta entre {resta1} menos {resta2} es {resta}");
                    
                    break;
                case 3:
                    Console.WriteLine("\nIngrese primer numero: ");
                    int  multiplicacion1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo numero: ");   
                    int  multiplicacion2 = Convert.ToInt32(Console.ReadLine());
                    int multiplicacion = multiplicacion1 * multiplicacion2;
                    Console.WriteLine($"La multiplicacion entre {multiplicacion1} y {multiplicacion2} es {multiplicacion}");
                    
                    break;
                case 4:
                    Console.WriteLine("\nIngrese primer numero: ");
                    double  divicion1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese segundo numero: ");
                    double divicion2 = Convert.ToInt32(Console.ReadLine());

                    if (divicion1 == 0  && divicion2 ==0)
                    {
                        Console.WriteLine($"La divicion entre {divicion1} y {divicion2} no se puede realizar");
                    }else if (divicion2 == 0)
                    {
                        do
                        {
                            Console.WriteLine("\nIngreso cero como divisor, imposible efectuar, elija otro numero: ");
                            divicion2 = Convert.ToInt32(Console.ReadLine());
                        } while (divicion2 == 0);
                        double divicion = divicion1 / divicion2;
                        Console.WriteLine($"La divicion entre {divicion1} y {divicion2} es {divicion}");
                    }
                    break;
                }
                
            } while (dato != 0);
        }
    }
}