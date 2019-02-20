-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  Dim 16 déc. 2018 à 04:05
-- Version du serveur :  10.1.31-MariaDB
-- Version de PHP :  5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gestioncourses`
--
DROP DATABASE IF EXISTS `gestioncourses`;
CREATE DATABASE `gestioncourses`;
USE `gestioncourses`;

-- --------------------------------------------------------

--
-- Structure de la table `coureur`
--

CREATE TABLE `coureur` (
  `idCoureur` int(11) NOT NULL,
  `cour_nom` varchar(255) NOT NULL,
  `cour_prenom` varchar(255) NOT NULL,
  `cour_sexe` varchar(255) NOT NULL,
  `cour_courriel` varchar(255) NOT NULL,
  `cour_licence` varchar(255) NOT NULL,
  `cour_dateNaissance` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `coureur`
--

INSERT INTO `coureur` (`idCoureur`, `cour_nom`, `cour_prenom`, `cour_sexe`, `cour_courriel`, `cour_licence`, `cour_dateNaissance`) VALUES
(1, 'Bres', 'Raphael', 'M', 'rbres@ensc.fr', '0330021M', '1996-09-06 00:00:00'),
(2, 'Jouffroy', 'Emma', 'F', 'ejouffroy@ensc.fr', '0330131B', '1997-06-01 00:00:00'),
(3, 'Pesquet', 'Baptiste', 'M', 'bpesquet@ensc.fr', '0330092H', '1978-06-01 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `course`
--

CREATE TABLE `course` (
  `idCourse` int(11) NOT NULL,
  `course_nom` varchar(255) NOT NULL,
  `course_type` varchar(255) NOT NULL,
  `course_km` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `course`
--

INSERT INTO `course` (`idCourse`, `course_nom`, `course_type`, `course_km`) VALUES
(1, 'Marathon de Paris', 'Marathon ', 42),
(2, 'Course de Bordeaux', 'Semi-Marathon', 21);

-- --------------------------------------------------------

--
-- Structure de la table `participation`
--

CREATE TABLE `participation` (
  `idParticipation` int(11) NOT NULL,
  `idCoureur` int(11) DEFAULT NULL,
  `idCourse` int(11) DEFAULT NULL,
  `pt_dossard` int(11) NOT NULL,
  `pt_temps` varchar(255) NOT NULL,
  `pt_place` int(11) NOT NULL,
  `pt_vitesseMoyenne` double NOT NULL,
  `pt_allMoyenne` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participation`
--

INSERT INTO `participation` (`idParticipation`, `idCoureur`, `idCourse`, `pt_dossard`, `pt_temps`, `pt_place`, `pt_vitesseMoyenne`, `pt_allMoyenne`) VALUES
(1, 1, 1, 6728, '03:16:33', 3, 12, '14'),
(2, 2, 1, 2492, '03:06:11', 2, 13, '14'),
(3, 3, 1, 3430, '02:10:24', 1, 14, '15'),
(4, 2, 2, 8493, '01:32:31', 1, 13, '14');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `idUtilisateur` int(11) NOT NULL,
  `utilisateur_mail` varchar(255) NOT NULL,
  `utilisateur_mdp` varchar(255) NOT NULL,
  `utilisateur_connecte` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`idUtilisateur`, `utilisateur_mail`, `utilisateur_mdp`, `utilisateur_connecte`) VALUES
(1, 'ejouffroy@ensc.fr', 'ejouffroy', 0),
(2, 'braphael@ensc.fr', 'braphael', 0),
(3, 'madolphe@ensc.fr', 'madolphe', 0),
(4, 'admin', 'password', 0);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `coureur`
--
ALTER TABLE `coureur`
  ADD PRIMARY KEY (`idCoureur`);

--
-- Index pour la table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`idCourse`),
  ADD KEY `course_type` (`course_type`),
  ADD KEY `course_type_2` (`course_type`);

--
-- Index pour la table `participation`
--
ALTER TABLE `participation`
  ADD PRIMARY KEY (`idParticipation`),
  ADD KEY `idCoureur` (`idCoureur`),
  ADD KEY `idCourse` (`idCourse`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`idUtilisateur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `coureur`
--
ALTER TABLE `coureur`
  MODIFY `idCoureur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT pour la table `course`
--
ALTER TABLE `course`
  MODIFY `idCourse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `participation`
--
ALTER TABLE `participation`
  MODIFY `idParticipation` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `idUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participation`
--
ALTER TABLE `participation`
  ADD CONSTRAINT `FK669FE8D45EF571DE` FOREIGN KEY (`idCoureur`) REFERENCES `coureur` (`idCoureur`),
  ADD CONSTRAINT `FK669FE8D4BED36AB7` FOREIGN KEY (`idCourse`) REFERENCES `course` (`idCourse`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
