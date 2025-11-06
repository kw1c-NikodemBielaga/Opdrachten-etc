//Nikodem Bielaga
// 01-04-2025
//Oefening74
using Oefening74.Controller;
using Oefening74.Model;
using System.Windows.Forms;

namespace Oefening74
{
    public partial class Form1 : Form
    {
        private DoctorController doctorController;
        public Form1()
        {
            InitializeComponent();
            doctorController = new DoctorController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DoctorModel> doctors = doctorController.ReadAll();
            dataGridView1.DataSource = doctors;
        }
    }
}
