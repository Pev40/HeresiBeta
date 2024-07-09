use Heresi
go
--------------------Trabajando con Tabla Estados civiles
--Insertar
create procedure sp_IEstCiv
@descripcion varchar(20)
as
insert into TabEciv(DesEciv) values(@descripcion)
go
--Mostrar
Create Procedure sp_MEstCiv
as
select IdEciv as Identificador,DesEciv as Descripción from TabEciv
go
--Mostrar solo un registro específico
Create Procedure sp_MUREstCiv
@Index int
as
select IdEciv as Identificador,DesEciv as Descripción from TabECiv where IdEciv=@Index
go
--Eliminar
Create Procedure sp_EEstCiv
@Index int
as
delete from TabECiv where IdEciv=@Index
go
--Actualizar
Create Procedure sp_AEstCiv
@Index int,
@descripcion varchar(20)
as
Update TabECiv set DesEciv=@descripcion where IdEciv=@Index
go
--Obtener Param Salida
Create Procedure sp_RDEstCiv
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesEciv from TabEciv where IdECiv = @Index
go

--------------------Trabajando con Tabla Ocupaciones
--Insertar
create procedure sp_IOcupaciones
@descripcion varchar(50)
as
insert into TabOcup(DesOcup) values(@descripcion)
go
--Mostrar
Create Procedure sp_MOcupaciones
as
select IdOcup as Identificador,DesOcup as Descripción from TabOcup
go
--Mostrar solo un registro específico
Create Procedure sp_MUROcupaciones
@Index int
as
select IdOcup as Identificador,DesOcup as Descripción from TabOcup where IdOcup=@Index
go
--Eliminar
Create Procedure sp_EOcupaciones
@Index int
as
delete from TabOcup where IdOcup=@Index
go
--Actualizar
Create Procedure sp_AOcupaciones
@Index int,
@descripcion varchar(50)
as
Update TabOcup set DesOcup=@descripcion where IdOcup=@Index
go
--Obtener Param Salida
Create Procedure sp_RDOcupaciones
@index int,
@descripcion varchar(50) output
as
select @descripcion = DesOcup from TabOcup where IdOcup = @Index
go

--------------------Trabajando con Tabla Religiones
--Insertar
create procedure sp_IReligiones
@descripcion varchar(20)
as
insert into TabRelg(DesRelg) values(@descripcion)
go
--Mostrar
Create Procedure sp_MReligiones
as
select IdRelg as Identificador,DesRelg as Descripción from TabRelg
go
--Mostrar solo un registro específico
Create Procedure sp_MURReligiones
@Index int
as
select IdRelg as Identificador,DesRelg as Descripción from TabRelg where IdRelg=@Index
go
--Eliminar
Create Procedure sp_EReligiones
@Index int
as
delete from TabRelg where IdRelg=@Index
go
--Actualizar
Create Procedure sp_AReligiones
@Index int,
@descripcion varchar(20)
as
Update TabRelg set DesRelg=@descripcion where IdRelg=@Index
go
--Obtener Param Salida
Create Procedure sp_RDReligiones
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesRelg from TabRelg where IdRelg = @Index
go

--------------------Trabajando con Tabla Grado de Instrucciones
--Insertar
create procedure sp_IGI
@descripcion varchar(20)
as
insert into TabGins(DesGins) values(@descripcion)
go
--Mostrar
Create Procedure sp_MGI
as
select IdGins as Identificador,DesGins as Descripción from TabGins
go
--Mostrar solo un registro específico
Create Procedure sp_MURGI
@Index int
as
select IdGins as Identificador,DesGins as Descripción from TabGins where IdGins=@Index
go
--Eliminar
Create Procedure sp_EGI
@Index int
as
delete from TabGins where IdGins=@Index
go
--Actualizar
Create Procedure sp_AGI
@Index int,
@descripcion varchar(20)
as
Update TabGins set DesGins=@descripcion where IdGins=@Index
go
--Obtener Param Salida
Create Procedure sp_RDGI
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesGins from TabGins where IdGins = @Index
go

--------------------Trabajando con Tabla Idiomas
--Insertar
create procedure sp_IIdma
@descripcion varchar(20)
as
insert into TabIdma(DesIdma) values(@descripcion)
go
--Mostrar
Create Procedure sp_MIdma
as
select IdIdma as Identificador,DesIdma as Descripción from TabIdma
go
--Mostrar solo un registro específico
Create Procedure sp_MURIdma
@Index int
as
select IdIdma as Identificador,DesIdma as Descripción from TabIdma where IdIdma=@Index
go
--Eliminar
Create Procedure sp_EIdma
@Index int
as
delete from TabIdma where IdIdma=@Index
go
--Actualizar
Create Procedure sp_AIdma
@Index int,
@descripcion varchar(20)
as
Update TabIdma set DesIdma=@descripcion where IdIdma=@Index
go
--Obtener Param Salida
Create Procedure sp_RDIdma
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesIdma from TabIdma where IdIdma = @Index
go

