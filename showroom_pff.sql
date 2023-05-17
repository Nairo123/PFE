-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : ven. 28 avr. 2023 à 14:29
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP : 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `showroom_pff`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `Cin_Client` int(20) NOT NULL,
  `Nom` varchar(20) NOT NULL,
  `Prenom` varchar(20) NOT NULL,
  `Adresse` varchar(20) NOT NULL,
  `Numéro_telephone` int(20) NOT NULL,
  `Ville` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`Cin_Client`, `Nom`, `Prenom`, `Adresse`, `Numéro_telephone`, `Ville`) VALUES
(241, 'Achraf', 'Aroud', 'BBGG', 9875564, 'Birbouregba'),
(787, 'dzagtf', 'drht', 'dtjrt', 651498496, 'hazha'),
(1888, 'Ahmad', 'SCCS', 'hammamet', 93214558, 'nabeul');

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

CREATE TABLE `commandes` (
  `Numéro_commande` int(25) NOT NULL,
  `Marque` varchar(25) NOT NULL,
  `Modéle` varchar(25) NOT NULL,
  `Mode de paiment` varchar(25) NOT NULL,
  `Date de commande` date NOT NULL,
  `Cin_Client` int(20) NOT NULL,
  `Montant` int(20) NOT NULL,
  `Remise` int(20) NOT NULL,
  `Avance` int(20) NOT NULL,
  `Reste` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `Log_in` varchar(20) NOT NULL,
  `Mot_de_passe` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`Log_in`, `Mot_de_passe`) VALUES
('ahmedhh', '0000');

-- --------------------------------------------------------

--
-- Structure de la table `voiture`
--

CREATE TABLE `voiture` (
  `Matricule` varchar(20) NOT NULL,
  `Modéle` varchar(20) NOT NULL,
  `Marque` varchar(20) NOT NULL,
  `Puissance Fiscale` int(20) NOT NULL,
  `Carburant` varchar(20) NOT NULL,
  `Kélometrage` int(20) NOT NULL,
  `Boite` varchar(20) NOT NULL,
  `Date de fabrication` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `voiture`
--

INSERT INTO `voiture` (`Matricule`, `Modéle`, `Marque`, `Puissance Fiscale`, `Carburant`, `Kélometrage`, `Boite`, `Date de fabrication`) VALUES
('123tu134', 'Peugoet', '', 5, 'Essence', 12344, 'Automatique', '2023-03-21'),
('124', '11', 'VolksXagen', 5, '', 1164597, '', '2023-01-01'),
('132tu14777', 'Bmw', '', 10, 'Essence', 15577, 'Automatique', '2023-03-21'),
('21', '', '', 21, '', 121, '', '2023-01-12'),
('rezrth', 'Peugoet', '', 5863, '', 26, '', '2023-02-07');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`Cin_Client`);

--
-- Index pour la table `commandes`
--
ALTER TABLE `commandes`
  ADD PRIMARY KEY (`Numéro_commande`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Log_in`);

--
-- Index pour la table `voiture`
--
ALTER TABLE `voiture`
  ADD PRIMARY KEY (`Matricule`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
