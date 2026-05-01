# 🧩 Pattern Name
Abstract Factory

## 📖 What is it?
The Abstract Factory is a creational pattern that provides an interface for creating families of related objects without needing to specify their concrete classes.
In simple terms: you create a "factory of factories" that ensures the objects created are compatible with each other.

---

## 🎯 When to use?
 Use this when you need to create objects that belong to the same set/coherence:
 - When your system needs to support multiple databases (e.g., Ingres, SQL Server, Oracle)
 - When you want to easily switch implementations without altering the main code
 - When there is a dependency between objects created together (e.g., connection + command + adapter)
 - When you want to follow the Open/Closed principle (open for extension, closed for modification)


---

## 🚫 When not to use ?
Avoid using this when:
 - The system is simple and uses only one implementation.
 - You don't need to switch object families.
 - It will generate unnecessary complexity.
 - Overengineering (too many standards for too few problems).
---

## 🧠 How does it work?
The idea is to define:
 - Abstract factory interface
 - Concrete factories
---

🧩 Pattern Name
Builder
📖 What is it?
The Builder pattern is a creational design pattern that lets you construct complex objects step by step, separating the construction process from the final representation.
In simple terms: it allows you to build an object gradually, controlling each part of its creation, instead of using a large and confusing constructor.
---

🎯 When to use?
Use Builder when:
An object has many optional parameters
You want to avoid telescoping constructors (constructors with too many arguments)
The construction process needs to follow specific steps or order
You need to create different representations of the same object
You want more readable and maintainable object creation
Practical scenarios:
Creating complex configuration objects
Building SQL queries dynamically
Constructing UI components step by step
Creating immutable objects with many fields
Generating documents (HTML, JSON, reports)
---

🚫 When not to use?
Avoid Builder when:
The object is simple and has few parameters
A constructor or object initializer is already clear enough
The added abstraction would make the code unnecessarily complex
There is no need for step-by-step construction

---
🧠 How does it work?
The Builder pattern separates the construction logic into distinct roles:
Builder Interface
Defines the steps required to build the object.
Concrete Builder
Implements those steps and keeps track of the object being built.
Product
The final object that is being constructed.
Director (optional)
Controls the order of building steps. It defines how to build a specific version of the object.