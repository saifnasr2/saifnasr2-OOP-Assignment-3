# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n²)
- Time (ms) before: 24 ms
- What did you change?
I used HashSet instead of List in the CountBlocked method and in the BuildRequestId method and this allow faster check
- Time complexity after:O(n)
- Time (ms) after: 0 ms

---

## Students

- What was the problem?
when i call the method to get all student , in every time i call it it creates 1 million object so if i just want a number of students it will also creates 1 million object and this can be bad in lots of cases.
- What did you change?
I modified it to return IEnumerable<student> and used lazy evalution approach by using yield return.
