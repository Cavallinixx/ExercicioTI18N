using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTI18N
{
      class controlFormulario
    {
        modelExercicio exercicio;
        private int opcao; 

        public controlFormulario() 
        {
             exercicio= new modelExercicio();//Conecta a classe model e a control no exercicio
            ConsultarOpcao = -1;
        }//fim do método construtor 

        //Métodos modificadores 
        public int ConsultarOpcao
        {
            get { return opcao;}
            set { opcao = value;}
        }//fim do método

        public void menu() 
        {
            Console.WriteLine("\n\n ---- Menu ---- \n\n" +
                               "0. Sair\n" +
                              "1. Exercicio 01\n" +
                              "2. Exercicio 02\n" +
                              "3. Exercicio 03\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//mostrar menu

        public void operacao () 
        {
            do
            {

                menu();
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1 = 0;//Declarei do lado de fora
                        double nota2 = 0;//Declarei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);


                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }
                        } while (exercicio.ValidarNotas(nota2) == true);
                        //Chamar metodo da media que esta na classe model

                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;
                   
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação 
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;
                   
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado 
                        Console.WriteLine("O antecessor é: " + exercicio.Antecessor(num));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;     
                }//fim do escolha
            } while (ConsultarOpcao != 0);
        }//fim método



    }//fim classe
}//fim projeto
