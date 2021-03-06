(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
GuruTutor
======================

MOST OF THIS PAGE IS A TEMPLATE AND IS NOT FUNCTIONAL: 3-10-16

GuruTutor is a redesign of two previous projects:

* GnuTutor

* Guru

Both of these projects were **intelligent tutoring systems (ITS)**, which are computer programs that try to emulate human tutors. These projects in particular are **conversational ITS**, meaning that they tutor by holding a natural language conversation with the student.

GuruTutor attempts to update GnuTutor with some of the ideas from Guru, but does not have the complete functionality of Guru.

**Disclaimer:**

Guru was supported by the Institute of Education Sciences, U.S. Department of Education, through Grant R305A080594 to the University of Memphis. The opinions expressed are those of the authors and do not represent views of the Institute or the U.S. Department of Education.

Installation
------------

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The GuruTutor library can be <a href="https://nuget.org/packages/GuruTutor">installed from NuGet</a>:
      <pre>PM> Install-Package GuruTutor</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

Example
-------

This example demonstrates using a function defined in this sample library.

*)
#r "GuruTutor.dll"
open GuruTutor

printfn "hello = %i" <| Library.hello 0

(**
Some more info

Samples & documentation
-----------------------

The library comes with comprehensible documentation. 
It can include tutorials automatically generated from `*.fsx` files in [the content folder][content]. 
The API reference is automatically generated from Markdown comments in the library implementation.

 * [Tutorial](tutorial.html) contains a further explanation of this sample library.

 * [API Reference](reference/index.html) contains automatically generated documentation for all types, modules
   and functions in the library. This includes additional brief samples on using most of the
   functions.
 
Contributing and copyright
--------------------------

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding a new public API, please also 
consider adding [samples][content] that can be turned into a documentation. You might
also want to read the [library design notes][readme] to understand how it works.

The library is available under Public Domain license, which allows modification and 
redistribution for both commercial and non-commercial purposes. For more information see the 
[License file][license] in the GitHub repository. 

  [content]: https://github.com/fsprojects/GuruTutor/tree/master/docs/content
  [gh]: https://github.com/fsprojects/GuruTutor
  [issues]: https://github.com/fsprojects/GuruTutor/issues
  [readme]: https://github.com/fsprojects/GuruTutor/blob/master/README.md
  [license]: https://github.com/fsprojects/GuruTutor/blob/master/LICENSE.txt
*)
