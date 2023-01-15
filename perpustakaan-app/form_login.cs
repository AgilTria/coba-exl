using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace perpustakaan_app
{
    public partial class form_login : Form
    {
        private model.general authenticate = new model.general();
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*var result = authenticate.login(txt_user.Text, txt_pass.Text);

            if (result.Rows.Count > 0)
            {
                new beranda().Show();
                this.Hide();

                administrator admin = new administrator();
                admin.status_id.Text = result.Rows[0][0].ToString().ToUpper();
                admin.status_nama.Text = result.Rows[0][1].ToString().ToUpper();
                admin.status_level.Text = result.Rows[0][2].ToString().ToUpper();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal.! Periksa kembali Username dan Password Anda.!");
            }*/
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {



            var result = authenticate.login(txt_nama.Text, txt_pass.Text);

            if (result.Rows.Count > 0)
            {
                new beranda().Show();
                this.Hide();

                administrator admin = new administrator();
                admin.status_id.Text = result.Rows[0][0].ToString().ToUpper();
                admin.status_nama.Text = result.Rows[0][1].ToString().ToUpper();
                admin.status_level.Text = result.Rows[0][2].ToString().ToUpper();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal.! Periksa kembali Username dan Password Anda.!");
            }

        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            new pegawai().Show();
            this.Hide();
        }
    }
}



