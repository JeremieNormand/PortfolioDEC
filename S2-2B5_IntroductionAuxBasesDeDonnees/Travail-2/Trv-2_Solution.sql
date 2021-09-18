-- Introduction aux bases de donnees

-- Travail Pratique 2

-- Jeremie Normand

----------------------------------------------------------------

-- Changement du format de date

ALTER SESSION SET NLS_DATE_FORMAT  = 'YYYY-MM-DD';

-- Initialisation des tables

DROP TABLE employe;

DROP TABLE departement;

CREATE TABLE departement
(
	dep_no      NUMBER(3)       CONSTRAINT pk_departement PRIMARY KEY
	                            CONSTRAINT ck_dep_no_dept CHECK (dep_no > 0),
	dep_nom     VARCHAR2(20)    CONSTRAINT nn_dep_nom_dept NOT NULL,
	site        VARCHAR2(20)    CONSTRAINT nn_site_dept NOT NULL
);

CREATE TABLE employe
(
	emp_no      NUMBER(4)       CONSTRAINT pk_employe PRIMARY KEY
	                            CONSTRAINT ck_emp_no_empl CHECK (emp_no >= 7000),
	emp_nom     VARCHAR2(25)    CONSTRAINT nn_emp_nom_empl NOT NULL,
	job         VARCHAR2(15),
	superv      NUMBER(4),
	engagement  DATE            DEFAULT SYSDATE,
	sal         NUMBER(9,2)     CONSTRAINT ck_sal_empl CHECK (sal > 0),
	comm        NUMBER(7,2),
	dep_no      NUMBER(3)       CONSTRAINT fk_dep_no_empl REFERENCES departement(dep_no)
);

-- Initialisation des sequences

DROP SEQUENCE seq_emp_no;

CREATE SEQUENCE seq_emp_no
	MINVALUE        7000
	MAXVALUE        9999
	START WITH      7000
	INCREMENT BY    5
;

DROP SEQUENCE seq_dep_no;

CREATE SEQUENCE seq_dep_no
	MINVALUE        10
	MAXVALUE        990
	START WITH      10
	INCREMENT BY    10
;

-- Insertion dans la table departement

INSERT INTO departement VALUES (seq_dep_no.NEXTVAL, 'Comptabilite', 'New York');
INSERT INTO departement VALUES (seq_dep_no.NEXTVAL, 'Recherche', 'Quebec');
INSERT INTO departement VALUES (seq_dep_no.NEXTVAL, 'Ventes', 'Los Angeles');
INSERT INTO departement VALUES (seq_dep_no.NEXTVAL, 'Ressources Hum', 'New York');

-- Insertion dans la table employe

INSERT INTO employe VALUES (7800, 'King', 'President', NULL, '1981-11-17', 500000, NULL, 10);
INSERT INTO employe VALUES (7810, 'Jones', 'Manager', 7800, '1981-04-02', 297500, NULL, 20);
INSERT INTO employe VALUES (7820, 'Blake', 'Manager', 7800, '1981-05-01', 385000, NULL, 40);
INSERT INTO employe VALUES (7830, 'Clark', 'Manager', 7800, '1981-06-09', 240500, NULL, 30);

INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Ford', 'Analyste', NULL, '1981-12-03', 30000, NULL, 20);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Smith', 'Secretaire', NULL, '1980-12-17', 28000, NULL, 40);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Allen', 'Vendeur', NULL, '1981-02-20', 56000, 3000.00, 30);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Ward', 'Vendeur', NULL, '1981-02-22', 42500, 5000.00, 30);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Martin', 'Vendeur', NULL, '1981-09-28', 12500, 1400.00, 30);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Scott', 'Analyste', NULL, '1985-04-27', 30000, NULL, 40);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Miller', 'Secretaire', NULL, '1981-01-23', 33000, NULL, 10);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Turner', 'Vendeur', NULL, '1981-09-08', 15000, 9999.00, 30);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'Adams', 'Secretaire', NULL, '1985-05-31', 21000, NULL, 20);
INSERT INTO employe VALUES (seq_emp_no.NEXTVAL, 'James', 'Secretaire', NULL, '1981-12-03', 39500, NULL, 30);

-- Mise a jour du champ superv

UPDATE employe SET superv=7810 WHERE dep_no=20 AND superv IS NULL;
UPDATE employe SET superv=7830 WHERE dep_no=30 AND superv IS NULL;
UPDATE employe SET superv=7820 WHERE dep_no=40 AND superv IS NULL;
UPDATE employe SET superv=7800 WHERE dep_no=10 AND superv IS NULL AND job <> 'President';

-- Sauvegarde de la base de donnees

COMMIT;

-- Affichage divers

SELECT emp_nom FROM employe WHERE sal IN (500000, 30000, 28000);
SELECT emp_nom FROM employe WHERE engagement BETWEEN '1981-01-01' AND '1981-08-01';
SELECT emp_nom FROM employe WHERE comm IS NOT NULL;
SELECT emp_nom FROM employe WHERE emp_nom LIKE 'Al%';
SELECT emp_nom FROM employe WHERE job LIKE '%a%' OR job LIKE '%A%';
SELECT emp_nom, CURRENT_DATE - engagement AS annees_embauche FROM employe WHERE sal < 50000;
SELECT emp_nom FROM employe WHERE emp_nom LIKE 'M%' AND NOT emp_nom LIKE '%r';
SELECT COUNT(emp_nom) FROM employe WHERE job = 'Vendeur';
SELECT SUM(comm) FROM employe;
SELECT COUNT(emp_nom) FROM employe WHERE superv = 7830;
SELECT MAX(sal) FROM employe WHERE job <> 'President';
SELECT SUM(sal) FROM employe WHERE emp_nom IN ('Jones', 'Smith', 'Clark', 'Scott');
SELECT emp_nom, dep_nom FROM employe, departement WHERE employe.dep_no = departement.dep_no;
SELECT emp_nom, site FROM employe, departement WHERE employe.dep_no = departement.dep_no;