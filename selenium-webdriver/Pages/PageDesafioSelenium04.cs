using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_webdriver.Pages
{
    class PageDesafioSelenium04
    {
        // Instanciando IWebDriver (Ações no Browser)
        IWebDriver driver;

        // Variáveis de retorno dos métodos
        public string tituloPagina;
        public string cepPreenchido;
        public string ruaPreenchida;
        public string numeroPreenchido;
        public string complementoPreenchido;
        public string bairroPreenchido;
        public string cidadePreenchida;
        public string estadoPreenchido;

        public PageDesafioSelenium04(IWebDriver driver)
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

        public void autoPreenchimentoDeCampos(string cep, string numero, string complemento)
        {
            // Encontrando campo CEP e preenchendo-o
            IWebElement campoCEP = driver.FindElement(By.Id("cep"));
            campoCEP.SendKeys(cep);

            // Encontrando campo numero e preenchendo-o
            IWebElement campoNumero = driver.FindElement(By.Id("numero"));
            campoNumero.Click();
            campoNumero.SendKeys(numero);

            // Encontrando campo complemento e preenchendo-o
            IWebElement campoComplemento = driver.FindElement(By.Id("complemento"));
            campoComplemento.SendKeys(complemento);

            // Aguardando preenchimento automático do campo rua
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("rua"), "Avenida: Paulista"));

            // Armazenar os dados do campo CEP
            cepPreenchido = Convert.ToString(campoCEP.GetAttribute("value"));

            // Armazenar os dados do campo Numero
            numeroPreenchido = Convert.ToString(campoNumero.GetAttribute("value"));

            // Armazenar os dados do campo Complemento
            complementoPreenchido = Convert.ToString(campoComplemento.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Rua
            IWebElement campoRua = driver.FindElement(By.Id("rua"));
            ruaPreenchida = Convert.ToString(campoRua.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Bairro
            IWebElement campoBairro = driver.FindElement(By.Id("bairro"));
            bairroPreenchido = Convert.ToString(campoBairro.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Cidade
            IWebElement campoCidade = driver.FindElement(By.Id("cidade"));
            cidadePreenchida = Convert.ToString(campoCidade.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Estado
            IWebElement campoEstado = driver.FindElement(By.Id("estado"));
            estadoPreenchido = Convert.ToString(campoEstado.GetAttribute("value"));
        }

        public void limparCampos()
        {
            // Encontrando botão 'Limpar' e clicando nele
            IWebElement botaoLimpar = driver.FindElement(By.CssSelector("input[value='Limpar']"));
            botaoLimpar.Click();

            // Aguardar remoção dos dados do campo CEP
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TextToBePresentInElementValue(By.Id("cep"), ""));

            // Armazenar os dados do campo CEP
            IWebElement campoCEP = driver.FindElement(By.Id("cep"));
            cepPreenchido = Convert.ToString(campoCEP.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Rua
            IWebElement campoRua = driver.FindElement(By.Id("rua"));
            ruaPreenchida = Convert.ToString(campoRua.GetAttribute("value"));

            // Armazenar os dados do campo Numero
            IWebElement campoNumero = driver.FindElement(By.Id("numero"));
            numeroPreenchido = Convert.ToString(campoNumero.GetAttribute("value"));

            // Armazenar os dados do campo Complemento
            IWebElement campoComplemento = driver.FindElement(By.Id("complemento"));
            complementoPreenchido = Convert.ToString(campoComplemento.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Bairro
            IWebElement campoBairro = driver.FindElement(By.Id("bairro"));
            bairroPreenchido = Convert.ToString(campoBairro.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Cidade
            IWebElement campoCidade = driver.FindElement(By.Id("cidade"));
            cidadePreenchida = Convert.ToString(campoCidade.GetAttribute("value"));

            // Encontrando e Armazenar os dados do campo Estado
            IWebElement campoEstado = driver.FindElement(By.Id("estado"));
            estadoPreenchido = Convert.ToString(campoEstado.GetAttribute("value"));
        }
    }
}