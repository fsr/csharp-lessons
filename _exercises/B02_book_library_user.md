---
title: Book, Library and User
number: 6
status: drafty
authors: marc
lesson: 3
---

This time we want to create three classes and fill them with some code.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/03_objektorientierung/B01_book_library_user/).

### Step 1

Create the following classes:

- `Library` in the solution folder
- `Book` in the "Media" folder
- `UserAccount` in the "User" folder

### Step 2

Fill the `Book` class with the following members:

- three `string` properties: "Title", "Autor" and "ISBN"
  - they have a `get` and a `private set`
- a `private UserAccount` field "borrowedTo"
- a constructor with three parameters: title, autor and isbn
- a method "Search" that searches in its members with a given search query and returns `true` if a member match with the query

Fill the `UserAccount` class with the following members:

- two `string` properties: "Name" and "EMail"
- a `long` property "ID"
  - all of them have a `get` and a `private set`
- a `private` array of `Book` as field "borrowedBooks"
  - the user can only borrow 5 books at a time
- a constructor with three parameters: name, email and id

Fill the `Library` class with the following members:

- a `private` array field of `UserAccount` "users"
  - the library can only have 100 users at a time
- a `private` array field of `Book` "books"
  - the library can only manage 500 books at a time
- a standard constructor
- a method "Search" that serches through all books with a given search query and returns an array of `Book`

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

Create for all created classes, methode, properties and field documentation comments.