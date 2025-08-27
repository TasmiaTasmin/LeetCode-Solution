using System.Diagnostics;
using System.Windows.Forms;

namespace LeetCode_Solution
{
    public partial class LeetCodeSolutionList : Form
    {        
        public LeetCodeSolutionList()
        {
            InitializeComponent();

            // Configure ListView
            problemListView.View = View.List;
            problemListView.FullRowSelect = true;

            // Add console apps (change names to match your console project names)
            problemListView.Items.Add("FizzBuzz");
            problemListView.Items.Add("ConsoleApp2");
            problemListView.Items.Add("ConsoleApp3");

            // Handle double click to run the app
            problemListView.DoubleClick += problemListView_DoubleClick;
        }

        private void problemListView_DoubleClick(object sender, EventArgs e)
        {
            if (problemListView.SelectedItems.Count > 0)
            {
                string appName = problemListView.SelectedItems[0].Text;
                RunConsoleApp(appName);
            }
        }

        private void RunConsoleApp(string appName)
        {
            try
            {
                // Path to console EXE (adjust path if needed)
                //string exePath = Path.Combine(Application.StartupPath, $"{appName}.exe");

                // Path to the console app's build output (adjust as needed)
                string consoleAppOutputDir = Path.Combine(Application.StartupPath, "..", "..", "..", "..", appName, "bin", "Debug", "net7.0");
                string sourceExePath = Path.GetFullPath(Path.Combine(consoleAppOutputDir, $"{appName}.exe"));
                string destExePath = Path.Combine(Application.StartupPath, $"{appName}.exe");

                // Copy or overwrite the EXE in the WinForms output directory
                if (File.Exists(sourceExePath))
                {
                    File.Copy(sourceExePath, destExePath, true);
                }
                else
                {
                    MessageBox.Show($"Source console app not found: {sourceExePath}");
                    return;
                }

                //if (!File.Exists(exePath))
                //{
                //    MessageBox.Show($"Console app not found: {exePath}");
                //    return;
                //}

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = destExePath,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    //Console.Out.Flush();
                    MessageBox.Show($"Output: {output}");
                    //solutionOutput.Text = output;
                    solutionOutput.Text = string.IsNullOrWhiteSpace(output) ? error : output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running console app: {ex.Message}");
            }
        }
    }
}
