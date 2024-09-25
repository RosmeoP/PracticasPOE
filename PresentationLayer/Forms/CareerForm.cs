using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;

namespace PresentationLayer.Forms
{
    public partial class CareerForm : Form
    {

        private CareerService _careerService;
        public CareerForm()
        {
            _careerService = new CareerService();
            InitializeComponent();

            LoadCareerData();
        }

        private void LoadCareerData()
        {
            dgvCareers.DataSource = _careerService.GetAllCareers();
        }

       
    }
}
