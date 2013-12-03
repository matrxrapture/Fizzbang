What is expected in this test
-----------------------------
This test measures your JavaScript knowledge and application.

The system you need implement has the following requirements:
1)	Allow the user to search last.fm for artists based on artist name
2)	Display the search results in a list
3)	Allow the user to select artists from the search results and add artists to their list of favourite artists

*	In the screenshots folder there are screenshots of the expected functionality

How to search for artists using last.fm API
-------------------------------------------
To search for artists based on name you need to invoke the last.fm API. More information about the last.fm API can be found here http://www.last.fm/api/show/artist.search. The documentation also include sample API calls. Basically you need to call the following URL to get search results

http://ws.audioscrobbler.com/2.0/?method=artist.search&artist=<artist_name>&api_key=18fe148b510a9409923195592727d7d8&format=json

where <artist_name> is the search criteria entered by the user.

*	Please make sure you use the following API key 18fe148b510a9409923195592727d7d8.


