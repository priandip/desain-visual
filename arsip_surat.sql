-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 22 Nov 2017 pada 08.51
-- Versi Server: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `arsip_surat`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `arsip`
--

CREATE TABLE `arsip` (
  `no_arsip` varchar(20) NOT NULL,
  `no_surat` varchar(20) NOT NULL,
  `lokasi_arsip` varchar(40) NOT NULL,
  `keterangan` varchar(40) NOT NULL,
  `tgl_arsip` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `surat_keluar`
--

CREATE TABLE `surat_keluar` (
  `no_surat` varchar(20) NOT NULL,
  `perihal` varchar(40) NOT NULL,
  `tgl_kirim` date NOT NULL,
  `tgl_surat` date NOT NULL,
  `lampiran` varchar(40) NOT NULL,
  `tembusan` varchar(200) NOT NULL,
  `kepada` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `surat_keluar`
--

INSERT INTO `surat_keluar` (`no_surat`, `perihal`, `tgl_kirim`, `tgl_surat`, `lampiran`, `tembusan`, `kepada`) VALUES
('1242', 'surat tugas', '2017-11-22', '0000-00-00', '1242.txt', 'ooo', 'ad'),
('12a', 'surat tugas', '2017-11-22', '0000-00-00', '12a.txt', 'norman dkk', 'guna'),
('69', 'Ah!', '2017-11-22', '0000-00-00', '69.txt', 'Ah!', 'Koko');

-- --------------------------------------------------------

--
-- Struktur dari tabel `surat_masuk`
--

CREATE TABLE `surat_masuk` (
  `no_surat` varchar(20) NOT NULL,
  `perihal` varchar(40) NOT NULL,
  `pengirim` varchar(20) NOT NULL,
  `tgl_surat` date NOT NULL,
  `tgl_terima` date NOT NULL,
  `lampiran` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `surat_masuk`
--

INSERT INTO `surat_masuk` (`no_surat`, `perihal`, `pengirim`, `tgl_surat`, `tgl_terima`, `lampiran`) VALUES
('099', 'tugas tugas', 'norman1', '2017-11-22', '2017-11-22', '099.txt'),
('123', 'tugas', 'norman', '2017-11-22', '2017-11-22', '123.txt'),
('123123123', '12313123111', 'batok', '2017-11-22', '2017-11-22', '123123123.txt');

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('direktur', 'direktur'),
('pegawai', 'pegawai');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `arsip`
--
ALTER TABLE `arsip`
  ADD PRIMARY KEY (`no_arsip`);

--
-- Indexes for table `surat_keluar`
--
ALTER TABLE `surat_keluar`
  ADD PRIMARY KEY (`no_surat`);

--
-- Indexes for table `surat_masuk`
--
ALTER TABLE `surat_masuk`
  ADD PRIMARY KEY (`no_surat`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
