# Functional Specification

* 1 [Introduction](#1-introduction)
  * 1.1 [Purpose](#11-purpose)
  * 1.2 [Document Conventions](#12-document-conventions)
  * 1.3 [For whom the document is intended](#13-for-whom-the-document-is-intended)
  * 1.4 [References](#15-references)
* 2 [Scenarios](#2-scenarios)
  * 2.1 [all-realistic-uses](#21-all-realistic-uses)
  * 2.2 [Types of user roles](#22-types-of-user-roles)
  * 2.3 [Scoping - what will not be in the software](#23-scoping---what-will-not-be-in-the-software)
  * 2.4 [What will not be emphasized (performance)](#24-what-will-not-be-emphasized-performance)
* 3 [Overall gross Architecture](#3-overall-gross-architecture)
  * 3.1 [Workflow](#31-workflow)
  * 3.2 [Main modules](#32-main-modules)
  * 3.3 [All the details: screens, windows, prints, error messages, logging](#33-all-the-details-screens-windows-prints-error-messages-logging)
  * 3.4 [All possible program flows and their manifestations](#34-all-possible-program-flows-and-their-manifestations)
  * 3.5 [All agreed principles](#35-all-agreed-principles)

## 1. Introduction
### 1.1 Purpose

The purpose of this document is to develop software to retrieve information about objects tracked by NASA that could be potentially dangerous to Earth.

### 1.2 Document Conventions

`This message will be displayed on your mobile phone screen.`
```
This is an example
```

### 1.3 For whom the document is intended

This document is intended primarily for anyone either involved in or interested in the development of this project.

### 1.4 References

https://github.com/pruchafil/Serialization

https://api.nasa.gov/

https://github.com/pruchafil/Serialization/blob/master/srs.md

## 2. Scenarios
### 2.1 All realistic uses

The main use of this software is to retrieve updated information about space objects from the NASA API. This information can be filtered.

### 2.2 Types of user roles

There is no need to split users into groups, they will all have the same permissions.

### 2.3 Scoping - what will not be in the software

Although the application shows all the data, it does not directly show the data structure for storing the JSON file in which this information is stored. The application cannot automatically update the information at runtime, the request for an update at runtime must be confirmed explicitly in the gear icon.

### 2.4 What will not be emphasized (performance)

Information retrieval could theoretically be very slow if there are many elements in the file storing the data. If there was an overload of data about dangerous bodies for planet Earth, slow loading of the program would probably be the least of your worries.

## 3. Overall gross Architecture
### 3.1 Workflow

When the application is launched, the data will be updated depending on whether this option is enabled (by default it is enabled) and whether there is an internet connection. When the application is launched, the main layout will be displayed, which includes a text box into which the search phrase will be entered. Each time you type into the text box, the search result will be updated. The result is displayed in another text box located below the input field. Once clicked, there is an option to set the updates and display mode, force the update and display the data in a readable format.

### 3.2 Main modules

The application has three main modules: the main search module, the settings module and the data display module.

### 3.3 All the details: screens, windows, prints, error messages, logging

If an error occurs during the update, an `Failed` is displayed on the screen. If there is a success, `Updated` is displayed on the screen.

### 3.4 All possible program flows and their manifestations

One flow of the program is to automatically run the update when the program starts and then display the search layout. The other flow is an error for this update, whereby the update will be skipped and work with outdated data. The last option is similar to the second, whereby this update will be skipped altogether.

### 3.5 All agreed principles

Wand writing will be used.

The data is stored in a JSON file.

The data representation is in the following format:

```
Information:
(
    MoreInformation: MoreInformation:
    (
        (
            IsA: true
        );
        (
            B: The too-yellow horse whinnied devilish odes.
        )
    )
)
```
