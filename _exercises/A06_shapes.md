---
title: A06 - Shape class and derivation
number: 13
status: finished
authors: marc
lesson: 5
---

Now we want to extend our Polygon example a bit more. This time we will use inheritance.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-lessons-exercise-solutions/tree/master/lesson_05/A06_shapes/ExerciseSolution/).

### Step 1

Create an class `Shape`. This class needs the following member:

- a field for the position (`Point2D`) of the `Shape`
- a property with `get` and `protected set` for the area
- a constructor that take the position of that `Shape` as a parameter
- a `protected` method for the calculation of the area
  - it should return -1

### Step 2

Let your `Polygon` class derive from `Shape`. Change the internal structure of `Polygon` so that there are no errors through the derivation.

*Hint: Don't forget the `base` constructor.*

### Step 3

Create a new class `Circle` that also derive from `Shape`. This class needs also the following member:

- a `private` field and `public` for the radius
  - if the radius changed (per `set`) it should recalculate the area
- a constructor that take the radius of that `Circle` as a parameter
- override the implementation of the given calculation method for the area

### Step 4

Change the polygon creation method in the `Program`.

Create a new `static`[^static] method in the `Program` class to create a `Circle` with user input.
The radius should never be less or equal 0.

[^static]:
    We discuss `static` in a different lesson. So be patient ;)

*Hint: For the time being will use the (0, 0) point for the position of the shapes.*