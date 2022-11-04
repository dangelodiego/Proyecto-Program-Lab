--SQL SERVER

Insert into Laboralidad (descripcion) values ('Autonomo')
Insert into Laboralidad (descripcion) values ('Asalariado tiempo completo')
Insert into Laboralidad (descripcion) values ('Asalariado tiempo parcial')
Insert into Laboralidad (descripcion) values ('Jubilado')
Insert into Laboralidad (descripcion) values ('Desempleado')


Insert into Habitacionalidad (descripcion) values ('Propia')
Insert into Habitacionalidad (descripcion) values ('Alquilada')
Insert into Habitacionalidad (descripcion) values ('Otra')

--Provincias

insert into provincias (nombre) values ('Buenos Aires')
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
'Córdoba', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Agua de
Oro', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Alta
Gracia', 5)
insert into Ciudades( nombre, id_provincia ) values (
'Anisacate', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Bell
Ville', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Bialet
Massé', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Capilla
del Monte', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Colonia
Caroya', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Cosquín',
5)
insert into Ciudades( nombre, id_provincia ) values ( 'Cruz
del Eje', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Deán
Funes', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Jesús
María', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'La
Calera', 5)
insert into Ciudades( nombre, id_provincia ) values ( 'Saldan',
5)
insert into Ciudades( nombre, id_provincia ) values ( 'Villa
Allende', 5)
insert into Ciudades( nombre, id_provincia ) values (
'Avellaneda', 1)
insert into Ciudades( nombre, id_provincia ) values (
'Cañuelas', 1)
insert into Ciudades( nombre, id_provincia ) values ( 'CABA',
1)
insert into Ciudades( nombre, id_provincia ) values ( 'La
Matanza', 1)
insert into Ciudades( nombre, id_provincia ) values (
'Quilmes', 1)
insert into Ciudades(nombre, id_provincia ) values ( 'Carlos
Paz', 5)

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

Insert into estados_civiles (nombre) values ('Soltero/a')
Insert into estados_civiles (nombre) values ('Casado/a')
Insert into estados_civiles (nombre) values ('Divorciado/a')
Insert into estados_civiles (nombre) values ('Viudo/a')


Insert into turnos (nombre) values ('Mañana')
Insert into turnos (nombre) values ('Tarde')
Insert into turnos (nombre) values ('Noche')

Insert into cursos (nombre) values ('1W4')
Insert into cursos (nombre) values ('1W3')
Insert into cursos (nombre) values ('2W3')
Insert into cursos (nombre) values ('2W4')
Insert into cursos (nombre) values ('3W3')
Insert into cursos (nombre) values ('3W4')

Insert into carreras (nombre) values ('Tec. Univ. Programación')
Insert into carreras (nombre) values ('Tec. Univ. Industrias Alimentarias')
Insert into carreras (nombre) values ('Tec. Univ. Mecatronica')
Insert into carreras (nombre) values ('Tec. Univ. Mant. Industrial')
Insert into carreras (nombre) values ('Tec. Univ. Moldes Matrices y Dispo.')
Insert into carreras (nombre) values ('Tec. Univ. Telecomunicaciones')

Insert into materias (nombre) values ('Matematica')
