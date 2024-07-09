----------------------------------
-- Creación de la base de datos
----------------------------------
USE master
go

IF EXISTS ( SELECT name FROM sysdatabases WHERE name = 'Heresi' )
	DROP DATABASE Heresi
go

CREATE DATABASE Heresi ON PRIMARY 
          (NAME = Heresi_Data, 
           FILENAME = 'D:\SHeresi\BD\HeresiData.mdf', 
           SIZE = 10MB, 
           MAXSIZE = 15MB, 
           FILEGROWTH = 10%)
           LOG ON 
          (NAME = Heresi_Log, 
           FILENAME = 'D:\SHeresi\BD\HeresiLog.ldf', 
           SIZE = 4MB, 
           MAXSIZE = 6MB, 
           FILEGROWTH = 10%) 
go
USE Heresi
go
SET DATEFORMAT dmy
go

----------------------------
-- Creación de las tablas
----------------------------
CREATE TABLE HRACLI (
        NroHra          int NOT NULL,
        NroIng          int NULL,
        FecHra    	datetime DEFAULT getdate(),
	SinTma		varchar(500)NULL,
        IdDiag		Varchar(15) NULL,
	FecIng		datetime NULL,
	FecEgr		datetime NULL,
	TieHos		int NULL,
	IdTiph		int NULL,
	IdCond		int NULL,
	IdPcte		int NOT NULL)
	
go

ALTER TABLE HRACLI
	ADD PRIMARY KEY (NroHra)
go

CREATE TABLE TABPAC (
        IdPcte          int IDENTITY,
        ApePat          varchar(50) NULL,
        ApeMat    	varchar(50) NULL,
	NomPac		varchar(100)NOT NULL,
	SexPac		char(1) NOT NULL,
        FecNac		datetime NULL,
	IdDist		int NULL,	
	IdProv		int NULL,	
	IdDpto		int NULL,
	DomPac		varchar(100)NULL,	
	IDRelg		int NULL,
	IDEciv		int NULL,
	IdOcup		int NULL,
	CenTra		Varchar(100) NULL,
	TieDes		int NULL,
	TieRes		int NULL,
	IDGins		int NULL,
	IdDocu		int NULL,
	NumDoc		int NULL,
	IdIdma		int NULL,
	RefPor		varchar(100) NULL,
	AppApo		varchar(50) NULL,		
	ApmApo		varchar(50) NULL,		
	NomApo		varchar(50) NULL,		
	DirApo		varchar(100) NULL,		
	TelApo		int NULL)
	
go

ALTER TABLE TABPAC
	ADD PRIMARY KEY (IdPcte)
go

CREATE TABLE CABPARTDIA (
	IdPart		int IDENTITY,
	IdDoct		int NOT NULL,
	FecPar		datetime DEFAULT getdate(),	
)
go
ALTER TABLE CABPARTDIA
	ADD PRIMARY KEY (IdPart)
go
CREATE TABLE DETPARTDIA (
	IdPart		int NOT NULL,
	NroHra		int NOT NULL,
	IdcPac		int NOT NULL,
	IdDiag		Varchar(15) NOT NULL,
	IdTipPac	int NOT NULL,
	IdEnfm		int NOT NULL			
)
go
--Tablas Auxiliares y Llaves Primarias

	--Tipo Hospitalizacion
CREATE TABLE TIPHOSP (
	IdTiph		int IDENTITY,
	DesTiph		varchar(20)NULL,
)
go
ALTER TABLE TIPHOSP
	ADD PRIMARY KEY (IdTiph)
go

	--Condicion de Alta
CREATE TABLE TABCOND (
	IdCond		int IDENTITY,
	DesCond		varchar(20)NULL,
)
go
ALTER TABLE TABCOND
	ADD PRIMARY KEY (IdCond)
go
	--Tipos de pacientes segun sus pagos
CREATE TABLE TIPPAC (
	IdTipPac	int IDENTITY,
	CodTipPac	char(5)NOT NULL,
	DescTipPac	varchar(20)NULL,
)
go
ALTER TABLE TIPPAC
	ADD PRIMARY KEY (IdTipPac)
go
	--Continuidad de los Pacientes
CREATE TABLE CONTPAC (
	IdcPac		int IDENTITY,
	DescPac		varchar(20)NOT NULL,
)
go
ALTER TABLE CONTPAC
	ADD PRIMARY KEY (IdcPac)
go
	--Departamentos
CREATE TABLE TABDPTO (
	IdDpto		int NOT NULL,
	DesDpto		varchar(50)NOT NULL,
)
go
ALTER TABLE TABDPTO
	ADD PRIMARY KEY (IdDpto)
go
	--Provincias
CREATE TABLE TABPROV (
	IdDpto		int NOT NULL,
	IdProv		int NOT NULL,
	DesProv		varchar(50) NOT NULL,
)
go
ALTER TABLE TABPROV
	ADD PRIMARY KEY (IdDpto,IdProv)
go
	--Distritos
CREATE TABLE TABDIST (
	IdDpto		int Not NULL,	
	IdProv		int Not NULL,	
	IdDist		int NOT NULL,
	DesDist		varchar(50) NOT NULL,
)
go
ALTER TABLE TABDIST
	ADD PRIMARY KEY (IdDpto,IdProv,IdDist)
go
	--EstadoCivil
CREATE TABLE TABECIV (
	IdEciv		int IDENTITY,
	DesEciv		varchar(20) NOT NULL	
)
go
ALTER TABLE TABECIV
	ADD PRIMARY KEY (IdEciv)
go
	--Grado de Instruccion
