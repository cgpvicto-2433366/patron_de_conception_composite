using System;
using System.Collections.Generic;
using System.Text;

namespace patron_conception_composite
{
    public class Navigation
    {
        private IComposantMenu _racine;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="racine">Objet implementant l'interface IComposantMenu</param>
        public Navigation(IComposantMenu racine) 
        {
            _racine = racine;
        }

        /// <summary>
        /// Desactiver un menu et ses enfants
        /// </summary>
        public void ToutDesactiver() 
        {
            _racine.Desactiver();
        }

        /// <summary>
        /// Afficher le menu
        /// </summary>
        public void Afficher() 
        {
            _racine.Afficher();
        } 
    }
}
