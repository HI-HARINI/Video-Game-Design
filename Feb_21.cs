//Today I wrote the code to displayy the variables I created on the console with context. The text below is the code I wrote to generate the suggested output. I also finished the entire Module.
string name = "Bob";
int messages = 3;
double temperature = 34.4;
Console.WriteLine("Hello, " + name + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celsius.");

//This is the "answer" that was revealed in Unit 7, though it is different, the output was the same.
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
