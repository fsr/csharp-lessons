---
title: B02 - Book and Library
number: 6
status: reviewed
authors: [marc, sascha]
lesson: 3
---

This time we want to create three classes and fill them with some code.[^test] [^solution]

[^test]:
    You can find a test project for this task 
    [Here](https://github.com/satkowski/csharp-solutions/tree/master/03_objektorientierung/B02_book_library/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/03_objektorientierung/B02_book_library/ExerciseSolution/).

### Step 1

Create the following classes:

- `Library` in the solution folder
- `Book` in the "Media" folder

### Step 2

Fill the `Book` class with the following members:

- three `string` properties: "Title", "Autor" and "ISBN"
  - they have a `get` and a `private set`
- a constructor with three parameters: title, autor and isbn
- a method "Search" that searches in its members with a given search query and returns `true` if a member match with the query

Fill the `Library` class with the following members:

- a `private` array field of `Book` "books"
  - the library can only manage 500 books at a time
- a `private int` field "bookCount" that contains the number of books already in the stock
- a standard constructor
- a method "Search" that serches through all books with a given search query and returns an array of `Book`
- a method "AddNewBook" that adds a given book (as parameter) to the stock of all books of the library

### Step 3

Implement (if you haven't done it yet) the "Search" method in `Book`.

### Step 4

Now we want to implement the "Search" method in `Library`. 
This method should only search if the search query has a length greater than 2. 
The result array should have the size[^length] of the numbers of results and not more.

[^length]:
    You can get the size of an array with the `.Length` property. ([MSDN site](https://msdn.microsoft.com/de-de/library/system.array.length%28v=vs.110%29.aspx))

*Hint: Maybe you need a temporary array to solve this.*

### Step 5

Finally we implement the "AddNewBook" method. It should add the new book to the stock of books and save the new book count.

### Step 6

Create for all created classes, methodes, properties and fields documentation comments.
