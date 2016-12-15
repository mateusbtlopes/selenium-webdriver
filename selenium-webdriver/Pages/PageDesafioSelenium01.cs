using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_webdriver.Pages
{
    class PageDesafioSelenium01
    {
        // Instanciando IWebDriver (Ações no Browser)
        IWebDriver driver;

        // Variáveis de retorno dos métodos
        public string tituloPagina;
        public string resultadoObtido;

        public PageDesafioSelenium01(IWebDriver driver)
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

        public String somarDoisNumerosRandomicosCorretamente()
        {
            // Pegando primeiro número
            IWebElement primeiroNumero = driver.FindElement(By.Id("number1"));

            //Convertendo primeiro número em String
            string Numero01 = Convert.ToString(primeiroNumero.Text);

            // Pegando segundo número
            IWebElement segundoNumero = driver.FindElement(By.Id("number2"));

            //Convertendo segundo número em String
            string Numero02 = Convert.ToString(segundoNumero.Text);
            
            // Transformando números em inteiros e somando os valores
            int resultadoSoma = Convert.ToInt32(Numero01) + Convert.ToInt32(Numero02);

            // Preenchendo campo de soma com o valor de resultado convertido para string
            driver.FindElement(By.Name("soma")).SendKeys(Convert.ToString(resultadoSoma));
            
            // Clicando no botão 'Enviar'
            driver.FindElement(By.Name("submit")).Click();

            // Pegando resultado fornecido pelo sistema 'CORRETO' ou 'ERRADO'
            IWebElement mensagemSistema = driver.FindElement(By.Id("resultado"));

            // Retornando resultado obtido no sistema
            return resultadoObtido = Convert.ToString(mensagemSistema.Text);
        }

        public String somarDoisNumerosRandomicosIncorretamente()
        {
            // Pegando primeiro número
            IWebElement primeiroNumero = driver.FindElement(By.Id("number1"));

            //Convertendo primeiro número em String
            string Numero01 = Convert.ToString(primeiroNumero.Text);

            // Pegando segundo número
            IWebElement segundoNumero = driver.FindElement(By.Id("number2"));

            //Convertendo segundo número em String
            string Numero02 = Convert.ToString(segundoNumero.Text);

            // Transformando números em inteiros e somando os valores
            int resultadoSoma = Convert.ToInt32(Numero01) + Convert.ToInt32(Numero02) + 1;

            // Preenchendo campo de soma com o valor de resultado convertido para string
            driver.FindElement(By.Name("soma")).SendKeys(Convert.ToString(resultadoSoma));

            // Clicando no botão 'Enviar'
            driver.FindElement(By.Name("submit")).Click();

            // Pegando resultado fornecido pelo sistema 'CORRETO' ou 'ERRADO'
            IWebElement mensagemSistema = driver.FindElement(By.Id("resultado"));

            // Retornando resultado obtido no sistema
            return resultadoObtido = Convert.ToString(mensagemSistema.Text);
        }
    }
}
