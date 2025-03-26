j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Usings.cs�l
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
GetConnectionString	88v �
(
88� �
$str
88� �
)
88� �
)
88� �
)
88� �
;
88� �
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
GetConnectionString	FFv �
(
FF� �
$str
FF� �
)
FF� �
)
FF� �
)
FF� �
;
FF� �
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
�� 
builder�� 
.
�� 
Services
�� 
.
�� !
AddExceptionHandler
�� $
<
��$ %'
HttpGlobalExceptionFilter
��% >
>
��> ?
(
��? @
)
��@ A
;
��A B
builder�� 
.
�� 
Services
�� 
.
�� 
AddProblemDetails
�� "
(
��" #
)
��# $
;
��$ %
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
UseAuthentication
�� 
(
�� 
)
�� 
;
�� 
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
�� 
UseCors
�� 
(
�� 
)
�� 
;
�� 
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
}88 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/OpenAPI/SwaggerConfigureOptions.cs
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
}22 �I
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
}JJ �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Filters/HttpGlobalExceptionFilter.cs
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
}"" ڒ
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/PropertyController.cs
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
--� �
,
--� �
ILocalityService
--� �
localityService
--� �
,
--� �
IPlotSizeService
--� �
plotSizeService
--� �
,
--� �!
IApartmentTypeService.. 3 
apartmentTypeService..4 H
,..H I
IFacilitiesService..J \
facilitiesService..] n
,..n o#
IFloorNumberingService	..p �#
floorNumberingService
..� �
,
..� �"
IPropertyTypeService
..� �!
propertyTypeService
..� �
,
..� �$
IPropertyHeightService
..� �#
propertyHeightService
..� �
,
..� �
IBlockNumberService// 1
blockNumberService//2 D
,//D E
IBlockSideService//F W
blockSideService//X h
,//h i
IBlockTypeService//j {
blockTypeService	//| �
,
//� �
IBlockUnitService
//� �
blockUnitService
//� �
,
//� �
IActivityService00 .
activityService00/ >
,00> ? 
IActivityTypeService00@ T
activityTypeService00U h
,00h i#
IPropertyMasterService	00j �#
propertyMasterService
00� �
)
00� �
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
�� 
Ok
�� 
(
�� 
await
�� 
_activityService
�� (
.
��( )!
UpdateActivityAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteActivity
�� 
(
�� 
int
�� "

activityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� #
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
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /!
ActivityTypeReadDto
��/ B
>
��B C
>
��C D
>
��D E
GetActivityTypes
��F V
(
��V W
)
��W X
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_activityTypeService
�� ,
.
��, -"
GetActivityTypeAsync
��- A
(
��A B
)
��B C
)
��C D
;
��D E
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
ActivityTypeReadDto
��# 6
>
��6 7
>
��7 8 
CreateActivityType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
ActivityTypeCreateDto
��W l
values
��m s
)
��s t
{
�� 
try
�� 
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
_activityTypeService
�� 0
.
��0 1%
CreateActivityTypeAsync
��1 H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
ActivityTypeReadDto
��# 6
>
��6 7
>
��7 8 
UpdateActivityType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
ActivityTypeUpdateDto
��W l
values
��m s
)
��s t
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_activityTypeService
�� ,
.
��, -%
UpdateActivityTypeAsync
��- D
(
��D E
values
��E K
)
��K L
)
��L M
;
��M N
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

void
��  
DeleteActivityType
�� "
(
��" #
int
��# &
activityTypeId
��' 5
)
��5 6
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
AllocationTypeReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetAllocationType
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :
GetAllocationType
��; L
(
��L M
string
��M S
allocationType
��T b
)
��b c
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
allocationType
��F T
)
��T U
)
��U V
;
��V W
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� ;
)
��; <
]
��< =
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :#
GetAllocationTypeById
��; P
(
��P Q
int
��Q T
allocationTypeId
��U e
)
��e f
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
allocationTypeId
��F V
)
��V W
)
��W X
;
��X Y
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
CreateAllocationType
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
AllocationTypeCreateDto
��[ r
values
��s y
)
��y z
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� 2
.
��2 3$
AddAllocationTypeAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
new
��# &
{
��' (
detail
��) /
=
��0 1
ex
��2 4
.
��4 5
Message
��5 <
}
��= >
)
��> ?
;
��? @
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
UpdateAllocationType
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
AllocationTypeUpdateDto
��[ r
values
��s y
)
��y z
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /'
UpdateAllocationTypeAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

void
�� "
DeleteAllocationType
�� $
(
��$ %
int
��% (
allocationTypeId
��) 9
)
��9 :
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� #
)
��# $
]
��$ %
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /"
ApartmentTypeReadDto
��/ C
>
��C D
>
��D E
>
��E F
GetApartmentType
��G W
(
��W X
)
��X Y
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :
GetApartmentType
��; K
(
��K L
string
��L R
apartmentType
��S `
)
��` a
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
apartmentType
��D Q
)
��Q R
)
��R S
;
��S T
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
GetApartmentTypeById
��; O
(
��O P
int
��P S
apartmentTypeId
��T c
)
��c d
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
apartmentTypeId
��D S
)
��S T
)
��T U
;
��U V
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #"
ApartmentTypeReadDto
��# 7
>
��7 8
>
��8 9
AddApartmentType
��: J
(
��J K
[
��K L
FromBody
��L T
]
��T U$
ApartmentTypeCreateDto
��V l
values
��m s
)
��s t
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� 1
.
��1 2#
AddApartmentTypeAsync
��2 G
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
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #"
ApartmentTypeReadDto
��# 7
>
��7 8
>
��8 9!
UpdateApartmentType
��: M
(
��M N
[
��N O
FromBody
��O W
]
��W X$
ApartmentTypeUpdateDto
��Y o
values
��p v
)
��v w
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .&
UpdateApartmentTypeAsync
��. F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
public
�� 

void
�� !
DeleteApartmentType
�� #
(
��# $
int
��$ '
apartmentTypeId
��( 7
)
��7 8
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. / 
BlockNumberReadDto
��/ A
>
��A B
>
��B C
>
��C D
GetBlockNumber
��E S
(
��S T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� +
.
��+ ,!
GetBlockNumberAsync
��, ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
BlockNumberReadDto
��# 5
>
��5 6
>
��6 7
AddBlockNumber
��8 F
(
��F G
[
��G H
FromBody
��H P
]
��P Q"
BlockNumberCreateDto
��R f
values
��g m
)
��m n
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� /
.
��/ 0!
AddBlockNumberAsync
��0 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
BlockNumberReadDto
��# 5
>
��5 6
>
��6 7
UpdateBlockNumber
��8 I
(
��I J
[
��J K
FromBody
��K S
]
��S T"
BlockNumberUpdateDto
��U i
values
��j p
)
��p q
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� +
.
��+ ,$
UpdateBlockNumberAsync
��, B
(
��B C
values
��C I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 0
)
��0 1
]
��1 2
public
�� 

void
�� 
DeleteBlockNumber
�� !
(
��! "
int
��" %

facilityId
��& 0
)
��0 1
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockSideReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockSides
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� )
.
��) *
GetBlockSideAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockSideReadDto
��# 3
>
��3 4
>
��4 5
AddBlockSide
��6 B
(
��B C
[
��C D
FromBody
��D L
]
��L M 
BlockSideCreateDto
��N `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� -
.
��- .
AddBlockSideAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockSideReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockSide
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockSideUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� )
.
��) *"
UpdateBlockSideAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockSide
�� 
(
��  
int
��  #
blockSideId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockTypeReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockTypes
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� )
.
��) *
GetBlockTypeAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockTypeReadDto
��# 3
>
��3 4
>
��4 5
AddBlockType
��6 B
(
��B C
[
��C D
FromBody
��D L
]
��L M 
BlockTypeCreateDto
��N `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� -
.
��- .
AddBlockTypeAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockTypeReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockType
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockTypeUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� )
.
��) *"
UpdateBlockTypeAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockType
�� 
(
��  
int
��  #
blockTypeId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockUnitReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockUnits
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� )
.
��) *
GetBlockUnitAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockUnitReadDto
��# 3
>
��3 4
>
��4 5
CreateBlockUnit
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockUnitCreateDto
��Q c
values
��d j
)
��j k
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� -
.
��- .
AddBlockUnitAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockUnitReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockUnit
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockUnitUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� )
.
��) *"
UpdateBlockUnitAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockUnit
�� 
(
��  
int
��  #
blockUnitId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
FacilitiesReadDto
��/ @
>
��@ A
>
��A B
>
��B C
GetFacilities
��D Q
(
��Q R
)
��R S
{
�� 
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� *
.
��* + 
GetFacilitiesAsync
��+ =
(
��= >
)
��> ?
)
��? @
;
��@ A
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
FacilitiesReadDto
��# 4
>
��4 5
>
��5 6
CreateFacility
��7 E
(
��E F
[
��F G
FromBody
��G O
]
��O P!
FacilitiesCreateDto
��Q d
values
��e k
)
��k l
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� .
.
��. / 
AddFacilitiesAsync
��/ A
(
��A B
values
��B H
)
��H I
)
��I J
;
��J K
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
FacilitiesReadDto
��# 4
>
��4 5
>
��5 6
UpdateFacility
��7 E
(
��E F
[
��F G
FromBody
��G O
]
��O P!
FacilitiesUpdateDto
��Q d
values
��e k
)
��k l
{
�� 
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� *
.
��* +#
UpdateFacilitiesAsync
��+ @
(
��@ A
values
��A G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteFacility
�� 
(
�� 
int
�� "

facilityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
FloorNumberingReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetFloorNumbering
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� .
.
��. /$
GetFloorNumberingAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
FloorNumberingReadDto
��# 8
>
��8 9
>
��9 :
CreateFloorNumber
��; L
(
��L M
[
��M N
FromBody
��N V
]
��V W%
FloorNumberingCreateDto
��X o
values
��p v
)
��v w
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� 2
.
��2 3$
AddFloorNumberingAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
FloorNumberingReadDto
��# 8
>
��8 9
>
��9 :
UpdateFloorNumber
��; L
(
��L M
[
��M N
FromBody
��N V
]
��V W%
FloorNumberingUpdateDto
��X o
values
��p v
)
��v w
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� .
.
��. /'
UpdateFloorNumberingAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

void
�� 
DeleteFloorNumber
�� !
(
��! "
int
��" %
floorNumberId
��& 3
)
��3 4
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
LandUseReadDto
��/ =
>
��= >
>
��> ?
>
��? @

GetLandUse
��A K
(
��K L
)
��L M
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� '
)
��' (
]
��( )
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3

GetLandUse
��4 >
(
��> ?
string
��? E
landUse
��F M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
landUse
��8 ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� -
)
��- .
]
��. /
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
GetLandUseById
��4 B
(
��B C
int
��C F
	landUseId
��G P
)
��P Q
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
	landUseId