CREATE TABLE TABGINS (
	IdGins		int IDENTITY,
	DesGins		varchar(20) NOT NULL	
)
go
ALTER TABLE TABGINS
	ADD PRIMARY KEY (IdGins)
go
	--Religion
CREATE TABLE TABRELG (
	IdRelg		int IDENTITY,
	DesRelg		varchar(20) NOT NULL	
)
go
ALTER TABLE TABRELG
	ADD PRIMARY KEY (IdRelg)
go
	--Documentos
CREATE TABLE TABDOCU (
	IdDocu		int IDENTITY,
	DesDocu		varchar(20) NOT NULL	
)
go
ALTER TABLE TABDOCU
	ADD PRIMARY KEY (IdDocu)
go
	--Idiomas
CREATE TABLE TABIDMA (
	IdIdma		int IDENTITY,
	DesIdma		varchar(20) NOT NULL	
)
go
ALTER TABLE TABIDMA
	ADD PRIMARY KEY (IdIdma)
go
	--Ocupaciones	
CREATE TABLE TABOCUP (
	IdOcup		int IDENTITY,
	DesOcup		varchar(50) NOT NULL	
)
go
ALTER TABLE TABOCUP
	ADD PRIMARY KEY (IdOcup)
go
	--Diagnosticos
CREATE TABLE TABDIAG (
	IdDiag		Varchar(15) NOT NULL,
	DesDiag		varchar(500) NOT NULL	
)
go
ALTER TABLE TABDIAG
	ADD PRIMARY KEY (IdDiag)
go
	--Doctores
CREATE TABLE TABDOCT (
	IdDoct		int IDENTITY,
	ApePat		varchar(50) NOT NULL,	
	ApeMat		varchar(50) NOT NULL,
	NomDoc		varchar(100) NOT NULL,
	IDDocu		int NOT NULL,
	NumDoc		int NOT NULL,
	Clave		varchar(20)NULL
)
go
ALTER TABLE TABDOCT
	ADD PRIMARY KEY (IdDoct)
go
	--Enfermeras
CREATE TABLE TABENFM (
	IdEnfm		int IDENTITY,
	ApePat		varchar(50) NOT NULL,	
	ApeMat		varchar(50) NOT NULL,
	NomEnf		varchar(100) NOT NULL,
	IDDocu		int NOT NULL,
	NumDoc		int NOT NULL,
	Clave		varchar(20)NULL
)
go
ALTER TABLE TABENFM
	ADD PRIMARY KEY (IdEnfm)
go

	--Relaciones e integridad referencial
--Query funcionable para borrar y actualizar en cascada
--ALTER TABLE TABDIST
--       ADD FOREIGN KEY(IdProv) 
--	REFERENCES TABPROV(IdProv) ON DELETE CASCADE ON UPDATE CASCADE	
--go
	-- Sobre la Tabla Distrito
ALTER TABLE TABDIST
        ADD FOREIGN KEY(IdDpto,IdProv) 
	REFERENCES TABPROV(IdDpto,IdProv) 
go
	-- Sobre la Tabla Provincias
ALTER TABLE TABPROV
        ADD FOREIGN KEY(IdDpto) 
	REFERENCES TABDPTO(IdDpto) 
go
	-- Sobre la Tabla Pacientes
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdDpto,IdProv,IdDist)
	REFERENCES TABDIST(IdDpto,IdProv,IdDist)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdEciv)
	REFERENCES TABECIV(IdEciv)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdGins)
	REFERENCES TABGINS(IdGins)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdRelg)
	REFERENCES TABRELG(IdRelg)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdDocu)
	REFERENCES TABDOCU(IdDocu)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdIdma)
	REFERENCES TABIDMA(IdIdma)
go
ALTER TABLE TABPAC
	ADD FOREIGN KEY(IdOcup)
	REFERENCES TABOCUP(IdOcup)
go
	-- Sobre la Tabla Historia Clinica
ALTER TABLE HRACLI
	ADD FOREIGN KEY(IdTiph)
	REFERENCES TIPHOSP(IdTiph)
go
ALTER TABLE HRACLI
	ADD FOREIGN KEY(IdCond)
	REFERENCES TABCOND(IdCond)
go
ALTER TABLE HRACLI
	ADD FOREIGN KEY(IdDiag)
	REFERENCES TABDIAG(IdDiag)
go
ALTER TABLE HRACLI
	ADD FOREIGN KEY(IdPcte)
	REFERENCES TABPAC(IdPcte)
go
	-- Sobre la Tabla Parte Diario
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(NroHra)
	REFERENCES HraCli(NroHra)
go
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(IdDiag)
	REFERENCES TABDIAG(IdDiag)
go
ALTER TABLE CABPARTDIA
	ADD FOREIGN KEY(IdDoct)
	REFERENCES TABDOCT(IdDoct)
go
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(IdEnfm)
	REFERENCES TABENFM(IdEnfm)
go
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(IdTipPac)
	REFERENCES TIPPAC(IdTipPac)
go
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(IdcPac)
	REFERENCES CONTPAC(IdcPac)
go
ALTER TABLE DETPARTDIA
	ADD FOREIGN KEY(IdPart)
	REFERENCES CABPARTDIA(IdPart)
go
	--Sobre la Tabla Doctores
ALTER TABLE TABDOCT
	ADD FOREIGN KEY(IdDocu)
	REFERENCES TABDOCU(IdDocu)
go
	--Sobre la Tabla Enfermeras
ALTER TABLE TABENFM
	ADD FOREIGN KEY(IdDocu)
	REFERENCES TABDOCU(IdDocu)
go





