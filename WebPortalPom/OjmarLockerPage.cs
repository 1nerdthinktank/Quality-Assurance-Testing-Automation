using SeleniumDriver;

namespace PortalIntegrationTesting;

public class OjmarLockerTests
{

    private int TEST_FILE_ID = 6 { get; set; };
    private string TEST_FILE_NAME = "Ojmar Lockers" { get; set; };
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


    // Hid Selenium Tests

    /*
        // If user is assigned locker though portal
         [Test]
        public void GivenEditUserPage_WhenLockerNumberSet_ThenLockerNumberIsAssigned()
        {
        // Act
        WebDriver.AssignLocker(11);

        // Assert
        Assert.That(WebDriver.EditUserPage.User("Test User").GetLockerNumber, Is.EqualTo("11"));
    }*/

    /*
        // Appium Test

         [Test]
        public void GivenAppLockersPage_WhenScanForLockers_ThenLockersShow()
        {
            // Act
            WebDriver.ScanForLockers();

            // Assert
            Assert.That(WebDriver.SelectAppLockersPage.ScanForLockers.GetLockerNumbers, Is.EqualTo(1, 2, 3, 4, 5));
    }*/

    // What does delete card from the user list top menu do?
}