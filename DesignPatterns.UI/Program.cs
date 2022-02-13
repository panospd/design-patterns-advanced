using DesignPatterns.UI.Memento.Documents;
using DesignPatterns.UI.Memento.Documents.Actions;

var document = new Document();
var history = new DocumentHistory();

document.Update(new SetContentAction("a content"));
document.Update(new SetFontNameAction("a font name"));
document.Update(new SetFontSizeAction(2));

history.Push(document.CreateState());

document.Update(new SetContentAction("b content"));
document.Update(new SetFontNameAction("b font name"));

document.Restore(history.Pop());

System.Console.WriteLine(document.Content);
System.Console.WriteLine(document.FontName);
System.Console.WriteLine(document.FontSize);

