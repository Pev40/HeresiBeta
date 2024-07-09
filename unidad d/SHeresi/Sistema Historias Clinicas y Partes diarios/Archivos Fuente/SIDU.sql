--Insercion de registros como primeros campos a validar
--Ocupaciones
Insert Into TabOcup(DesOcup)values('S/E') 
go
--Religiones
Insert Into TabRelg(DesRelg)values('S/E') 
go
Insert Into TabRelg(DesRelg)values('Cristiana') 
go
Insert Into TabRelg(DesRelg)values('Católica') 
go
Insert Into TabRelg(DesRelg)values('Mormona') 
go
--Estados Civiles
Insert Into TabEciv(DesEciv)values('S/E') 
go
Insert Into TabEciv(DesEciv)values('Soltero(a)') 
go
Insert Into TabEciv(DesEciv)values('Casado(a)') 
go
Insert Into TabEciv(DesEciv)values('Viudo(a)') 
go
Insert Into TabEciv(DesEciv)values('Divorciado(a)') 
go
Insert Into TabEciv(DesEciv)values('Conviviente(a)') 
go
Insert Into TabEciv(DesEciv)values('Separado(a)') 
go
--Grados de Instruccion
Insert Into TabGins(DesGins)values('S/E') 
go
Insert Into TabGins(DesGins)values('C/Primaria') 
go
Insert Into TabGins(DesGins)values('C/Secundaria') 
go
Insert Into TabGins(DesGins)values('C/Técnica') 
go
Insert Into TabGins(DesGins)values('C/Superior') 
go
Insert Into TabGins(DesGins)values('C/Universitaria') 
go
--Documentos
Insert Into TabDocu(DesDocu)values('S/E') 
go
Insert Into TabDocu(DesDocu)values('D.N.I.') 
go
Insert Into TabDocu(DesDocu)values('L.M.') 
go
Insert Into TabDocu(DesDocu)values('P.N.') 
go
--Idiomas
Insert Into TabIdma(DesIdma)values('S/E') 
go
Insert Into TabIdma(DesIdma)values('Castellano') 
go
Insert Into TabIdma(DesIdma)values('Quechua') 
go
Insert Into TabIdma(DesIdma)values('Ingles') 
go
--Estados Economicos
Insert Into TipPac(CodTipPac,DescTipPac)values('S/E','S/E') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('PP','Pagante') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('P','Pagante') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('A','Pagante') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('B','Pagante') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('C','Pagante') 
go
Insert Into TipPac(CodTipPac,DescTipPac)values('E','Indigente') 
go
--Condiciones de Alta
Insert Into tabCond(DesCond)values('S/E') 
go
Insert Into tabCond(DesCond)values('Mejorado') 
go
Insert Into tabCond(DesCond)values('No Mejorado') 
go
Insert Into tabCond(DesCond)values('Fallecido') 
go
--Continuidad del Paciente
Insert Into ContPac(DescPac)values('S/E')
go
Insert Into ContPac(DescPac)values('Nuevo(a)')
go
Insert Into ContPac(DescPac)values('Continuador(a)')
go
Insert Into ContPac(DescPac)values('Reingresante')
go
--Tipos de Hospitalizaciones
Insert Into TipHosp(DesTiph)values('S/E')
go
Insert Into TipHosp(DesTiph)values('Completa')
go
Insert Into TipHosp(DesTiph)values('Parcial')
go
--Diagnosticos
Insert Into TabDiag(IdDiag,DesDiag)values('S/E','S/E')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F00-F09','Transtornos mentales orgánicos, incluidos los sintomáticos')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F10-F19','Transtornos mentales y del comportamiento debidos al consumo de sustancias psicotropas')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F20-F29','Esquisofrenia, transtorno esquizotípico y transtorno de ideas delirantes')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F30-F39','Transtornos del humor (afectivos)')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F40-F49','Transtornos neuróticos secundarios a situaciones estresantes y somatomorfos')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F50-F59','Transtornos del comportamiento asociados a disfunciones fisiológicas y a factores somáticos')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F60-F69','Transtornos de la personalidad y del comportamiento del adulto')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F70-F79','Retraso mental')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F80-F89','Transtornos del desarrollo psicológico')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F90-F98','Transtornos del comportamiento y de las emociones de comienzo habitual en la infancia y adolescencia')
go
Insert Into TabDiag(IdDiag,DesDiag)
values('F99','Transtornos mental sin especificación')
go




