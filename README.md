The logic is written in the Program.cs file.

The project was written using .Net 8. To start the program, run "dotnet run".

## Input

After starting the program, 3 inputs are required.

1. Number of rows
2. Number of columns
3. Space separated 0s and 1s, where each line is one row.

## Algorithm

The algorithm to find the islands iterates trough every entry one by one. If the entry is a '1', recursively finds neighbouring land pieces.

The output is the number of islands.
