# 🎯 Design Patterns in C# ASP.NET

This project demonstrates 3 core object-oriented design patterns using C# with simple, real-world-inspired examples. Each pattern is implemented in its own module with clean code and comments — perfect for learning and demonstration.

---

## 🔥 Why Design Patterns?

Design Patterns are **reusable, proven solutions** to common software design problems. They:

- Promote **code reusability** and **readability**
- Make systems **easier to maintain and scale**
- Follow **SOLID** and **OOP** principles
- Help you think like a software architect 🧠

---

## 🧰 Patterns Implemented

### 🏭 1. Factory Pattern – *Object Creation Simplified*

**💡 Example Used:** `Notification Service`  
Different types of notifications (Email, SMS) are created using a centralized factory.

**🔍 Concept:**  
You don’t create objects with `new` directly. Instead, the `NotificationFactory` decides which subclass to instantiate based on user input or type.

**✅ Real-World Use Cases:**
- Payment Gateways (Stripe, PayPal, etc.)
- UI Component Builders
- Document Exporters

**📂 Folder:** `FactoryPattern/`

---

### 👀 2. Observer Pattern – *Event-based Notification*

**💡 Example Used:** `YouTube Channel Menu`  
A YouTube channel notifies all its subscribers when a new video is uploaded.

**🔍 Concept:**  
One class (the Subject, e.g. Channel) keeps a list of observers (Subscribers), and notifies all of them when its state changes.

**✅ Real-World Use Cases:**
- Push notification systems
- Real-time stock price updates
- Chat apps or feed updates

**📂 Folder:** `ObserverPattern/`

---

### 🎨 3. Decorator Pattern – *Flexible Customization*

**💡 Example Used:** `Coffee Customizer`  
Start with a basic coffee and dynamically add milk, sugar, or whip cream without altering the original class.

**🔍 Concept:**  
You "wrap" objects in other objects to extend functionality without modifying their structure.
**✅ Real-World Use Cases:**
- Stream I/O (e.g., adding compression/encryption)
- UI themes and styling
- Middleware in web frameworks (like ASP.NET)

**📂 Folder:** `DecoratorPattern/`

---

## 🗂️ Project Structure

DesignPattern/
│
├── FactoryPattern/ # Factory Pattern: Notification Service (Email, SMS)
│ ├── NotificationFactory.cs
│ ├── INotification.cs
│ ├── EmailNotification.cs
│ ├── SmsNotification.cs
│ └── Program.cs
│
├── ObserverPattern/ # Observer Pattern: YouTube Channel Subscriber System
│ ├── ISubscriber.cs
| ├── Subscriber.cs
│ ├── IChannel.cs
│ ├── Channel.cs
│ └── Program.cs
│
├── DecoratorPattern/ # Decorator Pattern: Coffee Customizer with Add-ons
│ ├── ICoffee.cs
│ ├── BasicCoffee.cs
│ ├── MilkDecorator.cs
│ ├── SugarDecorator.cs
│ ├── WhipCreamDecorator.cs
│ └── Program.cs
│
└── README.md # Project documentation


---

## 🚀 How to Run

1. Open this project in Visual Studio or VS Code.
2. Go to `Program.cs` and run.
3. Press **Run** or use `dotnet run` in terminal.
4. Follow the console prompts to see how each pattern works in action.

---

## 🙌 Credits

This project was created as part of my **internship learning journey at Kutumba Tech Pvt. Ltd.**.  
It helped me understand how to structure clean and scalable code using core design principles.

Thanks to the amazing team and mentors at [@Kutumba Tech Pvt. Ltd.] for their guidance and support! 💙

---

## 🏷️ Keywords

`C#` `Design Patterns` `Factory` `Observer` `Decorator` `.NET Console App` `SOLID Principles` `Internship Project` `Software Design`

---

## 📚 References

- [Refactoring Guru – Design Patterns](https://refactoring.guru/design-patterns)
- [Microsoft Docs – Patterns in .NET](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)
- [Geeks for Geeks - Software Design Patterns Tutorials](https://www.geeksforgeeks.org/system-design/software-design-patterns/)




