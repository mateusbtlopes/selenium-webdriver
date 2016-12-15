using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_webdriver.Pages;

namespace selenium_webdriver
{
    [TestClass]
    public class TestDesafioSelenium02
    {
        // Declarando IWebDriver
        private IWebDriver driver = null;

        [TestInitialize]
        public void abrirNavegador()
        {
            // Instanciando navegador Google Chrome
            driver = new ChromeDriver();
            
            // Abrindo página do desafio
            driver.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/2desafio/");
            
            // Maximizando janela do navegador
            driver.Manage().Window.Maximize();
        }
        
        [TestMethod]
        public void TestEdicaoDeCamposInline()
        {
            // Variáveis para edição dos campos
            string nome = "Mateus Lopes";
            string email = "mateus.redes@gmail.com";
            string telefone = "00 12345-6789";
            
            // Instanciando página do desafio
            PageDesafioSelenium02 pageDesafio02 = new PageDesafioSelenium02(driver);

            // Executando método para capturar o título da página
            pageDesafio02.pegarTituloPagina();

            // Executando Assert para conferir título da página
            Assert.AreEqual("Edição inline", pageDesafio02.tituloPagina);

            // Executando método para editar campo nome
            pageDesafio02.editarCampoNomeInline(nome);

            // Executando Assert para conferir nome atualizado
            Assert.AreEqual(nome, pageDesafio02.nomeAtualizado);

            // Executando método para editar campo e-mail
            pageDesafio02.editarCampoEmailInline(email);

            // Executando Assert para conferir email atualizado
            Assert.AreEqual("Email: " + email, pageDesafio02.emailAtualizado);

            // Executando método para editar campo telefone
            pageDesafio02.editarCampoTelefoneInline(telefone);

            // Executando Assert para conferir telefone atualizado
            Assert.AreEqual("Telefone: " + telefone, pageDesafio02.telefoneAtualizado);
        }

        [TestCleanup]
        public void fecharNavegador()
        {
            // Fechar navegador
            driver.Quit();
        }
    }
}
