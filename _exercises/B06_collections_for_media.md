---
title: B06 - Collections for Media
number: 14
status: reviewed
authors: [marc, sascha]
lesson: 6
---

After we learned something about the collections we want to use them in our project.[^tests] [^solution]

[^tests]:
    You can find the tests for this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/lesson_06/B06_collections_for_media/Tests)

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/blob/master/lesson_06/B06_collections_for_media/ExerciseSolution/).

### Step 1

Switch the array "borrowedMedia" in `UserAccount` to a list.

### Step 2

Change the two arrays "media" and "users" in `Library` to dictionaries. Use as the key for both a `long`.

### Step 3

Now we update the method "AddNewMedium". Use the new dictionary and use the "mediaCount" as the key and the new medium as the value of the new entry.

Do the same for the "RegisterUser" method but use "userCount" as key and the new user as value instead.

### Step 4

Update the method "Search". Use the foreach loop and change the return parameter to a list.

*Hint: We don't need to make the array as long as the number of entries because the list is allways as long as how many entries it have.*

### Step 5 (optional)

Update all your documentation commentaries.
