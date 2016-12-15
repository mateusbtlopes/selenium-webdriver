using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_webdriver.Pages
{
    class PageDesafioSelenium02
    {
        // Instanciando IWebDriver (Ações no Browser)
        IWebDriver driver;

        // Variáveis de retorno dos métodos
        public string tituloPagina;
        public string nomeAtualizado;
        public string emailAtualizado;
        public string telefoneAtualizado;

        public PageDesafioSelenium02(IWebDriver driver)
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

        public String editarCampoNomeInline(String nome)
        {
            // Encontrando campo nome e clicando no campo
            IWebElement campoNome = driver.FindElement(By.Id("name_rg_display_section"));
            campoNome.Click();

            // Encontrando nome da pessoa e limpando nome da pessoa
            IWebElement nomePessoa = driver.FindElement(By.Id("nome_pessoa"));
            nomePessoa.Clear();

            // Inserindo novo nome
            nomePessoa.SendKeys(nome);

            // Encontrando botão 'Salvar' e clicando nele
            IWebElement botaoSalvarNome = driver.FindElement(By.CssSelector("#name_hv_editing_section > input[value='Salvar']"));
            botaoSalvarNome.Click();

            // Aguardando novo nome aparecer no campo nome
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("name_hv_saving_section")));

            // Retornando nome atualizado da pessoa
            return nomeAtualizado = Convert.ToString(campoNome.Text);
        }

        public String editarCampoEmailInline(String email)
        {
            // Encontrando campo email e clicando no campo
            IWebElement campoEmail = driver.FindElement(By.Id("email_rg_display_section"));
            campoEmail.Click();

            // Encontrando email da pessoa e limpando nome da pessoa
            IWebElement enderecoEmail = driver.FindElement(By.Id("email_value"));
            enderecoEmail.Clear();

            // Inserindo novo email
            enderecoEmail.SendKeys(email);

            // Encontrando botão 'Salvar' e clicando nele
            IWebElement botaoSalvarEmail = driver.FindElement(By.CssSelector("#email_hv_editing_section > input[value='Salvar']"));
            botaoSalvarEmail.Click();

            // Aguardando novo email aparecer no campo email
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("email_hv_saving_section")));

            // Retornando email atualizado da pessoa
            return emailAtualizado = Convert.ToString(campoEmail.Text);
        }

        public String editarCampoTelefoneInline(String telefone)
        {
            // Encontrando campo telefone e clicando no campo
            IWebElement campoTelefone = driver.FindElement(By.Id("phone_rg_display_section"));
            campoTelefone.Click();

            // Encontrando telefone da pessoa e limpando nome da pessoa
            IWebElement numeroTelefone = driver.FindElement(By.Id("phone_value"));
            numeroTelefone.Clear();

            // Inserindo novo telefone
            numeroTelefone.SendKeys(telefone);

            // Encontrando botão 'Salvar' e clicando nele
            IWebElement botaoSalvarTelefone = driver.FindElement(By.CssSelector("#phone_hv_editing_section > input[value='Salvar']"));
            botaoSalvarTelefone.Click();

            // Aguardando novo telefone aparecer no campo telefone
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("phone_hv_saving_section")));

            // Retornando telefone atualizado da pessoa
            return telefoneAtualizado = Convert.ToString(campoTelefone.Text);
        }
    }
}