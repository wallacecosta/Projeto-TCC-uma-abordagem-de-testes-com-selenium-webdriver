using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace ProjetoTcc.Pages
{
    public class CadastroPage : BasePage
    {        
        
        [FindsBy(How = How.Name, Using = "customer['name']")]
        public IWebElement nome { get; set; }

        [FindsBy(How = How.Name, Using = "customer['cpf_cnpj']")]
        public IWebElement cpf { get; set; }

        [FindsBy(How = How.Name, Using = "customer['birthdate']")]
        public IWebElement dataNascimento { get; set; }

        [FindsBy(How = How.Name, Using = "customer['address']")]
        public IWebElement endereco { get; set; }

        [FindsBy(How = How.Name, Using = "customer['hood']")]
        public IWebElement bairro { get; set; }

        [FindsBy(How = How.Name, Using = "customer['zip_code']")]
        public IWebElement cep { get; set; }

        [FindsBy(How = How.Name, Using = "customer['city']")]
        public IWebElement municipio { get; set; }

        [FindsBy(How = How.Name, Using = "customer['phone']")]
        public IWebElement telefone { get; set; }

        [FindsBy(How = How.Name, Using = "customer['mobile']")]
        public IWebElement celular { get; set; }

        [FindsBy(How = How.Name, Using = "customer['state']")]
        public IWebElement uf { get; set; }

        [FindsBy(How = How.Name, Using = "customer['ie']")]
        public IWebElement ie { get; set; }

        [FindsBy(How = How.Name, Using ="salvar")]
        public IWebElement salvar { get; set; }
        
        public void NavegarParaPaginaPrincipal()
        {
            Driver.Navigate().GoToUrl(baseURL);
        }
    }
}
