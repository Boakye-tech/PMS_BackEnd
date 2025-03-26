l
j/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Usings.cs�k
k/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Program.cs
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
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB `
)` a
;a b
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
if!! 
(!! 
builder!! 
.!! 
Environment!! 
.!! 
IsProduction!! $
(!!$ %
)!!% &
)!!& '
{"" 
var## 
currentDirectory## 
=## 
	Directory## $
.##$ %
GetCurrentDirectory##% 8
(##8 9
)##9 :
;##: ;
var$$ 
solutionDirectory$$ 
=$$ 
	Directory$$ %
.$$% &
	GetParent$$& /
($$/ 0
currentDirectory$$0 @
)$$@ A
?$$A B
.$$B C
Parent$$C I
?$$I J
.$$J K
FullName$$K S
??$$T V
$str$$W Y
;$$Y Z
var%% #
solutionLevelConfigPath%% 
=%%  !
Path%%" &
.%%& '
Combine%%' .
(%%. /
solutionDirectory%%/ @
,%%@ A
$str%%B T
)%%T U
;%%U V
if'' 
('' 
File'' 
.'' 
Exists'' 
('' #
solutionLevelConfigPath'' +
)''+ ,
)'', -
{(( 
builder)) 
.)) 
Configuration)) 
.)) 
AddJsonFile)) )
())) *#
solutionLevelConfigPath))* A
,))A B
optional))C K
:))K L
false))M R
,))R S
reloadOnChange))T b
:))b c
true))d h
)))h i
;))i j
}** 
}++ 
builder.. 
... 
Host.. 
... 

