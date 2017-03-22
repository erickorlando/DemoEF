using System;
using System.Windows.Forms;
using LogicaNegocio;

namespace DemoEF
{
    public partial class LoginForm : Form
    {
        private readonly LoginViewModel _viewModel;

        public LoginForm()
        {
            InitializeComponent();

            btnCancel.Click += (s, e) => Close();

            _viewModel = new LoginViewModel();

            LoginBindingSource.DataSource = _viewModel;
            LoginBindingSource.ResetBindings(false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _viewModel.Autenticar();

                LoginBindingSource.ResetBindings(false);

                if (!result) return;

                using (var frm = new UsuariosForm())
                {
                    frm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
