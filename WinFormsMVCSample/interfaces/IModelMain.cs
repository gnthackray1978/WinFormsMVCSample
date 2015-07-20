namespace WinFormsMVCSample
{
    public interface IModelMain
    {
        void AddObserver(IViewMain paramView);
        void RemoveObserver(IViewMain paramView);
        void NotifyObservers();

        bool IsValidName { get; }

        string Name { get; }
        
        string Surname { get; }

        void SetName(string name);

        void SetSurname(string surname);

        void Process();
    }
}