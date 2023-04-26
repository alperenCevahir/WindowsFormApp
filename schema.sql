CREATE TABLE [Custodians] (
    [TcNo] int NOT NULL IDENTITY,
    [StudentId] int NOT NULL,
    [IsCustodian] bit NOT NULL,
    [IsFather] bit NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Surname] nvarchar(max) NOT NULL,
    [TelNo] int NULL,
    [Occupation] nvarchar(max) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [ParentsLiveTogether] bit NOT NULL,
    CONSTRAINT [PK_Custodians] PRIMARY KEY ([TcNo])
);
GO


CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Students] (
    [TcNo] int NOT NULL IDENTITY,
    [EmergencyId] int NOT NULL,
    [IsFatherAlive] bit NOT NULL,
    [IsMotherAlive] bit NOT NULL,
    [CustodianId] int NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Surname] nvarchar(max) NOT NULL,
    [TelNo] int NULL,
    [StudentGrade] int NOT NULL,
    [StudentClass] nvarchar(max) NOT NULL,
    [BirthPlaceAndYear] nvarchar(max) NOT NULL,
    [StudentGender] bit NOT NULL,
    [StartDate] datetime2 NOT NULL,
    [BloodType] nvarchar(max) NOT NULL,
    [Diseases] nvarchar(max) NULL,
    [Medicines] nvarchar(max) NULL,
    [School] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([TcNo]),
    CONSTRAINT [FK_Students_Custodians_CustodianId] FOREIGN KEY ([CustodianId]) REFERENCES [Custodians] ([TcNo]) ON DELETE CASCADE
);
GO


CREATE TABLE [Emergencies] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Surname] nvarchar(max) NOT NULL,
    [Relativity] nvarchar(max) NOT NULL,
    [TelNo] int NOT NULL,
    [EmergencyId] int NULL,
    CONSTRAINT [PK_Emergencies] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Emergencies_Students_EmergencyId] FOREIGN KEY ([EmergencyId]) REFERENCES [Students] ([TcNo])
);
GO


CREATE INDEX [IX_Emergencies_EmergencyId] ON [Emergencies] ([EmergencyId]);
GO


CREATE INDEX [IX_Students_CustodianId] ON [Students] ([CustodianId]);
GO


