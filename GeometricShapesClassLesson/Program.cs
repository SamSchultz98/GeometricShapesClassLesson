﻿using GeometricShapesClassLesson;
using GeometricShapesClassLesson;

Quad q2 = new Rect(1, 2);
var p = q2.Perimeter();


Rect r2 = new Square(3);
//Console.WriteLine(r2.Print());


Quad q1 = new(3, 4, 5, 6);
//Console.WriteLine($"Quad:{q1.Print()}");


Rect r1 = new(3, 5);
//Console.WriteLine($"Rect:{r1.Print()}");


Square s1 = new(5);
//Console.WriteLine($"Square:{s1.Print()}");

Quad[] quads = { q1, r1, s1 };

foreach (Quad q in quads)
{
    Console.WriteLine(q.Print());
    
}
