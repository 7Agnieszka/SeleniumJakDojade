using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;


class EntryPoint

{
    private static By PRZYCISK_RODO = By.CssSelector(".cmp-button_button.cmp-intro_acceptAll");
    private static By PRZYCISK_WYBORU_MIASTA = By.CssSelector(".cn-city-list-button.ng-scope");
    private static By KRAKOW = By.XPath("//a[@href='krakow']");




    static void Main()
    {
        //inicjowanie sterowinka przeglądarki
        IWebDriver driver = new ChromeDriver();
        //przejście do strony jakdojade
        driver.Navigate().GoToUrl("http://jakdojade.pl");
        //definicja elementu komunikatu rodo
        IWebElement komunikat_rodo = driver.FindElement(PRZYCISK_RODO);
        //jesli komunikat rodo wyświetla się
        if (komunikat_rodo.Displayed)
        {
            //kliknięcie rodo
            driver.FindElement(PRZYCISK_RODO).Click();
            //kliknięcie wyboru miasta
            driver.FindElement(PRZYCISK_WYBORU_MIASTA).Click();
            //wybór miasta z listy
            driver.FindElement(KRAKOW).Click();
        }
        //sprawdzenie adreu strony
        if (driver.Url == "https://jakdojade.pl/krakow/trasa/")
        {
            PassMessage("Strona się wyświetliła");
        }
        else
        {
            FailMessage("Strona się nie wyświetliła");
        }











        Thread.Sleep(3000);


        driver.Quit();
    }


    private static void PassMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }



    private static void FailMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }


}

