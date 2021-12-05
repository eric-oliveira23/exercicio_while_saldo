using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_saldo
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
            double valor, saldo_atual;
            int resposta; 
            string resp;

            
            Console.WriteLine("Insira o seu saldo atual.");
            saldo_atual = double.Parse(Console.ReadLine());
            resp = "S";
            while (resp == "S")
            {
            Console.WriteLine("Deseja sacar ou depositar? \n (1) - Sacar \n (2) - Depositar");
            resposta = int.Parse(Console.ReadLine());
            resp = "S";


                    switch (resposta)
                    {
                        case 1:

                            Console.WriteLine("Insira o valor a ser sacado.");
                            valor = double.Parse(Console.ReadLine());

                            while (saldo_atual < valor)
                            {
                                Console.WriteLine("O valor a ser sacado não pode ser maior que o saldo atual.");
                                
                                Console.WriteLine("Insira o valor a ser sacado.");
                                valor = double.Parse(Console.ReadLine());
                            }
                    
                                saldo_atual -= valor;

                            Console.WriteLine("Novo saldo: " + saldo_atual.ToString("C"));

                            break;

                    
                    case 2:
                        
                        Console.WriteLine("Insira o valor a ser depositado.");
                        valor = double.Parse(Console.ReadLine());

                        saldo_atual += valor;

                        Console.WriteLine("Novo Saldo: " + saldo_atual.ToString("C"));

                        break;
                }
                Console.WriteLine("Deseja repetir o processo? (S)im / (N)ão");
                resp = Console.ReadLine().ToUpper();

            }
                Console.WriteLine("Saldo Final: " + saldo_atual.ToString("C"));

                Console.WriteLine("Programa encerrado.");
            }
            catch (SystemException)
            {
                Console.WriteLine("Valor digitado fora do contexto atual.");
            }

            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro, tente novamente mais tarde.");
            }
            Console.ReadKey();


             }


        }
    }
