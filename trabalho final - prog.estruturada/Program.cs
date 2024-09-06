using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace trabalho_final___prog.estruturada
{
    internal class Program
    {

        static void Main(string[] args)

        { //inserir os nrs e estrelas apostados, validar entradas e limitar a repetição dos nrs inseridos
            Console.WriteLine("********************************EUROMILHOES********************************");

            Console.WriteLine("\n\t\t\tAPOSTA");

            #region Aposta
            //aposta de nrs
            int[] aposta_nr = new int[5];
            for (int i = 0; i < aposta_nr.Length; i++) 
                // variavel; condição; acção - enquanto a variavel i for menor que o comprimento estipulado do array, será incrementada
            {
                do
                {
                    Console.WriteLine($"\nIntroduza o {i + 1}º número da aposta: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (aposta_nr.Contains(numero)) //confirma se o numero inserido já consta no array  
                    {
                        Console.WriteLine("\n\tTente novamente!"); //msg erro 
                    }
                    else if (numero < 1 || numero > 50 || numero == 0) //limitaçao dos intervalo de nrs
                    {
                        Console.WriteLine("\n\tO número deve ser compreendido entre 1 e 50. Tente novamente!"); //msg erro caso o nr fuja aos parametros da chave
                    }
                    else
                    {
                        aposta_nr[i] = numero; //o array toma o nr inserido caso tenha passado nos testes anteriores
                        break;
                    }
                } while (true);
            }
            //aposta de estrelas
            int[] aposta_estrela = new int[2];
            for (int i = 0; i < aposta_estrela.Length; i++)
            // variavel; condição; acção - enquanto a variavel i for menor que o comprimento estipulado do array, será incrementada
            {
                do
                {
                    Console.WriteLine($"\nIntroduza a {i + 1}º estrela: ");
                    int estrela = int.Parse(Console.ReadLine());

                    if (aposta_estrela.Contains(estrela))//confirma se a estrela inserida já consta no array  
                    {
                        Console.WriteLine("\n\t Tente novamente!");//msg erro
                    }
                    else if (estrela < 1 || estrela > 12 || estrela == 0) //range da estrela
                    {
                        Console.WriteLine("\n\tO número introduzido deve ser compreendido entre 1 e 12. Tente novamente!");//msg erro caso a estrela fuja aos parametros da chave
                    }
                    else
                    {
                        aposta_estrela[i] = estrela; //o array toma o nr inserido caso tenha passado nos testes anteriores
                        break;
                    }

                } while (true);

            }
            #endregion

            Console.WriteLine("\n\t\t\tSORTEIO");

            //mostrar os nrs gerados e limitar a sua repetição
           
            Random gerar = new Random(); //gerar nrs aleatórios
            int[] numeros_gerados = new int[5]; //array do sorteio de nrs

            Console.Write("\nNúmeros: ");
            for (int i = 0; i < numeros_gerados.Length; i++)
            // variavel; condição; acção - enquanto a variavel i for menor que o comprimento estipulado do array, será incrementada
            {

                int number = gerar.Next(1, 51); // gerar nrs de 1-50

                // confirma se o nr existe no array
                while (numeros_gerados.Contains(number))
                {
                    // gera novo nr se ja existir
                    number = gerar.Next(1, 51);
                }

                numeros_gerados[i] = number;  //atribui novo nr ao array numeros
             
                Console.Write(numeros_gerados[i] + " "); //escreve os nrs sorteados com espaço entre si p/ melhor leitura
            }

            //mostrar as estrelas geradas e limitar repetição
            int[] estrelas_geradas = new int[2]; //array do sorteio de estrelas
            Console.Write("\nEstrelas: ");
            for (int i = 0; i < estrelas_geradas.Length; i++)
            // variavel; condição; acção - enquanto a variavel i for menor que o comprimento estipulado do array, será incrementada
            {
                int numb = gerar.Next(1, 13); // gerar nrs de 1-12

                // confirma se o nr existe no array
                while(estrelas_geradas.Contains(numb))
                {
                    // gera novo nr se ja existir
                    numb = gerar.Next(1, 13);
                }

                estrelas_geradas[i] = numb;  //atribui novo nr ao array estrelas

                Console.Write(estrelas_geradas[i] + " "); //escreve as estrelas sorteadas com espaço entre si p/ melhor leitura

            }

                //mostrar prémios (total de nrs e estrelas para contagem do premio)
            int total_numeros = 0;
            int total_estrelas = 0;

            //para cada valor do array dos nrs sorteados há comparaçao para cada valor do array aposta_numeros
            foreach (int ng in numeros_gerados)             
            {
                foreach (int na in aposta_nr)
                {
                    if (ng == na)
                    { total_numeros++; } //quando os nrs são iguais o contador é incrementado
                }
            }
            //para cada valor do array das estrelas sorteadas há comparaçao para cada valor do array aposta_estrelas
            foreach (int eg in estrelas_geradas)
            {
                foreach (int ea in aposta_estrela)
                {
                    if (eg == ea)
                    {
                        total_estrelas++; //quando os nrs são iguais o contador é incrementado
                    }
                }
            }
            //atribuição dos prémios
            Console.WriteLine($"\n\nAcertou {total_numeros} números.");
            Console.WriteLine($"\nAcertou {total_estrelas} estrelas.");

            //condiçoes dos premios atribuidas segundo a tabela do enunciado
            if (total_numeros == 5 && total_estrelas == 2) 
            {
                Console.WriteLine("\nParabéns!Ganhou o 1º prémio!(");
            }
            else if (total_numeros == 5 && total_estrelas == 1)
            {
                Console.WriteLine("\nParabéns!Ganhou o 2º prémio!");
            }
            else if (total_numeros == 5 && total_estrelas == 0)
            {
                Console.WriteLine("\nParabéns!Ganhou o 3º prémio!");
            }
            else if (total_numeros == 4 && total_estrelas == 2)
            {
                Console.WriteLine("\nParabéns!Ganhou o 4º prémio!");
            }
            else if (total_numeros == 4 && total_estrelas == 1)
            {
                Console.WriteLine("\nParabéns!Ganhou o 5º prémio!");
            }
            else if (total_numeros == 4 && total_estrelas == 0)
            {
                Console.WriteLine("\nParabéns!Ganhou o 6º prémio!");
            }
            else
            {
                Console.WriteLine("\n\nDesta vez a sorte não lhe bateu à porta =( Tente novamente!");
            }
        }
    }
}
//Validar se é INT ou não:

//            string teste_string = Console.ReadLine();
//try
//{
//    int teste_int = Int32.Parse(teste_string);
//    Console.WriteLine(teste_int);
//}
//catch (FormatException)
//{
//    Console.WriteLine($"Unable to parse '{teste_string}'");
//}

