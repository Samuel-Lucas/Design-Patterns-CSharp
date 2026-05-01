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