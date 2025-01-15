# NullReferenceException in C# Property Getter

This repository demonstrates a scenario where a seemingly innocuous C# property getter can lead to a `NullReferenceException`.  The problem arises when the property's backing field is not initialized and the property is used in an expression before its value has been set.

The `Bug.cs` file contains the problematic code, and `BugSolution.cs` offers a solution.