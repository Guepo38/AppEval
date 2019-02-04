
CREATE TABLE RH
(
    idRh INT,
    loginRh VARCHAR(30),
    password VARCHAR(30),
    statut INT,
    CONSTRAINT pk_RH PRIMARY KEY(idRH)
);
INSERT INTO RH(idRh, loginRh, password, statut)
VALUES(1, 'testDRH', 'testDRH', 1);
INSERT INTO RH(idRH, loginRh, password, statut)
VALUES(2, 'testRH', 'testRH', 0);


CREATE TABLE OFFRE_EMPLOI
(
  idOffre INT,
  titre VARCHAR(50),
  date_limite DATE,
  CONSTRAINT pk_offre_e PRIMARY KEY(idOffre)
);
INSERT INTO OFFRE_EMPLOI(idOffre, titre, date_limite)
VALUES(1 , 'testOffre', '2018-09-09');

CREATE TABLE CRITERE
(
  idCritere SERIAL,
  libelleCritere VARCHAR(50),
  coeff INT,
  idOffre INT,
  CONSTRAINT pk_critere PRIMARY KEY(idCritere),
  CONSTRAINT fk_critere FOREIGN KEY(idOffre)
  REFERENCES OFFRE_EMPLOI(idOffre)
);
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('tenue', 5, 1);
INSERT INTO CRITERE(libelleCritere, coeff, idOffre)
VALUES('competences', 2, 1);



CREATE TABLE CANDIDATURE
(
  idCandidature SERIAL,
  nomCand VARCHAR(30),
  prenomCand VARCHAR(30),
  dateCand DATE,
  statut VARCHAR(10),
  idOffre INT,
  CONSTRAINT pk_cand PRIMARY KEY(idCandidature),
  CONSTRAINT fk_cand FOREIGN KEY(idOffre)
  REFERENCES OFFRE_EMPLOI(idOffre)
);

CREATE TABLE EVALUATION
(
  idEvaluation INT,
  nomRH VARCHAR(30),
  prenomRH VARCHAR(30),
  dateEval DATE,
  BonusMalus INT,
  commentaire VARCHAR(200),
  idCandidature INT,
  CONSTRAINT pk_eval PRIMARY KEY(idEvaluation),
  CONSTRAINT fk_eval FOREIGN KEY(idCandidature)
  REFERENCES CANDIDATURE(idCandidature)
);

CREATE TABLE NOTER
(
  idCritere INT,
  idEvaluation INT,
  note INT,
  CONSTRAINT pk_noter PRIMARY KEY(idCritere, idEvaluation),
  CONSTRAINT fk_noter1 FOREIGN KEY(idCritere)
  REFERENCES CRITERE(idCritere),
  CONSTRAINT fk_noter2 FOREIGN KEY(idEvaluation)
  REFERENCES EVALUATION(idEvaluation)
);
