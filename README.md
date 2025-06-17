Program 1

Write a C# program that asks the user to enter multiple lines of text (until they type "STOP"). Save these lines into a file named "output.txt". Then, read and display the contents of the file. Implement proper exception handling to catch potential errors (e.g., file access issues).

Program 2 

Write a program that takes a list of integers from the user and performs the following operations using LINQ:
a) Find all numbers greater than 50
b) Sort the numbers in ascending order
c) Find the square of each number

Program 3

Create a program that allows the user to store student records using a dictionary. Each student should have:
ID (integer, unique)
Name (string)
Your program should allow the user to:
a) Add a new student.
b) Remove a student by ID.
c) Display all students.

Program 4

Simulate an online order processing system using async programming. Your program should:
a) Ask the user for an order name.
b) Display "Processing order..."
c) Wait 3 seconds (to simulate processing time).
d) Display "Order for [item] is ready!"
Use async and await to make the processing non-blocking.

Program 5

Write a program to write 10MB of data to multiple files as per the procedure mentioned below:
Write 10MB of binary data in blocks of 50kB byte array
The above should be replicated for 100 files i.e. after execution, the program should have created 100 number 10MB files.
After completion of writing to each single file, the program should output the following message on console "<Filename> Writing Completed"
Execute the above program in a single thread and also multiple threads/tasks using async/await programming. Make sure that the UI thread is not blocked.
Note the time taken for execution of the program in single task and multiple tasks
