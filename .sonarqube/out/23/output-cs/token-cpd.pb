o
m/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Usings.cs≥d
n/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB `
)` a
;a b
if

 
(

 
File

 
.

 
Exists

 
(

 #
solutionLevelConfigPath

 +
)

+ ,
)

, -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
if 
( 
builder 
. 
Environment 
. 
IsProduction $
($ %
)% &
)& '
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB T
)T U
;U V
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
builder 
. 
Host 
. 

UseSerilog 
( 
( 
context  
,  !
configuration" /
)/ 0
=>1 3
configuration4 A
.A B
ReadFromB J
.J K
ConfigurationK X
(X Y
contextY `
.` a
Configurationa n
)n o
)o p
;p q
if!! 
(!! 
builder!! 
.!! 
Environment!! 
.!! 
IsDevelopment!! %
(!!% &
)!!& '
)!!' (
{"" 
switch## 

(## 
builder## 
.## 
Configuration## !
.##! "

GetSection##" ,
(##, -
$str##- 7
)##7 8
.##8 9

GetSection##9 C
(##C D
$str##D V
)##V W
.##W X
Value##X ]
)##] ^
{$$ 
case%% 
$str%% 
:%% 
break'' 
;'' 
case(( 
$str(( 
:(( 
builder)) 
.)) 
Services)) 
.)) 
AddDbContext)) )
<))) *!
NotificationDbContext))* ?
>))? @
())@ A
options))A H
=>))I K
options))L S
.))S T
UseSqlServer))T `
())` a
builder))a h
.))h i
Configuration))i v
.))v w 
GetConnectionString	))w ä
(
))ä ã
$str
))ã ú
)
))ú ù
)
))ù û
)
))û ü
;
))ü †
break** 
;** 
}++ 
}-- 
if// 
(// 
builder// 
.// 
Environment// 
.// 
IsProduction// $
(//$ %
)//% &
)//& '
{00 
switch11 

(11 
builder11 
.11 
Configuration11 !
.11! "

GetSection11" ,
(11, -
$str11- 7
)117 8
.118 9

GetSection119 C
(11C D
$str11D V
)11V W
.11W X
Value11X ]
)11] ^
{22 
case33 
$str33 
:33 
break55 
;55 
case66 
$str66 
:66 
builder77 
.77 
Services77 
.77 
AddDbContext77 )
<77) *!
NotificationDbContext77* ?
>77? @
(77@ A
options77A H
=>77I K
options77L S
.77S T
UseSqlServer77T `
(77` a
builder77a h
.77h i
Configuration77i v
.77v w 
GetConnectionString	77w ä
(
77ä ã
$str
77ã ú
)
77ú ù
)
77ù û
)
77û ü
;
77ü †
break88 
;88 
}99 
}:: 
builder<< 
.<< 
Services<< 
.<< 
AddCors<< 
(<< 
o<< 
=><< 
{== 
o>> 
.>> 
AddDefaultPolicy>> 
(>> 
builder?? 
=>?? 
{@@ 	
builderAA 
.AA 
AllowAnyOriginAA "
(AA" #
)AA# $
.BB 
AllowAnyHeaderBB "
(BB" #
)BB# $
.CC 
AllowAnyMethodCC "
(CC" #
)CC# $
;CC$ %
}EE 	
)EE	 

;EE
 
}FF 
)FF 
;FF 
builderHH 
.HH 
ServicesHH 
.HH !
AddNotificationModuleHH &
(HH& '
builderHH' .
.HH. /
ConfigurationHH/ <
)HH< =
;HH= >
builderKK 
.KK 
ServicesKK 
.KK 
AddExceptionHandlerKK $
<KK$ %%
HttpGlobalExceptionFilterKK% >
>KK> ?
(KK? @
)KK@ A
;KKA B
builderLL 
.LL 
ServicesLL 
.LL 
AddProblemDetailsLL "
(LL" #
)LL# $
;LL$ %
builderNN 
.NN 
ServicesNN 
.NN 
AddControllersNN 
(NN  
)NN  !
;NN! "
builderQQ 
.QQ 
ServicesQQ 
.RR 
AddApiVersioningRR 
(RR 
optionsRR 
=>RR  
{SS 
optionsTT 
.TT 
DefaultApiVersionTT !
=TT" #
newTT$ '

ApiVersionTT( 2
(TT2 3
$numTT3 4
,TT4 5
$numTT6 7
)TT7 8
;TT8 9
optionsUU 
.UU /
#AssumeDefaultVersionWhenUnspecifiedUU 3
=UU4 5
trueUU6 :
;UU: ;
optionsVV 
.VV 
ReportApiVersionsVV !
=VV" #
trueVV$ (
;VV( )
}WW 
)WW 
.XX 
AddApiExplorerXX 
(XX 
optionsXX 
=>XX 
{YY 
optionsZZ 
.ZZ 
GroupNameFormatZZ 
=ZZ  !
$strZZ" *
;ZZ* +
options[[ 
.[[ %
SubstituteApiVersionInUrl[[ )
=[[* +
true[[, 0
;[[0 1
}\\ 
)\\ 
;\\ 
builder^^ 
.^^ 
Services^^ 
.^^ #
AddEndpointsApiExplorer^^ (
(^^( )
)^^) *
;^^* +
builder__ 
.__ 
Services__ 
.__ 
AddTransient__ 
<__ 
IConfigureOptions__ /
<__/ 0
SwaggerGenOptions__0 A
>__A B
,__B C#
SwaggerConfigureOptions__D [
>__[ \
(__\ ]
)__] ^
;__^ _
builder`` 
.`` 
Services`` 
.`` 
AddSwaggerGen`` 
(`` 
options`` &
=>``' )
{aa 
optionsbb 
.bb 
OperationFilterbb 
<bb  
SwaggerDefaultValuesbb 0
>bb0 1
(bb1 2
)bb2 3
;bb3 4
}ee 
)ee 
;ee 
varqq 
appqq 
=qq 	
builderqq
 
.qq 
Buildqq 
(qq 
)qq 
;qq 
iftt 
(tt 
apptt 
.tt 
Environmenttt 
.tt 
IsDevelopmenttt !
(tt! "
)tt" #
)tt# $
{uu 
appvv 
.vv 

UseSwaggervv 
(vv 
optionsvv 
=>vv 
{ww 
optionsxx 
.xx 
PreSerializeFiltersxx #
.xx# $
Addxx$ '
(xx' (
(xx( )
swaggerxx) 0
,xx0 1
reqxx2 5
)xx5 6
=>xx7 9
{yy 	
swaggerzz 
.zz 
Serverszz 
=zz 
newzz !
Listzz" &
<zz& '
OpenApiServerzz' 4
>zz4 5
(zz5 6
)zz6 7
{zz8 9
newzz: =
OpenApiServerzz> K
(zzK L
)zzL M
{zzN O
UrlzzP S
=zzT U
$"zzV X
$strzzX `
{zz` a
reqzza d
.zzd e
Hostzze i
}zzi j
"zzj k
}zzl m
}zzn o
;zzo p
}{{ 	
){{	 

;{{
 
}|| 
)|| 
;|| 
app 
. 
UseSwaggerUI 
( 
options 
=> 
{
ÄÄ 
var
ÅÅ $
ApiVersionDescriptions
ÅÅ "
=
ÅÅ# $
app
ÅÅ% (
.
ÅÅ( )!
DescribeApiVersions
ÅÅ) <
(
ÅÅ< =
)
ÅÅ= >
;
ÅÅ> ?
foreach
ÉÉ 
(
ÉÉ 
var
ÉÉ 
desc
ÉÉ 
in
ÉÉ $
ApiVersionDescriptions
ÉÉ 3
)
ÉÉ3 4
{
ÑÑ 	
options
ÖÖ 
.
ÖÖ 
SwaggerEndpoint
ÖÖ #
(
ÖÖ# $
$"
ÖÖ$ &
$str
ÖÖ& 1
{
ÖÖ1 2
desc
ÖÖ2 6
.
ÖÖ6 7
	GroupName
ÖÖ7 @
}
ÖÖ@ A
$str
ÖÖA N
"
ÖÖN O
,
ÖÖO P
$"
ÖÖQ S
$str
ÖÖS d
{
ÖÖd e
desc
ÖÖe i
.
ÖÖi j

ApiVersion
ÖÖj t
.
ÖÖt u
ToString
ÖÖu }
(
ÖÖ} ~
)
ÖÖ~ 
}ÖÖ Ä
"ÖÖÄ Å
)ÖÖÅ Ç
;ÖÖÇ É
options
ÜÜ 
.
ÜÜ &
DefaultModelsExpandDepth
ÜÜ ,
(
ÜÜ, -
-
ÜÜ- .
$num
ÜÜ. /
)
ÜÜ/ 0
;
ÜÜ0 1
options
áá 
.
áá 
DocExpansion
áá  
(
áá  !
Swashbuckle
áá! ,
.
áá, -

AspNetCore
áá- 7
.
áá7 8
	SwaggerUI
áá8 A
.
ááA B
DocExpansion
ááB N
.
ááN O
None
ááO S
)
ááS T
;
ááT U
}
àà 	
}
ââ 
)
ââ 
;
ââ 
}ää 
appåå 
.
åå !
UseHttpsRedirection
åå 
(
åå 
)
åå 
;
åå 
appéé 
.
éé 
UseAuthorization
éé 
(
éé 
)
éé 
;
éé 
appêê 
.
êê 
UseCors
êê 
(
êê 
)
êê 
;
êê 
appíí 
.
íí 
MapControllers
íí 
(
íí 
)
íí 
;
íí 
appîî 
.
îî 
Run
îî 
(
îî 
)
îî 	
;
îî	 
Æ
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
Notification		 
.		 
Presentation		 +
.		+ ,
OpenAPI		, 3
{

 
public 

class #
SwaggerConfigureOptions (
:) *
IConfigureOptions+ <
<< =
SwaggerGenOptions= N
>N O
{ 
private 
readonly *
IApiVersionDescriptionProvider 7
	_provider8 A
;A B
public #
SwaggerConfigureOptions &
(& '*
IApiVersionDescriptionProvider' E
providerF N
)N O
=>P R
	_providerS \
=] ^
provider_ g
;g h
public 
void 
	Configure 
( 
SwaggerGenOptions /
options0 7
)7 8
{ 	
foreach 
( 
var 
desc 
in  
	_provider! *
.* +"
ApiVersionDescriptions+ A
)A B
{ 
options 
. 

SwaggerDoc "
(" #
desc# '
.' (
	GroupName( 1
,1 2#
CreateInfoForApiVersion3 J
(J K
descK O
)O P
)P Q
;Q R
} 
} 	
private 
static 
OpenApiInfo "#
CreateInfoForApiVersion# :
(: ;!
ApiVersionDescription; P
descriptionQ \
)\ ]
{ 	
var 
info 
= 
new 
OpenApiInfo &
{ 
Title 
= 
$str J
,J K
Version 
= 
description %
.% &

ApiVersion& 0
.0 1
ToString1 9
(9 :
): ;
,; <
Description 
= 
$str J
,J K
Contact 
= 
new 
OpenApiContact ,
{- .
Name/ 3
=4 5
$str6 S
,S T
EmailU Z
=[ \
$str	] É
}
Ñ Ö
,
Ö Ü
License   
=   
new   
OpenApiLicense   ,
{  - .
Name  / 3
=  4 5
$str  6 M
}  N O
,  O P

Extensions"" 
="" 
new""  

Dictionary""! +
<""+ ,
string"", 2
,""2 3
IOpenApiExtension""4 E
>""E F
{## 
{$$ 
$str$$ %
,$$% &
new$$' *
OpenApiObject$$+ 8
{%%  !
{&&$ %
$str&&% *
,&&* +
new&&, /
OpenApiString&&0 =
(&&= >
$str&&> @
)&&@ A
}&&A B
,&&B C
{''$ %
$str''& /
,''/ 0
new''1 4
OpenApiString''5 B
(''B C
$str''C E
)''E F
}''F G
}((  !
})) 
}** 
}++ 
;++ 
return-- 
info-- 
;-- 
}.. 	
}11 
}22 Ê%
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
Notification 
. 
Presentation +
.+ ,
OpenAPI, 3
{		 
public

 

class

  
SwaggerDefaultValues

 %
:

& '
IOperationFilter

( 8
{ 
public 
void 
Apply 
( 
OpenApiOperation *
	operation+ 4
,4 5"
OperationFilterContext6 L
contextM T
)T U
{ 	
var 
apiDescription 
=  
context! (
.( )
ApiDescription) 7
;7 8
	operation 
. 

Deprecated  
|=! #
apiDescription$ 2
.2 3
IsDeprecated3 ?
(? @
)@ A
;A B
foreach 
( 
var 
responseType %
in& (
context) 0
.0 1
ApiDescription1 ?
.? @"
SupportedResponseTypes@ V
)V W
{ 
var 
responseKey 
=  !
responseType" .
.. /
IsDefaultResponse/ @
?A B
$strC L
:M N
responseTypeO [
.[ \

StatusCode\ f
.f g
ToStringg o
(o p
)p q
;q r
var 
response 
= 
	operation (
.( )
	Responses) 2
[2 3
responseKey3 >
]> ?
;? @
foreach 
( 
var 
contentType (
in) +
response, 4
.4 5
Content5 <
.< =
Keys= A
)A B
{ 
if 
( 
responseType $
.$ %
ApiResponseFormats% 7
.7 8
All8 ;
(; <
x< =
=>> @
xA B
.B C
	MediaTypeC L
!=M O
contentTypeP [
)[ \
)\ ]
{ 
response  
.  !
Content! (
.( )
Remove) /
(/ 0
contentType0 ;
); <
;< =
} 
} 
} 
if 
( 
	operation 
. 

Parameters $
==% '
null( ,
), -
{   
return!! 
;!! 
}"" 
foreach$$ 
($$ 
var$$ 
	parameter$$ "
in$$# %
	operation$$& /
.$$/ 0

Parameters$$0 :
)$$: ;
{%% 
var&& 
description&& 
=&&  !
apiDescription&&" 0
.&&0 1!
ParameterDescriptions&&1 F
.&&F G
First&&G L
(&&L M
p&&M N
=>&&O Q
p&&R S
.&&S T
Name&&T X
==&&Y [
	parameter&&\ e
.&&e f
Name&&f j
)&&j k
;&&k l
	parameter(( 
.(( 
Description(( %
??=((& )
description((* 5
.((5 6
ModelMetadata((6 C
?((C D
.((D E
Description((E P
;((P Q
if** 
(** 
	parameter** 
.** 
Schema** $
.**$ %
Default**% ,
==**- /
null**0 4
&&**5 7
description++  
.++  !
DefaultValue++! -
!=++. 0
null++1 5
&&++6 8
description,,  
.,,  !
DefaultValue,,! -
is,,. 0
not,,1 4
DBNull,,5 ;
&&,,< >
description--  
.--  !
ModelMetadata--! .
is--/ 1
ModelMetadata--2 ?
modelMetadata--@ M
)--M N
{.. 
var00 
json00 
=00 
JsonSerializer00 -
.00- .
	Serialize00. 7
(007 8
description008 C
.00C D
DefaultValue00D P
,00P Q
modelMetadata00R _
.00_ `
	ModelType00` i
)00i j
;00j k
	parameter11 
.11 
Schema11 $
.11$ %
Default11% ,
=11- .
OpenApiAnyFactory11/ @
.11@ A
CreateFromJson11A O
(11O P
json11P T
)11T U
;11U V
}22 
	parameter44 
.44 
Required44 "
|=44# %
description44& 1
.441 2

IsRequired442 <
;44< =
}55 
}66 	
}77 
}88 ı
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/ModuleExtensions.cs
	namespace 	
Modules
 
. 
Notification 
. 
Presentation +
{ 
public 

static 
class 
ModuleExtensions (
{ 
public		 
static		 
IServiceCollection		 (!
AddNotificationModule		) >
(		> ?
this		? C
IServiceCollection		D V
services		W _
,		_ `
IConfiguration		a o
configuration		p }
)		} ~
{

 	
services 
. )
AddNotificationInfrastructure .
(. /
configuration/ <
)< =
;= >
services 
. 

AddMediatR 
(  
cfg  #
=>$ &
cfg' *
.* +
AsTransient+ 6
(6 7
)7 8
,8 9
typeof: @
(@ A#
SendNotificationHandlerA X
)X Y
.Y Z
AssemblyZ b
)b c
;c d
services 
. 
	AddScoped 
< #
INotificationRepository 6
,6 7"
NotificationRepository8 N
>N O
(O P
)P Q
;Q R
services 
. 
	AddScoped 
< 
INotificationSender 2
,2 3
NotificationService4 G
>G H
(H I
)I J
;J K
services 
. 
	AddScoped 
< 

ISmsSender )
,) *
	SmsSender+ 4
>4 5
(5 6
)6 7
;7 8
return 
services 
; 
} 	
} 
} §
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Filters/HttpGlobalExceptionFilter.cs
	namespace 	
Modules
 
. 
Notification 
. 
Presentation +
.+ ,
Filters, 3
{ 
public 

class %
HttpGlobalExceptionFilter *
:+ ,
IExceptionHandler- >
{ 
public 
readonly 
ILogger 
<  %
HttpGlobalExceptionFilter  9
>9 :
_logger; B
;B C
public

 %
HttpGlobalExceptionFilter

 (
(

( )
ILogger

) 0
<

0 1%
HttpGlobalExceptionFilter

1 J
>

J K
logger

L R
)

R S
{ 	
_logger 
= 
logger 
; 
} 	
public 
async 
	ValueTask 
< 
bool #
># $
TryHandleAsync% 3
(3 4
HttpContext4 ?
httpContext@ K
,K L
	ExceptionM V
	exceptionW `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 	
_logger 
. 
LogError 
( 
	exception &
,& '
$str( G
,G H
	exceptionI R
.R S
MessageS Z
)Z [
;[ \
var 
problemDetails 
=  
new! $
ProblemDetails% 3
{ 
Status 
= 
StatusCodes $
.$ %(
Status500InternalServerError% A
,A B
Title 
= 
$str &
,& '
Detail 
= 
	exception "
." #
InnerException# 1
!1 2
.2 3
Message3 :
} 
; 
httpContext 
. 
Response  
.  !

StatusCode! +
=, -
problemDetails. <
.< =
Status= C
.C D
ValueD I
;I J
await 
httpContext 
. 
Response &
.& '
WriteAsJsonAsync' 7
(7 8
problemDetails8 F
,F G
cancellationTokenH Y
)Y Z
;Z [
return 
true 
; 
}   	
}!! 
}## ˛
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Controllers/v2/NotificationController.cs
	namespace 	
Modules
 
. 
Notification 
. 
Presentation +
.+ ,
Controllers, 7
.7 8
v28 :
;: ;
[		 
ApiController		 
]		 
[

 

ApiVersion

 
(

 
$str

 
)

 
]

 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class "
NotificationController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
ILogger 
< "
NotificationController 3
>3 4
_logger5 <
;< =
private 
readonly 
	IMediator 
	_mediator (
;( )
public 
"
NotificationController !
(! "
ILogger" )
<* +"
NotificationController+ A
>A B
loggerC I
,I J
	IMediatorK T
mediatorU ]
)] ^
{ 
_logger 
= 
logger 
; 
	_mediator 
= 
mediator 
; 
} 
[ 
HttpPost 
] 
public 

async 
Task 
< 
IActionResult #
># $
SendNotification% 5
(5 6
[6 7
FromBody7 ?
]? @#
SendNotificationRequestA X
requestY `
)` a
{ 
var 
notificationId 
= 
await "
	_mediator# ,
., -
Send- 1
(1 2
new2 5#
SendNotificationCommand6 M
(M N
requestN U
)U V
)V W
;W X
return 
Ok 
( 
notificationId  
)  !
;! "
} 
} ‘1
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Controllers/v1/NotificationController.cs
	namespace 	
Modules
 
. 
Notification 
. 
Presentation +
.+ ,
Controllers, 7
.7 8
v18 :
;: ;
[		 
ApiController		 
]		 
[

 

ApiVersion

 
(

 
$str

 
)

 
]

 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class "
NotificationController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
ILogger 
< "
NotificationController 3
>3 4
_logger5 <
;< =
private 
readonly 
	IMediator 
	_mediator (
;( )
public 
"
NotificationController !
(! "
ILogger" )
<* +"
NotificationController+ A
>A B
loggerC I
,I J
	IMediatorK T
mediatorU ]
)] ^
{ 
_logger 
= 
logger 
; 
	_mediator 
= 
mediator 
; 
} 
[11 
HttpGet11 
]11 
[22 
Route22 

(22
 
$str22 
)22 
]22 
[33 
AllowAnonymous33 
]33 
public44 

IActionResult44 
GetNotificationType44 ,
(44, -
)44- .
{55 
var66 
types66 
=66 
Enum66 
.66 
	GetValues66 "
(66" #
typeof66# )
(66) *
NotificationType66* :
)66: ;
)66; <
.77  
Cast77  $
<77$ %
NotificationType77% 5
>775 6
(776 7
)777 8
.88  
Select88  &
(88& '
e88' (
=>88) +
new88, /
{99  
Id::# %
=::& '
(::( )
int::) ,
)::, -
e::- .
,::. /
Name;;# '
=;;( )
e;;* +
.;;+ ,
ToString;;, 4
(;;4 5
);;5 6
,;;6 7
DisplayName<<# .
=<</ 0
e<<1 2
.<<2 3
GetType<<3 :
(<<: ;
)<<; <
.==1 2
GetField==2 :
(==: ;
e==; <
.==< =
ToString=== E
(==E F
)==F G
)==G H
!==H I
.>>1 2
GetCustomAttribute>>2 D
<>>D E 
DescriptionAttribute>>E Y
>>>Y Z
(>>Z [
)>>[ \
?>>\ ]
.??1 2
Description??2 =
}AA  
)AA  !
;AA! "
returnBB 
OkBB 
(BB 
typesBB 
)BB 
;BB 
}CC 
[FF 
HttpGetFF 
]FF 
[GG 
RouteGG 

(GG
 
$strGG 
)GG  
]GG  !
[HH 
AllowAnonymousHH 
]HH 
publicII 

IActionResultII !
GetNotificationStatusII .
(II. /
)II/ 0
{JJ 
varKK 
typesKK 
=KK 
EnumKK 
.KK 
	GetValuesKK "
(KK" #
typeofKK# )
(KK) *
NotificationStatusKK* <
)KK< =
)KK= >
.LL  
CastLL  $
<LL$ %
NotificationStatusLL% 7
>LL7 8
(LL8 9
)LL9 :
.MM  
SelectMM  &
(MM& '
eMM' (
=>MM) +
newMM, /
{NN  
IdOO# %
=OO& '
(OO( )
intOO) ,
)OO, -
eOO- .
,OO. /
NamePP# '
=PP( )
ePP* +
.PP+ ,
ToStringPP, 4
(PP4 5
)PP5 6
,PP6 7
DisplayNameQQ# .
=QQ/ 0
eQQ1 2
.QQ2 3
GetTypeQQ3 :
(QQ: ;
)QQ; <
.RR1 2
GetFieldRR2 :
(RR: ;
eRR; <
.RR< =
ToStringRR= E
(RRE F
)RRF G
)RRG H
!RRH I
.SS1 2
GetCustomAttributeSS2 D
<SSD E 
DescriptionAttributeSSE Y
>SSY Z
(SSZ [
)SS[ \
?SS\ ]
.TT1 2
DescriptionTT2 =
}VV  
)VV  !
;VV! "
returnWW 
OkWW 
(WW 
typesWW 
)WW 
;WW 
}XX 
[]] 
HttpPost]] 
]]] 
[^^ 
Route^^ 

(^^
 
$str^^ 
)^^ 
]^^ 
public__ 

async__ 
Task__ 
<__ 
IActionResult__ #
>__# $
SendNotification__% 5
(__5 6
[__6 7
FromBody__7 ?
]__? @&
SendNotificationRequestDto__A [
values__\ b
)__b c
{`` #
SendNotificationRequestaa 
requestaa  '
=aa( )
newaa* -#
SendNotificationRequestaa. E
(aaE F
valuesaaF L
.aaL M
UserIdaaM S
,aaS T
$"aaU W
{aaW X
valuesaaX ^
.aa^ _
Subjectaa_ f
}aaf g
$straag h
{aah i
valuesaai o
.aao p
DisplayNameaap {
}aa{ |
"aa| }
,aa} ~
values	aa Ö
.
aaÖ Ü
Message
aaÜ ç
,
aaç é
values
aaè ï
.
aaï ñ
Type
aañ ö
)
aaö õ
;
aaõ ú
varcc 
notificationIdcc 
=cc 
awaitcc "
	_mediatorcc# ,
.cc, -
Sendcc- 1
(cc1 2
newcc2 5#
SendNotificationCommandcc6 M
(ccM N
requestccN U
)ccU V
)ccV W
;ccW X
returndd 
Okdd 
(dd 
notificationIddd  
)dd  !
;dd! "
}ff 
}gg 