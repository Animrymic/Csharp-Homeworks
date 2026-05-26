using Class02.Homework;
using System.Reflection.Metadata;

Document doc = new Document
(
    "My notes",
    "C# is a great programming language. I enjoy learning C# and building applications with it."
); 

WebPage page = new WebPage
(
    "https://youtu.be/wxznTygnRfQ?si=Iu9ddI4PRai4XLie",
    "<html><body><h1>Welcome to my website</h1><p>This is a sample webpage for testing search functionality.</p></body></html>"
);

string word1 = "C#"; 
string word2 = "Python";

Console.WriteLine("DOCUMENT SEARCH:");
Console.WriteLine($"Search '{word1}': {doc.Search(word1)}");
Console.WriteLine($"Search '{word2}': {doc.Search(word2)}");

Console.WriteLine("\nWEBPAGE SEARCH:");
Console.WriteLine($"Search '{word1}': {page.Search(word1)}");
Console.WriteLine($"Search '{word2}': {page.Search(word2)}");