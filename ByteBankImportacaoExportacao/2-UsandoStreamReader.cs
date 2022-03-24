using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsandoStreamReader()
        {
            var enderecoArquivo = "arquivo2.txt";
            using (var fluxo = new FileStream(enderecoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxo))
            {

                while (!leitor.EndOfStream)
                {
                    Console.WriteLine($"O saldo da conta {converter(leitor.ReadLine()).Numero} é {converter(leitor.ReadLine()).Saldo} na Agencia {converter(leitor.ReadLine()).Agencia} do Titular {converter(leitor.ReadLine()).Titular.Nome}");
                }
            }

        }
        static ContaCorrente converter(string linha)
        {
            var campo = linha.Split(',');

            var resultado = new ContaCorrente(int.Parse(campo[0]), int.Parse(campo[1]));
            var titular = new Cliente()
            {
                Nome = campo[3],
            };
            resultado.Depositar(double.Parse(campo[2].Replace('.', ',')));
            resultado.Titular = titular;
            return resultado;
        }
    }
}