��8 A
)
��A B
)
��B C
;
��C D
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
CreateLandUse
��4 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
LandUseCreateDto
��M ]
values
��^ d
)
��d e
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� +
.
��+ ,
AddLandUseAsync
��, ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
UpdateLandUse
��4 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
LandUseUpdateDto
��M ]
values
��^ d
)
��d e
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' ( 
UpdateLandUseAsync
��( :
(
��: ;
values
��; A
)
��A B
)
��B C
;
��C D
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� +
)
��+ ,
]
��, -
public
�� 

void
�� 
DeleteLandUse
�� 
(
�� 
int
�� !
	landUseId
��" +
)
��+ ,
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. / 
LandUseTypeReadDto
��/ A
>
��A B
>
��B C
>
��C D
GetLandUseType
��E S
(
��S T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� +
)
��+ ,
]
��, -
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
LandUseTypeReadDto
��# 5
>
��5 6
>
��6 7
GetLandUseType
��8 F
(
��F G
string
��G M
landUse
��N U
)
��U V
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
landUse
��@ G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3 
GetLandUseTypeById
��4 F
(
��F G
int
��G J
	landUseId
��K T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
	landUseId
��@ I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
LandUseTypeReadDto
��# 5
>
��5 6
>
��6 7
CreateLandUseType
��8 I
(
��I J
[
��J K
FromBody
��K S
]
��S T"
LandUseTypeCreateDto
��U i
values
��j p
)
��p q
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� /
.
��/ 0!
AddLandUseTypeAsync
��0 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
UpdateLandUseType
��4 E
(
��E F
[
��F G
FromBody
��G O
]
��O P"
LandUseTypeUpdateDto
��Q e
values
��f l
)
��l m
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,$
UpdateLandUseTypeAsync
��, B
(
��B C
values
��C I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

void
�� 
DeleteLandUseType
�� !
(
��! "
int
��" %
	landUseId
��& /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
LocalityReadDto
��/ >
>
��> ?
>
��? @
>
��@ A

GeLocality
��B L
(
��L M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :
)
��: ;
)
��; <
;
��< =
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� &
)
��& '
]
��' (
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
GetLocality
��5 @
(
��@ A
string
��A G
value
��H M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :
value
��: ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
GetLocalityById
��5 D
(
��D E
int
��E H

localityId
��I S
)
��S T
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :

localityId
��: D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
CreateLocality
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
LocalityCreateDto
��O `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� ,
.
��, -!
CreateLocalityAsync
��- @
(
��@ A
values
��A G
)
��G H
)
��H I
;
��I J
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
UpdateLocality
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
LocalityUpdateDto
��O `
values
��a g
)
��g h
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )!
UpdateLocalityAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteLocality
�� 
(
�� 
int
�� "

localityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
PlotSizeReadDto
��/ >
>
��> ?
>
��? @
>
��@ A
GetPlotSize
��B M
(
��M N
)
��N O
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :
)
��: ;
)
��; <
;
��< =
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� &
)
��& '
]
��' (
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
GetPlotSize
��5 @
(
��@ A
string
��A G
value
��H M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :
value
��: ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
GetPlotSizeById
��5 D
(
��D E
int
��E H

plotSizeId
��I S
)
��S T
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :

plotSizeId
��: D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
AddPlotSize
��5 @
(
��@ A
[
��A B
FromBody
��B J
]
��J K
PlotSizeCreateDto
��L ]
values
��^ d
)
��d e
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� ,
.
��, -
AddPlotSizeAsync
��- =
(
��= >
values
��> D
)
��D E
)
��E F
;
��F G
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
UpdatePlotSize
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
PlotSizeUpdateDto
��O `
values
��a g
)
��g h
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )!
UpdatePlotSizeAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeletePlotSize
�� 
(
�� 
int
�� "

localityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
PropertyHeightReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetPropertyHeight
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� .
.
��. /$
GetPropertyHeightAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
PropertyHeightReadDto
��# 8
>
��8 9
>
��9 :"
CreatePropertyHeight
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
PropertyHeightCreateDto
��[ r
values
��s y
)
��y z
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� 2
.
��2 3$
AddPropertyHeightAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
PropertyHeightReadDto
��# 8
>
��8 9
>
��9 :"
UpdatePropertyHeight
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
PropertyHeightUpdateDto
��[ r
values
��s y
)
��y z
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� .
.
��. /'
UpdatePropertyHeightAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

void
�� "
DeletePropertyHeight
�� $
(
��$ %
int
��% (
propertyHeightId
��) 9
)
��9 :
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� "
)
��" #
]
��# $
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /!
PropertyTypeReadDto
��/ B
>
��B C
>
��C D
>
��D E
GetPropertyType
��F U
(
��U V
)
��V W
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
)
��B C
)
��C D
;
��D E
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� *
)
��* +
]
��+ ,
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8
GetPropertyType
��9 H
(
��H I
string
��I O
value
��P U
)
��U V
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
value
��B G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 7
)
��7 8
]
��8 9
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8!
GetPropertyTypeById
��9 L
(
��L M
int
��M P
propertyTypeId
��Q _
)
��_ `
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
propertyTypeId
��B P
)
��P Q
)
��Q R
;
��R S
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8 
CreatePropertyType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
PropertyTypeCreateDto
��W l
values
��m s
)
��s t
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� 0
.
��0 1"
AddPropertyTypeAsync
��1 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8 
UpdatePropertyType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
PropertyTypeUpdateDto
��W l
values
��m s
)
��s t
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -%
UpdatePropertyTypeAsync
��- D
(
��D E
values
��E K
)
��K L
)
��L M
;
��M N
}
�	�	 
[
�	�	 

HttpDelete
�	�	 
(
�	�	 
$str
�	�	 5
)
�	�	5 6
]
�	�	6 7
public
�	�	 

void
�	�	  
DeletePropertyType
�	�	 "
(
�	�	" #
int
�	�	# &
propertyTypeId
�	�	' 5
)
�	�	5 6
{
�	�	 
}
�	�	 
[
�	�	 
HttpPost
�	�	 
]
�	�	 
[
�	�	 
Route
�	�	 

(
�	�	
 
$str
�	�	 
)
�	�	 
]
�	�	 
public
�	�	 

