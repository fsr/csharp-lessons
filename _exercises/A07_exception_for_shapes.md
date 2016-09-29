---
title: A07 - Exception for Shapes
number: 12
status: drafty
authors: marc
lesson: 5
---

This time we want to handle the exception of the user inputs.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_05/A07_exception_for_shapes/ExerciseSolution/).

### Step 1

Catch the exception that can happen in the `CreatePoint` method. 
If a exceptions happens return `null`.

### Step 2

Update the `CreatePolygon` method so that the `null` as point is captured and solved.

The user need to enter a new point if there was a problem.

### Step 3

Update both, the `CreatePolygon` and the `CreateCircle` method, with exception handling for the radius or vertex count.

*Hint: Maybe you need to update the whole process of entering the numbers.*

### Step 4

Comment your new code.