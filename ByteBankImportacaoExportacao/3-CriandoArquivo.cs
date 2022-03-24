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
        static void CriarArquivoCSV(string caminho)
        {
            caminho = caminho + ".csv";
            using (var fluxo = new FileStream(caminho, FileMode.Create))
            {
                
                //var enconding = Encoding.UTF8.GetBytes(stringzada);
                //fluxo.Write(enconding, 0, enconding.Length);
            }
        }
        static void CriarArquivoWrite(string caminho)
        {
            caminho = caminho + ".csv";
            using (var fluxo = new FileStream(caminho, FileMode.CreateNew))
                using(var write = new StreamWriter(fluxo, Encoding.UTF8))
            {
                var stringzada = "123,1234,12.12,Danilo Couto";
                write.Write(stringzada);
            }
        }
        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }
        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }
    }
}