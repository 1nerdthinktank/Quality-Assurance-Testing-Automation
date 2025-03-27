using SeleniumDriver;

namespace PortalIntegrationTesting;

public class AccessCardTestsHid
{
    private int TEST_FILE_ID = 5 { get; set; };
    private string TEST_FILE_NAME = "HID Card" { get; set; };

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

    // HID Tests

    /*    [Test]
        public void GivenEditUserPage_WhenHidCardDoesNotExist_ThenCreateCard()
        {
            // Act
            WebDriver.CreateCard(Hid);

            // Assert
            Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("True"));
    }*/

    /*    [Test]
public void GivenEditUserPage_WhenHidCardExists_ThenDeleteCard()
{
    // ID

    // Act
    WebDriver.DeleteCard(Stid);

    // Assert
    Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("False"));
}*/

    // Hid Tests

    /*    [Test]
public void GivenEditUserPage_WhenHidCardExists_ThenDeleteCard()
{
// Act
WebDriver.DeleteCard(Hid);

// Assert
Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("False"));
}*/

    /*    [Test]
    public void GivenEditUserPage_WhenHidCardDoesNotExist_ThenCreateCard()
    {
        // Act
        WebDriver.CreateCard(Hid);

        // Assert
        Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("True"));
    }*/

    // What does delete card from the user list top menu do?
}