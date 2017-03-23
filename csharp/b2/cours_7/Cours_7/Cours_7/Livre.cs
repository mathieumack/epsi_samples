using System;

namespace Cours_7
{
    internal class Livre
    {
        /// <summary>
        /// Identifiant unique
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Date de disponibilité
        /// </summary>
        public DateTime? DateDisponibilite { get; set; }
    }
}
