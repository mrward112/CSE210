// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book fablehaven = new Book ("Fablehaven", "Brandon Mull");
Book lightning_thief = new Book ("Lighting Thief", "Rick Riordan");


mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());

fablehaven.Display();
lightning_thief.Display();