async
�	�	 
Task
�	�	 
<
�	�	 
ActionResult
�	�	 "
<
�	�	" #!
PropertyTypeReadDto
�	�	# 6
>
�	�	6 7
>
�	�	7 8
CreateProperty
�	�	9 G
(
�	�	G H
[
�	�	H I
FromBody
�	�	I Q
]
�	�	Q R)
PropertyMasterCreatePlotDto
�	�	S n
values
�	�	o u
)
�	�	u v
{
�	�	 
try
�	�	 
{
�	�	 	
return
�	�	 
Ok
�	�	 
(
�	�	 
await
�	�	 $
_propertyMasterService
�	�	 2
.
�	�	2 3
CreateProperty
�	�	3 A
(
�	�	A B
values
�	�	B H
)
�	�	H I
)
�	�	I J
;
�	�	J K
}
�	�	 	
catch
�	�	 
(
�	�	 
	Exception
�	�	 
ex
�	�	 
)
�	�	 
{
�	�	 	
return
�	�	 

StatusCode
�	�	 
(
�	�	 
$num
�	�	 !
,
�	�	! "
ex
�	�	# %
.
�	�	% &
InnerException
�	�	& 4
!
�	�	4 5
.
�	�	5 6
Message
�	�	6 =
)
�	�	= >
;
�	�	> ?
}
�	�	 	
}
�	�	 
}�	�	 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/CustomersController.cs
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
}ll ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v2/CustomerController.cs
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
IIdentificationTypeService	j �'
identificationTypeService
� �
,
� �!
INationalityService
� � 
nationalityService
� �
,
� � 
IResidentTypeService" 6
residentTypeService7 J
,J K
ISocialMediaServiceL _
socialMediaService` r
,r s
ITitleService	t �
titleService
� �
,
� �$
ICustomerMasterService
� �#
customerMasterService
� �
)
� �
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
�� 	
}
��
 
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
�� -
)
��- .
]
��. /
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
��2 3'
IdentificationTypeReadDto
��3 L
>
��L M
>
��M N
>
��N O$
GetIdentificationTypes
��P f
(
��f g
)
��g h
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
�� 6
.
��6 7(
GetIdentificationTypeAsync
��7 Q
(
��Q R
)
��R S
)
��S T
;
��T U
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
��& ''
IdentificationTypeReadDto
��' @
>
��@ A
>
��A B#
AddIdentificationType
��C X
(
��X Y
[
��Y Z
FromBody
��Z b
]
��b c)
IdentificationTypeCreateDto
��d 
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
�� (
_identificationTypeService
��  :
.
��: ;(
AddIdentificationTypeAsync
��; U
(
��U V
values
��V \
)
��\ ]
)
��] ^
;
��^ _
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
HttpPut
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
��& ''
IdentificationTypeReadDto
��' @
>
��@ A
>
��A B 
UpdateCustomerType
��C U
(
��U V
[
��V W
FromBody
��W _
]
��_ `)
IdentificationTypeUpdateDto
��a |
values��} �
)��� �
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
�� 6
.
��6 7+
UpdateIdentificationTypeAsync
��7 T
(
��T U
values
��U [
)
��[ \
)
��\ ]
;
��] ^
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� E
)
��E F
]
��F G
public
�� 
void
�� &
DeleteIdentificationType
�� ,
(
��, -
int
��- 0"
identificationTypeId
��1 E
)
��E F
{
�� 	
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
�� %
)
��% &
]
��& '
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
��2 3 
NationalityReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetNationality
��I W
(
��W X
)
��X Y
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_nationalityService
�� /
.
��/ 0!
GetNationalityAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
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
��& ' 
NationalityReadDto
��' 9
>
��9 :
>
��: ;
AddNationality
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
NationalityCreateDto
��V j
values
��k q
)
��q r
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
�� !
_nationalityService
��  3
.
��3 4!
AddNationalityAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
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
HttpPut
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
��& ' 
NationalityReadDto
��' 9
>
��9 :
>
��: ;
UpdateNationality
��< M
(
��M N
[
��N O
FromBody
��O W
]
��W X"
NationalityUpdateDto
��Y m
values
��n t
)
��t u
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_nationalityService
�� /
.
��/ 0$
UpdateNationalityAsync
��0 F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
public
�� 
void
�� 
DeleteNationality
�� %
(
��% &
int
��& )
nationalityId
��* 7
)
��7 8
{
�� 	
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
�� '
)
��' (
]
��( )
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
ResidentTypeReadDto
��3 F
>
��F G
>
��G H
>
��H I
GetResidentTypes
��J Z
(
��Z [
)
��[ \
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
_residentTypeService
�� 0
.
��0 1"
GetResidentTypeAsync
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
ResidentTypeReadDto
��' :
>
��: ;
>
��; <
AddResidentType
��= L
(
��L M
[
��M N
FromBody
��N V
]
��V W#
ResidentTypeCreateDto
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
_residentTypeService
��  4
.
��4 5"
AddResidentTypeAsync
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
HttpPut
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
�� #
)
��# $
]
��$ %
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
ResidentTypeReadDto
��' :
>
��: ;
>
��; < 
UpdateResidentType
��= O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z#
ResidentTypeUpdateDto
��[ p
values
��q w
)
��w x
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
_residentTypeService
�� 0
.
��0 1%
UpdateResidentTypeAsync
��1 H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
void
��  
DeleteResidentType
�� &
(
��& '
int
��' *
residentTypeId
��+ 9
)
��9 :
{
�� 	
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
�� %
)
��% &
]
��& '
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
��2 3 
SocialMediaReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetSocialMedia
��I W
(
��W X
)
��X Y
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_socialMediaService
�� /
.
��/ 0!
GetSocialMediaAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
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
��& ' 
SocialMediaReadDto
��' 9
>
��9 :
>
��: ;
AddSocialMedia
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
SocialMediaCreateDto
��V j
values
��k q
)
��q r
{
�� 	
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
_socialMediaService
��  3
.
��3 4!
AddSocialMediaAsync
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
HttpPut
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
�� "
)
��" #
]
��# $
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
SocialMediaReadDto
��' 9
>
��9 :
>
��: ;
UpdateSocialMedia
��< M
(
��M N
[
��N O
FromBody
��O W
]
��W X"
SocialMediaUpdateDto
��Y m
values
��n t
)
��t u
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
_socialMediaService
�� /
.
��/ 0$
UpdateSocialMediaAsync
��0 F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
public
�� 
void
�� 
DeleteSocialMedia
�� %
(
��% &
int
��& )
socialMediaId
��* 7
)
��7 8
{
�� 	
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
��  
)
��  !
]
��! "
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
��2 3
TitleReadDto
��3 ?
>
��? @
>
��@ A
>
��A B
	GetTitles
