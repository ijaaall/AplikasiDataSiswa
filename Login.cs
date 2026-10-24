using AplikasiDataSiswa.Data;
using AplikasiDataSiswa.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataSiswa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    btnLogin.Enabled = false;

                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;

                    var Login = await context.Operator.Include(o => o.Role).FirstOrDefaultAsync(o => o.Username == Username && o.Password == Password);

                    if (Login != null)
                    {
                        Session.OperatorId = Login.OperatorId;
                        Session.Username = Login.Username;
                        Session.Password = Login.Password;
                        Session.Role = Login.Role.NamaRole;

                        if (Login.Role.NamaRole.ToLower() == "admin")
                        {
                            new SiswaForm().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("username atau password salah!!", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnLogin.Enabled = true;
                }
            }
        }
    }
}
