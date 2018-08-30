-- 1. Query all the entries in the Genre table
SELECT Label FROM Genre;

SELECT * FROM Artist;

SELECT *
FROM Artist
WHERE ArtistName  = "Michael Jackson"
or ArtistName LIKE "Marv%";

-- 2. Using the INSERT statement, add one of your favorite artists to the Artist table.
INSERT INTO Artist VALUES (null, "Michael Jackson", 1965);

-- 3. Using the INSERT statement, add one, or more, albums by your artist to the Album table.
INSERT INTO Album
	select null, "Thriller", "November 30, 1982", SUBSTR(ABS(RANDOM())||'', 0, 5), r.RecordLabelId, a.ArtistId, g.GenreId
	from RecordLabel r, Artist a, Genre g where r.LabelName = "Epic" AND a.ArtistName = "Michael Jackson" and g.Label = "Pop";

-- 4. Using the INSERT statement, add some songs that are on that album to the Song table.
INSERT INTO Song 
	select null,
	"Billie Jean", 300, "January 2, 1983", g.GenreId, a.ArtistId, al.AlbumId
	from Genre g, Artist a, Album al where g.Label = "Pop" and a.ArtistName = "Michael Jackson" and al.Title = "Thriller";

INSERT INTO Song 
	select null,
	"Beat It", 255, "February 14, 1983", g.GenreId, a.ArtistId, al.AlbumId
	from Genre g, Artist a, Album al where g.Label = "Pop" and a.ArtistName = "Michael Jackson" and al.Title = "Thriller";

INSERT INTO Song 
	select null,
	"PYT", 289, "September 19, 1983", g.GenreId, a.ArtistId, al.AlbumId
	from Genre g, Artist a, Album al where g.Label = "Pop" and a.ArtistName = "Michael Jackson" and al.Title = "Thriller";

-- 5. Write a SELECT query that provides the song titles, album title, and artist name for all of the data you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, and the WHERE keyword to filter the results to the album and artist you added.
SELECT a.Title 'Album', s.Title 'Song', ar.ArtistName 'Artist'
FROM Album a
LEFT JOIN Song s ON s.AlbumId = a.AlbumId
LEFT JOIN Artist ar on a.ArtistId = ar.ArtistId
WHERE ar.ArtistName = "Michael Jackson";
--Removing "Left" from the join statement returns only albums that have song matches. When "Left" is present, preference is given to album and all albums are returned whether or not a song match is present.

SELECT a.Title as album, s.Title as song
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId;

-- 6. Using SELECT and LEFT JOIN, write a query that displays the song title, the song duration, the album label, and the genre name for every song.
SELECT s.Title, s.SongLength, r.LabelName, g.label 'Genre'
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId
LEFT JOIN RecordLabel r on a.RecordLabelId = r.RecordLabelId;

-- 7. Using a WHERE clause, modify the previous query to only show the information for songs that have a duration of 250 or greater.
SELECT s.Title, s.SongLength, r.LabelName, g.label 'Genre'
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId
left join RecordLabel r on a.RecordLabelId = r.RecordLabelId
WHERE s.SongLength > 250;


-- 8. Write a SELECT statement to display how many songs exist for each album. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
SELECT s.AlbumId, a.Title, COUNT(s.SongId)
FROM Song s
JOIN Album a on s.AlbumId = a.AlbumId
GROUP BY s.AlbumId;

-- 9. Write a SELECT statement to display how many songs exist for each artist. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
SELECT s.ArtistId, a.ArtistName, COUNT(s.SongId)
FROM Artist a
JOIN Song s on s.ArtistId = a.ArtistId
GROUP BY a.ArtistId;

-- 10. Write a SELECT statement to display how many songs exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
select g.Label 'Genre', count(s.SongId)
from Genre g
Left Join Song s on g.GenreId = s.GenreId
group by g.GenreId;

-- 11. Write a SELECT statement to display how many artists exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
select g.Label 'Genre', count(a.ArtistId)
from Genre g
Join Song s on g.GenreId = s.GenreId
Join Artist a on s.ArtistId = a.ArtistId
group by a.ArtistId;

-- 12. Using MAX() function, write a select statement to find the album with the longest duration. The result should display the album title and the duration.
SELECT a.Title, MAX(a.AlbumLength)
FROM Album a;

-- 13. Using MAX() function, write a select statement to find the song with the longest duration. The result should display the song title and the duration.
select s.Title, Max(s.SongLength)
from song s;

-- 14. Modify the previous query to also display the title of the album.
select s.Title, a.Title 'Album', Max(s.SongLength) 'Song Length'
from song s
join Album a on s.AlbumId = a.AlbumId;