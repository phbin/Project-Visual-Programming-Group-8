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
        
        void LoadMovieIntoComboBox(ComboBox cbb)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat= "MM/dd/yyyy hh:mm:ss";
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
            string query = "SELECT ID FROM dbo.Movie where namefilm ='" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idmovie = rows["ID"].ToString();
            }
            return idmovie;
        }
        private DateTime GetDate(string name)
        {
            string query = "SELECT DateOut FROM dbo.Movie where namefilm ='" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                day = Convert.ToDateTime(rows["DateOut"].ToString());
            }
            return day;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
           
            if (txtID.Text != "" && cbIDMovie.Text != "" && cbIDRoom.Text != "" && txtPrice.Text !="")
            {
                if (dtpTime.Value < DateTime.Now) MessageBox.Show("Showtime must not greater than now!");
                //else if (dtpTime.Value > GetDate(cbIDMovie.Text)) MessageBox.Show("Showtime must not greater than Expiry Date");
                else
                {
                    //string id,  string idmovie, DateTime time, string idroom, float ticketPrice
                    ShowtimeDAO.Instance.InsertShowtime(txtID.Text, GetIDMovie(cbIDMovie.Text), dtpTime.Value, cbIDRoom.Text, Convert.ToDouble(txtPrice.Text));
                    MessageBox.Show("Showtime added!");
                }
            }
            else MessageBox.Show("Please fill the information!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
