using ERP.Commun.Models;
namespace Exercicios.Services
{
    
    public class MenuCliente(GerenciarClientes gerenciador)
    {
        private readonly GerenciarClientes gerenciarClientes = gerenciador ?? throw new ArgumentNullException(nameof(gerenciador), "Gerenciador não pode ser nulo");
        public void ApresentarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--Menu Gerenciar Clientes--");
                Console.WriteLine("0 para sair");
                Console.WriteLine("1-Adicionar Cliente");
                Console.WriteLine("2-Listar Clientes");
                if(int.TryParse(Console.ReadLine(), out int opcao )){}
                switch (opcao)
                {
                    case 1:
                        gerenciarClientes.CadastrarCliente();
                        break;
                    case 2:
                        gerenciarClientes.ApresentarCliente();
                        break;
                    case 0:
                        return;
                }
            }
        }
    }
}