--------------------Trabajando con Tabla Condiciones
--Insertar
create procedure sp_ICond
@descripcion varchar(20)
as
insert into TabCond(DesCond) values(@descripcion)
go
--Mostrar
Create Procedure sp_MCond
as
select IdCond as Identificador,DesCond as Descripción from TabCond
go
--Mostrar solo un registro específico
Create Procedure sp_MURCond
@Index int
as
select IdCond as Identificador,DesCond as Descripción from TabCond where IdCond=@Index
go
--Eliminar
Create Procedure sp_ECond
@Index int
as
delete from TabCond where IdCond=@Index
go
--Actualizar
Create Procedure sp_ACond
@Index int,
@descripcion varchar(20)
as
Update TabCond set DesCond=@descripcion where IdCond=@Index
go
--Obtener Param Salida
Create Procedure sp_RDCond
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesCond from TabCond where IdCond = @Index
go

--------------------Trabajando con Tabla Tipo de Hospitalizaciones
--Insertar
create procedure sp_IHosp
@descripcion varchar(20)
as
insert into TipHosp(DesTiph) values(@descripcion)
go
--Mostrar
Create Procedure sp_MHosp
as
select IdTiph as Identificador,DesTiph as Descripción from TipHosp
go
--Mostrar solo un registro específico
Create Procedure sp_MURHosp
@Index int
as
select IdTiph as Identificador,DesTiph as Descripción from TipHosp where IdTiph=@Index
go
--Eliminar
Create Procedure sp_EHosp
@Index int
as
delete from TipHosp where IdTiph=@Index
go
--Actualizar
Create Procedure sp_AHosp
@Index int,
@descripcion varchar(20)
as
Update TipHosp set DesTiph=@descripcion where IdTiph=@Index
go
--Obtener Param Salida
Create Procedure sp_RDHosp
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesTiph from TipHosp where IdTiph = @Index
go

--------------------Trabajando con Tabla Tipos de Documento
--Insertar
create procedure sp_IDocu
@descripcion varchar(20)
as
insert into TabDocu(DesDocu) values(@descripcion)
go
--Mostrar
Create Procedure sp_MDocu
as
select IdDocu as Identificador,DesDocu as Descripción from TabDocu
go
--Mostrar solo un registro específico
Create Procedure sp_MURDocu
@Index int
as
select IdDocu as Identificador,DesDocu as Descripción from TabDocu where IdDocu=@Index
go
--Eliminar
Create Procedure sp_EDocu
@Index int
as
delete from TabDocu where IdDocu=@Index
go
--Actualizar
Create Procedure sp_ADocu
@Index int,
@descripcion varchar(20)
as
Update TabDocu set DesDocu=@descripcion where IdDocu=@Index
go
--Obtener Param Salida
Create Procedure sp_RDDocu
@index int,
@descripcion varchar(20) output
as
select @descripcion = DesDocu from TabDocu where IdDocu = @Index
go

--------------------Trabajando con Tabla Continuidad de Pacientes
--Insertar
create procedure sp_IcPac
@descripcion varchar(20)
as
insert into ContPac(DescPac) values(@descripcion)
go
--Mostrar
Create Procedure sp_McPac
as
select IdcPac as Identificador,DescPac as Descripción from ContPac
go
--Mostrar solo un registro específico
Create Procedure sp_MURcPac
@Index int
as
select IdcPac as Identificador,DescPac as Descripción from ContPac where IdcPac=@Index
go
--Eliminar
Create Procedure sp_EcPac
@Index int
as
delete from ContPac where IdcPac=@Index
go
--Actualizar
Create Procedure sp_AcPac
@Index int,
@descripcion varchar(20)
as
Update ContPac set DescPac=@descripcion where IdcPac=@Index
go
--Obtener Param Salida
Create Procedure sp_RDcPac
@index int,
@descripcion varchar(20) output
as
select @descripcion = DescPac from ContPac where IdcPac = @Index
go

--------------------Trabajando con Tabla diagnosticos
--Insertar
create procedure sp_IDiag
@Categoria varchar(15),
@Descripcion varchar(500)
as
insert into TabDiag(IdDiag,DesDiag) values(@Categoria,@Descripcion)
go
--Mostrar
Create Procedure sp_MDiag
as
select IdDiag as Categoría,DesDiag as Descripción from TabDiag
go
--Mostrar solo un registro específico
Create Procedure sp_MURDiag
@Index Varchar(15)
as
select IdDiag as Categoría,DesDiag as Descripción from TabDiag where IdDiag=@Index
go
--Eliminar
Create Procedure sp_EDiag
@Index Varchar(15)
as
delete from TabDiag where IdDiag=@Index
go
--Actualizar
Create Procedure sp_ADiag
@Index Varchar(15),
@Descripcion varchar(500)
as
Update TabDiag set DesDiag=@Descripcion where IdDiag=@Index
go
--Obtener Param Salida
Create Procedure sp_RDDiag
@Index Varchar(15),
@Categoria varchar(15) output,
@Descripcion varchar(500) output
as
select @Categoria=IdDiag,@Descripcion = DesDiag from TabDiag where IdDiag = @Index
go

