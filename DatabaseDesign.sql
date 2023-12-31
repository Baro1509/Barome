--create database ProjectMessage;

use ProjectMessage;

drop table ProfilePic;
drop table ServerProfilePic;
drop table Role;
drop table Message;
drop table Participant;
drop table Channel;
drop table Server;
drop table UserInfo;

create table UserInfo(
	Id int primary key identity(1,1),
	DisplayName nvarchar(50),
	Username nvarchar(50) unique not null,
	Password nvarchar(50) not null,
	Birthday datetime not null,
	Bio nvarchar(100),
	CreatedAt datetime not null,
	UpdatedAt datetime not null,
	IsDeleted tinyint not null
)

create table Server(
	Id int primary key identity(1,1),
	Name nvarchar(50),
	CreatedAt datetime,
	UpdatedAt datetime,
	CreatorId int not null references UserInfo(Id),
	IsDeleted tinyint not null
)

create table Channel(
	Id int primary key identity(1,1),
	Name nvarchar(50),
	AppearOrder tinyint not null,
	IsDeleted tinyint not null,
	ServerId int not null references Server(Id)
)

create table Participant(
	UserId int not null references UserInfo(Id),
	ServerId int not null references Server(Id),
	JoinedDate datetime not null,
	isDeleted tinyint not null
)

create table Message(
	Id int primary key identity(1,1),
	SenderId int not null references UserInfo(Id),
	ChannelId int not null references Channel(Id),
	SendAt datetime not null,
	Type tinyint not null,
	Content nvarchar(MAX) not null,
	isDeleted tinyint not null,
	ParentId int
)

create table Role(
	Id int primary key identity(1,1),
	Name nvarchar(20) not null,
	Color varchar(6) not null,
	ServerId int not null references Server(Id)
)

create table ProfilePic(
	Id int primary key identity(1,1),
	UserId int not null references UserInfo(Id),
	ImageName varchar(max) not null,
	ImagePath varchar(max) not null
)

create table ServerProfilePic(
	Id int primary key identity(1,1),
	ServerId int not null references Server(Id),
	ImageName varchar(max) not null,
	ImagePath varchar(max) not null
)

alter table Message add foreign key (ParentId) references Message(Id)