namespace P2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullCardName = " ";
            string fullSuitName = " ";

            
            while (fullCardName == " " || fullSuitName == " ")
            {
                Console.Write("Enter cards (A, 2...10,J,Q): ");
                string card = Console.ReadLine().ToLower();
                fullCardName = Number(card[0]);
                if (card[0] != '1')
                {
                    fullSuitName = Suit(card[1]);
                }
                else
                {

                    fullSuitName = Suit(card[2]);
                }
                
            }
            Console.WriteLine($"{fullCardName} of {fullSuitName}");

        }
        static string Number(char cards)
        {

            string fullCardName = " ";


            if (cards == 'a')
            {
                fullCardName = "Ace";
                
            }
            else if (cards == 'j')
            {
                fullCardName = "Jack";
                
            }
            else if (cards == 'q')
            {
                fullCardName = "Queen";
                
            }
            else if (cards == '2')
            {
                fullCardName = "Two";
                
            }
            else if (cards == '3')
            {
                fullCardName = "Three";
                
            }
            else if (cards == '4')
            {
                fullCardName = "Four";
                
            }
            else if (cards == '5')
            {
                fullCardName = "Five";
                
            }
            else if (cards == '6')
            {
                fullCardName = "Six";
                
            }
            else if (cards == '7')
            {
                fullCardName = "Seven";
                
            }
            else if (cards == '8')
            {
                fullCardName = "Eight";
                
            }
            else if (cards == '9')
            {
                fullCardName = "Nine";
                
            }
            else if (cards == '1')
            {
                fullCardName = "Ten";
                
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return fullCardName;
        }
        static string Suit(char suit)
        {
            
            string fullSuitName = " ";

            if (suit == 'd')
            {
                fullSuitName = "Diamond";
                
            }
            else if (suit == 'h')
            {
                fullSuitName = "Heart";
                
            }
            else if (suit == 's')
            {
                fullSuitName = "Spades";
                

            }
            else if (suit == 'c')
            {
                fullSuitName = "Clubs";
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
            return fullSuitName;
        }
    }
}