--------------------Trabajando con Tabla Tipos de pacientes
--Insertar
create procedure sp_ITipPac
@Codigo char(5),
@Descripcion varchar(20)
as
insert into TipPac(CodTipPac,DescTipPac) values(@Codigo,@Descripcion)
go
--Mostrar
Create Procedure sp_MTipPac
as
select idTipPac as Identificador,CodTipPac as Código,DescTipPac as Descripción from TipPac
go
--Mostrar solo un registro específico
Create Procedure sp_MURTipPac
@Index int
as
select idTipPac as Identificador,CodTipPac as Código,DescTipPac as Descripción from TipPac where IdTipPac = @Index
go
--Eliminar
Create Procedure sp_ETipPac
@Index int
as
delete from TipPac where IdTipPac=@Index
go
--Actualizar
Create Procedure sp_ATipPac
@Index int,
@Codigo char(5),
@Descripcion varchar(20)
as
Update TipPac set CodTipPac=@Codigo,DescTipPac=@Descripcion where IdTipPac=@Index
go
--Obtener Param Salida
Create Procedure sp_RDTipPac
@Index int,
@Codigo char(5) output,
@Descripcion varchar(20) output
as
select @Codigo=CodTipPac,@Descripcion = DescTipPac from TipPac where IdTipPac = @Index
go

--------------------Trabajando con Tabla Enfermeras
--Insertar
create procedure sp_IEnfm
@ApePat varchar(50),
@ApeMat varchar(50),
@Nombre varchar(100),
@IdDocu int,
@NumDoc int,
@Clave	varchar(20)
as
insert into TabEnfm(ApePat,ApeMat,NomEnf,IdDocu,NumDoc,Clave) 
values(@ApePat,@ApeMat,@Nombre,@IdDocu,@NumDoc,@Clave)
go
--Mostrar
Create Procedure sp_MEnfm
as
select IdEnfm as Identificador, ApePat as Ap_Paterno, ApeMat as Ape_Materno, NomEnf as Nombres,
IdDocu as Documento, NumDoc as Numero from TabEnfm 
go
--Mostrar solo un registro específico
Create Procedure sp_MUREnfm
@Index int
as
select IdEnfm as Identificador, ApePat as Ap_Paterno, ApeMat as Ape_Materno, 
NomEnf as Nombres,IdDocu as Documento, NumDoc as Numero from TabEnfm where IdEnfm=@Index
go
--Eliminar
Create Procedure sp_EEnfm
@Index int
as
delete from TabEnfm where IdEnfm=@Index
go
--Actualizar
Create Procedure sp_AEnfm
@Index int,
@ApePat varchar(50),
@ApeMat varchar(50),
@Nombre varchar(100),
@IdDocu int,
@NumDoc int,
@Clave	varchar(20)
as
Update TabEnfm set ApePat=@ApePat, ApeMat=@ApeMat, NomEnf=@Nombre, IdDocu=@IdDocu,
NumDoc=@NumDoc, Clave=@Clave where IdEnfm=@Index
go
--Obtener Param Salida
Create Procedure sp_RDEnfm
@Index int,
@ApePat varchar(50) output,
@ApeMat varchar(50) output,
@Nombre varchar(100) output,
@IdDocu int output,
@NumDoc int output,
@Clave	varchar(20) output
as
select @ApePat=ApePat, @ApeMat=ApeMat, @Nombre=NomEnf,@IdDocu=IdDocu, @NumDoc=NumDoc,@Clave=Clave 
from TabEnfm where IdEnfm=@Index
go


