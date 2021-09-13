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

insert into pregunta_respuesta values('G1','Geografia','�Cu�l es el idioma m�s hablado en Suiza?','Alem�n'),
('G2','Geografia','�Qu� pa�s est� entre Per� y Colombia?','Ecuador'),
('G3','Geografia','�Cu�l es el lago m�s largo de Europa Occidental?','Lago Leman'),
('G4','Geografia','�En qu� pa�s se encuentra el pico Aconcagua?','Argentina'),
('G5','Geografia','�En qu� pa�s europeo se habla el magyar?','Hungria')

insert into pregunta_respuesta values('H1','Historia','�Qu� reina brit�nica era hija de los Reyes Cat�licos?','Catalina de Arag�n'),
('H2','Historia','�Cu�l fue la dictadura que comenz� en Espa�a en el a�o 1923?','La del general Primo de Rivera'),
('H3','Historia','�Qui�n fue el primer presidente de la Republica de Colombia?','Jos� Mar�a Campo Serrano'),
('H4','Historia','�Qu� batalla crucial tuvo lugar en 1815?','Waterloo'),
('H5','Historia','�Qui�n era el emperador de Roma cuando muri� Jes�s?','Tiberio')

insert into pregunta_respuesta values('AL1','Arte y Literatura','�Cu�l es la identidad secreta de Don Diego de la Vega?','El Zorro'),
('AL2','Arte y Literatura','�Qui�n escribi� La Guerra de los Mundos en 1898?','H.G. Wells'),
('AL3','Arte y Literatura','�Qui�n escribi� La Perra?','Pilar Quintana'),
('AL4','Arte y Literatura','�Qui�n pint� La Barequera?','Pedro Nel G�mez'),
('AL5','Arte y Literatura','�Qui�n fue el italiano que puso m�sica al Othelo de Shakespeare?','Verdi')

insert into pregunta_respuesta values('CN1','Ciencia y Naturaleza','�En qu� parte del cuerpo se encuentra la piel m�s gruesa?','Espalda'),
('CN2','Ciencia y Naturaleza','�Cu�l de los cinco sentidos se desarrolla el primero?','Olfato'),
('CN3','Ciencia y Naturaleza','�C�mo se llama el componente m�nimo que forma a los seres vivos?','C�lula'),
('CN4','Ciencia y Naturaleza','Para los bot�nicos, el tomate es una:','Fruta'),
('CN5','Ciencia y Naturaleza','�C�mo se llaman las part�culas subat�micas con carga el�ctrica negativa?','Electrones')

insert into pregunta_respuesta values('D1','Deportes','�Qu� deporte practican los Harlem Globetrotters?','Baloncesto'),
('D2','Deportes','�En qu� pa�s se encuentra el circuito de Le Mans?','Francia'),
('D3','Deportes','�Cu�l era el nombre anterior de Muhammad Al�?','Cassius Clay'),
('D4','Deportes','�Qu� jugador marc� el gol que le dio la clasificaci�n a Colombia a los octavos de final del Mundial de Italia 1990?','Freddy Rinc�n'),
('D5','Deportes','�Cu�l fue la primera colombiana en ganar una medalla de bronce ol�mpica en atletismo?','Ximena Restrepo')

insert into respuestas_incorrectas values('RG1','Suizo','Ingles','Holandes','G1'),
('RG2','Brazil','Peru','Bolivia','G2'),
('RG3','Lago Peipus','Lago Saimaa','Lago V�nern','G3'),
('RG4','Chile','Paraguay','Uruguay','G4'),
('RG5','Mexico','Holanda','Armenia','G5');

insert into respuestas_incorrectas values('RH1','Isabel de York','Ana Boleana','Juana Seymour','H1'),
('RH2','La del general Serrano','La de Franco','La del general Cavaignac','H2'),
('RH3','Sim�n Bol�var','Santander','Joaqu�n Mosquera','H3'),
('RH4','Wavre','Tezmalaca','Ligny','H4'),
('RH5','Cal�gula','Augusto','Julio C�sar','H5');

insert into respuestas_incorrectas values('RAL1','Cantiflas','Sherlom Homes','Le candidat','AL1'),
('RAL2','Evelyn Abbott','John Aikin','Edwin Arnold','AL2'),
('RAL3','Jes�s Abad Colorado','Tomas Carrasquilla','Mario Mendoza','AL3'),
('RAL4','Epifanio Garay','Ram�n Torres M�ndez','Jos� Mar�a Espinosa','AL4'),
('RAL5','Strauss','Faur�','Gounod','AL5');

insert into respuestas_incorrectas values('RCN1','Piernas','Barriga','Brazos','CN1'),
('RCN2','Vista','Oido','Gusto','CN2'),
('RCN3','Mitrocondia','�tomo','Citoplasma','CN3'),
('RCN4','Verdura','Hortaliza','Legumbre','CN4'),
('RCN5','Protones','Neutrones','Fotones','CN5');

insert into respuestas_incorrectas values('RD1','Soccer','Hockey','Voleibol','D1'),
('RD2','Italia','Alemania','USA','D2'),
('RD3','Mike Clay','Michael Clay','Cornelius Clay','D3'),
('RD4','Pibe Valderrama','Andr�s Escobar','Leonel �lvarez','D4'),
('RD5','Muriel Coneo','Caterine Ibarg�en','Sandra Lorena Arenas','D5');
