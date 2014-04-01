FacebookDesktopApp
==================

Facebook Desktop Application

The Facebook Desktop Application is a project created in 2012 during a Design Patterns class I attended. The project was created by my friend Oriel Belzer and myself.

The main focus in this project is using design patterns describe thier class diagram and use cases.

Some of the Design Patterns implemented in the project:

1. Singleton
2. Strategy
3. Adapter
4. Observer
5. Iterator

Key features:

1.	Status search:  The feature gives the user the ability to search a text in his friend's status posts. 
  The feature give the Facebook Application user 2 options : 
  a.	Search text in all user friends. 
  b.	Search text in a specific user/s that the Facebook Application user is choosing to search in.

2.	Album downloader: The feature gives the user the ability to download his own picture albums that he has in his Facebook account.  Using this feature the user can save all album pictures locally to his computer. 

3.	Post statuses: The feature gives the user the ability to post statuses on his friends walls in Facebook. 
  The feature give the user 3 options to choose from:
  a.	Post status on all friends walls. 
  b.	Post status on a specific chosen friend.
  c.	Post status on all friends that have birthday at the same date.

4.	Smart login: The feature gives the user the ability to perform a smart login which is a login that will perform some actions on the user's behalf. 
  The actions that this feature gives are : 
  a.	Post a status on the user's wall according to the time of the day.
  b.	Post a "happy birthday" status on all the user's friends that has birthday at the same day.

Multithreaded was not a focus point in the project but it was implemented at the status search feature. You may experience some delays reflected by the implementation of the FacebookAPI given by the professor.

In order to run the project you will have to create a new facebook application here: https://developers.facebook.com/apps and copy the appID to "private const string k_AppID = "";" at FacebookAppLogic.cs

