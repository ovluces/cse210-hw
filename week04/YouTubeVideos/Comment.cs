public class Comment
{
  private string _name;
  private string _text;

  public Comment()
  {
    _name = "name";
    _text = "text";
  }
  public Comment(string name, string text)
  {
    _name = name;
    _text = text;
  }

  public string DisplayComment()
  {
    string texto = "Name: " + _name + "\nComment: " + _text; //https://andresledo.es/salto-de-linea/
    return texto;
  }
}
