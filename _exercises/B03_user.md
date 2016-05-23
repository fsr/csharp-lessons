---
title: B03 - User of the Library
number: 7
status: reviewed
authors: [marc, sascha]
lesson: 3
---

After we created a `Library` and `Book` class we want to create a user to use this library.[^tests] [^solution]

[^tests]:
    You can find the tests for this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/03_objektorientierung/B03_user/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/03_objektorientierung/B03_user/ExerciseSolution/).

### Step 1

Create the following classes:

- `Library` in the solution folder
- `Book` in the "Media" folder
- `UserAccount` in the "User" folder

### Step 2

Fill the `UserAccount` class with the following members:

- two `string` properties: "Name" and "EMail"
- a `long` property "ID"
  - all of them have a `get` and a `private set`
- a `private` array of `Book` as field "borrowedBooks"
  - the user can only borrow 5 books at a time
- a constructor with three parameters: name, email and id

Add to the `Library` class the following members:

- a `private` array field of `UserAccount` "users"
  - the library can only have 100 users at a time
- a `private int` field "userCount" that contains the number users already registered
- method `RegisterUser` with two parameters: name and email

Add to the `Book` class the following member:

- a `private UserAccount` field "borrowedTo"

### Step 3

Implement the "Register" method. It should add a new user to the array of users. Create a new user with the given parameters.

*Hint: We don't get the id as parameter in this method. What can you use as an id for the constructor?*

### Step 4

Write for all created classes, methodes, properties and fields documentation comments.
