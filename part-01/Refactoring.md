# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
When  want to add another way to shipping i must go to ShippingCostCalculator and add the case to the switch case.
- What did you change?
I created an interface and for every way to ship i created class to handle its calculation and implement the ICarrier in them,
this helped me to avoid modifying ShippingCost class in every time i need to add anoter way to ship.
---

## OrderProcessor

- What was the problem?
Every time I Call the process method, it create a new object of the SqlOrederRepository and SmtpEmailSender every once you save the order it is saved in diff repo and there is another problem, you are restricted by one OrderRepo class and one Email Sender class, so if you wanna change any of them you must modify in the order process and this violates ocp.

- What did you change?
i created two interfaces to OrderRepository and Email Sender,
then i created two prvate fields in the OrderProcess and assigned there values in the constructor,
now you can use any way to save the order and any way to send the email without modify in the OrderProcess.
---

## Notifications

- What was the problem?
Every time i want to add a new way to send notification, i must create 3 classes
one to send a normal notification,
one to send an Urgent notification,
one to send a Scheduled Urgent notification.

- What did you change?
I made an interface which all notification will implement it,
then i split the Urgent and scheduled into independent behaviours to make them reusable across all ways to notification.
---

## Proof

- New carrier file(s): yes
- New notification channel file(s): yes
- Existing classes left unchanged? (yes/no): yes
