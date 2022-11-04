
create table Laboralidad
(id_laboralidad int identity(1,1),
descripcion varchar (60)
constraint pk_id_laboralidad primary key (id_laboralidad))

create table Habitacionalidad
(id_habitacionalidad int identity (1,1),
descripcion varchar(50)
constraint pk_habitacionalidad primary key (id_habitacionalidad)) 



create table provincias(
id_provincia int identity(1,1),
nombre	varchar(50)
constraint	pk_provincia primary key (id_provincia))

create table ciudades(
id_ciudades int identity(1,1),
nombre	varchar(50),
id_provincia int
constraint	pk_ciudades primary key (id_ciudades),
constraint	fk_provincia foreign key(id_provincia)
references provincias(id_provincia))

create table barrios(
id_barrio int identity(1,1),
nombre	varchar(50),
id_ciudades int
constraint	pk_barrios primary key (id_barrio),
constraint	fk_ciudades foreign key(id_ciudades)
references ciudades(id_ciudades))

--create table calles(
--id_calle int identity(1,1),
--nombre	varchar(50),
--id_barrios int
--constraint	pk_calle primary key (id_calle),
--constraint	fk_barrios foreign key(id_barrios)
--references barrios(id_barrios))

create table estados_civiles(
id_estado_civil int identity(1,1),
descripcion varchar(50)
constraint	pk_estado_civil primary key (id_estado_civil))

create table turnos(
id_turno int identity(1,1),
descripcion varchar(40)
constraint	pk_turno primary key (id_turno))

create table cursos(
id_curso int identity(1,1),
nombre varchar(50),
id_turno int
constraint	pk_curso primary key (id_curso)
constraint fk_turno foreign key (id_turno)
references turnos (id_turno))

create table carreras(
id_carrera	int	identity(1,1),
nombre	varchar(50)
constraint	pk_carrera primary key (id_carrera))

--create table personas(
--id_persona int identity(1,1),
--nombre varchar(50),
--apellido varchar(50),
--fecha_nac datetime,
--dni smallint,
--e_mail varchar(100),
--telefono smallint,
--id_calle int,
--altura int,
--sexo int  ---para manejarlo con enum?
--constraint pk_persona primary key(id_persona),
--constraint	fk_calle foreign key(id_calle)
--references calles(id_calle))

create table alumnos(
legajo int identity (900,1),
nombre varchar(50),
apellido varchar(50),
fecha_nac datetime,
dni bigint,
e_mail varchar(100),
telefono bigint,
calle varchar(100),
altura int,
sexo int,
id_curso int,
id_carrera int,
fecha_insc datetime,
id_estado_civil int,
id_laboralidad int,
id_habitacionalidad int,
id_barrio int
constraint pk_legajo primary key(legajo),
constraint fk_barrio foreign key (id_barrio)
references barrios(id_barrio),
constraint	fk_cursos foreign key(id_curso)
references cursos(id_curso),
constraint	fk_carrea foreign key(id_carrera)
references carreras(id_carrera),
constraint	fk_estado_civil foreign key(id_estado_civil)
references estados_civiles(id_estado_civil),
constraint	fk_laboralidad foreign key(id_laboralidad)
references laboralidad (id_laboralidad),
constraint	fk_curso foreign key(id_curso)
references cursos(id_curso),
constraint	fk_habitacionalidad foreign key(id_habitacionalidad)
references habitacionalidad(id_habitacionalidad))

create table materias(
id_materia	int	identity(1,1),
nombre	varchar(50),
promocionable	bit
constraint pk_materia primary key(id_materia))


--create table contenidos(
--id_materia	int,
--id_carrera	int
-----pk
--constraint	pk_contenidos primary key(id_materia,id_carrera),
--constraint	fk_materia foreign key(id_materia)
--references materias(id_materia),
--constraint	fk_carrera foreign key(id_carrera)
--references carreras(id_carrera))

create table profesores(
id_profesor	int	identity(1,1),
nombre varchar(50),
apellido varchar(50),
fecha_nac datetime,
dni bigint,
e_mail varchar(100),
telefono bigint,
calle varchar(100),
altura int,
sexo int,
id_barrio int
constraint fk_barrios foreign key (id_barrio)
references barrios(id_barrio),
constraint pk_profesor primary key(id_profesor))


create table materia_x_profesores(
id_mat_x_prof int identity(1,1),
id_profesor int,
id_materia int
constraint fk_profesor foreign key (id_profesor)
references profesores(id_profesor),
constraint fk_materia foreign key (id_materia)
references materias(id_materia),
constraint pk_id_mat_x_prof primary key(id_mat_x_prof))

create table estados_ac
(
id_estado_ac	int	identity(1,1),
descripcion	varchar(50)
constraint	pk_estado_ac	primary	key(id_estado_ac))


create table estados_academicos(
id_materia	int,	
legajo	int,
id_estado_ac	int,
asistencias	int,
año	datetime
---pk 
constraint	pk_estados_academicos primary key(id_materia,legajo),
constraint	fk_materia1 foreign key(id_materia)
references materias(id_materia),
constraint	fk_Legajo foreign key(legajo)
references alumnos(legajo),
constraint	fk_estado_ac foreign key(id_estado_ac)
references estados_ac(id_estado_ac))

create table tipo_prueba(
id_tipo_prueba	int	identity(1,1),
descripcion	varchar(50),
id_estado_ac int
constraint	pk_tipo_prueba primary key(id_tipo_prueba),
constraint	FK_estado_ac1 foreign key(id_estado_ac)
references	estados_ac(id_estado_ac))

create table pruebas(
id_prueba	int	identity(1,1),
id_materia	int,	
legajo	int,
nota	int,
fecha	datetime,
id_tipo_prueba	int
constraint	pk_prueba	primary	key(id_prueba),
constraint	fk_Materia2 foreign key(id_materia)
references materias(id_materia),
constraint	FK_legajo1 foreign key(legajo)
references alumnos(legajo),
constraint	FK_Tipo_prueba foreign key(id_tipo_prueba)
references tipo_prueba(id_tipo_prueba))


create table turnos_examenes
(id_turno_examen int identity (1,1),
descripcion varchar(50)
constraint pk_id_turno_examen primary key (id_turno_examen))

create table mesa_examenes(
id_mesa	int	identity(1,1),
fecha	datetime,
turno_examen int,
id_materia	int,
id_profesores	int,
constraint	pk_mesa	primary	key(id_mesa),
constraint	fk_materia3 foreign key(id_materia)
references materias(id_materia),
constraint	FK_Profesores foreign key(id_profesores)
references profesores(id_profesor),
constraint fk_turno_examen foreign key(turno_examen) 
references turnos_examenes (id_turno_examen))




create table examenes(
id_examenes	int	identity(1,1),
id_mesa	int,
legajo	int,
nota	int
constraint	pk_examenes	primary	key(id_examenes),
constraint	Fk_mesa	foreign	key(id_mesa)
references	mesa_examenes(id_mesa),
constraint	kF_Legajo	foreign	key(legajo)
references	alumnos(legajo))






