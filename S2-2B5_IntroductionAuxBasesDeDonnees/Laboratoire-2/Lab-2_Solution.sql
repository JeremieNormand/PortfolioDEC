SQL> create table CONTACT(
  2  Nom varchar2(30),
  3  Prenom varchar2(30),
  4  Sexe char,
  5  DateNais date,
  6  Ville varchar2(50),
  7  CodePostal varchar2(6),
  8  Telephone varchar2(10),
  9  Email varchar2(50),
 10  GenreContact char);

Table created.

SQL> alter table CONTACT add(Employeur varchar2(30));

Table altered.

SQL> alter table CONTACT modify(Nom varchar2(50));

Table altered.

SQL> alter table CONTACT rename column DateNais to date_Naissance;

Table altered.

SQL> desc CONTACT;
 Name                                      Null?    Type
 ----------------------------------------- -------- ----------------------------
 NOM                                                VARCHAR2(50)
 PRENOM                                             VARCHAR2(30)
 SEXE                                               CHAR(1)
 DATE_NAISSANCE                                     DATE
 VILLE                                              VARCHAR2(50)
 CODEPOSTAL                                         VARCHAR2(6)
 TELEPHONE                                          VARCHAR2(10)
 EMAIL                                              VARCHAR2(50)
 GENRECONTACT                                       CHAR(1)
 EMPLOYEUR                                          VARCHAR2(30)

SQL> alter session set NLS_DATE_FORMAT = 'YYYY-MM-DD';

Session altered.

SQL> insert into CONTACT values('Morin', 'Luce', 'F', '1956-12-20', 'Levis', 'G6V2B8', '4188335110', 'luce.morin@clevislauzon.qc.ca', 'P', 'Cegep Levis-Lauzon');

1 row created.

SQL> insert into CONTACT values('Tremblay', 'Marc', 'M', '1971-10-16', 'Quebec', 'G1L1A8', '4185138899', 'tremblaymarc01@hotmail.com', 'A', 'Etudiant');

1 row created.

SQL> insert into CONTACT values('Rioux', 'Pauline', 'F', '1975-12-23', 'Montmagny', 'G0R2B9', '5142222344', 'rixou.pauline@hotmail.com', 'P', 'Couche-Tard');

1 row created.

SQL> select from CONTACT
  2  ;
select from CONTACT
       *
ERROR at line 1:
ORA-00936: missing expression 


SQL> select from CONTACT;
select from CONTACT
       *
ERROR at line 1:
ORA-00936: missing expression 


SQL> select * from CONTACT;

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Morin                                                                           
Luce                           F 1956-12-20                                     
Levis                                              G6V2B8 4188335110            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
luce.morin@clevislauzon.qc.ca                      P                            
Cegep Levis-Lauzon                                                              
                                                                                

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Tremblay                                                                        
Marc                           M 1971-10-16                                     
Quebec                                             G1L1A8 4185138899            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
tremblaymarc01@hotmail.com                         A                            
Etudiant                                                                        
                                                                                

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Rioux                                                                           
Pauline                        F 1975-12-23                                     
Montmagny                                          G0R2B9 5142222344            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
rixou.pauline@hotmail.com                          P                            
Couche-Tard                                                                     
                                                                                

SQL> insert into CONTACT (Nom, Prenom, GenreContact) values ('Christian', 'Asselin', 'A');

1 row created.

SQL> insert into CONTACT (Nom, Prenom, GenreContact) values ('Stephane', 'Mercier', 'A');

1 row created.

SQL> insert into CONTACT values('Bello Maldonado', 'Wendolyne', 'F', '2001-01-10', 'Moncton', 'H1P2P8', '6789901234', 'w_bellomaldonado@sympatico.ca', 'P', 'Pecheries Ocean');

1 row created.

SQL> create table RV(
  2  DateRV date,
  3  NomRV varchar2(30),
  4  PrenomRV varchar2(30),
  5  LieuRV varchar2(30));

Table created.

SQL> alter table RV add(Sujet varchar2(30));

Table altered.

SQL> alter table RV modify(NomRV varchar2(50));

Table altered.

SQL> insert into RV values (to_date('2012-02-29 13:30','YYYY-MM-DD HH24:MI'),'Morin','Luce','Cegep','Cours d''analyse');

1 row created.

SQL> insert into RV values (to_date('2012-03-02 08:30','YYYY-MM-DD HH24:MI'),'Proulx','Julien','DFC','Emploi');

1 row created.

SQL> nsert into RV values (to_date('2013-01-01 17:30','YYYY-MM-DD HH24:MI'),'Savard','Sylvain','230des Lys','Nouvel an');
SP2-0734: unknown command beginning "nsert into..." - rest of line ignored.
SQL> insert into RV values (to_date('2013-01-01 17:30','YYYY-MM-DD HH24:MI'),'Savard','Sylvain','230des Lys','Nouvel an');

1 row created.

SQL> insert into RV values (to_date('2012-08-22 12:30','YYYY-MM-DD HH24:MI'),'St-Pierre','Julie','Maison','Ma fˆte');

1 row created.

SQL> insert into RV values (to_date('2012-03-12 13:30','YYYY-MM-DD HH24:MI'),'Morin','Luce','Cegep','Retraite');

1 row created.

