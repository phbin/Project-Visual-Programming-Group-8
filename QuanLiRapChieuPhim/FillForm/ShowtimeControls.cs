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
    public partial class ShowtimeControls : Form
    {

        public ShowtimeControls()
        {
            InitializeComponent();
            LoadMovieIntoComboBox(cbIDMovie);
            buttonOK.BringToFront();
        }
        public ShowtimeControls()
        {
            InitializeComponent();
            LoadMovieIntoComboBox(cbIDMovie);
            buttonOK.BringToFront();
        }
        void LoadMovieIntoComboBox(ComboBox cbb)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat= "yyyy/MM/dd hh:mm:ss tt";
            DataTable tb =DataProvider.Instance.ExecuteQuery("Select * from dbo.Movie");
            cbb.DataSource = tb;
            cbb.DisplayMember = "NameFilm";
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
        string idmovie;
        DateTime day;
        private string GetIDMovie(string name)
        {
            string query = "SELECT ID FROM dbo.Movie where namefilm = N'" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idmovie = rows["ID"].ToString();
            }
            return idmovie;
        }
        private DateTime GetDate(string name)
        {
            string query = "SELECT DateOut FROM dbo.Movie where namefilm =N'" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                day = Convert.ToDateTime(rows["DateOut"].ToString());
            }
            return day;
        }
       
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text != "" && cbIDMovie.Text != "" && cbIDRoom.Text != "" && txtPrice.Text != "")
            {
                if (dtpTime.Value < DateTime.Now) MessageBox.Show("Showtime must not greater than now!");
                //else if (dtpTime.Value > GetDate(cbIDMovie.Text)) MessageBox.Show("Showtime must not greater than Expiry Date");
                else
                {                    
                    ShowtimeDAO.Instance.InsertShowtime(txtID.Text,GetIDMovie(cbIDMovie.Text), dtpTime.Text, cbIDRoom.Text, Convert.ToInt32(txtPrice.Text));
                    MessageBox.Show(""+GetIDMovie(cbIDMovie.Text));

                    MessageBox.Show("Showtime added!");
                    //this.Close();
                }
            }
            else MessageBox.Show("Please fill the information!");
        }
    }
}
