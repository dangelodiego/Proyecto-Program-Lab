--SP_OBTENER_PROVINCIAS

CREATE PROCEDURE [dbo].[SP_OBTENER_PROVINCIAS]
AS
BEGIN 
SELECT id_provincia, nombre
FROM provincias
END

--SP_OBTENER CIUDADES

CREATE PROCEDURE [dbo].[SP_OBTENER_CIUDADES]
AS
BEGIN 
SELECT id_ciudades, nombre, id_provincia
FROM ciudades
END

--SP_OBTENER_BARRIOS

CREATE PROCEDURE [dbo].[SP_OBTENER_BARRIOS]
AS
BEGIN 
SELECT id_barrio, nombre, id_ciudades
FROM barrios
END

--SP_INSERTAR_ALUMNO

CREATE PROCEDURE [dbo].[SP_INSERTAR_ALUMNO]
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac datetime,
@dni bigint,
@e_mail varchar(100),
@telefono bigint,
@calle varchar(100),
@altura int,
@id_sexo int,
@id_curso int,
@id_carrera int,
@fecha_insc datetime,
@id_estado_civil int,
@id_laboralidad int,
@id_habitacionalidad int,
@id_barrio int
AS
BEGIN
INSERT INTO alumnos 
VALUES (@nombre,@apellido,@fecha_nac,@dni,@e_mail,@telefono,@calle,@altura,@id_sexo,@id_curso,@id_carrera,@fecha_insc,@id_estado_civil,
@id_laboralidad,@id_habitacionalidad,@id_barrio)
END

--SP_INSERTAR_PROFESOR

CREATE PROCEDURE [dbo].[SP_INSERTAR_PROFESOR]
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac datetime,
@dni bigint,
@e_mail varchar(100),
@telefono bigint,
@calle varchar(100),
@altura int,
@id_sexo int,
@id_barrio int
AS
BEGIN 
INSERT INTO profesores
VALUES (@nombre,@apellido,@fecha_nac,@dni,@e_mail,@telefono,@calle,@altura,@id_sexo,@id_barrio)
END

--SP_INSERTAR_MAESTRO

CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO]
@fecha datetime,
@turno int,
@id_materia int,
@id_profesores int,
@id_mesa int output
AS
BEGIN
INSERT INTO mesa_examenes
VALUES (@fecha,@turno,@id_materia,@id_profesores)
SET @id_mesa = SCOPE_IDENTITY();
END

--SP_INSERTAR_DETALLE

CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE]
@id_mesa int,
@legajo int,
@nota int 
AS
BEGIN 
 INSERT INTO examenes
 VALUES (@id_mesa,@legajo,@nota)
END

--SP_BORRAR_ALUMNO

CREATE PROCEDURE [dbo].[SP_BORRAR_ALUMNO]
@legajo int
AS
DELETE alumnos
WHERE legajo = @legajo

--SP_BORRAR_PROFESOR

CREATE PROCEDURE [dbo].[SP_BORRAR_PROFESOR]
@id_profesor int
AS
DELETE profesores
WHERE id_profesor=@id_profesor

--SP_MODIFICAR_ALUMNO

CREATE PROCEDURE [dbo].[SP_MODIFICAR_ALUMNO]
@legajo int,
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac datetime,
@dni bigint,
@e_mail varchar(100),
@telefono bigint,
@calle varchar(100),
@altura int,
@id_sexo int,
@id_curso int,
@id_carrera int,
@fecha_insc datetime,
@id_estado_civil int,
@id_laboralidad int,
@id_habitacionalidad int,
@id_barrio int
AS
BEGIN
UPDATE alumnos 
SET nombre=@nombre,
apellido= @apellido,
fecha_nac=@fecha_nac,
dni=@dni,
e_mail=@e_mail,
telefono=@telefono,
calle=@calle,
altura=@altura,
id_sexo=@id_sexo,
id_curso=@id_curso,
id_carrera=@id_carrera,
fecha_insc=@fecha_insc,
id_estado_civil=@id_estado_civil,
id_laboralidad=@id_laboralidad,
id_habitacionalidad=@id_habitacionalidad,
id_barrio=@id_barrio
WHERE legajo = @legajo
END

--SP_MODIFICAR_MESA

CREATE PROCEDURE [dbo].[SP_MODIFICAR_MESA]
@fecha datetime,
@turno_examen int,
@id_materia int,
@id_profesores int,
@id_mesa int 
AS
BEGIN
UPDATE mesa_examenes SET fecha = @fecha, turno_examen = @turno_examen, id_materia= @id_materia,
id_profesores = @id_profesores
WHERE id_mesa = @id_mesa;

DELETE examenes
WHERE id_mesa = @id_mesa;
END

--SP_MODIFICAR_PROFESOR

