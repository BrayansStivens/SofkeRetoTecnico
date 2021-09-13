create database ConcursoPyR
use ConcursoPyR

create table pregunta_respuesta(
codigo varchar(10) primary key,
categoria varchar(30) not null,
pregunta varchar(200) not null,
respuesta varchar(100) not null,
)

create table respuestas_incorrectas(
codigo varchar(10) primary key,
uno varchar(100) not null,
dos varchar(100) not null,
tres varchar(100) not null,
codPregunta varchar(10) not null foreign key references pregunta_respuesta(codigo))


create table jugador(
id int identity(1,1) primary key,
nombre varchar(50) not null,
puntaje int not null
) 

insert into pregunta_respuesta values('G1','Geografia','¿Cuál es el idioma más hablado en Suiza?','Alemán'),
('G2','Geografia','¿Qué país está entre Perú y Colombia?','Ecuador'),
('G3','Geografia','¿Cuál es el lago más largo de Europa Occidental?','Lago Leman'),
('G4','Geografia','¿En qué país se encuentra el pico Aconcagua?','Argentina'),
('G5','Geografia','¿En qué país europeo se habla el magyar?','Hungria')

insert into pregunta_respuesta values('H1','Historia','¿Qué reina británica era hija de los Reyes Católicos?','Catalina de Aragón'),
('H2','Historia','¿Cuál fue la dictadura que comenzó en España en el año 1923?','La del general Primo de Rivera'),
('H3','Historia','¿Quién fue el primer presidente de la Republica de Colombia?','José María Campo Serrano'),
('H4','Historia','¿Qué batalla crucial tuvo lugar en 1815?','Waterloo'),
('H5','Historia','¿Quién era el emperador de Roma cuando murió Jesús?','Tiberio')

insert into pregunta_respuesta values('AL1','Arte y Literatura','¿Cuál es la identidad secreta de Don Diego de la Vega?','El Zorro'),
('AL2','Arte y Literatura','¿Quién escribió La Guerra de los Mundos en 1898?','H.G. Wells'),
('AL3','Arte y Literatura','¿Quién escribió La Perra?','Pilar Quintana'),
('AL4','Arte y Literatura','¿Quién pintó La Barequera?','Pedro Nel Gómez'),
('AL5','Arte y Literatura','¿Quién fue el italiano que puso música al Othelo de Shakespeare?','Verdi')

insert into pregunta_respuesta values('CN1','Ciencia y Naturaleza','¿En qué parte del cuerpo se encuentra la piel más gruesa?','Espalda'),
('CN2','Ciencia y Naturaleza','¿Cuál de los cinco sentidos se desarrolla el primero?','Olfato'),
('CN3','Ciencia y Naturaleza','¿Cómo se llama el componente mínimo que forma a los seres vivos?','Célula'),
('CN4','Ciencia y Naturaleza','Para los botánicos, el tomate es una:','Fruta'),
('CN5','Ciencia y Naturaleza','¿Cómo se llaman las partículas subatómicas con carga eléctrica negativa?','Electrones')

insert into pregunta_respuesta values('D1','Deportes','¿Qué deporte practican los Harlem Globetrotters?','Baloncesto'),
('D2','Deportes','¿En qué país se encuentra el circuito de Le Mans?','Francia'),
('D3','Deportes','¿Cuál era el nombre anterior de Muhammad Alí?','Cassius Clay'),
('D4','Deportes','¿Qué jugador marcó el gol que le dio la clasificación a Colombia a los octavos de final del Mundial de Italia 1990?','Freddy Rincón'),
('D5','Deportes','¿Cuál fue la primera colombiana en ganar una medalla de bronce olímpica en atletismo?','Ximena Restrepo')

insert into respuestas_incorrectas values('RG1','Suizo','Ingles','Holandes','G1'),
('RG2','Brazil','Peru','Bolivia','G2'),
('RG3','Lago Peipus','Lago Saimaa','Lago Vänern','G3'),
('RG4','Chile','Paraguay','Uruguay','G4'),
('RG5','Mexico','Holanda','Armenia','G5');

insert into respuestas_incorrectas values('RH1','Isabel de York','Ana Boleana','Juana Seymour','H1'),
('RH2','La del general Serrano','La de Franco','La del general Cavaignac','H2'),
('RH3','Simón Bolívar','Santander','Joaquín Mosquera','H3'),
('RH4','Wavre','Tezmalaca','Ligny','H4'),
('RH5','Calígula','Augusto','Julio César','H5');

insert into respuestas_incorrectas values('RAL1','Cantiflas','Sherlom Homes','Le candidat','AL1'),
('RAL2','Evelyn Abbott','John Aikin','Edwin Arnold','AL2'),
('RAL3','Jesús Abad Colorado','Tomas Carrasquilla','Mario Mendoza','AL3'),
('RAL4','Epifanio Garay','Ramón Torres Méndez','José María Espinosa','AL4'),
('RAL5','Strauss','Fauré','Gounod','AL5');

insert into respuestas_incorrectas values('RCN1','Piernas','Barriga','Brazos','CN1'),
('RCN2','Vista','Oido','Gusto','CN2'),
('RCN3','Mitrocondia','Átomo','Citoplasma','CN3'),
('RCN4','Verdura','Hortaliza','Legumbre','CN4'),
('RCN5','Protones','Neutrones','Fotones','CN5');

insert into respuestas_incorrectas values('RD1','Soccer','Hockey','Voleibol','D1'),
('RD2','Italia','Alemania','USA','D2'),
('RD3','Mike Clay','Michael Clay','Cornelius Clay','D3'),
('RD4','Pibe Valderrama','Andrés Escobar','Leonel Álvarez','D4'),
('RD5','Muriel Coneo','Caterine Ibargüen','Sandra Lorena Arenas','D5');
