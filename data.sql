-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 19, 2019 at 06:57 AM
-- Server version: 8.0.13-4
-- PHP Version: 7.2.24-0ubuntu0.18.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ySI5U4T5pN`
--

-- --------------------------------------------------------

--
-- Table structure for table `Dosyalar`
--

CREATE TABLE `Dosyalar` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `Adi` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Yolu` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `Boyutu` bigint(20) NOT NULL,
  `Tipi` varchar(20) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Dosyalar`
--

INSERT INTO `Dosyalar` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `Adi`, `Yolu`, `Boyutu`, `Tipi`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, '20191126115042.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126115042.jpg', 849945, 'image/jpeg'),
(2, 0, '2019-01-01 00:00:00', NULL, '20191126115143.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126115143.jpg', 849945, 'image/jpeg'),
(3, 0, '2019-01-01 00:00:00', NULL, '20191126144554.PNG', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126144554.PNG', 424825, 'image/png'),
(4, 0, '2019-01-01 00:00:00', NULL, '20191126144745.PNG', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126144745.PNG', 424825, 'image/png'),
(5, 0, '2019-01-01 00:00:00', NULL, '20191126144954.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126144954.jpg', 849945, 'image/jpeg'),
(6, 0, '2019-01-01 00:00:00', NULL, '20191126151809.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126151809.jpg', 849945, 'image/jpeg'),
(7, 0, '2019-01-01 00:00:00', NULL, '20191126182131.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126182131.jpg', 391575, 'image/jpeg'),
(8, 0, '2019-01-01 00:00:00', NULL, '20191126183253.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126183253.jpg', 391575, 'image/jpeg'),
(9, 0, '2019-01-01 00:00:00', NULL, '20191126184418.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126184418.jpg', 849945, 'image/jpeg'),
(10, 0, '2019-01-01 00:00:00', NULL, '20191126190517.png', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126190517.png', 2326, 'image/png'),
(11, 0, '2019-01-01 00:00:00', NULL, '20191126190535.png', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126190535.png', 2131, 'image/png'),
(12, 0, '2019-01-01 00:00:00', NULL, '20191126191448.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126191448.jpg', 125504, 'image/jpeg'),
(13, 0, '2019-01-01 00:00:00', NULL, '20191126191506.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126191506.jpg', 96451, 'image/jpeg'),
(14, 0, '2019-01-01 00:00:00', NULL, '20191126191522.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126191522.jpg', 45270, 'image/jpeg'),
(15, 0, '2019-01-01 00:00:00', NULL, '20191126200549.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126200549.jpg', 53530, 'image/jpeg'),
(16, 0, '2019-01-01 00:00:00', NULL, '20191126200752.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126200752.jpg', 10372, 'image/jpeg'),
(17, 0, '2019-01-01 00:00:00', NULL, '20191126200822.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126200822.jpg', 107815, 'image/jpeg'),
(18, 0, '2019-01-01 00:00:00', NULL, '20191126201015.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126201015.jpg', 39803, 'image/jpeg'),
(19, 0, '2019-01-01 00:00:00', NULL, '20191126201043.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126201043.jpg', 116298, 'image/jpeg'),
(20, 0, '2019-01-01 00:00:00', NULL, '20191126201107.jpg', '/home/g3250/Projects/neccms/NecCms.Admin/wwwroot/images/20191126201107.jpg', 107815, 'image/jpeg'),
(21, 0, '2019-01-01 00:00:00', NULL, '20191127071422.jpg', 'D:\\home\\site\\wwwroot\\wwwroot\\images\\20191127071422.jpg', 125725, 'image/jpeg'),
(22, 0, '2019-01-01 00:00:00', NULL, '20191127071510.jpg', 'D:\\home\\site\\wwwroot\\wwwroot\\images\\20191127071510.jpg', 125725, 'image/jpeg'),
(23, 0, '2019-01-01 00:00:00', NULL, '20191128074235.jpg', 'D:\\home\\site\\wwwroot\\wwwroot\\images\\20191128074235.jpg', 56642, 'image/jpeg'),
(24, 0, '2019-01-01 00:00:00', NULL, '20191128074307.jpg', 'D:\\home\\site\\wwwroot\\wwwroot\\images\\20191128074307.jpg', 56642, 'image/jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `FotografGalerisi`
--

CREATE TABLE `FotografGalerisi` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `IcerikId` int(11) NOT NULL,
  `FotografGalerisiDosyaId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `FotografGalerisiDosyalar`
--

CREATE TABLE `FotografGalerisiDosyalar` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `DosyaId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `Icerikler`
--

CREATE TABLE `Icerikler` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `MenuId` int(11) NOT NULL,
  `Baslik` text COLLATE utf8_unicode_ci NOT NULL,
  `Giris` text COLLATE utf8_unicode_ci NOT NULL,
  `Icerik` text COLLATE utf8_unicode_ci,
  `YayinlanmaTarihi` datetime NOT NULL,
  `Durum` int(11) NOT NULL,
  `YazarId` int(11) NOT NULL,
  `ResimId` int(11) DEFAULT NULL,
  `Url` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Icerikler`
--

