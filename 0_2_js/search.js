/// <reference path="typings/jquery/jquery.d.ts"/>

	


$(document).ready(function() {
alert('tedst1');
	$('#search-button').click(function () {
		SearchArtist();
	});
});

function SearchArtist() 
{
	var artist_name = $('#search-button').val();
	$.ajax(
		{
		method: "GET",
		url:'http://ws.audioscrobbler.com/2.0/?method=artist.search&artist='+ artist_name+ '&api_key=18fe148b510a9409923195592727d7d8&format=json',
		success:function (result) {
			if (result) {
				$.each(function (element, Index) {
					$('#artist-list').append('<li><a href="#" data-ArtistName="' + element + '">Add To List ' + element + '</a></li>');

				});
			}

		}}
		);
}
		