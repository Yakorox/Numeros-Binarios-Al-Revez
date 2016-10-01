using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace BinarioAlrevez
{
    class Binario
    {
        int numero;
        int p;
        int q;
        int[]pbinario;
        int[] qbinario;
        int[] nbinario;
        int tam;
        ArrayList qbina;

        public Binario(int n)
        {
            numero = n;
            p = q = tam = 0;
            qbina = new ArrayList();
        }

        public void calcularReversoBinario()
        {
            int cont = 0;
            int pru=numero;
            String pr = "";
            while (pru >= 2)
            {
                pr = Convert.ToString(pru%2);
                qbina.Add(pr);
                pru = pru / 2;
                tam++;
            }
            pr = Convert.ToString(pru);
            qbina.Add(pr);
            tam++;
        }

        public void GenerarBinarios()
        {
            int i = 0;
            int k = tam-1;
            qbinario=new int[tam];
            nbinario=new int[tam];
            pbinario=new int[tam];
            foreach (String j in qbina)
            {
                nbinario[k] = qbinario[i] = Convert.ToInt32(j);
                if (nbinario[k] == 0)
                    pbinario[k] = 1;
                else
                    pbinario[k] = 0;
                
                k--;
                i++;
            }    
        }

        public void calcularDecimales()
        {
            int k = tam-1;
            for (int i = 0; i < tam; i++)
            {
                q = q + (qbinario[i] * ((int)Math.Pow(2,k)));
                p=p+(pbinario[i])*((int)Math.Pow(2,k));
                k--;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine(p+" "+q);
        }

    }
}
