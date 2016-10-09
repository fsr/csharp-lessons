---
title: B08 - Advancing the Library
number: 21
status: finished
authors: sascha
lesson: 7
---

Lets add some useful functionality to our library project[^solution]. The **tests** [^tests] for this exercise will help you work out the correct implementation. **Use them!**

[^tests]:
    You can find the tests for this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_07/B08_advanced_example/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_07/B08_advanced_example/ExerciseSolution/).

### What's to do

- Add (readonly) static limit `MAX_MEDIA_COUNT` to `UserAccount` to express that a user can only borrow 10 items
- Add `Borrow` and `ReturnMedia` methods to `UserAccount` (return bool)
- `ReturnMedia` should also update the Fees
- You can only return what you have borrowed. 
- You can only borrow if `MAX_MEDIA_COUNT` is not reached
- Add a property `BorrowedCount` to `UserAccount` that gives the curred number of borrowed items of this account
- Add `Borrow` and `ReturnMe` methods to `Medium` that marks/unmarks the borrower (`UserAccount`) and sets the returnDate/calculates the fees if late
- Add a method `Authentificate` to `Library` to identify a user. It shall take an long id and return a `UserAccount` object or null if this id is not connect to any account
