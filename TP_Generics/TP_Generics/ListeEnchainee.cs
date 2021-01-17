namespace TP_Generics
{
    public class ListeEnchainee<T>
    {
        public Chainage<T> Premier { get; private set; }
        public Chainage<T> Dernier
        {
            get
            {
                if (Premier == null)
                {
                    return null;
                }

                Chainage<T> dernier = Premier;
                while (dernier.Suivant != null)
                {
                    dernier = dernier.Suivant;
                }
                return dernier;
            }
        }

        public void Ajouter(T element)
        {
            if (Premier == null)
            {
                Premier = new Chainage<T> { Valeur = element };
            }

            else
            {
                Chainage<T> dernier = Dernier;
                dernier.Suivant = new Chainage<T> { Valeur = element, Precedent = dernier };
            }
        }


        public Chainage<T> ObtenirElement(int index)
        {
            bool found = false;
            int i = 0;

            Chainage<T> temp = Premier;
            Chainage<T> res = default(Chainage<T>);

            while (!found)
            {
  
                if (i == index)
                {
                    res = temp;
                    found = true;

                }
                temp = temp.Suivant;
                i++;

            }
            return res;

        }

        public void Inserer(T element, int index)
        {
            Chainage<T> elementAIndice = ObtenirElement(index);
            Chainage<T> precedent = elementAIndice.Precedent;//last OK value
            Chainage<T> temp = precedent.Suivant;


            precedent.Suivant = new Chainage<T> { Valeur = element, Precedent = precedent, Suivant = temp };

        }


    }
}
