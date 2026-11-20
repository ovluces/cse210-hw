public class Video
{
  private string _title;
  private string _author;
  private int _lenght;

  private List<Comment> _comment = new();
  public Video()
  {
    _title = "title";
    _author = "author";
    _lenght = 0;
    _comment.Add(new("name", "comment"));
  }
  public Video(string title, string author, int lenght)
  {
    _title = title;
    _author = author;
    _lenght = lenght;
  }

  public void AddComment(string name, string comment)
  {
    _comment.Add(new Comment(name, comment));
  }

  public string GetAuthor()
  {
    return _author;
  }

  public int GetLenght()
  {
    return _lenght;
  }

  public string GetTitle()
  {
    return _title;
  }
  public string GetVideo()
  {
    string texto = "Title: " + _title + "\nAuthor: " + _author + "\nLenght (sec): " + _lenght.ToString() + " "; //https://andresledo.es/salto-de-linea/
    return texto;
  }

  public List<Comment> GetComment()
  {
    return _comment;
  }

  public int GetNumberOfComments()
  {
    return _comment.Count();
  }

}
