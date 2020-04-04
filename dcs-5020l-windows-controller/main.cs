using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace dcs_5020l_windows_controller
{
    public partial class Main : Form
    {
        public String cameraAddress = null;
        public String cameraBase64Auth = null;
        public String responseBody = null;
        public Main()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            if (!File.Exists("config.cfg"))
            {
                Login loginForm = new Login();
                loginForm.ShowDialog();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.cfg"))
            {
                MessageBox.Show("No login details where provided / found! The application will now exit.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                string[] conf = File.ReadAllLines("config.cfg");
                cameraAddress = conf[0];
                cameraBase64Auth = conf[1];
            }
        }

        private async void BtnPTHome_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanTiltPresetPositionMove=1");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnPTUp_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanSingleMoveDegree=5&TiltSingleMoveDegree=5&PanTiltSingleMove=1");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnPTDown_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanSingleMoveDegree=5&TiltSingleMoveDegree=5&PanTiltSingleMove=7");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnPTLeft_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanSingleMoveDegree=5&TiltSingleMoveDegree=5&PanTiltSingleMove=3");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnPTRight_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanSingleMoveDegree=5&TiltSingleMoveDegree=5&PanTiltSingleMove=5");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnPresetPositionsGo_Click(object sender, EventArgs e)
        {
            int presetIndex = cmbPresetPositions.SelectedIndex + 1;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "pantiltcontrol.cgi?PanTiltPresetPositionMove=" + presetIndex);
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private async void BtnSystemToolsRestart_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", cameraBase64Auth);
            HttpResponseMessage response = await client.GetAsync(cameraAddress + "reset.cgi?Reset=Yes");
            response.EnsureSuccessStatusCode();
            responseBody = await response.Content.ReadAsStringAsync();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            File.Delete("config.cfg");
            MessageBox.Show("Logout completed successfully! The application will now exit.", "Logout Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
    }
}
