-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 18 Mai 2017 à 01:20
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bddcime`
--

-- --------------------------------------------------------

--
-- Structure de la table `beneficiaires`
--

CREATE TABLE `beneficiaires` (
  `ben_id` int(11) NOT NULL,
  `ben_nom` varchar(255) DEFAULT NULL,
  `ben_prenom` varchar(255) DEFAULT NULL,
  `ben_date_naiss` date DEFAULT NULL,
  `ben_lien_parente` varchar(255) DEFAULT NULL,
  `ben_adresse` varchar(255) DEFAULT NULL,
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `beneficiaires`
--

INSERT INTO `beneficiaires` (`ben_id`, `ben_nom`, `ben_prenom`, `ben_date_naiss`, `ben_lien_parente`, `ben_adresse`, `locville_id`) VALUES
(1, 'Bennom', 'BenPrenom', '2017-05-01', 'Mari', 'rue ben1', 1),
(2, 'bennom2', 'benprenom2', '2017-05-02', 'femme', 'rue ben2', 2),
(3, 'bennom3', 'benprenom3', '2017-05-03', 'oncle', 'rue du ben3', 2),
(4, 'bennom4', 'benprenom4', '2017-05-03', 'oncle', 'rue du ben4', 2),
(5, 'bennom5', 'benprenom5', '2017-05-03', 'oncle', 'rue du ben5', 2),
(6, 'bennom6', 'benprenom6', '2017-05-03', 'oncle', 'rue du ben6', 1),
(7, 'bennom7', 'benprenom7', '2017-05-03', 'oncle', 'rue du ben7', 2),
(8, 'bennom8', 'benprenom8', '2017-05-03', 'oncle', 'rue du ben8', 2),
(9, 'bennom9', 'benprenom9', '2017-05-03', 'oncle', 'rue du ben9', 2),
(10, 'bennom10', 'benprenom10', '2017-05-03', 'oncle', 'rue du ben10', 2),
(11, 'bennom11', 'benprenom11', '2017-05-03', 'oncle', 'rue du ben11', 2),
(12, 'bennom12', 'benprenom12', '2017-05-03', 'oncle', 'rue du ben12', 2),
(13, 'bennom13', 'benprenom13', '2017-05-02', 'femme', 'rue ben13', 2),
(14, 'bennom14', 'benprenom14', '2017-05-03', 'oncle', 'rue du ben14', 2),
(15, 'bennom15', 'benprenom15', '2017-05-03', 'oncle', 'rue du ben15', 1),
(16, 'bennom16', 'benprenom16', '2017-05-03', 'oncle', 'rue du ben16', 2),
(17, 'bennom17', 'benprenom17', '2017-05-03', 'oncle', 'rue du ben17', 2),
(18, 'bennom18', 'benprenom18', '2017-05-03', 'oncle', 'rue du ben18', 2),
(19, 'bennom19', 'benprenom19', '2017-05-03', 'oncle', 'rue du ben19', 2),
(20, 'bennom20', 'benprenom20', '2017-05-03', 'oncle', 'rue du ben20', 2),
(21, 'bennom21', 'benprenom21', '2017-05-03', 'oncle', 'rue du ben21', 2),
(22, 'bennom22', 'benprenom22', '2017-05-03', 'oncle', 'rue du ben22', 2),
(23, 'bennom23', 'benprenom23', '2017-05-03', 'oncle', 'rue du ben23', 2);
-- --------------------------------------------------------

--
-- Structure de la table `beneficier`
--

CREATE TABLE `beneficier` (
  `con_id` int(11) NOT NULL,
  `ben_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `beneficier`
--

INSERT INTO `beneficier` (`con_id`, `ben_id`) VALUES
(2, 1),
(2, 2),
(1, 3),
(2, 3),
(3, 10),
(3, 11),
(3, 12),
(3, 13),
(4, 15),
(5, 16),
(6, 4),
(7, 5),
(8, 6),
(9, 7),
(10, 8),
(7, 20),
(8, 21),
(9, 22),
(10, 23);

