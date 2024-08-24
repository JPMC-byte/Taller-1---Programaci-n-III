using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica
{
    public class EjerciciosBasicos
    {
        PersistenciaBasica PersistenciaBasica = new PersistenciaBasica();
        public String LogicaListaOrdenada(List<int> List)
        {
            bool Asc = true, Desc = true;
            for (int i = 0; i < List.Count - 1; i++)
            {
                if (List[i] > List[i + 1])
                {
                    Asc = false;
                }
                if (List[i] < List[i + 1])
                {
                    Desc = false;
                }
            }

            if (Asc)
            {
                return "La lista se encuentra ordenada ascendentemente";
            }
            else if (Desc)
            {
                return "La lista se encuentra ordenada descendentemente";
            }
            else
            {
                return "La lista no se encuentra ordenada";
            }

        }

        public String LogicaAutentificacionUsuario(String Usuario, String Contraseña)
        {
            
            bool Sesion = PersistenciaBasica.PersistenciaUsuario(Usuario,Contraseña);


            if (Sesion)
            {
                return "Inicio de sesión completado con exito";

            }else
            {
                return "Error - Digitos erroneos - Usuario y/o contraseña incorrecta.";
            }
        }

        public double LogicaRaizCuadrada(double Numero)
        {
            double Aproximado = Numero / 2.0;
            double Tolerancia = 0.00001;
            double MejorAproximado;
            bool Verificador = true;

            while (Verificador)
            {
                MejorAproximado = (Aproximado + Numero / Aproximado) / 2.0;
                if (MejorAproximado - Aproximado < Tolerancia && MejorAproximado - Aproximado > -Tolerancia)
                {
                    Verificador = false;
                } 
                Aproximado = MejorAproximado;

            }
            return Aproximado;
        }

        public (string Resultado, string Opcion) LogicaPiedraPapelTijeras(int Respuesta)
        {
            Random rand = new Random();
            List<String> Opciones = new List<String> { "Piedra", "Papel", "Tijeras"};
            int OpcionMaquina = rand.Next(Opciones.Count);
            String Resultado;

            if (Respuesta == OpcionMaquina)
            {
                Resultado = "Empate";
            }
            else
            {
                if ((Respuesta == 0 && OpcionMaquina == 2) || (Respuesta == 1 && OpcionMaquina == 0) || (Respuesta == 2 && OpcionMaquina == 1))
                {
                    Resultado = "Ganaste";
                }
                else
                {
                    Resultado = "Perdiste";
                }
            }
            return (Resultado, Opciones[OpcionMaquina]);

        }

        public String LogicaPalindromo(String Texto)
        {
            String TextoInverso;

            Texto.ToLower().Trim();
            char[] Caracteres = Texto.ToCharArray();
            Array.Reverse(Caracteres);
            TextoInverso = new String(Caracteres);

            if (Texto == TextoInverso)
            {
                return "es un palindromo";
            }
            else
            {
                return "NO es un palindromo";
            }
        }

        public List<int> LogicaListaNoDuplicada(List<int> Lista)
        {
            List<int> listaSinDuplicados = new List<int>();

            foreach (int i in Lista)
            {
                if (!listaSinDuplicados.Contains(i)) 
                {
                    listaSinDuplicados.Add(i);
                }
            }
            return listaSinDuplicados;
        }

        public (List<int>, List<int>, List<int>) LogicaListaDoble()
        {
            int i = 0, j = 0;
            var (Lista1, Lista2) = PersistenciaBasica.PersistenciaListaDoble();
            List<int> NuevaLista = new List<int>();

            while (i < Lista1.Count || j < Lista2.Count)
            {
                if (i < Lista1.Count)
                {
                    NuevaLista.Add(Lista1[i]);
                    i++;
                }

                if (j < Lista2.Count)
                {
                    NuevaLista.Add(Lista2[j]);
                    j++;
                }
            }

            return (Lista1, Lista2, NuevaLista);
        }
    }
}