--------------------Trabajando con Tabla Doctores
--Insertar
create procedure sp_IDoct
@ApePat varchar(50),
@ApeMat varchar(50),
@Nombre varchar(100),
@IdDocu int,
@NumDoc int,
@Clave	varchar(20)
as
insert into TabDoct(ApePat,ApeMat,NomDoc,IdDocu,NumDoc,Clave) 
values(@ApePat,@ApeMat,@Nombre,@IdDocu,@NumDoc,@Clave)
go
--Mostrar
Create Procedure sp_MDoct
as
select IdDoct as Identificador, ApePat as Ap_Paterno, ApeMat as Ape_Materno, NomDoc as Nombres,
IdDocu as Documento, NumDoc as Numero from TabDoct
go
--Mostrar solo un registro específico
Create Procedure sp_MURDoct
@Index int
as
select IdDoct as Identificador, ApePat as Ap_Paterno, ApeMat as Ape_Materno, 
NomDoc as Nombres,IdDocu as Documento, NumDoc as Numero from TabDoct where IdDoct=@Index
go
--Eliminar
Create Procedure sp_EDoct
@Index int
as
delete from TabDoct where IdDoct=@Index
go
--Actualizar
Create Procedure sp_ADoct
@Index int,
@ApePat varchar(50),
@ApeMat varchar(50),
@Nombre varchar(100),
@IdDocu int,
@NumDoc int,
@Clave	varchar(20)
as
Update TabDoct set ApePat=@ApePat, ApeMat=@ApeMat, NomDoc=@Nombre, IdDocu=@IdDocu,
NumDoc=@NumDoc, Clave=@Clave where IdDoct=@Index
go
--Obtener Param Salida
Create Procedure sp_RDDoct
@Index int,
@ApePat varchar(50) output,
@ApeMat varchar(50) output,
@Nombre varchar(100) output,
@IdDocu int output,
@NumDoc int output,
@Clave	varchar(20) output
as
select @ApePat=ApePat, @ApeMat=ApeMat, @Nombre=NomDoc,@IdDocu=IdDocu, @NumDoc=NumDoc,@Clave=Clave 
from TabDoct where IdDoct=@Index
go

--------------------Trabajando con Tabla Pacientes
--Insertar
create procedure sp_IPac
@ApePat varchar(50),
@ApeMat varchar(50),
@NomPac varchar(100),
@SexPac char(1),
@FecNac datetime,
@IdDist int,
@IdProv int,
@IdDpto int,
@DomPac varchar(100),
@IdRelg int,
@IdEciv int,
@IdOcup int,
@Centra varchar(100),
@TieDes int,
@TieRes int,
@IdGins int,
@IdDocu int,
@Numdoc int,
@IdIdma int,
@RefPor varchar(100),
@AppApo varchar(50),
@ApmApo varchar(50),
@NomApo varchar(50),
@DirApo varchar(100),
@TelApo int
as
insert into TabPac(ApePat,ApeMat,NomPac,SexPac,FecNac,IdDist,IdProv,IdDpto,DomPac,IdRelg,IdEciv,IdOcup,Centra,TieDes,TieRes,IdGins,IdDocu,Numdoc,IdIdma,RefPor,AppApo,ApmApo,NomApo,DirApo,TelApo) 
values(@ApePat,@ApeMat,@NomPac,@SexPac,@FecNac,@IdDist,@IdProv,@IdDpto,@DomPac,@IdRelg,@IdEciv,@IdOcup,@Centra,@TieDes,@TieRes,@IdGins,@IdDocu,@Numdoc,@IdIdma,@RefPor,@AppApo,@ApmApo,@NomApo,@DirApo,@TelApo)
go
--Mostrar
Create Procedure sp_MPac
as
select 
IdPcte as Identificador, 
ApePat as Ape_Paterno, 
ApeMat as Ape_Materno, 
NomPac as Nombres,
SexPac as Sexo,
FecNac as F_Nacimiento,
DesDist as Distrito,
DesProv as Provincia,
DesDpto as Departamento,
DomPac as Domicilio,
DesRelg as Religion, 	
DesEciv as Est_Civil,
DesOcup as Ocupación,
Centra as C_Trabajo,
TieDes as T_Desocupación,
TieRes as T_Residencia,
DesGins as G_Instrucción,
DesDocu as Tipo_Documento,
NumDoc as Num_Documento,
IdIdma as Idioma,
RefPor as Referido_Por,
AppApo as Ape_Pat_Apoderado,
ApmApo as Ape_Mat_Apoderado,
NomApo as Nombres_Apoderado,
DirApo as Dirección_Apoderado,
TelApo as Teléfono_Apoderado
from tabpac,tabdist,tabprov,tabdpto,tabrelg,TabEciv,tabocup,tabgins,tabdocu 
where 
    tabpac.iddpto=tabdist.iddpto