UseSerilog.. 
(.. 
(.. 
context..  
,..  !
configuration.." /
)../ 0
=>..1 3
configuration..4 A
...A B
ReadFrom..B J
...J K
Configuration..K X
(..X Y
context..Y `
...` a
Configuration..a n
)..n o
)..o p
;..p q
if11 
(11 
builder11 
.11 
Environment11 
.11 
IsDevelopment11 %
(11% &
)11& '
)11' (
{22 
switch33 

(33 
builder33 
.33 
Configuration33 !
.33! "

GetSection33" ,
(33, -
$str33- 7
)337 8
.338 9

GetSection339 C
(33C D
$str33D V
)33V W
.33W X
Value33X ]
)33] ^
{44 
case55 
$str55 
:55 
break77 
;77 
case88 
$str88 
:88 
builder99 
.99 
Services99 
.99 
AddDbContext99 )
<99) * 
ApplicationDBContext99* >
>99> ?
(99? @
options99@ G
=>99H J
options99K R
.99R S
UseSqlServer99S _
(99_ `
builder99` g
.99g h
Configuration99h u
.99u v 
GetConnectionString	99v �
(
99� �
$str
99� �
)
99� �
)
99� �
)
99� �
;
99� �
break:: 
;:: 
};; 
}== 
if?? 
(?? 
builder?? 
.?? 
Environment?? 
.?? 
IsProduction?? $
(??$ %
)??% &
)??& '
{@@ 
switchAA 

(AA 
builderAA 
.AA 
ConfigurationAA !
.AA! "

GetSectionAA" ,
(AA, -
$strAA- 7
)AA7 8
.AA8 9

GetSectionAA9 C
(AAC D
$strAAD V
)AAV W
.AAW X
ValueAAX ]
)AA] ^
{BB 
caseCC 
$strCC 
:CC 
breakEE 
;EE 
caseFF 
$strFF 
:FF 
builderGG 
.GG 
ServicesGG 
.GG 
AddDbContextGG )
<GG) * 
ApplicationDBContextGG* >
>GG> ?
(GG? @
optionsGG@ G
=>GGH J
optionsGGK R
.GGR S
UseSqlServerGGS _
(GG_ `
builderGG` g
.GGg h
ConfigurationGGh u
.GGu v 
GetConnectionString	GGv �
(
GG� �
$str
GG� �
)
GG� �
)
GG� �
)
GG� �
;
GG� �
breakHH 
;HH 
}II 
}JJ 
builderLL 
.LL 
ServicesLL 
.LL 
AddCorsLL 
(LL 
oLL 
=>LL 
{MM 
oNN 
.NN 
AddDefaultPolicyNN 
(NN 
builderOO 
=>OO 
{PP 	
builderQQ 
.QQ 
AllowAnyOriginQQ "
(QQ" #
)QQ# $
.RR 
AllowAnyHeaderRR "
(RR" #
)RR# $
.SS 
AllowAnyMethodSS "
(SS" #
)SS# $
;SS$ %
}UU 	
)UU	 

;UU
 
}VV 
)VV 
;VV 
builderww 
.ww 
Servicesww 
.ww 
AddCustomerModuleww "
(ww" #
builderww# *
.ww* +
Configurationww+ 8
)ww8 9
;ww9 :
builder{{ 
.{{ 
Services{{ 
.{{ 
AddExceptionHandler{{ $
<{{$ %%
HttpGlobalExceptionFilter{{% >
>{{> ?
({{? @
){{@ A
;{{A B
builder|| 
.|| 
Services|| 
.|| 
AddProblemDetails|| "
(||" #
)||# $
;||$ %
builder~~ 
.~~ 
Services~~ 
.~~ 
AddControllers~~ 
(~~  
)~~  !
;~~! "
builder 
. 
Services 
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
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presentation (
.( )
OpenAPI) 0
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
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
	Customers		 
.		 
Presentation		 (
.		( )
OpenAPI		) 0
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
$str E
,E F
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
}22 �
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/ModuleExtensions.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presentation (
{ 
public 
static 
class 
ModuleExtensions %
{ 
public 
static 
IServiceCollection (
AddCustomerModule) :
(: ;
this; ?
IServiceCollection@ R
servicesS [
,[ \
IConfiguration] k
configurationl y
)y z
{		 	
services

 
. %
AddCustomerInfrastructure *
(* +
configuration+ 8
)8 9
;9 :
services 
. 
	AddScoped 
< 
IUnitOfWork *
,* +

UnitOfWork, 6
>6 7
(7 8
)8 9
;9 :
services 
. 
	AddScoped 
< #
IPropertyDetailsService 6
,6 7"
PropertyDetailsService8 N
>N O
(O P
)P Q
;Q R
services 
. 
	AddScoped 
< #
ICustomerDetailsService 6
,6 7"
CustomerDetailsService8 N
>N O
(O P
)P Q
;Q R
services 
. 
	AddScoped 
< (
ICustomerTransactionsService ;
,; <'
CustomerTransactionsService= X
>X Y
(Y Z
)Z [
;[ \
services 
. 
	AddScoped 
< $
ICustomerPaymentsService 7
,7 8#
CustomerPaymentsService9 P
>P Q
(Q R
)R S
;S T
services 
. 
	AddScoped 
< #
ICustomerInvoiceService 6
,6 7"
CustomerInvoiceService8 N
>N O
(O P
)P Q
;Q R
services 
. 
AddSingleton !
(! "
s" #
=>$ &
{ 
return 
new 
BlobServiceClient ,
(, -
$str	- �
)
� �
;
� �
} 
) 
; 
services 
. 
	AddScoped 
< 
IAzureBlobService 0
,0 1
AzureBlobService2 B
>B C
(C D
)D E
;E F
services   
.   
AddAutoMapper   "
(  " #
	AppDomain  # ,
.  , -
CurrentDomain  - :
.  : ;
GetAssemblies  ; H
(  H I
)  I J
)  J K
;  K L
return## 
services## 
;## 
}$$ 	
}%% 
}&& �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Filters/HttpGlobalExceptionFilter.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presentation (
.( )
Filters) 0
;0 1
public 
class %
HttpGlobalExceptionFilter &
:' (
IExceptionHandler) :
{ 
public		 

readonly		 
ILogger		 
<		 %
HttpGlobalExceptionFilter		 5
>		5 6
_logger		7 >
;		> ?
public 
%
HttpGlobalExceptionFilter $
($ %
ILogger% ,
<, -%
HttpGlobalExceptionFilter- F
>F G
loggerH N
)N O
{ 
_logger 
= 
logger 
; 
} 
public 

async 
	ValueTask 
< 
bool 
>  
TryHandleAsync! /
(/ 0
HttpContext0 ;
httpContext< G
,G H
	ExceptionI R
	exceptionS \
,\ ]
CancellationToken^ o
cancellationToken	p �
)
� �
{ 
_logger 
. 
LogError 
( 
	exception "
," #
$str$ C
,C D
	exceptionE N
.N O
MessageO V
)V W
;W X
var 
problemDetails 
= 
new  
ProblemDetails! /
{ 	
Status 
= 
StatusCodes  
.  !(
Status500InternalServerError! =
,= >
Title 
= 
$str "
," #
Detail 
= 
	exception 
. 
Message &
} 	
;	 

httpContext 
. 
Response 
. 

StatusCode '
=( )
problemDetails* 8
.8 9
Status9 ?
.? @
Value@ E
;E F
await 
httpContext 
. 
Response "
." #
WriteAsJsonAsync# 3
(3 4
problemDetails4 B
,B C
cancellationTokenD U
)U V
;V W
return 
true 
; 
}!! 
}"" �%
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Controllers/v2/OnlineCustomerController.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presntation '
.' (
Controllers( 3
.3 4
v24 6
;6 7
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[		 
Route		 
(		 
$str		 /
)		/ 0
]		0 1
[

 
Produces

 	
(

	 

$str


 
)

 
]

 
public 
class $
OnlineCustomerController %
:& '
ControllerBase( 6
{ 
private 
readonly 
ILogger 
< $
OnlineCustomerController 5
>5 6
_logger7 >
;> ?
private 
readonly #
IPropertyDetailsService ,#
_propertyDetailsService- D
;D E
public 
$
OnlineCustomerController #
(# $
ILogger$ +
<+ ,$
OnlineCustomerController, D
>D E
loggerF L
,L M#
IPropertyDetailsServiceN e"
propertyDetailsServicef |
)| }
{ 
_logger 
= 
logger 
; #
_propertyDetailsService 
=  !"
propertyDetailsService" 8
;8 9
} 
["" 
HttpGet"" 
("" 
$str"" 8
,""8 9
Name"": >
=""? @
$str""A c
)""c d
]""d e
public## 

async## 
Task## 
<## 
IEnumerable## !
<##! "(
PropertySummaryMobileViewDto##" >
>##> ?
>##? @

MobileView##A K
(##K L
string##L R
customerCode##S _
)##_ `
{$$ 
return%%	 
await%% #
_propertyDetailsService%% -
.%%- .$
GetPropertySummaryMobile%%. F
(%%F G
customerCode%%G S
)%%S T
;%%T U
}&& 
[(( 
HttpGet(( 
((( 
$str(( 5
,((5 6
Name((7 ;
=((< =
$str((> ]
)((] ^
]((^ _
public)) 

async)) 
Task)) 
<)) 
IEnumerable)) !
<))! "%
PropertySummaryWebViewDto))" ;
>)); <
>))< =
WebView))> E
())E F
string))F L
customerCode))M Y
)))Y Z
{** 
return++ 
await++ #
_propertyDetailsService++ ,
.++, -!
GetPropertySummaryWeb++- B
(++B C
customerCode++C O
)++O P
;++P Q
},, 
[.. 
HttpGet.. 
(.. 
$str.. /
)../ 0
]..0 1
public// 

async// 
Task// 
<// "
PropertyDetailsReadDto// ,
>//, -
PropertyDetails//. =
(//= >
string//> D
propertyNumber//E S
)//S T
{00 
string11 
propertynumber11 
=11 
HttpUtility11  +
.11+ ,
	UrlDecode11, 5
(115 6
propertyNumber116 D
)11D E
;11E F
return22 
await22 #
_propertyDetailsService22 ,
.22, -
GetPropertyDetails22- ?
(22? @
propertynumber22@ N
)22N O
;22O P
}33 
[55 
HttpPost55 
(55 
$str55 "
,55" #
Name55$ (
=55) *
$str55+ G
)55G H
]55H I
public66 

Task66 
<66 
IActionResult66 
>66 
CustomerDetails66 .
(66. /
CustomerDetailsDto66/ A
values66B H
)66H I
{77 
return88 
null88 
!88 
;88 
}99 
[;; 
HttpPost;; 
(;; 
$str;; "
);;" #
];;# $
public<< 

async<< 
Task<< 
<<< 
GenericResponseDto<< (
><<( )
PropertyDetails<<* 9
(<<9 :
PropertyDetailsDto<<: L
values<<M S
)<<S T
{== 
return>> 
await>> #
_propertyDetailsService>> ,
.>>, -!
AddNewPropertyDetails>>- B
(>>B C
values>>C I
)>>I J
;>>J K
}@@ 
}BB �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Controllers/v2/FileManagerController.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presntation '
.' (
Controllers( 3
;3 4
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[		 
Route		 
(		 
$str		 /
)		/ 0
]		0 1
[

 
Produces

 	
(

	 

$str


 
)

 
]

 
public 
class !
FileManagerController "
:# $
ControllerBase% 3
{ 
private 
readonly 
IAzureBlobService &
_blobService' 3
;3 4
public 
!
FileManagerController  
(  !
IAzureBlobService! 2
blobService3 >
)> ?
{ 
_blobService 
= 
blobService "
;" #
} 
[ 
HttpPost 
] 
[ 
Route 

(
 
$str  
)  !
]! "
public 

async 
Task 
< 
IActionResult #
># $
UploadFileDocuments% 8
(8 9
	IFormFile9 B
filesC H
)H I
{ 
try 
{ 	
if 
( 
files 
== 
null 
) 
return 

BadRequest !
(! "
)" #
;# $
var!! 
result!! 
=!! 
await!! 
_blobService!! +
.!!+ ,
UploadFileBlobAsync!!, ?
(!!? @
$str!!@ Y
,!!Y Z
files!![ `
.!!` a
OpenReadStream!!a o
(!!o p
)!!p q
,!!q r
files!!s x
.!!x y
ContentType	!!y �
,
!!� �
files
!!� �
.
!!� �
FileName
!!� �
)
!!� �
;
!!� �
var"" 
toReturn"" 
="" 
result"" !
.""! "
AbsoluteUri""" -
;""- .
return$$ 
Ok$$ 
($$ 
new$$ 
{$$ 
path$$  
=$$! "
toReturn$$# +
}$$, -
)$$- .
;$$. /
}%% 	
catch&& 
(&& 
	Exception&& 
ex&& 
)&& 
{'' 	
return(( 

BadRequest(( 
((( 
new(( !
{((" #
error(($ )
=((* +
ex((, .
.((. /
ToString((/ 7
(((7 8
)((8 9
}((: ;
)((; <
;((< =
})) 	
}** 
},, ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Controllers/v1/OnlineCustomerController.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presntation '
.' (
Controllers( 3
.3 4
v14 6
;6 7
[ 
ApiController 
] 
[		 

ApiVersion		 
(		 
$str		 
)		 
]		 
[

 
Route

 
(

 
$str

 /
)

/ 0
]

0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class $
OnlineCustomerController %
:& '
ControllerBase( 6
{ 
private 
readonly 
ILogger 
< $
OnlineCustomerController 5
>5 6
_logger7 >
;> ?
private 
readonly #
IPropertyDetailsService ,#
_propertyDetailsService- D
;D E
private 
readonly #
ICustomerDetailsService ,#
_customerDetailsService- D
;D E
private 
readonly (
ICustomerTransactionsService 1 
_transactionsService2 F
;F G
private 
readonly #
ICustomerInvoiceService ,
_invoiceService- <
;< =
private 
readonly $
ICustomerPaymentsService -
_paymentsService. >
;> ?
public 
$
OnlineCustomerController #
(# $
ILogger$ +
<+ ,$
OnlineCustomerController, D
>D E
loggerF L
,L M#
IPropertyDetailsServiceN e"
propertyDetailsServicef |
,| }$
ICustomerDetailsService	~ �$
customerDetailsService
� �
,
� �*
ICustomerTransactionsService
� �!
transactionsService
� �
,
� �%
ICustomerInvoiceService
� �
invoiceService
� �
,
� �&
ICustomerPaymentsService
� �
paymentsService
� �
)
� �
{ 
_logger 
= 
logger 
; #
_propertyDetailsService 
=  !"
propertyDetailsService" 8
;8 9#
_customerDetailsService 
=  !"
customerDetailsService" 8
;8 9 
_transactionsService 
= 
transactionsService 2
;2 3
_invoiceService 
= 
invoiceService (
;( )
_paymentsService 
= 
paymentsService *
;* +
} 
[ 
HttpGet 
( 
$str "
)" #
]# $
public   

async   
Task   
<   
IEnumerable   !
<  ! "+
AvailablePropertySummaryViewDto  " A
>  A B
>  B C
AvailableProperties  D W
(  W X
)  X Y
{!! 
return"" 
await"" #
_propertyDetailsService"" ,
."", -&
AvailablePropertiesSummary""- G
(""G H
)""H I
;""I J
}## 
[&& 
HttpGet&& 
(&& 
$str&& 8
,&&8 9
Name&&: >
=&&? @
$str&&A c
)&&c d
]&&d e
public'' 

async'' 
Task'' 
<'' 
IEnumerable'' !
<''! "(
PropertySummaryMobileViewDto''" >
>''> ?
>''? @

MobileView''A K
(''K L
string''L R
customerCode''S _
)''_ `
{(( 
return))	 
await)) #
_propertyDetailsService)) -
.))- .$
GetPropertySummaryMobile)). F
())F G
customerCode))G S
)))S T
;))T U
}** 
[,, 
HttpGet,, 
(,, 
$str,, 5
,,,5 6
Name,,7 ;
=,,< =
$str,,> ]
),,] ^
],,^ _
public-- 

async-- 
Task-- 
<-- 
IEnumerable-- !
<--! "%
PropertySummaryWebViewDto--" ;
>--; <
>--< =
WebView--> E
(--E F
string--F L
customerCode--M Y
)--Y Z
{.. 
return// 
await// #
_propertyDetailsService// ,
.//, -!
GetPropertySummaryWeb//- B
(//B C
customerCode//C O
)//O P
;//P Q
}00 
[22 
HttpGet22 
(22 
$str22 
)22 
]22  
public33 

async33 
Task33 
<33 "
PropertyDetailsReadDto33 ,
>33, -
PropertyDetails33. =
(33= >
[33> ?
	FromQuery33? H
]33H I
string33J P
propertyNumber33Q _
)33_ `
{44 
string55 
propertynumber55 
=55 
HttpUtility55  +
.55+ ,
	UrlDecode55, 5
(555 6
propertyNumber556 D
)55D E
;55E F
return66 
await66 #
_propertyDetailsService66 ,
.66, -
GetPropertyDetails66- ?
(66? @
propertynumber66@ N
)66N O
;66O P
}77 
[99 
HttpGet99 
(99 
$str99 #
)99# $
]99$ %
public:: 

async:: 
Task:: 
<:: 
IEnumerable:: !
<::! "'
CustomerTransactionsReadDto::" =
>::= >
>::> ? 
CustomerTransactions::@ T
(::T U
[::U V
	FromQuery::V _
]::_ `
string::a g
customerCode::h t
,::t u
[::v w
	FromQuery	::w �
]
::� �
string
::� �
propertyNumber
::� �
)
::� �
{;; 
if<< 

(<< 
propertyNumber<< 
==<< 
null<< "
&&<<# %
customerCode<<& 2
==<<3 5
null<<6 :
)<<: ;
{== 	
return>> 
null>> 
!>> 
;>> 
}?? 	
stringAA 
propertynumberAA 
=AA 
HttpUtilityAA  +
.AA+ ,
	UrlDecodeAA, 5
(AA5 6
propertyNumberAA6 D
!AAD E
)AAE F
;AAF G
returnBB 
awaitBB  
_transactionsServiceBB )
.BB) *&
CustomerTransactionDetailsBB* D
(BBD E
customerCodeBBF R
,BBR S
propertynumberBBT b
)BBb c
;BBc d
}DD 
[GG 
HttpGetGG 
(GG 
$strGG  
)GG  !
]GG! "
publicHH 

asyncHH 
TaskHH 
<HH 
IEnumerableHH !
<HH! "'
CustomerTransactionsReadDtoHH" =
>HH= >
>HH> ?
CustomerStatementHH@ Q
(HHQ R
[HHR S
	FromQueryHHS \
]HH\ ]
stringHH^ d
?HHd e
customerCodeHHf r
,HHr s
[HHt u
	FromQueryHHu ~
]HH~ 
string
HH� �
?
HH� �
propertyNumber
HH� �
,
HH� �
[
HH� �
	FromQuery
HH� �
]
HH� �
string
HH� �
?
HH� �&
receipt_or_invoiceNumber
HH� �
,
HH� �
[
HH� �
	FromQuery
HH� �
]
HH� �
string
HH� �
?
HH� �
transactionType
HH� �
,
HH� �
[
HH� �
	FromQuery
HH� �
]
HH� �
int
HH� �
year
HH� �
)
HH� �
{II 
ifJJ 

(JJ 
customerCodeJJ 
==JJ 
nullJJ  
&&JJ! #
propertyNumberJJ$ 2
==JJ3 5
nullJJ6 :
&&JJ; =$
receipt_or_invoiceNumberJJ> V
==JJW Y
nullJJZ ^
&&JJ_ a
transactionTypeJJb q
==JJr t
nullJJu y
&&JJz |
year	JJ} �
.
JJ� �
ToString
JJ� �
(
JJ� �
)
JJ� �
.
JJ� �
Length
JJ� �
!=
JJ� �
$num
JJ� �
)
JJ� �
{KK 	
returnLL 
nullLL 
!LL 
;LL 
}MM 	
stringOO 
propertynumberOO 
=OO 
HttpUtilityOO  +
.OO+ ,
	UrlDecodeOO, 5
(OO5 6
propertyNumberOO6 D
!OOD E
)OOE F
;OOF G
returnPP 
awaitPP  
_transactionsServicePP )
.PP) *
CustomerStatementPP* ;
(PP; <
customerCodePP< H
!PPH I
,PPI J
propertynumberPPK Y
,PPY Z$
receipt_or_invoiceNumberPP[ s
!PPs t
,PPt u
transactionType	PPv �
!
PP� �
,
PP� �
year
PP� �
)
PP� �
;
PP� �
}QQ 
[SS 
HttpGetSS 
(SS 
$strSS %
)SS% &
]SS& '
publicTT 

asyncTT 
TaskTT 
<TT 
IEnumerableTT !
<TT! "&
CustomerPaymentsSummaryDtoTT" <
>TT< =
>TT= >"
CustomerPaymentSummaryTT? U
(TTU V
[TTV W
	FromQueryTTW `
]TT` a
stringTTb h
?TTh i
customerCodeTTj v
,TTv w
[TTx y
	FromQuery	TTy �
]
TT� �
string
TT� �
?
TT� �
propertyNumber
TT� �
,
TT� �
[
TT� �
	FromQuery
TT� �
]
TT� �
string
TT� �
?
TT� �
receiptNumber
TT� �
,
TT� �
[
TT� �
	FromQuery
TT� �
]
TT� �
string
TT� �
?
TT� �
paymentMode
TT� �
,
TT� �
[
TT� �
	FromQuery
TT� �
]
TT� �
int
TT� �
year
TT� �
)
TT� �
{UU 
ifVV 

(VV 
propertyNumberVV 
==VV 
nullVV "
&&VV# %
receiptNumberVV& 3
==VV4 6
nullVV7 ;
&&VV< >
paymentModeVV? J
==VVK M
nullVVN R
&&VVS U
customerCodeVVV b
==VVc e
nullVVf j
&&VVk m
yearVVn r
.VVr s
ToStringVVs {
(VV{ |
)VV| }
.VV} ~
Length	VV~ �
!=
VV� �
$num
VV� �
)
VV� �
{WW 	
returnXX 
nullXX 
!XX 
;XX 
}YY 	
string[[ 
propertynumber[[ 
=[[ 
HttpUtility[[  +
.[[+ ,
	UrlDecode[[, 5
([[5 6
propertyNumber[[6 D
![[D E
)[[E F
;[[F G
return\\ 
await\\ 
_paymentsService\\ %
.\\% &"
CustomerPaymentSummary\\& <
(\\< =
customerCode\\= I
,\\I J
propertynumber\\K Y
,\\Y Z
receiptNumber\\[ h
,\\h i
paymentMode\\j u
!\\u v
,\\v w
year\\x |
)\\| }
;\\} ~
}]] 
[`` 
HttpGet`` 
(`` 
$str`` %
)``% &
]``& '
publicaa 

asyncaa 
Taskaa 
<aa 
IEnumerableaa !
<aa! "
CustomerPaymentsDtoaa" 5
>aa5 6
>aa6 7"
CustomerPaymentDetailsaa8 N
(aaN O
[aaO P
	FromQueryaaP Y
]aaY Z
stringaa[ a
?aaa b
customerCodeaac o
,aao p
[aaq r
	FromQueryaar {
]aa{ |
string	aa} �
?
aa� �
propertyNumber
aa� �
,
aa� �
[
aa� �
	FromQuery
aa� �
]
aa� �
string
aa� �
?
aa� �
receiptNumber
aa� �
,
aa� �
[
aa� �
	FromQuery
aa� �
]
aa� �
string
aa� �
?
aa� �
paymentMode
aa� �
,
aa� �
[
aa� �
	FromQuery
aa� �
]
aa� �
int
aa� �
year
aa� �
)
aa� �
{bb 
ifcc 

(cc 
propertyNumbercc 
==cc 
nullcc "
&&cc# %
receiptNumbercc& 3
==cc4 6
nullcc7 ;
&&cc< >
paymentModecc? J
==ccK M
nullccN R
&&ccS U
customerCodeccV b
==ccc e
nullccf j
&&cck m
yearccn r
.ccr s
ToStringccs {
(cc{ |
)cc| }
.cc} ~
Length	cc~ �
!=
cc� �
$num
cc� �
)
cc� �
{dd 	
returnee 
nullee 
!ee 
;ee 
}ff 	
stringhh 
propertynumberhh 
=hh 
HttpUtilityhh  +
.hh+ ,
	UrlDecodehh, 5
(hh5 6
propertyNumberhh6 D
!hhD E
)hhE F
;hhF G
returnii 
awaitii 
_paymentsServiceii %
.ii% &"
CustomerPaymentDetailsii& <
(ii< =
customerCodeii= I
,iiI J
propertynumberiiK Y
,iiY Z
receiptNumberii[ h
,iih i
paymentModeiij u
!iiu v
,iiv w
yeariix |
)ii| }
;ii} ~
}jj 
[mm 
HttpGetmm 
(mm 
$strmm %
)mm% &
]mm& '
publicnn 

asyncnn 
Tasknn 
<nn 
IEnumerablenn !
<nn! ")
CustomerInvoiceSummaryReadDtonn" ?
>nn? @
>nn@ A"
CustomerInvoiceSummarynnB X
(nnX Y
[nnY Z
	FromQuerynnZ c
]nnc d
stringnne k
?nnk l
invoiceNumbernnm z
,nnz {
[nn| }
	FromQuery	nn} �
]
nn� �
string
nn� �
?
nn� �
customerCode
nn� �
,
nn� �
[
nn� �
	FromQuery
nn� �
]
nn� �
string
nn� �
?
nn� �
propertyNumber
nn� �
,
nn� �
[
nn� �
	FromQuery
nn� �
]
nn� �
string
nn� �
?
nn� �
status
nn� �
,
nn� �
[
nn� �
	FromQuery
nn� �
]
nn� �
int
nn� �
year
nn� �
)
nn� �
{oo 
ifpp 

(pp 
invoiceNumberpp 
==pp 
nullpp "
&&pp# %
propertyNumberpp& 4
==pp5 7
nullpp8 <
&&pp= ?
customerCodepp@ L
==ppM O
nullppP T
&&ppU W
statusppX ^
==pp_ a
nullppb f
&&ppg i
yearppj n
.ppn o
ToStringppo w
(ppw x
)ppx y
!ppy z
.ppz {
Length	pp{ �
!=
pp� �
$num
pp� �
)
pp� �
{qq 	
returnrr 
nullrr 
!rr 
;rr 
}ss 	
stringuu 
propertynumberuu 
=uu 
HttpUtilityuu  +
.uu+ ,
	UrlDecodeuu, 5
(uu5 6
propertyNumberuu6 D
!uuD E
)uuE F
;uuF G
returnvv 
awaitvv 
_invoiceServicevv $
.vv$ %"
CustomerInvoiceSummaryvv% ;
(vv; <
invoiceNumbervv< I
!vvI J
,vvJ K
customerCodevvL X
!vvX Y
,vvY Z
propertynumbervv[ i
,vvi j
statusvvk q
!vvq r
,vvr s
yearvvt x
)vvx y
;vvy z
}ww 
[yy 
HttpGetyy 
(yy 
$stryy %
)yy% &
]yy& '
publiczz 

asynczz 
Taskzz 
<zz 
IEnumerablezz !
<zz! "
CustomerInvoiceDtozz" 4
>zz4 5
>zz5 6"
CustomerInvoiceDetailszz7 M
(zzM N
[zzN O
	FromQueryzzO X
]zzX Y
stringzzZ `
?zz` a
invoiceNumberzzb o
,zzo p
[zzq r
	FromQueryzzr {
]zz{ |
string	zz} �
?
zz� �
customerCode
zz� �
,
zz� �
[
zz� �
	FromQuery
zz� �
]
zz� �
string
zz� �
?
zz� �
propertyNumber
zz� �
,
zz� �
[
zz� �
	FromQuery
zz� �
]
zz� �
string
zz� �
?
zz� �
status
zz� �
,
zz� �
[
zz� �
	FromQuery
zz� �
]
zz� �
int
zz� �
year
zz� �
)
zz� �
{{{ 
if|| 

(|| 
invoiceNumber|| 
==|| 
null|| !
&&||" $
propertyNumber||% 3
==||4 6
null||7 ;
&&||< >
customerCode||? K
==||L N
null||O S
&&||T V
status||W ]
==||^ `
null||a e
&&||f h
year||i m
.||m n
ToString||n v
(||v w
)||w x
!||x y
.||y z
Length	||z �
!=
||� �
$num
||� �
)
||� �
{}} 	
return~~ 
null~~ 
!~~ 
;~~ 
} 	
string
�� 
propertynumber
�� 
=
�� 
HttpUtility
��  +
.
��+ ,
	UrlDecode
��, 5
(
��5 6
propertyNumber
��6 D
!
��D E
)
��E F
;
��F G
return
�� 
await
�� 
_invoiceService
�� $
.
��$ %$
CustomerInvoiceDetails
��% ;
(
��; <
invoiceNumber
��< I
!
��I J
,
��J K
customerCode
��L X
!
��X Y
,
��Y Z
propertynumber
��[ i
,
��i j
status
��k q
!
��q r
,
��r s
year
��t x
)
��x y
;
��y z
}
�� 
[
�� 
HttpPost
�� 
(
�� 
$str
�� "
,
��" #
Name
��$ (
=
��) *
$str
��+ G
)
��G H
]
��H I
public
�� 

async
�� 
Task
�� 
<
��  
GenericResponseDto
�� (
>
��( )
CustomerDetails
��* 9
(
��9 : 
CustomerDetailsDto
��: L
values
��M S
)
��S T
{
�� 
return
�� 
await
�� %
_customerDetailsService
�� ,
.
��, -#
AddNewCustomerDetails
��- B
(
��B C
values
��C I
)
��I J
;
��J K
}
�� 
[
�� 
HttpPost
�� 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 

async
�� 
Task
�� 
<
��  
GenericResponseDto
�� (
>
��( )
PropertyDetails
��* 9
(
��9 : 
PropertyDetailsDto
��: L
values
��M S
)
��S T
{
�� 
return
�� 
await
�� %
_propertyDetailsService
�� ,
.
��, -#
AddNewPropertyDetails
��- B
(
��B C
values
��C I
)
��I J
;
��J K
}
�� 
[
�� 
HttpPost
�� 
(
�� 
$str
�� '
)
��' (
]
��( )
public
�� 

async
�� 
Task
�� 
<
��  
GenericResponseDto
�� (
>
��( )%
AddCustomerTransactions
��* A
(
��A B%
CustomerTransactionsDto
��B Y
values
��Z `
)
��` a
{
�� 
return
�� 
await
�� "
_transactionsService
�� )
.
��) *.
 AddNewCustomerTransactionDetails
��* J
(
��J K
values
��K Q
)
��Q R
;
��R S
}
�� 
[
�� 
HttpPost
�� 
(
�� 
$str
�� #
)
��# $
]
��$ %
public
�� 

async
�� 
Task
�� 
<
��  
GenericResponseDto
�� )
>
��) *!
AddCustomerInvoices
��+ >
(
��> ? 
CustomerInvoiceDto
��? Q
values
��R X
)
��X Y
{
�� 
return
�� 
await
�� 
_invoiceService
�� $
.
��$ %'
AddCustomerInvoiceDetails
��% >
(
��> ?
values
��? E
)
��E F
;
��F G
}
�� 
[
�� 
HttpPost
�� 
(
�� 
$str
�� #
)
��# $
]
��$ %
public
�� 

async
�� 
Task
�� 
<
��  
GenericResponseDto
�� (
>
��( )!
AddCustomerPayments
��* =
(
��= >!
CustomerPaymentsDto
��> Q
values
��R X
)
��X Y
{
�� 
return
�� 
await
�� 
_paymentsService
�� %
.
��% &*
AddNewCustomerPaymentDetails
��& B
(
��B C
values
��C I
)
��I J
;
��J K
}
�� 
}�� �#
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Presentation/Controllers/v1/FileManagerController.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Presntation '
.' (
Controllers( 3
.3 4
v14 6
;6 7
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[		 
Route		 
(		 
$str		 /
)		/ 0
]		0 1
[

 
Produces

 	
(

	 

$str


 
)

 
]

 
public 
class !
FileManagerController "
:# $
ControllerBase% 3
{ 
private 
readonly 
IAzureBlobService &
_blobService' 3
;3 4
public 
!
FileManagerController  
(  !
IAzureBlobService! 2
blobService3 >
)> ?
{ 
_blobService 
= 
blobService "
;" #
} 
[ 
HttpPost 
] 
[ 
Route 

(
 
$str  
)  !
]! "
public 

async 
Task 
< 
IActionResult #
># $
UploadFileDocuments% 8
(8 9
	IFormFile9 B
filesC H
)H I
{ 
try 
{ 	
if 
( 
files 
== 
null 
) 
return 

BadRequest !
(! "
)" #
;# $
var!! 
result!! 
=!! 
await!! 
_blobService!! +
.!!+ ,
UploadFileBlobAsync!!, ?
(!!? @
$str!!@ Y
,!!Y Z
files!![ `
.!!` a
OpenReadStream!!a o
(!!o p
)!!p q
,!!q r
files!!s x
.!!x y
ContentType	!!y �
,
!!� �
files
!!� �
.
!!� �
FileName
!!� �
)
!!� �
;
!!� �
var"" 
toReturn"" 
="" 
result"" !
.""! "
AbsoluteUri""" -
;""- .
return&& 
Ok&& 
(&& 
new&& 
{&& 
path&&  
=&&! "
toReturn&&# +
}&&, -
)&&- .
;&&. /
}'' 	
catch(( 
((( 
	Exception(( 
ex(( 
)(( 
{)) 	
return** 

BadRequest** 
(** 
new** !
{**" #
error**$ )
=*** +
ex**, .
.**. /
ToString**/ 7
(**7 8
)**8 9
}**: ;
)**; <
;**< =
}++ 	
},, 
[.. 

HttpDelete.. 
].. 
[// 
Route// 

(//
 
$str// (
)//( )
]//) *
public00 

async00 
Task00 
<00 
IActionResult00 #
>00# $
DeleteUploadFile00% 5
(005 6
string006 <
filename00= E
)00E F
{11 
try22 
{33 	
if44 
(44 
string44 
.44 
IsNullOrWhiteSpace44 )
(44) *
filename44* 2
)442 3
==444 6
true447 ;
)44; <
return55 

BadRequest55 !
(55! "
)55" #
;55# $
var77 
result77 
=77 
await77 
_blobService77 +
.77+ ,
DeleteFileBlobAsync77, ?
(77? @
$str77@ Y
,77Y Z
filename77[ c
)77c d
;77d e
return99 
Ok99 
(99 
new99 
{99 
Response99 $
=99% &
result99' -
}99. /
)99/ 0
;990 1
}:: 	
catch;; 
(;; 
	Exception;; 
ex;; 
);; 
{<< 	
return== 

BadRequest== 
(== 
new== !
{==" #
error==$ )
===* +
ex==, .
.==. /
ToString==/ 7
(==7 8
)==8 9
}==: ;
)==; <
;==< =
}>> 	
}?? 
}AA 