using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _031_PhoneBook
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "oLPxEiYHLQUtZpgXuvCLYl6PZTX0WZnOyhYDgTZ8",      //firebase 비번
            BasePath = "https://vp01-10b6c-default-rtdb.firebaseio.com/"  //firebase 주소
        };

        IFirebaseClient client;       //C#에서 firebase의 database를 대신하는 이름
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client != null)
            {
                MessageBox.Show("Connection 성공!");
            }
        }


        //추가 버튼
        private async void btninsert_Click(object sender, EventArgs e)
        {
            //여러개를 한 꺼번에 초기화 → {}; 사용
            Data data = new Data
            {
                Id = txtid.Text,
                SId = txtsid.Text,
                Name = txtname.Text,
                Phone = txtphone.Text
            };

            
            SetResponse response = 
                await client.SetAsync("Phonebook/" + txtid.Text, data);


            Data result = response.ResultAs<Data>();

            MessageBox.Show(String.Format("Data Inserted : Id = {0}, Name = {1}", result.Id, result.Name));
            
        }

        //clear 버튼
        private void ｂｔｎＣｌｅａｒ_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtsid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            
        }

        //검색버튼
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.GetAsync("Phonebook/" + txtid.Text);
            Data obj = response.ResultAs<Data>();

            txtid.Text = obj.Id;
            txtsid.Text = obj.SId;
            txtname.Text = obj.Name;
            txtphone.Text = obj.Phone;

            MessageBox.Show("Data reteribed successfully!");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Data data = new Data()
            {
                Id = txtid.Text,
                SId = txtsid.Text,
                Name = txtname.Text,
                Phone = txtphone.Text
            };

            FirebaseResponse response = await
                client.UpdateAsync("Phonebook/"+txtid.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data updated successfully: ID = " + result.Id);
        }

        //일부삭제
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.DeleteAsync("Phonebook/" + txtid.Text);
            MessageBox.Show("Deleted ID = "+txtid.Text);

            txtid.Text = "";
            txtsid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await
                client.DeleteAsync("Phonebook");

            txtid.Text = "";
            txtsid.Text = "";
            txtname.Text = "";
            txtphone.Text = "";

            MessageBox.Show("All Data at /Phonebook node deleted!");
        }
    }
}
