/* Jeremie Normand */

SQL> CREATE TABLE employe
  2  (
  3  	emp_no		NUMBER(4),
  4  	emp_nom		VARCHAR2(15),
  5  	job		VARCHAR2(15),
  6  	superviseur	NUMBER(4),
  7  	date_embauche	DATE,
  8  	salaire		NUMBER(8,2),
  9  	commission	NUMBER(6,2),
 10  	dep_no		CHAR(3)
 11  );

Table created.

SQL> ALTER TABLE employe ADD code_postal CHAR(6);

Table altered.

SQL> ALTER TABLE employe MODIFY emp_nom VARCHAR2(50);

Table altered.

SQL> ALTER TABLE employe RENAME COLUMN date_embauche TO embauche;

Table altered.

SQL> DESCRIBE employe
 Name                                      Null?    Type
 ----------------------------------------- -------- ----------------------------
 EMP_NO                                             NUMBER(4)
 EMP_NOM                                            VARCHAR2(50)
 JOB                                                VARCHAR2(15)
 SUPERVISEUR                                        NUMBER(4)
 EMBAUCHE                                           DATE
 SALAIRE                                            NUMBER(8,2)
 COMMISSION                                         NUMBER(6,2)
 DEP_NO                                             CHAR(3)
 CODE_POSTAL                                        CHAR(6)

SQL> ALTER TABLE employe DROP COLUMN commission;

Table altered.

SQL> ALTER TABLE employe RENAME TO employes;

Table altered.

SQL> ALTER TABLE employes ADD (emp_prenom VARCHAR2(50), ville VARCHAR2(30));

Table altered.

SQL> DESCRIBE employes
 Name                                      Null?    Type
 ----------------------------------------- -------- ----------------------------
 EMP_NO                                             NUMBER(4)
 EMP_NOM                                            VARCHAR2(50)
 JOB                                                VARCHAR2(15)
 SUPERVISEUR                                        NUMBER(4)
 EMBAUCHE                                           DATE
 SALAIRE                                            NUMBER(8,2)
 DEP_NO                                             CHAR(3)
 CODE_POSTAL                                        CHAR(6)
 EMP_PRENOM                                         VARCHAR2(50)
 VILLE                                              VARCHAR2(30)

SQL> INSERT INTO employes VALUES (7893, 'King', 'President', NULL, '2013-01-21', 286574.55, 'OPE', 'G6SJ8R', 'James', 'Levis');

1 row created.

SQL> INSERT INTO employes VALUES (7566, 'Jones', 'Manager', 1893, '2014-01-25', 123456.00, 'CPT', 'G6D9K9', 'Bob', 'Quebec');

1 row created.

SQL> INSERT INTO employes VALUES (7902, 'Ford', 'Analyste', 7566, '2014-08-24', 75259.85, 'CPT', 'G6D8F9', 'Tom', 'Levis');

1 row created.

SQL> SELECT * FROM employes;

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7893 King                                               President         
            2013-01-21  286574.55 OPE G6SJ8R                                    
James                                                                           
Levis                                                                           
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7566 Jones                                              Manager           
       1893 2014-01-25     123456 CPT G6D9K9                                    
Bob                                                                             
Quebec                                                                          
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7902 Ford                                               Analyste          
       7566 2014-08-24   75259.85 CPT G6D8F9                                    
Tom                                                                             
Levis                                                                           
                                                                                

SQL> INSERT INTO employes (emp_no, emp_nom, job, salaire) VALUES (7845, 'Chabot', 'Programmeur', 65699.00);

1 row created.

SQL> INSERT INTO employes VALUES (7902, 'Ford', 'Vendeur', 7566, '2021-02-15', 75000.00, 'VTE', 'G6D6G6', 'Tom', 'Levis');

1 row created.

SQL> UPDATE employes SET emp_no=7707 WHERE job='Vendeur';

1 row updated.

SQL> UPDATE employes SET superviseur=7902, dep_no='INF' WHERE emp_no=7845;

1 row updated.

SQL> INSERT INTO employes (emp_no, emp_nom, job, superviseur, embauche, dep_no, code_postal, emp_prenom, ville) VALUES (7369, 'Smith', 'Secretaire', 7902, '2015-10-03', 'OPE', NULL, 'Julia', NULL);

