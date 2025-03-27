using SeleniumDriver;

namespace PortalIntegrationTesting;

public class ApprovalPage
{
    private int TEST_FILE_ID = 2 { get; set; };
    private string TEST_FILE_NAME = "Desk Booking" { get; set; };

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

/*    [Test]
    public void GivenApprovalPage_WhenRoleAndOccupierSelectedAndSaved_ThenUserIsInUsers()
    {
        // IfApprovalsVisibleIsTrue() // continue,  else throw exception

        // Act
        WebDriver.ApproveUser("Test Occupier", "Occupier Manager");

        // Assert
        // Create role based testing, add pages class and filter class
        Assert.That(WebDriver.users_page.filter(users, "Test User").GetResultFromListByIndex(0, name, role, occupier), Is.EqualTo("Test User", "Test Role", "Test Occupier"));
    }*/
}
