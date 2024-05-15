using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;
        //constructor
        public clsVector() { 
        vector= new int [100];
        lg = 0;
        }
        //metodos (procedimiento y funciones)
        public void adicionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        // Longitud del vector
        public int longitud() {
            return lg;
        }
        // invertir los elementos del vector
        public void invertir() {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad) {
                aux = vector[fin - i];
                vector[fin-i]= vector[i];
                vector[i]=aux;
                i++;
            }
        }
        //Cantidad de elementos pares
        public int contarNumerosPares(){
            int contador = 0;
            for (int i = 0; i < lg; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    contador++;
                }
            }
            return contador;
        }
        //Ordenar los elemnetos del vector de menor a mayor
        public void ordenarVector(){
            for (int i = 0; i < lg - 1; i++){
                for (int j = 0; j < lg - i - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        // Intercambiar vector[j] y vector[j+1]
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
        }
        //eliminar elementos pos. p
        public void eliminarElementosPos(int p){
            for (int i = p - 1; i <lg; i++){
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }
        //contar numeros impares
        public int contarNumerosImpares(){
            int contador = 0;
            for (int i = 0; i < lg; i++)
            {
                if (vector[i] % 2 != 0)
                {
                    contador++;
                }
            }
            return contador;
        }
        //contar numeros capicua
        public int contarNumerosCapicua()
        {
            int contador = 0;
            for (int i = 0; i < lg; i++)
            {
                if (esCapicua(vector[i]))
                {
                    contador++;
                }
            }
            return contador;
        }

        public Boolean esCapicua(int numero)
        {
            int numeroAbsoluto = Math.Abs(numero); // Tomamos el valor absoluto para manejar números negativos
            int reverso = 0;
            int temp = numeroAbsoluto;
            while (temp != 0)
            {
                int ultimoDigito = temp % 10;
                reverso = reverso * 10 + ultimoDigito;
                temp = temp / 10;
            }
            return numeroAbsoluto == reverso;
        }
        //contar numeros primos
        public int contarNumerosPrimos()
        {
            int contador = 0;
            for (int i = 0; i < lg; i++)
            {
                if (esPrimo(vector[i]))
                {
                    contador++;
                }
            }
            return contador;
        }

        public Boolean esPrimo(int numero)
        {
            if (numero < 1)
            {
                return false;
            }
            if (numero == 1)
            {
                return true; // Consideramos el número uno como primo
            }
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //invertir cada elemento
        public void invertirCadaElementos()
        {
            for (int i = 0; i < lg; i++)
            {
                vector[i] = invertirNumero(vector[i]);
            }
        }

        public int invertirNumero(int numero)
        {
            int numeroInvertido = 0;
            while (numero != 0)
            {
                int digito = numero % 10;
                numeroInvertido = numeroInvertido * 10 + digito;
                numero /= 10;
            }
            return numeroInvertido;
        }

        public int contarElementos()
        {
            return vector.Length;
        }







    }
}
