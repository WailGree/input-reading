namespace InputReading
{
    internal class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int CopiesSold { get; set; }
        public string Year { get; set; }

        public Book(string line)
        {
            string[] data = line.Split('*'); // Split line based on given character. In this case "*".
            // Set properties from data.
            Author = data[0];
            Title = data[1];
            CopiesSold = int.Parse(data[2]);
            Year = data[3];
        }
        public override string ToString() // Return a fast representation of the Book object's properties.
        {
            return $"Author: {Author}, Title: {Title}, CopiesSold: {CopiesSold}, Year: {Year}";
        }
    }
}