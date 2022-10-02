# System Requirements Specifications

* 1 [Introduction](#1-introduction)
  * 1.1 [Purpose](#11-introduction)
  * 1.2 [Document Conventions](#12-document-conventions)
  * 1.3 [Intended Audience](#13-intended-audience)
  * 1.4 [Project Scope](#14-project-scope)
  * 1.5 [References](#15-references)
* 2 [Overall Description](#2-overall-descriptionn)
  * 2.1 [Product Perspective](#21-product-perspective)
  * 2.2 [Product Functions](#22-product-functions)
  * 2.3 [User Classes and Characteristics](#23-user-classes-and-characteristics)
  * 2.4 [Operating Environment](#24-operating-environment)
  * 2.5 [Design and Implementation Constraints](#25-design-and-implementation-constraints)
  * 2.6 [Assumptions and Dependencies](#26-assumptions-and-dependencies)
* 3 [External Interface Requirements](#30-external-interface-requirements)
  * 3.1 [User Interfaces](#31-user-interfaces)
  * 3.2 [Hardware Interfaces](#32-hardware-interfaces)
  * 3.3 [Software Interfaces](#33-software-interfaces)
  * 3.4 [Communication Interfaces](#34-communication-interfaces)
* 4 [System Features](#4-system-features)
  * 4.1 [Functional Requirements](#41-functional-requirements)
* 5 [Nonfunctional Requirements](#5-nonfunctional-requirements)
  * 5.1 [Performance Requirements](#51-performance-requirements)
  * 5.2 [Safety Requirements](#52-safety-requirements)
  * 5.3 [Security Requirements](#53-security-requirements)
  * 5.4 [Software Quality Attributes](#54-software-quality-attributes)

## 1. Introduction
### 1.1 Purpose

The purpose of this document is to develop software to retrieve information about objects tracked by NASA that could be potentially dangerous to Earth.

### 1.2 Document Conventions


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


### 2.6 Assumptions and Dependencies
## 3. External Interface Requirements
### 3.1 User Interfaces
### 3.2 Hardware Interfaces
### 3.3 Software Interfaces
### 3.4 Communication Interfaces
## 4. System Features
### 4.1 Functional Requirments
## 5. Nonfunctional Requirements
### 5.1 Performance Requirements
### 5.2 Safety Requirements
### 5.3 Security Requirements
### 5.4 Software Quality Attributes
