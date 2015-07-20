using System;
using System.Windows.Forms;
using WinFormsMVCSample.controllers;
using WinFormsMVCSample.interfaces;

namespace WinFormsMVCSample
{
    public partial class FrmMain : Form, IViewMain
    {
        private IControlMain _iControl;
        private IModelMain _iModel;


        public FrmMain()
        {
            InitializeComponent();

            WireUp(new ControlMain(), new ModelMain() );
        }

        public void WireUp(IControlMain paramControl, IModelMain paramModel)
        {
            if (_iModel != null)
            {
                _iModel.RemoveObserver(this);
            }

            _iModel = paramModel;
            _iControl = paramControl;

            _iControl.Setup(this, _iModel);

            _iModel.AddObserver(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _iControl.RequestSetName(txtName.Text);
            _iControl.RequestSetSurname(txtSurname.Text);
        }

        public void ShowInvalidState(bool valid)
        {
            epName.SetError(txtName, !valid ? "Bad Name" : "");
        }

        public void Update(IModelMain paramModel)
        {
            txtName.Text = paramModel.Name;
            txtSurname.Text = paramModel.Surname;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            _iControl.RequestProcess();
        }
    }
}
