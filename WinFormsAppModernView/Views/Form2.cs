using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppModernView.Presenters;
using WinFormsAppModernView.Views;

namespace WinFormsAppModernView
{
    public partial class Form2 : Form, IRectangle
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string LengthText { get => txtLength.Text; set => txtLength.Text = value; }
        public string WidthText { get => txtWidth.Text; set => txtWidth.Text = value; }
        public string AreaText { get => lblArea.Text; set => lblArea.Text = value; }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saveConfig
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}
