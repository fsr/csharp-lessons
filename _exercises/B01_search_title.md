---
title: B01 - Search title
number: 3
status: finished
authors: marc
lesson: 2
---

We have a arbitrary array of title for books or other stuff. We want to get the first title that the program can find from our own search query.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_02/B01_search_title/ExerciseSolution/).
    
### Step 1

Create a array of `string` and fill it with arbitrary book titles.

### Step 2

Create a new method (it need to be `static`[^static]) that need the array and an extra `string` (the search query) as parameter.

[^static]:
    We discuss `static` in a different lesson. So be patient ;)

It should return you the first appearence of a matching title string and if none was found it returns an empty string.

*Hint: To test if a string contains another string use the `Contains()`[^contains] method. This method is case sensetiv!*

[^contains]:
    [MSDN Site](https://msdn.microsoft.com/de-de/library/dy85x1sa%28v=vs.110%29.aspx) for stringobject`.Contains()`
    
### Step 3

Change the `Main` method to the new algorithm.

The user should enter a arbitrary search query. The programm only accept a search query if it has more than 2 characters in it.[^string_length]

[^string_length]:
    You can get the length of a string with the `Length` property of the string. ([MSDN Site](https://msdn.microsoft.com/de-de/library/system.string.length%28v=vs.110%29.aspx))
    
### Step 4

If a title was found it should be printed on the console. Else the programm should print "No title was found.".