// See https://aka.ms/new-console-template for more information
using Feature92;
using System;
using System.Text;

Console.WriteLine("Assignment and declaration in same deconstruction");
var rectangle = new Rectangle(10, 20);
(int h, int w) = rectangle;

int height = 0;
//int width = 0;
(height, int width) = rectangle; //assignment and declaration is not possible in deconstructor in c# 10