SQL> select * from CONTACT where GenreContact='P';

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Morin                                                                           
Luce                           F 1956-12-20                                     
Levis                                              G6V2B8 4188335110            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
luce.morin@clevislauzon.qc.ca                      P                            
Cegep Levis-Lauzon                                                              
                                                                                

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Rioux                                                                           
Pauline                        F 1975-12-23                                     
Montmagny                                          G0R2B9 5142222344            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
rixou.pauline@hotmail.com                          P                            
Couche-Tard                                                                     
                                                                                

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
Bello Maldonado                                                                 
Wendolyne                      F 2001-01-10                                     
Moncton                                            H1P2P8 6789901234            

NOM                                                                             
--------------------------------------------------                              
PRENOM                         S DATE_NAISS                                     
------------------------------ - ----------                                     
VILLE                                              CODEPO TELEPHONE             
-------------------------------------------------- ------ ----------            
EMAIL                                              G                            
-------------------------------------------------- -                            
EMPLOYEUR                                                                       
------------------------------                                                  
w_bellomaldonado@sympatico.ca                      P                            
Pecheries Ocean                                                                 
                                                                                

SQL> select Nom, Prenom from CONTACT where GenreContact='A';

NOM                                                                             
--------------------------------------------------                              
PRENOM                                                                          
------------------------------                                                  
Tremblay                                                                        
Marc                                                                            
                                                                                
Christian                                                                       
Asselin                                                                         
                                                                                
Stephane                                                                        
Mercier                                                                         
                                                                                

SQL> select * from RV
  2  ;

DATERV     NOMRV                                                                
---------- --------------------------------------------------                   
PRENOMRV                       LIEURV                                           
------------------------------ ------------------------------                   
SUJET                                                                           
------------------------------                                                  
2012-02-29 Morin                                                                
Luce                           Cegep                                            
Cours d'analyse                                                                 
                                                                                
2012-03-02 Proulx                                                               
Julien                         DFC                                              
Emploi                                                                          

DATERV     NOMRV                                                                
---------- --------------------------------------------------                   
PRENOMRV                       LIEURV                                           
------------------------------ ------------------------------                   
SUJET                                                                           
------------------------------                                                  
                                                                                
2013-01-01 Savard                                                               
Sylvain                        230des Lys                                       
Nouvel an                                                                       
                                                                                
2012-08-22 St-Pierre                                                            
Julie                          Maison                                           

DATERV     NOMRV                                                                
---------- --------------------------------------------------                   
PRENOMRV                       LIEURV                                           
------------------------------ ------------------------------                   
SUJET                                                                           
------------------------------                                                  
Ma f?te                                                                         
                                                                                
2012-03-12 Morin                                                                
Luce                           Cegep                                            
Retraite                                                                        
                                                                                

SQL> select Upper(NomRV), PrenomRV, tochar(DateRV, 'yyyy/mm/dd hh24:mi') "Rendez-vous" from RV;
select Upper(NomRV), PrenomRV, tochar(DateRV, 'yyyy/mm/dd hh24:mi') "Rendez-vous" from RV
                               *
ERROR at line 1:
ORA-00904: "TOCHAR": invalid identifier 


SQL> select Upper(NomRV), PrenomRV, tochar(DateRV, 'yyyy/mm/dd hh24:mi') 'Rendez-vous' from RV;
select Upper(NomRV), PrenomRV, tochar(DateRV, 'yyyy/mm/dd hh24:mi') 'Rendez-vous' from RV
                                                                    *
ERROR at line 1:
ORA-00923: FROM keyword not found where expected 


SQL> select LieuRV from RV where NomRV='Morin' and PrenomRV='Luce';

LIEURV                                                                          
------------------------------                                                  
Cegep                                                                           
Cegep                                                                           

SQL> select count(*) from contact where GenreContact='P';

  COUNT(*)                                                                      
----------                                                                      
         3                                                                      

SQL> select nom, prenom, email from contact where email like '%@hotmail.com';

NOM                                                                             
--------------------------------------------------                              
PRENOM                                                                          
------------------------------                                                  
EMAIL                                                                           
--------------------------------------------------                              
Tremblay                                                                        
Marc                                                                            
tremblaymarc01@hotmail.com                                                      
                                                                                
Rioux                                                                           
Pauline                                                                         
rixou.pauline@hotmail.com                                                       

NOM                                                                             
--------------------------------------------------                              
PRENOM                                                                          
------------------------------                                                  
EMAIL                                                                           
--------------------------------------------------                              
                                                                                

SQL> select nom, prenom, floor((sysdaate - date_naissance)/365) as age from contact;
select nom, prenom, floor((sysdaate - date_naissance)/365) as age from contact
                           *
ERROR at line 1:
ORA-00904: "SYSDAATE": invalid identifier 


SQL> select nom, prenom, floor((sysdate - date_naissance)/365) as age from contact;

NOM                                                                             
--------------------------------------------------                              
PRENOM                                AGE                                       
------------------------------ ----------                                       
Morin                                                                           
Luce                                   64                                       
                                                                                
Tremblay                                                                        
Marc                                   49                                       
                                                                                
Rioux                                                                           
Pauline                                45                                       
                                                                                

NOM                                                                             
--------------------------------------------------                              
PRENOM                                AGE                                       
------------------------------ ----------                                       
Christian                                                                       
Asselin                                                                         
                                                                                
Stephane                                                                        
Mercier                                                                         
                                                                                
Bello Maldonado                                                                 
Wendolyne                              20                                       
                                                                                

6 rows selected.

SQL> select table_name from user_tables;

TABLE_NAME                                                                      
--------------------------------------------------------------------------------
CONTACT                                                                         
RV                                                                              

SQL> delete RV;

5 rows deleted.

SQL> select * from RV;

no rows selected

SQL> drop table RV;

Table dropped.

SQL> spool off
