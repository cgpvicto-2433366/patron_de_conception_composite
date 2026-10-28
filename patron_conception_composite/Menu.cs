using System;
using System.Collections.Generic;
using System.Text;

namespace patron_conception_composite
{
    public class Menu: IComposantMenu
    {
        private string _nom;
        private bool _actif;

        // Liste des enfants, contenant des objets pouvant être de type menu ou option
        private List<IComposantMenu> _enfants = new List<IComposantMenu>();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="actif"></param>
        public Menu(string nom, bool actif = true)
        {
            _nom = nom;
            _actif = actif;
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

        /// <summary>
        /// Ajouter un enfant
        /// </summary>
        /// <param name="enfant"> Objet qui implémente l'interface IComposantMenu</param>
        public void Ajouter(IComposantMenu enfant)
        {
            _enfants.Add(enfant);
        }

        /// <summary>
        /// Implementation de la méthode du composant
        /// </summary>
        public void Desactiver()
        {
            _actif = false;

            //Demande à chacun de ses enfants de se descativer sans connaitre le type
            foreach (var enfant in _enfants)
            {
                enfant.Desactiver();
            }
        }

        /// <summary>
        /// Affiche un menu et ses enfants
        /// </summary>
        public void Afficher()
        {
            string etat = _actif ? "actif" : "inactif";
            Console.WriteLine($"[Menu] {_nom} ({etat})");
            foreach (var enfant in _enfants)
                enfant.Afficher();
        }
    }
}
