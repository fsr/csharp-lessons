---
title: B07 - Fee calculation with DateTime
number: 20
status: reviewed
authors: [marc, sascha]
lesson: 7
---

This time we want to calculate overdraft fees for the media.[^tests] [^solution]
    
[^tests]:
    You can find the tests for this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_07/B07_fee_calculation/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_07/B07_fee_calculation/ExerciseSolution/).

### Step 1

First we will extend our `Medium` class with a few new members:
- a `int` property with the name "Period"
- a `float` property with the name "FeePerDay"
- a `DateTime` property with the name "ReturnDate" (the predicted date the book should be returned)
  - they all have a `get` and a `protected set`
- a `public` method "CalculateFee" that will calculate the fee that is need to pay

We extend our `UserAccount` with one member too:
- a `float` property with the name "FeeToPay" 
  - it has a `get` and a `protected set`

*Hint: `DateTime` can be found in the namespace `System`.*

### Step 2

Update your constrcutor and all constructor for your children classes.

Also familiarize yourself with the `DateTime`[^dateTime] class. We will need some things from it (e.g. in the constructor).

[^dateTime]:    
    [MSDN site](https://msdn.microsoft.com/de-de/library/system.datetime%28v=vs.110%29.aspx) for `DateTime`
    
### Step 3

Now we write the implementation for the "CalculateFee" method.

It should allways return 0.0 if the actual date (the actual return date) is befor the predicted "ReturnDate".
Calculate the fee also for a started day.

*Hint: To measure the difference between to dates the `Tick` property of DateTime is really nice.*

### Step 4

And again, create documentation comments on all created stuff.
