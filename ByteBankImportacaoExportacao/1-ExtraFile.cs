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
        static void LidandoComFileStream()
        {
            var enderecoArquivo = "arquivo2.txt";
            using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var Bytelidos = -1;

                while (Bytelidos != 0)
                {
                    Bytelidos = fluxoArquivo.Read(buffer, 0, 1024);
                    LeiaByte(buffer, Bytelidos);
                }

            }

        }
        static void LeiaByte(byte[] buffer, int byteslidos)
        {
            var utf = Encoding.UTF8
                .GetString(buffer, 0, byteslidos);
            Console.Write(utf);

            //foreach (var buff in buffer)
            //{
            //    Console.Write(buff);
            //    Console.Write(" ");
            //}
        }
    }
}