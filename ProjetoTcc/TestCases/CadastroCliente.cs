using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTcc.Configuration;
using ProjetoTcc.Pages;
using NUnit.Framework;
using System.Threading;
using System.IO;

namespace ProjetoTcc.TestCases
{
    [TestFixture]
    public class CadastroCliente : BaseUITest
    {
        public void esperaEmSegundos(int segundos)
        {
            //converte segundos em milisegundos pois Thread recebe milisegundos
            segundos = segundos * 1000;
            Thread.Sleep(segundos);
        }
        [Test]
        public void cadastrarClienteVerificarSeSalvou()
        {
            CadastroPage cliente = new CadastroPage();
            cliente.NavegarParaPaginaPrincipal();

            cliente.nome.SendKeys("Wallace Costa");
            esperaEmSegundos(2);
            cliente.cpf.SendKeys("123.456.789-10");
            esperaEmSegundos(2);
            cliente.dataNascimento.SendKeys("1989-09-20");
            esperaEmSegundos(2);
            cliente.endereco.SendKeys("Avenida Paris, 100");
            esperaEmSegundos(2);
            cliente.bairro.SendKeys("Bonsucesso");
            esperaEmSegundos(2);
            cliente.cep.SendKeys("22111333");
            esperaEmSegundos(2);
            cliente.municipio.SendKeys("Rio de Janeiro");
            esperaEmSegundos(2);
            cliente.telefone.SendKeys("40042020");
            esperaEmSegundos(2);
            cliente.celular.SendKeys("980802020");
            esperaEmSegundos(2);
            cliente.uf.SendKeys("RJ");
            esperaEmSegundos(2);
            cliente.ie.SendKeys("123456");
            esperaEmSegundos(2);
            cliente.salvar.Click();

            esperaEmSegundos(5);

            Assert.IsTrue(Driver.PageSource.Contains("Wallace Costa"));
            //Vai salvar em C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE
            StreamWriter file = new StreamWriter("relatorio.txt");
            file.Write("Teste realizado com sucesso!");
            file.Close();
        }
}
}
