
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Formats.Asn1;
using System.Globalization;

/*
Alix Corley
------------------------------------------------------------------------------------------------------

TODO: (headless meaning, they can be run via command line, with arguments i.e. username/pw) -> use default value, if no args are supplied

------------------------------------------------------------------------------------------------------


DONE: run a new browser session
      go to one of the portals
      try and login
      verify login has occurred in a reasonable time frame
      verify the user can then do some harmless action such as navigate to another page
      display success output

DONE: Logging into an account that has been locked out, and verifying the message a user receives

DONE: Logging into an account that does not exist / password does not match

------------------------------------------------------------------------------------------------------
*/


namespace SeleniumDriver;

public class SeleniumDriver : IDisposable
{
    //TODO: Make Delays Different Depending on Task
    public readonly TimeSpan EntryFieldDelay = TimeSpan.FromMilliseconds(1000);
    public readonly TimeSpan EntryFieldPostDelay = TimeSpan.FromMilliseconds(1000);
    public readonly TimeSpan NavigationDelay = TimeSpan.FromMilliseconds(3000);

    private IWebDriver WebDriver { get; set; }

    public string CurrentUrl => WebDriver.Url;

    private ChromeOptions GetDefaultOptions()
    {
        var options = new ChromeOptions();
        options.AddExcludedArguments(new List<string>{
            "enable-automation",
            "excludeSwitches",
            "enable-logging",
            "disable-popup-blocking"
        });
        return options;
    }

    public void Initialise()
    {
        var options = GetDefaultOptions();
        WebDriver = new ChromeDriver(options);
        // WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        WebDriver.Manage().Window.Maximize();
    }


    // User Actions 

    public void NavigateTo(string url)
    {
        WebDriver.Url = url;
    }

    public void FillEntryFieldByName(string name, string content, bool clearFirst = true)
    {
        IWebElement element = FindByName(name);
        element.Click();
        Thread.Sleep(EntryFieldDelay);
        if (clearFirst)
        {
            element.SendKeys(Keys.Control + "a");
        }
        element.SendKeys(content);
        Thread.Sleep(EntryFieldPostDelay);
    }

    public void ButtonClickByName(string name)
    {
        IWebElement element = FindByName(name);
        element.Click();
    }

    public string GetElementText(string xpath)
    {
        IWebElement element = FindByXpath(xpath);
        return element.Text;

    }

    public bool IsElementDisplayed(string xpath)
    {
        IWebElement element = FindByXpath(xpath);
        return element.Displayed;
    }

    public void WaitForNavigation()
    {
        Thread.Sleep(NavigationDelay);
    }

    // Different ways to find elements by 
    private IWebElement FindByName(string name) => WebDriver.FindElement(By.Name(name));

    private IWebElement FindByXpath(string xpath) => WebDriver.FindElement(By.XPath(xpath));

    private IWebElement FindByClassName(string className) => WebDriver.FindElement(By.ClassName(className));

    private IWebElement FindByCss(string cssId) => WebDriver.FindElement(By.CssSelector(cssId));


    public void Dispose()
    {
        WebDriver.Close();
        WebDriver.Quit();
        WebDriver.Dispose();
    }

}
