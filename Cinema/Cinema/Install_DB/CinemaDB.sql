CREATE TABLE [Cinema] (
	ID_Cinema int NOT NULL,
	_Name nvarchar(30) NOT NULL,
	Phone nvarchar(20) NOT NULL,
	Contact nvarchar(30) NOT NULL,
  CONSTRAINT [PK_CINEMA] PRIMARY KEY CLUSTERED
  (
  [ID_Cinema] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Movies] (
	ID_Cinema int NOT NULL,
	ID_Film int NOT NULL,
	Title nvarchar(30) NOT NULL,
	Actors nvarchar(50) NOT NULL,
	Genre nvarchar(30) NOT NULL,
	Duration int NOT NULL,
  CONSTRAINT [PK_MOVIES] PRIMARY KEY CLUSTERED
  (
  [ID_Film] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [CinemaHall] (
	ID_Cinema int NOT NULL,
	ID_Hall int NOT NULL,
	Color nvarchar(20) NOT NULL,
	_3D bit DEFAULT '0',
  CONSTRAINT [PK_CINEMAHALL] PRIMARY KEY CLUSTERED
  (
  [ID_Hall] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Tickets] (
	ID_Ticket int NOT NULL,
	ID_Film int NOT NULL,
	_Row int NOT NULL,
	Place int NOT NULL,
	Bought bit DEFAULT '0',
	Booked bit DEFAULT '0',
  CONSTRAINT [PK_TICKETS] PRIMARY KEY CLUSTERED
  (
  [ID_Ticket] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Movies] WITH CHECK ADD CONSTRAINT [Movies_fk0] FOREIGN KEY ([ID_Cinema]) REFERENCES [Cinema]([ID_Cinema])
ON UPDATE CASCADE
GO
ALTER TABLE [Movies] CHECK CONSTRAINT [Movies_fk0]
GO

ALTER TABLE [CinemaHall] WITH CHECK ADD CONSTRAINT [CinemaHall_fk0] FOREIGN KEY ([ID_Cinema]) REFERENCES [Cinema]([ID_Cinema])
ON UPDATE CASCADE
GO
ALTER TABLE [CinemaHall] CHECK CONSTRAINT [CinemaHall_fk0]
GO

ALTER TABLE [Tickets] WITH CHECK ADD CONSTRAINT [Tickets_fk0] FOREIGN KEY ([ID_Film]) REFERENCES [Movies]([ID_Film])
ON UPDATE CASCADE
GO
ALTER TABLE [Tickets] CHECK CONSTRAINT [Tickets_fk0]
GO

create procedure AddCinema
	@id_cinema int,
	@_name nchar(30),
	@phone nchar(20),
	@contact nchar(30)	
	as
	begin
		insert into Cinema
		(ID_Cinema,_Name,Phone,Contact)
		values
			(@id_cinema,@_name,@phone,@contact)
	end
	
go
create procedure AddHall
	@id_cinema int,
	@id_hall int,
	@color nchar(20),
	@_3d bit
	as
	begin
		insert into CinemaHall
		(ID_Cinema,ID_Hall,Color,_3D)
		values
		(@id_cinema,@id_hall,@color,@_3d)
	end

go
create procedure AddMovies
	@id_cinema int,
	@id_film int,
	@title nchar(30),
	@actors nchar(50),
	@genre nchar(30),
	@duration int
	as
	begin
	insert into Movies
		(ID_Cinema,ID_Film,Title,Actors,Genre,Duration)
		values
		(@id_cinema,@id_film,@title,@actors,@genre,@duration)
	end

go
create procedure AddTicket
	@id_ticket int,
	@id_film int,
	@_row int,
	@place int,
	@bought bit,
	@booked bit
	as
	begin
		insert into Tickets
		(ID_Ticket,ID_Film,_Row,Place,Bought,Booked)
		values
		(@id_ticket,@id_film,@_row,@place,@bought,@booked)
	end

go 
create view Films as
	select Cinema._Name as "Имя кинотеатра",
			Movies.title as "Название фильма"
	from cinema inner join Movies on
	Cinema.id_cinema = movies.id_cinema
			