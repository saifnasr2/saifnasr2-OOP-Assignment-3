###  Research: IReadOnlyDictionary & SortedDictionary
## IReadOnlyDictionary
- It is an interface which you can use it to expose dictionary data.
- It is different from Dictonary, because it isn't modifiable, it just exposes dictionary's data.
you can return it over dictionary in the public method if you need to prevent the caller to from modifying its data

## SortedDictionary
- It is a Dictionary, but it automatically keeps its entries sorted.
- It is different from the Dictionary in ordering the data which dictionary doesn't gurantee the data will be sorted but this keeps the data sorted.
- The Dictionary's lookup speed is O(1) but this is O(log n) , because this uses the binary search in the modifying like: Add, Remove, Search.
- You can use it if you want to keep your Dictionary sorted.

### Task 2.2 — Pick the Collection
## Find a student by national ID — thousands of times a day.
- Dictionary
- 1- Because it is very fast in lookup.
  2- Because its keys' value must be unique.  

## Keep the tags of a course. The same tag must never be stored twice.
- HashSet
- Because it prevents duplication.

## Keep a student's grades in the order they were entered. The same grade can appear more than once.
- List
- Because it keeps the entries as they were entered, allows duplication.
## A public method returns the course price list. Callers can read prices but must not add or change any.
- IReadOnlyList
- Because it prevents the callers from doing any change on it.

## A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order.
- Sorted Dictionary
- Because it keeps its entries sorted.
## A method returns results that the caller only loops over once — and may stop early.
- IEnumerable
- Because the lazy execution with yield return needs IEnumerable as a return type for the method.