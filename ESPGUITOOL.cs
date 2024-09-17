/*
*	FILE			: espguitool.cs
*	PROJECT			: espguitool
*	PROGRAMMER		: Brian Hinds
*	FIRST VERSION	: 1.0.0.1
*	DATE            : SEPTEMBER 09, 2924
*	MODIFIED        : SEPTEMBER 09, 2924
*	DESCRIPTION 	: Use to flash ESP with through esptool
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.FileIO;

namespace ESPGUITOOL
{
    public partial class ESPGUITOOL : MaterialForm
    {
        private string output;
        private List<String> portnames = new List<String>();
        private List<string> extensions = new List<string>();
        private string filePath;
        private string filename;
        private string p_FileToFlash;
        private string p_COMToFlash;
        private string p_espToolForFlash;
        private string theResults;
        private string theEraseScript;
        private string theFlashScript;
        private string dirPath = @"C:\ESPGUITOOL";
        private string copyFiles;
        private string filePath_esptool;

        public ESPGUITOOL()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            GUIToolDirectory();
            allPorts();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="command"></param>
        private void ExecuteCommand(string command)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "powershell.exe";
                processStartInfo.Arguments = $"-Command \"{command}\"";
                processStartInfo.Verb = "runas";
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;

                var process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();
                Process[] scanProcess = Process.GetProcessesByName("powershell");
                foreach (Process thisProcess in scanProcess)
                {
                    process.WaitForExit();
                }
                output += process.StandardOutput.ReadToEnd();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private List<string> scanCOMPorts()
        {
            using (var searchPort = new ManagementObjectSearcher("SELECT * FROM " + "Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                String[] ports = SerialPort.GetPortNames();

                var port = searchPort.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                List<String> portList = ports.Select(n => n + " - " + port.FirstOrDefault(s => s.Contains(n))).ToList();

                return portList;
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void GUIToolDirectory()

        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath, true);
                Directory.CreateDirectory(dirPath);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void allPorts()
        {
            portnames = scanCOMPorts();
            foreach (string port in portnames)
            {
                portBox.Items.Add(port);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void flash_Files()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            List<string> extensions = new List<string> { "BIN" };
            string[] files_ = GetFilesWithExtensions(filePath, extensions);
            flashFileBox.Items.AddRange(files_);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="extensions"></param>
        /// <returns></returns>
        private string[] GetFilesWithExtensions(string path, List<string> extensions)
        {
            string[] allFilesInFolder = Directory.GetFiles(path);
            return allFilesInFolder.Where(f => extensions.Contains(f.ToUpper().Split('.').Last())).ToArray();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flashFileBtn_Click(object sender, EventArgs e)
        {
            flash_Files();
        }
        /// <summary>
        /// 
        /// </summary>
        private void esp_tool()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath_esptool = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            List<string> extensions = new List<string> { "EXE" };
            string[] files_ = GetFilesWithExtensions(filePath_esptool, extensions);
            espToolBox.Items.AddRange(files_);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void espToolBtn_Click(object sender, EventArgs e)
        {
            esp_tool();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void portBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_COMToFlash = portBox.SelectedItem.ToString();
            string[] words = p_COMToFlash.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    theCOMPort.Text = words[i];
                    p_COMToFlash = words[i];
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void setScripts()
        {
            FileSystem.CopyDirectory(filePath, dirPath, UIOption.OnlyErrorDialogs);
            FileSystem.CopyDirectory(filePath_esptool, dirPath, UIOption.OnlyErrorDialogs);
            theEraseScript = dirPath + "\\" + esptoolFile.Text + " --chip esp8266 --port " + theCOMPort.Text + " erase_flash";
            theFlashScript = dirPath + "\\" + esptoolFile.Text + " --chip esp8266 --port " + theCOMPort.Text + " --baud 115200 write_flash 0x00000 " + dirPath + "\\" + theFlashBin.Text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flashFileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_FileToFlash = flashFileBox.SelectedItem.ToString();
            theFlashBin.Text = Path.GetFileName(p_FileToFlash);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void espToolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_espToolForFlash = espToolBox.SelectedItem.ToString();
            esptoolFile.Text = Path.GetFileName(p_espToolForFlash);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flashBtn_Click(object sender, EventArgs e)
        {
            setScripts();
            flashProgress.Text = "PLEASE WAIT. . . ERASING AND FLASHING ESP FLASH MEMORY!";
            ExecuteCommand(theEraseScript + " | " + theFlashScript);
            resultsBox.Text += output;
            flashProgress.Text = "FLASHING COMPLETE";
            GUIToolDirectory();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            GUIToolDirectory();
            flashFileBox.Items.Clear();
            espToolBox.Items.Clear();
            theCOMPort.Text = string.Empty;
            theFlashBin.Text = string.Empty;
            esptoolFile.Text = string.Empty;
            resultsBox.Text = string.Empty;
            flashProgress.Text = "READY";
            esptoolFile.Text = string.Empty;
        }
    }
}