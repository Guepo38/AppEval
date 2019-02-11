CREATE DATABASE AppEval;
USE AppEval;

CREATE TABLE RH
(
    idRh INT,
    loginRh VARCHAR(30),
    password VARCHAR(30),
    statut INT,
    CONSTRAINT pk_RH PRIMARY KEY(idRH)
);

CREATE TABLE OFFRE_EMPLOI
(
  idOffre VARCHAR(5),
  titre VARCHAR(50),
  date_limite DATE,
  CONSTRAINT pk_offre_e PRIMARY KEY(idOffre)
);

CREATE TABLE CRITERE
(
  idCritere SERIAL,
  libelleCritere VARCHAR(50),
  coeff INT NOT NULL,
  idOffre VARCHAR(5),
  CONSTRAINT pk_critere PRIMARY KEY(idCritere),
  CONSTRAINT fk_critere FOREIGN KEY(idOffre)
  REFERENCES OFFRE_EMPLOI(idOffre)
);

CREATE TABLE CANDIDATURE
(
  idCandidature VARCHAR(5),
  nomCand VARCHAR(30),
  prenomCand VARCHAR(30),
  dateCand DATE,
  statut VARCHAR(10),
  idOffre VARCHAR(5),
  CONSTRAINT pk_cand PRIMARY KEY(idCandidature),
  CONSTRAINT fk_cand FOREIGN KEY(idOffre)
  REFERENCES OFFRE_EMPLOI(idOffre)
);

CREATE TABLE EVALUATION
(
  idEvaluation VARCHAR(5),
  nomRH VARCHAR(30),
  prenomRH VARCHAR(30),
  dateEval DATE,
  BonusMalus INT,
  commentaire VARCHAR(200),
  idCandidature VARCHAR(5),
  CONSTRAINT pk_eval PRIMARY KEY(idEvaluation),
  CONSTRAINT fk_eval FOREIGN KEY(idCandidature)
  REFERENCES CANDIDATURE(idCandidature)
);

CREATE TABLE NOTER
(
  idCritere INT,
  idEvaluation VARCHAR(5),
  note INT,
  CONSTRAINT pk_noter PRIMARY KEY(idCritere, idEvaluation),
  CONSTRAINT fk_noter1 FOREIGN KEY(idCritere)
  REFERENCES CRITERE(idCritere),
  CONSTRAINT fk_noter2 FOREIGN KEY(idEvaluation)
  REFERENCES EVALUATION(idEvaluation)
);
