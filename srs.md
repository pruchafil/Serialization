# System Requirements Specifications

* 1 [Introduction](#1-introduction)
  * 1.1 [Purpose](#11-introduction)
  * 1.2 [Document Conventions](#12-document-conventions)
  * 1.3 [Intended Audience](#13-intended-audience)
  * 1.4 [Project Scope](#14-project-scope)
  * 1.5 [References](#15-references)
* 2 [Overall Description](#2-overall-description)
  * 2.1 [Product Perspective](#21-product-perspective)
  * 2.2 [Product Functions](#22-product-functions)
  * 2.3 [User Classes and Characteristics](#23-user-classes-and-characteristics)
  * 2.4 [Operating Environment](#24-operating-environment)
  * 2.5 [Design and Implementation Constraints](#25-design-and-implementation-constraints)
  * 2.6 [Assumptions and Dependencies](#26-assumptions-and-dependencies)
* 3 [External Interface Requirements](#3-external-interface-requirements)
  * 3.1 [User Interfaces](#31-user-interfaces)
  * 3.2 [Hardware Interfaces](#32-hardware-interfaces)
  * 3.3 [Software Interfaces](#33-software-interfaces)
* 4 [System Features](#4-system-features)
  * 4.1 [Functional Requirements](#41-functional-requirments)

## 1. Introduction
### 1.1 Purpose

The purpose of this document is to develop software to retrieve information about objects tracked by NASA that could be potentially dangerous to Earth.

### 1.2 Document Conventions

`This message will be displayed on your mobile phone screen.`

### 1.3 Intended Audience

This project is suitable for all people who are interested in potentially dangerous space objects for planet Earth and need to track some information about them.

### 1.4 Project Scope

Účel tohoto softwaru je poskytnout přehledné a jednoduché vyhledávání pravidělně aktualizovaných informací o vesmírných objektech, které by mohly být potencionálně pro Zemi nebezpečné. Software umožňuje zobrazit přehledně formátované informace pro celkové zobrazení či vyhledávat konkrétní klíčová slova.

### 1.5 References

https://github.com/pruchafil/Serialization

https://api.nasa.gov/

## 2. Overall Description
### 2.1 Product Perspective

The software stores information about space objects. It stores their number, ID, Neo reference ID, name, magnitude, an estimate of the object's diameter, whether the object is potentially dangerous, close approach data and minor additional information. It also stores information about the regularity of data updates and the selected colour display mode (dark or light mode). All data is stored in JSON format.

### 2.2 Product Functions

The main functionality of the program is to enter a letter input into a text field. This letter input will then be used when searching for information about objects in written form. When a text input is entered, the result found will automatically be displayed below the text box.

### 2.3 User Classes and Characteristics

There is no need to split users into groups, they will all have the same permissions.

### 2.4 Operating Environment

Mobile phone with Android operation system.

### 2.5 Design and Implementation Constraints

For file storage, it is necessary to store these files in JSON format in a specific location that Android supports.

### 2.6 Assumptions and Dependencies

It is assumed that the user will have a phone powerful enough to handle more demanding search results. It is also assumed that the user will have access to an internet connection.

## 3. External Interface Requirements
### 3.1 User Interfaces

Jednoduché rozložení, jehož hlavní složka je textové pole pro uživatelský vstup a textové pole pro zobrazení výsledků hledání, jež uživatel zadal do prvního pole. V horní části je ikona zubatého kola pro zobrazení dalších možností, ve kterých je možnost nastavit světlý nebo tmavý režim zobrazení, četnost aktualizací, manuální aktualizaci a zobrazení všech informací v dobře čitelném formátu.

### 3.2 Hardware Interfaces

N/A

### 3.3 Software Interfaces

N/A

## 4. System Features
### 4.1 Functional Requirments

#### 4.1.1 Text Input

Purpose:

Information lookup.

Inputs:

Input is via the on-screen keyboard.

Processing:

The input is stored and used as a search argument. The search attempts to find any mention of the current input and retrieves all objects that have that mention.

Outputs:

All objects that have been marked as correct by the search via a mention from user input. These objects are listed in a formatted text layout that can be scrolled through for a broader list.

#### 4.1.2 Dark and light mode switching

Purpose:

A better and more pleasant view.

Inputs:

Button click.

Processing:

Clicking the button switches the mode and saves this information for future application launches.

Outputs:

Button is checked or unchecked. Background colour.

#### 4.1.3 Auto update switch

Purpose:

Provide updated information.

Inputs:

Button click.

Processing:

Clicking the button switches the mode and saves this information for future application launches. All information will be updated every time the application is launched.

Outputs:

Button is checked or unchecked.

#### 4.1.4 Force update

Purpose:

Provide updated information.

Inputs:

Button click.

Processing:

Clicking the button will update all the information.

Outputs:

`Updated` or `Failed`

#### 4.1.5 Show information

Purpose:
Data structure display.

Inputs:
Button click.

Processing:
The entire JSON file will be read, parsed into data structures and converted to text.

Outputs:
All objects are listed in a formatted text layout that can be scrolled through for a broader list.
