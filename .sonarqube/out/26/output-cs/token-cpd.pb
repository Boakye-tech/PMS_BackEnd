j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Usings.cs�n
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
GetConnectionString	77r �
(
77� �
$str
77� �
)
77� �
)
77� �
)
77� �
;
77� �
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
GetConnectionString	EEr �
(
EE� �
$str
EE� �
)
EE� �
)
EE� �
)
EE� �
;
EE� �
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
builder�� 
.
�� 
Services
�� 
.
�� 
AddApiVersioning
�� 
(
�� 
options
�� 
=>
��  
{
�� 
options
�� 
.
�� 
DefaultApiVersion
�� !
=
��" #
new
��$ '

ApiVersion
��( 2
(
��2 3
$num
��3 4
,
��4 5
$num
��6 7
)
��7 8
;
��8 9
options
�� 
.
�� 1
#AssumeDefaultVersionWhenUnspecified
�� 3
=
��4 5
true
��6 :
;
��: ;
options
�� 
.
�� 
ReportApiVersions
�� !
=
��" #
true
��$ (
;
��( )
}
�� 
)
�� 
.
�� 
AddApiExplorer
�� 
(
�� 
options
�� 
=>
�� 
{
�� 
options
�� 
.
�� 
GroupNameFormat
�� 
=
��  !
$str
��" *
;
��* +
options
�� 
.
�� '
SubstituteApiVersionInUrl
�� )
=
��* +
true
��, 0
;
��0 1
}
�� 
)
�� 
;
�� 
builder�� 
.
�� 
Services
�� 
.
�� /
!AddFluentValidationAutoValidation
�� 2
(
��2 3
)
��3 4
;
��4 5
builder�� 
.
�� 
Services
�� 
.
�� 1
#AddValidatorsFromAssemblyContaining
�� 4
<
��4 5
BankDtoValidator
��5 E
>
��E F
(
��F G
)
��G H
;
��H I
builder�� 
.
�� 
Services
�� 
.
�� %
AddEndpointsApiExplorer
�� (
(
��( )
)
��) *
;
��* +
builder�� 
.
�� 
Services
�� 
.
�� 
AddTransient
�� 
<
�� 
IConfigureOptions
�� /
<
��/ 0
SwaggerGenOptions
��0 A
>
��A B
,
��B C%
SwaggerConfigureOptions
��D [
>
��[ \
(
��\ ]
)
��] ^
;
��^ _
builder�� 
.
�� 
Services
�� 
.
�� 
AddSwaggerGen
�� 
(
�� 
options
�� &
=>
��' )
{�� 
options
�� 
.
�� 
OperationFilter
�� 
<
�� "
SwaggerDefaultValues
�� 0
>
��0 1
(
��1 2
)
��2 3
;
��3 4
options
�� 
.
��  
IncludeXmlComments
�� 
(
�� 
Path
�� #
.
��# $
Combine
��$ +
(
��+ ,

AppContext
��, 6
.
��6 7
BaseDirectory
��7 D
,
��D E
$"
��F H
{
��H I
Assembly
��I Q
.
��Q R"
GetExecutingAssembly
��R f
(
��f g
)
��g h
.
��h i
GetName
��i p
(
��p q
)
��q r
.
��r s
Name
��s w
}
��w x
$str
��x |
"
��| }
)
��} ~
)
��~ 
;�� �
}�� 
)
�� 
;
�� 
var�� 
app
�� 
=
�� 	
builder
��
 
