# MovieSongSearch

---

## **Introduction**
The purpose of this application is to provide users with various options to keep them away from boredom. We enable users to search for movies and music.
They will be able to search for any movie title and read it's brief description based on which they can decide to watch the movie or search for alternatives. We also provide users with the option to search for soundtracks in the movies they watched. Additionally,they can search for various songs and artists. 

Some of the new features we are planning for the next iterations are to collect user inputs and provide them with recommendations which will keep them entertained at all times.

## **Logo**
![Company Logo](https://github.com/mahajasl/MovieSongSearch/blob/main/CompanyLogo.PNG)

## **StoryBoard**
![Home Page](https://github.com/mahajasl/MovieSongSearch/blob/main/MovieSongSearch/MovieSongSearch/wwwroot/mss3.png)
![Movie Search](https://github.com/mahajasl/MovieSongSearch/blob/main/MovieSongSearch/MovieSongSearch/wwwroot/mss2.png)
![Song Search](https://github.com/mahajasl/MovieSongSearch/blob/main/MovieSongSearch/MovieSongSearch/wwwroot/mss1.png)

## **Project Plan**

## **Requirements**
1) Search for Movies and Music
## **Scenario**
-As a user seeking an interesting movie to watch, I would like to have a place where I can go and read a brief description of the plot which would help me make an informed choice.
-Additionally, I may want to be able to search for a soundtrack that I just heard while watching the movie. This platform allows you to not just search for movies but soundtracks of your favorite composers as well.
## **Dependencies**
-Music library and movie library are available.
-MovieSongSearch site list is maintained and accurate.
## **Assumptions**
-Songs/Soundtrack searches are in English
-Search Results are driven off available data.
-Movie description is in English.
-Song searches includes external links.
-Song searches include artist, genre,track and collection name.

## **Examples**

#### 1) **Movie Search**

**Given** I type the name of a movie in the search bar.

**Then** I should get a list of movies containing the typed keywords along with the date of release and description.

#### 2)**Music Search using movie title**

**Given** I type the title of the movie in the search bar.

**Then** I should get a list of soundtracks from the movie.

#### 3) **Music Search using artist's name.**

**Given** I type the name of the artist in the search bar.

**Then** I get a list of soundtracks composed by the artist.

---
**2)User added music/movie interests( this is the feature we will add in our database to collect customer information. It's not called from any API's)**
**Scenario**
-As a user interested in receiving movie and music reccomendations of my favorite artists, I want to be able to enter information regarding my interests so that I can get a customized experience.

**Dependancies**
-We will gather user-entered information and provide the best reccomendations possible.

**Assumptions**
-Reccomendations will be provided in various genres.
-Reccomendations will be provided for various artists who are similiar.

## **Data Feeds**
- [Movies](https://api.themoviedb.org/3/search/movie?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US)
- [Music](https://itunes.apple.com/search)


## **Team Composition**
- Christina Schwierling- frontend developer
- Apruva Sriwastwa- integration developer
- Snehal Mahajan- Project Owner, integration developer
- Priyanka Nainani- fontend developer
- Krishnaja Pinnamaneni- frontend developer

## **Weekly Meetings**
We meet on Sunday at 7p over Microsoft teams to divide up the work and iron out details.

Then we have a weekly standup on Tuesday at from 6:10p - 6:20p to talk about progress and obstacles
