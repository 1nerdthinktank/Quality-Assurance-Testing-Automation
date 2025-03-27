using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDriver

public class LoginPage
{
    private int TEST_FILE_ID = 9 { get; set; };
    private string TEST_FILE_NAME = "App Login" { get; set; };

/*
  280 BISHOPSGATE FLUTTER APP ANDROID LOGIN PAGE

  Email Entry Field
  Android Element ID = 00000000-0000-0205-0000-000a00000004
  XPath = /hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.EditText[2]
  Class = android.widget.EditText
  Text = Password
  Index = 0

  Password Entry Field
  Android Element ID = 00000000-0000-0205-0000-000a00000004
  XPath = /hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.EditText[2]
  Class = android.widget.EditText
  Text = Password
  Index = 1

  Show Password Widget
  Android Element ID = 00000000-0000-0205-0000-001000000004
  XPath = /hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]
  Class = android.view.View
  Index = 2

  Login Widget
  Accessibility ID = LOGIN
  Android Element ID = Null!?
  XPath = //android.view.View[@content-desc="LOGIN"]
  Class = android.view.View
  Text = Null!?
  Index = 3

  Forgotten Password Widget
  Accessibility ID = Forgotten Password
  Android Element ID = Null!?
  XPath = //android.view.View[@content-desc="Forgotten Password"]
  Class = android.view.View
  Text = Null!?
  Index = 4

  Register Widget
  Accessibility ID = Register
  Android Element ID = 00000000-0000-0205-0000-000f00000004
  XPath = //android.view.View[@content-desc="Register"]
  Class = android.view.View
  Text = Null!?
  Index = 5
*/

public class LoginPage
{

    // add login page init

    {
    public void Login(string username, string password)
    {
        if (CurrentUrl != PortalUrl)
        {
            WebDriver.NavigateTo(PortalUrl);
        }
        WebDriver.FillEntryFieldByName("Email", username);
        WebDriver.FillEntryFieldByName("Password", password);
        WebDriver.ButtonClickByName("OperationValue");
        WebDriver.WaitForNavigation();
    }

    public string FindLoginErrorMessage(string invalidLoginXPath = "/html/body/div/div/div[2]/div[1]/div/div[2]/form/div[1]/ul/li")
    {
        return WebDriver.GetElementText(invalidLoginXPath);
    }

    public void MultipleLogins(string username, string password, int attempts)
    {
        while (attempts > 0)
        {
            Login(username, password);
            attempts--;
        }
    }
}
}
}
