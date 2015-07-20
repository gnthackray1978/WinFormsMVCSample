using WinFormsMVCSample.interfaces;

namespace WinFormsMVCSample.controllers
{
    public class ControlMain : IControlMain
    {
        private IModelMain _model;
        private IViewMain _view;

        public void Setup(IViewMain paramView, IModelMain paramModel)
        {
            _model = paramModel;

            _view = paramView;
        }
     
        public void SetView()
        {
            if (_view == null) return;

            _view.ShowInvalidState(_model.IsValidName);
        }



        public void RequestSetName(string name)
        {
            if (_model == null) return;

            _model.SetName(name);

            SetView();
        }

        public void RequestSetSurname(string surname)
        {
            if (_model == null) return;

            _model.SetSurname(surname);

            SetView();
        }

        public void RequestProcess()
        {
            if (_model == null) return;

            _model.Process();
        }
    }
}