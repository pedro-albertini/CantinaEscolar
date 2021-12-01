using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using LibraryCantinaEscolar;

namespace CantinaEscolar
{
    class Conexao
    {
        public string ra;
        public int idade;
        public string turma;


        public void cadastroAluno()
        {
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=cantina;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possível conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }



            MySqlCommand cmd;
            Console.WriteLine("Digite um ra para ser cadastrado");
            ra = Console.ReadLine();
            Console.WriteLine("Digite uma idade para este usuario");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite turma para este usuario");
            turma = Console.ReadLine();
            string sql;
            //insert into login values ('usuario', 'senha', 'email');
            //sql = "insert into login values ('" + usuario + "','" + senha + "','" + email + "')";
            //Console.WriteLine("SQL:" + sql);
            sql = "insert into aluno values(@ra,@idade,@turma)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ra", ra);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@turma", turma);
            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.ReadKey();

        }

        public void atualizarAluno()
        {
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=cantina;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possível conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }



            MySqlCommand cmd;
            string sqlupdate = "update aluno set idade=@idade, turma@turma where ra=@ra";
            cmd = new MySqlCommand(sqlupdate, conexao);
            cmd.Parameters.AddWithValue("@ra", ra);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@turma", turma);
            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();
        }

        public void verAluno()
        {
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=cantina;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possível conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }



            MySqlCommand cmd;
            string sqlselect = "select * from aluno where ra = @ra";
            cmd = new MySqlCommand(sqlselect, conexao);
            cmd.Parameters.AddWithValue("@ra", ra);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();

            while (resultado.Read())
            {
                Console.WriteLine("RA: " + resultado["ra"]);
                Console.WriteLine("Idade: " + resultado["idade"]);
                Console.WriteLine("Turma: " + resultado["turma"]);
            }
            conexao.Close();

            Console.ReadKey();
        }

        public void deletarAluno()
        {
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=cantina;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possível conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }



            MySqlCommand cmd;
            string sqldelete = "delete from aluno where ra=@ra";
            cmd = new MySqlCommand(sqldelete, conexao);
            cmd.Parameters.AddWithValue("@ra", ra);
            cmd.CommandText = sqldelete;
            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();
        }
    }
}
