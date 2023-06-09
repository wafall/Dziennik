USE [librusprogram]
GO
/****** Object:  Table [dbo].[nauczyciel]    Script Date: 20.04.2023 09:25:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nauczyciel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[imie] [text] NOT NULL,
	[nazwisko] [text] NOT NULL,
	[adres_email] [text] NOT NULL,
	[haslo] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oceny]    Script Date: 20.04.2023 09:25:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oceny](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_nauczyciela] [int] NOT NULL,
	[Id_ucznia] [int] NOT NULL,
	[ocena] [int] NOT NULL,
	[temat_oceny] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uczniowie]    Script Date: 20.04.2023 09:25:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uczniowie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[imie] [text] NOT NULL,
	[nazwisko] [text] NOT NULL,
	[adres_email] [text] NOT NULL,
	[haslo] [text] NOT NULL,
	[id_rodzica] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uwagi]    Script Date: 20.04.2023 09:25:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uwagi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_nauczyciela] [int] NOT NULL,
	[Id_ucznia] [int] NOT NULL,
	[uwaga] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[nauczyciel] ON 

INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (1, N'Jan', N'Kowalski', N'jan.kowalski@example.com', N'qwerty123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (2, N'Maria', N'Nowak', N'maria.nowak@example.com', N'haslo123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (3, N'Piotr', N'Jankowski', N'piotr.jankowski@example.com', N'password1')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (4, N'Anna', N'Wojciechowska', N'anna.wojciechowska@example.com', N'pass123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (5, N'Tomasz', N'Lewandowski', N'tomasz.lewandowski@example.com', N'pass123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (6, N'Iwona', N'Krawczyk', N'iwona.krawczyk@example.com', N'password1')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (7, N'Katarzyna', N'Kaczmarek', N'katarzyna.kaczmarek@example.com', N'qwerty123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (8, N'Adam', N'Michalski', N'adam.michalski@example.com', N'haslo123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (9, N'Ewa', N'Kozłowska', N'ewa.kozlowska@example.com', N'qwerty123')
INSERT [dbo].[nauczyciel] ([ID], [imie], [nazwisko], [adres_email], [haslo]) VALUES (10, N'Michał', N'Zając', N'michal.zajac@example.com', N'password1')
SET IDENTITY_INSERT [dbo].[nauczyciel] OFF
GO
SET IDENTITY_INSERT [dbo].[oceny] ON 

INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (1, 1, 1, 4, N'Matematyka')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (2, 1, 2, 5, N'Historia')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (3, 1, 3, 3, N'Język polski')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (4, 2, 1, 5, N'Matematyka')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (5, 2, 2, 3, N'Fizyka')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (6, 2, 3, 4, N'Biologia')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (7, 3, 1, 2, N'Wychowanie fizyczne')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (8, 3, 2, 4, N'Informatyka')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (9, 3, 3, 5, N'Język angielski')
INSERT [dbo].[oceny] ([ID], [Id_nauczyciela], [Id_ucznia], [ocena], [temat_oceny]) VALUES (10, 4, 1, 3, N'Historia')
SET IDENTITY_INSERT [dbo].[oceny] OFF
GO
SET IDENTITY_INSERT [dbo].[uczniowie] ON 

INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (1, N'Aleksandra', N'Nowak', N'aleksandra.nowak@example.com', N'password1', 1)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (2, N'Bartosz', N'Kowalczyk', N'bartosz.kowalczyk@example.com', N'qwerty123', 1)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (3, N'Monika', N'Mazur', N'monika.mazur@example.com', N'haslo123', 2)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (4, N'Kacper', N'Wójcik', N'kacper.wojcik@example.com', N'password1', 2)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (5, N'Magdalena', N'Kamińska', N'magdalena.kaminska@example.com', N'qwerty123', 3)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (6, N'Szymon', N'Kowalewski', N'szymon.kowalewski@example.com', N'password1', 3)
INSERT [dbo].[uczniowie] ([ID], [imie], [nazwisko], [adres_email], [haslo], [id_rodzica]) VALUES (7, N'Wiktoria', N'Lis', N'wiktoria.lis@example.com', N'haslo123', 4)
SET IDENTITY_INSERT [dbo].[uczniowie] OFF
GO
SET IDENTITY_INSERT [dbo].[uwagi] ON 

INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (1, 2, 3, N'Brak zrobionych zadań domowych.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (2, 5, 1, N'Nieprzygotowanie na lekcję.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (3, 4, 2, N'Nieodpowiednie zachowanie podczas lekcji.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (4, 1, 7, N'Nieprawidłowe ubranie.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (5, 3, 9, N'Brak aktywności podczas zajęć.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (6, 2, 6, N'Opóźnienie do szkoły.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (7, 5, 8, N'Nieodpowiednia mowa podczas zajęć.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (8, 4, 10, N'Nieodpowiednie zachowanie wobec nauczyciela.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (9, 1, 4, N'Nieprzestrzeganie regulaminu szkolnego.')
INSERT [dbo].[uwagi] ([ID], [Id_nauczyciela], [Id_ucznia], [uwaga]) VALUES (10, 3, 5, N'Użycie telefonu podczas zajęć.')
SET IDENTITY_INSERT [dbo].[uwagi] OFF
GO
