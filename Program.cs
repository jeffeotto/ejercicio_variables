using System;

namespace ejercicio_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = "Jefferson";
            var apellido1 = "Otto";
            var apellido2 = "Gonsalves";

            int dia = 09;
            int mes = 10;
            int year = 1972;

            //Output Nombre empezando por appelidos
            Console.WriteLine(apellido1 + " " + apellido2 + " " + nombre);
            //Output fecha nacimiemto + /
            Console.WriteLine(dia + "/" + mes + "/" + year);


            //Calculo de cuantos años bisiestos hay entre 1948 y mi año de nacmiento
            const int leap = 1948;
            const int leapInterval = 4;

            var result = (year - leap) / leapInterval;
            Console.WriteLine(result);



           
            //Output los años bisiestos desde 1948 hasta 1972
            for (var i = leap; i <= year; i += 4)
            {
                Console.WriteLine(i);
            }


            //Variables para testeo del año de nacimiento
            var fraseLeap = "Mi año de nacimiento es bisiesto.";
            var fraseNoLeap = "Mi año de nacimiento no es bisiesto.";
            var leapYear = 1948;
            var nameFrase = $"Mi nonmbre es {nombre} {apellido1} {apellido2}";
            var bornFrase = $"Nací el {dia}/{mes}/{year}";
            bool isLeap = false;
            var leapFinalFrase = nameFrase + Environment.NewLine + bornFrase + Environment.NewLine + fraseLeap;
            var notLeapFinalFrase = nameFrase + Environment.NewLine + bornFrase + Environment.NewLine + fraseNoLeap;



            /*Bucle de testeo para verificar si el año es bisiesto
             más output de las frases con nombre, fecha de nacimiento
             y si el año es bisiesto o no.*/
            
            while (leapYear <= year && isLeap == false)
            {

                if (leapYear == year)
                {
                    Console.WriteLine(leapFinalFrase);
                    isLeap = true;

                }

                leapYear += 4;

            }


            if (isLeap == false)
            {
                Console.WriteLine(notLeapFinalFrase);
            }
        }
    }
}
