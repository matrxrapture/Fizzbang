/// <reference path="typings/jquery/jquery.d.ts"/>

$(document).ready(function () {

	eventHandlers.seachButton_Click();
	eventHandlers.addfavouriteArtist();
});

var eventHandlers = {
				seachButton_Click: function () {
		$('#search-button').click(function () {
			searchArtist();
		});
				},
				addfavouriteArtist: function () {
		$('#artist-list').on("click", ".addto", function (event) {
			event.preventDefault();
			console.info('add favoutite has been fired');
			var favouriteArtist = $(event.target).attr('data-artistname');
			$('#my-search-list').append('<li>' + favouriteArtist + '</li>');
		});
				}
};

function searchArtist() {
				var artist_name = $('#q').val();
				$.ajax(
		{
			method: "GET",
			url: 'http://ws.audioscrobbler.com/2.0/?method=artist.search&artist=' + artist_name + '&api_key=18fe148b510a9409923195592727d7d8&format=json',
			success: function (result) {
				if (result) {
					var artists = result.results.artistmatches.artist;
					$.each(artists, function (index, singleArtist) {
						if (singleArtist.name.length > 30) {
							singleArtist.name = singleArtist.name.substring(0, 26) + "<span class='viewMore'>...</span>";
						}

						$('#artist-list').append('<li><a href="#" class="addto" data-ArtistName="' + singleArtist.name + '">add to list  </a><span>' + singleArtist.name + '</span></li>');

					});
				}
				else {

					$('#artist-list').append("<span > No Results</span>");
				}

			},
			failure: function () {

				$('#artist-list').append("<span > Could not establish connecttion to last.fm</span>");

			}
		}
		);
}
