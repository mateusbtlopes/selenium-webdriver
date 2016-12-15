using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_webdriver.Pages;

namespace selenium_webdriver
{
    [TestClass]
    public class TestDesafioSelenium05
    {
        // Declarando IWebDriver
        private IWebDriver driver = null;

        [TestInitialize]
        public void abrirNavegador()
        {
            // Instanciando navegador Google Chrome
            driver = new ChromeDriver();
            
            // Abrindo página do desafio
            driver.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/5desafio/");
            
            // Maximizando janela do navegador
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void testPreenchimentoDeCamposComIDsDinamicos()
        {
            // Variáveis para preenchimento dos campos
            string username1 = "mateusblopes";
            string username2 = "mateuslopes";
            string password = "1234567890";

            // Instanciando página do desafio
            PageDesafioSelenium05 pageDesafio05 = new PageDesafioSelenium05(driver);

            // Executando método para capturar o título da página
            pageDesafio05.pegarTituloPagina();

            // Executando Assert para conferir título da página
            Assert.AreEqual("IDs Dinâmicos", pageDesafio05.tituloPagina);

            // Executando método para preenchimento dos campos
            pageDesafio05.preenchimentoDeCamposComIDsDinamicos(username1, username2, password, password);

            // Executando Assert para conferir título da página
            Assert.AreEqual("Os campos não tem o mesmo valor!", pageDesafio05.resultadoObtido);

            // Executando método para preenchimento dos campos
            pageDesafio05.preenchimentoDeCamposComIDsDinamicos(username2, username2, password, password);

            // Executando Assert para conferir título da página
            Assert.AreEqual("", pageDesafio05.resultadoObtido);
        }

        [TestCleanup]
        public void fecharNavegador()
        {
            // Fechar navegador
            driver.Quit();
        }
    }
}
