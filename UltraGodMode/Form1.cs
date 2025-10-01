using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UltraGodMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void godModeItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (godModeItems.SelectedItems.Count > 0)
                {
                    e.Handled = true;
                    launchButton.PerformClick();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            godModeItems.Columns.Add("Name", 300);
            godModeItems.Columns.Add("Path", 450);

            // Here we add items to the ListView using a function to cut down on redundancy.
            AddItemToListView("Task Manager", "taskmgr.exe");
            AddItemToListView("Services", "services.msc");
            AddItemToListView("Control Panel", "control.exe");
            AddItemToListView("System Restore", "rstrui.exe");
            AddItemToListView("Registry Editor", "regedit.exe");
            AddItemToListView("Command Prompt", "cmd.exe");
            AddItemToListView("Windows Security", "windowsdefender://");
            AddItemToListView("Windows Security Network Settings", "windowsdefender://network");
            AddItemToListView("Windows Security Protection History", "windowsdefender://history");
            AddItemToListView("Settings", "ms-settings:");
            AddItemToListView("Sound Settings", "ms-settings:sound");
            AddItemToListView("Account Settings", "ms-settings:accounts");
            AddItemToListView("Volume Mixer Settings", "ms-settings:apps-volume");
            AddItemToListView("Battery Settings", "ms-settings:batterysaver");
            AddItemToListView("Date and Time Settings", "ms-settings:dateandtime");
            AddItemToListView("Network Settings", "ms-settings:network");
            AddItemToListView("Notification Settings", "ms-settings:notifications");
            AddItemToListView("Location Privacy Settings", "ms-settings:privacy-location");
            AddItemToListView("Microphone Privacy Settings", "ms-settings:privacy-microphone");
            AddItemToListView("Taskbar Settings", "ms-settings:taskbar");
            AddItemToListView("Windows Update", "ms-settings:windowsupdate");
            AddItemToListView("Windows Update: Uninstall Updates", "ms-settings:windowsupdate-uninstallupdates");
            AddItemToListView("Programs and Features", "appwiz.cpl");
            AddItemToListView("Bluetooth Settings", "bthprops.cpl");
            AddItemToListView("Display Settings", "desk.cpl");
            AddItemToListView("Windows Defender Firewall Settings", "Firewall.cpl");
            AddItemToListView("Device Manager", "hdwwiz.cpl");
            AddItemToListView("Internet Properties", "inetcpl.cpl");
            AddItemToListView("Regional Settings", "intl.cpl");
            AddItemToListView("Color Management", "colorcpl.exe");
            AddItemToListView("Add Hardware Wizard", "hdwwiz.exe");
            AddItemToListView("System Information", "msinfo32.exe");
            AddItemToListView("Group Policy Editor", "gpedit.msc");
            AddItemToListView("Computer Management", "lusrmgr.msc");
            AddItemToListView("User Account Control Settings", "UserAccountControlSettings.exe");
            AddItemToListView("Add New User", "ms-cxh://setaddnewuser");
            AddItemToListView("Event Viewer", "eventvwr.exe");
            AddItemToListView("Authorization Manager", "azman.msc");
            AddItemToListView("Certificates", "certlm.msc");
            AddItemToListView("Component Services", "comexp.msc");
            AddItemToListView("DevModeRunAsUserConfig", "DevModeRunAsUserConfig.msc");
            AddItemToListView("Disk Management", "diskmgmt.msc");
            AddItemToListView("Shared Folders", "fsmgmt.msc");
            AddItemToListView("Performance Monitor", "perfmon.msc");
            AddItemToListView("Print Management", "printmanagement.msc");
            AddItemToListView("Resultant Set of Policy", "rsop.msc");
            AddItemToListView("Local Security Policy", "secpol.msc");
            AddItemToListView("Task Scheduler", "taskschd.msc");
            AddItemToListView("TPM Management", "tpm.msc");
            AddItemToListView("Windows Defender Firewall with Advanced Security", "wf.msc");
            AddItemToListView("Windows Management Instrumentation", "wmimgmt.msc");
            AddItemToListView("System Properties - Advanced", "SystemPropertiesAdvanced.exe");
            AddItemToListView("System Properties - Computer Name", "SystemPropertiesComputerName.exe");
            AddItemToListView("System Properties - Hardware", "SystemPropertiesHardware.exe");
            AddItemToListView("System Properties - Performance", "SystemPropertiesPerformance.exe");
            AddItemToListView("System Properties - Protection", "SystemPropertiesProtection.exe");
            AddItemToListView("System Properties - Remote", "SystemPropertiesRemote.exe");
            AddItemToListView("Digitizer Calibration Tool", "tabcal.exe");
            AddItemToListView("Optional Windows Features", "optionalfeatures.exe");
            AddItemToListView("DirectX Diagnostic Tool", "dxdiag.exe");
            AddItemToListView("Available Networks", "ms-availablenetworks:");
            AddItemToListView("Device Discovery/Cast Settings", "ms-settings-connectabledevices:devicediscovery");
            AddItemToListView("Workplace Settings", "ms-settings:workplace");
            AddItemToListView("Email and Accounts Settings", "ms-settings:emailandaccounts");
            AddItemToListView("Other Users", "ms-settings:otherusers");
            AddItemToListView("Family Settings", "ms-settings:family-group");
            AddItemToListView("Set Up A Kiosk", "ms-settings:assignedaccess");
            AddItemToListView("Sign-in Options", "ms-settings:signinoptions");
            AddItemToListView("Windows Hello Setup (Face Unlock)", "ms-settings:signinoptions-launchfaceenrollment");
            AddItemToListView("Windows Hello Setup (Fingerprint Unlock)", "ms-settings:signinoptions-launchfingerprintenrollment");
            AddItemToListView("Your Info", "ms-settings:yourinfo");
            AddItemToListView("Apps and Features (Settings)", "ms-settings:appsfeature");
            AddItemToListView("App Features", "ms-settings:appsfeatures-app");
            AddItemToListView("Apps for Websites", "ms-settings:appsforwebsites");
            AddItemToListView("Default App Settings", "ms-settings:defaultapps");
            AddItemToListView("Optional Features (Settings)", "ms-settings:optionalfeatures");
            AddItemToListView("Offline Maps", "ms-settings:maps");
            AddItemToListView("Download Offline Maps", "ms-settings:maps-downloadmaps");
            AddItemToListView("Startup Apps", "ms-settings:startupapps");
            AddItemToListView("Video Playback", "ms-settings:videoplayback");
            AddItemToListView("AutoPlay Settings", "ms-settings:autoplay");
            AddItemToListView("Connected Devices Settings", "ms-settings:connecteddevices");
            AddItemToListView("Camera Settings", "ms-settings:camera");
            AddItemToListView("Mouse and Touchpad Settings", "ms-settings:mousetouchpad");
            AddItemToListView("Pen and Windows Ink Settings", "ms-settings:pen");
            AddItemToListView("Printers and Scanners Settings", "ms-settings:printers");
            AddItemToListView("Touch Settings", "ms-settings:devices-touch");
            AddItemToListView("Touchpad Settings", "ms-settings:devices-touchpad");
            AddItemToListView("Text Suggestions Settings", "ms-settings:devicestyping-hwkbtextsuggestions");
            AddItemToListView("Typing Settings", "ms-settings:typing");
            AddItemToListView("USB Settings", "ms-settings:usb");
            AddItemToListView("Audio Accessibility Settings", "ms-settings:easeofaccess-audio");
            AddItemToListView("Closed Captions Settings", "ms-settings:easeofaccess-closedcaptioning");
            AddItemToListView("Color Filter Settings", "ms-settings:easeofaccess-colorfilter");
            AddItemToListView("Display Settings", "ms-settings:easeofaccess-colorfilter-adaptivecolorlink");
            AddItemToListView("Night Light Settings", "ms-settings:easeofaccess-colorfilter-bluelightlink");
            AddItemToListView("Eye Control Settings", "ms-settings:easeofaccess-eyecontrol");
            AddItemToListView("Fonts Settings", "ms-settings:fonts");
            AddItemToListView("High Contrast Settings", "ms-settings:easeofaccess-highcontrast");
            AddItemToListView("Keyboard Settings", "ms-settings:easeofaccess-keyboard");
            AddItemToListView("Mouse Settings", "ms-settings:easeofaccess-mouse");
            AddItemToListView("Magnifier Settings", "ms-settings:easeofaccess-magnifier");
            AddItemToListView("Mouse Pointer and Touch Settings", "ms-settings:easeofaccess-mousepointer");
            AddItemToListView("Narrator Settings", "ms-settings:easeofaccess-narrator");
            AddItemToListView("Speech Recognition Settings", "ms-settings:easeofaccess-speechrecognition");
            AddItemToListView("Text Cursor Settings", "ms-settings:easeofaccess-cursor");
            AddItemToListView("Visual Effects Accessibility Settings", "ms-settings:easeofaccess-visualeffects");
            AddItemToListView("Game Bar Settings", "ms-settings:gaming-gamebar");
            AddItemToListView("Game DVR Settings", "ms-settings:gaming-gamedvr");
            AddItemToListView("Game Mode Settings", "ms-settings:gaming-gamemode");
            AddItemToListView("Default Browser Setttings", "ms-settings:defaultbrowsersettings");
            AddItemToListView("Advanced Network Settings", "ms-settings:network-advancedsettings");
            AddItemToListView("Airplane Mode Settings", "ms-settings:network-airplanemode");
            AddItemToListView("Dial-Up Settings", "ms-settings:network-dialup");
            AddItemToListView("Ethernet Settings", "ms-settings:network-ethernet");
            AddItemToListView("Known Network Settings", "ms-settings:network-wifisettings");
            AddItemToListView("Mobile Hotspot Settings", "ms-settings:network-mobilehotspot");
            AddItemToListView("Proxy Settings", "ms-settings:network-proxy");
            AddItemToListView("VPN Settings", "ms-settings:network-vpn");
            AddItemToListView("Wi-Fi Settings", "ms-settings:network-wifi");
            AddItemToListView("Background Settings", "ms-settings:personalization-background");
            AddItemToListView("Colors Settings", "ms-settings:personalization-colors");
            AddItemToListView("Lock Screen Settings", "ms-settings:lockscreen");
            AddItemToListView("Start Folder Settings", "ms-settings:personalization-start-places");
            AddItemToListView("Themes Settings", "ms-settings:themes");
            AddItemToListView("Taskbar Settings", "ms-settings:taskbar");
            AddItemToListView("Device Usage Settings", "ms-settings:deviceusage");
            AddItemToListView("Privacy and Security", "ms-settings:privacy");
            AddItemToListView("Privacy and Security - Account Info", "ms-settings:privacy-accountinfo");
            AddItemToListView("Privacy and Security - App Diagnostics", "ms-settings:privacy-appdiagnostics");
            AddItemToListView("Privacy and Security - Automatic File Downloads", "ms-settings:privacy-automaticfiledownloads");
            AddItemToListView("Privacy and Security - Calendar", "ms-settings:privacy-calendar");
            AddItemToListView("Privacy and Security - Call History", "ms-settings:callhistory");
            AddItemToListView("Privacy and Security - Camera", "ms-settings:privacy-webcam");
            AddItemToListView("Privacy and Security - Contacts", "ms-settings:privacy-contacts");
            AddItemToListView("Privacy and Security - Diagnostics and Feedback", "ms-settings:privacy-feedback");
            AddItemToListView("Privacy and Security - Documents", "ms-settings:privacy-documents");
            AddItemToListView("Privacy and Security - Downloads Folder", "ms-settings:privacy-downloadsfolder");
            AddItemToListView("Privacy and Security - Email", "ms-settings:privacy-email");
            AddItemToListView("Privacy and Security - File System", "ms-settings:privacy-broadfilesystemaccess");
            AddItemToListView("Privacy and Security - Screenshots and Screen Recording", "ms-settings:privacy-graphicscaptureprogrammatic");
            AddItemToListView("Privacy and Security - Screenshot Borders", "ms-settings:privacy-graphicscapturewithoutborder");
            AddItemToListView("Privacy and Security - Inking and Typing Personalization", "ms-settings:privacy-speechtyping");
            AddItemToListView("Privacy and Security - Location", "ms-settings:privacy-location");
            AddItemToListView("Privacy and Security - Messaging", "ms-settings:privacy-messaging");
            AddItemToListView("Privacy and Security - Microphone", "ms-settings:privacy-microphone");
            AddItemToListView("Privacy and Security - Music Library", "ms-settings:privacy-musiclibrary");
            AddItemToListView("Privacy and Security - Notifications", "ms-settings:privacy-notifications");
            AddItemToListView("Privacy and Security - Other Devices", "ms-settings:privacy-customdevices");
            AddItemToListView("Privacy and Security - Pictures", "ms-settings:privacy-pictures");
            AddItemToListView("Privacy and Security - Radios", "ms-settings:pr vcfds1ivacy-radios");
            AddItemToListView("Privacy and Security - Speech", "ms-settings:privacy-speech");
            AddItemToListView("Privacy and Security - Tasks", "ms-settings:privacy-tasks");
            AddItemToListView("Privacy and Security - Videos", "ms-settings:privacy-videos");
            AddItemToListView("Privacy and Security - Voice Activation", "ms-settings:privacy-voiceactivation");
            AddItemToListView("Privacy and Security - Search", "ms-settings:search");
            AddItemToListView("About Device", "ms-settings:about");
            AddItemToListView("Clipboard Settings", "ms-settings:clipboard");
            AddItemToListView("Default Save Locations", "ms-settings:savelocations");
            AddItemToListView("Focus Settings", "ms-settings:quiethours");
            AddItemToListView("Application Graphics Settings", "ms-settings:display-advancedgraphics");
            AddItemToListView("Multitasking Settings", "ms-settings:multitasking");
            AddItemToListView("Night Light Settings", "ms-settings:nightlight");
            AddItemToListView("Projecting to this PC Settings", "ms-settings:project");
            AddItemToListView("Nearby Sharing Settings", "ms-settings:crossdevice");
            AddItemToListView("Remote Desktop Settings", "ms-settings:remotedesktop");
            AddItemToListView("Sound Device Settings", "ms-settings:sound-devices");
            AddItemToListView("Storage Settings", "ms-settings:storagesense");
            AddItemToListView("Storage Policies", "ms-settings:storagepolicies");
            AddItemToListView("Disks and Volumes", "ms-settings:disksandvolumes");
            AddItemToListView("Japan IME Settings", "ms-settings:japan-ime");
            AddItemToListView("Language and Region Settings", "ms-settings:regionformatting");

            // Now we add some third-party options if we detect that those programs are installed.
            if (System.IO.Directory.Exists(@"C:\Program Files (x86)\Steam")) // To-Do: Add a non-directory specific way of detecting Steam.
            {
                AddItemToListView("Steam Client Developer Console", "steam://nav/console");
                AddItemToListView("Steam Client Settings", "steam://settings");
            }

            // The below code allows the ENTER code to function.
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (godModeItems.SelectedItems.Count == 0)
            {
                return;
            }
            string selectedItem = godModeItems.SelectedItems[0].SubItems[1].Text?.Trim();
            // Warning system due to some ms-cxh commands doing potentially unwanted behavior. We ignore setaddnewuser as it's the command that is executed for adding new users from the Settings app.
            if (selectedItem.StartsWith("ms-cxh", StringComparison.OrdinalIgnoreCase) && selectedItem != "ms-cxh://setaddnewuser")
            {
                DialogResult WarnResult = MessageBox.Show("'ms-cxh' items may modify your device's settings, including adding a demo Microsoft account to your device.\nThe author is not responsible for any damage caused.\n Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (WarnResult == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                var command = new ProcessStartInfo
                {
                    FileName = selectedItem,
                    UseShellExecute = true   // required to open URI schemes
                };
                Process.Start(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open \"{selectedItem}\": {ex.Message}");
            }
        }
        private void AddItemToListView(string name, string path)
        {
            // Create a new row (ListViewItem)
            ListViewItem item = new ListViewItem(name);

            // Add second column
            item.SubItems.Add(path);

            // Add to ListView
            godModeItems.Items.Add(item);
        }

    }
}
