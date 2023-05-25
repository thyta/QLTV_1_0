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
using QLTV_1_0.Store_1;

namespace QLTV_1_0
{
    public partial class FindBook : Form
    {
        public FindBook()
        {
            InitializeComponent();
            LoadDataBook();
        }

        private void FindBook_Load(object sender, EventArgs e)
        {

        }
        void LoadDataBook()
        {
            string query = "select * from dausach";

            DataProvider dataQuery = new DataProvider();
            dataGridView1.DataSource = dataQuery.ExecuteQuery(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
