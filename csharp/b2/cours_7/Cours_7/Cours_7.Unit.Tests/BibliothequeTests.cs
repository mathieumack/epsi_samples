using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cours_7.Unit.Tests
{
    [TestClass]
    public class BibliothequeTests
    {
        private IBibliotheque bibliotheque;

        [TestInitialize]
        public void TestInit()
        {
            bibliotheque = new Bibliotheque();

            List<Livre> livres = new List<Livre>();
            livres.Add(new Livre()
            {
                Id = 1,
                Titre = "Titre 1",
                IsReservable = true,
                DateDisponibilite = null
            });
            livres.Add(new Livre()
            {
                Id = 2,
                Titre = "Titre 1",
                IsReservable = false,
                DateDisponibilite = null
            });

            bibliotheque.InitDatas(livres, new List<Utilisateur>());
        }

        [TestMethod]
        public void IsReservable()
        {
            bool isReservable = bibliotheque.IsReservable(1);
            Assert.IsTrue(isReservable);

            isReservable = bibliotheque.IsReservable(2);
            Assert.IsFalse(isReservable);
        }

        [TestMethod]
        public void ReserveLivre()
        {
            bool canReserver = bibliotheque.ReserveLivre(2, new DateTime(2017, 2, 1));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(2, new DateTime(2017, 2, 1));
            Assert.IsFalse(canReserver);
        }
    }
}
