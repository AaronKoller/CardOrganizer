namespace CardOrganizer
{
    public class Game
    {
        private readonly ICard _card;

        public Game(ICard card)
        {
            _card = card;
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void Start()
        {
            var deck = new Deck(_card);
            deck.Shuffle();
            deck.Sort();
        }
    }
}