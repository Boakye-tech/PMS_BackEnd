j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Usings.cs⁄l
i/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB `
)` a
;a b
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
if 
( 
builder 
. 
Environment 
. 
IsProduction $
($ %
)% &
)& '
{   
var!! 
currentDirectory!! 
=!! 
	Directory!! $
.!!$ %
GetCurrentDirectory!!% 8
(!!8 9
)!!9 :
;!!: ;
var"" 
solutionDirectory"" 
="" 
	Directory"" %
.""% &
	GetParent""& /
(""/ 0
currentDirectory""0 @
)""@ A
?""A B
.""B C
Parent""C I
?""I J
.""J K
FullName""K S
??""T V
$str""W Y
;""Y Z
var## #
solutionLevelConfigPath## 
=##  !
Path##" &
.##& '
Combine##' .
(##. /
solutionDirectory##/ @
,##@ A
$str##B T
)##T U
;##U V
if%% 
(%% 
File%% 
.%% 
Exists%% 
(%% #
solutionLevelConfigPath%% +
)%%+ ,
)%%, -
{&& 
builder'' 
.'' 
Configuration'' 
.'' 
AddJsonFile'' )
('') *#
solutionLevelConfigPath''* A
,''A B
optional''C K
:''K L
false''M R
,''R S
reloadOnChange''T b
:''b c
true''d h
)''h i
;''i j
}(( 
})) 
builder,, 
.,, 
Host,, 
.,, 

UseSerilog,, 
(,, 
(,, 
context,,  
,,,  !
configuration,," /
),,/ 0
=>,,1 3
configuration,,4 A
.,,A B
ReadFrom,,B J
.,,J K
Configuration,,K X
(,,X Y
context,,Y `
.,,` a
Configuration,,a n
),,n o
),,o p
;,,p q
if00 
(00 
builder00 
.00 
Environment00 
.00 
IsDevelopment00 %
(00% &
)00& '
)00' (
{11 
switch22 

(22 
builder22 
.22 
Configuration22 !
.22! "

GetSection22" ,
(22, -
$str22- 7
)227 8
.228 9

GetSection229 C
(22C D
$str22D V
)22V W
.22W X
Value22X ]
)22] ^
{33 
case44 
$str44 
:44 
break66 
;66 
case77 
$str77 
:77 
builder88 
.88 
Services88 
.88 
AddDbContext88 )
<88) * 
ApplicationDbContext88* >
>88> ?
(88? @
options88@ G
=>88H J
options88K R
.88R S
UseSqlServer88S _
(88_ `
builder88` g
.88g h
Configuration88h u
.88u v 
GetConnectionString	88v â
(
88â ä
$str
88ä õ
)
88õ ú
)
88ú ù
)
88ù û
;
88û ü
break99 
;99 
}:: 
}<< 
if>> 
(>> 
builder>> 
.>> 
Environment>> 
.>> 
IsProduction>> $
(>>$ %
)>>% &
)>>& '
{?? 
switch@@ 

(@@ 
builder@@ 
.@@ 
Configuration@@ !
.@@! "

GetSection@@" ,
(@@, -
$str@@- 7
)@@7 8
.@@8 9

GetSection@@9 C
(@@C D
$str@@D V
)@@V W
.@@W X
Value@@X ]
)@@] ^
{AA 
caseBB 
$strBB 
:BB 
breakDD 
;DD 
caseEE 
$strEE 
:EE 
builderFF 
.FF 
ServicesFF 
.FF 
AddDbContextFF )
<FF) * 
ApplicationDbContextFF* >
>FF> ?
(FF? @
optionsFF@ G
=>FFH J
optionsFFK R
.FFR S
UseSqlServerFFS _
(FF_ `
builderFF` g
.FFg h
ConfigurationFFh u
.FFu v 
GetConnectionString	FFv â
(
FFâ ä
$str
FFä õ
)
FFõ ú
)
FFú ù
)
FFù û
;
FFû ü
breakGG 
;GG 
}HH 
}II 
builderKK 
.KK 
ServicesKK 
.KK 
AddCorsKK 
(KK 
oKK 
=>KK 
{LL 
oMM 
.MM 
AddDefaultPolicyMM 
(MM 
builderNN 
=>NN 
{OO 	
builderPP 
.PP 
AllowAnyOriginPP "
(PP" #
)PP# $
.QQ 
AllowAnyHeaderQQ "
(QQ" #
)QQ# $
.RR 
AllowAnyMethodRR "
(RR" #
)RR# $
;RR$ %
}TT 	
)TT	 

;TT
 
}UU 
)UU 
;UU 
builderww 
.ww 
Servicesww 
.ww 
AddEstateModuleww  
(ww  !
builderww! (
.ww( )
Configurationww) 6
)ww6 7
;ww7 8
builderxx 
.xx 
Servicesxx 
.xx 
AddControllersxx 
(xx  
)xx  !
;xx! "
builderzz 
.zz 
Serviceszz 
.{{ 
AddApiVersioning{{ 
({{ 
options{{ 
=>{{  
{|| 
options}} 
.}} 
DefaultApiVersion}} !
=}}" #
new}}$ '

ApiVersion}}( 2
(}}2 3
$num}}3 4
,}}4 5
$num}}6 7
)}}7 8
;}}8 9
options~~ 
.~~ /
#AssumeDefaultVersionWhenUnspecified~~ 3
=~~4 5
true~~6 :
;~~: ;
options 
. 
ReportApiVersions !
=" #
true$ (
;( )
}
ÄÄ 
)
ÄÄ 
.
ÅÅ 
AddApiExplorer
ÅÅ 
(
ÅÅ 
options
ÅÅ 
=>
ÅÅ 
{
ÇÇ 
options
ÉÉ 
.
ÉÉ 
GroupNameFormat
ÉÉ 
=
ÉÉ  !
$str
ÉÉ" *
;
ÉÉ* +
options
ÑÑ 
.
ÑÑ '
SubstituteApiVersionInUrl
ÑÑ )
=
ÑÑ* +
true
ÑÑ, 0
;
ÑÑ0 1
}
ÖÖ 
)
ÖÖ 
;
ÖÖ 
builderàà 
.
àà 
Services
àà 
.
àà %
AddEndpointsApiExplorer
àà (
(
àà( )
)
àà) *
;
àà* +
builderââ 
.
ââ 
Services
ââ 
.
ââ 
AddTransient
ââ 
<
ââ 
IConfigureOptions
ââ /
<
ââ/ 0
SwaggerGenOptions
ââ0 A
>
ââA B
,
ââB C%
SwaggerConfigureOptions
ââD [
>
ââ[ \
(
ââ\ ]
)
ââ] ^
;
ââ^ _
builderää 
.
ää 
Services
ää 
.
ää 
AddSwaggerGen
ää 
(
ää 
options
ää &
=>
ää' )
{ãã 
options
åå 
.
åå 
OperationFilter
åå 
<
åå "
SwaggerDefaultValues
åå 0
>
åå0 1
(
åå1 2
)
åå2 3
;
åå3 4
options
çç 
.
çç  
IncludeXmlComments
çç 
(
çç 
Path
çç #
.
çç# $
Combine
çç$ +
(
çç+ ,

AppContext
çç, 6
.
çç6 7
BaseDirectory
çç7 D
,
ççD E
$"
ççF H
{
ççH I
Assembly
ççI Q
.
ççQ R"
GetExecutingAssembly
ççR f
(
ççf g
)
ççg h
.
ççh i
GetName
ççi p
(
ççp q
)
ççq r
.
ççr s
Name
ççs w
}
ççw x
$str
ççx |
"
çç| }
)
çç} ~
)
çç~ 
;çç Ä
}èè 
)
èè 
;
èè 
builderìì 
.
ìì 
Services
ìì 
.
ìì !
AddExceptionHandler
ìì $
<
ìì$ %'
HttpGlobalExceptionFilter
ìì% >
>
ìì> ?
(
ìì? @
)
ìì@ A
;
ììA B
builderîî 
.
îî 
Services
îî 
.
îî 
AddProblemDetails
îî "
(
îî" #
)
îî# $
;
îî$ %
varóó 
app
óó 
=
óó 	
builder
óó
 
.
óó 
Build
óó 
(
óó 
)
óó 
;
óó 
iföö 
(
öö 
app
öö 
.
öö 
Environment
öö 
.
öö 
IsDevelopment
öö !
(
öö! "
)
öö" #
)
öö# $
{õõ 
app
ûû 
.
ûû 

UseSwagger
ûû 
(
ûû 
options
ûû 
=>
ûû 
{
üü 
options
†† 
.
†† !
PreSerializeFilters
†† #
.
††# $
Add
††$ '
(
††' (
(
††( )
swagger
††) 0
,
††0 1
req
††2 5
)
††5 6
=>
††7 9
{
°° 	
swagger
¢¢ 
.
¢¢ 
Servers
¢¢ 
=
¢¢ 
new
¢¢ !
List
¢¢" &
<
¢¢& '
OpenApiServer
¢¢' 4
>
¢¢4 5
(
¢¢5 6
)
¢¢6 7
{
¢¢8 9
new
¢¢: =
OpenApiServer
¢¢> K
(
¢¢K L
)
¢¢L M
{
¢¢N O
Url
¢¢P S
=
¢¢T U
$"
¢¢V X
$str
¢¢X `
{
¢¢` a
req
¢¢a d
.
¢¢d e
Host
¢¢e i
}
¢¢i j
"
¢¢j k
}
¢¢l m
}
¢¢n o
;
¢¢o p
}
££ 	
)
££	 

;
££
 
}
§§ 
)
§§ 
;
§§ 
app
ßß 
.
ßß 
UseSwaggerUI
ßß 
(
ßß 
options
ßß 
=>
ßß 
{
®® 
var
©© $
ApiVersionDescriptions
©© "
=
©©# $
app
©©% (
.
©©( )!
DescribeApiVersions
©©) <
(
©©< =
)
©©= >
;
©©> ?
foreach
´´ 
(
´´ 
var
´´ 
desc
´´ 
in
´´ $
ApiVersionDescriptions
´´ 3
)
´´3 4
{
¨¨ 	
options
≠≠ 
.
≠≠ 
SwaggerEndpoint
≠≠ #
(
≠≠# $
$"
≠≠$ &
$str
≠≠& 1
{
≠≠1 2
desc
≠≠2 6
.
≠≠6 7
	GroupName
≠≠7 @
}
≠≠@ A
$str
≠≠A N
"
≠≠N O
,
≠≠O P
$"
≠≠Q S
$str
≠≠S d
{
≠≠d e
desc
≠≠e i
.
≠≠i j

ApiVersion
≠≠j t
.
≠≠t u
ToString
≠≠u }
(
≠≠} ~
)
≠≠~ 
}≠≠ Ä
"≠≠Ä Å
)≠≠Å Ç
;≠≠Ç É
options
ÆÆ 
.
ÆÆ &
DefaultModelsExpandDepth
ÆÆ ,
(
ÆÆ, -
-
ÆÆ- .
$num
ÆÆ. /
)
ÆÆ/ 0
;
ÆÆ0 1
options
ØØ 
.
ØØ 
DocExpansion
ØØ  
(
ØØ  !
Swashbuckle
ØØ! ,
.
ØØ, -

AspNetCore
ØØ- 7
.
ØØ7 8
	SwaggerUI
ØØ8 A
.
ØØA B
DocExpansion
ØØB N
.
ØØN O
None
ØØO S
)
ØØS T
;
ØØT U
}
∞∞ 	
}
±± 
)
±± 
;
±± 
}≤≤ 
app¥¥ 
.
¥¥ !
UseHttpsRedirection
¥¥ 
(
¥¥ 
)
¥¥ 
;
¥¥ 
app∂∂ 
.
∂∂ 
UseAuthentication
∂∂ 
(
∂∂ 
)
∂∂ 
;
∂∂ 
app∑∑ 
.
∑∑ 
UseAuthorization
∑∑ 
(
∑∑ 
)
∑∑ 
;
∑∑ 
app∏∏ 
.
∏∏ 
UseCors
∏∏ 
(
∏∏ 
)
∏∏ 
;
∏∏ 
app∫∫ 
.
∫∫ 
MapControllers
∫∫ 
(
∫∫ 
)
∫∫ 
;
∫∫ 
appºº 
.
ºº 
Run
ºº 
(
ºº 
)
ºº 	
;
ºº	 
€%
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
Estates 
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
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
Estates		 
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
}22 ∂I
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/ModuleExtensions.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
;& '
public

 
static

 
class

 
ModuleExtensions

 $
{ 
public 

static 
IServiceCollection $
AddEstateModule% 4
(4 5
this5 9
IServiceCollection: L
servicesM U
,U V
IConfigurationW e
configurationf s
)s t
{ 
services 
. #
AddEstateInfrastructure $
($ %
configuration% 2
)2 3
;3 4
services 
. 
	AddScoped 
< 
IUnitOfWork &
,& '

UnitOfWork( 2
>2 3
(3 4
)4 5
;5 6
services 
. 
	AddScoped 
< "
IAllocationTypeService 1
,1 2!
AllocationTypeService3 H
>H I
(I J
)J K
;K L
services 
. 
	AddScoped 
< !
IApartmentTypeService 0
,0 1 
ApartmentTypeService2 F
>F G
(G H
)H I
;I J
services 
. 
	AddScoped 
< 
IBlockNumberService .
,. /
BlockNumberService0 B
>B C
(C D
)D E
;E F
services 
. 
	AddScoped 
< 
IBlockSideService ,
,, -
BlockSideService. >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< 
IBlockTypeService ,
,, -
BlockTypeService. >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< 
IBlockUnitService ,
,, -
BlockUnitService. >
>> ?
(? @
)@ A
;A B
services 
. 
	AddScoped 
< 
IFacilitiesService -
,- .
FacilitiesService/ @
>@ A
(A B
)B C
;C D
services 
. 
	AddScoped 
< "
IFloorNumberingService 1
,1 2!
FloorNumberingService3 H
>H I
(I J
)J K
;K L
services 
. 
	AddScoped 
< 
ILandUseService *
,* +
LandUseService, :
>: ;
(; <
)< =
;= >
services 
. 
	AddScoped 
< 
ILandUseTypeService .
,. /
LandUseTypeService0 B
>B C
(C D
)D E
;E F
services 
. 
	AddScoped 
< 
ILocalityService +
,+ ,
LocalityService- <
>< =
(= >
)> ?
;? @
services 
. 
	AddScoped 
< 
IPlotSizeService +
,+ ,
PlotSizeService- <
>< =
(= >
)> ?
;? @
services   
.   
	AddScoped   
<   "
IPropertyHeightService   1
,  1 2!
PropertyHeightService  3 H
>  H I
(  I J
)  J K
;  K L
services!! 
.!! 
	AddScoped!! 
<!!  
IPropertyTypeService!! /
,!!/ 0
PropertyTypeService!!1 D
>!!D E
(!!E F
)!!F G
;!!G H
services## 
.## 
	AddScoped## 
<## 
IActivityService## +
,##+ ,
ActivityService##- <
>##< =
(##= >
)##> ?
;##? @
services$$ 
.$$ 
	AddScoped$$ 
<$$  
IActivityTypeService$$ /
,$$/ 0
ActivityTypeService$$1 D
>$$D E
($$E F
)$$F G
;$$G H
services&& 
.&& 
	AddScoped&& 
<&& "
IPropertyMasterService&& 1
,&&1 2!
PropertyMasterService&&3 H
>&&H I
(&&I J
)&&J K
;&&K L
services'' 
.'' 
	AddScoped'' 
<'' "
ICustomerDomainService'' 1
,''1 2!
CustomerDomainService''3 H
>''H I
(''I J
)''J K
;''K L
services)) 
.)) 
	AddScoped)) 
<))  
ICustomerTypeService)) /
,))/ 0
CustomerTypeService))1 D
>))D E
())E F
)))F G
;))G H
services** 
.** 
	AddScoped** 
<** 
IGenderService** )
,**) *
GenderService**+ 8
>**8 9
(**9 :
)**: ;
;**; <
services++ 
.++ 
	AddScoped++ 
<++ &
IIdentificationTypeService++ 5
,++5 6%
IdentificationTypeService++7 P
>++P Q
(++Q R
)++R S
;++S T
services,, 
.,, 
	AddScoped,, 
<,, 
INationalityService,, .
,,,. /
NationalityService,,0 B
>,,B C
(,,C D
),,D E
;,,E F
services-- 
.-- 
	AddScoped-- 
<--  
IResidentTypeService-- /
,--/ 0
ResidentTypeService--1 D
>--D E
(--E F
)--F G
;--G H
services.. 
... 
	AddScoped.. 
<.. 
ISocialMediaService.. .
,... /
SocialMediaService..0 B
>..B C
(..C D
)..D E
;..E F
services// 
.// 
	AddScoped// 
<// 
ITitleService// (
,//( )
TitleService//* 6
>//6 7
(//7 8
)//8 9
;//9 :
services00 
.00 
	AddScoped00 
<00 !
IOwnershipTypeService00 0
,000 1 
OwnershipTypeService002 F
>00F G
(00G H
)00H I
;00I J
services22 
.22 
	AddScoped22 
<22 "
ICustomerMasterService22 1
,221 2!
CustomerMasterService223 H
>22H I
(22I J
)22J K
;22K L
services44 
.44 
	AddScoped44 
<44 "
IDomainEventDispatcher44 1
,441 2!
DomainEventDispatcher443 H
>44H I
(44I J
)44J K
;44K L
services66 
.66 
AddHttpClient66 
<66 &
IIdentificationTypeService66 9
,669 :%
IdentificationTypeService66; T
>66T U
(66U V
)66V W
;66W X
services77 
.77 
AddHttpClient77 
<77 (
IModuleCommunicationServices77 ;
,77; <'
ModuleCommunicationServices77= X
>77X Y
(77Y Z
)77Z [
;77[ \
services:: 
.:: /
#AddValidatorsFromAssemblyContaining:: 4
<::4 5$
CustomerTypeDtoValidator::5 M
>::M N
(::N O
)::O P
;::P Q
services;; 
.;; /
#AddValidatorsFromAssemblyContaining;; 4
<;;4 5
GenderDtoValidator;;5 G
>;;G H
(;;H I
);;I J
;;;J K
services<< 
.<< /
#AddValidatorsFromAssemblyContaining<< 4
<<<4 5*
IdentificationTypeDtoValidator<<5 S
><<S T
(<<T U
)<<U V
;<<V W
services== 
.== /
#AddValidatorsFromAssemblyContaining== 4
<==4 5#
NationalityDtoValidator==5 L
>==L M
(==M N
)==N O
;==O P
services>> 
.>> /
#AddValidatorsFromAssemblyContaining>> 4
<>>4 5%
OwnershipTypeDtoValidator>>5 N
>>>N O
(>>O P
)>>P Q
;>>Q R
services?? 
.?? /
#AddValidatorsFromAssemblyContaining?? 4
<??4 5$
ResidentTypeDtoValidator??5 M
>??M N
(??N O
)??O P
;??P Q
services@@ 
.@@ /
#AddValidatorsFromAssemblyContaining@@ 4
<@@4 5#
SocialMediaDtoValidator@@5 L
>@@L M
(@@M N
)@@N O
;@@O P
servicesAA 
.AA /
#AddValidatorsFromAssemblyContainingAA 4
<AA4 5
TitleDtoValidatorAA5 F
>AAF G
(AAG H
)AAH I
;AAI J
servicesEE 
.EE 
AddAutoMapperEE 
(EE 
	AppDomainEE (
.EE( )
CurrentDomainEE) 6
.EE6 7
GetAssembliesEE7 D
(EED E
)EEE F
)EEF G
;EEG H
returnHH 
servicesHH 
;HH 
}II 
}JJ œ
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Filters/HttpGlobalExceptionFilter.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Filters' .
;. /
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
cancellationToken	p Å
)
Å Ç
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
}"" ⁄í
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/PropertyController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v23 5
;5 6
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class 
PropertyController 
:  !
ControllerBase" 0
{ 
public 

readonly "
IAllocationTypeService *"
_allocationTypeService+ A
;A B
public 

readonly !
IApartmentTypeService )!
_apartmentTypeService* ?
;? @
readonly 
IBlockNumberService  
_blockNumberService! 4
;4 5
readonly 
IBlockSideService 
_blockSideService 0
;0 1
readonly 
IBlockTypeService 
_blockTypeService 0
;0 1
readonly 
IBlockUnitService 
_blockUnitService 0
;0 1
readonly 
IFacilitiesService 
_facilitiesService  2
;2 3
readonly "
IFloorNumberingService #"
_floorNumberingService$ :
;: ;
readonly 
ILandUseService 
_landUseService ,
;, -
readonly   
ILandUseTypeService    
_landUseTypeService  ! 4
;  4 5
readonly!! 
ILocalityService!! 
_localityService!! .
;!!. /
readonly"" 
IPlotSizeService"" 
_plotSizeService"" .
;"". /
readonly## "
IPropertyHeightService## #"
_propertyHeightService##$ :
;##: ;
readonly$$  
IPropertyTypeService$$ ! 
_propertyTypeService$$" 6
;$$6 7
readonly&& 
IActivityService&& 
_activityService&& .
;&&. /
readonly''  
IActivityTypeService'' ! 
_activityTypeService''" 6
;''6 7
readonly)) "
IPropertyMasterService)) #"
_propertyMasterService))$ :
;)): ;
public-- 

PropertyController-- 
(-- "
IAllocationTypeService-- 4!
allocationTypeService--5 J
,--J K
ILandUseService--L [
landUseService--\ j
,--j k
ILandUseTypeService--l  
landUseTypeService
--Ä í
,
--í ì
ILocalityService
--î §
localityService
--• ¥
,
--¥ µ
IPlotSizeService
--∂ ∆
plotSizeService
--« ÷
,
--÷ ◊!
IApartmentTypeService.. 3 
apartmentTypeService..4 H
,..H I
IFacilitiesService..J \
facilitiesService..] n
,..n o#
IFloorNumberingService	..p Ü#
floorNumberingService
..á ú
,
..ú ù"
IPropertyTypeService
..û ≤!
propertyTypeService
..≥ ∆
,
..∆ «$
IPropertyHeightService
..» ﬁ#
propertyHeightService
..ﬂ Ù
,
..Ù ı
IBlockNumberService// 1
blockNumberService//2 D
,//D E
IBlockSideService//F W
blockSideService//X h
,//h i
IBlockTypeService//j {
blockTypeService	//| å
,
//å ç
IBlockUnitService
//é ü
blockUnitService
//† ∞
,
//∞ ±
IActivityService00 .
activityService00/ >
,00> ? 
IActivityTypeService00@ T
activityTypeService00U h
,00h i#
IPropertyMasterService	00j Ä#
propertyMasterService
00Å ñ
)
00ñ ó
{11 "
_allocationTypeService22 
=22  !
allocationTypeService22! 6
;226 7!
_apartmentTypeService33 
=33  
apartmentTypeService33  4
;334 5
_blockNumberService55 
=55 
blockNumberService55 0
;550 1
_blockSideService66 
=66 
blockSideService66 ,
;66, -
_blockTypeService77 
=77 
blockTypeService77 ,
;77, -
_blockUnitService88 
=88 
blockUnitService88 ,
;88, -
_facilitiesService:: 
=:: 
facilitiesService:: .
;::. /"
_floorNumberingService;; 
=;;  !
floorNumberingService;;! 6
;;;6 7
_landUseService<< 
=<< 
landUseService<< (
;<<( )
_landUseTypeService== 
=== 
landUseTypeService== 0
;==0 1
_localityService>> 
=>> 
localityService>> *
;>>* +
_plotSizeService?? 
=?? 
plotSizeService?? *
;??* +"
_propertyHeightService@@ 
=@@  !
propertyHeightService@@! 6
;@@6 7 
_propertyTypeServiceAA 
=AA 
propertyTypeServiceAA 2
;AA2 3
_activityServiceCC 
=CC 
activityServiceCC *
;CC* + 
_activityTypeServiceDD 
=DD 
activityTypeServiceDD 2
;DD2 3"
_propertyMasterServiceFF 
=FF  !
propertyMasterServiceFF! 6
;FF6 7
}GG 
[MM 
HttpGetMM 
]MM 
[NN 
RouteNN 

(NN
 
$strNN  
)NN  !
]NN! "
publicOO 

asyncOO 
TaskOO 
<OO 
ActionResultOO "
<OO" #
IEnumerableOO# .
<OO. /
ActivityReadDtoOO/ >
>OO> ?
>OO? @
>OO@ A
GetActivitiesOOB O
(OOO P
)OOP Q
{PP 
returnQQ 
OkQQ 
(QQ 
awaitQQ 
_activityServiceQQ (
.QQ( )
GetActivitiesAsyncQQ) ;
(QQ; <
)QQ< =
)QQ= >
;QQ> ?
}RR 
[jj 
HttpPostjj 
]jj 
[kk 
Routekk 

(kk
 
$strkk 
)kk 
]kk 
publicll 

asyncll 
Taskll 
<ll 
ActionResultll "
<ll" #
ActivityReadDtoll# 2
>ll2 3
>ll3 4
CreateActivityll5 C
(llC D
[llD E
FromBodyllE M
]llM N
ActivityCreateDtollO `
valueslla g
)llg h
{mm 
trynn 
{oo 	
returnpp 
Okpp 
(pp 
awaitpp 
_activityServicepp ,
.pp, -
CreateActivityAsyncpp- @
(pp@ A
valuesppA G
)ppG H
)ppH I
;ppI J
}qq 	
catchrr 
(rr 
	Exceptionrr 
exrr 
)rr 
{ss 	
returntt 

StatusCodett 
(tt 
$numtt !
,tt! "
extt# %
.tt% &
InnerExceptiontt& 4
!tt4 5
.tt5 6
Messagett6 =
)tt= >
;tt> ?
}uu 	
}vv 
[|| 
HttpPut|| 
]|| 
[}} 
Route}} 

(}}
 
$str}} 
)}} 
]}} 
public~~ 

async~~ 
Task~~ 
<~~ 
ActionResult~~ "
<~~" #
ActivityReadDto~~# 2
>~~2 3
>~~3 4
UpdateActivity~~5 C
(~~C D
[~~D E
FromBody~~E M
]~~M N
ActivityUpdateDto~~O `
values~~a g
)~~g h
{ 
return
ÄÄ 
Ok
ÄÄ 
(
ÄÄ 
await
ÄÄ 
_activityService
ÄÄ (
.
ÄÄ( )!
UpdateActivityAsync
ÄÄ) <
(
ÄÄ< =
values
ÄÄ= C
)
ÄÄC D
)
ÄÄD E
;
ÄÄE F
}
ÅÅ 
[
ÉÉ 

HttpDelete
ÉÉ 
(
ÉÉ 
$str
ÉÉ -
)
ÉÉ- .
]
ÉÉ. /
public
ÑÑ 

void
ÑÑ 
DeleteActivity
ÑÑ 
(
ÑÑ 
int
ÑÑ "

activityId
ÑÑ# -
)
ÑÑ- .
{
ÖÖ 
}
ÜÜ 
[
åå 
HttpGet
åå 
]
åå 
[
çç 
Route
çç 

(
çç
 
$str
çç #
)
çç# $
]
çç$ %
public
éé 

async
éé 
Task
éé 
<
éé 
ActionResult
éé "
<
éé" #
IEnumerable
éé# .
<
éé. /!
ActivityTypeReadDto
éé/ B
>
ééB C
>
ééC D
>
ééD E
GetActivityTypes
ééF V
(
ééV W
)
ééW X
{
èè 
return
êê 
Ok
êê 
(
êê 
await
êê "
_activityTypeService
êê ,
.
êê, -"
GetActivityTypeAsync
êê- A
(
êêA B
)
êêB C
)
êêC D
;
êêD E
}
ëë 
[
™™ 
HttpPost
™™ 
]
™™ 
[
´´ 
Route
´´ 

(
´´
 
$str
´´ 
)
´´  
]
´´  !
public
¨¨ 

async
¨¨ 
Task
¨¨ 
<
¨¨ 
ActionResult
¨¨ "
<
¨¨" #!
ActivityTypeReadDto
¨¨# 6
>
¨¨6 7
>
¨¨7 8 
CreateActivityType
¨¨9 K
(
¨¨K L
[
¨¨L M
FromBody
¨¨M U
]
¨¨U V#
ActivityTypeCreateDto
¨¨W l
values
¨¨m s
)
¨¨s t
{
≠≠ 
try
ÆÆ 
{
ØØ 	
return
∞∞ 
Ok
∞∞ 
(
∞∞ 
await
∞∞ "
_activityTypeService
∞∞ 0
.
∞∞0 1%
CreateActivityTypeAsync
∞∞1 H
(
∞∞H I
values
∞∞I O
)
∞∞O P
)
∞∞P Q
;
∞∞Q R
}
±± 	
catch
≤≤ 
(
≤≤ 
	Exception
≤≤ 
ex
≤≤ 
)
≤≤ 
{
≥≥ 	
return
¥¥ 

StatusCode
¥¥ 
(
¥¥ 
$num
¥¥ !
,
¥¥! "
ex
¥¥# %
.
¥¥% &
InnerException
¥¥& 4
!
¥¥4 5
.
¥¥5 6
Message
¥¥6 =
)
¥¥= >
;
¥¥> ?
}
µµ 	
}
∂∂ 
[
ºº 
HttpPut
ºº 
]
ºº 
[
ΩΩ 
Route
ΩΩ 

(
ΩΩ
 
$str
ΩΩ 
)
ΩΩ  
]
ΩΩ  !
public
ææ 

async
ææ 
Task
ææ 
<
ææ 
ActionResult
ææ "
<
ææ" #!
ActivityTypeReadDto
ææ# 6
>
ææ6 7
>
ææ7 8 
UpdateActivityType
ææ9 K
(
ææK L
[
ææL M
FromBody
ææM U
]
ææU V#
ActivityTypeUpdateDto
ææW l
values
ææm s
)
ææs t
{
øø 
return
¿¿ 
Ok
¿¿ 
(
¿¿ 
await
¿¿ "
_activityTypeService
¿¿ ,
.
¿¿, -%
UpdateActivityTypeAsync
¿¿- D
(
¿¿D E
values
¿¿E K
)
¿¿K L
)
¿¿L M
;
¿¿M N
}
¡¡ 
[
√√ 

HttpDelete
√√ 
(
√√ 
$str
√√ 5
)
√√5 6
]
√√6 7
public
ƒƒ 

void
ƒƒ  
DeleteActivityType
ƒƒ "
(
ƒƒ" #
int
ƒƒ# &
activityTypeId
ƒƒ' 5
)
ƒƒ5 6
{
≈≈ 
}
∆∆ 
[
”” 
HttpGet
”” 
]
”” 
[
‘‘ 
Route
‘‘ 

(
‘‘
 
$str
‘‘ $
)
‘‘$ %
]
‘‘% &
public
’’ 

async
’’ 
Task
’’ 
<
’’ 
ActionResult
’’ "
<
’’" #
IEnumerable
’’# .
<
’’. /#
AllocationTypeReadDto
’’/ D
>
’’D E
>
’’E F
>
’’F G
GetAllocationType
’’H Y
(
’’Y Z
)
’’Z [
{
÷÷ 
return
◊◊ 
Ok
◊◊ 
(
◊◊ 
await
◊◊ $
_allocationTypeService
◊◊ .
.
◊◊. /$
GetAllocationTypeAsync
◊◊/ E
(
◊◊E F
)
◊◊F G
)
◊◊G H
;
◊◊H I
}
ÿÿ 
[
⁄⁄ 
HttpGet
⁄⁄ 
]
⁄⁄ 
[
€€ 
Route
€€ 

(
€€
 
$str
€€ 5
)
€€5 6
]
€€6 7
public
‹‹ 

async
‹‹ 
Task
‹‹ 
<
‹‹ 
ActionResult
‹‹ "
<
‹‹" ##
AllocationTypeReadDto
‹‹# 8
>
‹‹8 9
>
‹‹9 :
GetAllocationType
‹‹; L
(
‹‹L M
string
‹‹M S
allocationType
‹‹T b
)
‹‹b c
{
›› 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ $
_allocationTypeService
ﬁﬁ .
.
ﬁﬁ. /$
GetAllocationTypeAsync
ﬁﬁ/ E
(
ﬁﬁE F
allocationType
ﬁﬁF T
)
ﬁﬁT U
)
ﬁﬁU V
;
ﬁﬁV W
}
ﬂﬂ 
[
·· 
HttpGet
·· 
]
·· 
[
‚‚ 
Route
‚‚ 

(
‚‚
 
$str
‚‚ ;
)
‚‚; <
]
‚‚< =
public
„„ 

async
„„ 
Task
„„ 
<
„„ 
ActionResult
„„ "
<
„„" ##
AllocationTypeReadDto
„„# 8
>
„„8 9
>
„„9 :#
GetAllocationTypeById
„„; P
(
„„P Q
int
„„Q T
allocationTypeId
„„U e
)
„„e f
{
‰‰ 
return
ÂÂ 
Ok
ÂÂ 
(
ÂÂ 
await
ÂÂ $
_allocationTypeService
ÂÂ .
.
ÂÂ. /$
GetAllocationTypeAsync
ÂÂ/ E
(
ÂÂE F
allocationTypeId
ÂÂF V
)
ÂÂV W
)
ÂÂW X
;
ÂÂX Y
}
ÊÊ 
[
ˇˇ 
HttpPost
ˇˇ 
]
ˇˇ 
[
ÄÄ 
Route
ÄÄ 

(
ÄÄ
 
$str
ÄÄ !
)
ÄÄ! "
]
ÄÄ" #
public
ÅÅ 

async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ "
<
ÅÅ" ##
AllocationTypeReadDto
ÅÅ# 8
>
ÅÅ8 9
>
ÅÅ9 :"
CreateAllocationType
ÅÅ; O
(
ÅÅO P
[
ÅÅP Q
FromBody
ÅÅQ Y
]
ÅÅY Z%
AllocationTypeCreateDto
ÅÅ[ r
values
ÅÅs y
)
ÅÅy z
{
ÇÇ 
try
ÉÉ 
{
ÑÑ 	
return
ÖÖ 
Ok
ÖÖ 
(
ÖÖ 
await
ÖÖ $
_allocationTypeService
ÖÖ 2
.
ÖÖ2 3$
AddAllocationTypeAsync
ÖÖ3 I
(
ÖÖI J
values
ÖÖJ P
)
ÖÖP Q
)
ÖÖQ R
;
ÖÖR S
}
ÜÜ 	
catch
áá 
(
áá 
	Exception
áá 
ex
áá 
)
áá 
{
àà 	
return
ââ 

StatusCode
ââ 
(
ââ 
$num
ââ !
,
ââ! "
new
ââ# &
{
ââ' (
detail
ââ) /
=
ââ0 1
ex
ââ2 4
.
ââ4 5
Message
ââ5 <
}
ââ= >
)
ââ> ?
;
ââ? @
}
ää 	
}
ãã 
[
ëë 
HttpPut
ëë 
]
ëë 
[
íí 
Route
íí 

(
íí
 
$str
íí !
)
íí! "
]
íí" #
public
ìì 

async
ìì 
Task
ìì 
<
ìì 
ActionResult
ìì "
<
ìì" ##
AllocationTypeReadDto
ìì# 8
>
ìì8 9
>
ìì9 :"
UpdateAllocationType
ìì; O
(
ììO P
[
ììP Q
FromBody
ììQ Y
]
ììY Z%
AllocationTypeUpdateDto
ìì[ r
values
ììs y
)
ììy z
{
îî 
return
ïï 
Ok
ïï 
(
ïï 
await
ïï $
_allocationTypeService
ïï .
.
ïï. /'
UpdateAllocationTypeAsync
ïï/ H
(
ïïH I
values
ïïI O
)
ïïO P
)
ïïP Q
;
ïïQ R
}
ññ 
[
òò 

HttpDelete
òò 
(
òò 
$str
òò 9
)
òò9 :
]
òò: ;
public
ôô 

void
ôô "
DeleteAllocationType
ôô $
(
ôô$ %
int
ôô% (
allocationTypeId
ôô) 9
)
ôô9 :
{
öö 
}
õõ 
[
°° 
HttpGet
°° 
]
°° 
[
¢¢ 
Route
¢¢ 

(
¢¢
 
$str
¢¢ #
)
¢¢# $
]
¢¢$ %
public
££ 

async
££ 
Task
££ 
<
££ 
ActionResult
££ "
<
££" #
IEnumerable
££# .
<
££. /"
ApartmentTypeReadDto
££/ C
>
££C D
>
££D E
>
££E F
GetApartmentType
££G W
(
££W X
)
££X Y
{
§§ 
return
•• 
Ok
•• 
(
•• 
await
•• #
_apartmentTypeService
•• -
.
••- .#
GetApartmentTypeAsync
••. C
(
••C D
)
••D E
)
••E F
;
••F G
}
¶¶ 
[
®® 
HttpGet
®® 
]
®® 
[
©© 
Route
©© 

(
©©
 
$str
©© 3
)
©©3 4
]
©©4 5
public
™™ 

async
™™ 
Task
™™ 
<
™™ 
ActionResult
™™ "
<
™™" ##
AllocationTypeReadDto
™™# 8
>
™™8 9
>
™™9 :
GetApartmentType
™™; K
(
™™K L
string
™™L R
apartmentType
™™S `
)
™™` a
{
´´ 
return
¨¨ 
Ok
¨¨ 
(
¨¨ 
await
¨¨ #
_apartmentTypeService
¨¨ -
.
¨¨- .#
GetApartmentTypeAsync
¨¨. C
(
¨¨C D
apartmentType
¨¨D Q
)
¨¨Q R
)
¨¨R S
;
¨¨S T
}
≠≠ 
[
ØØ 
HttpGet
ØØ 
]
ØØ 
[
∞∞ 
Route
∞∞ 

(
∞∞
 
$str
∞∞ 9
)
∞∞9 :
]
∞∞: ;
public
±± 

async
±± 
Task
±± 
<
±± 
ActionResult
±± "
<
±±" ##
AllocationTypeReadDto
±±# 8
>
±±8 9
>
±±9 :"
GetApartmentTypeById
±±; O
(
±±O P
int
±±P S
apartmentTypeId
±±T c
)
±±c d
{
≤≤ 
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ #
_apartmentTypeService
≥≥ -
.
≥≥- .#
GetApartmentTypeAsync
≥≥. C
(
≥≥C D
apartmentTypeId
≥≥D S
)
≥≥S T
)
≥≥T U
;
≥≥U V
}
¥¥ 
[
ŒŒ 
HttpPost
ŒŒ 
]
ŒŒ 
[
œœ 
Route
œœ 

(
œœ
 
$str
œœ  
)
œœ  !
]
œœ! "
public
–– 

async
–– 
Task
–– 
<
–– 
ActionResult
–– "
<
––" #"
ApartmentTypeReadDto
––# 7
>
––7 8
>
––8 9
AddApartmentType
––: J
(
––J K
[
––K L
FromBody
––L T
]
––T U$
ApartmentTypeCreateDto
––V l
values
––m s
)
––s t
{
—— 
try
““ 
{
”” 	
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ #
_apartmentTypeService
‘‘ 1
.
‘‘1 2#
AddApartmentTypeAsync
‘‘2 G
(
‘‘G H
values
‘‘H N
)
‘‘N O
)
‘‘O P
;
‘‘P Q
}
’’ 	
catch
÷÷ 
(
÷÷ 
	Exception
÷÷ 
ex
÷÷ 
)
÷÷ 
{
◊◊ 	
return
ÿÿ 

StatusCode
ÿÿ 
(
ÿÿ 
$num
ÿÿ !
,
ÿÿ! "
ex
ÿÿ# %
.
ÿÿ% &
InnerException
ÿÿ& 4
!
ÿÿ4 5
.
ÿÿ5 6
Message
ÿÿ6 =
)
ÿÿ= >
;
ÿÿ> ?
}
ŸŸ 	
}
⁄⁄ 
[
ﬂﬂ 
HttpPut
ﬂﬂ 
]
ﬂﬂ 
[
‡‡ 
Route
‡‡ 

(
‡‡
 
$str
‡‡  
)
‡‡  !
]
‡‡! "
public
·· 

async
·· 
Task
·· 
<
·· 
ActionResult
·· "
<
··" #"
ApartmentTypeReadDto
··# 7
>
··7 8
>
··8 9!
UpdateApartmentType
··: M
(
··M N
[
··N O
FromBody
··O W
]
··W X$
ApartmentTypeUpdateDto
··Y o
values
··p v
)
··v w
{
‚‚ 
return
„„ 
Ok
„„ 
(
„„ 
await
„„ #
_apartmentTypeService
„„ -
.
„„- .&
UpdateApartmentTypeAsync
„„. F
(
„„F G
values
„„G M
)
„„M N
)
„„N O
;
„„O P
}
‰‰ 
[
ÊÊ 

HttpDelete
ÊÊ 
(
ÊÊ 
$str
ÊÊ 7
)
ÊÊ7 8
]
ÊÊ8 9
public
ÁÁ 

void
ÁÁ !
DeleteApartmentType
ÁÁ #
(
ÁÁ# $
int
ÁÁ$ '
apartmentTypeId
ÁÁ( 7
)
ÁÁ7 8
{
ËË 
}
ÈÈ 
[
ÔÔ 
HttpGet
ÔÔ 
]
ÔÔ 
[
 
Route
 

(

 
$str
 !
)
! "
]
" #
public
ÒÒ 

async
ÒÒ 
Task
ÒÒ 
<
ÒÒ 
ActionResult
ÒÒ "
<
ÒÒ" #
IEnumerable
ÒÒ# .
<
ÒÒ. / 
BlockNumberReadDto
ÒÒ/ A
>
ÒÒA B
>
ÒÒB C
>
ÒÒC D
GetBlockNumber
ÒÒE S
(
ÒÒS T
)
ÒÒT U
{
ÚÚ 
return
ÛÛ 
Ok
ÛÛ 
(
ÛÛ 
await
ÛÛ !
_blockNumberService
ÛÛ +
.
ÛÛ+ ,!
GetBlockNumberAsync
ÛÛ, ?
(
ÛÛ? @
)
ÛÛ@ A
)
ÛÛA B
;
ÛÛB C
}
ÙÙ 
[
àà 
HttpPost
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ 
)
ââ 
]
ââ  
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" # 
BlockNumberReadDto
ää# 5
>
ää5 6
>
ää6 7
AddBlockNumber
ää8 F
(
ääF G
[
ääG H
FromBody
ääH P
]
ääP Q"
BlockNumberCreateDto
ääR f
values
ääg m
)
ääm n
{
ãã 
try
åå 
{
çç 	
return
éé 
Ok
éé 
(
éé 
await
éé !
_blockNumberService
éé /
.
éé/ 0!
AddBlockNumberAsync
éé0 C
(
ééC D
values
ééD J
)
ééJ K
)
ééK L
;
ééL M
}
èè 	
catch
êê 
(
êê 
	Exception
êê 
ex
êê 
)
êê 
{
ëë 	
return
íí 

StatusCode
íí 
(
íí 
$num
íí !
,
íí! "
ex
íí# %
.
íí% &
InnerException
íí& 4
!
íí4 5
.
íí5 6
Message
íí6 =
)
íí= >
;
íí> ?
}
ìì 	
}
îî 
[
öö 
HttpPut
öö 
]
öö 
[
õõ 
Route
õõ 

(
õõ
 
$str
õõ 
)
õõ 
]
õõ  
public
úú 

async
úú 
Task
úú 
<
úú 
ActionResult
úú "
<
úú" # 
BlockNumberReadDto
úú# 5
>
úú5 6
>
úú6 7
UpdateBlockNumber
úú8 I
(
úúI J
[
úúJ K
FromBody
úúK S
]
úúS T"
BlockNumberUpdateDto
úúU i
values
úúj p
)
úúp q
{
ùù 
return
ûû 
Ok
ûû 
(
ûû 
await
ûû !
_blockNumberService
ûû +
.
ûû+ ,$
UpdateBlockNumberAsync
ûû, B
(
ûûB C
values
ûûC I
)
ûûI J
)
ûûJ K
;
ûûK L
}
üü 
[
°° 

HttpDelete
°° 
(
°° 
$str
°° 0
)
°°0 1
]
°°1 2
public
¢¢ 

void
¢¢ 
DeleteBlockNumber
¢¢ !
(
¢¢! "
int
¢¢" %

facilityId
¢¢& 0
)
¢¢0 1
{
££ 
}
§§ 
[
™™ 
HttpGet
™™ 
]
™™ 
[
´´ 
Route
´´ 

(
´´
 
$str
´´  
)
´´  !
]
´´! "
public
¨¨ 

async
¨¨ 
Task
¨¨ 
<
¨¨ 
ActionResult
¨¨ "
<
¨¨" #
IEnumerable
¨¨# .
<
¨¨. /
BlockSideReadDto
¨¨/ ?
>
¨¨? @
>
¨¨@ A
>
¨¨A B
GetBlockSides
¨¨C P
(
¨¨P Q
)
¨¨Q R
{
≠≠ 
return
ÆÆ 
Ok
ÆÆ 
(
ÆÆ 
await
ÆÆ 
_blockSideService
ÆÆ )
.
ÆÆ) *
GetBlockSideAsync
ÆÆ* ;
(
ÆÆ; <
)
ÆÆ< =
)
ÆÆ= >
;
ÆÆ> ?
}
ØØ 
[
ƒƒ 
HttpPost
ƒƒ 
]
ƒƒ 
[
≈≈ 
Route
≈≈ 

(
≈≈
 
$str
≈≈ 
)
≈≈ 
]
≈≈ 
public
∆∆ 

async
∆∆ 
Task
∆∆ 
<
∆∆ 
ActionResult
∆∆ "
<
∆∆" #
BlockSideReadDto
∆∆# 3
>
∆∆3 4
>
∆∆4 5
AddBlockSide
∆∆6 B
(
∆∆B C
[
∆∆C D
FromBody
∆∆D L
]
∆∆L M 
BlockSideCreateDto
∆∆N `
values
∆∆a g
)
∆∆g h
{
«« 
try
»» 
{
…… 	
return
   
Ok
   
(
   
await
   
_blockSideService
   -
.
  - .
AddBlockSideAsync
  . ?
(
  ? @
values
  @ F
)
  F G
)
  G H
;
  H I
}
ÀÀ 	
catch
ÃÃ 
(
ÃÃ 
	Exception
ÃÃ 
ex
ÃÃ 
)
ÃÃ 
{
ÕÕ 	
return
ŒŒ 

StatusCode
ŒŒ 
(
ŒŒ 
$num
ŒŒ !
,
ŒŒ! "
ex
ŒŒ# %
.
ŒŒ% &
InnerException
ŒŒ& 4
!
ŒŒ4 5
.
ŒŒ5 6
Message
ŒŒ6 =
)
ŒŒ= >
;
ŒŒ> ?
}
œœ 	
}
–– 
[
÷÷ 
HttpPut
÷÷ 
]
÷÷ 
[
◊◊ 
Route
◊◊ 

(
◊◊
 
$str
◊◊ 
)
◊◊ 
]
◊◊ 
public
ÿÿ 

async
ÿÿ 
Task
ÿÿ 
<
ÿÿ 
ActionResult
ÿÿ "
<
ÿÿ" #
BlockSideReadDto
ÿÿ# 3
>
ÿÿ3 4
>
ÿÿ4 5
UpdateBlockSide
ÿÿ6 E
(
ÿÿE F
[
ÿÿF G
FromBody
ÿÿG O
]
ÿÿO P 
BlockSideUpdateDto
ÿÿQ c
values
ÿÿd j
)
ÿÿj k
{
ŸŸ 
return
⁄⁄ 
Ok
⁄⁄ 
(
⁄⁄ 
await
⁄⁄ 
_blockSideService
⁄⁄ )
.
⁄⁄) *"
UpdateBlockSideAsync
⁄⁄* >
(
⁄⁄> ?
values
⁄⁄? E
)
⁄⁄E F
)
⁄⁄F G
;
⁄⁄G H
}
€€ 
[
›› 

HttpDelete
›› 
(
›› 
$str
›› /
)
››/ 0
]
››0 1
public
ﬁﬁ 

void
ﬁﬁ 
DeleteBlockSide
ﬁﬁ 
(
ﬁﬁ  
int
ﬁﬁ  #
blockSideId
ﬁﬁ$ /
)
ﬁﬁ/ 0
{
ﬂﬂ 
}
‡‡ 
[
ÁÁ 
HttpGet
ÁÁ 
]
ÁÁ 
[
ËË 
Route
ËË 

(
ËË
 
$str
ËË  
)
ËË  !
]
ËË! "
public
ÈÈ 

async
ÈÈ 
Task
ÈÈ 
<
ÈÈ 
ActionResult
ÈÈ "
<
ÈÈ" #
IEnumerable
ÈÈ# .
<
ÈÈ. /
BlockTypeReadDto
ÈÈ/ ?
>
ÈÈ? @
>
ÈÈ@ A
>
ÈÈA B
GetBlockTypes
ÈÈC P
(
ÈÈP Q
)
ÈÈQ R
{
ÍÍ 
return
ÎÎ 
Ok
ÎÎ 
(
ÎÎ 
await
ÎÎ 
_blockTypeService
ÎÎ )
.
ÎÎ) *
GetBlockTypeAsync
ÎÎ* ;
(
ÎÎ; <
)
ÎÎ< =
)
ÎÎ= >
;
ÎÎ> ?
}
ÏÏ 
[
ÄÄ 
HttpPost
ÄÄ 
]
ÄÄ 
[
ÅÅ 
Route
ÅÅ 

(
ÅÅ
 
$str
ÅÅ 
)
ÅÅ 
]
ÅÅ 
public
ÇÇ 

async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ "
<
ÇÇ" #
BlockTypeReadDto
ÇÇ# 3
>
ÇÇ3 4
>
ÇÇ4 5
AddBlockType
ÇÇ6 B
(
ÇÇB C
[
ÇÇC D
FromBody
ÇÇD L
]
ÇÇL M 
BlockTypeCreateDto
ÇÇN `
values
ÇÇa g
)
ÇÇg h
{
ÉÉ 
try
ÑÑ 
{
ÖÖ 	
return
ÜÜ 
Ok
ÜÜ 
(
ÜÜ 
await
ÜÜ 
_blockTypeService
ÜÜ -
.
ÜÜ- .
AddBlockTypeAsync
ÜÜ. ?
(
ÜÜ? @
values
ÜÜ@ F
)
ÜÜF G
)
ÜÜG H
;
ÜÜH I
}
áá 	
catch
àà 
(
àà 
	Exception
àà 
ex
àà 
)
àà 
{
ââ 	
return
ää 

StatusCode
ää 
(
ää 
$num
ää !
,
ää! "
ex
ää# %
.
ää% &
InnerException
ää& 4
!
ää4 5
.
ää5 6
Message
ää6 =
)
ää= >
;
ää> ?
}
ãã 	
}
åå 
[
íí 
HttpPut
íí 
]
íí 
[
ìì 
Route
ìì 

(
ìì
 
$str
ìì 
)
ìì 
]
ìì 
public
îî 

async
îî 
Task
îî 
<
îî 
ActionResult
îî "
<
îî" #
BlockTypeReadDto
îî# 3
>
îî3 4
>
îî4 5
UpdateBlockType
îî6 E
(
îîE F
[
îîF G
FromBody
îîG O
]
îîO P 
BlockTypeUpdateDto
îîQ c
values
îîd j
)
îîj k
{
ïï 
return
ññ 
Ok
ññ 
(
ññ 
await
ññ 
_blockTypeService
ññ )
.
ññ) *"
UpdateBlockTypeAsync
ññ* >
(
ññ> ?
values
ññ? E
)
ññE F
)
ññF G
;
ññG H
}
óó 
[
ôô 

HttpDelete
ôô 
(
ôô 
$str
ôô /
)
ôô/ 0
]
ôô0 1
public
öö 

void
öö 
DeleteBlockType
öö 
(
öö  
int
öö  #
blockTypeId
öö$ /
)
öö/ 0
{
õõ 
}
úú 
[
¢¢ 
HttpGet
¢¢ 
]
¢¢ 
[
££ 
Route
££ 

(
££
 
$str
££  
)
££  !
]
££! "
public
§§ 

async
§§ 
Task
§§ 
<
§§ 
ActionResult
§§ "
<
§§" #
IEnumerable
§§# .
<
§§. /
BlockUnitReadDto
§§/ ?
>
§§? @
>
§§@ A
>
§§A B
GetBlockUnits
§§C P
(
§§P Q
)
§§Q R
{
•• 
return
¶¶ 
Ok
¶¶ 
(
¶¶ 
await
¶¶ 
_blockUnitService
¶¶ )
.
¶¶) *
GetBlockUnitAsync
¶¶* ;
(
¶¶; <
)
¶¶< =
)
¶¶= >
;
¶¶> ?
}
ßß 
[
ªª 
HttpPost
ªª 
]
ªª 
[
ºº 
Route
ºº 

(
ºº
 
$str
ºº 
)
ºº 
]
ºº 
public
ΩΩ 

async
ΩΩ 
Task
ΩΩ 
<
ΩΩ 
ActionResult
ΩΩ "
<
ΩΩ" #
BlockUnitReadDto
ΩΩ# 3
>
ΩΩ3 4
>
ΩΩ4 5
CreateBlockUnit
ΩΩ6 E
(
ΩΩE F
[
ΩΩF G
FromBody
ΩΩG O
]
ΩΩO P 
BlockUnitCreateDto
ΩΩQ c
values
ΩΩd j
)
ΩΩj k
{
ææ 
try
øø 
{
¿¿ 	
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ 
_blockUnitService
¡¡ -
.
¡¡- .
AddBlockUnitAsync
¡¡. ?
(
¡¡? @
values
¡¡@ F
)
¡¡F G
)
¡¡G H
;
¡¡H I
}
¬¬ 	
catch
√√ 
(
√√ 
	Exception
√√ 
ex
√√ 
)
√√ 
{
ƒƒ 	
return
≈≈ 

StatusCode
≈≈ 
(
≈≈ 
$num
≈≈ !
,
≈≈! "
ex
≈≈# %
.
≈≈% &
InnerException
≈≈& 4
!
≈≈4 5
.
≈≈5 6
Message
≈≈6 =
)
≈≈= >
;
≈≈> ?
}
∆∆ 	
}
«« 
[
ÕÕ 
HttpPut
ÕÕ 
]
ÕÕ 
[
ŒŒ 
Route
ŒŒ 

(
ŒŒ
 
$str
ŒŒ 
)
ŒŒ 
]
ŒŒ 
public
œœ 

async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ "
<
œœ" #
BlockUnitReadDto
œœ# 3
>
œœ3 4
>
œœ4 5
UpdateBlockUnit
œœ6 E
(
œœE F
[
œœF G
FromBody
œœG O
]
œœO P 
BlockUnitUpdateDto
œœQ c
values
œœd j
)
œœj k
{
–– 
return
—— 
Ok
—— 
(
—— 
await
—— 
_blockUnitService
—— )
.
——) *"
UpdateBlockUnitAsync
——* >
(
——> ?
values
——? E
)
——E F
)
——F G
;
——G H
}
““ 
[
‘‘ 

HttpDelete
‘‘ 
(
‘‘ 
$str
‘‘ /
)
‘‘/ 0
]
‘‘0 1
public
’’ 

void
’’ 
DeleteBlockUnit
’’ 
(
’’  
int
’’  #
blockUnitId
’’$ /
)
’’/ 0
{
÷÷ 
}
◊◊ 
[
›› 
HttpGet
›› 
]
›› 
[
ﬁﬁ 
Route
ﬁﬁ 

(
ﬁﬁ
 
$str
ﬁﬁ  
)
ﬁﬁ  !
]
ﬁﬁ! "
public
ﬂﬂ 

async
ﬂﬂ 
Task
ﬂﬂ 
<
ﬂﬂ 
ActionResult
ﬂﬂ "
<
ﬂﬂ" #
IEnumerable
ﬂﬂ# .
<
ﬂﬂ. /
FacilitiesReadDto
ﬂﬂ/ @
>
ﬂﬂ@ A
>
ﬂﬂA B
>
ﬂﬂB C
GetFacilities
ﬂﬂD Q
(
ﬂﬂQ R
)
ﬂﬂR S
{
‡‡ 
return
·· 
Ok
·· 
(
·· 
await
··  
_facilitiesService
·· *
.
··* + 
GetFacilitiesAsync
··+ =
(
··= >
)
··> ?
)
··? @
;
··@ A
}
‚‚ 
[
ˆˆ 
HttpPost
ˆˆ 
]
ˆˆ 
[
˜˜ 
Route
˜˜ 

(
˜˜
 
$str
˜˜ 
)
˜˜ 
]
˜˜ 
public
¯¯ 

async
¯¯ 
Task
¯¯ 
<
¯¯ 
ActionResult
¯¯ "
<
¯¯" #
FacilitiesReadDto
¯¯# 4
>
¯¯4 5
>
¯¯5 6
CreateFacility
¯¯7 E
(
¯¯E F
[
¯¯F G
FromBody
¯¯G O
]
¯¯O P!
FacilitiesCreateDto
¯¯Q d
values
¯¯e k
)
¯¯k l
{
˘˘ 
try
˙˙ 
{
˚˚ 	
return
¸¸ 
Ok
¸¸ 
(
¸¸ 
await
¸¸  
_facilitiesService
¸¸ .
.
¸¸. / 
AddFacilitiesAsync
¸¸/ A
(
¸¸A B
values
¸¸B H
)
¸¸H I
)
¸¸I J
;
¸¸J K
}
˝˝ 	
catch
˛˛ 
(
˛˛ 
	Exception
˛˛ 
ex
˛˛ 
)
˛˛ 
{
ˇˇ 	
return
ÄÄ 

StatusCode
ÄÄ 
(
ÄÄ 
$num
ÄÄ !
,
ÄÄ! "
ex
ÄÄ# %
.
ÄÄ% &
InnerException
ÄÄ& 4
!
ÄÄ4 5
.
ÄÄ5 6
Message
ÄÄ6 =
)
ÄÄ= >
;
ÄÄ> ?
}
ÅÅ 	
}
ÇÇ 
[
àà 
HttpPut
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ 
)
ââ 
]
ââ 
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" #
FacilitiesReadDto
ää# 4
>
ää4 5
>
ää5 6
UpdateFacility
ää7 E
(
ääE F
[
ääF G
FromBody
ääG O
]
ääO P!
FacilitiesUpdateDto
ääQ d
values
ääe k
)
ääk l
{
ãã 
return
åå 
Ok
åå 
(
åå 
await
åå  
_facilitiesService
åå *
.
åå* +#
UpdateFacilitiesAsync
åå+ @
(
åå@ A
values
ååA G
)
ååG H
)
ååH I
;
ååI J
}
çç 
[
èè 

HttpDelete
èè 
(
èè 
$str
èè -
)
èè- .
]
èè. /
public
êê 

void
êê 
DeleteFacility
êê 
(
êê 
int
êê "

facilityId
êê# -
)
êê- .
{
ëë 
}
íí 
[
òò 
HttpGet
òò 
]
òò 
[
ôô 
Route
ôô 

(
ôô
 
$str
ôô $
)
ôô$ %
]
ôô% &
public
öö 

async
öö 
Task
öö 
<
öö 
ActionResult
öö "
<
öö" #
IEnumerable
öö# .
<
öö. /#
FloorNumberingReadDto
öö/ D
>
ööD E
>
ööE F
>
ööF G
GetFloorNumbering
ööH Y
(
ööY Z
)
ööZ [
{
õõ 
return
úú 
Ok
úú 
(
úú 
await
úú $
_floorNumberingService
úú .
.
úú. /$
GetFloorNumberingAsync
úú/ E
(
úúE F
)
úúF G
)
úúG H
;
úúH I
}
ùù 
[
±± 
HttpPost
±± 
]
±± 
[
≤≤ 
Route
≤≤ 

(
≤≤
 
$str
≤≤ 
)
≤≤ 
]
≤≤  
public
≥≥ 

async
≥≥ 
Task
≥≥ 
<
≥≥ 
ActionResult
≥≥ "
<
≥≥" ##
FloorNumberingReadDto
≥≥# 8
>
≥≥8 9
>
≥≥9 :
CreateFloorNumber
≥≥; L
(
≥≥L M
[
≥≥M N
FromBody
≥≥N V
]
≥≥V W%
FloorNumberingCreateDto
≥≥X o
values
≥≥p v
)
≥≥v w
{
¥¥ 
try
µµ 
{
∂∂ 	
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
await
∑∑ $
_floorNumberingService
∑∑ 2
.
∑∑2 3$
AddFloorNumberingAsync
∑∑3 I
(
∑∑I J
values
∑∑J P
)
∑∑P Q
)
∑∑Q R
;
∑∑R S
}
∏∏ 	
catch
ππ 
(
ππ 
	Exception
ππ 
ex
ππ 
)
ππ 
{
∫∫ 	
return
ªª 

StatusCode
ªª 
(
ªª 
$num
ªª !
,
ªª! "
ex
ªª# %
.
ªª% &
InnerException
ªª& 4
!
ªª4 5
.
ªª5 6
Message
ªª6 =
)
ªª= >
;
ªª> ?
}
ºº 	
}
ΩΩ 
[
√√ 
HttpPut
√√ 
]
√√ 
[
ƒƒ 
Route
ƒƒ 

(
ƒƒ
 
$str
ƒƒ 
)
ƒƒ 
]
ƒƒ  
public
≈≈ 

async
≈≈ 
Task
≈≈ 
<
≈≈ 
ActionResult
≈≈ "
<
≈≈" ##
FloorNumberingReadDto
≈≈# 8
>
≈≈8 9
>
≈≈9 :
UpdateFloorNumber
≈≈; L
(
≈≈L M
[
≈≈M N
FromBody
≈≈N V
]
≈≈V W%
FloorNumberingUpdateDto
≈≈X o
values
≈≈p v
)
≈≈v w
{
∆∆ 
return
«« 
Ok
«« 
(
«« 
await
«« $
_floorNumberingService
«« .
.
««. /'
UpdateFloorNumberingAsync
««/ H
(
««H I
values
««I O
)
««O P
)
««P Q
;
««Q R
}
»» 
[
   

HttpDelete
   
(
   
$str
   3
)
  3 4
]
  4 5
public
ÀÀ 

void
ÀÀ 
DeleteFloorNumber
ÀÀ !
(
ÀÀ! "
int
ÀÀ" %
floorNumberId
ÀÀ& 3
)
ÀÀ3 4
{
ÃÃ 
}
ÕÕ 
[
”” 
HttpGet
”” 
]
”” 
[
‘‘ 
Route
‘‘ 

(
‘‘
 
$str
‘‘ 
)
‘‘ 
]
‘‘ 
public
’’ 

async
’’ 
Task
’’ 
<
’’ 
ActionResult
’’ "
<
’’" #
IEnumerable
’’# .
<
’’. /
LandUseReadDto
’’/ =
>
’’= >
>
’’> ?
>
’’? @

GetLandUse
’’A K
(
’’K L
)
’’L M
{
÷÷ 
return
◊◊ 
Ok
◊◊ 
(
◊◊ 
await
◊◊ 
_landUseService
◊◊ '
.
◊◊' (
GetLandUseAsync
◊◊( 7
(
◊◊7 8
)
◊◊8 9
)
◊◊9 :
;
◊◊: ;
}
ÿÿ 
[
⁄⁄ 
HttpGet
⁄⁄ 
]
⁄⁄ 
[
€€ 
Route
€€ 

(
€€
 
$str
€€ '
)
€€' (
]
€€( )
public
‹‹ 

async
‹‹ 
Task
‹‹ 
<
‹‹ 
ActionResult
‹‹ "
<
‹‹" #
LandUseReadDto
‹‹# 1
>
‹‹1 2
>
‹‹2 3

GetLandUse
‹‹4 >
(
‹‹> ?
string
‹‹? E
landUse
‹‹F M
)
‹‹M N
{
›› 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ 
_landUseService
ﬁﬁ '
.
ﬁﬁ' (
GetLandUseAsync
ﬁﬁ( 7
(
ﬁﬁ7 8
landUse
ﬁﬁ8 ?
)
ﬁﬁ? @
)
ﬁﬁ@ A
;
ﬁﬁA B
}
ﬂﬂ 
[
·· 
HttpGet
·· 
]
·· 
[
‚‚ 
Route
‚‚ 

(
‚‚
 
$str
‚‚ -
)
‚‚- .
]
‚‚. /
public
„„ 

async
„„ 
Task
„„ 
<
„„ 
ActionResult
„„ "
<
„„" #
LandUseReadDto
„„# 1
>
„„1 2
>
„„2 3
GetLandUseById
„„4 B
(
„„B C
int
„„C F
	landUseId
„„G P
)
„„P Q
{
‰‰ 
return
ÂÂ 
Ok
ÂÂ 
(
ÂÂ 
await
ÂÂ 
_landUseService
ÂÂ '
.
ÂÂ' (
GetLandUseAsync
ÂÂ( 7
(
ÂÂ7 8
	landUseId
ÂÂ8 A
)
ÂÂA B
)
ÂÂB C
;
ÂÂC D
}
ÊÊ 
[
ÅÅ 
HttpPost
ÅÅ 
]
ÅÅ 
[
ÇÇ 
Route
ÇÇ 

(
ÇÇ
 
$str
ÇÇ 
)
ÇÇ 
]
ÇÇ 
public
ÉÉ 

async
ÉÉ 
Task
ÉÉ 
<
ÉÉ 
ActionResult
ÉÉ "
<
ÉÉ" #
LandUseReadDto
ÉÉ# 1
>
ÉÉ1 2
>
ÉÉ2 3
CreateLandUse
ÉÉ4 A
(
ÉÉA B
[
ÉÉB C
FromBody
ÉÉC K
]
ÉÉK L
LandUseCreateDto
ÉÉM ]
values
ÉÉ^ d
)
ÉÉd e
{
ÑÑ 
try
ÜÜ 
{
áá 	
return
àà 
Ok
àà 
(
àà 
await
àà 
_landUseService
àà +
.
àà+ ,
AddLandUseAsync
àà, ;
(
àà; <
values
àà< B
)
ààB C
)
ààC D
;
ààD E
}
ââ 	
catch
ää 
(
ää 
	Exception
ää 
ex
ää 
)
ää 
{
ãã 	
return
åå 

StatusCode
åå 
(
åå 
$num
åå !
,
åå! "
ex
åå# %
.
åå% &
InnerException
åå& 4
!
åå4 5
.
åå5 6
Message
åå6 =
)
åå= >
;
åå> ?
}
çç 	
}
éé 
[
îî 
HttpPut
îî 
]
îî 
[
ïï 
Route
ïï 

(
ïï
 
$str
ïï 
)
ïï 
]
ïï 
public
ññ 

async
ññ 
Task
ññ 
<
ññ 
ActionResult
ññ "
<
ññ" #
LandUseReadDto
ññ# 1
>
ññ1 2
>
ññ2 3
UpdateLandUse
ññ4 A
(
ññA B
[
ññB C
FromBody
ññC K
]
ññK L
LandUseUpdateDto
ññM ]
values
ññ^ d
)
ññd e
{
óó 
return
òò 
Ok
òò 
(
òò 
await
òò 
_landUseService
òò '
.
òò' ( 
UpdateLandUseAsync
òò( :
(
òò: ;
values
òò; A
)
òòA B
)
òòB C
;
òòC D
}
ôô 
[
õõ 

HttpDelete
õõ 
(
õõ 
$str
õõ +
)
õõ+ ,
]
õõ, -
public
úú 

void
úú 
DeleteLandUse
úú 
(
úú 
int
úú !
	landUseId
úú" +
)
úú+ ,
{
ùù 
}
ûû 
[
§§ 
HttpGet
§§ 
]
§§ 
[
•• 
Route
•• 

(
••
 
$str
•• !
)
••! "
]
••" #
public
¶¶ 

async
¶¶ 
Task
¶¶ 
<
¶¶ 
ActionResult
¶¶ "
<
¶¶" #
IEnumerable
¶¶# .
<
¶¶. / 
LandUseTypeReadDto
¶¶/ A
>
¶¶A B
>
¶¶B C
>
¶¶C D
GetLandUseType
¶¶E S
(
¶¶S T
)
¶¶T U
{
ßß 
return
®® 
Ok
®® 
(
®® 
await
®® !
_landUseTypeService
®® +
.
®®+ ,!
GetLandUseTypeAsync
®®, ?
(
®®? @
)
®®@ A
)
®®A B
;
®®B C
}
©© 
[
´´ 
HttpGet
´´ 
]
´´ 
[
¨¨ 
Route
¨¨ 

(
¨¨
 
$str
¨¨ +
)
¨¨+ ,
]
¨¨, -
public
≠≠ 

async
≠≠ 
Task
≠≠ 
<
≠≠ 
ActionResult
≠≠ "
<
≠≠" # 
LandUseTypeReadDto
≠≠# 5
>
≠≠5 6
>
≠≠6 7
GetLandUseType
≠≠8 F
(
≠≠F G
string
≠≠G M
landUse
≠≠N U
)
≠≠U V
{
ÆÆ 
return
ØØ 
Ok
ØØ 
(
ØØ 
await
ØØ !
_landUseTypeService
ØØ +
.
ØØ+ ,!
GetLandUseTypeAsync
ØØ, ?
(
ØØ? @
landUse
ØØ@ G
)
ØØG H
)
ØØH I
;
ØØI J
}
∞∞ 
[
≤≤ 
HttpGet
≤≤ 
]
≤≤ 
[
≥≥ 
Route
≥≥ 

(
≥≥
 
$str
≥≥ 5
)
≥≥5 6
]
≥≥6 7
public
¥¥ 

async
¥¥ 
Task
¥¥ 
<
¥¥ 
ActionResult
¥¥ "
<
¥¥" #
LandUseReadDto
¥¥# 1
>
¥¥1 2
>
¥¥2 3 
GetLandUseTypeById
¥¥4 F
(
¥¥F G
int
¥¥G J
	landUseId
¥¥K T
)
¥¥T U
{
µµ 
return
∂∂ 
Ok
∂∂ 
(
∂∂ 
await
∂∂ !
_landUseTypeService
∂∂ +
.
∂∂+ ,!
GetLandUseTypeAsync
∂∂, ?
(
∂∂? @
	landUseId
∂∂@ I
)
∂∂I J
)
∂∂J K
;
∂∂K L
}
∑∑ 
[
œœ 
HttpPost
œœ 
]
œœ 
[
–– 
Route
–– 

(
––
 
$str
–– 
)
–– 
]
––  
public
—— 

async
—— 
Task
—— 
<
—— 
ActionResult
—— "
<
——" # 
LandUseTypeReadDto
——# 5
>
——5 6
>
——6 7
CreateLandUseType
——8 I
(
——I J
[
——J K
FromBody
——K S
]
——S T"
LandUseTypeCreateDto
——U i
values
——j p
)
——p q
{
““ 
try
‘‘ 
{
’’ 	
return
÷÷ 
Ok
÷÷ 
(
÷÷ 
await
÷÷ !
_landUseTypeService
÷÷ /
.
÷÷/ 0!
AddLandUseTypeAsync
÷÷0 C
(
÷÷C D
values
÷÷D J
)
÷÷J K
)
÷÷K L
;
÷÷L M
}
◊◊ 	
catch
ÿÿ 
(
ÿÿ 
	Exception
ÿÿ 
ex
ÿÿ 
)
ÿÿ 
{
ŸŸ 	
return
⁄⁄ 

StatusCode
⁄⁄ 
(
⁄⁄ 
$num
⁄⁄ !
,
⁄⁄! "
ex
⁄⁄# %
.
⁄⁄% &
InnerException
⁄⁄& 4
!
⁄⁄4 5
.
⁄⁄5 6
Message
⁄⁄6 =
)
⁄⁄= >
;
⁄⁄> ?
}
€€ 	
}
‹‹ 
[
‚‚ 
HttpPut
‚‚ 
]
‚‚ 
[
„„ 
Route
„„ 

(
„„
 
$str
„„ 
)
„„ 
]
„„  
public
‰‰ 

async
‰‰ 
Task
‰‰ 
<
‰‰ 
ActionResult
‰‰ "
<
‰‰" #
LandUseReadDto
‰‰# 1
>
‰‰1 2
>
‰‰2 3
UpdateLandUseType
‰‰4 E
(
‰‰E F
[
‰‰F G
FromBody
‰‰G O
]
‰‰O P"
LandUseTypeUpdateDto
‰‰Q e
values
‰‰f l
)
‰‰l m
{
ÂÂ 
return
ÊÊ 
Ok
ÊÊ 
(
ÊÊ 
await
ÊÊ !
_landUseTypeService
ÊÊ +
.
ÊÊ+ ,$
UpdateLandUseTypeAsync
ÊÊ, B
(
ÊÊB C
values
ÊÊC I
)
ÊÊI J
)
ÊÊJ K
;
ÊÊK L
}
ÁÁ 
[
ÈÈ 

HttpDelete
ÈÈ 
(
ÈÈ 
$str
ÈÈ 3
)
ÈÈ3 4
]
ÈÈ4 5
public
ÍÍ 

void
ÍÍ 
DeleteLandUseType
ÍÍ !
(
ÍÍ! "
int
ÍÍ" %
	landUseId
ÍÍ& /
)
ÍÍ/ 0
{
ÎÎ 
}
ÏÏ 
[
ÚÚ 
HttpGet
ÚÚ 
]
ÚÚ 
[
ÛÛ 
Route
ÛÛ 

(
ÛÛ
 
$str
ÛÛ 
)
ÛÛ 
]
ÛÛ  
public
ÙÙ 

async
ÙÙ 
Task
ÙÙ 
<
ÙÙ 
ActionResult
ÙÙ "
<
ÙÙ" #
IEnumerable
ÙÙ# .
<
ÙÙ. /
LocalityReadDto
ÙÙ/ >
>
ÙÙ> ?
>
ÙÙ? @
>
ÙÙ@ A

GeLocality
ÙÙB L
(
ÙÙL M
)
ÙÙM N
{
ıı 
return
ˆˆ 
Ok
ˆˆ 
(
ˆˆ 
await
ˆˆ 
_localityService
ˆˆ (
.
ˆˆ( )
GetLocalityAsync
ˆˆ) 9
(
ˆˆ9 :
)
ˆˆ: ;
)
ˆˆ; <
;
ˆˆ< =
}
˜˜ 
[
˘˘ 
HttpGet
˘˘ 
]
˘˘ 
[
˙˙ 
Route
˙˙ 

(
˙˙
 
$str
˙˙ &
)
˙˙& '
]
˙˙' (
public
˚˚ 

async
˚˚ 
Task
˚˚ 
<
˚˚ 
ActionResult
˚˚ "
<
˚˚" #
LocalityReadDto
˚˚# 2
>
˚˚2 3
>
˚˚3 4
GetLocality
˚˚5 @
(
˚˚@ A
string
˚˚A G
value
˚˚H M
)
˚˚M N
{
¸¸ 
return
˝˝ 
Ok
˝˝ 
(
˝˝ 
await
˝˝ 
_localityService
˝˝ (
.
˝˝( )
GetLocalityAsync
˝˝) 9
(
˝˝9 :
value
˝˝: ?
)
˝˝? @
)
˝˝@ A
;
˝˝A B
}
˛˛ 
[
ÄÄ 
HttpGet
ÄÄ 
]
ÄÄ 
[
ÅÅ 
Route
ÅÅ 

(
ÅÅ
 
$str
ÅÅ /
)
ÅÅ/ 0
]
ÅÅ0 1
public
ÇÇ 

async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ "
<
ÇÇ" #
LocalityReadDto
ÇÇ# 2
>
ÇÇ2 3
>
ÇÇ3 4
GetLocalityById
ÇÇ5 D
(
ÇÇD E
int
ÇÇE H

localityId
ÇÇI S
)
ÇÇS T
{
ÉÉ 
return
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
await
ÑÑ 
_localityService
ÑÑ (
.
ÑÑ( )
GetLocalityAsync
ÑÑ) 9
(
ÑÑ9 :

localityId
ÑÑ: D
)
ÑÑD E
)
ÑÑE F
;
ÑÑF G
}
ÖÖ 
[
ùù 
HttpPost
ùù 
]
ùù 
[
ûû 
Route
ûû 

(
ûû
 
$str
ûû 
)
ûû 
]
ûû 
public
üü 

async
üü 
Task
üü 
<
üü 
ActionResult
üü "
<
üü" #
LocalityReadDto
üü# 2
>
üü2 3
>
üü3 4
CreateLocality
üü5 C
(
üüC D
[
üüD E
FromBody
üüE M
]
üüM N
LocalityCreateDto
üüO `
values
üüa g
)
üüg h
{
†† 
try
°° 
{
¢¢ 	
return
££ 
Ok
££ 
(
££ 
await
££ 
_localityService
££ ,
.
££, -!
CreateLocalityAsync
££- @
(
££@ A
values
££A G
)
££G H
)
££H I
;
££I J
}
§§ 	
catch
•• 
(
•• 
	Exception
•• 
ex
•• 
)
•• 
{
¶¶ 	
return
ßß 

StatusCode
ßß 
(
ßß 
$num
ßß !
,
ßß! "
ex
ßß# %
.
ßß% &
InnerException
ßß& 4
!
ßß4 5
.
ßß5 6
Message
ßß6 =
)
ßß= >
;
ßß> ?
}
®® 	
}
©© 
[
ØØ 
HttpPut
ØØ 
]
ØØ 
[
∞∞ 
Route
∞∞ 

(
∞∞
 
$str
∞∞ 
)
∞∞ 
]
∞∞ 
public
±± 

async
±± 
Task
±± 
<
±± 
ActionResult
±± "
<
±±" #
LocalityReadDto
±±# 2
>
±±2 3
>
±±3 4
UpdateLocality
±±5 C
(
±±C D
[
±±D E
FromBody
±±E M
]
±±M N
LocalityUpdateDto
±±O `
values
±±a g
)
±±g h
{
≤≤ 
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ 
_localityService
≥≥ (
.
≥≥( )!
UpdateLocalityAsync
≥≥) <
(
≥≥< =
values
≥≥= C
)
≥≥C D
)
≥≥D E
;
≥≥E F
}
¥¥ 
[
∂∂ 

HttpDelete
∂∂ 
(
∂∂ 
$str
∂∂ -
)
∂∂- .
]
∂∂. /
public
∑∑ 

void
∑∑ 
DeleteLocality
∑∑ 
(
∑∑ 
int
∑∑ "

localityId
∑∑# -
)
∑∑- .
{
∏∏ 
}
ππ 
[
øø 
HttpGet
øø 
]
øø 
[
¿¿ 
Route
¿¿ 

(
¿¿
 
$str
¿¿ 
)
¿¿ 
]
¿¿  
public
¡¡ 

async
¡¡ 
Task
¡¡ 
<
¡¡ 
ActionResult
¡¡ "
<
¡¡" #
IEnumerable
¡¡# .
<
¡¡. /
PlotSizeReadDto
¡¡/ >
>
¡¡> ?
>
¡¡? @
>
¡¡@ A
GetPlotSize
¡¡B M
(
¡¡M N
)
¡¡N O
{
¬¬ 
return
√√ 
Ok
√√ 
(
√√ 
await
√√ 
_plotSizeService
√√ (
.
√√( )
GetPlotSizeAsync
√√) 9
(
√√9 :
)
√√: ;
)
√√; <
;
√√< =
}
ƒƒ 
[
∆∆ 
HttpGet
∆∆ 
]
∆∆ 
[
«« 
Route
«« 

(
««
 
$str
«« &
)
««& '
]
««' (
public
»» 

async
»» 
Task
»» 
<
»» 
ActionResult
»» "
<
»»" #
PlotSizeReadDto
»»# 2
>
»»2 3
>
»»3 4
GetPlotSize
»»5 @
(
»»@ A
string
»»A G
value
»»H M
)
»»M N
{
…… 
return
   
Ok
   
(
   
await
   
_plotSizeService
   (
.
  ( )
GetPlotSizeAsync
  ) 9
(
  9 :
value
  : ?
)
  ? @
)
  @ A
;
  A B
}
ÀÀ 
[
ÕÕ 
HttpGet
ÕÕ 
]
ÕÕ 
[
ŒŒ 
Route
ŒŒ 

(
ŒŒ
 
$str
ŒŒ /
)
ŒŒ/ 0
]
ŒŒ0 1
public
œœ 

async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ "
<
œœ" #
PlotSizeReadDto
œœ# 2
>
œœ2 3
>
œœ3 4
GetPlotSizeById
œœ5 D
(
œœD E
int
œœE H

plotSizeId
œœI S
)
œœS T
{
–– 
return
—— 
Ok
—— 
(
—— 
await
—— 
_plotSizeService
—— (
.
——( )
GetPlotSizeAsync
——) 9
(
——9 :

plotSizeId
——: D
)
——D E
)
——E F
;
——F G
}
““ 
[
ÊÊ 
HttpPost
ÊÊ 
]
ÊÊ 
[
ÁÁ 
Route
ÁÁ 

(
ÁÁ
 
$str
ÁÁ 
)
ÁÁ 
]
ÁÁ 
public
ËË 

async
ËË 
Task
ËË 
<
ËË 
ActionResult
ËË "
<
ËË" #
PlotSizeReadDto
ËË# 2
>
ËË2 3
>
ËË3 4
AddPlotSize
ËË5 @
(
ËË@ A
[
ËËA B
FromBody
ËËB J
]
ËËJ K
PlotSizeCreateDto
ËËL ]
values
ËË^ d
)
ËËd e
{
ÈÈ 
try
ÍÍ 
{
ÎÎ 	
return
ÏÏ 
Ok
ÏÏ 
(
ÏÏ 
await
ÏÏ 
_plotSizeService
ÏÏ ,
.
ÏÏ, -
AddPlotSizeAsync
ÏÏ- =
(
ÏÏ= >
values
ÏÏ> D
)
ÏÏD E
)
ÏÏE F
;
ÏÏF G
}
ÌÌ 	
catch
ÓÓ 
(
ÓÓ 
	Exception
ÓÓ 
ex
ÓÓ 
)
ÓÓ 
{
ÔÔ 	
return
 

StatusCode
 
(
 
$num
 !
,
! "
ex
# %
.
% &
InnerException
& 4
!
4 5
.
5 6
Message
6 =
)
= >
;
> ?
}
ÒÒ 	
}
ÚÚ 
[
¯¯ 
HttpPut
¯¯ 
]
¯¯ 
[
˘˘ 
Route
˘˘ 

(
˘˘
 
$str
˘˘ 
)
˘˘ 
]
˘˘ 
public
˙˙ 

async
˙˙ 
Task
˙˙ 
<
˙˙ 
ActionResult
˙˙ "
<
˙˙" #
PlotSizeReadDto
˙˙# 2
>
˙˙2 3
>
˙˙3 4
UpdatePlotSize
˙˙5 C
(
˙˙C D
[
˙˙D E
FromBody
˙˙E M
]
˙˙M N
PlotSizeUpdateDto
˙˙O `
values
˙˙a g
)
˙˙g h
{
˚˚ 
return
¸¸ 
Ok
¸¸ 
(
¸¸ 
await
¸¸ 
_plotSizeService
¸¸ (
.
¸¸( )!
UpdatePlotSizeAsync
¸¸) <
(
¸¸< =
values
¸¸= C
)
¸¸C D
)
¸¸D E
;
¸¸E F
}
˝˝ 
[
ˇˇ 

HttpDelete
ˇˇ 
(
ˇˇ 
$str
ˇˇ -
)
ˇˇ- .
]
ˇˇ. /
public
ÄÄ 

void
ÄÄ 
DeletePlotSize
ÄÄ 
(
ÄÄ 
int
ÄÄ "

localityId
ÄÄ# -
)
ÄÄ- .
{
ÅÅ 
}
ÇÇ 
[
àà 
HttpGet
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ $
)
ââ$ %
]
ââ% &
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" #
IEnumerable
ää# .
<
ää. /#
PropertyHeightReadDto
ää/ D
>
ääD E
>
ääE F
>
ääF G
GetPropertyHeight
ääH Y
(
ääY Z
)
ääZ [
{
ãã 
return
åå 
Ok
åå 
(
åå 
await
åå $
_propertyHeightService
åå .
.
åå. /$
GetPropertyHeightAsync
åå/ E
(
ååE F
)
ååF G
)
ååG H
;
ååH I
}
çç 
[
°° 
HttpPost
°° 
]
°° 
[
¢¢ 
Route
¢¢ 

(
¢¢
 
$str
¢¢ !
)
¢¢! "
]
¢¢" #
public
££ 

async
££ 
Task
££ 
<
££ 
ActionResult
££ "
<
££" ##
PropertyHeightReadDto
££# 8
>
££8 9
>
££9 :"
CreatePropertyHeight
££; O
(
££O P
[
££P Q
FromBody
££Q Y
]
££Y Z%
PropertyHeightCreateDto
££[ r
values
££s y
)
££y z
{
§§ 
try
•• 
{
¶¶ 	
return
ßß 
Ok
ßß 
(
ßß 
await
ßß $
_propertyHeightService
ßß 2
.
ßß2 3$
AddPropertyHeightAsync
ßß3 I
(
ßßI J
values
ßßJ P
)
ßßP Q
)
ßßQ R
;
ßßR S
}
®® 	
catch
©© 
(
©© 
	Exception
©© 
ex
©© 
)
©© 
{
™™ 	
return
´´ 

StatusCode
´´ 
(
´´ 
$num
´´ !
,
´´! "
ex
´´# %
.
´´% &
InnerException
´´& 4
!
´´4 5
.
´´5 6
Message
´´6 =
)
´´= >
;
´´> ?
}
¨¨ 	
}
≠≠ 
[
≥≥ 
HttpPut
≥≥ 
]
≥≥ 
[
¥¥ 
Route
¥¥ 

(
¥¥
 
$str
¥¥ !
)
¥¥! "
]
¥¥" #
public
µµ 

async
µµ 
Task
µµ 
<
µµ 
ActionResult
µµ "
<
µµ" ##
PropertyHeightReadDto
µµ# 8
>
µµ8 9
>
µµ9 :"
UpdatePropertyHeight
µµ; O
(
µµO P
[
µµP Q
FromBody
µµQ Y
]
µµY Z%
PropertyHeightUpdateDto
µµ[ r
values
µµs y
)
µµy z
{
∂∂ 
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
await
∑∑ $
_propertyHeightService
∑∑ .
.
∑∑. /'
UpdatePropertyHeightAsync
∑∑/ H
(
∑∑H I
values
∑∑I O
)
∑∑O P
)
∑∑P Q
;
∑∑Q R
}
∏∏ 
[
∫∫ 

HttpDelete
∫∫ 
(
∫∫ 
$str
∫∫ 9
)
∫∫9 :
]
∫∫: ;
public
ªª 

void
ªª "
DeletePropertyHeight
ªª $
(
ªª$ %
int
ªª% (
propertyHeightId
ªª) 9
)
ªª9 :
{
ºº 
}
ºº 
[
¬¬ 
HttpGet
¬¬ 
]
¬¬ 
[
√√ 
Route
√√ 

(
√√
 
$str
√√ "
)
√√" #
]
√√# $
public
ƒƒ 

async
ƒƒ 
Task
ƒƒ 
<
ƒƒ 
ActionResult
ƒƒ "
<
ƒƒ" #
IEnumerable
ƒƒ# .
<
ƒƒ. /!
PropertyTypeReadDto
ƒƒ/ B
>
ƒƒB C
>
ƒƒC D
>
ƒƒD E
GetPropertyType
ƒƒF U
(
ƒƒU V
)
ƒƒV W
{
≈≈ 
return
∆∆ 
Ok
∆∆ 
(
∆∆ 
await
∆∆ "
_propertyTypeService
∆∆ ,
.
∆∆, -"
GetPropertyTypeAsync
∆∆- A
(
∆∆A B
)
∆∆B C
)
∆∆C D
;
∆∆D E
}
«« 
[
…… 
HttpGet
…… 
]
…… 
[
   
Route
   

(
  
 
$str
   *
)
  * +
]
  + ,
public
ÀÀ 

async
ÀÀ 
Task
ÀÀ 
<
ÀÀ 
ActionResult
ÀÀ "
<
ÀÀ" #!
PropertyTypeReadDto
ÀÀ# 6
>
ÀÀ6 7
>
ÀÀ7 8
GetPropertyType
ÀÀ9 H
(
ÀÀH I
string
ÀÀI O
value
ÀÀP U
)
ÀÀU V
{
ÃÃ 
return
ÕÕ 
Ok
ÕÕ 
(
ÕÕ 
await
ÕÕ "
_propertyTypeService
ÕÕ ,
.
ÕÕ, -"
GetPropertyTypeAsync
ÕÕ- A
(
ÕÕA B
value
ÕÕB G
)
ÕÕG H
)
ÕÕH I
;
ÕÕI J
}
ŒŒ 
[
–– 
HttpGet
–– 
]
–– 
[
—— 
Route
—— 

(
——
 
$str
—— 7
)
——7 8
]
——8 9
public
““ 

async
““ 
Task
““ 
<
““ 
ActionResult
““ "
<
““" #!
PropertyTypeReadDto
““# 6
>
““6 7
>
““7 8!
GetPropertyTypeById
““9 L
(
““L M
int
““M P
propertyTypeId
““Q _
)
““_ `
{
”” 
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ "
_propertyTypeService
‘‘ ,
.
‘‘, -"
GetPropertyTypeAsync
‘‘- A
(
‘‘A B
propertyTypeId
‘‘B P
)
‘‘P Q
)
‘‘Q R
;
‘‘R S
}
’’ 
[
ÈÈ 
HttpPost
ÈÈ 
]
ÈÈ 
[
ÍÍ 
Route
ÍÍ 

(
ÍÍ
 
$str
ÍÍ 
)
ÍÍ  
]
ÍÍ  !
public
ÎÎ 

async
ÎÎ 
Task
ÎÎ 
<
ÎÎ 
ActionResult
ÎÎ "
<
ÎÎ" #!
PropertyTypeReadDto
ÎÎ# 6
>
ÎÎ6 7
>
ÎÎ7 8 
CreatePropertyType
ÎÎ9 K
(
ÎÎK L
[
ÎÎL M
FromBody
ÎÎM U
]
ÎÎU V#
PropertyTypeCreateDto
ÎÎW l
values
ÎÎm s
)
ÎÎs t
{
ÏÏ 
try
ÌÌ 
{
ÓÓ 	
return
ÔÔ 
Ok
ÔÔ 
(
ÔÔ 
await
ÔÔ "
_propertyTypeService
ÔÔ 0
.
ÔÔ0 1"
AddPropertyTypeAsync
ÔÔ1 E
(
ÔÔE F
values
ÔÔF L
)
ÔÔL M
)
ÔÔM N
;
ÔÔN O
}
 	
catch
ÒÒ 
(
ÒÒ 
	Exception
ÒÒ 
ex
ÒÒ 
)
ÒÒ 
{
ÚÚ 	
return
ÛÛ 

StatusCode
ÛÛ 
(
ÛÛ 
$num
ÛÛ !
,
ÛÛ! "
ex
ÛÛ# %
.
ÛÛ% &
InnerException
ÛÛ& 4
!
ÛÛ4 5
.
ÛÛ5 6
Message
ÛÛ6 =
)
ÛÛ= >
;
ÛÛ> ?
}
ÙÙ 	
}
ıı 
[
˚˚ 
HttpPut
˚˚ 
]
˚˚ 
[
¸¸ 
Route
¸¸ 

(
¸¸
 
$str
¸¸ 
)
¸¸  
]
¸¸  !
public
˝˝ 

async
˝˝ 
Task
˝˝ 
<
˝˝ 
ActionResult
˝˝ "
<
˝˝" #!
PropertyTypeReadDto
˝˝# 6
>
˝˝6 7
>
˝˝7 8 
UpdatePropertyType
˝˝9 K
(
˝˝K L
[
˝˝L M
FromBody
˝˝M U
]
˝˝U V#
PropertyTypeUpdateDto
˝˝W l
values
˝˝m s
)
˝˝s t
{
˛˛ 
return
ˇˇ 
Ok
ˇˇ 
(
ˇˇ 
await
ˇˇ "
_propertyTypeService
ˇˇ ,
.
ˇˇ, -%
UpdatePropertyTypeAsync
ˇˇ- D
(
ˇˇD E
values
ˇˇE K
)
ˇˇK L
)
ˇˇL M
;
ˇˇM N
}
Ä	Ä	 
[
Ç	Ç	 

HttpDelete
Ç	Ç	 
(
Ç	Ç	 
$str
Ç	Ç	 5
)
Ç	Ç	5 6
]
Ç	Ç	6 7
public
É	É	 

void
É	É	  
DeletePropertyType
É	É	 "
(
É	É	" #
int
É	É	# &
propertyTypeId
É	É	' 5
)
É	É	5 6
{
Ñ	Ñ	 
}
Ñ	Ñ	 
[
á	á	 
HttpPost
á	á	 
]
á	á	 
[
à	à	 
Route
à	à	 

(
à	à	
 
$str
à	à	 
)
à	à	 
]
à	à	 
public
â	â	 

async
â	â	 
Task
â	â	 
<
â	â	 
ActionResult
â	â	 "
<
â	â	" #!
PropertyTypeReadDto
â	â	# 6
>
â	â	6 7
>
â	â	7 8
CreateProperty
â	â	9 G
(
â	â	G H
[
â	â	H I
FromBody
â	â	I Q
]
â	â	Q R)
PropertyMasterCreatePlotDto
â	â	S n
values
â	â	o u
)
â	â	u v
{
ä	ä	 
try
ã	ã	 
{
å	å	 	
return
ç	ç	 
Ok
ç	ç	 
(
ç	ç	 
await
ç	ç	 $
_propertyMasterService
ç	ç	 2
.
ç	ç	2 3
CreateProperty
ç	ç	3 A
(
ç	ç	A B
values
ç	ç	B H
)
ç	ç	H I
)
ç	ç	I J
;
ç	ç	J K
}
é	é	 	
catch
è	è	 
(
è	è	 
	Exception
è	è	 
ex
è	è	 
)
è	è	 
{
ê	ê	 	
return
ë	ë	 

StatusCode
ë	ë	 
(
ë	ë	 
$num
ë	ë	 !
,
ë	ë	! "
ex
ë	ë	# %
.
ë	ë	% &
InnerException
ë	ë	& 4
!
ë	ë	4 5
.
ë	ë	5 6
Message
ë	ë	6 =
)
ë	ë	= >
;
ë	ë	> ?
}
í	í	 	
}
ì	ì	 
}ï	ï	 Ñ
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/CustomersController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v23 5
{ 
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{ 
}kk 
}ll çÎ
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/CustomerController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v23 5
{ 
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{ 
readonly  
ICustomerTypeService % 
_customerTypeService& :
;: ;
readonly 
IGenderService 
_genderService  .
;. /
readonly &
IIdentificationTypeService +&
_identificationTypeService, F
;F G
readonly 
INationalityService $
_nationalityService% 8
;8 9
readonly  
IResidentTypeService % 
_residentTypeService& :
;: ;
readonly 
ISocialMediaService $
_socialMediaService% 8
;8 9
readonly 
ITitleService 
_titleService ,
;, -
readonly "
ICustomerMasterService '"
_customerMasterService( >
;> ?
public 
CustomerController !
(! " 
ICustomerTypeService" 6
customerTypeService7 J
,J K
IGenderServiceL Z
genderService[ h
,h i'
IIdentificationTypeService	j Ñ'
identificationTypeService
Ö û
,
û ü!
INationalityService
† ≥ 
nationalityService
¥ ∆
,
∆ « 
IResidentTypeService" 6
residentTypeService7 J
,J K
ISocialMediaServiceL _
socialMediaService` r
,r s
ITitleService	t Å
titleService
Ç é
,
é è$
ICustomerMasterService
ê ¶#
customerMasterService
ß º
)
º Ω
{ 	 
_customerTypeService    
=  ! "
customerTypeService  # 6
;  6 7
_genderService!! 
=!! 
genderService!! *
;!!* +&
_identificationTypeService"" &
=""' (%
identificationTypeService"") B
;""B C
_nationalityService## 
=##  !
nationalityService##" 4
;##4 5 
_residentTypeService$$  
=$$! "
residentTypeService$$# 6
;$$6 7
_socialMediaService%% 
=%%  !
socialMediaService%%" 4
;%%4 5
_titleService&& 
=&& 
titleService&& (
;&&( )"
_customerMasterService(( "
=((# $!
customerMasterService((% :
;((: ;
})) 	
[// 	
HttpGet//	 
]// 
[00 	
Route00	 
(00 
$str00 '
)00' (
]00( )
public11 
async11 
Task11 
<11 
ActionResult11 &
<11& '
IEnumerable11' 2
<112 3
CustomerTypeReadDto113 F
>11F G
>11G H
>11H I
GetCustomerTypes11J Z
(11Z [
)11[ \
{22 	
return33 
Ok33 
(33 
await33  
_customerTypeService33 0
.330 1 
GetCustomerTypeAsync331 E
(33E F
)33F G
)33G H
;33H I
}44 	
[66 	
HttpPost66	 
]66 
[77 	
Route77	 
(77 
$str77  
)77  !
]77! "
public88 
async88 
Task88 
<88 
ActionResult88 &
<88& '
CustomerTypeReadDto88' :
>88: ;
>88; <
AddCustomerType88= L
(88L M
[88M N
FromBody88N V
]88V W!
CustomerTypeCreateDto88X m
values88n t
)88t u
{99 	
try:: 
{;; 
return<< 
Ok<< 
(<< 
await<<  
_customerTypeService<<  4
.<<4 5 
AddCustomerTypeAsync<<5 I
(<<I J
values<<J P
)<<P Q
)<<Q R
;<<R S
}== 
catch>> 
(>> 
	Exception>> 
ex>> 
)>>  
{?? 
return@@ 

StatusCode@@ !
(@@! "
$num@@" %
,@@% &
ex@@' )
.@@) *
InnerException@@* 8
!@@8 9
.@@9 :
Message@@: A
)@@A B
;@@B C
}AA 
}BB 	
[DD 	
HttpPutDD	 
]DD 
[EE 	
RouteEE	 
(EE 
$strEE #
)EE# $
]EE$ %
publicFF 
asyncFF 
TaskFF 
<FF 
ActionResultFF &
<FF& '
CustomerTypeReadDtoFF' :
>FF: ;
>FF; <
UpdateCustomerTypeFF= O
(FFO P
[FFP Q
FromBodyFFQ Y
]FFY Z!
CustomerTypeUpdateDtoFF[ p
valuesFFq w
)FFw x
{GG 	
returnHH 
OkHH 
(HH 
awaitHH  
_customerTypeServiceHH 0
.HH0 1#
UpdateCustomerTypeAsyncHH1 H
(HHH I
valuesHHI O
)HHO P
)HHP Q
;HHQ R
}II 	
[KK 	

HttpDeleteKK	 
(KK 
$strKK 9
)KK9 :
]KK: ;
publicLL 
voidLL 
DeleteCustomerTypeLL &
(LL& '
intLL' *
customerTypeIdLL+ 9
)LL9 :
{MM 	
}NN 	
[TT 	
HttpGetTT	 
]TT 
[UU 	
RouteUU	 
(UU 
$strUU !
)UU! "
]UU" #
publicVV 
asyncVV 
TaskVV 
<VV 
ActionResultVV &
<VV& '
IEnumerableVV' 2
<VV2 3
GenderReadDtoVV3 @
>VV@ A
>VVA B
>VVB C
	GetGenderVVD M
(VVM N
)VVN O
{WW 	
returnXX 
OkXX 
(XX 
awaitXX 
_genderServiceXX *
.XX* +
GetGenderAsyncXX+ 9
(XX9 :
)XX: ;
)XX; <
;XX< =
}YY 	
[[[ 	
HttpGet[[	 
][[ 
[\\ 	
Route\\	 
(\\ 
$str\\ (
)\\( )
]\\) *
public]] 
async]] 
Task]] 
<]] 
ActionResult]] &
<]]& '
GenderReadDto]]' 4
>]]4 5
>]]5 6
	GetGender]]7 @
(]]@ A
string]]A G
value]]H M
)]]M N
{^^ 	
return__ 
Ok__ 
(__ 
await__ 
_genderService__ *
.__* +
GetGenderAsync__+ 9
(__9 :
value__: ?
)__? @
)__@ A
;__A B
}`` 	
[bb 	
HttpGetbb	 
]bb 
[cc 	
Routecc	 
(cc 
$strcc /
)cc/ 0
]cc0 1
publicdd 
asyncdd 
Taskdd 
<dd 
ActionResultdd &
<dd& '
GenderReadDtodd' 4
>dd4 5
>dd5 6
GetGenderByIddd7 D
(ddD E
intddE H
genderIdddI Q
)ddQ R
{ee 	
returnff 
Okff 
(ff 
awaitff 
_genderServiceff *
.ff* +
GetGenderAsyncff+ 9
(ff9 :
genderIdff: B
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
$strjj 
)jj 
]jj 
publickk 
asynckk 
Taskkk 
<kk 
ActionResultkk &
<kk& '
GenderReadDtokk' 4
>kk4 5
>kk5 6
	AddGenderkk7 @
(kk@ A
[kkA B
FromBodykkB J
]kkJ K
GenderCreateDtokkL [
valueskk\ b
)kkb c
{ll 	
trymm 
{nn 
returnoo 
Okoo 
(oo 
awaitoo 
_genderServiceoo  .
.oo. /
AddGenderAsyncoo/ =
(oo= >
valuesoo> D
)ooD E
)ooE F
;ooF G
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
[ww 	
HttpPutww	 
]ww 
[xx 	
Routexx	 
(xx 
$strxx 
)xx 
]xx 
publicyy 
asyncyy 
Taskyy 
<yy 
ActionResultyy &
<yy& '
GenderReadDtoyy' 4
>yy4 5
>yy5 6
UpdateGenderyy7 C
(yyC D
[yyD E
FromBodyyyE M
]yyM N
GenderUpdateDtoyyO ^
valuesyy_ e
)yye f
{zz 	
return{{ 
Ok{{ 
({{ 
await{{ 
_genderService{{ *
.{{* +
UpdateGenderAsync{{+ <
({{< =
values{{= C
){{C D
){{D E
;{{E F
}|| 	
[~~ 	

HttpDelete~~	 
(~~ 
$str~~ -
)~~- .
]~~. /
public 
void 
DeleteGender  
(  !
int! $
genderId% -
)- .
{
ÄÄ 	
}
ÄÄ
 
[
ÜÜ 	
HttpGet
ÜÜ	 
]
ÜÜ 
[
áá 	
Route
áá	 
(
áá 
$str
áá -
)
áá- .
]
áá. /
public
àà 
async
àà 
Task
àà 
<
àà 
ActionResult
àà &
<
àà& '
IEnumerable
àà' 2
<
àà2 3'
IdentificationTypeReadDto
àà3 L
>
ààL M
>
ààM N
>
ààN O$
GetIdentificationTypes
ààP f
(
ààf g
)
ààg h
{
ââ 	
return
ää 
Ok
ää 
(
ää 
await
ää (
_identificationTypeService
ää 6
.
ää6 7(
GetIdentificationTypeAsync
ää7 Q
(
ääQ R
)
ääR S
)
ääS T
;
ääT U
}
ãã 	
[
çç 	
HttpPost
çç	 
]
çç 
[
éé 	
Route
éé	 
(
éé 
$str
éé &
)
éé& '
]
éé' (
public
èè 
async
èè 
Task
èè 
<
èè 
ActionResult
èè &
<
èè& ''
IdentificationTypeReadDto
èè' @
>
èè@ A
>
èèA B#
AddIdentificationType
èèC X
(
èèX Y
[
èèY Z
FromBody
èèZ b
]
èèb c)
IdentificationTypeCreateDto
èèd 
valuesèèÄ Ü
)èèÜ á
{
êê 	
try
ëë 
{
íí 
return
ìì 
Ok
ìì 
(
ìì 
await
ìì (
_identificationTypeService
ìì  :
.
ìì: ;(
AddIdentificationTypeAsync
ìì; U
(
ììU V
values
ììV \
)
ìì\ ]
)
ìì] ^
;
ìì^ _
}
îî 
catch
ïï 
(
ïï 
	Exception
ïï 
ex
ïï 
)
ïï  
{
ññ 
return
óó 

StatusCode
óó !
(
óó! "
$num
óó" %
,
óó% &
ex
óó' )
.
óó) *
InnerException
óó* 8
!
óó8 9
.
óó9 :
Message
óó: A
)
óóA B
;
óóB C
}
òò 
}
ôô 	
[
õõ 	
HttpPut
õõ	 
]
õõ 
[
úú 	
Route
úú	 
(
úú 
$str
úú )
)
úú) *
]
úú* +
public
ùù 
async
ùù 
Task
ùù 
<
ùù 
ActionResult
ùù &
<
ùù& ''
IdentificationTypeReadDto
ùù' @
>
ùù@ A
>
ùùA B 
UpdateCustomerType
ùùC U
(
ùùU V
[
ùùV W
FromBody
ùùW _
]
ùù_ `)
IdentificationTypeUpdateDto
ùùa |
valuesùù} É
)ùùÉ Ñ
{
ûû 	
return
üü 
Ok
üü 
(
üü 
await
üü (
_identificationTypeService
üü 6
.
üü6 7+
UpdateIdentificationTypeAsync
üü7 T
(
üüT U
values
üüU [
)
üü[ \
)
üü\ ]
;
üü] ^
}
†† 	
[
¢¢ 	

HttpDelete
¢¢	 
(
¢¢ 
$str
¢¢ E
)
¢¢E F
]
¢¢F G
public
££ 
void
££ &
DeleteIdentificationType
££ ,
(
££, -
int
££- 0"
identificationTypeId
££1 E
)
££E F
{
§§ 	
}
•• 	
[
´´ 	
HttpGet
´´	 
]
´´ 
[
¨¨ 	
Route
¨¨	 
(
¨¨ 
$str
¨¨ %
)
¨¨% &
]
¨¨& '
public
≠≠ 
async
≠≠ 
Task
≠≠ 
<
≠≠ 
ActionResult
≠≠ &
<
≠≠& '
IEnumerable
≠≠' 2
<
≠≠2 3 
NationalityReadDto
≠≠3 E
>
≠≠E F
>
≠≠F G
>
≠≠G H
GetNationality
≠≠I W
(
≠≠W X
)
≠≠X Y
{
ÆÆ 	
return
ØØ 
Ok
ØØ 
(
ØØ 
await
ØØ !
_nationalityService
ØØ /
.
ØØ/ 0!
GetNationalityAsync
ØØ0 C
(
ØØC D
)
ØØD E
)
ØØE F
;
ØØF G
}
∞∞ 	
[
≤≤ 	
HttpPost
≤≤	 
]
≤≤ 
[
≥≥ 	
Route
≥≥	 
(
≥≥ 
$str
≥≥ 
)
≥≥  
]
≥≥  !
public
¥¥ 
async
¥¥ 
Task
¥¥ 
<
¥¥ 
ActionResult
¥¥ &
<
¥¥& ' 
NationalityReadDto
¥¥' 9
>
¥¥9 :
>
¥¥: ;
AddNationality
¥¥< J
(
¥¥J K
[
¥¥K L
FromBody
¥¥L T
]
¥¥T U"
NationalityCreateDto
¥¥V j
values
¥¥k q
)
¥¥q r
{
µµ 	
try
∂∂ 
{
∑∑ 
return
∏∏ 
Ok
∏∏ 
(
∏∏ 
await
∏∏ !
_nationalityService
∏∏  3
.
∏∏3 4!
AddNationalityAsync
∏∏4 G
(
∏∏G H
values
∏∏H N
)
∏∏N O
)
∏∏O P
;
∏∏P Q
}
ππ 
catch
∫∫ 
(
∫∫ 
	Exception
∫∫ 
ex
∫∫ 
)
∫∫  
{
ªª 
return
ºº 

StatusCode
ºº !
(
ºº! "
$num
ºº" %
,
ºº% &
ex
ºº' )
.
ºº) *
InnerException
ºº* 8
!
ºº8 9
.
ºº9 :
Message
ºº: A
)
ººA B
;
ººB C
}
ΩΩ 
}
ææ 	
[
¿¿ 	
HttpPut
¿¿	 
]
¿¿ 
[
¡¡ 	
Route
¡¡	 
(
¡¡ 
$str
¡¡ "
)
¡¡" #
]
¡¡# $
public
¬¬ 
async
¬¬ 
Task
¬¬ 
<
¬¬ 
ActionResult
¬¬ &
<
¬¬& ' 
NationalityReadDto
¬¬' 9
>
¬¬9 :
>
¬¬: ;
UpdateNationality
¬¬< M
(
¬¬M N
[
¬¬N O
FromBody
¬¬O W
]
¬¬W X"
NationalityUpdateDto
¬¬Y m
values
¬¬n t
)
¬¬t u
{
√√ 	
return
ƒƒ 
Ok
ƒƒ 
(
ƒƒ 
await
ƒƒ !
_nationalityService
ƒƒ /
.
ƒƒ/ 0$
UpdateNationalityAsync
ƒƒ0 F
(
ƒƒF G
values
ƒƒG M
)
ƒƒM N
)
ƒƒN O
;
ƒƒO P
}
≈≈ 	
[
«« 	

HttpDelete
««	 
(
«« 
$str
«« 7
)
««7 8
]
««8 9
public
»» 
void
»» 
DeleteNationality
»» %
(
»»% &
int
»»& )
nationalityId
»»* 7
)
»»7 8
{
…… 	
}
   	
[
–– 	
HttpGet
––	 
]
–– 
[
—— 	
Route
——	 
(
—— 
$str
—— '
)
——' (
]
——( )
public
““ 
async
““ 
Task
““ 
<
““ 
ActionResult
““ &
<
““& '
IEnumerable
““' 2
<
““2 3!
ResidentTypeReadDto
““3 F
>
““F G
>
““G H
>
““H I
GetResidentTypes
““J Z
(
““Z [
)
““[ \
{
”” 	
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ "
_residentTypeService
‘‘ 0
.
‘‘0 1"
GetResidentTypeAsync
‘‘1 E
(
‘‘E F
)
‘‘F G
)
‘‘G H
;
‘‘H I
}
’’ 	
[
◊◊ 	
HttpPost
◊◊	 
]
◊◊ 
[
ÿÿ 	
Route
ÿÿ	 
(
ÿÿ 
$str
ÿÿ  
)
ÿÿ  !
]
ÿÿ! "
public
ŸŸ 
async
ŸŸ 
Task
ŸŸ 
<
ŸŸ 
ActionResult
ŸŸ &
<
ŸŸ& '!
ResidentTypeReadDto
ŸŸ' :
>
ŸŸ: ;
>
ŸŸ; <
AddResidentType
ŸŸ= L
(
ŸŸL M
[
ŸŸM N
FromBody
ŸŸN V
]
ŸŸV W#
ResidentTypeCreateDto
ŸŸX m
values
ŸŸn t
)
ŸŸt u
{
⁄⁄ 	
try
€€ 
{
‹‹ 
return
›› 
Ok
›› 
(
›› 
await
›› "
_residentTypeService
››  4
.
››4 5"
AddResidentTypeAsync
››5 I
(
››I J
values
››J P
)
››P Q
)
››Q R
;
››R S
}
ﬁﬁ 
catch
ﬂﬂ 
(
ﬂﬂ 
	Exception
ﬂﬂ 
ex
ﬂﬂ 
)
ﬂﬂ  
{
‡‡ 
return
·· 

StatusCode
·· !
(
··! "
$num
··" %
,
··% &
ex
··' )
.
··) *
InnerException
··* 8
!
··8 9
.
··9 :
Message
··: A
)
··A B
;
··B C
}
‚‚ 
}
„„ 	
[
ÂÂ 	
HttpPut
ÂÂ	 
]
ÂÂ 
[
ÊÊ 	
Route
ÊÊ	 
(
ÊÊ 
$str
ÊÊ #
)
ÊÊ# $
]
ÊÊ$ %
public
ÁÁ 
async
ÁÁ 
Task
ÁÁ 
<
ÁÁ 
ActionResult
ÁÁ &
<
ÁÁ& '!
ResidentTypeReadDto
ÁÁ' :
>
ÁÁ: ;
>
ÁÁ; < 
UpdateResidentType
ÁÁ= O
(
ÁÁO P
[
ÁÁP Q
FromBody
ÁÁQ Y
]
ÁÁY Z#
ResidentTypeUpdateDto
ÁÁ[ p
values
ÁÁq w
)
ÁÁw x
{
ËË 	
return
ÈÈ 
Ok
ÈÈ 
(
ÈÈ 
await
ÈÈ "
_residentTypeService
ÈÈ 0
.
ÈÈ0 1%
UpdateResidentTypeAsync
ÈÈ1 H
(
ÈÈH I
values
ÈÈI O
)
ÈÈO P
)
ÈÈP Q
;
ÈÈQ R
}
ÍÍ 	
[
ÏÏ 	

HttpDelete
ÏÏ	 
(
ÏÏ 
$str
ÏÏ 9
)
ÏÏ9 :
]
ÏÏ: ;
public
ÌÌ 
void
ÌÌ  
DeleteResidentType
ÌÌ &
(
ÌÌ& '
int
ÌÌ' *
residentTypeId
ÌÌ+ 9
)
ÌÌ9 :
{
ÓÓ 	
}
ÔÔ 	
[
ıı 	
HttpGet
ıı	 
]
ıı 
[
ˆˆ 	
Route
ˆˆ	 
(
ˆˆ 
$str
ˆˆ %
)
ˆˆ% &
]
ˆˆ& '
public
˜˜ 
async
˜˜ 
Task
˜˜ 
<
˜˜ 
ActionResult
˜˜ &
<
˜˜& '
IEnumerable
˜˜' 2
<
˜˜2 3 
SocialMediaReadDto
˜˜3 E
>
˜˜E F
>
˜˜F G
>
˜˜G H
GetSocialMedia
˜˜I W
(
˜˜W X
)
˜˜X Y
{
¯¯ 	
return
˘˘ 
Ok
˘˘ 
(
˘˘ 
await
˘˘ !
_socialMediaService
˘˘ /
.
˘˘/ 0!
GetSocialMediaAsync
˘˘0 C
(
˘˘C D
)
˘˘D E
)
˘˘E F
;
˘˘F G
}
˙˙ 	
[
¸¸ 	
HttpPost
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ 
)
˝˝  
]
˝˝  !
public
˛˛ 
async
˛˛ 
Task
˛˛ 
<
˛˛ 
ActionResult
˛˛ &
<
˛˛& ' 
SocialMediaReadDto
˛˛' 9
>
˛˛9 :
>
˛˛: ;
AddSocialMedia
˛˛< J
(
˛˛J K
[
˛˛K L
FromBody
˛˛L T
]
˛˛T U"
SocialMediaCreateDto
˛˛V j
values
˛˛k q
)
˛˛q r
{
ˇˇ 	
try
ÄÄ 
{
ÅÅ 
return
ÇÇ 
Ok
ÇÇ 
(
ÇÇ 
await
ÇÇ !
_socialMediaService
ÇÇ  3
.
ÇÇ3 4!
AddSocialMediaAsync
ÇÇ4 G
(
ÇÇG H
values
ÇÇH N
)
ÇÇN O
)
ÇÇO P
;
ÇÇP Q
}
ÉÉ 
catch
ÑÑ 
(
ÑÑ 
	Exception
ÑÑ 
ex
ÑÑ 
)
ÑÑ  
{
ÖÖ 
return
ÜÜ 

StatusCode
ÜÜ !
(
ÜÜ! "
$num
ÜÜ" %
,
ÜÜ% &
ex
ÜÜ' )
.
ÜÜ) *
InnerException
ÜÜ* 8
!
ÜÜ8 9
.
ÜÜ9 :
Message
ÜÜ: A
)
ÜÜA B
;
ÜÜB C
}
áá 
}
àà 	
[
ää 	
HttpPut
ää	 
]
ää 
[
ãã 	
Route
ãã	 
(
ãã 
$str
ãã "
)
ãã" #
]
ãã# $
public
åå 
async
åå 
Task
åå 
<
åå 
ActionResult
åå &
<
åå& ' 
SocialMediaReadDto
åå' 9
>
åå9 :
>
åå: ;
UpdateSocialMedia
åå< M
(
ååM N
[
ååN O
FromBody
ååO W
]
ååW X"
SocialMediaUpdateDto
ååY m
values
åån t
)
ååt u
{
çç 	
return
éé 
Ok
éé 
(
éé 
await
éé !
_socialMediaService
éé /
.
éé/ 0$
UpdateSocialMediaAsync
éé0 F
(
ééF G
values
ééG M
)
ééM N
)
ééN O
;
ééO P
}
èè 	
[
ëë 	

HttpDelete
ëë	 
(
ëë 
$str
ëë 7
)
ëë7 8
]
ëë8 9
public
íí 
void
íí 
DeleteSocialMedia
íí %
(
íí% &
int
íí& )
socialMediaId
íí* 7
)
íí7 8
{
ìì 	
}
îî 	
[
öö 	
HttpGet
öö	 
]
öö 
[
õõ 	
Route
õõ	 
(
õõ 
$str
õõ  
)
õõ  !
]
õõ! "
public
úú 
async
úú 
Task
úú 
<
úú 
ActionResult
úú &
<
úú& '
IEnumerable
úú' 2
<
úú2 3
TitleReadDto
úú3 ?
>
úú? @
>
úú@ A
>
úúA B
	GetTitles
úúC L
(
úúL M
)
úúM N
{
ùù 	
return
ûû 
Ok
ûû 
(
ûû 
await
ûû 
_titleService
ûû )
.
ûû) *
GetTitleAsync
ûû* 7
(
ûû7 8
)
ûû8 9
)
ûû9 :
;
ûû: ;
}
üü 	
[
°° 	
HttpGet
°°	 
]
°° 
[
¢¢ 	
Route
¢¢	 
(
¢¢ 
$str
¢¢ '
)
¢¢' (
]
¢¢( )
public
££ 
async
££ 
Task
££ 
<
££ 
ActionResult
££ &
<
££& '
TitleReadDto
££' 3
>
££3 4
>
££4 5
GetTitle
££6 >
(
££> ?
string
££? E
value
££F K
)
££K L
{
§§ 	
return
•• 
Ok
•• 
(
•• 
await
•• 
_titleService
•• )
.
••) *
GetTitleAsync
••* 7
(
••7 8
value
••8 =
)
••= >
)
••> ?
;
••? @
}
¶¶ 	
[
®® 	
HttpGet
®®	 
]
®® 
[
©© 	
Route
©©	 
(
©© 
$str
©© .
)
©©. /
]
©©/ 0
public
™™ 
async
™™ 
Task
™™ 
<
™™ 
ActionResult
™™ &
<
™™& '
TitleReadDto
™™' 3
>
™™3 4
>
™™4 5
GetTitleById
™™6 B
(
™™B C
int
™™C F
titleId
™™G N
)
™™N O
{
´´ 	
return
¨¨ 
Ok
¨¨ 
(
¨¨ 
await
¨¨ 
_titleService
¨¨ )
.
¨¨) *
GetTitleAsync
¨¨* 7
(
¨¨7 8
titleId
¨¨8 ?
)
¨¨? @
)
¨¨@ A
;
¨¨A B
}
≠≠ 	
[
ØØ 	
HttpPost
ØØ	 
]
ØØ 
[
∞∞ 	
Route
∞∞	 
(
∞∞ 
$str
∞∞ 
)
∞∞ 
]
∞∞ 
public
±± 
async
±± 
Task
±± 
<
±± 
ActionResult
±± &
<
±±& '
TitleReadDto
±±' 3
>
±±3 4
>
±±4 5
AddTitle
±±6 >
(
±±> ?
[
±±? @
FromBody
±±@ H
]
±±H I
TitleCreateDto
±±J X
values
±±Y _
)
±±_ `
{
≤≤ 	
try
≥≥ 
{
¥¥ 
return
µµ 
Ok
µµ 
(
µµ 
await
µµ 
_titleService
µµ  -
.
µµ- .
AddTitleAsync
µµ. ;
(
µµ; <
values
µµ< B
)
µµB C
)
µµC D
;
µµD E
}
∂∂ 
catch
∑∑ 
(
∑∑ 
	Exception
∑∑ 
ex
∑∑ 
)
∑∑  
{
∏∏ 
return
ππ 

StatusCode
ππ !
(
ππ! "
$num
ππ" %
,
ππ% &
ex
ππ' )
.
ππ) *
InnerException
ππ* 8
!
ππ8 9
.
ππ9 :
Message
ππ: A
)
ππA B
;
ππB C
}
∫∫ 
}
ªª 	
[
ΩΩ 	
HttpPut
ΩΩ	 
]
ΩΩ 
[
ææ 	
Route
ææ	 
(
ææ 
$str
ææ 
)
ææ 
]
ææ 
public
øø 
async
øø 
Task
øø 
<
øø 
ActionResult
øø &
<
øø& '
TitleReadDto
øø' 3
>
øø3 4
>
øø4 5
UpdateTitle
øø6 A
(
øøA B
[
øøB C
FromBody
øøC K
]
øøK L
TitleUpdateDto
øøM [
values
øø\ b
)
øøb c
{
¿¿ 	
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ 
_titleService
¡¡ )
.
¡¡) *
UpdateTitleAsync
¡¡* :
(
¡¡: ;
values
¡¡; A
)
¡¡A B
)
¡¡B C
;
¡¡C D
}
¬¬ 	
[
ƒƒ 	

HttpDelete
ƒƒ	 
(
ƒƒ 
$str
ƒƒ +
)
ƒƒ+ ,
]
ƒƒ, -
public
≈≈ 
void
≈≈ 
DeleteTitle
≈≈ 
(
≈≈  
int
≈≈  #
titleId
≈≈$ +
)
≈≈+ ,
{
∆∆ 	
}
∆∆
 
[
…… 	
HttpPost
……	 
]
…… 
[
   	
Route
  	 
(
   
$str
   '
)
  ' (
]
  ( )
public
ÀÀ 
async
ÀÀ 
Task
ÀÀ 
<
ÀÀ 
ActionResult
ÀÀ &
<
ÀÀ& ',
ProspectiveCustomerResponseDto
ÀÀ' E
>
ÀÀE F
>
ÀÀF G$
AddProspectiveCustomer
ÀÀH ^
(
ÀÀ^ _
[
ÀÀ_ `
FromBody
ÀÀ` h
]
ÀÀh i%
ProspectiveCustomerDtoÀÀj Ä
valuesÀÀÅ á
)ÀÀá à
{
ÃÃ 	
try
ÕÕ 
{
ŒŒ 
return
œœ 
Ok
œœ 
(
œœ 
await
œœ $
_customerMasterService
œœ  6
.
œœ6 7
CreateCustomer
œœ7 E
(
œœE F
values
œœF L
)
œœL M
)
œœM N
;
œœN O
}
–– 
catch
—— 
(
—— 
	Exception
—— 
ex
—— 
)
——  
{
““ 
return
”” 

StatusCode
”” !
(
””! "
$num
””" %
,
””% &
ex
””' )
.
””) *
InnerException
””* 8
!
””8 9
.
””9 :
Message
””: A
)
””A B
;
””B C
}
‘‘ 
}
’’ 	
[
◊◊ 	
HttpPost
◊◊	 
]
◊◊ 
[
ÿÿ 	
Route
ÿÿ	 
(
ÿÿ 
$str
ÿÿ #
)
ÿÿ# $
]
ÿÿ$ %
public
ŸŸ 
async
ŸŸ 
Task
ŸŸ 
<
ŸŸ 
ActionResult
ŸŸ &
<
ŸŸ& '(
CompanyCustomerResponseDto
ŸŸ' A
>
ŸŸA B
>
ŸŸB C 
AddCompanyCustomer
ŸŸD V
(
ŸŸV W
[
ŸŸW X
FromBody
ŸŸX `
]
ŸŸ` a&
CreateCompanyCustomerDto
ŸŸb z
valuesŸŸ{ Å
)ŸŸÅ Ç
{
⁄⁄ 	
try
€€ 
{
‹‹ 
return
›› 
Ok
›› 
(
›› 
await
›› $
_customerMasterService
››  6
.
››6 7
CreateCustomer
››7 E
(
››E F
values
››F L
)
››L M
)
››M N
;
››N O
}
ﬁﬁ 
catch
ﬂﬂ 
(
ﬂﬂ 
	Exception
ﬂﬂ 
ex
ﬂﬂ 
)
ﬂﬂ  
{
‡‡ 
return
·· 

StatusCode
·· !
(
··! "
$num
··" %
,
··% &
ex
··' )
.
··) *
InnerException
··* 8
!
··8 9
.
··9 :
Message
··: A
)
··A B
;
··B C
}
‚‚ 
}
„„ 	
}
ÊÊ 
}ÁÁ ⁄í
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v13 5
;5 6
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class 
PropertyController 
:  !
ControllerBase" 0
{ 
public 

readonly "
IAllocationTypeService *"
_allocationTypeService+ A
;A B
public 

readonly !
IApartmentTypeService )!
_apartmentTypeService* ?
;? @
readonly 
IBlockNumberService  
_blockNumberService! 4
;4 5
readonly 
IBlockSideService 
_blockSideService 0
;0 1
readonly 
IBlockTypeService 
_blockTypeService 0
;0 1
readonly 
IBlockUnitService 
_blockUnitService 0
;0 1
readonly 
IFacilitiesService 
_facilitiesService  2
;2 3
readonly "
IFloorNumberingService #"
_floorNumberingService$ :
;: ;
readonly 
ILandUseService 
_landUseService ,
;, -
readonly   
ILandUseTypeService    
_landUseTypeService  ! 4
;  4 5
readonly!! 
ILocalityService!! 
_localityService!! .
;!!. /
readonly"" 
IPlotSizeService"" 
_plotSizeService"" .
;"". /
readonly## "
IPropertyHeightService## #"
_propertyHeightService##$ :
;##: ;
readonly$$  
IPropertyTypeService$$ ! 
_propertyTypeService$$" 6
;$$6 7
readonly&& 
IActivityService&& 
_activityService&& .
;&&. /
readonly''  
IActivityTypeService'' ! 
_activityTypeService''" 6
;''6 7
readonly)) "
IPropertyMasterService)) #"
_propertyMasterService))$ :
;)): ;
public-- 

PropertyController-- 
(-- "
IAllocationTypeService-- 4!
allocationTypeService--5 J
,--J K
ILandUseService--L [
landUseService--\ j
,--j k
ILandUseTypeService--l  
landUseTypeService
--Ä í
,
--í ì
ILocalityService
--î §
localityService
--• ¥
,
--¥ µ
IPlotSizeService
--∂ ∆
plotSizeService
--« ÷
,
--÷ ◊!
IApartmentTypeService.. 3 
apartmentTypeService..4 H
,..H I
IFacilitiesService..J \
facilitiesService..] n
,..n o#
IFloorNumberingService	..p Ü#
floorNumberingService
..á ú
,
..ú ù"
IPropertyTypeService
..û ≤!
propertyTypeService
..≥ ∆
,
..∆ «$
IPropertyHeightService
..» ﬁ#
propertyHeightService
..ﬂ Ù
,
..Ù ı
IBlockNumberService// 1
blockNumberService//2 D
,//D E
IBlockSideService//F W
blockSideService//X h
,//h i
IBlockTypeService//j {
blockTypeService	//| å
,
//å ç
IBlockUnitService
//é ü
blockUnitService
//† ∞
,
//∞ ±
IActivityService00 .
activityService00/ >
,00> ? 
IActivityTypeService00@ T
activityTypeService00U h
,00h i#
IPropertyMasterService	00j Ä#
propertyMasterService
00Å ñ
)
00ñ ó
{11 "
_allocationTypeService22 
=22  !
allocationTypeService22! 6
;226 7!
_apartmentTypeService33 
=33  
apartmentTypeService33  4
;334 5
_blockNumberService55 
=55 
blockNumberService55 0
;550 1
_blockSideService66 
=66 
blockSideService66 ,
;66, -
_blockTypeService77 
=77 
blockTypeService77 ,
;77, -
_blockUnitService88 
=88 
blockUnitService88 ,
;88, -
_facilitiesService:: 
=:: 
facilitiesService:: .
;::. /"
_floorNumberingService;; 
=;;  !
floorNumberingService;;! 6
;;;6 7
_landUseService<< 
=<< 
landUseService<< (
;<<( )
_landUseTypeService== 
=== 
landUseTypeService== 0
;==0 1
_localityService>> 
=>> 
localityService>> *
;>>* +
_plotSizeService?? 
=?? 
plotSizeService?? *
;??* +"
_propertyHeightService@@ 
=@@  !
propertyHeightService@@! 6
;@@6 7 
_propertyTypeServiceAA 
=AA 
propertyTypeServiceAA 2
;AA2 3
_activityServiceCC 
=CC 
activityServiceCC *
;CC* + 
_activityTypeServiceDD 
=DD 
activityTypeServiceDD 2
;DD2 3"
_propertyMasterServiceFF 
=FF  !
propertyMasterServiceFF! 6
;FF6 7
}GG 
[MM 
HttpGetMM 
]MM 
[NN 
RouteNN 

(NN
 
$strNN  
)NN  !
]NN! "
publicOO 

asyncOO 
TaskOO 
<OO 
ActionResultOO "
<OO" #
IEnumerableOO# .
<OO. /
ActivityReadDtoOO/ >
>OO> ?
>OO? @
>OO@ A
GetActivitiesOOB O
(OOO P
)OOP Q
{PP 
returnQQ 
OkQQ 
(QQ 
awaitQQ 
_activityServiceQQ (
.QQ( )
GetActivitiesAsyncQQ) ;
(QQ; <
)QQ< =
)QQ= >
;QQ> ?
}RR 
[jj 
HttpPostjj 
]jj 
[kk 
Routekk 

(kk
 
$strkk 
)kk 
]kk 
publicll 

asyncll 
Taskll 
<ll 
ActionResultll "
<ll" #
ActivityReadDtoll# 2
>ll2 3
>ll3 4
CreateActivityll5 C
(llC D
[llD E
FromBodyllE M
]llM N
ActivityCreateDtollO `
valueslla g
)llg h
{mm 
trynn 
{oo 	
returnpp 
Okpp 
(pp 
awaitpp 
_activityServicepp ,
.pp, -
CreateActivityAsyncpp- @
(pp@ A
valuesppA G
)ppG H
)ppH I
;ppI J
}qq 	
catchrr 
(rr 
	Exceptionrr 
exrr 
)rr 
{ss 	
returntt 

StatusCodett 
(tt 
$numtt !
,tt! "
extt# %
.tt% &
InnerExceptiontt& 4
!tt4 5
.tt5 6
Messagett6 =
)tt= >
;tt> ?
}uu 	
}vv 
[|| 
HttpPut|| 
]|| 
[}} 
Route}} 

(}}
 
$str}} 
)}} 
]}} 
public~~ 

async~~ 
Task~~ 
<~~ 
ActionResult~~ "
<~~" #
ActivityReadDto~~# 2
>~~2 3
>~~3 4
UpdateActivity~~5 C
(~~C D
[~~D E
FromBody~~E M
]~~M N
ActivityUpdateDto~~O `
values~~a g
)~~g h
{ 
return
ÄÄ 
Ok
ÄÄ 
(
ÄÄ 
await
ÄÄ 
_activityService
ÄÄ (
.
ÄÄ( )!
UpdateActivityAsync
ÄÄ) <
(
ÄÄ< =
values
ÄÄ= C
)
ÄÄC D
)
ÄÄD E
;
ÄÄE F
}
ÅÅ 
[
ÉÉ 

HttpDelete
ÉÉ 
(
ÉÉ 
$str
ÉÉ -
)
ÉÉ- .
]
ÉÉ. /
public
ÑÑ 

void
ÑÑ 
DeleteActivity
ÑÑ 
(
ÑÑ 
int
ÑÑ "

activityId
ÑÑ# -
)
ÑÑ- .
{
ÖÖ 
}
ÜÜ 
[
åå 
HttpGet
åå 
]
åå 
[
çç 
Route
çç 

(
çç
 
$str
çç #
)
çç# $
]
çç$ %
public
éé 

async
éé 
Task
éé 
<
éé 
ActionResult
éé "
<
éé" #
IEnumerable
éé# .
<
éé. /!
ActivityTypeReadDto
éé/ B
>
ééB C
>
ééC D
>
ééD E
GetActivityTypes
ééF V
(
ééV W
)
ééW X
{
èè 
return
êê 
Ok
êê 
(
êê 
await
êê "
_activityTypeService
êê ,
.
êê, -"
GetActivityTypeAsync
êê- A
(
êêA B
)
êêB C
)
êêC D
;
êêD E
}
ëë 
[
™™ 
HttpPost
™™ 
]
™™ 
[
´´ 
Route
´´ 

(
´´
 
$str
´´ 
)
´´  
]
´´  !
public
¨¨ 

async
¨¨ 
Task
¨¨ 
<
¨¨ 
ActionResult
¨¨ "
<
¨¨" #!
ActivityTypeReadDto
¨¨# 6
>
¨¨6 7
>
¨¨7 8 
CreateActivityType
¨¨9 K
(
¨¨K L
[
¨¨L M
FromBody
¨¨M U
]
¨¨U V#
ActivityTypeCreateDto
¨¨W l
values
¨¨m s
)
¨¨s t
{
≠≠ 
try
ÆÆ 
{
ØØ 	
return
∞∞ 
Ok
∞∞ 
(
∞∞ 
await
∞∞ "
_activityTypeService
∞∞ 0
.
∞∞0 1%
CreateActivityTypeAsync
∞∞1 H
(
∞∞H I
values
∞∞I O
)
∞∞O P
)
∞∞P Q
;
∞∞Q R
}
±± 	
catch
≤≤ 
(
≤≤ 
	Exception
≤≤ 
ex
≤≤ 
)
≤≤ 
{
≥≥ 	
return
¥¥ 

StatusCode
¥¥ 
(
¥¥ 
$num
¥¥ !
,
¥¥! "
ex
¥¥# %
.
¥¥% &
InnerException
¥¥& 4
!
¥¥4 5
.
¥¥5 6
Message
¥¥6 =
)
¥¥= >
;
¥¥> ?
}
µµ 	
}
∂∂ 
[
ºº 
HttpPut
ºº 
]
ºº 
[
ΩΩ 
Route
ΩΩ 

(
ΩΩ
 
$str
ΩΩ 
)
ΩΩ  
]
ΩΩ  !
public
ææ 

async
ææ 
Task
ææ 
<
ææ 
ActionResult
ææ "
<
ææ" #!
ActivityTypeReadDto
ææ# 6
>
ææ6 7
>
ææ7 8 
UpdateActivityType
ææ9 K
(
ææK L
[
ææL M
FromBody
ææM U
]
ææU V#
ActivityTypeUpdateDto
ææW l
values
ææm s
)
ææs t
{
øø 
return
¿¿ 
Ok
¿¿ 
(
¿¿ 
await
¿¿ "
_activityTypeService
¿¿ ,
.
¿¿, -%
UpdateActivityTypeAsync
¿¿- D
(
¿¿D E
values
¿¿E K
)
¿¿K L
)
¿¿L M
;
¿¿M N
}
¡¡ 
[
√√ 

HttpDelete
√√ 
(
√√ 
$str
√√ 5
)
√√5 6
]
√√6 7
public
ƒƒ 

void
ƒƒ  
DeleteActivityType
ƒƒ "
(
ƒƒ" #
int
ƒƒ# &
activityTypeId
ƒƒ' 5
)
ƒƒ5 6
{
≈≈ 
}
∆∆ 
[
”” 
HttpGet
”” 
]
”” 
[
‘‘ 
Route
‘‘ 

(
‘‘
 
$str
‘‘ $
)
‘‘$ %
]
‘‘% &
public
’’ 

async
’’ 
Task
’’ 
<
’’ 
ActionResult
’’ "
<
’’" #
IEnumerable
’’# .
<
’’. /#
AllocationTypeReadDto
’’/ D
>
’’D E
>
’’E F
>
’’F G
GetAllocationType
’’H Y
(
’’Y Z
)
’’Z [
{
÷÷ 
return
◊◊ 
Ok
◊◊ 
(
◊◊ 
await
◊◊ $
_allocationTypeService
◊◊ .
.
◊◊. /$
GetAllocationTypeAsync
◊◊/ E
(
◊◊E F
)
◊◊F G
)
◊◊G H
;
◊◊H I
}
ÿÿ 
[
⁄⁄ 
HttpGet
⁄⁄ 
]
⁄⁄ 
[
€€ 
Route
€€ 

(
€€
 
$str
€€ 5
)
€€5 6
]
€€6 7
public
‹‹ 

async
‹‹ 
Task
‹‹ 
<
‹‹ 
ActionResult
‹‹ "
<
‹‹" ##
AllocationTypeReadDto
‹‹# 8
>
‹‹8 9
>
‹‹9 :
GetAllocationType
‹‹; L
(
‹‹L M
string
‹‹M S
allocationType
‹‹T b
)
‹‹b c
{
›› 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ $
_allocationTypeService
ﬁﬁ .
.
ﬁﬁ. /$
GetAllocationTypeAsync
ﬁﬁ/ E
(
ﬁﬁE F
allocationType
ﬁﬁF T
)
ﬁﬁT U
)
ﬁﬁU V
;
ﬁﬁV W
}
ﬂﬂ 
[
·· 
HttpGet
·· 
]
·· 
[
‚‚ 
Route
‚‚ 

(
‚‚
 
$str
‚‚ ;
)
‚‚; <
]
‚‚< =
public
„„ 

async
„„ 
Task
„„ 
<
„„ 
ActionResult
„„ "
<
„„" ##
AllocationTypeReadDto
„„# 8
>
„„8 9
>
„„9 :#
GetAllocationTypeById
„„; P
(
„„P Q
int
„„Q T
allocationTypeId
„„U e
)
„„e f
{
‰‰ 
return
ÂÂ 
Ok
ÂÂ 
(
ÂÂ 
await
ÂÂ $
_allocationTypeService
ÂÂ .
.
ÂÂ. /$
GetAllocationTypeAsync
ÂÂ/ E
(
ÂÂE F
allocationTypeId
ÂÂF V
)
ÂÂV W
)
ÂÂW X
;
ÂÂX Y
}
ÊÊ 
[
ˇˇ 
HttpPost
ˇˇ 
]
ˇˇ 
[
ÄÄ 
Route
ÄÄ 

(
ÄÄ
 
$str
ÄÄ !
)
ÄÄ! "
]
ÄÄ" #
public
ÅÅ 

async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ "
<
ÅÅ" ##
AllocationTypeReadDto
ÅÅ# 8
>
ÅÅ8 9
>
ÅÅ9 :"
CreateAllocationType
ÅÅ; O
(
ÅÅO P
[
ÅÅP Q
FromBody
ÅÅQ Y
]
ÅÅY Z%
AllocationTypeCreateDto
ÅÅ[ r
values
ÅÅs y
)
ÅÅy z
{
ÇÇ 
try
ÉÉ 
{
ÑÑ 	
return
ÖÖ 
Ok
ÖÖ 
(
ÖÖ 
await
ÖÖ $
_allocationTypeService
ÖÖ 2
.
ÖÖ2 3$
AddAllocationTypeAsync
ÖÖ3 I
(
ÖÖI J
values
ÖÖJ P
)
ÖÖP Q
)
ÖÖQ R
;
ÖÖR S
}
ÜÜ 	
catch
áá 
(
áá 
	Exception
áá 
ex
áá 
)
áá 
{
àà 	
return
ââ 

StatusCode
ââ 
(
ââ 
$num
ââ !
,
ââ! "
new
ââ# &
{
ââ' (
detail
ââ) /
=
ââ0 1
ex
ââ2 4
.
ââ4 5
Message
ââ5 <
}
ââ= >
)
ââ> ?
;
ââ? @
}
ää 	
}
ãã 
[
ëë 
HttpPut
ëë 
]
ëë 
[
íí 
Route
íí 

(
íí
 
$str
íí !
)
íí! "
]
íí" #
public
ìì 

async
ìì 
Task
ìì 
<
ìì 
ActionResult
ìì "
<
ìì" ##
AllocationTypeReadDto
ìì# 8
>
ìì8 9
>
ìì9 :"
UpdateAllocationType
ìì; O
(
ììO P
[
ììP Q
FromBody
ììQ Y
]
ììY Z%
AllocationTypeUpdateDto
ìì[ r
values
ììs y
)
ììy z
{
îî 
return
ïï 
Ok
ïï 
(
ïï 
await
ïï $
_allocationTypeService
ïï .
.
ïï. /'
UpdateAllocationTypeAsync
ïï/ H
(
ïïH I
values
ïïI O
)
ïïO P
)
ïïP Q
;
ïïQ R
}
ññ 
[
òò 

HttpDelete
òò 
(
òò 
$str
òò 9
)
òò9 :
]
òò: ;
public
ôô 

void
ôô "
DeleteAllocationType
ôô $
(
ôô$ %
int
ôô% (
allocationTypeId
ôô) 9
)
ôô9 :
{
öö 
}
õõ 
[
°° 
HttpGet
°° 
]
°° 
[
¢¢ 
Route
¢¢ 

(
¢¢
 
$str
¢¢ #
)
¢¢# $
]
¢¢$ %
public
££ 

async
££ 
Task
££ 
<
££ 
ActionResult
££ "
<
££" #
IEnumerable
££# .
<
££. /"
ApartmentTypeReadDto
££/ C
>
££C D
>
££D E
>
££E F
GetApartmentType
££G W
(
££W X
)
££X Y
{
§§ 
return
•• 
Ok
•• 
(
•• 
await
•• #
_apartmentTypeService
•• -
.
••- .#
GetApartmentTypeAsync
••. C
(
••C D
)
••D E
)
••E F
;
••F G
}
¶¶ 
[
®® 
HttpGet
®® 
]
®® 
[
©© 
Route
©© 

(
©©
 
$str
©© 3
)
©©3 4
]
©©4 5
public
™™ 

async
™™ 
Task
™™ 
<
™™ 
ActionResult
™™ "
<
™™" ##
AllocationTypeReadDto
™™# 8
>
™™8 9
>
™™9 :
GetApartmentType
™™; K
(
™™K L
string
™™L R
apartmentType
™™S `
)
™™` a
{
´´ 
return
¨¨ 
Ok
¨¨ 
(
¨¨ 
await
¨¨ #
_apartmentTypeService
¨¨ -
.
¨¨- .#
GetApartmentTypeAsync
¨¨. C
(
¨¨C D
apartmentType
¨¨D Q
)
¨¨Q R
)
¨¨R S
;
¨¨S T
}
≠≠ 
[
ØØ 
HttpGet
ØØ 
]
ØØ 
[
∞∞ 
Route
∞∞ 

(
∞∞
 
$str
∞∞ 9
)
∞∞9 :
]
∞∞: ;
public
±± 

async
±± 
Task
±± 
<
±± 
ActionResult
±± "
<
±±" ##
AllocationTypeReadDto
±±# 8
>
±±8 9
>
±±9 :"
GetApartmentTypeById
±±; O
(
±±O P
int
±±P S
apartmentTypeId
±±T c
)
±±c d
{
≤≤ 
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ #
_apartmentTypeService
≥≥ -
.
≥≥- .#
GetApartmentTypeAsync
≥≥. C
(
≥≥C D
apartmentTypeId
≥≥D S
)
≥≥S T
)
≥≥T U
;
≥≥U V
}
¥¥ 
[
ŒŒ 
HttpPost
ŒŒ 
]
ŒŒ 
[
œœ 
Route
œœ 

(
œœ
 
$str
œœ  
)
œœ  !
]
œœ! "
public
–– 

async
–– 
Task
–– 
<
–– 
ActionResult
–– "
<
––" #"
ApartmentTypeReadDto
––# 7
>
––7 8
>
––8 9
AddApartmentType
––: J
(
––J K
[
––K L
FromBody
––L T
]
––T U$
ApartmentTypeCreateDto
––V l
values
––m s
)
––s t
{
—— 
try
““ 
{
”” 	
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ #
_apartmentTypeService
‘‘ 1
.
‘‘1 2#
AddApartmentTypeAsync
‘‘2 G
(
‘‘G H
values
‘‘H N
)
‘‘N O
)
‘‘O P
;
‘‘P Q
}
’’ 	
catch
÷÷ 
(
÷÷ 
	Exception
÷÷ 
ex
÷÷ 
)
÷÷ 
{
◊◊ 	
return
ÿÿ 

StatusCode
ÿÿ 
(
ÿÿ 
$num
ÿÿ !
,
ÿÿ! "
ex
ÿÿ# %
.
ÿÿ% &
InnerException
ÿÿ& 4
!
ÿÿ4 5
.
ÿÿ5 6
Message
ÿÿ6 =
)
ÿÿ= >
;
ÿÿ> ?
}
ŸŸ 	
}
⁄⁄ 
[
ﬂﬂ 
HttpPut
ﬂﬂ 
]
ﬂﬂ 
[
‡‡ 
Route
‡‡ 

(
‡‡
 
$str
‡‡  
)
‡‡  !
]
‡‡! "
public
·· 

async
·· 
Task
·· 
<
·· 
ActionResult
·· "
<
··" #"
ApartmentTypeReadDto
··# 7
>
··7 8
>
··8 9!
UpdateApartmentType
··: M
(
··M N
[
··N O
FromBody
··O W
]
··W X$
ApartmentTypeUpdateDto
··Y o
values
··p v
)
··v w
{
‚‚ 
return
„„ 
Ok
„„ 
(
„„ 
await
„„ #
_apartmentTypeService
„„ -
.
„„- .&
UpdateApartmentTypeAsync
„„. F
(
„„F G
values
„„G M
)
„„M N
)
„„N O
;
„„O P
}
‰‰ 
[
ÊÊ 

HttpDelete
ÊÊ 
(
ÊÊ 
$str
ÊÊ 7
)
ÊÊ7 8
]
ÊÊ8 9
public
ÁÁ 

void
ÁÁ !
DeleteApartmentType
ÁÁ #
(
ÁÁ# $
int
ÁÁ$ '
apartmentTypeId
ÁÁ( 7
)
ÁÁ7 8
{
ËË 
}
ÈÈ 
[
ÔÔ 
HttpGet
ÔÔ 
]
ÔÔ 
[
 
Route
 

(

 
$str
 !
)
! "
]
" #
public
ÒÒ 

async
ÒÒ 
Task
ÒÒ 
<
ÒÒ 
ActionResult
ÒÒ "
<
ÒÒ" #
IEnumerable
ÒÒ# .
<
ÒÒ. / 
BlockNumberReadDto
ÒÒ/ A
>
ÒÒA B
>
ÒÒB C
>
ÒÒC D
GetBlockNumber
ÒÒE S
(
ÒÒS T
)
ÒÒT U
{
ÚÚ 
return
ÛÛ 
Ok
ÛÛ 
(
ÛÛ 
await
ÛÛ !
_blockNumberService
ÛÛ +
.
ÛÛ+ ,!
GetBlockNumberAsync
ÛÛ, ?
(
ÛÛ? @
)
ÛÛ@ A
)
ÛÛA B
;
ÛÛB C
}
ÙÙ 
[
àà 
HttpPost
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ 
)
ââ 
]
ââ  
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" # 
BlockNumberReadDto
ää# 5
>
ää5 6
>
ää6 7
AddBlockNumber
ää8 F
(
ääF G
[
ääG H
FromBody
ääH P
]
ääP Q"
BlockNumberCreateDto
ääR f
values
ääg m
)
ääm n
{
ãã 
try
åå 
{
çç 	
return
éé 
Ok
éé 
(
éé 
await
éé !
_blockNumberService
éé /
.
éé/ 0!
AddBlockNumberAsync
éé0 C
(
ééC D
values
ééD J
)
ééJ K
)
ééK L
;
ééL M
}
èè 	
catch
êê 
(
êê 
	Exception
êê 
ex
êê 
)
êê 
{
ëë 	
return
íí 

StatusCode
íí 
(
íí 
$num
íí !
,
íí! "
ex
íí# %
.
íí% &
InnerException
íí& 4
!
íí4 5
.
íí5 6
Message
íí6 =
)
íí= >
;
íí> ?
}
ìì 	
}
îî 
[
öö 
HttpPut
öö 
]
öö 
[
õõ 
Route
õõ 

(
õõ
 
$str
õõ 
)
õõ 
]
õõ  
public
úú 

async
úú 
Task
úú 
<
úú 
ActionResult
úú "
<
úú" # 
BlockNumberReadDto
úú# 5
>
úú5 6
>
úú6 7
UpdateBlockNumber
úú8 I
(
úúI J
[
úúJ K
FromBody
úúK S
]
úúS T"
BlockNumberUpdateDto
úúU i
values
úúj p
)
úúp q
{
ùù 
return
ûû 
Ok
ûû 
(
ûû 
await
ûû !
_blockNumberService
ûû +
.
ûû+ ,$
UpdateBlockNumberAsync
ûû, B
(
ûûB C
values
ûûC I
)
ûûI J
)
ûûJ K
;
ûûK L
}
üü 
[
°° 

HttpDelete
°° 
(
°° 
$str
°° 0
)
°°0 1
]
°°1 2
public
¢¢ 

void
¢¢ 
DeleteBlockNumber
¢¢ !
(
¢¢! "
int
¢¢" %

facilityId
¢¢& 0
)
¢¢0 1
{
££ 
}
§§ 
[
™™ 
HttpGet
™™ 
]
™™ 
[
´´ 
Route
´´ 

(
´´
 
$str
´´  
)
´´  !
]
´´! "
public
¨¨ 

async
¨¨ 
Task
¨¨ 
<
¨¨ 
ActionResult
¨¨ "
<
¨¨" #
IEnumerable
¨¨# .
<
¨¨. /
BlockSideReadDto
¨¨/ ?
>
¨¨? @
>
¨¨@ A
>
¨¨A B
GetBlockSides
¨¨C P
(
¨¨P Q
)
¨¨Q R
{
≠≠ 
return
ÆÆ 
Ok
ÆÆ 
(
ÆÆ 
await
ÆÆ 
_blockSideService
ÆÆ )
.
ÆÆ) *
GetBlockSideAsync
ÆÆ* ;
(
ÆÆ; <
)
ÆÆ< =
)
ÆÆ= >
;
ÆÆ> ?
}
ØØ 
[
ƒƒ 
HttpPost
ƒƒ 
]
ƒƒ 
[
≈≈ 
Route
≈≈ 

(
≈≈
 
$str
≈≈ 
)
≈≈ 
]
≈≈ 
public
∆∆ 

async
∆∆ 
Task
∆∆ 
<
∆∆ 
ActionResult
∆∆ "
<
∆∆" #
BlockSideReadDto
∆∆# 3
>
∆∆3 4
>
∆∆4 5
AddBlockSide
∆∆6 B
(
∆∆B C
[
∆∆C D
FromBody
∆∆D L
]
∆∆L M 
BlockSideCreateDto
∆∆N `
values
∆∆a g
)
∆∆g h
{
«« 
try
»» 
{
…… 	
return
   
Ok
   
(
   
await
   
_blockSideService
   -
.
  - .
AddBlockSideAsync
  . ?
(
  ? @
values
  @ F
)
  F G
)
  G H
;
  H I
}
ÀÀ 	
catch
ÃÃ 
(
ÃÃ 
	Exception
ÃÃ 
ex
ÃÃ 
)
ÃÃ 
{
ÕÕ 	
return
ŒŒ 

StatusCode
ŒŒ 
(
ŒŒ 
$num
ŒŒ !
,
ŒŒ! "
ex
ŒŒ# %
.
ŒŒ% &
InnerException
ŒŒ& 4
!
ŒŒ4 5
.
ŒŒ5 6
Message
ŒŒ6 =
)
ŒŒ= >
;
ŒŒ> ?
}
œœ 	
}
–– 
[
÷÷ 
HttpPut
÷÷ 
]
÷÷ 
[
◊◊ 
Route
◊◊ 

(
◊◊
 
$str
◊◊ 
)
◊◊ 
]
◊◊ 
public
ÿÿ 

async
ÿÿ 
Task
ÿÿ 
<
ÿÿ 
ActionResult
ÿÿ "
<
ÿÿ" #
BlockSideReadDto
ÿÿ# 3
>
ÿÿ3 4
>
ÿÿ4 5
UpdateBlockSide
ÿÿ6 E
(
ÿÿE F
[
ÿÿF G
FromBody
ÿÿG O
]
ÿÿO P 
BlockSideUpdateDto
ÿÿQ c
values
ÿÿd j
)
ÿÿj k
{
ŸŸ 
return
⁄⁄ 
Ok
⁄⁄ 
(
⁄⁄ 
await
⁄⁄ 
_blockSideService
⁄⁄ )
.
⁄⁄) *"
UpdateBlockSideAsync
⁄⁄* >
(
⁄⁄> ?
values
⁄⁄? E
)
⁄⁄E F
)
⁄⁄F G
;
⁄⁄G H
}
€€ 
[
›› 

HttpDelete
›› 
(
›› 
$str
›› /
)
››/ 0
]
››0 1
public
ﬁﬁ 

void
ﬁﬁ 
DeleteBlockSide
ﬁﬁ 
(
ﬁﬁ  
int
ﬁﬁ  #
blockSideId
ﬁﬁ$ /
)
ﬁﬁ/ 0
{
ﬂﬂ 
}
‡‡ 
[
ÁÁ 
HttpGet
ÁÁ 
]
ÁÁ 
[
ËË 
Route
ËË 

(
ËË
 
$str
ËË  
)
ËË  !
]
ËË! "
public
ÈÈ 

async
ÈÈ 
Task
ÈÈ 
<
ÈÈ 
ActionResult
ÈÈ "
<
ÈÈ" #
IEnumerable
ÈÈ# .
<
ÈÈ. /
BlockTypeReadDto
ÈÈ/ ?
>
ÈÈ? @
>
ÈÈ@ A
>
ÈÈA B
GetBlockTypes
ÈÈC P
(
ÈÈP Q
)
ÈÈQ R
{
ÍÍ 
return
ÎÎ 
Ok
ÎÎ 
(
ÎÎ 
await
ÎÎ 
_blockTypeService
ÎÎ )
.
ÎÎ) *
GetBlockTypeAsync
ÎÎ* ;
(
ÎÎ; <
)
ÎÎ< =
)
ÎÎ= >
;
ÎÎ> ?
}
ÏÏ 
[
ÄÄ 
HttpPost
ÄÄ 
]
ÄÄ 
[
ÅÅ 
Route
ÅÅ 

(
ÅÅ
 
$str
ÅÅ 
)
ÅÅ 
]
ÅÅ 
public
ÇÇ 

async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ "
<
ÇÇ" #
BlockTypeReadDto
ÇÇ# 3
>
ÇÇ3 4
>
ÇÇ4 5
AddBlockType
ÇÇ6 B
(
ÇÇB C
[
ÇÇC D
FromBody
ÇÇD L
]
ÇÇL M 
BlockTypeCreateDto
ÇÇN `
values
ÇÇa g
)
ÇÇg h
{
ÉÉ 
try
ÑÑ 
{
ÖÖ 	
return
ÜÜ 
Ok
ÜÜ 
(
ÜÜ 
await
ÜÜ 
_blockTypeService
ÜÜ -
.
ÜÜ- .
AddBlockTypeAsync
ÜÜ. ?
(
ÜÜ? @
values
ÜÜ@ F
)
ÜÜF G
)
ÜÜG H
;
ÜÜH I
}
áá 	
catch
àà 
(
àà 
	Exception
àà 
ex
àà 
)
àà 
{
ââ 	
return
ää 

StatusCode
ää 
(
ää 
$num
ää !
,
ää! "
ex
ää# %
.
ää% &
InnerException
ää& 4
!
ää4 5
.
ää5 6
Message
ää6 =
)
ää= >
;
ää> ?
}
ãã 	
}
åå 
[
íí 
HttpPut
íí 
]
íí 
[
ìì 
Route
ìì 

(
ìì
 
$str
ìì 
)
ìì 
]
ìì 
public
îî 

async
îî 
Task
îî 
<
îî 
ActionResult
îî "
<
îî" #
BlockTypeReadDto
îî# 3
>
îî3 4
>
îî4 5
UpdateBlockType
îî6 E
(
îîE F
[
îîF G
FromBody
îîG O
]
îîO P 
BlockTypeUpdateDto
îîQ c
values
îîd j
)
îîj k
{
ïï 
return
ññ 
Ok
ññ 
(
ññ 
await
ññ 
_blockTypeService
ññ )
.
ññ) *"
UpdateBlockTypeAsync
ññ* >
(
ññ> ?
values
ññ? E
)
ññE F
)
ññF G
;
ññG H
}
óó 
[
ôô 

HttpDelete
ôô 
(
ôô 
$str
ôô /
)
ôô/ 0
]
ôô0 1
public
öö 

void
öö 
DeleteBlockType
öö 
(
öö  
int
öö  #
blockTypeId
öö$ /
)
öö/ 0
{
õõ 
}
úú 
[
¢¢ 
HttpGet
¢¢ 
]
¢¢ 
[
££ 
Route
££ 

(
££
 
$str
££  
)
££  !
]
££! "
public
§§ 

async
§§ 
Task
§§ 
<
§§ 
ActionResult
§§ "
<
§§" #
IEnumerable
§§# .
<
§§. /
BlockUnitReadDto
§§/ ?
>
§§? @
>
§§@ A
>
§§A B
GetBlockUnits
§§C P
(
§§P Q
)
§§Q R
{
•• 
return
¶¶ 
Ok
¶¶ 
(
¶¶ 
await
¶¶ 
_blockUnitService
¶¶ )
.
¶¶) *
GetBlockUnitAsync
¶¶* ;
(
¶¶; <
)
¶¶< =
)
¶¶= >
;
¶¶> ?
}
ßß 
[
ªª 
HttpPost
ªª 
]
ªª 
[
ºº 
Route
ºº 

(
ºº
 
$str
ºº 
)
ºº 
]
ºº 
public
ΩΩ 

async
ΩΩ 
Task
ΩΩ 
<
ΩΩ 
ActionResult
ΩΩ "
<
ΩΩ" #
BlockUnitReadDto
ΩΩ# 3
>
ΩΩ3 4
>
ΩΩ4 5
CreateBlockUnit
ΩΩ6 E
(
ΩΩE F
[
ΩΩF G
FromBody
ΩΩG O
]
ΩΩO P 
BlockUnitCreateDto
ΩΩQ c
values
ΩΩd j
)
ΩΩj k
{
ææ 
try
øø 
{
¿¿ 	
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ 
_blockUnitService
¡¡ -
.
¡¡- .
AddBlockUnitAsync
¡¡. ?
(
¡¡? @
values
¡¡@ F
)
¡¡F G
)
¡¡G H
;
¡¡H I
}
¬¬ 	
catch
√√ 
(
√√ 
	Exception
√√ 
ex
√√ 
)
√√ 
{
ƒƒ 	
return
≈≈ 

StatusCode
≈≈ 
(
≈≈ 
$num
≈≈ !
,
≈≈! "
ex
≈≈# %
.
≈≈% &
InnerException
≈≈& 4
!
≈≈4 5
.
≈≈5 6
Message
≈≈6 =
)
≈≈= >
;
≈≈> ?
}
∆∆ 	
}
«« 
[
ÕÕ 
HttpPut
ÕÕ 
]
ÕÕ 
[
ŒŒ 
Route
ŒŒ 

(
ŒŒ
 
$str
ŒŒ 
)
ŒŒ 
]
ŒŒ 
public
œœ 

async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ "
<
œœ" #
BlockUnitReadDto
œœ# 3
>
œœ3 4
>
œœ4 5
UpdateBlockUnit
œœ6 E
(
œœE F
[
œœF G
FromBody
œœG O
]
œœO P 
BlockUnitUpdateDto
œœQ c
values
œœd j
)
œœj k
{
–– 
return
—— 
Ok
—— 
(
—— 
await
—— 
_blockUnitService
—— )
.
——) *"
UpdateBlockUnitAsync
——* >
(
——> ?
values
——? E
)
——E F
)
——F G
;
——G H
}
““ 
[
‘‘ 

HttpDelete
‘‘ 
(
‘‘ 
$str
‘‘ /
)
‘‘/ 0
]
‘‘0 1
public
’’ 

void
’’ 
DeleteBlockUnit
’’ 
(
’’  
int
’’  #
blockUnitId
’’$ /
)
’’/ 0
{
÷÷ 
}
◊◊ 
[
›› 
HttpGet
›› 
]
›› 
[
ﬁﬁ 
Route
ﬁﬁ 

(
ﬁﬁ
 
$str
ﬁﬁ  
)
ﬁﬁ  !
]
ﬁﬁ! "
public
ﬂﬂ 

async
ﬂﬂ 
Task
ﬂﬂ 
<
ﬂﬂ 
ActionResult
ﬂﬂ "
<
ﬂﬂ" #
IEnumerable
ﬂﬂ# .
<
ﬂﬂ. /
FacilitiesReadDto
ﬂﬂ/ @
>
ﬂﬂ@ A
>
ﬂﬂA B
>
ﬂﬂB C
GetFacilities
ﬂﬂD Q
(
ﬂﬂQ R
)
ﬂﬂR S
{
‡‡ 
return
·· 
Ok
·· 
(
·· 
await
··  
_facilitiesService
·· *
.
··* + 
GetFacilitiesAsync
··+ =
(
··= >
)
··> ?
)
··? @
;
··@ A
}
‚‚ 
[
ˆˆ 
HttpPost
ˆˆ 
]
ˆˆ 
[
˜˜ 
Route
˜˜ 

(
˜˜
 
$str
˜˜ 
)
˜˜ 
]
˜˜ 
public
¯¯ 

async
¯¯ 
Task
¯¯ 
<
¯¯ 
ActionResult
¯¯ "
<
¯¯" #
FacilitiesReadDto
¯¯# 4
>
¯¯4 5
>
¯¯5 6
CreateFacility
¯¯7 E
(
¯¯E F
[
¯¯F G
FromBody
¯¯G O
]
¯¯O P!
FacilitiesCreateDto
¯¯Q d
values
¯¯e k
)
¯¯k l
{
˘˘ 
try
˙˙ 
{
˚˚ 	
return
¸¸ 
Ok
¸¸ 
(
¸¸ 
await
¸¸  
_facilitiesService
¸¸ .
.
¸¸. / 
AddFacilitiesAsync
¸¸/ A
(
¸¸A B
values
¸¸B H
)
¸¸H I
)
¸¸I J
;
¸¸J K
}
˝˝ 	
catch
˛˛ 
(
˛˛ 
	Exception
˛˛ 
ex
˛˛ 
)
˛˛ 
{
ˇˇ 	
return
ÄÄ 

StatusCode
ÄÄ 
(
ÄÄ 
$num
ÄÄ !
,
ÄÄ! "
ex
ÄÄ# %
.
ÄÄ% &
InnerException
ÄÄ& 4
!
ÄÄ4 5
.
ÄÄ5 6
Message
ÄÄ6 =
)
ÄÄ= >
;
ÄÄ> ?
}
ÅÅ 	
}
ÇÇ 
[
àà 
HttpPut
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ 
)
ââ 
]
ââ 
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" #
FacilitiesReadDto
ää# 4
>
ää4 5
>
ää5 6
UpdateFacility
ää7 E
(
ääE F
[
ääF G
FromBody
ääG O
]
ääO P!
FacilitiesUpdateDto
ääQ d
values
ääe k
)
ääk l
{
ãã 
return
åå 
Ok
åå 
(
åå 
await
åå  
_facilitiesService
åå *
.
åå* +#
UpdateFacilitiesAsync
åå+ @
(
åå@ A
values
ååA G
)
ååG H
)
ååH I
;
ååI J
}
çç 
[
èè 

HttpDelete
èè 
(
èè 
$str
èè -
)
èè- .
]
èè. /
public
êê 

void
êê 
DeleteFacility
êê 
(
êê 
int
êê "

facilityId
êê# -
)
êê- .
{
ëë 
}
íí 
[
òò 
HttpGet
òò 
]
òò 
[
ôô 
Route
ôô 

(
ôô
 
$str
ôô $
)
ôô$ %
]
ôô% &
public
öö 

async
öö 
Task
öö 
<
öö 
ActionResult
öö "
<
öö" #
IEnumerable
öö# .
<
öö. /#
FloorNumberingReadDto
öö/ D
>
ööD E
>
ööE F
>
ööF G
GetFloorNumbering
ööH Y
(
ööY Z
)
ööZ [
{
õõ 
return
úú 
Ok
úú 
(
úú 
await
úú $
_floorNumberingService
úú .
.
úú. /$
GetFloorNumberingAsync
úú/ E
(
úúE F
)
úúF G
)
úúG H
;
úúH I
}
ùù 
[
±± 
HttpPost
±± 
]
±± 
[
≤≤ 
Route
≤≤ 

(
≤≤
 
$str
≤≤ 
)
≤≤ 
]
≤≤  
public
≥≥ 

async
≥≥ 
Task
≥≥ 
<
≥≥ 
ActionResult
≥≥ "
<
≥≥" ##
FloorNumberingReadDto
≥≥# 8
>
≥≥8 9
>
≥≥9 :
CreateFloorNumber
≥≥; L
(
≥≥L M
[
≥≥M N
FromBody
≥≥N V
]
≥≥V W%
FloorNumberingCreateDto
≥≥X o
values
≥≥p v
)
≥≥v w
{
¥¥ 
try
µµ 
{
∂∂ 	
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
await
∑∑ $
_floorNumberingService
∑∑ 2
.
∑∑2 3$
AddFloorNumberingAsync
∑∑3 I
(
∑∑I J
values
∑∑J P
)
∑∑P Q
)
∑∑Q R
;
∑∑R S
}
∏∏ 	
catch
ππ 
(
ππ 
	Exception
ππ 
ex
ππ 
)
ππ 
{
∫∫ 	
return
ªª 

StatusCode
ªª 
(
ªª 
$num
ªª !
,
ªª! "
ex
ªª# %
.
ªª% &
InnerException
ªª& 4
!
ªª4 5
.
ªª5 6
Message
ªª6 =
)
ªª= >
;
ªª> ?
}
ºº 	
}
ΩΩ 
[
√√ 
HttpPut
√√ 
]
√√ 
[
ƒƒ 
Route
ƒƒ 

(
ƒƒ
 
$str
ƒƒ 
)
ƒƒ 
]
ƒƒ  
public
≈≈ 

async
≈≈ 
Task
≈≈ 
<
≈≈ 
ActionResult
≈≈ "
<
≈≈" ##
FloorNumberingReadDto
≈≈# 8
>
≈≈8 9
>
≈≈9 :
UpdateFloorNumber
≈≈; L
(
≈≈L M
[
≈≈M N
FromBody
≈≈N V
]
≈≈V W%
FloorNumberingUpdateDto
≈≈X o
values
≈≈p v
)
≈≈v w
{
∆∆ 
return
«« 
Ok
«« 
(
«« 
await
«« $
_floorNumberingService
«« .
.
««. /'
UpdateFloorNumberingAsync
««/ H
(
««H I
values
««I O
)
««O P
)
««P Q
;
««Q R
}
»» 
[
   

HttpDelete
   
(
   
$str
   3
)
  3 4
]
  4 5
public
ÀÀ 

void
ÀÀ 
DeleteFloorNumber
ÀÀ !
(
ÀÀ! "
int
ÀÀ" %
floorNumberId
ÀÀ& 3
)
ÀÀ3 4
{
ÃÃ 
}
ÕÕ 
[
”” 
HttpGet
”” 
]
”” 
[
‘‘ 
Route
‘‘ 

(
‘‘
 
$str
‘‘ 
)
‘‘ 
]
‘‘ 
public
’’ 

async
’’ 
Task
’’ 
<
’’ 
ActionResult
’’ "
<
’’" #
IEnumerable
’’# .
<
’’. /
LandUseReadDto
’’/ =
>
’’= >
>
’’> ?
>
’’? @

GetLandUse
’’A K
(
’’K L
)
’’L M
{
÷÷ 
return
◊◊ 
Ok
◊◊ 
(
◊◊ 
await
◊◊ 
_landUseService
◊◊ '
.
◊◊' (
GetLandUseAsync
◊◊( 7
(
◊◊7 8
)
◊◊8 9
)
◊◊9 :
;
◊◊: ;
}
ÿÿ 
[
⁄⁄ 
HttpGet
⁄⁄ 
]
⁄⁄ 
[
€€ 
Route
€€ 

(
€€
 
$str
€€ '
)
€€' (
]
€€( )
public
‹‹ 

async
‹‹ 
Task
‹‹ 
<
‹‹ 
ActionResult
‹‹ "
<
‹‹" #
LandUseReadDto
‹‹# 1
>
‹‹1 2
>
‹‹2 3

GetLandUse
‹‹4 >
(
‹‹> ?
string
‹‹? E
landUse
‹‹F M
)
‹‹M N
{
›› 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ 
_landUseService
ﬁﬁ '
.
ﬁﬁ' (
GetLandUseAsync
ﬁﬁ( 7
(
ﬁﬁ7 8
landUse
ﬁﬁ8 ?
)
ﬁﬁ? @
)
ﬁﬁ@ A
;
ﬁﬁA B
}
ﬂﬂ 
[
·· 
HttpGet
·· 
]
·· 
[
‚‚ 
Route
‚‚ 

(
‚‚
 
$str
‚‚ -
)
‚‚- .
]
‚‚. /
public
„„ 

async
„„ 
Task
„„ 
<
„„ 
ActionResult
„„ "
<
„„" #
LandUseReadDto
„„# 1
>
„„1 2
>
„„2 3
GetLandUseById
„„4 B
(
„„B C
int
„„C F
	landUseId
„„G P
)
„„P Q
{
‰‰ 
return
ÂÂ 
Ok
ÂÂ 
(
ÂÂ 
await
ÂÂ 
_landUseService
ÂÂ '
.
ÂÂ' (
GetLandUseAsync
ÂÂ( 7
(
ÂÂ7 8
	landUseId
ÂÂ8 A
)
ÂÂA B
)
ÂÂB C
;
ÂÂC D
}
ÊÊ 
[
ÅÅ 
HttpPost
ÅÅ 
]
ÅÅ 
[
ÇÇ 
Route
ÇÇ 

(
ÇÇ
 
$str
ÇÇ 
)
ÇÇ 
]
ÇÇ 
public
ÉÉ 

async
ÉÉ 
Task
ÉÉ 
<
ÉÉ 
ActionResult
ÉÉ "
<
ÉÉ" #
LandUseReadDto
ÉÉ# 1
>
ÉÉ1 2
>
ÉÉ2 3
CreateLandUse
ÉÉ4 A
(
ÉÉA B
[
ÉÉB C
FromBody
ÉÉC K
]
ÉÉK L
LandUseCreateDto
ÉÉM ]
values
ÉÉ^ d
)
ÉÉd e
{
ÑÑ 
try
ÜÜ 
{
áá 	
return
àà 
Ok
àà 
(
àà 
await
àà 
_landUseService
àà +
.
àà+ ,
AddLandUseAsync
àà, ;
(
àà; <
values
àà< B
)
ààB C
)
ààC D
;
ààD E
}
ââ 	
catch
ää 
(
ää 
	Exception
ää 
ex
ää 
)
ää 
{
ãã 	
return
åå 

StatusCode
åå 
(
åå 
$num
åå !
,
åå! "
ex
åå# %
.
åå% &
InnerException
åå& 4
!
åå4 5
.
åå5 6
Message
åå6 =
)
åå= >
;
åå> ?
}
çç 	
}
éé 
[
îî 
HttpPut
îî 
]
îî 
[
ïï 
Route
ïï 

(
ïï
 
$str
ïï 
)
ïï 
]
ïï 
public
ññ 

async
ññ 
Task
ññ 
<
ññ 
ActionResult
ññ "
<
ññ" #
LandUseReadDto
ññ# 1
>
ññ1 2
>
ññ2 3
UpdateLandUse
ññ4 A
(
ññA B
[
ññB C
FromBody
ññC K
]
ññK L
LandUseUpdateDto
ññM ]
values
ññ^ d
)
ññd e
{
óó 
return
òò 
Ok
òò 
(
òò 
await
òò 
_landUseService
òò '
.
òò' ( 
UpdateLandUseAsync
òò( :
(
òò: ;
values
òò; A
)
òòA B
)
òòB C
;
òòC D
}
ôô 
[
õõ 

HttpDelete
õõ 
(
õõ 
$str
õõ +
)
õõ+ ,
]
õõ, -
public
úú 

void
úú 
DeleteLandUse
úú 
(
úú 
int
úú !
	landUseId
úú" +
)
úú+ ,
{
ùù 
}
ûû 
[
§§ 
HttpGet
§§ 
]
§§ 
[
•• 
Route
•• 

(
••
 
$str
•• !
)
••! "
]
••" #
public
¶¶ 

async
¶¶ 
Task
¶¶ 
<
¶¶ 
ActionResult
¶¶ "
<
¶¶" #
IEnumerable
¶¶# .
<
¶¶. / 
LandUseTypeReadDto
¶¶/ A
>
¶¶A B
>
¶¶B C
>
¶¶C D
GetLandUseType
¶¶E S
(
¶¶S T
)
¶¶T U
{
ßß 
return
®® 
Ok
®® 
(
®® 
await
®® !
_landUseTypeService
®® +
.
®®+ ,!
GetLandUseTypeAsync
®®, ?
(
®®? @
)
®®@ A
)
®®A B
;
®®B C
}
©© 
[
´´ 
HttpGet
´´ 
]
´´ 
[
¨¨ 
Route
¨¨ 

(
¨¨
 
$str
¨¨ +
)
¨¨+ ,
]
¨¨, -
public
≠≠ 

async
≠≠ 
Task
≠≠ 
<
≠≠ 
ActionResult
≠≠ "
<
≠≠" # 
LandUseTypeReadDto
≠≠# 5
>
≠≠5 6
>
≠≠6 7
GetLandUseType
≠≠8 F
(
≠≠F G
string
≠≠G M
landUse
≠≠N U
)
≠≠U V
{
ÆÆ 
return
ØØ 
Ok
ØØ 
(
ØØ 
await
ØØ !
_landUseTypeService
ØØ +
.
ØØ+ ,!
GetLandUseTypeAsync
ØØ, ?
(
ØØ? @
landUse
ØØ@ G
)
ØØG H
)
ØØH I
;
ØØI J
}
∞∞ 
[
≤≤ 
HttpGet
≤≤ 
]
≤≤ 
[
≥≥ 
Route
≥≥ 

(
≥≥
 
$str
≥≥ 5
)
≥≥5 6
]
≥≥6 7
public
¥¥ 

async
¥¥ 
Task
¥¥ 
<
¥¥ 
ActionResult
¥¥ "
<
¥¥" #
LandUseReadDto
¥¥# 1
>
¥¥1 2
>
¥¥2 3 
GetLandUseTypeById
¥¥4 F
(
¥¥F G
int
¥¥G J
	landUseId
¥¥K T
)
¥¥T U
{
µµ 
return
∂∂ 
Ok
∂∂ 
(
∂∂ 
await
∂∂ !
_landUseTypeService
∂∂ +
.
∂∂+ ,!
GetLandUseTypeAsync
∂∂, ?
(
∂∂? @
	landUseId
∂∂@ I
)
∂∂I J
)
∂∂J K
;
∂∂K L
}
∑∑ 
[
œœ 
HttpPost
œœ 
]
œœ 
[
–– 
Route
–– 

(
––
 
$str
–– 
)
–– 
]
––  
public
—— 

async
—— 
Task
—— 
<
—— 
ActionResult
—— "
<
——" # 
LandUseTypeReadDto
——# 5
>
——5 6
>
——6 7
CreateLandUseType
——8 I
(
——I J
[
——J K
FromBody
——K S
]
——S T"
LandUseTypeCreateDto
——U i
values
——j p
)
——p q
{
““ 
try
‘‘ 
{
’’ 	
return
÷÷ 
Ok
÷÷ 
(
÷÷ 
await
÷÷ !
_landUseTypeService
÷÷ /
.
÷÷/ 0!
AddLandUseTypeAsync
÷÷0 C
(
÷÷C D
values
÷÷D J
)
÷÷J K
)
÷÷K L
;
÷÷L M
}
◊◊ 	
catch
ÿÿ 
(
ÿÿ 
	Exception
ÿÿ 
ex
ÿÿ 
)
ÿÿ 
{
ŸŸ 	
return
⁄⁄ 

StatusCode
⁄⁄ 
(
⁄⁄ 
$num
⁄⁄ !
,
⁄⁄! "
ex
⁄⁄# %
.
⁄⁄% &
InnerException
⁄⁄& 4
!
⁄⁄4 5
.
⁄⁄5 6
Message
⁄⁄6 =
)
⁄⁄= >
;
⁄⁄> ?
}
€€ 	
}
‹‹ 
[
‚‚ 
HttpPut
‚‚ 
]
‚‚ 
[
„„ 
Route
„„ 

(
„„
 
$str
„„ 
)
„„ 
]
„„  
public
‰‰ 

async
‰‰ 
Task
‰‰ 
<
‰‰ 
ActionResult
‰‰ "
<
‰‰" #
LandUseReadDto
‰‰# 1
>
‰‰1 2
>
‰‰2 3
UpdateLandUseType
‰‰4 E
(
‰‰E F
[
‰‰F G
FromBody
‰‰G O
]
‰‰O P"
LandUseTypeUpdateDto
‰‰Q e
values
‰‰f l
)
‰‰l m
{
ÂÂ 
return
ÊÊ 
Ok
ÊÊ 
(
ÊÊ 
await
ÊÊ !
_landUseTypeService
ÊÊ +
.
ÊÊ+ ,$
UpdateLandUseTypeAsync
ÊÊ, B
(
ÊÊB C
values
ÊÊC I
)
ÊÊI J
)
ÊÊJ K
;
ÊÊK L
}
ÁÁ 
[
ÈÈ 

HttpDelete
ÈÈ 
(
ÈÈ 
$str
ÈÈ 3
)
ÈÈ3 4
]
ÈÈ4 5
public
ÍÍ 

void
ÍÍ 
DeleteLandUseType
ÍÍ !
(
ÍÍ! "
int
ÍÍ" %
	landUseId
ÍÍ& /
)
ÍÍ/ 0
{
ÎÎ 
}
ÏÏ 
[
ÚÚ 
HttpGet
ÚÚ 
]
ÚÚ 
[
ÛÛ 
Route
ÛÛ 

(
ÛÛ
 
$str
ÛÛ 
)
ÛÛ 
]
ÛÛ  
public
ÙÙ 

async
ÙÙ 
Task
ÙÙ 
<
ÙÙ 
ActionResult
ÙÙ "
<
ÙÙ" #
IEnumerable
ÙÙ# .
<
ÙÙ. /
LocalityReadDto
ÙÙ/ >
>
ÙÙ> ?
>
ÙÙ? @
>
ÙÙ@ A

GeLocality
ÙÙB L
(
ÙÙL M
)
ÙÙM N
{
ıı 
return
ˆˆ 
Ok
ˆˆ 
(
ˆˆ 
await
ˆˆ 
_localityService
ˆˆ (
.
ˆˆ( )
GetLocalityAsync
ˆˆ) 9
(
ˆˆ9 :
)
ˆˆ: ;
)
ˆˆ; <
;
ˆˆ< =
}
˜˜ 
[
˘˘ 
HttpGet
˘˘ 
]
˘˘ 
[
˙˙ 
Route
˙˙ 

(
˙˙
 
$str
˙˙ &
)
˙˙& '
]
˙˙' (
public
˚˚ 

async
˚˚ 
Task
˚˚ 
<
˚˚ 
ActionResult
˚˚ "
<
˚˚" #
LocalityReadDto
˚˚# 2
>
˚˚2 3
>
˚˚3 4
GetLocality
˚˚5 @
(
˚˚@ A
string
˚˚A G
value
˚˚H M
)
˚˚M N
{
¸¸ 
return
˝˝ 
Ok
˝˝ 
(
˝˝ 
await
˝˝ 
_localityService
˝˝ (
.
˝˝( )
GetLocalityAsync
˝˝) 9
(
˝˝9 :
value
˝˝: ?
)
˝˝? @
)
˝˝@ A
;
˝˝A B
}
˛˛ 
[
ÄÄ 
HttpGet
ÄÄ 
]
ÄÄ 
[
ÅÅ 
Route
ÅÅ 

(
ÅÅ
 
$str
ÅÅ /
)
ÅÅ/ 0
]
ÅÅ0 1
public
ÇÇ 

async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ "
<
ÇÇ" #
LocalityReadDto
ÇÇ# 2
>
ÇÇ2 3
>
ÇÇ3 4
GetLocalityById
ÇÇ5 D
(
ÇÇD E
int
ÇÇE H

localityId
ÇÇI S
)
ÇÇS T
{
ÉÉ 
return
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
await
ÑÑ 
_localityService
ÑÑ (
.
ÑÑ( )
GetLocalityAsync
ÑÑ) 9
(
ÑÑ9 :

localityId
ÑÑ: D
)
ÑÑD E
)
ÑÑE F
;
ÑÑF G
}
ÖÖ 
[
ùù 
HttpPost
ùù 
]
ùù 
[
ûû 
Route
ûû 

(
ûû
 
$str
ûû 
)
ûû 
]
ûû 
public
üü 

async
üü 
Task
üü 
<
üü 
ActionResult
üü "
<
üü" #
LocalityReadDto
üü# 2
>
üü2 3
>
üü3 4
CreateLocality
üü5 C
(
üüC D
[
üüD E
FromBody
üüE M
]
üüM N
LocalityCreateDto
üüO `
values
üüa g
)
üüg h
{
†† 
try
°° 
{
¢¢ 	
return
££ 
Ok
££ 
(
££ 
await
££ 
_localityService
££ ,
.
££, -!
CreateLocalityAsync
££- @
(
££@ A
values
££A G
)
££G H
)
££H I
;
££I J
}
§§ 	
catch
•• 
(
•• 
	Exception
•• 
ex
•• 
)
•• 
{
¶¶ 	
return
ßß 

StatusCode
ßß 
(
ßß 
$num
ßß !
,
ßß! "
ex
ßß# %
.
ßß% &
InnerException
ßß& 4
!
ßß4 5
.
ßß5 6
Message
ßß6 =
)
ßß= >
;
ßß> ?
}
®® 	
}
©© 
[
ØØ 
HttpPut
ØØ 
]
ØØ 
[
∞∞ 
Route
∞∞ 

(
∞∞
 
$str
∞∞ 
)
∞∞ 
]
∞∞ 
public
±± 

async
±± 
Task
±± 
<
±± 
ActionResult
±± "
<
±±" #
LocalityReadDto
±±# 2
>
±±2 3
>
±±3 4
UpdateLocality
±±5 C
(
±±C D
[
±±D E
FromBody
±±E M
]
±±M N
LocalityUpdateDto
±±O `
values
±±a g
)
±±g h
{
≤≤ 
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ 
_localityService
≥≥ (
.
≥≥( )!
UpdateLocalityAsync
≥≥) <
(
≥≥< =
values
≥≥= C
)
≥≥C D
)
≥≥D E
;
≥≥E F
}
¥¥ 
[
∂∂ 

HttpDelete
∂∂ 
(
∂∂ 
$str
∂∂ -
)
∂∂- .
]
∂∂. /
public
∑∑ 

void
∑∑ 
DeleteLocality
∑∑ 
(
∑∑ 
int
∑∑ "

localityId
∑∑# -
)
∑∑- .
{
∏∏ 
}
ππ 
[
øø 
HttpGet
øø 
]
øø 
[
¿¿ 
Route
¿¿ 

(
¿¿
 
$str
¿¿ 
)
¿¿ 
]
¿¿  
public
¡¡ 

async
¡¡ 
Task
¡¡ 
<
¡¡ 
ActionResult
¡¡ "
<
¡¡" #
IEnumerable
¡¡# .
<
¡¡. /
PlotSizeReadDto
¡¡/ >
>
¡¡> ?
>
¡¡? @
>
¡¡@ A
GetPlotSize
¡¡B M
(
¡¡M N
)
¡¡N O
{
¬¬ 
return
√√ 
Ok
√√ 
(
√√ 
await
√√ 
_plotSizeService
√√ (
.
√√( )
GetPlotSizeAsync
√√) 9
(
√√9 :
)
√√: ;
)
√√; <
;
√√< =
}
ƒƒ 
[
∆∆ 
HttpGet
∆∆ 
]
∆∆ 
[
«« 
Route
«« 

(
««
 
$str
«« &
)
««& '
]
««' (
public
»» 

async
»» 
Task
»» 
<
»» 
ActionResult
»» "
<
»»" #
PlotSizeReadDto
»»# 2
>
»»2 3
>
»»3 4
GetPlotSize
»»5 @
(
»»@ A
string
»»A G
value
»»H M
)
»»M N
{
…… 
return
   
Ok
   
(
   
await
   
_plotSizeService
   (
.
  ( )
GetPlotSizeAsync
  ) 9
(
  9 :
value
  : ?
)
  ? @
)
  @ A
;
  A B
}
ÀÀ 
[
ÕÕ 
HttpGet
ÕÕ 
]
ÕÕ 
[
ŒŒ 
Route
ŒŒ 

(
ŒŒ
 
$str
ŒŒ /
)
ŒŒ/ 0
]
ŒŒ0 1
public
œœ 

async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ "
<
œœ" #
PlotSizeReadDto
œœ# 2
>
œœ2 3
>
œœ3 4
GetPlotSizeById
œœ5 D
(
œœD E
int
œœE H

plotSizeId
œœI S
)
œœS T
{
–– 
return
—— 
Ok
—— 
(
—— 
await
—— 
_plotSizeService
—— (
.
——( )
GetPlotSizeAsync
——) 9
(
——9 :

plotSizeId
——: D
)
——D E
)
——E F
;
——F G
}
““ 
[
ÊÊ 
HttpPost
ÊÊ 
]
ÊÊ 
[
ÁÁ 
Route
ÁÁ 

(
ÁÁ
 
$str
ÁÁ 
)
ÁÁ 
]
ÁÁ 
public
ËË 

async
ËË 
Task
ËË 
<
ËË 
ActionResult
ËË "
<
ËË" #
PlotSizeReadDto
ËË# 2
>
ËË2 3
>
ËË3 4
AddPlotSize
ËË5 @
(
ËË@ A
[
ËËA B
FromBody
ËËB J
]
ËËJ K
PlotSizeCreateDto
ËËL ]
values
ËË^ d
)
ËËd e
{
ÈÈ 
try
ÍÍ 
{
ÎÎ 	
return
ÏÏ 
Ok
ÏÏ 
(
ÏÏ 
await
ÏÏ 
_plotSizeService
ÏÏ ,
.
ÏÏ, -
AddPlotSizeAsync
ÏÏ- =
(
ÏÏ= >
values
ÏÏ> D
)
ÏÏD E
)
ÏÏE F
;
ÏÏF G
}
ÌÌ 	
catch
ÓÓ 
(
ÓÓ 
	Exception
ÓÓ 
ex
ÓÓ 
)
ÓÓ 
{
ÔÔ 	
return
 

StatusCode
 
(
 
$num
 !
,
! "
ex
# %
.
% &
InnerException
& 4
!
4 5
.
5 6
Message
6 =
)
= >
;
> ?
}
ÒÒ 	
}
ÚÚ 
[
¯¯ 
HttpPut
¯¯ 
]
¯¯ 
[
˘˘ 
Route
˘˘ 

(
˘˘
 
$str
˘˘ 
)
˘˘ 
]
˘˘ 
public
˙˙ 

async
˙˙ 
Task
˙˙ 
<
˙˙ 
ActionResult
˙˙ "
<
˙˙" #
PlotSizeReadDto
˙˙# 2
>
˙˙2 3
>
˙˙3 4
UpdatePlotSize
˙˙5 C
(
˙˙C D
[
˙˙D E
FromBody
˙˙E M
]
˙˙M N
PlotSizeUpdateDto
˙˙O `
values
˙˙a g
)
˙˙g h
{
˚˚ 
return
¸¸ 
Ok
¸¸ 
(
¸¸ 
await
¸¸ 
_plotSizeService
¸¸ (
.
¸¸( )!
UpdatePlotSizeAsync
¸¸) <
(
¸¸< =
values
¸¸= C
)
¸¸C D
)
¸¸D E
;
¸¸E F
}
˝˝ 
[
ˇˇ 

HttpDelete
ˇˇ 
(
ˇˇ 
$str
ˇˇ -
)
ˇˇ- .
]
ˇˇ. /
public
ÄÄ 

void
ÄÄ 
DeletePlotSize
ÄÄ 
(
ÄÄ 
int
ÄÄ "

localityId
ÄÄ# -
)
ÄÄ- .
{
ÅÅ 
}
ÇÇ 
[
àà 
HttpGet
àà 
]
àà 
[
ââ 
Route
ââ 

(
ââ
 
$str
ââ $
)
ââ$ %
]
ââ% &
public
ää 

async
ää 
Task
ää 
<
ää 
ActionResult
ää "
<
ää" #
IEnumerable
ää# .
<
ää. /#
PropertyHeightReadDto
ää/ D
>
ääD E
>
ääE F
>
ääF G
GetPropertyHeight
ääH Y
(
ääY Z
)
ääZ [
{
ãã 
return
åå 
Ok
åå 
(
åå 
await
åå $
_propertyHeightService
åå .
.
åå. /$
GetPropertyHeightAsync
åå/ E
(
ååE F
)
ååF G
)
ååG H
;
ååH I
}
çç 
[
°° 
HttpPost
°° 
]
°° 
[
¢¢ 
Route
¢¢ 

(
¢¢
 
$str
¢¢ !
)
¢¢! "
]
¢¢" #
public
££ 

async
££ 
Task
££ 
<
££ 
ActionResult
££ "
<
££" ##
PropertyHeightReadDto
££# 8
>
££8 9
>
££9 :"
CreatePropertyHeight
££; O
(
££O P
[
££P Q
FromBody
££Q Y
]
££Y Z%
PropertyHeightCreateDto
££[ r
values
££s y
)
££y z
{
§§ 
try
•• 
{
¶¶ 	
return
ßß 
Ok
ßß 
(
ßß 
await
ßß $
_propertyHeightService
ßß 2
.
ßß2 3$
AddPropertyHeightAsync
ßß3 I
(
ßßI J
values
ßßJ P
)
ßßP Q
)
ßßQ R
;
ßßR S
}
®® 	
catch
©© 
(
©© 
	Exception
©© 
ex
©© 
)
©© 
{
™™ 	
return
´´ 

StatusCode
´´ 
(
´´ 
$num
´´ !
,
´´! "
ex
´´# %
.
´´% &
InnerException
´´& 4
!
´´4 5
.
´´5 6
Message
´´6 =
)
´´= >
;
´´> ?
}
¨¨ 	
}
≠≠ 
[
≥≥ 
HttpPut
≥≥ 
]
≥≥ 
[
¥¥ 
Route
¥¥ 

(
¥¥
 
$str
¥¥ !
)
¥¥! "
]
¥¥" #
public
µµ 

async
µµ 
Task
µµ 
<
µµ 
ActionResult
µµ "
<
µµ" ##
PropertyHeightReadDto
µµ# 8
>
µµ8 9
>
µµ9 :"
UpdatePropertyHeight
µµ; O
(
µµO P
[
µµP Q
FromBody
µµQ Y
]
µµY Z%
PropertyHeightUpdateDto
µµ[ r
values
µµs y
)
µµy z
{
∂∂ 
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
await
∑∑ $
_propertyHeightService
∑∑ .
.
∑∑. /'
UpdatePropertyHeightAsync
∑∑/ H
(
∑∑H I
values
∑∑I O
)
∑∑O P
)
∑∑P Q
;
∑∑Q R
}
∏∏ 
[
∫∫ 

HttpDelete
∫∫ 
(
∫∫ 
$str
∫∫ 9
)
∫∫9 :
]
∫∫: ;
public
ªª 

void
ªª "
DeletePropertyHeight
ªª $
(
ªª$ %
int
ªª% (
propertyHeightId
ªª) 9
)
ªª9 :
{
ºº 
}
ºº 
[
¬¬ 
HttpGet
¬¬ 
]
¬¬ 
[
√√ 
Route
√√ 

(
√√
 
$str
√√ "
)
√√" #
]
√√# $
public
ƒƒ 

async
ƒƒ 
Task
ƒƒ 
<
ƒƒ 
ActionResult
ƒƒ "
<
ƒƒ" #
IEnumerable
ƒƒ# .
<
ƒƒ. /!
PropertyTypeReadDto
ƒƒ/ B
>
ƒƒB C
>
ƒƒC D
>
ƒƒD E
GetPropertyType
ƒƒF U
(
ƒƒU V
)
ƒƒV W
{
≈≈ 
return
∆∆ 
Ok
∆∆ 
(
∆∆ 
await
∆∆ "
_propertyTypeService
∆∆ ,
.
∆∆, -"
GetPropertyTypeAsync
∆∆- A
(
∆∆A B
)
∆∆B C
)
∆∆C D
;
∆∆D E
}
«« 
[
…… 
HttpGet
…… 
]
…… 
[
   
Route
   

(
  
 
$str
   *
)
  * +
]
  + ,
public
ÀÀ 

async
ÀÀ 
Task
ÀÀ 
<
ÀÀ 
ActionResult
ÀÀ "
<
ÀÀ" #!
PropertyTypeReadDto
ÀÀ# 6
>
ÀÀ6 7
>
ÀÀ7 8
GetPropertyType
ÀÀ9 H
(
ÀÀH I
string
ÀÀI O
value
ÀÀP U
)
ÀÀU V
{
ÃÃ 
return
ÕÕ 
Ok
ÕÕ 
(
ÕÕ 
await
ÕÕ "
_propertyTypeService
ÕÕ ,
.
ÕÕ, -"
GetPropertyTypeAsync
ÕÕ- A
(
ÕÕA B
value
ÕÕB G
)
ÕÕG H
)
ÕÕH I
;
ÕÕI J
}
ŒŒ 
[
–– 
HttpGet
–– 
]
–– 
[
—— 
Route
—— 

(
——
 
$str
—— 7
)
——7 8
]
——8 9
public
““ 

async
““ 
Task
““ 
<
““ 
ActionResult
““ "
<
““" #!
PropertyTypeReadDto
““# 6
>
““6 7
>
““7 8!
GetPropertyTypeById
““9 L
(
““L M
int
““M P
propertyTypeId
““Q _
)
““_ `
{
”” 
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ "
_propertyTypeService
‘‘ ,
.
‘‘, -"
GetPropertyTypeAsync
‘‘- A
(
‘‘A B
propertyTypeId
‘‘B P
)
‘‘P Q
)
‘‘Q R
;
‘‘R S
}
’’ 
[
ÈÈ 
HttpPost
ÈÈ 
]
ÈÈ 
[
ÍÍ 
Route
ÍÍ 

(
ÍÍ
 
$str
ÍÍ 
)
ÍÍ  
]
ÍÍ  !
public
ÎÎ 

async
ÎÎ 
Task
ÎÎ 
<
ÎÎ 
ActionResult
ÎÎ "
<
ÎÎ" #!
PropertyTypeReadDto
ÎÎ# 6
>
ÎÎ6 7
>
ÎÎ7 8 
CreatePropertyType
ÎÎ9 K
(
ÎÎK L
[
ÎÎL M
FromBody
ÎÎM U
]
ÎÎU V#
PropertyTypeCreateDto
ÎÎW l
values
ÎÎm s
)
ÎÎs t
{
ÏÏ 
try
ÌÌ 
{
ÓÓ 	
return
ÔÔ 
Ok
ÔÔ 
(
ÔÔ 
await
ÔÔ "
_propertyTypeService
ÔÔ 0
.
ÔÔ0 1"
AddPropertyTypeAsync
ÔÔ1 E
(
ÔÔE F
values
ÔÔF L
)
ÔÔL M
)
ÔÔM N
;
ÔÔN O
}
 	
catch
ÒÒ 
(
ÒÒ 
	Exception
ÒÒ 
ex
ÒÒ 
)
ÒÒ 
{
ÚÚ 	
return
ÛÛ 

StatusCode
ÛÛ 
(
ÛÛ 
$num
ÛÛ !
,
ÛÛ! "
ex
ÛÛ# %
.
ÛÛ% &
InnerException
ÛÛ& 4
!
ÛÛ4 5
.
ÛÛ5 6
Message
ÛÛ6 =
)
ÛÛ= >
;
ÛÛ> ?
}
ÙÙ 	
}
ıı 
[
˚˚ 
HttpPut
˚˚ 
]
˚˚ 
[
¸¸ 
Route
¸¸ 

(
¸¸
 
$str
¸¸ 
)
¸¸  
]
¸¸  !
public
˝˝ 

async
˝˝ 
Task
˝˝ 
<
˝˝ 
ActionResult
˝˝ "
<
˝˝" #!
PropertyTypeReadDto
˝˝# 6
>
˝˝6 7
>
˝˝7 8 
UpdatePropertyType
˝˝9 K
(
˝˝K L
[
˝˝L M
FromBody
˝˝M U
]
˝˝U V#
PropertyTypeUpdateDto
˝˝W l
values
˝˝m s
)
˝˝s t
{
˛˛ 
return
ˇˇ 
Ok
ˇˇ 
(
ˇˇ 
await
ˇˇ "
_propertyTypeService
ˇˇ ,
.
ˇˇ, -%
UpdatePropertyTypeAsync
ˇˇ- D
(
ˇˇD E
values
ˇˇE K
)
ˇˇK L
)
ˇˇL M
;
ˇˇM N
}
Ä	Ä	 
[
Ç	Ç	 

HttpDelete
Ç	Ç	 
(
Ç	Ç	 
$str
Ç	Ç	 5
)
Ç	Ç	5 6
]
Ç	Ç	6 7
public
É	É	 

void
É	É	  
DeletePropertyType
É	É	 "
(
É	É	" #
int
É	É	# &
propertyTypeId
É	É	' 5
)
É	É	5 6
{
Ñ	Ñ	 
}
Ñ	Ñ	 
[
á	á	 
HttpPost
á	á	 
]
á	á	 
[
à	à	 
Route
à	à	 

(
à	à	
 
$str
à	à	 
)
à	à	 
]
à	à	 
public
â	â	 

async
â	â	 
Task
â	â	 
<
â	â	 
ActionResult
â	â	 "
<
â	â	" #!
PropertyTypeReadDto
â	â	# 6
>
â	â	6 7
>
â	â	7 8
CreateProperty
â	â	9 G
(
â	â	G H
[
â	â	H I
FromBody
â	â	I Q
]
â	â	Q R)
PropertyMasterCreatePlotDto
â	â	S n
values
â	â	o u
)
â	â	u v
{
ä	ä	 
try
ã	ã	 
{
å	å	 	
return
ç	ç	 
Ok
ç	ç	 
(
ç	ç	 
await
ç	ç	 $
_propertyMasterService
ç	ç	 2
.
ç	ç	2 3
CreateProperty
ç	ç	3 A
(
ç	ç	A B
values
ç	ç	B H
)
ç	ç	H I
)
ç	ç	I J
;
ç	ç	J K
}
é	é	 	
catch
è	è	 
(
è	è	 
	Exception
è	è	 
ex
è	è	 
)
è	è	 
{
ê	ê	 	
return
ë	ë	 

StatusCode
ë	ë	 
(
ë	ë	 
$num
ë	ë	 !
,
ë	ë	! "
ex
ë	ë	# %
.
ë	ë	% &
InnerException
ë	ë	& 4
!
ë	ë	4 5
.
ë	ë	5 6
Message
ë	ë	6 =
)
ë	ë	= >
;
ë	ë	> ?
}
í	í	 	
}
ì	ì	 
}ï	ï	 ≠∏
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomersController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v13 5
{ 
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{ 
[ 	
HttpPost	 
] 
[ 	
Route	 
( 
$str '
)' (
]( )
[ 	
	Authorize	 
( 
Policy 
= 
$str 9
)9 :
]: ;
public   
async   
Task   
<   
ActionResult   &
>  & '"
AddProspectiveCustomer  ( >
(  > ?
[  ? @
FromBody  @ H
]  H I"
ProspectiveCustomerDto  J `
values  a g
)  g h
{!! 	
try"" 
{## 
var&& 
userId&& 
=&& 
_userContextService&& 0
.&&0 1
	GetUserId&&1 :
(&&: ;
)&&; <
;&&< =
if'' 
('' 
!'' 
string'' 
.'' 
Equals'' "
(''" #
userId''# )
,'') *
values''+ 1
.''1 2
	CreatedBy''2 ;
)''; <
)''< =
{(( 
return)) 
Unauthorized)) '
())' (
)))( )
;))) *
}** 
var,, 
result,, 
=,, 
await,, ""
_customerMasterService,,# 9
.,,9 :
CreateCustomer,,: H
(,,H I
values,,I O
),,O P
;,,P Q
if-- 
(-- 
result-- 
.-- 
	IsSuccess-- $
==--% '
true--( ,
)--, -
{.. 
return// 
Ok// 
(// 
result// $
.//$ %
SuccessResponse//% 4
)//4 5
;//5 6
}00 
var22 
status22 
=22 
result22 #
.22# $
ErrorResponse22$ 1
!221 2
.222 3

StatusCode223 =
;22= >
return33 
status33 
switch33 $
{44 
$num55 
=>55 
	NoContent55 $
(55$ %
)55% &
,55& '
$num66 
=>66 

BadRequest66 %
(66% &
result66& ,
.66, -
ErrorResponse66- :
)66: ;
,66; <
$num77 
=>77 
NotFound77 #
(77# $
result77$ *
.77* +
ErrorResponse77+ 8
)778 9
,779 :
_88 
=>88 

StatusCode88 #
(88# $
$num88$ '
,88' (
result88) /
.88/ 0
ErrorResponse880 =
)88= >
,88> ?
}99 
;99 
}:: 
catch;; 
(;; 
	Exception;; 
ex;; 
);;  
{<< 
return== 

StatusCode== !
(==! "
$num==" %
,==% &
ex==' )
.==) *
InnerException==* 8
!==8 9
.==9 :
Message==: A
)==A B
;==B C
}>> 
}?? 	
[AA 	
HttpPostAA	 
]AA 
[BB 	
RouteBB	 
(BB 
$strBB #
)BB# $
]BB$ %
[CC 	
	AuthorizeCC	 
(CC 
PolicyCC 
=CC 
$strCC 9
)CC9 :
]CC: ;
publicDD 
asyncDD 
TaskDD 
<DD 
ActionResultDD &
>DD& '
AddCompanyCustomerDD( :
(DD: ;
[DD; <
FromBodyDD< D
]DDD E$
CreateCompanyCustomerDtoDDF ^
valuesDD_ e
)DDe f
{EE 	
tryFF 
{GG 
varJJ 
userIdJJ 
=JJ 
_userContextServiceJJ 0
.JJ0 1
	GetUserIdJJ1 :
(JJ: ;
)JJ; <
;JJ< =
ifKK 
(KK 
!KK 
stringKK 
.KK 
EqualsKK "
(KK" #
userIdKK# )
,KK) *
valuesKK+ 1
.KK1 2
	CreatedByKK2 ;
)KK; <
)KK< =
{LL 
returnMM 
UnauthorizedMM '
(MM' (
)MM( )
;MM) *
}NN 
varPP 
resultPP 
=PP 
awaitPP ""
_customerMasterServicePP# 9
.PP9 :
CreateCustomerPP: H
(PPH I
valuesPPI O
)PPO P
;PPP Q
ifQQ 
(QQ 
resultQQ 
.QQ 
	IsSuccessQQ #
==QQ$ &
trueQQ' +
)QQ+ ,
{RR 
returnSS 
OkSS 
(SS 
resultSS $
.SS$ %
SuccessResponseSS% 4
)SS4 5
;SS5 6
}TT 
varVV 
statusVV 
=VV 
resultVV #
.VV# $
ErrorResponseVV$ 1
!VV1 2
.VV2 3

StatusCodeVV3 =
;VV= >
returnWW 
statusWW 
switchWW $
{XX 
$numYY 
=>YY 
	NoContentYY $
(YY$ %
)YY% &
,YY& '
$numZZ 
=>ZZ 

BadRequestZZ %
(ZZ% &
resultZZ& ,
.ZZ, -
ErrorResponseZZ- :
)ZZ: ;
,ZZ; <
$num[[ 
=>[[ 
NotFound[[ #
([[# $
result[[$ *
.[[* +
ErrorResponse[[+ 8
)[[8 9
,[[9 :
_\\ 
=>\\ 

StatusCode\\ #
(\\# $
$num\\$ '
,\\' (
result\\) /
.\\/ 0
ErrorResponse\\0 =
)\\= >
,\\> ?
}]] 
;]] 
}__ 
catch`` 
(`` 
	Exception`` 
ex`` 
)``  
{aa 
returnbb 

StatusCodebb !
(bb! "
$numbb" %
,bb% &
exbb' )
.bb) *
InnerExceptionbb* 8
!bb8 9
.bb9 :
Messagebb: A
)bbA B
;bbB C
}cc 
}dd 	
[ff 	
HttpPostff	 
]ff 
[gg 	
Routegg	 
(gg 
$strgg &
)gg& '
]gg' (
[hh 	
	Authorizehh	 
(hh 
Policyhh 
=hh 
$strhh 9
)hh9 :
]hh: ;
publicii 
asyncii 
Taskii 
<ii 
ActionResultii &
>ii& '!
AddIndividualCustomerii( =
(ii= >
[ii> ?
FromBodyii? G
]iiG H)
IndividualResidentCustomerDtoiiI f
valuesiig m
)iim n
{jj 	
trykk 
{ll 
varmm 
userIdmm 
=mm 
_userContextServicemm 0
.mm0 1
	GetUserIdmm1 :
(mm: ;
)mm; <
;mm< =
ifnn 
(nn 
!nn 
stringnn 
.nn 
Equalsnn "
(nn" #
userIdnn# )
,nn) *
valuesnn+ 1
.nn1 2
	CreatedBynn2 ;
)nn; <
)nn< =
{oo 
returnpp 
Unauthorizedpp '
(pp' (
)pp( )
;pp) *
}qq 
ifss 
(ss 
valuesss 
.ss 
CustomerTypeIdss )
==ss* ,
(ss- .
intss. 1
)ss1 2
CustomerTypeEnumss2 B
.ssB C

INDIVIDUALssC M
&&ssN P
valuesssQ W
.ssW X
ResidentTypeIdssX f
==ssg i
(ssj k
intssk n
)ssn o
ResidentTypeEnumsso 
.	ss Ä

EXPATRIATE
ssÄ ä
)
ssä ã
{tt 
ifuu 
(uu 
valuesuu 
.uu 

Expatriateuu )
isuu* ,
nulluu- 1
)uu1 2
{vv 
returnww 

BadRequestww )
(ww) *
$strww* W
)wwW X
;wwX Y
}xx 
ifzz 
(zz 
stringzz 
.zz 
IsNullOrWhiteSpacezz 1
(zz1 2
valueszz2 8
.zz8 9

Expatriatezz9 C
!zzC D
.zzD E 
ResidentPermitNumberzzE Y
)zzY Z
)zzZ [
{{{ 
return|| 

BadRequest|| )
(||) *
$str||* [
)||[ \
;||\ ]
}}} 
}
ÄÄ 
if
ÇÇ 
(
ÇÇ 
values
ÇÇ 
.
ÇÇ 
CustomerTypeId
ÇÇ )
==
ÇÇ* ,
(
ÇÇ- .
int
ÇÇ. 1
)
ÇÇ1 2
CustomerTypeEnum
ÇÇ2 B
.
ÇÇB C

INDIVIDUAL
ÇÇC M
&&
ÇÇN P
values
ÇÇQ W
.
ÇÇW X
ResidentTypeId
ÇÇX f
==
ÇÇg i
(
ÇÇj k
int
ÇÇk n
)
ÇÇn o
ResidentTypeEnum
ÇÇo 
.ÇÇ Ä
NON_RESIDENTÇÇÄ å
)ÇÇå ç
{
ÉÉ 
if
ÑÑ 
(
ÑÑ 
values
ÑÑ 
.
ÑÑ 
NonResident
ÑÑ *
is
ÑÑ+ -
null
ÑÑ. 2
)
ÑÑ2 3
{
ÖÖ 
return
ÜÜ 

BadRequest
ÜÜ )
(
ÜÜ) *
$str
ÜÜ* h
)
ÜÜh i
;
ÜÜi j
}
áá 
if
ââ 
(
ââ 
string
ââ 
.
ââ  
IsNullOrWhiteSpace
ââ 1
(
ââ1 2
values
ââ2 8
.
ââ8 9
NonResident
ââ9 D
!
ââD E
.
ââE F$
ContactPerson_FullName
ââF \
)
ââ\ ]
)
ââ] ^
{
ää 
return
ãã 

BadRequest
ãã )
(
ãã) *
$str
ãã* ^
)
ãã^ _
;
ãã_ `
}
åå 
if
éé 
(
éé 
string
éé 
.
éé  
IsNullOrWhiteSpace
éé 1
(
éé1 2
values
éé2 8
.
éé8 9
NonResident
éé9 D
!
ééD E
.
ééE F(
ContactPerson_EmailAddress
ééF `
)
éé` a
)
ééa b
{
èè 
return
êê 

BadRequest
êê )
(
êê) *
$str
êê* c
)
êêc d
;
êêd e
}
ëë 
if
ìì 
(
ìì 
string
ìì 
.
ìì  
IsNullOrWhiteSpace
ìì 1
(
ìì1 2
values
ìì2 8
.
ìì8 9
NonResident
ìì9 D
!
ììD E
.
ììE F'
ContactPerson_PhoneNumber
ììF _
)
ìì_ `
)
ìì` a
{
îî 
return
ïï 

BadRequest
ïï )
(
ïï) *
$str
ïï* b
)
ïïb c
;
ïïc d
}
ññ 
}
òò 
return
öö 
Ok
öö 
(
öö 
await
öö $
_customerMasterService
öö  6
.
öö6 7
CreateCustomer
öö7 E
(
ööE F
values
ööF L
)
ööL M
)
ööM N
;
ööN O
}
õõ 
catch
úú 
(
úú 
	Exception
úú 
ex
úú 
)
úú  
{
ùù 
return
ûû 

StatusCode
ûû !
(
ûû! "
$num
ûû" %
,
ûû% &
ex
ûû' )
.
ûû) *
InnerException
ûû* 8
!
ûû8 9
.
ûû9 :
Message
ûû: A
)
ûûA B
;
ûûB C
}
üü 
}
†† 	
[
¢¢ 	
HttpPost
¢¢	 
]
¢¢ 
[
££ 	
Route
££	 
(
££ 
$str
££ !
)
££! "
]
££" #
[
§§ 	
	Authorize
§§	 
(
§§ 
Policy
§§ 
=
§§ 
$str
§§ 9
)
§§9 :
]
§§: ;
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
>
••& '
AddJointCustomer
••( 8
(
••8 9
[
••9 :
FromBody
••: B
]
••B C'
JointOwnershipCustomerDto
••D ]
values
••^ d
)
••d e
{
¶¶ 	
try
ßß 
{
®® 
var
©© 
userId
©© 
=
©© !
_userContextService
©© 0
.
©©0 1
	GetUserId
©©1 :
(
©©: ;
)
©©; <
;
©©< =
if
™™ 
(
™™ 
!
™™ 
string
™™ 
.
™™ 
Equals
™™ "
(
™™" #
userId
™™# )
,
™™) *
values
™™+ 1
.
™™1 2
	CreatedBy
™™2 ;
)
™™; <
)
™™< =
{
´´ 
return
¨¨ 
Unauthorized
¨¨ '
(
¨¨' (
)
¨¨( )
;
¨¨) *
}
≠≠ 
var
ØØ 
cnt
ØØ 
=
ØØ 
values
ØØ  
.
ØØ  !
CoLesse
ØØ! (
!
ØØ( )
.
ØØ) *
Count
ØØ* /
(
ØØ/ 0
)
ØØ0 1
;
ØØ1 2
if
∞∞ 
(
∞∞ 
cnt
∞∞ 
==
∞∞ 
$num
∞∞ 
)
∞∞ 
{
±± 
return
≤≤ 

BadRequest
≤≤ %
(
≤≤% &
$str
≤≤& H
)
≤≤H I
;
≤≤I J
}
≥≥ 
if
µµ 
(
µµ 
values
µµ 
.
µµ 
CustomerTypeId
µµ )
==
µµ* ,
(
µµ- .
int
µµ. 1
)
µµ1 2
CustomerTypeEnum
µµ2 B
.
µµB C
JOINT_OWNERSHIP
µµC R
&&
µµS U
values
µµV \
.
µµ\ ]
ResidentTypeId
µµ] k
==
µµl n
(
µµo p
int
µµp s
)
µµs t
ResidentTypeEnumµµt Ñ
.µµÑ Ö

EXPATRIATEµµÖ è
)µµè ê
{
∂∂ 
if
∑∑ 
(
∑∑ 
values
∑∑ 
.
∑∑ 

Expatriate
∑∑ )
is
∑∑* ,
null
∑∑- 1
)
∑∑1 2
{
∏∏ 
return
ππ 

BadRequest
ππ )
(
ππ) *
$str
ππ* W
)
ππW X
;
ππX Y
}
∫∫ 
if
ºº 
(
ºº 
string
ºº 
.
ºº  
IsNullOrWhiteSpace
ºº 1
(
ºº1 2
values
ºº2 8
.
ºº8 9

Expatriate
ºº9 C
!
ººC D
.
ººD E"
ResidentPermitNumber
ººE Y
)
ººY Z
)
ººZ [
{
ΩΩ 
return
ææ 

BadRequest
ææ )
(
ææ) *
$str
ææ* [
)
ææ[ \
;
ææ\ ]
}
øø 
}
¿¿ 
if
¬¬ 
(
¬¬ 
values
¬¬ 
.
¬¬ 
CustomerTypeId
¬¬ )
==
¬¬* ,
(
¬¬- .
int
¬¬. 1
)
¬¬1 2
CustomerTypeEnum
¬¬2 B
.
¬¬B C
JOINT_OWNERSHIP
¬¬C R
&&
¬¬S U
values
¬¬V \
.
¬¬\ ]
ResidentTypeId
¬¬] k
==
¬¬l n
(
¬¬o p
int
¬¬p s
)
¬¬s t
ResidentTypeEnum¬¬t Ñ
.¬¬Ñ Ö
NON_RESIDENT¬¬Ö ë
)¬¬ë í
{
√√ 
if
ƒƒ 
(
ƒƒ 
values
ƒƒ 
.
ƒƒ 
NonResident
ƒƒ *
is
ƒƒ+ -
null
ƒƒ. 2
)
ƒƒ2 3
{
≈≈ 
return
∆∆ 

BadRequest
∆∆ )
(
∆∆) *
$str
∆∆* h
)
∆∆h i
;
∆∆i j
}
«« 
if
…… 
(
…… 
string
…… 
.
……  
IsNullOrWhiteSpace
…… 1
(
……1 2
values
……2 8
.
……8 9
NonResident
……9 D
!
……D E
.
……E F$
ContactPerson_FullName
……F \
)
……\ ]
)
……] ^
{
   
return
ÀÀ 

BadRequest
ÀÀ )
(
ÀÀ) *
$str
ÀÀ* ^
)
ÀÀ^ _
;
ÀÀ_ `
}
ÃÃ 
if
ŒŒ 
(
ŒŒ 
string
ŒŒ 
.
ŒŒ  
IsNullOrWhiteSpace
ŒŒ 1
(
ŒŒ1 2
values
ŒŒ2 8
.
ŒŒ8 9
NonResident
ŒŒ9 D
!
ŒŒD E
.
ŒŒE F(
ContactPerson_EmailAddress
ŒŒF `
)
ŒŒ` a
)
ŒŒa b
{
œœ 
return
–– 

BadRequest
–– )
(
––) *
$str
––* c
)
––c d
;
––d e
}
—— 
if
”” 
(
”” 
string
”” 
.
””  
IsNullOrWhiteSpace
”” 1
(
””1 2
values
””2 8
.
””8 9
NonResident
””9 D
!
””D E
.
””E F'
ContactPerson_PhoneNumber
””F _
)
””_ `
)
””` a
{
‘‘ 
return
’’ 

BadRequest
’’ )
(
’’) *
$str
’’* b
)
’’b c
;
’’c d
}
÷÷ 
}
◊◊ 
return
⁄⁄ 
Ok
⁄⁄ 
(
⁄⁄ 
await
⁄⁄ $
_customerMasterService
⁄⁄  6
.
⁄⁄6 7
CreateCustomer
⁄⁄7 E
(
⁄⁄E F
values
⁄⁄F L
)
⁄⁄L M
)
⁄⁄M N
;
⁄⁄N O
}
€€ 
catch
‹‹ 
(
‹‹ 
	Exception
‹‹ 
ex
‹‹ 
)
‹‹  
{
›› 
return
ﬁﬁ 

StatusCode
ﬁﬁ !
(
ﬁﬁ! "
$num
ﬁﬁ" %
,
ﬁﬁ% &
ex
ﬁﬁ' )
.
ﬁﬁ) *
InnerException
ﬁﬁ* 8
!
ﬁﬁ8 9
.
ﬁﬁ9 :
Message
ﬁﬁ: A
)
ﬁﬁA B
;
ﬁﬁB C
}
ﬂﬂ 
}
‡‡ 	
[
‚‚ 	
HttpPost
‚‚	 
]
‚‚ 
[
„„ 	
Route
„„	 
(
„„ 
$str
„„ !
)
„„! "
]
„„" #
[
‰‰ 	
	Authorize
‰‰	 
(
‰‰ 
Policy
‰‰ 
=
‰‰ 
$str
‰‰ 9
)
‰‰9 :
]
‰‰: ;
public
ÂÂ 
async
ÂÂ 
Task
ÂÂ 
<
ÂÂ 
ActionResult
ÂÂ &
>
ÂÂ& '
AddMultiCustomer
ÂÂ( 8
(
ÂÂ8 9
[
ÂÂ9 :
FromBody
ÂÂ: B
]
ÂÂB C'
MultiOwnershipCustomerDto
ÂÂD ]
values
ÂÂ^ d
)
ÂÂd e
{
ÊÊ 	
try
ÁÁ 
{
ËË 
var
ÈÈ 
userId
ÈÈ 
=
ÈÈ !
_userContextService
ÈÈ 0
.
ÈÈ0 1
	GetUserId
ÈÈ1 :
(
ÈÈ: ;
)
ÈÈ; <
;
ÈÈ< =
if
ÍÍ 
(
ÍÍ 
!
ÍÍ 
string
ÍÍ 
.
ÍÍ 
Equals
ÍÍ "
(
ÍÍ" #
userId
ÍÍ# )
,
ÍÍ) *
values
ÍÍ+ 1
.
ÍÍ1 2
	CreatedBy
ÍÍ2 ;
)
ÍÍ; <
)
ÍÍ< =
{
ÎÎ 
return
ÏÏ 
Unauthorized
ÏÏ '
(
ÏÏ' (
)
ÏÏ( )
;
ÏÏ) *
}
ÌÌ 
var
ÔÔ 
cnt
ÔÔ 
=
ÔÔ 
values
ÔÔ  
.
ÔÔ  !
	Dependent
ÔÔ! *
!
ÔÔ* +
.
ÔÔ+ ,
Count
ÔÔ, 1
(
ÔÔ1 2
)
ÔÔ2 3
;
ÔÔ3 4
if
 
(
 
cnt
 
==
 
$num
 
)
 
{
ÒÒ 
return
ÚÚ 

BadRequest
ÚÚ %
(
ÚÚ% &
$str
ÚÚ& I
)
ÚÚI J
;
ÚÚJ K
}
ÛÛ 
if
ıı 
(
ıı 
values
ıı 
.
ıı 
CustomerTypeId
ıı )
==
ıı* ,
(
ıı- .
int
ıı. 1
)
ıı1 2
CustomerTypeEnum
ıı2 B
.
ııB C
MULTI_OWNERSHIP
ııC R
&&
ııS U
values
ııV \
.
ıı\ ]
ResidentTypeId
ıı] k
==
ııl n
(
ııo p
int
ııp s
)
ııs t
ResidentTypeEnumııt Ñ
.ııÑ Ö

EXPATRIATEııÖ è
)ııè ê
{
ˆˆ 
if
˜˜ 
(
˜˜ 
values
˜˜ 
.
˜˜ 

Expatriate
˜˜ )
is
˜˜* ,
null
˜˜- 1
)
˜˜1 2
{
¯¯ 
return
˘˘ 

BadRequest
˘˘ )
(
˘˘) *
$str
˘˘* W
)
˘˘W X
;
˘˘X Y
}
˙˙ 
if
¸¸ 
(
¸¸ 
string
¸¸ 
.
¸¸  
IsNullOrWhiteSpace
¸¸ 1
(
¸¸1 2
values
¸¸2 8
.
¸¸8 9

Expatriate
¸¸9 C
!
¸¸C D
.
¸¸D E"
ResidentPermitNumber
¸¸E Y
)
¸¸Y Z
)
¸¸Z [
{
˝˝ 
return
˛˛ 

BadRequest
˛˛ )
(
˛˛) *
$str
˛˛* [
)
˛˛[ \
;
˛˛\ ]
}
ˇˇ 
}
ÄÄ 
if
ÇÇ 
(
ÇÇ 
values
ÇÇ 
.
ÇÇ 
CustomerTypeId
ÇÇ )
==
ÇÇ* ,
(
ÇÇ- .
int
ÇÇ. 1
)
ÇÇ1 2
CustomerTypeEnum
ÇÇ2 B
.
ÇÇB C
MULTI_OWNERSHIP
ÇÇC R
&&
ÇÇS U
values
ÇÇV \
.
ÇÇ\ ]
ResidentTypeId
ÇÇ] k
==
ÇÇl n
(
ÇÇo p
int
ÇÇp s
)
ÇÇs t
ResidentTypeEnumÇÇt Ñ
.ÇÇÑ Ö
NON_RESIDENTÇÇÖ ë
)ÇÇë í
{
ÉÉ 
if
ÑÑ 
(
ÑÑ 
values
ÑÑ 
.
ÑÑ 
NonResident
ÑÑ *
is
ÑÑ+ -
null
ÑÑ. 2
)
ÑÑ2 3
{
ÖÖ 
return
ÜÜ 

BadRequest
ÜÜ )
(
ÜÜ) *
$str
ÜÜ* h
)
ÜÜh i
;
ÜÜi j
}
áá 
if
ââ 
(
ââ 
string
ââ 
.
ââ  
IsNullOrWhiteSpace
ââ 1
(
ââ1 2
values
ââ2 8
.
ââ8 9
NonResident
ââ9 D
!
ââD E
.
ââE F$
ContactPerson_FullName
ââF \
)
ââ\ ]
)
ââ] ^
{
ää 
return
ãã 

BadRequest
ãã )
(
ãã) *
$str
ãã* ^
)
ãã^ _
;
ãã_ `
}
åå 
if
éé 
(
éé 
string
éé 
.
éé  
IsNullOrWhiteSpace
éé 1
(
éé1 2
values
éé2 8
.
éé8 9
NonResident
éé9 D
!
ééD E
.
ééE F(
ContactPerson_EmailAddress
ééF `
)
éé` a
)
ééa b
{
èè 
return
êê 

BadRequest
êê )
(
êê) *
$str
êê* c
)
êêc d
;
êêd e
}
ëë 
if
ìì 
(
ìì 
string
ìì 
.
ìì  
IsNullOrWhiteSpace
ìì 1
(
ìì1 2
values
ìì2 8
.
ìì8 9
NonResident
ìì9 D
!
ììD E
.
ììE F'
ContactPerson_PhoneNumber
ììF _
)
ìì_ `
)
ìì` a
{
îî 
return
ïï 

BadRequest
ïï )
(
ïï) *
$str
ïï* b
)
ïïb c
;
ïïc d
}
ññ 
}
óó 
return
öö 
Ok
öö 
(
öö 
await
öö $
_customerMasterService
öö  6
.
öö6 7
CreateCustomer
öö7 E
(
ööE F
values
ööF L
)
ööL M
)
ööM N
;
ööN O
}
õõ 
catch
úú 
(
úú 
	Exception
úú 
ex
úú 
)
úú  
{
ùù 
return
ûû 

StatusCode
ûû !
(
ûû! "
$num
ûû" %
,
ûû% &
ex
ûû' )
.
ûû) *
InnerException
ûû* 8
!
ûû8 9
.
ûû9 :
Message
ûû: A
)
ûûA B
;
ûûB C
}
üü 
}
†† 	
[
ßß 	
HttpGet
ßß	 
]
ßß 
[
®® 	
Route
®®	 
(
®® 
$str
®® 2
)
®®2 3
]
®®3 4
[
©© 	
AllowAnonymous
©©	 
]
©© 
public
™™ 
async
™™ 
Task
™™ 
<
™™ 
ActionResult
™™ &
>
™™& '
GetCustomer
™™( 3
(
™™3 4
string
™™4 :
customerCode
™™; G
)
™™G H
{
´´ 	
try
¨¨ 
{
≠≠ 
var
ÆÆ 
result
ÆÆ 
=
ÆÆ 
await
ÆÆ "$
_customerMasterService
ÆÆ# 9
.
ÆÆ9 :
GetCustomer
ÆÆ: E
(
ÆÆE F
customerCode
ÆÆF R
)
ÆÆR S
;
ÆÆS T
if
ØØ 
(
ØØ 
result
ØØ 
is
ØØ 
null
ØØ "
)
ØØ" #
{
∞∞ 
return
±± 
NotFound
±± #
(
±±# $
$"
±±$ &
$str
±±& 4
{
±±4 5
customerCode
±±5 A
}
±±A B
$str
±±B M
"
±±M N
)
±±N O
;
±±O P
}
≤≤ 
if
¥¥ 
(
¥¥ 
result
¥¥ 
.
¥¥ 
CustomerTypeId
¥¥ )
==
¥¥* ,
(
¥¥- .
int
¥¥. 1
)
¥¥1 2
CustomerTypeEnum
¥¥2 B
.
¥¥B C
PROSPECTIVE
¥¥C N
)
¥¥N O
{
µµ 
return
∂∂ 
Ok
∂∂ 
(
∂∂ 
await
∂∂ #$
_customerMasterService
∂∂$ :
.
∂∂: ;+
GetProspectiveCustomerDetails
∂∂; X
(
∂∂X Y
customerCode
∂∂Y e
)
∂∂e f
)
∂∂f g
;
∂∂g h
}
∑∑ 
if
ππ 
(
ππ 
result
ππ 
.
ππ 
CustomerTypeId
ππ )
==
ππ* ,
(
ππ- .
int
ππ. 1
)
ππ1 2
CustomerTypeEnum
ππ2 B
.
ππB C
COMPANY
ππC J
)
ππJ K
{
∫∫ 
return
ªª 
Ok
ªª 
(
ªª 
await
ªª #$
_customerMasterService
ªª$ :
.
ªª: ;'
GetCompanyCustomerDetails
ªª; T
(
ªªT U
customerCode
ªªU a
)
ªªa b
)
ªªb c
;
ªªc d
}
ºº 
if
ææ 
(
ææ 
result
ææ 
.
ææ 
CustomerTypeId
ææ )
==
ææ* ,
(
ææ- .
int
ææ. 1
)
ææ1 2
CustomerTypeEnum
ææ2 B
.
ææB C

INDIVIDUAL
ææC M
)
ææM N
{
øø 
return
¿¿ 
Ok
¿¿ 
(
¿¿ 
await
¿¿ #$
_customerMasterService
¿¿$ :
.
¿¿: ;*
GetIndividualCustomerDetails
¿¿; W
(
¿¿W X
customerCode
¿¿X d
)
¿¿d e
)
¿¿e f
;
¿¿f g
}
¡¡ 
if
√√ 
(
√√ 
result
√√ 
.
√√ 
CustomerTypeId
√√ )
==
√√* ,
(
√√- .
int
√√. 1
)
√√1 2
CustomerTypeEnum
√√2 B
.
√√B C
JOINT_OWNERSHIP
√√C R
)
√√R S
{
ƒƒ 
return
≈≈ 
Ok
≈≈ 
(
≈≈ 
await
≈≈ #$
_customerMasterService
≈≈$ :
.
≈≈: ;%
GetJointCustomerDetails
≈≈; R
(
≈≈R S
customerCode
≈≈S _
)
≈≈_ `
)
≈≈` a
;
≈≈a b
}
∆∆ 
if
»» 
(
»» 
result
»» 
.
»» 
CustomerTypeId
»» )
==
»»* ,
(
»»- .
int
»». 1
)
»»1 2
CustomerTypeEnum
»»2 B
.
»»B C
MULTI_OWNERSHIP
»»C R
)
»»R S
{
…… 
return
   
Ok
   
(
   
await
   #$
_customerMasterService
  $ :
.
  : ;%
GetMultiCustomerDetails
  ; R
(
  R S
customerCode
  S _
)
  _ `
)
  ` a
;
  a b
}
ÀÀ 
return
ÕÕ 

BadRequest
ÕÕ !
(
ÕÕ! "
)
ÕÕ" #
;
ÕÕ# $
}
ŒŒ 
catch
œœ 
(
œœ 
	Exception
œœ 
ex
œœ 
)
œœ  
{
–– 
return
—— 

StatusCode
—— !
(
——! "
$num
——" %
,
——% &
ex
——' )
.
——) *
InnerException
——* 8
!
——8 9
.
——9 :
Message
——: A
)
——A B
;
——B C
}
““ 
}
‘‘ 	
[
◊◊ 	
HttpPut
◊◊	 
]
◊◊ 
[
ÿÿ 	
Route
ÿÿ	 
(
ÿÿ 
$str
ÿÿ &
)
ÿÿ& '
]
ÿÿ' (
[
ŸŸ 	
	Authorize
ŸŸ	 
(
ŸŸ 
Policy
ŸŸ 
=
ŸŸ 
$str
ŸŸ 9
)
ŸŸ9 :
]
ŸŸ: ;
public
⁄⁄ 
async
⁄⁄ 
Task
⁄⁄ 
<
⁄⁄ 
ActionResult
⁄⁄ &
>
⁄⁄& '#
UpdateCompanyCustomer
⁄⁄( =
(
⁄⁄= >
[
⁄⁄> ?
FromBody
⁄⁄? G
]
⁄⁄G H&
UpdateCompanyCustomerDto
⁄⁄I a
values
⁄⁄b h
)
⁄⁄h i
{
€€ 	
try
‹‹ 
{
›› 
var
‡‡ 
userId
‡‡ 
=
‡‡ !
_userContextService
‡‡ 0
.
‡‡0 1
	GetUserId
‡‡1 :
(
‡‡: ;
)
‡‡; <
;
‡‡< =
if
·· 
(
·· 
!
·· 
string
·· 
.
·· 
Equals
·· "
(
··" #
userId
··# )
,
··) *
values
··+ 1
.
··1 2

ModifiedBy
··2 <
)
··< =
)
··= >
{
‚‚ 
return
„„ 
Unauthorized
„„ '
(
„„' (
)
„„( )
;
„„) *
}
‰‰ 
var
ÊÊ 
result
ÊÊ 
=
ÊÊ 
await
ÊÊ "$
_customerMasterService
ÊÊ# 9
.
ÊÊ9 :
UpdateCustomer
ÊÊ: H
(
ÊÊH I
values
ÊÊI O
)
ÊÊO P
;
ÊÊP Q
if
ÁÁ 
(
ÁÁ 
result
ÁÁ 
.
ÁÁ 
	IsSuccess
ÁÁ $
==
ÁÁ% '
true
ÁÁ( ,
)
ÁÁ, -
{
ËË 
return
ÈÈ 
Ok
ÈÈ 
(
ÈÈ 
result
ÈÈ $
.
ÈÈ$ %
SuccessResponse
ÈÈ% 4
)
ÈÈ4 5
;
ÈÈ5 6
}
ÍÍ 
var
ÏÏ 
status
ÏÏ 
=
ÏÏ 
result
ÏÏ #
.
ÏÏ# $
ErrorResponse
ÏÏ$ 1
!
ÏÏ1 2
.
ÏÏ2 3

StatusCode
ÏÏ3 =
;
ÏÏ= >
return
ÌÌ 
status
ÌÌ 
switch
ÌÌ $
{
ÓÓ 
$num
ÔÔ 
=>
ÔÔ 
	NoContent
ÔÔ $
(
ÔÔ$ %
)
ÔÔ% &
,
ÔÔ& '
$num
 
=>
 

BadRequest
 %
(
% &
result
& ,
.
, -
ErrorResponse
- :
)
: ;
,
; <
$num
ÒÒ 
=>
ÒÒ 
NotFound
ÒÒ #
(
ÒÒ# $
result
ÒÒ$ *
.
ÒÒ* +
ErrorResponse
ÒÒ+ 8
)
ÒÒ8 9
,
ÒÒ9 :
_
ÚÚ 
=>
ÚÚ 

StatusCode
ÚÚ #
(
ÚÚ# $
$num
ÚÚ$ '
,
ÚÚ' (
result
ÚÚ) /
.
ÚÚ/ 0
ErrorResponse
ÚÚ0 =
)
ÚÚ= >
,
ÚÚ> ?
}
ÛÛ 
;
ÛÛ 
}
ıı 
catch
ˆˆ 
(
ˆˆ 
	Exception
ˆˆ 
ex
ˆˆ 
)
ˆˆ  
{
˜˜ 
return
¯¯ 

StatusCode
¯¯ !
(
¯¯! "
$num
¯¯" %
,
¯¯% &
ex
¯¯' )
.
¯¯) *
InnerException
¯¯* 8
!
¯¯8 9
.
¯¯9 :
Message
¯¯: A
)
¯¯A B
;
¯¯B C
}
˘˘ 
}
˙˙ 	
[
¸¸ 	
HttpPut
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ )
)
˝˝) *
]
˝˝* +
[
˛˛ 	
	Authorize
˛˛	 
(
˛˛ 
Policy
˛˛ 
=
˛˛ 
$str
˛˛ 9
)
˛˛9 :
]
˛˛: ;
public
ˇˇ 
async
ˇˇ 
Task
ˇˇ 
<
ˇˇ 
ActionResult
ˇˇ &
>
ˇˇ& '&
UpdateIndividualCustomer
ˇˇ( @
(
ˇˇ@ A
[
ˇˇA B
FromBody
ˇˇB J
]
ˇˇJ K1
#UpdateIndividualResidentCustomerDto
ˇˇL o
values
ˇˇp v
)
ˇˇv w
{
ÄÄ 	
try
ÅÅ 
{
ÇÇ 
var
ÉÉ 
userId
ÉÉ 
=
ÉÉ !
_userContextService
ÉÉ 0
.
ÉÉ0 1
	GetUserId
ÉÉ1 :
(
ÉÉ: ;
)
ÉÉ; <
;
ÉÉ< =
if
ÑÑ 
(
ÑÑ 
!
ÑÑ 
string
ÑÑ 
.
ÑÑ 
Equals
ÑÑ "
(
ÑÑ" #
userId
ÑÑ# )
,
ÑÑ) *
values
ÑÑ+ 1
.
ÑÑ1 2

ModifiedBy
ÑÑ2 <
)
ÑÑ< =
)
ÑÑ= >
{
ÖÖ 
return
ÜÜ 
Unauthorized
ÜÜ '
(
ÜÜ' (
)
ÜÜ( )
;
ÜÜ) *
}
áá 
if
ââ 
(
ââ 
values
ââ 
.
ââ 
CustomerTypeId
ââ )
==
ââ* ,
(
ââ- .
int
ââ. 1
)
ââ1 2
CustomerTypeEnum
ââ2 B
.
ââB C

INDIVIDUAL
ââC M
&&
ââN P
values
ââQ W
.
ââW X
ResidentTypeId
ââX f
==
ââg i
(
ââj k
int
ââk n
)
âân o
ResidentTypeEnum
ââo 
.ââ Ä

EXPATRIATEââÄ ä
)ââä ã
{
ää 
if
ãã 
(
ãã 
values
ãã 
.
ãã 

Expatriate
ãã )
is
ãã* ,
null
ãã- 1
)
ãã1 2
{
åå 
return
çç 

BadRequest
çç )
(
çç) *
$str
çç* W
)
ççW X
;
ççX Y
}
éé 
if
êê 
(
êê 
string
êê 
.
êê  
IsNullOrWhiteSpace
êê 1
(
êê1 2
values
êê2 8
.
êê8 9

Expatriate
êê9 C
!
êêC D
.
êêD E"
ResidentPermitNumber
êêE Y
)
êêY Z
)
êêZ [
{
ëë 
return
íí 

BadRequest
íí )
(
íí) *
$str
íí* [
)
íí[ \
;
íí\ ]
}
ìì 
}
ññ 
if
òò 
(
òò 
values
òò 
.
òò 
CustomerTypeId
òò )
==
òò* ,
(
òò- .
int
òò. 1
)
òò1 2
CustomerTypeEnum
òò2 B
.
òòB C

INDIVIDUAL
òòC M
&&
òòN P
values
òòQ W
.
òòW X
ResidentTypeId
òòX f
==
òòg i
(
òòj k
int
òòk n
)
òòn o
ResidentTypeEnum
òòo 
.òò Ä
NON_RESIDENTòòÄ å
)òòå ç
{
ôô 
if
öö 
(
öö 
values
öö 
.
öö 
NonResident
öö *
is
öö+ -
null
öö. 2
)
öö2 3
{
õõ 
return
úú 

BadRequest
úú )
(
úú) *
$str
úú* h
)
úúh i
;
úúi j
}
ùù 
if
üü 
(
üü 
string
üü 
.
üü  
IsNullOrWhiteSpace
üü 1
(
üü1 2
values
üü2 8
.
üü8 9
NonResident
üü9 D
!
üüD E
.
üüE F$
ContactPerson_FullName
üüF \
)
üü\ ]
)
üü] ^
{
†† 
return
°° 

BadRequest
°° )
(
°°) *
$str
°°* ^
)
°°^ _
;
°°_ `
}
¢¢ 
if
§§ 
(
§§ 
string
§§ 
.
§§  
IsNullOrWhiteSpace
§§ 1
(
§§1 2
values
§§2 8
.
§§8 9
NonResident
§§9 D
!
§§D E
.
§§E F(
ContactPerson_EmailAddress
§§F `
)
§§` a
)
§§a b
{
•• 
return
¶¶ 

BadRequest
¶¶ )
(
¶¶) *
$str
¶¶* c
)
¶¶c d
;
¶¶d e
}
ßß 
if
©© 
(
©© 
string
©© 
.
©©  
IsNullOrWhiteSpace
©© 1
(
©©1 2
values
©©2 8
.
©©8 9
NonResident
©©9 D
!
©©D E
.
©©E F'
ContactPerson_PhoneNumber
©©F _
)
©©_ `
)
©©` a
{
™™ 
return
´´ 

BadRequest
´´ )
(
´´) *
$str
´´* b
)
´´b c
;
´´c d
}
¨¨ 
}
ÆÆ 
return
∞∞ 
Ok
∞∞ 
(
∞∞ 
await
∞∞ $
_customerMasterService
∞∞  6
.
∞∞6 7
UpdateCustomer
∞∞7 E
(
∞∞E F
values
∞∞F L
)
∞∞L M
)
∞∞M N
;
∞∞N O
}
±± 
catch
≤≤ 
(
≤≤ 
	Exception
≤≤ 
ex
≤≤ 
)
≤≤  
{
≥≥ 
return
¥¥ 

StatusCode
¥¥ !
(
¥¥! "
$num
¥¥" %
,
¥¥% &
ex
¥¥' )
.
¥¥) *
InnerException
¥¥* 8
!
¥¥8 9
.
¥¥9 :
Message
¥¥: A
)
¥¥A B
;
¥¥B C
}
µµ 
}
∂∂ 	
[
∏∏ 	
HttpPut
∏∏	 
]
∏∏ 
[
ππ 	
Route
ππ	 
(
ππ 
$str
ππ $
)
ππ$ %
]
ππ% &
[
∫∫ 	
	Authorize
∫∫	 
(
∫∫ 
Policy
∫∫ 
=
∫∫ 
$str
∫∫ 9
)
∫∫9 :
]
∫∫: ;
public
ªª 
async
ªª 
Task
ªª 
<
ªª 
ActionResult
ªª &
>
ªª& '!
UpdateJointCustomer
ªª( ;
(
ªª; <
[
ªª< =
FromBody
ªª= E
]
ªªE F-
UpdateJointOwnershipCustomerDto
ªªG f
values
ªªg m
)
ªªm n
{
ºº 	
try
ΩΩ 
{
ææ 
var
øø 
userId
øø 
=
øø !
_userContextService
øø 0
.
øø0 1
	GetUserId
øø1 :
(
øø: ;
)
øø; <
;
øø< =
if
¿¿ 
(
¿¿ 
!
¿¿ 
string
¿¿ 
.
¿¿ 
Equals
¿¿ "
(
¿¿" #
userId
¿¿# )
,
¿¿) *
values
¿¿+ 1
.
¿¿1 2

ModifiedBy
¿¿2 <
)
¿¿< =
)
¿¿= >
{
¡¡ 
return
¬¬ 
Unauthorized
¬¬ '
(
¬¬' (
)
¬¬( )
;
¬¬) *
}
√√ 
if
ÀÀ 
(
ÀÀ 
values
ÀÀ 
.
ÀÀ 
CustomerTypeId
ÀÀ )
==
ÀÀ* ,
(
ÀÀ- .
int
ÀÀ. 1
)
ÀÀ1 2
CustomerTypeEnum
ÀÀ2 B
.
ÀÀB C
JOINT_OWNERSHIP
ÀÀC R
&&
ÀÀS U
values
ÀÀV \
.
ÀÀ\ ]
ResidentTypeId
ÀÀ] k
==
ÀÀl n
(
ÀÀo p
int
ÀÀp s
)
ÀÀs t
ResidentTypeEnumÀÀt Ñ
.ÀÀÑ Ö

EXPATRIATEÀÀÖ è
)ÀÀè ê
{
ÃÃ 
if
ÕÕ 
(
ÕÕ 
values
ÕÕ 
.
ÕÕ 

Expatriate
ÕÕ )
is
ÕÕ* ,
null
ÕÕ- 1
)
ÕÕ1 2
{
ŒŒ 
return
œœ 

BadRequest
œœ )
(
œœ) *
$str
œœ* W
)
œœW X
;
œœX Y
}
–– 
if
““ 
(
““ 
string
““ 
.
““  
IsNullOrWhiteSpace
““ 1
(
““1 2
values
““2 8
.
““8 9

Expatriate
““9 C
!
““C D
.
““D E"
ResidentPermitNumber
““E Y
)
““Y Z
)
““Z [
{
”” 
return
‘‘ 

BadRequest
‘‘ )
(
‘‘) *
$str
‘‘* [
)
‘‘[ \
;
‘‘\ ]
}
’’ 
}
÷÷ 
if
ÿÿ 
(
ÿÿ 
values
ÿÿ 
.
ÿÿ 
CustomerTypeId
ÿÿ )
==
ÿÿ* ,
(
ÿÿ- .
int
ÿÿ. 1
)
ÿÿ1 2
CustomerTypeEnum
ÿÿ2 B
.
ÿÿB C
JOINT_OWNERSHIP
ÿÿC R
&&
ÿÿS U
values
ÿÿV \
.
ÿÿ\ ]
ResidentTypeId
ÿÿ] k
==
ÿÿl n
(
ÿÿo p
int
ÿÿp s
)
ÿÿs t
ResidentTypeEnumÿÿt Ñ
.ÿÿÑ Ö
NON_RESIDENTÿÿÖ ë
)ÿÿë í
{
ŸŸ 
if
⁄⁄ 
(
⁄⁄ 
values
⁄⁄ 
.
⁄⁄ 
NonResident
⁄⁄ *
is
⁄⁄+ -
null
⁄⁄. 2
)
⁄⁄2 3
{
€€ 
return
‹‹ 

BadRequest
‹‹ )
(
‹‹) *
$str
‹‹* h
)
‹‹h i
;
‹‹i j
}
›› 
if
ﬂﬂ 
(
ﬂﬂ 
string
ﬂﬂ 
.
ﬂﬂ  
IsNullOrWhiteSpace
ﬂﬂ 1
(
ﬂﬂ1 2
values
ﬂﬂ2 8
.
ﬂﬂ8 9
NonResident
ﬂﬂ9 D
!
ﬂﬂD E
.
ﬂﬂE F$
ContactPerson_FullName
ﬂﬂF \
)
ﬂﬂ\ ]
)
ﬂﬂ] ^
{
‡‡ 
return
·· 

BadRequest
·· )
(
··) *
$str
··* ^
)
··^ _
;
··_ `
}
‚‚ 
if
‰‰ 
(
‰‰ 
string
‰‰ 
.
‰‰  
IsNullOrWhiteSpace
‰‰ 1
(
‰‰1 2
values
‰‰2 8
.
‰‰8 9
NonResident
‰‰9 D
!
‰‰D E
.
‰‰E F(
ContactPerson_EmailAddress
‰‰F `
)
‰‰` a
)
‰‰a b
{
ÂÂ 
return
ÊÊ 

BadRequest
ÊÊ )
(
ÊÊ) *
$str
ÊÊ* c
)
ÊÊc d
;
ÊÊd e
}
ÁÁ 
if
ÈÈ 
(
ÈÈ 
string
ÈÈ 
.
ÈÈ  
IsNullOrWhiteSpace
ÈÈ 1
(
ÈÈ1 2
values
ÈÈ2 8
.
ÈÈ8 9
NonResident
ÈÈ9 D
!
ÈÈD E
.
ÈÈE F'
ContactPerson_PhoneNumber
ÈÈF _
)
ÈÈ_ `
)
ÈÈ` a
{
ÍÍ 
return
ÎÎ 

BadRequest
ÎÎ )
(
ÎÎ) *
$str
ÎÎ* b
)
ÎÎb c
;
ÎÎc d
}
ÏÏ 
}
ÌÌ 
return
 
Ok
 
(
 
await
 $
_customerMasterService
  6
.
6 7
UpdateCustomer
7 E
(
E F
values
F L
)
L M
)
M N
;
N O
}
ÒÒ 
catch
ÚÚ 
(
ÚÚ 
	Exception
ÚÚ 
ex
ÚÚ 
)
ÚÚ  
{
ÛÛ 
return
ÙÙ 

StatusCode
ÙÙ !
(
ÙÙ! "
$num
ÙÙ" %
,
ÙÙ% &
ex
ÙÙ' )
.
ÙÙ) *
InnerException
ÙÙ* 8
!
ÙÙ8 9
.
ÙÙ9 :
Message
ÙÙ: A
)
ÙÙA B
;
ÙÙB C
}
ıı 
}
ˆˆ 	
[
¯¯ 	
HttpPut
¯¯	 
]
¯¯ 
[
˘˘ 	
Route
˘˘	 
(
˘˘ 
$str
˘˘ $
)
˘˘$ %
]
˘˘% &
[
˙˙ 	
	Authorize
˙˙	 
(
˙˙ 
Policy
˙˙ 
=
˙˙ 
$str
˙˙ 9
)
˙˙9 :
]
˙˙: ;
public
˚˚ 
async
˚˚ 
Task
˚˚ 
<
˚˚ 
ActionResult
˚˚ &
>
˚˚& '!
UpdateMultiCustomer
˚˚( ;
(
˚˚; <
[
˚˚< =
FromBody
˚˚= E
]
˚˚E F-
UpdateMultiOwnershipCustomerDto
˚˚G f
values
˚˚g m
)
˚˚m n
{
¸¸ 	
try
˝˝ 
{
˛˛ 
var
ˇˇ 
userId
ˇˇ 
=
ˇˇ !
_userContextService
ˇˇ 0
.
ˇˇ0 1
	GetUserId
ˇˇ1 :
(
ˇˇ: ;
)
ˇˇ; <
;
ˇˇ< =
if
ÄÄ 
(
ÄÄ 
!
ÄÄ 
string
ÄÄ 
.
ÄÄ 
Equals
ÄÄ "
(
ÄÄ" #
userId
ÄÄ# )
,
ÄÄ) *
values
ÄÄ+ 1
.
ÄÄ1 2

ModifiedBy
ÄÄ2 <
)
ÄÄ< =
)
ÄÄ= >
{
ÅÅ 
return
ÇÇ 
Unauthorized
ÇÇ '
(
ÇÇ' (
)
ÇÇ( )
;
ÇÇ) *
}
ÉÉ 
if
ãã 
(
ãã 
values
ãã 
.
ãã 
CustomerTypeId
ãã )
==
ãã* ,
(
ãã- .
int
ãã. 1
)
ãã1 2
CustomerTypeEnum
ãã2 B
.
ããB C
MULTI_OWNERSHIP
ããC R
&&
ããS U
values
ããV \
.
ãã\ ]
ResidentTypeId
ãã] k
==
ããl n
(
ãão p
int
ããp s
)
ããs t
ResidentTypeEnumããt Ñ
.ããÑ Ö

EXPATRIATEããÖ è
)ããè ê
{
åå 
if
çç 
(
çç 
values
çç 
.
çç 

Expatriate
çç )
is
çç* ,
null
çç- 1
)
çç1 2
{
éé 
return
èè 

BadRequest
èè )
(
èè) *
$str
èè* W
)
èèW X
;
èèX Y
}
êê 
if
íí 
(
íí 
string
íí 
.
íí  
IsNullOrWhiteSpace
íí 1
(
íí1 2
values
íí2 8
.
íí8 9

Expatriate
íí9 C
!
ííC D
.
ííD E"
ResidentPermitNumber
ííE Y
)
ííY Z
)
ííZ [
{
ìì 
return
îî 

BadRequest
îî )
(
îî) *
$str
îî* [
)
îî[ \
;
îî\ ]
}
ïï 
}
ññ 
if
òò 
(
òò 
values
òò 
.
òò 
CustomerTypeId
òò )
==
òò* ,
(
òò- .
int
òò. 1
)
òò1 2
CustomerTypeEnum
òò2 B
.
òòB C
MULTI_OWNERSHIP
òòC R
&&
òòS U
values
òòV \
.
òò\ ]
ResidentTypeId
òò] k
==
òòl n
(
òòo p
int
òòp s
)
òòs t
ResidentTypeEnumòòt Ñ
.òòÑ Ö
NON_RESIDENTòòÖ ë
)òòë í
{
ôô 
if
öö 
(
öö 
values
öö 
.
öö 
NonResident
öö *
is
öö+ -
null
öö. 2
)
öö2 3
{
õõ 
return
úú 

BadRequest
úú )
(
úú) *
$str
úú* h
)
úúh i
;
úúi j
}
ùù 
if
üü 
(
üü 
string
üü 
.
üü  
IsNullOrWhiteSpace
üü 1
(
üü1 2
values
üü2 8
.
üü8 9
NonResident
üü9 D
!
üüD E
.
üüE F$
ContactPerson_FullName
üüF \
)
üü\ ]
)
üü] ^
{
†† 
return
°° 

BadRequest
°° )
(
°°) *
$str
°°* ^
)
°°^ _
;
°°_ `
}
¢¢ 
if
§§ 
(
§§ 
string
§§ 
.
§§  
IsNullOrWhiteSpace
§§ 1
(
§§1 2
values
§§2 8
.
§§8 9
NonResident
§§9 D
!
§§D E
.
§§E F(
ContactPerson_EmailAddress
§§F `
)
§§` a
)
§§a b
{
•• 
return
¶¶ 

BadRequest
¶¶ )
(
¶¶) *
$str
¶¶* c
)
¶¶c d
;
¶¶d e
}
ßß 
if
©© 
(
©© 
string
©© 
.
©©  
IsNullOrWhiteSpace
©© 1
(
©©1 2
values
©©2 8
.
©©8 9
NonResident
©©9 D
!
©©D E
.
©©E F'
ContactPerson_PhoneNumber
©©F _
)
©©_ `
)
©©` a
{
™™ 
return
´´ 

BadRequest
´´ )
(
´´) *
$str
´´* b
)
´´b c
;
´´c d
}
¨¨ 
}
≠≠ 
return
∞∞ 
Ok
∞∞ 
(
∞∞ 
await
∞∞ $
_customerMasterService
∞∞  6
.
∞∞6 7
UpdateCustomer
∞∞7 E
(
∞∞E F
values
∞∞F L
)
∞∞L M
)
∞∞M N
;
∞∞N O
}
±± 
catch
≤≤ 
(
≤≤ 
	Exception
≤≤ 
ex
≤≤ 
)
≤≤  
{
≥≥ 
return
¥¥ 

StatusCode
¥¥ !
(
¥¥! "
$num
¥¥" %
,
¥¥% &
ex
¥¥' )
.
¥¥) *
InnerException
¥¥* 8
!
¥¥8 9
.
¥¥9 :
Message
¥¥: A
)
¥¥A B
;
¥¥B C
}
µµ 
}
∂∂ 	
[
∏∏ 	

HttpDelete
∏∏	 
(
∏∏ 
$str
∏∏ ?
)
∏∏? @
]
∏∏@ A
[
ππ 	
	Authorize
ππ	 
(
ππ 
Policy
ππ 
=
ππ 
$str
ππ 9
)
ππ9 :
]
ππ: ;
public
∫∫ 
async
∫∫ 
Task
∫∫ 
<
∫∫ 
ActionResult
∫∫ &
>
∫∫& '
DeleteCustomer
∫∫( 6
(
∫∫6 7
string
∫∫7 =
customerCode
∫∫> J
,
∫∫J K
string
∫∫L R
	deletedBy
∫∫S \
)
∫∫\ ]
{
ªª 	
try
ºº 
{
ΩΩ 
if
ææ 
(
ææ 
string
ææ 
.
ææ  
IsNullOrWhiteSpace
ææ -
(
ææ- .
customerCode
ææ. :
)
ææ: ;
&&
ææ< >
string
ææ? E
.
ææE F 
IsNullOrWhiteSpace
ææF X
(
ææX Y
	deletedBy
ææY b
)
ææb c
)
ææc d
{
øø 
return
¿¿ 

BadRequest
¿¿ %
(
¿¿% &
$str
¿¿& _
)
¿¿_ `
;
¿¿` a
}
¡¡ 
var
√√ 
values
√√ 
=
√√ 
new
√√  &
DeleteCustomerRequestDto
√√! 9
(
√√9 :
customerCode
√√: F
,
√√F G
	deletedBy
√√H Q
)
√√Q R
;
√√R S
var
ƒƒ 
response
ƒƒ 
=
ƒƒ 
await
ƒƒ $$
_customerMasterService
ƒƒ% ;
.
ƒƒ; <!
DeleteCustomerAsync
ƒƒ< O
(
ƒƒO P
values
ƒƒP V
)
ƒƒV W
;
ƒƒW X
return
∆∆ 
response
∆∆ 
switch
∆∆  &
{
«« 
$num
»» 
=>
»» 
Ok
»» 
(
»» 
$str
»» 5
)
»»5 6
,
»»6 7
$num
…… 
=>
…… 

BadRequest
…… %
(
……% &
)
……& '
,
……' (
$num
   
=>
   
NotFound
   #
(
  # $
$str
  $ L
)
  L M
,
  M N
_
ÀÀ 
=>
ÀÀ 

StatusCode
ÀÀ #
(
ÀÀ# $
$num
ÀÀ$ '
,
ÀÀ' (
$str
ÀÀ) @
)
ÀÀ@ A
,
ÀÀA B
}
ÃÃ 
;
ÃÃ 
}
ÕÕ 
catch
ŒŒ 
(
ŒŒ 
	Exception
ŒŒ 
ex
ŒŒ 
)
ŒŒ  
{
œœ 
return
–– 

StatusCode
–– !
(
––! "
$num
––" %
,
––% &
ex
––' )
.
––) *
InnerException
––* 8
!
––8 9
.
––9 :
Message
––: A
)
––A B
;
––B C
}
—— 
}
““ 	
[
‘‘ 	
HttpPut
‘‘	 
]
‘‘ 
[
’’ 	
Route
’’	 
(
’’ 
$str
’’ "
)
’’" #
]
’’# $
[
÷÷ 	
	Authorize
÷÷	 
(
÷÷ 
Policy
÷÷ 
=
÷÷ 
$str
÷÷ 9
)
÷÷9 :
]
÷÷: ;
public
◊◊ 
async
◊◊ 
Task
◊◊ 
<
◊◊ 
ActionResult
◊◊ &
>
◊◊& '
StopCustomerDebit
◊◊( 9
(
◊◊9 :
[
◊◊: ;
FromBody
◊◊; C
]
◊◊C D!
StopDebitRequestDto
◊◊E X
values
◊◊Y _
)
◊◊_ `
{
ÿÿ 	
try
ŸŸ 
{
⁄⁄ 
var
€€ 
userId
€€ 
=
€€ !
_userContextService
€€ 0
.
€€0 1
	GetUserId
€€1 :
(
€€: ;
)
€€; <
;
€€< =
if
‹‹ 
(
‹‹ 
!
‹‹ 
string
‹‹ 
.
‹‹ 
Equals
‹‹ "
(
‹‹" #
userId
‹‹# )
,
‹‹) *
values
‹‹+ 1
.
‹‹1 2
ActionBy
‹‹2 :
)
‹‹: ;
)
‹‹; <
{
›› 
return
ﬁﬁ 
Unauthorized
ﬁﬁ '
(
ﬁﬁ' (
)
ﬁﬁ( )
;
ﬁﬁ) *
}
ﬂﬂ 
var
·· 
status
·· 
=
·· 
await
·· "$
_customerMasterService
··# 9
.
··9 :$
StopCustomerDebitAsync
··: P
(
··P Q
values
··Q W
)
··W X
;
··X Y
return
„„ 
status
„„ 
switch
„„ $
{
‰‰ 
$num
ÂÂ 
=>
ÂÂ 
Ok
ÂÂ 
(
ÂÂ 
$str
ÂÂ '
)
ÂÂ' (
,
ÂÂ( )
$num
ÊÊ 
=>
ÊÊ 

BadRequest
ÊÊ %
(
ÊÊ% &
)
ÊÊ& '
,
ÊÊ' (
$num
ÁÁ 
=>
ÁÁ 
NotFound
ÁÁ #
(
ÁÁ# $
$"
ÁÁ$ &
$str
ÁÁ& 4
{
ÁÁ4 5
values
ÁÁ5 ;
.
ÁÁ; <
CustomerCode
ÁÁ< H
}
ÁÁH I
$str
ÁÁI S
"
ÁÁS T
)
ÁÁT U
,
ÁÁU V
$num
ËË 
=>
ËË 

StatusCode
ËË %
(
ËË% &
$num
ËË& )
,
ËË) *
$str
ËË* 8
)
ËË8 9
,
ËË9 :
_
ÈÈ 
=>
ÈÈ 

StatusCode
ÈÈ #
(
ÈÈ# $
$num
ÈÈ$ '
,
ÈÈ' (
$str
ÈÈ) @
)
ÈÈ@ A
,
ÈÈA B
}
ÍÍ 
;
ÍÍ 
;
ÍÍ 
}
ÏÏ 
catch
ÌÌ 
(
ÌÌ 
	Exception
ÌÌ 
ex
ÌÌ 
)
ÌÌ  
{
ÓÓ 
return
ÔÔ 

StatusCode
ÔÔ !
(
ÔÔ! "
$num
ÔÔ" %
,
ÔÔ% &
ex
ÔÔ' )
.
ÔÔ) *
InnerException
ÔÔ* 8
!
ÔÔ8 9
.
ÔÔ9 :
Message
ÔÔ: A
)
ÔÔA B
;
ÔÔB C
}
 
}
ÒÒ 	
[
ÛÛ 	
HttpPut
ÛÛ	 
]
ÛÛ 
[
ÙÙ 	
Route
ÙÙ	 
(
ÙÙ 
$str
ÙÙ $
)
ÙÙ$ %
]
ÙÙ% &
[
ıı 	
	Authorize
ıı	 
(
ıı 
Policy
ıı 
=
ıı 
$str
ıı 9
)
ıı9 :
]
ıı: ;
public
ˆˆ 
async
ˆˆ 
Task
ˆˆ 
<
ˆˆ 
ActionResult
ˆˆ &
>
ˆˆ& '!
UnstopCustomerDebit
ˆˆ( ;
(
ˆˆ; <
[
ˆˆ< =
FromBody
ˆˆ= E
]
ˆˆE F!
StopDebitRequestDto
ˆˆG Z
values
ˆˆ[ a
)
ˆˆa b
{
˜˜ 	
try
¯¯ 
{
˘˘ 
var
˙˙ 
userId
˙˙ 
=
˙˙ !
_userContextService
˙˙ 0
.
˙˙0 1
	GetUserId
˙˙1 :
(
˙˙: ;
)
˙˙; <
;
˙˙< =
if
˚˚ 
(
˚˚ 
!
˚˚ 
string
˚˚ 
.
˚˚ 
Equals
˚˚ "
(
˚˚" #
userId
˚˚# )
,
˚˚) *
values
˚˚+ 1
.
˚˚1 2
ActionBy
˚˚2 :
)
˚˚: ;
)
˚˚; <
{
¸¸ 
return
˝˝ 
Unauthorized
˝˝ '
(
˝˝' (
)
˝˝( )
;
˝˝) *
}
˛˛ 
var
ÄÄ 
status
ÄÄ 
=
ÄÄ 
await
ÄÄ "$
_customerMasterService
ÄÄ# 9
.
ÄÄ9 :$
StopCustomerDebitAsync
ÄÄ: P
(
ÄÄP Q
values
ÄÄQ W
)
ÄÄW X
;
ÄÄX Y
return
ÇÇ 
status
ÇÇ 
switch
ÇÇ $
{
ÉÉ 
$num
ÑÑ 
=>
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
$str
ÑÑ '
)
ÑÑ' (
,
ÑÑ( )
$num
ÖÖ 
=>
ÖÖ 

BadRequest
ÖÖ %
(
ÖÖ% &
)
ÖÖ& '
,
ÖÖ' (
$num
ÜÜ 
=>
ÜÜ 
NotFound
ÜÜ #
(
ÜÜ# $
$"
ÜÜ$ &
$str
ÜÜ& 4
{
ÜÜ4 5
values
ÜÜ5 ;
.
ÜÜ; <
CustomerCode
ÜÜ< H
}
ÜÜH I
$str
ÜÜI S
"
ÜÜS T
)
ÜÜT U
,
ÜÜU V
$num
áá 
=>
áá 

StatusCode
áá %
(
áá% &
$num
áá& )
,
áá) *
$str
áá+ 9
)
áá9 :
,
áá: ;
_
àà 
=>
àà 

StatusCode
àà #
(
àà# $
$num
àà$ '
,
àà' (
$str
àà) @
)
àà@ A
,
ààA B
}
ââ 
;
ââ 
;
ââ 
}
ãã 
catch
åå 
(
åå 
	Exception
åå 
ex
åå 
)
åå  
{
çç 
return
éé 

StatusCode
éé !
(
éé! "
$num
éé" %
,
éé% &
ex
éé' )
.
éé) *
InnerException
éé* 8
!
éé8 9
.
éé9 :
Message
éé: A
)
ééA B
;
ééB C
}
èè 
}
êê 	
}
íí 
}ìì »ö
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomerController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v13 5
{ 
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
[ 
	Authorize 
( !
AuthenticationSchemes $
=% &
JwtBearerDefaults' 8
.8 9 
AuthenticationScheme9 M
)M N
]N O
[ 
	Authorize 
( 
Policy 
= 
$str 3
)3 4
]4 5
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{ 
readonly  
ICustomerTypeService % 
_customerTypeService& :
;: ;
readonly   
IGenderService   
_genderService    .
;  . /
readonly!! &
IIdentificationTypeService!! +&
_identificationTypeService!!, F
;!!F G
readonly"" 
INationalityService"" $
_nationalityService""% 8
;""8 9
readonly##  
IResidentTypeService## % 
_residentTypeService##& :
;##: ;
readonly$$ 
ISocialMediaService$$ $
_socialMediaService$$% 8
;$$8 9
readonly%% 
ITitleService%% 
_titleService%% ,
;%%, -
readonly&& !
IOwnershipTypeService&& &!
_ownershipTypeService&&' <
;&&< =
readonly(( "
ICustomerMasterService(( '"
_customerMasterService((( >
;((> ?
private** 
readonly** 
IUserContextService** ,
_userContextService**- @
;**@ A
public,, 
CustomerController,, !
(,,! " 
ICustomerTypeService,," 6
customerTypeService,,7 J
,,,J K
IGenderService,,L Z
genderService,,[ h
,,,h i'
IIdentificationTypeService	,,j Ñ'
identificationTypeService
,,Ö û
,
,,û ü!
INationalityService
,,† ≥ 
nationalityService
,,¥ ∆
,
,,∆ «"
IResidentTypeService
,,» ‹!
residentTypeService
,,› 
,
,, Ò
ISocialMediaService--" 5
socialMediaService--6 H
,--H I
ITitleService--J W
titleService--X d
,--d e"
ICustomerMasterService--f |"
customerMasterService	--} í
,
--í ì#
IOwnershipTypeService
--î ©"
ownershipTypeService
--™ æ
,
--æ ø!
IUserContextService
--¿ ” 
userContextService
--‘ Ê
)
--Ê Á
{.. 	 
_customerTypeService//  
=//! "
customerTypeService//# 6
;//6 7
_genderService00 
=00 
genderService00 *
;00* +&
_identificationTypeService11 &
=11' (%
identificationTypeService11) B
;11B C
_nationalityService22 
=22  !
nationalityService22" 4
;224 5 
_residentTypeService33  
=33! "
residentTypeService33# 6
;336 7
_socialMediaService44 
=44  !
socialMediaService44" 4
;444 5
_titleService55 
=55 
titleService55 (
;55( )"
_customerMasterService77 "
=77# $!
customerMasterService77% :
;77: ;!
_ownershipTypeService88 !
=88" # 
ownershipTypeService88$ 8
;888 9
_userContextService99 
=99  !
userContextService99" 4
;994 5
}:: 	
[@@ 	
HttpGet@@	 
]@@ 
[AA 	
RouteAA	 
(AA 
$strAA !
)AA! "
]AA" #
publicBB 
asyncBB 
TaskBB 
<BB 
ActionResultBB &
<BB& '
IEnumerableBB' 2
<BB2 3
CustomerTypeReadDtoBB3 F
>BBF G
>BBG H
>BBH I
GetCustomerTypesBBJ Z
(BBZ [
)BB[ \
{CC 	
returnDD 
OkDD 
(DD 
awaitDD  
_customerTypeServiceDD 0
.DD0 1 
GetCustomerTypeAsyncDD1 E
(DDE F
)DDF G
)DDG H
;DDH I
}EE 	
[XX 	
HttpPostXX	 
]XX 
[YY 	
RouteYY	 
(YY 
$strYY #
)YY# $
]YY$ %
[ZZ 	
	AuthorizeZZ	 
(ZZ 
PolicyZZ 
=ZZ 
$strZZ 9
)ZZ9 :
]ZZ: ;
public[[ 
async[[ 
Task[[ 
<[[ 
ActionResult[[ &
<[[& '
CustomerTypeReadDto[[' :
>[[: ;
>[[; <
CreateCustomerType[[= O
([[O P
[[[P Q
FromBody[[Q Y
][[Y Z!
CustomerTypeCreateDto[[[ p
values[[q w
)[[w x
{\\ 	
try]] 
{^^ 
var__ 
userId__ 
=__ 
_userContextService__ 0
.__0 1
	GetUserId__1 :
(__: ;
)__; <
;__< =
ifaa 
(aa 
!aa 
stringaa 
.aa 
Equalsaa !
(aa! "
userIdaa" (
,aa( )
valuesaa* 0
.aa0 1
	createdByaa1 :
)aa: ;
)aa; <
{bb 
returncc 
Unauthorizedcc '
(cc' (
)cc( )
;cc) *
}dd 
returnff 
Okff 
(ff 
awaitff  
_customerTypeServiceff  4
.ff4 5 
AddCustomerTypeAsyncff5 I
(ffI J
valuesffJ P
)ffP Q
)ffQ R
;ffR S
}gg 
catchhh 
(hh 
	Exceptionhh 
exhh 
)hh  
{ii 
returnjj 

StatusCodejj !
(jj! "
$numjj" %
,jj% &
exjj' )
.jj) *
InnerExceptionjj* 8
!jj8 9
.jj9 :
Messagejj: A
)jjA B
;jjB C
}kk 
}ll 	
[}} 	
HttpPut}}	 
]}} 
[~~ 	
Route~~	 
(~~ 
$str~~ #
)~~# $
]~~$ %
[ 	
	Authorize	 
( 
Policy 
= 
$str 9
)9 :
]: ;
public
ÄÄ 
async
ÄÄ 
Task
ÄÄ 
<
ÄÄ 
ActionResult
ÄÄ &
<
ÄÄ& '!
CustomerTypeReadDto
ÄÄ' :
>
ÄÄ: ;
>
ÄÄ; < 
UpdateCustomerType
ÄÄ= O
(
ÄÄO P
[
ÄÄP Q
FromBody
ÄÄQ Y
]
ÄÄY Z#
CustomerTypeUpdateDto
ÄÄ[ p
values
ÄÄq w
)
ÄÄw x
{
ÅÅ 	
var
ÇÇ 
userId
ÇÇ 
=
ÇÇ !
_userContextService
ÇÇ ,
.
ÇÇ, -
	GetUserId
ÇÇ- 6
(
ÇÇ6 7
)
ÇÇ7 8
;
ÇÇ8 9
if
ÉÉ 
(
ÉÉ 
!
ÉÉ 
string
ÉÉ 
.
ÉÉ 
Equals
ÉÉ 
(
ÉÉ 
userId
ÉÉ %
,
ÉÉ% &
values
ÉÉ' -
.
ÉÉ- .

modifiedBy
ÉÉ. 8
)
ÉÉ8 9
)
ÉÉ9 :
{
ÑÑ 
return
ÖÖ 
Unauthorized
ÖÖ #
(
ÖÖ# $
)
ÖÖ$ %
;
ÖÖ% &
}
ÜÜ 
return
àà 
Ok
àà 
(
àà 
await
àà "
_customerTypeService
àà 0
.
àà0 1%
UpdateCustomerTypeAsync
àà1 H
(
ààH I
values
ààI O
)
ààO P
)
ààP Q
;
ààQ R
}
ââ 	
[
ãã 	

HttpDelete
ãã	 
(
ãã 
$str
ãã 9
)
ãã9 :
]
ãã: ;
[
åå 	
	Authorize
åå	 
(
åå 
Policy
åå 
=
åå 
$str
åå 9
)
åå9 :
]
åå: ;
public
çç 
async
çç 
Task
çç 
<
çç 
ActionResult
çç &
>
çç& ' 
DeleteCustomerType
çç( :
(
çç: ;
int
çç; >
customerTypeId
çç? M
)
ççM N
{
éé 	
var
èè 
response
èè 
=
èè 
await
èè  "
_customerTypeService
èè! 5
.
èè5 6$
DeleteCustomerTyeAsync
èè6 L
(
èèL M
customerTypeId
èèM [
)
èè[ \
;
èè\ ]
if
ëë 
(
ëë 
response
ëë 
==
ëë 
$str
ëë $
)
ëë$ %
{
íí 
return
ìì 
Ok
ìì 
(
ìì 
await
ìì "
_customerTypeService
ìì  4
.
ìì4 5$
DeleteCustomerTyeAsync
ìì5 K
(
ììK L
customerTypeId
ììL Z
)
ììZ [
)
ìì[ \
;
ìì\ ]
}
îî 
return
ññ 

BadRequest
ññ 
(
ññ 
)
ññ 
;
ññ  
}
óó 	
[
ùù 	
HttpGet
ùù	 
]
ùù 
[
ûû 	
Route
ûû	 
(
ûû 
$str
ûû 
)
ûû 
]
ûû 
public
üü 
async
üü 
Task
üü 
<
üü 
ActionResult
üü &
<
üü& '
IEnumerable
üü' 2
<
üü2 3
GenderReadDto
üü3 @
>
üü@ A
>
üüA B
>
üüB C
	GetGender
üüD M
(
üüM N
)
üüN O
{
†† 	
return
°° 
Ok
°° 
(
°° 
await
°° 
_genderService
°° *
.
°°* +
GetGenderAsync
°°+ 9
(
°°9 :
)
°°: ;
)
°°; <
;
°°< =
}
¢¢ 	
[
§§ 	
HttpGet
§§	 
]
§§ 
[
•• 	
Route
••	 
(
•• 
$str
•• "
)
••" #
]
••# $
private
¶¶ 
async
¶¶ 
Task
¶¶ 
<
¶¶ 
ActionResult
¶¶ '
<
¶¶' (
GenderReadDto
¶¶( 5
>
¶¶5 6
>
¶¶6 7
	GetGender
¶¶8 A
(
¶¶A B
string
¶¶B H
value
¶¶I N
)
¶¶N O
{
ßß 	
return
®® 
Ok
®® 
(
®® 
await
®® 
_genderService
®® *
.
®®* +
GetGenderAsync
®®+ 9
(
®®9 :
value
®®: ?
)
®®? @
)
®®@ A
;
®®A B
}
©© 	
[
´´ 	
HttpGet
´´	 
]
´´ 
[
¨¨ 	
Route
¨¨	 
(
¨¨ 
$str
¨¨ %
)
¨¨% &
]
¨¨& '
public
≠≠ 
async
≠≠ 
Task
≠≠ 
<
≠≠ 
ActionResult
≠≠ &
<
≠≠& '
GenderReadDto
≠≠' 4
>
≠≠4 5
>
≠≠5 6
	GetGender
≠≠7 @
(
≠≠@ A
int
≠≠A D
genderId
≠≠E M
)
≠≠M N
{
ÆÆ 	
return
ØØ 
Ok
ØØ 
(
ØØ 
await
ØØ 
_genderService
ØØ *
.
ØØ* +
GetGenderAsync
ØØ+ 9
(
ØØ9 :
genderId
ØØ: B
)
ØØB C
)
ØØC D
;
ØØD E
}
∞∞ 	
[
¡¡ 	
HttpPost
¡¡	 
]
¡¡ 
[
¬¬ 	
Route
¬¬	 
(
¬¬ 
$str
¬¬ 
)
¬¬ 
]
¬¬ 
[
√√ 	
	Authorize
√√	 
(
√√ 
Policy
√√ 
=
√√ 
$str
√√ 9
)
√√9 :
]
√√: ;
public
ƒƒ 
async
ƒƒ 
Task
ƒƒ 
<
ƒƒ 
ActionResult
ƒƒ &
<
ƒƒ& '
GenderReadDto
ƒƒ' 4
>
ƒƒ4 5
>
ƒƒ5 6
CreateGender
ƒƒ7 C
(
ƒƒC D
[
ƒƒD E
FromBody
ƒƒE M
]
ƒƒM N
GenderCreateDto
ƒƒO ^
values
ƒƒ_ e
)
ƒƒe f
{
≈≈ 	
try
∆∆ 
{
«« 
var
»» 
userId
»» 
=
»» !
_userContextService
»» 0
.
»»0 1
	GetUserId
»»1 :
(
»»: ;
)
»»; <
;
»»< =
if
   
(
   
!
   
string
   
.
   
Equals
   "
(
  " #
userId
  # )
,
  ) *
values
  + 1
.
  1 2
	createdBy
  2 ;
)
  ; <
)
  < =
{
ÀÀ 
return
ÃÃ 
Unauthorized
ÃÃ '
(
ÃÃ' (
)
ÃÃ( )
;
ÃÃ) *
}
ÕÕ 
return
œœ 
Ok
œœ 
(
œœ 
await
œœ 
_genderService
œœ  .
.
œœ. /
AddGenderAsync
œœ/ =
(
œœ= >
values
œœ> D
)
œœD E
)
œœE F
;
œœF G
}
–– 
catch
—— 
(
—— 
	Exception
—— 
ex
—— 
)
——  
{
““ 
return
”” 

StatusCode
”” !
(
””! "
$num
””" %
,
””% &
ex
””' )
.
””) *
InnerException
””* 8
!
””8 9
.
””9 :
Message
””: A
)
””A B
;
””B C
}
‘‘ 
}
’’ 	
[
ÊÊ 	
HttpPut
ÊÊ	 
]
ÊÊ 
[
ÁÁ 	
Route
ÁÁ	 
(
ÁÁ 
$str
ÁÁ 
)
ÁÁ 
]
ÁÁ 
[
ËË 	
	Authorize
ËË	 
(
ËË 
Policy
ËË 
=
ËË 
$str
ËË 9
)
ËË9 :
]
ËË: ;
public
ÈÈ 
async
ÈÈ 
Task
ÈÈ 
<
ÈÈ 
ActionResult
ÈÈ &
<
ÈÈ& '
GenderReadDto
ÈÈ' 4
>
ÈÈ4 5
>
ÈÈ5 6
UpdateGender
ÈÈ7 C
(
ÈÈC D
[
ÈÈD E
FromBody
ÈÈE M
]
ÈÈM N
GenderUpdateDto
ÈÈO ^
values
ÈÈ_ e
)
ÈÈe f
{
ÍÍ 	
var
ÎÎ 
userId
ÎÎ 
=
ÎÎ !
_userContextService
ÎÎ ,
.
ÎÎ, -
	GetUserId
ÎÎ- 6
(
ÎÎ6 7
)
ÎÎ7 8
;
ÎÎ8 9
if
ÏÏ 
(
ÏÏ 
!
ÏÏ 
string
ÏÏ 
.
ÏÏ 
Equals
ÏÏ 
(
ÏÏ 
userId
ÏÏ %
,
ÏÏ% &
values
ÏÏ' -
.
ÏÏ- .

modifiedBy
ÏÏ. 8
)
ÏÏ8 9
)
ÏÏ9 :
{
ÌÌ 
return
ÓÓ 
Unauthorized
ÓÓ #
(
ÓÓ# $
)
ÓÓ$ %
;
ÓÓ% &
}
ÔÔ 
return
ÒÒ 
Ok
ÒÒ 
(
ÒÒ 
await
ÒÒ 
_genderService
ÒÒ *
.
ÒÒ* +
UpdateGenderAsync
ÒÒ+ <
(
ÒÒ< =
values
ÒÒ= C
)
ÒÒC D
)
ÒÒD E
;
ÒÒE F
}
ÚÚ 	
[
ÙÙ 	

HttpDelete
ÙÙ	 
(
ÙÙ 
$str
ÙÙ -
)
ÙÙ- .
]
ÙÙ. /
[
ıı 	
	Authorize
ıı	 
(
ıı 
Policy
ıı 
=
ıı 
$str
ıı 9
)
ıı9 :
]
ıı: ;
public
ˆˆ 
async
ˆˆ 
Task
ˆˆ 
<
ˆˆ 
ActionResult
ˆˆ &
>
ˆˆ& '
DeleteGender
ˆˆ( 4
(
ˆˆ4 5
int
ˆˆ5 8
genderId
ˆˆ9 A
)
ˆˆA B
{
˜˜ 	
return
¯¯ 
Ok
¯¯ 
(
¯¯ 
await
¯¯ 
_genderService
¯¯ *
.
¯¯* +
DeleteGenderAsync
¯¯+ <
(
¯¯< =
genderId
¯¯= E
)
¯¯E F
)
¯¯F G
;
¯¯G H
}
˘˘ 	
[
ˇˇ 	
HttpGet
ˇˇ	 
]
ˇˇ 
[
ÄÄ 	
Route
ÄÄ	 
(
ÄÄ 
$str
ÄÄ '
)
ÄÄ' (
]
ÄÄ( )
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ &
<
ÅÅ& '
IEnumerable
ÅÅ' 2
<
ÅÅ2 3'
IdentificationTypeReadDto
ÅÅ3 L
>
ÅÅL M
>
ÅÅM N
>
ÅÅN O$
GetIdentificationTypes
ÅÅP f
(
ÅÅf g
)
ÅÅg h
{
ÇÇ 	
return
ÉÉ 
Ok
ÉÉ 
(
ÉÉ 
await
ÉÉ (
_identificationTypeService
ÉÉ 6
.
ÉÉ6 7(
GetIdentificationTypeAsync
ÉÉ7 Q
(
ÉÉQ R
)
ÉÉR S
)
ÉÉS T
;
ÉÉT U
}
ÑÑ 	
[
ññ 	
HttpPost
ññ	 
]
ññ 
[
óó 	
Route
óó	 
(
óó 
$str
óó )
)
óó) *
]
óó* +
[
òò 	
	Authorize
òò	 
(
òò 
Policy
òò 
=
òò 
$str
òò 9
)
òò9 :
]
òò: ;
public
ôô 
async
ôô 
Task
ôô 
<
ôô 
ActionResult
ôô &
<
ôô& ''
IdentificationTypeReadDto
ôô' @
>
ôô@ A
>
ôôA B&
CreateIdentificationType
ôôC [
(
ôô[ \
[
ôô\ ]
FromBody
ôô] e
]
ôôe f*
IdentificationTypeCreateDtoôôg Ç
valuesôôÉ â
)ôôâ ä
{
öö 	
try
õõ 
{
úú 
var
ùù 
userId
ùù 
=
ùù !
_userContextService
ùù 0
.
ùù0 1
	GetUserId
ùù1 :
(
ùù: ;
)
ùù; <
;
ùù< =
if
ûû 
(
ûû 
!
ûû 
string
ûû 
.
ûû 
Equals
ûû "
(
ûû" #
userId
ûû# )
,
ûû) *
values
ûû+ 1
.
ûû1 2
	createdBy
ûû2 ;
)
ûû; <
)
ûû< =
{
üü 
return
†† 
Unauthorized
†† '
(
††' (
)
††( )
;
††) *
}
°° 
return
££ 
Ok
££ 
(
££ 
await
££ (
_identificationTypeService
££  :
.
££: ;(
AddIdentificationTypeAsync
££; U
(
££U V
values
££V \
)
££\ ]
)
££] ^
;
££^ _
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
∫∫ 	
HttpPut
∫∫	 
]
∫∫ 
[
ªª 	
Route
ªª	 
(
ªª 
$str
ªª )
)
ªª) *
]
ªª* +
[
ºº 	
	Authorize
ºº	 
(
ºº 
Policy
ºº 
=
ºº 
$str
ºº 9
)
ºº9 :
]
ºº: ;
public
ΩΩ 
async
ΩΩ 
Task
ΩΩ 
<
ΩΩ 
ActionResult
ΩΩ &
<
ΩΩ& ''
IdentificationTypeReadDto
ΩΩ' @
>
ΩΩ@ A
>
ΩΩA B 
UpdateCustomerType
ΩΩC U
(
ΩΩU V
[
ΩΩV W
FromBody
ΩΩW _
]
ΩΩ_ `)
IdentificationTypeUpdateDto
ΩΩa |
valuesΩΩ} É
)ΩΩÉ Ñ
{
ææ 	
var
øø 
userId
øø 
=
øø !
_userContextService
øø ,
.
øø, -
	GetUserId
øø- 6
(
øø6 7
)
øø7 8
;
øø8 9
if
¿¿ 
(
¿¿ 
!
¿¿ 
string
¿¿ 
.
¿¿ 
Equals
¿¿ 
(
¿¿ 
userId
¿¿ %
,
¿¿% &
values
¿¿' -
.
¿¿- .

modifiedBy
¿¿. 8
)
¿¿8 9
)
¿¿9 :
{
¡¡ 
return
¬¬ 
Unauthorized
¬¬ #
(
¬¬# $
)
¬¬$ %
;
¬¬% &
}
√√ 
return
ƒƒ 
Ok
ƒƒ 
(
ƒƒ 
await
ƒƒ (
_identificationTypeService
ƒƒ 6
.
ƒƒ6 7+
UpdateIdentificationTypeAsync
ƒƒ7 T
(
ƒƒT U
values
ƒƒU [
)
ƒƒ[ \
)
ƒƒ\ ]
;
ƒƒ] ^
}
≈≈ 	
[
«« 	

HttpDelete
««	 
(
«« 
$str
«« E
)
««E F
]
««F G
[
»» 	
	Authorize
»»	 
(
»» 
Policy
»» 
=
»» 
$str
»» 9
)
»»9 :
]
»»: ;
public
…… 
async
…… 
Task
…… 
<
…… 
ActionResult
…… &
>
……& '&
DeleteIdentificationType
……( @
(
……@ A
int
……A D"
identificationTypeId
……E Y
)
……Y Z
{
   	
return
ÀÀ 
Ok
ÀÀ 
(
ÀÀ 
await
ÀÀ (
_identificationTypeService
ÀÀ 6
.
ÀÀ6 7+
DeleteIdentificationTypeAsync
ÀÀ7 T
(
ÀÀT U"
identificationTypeId
ÀÀU i
)
ÀÀi j
)
ÀÀj k
;
ÀÀk l
}
ÃÃ 	
[
““ 	
HttpGet
““	 
]
““ 
[
”” 	
Route
””	 
(
”” 
$str
”” 
)
””  
]
””  !
public
‘‘ 
async
‘‘ 
Task
‘‘ 
<
‘‘ 
ActionResult
‘‘ &
<
‘‘& '
IEnumerable
‘‘' 2
<
‘‘2 3 
NationalityReadDto
‘‘3 E
>
‘‘E F
>
‘‘F G
>
‘‘G H
GetNationality
‘‘I W
(
‘‘W X
)
‘‘X Y
{
’’ 	
return
÷÷ 
Ok
÷÷ 
(
÷÷ 
await
÷÷ !
_nationalityService
÷÷ /
.
÷÷/ 0!
GetNationalityAsync
÷÷0 C
(
÷÷C D
)
÷÷D E
)
÷÷E F
;
÷÷F G
}
◊◊ 	
[
ËË 	
HttpPost
ËË	 
]
ËË 
[
ÈÈ 	
Route
ÈÈ	 
(
ÈÈ 
$str
ÈÈ "
)
ÈÈ" #
]
ÈÈ# $
[
ÍÍ 	
	Authorize
ÍÍ	 
(
ÍÍ 
Policy
ÍÍ 
=
ÍÍ 
$str
ÍÍ 9
)
ÍÍ9 :
]
ÍÍ: ;
public
ÎÎ 
async
ÎÎ 
Task
ÎÎ 
<
ÎÎ 
ActionResult
ÎÎ &
<
ÎÎ& ' 
NationalityReadDto
ÎÎ' 9
>
ÎÎ9 :
>
ÎÎ: ;
CreateNationality
ÎÎ< M
(
ÎÎM N
[
ÎÎN O
FromBody
ÎÎO W
]
ÎÎW X"
NationalityCreateDto
ÎÎY m
values
ÎÎn t
)
ÎÎt u
{
ÏÏ 	
try
ÌÌ 
{
ÓÓ 
var
ÔÔ 
userId
ÔÔ 
=
ÔÔ !
_userContextService
ÔÔ 0
.
ÔÔ0 1
	GetUserId
ÔÔ1 :
(
ÔÔ: ;
)
ÔÔ; <
;
ÔÔ< =
if
 
(
 
!
 
string
 
.
 
Equals
 "
(
" #
userId
# )
,
) *
values
+ 1
.
1 2
	createdby
2 ;
)
; <
)
< =
{
ÒÒ 
return
ÚÚ 
Unauthorized
ÚÚ '
(
ÚÚ' (
)
ÚÚ( )
;
ÚÚ) *
}
ÛÛ 
return
ıı 
Ok
ıı 
(
ıı 
await
ıı !
_nationalityService
ıı  3
.
ıı3 4!
AddNationalityAsync
ıı4 G
(
ııG H
values
ııH N
)
ııN O
)
ııO P
;
ııP Q
}
ˆˆ 
catch
˜˜ 
(
˜˜ 
	Exception
˜˜ 
ex
˜˜ 
)
˜˜  
{
¯¯ 
return
˘˘ 

StatusCode
˘˘ !
(
˘˘! "
$num
˘˘" %
,
˘˘% &
ex
˘˘' )
.
˘˘) *
InnerException
˘˘* 8
!
˘˘8 9
.
˘˘9 :
Message
˘˘: A
)
˘˘A B
;
˘˘B C
}
˙˙ 
}
˚˚ 	
[
ãã 	
HttpPut
ãã	 
]
ãã 
[
åå 	
Route
åå	 
(
åå 
$str
åå "
)
åå" #
]
åå# $
[
çç 	
	Authorize
çç	 
(
çç 
Policy
çç 
=
çç 
$str
çç 9
)
çç9 :
]
çç: ;
public
éé 
async
éé 
Task
éé 
<
éé 
ActionResult
éé &
<
éé& ' 
NationalityReadDto
éé' 9
>
éé9 :
>
éé: ;
UpdateNationality
éé< M
(
ééM N
[
ééN O
FromBody
ééO W
]
ééW X"
NationalityUpdateDto
ééY m
values
één t
)
éét u
{
èè 	
var
êê 
userId
êê 
=
êê !
_userContextService
êê ,
.
êê, -
	GetUserId
êê- 6
(
êê6 7
)
êê7 8
;
êê8 9
if
ëë 
(
ëë 
!
ëë 
string
ëë 
.
ëë 
Equals
ëë 
(
ëë 
userId
ëë %
,
ëë% &
values
ëë' -
.
ëë- .

modifiedby
ëë. 8
)
ëë8 9
)
ëë9 :
{
íí 
return
ìì 
Unauthorized
ìì #
(
ìì# $
)
ìì$ %
;
ìì% &
}
îî 
return
ïï 
Ok
ïï 
(
ïï 
await
ïï !
_nationalityService
ïï /
.
ïï/ 0$
UpdateNationalityAsync
ïï0 F
(
ïïF G
values
ïïG M
)
ïïM N
)
ïïN O
;
ïïO P
}
ññ 	
[
òò 	

HttpDelete
òò	 
(
òò 
$str
òò 7
)
òò7 8
]
òò8 9
[
ôô 	
	Authorize
ôô	 
(
ôô 
Policy
ôô 
=
ôô 
$str
ôô 9
)
ôô9 :
]
ôô: ;
public
öö 
async
öö 
Task
öö 
<
öö 
ActionResult
öö &
>
öö& '
DeleteNationality
öö( 9
(
öö9 :
int
öö: =
nationalityId
öö> K
)
ööK L
{
õõ 	
return
úú 
Ok
úú 
(
úú 
await
úú !
_nationalityService
úú /
.
úú/ 0$
DeleteNationalityAsync
úú0 F
(
úúF G
nationalityId
úúG T
)
úúT U
)
úúU V
;
úúV W
}
ùù 	
[
££ 	
HttpGet
££	 
]
££ 
[
§§ 	
Route
§§	 
(
§§ 
$str
§§ !
)
§§! "
]
§§" #
public
•• 
async
•• 
Task
•• 
<
•• 
ActionResult
•• &
<
••& '
IEnumerable
••' 2
<
••2 3!
ResidentTypeReadDto
••3 F
>
••F G
>
••G H
>
••H I
GetResidentTypes
••J Z
(
••Z [
)
••[ \
{
¶¶ 	
return
ßß 
Ok
ßß 
(
ßß 
await
ßß "
_residentTypeService
ßß 0
.
ßß0 1"
GetResidentTypeAsync
ßß1 E
(
ßßE F
)
ßßF G
)
ßßG H
;
ßßH I
}
®® 	
[
ππ 	
HttpPost
ππ	 
]
ππ 
[
∫∫ 	
Route
∫∫	 
(
∫∫ 
$str
∫∫ #
)
∫∫# $
]
∫∫$ %
[
ªª 	
	Authorize
ªª	 
(
ªª 
Policy
ªª 
=
ªª 
$str
ªª 9
)
ªª9 :
]
ªª: ;
public
ºº 
async
ºº 
Task
ºº 
<
ºº 
ActionResult
ºº &
<
ºº& '!
ResidentTypeReadDto
ºº' :
>
ºº: ;
>
ºº; < 
CreateResidentType
ºº= O
(
ººO P
[
ººP Q
FromBody
ººQ Y
]
ººY Z#
ResidentTypeCreateDto
ºº[ p
values
ººq w
)
ººw x
{
ΩΩ 	
try
ææ 
{
øø 
var
¿¿ 
userId
¿¿ 
=
¿¿ !
_userContextService
¿¿ 0
.
¿¿0 1
	GetUserId
¿¿1 :
(
¿¿: ;
)
¿¿; <
;
¿¿< =
if
¡¡ 
(
¡¡ 
!
¡¡ 
string
¡¡ 
.
¡¡ 
Equals
¡¡ "
(
¡¡" #
userId
¡¡# )
,
¡¡) *
values
¡¡+ 1
.
¡¡1 2
	createdBy
¡¡2 ;
)
¡¡; <
)
¡¡< =
{
¬¬ 
return
√√ 
Unauthorized
√√ '
(
√√' (
)
√√( )
;
√√) *
}
ƒƒ 
return
≈≈ 
Ok
≈≈ 
(
≈≈ 
await
≈≈ "
_residentTypeService
≈≈  4
.
≈≈4 5"
AddResidentTypeAsync
≈≈5 I
(
≈≈I J
values
≈≈J P
)
≈≈P Q
)
≈≈Q R
;
≈≈R S
}
∆∆ 
catch
«« 
(
«« 
	Exception
«« 
ex
«« 
)
««  
{
»» 
return
…… 

StatusCode
…… !
(
……! "
$num
……" %
,
……% &
ex
……' )
.
……) *
InnerException
……* 8
!
……8 9
.
……9 :
Message
……: A
)
……A B
;
……B C
}
   
}
ÀÀ 	
[
‹‹ 	
HttpPut
‹‹	 
]
‹‹ 
[
›› 	
Route
››	 
(
›› 
$str
›› #
)
››# $
]
››$ %
[
ﬁﬁ 	
	Authorize
ﬁﬁ	 
(
ﬁﬁ 
Policy
ﬁﬁ 
=
ﬁﬁ 
$str
ﬁﬁ 9
)
ﬁﬁ9 :
]
ﬁﬁ: ;
public
ﬂﬂ 
async
ﬂﬂ 
Task
ﬂﬂ 
<
ﬂﬂ 
ActionResult
ﬂﬂ &
<
ﬂﬂ& '!
ResidentTypeReadDto
ﬂﬂ' :
>
ﬂﬂ: ;
>
ﬂﬂ; < 
UpdateResidentType
ﬂﬂ= O
(
ﬂﬂO P
[
ﬂﬂP Q
FromBody
ﬂﬂQ Y
]
ﬂﬂY Z#
ResidentTypeUpdateDto
ﬂﬂ[ p
values
ﬂﬂq w
)
ﬂﬂw x
{
‡‡ 	
var
·· 
userId
·· 
=
·· !
_userContextService
·· ,
.
··, -
	GetUserId
··- 6
(
··6 7
)
··7 8
;
··8 9
if
‚‚ 
(
‚‚ 
!
‚‚ 
string
‚‚ 
.
‚‚ 
Equals
‚‚ 
(
‚‚ 
userId
‚‚ %
,
‚‚% &
values
‚‚' -
.
‚‚- .

modifiedBy
‚‚. 8
)
‚‚8 9
)
‚‚9 :
{
„„ 
return
‰‰ 
Unauthorized
‰‰ #
(
‰‰# $
)
‰‰$ %
;
‰‰% &
}
ÂÂ 
return
ÊÊ 
Ok
ÊÊ 
(
ÊÊ 
await
ÊÊ "
_residentTypeService
ÊÊ 0
.
ÊÊ0 1%
UpdateResidentTypeAsync
ÊÊ1 H
(
ÊÊH I
values
ÊÊI O
)
ÊÊO P
)
ÊÊP Q
;
ÊÊQ R
}
ÁÁ 	
[
ÈÈ 	

HttpDelete
ÈÈ	 
(
ÈÈ 
$str
ÈÈ 9
)
ÈÈ9 :
]
ÈÈ: ;
[
ÍÍ 	
	Authorize
ÍÍ	 
(
ÍÍ 
Policy
ÍÍ 
=
ÍÍ 
$str
ÍÍ 9
)
ÍÍ9 :
]
ÍÍ: ;
public
ÎÎ 
async
ÎÎ 
Task
ÎÎ 
<
ÎÎ 
ActionResult
ÎÎ &
>
ÎÎ& ' 
DeleteResidentType
ÎÎ( :
(
ÎÎ: ;
int
ÎÎ; >
residentTypeId
ÎÎ? M
)
ÎÎM N
{
ÏÏ 	
return
ÌÌ 
Ok
ÌÌ 
(
ÌÌ 
await
ÌÌ "
_residentTypeService
ÌÌ 0
.
ÌÌ0 1%
DeleteResidentTypeAsync
ÌÌ1 H
(
ÌÌH I
residentTypeId
ÌÌI W
)
ÌÌW X
)
ÌÌX Y
;
ÌÌY Z
}
ÓÓ 	
[
ÙÙ 	
HttpGet
ÙÙ	 
]
ÙÙ 
[
ıı 	
Route
ıı	 
(
ıı 
$str
ıı 
)
ıı  
]
ıı  !
public
ˆˆ 
async
ˆˆ 
Task
ˆˆ 
<
ˆˆ 
ActionResult
ˆˆ &
<
ˆˆ& '
IEnumerable
ˆˆ' 2
<
ˆˆ2 3 
SocialMediaReadDto
ˆˆ3 E
>
ˆˆE F
>
ˆˆF G
>
ˆˆG H
GetSocialMedia
ˆˆI W
(
ˆˆW X
)
ˆˆX Y
{
˜˜ 	
return
¯¯ 
Ok
¯¯ 
(
¯¯ 
await
¯¯ !
_socialMediaService
¯¯ /
.
¯¯/ 0!
GetSocialMediaAsync
¯¯0 C
(
¯¯C D
)
¯¯D E
)
¯¯E F
;
¯¯F G
}
˘˘ 	
[
˛˛ 	
HttpPost
˛˛	 
]
˛˛ 
[
ˇˇ 	
Route
ˇˇ	 
(
ˇˇ 
$str
ˇˇ 
)
ˇˇ  
]
ˇˇ  !
[
ÄÄ 	
	Authorize
ÄÄ	 
(
ÄÄ 
Policy
ÄÄ 
=
ÄÄ 
$str
ÄÄ 9
)
ÄÄ9 :
]
ÄÄ: ;
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ &
<
ÅÅ& ' 
SocialMediaReadDto
ÅÅ' 9
>
ÅÅ9 :
>
ÅÅ: ;
AddSocialMedia
ÅÅ< J
(
ÅÅJ K
[
ÅÅK L
FromBody
ÅÅL T
]
ÅÅT U"
SocialMediaCreateDto
ÅÅV j
values
ÅÅk q
)
ÅÅq r
{
ÇÇ 	
try
ÉÉ 
{
ÑÑ 
var
ÜÜ 
userId
ÜÜ 
=
ÜÜ !
_userContextService
ÜÜ 0
.
ÜÜ0 1
	GetUserId
ÜÜ1 :
(
ÜÜ: ;
)
ÜÜ; <
;
ÜÜ< =
if
áá 
(
áá 
!
áá 
string
áá 
.
áá 
Equals
áá "
(
áá" #
userId
áá# )
,
áá) *
values
áá+ 1
.
áá1 2
	CreatedBy
áá2 ;
)
áá; <
)
áá< =
{
àà 
return
ââ 
Unauthorized
ââ '
(
ââ' (
)
ââ( )
;
ââ) *
}
ää 
return
åå 
Ok
åå 
(
åå 
await
åå !
_socialMediaService
åå  3
.
åå3 4!
AddSocialMediaAsync
åå4 G
(
ååG H
values
ååH N
)
ååN O
)
ååO P
;
ååP Q
}
çç 
catch
éé 
(
éé 
	Exception
éé 
ex
éé 
)
éé  
{
èè 
return
êê 

StatusCode
êê !
(
êê! "
$num
êê" %
,
êê% &
ex
êê' )
.
êê) *
InnerException
êê* 8
!
êê8 9
.
êê9 :
Message
êê: A
)
êêA B
;
êêB C
}
ëë 
}
íí 	
[
óó 	
HttpPut
óó	 
]
óó 
[
òò 	
Route
òò	 
(
òò 
$str
òò "
)
òò" #
]
òò# $
[
ôô 	
	Authorize
ôô	 
(
ôô 
Policy
ôô 
=
ôô 
$str
ôô 9
)
ôô9 :
]
ôô: ;
public
öö 
async
öö 
Task
öö 
<
öö 
ActionResult
öö &
<
öö& ' 
SocialMediaReadDto
öö' 9
>
öö9 :
>
öö: ;
UpdateSocialMedia
öö< M
(
ööM N
[
ööN O
FromBody
ööO W
]
ööW X"
SocialMediaUpdateDto
ööY m
values
öön t
)
ööt u
{
õõ 	
var
úú 
userId
úú 
=
úú !
_userContextService
úú ,
.
úú, -
	GetUserId
úú- 6
(
úú6 7
)
úú7 8
;
úú8 9
if
ùù 
(
ùù 
!
ùù 
string
ùù 
.
ùù 
Equals
ùù 
(
ùù 
userId
ùù %
,
ùù% &
values
ùù' -
.
ùù- .

ModifiedBy
ùù. 8
)
ùù8 9
)
ùù9 :
{
ûû 
return
üü 
Unauthorized
üü #
(
üü# $
)
üü$ %
;
üü% &
}
†† 
return
°° 
Ok
°° 
(
°° 
await
°° !
_socialMediaService
°° /
.
°°/ 0$
UpdateSocialMediaAsync
°°0 F
(
°°F G
values
°°G M
)
°°M N
)
°°N O
;
°°O P
}
¢¢ 	
[
§§ 	

HttpDelete
§§	 
(
§§ 
$str
§§ 7
)
§§7 8
]
§§8 9
[
•• 	
	Authorize
••	 
(
•• 
Policy
•• 
=
•• 
$str
•• 9
)
••9 :
]
••: ;
public
¶¶ 
async
¶¶ 
Task
¶¶ 
<
¶¶ 
ActionResult
¶¶ &
>
¶¶& '
DeleteSocialMedia
¶¶( 9
(
¶¶9 :
int
¶¶: =
socialMediaId
¶¶> K
)
¶¶K L
{
ßß 	
return
®® 
Ok
®® 
(
®® 
await
®® !
_socialMediaService
®® /
.
®®/ 0$
DeleteSocialMediaAsync
®®0 F
(
®®F G
socialMediaId
®®G T
)
®®T U
)
®®U V
;
®®V W
}
©© 	
[
ØØ 	
HttpGet
ØØ	 
]
ØØ 
[
∞∞ 	
Route
∞∞	 
(
∞∞ 
$str
∞∞ 
)
∞∞ 
]
∞∞ 
public
±± 
async
±± 
Task
±± 
<
±± 
ActionResult
±± &
<
±±& '
IEnumerable
±±' 2
<
±±2 3
TitleReadDto
±±3 ?
>
±±? @
>
±±@ A
>
±±A B
	GetTitles
±±C L
(
±±L M
)
±±M N
{
≤≤ 	
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ 
_titleService
≥≥ )
.
≥≥) *
GetTitleAsync
≥≥* 7
(
≥≥7 8
)
≥≥8 9
)
≥≥9 :
;
≥≥: ;
}
¥¥ 	
[
∂∂ 	
HttpGet
∂∂	 
]
∂∂ 
[
∑∑ 	
Route
∑∑	 
(
∑∑ 
$str
∑∑ !
)
∑∑! "
]
∑∑" #
private
∏∏ 
async
∏∏ 
Task
∏∏ 
<
∏∏ 
ActionResult
∏∏ '
<
∏∏' (
TitleReadDto
∏∏( 4
>
∏∏4 5
>
∏∏5 6
GetTitle
∏∏7 ?
(
∏∏? @
string
∏∏@ F
value
∏∏G L
)
∏∏L M
{
ππ 	
return
∫∫ 
Ok
∫∫ 
(
∫∫ 
await
∫∫ 
_titleService
∫∫ )
.
∫∫) *
GetTitleAsync
∫∫* 7
(
∫∫7 8
value
∫∫8 =
)
∫∫= >
)
∫∫> ?
;
∫∫? @
}
ªª 	
[
ΩΩ 	
HttpGet
ΩΩ	 
]
ΩΩ 
[
ææ 	
Route
ææ	 
(
ææ 
$str
ææ $
)
ææ$ %
]
ææ% &
public
øø 
async
øø 
Task
øø 
<
øø 
ActionResult
øø &
<
øø& '
TitleReadDto
øø' 3
>
øø3 4
>
øø4 5
GetTitleById
øø6 B
(
øøB C
int
øøC F
titleId
øøG N
)
øøN O
{
¿¿ 	
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ 
_titleService
¡¡ )
.
¡¡) *
GetTitleAsync
¡¡* 7
(
¡¡7 8
titleId
¡¡8 ?
)
¡¡? @
)
¡¡@ A
;
¡¡A B
}
¬¬ 	
[
”” 	
HttpPost
””	 
]
”” 
[
‘‘ 	
Route
‘‘	 
(
‘‘ 
$str
‘‘ 
)
‘‘ 
]
‘‘ 
[
’’ 	
	Authorize
’’	 
(
’’ 
Policy
’’ 
=
’’ 
$str
’’ 9
)
’’9 :
]
’’: ;
public
÷÷ 
async
÷÷ 
Task
÷÷ 
<
÷÷ 
ActionResult
÷÷ &
<
÷÷& '
TitleReadDto
÷÷' 3
>
÷÷3 4
>
÷÷4 5
CreateTitle
÷÷6 A
(
÷÷A B
[
÷÷B C
FromBody
÷÷C K
]
÷÷K L
TitleCreateDto
÷÷M [
values
÷÷\ b
)
÷÷b c
{
◊◊ 	
try
ÿÿ 
{
ŸŸ 
var
⁄⁄ 
userId
⁄⁄ 
=
⁄⁄ !
_userContextService
⁄⁄ 0
.
⁄⁄0 1
	GetUserId
⁄⁄1 :
(
⁄⁄: ;
)
⁄⁄; <
;
⁄⁄< =
if
€€ 
(
€€ 
!
€€ 
string
€€ 
.
€€ 
Equals
€€ "
(
€€" #
userId
€€# )
,
€€) *
values
€€+ 1
.
€€1 2
	createdby
€€2 ;
)
€€; <
)
€€< =
{
‹‹ 
return
›› 
Unauthorized
›› '
(
››' (
)
››( )
;
››) *
}
ﬁﬁ 
return
‡‡ 
Ok
‡‡ 
(
‡‡ 
await
‡‡ 
_titleService
‡‡  -
.
‡‡- .
AddTitleAsync
‡‡. ;
(
‡‡; <
values
‡‡< B
)
‡‡B C
)
‡‡C D
;
‡‡D E
}
·· 
catch
‚‚ 
(
‚‚ 
	Exception
‚‚ 
ex
‚‚ 
)
‚‚  
{
„„ 
return
‰‰ 

StatusCode
‰‰ !
(
‰‰! "
$num
‰‰" %
,
‰‰% &
ex
‰‰' )
.
‰‰) *
InnerException
‰‰* 8
!
‰‰8 9
.
‰‰9 :
Message
‰‰: A
)
‰‰A B
;
‰‰B C
}
ÂÂ 
}
ÊÊ 	
[
˜˜ 	
HttpPut
˜˜	 
]
˜˜ 
[
¯¯ 	
Route
¯¯	 
(
¯¯ 
$str
¯¯ 
)
¯¯ 
]
¯¯ 
[
˘˘ 	
	Authorize
˘˘	 
(
˘˘ 
Policy
˘˘ 
=
˘˘ 
$str
˘˘ 9
)
˘˘9 :
]
˘˘: ;
public
˙˙ 
async
˙˙ 
Task
˙˙ 
<
˙˙ 
ActionResult
˙˙ &
<
˙˙& '
TitleReadDto
˙˙' 3
>
˙˙3 4
>
˙˙4 5
UpdateTitle
˙˙6 A
(
˙˙A B
[
˙˙B C
FromBody
˙˙C K
]
˙˙K L
TitleUpdateDto
˙˙M [
values
˙˙\ b
)
˙˙b c
{
˚˚ 	
var
¸¸ 
userId
¸¸ 
=
¸¸ !
_userContextService
¸¸ ,
.
¸¸, -
	GetUserId
¸¸- 6
(
¸¸6 7
)
¸¸7 8
;
¸¸8 9
if
˝˝ 
(
˝˝ 
!
˝˝ 
string
˝˝ 
.
˝˝ 
Equals
˝˝ 
(
˝˝ 
userId
˝˝ %
,
˝˝% &
values
˝˝' -
.
˝˝- .

modifiedby
˝˝. 8
)
˝˝8 9
)
˝˝9 :
{
˛˛ 
return
ˇˇ 
Unauthorized
ˇˇ #
(
ˇˇ# $
)
ˇˇ$ %
;
ˇˇ% &
}
ÄÄ 
return
ÅÅ 
Ok
ÅÅ 
(
ÅÅ 
await
ÅÅ 
_titleService
ÅÅ )
.
ÅÅ) *
UpdateTitleAsync
ÅÅ* :
(
ÅÅ: ;
values
ÅÅ; A
)
ÅÅA B
)
ÅÅB C
;
ÅÅC D
}
ÇÇ 	
[
ÑÑ 	

HttpDelete
ÑÑ	 
(
ÑÑ 
$str
ÑÑ +
)
ÑÑ+ ,
]
ÑÑ, -
[
ÖÖ 	
	Authorize
ÖÖ	 
(
ÖÖ 
Policy
ÖÖ 
=
ÖÖ 
$str
ÖÖ 9
)
ÖÖ9 :
]
ÖÖ: ;
public
ÜÜ 
async
ÜÜ 
Task
ÜÜ 
<
ÜÜ 
ActionResult
ÜÜ &
>
ÜÜ& '
DeleteTitle
ÜÜ( 3
(
ÜÜ3 4
int
ÜÜ4 7
titleId
ÜÜ8 ?
)
ÜÜ? @
{
áá 	
return
àà 
Ok
àà 
(
àà 
await
àà 
_titleService
àà )
.
àà) *
DeleteTitleAsync
àà* :
(
àà: ;
titleId
àà; B
)
ààB C
)
ààC D
;
ààD E
}
ââ 	
[
êê 	
HttpGet
êê	 
]
êê 
[
ëë 	
Route
ëë	 
(
ëë 
$str
ëë "
)
ëë" #
]
ëë# $
public
íí 
async
íí 
Task
íí 
<
íí 
ActionResult
íí &
<
íí& '
IEnumerable
íí' 2
<
íí2 3"
OwnershipTypeReadDto
íí3 G
>
ííG H
>
ííH I
>
ííI J
GetOwnershipTypes
ííK \
(
íí\ ]
)
íí] ^
{
ìì 	
return
îî 
Ok
îî 
(
îî 
await
îî #
_ownershipTypeService
îî 1
.
îî1 2#
GetOwnershipTypeAsync
îî2 G
(
îîG H
)
îîH I
)
îîI J
;
îîJ K
}
ïï 	
[
óó 	
HttpGet
óó	 
]
óó 
[
òò 	
Route
òò	 
(
òò 
$str
òò *
)
òò* +
]
òò+ ,
private
ôô 
async
ôô 
Task
ôô 
<
ôô 
ActionResult
ôô '
<
ôô' ("
OwnershipTypeReadDto
ôô( <
>
ôô< =
>
ôô= >
GetOwnershipTypes
ôô? P
(
ôôP Q
string
ôôQ W
value
ôôX ]
)
ôô] ^
{
öö 	
return
õõ 
Ok
õõ 
(
õõ 
await
õõ #
_ownershipTypeService
õõ 1
.
õõ1 2#
GetOwnershipTypeAsync
õõ2 G
(
õõG H
value
õõH M
)
õõM N
)
õõN O
;
õõO P
}
úú 	
[
ûû 	
HttpGet
ûû	 
]
ûû 
[
üü 	
Route
üü	 
(
üü 
$str
üü 3
)
üü3 4
]
üü4 5
public
†† 
async
†† 
Task
†† 
<
†† 
ActionResult
†† &
<
††& '"
OwnershipTypeReadDto
††' ;
>
††; <
>
††< =
GetOwnershipType
††> N
(
††N O
int
††O R
ownershipTypeId
††S b
)
††b c
{
°° 	
return
¢¢ 
Ok
¢¢ 
(
¢¢ 
await
¢¢ #
_ownershipTypeService
¢¢ 1
.
¢¢1 2#
GetOwnershipTypeAsync
¢¢2 G
(
¢¢G H
ownershipTypeId
¢¢H W
)
¢¢W X
)
¢¢X Y
;
¢¢Y Z
}
££ 	
[
¥¥ 	
HttpPost
¥¥	 
]
¥¥ 
[
µµ 	
Route
µµ	 
(
µµ 
$str
µµ $
)
µµ$ %
]
µµ% &
[
∂∂ 	
	Authorize
∂∂	 
(
∂∂ 
Policy
∂∂ 
=
∂∂ 
$str
∂∂ 9
)
∂∂9 :
]
∂∂: ;
public
∑∑ 
async
∑∑ 
Task
∑∑ 
<
∑∑ 
ActionResult
∑∑ &
<
∑∑& '
TitleReadDto
∑∑' 3
>
∑∑3 4
>
∑∑4 5!
CreateOwnershipType
∑∑6 I
(
∑∑I J
[
∑∑J K
FromBody
∑∑K S
]
∑∑S T$
OwnershipTypeCreateDto
∑∑U k
values
∑∑l r
)
∑∑r s
{
∏∏ 	
try
ππ 
{
∫∫ 
var
ªª 
userId
ªª 
=
ªª !
_userContextService
ªª 0
.
ªª0 1
	GetUserId
ªª1 :
(
ªª: ;
)
ªª; <
;
ªª< =
if
ºº 
(
ºº 
!
ºº 
string
ºº 
.
ºº 
Equals
ºº "
(
ºº" #
userId
ºº# )
,
ºº) *
values
ºº+ 1
.
ºº1 2
	createdby
ºº2 ;
)
ºº; <
)
ºº< =
{
ΩΩ 
return
ææ 
Unauthorized
ææ '
(
ææ' (
)
ææ( )
;
ææ) *
}
øø 
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ #
_ownershipTypeService
¡¡  5
.
¡¡5 6#
AddOwnershipTypeAsync
¡¡6 K
(
¡¡K L
values
¡¡L R
)
¡¡R S
)
¡¡S T
;
¡¡T U
}
¬¬ 
catch
√√ 
(
√√ 
	Exception
√√ 
ex
√√ 
)
√√  
{
ƒƒ 
return
≈≈ 

StatusCode
≈≈ !
(
≈≈! "
$num
≈≈" %
,
≈≈% &
ex
≈≈' )
.
≈≈) *
InnerException
≈≈* 8
!
≈≈8 9
.
≈≈9 :
Message
≈≈: A
)
≈≈A B
;
≈≈B C
}
∆∆ 
}
«« 	
[
ÿÿ 	
HttpPut
ÿÿ	 
]
ÿÿ 
[
ŸŸ 	
Route
ŸŸ	 
(
ŸŸ 
$str
ŸŸ $
)
ŸŸ$ %
]
ŸŸ% &
[
⁄⁄ 	
	Authorize
⁄⁄	 
(
⁄⁄ 
Policy
⁄⁄ 
=
⁄⁄ 
$str
⁄⁄ 9
)
⁄⁄9 :
]
⁄⁄: ;
public
€€ 
async
€€ 
Task
€€ 
<
€€ 
ActionResult
€€ &
<
€€& '"
OwnershipTypeReadDto
€€' ;
>
€€; <
>
€€< =!
UpdateOwnershipType
€€> Q
(
€€Q R
[
€€R S
FromBody
€€S [
]
€€[ \$
OwnershipTypeUpdateDto
€€] s
values
€€t z
)
€€z {
{
‹‹ 	
var
›› 
userId
›› 
=
›› !
_userContextService
›› ,
.
››, -
	GetUserId
››- 6
(
››6 7
)
››7 8
;
››8 9
if
ﬁﬁ 
(
ﬁﬁ 
!
ﬁﬁ 
string
ﬁﬁ 
.
ﬁﬁ 
Equals
ﬁﬁ 
(
ﬁﬁ 
userId
ﬁﬁ %
,
ﬁﬁ% &
values
ﬁﬁ' -
.
ﬁﬁ- .

modifiedby
ﬁﬁ. 8
)
ﬁﬁ8 9
)
ﬁﬁ9 :
{
ﬂﬂ 
return
‡‡ 
Unauthorized
‡‡ #
(
‡‡# $
)
‡‡$ %
;
‡‡% &
}
·· 
return
‚‚ 
Ok
‚‚ 
(
‚‚ 
await
‚‚ #
_ownershipTypeService
‚‚ 1
.
‚‚1 2&
UpdateOwnershipTypeAsync
‚‚2 J
(
‚‚J K
values
‚‚K Q
)
‚‚Q R
)
‚‚R S
;
‚‚S T
}
„„ 	
[
ÂÂ 	

HttpDelete
ÂÂ	 
(
ÂÂ 
$str
ÂÂ ;
)
ÂÂ; <
]
ÂÂ< =
[
ÊÊ 	
	Authorize
ÊÊ	 
(
ÊÊ 
Policy
ÊÊ 
=
ÊÊ 
$str
ÊÊ 9
)
ÊÊ9 :
]
ÊÊ: ;
public
ÁÁ 
async
ÁÁ 
Task
ÁÁ 
<
ÁÁ 
ActionResult
ÁÁ &
>
ÁÁ& '!
DeleteOwnershipType
ÁÁ( ;
(
ÁÁ; <
int
ÁÁ< ?
ownershipTypeId
ÁÁ@ O
)
ÁÁO P
{
ËË 	
return
ÈÈ 
Ok
ÈÈ 
(
ÈÈ 
await
ÈÈ #
_ownershipTypeService
ÈÈ 1
.
ÈÈ1 2&
DeleteOwnershipTypeAsync
ÈÈ2 J
(
ÈÈJ K
ownershipTypeId
ÈÈK Z
)
ÈÈZ [
)
ÈÈ[ \
;
ÈÈ\ ]
}
ÍÍ 	
[
ÓÓ 	
HttpGet
ÓÓ	 
]
ÓÓ 
[
ÔÔ 	
Route
ÔÔ	 
(
ÔÔ 
$str
ÔÔ 
)
ÔÔ 
]
ÔÔ  
public
ÒÒ 
IActionResult
ÒÒ 
MaritalStatus
ÒÒ *
(
ÒÒ* +
)
ÒÒ+ ,
{
ÚÚ 	
var
ÛÛ 
statuses
ÛÛ 
=
ÛÛ 
Enum
ÛÛ 
.
ÛÛ  
	GetValues
ÛÛ  )
(
ÛÛ) *
typeof
ÛÛ* 0
(
ÛÛ0 1
MaritalStatusEnum
ÛÛ1 B
)
ÛÛB C
)
ÛÛC D
.
ÙÙ# $
Cast
ÙÙ$ (
<
ÙÙ( )
MaritalStatusEnum
ÙÙ) :
>
ÙÙ: ;
(
ÙÙ; <
)
ÙÙ< =
.
ıı# $
Select
ıı$ *
(
ıı* +
e
ıı+ ,
=>
ıı- /
new
ıı0 3
{
ˆˆ# $
Id
˜˜' )
=
˜˜* +
(
˜˜, -
int
˜˜- 0
)
˜˜0 1
e
˜˜1 2
,
˜˜2 3
Name
¯¯' +
=
¯¯, -
e
¯¯. /
.
¯¯/ 0
ToString
¯¯0 8
(
¯¯8 9
)
¯¯9 :
,
¯¯: ;
DisplayName
˘˘' 2
=
˘˘3 4
e
˘˘5 6
.
˘˘6 7
GetType
˘˘7 >
(
˘˘> ?
)
˘˘? @
.
˙˙5 6
GetField
˙˙6 >
(
˙˙> ?
e
˙˙? @
.
˙˙@ A
ToString
˙˙A I
(
˙˙I J
)
˙˙J K
)
˙˙K L
!
˙˙L M
.
˚˚6 7 
GetCustomAttribute
˚˚7 I
<
˚˚I J"
DescriptionAttribute
˚˚J ^
>
˚˚^ _
(
˚˚_ `
)
˚˚` a
?
˚˚a b
.
¸¸6 7
Description
¸¸7 B
}
˛˛# $
)
˛˛$ %
;
˛˛% &
return
ˇˇ 
Ok
ˇˇ 
(
ˇˇ 
statuses
ˇˇ 
)
ˇˇ 
;
ˇˇ  
}
ÄÄ 	
[
áá 	
HttpGet
áá	 
]
áá 
[
àà 	
Route
àà	 
(
àà 
$str
àà  
)
àà  !
]
àà! "
public
ââ 
async
ââ 
Task
ââ 
<
ââ 
ActionResult
ââ &
<
ââ& '
IEnumerable
ââ' 2
<
ââ2 3
CustomerListDto
ââ3 B
>
ââB C
>
ââC D
>
ââD E
GetCustomerList
ââF U
(
ââU V
)
ââV W
{
ää 	
return
ãã 
Ok
ãã 
(
ãã 
await
ãã $
_customerMasterService
ãã 2
.
ãã2 3"
GetCustomerListAsync
ãã3 G
(
ããG H
)
ããH I
)
ããI J
;
ããJ K
}
åå 	
}
êê 
}ëë 