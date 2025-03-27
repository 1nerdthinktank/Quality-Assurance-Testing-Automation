using SeleniumDriver;

namespace PortalIntegrationTesting;

public class VisitorManagementTesting
{

    private int TEST_FILE_ID = 3 { get; set; };
    private string TEST_FILE_NAME = "VMS" { get; set; };

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

    /*
    TODO: SELENIUM (TESTING OUR CMS SOFTWARE) CREATE APPOINTMENT IN PORTAL

    [Test]
    public void GivenVisitorsAppointmentPage_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));

    TODO: CONFIRM EMAIL IS RECEIVED 

    TODO: APPIUM (TESTING USERS DEVICES) OPEN EMAIL AND QR IMAGE

    [Test]
    public void GivenVisitorsAppointmentPage_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));

    TODO: AUTOMATE_ACTIONS_IN_OFFICE_TESTBED (TESTING 3rd PARTY DEVICES) SCAN QR CODE

    [Test]
    public void GivenVisitorsQRCode_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));

    TODO: AUTOMATE_ACTIONS_IN_CLOUD_SERVER (TESTING 3rd PARTY ACS) QR INFO CONFIRMED & ACCESS GRANTED IN EVENT LOGS

    [Test]
    public void GivenVisitorsQRCode_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));

    TODO: SELENIUM (TESTING SMART SPACES CMS PORTAL ) VISITOR APPOINTMENT STATUS FROM PRE-BOOKED TO ARRIVED

    [Test]
    public void GivenVisitorsQRCode_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));

    TODO: AUTOMATE_ACTIONS_IN_CLOUD_SERVER (TESTING 3rd PARTY ACS) QR INFO CONFIRMED & ACCESS DENIED IN EVENT LOGS

    [Test]
    public void GivenVisitorsQRCode_WhenAppointmentIsCreated_ThenBookingVisible()
    {
        // Act
        WebDriver.CreateAppointment("Test User 1", 10/10/23, 10:00, "Test Visitor 1");

        // Assert
        Assert.That(WebDriver.VisitorsPage("Test User", 10/10/23, 10:00).AppointmentExists, Is.EqualTo("True"));



}*/

}
