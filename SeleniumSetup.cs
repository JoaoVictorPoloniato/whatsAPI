using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SeleniumSetup
{
    public static IWebDriver InitializeDriver(string driverPath)
    {
        return new ChromeDriver(driverPath);
    }
}
