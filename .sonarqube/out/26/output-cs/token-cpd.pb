j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Usings.cs∑n
i/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB `
)` a
;a b
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
if 
( 
builder 
. 
Environment 
. 
IsProduction $
($ %
)% &
)& '
{ 
var   
currentDirectory   
=   
	Directory   $
.  $ %
GetCurrentDirectory  % 8
(  8 9
)  9 :
;  : ;
var!! 
solutionDirectory!! 
=!! 
	Directory!! %
.!!% &
	GetParent!!& /
(!!/ 0
currentDirectory!!0 @
)!!@ A
?!!A B
.!!B C
Parent!!C I
?!!I J
.!!J K
FullName!!K S
??!!T V
$str!!W Y
;!!Y Z
var"" #
solutionLevelConfigPath"" 
=""  !
Path""" &
.""& '
Combine""' .
("". /
solutionDirectory""/ @
,""@ A
$str""B T
)""T U
;""U V
if$$ 
($$ 
File$$ 
.$$ 
Exists$$ 
($$ #
solutionLevelConfigPath$$ +
)$$+ ,
)$$, -
{%% 
builder&& 
.&& 
Configuration&& 
.&& 
AddJsonFile&& )
(&&) *#
solutionLevelConfigPath&&* A
,&&A B
optional&&C K
:&&K L
false&&M R
,&&R S
reloadOnChange&&T b
:&&b c
true&&d h
)&&h i
;&&i j
}'' 
}(( 
builder++ 
.++ 
Host++ 
.++ 

UseSerilog++ 
(++ 
(++ 
context++  
,++  !
configuration++" /
)++/ 0
=>++1 3
configuration++4 A
.++A B
ReadFrom++B J
.++J K
Configuration++K X
(++X Y
context++Y `
.++` a
Configuration++a n
)++n o
)++o p
;++p q
if// 
(// 
builder// 
.// 
Environment// 
.// 
IsDevelopment// %
(//% &
)//& '
)//' (
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
<77) *
FinanceDbContext77* :
>77: ;
(77; <
options77< C
=>77D F
options77G N
.77N O
UseSqlServer77O [
(77[ \
builder77\ c
.77c d
Configuration77d q
.77q r 
GetConnectionString	77r Ö
(
77Ö Ü
$str
77Ü ó
)
77ó ò
)
77ò ô
)
77ô ö
;
77ö õ
break88 
;88 
}99 
};; 
if== 
(== 
builder== 
.== 
Environment== 
.== 
IsProduction== $
(==$ %
)==% &
)==& '
{>> 
switch?? 

(?? 
builder?? 
.?? 
Configuration?? !
.??! "

GetSection??" ,
(??, -
$str??- 7
)??7 8
.??8 9

GetSection??9 C
(??C D
$str??D V
)??V W
.??W X
Value??X ]
)??] ^
{@@ 
caseAA 
$strAA 
:AA 
breakCC 
;CC 
caseDD 
$strDD 
:DD 
builderEE 
.EE 
ServicesEE 
.EE 
AddDbContextEE )
<EE) *
FinanceDbContextEE* :
>EE: ;
(EE; <
optionsEE< C
=>EED F
optionsEEG N
.EEN O
UseSqlServerEEO [
(EE[ \
builderEE\ c
.EEc d
ConfigurationEEd q
.EEq r 
GetConnectionString	EEr Ö
(
EEÖ Ü
$str
EEÜ ó
)
EEó ò
)
EEò ô
)
EEô ö
;
EEö õ
breakFF 
;FF 
}GG 
}HH 
builderJJ 
.JJ 
ServicesJJ 
.JJ 
AddCorsJJ 
(JJ 
oJJ 
=>JJ 
{KK 
oLL 
.LL 
AddDefaultPolicyLL 
(LL 
builderMM 
=>MM 
{NN 	
builderOO 
.OO 
AllowAnyOriginOO "
(OO" #
)OO# $
.PP 
AllowAnyHeaderPP "
(PP" #
)PP# $
.QQ 
AllowAnyMethodQQ "
(QQ" #
)QQ# $
;QQ$ %
}SS 	
)SS	 

;SS
 
}TT 
)TT 
;TT 
builderuu 
.uu 
Servicesuu 
.uu 
AddFinanceModuleuu !
(uu! "
builderuu" )
.uu) *
Configurationuu* 7
)uu7 8
;uu8 9
builder|| 
.|| 
Services|| 
.|| 
AddExceptionHandler|| $
<||$ %%
HttpGlobalExceptionFilter||% >
>||> ?
(||? @
)||@ A
;||A B
builder}} 
.}} 
Services}} 
.}} 
AddProblemDetails}} "
(}}" #
)}}# $
;}}$ %
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builderÅÅ 
.
ÅÅ 
Services
ÅÅ 
.
ÇÇ 
AddApiVersioning
ÇÇ 
(
ÇÇ 
options
ÇÇ 
=>
ÇÇ  
{
ÉÉ 
options
ÑÑ 
.
ÑÑ 
DefaultApiVersion
ÑÑ !
=
ÑÑ" #
new
ÑÑ$ '

ApiVersion
ÑÑ( 2
(
ÑÑ2 3
$num
ÑÑ3 4
,
ÑÑ4 5
$num
ÑÑ6 7
)
ÑÑ7 8
;
ÑÑ8 9
options
ÖÖ 
.
ÖÖ 1
#AssumeDefaultVersionWhenUnspecified
ÖÖ 3
=
ÖÖ4 5
true
ÖÖ6 :
;
ÖÖ: ;
options
ÜÜ 
.
ÜÜ 
ReportApiVersions
ÜÜ !
=
ÜÜ" #
true
ÜÜ$ (
;
ÜÜ( )
}
áá 
)
áá 
.
àà 
AddApiExplorer
àà 
(
àà 
options
àà 
=>
àà 
{
ââ 
options
ää 
.
ää 
GroupNameFormat
ää 
=
ää  !
$str
ää" *
;
ää* +
options
ãã 
.
ãã '
SubstituteApiVersionInUrl
ãã )
=
ãã* +
true
ãã, 0
;
ãã0 1
}
åå 
)
åå 
;
åå 
builderéé 
.
éé 
Services
éé 
.
éé /
!AddFluentValidationAutoValidation
éé 2
(
éé2 3
)
éé3 4
;
éé4 5
builderèè 
.
èè 
Services
èè 
.
èè 1
#AddValidatorsFromAssemblyContaining
èè 4
<
èè4 5
BankDtoValidator
èè5 E
>
èèE F
(
èèF G
)
èèG H
;
èèH I
builderìì 
.
ìì 
Services
ìì 
.
ìì %
AddEndpointsApiExplorer
ìì (
(
ìì( )
)
ìì) *
;
ìì* +
builderîî 
.
îî 
Services
îî 
.
îî 
AddTransient
îî 
<
îî 
IConfigureOptions
îî /
<
îî/ 0
SwaggerGenOptions
îî0 A
>
îîA B
,
îîB C%
SwaggerConfigureOptions
îîD [
>
îî[ \
(
îî\ ]
)
îî] ^
;
îî^ _
builderïï 
.
ïï 
Services
ïï 
.
ïï 
AddSwaggerGen
ïï 
(
ïï 
options
ïï &
=>
ïï' )
{ññ 
options
óó 
.
óó 
OperationFilter
óó 
<
óó "
SwaggerDefaultValues
óó 0
>
óó0 1
(
óó1 2
)
óó2 3
;
óó3 4
options
òò 
.
òò  
IncludeXmlComments
òò 
(
òò 
Path
òò #
.
òò# $
Combine
òò$ +
(
òò+ ,

AppContext
òò, 6
.
òò6 7
BaseDirectory
òò7 D
,
òòD E
$"
òòF H
{
òòH I
Assembly
òòI Q
.
òòQ R"
GetExecutingAssembly
òòR f
(
òòf g
)
òòg h
.
òòh i
GetName
òòi p
(
òòp q
)
òòq r
.
òòr s
Name
òòs w
}
òòw x
$str
òòx |
"
òò| }
)
òò} ~
)
òò~ 
;òò Ä
}öö 
)
öö 
;
öö 
varúú 
app
úú 
=
úú 	
builder
úú
 
.
úú 
Build
úú 
(
úú 
)
úú 
;
úú 
ifüü 
(
üü 
app
üü 
.
üü 
Environment
üü 
.
üü 
IsDevelopment
üü !
(
üü! "
)
üü" #
)
üü# $
{†† 
app
££ 
.
££ 

UseSwagger
££ 
(
££ 
options
££ 
=>
££ 
{
§§ 
options
•• 
.
•• !
PreSerializeFilters
•• #
.
••# $
Add
••$ '
(
••' (
(
••( )
swagger
••) 0
,
••0 1
req
••2 5
)
••5 6
=>
••7 9
{
¶¶ 	
swagger
ßß 
.
ßß 
Servers
ßß 
=
ßß 
new
ßß !
List
ßß" &
<
ßß& '
OpenApiServer
ßß' 4
>
ßß4 5
(
ßß5 6
)
ßß6 7
{
ßß8 9
new
ßß: =
OpenApiServer
ßß> K
(
ßßK L
)
ßßL M
{
ßßN O
Url
ßßP S
=
ßßT U
$"
ßßV X
$str
ßßX `
{
ßß` a
req
ßßa d
.
ßßd e
Host
ßße i
}
ßßi j
"
ßßj k
}
ßßl m
}
ßßn o
;
ßßo p
}
®® 	
)
®®	 

;
®®
 
}
©© 
)
©© 
;
©© 
app
¨¨ 
.
¨¨ 
UseSwaggerUI
¨¨ 
(
¨¨ 
options
¨¨ 
=>
¨¨ 
{
≠≠ 
var
ÆÆ $
ApiVersionDescriptions
ÆÆ "
=
ÆÆ# $
app
ÆÆ% (
.
ÆÆ( )!
DescribeApiVersions
ÆÆ) <
(
ÆÆ< =
)
ÆÆ= >
;
ÆÆ> ?
foreach
∞∞ 
(
∞∞ 
var
∞∞ 
desc
∞∞ 
in
∞∞ $
ApiVersionDescriptions
∞∞ 3
)
∞∞3 4
{
±± 	
options
≤≤ 
.
≤≤ 
SwaggerEndpoint
≤≤ #
(
≤≤# $
$"
≤≤$ &
$str
≤≤& 1
{
≤≤1 2
desc
≤≤2 6
.
≤≤6 7
	GroupName
≤≤7 @
}
≤≤@ A
$str
≤≤A N
"
≤≤N O
,
≤≤O P
$"
≤≤Q S
$str
≤≤S d
{
≤≤d e
desc
≤≤e i
.
≤≤i j

ApiVersion
≤≤j t
.
≤≤t u
ToString
≤≤u }
(
≤≤} ~
)
≤≤~ 
}≤≤ Ä
"≤≤Ä Å
)≤≤Å Ç
;≤≤Ç É
options
≥≥ 
.
≥≥ &
DefaultModelsExpandDepth
≥≥ ,
(
≥≥, -
-
≥≥- .
$num
≥≥. /
)
≥≥/ 0
;
≥≥0 1
options
¥¥ 
.
¥¥ 
DocExpansion
¥¥  
(
¥¥  !
Swashbuckle
¥¥! ,
.
¥¥, -

AspNetCore
¥¥- 7
.
¥¥7 8
	SwaggerUI
¥¥8 A
.
¥¥A B
DocExpansion
¥¥B N
.
¥¥N O
None
¥¥O S
)
¥¥S T
;
¥¥T U
}
µµ 	
}
∂∂ 
)
∂∂ 
;
∂∂ 
}∑∑ 
appππ 
.
ππ !
UseHttpsRedirection
ππ 
(
ππ 
)
ππ 
;
ππ 
appªª 
.
ªª 
UseAuthorization
ªª 
(
ªª 
)
ªª 
;
ªª 
appΩΩ 
.
ΩΩ 
MapControllers
ΩΩ 
(
ΩΩ 
)
ΩΩ 
;
ΩΩ 
appøø 
.
øø 
Run
øø 
(
øø 
)
øø 	
;
øø	 
€%
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
Finance 
. 
Presentation &
.& '
OpenAPI' .
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
}88 §
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
Finance		 
.		 
Presentation		 &
.		& '
OpenAPI		' .
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
$str D
,D E
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
}22 ö
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Filters/HttpGlobalExceptionFilter.cs
	namespace 	
Modules
 
. 
Finance 
. 
Presentation &
.& '
Filters' .
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
}## °
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/ModuleExtensions.cs
	namespace 	
Modules
 
. 
Finance 
. 
Presentation &
{ 
public 

static 
class 
ModuleExtensions (
{ 
public 
static 
IServiceCollection (
AddFinanceModule) 9
(9 :
this: >
IServiceCollection? Q
servicesR Z
,Z [
IConfiguration\ j
configurationk x
)x y
{ 	
services 
.		 $
AddFinanceInfrastructure		 )
(		) *
configuration		* 7
)		7 8
;		8 9
services 
. 
	AddScoped 
< 
IUnitOfWork *
,* +

UnitOfWork, 6
>6 7
(7 8
)8 9
;9 :
services 
. 
	AddScoped 
< 
IBankBranchService 1
,1 2
BankBranchService3 D
>D E
(E F
)F G
;G H
services 
. 
	AddScoped 
< 
IBankService +
,+ ,
BankService- 8
>8 9
(9 :
): ;
;; <
services 
. 
	AddScoped 
< !
IBankSortCodesService 4
,4 5 
BankSortCodesService6 J
>J K
(K L
)L M
;M N
services 
. 
	AddScoped 
< #
IChartOfAccountsService 6
,6 7"
ChartOfAccountsService8 N
>N O
(O P
)P Q
;Q R
services 
. 
	AddScoped 
< +
ICurrencyAndExchangeRateService >
,> ?*
CurrencyAndExchangeRateService@ ^
>^ _
(_ `
)` a
;a b
services 
. 
	AddScoped 
< 
IFormsService ,
,, -
FormsService. :
>: ;
(; <
)< =
;= >
services 
. 
	AddScoped 
< 
IPaymentModeService 2
,2 3
PaymentModeService4 F
>F G
(G H
)H I
;I J
services 
. 
	AddScoped 
< 
IPaymentTypeService 2
,2 3
PaymentTypeService4 F
>F G
(G H
)H I
;I J
services 
. 
	AddScoped 
< 
IPayPointsService 0
,0 1
PayPointsService2 B
>B C
(C D
)D E
;E F
services 
. 
	AddScoped 
<  
IInvoiceTypesService 3
,3 4
InvoiceTypesService5 H
>H I
(I J
)J K
;K L
services 
. 
AddAutoMapper "
(" #
	AppDomain# ,
., -
CurrentDomain- :
.: ;
GetAssemblies; H
(H I
)I J
)J K
;K L
return 
services 
; 
} 	
} 
} ¡À
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v2/FinanceController.cs
	namespace 	
Modules
 
. 
Finance 
. 
Presentation &
.& '
Controllers' 2
.2 3
v23 5
{ 
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
public 

class 
FinanceController "
:# $
ControllerBase% 3
{ 
public 
readonly 
IBankBranchService *
_bankBranchService+ =
;= >
public 
readonly 
IBankService $
_bankService% 1
;1 2
public 
readonly !
IBankSortCodesService -!
_bankSortCodesService. C
;C D
public 
readonly #
IChartOfAccountsService /#
_chartOfAccountsService0 G
;G H
public 
readonly +
ICurrencyAndExchangeRateService 7+
_currencyAndExchangeRateService8 W
;W X
public 
readonly 
IFormsService %
_formsService& 3
;3 4
public 
readonly 
IPaymentModeService +
_paymentModeService, ?
;? @
public 
readonly 
IPaymentTypeService +
_paymentTypeService, ?
;? @
public 
readonly 
IPayPointsService )
_payPointsService* ;
;; <
public 
readonly  
IInvoiceTypesService , 
_invoiceTypesService- A
;A B
public   
FinanceController    
(    !
IBankBranchService  ! 3
bankBranchService  4 E
,  E F
IBankService  G S
bankService  T _
,  _ `!
IBankSortCodesService  a v!
bankSortCodesService	  w ã
,
  ã å%
IChartOfAccountsService
  ç §$
chartOfAccountsService
  • ª
,
  ª º+
ICurrencyAndExchangeRateService!!! @*
currencyAndExchangeRateService!!A _
,!!_ `
IFormsService!!a n
formsService!!o {
,!!{ | 
IPaymentModeService	!!} ê 
paymentModeService
!!ë £
,
!!£ §!
IPaymentTypeService
!!• ∏ 
paymentTypeService
!!π À
,
!!À Ã
IPayPointsService""! 2
payPointsService""3 C
,""C D 
IInvoiceTypesService""E Y
invoiceTypesService""Z m
)""m n
{## 	
_bankService$$ 
=$$ 
bankService$$ &
;$$& '
_bankBranchService%% 
=%%  
bankBranchService%%! 2
;%%2 3!
_bankSortCodesService&& !
=&&" # 
bankSortCodesService&&$ 8
;&&8 9#
_chartOfAccountsService'' #
=''$ %"
chartOfAccountsService''& <
;''< =+
_currencyAndExchangeRateService(( +
=((, -*
currencyAndExchangeRateService((. L
;((L M
_formsService)) 
=)) 
formsService)) (
;))( )
_paymentModeService** 
=**  !
paymentModeService**" 4
;**4 5
_paymentTypeService++ 
=++  !
paymentTypeService++" 4
;++4 5
_payPointsService,, 
=,, 
payPointsService,,  0
;,,0 1 
_invoiceTypesService--  
=--! "
invoiceTypesService--# 6
;--6 7
}.. 	
[11 	
HttpGet11	 
]11 
[22 	
Route22	 
(22 
$str22 
)22  
]22  !
public33 
async33 
Task33 
<33 
ActionResult33 &
<33& '
IEnumerable33' 2
<332 3
BankReadDto333 >
>33> ?
>33? @
>33@ A
GetBanks33B J
(33J K
)33K L
{44 	
return55 
Ok55 
(55 
await55 
_bankService55 (
.55( )
GetBankAsync55) 5
(555 6
)556 7
)557 8
;558 9
}66 	
[88 	
HttpGet88	 
]88 
[99 	
Route99	 
(99 
$str99 '
)99' (
]99( )
public:: 
async:: 
Task:: 
<:: 
ActionResult:: &
<::& '
BankReadDto::' 2
>::2 3
>::3 4
GetBanks::5 =
(::= >
string::> D
Banks::E J
)::J K
{;; 	
return<< 
Ok<< 
(<< 
await<< 
_bankService<< (
.<<( )
GetBankAsync<<) 5
(<<5 6
Banks<<6 ;
)<<; <
)<<< =
;<<= >
}== 	
[?? 	
HttpGet??	 
]?? 
[@@ 	
Route@@	 
(@@ 
$str@@ +
)@@+ ,
]@@, -
publicAA 
asyncAA 
TaskAA 
<AA 
ActionResultAA &
<AA& '
BankReadDtoAA' 2
>AA2 3
>AA3 4
GetBanksByIdAA5 A
(AAA B
stringAAB H
bankIdAAI O
)AAO P
{BB 	
returnCC 
OkCC 
(CC 
awaitCC 
_bankServiceCC (
.CC( )
GetBankAsyncCC) 5
(CC5 6
bankIdCC6 <
)CC< =
)CC= >
;CC> ?
}DD 	
[FF 	
HttpPostFF	 
]FF 
[GG 	
RouteGG	 
(GG 
$strGG 
)GG 
]GG 
publicHH 
asyncHH 
TaskHH 
<HH 
ActionResultHH &
<HH& '
BankReadDtoHH' 2
>HH2 3
>HH3 4
AddBankHH5 <
(HH< =
[HH= >
FromBodyHH> F
]HHF G
BankCreateDtoHHH U
valuesHHV \
)HH\ ]
{II 	
tryJJ 
{KK 
returnLL 
OkLL 
(LL 
awaitLL 
_bankServiceLL  ,
.LL, -
AddBankAsyncLL- 9
(LL9 :
valuesLL: @
)LL@ A
)LLA B
;LLB C
}MM 
catchNN 
(NN 
	ExceptionNN 
exNN 
)NN  
{OO 
returnPP 

StatusCodePP !
(PP! "
$numPP" %
,PP% &
exPP' )
.PP) *
InnerExceptionPP* 8
!PP8 9
.PP9 :
MessagePP: A
)PPA B
;PPB C
}QQ 
}RR 	
[TT 	
HttpPutTT	 
]TT 
[UU 	
RouteUU	 
(UU 
$strUU 
)UU 
]UU 
publicVV 
asyncVV 
TaskVV 
<VV 
ActionResultVV &
<VV& '
BankReadDtoVV' 2
>VV2 3
>VV3 4
UpdateBanksVV5 @
(VV@ A
[VVA B
FromBodyVVB J
]VVJ K
BankUpdateDtoVVL Y
valuesVVZ `
)VV` a
{WW 	
returnXX 
OkXX 
(XX 
awaitXX 
_bankServiceXX (
.XX( )
UpdateBankAsyncXX) 8
(XX8 9
valuesXX9 ?
)XX? @
)XX@ A
;XXA B
}YY 	
[[[ 	

HttpDelete[[	 
([[ 
$str[[ )
)[[) *
][[* +
public\\ 
void\\ 
DeleteBanks\\ 
(\\  
int\\  #
BanksId\\$ +
)\\+ ,
{]] 	
}^^ 	
[bb 	
HttpGetbb	 
]bb 
[cc 	
Routecc	 
(cc 
$strcc &
)cc& '
]cc' (
publicdd 
asyncdd 
Taskdd 
<dd 
ActionResultdd &
<dd& '
IEnumerabledd' 2
<dd2 3
BankBranchReadDtodd3 D
>ddD E
>ddE F
>ddF G
GetBankBranchesddH W
(ddW X
)ddX Y
{ee 	
returnff 
Okff 
(ff 
awaitff 
_bankBranchServiceff .
.ff. /
GetBankBranchAsyncff/ A
(ffA B
)ffB C
)ffC D
;ffD E
}gg 	
[ii 	
HttpPostii	 
]ii 
[jj 	
Routejj	 
(jj 
$strjj 
)jj 
]jj  
publickk 
asynckk 
Taskkk 
<kk 
ActionResultkk &
<kk& '
BankBranchReadDtokk' 8
>kk8 9
>kk9 :
AddBankBranchkk; H
(kkH I
[kkI J
FromBodykkJ R
]kkR S
BankBranchCreateDtokkT g
valueskkh n
)kkn o
{ll 	
trymm 
{nn 
returnoo 
Okoo 
(oo 
awaitoo 
_bankBranchServiceoo  2
.oo2 3!
CreateBankBranchAsyncoo3 H
(ooH I
valuesooI O
)ooO P
)ooP Q
;ooQ R
}pp 
catchqq 
(qq 
	Exceptionqq 
exqq 
)qq  
{rr 
returnss 

StatusCodess !
(ss! "
$numss" %
,ss% &
exss' )
.ss) *
InnerExceptionss* 8
!ss8 9
.ss9 :
Messagess: A
)ssA B
;ssB C
}tt 
}uu 	
[xx 	
HttpGetxx	 
]xx 
[yy 	
Routeyy	 
(yy 
$stryy '
)yy' (
]yy( )
publiczz 
asynczz 
Taskzz 
<zz 
ActionResultzz &
<zz& '
IEnumerablezz' 2
<zz2 3 
BankSortCodesReadDtozz3 G
>zzG H
>zzH I
>zzI J
GetBankSortCodeszzK [
(zz[ \
)zz\ ]
{{{ 	
return|| 
Ok|| 
(|| 
await|| !
_bankSortCodesService|| 1
.||1 2!
GetBankSortCodesAsync||2 G
(||G H
)||H I
)||I J
;||J K
}}} 	
[ 	
HttpPost	 
] 
[
ÄÄ 	
Route
ÄÄ	 
(
ÄÄ 
$str
ÄÄ !
)
ÄÄ! "
]
ÄÄ" #
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ &
<
ÅÅ& '"
BankSortCodesReadDto
ÅÅ' ;
>
ÅÅ; <
>
ÅÅ< =
AddBankSortCodes
ÅÅ> N
(
ÅÅN O
[
ÅÅO P
FromBody
ÅÅP X
]
ÅÅX Y$
BankSortCodesCreateDto
ÅÅZ p
values
ÅÅq w
)
ÅÅw x
{
ÇÇ 	
try
ÉÉ 
{
ÑÑ 
return
ÖÖ 
Ok
ÖÖ 
(
ÖÖ 
await
ÖÖ #
_bankSortCodesService
ÖÖ  5
.
ÖÖ5 6#
AddBankSortCodesAsync
ÖÖ6 K
(
ÖÖK L
values
ÖÖL R
)
ÖÖR S
)
ÖÖS T
;
ÖÖT U
}
ÜÜ 
catch
áá 
(
áá 
	Exception
áá 
ex
áá 
)
áá  
{
àà 
return
ââ 

StatusCode
ââ !
(
ââ! "
$num
ââ" %
,
ââ% &
ex
ââ' )
.
ââ) *
InnerException
ââ* 8
!
ââ8 9
.
ââ9 :
Message
ââ: A
)
ââA B
;
ââB C
}
ää 
}
ãã 	
[
éé 	
HttpGet
éé	 
]
éé 
[
èè 	
Route
èè	 
(
èè 
$str
èè )
)
èè) *
]
èè* +
public
êê 
async
êê 
Task
êê 
<
êê 
ActionResult
êê &
<
êê& '
IEnumerable
êê' 2
<
êê2 3$
ChartOfAccountsReadDto
êê3 I
>
êêI J
>
êêJ K
>
êêK L 
GetChartOfAccounts
êêM _
(
êê_ `
)
êê` a
{
ëë 	
return
íí 
Ok
íí 
(
íí 
await
íí %
_chartOfAccountsService
íí 3
.
íí3 4%
GetChartOfAccountsAsync
íí4 K
(
ííK L
)
ííL M
)
ííM N
;
ííN O
}
ìì 	
[
££ 	
HttpPost
££	 
]
££ 
[
§§ 	
Route
§§	 
(
§§ 
$str
§§ "
)
§§" #
]
§§# $
public
•• 
async
•• 
Task
•• 
<
•• 
ActionResult
•• &
<
••& '$
ChartOfAccountsReadDto
••' =
>
••= >
>
••> ?
AddChartOfAccount
••@ Q
(
••Q R
[
••R S
FromBody
••S [
]
••[ \&
ChartOfAccountsCreateDto
••] u
values
••v |
)
••| }
{
¶¶ 	
try
ßß 
{
®® 
return
©© 
Ok
©© 
(
©© 
await
©© %
_chartOfAccountsService
©©  7
.
©©7 8%
AddChartOfAccountsAsync
©©8 O
(
©©O P
values
©©P V
)
©©V W
)
©©W X
;
©©X Y
}
™™ 
catch
´´ 
(
´´ 
	Exception
´´ 
ex
´´ 
)
´´  
{
¨¨ 
return
≠≠ 

StatusCode
≠≠ !
(
≠≠! "
$num
≠≠" %
,
≠≠% &
ex
≠≠' )
.
≠≠) *
InnerException
≠≠* 8
!
≠≠8 9
.
≠≠9 :
Message
≠≠: A
)
≠≠A B
;
≠≠B C
}
ÆÆ 
}
ØØ 	
[
ææ 	
HttpGet
ææ	 
]
ææ 
[
øø 	
Route
øø	 
(
øø 
$str
øø /
)
øø/ 0
]
øø0 1
public
¿¿ 
async
¿¿ 
Task
¿¿ 
<
¿¿ 
ActionResult
¿¿ &
<
¿¿& '
IEnumerable
¿¿' 2
<
¿¿2 3,
CurrencyAndExchangeRateReadDto
¿¿3 Q
>
¿¿Q R
>
¿¿R S
>
¿¿S T)
GetCurrencyAndExchangeRates
¿¿U p
(
¿¿p q
)
¿¿q r
{
¡¡ 	
return
¬¬ 
Ok
¬¬ 
(
¬¬ 
await
¬¬ -
_currencyAndExchangeRateService
¬¬ ;
.
¬¬; <-
GetCurrencyAndExchangeRateAsync
¬¬< [
(
¬¬[ \
)
¬¬\ ]
)
¬¬] ^
;
¬¬^ _
}
√√ 	
[
≈≈ 	
HttpPost
≈≈	 
]
≈≈ 
[
∆∆ 	
Route
∆∆	 
(
∆∆ 
$str
∆∆ +
)
∆∆+ ,
]
∆∆, -
public
«« 
async
«« 
Task
«« 
<
«« 
ActionResult
«« &
<
««& ',
CurrencyAndExchangeRateReadDto
««' E
>
««E F
>
««F G(
AddCurrencyAndExchangeRate
««H b
(
««b c
[
««c d
FromBody
««d l
]
««l m/
 CurrencyAndExchangeRateCreateDto««n é
values««è ï
)««ï ñ
{
»» 	
try
…… 
{
   
return
ÀÀ 
Ok
ÀÀ 
(
ÀÀ 
await
ÀÀ -
_currencyAndExchangeRateService
ÀÀ  ?
.
ÀÀ? @-
AddCurrencyAndExchangeRateAsync
ÀÀ@ _
(
ÀÀ_ `
values
ÀÀ` f
)
ÀÀf g
)
ÀÀg h
;
ÀÀh i
}
ÃÃ 
catch
ÕÕ 
(
ÕÕ 
	Exception
ÕÕ 
ex
ÕÕ 
)
ÕÕ  
{
ŒŒ 
return
œœ 

StatusCode
œœ !
(
œœ! "
$num
œœ" %
,
œœ% &
ex
œœ' )
.
œœ) *
InnerException
œœ* 8
!
œœ8 9
.
œœ9 :
Message
œœ: A
)
œœA B
;
œœB C
}
–– 
}
—— 	
[
‘‘ 	
HttpGet
‘‘	 
]
‘‘ 
[
’’ 	
Route
’’	 
(
’’ 
$str
’’ &
)
’’& '
]
’’' (
public
÷÷ 
async
÷÷ 
Task
÷÷ 
<
÷÷ 
ActionResult
÷÷ &
<
÷÷& '
IEnumerable
÷÷' 2
<
÷÷2 3!
InvoiceTypesReadDto
÷÷3 F
>
÷÷F G
>
÷÷G H
>
÷÷H I
GetInvoiceTypes
÷÷J Y
(
÷÷Y Z
)
÷÷Z [
{
◊◊ 	
return
ÿÿ 
Ok
ÿÿ 
(
ÿÿ 
await
ÿÿ "
_invoiceTypesService
ÿÿ 0
.
ÿÿ0 1"
GetInvoiceTypesAsync
ÿÿ1 E
(
ÿÿE F
)
ÿÿF G
)
ÿÿG H
;
ÿÿH I
}
ŸŸ 	
[
€€ 	
HttpPost
€€	 
]
€€ 
[
‹‹ 	
Route
‹‹	 
(
‹‹ 
$str
‹‹  
)
‹‹  !
]
‹‹! "
public
›› 
async
›› 
Task
›› 
<
›› 
ActionResult
›› &
<
››& '!
InvoiceTypesReadDto
››' :
>
››: ;
>
››; <
AddInvoiceTypes
››= L
(
››L M
[
››M N
FromBody
››N V
]
››V W#
InvoiceTypesCreateDto
››X m
values
››n t
)
››t u
{
ﬁﬁ 	
try
ﬂﬂ 
{
‡‡ 
return
·· 
Ok
·· 
(
·· 
await
·· "
_invoiceTypesService
··  4
.
··4 5"
AddInvoiceTypesAsync
··5 I
(
··I J
values
··J P
)
··P Q
)
··Q R
;
··R S
}
‚‚ 
catch
„„ 
(
„„ 
	Exception
„„ 
ex
„„ 
)
„„  
{
‰‰ 
return
ÂÂ 

StatusCode
ÂÂ !
(
ÂÂ! "
$num
ÂÂ" %
,
ÂÂ% &
ex
ÂÂ' )
.
ÂÂ) *
InnerException
ÂÂ* 8
!
ÂÂ8 9
.
ÂÂ9 :
Message
ÂÂ: A
)
ÂÂA B
;
ÂÂB C
}
ÊÊ 
}
ÁÁ 	
[
ÍÍ 	
HttpGet
ÍÍ	 
]
ÍÍ 
[
ÎÎ 	
Route
ÎÎ	 
(
ÎÎ 
$str
ÎÎ 
)
ÎÎ  
]
ÎÎ  !
public
ÏÏ 
async
ÏÏ 
Task
ÏÏ 
<
ÏÏ 
ActionResult
ÏÏ &
<
ÏÏ& '
IEnumerable
ÏÏ' 2
<
ÏÏ2 3
FormsReadDto
ÏÏ3 ?
>
ÏÏ? @
>
ÏÏ@ A
>
ÏÏA B
GetForms
ÏÏC K
(
ÏÏK L
)
ÏÏL M
{
ÌÌ 	
return
ÓÓ 
Ok
ÓÓ 
(
ÓÓ 
await
ÓÓ 
_formsService
ÓÓ )
.
ÓÓ) *
GetFormsAsync
ÓÓ* 7
(
ÓÓ7 8
)
ÓÓ8 9
)
ÓÓ9 :
;
ÓÓ: ;
}
ÔÔ 	
[
ÒÒ 	
HttpPost
ÒÒ	 
]
ÒÒ 
[
ÚÚ 	
Route
ÚÚ	 
(
ÚÚ 
$str
ÚÚ 
)
ÚÚ 
]
ÚÚ 
public
ÛÛ 
async
ÛÛ 
Task
ÛÛ 
<
ÛÛ 
ActionResult
ÛÛ &
<
ÛÛ& '
FormsReadDto
ÛÛ' 3
>
ÛÛ3 4
>
ÛÛ4 5
AddForm
ÛÛ6 =
(
ÛÛ= >
[
ÛÛ> ?
FromBody
ÛÛ? G
]
ÛÛG H
FormsCreateDto
ÛÛI W
values
ÛÛX ^
)
ÛÛ^ _
{
ÙÙ 	
try
ıı 
{
ˆˆ 
return
˜˜ 
Ok
˜˜ 
(
˜˜ 
await
˜˜ 
_formsService
˜˜  -
.
˜˜- .
AddFormsAsync
˜˜. ;
(
˜˜; <
values
˜˜< B
)
˜˜B C
)
˜˜C D
;
˜˜D E
}
¯¯ 
catch
˘˘ 
(
˘˘ 
	Exception
˘˘ 
ex
˘˘ 
)
˘˘  
{
˙˙ 
return
˚˚ 

StatusCode
˚˚ !
(
˚˚! "
$num
˚˚" %
,
˚˚% &
ex
˚˚' )
.
˚˚) *
InnerException
˚˚* 8
!
˚˚8 9
.
˚˚9 :
Message
˚˚: A
)
˚˚A B
;
˚˚B C
}
¸¸ 
}
˝˝ 	
[
ÄÄ 	
HttpGet
ÄÄ	 
]
ÄÄ 
[
ÅÅ 	
Route
ÅÅ	 
(
ÅÅ 
$str
ÅÅ &
)
ÅÅ& '
]
ÅÅ' (
public
ÇÇ 
async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ &
<
ÇÇ& '
IEnumerable
ÇÇ' 2
<
ÇÇ2 3 
PaymentModeReadDto
ÇÇ3 E
>
ÇÇE F
>
ÇÇF G
>
ÇÇG H
GetPaymentModes
ÇÇI X
(
ÇÇX Y
)
ÇÇY Z
{
ÉÉ 	
return
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
await
ÑÑ !
_paymentModeService
ÑÑ /
.
ÑÑ/ 0!
GetPaymentModeAsync
ÑÑ0 C
(
ÑÑC D
)
ÑÑD E
)
ÑÑE F
;
ÑÑF G
}
ÖÖ 	
[
áá 	
HttpPost
áá	 
]
áá 
[
àà 	
Route
àà	 
(
àà 
$str
àà 
)
àà  
]
àà  !
public
ââ 
async
ââ 
Task
ââ 
<
ââ 
ActionResult
ââ &
<
ââ& ' 
PaymentModeReadDto
ââ' 9
>
ââ9 :
>
ââ: ;
AddPaymentMode
ââ< J
(
ââJ K
[
ââK L
FromBody
ââL T
]
ââT U"
PaymentModeCreateDto
ââV j
values
ââk q
)
ââq r
{
ää 	
try
ãã 
{
åå 
return
çç 
Ok
çç 
(
çç 
await
çç !
_paymentModeService
çç  3
.
çç3 4!
AddPaymentModeAsync
çç4 G
(
ççG H
values
ççH N
)
ççN O
)
ççO P
;
ççP Q
}
éé 
catch
èè 
(
èè 
	Exception
èè 
ex
èè 
)
èè  
{
êê 
return
ëë 

StatusCode
ëë !
(
ëë! "
$num
ëë" %
,
ëë% &
ex
ëë' )
.
ëë) *
InnerException
ëë* 8
!
ëë8 9
.
ëë9 :
Message
ëë: A
)
ëëA B
;
ëëB C
}
íí 
}
ìì 	
[
ññ 	
HttpGet
ññ	 
]
ññ 
[
óó 	
Route
óó	 
(
óó 
$str
óó &
)
óó& '
]
óó' (
public
òò 
async
òò 
Task
òò 
<
òò 
ActionResult
òò &
<
òò& '
IEnumerable
òò' 2
<
òò2 3 
PaymentTypeReadDto
òò3 E
>
òòE F
>
òòF G
>
òòG H
GetPaymentTypes
òòI X
(
òòX Y
)
òòY Z
{
ôô 	
return
öö 
Ok
öö 
(
öö 
await
öö !
_paymentTypeService
öö /
.
öö/ 0!
GetPaymentTypeAsync
öö0 C
(
ööC D
)
ööD E
)
ööE F
;
ööF G
}
õõ 	
[
ùù 	
HttpPost
ùù	 
]
ùù 
[
ûû 	
Route
ûû	 
(
ûû 
$str
ûû 
)
ûû  
]
ûû  !
public
üü 
async
üü 
Task
üü 
<
üü 
ActionResult
üü &
<
üü& ' 
PaymentTypeReadDto
üü' 9
>
üü9 :
>
üü: ;
AddPaymentType
üü< J
(
üüJ K
[
üüK L
FromBody
üüL T
]
üüT U"
PaymentTypeCreateDto
üüV j
values
üük q
)
üüq r
{
†† 	
try
°° 
{
¢¢ 
return
££ 
Ok
££ 
(
££ 
await
££ !
_paymentTypeService
££  3
.
££3 4!
AddPaymentTypeAsync
££4 G
(
££G H
values
££H N
)
££N O
)
££O P
;
££P Q
}
§§ 
catch
•• 
(
•• 
	Exception
•• 
ex
•• 
)
••  
{
¶¶ 
return
ßß 

StatusCode
ßß !
(
ßß! "
$num
ßß" %
,
ßß% &
ex
ßß' )
.
ßß) *
InnerException
ßß* 8
!
ßß8 9
.
ßß9 :
Message
ßß: A
)
ßßA B
;
ßßB C
}
®® 
}
©© 	
[
≠≠ 	
HttpGet
≠≠	 
]
≠≠ 
[
ÆÆ 	
Route
ÆÆ	 
(
ÆÆ 
$str
ÆÆ #
)
ÆÆ# $
]
ÆÆ$ %
public
ØØ 
async
ØØ 
Task
ØØ 
<
ØØ 
ActionResult
ØØ &
<
ØØ& '
IEnumerable
ØØ' 2
<
ØØ2 3
PaypointsReadDto
ØØ3 C
>
ØØC D
>
ØØD E
>
ØØE F
GetPaypoints
ØØG S
(
ØØS T
)
ØØT U
{
∞∞ 	
return
±± 
Ok
±± 
(
±± 
await
±± 
_payPointsService
±± -
.
±±- .
GetPaypointsAsync
±±. ?
(
±±? @
)
±±@ A
)
±±A B
;
±±B C
}
≤≤ 	
[
¥¥ 	
HttpPost
¥¥	 
]
¥¥ 
[
µµ 	
Route
µµ	 
(
µµ 
$str
µµ 
)
µµ 
]
µµ 
public
∂∂ 
async
∂∂ 
Task
∂∂ 
<
∂∂ 
ActionResult
∂∂ &
<
∂∂& '
PaypointsReadDto
∂∂' 7
>
∂∂7 8
>
∂∂8 9
AddPaypoint
∂∂: E
(
∂∂E F
[
∂∂F G
FromBody
∂∂G O
]
∂∂O P 
PaypointsCreateDto
∂∂Q c
values
∂∂d j
)
∂∂j k
{
∑∑ 	
try
∏∏ 
{
ππ 
return
∫∫ 
Ok
∫∫ 
(
∫∫ 
await
∫∫ 
_payPointsService
∫∫  1
.
∫∫1 2
AddPaypointsAsync
∫∫2 C
(
∫∫C D
values
∫∫D J
)
∫∫J K
)
∫∫K L
;
∫∫L M
}
ªª 
catch
ºº 
(
ºº 
	Exception
ºº 
ex
ºº 
)
ºº  
{
ΩΩ 
return
ææ 

StatusCode
ææ !
(
ææ! "
$num
ææ" %
,
ææ% &
ex
ææ' )
.
ææ) *
InnerException
ææ* 8
!
ææ8 9
.
ææ9 :
Message
ææ: A
)
ææA B
;
ææB C
}
øø 
}
¿¿ 	
}
√√ 
}ƒƒ ¢À
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.cs
	namespace 	
Modules
 
. 
Finance 
. 
Presentation &
.& '
Controllers' 2
{ 
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
public 

class 
FinanceController "
:# $
ControllerBase% 3
{ 
public 
readonly 
IBankBranchService *
_bankBranchService+ =
;= >
public 
readonly 
IBankService $
_bankService% 1
;1 2
public 
readonly !
IBankSortCodesService -!
_bankSortCodesService. C
;C D
public 
readonly #
IChartOfAccountsService /#
_chartOfAccountsService0 G
;G H
public 
readonly +
ICurrencyAndExchangeRateService 7+
_currencyAndExchangeRateService8 W
;W X
public 
readonly 
IFormsService %
_formsService& 3
;3 4
public 
readonly 
IPaymentModeService +
_paymentModeService, ?
;? @
public 
readonly 
IPaymentTypeService +
_paymentTypeService, ?
;? @
public 
readonly 
IPayPointsService )
_payPointsService* ;
;; <
public 
readonly  
IInvoiceTypesService , 
_invoiceTypesService- A
;A B
public   
FinanceController    
(    !
IBankBranchService  ! 3
bankBranchService  4 E
,  E F
IBankService  G S
bankService  T _
,  _ `!
IBankSortCodesService  a v!
bankSortCodesService	  w ã
,
  ã å%
IChartOfAccountsService
  ç §$
chartOfAccountsService
  • ª
,
  ª º+
ICurrencyAndExchangeRateService!!! @*
currencyAndExchangeRateService!!A _
,!!_ `
IFormsService!!a n
formsService!!o {
,!!{ | 
IPaymentModeService	!!} ê 
paymentModeService
!!ë £
,
!!£ §!
IPaymentTypeService
!!• ∏ 
paymentTypeService
!!π À
,
!!À Ã
IPayPointsService""! 2
payPointsService""3 C
,""C D 
IInvoiceTypesService""E Y
invoiceTypesService""Z m
)""m n
{## 	
_bankService$$ 
=$$ 
bankService$$ &
;$$& '
_bankBranchService%% 
=%%  
bankBranchService%%! 2
;%%2 3!
_bankSortCodesService&& !
=&&" # 
bankSortCodesService&&$ 8
;&&8 9#
_chartOfAccountsService'' #
=''$ %"
chartOfAccountsService''& <
;''< =+
_currencyAndExchangeRateService(( +
=((, -*
currencyAndExchangeRateService((. L
;((L M
_formsService)) 
=)) 
formsService)) (
;))( )
_paymentModeService** 
=**  !
paymentModeService**" 4
;**4 5
_paymentTypeService++ 
=++  !
paymentTypeService++" 4
;++4 5
_payPointsService,, 
=,, 
payPointsService,,  0
;,,0 1 
_invoiceTypesService--  
=--! "
invoiceTypesService--# 6
;--6 7
}.. 	
[11 	
HttpGet11	 
]11 
[22 	
Route22	 
(22 
$str22 
)22  
]22  !
public33 
async33 
Task33 
<33 
ActionResult33 &
<33& '
IEnumerable33' 2
<332 3
BankReadDto333 >
>33> ?
>33? @
>33@ A
GetBanks33B J
(33J K
)33K L
{44 	
return55 
Ok55 
(55 
await55 
_bankService55 (
.55( )
GetBankAsync55) 5
(555 6
)556 7
)557 8
;558 9
}66 	
[88 	
HttpGet88	 
]88 
[99 	
Route99	 
(99 
$str99 '
)99' (
]99( )
public:: 
async:: 
Task:: 
<:: 
ActionResult:: &
<::& '
BankReadDto::' 2
>::2 3
>::3 4
GetBanks::5 =
(::= >
string::> D
Banks::E J
)::J K
{;; 	
return<< 
Ok<< 
(<< 
await<< 
_bankService<< (
.<<( )
GetBankAsync<<) 5
(<<5 6
Banks<<6 ;
)<<; <
)<<< =
;<<= >
}== 	
[?? 	
HttpGet??	 
]?? 
[@@ 	
Route@@	 
(@@ 
$str@@ +
)@@+ ,
]@@, -
publicAA 
asyncAA 
TaskAA 
<AA 
ActionResultAA &
<AA& '
BankReadDtoAA' 2
>AA2 3
>AA3 4
GetBanksByIdAA5 A
(AAA B
stringAAB H
bankIdAAI O
)AAO P
{BB 	
returnCC 
OkCC 
(CC 
awaitCC 
_bankServiceCC (
.CC( )
GetBankAsyncCC) 5
(CC5 6
bankIdCC6 <
)CC< =
)CC= >
;CC> ?
}DD 	
[FF 	
HttpPostFF	 
]FF 
[GG 	
RouteGG	 
(GG 
$strGG 
)GG 
]GG 
publicHH 
asyncHH 
TaskHH 
<HH 
ActionResultHH &
<HH& '
BankReadDtoHH' 2
>HH2 3
>HH3 4
AddBankHH5 <
(HH< =
[HH= >
FromBodyHH> F
]HHF G
BankCreateDtoHHH U
valuesHHV \
)HH\ ]
{II 	
tryJJ 
{KK 
returnLL 
OkLL 
(LL 
awaitLL 
_bankServiceLL  ,
.LL, -
AddBankAsyncLL- 9
(LL9 :
valuesLL: @
)LL@ A
)LLA B
;LLB C
}MM 
catchNN 
(NN 
	ExceptionNN 
exNN 
)NN  
{OO 
returnPP 

StatusCodePP !
(PP! "
$numPP" %
,PP% &
exPP' )
.PP) *
InnerExceptionPP* 8
!PP8 9
.PP9 :
MessagePP: A
)PPA B
;PPB C
}QQ 
}RR 	
[TT 	
HttpPutTT	 
]TT 
[UU 	
RouteUU	 
(UU 
$strUU 
)UU 
]UU 
publicVV 
asyncVV 
TaskVV 
<VV 
ActionResultVV &
<VV& '
BankReadDtoVV' 2
>VV2 3
>VV3 4
UpdateBanksVV5 @
(VV@ A
[VVA B
FromBodyVVB J
]VVJ K
BankUpdateDtoVVL Y
valuesVVZ `
)VV` a
{WW 	
returnXX 
OkXX 
(XX 
awaitXX 
_bankServiceXX (
.XX( )
UpdateBankAsyncXX) 8
(XX8 9
valuesXX9 ?
)XX? @
)XX@ A
;XXA B
}YY 	
[[[ 	

HttpDelete[[	 
([[ 
$str[[ )
)[[) *
][[* +
public\\ 
void\\ 
DeleteBanks\\ 
(\\  
int\\  #
BanksId\\$ +
)\\+ ,
{]] 	
}^^ 	
[bb 	
HttpGetbb	 
]bb 
[cc 	
Routecc	 
(cc 
$strcc &
)cc& '
]cc' (
publicdd 
asyncdd 
Taskdd 
<dd 
ActionResultdd &
<dd& '
IEnumerabledd' 2
<dd2 3
BankBranchReadDtodd3 D
>ddD E
>ddE F
>ddF G
GetBankBranchesddH W
(ddW X
)ddX Y
{ee 	
returnff 
Okff 
(ff 
awaitff 
_bankBranchServiceff .
.ff. /
GetBankBranchAsyncff/ A
(ffA B
)ffB C
)ffC D
;ffD E
}gg 	
[ii 	
HttpPostii	 
]ii 
[jj 	
Routejj	 
(jj 
$strjj 
)jj 
]jj  
publickk 
asynckk 
Taskkk 
<kk 
ActionResultkk &
<kk& '
BankBranchReadDtokk' 8
>kk8 9
>kk9 :
AddBankBranchkk; H
(kkH I
[kkI J
FromBodykkJ R
]kkR S
BankBranchCreateDtokkT g
valueskkh n
)kkn o
{ll 	
trymm 
{nn 
returnoo 
Okoo 
(oo 
awaitoo 
_bankBranchServiceoo  2
.oo2 3!
CreateBankBranchAsyncoo3 H
(ooH I
valuesooI O
)ooO P
)ooP Q
;ooQ R
}pp 
catchqq 
(qq 
	Exceptionqq 
exqq 
)qq  
{rr 
returnss 

StatusCodess !
(ss! "
$numss" %
,ss% &
exss' )
.ss) *
InnerExceptionss* 8
!ss8 9
.ss9 :
Messagess: A
)ssA B
;ssB C
}tt 
}uu 	
[xx 	
HttpGetxx	 
]xx 
[yy 	
Routeyy	 
(yy 
$stryy '
)yy' (
]yy( )
publiczz 
asynczz 
Taskzz 
<zz 
ActionResultzz &
<zz& '
IEnumerablezz' 2
<zz2 3 
BankSortCodesReadDtozz3 G
>zzG H
>zzH I
>zzI J
GetBankSortCodeszzK [
(zz[ \
)zz\ ]
{{{ 	
return|| 
Ok|| 
(|| 
await|| !
_bankSortCodesService|| 1
.||1 2!
GetBankSortCodesAsync||2 G
(||G H
)||H I
)||I J
;||J K
}}} 	
[ 	
HttpPost	 
] 
[
ÄÄ 	
Route
ÄÄ	 
(
ÄÄ 
$str
ÄÄ !
)
ÄÄ! "
]
ÄÄ" #
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ &
<
ÅÅ& '"
BankSortCodesReadDto
ÅÅ' ;
>
ÅÅ; <
>
ÅÅ< =
AddBankSortCodes
ÅÅ> N
(
ÅÅN O
[
ÅÅO P
FromBody
ÅÅP X
]
ÅÅX Y$
BankSortCodesCreateDto
ÅÅZ p
values
ÅÅq w
)
ÅÅw x
{
ÇÇ 	
try
ÉÉ 
{
ÑÑ 
return
ÖÖ 
Ok
ÖÖ 
(
ÖÖ 
await
ÖÖ #
_bankSortCodesService
ÖÖ  5
.
ÖÖ5 6#
AddBankSortCodesAsync
ÖÖ6 K
(
ÖÖK L
values
ÖÖL R
)
ÖÖR S
)
ÖÖS T
;
ÖÖT U
}
ÜÜ 
catch
áá 
(
áá 
	Exception
áá 
ex
áá 
)
áá  
{
àà 
return
ââ 

StatusCode
ââ !
(
ââ! "
$num
ââ" %
,
ââ% &
ex
ââ' )
.
ââ) *
InnerException
ââ* 8
!
ââ8 9
.
ââ9 :
Message
ââ: A
)
ââA B
;
ââB C
}
ää 
}
ãã 	
[
éé 	
HttpGet
éé	 
]
éé 
[
èè 	
Route
èè	 
(
èè 
$str
èè )
)
èè) *
]
èè* +
public
êê 
async
êê 
Task
êê 
<
êê 
ActionResult
êê &
<
êê& '
IEnumerable
êê' 2
<
êê2 3$
ChartOfAccountsReadDto
êê3 I
>
êêI J
>
êêJ K
>
êêK L 
GetChartOfAccounts
êêM _
(
êê_ `
)
êê` a
{
ëë 	
return
íí 
Ok
íí 
(
íí 
await
íí %
_chartOfAccountsService
íí 3
.
íí3 4%
GetChartOfAccountsAsync
íí4 K
(
ííK L
)
ííL M
)
ííM N
;
ííN O
}
ìì 	
[
££ 	
HttpPost
££	 
]
££ 
[
§§ 	
Route
§§	 
(
§§ 
$str
§§ "
)
§§" #
]
§§# $
public
•• 
async
•• 
Task
•• 
<
•• 
ActionResult
•• &
<
••& '$
ChartOfAccountsReadDto
••' =
>
••= >
>
••> ?
AddChartOfAccount
••@ Q
(
••Q R
[
••R S
FromBody
••S [
]
••[ \&
ChartOfAccountsCreateDto
••] u
values
••v |
)
••| }
{
¶¶ 	
try
ßß 
{
®® 
return
©© 
Ok
©© 
(
©© 
await
©© %
_chartOfAccountsService
©©  7
.
©©7 8%
AddChartOfAccountsAsync
©©8 O
(
©©O P
values
©©P V
)
©©V W
)
©©W X
;
©©X Y
}
™™ 
catch
´´ 
(
´´ 
	Exception
´´ 
ex
´´ 
)
´´  
{
¨¨ 
return
≠≠ 

StatusCode
≠≠ !
(
≠≠! "
$num
≠≠" %
,
≠≠% &
ex
≠≠' )
.
≠≠) *
InnerException
≠≠* 8
!
≠≠8 9
.
≠≠9 :
Message
≠≠: A
)
≠≠A B
;
≠≠B C
}
ÆÆ 
}
ØØ 	
[
ææ 	
HttpGet
ææ	 
]
ææ 
[
øø 	
Route
øø	 
(
øø 
$str
øø /
)
øø/ 0
]
øø0 1
public
¿¿ 
async
¿¿ 
Task
¿¿ 
<
¿¿ 
ActionResult
¿¿ &
<
¿¿& '
IEnumerable
¿¿' 2
<
¿¿2 3,
CurrencyAndExchangeRateReadDto
¿¿3 Q
>
¿¿Q R
>
¿¿R S
>
¿¿S T)
GetCurrencyAndExchangeRates
¿¿U p
(
¿¿p q
)
¿¿q r
{
¡¡ 	
return
¬¬ 
Ok
¬¬ 
(
¬¬ 
await
¬¬ -
_currencyAndExchangeRateService
¬¬ ;
.
¬¬; <-
GetCurrencyAndExchangeRateAsync
¬¬< [
(
¬¬[ \
)
¬¬\ ]
)
¬¬] ^
;
¬¬^ _
}
√√ 	
[
≈≈ 	
HttpPost
≈≈	 
]
≈≈ 
[
∆∆ 	
Route
∆∆	 
(
∆∆ 
$str
∆∆ +
)
∆∆+ ,
]
∆∆, -
public
«« 
async
«« 
Task
«« 
<
«« 
ActionResult
«« &
<
««& ',
CurrencyAndExchangeRateReadDto
««' E
>
««E F
>
««F G(
AddCurrencyAndExchangeRate
««H b
(
««b c
[
««c d
FromBody
««d l
]
««l m/
 CurrencyAndExchangeRateCreateDto««n é
values««è ï
)««ï ñ
{
»» 	
try
…… 
{
   
return
ÀÀ 
Ok
ÀÀ 
(
ÀÀ 
await
ÀÀ -
_currencyAndExchangeRateService
ÀÀ  ?
.
ÀÀ? @-
AddCurrencyAndExchangeRateAsync
ÀÀ@ _
(
ÀÀ_ `
values
ÀÀ` f
)
ÀÀf g
)
ÀÀg h
;
ÀÀh i
}
ÃÃ 
catch
ÕÕ 
(
ÕÕ 
	Exception
ÕÕ 
ex
ÕÕ 
)
ÕÕ  
{
ŒŒ 
return
œœ 

StatusCode
œœ !
(
œœ! "
$num
œœ" %
,
œœ% &
ex
œœ' )
.
œœ) *
InnerException
œœ* 8
!
œœ8 9
.
œœ9 :
Message
œœ: A
)
œœA B
;
œœB C
}
–– 
}
—— 	
[
‘‘ 	
HttpGet
‘‘	 
]
‘‘ 
[
’’ 	
Route
’’	 
(
’’ 
$str
’’ &
)
’’& '
]
’’' (
public
÷÷ 
async
÷÷ 
Task
÷÷ 
<
÷÷ 
ActionResult
÷÷ &
<
÷÷& '
IEnumerable
÷÷' 2
<
÷÷2 3!
InvoiceTypesReadDto
÷÷3 F
>
÷÷F G
>
÷÷G H
>
÷÷H I
GetInvoiceTypes
÷÷J Y
(
÷÷Y Z
)
÷÷Z [
{
◊◊ 	
return
ÿÿ 
Ok
ÿÿ 
(
ÿÿ 
await
ÿÿ "
_invoiceTypesService
ÿÿ 0
.
ÿÿ0 1"
GetInvoiceTypesAsync
ÿÿ1 E
(
ÿÿE F
)
ÿÿF G
)
ÿÿG H
;
ÿÿH I
}
ŸŸ 	
[
€€ 	
HttpPost
€€	 
]
€€ 
[
‹‹ 	
Route
‹‹	 
(
‹‹ 
$str
‹‹  
)
‹‹  !
]
‹‹! "
public
›› 
async
›› 
Task
›› 
<
›› 
ActionResult
›› &
<
››& '!
InvoiceTypesReadDto
››' :
>
››: ;
>
››; <
AddInvoiceTypes
››= L
(
››L M
[
››M N
FromBody
››N V
]
››V W#
InvoiceTypesCreateDto
››X m
values
››n t
)
››t u
{
ﬁﬁ 	
try
ﬂﬂ 
{
‡‡ 
return
·· 
Ok
·· 
(
·· 
await
·· "
_invoiceTypesService
··  4
.
··4 5"
AddInvoiceTypesAsync
··5 I
(
··I J
values
··J P
)
··P Q
)
··Q R
;
··R S
}
‚‚ 
catch
„„ 
(
„„ 
	Exception
„„ 
ex
„„ 
)
„„  
{
‰‰ 
return
ÂÂ 

StatusCode
ÂÂ !
(
ÂÂ! "
$num
ÂÂ" %
,
ÂÂ% &
ex
ÂÂ' )
.
ÂÂ) *
InnerException
ÂÂ* 8
!
ÂÂ8 9
.
ÂÂ9 :
Message
ÂÂ: A
)
ÂÂA B
;
ÂÂB C
}
ÊÊ 
}
ÁÁ 	
[
ÍÍ 	
HttpGet
ÍÍ	 
]
ÍÍ 
[
ÎÎ 	
Route
ÎÎ	 
(
ÎÎ 
$str
ÎÎ 
)
ÎÎ  
]
ÎÎ  !
public
ÏÏ 
async
ÏÏ 
Task
ÏÏ 
<
ÏÏ 
ActionResult
ÏÏ &
<
ÏÏ& '
IEnumerable
ÏÏ' 2
<
ÏÏ2 3
FormsReadDto
ÏÏ3 ?
>
ÏÏ? @
>
ÏÏ@ A
>
ÏÏA B
GetForms
ÏÏC K
(
ÏÏK L
)
ÏÏL M
{
ÌÌ 	
return
ÓÓ 
Ok
ÓÓ 
(
ÓÓ 
await
ÓÓ 
_formsService
ÓÓ )
.
ÓÓ) *
GetFormsAsync
ÓÓ* 7
(
ÓÓ7 8
)
ÓÓ8 9
)
ÓÓ9 :
;
ÓÓ: ;
}
ÔÔ 	
[
ÒÒ 	
HttpPost
ÒÒ	 
]
ÒÒ 
[
ÚÚ 	
Route
ÚÚ	 
(
ÚÚ 
$str
ÚÚ 
)
ÚÚ 
]
ÚÚ 
public
ÛÛ 
async
ÛÛ 
Task
ÛÛ 
<
ÛÛ 
ActionResult
ÛÛ &
<
ÛÛ& '
FormsReadDto
ÛÛ' 3
>
ÛÛ3 4
>
ÛÛ4 5
AddForm
ÛÛ6 =
(
ÛÛ= >
[
ÛÛ> ?
FromBody
ÛÛ? G
]
ÛÛG H
FormsCreateDto
ÛÛI W
values
ÛÛX ^
)
ÛÛ^ _
{
ÙÙ 	
try
ıı 
{
ˆˆ 
return
˜˜ 
Ok
˜˜ 
(
˜˜ 
await
˜˜ 
_formsService
˜˜  -
.
˜˜- .
AddFormsAsync
˜˜. ;
(
˜˜; <
values
˜˜< B
)
˜˜B C
)
˜˜C D
;
˜˜D E
}
¯¯ 
catch
˘˘ 
(
˘˘ 
	Exception
˘˘ 
ex
˘˘ 
)
˘˘  
{
˙˙ 
return
˚˚ 

StatusCode
˚˚ !
(
˚˚! "
$num
˚˚" %
,
˚˚% &
ex
˚˚' )
.
˚˚) *
InnerException
˚˚* 8
!
˚˚8 9
.
˚˚9 :
Message
˚˚: A
)
˚˚A B
;
˚˚B C
}
¸¸ 
}
˝˝ 	
[
ÄÄ 	
HttpGet
ÄÄ	 
]
ÄÄ 
[
ÅÅ 	
Route
ÅÅ	 
(
ÅÅ 
$str
ÅÅ &
)
ÅÅ& '
]
ÅÅ' (
public
ÇÇ 
async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ &
<
ÇÇ& '
IEnumerable
ÇÇ' 2
<
ÇÇ2 3 
PaymentModeReadDto
ÇÇ3 E
>
ÇÇE F
>
ÇÇF G
>
ÇÇG H
GetPaymentModes
ÇÇI X
(
ÇÇX Y
)
ÇÇY Z
{
ÉÉ 	
return
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
await
ÑÑ !
_paymentModeService
ÑÑ /
.
ÑÑ/ 0!
GetPaymentModeAsync
ÑÑ0 C
(
ÑÑC D
)
ÑÑD E
)
ÑÑE F
;
ÑÑF G
}
ÖÖ 	
[
áá 	
HttpPost
áá	 
]
áá 
[
àà 	
Route
àà	 
(
àà 
$str
àà 
)
àà  
]
àà  !
public
ââ 
async
ââ 
Task
ââ 
<
ââ 
ActionResult
ââ &
<
ââ& ' 
PaymentModeReadDto
ââ' 9
>
ââ9 :
>
ââ: ;
AddPaymentMode
ââ< J
(
ââJ K
[
ââK L
FromBody
ââL T
]
ââT U"
PaymentModeCreateDto
ââV j
values
ââk q
)
ââq r
{
ää 	
try
ãã 
{
åå 
return
çç 
Ok
çç 
(
çç 
await
çç !
_paymentModeService
çç  3
.
çç3 4!
AddPaymentModeAsync
çç4 G
(
ççG H
values
ççH N
)
ççN O
)
ççO P
;
ççP Q
}
éé 
catch
èè 
(
èè 
	Exception
èè 
ex
èè 
)
èè  
{
êê 
return
ëë 

StatusCode
ëë !
(
ëë! "
$num
ëë" %
,
ëë% &
ex
ëë' )
.
ëë) *
InnerException
ëë* 8
!
ëë8 9
.
ëë9 :
Message
ëë: A
)
ëëA B
;
ëëB C
}
íí 
}
ìì 	
[
ññ 	
HttpGet
ññ	 
]
ññ 
[
óó 	
Route
óó	 
(
óó 
$str
óó &
)
óó& '
]
óó' (
public
òò 
async
òò 
Task
òò 
<
òò 
ActionResult
òò &
<
òò& '
IEnumerable
òò' 2
<
òò2 3 
PaymentTypeReadDto
òò3 E
>
òòE F
>
òòF G
>
òòG H
GetPaymentTypes
òòI X
(
òòX Y
)
òòY Z
{
ôô 	
return
öö 
Ok
öö 
(
öö 
await
öö !
_paymentTypeService
öö /
.
öö/ 0!
GetPaymentTypeAsync
öö0 C
(
ööC D
)
ööD E
)
ööE F
;
ööF G
}
õõ 	
[
ùù 	
HttpPost
ùù	 
]
ùù 
[
ûû 	
Route
ûû	 
(
ûû 
$str
ûû 
)
ûû  
]
ûû  !
public
üü 
async
üü 
Task
üü 
<
üü 
ActionResult
üü &
<
üü& ' 
PaymentTypeReadDto
üü' 9
>
üü9 :
>
üü: ;
AddPaymentType
üü< J
(
üüJ K
[
üüK L
FromBody
üüL T
]
üüT U"
PaymentTypeCreateDto
üüV j
values
üük q
)
üüq r
{
†† 	
try
°° 
{
¢¢ 
return
££ 
Ok
££ 
(
££ 
await
££ !
_paymentTypeService
££  3
.
££3 4!
AddPaymentTypeAsync
££4 G
(
££G H
values
££H N
)
££N O
)
££O P
;
££P Q
}
§§ 
catch
•• 
(
•• 
	Exception
•• 
ex
•• 
)
••  
{
¶¶ 
return
ßß 

StatusCode
ßß !
(
ßß! "
$num
ßß" %
,
ßß% &
ex
ßß' )
.
ßß) *
InnerException
ßß* 8
!
ßß8 9
.
ßß9 :
Message
ßß: A
)
ßßA B
;
ßßB C
}
®® 
}
©© 	
[
≠≠ 	
HttpGet
≠≠	 
]
≠≠ 
[
ÆÆ 	
Route
ÆÆ	 
(
ÆÆ 
$str
ÆÆ #
)
ÆÆ# $
]
ÆÆ$ %
public
ØØ 
async
ØØ 
Task
ØØ 
<
ØØ 
ActionResult
ØØ &
<
ØØ& '
IEnumerable
ØØ' 2
<
ØØ2 3
PaypointsReadDto
ØØ3 C
>
ØØC D
>
ØØD E
>
ØØE F
GetPaypoints
ØØG S
(
ØØS T
)
ØØT U
{
∞∞ 	
return
±± 
Ok
±± 
(
±± 
await
±± 
_payPointsService
±± -
.
±±- .
GetPaypointsAsync
±±. ?
(
±±? @
)
±±@ A
)
±±A B
;
±±B C
}
≤≤ 	
[
¥¥ 	
HttpPost
¥¥	 
]
¥¥ 
[
µµ 	
Route
µµ	 
(
µµ 
$str
µµ 
)
µµ 
]
µµ 
public
∂∂ 
async
∂∂ 
Task
∂∂ 
<
∂∂ 
ActionResult
∂∂ &
<
∂∂& '
PaypointsReadDto
∂∂' 7
>
∂∂7 8
>
∂∂8 9
AddPaypoint
∂∂: E
(
∂∂E F
[
∂∂F G
FromBody
∂∂G O
]
∂∂O P 
PaypointsCreateDto
∂∂Q c
values
∂∂d j
)
∂∂j k
{
∑∑ 	
try
∏∏ 
{
ππ 
return
∫∫ 
Ok
∫∫ 
(
∫∫ 
await
∫∫ 
_payPointsService
∫∫  1
.
∫∫1 2
AddPaypointsAsync
∫∫2 C
(
∫∫C D
values
∫∫D J
)
∫∫J K
)
∫∫K L
;
∫∫L M
}
ªª 
catch
ºº 
(
ºº 
	Exception
ºº 
ex
ºº 
)
ºº  
{
ΩΩ 
return
ææ 

StatusCode
ææ !
(
ææ! "
$num
ææ" %
,
ææ% &
ex
ææ' )
.
ææ) *
InnerException
ææ* 8
!
ææ8 9
.
ææ9 :
Message
ææ: A
)
ææA B
;
ææB C
}
øø 
}
¿¿ 	
}
√√ 
}ƒƒ 