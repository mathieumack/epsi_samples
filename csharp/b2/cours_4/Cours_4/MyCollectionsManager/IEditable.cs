namespace MyCollectionsManager
{
    public interface IEditable
    {
        string Title { get; set; }

        void ShowDetail();

        void Edit();
    }
}