and tabpac.idprov=tabdist.idprov 
and tabpac.iddist=tabdist.iddist
and tabpac.idprov=tabprov.idprov 
and tabpac.iddpto=tabprov.iddpto
and tabpac.iddpto=tabdpto.iddpto 
and tabpac.IdRelg=tabRelg.idRelg 
and tabpac.IdEciv=tabEciv.IdEciv
and tabpac.idocup=tabocup.idocup
and tabpac.idgins=tabgins.idgins
and tabpac.Iddocu=tabdocu.Iddocu
go
--Mostrar solo un registro específico
Create Procedure sp_MURPac
@Index int
as
select 
IdPcte as Identificador, 
ApePat as Ape_Paterno, 
ApeMat as Ape_Materno, 
NomPac as Nombres,
SexPac as Sexo,
FecNac as F_Nacimiento,
IdDist as Distrito, 
IdProv as Provincia, 
IdDpto as Departamento, 
DomPac as Domicilio,
IdRelg as Religion, 
IdEciv as Est_Civil,
IdOcup as Ocupación,
Centra as C_Trabajo,
TieDes as T_Desocupación,
TieRes as T_Residencia,
IdGins as G_Instrucción,
IdDocu as Tipo_Documento,
NumDoc as Num_Documento,
IdIdma as Idioma,
RefPor as Referido_Por,
AppApo as Ape_Pat_Apoderado,
ApmApo as Ape_Mat_Apoderado,
NomApo as Nombres_Apoderado,
DirApo as Dirección_Apoderado,
TelApo as Teléfono_Apoderado
from TabPac
Where IdPcte = @Index
go
--Eliminar
Create Procedure sp_EPac
@Index int
as
delete from TabPac where IdPcte=@Index
go
--Actualizar
Create Procedure sp_APac
@Index int,
@ApePat varchar(50),
@ApeMat varchar(50),
@NomPac varchar(100),
@SexPac char(1),
@FecNac datetime,
@IdDist int,
@IdProv int,
@IdDpto int,
@DomPac varchar(100),
@IdRelg int,
@IdEciv int,
@IdOcup int,
@Centra varchar(100),
@TieDes int,
@TieRes int,
@IdGins int,
@IdDocu int,
@Numdoc int,
@IdIdma int,
@RefPor varchar(100),
@AppApo varchar(50),
@ApmApo varchar(50),
@NomApo varchar(50),
@DirApo varchar(100),
@TelApo int
as
Update TabPac set 
ApePat = @ApePat, 
ApeMat = @ApeMat, 
NomPac = @NomPac, 
SexPac = @SexPac,
FecNac = @FecNac ,
IdDist = @IdDist, 
IdProv = @IdProv, 
IdDpto = @IdDpto, 
DomPac = @DomPac,
IdRelg = @IdRelg, 
IdEciv = @IdEciv,
IdOcup = @IdOcup,
Centra = @Centra,
TieDes = @TieDes,
TieRes = @TieRes,
IdGins = @IdGins,
IdDocu = @IdDocu,
NumDoc = @NumDoc,
IdIdma = @IdIdma,
RefPor = @RefPor,
AppApo = @AppApo,
ApmApo = @ApmApo,
NomApo = @NomApo,
DirApo = @DirApo,
TelApo = @TelApo
where IdPcte = @Index
go
--Obtener Param Salida
Create Procedure sp_RDPac
@Index int,
@ApePat varchar(50) output,
@ApeMat varchar(50)  output,
@NomPac varchar(100) output,
@SexPac char(1) output,
@FecNac datetime output,
@IdDist int output,
@IdProv int output,
@IdDpto int output,
@DomPac varchar(100) output,
@IdRelg int output,
@IdEciv int output,
@IdOcup int output,
@Centra varchar(100) output,
@TieDes int output,
@TieRes int output,
@IdGins int output,
@IdDocu int output,
@Numdoc int output,
@IdIdma int output,
@RefPor varchar(100) output,
@AppApo varchar(50) output,
@ApmApo varchar(50) output,
@NomApo varchar(50) output,
@DirApo varchar(100)output,
@TelApo int output
as
select 
@ApePat = ApePat, 
@ApeMat = ApeMat, 
@NomPac = NomPac, 
@SexPac = SexPac,
@FecNac = FecNac,
@IdDist = IdDist, 
@IdProv = IdProv, 
@IdDpto = IdDpto, 
@DomPac = DomPac,
@IdRelg = IdRelg, 
@IdEciv = IdEciv,
@IdOcup = IdOcup,
@Centra = Centra,
@TieDes = TieDes,
@TieRes = TieRes,
@IdGins = IdGins,
@IdDocu = IdDocu,
@NumDoc = NumDoc,
@IdIdma = IdIdma,
@RefPor = RefPor,
@AppApo = AppApo,
@ApmApo = ApmApo,
@NomApo = NomApo,
@DirApo = DirApo,
@TelApo = TelApo 
from TabPac
where IdPcte=@Index
go

--Obtener departamentos
create procedure sp_ODpto
as
select IdDpto,DesDpto from tabdpto order by DesDpto
go
--Obtener Provincias
create procedure sp_OProv
@IdDpto int 
as
select IdProv,DesProv from TabProv where IdDpto=@IdDpto
go
--Obtener distritos
create procedure sp_ODist
@IdDpto int, 
@IdProv int 
as
select IdDist,DesDist from TabDist where IdDpto=@IdDpto and IdProv=@IdProv
go