-- --------------------------------------------------------

--
-- Structure de la table `concessionnaires`
--

CREATE TABLE `concessionnaires` (
  `csnr_id` int(11) NOT NULL,
  `csnr_nom` varchar(255) DEFAULT NULL,
  `csnr_prenom` varchar(255) DEFAULT NULL,
  `csnr_date_naiss` date DEFAULT NULL,
  `csnr_adresse` varchar(255) DEFAULT NULL,
  `csnr_no_registre` int(11) DEFAULT NULL,
  `csnr_tel` varchar(255) DEFAULT NULL,
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessionnaires`
--

INSERT INTO `concessionnaires` (`csnr_id`, `csnr_nom`, `csnr_prenom`, `csnr_date_naiss`, `csnr_adresse`, `csnr_no_registre`, `csnr_tel`, `locville_id`) VALUES
(1, 'consnom1', 'consprenom1', '2017-05-11', 'rue du cons1', 15478552, '255145525', 2),
(2, 'consnom2', 'consprenom2', '2017-05-08', 'rue du cons2', 58288848, '1478569', 3),
(3, 'consnom3', 'consprenom1', '2017-05-11', 'rue du cons3', 15478552, '2551525', 2),
(4, 'consnom4', 'consprenom2', '2017-05-08', 'rue du cons4', 58288848, '14785269', 3),
(5, 'consnom5', 'consprenom1', '2017-05-11', 'rue du cons5', 15478552, '255185525', 2),
(6, 'consnom6', 'consprenom2', '2017-05-08', 'rue du cons6', 58288848, '147852369', 3),
(7, 'consnom7', 'consprenom1', '2017-05-11', 'rue du cons7', 15478552, '2551400055', 2),
(8, 'consnom8', 'consprenom2', '2017-05-08', 'rue du cons8', 58288848, '14785212369', 3),
(9, 'consnom9', 'consprenom1', '2017-05-11', 'rue du cons9', 15478552, '200005', 2),
(10, 'consnom10', 'consprenom2', '2017-05-08', 'rue du cons10', 58288848, '0000069', 3);
-- --------------------------------------------------------

--
-- Structure de la table `concessions`
--

CREATE TABLE `concessions` (
  `con_id` int(11) NOT NULL,
  `con_numero` int(11) DEFAULT NULL,
  `con_date_debut` date DEFAULT NULL,
  `con_date_fin` date DEFAULT NULL,
  `con_nbre_renovations` int(11) DEFAULT NULL,
  `con_montant_paye` decimal(7,0) DEFAULT NULL,
  `empl_id` int(11) NOT NULL,
  `csnr_id` int(11) NOT NULL,
  `com_id` int(11) DEFAULT NULL,
  `h_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessions`
--

INSERT INTO `concessions` (`con_id`, `con_numero`, `con_date_debut`, `con_date_fin`, `con_nbre_renovations`, `con_montant_paye`, `empl_id`, `csnr_id`, `com_id`, `h_id`) VALUES
(1, 20161, '2012-05-01', '2017-05-25', 0, '100', 2, 1, NULL, NULL),
(2, 20162, '2012-05-08', '2017-05-10', 0, '150', 4, 2, NULL, NULL),
(3, 20163, '2012-05-01', '2017-05-02', 1, '200', 3, 3, NULL, NULL),
(4, 20164, '2012-05-01', '2017-05-25', 0, '100', 5, 4, NULL, NULL),
(5, 20165, '2012-05-08', '2017-05-10', 0, '150', 4, 2, NULL, NULL),
(6, 20166, '2012-05-01', '2017-05-02', 1, '200', 7, 1, NULL, NULL),
(7, 20167, '2012-05-01', '2017-05-25', 0, '100', 9, 6, NULL, NULL),
(8, 20168, '2012-05-08', '2017-05-10', 0, '150', 10, 2, NULL, NULL),
(9, 20169, '2012-05-01', '2017-05-02', 1, '200', 3, 1, NULL, NULL),
(10, 201610, '2012-05-01', '2017-05-25', 0, '100', 12, 1, NULL, NULL),
(11, 201611, '2012-05-08', '2017-05-10', 0, '150', 15, 4, NULL, NULL),
(12, 201612, '2012-05-01', '2017-05-02', 1, '200', 16, 8, NULL, NULL),
(13, 201613, '2017-05-01', '2017-05-25', 0, '100', 17, 8, NULL, NULL),
(14, 201614, '2017-05-08', '2017-05-10', 0, '150', 15, 2, NULL, NULL),
(15, 201615, '2017-05-01', '2017-05-02', 1, '200', 15, 1, NULL, NULL);
-- --------------------------------------------------------

--
-- Structure de la table `defunts`
--

CREATE TABLE `defunts` (
  `def_id` int(11) NOT NULL,
  `def_numero_lh` int(11) DEFAULT NULL,
  `def_numero_annee` int(11) DEFAULT NULL,
  `def_prenom` varchar(255) DEFAULT NULL,
  `def_nom` varchar(255) DEFAULT NULL,
  `def_adresse` varchar(255) DEFAULT NULL,
  `def_etat_civil` int(11) DEFAULT NULL,
  `def_etat_civil_de` varchar(255) DEFAULT NULL,
  `def_date_naiss` date DEFAULT NULL,
  `def_lieu_naiss` varchar(255) DEFAULT NULL,
  `def_date_deces` date DEFAULT NULL,
  `def_lieu_deces` int(11) NOT NULL,
  `pc_id` int(11) NOT NULL,
  `Date_debut` date DEFAULT NULL,
  `Date_fin` date DEFAULT NULL,
  `empl_id` int(11) NOT NULL,
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `defunts`
--

INSERT INTO `defunts` (`def_id`, `def_numero_lh`, `def_numero_annee`, `def_prenom`, `def_nom`, `def_adresse`, `def_etat_civil`, `def_etat_civil_de`, `def_date_naiss`, `def_lieu_naiss`, `def_date_deces`, `def_lieu_deces`, `pc_id`, `Date_debut`, `Date_fin`, `empl_id`, `locville_id`) VALUES
(1, 10001, 201610001, 'defuntprenom1', 'defuntnom1', 'rue du defadresse 1', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 2, 3),
(2, 10002, 201610002, 'defuntprenom2', 'defuntnom2', 'rue du defadresse 2', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(3, 10003, 201610003, 'defuntprenom3', 'defuntnom3', 'rue du defadresse 3', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(4, 10004, 201610004, 'defuntprenom4', 'defuntnom4', 'rue du defadresse 4', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 14, 3),
(5, 10005, 201610005, 'defuntprenom5', 'defuntnom5', 'rue du defadresse 5', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 15, 3),
(6, 10006, 201610006, 'defuntprenom6', 'defuntnom36', 'rue du defadresse 6', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(7, 10007, 201610007, 'defuntprenom7', 'defuntnom7', 'rue du defadresse 7', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 14, 3),
(8, 10008, 201610008, 'defuntprenom8', 'defuntnom8', 'rue du defadresse 8', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 14, 3),
(9, 10009, 201610009, 'defuntprenom9', 'defuntnom9', 'rue du defadresse 9', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(10, 10010, 201610010, 'defuntprenom10', 'defuntnom10', 'rue du defadresse 10', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 12, 3),
(11, 10011, 201610011, 'defuntprenom11', 'defuntnom11', 'rue du defadresse 11', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 8, 3),
(12, 10012, 201610012, 'defuntprenom12', 'defuntnom12', 'rue du defadresse 12', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(13, 10013, 201610013, 'defuntprenom13', 'defuntnom13', 'rue du defadresse 13', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 9, 3),
(14, 10014, 201610014, 'defuntprenom14', 'defuntnom14', 'rue du defadresse 14', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3),
(15, 10015, 201610015, 'defuntprenom15', 'defuntnom15', 'rue du defadresse 15', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 5, 3),
(16, 10016, 201610016, 'defuntprenom16', 'defuntnom16', 'rue du defadresse 16', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 4, 3),
(17, 10017, 201610017, 'defuntprenom17', 'defuntnom17', 'rue du defadresse 17', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 3, 3),
(18, 10018, 201610018, 'defuntprenom18', 'defuntnom18', 'rue du defadresse 18', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 7, 3),
(19, 10019, 201610019, 'defuntprenom19', 'defuntnom19', 'rue du defadresse 19', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 10, 3),
(20, 10020, 201610020, 'defuntprenom20', 'defuntnom20', 'rue du defadresse 20', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 11, 3),
(21, 20001, 201620001, 'defuntprenom21', 'defuntnom21', 'rue du defadresse 21', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 13, 3),
(22, 20002, 201620002, 'defuntprenom22', 'defuntnom22', 'rue du defadresse 22', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 13, 3),
(23, 20003, 201620003, 'defuntprenom23', 'defuntnom23', 'rue du defadresse 23', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 16, 3),
(24, 20004, 201620004, 'defuntprenom24', 'defuntnom24', 'rue du defadresse 24', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 14, 3),
(25, 20005, 201620005, 'defuntprenom25', 'defuntnom25', 'rue du defadresse 25', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 15, 3),
(26, 20006, 201620006, 'defuntprenom26', 'defuntnom26', 'rue du defadresse 26', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 17, 3),
(27, 20007, 201620007, 'defuntprenom27', 'defuntnom27', 'rue du defadresse 27', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 1, 1, '2017-05-02', '2017-05-31', 14, 3),
(28, 20008, 201620008, 'defuntprenom28', 'defuntnom28', 'rue du defadresse 28', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 14, 3),
(29, 20009, 201620009, 'defuntprenom29', 'defuntnom29', 'rue du defadresse 29', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', 2, 2, '2017-05-02', '2017-05-31', 2, 3);
-- --------------------------------------------------------

--
-- Structure de la table `emplacements`
--

CREATE TABLE `emplacements` (
  `empl_id` int(11) NOT NULL,
  `empl_reference` varchar(255) DEFAULT NULL,
  `empl_type` varchar(50) DEFAULT NULL,
  `empl_nb_places` int(11) DEFAULT NULL,
  `empl_monum_classe` tinyint(4) DEFAULT NULL,
  `empl_coords` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `emplacements`
--

INSERT INTO `emplacements` (`empl_id`, `empl_reference`, `empl_type`, `empl_nb_places`, `empl_monum_classe`, `empl_coords`) VALUES
(1, 'A100', 'caveau', 10, 0, NULL),
(2, 'A200', 'caveau', 10, 0, NULL),
(3, 'A300', 'caveau', 10, 0, NULL),
(4, 'A400', 'caveau', 5, 0, NULL),
(5, 'A500', 'plein terre', 1, 0, NULL),
(6, 'A600', 'caveau', 10, 0, NULL),
(7, 'A700', 'caveau', 10, 0, NULL),
(8, 'A800', 'caveau', 10, 0, NULL),
(9, 'A900', 'caveau', 5, 0, NULL),
(10, 'A1000', 'plein terre', 1, 0, NULL),
(11, 'A1100', 'caveau', 10, 0, NULL),
(12, 'A1200', 'caveau', 10, 0, NULL),
(13, 'A1300', 'caveau', 10, 0, NULL),
(14, 'A1400', 'caveau', 5, 0, NULL),
(15, 'A1500', 'plein terre', 1, 0, NULL),
(16, 'A1600', 'caveau', 10, 0, NULL),
(17, 'A1700', 'caveau', 10, 0, NULL),
(18, 'A1800', 'caveau', 10, 0, NULL),
(19, 'A1900', 'caveau', 5, 0, NULL),
(20, 'A2000', 'plein terre', 1, 0, NULL),
(21, 'A2100', 'plein terre', 1, 0, NULL),
(22, 'A2200', 'caveau', 10, 0, NULL),
(23, 'A2300', 'caveau', 10, 0, NULL),
(24, 'A2400', 'caveau', 10, 0, NULL),
(25, 'A2500', 'caveau', 5, 0, NULL),
(26, 'A2600', 'plein terre', 1, 0, NULL),
(27, 'A2700', 'caveau', 10, 0, NULL),
(28, 'A2800', 'caveau', 10, 0, NULL),
(29, 'A2900', 'caveau', 10, 0, NULL),
(30, 'A3000', 'caveau', 5, 0, NULL),
(31, 'A3100', 'plein terre', 1, 0, NULL);


-- --------------------------------------------------------

--
-- Structure de la table `personnes_contact`
--

CREATE TABLE `personnes_contact` (
  `pc_id` int(11) NOT NULL,
  `pc_nom` varchar(255) DEFAULT NULL,
  `pc_prenom` varchar(255) DEFAULT NULL,
  `pc_tel` varchar(255) DEFAULT NULL,
  `pc_adresse` varchar(255) DEFAULT NULL,
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `personnes_contact`
--

INSERT INTO `personnes_contact` (`pc_id`, `pc_nom`, `pc_prenom`, `pc_tel`, `pc_adresse`, `locville_id`) VALUES
(1, 'persnom1', 'persprenom1', '14557751', 'rue de perscontact1', 2),
(2, 'persnom2', 'persprenom2', '1450002727', 'rue de persocontact2', 4),
(3, 'persnom3', 'persprenom3', '17751', 'rue de perscontact3', 2),
(4, 'persnom4', 'persprenom4', '14545072727', 'rue de persocontact4', 4),
(5, 'persnom5', 'persprenom5', '145500051', 'rue de perscontact5', 2),
(6, 'persnom6', 'persprenom6', '1454572727', 'rue de persocontact6', 4),
(7, 'persnom7', 'persprenom7', '19999951', 'rue de perscontact7', 2),
(8, 'persnom8', 'persprenom8', '1458888827', 'rue de persocontact8', 4),
(9, 'persnom9', 'persprenom9', '146666751', 'rue de perscontact9', 2),
(10, 'persnom10', 'persprenom10', '1455552727', 'rue de persocontact10', 4),
(11, 'persnom11', 'persprenom11', '14444451', 'rue de perscontact11', 2),
(12, 'persnom12', 'persprenom12', '143333727', 'rue de persocontact12', 4);

-- --------------------------------------------------------

--
-- Structure de la table `t_commentaire`
--

CREATE TABLE `t_commentaire` (
  `com_id` int(11) NOT NULL,
  `com_commentaire` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_histoire`
--

CREATE TABLE `t_histoire` (
  `h_id` int(11) NOT NULL,
  `h_histoire` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_loc_ville`
--

CREATE TABLE `t_loc_ville` (
  `locville_id` int(11) NOT NULL,
  `locville_cp` int(11) DEFAULT NULL,
  `locville_ville` varchar(25) DEFAULT NULL,
  `Pays_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_loc_ville`
--

INSERT INTO `t_loc_ville` (`locville_id`, `locville_cp`, `locville_ville`, `Pays_id`) VALUES
(1, 1310, 'La hulpe', 2),
(2, 1410, 'Waterloo', 2),
(3, 5555, 'Regua', 1),
(4, 666, 'Hell', 5);

-- --------------------------------------------------------

--
-- Structure de la table `t_pays`
--

CREATE TABLE `t_pays` (
  `Pays_id` int(11) NOT NULL,
  `Pays_nom` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_pays`
--

INSERT INTO `t_pays` (`Pays_id`, `Pays_nom`) VALUES
(1, 'Portugal'),
(2, 'Belgique'),
(3, 'France'),
(4, 'Allemagne'),
(5, 'Canada');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `beneficiaires`
--
ALTER TABLE `beneficiaires`
  ADD PRIMARY KEY (`ben_id`),
  ADD KEY `FK_beneficiaires_locville_id` (`locville_id`);

--
-- Index pour la table `beneficier`
--
ALTER TABLE `beneficier`
  ADD PRIMARY KEY (`con_id`,`ben_id`),
  ADD KEY `FK_Beneficier_ben_id` (`ben_id`);

--
-- Index pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  ADD PRIMARY KEY (`csnr_id`),
  ADD KEY `FK_concessionnaires_locville_id` (`locville_id`);

--
-- Index pour la table `concessions`
--
ALTER TABLE `concessions`
  ADD PRIMARY KEY (`con_id`),
  ADD KEY `FK_concessions_empl_id` (`empl_id`),
  ADD KEY `FK_concessions_csnr_id` (`csnr_id`),
  ADD KEY `FK_concessions_com_id` (`com_id`),
  ADD KEY `FK_concessions_h_id` (`h_id`);

--
-- Index pour la table `defunts`
--
ALTER TABLE `defunts`
  ADD PRIMARY KEY (`def_id`),
  ADD KEY `FK_defunts_locville_id` (`locville_id`),
  ADD KEY `empl_id` (`empl_id`),
  ADD KEY `FK_def_lieu_deces` (`pc_id`) USING BTREE;

--
-- Index pour la table `emplacements`
--
ALTER TABLE `emplacements`
  ADD PRIMARY KEY (`empl_id`);

--
-- Index pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  ADD PRIMARY KEY (`pc_id`),
  ADD KEY `FK_personnes_contact_locville_id` (`locville_id`);

--
-- Index pour la table `t_commentaire`
--
ALTER TABLE `t_commentaire`
  ADD PRIMARY KEY (`com_id`);

--
-- Index pour la table `t_histoire`
--
ALTER TABLE `t_histoire`
  ADD PRIMARY KEY (`h_id`);

--
-- Index pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  ADD PRIMARY KEY (`locville_id`),
  ADD KEY `FK_T_Loc_ville_Pays_id` (`Pays_id`);

--
-- Index pour la table `t_pays`
--
ALTER TABLE `t_pays`
  ADD PRIMARY KEY (`Pays_id`);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `beneficiaires`
--
ALTER TABLE `beneficiaires`
  ADD CONSTRAINT `FK_beneficiaires_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`);

--
-- Contraintes pour la table `beneficier`
--
ALTER TABLE `beneficier`
  ADD CONSTRAINT `FK_Beneficier_ben_id` FOREIGN KEY (`ben_id`) REFERENCES `beneficiaires` (`ben_id`),
  ADD CONSTRAINT `FK_Beneficier_con_id` FOREIGN KEY (`con_id`) REFERENCES `concessions` (`con_id`);

--
-- Contraintes pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  ADD CONSTRAINT `FK_concessionnaires_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`);

