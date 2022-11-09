--SQL SERVER

Insert into Laboralidad (descripcion) values ('Autonomo')
Insert into Laboralidad (descripcion) values ('Asalariado tiempo completo')
Insert into Laboralidad (descripcion) values ('Asalariado tiempo parcial')
Insert into Laboralidad (descripcion) values ('Jubilado')
Insert into Laboralidad (descripcion) values ('Desempleado')


Insert into Habitacionalidad (descripcion) values ('Propia')
Insert into Habitacionalidad (descripcion) values ('Alquilada')
Insert into Habitacionalidad (descripcion) values ('Otra')

Insert into Sexos(descripcion) values ('Masculino')
Insert into Sexos(descripcion) values ('Femenino')
Insert into Sexos(descripcion) values ('Desconocido')

insert into provincias (nombre) values ('Buenos Aires')
insert into provincias (nombre) values ('CABA')
insert into provincias (nombre) values ('Catamarca')
insert into provincias (nombre) values ('Chaco')
insert into provincias (nombre) values ('Chubut')
insert into provincias (nombre) values ('Córdoba')
insert into provincias (nombre) values ('Corrientes')
insert into provincias (nombre) values ('Entre Rios')
insert into provincias (nombre) values ('Formosa')
insert into provincias (nombre) values ('Jujuy')
insert into provincias (nombre) values ('La Pampa')
insert into provincias (nombre) values ('La Rioja')
insert into provincias (nombre) values ('Mendoza')
insert into provincias (nombre) values ('Misiones')
insert into provincias (nombre) values ('Neuquén')
insert into provincias (nombre) values ('Río Negro')
insert into provincias (nombre) values ('Salta')
insert into provincias (nombre) values ('San Juan')
insert into provincias (nombre) values ('San Luis')
insert into provincias (nombre) values ('Santa Cruz')
insert into provincias (nombre) values ('Santa Fe')
insert into provincias (nombre) values ('Santiago del estero')
insert into provincias (nombre) values ('Tierra del Fuego')
insert into provincias (nombre) values ('Tucumán')

--Ciudades

