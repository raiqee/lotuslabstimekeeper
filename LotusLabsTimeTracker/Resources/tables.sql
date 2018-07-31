DROP DATABASE LOTUS_LAB_TIMEKEEPER;
CREATE DATABASE LOTUS_LAB_TIMEKEEPER;
USE LOTUS_LAB_TIMEKEEPER;

DROP TABLE User;
DROP TABLE Module;
DROP TABLE Project;
DROP TABLE TaskType;
DROP TABLE UserType;
DROP TABLE WorkType;
DROP TABLE UserTask;

CREATE TABLE User (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    username varchar(50) NOT NULL, 
	password varchar(128) NOT NULL,
    first_name varchar(50) NOT NULL,
    middle_name varchar(50) NOT NULL,
    last_name varchar(50) NOT NULL,
    email varchar(50) NOT NULL,
	userType_id mediumint NOT NULL,
	last_login datetime,
    validated TINYINT DEFAULT 0,
	invalid_login MEDIUMINT NOT NULL,
    activeFlag TINYINT DEFAULT 1,
    createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id)
);


CREATE TABLE Module (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    code varchar(50) NOT NULL, 
	name varchar(50) NOT NULL,
    description varchar(255),
    activeFlag TINYINT DEFAULT 1,
	createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id)
);

CREATE TABLE Project (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    code varchar(50) NOT NULL, 
	name varchar(50) NOT NULL,
    description varchar(255),
    activeFlag TINYINT DEFAULT 1,
	createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id)
);

CREATE TABLE TaskType (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    code varchar(50) NOT NULL, 
	name varchar(50) NOT NULL,
    description varchar(255),
    activeFlag TINYINT DEFAULT 1,
	createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id)
);

CREATE TABLE UserType (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    code varchar(50) NOT NULL, 
	name varchar(50) NOT NULL,
    description varchar(255),
    activeFlag TINYINT DEFAULT 1,
	createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id),
    UNIQUE (CODE)
);

CREATE TABLE WorkType (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    code varchar(50) NOT NULL, 
	name varchar(50) NOT NULL,
    description varchar(255),
    activeFlag TINYINT DEFAULT 1,
	createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
    PRIMARY KEY (id)
);

CREATE TABLE UserTask (
	id MEDIUMINT NOT NULL AUTO_INCREMENT,
    user_id MEDIUMINT NOT NULL,
    startDateTime datetime,
    endDateTime dateTime,
    project_id MEDIUMINT NOT NULL,
    module_id MEDIUMINT NOT NULL,
    taskType_id MEDIUMINT NOT NULL,
    workType_id MEDIUMINT NOT NULL,
    billable TINYINT DEFAULT 0,
    description varchar(255) NOT NULL,
    activeFlag TINYINT DEFAULT 1,
    createdBy MEDIUMINT NOT NULL,
	createdDate datetime NOT NULL,
	updatedBy MEDIUMINT NOT NULL,
	updatedDate datetime, 
	PRIMARY KEY (id)
);

INSERT INTO UserType (code, name, description, createdBy, createdDate, updatedBy, updatedDate)
VALUES ('RANK_AND_FILE', 'Rank and File', 'Account for rank and file users', 0, NOW(), 0, NOW());
INSERT INTO UserType (code, name, description, createdBy, createdDate, updatedBy, updatedDate)
VALUES ('SUPERVISOR', 'Supervisor', 'Account for supervisor users', 0, NOW(), 0, NOW());
INSERT INTO UserType (code, name, description, createdBy, createdDate, updatedBy, updatedDate)
VALUES ('QA_MANAGER', 'Manager', 'Account for QA Managers', 0, NOW(), 0, NOW());
INSERT INTO UserType (code, name, description, createdBy, createdDate, updatedBy, updatedDate)
VALUES ('ADMIN', 'Admin', 'Account for Admins', 0, NOW(), 0, NOW());

INSERT INTO user (username, password, first_name, middle_name, last_name, email, userType_id, last_Login, validated, invalid_login, activeFlag, createdBy, createdDate, updatedBy, updatedDate)
VALUES ('MBO18056', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Milca', 'Belga', 'Oliveros', 'milca@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('MCL18057', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Michael', 'Campos', 'Lim', 'michael.lim@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('JFE18058', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Joy', 'Flores', 'Esquivel', 'joy@admin.com', 3, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('AFL18059', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Anna', 'Franco', 'Lucas', 'anna.lucas@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('MMG18060', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Maye', 'Medes', 'Gallardo', 'mae.gallardo@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('RCS18062', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Renaleen', 'Cayang', 'Sobere', 'renaleen.sobere@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('JBJ18064', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Jeoffrey', 'Benitez', 'Jalac', 'jeoffrey.jalac@admin.com', 1, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('JCC18066', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Jun', 'Cabatay', 'Comple', 'jun.comple@admin.com', 1, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('KPF18067', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Krizzle', 'Paneda', 'Fontanos', 'krizzle.fontanos@admin.com', 1, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('BCM18068', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Bea', 'Castro', 'Macalindong', 'bea.macalindong@admin.com', 1, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('DTR18069', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Don', 'Toledo', 'Reyes', 'don.reyes@admin.com', 2, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('RPS18074', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Roldan', 'Panuelos', 'Saldaña', 'roldan.saldana@admin.com', 1, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW()),
('admin', 'jiobvVncxw07G9Z+6LtihKDKhLSYg6q3okeotXGQmco=', 'Lotus', 'Labs', 'Admin', 'admin@admin.com', 4, '0001-01-01 00:00:00', 0, 0, 1, 0, NOW(), 0, NOW());