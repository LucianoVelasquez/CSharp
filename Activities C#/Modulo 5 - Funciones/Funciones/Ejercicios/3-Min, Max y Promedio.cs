using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Implementa una función, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor máximo de dicho arreglo, 
    el valor mínimo, y el valor promedio.

    Para este ejercicio, utilizaremos parámetros out para extraer los tres valores.

    La función devolverá true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolverá false.

    El orden de los parámetros es: int[] numeros, int minimo, int maximo, double promedio

    Nota: debes de colocar out en los parámetros adecuados.
     */

    public class MinMaxPromedio
    {
        // Tu código debajo de esta línea
        bool ObtenerMinMaxPromedio(int[] numer, out int minimo, out int maximo, out double promedio)
        {

            minimo = 0;
            maximo = 0;
            int suma = 0;
            promedio = 0.0;

            if (numer.Length == 0)
            {
                return false;
            }

            minimo = 9999;
            maximo = 0;
            suma = 0;
            promedio = 0.0;

            for (int i = 0; i < numer.LongLength; i++)
            {
                if(minimo > numer[i]) minimo = numer[i];
                if(maximo < numer[i]) maximo = numer[i];
                suma += numer[i];
            }

            promedio = suma / numer.Length;

            return numer.Length > 0 ? true : false;
        
        }
    }
}
