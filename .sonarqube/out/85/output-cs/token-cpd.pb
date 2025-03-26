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
}ï	ï	 ëÍ
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomersController.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
Controllers' 2
.2 3
v13 5
{ 
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{ 
[ 	
HttpPost	 
] 
[ 	
Route	 
( 
$str '
)' (
]( )
[ 	
	Authorize	 
( 
Policy 
= 
$str 9
)9 :
]: ;
public 
async 
Task 
< 
ActionResult &
>& '"
AddProspectiveCustomer( >
(> ?
[? @
FromBody@ H
]H I"
ProspectiveCustomerDtoJ `
valuesa g
)g h
{ 	
try 
{ 
var 
userId 
= 
_userContextService 0
.0 1
	GetUserId1 :
(: ;
); <
;< =
if 
( 
! 
string 
. 
Equals "
(" #
userId# )
,) *
values+ 1
.1 2
	CreatedBy2 ;
); <
)< =
{   
return!! 
Unauthorized!! '
(!!' (
)!!( )
;!!) *
}"" 
var$$ 
result$$ 
=$$ 
await$$ ""
_customerMasterService$$# 9
.$$9 :
CreateCustomer$$: H
($$H I
values$$I O
)$$O P
;$$P Q
if%% 
(%% 
result%% 
.%% 
	IsSuccess%% $
)%%$ %
{&& 
return'' 
Ok'' 
('' 
result'' $
.''$ %
SuccessResponse''% 4
)''4 5
;''5 6
}(( 
var** 
status** 
=** 
result** #
.**# $
ErrorResponse**$ 1
!**1 2
.**2 3

StatusCode**3 =
;**= >
return++ 
status++ 
switch++ $
{,, 
$num-- 
=>-- 
	NoContent-- $
(--$ %
)--% &
,--& '
$num.. 
=>.. 

BadRequest.. %
(..% &
result..& ,
..., -
ErrorResponse..- :
)..: ;
,..; <
$num// 
=>// 
NotFound// #
(//# $
result//$ *
.//* +
ErrorResponse//+ 8
)//8 9
,//9 :
_00 
=>00 

StatusCode00 #
(00# $
$num00$ '
,00' (
result00) /
.00/ 0
ErrorResponse000 =
)00= >
,00> ?
}11 
;11 
}22 
catch33 
(33 
	Exception33 
ex33 
)33  
{44 
return55 

StatusCode55 !
(55! "
$num55" %
,55% &
ex55' )
.55) *
InnerException55* 8
!558 9
.559 :
Message55: A
)55A B
;55B C
}66 
}77 	
[<< 	
HttpPost<<	 
]<< 
[== 	
Route==	 
(== 
$str== #
)==# $
]==$ %
[>> 	
	Authorize>>	 
(>> 
Policy>> 
=>> 
$str>> 9
)>>9 :
]>>: ;
public?? 
async?? 
Task?? 
<?? 
ActionResult?? &
>??& '
AddCompanyCustomer??( :
(??: ;
[??; <
FromBody??< D
]??D E$
CreateCompanyCustomerDto??F ^
values??_ e
)??e f
{@@ 	
tryAA 
{BB 
varCC 
userIdCC 
=CC 
_userContextServiceCC 0
.CC0 1
	GetUserIdCC1 :
(CC: ;
)CC; <
;CC< =
ifDD 
(DD 
!DD 
stringDD 
.DD 
EqualsDD "
(DD" #
userIdDD# )
,DD) *
valuesDD+ 1
.DD1 2
	CreatedByDD2 ;
)DD; <
)DD< =
{EE 
returnFF 
UnauthorizedFF '
(FF' (
)FF( )
;FF) *
}GG 
varII 
resultII 
=II 
awaitII ""
_customerMasterServiceII# 9
.II9 :
CreateCustomerII: H
(IIH I
valuesIII O
)IIO P
;IIP Q
ifJJ 
(JJ 
resultJJ 
.JJ 
	IsSuccessJJ #
)JJ# $
{KK 
returnLL 
OkLL 
(LL 
resultLL $
.LL$ %
SuccessResponseLL% 4
)LL4 5
;LL5 6
}MM 
varOO 
statusOO 
=OO 
resultOO #
.OO# $
ErrorResponseOO$ 1
!OO1 2
.OO2 3

StatusCodeOO3 =
;OO= >
returnPP 
statusPP 
switchPP $
{QQ 
$numRR 
=>RR 
	NoContentRR $
(RR$ %
)RR% &
,RR& '
$numSS 
=>SS 

BadRequestSS %
(SS% &
resultSS& ,
.SS, -
ErrorResponseSS- :
)SS: ;
,SS; <
$numTT 
=>TT 
NotFoundTT #
(TT# $
resultTT$ *
.TT* +
ErrorResponseTT+ 8
)TT8 9
,TT9 :
_UU 
=>UU 

StatusCodeUU #
(UU# $
$numUU$ '
,UU' (
resultUU) /
.UU/ 0
ErrorResponseUU0 =
)UU= >
,UU> ?
}VV 
;VV 
}XX 
catchYY 
(YY 
	ExceptionYY 
exYY 
)YY  
{ZZ 
return[[ 

StatusCode[[ !
([[! "
$num[[" %
,[[% &
ex[[' )
.[[) *
InnerException[[* 8
![[8 9
.[[9 :
Message[[: A
)[[A B
;[[B C
}\\ 
}]] 	
[bb 	
HttpPostbb	 
]bb 
[cc 	
Routecc	 
(cc 
$strcc &
)cc& '
]cc' (
[dd 	
	Authorizedd	 
(dd 
Policydd 
=dd 
$strdd 9
)dd9 :
]dd: ;
publicee 
asyncee 
Taskee 
<ee 
ActionResultee &
>ee& '!
AddIndividualCustomeree( =
(ee= >
[ee> ?
FromBodyee? G
]eeG H)
IndividualResidentCustomerDtoeeI f
valueseeg m
)eem n
{ff 	
trygg 
{hh 
ifii 
(ii 
!ii 
IsAuthorizedii !
(ii! "
valuesii" (
.ii( )
	CreatedByii) 2
!ii2 3
)ii3 4
)ii4 5
{jj 
returnkk 
Unauthorizedkk '
(kk' (
)kk( )
;kk) *
}ll 
varnn 
validationErrornn #
=nn$ %#
ValidateCustomerDetailsnn& =
(nn= >
valuesnn> D
)nnD E
;nnE F
ifoo 
(oo 
validationErroroo #
isoo$ &
notoo' *
nulloo+ /
)oo/ 0
{pp 
returnqq 

BadRequestqq %
(qq% &
validationErrorqq& 5
)qq5 6
;qq6 7
}rr 
returnuu 
Okuu 
(uu 
awaituu "
_customerMasterServiceuu  6
.uu6 7
CreateCustomeruu7 E
(uuE F
valuesuuF L
)uuL M
)uuM N
;uuN O
}vv 
catchww 
(ww 
	Exceptionww 
exww 
)ww  
{xx 
returnyy 

StatusCodeyy !
(yy! "
$numyy" %
,yy% &
exyy' )
.yy) *
InnerExceptionyy* 8
!yy8 9
.yy9 :
Messageyy: A
)yyA B
;yyB C
}zz 
}{{ 	
[
ÄÄ 	
HttpPost
ÄÄ	 
]
ÄÄ 
[
ÅÅ 	
Route
ÅÅ	 
(
ÅÅ 
$str
ÅÅ !
)
ÅÅ! "
]
ÅÅ" #
[
ÇÇ 	
	Authorize
ÇÇ	 
(
ÇÇ 
Policy
ÇÇ 
=
ÇÇ 
$str
ÇÇ 9
)
ÇÇ9 :
]
ÇÇ: ;
public
ÉÉ 
async
ÉÉ 
Task
ÉÉ 
<
ÉÉ 
ActionResult
ÉÉ &
>
ÉÉ& '
AddJointCustomer
ÉÉ( 8
(
ÉÉ8 9
[
ÉÉ9 :
FromBody
ÉÉ: B
]
ÉÉB C'
JointOwnershipCustomerDto
ÉÉD ]
values
ÉÉ^ d
)
ÉÉd e
{
ÑÑ 	
try
ÖÖ 
{
ÜÜ 
if
áá 
(
áá 
!
áá 
IsAuthorized
áá !
(
áá! "
values
áá" (
.
áá( )
	CreatedBy
áá) 2
!
áá2 3
)
áá3 4
)
áá4 5
{
àà 
return
ââ 
Unauthorized
ââ '
(
ââ' (
)
ââ( )
;
ââ) *
}
ää 
var
åå 
cnt
åå 
=
åå 
values
åå  
.
åå  !
CoLesse
åå! (
!
åå( )
.
åå) *
Count
åå* /
(
åå/ 0
)
åå0 1
;
åå1 2
if
çç 
(
çç 
cnt
çç 
==
çç 
$num
çç 
)
çç 
{
éé 
return
èè 

BadRequest
èè %
(
èè% &
CustomerConstants
èè& 7
.
èè7 8
ErrorCoLesseEmpty
èè8 I
)
èèI J
;
èèJ K
}
êê 
var
íí 
validationError
íí #
=
íí$ %%
ValidateCustomerDetails
íí& =
(
íí= >
values
íí> D
)
ííD E
;
ííE F
if
ìì 
(
ìì 
validationError
ìì #
is
ìì$ &
not
ìì' *
null
ìì+ /
)
ìì/ 0
{
îî 
return
ïï 

BadRequest
ïï %
(
ïï% &
validationError
ïï& 5
)
ïï5 6
;
ïï6 7
}
ññ 
return
ôô 
Ok
ôô 
(
ôô 
await
ôô $
_customerMasterService
ôô  6
.
ôô6 7
CreateCustomer
ôô7 E
(
ôôE F
values
ôôF L
)
ôôL M
)
ôôM N
;
ôôN O
}
öö 
catch
õõ 
(
õõ 
	Exception
õõ 
ex
õõ 
)
õõ  
{
úú 
return
ùù 

StatusCode
ùù !
(
ùù! "
$num
ùù" %
,
ùù% &
ex
ùù' )
.
ùù) *
InnerException
ùù* 8
!
ùù8 9
.
ùù9 :
Message
ùù: A
)
ùùA B
;
ùùB C
}
ûû 
}
üü 	
[
§§ 	
HttpPost
§§	 
]
§§ 
[
•• 	
Route
••	 
(
•• 
$str
•• !
)
••! "
]
••" #
[
¶¶ 	
	Authorize
¶¶	 
(
¶¶ 
Policy
¶¶ 
=
¶¶ 
$str
¶¶ 9
)
¶¶9 :
]
¶¶: ;
public
ßß 
async
ßß 
Task
ßß 
<
ßß 
ActionResult
ßß &
>
ßß& '
AddMultiCustomer
ßß( 8
(
ßß8 9
[
ßß9 :
FromBody
ßß: B
]
ßßB C'
MultiOwnershipCustomerDto
ßßD ]
values
ßß^ d
)
ßßd e
{
®® 	
try
©© 
{
™™ 
if
´´ 
(
´´ 
!
´´ 
IsAuthorized
´´ !
(
´´! "
values
´´" (
.
´´( )
	CreatedBy
´´) 2
!
´´2 3
)
´´3 4
)
´´4 5
{
¨¨ 
return
≠≠ 
Unauthorized
≠≠ '
(
≠≠' (
)
≠≠( )
;
≠≠) *
}
ÆÆ 
var
∞∞ 
cnt
∞∞ 
=
∞∞ 
values
∞∞  
.
∞∞  !
	Dependent
∞∞! *
!
∞∞* +
.
∞∞+ ,
Count
∞∞, 1
(
∞∞1 2
)
∞∞2 3
;
∞∞3 4
if
±± 
(
±± 
cnt
±± 
==
±± 
$num
±± 
)
±± 
{
≤≤ 
return
≥≥ 

BadRequest
≥≥ %
(
≥≥% &
CustomerConstants
≥≥& 7
.
≥≥7 8!
ErrorDependentEmpty
≥≥8 K
)
≥≥K L
;
≥≥L M
}
¥¥ 
var
∂∂ 
validationError
∂∂ #
=
∂∂$ %%
ValidateCustomerDetails
∂∂& =
(
∂∂= >
values
∂∂> D
)
∂∂D E
;
∂∂E F
if
∑∑ 
(
∑∑ 
validationError
∑∑ #
is
∑∑$ &
not
∑∑' *
null
∑∑+ /
)
∑∑/ 0
{
∏∏ 
return
ππ 

BadRequest
ππ %
(
ππ% &
validationError
ππ& 5
)
ππ5 6
;
ππ6 7
}
∫∫ 
return
ΩΩ 
Ok
ΩΩ 
(
ΩΩ 
await
ΩΩ $
_customerMasterService
ΩΩ  6
.
ΩΩ6 7
CreateCustomer
ΩΩ7 E
(
ΩΩE F
values
ΩΩF L
)
ΩΩL M
)
ΩΩM N
;
ΩΩN O
}
ææ 
catch
øø 
(
øø 
	Exception
øø 
ex
øø 
)
øø  
{
¿¿ 
return
¡¡ 

StatusCode
¡¡ !
(
¡¡! "
$num
¡¡" %
,
¡¡% &
ex
¡¡' )
.
¡¡) *
InnerException
¡¡* 8
!
¡¡8 9
.
¡¡9 :
Message
¡¡: A
)
¡¡A B
;
¡¡B C
}
¬¬ 
}
√√ 	
[
»» 	
HttpPut
»»	 
]
»» 
[
…… 	
Route
……	 
(
…… 
$str
……  
)
……  !
]
……! "
[
   	
	Authorize
  	 
(
   
Policy
   
=
   
$str
   :
)
  : ;
]
  ; <
public
ÀÀ 
async
ÀÀ 
Task
ÀÀ 
<
ÀÀ 
ActionResult
ÀÀ &
>
ÀÀ& '
StopCustomerDebit
ÀÀ( 9
(
ÀÀ9 :
[
ÀÀ: ;
FromBody
ÀÀ; C
]
ÀÀC D 
ApproveCustomerDto
ÀÀE W
values
ÀÀX ^
)
ÀÀ^ _
{
ÃÃ 	
try
ÕÕ 
{
ŒŒ 
var
œœ 
userId
œœ 
=
œœ !
_userContextService
œœ 0
.
œœ0 1
	GetUserId
œœ1 :
(
œœ: ;
)
œœ; <
;
œœ< =
if
–– 
(
–– 
!
–– 
string
–– 
.
–– 
Equals
–– "
(
––" #
userId
––# )
,
––) *
values
––+ 1
.
––1 2

approvedBy
––2 <
)
––< =
)
––= >
{
—— 
return
““ 
Unauthorized
““ '
(
““' (
)
““( )
;
““) *
}
”” 
var
’’ 
status
’’ 
=
’’ 
await
’’ "$
_customerMasterService
’’# 9
.
’’9 :"
ApproveCustomerAsync
’’: N
(
’’N O
values
’’O U
)
’’U V
;
’’V W
return
◊◊ 
status
◊◊ 
switch
◊◊ $
{
ÿÿ 
$num
ŸŸ 
=>
ŸŸ 
Ok
ŸŸ 
(
ŸŸ 
$str
ŸŸ '
)
ŸŸ' (
,
ŸŸ( )
$num
⁄⁄ 
=>
⁄⁄ 

BadRequest
⁄⁄ %
(
⁄⁄% &
)
⁄⁄& '
,
⁄⁄' (
$num
€€ 
=>
€€ 
NotFound
€€ #
(
€€# $
$"
€€$ &
$str
€€& 4
{
€€4 5
values
€€5 ;
.
€€; <
customerCode
€€< H
}
€€H I
$str
€€I S
"
€€S T
)
€€T U
,
€€U V
$num
‹‹ 
=>
‹‹ 

StatusCode
‹‹ %
(
‹‹% &
$num
‹‹& )
,
‹‹) *
$str
‹‹+ 9
)
‹‹9 :
,
‹‹: ;
_
›› 
=>
›› 

StatusCode
›› #
(
››# $
$num
››$ '
,
››' (
$str
››) @
)
››@ A
,
››A B
}
ﬁﬁ 
;
ﬁﬁ 
;
ﬁﬁ 
}
‡‡ 
catch
·· 
(
·· 
	Exception
·· 
ex
·· 
)
··  
{
‚‚ 
return
„„ 

StatusCode
„„ !
(
„„! "
$num
„„" %
,
„„% &
ex
„„' )
.
„„) *
InnerException
„„* 8
!
„„8 9
.
„„9 :
Message
„„: A
)
„„A B
;
„„B C
}
‰‰ 
}
ÂÂ 	
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
ÎÎ 2
)
ÎÎ2 3
]
ÎÎ3 4
[
ÏÏ 	
AllowAnonymous
ÏÏ	 
]
ÏÏ 
public
ÌÌ 
async
ÌÌ 
Task
ÌÌ 
<
ÌÌ 
ActionResult
ÌÌ &
>
ÌÌ& '
GetCustomer
ÌÌ( 3
(
ÌÌ3 4
string
ÌÌ4 :
customerCode
ÌÌ; G
)
ÌÌG H
{
ÓÓ 	
try
ÔÔ 
{
 
var
ÒÒ 
result
ÒÒ 
=
ÒÒ 
await
ÒÒ "$
_customerMasterService
ÒÒ# 9
.
ÒÒ9 :
GetCustomer
ÒÒ: E
(
ÒÒE F
customerCode
ÒÒF R
)
ÒÒR S
;
ÒÒS T
if
ÚÚ 
(
ÚÚ 
result
ÚÚ 
is
ÚÚ 
null
ÚÚ "
)
ÚÚ" #
{
ÛÛ 
return
ÙÙ 
NotFound
ÙÙ #
(
ÙÙ# $
$"
ÙÙ$ &
$str
ÙÙ& 4
{
ÙÙ4 5
customerCode
ÙÙ5 A
}
ÙÙA B
$str
ÙÙB M
"
ÙÙM N
)
ÙÙN O
;
ÙÙO P
}
ıı 
if
˜˜ 
(
˜˜ 
result
˜˜ 
.
˜˜ 
CustomerTypeId
˜˜ )
==
˜˜* ,
(
˜˜- .
int
˜˜. 1
)
˜˜1 2
CustomerTypeEnum
˜˜2 B
.
˜˜B C
PROSPECTIVE
˜˜C N
)
˜˜N O
{
¯¯ 
return
˘˘ 
Ok
˘˘ 
(
˘˘ 
await
˘˘ #$
_customerMasterService
˘˘$ :
.
˘˘: ;+
GetProspectiveCustomerDetails
˘˘; X
(
˘˘X Y
customerCode
˘˘Y e
)
˘˘e f
)
˘˘f g
;
˘˘g h
}
˙˙ 
if
¸¸ 
(
¸¸ 
result
¸¸ 
.
¸¸ 
CustomerTypeId
¸¸ )
==
¸¸* ,
(
¸¸- .
int
¸¸. 1
)
¸¸1 2
CustomerTypeEnum
¸¸2 B
.
¸¸B C
COMPANY
¸¸C J
)
¸¸J K
{
˝˝ 
return
˛˛ 
Ok
˛˛ 
(
˛˛ 
await
˛˛ #$
_customerMasterService
˛˛$ :
.
˛˛: ;'
GetCompanyCustomerDetails
˛˛; T
(
˛˛T U
customerCode
˛˛U a
)
˛˛a b
)
˛˛b c
;
˛˛c d
}
ˇˇ 
if
ÅÅ 
(
ÅÅ 
result
ÅÅ 
.
ÅÅ 
CustomerTypeId
ÅÅ )
==
ÅÅ* ,
(
ÅÅ- .
int
ÅÅ. 1
)
ÅÅ1 2
CustomerTypeEnum
ÅÅ2 B
.
ÅÅB C

INDIVIDUAL
ÅÅC M
)
ÅÅM N
{
ÇÇ 
return
ÉÉ 
Ok
ÉÉ 
(
ÉÉ 
await
ÉÉ #$
_customerMasterService
ÉÉ$ :
.
ÉÉ: ;*
GetIndividualCustomerDetails
ÉÉ; W
(
ÉÉW X
customerCode
ÉÉX d
)
ÉÉd e
)
ÉÉe f
;
ÉÉf g
}
ÑÑ 
if
ÜÜ 
(
ÜÜ 
result
ÜÜ 
.
ÜÜ 
CustomerTypeId
ÜÜ )
==
ÜÜ* ,
(
ÜÜ- .
int
ÜÜ. 1
)
ÜÜ1 2
CustomerTypeEnum
ÜÜ2 B
.
ÜÜB C
JOINT_OWNERSHIP
ÜÜC R
)
ÜÜR S
{
áá 
return
àà 
Ok
àà 
(
àà 
await
àà #$
_customerMasterService
àà$ :
.
àà: ;%
GetJointCustomerDetails
àà; R
(
ààR S
customerCode
ààS _
)
àà_ `
)
àà` a
;
ààa b
}
ââ 
if
ãã 
(
ãã 
result
ãã 
.
ãã 
CustomerTypeId
ãã )
==
ãã* ,
(
ãã- .
int
ãã. 1
)
ãã1 2
CustomerTypeEnum
ãã2 B
.
ããB C
MULTI_OWNERSHIP
ããC R
)
ããR S
{
åå 
return
çç 
Ok
çç 
(
çç 
await
çç #$
_customerMasterService
çç$ :
.
çç: ;%
GetMultiCustomerDetails
çç; R
(
ççR S
customerCode
ççS _
)
çç_ `
)
çç` a
;
çça b
}
éé 
return
êê 

BadRequest
êê !
(
êê! "
)
êê" #
;
êê# $
}
ëë 
catch
íí 
(
íí 
	Exception
íí 
ex
íí 
)
íí  
{
ìì 
return
îî 

StatusCode
îî !
(
îî! "
$num
îî" %
,
îî% &
ex
îî' )
.
îî) *
InnerException
îî* 8
!
îî8 9
.
îî9 :
Message
îî: A
)
îîA B
;
îîB C
}
ïï 
}
óó 	
[
ùù 	
HttpPut
ùù	 
]
ùù 
[
ûû 	
Route
ûû	 
(
ûû 
$str
ûû &
)
ûû& '
]
ûû' (
[
üü 	
	Authorize
üü	 
(
üü 
Policy
üü 
=
üü 
$str
üü 9
)
üü9 :
]
üü: ;
public
†† 
async
†† 
Task
†† 
<
†† 
ActionResult
†† &
>
††& '#
UpdateCompanyCustomer
††( =
(
††= >
[
††> ?
FromBody
††? G
]
††G H&
UpdateCompanyCustomerDto
††I a
values
††b h
)
††h i
{
°° 	
try
¢¢ 
{
££ 
var
¶¶ 
userId
¶¶ 
=
¶¶ !
_userContextService
¶¶ 0
.
¶¶0 1
	GetUserId
¶¶1 :
(
¶¶: ;
)
¶¶; <
;
¶¶< =
if
ßß 
(
ßß 
!
ßß 
string
ßß 
.
ßß 
Equals
ßß "
(
ßß" #
userId
ßß# )
,
ßß) *
values
ßß+ 1
.
ßß1 2

ModifiedBy
ßß2 <
)
ßß< =
)
ßß= >
{
®® 
return
©© 
Unauthorized
©© '
(
©©' (
)
©©( )
;
©©) *
}
™™ 
var
¨¨ 
validationError
¨¨ #
=
¨¨$ %%
ValidateCustomerDetails
¨¨& =
(
¨¨= >
values
¨¨> D
)
¨¨D E
;
¨¨E F
if
≠≠ 
(
≠≠ 
validationError
≠≠ #
is
≠≠$ &
not
≠≠' *
null
≠≠+ /
)
≠≠/ 0
{
ÆÆ 
return
ØØ 

BadRequest
ØØ %
(
ØØ% &
validationError
ØØ& 5
)
ØØ5 6
;
ØØ6 7
}
∞∞ 
var
≤≤ 
result
≤≤ 
=
≤≤ 
await
≤≤ "$
_customerMasterService
≤≤# 9
.
≤≤9 :
UpdateCustomer
≤≤: H
(
≤≤H I
values
≤≤I O
)
≤≤O P
;
≤≤P Q
if
≥≥ 
(
≥≥ 
result
≥≥ 
.
≥≥ 
	IsSuccess
≥≥ $
)
≥≥$ %
{
¥¥ 
return
µµ 
Ok
µµ 
(
µµ 
result
µµ $
.
µµ$ %
SuccessResponse
µµ% 4
)
µµ4 5
;
µµ5 6
}
∂∂ 
var
∏∏ 
status
∏∏ 
=
∏∏ 
result
∏∏ #
.
∏∏# $
ErrorResponse
∏∏$ 1
!
∏∏1 2
.
∏∏2 3

StatusCode
∏∏3 =
;
∏∏= >
return
ππ 
status
ππ 
switch
ππ $
{
∫∫ 
$num
ªª 
=>
ªª 
	NoContent
ªª $
(
ªª$ %
)
ªª% &
,
ªª& '
$num
ºº 
=>
ºº 

BadRequest
ºº %
(
ºº% &
result
ºº& ,
.
ºº, -
ErrorResponse
ºº- :
)
ºº: ;
,
ºº; <
$num
ΩΩ 
=>
ΩΩ 
NotFound
ΩΩ #
(
ΩΩ# $
result
ΩΩ$ *
.
ΩΩ* +
ErrorResponse
ΩΩ+ 8
)
ΩΩ8 9
,
ΩΩ9 :
_
ææ 
=>
ææ 

StatusCode
ææ #
(
ææ# $
$num
ææ$ '
,
ææ' (
result
ææ) /
.
ææ/ 0
ErrorResponse
ææ0 =
)
ææ= >
,
ææ> ?
}
øø 
;
øø 
}
¡¡ 
catch
¬¬ 
(
¬¬ 
	Exception
¬¬ 
ex
¬¬ 
)
¬¬  
{
√√ 
return
ƒƒ 

StatusCode
ƒƒ !
(
ƒƒ! "
$num
ƒƒ" %
,
ƒƒ% &
ex
ƒƒ' )
.
ƒƒ) *
InnerException
ƒƒ* 8
!
ƒƒ8 9
.
ƒƒ9 :
Message
ƒƒ: A
)
ƒƒA B
;
ƒƒB C
}
≈≈ 
}
∆∆ 	
[
ÀÀ 	
HttpPut
ÀÀ	 
]
ÀÀ 
[
ÃÃ 	
Route
ÃÃ	 
(
ÃÃ 
$str
ÃÃ )
)
ÃÃ) *
]
ÃÃ* +
[
ÕÕ 	
	Authorize
ÕÕ	 
(
ÕÕ 
Policy
ÕÕ 
=
ÕÕ 
$str
ÕÕ 9
)
ÕÕ9 :
]
ÕÕ: ;
[
ŒŒ 	
Obsolete
ŒŒ	 
]
ŒŒ 
public
œœ 
async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ &
>
œœ& '&
UpdateIndividualCustomer
œœ( @
(
œœ@ A
[
œœA B
FromBody
œœB J
]
œœJ K1
#UpdateIndividualResidentCustomerDto
œœL o
values
œœp v
)
œœv w
{
–– 	
try
—— 
{
““ 
if
”” 
(
”” 
!
”” 
IsAuthorized
”” !
(
””! "
values
””" (
.
””( )

ModifiedBy
””) 3
!
””3 4
)
””4 5
)
””5 6
{
‘‘ 
return
’’ 
Unauthorized
’’ '
(
’’' (
)
’’( )
;
’’) *
}
÷÷ 
var
ÿÿ 
validationError
ÿÿ #
=
ÿÿ$ %%
ValidateCustomerDetails
ÿÿ& =
(
ÿÿ= >
values
ÿÿ> D
)
ÿÿD E
;
ÿÿE F
if
ŸŸ 
(
ŸŸ 
validationError
ŸŸ #
is
ŸŸ$ &
not
ŸŸ' *
null
ŸŸ+ /
)
ŸŸ/ 0
{
⁄⁄ 
return
€€ 

BadRequest
€€ %
(
€€% &
validationError
€€& 5
)
€€5 6
;
€€6 7
}
‹‹ 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ $
_customerMasterService
ﬁﬁ  6
.
ﬁﬁ6 7
UpdateCustomer
ﬁﬁ7 E
(
ﬁﬁE F
values
ﬁﬁF L
)
ﬁﬁL M
)
ﬁﬁM N
;
ﬁﬁN O
}
ﬂﬂ 
catch
‡‡ 
(
‡‡ 
	Exception
‡‡ 
ex
‡‡ 
)
‡‡  
{
·· 
return
‚‚ 

StatusCode
‚‚ !
(
‚‚! "
$num
‚‚" %
,
‚‚% &
ex
‚‚' )
.
‚‚) *
InnerException
‚‚* 8
!
‚‚8 9
.
‚‚9 :
Message
‚‚: A
)
‚‚A B
;
‚‚B C
}
„„ 
}
‰‰ 	
[
ÈÈ 	
HttpPut
ÈÈ	 
]
ÈÈ 
[
ÍÍ 	
Route
ÍÍ	 
(
ÍÍ 
$str
ÍÍ $
)
ÍÍ$ %
]
ÍÍ% &
[
ÎÎ 	
	Authorize
ÎÎ	 
(
ÎÎ 
Policy
ÎÎ 
=
ÎÎ 
$str
ÎÎ 9
)
ÎÎ9 :
]
ÎÎ: ;
[
ÏÏ 	
Obsolete
ÏÏ	 
]
ÏÏ 
public
ÌÌ 
async
ÌÌ 
Task
ÌÌ 
<
ÌÌ 
ActionResult
ÌÌ &
>
ÌÌ& '!
UpdateJointCustomer
ÌÌ( ;
(
ÌÌ; <
[
ÌÌ< =
FromBody
ÌÌ= E
]
ÌÌE F-
UpdateJointOwnershipCustomerDto
ÌÌG f
values
ÌÌg m
)
ÌÌm n
{
ÓÓ 	
try
ÔÔ 
{
 
if
ÒÒ 
(
ÒÒ 
!
ÒÒ 
IsAuthorized
ÒÒ !
(
ÒÒ! "
values
ÒÒ" (
.
ÒÒ( )

ModifiedBy
ÒÒ) 3
!
ÒÒ3 4
)
ÒÒ4 5
)
ÒÒ5 6
{
ÚÚ 
return
ÛÛ 
Unauthorized
ÛÛ '
(
ÛÛ' (
)
ÛÛ( )
;
ÛÛ) *
}
ÙÙ 
var
ˆˆ 
validationError
ˆˆ #
=
ˆˆ$ %%
ValidateCustomerDetails
ˆˆ& =
(
ˆˆ= >
values
ˆˆ> D
)
ˆˆD E
;
ˆˆE F
if
˜˜ 
(
˜˜ 
validationError
˜˜ #
is
˜˜$ &
not
˜˜' *
null
˜˜+ /
)
˜˜/ 0
{
¯¯ 
return
˘˘ 

BadRequest
˘˘ %
(
˘˘% &
validationError
˘˘& 5
)
˘˘5 6
;
˘˘6 7
}
˙˙ 
return
˝˝ 
Ok
˝˝ 
(
˝˝ 
await
˝˝ $
_customerMasterService
˝˝  6
.
˝˝6 7
UpdateCustomer
˝˝7 E
(
˝˝E F
values
˝˝F L
)
˝˝L M
)
˝˝M N
;
˝˝N O
}
˛˛ 
catch
ˇˇ 
(
ˇˇ 
	Exception
ˇˇ 
ex
ˇˇ 
)
ˇˇ  
{
ÄÄ 
return
ÅÅ 

StatusCode
ÅÅ !
(
ÅÅ! "
$num
ÅÅ" %
,
ÅÅ% &
ex
ÅÅ' )
.
ÅÅ) *
InnerException
ÅÅ* 8
!
ÅÅ8 9
.
ÅÅ9 :
Message
ÅÅ: A
)
ÅÅA B
;
ÅÅB C
}
ÇÇ 
}
ÉÉ 	
[
àà 	
HttpPut
àà	 
]
àà 
[
ââ 	
Route
ââ	 
(
ââ 
$str
ââ $
)
ââ$ %
]
ââ% &
[
ää 	
	Authorize
ää	 
(
ää 
Policy
ää 
=
ää 
$str
ää 9
)
ää9 :
]
ää: ;
[
ãã 	
Obsolete
ãã	 
]
ãã 
public
åå 
async
åå 
Task
åå 
<
åå 
ActionResult
åå &
>
åå& '!
UpdateMultiCustomer
åå( ;
(
åå; <
[
åå< =
FromBody
åå= E
]
ååE F-
UpdateMultiOwnershipCustomerDto
ååG f
values
ååg m
)
ååm n
{
çç 	
try
éé 
{
èè 
if
êê 
(
êê 
!
êê 
IsAuthorized
êê !
(
êê! "
values
êê" (
.
êê( )

ModifiedBy
êê) 3
!
êê3 4
)
êê4 5
)
êê5 6
{
ëë 
return
íí 
Unauthorized
íí '
(
íí' (
)
íí( )
;
íí) *
}
ìì 
var
ïï 
validationError
ïï #
=
ïï$ %%
ValidateCustomerDetails
ïï& =
(
ïï= >
values
ïï> D
)
ïïD E
;
ïïE F
if
ññ 
(
ññ 
validationError
ññ #
is
ññ$ &
not
ññ' *
null
ññ+ /
)
ññ/ 0
{
óó 
return
òò 

BadRequest
òò %
(
òò% &
validationError
òò& 5
)
òò5 6
;
òò6 7
}
ôô 
return
õõ 
Ok
õõ 
(
õõ 
await
õõ $
_customerMasterService
õõ  6
.
õõ6 7
UpdateCustomer
õõ7 E
(
õõE F
values
õõF L
)
õõL M
)
õõM N
;
õõN O
}
úú 
catch
ùù 
(
ùù 
	Exception
ùù 
ex
ùù 
)
ùù  
{
ûû 
return
üü 

StatusCode
üü !
(
üü! "
$num
üü" %
,
üü% &
ex
üü' )
.
üü) *
InnerException
üü* 8
!
üü8 9
.
üü9 :
Message
üü: A
)
üüA B
;
üüB C
}
†† 
}
°° 	
[
¶¶ 	
HttpPut
¶¶	 
]
¶¶ 
[
ßß 	
Route
ßß	 
(
ßß 
$str
ßß &
)
ßß& '
]
ßß' (
[
®® 	
	Authorize
®®	 
(
®® 
Policy
®® 
=
®® 
$str
®® 9
)
®®9 :
]
®®: ;
public
©© 
async
©© 
Task
©© 
<
©© 
ActionResult
©© &
>
©©& '#
UpdateCustomerDetails
©©( =
(
©©= >
[
©©> ?
FromBody
©©? G
]
©©G H-
UpdateJointOwnershipCustomerDto
©©I h
values
©©i o
)
©©o p
{
™™ 	
try
´´ 
{
¨¨ 
if
≠≠ 
(
≠≠ 
!
≠≠ 
IsAuthorized
≠≠ !
(
≠≠! "
values
≠≠" (
.
≠≠( )

ModifiedBy
≠≠) 3
!
≠≠3 4
)
≠≠4 5
)
≠≠5 6
{
ÆÆ 
return
ØØ 
Unauthorized
ØØ '
(
ØØ' (
)
ØØ( )
;
ØØ) *
}
∞∞ 
return
≤≤ 
Ok
≤≤ 
(
≤≤ 
await
≤≤ $
_customerMasterService
≤≤  6
.
≤≤6 7
UpdateCustomer
≤≤7 E
(
≤≤E F
values
≤≤F L
)
≤≤L M
)
≤≤M N
;
≤≤N O
}
≥≥ 
catch
¥¥ 
(
¥¥ 
	Exception
¥¥ 
ex
¥¥ 
)
¥¥  
{
µµ 
return
∂∂ 

StatusCode
∂∂ !
(
∂∂! "
$num
∂∂" %
,
∂∂% &
ex
∂∂' )
.
∂∂) *
InnerException
∂∂* 8
!
∂∂8 9
.
∂∂9 :
Message
∂∂: A
)
∂∂A B
;
∂∂B C
}
∑∑ 
}
∏∏ 	
[
ææ 	

HttpDelete
ææ	 
(
ææ 
$str
ææ ?
)
ææ? @
]
ææ@ A
[
øø 	
	Authorize
øø	 
(
øø 
Policy
øø 
=
øø 
$str
øø 9
)
øø9 :
]
øø: ;
public
¿¿ 
async
¿¿ 
Task
¿¿ 
<
¿¿ 
ActionResult
¿¿ &
>
¿¿& '
DeleteCustomer
¿¿( 6
(
¿¿6 7
string
¿¿7 =
customerCode
¿¿> J
,
¿¿J K
string
¿¿L R
	deletedBy
¿¿S \
)
¿¿\ ]
{
¡¡ 	
try
¬¬ 
{
√√ 
if
ƒƒ 
(
ƒƒ 
string
ƒƒ 
.
ƒƒ  
IsNullOrWhiteSpace
ƒƒ -
(
ƒƒ- .
customerCode
ƒƒ. :
)
ƒƒ: ;
&&
ƒƒ< >
string
ƒƒ? E
.
ƒƒE F 
IsNullOrWhiteSpace
ƒƒF X
(
ƒƒX Y
	deletedBy
ƒƒY b
)
ƒƒb c
)
ƒƒc d
{
≈≈ 
return
∆∆ 

BadRequest
∆∆ %
(
∆∆% &
$str
∆∆& _
)
∆∆_ `
;
∆∆` a
}
«« 
var
…… 
values
…… 
=
…… 
new
……  &
DeleteCustomerRequestDto
……! 9
(
……9 :
customerCode
……: F
,
……F G
	deletedBy
……H Q
)
……Q R
;
……R S
var
   
response
   
=
   
await
   $$
_customerMasterService
  % ;
.
  ; <!
DeleteCustomerAsync
  < O
(
  O P
values
  P V
)
  V W
;
  W X
return
ÃÃ 
response
ÃÃ 
switch
ÃÃ  &
{
ÕÕ 
$num
ŒŒ 
=>
ŒŒ 
Ok
ŒŒ 
(
ŒŒ 
$str
ŒŒ 5
)
ŒŒ5 6
,
ŒŒ6 7
$num
œœ 
=>
œœ 

BadRequest
œœ %
(
œœ% &
)
œœ& '
,
œœ' (
$num
–– 
=>
–– 
NotFound
–– #
(
––# $
$str
––$ L
)
––L M
,
––M N
_
—— 
=>
—— 

StatusCode
—— #
(
——# $
$num
——$ '
,
——' (
$str
——) @
)
——@ A
,
——A B
}
““ 
;
““ 
}
”” 
catch
‘‘ 
(
‘‘ 
	Exception
‘‘ 
ex
‘‘ 
)
‘‘  
{
’’ 
return
÷÷ 

StatusCode
÷÷ !
(
÷÷! "
$num
÷÷" %
,
÷÷% &
ex
÷÷' )
.
÷÷) *
InnerException
÷÷* 8
!
÷÷8 9
.
÷÷9 :
Message
÷÷: A
)
÷÷A B
;
÷÷B C
}
◊◊ 
}
ÿÿ 	
[
›› 	
HttpPut
››	 
]
›› 
[
ﬁﬁ 	
Route
ﬁﬁ	 
(
ﬁﬁ 
$str
ﬁﬁ "
)
ﬁﬁ" #
]
ﬁﬁ# $
[
ﬂﬂ 	
	Authorize
ﬂﬂ	 
(
ﬂﬂ 
Policy
ﬂﬂ 
=
ﬂﬂ 
$str
ﬂﬂ 9
)
ﬂﬂ9 :
]
ﬂﬂ: ;
public
‡‡ 
async
‡‡ 
Task
‡‡ 
<
‡‡ 
ActionResult
‡‡ &
>
‡‡& '
StopCustomerDebit
‡‡( 9
(
‡‡9 :
[
‡‡: ;
FromBody
‡‡; C
]
‡‡C D!
StopDebitRequestDto
‡‡E X
values
‡‡Y _
)
‡‡_ `
{
·· 	
try
‚‚ 
{
„„ 
var
‰‰ 
userId
‰‰ 
=
‰‰ !
_userContextService
‰‰ 0
.
‰‰0 1
	GetUserId
‰‰1 :
(
‰‰: ;
)
‰‰; <
;
‰‰< =
if
ÂÂ 
(
ÂÂ 
!
ÂÂ 
string
ÂÂ 
.
ÂÂ 
Equals
ÂÂ "
(
ÂÂ" #
userId
ÂÂ# )
,
ÂÂ) *
values
ÂÂ+ 1
.
ÂÂ1 2
ActionBy
ÂÂ2 :
)
ÂÂ: ;
)
ÂÂ; <
{
ÊÊ 
return
ÁÁ 
Unauthorized
ÁÁ '
(
ÁÁ' (
)
ÁÁ( )
;
ÁÁ) *
}
ËË 
var
ÍÍ 
status
ÍÍ 
=
ÍÍ 
await
ÍÍ "$
_customerMasterService
ÍÍ# 9
.
ÍÍ9 :$
StopCustomerDebitAsync
ÍÍ: P
(
ÍÍP Q
values
ÍÍQ W
)
ÍÍW X
;
ÍÍX Y
return
ÏÏ 
status
ÏÏ 
switch
ÏÏ $
{
ÌÌ 
$num
ÓÓ 
=>
ÓÓ 
Ok
ÓÓ 
(
ÓÓ 
$str
ÓÓ '
)
ÓÓ' (
,
ÓÓ( )
$num
ÔÔ 
=>
ÔÔ 

BadRequest
ÔÔ %
(
ÔÔ% &
)
ÔÔ& '
,
ÔÔ' (
$num
 
=>
 
NotFound
 #
(
# $
$"
$ &
$str
& 4
{
4 5
values
5 ;
.
; <
CustomerCode
< H
}
H I
$str
I S
"
S T
)
T U
,
U V
$num
ÒÒ 
=>
ÒÒ 

StatusCode
ÒÒ %
(
ÒÒ% &
$num
ÒÒ& )
,
ÒÒ) *
$str
ÒÒ* 8
)
ÒÒ8 9
,
ÒÒ9 :
_
ÚÚ 
=>
ÚÚ 

StatusCode
ÚÚ #
(
ÚÚ# $
$num
ÚÚ$ '
,
ÚÚ' (
$str
ÚÚ) @
)
ÚÚ@ A
,
ÚÚA B
}
ÛÛ 
;
ÛÛ 
;
ÛÛ 
}
ıı 
catch
ˆˆ 
(
ˆˆ 
	Exception
ˆˆ 
ex
ˆˆ 
)
ˆˆ  
{
˜˜ 
return
¯¯ 

StatusCode
¯¯ !
(
¯¯! "
$num
¯¯" %
,
¯¯% &
ex
¯¯' )
.
¯¯) *
InnerException
¯¯* 8
!
¯¯8 9
.
¯¯9 :
Message
¯¯: A
)
¯¯A B
;
¯¯B C
}
˘˘ 
}
˙˙ 	
[
ˇˇ 	
HttpPut
ˇˇ	 
]
ˇˇ 
[
ÄÄ 	
Route
ÄÄ	 
(
ÄÄ 
$str
ÄÄ $
)
ÄÄ$ %
]
ÄÄ% &
[
ÅÅ 	
	Authorize
ÅÅ	 
(
ÅÅ 
Policy
ÅÅ 
=
ÅÅ 
$str
ÅÅ 9
)
ÅÅ9 :
]
ÅÅ: ;
public
ÇÇ 
async
ÇÇ 
Task
ÇÇ 
<
ÇÇ 
ActionResult
ÇÇ &
>
ÇÇ& '!
UnstopCustomerDebit
ÇÇ( ;
(
ÇÇ; <
[
ÇÇ< =
FromBody
ÇÇ= E
]
ÇÇE F!
StopDebitRequestDto
ÇÇG Z
values
ÇÇ[ a
)
ÇÇa b
{
ÉÉ 	
try
ÑÑ 
{
ÖÖ 
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
áá1 2
ActionBy
áá2 :
)
áá: ;
)
áá; <
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
ää 
var
åå 
status
åå 
=
åå 
await
åå "$
_customerMasterService
åå# 9
.
åå9 :$
StopCustomerDebitAsync
åå: P
(
ååP Q
values
ååQ W
)
ååW X
;
ååX Y
return
éé 
status
éé 
switch
éé $
{
èè 
$num
êê 
=>
êê 
Ok
êê 
(
êê 
$str
êê '
)
êê' (
,
êê( )
$num
ëë 
=>
ëë 

BadRequest
ëë %
(
ëë% &
)
ëë& '
,
ëë' (
$num
íí 
=>
íí 
NotFound
íí #
(
íí# $
$"
íí$ &
$str
íí& 4
{
íí4 5
values
íí5 ;
.
íí; <
CustomerCode
íí< H
}
ííH I
$str
ííI S
"
ííS T
)
ííT U
,
ííU V
$num
ìì 
=>
ìì 

StatusCode
ìì %
(
ìì% &
$num
ìì& )
,
ìì) *
$str
ìì+ 9
)
ìì9 :
,
ìì: ;
_
îî 
=>
îî 

StatusCode
îî #
(
îî# $
$num
îî$ '
,
îî' (
$str
îî) @
)
îî@ A
,
îîA B
}
ïï 
;
ïï 
}
óó 
catch
òò 
(
òò 
	Exception
òò 
ex
òò 
)
òò  
{
ôô 
return
öö 

StatusCode
öö !
(
öö! "
$num
öö" %
,
öö% &
ex
öö' )
.
öö) *
InnerException
öö* 8
!
öö8 9
.
öö9 :
Message
öö: A
)
ööA B
;
ööB C
}
õõ 
}
úú 	
private
¢¢ 
bool
¢¢ 
IsAuthorized
¢¢ !
(
¢¢! "
string
¢¢" (

modifiedBy
¢¢) 3
)
¢¢3 4
{
££ 	
var
§§ 
userId
§§ 
=
§§ !
_userContextService
§§ ,
.
§§, -
	GetUserId
§§- 6
(
§§6 7
)
§§7 8
;
§§8 9
return
•• 
string
•• 
.
•• 
Equals
••  
(
••  !
userId
••! '
,
••' (

modifiedBy
••) 3
)
••3 4
;
••4 5
}
¶¶ 	
private
´´ 
string
´´ 
?
´´ %
ValidateCustomerDetails
´´ /
(
´´/ 0
dynamic
´´0 7
values
´´8 >
)
´´> ?
{
¨¨ 	
return
≠≠ 
values
≠≠ 
.
≠≠ 
ResidentTypeId
≠≠ (
switch
≠≠) /
{
ÆÆ 
(
ØØ 
int
ØØ 
)
ØØ 
ResidentTypeEnum
ØØ %
.
ØØ% &

EXPATRIATE
ØØ& 0
=>
ØØ1 3 
ValidateExpatriate
ØØ4 F
(
ØØF G
values
ØØG M
.
ØØM N

Expatriate
ØØN X
)
ØØX Y
,
ØØY Z
(
∞∞ 
int
∞∞ 
)
∞∞ 
ResidentTypeEnum
∞∞ %
.
∞∞% &
NON_RESIDENT
∞∞& 2
=>
∞∞3 5!
ValidateNonResident
∞∞6 I
(
∞∞I J
values
∞∞J P
.
∞∞P Q
NonResident
∞∞Q \
)
∞∞\ ]
,
∞∞] ^
_
±± 
=>
±± 
null
±± 
}
≤≤ 
;
≤≤ 
}
≥≥ 	
private
∏∏ 
static
∏∏ 
string
∏∏ 
?
∏∏  
ValidateExpatriate
∏∏ 1
(
∏∏1 2-
IndividualExpatriateCustomerDto
∏∏2 Q
?
∏∏Q R

expatriate
∏∏S ]
)
∏∏] ^
{
ππ 	
if
∫∫ 
(
∫∫ 

expatriate
∫∫ 
is
∫∫ 
null
∫∫ "
)
∫∫" #
return
∫∫$ *
CustomerConstants
∫∫+ <
.
∫∫< =!
ErrorExpatriateNull
∫∫= P
;
∫∫P Q
if
ªª 
(
ªª 
string
ªª 
.
ªª  
IsNullOrWhiteSpace
ªª )
(
ªª) *

expatriate
ªª* 4
.
ªª4 5"
ResidentPermitNumber
ªª5 I
)
ªªI J
)
ªªJ K
return
ªªL R
CustomerConstants
ªªS d
.
ªªd e%
ErrorResidentPermitNull
ªªe |
;
ªª| }
return
ºº 
null
ºº 
;
ºº 
}
ΩΩ 	
private
¬¬ 
static
¬¬ 
string
¬¬ 
?
¬¬ !
ValidateNonResident
¬¬ 2
(
¬¬2 3.
 IndividualNonResidentCustomerDto
¬¬3 S
?
¬¬S T
nonResident
¬¬U `
)
¬¬` a
{
√√ 	
if
ƒƒ 
(
ƒƒ 
nonResident
ƒƒ 
is
ƒƒ 
null
ƒƒ #
)
ƒƒ# $
return
ƒƒ% +
CustomerConstants
ƒƒ, =
.
ƒƒ= >"
ErrorNonResidentNull
ƒƒ> R
;
ƒƒR S
if
≈≈ 
(
≈≈ 
string
≈≈ 
.
≈≈  
IsNullOrWhiteSpace
≈≈ )
(
≈≈) *
nonResident
≈≈* 5
.
≈≈5 6$
ContactPerson_FullName
≈≈6 L
)
≈≈L M
)
≈≈M N
return
≈≈O U
CustomerConstants
≈≈V g
.
≈≈g h'
ErrorContactFullNameNull≈≈h Ä
;≈≈Ä Å
if
∆∆ 
(
∆∆ 
string
∆∆ 
.
∆∆  
IsNullOrWhiteSpace
∆∆ )
(
∆∆) *
nonResident
∆∆* 5
.
∆∆5 6(
ContactPerson_EmailAddress
∆∆6 P
)
∆∆P Q
)
∆∆Q R
return
∆∆S Y
CustomerConstants
∆∆Z k
.
∆∆k l$
ErrorContactEmailNull∆∆l Å
;∆∆Å Ç
if
«« 
(
«« 
string
«« 
.
««  
IsNullOrWhiteSpace
«« )
(
««) *
nonResident
««* 5
.
««5 6'
ContactPerson_PhoneNumber
««6 O
)
««O P
)
««P Q
return
««R X
CustomerConstants
««Y j
.
««j k$
ErrorContactPhoneNull««k Ä
;««Ä Å
return
»» 
null
»» 
;
»» 
}
…… 	
}
ÕÕ 
}ŒŒ úú
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
[ 
	Authorize 
( !
AuthenticationSchemes $
=% &
JwtBearerDefaults' 8
.8 9 
AuthenticationScheme9 M
)M N
]N O
[ 
	Authorize 
( 
Policy 
= 
$str 3
)3 4
]4 5
public 