--
-- Contraintes pour la table `concessions`
--
ALTER TABLE `concessions`
  ADD CONSTRAINT `FK_concessions_com_id` FOREIGN KEY (`com_id`) REFERENCES `t_commentaire` (`com_id`),
  ADD CONSTRAINT `FK_concessions_csnr_id` FOREIGN KEY (`csnr_id`) REFERENCES `concessionnaires` (`csnr_id`),
  ADD CONSTRAINT `FK_concessions_empl_id` FOREIGN KEY (`empl_id`) REFERENCES `emplacements` (`empl_id`),
  ADD CONSTRAINT `FK_concessions_h_id` FOREIGN KEY (`h_id`) REFERENCES `t_histoire` (`h_id`);

--
-- Contraintes pour la table `defunts`
--
ALTER TABLE `defunts`
  ADD CONSTRAINT `FK_defunts_empl_id` FOREIGN KEY (`empl_id`) REFERENCES `emplacements` (`empl_id`),
  ADD CONSTRAINT `FK_defunts_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`),
  ADD CONSTRAINT `FK_defunts_pc_id` FOREIGN KEY (`pc_id`) REFERENCES `personnes_contact` (`pc_id`);

--
-- Contraintes pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  ADD CONSTRAINT `FK_personnes_contact_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`);

--
-- Contraintes pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  ADD CONSTRAINT `FK_T_Loc_ville_Pays_id` FOREIGN KEY (`Pays_id`) REFERENCES `t_pays` (`Pays_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