--------------------Trabajando con Tabla Historias Clínicas
--Insertar
create procedure sp_IHraCli
@NroHra int,
@NroIng int,
@FecHra datetime,
@SinTma varchar(500),
@IdDiag Varchar(15),
@FecIng datetime,
@FecEgr datetime,
@TieHos int,
@IdTiph int,
@IdCond int,
@IdPcte int
as
insert into HraCli
(
NroHra,
NroIng,
FecHra,
SinTma,
IdDiag,
FecIng,
FecEgr,
TieHos,
IdTiph,
IdCond,
IdPcte 
) 
values
(
@NroHra,
@NroIng,
@FecHra,
@SinTma,
@IdDiag,
@FecIng,
@FecEgr,
@TieHos,
@IdTiph,
@IdCond,
@IdPcte 
)
go

--Mostrar
Create Procedure sp_MHraCli
as
select 
HraCli.NroHra as Nro_Historia, 
HraCli.FecHra as Fecha_Historia,
HraCli.IdPcte as Id_Pcte,
tabpac.Apepat + ' ' + tabpac.Apemat + ' ' + tabpac.Nompac as Paciente,
HraCli.IdDiag as Diagnóstico
from HraCli,tabpac where Hracli.idpcte=Tabpac.idpcte
go
--Mostrar solo un registro específico
Create Procedure sp_MURHraCli
@Index int
as
select 
NroHra as Nro_Historia, 
NroIng as Nro_Ingreso,
FecHra as Fecha_Creación,
IdPcte as Id_Paciente,
SinTma as Sintoma,
IdDiag as Diagnóstico,
FecIng as Fecha_Ingreso,
FecEgr as Fecha_Egreso,
TieHos as Tiempo_Hosp,
IdTiph as Tipo_Hosp,
IdCond as Cond_Alta
from HraCli
Where NroHra = @Index
go
--Eliminar
Create Procedure sp_EHraCli
@Index int
as
delete from HraCli where NroHra=@Index
go
--Actualizar
Create Procedure sp_AHraCli
@Index int,
@NroHra int,
@NroIng int,
@FecHra datetime,
@SinTma varchar(500),
@IdDiag Varchar(15),
@FecIng datetime,
@FecEgr datetime,
@TieHos int,
@IdTiph int,
@IdCond int
as
Update HraCli set 
NroHra = @NroHra,
NroIng = @NroIng,
FecHra = @FecHra,
SinTma = @SinTma,
IdDiag = @IdDiag,
FecIng = @FecIng,
FecEgr = @FecEgr,
TieHos = @TieHos,
IdTiph = @IdTiph,
IdCond = @IdCond
where NroHra = @Index
go

--Obtener Param Salida
Create Procedure sp_RDHraCli
@Index int,
@NroHra int output,
@NroIng int output,
@FecHra datetime output,
@SinTma varchar(500) output,
@IdDiag Varchar(15) output,
@FecIng datetime output,
@FecEgr datetime output,
@TieHos int output,
@IdTiph int output,
@IdCond int output,
@IdPcte int output
as
select 
@NroHra = NroHra,
@NroIng = NroIng,
@FecHra = FecHra,
@SinTma = SinTma,
@IdDiag = IdDiag,
@FecIng = FecIng,
@FecEgr = FecEgr,
@TieHos = TieHos,
@IdTiph = IdTiph,
@IdCond = IdCond,
@IdPcte = IdPcte
from HraCli
where NroHra=@Index
go

--------------------------------------------------------------------------------------------
--Obtener Tipos de Documentos Para Enfermeras, Doctores y Pacientes o usuarios
Create Procedure sp_MTipDoc 	
as
select * from TabDocu
go
--Para Validar Usuarios 
Create Procedure sp_VUsersE
@NumDoc int,
@Clave varchar(20),
@SN int output,
@SC varchar(20) output
as
select @SN=NumDoc,@SC=clave from TabEnfm where Numdoc=@Numdoc and Clave=@Clave
go
Create Procedure sp_VUsersD
@NumDoc int,
@Clave varchar(20),
@SN int output,
@SC varchar(20) output
as
select @SN=NumDoc,@SC=clave from TabDoct where Numdoc=@Numdoc and Clave=@Clave
go

--Para Permitir Editar (Enfermeras)
Create Procedure sp_PEE
@Index int,
@NumDoc int output
as
select @NumDoc=NumDoc from TabEnfm where IdEnfm=@Index
go
--Para Permitir Editar (Doctores)
Create Procedure sp_PED
@Index int,
@NumDoc int output
as
select @NumDoc=NumDoc from TabDoct where IdDoct=@Index
go

--Para Capturar la informacion de los pacientes
Create procedure sp_CPac
as
select 
IdPcte as Identificador,
Apepat as Ap_Paterno, 
Apemat as Ap_Materno, 
NomPac as Nombres
from TabPac
go
--Para Capturar la informacion de los diagnosticos
create procedure sp_CDiag
as
select 
IdDiag as Identificador,
DesDiag as Descripción
from TabDiag
go