CREATE PROCEDURE [dbo].[SP_MODIFICAR_PROFESOR]
@id_profesor int,
@nombre varchar(50),
@apellido varchar(50),
@fecha_nac datetime,
@dni bigint,
@e_mail varchar(100),
@telefono bigint,
@calle varchar(100),
@altura int,
@id_sexo int,
@id_barrio int
AS
BEGIN 
UPDATE profesores
SET nombre=@nombre,
apellido= @apellido,
fecha_nac=@fecha_nac,
dni=@dni,
e_mail=@e_mail,
telefono=@telefono,
calle=@calle,
altura=@altura,
id_sexo=@id_sexo,
id_barrio=@id_barrio
WHERE id_profesor = @id_profesor
END

--SP_CONSULTAR_ALUMNOS

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ALUMNOS]
AS
BEGIN
SELECT * 
FROM alumnos
END

--SP_CONSULTAR_MATERIAS 

CREATE PROCEDURE [dbo].[SP_CONSULTAR_MATERIAS]
AS
BEGIN
SELECT id_materia, nombre, promocionable
FROM materias
END

--SP_CONSULTAR_PROFESORES

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PROFESORES]
AS
BEGIN
SELECT * 
FROM profesores
END

--SP_ALUMNOS_SEGUN_PROMEDIO_ANIOS_INGRESO

CREATE PROCEDURE [dbo].[SP_ALUMNOS_SEGUN_PROMEDIO_ANIOS_INGRESO]
@anio_ingreso1 int,
@anio_ingreso2 int
AS
BEGIN
Select a.legajo 'Legajo', nombre 'Nombre Alumno',
'Ingreso este Año' Observaciones
From Alumnos a 
Where 8 >= (select AVG(nota)
from Pruebas p1
where p1.legajo = a.legajo)
and year(fecha_insc) = @anio_ingreso1
Union
Select a.legajo, nombre, 'Ingreso el Año Pasado'
From Alumnos a 
join Pruebas p1 on p1.legajo = a.legajo
Where year(fecha_insc) = @anio_ingreso2
Group by a.legajo, nombre
having AVG(nota) >= 8
Order By 2, 1
END

--SP_CONSULTAR_ALUMNOS_SEGUN_MATERIAS_CURSADAS

CREATE PROCEDURE [dbo].[SP_CONSULTAR_ALUMNOS_SEGUN_MATERIAS_CURSADAS]
@cantidad int
AS
BEGIN
SELECT a.legajo 'Legajo',
 apellido+','+nombre 'alumno',
 dni 'documento',
 fecha_insc 'fecha de inscripcion'
FROM alumnos a join
estados_academicos ac on a.legajo=ac.legajo
where @cantidad <any (select id_materia
from pruebas
where year(fecha)=year(fecha)-1)
END

--SP_MATERIAS_PORCENTAJE_ALUMNOS_NOTAS_MENOR

CREATE PROCEDURE [dbo].[SP_MATERIAS_PORCENTAJE_ALUMNOS_NOTAS_MENOR]
@nota int
AS
BEGIN
SELECT m.nombre, 100*(SELECT COUNT(a1.legajo)
FROM materias m1 join pruebas p1
on m1.id_materia = p1.id_materia
join alumnos a1 on p1.legajo = a1.legajo
WHERE  @nota > (SELECT p2.nota
FROM materias m2 join pruebas p2 on m2.id_materia
= p2.id_materia
join alumnos a2 on p2.legajo = a2.legajo
WHERE a1.legajo=a2.legajo)) /COUNT(a.legajo)
FROM materias m join pruebas p on m.id_materia =
p.id_materia join alumnos a on p.legajo = a.legajo
GROUP BY m.nombre
END

--SP_MATERIAS_SEGUN_PROMEDIO

CREATE PROCEDURE [dbo].[SP_MATERIAS_SEGUN_PROMEDIO]
@promedio int
AS
BEGIN
SELECT m.id_materia, m.nombre, avg(nota)
FROM Materias M join Pruebas P on
M.id_materia=P.id_materia
GROUP BY m.id_materia, m.nombre
HAVING avg(nota)>@promedio
END

--SP_NO_VAN_A_RENDIR_HACE_TANTOS_AÑOS

CREATE PROCEDURE [dbo].[SP_NO_VAN_A_RENDIR_HACE_TANTOS_AÑOS]
@legajo int,
@años int
AS
BEGIN
SELECT a.legajo, apellido+' '+nombre
FROM alumnos a 
join pruebas pr on a.legajo=pr.legajo
WHERE @legajo NOT IN (
select legajo from pruebas
where year(fecha)=year(getdate())-@años)
END

--SP_OBTENER_PROMEDIO_EDAD_CURSO

CREATE PROCEDURE [dbo].[SP_OBTENER_PROMEDIO_EDAD_CURSO]
AS
BEGIN 
select a.id_curso 'CURSO',
Avg(DATEDIFF(YEAR,Fecha_Nac,GETDATE())
-(CASE WHEN DATEADD(YY,DATEDIFF(YEAR,Fecha_Nac,GETDATE()),
Fecha_nac)>GETDATE() THEN
 1
 ELSE
 0
 END)) as 'Edad promedio'
