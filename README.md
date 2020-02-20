# Shape Simulator
This console application simulates the addition of the following widgets to a page: rectangle, square, ellipse, circle and textbox. This project responds to its specification by exploring and implementing SOLID design principles.
## Table of Contents
- [The Challenge](#the-challenge)
- [The Principles of Object-Oriented Design](#the-principles-of-object-oriented-design)
  - [SOLID](#solid)
    - [Single Responsibility Principle](#single-responsibility-principle)
    - [Open–Closed Principle](#open/closed-principle)
    - [Liskov Substitution Principle](#liskov-substitution-principle)
    - [Interface Segregation Principle](#interface-segregation-principle)
    - [Dependency Inversion Principle](#dependency-inversion-principle)
- [Design Rationale](#design-rationale)
- [Bibliography](#bibliography)
## The Challenge
To develop a console application that simulates a vector-based drawing package. The application must support the following five drawing primitives: rectangle, square, ellipse, circle and textbox. These may also be referred to as widgets. All widgets must have relevant dimensions and a pair of coordinates which represent its location on an imaginary page. The necessary dimensions are as follows:
1) rectangle—width and height,
2) square—width,
3) ellipse—horizontal and vertical diameter,
4) circle—diameter,
5) textbox—width and height of bounding rectangle.

Naturally, the textbox must have the functionality of displaying text within its bounding rectangle.
## The Principles of Object-Oriented Design
Before writing any code, it is apposite to review best practice in code design. The acronym SOLID is a set of principles that guide developers to thoroughly exploit the advantages of object-oriented programming. This section is based on the sources in the [bibliography](#bibliography).  
<sub><sup>NB: All quotes are taken from the work of Robert Martin (2000, 2006).</sup></sub>
### SOLID

#### Single Responsibility Principle
> A class should have only one reason to change.

Each module, class and function should have a single responsibility. For example, a module that prints a report could be separated into one that determines the content (substantive) and another that determines the format (cosmetic). This ensures robustness of classes.
#### Open–Closed Princiiple
> A module should be open for extension, but closed for modification.

Put another way, an entity should be designed in such a way that it can be extended without being modified. This is achieved through the use of abstractions and ensures extensibility and robustness to changing requirements.
#### Liskov Substitution Principle
> Subclasses should be substitutable for their base classes.

A derived class should contain all the functionality of its base class, so a user of the latter will continue to function normally if the former is passed to it. An illustrative example of the violation of this principle is letting circle be a derivative of ellipse: circles have a single property—radius—while ellipses requier three—two foci and the length of the major axis. Attempting to navigate this design flaw via a verfication step (an if–else or switch statement), would introduce an open–closed principle (OCP) violation.
#### Interface Segregation Principle
> Many client specific interfaces are better than one general purpose interface.

Classes should not contain extraneous properties or methods. This is achieved with fine-grained interfaces with specific methods. The benefit of this principle is robustness.
#### Dependency Inversion Principle
> Depend upon abstractions. Do not depend upon concretions.

Rather than high-level modules depending on low-level modules, as in procedural architecture, both should depend on abstractions. Traditional layers pattern:  
<p align="center">Policy Layer → Mechanism Layer → Utility Layer</p>
Dependency Inversion Pattern: 
<p align="center">Policy Layer → Interface ← Mechanism Layer → Interface ← Utility Layer</p>

## Design Rationale
My design choices were principally guided by SOLID principles, but also by the Agile principle of simplicity. The foundation of the architecture is the abstract class `Shape`, which is able to serve as a base class for all widgets because the primitives share certain features and may, thus, be grouped together. Relying on an abstract super class respects the dependency inversion principle (DIP).

The base class includes two virtual properties, `protected int x` and `protected int y`, an abstract method, `public abstract void Print()`, and a constructor. Firstly, The `protected` keyword is attributed to the variables because they are only called by derived classes. Secondly, declaring the coordinates as virtual properties reduces the need for duplication as all primitives require a location to be 'drawn' on the page. This repects the Liskov substitution principle (LSP) as all widgets have all the features of the `Shape` class. Furthermore, the widgets contain no extraneous features as prescribed by the integration seperation principle (ISP).

Manifestly, this architecture follows the OCP as the `Shape` class doesn't have to be modified to add additional primitives. Moreover, the abstract `Print()` method signature forces all subclasses to override it. An alternative solution may have been to have one `Print()` method that took advantage of an if-else/switch statement to output the required format for the given widget. This, however, would have been in violation of the OCP. The chosen solution offers superior robustness to changing requirements and extensibility.

Returning to the LSP, the decision was made to not have circle inherit from ellipse, nor square from rectangle, because the derived classes would not have all the properties of their progenitors. On the other hand, `Textbox` inherits  from `Rectangle`. Although this could be considered an infringement of the DIP, it is in line with the LSP and the ISP, and avoids tthe duplication of common properties.

## Bibliography
- Grace Hopper Academy, 2016, *S.O.L.I.D. Principles of Object-Oriented Design - A Tutorial on Object-Oriented Design*, YouTube, viewed 18 February 2020, https://www.youtube.com/watch?v=GtZtQ2VFweA
- Martin, R 2000, *Design Principles and Design Patterns*, Objectmentor, viewed 19 February 2020, https://web.archive.org/web/20150906155800/http://www.objectmentor.com/resources/articles/Principles_and_Patterns.pdf
- Martin, R 2006, *The Principles of OOD*, butunclebob.com, viewed 19 February 2020, http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod
- Web Dev Simplified, 2020, *SOLID Design Principles*, YouTube, viewed 18 February 2020, https://www.youtube.com/playlist?list=PLZlA0Gpn_vH9kocFX7R7BAe_CvvOCO_p9
- Wikipedia, 2020, *SOLID*, viewed 18 February, https://en.wikipedia.org/wiki/SOLID
