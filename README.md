# NullReferenceException in C#

This repository demonstrates a common C# error: the `NullReferenceException`.  The `bug.cs` file contains code that throws this exception. The `bugSolution.cs` file provides a corrected version that prevents the error.

## Problem

Accessing a member (property or method) of a null object results in a `NullReferenceException`. This happens frequently when an object isn't properly initialized before use.

## Solution

The solution typically involves either:

1. **Null Checks:**  Explicitly checking for null before accessing members.
2. **Default Values:** Initializing the object or member to a default value to avoid null.

This example shows both approaches to handle the issue effectively and robustly.