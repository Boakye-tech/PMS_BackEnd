h
f/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Usings.cs∫k
g/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
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
$strB `
)` a
;a b
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
} 
if 
( 
builder 
. 
Environment 
. 
IsProduction $
($ %
)% &
)& '
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var   #
solutionLevelConfigPath   
=    !
Path  " &
.  & '
Combine  ' .
(  . /
solutionDirectory  / @
,  @ A
$str  B T
)  T U
;  U V
if"" 
("" 
File"" 
."" 
Exists"" 
("" #
solutionLevelConfigPath"" +
)""+ ,
)"", -
{## 
builder$$ 
.$$ 
Configuration$$ 
.$$ 
AddJsonFile$$ )
($$) *#
solutionLevelConfigPath$$* A
,$$A B
optional$$C K
:$$K L
false$$M R
,$$R S
reloadOnChange$$T b
:$$b c
true$$d h
)$$h i
;$$i j
}%% 
}&& 
builder)) 
.)) 
Host)) 
.)) 

UseSerilog)) 
()) 
()) 
context))  
,))  !
configuration))" /
)))/ 0
=>))1 3
configuration))4 A
.))A B
ReadFrom))B J
.))J K
Configuration))K X
())X Y
context))Y `
.))` a
Configuration))a n
)))n o
)))o p
;))p q
if-- 
(-- 
builder-- 
.-- 
Environment-- 
.-- 
IsDevelopment-- %
(--% &
)--& '
)--' (
{.. 
switch// 

(// 
builder// 
.// 
Configuration// !
.//! "

GetSection//" ,
(//, -
$str//- 7
)//7 8
.//8 9

GetSection//9 C
(//C D
$str//D V
)//V W
.//W X
Value//X ]
)//] ^
{00 
case11 
$str11 
:11 
break33 
;33 
case55 
$str55 
:55 
builder66 
.66 
Services66 
.66 
AddDbContext66 )
<66) *
UserDbContext66* 7
>667 8
(668 9
options669 @
=>66A C
options66D K
.66K L
UseSqlServer66L X
(66X Y
builder66Y `
.66` a
Configuration66a n
.66n o 
GetConnectionString	66o Ç
(
66Ç É
$str
66É î
)
66î ï
)
66ï ñ
.
66ñ ó"
EnableDetailedErrors
66ó ´
(
66´ ¨
)
66¨ ≠
.
66≠ Æ(
EnableSensitiveDataLogging
66Æ »
(
66» …
)
66…  
)
66  À
;
66À Ã
break77 
;77 
}88 
}:: 
if<< 
(<< 
builder<< 
.<< 
Environment<< 
.<< 
IsProduction<< $
(<<$ %
)<<% &
)<<& '
{== 
switch>> 

(>> 
builder>> 
.>> 
Configuration>> !
.>>! "

GetSection>>" ,
(>>, -
$str>>- 7
)>>7 8
.>>8 9

GetSection>>9 C
(>>C D
$str>>D V
)>>V W
.>>W X
Value>>X ]
)>>] ^
{?? 
case@@ 
$str@@ 
:@@ 
breakBB 
;BB 
caseCC 
$strCC 
:CC 
builderDD 
.DD 
ServicesDD 
.DD 
AddDbContextDD )
<DD) *
UserDbContextDD* 7
>DD7 8
(DD8 9
optionsDD9 @
=>DDA C
optionsDDD K
.DDK L
UseSqlServerDDL X
(DDX Y
builderDDY `
.DD` a
ConfigurationDDa n
.DDn o 
GetConnectionString	DDo Ç
(
DDÇ É
$str
DDÉ î
)
DDî ï
)
DDï ñ
)
DDñ ó
;
DDó ò
breakEE 
;EE 
}FF 
}GG 
builderII 
.II 
ServicesII 
.II 
AddCorsII 
(II 
oII 
=>II 
{JJ 
oKK 
.KK 
AddDefaultPolicyKK 
(KK 
builderLL 
=>LL 
{MM 	
builderNN 
.NN 
AllowAnyOriginNN "
(NN" #
)NN# $
.OO 
AllowAnyHeaderOO "
(OO" #
)OO# $
.PP 
AllowAnyMethodPP "
(PP" #
)PP# $
;PP$ %
}RR 	
)RR	 

;RR
 
}SS 
)SS 
;SS 
builderVV 
.VV 
ServicesVV 
.VV 
AddUserModuleVV 
(VV 
builderVV &
.VV& '
ConfigurationVV' 4
)VV4 5
;VV5 6
builderXX 
.XX 
ServicesXX 
.XX 
AddControllersXX 
(XX  
)XX  !
;XX! "
builderZZ 
.ZZ 
ServicesZZ 
.[[ 
AddApiVersioning[[ 
([[ 
options[[ 
=>[[  
{\\ 
options]] 
.]] 
DefaultApiVersion]] !
=]]" #
new]]$ '

ApiVersion]]( 2
(]]2 3
$num]]3 4
,]]4 5
$num]]6 7
)]]7 8
;]]8 9
options^^ 
.^^ /
#AssumeDefaultVersionWhenUnspecified^^ 3
=^^4 5
true^^6 :
;^^: ;
options__ 
.__ 
ReportApiVersions__ !
=__" #
true__$ (
;__( )
}`` 
)`` 
.aa 
AddApiExploreraa 
(aa 
optionsaa 
=>aa 
{bb 
optionscc 
.cc 
GroupNameFormatcc 
=cc  !
$strcc" *
;cc* +
optionsdd 
.dd %
SubstituteApiVersionInUrldd )
=dd* +
truedd, 0
;dd0 1
}ee 
)ee 
;ee 
builderhh 
.hh 
Serviceshh 
.hh #
AddEndpointsApiExplorerhh (
(hh( )
)hh) *
;hh* +
builderii 
.ii 
Servicesii 
.ii 
AddTransientii 
<ii 
IConfigureOptionsii /
<ii/ 0
SwaggerGenOptionsii0 A
>iiA B
,iiB C#
SwaggerConfigureOptionsiiD [
>ii[ \
(ii\ ]
)ii] ^
;ii^ _
builderjj 
.jj 
Servicesjj 
.jj 
AddSwaggerGenjj 
(jj 
optionsjj &
=>jj' )
{kk 
optionsll 
.ll 
OperationFilterll 
<ll  
SwaggerDefaultValuesll 0
>ll0 1
(ll1 2
)ll2 3
;ll3 4
optionsmm 
.mm 
IncludeXmlCommentsmm 
(mm 
Pathmm #
.mm# $
Combinemm$ +
(mm+ ,

AppContextmm, 6
.mm6 7
BaseDirectorymm7 D
,mmD E
$"mmF H
{mmH I
AssemblymmI Q
.mmQ R 
GetExecutingAssemblymmR f
(mmf g
)mmg h
.mmh i
GetNamemmi p
(mmp q
)mmq r
.mmr s
Namemms w
}mmw x
$strmmx |
"mm| }
)mm} ~
)mm~ 
;	mm Ä
}oo 
)oo 
;oo 
varuu 
appuu 
=uu 	
builderuu
 