��C L
(
��L M
)
��M N
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
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
�� '
)
��' (
]
��( )
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
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
GetTitle
��6 >
(
��> ?
string
��? E
value
��F K
)
��K L
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
value
��8 =
)
��= >
)
��> ?
;
��? @
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
�� .
)
��. /
]
��/ 0
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
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
GetTitleById
��6 B
(
��B C
int
��C F
titleId
��G N
)
��N O
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
titleId
��8 ?
)
��? @
)
��@ A
;
��A B
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
�� 
)
�� 
]
�� 
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
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
AddTitle
��6 >
(
��> ?
[
��? @
FromBody
��@ H
]
��H I
TitleCreateDto
��J X
values
��Y _
)
��_ `
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
�� 
_titleService
��  -
.
��- .
AddTitleAsync
��. ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
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
HttpPut
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
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
UpdateTitle
��6 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
TitleUpdateDto
��M [
values
��\ b
)
��b c
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
UpdateTitleAsync
��* :
(
��: ;
values
��; A
)
��A B
)
��B C
;
��C D
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� +
)
��+ ,
]
��, -
public
�� 
void
�� 
DeleteTitle
�� 
(
��  
int
��  #
titleId
��$ +
)
��+ ,
{
�� 	
}
��
 
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
�� '
)
��' (
]
��( )
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
��& ',
ProspectiveCustomerResponseDto
��' E
>
��E F
>
��F G$
AddProspectiveCustomer
��H ^
(
��^ _
[
��_ `
FromBody
��` h
]
��h i%
ProspectiveCustomerDto��j �
values��� �
)��� �
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
�� $
_customerMasterService
��  6
.
��6 7
CreateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
��& '(
CompanyCustomerResponseDto
��' A
>
��A B
>
��B C 
AddCompanyCustomer
��D V
(
��V W
[
��W X
FromBody
��X `
]
��` a&
CreateCompanyCustomerDto
��b z
values��{ �
)��� �
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
�� $
_customerMasterService
��  6
.
��6 7
CreateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
}�� ڒ
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.cs
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
--� �
,
--� �
ILocalityService
--� �
localityService
--� �
,
--� �
IPlotSizeService
--� �
plotSizeService
--� �
,
--� �!
IApartmentTypeService.. 3 
apartmentTypeService..4 H
,..H I
IFacilitiesService..J \
facilitiesService..] n
,..n o#
IFloorNumberingService	..p �#
floorNumberingService
..� �
,
..� �"
IPropertyTypeService
..� �!
propertyTypeService
..� �
,
..� �$
IPropertyHeightService
..� �#
propertyHeightService
..� �
,
..� �
IBlockNumberService// 1
blockNumberService//2 D
,//D E
IBlockSideService//F W
blockSideService//X h
,//h i
IBlockTypeService//j {
blockTypeService	//| �
,
//� �
IBlockUnitService
//� �
blockUnitService
//� �
,
//� �
IActivityService00 .
activityService00/ >
,00> ? 
IActivityTypeService00@ T
activityTypeService00U h
,00h i#
IPropertyMasterService	00j �#
propertyMasterService
00� �
)
00� �
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
�� 
Ok
�� 
(
�� 
await
�� 
_activityService
�� (
.
��( )!
UpdateActivityAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteActivity
�� 
(
�� 
int
�� "

activityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� #
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
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /!
ActivityTypeReadDto
��/ B
>
��B C
>
��C D
>
��D E
GetActivityTypes
��F V
(
��V W
)
��W X
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_activityTypeService
�� ,
.
��, -"
GetActivityTypeAsync
��- A
(
��A B
)
��B C
)
��C D
;
��D E
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
ActivityTypeReadDto
��# 6
>
��6 7
>
��7 8 
CreateActivityType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
ActivityTypeCreateDto
��W l
values
��m s
)
��s t
{
�� 
try
�� 
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
_activityTypeService
�� 0
.
��0 1%
CreateActivityTypeAsync
��1 H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
ActivityTypeReadDto
��# 6
>
��6 7
>
��7 8 
UpdateActivityType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
ActivityTypeUpdateDto
��W l
values
��m s
)
��s t
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_activityTypeService
�� ,
.
��, -%
UpdateActivityTypeAsync
��- D
(
��D E
values
��E K
)
��K L
)
��L M
;
��M N
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

void
��  
DeleteActivityType
�� "
(
��" #
int
��# &
activityTypeId
��' 5
)
��5 6
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
AllocationTypeReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetAllocationType
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :
GetAllocationType
��; L
(
��L M
string
��M S
allocationType
��T b
)
��b c
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
allocationType
��F T
)
��T U
)
��U V
;
��V W
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� ;
)
��; <
]
��< =
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :#
GetAllocationTypeById
��; P
(
��P Q
int
��Q T
allocationTypeId
��U e
)
��e f
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /$
GetAllocationTypeAsync
��/ E
(
��E F
allocationTypeId
��F V
)
��V W
)
��W X
;
��X Y
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
CreateAllocationType
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
AllocationTypeCreateDto
��[ r
values
��s y
)
��y z
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� 2
.
��2 3$
AddAllocationTypeAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
new
��# &
{
��' (
detail
��) /
=
��0 1
ex
��2 4
.
��4 5
Message
��5 <
}
��= >
)
��> ?
;
��? @
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
UpdateAllocationType
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
AllocationTypeUpdateDto
��[ r
values
��s y
)
��y z
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_allocationTypeService
�� .
.
��. /'
UpdateAllocationTypeAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

void
�� "
DeleteAllocationType
�� $
(
��$ %
int
��% (
allocationTypeId
��) 9
)
��9 :
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� #
)
��# $
]
��$ %
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /"
ApartmentTypeReadDto
��/ C
>
��C D
>
��D E
>
��E F
GetApartmentType
��G W
(
��W X
)
��X Y
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :
GetApartmentType
��; K
(
��K L
string
��L R
apartmentType
��S `
)
��` a
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
apartmentType
��D Q
)
��Q R
)
��R S
;
��S T
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
AllocationTypeReadDto
��# 8
>
��8 9
>
��9 :"
GetApartmentTypeById
��; O
(
��O P
int
��P S
apartmentTypeId
��T c
)
��c d
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .#
GetApartmentTypeAsync
��. C
(
��C D
apartmentTypeId
��D S
)
��S T
)
��T U
;
��U V
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #"
ApartmentTypeReadDto
��# 7
>
��7 8
>
��8 9
AddApartmentType
��: J
(
��J K
[
��K L
FromBody
��L T
]
��T U$
ApartmentTypeCreateDto
��V l
values
��m s
)
��s t
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� 1
.
��1 2#
AddApartmentTypeAsync
��2 G
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
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #"
ApartmentTypeReadDto
��# 7
>
��7 8
>
��8 9!
UpdateApartmentType
��: M
(
��M N
[
��N O
FromBody
��O W
]
��W X$
ApartmentTypeUpdateDto
��Y o
values
��p v
)
��v w
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_apartmentTypeService
�� -
.
��- .&
UpdateApartmentTypeAsync
��. F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
public
�� 

void
�� !
DeleteApartmentType
�� #
(
��# $
int
��$ '
apartmentTypeId
��( 7
)
��7 8
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. / 
BlockNumberReadDto
��/ A
>
��A B
>
��B C
>
��C D
GetBlockNumber
��E S
(
��S T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� +
.
��+ ,!
GetBlockNumberAsync
��, ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
BlockNumberReadDto
��# 5
>
��5 6
>
��6 7
AddBlockNumber
��8 F
(
��F G
[
��G H
FromBody
��H P
]
��P Q"
BlockNumberCreateDto
��R f
values
��g m
)
��m n
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� /
.
��/ 0!
AddBlockNumberAsync
��0 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
BlockNumberReadDto
��# 5
>
��5 6
>
��6 7
UpdateBlockNumber
��8 I
(
��I J
[
��J K
FromBody
��K S
]
��S T"
BlockNumberUpdateDto
��U i
values
��j p
)
��p q
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_blockNumberService
�� +
.
��+ ,$
UpdateBlockNumberAsync
��, B
(
��B C
values
��C I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 0
)
��0 1
]
��1 2
public
�� 

void
�� 
DeleteBlockNumber
�� !
(
��! "
int
��" %

facilityId
��& 0
)
��0 1
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockSideReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockSides
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� )
.
��) *
GetBlockSideAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockSideReadDto
��# 3
>
��3 4
>
��4 5
AddBlockSide
��6 B
(
��B C
[
��C D
FromBody
��D L
]
��L M 
BlockSideCreateDto
��N `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� -
.
��- .
AddBlockSideAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockSideReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockSide
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockSideUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockSideService
�� )
.
��) *"
UpdateBlockSideAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockSide
�� 
(
��  
int
��  #
blockSideId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockTypeReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockTypes
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� )
.
��) *
GetBlockTypeAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockTypeReadDto
��# 3
>
��3 4
>
��4 5
AddBlockType
��6 B
(
��B C
[
��C D
FromBody
��D L
]
��L M 
BlockTypeCreateDto
��N `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� -
.
��- .
AddBlockTypeAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockTypeReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockType
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockTypeUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockTypeService
�� )
.
��) *"
UpdateBlockTypeAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockType
�� 
(
��  
int
��  #
blockTypeId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
BlockUnitReadDto
��/ ?
>
��? @
>
��@ A
>
��A B
GetBlockUnits
��C P
(
��P Q
)
��Q R
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� )
.
��) *
GetBlockUnitAsync
��* ;
(
��; <
)
��< =
)
��= >
;
��> ?
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockUnitReadDto
��# 3
>
��3 4
>
��4 5
CreateBlockUnit
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockUnitCreateDto
��Q c
values
��d j
)
��j k
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� -
.
��- .
AddBlockUnitAsync
��. ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
BlockUnitReadDto
��# 3
>
��3 4
>
��4 5
UpdateBlockUnit
��6 E
(
��E F
[
��F G
FromBody
��G O
]
��O P 
BlockUnitUpdateDto
��Q c
values
��d j
)
��j k
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_blockUnitService
�� )
.
��) *"
UpdateBlockUnitAsync
��* >
(
��> ?
values
��? E
)
��E F
)
��F G
;
��G H
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

void
�� 
DeleteBlockUnit
�� 
(
��  
int
��  #
blockUnitId
��$ /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
��  
)
��  !
]
��! "
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
FacilitiesReadDto
��/ @
>
��@ A
>
��A B
>
��B C
GetFacilities
��D Q
(
��Q R
)
��R S
{
�� 
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� *
.
��* + 
GetFacilitiesAsync
��+ =
(
��= >
)
��> ?
)
��? @
;
��@ A
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
FacilitiesReadDto
��# 4
>
��4 5
>
��5 6
CreateFacility
��7 E
(
��E F
[
��F G
FromBody
��G O
]
��O P!
FacilitiesCreateDto
��Q d
values
��e k
)
��k l
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� .
.
��. / 
AddFacilitiesAsync
��/ A
(
��A B
values
��B H
)
��H I
)
��I J
;
��J K
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
FacilitiesReadDto
��# 4
>
��4 5
>
��5 6
UpdateFacility
��7 E
(
��E F
[
��F G
FromBody
��G O
]
��O P!
FacilitiesUpdateDto
��Q d
values
��e k
)
��k l
{
�� 
return
�� 
Ok
�� 
(
�� 
await
��  
_facilitiesService
�� *
.
��* +#
UpdateFacilitiesAsync
��+ @
(
��@ A
values
��A G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteFacility
�� 
(
�� 
int
�� "

facilityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
FloorNumberingReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetFloorNumbering
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� .
.
��. /$
GetFloorNumberingAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
FloorNumberingReadDto
��# 8
>
��8 9
>
��9 :
CreateFloorNumber
��; L
(
��L M
[
��M N
FromBody
��N V
]
��V W%
FloorNumberingCreateDto
��X o
values
��p v
)
��v w
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� 2
.
��2 3$
AddFloorNumberingAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
FloorNumberingReadDto
��# 8
>
��8 9
>
��9 :
UpdateFloorNumber
��; L
(
��L M
[
��M N
FromBody
��N V
]
��V W%
FloorNumberingUpdateDto
��X o
values
��p v
)
��v w
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_floorNumberingService
�� .
.
��. /'
UpdateFloorNumberingAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

void
�� 
DeleteFloorNumber
�� !
(
��! "
int
��" %
floorNumberId
��& 3
)
��3 4
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
LandUseReadDto
��/ =
>
��= >
>
��> ?
>
��? @

GetLandUse
��A K
(
��K L
)
��L M
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� '
)
��' (
]
��( )
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3

GetLandUse
��4 >
(
��> ?
string
��? E
landUse
��F M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
landUse
��8 ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� -
)
��- .
]
��. /
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
GetLandUseById
��4 B
(
��B C
int
��C F
	landUseId
��G P
)
��P Q
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' (
GetLandUseAsync
��( 7
(
��7 8
	landUseId
��8 A
)
��A B
)
��B C
;
��C D
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
CreateLandUse
��4 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
LandUseCreateDto
��M ]
values
��^ d
)
��d e
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� +
.
��+ ,
AddLandUseAsync
��, ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
UpdateLandUse
��4 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
LandUseUpdateDto
��M ]
values
��^ d
)
��d e
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_landUseService
�� '
.
��' ( 
UpdateLandUseAsync
��( :
(
��: ;
values
��; A
)
��A B
)
��B C
;
��C D
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� +
)
��+ ,
]
��, -
public
�� 

void
�� 
DeleteLandUse
�� 
(
�� 
int
�� !
	landUseId
��" +
)
��+ ,
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. / 
LandUseTypeReadDto
��/ A
>
��A B
>
��B C
>
��C D
GetLandUseType
��E S
(
��S T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
)
��@ A
)
��A B
;
��B C
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� +
)
��+ ,
]
��, -
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
LandUseTypeReadDto
��# 5
>
��5 6
>
��6 7
GetLandUseType
��8 F
(
��F G
string
��G M
landUse
��N U
)
��U V
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
landUse
��@ G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 5
)
��5 6
]
��6 7
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3 
GetLandUseTypeById
��4 F
(
��F G
int
��G J
	landUseId
��K T
)
��T U
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,!
GetLandUseTypeAsync
��, ?
(
��? @
	landUseId
��@ I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" # 
LandUseTypeReadDto
��# 5
>
��5 6
>
��6 7
CreateLandUseType
��8 I
(
��I J
[
��J K
FromBody
��K S
]
��S T"
LandUseTypeCreateDto
��U i
values
��j p
)
��p q
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� /
.
��/ 0!
AddLandUseTypeAsync
��0 C
(
��C D
values
��D J
)
��J K
)
��K L
;
��L M
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LandUseReadDto
��# 1
>
��1 2
>
��2 3
UpdateLandUseType
��4 E
(
��E F
[
��F G
FromBody
��G O
]
��O P"
LandUseTypeUpdateDto
��Q e
values
��f l
)
��l m
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_landUseTypeService
�� +
.
��+ ,$
UpdateLandUseTypeAsync
��, B
(
��B C
values
��C I
)
��I J
)
��J K
;
��K L
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
public
�� 

void
�� 
DeleteLandUseType
�� !
(
��! "
int
��" %
	landUseId
��& /
)
��/ 0
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
LocalityReadDto
��/ >
>
��> ?
>
��? @
>
��@ A

GeLocality
��B L
(
��L M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :
)
��: ;
)
��; <
;
��< =
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� &
)
��& '
]
��' (
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
GetLocality
��5 @
(
��@ A
string
��A G
value
��H M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :
value
��: ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
GetLocalityById
��5 D
(
��D E
int
��E H

localityId
��I S
)
��S T
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )
GetLocalityAsync
��) 9
(
��9 :

localityId
��: D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
CreateLocality
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
LocalityCreateDto
��O `
values
��a g
)
��g h
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� ,
.
��, -!
CreateLocalityAsync
��- @
(
��@ A
values
��A G
)
��G H
)
��H I
;
��I J
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
LocalityReadDto
��# 2
>
��2 3
>
��3 4
UpdateLocality
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
LocalityUpdateDto
��O `
values
��a g
)
��g h
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_localityService
�� (
.
��( )!
UpdateLocalityAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeleteLocality
�� 
(
�� 
int
�� "

localityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /
PlotSizeReadDto
��/ >
>
��> ?
>
��? @
>
��@ A
GetPlotSize
��B M
(
��M N
)
��N O
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :
)
��: ;
)
��; <
;
��< =
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� &
)
��& '
]
��' (
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
GetPlotSize
��5 @
(
��@ A
string
��A G
value
��H M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :
value
��: ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� /
)
��/ 0
]
��0 1
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
GetPlotSizeById
��5 D
(
��D E
int
��E H

plotSizeId
��I S
)
��S T
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )
GetPlotSizeAsync
��) 9
(
��9 :

plotSizeId
��: D
)
��D E
)
��E F
;
��F G
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
AddPlotSize
��5 @
(
��@ A
[
��A B
FromBody
��B J
]
��J K
PlotSizeCreateDto
��L ]
values
��^ d
)
��d e
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� ,
.
��, -
AddPlotSizeAsync
��- =
(
��= >
values
��> D
)
��D E
)
��E F
;
��F G
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
PlotSizeReadDto
��# 2
>
��2 3
>
��3 4
UpdatePlotSize
��5 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
PlotSizeUpdateDto
��O `
values
��a g
)
��g h
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_plotSizeService
�� (
.
��( )!
UpdatePlotSizeAsync
��) <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� -
)
��- .
]
��. /
public
�� 