partial 
class 
CustomerController +
:, -
ControllerBase. <
{   
readonly!!  
ICustomerTypeService!! % 
_customerTypeService!!& :
;!!: ;
readonly"" 
IGenderService"" 
_genderService""  .
;"". /
readonly## &
IIdentificationTypeService## +&
_identificationTypeService##, F
;##F G
readonly$$ 
INationalityService$$ $
_nationalityService$$% 8
;$$8 9
readonly%%  
IResidentTypeService%% % 
_residentTypeService%%& :
;%%: ;
readonly&& 
ISocialMediaService&& $
_socialMediaService&&% 8
;&&8 9
readonly'' 
ITitleService'' 
_titleService'' ,
;'', -
readonly(( !
IOwnershipTypeService(( &!
_ownershipTypeService((' <
;((< =
readonly)) "
ICustomerMasterService)) '"
_customerMasterService))( >
;))> ?
readonly** 
IUserContextService** $
_userContextService**% 8
;**8 9
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
_customerMasterService66 "
=66# $!
customerMasterService66% :
;66: ;!
_ownershipTypeService77 !
=77" # 
ownershipTypeService77$ 8
;778 9
_userContextService88 
=88  !
userContextService88" 4
;884 5
}99 	
[?? 	
HttpGet??	 
]?? 
[@@ 	
Route@@	 
(@@ 
$str@@ !
)@@! "
]@@" #
publicAA 
asyncAA 
TaskAA 
<AA 
ActionResultAA &
<AA& '
IEnumerableAA' 2
<AA2 3
CustomerTypeReadDtoAA3 F
>AAF G
>AAG H
>AAH I
GetCustomerTypesAAJ Z
(AAZ [
)AA[ \
{BB 	
returnCC 
OkCC 
(CC 
awaitCC  
_customerTypeServiceCC 0
.CC0 1 
GetCustomerTypeAsyncCC1 E
(CCE F
)CCF G
)CCG H
;CCH I
}DD 	
[WW 	
HttpPostWW	 
]WW 
[XX 	
RouteXX	 
(XX 
$strXX #
)XX# $
]XX$ %
[YY 	
	AuthorizeYY	 
(YY 
PolicyYY 
=YY 
$strYY 9
)YY9 :
]YY: ;
publicZZ 
asyncZZ 
TaskZZ 
<ZZ 
ActionResultZZ &
<ZZ& '
CustomerTypeReadDtoZZ' :
>ZZ: ;
>ZZ; <
CreateCustomerTypeZZ= O
(ZZO P
[ZZP Q
FromBodyZZQ Y
]ZZY Z!
CustomerTypeCreateDtoZZ[ p
valuesZZq w
)ZZw x
{[[ 	
try\\ 
{]] 
var^^ 
userId^^ 
=^^ 
_userContextService^^ 0
.^^0 1
	GetUserId^^1 :
(^^: ;
)^^; <
;^^< =
if`` 
(`` 
!`` 
string`` 
.`` 
Equals`` !
(``! "
userId``" (
,``( )
values``* 0
.``0 1
	createdBy``1 :
)``: ;
)``; <
{aa 
returnbb 
Unauthorizedbb '
(bb' (
)bb( )
;bb) *
}cc 
returnee 
Okee 
(ee 
awaitee  
_customerTypeServiceee  4
.ee4 5 
AddCustomerTypeAsyncee5 I
(eeI J
valueseeJ P
)eeP Q
)eeQ R
;eeR S
}ff 
catchgg 
(gg 
	Exceptiongg 
exgg 
)gg  
{hh 
returnii 

StatusCodeii !
(ii! "
$numii" %
,ii% &
exii' )
.ii) *
InnerExceptionii* 8
!ii8 9
.ii9 :
Messageii: A
)iiA B
;iiB C
}jj 
}kk 	
[|| 	
HttpPut||	 
]|| 
[}} 	
Route}}	 
(}} 
$str}} #
)}}# $
]}}$ %
[~~ 	
	Authorize~~	 
(~~ 
Policy~~ 
=~~ 
$str~~ 9
)~~9 :
]~~: ;
public 
async 
Task 
< 
ActionResult &
<& '
CustomerTypeReadDto' :
>: ;
>; <
UpdateCustomerType= O
(O P
[P Q
FromBodyQ Y
]Y Z!
CustomerTypeUpdateDto[ p
valuesq w
)w x
{
ÄÄ 	
var
ÅÅ 
userId
ÅÅ 
=
ÅÅ !
_userContextService
ÅÅ ,
.
ÅÅ, -
	GetUserId
ÅÅ- 6
(
ÅÅ6 7
)
ÅÅ7 8
;
ÅÅ8 9
if
ÇÇ 
(
ÇÇ 
!
ÇÇ 
string
ÇÇ 
.
ÇÇ 
Equals
ÇÇ 
(
ÇÇ 
userId
ÇÇ %
,
ÇÇ% &
values
ÇÇ' -
.
ÇÇ- .

modifiedBy
ÇÇ. 8
)
ÇÇ8 9
)
ÇÇ9 :
{
ÉÉ 
return
ÑÑ 
Unauthorized
ÑÑ #
(
ÑÑ# $
)
ÑÑ$ %
;
ÑÑ% &
}
ÖÖ 
return
áá 
Ok
áá 
(
áá 
await
áá "
_customerTypeService
áá 0
.
áá0 1%
UpdateCustomerTypeAsync
áá1 H
(
ááH I
values
ááI O
)
ááO P
)
ááP Q
;
ááQ R
}
àà 	
[
çç 	

HttpDelete
çç	 
(
çç 
$str
çç 9
)
çç9 :
]
çç: ;
[
éé 	
	Authorize
éé	 
(
éé 
Policy
éé 
=
éé 
$str
éé 9
)
éé9 :
]
éé: ;
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
>
èè& ' 
DeleteCustomerType
èè( :
(
èè: ;
int
èè; >
customerTypeId
èè? M
)
èèM N
{
êê 	
var
ëë 
response
ëë 
=
ëë 
await
ëë  "
_customerTypeService
ëë! 5
.
ëë5 6$
DeleteCustomerTyeAsync
ëë6 L
(
ëëL M
customerTypeId
ëëM [
)
ëë[ \
;
ëë\ ]
if
ìì 
(
ìì 
response
ìì 
==
ìì 
$str
ìì $
)
ìì$ %
{
îî 
return
ïï 
Ok
ïï 
(
ïï 
await
ïï "
_customerTypeService
ïï  4
.
ïï4 5$
DeleteCustomerTyeAsync
ïï5 K
(
ïïK L
customerTypeId
ïïL Z
)
ïïZ [
)
ïï[ \
;
ïï\ ]
}
ññ 
return
òò 

BadRequest
òò 
(
òò 
)
òò 
;
òò  
}
ôô 	
[
üü 	
HttpGet
üü	 
]
üü 
[
†† 	
Route
††	 
(
†† 
$str
†† 
)
†† 
]
†† 
public
°° 
async
°° 
Task
°° 
<
°° 
ActionResult
°° &
<
°°& '
IEnumerable
°°' 2
<
°°2 3
GenderReadDto
°°3 @
>
°°@ A
>
°°A B
>
°°B C
	GetGender
°°D M
(
°°M N
)
°°N O
{
¢¢ 	
return
££ 
Ok
££ 
(
££ 
await
££ 
_genderService
££ *
.
££* +
GetGenderAsync
££+ 9
(
££9 :
)
££: ;
)
££; <
;
££< =
}
§§ 	
[
©© 	
HttpGet
©©	 
]
©© 
[
™™ 	
Route
™™	 
(
™™ 
$str
™™ "
)
™™" #
]
™™# $
private
´´ 
async
´´ 
Task
´´ 
<
´´ 
ActionResult
´´ '
<
´´' (
GenderReadDto
´´( 5
>
´´5 6
>
´´6 7
	GetGender
´´8 A
(
´´A B
string
´´B H
value
´´I N
)
´´N O
{
¨¨ 	
return
≠≠ 
Ok
≠≠ 
(
≠≠ 
await
≠≠ 
_genderService
≠≠ *
.
≠≠* +
GetGenderAsync
≠≠+ 9
(
≠≠9 :
value
≠≠: ?
)
≠≠? @
)
≠≠@ A
;
≠≠A B
}
ÆÆ 	
[
≥≥ 	
HttpGet
≥≥	 
]
≥≥ 
[
¥¥ 	
Route
¥¥	 
(
¥¥ 
$str
¥¥ %
)
¥¥% &
]
¥¥& '
public
µµ 
async
µµ 
Task
µµ 
<
µµ 
ActionResult
µµ &
<
µµ& '
GenderReadDto
µµ' 4
>
µµ4 5
>
µµ5 6
	GetGender
µµ7 @
(
µµ@ A
int
µµA D
genderId
µµE M
)
µµM N
{
∂∂ 	
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
await
∑∑ 
_genderService
∑∑ *
.
∑∑* +
GetGenderAsync
∑∑+ 9
(
∑∑9 :
genderId
∑∑: B
)
∑∑B C
)
∑∑C D
;
∑∑D E
}
∏∏ 	
[
…… 	
HttpPost
……	 
]
…… 
[
   	
Route
  	 
(
   
$str
   
)
   
]
   
[
ÀÀ 	
	Authorize
ÀÀ	 
(
ÀÀ 
Policy
ÀÀ 
=
ÀÀ 
$str
ÀÀ 9
)
ÀÀ9 :
]
ÀÀ: ;
public
ÃÃ 
async
ÃÃ 
Task
ÃÃ 
<
ÃÃ 
ActionResult
ÃÃ &
<
ÃÃ& '
GenderReadDto
ÃÃ' 4
>
ÃÃ4 5
>
ÃÃ5 6
CreateGender
ÃÃ7 C
(
ÃÃC D
[
ÃÃD E
FromBody
ÃÃE M
]
ÃÃM N
GenderCreateDto
ÃÃO ^
values
ÃÃ_ e
)
ÃÃe f
{
ÕÕ 	
try
ŒŒ 
{
œœ 
var
–– 
userId
–– 
=
–– !
_userContextService
–– 0
.
––0 1
	GetUserId
––1 :
(
––: ;
)
––; <
;
––< =
if
““ 
(
““ 
!
““ 
string
““ 
.
““ 
Equals
““ "
(
““" #
userId
““# )
,
““) *
values
““+ 1
.
““1 2
	createdBy
““2 ;
)
““; <
)
““< =
{
”” 
return
‘‘ 
Unauthorized
‘‘ '
(
‘‘' (
)
‘‘( )
;
‘‘) *
}
’’ 
return
◊◊ 
Ok
◊◊ 
(
◊◊ 
await
◊◊ 
_genderService
◊◊  .
.
◊◊. /
AddGenderAsync
◊◊/ =
(
◊◊= >
values
◊◊> D
)
◊◊D E
)
◊◊E F
;
◊◊F G
}
ÿÿ 
catch
ŸŸ 
(
ŸŸ 
	Exception
ŸŸ 
ex
ŸŸ 
)
ŸŸ  
{
⁄⁄ 
return
€€ 

StatusCode
€€ !
(
€€! "
$num
€€" %
,
€€% &
ex
€€' )
.
€€) *
InnerException
€€* 8
!
€€8 9
.
€€9 :
Message
€€: A
)
€€A B
;
€€B C
}
‹‹ 
}
›› 	
[
ÓÓ 	
HttpPut
ÓÓ	 
]
ÓÓ 
[
ÔÔ 	
Route
ÔÔ	 
(
ÔÔ 
$str
ÔÔ 
)
ÔÔ 
]
ÔÔ 
[
 	
	Authorize
	 
(
 
Policy
 
=
 
$str
 9
)
9 :
]
: ;
public
ÒÒ 
async
ÒÒ 
Task
ÒÒ 
<
ÒÒ 
ActionResult
ÒÒ &
<
ÒÒ& '
GenderReadDto
ÒÒ' 4
>
ÒÒ4 5
>
ÒÒ5 6
UpdateGender
ÒÒ7 C
(
ÒÒC D
[
ÒÒD E
FromBody
ÒÒE M
]
ÒÒM N
GenderUpdateDto
ÒÒO ^
values
ÒÒ_ e
)
ÒÒe f
{
ÚÚ 	
var
ÛÛ 
userId
ÛÛ 
=
ÛÛ !
_userContextService
ÛÛ ,
.
ÛÛ, -
	GetUserId
ÛÛ- 6
(
ÛÛ6 7
)
ÛÛ7 8
;
ÛÛ8 9
if
ÙÙ 
(
ÙÙ 
!
ÙÙ 
string
ÙÙ 
.
ÙÙ 
Equals
ÙÙ 
(
ÙÙ 
userId
ÙÙ %
,
ÙÙ% &
values
ÙÙ' -
.
ÙÙ- .

modifiedBy
ÙÙ. 8
)
ÙÙ8 9
)
ÙÙ9 :
{
ıı 
return
ˆˆ 
Unauthorized
ˆˆ #
(
ˆˆ# $
)
ˆˆ$ %
;
ˆˆ% &
}
˜˜ 
return
˘˘ 
Ok
˘˘ 
(
˘˘ 
await
˘˘ 
_genderService
˘˘ *
.
˘˘* +
UpdateGenderAsync
˘˘+ <
(
˘˘< =
values
˘˘= C
)
˘˘C D
)
˘˘D E
;
˘˘E F
}
˙˙ 	
[
ˇˇ 	

HttpDelete
ˇˇ	 
(
ˇˇ 
$str
ˇˇ -
)
ˇˇ- .
]
ˇˇ. /
[
ÄÄ 	
	Authorize
ÄÄ	 
(
ÄÄ 
Policy
ÄÄ 
=
ÄÄ 
$str
ÄÄ 9
)
ÄÄ9 :
]
ÄÄ: ;
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
>
ÅÅ& '
DeleteGender
ÅÅ( 4
(
ÅÅ4 5
int
ÅÅ5 8
genderId
ÅÅ9 A
)
ÅÅA B
{
ÇÇ 	
return
ÉÉ 
Ok
ÉÉ 
(
ÉÉ 
await
ÉÉ 
_genderService
ÉÉ *
.
ÉÉ* +
DeleteGenderAsync
ÉÉ+ <
(
ÉÉ< =
genderId
ÉÉ= E
)
ÉÉE F
)
ÉÉF G
;
ÉÉG H
}
ÑÑ 	
[
ää 	
HttpGet
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
ãã '
)
ãã' (
]
ãã( )
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
åå& '
IEnumerable
åå' 2
<
åå2 3'
IdentificationTypeReadDto
åå3 L
>
ååL M
>
ååM N
>
ååN O$
GetIdentificationTypes
ååP f
(
ååf g
)
ååg h
{
çç 	
return
éé 
Ok
éé 
(
éé 
await
éé (
_identificationTypeService
éé 6
.
éé6 7(
GetIdentificationTypeAsync
éé7 Q
(
ééQ R
)
ééR S
)
ééS T
;
ééT U
}
èè 	
[
°° 	
HttpPost
°°	 
]
°° 
[
¢¢ 	
Route
¢¢	 
(
¢¢ 
$str
¢¢ )
)
¢¢) *
]
¢¢* +
[
££ 	
	Authorize
££	 
(
££ 
Policy
££ 
=
££ 
$str
££ 9
)
££9 :
]
££: ;
public
§§ 
async
§§ 
Task
§§ 
<
§§ 
ActionResult
§§ &
<
§§& ''
IdentificationTypeReadDto
§§' @
>
§§@ A
>
§§A B&
CreateIdentificationType
§§C [
(
§§[ \
[
§§\ ]
FromBody
§§] e
]
§§e f*
IdentificationTypeCreateDto§§g Ç
values§§É â
)§§â ä
{
•• 	
try
¶¶ 
{
ßß 
var
®® 
userId
®® 
=
®® !
_userContextService
®® 0
.
®®0 1
	GetUserId
®®1 :
(
®®: ;
)
®®; <
;
®®< =
if
©© 
(
©© 
!
©© 
string
©© 
.
©© 
Equals
©© "
(
©©" #
userId
©©# )
,
©©) *
values
©©+ 1
.
©©1 2
	createdBy
©©2 ;
)
©©; <
)
©©< =
{
™™ 
return
´´ 
Unauthorized
´´ '
(
´´' (
)
´´( )
;
´´) *
}
¨¨ 
return
ÆÆ 
Ok
ÆÆ 
(
ÆÆ 
await
ÆÆ (
_identificationTypeService
ÆÆ  :
.
ÆÆ: ;(
AddIdentificationTypeAsync
ÆÆ; U
(
ÆÆU V
values
ÆÆV \
)
ÆÆ\ ]
)
ÆÆ] ^
;
ÆÆ^ _
}
ØØ 
catch
∞∞ 
(
∞∞ 
	Exception
∞∞ 
ex
∞∞ 
)
∞∞  
{
±± 
return
≤≤ 

StatusCode
≤≤ !
(
≤≤! "
$num
≤≤" %
,
≤≤% &
ex
≤≤' )
.
≤≤) *
InnerException
≤≤* 8
!
≤≤8 9
.
≤≤9 :
Message
≤≤: A
)
≤≤A B
;
≤≤B C
}
≥≥ 
}
¥¥ 	
[
≈≈ 	
HttpPut
≈≈	 
]
≈≈ 
[
∆∆ 	
Route
∆∆	 
(
∆∆ 
$str
∆∆ )
)
∆∆) *
]
∆∆* +
[
«« 	
	Authorize
««	 
(
«« 
Policy
«« 
=
«« 
$str
«« 9
)
««9 :
]
««: ;
public
»» 
async
»» 
Task
»» 
<
»» 
ActionResult
»» &
<
»»& ''
IdentificationTypeReadDto
»»' @
>
»»@ A
>
»»A B 
UpdateCustomerType
»»C U
(
»»U V
[
»»V W
FromBody
»»W _
]
»»_ `)
IdentificationTypeUpdateDto
»»a |
values»»} É
)»»É Ñ
{
…… 	
var
   
userId
   
=
   !
_userContextService
   ,
.
  , -
	GetUserId
  - 6
(
  6 7
)
  7 8
;
  8 9
if
ÀÀ 
(
ÀÀ 
!
ÀÀ 
string
ÀÀ 
.
ÀÀ 
Equals
ÀÀ 
(
ÀÀ 
userId
ÀÀ %
,
ÀÀ% &
values
ÀÀ' -
.
ÀÀ- .

modifiedBy
ÀÀ. 8
)
ÀÀ8 9
)
ÀÀ9 :
{
ÃÃ 
return
ÕÕ 
Unauthorized
ÕÕ #
(
ÕÕ# $
)
ÕÕ$ %
;
ÕÕ% &
}
ŒŒ 
return
œœ 
Ok
œœ 
(
œœ 
await
œœ (
_identificationTypeService
œœ 6
.
œœ6 7+
UpdateIdentificationTypeAsync
œœ7 T
(
œœT U
values
œœU [
)
œœ[ \
)
œœ\ ]
;
œœ] ^
}
–– 	
[
’’ 	

HttpDelete
’’	 
(
’’ 
$str
’’ E
)
’’E F
]
’’F G
[
÷÷ 	
	Authorize
÷÷	 
(
÷÷ 
Policy
÷÷ 
=
÷÷ 
$str
÷÷ 9
)
÷÷9 :
]
÷÷: ;
public
◊◊ 
async
◊◊ 
Task
◊◊ 
<
◊◊ 
ActionResult
◊◊ &
>
◊◊& '&
DeleteIdentificationType
◊◊( @
(
◊◊@ A
int
◊◊A D"
identificationTypeId
◊◊E Y
)
◊◊Y Z
{
ÿÿ 	
return
ŸŸ 
Ok
ŸŸ 
(
ŸŸ 
await
ŸŸ (
_identificationTypeService
ŸŸ 6
.
ŸŸ6 7+
DeleteIdentificationTypeAsync
ŸŸ7 T
(
ŸŸT U"
identificationTypeId
ŸŸU i
)
ŸŸi j
)
ŸŸj k
;
ŸŸk l
}
⁄⁄ 	
[
‡‡ 	
HttpGet
‡‡	 
]
‡‡ 
[
·· 	
Route
··	 
(
·· 
$str
·· 
)
··  
]
··  !
public
‚‚ 
async
‚‚ 
Task
‚‚ 
<
‚‚ 
ActionResult
‚‚ &
<
‚‚& '
IEnumerable
‚‚' 2
<
‚‚2 3 
NationalityReadDto
‚‚3 E
>
‚‚E F
>
‚‚F G
>
‚‚G H
GetNationality
‚‚I W
(
‚‚W X
)
‚‚X Y
{
„„ 	
return
‰‰ 
Ok
‰‰ 
(
‰‰ 
await
‰‰ !
_nationalityService
‰‰ /
.
‰‰/ 0!
GetNationalityAsync
‰‰0 C
(
‰‰C D
)
‰‰D E
)
‰‰E F
;
‰‰F G
}
ÂÂ 	
[
ˆˆ 	
HttpPost
ˆˆ	 
]
ˆˆ 
[
˜˜ 	
Route
˜˜	 
(
˜˜ 
$str
˜˜ "
)
˜˜" #
]
˜˜# $
[
¯¯ 	
	Authorize
¯¯	 
(
¯¯ 
Policy
¯¯ 
=
¯¯ 
$str
¯¯ 9
)
¯¯9 :
]
¯¯: ;
public
˘˘ 
async
˘˘ 
Task
˘˘ 
<
˘˘ 
ActionResult
˘˘ &
<
˘˘& ' 
NationalityReadDto
˘˘' 9
>
˘˘9 :
>
˘˘: ;
CreateNationality
˘˘< M
(
˘˘M N
[
˘˘N O
FromBody
˘˘O W
]
˘˘W X"
NationalityCreateDto
˘˘Y m
values
˘˘n t
)
˘˘t u
{
˙˙ 	
try
˚˚ 
{
¸¸ 
var
˝˝ 
userId
˝˝ 
=
˝˝ !
_userContextService
˝˝ 0
.
˝˝0 1
	GetUserId
˝˝1 :
(
˝˝: ;
)
˝˝; <
;
˝˝< =
if
˛˛ 
(
˛˛ 
!
˛˛ 
string
˛˛ 
.
˛˛ 
Equals
˛˛ "
(
˛˛" #
userId
˛˛# )
,
˛˛) *
values
˛˛+ 1
.
˛˛1 2
	createdby
˛˛2 ;
)
˛˛; <
)
˛˛< =
{
ˇˇ 
return
ÄÄ 
Unauthorized
ÄÄ '
(
ÄÄ' (
)
ÄÄ( )
;
ÄÄ) *
}
ÅÅ 
return
ÉÉ 
Ok
ÉÉ 
(
ÉÉ 
await
ÉÉ !
_nationalityService
ÉÉ  3
.
ÉÉ3 4!
AddNationalityAsync
ÉÉ4 G
(
ÉÉG H
values
ÉÉH N
)
ÉÉN O
)
ÉÉO P
;
ÉÉP Q
}
ÑÑ 
catch
ÖÖ 
(
ÖÖ 
	Exception
ÖÖ 
ex
ÖÖ 
)
ÖÖ  
{
ÜÜ 
return
áá 

StatusCode
áá !
(
áá! "
$num
áá" %
,
áá% &
ex
áá' )
.
áá) *
InnerException
áá* 8
!
áá8 9
.
áá9 :
Message
áá: A
)
ááA B
;
ááB C
}
àà 
}
ââ 	
[
ôô 	
HttpPut
ôô	 
]
ôô 
[
öö 	
Route
öö	 
(
öö 
$str
öö "
)
öö" #
]
öö# $
[
õõ 	
	Authorize
õõ	 
(
õõ 
Policy
õõ 
=
õõ 
$str
õõ 9
)
õõ9 :
]
õõ: ;
public
úú 
async
úú 
Task
úú 
<
úú 
ActionResult
úú &
<
úú& ' 
NationalityReadDto
úú' 9
>
úú9 :
>
úú: ;
UpdateNationality
úú< M
(
úúM N
[
úúN O
FromBody
úúO W
]
úúW X"
NationalityUpdateDto
úúY m
values
úún t
)
úút u
{
ùù 	
var
ûû 
userId
ûû 
=
ûû !
_userContextService
ûû ,
.
ûû, -
	GetUserId
ûû- 6
(
ûû6 7
)
ûû7 8
;
ûû8 9
if
üü 
(
üü 
!
üü 
string
üü 
.
üü 
Equals
üü 
(
üü 
userId
üü %
,
üü% &
values
üü' -
.
üü- .

modifiedby
üü. 8
)
üü8 9
)
üü9 :
{
†† 
return
°° 
Unauthorized
°° #
(
°°# $
)
°°$ %
;
°°% &
}
¢¢ 
return
££ 
Ok
££ 
(
££ 
await
££ !
_nationalityService
££ /
.
££/ 0$
UpdateNationalityAsync
££0 F
(
££F G
values
££G M
)
££M N
)
££N O
;
££O P
}
§§ 	
[
©© 	

HttpDelete
©©	 
(
©© 
$str
©© 7
)
©©7 8
]
©©8 9
[
™™ 	
	Authorize
™™	 
(
™™ 
Policy
™™ 
=
™™ 
$str
™™ 9
)
™™9 :
]
™™: ;
public
´´ 
async
´´ 
Task
´´ 
<
´´ 
ActionResult
´´ &
>
´´& '
DeleteNationality
´´( 9
(
´´9 :
int
´´: =
nationalityId
´´> K
)
´´K L
{
¨¨ 	
return
≠≠ 
Ok
≠≠ 
(
≠≠ 
await
≠≠ !
_nationalityService
≠≠ /
.
≠≠/ 0$
DeleteNationalityAsync
≠≠0 F
(
≠≠F G
nationalityId
≠≠G T
)
≠≠T U
)
≠≠U V
;
≠≠V W
}
ÆÆ 	
[
¥¥ 	
HttpGet
¥¥	 
]
¥¥ 
[
µµ 	
Route
µµ	 
(
µµ 
$str
µµ !
)
µµ! "
]
µµ" #
public
∂∂ 
async
∂∂ 
Task
∂∂ 
<
∂∂ 
ActionResult
∂∂ &
<
∂∂& '
IEnumerable
∂∂' 2
<
∂∂2 3!
ResidentTypeReadDto
∂∂3 F
>
∂∂F G
>
∂∂G H
>
∂∂H I
GetResidentTypes
∂∂J Z
(
∂∂Z [
)
∂∂[ \
{
∑∑ 	
return
∏∏ 
Ok
∏∏ 
(
∏∏ 
await
∏∏ "
_residentTypeService
∏∏ 0
.
∏∏0 1"
GetResidentTypeAsync
∏∏1 E
(
∏∏E F
)
∏∏F G
)
∏∏G H
;
∏∏H I
}
ππ 	
[
   	
HttpPost
  	 
]
   
[
ÀÀ 	
Route
ÀÀ	 
(
ÀÀ 
$str
ÀÀ #
)
ÀÀ# $
]
ÀÀ$ %
[
ÃÃ 	
	Authorize
ÃÃ	 
(
ÃÃ 
Policy
ÃÃ 
=
ÃÃ 
$str
ÃÃ 9
)
ÃÃ9 :
]
ÃÃ: ;
public
ÕÕ 
async
ÕÕ 
Task
ÕÕ 
<
ÕÕ 
ActionResult
ÕÕ &
<
ÕÕ& '!
ResidentTypeReadDto
ÕÕ' :
>
ÕÕ: ;
>
ÕÕ; < 
CreateResidentType
ÕÕ= O
(
ÕÕO P
[
ÕÕP Q
FromBody
ÕÕQ Y
]
ÕÕY Z#
ResidentTypeCreateDto
ÕÕ[ p
values
ÕÕq w
)
ÕÕw x
{
ŒŒ 	
try
œœ 
{
–– 
var
—— 
userId
—— 
=
—— !
_userContextService
—— 0
.
——0 1
	GetUserId
——1 :
(
——: ;
)
——; <
;
——< =
if
““ 
(
““ 
!
““ 
string
““ 
.
““ 
Equals
““ "
(
““" #
userId
““# )
,
““) *
values
““+ 1
.
““1 2
	createdBy
““2 ;
)
““; <
)
““< =
{
”” 
return
‘‘ 
Unauthorized
‘‘ '
(
‘‘' (
)
‘‘( )
;
‘‘) *
}
’’ 
return
÷÷ 
Ok
÷÷ 
(
÷÷ 
await
÷÷ "
_residentTypeService
÷÷  4
.
÷÷4 5"
AddResidentTypeAsync
÷÷5 I
(
÷÷I J
values
÷÷J P
)
÷÷P Q
)
÷÷Q R
;
÷÷R S
}
◊◊ 
catch
ÿÿ 
(
ÿÿ 
	Exception
ÿÿ 
ex
ÿÿ 
)
ÿÿ  
{
ŸŸ 
return
⁄⁄ 

StatusCode
⁄⁄ !
(
⁄⁄! "
$num
⁄⁄" %
,
⁄⁄% &
ex
⁄⁄' )
.
⁄⁄) *
InnerException
⁄⁄* 8
!
⁄⁄8 9
.
⁄⁄9 :
Message
⁄⁄: A
)
⁄⁄A B
;
⁄⁄B C
}
€€ 
}
‹‹ 	
[
ÌÌ 	
HttpPut
ÌÌ	 
]
ÌÌ 
[
ÓÓ 	
Route
ÓÓ	 
(
ÓÓ 
$str
ÓÓ #
)
ÓÓ# $
]
ÓÓ$ %
[
ÔÔ 	
	Authorize
ÔÔ	 
(
ÔÔ 
Policy
ÔÔ 
=
ÔÔ 
$str
ÔÔ 9
)
ÔÔ9 :
]
ÔÔ: ;
public
 
async
 
Task
 
<
 
ActionResult
 &
<
& '!
ResidentTypeReadDto
' :
>
: ;
>
; < 
UpdateResidentType
= O
(
O P
[
P Q
FromBody
Q Y
]
Y Z#
ResidentTypeUpdateDto
[ p
values
q w
)
w x
{
ÒÒ 	
var
ÚÚ 
userId
ÚÚ 
=
ÚÚ !
_userContextService
ÚÚ ,
.
ÚÚ, -
	GetUserId
ÚÚ- 6
(
ÚÚ6 7
)
ÚÚ7 8
;
ÚÚ8 9
if
ÛÛ 
(
ÛÛ 
!
ÛÛ 
string
ÛÛ 
.
ÛÛ 
Equals
ÛÛ 
(
ÛÛ 
userId
ÛÛ %
,
ÛÛ% &
values
ÛÛ' -
.
ÛÛ- .

modifiedBy
ÛÛ. 8
)
ÛÛ8 9
)
ÛÛ9 :
{
ÙÙ 
return
ıı 
Unauthorized
ıı #
(
ıı# $
)
ıı$ %
;
ıı% &
}
ˆˆ 
return
˜˜ 
Ok
˜˜ 
(
˜˜ 
await
˜˜ "
_residentTypeService
˜˜ 0
.
˜˜0 1%
UpdateResidentTypeAsync
˜˜1 H
(
˜˜H I
values
˜˜I O
)
˜˜O P
)
˜˜P Q
;
˜˜Q R
}
¯¯ 	
[
˝˝ 	

HttpDelete
˝˝	 
(
˝˝ 
$str
˝˝ 9
)
˝˝9 :
]
˝˝: ;
[
˛˛ 	
	Authorize
˛˛	 
(
˛˛ 
Policy
˛˛ 
=
˛˛ 
$str
˛˛ 9
)
˛˛9 :
]
˛˛: ;
public
ˇˇ 
async
ˇˇ 
Task
ˇˇ 
<
ˇˇ 
ActionResult
ˇˇ &
>
ˇˇ& ' 
DeleteResidentType
ˇˇ( :
(
ˇˇ: ;
int
ˇˇ; >
residentTypeId
ˇˇ? M
)
ˇˇM N
{
ÄÄ 	
return
ÅÅ 
Ok
ÅÅ 
(
ÅÅ 
await
ÅÅ "
_residentTypeService
ÅÅ 0
.
ÅÅ0 1%
DeleteResidentTypeAsync
ÅÅ1 H
(
ÅÅH I
residentTypeId
ÅÅI W
)
ÅÅW X
)
ÅÅX Y
;
ÅÅY Z
}
ÇÇ 	
[
àà 	
HttpGet
àà	 
]
àà 
[
ââ 	
Route
ââ	 
(
ââ 
$str
ââ 
)
ââ  
]
ââ  !
public
ää 
async
ää 
Task
ää 
<
ää 
ActionResult
ää &
<
ää& '
IEnumerable
ää' 2
<
ää2 3 
SocialMediaReadDto
ää3 E
>
ääE F
>
ääF G
>
ääG H
GetSocialMedia
ääI W
(
ääW X
)
ääX Y
{
ãã 	
return
åå 
Ok
åå 
(
åå 
await
åå !
_socialMediaService
åå /
.
åå/ 0!
GetSocialMediaAsync
åå0 C
(
ååC D
)
ååD E
)
ååE F
;
ååF G
}
çç 	
[
íí 	
HttpPost
íí	 
]
íí 
[
ìì 	
Route
ìì	 
(
ìì 
$str
ìì 
)
ìì  
]
ìì  !
[
îî 	
	Authorize
îî	 
(
îî 
Policy
îî 
=
îî 
$str
îî 9
)
îî9 :
]
îî: ;
public
ïï 
async
ïï 
Task
ïï 
<
ïï 
ActionResult
ïï &
<
ïï& ' 
SocialMediaReadDto
ïï' 9
>
ïï9 :
>
ïï: ;
AddSocialMedia
ïï< J
(
ïïJ K
[
ïïK L
FromBody
ïïL T
]
ïïT U"
SocialMediaCreateDto
ïïV j
values
ïïk q
)
ïïq r
{
ññ 	
try
óó 
{
òò 
var
öö 
userId
öö 
=
öö !
_userContextService
öö 0
.
öö0 1
	GetUserId
öö1 :
(
öö: ;
)
öö; <
;
öö< =
if
õõ 
(
õõ 
!
õõ 
string
õõ 
.
õõ 
Equals
õõ "
(
õõ" #
userId
õõ# )
,
õõ) *
values
õõ+ 1
.
õõ1 2
	CreatedBy
õõ2 ;
)
õõ; <
)
õõ< =
{
úú 
return
ùù 
Unauthorized
ùù '
(
ùù' (
)
ùù( )
;
ùù) *
}
ûû 
return
†† 
Ok
†† 
(
†† 
await
†† !
_socialMediaService
††  3
.
††3 4!
AddSocialMediaAsync
††4 G
(
††G H
values
††H N
)
††N O
)
††O P
;
††P Q
}
°° 
catch
¢¢ 
(
¢¢ 
	Exception
¢¢ 
ex
¢¢ 
)
¢¢  
{
££ 
return
§§ 

StatusCode
§§ !
(
§§! "
$num
§§" %
,
§§% &
ex
§§' )
.
§§) *
InnerException
§§* 8
!
§§8 9
.
§§9 :
Message
§§: A
)
§§A B
;
§§B C
}
•• 
}
¶¶ 	
[
´´ 	
HttpPut
´´	 
]
´´ 
[
¨¨ 	
Route
¨¨	 
(
¨¨ 
$str
¨¨ "
)
¨¨" #
]
¨¨# $
[
≠≠ 	
	Authorize
≠≠	 
(
≠≠ 
Policy
≠≠ 
=
≠≠ 
$str
≠≠ 9
)
≠≠9 :
]
≠≠: ;
public
ÆÆ 
async
ÆÆ 
Task
ÆÆ 
<
ÆÆ 
ActionResult
ÆÆ &
<
ÆÆ& ' 
SocialMediaReadDto
ÆÆ' 9
>
ÆÆ9 :
>
ÆÆ: ;
UpdateSocialMedia
ÆÆ< M
(
ÆÆM N
[
ÆÆN O
FromBody
ÆÆO W
]
ÆÆW X"
SocialMediaUpdateDto
ÆÆY m
values
ÆÆn t
)
ÆÆt u
{
ØØ 	
var
∞∞ 
userId
∞∞ 
=
∞∞ !
_userContextService
∞∞ ,
.
∞∞, -
	GetUserId
∞∞- 6
(
∞∞6 7
)
∞∞7 8
;
∞∞8 9
if
±± 
(
±± 
!
±± 
string
±± 
.
±± 
Equals
±± 
(
±± 
userId
±± %
,
±±% &
values
±±' -
.
±±- .

ModifiedBy
±±. 8
)
±±8 9
)
±±9 :
{
≤≤ 
return
≥≥ 
Unauthorized
≥≥ #
(
≥≥# $
)
≥≥$ %
;
≥≥% &
}
¥¥ 
return
µµ 
Ok
µµ 
(
µµ 
await
µµ !
_socialMediaService
µµ /
.
µµ/ 0$
UpdateSocialMediaAsync
µµ0 F
(
µµF G
values
µµG M
)
µµM N
)
µµN O
;
µµO P
}
∂∂ 	
[
ªª 	

HttpDelete
ªª	 
(
ªª 
$str
ªª 7
)
ªª7 8
]
ªª8 9
[
ºº 	
	Authorize
ºº	 
(
ºº 
Policy
ºº 
=
ºº 
$str
ºº 9
)
ºº9 :
]
ºº: ;
public
ΩΩ 
async
ΩΩ 
Task
ΩΩ 
<
ΩΩ 
ActionResult
ΩΩ &
>
ΩΩ& '
DeleteSocialMedia
ΩΩ( 9
(
ΩΩ9 :
int
ΩΩ: =
socialMediaId
ΩΩ> K
)
ΩΩK L
{
ææ 	
return
øø 
Ok
øø 
(
øø 
await
øø !
_socialMediaService
øø /
.
øø/ 0$
DeleteSocialMediaAsync
øø0 F
(
øøF G
socialMediaId
øøG T
)
øøT U
)
øøU V
;
øøV W
}
¿¿ 	
[
∆∆ 	
HttpGet
∆∆	 
]
∆∆ 
[
«« 	
Route
««	 
(
«« 
$str
«« 
)
«« 
]
«« 
public
»» 
async
»» 
Task
»» 
<
»» 
ActionResult
»» &
<
»»& '
IEnumerable
»»' 2
<
»»2 3
TitleReadDto
»»3 ?
>
»»? @
>
»»@ A
>
»»A B
	GetTitles
»»C L
(
»»L M
)
»»M N
{
…… 	
return
   
Ok
   
(
   
await
   
_titleService
   )
.
  ) *
GetTitleAsync
  * 7
(
  7 8
)
  8 9
)
  9 :
;
  : ;
}
ÀÀ 	
[
–– 	
HttpGet
––	 
]
–– 
[
—— 	
Route
——	 
(
—— 
$str
—— !
)
——! "
]
——" #
private
““ 
async
““ 
Task
““ 
<
““ 
ActionResult
““ '
<
““' (
TitleReadDto
““( 4
>
““4 5
>
““5 6
GetTitle
““7 ?
(
““? @
string
““@ F
value
““G L
)
““L M
{
”” 	
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ 
_titleService
‘‘ )
.
‘‘) *
GetTitleAsync
‘‘* 7
(
‘‘7 8
value
‘‘8 =
)
‘‘= >
)
‘‘> ?
;
‘‘? @
}
’’ 	
[
⁄⁄ 	
HttpGet
⁄⁄	 
]
⁄⁄ 
[
€€ 	
Route
€€	 
(
€€ 
$str
€€ $
)
€€$ %
]
€€% &
public
‹‹ 
async
‹‹ 
Task
‹‹ 
<
‹‹ 
ActionResult
‹‹ &
<
‹‹& '
TitleReadDto
‹‹' 3
>
‹‹3 4
>
‹‹4 5
GetTitleById
‹‹6 B
(
‹‹B C
int
‹‹C F
titleId
‹‹G N
)
‹‹N O
{
›› 	
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
await
ﬁﬁ 
_titleService
ﬁﬁ )
.
ﬁﬁ) *
GetTitleAsync
ﬁﬁ* 7
(
ﬁﬁ7 8
titleId
ﬁﬁ8 ?
)
ﬁﬁ? @
)
ﬁﬁ@ A
;
ﬁﬁA B
}
ﬂﬂ 	
[
 	
HttpPost
	 
]
 
[
ÒÒ 	
Route
ÒÒ	 
(
ÒÒ 
$str
ÒÒ 
)
ÒÒ 
]
ÒÒ 
[
ÚÚ 	
	Authorize
ÚÚ	 
(
ÚÚ 
Policy
ÚÚ 
=
ÚÚ 
$str
ÚÚ 9
)
ÚÚ9 :
]
ÚÚ: ;
public
ÛÛ 
async
ÛÛ 
Task
ÛÛ 
<
ÛÛ 
ActionResult
ÛÛ &
<
ÛÛ& '
TitleReadDto
ÛÛ' 3
>
ÛÛ3 4
>
ÛÛ4 5
CreateTitle
ÛÛ6 A
(
ÛÛA B
[
ÛÛB C
FromBody
ÛÛC K
]
ÛÛK L
TitleCreateDto
ÛÛM [
values
ÛÛ\ b
)
ÛÛb c
{
ÙÙ 	
try
ıı 
{
ˆˆ 
var
˜˜ 
userId
˜˜ 
=
˜˜ !
_userContextService
˜˜ 0
.
˜˜0 1
	GetUserId
˜˜1 :
(
˜˜: ;
)
˜˜; <
;
˜˜< =
if
¯¯ 
(
¯¯ 
!
¯¯ 
string
¯¯ 
.
¯¯ 
Equals
¯¯ "
(
¯¯" #
userId
¯¯# )
,
¯¯) *
values
¯¯+ 1
.
¯¯1 2
	createdby
¯¯2 ;
)
¯¯; <
)
¯¯< =
{
˘˘ 
return
˙˙ 
Unauthorized
˙˙ '
(
˙˙' (
)
˙˙( )
;
˙˙) *
}
˚˚ 
return
˝˝ 
Ok
˝˝ 
(
˝˝ 
await
˝˝ 
_titleService
˝˝  -
.
˝˝- .
AddTitleAsync
˝˝. ;
(
˝˝; <
values
˝˝< B
)
˝˝B C
)
˝˝C D
;
˝˝D E
}
˛˛ 
catch
ˇˇ 
(
ˇˇ 
	Exception
ˇˇ 
ex
ˇˇ 
)
ˇˇ  
{
ÄÄ 
return
ÅÅ 

StatusCode
ÅÅ !
(
ÅÅ! "
$num
ÅÅ" %
,
ÅÅ% &
ex
ÅÅ' )
.
ÅÅ) *
InnerException
ÅÅ* 8
!
ÅÅ8 9
.
ÅÅ9 :
Message
ÅÅ: A
)
ÅÅA B
;
ÅÅB C
}
ÇÇ 
}
ÉÉ 	
[
îî 	
HttpPut
îî	 
]
îî 
[
ïï 	
Route
ïï	 
(
ïï 
$str
ïï 
)
ïï 
]
ïï 
[
ññ 	
	Authorize
ññ	 
(
ññ 
Policy
ññ 
=
ññ 
$str
ññ 9
)
ññ9 :
]
ññ: ;
public
óó 
async
óó 
Task
óó 
<
óó 
ActionResult
óó &
<
óó& '
TitleReadDto
óó' 3
>
óó3 4
>
óó4 5
UpdateTitle
óó6 A
(
óóA B
[
óóB C
FromBody
óóC K
]
óóK L
TitleUpdateDto
óóM [
values
óó\ b
)
óób c
{
òò 	
var
ôô 
userId
ôô 
=
ôô !
_userContextService
ôô ,
.
ôô, -
	GetUserId
ôô- 6
(
ôô6 7
)
ôô7 8
;
ôô8 9
if
öö 
(
öö 
!
öö 
string
öö 
.
öö 
Equals
öö 
(
öö 
userId
öö %
,
öö% &
values
öö' -
.
öö- .

modifiedby
öö. 8
)
öö8 9
)
öö9 :
{
õõ 
return
úú 
Unauthorized
úú #
(
úú# $
)
úú$ %
;
úú% &
}
ùù 
return
ûû 
Ok
ûû 
(
ûû 
await
ûû 
_titleService
ûû )
.
ûû) *
UpdateTitleAsync
ûû* :
(
ûû: ;
values
ûû; A
)
ûûA B
)
ûûB C
;
ûûC D
}
üü 	
[
§§ 	

HttpDelete
§§	 
(
§§ 
$str
§§ +
)
§§+ ,
]
§§, -
[
•• 	
	Authorize
••	 
(
•• 
Policy
•• 
=
•• 
$str
•• 9
)
••9 :
]
••: ;
public
¶¶ 
async
¶¶ 
Task
¶¶ 
<
¶¶ 
ActionResult
¶¶ &
>
¶¶& '
DeleteTitle
¶¶( 3
(
¶¶3 4
int
¶¶4 7
titleId
¶¶8 ?
)
¶¶? @
{
ßß 	
return
®® 
Ok
®® 
(
®® 
await
®® 
_titleService
®® )
.
®®) *
DeleteTitleAsync
®®* :
(
®®: ;
titleId
®®; B
)
®®B C
)
®®C D
;
®®D E
}
©© 	
[
∞∞ 	
HttpGet
∞∞	 
]
∞∞ 
[
±± 	
Route
±±	 
(
±± 
$str
±± "
)
±±" #
]
±±# $
public
≤≤ 
async
≤≤ 
Task
≤≤ 
<
≤≤ 
ActionResult
≤≤ &
<
≤≤& '
IEnumerable
≤≤' 2
<
≤≤2 3"
OwnershipTypeReadDto
≤≤3 G
>
≤≤G H
>
≤≤H I
>
≤≤I J
GetOwnershipTypes
≤≤K \
(
≤≤\ ]
)
≤≤] ^
{
≥≥ 	
return
¥¥ 
Ok
¥¥ 
(
¥¥ 
await
¥¥ #
_ownershipTypeService
¥¥ 1
.
¥¥1 2#
GetOwnershipTypeAsync
¥¥2 G
(
¥¥G H
)
¥¥H I
)
¥¥I J
;
¥¥J K
}
µµ 	
[
∫∫ 	
HttpGet
∫∫	 
]
∫∫ 
[
ªª 	
Route
ªª	 
(
ªª 
$str
ªª *
)
ªª* +
]
ªª+ ,
private
ºº 
async
ºº 
Task
ºº 
<
ºº 
ActionResult
ºº '
<
ºº' ("
OwnershipTypeReadDto
ºº( <
>
ºº< =
>
ºº= >
GetOwnershipTypes
ºº? P
(
ººP Q
string
ººQ W
value
ººX ]
)
ºº] ^
{
ΩΩ 	
return
ææ 
Ok
ææ 
(
ææ 
await
ææ #
_ownershipTypeService
ææ 1
.
ææ1 2#
GetOwnershipTypeAsync
ææ2 G
(
ææG H
value
ææH M
)
ææM N
)
ææN O
;
ææO P
}
øø 	
[
ƒƒ 	
HttpGet
ƒƒ	 
]
ƒƒ 
[
≈≈ 	
Route
≈≈	 
(
≈≈ 
$str
≈≈ 3
)
≈≈3 4
]
≈≈4 5
public
∆∆ 
async
∆∆ 
Task
∆∆ 
<
∆∆ 
ActionResult
∆∆ &
<
∆∆& '"
OwnershipTypeReadDto
∆∆' ;
>
∆∆; <
>
∆∆< =
GetOwnershipType
∆∆> N
(
∆∆N O
int
∆∆O R
ownershipTypeId
∆∆S b
)
∆∆b c
{
«« 	
return
»» 
Ok
»» 
(
»» 
await
»» #
_ownershipTypeService
»» 1
.
»»1 2#
GetOwnershipTypeAsync
»»2 G
(
»»G H
ownershipTypeId
»»H W
)
»»W X
)
»»X Y
;
»»Y Z
}
…… 	
[
⁄⁄ 	
HttpPost
⁄⁄	 
]
⁄⁄ 
[
€€ 	
Route
€€	 
(
€€ 
$str
€€ $
)
€€$ %
]
€€% &
[
‹‹ 	
	Authorize
‹‹	 
(
‹‹ 
Policy
‹‹ 
=
‹‹ 
$str
‹‹ 9
)
‹‹9 :
]
‹‹: ;
public
›› 
async
›› 
Task
›› 
<
›› 
ActionResult
›› &
<
››& '
TitleReadDto
››' 3
>
››3 4
>
››4 5!
CreateOwnershipType
››6 I
(
››I J
[
››J K
FromBody
››K S
]
››S T$
OwnershipTypeCreateDto
››U k
values
››l r
)
››r s
{
ﬁﬁ 	
try
ﬂﬂ 
{
‡‡ 
var
·· 
userId
·· 
=
·· !
_userContextService
·· 0
.
··0 1
	GetUserId
··1 :
(
··: ;
)
··; <
;
··< =
if
‚‚ 
(
‚‚ 
!
‚‚ 
string
‚‚ 
.
‚‚ 
Equals
‚‚ "
(
‚‚" #
userId
‚‚# )
,
‚‚) *
values
‚‚+ 1
.
‚‚1 2
	createdby
‚‚2 ;
)
‚‚; <
)
‚‚< =
{
„„ 
return
‰‰ 
Unauthorized
‰‰ '
(
‰‰' (
)
‰‰( )
;
‰‰) *
}
ÂÂ 
return
ÁÁ 
Ok
ÁÁ 
(
ÁÁ 
await
ÁÁ #
_ownershipTypeService
ÁÁ  5
.
ÁÁ5 6#
AddOwnershipTypeAsync
ÁÁ6 K
(
ÁÁK L
values
ÁÁL R
)
ÁÁR S
)
ÁÁS T
;
ÁÁT U
}
ËË 
catch
ÈÈ 
(
ÈÈ 
	Exception
ÈÈ 
ex
ÈÈ 
)
ÈÈ  
{
ÍÍ 
return
ÎÎ 

StatusCode
ÎÎ !
(
ÎÎ! "
$num
ÎÎ" %
,
ÎÎ% &
ex
ÎÎ' )
.
ÎÎ) *
InnerException
ÎÎ* 8
!
ÎÎ8 9
.
ÎÎ9 :
Message
ÎÎ: A
)
ÎÎA B
;
ÎÎB C
}
ÏÏ 
}
ÌÌ 	
[
˛˛ 	
HttpPut
˛˛	 
]
˛˛ 
[
ˇˇ 	
Route
ˇˇ	 
(
ˇˇ 
$str
ˇˇ $
)
ˇˇ$ %
]
ˇˇ% &
[
ÄÄ 	
	Authorize
ÄÄ	 
(
ÄÄ 
Policy
ÄÄ 
=
ÄÄ 
$str
ÄÄ 9
)
ÄÄ9 :
]
ÄÄ: ;
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
ActionResult
ÅÅ &
<
ÅÅ& '"
OwnershipTypeReadDto
ÅÅ' ;
>
ÅÅ; <
>
ÅÅ< =!
UpdateOwnershipType
ÅÅ> Q
(
ÅÅQ R
[
ÅÅR S
FromBody
ÅÅS [
]
ÅÅ[ \$
OwnershipTypeUpdateDto
ÅÅ] s
values
ÅÅt z
)
ÅÅz {
{
ÇÇ 	
var
ÉÉ 
userId
ÉÉ 
=
ÉÉ !
_userContextService
ÉÉ ,
.
ÉÉ, -
	GetUserId
ÉÉ- 6
(
ÉÉ6 7
)
ÉÉ7 8
;
ÉÉ8 9
if
ÑÑ 
(
ÑÑ 
!
ÑÑ 
string
ÑÑ 
.
ÑÑ 
Equals
ÑÑ 
(
ÑÑ 
userId
ÑÑ %
,
ÑÑ% &
values
ÑÑ' -
.
ÑÑ- .

modifiedby
ÑÑ. 8
)
ÑÑ8 9
)
ÑÑ9 :
{
ÖÖ 
return
ÜÜ 
Unauthorized
ÜÜ #
(
ÜÜ# $
)
ÜÜ$ %
;
ÜÜ% &
}
áá 
return
àà 
Ok
àà 
(
àà 
await
àà #
_ownershipTypeService
àà 1
.
àà1 2&
UpdateOwnershipTypeAsync
àà2 J
(
ààJ K
values
ààK Q
)
ààQ R
)
ààR S
;
ààS T
}
ââ 	
[
éé 	

HttpDelete
éé	 
(
éé 
$str
éé ;
)
éé; <
]
éé< =
[
èè 	
	Authorize
èè	 
(
èè 
Policy
èè 
=
èè 
$str
èè 9
)
èè9 :
]
èè: ;
public
êê 
async
êê 
Task
êê 
<
êê 
ActionResult
êê &
>
êê& '!
DeleteOwnershipType
êê( ;
(
êê; <
int
êê< ?
ownershipTypeId
êê@ O
)
êêO P
{
ëë 	
return
íí 
Ok
íí 
(
íí 
await
íí #
_ownershipTypeService
íí 1
.
íí1 2&
DeleteOwnershipTypeAsync
íí2 J
(
ííJ K
ownershipTypeId
ííK Z
)
ííZ [
)
íí[ \
;
íí\ ]
}
ìì 	
[
ôô 	
HttpGet
ôô	 
]
ôô 
[
öö 	
Route
öö	 
(
öö 
$str
öö 
)
öö 
]
öö  
[
õõ 	"
ProducesResponseType
õõ	 
(
õõ 
typeof
õõ $
(
õõ$ %
int
õõ% (
)
õõ( )
,
õõ) *
StatusCodes
õõ+ 6
.
õõ6 7
Status200OK
õõ7 B
)
õõB C
]
õõC D
public
úú 
IActionResult
úú 
MaritalStatus
úú *
(
úú* +
)
úú+ ,
{
ùù 	
var
ûû 
statuses
ûû 
=
ûû 
Enum
ûû 
.
ûû  
	GetValues
ûû  )
(
ûû) *
typeof
ûû* 0
(
ûû0 1
MaritalStatusEnum
ûû1 B
)
ûûB C
)
ûûC D
.
üü# $
Cast
üü$ (
<
üü( )
MaritalStatusEnum
üü) :
>
üü: ;
(
üü; <
)
üü< =
.
††# $
Select
††$ *
(
††* +
e
††+ ,
=>
††- /
new
††0 3
{
°°# $
Id
¢¢' )
=
¢¢* +
(
¢¢, -
int
¢¢- 0
)
¢¢0 1
e
¢¢1 2
,
¢¢2 3
Name
££' +
=
££, -
e
££. /
.
££/ 0
ToString
££0 8
(
££8 9
)
££9 :
,
££: ;
DisplayName
§§' 2
=
§§3 4
e
§§5 6
.
§§6 7
GetType
§§7 >
(
§§> ?
)
§§? @
.
••5 6
GetField
••6 >
(
••> ?
e
••? @
.
••@ A
ToString
••A I
(
••I J
)
••J K
)
••K L
!
••L M
.
¶¶6 7 
GetCustomAttribute
¶¶7 I
<
¶¶I J"
DescriptionAttribute
¶¶J ^
>
¶¶^ _
(
¶¶_ `
)
¶¶` a
?
¶¶a b
.
ßß6 7
Description
ßß7 B
}
©©# $
)
©©$ %
;
©©% &
return
™™ 
Ok
™™ 
(
™™ 
statuses
™™ 
)
™™ 
;
™™  
}
´´ 	
[
±± 	
HttpGet
±±	 
]
±± 
[
≤≤ 	
Route
≤≤	 
(
≤≤ 
$str
≤≤  
)
≤≤  !
]
≤≤! "
public
≥≥ 
async
≥≥ 
Task
≥≥ 
<
≥≥ 
ActionResult
≥≥ &
<
≥≥& '
IEnumerable
≥≥' 2
<
≥≥2 3
CustomerListDto
≥≥3 B
>
≥≥B C
>
≥≥C D
>
≥≥D E
GetCustomerList
≥≥F U
(
≥≥U V
)
≥≥V W
{
¥¥ 	
return
µµ 
Ok
µµ 
(
µµ 
await
µµ $
_customerMasterService
µµ 2
.
µµ2 3"
GetCustomerListAsync
µµ3 G
(
µµG H
)
µµH I
)
µµI J
;
µµJ K
}
∂∂ 	
}
∫∫ 
}ªª ∑
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Constants/CustomerConstants.cs
	namespace 	
Modules
 
. 
Estates 
. 
Presentation &
.& '
	Constants' 0
{ 
public 

static 
class 
CustomerConstants )
{ 
public 
const 
string 
ErrorUnauthorized -
=. /
$str0 >
;> ?
public 
const 
string 
ErrorExpatriateNull /
=0 1
$str2 _
;_ `
public 
const 
string #
ErrorResidentPermitNull 3
=4 5
$str6 g
;g h
public 
const 
string  
ErrorNonResidentNull 0
=1 2
$str3 q
;q r
public   
const   
string   $
ErrorContactFullNameNull   4
=  5 6
$str  7 k
;  k l
public%% 
const%% 
string%% !
ErrorContactEmailNull%% 1
=%%2 3
$str%%4 m
;%%m n
public** 
const** 
string** !
ErrorContactPhoneNull** 1
=**2 3
$str**4 l
;**l m
public// 
const// 
string// 
ErrorCoLesseEmpty// -
=//. /
$str//0 R
;//R S
public44 
const44 
string44 
ErrorDependentEmpty44 /
=440 1
$str442 U
;44U V
public99 
const99 
int99 )
StatusCodeInternalServerError99 6
=997 8
$num999 <
;99< =
}:: 
};; 