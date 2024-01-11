Book[] books = new Book[9];

books[0] = new Book("Гвидо", "Программирование на Python", 2000, new int[12] { 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 });
books[1] = new Book("Олег", "Как закрыть все долги за ночь и не офигеть", 2018, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
books[2] = new Book("Гвидо", "Программирование на Python, 3 изд.", 2008, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 });
books[3] = new Book("Максим", "Как поставить в Ниву 2jz", 2023, new int[12] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 });
books[4] = new Book("Максим", "Программирование на Java", 2022, new int[12] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 });
books[5] = new Book("Билл", "Программирование на C#", 2022, new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
books[6] = new Book("Гвидо", "Программирование на Python, 2 изд", 2005, new int[12] { 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1 });
books[7] = new Book("Информатик", "Pascal для чайников", 2022, new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 });
books[8] = new Book("Денис", "Сдача сессии без посещения универа", 2023, new int[12] { 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1 });


String sortAuthor = "Стив";
int sortByYear = 2000;
Book sortBook = books[2];

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine("Даты выдачи для книги <<" + books[i].getName(books[i]) + ">>: " + books[i].getDate(books[i]));
}

Console.WriteLine("Сортировка по имени автора " + sortAuthor);
Console.WriteLine(sortBook.bookInfo(sortBook.booksByAuthor(books, sortAuthor)));

Console.WriteLine("Сортировка по году издания, больше указанного " + sortByYear);
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine(books[i].bookInfo(books[i].sortByYearMoreThanWritten(books[i], sortByYear)));
}

Console.WriteLine("Информация о книге <<Как поставить в Ниву 2jz>>" + sortBook.bookInfo(sortBook));


class Book
{
    private string Author;
    private string Name;
    private int PublicationYear;
    private int[] IssueDate = new int[12];

    public Book(string Author, string Name, int PublicationDate, int[] IssueDate)
    {
        this.Author = Author;
        this.Name = Name;
        this.PublicationYear = PublicationDate;
        this.IssueDate = IssueDate;
    }

    public int getCountOfIssueOfBook(Book book)
    {
        int counterOfIssueOfBook = 0;
        for (int i = 0; i < 12; i++)
        {
            if (book.IssueDate[i] == 1)
            {
                counterOfIssueOfBook++;
            }
        }
        return counterOfIssueOfBook;
    }

    public Book sortByYearMoreThanWritten(Book book, int sortYear)
    {
        if (book.PublicationYear > sortYear)
        {
            return book;
        }
        else
        {
            return null;
        }
    }

    public Book booksByAuthor(Book[] book, String sortinAuthor)
    {
        for (int i = 0; i < book.Length; i++)
        {
            if (book[i].Author.Equals(sortinAuthor))
            {
                return book[i];
            }
        }
        return null;
    }

    public String bookInfo(Book book)
    {
        String datesOfIssue = "";
        for (int i = 0; i < 12; i++)
        {
            if (book.IssueDate[i] == 1)
            {
                datesOfIssue += (i + 1) + "в месяце; ";
            }
        }
        return "Название книги: " + book.Name + "\n Год издания: " + book.PublicationYear + "\n Автор:" + book.Author + "\n Была выдана в" + datesOfIssue;
    }

    public void setName(String name)
    {
        this.Name = name;
    }

    public String getName(Book book)
    {
        return book.Name;
    }

    public void setYear(int year_Of_Publication)
    {
        this.PublicationYear = year_Of_Publication;
    }

    public int getYear(Book book)
    {
        return book.PublicationYear;
    }

    public void setAuthor(String author)
    {
        this.Author = author;
    }

    public String getAuthor(Book book)
    {
        return book.Author;
    }

    public void setDate(int month, int type)
    {
        this.IssueDate[month] = type;
    }

   
    public String getDate(Book book)
    {
        String datesOfIssue = "";
        for (int i = 0; i < 12; i++)
        {
            if (book.IssueDate[i] == 1)
            {
                datesOfIssue += (i + 1) + "в месяце; ";
            }
        }

        return "Книга была выдана " + datesOfIssue;
    }
}