void
�� 
DeletePlotSize
�� 
(
�� 
int
�� "

localityId
��# -
)
��- .
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� $
)
��$ %
]
��% &
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /#
PropertyHeightReadDto
��/ D
>
��D E
>
��E F
>
��F G
GetPropertyHeight
��H Y
(
��Y Z
)
��Z [
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� .
.
��. /$
GetPropertyHeightAsync
��/ E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
PropertyHeightReadDto
��# 8
>
��8 9
>
��9 :"
CreatePropertyHeight
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
PropertyHeightCreateDto
��[ r
values
��s y
)
��y z
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� 2
.
��2 3$
AddPropertyHeightAsync
��3 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� !
)
��! "
]
��" #
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" ##
PropertyHeightReadDto
��# 8
>
��8 9
>
��9 :"
UpdatePropertyHeight
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
PropertyHeightUpdateDto
��[ r
values
��s y
)
��y z
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_propertyHeightService
�� .
.
��. /'
UpdatePropertyHeightAsync
��/ H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 
[
�� 

HttpDelete
�� 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 

void
�� "
DeletePropertyHeight
�� $
(
��$ %
int
��% (
propertyHeightId
��) 9
)
��9 :
{
�� 
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� "
)
��" #
]
��# $
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #
IEnumerable
��# .
<
��. /!
PropertyTypeReadDto
��/ B
>
��B C
>
��C D
>
��D E
GetPropertyType
��F U
(
��U V
)
��V W
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
)
��B C
)
��C D
;
��D E
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� *
)
��* +
]
��+ ,
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8
GetPropertyType
��9 H
(
��H I
string
��I O
value
��P U
)
��U V
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
value
��B G
)
��G H
)
��H I
;
��I J
}
�� 
[
�� 
HttpGet
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 7
)
��7 8
]
��8 9
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8!
GetPropertyTypeById
��9 L
(
��L M
int
��M P
propertyTypeId
��Q _
)
��_ `
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -"
GetPropertyTypeAsync
��- A
(
��A B
propertyTypeId
��B P
)
��P Q
)
��Q R
;
��R S
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8 
CreatePropertyType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
PropertyTypeCreateDto
��W l
values
��m s
)
��s t
{
�� 
try
�� 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� 0
.
��0 1"
AddPropertyTypeAsync
��1 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
}
�� 	
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
�� 
{
�� 	
return
�� 

StatusCode
�� 
(
�� 
$num
�� !
,
��! "
ex
��# %
.
��% &
InnerException
��& 4
!
��4 5
.
��5 6
Message
��6 =
)
��= >
;
��> ?
}
�� 	
}
�� 
[
�� 
HttpPut
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
��  
]
��  !
public
�� 

async
�� 
Task
�� 
<
�� 
ActionResult
�� "
<
��" #!
PropertyTypeReadDto
��# 6
>
��6 7
>
��7 8 
UpdatePropertyType
��9 K
(
��K L
[
��L M
FromBody
��M U
]
��U V#
PropertyTypeUpdateDto
��W l
values
��m s
)
��s t
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_propertyTypeService
�� ,
.
��, -%
UpdatePropertyTypeAsync
��- D
(
��D E
values
��E K
)
��K L
)
��L M
;
��M N
}
�	�	 
[
�	�	 

HttpDelete
�	�	 
(
�	�	 
$str
�	�	 5
)
�	�	5 6
]
�	�	6 7
public
�	�	 

void
�	�	  
DeletePropertyType
�	�	 "
(
�	�	" #
int
�	�	# &
propertyTypeId
�	�	' 5
)
�	�	5 6
{
�	�	 
}
�	�	 
[
�	�	 
HttpPost
�	�	 
]
�	�	 
[
�	�	 
Route
�	�	 

(
�	�	
 
$str
�	�	 
)
�	�	 
]
�	�	 
public
�	�	 

async
�	�	 
Task
�	�	 
<
�	�	 
ActionResult
�	�	 "
<
�	�	" #!
PropertyTypeReadDto
�	�	# 6
>
�	�	6 7
>
�	�	7 8
CreateProperty
�	�	9 G
(
�	�	G H
[
�	�	H I
FromBody
�	�	I Q
]
�	�	Q R)
PropertyMasterCreatePlotDto
�	�	S n
values
�	�	o u
)
�	�	u v
{
�	�	 
try
�	�	 
{
�	�	 	
return
�	�	 
Ok
�	�	 
(
�	�	 
await
�	�	 $
_propertyMasterService
�	�	 2
.
�	�	2 3
CreateProperty
�	�	3 A
(
�	�	A B
values
�	�	B H
)
�	�	H I
)
�	�	I J
;
�	�	J K
}
�	�	 	
catch
�	�	 
(
�	�	 
	Exception
�	�	 
ex
�	�	 
)
�	�	 
{
�	�	 	
return
�	�	 

StatusCode
�	�	 
(
�	�	 
$num
�	�	 !
,
�	�	! "
ex
�	�	# %
.
�	�	% &
InnerException
�	�	& 4
!
�	�	4 5
.
�	�	5 6
Message
�	�	6 =
)
�	�	= >
;
�	�	> ?
}
�	�	 	
}
�	�	 
}�	�	 ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomersController.cs
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
�� !
)
��! "
]
��" #
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& '
AddJointCustomer
��( 8
(
��8 9
[
��9 :
FromBody
��: B
]
��B C'
JointOwnershipCustomerDto
��D ]
values
��^ d
)
��d e
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )
	CreatedBy
��) 2
!
��2 3
)
��3 4
)
��4 5
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
cnt
�� 
=
�� 
values
��  
.
��  !
CoLesse
��! (
!
��( )
.
��) *
Count
��* /
(
��/ 0
)
��0 1
;
��1 2
if
�� 
(
�� 
cnt
�� 
==
�� 
$num
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� %
(
��% &
CustomerConstants
��& 7
.
��7 8
ErrorCoLesseEmpty
��8 I
)
��I J
;
��J K
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
CreateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
�� !
)
��! "
]
��" #
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& '
AddMultiCustomer
��( 8
(
��8 9
[
��9 :
FromBody
��: B
]
��B C'
MultiOwnershipCustomerDto
��D ]
values
��^ d
)
��d e
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )
	CreatedBy
��) 2
!
��2 3
)
��3 4
)
��4 5
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
cnt
�� 
=
�� 
values
��  
.
��  !
	Dependent
��! *
!
��* +
.
��+ ,
Count
��, 1
(
��1 2
)
��2 3
;
��3 4
if
�� 
(
�� 
cnt
�� 
==
�� 
$num
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� %
(
��% &
CustomerConstants
��& 7
.
��7 8!
ErrorDependentEmpty
��8 K
)
��K L
;
��L M
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
CreateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
HttpPut
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
��  
)
��  !
]
��! "
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� :
)
��: ;
]
��; <
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
>
��& '
StopCustomerDebit
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D 
ApproveCustomerDto
��E W
values
��X ^
)
��^ _
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2

approvedBy
��2 <
)
��< =
)
��= >
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
status
�� 
=
�� 
await
�� "$
_customerMasterService
��# 9
.
��9 :"
ApproveCustomerAsync
��: N
(
��N O
values
��O U
)
��U V
;
��V W
return
�� 
status
�� 
switch
�� $
{
�� 
$num
�� 
=>
�� 
Ok
�� 
(
�� 
$str
�� '
)
��' (
,
��( )
$num
�� 
=>
�� 

BadRequest
�� %
(
��% &
)
��& '
,
��' (
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
$"
��$ &
$str
��& 4
{
��4 5
values
��5 ;
.
��; <
customerCode
��< H
}
��H I
$str
��I S
"
��S T
)
��T U
,
��U V
$num
�� 
=>
�� 

StatusCode
�� %
(
��% &
$num
��& )
,
��) *
$str
��+ 9
)
��9 :
,
��: ;
_
�� 
=>
�� 

StatusCode
�� #
(
��# $
$num
��$ '
,
��' (
$str
��) @
)
��@ A
,
��A B
}
�� 
;
�� 
;
�� 
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
�� 2
)
��2 3
]
��3 4
[
�� 	
AllowAnonymous
��	 
]
�� 
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
>
��& '
GetCustomer
��( 3
(
��3 4
string
��4 :
customerCode
��; G
)
��G H
{
�� 	
try
�� 
{
�� 
var
�� 
result
�� 
=
�� 
await
�� "$
_customerMasterService
��# 9
.
��9 :
GetCustomer
��: E
(
��E F
customerCode
��F R
)
��R S
;
��S T
if
�� 
(
�� 
result
�� 
is
�� 
null
�� "
)
��" #
{
�� 
return
�� 
NotFound
�� #
(
��# $
$"
��$ &
$str
��& 4
{
��4 5
customerCode
��5 A
}
��A B
$str
��B M
"
��M N
)
��N O
;
��O P
}
�� 
if
�� 
(
�� 
result
�� 
.
�� 
CustomerTypeId
�� )
==
��* ,
(
��- .
int
��. 1
)
��1 2
CustomerTypeEnum
��2 B
.
��B C
PROSPECTIVE
��C N
)
��N O
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #$
_customerMasterService
��$ :
.
��: ;+
GetProspectiveCustomerDetails
��; X
(
��X Y
customerCode
��Y e
)
��e f
)
��f g
;
��g h
}
�� 
if
�� 
(
�� 
result
�� 
.
�� 
CustomerTypeId
�� )
==
��* ,
(
��- .
int
��. 1
)
��1 2
CustomerTypeEnum
��2 B
.
��B C
COMPANY
��C J
)
��J K
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #$
_customerMasterService
��$ :
.
��: ;'
GetCompanyCustomerDetails
��; T
(
��T U
customerCode
��U a
)
��a b
)
��b c
;
��c d
}
�� 
if
�� 
(
�� 
result
�� 
.
�� 
CustomerTypeId
�� )
==
��* ,
(
��- .
int
��. 1
)
��1 2
CustomerTypeEnum
��2 B
.
��B C

INDIVIDUAL
��C M
)
��M N
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #$
_customerMasterService
��$ :
.
��: ;*
GetIndividualCustomerDetails
��; W
(
��W X
customerCode
��X d
)
��d e
)
��e f
;
��f g
}
�� 
if
�� 
(
�� 
result
�� 
.
�� 
CustomerTypeId
�� )
==
��* ,
(
��- .
int
��. 1
)
��1 2
CustomerTypeEnum
��2 B
.
��B C
JOINT_OWNERSHIP
��C R
)
��R S
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #$
_customerMasterService
��$ :
.
��: ;%
GetJointCustomerDetails
��; R
(
��R S
customerCode
��S _
)
��_ `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� 
result
�� 
.
�� 
CustomerTypeId
�� )
==
��* ,
(
��- .
int
��. 1
)
��1 2
CustomerTypeEnum
��2 B
.
��B C
MULTI_OWNERSHIP
��C R
)
��R S
{
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #$
_customerMasterService
��$ :
.
��: ;%
GetMultiCustomerDetails
��; R
(
��R S
customerCode
��S _
)
��_ `
)
��` a
;
��a b
}
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
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
HttpPut
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
��' (
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& '#
UpdateCompanyCustomer
��( =
(
��= >
[
��> ?
FromBody
��? G
]
��G H&
UpdateCompanyCustomerDto
��I a
values
��b h
)
��h i
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2

ModifiedBy
��2 <
)
��< =
)
��= >
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
var
�� 
result
�� 
=
�� 
await
�� "$
_customerMasterService
��# 9
.
��9 :
UpdateCustomer
��: H
(
��H I
values
��I O
)
��O P
;
��P Q
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
�� $
)
��$ %
{
�� 
return
�� 
Ok
�� 
(
�� 
result
�� $
.
��$ %
SuccessResponse
��% 4
)
��4 5
;
��5 6
}
�� 
var
�� 
status
�� 
=
�� 
result
�� #
.
��# $
ErrorResponse
��$ 1
!
��1 2
.
��2 3

