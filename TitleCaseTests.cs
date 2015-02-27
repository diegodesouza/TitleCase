namespace TitleCaseProblem
{
  /*
  Title Capitalizion
  Many writers are often confused by the different methods of capitalizing titles.
  There are several forms of capitalizion rules, but one of the most popular is
  called "title case" or "up style." Implement a function that will take a title
  in the form of a string and return the string with the correct capitalization
  for a title according to these rules.

  Always capitalize the first word in a title.
  Always capitalize the last word in a title.
  Lowercase the following words, unless they are the first or last word of the title:
  "a", "the", "to", "at", "in", "with", "and", "but", "or."
  Uppercase any words not in the list above.
  (This is not the exact set of rules, but pretty close)

  A word is defined as a series of non-space characters.

  Example 1: "i love solving problems and it is fun"
  Would return "I Love Solving Problems and It Is Fun"

  Example 2: "wHy DoeS A biRd Fly?"
  Would return "Why Does a Bird Fly?"

  */

  [TestClass]
  public class TitleCaseTests
  {
    [TestMethod]
    public void Example1()
    {
      var result = TitleCase("i love solving problems and it is fun");
      Assert.AreEqual("I Love Solving Problems and It Is Fun", result);
    }

    [TestMethod]
    public void Example2()
    {
      var result = TitleCase("wHy DoeS A biRd Fly?");
      Assert.AreEqual("Why Does a Bird Fly?", result);
    }

    [TestMethod]
    public void Corner1()
    {
      var result = TitleCase("aT");
      Assert.AreEqual("At", result);
    }

    [TestMethod]
    public void Corner2()
    {
      var result = TitleCase("");
      Assert.AreEqual("", result);
    }

    private List<string> lowerList = new List<string>
    {
      "a",
      "the",
      "to",
      "at",
      "in",
      "with",
      "and",
      "but",
      "or"
      };


    public string TitleCase(string title)
    {
      if (string.InNullEmpty(title))
      return string.Empty;

      title = title.ToLower();
      var words = title.Split(' ');

      words[0] = Capitalize(words[0]);

      words[words.Length - 1] = Capitalize(words[words.Length - 1]);

      for (int i = 0; i < words.Length; i++)
      {

        if(i == 0 || i = words.Length - 1 || !lowerList.Contains(words[i]))
              words[i] = Capitalize(words[i]);
       }
      return string.join(" ", words);
    }

    public string Capitalize(string word)
    {

      word = char.ToUpper(word[0]) + word.Substring(1);
      return word;
    }

  }
}
