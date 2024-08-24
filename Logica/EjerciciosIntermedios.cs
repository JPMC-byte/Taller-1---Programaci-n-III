using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica
{
    public class EjerciciosIntermedios
    {
        public List<List<int>> LogicaPermutacionesPosibles(List<int> Lista)
        {
            List<List<int>> Resultados = new List<List<int>>();
            Permutar(Lista, 0);
            return Resultados;

            void Permutar(List<int> ListaPermutar, int Indice)
            {
                if (Indice >= ListaPermutar.Count)
                {
                    Resultados.Add(new List<int>(ListaPermutar));
                }
                else
                {
                    for (int i = Indice; i < ListaPermutar.Count; i++)
                    {
                        Intercambiar(ListaPermutar, Indice, i);

                        Permutar(ListaPermutar, Indice + 1);

                        Intercambiar(ListaPermutar, Indice, i);
                    }
                }
            }

            void Intercambiar(List<int> ListaPermutar, int Indice, int i)
            {
                int temp = ListaPermutar[Indice];
                ListaPermutar[Indice] = ListaPermutar[i];
                Lista[i] = temp;
            }
        }
    }
}