StatusCode
��3 =
;
��= >
return
�� 
status
�� 
switch
�� $
{
�� 
$num
�� 
=>
�� 
	NoContent
�� $
(
��$ %
)
��% &
,
��& '
$num
�� 
=>
�� 

BadRequest
�� %
(
��% &
result
��& ,
.
��, -
ErrorResponse
��- :
)
��: ;
,
��; <
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
result
��$ *
.
��* +
ErrorResponse
��+ 8
)
��8 9
,
��9 :
_
�� 
=>
�� 

StatusCode
�� #
(
��# $
$num
��$ '
,
��' (
result
��) /
.
��/ 0
ErrorResponse
��0 =
)
��= >
,
��> ?
}
�� 
;
�� 
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
HttpPut
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
�� )
)
��) *
]
��* +
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
[
�� 	
Obsolete
��	 
]
�� 
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
>
��& '&
UpdateIndividualCustomer
��( @
(
��@ A
[
��A B
FromBody
��B J
]
��J K1
#UpdateIndividualResidentCustomerDto
��L o
values
��p v
)
��v w
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )

ModifiedBy
��) 3
!
��3 4
)
��4 5
)
��5 6
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
UpdateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
HttpPut
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
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
[
�� 	
Obsolete
��	 
]
�� 
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
>
��& '!
UpdateJointCustomer
��( ;
(
��; <
[
��< =
FromBody
��= E
]
��E F-
UpdateJointOwnershipCustomerDto
��G f
values
��g m
)
��m n
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )

ModifiedBy
��) 3
!
��3 4
)
��4 5
)
��5 6
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
UpdateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
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
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
[
�� 	
Obsolete
��	 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '!
UpdateMultiCustomer
��( ;
(
��; <
[
��< =
FromBody
��= E
]
��E F-
UpdateMultiOwnershipCustomerDto
��G f
values
��g m
)
��m n
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )

ModifiedBy
��) 3
!
��3 4
)
��4 5
)
��5 6
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
validationError
�� #
=
��$ %%
ValidateCustomerDetails
��& =
(
��= >
values
��> D
)
��D E
;
��E F
if
�� 
(
�� 
validationError
�� #
is
��$ &
not
��' *
null
��+ /
)
��/ 0
{
�� 
return
�� 

BadRequest
�� %
(
��% &
validationError
��& 5
)
��5 6
;
��6 7
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
UpdateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� &
)
��& '
]
��' (
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '#
UpdateCustomerDetails
��( =
(
��= >
[
��> ?
FromBody
��? G
]
��G H-
UpdateJointOwnershipCustomerDto
��I h
values
��i o
)
��o p
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
!
�� 
IsAuthorized
�� !
(
��! "
values
��" (
.
��( )

ModifiedBy
��) 3
!
��3 4
)
��4 5
)
��5 6
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
��  6
.
��6 7
UpdateCustomer
��7 E
(
��E F
values
��F L
)
��L M
)
��M N
;
��N O
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� ?
)
��? @
]
��@ A
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
DeleteCustomer
��( 6
(
��6 7
string
��7 =
customerCode
��> J
,
��J K
string
��L R
	deletedBy
��S \
)
��\ ]
{
�� 	
try
�� 
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .
customerCode
��. :
)
��: ;
&&
��< >
string
��? E
.
��E F 
IsNullOrWhiteSpace
��F X
(
��X Y
	deletedBy
��Y b
)
��b c
)
��c d
{
�� 
return
�� 

BadRequest
�� %
(
��% &
$str
��& _
)
��_ `
;
��` a
}
�� 
var
�� 
values
�� 
=
�� 
new
��  &
DeleteCustomerRequestDto
��! 9
(
��9 :
customerCode
��: F
,
��F G
	deletedBy
��H Q
)
��Q R
;
��R S
var
�� 
response
�� 
=
�� 
await
�� $$
_customerMasterService
��% ;
.
��; <!
DeleteCustomerAsync
��< O
(
��O P
values
��P V
)
��V W
;
��W X
return
�� 
response
�� 
switch
��  &
{
�� 
$num
�� 
=>
�� 
Ok
�� 
(
�� 
$str
�� 5
)
��5 6
,
��6 7
$num
�� 
=>
�� 

BadRequest
�� %
(
��% &
)
��& '
,
��' (
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
$str
��$ L
)
��L M
,
��M N
_
�� 
=>
�� 

