// Remova qualquer declaração de namespace

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Defina o caminho para o ChromeDriver
        string driverPath = @"C:\Users\polon\OneDrive\Documentos\GitHub\whatsAPI\utilities\chromedriver.exe";

        // Inicialize o ChromeDriver
        var driver = new ChromeDriver(driverPath);

        // Agora você pode usar o driver para interagir com o navegador

        // Por exemplo, abrir uma página da web
        driver.Navigate().GoToUrl("https://www.google.com");

        // Feche o navegador quando terminar
        driver.Quit();
    }
}