INSERT INTO `Icerikler` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `MenuId`, `Baslik`, `Giris`, `Icerik`, `YayinlanmaTarihi`, `Durum`, `YazarId`, `ResimId`, `Url`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 2, 'Etkinlik 1', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<p><span style=\"color: rgb(68, 68, 68);\">Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</span></p>', '0001-01-01 00:00:00', 2, 1, 15, 'etkinlik-1'),
(2, 0, '2019-01-01 00:00:00', NULL, 2, 'Etkinlik 2', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<p><span style=\"color: rgb(68, 68, 68);\">Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</span></p>', '0001-01-01 00:00:00', 2, 1, 24, 'etkinlik-2'),
(3, 0, '2019-01-01 00:00:00', NULL, 2, 'Etkinlik 3', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<p><span style=\"color: rgb(68, 68, 68);\">Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</span></p>', '0001-01-01 00:00:00', 2, 1, 17, 'etkinlik-3'),
(4, 0, '2019-01-01 00:00:00', NULL, 8, 'Haber 1', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<pre class=\"ql-syntax\" spellcheck=\"false\">Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</pre><p><br></p>', '0001-01-01 00:00:00', 2, 1, 18, 'haber-1'),
(5, 0, '2019-01-01 00:00:00', NULL, 8, 'Haber 2', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<p>Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</p>', '0001-01-01 00:00:00', 2, 1, 19, 'haber-2'),
(6, 0, '2019-01-01 00:00:00', NULL, 8, 'Haber 3', 'Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.', '<p>Lorem ipsum dolor sit amet, ei tincidunt persequeris efficiantur vel, usu animal patrioque omittantur et. Timeam nostrud platonem nec ea, simul nihil delectus has ex.</p>', '0001-01-01 00:00:00', 2, 1, 20, 'haber-3'),
(7, 0, '2019-01-01 00:00:00', NULL, 8, 'Haber 4', 'tsets', '<p>tsets</p>', '0001-01-01 00:00:00', 2, 1, 23, 'haber-4');

-- --------------------------------------------------------

--
-- Table structure for table `IcerikTipDegerleri`
--

CREATE TABLE `IcerikTipDegerleri` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `IcerikTipiId` int(11) NOT NULL,
  `Alan` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Deger` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `DegerInt` int(11) NOT NULL DEFAULT '0',
  `Sira` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `IcerikTipDegerleri`
--

INSERT INTO `IcerikTipDegerleri` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `IcerikTipiId`, `Alan`, `Deger`, `DegerInt`, `Sira`) VALUES
(1, 1, '2019-01-01 00:00:00', NULL, 1, 'resim', '20191126144954.jpg', 5, 0),
(2, 1, '2019-01-01 00:00:00', NULL, 1, 'baslik', 'test', 0, 0),
(3, 1, '2019-01-01 00:00:00', NULL, 1, 'buttonyazi', 'test', 0, 0),
(4, 1, '2019-01-01 00:00:00', NULL, 1, 'buttonlink', '/', 0, 0),
(5, 1, '2019-01-01 00:00:00', NULL, 1, 'resim', '20191126151809.jpg', 6, 1),
(6, 1, '2019-01-01 00:00:00', NULL, 1, 'baslik', 'Test', 0, 1),
(7, 1, '2019-01-01 00:00:00', NULL, 1, 'aciklama', 'Test', 0, 1),
(8, 1, '2019-01-01 00:00:00', NULL, 1, 'buttonyazi', 'Test', 0, 1),
(9, 1, '2019-01-01 00:00:00', NULL, 1, 'buttonlink', '/', 0, 2),
(10, 0, '2019-01-01 00:00:00', NULL, 1, 'resim', '20191126183253.jpg', 8, 1),
(11, 0, '2019-01-01 00:00:00', NULL, 1, 'baslik', 'Başlık', 0, 1),
(12, 0, '2019-01-01 00:00:00', NULL, 1, 'aciklama', 'Açıklama', 0, 1),
(13, 0, '2019-01-01 00:00:00', NULL, 1, 'buttonyazi', 'Button', 0, 1),
(14, 0, '2019-01-01 00:00:00', NULL, 1, 'buttonlink', '/', 0, 1),
(15, 0, '2019-01-01 00:00:00', NULL, 1, 'resim', '20191126184418.jpg', 9, 2),
(16, 0, '2019-01-01 00:00:00', NULL, 1, 'baslik', 'Baslik 2', 0, 2),
(17, 0, '2019-01-01 00:00:00', NULL, 1, 'aciklama', 'Aciklama 2', 0, 2),
(18, 0, '2019-01-01 00:00:00', NULL, 1, 'buttonyazi', 'Button Yazi 2', 0, 2),
(19, 0, '2019-01-01 00:00:00', NULL, 1, 'buttonlink', '/', 0, 2),
(20, 0, '2019-01-01 00:00:00', NULL, 2, 'resim', '20191126191448.jpg', 12, 3),
(21, 0, '2019-01-01 00:00:00', NULL, 2, 'baslik', 'Etkinliklerimiz', 0, 3),
(22, 0, '2019-01-01 00:00:00', NULL, 2, 'link', '/', 0, 3),
(23, 0, '2019-01-01 00:00:00', NULL, 2, 'resim', '20191126191506.jpg', 13, 4),
(24, 0, '2019-01-01 00:00:00', NULL, 2, 'baslik', 'Baslik 2', 0, 4),
(25, 0, '2019-01-01 00:00:00', NULL, 2, 'link', '/', 0, 4),
(26, 0, '2019-01-01 00:00:00', NULL, 2, 'resim', '20191126191522.jpg', 14, 5),
(27, 0, '2019-01-01 00:00:00', NULL, 2, 'baslik', 'Baslik 3', 0, 5),
(28, 0, '2019-01-01 00:00:00', NULL, 2, 'link', '/', 0, 5),
(29, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', 'iconcustom-certificate', 0, 6),
(30, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Quality Certifications', 0, 6),
(31, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 6),
(32, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', ' iconcustom-innovation', 0, 7),
(33, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Learning Best Practice', 0, 7),
(34, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 7),
(35, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', ' iconcustom-education_online', 0, 8),
(36, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Online Resources', 0, 8),
(37, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 8),
(38, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', ' iconcustom-know_how', 0, 9),
(39, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Study Plan Tutors', 0, 9),
(40, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 9),
(41, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', ' iconcustom-science', 0, 10),
(42, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Advanced Practice', 0, 10),
(43, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 10),
(44, 0, '2019-01-01 00:00:00', NULL, 3, 'icon', ' iconcustom-test', 0, 11),
(45, 0, '2019-01-01 00:00:00', NULL, 3, 'baslik', 'Araştırma', 0, 11),
(46, 0, '2019-01-01 00:00:00', NULL, 3, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex, appareat similique an usu.', 0, 11),
(47, 0, '2019-01-01 00:00:00', NULL, 4, 'baslik', 'Students growth', 0, 12),
(48, 0, '2019-01-01 00:00:00', NULL, 4, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex.', 0, 12),
(49, 0, '2019-01-01 00:00:00', NULL, 4, 'baslik', 'Best learning practice', 0, 13),
(50, 0, '2019-01-01 00:00:00', NULL, 4, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex.', 0, 13),
(51, 0, '2019-01-01 00:00:00', NULL, 4, 'baslik', 'Focus on targets', 0, 14),
(52, 0, '2019-01-01 00:00:00', NULL, 4, 'aciklama', 'Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex.', 0, 14),
(53, 0, '2019-01-01 00:00:00', NULL, 4, 'baslik', 'Interdisciplanary model', 0, 15),
(54, 0, '2019-01-01 00:00:00', NULL, 4, 'aciklama', 'Test Lorem ipsum dolor sit amet, vix erat audiam ei. Cum doctus civibus efficiantur in. Nec id tempor imperdiet deterruisset, doctus volumus explicari qui ex.', 0, 15);

-- --------------------------------------------------------

--
-- Table structure for table `IcerikTipleri`
--

CREATE TABLE `IcerikTipleri` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `Isim` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Kodu` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Alanlar` varchar(500) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `IcerikTipleri`
--

INSERT INTO `IcerikTipleri` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `Isim`, `Kodu`, `Alanlar`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 'Slider', 'slider', 'resim:dosya;baslik:yazi;aciklama:yazi;buttonyazi:yazi;buttonlink:yazi'),
(2, 0, '2019-01-01 00:00:00', NULL, 'Slider Altındaki Menuler', 'slideraltındakimenuler', 'resim:dosya;baslik:yazi;link:yazi'),
(3, 0, '2019-01-01 00:00:00', NULL, 'Anasayfa Bölüm 1', 'anasayfabolum1', 'icon:input;baslik:input;aciklama:textarea'),
(4, 0, '2019-01-01 00:00:00', NULL, 'Anasayfa Bolum 2', 'anasayfabolum2', 'baslik:input;aciklama:textarea');

-- --------------------------------------------------------

--
-- Table structure for table `Iletisim`
--

CREATE TABLE `Iletisim` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `Konu` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `AdSoyad` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Eposta` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Aciklama` varchar(500) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Iletisim`
--

INSERT INTO `Iletisim` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `Konu`, `AdSoyad`, `Eposta`, `Aciklama`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, '123', '123', '123', '123'),
(2, 0, '2019-01-01 00:00:00', NULL, '1', '1', '1@1', '1');

-- --------------------------------------------------------

--
-- Table structure for table `Kullanicilar`
--

CREATE TABLE `Kullanicilar` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `AdSoyad` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `Telefon` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `Eposta` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Parola` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Rol` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Kullanicilar`
--

INSERT INTO `Kullanicilar` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `AdSoyad`, `Telefon`, `Eposta`, `Parola`, `Rol`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 'Admin', '05456286324', 'admin@crm.com', 'admin@crm.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Loggers`
--

CREATE TABLE `Loggers` (
  `Id` int(11) NOT NULL,
  `Tarih` datetime NOT NULL,
  `RemoteIpAddress` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Path` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `QueryString` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `UserAgent` varchar(250) COLLATE utf8_unicode_ci NOT NULL,
  `StatusCode` int(11) NOT NULL,
  `Time` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Loggers`
--

INSERT INTO `Loggers` (`Id`, `Tarih`, `RemoteIpAddress`, `Path`, `QueryString`, `UserAgent`, `StatusCode`, `Time`) VALUES
(1, '2019-11-26 11:27:11', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 3583),
(2, '2019-11-26 11:27:15', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(3, '2019-11-26 15:41:42', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 18250),
(4, '2019-11-26 15:41:43', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 223),
(5, '2019-11-26 15:41:44', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 10),
(6, '2019-11-26 15:41:46', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2),
(7, '2019-11-26 15:41:47', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2),
(8, '2019-11-26 15:41:47', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 3),
(9, '2019-11-26 15:41:47', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 6),
(10, '2019-11-26 15:41:59', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2003),
(11, '2019-11-26 15:45:02', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(12, '2019-11-26 18:14:30', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8984),
(13, '2019-11-26 18:14:33', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 6465),
(14, '2019-11-26 18:14:40', '::1', '/20191126151809.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1396),
(15, '2019-11-26 18:14:47', '::1', '/20191126151809.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1013),
(16, '2019-11-26 18:15:06', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2196),
(17, '2019-11-26 18:15:29', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2457),
(18, '2019-11-26 18:15:56', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1953),
(19, '2019-11-26 18:15:58', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1027),
(20, '2019-11-26 18:16:57', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1321),
(21, '2019-11-26 18:16:58', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1024),
(22, '2019-11-26 18:17:14', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1313),
(23, '2019-11-26 18:17:16', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1010),
(24, '2019-11-26 18:21:45', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(25, '2019-11-26 18:33:07', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(26, '2019-11-26 18:33:53', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4416),
(27, '2019-11-26 18:34:06', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1337),
(28, '2019-11-26 18:36:07', '::1', '/img/popup.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 6283),
(29, '2019-11-26 18:41:20', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 5476),
(30, '2019-11-26 18:44:26', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 3236),
(31, '2019-11-26 18:49:45', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4192),
(32, '2019-11-26 18:49:49', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(33, '2019-11-26 18:51:24', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 944),
(34, '2019-11-26 18:51:24', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8210),
(35, '2019-11-26 19:06:35', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 6436),
(36, '2019-11-26 19:06:42', '::1', '/20191126190535.png', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1191),
(37, '2019-11-26 19:06:42', '::1', '/20191126190517.png', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 5),
(38, '2019-11-26 19:07:12', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(39, '2019-11-26 19:17:13', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 14373),
(40, '2019-11-26 19:35:46', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8418),
(41, '2019-11-26 19:43:21', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8854),
(42, '2019-11-26 19:44:07', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 7030),
(43, '2019-11-26 19:51:39', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2737),
(44, '2019-11-26 19:51:42', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1103),
(45, '2019-11-26 19:51:57', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1270),
(46, '2019-11-26 19:51:59', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1044),
(47, '2019-11-26 19:52:09', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8712),
(48, '2019-11-26 19:52:35', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8764),
(49, '2019-11-26 19:53:12', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8936),
(50, '2019-11-26 19:53:55', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8803),
(51, '2019-11-26 19:54:22', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8774),
(52, '2019-11-26 19:54:43', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8892),
(53, '2019-11-26 19:55:33', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8601),
(54, '2019-11-26 19:56:21', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8428),
(55, '2019-11-26 19:57:06', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(56, '2019-11-26 20:06:09', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 20780),
(57, '2019-11-26 20:07:09', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 12340),
(58, '2019-11-26 20:11:43', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 17298),
(59, '2019-11-26 20:20:10', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 21824),
(60, '2019-11-26 20:21:29', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 22751),
(61, '2019-11-26 20:22:41', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(62, '2019-11-26 20:25:31', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 23299),
(63, '2019-11-26 20:25:55', '::1', '/layerslider/skins/v5/loading.gif', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(64, '2019-11-26 17:34:19', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4991),
(65, '2019-11-26 17:34:24', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1721),
(66, '2019-11-26 17:34:44', '95.70.213.113', '/', NULL, 'WhatsApp/2.19.341 A', 200, 1484),
(67, '2019-11-26 17:36:19', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (Linux; Android 8.1.0; CPH1903) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 1392),
(68, '2019-11-26 17:36:52', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (Linux; Android 8.1.0; CPH1903) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 0),
(69, '2019-11-26 20:28:34', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (Linux; Android 8.1.0; CPH1903) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 0),
(70, '2019-11-27 06:55:24', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (Linux; Android 8.1.0; CPH1903) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 4891),
(71, '2019-11-27 06:55:31', '78.190.250.206', '/layerslider/skins/v5/loading.gif', NULL, 'Mozilla/5.0 (Linux; Android 8.1.0; CPH1903) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 101),
(72, '2019-11-27 07:06:53', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1701),
(73, '2019-11-27 07:07:22', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 3439),
(74, '2019-11-27 07:07:22', '78.190.250.206', '/img/loader.gif', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(75, '2019-11-27 07:07:22', '78.190.250.206', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 500, 0),
(76, '2019-11-27 07:08:38', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1462),
(77, '2019-11-27 10:12:23', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 18024),
(78, '2019-11-27 07:14:39', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(79, '2019-11-27 07:14:39', '78.190.250.206', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 500, 0),
(80, '2019-11-27 07:14:45', '78.190.250.206', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(81, '2019-11-27 07:14:45', '78.190.250.206', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 500, 0),
(82, '2019-11-27 10:15:16', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 15077),
(83, '2019-11-27 10:37:31', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 13844),
(84, '2019-11-27 10:37:45', '::1', '/img/header_bg_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 5458),
(85, '2019-11-27 10:59:21', '::1', '/img/header_bg_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 21380),
(86, '2019-11-27 10:59:51', '::1', '/img/header_bg_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 5608),
(87, '2019-11-27 11:11:03', '::1', '/img/header_bg_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 13689),
(88, '2019-11-27 11:14:40', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1267),
(89, '2019-11-27 11:14:43', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 10886),
(90, '2019-11-27 11:14:48', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 21757),
(91, '2019-11-27 11:14:52', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 25344),
(92, '2019-11-27 11:15:34', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 11969),
(93, '2019-11-27 11:18:26', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 11169),
(94, '2019-11-27 11:18:50', '::1', '/blog', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 11751),
(95, '2019-11-27 11:19:12', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 9703),
(96, '2019-11-27 11:19:29', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 13995),
(97, '2019-11-27 11:20:39', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 21088),
(98, '2019-11-27 11:21:05', '::1', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(99, '2019-11-27 14:00:10', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 23581),
(100, '2019-11-27 14:00:35', '::1', '/layerslider/skins/v5/loading.gif', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 749),
(101, '2019-11-27 14:00:54', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10796),
(102, '2019-11-27 14:01:23', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13291),
(103, '2019-11-27 14:02:22', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10812),
(104, '2019-11-27 14:02:39', '::1', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10585),
(105, '2019-11-27 14:04:13', '::1', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10984),
(106, '2019-11-27 14:04:31', '::1', '/blog', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10528),
(107, '2019-11-27 14:06:33', '::1', '/blog', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1066),
(108, '2019-11-27 14:06:34', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1057),
(109, '2019-11-27 14:06:42', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 18389),
(110, '2019-11-27 14:07:13', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10356),
(111, '2019-11-27 11:07:12', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4527),
(112, '2019-11-27 11:07:24', '95.70.213.113', '/blog', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(113, '2019-11-27 11:07:24', '95.70.213.113', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 500, 0),
(114, '2019-11-27 14:12:49', '::1', '/blog', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 2481),
(115, '2019-11-27 14:12:52', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1099),
(116, '2019-11-27 14:13:18', '::1', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 2530),
(117, '2019-11-27 14:13:20', '::1', '/fontello/css/animation.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 744),
(118, '2019-11-27 14:13:21', '::1', '/js/jquery.easing.1.3.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 14),
(119, '2019-11-27 14:13:21', '::1', '/fontello/css/fontello.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 27),
(120, '2019-11-27 14:13:21', '::1', '/js/jquery.animate-enhanced.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 22),
(121, '2019-11-27 14:13:21', '::1', '/js/jquery.superslides.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 22),
(122, '2019-11-27 14:13:21', '::1', '/img/slide_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 14),
(123, '2019-11-27 14:13:21', '::1', '/js/retina.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(124, '2019-11-27 14:13:21', '::1', '/img/slide_2.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(125, '2019-11-27 14:13:21', '::1', '/img/slide_3.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 21),
(126, '2019-11-27 14:13:21', '::1', '/js/jquery.easing.1.3.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7092),
(127, '2019-11-27 14:13:28', '::1', '/js/jquery.animate-enhanced.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7000),
(128, '2019-11-27 14:13:35', '::1', '/fontello/css/fontello.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1654),
(129, '2019-11-27 14:13:35', '::1', '/fontello/css/animation.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(130, '2019-11-27 14:13:35', '::1', '/js/jquery.superslides.min.js', NULL, 'Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 3),
(131, '2019-11-27 14:13:35', '::1', '/js/retina.min.js', NULL, 'Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Mobile Safari/537.36', 200, 5),
(132, '2019-11-27 14:13:52', '::1', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1884),
(133, '2019-11-27 14:13:54', '::1', '/fontello/css/fontello.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 723),
(134, '2019-11-27 14:13:54', '::1', '/fontello/css/animation.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 14),
(135, '2019-11-27 14:13:54', '::1', '/img/slide_1.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 12),
(136, '2019-11-27 14:13:54', '::1', '/js/jquery.easing.1.3.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7),
(137, '2019-11-27 14:13:54', '::1', '/js/jquery.animate-enhanced.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7),
(138, '2019-11-27 14:13:54', '::1', '/js/jquery.superslides.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 8),
(139, '2019-11-27 14:13:54', '::1', '/js/retina.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 8),
(140, '2019-11-27 14:13:54', '::1', '/img/slide_3.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4),
(141, '2019-11-27 14:13:54', '::1', '/img/slide_2.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(142, '2019-11-27 14:13:54', '::1', '/js/jquery.easing.1.3.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6897),
(143, '2019-11-27 14:14:01', '::1', '/js/jquery.animate-enhanced.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6836),
(144, '2019-11-27 14:14:03', '::1', '/img/slide_2.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6894),
(145, '2019-11-27 14:14:08', '::1', '/js/jquery.superslides.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6983),
(146, '2019-11-27 14:14:15', '::1', '/js/retina.min.js', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(147, '2019-11-27 14:15:43', '::1', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4505),
(148, '2019-11-27 14:15:48', '::1', '/fontello/css/fontello.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 766),
(149, '2019-11-27 14:15:48', '::1', '/fontello/css/animation.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 201),
(150, '2019-11-27 14:16:05', '::1', '/Home/Error', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 2090),
(151, '2019-11-27 14:16:07', '::1', '/fontello/css/fontello.css', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(152, '2019-11-27 14:21:44', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 21476),
(153, '2019-11-27 14:23:20', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10055),
(154, '2019-11-27 14:23:38', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9942),
(155, '2019-11-27 14:24:05', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 12267),
(156, '2019-11-27 14:56:18', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(157, '2019-11-27 14:58:20', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13077),
(158, '2019-11-27 15:00:06', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7583),
(159, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/course_1_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 113),
(160, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/course_1_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 833),
(161, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 89),
(162, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 84),
(163, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_3_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4),
(164, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_4_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 3),
(165, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_5_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6),
(166, '2019-11-27 15:00:14', '::1', '/etkinlikler/img/teacher_6_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13),
(167, '2019-11-27 15:02:46', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10679),
(168, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/course_1_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 760),
(169, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 17),
(170, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_3_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 18),
(171, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/course_1_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 14),
(172, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_4_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13),
(173, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 12),
(174, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_5_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 23),
(175, '2019-11-27 15:02:57', '::1', '/etkinlikler/img/teacher_6_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4),
(176, '2019-11-27 15:02:57', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(177, '2019-11-27 15:03:28', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 8195),
(178, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/course_1_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 713),
(179, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/course_1_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 36),
(180, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(181, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4),
(182, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_4_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 5),
(183, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_3_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 35),
(184, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_6_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 39),
(185, '2019-11-27 15:03:37', '::1', '/etkinlikler/img/teacher_5_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 12),
(186, '2019-11-27 15:03:50', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7631),
(187, '2019-11-27 15:03:58', '::1', '/etkinlikler/img/course_1_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(188, '2019-11-27 15:10:21', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9929),
(189, '2019-11-27 15:11:33', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6971),
(190, '2019-11-27 15:14:03', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 18182),
(191, '2019-11-27 15:14:27', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9707),
(192, '2019-11-27 15:14:44', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6989),
(193, '2019-11-27 15:15:09', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7005),
(194, '2019-11-27 15:16:20', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 10599),
(195, '2019-11-27 15:17:05', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1653),
(196, '2019-11-27 15:17:07', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(197, '2019-11-27 15:18:02', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13581),
(198, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/course_1_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 743),
(199, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_1_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 92),
(200, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 84),
(201, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_3_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 71),
(202, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_4_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 74),
(203, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/course_1_2_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 69),
(204, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_5_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 4),
(205, '2019-11-27 15:18:16', '::1', '/etkinlikler/img/teacher_6_thumb.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 13),
(206, '2019-11-27 15:18:16', '::1', '/etkinlikler/20191126200822.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 8),
(207, '2019-11-27 15:22:41', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7895),
(208, '2019-11-27 15:22:50', '::1', '/etkinlikler/20191126200822.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1142),
(209, '2019-11-27 15:23:36', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7759),
(210, '2019-11-27 15:23:45', '::1', '/etkinlikler/20191126200822.jpg', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1139),
(211, '2019-11-27 15:24:16', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7520),
(212, '2019-11-27 15:25:39', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7343),
(213, '2019-11-27 15:26:10', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7589),
(214, '2019-11-27 15:26:22', '::1', '/etkinlikler/etkinlik-3', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7513),
(215, '2019-11-27 15:27:04', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 18328),
(216, '2019-11-27 15:27:28', '::1', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9833),
(217, '2019-11-27 15:27:42', '::1', '/haberler/haber-4', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 7678),
(218, '2019-11-27 15:27:56', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 18009),
(219, '2019-11-27 15:31:23', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 17139),
(220, '2019-11-27 15:32:38', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6741),
(221, '2019-11-27 15:34:22', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6593),
(222, '2019-11-27 15:34:40', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(223, '2019-11-27 15:42:12', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 11362),
(224, '2019-11-27 15:43:27', '::1', '/iletisim/kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1518),
(225, '2019-11-27 15:44:14', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6797),
(226, '2019-11-27 15:44:39', '::1', '/iletisim/kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1319),
(227, '2019-11-27 15:45:26', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6617),
(228, '2019-11-27 15:45:50', '::1', '/iletisim/kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1326),
(229, '2019-11-27 15:48:11', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6581),
(230, '2019-11-27 15:48:34', '::1', '/iletisim/kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1347),
(231, '2019-11-27 15:49:23', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6728),
(232, '2019-11-27 15:49:44', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1385),
(233, '2019-11-27 15:49:45', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(234, '2019-11-27 15:50:39', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 3928),
(235, '2019-11-27 15:50:43', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1201),
(236, '2019-11-27 15:50:57', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6738),
(237, '2019-11-27 15:51:20', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1337),
(238, '2019-11-27 15:51:22', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(239, '2019-11-27 15:52:23', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 2853),
(240, '2019-11-27 15:52:32', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6867),
(241, '2019-11-27 15:52:54', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(242, '2019-11-27 15:53:20', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9455),
(243, '2019-11-27 15:53:41', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1499),
(244, '2019-11-27 15:53:43', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(245, '2019-11-27 15:54:12', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9133),
(246, '2019-11-27 15:54:38', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1581),
(247, '2019-11-27 15:54:40', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(248, '2019-11-27 15:55:18', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9418),
(249, '2019-11-27 15:55:40', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1499),
(250, '2019-11-27 15:55:55', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 6251),
(251, '2019-11-27 15:56:18', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 1332),
(252, '2019-11-27 15:59:19', '::1', '/Iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 9163),
(253, '2019-11-27 15:59:43', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36', 200, 0),
(254, '2019-11-27 15:48:53', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 4718),
(255, '2019-11-27 15:48:54', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 0),
(256, '2019-11-27 15:48:54', '46.221.242.134', '/Home/Error', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 500, 0),
(257, '2019-11-27 15:48:55', '46.221.242.134', '/favicon.ico', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 0),
(258, '2019-11-27 15:48:55', '46.221.242.134', '/Home/Error', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 500, 0),
(259, '2019-11-27 15:49:10', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1252),
(260, '2019-11-27 15:49:14', '46.221.242.134', '/layerslider/skins/v5/loading.gif', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 75),
(261, '2019-11-27 15:49:26', '46.221.242.134', '/etkinlik-3', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 628),
(262, '2019-11-27 15:49:26', '46.221.242.134', '/Home/Error', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 500, 482),
(263, '2019-11-27 15:49:42', '46.221.242.134', '/sponsorlar', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 311),
(264, '2019-11-27 15:49:42', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1249),
(265, '2019-11-27 15:49:48', '46.221.242.134', '/iletisim', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1354),
(266, '2019-11-27 15:49:49', '46.221.242.134', '/Home/Error', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 500, 467);
INSERT INTO `Loggers` (`Id`, `Tarih`, `RemoteIpAddress`, `Path`, `QueryString`, `UserAgent`, `StatusCode`, `Time`) VALUES
(267, '2019-11-27 15:50:15', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1349),
(268, '2019-11-27 15:50:20', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1218),
(269, '2019-11-27 15:50:25', '46.221.242.134', '/haberler', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 687),
(270, '2019-11-27 15:50:36', '46.221.242.134', '/iletisim', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1207),
(271, '2019-11-27 15:50:37', '46.221.242.134', '/Home/Error', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 500, 471),
(272, '2019-11-27 15:51:02', '46.221.242.134', '/haberler/haber-3', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 737),
(273, '2019-11-27 15:51:07', '46.221.242.134', '/haberler/haber-2', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 519),
(274, '2019-11-27 15:51:13', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1219),
(275, '2019-11-27 15:51:26', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 1278),
(276, '2019-11-27 15:52:13', '46.221.242.134', '/', NULL, 'Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.1.1 Mobile/15E148 Safari/604.1', 200, 0),
(277, '2019-11-28 07:05:23', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4880),
(278, '2019-11-28 07:06:59', '95.70.213.113', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(279, '2019-11-28 10:07:04', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 23151),
(280, '2019-11-28 10:07:32', '::1', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 9508),
(281, '2019-11-28 10:07:58', '::1', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 9958),
(282, '2019-11-28 07:13:07', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 7663),
(283, '2019-11-28 07:13:19', '95.70.213.113', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 771),
(284, '2019-11-28 07:14:17', '95.70.213.113', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 746),
(285, '2019-11-28 07:14:20', '95.70.213.113', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 745),
(286, '2019-11-28 07:14:26', '95.70.213.113', '/haberler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 687),
(287, '2019-11-28 07:14:31', '95.70.213.113', '/haberler/haber-4', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 538),
(288, '2019-11-28 07:14:38', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1280),
(289, '2019-11-28 07:14:54', '95.70.213.113', '/sponsorlar', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 268),
(290, '2019-11-28 07:14:54', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1256),
(291, '2019-11-28 07:14:58', '95.70.213.113', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(292, '2019-11-28 07:41:17', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4686),
(293, '2019-11-28 07:41:22', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1237),
(294, '2019-11-28 07:41:33', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1263),
(295, '2019-11-28 07:43:10', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1242),
(296, '2019-11-28 07:44:03', '95.70.213.113', '/etkinlikler', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 778),
(297, '2019-11-28 10:57:57', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2220),
(298, '2019-11-28 10:58:00', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1004),
(299, '2019-11-28 10:58:25', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 680),
(300, '2019-11-28 10:58:25', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 975),
(301, '2019-11-28 10:58:30', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 683),
(302, '2019-11-28 10:58:31', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 944),
(303, '2019-11-28 10:58:43', '::1', '/home/index', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 676),
(304, '2019-11-28 10:58:44', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 984),
(305, '2019-11-28 10:58:55', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 706),
(306, '2019-11-28 10:58:56', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 972),
(307, '2019-11-28 11:00:23', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 4641),
(308, '2019-11-28 11:00:27', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 952),
(309, '2019-11-28 11:00:34', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 683),
(310, '2019-11-28 11:00:34', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 984),
(311, '2019-11-28 08:01:17', '95.70.213.113', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(312, '2019-11-28 11:02:18', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 691),
(313, '2019-11-28 11:02:18', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 952),
(314, '2019-11-28 11:02:20', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 673),
(315, '2019-11-28 11:02:21', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1051),
(316, '2019-11-28 11:04:27', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 1043),
(317, '2019-11-28 11:04:28', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 46628),
(318, '2019-11-28 11:05:32', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 944),
(319, '2019-11-28 11:05:33', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 0),
(320, '2019-11-28 11:07:21', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 20392),
(321, '2019-11-28 11:07:45', '::1', '/sponsorlar', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 3506),
(322, '2019-11-28 11:07:49', '::1', '/', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 16427),
(323, '2019-11-28 11:08:35', '::1', '/sponsorlar', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 8761),
(324, '2019-11-28 11:08:46', '::1', '/iletisim', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 6114),
(325, '2019-11-28 11:15:48', '::1', '/Iletisim/Kaydet', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 2588),
(326, '2019-11-28 11:15:51', '::1', '/favicon.ico', NULL, 'Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.97 Safari/537.36 OPR/65.0.3467.48', 200, 960),
(327, '2019-11-28 11:16:24', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 1224),
(328, '2019-11-28 11:16:59', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 691),
(329, '2019-11-28 11:17:13', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 674),
(330, '2019-11-28 11:17:44', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 674),
(331, '2019-11-28 11:18:29', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 1218),
(332, '2019-11-28 11:18:40', '::1', '/Iletisim/Kaydet', NULL, 'PostmanRuntime/7.20.1', 200, 0);

-- --------------------------------------------------------

--
-- Table structure for table `Menu`
--

CREATE TABLE `Menu` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `Isim` text COLLATE utf8_unicode_ci NOT NULL,
  `Url` text COLLATE utf8_unicode_ci,
  `Sira` int(11) NOT NULL,
  `Tip` int(11) NOT NULL,
  `UstId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Menu`
--

INSERT INTO `Menu` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `Isim`, `Url`, `Sira`, `Tip`, `UstId`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 'Anasayfa', '/', 1, 1, NULL),
(2, 0, '2019-01-01 00:00:00', NULL, 'Etkinlikler', '/etkinlikler', 2, 2, NULL),
(3, 1, '2019-01-01 00:00:00', NULL, 'Kayıt ve Başvuru', '/kayit-ve-basvuru', 4, 1, NULL),
(4, 1, '2019-01-01 00:00:00', NULL, 'Blog', '/blog', 5, 2, NULL),
(5, 0, '2019-01-01 00:00:00', NULL, 'İletisim', '/iletisim', 7, 1, NULL),
(6, 0, '2019-01-01 00:00:00', NULL, 'Sponsorlar', '/sponsorlar', 8, 2, NULL),
(7, 1, '2019-01-01 00:00:00', NULL, 'Fotograf Galerilerimiz', '/fotograf-galerilerimiz', 6, 2, 4),
(8, 0, '2019-01-01 00:00:00', NULL, 'Haberler', '/haberler', 3, 2, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `Parametre`
--

CREATE TABLE `Parametre` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `Kodu` text COLLATE utf8_unicode_ci NOT NULL,
  `Isim` text COLLATE utf8_unicode_ci,
  `Aciklama` text COLLATE utf8_unicode_ci,
  `Tip` int(11) NOT NULL,
  `Sira` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `Parametre`
--

INSERT INTO `Parametre` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `Kodu`, `Isim`, `Aciklama`, `Tip`, `Sira`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 'logo', 'logo', 'logo', 2, 0),
(2, 0, '2019-01-01 00:00:00', NULL, 'logomobil', 'logomobil', 'logomobil', 2, 0),
(3, 0, '2019-01-01 00:00:00', NULL, 'baslik', 'Site Başlığı', 'Site Başlığı', 1, 0),
(4, 0, '2019-01-01 00:00:00', NULL, 'seokeywords', 'seokeywords', '', 1, 0),
(5, 0, '2019-01-01 00:00:00', NULL, 'seodescription', 'seodescription', '', 1, 0),
(6, 0, '2019-01-01 00:00:00', NULL, 'seoauthor', 'seoauthor', 'seoauthor', 1, 0),
(7, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik1', 'Anasayfa Alt Başlık 1', '', 1, 0),
(8, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik1aciklama', 'Anasayfa Alt Başlık 1 Açıklama', '', 1, 0),
(9, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik2', 'Anasayfa Alt Başlık 2', '', 1, 0),
(10, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik2aciklama', 'Anasayfa Alt Başlık 2 Açıklama', '', 1, 0),
(11, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik3', 'Anasayfa Alt Başlık 3', '', 1, 0),
(12, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik3aciklama', 'Anasayfa Alt Başlık 3 Açıklama', '', 1, 0),
(13, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik4', 'Anasayfa Alt Başlık 4', '', 1, 0),
(14, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik4aciklama', 'Anasayfa Alt Başlık 4 Açıklama', '', 1, 0),
(15, 0, '2019-01-01 00:00:00', NULL, 'anasayfaaltbaslik4link', 'Anasayfa Alt Başlık 4 link', '', 1, 0),
(16, 0, '2019-01-01 00:00:00', NULL, 'telefon', 'Telefon', '', 1, 0),
(17, 0, '2019-01-01 00:00:00', NULL, 'eposta', 'Eposta', '', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `ParametreDegeri`
--

CREATE TABLE `ParametreDegeri` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `ParametreId` int(11) NOT NULL,
  `Deger` text COLLATE utf8_unicode_ci,
  `DegerInt` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `ParametreDegeri`
--

INSERT INTO `ParametreDegeri` (`Id`, `Sil`, `Tarih`, `KullaniciId`, `ParametreId`, `Deger`, `DegerInt`) VALUES
(1, 0, '2019-01-01 00:00:00', NULL, 6, 'İnönü Üniversitesi Girişimcilik Toplulugu', 0),
(2, 0, '2019-01-01 00:00:00', NULL, 5, 'İnönü Üniversitesi Girişimclik Toplulugu', 0),
(3, 0, '2019-01-01 00:00:00', NULL, 4, 'inönü, üniversites, girişimcilik, toplulugu', 0),
(4, 0, '2019-01-01 00:00:00', NULL, 3, 'İnönü Üniversitesi Girişimcilik Topluluğu', 0),
(5, 0, '2019-01-01 00:00:00', NULL, 2, '20191126190517.png', 10),
(6, 0, '2019-01-01 00:00:00', NULL, 1, '20191126190535.png', 11),
(7, 0, '2019-01-01 00:00:00', NULL, 8, 'Anasayfa Alt Başlık 1', 0),
(8, 0, '2019-01-01 00:00:00', NULL, 7, 'Anasayfa Alt Başlık 1', 0),
(9, 0, '2019-01-01 00:00:00', NULL, 8, 'Anasayfa Alt Başlık 1 Açıklama', 0),
(10, 0, '2019-01-01 00:00:00', NULL, 9, 'Anasayfa Alt Başlık 2', 0),
(11, 0, '2019-01-01 00:00:00', NULL, 10, 'Anasayfa Alt Başlık 2', 0),
(12, 0, '2019-01-01 00:00:00', NULL, 11, 'Anasayfa Alt Başlık 3', 0),
(13, 0, '2019-01-01 00:00:00', NULL, 12, 'Anasayfa Alt Başlık 3 Açıklama', 0),
(14, 0, '2019-01-01 00:00:00', NULL, 13, 'Anasayfa Alt Başlık 4', 0),
(15, 0, '2019-01-01 00:00:00', NULL, 14, 'Anasayfa Alt Başlık 4 Açıklama', 0),
(16, 0, '2019-01-01 00:00:00', NULL, 15, '/', 0),
(17, 0, '2019-01-01 00:00:00', NULL, 16, '0541 234 56 78', 0),
(18, 0, '2019-01-01 00:00:00', NULL, 17, 'eposta@eposta.com', 0);

-- --------------------------------------------------------

--
-- Table structure for table `Uyeler`
--

CREATE TABLE `Uyeler` (
  `Id` int(11) NOT NULL,
  `Sil` smallint(6) NOT NULL,
  `Tarih` datetime NOT NULL,
  `KullaniciId` int(11) DEFAULT NULL,
  `AdSoyad` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Email` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Telefon` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `Cinsiyet` smallint(6) NOT NULL,
  `DogumTarihi` datetime NOT NULL,
  `Bolum` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Hakkinda` varchar(250) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20191125204533_initial', '2.2.6-servicing-10079'),
('20191126075138_iceriktipiint', '2.2.6-servicing-10079'),
('20191126105221_iceriktiplerisira', '2.2.6-servicing-10079'),
('20191126161233_iceriklongisim', '2.2.6-servicing-10079');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Dosyalar`
--
ALTER TABLE `Dosyalar`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `FotografGalerisi`
--
ALTER TABLE `FotografGalerisi`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_FotografGalerisi_FotografGalerisiDosyaId` (`FotografGalerisiDosyaId`),
  ADD KEY `IX_FotografGalerisi_IcerikId` (`IcerikId`);

--
-- Indexes for table `FotografGalerisiDosyalar`
--
ALTER TABLE `FotografGalerisiDosyalar`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_FotografGalerisiDosyalar_DosyaId` (`DosyaId`);

--
-- Indexes for table `Icerikler`
--
ALTER TABLE `Icerikler`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Icerikler_MenuId` (`MenuId`),
  ADD KEY `IX_Icerikler_ResimId` (`ResimId`),
  ADD KEY `IX_Icerikler_YazarId` (`YazarId`);

--
-- Indexes for table `IcerikTipDegerleri`
--
ALTER TABLE `IcerikTipDegerleri`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_IcerikTipDegerleri_IcerikTipiId` (`IcerikTipiId`);

--
-- Indexes for table `IcerikTipleri`
--
ALTER TABLE `IcerikTipleri`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Iletisim`
--
ALTER TABLE `Iletisim`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Kullanicilar`
--
ALTER TABLE `Kullanicilar`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Loggers`
--
ALTER TABLE `Loggers`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Menu`
--
ALTER TABLE `Menu`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Menu_UstId` (`UstId`);

--
-- Indexes for table `Parametre`
--
ALTER TABLE `Parametre`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `ParametreDegeri`
--
ALTER TABLE `ParametreDegeri`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ParametreDegeri_ParametreId` (`ParametreId`);

--
-- Indexes for table `Uyeler`
--
ALTER TABLE `Uyeler`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Dosyalar`
--
ALTER TABLE `Dosyalar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `FotografGalerisi`
--
ALTER TABLE `FotografGalerisi`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `FotografGalerisiDosyalar`
--
ALTER TABLE `FotografGalerisiDosyalar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `Icerikler`
--
ALTER TABLE `Icerikler`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `IcerikTipDegerleri`
--
ALTER TABLE `IcerikTipDegerleri`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT for table `IcerikTipleri`
--
ALTER TABLE `IcerikTipleri`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `Iletisim`
--
ALTER TABLE `Iletisim`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Kullanicilar`
--
ALTER TABLE `Kullanicilar`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `Loggers`
--
ALTER TABLE `Loggers`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=333;

--
-- AUTO_INCREMENT for table `Menu`
--
ALTER TABLE `Menu`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `Parametre`
--
ALTER TABLE `Parametre`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `ParametreDegeri`
--
ALTER TABLE `ParametreDegeri`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `Uyeler`
--
ALTER TABLE `Uyeler`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `FotografGalerisi`
--
ALTER TABLE `FotografGalerisi`
  ADD CONSTRAINT `FK_FotografGalerisiDosyaId` FOREIGN KEY (`FotografGalerisiDosyaId`) REFERENCES `FotografGalerisiDosyalar` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_FotografGalerisi_Icerikler_IcerikId` FOREIGN KEY (`IcerikId`) REFERENCES `Icerikler` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `FotografGalerisiDosyalar`
--
ALTER TABLE `FotografGalerisiDosyalar`
  ADD CONSTRAINT `FK_FotografGalerisiDosyalar_Dosyalar_DosyaId` FOREIGN KEY (`DosyaId`) REFERENCES `Dosyalar` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `Icerikler`
--
ALTER TABLE `Icerikler`
  ADD CONSTRAINT `FK_Icerikler_Dosyalar_ResimId` FOREIGN KEY (`ResimId`) REFERENCES `Dosyalar` (`id`) ON DELETE RESTRICT,
  ADD CONSTRAINT `FK_Icerikler_Kullanicilar_YazarId` FOREIGN KEY (`YazarId`) REFERENCES `Kullanicilar` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Icerikler_Menu_MenuId` FOREIGN KEY (`MenuId`) REFERENCES `Menu` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `IcerikTipDegerleri`
--
ALTER TABLE `IcerikTipDegerleri`
  ADD CONSTRAINT `FK_IcerikTipDegerleri_IcerikTipleri_IcerikTipiId` FOREIGN KEY (`IcerikTipiId`) REFERENCES `IcerikTipleri` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `Menu`
--
ALTER TABLE `Menu`
  ADD CONSTRAINT `FK_Menu_Menu_UstId` FOREIGN KEY (`UstId`) REFERENCES `Menu` (`id`) ON DELETE RESTRICT;

--
-- Constraints for table `ParametreDegeri`
--
ALTER TABLE `ParametreDegeri`
  ADD CONSTRAINT `FK_ParametreDegeri_Parametre_ParametreId` FOREIGN KEY (`ParametreId`) REFERENCES `Parametre` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
