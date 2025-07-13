# Factorial Calculator

This simpple project calculate facotrial using tread safely

---

# How to Run

1. Open the code in **Visual Studio** or visual studio Code

2. Make sure the project is targeting **.NET Core**, **.NET 6**, or **.NET 7**.

3. Press **Run** or use the terminal to execute the program.

   You should see factorial results printed to the console.

4. There's a `Thread.Sleep(1000)` at the end of the code.  
   This is just to give all threads enough time to finish before the program exits.
The program takes an array of numbers:

```csharp
int[] numbers = { 4, 3, 1 };
