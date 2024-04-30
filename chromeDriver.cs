using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Defina o caminho para o ChromeDriver
        string driverPath = @"C:\Users\polon\OneDrive\Documentos\GitHub\whatsAPI\utilities\chromedriver.exe";

        // Inicialize o ChromeDriver
        var driver = new ChromeDriver(driverPath);

        // Navegue até o WhatsApp Web
        driver.Navigate().GoToUrl("https://web.whatsapp.com/");

        // Aguarde até que o usuário faça login no WhatsApp Web manualmente
        Console.WriteLine("Faça login no WhatsApp Web e pressione Enter.");
        Console.ReadLine();

        // Aguarde um momento para que a página seja carregada completamente
        System.Threading.Thread.Sleep(5000); // Espera de 5 segundos

        // Encontre e clique no ícone de chat para abrir a lista de contatos
        var chatIcon = driver.FindElement(By.XPath("//div[@class='_3qx7_']"));
        chatIcon.Click();

        // Aguarde um momento para que a lista de contatos seja carregada
        System.Threading.Thread.Sleep(2000); // Espera de 2 segundos

        // Encontre todos os elementos que representam os contatos na lista
        var contactElements = driver.FindElements(By.XPath("//div[@class='_210SC']"));

        // Lista para armazenar os nomes dos contatos
        List<string> contacts = new List<string>();

        // Itere sobre os elementos dos contatos para obter os nomes
        foreach (var contactElement in contactElements)
        {
            string contactName = contactElement.Text;
            contacts.Add(contactName);
        }

        // Imprima os contatos na lista
        Console.WriteLine("Meus contatos:");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }

        // Feche o navegador quando terminar
        driver.Quit();
    }
}
