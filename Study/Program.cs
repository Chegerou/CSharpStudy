﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        #region Classes

        class Teste1
        {
            int X;
            int Y;
            public Teste1()
            {
                X = 10;
                Y = 20;
            }
        }

        public enum Cores
        {
            Preta,
            Azul,
            Verde
        }

        #endregion

        #region Estrturas

        struct Teste2
        {
            int X;
            int Y;
            /*
            public Teste2()
            {
                X = 10;
                Y = 20;
            }
            */
        }

        #endregion

        #region Métodos estáticos

        #region Método main

        static void Main(string[] args)
        {
            /*
            Computer computer = new Computer();
            computer.CPU = "i7";

            OOProgrammer oo = new TypeScriptProgrammer();
            OOProgrammer oo2 = new OOProgrammer();



            Person pessoa = new Person();

            //int idade = pessoa.CalculateAge();

            int idade = Person.CalculateAge(pessoa);



    */
            /*

                    Person igor = Person.GetPersonWith20YearsOld();
                    igor.Name = "Igor";
                    igor.Age = 24;
                    int r = igor.Age;

                    igor.CoffeeCupsPerDay = 10;

                    double valorPIS = ImpostoPIS.CalcularPIS(35000);


                    string integrantes = "Ana " + " Val" + igor.Name + "Letícia " + "Igor";
                    string integrantew = string.Format("Ana Val {0} {1} Letícia Igor", igor.Name, igor.Name);
                    string integranter = $"Ana Val {igor.Name} Letícia Igor";




                    var cronometro = new System.Diagnostics.Stopwatch();

                    cronometro.Start();

                    var palavra = "ihfsdhfjshfjshfksdhfkjsdhfkjsdhfksdhfksdhfksdjfhksdhfksdjfhksdjgf";

                    var sb = new StringBuilder();

                    for (var i = 0; i < 20000; i++)
                    {
                        sb.Append(palavra);
                    }

                    sb.ToString();

                    Console.WriteLine(cronometro.ElapsedMilliseconds);


                    using (var stream = new FileStream("", FileMode.Append))
                    {

                    }

                    Programmer programador = new Programmer
                    {
                        Name = "Bruno",
                        Age = 22
                    };

            */

            //TestAttribute();
            /*
            var listaChars = new List<char>();
            //listaInteiros.Add(800);
            listaChars.Add('T');
            listaChars.Add('R');
            //listaInteiros.RemoveAt(0);
            var listaDeErres = listaChars.Where(letra => letra == 'R');
            //listaInteiros.orde

            if (listaChars.Count() > 2)
            {
                listaChars.Add('Y');
            }
            else
            {
                listaChars.Add('O');
            }

            listaChars.Add(listaChars.Count() > 2 ? 'Y' : 'O');

            switch(listaChars.FirstOrDefault())
            {
                case 'A':
                    Console.WriteLine("Primeira letra do alfabeto");
                    break;
                case 'Z':
                    Console.WriteLine("Ultima letra do alfabeto");
                    break;
                default:
                    Console.WriteLine("Não é a primeira nem a última letra do alfabeto");
                    break;
            }

            int teste = 5;

            if (++teste == 6)
            {

            }

            for (var i = 0; i < listaChars.Count(); i++)
            {
                char caracter = listaChars[i];
                Console.WriteLine(caracter);
            }

            foreach(char caracter in listaChars)
            {
                Console.WriteLine(caracter);
            }

            int index = 0;

            while (listaChars.Where(caractere => caractere == 'Z').Count() == 0)
            {
                listaChars.Add(Convert.ToChar(index++));
            }

            listaChars.ForEach(caractere =>
            {
                Console.WriteLine(caractere);
            });

            do
            {
                listaChars.Add('H');
            } while (listaChars.Where(caractere => caractere == 'H').Count() == 0);

            OOProgrammer.Teste();

            System.Nullable<int> y = null;
            var date = default(DateTime);

            int u = y ?? default(int);
            */
#if DEBUG
            Console.WriteLine("Estou na linha 194");
            Console.WriteLine("Goku passou na linha 195");
            
#endif
#line 400
#warning Não utilize este código
            
            System.Threading.Thread.Sleep(3000);

            Cores corCamisaCliente = Cores.
        }
        #endregion
        public static void TestAttribute()
        {
            Programmer.GetAttribute(typeof(CSharpProgrammer));
        }
        #endregion
    }
}