.uu 
Builduu 
(uu 
)uu 
;uu #
UserAndRolesConfigurationww 
.ww 
SeedUserAndRolesww *
(ww* +
appww+ .
.ww. /
Servicesww/ 7
)ww7 8
.ww8 9
Waitww9 =
(ww= >
)ww> ?
;ww? @
ifzz 
(zz 
appzz 
.zz 
Environmentzz 
.zz 
IsDevelopmentzz !
(zz! "
)zz" #
)zz# $
{{{ 
app|| 
.|| 

UseSwagger|| 
(|| 
options|| 
=>|| 
{}} 
options~~ 
.~~ 
PreSerializeFilters~~ #
.~~# $
Add~~$ '
(~~' (
(~~( )
swagger~~) 0
,~~0 1
req~~2 5
)~~5 6
=>~~7 9
{ 	
swagger
ÄÄ 
.
ÄÄ 
Servers
ÄÄ 
=
ÄÄ 
new
ÄÄ !
List
ÄÄ" &
<
ÄÄ& '
OpenApiServer
ÄÄ' 4
>
ÄÄ4 5
(
ÄÄ5 6
)
ÄÄ6 7
{
ÄÄ8 9
new
ÄÄ: =
OpenApiServer
ÄÄ> K
(
ÄÄK L
)
ÄÄL M
{
ÄÄN O
Url
ÄÄP S
=
ÄÄT U
$"
ÄÄV X
$str
ÄÄX `
{
ÄÄ` a
req
ÄÄa d
.
ÄÄd e
Host
ÄÄe i
}
ÄÄi j
"
ÄÄj k
}
ÄÄl m
}
ÄÄn o
;
ÄÄo p
}
ÅÅ 	
)
ÅÅ	 

;
ÅÅ
 
}
ÇÇ 
)
ÇÇ 
;
ÇÇ 
app
ÖÖ 
.
ÖÖ 
UseSwaggerUI
ÖÖ 
(
ÖÖ 
options
ÖÖ 
=>
ÖÖ 
{
ÜÜ 
var
áá $
ApiVersionDescriptions
áá "
=
áá# $
app
áá% (
.
áá( )!
DescribeApiVersions
áá) <
(
áá< =
)
áá= >
;
áá> ?
foreach
ââ 
(
ââ 
var
ââ 
desc
ââ 
in
ââ $
ApiVersionDescriptions
ââ 3
)
ââ3 4
{
ää 	
options
ãã 
.
ãã 
SwaggerEndpoint
ãã #
(
ãã# $
$"
ãã$ &
$str
ãã& 1
{
ãã1 2
desc
ãã2 6
.
ãã6 7
	GroupName
ãã7 @
}
ãã@ A
$str
ããA N
"
ããN O
,
ããO P
$"
ããQ S
$str
ããS d
{
ããd e
desc
ããe i
.
ããi j

ApiVersion
ããj t
.
ããt u
ToString
ããu }
(
ãã} ~
)
ãã~ 
}ãã Ä
"ããÄ Å
)ããÅ Ç
;ããÇ É
options
åå 
.
åå &
DefaultModelsExpandDepth
åå ,
(
åå, -
-
åå- .
$num
åå. /
)
åå/ 0
;
åå0 1
options
çç 
.
çç 
DocExpansion
çç  
(
çç  !
Swashbuckle
çç! ,
.
çç, -

AspNetCore
çç- 7
.
çç7 8
	SwaggerUI
çç8 A
.
ççA B
DocExpansion
ççB N
.
ççN O
None
ççO S
)
ççS T
;
ççT U
}
éé 	
}
èè 
)
èè 
;
èè 
}êê 
appíí 
.
íí 
UseRateLimiter
íí 
(
íí 
)
íí 
;
íí 
appîî 
.
îî !
UseHttpsRedirection
îî 
(
îî 
)
îî 
;
îî 
appïï 
.
ïï 
UseAuthentication
ïï 
(
ïï 
)
ïï 
;
ïï 
appññ 
.
ññ 
UseAuthorization
ññ 
(
ññ 
)
ññ 
;
ññ 
appòò 
.
òò 
UseCors
òò 
(
òò 
)
òò 
;
òò 
appöö 
.
öö 
MapControllers
öö 
(
öö 
)
öö 
;
öö 
appúú 
.
úú 
Run
úú 
(
úú 
)
úú 	
;
úú	 
◊%
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
OpenAPI% ,
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
}88 ü
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
Users		 
.		 
Presentation		 $
.		$ %
OpenAPI		% ,
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
$str B
,B C
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
}22 âK
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/ModuleExtensions.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
{ 
public 
static 
class 
ModuleExtensions %
{ 
public 
static 
IServiceCollection (
AddUserModule) 6
(6 7
this7 ;
IServiceCollection< N
servicesO W
,W X
IConfigurationY g
configurationh u
)u v
{ 	
services 
. !
AddUserInfrastructure &
(& '
configuration' 4
)4 5
;5 6
services 
. 
AddIdentity  
<  !#
ApplicationIdentityUser! 8
,8 9#
ApplicationIdentityRole: Q
>Q R
(R S
optionsS Z
=>[ ]
{ 
options 
. 
SignIn 
. #
RequireConfirmedAccount 6
=7 8
true9 =
;= >
options 
. 
Password  
.  !
RequiredLength! /
=0 1
$num2 3
;3 4
options 
. 
Password  
.  !"
RequireNonAlphanumeric! 7
=8 9
true: >
;> ?
options 
. 
Password  
.  !
RequireUppercase! 1
=2 3
true4 8
;8 9
options 
. 
Password  
.  !
RequireDigit! -
=. /
true0 4
;4 5
options 
. 
Password  
.  !
RequireLowercase! 1
=2 3
true4 8
;8 9
options   
.   
Password    
.    !
RequiredUniqueChars  ! 4
=  5 6
$num  7 8
;  8 9
options## 
.## 
Lockout## 
.##  "
DefaultLockoutTimeSpan##  6
=##7 8
TimeSpan##9 A
.##A B
FromMinutes##B M
(##M N
$num##N O
)##O P
;##P Q
options$$ 
.$$ 
Lockout$$ 
.$$  #
MaxFailedAccessAttempts$$  7
=$$8 9
$num$$: ;
;$$; <
options%% 
.%% 
Lockout%% 
.%%  
AllowedForNewUsers%%  2
=%%3 4
true%%5 9
;%%9 :
options(( 
.(( 
User(( 
.(( 
RequireUniqueEmail(( /
=((0 1
true((2 6
;((6 7
options)) 
.)) 
User)) 
.)) %
AllowedUserNameCharacters)) 6
=))7 8
$str))8 }
;))} ~
}** 
)** 
.** $
AddEntityFrameworkStores** '
<**' (
UserDbContext**( 5
>**5 6
(**6 7
)**7 8
.,, $
AddDefaultTokenProviders,, '
(,,' (
),,( )
;,,) *
servicesPP 
.PP 
AddHttpClientPP "
<PP" # 
TokenStoreRepositoryPP# 7
>PP7 8
(PP8 9
)PP9 :
;PP: ;
servicesQQ 
.QQ 
	AddScopedQQ 
<QQ 
ValidationServiceQQ 0
>QQ0 1
(QQ1 2
)QQ2 3
;QQ3 4
servicesSS 
.SS 
	AddScopedSS 
<SS 
IUnitOfWorkSS *
,SS* +

UnitOfWorkSS, 6
>SS6 7
(SS7 8
)SS8 9
;SS9 :
servicesTT 
.TT 
	AddScopedTT 
<TT 
IChannelServiceTT .
,TT. /
ChannelServiceTT0 >
>TT> ?
(TT? @
)TT@ A
;TTA B
servicesUU 
.UU 
	AddScopedUU 
<UU 
IDepartmentServiceUU 1
,UU1 2
DepartmentServiceUU3 D
>UUD E
(UUE F
)UUF G
;UUG H
servicesVV 
.VV 
	AddScopedVV 
<VV "
IDepartmentUnitServiceVV 5
,VV5 6!
DepartmentUnitServiceVV7 L
>VVL M
(VVM N
)VVN O
;VVO P
servicesWW 
.WW 
	AddScopedWW 
<WW "
IAdministrationServiceWW 5
,WW5 6!
AdministrationServiceWW7 L
>WWL M
(WWM N
)WWN O
;WWO P
servicesXX 
.XX 
	AddScopedXX 
<XX  
IUserAccountsServiceXX 3
,XX3 4
UserAccountsServiceXX5 H
>XXH I
(XXI J
)XXJ K
;XXK L
servicesYY 
.YY 
	AddScopedYY 
<YY 
IMenuServiceYY +
,YY+ ,
MenuServiceYY- 8
>YY8 9
(YY9 :
)YY: ;
;YY; <
servicesZZ 
.ZZ 
	AddScopedZZ 
<ZZ !
ITokenStoreRepositoryZZ 4
,ZZ4 5 
TokenStoreRepositoryZZ6 J
>ZZJ K
(ZZK L
)ZZL M
;ZZM N
services\\ 
.\\ 
	AddScoped\\ 
<\\ &
IIdentificationTypeService\\ 9
,\\9 :%
IdentificationTypeService\\; T
>\\T U
(\\U V
)\\V W
;\\W X
servicesaa 
.aa 
AddExceptionHandleraa (
<aa( )%
HttpGlobalExceptionFilteraa) B
>aaB C
(aaC D
)aaD E
;aaE F
servicesbb 
.bb 
AddProblemDetailsbb &
(bb& '
)bb' (
;bb( )
servicesdd 
.dd -
!AddFluentValidationAutoValidationdd 6
(dd6 7
)dd7 8
.dd8 9/
#AddValidatorsFromAssemblyContainingdd9 \
<dd\ ]-
!ChangePasswordRequestDtoValidatordd] ~
>dd~ 
(	dd Ä
)
ddÄ Å
;
ddÅ Ç
servicesgg 
.gg /
#AddValidatorsFromAssemblyContaininggg 8
<gg8 9"
DepartmentDtoValidatorgg9 O
>ggO P
(ggP Q
)ggQ R
;ggR S
serviceshh 
.hh /
#AddValidatorsFromAssemblyContaininghh 8
<hh8 9&
DepartmentUnitDtoValidatorhh9 S
>hhS T
(hhT U
)hhU V
;hhV W
servicesii 
.ii /
#AddValidatorsFromAssemblyContainingii 8
<ii8 9"
TokenStoreDtoValidatorii9 O
>iiO P
(iiP Q
)iiQ R
;iiR S
serviceskk 
.kk /
#AddValidatorsFromAssemblyContainingkk 8
<kk8 9
RolesDtoValidatorkk9 J
>kkJ K
(kkK L
)kkL M
;kkM N
servicesll 
.ll /
#AddValidatorsFromAssemblyContainingll 8
<ll8 9#
RolesUpdateDtoValidatorll9 P
>llP Q
(llQ R
)llR S
;llS T
servicesmm 
.mm /
#AddValidatorsFromAssemblyContainingmm 8
<mm8 9#
RolesDeleteDtoValidatormm9 P
>mmP Q
(mmQ R
)mmR S
;mmS T
servicesoo 
.oo /
#AddValidatorsFromAssemblyContainingoo 8
<oo8 9'
RoleMenuActionsDtoValidatoroo9 T
>ooT U
(ooU V
)ooV W
;ooW X
servicespp 
.pp /
#AddValidatorsFromAssemblyContainingpp 8
<pp8 9
MenusDtoValidatorpp9 J
>ppJ K
(ppK L
)ppL M
;ppM N
servicesqq 
.qq /
#AddValidatorsFromAssemblyContainingqq 8
<qq8 9 
SubMenusDtoValidatorqq9 M
>qqM N
(qqN O
)qqO P
;qqP Q
servicesrr 
.rr /
#AddValidatorsFromAssemblyContainingrr 8
<rr8 9$
SubMenuItemsDtoValidatorrr9 Q
>rrQ R
(rrR S
)rrS T
;rrT U
servicesss 
.ss /
#AddValidatorsFromAssemblyContainingss 8
<ss8 9*
ApproveUserAccountDtoValidatorss9 W
>ssW X
(ssX Y
)ssY Z
;ssZ [
servicesvv 
.vv 
AddRateLimitervv #
(vv# $
optionsvv$ +
=>vv, .
{ww 
optionsxx 
.xx !
AddFixedWindowLimiterxx -
(xx- .
$strxx. A
,xxA B
optxxC F
=>xxG I
{yy 
optzz 
.zz 
Windowzz 
=zz  
TimeSpanzz! )
.zz) *
FromMinuteszz* 5
(zz5 6
$numzz6 7
)zz7 8
;zz8 9
opt{{ 
.{{ 
PermitLimit{{ #
={{$ %
$num{{& '
;{{' (
opt|| 
.|| 

QueueLimit|| "
=||# $
$num||% &
;||& '
opt}} 
.}}  
QueueProcessingOrder}} ,
=}}- . 
QueueProcessingOrder}}/ C
.}}C D
OldestFirst}}D O
;}}O P
}~~ 
)~~ 
;~~ 
} 
) 
; 
services
ÇÇ 
.
ÇÇ 
AddAutoMapper
ÇÇ "
(
ÇÇ" #
	AppDomain
ÇÇ# ,
.
ÇÇ, -
CurrentDomain
ÇÇ- :
.
ÇÇ: ;
GetAssemblies
ÇÇ; H
(
ÇÇH I
)
ÇÇI J
)
ÇÇJ K
;
ÇÇK L
return
ÖÖ 
services
ÖÖ 
;
ÖÖ 
}
ÜÜ 	
}
áá 
}àà ñ
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Filters/HttpGlobalExceptionFilter.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Filters% ,
{ 
public 

class %
HttpGlobalExceptionFilter *
:+ ,
IExceptionHandler- >
{ 
public		 
readonly		 
ILogger		 
<		  %
HttpGlobalExceptionFilter		  9
>		9 :
_logger		; B
;		B C
public %
HttpGlobalExceptionFilter (
(( )
ILogger) 0
<0 1%
HttpGlobalExceptionFilter1 J
>J K
loggerL R
)R S
{ 	
_logger 
= 
logger 
; 
} 	
public 
async 
	ValueTask 
< 
bool #
># $
TryHandleAsync% 3
(3 4
HttpContext4 ?
httpContext@ K
,K L
	ExceptionM V
	exceptionW `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 	
_logger 
. 
LogError 
( 
	exception &
,& '
$str( G
,G H
	exceptionI R
.R S
MessageS Z
)Z [
;[ \
var 
problemDetails 
=  
new! $
ProblemDetails% 3
{ 
Status 
= 
StatusCodes $
.$ %(
Status500InternalServerError% A
,A B
Title 
= 
$str &
,& '
Detail 
= 
	exception "
." #
InnerException# 1
!1 2
.2 3
Message3 :
} 
; 
httpContext 
. 
Response  
.  !

StatusCode! +
=, -
problemDetails. <
.< =
Status= C
.C D
ValueD I
;I J
await 
httpContext 
. 
Response &
.& '
WriteAsJsonAsync' 7
(7 8
problemDetails8 F
,F G
cancellationTokenH Y
)Y Z
;Z [
return 
true 
; 
}!! 	
}"" 
}## ú°
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v2/AdministrationController.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Controllers% 0
.0 1
v21 3
{		 
[

 
ApiController

 
]

 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
public 

class $
AdministrationController )
:* +
ControllerBase, :
{ 
readonly "
IAdministrationService '
_adminService( 5
;5 6
readonly 
IMenuService 
_menuService *
;* +
public $
AdministrationController '
(' ("
IAdministrationService( >
adminService? K
,K L
IMenuServiceM Y
menuServiceZ e
)e f
{ 	
_adminService 
= 
adminService (
;( )
_menuService 
= 
menuService &
;& '
} 	
["" 	
HttpGet""	 
]"" 
[## 	
Route##	 
(## 
$str## 
)##  
]##  !
public$$ 
IEnumerable$$ 
<$$ 
MenuActionsDto$$ )
>$$) *
GetUserActions$$+ 9
($$9 :
)$$: ;
{%% 	
return&& 
_menuService&& 
.&&  

GetActions&&  *
(&&* +
)&&+ ,
;&&, -
}'' 	
[)) 	
HttpGet))	 
])) 
[** 	
Route**	 
(** 
$str** 
)** 
]** 
public++ 
async++ 
Task++ 
<++ 
IEnumerable++ %
<++% &
MenusDto++& .
>++. /
>++/ 0
GetMenus++1 9
(++9 :
)++: ;
{,, 	
return-- 
await-- 
_menuService-- %
.--% &
GetMenus--& .
(--. /
)--/ 0
;--0 1
}.. 	
[00 	
HttpPost00	 
]00 
[11 	
Route11	 
(11 
$str11 
)11 
]11 
public22 
async22 
Task22 
<22 
ActionResult22 &
>22& '
CreateMenus22( 3
(223 4
[224 5
FromBody225 =
]22= >
MenusDto22? G
values22H N
)22N O
{33 	
var44 
result44 
=44 
await44 
_menuService44 +
.44+ ,

CreateMenu44, 6
(446 7
values447 =
)44= >
;44> ?
return55 
Ok55 
(55 
result55 
)55 
;55 
}66 	
[88 	
HttpGet88	 
]88 
[99 	
Route99	 
(99 
$str99 
)99 
]99 
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &
SubMenusDto::& 1
>::1 2
>::2 3
GetSubMenus::4 ?
(::? @
)::@ A
{;; 	
return<< 
await<< 
_menuService<< %
.<<% &
GetSubMenus<<& 1
(<<1 2
)<<2 3
;<<3 4
}== 	
[?? 	
HttpPost??	 
]?? 
[@@ 	
Route@@	 
(@@ 
$str@@ 
)@@  
]@@  !
publicAA 
asyncAA 
TaskAA 
<AA 
ActionResultAA &
>AA& '
CreateSubMenusAA( 6
(AA6 7
[AA7 8
FromBodyAA8 @
]AA@ A
SubMenusCreateDtoAAB S
valuesAAT Z
)AAZ [
{BB 	
varCC 
resultCC 
=CC 
awaitCC 
_menuServiceCC +
.CC+ ,
CreateSubMenuCC, 9
(CC9 :
valuesCC: @
)CC@ A
;CCA B
returnDD 
OkDD 
(DD 
resultDD 
)DD 
;DD 
}EE 	
[PP 	
HttpGetPP	 
]PP 
[QQ 	
RouteQQ	 
(QQ 
$strQQ 
)QQ 
]QQ 
publicSS 
IEnumerableSS 
<SS 
RolesDtoSS #
>SS# $
GetUserRolesSS% 1
(SS1 2
)SS2 3
{TT 	
returnUU 
_adminServiceUU  
.UU  !
GetUserRolesUU! -
(UU- .
)UU. /
;UU/ 0
}VV 	
[XX 	
HttpPostXX	 
]XX 
[YY 	
RouteYY	 
(YY 
$strYY 
)YY  
]YY  !
publicZZ 
asyncZZ 
TaskZZ 
<ZZ 
ActionResultZZ &
>ZZ& '
CreateUserRoleZZ( 6
(ZZ6 7
[ZZ7 8
FromBodyZZ8 @
]ZZ@ A
RolesCreateDtoZZB P
valuesZZQ W
)ZZW X
{[[ 	
var\\ 
result\\ 
=\\ 
await\\ 
_adminService\\ ,
.\\, -
CreateUserRole\\- ;
(\\; <
values\\< B
)\\B C
;\\C D
if^^ 
(^^ 
result^^ 
.^^ 
	Succeeded^^  
)^^  !
{__ 
return`` 
Ok`` 
(`` 
result``  
.``  !
ToString``! )
(``) *
)``* +
)``+ ,
;``, -
}aa 
ifcc 
(cc 
!cc 
resultcc 
.cc 
	Succeededcc !
)cc! "
{dd 
returnee 

BadRequestee !
(ee! "
resultee" (
.ee( )
Errorsee) /
)ee/ 0
;ee0 1
}ff 
returnhh 

BadRequesthh 
(hh 
resulthh $
)hh$ %
;hh% &
}ii 	
[kk 	
HttpPutkk	 
]kk 
[ll 	
Routell	 
(ll 
$strll 
)ll  
]ll  !
publicmm 
asyncmm 
Taskmm 
<mm 
ActionResultmm &
>mm& '
UpdateUserRolemm( 6
(mm6 7
[mm7 8
FromBodymm8 @
]mm@ A
RolesUpdateDtommB P
valuesmmQ W
)mmW X
{nn 	
varoo 
resultoo 
=oo 
awaitoo 
_adminServiceoo ,
.oo, -
UpdateUserRoleoo- ;
(oo; <
valuesoo< B
)ooB C
;ooC D
ifqq 
(qq 
resultqq 
.qq 
	Succeededqq  
)qq  !
{rr 
returnss 
Okss 
(ss 
resultss  
.ss  !
ToStringss! )
(ss) *
)ss* +
)ss+ ,
;ss, -
}tt 
ifvv 
(vv 
!vv 
resultvv 
.vv 
	Succeededvv !
)vv! "
{ww 
returnxx 

BadRequestxx !
(xx! "
resultxx" (
.xx( )
Errorsxx) /
)xx/ 0
;xx0 1
}yy 
return{{ 

BadRequest{{ 
({{ 
result{{ $
){{$ %
;{{% &
}|| 	
[~~ 	

HttpDelete~~	 
]~~ 
[ 	
Route	 
( 
$str 
)  
]  !
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
>
ÄÄ& '
DeleteUserRole
ÄÄ( 6
(
ÄÄ6 7
[
ÄÄ7 8
FromBody
ÄÄ8 @
]
ÄÄ@ A
RolesDeleteDto
ÄÄB P
values
ÄÄQ W
)
ÄÄW X
{
ÅÅ 	
var
ÇÇ 
result
ÇÇ 
=
ÇÇ 
await
ÇÇ 
_adminService
ÇÇ ,
.
ÇÇ, -
DeleteUserRole
ÇÇ- ;
(
ÇÇ; <
values
ÇÇ< B
)
ÇÇB C
;
ÇÇC D
if
ÑÑ 
(
ÑÑ 
result
ÑÑ 
.
ÑÑ 
	Succeeded
ÑÑ  
)
ÑÑ  !
{
ÖÖ 
return
ÜÜ 
Ok
ÜÜ 
(
ÜÜ 
result
ÜÜ  
.
ÜÜ  !
ToString
ÜÜ! )
(
ÜÜ) *
)
ÜÜ* +
)
ÜÜ+ ,
;
ÜÜ, -
}
áá 
if
ââ 
(
ââ 
!
ââ 
result
ââ 
.
ââ 
	Succeeded
ââ !
)
ââ! "
{
ää 
return
ãã 

BadRequest
ãã !
(
ãã! "
result
ãã" (
.
ãã( )
Errors
ãã) /
)
ãã/ 0
;
ãã0 1
}
åå 
return
éé 

BadRequest
éé 
(
éé 
result
éé $
)
éé$ %
;
éé% &
}
èè 	
[
îî 	
HttpPost
îî	 
]
îî 
[
ïï 	
Route
ïï	 
(
ïï 
$str
ïï !
)
ïï! "
]
ïï" #
public
ññ 
async
ññ 
Task
ññ 
<
ññ 
ActionResult
ññ &
>
ññ& '
AssignRoleToUser
ññ( 8
(
ññ8 9
[
ññ9 :
FromBody
ññ: B
]
ññB C
AssignUserRoleDto
ññD U
values
ññV \
)
ññ\ ]
{
óó 	
var
òò 
result
òò 
=
òò 
await
òò 
_menuService
òò +
.
òò+ ,
AssignUserRole
òò, :
(
òò: ;
values
òò; A
)
òòA B
;
òòB C
if
öö 
(
öö 
result
öö 
is
öö 
null
öö 
)
öö 
{
õõ 
return
úú 

BadRequest
úú !
(
úú! "
$"
úú" $
$str
úú$ 2
{
úú2 3
values
úú3 9
.
úú9 :
EmailAddress
úú: F
}
úúF G
$str
úúG _
"
úú_ `
)
úú` a
;
úúa b
}
ùù 
if
üü 
(
üü 
result
üü 
!
üü 
.
üü 
	Succeeded
üü !
)
üü! "
{
†† 
return
°° 
Ok
°° 
(
°° 
result
°°  
)
°°  !
;
°°! "
}
¢¢ 
return
§§ 

BadRequest
§§ 
(
§§ 
result
§§ $
.
§§$ %
Errors
§§% +
)
§§+ ,
;
§§, -
}
¶¶ 	
[
©© 	
HttpPost
©©	 
]
©© 
[
™™ 	
Route
™™	 
(
™™ 
$str
™™ (
)
™™( )
]
™™) *
public
´´ 
async
´´ 
Task
´´ 
<
´´ 
ActionResult
´´ &
>
´´& '%
AssignPermissionsToRole
´´( ?
(
´´? @
[
´´@ A
FromBody
´´A I
]
´´I J)
PermissionsAccessModulesDto
´´K f
values
´´g m
)
´´m n
{
¨¨ 	
return
≠≠ 
Ok
≠≠ 
(
≠≠ 
await
≠≠ 
_menuService
≠≠ (
.
≠≠( )$
AssignPermissionToRole
≠≠) ?
(
≠≠? @
values
≠≠@ F
)
≠≠F G
)
≠≠G H
;
≠≠H I
}
ÆÆ 	
[
∞∞ 	
HttpGet
∞∞	 
]
∞∞ 
[
±± 	
Route
±±	 
(
±± 
$str
±± ,
)
±±, -
]
±±- .
public
≤≤ 
Task
≤≤ 
<
≤≤ 
IEnumerable
≤≤ 
<
≤≤  )
PermissionsAccessModulesDto
≤≤  ;
>
≤≤; <
>
≤≤< = 
GetUserPermissions
≤≤> P
(
≤≤P Q
string
≤≤Q W
userId
≤≤X ^
)
≤≤^ _
{
≥≥ 	
return
¥¥ 
null
¥¥ 
!
¥¥ 
;
¥¥ 
}
∂∂ 	
[
∏∏ 	
HttpGet
∏∏	 
]
∏∏ 
[
ππ 	
Route
ππ	 
(
ππ 
$str
ππ ,
)
ππ, -
]
ππ- .
public
∫∫ 
Task
∫∫ 
<
∫∫ 
IEnumerable
∫∫ 
<
∫∫  )
PermissionsAccessModulesDto
∫∫  ;
>
∫∫; <
>
∫∫< = 
GetRolePermissions
∫∫> P
(
∫∫P Q
string
∫∫Q W
roleId
∫∫X ^
)
∫∫^ _
{
ªª 	
return
ΩΩ 
null
ΩΩ 
!
ΩΩ 
;
ΩΩ 
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
>
¬¬& '
VerifyUserAccount
¬¬( 9
(
¬¬9 :
[
¬¬: ;
FromBody
¬¬; C
]
¬¬C D"
VerifyUserAccountDto
¬¬E Y
values
¬¬Z `
)
¬¬` a
{
√√ 	
var
ƒƒ 
result
ƒƒ 
=
ƒƒ 
await
ƒƒ 
_adminService
ƒƒ ,
.
ƒƒ, -#
VerifyCustomerAccount
ƒƒ- B
(
ƒƒB C
values
ƒƒC I
)
ƒƒI J
;
ƒƒJ K
if
∆∆ 
(
∆∆ 
result
∆∆ 
.
∆∆ 
	IsSuccess
∆∆ 
)
∆∆  
{
«« 
return
»» 
Ok
»» 
(
»» 
result
»»  
.
»»  !
SuccessResponse
»»! 0
)
»»0 1
;
»»1 2
}
…… 
return
ÀÀ 
Problem
ÀÀ 
(
ÀÀ 
result
ÀÀ !
.
ÀÀ! "
ErrorResponse
ÀÀ" /
?
ÀÀ/ 0
.
ÀÀ0 1
StatusMessage
ÀÀ1 >
??
ÀÀ? A
$str
ÀÀB a
)
ÀÀa b
;
ÀÀb c
}
ÃÃ 	
[
ŒŒ 	
HttpPut
ŒŒ	 
]
ŒŒ 
[
œœ 	
Route
œœ	 
(
œœ 
$str
œœ "
)
œœ" #
]
œœ# $
public
–– 
async
–– 
Task
–– 
<
–– 
ActionResult
–– &
>
––& '
RejectUserAccount
––( 9
(
––9 :
[
––: ;
FromBody
––; C
]
––C D"
RejectUserAccountDto
––E Y
values
––Z `
)
––` a
{
—— 	
var
““ 
result
““ 
=
““ 
await
““ 
_adminService
““ ,
.
““, -#
RejectCustomerAccount
““- B
(
““B C
values
““C I
)
““I J
;
““J K
if
‘‘ 
(
‘‘ 
result
‘‘ 
.
‘‘ 
	IsSuccess
‘‘  
)
‘‘  !
{
’’ 
return
÷÷ 
Ok
÷÷ 
(
÷÷ 
result
÷÷  
.
÷÷  !
SuccessResponse
÷÷! 0
)
÷÷0 1
;
÷÷1 2
}
◊◊ 
return
ŸŸ 
Problem
ŸŸ 
(
ŸŸ 
result
ŸŸ !
.
ŸŸ! "
ErrorResponse
ŸŸ" /
?
ŸŸ/ 0
.
ŸŸ0 1
StatusMessage
ŸŸ1 >
??
ŸŸ? A
$str
ŸŸB a
)
ŸŸa b
;
ŸŸb c
}
⁄⁄ 	
[
‹‹ 	
HttpPut
‹‹	 
]
‹‹ 
[
›› 	
Route
››	 
(
›› 
$str
›› #
)
››# $
]
››$ %
public
ﬁﬁ 
async
ﬁﬁ 
Task
ﬁﬁ 
<
ﬁﬁ 
ActionResult
ﬁﬁ &
>
ﬁﬁ& ' 
ApproveUserAccount
ﬁﬁ( :
(
ﬁﬁ: ;
[
ﬁﬁ; <
FromBody
ﬁﬁ< D
]
ﬁﬁD E#
ApproveUserAccountDto
ﬁﬁF [
values
ﬁﬁ\ b
)
ﬁﬁb c
{
ﬂﬂ 	
var
‡‡ 
result
‡‡ 
=
‡‡ 
await
‡‡ 
_adminService
‡‡ ,
.
‡‡, - 
ApproveUserAccount
‡‡- ?
(
‡‡? @
values
‡‡@ F
)
‡‡F G
;
‡‡G H
if
‚‚ 
(
‚‚ 
result
‚‚ 
.
‚‚ 
	IsSuccess
‚‚  
)
‚‚  !
{
„„ 
return
‰‰ 
Ok
‰‰ 
(
‰‰ 
result
‰‰  
.
‰‰  !
SuccessResponse
‰‰! 0
)
‰‰0 1
;
‰‰1 2
}
ÂÂ 
return
ÁÁ 
Problem
ÁÁ 
(
ÁÁ 
result
ÁÁ !
.
ÁÁ! "
ErrorResponse
ÁÁ" /
?
ÁÁ/ 0
.
ÁÁ0 1
StatusMessage
ÁÁ1 >
??
ÁÁ? A
$str
ÁÁB a
)
ÁÁa b
;
ÁÁb c
}
ËË 	
[
ÍÍ 	
HttpPut
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
ÎÎ &
)
ÎÎ& '
]
ÎÎ' (
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
>
ÏÏ& '#
DisapproveUserAccount
ÏÏ( =
(
ÏÏ= >
[
ÏÏ> ?
FromBody
ÏÏ? G
]
ÏÏG H'
DisapprovedUserAccountDto
ÏÏI b
values
ÏÏc i
)
ÏÏi j
{
ÌÌ 	
var
ÓÓ 
result
ÓÓ 
=
ÓÓ 
await
ÓÓ 
_adminService
ÓÓ ,
.
ÓÓ, -#
DisapproveUserAccount
ÓÓ- B
(
ÓÓB C
values
ÓÓC I
)
ÓÓI J
;
ÓÓJ K
if
 
(
 
result
 
.
 
	IsSuccess
  
)
  !
{
ÒÒ 
return
ÚÚ 
Ok
ÚÚ 
(
ÚÚ 
result
ÚÚ  
.
ÚÚ  !
SuccessResponse
ÚÚ! 0
)
ÚÚ0 1
;
ÚÚ1 2
}
ÛÛ 
return
ıı 
Problem
ıı 
(
ıı 
result
ıı !
.
ıı! "
ErrorResponse
ıı" /
?
ıı/ 0
.
ıı0 1
StatusMessage
ıı1 >
??
ıı? A
$str
ııB a
)
ııa b
;
ııb c
}
ˆˆ 	
[
¯¯ 	
HttpPut
¯¯	 
]
¯¯ 
[
˘˘ 	
Route
˘˘	 
(
˘˘ 
$str
˘˘ $
)
˘˘$ %
]
˘˘% &
public
˙˙ 
async
˙˙ 
Task
˙˙ 
<
˙˙ 
ActionResult
˙˙ &
>
˙˙& '!
ActivateUserAccount
˙˙( ;
(
˙˙; <
[
˙˙< =
FromBody
˙˙= E
]
˙˙E F$
ActivateUserAccountDto
˙˙G ]
values
˙˙^ d
)
˙˙d e
{
˚˚ 	
var
¸¸ 
result
¸¸ 
=
¸¸ 
await
¸¸ 
_adminService
¸¸ ,
.
¸¸, -!
ActivateUserAccount
¸¸- @
(
¸¸@ A
values
¸¸A G
)
¸¸G H
;
¸¸H I
if
˛˛ 
(
˛˛ 
result
˛˛ 
.
˛˛ 
	IsSuccess
˛˛  
)
˛˛  !
{
ˇˇ 
return
ÄÄ 
Ok
ÄÄ 
(
ÄÄ 
result
ÄÄ  
.
ÄÄ  !
SuccessResponse
ÄÄ! 0
)
ÄÄ0 1
;
ÄÄ1 2
}
ÅÅ 
return
ÉÉ 
Problem
ÉÉ 
(
ÉÉ 
result
ÉÉ !
.
ÉÉ! "
ErrorResponse
ÉÉ" /
?
ÉÉ/ 0
.
ÉÉ0 1
StatusMessage
ÉÉ1 >
??
ÉÉ? A
$str
ÉÉB a
)
ÉÉa b
;
ÉÉb c
}
ÑÑ 	
[
ÜÜ 	
HttpPut
ÜÜ	 
]
ÜÜ 
[
áá 	
Route
áá	 
(
áá 
$str
áá &
)
áá& '
]
áá' (
public
àà 
async
àà 
Task
àà 
<
àà 
ActionResult
àà &
>
àà& '"
DectivateUserAccount
àà( <
(
àà< =
[
àà= >
FromBody
àà> F
]
ààF G&
DeactivateUserAccountDto
ààH `
values
ààa g
)
ààg h
{
ââ 	
var
ää 
result
ää 
=
ää 
await
ää 
_adminService
ää ,
.
ää, -#
DeactivateUserAccount
ää- B
(
ääB C
values
ääC I
)
ääI J
;
ääJ K
if
åå 
(
åå 
result
åå 
.
åå 
	IsSuccess
åå  
)
åå  !
{
çç 
return
éé 
Ok
éé 
(
éé 
result
éé  
.
éé  !
SuccessResponse
éé! 0
)
éé0 1
;
éé1 2
}
èè 
return
ëë 
Problem
ëë 
(
ëë 
result
ëë !
.
ëë! "
ErrorResponse
ëë" /
?
ëë/ 0
.
ëë0 1
StatusMessage
ëë1 >
??
ëë? A
$str
ëëB a
)
ëëa b
;
ëëb c
}
íí 	
}
ïï 
}ññ Ïà
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v2/AccountController.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Controllers% 0
.0 1
v21 3
;3 4
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
public 
class 
AccountController 
:  
ControllerBase! /
{  
IUserAccountsService  
_userAccountsService -
;- .
IUnitOfWork 
_unitOfWork 
; 
public 

AccountController 
(  
IUserAccountsService 1
userAccountsService2 E
,E F
IUnitOfWorkG R

unitOfWorkS ]
)] ^
{  
_userAccountsService 
= 
userAccountsService 2
;2 3
_unitOfWork 
= 

unitOfWork  
;  !
} 
[!! 
HttpPost!! 
]!! 
["" 
Route"" 

(""
 
$str"" 
)"" 
]""  
public## 

async## 
Task## 
<## 
ActionResult## "
<##" # 
RegistrationResponse### 7
>##7 8
>##8 9
Register##: B
(##B C
[##C D
FromBody##D L
]##L M*
CustomerRegistrationRequestDto##N l
values##m s
)##s t
{$$ 
if%% 

(%% 

ModelState%% 
.%% 
IsValid%% 
)%% 
{&& 	
return'' 
Ok'' 
('' 
await''  
_userAccountsService'' 0
.''0 1$
CustomerUserRegistration''1 I
(''I J
values''J P
)''P Q
)''Q R
;''R S
}(( 	
return** 

BadRequest** 
(** 
)** 
;** 
},, 
[11 
HttpPost11 
]11 
[22 
AllowAnonymous22 
]22 
[33 
Route33 

(33
 
$str33 
)33 
]33 
public44 

async44 
Task44 
<44 
IActionResult44 #
>44# $
ChangePassword44% 3
(443 4
[444 5
FromBody445 =
]44= >$
ChangePasswordRequestDto44? W%
changeUserPasswordRequest44X q
)44q r
{55 
try66 
{77 	
if88 
(88 

ModelState88 
.88 
IsValid88 "
)88" #
{99 
var:: 
changeResult::  
=::! "
await::# ( 
_userAccountsService::) =
.::= >
ChangePassword::> L
(::L M%
changeUserPasswordRequest::M f
)::f g
;::g h
return;; 
Ok;; 
(;; 
changeResult;; &
);;& '
;;;' (
}<< 
return>> 

BadRequest>> 
(>> 
)>> 
;>>  
}?? 	
catch@@ 
(@@ 
	Exception@@ 
ex@@ 
)@@ 
{AA 	
returnBB 

StatusCodeBB 
(BB 
$numBB !
,BB! "
exBB# %
.BB% &
MessageBB& -
)BB- .
;BB. /
}CC 	
}DD 
[II 
HttpPostII 
]II 
[JJ 
AllowAnonymousJJ 
]JJ 
[KK 
RouteKK 

(KK
 
$strKK 
)KK 
]KK 
publicLL 

asyncLL 
TaskLL 
<LL 
IActionResultLL #
>LL# $
ResetPasswordLL% 2
(LL2 3
[LL3 4
FromBodyLL4 <
]LL< =#
ResetPasswordRequestDtoLL> U 
resetPasswordRequestLLV j
)LLj k
{MM 
tryNN 
{OO 	
varPP 

emailRegexPP 
=PP 
newPP  
RegexPP! &
(PP& '
$strPP' D
)PPD E
;PPE F
varQQ 

phoneRegexQQ 
=QQ 
newQQ  
RegexQQ! &
(QQ& '
$strQQ' 8
)QQ8 9
;QQ9 :
ifTT 
(TT 

ModelStateTT 
.TT 
IsValidTT "
)TT" #
{UU 
ifWW 
(WW 

emailRegexWW 
.WW 
IsMatchWW &
(WW& ' 
resetPasswordRequestWW' ;
.WW; <
Phone_OR_EmailWW< J
!WWJ K
)WWK L
)WWL M
{XX #
ResetPasswordRequestDtoYY +
passwordRequestYY, ;
=YY< =
newYY> A#
ResetPasswordRequestDtoYYB Y
{ZZ 
Phone_OR_Email[[ &
=[[' ( 
resetPasswordRequest[[) =
.[[= >
Phone_OR_Email[[> L
,[[L M
Token\\ 
=\\  
resetPasswordRequest\\  4
.\\4 5
Token\\5 :
,\\: ;
NewPassword]] #
=]]$ % 
resetPasswordRequest]]& :
.]]: ;
NewPassword]]; F
,]]F G
ConfirmNewPassword^^ *
=^^+ , 
resetPasswordRequest^^- A
.^^A B
ConfirmNewPassword^^B T
}__ 
;__ 
varaa 
changeResultaa $
=aa% &
awaitaa' , 
_userAccountsServiceaa- A
.aaA B(
ResetPasswordViaEmailAddressaaB ^
(aa^ _
passwordRequestaa_ n
)aan o
;aao p
returnbb 
Okbb 
(bb 
changeResultbb *
)bb* +
;bb+ ,
}dd 
ifgg 
(gg 

phoneRegexgg 
.gg 
IsMatchgg &
(gg& ' 
resetPasswordRequestgg' ;
.gg; <
Phone_OR_Emailgg< J
!ggJ K
)ggK L
)ggL M
{hh #
ResetPasswordRequestDtoii +
passwordRequestii, ;
=ii< =
newii> A#
ResetPasswordRequestDtoiiB Y
{jj 
Phone_OR_Emailkk &
=kk' ( 
resetPasswordRequestkk) =
.kk= >
Phone_OR_Emailkk> L
,kkL M
Tokenll 
=ll  
resetPasswordRequestll  4
.ll4 5
Tokenll5 :
,ll: ;
NewPasswordmm #
=mm$ % 
resetPasswordRequestmm& :
.mm: ;
NewPasswordmm; F
,mmF G
ConfirmNewPasswordnn *
=nn+ , 
resetPasswordRequestnn- A
.nnA B
ConfirmNewPasswordnnB T
}oo 
;oo 
varqq 
changeResultqq $
=qq% &
awaitqq' , 
_userAccountsServiceqq- A
.qqA B-
!ResetPasswordViaMobilePhoneNumberqqB c
(qqc d
passwordRequestqqd s
)qqs t
;qqt u
returnrr 
Okrr 
(rr 
changeResultrr *
)rr* +
;rr+ ,
}tt 
}vv 
returnxx 

BadRequestxx 
(xx 
)xx 
;xx  
}yy 	
catchzz 
(zz 
	Exceptionzz 
exzz 
)zz 
{{{ 	
return|| 

StatusCode|| 
(|| 
$num|| !
,||! "
ex||# %
.||% &
Message||& -
)||- .
;||. /
}}} 	
}~~ 
[
ÉÉ 
HttpPost
ÉÉ 
]
ÉÉ 
[
ÑÑ 
AllowAnonymous
ÑÑ 
]
ÑÑ 
[
ÖÖ 
Route
ÖÖ 

(
ÖÖ
 
$str
ÖÖ 
)
ÖÖ 
]
ÖÖ 
[
ÜÜ "
ProducesResponseType
ÜÜ 
(
ÜÜ 
$num
ÜÜ 
,
ÜÜ 
Type
ÜÜ #
=
ÜÜ$ %
typeof
ÜÜ& ,
(
ÜÜ, -
LoginResponseDto
ÜÜ- =
)
ÜÜ= >
)
ÜÜ> ?
]
ÜÜ? @
public
áá 

