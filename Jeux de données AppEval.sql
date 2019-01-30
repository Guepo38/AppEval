-- DONNEES CRITERE --
INSERT INTO CRITERE(libelleCritere)
VALUES("Personnalité et attitude");
INSERT INTO CRITERE(libelleCritere)
VALUES("Expérience");
INSERT INTO CRITERE(libelleCritere)
VALUES("Disponibilité");
INSERT INTO CRITERE(libelleCritere)
VALUES("Formation ou détention d'un diplôme");

-- OFFRE_EMPLOI --
INSERT INTO OFFRE_EMPLOI(titre)
VALUES("Administrateur Réseau");
INSERT INTO OFFRE_EMPLOI(titre)
VALUES("Chef de Projet");
INSERT INTO OFFRE_EMPLOI(titre)
VALUES("Développeur Web");

-- CANDIDATURE --
INSERT INTO CANDIDATURE(nomCand, prenomCand, dateCand, statut, id_offre)
VALUES("Mimi", "Jean", "2019-11-30", "Accepté", 1);
INSERT INTO CANDIDATURE(nomCand, prenomCand, dateCand, statut, id_offre)
VALUES("Bobo", "Dugenou", "2019-11-29", "En Attente", 2);
INSERT INTO CANDIDATURE(nomCand, prenomCand, dateCand, statut, id_offre)
VALUES("Jojo", "Leclerc", "2019-11-28", "Refusé" , 3);

-- EVALUATION --
INSERT INTO EVALUATION(nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES("LeRH", "Zac", "2019-12-30", NULL,)
INSERT INTO EVALUATION(nomRH, prenomRH, dateEval, BonusMalus, commentaire, idCandidature)
VALUES("LeDRH", "Eugene", "2019-12-29")
