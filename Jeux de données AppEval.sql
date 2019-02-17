-- OFFRE_EMPLOI --
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES('1','Administrateur Réseau', '2019-09-09');
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES('2','Chef de Projet', '2019-09-09');
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES('3','Développeur Web', '2019-09-09');


-- DONNEES CRITERE --
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('Personnalité et attitude', 2, '1');
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('Expérience', 5, '3');
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('Disponibilité', 1, '1');
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('Formation ou détention d  diplôme', 10, '2');

-- Requête trouver dans BDD AppEval.sql --
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('tenue', 5, '1');
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('competences', 2, '1');


-- Requête trouver dans BDD AppEval.sql --
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES('4', 'testOffre', '2018-09-09');

-- Requête trouver dans BDD AppEval.sql --
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES('5', 'testOffre', '2018-09-09');

-- RH --
INSERT INTO RH(idRh, loginRh, password, statut)
VALUES(1, 'testDRH', 'testDRH', 1);
INSERT INTO RH(idRH, loginRh, password, statut)
VALUES(2, 'testRH', 'testRH', 0);


-- CANDIDATURE --
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('1','Mimi', 'Jean', '2019-11-30', 'Accepté', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('2','Guy', 'Bedos', '2019-08-20', 'Accepté', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('3','Marc', 'Enrique', '2019-07-18', 'Accepté', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('4','Bobo', 'Dugenou', '2019-11-29', 'En Attente', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('5','Alain', 'Soupe', '2019-10-28', 'En Attente', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('6','Edgar', 'AlanPoe', '2019-09-27', 'En Attente', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('7','Jojo', 'Leclerc', '2019-11-28', 'Refusé', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('8','Boris', 'Meunier', '2019-11-01', 'Refusé', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('9','Joris', 'Fort', '2019-11-02', 'Refusé', 1);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('10','Arthur', 'King', '2019-11-30', 'Accepté', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('11','Fatima', 'Afroid', '2019-08-20', 'Accepté', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('12','Loris', 'Enrique', '2019-07-18', 'Accepté', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('13','Bernard', 'Dugenou', '2019-11-29', 'En Attente', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('14','Ali', 'Soupe', '2019-10-28', 'En Attente', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('15','Edward', 'Elric', '2019-09-27', 'En Attente', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('16','Joel', 'Leclerc', '2019-11-28', 'Refusé', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('17','Anna', 'Meunier', '2019-11-01', 'Refusé', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('18','Laura', 'Fort', '2019-11-02', 'Refusé', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('19','Sophie', 'King', '2019-11-30', 'Accepté', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('20','Paula', 'Kennedy', '2019-08-20', 'Accepté', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('21','Léa', 'Mal', '2019-07-18', 'Accepté', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('22','Benjamin', 'Dugenou', '2019-11-29', 'En Attente', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('23','Alice', 'Soupe', '2019-10-28', 'En Attente', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('24','Sona', 'Elric', '2019-09-27', 'En Attente', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('25','Theresa', 'Leclerc', '2019-11-28', 'Refusé', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('26','Marie', 'Meunier', '2019-11-01', 'Refusé', 3);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('27','Marine', 'Fort', '2019-11-02', 'Refusé', 3);


-- EVALUATION --
INSERT INTO EVALUATION(idEvaluation, nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES('1', 'LeRH', 'Zac', '2019-12-30', 0, 'Bof peu mieux faire', '1');
INSERT INTO EVALUATION(idEvaluation, nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES('2', 'LeDRH', 'Eugene', '2019-12-29', 5, 'Ponctuel RAS', '2');
