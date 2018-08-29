-- 1. Query all the entries in the Genre table
SELECT Label FROM Genre;

SELECT * FROM Artist;

SELECT *
FROM Artist
WHERE ArtistName  = "Michael Jackson"
or ArtistName LIKE "Marv%";

-- 2. Using the INSERT statement, add one of your favorite artists to the Artist table.
INSERT INTO Artist VALUES (null, "Marvin Gaye", 1969);
INSERT INTO Artist VALUES (null, "Michael Jackson", 1965);

-- 3. Using the INSERT statement, add one, or more, albums by your artist to the Album table.
INSERT INTO Album VALUES (null, "Thriller", "November 30, 1982", 1, "Epic Records", 30, 7);

-- 4. Using the INSERT statement, add some songs that are on that album to the Song table.
INSERT INTO Song 
(Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES 
("Billie Jean", 5, "January 2, 1983", 6, 30, 23);

INSERT INTO Song 
(Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES 
("Beat It", 4, "February 14, 1983", 7, 30, 23);

INSERT INTO Song 
(Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES 
("PYT", 4, "September 19, 1983", 7, 30, 23);

-- 5. Write a SELECT query that provides the song titles, album title, and artist name for all of the data you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, and the WHERE keyword to filter the results to the album and artist you added.
SELECT a.Title, s.Title
FROM Album a
JOIN Song s ON s.AlbumId = a.AlbumId;
--Removing "Left" from the join statement returns only albums that have song matches. When "Left" is present, preference is given to album and all albums are returned whether or not a song match is present.

SELECT a.Title as album, s.Title as song
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId;

-- 6. Using SELECT and LEFT JOIN, write a query that displays the song title, the song duration, the album label, and the genre name for every song.
SELECT s.Title, s.SongLength, a.Label, g.label
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId;

-- 7. Using a WHERE clause, modify the previous query to only show the information for songs that have a duration of 250 or greater.
SELECT s.Title, s.SongLength, a.Label, g.label
FROM Song s
LEFT JOIN Album a ON s.AlbumId = a.AlbumId
LEFT JOIN Genre g ON s.GenreId = g.GenreId
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


-- 11. Write a SELECT statement to display how many artists exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence.

-- 12. Using MAX() function, write a select statement to find the album with the longest duration. The result should display the album title and the duration.
SELECT a.Title, MAX(a.AlbumLength)
FROM Album a;

-- 13. Using MAX() function, write a select statement to find the song with the longest duration. The result should display the song title and the duration.

-- 14. Modify the previous query to also display the title of the album.
