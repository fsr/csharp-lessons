---
title: Polygon Area - 2
number: 3
status: finished
authors: marc
lesson: 2
---

Extension of the polygon area calculation by user input. There can be arbitrary many vertices (max 100) of the polygon.

### Step 1

Read the user input [^user_input] the user input. The user input for a new vertex should be look like `x:y`.

[^user_input]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/system.console.readline%28v=vs.110%29.aspx)

If the user don't want to enter more vertex he can enter an empty string. The programm should notify the user that the input has ended.

### Step 2

Split the string[^string_split] and use both coordinates separately.

[^string_split]:
    [MSDN site](https://msdn.microsoft.com/de-de/library/tabh47cf%28v=vs.110%29.aspx)

Parse all the the input strings to numbers and save them in the array.

We assume that the user only enters correct input strings.

### Step 3

Calculate the polygon area and print the soultion on the console.
