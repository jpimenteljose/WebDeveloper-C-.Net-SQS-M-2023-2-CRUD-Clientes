using Projeto06.Entities;
using Projeto06.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Controllers
{
    public class ClienteController
    {
        public void ExecutarMenu()
        {
            Console.WriteLine("\n*** CONTROLE DE CLIENTES ***\n");
            Console.WriteLine("(1) - CADASTRAR CLIENTE");
            Console.WriteLine("(2) - ATUALIZAR CLIENTE");
            Console.WriteLine("(3) - EXCLUIR CLIENTE");
            Console.WriteLine("(4) - CONSULTAR CLIENTE");

            try
            {
                Console.Write("\nINFORME A OPÇÃO DESEJADA: ");
                var opcao = int.Parse(Console.ReadLine());  

                switch(opcao)
                {
                    case 1: CadastrarCliente(); break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    default:
                        Console.WriteLine("\nOPÇÃO INVÁLIDA.");
                        break;
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        // Método para executar o cadastro de um cliente
        public void CadastrarCliente()
        {
            try
            {
                Console.WriteLine("\n*** CADASTRO DE CLIENTE ***\n");

                var cliente = new Cliente();

                Console.Write("NOME DO CLIENTE.........: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("CPF DO CLIENTE..........: ");
                cliente.Cpf = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO......: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                var clienteRepository = new ClienteRepository();
                clienteRepository.Inserir(cliente);

                Console.WriteLine("\nCLIENTE CASDASTRADO COM SUCESSO.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nOcorreram erros de validação:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar cliente:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

