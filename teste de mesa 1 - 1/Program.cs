using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace testeDemesa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Objects objects = new Objects();
            objects.Teste1();
            objects.Teste2();
            objects.Teste3();
        }
    }
    public class Objects
    {
        double a = 10;
        double b = 20;
        double c1;
        double c2;
        double[] v = new double [4];
        string vI; // representa o valor de i, no caso, se i = 5, retorna verdadeiro e se não retorna falso

        public void Teste1()
        {
            Console.WriteLine($"Planilha 1 teste 1:");
            c1 = (a + b) / 2;
            c2 = c1 - 40;
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    v[i] = a + b + c2;
                }
                else
                {
                    v[i] = 0;
                }
                vI = (v[i] == 5) ? "Verdadeiro" : "Falso";
                Console.WriteLine($"linha {i+1}, valor de a: {a}, valor de b: {b}, variavel c1: {c1}, variavel c2: {c2}, vetor v[{i}]: {v[i]}, condição do vetor: {vI} ");
            }
        }

        public void Teste2()
        {
            Console.WriteLine($"Planilha 1 teste 2:");
            int a = 2;
            string c = "verdadeiro";
            int i = 0;
            while (a <= 6)
            {
                ++a;
                i++;
                if (a - 1 == 6)
                {
                    c = "Falso";
                }
                Console.WriteLine($"posição: {i - 1}, variavel: {a - 1}, vetor[{i - 1}]: {a * 10}, contador: {a}, condição: {c}");
            }
        }
        public void Teste3()
        {
            Console.WriteLine($"Planilha 1 teste 3:");
            int[] v = new int[10];
            int a = 7;
            int b = a - 7;
            while (b < a)
            {
                v[b] = b + a;
                b = b + 2;
                Console.WriteLine($"valor de a: {a}, valor de b: {b}");
            }
        }
    }
}