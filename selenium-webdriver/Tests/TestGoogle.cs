using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium_webdriver.Pages;

namespace selenium_webdriver
{
    [TestClass]
    public class TestGoogle
    {
        // Declarando IWebDriver
        private IWebDriver driver = null;

        [TestInitialize]
        public void abrirNavegador()
        {
            // Instanciando navegador Google Chrome
            driver = new ChromeDriver();
            
            // Abrindo página do desafio
            driver.Navigate().GoToUrl("https://www.google.com.br/");
            
            // Maximizando janela do navegador
            driver.Manage().Window.Maximize();
        }
        
        [TestMethod]
        public void testPesquisaGoogle()
        {
            // Variável a ser utilizada como termo para pesquisa
            string termoAPesquisar = "mateusblopes.com.br";

            // Instanciando página do desafio
            PageGoogle pageGoogle = new PageGoogle(driver);

            // Executando método para capturar o título da página
            pageGoogle.pegarTituloPagina();

            // Executando Assert para conferir título da página
            Assert.AreEqual("Google", pageGoogle.tituloPagina);

            // Executando método para somar números randômicos
            pageGoogle.fazerPesquisa(termoAPesquisar);

            // Executando Assert para conferir resultado da soma 'CORRETO'
            Assert.AreEqual("Mateus Bruno T. Lopes", pageGoogle.resultadoObtidoPesquisa);
        }

        [TestCleanup]
        public void fecharNavegador()
        {
            // Fechar navegador
            driver.Quit();
        }
    }
}
