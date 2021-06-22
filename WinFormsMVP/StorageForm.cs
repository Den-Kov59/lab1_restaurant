using lab1_restaurant;
using lab1_restaurant.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVP
{
    public partial class StorageForm : Form, IStorageView
    {
        public MyDictToString Dict { get; set; }
        public StorageForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {   
            lbStorage.DataSource = Dict.getStr();
            base.OnLoad(e);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
