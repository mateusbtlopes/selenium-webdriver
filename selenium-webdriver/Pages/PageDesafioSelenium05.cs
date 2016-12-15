using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_webdriver.Pages
{
    class PageDesafioSelenium05
    {
        // Instanciando IWebDriver (Ações no Browser)
        IWebDriver driver;

        // Variáveis de retorno dos métodos
        public string tituloPagina;
        public string resultadoObtido;
     
        public PageDesafioSelenium05(IWebDriver driver)
        {
            // Classe IWebdriver
            this.driver = driver;
        }

        public String pegarTituloPagina()
        {
            // Pegando título da página
            IWebElement titulo = driver.FindElement(By.CssSelector("h1"));
            
            // Retornando título da página
            return tituloPagina = Convert.ToString(titulo.Text);
        }

        public void preenchimentoDeCamposComIDsDinamicos(string username1, string username2, string password1, string password2)
        {
            // Encontrando campo Username1 e preenchendo-o
            IWebElement campoUsername1 = driver.FindElement(By.XPath("//label[text() = 'Username']/following-sibling::div/input"));
            campoUsername1.SendKeys(username1);

            // Encontrando campo Username2 e preenchendo-o
            IWebElement campoUsername2 = driver.FindElement(By.XPath("//label[text() = 'Username (repetir)']/following-sibling::div/input"));
            campoUsername2.SendKeys(username2);

            // Encontrando campo Password1 e preenchendo-o
            IWebElement campoPassword1 = driver.FindElement(By.XPath("//label[text() = 'Password']/following-sibling::div/input"));
            campoPassword1.SendKeys(password1);

            // Encontrando campo Password2 e preenchendo-o
            IWebElement campoPassword2 = driver.FindElement(By.XPath("//label[text() = 'Password (repetir)']/following-sibling::div/input"));
            campoPassword2.SendKeys(password2);

            // Encontrando o botão 'Enviar' e clicando nele
            IWebElement botaoEnviar = driver.FindElement(By.Id("submitBtn2"));
            botaoEnviar.Click();

            // Encontrando e Armazenar os dados do campo Estado
            IWebElement mensagemResultado = driver.FindElement(By.Id("errorDiv2"));
            resultadoObtido = Convert.ToString(mensagemResultado.Text);
        }
    }
}