insert into Ciudades(nombre, id_provincia ) values (
'Córdoba', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Agua de
Oro', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Alta
Gracia', 6)
insert into Ciudades( nombre, id_provincia ) values (
'Anisacate', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Bell
Ville', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Bialet
Massé', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Capilla
del Monte', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Colonia
Caroya', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Cosquín',
6)
insert into Ciudades( nombre, id_provincia ) values ( 'Cruz
del Eje', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Deán
Funes', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Jesús
María', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'La
Calera', 6)
insert into Ciudades( nombre, id_provincia ) values ( 'Saldan',
6)
insert into Ciudades( nombre, id_provincia ) values ( 'Villa
Allende', 6)
insert into Ciudades( nombre, id_provincia ) values (
'Avellaneda', 1)
insert into Ciudades( nombre, id_provincia ) values (
'Cañuelas', 1)
insert into Ciudades( nombre, id_provincia ) values ( 'La
Matanza', 1)
insert into Ciudades( nombre, id_provincia ) values (
'Quilmes', 1)
insert into Ciudades(nombre, id_provincia ) values ( 'Carlos
Paz', 6)

--Barrios--
insert into Barrios ( nombre, id_ciudades) values ( 'Alta Cordoba', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Alberdi', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Alto Alberdi', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Arguello', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Jardin', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Centro', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Cerro de las
Rosas', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Nueva Córdoba', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Observatorio', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'General Paz', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'San Vicente', 1)
insert into Barrios ( nombre, id_ciudades) values ( 'Barrio Córdoba', 3)
insert into Barrios ( nombre, id_ciudades) values ( 'El Crucero', 3)
insert into Barrios ( nombre, id_ciudades) values ( 'Parque del
Virrey', 3)
insert into Barrios ( nombre, id_ciudades) values ( 'Liniers', 3)
insert into Barrios ( nombre, id_ciudades) values ( 'Capilla del
Monte Centro', 7)
insert into Barrios ( nombre, id_ciudades) values ( 'VCP centro', 21)
insert into Barrios ( nombre, id_ciudades) values ( 'Los
Manantiales', 21)
insert into Barrios ( nombre, id_ciudades) values ( 'Sol y Lago', 21)
insert into Barrios ( nombre, id_ciudades) values ( 'San Isidro', 15)
insert into Barrios ( nombre, id_ciudades) values ( 'San Alfonso', 15)
insert into Barrios ( nombre, id_ciudades) values ( 'Villa Allende
Parque', 15)

Insert into estados_civiles (descripcion) values ('Soltero/a')
Insert into estados_civiles (descripcion) values ('Casado/a')
Insert into estados_civiles (descripcion) values ('Divorciado/a')
Insert into estados_civiles (descripcion) values ('Viudo/a')


Insert into turnos (descripcion) values ('Mañana')
Insert into turnos (descripcion) values ('Tarde')
Insert into turnos (descripcion) values ('Noche')

Insert into cursos (nombre) values ('1W4', 2)
Insert into cursos (nombre) values ('1W3', 3)
Insert into cursos (nombre) values ('2W3', 3)
Insert into cursos (nombre) values ('2W4', 2)
Insert into cursos (nombre) values ('3W3', 3)
Insert into cursos (nombre) values ('3W4', 2)



Insert into carreras (nombre) values ('Tec. Univ. Programación')
Insert into carreras (nombre) values ('Tec. Univ. Industrias Alimentarias')
Insert into carreras (nombre) values ('Tec. Univ. Mecatronica')
Insert into carreras (nombre) values ('Tec. Univ. Mant. Industrial')
Insert into carreras (nombre) values ('Tec. Univ. Moldes Matrices y Dispo.')
Insert into carreras (nombre) values ('Tec. Univ. Telecomunicaciones')

Insert into materias (nombre, promocionable, id_carrera) values ('Matematica',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Ingles I',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Ingles II',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Lab. de Computacion I',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Lab. de Computacion II',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Lab. de Computacion III',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Lab. de Computacion IV',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Programacion  I',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Programacion  II',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Programacion  III',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Sistema de Proc. de Datos',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Arq. y Sist. Operativos',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Estadistica',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Met. de la Investigacion',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Org. Contable de la Empresa',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Org. Empresarial',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Elementos de Investg. Operativa',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Met. de Sistemas',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Diseño y Adm. de Bases de Datos',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Legislacion',1,1)
Insert into materias (nombre, promocionable, id_carrera) values ('Practica Profesional',1,1)

Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Juan', 'Perez', '1980-01-01', 12345467, 'juanperez@gmail.com', 351678945, 'San Martin', 123, 1, 1)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Maria', 'Gomez', '1970-01-25', 12345568, 'mariagomez@hotmail.com', 351678934, 'General Paz', 500, 2, 2)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Jose', 'Gonzalez', '1975-01-25', 12455634, 'josegonzales@yahoo.com', 351678934, 'La Rioja', 250, 1, 3)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Ana', 'Rodriguez', '1976-12-25', 11234556, 'anarodri@gmail.com', 351678994, 'San Martin', 250, 2, 4)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Pedro', 'Lopez', '1976-06-25', 12345556, 'pedrolop@hotmail.com', 351678494, 'Catamarca', 250, 1, 5)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Maria', 'Martinez', '1976-06-25', 16455563,'mariamartinez@gmail.com', 351678495, 'Libertador', 350, 2, 6)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Jose', 'Sanchez', '1985-06-25', 12345563,'josesanchez@gmail.com', 351678495, 'Poeta Lugones', 390, 3, 6)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Maria', 'Gonzalez', '1985-06-25', 12349963,'mariagon@gmail.com', 351678495, 'San Ignacio', 1390, 2, 8)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Jose', 'Gomez', '1985-06-25', 12345453,'gomezjose@gmail.com', 351678495, 'San Martin', 1390, 1, 9)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Oscar', 'Botta', '1970-06-25', 20345453,'bottaosquiloco@hotmail.com', 35178945652, 'Esquiu', 1190, 1, 10)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Kunda', 'Beatriz', '1970-07-25', 20545453,'betytopkunda@yahoo.com', 3517897852, 'Rosas', 90, 2, 1)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Stefanich', 'Gloria', '1959-06-25', 10545453,'gloriadios@gmail.com', 3517945652, 'San Carlos', 2290, 2, 2)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Gonzalez', 'Jairo', '1990-06-25', 29345453,'jairogonzalete@hotmail.com', 3517894452, '9 de Julio', 616, 1, 20)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Olmedo', 'Roberto', '1969-06-25', 22345453,'olmedorober@gmail.com', 3541789456, 'Peron', 789, 1, 21)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Estella', 'Garto', '1950-06-25', 22345453,'estellagarto@hotmail.com', 3541789445, 'San Martin', 78, 1, 15)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Ana', 'Konda', '1942-06-25', 02345453,'kondaana@gmail.com', 35417456, 'Caseros', 58, 2, 15)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Elba', 'Lazo', '1960-06-25', 22345456,'lazoelba@gmail.com', 3541789456, 'San Martin', 08, 2, 15)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Lucho', 'Gonzalez', '1962-06-25', 22345456,'luchogonza@hotmail.com', 3541789456, 'San Jeronimo', 15, 1, 13)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Eduardo', 'Gomez', '1967-08-25', 29345456,'edugomez@hotmail.com', 351787456, 'Jose H Porto', 195, 1, 11)
Insert into Profesores (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_barrio)
    values ('Lisandro', 'Jackson', '1987-08-25', 29845456,'jacksondestripador@gmail.com', 351789956, 'Echeverria', 1995, 1, 3)

--Inserts Tabla Administradores
insert into Administradores (usuario, contrasenia)
	values ('robertogomezUTNFRC', 'administrador2022')
insert into Administradores (usuario, contrasenia)
	values ('rosaliarosalesUTNFRC', 'administradora2022')
insert into Administradores (usuario, contrasenia)
	values ('pepe', 'pepe123')

--Inserts Tabla Estados_Ac
Insert into estados_ac
	values ('Promocionado')
Insert into estados_ac
	values ('Libre')
Insert into estados_ac
	values ('Regular')

	--Inserts TURNOS
INSERT INTO turnos_examenes VALUES ('Primer turno de Noviembre');
INSERT INTO turnos_examenes VALUES ('Segundo turno de Noviembre');
INSERT INTO turnos_examenes VALUES ('Primer turno de Noviembre');
INSERT INTO turnos_examenes VALUES ('Segundo turno de Diciembre');
INSERT INTO turnos_examenes VALUES ('Primer turno de Febrero');
INSERT INTO turnos_examenes VALUES ('Segundo turno de Febrero');
INSERT INTO turnos_examenes VALUES ('Primer turno de Marzo');
INSERT INTO turnos_examenes VALUES ('Segundo turno de Marzo');
INSERT INTO turnos_examenes VALUES ('Primer turno de Julio');
INSERT INTO turnos_examenes VALUES ('Segundo turno de Julio');


--Insert Alumno
insert into Alumnos (nombre, apellido, fecha_nac, dni, e_mail, telefono, calle, altura, id_sexo, id_curso, id_carrera, fecha_insc, id_estado_civil, id_laboralidad, id_habitacionalidad, id_barrio)  	
	values('Prueba', 'ApellidoPrueba', '8/11/2022', 444, 'prueba@gmail.com',333, 'Av. Prueba', 222, 1, 1, 1, '3/11/2022', 1, 1, 1, 1)

	--Inserts de Materias_x_Profesores para poder cargar Combo de profesores por materia
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (10, 8)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (10, 9)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (10, 10)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (6, 9)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (9, 9)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (11, 4)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (11, 5)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (11, 6)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (11, 7)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (8, 1)
INSERT INTO materia_x_profesores (id_profesor, id_materia) VALUES (7, 1)

