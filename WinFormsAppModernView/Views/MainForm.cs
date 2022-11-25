namespace WinFormsAppModernView
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelSubmenu1.Visible = false;
            panelSubmenu2.Visible = false;
            panelSubmenu3.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSubmenu1.Visible == true)
                panelSubmenu1.Visible = false;
            if (panelSubmenu2.Visible == true)
                panelSubmenu2.Visible = false;
            if (panelSubmenu3.Visible == true)
                panelSubmenu3.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible=false;
               
        }

        private void btnMainMenu1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu1);
        }

        private void btnMainMenu2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu2);
        }

        private void btnMainMenu3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenu3);
        }

        private void btnSubmenu1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            HideSubMenu();
        }

        private void btnSubmenu2_Click(object sender, EventArgs e)
        {
            //open form code
            HideSubMenu();
        }

        private void btnSubmenu3_Click(object sender, EventArgs e)
        {
            // open form code
            HideSubMenu();
        }

        private void btnSubmenu4_Click(object sender, EventArgs e)
        {
            // open form code
            HideSubMenu();
        }

        private void btnMainMenu4_Click(object sender, EventArgs e)
        {
            // open form code
            HideSubMenu();
        }

        private void btnMainMenu5_Click(object sender, EventArgs e)
        {
            // open form code
            HideSubMenu();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}