---
title: A07 - Lists for Shapes
number: 16
status: drafty
authors: marc
lesson: 6
---

Lists are better than arrays. Therefor we want to switch all arrays to lists.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_06/A07_lists_for_shapes/ExerciseSolution/).

### Step 1

We want to change all appearance of arrays in the `Polygon` class to `List<Point2D>`:

- change the typ of the property and field "Vertices"
- change the `get` of "VertexCount"
- change the constructor
  - we didn't need the parameter for the vertex count anymore but we need to initialize a empty list instead
- also change the methods

