# Technical Test Instructions for Mobile Developer Role

## Overview
This technical test evaluates your skills in mobile development using Kotlin for Android and backend development using C# with ASP.NET 8. The test consists of two tasks, each focusing on one of these areas. Your solutions will be assessed based on:

- Functionality: Does the application meet the specified requirements?
- Code quality: Is the code readable and well-structured?

As the time is limited we do not expect a perfect solution.  Do the best you can in the time allocated and see how far you can get.  If you finish the tasks quickly you can expand the solution by adding the ability to search on additional fields and/or unit tests.


## Task 1: Android App Development with Kotlin

### Objective
Create an Android application that displays a list of cruises and allows users to filter the list by cruise name or embarkation port.

### Requirements

Data Source:

Use the data provided in android/data/eu2025.json from the repository.
The JSON file contains a list of cruises with details such as cruise name, embarkation port, start date, and other relevant information.


### User Interface:

Create a single-screen application that displays a list of cruises.

For each cruise, display the following fields:

- Cruise Name
- Embarkation Port
- Start Date

Ensure the list is scrollable if the number of cruises exceeds the screen height.


### Search Functionality:

Implement a search field at the top of the screen.
Allow users to filter the displayed cruises by entering text that matches either the Cruise Name or Embarkation Port (case-insensitive).
Update the list dynamically as the user types, showing only cruises that match the search query.
If the search field is empty, display all cruises.


### Technical Requirements:

Use Kotlin as the programming language.


### Deliverables:

Place your Android project in the android folder of the repository.



## Task 2: ASP.NET 8 Backend Development with C#

### Objective
Modify an existing ASP.NET 8 project to implement a search function for filtering by cruise name or embarkation port.

### Requirements

Project Setup:

The ASP.NET 8 project is located in the aspnet/TestTestAspNet folder of the repository.
The data source is the same as the android project and is located in aspnet/TechTestAspNet/Data, however
the loading and display is already implemented for you.


### Controller and View Modifications:

Modify the HomeController and associate view file to implement the same search as in the Android project

### Technical Requirements:

Please do the search logic on the server side

Deliverables:

Update the existing ASP.NET project in the aspnet/TestTestAspNet folder.



## Submission Instructions

Once you have made your changes please push to a new branch of the repo and let your contact know you are done.


## Notes

- If you don't have the ability to dev ASP.NET locally we can provide a VM for you to log into
- If you encounter issues accessing the repository or data file, please notify us immediately.
- You may use third-party libraries or frameworks
- The test is designed to take approximately 1.5 - 2 hours

Good luck, and we look forward to reviewing your submission!
