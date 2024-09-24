namespace Harjoitus12KT
{
    public class Kortit
    {
        private List<string> cards = new List<string>();

            public List<string> kortit()
            {
            for (int i = 1; i <= 13; i++)
            {
                cards.Add("Kortti on Pata " + i);
            }

            for (int i = 1; i <= 13; i++)
            {
                cards.Add("Kortti on Risti " + i);
            }

            for (int i = 1; i <= 13; i++)
            {
                cards.Add("Kortti on Hertta " + i);
            }

            for (int i = 1; i <= 13; i++)
            {
                cards.Add("Kortti on Ruutu " + i);
            }

            return cards;
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public void Tulostus()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}