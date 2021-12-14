using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class ChooseShowtime : Form
    {

        public ChooseShowtime(string id)
        {
            InitializeComponent();
            idmovie = id;
            LoadDay();
        }
        Button curBtn = new Button();
        string idmovie;
        string getday;
        string gettime;
        List<string> nameButton = new List<string>();
        List<string> timeButton = new List<string>();
        void LoadDay()
        {
            flpDay.Controls.Clear();
            int temp = 0;
            string query = "SELECT count(distinct format(shtime,'dd/MM/yyyy')) as temp from showtime where idmovie ='" + idmovie + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                temp = (int)rows["temp"];
            }
            nameButton = new List<string>(temp);
            query = "SELECT distinct format(shtime,'dd/MM/yyyy') as ST from showtime where idmovie ='" + idmovie + "' order by ST";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                nameButton.Add(rows["ST"].ToString());
            }
            foreach (string item in nameButton)
            {
                Button day = new Button();
                day.Width = 120;
                day.Height = 60;
                day.FlatStyle = FlatStyle.Flat;
                day.FlatAppearance.BorderSize = 0;
                day.Dock = DockStyle.Top;
                day.Font = new Font("Lato", 10F, FontStyle.Bold);
                day.ForeColor = Color.White;
                day.BackColor = Color.FromArgb(190, 62, 66);
                day.Text = item;
                day.Tag = (object)item;
                day.Click += Day_Click;
                flpDay.Controls.Add(day);
            }
        }
        private void Day_Click(object sender, EventArgs e)
        {
            curBtn = (Button)sender;
            getday = curBtn.Tag as string;
            LoadTime(curBtn.Tag as string);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadTime(string getday)
        {
            int temp = 0;
            flpTime.Controls.Clear();
            string query = "SELECT count(format(shtime,'hh:mm tt')) as temp from showtime where format(shtime,'dd/MM/yyyy') ='" + getday + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                temp = (int)rows["temp"];
            }
            timeButton = new List<string>(temp);
            query = "SELECT format(shtime,'hh:mm tt') as ST from showtime where format(shtime,'dd/MM/yyyy') ='" + getday + "' order by ST";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                timeButton.Add(rows["ST"].ToString());
            }
            foreach (string item in timeButton)
            {
                Button time = new Button();
                time.Width = 120;
                time.Height = 60;
                time.FlatStyle = FlatStyle.Flat;
                time.FlatAppearance.BorderSize = 0;
                time.Dock = DockStyle.Top;
                time.Font = new Font("Lato", 10F, FontStyle.Bold);
                time.ForeColor = Color.White;
                time.BackColor = Color.FromArgb(190, 62, 66);
                time.Text = item;
                time.Tag = (object)item;
                time.Click += Time_Click;
                flpTime.Controls.Add(time);
            }
        }

        private void Time_Click(object sender, EventArgs e)
        {
            curBtn = (Button)sender;
            gettime = curBtn.Tag as string;
            string idst="";
            string query = "SELECT ID from showtime where format(shtime,'dd/MM/yyyy') ='" + getday + "' and format(shtime,'hh:mm tt')='"+gettime+"' and idmovie='"+idmovie+"'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idst = rows["ID"].ToString();
            }
            FormBooking frm = new FormBooking(idst);
            this.Close();
            frm.Show();
        }
    }
}