create procedure sp_ContarRegE
as
select count(*) from tabenfm
go
create procedure sp_ContarRegD
as
select count(*) from tabDoct
go


--------------------Trabajando con Tabla Parte Diario Cabecera
--Para Capturar la informacion de las  Hras para la grilla
create procedure sp_CHras
as
select HraCli.NroHra as Nro_Historia, 
HraCli.FecHra as Fecha_Historia, 
HraCli.IdPcte as Id_Paciente,
TabPac.Nompac + ' ' + TabPac.ApePat + ' ' + TabPac.ApeMat as Nombre_Paciente
from HraCli inner join TabPac on HraCli.Idpcte = TabPac.IdPcte
go
--Para mostrar los datos   combo
create procedure sp_SNomDoc
as
select 
iddoct as Identificador, 
apepat +' '+ apemat +' '+  nomdoc as Doctor 
from tabdoct
go

--Insertar cabecera
Create procedure sp_ICabPart
@IdDoct int,
@FecPar datetime
as
insert into cabpartdia(IdDoct,FecPar) 
values (@IdDoct,@FecPar)
go

--Mostrar  Es lo que se va a mostrar en la grilla del modulo principal
Create Procedure sp_MCabPart
as
select 
CabPartDia.IdPart as Parte, 
CabPartDia.IDDoct as Id_Doctor,
TabDoct.Nomdoc + ' ' + TabDoct.Apepat + ' ' + TabDoct.Apemat as Doctor,
CabPartDia.Fecpar as Fecha_Parte
from CabPartDia inner join TabDoct
on CabPartDia.Iddoct=TabDoct.IdDoct
go
--Eliminar
Create Procedure sp_ECabPart
@Index int
as
delete from CabPartDia where IdPart=@Index
go


--------------------Trabajando con Tabla Parte Diario Detalles
Alter procedure sp_LlenarCamposPart
@S3Index int --historia clinica
as
select 
TabPac.Apepat as ApePat, 
TabPac.ApeMat as ApeMat, 
TabPac.NomPac as NomPac, 
Tabpac.SexPac as SexPac,
edad=(
Select case when month(getdate()) - month(TabPac.FecNac) < 0 or day(getdate()) - day(TabPac.FecNac) < 0 then
year(getdate()) - year(TabPac.FecNac) - 1 when month(getdate()) - month(TabPac.FecNac) >= 0 or day(getdate()) - day(TabPac.FecNac) >= 0 
then year(getdate()) - year(TabPac.FecNac)end
),
Procedencia = (
select 
tabdist.desdist 
from tabpac,tabdist,tabprov,tabdpto,hracli 
where 
    tabpac.iddpto=tabdist.iddpto
and tabpac.idprov=tabdist.idprov 
and tabpac.iddist=tabdist.iddist
and tabpac.idprov=tabprov.idprov 
and tabpac.iddpto=tabprov.iddpto
and tabpac.iddpto=tabdpto.iddpto 
and HraCli.NroHra=@S3Index and  TabPac.IdPcte =HraCli.IdPcte
)
from Tabpac, HraCli where HraCli.NroHra=@S3Index and  TabPac.IdPcte =HraCli.IdPcte
go

--Insertar DetPartDia
create procedure sp_IDetPartDia
@IdPart int,
@NroHra int,
@IdcPac int,
@IdDiag varchar(15),
@IdTipPac int,
@IdEnfm int
as
insert into DetPartDia
(IdPart,NroHra,IdcPac,IdDiag,IdTipPac,IdEnfm) 
values
(@IdPart,@NroHra,@IdcPac,@IdDiag,@IdTipPac,@IdEnfm)
go

Create procedure sp_ContadorEstados
@IdcPac int,
@IdPart int
as
select count(idcpac) from detpartdia where idcpac=@IdcPac and idpart=@IdPart 
go

create procedure sp_ContarMujeres
@IdPart int
as
select count(SexPac) as Sexo from tabpac,hracli,detpartdia where SexPac='F' 
and tabpac.idpcte=hracli.idpcte
and hracli.nrohra=detpartdia.nrohra
and detpartdia.idpart=@IdPart 
go
create procedure sp_ContarVarones
@IdPart int
as
select count(SexPac) as Sexo from tabpac,hracli,detpartdia where SexPac='M' 
and tabpac.idpcte=hracli.idpcte
and hracli.nrohra=detpartdia.nrohra
and detpartdia.idpart=@IdPart 
go

