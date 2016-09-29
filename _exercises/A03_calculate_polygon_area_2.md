---
title: A03 - Polygon Area with user input
number: 5
status: finished
authors: marc
lesson: 3
---

An extension of the polygon area calculation by user input. There can be arbitrary many vertices of the polygon.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_03/A03_polygon_area_2/ExerciseSolution/).

*We assume that the user only enters correct input strings.*

### Step 1

Read the number of vertices for the polygon from user input[^user_input].

[^user_input]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/system.console.readline%28v=vs.110%29.aspx) for `Console.WriteLine()`

Parse[^parse] the input string to a number.

[^parse]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/b3h1hf19%28v=vs.110%29.aspx) for `int.Parse()`
    
Only continue with the programm if the number is equal or greater than 3. If the input don't match with that criteria, the user should enter a new number.

### Step 2

Create the two arrays (empty) with the given count of vertices.

### Step 3

Read the user input. The user input for a new vertex should be look like `x-y`. The input for the vertices end if both arrays are full.

### Step 4

Split the string[^string_split] and use both coordinates separately.

[^string_split]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/tabh47cf%28v=vs.110%29.aspx) for `String.Split()`

Parse all the the input strings to numbers and save them in the array.

### Step 5

Calculate the polygon area and print the soultion on the console.