using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCantinaEscolar
{
    public class Menu
    {
        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1- Cadastrar aluno");
            Console.WriteLine("2- Atualizar aluno");
            Console.WriteLine("3- Ver aluno");
            Console.WriteLine("4- Deletar aluno");
            Console.WriteLine("5- Produtos");
            Console.WriteLine("6- Comprar");
            Console.WriteLine("q- sair");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }

        public string menuProduto()
        {
            Console.Clear();
            Console.WriteLine("1- Misto uente");
            Console.WriteLine("2- Refrigerante");
            Console.WriteLine("3- Coxinha");
            Console.WriteLine("4- Pão de quiejo");
            Console.WriteLine("5- Café com leite");
            Console.WriteLine("q- sair");
            string escolha;
            escolha = Console.ReadLine();
            return escolha.ToUpper();
        }


        public void sairFila()
        {
            Console.Clear();
        }
    }
}

