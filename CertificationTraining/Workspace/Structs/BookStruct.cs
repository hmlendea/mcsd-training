namespace CertificationTraining.Workspace.Structs
{
    public struct BookStruct
    {
        /// <summary>
        /// The book title.
        /// </summary>
        public string Title;

        /// <summary>
        /// The category.
        /// </summary>
        public string Category;

        /// <summary>
        /// The name of the author.
        /// </summary>
        public string Author;

        /// <summary>
        /// The number of pages.
        /// </summary>
        public int PageCount;

        /// <summary>
        /// The current page.
        /// </summary>
        public int Page;

        /// <summary>
        /// The ISBN code.
        /// </summary>
        public string ISBN;

        /// <summary>
        /// The style of the cover.
        /// </summary>
        public string CoverStyle;

        public BookStruct(string title, string category, string author, int pageCount, int page, string isbn, string coverStyle)
        {
            Title = title;
            Category = category;
            Author = author;
            PageCount = pageCount;
            Page = page;
            ISBN = isbn;
            CoverStyle = coverStyle;
        }

        public void NextPage()
        {
            if (Page < PageCount)
            {
                Page += 1;
            }
        }

        public void PreviousPage()
        {
            if (Page > 0)
            {
                Page -= 1;
            }
        }
    }
}