1 row created.

SQL> INSERT INTO employes (emp_no, emp_nom, job, superviseur, embauche, dep_no, code_postal, emp_prenom, ville) VALUES (7698, 'Blake', 'Manager', 7893, '2021-02-15', 'INF', NULL, 'Tom', NULL);

1 row created.

SQL> SELECT * FROM employes;

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7893 King                                               President         
            2013-01-21  286574.55 OPE G6SJ8R                                    
James                                                                           
Levis                                                                           
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7566 Jones                                              Manager           
       1893 2014-01-25     123456 CPT G6D9K9                                    
Bob                                                                             
Quebec                                                                          
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7902 Ford                                               Analyste          
       7566 2014-08-24   75259.85 CPT G6D8F9                                    
Tom                                                                             
Levis                                                                           
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7845 Chabot                                             Programmeur       
       7902                 65699 INF                                           
                                                                                
                                                                                
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7707 Ford                                               Vendeur           
       7566 2021-02-15      75000 VTE G6D6G6                                    
Tom                                                                             
Levis                                                                           
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7369 Smith                                              Secretaire        
       7902 2015-10-03            OPE                                           
Julia                                                                           
                                                                                
                                                                                

    EMP_NO EMP_NOM                                            JOB               
---------- -------------------------------------------------- ---------------   
SUPERVISEUR EMBAUCHE      SALAIRE DEP CODE_P                                    
----------- ---------- ---------- --- ------                                    
EMP_PRENOM                                                                      
--------------------------------------------------                              
VILLE                                                                           
------------------------------                                                  
      7698 Blake                                              Manager           
       7893 2021-02-15            INF                                           
Tom                                                                             
                                                                                
                                                                                

7 rows selected.

SQL> SELECT emp_no, emp_nom, emp_prenom FROM employes;

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                                                      
--------------------------------------------------                              
      7893 King                                                                 
James                                                                           
                                                                                
      7566 Jones                                                                
Bob                                                                             
                                                                                
      7902 Ford                                                                 
Tom                                                                             
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                                                      
--------------------------------------------------                              
      7845 Chabot                                                               
                                                                                
                                                                                
      7707 Ford                                                                 
Tom                                                                             
                                                                                
      7369 Smith                                                                
Julia                                                                           
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                                                      
--------------------------------------------------                              
      7698 Blake                                                                
Tom                                                                             
                                                                                

7 rows selected.

SQL> SELECT emp_no, emp_nom, emp_prenom, superviseur FROM employes;

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         SUPERVISEUR                  
-------------------------------------------------- -----------                  
      7893 King                                                                 
James                                                                           
                                                                                
      7566 Jones                                                                
Bob                                                       1893                  
                                                                                
      7902 Ford                                                                 
Tom                                                       7566                  
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         SUPERVISEUR                  
-------------------------------------------------- -----------                  
      7845 Chabot                                                               
                                                          7902                  
                                                                                
      7707 Ford                                                                 
Tom                                                       7566                  
                                                                                
      7369 Smith                                                                
Julia                                                     7902                  
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         SUPERVISEUR                  
-------------------------------------------------- -----------                  
      7698 Blake                                                                
Tom                                                       7893                  
                                                                                

7 rows selected.

SQL> SELECT UPPER(emp_nom), emp_prenom, embauche FROM employes;

UPPER(EMP_NOM)                                                                  
--------------------------------------------------                              
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
KING                                                                            
James                                              2013-01-21                   
                                                                                
JONES                                                                           
Bob                                                2014-01-25                   
                                                                                
FORD                                                                            
Tom                                                2014-08-24                   
                                                                                

UPPER(EMP_NOM)                                                                  
--------------------------------------------------                              
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
CHABOT                                                                          
                                                                                
                                                                                
FORD                                                                            
Tom                                                2021-02-15                   
                                                                                
SMITH                                                                           
Julia                                              2015-10-03                   
                                                                                

UPPER(EMP_NOM)                                                                  
--------------------------------------------------                              
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
BLAKE                                                                           
Tom                                                2021-02-15                   
                                                                                