async
áá 
Task
áá 
<
áá 
IActionResult
áá #
>
áá# $
	UserLogin
áá% .
(
áá. /
[
áá/ 0
FromBody
áá0 8
]
áá8 9
LoginRequestDto
áá: I

loginModel
ááJ T
)
ááT U
{
àà 
try
ââ 
{
ää 	
var
ãã 

emailRegex
ãã 
=
ãã 
new
ãã  
Regex
ãã! &
(
ãã& '
$str
ãã' D
)
ããD E
;
ããE F
var
åå 

phoneRegex
åå 
=
åå 
new
åå  
Regex
åå! &
(
åå& '
$str
åå' 8
)
åå8 9
;
åå9 :
if
éé 
(
éé 

ModelState
éé 
.
éé 
IsValid
éé "
)
éé" #
{
èè 
if
êê 
(
êê 

emailRegex
êê 
.
êê 
IsMatch
êê &
(
êê& '

loginModel
êê' 1
.
êê1 2
Phone_OR_Email
êê2 @
!
êê@ A
)
êêA B
)
êêB C
{
ëë 
LoginRequestDto
íí #
loginRequest
íí$ 0
=
íí1 2
new
íí3 6
LoginRequestDto
íí7 F
{
ìì 
Phone_OR_Email
îî &
=
îî' (

loginModel
îî) 3
.
îî3 4
Phone_OR_Email
îî4 B
,
îîB C
Password
ïï  
=
ïï! "

loginModel
ïï# -
.
ïï- .
Password
ïï. 6
}
ññ 
;
ññ 
var
òò 
result
òò 
=
òò  
await
òò! &"
_userAccountsService
òò' ;
.
òò; <#
LoginWithEmailAddress
òò< Q
(
òòQ R
loginRequest
òòR ^
)
òò^ _
;
òò_ `
switch
öö 
(
öö 
result
öö "
.
öö" #
LoginStatus
öö# .
)
öö. /
{
õõ 
case
úú 
true
úú !
:
úú! "
return
ùù "
Ok
ùù# %
(
ùù% &
result
ùù& ,
)
ùù, -
;
ùù- .
case
ûû 
false
ûû "
:
ûû" #
return
üü "
Ok
üü# %
(
üü% &
result
üü& ,
)
üü, -
;
üü- .
}
†† 
}
°° 
if
££ 
(
££ 

phoneRegex
££ 
.
££ 
IsMatch
££ &
(
££& '

loginModel
££' 1
.
££1 2
Phone_OR_Email
££2 @
!
££@ A
)
££A B
)
££B C
{
§§ 
LoginRequestDto
•• #
loginRequest
••$ 0
=
••1 2
new
••3 6
LoginRequestDto
••7 F
{
¶¶ 
Phone_OR_Email
ßß &
=
ßß' (

loginModel
ßß) 3
.
ßß3 4
Phone_OR_Email
ßß4 B
,
ßßB C
Password
®®  
=
®®! "

loginModel
®®# -
.
®®- .
Password
®®. 6
}
™™ 
;
™™ 
var
¨¨ 
result
¨¨ 
=
¨¨  
await
¨¨! &"
_userAccountsService
¨¨' ;
.
¨¨; <(
LoginWithMobilePhoneNumber
¨¨< V
(
¨¨V W
loginRequest
¨¨W c
)
¨¨c d
;
¨¨d e
switch
ÆÆ 
(
ÆÆ 
result
ÆÆ "
.
ÆÆ" #
LoginStatus
ÆÆ# .
)
ÆÆ. /
{
ØØ 
case
∞∞ 
true
∞∞ !
:
∞∞! "
return
±± "
Ok
±±# %
(
±±% &
result
±±& ,
)
±±, -
;
±±- .
case
≤≤ 
false
≤≤ "
:
≤≤" #
return
≥≥ "
Ok
≥≥# %
(
≥≥% &
result
≥≥& ,
)
≥≥, -
;
≥≥- .
}
¥¥ 
}
µµ 
}
∏∏ 
return
∫∫ 

BadRequest
∫∫ 
(
∫∫ 
)
∫∫ 
;
∫∫  
}
ªª 	
catch
ºº 
(
ºº 
	Exception
ºº 
ex
ºº 
)
ºº 
{
ΩΩ 	
return
ææ 

StatusCode
ææ 
(
ææ 
$num
ææ !
,
ææ! "
ex
ææ# %
.
ææ% &
Message
ææ& -
)
ææ- .
;
ææ. /
}
øø 	
}
¿¿ 
[
≈≈ 
HttpPost
≈≈ 
]
≈≈ 
[
∆∆ 
AllowAnonymous
∆∆ 
]
∆∆ 
[
«« 
Route
«« 

(
««
 
$str
«« 
)
«« 
]
«« 
[
»» "
ProducesResponseType
»» 
(
»» 
$num
»» 
,
»» 
Type
»» #
=
»»$ %
typeof
»»& ,
(
»», -%
RefreshTokenResponseDto
»»- D
)
»»D E
)
»»E F
]
»»F G
public
…… 

async
…… 
Task
…… 
<
…… 
IActionResult
…… #
>
……# $
RefreshToken
……% 1
(
……1 2
[
……2 3
FromBody
……3 ;
]
……; <$
RefreshTokenRequestDto
……= S
request
……T [
)
……[ \
{
   
try
ÀÀ 
{
ÃÃ 	
if
ŒŒ 
(
ŒŒ 

ModelState
ŒŒ 
.
ŒŒ 
IsValid
ŒŒ "
)
ŒŒ" #
{
œœ 
var
—— 
	newTokens
—— 
=
—— 
await
——  %"
_userAccountsService
——& :
.
——: ; 
RefreshBearerToken
——; M
(
——M N
request
——N U
)
——U V
;
——V W
return
““ 
Ok
““ 
(
““ 
	newTokens
““ #
)
““# $
;
““$ %
}
”” 
return
’’ 

BadRequest
’’ 
(
’’ 
)
’’ 
;
’’  
}
÷÷ 	
catch
◊◊ 
(
◊◊ 
	Exception
◊◊ 
ex
◊◊ 
)
◊◊ 
{
ÿÿ 	
return
ŸŸ 

StatusCode
ŸŸ 
(
ŸŸ 
$num
ŸŸ !
,
ŸŸ! "
ex
ŸŸ# %
.
ŸŸ% &
Message
ŸŸ& -
)
ŸŸ- .
;
ŸŸ. /
}
⁄⁄ 	
}
€€ 
[
‡‡ 
HttpPost
‡‡ 
]
‡‡ 
[
·· 
AllowAnonymous
·· 
]
·· 
[
‚‚ 
Route
‚‚ 

(
‚‚
 
$str
‚‚ 
)
‚‚ 
]
‚‚ 
public
‰‰ 

IActionResult
‰‰ 
SendSMSToken
‰‰ %
(
‰‰% &
[
‰‰& '
FromBody
‰‰' /
]
‰‰/ 0&
TokenRequestParameterDto
‰‰1 I
value
‰‰J O
)
‰‰O P
{
ÂÂ 
try
ÊÊ 
{
ÁÁ 	
if
ËË 
(
ËË 

ModelState
ËË 
.
ËË 
IsValid
ËË "
)
ËË" #
{
ÈÈ 
var
ÍÍ 
result
ÍÍ 
=
ÍÍ 
_unitOfWork
ÍÍ (
.
ÍÍ( )

TokenStore
ÍÍ) 3
.
ÍÍ3 4
GetToken
ÍÍ4 <
(
ÍÍ< =
value
ÍÍ= B
.
ÍÍB C
phone_OR_email
ÍÍC Q
!
ÍÍQ R
,
ÍÍR S
$num
ÍÍS T
)
ÍÍT U
;
ÍÍU V
return
ÎÎ 
Ok
ÎÎ 
(
ÎÎ 
result
ÎÎ  
)
ÎÎ  !
;
ÎÎ! "
}
ÏÏ 
return
ÓÓ 
NotFound
ÓÓ 
(
ÓÓ 
)
ÓÓ 
;
ÓÓ 
}
ÔÔ 	
catch
 
(
 
	Exception
 
ex
 
)
 
{
ÒÒ 	
return
ÚÚ 

StatusCode
ÚÚ 
(
ÚÚ 
$num
ÚÚ !
,
ÚÚ! "
ex
ÚÚ# %
.
ÚÚ% &
Message
ÚÚ& -
)
ÚÚ- .
;
ÚÚ. /
}
ÛÛ 	
}
ÙÙ 
[
˘˘ 
HttpPost
˘˘ 
]
˘˘ 
[
˙˙ 
AllowAnonymous
˙˙ 
]
˙˙ 
[
˚˚ 
Route
˚˚ 

(
˚˚
 
$str
˚˚ 
)
˚˚ 
]
˚˚ 
public
˝˝ 

IActionResult
˝˝ 
SendEmailToken
˝˝ '
(
˝˝' (
[
˝˝( )
FromBody
˝˝) 1
]
˝˝1 2&
TokenRequestParameterDto
˝˝3 K
value
˝˝L Q
)
˝˝Q R
{
˛˛ 
try
ˇˇ 
{
ÄÄ 	
if
ÅÅ 
(
ÅÅ 

ModelState
ÅÅ 
.
ÅÅ 
IsValid
ÅÅ "
)
ÅÅ" #
{
ÇÇ 
var
ÉÉ 
result
ÉÉ 
=
ÉÉ 
_unitOfWork
ÉÉ (
.
ÉÉ( )

TokenStore
ÉÉ) 3
.
ÉÉ3 4
GetToken
ÉÉ4 <
(
ÉÉ< =
value
ÉÉ= B
.
ÉÉB C
phone_OR_email
ÉÉC Q
!
ÉÉQ R
,
ÉÉR S
$num
ÉÉS T
)
ÉÉT U
;
ÉÉU V
return
ÑÑ 
Ok
ÑÑ 
(
ÑÑ 
result
ÑÑ  
)
ÑÑ  !
;
ÑÑ! "
}
ÖÖ 
return
áá 
NotFound
áá 
(
áá 
)
áá 
;
áá 
}
àà 	
catch
ââ 
(
ââ 
	Exception
ââ 
ex
ââ 
)
ââ 
{
ää 	
return
ãã 

StatusCode
ãã 
(
ãã 
$num
ãã !
,
ãã! "
ex
ãã# %
.
ãã% &
Message
ãã& -
)
ãã- .
;
ãã. /
}
åå 	
}
çç 
}ëë …ˆ
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v1/AdministrationController.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Controllers% 0
.0 1
v11 3
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
$str /
)/ 0
]0 1
public 

class $
AdministrationController )
:* +
ControllerBase, :
{ 
readonly "
IAdministrationService '
_adminService( 5
;5 6
readonly 
IMenuService 
_menuService *
;* +
readonly   
IDepartmentService   #
_departmentService  $ 6
;  6 7
readonly!! "
IDepartmentUnitService!! '"
_departmentUnitService!!( >
;!!> ?
readonly"" 
IChannelService""  
_channelService""! 0
;""0 1
readonly## &
IIdentificationTypeService## +&
_identificationTypeService##, F
;##F G
private$$ 
readonly$$ 
IUserContextService$$ ,
_userContextService$$- @
;$$@ A
public&& $
AdministrationController&& '
(&&' ("
IAdministrationService&&( >
adminService&&? K
,&&K L
IDepartmentService&&M _
departmentService&&` q
,&&q r#
IDepartmentUnitService	&&s â#
departmentUnitService
&&ä ü
,
&&ü †
IMenuService
&&° ≠
menuService
&&Æ π
,
&&π ∫
IChannelService
&&ª  
channelService
&&À Ÿ
,
&&Ÿ ⁄(
IIdentificationTypeService
&&€ ı'
identificationTypeService
&&ˆ è
,
&&è ê!
IUserContextService
&&ë § 
userContextService
&&• ∑
)
&&∑ ∏
{'' 	
_adminService(( 
=(( 
adminService(( (
;((( )
_menuService)) 
=)) 
menuService)) &
;))& '
_departmentService** 
=**  
departmentService**! 2
;**2 3"
_departmentUnitService++ "
=++# $!
departmentUnitService++% :
;++: ;
_channelService,, 
=,, 
channelService,, ,
;,,, -&
_identificationTypeService-- &
=--' (%
identificationTypeService--) B
;--B C
_userContextService.. 
=..  !
userContextService.." 4
;..4 5
}// 	
[55 	
HttpGet55	 
]55 
[66 	
Route66	 
(66 
$str66 
)66 
]66 
public77 
async77 
Task77 
<77 
ActionResult77 &
<77& '
IEnumerable77' 2
<772 3
ChannelReadDto773 A
>77A B
>77B C
>77C D
GetChannels77E P
(77P Q
)77Q R
{88 	
return99 
Ok99 
(99 
await99 
_channelService99 +
.99+ ,
GetChannelAsync99, ;
(99; <
)99< =
)99= >
;99> ?
}:: 	
[== 	
HttpPost==	 
]== 
[>> 	
Route>>	 
(>> 
$str>> 
)>> 
]>>  
[?? 	
	Authorize??	 
(?? 
Policy?? 
=?? 
$str?? 5
)??5 6
]??6 7
public@@ 
async@@ 
Task@@ 
<@@ 
ActionResult@@ &
<@@& '
ChannelReadDto@@' 5
>@@5 6
>@@6 7
CreateChannel@@8 E
(@@E F
[@@F G
FromBody@@G O
]@@O P
ChannelCreateDto@@Q a
values@@b h
)@@h i
{AA 	
tryBB 
{CC 
varDD 
userIdDD 
=DD 
_userContextServiceDD 0
.DD0 1
	GetUserIdDD1 :
(DD: ;
)DD; <
;DD< =
ifEE 
(EE 
!EE 
stringEE 
.EE 
EqualsEE "
(EE" #
userIdEE# )
,EE) *
valuesEE+ 1
.EE1 2
	CreatedByEE2 ;
)EE; <
)EE< =
{FF 
returnGG 
UnauthorizedGG '
(GG' (
)GG( )
;GG) *
}HH 
varJJ 
resultJJ 
=JJ 
awaitJJ "
_channelServiceJJ# 2
.JJ2 3
AddChannelAsyncJJ3 B
(JJB C
valuesJJC I
)JJI J
;JJJ K
ifKK 
(KK 
resultKK 
isKK 
nullKK "
)KK" #
{LL 
returnMM 

BadRequestMM %
(MM% &
resultMM& ,
)MM, -
;MM- .
}NN 
returnPP 

StatusCodePP !
(PP! "
StatusCodesPP" -
.PP- .
Status201CreatedPP. >
,PP> ?
resultPP@ F
)PPF G
;PPG H
}SS 
catchTT 
(TT 
	ExceptionTT 
exTT 
)TT  
{UU 
returnVV 

StatusCodeVV !
(VV! "
$numVV" %
,VV% &
exVV' )
.VV) *
InnerExceptionVV* 8
!VV8 9
.VV9 :
MessageVV: A
)VVA B
;VVB C
}WW 
}XX 	
[ZZ 	
HttpPutZZ	 
]ZZ 
[[[ 	
Route[[	 
([[ 
$str[[ 
)[[ 
][[  
[\\ 	
	Authorize\\	 
(\\ 
Policy\\ 
=\\ 
$str\\ 5
)\\5 6
]\\6 7
public]] 
async]] 
Task]] 
<]] 
ActionResult]] &
<]]& '
ChannelReadDto]]' 5
>]]5 6
>]]6 7
UpdateChannel]]8 E
(]]E F
[]]F G
FromBody]]G O
]]]O P
ChannelUpdateDto]]Q a
values]]b h
)]]h i
{^^ 	
var__ 
userId__ 
=__ 
_userContextService__ ,
.__, -
	GetUserId__- 6
(__6 7
)__7 8
;__8 9
if`` 
(`` 
!`` 
string`` 
.`` 
Equals`` 
(`` 
userId`` %
,``% &
values``' -
.``- .

ModifiedBy``. 8
)``8 9
)``9 :
{aa 
returnbb 
Unauthorizedbb #
(bb# $
)bb$ %
;bb% &
}cc 
varee 
resultee 
=ee 
awaitee 
_channelServiceee .
.ee. /
UpdateChannelAsyncee/ A
(eeA B
valueseeB H
)eeH I
;eeI J
ifff 
(ff 
resultff 
isff 
nullff 
)ff 
{gg 
returnhh 

BadRequesthh !
(hh! "
)hh" #
;hh# $
}ii 
returnkk 
Okkk 
(kk 
resultkk 
)kk 
;kk 
}ll 	
[nn 	

HttpDeletenn	 
(nn 
$strnn /
)nn/ 0
]nn0 1
publicoo 
asyncoo 
Taskoo 
<oo 
ActionResultoo &
>oo& '
DeleteChanneloo( 5
(oo5 6
intoo6 9
	channelIdoo: C
)ooC D
{pp 	
varss 
responsess 
=ss 
awaitss  
_channelServicess! 0
.ss0 1
DeleteChannelAsyncss1 C
(ssC D
	channelIdssD M
)ssM N
;ssN O
ifuu 
(uu 
responseuu 
==uu 
$struu %
)uu% &
{vv 
returnww 
Okww 
(ww 
awaitww 
_channelServiceww  /
.ww/ 0
DeleteChannelAsyncww0 B
(wwB C
	channelIdwwC L
)wwL M
)wwM N
;wwN O
}xx 
returnzz 

BadRequestzz 
(zz 
)zz 
;zz  
}{{ 	
[ 	
HttpGet	 
] 
[
ÄÄ 	
Route
ÄÄ	 
(
ÄÄ 
$str
ÄÄ 
)
ÄÄ  
]
ÄÄ  !
public
ÅÅ 
async
ÅÅ 
Task
ÅÅ 
<
ÅÅ 
AccessModulesDto
ÅÅ *
>
ÅÅ* +
GetAccessMenus
ÅÅ, :
(
ÅÅ: ;
)
ÅÅ; <
{
ÇÇ 	
return
ÉÉ 
await
ÉÉ 
_menuService
ÉÉ %
.
ÉÉ% &
GetAccessMenus
ÉÉ& 4
(
ÉÉ4 5
)
ÉÉ5 6
;
ÉÉ6 7
}
ÑÑ 	
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
áá 
)
áá  
]
áá  !
public
àà 
IEnumerable
àà 
<
àà 
MenuActionsDto
àà )
>
àà) *
GetUserActions
àà+ 9
(
àà9 :
)
àà: ;
{
ââ 	
return
ää 
_menuService
ää 
.
ää  

GetActions
ää  *
(
ää* +
)
ää+ ,
;
ää, -
}
ãã 	
[
çç 	
HttpGet
çç	 
]
çç 
[
éé 	
Route
éé	 
(
éé 
$str
éé 
)
éé 
]
éé 
public
èè 
async
èè 
Task
èè 
<
èè 
IEnumerable
èè %
<
èè% &
MenusDto
èè& .
>
èè. /
>
èè/ 0
GetMenus
èè1 9
(
èè9 :
)
èè: ;
{
êê 	
return
ëë 
await
ëë 
_menuService
ëë %
.
ëë% &
GetMenus
ëë& .
(
ëë. /
)
ëë/ 0
;
ëë0 1
}
íí 	
[
îî 	
HttpPost
îî	 
]
îî 
[
ïï 	
Route
ïï	 
(
ïï 
$str
ïï 
)
ïï 
]
ïï 
[
ññ 	
	Authorize
ññ	 
(
ññ 
Policy
ññ 
=
ññ 
$str
ññ 5
)
ññ5 6
]
ññ6 7
public
óó 
async
óó 
Task
óó 
<
óó 
ActionResult
óó &
>
óó& '
CreateMenus
óó( 3
(
óó3 4
[
óó4 5
FromBody
óó5 =
]
óó= >
MenusDto
óó? G
values
óóH N
)
óóN O
{
òò 	
var
ôô 
result
ôô 
=
ôô 
await
ôô 
_menuService
ôô +
.
ôô+ ,

CreateMenu
ôô, 6
(
ôô6 7
values
ôô7 =
)
ôô= >
;
ôô> ?
return
öö 
Ok
öö 
(
öö 
result
öö 
)
öö 
;
öö 
}
õõ 	
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
ûû 
)
ûû 
]
ûû 
public
üü 
async
üü 
Task
üü 
<
üü 
IEnumerable
üü %
<
üü% &
SubMenusDto
üü& 1
>
üü1 2
>
üü2 3
GetSubMenus
üü4 ?
(
üü? @
)
üü@ A
{
†† 	
return
°° 
await
°° 
_menuService
°° %
.
°°% &
GetSubMenus
°°& 1
(
°°1 2
)
°°2 3
;
°°3 4
}
¢¢ 	
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
•• 
)
••  
]
••  !
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
¶¶ 5
)
¶¶5 6
]
¶¶6 7
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
CreateSubMenus
ßß( 6
(
ßß6 7
[
ßß7 8
FromBody
ßß8 @
]
ßß@ A
SubMenusCreateDto
ßßB S
values
ßßT Z
)
ßßZ [
{
®® 	
var
©© 
result
©© 
=
©© 
await
©© 
_menuService
©© +
.
©©+ ,
CreateSubMenu
©©, 9
(
©©9 :
values
©©: @
)
©©@ A
;
©©A B
return
™™ 
Ok
™™ 
(
™™ 
result
™™ 
)
™™ 
;
™™ 
}
´´ 	
[
≠≠ 	
HttpGet
≠≠	 
]
≠≠ 
[
ÆÆ 	
Route
ÆÆ	 
(
ÆÆ 
$str
ÆÆ  
)
ÆÆ  !
]
ÆÆ! "
public
ØØ 
async
ØØ 
Task
ØØ 
<
ØØ 
IEnumerable
ØØ %
<
ØØ% &
SubMenuItemsDto
ØØ& 5
>
ØØ5 6
>
ØØ6 7
GetSubMenuItems
ØØ8 G
(
ØØG H
)
ØØH I
{
∞∞ 	
return
±± 
await
±± 
_menuService
±± %
.
±±% &
GetSubMenuItems
±±& 5
(
±±5 6
)
±±6 7
;
±±7 8
}
≤≤ 	
[
¥¥ 	
HttpGet
¥¥	 
]
¥¥ 
[
µµ 	
Route
µµ	 
(
µµ 
$str
µµ &
)
µµ& '
]
µµ' (
[
∂∂ 	
AllowAnonymous
∂∂	 
]
∂∂ 
public
∑∑ 
async
∑∑ 
Task
∑∑ 
<
∑∑ 
IEnumerable
∑∑ %
<
∑∑% &#
ApplicationModulesDto
∑∑& ;
>
∑∑; <
>
∑∑< =#
GetApplicationModules
∑∑> S
(
∑∑S T
)
∑∑T U
{
∏∏ 	
return
ππ 
await
ππ 
_menuService
ππ %
.
ππ% &

GetModules
ππ& 0
(
ππ0 1
)
ππ1 2
;
ππ2 3
}
∫∫ 	
[
ºº 	
HttpPost
ºº	 
]
ºº 
[
ΩΩ 	
Route
ΩΩ	 
(
ΩΩ 
$str
ΩΩ &
)
ΩΩ& '
]
ΩΩ' (
[
ææ 	
AllowAnonymous
ææ	 
]
ææ 
public
øø 
async
øø 
Task
øø 
<
øø 
ActionResult
øø &
>
øø& '#
AddApplicationModules
øø( =
(
øø= >
[
øø> ?
FromBody
øø? G
]
øøG H)
ApplicationModulesCreateDto
øøI d
values
øøe k
)
øøk l
{
¿¿ 	
return
¡¡ 
Ok
¡¡ 
(
¡¡ 
await
¡¡ 
_menuService
¡¡ (
.
¡¡( )

AddModules
¡¡) 3
(
¡¡3 4
values
¡¡4 :
)
¡¡: ;
)
¡¡; <
;
¡¡< =
}
¬¬ 	
[
ƒƒ 	
HttpPut
ƒƒ	 
]
ƒƒ 
[
≈≈ 	
Route
≈≈	 
(
≈≈ 
$str
≈≈ )
)
≈≈) *
]
≈≈* +
[
∆∆ 	
AllowAnonymous
∆∆	 
]
∆∆ 
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
>
««& '&
UpdateApplicationModules
««( @
(
««@ A
[
««A B
FromBody
««B J
]
««J K#
ApplicationModulesDto
««L a
values
««b h
)
««h i
{
»» 	
return
…… 
Ok
…… 
(
…… 
await
…… 
_menuService
…… (
.
……( )
UpdateModules
……) 6
(
……6 7
values
……7 =
)
……= >
)
……> ?
;
……? @
}
   	
[
ÕÕ 	
HttpPost
ÕÕ	 
]
ÕÕ 
[
ŒŒ 	
Route
ŒŒ	 
(
ŒŒ 
$str
ŒŒ '
)
ŒŒ' (
]
ŒŒ( )
[
œœ 	
AllowAnonymous
œœ	 
]
œœ 
public
–– 
async
–– 
Task
–– 
<
–– 
ActionResult
–– &
>
––& '$
AssignModulePermission
––( >
(
––> ?
[
––? @
FromBody
––@ H
]
––H I.
 ApplicationModulesPermissionsDto
––J j
values
––k q
)
––q r
{
—— 	
return
““ 
Ok
““ 
(
““ 
await
““ 
_menuService
““ (
.
““( )$
AssignModulePermission
““) ?
(
““? @
values
““@ F
)
““F G
)
““G H
;
““H I
}
”” 	
[
’’ 	
HttpGet
’’	 
]
’’ 
[
÷÷ 	
Route
÷÷	 
(
÷÷ 
$str
÷÷ 7
)
÷÷7 8
]
÷÷8 9
[
◊◊ 	
AllowAnonymous
◊◊	 
]
◊◊ 
public
ÿÿ 
async
ÿÿ 
Task
ÿÿ 
<
ÿÿ 
IEnumerable
ÿÿ %
<
ÿÿ% &'
RoleModulesPermissionsDto
ÿÿ& ?
>
ÿÿ? @
>
ÿÿ@ A.
 GetApplicationModulesPermissions
ÿÿB b
(
ÿÿb c
string
ÿÿc i
roleId
ÿÿj p
)
ÿÿp q
{
ŸŸ 	
return
⁄⁄ 
await
⁄⁄ 
_menuService
⁄⁄ %
.
⁄⁄% &#
GetModulesPermissions
⁄⁄& ;
(
⁄⁄; <
roleId
⁄⁄< B
)
⁄⁄B C
;
⁄⁄C D
}
€€ 	
[
›› 	
HttpPost
››	 
]
›› 
[
ﬁﬁ 	
Route
ﬁﬁ	 
(
ﬁﬁ 
$str
ﬁﬁ #
)
ﬁﬁ# $
]
ﬁﬁ$ %
[
ﬂﬂ 	
	Authorize
ﬂﬂ	 
(
ﬂﬂ 
Policy
ﬂﬂ 
=
ﬂﬂ 
$str
ﬂﬂ 5
)
ﬂﬂ5 6
]
ﬂﬂ6 7
public
‡‡ 
async
‡‡ 
Task
‡‡ 
<
‡‡ 
ActionResult
‡‡ &
>
‡‡& ' 
CreateSubMenuItems
‡‡( :
(
‡‡: ;
[
‡‡; <
FromBody
‡‡< D
]
‡‡D E#
SubMenuItemsCreateDto
‡‡F [
values
‡‡\ b
)
‡‡b c
{
·· 	
return
‚‚ 
Ok
‚‚ 
(
‚‚ 
await
‚‚ 
_menuService
‚‚ (
.
‚‚( ) 
CreateSubMenuItems
‚‚) ;
(
‚‚; <
values
‚‚< B
)
‚‚B C
)
‚‚C D
;
‚‚D E
}
„„ 	
[
ÈÈ 	
HttpPost
ÈÈ	 
]
ÈÈ 
[
ÍÍ 	
Route
ÍÍ	 
(
ÍÍ 
$str
ÍÍ 
)
ÍÍ 
]
ÍÍ 
[
ÎÎ 	
	Authorize
ÎÎ	 
(
ÎÎ 
Policy
ÎÎ 
=
ÎÎ 
$str
ÎÎ 6
,
ÎÎ6 7
Roles
ÎÎ8 =
=
ÎÎ> ?
$str
ÎÎ@ R
)
ÎÎR S
]
ÎÎS T
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
>
ÏÏ& '
ApproveRole
ÏÏ( 3
(
ÏÏ3 4
[
ÏÏ4 5
FromBody
ÏÏ5 =
]
ÏÏ= >
RolesApprovalDto
ÏÏ? O
values
ÏÏP V
)
ÏÏV W
{
ÌÌ 	
var
ÓÓ 
userId
ÓÓ 
=
ÓÓ !
_userContextService
ÓÓ ,
.
ÓÓ, -
	GetUserId
ÓÓ- 6
(
ÓÓ6 7
)
ÓÓ7 8
;
ÓÓ8 9
if
ÔÔ 
(
ÔÔ 
!
ÔÔ 
string
ÔÔ 
.
ÔÔ 
Equals
ÔÔ 
(
ÔÔ 
userId
ÔÔ %
,
ÔÔ% &
values
ÔÔ' -
.
ÔÔ- .

ApprovedBy
ÔÔ. 8
)
ÔÔ8 9
)
ÔÔ9 :
{
 
return
ÒÒ 
Unauthorized
ÒÒ #
(
ÒÒ# $
)
ÒÒ$ %
;
ÒÒ% &
}
ÚÚ 
return
ÛÛ 
Ok
ÛÛ 
(
ÛÛ 
await
ÛÛ 
_adminService
ÛÛ )
.
ÛÛ) *
ApproveUserRole
ÛÛ* 9
(
ÛÛ9 :
values
ÛÛ: @
)
ÛÛ@ A
)
ÛÛA B
;
ÛÛB C
}
ÙÙ 	
[
˘˘ 	
HttpPost
˘˘	 
]
˘˘ 
[
˙˙ 	
Route
˙˙	 
(
˙˙ 
$str
˙˙ 
)
˙˙  
]
˙˙  !
[
˚˚ 	
	Authorize
˚˚	 
(
˚˚ 
Policy
˚˚ 
=
˚˚ 
$str
˚˚ 9
,
˚˚9 :
Roles
˚˚; @
=
˚˚A B
$str
˚˚C U
)
˚˚U V
]
˚˚V W
public
¸¸ 
async
¸¸ 
Task
¸¸ 
<
¸¸ 
ActionResult
¸¸ &
>
¸¸& '
DisapproveRole
¸¸( 6
(
¸¸6 7
[
¸¸7 8
FromBody
¸¸8 @
]
¸¸@ A
RolesApprovalDto
¸¸B R
values
¸¸S Y
)
¸¸Y Z
{
˝˝ 	
var
˛˛ 
userId
˛˛ 
=
˛˛ !
_userContextService
˛˛ ,
.
˛˛, -
	GetUserId
˛˛- 6
(
˛˛6 7
)
˛˛7 8
;
˛˛8 9
if
ˇˇ 
(
ˇˇ 
!
ˇˇ 
string
ˇˇ 
.
ˇˇ 
Equals
ˇˇ 
(
ˇˇ 
userId
ˇˇ %
,
ˇˇ% &
values
ˇˇ' -
.
ˇˇ- .

ApprovedBy
ˇˇ. 8
)
ˇˇ8 9
)
ˇˇ9 :
{
ÄÄ 
return
ÅÅ 
Unauthorized
ÅÅ #
(
ÅÅ# $
)
ÅÅ$ %
;
ÅÅ% &
}
ÇÇ 
return
ÉÉ 
Ok
ÉÉ 
(
ÉÉ 
await
ÉÉ 
_adminService
ÉÉ )
.
ÉÉ) *
ApproveUserRole
ÉÉ* 9
(
ÉÉ9 :
values
ÉÉ: @
)
ÉÉ@ A
)
ÉÉA B
;
ÉÉB C
}
ÖÖ 	
[
ãã 	
HttpGet
ãã	 
]
ãã 
[
åå 	
Route
åå	 
(
åå 
$str
åå %
)
åå% &
]
åå& '
public
çç 
IEnumerable
çç 
<
çç 
RolesDto
çç #
>
çç# $"
GetApprovedUserRoles
çç% 9
(
çç9 :
)
çç: ;
{
éé 	
return
èè 
_adminService
èè  
.
èè  !"
GetApprovedUserRoles
èè! 5
(
èè5 6
)
èè6 7
;
èè7 8
}
êê 	
[
óó 	
HttpGet
óó	 
]
óó 
[
òò 	
Route
òò	 
(
òò 
$str
òò 
)
òò 
]
òò 
public
öö 
IEnumerable
öö 
<
öö 
RolesDto
öö #
>
öö# $
GetUserRoles
öö% 1
(
öö1 2
)
öö2 3
{
õõ 	
return
úú 
_adminService
úú  
.
úú  !
GetUserRoles
úú! -
(
úú- .
)
úú. /
;
úú/ 0
}
ùù 	
[
üü 	
HttpPost
üü	 
]
üü 
[
†† 	
Route
††	 
(
†† 
$str
†† 
)
††  
]
††  !
[
°° 	
	Authorize
°°	 
(
°° 
Policy
°° 
=
°° 
$str
°° 9
)
°°9 :
]
°°: ;
public
¢¢ 
async
¢¢ 
Task
¢¢ 
<
¢¢ 
ActionResult
¢¢ &
>
¢¢& '
CreateUserRole
¢¢( 6
(
¢¢6 7
[
¢¢7 8
FromBody
¢¢8 @
]
¢¢@ A
RolesCreateDto
¢¢B P
values
¢¢Q W
)
¢¢W X
{
££ 	
var
§§ 
userId
§§ 
=
§§ !
_userContextService
§§ ,
.
§§, -
	GetUserId
§§- 6
(
§§6 7
)
§§7 8
;
§§8 9
if
•• 
(
•• 
!
•• 
string
•• 
.
•• 
Equals
•• 
(
•• 
userId
•• %
,
••% &
values
••' -
.
••- .
	CreatedBy
••. 7
)
••7 8
)
••8 9
{
¶¶ 
return
ßß 
Unauthorized
ßß #
(
ßß# $
)
ßß$ %
;
ßß% &
}
®® 
var
™™ 
result
™™ 
=
™™ 
await
™™ 
_adminService
™™ ,
.
™™, -
CreateUserRole
™™- ;
(
™™; <
values
™™< B
)
™™B C
;
™™C D
if
¨¨ 
(
¨¨ 
result
¨¨ 
.
¨¨ 
	Succeeded
¨¨  
)
¨¨  !
{
≠≠ 
return
ÆÆ 
Ok
ÆÆ 
(
ÆÆ 
new
ÆÆ 
{
ÆÆ  
message
ÆÆ! (
=
ÆÆ) *
result
ÆÆ+ 1
.
ÆÆ1 2
ToString
ÆÆ2 :
(
ÆÆ: ;
)
ÆÆ; <
}
ÆÆ= >
)
ÆÆ> ?
;
ÆÆ? @
}
ØØ 
if
±± 
(
±± 
!
±± 
result
±± 
.
±± 
	Succeeded
±± !
)
±±! "
{
≤≤ 
return
≥≥ 

BadRequest
≥≥ !
(
≥≥! "
result
≥≥" (
.
≥≥( )
Errors
≥≥) /
)
≥≥/ 0
;
≥≥0 1
}
¥¥ 
return
∂∂ 

BadRequest
∂∂ 
(
∂∂ 
result
∂∂ $
)
∂∂$ %
;
∂∂% &
}
∑∑ 	
[
ππ 	
HttpPut
ππ	 
]
ππ 
[
∫∫ 	
Route
∫∫	 
(
∫∫ 
$str
∫∫ 
)
∫∫  
]
∫∫  !
[
ªª 	
	Authorize
ªª	 
(
ªª 
Policy
ªª 
=
ªª 
$str
ªª 5
)
ªª5 6
]
ªª6 7
public
ºº 
async
ºº 
Task
ºº 
<
ºº 
ActionResult
ºº &
>
ºº& '
UpdateUserRole
ºº( 6
(
ºº6 7
[
ºº7 8
FromBody
ºº8 @
]
ºº@ A
RolesUpdateDto
ººB P
values
ººQ W
)
ººW X
{
ΩΩ 	
var
ææ 
userId
ææ 
=
ææ !
_userContextService
ææ ,
.
ææ, -
	GetUserId
ææ- 6
(
ææ6 7
)
ææ7 8
;
ææ8 9
if
øø 
(
øø 
!
øø 
string
øø 
.
øø 
Equals
øø 
(
øø 
userId
øø %
,
øø% &
values
øø' -
.
øø- .

ModifiedBy
øø. 8
)
øø8 9
)
øø9 :
{
¿¿ 
return
¡¡ 
Unauthorized
¡¡ #
(
¡¡# $
)
¡¡$ %
;
¡¡% &
}
¬¬ 
var
ƒƒ 
result
ƒƒ 
=
ƒƒ 
await
ƒƒ 
_adminService
ƒƒ ,
.
ƒƒ, -
UpdateUserRole
ƒƒ- ;
(
ƒƒ; <
values
ƒƒ< B
)
ƒƒB C
;
ƒƒC D
if
∆∆ 
(
∆∆ 
result
∆∆ 
.
∆∆ 
	Succeeded
∆∆  
)
∆∆  !
{
«« 
return
»» 
Ok
»» 
(
»» 
new
»» 
{
»» 
message
»»  '
=
»»( )
result
»»* 0
.
»»0 1
ToString
»»1 9
(
»»9 :
)
»»: ;
}
»»< =
)
»»= >
;
»»> ?
}
…… 
if
ÀÀ 
(
ÀÀ 
!
ÀÀ 
result
ÀÀ 
.
ÀÀ 
	Succeeded
ÀÀ !
)
ÀÀ! "
{
ÃÃ 
return
ÕÕ 

BadRequest
ÕÕ !
(
ÕÕ! "
result
ÕÕ" (
.
ÕÕ( )
Errors
ÕÕ) /
)
ÕÕ/ 0
;
ÕÕ0 1
}
ŒŒ 
return
–– 

BadRequest
–– 
(
–– 
result
–– $
)
––$ %
;
––% &
}
—— 	
[
”” 	

HttpDelete
””	 
]
”” 
[
‘‘ 	
Route
‘‘	 
(
‘‘ 
$str
‘‘ (
)
‘‘( )
]
‘‘) *
[
’’ 	
	Authorize
’’	 
(
’’ 
Policy
’’ 
=
’’ 
$str
’’ 5
,
’’5 6
Roles
’’7 <
=
’’= >
$str
’’? Q
)
’’Q R
]
’’R S
public
÷÷ 
async
÷÷ 
Task
÷÷ 
<
÷÷ 
ActionResult
÷÷ &
>
÷÷& '
DeleteUserRole
÷÷( 6
(
÷÷6 7
string
÷÷7 =
roleId
÷÷> D
)
÷÷D E
{
◊◊ 	
var
ÿÿ 
userId
ÿÿ 
=
ÿÿ !
_userContextService
ÿÿ ,
.
ÿÿ, -
	GetUserId
ÿÿ- 6
(
ÿÿ6 7
)
ÿÿ7 8
;
ÿÿ8 9
RolesDeleteDto
ﬁﬁ 
values
ﬁﬁ !
=
ﬁﬁ" #
new
ﬁﬁ$ '
RolesDeleteDto
ﬁﬁ( 6
(
ﬁﬁ6 7
roleId
ﬁﬁ7 =
,
ﬁﬁ= >
userId
ﬁﬁ? E
!
ﬁﬁE F
)
ﬁﬁF G
;
ﬁﬁG H
var
‡‡ 
result
‡‡ 
=
‡‡ 
await
‡‡ 
_adminService
‡‡ ,
.
‡‡, -
DeleteUserRole
‡‡- ;
(
‡‡; <
values
‡‡< B
)
‡‡B C
;
‡‡C D
if
‚‚ 
(
‚‚ 
result
‚‚ 
.
‚‚ 
	Succeeded
‚‚  
)
‚‚  !
{
„„ 
return
‰‰ 
Ok
‰‰ 
(
‰‰ 
result
‰‰  
.
‰‰  !
ToString
‰‰! )
(
‰‰) *
)
‰‰* +
)
‰‰+ ,
;
‰‰, -
}
ÂÂ 
if
ÁÁ 
(
ÁÁ 
!
ÁÁ 
result
ÁÁ 
.
ÁÁ 
	Succeeded
ÁÁ !
)
ÁÁ! "
{
ËË 
return
ÈÈ 

BadRequest
ÈÈ !
(
ÈÈ! "
result
ÈÈ" (
.
ÈÈ( )
Errors
ÈÈ) /
)
ÈÈ/ 0
;
ÈÈ0 1
}
ÍÍ 
return
ÏÏ 

BadRequest
ÏÏ 
(
ÏÏ 
result
ÏÏ $
)
ÏÏ$ %
;
ÏÏ% &
}
ÌÌ 	
[
ÙÙ 	
HttpPost
ÙÙ	 
]
ÙÙ 
[
ıı 	
Route
ıı	 
(
ıı 
$str
ıı !
)
ıı! "
]
ıı" #
[
ˆˆ 	
	Authorize
ˆˆ	 
(
ˆˆ 
Policy
ˆˆ 
=
ˆˆ 
$str
ˆˆ 9
)
ˆˆ9 :
]
ˆˆ: ;
public
˜˜ 
async
˜˜ 
Task
˜˜ 
<
˜˜ 
ActionResult
˜˜ &
>
˜˜& '
AssignRoleToUser
˜˜( 8
(
˜˜8 9
[
˜˜9 :
FromBody
˜˜: B
]
˜˜B C
AssignUserRoleDto
˜˜D U
values
˜˜V \
)
˜˜\ ]
{
¯¯ 	
var
ˇˇ 
result
ˇˇ 
=
ˇˇ 
await
ˇˇ 
_menuService
ˇˇ +
.
ˇˇ+ ,
AssignUserRole
ˇˇ, :
(
ˇˇ: ;
values
ˇˇ; A
)
ˇˇA B
;
ˇˇB C
if
ÅÅ 
(
ÅÅ 
result
ÅÅ 
is
ÅÅ 
null
ÅÅ 
)
ÅÅ 
{
ÇÇ 
return
ÉÉ 

BadRequest
ÉÉ !
(
ÉÉ! "
$"
ÉÉ" $
$str
ÉÉ$ 2
{
ÉÉ2 3
values
ÉÉ3 9
.
ÉÉ9 :
EmailAddress
ÉÉ: F
}
ÉÉF G
$str
ÉÉG _
"
ÉÉ_ `
)
ÉÉ` a
;
ÉÉa b
}
ÑÑ 
if
ÜÜ 
(
ÜÜ 
result
ÜÜ 
!
ÜÜ 
.
ÜÜ 
	Succeeded
ÜÜ !
)
ÜÜ! "
{
áá 
return
àà 
Ok
àà 
(
àà 
result
àà  
)
àà  !
;
àà! "
}
ââ 
return
ãã 

BadRequest
ãã 
(
ãã 
result
ãã $
.
ãã$ %
Errors
ãã% +
)
ãã+ ,
;
ãã, -
}
çç 	
[
êê 	
HttpPost
êê	 
]
êê 
[
ëë 	
Route
ëë	 
(
ëë 
$str
ëë (
)
ëë( )
]
ëë) *
[
íí 	
	Authorize
íí	 
(
íí 
Policy
íí 
=
íí 
$str
íí 9
)
íí9 :
]
íí: ;
public
ìì 
async
ìì 
Task
ìì 
<
ìì 
ActionResult
ìì &
>
ìì& '%
AssignPermissionsToRole
ìì( ?
(
ìì? @
[
ìì@ A
FromBody
ììA I
]
ììI J)
PermissionsAccessModulesDto
ììK f
values
ììg m
)
ììm n
{
îî 	
return
ïï 
Ok
ïï 
(
ïï 
await
ïï 
_menuService
ïï (
.
ïï( )$
AssignPermissionToRole
ïï) ?
(
ïï? @
values
ïï@ F
)
ïïF G
)
ïïG H
;
ïïH I
}
ññ 	
[
òò 	
HttpGet
òò	 
]
òò 
[
ôô 	
Route
ôô	 
(
ôô 
$str
ôô ,
)
ôô, -
]
ôô- .
public
öö 
Task
öö 
<
öö 
IEnumerable
öö 
<
öö  -
PermissionsAccessModulesReadDto
öö  ?
>
öö? @
>
öö@ A 
GetUserPermissions
ööB T
(
ööT U
string
ööU [
userId
öö\ b
)
ööb c
{
õõ 	
return
úú 
null
úú 
!
úú 
;
úú 
}
ûû 	
[
†† 	
HttpGet
††	 
]
†† 
[
°° 	
Route
°°	 
(
°° 
$str
°° ,
)
°°, -
]
°°- .
public
¢¢ 
async
¢¢ 
Task
¢¢ 
<
¢¢ -
PermissionsAccessModulesReadDto
¢¢ 9
>
¢¢9 : 
GetRolePermissions
¢¢; M
(
¢¢M N
string
¢¢N T
roleId
¢¢U [
)
¢¢[ \
{
££ 	
return
§§ 
await
§§ 
_menuService
§§ %
.
§§% &!
GetRolesPermissions
§§& 9
(
§§9 :
roleId
§§: @
)
§§@ A
;
§§A B
}
•• 	
[
ßß 	
HttpPut
ßß	 
]
ßß 
[
®® 	
Route
®®	 
(
®® 
$str
®® 0
)
®®0 1
]
®®1 2
private
©© 
async
©© 
Task
©© 
<
©© 
ActionResult
©© '
>
©©' (-
UpdatePermissionsAssignedToRole
©©) H
(
©©H I
[
©©I J
FromBody
©©J R
]
©©R S-
PermissionsAccessModulesReadDto
©©T s
values
©©t z
)
©©z {
{
™™ 	
return
´´ 
Ok
´´ 
(
´´ 
await
´´ 
_menuService
´´ (
.
´´( )-
UpdatePermissionsAssignedToRole
´´) H
(
´´H I
values
´´I O
)
´´O P
)
´´P Q
;
´´Q R
}
¨¨ 	
[
ØØ 	
HttpPut
ØØ	 
]
ØØ 
[
∞∞ 	
Route
∞∞	 
(
∞∞ 
$str
∞∞ "
)
∞∞" #
]
∞∞# $
[
±± 	
	Authorize
±±	 
(
±± 
Policy
±± 
=
±± 
$str
±± 5
)
±±5 6
]
±±6 7
public
≤≤ 
async
≤≤ 
Task
≤≤ 
<
≤≤ 
ActionResult
≤≤ &
>
≤≤& '
VerifyUserAccount
≤≤( 9
(
≤≤9 :
[
≤≤: ;
FromBody
≤≤; C
]
≤≤C D"
VerifyUserAccountDto
≤≤E Y
values
≤≤Z `
)
≤≤` a
{
≥≥ 	
var
¥¥ 
userId
¥¥ 
=
¥¥ !
_userContextService
¥¥ ,
.
¥¥, -
	GetUserId
¥¥- 6
(
¥¥6 7
)
¥¥7 8
;
¥¥8 9
if
µµ 
(
µµ 
!
µµ 
string
µµ 
.
µµ 
Equals
µµ 
(
µµ 
userId
µµ %
,
µµ% &
values
µµ' -
.
µµ- .

verifiedBy
µµ. 8
)
µµ8 9
)
µµ9 :
{
∂∂ 
return
∑∑ 
Unauthorized
∑∑ #
(
∑∑# $
)
∑∑$ %
;
∑∑% &
}
∏∏ 
var
∫∫ 
result
∫∫ 
=
∫∫ 
await
∫∫ 
_adminService
∫∫ ,
.
∫∫, -#
VerifyCustomerAccount
∫∫- B
(
∫∫B C
values
∫∫C I
)
∫∫I J
;
∫∫J K
if
ºº 
(
ºº 
result
ºº 
.
ºº 
	IsSuccess
ºº 
)
ºº  
{
ΩΩ 
return
ææ 
Ok
ææ 
(
ææ 
result
ææ  
.
ææ  !
SuccessResponse
ææ! 0
)
ææ0 1
;
ææ1 2
}
øø 
var
¬¬ 
status
¬¬ 
=
¬¬ 
result
¬¬ 
.
¬¬  
ErrorResponse
¬¬  -
!
¬¬- .
.
¬¬. /

StatusCode
¬¬/ 9
;
¬¬9 :
return
ƒƒ 
status
ƒƒ 
switch
ƒƒ  
{
≈≈ 
$num
∆∆ 
=>
∆∆ 
	NoContent
∆∆  
(
∆∆  !
)
∆∆! "
,
∆∆" #
$num
«« 
=>
«« 

BadRequest
«« !
(
««! "
result
««" (
.
««( )
ErrorResponse
««) 6
)
««6 7
,
««7 8
$num
»» 
=>
»» 
NotFound
»» 
(
»»  
result
»»  &
.
»»& '
ErrorResponse
»»' 4
)
»»4 5
,
»»5 6
$num
…… 
=>
…… 
Conflict
…… 
(
……  
result
……  &
.
……& '
ErrorResponse
……' 4
)
……4 5
,
……5 6
_
   
=>
   

StatusCode
   
(
    
$num
    #
,
  # $
result
  % +
)
  + ,
,
  , -
}
ÀÀ 
;
ÀÀ 
}
ÃÃ 	
[
ŒŒ 	
HttpPut
ŒŒ	 
]
ŒŒ 
[
œœ 	
Route
œœ	 
(
œœ 
$str
œœ "
)
œœ" #
]
œœ# $
[
–– 	
	Authorize
––	 
(
–– 
Policy
–– 
=
–– 
$str
–– 5
)
––5 6
]
––6 7
[
—— 	
Obsolete
——	 
]
—— 
public
““ 
async
““ 
Task
““ 
<
““ 
ActionResult
““ &
>
““& '
RejectUserAccount
““( 9
(
““9 :
[
““: ;
FromBody
““; C
]
““C D"
RejectUserAccountDto
““E Y
values
““Z `
)
““` a
{
”” 	
var
‘‘ 
userId
‘‘ 
=
‘‘ !
_userContextService
‘‘ ,
.
‘‘, -
	GetUserId
‘‘- 6
(
‘‘6 7
)
‘‘7 8
;
‘‘8 9
if
’’ 
(
’’ 
!
’’ 
string
’’ 
.
’’ 
Equals
’’ 
(
’’ 
userId
’’ %
,
’’% &
values
’’' -
.
’’- .

RejectedBy
’’. 8
)
’’8 9
)
’’9 :
{
÷÷ 
return
◊◊ 
Unauthorized
◊◊ #
(
◊◊# $
)
◊◊$ %
;
◊◊% &
}
ÿÿ 
var
⁄⁄ 
result
⁄⁄ 
=
⁄⁄ 
await
⁄⁄ 
_adminService
⁄⁄ ,
.
⁄⁄, -#
RejectCustomerAccount
⁄⁄- B
(
⁄⁄B C
values
⁄⁄C I
)
⁄⁄I J
;
⁄⁄J K
if
‹‹ 
(
‹‹ 
result
‹‹ 
.
‹‹ 
	IsSuccess
‹‹  
)
‹‹  !
{
›› 
return
ﬁﬁ 
Ok
ﬁﬁ 
(
ﬁﬁ 
result
ﬁﬁ  
.
ﬁﬁ  !
SuccessResponse
ﬁﬁ! 0
)
ﬁﬁ0 1
;
ﬁﬁ1 2
}
ﬂﬂ 
var
„„ 
status
„„ 
=
„„ 
result
„„ 
.
„„  
ErrorResponse
„„  -
!
„„- .
.
„„. /

StatusCode
„„/ 9
;
„„9 :
return
ÂÂ 
status
ÂÂ 
switch
ÂÂ  
{
ÊÊ 
$num
ÁÁ 
=>
ÁÁ 
	NoContent
ÁÁ  
(
ÁÁ  !
)
ÁÁ! "
,
ÁÁ" #
$num
ËË 
=>
ËË 

BadRequest
ËË !
(
ËË! "
result
ËË" (
.
ËË( )
ErrorResponse
ËË) 6
)
ËË6 7
,
ËË7 8
$num
ÈÈ 
=>
ÈÈ 
NotFound
ÈÈ 
(
ÈÈ  
result
ÈÈ  &
.
ÈÈ& '
ErrorResponse
ÈÈ' 4
)
ÈÈ4 5
,
ÈÈ5 6
$num
ÍÍ 
=>
ÍÍ 
Conflict
ÍÍ 
(
ÍÍ  
result
ÍÍ  &
.
ÍÍ& '
ErrorResponse
ÍÍ' 4
)
ÍÍ4 5
,
ÍÍ5 6
_
ÎÎ 
=>
ÎÎ 

StatusCode
ÎÎ 
(
ÎÎ  
$num
ÎÎ  #
,
ÎÎ# $
result
ÎÎ% +
)
ÎÎ+ ,
,
ÎÎ, -
}
ÏÏ 
;
ÏÏ 
}
ÌÌ 	
[
ÔÔ 	
HttpPut
ÔÔ	 
]
ÔÔ 
[
 	
Route
	 
(
 
$str
 #
)
# $
]
$ %
[
ÒÒ 	
	Authorize
ÒÒ	 
(
ÒÒ 
Policy
ÒÒ 
=
ÒÒ 
$str
ÒÒ 6
)
ÒÒ6 7
]
ÒÒ7 8
public
ÚÚ 
async
ÚÚ 
Task
ÚÚ 
<
ÚÚ 
ActionResult
ÚÚ &
>
ÚÚ& ' 
ApproveUserAccount
ÚÚ( :
(
ÚÚ: ;
[
ÚÚ; <
FromBody
ÚÚ< D
]
ÚÚD E#
ApproveUserAccountDto
ÚÚF [
values
ÚÚ\ b
)
ÚÚb c
{
ÛÛ 	
var
ÙÙ 
userId
ÙÙ 
=
ÙÙ !
_userContextService
ÙÙ ,
.
ÙÙ, -
	GetUserId
ÙÙ- 6
(
ÙÙ6 7
)
ÙÙ7 8
;
ÙÙ8 9
if
ıı 
(
ıı 
!
ıı 
string
ıı 
.
ıı 
Equals
ıı 
(
ıı 
userId
ıı %
,
ıı% &
values
ıı' -
.
ıı- .

ApprovedBy
ıı. 8
)
ıı8 9
)
ıı9 :
{
ˆˆ 
return
˜˜ 
Unauthorized
˜˜ #
(
˜˜# $
)
˜˜$ %
;
˜˜% &
}
¯¯ 
var
˙˙ 
result
˙˙ 
=
˙˙ 
await
˙˙ 
_adminService
˙˙ ,
.
˙˙, - 
ApproveUserAccount
˙˙- ?
(
˙˙? @
values
˙˙@ F
)
˙˙F G
;
˙˙G H
if
¸¸ 
(
¸¸ 
result
¸¸ 
.
¸¸ 
	IsSuccess
¸¸  
)
¸¸  !
{
˝˝ 
return
˛˛ 
Ok
˛˛ 
(
˛˛ 
result
˛˛  
.
˛˛  !
SuccessResponse
˛˛! 0
)
˛˛0 1
;
˛˛1 2
}
ˇˇ 
var
ÉÉ 
status
ÉÉ 
=
ÉÉ 
result
ÉÉ 
.
ÉÉ  
ErrorResponse
ÉÉ  -
!
ÉÉ- .
.
ÉÉ. /

StatusCode
ÉÉ/ 9
;
ÉÉ9 :
return
ÖÖ 
status
ÖÖ 
switch
ÖÖ  
{
ÜÜ 
$num
áá 
=>
áá 
	NoContent
áá  
(
áá  !
)
áá! "
,
áá" #
$num
àà 
=>
àà 

BadRequest
àà !
(
àà! "
result
àà" (
.
àà( )
ErrorResponse
àà) 6
)
àà6 7
,
àà7 8
$num
ââ 
=>
ââ 
NotFound
ââ 
(
ââ  
result
ââ  &
.
ââ& '
ErrorResponse
ââ' 4
)
ââ4 5
,
ââ5 6
$num
ää 
=>
ää 
Conflict
ää 
(
ää  
result
ää  &
.
ää& '
ErrorResponse
ää' 4
)
ää4 5
,
ää5 6
_
ãã 
=>
ãã 

StatusCode
ãã 
(
ãã  
$num
ãã  #
,
ãã# $
result
ãã% +
)
ãã+ ,
,
ãã, -
}
åå 
;
åå 
}
éé 	
[
êê 	
HttpPut
êê	 
]
êê 
[
ëë 	
Route
ëë	 
(
ëë 
$str
ëë &
)
ëë& '
]
ëë' (
[
íí 	
	Authorize
íí	 
(
íí 
Policy
íí 
=
íí 
$str
íí 9
)
íí9 :
]
íí: ;
public
ìì 
async
ìì 
Task
ìì 
<
ìì 
ActionResult
ìì &
>
ìì& '#
DisapproveUserAccount
ìì( =
(
ìì= >
[
ìì> ?
FromBody
ìì? G
]
ììG H'
DisapprovedUserAccountDto
ììI b
values
ììc i
)
ììi j
{
îî 	
var
ïï 
userId
ïï 
=
ïï !
_userContextService
ïï ,
.
ïï, -
	GetUserId
ïï- 6
(
ïï6 7
)
ïï7 8
;
ïï8 9
if
ññ 
(
ññ 
!
ññ 
string
ññ 
.
ññ 
Equals
ññ 
(
ññ 
userId
ññ %
,
ññ% &
values
ññ' -
.
ññ- .
DisapprovedBy
ññ. ;
)
ññ; <
)
ññ< =
{
óó 
return
òò 
Unauthorized
òò #
(
òò# $
)
òò$ %
;
òò% &
}
ôô 
var
õõ 
result
õõ 
=
õõ 
await
õõ 
_adminService
õõ ,
.
õõ, -#
DisapproveUserAccount
õõ- B
(
õõB C
values
õõC I
)
õõI J
;
õõJ K
if
ùù 
(
ùù 
result
ùù 
.
ùù 
	IsSuccess
ùù  
)
ùù  !
{
ûû 
return
üü 
Ok
üü 
(
üü 
result
üü  
.
üü  !
SuccessResponse
üü! 0
)
üü0 1
;
üü1 2
}
†† 
var
££ 
status
££ 
=
££ 
result
££ 
.
££  
ErrorResponse
££  -
!
££- .
.
££. /

StatusCode
££/ 9
;
££9 :
return
•• 
status
•• 
switch
••  
{
¶¶ 
$num
ßß 
=>
ßß 
	NoContent
ßß  
(
ßß  !
)
ßß! "
,
ßß" #
$num
®® 
=>
®® 

BadRequest
®® !
(
®®! "
result
®®" (
.
®®( )
ErrorResponse
®®) 6
)
®®6 7
,
®®7 8
$num
©© 
=>
©© 
NotFound
©© 
(
©©  
result
©©  &
.
©©& '
ErrorResponse
©©' 4
)
©©4 5
,
©©5 6
$num
™™ 
=>
™™ 
Conflict
™™ 
(
™™  
result
™™  &
.
™™& '
ErrorResponse
™™' 4
)
™™4 5
,
™™5 6
_
´´ 
=>
´´ 

StatusCode
´´ 
(
´´  
$num
´´  #
,
´´# $
result
´´% +
)
´´+ ,
,
´´, -
}
¨¨ 
;
¨¨ 
}
≠≠ 	
[
ØØ 	
HttpPut
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
∞∞ $
)
∞∞$ %
]
∞∞% &
[
±± 	
	Authorize
±±	 
(
±± 
Policy
±± 
=
±± 
$str
±± 7
)
±±7 8
]
±±8 9
public
≤≤ 
async
≤≤ 
Task
≤≤ 
<
≤≤ 
ActionResult
≤≤ &
>
≤≤& '!
ActivateUserAccount
≤≤( ;
(
≤≤; <
[
≤≤< =
FromBody
≤≤= E
]
≤≤E F$
ActivateUserAccountDto
≤≤G ]
values
≤≤^ d
)
≤≤d e
{
≥≥ 	
var
¥¥ 
userId
¥¥ 
=
¥¥ !
_userContextService
¥¥ ,
.
¥¥, -
	GetUserId
¥¥- 6
(
¥¥6 7
)
¥¥7 8
;
¥¥8 9
if
µµ 
(
µµ 
!
µµ 
string
µµ 
.
µµ 
Equals
µµ 
(
µµ 
userId
µµ %
,
µµ% &
values
µµ' -
.
µµ- .
activatedBy
µµ. 9
)
µµ9 :
)
µµ: ;
{
∂∂ 
return
∑∑ 
Unauthorized
∑∑ #
(
∑∑# $
)
∑∑$ %
;
∑∑% &
}
∏∏ 
var
∫∫ 
result
∫∫ 
=
∫∫ 
await
∫∫ 
_adminService
∫∫ ,
.
∫∫, -!
ActivateUserAccount
∫∫- @
(
∫∫@ A
values
∫∫A G
)
∫∫G H
;
∫∫H I
if
ºº 
(
ºº 
result
ºº 
.
ºº 
	IsSuccess
ºº  
)
ºº  !
{
ΩΩ 
return
ææ 
Ok
ææ 
(
ææ 
result
ææ  
.
ææ  !
SuccessResponse
ææ! 0
)
ææ0 1
;
ææ1 2
}
øø 
var
¬¬ 
status
¬¬ 
=
¬¬ 
result
¬¬ 
.
¬¬  
ErrorResponse
¬¬  -
!
¬¬- .
.
¬¬. /

StatusCode
¬¬/ 9
;
¬¬9 :
return
ƒƒ 
status
ƒƒ 
switch
ƒƒ  
{
≈≈ 
$num
∆∆ 
=>
∆∆ 
	NoContent
∆∆  
(
∆∆  !
)
∆∆! "
,
∆∆" #
$num
«« 
=>
«« 

BadRequest
«« !
(
««! "
result
««" (
.
««( )
ErrorResponse
««) 6
)
««6 7
,
««7 8
$num
»» 
=>
»» 
NotFound
»» 
(
»»  
result
»»  &
.
»»& '
ErrorResponse
»»' 4
)
»»4 5
,
»»5 6
$num
…… 
=>
…… 
Conflict
…… 
(
……  
result
……  &
.
……& '
ErrorResponse
……' 4
)
……4 5
,
……5 6
_
   
=>
   

StatusCode
   
(
    
$num
    #
,
  # $
result
  % +
)
  + ,
,
  , -
}
ÀÀ 
;
ÀÀ 
}
ÃÃ 	
[
ŒŒ 	
HttpPut
ŒŒ	 
]
ŒŒ 
[
œœ 	
Route
œœ	 
(
œœ 
$str
œœ &
)
œœ& '
]
œœ' (
[
–– 	
	Authorize
––	 
(
–– 
Policy
–– 
=
–– 
$str
–– 9
)
––9 :
]
––: ;
public
—— 
async
—— 
Task
—— 
<
—— 
ActionResult
—— &
>
——& '"
DectivateUserAccount
——( <
(
——< =
[
——= >
FromBody
——> F
]
——F G&
DeactivateUserAccountDto
——H `
values
——a g
)
——g h
{
““ 	
var
”” 
userId
”” 
=
”” !
_userContextService
”” ,
.
””, -
	GetUserId
””- 6
(
””6 7
)
””7 8
;
””8 9
if
‘‘ 
(
‘‘ 
!
‘‘ 
string
‘‘ 
.
‘‘ 
Equals
‘‘ 
(
‘‘ 
userId
‘‘ %
,
‘‘% &
values
‘‘' -
.
‘‘- .
DeactivatedBy
‘‘. ;
)
‘‘; <
)
‘‘< =
{
’’ 
return
÷÷ 
Unauthorized
÷÷ #
(
÷÷# $
)
÷÷$ %
;
÷÷% &
}
◊◊ 
var
ŸŸ 
result
ŸŸ 
=
ŸŸ 
await
ŸŸ 
_adminService
ŸŸ ,
.
ŸŸ, -#
DeactivateUserAccount
ŸŸ- B
(
ŸŸB C
values
ŸŸC I
)
ŸŸI J
;
ŸŸJ K
if
€€ 
(
€€ 
result
€€ 
.
€€ 
	IsSuccess
€€  
)
€€  !
{
‹‹ 
return
›› 
Ok
›› 
(
›› 
result
››  
.
››  !
SuccessResponse
››! 0
)
››0 1
;
››1 2
}
ﬁﬁ 
var
·· 
status
·· 
=
·· 
result
·· 
.
··  
ErrorResponse
··  -
!
··- .
.
··. /

StatusCode
··/ 9
;
··9 :
return
„„ 
status
„„ 
switch
„„  
{
‰‰ 
$num
ÂÂ 
=>
ÂÂ 
	NoContent
ÂÂ  
(
ÂÂ  !
)
ÂÂ! "
,
ÂÂ" #
$num
ÊÊ 
=>
ÊÊ 

BadRequest
ÊÊ !
(
ÊÊ! "
result
ÊÊ" (
.
ÊÊ( )
ErrorResponse
ÊÊ) 6
)
ÊÊ6 7
,
ÊÊ7 8
$num
ÁÁ 
=>
ÁÁ 
NotFound
ÁÁ 
(
ÁÁ  
result
ÁÁ  &
.
ÁÁ& '
ErrorResponse
ÁÁ' 4
)
ÁÁ4 5
,
ÁÁ5 6
$num
ËË 
=>
ËË 
Conflict
ËË 
(
ËË  
result
ËË  &
.
ËË& '
ErrorResponse
ËË' 4
)
ËË4 5
,
ËË5 6
_
ÈÈ 
=>
ÈÈ 

StatusCode
ÈÈ 
(
ÈÈ  
$num
ÈÈ  #
,
ÈÈ# $
result
ÈÈ% +
)
ÈÈ+ ,
,
ÈÈ, -
}
ÍÍ 
;
ÍÍ 
}
ÎÎ 	
[
ÚÚ 	
HttpGet
ÚÚ	 
]
ÚÚ 
[
ÛÛ 	
Route
ÛÛ	 
(
ÛÛ 
$str
ÛÛ 
)
ÛÛ  
]
ÛÛ  !
public
ÙÙ 
async
ÙÙ 
Task
ÙÙ 
<
ÙÙ 
ActionResult
ÙÙ &
<
ÙÙ& '
IEnumerable
ÙÙ' 2
<
ÙÙ2 3
DepartmentReadDto
ÙÙ3 D
>
ÙÙD E
>
ÙÙE F
>
ÙÙF G
GetDepartments
ÙÙH V
(
ÙÙV W
)
ÙÙW X
{
ıı 	
return
ˆˆ 
Ok
ˆˆ 
(
ˆˆ 
await
ˆˆ  
_departmentService
ˆˆ .
.
ˆˆ. / 
GetDepartmentAsync
ˆˆ/ A
(
ˆˆA B
)
ˆˆB C
)
ˆˆC D
;
ˆˆD E
}
˜˜ 	
[
¸¸ 	
HttpGet
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ 2
)
˝˝2 3
]
˝˝3 4
public
˛˛ 
async
˛˛ 
Task
˛˛ 
<
˛˛ 
ActionResult
˛˛ &
<
˛˛& '
IEnumerable
˛˛' 2
<
˛˛2 3
UnitReadDto
˛˛3 >
>
˛˛> ?
>
˛˛? @
>
˛˛@ A 
GetDepartmentUnits
˛˛B T
(
˛˛T U
int
˛˛U X
departmentId
˛˛Y e
)
˛˛e f
{
ˇˇ 	
return
ÄÄ 
Ok
ÄÄ 
(
ÄÄ 
await
ÄÄ $
_departmentUnitService
ÄÄ 2
.
ÄÄ2 3
GetUnitAsync
ÄÄ3 ?
(
ÄÄ? @
departmentId
ÄÄ@ L
)
ÄÄL M
)
ÄÄM N
;
ÄÄN O
}
ÅÅ 	
[
ÉÉ 	
HttpGet
ÉÉ	 
]
ÉÉ 
[
ÑÑ 	
Route
ÑÑ	 
(
ÑÑ 
$str
ÑÑ &
)
ÑÑ& '
]
ÑÑ' (
private
ÖÖ 
async
ÖÖ 
Task
ÖÖ 
<
ÖÖ 
ActionResult
ÖÖ '
<
ÖÖ' (
DepartmentReadDto
ÖÖ( 9
>
ÖÖ9 :
>
ÖÖ: ;
GetDepartment
ÖÖ< I
(
ÖÖI J
string
ÖÖJ P
value
ÖÖQ V
)
ÖÖV W
{
ÜÜ 	
return
áá 
Ok
áá 
(
áá 
await
áá  
_departmentService
áá .
.
áá. / 
GetDepartmentAsync
áá/ A
(
ááA B
value
ááB G
)
ááG H
)
ááH I
;
ááI J
}
àà 	
[
ää 	
HttpGet
ää	 
]
ää 
[
ãã 	
Route
ãã	 
(
ãã 
$str
ãã 1
)
ãã1 2
]
ãã2 3
public
åå 
async
åå 
Task
åå 
<
åå 
ActionResult
åå &
<
åå& '
DepartmentReadDto
åå' 8
>
åå8 9
>
åå9 :
GetDepartmentById
åå; L
(
ååL M
int
ååM P
departmentId
ååQ ]
)
åå] ^
{
çç 	
return
éé 
Ok
éé 
(
éé 
await
éé  
_departmentService
éé .
.
éé. / 
GetDepartmentAsync
éé/ A
(
ééA B
departmentId
ééB N
)
ééN O
)
ééO P
;
ééP Q
}
èè 	
[
ëë 	
HttpPost
ëë	 
]
ëë 
[
íí 	
Route
íí	 
(
íí 
$str
íí !
)
íí! "
]
íí" #
[
ìì 	
	Authorize
ìì	 
(
ìì 
Policy
ìì 
=
ìì 
$str
ìì 5
)
ìì5 6
]
ìì6 7
public
îî 
async
îî 
Task
îî 
<
îî 
ActionResult
îî &
<
îî& '
DepartmentReadDto
îî' 8
>
îî8 9
>
îî9 :
CreateDepartment
îî; K
(
îîK L
[
îîL M
FromBody
îîM U
]
îîU V!
DepartmentCreateDto
îîW j
values
îîk q
)
îîq r
{
ïï 	
try
ññ 
{
óó 
var
òò 
userId
òò 
=
òò !
_userContextService
òò 0
.
òò0 1
	GetUserId
òò1 :
(
òò: ;
)
òò; <
;
òò< =
if
ôô 
(
ôô 
!
ôô 
string
ôô 
.
ôô 
Equals
ôô "
(
ôô" #
userId
ôô# )
,
ôô) *
values
ôô+ 1
.
ôô1 2
	CreatedBy
ôô2 ;
)
ôô; <
)
ôô< =
{
öö 
return
õõ 
Unauthorized
õõ '
(
õõ' (
)
õõ( )
;
õõ) *
}
úú 
var
ûû 
result
ûû 
=
ûû 
await
ûû " 
_departmentService
ûû# 5
.
ûû5 6 
AddDepartmentAsync
ûû6 H
(
ûûH I
values
ûûI O
)
ûûO P
;
ûûP Q
if
üü 
(
üü 
result
üü 
is
üü 
null
üü !
)
üü! "
{
†† 
return
°° 

BadRequest
°° %
(
°°% &
result
°°& ,
)
°°, -
;
°°- .
}
¢¢ 
return
§§ 

StatusCode
§§ !
(
§§! "
StatusCodes
§§" -
.
§§- .
Status201Created
§§. >
,
§§> ?
result
§§@ F
)
§§F G
;
§§G H
}
¶¶ 
catch
ßß 
(
ßß 
	Exception
ßß 
ex
ßß 
)
ßß  
{
®® 
return
©© 

StatusCode
©© !
(
©©! "
$num
©©" %
,
©©% &
ex
©©' )
.
©©) *
InnerException
©©* 8
!
©©8 9
.
©©9 :
Message
©©: A
)
©©A B
;
©©B C
}
™™ 
}
´´ 	
[
≠≠ 	
HttpPut
≠≠	 
]
≠≠ 
[
ÆÆ 	
Route
ÆÆ	 
(
ÆÆ 
$str
ÆÆ !
)
ÆÆ! "
]
ÆÆ" #
[
ØØ 	
	Authorize
ØØ	 
(
ØØ 
Policy
ØØ 
=
ØØ 
$str
ØØ 5
)
ØØ5 6
]
ØØ6 7
public
∞∞ 
async
∞∞ 
Task
∞∞ 
<
∞∞ 
ActionResult
∞∞ &
<
∞∞& '
DepartmentReadDto
∞∞' 8
>
∞∞8 9
>
∞∞9 :
UpdateDepartment
∞∞; K
(
∞∞K L
[
∞∞L M
FromBody
∞∞M U
]
∞∞U V!
DepartmentUpdateDto
∞∞W j
values
∞∞k q
)
∞∞q r
{
±± 	
var
≤≤ 
userId
≤≤ 
=
≤≤ !
_userContextService
≤≤ ,
.
≤≤, -
	GetUserId
≤≤- 6
(
≤≤6 7
)
≤≤7 8
;
≤≤8 9
if
≥≥ 
(
≥≥ 
!
≥≥ 
string
≥≥ 
.
≥≥ 
Equals
≥≥ 
(
≥≥ 
userId
≥≥ %
,
≥≥% &
values
≥≥' -
.
≥≥- .

ModifiedBy
≥≥. 8
)
≥≥8 9
)
≥≥9 :
{
¥¥ 
return
µµ 
Unauthorized
µµ #
(
µµ# $
)
µµ$ %
;
µµ% &
}
∂∂ 
var
∏∏ 
result
∏∏ 
=
∏∏  
_departmentService
∏∏ +
.
∏∏+ , 
GetDepartmentAsync
∏∏, >
(
∏∏> ?
values
∏∏? E
.
∏∏E F
DepartmentId
∏∏F R
)
∏∏R S
;
∏∏S T
if
ππ 
(
ππ 
result
ππ 
is
ππ 
null
ππ 
)
ππ 
{
∫∫ 
return
ªª 

BadRequest
ªª !
(
ªª! "
)
ªª" #
;
ªª# $
}
ºº 
return
ææ 
Ok
ææ 
(
ææ 
await
ææ  
_departmentService
ææ .
.
ææ. /#
UpdateDepartmentAsync
ææ/ D
(
ææD E
values
ææE K
)
ææK L
)
ææL M
;
ææM N
}
øø 	
[
¡¡ 	

HttpDelete
¡¡	 
(
¡¡ 
$str
¡¡ 5
)
¡¡5 6
]
¡¡6 7
public
¬¬ 
async
¬¬ 
Task
¬¬ 
<
¬¬ 
ActionResult
¬¬ &
>
¬¬& '
DeleteDepartment
¬¬( 8
(
¬¬8 9
int
¬¬9 <
departmentId
¬¬= I
)
¬¬I J
{
√√ 	
var
ƒƒ 
result
ƒƒ 
=
ƒƒ 
await
ƒƒ  
_departmentService
ƒƒ 1
.
ƒƒ1 2
DeleteDepartment
ƒƒ2 B
(
ƒƒB C
departmentId
ƒƒC O
)
ƒƒO P
;
ƒƒP Q
if
≈≈ 
(
≈≈ 
result
≈≈ 
.
≈≈ 
response
≈≈ 
==
≈≈ !
$str
≈≈" +
)
≈≈+ ,
{
∆∆ 
return
«« 
Ok
«« 
(
«« 
result
««  
)
««  !
;
««! "
}
»» 
return
…… 

BadRequest
…… 
(
…… 
result
…… $
)
……$ %
;
……% &
}
   	
[
–– 	
HttpGet
––	 
]
–– 
[
—— 	
Route
——	 
(
—— 
$str
—— #
)
——# $
]
——$ %
public
““ 
async
““ 
Task
““ 
<
““ 
ActionResult
““ &
<
““& '
IEnumerable
““' 2
<
““2 3#
DepartmentUnitReadDto
““3 H
>
““H I
>
““I J
>
““J K 
GetDepartmentUnits
““L ^
(
““^ _
)
““_ `
{
”” 	
return
‘‘ 
Ok
‘‘ 
(
‘‘ 
await
‘‘ $
_departmentUnitService
‘‘ 2
.
‘‘2 3$
GetDepartmentUnitAsync
‘‘3 I
(
‘‘I J
)
‘‘J K
)
‘‘K L
;
‘‘L M
}
’’ 	
[
◊◊ 	
HttpGet
◊◊	 
]
◊◊ 
[
ÿÿ 	
Route
ÿÿ	 
(
ÿÿ 
$str
ÿÿ *
)
ÿÿ* +
]
ÿÿ+ ,
private
ŸŸ 
async
ŸŸ 
Task
ŸŸ 
<
ŸŸ 
ActionResult
ŸŸ '
<
ŸŸ' (
DepartmentReadDto
ŸŸ( 9
>
ŸŸ9 :
>
ŸŸ: ;
GetDepartmentUnit
ŸŸ< M
(
ŸŸM N
string
ŸŸN T
value
ŸŸU Z
)
ŸŸZ [
{
⁄⁄ 	
return
€€ 
Ok
€€ 
(
€€ 
await
€€ $
_departmentUnitService
€€ 2
.
€€2 3$
GetDepartmentUnitAsync
€€3 I
(
€€I J
value
€€J O
)
€€O P
)
€€P Q
;
€€Q R
}
‹‹ 	
[
ﬁﬁ 	
HttpGet
ﬁﬁ	 
]
ﬁﬁ 
[
ﬂﬂ 	
Route
ﬂﬂ	 
(
ﬂﬂ 
$str
ﬂﬂ @
)
ﬂﬂ@ A
]
ﬂﬂA B
public
‡‡ 
async
‡‡ 
Task
‡‡ 
<
‡‡ 
ActionResult
‡‡ &
<
‡‡& '
IEnumerable
‡‡' 2
<
‡‡2 3#
DepartmentUnitReadDto
‡‡3 H
>
‡‡H I
>
‡‡I J
>
‡‡J K.
 GetDepartmentUnitsByDepartmentId
‡‡L l
(
‡‡l m
int
‡‡m p
departmentId
‡‡q }
)
‡‡} ~
{
·· 	
return
‚‚ 
Ok
‚‚ 
(
‚‚ 
await
‚‚ $
_departmentUnitService
‚‚ 2
.
‚‚2 3$
GetDepartmentUnitAsync
‚‚3 I
(
‚‚I J
departmentId
‚‚J V
)
‚‚V W
)
‚‚W X
;
‚‚X Y
}
„„ 	
[
ÂÂ 	
HttpGet
ÂÂ	 
]
ÂÂ 
[
ÊÊ 	
Route
ÊÊ	 
(
ÊÊ 
$str
ÊÊ 9
)
ÊÊ9 :
]
ÊÊ: ;
private
ÁÁ 
async
ÁÁ 
Task
ÁÁ 
<
ÁÁ 
ActionResult
ÁÁ '
<
ÁÁ' (
DepartmentReadDto
ÁÁ( 9
>
ÁÁ9 :
>
ÁÁ: ;#
GetDepartmentUnitById
ÁÁ< Q
(
ÁÁQ R
int
ÁÁR U
departmentUnitId
ÁÁV f
)
ÁÁf g
{
ËË 	
return
ÈÈ 
Ok
ÈÈ 
(
ÈÈ 
await
ÈÈ $
_departmentUnitService
ÈÈ 2
.
ÈÈ2 3$
GetDepartmentUnitAsync
ÈÈ3 I
(
ÈÈI J
departmentUnitId
ÈÈJ Z
)
ÈÈZ [
)
ÈÈ[ \
;
ÈÈ\ ]
}
ÍÍ 	
[
ÏÏ 	
HttpPost
ÏÏ	 
]
ÏÏ 
[
ÌÌ 	
Route
ÌÌ	 
(
ÌÌ 
$str
ÌÌ %
)
ÌÌ% &
]
ÌÌ& '
[
ÓÓ 	
	Authorize
ÓÓ	 
(
ÓÓ 
Policy
ÓÓ 
=
ÓÓ 
$str
ÓÓ 5
)
ÓÓ5 6
]
ÓÓ6 7
public
ÔÔ 
async
ÔÔ 
Task
ÔÔ 
<
ÔÔ 
ActionResult
ÔÔ &
<
ÔÔ& '#
DepartmentUnitReadDto
ÔÔ' <
>
ÔÔ< =
>
ÔÔ= >"
CreateDepartmentUnit
ÔÔ? S
(
ÔÔS T
[
ÔÔT U
FromBody
ÔÔU ]
]
ÔÔ] ^%
DepartmentUnitCreateDto
ÔÔ_ v
values
ÔÔw }
)
ÔÔ} ~
{
 	
try
ÒÒ 
{
ÚÚ 
var
ÛÛ 
userId
ÛÛ 
=
ÛÛ !
_userContextService
ÛÛ 0
.
ÛÛ0 1
	GetUserId
ÛÛ1 :
(
ÛÛ: ;
)
ÛÛ; <
;
ÛÛ< =
if
ÙÙ 
(
ÙÙ 
!
ÙÙ 
string
ÙÙ 
.
ÙÙ 
Equals
ÙÙ "
(
ÙÙ" #
userId
ÙÙ# )
,
ÙÙ) *
values
ÙÙ+ 1
.
ÙÙ1 2
	CreatedBy
ÙÙ2 ;
)
ÙÙ; <
)
ÙÙ< =
{
ıı 
return
ˆˆ 
Unauthorized
ˆˆ '
(
ˆˆ' (
)
ˆˆ( )
;
ˆˆ) *
}
˜˜ 
var
˘˘ 
result
˘˘ 
=
˘˘ 
await
˘˘ "$
_departmentUnitService
˘˘# 9
.
˘˘9 :$
AddDepartmentUnitAsync
˘˘: P
(
˘˘P Q
values
˘˘Q W
)
˘˘W X
;
˘˘X Y
if
˙˙ 
(
˙˙ 
result
˙˙ 
is
˙˙ 
null
˙˙ "
)
˙˙" #
{
˚˚ 
return
¸¸ 

BadRequest
¸¸ %
(
¸¸% &
result
¸¸& ,
)
¸¸, -
;
¸¸- .
}
˝˝ 
return
ˇˇ 

StatusCode
ˇˇ !
(
ˇˇ! "
StatusCodes
ˇˇ" -
.
ˇˇ- .
Status201Created
ˇˇ. >
,
ˇˇ> ?
result
ˇˇ@ F
)
ˇˇF G
;
ˇˇG H
}
ÅÅ 
catch
ÇÇ 
(
ÇÇ 
	Exception
ÇÇ 
ex
ÇÇ 
)
ÇÇ  
{
ÉÉ 
return
ÑÑ 

StatusCode
ÑÑ !
(
ÑÑ! "
$num
ÑÑ" %
,
ÑÑ% &
ex
ÑÑ' )
.
ÑÑ) *
InnerException
ÑÑ* 8
!
ÑÑ8 9
.
ÑÑ9 :
Message
ÑÑ: A
)
ÑÑA B
;
ÑÑB C
}
ÖÖ 
}
ÜÜ 	
[
àà 	
HttpPut
àà	 
]
àà 
[
ââ 	
Route
ââ	 
(
ââ 
$str
ââ %
)
ââ% &
]
ââ& '
public
ää 
async
ää 
Task
ää 
<
ää 
ActionResult
ää &
<
ää& '
DepartmentReadDto
ää' 8
>
ää8 9
>
ää9 :"
UpdateDepartmentUnit
ää; O
(
ääO P
[
ääP Q
FromBody
ääQ Y
]
ääY Z%
DepartmentUnitUpdateDto
ää[ r
values
ääs y
)
ääy z
{
ãã 	
var
åå 
userId
åå 
=
åå !
_userContextService
åå ,
.
åå, -
	GetUserId
åå- 6
(
åå6 7
)
åå7 8
;
åå8 9
if
çç 
(
çç 
!
çç 
string
çç 
.
çç 
Equals
çç 
(
çç 
userId
çç %
,
çç% &
values
çç' -
.
çç- .

ModifiedBy
çç. 8
)
çç8 9
)
çç9 :
{
éé 
return
èè 
Unauthorized
èè #
(
èè# $
)
èè$ %
;
èè% &
}
êê 
var
íí 
result
íí 
=
íí $
_departmentUnitService
íí /
.
íí/ 0$
GetDepartmentUnitAsync
íí0 F
(
ííF G
values
ííG M
.
ííM N
UnitId
ííN T
)
ííT U
;
ííU V
if
ìì 
(
ìì 
result
ìì 
is
ìì 
null
ìì 
)
ìì 
{
îî 
return
ïï 

BadRequest
ïï !
(
ïï! "
)
ïï" #
;
ïï# $
}
ññ 
return
òò 
Ok
òò 
(
òò 
await
òò $
_departmentUnitService
òò 2
.
òò2 3'
UpdateDepartmentUnitAsync
òò3 L
(
òòL M
values
òòM S
)
òòS T
)
òòT U
;
òòU V
}
ôô 	
[
õõ 	

HttpDelete
õõ	 
(
õõ 
$str
õõ 3
)
õõ3 4
]
õõ4 5
public
úú 
async
úú 
Task
úú 
<
úú 
ActionResult
úú &
>
úú& '"
DeleteDepartmentUnit
úú( <
(
úú< =
int
úú= @
unitId
úúA G
)
úúG H
{
ùù 	
var
ûû 
result
ûû 
=
ûû 
await
ûû $
_departmentUnitService
ûû 5
.
ûû5 6"
DeleteDepartmentUnit
ûû6 J
(
ûûJ K
unitId
ûûK Q
)
ûûQ R
;
ûûR S
if
üü 
(
üü 
result
üü 
.
üü 
response
üü 
==
üü  "
$str
üü# ,
)
üü, -
{
†† 
return
°° 
Ok
°° 
(
°° 
result
°°  
)
°°  !
;
°°! "
}
¢¢ 
return
££ 

BadRequest
££ 
(
££ 
result
££ $
)
££$ %
;
££% &
}
§§ 	
[
¶¶ 	
HttpGet
¶¶	 
]
¶¶ 
[
ßß 	
Route
ßß	 
(
ßß 
$str
ßß #
)
ßß# $
]
ßß$ %
[
®® 	
AllowAnonymous
®®	 
]
®® 
public
©© 
IActionResult
©© #
GetRegistrationStatus
©© 2
(
©©2 3
)
©©3 4
{
™™ 	
var
´´ 
types
´´ 
=
´´ 
Enum
´´ 
.
´´ 
	GetValues
´´ &
(
´´& '
typeof
´´' -
(
´´- . 
RegistrationStatus
´´. @
)
´´@ A
)
´´A B
.
¨¨# $
Cast
¨¨$ (
<
¨¨( ) 
RegistrationStatus
¨¨) ;
>
¨¨; <
(
¨¨< =
)
¨¨= >
.
≠≠# $
Select
≠≠$ *
(
≠≠* +
e
≠≠+ ,
=>
≠≠- /
new
≠≠0 3
{
ÆÆ# $
Id
ØØ' )
=
ØØ* +
(
ØØ, -
int
ØØ- 0
)
ØØ0 1
e
ØØ1 2
,
ØØ2 3
Name
∞∞' +
=
∞∞, -
e
∞∞. /
.
∞∞/ 0
ToString
∞∞0 8
(
∞∞8 9
)
∞∞9 :
,
∞∞: ;
DisplayName
±±' 2
=
±±3 4
e
±±5 6
.
±±6 7
GetType
±±7 >
(
±±> ?
)
±±? @
.
≤≤5 6
GetField
≤≤6 >
(
≤≤> ?
e
≤≤? @
.
≤≤@ A
ToString
≤≤A I
(
≤≤I J
)
≤≤J K
)
≤≤K L
!
≤≤L M
.
≥≥5 6 
GetCustomAttribute
≥≥6 H
<
≥≥H I"
DescriptionAttribute
≥≥I ]
>
≥≥] ^
(
≥≥^ _
)
≥≥_ `
?
≥≥` a
.
¥¥5 6
Description
¥¥6 A
}
∂∂# $
)
∂∂$ %
;
∂∂% &
return
∑∑ 
Ok
∑∑ 
(
∑∑ 
types
∑∑ 
)
∑∑ 
;
∑∑ 
}
∏∏ 	
[
ææ 	
HttpGet
ææ	 
]
ææ 
[
øø 	
Route
øø	 
(
øø 
$str
øø '
)
øø' (
]
øø( )
public
¿¿ 
async
¿¿ 
Task
¿¿ 
<
¿¿ 
ActionResult
¿¿ &
<
¿¿& '
IEnumerable
¿¿' 2
<
¿¿2 3(
IIdentificationTypeService
¿¿3 M
>
¿¿M N
>
¿¿N O
>
¿¿O P$
GetIdentificationTypes
¿¿Q g
(
¿¿g h
)
¿¿h i
{
¡¡ 	
return
¬¬ 
Ok
¬¬ 
(
¬¬ 
await
¬¬ (
_identificationTypeService
¬¬ 6
.
¬¬6 7(
GetIdentificationTypeAsync
¬¬7 Q
(
¬¬Q R
)
¬¬R S
)
¬¬S T
;
¬¬T U
}
√√ 	
[
∆∆ 	
HttpPost
∆∆	 
]
∆∆ 
[
«« 	
Route
««	 
(
«« 
$str
«« )
)
««) *
]
««* +
[
»» 	
	Authorize
»»	 
(
»» 
Policy
»» 
=
»» 
$str
»» 5
)
»»5 6
]
»»6 7
public
…… 
async
…… 
Task
…… 
<
…… 
ActionResult
…… &
<
……& '
ChannelReadDto
……' 5
>
……5 6
>
……6 7&
CreateIdentificationType
……8 P
(
……P Q
[
……Q R
FromBody
……R Z
]
……Z [#
IdentificationTypeDto
……\ q
values
……r x
)
……x y
{
   	
try
ÀÀ 
{
ÃÃ 
var
ŒŒ 
result
ŒŒ 
=
ŒŒ 
await
ŒŒ "(
_identificationTypeService
ŒŒ# =
.
ŒŒ= >(
AddIdentificationTypeAsync
ŒŒ> X
(
ŒŒX Y
values
ŒŒY _
)
ŒŒ_ `
;
ŒŒ` a
if
œœ 
(
œœ 
result
œœ 
is
œœ 
null
œœ "
)
œœ" #
{
–– 
return
—— 

BadRequest
—— %
(
——% &
result
——& ,
)
——, -
;
——- .
}
““ 
return
‘‘ 

StatusCode
‘‘ !
(
‘‘! "
StatusCodes
‘‘" -
.
‘‘- .
Status201Created
‘‘. >
,
‘‘> ?
new
‘‘@ C
{
‘‘D E
response
‘‘F N
=
‘‘O P
result
‘‘Q W
}
‘‘X Y
)
‘‘Y Z
;
‘‘Z [
}
÷÷ 
catch
◊◊ 
(
◊◊ 
	Exception
◊◊ 
ex
◊◊ 
)
◊◊  
{
ÿÿ 
return
ŸŸ 

StatusCode
ŸŸ !
(
ŸŸ! "
$num
ŸŸ" %
,
ŸŸ% &
ex
ŸŸ' )
.
ŸŸ) *
InnerException
ŸŸ* 8
!
ŸŸ8 9
.
ŸŸ9 :
Message
ŸŸ: A
)
ŸŸA B
;
ŸŸB C
}
⁄⁄ 
}
€€ 	
[
›› 	
HttpPut
››	 
]
›› 
[
ﬁﬁ 	
Route
ﬁﬁ	 
(
ﬁﬁ 
$str
ﬁﬁ )
)
ﬁﬁ) *
]
ﬁﬁ* +
public
ﬂﬂ 
async
ﬂﬂ 
Task
ﬂﬂ 
<
ﬂﬂ 
ActionResult
ﬂﬂ &
<
ﬂﬂ& '
ChannelReadDto
ﬂﬂ' 5
>
ﬂﬂ5 6
>
ﬂﬂ6 7&
UpdateIdentificationType
ﬂﬂ8 P
(
ﬂﬂP Q
[
ﬂﬂQ R
FromBody
ﬂﬂR Z
]
ﬂﬂZ [#
IdentificationTypeDto
ﬂﬂ\ q
values
ﬂﬂr x
)
ﬂﬂx y
{
‡‡ 	
var
‚‚ 
result
‚‚ 
=
‚‚ 
await
‚‚ (
_identificationTypeService
‚‚ 9
.
‚‚9 :+
UpdateIdentificationTypeAsync
‚‚: W
(
‚‚W X
values
‚‚X ^
)
‚‚^ _
;
‚‚_ `
if
‰‰ 
(
‰‰ 
result
‰‰ 
is
‰‰ 
null
‰‰ 
)
‰‰ 
{
ÂÂ 
return
ÊÊ 

BadRequest
ÊÊ !
(
ÊÊ! "
)
ÊÊ" #
;
ÊÊ# $
}
ÁÁ 
return
ÈÈ 
Ok
ÈÈ 
(
ÈÈ 
new
ÈÈ 
{
ÈÈ 
response
ÈÈ $
=
ÈÈ% &
result
ÈÈ' -
}
ÈÈ. /
)
ÈÈ/ 0
;
ÈÈ0 1
}
ÍÍ 	
[
ÏÏ 	

HttpDelete
ÏÏ	 
(
ÏÏ 
$str
ÏÏ E
)
ÏÏE F
]
ÏÏF G
public
ÌÌ 
async
ÌÌ 
Task
ÌÌ 
<
ÌÌ 
ActionResult
ÌÌ &
>
ÌÌ& '&
DeleteIdentificationType
ÌÌ( @
(
ÌÌ@ A
int
ÌÌA D"
identificationTypeId
ÌÌE Y
)
ÌÌY Z
{
ÓÓ 	
var
ÔÔ 
result
ÔÔ 
=
ÔÔ 
await
ÔÔ (
_identificationTypeService
ÔÔ 9
.
ÔÔ9 :+
DeleteIdentificationTypeAsync
ÔÔ: W
(
ÔÔW X"
identificationTypeId
ÔÔX l
)
ÔÔl m
;
ÔÔm n
if
ÒÒ 
(
ÒÒ 
result
ÒÒ 
!=
ÒÒ 
$str
ÒÒ #
)
ÒÒ# $
return
ÚÚ 

BadRequest
ÚÚ !
(
ÚÚ! "
)
ÚÚ" #
;
ÚÚ# $
return
ÙÙ 
Ok
ÙÙ 
(
ÙÙ 
new
ÙÙ 
{
ÙÙ 
response
ÙÙ $
=
ÙÙ% &
result
ÙÙ' -
}
ÙÙ. /
)
ÙÙ/ 0
;
ÙÙ0 1
}
ıı 	
[
¸¸ 	
HttpGet
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ 
)
˝˝ 
]
˝˝  
[
˛˛ 	
	Authorize
˛˛	 
(
˛˛ 
Roles
˛˛ 
=
˛˛ 
$str
˛˛ :
)
˛˛: ;
]
˛˛; <
public
ˇˇ 
async
ˇˇ 
Task
ˇˇ 
<
ˇˇ 
ActionResult
ˇˇ &
<
ˇˇ& '
IEnumerable
ˇˇ' 2
<
ˇˇ2 3$
AdministrationStaffDto
ˇˇ3 I
>
ˇˇI J
>
ˇˇJ K
>
ˇˇK L$
GetAdministrationStaff
ˇˇM c
(
ˇˇc d
)
ˇˇd e
{
ÄÄ 	
return
ÅÅ 
Ok
ÅÅ 
(
ÅÅ 
await
ÅÅ 
_adminService
ÅÅ )
.
ÅÅ) *$
GetAdministrationStaff
ÅÅ* @
(
ÅÅ@ A
)
ÅÅA B
)
ÅÅB C
;
ÅÅC D
}
ÇÇ 	
[
áá 	
HttpGet
áá	 
]
áá 
[
àà 	
Route
àà	 
(
àà 
$str
àà !
)
àà! "
]
àà" #
public
ââ 
async
ââ 
Task
ââ 
<
ââ 
ActionResult
ââ &
<
ââ& '
IEnumerable
ââ' 2
<
ââ2 3'
AdministrationCustomerDto
ââ3 L
>
ââL M
>
ââM N
>
ââN O(
GetAdministrationCustomers
ââP j
(
ââj k
)
ââk l
{
ää 	
return
ãã 
Ok
ãã 
(
ãã 
await
ãã 
_adminService
ãã )
.
ãã) *'
GetAdministrationCustomer
ãã* C
(
ããC D
)
ããD E
)
ããE F
;
ããF G
}
åå 	
[
ëë 	
HttpGet
ëë	 
]
ëë 
[
íí 	
Route
íí	 
(
íí 
$str
íí #
)
íí# $
]
íí$ %
[
ìì 	
	Authorize
ìì	 
(
ìì 
Roles
ìì 
=
ìì 
$str
ìì :
)
ìì: ;
]
ìì; <
public
îî 
async
îî 
Task
îî 
<
îî 
ActionResult
îî &
<
îî& '
IEnumerable
îî' 2
<
îî2 3'
AdministrationPartnersDto
îî3 L
>
îîL M
>
îîM N
>
îîN O&
GetAdministrationPartner
îîP h
(
îîh i
)
îîi j
{
ïï 	
return
ññ 
Ok
ññ 
(
ññ 
await
ññ 
_adminService
ññ )
.
ññ) *'
GetAdministrationPartners
ññ* C
(
ññC D
)
ññD E
)
ññE F
;
ññF G
}
óó 	
[
ùù 	
HttpGet
ùù	 
]
ùù 
[
ûû 	
Route
ûû	 
(
ûû 
$str
ûû 7
)
ûû7 8
]
ûû8 9
public
üü 
async
üü 
Task
üü 
<
üü 
ActionResult
üü &
<
üü& '
IEnumerable
üü' 2
<
üü2 3$
AdministrationStaffDto
üü3 I
>
üüI J
>
üüJ K
>
üüK L.
 GetAdministrationDepartmentStaff
üüM m
(
üüm n
int
üün q
departmentId
üür ~
)
üü~ 
{
†† 	
return
°° 
Ok
°° 
(
°° 
await
°° 
_adminService
°° )
.
°°) *.
 GetAdministrationDepartmentStaff
°°* J
(
°°J K
departmentId
°°K W
)
°°W X
)
°°X Y
;
°°Y Z
}
¢¢ 	
[
ßß 	
HttpGet
ßß	 
]
ßß 
[
®® 	
Route
®®	 
(
®® 
$str
®® 5
)
®®5 6
]
®®6 7
public
©© 
async
©© 
Task
©© 
<
©© 
ActionResult
©© &
<
©©& '
IEnumerable
©©' 2
<
©©2 3$
AdministrationStaffDto
©©3 I
>
©©I J
>
©©J K
>
©©K L2
$GetAdministrationDepartmentUnitStaff
©©M q
(
©©q r
int
©©r u
unitId
©©v |
)
©©| }
{
™™ 	
return
´´ 
Ok
´´ 
(
´´ 
await
´´ 
_adminService
´´ )
.
´´) *2
$GetAdministrationDepartmentUnitStaff
´´* N
(
´´N O
unitId
´´O U
)
´´U V
)
´´V W
;
´´W X
}
¨¨ 	
}
ØØ 
}∞∞ ¬‹
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v1/AccountController.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Controllers% 0
.0 1
v11 3
;3 4
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[ 
Produces 	
(	 

$str
 
) 
] 
[ 
EnableRateLimiting 
( 
$str '
)' (
]( )
[ 
	Authorize 

(
 !
AuthenticationSchemes  
=! "
JwtBearerDefaults# 4
.4 5 
AuthenticationScheme5 I
)I J
]J K
[ 
AllowAnonymous 
] 
public 
class 
AccountController 
:  
ControllerBase! /
{  
IUserAccountsService  
_userAccountsService -
;- .
IUnitOfWork 
_unitOfWork 
; 
Regex   	

emailRegex  
 
=   
new   
Regex    
(    !
$str  ! >
)  > ?
;  ? @
Regex!! 	

phoneRegex!!
 
=!! 
new!! 
Regex!!  
(!!  !
$str!!! d
)!!d e
;!!e f
public$$ 

AccountController$$ 
($$  
IUserAccountsService$$ 1
userAccountsService$$2 E
,$$E F
IUnitOfWork$$G R

unitOfWork$$S ]
)$$] ^
{%%  
_userAccountsService&& 
=&& 
userAccountsService&& 2
;&&2 3
_unitOfWork'' 
='' 

unitOfWork''  
;''  !
})) 
[.. 
HttpGet.. 
].. 
[// 
Route// 

(//
 
$str// #
)//# $
]//$ %
public00 

async00 
Task00 
<00 
ActionResult00 "
<00" #
IEnumerable00# .
<00. /
IdentificationType00/ A
>00A B
>00B C
>00C D"
GetIdentificationTypes00E [
(00[ \
)00\ ]
{11 
return22 
Ok22 
(22 
await22 
_unitOfWork22 #
.22# $
IdentificationType22$ 6
.226 7
GetAll227 =
(22= >
)22> ?
)22? @
;22@ A
}33 
[88 
HttpGet88 
]88 
[99 
Route99 

(99
 
$str99 
)99 
]99 
public:: 

async:: 
Task:: 
<:: 
ActionResult:: "
<::" #
IEnumerable::# .
<::. /
ChannelReadDto::/ =
>::= >
>::> ?
>::? @
GetChannels::A L
(::L M
)::M N
{;; 
return<< 
Ok<< 
(<< 
(<< 
await<< 
_unitOfWork<< $
.<<$ %
Channels<<% -
.<<- .
GetAll<<. 4
(<<4 5
)<<5 6
)<<6 7
.<<7 8
Select<<8 >
(<<> ?
c<<? @
=><<A C
new<<D G
ChannelReadDto<<H V
(<<V W
c<<W X
.<<X Y
	ChannelId<<Y b
,<<b c
c<<d e
.<<e f
ChannelName<<f q
!<<q r
)<<r s
)<<s t
)<<t u
;<<u v
}>> 
[EE 
HttpPostEE 
]EE 
[FF 
RouteFF 

(FF
 
$strFF 
)FF 
]FF  
[GG  
ProducesResponseTypeGG 
(GG 
$numGG 
,GG 
TypeGG #
=GG$ %
typeofGG& ,
(GG, -'
RegistrationSuccessResponseGG- H
)GGH I
)GGI J
]GGJ K
[HH  
ProducesResponseTypeHH 
(HH 
$numHH 
,HH 
TypeHH #
=HH$ %
typeofHH& ,
(HH, -%
RegistrationErrorResponseHH- F
)HHF G
)HHG H
]HHH I
[II  
ProducesResponseTypeII 
(II 
$numII 
,II 
TypeII #
=II$ %
typeofII& ,
(II, -%
RegistrationErrorResponseII- F
)IIF G
)IIG H
]IIH I
[JJ  
ProducesResponseTypeJJ 
(JJ 
$numJJ 
,JJ 
TypeJJ #
=JJ$ %
typeofJJ& ,
(JJ, -%
RegistrationErrorResponseJJ- F
)JJF G
)JJG H
]JJH I
publicKK 

asyncKK 
TaskKK 
<KK 
ActionResultKK "
>KK" #
RegisterKK$ ,
(KK, -
[KK- .
FromBodyKK. 6
]KK6 7*
CustomerRegistrationRequestDtoKK8 V
valuesKKW ]
)KK] ^
{LL 
ifMM 

(MM 

ModelStateMM 
.MM 
IsValidMM 
)MM 
{NN 	
varOO 
responseOO 
=OO 
awaitOO   
_userAccountsServiceOO! 5
.OO5 6$
CustomerUserRegistrationOO6 N
(OON O
valuesOOO U
)OOU V
;OOV W
ifQQ 
(QQ 
responseQQ 
.QQ 
	IsSuccessQQ "
==QQ# %
trueQQ& *
)QQ* +
{RR 
returnSS 

StatusCodeSS !
(SS! "
StatusCodesSS" -
.SS- .
Status201CreatedSS. >
,SS> ?
responseSS@ H
.SSH I
SuccessResponseSSI X
)SSX Y
;SSY Z
}TT 
varVV 
statusVV 
=VV 
responseVV !
.VV! "
ErrorResponseVV" /
!VV/ 0
.VV0 1

StatusCodeVV1 ;
;VV; <
switchXX 
(XX 
statusXX 
)XX 
{YY 
caseZZ 
$numZZ 
:ZZ 
return[[ 
	NoContent[[ $
([[$ %
)[[% &
;[[& '
case\\ 
$num\\ 
:\\ 
return]] 

BadRequest]] %
(]]% &
response]]& .
.]]. /
ErrorResponse]]/ <
)]]< =
;]]= >
case^^ 
$num^^ 
:^^ 
return__ 
NotFound__ #
(__# $
response__$ ,
.__, -
ErrorResponse__- :
)__: ;
;__; <
case`` 
$num`` 
:`` 
returnaa 
Conflictaa #
(aa# $
responseaa$ ,
.aa, -
ErrorResponseaa- :
)aa: ;
;aa; <
defaultbb 
:bb 
breakcc 
;cc 
}dd 
;dd 
}ff 	
returnhh 

BadRequesthh 
(hh 
)hh 
;hh 
}jj 
[qq 
HttpPostqq 
]qq 
[rr 
AllowAnonymousrr 
]rr 
[ss 
Routess 

(ss
 
$strss 
)ss 
]ss  
[tt  
ProducesResponseTypett 
(tt 
$numtt 
,tt 
Typett #
=tt$ %
typeoftt& ,
(tt, - 
RegistrationResponsett- A
)ttA B
)ttB C
]ttC D
publicuu 

asyncuu 
Taskuu 
<uu 
ActionResultuu "
<uu" # 
RegistrationResponseuu# 7
>uu7 8
>uu8 9
Registeruu: B
(uuB C
[uuC D
FromBodyuuD L
]uuL M-
!PartnerBankRegistrationRequestDtouuN o
valuesuup v
)uuv w
{vv 
ifww 

(ww 

ModelStateww 
.ww 
IsValidww 
)ww 
{xx 	
varyy 
responseyy 
=yy 
awaityy   
_userAccountsServiceyy! 5
.yy5 6#
PartnerUserRegistrationyy6 M
(yyM N
valuesyyN T
)yyT U
;yyU V
if{{ 
({{ 
response{{ 
.{{ 
	IsSuccess{{ "
=={{# %
true{{& *
){{* +
{|| 
return}} 

StatusCode}} !
(}}! "
StatusCodes}}" -
.}}- .
Status201Created}}. >
,}}> ?
response}}@ H
.}}H I
SuccessResponse}}I X
)}}X Y
;}}Y Z
}~~ 
var
ÄÄ 
status
ÄÄ 
=
ÄÄ 
response
ÄÄ !
.
ÄÄ! "
ErrorResponse
ÄÄ" /
!
ÄÄ/ 0
.
ÄÄ0 1

StatusCode
ÄÄ1 ;
;
ÄÄ; <
switch
ÇÇ 
(
ÇÇ 
status
ÇÇ 
)
ÇÇ 
{
ÉÉ 
case
ÑÑ 
$num
ÑÑ 
:
ÑÑ 
return
ÖÖ 
	NoContent
ÖÖ $
(
ÖÖ$ %
)
ÖÖ% &
;
ÖÖ& '
case
ÜÜ 
$num
ÜÜ 
:
ÜÜ 
return
áá 

BadRequest
áá %
(
áá% &
response
áá& .
.
áá. /
ErrorResponse
áá/ <
)
áá< =
;
áá= >
case
àà 
$num
àà 
:
àà 
return
ââ 
NotFound
ââ #
(
ââ# $
response
ââ$ ,
.
ââ, -
ErrorResponse
ââ- :
)
ââ: ;
;
ââ; <
case
ää 
$num
ää 
:
ää 
return
ãã 
Conflict
ãã #
(
ãã# $
response
ãã$ ,
.
ãã, -
ErrorResponse
ãã- :
)
ãã: ;
;
ãã; <
default
åå 
:
åå 
break
çç 
;
çç 
}
éé 
;
éé 
}
èè 	
return
ëë 

BadRequest
ëë 
(
ëë 
)
ëë 
;
ëë 
}
íí 
[
ôô 
HttpPost
ôô 
]
ôô 
[
öö 
Route
öö 

(
öö
 
$str
öö 
)
öö 
]
öö 
[
õõ 
	Authorize
õõ 
(
õõ 
Policy
õõ 
=
õõ 
$str
õõ 1
)
õõ1 2
]
õõ2 3
[
úú "
ProducesResponseType
úú 
(
úú 
$num
úú 
,
úú 
Type
úú #
=
úú$ %
typeof
úú& ,
(
úú, -)
RegistrationSuccessResponse
úú- H
)
úúH I
)
úúI J
]
úúJ K
[
ùù "
ProducesResponseType
ùù 
(
ùù 
$num
ùù 
,
ùù 
Type
ùù #
=
ùù$ %
typeof
ùù& ,
(
ùù, -'
RegistrationErrorResponse
ùù- F
)
ùùF G
)
ùùG H
]
ùùH I
[
ûû "
ProducesResponseType
ûû 
(
ûû 
$num
ûû 
,
ûû 
Type
ûû #
=
ûû$ %
typeof
ûû& ,
(
ûû, -'
RegistrationErrorResponse
ûû- F
)
ûûF G
)
ûûG H
]
ûûH I
[
üü "
ProducesResponseType
üü 
(
üü 
$num
üü 
,
üü 
Type
üü #
=
üü$ %
typeof
üü& ,
(
üü, -'
RegistrationErrorResponse
üü- F
)
üüF G
)
üüG H
]
üüH I
public
†† 

async
†† 
Task
†† 
<
†† 
ActionResult
†† "
<
††" #"
RegistrationResponse
††# 7
>
††7 8
>
††8 9
Register
††: B
(
††B C
[
††C D
FromBody
††D L
]
††L M)
StaffRegistrationRequestDto
††N i
values
††j p
)
††p q
{
°° 
if
¢¢ 

(
¢¢ 

ModelState
¢¢ 
.
¢¢ 
IsValid
¢¢ 
)
¢¢ 
{
££ 	
var
§§ 
response
§§ 
=
§§ 
await
§§  "
_userAccountsService
§§! 5
.
§§5 6#
StaffUserRegistration
§§6 K
(
§§K L
values
§§L R
)
§§R S
;
§§S T
if
¶¶ 
(
¶¶ 
response
¶¶ 
.
¶¶ 
	IsSuccess
¶¶ !
==
¶¶" $
true
¶¶% )
)
¶¶) *
{
ßß 
return
®® 

StatusCode
®® !
(
®®! "
StatusCodes
®®" -
.
®®- .
Status201Created
®®. >
,
®®> ?
response
®®@ H
.
®®H I
SuccessResponse
®®I X
)
®®X Y
;
®®Y Z
}
©© 
var
´´ 
status
´´ 
=
´´ 
response
´´ !
.
´´! "
ErrorResponse
´´" /
!
´´/ 0
.
´´0 1

StatusCode
´´1 ;
;
´´; <
switch
≠≠ 
(
≠≠ 
status
≠≠ 
)
≠≠ 
{
ÆÆ 
case
ØØ 
$num
ØØ 
:
ØØ 
return
∞∞ 
	NoContent
∞∞ $
(
∞∞$ %
)
∞∞% &
;
∞∞& '
case
±± 
$num
±± 
:
±± 
return
≤≤ 

BadRequest
≤≤ %
(
≤≤% &
response
≤≤& .
.
≤≤. /
ErrorResponse
≤≤/ <
)
≤≤< =
;
≤≤= >
case
≥≥ 
$num
≥≥ 
:
≥≥ 
return
¥¥ 
NotFound
¥¥ #
(
¥¥# $
response
¥¥$ ,
.
¥¥, -
ErrorResponse
¥¥- :
)
¥¥: ;
;
¥¥; <
case
µµ 
$num
µµ 
:
µµ 
return
∂∂ 
Conflict
∂∂ #
(
∂∂# $
response
∂∂$ ,
.
∂∂, -
ErrorResponse
∂∂- :
)
∂∂: ;
;
∂∂; <
default
∑∑ 
:
∑∑ 
break
∏∏ 
;
∏∏ 
}
ππ 
;
ππ 
}
ªª 	
return
ΩΩ 

BadRequest
ΩΩ 
(
ΩΩ 
)
ΩΩ 
;
ΩΩ 
}
ææ 
[
ƒƒ 
HttpPost
ƒƒ 
]
ƒƒ 
[
≈≈ 
AllowAnonymous
≈≈ 
]
≈≈ 
[
∆∆ 
Route
∆∆ 

(
∆∆
 
$str
∆∆ 
)
∆∆ 
]
∆∆ 
public
«« 

async
«« 
Task
«« 
<
«« 
IActionResult
«« #
>
««# $
ChangePassword
««% 3
(
««3 4
[
««4 5
FromBody
««5 =
]
««= >&
ChangePasswordRequestDto
««? W'
changeUserPasswordRequest
««X q
)
««q r
{
»» 
try
…… 
{
   	
if
ÀÀ 
(
ÀÀ 

ModelState
ÀÀ 
.
ÀÀ 
IsValid
ÀÀ "
)
ÀÀ" #
{
ÃÃ 
var
ÕÕ 
changeResult
ÕÕ  
=
ÕÕ! "
await
ÕÕ# ("
_userAccountsService
ÕÕ) =
.
ÕÕ= >
ChangePassword
ÕÕ> L
(
ÕÕL M'
changeUserPasswordRequest
ÕÕM f
)
ÕÕf g
;
ÕÕg h
if
ŒŒ 
(
ŒŒ 
changeResult
ŒŒ  
.
ŒŒ  !
	IsSuccess
ŒŒ! *
)
ŒŒ* +
{
œœ 
return
–– 
Ok
–– 
(
–– 
changeResult
–– *
)
––* +
;
––+ ,
}
—— 
var
”” 
status
”” 
=
”” 
changeResult
”” )
.
””) *
ErrorResponse
””* 7
!
””7 8
.
””8 9

StatusCode
””9 C
;
””C D
switch
’’ 
(
’’ 
status
’’ 
)
’’ 
{
÷÷ 
case
◊◊ 
$num
◊◊ 
:
◊◊ 
return
ÿÿ 
	NoContent
ÿÿ (
(
ÿÿ( )
)
ÿÿ) *
;
ÿÿ* +
case
ŸŸ 
$num
ŸŸ 
:
ŸŸ 
return
⁄⁄ 

BadRequest
⁄⁄ )
(
⁄⁄) *
changeResult
⁄⁄* 6
.
⁄⁄6 7
ErrorResponse
⁄⁄7 D
)
⁄⁄D E
;
⁄⁄E F
case
€€ 
$num
€€ 
:
€€ 
return
‹‹ 
NotFound
‹‹ '
(
‹‹' (
changeResult
‹‹( 4
.
‹‹4 5
ErrorResponse
‹‹5 B
)
‹‹B C
;
‹‹C D
case
›› 
$num
›› 
:
›› 
return
ﬁﬁ 
Conflict
ﬁﬁ '
(
ﬁﬁ' (
changeResult
ﬁﬁ( 4
.
ﬁﬁ4 5
ErrorResponse
ﬁﬁ5 B
)
ﬁﬁB C
;
ﬁﬁC D
default
ﬂﬂ 
:
ﬂﬂ 
return
‡‡ 

StatusCode
‡‡ )
(
‡‡) *
$num
‡‡* -
,
‡‡- .
changeResult
‡‡/ ;
)
‡‡; <
;
‡‡< =
}
·· 
;
·· 
}
„„ 
return
ÂÂ 

BadRequest
ÂÂ 
(
ÂÂ 
)
ÂÂ 
;
ÂÂ  
}
ÊÊ 	
catch
ÁÁ 
(
ÁÁ 
	Exception
ÁÁ 
ex
ÁÁ 
)
ÁÁ 
{
ËË 	
return
ÈÈ 

StatusCode
ÈÈ 
(
ÈÈ 
$num
ÈÈ !
,
ÈÈ! "
ex
ÈÈ# %
.
ÈÈ% &
Message
ÈÈ& -
)
ÈÈ- .
;
ÈÈ. /
}
ÍÍ 	
}
ÎÎ 
[
 
HttpPost
 
]
 
[
ÒÒ 
AllowAnonymous
ÒÒ 
]
ÒÒ 
[
ÚÚ 
Route
ÚÚ 

(
ÚÚ
 
$str
ÚÚ 
)
ÚÚ 
]
ÚÚ 
public
ÛÛ 

async
ÛÛ 
Task
ÛÛ 
<
ÛÛ 
IActionResult
ÛÛ #
>
ÛÛ# $
ResetPassword
ÛÛ% 2
(
ÛÛ2 3
[
ÛÛ3 4
FromBody
ÛÛ4 <
]
ÛÛ< =%
ResetPasswordRequestDto
ÛÛ> U"
resetPasswordRequest
ÛÛV j
)
ÛÛj k
{
ÙÙ 
try
ıı 
{
ˆˆ 	#
ResetPasswordResponse
˜˜ !
changeResult
˜˜" .
=
˜˜/ 0
null
˜˜1 5
!
˜˜5 6
;
˜˜7 8
if
˘˘ 
(
˘˘ 

ModelState
˘˘ 
.
˘˘ 
IsValid
˘˘ "
)
˘˘" #
{
˙˙ %
ResetPasswordRequestDto
¸¸ '
passwordRequest
¸¸( 7
=
¸¸8 9
new
¸¸: =%
ResetPasswordRequestDto
¸¸> U
{
˝˝ 
Phone_OR_Email
˛˛ "
=
˛˛# $"
resetPasswordRequest
˛˛% 9
.
˛˛9 :
Phone_OR_Email
˛˛: H
,
˛˛H I
Token
ˇˇ 
=
ˇˇ "
resetPasswordRequest
ˇˇ 0
.
ˇˇ0 1
Token
ˇˇ1 6
,
ˇˇ6 7
NewPassword
ÄÄ 
=
ÄÄ  !"
resetPasswordRequest
ÄÄ" 6
.
ÄÄ6 7
NewPassword
ÄÄ7 B
,
ÄÄB C 
ConfirmNewPassword
ÅÅ &
=
ÅÅ' ("
resetPasswordRequest
ÅÅ) =
.
ÅÅ= > 
ConfirmNewPassword
ÅÅ> P
}
ÇÇ 
;
ÇÇ 
if
ÖÖ 
(
ÖÖ 

emailRegex
ÖÖ 
.
ÖÖ 
IsMatch
ÖÖ &
(
ÖÖ& '"
resetPasswordRequest
ÖÖ' ;
.
ÖÖ; <
Phone_OR_Email
ÖÖ< J
!
ÖÖJ K
)
ÖÖK L
)
ÖÖL M
{
ÜÜ 
changeResult
áá  
=
áá! "
await
áá# ("
_userAccountsService
áá) =
.
áá= >*
ResetPasswordViaEmailAddress
áá> Z
(
ááZ [
passwordRequest
áá[ j
)
ááj k
;
áák l
}
àà 
if
ãã 
(
ãã 

phoneRegex
ãã 
.
ãã 
IsMatch
ãã &
(
ãã& '"
resetPasswordRequest
ãã' ;
.
ãã; <
Phone_OR_Email
ãã< J
!
ããJ K
)
ããK L
)
ããL M
{
åå 
changeResult
çç  
=
çç! "
await
çç# ("
_userAccountsService
çç) =
.
çç= >/
!ResetPasswordViaMobilePhoneNumber
çç> _
(
çç_ `
passwordRequest
çç` o
)
çço p
;
ççp q
}
éé 
if
êê 
(
êê 
changeResult
êê  
.
êê  !
	IsSuccess
êê! *
)
êê* +
{
ëë 
return
íí 
Ok
íí 
(
íí 
changeResult
íí *
.
íí* +
SuccessResponse
íí+ :
)
íí: ;
;
íí; <
}
ìì 
var
ïï 
status
ïï 
=
ïï 
changeResult
ïï )
.
ïï) *
ErrorResponse
ïï* 7
!
ïï7 8
.
ïï8 9

StatusCode
ïï9 C
;
ïïC D
switch
óó 
(
óó 
status
óó 
)
óó 
{
òò 
case
ôô 
$num
ôô 
:
ôô 
return
öö 
	NoContent
öö (
(
öö( )
)
öö) *
;
öö* +
case
õõ 
$num
õõ 
:
õõ 
return
úú 

BadRequest
úú )
(
úú) *
changeResult
úú* 6
.
úú6 7
ErrorResponse
úú7 D
)
úúD E
;
úúE F
case
ùù 
$num
ùù 
:
ùù 
return
ûû 
NotFound
ûû '
(
ûû' (
changeResult
ûû( 4
.
ûû4 5
ErrorResponse
ûû5 B
)
ûûB C
;
ûûC D
case
üü 
$num
üü 
:
üü 
return
†† 
Conflict
†† '
(
††' (
changeResult
††( 4
.
††4 5
ErrorResponse
††5 B
)
††B C
;
††C D
default
°° 
:
°° 
return
¢¢ 

StatusCode
¢¢ )
(
¢¢) *
$num
¢¢* -
,
¢¢- .
changeResult
¢¢/ ;
)
¢¢; <
;
¢¢< =
}
££ 
;
££ 
}
•• 
return
ßß 

BadRequest
ßß 
(
ßß 
)
ßß 
;
ßß  
}
®® 	
catch
©© 
(
©© 
	Exception
©© 
ex
©© 
)
©© 
{
™™ 	
return
´´ 

StatusCode
´´ 
(
´´ 
$num
´´ !
,
´´! "
ex
´´# %
.
´´% &
Message
´´& -
)
´´- .
;
´´. /
}
¨¨ 	
}
≠≠ 
[
µµ 
HttpPost
µµ 
]
µµ 
[
∂∂ 
AllowAnonymous
∂∂ 
]
∂∂ 
[
∑∑ 
Route
∑∑ 

(
∑∑
 
$str
∑∑ 
)
∑∑ 
]
∑∑ 
[
∏∏ "
ProducesResponseType
∏∏ 
(
∏∏ 
$num
∏∏ 
,
∏∏ 
Type
∏∏ #
=
∏∏$ %
typeof
∏∏& ,
(
∏∏, -
LoginResponseDto
∏∏- =
)
∏∏= >
)
∏∏> ?
]
∏∏? @
public
ππ 

async
ππ 
Task
ππ 
<
ππ 
IActionResult
ππ #
>
ππ# $
	UserLogin
ππ% .
(
ππ. /
[
ππ/ 0
FromBody
ππ0 8
]
ππ8 9
LoginRequestDto
ππ: I

loginModel
ππJ T
)
ππT U
{
∫∫ 
try
ªª 
{
ºº 	
if
ΩΩ 
(
ΩΩ 

ModelState
ΩΩ 
.
ΩΩ 
IsValid
ΩΩ "
)
ΩΩ" #
{
ææ 
LoginRequestDto
¿¿ 
loginRequest
¿¿  ,
=
¿¿- .
new
¿¿/ 2
LoginRequestDto
¿¿3 B
{
¡¡ 
Phone_OR_Email
¬¬ "
=
¬¬# $

loginModel
¬¬% /
.
¬¬/ 0
Phone_OR_Email
¬¬0 >
,
¬¬> ?
Password
√√ 
=
√√ 

loginModel
√√ )
.
√√) *
Password
√√* 2
}
ƒƒ 
;
ƒƒ 
if
∆∆ 
(
∆∆ 

emailRegex
∆∆ 
.
∆∆ 
IsMatch
∆∆ &
(
∆∆& '

loginModel
∆∆' 1
.
∆∆1 2
Phone_OR_Email
∆∆2 @
!
∆∆@ A
)
∆∆A B
)
∆∆B C
{
«« 
var
»» 
result
»» 
=
»»  
await
»»! &"
_userAccountsService
»»' ;
.
»»; <#
LoginWithEmailAddress
»»< Q
(
»»Q R
loginRequest
»»R ^
)
»»^ _
;
»»_ `
switch
   
(
   
result
   "
.
  " #
LoginStatus
  # .
)
  . /
{
ÀÀ 
case
ÃÃ 
true
ÃÃ !
:
ÃÃ! "
return
ÕÕ "
Ok
ÕÕ# %
(
ÕÕ% &
result
ÕÕ& ,
)
ÕÕ, -
;
ÕÕ- .
case
ŒŒ 
false
ŒŒ "
:
ŒŒ" #
var
œœ 
status
œœ  &
=
œœ' (
result
œœ) /
.
œœ/ 0
errorResponse
œœ0 =
!
œœ= >
.
œœ> ?

StatusCode
œœ? I
;
œœI J
return
—— "
status
——# )
switch
——* 0
{
““ 
$num
””  #
=>
””$ &
	NoContent
””' 0
(
””0 1
)
””1 2
,
””2 3
$num
‘‘  #
=>
‘‘$ &

BadRequest
‘‘' 1
(
‘‘1 2
result
‘‘2 8
.
‘‘8 9
errorResponse
‘‘9 F
)
‘‘F G
,
‘‘G H
$num
’’  #
=>
’’$ &
NotFound
’’' /
(
’’/ 0
result
’’0 6
.
’’6 7
errorResponse
’’7 D
)
’’D E
,
’’E F
$num
÷÷  #
=>
÷÷$ &
Conflict
÷÷' /
(
÷÷/ 0
result
÷÷0 6
.
÷÷6 7
errorResponse
÷÷7 D
)
÷÷D E
,
÷÷E F
$num
◊◊  #
=>
◊◊$ &

StatusCode
◊◊' 1
(
◊◊1 2
$num
◊◊2 5
,
◊◊5 6
result
◊◊7 =
.
◊◊= >
errorResponse
◊◊> K
)
◊◊K L
,
◊◊L M
_
ÿÿ  !
=>
ÿÿ" $

StatusCode
ÿÿ% /
(
ÿÿ/ 0
$num
ÿÿ0 3
,
ÿÿ3 4
result
ÿÿ5 ;
)
ÿÿ; <
,
ÿÿ< =
}
ŸŸ 
;
ŸŸ 
}
‹‹ 
}
›› 
if
ﬂﬂ 
(
ﬂﬂ 

phoneRegex
ﬂﬂ 
.
ﬂﬂ 
IsMatch
ﬂﬂ &
(
ﬂﬂ& '

loginModel
ﬂﬂ' 1
.
ﬂﬂ1 2
Phone_OR_Email
ﬂﬂ2 @
!
ﬂﬂ@ A
)
ﬂﬂA B
)
ﬂﬂB C
{
‡‡ 
var
·· 
result
·· 
=
··  
await
··! &"
_userAccountsService
··' ;
.
··; <(
LoginWithMobilePhoneNumber
··< V
(
··V W
loginRequest
··W c
)
··c d
;
··d e
switch
„„ 
(
„„ 
result
„„ "
.
„„" #
LoginStatus
„„# .
)
„„. /
{
‰‰ 
case
ÂÂ 
true
ÂÂ !
:
ÂÂ! "
return
ÊÊ "
Ok
ÊÊ# %
(
ÊÊ% &
result
ÊÊ& ,
)
ÊÊ, -
;
ÊÊ- .
case
ÁÁ 
false
ÁÁ "
:
ÁÁ" #
var
ËË 
status
ËË  &
=
ËË' (
result
ËË) /
.
ËË/ 0
errorResponse
ËË0 =
!
ËË= >
.
ËË> ?

StatusCode
ËË? I
;
ËËI J
return
ÍÍ "
status
ÍÍ# )
switch
ÍÍ* 0
{
ÎÎ 
$num
ÏÏ  #
=>
ÏÏ$ &
	NoContent
ÏÏ' 0
(
ÏÏ0 1
)
ÏÏ1 2
,
ÏÏ2 3
$num
ÌÌ  #
=>
ÌÌ$ &

BadRequest
ÌÌ' 1
(
ÌÌ1 2
result
ÌÌ2 8
.
ÌÌ8 9
errorResponse
ÌÌ9 F
)
ÌÌF G
,
ÌÌG H
$num
ÓÓ  #
=>
ÓÓ$ &
NotFound
ÓÓ' /
(
ÓÓ/ 0
result
ÓÓ0 6
.
ÓÓ6 7
errorResponse
ÓÓ7 D
)
ÓÓD E
,
ÓÓE F
$num
ÔÔ  #
=>
ÔÔ$ &
Conflict
ÔÔ' /
(
ÔÔ/ 0
result
ÔÔ0 6
.
ÔÔ6 7
errorResponse
ÔÔ7 D
)
ÔÔD E
,
ÔÔE F
$num
  #
=>
$ &

StatusCode
' 1
(
1 2
$num
2 5
,
5 6
result
7 =
.
= >
errorResponse
> K
)
K L
,
L M
_
ÒÒ  !
=>
ÒÒ" $

StatusCode
ÒÒ% /
(
ÒÒ/ 0
$num
ÒÒ0 3
,
ÒÒ3 4
result
ÒÒ5 ;
)
ÒÒ; <
,
ÒÒ< =
}
ÚÚ 
;
ÚÚ 
}
ÛÛ 
}
ÙÙ 
}
˜˜ 
return
˘˘ 

BadRequest
˘˘ 
(
˘˘ 
new
˘˘ !
{
˘˘" #

statusCode
˘˘# -
=
˘˘. /
$num
˘˘0 3
,
˘˘3 4
message
˘˘5 <
=
˘˘= >
$str
˘˘? q
}
˘˘r s
)
˘˘s t
;
˘˘t u
}
˙˙ 	
catch
˚˚ 
(
˚˚ 
	Exception
˚˚ 
ex
˚˚ 
)
˚˚ 
{
¸¸ 	
return
˝˝ 

StatusCode
˝˝ 
(
˝˝ 
$num
˝˝ !
,
˝˝! "
ex
˝˝# %
.
˝˝% &
Message
˝˝& -
)
˝˝- .
;
˝˝. /
}
˛˛ 	
}
ˇˇ 
[
ÑÑ 
HttpPost
ÑÑ 
]
ÑÑ 
[
ÖÖ 
AllowAnonymous
ÖÖ 
]
ÖÖ 
[
ÜÜ 
Route
ÜÜ 

(
ÜÜ
 
$str
ÜÜ 
)
ÜÜ 
]
ÜÜ 
[
áá "
ProducesResponseType
áá 
(
áá 
$num
áá 
,
áá 
Type
áá #
=
áá$ %
typeof
áá& ,
(
áá, -%
RefreshTokenResponseDto
áá- D
)
ááD E
)
ááE F
]
ááF G
public
àà 

async
àà 
Task
àà 
<
àà 
IActionResult
àà #
>
àà# $
RefreshToken
àà% 1
(
àà1 2
[
àà2 3
FromBody
àà3 ;
]
àà; <$
RefreshTokenRequestDto
àà= S
request
ààT [
)
àà[ \
{
ââ 
try
ää 
{
ãã 	
if
åå 
(
åå 

ModelState
åå 
.
åå 
IsValid
åå "
)
åå" #
{
çç 
var
éé 
result
éé 
=
éé 
await
éé #"
_userAccountsService
éé$ 8
.
éé8 9 
RefreshBearerToken
éé9 K
(
ééK L
request
ééL S
)
ééS T
;
ééT U
if
èè 
(
èè 
result
èè 
.
èè 
	IsSuccess
èè $
)
èè$ %
{
êê 
return
ëë 
Ok
ëë 
(
ëë 
result
ëë $
.
ëë$ %
SuccessResponse
ëë% 4
)
ëë4 5
;
ëë5 6
}
íí 
var
îî 
status
îî 
=
îî 
result
îî #
.
îî# $
ErrorResponse
îî$ 1
!
îî1 2
.
îî2 3

StatusCode
îî3 =
;
îî= >
return
ïï 
status
ïï 
switch
ïï $
{
ññ 
$num
óó 
=>
óó 

BadRequest
óó %
(
óó% &
result
óó& ,
.
óó, -
ErrorResponse
óó- :
)
óó: ;
,
óó; <
$num
òò 
=>
òò 
NotFound
òò #
(
òò# $
result
òò$ *
.
òò* +
ErrorResponse
òò+ 8
)
òò8 9
,
òò9 :
$num
ôô 
=>
ôô 

StatusCode
ôô %
(
ôô% &
$num
ôô& )
,
ôô) *
result
ôô+ 1
.
ôô1 2
ErrorResponse
ôô2 ?
)
ôô? @
,
ôô@ A
_
öö 
=>
öö 

StatusCode
öö #
(
öö# $
$num
öö$ '
,
öö' (
result
öö) /
)
öö/ 0
,
öö0 1
}
õõ 
;
õõ 
}
úú 
return
ûû 

BadRequest
ûû 
(
ûû 
)
ûû 
;
ûû  
}
üü 	
catch
†† 
(
†† 
	Exception
†† 
ex
†† 
)
†† 
{
°° 	
return
¢¢ 

StatusCode
¢¢ 
(
¢¢ 
$num
¢¢ !
,
¢¢! "
ex
¢¢# %
.
¢¢% &
Message
¢¢& -
)
¢¢- .
;
¢¢. /
}
££ 	
}
§§ 
[
©© 
HttpGet
©© 
]
©© 
[
™™ 
Route
™™ 

(
™™
 
$str
™™ 
)
™™ 
]
™™ 
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
>
¨¨" #
UserDetails
¨¨$ /
(
¨¨/ 0
string
¨¨0 6
userId
¨¨7 =
)
¨¨= >
{
≠≠ 
var
ÆÆ 
user
ÆÆ 
=
ÆÆ 
await
ÆÆ 
_unitOfWork
ÆÆ $
.
ÆÆ$ %
Users
ÆÆ% *
.
ÆÆ* +
Get
ÆÆ+ .
(
ÆÆ. /
u
ÆÆ/ 0
=>
ÆÆ1 3
u
ÆÆ4 5
.
ÆÆ5 6
Id
ÆÆ6 8
==
ÆÆ9 ;
userId
ÆÆ< B
)
ÆÆB C
;
ÆÆC D
if
ØØ 

(
ØØ 
user
ØØ 
is
ØØ 
null
ØØ 
)
ØØ 
return
∞∞ 
NotFound
∞∞ 
(
∞∞ 
new
∞∞ 
{
∞∞  !
message
∞∞" )
=
∞∞* +
$str
∞∞, ?
}
∞∞@ A
)
∞∞A B
;
∞∞B C
return
≤≤ 
Ok
≤≤ 
(
≤≤ 
await
≤≤ "
_userAccountsService
≤≤ ,
.
≤≤, -
UserDetails
≤≤- 8
(
≤≤8 9
userId
≤≤9 ?
)
≤≤? @
)
≤≤@ A
;
≤≤A B
}
≥≥ 
[
∏∏ 
HttpPost
∏∏ 
]
∏∏ 
[
ππ 
AllowAnonymous
ππ 
]
ππ 
[
∫∫ 
Route
∫∫ 

(
∫∫
 
$str
∫∫ 
)
∫∫ 
]
∫∫ 
[
ªª "
ProducesResponseType
ªª 
(
ªª 
$num
ªª 
,
ªª 
Type
ªª #
=
ªª$ %
typeof
ªª& ,
(
ªª, -
TokenResponseDto
ªª- =
)
ªª= >
)
ªª> ?
]
ªª? @
public
ºº 

async
ºº 
Task
ºº 
<
ºº 
IActionResult
ºº #
>
ºº# $
SendOTPToken
ºº% 1
(
ºº1 2
[
ºº2 3
FromBody
ºº3 ;
]
ºº; <&
TokenRequestParameterDto
ºº= U
value
ººV [
)
ºº[ \
{
ΩΩ 
try
ææ 
{
øø 	
if
¿¿ 
(
¿¿ 
string
¿¿ 
.
¿¿  
IsNullOrWhiteSpace
¿¿ )
(
¿¿) *
value
¿¿* /
.
¿¿/ 0
phone_OR_email
¿¿0 >
)
¿¿> ?
)
¿¿? @
{
¡¡ 
return
¬¬ 

BadRequest
¬¬ !
(
¬¬! "
)
¬¬" #
;
¬¬# $
}
√√ 
if
≈≈ 
(
≈≈ 

ModelState
≈≈ 
.
≈≈ 
IsValid
≈≈ "
)
≈≈" #
{
∆∆ 
if
«« 
(
«« 

emailRegex
«« 
.
«« 
IsMatch
«« &
(
««& '
value
««' ,
.
««, -
phone_OR_email
««- ;
!
««; <
)
««< =
)
««= >
{
»» 
var
…… 
result
…… 
=
……  
await
……! &
_unitOfWork
……' 2
.
……2 3

TokenStore
……3 =
.
……= >
GetToken
……> F
(
……F G
value
……G L
.
……L M
phone_OR_email
……M [
!
……[ \
,
……\ ]
$num
……^ _
)
……_ `
;
……` a
if
   
(
   
result
   
.
   
Length
   $
!=
  % '
$num
  ( )
)
  ) *
{
ÀÀ 
return
ÃÃ 
NotFound
ÃÃ '
(
ÃÃ' (
new
ÃÃ( +
{
ÃÃ, -
message
ÃÃ. 5
=
ÃÃ6 7
result
ÃÃ8 >
}
ÃÃ? @
)
ÃÃ@ A
;
ÃÃA B
}
ÕÕ 
return
ŒŒ 
Ok
ŒŒ 
(
ŒŒ 
new
ŒŒ !
TokenResponseDto
ŒŒ" 2
(
ŒŒ2 3
result
ŒŒ3 9
)
ŒŒ9 :
)
ŒŒ: ;
;
ŒŒ; <
}
œœ 
if
““ 
(
““ 

phoneRegex
““ 
.
““ 
IsMatch
““ &
(
““& '
value
““' ,
.
““, -
phone_OR_email
““- ;
!
““; <
)
““< =
)
““= >
{
”” 
var
‘‘ 
result
‘‘ 
=
‘‘  
await
‘‘! &
_unitOfWork
‘‘' 2
.
‘‘2 3

TokenStore
‘‘3 =
.
‘‘= >
GetToken
‘‘> F
(
‘‘F G
value
‘‘G L
.
‘‘L M
phone_OR_email
‘‘M [
!
‘‘[ \
,
‘‘\ ]
$num
‘‘^ _
)
‘‘_ `
;
‘‘` a
if
’’ 
(
’’ 
result
’’ 
.
’’ 
Length
’’ %
!=
’’& (
$num
’’) *
)
’’* +
{
÷÷ 
return
◊◊ 
NotFound
◊◊ '
(
◊◊' (
new
◊◊( +
{
◊◊, -
message
◊◊. 5
=
◊◊6 7
result
◊◊8 >
}
◊◊? @
)
◊◊@ A
;
◊◊A B
}
ÿÿ 
return
ŸŸ 
Ok
ŸŸ 
(
ŸŸ 
new
ŸŸ !
TokenResponseDto
ŸŸ" 2
(
ŸŸ2 3
result
ŸŸ3 9
)
ŸŸ9 :
)
ŸŸ: ;
;
ŸŸ; <
}
⁄⁄ 
}
€€ 
return
›› 
NotFound
›› 
(
›› 
new
›› 
{
››  !
message
››! (
=
››) *
$str
››+ b
}
››c d
)
››d e
;
››e f
}
ﬁﬁ 	
catch
ﬂﬂ 
(
ﬂﬂ 
	Exception
ﬂﬂ 
ex
ﬂﬂ 
)
ﬂﬂ 
{
‡‡ 	
return
·· 

StatusCode
·· 
(
·· 
$num
·· !
,
··! "
ex
··# %
.
··% &
Message
··& -
)
··- .
;
··. /
}
‚‚ 	
}
„„ 
[
ËË 
HttpPost
ËË 
]
ËË 
[
ÈÈ 
AllowAnonymous
ÈÈ 
]
ÈÈ 
[
ÍÍ 
Route
ÍÍ 

(
ÍÍ
 
$str
ÍÍ 
)
ÍÍ 
]
ÍÍ 
[
ÎÎ "
ProducesResponseType
ÎÎ 
(
ÎÎ 
$num
ÎÎ 
,
ÎÎ 
Type
ÎÎ #
=
ÎÎ$ %
typeof
ÎÎ& ,
(
ÎÎ, -
TokenResponseDto
ÎÎ- =
)
ÎÎ= >
)
ÎÎ> ?
]
ÎÎ? @
public
ÏÏ 

async
ÏÏ 
Task
ÏÏ 
<
ÏÏ 
IActionResult
ÏÏ #
>
ÏÏ# $
VerifyOTPToken
ÏÏ% 3
(
ÏÏ3 4
[
ÏÏ4 5
FromBody
ÏÏ5 =
]
ÏÏ= >#
VerifyTokenRequestDto
ÏÏ? T 
verifyTokenRequest
ÏÏU g
)
ÏÏg h
{
ÌÌ 
try
ÓÓ 
{
ÔÔ 	
if
 
(
 
string
 
.
  
IsNullOrWhiteSpace
 (
(
( ) 
verifyTokenRequest
) ;
.
; <
phone_OR_email
< J
)
J K
||
L N
string
O U
.
U V 
IsNullOrWhiteSpace
V h
(
h i 
verifyTokenRequest
i {
.
{ |
token| Å
)Å Ç
)Ç É
{
ÒÒ 
return
ÚÚ 

BadRequest
ÚÚ !
(
ÚÚ! "
)
ÚÚ" #
;
ÚÚ# $
}
ÛÛ 
if
ıı 
(
ıı 

ModelState
ıı 
.
ıı 
IsValid
ıı "
)
ıı" #
{
ˆˆ 
if
¯¯ 
(
¯¯ 

emailRegex
¯¯ 
.
¯¯ 
IsMatch
¯¯ &
(
¯¯& ' 
verifyTokenRequest
¯¯' 9
.
¯¯9 :
phone_OR_email
¯¯: H
!
¯¯H I
)
¯¯I J
)
¯¯J K
{
˘˘ 
var
˙˙ 
result
˙˙ 
=
˙˙  
await
˙˙! &
_unitOfWork
˙˙' 2
.
˙˙2 3

TokenStore
˙˙3 =
.
˙˙= >
VerifyToken
˙˙> I
(
˙˙I J 
verifyTokenRequest
˙˙J \
.
˙˙\ ]
phone_OR_email
˙˙] k
,
˙˙k l 
verifyTokenRequest
˙˙m 
.˙˙ Ä
token˙˙Ä Ö
)˙˙Ö Ü
;˙˙Ü á
if
˚˚ 
(
˚˚ 
result
˚˚ 
!=
˚˚  
$str
˚˚! +
)
˚˚+ ,
{
¸¸ 
return
˝˝ 

BadRequest
˝˝ )
(
˝˝) *
new
˝˝* -
{
˝˝. /
message
˝˝0 7
=
˝˝8 9
result
˝˝: @
}
˝˝A B
)
˝˝B C
;
˝˝C D
}
˛˛ 
return
ˇˇ 
Ok
ˇˇ 
(
ˇˇ 
new
ˇˇ !
{
ˇˇ" #
message
ˇˇ$ +
=
ˇˇ, -
result
ˇˇ. 4
}
ˇˇ5 6
)
ˇˇ6 7
;
ˇˇ7 8
}
ÄÄ 
if
ÉÉ 
(
ÉÉ 

phoneRegex
ÉÉ 
.
ÉÉ 
IsMatch
ÉÉ &
(
ÉÉ& ' 
verifyTokenRequest
ÉÉ' 9
.
ÉÉ9 :
phone_OR_email
ÉÉ: H
!
ÉÉH I
)
ÉÉI J
)
ÉÉJ K
{
ÑÑ 
var
ÖÖ 
result
ÖÖ 
=
ÖÖ  
await
ÖÖ! &
_unitOfWork
ÖÖ' 2
.
ÖÖ2 3

TokenStore
ÖÖ3 =
.
ÖÖ= >
VerifyToken
ÖÖ> I
(
ÖÖI J 
verifyTokenRequest
ÖÖJ \
.
ÖÖ\ ]
phone_OR_email
ÖÖ] k
,
ÖÖk l 
verifyTokenRequest
ÖÖm 
.ÖÖ Ä
tokenÖÖÄ Ö
)ÖÖÖ Ü
;ÖÖÜ á
if
ÜÜ 
(
ÜÜ 
result
ÜÜ 
!=
ÜÜ !
$str
ÜÜ" ,
)
ÜÜ, -
{
áá 
return
àà 

BadRequest
àà )
(
àà) *
new
àà* -
{
àà. /
message
àà0 7
=
àà8 9
result
àà: @
}
ààA B
)
ààB C
;
ààC D
}
ââ 
return
ää 
Ok
ää 
(
ää 
new
ää !
{
ää" #
message
ää$ +
=
ää, -
result
ää. 4
}
ää5 6
)
ää6 7
;
ää7 8
}
ãã 
}
çç 
return
èè 
NotFound
èè 
(
èè 
)
èè 
;
èè 
}
êê 	
catch
ëë 
(
ëë 
	Exception
ëë 
ex
ëë 
)
ëë 
{
íí 	
return
ìì 

StatusCode
ìì 
(
ìì 
$num
ìì !
,
ìì! "
ex
ìì# %
.
ìì% &
Message
ìì& -
)
ìì- .
;
ìì. /
}
îî 	
}
ññ 
[
õõ 
HttpPut
õõ 
]
õõ 
[
úú 
AllowAnonymous
úú 
]
úú 
[
ùù 
Route
ùù 

(
ùù
 
$str
ùù 
)
ùù 
]
ùù  
[
ûû "
ProducesResponseType
ûû 
(
ûû 
$num
ûû 
,
ûû 
Type
ûû #
=
ûû$ %
typeof
ûû& ,
(
ûû, - 
UserInformationDto
ûû- ?
)
ûû? @
)
ûû@ A
]
ûûA B
public
üü 

