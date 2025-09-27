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
            godModeItems.Columns.Add("Name", 255);
            godModeItems.Columns.Add("Path", 500);

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
