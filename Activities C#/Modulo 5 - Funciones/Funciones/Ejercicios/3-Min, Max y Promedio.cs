using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Ejercicios
{
    /*
    Implementa una funci�n, llamada ObtenerMinMaxPromedio, que reciba un arreglo de enteros, y devuelva el valor m�ximo de dicho arreglo, 
    el valor m�nimo, y el valor promedio.

    Para este ejercicio, utilizaremos par�metros out para extraer los tres valores.

    La funci�n devolver� true si el arreglo de enteros tiene al menos un elemento, si tiene cero elementos devolver� false.

    El orden de los par�metros es: int[] numeros, int minimo, int maximo, double promedio

    Nota: debes de colocar out en los par�metros adecuados.
     */

    public class MinMaxPromedio
    {
        // Tu c�digo debajo de esta l�nea
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