---------------
create procedure sp_Niños
@NParte int
as 
select count(Tabpac.Idpcte) as Niños from tabpac,hracli,detpartdia where 
(Select case when month(getdate()) - month(tabpac.Fecnac) < 0 or day(getdate()) - day(tabpac.Fecnac) < 0 then
year(getdate()) - year(tabpac.Fecnac) - 1 
when month(getdate()) - month(tabpac.Fecnac) >= 0 or day(getdate()) - day(tabpac.Fecnac) >= 0 
then year(getdate()) - year(tabpac.Fecnac)end)<=10
and tabpac.idpcte=hracli.idpcte and hracli.nrohra=detpartdia.nrohra and detpartdia.idpart=@NParte
go
create procedure sp_Jovenes
@NParte int
as 
select count(Tabpac.Idpcte) as Jovenes from tabpac,hracli,detpartdia where 
(Select case when month(getdate()) - month(tabpac.Fecnac) < 0 or day(getdate()) - day(tabpac.Fecnac) < 0 then
year(getdate()) - year(tabpac.Fecnac) - 1 
when month(getdate()) - month(tabpac.Fecnac) >= 0 or day(getdate()) - day(tabpac.Fecnac) >= 0 
then year(getdate()) - year(tabpac.Fecnac)end)between 11 and 17
and tabpac.idpcte=hracli.idpcte and hracli.nrohra=detpartdia.nrohra and detpartdia.idpart=@NParte
go
create procedure sp_Adultos
@NParte int
as 
select count(Tabpac.Idpcte) as Adultos from tabpac,hracli,detpartdia where 
(Select case when month(getdate()) - month(tabpac.Fecnac) < 0 or day(getdate()) - day(tabpac.Fecnac) < 0 then
year(getdate()) - year(tabpac.Fecnac) - 1 
when month(getdate()) - month(tabpac.Fecnac) >= 0 or day(getdate()) - day(tabpac.Fecnac) >= 0 
then year(getdate()) - year(tabpac.Fecnac)end)between 18 and 60
and tabpac.idpcte=hracli.idpcte and hracli.nrohra=detpartdia.nrohra and detpartdia.idpart=@NParte
go
create procedure sp_Ancianos
@NParte int
as 
select count(Tabpac.Idpcte) as Ancianos from tabpac,hracli,detpartdia where 
(Select case when month(getdate()) - month(tabpac.Fecnac) < 0 or day(getdate()) - day(tabpac.Fecnac) < 0 then
year(getdate()) - year(tabpac.Fecnac) - 1 
when month(getdate()) - month(tabpac.Fecnac) >= 0 or day(getdate()) - day(tabpac.Fecnac) >= 0 
then year(getdate()) - year(tabpac.Fecnac)end)>=60
and tabpac.idpcte=hracli.idpcte and hracli.nrohra=detpartdia.nrohra and detpartdia.idpart=@NParte
go
-----------------------------------------------------
--Mostrar
Create Procedure sp_MDetPartDia
@NParte int
as
select 
detpartdia.IdPart as Parte,
detpartdia.NroHra as Historia,
TabPac.Apepat + ' ' + TabPac.ApeMat + ' ' + TabPac.NomPac as Paciente, 
Tabpac.SexPac as Sexo,
edad=(Select case when month(getdate()) - month(TabPac.FecNac) < 0 or day(getdate()) - day(TabPac.FecNac) < 0 
then year(getdate()) - year(TabPac.FecNac) - 1 
when month(getdate()) - month(TabPac.FecNac) >= 0 or day(getdate()) - day(TabPac.FecNac) >= 0 
then year(getdate()) - year(TabPac.FecNac)end),
ContPac.DescPac as Estado,
detpartdia.Iddiag as Diagnostico,
TipPac.CodTipPac as Categoría,
tabdist.desdist as Procedencia
from Tabpac, HraCli,detpartdia,ContPac,tabdist,tabprov,tabdpto,TipPac 
where 
ContPac.IdcPac=detpartdia.IdcPac 
and TipPac.IdTipPac = detpartdia.IdTipPac
and tabpac.iddpto=tabdist.iddpto
and tabpac.idprov=tabdist.idprov 
and tabpac.iddist=tabdist.iddist
and tabpac.idprov=tabprov.idprov 
and tabpac.iddpto=tabprov.iddpto
and tabpac.iddpto=tabdpto.iddpto  
and HraCli.NroHra=detpartdia.NroHra 
and TabPac.IdPcte =HraCli.IdPcte 
and detpartdia.IdPart=@NParte 
go

create procedure sp_ADetPartDia
@IdcPac int,
@IdDiag varchar(15),
@IdTipPac int,
@IdPart int,
@NroHra int
as
update DetPartDia set IdcPac=@IdcPac, IdDiag=@IdDiag, IdTipPac=@IdTipPac where IdPart=@IdPart and NroHra=@NroHra
go

create procedure sp_LlenarCamposPartCombos
@IdcPac int output,
@IdDiag varchar(15) output,
@IdTipPac int output,
@IdPart int,
@NroHra int
as 
select @IdcPac=IdcPac,@IdDiag=IdDiag,@IdTipPac=IdTipPac from detpartdia where Idpart=@Idpart and NroHra=@NroHra
go


