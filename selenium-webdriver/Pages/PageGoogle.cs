using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_webdriver.Pages
{
    class PageGoogle
    {
        // Instanciando IWebDriver (Ações no Browser)
        IWebDriver driver;

        // Variáveis de retorno dos métodos
        public string tituloPagina;
        public string resultadoObtidoPesquisa;

        public PageGoogle(IWebDriver driver)
        {
            // Classe IWebdriver
            this.driver = driver;
        }

        public String pegarTituloPagina()
        {
            // Pegando título da página
            IWebElement titulo = driver.FindElement(By.CssSelector("div[id='hplogo']"));
            
            // Retornando título da página
            return tituloPagina = Convert.ToString(titulo.GetAttribute("Title"));
        }

        public void fazerPesquisa(string termoAPesquisar)
        {
            // Encontrando o campo de pesquisa
            IWebElement campoPesquisa = driver.FindElement(By.Name("q"));

            // Preenchendo o campo de pesquisa
            campoPesquisa.SendKeys(termoAPesquisar);

            // Enviando a pesquisa
            campoPesquisa.Submit();

            // Aguardando resultado da pesquisa
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='rso']/div/div/div[1]/div/h3/a")));

            // Pegando título da pesquisa
            IWebElement resultadoPesquisa = driver.FindElement(By.XPath(".//*[@id='rso']/div/div/div[1]/div/h3/a"));

            // Retornando resultado da pesquisa
            resultadoObtidoPesquisa = Convert.ToString(resultadoPesquisa.Text);
        }
    }
}