from alumnos a 
join Carreras c on c.id_carrera=a.id_carrera
join cursos cu on cu.id_curso=a.id_curso
Where a.id_carrera = 1 --TUP
Group by a.id_curso
END

-- Sp LOGIN
create proc SP_Login
 @usuario varchar(20),
 @pass varchar(25)
as
begin 

	Select top 1 COUNT(*) 
	From Administradores a
	Where a.usuario = @usuario and a.contrasenia = @pass
end 
go

use 

--Sp OBTENER ESTADO CIVIL
CREATE PROCEDURE "SP_OBTENER_ESTADOCIVIL"
AS
SELECT id_estado_civil, descripcion FROM estados_civiles

--SP CIUDADES POR PROVONCIA
CREATE PROCEDURE "SP_CIUDADES_X_PCIA"
@id_provincia int
AS
SELECT id_provincia, id_ciudades, nombre from ciudades where id_provincia=@id_provincia



--SP_OBTENER_TECNICATURAS

CREATE PROCEDURE "SP_OBTENER_TECNICATURAS"
AS
BEGIN
SELECT id_carrera, nombre FROM CARRERAS
END


--SP_OBTENER_CURSOS

CREATE PROCEDURE "SP_OBTENER_CURSOS"
AS
BEGIN
SELECT id_curso, nombre FROM CURSOS
END

--SP_OBTENER_BARRIOS_POR_CIUDAD

CREATE PROCEDURE "SP_OBTENER_BARRIOS_X_CIUDAD"
@id_ciudades int
AS
BEGIN
SELECT id_ciudades, id_barrio, nombre FROM barrios where id_ciudades=@id_ciudades
END

<<<<<<< HEAD



CREATE PROCEDURE SP_OBTENER_LABORALIDADES
AS
Select * from Laboralidad


Create Procedure SP_OBTENER_HABITACIONALIDADES
AS
Select * from Habitacionalidad

=======
--SP_OBTENER_CANTIDAD_ALUMNOS

CREATE PROCEDURE "SP_OBETENER_CANTIDAD_ALUMNOS"
AS
BEGIN
SELECT COUNT(legajo) Cantidad
FROM alumnos
END



exec SP_OBETENER_CANTIDAD_ALUMNOS

--SP_OBTENER_CANTIDAD_PROMOCIONADOS

CREATE PROCEDURE "SP_OBTENER_CANTIDAD_PROMOCIONADOS"
AS
BEGIN
SELECT COUNT(legajo) Cantidad
FROM estados_academicos e JOIN estados_ac es on e.id_estado_ac=es.id_estado_ac 
WHERE descripcion = 'Promocionado'
end

--SP_OBTENER_CANTIDAD_LIBRES

CREATE PROCEDURE "SP_OBTENER_CANTIDAD_LIBRES"
AS
BEGIN
SELECT COUNT(legajo) Cantidad
FROM estados_academicos e JOIN estados_ac es on e.id_estado_ac=es.id_estado_ac 
WHERE descripcion = 'Libre'
END

--SP_OBTENER_CANTIDAD_REGULARES

CREATE PROCEDURE "SP_OBTENER_CANTIDAD_REGULARES"
AS
BEGIN
SELECT COUNT(legajo) Cantidad
FROM estados_academicos e JOIN estados_ac es on e.id_estado_ac=es.id_estado_ac 
WHERE descripcion = 'Regular'
END


--SP_OBTENER_CANTIDAD_PROFESORES

CREATE PROCEDURE SP_OBTENER_CANTIDAD_PROFESORES
AS
BEGIN
SELECT COUNT(id_profesor) Cantidad
FROM profesores
END

exec SP_OBTENER_CANTIDAD_PROFESORES

--SP_OBTENER_CANTIDAD_TECNICATURAS

CREATE PROCEDURE SP_OBTENER_CANTIDAD_TECNICATURAS
AS
BEGIN
SELECT COUNT(id_carrera) Cantidad
FROM carreras
END



--SP_OBTENER_MATERIAS_X_CARRERA
create PROCEDURE SP_OBTENER_MATERIAS_X_CARRERA
@id_carrera int
AS
BEGIN
SELECT id_carrera, id_materia, nombre, promocionable
FROM materias
WHERE id_carrera=@id_carrera
END


--SP_OBTENER_PROFESORES_X_MATERIA
create PROCEDURE "SP_OBTENER_PROFESORES_X_MATERIA"
@id_materia int
AS
BEGIN
SELECT mxp.id_profesor, p.apellido+' '+p.nombre 'Profesor', mxp.id_materia FROM materia_x_profesores mxp JOIN profesores p on mxp.id_profesor=p.id_profesor
WHERE mxp.id_materia=@id_materia
END














