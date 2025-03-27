using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDriver

public class LoginTests : ITests
{
    private int TEST_FILE_ID = 18 { get; set; };
    private string TEST_FILE_NAME = "Android App Login" { get; set; };

using SeleniAppDriver;

[TestFixture]
public class LoginTests: ITests
{
	private int TEST_FILE_ID = 1 { get; set; };
	private string TEST_FILE_NAME = "Login" { get; set; };
	private PortalDriver WebDriver { get; set; }


// Arrange Before Every Test
[SetUp]
public void Setup()
{
	WebDriver = new PortalDriver();
	WebDriver.Initialise();
}

// Close After Every Test
[TearDown]
public void TearDown()
{
	WebDriver.Dispose();
}

// each test should be an ITest
[Test]
public void GivenLoginPage_WhenEmailPasswordCorrect_ThenLoginSuccessful()
{
	// Act
	WebDriver.Login("a.corley@smartspaces.app", "*******");

	// Assert
	Assert.That(WebDriver.CurrentUrl, Is.EqualTo(@"https://portsokenhouse.smarttwin.app/portsokenhouse/VersionReview/Index"));
}

// each test should be an ITest
[Test]
public void GivenLoginPage_WhenEmailPasswordIncorrect_ThenLoginUnsuccessful()
{
	// Act
	WebDriver.Login("incorrect_email@test.com", "Incorrect_Password");

	// Assert
	Assert.That(WebDriver.FindLoginErrorMessage(), Is.EqualTo(@"Invalid Login Attempt."));
}
// each test should be an ITest
[Test]
public void GivenLoginPage_WhenInvalidEmail_ThenLoginUnsuccessful()
{
	// Act
	WebDriver.Login("INVALID_EMAIL_123", "Incorrect_Password");

	// Assert
	Assert.That(WebDriver.FindLoginErrorMessage(), Is.EqualTo(@"Invalid Email Format"));

	Assert.That()
	// IsDisplayed() = FALSE


	*TODO: No Invalid Email Error Message?
         
    }

    [Test]
public void GivenLoginPage_WhenIncorrectLoginAttemptedFiveTimes_ThenAccountIsLocked()
{
	// Act
	WebDriver.MultipleLogins("a.corley@d2i.co.uk", "Incorrect_Password", 5);

	// Assert
	Assert.That(WebDriver.FindLoginErrorMessage(), Is.EqualTo("This account has been locked out."));

}

[Test]
public void GivenLoginPage_WhenSQLiOnEmailField_ThenPageResponseIsSame()
{
	var injections = FileUtil.ReadInjections(@".\res\sqli_wordlist.csv");

	List<string> responses = injections.Select(injection =>
	{
		//Act
		WebDriver.Login(injection, "TestPass");
		return WebDriver.CurrentUrl;
	}).ToList();

	// Assert
	string firstResponse = responses.First();
	Assert.IsTrue(
		responses.Skip(1).All(s => string.Equals(firstResponse, s, StringComparison.InvariantCultureIgnoreCase))
	);

}

}


}
