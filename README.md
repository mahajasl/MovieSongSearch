# MovieSongSearch

---

## **Introduction**
This is our repository where we are committing a project which basically searches for movie names and songs when you search them on our website. 



## **Logo**
![Company Logo](/Movie & Music Logo.png)
## **StoryBoard**
![Home Page](https://github.com/mahajasl/XMLProject/blob/main/Slide1.PNG)

![Aircraft Type](https://github.com/mahajasl/XMLProject/blob/main/Slide2.PNG)

![Country](https://github.com/mahajasl/XMLProject/blob/main/Slide3.PNG)

![Landing Sites](https://github.com/mahajasl/XMLProject/blob/main/Slide4.PNG)

![Reviews](https://github.com/mahajasl/XMLProject/blob/main/Slide5.PNG)

![Landing Site Contacts](https://github.com/mahajasl/XMLProject/blob/main/Slide6.PNG)

## **Project Plan**

## **Requirements**
---
### 1) Search for Airports
#### Scenario
-	As a user looking to fly my aircraft from point A to point B, I want to be able to search for landing locations based on my type of aircraft and the country I am visiting so that I know where I can safely visit and what my flight plan will be.
#### Dependencies
- Country and landing sites are available
- Landing site list is maintained and accurate
#### Assumptions
-	Landing site names are in country language
-	Selections choices are driven off available data
-	Aircraft types are in English
-	Countries are in English
-	Airport coordinates map accurately to google maps

#### Examples
#### 1) Small airport search
**Given** I select small airport as my first selection

**When** I select 'Australia' for my country

**Then** I should get 
- a list of 1,559 airports where small airplanes can land in australia(Australia is mapped to AU from countrydataset and then for AU small airports will be filtered from airports dataset)
- the above locations (coordinates mentioned in airport dataset) plotted on a map of Australia from google maps api

#### 2) Seacraft landing site search
**Given** I select seacraft as my first selection

**When** I select 'United Kingdom' for my country(United Kingdom is mapped to GB from countrydataset and then for GB seacraft airports will be filtered from airports dataset)

**Then** I should get
- a list of 2 locations where seaplanes can land
- the above locations (coordinates mentioned in airport dataset) plotted on a map of United Kingdom from google maps api

#### 3) Balloon landing site search
**Given** I select balloon as my aircraft type

**When** I click 'choose my location'

**Then** I go to country I should only see United States, Denmark, France, United Kingdom, and Belize


#### 3) Data driven selections
**Given** My drop downs selections are driven off of data from the airport api

**When** I limit my aircraft landing type

**Then** My country choices should be limited to only countries with those aircraft landing types available

---
### 2) User add airport information ( this is the feature we will add on our database to collect customer information , it's not called from any APIs)
#### Scenario
-	As a user interested in flying all over the world, I want to be able to enter contact information for the various airports I visit, and add details like, conditions of the runway, easy of making arrangements, customer service, so that I know which landing locations to choose.

#### Dependencies
- We will use geolocation services to ensure the reviewer has visited the airport
- User has a device the has GPS capabilities and has granted location access

#### Assumptions
-	Comments can be translated from and to any language 
-	User adds information at the landing site (to verify location)
-	Information entered will be monitored to ensure accuracy


#### Examples
#### 1) User wants to add landing site contact information
**Given** the contact information for the airport is blank within the app

**When** 
- the user clicks update information
- the user adds the address, phone number, email, website 

**Then** the user goes back to search for the landing site, and contact information should be displayed

#### 1) User wants to update landing site contact information
**Given** the contact information is validated by our company

**When**  a customer wants to update contact information for a landing site

**Then** the customer should be directed to send the contact information to the company for review prior to update completion

#### 2) User wants to review the landing site
**Given** the user either has an image with the geolocation or is currently at the landing site and has location services turned on

**When** the user's location or image location is validated and they are allowed to continue to review the airport (star system), upload photos, and leave comments

**Then** when the user goes back to the home screen and searches for the airport, their review is visable

---
## **Data Feeds**
- [Airport Codes](https://datahub.io/core/airport-codes)
- [Country Names](https://datahub.io/core/country-list)
- [Google Maps](https://developers.google.com/maps/documentation/maps-static/start#Markers)

## **Team Composition**
- Christina Schwierling- integration developer
- Apruva Sriwastwa- integration developer
- Snehal Mahajan- Project Owner, integration developer
- Priyanka Nainani- fontend developer
- Krishnaja Pinnamaneni- frontend developer

## **Weekly Meetings**
We meet on Sunday at 7p over Microsoft teams to divide up the work and iron out details.

Then we have a weekly standup on Tuesday at from 6:10p - 6:20p to talk about progress and obstacles
