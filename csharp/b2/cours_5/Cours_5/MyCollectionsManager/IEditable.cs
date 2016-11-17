namespace MyCollectionsManager
{
    public interface IEditable
    {
        string Title { get; set; }

        void ShowDetail();

        /// <summary>
        /// Edition de l'objet
        /// </summary>
        /// <param name="nom">Nom par défaut</param>
        /// <param name="test">paramètre 2</param>
        void Edit(string nom, double test);
    }
}
