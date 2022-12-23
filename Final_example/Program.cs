using Final_example;

string sentence = "[][][][[[[]]";
string sentence1 = "]]][[[]]";
string sentence3 = "[[[[]]]]";
string sentence4 = "]]][[[";

Console.WriteLine(Algorithms.BracketMatch(sentence));
Console.WriteLine(Algorithms.BracketMatch(sentence1));
Console.WriteLine(Algorithms.BracketMatch(sentence3));
Console.WriteLine(Algorithms.BracketMatch(sentence4));