7 rows selected.

SQL> SELECT emp_no, emp_nom, emp_prenom, '2021-02-15' - embauche FROM employes;
SELECT emp_no, emp_nom, emp_prenom, '2021-02-15' - embauche FROM employes
                                    *
ERROR at line 1:
ORA-00932: inconsistent datatypes: expected CHAR got DATE 


SQL> SELECT emp_no, emp_nom, emp_prenom, embauche FROM employes;

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
      7893 King                                                                 
James                                              2013-01-21                   
                                                                                
      7566 Jones                                                                
Bob                                                2014-01-25                   
                                                                                
      7902 Ford                                                                 
Tom                                                2014-08-24                   
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
      7845 Chabot                                                               
                                                                                
                                                                                
      7707 Ford                                                                 
Tom                                                2021-02-15                   
                                                                                
      7369 Smith                                                                
Julia                                              2015-10-03                   
                                                                                

    EMP_NO EMP_NOM                                                              
---------- --------------------------------------------------                   
EMP_PRENOM                                         EMBAUCHE                     
-------------------------------------------------- ----------                   
      7698 Blake                                                                
Tom                                                2021-02-15                   
                                                                                

7 rows selected.

SQL> SELECT COUNT(emp_no) FROM employes;

COUNT(EMP_NO)                                                                   
-------------                                                                   
            7                                                                   

SQL> SELECT SUM(salaire) FROM employes;

SUM(SALAIRE)                                                                    
------------                                                                    
    625989.4                                                                    

SQL> SELECT MAX(salaire) FROM employes;

MAX(SALAIRE)                                                                    
------------                                                                    
   286574.55                                                                    

SQL> SELECT MIN(salaire) FROM employes;

MIN(SALAIRE)                                                                    
------------                                                                    
       65699                                                                    

SQL> SELECT DISTINCT(superviseur) FROM employes;

SUPERVISEUR                                                                     
-----------                                                                     
                                                                                
       1893                                                                     
       7893                                                                     
       7902                                                                     
       7566                                                                     

SQL> SELECT emp_no FROM employes WHERE emp_nom='Ford';

    EMP_NO                                                                      
----------                                                                      
      7902                                                                      
      7707                                                                      

SQL> SELECT emp_prenom, emp_nom FROM employes WHERE superviseur='7893';

EMP_PRENOM                                                                      
--------------------------------------------------                              
EMP_NOM                                                                         
--------------------------------------------------                              
Tom                                                                             
Blake                                                                           
                                                                                

SQL> SELECT emp_prenom, emp_nom FROM employes WHERE dep_no='OPE';

EMP_PRENOM                                                                      
--------------------------------------------------                              
EMP_NOM                                                                         
--------------------------------------------------                              
James                                                                           
King                                                                            
                                                                                
Julia                                                                           
Smith                                                                           
                                                                                

SQL> SELECT emp_prenom, emp_nom FROM employes WHERE code_postal IS NULL;

EMP_PRENOM                                                                      
--------------------------------------------------                              
EMP_NOM                                                                         
--------------------------------------------------                              
                                                                                
Chabot                                                                          
                                                                                
Julia                                                                           
Smith                                                                           
                                                                                
Tom                                                                             
Blake                                                                           
                                                                                

SQL> SELECT emp_prenom, emp_nom FROM employes WHERE ville IS NOT NULL;

EMP_PRENOM                                                                      
--------------------------------------------------                              
EMP_NOM                                                                         
--------------------------------------------------                              
James                                                                           
King                                                                            
                                                                                
Bob                                                                             
Jones                                                                           
                                                                                
Tom                                                                             
Ford                                                                            
                                                                                

EMP_PRENOM                                                                      
--------------------------------------------------                              
EMP_NOM                                                                         
--------------------------------------------------                              
Tom                                                                             
Ford                                                                            
                                                                                

SQL> SELECT table_name FROM user_tables;

TABLE_NAME                                                                      
--------------------------------------------------------------------------------
CONTACT                                                                         
EMPLOYES                                                                        

SQL> DELETE FROM employes;

7 rows deleted.

SQL> DROP TABLE employes;

Table dropped.

SQL> SPOOL OFF
