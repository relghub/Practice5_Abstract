﻿using Abstraction_Distraction;

// Приклад
/*
UserFamily user1 = new("Крикун", "Владислав", 19);
Console.WriteLine(user1.ui());
*/
Console.OutputEncoding = System.Text.Encoding.UTF8;

Tetrahedron fig1 = new(6,20);
Console.WriteLine(fig1.ValuesPrint());
Octahedron fig2 = new(12,12);
Console.WriteLine(fig2.ValuesPrint());
Cube fig3 = new(12,34);
Console.WriteLine(fig3.ValuesPrint());