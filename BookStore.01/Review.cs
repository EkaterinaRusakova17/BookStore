namespace BookStore
{
    public class Review
    {
        public string BookTitle { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        public Review(string bookTitle, string text, int rating)
        {
            BookTitle = bookTitle;
            Text = text;
            Rating = rating;
        }
    }
}