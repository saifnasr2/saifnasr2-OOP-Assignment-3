## What is the same between two stores, and what is different?
- The Two stores' methods are completely in similar , the difference just that course store stores courses and student store stores students.

## Step 3
- The Compile Error: 'type' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'type' could be found (are you missing a using directive or an assembly reference?).
- The reason: The compile doesn't know if T has an id or not.

## Step 7
- The new Store<string> not compiled because string doesnot implement IHasId whic is the constraint of the store<T>

## What is the common name for the kind of class you built in Steps 4 and 5?
- It is a generic class with a constrained type parameter.