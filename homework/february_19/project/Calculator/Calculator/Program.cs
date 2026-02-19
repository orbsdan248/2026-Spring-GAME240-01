// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator! What would you like to do today? (Please Capitalize)");
String function = Console.ReadLine();

Console.WriteLine("What is your first number?");
double a = Double.Parse(Console.ReadLine());

Console.WriteLine("What is your second number?");
double b = Double.Parse(Console.ReadLine());

Console.WriteLine("Here is your result!");
if (function == "Addition")
{
   Console.WriteLine(a + b); 
}
if (function == "Subtraction")
{
   Console.WriteLine(a - b);
}
if (function == "Multiplication")
{
   Console.WriteLine(a * b);
}

if (function == "Division")
{
   Console.WriteLine(a / b);
}

if (b == 0 && function == "Division")
{
   Console.WriteLine("Really? You thought you could get away with that?");
   Thread.Sleep(3000);
   Console.WriteLine("My friend, you have met a terrible, terrible demise. But you know I don’t feel to bad about it.");
   Thread.Sleep(3000);
   Console.WriteLine( "After all, if it weren’t from me, it would have just been from someone else, ya know? I guess what I’m trying to say life, life goes on");
   Thread.Sleep(3000);
   Console.WriteLine("W- well, for everyone else, life goes on not for you, you’re dead. That’s neither here nor there. That reminds me of one summer day in the park, I was having a delightful picnic with my good friend Orville. \n ");
   Thread.Sleep(3000);
   Console.WriteLine("And I said to him, I said “Orville, I-I have a story” And he said to me “What’s the significance of the story?” I said to him “Orville, not every story has to have significance, ya know? \n ");
   Thread.Sleep(3000);
   Console.WriteLine("Sometimes uhh, sometimes a story is just a story. You try to read into every little thing and find meaning in everything anyone says, you’ll just drive yourself crazy.");
   Thread.Sleep(3000);
   Console.WriteLine("Elephants have those clumsy hands, ya know? Actually, I suppose that’s the problem, they don’t have hands at all, they’re all feet. I couldn’t imagine someone asking me to eat a sandwich with my feet. \n ");
   Thread.Sleep(3000);
   Console.WriteLine("Now, if I recall correctly there was a bakery nearby, I said to him “Orville, let me go get you some rye bread.” ");
   Thread.Sleep(3000);
   Console.WriteLine("Now, I’m unsure elephants enjoy rye bread, but, I assure you that Orville does. Now this was on a Tuesday which was good because rye bread was always fresh on Tuesday.");
   Thread.Sleep(3000);
   Console.WriteLine("They made sourdough on Monday and threw it out Wednesday. or rather they sold it at a discount for people who wanting to feed the ducks and then probably at the end of the day they threw it all out. ");
   Thread.Sleep(3000);
   Console.WriteLine("I do remember a man who would being his son to the bakery every Wednesday, and go feed the ducks.");
   Thread.Sleep(3000);
   Console.WriteLine("He would buy all of the sourdough bread, of course, you know, you’re not supposed to feed the ducks sourdough bread at all.\n ");
   Thread.Sleep(3000);
   Console.WriteLine("It swells up in their stomach and they all die, at least that’s what I’ve heard. Ya know I never saw any ducks die myself but I did notice a substantial decrease in duck population over the course of a few years.");
   Thread.Sleep(3000);
   Console.WriteLine("I just never thought to stop the man and tell him he was killing the ducks by feeding them sourdough bread.");
   Thread.Sleep(3000);
   Console.WriteLine("And if you want my opinion on the matter if you wanna feed ducks or birds or any kind for that matter, especially buy seed. I mean, when you think about it, breads of any sort don’t occur in nature. ");
   Thread.Sleep(3000);
   Console.WriteLine("They don’t grow on trees or spring up from bushes! I don’t think birds know what to do with bread. What was I saying? \n ");
   Thread.Sleep(3000);
   Console.WriteLine(" Oh oh yes yes. So I bought Orville some rye bread. What a fine day it was.");
}

/* My friend, you have met a terrible, terrible demise. But you know I don’t feel to bad about it.
 After all, if it weren’t from me, it would have just been from someone else, ya know? I guess what I’m trying to say life, life goes on. 
 W- well, for everyone else, life goes on not for you, you’re dead. That’s neither here nor there. That reminds me of one summer day in the park, I was having a delightful picnic with my good friend Orville. 
 And I said to him, I said “Orville, I-I have a story” And he said to me “What’s the significance of the story?” I said to him “Orville, not every story has to have significance, ya know? 
 Sometimes uhh, sometimes a story is just a story. You try to read into every little thing and find meaning in everything anyone says, you’ll just drive yourself crazy. 
 Had a friend do it once, wasn’t pretty, we talked about it for years. And not only that, you’ll likely end up believe something you shouldn’t believe or thinking something you shouldn’t think o-o-or assuming something you shouldn’t assume, ya know? 
 Sometimes I said a story is just a story, so just be quiet for one second here life and eat your sandwich, okay? Of course, it was only then I realized i made sandwiches and poor Orville was having such difficulty eating it! 
 Elephants have those clumsy hands, ya know? Actually, I suppose that’s the problem, they don’t have hands at all, they’re all feet. I couldn’t imagine someone asking me to eat a sandwich with my feet. 
 Now, if I recall correctly there was a bakery nearby, I said to him “Orville, let me go get you some rye bread.” Now, I’m unsure elephants enjoy rye bread, but, I assure you that Orville does. Now this was on a Tuesday which was good because rye bread was always fresh on Tuesday. 
 They made sourdough on Monday and threw it out Wednesday. or rather they sold it at a discount for people who wanting to feed the ducks and then probably at the end of the day they threw it all out. I do remember a man who would being his son to the bakery every Wednesday, and go feed the ducks. 
 He would buy all of the sourdough bread, of course, you know, you’re not supposed to feed the ducks sourdough bread at all.
 It swells up in their stomach and they all die, at least that’s what I’ve heard. Ya know I never saw any ducks die myself but I did notice a substantial decrease in duck population over the course of a few years. I just never thought to stop the man and tell him he was killing the ducks by feeding them sourdough bread. 
 And if you want my opinion on the matter if you wanna feed ducks or birds or any kind for that matter, especially buy seed. I mean, when you think about it, breads of any sort don’t occur in nature, they don’t grow on trees or spring up from bushes! I don’t think birds know what to do with bread. What was I saying? 
 Oh oh yes yes. So I bought Orville some rye bread. What a fine day it was. */