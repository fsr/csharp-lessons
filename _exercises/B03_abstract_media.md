---
title: B03 - Abstract Media class and derivation
number: 8
status: drafty
authors: [marc, sascha]
lesson: 4
---

Now we want to extend our Library example a bit more. This time we will use abstract class and more.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/04_vererbung_und_polymorphie/B03_abstract_media/).

### Step 1

First we create an `abstract` class with the name `Medium`. This class need the following member:

- a `protected` field "borrowedTo" with the type of `UserAccount`
- a `string` property "Title"
  - it has a `get` and a `protected set`
- a constructor with one parameter: title
- a `virtual` method "Search" that searches in its mambers with a given query and returns `true` if a member matches with the search query

*Hint: It would be great if the class is in the same folder than the `Book` class.*
*Hint: Dont forget the base constructor.*

### Step 2

Now let our `Book` class be derived from `Medium` and adjust it to the derivation. 

*Hint: Maybe you can delete a few lines of code in `Book` because of this derivation.*

### Step 3

Adjust your "Search" method in `Book` so that it will use its derived code.

*Hint: A `base` call wouldn't be bad idea.*

### Step 4

Adjust your `Library` and `UserAccount` class.
Especially change your "Search" method in `Library` so, that it will now give a array of `Medium`

*Hint: Maybe your member needs a new typ and also a new name.*

### Step 5

Now that we have a new base class, let us create some more classes that will derive from that.

Create `Magazine` class with the following members:
- a `string` property with the name "ISSN"
- two `int` properties with the names "Issuing" and "Year"
  - they all have a `get` and a `private set`
- a constructor with four parameters: title, issn, issuing and year
- a method "Search" that searches in its members with a given search query and returns `true` if a member match with the query

Create `Video` class with the following members:
- a `string` property with the name "EAN"
  - it has a `get` and a `private set`
- a constructor with two parameters: title and ean
- a method "Search" that searches in its members with a given search query and returns `true` if a member match with the query

*Hint: This two classes would have a good place in the same folder as the `Book` class.*
*Hint: Dont forget the base constructor here too.*

### Step 6

Again, create documentation comments for your newly created classes, methods, fields and properties.