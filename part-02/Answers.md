# Part 02 — answers

---

## Reports

- What was the problem?
The Problem that it was lots of logics and states shared across all ways to export.
- What did you change?
I created abstract class and made the export classes inherit from him.
I put all the shared logics in the abstract class to make all the classes can perform them.
I made the different behaviour of each class as a abstract method and every class override it with its specfic implementation.
- Why did you choose that approach?
I chose that approach because i had shared logic across many classes and in the same time there was different behaviour for every class, so i made every exporter is responsible for its specific behaviour and all classes can access to the shared logic and if you need to add a new way to export you will just make him inherit from Exporter class and override its specfic behaviour instead of duplicating the logic more and more.
---

## Enrollment

- What was the problem?
The problem that when you need to enroll new student you must create four services every time. 
- What did you change?
I created an class which be responsible for that creation and perform this process through it by just call Enroll() instead of call all the services every time.
- Why did you choose that approach?
Because this approach allows me to create any numbers of student by just call Enroll() 