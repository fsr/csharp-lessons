---
title: B07 - Advancing the Library
number: 15
status: drafty
authors: [sascha]
lesson: 6
---

Lets add some useful functionality to our library project.[^tests] [^solution]

[^tests]:
    You can find the tests for this task
    [Here](https://github.com/satkowski/csharp-solutions/tree/master/06_datenstrukturen/B07_advanced_example/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/06_datenstrukturen/B07_advanced_example/ExerciseSolution/).

### Step 1

TODO
* Add (readonly) static limit MAX_MEDIA_COUNT to UserAccount
* Add Borrow and ReturnMedia methods to UserAccount (return bool)
* ReturnMedia should also update the Fees
* You can only return what you have borrowed. 
* You can only borrow if MAX_MEDIA_COUNT is not reached
* Add a Property BorrowedCount to UserAccount that gives the curred number of borrowed items of this account
* Add Borrow and ReturnMe Methods to Medium that marks/unmarks the borrower (UserAccount) and sets the returnDate/calculates the fees if late