async
üü 
Task
üü 
<
üü 
IActionResult
üü #
>
üü# $
UpdateUserAccount
üü% 6
(
üü6 7
[
üü7 8
FromBody
üü8 @
]
üü@ A
UpdateUserDto
üüB O
UserUpdateRequest
üüP a
)
üüa b
{
†† 
try
°° 
{
¢¢ 	
if
££ 
(
££ 

ModelState
££ 
.
££ 
IsValid
££ "
)
££" #
{
§§ 
var
•• 
result
•• 
=
•• 
await
•• ""
_userAccountsService
••# 7
.
••7 8"
UpdateAccountDetails
••8 L
(
••L M
UserUpdateRequest
••M ^
)
••^ _
;
••_ `
if
ßß 
(
ßß 
result
ßß 
.
ßß 
success
ßß "
is
ßß# %
not
ßß& )
null
ßß* .
)
ßß. /
{
®® 
return
©© 
Ok
©© 
(
©© 
result
©© $
.
©©$ %
success
©©% ,
)
©©, -
;
©©- .
}
™™ 
else
´´ 
{
¨¨ 
return
≠≠ 

BadRequest
≠≠ %
(
≠≠% &
result
≠≠& ,
.
≠≠, -
error
≠≠- 2
)
≠≠2 3
;
≠≠3 4
}
ÆÆ 
}
ØØ 
return
±± 
NotFound
±± 
(
±± 
)
±± 
;
±± 
}
≤≤ 	
catch
≥≥ 
(
≥≥ 
	Exception
≥≥ 
ex
≥≥ 
)
≥≥ 
{
¥¥ 	
return
µµ 

StatusCode
µµ 
(
µµ 
$num
µµ !
,
µµ! "
ex
µµ# %
.
µµ% &
Message
µµ& -
)
µµ- .
;
µµ. /
}
∂∂ 	
}
∏∏ 
}∫∫ 