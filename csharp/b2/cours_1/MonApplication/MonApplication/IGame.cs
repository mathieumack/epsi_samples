﻿namespace MonApplication
{
    public interface IGame
    {
        string NomJeu { get; }

        void LancerJeu();

        void GetStatistiques();

        void GetStatistiques(System.DateTime dateMin);
    }
}