.
�� 
Build
�� 
(
�� 
)
�� 
;
�� 
if�� 
(
�� 
app
�� 
.
�� 
Environment
�� 
.
�� 
IsDevelopment
�� !
(
��! "
)
��" #
)
��# $
{�� 
app
�� 
.
�� 

UseSwagger
�� 
(
�� 
options
�� 
=>
�� 
{
�� 
options
�� 
.
�� !
PreSerializeFilters
�� #
.
��# $
Add
��$ '
(
��' (
(
��( )
swagger
��) 0
,
��0 1
req
��2 5
)
��5 6
=>
��7 9
{
�� 	
swagger
�� 
.
�� 
Servers
�� 
=
�� 
new
�� !
List
��" &
<
��& '
OpenApiServer
��' 4
>
��4 5
(
��5 6
)
��6 7
{
��8 9
new
��: =
OpenApiServer
��> K
(
��K L
)
��L M
{
��N O
Url
��P S
=
��T U
$"
��V X
$str
��X `
{
��` a
req
��a d
.
��d e
Host
��e i
}
��i j
"
��j k
}
��l m
}
��n o
;
��o p
}
�� 	
)
��	 

;
��
 
}
�� 
)
�� 
;
�� 
app
�� 
.
�� 
UseSwaggerUI
�� 
(
�� 
options
�� 
=>
�� 
{
�� 
var
�� $
ApiVersionDescriptions
�� "
=
��# $
app
��% (
.
��( )!
DescribeApiVersions
��) <
(
��< =
)
��= >
;
��> ?
foreach
�� 
(
�� 
var
�� 
desc
�� 
in
�� $
ApiVersionDescriptions
�� 3
)
��3 4
{
�� 	
options
�� 
.
�� 
SwaggerEndpoint
�� #
(
��# $
$"
��$ &
$str
��& 1
{
��1 2
desc
��2 6
.
��6 7
	GroupName
��7 @
}
��@ A
$str
��A N
"
��N O
,
��O P
$"
��Q S
$str
��S d
{
��d e
desc
��e i
.
��i j

ApiVersion
��j t
.
��t u
ToString
��u }
(
��} ~
)
��~ 
}�� �
"��� �
)��� �
;��� �
options
�� 
.
�� &
DefaultModelsExpandDepth
�� ,
(
��, -
-
��- .
$num
��. /
)
��/ 0
;
��0 1
options
�� 
.
�� 
DocExpansion
��  
(
��  !
Swashbuckle
��! ,
.
��, -

AspNetCore
��- 7
.
��7 8
	SwaggerUI
��8 A
.
��A B
DocExpansion
��B N
.
��N O
None
��O S
)
��S T
;
��T U
}
�� 	
}
�� 
)
�� 
;
�� 
}�� 
app�� 
.
�� !
UseHttpsRedirection
�� 
(
�� 
)
�� 
;
�� 
app�� 
.
�� 
UseAuthorization
�� 
(
�� 
)
�� 
;
�� 
app�� 
.
�� 
MapControllers
�� 
(
�� 
)
�� 
;
�� 
app�� 
.
�� 
Run
�� 
(
�� 
)
�� 	
;
��	 
�%
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
}88 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/OpenAPI/SwaggerConfigureOptions.cs
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
$str	] �
}
� �
,
� �
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
}22 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Filters/HttpGlobalExceptionFilter.cs
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
cancellationToken	t �
)
� �
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
}## �
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
} ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v2/FinanceController.cs
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
bankSortCodesService	  w �
,
  � �%
IChartOfAccountsService
  � �$
chartOfAccountsService
  � �
,
  � �+
