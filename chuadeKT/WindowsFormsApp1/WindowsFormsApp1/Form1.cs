using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
             DataTable tabletailieu= new DataTable();
            tabletailieu = data.getAlltblTaiLieu();
            dataGridView1.DataSource= tabletailieu;
        }


        DataProcessing data=new DataProcessing();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Khi khỏi đọng form thì nó sẽ thực hiện
           




        }


        private void btnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string mattailieu=txtmatailieu.Text.Trim();
                string tentailieu=txttentailieu.Text.Trim();
                string tacgia=txttacgia.Text.Trim();
                string dongia=txtdongia.Text.Trim();
                string matheloai=txtmatheloai.Text.Trim();
                if (string.IsNullOrWhiteSpace(mattailieu)) throw new Exception("ban chua nhap ma tai lieu");
                if (string.IsNullOrWhiteSpace(tentailieu)) throw new Exception("ban chua nhap ten tai lieu");
                if (string.IsNullOrWhiteSpace(tacgia)) throw new Exception("ban chua nhap tac gia");
                if (string.IsNullOrWhiteSpace(matheloai)) throw new Exception("ban chua nhap ma the loai");

                if(!int.TryParse(mattailieu,out int number))
                {
                    throw new Exception("ma tai lieu la so nguyen ");
                }
                foreach(char c in dongia)
                {
                    if(Char.IsLetter(c)) throw new Exception("don gia san pham phai la so nguyen");
                }

                data.InserttblTaiLieu(mattailieu, tentailieu, tacgia, int.Parse(dongia), matheloai);
                Form1_Load(sender, e);
            }
            catch(Exception ex) {

                if (ex.Message.Contains("insert duplicate key"))
                {
                    MessageBox.Show("Mã sản phẩm không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string mattailieu=txtmatailieu.Text;
            if (string.IsNullOrEmpty(mattailieu)) 

            if(!int.TryParse(mattailieu,out int number))
            {
                throw new Exception("ma tai lieu phai la so nguyen");

            }
            data.DeletetblTaiLieu(mattailieu);
            Form1_Load(sender, e);
                
        }

        private void btthem_Click(object sender, EventArgs e)
        {
             string mattailieu=txtmatailieu.Text.Trim();
                string tentailieu=txttentailieu.Text.Trim();
                string tacgia=txttacgia.Text.Trim();
                var dongia= int.Parse(txtdongia.Text);
            string matheloai=txtmatheloai.Text.Trim();

            data.InserttblTaiLieu(mattailieu, tentailieu, tacgia, dongia, matheloai);

            data.InserttblTaiLieu();
           
            Form1_Load(sender, e);
        
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row=e.RowIndex;
            if(row>=0)
            {
                txtmatailieu.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txttentailieu.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txttacgia.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtdongia.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                txtmatheloai.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();

            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            try
            {
                string mattailieu = txtmatailieu.Text.Trim();
                string tentailieu = txttentailieu.Text.Trim();
                string tacgia = txttacgia.Text.Trim();
                string dongia = txtdongia.Text.Trim();
                string matheloai = txtmatheloai.Text.Trim();
                if (string.IsNullOrWhiteSpace(mattailieu)) throw new Exception("ban chua nhap ma tai lieu");
                if (string.IsNullOrWhiteSpace(tentailieu)) throw new Exception("ban chua nhap ten tai lieu");
                if (string.IsNullOrWhiteSpace(tacgia)) throw new Exception("ban chua nhap tac gia");
                if (string.IsNullOrWhiteSpace(dongia)) throw new Exception("ban chua nhap DON GIA");
                if (string.IsNullOrWhiteSpace(matheloai)) throw new Exception("ban chua nhap ma the loai");

              if(!int.TryParse(mattailieu,out int number))
                {
                    throw new Exception("ma tai lieu la so nguyen ");
                }
                foreach(char c in dongia)
                {
                    if(Char.IsLetter(c)) throw new Exception("don gia san pham phai la so nguyen");
                }

                data.InserttblTaiLieu(mattailieu, tentailieu, tacgia, int.Parse(dongia), matheloai);
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("insert duplicate key"))
                {
                    MessageBox.Show("Mã sản phẩm không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

   
}
