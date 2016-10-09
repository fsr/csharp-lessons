---
title: A07 - Exception for Shapes
number: 15
status: finished
authors: marc
lesson: 5
---

This time we want to handle the exception of the user inputs.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-lessons-exercise-solutions/tree/master/lesson_05/A07_exception_for_shapes/ExerciseSolution/).

### Step 1

Throw a exception if the un overriden "calculateArea" method in `Shape` is used.

*Hint: Which exception would be the suited one?*

### Step 2

Update the `CreatePolygon` method so that the program catches a wrong input (no `int`).

The user need to enter a new point if there was a problem.

### Step 3

Update both, the `CreatePolygon` and the `CreateCircle` method, with exception handling for the radius or vertex count.

*Hint: Maybe you need to update the whole process of entering the numbers.*

### Step 4

Comment your new code.