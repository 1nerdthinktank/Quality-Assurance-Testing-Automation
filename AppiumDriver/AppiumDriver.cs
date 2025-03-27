using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDriver

public class AppiumDriver: IDisposable
{

        AppiumOptions options = new AppiumOptions();
        options.AddAdditionalCapability("platformName", "Android");
        options.AddAdditionalCapability("appium:deviceName", "Samsung*");
        options.AddAdditionalCapability("appium:deviceOrientation", "portrait");
        options.AddAdditionalCapability("appium:automationName", "UiAutomator2");

        options.AddAdditionalCapability("appium:appPackage", "bishopsgate280.smartspaces.d2i.co");
        options.AddAdditionalCapability("appium:appActivity", "app.smartspaces.dev.MainActivity");
        // options.AddAdditionalCapability("appium:noReset", "true");


        options.AddAdditionalCapability("appium:unlockType", "pin");
        options.AddAdditionalCapability("appium:unlockKey", "0654");


        var url = new Uri("http://localhost:4723");
        var driver = new AndroidDriver<AppiumWebElement>(url, options);

        // driver.Lock();
        // driver.Unlock();
        driver.LaunchApp();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        driver.CloseApp();


 

        /*            public IWebElement FindByName(string name) => driver.FindElement(By.Name(name));

                    public IWebElement FindByXPath(string xpath) => driver.FindElement(By.XPath(xpath));

                    public IWebElement FindByID(string id) => driver.FindElement(By.Id(id));


                    public void FillEntryFieldByName(string name, string content)
                    {
                        IWebElement element = FindByName(name);
                        element.Click();
                        element.SendKeys(content);
                    }

                    public void FillEntryFieldByXpath(string xpath, string content)
                    {
                        IWebElement element = FindByXPath(xpath);
                        element.Click();
                        element.SendKeys(content);
                    }

                    public void FillEntryFieldByID(string id, string content)
                    {
                        IWebElement element = FindByName(id);
                        element.Click();
                        element.SendKeys(content);
                    }

                    public void ButtonClickByName(string name)
                    {
                        IWebElement element = FindByName(name);
                        element.Click();
                    }

                    public void ButtonClickByXPath(string xpath)
                    {
                        IWebElement element = FindByXPath(xpath);
                        element.Click();
                    }

                    public void ButtonClickById(string id)
                    {
                        IWebElement element = FindByName(id);
                        element.Click();
                    }*/



    }
}