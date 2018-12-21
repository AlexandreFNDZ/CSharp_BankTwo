using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankTwo.Funcionarios;

namespace BankTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); // Criar um objeto 'GerenciadorBonificacao' para calcular o total de Bonificações

            Funcionario carlos = new Funcionario(); // Criar um objeto 'Funcionario'

            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-00";
            carlos.Salario = 1000.0;

            Console.WriteLine("\nNome: " + carlos.Nome);
            Console.WriteLine("Bonificação: R$" + carlos.GetBonificacao());

            Funcionario pedro = new Diretor(); // Criar um objeto 'Diretor'

            pedro.Nome = "Pedro";
            pedro.CPF = "987.654.321-00";
            pedro.Salario = 3500.0;

            Console.WriteLine("\nNome: " + pedro.Nome);
            Console.WriteLine("Bonificação: R$" + pedro.GetBonificacao());

            gerenciador.Registrar(carlos); // Registrar a Bonificação do 'carlos'
            gerenciador.Registrar(pedro); // Registrar a Bonificação do 'pedro'

            Console.WriteLine("\nTotal Bonificação: R$" + gerenciador.GetTotalBonificacao()); // Mostrar o total de Bonificações

            Funcionario jorge = new Diretor(); // Criar um objeto 'Diretor'

            jorge.Nome = "Jorge";
            jorge.CPF = "555.687.489-00";
            jorge.Salario = 3000.0;

            Console.WriteLine("\nNome: " + jorge.Nome);
            Console.WriteLine("Bonificação: R$" + jorge.GetBonificacao());

            Console.WriteLine("\nTotal de Bonificações: R$" + gerenciador.GetTotalBonificacao()); // Mostrar o total de Bonificações (Valor incorreto, pois não chamou o método 'Registrar')

            gerenciador.Registrar(jorge); // Registrar a bonificação do 'jorge'

            Console.WriteLine("\nTotal de Bonificações: R$" + gerenciador.GetTotalBonificacao()); // Mostrar o total correto de Bonificações (Não soma se não chamar o método 'Registrar')


            Console.WriteLine("\nSalário Jorge: R$" + jorge.Salario);
            jorge.AumentarSalario();
            Console.WriteLine("Novo Salário do Jorge: R$" + jorge.Salario);

            Console.WriteLine("\nSalário Carlos: R$" + carlos.Salario);
            carlos.AumentarSalario();
            Console.WriteLine("Novo Salário do Carlos: R$" + carlos.Salario);

            Console.ReadLine();
        }
    }
}
