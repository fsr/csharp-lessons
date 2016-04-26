---
title: Polygon Area - 1
number: 2
status: finished
authors: marc
lesson: 2
---

Calculate the area of a polyon given with a set of points to represent his vertices.

### Step 1

Create two int arrays. One for all x and the other for all y coordinates. Fill those with values.

### Step 2

Create an method that take two arrays as input parameter und calculate a float value as area.

### Step 3

Go through all points in the two input arrays and calculate the area of the polygon[^polygon_area].

[^polygon_area]:
    [Wikipedia site](https://de.wikipedia.org/wiki/Polygon#Fl.C3.A4che) for polygon area calculation.
    
If you need to make the solution absolut use the Abs-Method[^abs]

[^abs]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/system.math.abs%28v=vs.110%29.aspx) for `Math.Abs()`
    
*Hint: That calculation uses pairs of points (with the left or right neighbour). So you need to use the pair from the first to the last point too.*

### Step 4

Show the solution in the console.