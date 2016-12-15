using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_webdriver.Pages;

namespace selenium_webdriver
{
    [TestClass]
    public class TestDesafioSelenium04
    {
        // Declarando IWebDriver
        private IWebDriver driver = null;

        [TestInitialize]
        public void abrirNavegador()
        {
            // Instanciando navegador Google Chrome
            driver = new ChromeDriver();
            
            // Abrindo página do desafio
            driver.Navigate().GoToUrl("http://eliasnogueira.com/arquivos_blog/selenium/desafio/4desafio/");
            
            // Maximizando janela do navegador
            driver.Manage().Window.Maximize();
        }
        
        [TestMethod]
        public void testAutoPreenchimentoDeCampos()
        {
            // Variáveis para preenchimento dos campos
            string cep = "01310200";
            string numero = "1234";
            string complemento = "MASP";

            // Variáveis para conferência dos campos
            string rua = "Avenida: Paulista";
            string bairro = "Bela Vista";
            string cidade = "São Paulo";
            string estado = "SP";
            
            // Instanciando página do desafio
            PageDesafioSelenium04 pageDesafio04 = new PageDesafioSelenium04(driver);

            // Executando método para capturar o título da página
            pageDesafio04.pegarTituloPagina();

            // Executando Assert para conferir título da página
            Assert.AreEqual("Auto preenchimento de campos", pageDesafio04.tituloPagina);

            // Executando método para editar campo nome
            pageDesafio04.autoPreenchimentoDeCampos(cep, numero, complemento);

            // Executando Assert para conferir rua inserida
            Assert.AreEqual(rua, pageDesafio04.ruaPreenchida);

            // Executando Assert para conferir bairro inserido
            Assert.AreEqual(bairro, pageDesafio04.bairroPreenchido);

            // Executando Assert para conferir cidade inserida
            Assert.AreEqual(cidade, pageDesafio04.cidadePreenchida);

            // Executando Assert para conferir estado inserido
            Assert.AreEqual(estado, pageDesafio04.estadoPreenchido);

            // Limpando dados preenchidos
            pageDesafio04.limparCampos();

            // Executando Assert para conferir rua em branco
            Assert.AreEqual("", pageDesafio04.ruaPreenchida);

            // Executando Assert para conferir cep em branco
            Assert.AreEqual("", pageDesafio04.cepPreenchido);

            // Executando Assert para conferir numero em branco
            Assert.AreEqual("", pageDesafio04.numeroPreenchido);

            // Executando Assert para conferir complemento em branco
            Assert.AreEqual("", pageDesafio04.complementoPreenchido);

            // Executando Assert para conferir bairro em branco
            Assert.AreEqual("", pageDesafio04.bairroPreenchido);

            // Executando Assert para conferir cidade em branco
            Assert.AreEqual("", pageDesafio04.cidadePreenchida);

            // Executando Assert para conferir estado em branco
            Assert.AreEqual("", pageDesafio04.estadoPreenchido);
          }

        [TestCleanup]
        public void fecharNavegador()
        {
            // Fechar navegador
            driver.Quit();
        }
    }
}
