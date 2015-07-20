namespace WinFormsMVCSample.interfaces
{
    public interface IControlMain
    {
        void RequestSetName(string name);
        void RequestSetSurname(string surname);
        void RequestProcess();

        void Setup(IViewMain paramView, IModelMain paramModel);       
        void SetView();
    }
}