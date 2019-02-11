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
VALUES('2','Bobo', 'Dugenou', '2019-11-29', 'En Attente', 2);
INSERT INTO CANDIDATURE(idCandidature, nomCand, prenomCand, dateCand, statut, idOffre)
VALUES('3','Jojo', 'Leclerc', '2019-11-28', 'Refusé', 3);

-- EVALUATION --
INSERT INTO EVALUATION(idEvaluation, nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES('1', 'LeRH', 'Zac', '2019-12-30', 0, 'Bof peu mieux faire', '1');
INSERT INTO EVALUATION(idEvaluation, nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES('2', 'LeDRH', 'Eugene', '2019-12-29', 5, 'Ponctuel RAS', '2');
