--------------------------------------------------------------------------------
-- Introduction aux bases de donnees
---- Travail Pratique 4 - Les Films du Plein Pays
------ Jeremie Normand
--------------------------------------------------------------------------------

---- Alteration du format de date

ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';

---- Suppression des entites

-- Suppression des sequences (occasione normalement des erreurs)

DROP SEQUENCE seq_films_film_id;
DROP SEQUENCE seq_realisateurs_realisateur_id;
DROP SEQUENCE seq_acteurs_acteur_id;
DROP SEQUENCE seq_genres_genre_id;

-- Suppression des tables (occasione normalement des erreurs)

DROP TABLE roles;
DROP TABLE acteurs;
DROP TABLE films;
DROP TABLE realisateurs;
DROP TABLE genres;

---- Creation des tables

CREATE TABLE genres
(
    genre_id  NUMBER(4),
    genre_nom VARCHAR2(32) CONSTRAINT nn_genres_genre_nom NOT NULL,
    CONSTRAINT pk_genres_genre_id PRIMARY KEY (genre_id)
);

CREATE TABLE acteurs
(
    acteur_id            NUMBER(4),
    acteur_nom           VARCHAR2(64) CONSTRAINT nn_acteurs_acteur_nom NOT NULL,
    acteur_prenom        VARCHAR2(64) CONSTRAINT nn_acteurs_acteur_prenom NOT NULL,
    acteur_sexe          VARCHAR2(1),
    acteur_dateNaissance DATE,
    acteur_nationalite   VARCHAR2(32),
    CONSTRAINT pk_acteurs_acteur_id PRIMARY KEY (acteur_id),
    CONSTRAINT ck_acteurs_acteur_sexe CHECK (acteur_sexe IN ('F', 'M'))
    
);

CREATE TABLE realisateurs
(
    realisateur_id     NUMBER(4),
    realisateur_nom    VARCHAR2(64) CONSTRAINT nn_realisateurs_realisateur_nom NOT NULL,
    realisateur_prenom VARCHAR2(64) CONSTRAINT nn_realisateurs_realisateur_prenom NOT NULL,
    genre_id           NUMBER(4),
    CONSTRAINT pk_realisateurs_realisateur_id PRIMARY KEY (realisateur_id),
    CONSTRAINT fk_realisateurs_genre_id FOREIGN KEY (genre_id) REFERENCES genres(genre_id)
);

CREATE TABLE films
(
    film_id           NUMBER(4),
    film_titre        VARCHAR2(256) CONSTRAINT nn_films_film_titre NOT NULL,
    film_duree        NUMBER(4),
    film_resume       VARCHAR2(512),
    film_dateParution DATE,
    film_affiche      VARCHAR2(128),
    genre_id          NUMBER(4),
    realisateur_id    NUMBER(4),
    CONSTRAINT pk_films_film_id PRIMARY KEY (film_id),
    CONSTRAINT fk_films_genre_id FOREIGN KEY (genre_id) REFERENCES genres(genre_id),
    CONSTRAINT fk_films_realisateur_id FOREIGN KEY (realisateur_id) REFERENCES realisateurs(realisateur_id)
);

CREATE TABLE roles
(
    film_id NUMBER(4),
    acteur_id NUMBER(4),
    role_nom VARCHAR2(64),
    CONSTRAINT pk_roles PRIMARY KEY (film_id, acteur_id),
    CONSTRAINT fk_roles_film_id FOREIGN KEY (film_id) REFERENCES films(film_id),
    CONSTRAINT fk_roles_acteur_id FOREIGN KEY (acteur_id) REFERENCES acteurs(acteur_id)
);

---- Creation des sequences

CREATE SEQUENCE seq_genres_genre_id
    MINVALUE     1
	MAXVALUE     999
	START WITH   1
	INCREMENT BY 1
;

CREATE SEQUENCE seq_acteurs_acteur_id
    MINVALUE     1
    MAXVALUE     999
    START WITH   1
    INCREMENT BY 1
;

CREATE SEQUENCE seq_realisateurs_realisateur_id
    MINVALUE     1
    MAXVALUE     999
    START WITH   1
    INCREMENT BY 1
;

CREATE SEQUENCE seq_films_film_id
    MINVALUE     1
    MAXVALUE     999
    START WITH   1
    INCREMENT BY 1
;    

---- Insertion des ensembles de donnees

-- Insertion dans la table genres

INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Comedy');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Drama');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Fantasy');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Family');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Sci-Fi');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Adventure');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Action');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Animation');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Documentary');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Stand-Up');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Crime');
INSERT INTO genres VALUES (seq_genres_genre_id.NEXTVAL, 'Biography');

-- Insertion dans la table realisateurs

INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Forster', 'Marc', 3);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Fincher', 'David', 2);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Spielberg', 'Steven', 6);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'DeBlois', 'Dean', 8);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Sanders', 'Chris', 8);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Mottola', 'Greg', 1);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Wright', 'Edgar', 7);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Miller', 'Tim', 1);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Burnett', 'Rob', 1);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Van Sant', 'Gus', 2);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Soderbergh', 'Steven', 2);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Snyder', 'Zack', 7);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Levy', 'Shawn', 7);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Selick', 'Henry', 3);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Burton', 'Tim', 3);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Fleischer', 'Ruben', 5);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Bird', 'Brad', 6);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Noer', 'Michael', 11);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Adamson', 'Andrew', 8);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Darabont', 'Frank', 2);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Emmerich', 'Roland', 7);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Sonnenfeld', 'Barry', 7);
INSERT INTO realisateurs VALUES (seq_realisateurs_realisateur_id.NEXTVAL, 'Coen', 'Joel', 1);

-- Insertion dans la table films

