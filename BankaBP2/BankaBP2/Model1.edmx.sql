
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2021 20:44:28
-- Generated from EDMX file: C:\Users\Lenovo\source\repos\BankaBP2\BankaBP2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Banka];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bankas'
CREATE TABLE [dbo].[Bankas] (
    [ID_Banka] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Filijalas'
CREATE TABLE [dbo].[Filijalas] (
    [ID_FIL] int IDENTITY(1,1) NOT NULL,
    [ADR_FIL] nvarchar(max)  NOT NULL,
    [BankaID_Banka] int  NOT NULL
);
GO

-- Creating table 'Sluzbeniks'
CREATE TABLE [dbo].[Sluzbeniks] (
    [JMBG_RAD] int IDENTITY(1,1) NOT NULL,
    [IME_RAD] nvarchar(max)  NOT NULL,
    [PRZ_RAD] nvarchar(max)  NOT NULL,
    [Filijala_ID_FIL] int  NOT NULL,
    [Filijala_BankaID_Banka] int  NOT NULL
);
GO

-- Creating table 'Klijents'
CREATE TABLE [dbo].[Klijents] (
    [JMBG_KLI] int IDENTITY(1,1) NOT NULL,
    [IME_KLI] nvarchar(max)  NOT NULL,
    [PRZ_KLI] nvarchar(max)  NOT NULL,
    [ZirantID_ZIR] int  NOT NULL,
    [PLT_KLI] int  NULL
);
GO

-- Creating table 'IzdatiKreditis'
CREATE TABLE [dbo].[IzdatiKreditis] (
    [KlijentJMBG_KLI] int  NOT NULL,
    [SluzbenikJMBG_RAD] int  NOT NULL,
    [OdobrenjeRISKID_KOMISIJE] int  NOT NULL,
    [OdobrenjeOdlukaID_ODLUKE] int  NOT NULL
);
GO

-- Creating table 'RISKs'
CREATE TABLE [dbo].[RISKs] (
    [ID_KOMISIJE] int IDENTITY(1,1) NOT NULL,
    [BR_CLANOVA] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Odlukas'
CREATE TABLE [dbo].[Odlukas] (
    [ID_ODLUKE] int IDENTITY(1,1) NOT NULL,
    [Odobreno] nvarchar(max)  NOT NULL,
    [DAT_ODLUKE] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Odobrenjes'
CREATE TABLE [dbo].[Odobrenjes] (
    [RISKID_KOMISIJE] int  NOT NULL,
    [OdlukaID_ODLUKE] int  NOT NULL
);
GO

-- Creating table 'Zirants'
CREATE TABLE [dbo].[Zirants] (
    [ID_ZIR] int IDENTITY(1,1) NOT NULL,
    [IME_ZIR] nvarchar(max)  NOT NULL,
    [PRZ_ZIR] nvarchar(max)  NOT NULL,
    [PLT_ZIR] int  NULL
);
GO

-- Creating table 'Gazdnistvoes'
CREATE TABLE [dbo].[Gazdnistvoes] (
    [ID_POS] int  NOT NULL,
    [POV] nvarchar(max)  NOT NULL,
    [NETO_POS] nvarchar(max)  NOT NULL,
    [Agro_ID_ZAHT] int  NOT NULL
);
GO

-- Creating table 'Kompanijas'
CREATE TABLE [dbo].[Kompanijas] (
    [ID_KOMP] int IDENTITY(1,1) NOT NULL,
    [NETO_KOMP] nvarchar(max)  NOT NULL,
    [Bizni_ID_ZAHT] int  NOT NULL
);
GO

-- Creating table 'Jemacs'
CREATE TABLE [dbo].[Jemacs] (
    [JMBG_JEM] int IDENTITY(1,1) NOT NULL,
    [IME_JEM] nvarchar(max)  NOT NULL,
    [PRZ_JEM] nvarchar(max)  NOT NULL,
    [PLT_JEM] nvarchar(max)  NOT NULL,
    [Kes_kredit_ID_ZAHT] int  NOT NULL
);
GO

-- Creating table 'Kredits'
CREATE TABLE [dbo].[Kredits] (
    [ID_ZAHT] int IDENTITY(1,1) NOT NULL,
    [VAL] nvarchar(max)  NOT NULL,
    [KOL_SRD] nvarchar(max)  NOT NULL,
    [DAT_IZD] nvarchar(max)  NOT NULL,
    [IzdatiKreditiKlijentJMBG_KLI] int  NOT NULL,
    [IzdatiKreditiSluzbenikJMBG_RAD] int  NOT NULL,
    [IzdatiKreditiOdobrenjeRISKID_KOMISIJE] int  NOT NULL,
    [IzdatiKreditiOdobrenjeOdlukaID_ODLUKE] int  NOT NULL,
    [tipKredita] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kredits_Agro'
CREATE TABLE [dbo].[Kredits_Agro] (
    [ID_ZAHT] int  NOT NULL
);
GO

-- Creating table 'Kredits_Biznis'
CREATE TABLE [dbo].[Kredits_Biznis] (
    [ID_ZAHT] int  NOT NULL
);
GO

-- Creating table 'Kredits_Kes_kredit'
CREATE TABLE [dbo].[Kredits_Kes_kredit] (
    [ID_ZAHT] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Banka] in table 'Bankas'
ALTER TABLE [dbo].[Bankas]
ADD CONSTRAINT [PK_Bankas]
    PRIMARY KEY CLUSTERED ([ID_Banka] ASC);
GO

-- Creating primary key on [ID_FIL], [BankaID_Banka] in table 'Filijalas'
ALTER TABLE [dbo].[Filijalas]
ADD CONSTRAINT [PK_Filijalas]
    PRIMARY KEY CLUSTERED ([ID_FIL], [BankaID_Banka] ASC);
GO

-- Creating primary key on [JMBG_RAD] in table 'Sluzbeniks'
ALTER TABLE [dbo].[Sluzbeniks]
ADD CONSTRAINT [PK_Sluzbeniks]
    PRIMARY KEY CLUSTERED ([JMBG_RAD] ASC);
GO

-- Creating primary key on [JMBG_KLI] in table 'Klijents'
ALTER TABLE [dbo].[Klijents]
ADD CONSTRAINT [PK_Klijents]
    PRIMARY KEY CLUSTERED ([JMBG_KLI] ASC);
GO

-- Creating primary key on [KlijentJMBG_KLI], [SluzbenikJMBG_RAD], [OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE] in table 'IzdatiKreditis'
ALTER TABLE [dbo].[IzdatiKreditis]
ADD CONSTRAINT [PK_IzdatiKreditis]
    PRIMARY KEY CLUSTERED ([KlijentJMBG_KLI], [SluzbenikJMBG_RAD], [OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE] ASC);
GO

-- Creating primary key on [ID_KOMISIJE] in table 'RISKs'
ALTER TABLE [dbo].[RISKs]
ADD CONSTRAINT [PK_RISKs]
    PRIMARY KEY CLUSTERED ([ID_KOMISIJE] ASC);
GO

-- Creating primary key on [ID_ODLUKE] in table 'Odlukas'
ALTER TABLE [dbo].[Odlukas]
ADD CONSTRAINT [PK_Odlukas]
    PRIMARY KEY CLUSTERED ([ID_ODLUKE] ASC);
GO

-- Creating primary key on [RISKID_KOMISIJE], [OdlukaID_ODLUKE] in table 'Odobrenjes'
ALTER TABLE [dbo].[Odobrenjes]
ADD CONSTRAINT [PK_Odobrenjes]
    PRIMARY KEY CLUSTERED ([RISKID_KOMISIJE], [OdlukaID_ODLUKE] ASC);
GO

-- Creating primary key on [ID_ZIR] in table 'Zirants'
ALTER TABLE [dbo].[Zirants]
ADD CONSTRAINT [PK_Zirants]
    PRIMARY KEY CLUSTERED ([ID_ZIR] ASC);
GO

-- Creating primary key on [ID_POS] in table 'Gazdnistvoes'
ALTER TABLE [dbo].[Gazdnistvoes]
ADD CONSTRAINT [PK_Gazdnistvoes]
    PRIMARY KEY CLUSTERED ([ID_POS] ASC);
GO

-- Creating primary key on [ID_KOMP] in table 'Kompanijas'
ALTER TABLE [dbo].[Kompanijas]
ADD CONSTRAINT [PK_Kompanijas]
    PRIMARY KEY CLUSTERED ([ID_KOMP] ASC);
GO

-- Creating primary key on [JMBG_JEM] in table 'Jemacs'
ALTER TABLE [dbo].[Jemacs]
ADD CONSTRAINT [PK_Jemacs]
    PRIMARY KEY CLUSTERED ([JMBG_JEM] ASC);
GO

-- Creating primary key on [ID_ZAHT] in table 'Kredits'
ALTER TABLE [dbo].[Kredits]
ADD CONSTRAINT [PK_Kredits]
    PRIMARY KEY CLUSTERED ([ID_ZAHT] ASC);
GO

-- Creating primary key on [ID_ZAHT] in table 'Kredits_Agro'
ALTER TABLE [dbo].[Kredits_Agro]
ADD CONSTRAINT [PK_Kredits_Agro]
    PRIMARY KEY CLUSTERED ([ID_ZAHT] ASC);
GO

-- Creating primary key on [ID_ZAHT] in table 'Kredits_Biznis'
ALTER TABLE [dbo].[Kredits_Biznis]
ADD CONSTRAINT [PK_Kredits_Biznis]
    PRIMARY KEY CLUSTERED ([ID_ZAHT] ASC);
GO

-- Creating primary key on [ID_ZAHT] in table 'Kredits_Kes_kredit'
ALTER TABLE [dbo].[Kredits_Kes_kredit]
ADD CONSTRAINT [PK_Kredits_Kes_kredit]
    PRIMARY KEY CLUSTERED ([ID_ZAHT] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BankaID_Banka] in table 'Filijalas'
ALTER TABLE [dbo].[Filijalas]
ADD CONSTRAINT [FK_BankaFilijala]
    FOREIGN KEY ([BankaID_Banka])
    REFERENCES [dbo].[Bankas]
        ([ID_Banka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BankaFilijala'
CREATE INDEX [IX_FK_BankaFilijala]
ON [dbo].[Filijalas]
    ([BankaID_Banka]);
GO

-- Creating foreign key on [Filijala_ID_FIL], [Filijala_BankaID_Banka] in table 'Sluzbeniks'
ALTER TABLE [dbo].[Sluzbeniks]
ADD CONSTRAINT [FK_FilijalaSluzbenik]
    FOREIGN KEY ([Filijala_ID_FIL], [Filijala_BankaID_Banka])
    REFERENCES [dbo].[Filijalas]
        ([ID_FIL], [BankaID_Banka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilijalaSluzbenik'
CREATE INDEX [IX_FK_FilijalaSluzbenik]
ON [dbo].[Sluzbeniks]
    ([Filijala_ID_FIL], [Filijala_BankaID_Banka]);
GO

-- Creating foreign key on [KlijentJMBG_KLI] in table 'IzdatiKreditis'
ALTER TABLE [dbo].[IzdatiKreditis]
ADD CONSTRAINT [FK_IzdatiKreditiKlijent]
    FOREIGN KEY ([KlijentJMBG_KLI])
    REFERENCES [dbo].[Klijents]
        ([JMBG_KLI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SluzbenikJMBG_RAD] in table 'IzdatiKreditis'
ALTER TABLE [dbo].[IzdatiKreditis]
ADD CONSTRAINT [FK_SluzbenikIzdatiKrediti]
    FOREIGN KEY ([SluzbenikJMBG_RAD])
    REFERENCES [dbo].[Sluzbeniks]
        ([JMBG_RAD])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SluzbenikIzdatiKrediti'
CREATE INDEX [IX_FK_SluzbenikIzdatiKrediti]
ON [dbo].[IzdatiKreditis]
    ([SluzbenikJMBG_RAD]);
GO

-- Creating foreign key on [RISKID_KOMISIJE] in table 'Odobrenjes'
ALTER TABLE [dbo].[Odobrenjes]
ADD CONSTRAINT [FK_RISKOdobrenje]
    FOREIGN KEY ([RISKID_KOMISIJE])
    REFERENCES [dbo].[RISKs]
        ([ID_KOMISIJE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OdlukaID_ODLUKE] in table 'Odobrenjes'
ALTER TABLE [dbo].[Odobrenjes]
ADD CONSTRAINT [FK_OdlukaOdobrenje]
    FOREIGN KEY ([OdlukaID_ODLUKE])
    REFERENCES [dbo].[Odlukas]
        ([ID_ODLUKE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OdlukaOdobrenje'
CREATE INDEX [IX_FK_OdlukaOdobrenje]
ON [dbo].[Odobrenjes]
    ([OdlukaID_ODLUKE]);
GO

-- Creating foreign key on [OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE] in table 'IzdatiKreditis'
ALTER TABLE [dbo].[IzdatiKreditis]
ADD CONSTRAINT [FK_OdobrenjeIzdatiKrediti]
    FOREIGN KEY ([OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE])
    REFERENCES [dbo].[Odobrenjes]
        ([RISKID_KOMISIJE], [OdlukaID_ODLUKE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OdobrenjeIzdatiKrediti'
CREATE INDEX [IX_FK_OdobrenjeIzdatiKrediti]
ON [dbo].[IzdatiKreditis]
    ([OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE]);
GO

-- Creating foreign key on [IzdatiKreditiKlijentJMBG_KLI], [IzdatiKreditiSluzbenikJMBG_RAD], [IzdatiKreditiOdobrenjeRISKID_KOMISIJE], [IzdatiKreditiOdobrenjeOdlukaID_ODLUKE] in table 'Kredits'
ALTER TABLE [dbo].[Kredits]
ADD CONSTRAINT [FK_IzdatiKreditiKredit]
    FOREIGN KEY ([IzdatiKreditiKlijentJMBG_KLI], [IzdatiKreditiSluzbenikJMBG_RAD], [IzdatiKreditiOdobrenjeRISKID_KOMISIJE], [IzdatiKreditiOdobrenjeOdlukaID_ODLUKE])
    REFERENCES [dbo].[IzdatiKreditis]
        ([KlijentJMBG_KLI], [SluzbenikJMBG_RAD], [OdobrenjeRISKID_KOMISIJE], [OdobrenjeOdlukaID_ODLUKE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IzdatiKreditiKredit'
CREATE INDEX [IX_FK_IzdatiKreditiKredit]
ON [dbo].[Kredits]
    ([IzdatiKreditiKlijentJMBG_KLI], [IzdatiKreditiSluzbenikJMBG_RAD], [IzdatiKreditiOdobrenjeRISKID_KOMISIJE], [IzdatiKreditiOdobrenjeOdlukaID_ODLUKE]);
GO

-- Creating foreign key on [Agro_ID_ZAHT] in table 'Gazdnistvoes'
ALTER TABLE [dbo].[Gazdnistvoes]
ADD CONSTRAINT [FK_AgroGazdnistvo]
    FOREIGN KEY ([Agro_ID_ZAHT])
    REFERENCES [dbo].[Kredits_Agro]
        ([ID_ZAHT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AgroGazdnistvo'
CREATE INDEX [IX_FK_AgroGazdnistvo]
ON [dbo].[Gazdnistvoes]
    ([Agro_ID_ZAHT]);
GO

-- Creating foreign key on [Bizni_ID_ZAHT] in table 'Kompanijas'
ALTER TABLE [dbo].[Kompanijas]
ADD CONSTRAINT [FK_BiznisKompanija]
    FOREIGN KEY ([Bizni_ID_ZAHT])
    REFERENCES [dbo].[Kredits_Biznis]
        ([ID_ZAHT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BiznisKompanija'
CREATE INDEX [IX_FK_BiznisKompanija]
ON [dbo].[Kompanijas]
    ([Bizni_ID_ZAHT]);
GO

-- Creating foreign key on [Kes_kredit_ID_ZAHT] in table 'Jemacs'
ALTER TABLE [dbo].[Jemacs]
ADD CONSTRAINT [FK_Kes_kreditJemac]
    FOREIGN KEY ([Kes_kredit_ID_ZAHT])
    REFERENCES [dbo].[Kredits_Kes_kredit]
        ([ID_ZAHT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Kes_kreditJemac'
CREATE INDEX [IX_FK_Kes_kreditJemac]
ON [dbo].[Jemacs]
    ([Kes_kredit_ID_ZAHT]);
GO

-- Creating foreign key on [ZirantID_ZIR] in table 'Klijents'
ALTER TABLE [dbo].[Klijents]
ADD CONSTRAINT [FK_ZirantKlijent]
    FOREIGN KEY ([ZirantID_ZIR])
    REFERENCES [dbo].[Zirants]
        ([ID_ZIR])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZirantKlijent'
CREATE INDEX [IX_FK_ZirantKlijent]
ON [dbo].[Klijents]
    ([ZirantID_ZIR]);
GO

-- Creating foreign key on [ID_ZAHT] in table 'Kredits_Agro'
ALTER TABLE [dbo].[Kredits_Agro]
ADD CONSTRAINT [FK_Agro_inherits_Kredit]
    FOREIGN KEY ([ID_ZAHT])
    REFERENCES [dbo].[Kredits]
        ([ID_ZAHT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_ZAHT] in table 'Kredits_Biznis'
ALTER TABLE [dbo].[Kredits_Biznis]
ADD CONSTRAINT [FK_Biznis_inherits_Kredit]
    FOREIGN KEY ([ID_ZAHT])
    REFERENCES [dbo].[Kredits]
        ([ID_ZAHT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID_ZAHT] in table 'Kredits_Kes_kredit'
ALTER TABLE [dbo].[Kredits_Kes_kredit]
ADD CONSTRAINT [FK_Kes_kredit_inherits_Kredit]
    FOREIGN KEY ([ID_ZAHT])
    REFERENCES [dbo].[Kredits]
        ([ID_ZAHT])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------