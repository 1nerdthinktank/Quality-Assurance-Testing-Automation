public class IConfig
{
	public IConfig()
	{
        string "Name" {get, set };
        string "URL" {get, set };
        string "Email" { get, set };
        string "Password" { get, set };
        string "Role" { get, set };
        string "Occupier" { get, set };

        // Specify White Label Settings -> This should change the test behavior 

        bool StidFullAutoEnabled { get, set };
        bool AutoCardRegistrationEnabled { get, set };
        bool AppleWalletEnabled { get, set };
        bool CreateNewProviderUserEnabled { get, set };

        // List of Selenium options

        // List of Appium options

        // List device config, ie BLE or NFC enabled.. ect..



        // dictionary of test file ids and test id, to be run sequentially 
        int{ TestFileId : TestId } SetTestsById;

        /*
            CMS TEST ID
            Login Test = 1
            Approval Test = 2
            VMS Test = 3
            STID Test = 4
            HID Test = 5
            Ojmar Tests = 6
            Meeting Room Tests = 7
            Desk Booking = 8

            ANDROID APP TEST ID
            Login Test = 9
            Approval Test = 10
            VMS Test = 11
            STID Test = 12
            HID Test = 13
            Ojmar Tests = 14
            Meeting Room Tests = 15
            Desk Booking = 16

        */

        // dictionary of test file names and test names, to be run sequentially 
        string{ TestFileName : TestName } SetTestsByName;

    }
}
