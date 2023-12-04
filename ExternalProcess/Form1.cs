using System.ComponentModel;
using System.Diagnostics;


namespace ExternalProcess
{
    public partial class frmMain : Form
    {
        private ExternalCmd cmd;

        public frmMain()
        {
            InitializeComponent();
            cmd = new ExternalCmd();
        }

        private void btnRunProcess_Click(object sender, EventArgs e)
        {
            cmd.StartInfo.FileName = txtExecutable.Text;
            cmd.StartInfo.Arguments = txtArguments.Text;
            cmd.StartInfo.UseShellExecute = false;
            cmd.EnableRaisingEvents = true;
            cmd.Exited += Cmd_Exited;
            try
            {
                cmd.Start();
                btnRunProcess.Enabled = false;
                btnKillProcess.Enabled = true;
                lblExtProc.Text = $"Process {cmd.StartInfo.FileName} ID : {cmd.Id}";
            }
            catch (Win32Exception win32ex)
            {
                MessageBox.Show(win32ex.Message, "Win32 Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ioex)
            {
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmd_Exited(object? sender, EventArgs e)
        {
            MessageBox.Show("Child Process Has Been Successfully Killed", "Child Process Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Exited -= Cmd_Exited;
            btnRunProcess.Enabled = (txtExecutable.Text.Length > 0);
            btnKillProcess.Enabled = false;
            lblExtProc.Text = "No Process";
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Kill(true);
            }
            catch (Win32Exception win32ex)
            {
                MessageBox.Show(win32ex.Message, "Win32 Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ioex)
            {
                MessageBox.Show(ioex.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtExecutable_TextChanged(object sender, EventArgs e)
        {
            btnRunProcess.Enabled = (txtExecutable.Text.Length > 0);
        }
    }
}