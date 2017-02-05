# Shahzad-Ali
Instructions :
1.Enter the required details.
2.Select the format you wish to export
3.You will find the output file in local drive D.


How it works : 
This code solves only the Part A of the challenge. I have used C# language to create the console application. The first part of the code involves data input using simple ReadLine() and WriteLine() commands. A do while loop with a switch case has been used to select the type of output format.

Text File: 
A method text() is called from the case 1 statement of switch case to export the output into text format.This method simply creates a file of .txt extension in the local drive D (as i have mentioned in the code). The input data is written into the file and the file is closed in the end.

PDF File :
To convert into the pdf format, I made use of a third party PDF library 'iTextsharp'. For this i downloaded the libarary and copied the necessary .dll files into the same folder where my project was saved. Then from the solution explorer I added reference ( Visual basic express 2012: That's where i coded). After creating a pdf document using the PdfWriter command, the input data are copied into this pdf. The output pdf can be viewed in local drive D.




