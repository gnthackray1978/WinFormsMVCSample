using System;
using System.Collections;

namespace WinFormsMVCSample
{
    public class ModelMain :IModelMain
    {
        private string _name = "";
        private string _surname = "";
        private readonly ArrayList _views = new ArrayList();


        public void AddObserver(IViewMain paramView)
        {
            _views.Add(paramView);
        }

        public void RemoveObserver(IViewMain paramView)
        {
            _views.Remove(paramView);
        }

        public void NotifyObservers()
        {
            foreach (IViewMain view in _views)
            {
                view.Update(this);
            }
        }


        public bool IsValidName
        {
            get { return (_name.Length > 0 && _surname.Length > 0); }
        }

        #region getter setter

        public string Name
        {
            get { return _name; }
        }

        public string Surname
        {
            get { return _surname; }
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetSurname(string surname)
        {
            _surname = surname;
        }
        #endregion

        public void Process()
        {
            _surname = "xxx_" + _surname + "_xxx";
            _name = "xxx_" + _name + "_xxx";

            NotifyObservers();
        }

    }
}