namespace SeleniumDriver;

public class PortalDriver : IDisposable
{
    private const string PortalUrl = @"https://portsokenhouse.smarttwin.app/account/login?whiteLabel=portsokenhouse";

    private readonly SeleniumDriver WebDriver = new SeleniumDriver();

    public void Initialise()
    {
        WebDriver.Initialise();
    }

/*    public void Login(string username, string password)
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
    }*/
    // Navigation
    // TODO: Navigate.Menu.Click("Settings")
    // TODO: NavigateMenuAndClick("Settings")

/*    public void NavigateTo()
    {
        WebDriver.Navigate.Menu.Click("Settings");
    }*/

    // Action
    // TODO: Action.Filter.
    // TODO: SelectFilter("Email", "a.corley@smartspaces.app")

/*    public void Action()
    {
        WebDriver.Action.Filter.Enter("Users");
    }*/

    // Action
    // TODO: Action.Filter.
    // TODO: SelectFilter("Email", "a.corley@smartspaces.app")

/*    public void Assert()
    {
        WebDriver.Assert.Filter.Enter("Users");
    }*/

    public void Dispose()
    {
        WebDriver.Dispose();
    }

    public string CurrentUrl => WebDriver.CurrentUrl;

}
