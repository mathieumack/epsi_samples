namespace MonApplication
{
    public interface IGame
    {
        string NomJeu { get; }

        void LancerJeu();

        void AfficherStatistiques();
    }
}
