using System;
using System.Collections.Generic;
using System.Text;

namespace patron_conception_composite
{
    /// <summary>
    /// Feuille : une option simple, sans enfant.
    /// Implémente le contrat IComposantMenu.
    /// </summary>
    public class Option: IComposantMenu
    {
        private string _nom;
        private bool _actif;

        /// <summary>
        /// Constructeur d'une option
        /// </summary>
        /// <param name="nom">Nom de l'option</param>
        /// <param name="actif">État  l'option</param>
        public Option(string nom, bool actif = true)
        {
            _nom = nom;
            _actif = actif;
        }

        /// <summary>
        /// Désactive l'option qui est une feuille
        /// </summary>
        public void Desactiver()
        {
            _actif = false;
        }

        /// <summary>
        /// Affiche l'option et son état
        /// </summary>
        public void Afficher()
        {
            string etat = _actif ? "actif" : "inactif";
            Console.WriteLine($"Option : {_nom} ({etat})");
        }

        public string Nom
        {
            get { return _nom; }
            private set => _nom = value;
        }

        public bool Actif
        {
            get { return _actif; }
            private set => _actif = value;
        }
    }
}