INSERT INTO films VALUES 
(
    seq_films_film_id.NEXTVAL,
    'Stranger Than Fiction',
    113,
    'I.R.S. auditor Harold Crick suddenly finds himself the subject of narration only he can hear: narration that begins to affect his entire life, from his work, to his love-interest, to his death.',
    CAST('2006-11-10' AS DATE),
    '2006_StrangerThanFiction.jpg',
    1,
    1
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Fight Club',
    139,
    'An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.',
    CAST('1999-10-15' AS DATE),
    '1999_FightClub.jpg',
    2,
    2
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'E.T. the Extra-Terrestrial',
    115,
    'A troubled child summons the courage to help a friendly alien escape Earth and return to his home world.',
    CAST('1982-06-11' AS DATE),
    '1982_ETTheExtraTerrestrial.jpg',
    5,
    3
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'How to Train Your Dragon',
    98,
    'A hapless young Viking who aspires to hunt dragons becomes the unlikely friend of a young dragon himself, and learns there may be more to the creatures than he assumed.',
    CAST('2010-03-26' AS DATE),
    '2010_HowToTrainYourDragon.jpg',
    8,
    4
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Superbad',
    113,
    'Two co-dependent high school seniors are forced to deal with separation anxiety after their plan to stage a booze-soaked party goes awry.',
    CAST('2007-08-17' AS DATE),
    '2007_Superbad.jpg',
    5,
    6
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Scott Pilgrim vs. the World',
    112,
    'In a magically realistic version of Toronto, a young man must defeat his new girlfriend''s seven evil exes one by one in order to win her heart.',
    CAST('2010-08-13' AS DATE),
    '2010_ScottPilgrimVSTheWorld.jpg',
    7,
    7
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Deadpool',
    108,
    'A wisecracking mercenary gets experimented on and becomes immortal but ugly, and sets out to track down the man who ruined his looks.',
    CAST('2016-02-12' AS DATE),
    '2016_Deadpool.jpg',
    1,
    8
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Fundamentals of Caring',
    97,
    'A man suffering a family loss enrolls in a class about care-giving that changes his perspective on life.',
    CAST('2016-06-24' AS DATE),
    '2016_TheFundamentalsOfCaring.jpg',
    1,
    9
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Good Will Hunting',
    126,
    'Will Hunting, a janitor at M.I.T., has a gift for mathematics, but needs help from a psychologist to find direction in his life.',
    CAST('1997-01-09' AS DATE),
    '1997_GoodWillHunting.jpg',
    2,
    10
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Contagion',
    106,
    'Healthcare professionals, government officials and everyday people find themselves in the midst of a pandemic as the CDC works to find a cure.',
    CAST('2011-09-09' AS DATE),
    '2011_Contagion.jpg',
    2,
    11
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Catch Me If You Can',
    141,
    'Barely 21 yet, Frank is a skilled forger who has passed as a doctor, lawyer and pilot. FBI agent Carl becomes obsessed with tracking down the con man, who only revels in the pursuit.',
    CAST('2003-01-02' AS DATE),
    '2003_CatchMeIfYouCan.jpg',
    11,
    3
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Man of Steel',
    143,
    'An alien child is evacuated from his dying world and sent to Earth to live among humans. His peace is threatened, when other survivors of his home planet invade Earth.',
    CAST('2013-06-14' AS DATE),
    '2013_ManOfSteel.jpg',
    5,
    12
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Real Steel',
    127,
    'In the near future, robot boxing is a top sport. A struggling ex-boxer feels he''s found a champion in a discarded robot.',
    CAST('2011-10-07' AS DATE),
    '2011_RealSteel.jpg',
    7,
    13
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Nightmare Before Christmas',
    76,
    'Jack Skellington, king of Halloween Town, discovers Christmas Town, but his attempts to bring Christmas to his home causes confusion.',
    CAST('1993-10-29' AS DATE),
    '1993_TheNightmareBeforeChristmas.jpg',
    8,
    14
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Edward Scissorhands',
    105,
    'An artificial man, who was incompletely constructed and has scissors for hands, leads a solitary life. Then one day, a suburban lady meets him and introduces him to her world.',
    CAST('1990-12-14' AS DATE),
    '1990_EdwardScissorhands.jpg',
    2,
    15
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Venom',
    112,
    'A failed reporter is bonded to an alien entity, one of many symbiotes who have invaded Earth. But the being takes a liking to Earth and decides to protect it.',
    CAST('2018-10-05' AS DATE),
    '2018_Venom.jpg',
    5,
    16
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    '300',
    117,
    'King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.',
    CAST('2006-03-09' AS DATE),
    '2006_300.jpg',
    7,
    12
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Iron Giant',
    86,
    'A young boy befriends a giant robot from outer space that a paranoid government agent wants to destroy.',
    CAST('1999-08-06' AS DATE),
    '1999_TheIronGiant.jpg',
    8,
    17
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Incredibles',
    115,
    'A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.',
    CAST('2004-11-05' AS DATE),
    '2004_TheIncredibles.jpg',
    8,
    17
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Papillon',
    133,
    'Wrongfully convicted for murder, Henri Charriere forms an unlikely relationship with fellow inmate and quirky convicted counterfeiter Louis Dega, in an attempt to escape from the notorious penal colony on Devil''s Island.',
    CAST('2017-08-24' AS DATE),
    '2017_Papillon.jpg',
    12,
    18
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Shrek',
    90,
    'A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.',
    CAST('2001-07-17' AS DATE),
    '2001_Shrek.jpg',
    6,
    19
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Shawshank Redemption',
    142,
    'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.',
    CAST('1994-10-14' AS DATE),
    '1994_TheShawshankRedemption.jpg',
    2,
    20
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Independence Day',
    145,
    'The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind''s best weapon is the will to survive.',
    CAST('1996-07-02' AS DATE),
    '1996_IndependenceDay.jpg',
    7,
    21
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'Men in Black',
    98,
    'A police officer joins a secret organization that polices and monitors extraterrestrial interactions on Earth.',
    CAST('1997-07-02' AS DATE),
    '1997_MenInBlack.jpg',
    5,
    22
);
INSERT INTO films VALUES
(
    seq_films_film_id.NEXTVAL,
    'The Big Lebowski',
    117,
    'Jeff "The Dude" Lebowski, mistaken for a millionaire of the same name, seeks restitution for his ruined rug and enlists his bowling buddies to help get it.',
    CAST('1998-03-06' AS DATE),
    '1998_TheBigLebowski.jpg',
    1,
    23
);

-- Insertion dans la table acteurs

INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Ferrell', 'Will', 'M', CAST('1967-07-16' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Thompson', 'Emma', 'F', CAST('1959-04-15' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hoffman', 'Dustin', 'M', CAST('1937-08-08' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Gyllenhaal', 'Maggie', 'F', CAST('1977-11-16' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Latifah', 'Queen', 'F', CAST('1970-03-18' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hale', 'Tony', 'M', CAST('1970-09-30' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hunt', 'Linda', 'F', CAST('1945-04-02' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Pitt', 'Brad', 'M', CAST('1963-12-18' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Norton', 'Edward', 'M', CAST('1969-08-18' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Bonham Carter', 'Helena', 'F', CAST('1966-05-26' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Leto', 'Jared', 'M', CAST('1971-12-26' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Loaf', 'Meat', 'M', CAST('1947-09-27' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Thomas', 'Henry', 'M', CAST('1971-09-09' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Barrymore', 'Drew', 'F', CAST('1975-02-22' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Wallace', 'Dee', 'F', CAST('1948-12-14' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'MacNaughton', 'Robert', 'M', CAST('1966-12-19' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Baruchel', 'Jay', 'M', CAST('1982-04-09' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Ferrera', 'America', 'F', CAST('1984-04-18' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Butler', 'Gerard', 'M', CAST('1969-11-13' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Mintz-Plasse', 'Christopher', 'M', CAST('1989-06-20' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hill', 'Jonah', 'M', CAST('1983-12-20' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Cera', 'Michael', 'M', CAST('1988-06-07' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Rogen', 'Seth', 'M', CAST('1982-04-15' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Elizabeth Winstead', 'Mary', 'F', CAST('1984-11-28' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Culkin', 'Kieran', 'M', CAST('1982-09-30' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Simmons', 'Johnny', 'M', CAST('1986-11-28' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Reynolds', 'Ryan', 'M', CAST('1976-10-23' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Miller', 'T.J.', 'M', CAST('1981-06-04' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Baccarin', 'Morena', 'F', CAST('1979-06-02' AS DATE), 'Brazil');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Rudd', 'Paul', 'M', CAST('1969-04-06' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Roberts', 'Craig', 'M', CAST('1991-01-21' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Gomez', 'Selena', 'F', CAST('1992-07-22' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Damon', 'Matt', 'M', CAST('1970-10-08' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Affleck', 'Ben', 'M', CAST('1972-08-15' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Williams', 'Robin', 'M', CAST('1951-07-21' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Driver', 'Minnie', 'F', CAST('1970-01-31' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Affleck', 'Casey', 'M', CAST('1975-08-12' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Skarsgard', 'Stellan', 'M', CAST('1951-06-13' AS DATE), 'Sweden');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Fishburne', 'Laurence', 'M', CAST('1961-07-30' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Law', 'Jude', 'M', CAST('1972-12-29' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Paltrow', 'Gwyneth', 'F', CAST('1972-09-27' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'DiCaprio', 'Leonardo', 'M', CAST('1974-11-11' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hanks', 'Tom', 'M', CAST('1956-07-09' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Walken', 'Christopher', 'M', CAST('1943-03-31' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Adams', 'Amy', 'F', CAST('1974-08-20' AS DATE), 'Italy');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Cavill', 'Henry', 'M', CAST('1983-05-05' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Shannon', 'Michael', 'M', CAST('1974-08-07' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Crowe', 'Russell', 'M', CAST('1964-04-07' AS DATE), 'New-Zealand');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Jackman', 'Hugh', 'M', CAST('1968-10-12' AS DATE), 'Australia');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Goyo', 'Dakota', 'M', CAST('1999-08-22' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Lilly', 'Evangeline', 'F', CAST('1979-08-03' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Durand', 'Kevin', 'M', CAST('1974-01-14' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Mackie', 'Anthony', 'M', CAST('1978-09-23' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Burton', 'Tim', 'M', CAST('1958-08-25' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Elfman', 'Danny', 'M', CAST('1953-05-29' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'O''Hara', 'Catherine', 'F', CAST('1954-03-04' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Sarandon', 'Chris', 'M', CAST('1942-07-24' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Depp', 'Johnny', 'M', CAST('1963-06-09' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Ryder', 'Winona', 'F', CAST('1971-10-29' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Arkin', 'Alan', 'M', CAST('1934-03-26' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hardy', 'Tom', 'M', CAST('1977-09-15' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Ahmed', 'Riz', 'M', CAST('1982-12-01' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Slate', 'Jenny', 'F', CAST('1982-03-25' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Headey', 'Lena', 'F', CAST('1973-10-03' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Fassbender', 'Michael', 'M', CAST('1977-04-02' AS DATE), 'Germany');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Diesel', 'Vin', 'M', CAST('1967-07-18' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Marienthal', 'Eli', 'M', CAST('1986-03-06' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Aniston', 'Jennifer', 'F', CAST('1969-02-11' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Connick Jr.', 'Harry', 'M', CAST('1967-09-11' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'McDonald', 'Christopher', 'M', CAST('1955-02-15' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Bird', 'Brad', 'M', CAST('1957-09-24' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hunter', 'Holly', 'F', CAST('1958-03-20' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'T. Nelson', 'Craig', 'M', CAST('1944-04-04' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'L. Jackson', 'Samuel', 'M', CAST('1948-12-21' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Hunnam', 'Charlie', 'M', CAST('1980-04-10' AS DATE), 'UK');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Malek', 'Rami', 'M', CAST('1981-05-12' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Myers', 'Mike', 'M', CAST('1963-05-25' AS DATE), 'Canada');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Murphy', 'Eddie', 'M', CAST('1961-04-03' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Diaz', 'Cameron', 'F', CAST('1972-08-30' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Freeman', 'Morgan', 'M', CAST('1937-06-01' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Robbins', 'Tim', 'M', CAST('1958-10-16' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Smith', 'Will', 'M', CAST('1968-09-25' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Goldblum', 'Jeff', 'M', CAST('1952-10-22' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Pullman', 'Bill', 'M', CAST('1953-12-17' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Lee Jones', 'Tommy', 'M', CAST('1946-09-15' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Torn', 'Rip', 'M', CAST('1931-02-06' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Bridges', 'Jeff', 'M', CAST('1949-12-04' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Goodman', 'John', 'M', CAST('1952-06-20' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Buscemi', 'Steve', 'M', CAST('1957-12-13' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Moore', 'Julianne', 'F', CAST('1960-12-03' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Turturro', 'John', 'M', CAST('1957-02-28' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Seymour Hoffman', 'Philip', 'M', CAST('1967-07-23' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Elliott', 'Sam', 'M', CAST('1944-08-09' AS DATE), 'USA');
INSERT INTO acteurs VALUES (seq_acteurs_acteur_id.NEXTVAL, 'Pratt', 'Chris', 'M', CAST('1979-06-21' AS DATE), 'USA');

-- Insertion dans la table roles

INSERT INTO roles VALUES (1, 1, 'Harold Crick');
INSERT INTO roles VALUES (1, 2, 'Karen Eiffeil');
INSERT INTO roles VALUES (1, 3, 'Prof. Jules Hilbert');
INSERT INTO roles VALUES (1, 4, 'Ana Pascal');
INSERT INTO roles VALUES (1, 5, 'Penny Escher');
INSERT INTO roles VALUES (1, 6, 'Dave');
INSERT INTO roles VALUES (1, 7, 'Dr. Mittag-Leffler');
INSERT INTO roles VALUES (2, 8, 'Tyler Durden');
INSERT INTO roles VALUES (2, 9, 'The Narrator');
INSERT INTO roles VALUES (2, 10, 'Maria Singer');
INSERT INTO roles VALUES (2, 11, 'Angel Face');
INSERT INTO roles VALUES (2, 12, 'Robert ''Bob'' Paulson');
INSERT INTO roles VALUES (3, 13, 'Elliott');
INSERT INTO roles VALUES (3, 14, 'Gertie');
INSERT INTO roles VALUES (3, 15, 'Mary');
INSERT INTO roles VALUES (3, 16, 'Micheal');
INSERT INTO roles VALUES (4, 17, 'Hiccup');
INSERT INTO roles VALUES (4, 18, 'Astrid Hofferson');
INSERT INTO roles VALUES (4, 19, 'Stoick the Vast');
INSERT INTO roles VALUES (4, 20, 'Fishlegs');
INSERT INTO roles VALUES (5, 21, 'Seth');
INSERT INTO roles VALUES (5, 22, 'Evan');
INSERT INTO roles VALUES (5, 23, 'Officer Michaels');
INSERT INTO roles VALUES (5, 20, 'Fishlegs');
INSERT INTO roles VALUES (6, 22, 'Scott Pilgrim');
INSERT INTO roles VALUES (6, 24, 'Ramona Flowers');
INSERT INTO roles VALUES (6, 25, 'Wallace Wells');
INSERT INTO roles VALUES (6, 26, 'Neil');
INSERT INTO roles VALUES (7, 27, 'Deadpool');
INSERT INTO roles VALUES (7, 28, 'Weasel');
INSERT INTO roles VALUES (7, 29, 'Vanessa');
INSERT INTO roles VALUES (8, 30, 'Ben');
INSERT INTO roles VALUES (8, 31, 'Trevor');
INSERT INTO roles VALUES (8, 32, 'Dot');
INSERT INTO roles VALUES (9, 33, 'Will Hunting');
INSERT INTO roles VALUES (9, 34, 'Chuckie Sullivan');
INSERT INTO roles VALUES (9, 35, 'Sean Maguire');
INSERT INTO roles VALUES (9, 36, 'Skylar');
INSERT INTO roles VALUES (9, 37, 'Morgan O''Mally');
INSERT INTO roles VALUES (9, 38, 'Prof. Gerald Lambeau');
INSERT INTO roles VALUES (10, 33, 'Mitch Emhoff');
INSERT INTO roles VALUES (10, 39, 'Dr. Ellis Cheever');
INSERT INTO roles VALUES (10, 40, 'Alan Krumwiede');
INSERT INTO roles VALUES (10, 41, 'Beth Emhoff');
INSERT INTO roles VALUES (11, 42, 'Frank Abagnale Jr.');
INSERT INTO roles VALUES (11, 43, 'Carl Hanratty');
INSERT INTO roles VALUES (11, 44, 'Frank Abagnale, Sr.');
INSERT INTO roles VALUES (11, 45, 'Brenda Strong');
INSERT INTO roles VALUES (12, 39, 'Perry White');
INSERT INTO roles VALUES (12, 45, 'Lois Lane');
INSERT INTO roles VALUES (12, 46, 'Superman');
INSERT INTO roles VALUES (12, 47, 'General Zod');
INSERT INTO roles VALUES (12, 48, 'Jor-El');
INSERT INTO roles VALUES (13, 49, 'Charlie Kenton');
INSERT INTO roles VALUES (13, 50, 'Max Kenton');
INSERT INTO roles VALUES (13, 51, 'Balley Tallet');
INSERT INTO roles VALUES (13, 52, 'Ricky');
INSERT INTO roles VALUES (13, 53, 'Finn');
INSERT INTO roles VALUES (14, 54, 'Zero');
INSERT INTO roles VALUES (14, 55, 'Clown');
INSERT INTO roles VALUES (14, 56, 'Sally');
INSERT INTO roles VALUES (14, 57, 'Jack Skellington');
INSERT INTO roles VALUES (15, 58, 'Edward Scissorhands');
INSERT INTO roles VALUES (15, 59, 'Kim');
INSERT INTO roles VALUES (15, 60, 'Bill');
INSERT INTO roles VALUES (16, 61, 'Eddie Brock');
INSERT INTO roles VALUES (16, 62, 'Carlton Drake');
INSERT INTO roles VALUES (16, 63, 'Dora Skirth');
INSERT INTO roles VALUES (17, 19, 'Leonidas I');
INSERT INTO roles VALUES (17, 64, 'Gorgo');
INSERT INTO roles VALUES (17, 65, 'Stellos');
INSERT INTO roles VALUES (18, 66, 'The Iron Giant');
INSERT INTO roles VALUES (18, 67, 'Hogarth Hughes');
INSERT INTO roles VALUES (18, 68, 'Annie Hughes');
INSERT INTO roles VALUES (18, 69, 'Dean McCoppin');
INSERT INTO roles VALUES (18, 70, 'Kent Mansley');
INSERT INTO roles VALUES (19, 71, 'Edna Mode');
INSERT INTO roles VALUES (19, 72, 'Elastigirl');
INSERT INTO roles VALUES (19, 73, 'Mr. Incredible');
INSERT INTO roles VALUES (19, 74, 'Frozone');
INSERT INTO roles VALUES (20, 75, 'Henri Papillon Charriere');
INSERT INTO roles VALUES (20, 76, 'Louis Dega');
INSERT INTO roles VALUES (21, 77, 'Shrek');
INSERT INTO roles VALUES (21, 78, 'Donkey');
INSERT INTO roles VALUES (21, 79, 'Princess Fiona');
INSERT INTO roles VALUES (22, 80, 'Ellis Boyd Redding');
INSERT INTO roles VALUES (22, 81, 'Andy Dufresne');
INSERT INTO roles VALUES (23, 82, 'Captain Steven Hiller');
INSERT INTO roles VALUES (23, 83, 'David Levinson');
INSERT INTO roles VALUES (23, 84, 'President Thomas J. Whitmore');
INSERT INTO roles VALUES (24, 82, 'Agent J');
INSERT INTO roles VALUES (24, 85, 'Agent K');
INSERT INTO roles VALUES (24, 86, 'Agent Zed');
INSERT INTO roles VALUES (25, 87, 'The Dude');
INSERT INTO roles VALUES (25, 88, 'Walter Sobchak');
INSERT INTO roles VALUES (25, 89, 'Theodore Donald Kerabatsos');
INSERT INTO roles VALUES (25, 90, 'Maude Lebowski');
INSERT INTO roles VALUES (25, 91, 'Jesus Quintana');
INSERT INTO roles VALUES (25, 92, 'Brandt');
INSERT INTO roles VALUES (25, 93, 'The Stranger');