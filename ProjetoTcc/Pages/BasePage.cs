using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProjetoTcc.Configuration;

namespace ProjetoTcc.Pages
{
    public class BasePage
    {
        /// Definição do Driver que irá rodar o navegador.
        protected IWebDriver Driver
        {
            get
            {
                return BaseUITest.Driver;
            }
        }
        /// Definição da URL para rodar os testes.
        protected string baseURL { get; set; }
        /// Construtor padrão. Irá inicializar os objetos das páginas com DOM.
        public BasePage()
        {
            PageFactory.InitElements(BaseUITest.Driver, this);

            baseURL = "http://lojadotcc.000webhostapp.com/customers/add.php";
        }
        protected internal void ExecuteScript(string jsScript)
        {
            ((IJavaScriptExecutor)BaseUITest.Driver).ExecuteScript(jsScript);
        }
    }
}
