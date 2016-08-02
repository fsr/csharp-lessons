# C# Lessons

This repository contains the __C# Lesson__ sources for the free student courses, held at the TU Dresden. You can find the builded slides [here](https://fsr.github.io/csharp-lessons/materials.html "C# Lessons")

<!-- Exercises to go along with the courses can be found [on GitHub pages](http://fsr.github.io/csharp-lessons/) or on the `gh-pages` branch of this repository as Markdown sources. -->


## Writing your slides and getting started

**At first:** Talk to your system admin of trust™ and make him set up the "watch" script for this repository on the kaki so that your LaTeX files are being built on the web server every time you make a push to `master`.

### Next Steps:
- This repository already contains a directory called `latex/slides/`. This is where your presentation slides will have to live.
- If you use source code in your presentation, put the code in separate `.cs` files in a subfolder of `latex/slides/resources/`, which should be named like your presentation (for consistency purposes only).

When writing a new slide, copy the file `latex/templates/new_slide.tex` to the slides folder and rename it. Then start to write your own content. Note that it is important to add the file name of the new slide to the *build_conf.json* in **builds -> pdf -> files**. Otherwise, these slides won't be built on the kaki!

That's it! :tada:


#### Syntax Highlightning
You might want to customize the syntax highlightning. I'm not sure, how good the auto-highlight for C# is.
