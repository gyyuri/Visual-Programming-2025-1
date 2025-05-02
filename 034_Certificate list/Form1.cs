using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace _034_Certificate_list
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bjXp74G8NstsQcRXUzzzKW5tjVtVa8af8tQ0tBoS",
            BasePath = "https://vp-kgr-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) MessageBox.Show("Connection 성공");
        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                Num = txtNum.Text,
                Name = txtName.Text,
                Date = txtDate.Text,
                Issuer = txtIssuer.Text
            };

            SetResponse response = await
                client.SetAsync("Certificate/" + txtNum.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Instered : Id = " + result.Num);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtName.Text = "";
            txtDate.Text = "";
            txtIssuer.Text = "";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.GetAsync("Certificate/"+txtNum.Text);
            Data obj = response.ResultAs<Data>();

            txtNum.Text = obj.Num;
            txtName.Text = obj.Name;
            txtDate.Text = obj.Date;
            txtIssuer.Text = obj.Issuer;

            MessageBox.Show("Data reterived Successfully");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                Num = txtNum.Text,
                Name = txtName.Text,
                Date = txtDate.Text,
                Issuer = txtIssuer.Text
            };

            FirebaseResponse response = await
                client.UpdateAsync("Certificate/" + txtNum.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data updated Successfully Id: "+result.Num);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.DeleteAsync("Certificate/" + txtNum.Text);
            MessageBox.Show("Deleted Id: "+txtNum.Text);

            txtNum.Text = "";
            txtName.Text = "";
            txtDate.Text = "";
            txtIssuer.Text = "";
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.DeleteAsync("Certificate");
            MessageBox.Show("All Data at /Certificate node Deleted");

        }
    }
}
