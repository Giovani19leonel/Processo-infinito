using System;
using System.Diagnostics;

namespace scripts
{
   
    class Program
    {

        static void Main(string[] args)
        {
            // Cria uma variavel de um processo nullo.
            Process ArqProcesso = null;
            // Inicia o processo desejado.
            ArqProcesso = Process.Start("mspaint.exe");
            // Ponto de Inicio da analise
            REVISAO:
            // Faz uma atualização do estado atual do processo, se ele foi fechado ou não.
            ArqProcesso.Refresh();  // Important
            if (ArqProcesso.HasExited)
            {
                // Entra no if se o processo foi fechado, então reinicia o processo e atualiza denovo;
                ArqProcesso = Process.Start("mspaint.exe");
                ArqProcesso.Refresh();
                goto REVISAO;
            }
            else
            {
                goto REVISAO;
            }
        }
    }
    }