ICurrencyAndExchangeRateService!!! @*
currencyAndExchangeRateService!!A _
,!!_ `
IFormsService!!a n
formsService!!o {
,!!{ | 
IPaymentModeService	!!} � 
paymentModeService
!!� �
,
!!� �!
IPaymentTypeService
!!� � 
paymentTypeService
!!� �
,
!!� �
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
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '"
BankSortCodesReadDto
��' ;
>
��; <
>
��< =
AddBankSortCodes
��> N
(
��N O
[
��O P
FromBody
��P X
]
��X Y$
BankSortCodesCreateDto
��Z p
values
��q w
)
��w x
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_bankSortCodesService
��  5
.
��5 6#
AddBankSortCodesAsync
��6 K
(
��K L
values
��L R
)
��R S
)
��S T
;
��T U
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� )
)
��) *
]
��* +
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3$
ChartOfAccountsReadDto
��3 I
>
��I J
>
��J K
>
��K L 
GetChartOfAccounts
��M _
(
��_ `
)
��` a
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� %
_chartOfAccountsService
�� 3
.
��3 4%
GetChartOfAccountsAsync
��4 K
(
��K L
)
��L M
)
��M N
;
��N O
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '$
ChartOfAccountsReadDto
��' =
>
��= >
>
��> ?
AddChartOfAccount
��@ Q
(
��Q R
[
��R S
FromBody
��S [
]
��[ \&
ChartOfAccountsCreateDto
��] u
values
��v |
)
��| }
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� %
_chartOfAccountsService
��  7
.
��7 8%
AddChartOfAccountsAsync
��8 O
(
��O P
values
��P V
)
��V W
)
��W X
;
��X Y
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3,
CurrencyAndExchangeRateReadDto
��3 Q
>
��Q R
>
��R S
>
��S T)
GetCurrencyAndExchangeRates
��U p
(
��p q
)
��q r
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� -
_currencyAndExchangeRateService
�� ;
.
��; <-
GetCurrencyAndExchangeRateAsync
��< [
(
��[ \
)
��\ ]
)
��] ^
;
��^ _
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� +
)
��+ ,
]
��, -
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ',
CurrencyAndExchangeRateReadDto
��' E
>
��E F
>
��F G(
AddCurrencyAndExchangeRate
��H b
(
��b c
[
��c d
FromBody
��d l
]
��l m/
 CurrencyAndExchangeRateCreateDto��n �
values��� �
)��� �
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� -
_currencyAndExchangeRateService
��  ?
.
��? @-
AddCurrencyAndExchangeRateAsync
��@ _
(
��_ `
values
��` f
)
��f g
)
��g h
;
��h i
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3!
InvoiceTypesReadDto
��3 F
>
��F G
>
��G H
>
��H I
GetInvoiceTypes
��J Y
(
��Y Z
)
��Z [
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_invoiceTypesService
�� 0
.
��0 1"
GetInvoiceTypesAsync
��1 E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
��  
)
��  !
]
��! "
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '!
InvoiceTypesReadDto
��' :
>
��: ;
>
��; <
AddInvoiceTypes
��= L
(
��L M
[
��M N
FromBody
��N V
]
��V W#
InvoiceTypesCreateDto
��X m
values
��n t
)
��t u
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_invoiceTypesService
��  4
.
��4 5"
AddInvoiceTypesAsync
��5 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
FormsReadDto
��3 ?
>
��? @
>
��@ A
>
��A B
GetForms
��C K
(
��K L
)
��L M
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_formsService
�� )
.
��) *
GetFormsAsync
��* 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
FormsReadDto
��' 3
>
��3 4
>
��4 5
AddForm
��6 =
(
��= >
[
��> ?
FromBody
��? G
]
��G H
FormsCreateDto
��I W
values
��X ^
)
��^ _
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_formsService
��  -
.
��- .
AddFormsAsync
��. ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3 
PaymentModeReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetPaymentModes
��I X
(
��X Y
)
��Y Z
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentModeService
�� /
.
��/ 0!
GetPaymentModeAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
PaymentModeReadDto
��' 9
>
��9 :
>
��: ;
AddPaymentMode
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
PaymentModeCreateDto
��V j
values
��k q
)
��q r
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentModeService
��  3
.
��3 4!
AddPaymentModeAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3 
PaymentTypeReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetPaymentTypes
��I X
(
��X Y
)
��Y Z
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentTypeService
�� /
.
��/ 0!
GetPaymentTypeAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
PaymentTypeReadDto
��' 9
>
��9 :
>
��: ;
AddPaymentType
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
PaymentTypeCreateDto
��V j
values
��k q
)
��q r
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentTypeService
��  3
.
��3 4!
AddPaymentTypeAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� #
)
��# $
]
��$ %
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
PaypointsReadDto
��3 C
>
��C D
>
��D E
>
��E F
GetPaypoints
��G S
(
��S T
)
��T U
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_payPointsService
�� -
.
��- .
GetPaypointsAsync
��. ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
PaypointsReadDto
��' 7
>
��7 8
>
��8 9
AddPaypoint
��: E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
PaypointsCreateDto
��Q c
values
��d j
)
��j k
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_payPointsService
��  1
.
��1 2
AddPaypointsAsync
��2 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.cs
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
bankSortCodesService	  w �
,
  � �%
IChartOfAccountsService
  � �$
chartOfAccountsService
  � �
,
  � �+
ICurrencyAndExchangeRateService!!! @*
currencyAndExchangeRateService!!A _
,!!_ `
IFormsService!!a n
formsService!!o {
,!!{ | 
IPaymentModeService	!!} � 
paymentModeService
!!� �
,
!!� �!
IPaymentTypeService
!!� � 
paymentTypeService
!!� �
,
!!� �
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
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '"
BankSortCodesReadDto
��' ;
>
��; <
>
��< =
AddBankSortCodes
��> N
(
��N O
[
��O P
FromBody
��P X
]
��X Y$
BankSortCodesCreateDto
��Z p
values
��q w
)
��w x
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_bankSortCodesService
��  5
.
��5 6#
AddBankSortCodesAsync
��6 K
(
��K L
values
��L R
)
��R S
)
��S T
;
��T U
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� )
)
��) *
]
��* +
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3$
ChartOfAccountsReadDto
��3 I
>
��I J
>
��J K
>
��K L 
GetChartOfAccounts
��M _
(
��_ `
)
��` a
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� %
_chartOfAccountsService
�� 3
.
��3 4%
GetChartOfAccountsAsync
��4 K
(
��K L
)
��L M
)
��M N
;
��N O
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '$
ChartOfAccountsReadDto
��' =
>
��= >
>
��> ?
AddChartOfAccount
��@ Q
(
��Q R
[
��R S
FromBody
��S [
]
��[ \&
ChartOfAccountsCreateDto
��] u
values
��v |
)
��| }
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� %
_chartOfAccountsService
��  7
.
��7 8%
AddChartOfAccountsAsync
��8 O
(
��O P
values
��P V
)
��V W
)
��W X
;
��X Y
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3,
CurrencyAndExchangeRateReadDto
��3 Q
>
��Q R
>
��R S
>
��S T)
GetCurrencyAndExchangeRates
��U p
(
��p q
)
��q r
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� -
_currencyAndExchangeRateService
�� ;
.
��; <-
GetCurrencyAndExchangeRateAsync
��< [
(
��[ \
)
��\ ]
)
��] ^
;
��^ _
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� +
)
��+ ,
]
��, -
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ',
CurrencyAndExchangeRateReadDto
��' E
>
��E F
>
��F G(
AddCurrencyAndExchangeRate
��H b
(
��b c
[
��c d
FromBody
��d l
]
��l m/
 CurrencyAndExchangeRateCreateDto��n �
values��� �
)��� �
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� -
_currencyAndExchangeRateService
��  ?
.
��? @-
AddCurrencyAndExchangeRateAsync
��@ _
(
��_ `
values
��` f
)
��f g
)
��g h
;
��h i
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3!
InvoiceTypesReadDto
��3 F
>
��F G
>
��G H
>
��H I
GetInvoiceTypes
��J Y
(
��Y Z
)
��Z [
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_invoiceTypesService
�� 0
.
��0 1"
GetInvoiceTypesAsync
��1 E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
��  
)
��  !
]
��! "
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '!
InvoiceTypesReadDto
��' :
>
��: ;
>
��; <
AddInvoiceTypes
��= L
(
��L M
[
��M N
FromBody
��N V
]
��V W#
InvoiceTypesCreateDto
��X m
values
��n t
)
��t u
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_invoiceTypesService
��  4
.
��4 5"
AddInvoiceTypesAsync
��5 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
FormsReadDto
��3 ?
>
��? @
>
��@ A
>
��A B
GetForms
��C K
(
��K L
)
��L M
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_formsService
�� )
.
��) *
GetFormsAsync
��* 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
FormsReadDto
��' 3
>
��3 4
>
��4 5
AddForm
��6 =
(
��= >
[
��> ?
FromBody
��? G
]
��G H
FormsCreateDto
��I W
values
��X ^
)
��^ _
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_formsService
��  -
.
��- .
AddFormsAsync
��. ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3 
PaymentModeReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetPaymentModes
��I X
(
��X Y
)
��Y Z
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentModeService
�� /
.
��/ 0!
GetPaymentModeAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
PaymentModeReadDto
��' 9
>
��9 :
>
��: ;
AddPaymentMode
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
PaymentModeCreateDto
��V j
values
��k q
)
��q r
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentModeService
��  3
.
��3 4!
AddPaymentModeAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3 
PaymentTypeReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetPaymentTypes
��I X
(
��X Y
)
��Y Z
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentTypeService
�� /
.
��/ 0!
GetPaymentTypeAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
PaymentTypeReadDto
��' 9
>
��9 :
>
��: ;
AddPaymentType
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
PaymentTypeCreateDto
��V j
values
��k q
)
��q r
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_paymentTypeService
��  3
.
��3 4!
AddPaymentTypeAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� #
)
��# $
]
��$ %
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
PaypointsReadDto
��3 C
>
��C D
>
��D E
>
��E F
GetPaypoints
��G S
(
��S T
)
��T U
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_payPointsService
�� -
.
��- .
GetPaypointsAsync
��. ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
PaypointsReadDto
��' 7
>
��7 8
>
��8 9
AddPaypoint
��: E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
PaypointsCreateDto
��Q c
values
��d j
)
��j k
{
�� 	
try
�� 
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_payPointsService
��  1
.
��1 2
AddPaypointsAsync
��2 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
}
�� 
}�� 