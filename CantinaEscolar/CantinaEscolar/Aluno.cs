using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCantinaEscolar;

namespace CantinaEscolar
{
    class Aluno
    {
        public string nome;
        public double idade;
        public string turma;
        public double ra;

        public void cadastrarAluno()
        {
            Console.WriteLine("Qual o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade: ");
            idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua turma: (ex: primeiro ano)");
            turma = Console.ReadLine();
            Console.WriteLine("Qual o seu RA escolar: ");
            ra = double.Parse(Console.ReadLine());
        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- CADASTRO ---");
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("Idade:{0}", idade);
            Console.WriteLine("Turma:{0}", turma);
            Console.WriteLine("RA:{0}", ra);
        }

        public void sairFila()
        {
            Console.Clear();
        }
    }
}
