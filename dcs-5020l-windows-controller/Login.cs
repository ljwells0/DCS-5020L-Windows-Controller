using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dcs_5020l_windows_controller
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string base64Credentials = Base64Encode(txtUsername.Text + ":" + txtPassword.Text);
            string[] conf = {"http://" + txtHostname.Text + ":" + txtPort.Text + "/", base64Credentials};
            System.IO.File.WriteAllLines("config.cfg", conf);
            this.Close();
        }
    }
}
