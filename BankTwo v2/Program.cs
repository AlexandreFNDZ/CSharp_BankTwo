using BankTwo_v2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTwo_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            UsarSistema();
            
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); 

            Designer pedro = new Designer("833.222.048-39"); // Adicionar um 'Designer'
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04"); // Adicionar um 'Diretor'
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53"); // Adicionar um 'Auxiliar'
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89"); // Adicionar um 'GerenteDeConta'
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro); // Registrar as Bonificações
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de Bonificações: R$" + gerenciador.GetTotalBonificacao()); // Mostrar o total das bonificações
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.456.789-00"); // Adicionar um 'Diretor'
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89"); // Adicionar um 'GerentedeConta'
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial loja = new ParceiroComercial(); // Adicionar um 'ParceiroComercial'
            loja.Senha = "000";

            sistemaInterno.Logar(roberta, "123"); // Registrar o Login
            sistemaInterno.Logar(camila, "555");
            sistemaInterno.Logar(loja, "000");
        }
    }
}
