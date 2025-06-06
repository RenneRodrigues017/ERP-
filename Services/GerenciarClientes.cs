using Exercicios.Models;

namespace Exercicios.Services
{
    public class GerenciarClientes
    {
        private List<Cliente> _clientes;
        public GerenciarClientes()
        {
            _clientes = new List<Cliente>();
        }
        public void CadastrarCliente()
        {
            string? nomeDigitado;
            bool cadastroConcluido=false;
            while (!cadastroConcluido)
            {
                Console.WriteLine("--Cadastro de Cliente--");
                Console.Write("Nome (digite sair para finalizar): ");
                nomeDigitado = Console.ReadLine();
                if (nomeDigitado?.ToUpper() == "sair" && nomeDigitado?.ToUpper() == "Sair")
                {
                    Console.WriteLine("Cadastro cancelado. Saindo..."); return;
                }
                try
                {
                    if (string.IsNullOrWhiteSpace(nomeDigitado))
                    {
                        Console.WriteLine("Nome não pode ser vazio. Tente novamente."); continue;
                    }
                    if (!nomeDigitado.All(Char.IsLetter))
                    {
                        Console.WriteLine("Nome deve conter apenas letras. Tente novamente."); continue;
                    }

                    Cliente clienteNovo = new Cliente(nomeDigitado);
                    _clientes.Add(clienteNovo);
                    cadastroConcluido = true;
                    Console.WriteLine($"Cadastro finalizado. Nome:{clienteNovo.Nome}, ID:{clienteNovo.Id}, Staus:{clienteNovo.Status}");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"ERRO no cadastro(Argumento Nulo). {ex.Message}.Por favor tente novamente.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"ERRO no cadastro (Argumento invalido). {ex.Message}. Tente novamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRO inesperado. {ex.Message}. Tente novamente");
                }
            }
        }

        public void ApresentarCliente()
        {
            try
            {
                Console.WriteLine("--Lista de Clientes--");
                if (_clientes.Count == 0)
                {
                    Console.WriteLine($"Nenhum cliente cadastrado."); return;
                }
                foreach (Cliente cliente in _clientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, ID: {cliente.Id}, Status: {cliente.Status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado. {ex.Message}");
            }
        }
    }
}
