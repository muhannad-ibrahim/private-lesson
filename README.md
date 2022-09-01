# Private Lesson Application
This program was developed to help teachers to CURD the data of their students and follow up them.

Developed By: -
Muhannad Ibrahim Taha 


Graduated from Computer Science, Math. Department, Faculty of Science, Ain Shams University, Cairo - Egypt.

Contact: 
https://www.linkedin.com/in/muhannad-ibrahim 

## To install the program 

* First you have to download the setup file that is uploaded to the repo with name Private Lesson.
* run the setup file and install the program on your machine.
* download sqlLocalDB and install it on your machine from 
          "https://download.microsoft.com/download/f/a/8/fa83d147-63d1-449c-b22d-5fef9bd5bb46/SQLServer2016-SSEI-Expr.exe"

## CONTENTS

1.	Project Specification
2.	Requirements Gathering and Analysis
3.	Technology on which SW project carried out
4.	Process model adapted for SW project development 
5.	Data dictionary
6.	System architecture


## 1- Project Specification
1- Description
The Project “Private lesson” job is to help teachers to follow up their students by entering their data and the outlay for each month, result of their exams for each month and the attendance for each lecture.


2- Objectives
The project objective is to successfully place all student data, their payments and results of each exam and show all data related to the student at his profile.




## 2- Requirements Gathering and Analysis

1-	 The Project is a custom requirement to help teachers to follow up their students quickly.

2-	 Meet up with the customer to fetch his requirement and map it to features.

3-	 Searching for other existing systems to get more ideas for the implementation.

4-	 Draw a simple user interface and meet up with customer to see if he has any updates.

5-	Start to design the UI and developed the app.




## 3- Technology on which SW project carried out
1.	 C# 
Which is the basic language used to build our application using the environment visual studio (at least version 2015). 
2.	 Sql server 
Recommend to use Microsoft SQL Server Express Edition (64-bit) version 15.0.2000 RTM.
3.	 Git source control
a.	 Host: GitHub.
b.	 Desktop client GitHub.




## 4- Process model adapted for SW project development 
I worked through the application using the AGILE method as the following:

•	First, I decided to use the click up application for planning, assigning tasks and know what features need to be done.

•	Designed the database for the application.

•	Designed the UI of the application. 

•	The App features were split into 3 sprints each sprint process was (Analysis=>UI/UX Design Script Prototype on Paint=>Implement the features=>Test & Fix=>Close Tasks).

•	Sprint period varied depending on features
First Sprint (Entering the data): -
The sprint aimed to finish features related to entering data like student data, places, groups, attendance, payments and exams. 
		Second sprint (fetching data) 
Trying to design models on the input data to fetch tehm from the DB and test its efficiency when representing it on the UI.
		Third sprint (representing the data)
After fetching has been done. We represent the UI with a profile for each student to show his essential data and the data related to his exams, attendance and payments.




## 5- Data dictionary
The database contains 6 essential tables which is Student, Place, Groups, Exam, Payment and Attendance.

And, you can view the relationship model (ER model) from the following:

![image](https://user-images.githubusercontent.com/39066284/187081728-aabb2569-fafd-48e8-9e81-aad2ad1d50aa.png)




## 6- System architecture 
The system uses MVC design pattern as Windows Form Application Projects done by C# has a great and ready to go base code to follow the MVC Pattern as it generates the View and Starter Controller code automatically.
### Models(M): -
There is almost a model for each table that contains its own data members and functions that directly communicate with the database to fetch the required data.

![image](https://user-images.githubusercontent.com/39066284/187081761-2d517c45-5374-461b-97d9-fc803fba12b8.png)

Model (A) can communicate with Model (B) in the background if Model (A) has a relationship with Model (B)


### View (V): -
  The App is developed using visual studio which offers a drag and drop Windows Form Designer tool which generates its view code 
  
![image](https://user-images.githubusercontent.com/39066284/187081777-f1ee3ac7-3ed7-4465-a40b-aefa29411509.png)
![image](https://user-images.githubusercontent.com/39066284/187081784-e91b8307-9b37-4bab-8fbd-86984551bcf8.png)


### Controller (C): -
A starter code is also generated with each form then all event handlers like (OnMouseClick, and OnValueChanged) are added to the controller.

![image](https://user-images.githubusercontent.com/39066284/187081790-6205b2c5-1864-4dd0-84b5-c16a551b13ef.png)


