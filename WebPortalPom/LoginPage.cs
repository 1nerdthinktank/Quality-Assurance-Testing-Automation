

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
