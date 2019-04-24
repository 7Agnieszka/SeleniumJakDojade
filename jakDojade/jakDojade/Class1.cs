using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

[TestFixture]
class EntryPoint

{



    [Test]
    public void Krakow_City_Set_up()
    {
        By PRZYCISK_RODO = By.CssSelector(".cmp-button_button.cmp-intro_acceptAll");
        By PRZYCISK_WYBORU_MIASTA = By.CssSelector(".cn-city-list-button.ng-scope");
        By KRAKOW = By.XPath("//a[@href='krakow']");

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

        Assert.AreEqual("https://jakdojade.pl/krakow/trasa/", driver.Url, "Pass");
        Thread.Sleep(300);
        driver.Quit();
    }



    [Test]
    public void Krakow_From_Map()
    {
        By PRZYCISK_RODO = By.CssSelector(".cmp-button_button.cmp-intro_acceptAll");
        By PRZYCISK_WYBORU_MIASTA = By.CssSelector(".cn-city-list-button.ng-scope");
        By KRAKOW = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Stops'])[1]/following::a[3]");

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


        Assert.AreEqual("https://jakdojade.pl/krakow/trasa/", driver.Url, "Pass");


        Thread.Sleep(300);
        driver.Quit();
    }

}