StatusCode
�� #
(
��# $
$num
��$ '
,
��' (
$str
��) @
)
��@ A
,
��A B
}
�� 
;
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
StopCustomerDebit
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D!
StopDebitRequestDto
��E X
values
��Y _
)
��_ `
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
ActionBy
��2 :
)
��: ;
)
��; <
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
status
�� 
=
�� 
await
�� "$
_customerMasterService
��# 9
.
��9 :$
StopCustomerDebitAsync
��: P
(
��P Q
values
��Q W
)
��W X
;
��X Y
return
�� 
status
�� 
switch
�� $
{
�� 
$num
�� 
=>
�� 
Ok
�� 
(
�� 
$str
�� '
)
��' (
,
��( )
$num
�� 
=>
�� 

BadRequest
�� %
(
��% &
)
��& '
,
��' (
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
$"
��$ &
$str
��& 4
{
��4 5
values
��5 ;
.
��; <
CustomerCode
��< H
}
��H I
$str
��I S
"
��S T
)
��T U
,
��U V
$num
�� 
=>
�� 

StatusCode
�� %
(
��% &
$num
��& )
,
��) *
$str
��* 8
)
��8 9
,
��9 :
_
�� 
=>
�� 

StatusCode
�� #
(
��# $
$num
��$ '
,
��' (
$str
��) @
)
��@ A
,
��A B
}
�� 
;
�� 
;
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '!
UnstopCustomerDebit
��( ;
(
��; <
[
��< =
FromBody
��= E
]
��E F!
StopDebitRequestDto
��G Z
values
��[ a
)
��a b
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
ActionBy
��2 :
)
��: ;
)
��; <
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
var
�� 
status
�� 
=
�� 
await
�� "$
_customerMasterService
��# 9
.
��9 :$
StopCustomerDebitAsync
��: P
(
��P Q
values
��Q W
)
��W X
;
��X Y
return
�� 
status
�� 
switch
�� $
{
�� 
$num
�� 
=>
�� 
Ok
�� 
(
�� 
$str
�� '
)
��' (
,
��( )
$num
�� 
=>
�� 

BadRequest
�� %
(
��% &
)
��& '
,
��' (
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
$"
��$ &
$str
��& 4
{
��4 5
values
��5 ;
.
��; <
CustomerCode
��< H
}
��H I
$str
��I S
"
��S T
)
��T U
,
��U V
$num
�� 
=>
�� 

StatusCode
�� %
(
��% &
$num
��& )
,
��) *
$str
��+ 9
)
��9 :
,
��: ;
_
�� 
=>
�� 

StatusCode
�� #
(
��# $
$num
��$ '
,
��' (
$str
��) @
)
��@ A
,
��A B
}
�� 
;
�� 
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
private
�� 
bool
�� 
IsAuthorized
�� !
(
��! "
string
��" (

modifiedBy
��) 3
)
��3 4
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
return
�� 
string
�� 
.
�� 
Equals
��  
(
��  !
userId
��! '
,
��' (

modifiedBy
��) 3
)
��3 4
;
��4 5
}
�� 	
private
�� 
string
�� 
?
�� %
ValidateCustomerDetails
�� /
(
��/ 0
dynamic
��0 7
values
��8 >
)
��> ?
{
�� 	
return
�� 
values
�� 
.
�� 
ResidentTypeId
�� (
switch
��) /
{
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &

EXPATRIATE
��& 0
=>
��1 3 
ValidateExpatriate
��4 F
(
��F G
values
��G M
.
��M N

Expatriate
��N X
)
��X Y
,
��Y Z
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &
NON_RESIDENT
��& 2
=>
��3 5!
ValidateNonResident
��6 I
(
��I J
values
��J P
.
��P Q
NonResident
��Q \
)
��\ ]
,
��] ^
_
�� 
=>
�� 
null
�� 
}
�� 
;
�� 
}
�� 	
private
�� 
static
�� 
string
�� 
?
��  
ValidateExpatriate
�� 1
(
��1 2-
IndividualExpatriateCustomerDto
��2 Q
?
��Q R

expatriate
��S ]
)
��] ^
{
�� 	
if
�� 
(
�� 

expatriate
�� 
is
�� 
null
�� "
)
��" #
return
��$ *
CustomerConstants
��+ <
.
��< =!
ErrorExpatriateNull
��= P
;
��P Q
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *

expatriate
��* 4
.
��4 5"
ResidentPermitNumber
��5 I
)
��I J
)
��J K
return
��L R
CustomerConstants
��S d
.
��d e%
ErrorResidentPermitNull
��e |
;
��| }
return
�� 
null
�� 
;
�� 
}
�� 	
private
�� 
static
�� 
string
�� 
?
�� !
ValidateNonResident
�� 2
(
��2 3.
 IndividualNonResidentCustomerDto
��3 S
?
��S T
nonResident
��U `
)
��` a
{
�� 	
if
�� 
(
�� 
nonResident
�� 
is
�� 
null
�� #
)
��# $
return
��% +
CustomerConstants
��, =
.
��= >"
ErrorNonResidentNull
��> R
;
��R S
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
nonResident
��* 5
.
��5 6$
ContactPerson_FullName
��6 L
)
��L M
)
��M N
return
��O U
CustomerConstants
��V g
.
��g h'
ErrorContactFullNameNull��h �
;��� �
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
nonResident
��* 5
.
��5 6(
ContactPerson_EmailAddress
��6 P
)
��P Q
)
��Q R
return
��S Y
CustomerConstants
��Z k
.
��k l$
ErrorContactEmailNull��l �
;��� �
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
nonResident
��* 5
.
��5 6'
ContactPerson_PhoneNumber
��6 O
)
��O P
)
��P Q
return
��R X
CustomerConstants
��Y j
.
��j k$
ErrorContactPhoneNull��k �
;��� �
return
�� 
null
�� 
;
�� 
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/CustomerController.cs
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
IIdentificationTypeService	,,j �'
identificationTypeService
,,� �
,
,,� �!
INationalityService
,,� � 
nationalityService
,,� �
,
,,� �"
IResidentTypeService
,,� �!
residentTypeService
,,� �
,
,,� �
ISocialMediaService--" 5
socialMediaService--6 H
,--H I
ITitleService--J W
titleService--X d
,--d e"
ICustomerMasterService--f |"
customerMasterService	--} �
,
--� �#
IOwnershipTypeService
--� �"
ownershipTypeService
--� �
,
--� �!
IUserContextService
--� � 
userContextService
--� �
)
--� �
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
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedBy
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_customerTypeService
�� 0
.
��0 1%
UpdateCustomerTypeAsync
��1 H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& ' 
DeleteCustomerType
��( :
(
��: ;
int
��; >
customerTypeId
��? M
)
��M N
{
�� 	
var
�� 
response
�� 
=
�� 
await
��  "
_customerTypeService
��! 5
.
��5 6$
DeleteCustomerTyeAsync
��6 L
(
��L M
customerTypeId
��M [
)
��[ \
;
��\ ]
if
�� 
(
�� 
response
�� 
==
�� 
$str
�� $
)
��$ %
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
_customerTypeService
��  4
.
��4 5$
DeleteCustomerTyeAsync
��5 K
(
��K L
customerTypeId
��L Z
)
��Z [
)
��[ \
;
��\ ]
}
�� 
return
�� 

BadRequest
�� 
(
�� 
)
�� 
;
��  
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
�� 
)
�� 
]
�� 
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
��2 3
GenderReadDto
��3 @
>
��@ A
>
��A B
>
��B C
	GetGender
��D M
(
��M N
)
��N O
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_genderService
�� *
.
��* +
GetGenderAsync
��+ 9
(
��9 :
)
��: ;
)
��; <
;
��< =
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
�� "
)
��" #
]
��# $
private
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� '
<
��' (
GenderReadDto
��( 5
>
��5 6
>
��6 7
	GetGender
��8 A
(
��A B
string
��B H
value
��I N
)
��N O
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_genderService
�� *
.
��* +
GetGenderAsync
��+ 9
(
��9 :
value
��: ?
)
��? @
)
��@ A
;
��A B
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
�� %
)
��% &
]
��& '
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
��& '
GenderReadDto
��' 4
>
��4 5
>
��5 6
	GetGender
��7 @
(
��@ A
int
��A D
genderId
��E M
)
��M N
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_genderService
�� *
.
��* +
GetGenderAsync
��+ 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
;
��D E
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
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
��& '
GenderReadDto
��' 4
>
��4 5
>
��5 6
CreateGender
��7 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
GenderCreateDto
��O ^
values
��_ e
)
��e f
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdBy
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_genderService
��  .
.
��. /
AddGenderAsync
��/ =
(
��= >
values
��> D
)
��D E
)
��E F
;
��F G
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
HttpPut
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
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
��& '
GenderReadDto
��' 4
>
��4 5
>
��5 6
UpdateGender
��7 C
(
��C D
[
��D E
FromBody
��E M
]
��M N
GenderUpdateDto
��O ^
values
��_ e
)
��e f
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedBy
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_genderService
�� *
.
��* +
UpdateGenderAsync
��+ <
(
��< =
values
��= C
)
��C D
)
��D E
;
��E F
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� -
)
��- .
]
��. /
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& '
DeleteGender
��( 4
(
��4 5
int
��5 8
genderId
��9 A
)
��A B
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
_genderService
�� *
.
��* +
DeleteGenderAsync
��+ <
(
��< =
genderId
��= E
)
��E F
)
��F G
;
��G H
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
�� '
)
��' (
]
��( )
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
��2 3'
IdentificationTypeReadDto
��3 L
>
��L M
>
��M N
>
��N O$
GetIdentificationTypes
��P f
(
��f g
)
��g h
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
�� 6
.
��6 7(
GetIdentificationTypeAsync
��7 Q
(
��Q R
)
��R S
)
��S T
;
��T U
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
�� )
)
��) *
]
��* +
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
��& ''
IdentificationTypeReadDto
��' @
>
��@ A
>
��A B&
CreateIdentificationType
��C [
(
��[ \
[
��\ ]
FromBody
��] e
]
��e f*
IdentificationTypeCreateDto��g �
values��� �
)��� �
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdBy
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
��  :
.
��: ;(
AddIdentificationTypeAsync
��; U
(
��U V
values
��V \
)
��\ ]
)
��] ^
;
��^ _
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
HttpPut
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
�� )
)
��) *
]
��* +
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
��& ''
IdentificationTypeReadDto
��' @
>
��@ A
>
��A B 
UpdateCustomerType
��C U
(
��U V
[
��V W
FromBody
��W _
]
��_ `)
IdentificationTypeUpdateDto
��a |
values��} �
)��� �
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedBy
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
�� 6
.
��6 7+
UpdateIdentificationTypeAsync
��7 T
(
��T U
values
��U [
)
��[ \
)
��\ ]
;
��] ^
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� E
)
��E F
]
��F G
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
>
��& '&
DeleteIdentificationType
��( @
(
��@ A
int
��A D"
identificationTypeId
��E Y
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
�� (
_identificationTypeService
�� 6
.
��6 7+
DeleteIdentificationTypeAsync
��7 T
(
��T U"
identificationTypeId
��U i
)
��i j
)
��j k
;
��k l
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
��& '
IEnumerable
��' 2
<
��2 3 
NationalityReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetNationality
��I W
(
��W X
)
��X Y
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
_nationalityService
�� /
.
��/ 0!
GetNationalityAsync
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
�� "
)
��" #
]
��# $
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
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
NationalityReadDto
��' 9
>
��9 :
>
��: ;
CreateNationality
��< M
(
��M N
[
��N O
FromBody
��O W
]
��W X"
NationalityCreateDto
��Y m
values
��n t
)
��t u
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdby
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_nationalityService
��  3
.
��3 4!
AddNationalityAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
NationalityReadDto
��' 9
>
��9 :
>
��: ;
UpdateNationality
��< M
(
��M N
[
��N O
FromBody
��O W
]
��W X"
NationalityUpdateDto
��Y m
values
��n t
)
��t u
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedby
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_nationalityService
�� /
.
��/ 0$
UpdateNationalityAsync
��0 F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
DeleteNationality
��( 9
(
��9 :
int
��: =
nationalityId
��> K
)
��K L
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_nationalityService
�� /
.
��/ 0$
DeleteNationalityAsync
��0 F
(
��F G
nationalityId
��G T
)
��T U
)
��U V
;
��V W
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3!
ResidentTypeReadDto
��3 F
>
��F G
>
��G H
>
��H I
GetResidentTypes
��J Z
(
��Z [
)
��[ \
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_residentTypeService
�� 0
.
��0 1"
GetResidentTypeAsync
��1 E
(
��E F
)
��F G
)
��G H
;
��H I
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� #
)
��# $
]
��$ %
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '!
ResidentTypeReadDto
��' :
>
��: ;
>
��; < 
CreateResidentType
��= O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z#
ResidentTypeCreateDto
��[ p
values
��q w
)
��w x
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdBy
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_residentTypeService
��  4
.
��4 5"
AddResidentTypeAsync
��5 I
(
��I J
values
��J P
)
��P Q
)
��Q R
;
��R S
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� #
)
��# $
]
��$ %
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '!
ResidentTypeReadDto
��' :
>
��: ;
>
��; < 
UpdateResidentType
��= O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z#
ResidentTypeUpdateDto
��[ p
values
��q w
)
��w x
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedBy
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� "
_residentTypeService
�� 0
.
��0 1%
UpdateResidentTypeAsync
��1 H
(
��H I
values
��I O
)
��O P
)
��P Q
;
��Q R
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 9
)
��9 :
]
��: ;
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& ' 
DeleteResidentType
��( :
(
��: ;
int
��; >
residentTypeId
��? M
)
��M N
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� "
_residentTypeService
�� 0
.
��0 1%
DeleteResidentTypeAsync
��1 H
(
��H I
residentTypeId
��I W
)
��W X
)
��X Y
;
��Y Z
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3 
SocialMediaReadDto
��3 E
>
��E F
>
��F G
>
��G H
GetSocialMedia
��I W
(
��W X
)
��X Y
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_socialMediaService
�� /
.
��/ 0!
GetSocialMediaAsync
��0 C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
��  
]
��  !
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
SocialMediaReadDto
��' 9
>
��9 :
>
��: ;
AddSocialMedia
��< J
(
��J K
[
��K L
FromBody
��L T
]
��T U"
SocialMediaCreateDto
��V j
values
��k q
)
��q r
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	CreatedBy
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_socialMediaService
��  3
.
��3 4!
AddSocialMediaAsync
��4 G
(
��G H
values
��H N
)
��N O
)
��O P
;
��P Q
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& ' 
SocialMediaReadDto
��' 9
>
��9 :
>
��: ;
UpdateSocialMedia
��< M
(
��M N
[
��N O
FromBody
��O W
]
��W X"
SocialMediaUpdateDto
��Y m
values
��n t
)
��t u
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

