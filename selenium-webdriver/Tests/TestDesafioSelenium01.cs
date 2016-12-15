using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_webdriver.Pages;

namespace selenium_webdriver
{
    [TestClass]
    public class TestDesafioSelenium01
    {
        // Declarando IWebDriver
        private IWebDriver driver = null;

        [TestInitialize]
        public void abrirNavegador()
        {
            // Instanciando navegador Google Chrome
            driver = new ChromeDriver();
            
            // Abrindo página do desafio
            driver.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/1desafio/");
            
            // Maximizando janela do navegador
            driver.Manage().Window.Maximize();
        }
        
        [TestMethod]
        public void testSomarDoisNumerosRandomicos()
        {
            // Instanciando página do desafio
            PageDesafioSelenium01 pageDesafio01 = new PageDesafioSelenium01(driver);

            // Executando método para capturar o título da página
            pageDesafio01.pegarTituloPagina();

            // Executando Assert para conferir título da página
            Assert.AreEqual("Soma com números aleatórios", pageDesafio01.tituloPagina);

            // Executando método para somar números randômicos
            pageDesafio01.somarDoisNumerosRandomicosCorretamente();

            // Executando Assert para conferir resultado da soma 'CORRETO'
            Assert.AreEqual("CORRETO", pageDesafio01.resultadoObtido);

            // Executando método para somar números randômicos
            pageDesafio01.somarDoisNumerosRandomicosIncorretamente();

            // Executando Assert para conferir resultado da soma 'ERRADO'
            Assert.AreEqual("ERRADO", pageDesafio01.resultadoObtido);
        }

        [TestCleanup]
        public void fecharNavegador()
        {
            // Fechar navegador
            driver.Quit();
        }
    }
}
