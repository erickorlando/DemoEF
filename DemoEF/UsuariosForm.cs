using LogicaNegocio;
using System;
using System.Windows.Forms;

namespace DemoEF
{
    public partial class UsuariosForm : Form
    {
        private readonly UsuariosViewModel _viewModel;

        public UsuariosForm()
        {
            InitializeComponent();

            _viewModel = new UsuariosViewModel();

            usuariosViewModelBindingSource.DataSource = _viewModel;
            usuariosViewModelBindingSource.ResetBindings(false);

            Load += FormLoad;
        }

        private void FormLoad(object s, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (_viewModel == null) return;

                _viewModel.CargarLista();

                usuariosViewModelBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}