ModifiedBy
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� !
_socialMediaService
�� /
.
��/ 0$
UpdateSocialMediaAsync
��0 F
(
��F G
values
��G M
)
��M N
)
��N O
;
��O P
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
DeleteSocialMedia
��( 9
(
��9 :
int
��: =
socialMediaId
��> K
)
��K L
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� !
_socialMediaService
�� /
.
��/ 0$
DeleteSocialMediaAsync
��0 F
(
��F G
socialMediaId
��G T
)
��T U
)
��U V
;
��V W
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
TitleReadDto
��3 ?
>
��? @
>
��@ A
>
��A B
	GetTitles
��C L
(
��L M
)
��M N
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
)
��8 9
)
��9 :
;
��: ;
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
private
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� '
<
��' (
TitleReadDto
��( 4
>
��4 5
>
��5 6
GetTitle
��7 ?
(
��? @
string
��@ F
value
��G L
)
��L M
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
value
��8 =
)
��= >
)
��> ?
;
��? @
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
GetTitleById
��6 B
(
��B C
int
��C F
titleId
��G N
)
��N O
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
GetTitleAsync
��* 7
(
��7 8
titleId
��8 ?
)
��? @
)
��@ A
;
��A B
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
CreateTitle
��6 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
TitleCreateDto
��M [
values
��\ b
)
��b c
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdby
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
��  -
.
��- .
AddTitleAsync
��. ;
(
��; <
values
��< B
)
��B C
)
��C D
;
��D E
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5
UpdateTitle
��6 A
(
��A B
[
��B C
FromBody
��C K
]
��K L
TitleUpdateDto
��M [
values
��\ b
)
��b c
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedby
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
UpdateTitleAsync
��* :
(
��: ;
values
��; A
)
��A B
)
��B C
;
��C D
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� +
)
��+ ,
]
��, -
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '
DeleteTitle
��( 3
(
��3 4
int
��4 7
titleId
��8 ?
)
��? @
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_titleService
�� )
.
��) *
DeleteTitleAsync
��* :
(
��: ;
titleId
��; B
)
��B C
)
��C D
;
��D E
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� "
)
��" #
]
��# $
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3"
OwnershipTypeReadDto
��3 G
>
��G H
>
��H I
>
��I J
GetOwnershipTypes
��K \
(
��\ ]
)
��] ^
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
�� 1
.
��1 2#
GetOwnershipTypeAsync
��2 G
(
��G H
)
��H I
)
��I J
;
��J K
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� *
)
��* +
]
��+ ,
private
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� '
<
��' ("
OwnershipTypeReadDto
��( <
>
��< =
>
��= >
GetOwnershipTypes
��? P
(
��P Q
string
��Q W
value
��X ]
)
��] ^
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
�� 1
.
��1 2#
GetOwnershipTypeAsync
��2 G
(
��G H
value
��H M
)
��M N
)
��N O
;
��O P
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '"
OwnershipTypeReadDto
��' ;
>
��; <
>
��< =
GetOwnershipType
��> N
(
��N O
int
��O R
ownershipTypeId
��S b
)
��b c
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
�� 1
.
��1 2#
GetOwnershipTypeAsync
��2 G
(
��G H
ownershipTypeId
��H W
)
��W X
)
��X Y
;
��Y Z
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
TitleReadDto
��' 3
>
��3 4
>
��4 5!
CreateOwnershipType
��6 I
(
��I J
[
��J K
FromBody
��K S
]
��S T$
OwnershipTypeCreateDto
��U k
values
��l r
)
��r s
{
�� 	
try
�� 
{
�� 
var
�� 
userId
�� 
=
�� !
_userContextService
�� 0
.
��0 1
	GetUserId
��1 :
(
��: ;
)
��; <
;
��< =
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� "
(
��" #
userId
��# )
,
��) *
values
��+ 1
.
��1 2
	createdby
��2 ;
)
��; <
)
��< =
{
�� 
return
�� 
Unauthorized
�� '
(
��' (
)
��( )
;
��) *
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
��  5
.
��5 6#
AddOwnershipTypeAsync
��6 K
(
��K L
values
��L R
)
��R S
)
��S T
;
��T U
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� $
)
��$ %
]
��% &
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '"
OwnershipTypeReadDto
��' ;
>
��; <
>
��< =!
UpdateOwnershipType
��> Q
(
��Q R
[
��R S
FromBody
��S [
]
��[ \$
OwnershipTypeUpdateDto
��] s
values
��t z
)
��z {
{
�� 	
var
�� 
userId
�� 
=
�� !
_userContextService
�� ,
.
��, -
	GetUserId
��- 6
(
��6 7
)
��7 8
;
��8 9
if
�� 
(
�� 
!
�� 
string
�� 
.
�� 
Equals
�� 
(
�� 
userId
�� %
,
��% &
values
��' -
.
��- .

modifiedby
��. 8
)
��8 9
)
��9 :
{
�� 
return
�� 
Unauthorized
�� #
(
��# $
)
��$ %
;
��% &
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
�� 1
.
��1 2&
UpdateOwnershipTypeAsync
��2 J
(
��J K
values
��K Q
)
��Q R
)
��R S
;
��S T
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� ;
)
��; <
]
��< =
[
�� 	
	Authorize
��	 
(
�� 
Policy
�� 
=
�� 
$str
�� 9
)
��9 :
]
��: ;
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
>
��& '!
DeleteOwnershipType
��( ;
(
��; <
int
��< ?
ownershipTypeId
��@ O
)
��O P
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� #
_ownershipTypeService
�� 1
.
��1 2&
DeleteOwnershipTypeAsync
��2 J
(
��J K
ownershipTypeId
��K Z
)
��Z [
)
��[ \
;
��\ ]
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
��  
[
�� 	"
ProducesResponseType
��	 
(
�� 
typeof
�� $
(
��$ %
int
��% (
)
��( )
,
��) *
StatusCodes
��+ 6
.
��6 7
Status200OK
��7 B
)
��B C
]
��C D
public
�� 
IActionResult
�� 
MaritalStatus
�� *
(
��* +
)
��+ ,
{
�� 	
var
�� 
statuses
�� 
=
�� 
Enum
�� 
.
��  
	GetValues
��  )
(
��) *
typeof
��* 0
(
��0 1
MaritalStatusEnum
��1 B
)
��B C
)
��C D
.
��# $
Cast
��$ (
<
��( )
MaritalStatusEnum
��) :
>
��: ;
(
��; <
)
��< =
.
��# $
Select
��$ *
(
��* +
e
��+ ,
=>
��- /
new
��0 3
{
��# $
Id
��' )
=
��* +
(
��, -
int
��- 0
)
��0 1
e
��1 2
,
��2 3
Name
��' +
=
��, -
e
��. /
.
��/ 0
ToString
��0 8
(
��8 9
)
��9 :
,
��: ;
DisplayName
��' 2
=
��3 4
e
��5 6
.
��6 7
GetType
��7 >
(
��> ?
)
��? @
.
��5 6
GetField
��6 >
(
��> ?
e
��? @
.
��@ A
ToString
��A I
(
��I J
)
��J K
)
��K L
!
��L M
.
��6 7 
GetCustomAttribute
��7 I
<
��I J"
DescriptionAttribute
��J ^
>
��^ _
(
��_ `
)
��` a
?
��a b
.
��6 7
Description
��7 B
}
��# $
)
��$ %
;
��% &
return
�� 
Ok
�� 
(
�� 
statuses
�� 
)
�� 
;
��  
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
��  
)
��  !
]
��! "
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3
CustomerListDto
��3 B
>
��B C
>
��C D
>
��D E
GetCustomerList
��F U
(
��U V
)
��V W
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� $
_customerMasterService
�� 2
.
��2 3"
GetCustomerListAsync
��3 G
(
��G H
)
��H I
)
��I J
;
��J K
}
�� 	
}
�� 
}�� �
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