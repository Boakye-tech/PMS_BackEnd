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
ü
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
}## Ïà
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
}ëë ◊%
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
}88 œ°
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
publicRR 
asyncRR 
TaskRR 
<RR 
ListRR 
<RR 
RolesDtoRR '
>RR' (
>RR( )
GetUserRolesRR* 6
(RR6 7
)RR7 8
{SS 	
returnTT 
awaitTT 
_adminServiceTT &
.TT& '
GetUserRolesTT' 3
(TT3 4
)TT4 5
;TT5 6
}UU 	
[WW 	
HttpPostWW	 
]WW 
[XX 	
RouteXX	 
(XX 
$strXX 
)XX  
]XX  !
publicYY 
asyncYY 
TaskYY 
<YY 
ActionResultYY &
>YY& '
CreateUserRoleYY( 6
(YY6 7
[YY7 8
FromBodyYY8 @
]YY@ A
RolesCreateDtoYYB P
valuesYYQ W
)YYW X
{ZZ 	
var[[ 
result[[ 
=[[ 
await[[ 
_adminService[[ ,
.[[, -
CreateUserRole[[- ;
([[; <
values[[< B
)[[B C
;[[C D
if]] 
(]] 
result]] 
.]] 
	Succeeded]]  
)]]  !
{^^ 
return__ 
Ok__ 
(__ 
result__  
.__  !
ToString__! )
(__) *
)__* +
)__+ ,
;__, -
}`` 
ifbb 
(bb 
!bb 
resultbb 
.bb 
	Succeededbb !
)bb! "
{cc 
returndd 

BadRequestdd !
(dd! "
resultdd" (
.dd( )
Errorsdd) /
)dd/ 0
;dd0 1
}ee 
returngg 

BadRequestgg 
(gg 
resultgg $
)gg$ %
;gg% &
}hh 	
[jj 	
HttpPutjj	 
]jj 
[kk 	
Routekk	 
(kk 
$strkk 
)kk  
]kk  !
publicll 
asyncll 
Taskll 
<ll 
ActionResultll &
>ll& '
UpdateUserRolell( 6
(ll6 7
[ll7 8
FromBodyll8 @
]ll@ A
RolesUpdateDtollB P
valuesllQ W
)llW X
{mm 	
varnn 
resultnn 
=nn 
awaitnn 
_adminServicenn ,
.nn, -
UpdateUserRolenn- ;
(nn; <
valuesnn< B
)nnB C
;nnC D
ifpp 
(pp 
resultpp 
.pp 
	Succeededpp  
)pp  !
{qq 
returnrr 
Okrr 
(rr 
resultrr  
.rr  !
ToStringrr! )
(rr) *
)rr* +
)rr+ ,
;rr, -
}ss 
ifuu 
(uu 
!uu 
resultuu 
.uu 
	Succeededuu !
)uu! "
{vv 
returnww 

BadRequestww !
(ww! "
resultww" (
.ww( )
Errorsww) /
)ww/ 0
;ww0 1
}xx 
returnzz 

BadRequestzz 
(zz 
resultzz $
)zz$ %
;zz% &
}{{ 	
[}} 	

HttpDelete}}	 
]}} 
[~~ 	
Route~~	 
(~~ 
$str~~ 
)~~  
]~~  !
public 
async 
Task 
< 
ActionResult &
>& '
DeleteUserRole( 6
(6 7
[7 8
FromBody8 @
]@ A
RolesDeleteDtoB P
valuesQ W
)W X
{
ÄÄ 	
var
ÅÅ 
result
ÅÅ 
=
ÅÅ 
await
ÅÅ 
_adminService
ÅÅ ,
.
ÅÅ, -
DeleteUserRole
ÅÅ- ;
(
ÅÅ; <
values
ÅÅ< B
)
ÅÅB C
;
ÅÅC D
if
ÉÉ 
(
ÉÉ 
result
ÉÉ 
.
ÉÉ 
	Succeeded
ÉÉ  
)
ÉÉ  !
{
ÑÑ 
return
ÖÖ 
Ok
ÖÖ 
(
ÖÖ 
result
ÖÖ  
.
ÖÖ  !
ToString
ÖÖ! )
(
ÖÖ) *
)
ÖÖ* +
)
ÖÖ+ ,
;
ÖÖ, -
}
ÜÜ 
if
àà 
(
àà 
!
àà 
result
àà 
.
àà 
	Succeeded
àà !
)
àà! "
{
ââ 
return
ää 

BadRequest
ää !
(
ää! "
result
ää" (
.
ää( )
Errors
ää) /
)
ää/ 0
;
ää0 1
}
ãã 
return
çç 

BadRequest
çç 
(
çç 
result
çç $
)
çç$ %
;
çç% &
}
éé 	
[
ìì 	
HttpPost
ìì	 
]
ìì 
[
îî 	
Route
îî	 
(
îî 
$str
îî !
)
îî! "
]
îî" #
public
ïï 
async
ïï 
Task
ïï 
<
ïï 
ActionResult
ïï &
>
ïï& '
AssignRoleToUser
ïï( 8
(
ïï8 9
[
ïï9 :
FromBody
ïï: B
]
ïïB C
AssignUserRoleDto
ïïD U
values
ïïV \
)
ïï\ ]
{
ññ 	
var
óó 
result
óó 
=
óó 
await
óó 
_menuService
óó +
.
óó+ ,
AssignUserRole
óó, :
(
óó: ;
values
óó; A
)
óóA B
;
óóB C
if
ôô 
(
ôô 
result
ôô 
is
ôô 
null
ôô 
)
ôô 
{
öö 
return
õõ 

BadRequest
õõ !
(
õõ! "
$"
õõ" $
$str
õõ$ 2
{
õõ2 3
values
õõ3 9
.
õõ9 :
EmailAddress
õõ: F
}
õõF G
$str
õõG _
"
õõ_ `
)
õõ` a
;
õõa b
}
úú 
if
ûû 
(
ûû 
result
ûû 
!
ûû 
.
ûû 
	Succeeded
ûû !
)
ûû! "
{
üü 
return
†† 
Ok
†† 
(
†† 
result
††  
)
††  !
;
††! "
}
°° 
return
££ 

BadRequest
££ 
(
££ 
result
££ $
.
££$ %
Errors
££% +
)
££+ ,
;
££, -
}
•• 	
[
®® 	
HttpPost
®®	 
]
®® 
[
©© 	
Route
©©	 
(
©© 
$str
©© (
)
©©( )
]
©©) *
public
™™ 
async
™™ 
Task
™™ 
<
™™ 
ActionResult
™™ &
>
™™& '%
AssignPermissionsToRole
™™( ?
(
™™? @
[
™™@ A
FromBody
™™A I
]
™™I J)
PermissionsAccessModulesDto
™™K f
values
™™g m
)
™™m n
{
´´ 	
return
¨¨ 
Ok
¨¨ 
(
¨¨ 
await
¨¨ 
_menuService
¨¨ (
.
¨¨( )$
AssignPermissionToRole
¨¨) ?
(
¨¨? @
values
¨¨@ F
)
¨¨F G
)
¨¨G H
;
¨¨H I
}
≠≠ 	
[
ØØ 	
HttpGet
ØØ	 
]
ØØ 
[
∞∞ 	
Route
∞∞	 
(
∞∞ 
$str
∞∞ ,
)
∞∞, -
]
∞∞- .
public
±± 
Task
±± 
<
±± 
IEnumerable
±± 
<
±±  )
PermissionsAccessModulesDto
±±  ;
>
±±; <
>
±±< = 
GetUserPermissions
±±> P
(
±±P Q
string
±±Q W
userId
±±X ^
)
±±^ _
{
≤≤ 	
return
≥≥ 
null
≥≥ 
!
≥≥ 
;
≥≥ 
}
µµ 	
[
∑∑ 	
HttpGet
∑∑	 
]
∑∑ 
[
∏∏ 	
Route
∏∏	 
(
∏∏ 
$str
∏∏ ,
)
∏∏, -
]
∏∏- .
public
ππ 
Task
ππ 
<
ππ 
IEnumerable
ππ 
<
ππ  )
PermissionsAccessModulesDto
ππ  ;
>
ππ; <
>
ππ< = 
GetRolePermissions
ππ> P
(
ππP Q
string
ππQ W
roleId
ππX ^
)
ππ^ _
{
∫∫ 	
return
ºº 
null
ºº 
!
ºº 
;
ºº 
}
ΩΩ 	
[
øø 	
HttpPut
øø	 
]
øø 
[
¿¿ 	
Route
¿¿	 
(
¿¿ 
$str
¿¿ "
)
¿¿" #
]
¿¿# $
public
¡¡ 
async
¡¡ 
Task
¡¡ 
<
¡¡ 
ActionResult
¡¡ &
>
¡¡& '
VerifyUserAccount
¡¡( 9
(
¡¡9 :
[
¡¡: ;
FromBody
¡¡; C
]
¡¡C D"
VerifyUserAccountDto
¡¡E Y
values
¡¡Z `
)
¡¡` a
{
¬¬ 	
var
√√ 
result
√√ 
=
√√ 
await
√√ 
_adminService
√√ ,
.
√√, -#
VerifyCustomerAccount
√√- B
(
√√B C
values
√√C I
)
√√I J
;
√√J K
if
≈≈ 
(
≈≈ 
result
≈≈ 
.
≈≈ 
	IsSuccess
≈≈ 
)
≈≈  
{
∆∆ 
return
«« 
Ok
«« 
(
«« 
result
««  
.
««  !
SuccessResponse
««! 0
)
««0 1
;
««1 2
}
»» 
return
   
Problem
   
(
   
result
   !
.
  ! "
ErrorResponse
  " /
?
  / 0
.
  0 1
StatusMessage
  1 >
??
  ? A
$str
  B a
)
  a b
;
  b c
}
ÀÀ 	
[
ÕÕ 	
HttpPut
ÕÕ	 
]
ÕÕ 
[
ŒŒ 	
Route
ŒŒ	 
(
ŒŒ 
$str
ŒŒ "
)
ŒŒ" #
]
ŒŒ# $
public
œœ 
async
œœ 
Task
œœ 
<
œœ 
ActionResult
œœ &
>
œœ& '
RejectUserAccount
œœ( 9
(
œœ9 :
[
œœ: ;
FromBody
œœ; C
]
œœC D"
RejectUserAccountDto
œœE Y
values
œœZ `
)
œœ` a
{
–– 	
var
—— 
result
—— 
=
—— 
await
—— 
_adminService
—— ,
.
——, -#
RejectCustomerAccount
——- B
(
——B C
values
——C I
)
——I J
;
——J K
if
”” 
(
”” 
result
”” 
.
”” 
	IsSuccess
””  
)
””  !
{
‘‘ 
return
’’ 
Ok
’’ 
(
’’ 
result
’’  
.
’’  !
SuccessResponse
’’! 0
)
’’0 1
;
’’1 2
}
÷÷ 
return
ÿÿ 
Problem
ÿÿ 
(
ÿÿ 
result
ÿÿ !
.
ÿÿ! "
ErrorResponse
ÿÿ" /
?
ÿÿ/ 0
.
ÿÿ0 1
StatusMessage
ÿÿ1 >
??
ÿÿ? A
$str
ÿÿB a
)
ÿÿa b
;
ÿÿb c
}
ŸŸ 	
[
€€ 	
HttpPut
€€	 
]
€€ 
[
‹‹ 	
Route
‹‹	 
(
‹‹ 
$str
‹‹ #
)
‹‹# $
]
‹‹$ %
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
>
››& ' 
ApproveUserAccount
››( :
(
››: ;
[
››; <
FromBody
››< D
]
››D E#
ApproveUserAccountDto
››F [
values
››\ b
)
››b c
{
ﬁﬁ 	
var
ﬂﬂ 
result
ﬂﬂ 
=
ﬂﬂ 
await
ﬂﬂ 
_adminService
ﬂﬂ ,
.
ﬂﬂ, - 
ApproveUserAccount
ﬂﬂ- ?
(
ﬂﬂ? @
values
ﬂﬂ@ F
)
ﬂﬂF G
;
ﬂﬂG H
if
·· 
(
·· 
result
·· 
.
·· 
	IsSuccess
··  
)
··  !
{
‚‚ 
return
„„ 
Ok
„„ 
(
„„ 
result
„„  
.
„„  !
SuccessResponse
„„! 0
)
„„0 1
;
„„1 2
}
‰‰ 
return
ÊÊ 
Problem
ÊÊ 
(
ÊÊ 
result
ÊÊ !
.
ÊÊ! "
ErrorResponse
ÊÊ" /
?
ÊÊ/ 0
.
ÊÊ0 1
StatusMessage
ÊÊ1 >
??
ÊÊ? A
$str
ÊÊB a
)
ÊÊa b
;
ÊÊb c
}
ÁÁ 	
[
ÈÈ 	
HttpPut
ÈÈ	 
]
ÈÈ 
[
ÍÍ 	
Route
ÍÍ	 
(
ÍÍ 
$str
ÍÍ &
)
ÍÍ& '
]
ÍÍ' (
public
ÎÎ 
async
ÎÎ 
Task
ÎÎ 
<
ÎÎ 
ActionResult
ÎÎ &
>
ÎÎ& '#
DisapproveUserAccount
ÎÎ( =
(
ÎÎ= >
[
ÎÎ> ?
FromBody
ÎÎ? G
]
ÎÎG H'
DisapprovedUserAccountDto
ÎÎI b
values
ÎÎc i
)
ÎÎi j
{
ÏÏ 	
var
ÌÌ 
result
ÌÌ 
=
ÌÌ 
await
ÌÌ 
_adminService
ÌÌ ,
.
ÌÌ, -#
DisapproveUserAccount
ÌÌ- B
(
ÌÌB C
values
ÌÌC I
)
ÌÌI J
;
ÌÌJ K
if
ÔÔ 
(
ÔÔ 
result
ÔÔ 
.
ÔÔ 
	IsSuccess
ÔÔ  
)
ÔÔ  !
{
 
return
ÒÒ 
Ok
ÒÒ 
(
ÒÒ 
result
ÒÒ  
.
ÒÒ  !
SuccessResponse
ÒÒ! 0
)
ÒÒ0 1
;
ÒÒ1 2
}
ÚÚ 
return
ÙÙ 
Problem
ÙÙ 
(
ÙÙ 
result
ÙÙ !
.
ÙÙ! "
ErrorResponse
ÙÙ" /
?
ÙÙ/ 0
.
ÙÙ0 1
StatusMessage
ÙÙ1 >
??
ÙÙ? A
$str
ÙÙB a
)
ÙÙa b
;
ÙÙb c
}
ıı 	
[
˜˜ 	
HttpPut
˜˜	 
]
˜˜ 
[
¯¯ 	
Route
¯¯	 
(
¯¯ 
$str
¯¯ $
)
¯¯$ %
]
¯¯% &
public
˘˘ 
async
˘˘ 
Task
˘˘ 
<
˘˘ 
ActionResult
˘˘ &
>
˘˘& '!
ActivateUserAccount
˘˘( ;
(
˘˘; <
[
˘˘< =
FromBody
˘˘= E
]
˘˘E F$
ActivateUserAccountDto
˘˘G ]
values
˘˘^ d
)
˘˘d e
{
˙˙ 	
var
˚˚ 
result
˚˚ 
=
˚˚ 
await
˚˚ 
_adminService
˚˚ ,
.
˚˚, -!
ActivateUserAccount
˚˚- @
(
˚˚@ A
values
˚˚A G
)
˚˚G H
;
˚˚H I
if
˝˝ 
(
˝˝ 
result
˝˝ 
.
˝˝ 
	IsSuccess
˝˝  
)
˝˝  !
{
˛˛ 
return
ˇˇ 
Ok
ˇˇ 
(
ˇˇ 
result
ˇˇ  
.
ˇˇ  !
SuccessResponse
ˇˇ! 0
)
ˇˇ0 1
;
ˇˇ1 2
}
ÄÄ 
return
ÇÇ 
Problem
ÇÇ 
(
ÇÇ 
result
ÇÇ !
.
ÇÇ! "
ErrorResponse
ÇÇ" /
?
ÇÇ/ 0
.
ÇÇ0 1
StatusMessage
ÇÇ1 >
??
ÇÇ? A
$str
ÇÇB a
)
ÇÇa b
;
ÇÇb c
}
ÉÉ 	
[
ÖÖ 	
HttpPut
ÖÖ	 
]
ÖÖ 
[
ÜÜ 	
Route
ÜÜ	 
(
ÜÜ 
$str
ÜÜ &
)
ÜÜ& '
]
ÜÜ' (
public
áá 
async
áá 
Task
áá 
<
áá 
ActionResult
áá &
>
áá& '"
DectivateUserAccount
áá( <
(
áá< =
[
áá= >
FromBody
áá> F
]
ááF G&
DeactivateUserAccountDto
ááH `
values
ááa g
)
áág h
{
àà 	
var
ââ 
result
ââ 
=
ââ 
await
ââ 
_adminService
ââ ,
.
ââ, -#
DeactivateUserAccount
ââ- B
(
ââB C
values
ââC I
)
ââI J
;
ââJ K
if
ãã 
(
ãã 
result
ãã 
.
ãã 
	IsSuccess
ãã  
)
ãã  !
{
åå 
return
çç 
Ok
çç 
(
çç 
result
çç  
.
çç  !
SuccessResponse
çç! 0
)
çç0 1
;
çç1 2
}
éé 
return
êê 
Problem
êê 
(
êê 
result
êê !
.
êê! "
ErrorResponse
êê" /
?
êê/ 0
.
êê0 1
StatusMessage
êê1 >
??
êê? A
$str
êêB a
)
êêa b
;
êêb c
}
ëë 	
}
îî 
}ïï ûá
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v1/AdministrationController.cs
	namespace 	
Modules
 
. 
Users 
. 
Presentation $
.$ %
Controllers% 0
.0 1
v11 3
{ 
[		 
ApiController		 
]		 
[

 

ApiVersion

 
(

 
$str

 
)

 
]

 
[ 
Route 

(
 
$str 3
)3 4
]4 5
[ 
Produces 
( 
$str  
)  !
]! "
[ 
	Authorize 
( !
AuthenticationSchemes $
=% &
JwtBearerDefaults' 8
.8 9 
AuthenticationScheme9 M
)M N
]N O
[ 
	Authorize 
( 
Policy 
= 
$str /
)/ 0
]0 1
public 

class $
AdministrationController )
:* +
ControllerBase, :
{ 
readonly "
IAdministrationService '
_adminService( 5
;5 6
readonly 
IMenuService 
_menuService *
;* +
readonly 
IDepartmentService #
_departmentService$ 6
;6 7
readonly "
IDepartmentUnitService '"
_departmentUnitService( >
;> ?
readonly 
IChannelService  
_channelService! 0
;0 1
readonly &
IIdentificationTypeService +&
_identificationTypeService, F
;F G
private 
readonly 
IUserContextService ,
_userContextService- @
;@ A
public $
AdministrationController '
(' ("
IAdministrationService( >
adminService? K
,K L
IDepartmentServiceM _
departmentService` q
,q r#
IDepartmentUnitService	s â#
departmentUnitService
ä ü
,
ü †
IMenuService
° ≠
menuService
Æ π
,
π ∫
IChannelService
ª  
channelService
À Ÿ
,
Ÿ ⁄(
IIdentificationTypeService
€ ı'
identificationTypeService
ˆ è
,
è ê!
IUserContextService
ë § 
userContextService
• ∑
)
∑ ∏
{ 	
_adminService 
= 
adminService (
;( )
_menuService 
= 
menuService &
;& '
_departmentService 
=  
departmentService! 2
;2 3"
_departmentUnitService   "
=  # $!
departmentUnitService  % :
;  : ;
_channelService!! 
=!! 
channelService!! ,
;!!, -&
_identificationTypeService"" &
=""' (%
identificationTypeService"") B
;""B C
_userContextService## 
=##  !
userContextService##" 4
;##4 5
}$$ 	
[** 	
HttpGet**	 
]** 
[++ 	
Route++	 
(++ 
$str++ 
)++ 
]++ 
public,, 
async,, 
Task,, 
<,, 
ActionResult,, &
<,,& '
IEnumerable,,' 2
<,,2 3
ChannelReadDto,,3 A
>,,A B
>,,B C
>,,C D
GetChannels,,E P
(,,P Q
),,Q R
{-- 	
return.. 
Ok.. 
(.. 
await.. 
_channelService.. +
...+ ,
GetChannelAsync.., ;
(..; <
)..< =
)..= >
;..> ?
}// 	
[22 	
HttpPost22	 
]22 
[33 	
Route33	 
(33 
$str33 
)33 
]33  
[44 	
	Authorize44	 
(44 
Policy44 
=44 
$str44 5
)445 6
]446 7
public55 
async55 
Task55 
<55 
ActionResult55 &
<55& '
ChannelReadDto55' 5
>555 6
>556 7
CreateChannel558 E
(55E F
[55F G
FromBody55G O
]55O P
ChannelCreateDto55Q a
values55b h
)55h i
{66 	
try77 
{88 
var99 
userId99 
=99 
_userContextService99 0
.990 1
	GetUserId991 :
(99: ;
)99; <
;99< =
if:: 
(:: 
!:: 
string:: 
.:: 
Equals:: "
(::" #
userId::# )
,::) *
values::+ 1
.::1 2
	CreatedBy::2 ;
)::; <
)::< =
{;; 
return<< 
Unauthorized<< '
(<<' (
)<<( )
;<<) *
}== 
var?? 
result?? 
=?? 
await?? "
_channelService??# 2
.??2 3
AddChannelAsync??3 B
(??B C
values??C I
)??I J
;??J K
if@@ 
(@@ 
result@@ 
is@@ 
null@@ "
)@@" #
{AA 
returnBB 

BadRequestBB %
(BB% &
resultBB& ,
)BB, -
;BB- .
}CC 
returnEE 

StatusCodeEE !
(EE! "
StatusCodesEE" -
.EE- .
Status201CreatedEE. >
,EE> ?
resultEE@ F
)EEF G
;EEG H
}FF 
catchGG 
(GG 
	ExceptionGG 
exGG 
)GG  
{HH 
returnII 

StatusCodeII !
(II! "
$numII" %
,II% &
exII' )
.II) *
InnerExceptionII* 8
!II8 9
.II9 :
MessageII: A
)IIA B
;IIB C
}JJ 
}KK 	
[MM 	
HttpPutMM	 
]MM 
[NN 	
RouteNN	 
(NN 
$strNN 
)NN 
]NN  
[OO 	
	AuthorizeOO	 
(OO 
PolicyOO 
=OO 
$strOO 5
)OO5 6
]OO6 7
publicPP 
asyncPP 
TaskPP 
<PP 
ActionResultPP &
<PP& '
ChannelReadDtoPP' 5
>PP5 6
>PP6 7
UpdateChannelPP8 E
(PPE F
[PPF G
FromBodyPPG O
]PPO P
ChannelUpdateDtoPPQ a
valuesPPb h
)PPh i
{QQ 	
varRR 
userIdRR 
=RR 
_userContextServiceRR ,
.RR, -
	GetUserIdRR- 6
(RR6 7
)RR7 8
;RR8 9
ifSS 
(SS 
!SS 
stringSS 
.SS 
EqualsSS 
(SS 
userIdSS %
,SS% &
valuesSS' -
.SS- .

ModifiedBySS. 8
)SS8 9
)SS9 :
{TT 
returnUU 
UnauthorizedUU #
(UU# $
)UU$ %
;UU% &
}VV 
varXX 
resultXX 
=XX 
awaitXX 
_channelServiceXX .
.XX. /
UpdateChannelAsyncXX/ A
(XXA B
valuesXXB H
)XXH I
;XXI J
ifYY 
(YY 
resultYY 
isYY 
nullYY 
)YY 
{ZZ 
return[[ 

BadRequest[[ !
([[! "
)[[" #
;[[# $
}\\ 
return^^ 
Ok^^ 
(^^ 
result^^ 
)^^ 
;^^ 
}__ 	
[aa 	

HttpDeleteaa	 
(aa 
$straa /
)aa/ 0
]aa0 1
publicbb 
asyncbb 
Taskbb 
<bb 
ActionResultbb &
>bb& '
DeleteChannelbb( 5
(bb5 6
intbb6 9
	channelIdbb: C
)bbC D
{cc 	
vardd 
responsedd 
=dd 
awaitdd  
_channelServicedd! 0
.dd0 1
DeleteChannelAsyncdd1 C
(ddC D
	channelIdddD M
)ddM N
;ddN O
ifff 
(ff 
responseff 
==ff 
$strff %
)ff% &
{gg 
returnhh 
Okhh 
(hh 
awaithh 
_channelServicehh  /
.hh/ 0
DeleteChannelAsynchh0 B
(hhB C
	channelIdhhC L
)hhL M
)hhM N
;hhN O
}ii 
returnkk 

BadRequestkk 
(kk 
)kk 
;kk  
}ll 	
[pp 	
HttpGetpp	 
]pp 
[qq 	
Routeqq	 
(qq 
$strqq 
)qq  
]qq  !
publicrr 
asyncrr 
Taskrr 
<rr 
AccessModulesDtorr *
>rr* +
GetAccessMenusrr, :
(rr: ;
)rr; <
{ss 	
returntt 
awaittt 
_menuServicett %
.tt% &
GetAccessMenustt& 4
(tt4 5
)tt5 6
;tt6 7
}uu 	
[ww 	
HttpGetww	 
]ww 
[xx 	
Routexx	 
(xx 
$strxx 
)xx  
]xx  !
publicyy 
IEnumerableyy 
<yy 
MenuActionsDtoyy )
>yy) *
GetUserActionsyy+ 9
(yy9 :
)yy: ;
{zz 	
return{{ 
_menuService{{ 
.{{  

GetActions{{  *
({{* +
){{+ ,
;{{, -
}|| 	
[~~ 	
HttpGet~~	 
]~~ 
[ 	
Route	 
( 
$str 
) 
] 
public
ÄÄ 
async
ÄÄ 
Task
ÄÄ 
<
ÄÄ 
IEnumerable
ÄÄ %
<
ÄÄ% &
MenusDto
ÄÄ& .
>
ÄÄ. /
>
ÄÄ/ 0
GetMenus
ÄÄ1 9
(
ÄÄ9 :
)
ÄÄ: ;
{
ÅÅ 	
return
ÇÇ 
await
ÇÇ 
_menuService
ÇÇ %
.
ÇÇ% &
GetMenus
ÇÇ& .
(
ÇÇ. /
)
ÇÇ/ 0
;
ÇÇ0 1
}
ÉÉ 	
[
ÖÖ 	
HttpPost
ÖÖ	 
]
ÖÖ 
[
ÜÜ 	
Route
ÜÜ	 
(
ÜÜ 
$str
ÜÜ 
)
ÜÜ 
]
ÜÜ 
[
áá 	
	Authorize
áá	 
(
áá 
Policy
áá 
=
áá 
$str
áá 5
)
áá5 6
]
áá6 7
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
>
àà& '
CreateMenus
àà( 3
(
àà3 4
[
àà4 5
FromBody
àà5 =
]
àà= >
MenusDto
àà? G
values
ààH N
)
ààN O
{
ââ 	
var
ää 
result
ää 
=
ää 
await
ää 
_menuService
ää +
.
ää+ ,

CreateMenu
ää, 6
(
ää6 7
values
ää7 =
)
ää= >
;
ää> ?
return
ãã 
Ok
ãã 
(
ãã 
result
ãã 
)
ãã 
;
ãã 
}
åå 	
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
èè 
)
èè 
]
èè 
public
êê 
async
êê 
Task
êê 
<
êê 
IEnumerable
êê %
<
êê% &
SubMenusDto
êê& 1
>
êê1 2
>
êê2 3
GetSubMenus
êê4 ?
(
êê? @
)
êê@ A
{
ëë 	
return
íí 
await
íí 
_menuService
íí %
.
íí% &
GetSubMenus
íí& 1
(
íí1 2
)
íí2 3
;
íí3 4
}
ìì 	
[
ïï 	
HttpPost
ïï	 
]
ïï 
[
ññ 	
Route
ññ	 
(
ññ 
$str
ññ 
)
ññ  
]
ññ  !
[
óó 	
	Authorize
óó	 
(
óó 
Policy
óó 
=
óó 
$str
óó 5
)
óó5 6
]
óó6 7
public
òò 
async
òò 
Task
òò 
<
òò 
ActionResult
òò &
>
òò& '
CreateSubMenus
òò( 6
(
òò6 7
[
òò7 8
FromBody
òò8 @
]
òò@ A
SubMenusCreateDto
òòB S
values
òòT Z
)
òòZ [
{
ôô 	
var
öö 
result
öö 
=
öö 
await
öö 
_menuService
öö +
.
öö+ ,
CreateSubMenu
öö, 9
(
öö9 :
values
öö: @
)
öö@ A
;
ööA B
return
õõ 
Ok
õõ 
(
õõ 
result
õõ 
)
õõ 
;
õõ 
}
úú 	
[
ûû 	
HttpGet
ûû	 
]
ûû 
[
üü 	
Route
üü	 
(
üü 
$str
üü  
)
üü  !
]
üü! "
public
†† 
async
†† 
Task
†† 
<
†† 
IEnumerable
†† %
<
††% &
SubMenuItemsDto
††& 5
>
††5 6
>
††6 7
GetSubMenuItems
††8 G
(
††G H
)
††H I
{
°° 	
return
¢¢ 
await
¢¢ 
_menuService
¢¢ %
.
¢¢% &
GetSubMenuItems
¢¢& 5
(
¢¢5 6
)
¢¢6 7
;
¢¢7 8
}
££ 	
[
•• 	
HttpGet
••	 
]
•• 
[
¶¶ 	
Route
¶¶	 
(
¶¶ 
$str
¶¶ &
)
¶¶& '
]
¶¶' (
[
ßß 	
AllowAnonymous
ßß	 
]
ßß 
public
®® 
async
®® 
Task
®® 
<
®® 
IEnumerable
®® %
<
®®% &#
ApplicationModulesDto
®®& ;
>
®®; <
>
®®< =#
GetApplicationModules
®®> S
(
®®S T
)
®®T U
{
©© 	
return
™™ 
await
™™ 
_menuService
™™ %
.
™™% &

GetModules
™™& 0
(
™™0 1
)
™™1 2
;
™™2 3
}
´´ 	
[
≠≠ 	
HttpPost
≠≠	 
]
≠≠ 
[
ÆÆ 	
Route
ÆÆ	 
(
ÆÆ 
$str
ÆÆ &
)
ÆÆ& '
]
ÆÆ' (
[
ØØ 	
AllowAnonymous
ØØ	 
]
ØØ 
public
∞∞ 
async
∞∞ 
Task
∞∞ 
<
∞∞ 
ActionResult
∞∞ &
>
∞∞& '#
AddApplicationModules
∞∞( =
(
∞∞= >
[
∞∞> ?
FromBody
∞∞? G
]
∞∞G H)
ApplicationModulesCreateDto
∞∞I d
values
∞∞e k
)
∞∞k l
{
±± 	
return
≤≤ 
Ok
≤≤ 
(
≤≤ 
await
≤≤ 
_menuService
≤≤ (
.
≤≤( )

AddModules
≤≤) 3
(
≤≤3 4
values
≤≤4 :
)
≤≤: ;
)
≤≤; <
;
≤≤< =
}
≥≥ 	
[
µµ 	
HttpPut
µµ	 
]
µµ 
[
∂∂ 	
Route
∂∂	 
(
∂∂ 
$str
∂∂ )
)
∂∂) *
]
∂∂* +
[
∑∑ 	
AllowAnonymous
∑∑	 
]
∑∑ 
public
∏∏ 
async
∏∏ 
Task
∏∏ 
<
∏∏ 
ActionResult
∏∏ &
>
∏∏& '&
UpdateApplicationModules
∏∏( @
(
∏∏@ A
[
∏∏A B
FromBody
∏∏B J
]
∏∏J K#
ApplicationModulesDto
∏∏L a
values
∏∏b h
)
∏∏h i
{
ππ 	
return
∫∫ 
Ok
∫∫ 
(
∫∫ 
await
∫∫ 
_menuService
∫∫ (
.
∫∫( )
UpdateModules
∫∫) 6
(
∫∫6 7
values
∫∫7 =
)
∫∫= >
)
∫∫> ?
;
∫∫? @
}
ªª 	
[
ææ 	
HttpPost
ææ	 
]
ææ 
[
øø 	
Route
øø	 
(
øø 
$str
øø '
)
øø' (
]
øø( )
[
¿¿ 	
AllowAnonymous
¿¿	 
]
¿¿ 
public
¡¡ 
async
¡¡ 
Task
¡¡ 
<
¡¡ 
ActionResult
¡¡ &
>
¡¡& '$
AssignModulePermission
¡¡( >
(
¡¡> ?
[
¡¡? @
FromBody
¡¡@ H
]
¡¡H I.
 ApplicationModulesPermissionsDto
¡¡J j
values
¡¡k q
)
¡¡q r
{
¬¬ 	
return
√√ 
Ok
√√ 
(
√√ 
await
√√ 
_menuService
√√ (
.
√√( )$
AssignModulePermission
√√) ?
(
√√? @
values
√√@ F
)
√√F G
)
√√G H
;
√√H I
}
ƒƒ 	
[
∆∆ 	
HttpGet
∆∆	 
]
∆∆ 
[
«« 	
Route
««	 
(
«« 
$str
«« 7
)
««7 8
]
««8 9
[
»» 	
AllowAnonymous
»»	 
]
»» 
public
…… 
async
…… 
Task
…… 
<
…… 
IEnumerable
…… %
<
……% &'
RoleModulesPermissionsDto
……& ?
>
……? @
>
……@ A.
 GetApplicationModulesPermissions
……B b
(
……b c
string
……c i
roleId
……j p
)
……p q
{
   	
return
ÀÀ 
await
ÀÀ 
_menuService
ÀÀ %
.
ÀÀ% &#
GetModulesPermissions
ÀÀ& ;
(
ÀÀ; <
roleId
ÀÀ< B
)
ÀÀB C
;
ÀÀC D
}
ÃÃ 	
[
ŒŒ 	
HttpPost
ŒŒ	 
]
ŒŒ 
[
œœ 	
Route
œœ	 
(
œœ 
$str
œœ #
)
œœ# $
]
œœ$ %
[
–– 	
	Authorize
––	 
(
–– 
Policy
–– 
=
–– 
$str
–– 5
)
––5 6
]
––6 7
public
—— 
async
—— 
Task
—— 
<
—— 
ActionResult
—— &
>
——& ' 
CreateSubMenuItems
——( :
(
——: ;
[
——; <
FromBody
——< D
]
——D E#
SubMenuItemsCreateDto
——F [
values
——\ b
)
——b c
{
““ 	
return
”” 
Ok
”” 
(
”” 
await
”” 
_menuService
”” (
.
””( ) 
CreateSubMenuItems
””) ;
(
””; <
values
””< B
)
””B C
)
””C D
;
””D E
}
‘‘ 	
[
⁄⁄ 	
HttpPost
⁄⁄	 
]
⁄⁄ 
[
€€ 	
Route
€€	 
(
€€ 
$str
€€ 
)
€€ 
]
€€ 
[
‹‹ 	
	Authorize
‹‹	 
(
‹‹ 
Policy
‹‹ 
=
‹‹ 
$str
‹‹ 6
,
‹‹6 7
Roles
‹‹8 =
=
‹‹> ?
$str
‹‹@ R
)
‹‹R S
]
‹‹S T
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
>
››& '
ApproveRole
››( 3
(
››3 4
[
››4 5
FromBody
››5 =
]
››= >
RolesApprovalDto
››? O
values
››P V
)
››V W
{
ﬁﬁ 	
var
ﬂﬂ 
userId
ﬂﬂ 
=
ﬂﬂ !
_userContextService
ﬂﬂ ,
.
ﬂﬂ, -
	GetUserId
ﬂﬂ- 6
(
ﬂﬂ6 7
)
ﬂﬂ7 8
;
ﬂﬂ8 9
if
‡‡ 
(
‡‡ 
!
‡‡ 
string
‡‡ 
.
‡‡ 
Equals
‡‡ 
(
‡‡ 
userId
‡‡ %
,
‡‡% &
values
‡‡' -
.
‡‡- .

ApprovedBy
‡‡. 8
)
‡‡8 9
)
‡‡9 :
{
·· 
return
‚‚ 
Unauthorized
‚‚ #
(
‚‚# $
)
‚‚$ %
;
‚‚% &
}
„„ 
return
‰‰ 
Ok
‰‰ 
(
‰‰ 
await
‰‰ 
_adminService
‰‰ )
.
‰‰) *
ApproveUserRole
‰‰* 9
(
‰‰9 :
values
‰‰: @
)
‰‰@ A
)
‰‰A B
;
‰‰B C
}
ÂÂ 	
[
ÍÍ 	
HttpPost
ÍÍ	 
]
ÍÍ 
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
ÎÎ  !
[
ÏÏ 	
	Authorize
ÏÏ	 
(
ÏÏ 
Policy
ÏÏ 
=
ÏÏ 
$str
ÏÏ 9
,
ÏÏ9 :
Roles
ÏÏ; @
=
ÏÏA B
$str
ÏÏC U
)
ÏÏU V
]
ÏÏV W
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
ÌÌ& '
DisapproveRole
ÌÌ( 6
(
ÌÌ6 7
[
ÌÌ7 8
FromBody
ÌÌ8 @
]
ÌÌ@ A
RolesApprovalDto
ÌÌB R
values
ÌÌS Y
)
ÌÌY Z
{
ÓÓ 	
var
ÔÔ 
userId
ÔÔ 
=
ÔÔ !
_userContextService
ÔÔ ,
.
ÔÔ, -
	GetUserId
ÔÔ- 6
(
ÔÔ6 7
)
ÔÔ7 8
;
ÔÔ8 9
if
 
(
 
!
 
string
 
.
 
Equals
 
(
 
userId
 %
,
% &
values
' -
.
- .

ApprovedBy
. 8
)
8 9
)
9 :
{
ÒÒ 
return
ÚÚ 
Unauthorized
ÚÚ #
(
ÚÚ# $
)
ÚÚ$ %
;
ÚÚ% &
}
ÛÛ 
return
ÙÙ 
Ok
ÙÙ 
(
ÙÙ 
await
ÙÙ 
_adminService
ÙÙ )
.
ÙÙ) *
ApproveUserRole
ÙÙ* 9
(
ÙÙ9 :
values
ÙÙ: @
)
ÙÙ@ A
)
ÙÙA B
;
ÙÙB C
}
ˆˆ 	
[
¸¸ 	
HttpGet
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ %
)
˝˝% &
]
˝˝& '
public
˛˛ 
async
˛˛ 
Task
˛˛ 
<
˛˛ 
List
˛˛ 
<
˛˛ 
RolesDto
˛˛ '
>
˛˛' (
>
˛˛( )"
GetApprovedUserRoles
˛˛* >
(
˛˛> ?
)
˛˛? @
{
ˇˇ 	
return
ÄÄ 
await
ÄÄ 
_adminService
ÄÄ &
.
ÄÄ& '"
GetApprovedUserRoles
ÄÄ' ;
(
ÄÄ; <
)
ÄÄ< =
;
ÄÄ= >
}
ÅÅ 	
[
áá 	
HttpGet
áá	 
]
áá 
[
àà 	
Route
àà	 
(
àà 
$str
àà 6
)
àà6 7
]
àà7 8
public
ââ 
async
ââ 
Task
ââ 
<
ââ 
List
ââ 
<
ââ 
RolesDto
ââ '
>
ââ' (
>
ââ( )$
GetDepartmentUserRoles
ââ* @
(
ââ@ A
int
ââA D
departmentId
ââE Q
)
ââQ R
{
ää 	
return
ãã 
await
ãã 
_adminService
ãã &
.
ãã& '$
GetDepartmentUserRoles
ãã' =
(
ãã= >
departmentId
ãã> J
)
ããJ K
;
ããK L
}
åå 	
[
íí 	
HttpGet
íí	 
]
íí 
[
ìì 	
Route
ìì	 
(
ìì 
$str
ìì 4
)
ìì4 5
]
ìì5 6
public
îî 
async
îî 
Task
îî 
<
îî 
List
îî 
<
îî 
RolesDto
îî '
>
îî' (
>
îî( )(
GetDepartmentUnitUserRoles
îî* D
(
îîD E
int
îîE H
unitId
îîI O
)
îîO P
{
ïï 	
return
ññ 
await
ññ 
_adminService
ññ &
.
ññ& '(
GetDepartmentUnitUserRoles
ññ' A
(
ññA B
unitId
ññB H
)
ññH I
;
ññI J
}
óó 	
[
ùù 	
HttpGet
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
ûû %
)
ûû% &
]
ûû& '
[
üü 	
Obsolete
üü	 
]
üü 
public
†† 
async
†† 
Task
†† 
<
†† 
List
†† 
<
†† 
RolesDto
†† '
>
††' (
>
††( )"
GetRejectedUserRoles
††* >
(
††> ?
)
††? @
{
°° 	
return
¢¢ 
await
¢¢ 
_adminService
¢¢ &
.
¢¢& '"
GetRejectedUserRoles
¢¢' ;
(
¢¢; <
)
¢¢< =
;
¢¢= >
}
££ 	
[
©© 	
HttpGet
©©	 
]
©© 
[
™™ 	
Route
™™	 
(
™™ 
$str
™™ 
)
™™ 
]
™™ 
public
´´ 
async
´´ 
Task
´´ 
<
´´ 
List
´´ 
<
´´ 
RolesDto
´´ '
>
´´' (
>
´´( )
GetUserRoles
´´* 6
(
´´6 7
)
´´7 8
{
¨¨ 	
return
≠≠ 
await
≠≠ 
_adminService
≠≠ &
.
≠≠& '
GetUserRoles
≠≠' 3
(
≠≠3 4
)
≠≠4 5
;
≠≠5 6
}
ÆÆ 	
[
∞∞ 	
HttpPost
∞∞	 
]
∞∞ 
[
±± 	
Route
±±	 
(
±± 
$str
±± 
)
±±  
]
±±  !
[
≤≤ 	
	Authorize
≤≤	 
(
≤≤ 
Policy
≤≤ 
=
≤≤ 
$str
≤≤ 9
)
≤≤9 :
]
≤≤: ;
public
≥≥ 
async
≥≥ 
Task
≥≥ 
<
≥≥ 
ActionResult
≥≥ &
>
≥≥& '
CreateUserRole
≥≥( 6
(
≥≥6 7
[
≥≥7 8
FromBody
≥≥8 @
]
≥≥@ A
RolesCreateDto
≥≥B P
values
≥≥Q W
)
≥≥W X
{
¥¥ 	
var
µµ 
userId
µµ 
=
µµ !
_userContextService
µµ ,
.
µµ, -
	GetUserId
µµ- 6
(
µµ6 7
)
µµ7 8
;
µµ8 9
if
∂∂ 
(
∂∂ 
!
∂∂ 
string
∂∂ 
.
∂∂ 
Equals
∂∂ 
(
∂∂ 
userId
∂∂ %
,
∂∂% &
values
∂∂' -
.
∂∂- .
	CreatedBy
∂∂. 7
)
∂∂7 8
)
∂∂8 9
{
∑∑ 
return
∏∏ 
Unauthorized
∏∏ #
(
∏∏# $
)
∏∏$ %
;
∏∏% &
}
ππ 
var
ªª 
result
ªª 
=
ªª 
await
ªª 
_adminService
ªª ,
.
ªª, -
CreateUserRole
ªª- ;
(
ªª; <
values
ªª< B
)
ªªB C
;
ªªC D
if
ΩΩ 
(
ΩΩ 
result
ΩΩ 
.
ΩΩ 
	Succeeded
ΩΩ  
)
ΩΩ  !
{
ææ 
return
øø 
Ok
øø 
(
øø 
new
øø 
{
øø  
message
øø! (
=
øø) *
result
øø+ 1
.
øø1 2
ToString
øø2 :
(
øø: ;
)
øø; <
}
øø= >
)
øø> ?
;
øø? @
}
¿¿ 
if
¬¬ 
(
¬¬ 
!
¬¬ 
result
¬¬ 
.
¬¬ 
	Succeeded
¬¬ !
)
¬¬! "
{
√√ 
return
ƒƒ 

BadRequest
ƒƒ !
(
ƒƒ! "
result
ƒƒ" (
.
ƒƒ( )
Errors
ƒƒ) /
)
ƒƒ/ 0
;
ƒƒ0 1
}
≈≈ 
return
«« 

BadRequest
«« 
(
«« 
result
«« $
)
««$ %
;
««% &
}
»» 	
[
   	
HttpPut
  	 
]
   
[
ÀÀ 	
Route
ÀÀ	 
(
ÀÀ 
$str
ÀÀ 
)
ÀÀ  
]
ÀÀ  !
[
ÃÃ 	
	Authorize
ÃÃ	 
(
ÃÃ 
Policy
ÃÃ 
=
ÃÃ 
$str
ÃÃ 5
)
ÃÃ5 6
]
ÃÃ6 7
public
ÕÕ 
async
ÕÕ 
Task
ÕÕ 
<
ÕÕ 
ActionResult
ÕÕ &
>
ÕÕ& '
UpdateUserRole
ÕÕ( 6
(
ÕÕ6 7
[
ÕÕ7 8
FromBody
ÕÕ8 @
]
ÕÕ@ A
RolesUpdateDto
ÕÕB P
values
ÕÕQ W
)
ÕÕW X
{
ŒŒ 	
var
œœ 
userId
œœ 
=
œœ !
_userContextService
œœ ,
.
œœ, -
	GetUserId
œœ- 6
(
œœ6 7
)
œœ7 8
;
œœ8 9
if
–– 
(
–– 
!
–– 
string
–– 
.
–– 
Equals
–– 
(
–– 
userId
–– %
,
––% &
values
––' -
.
––- .

ModifiedBy
––. 8
)
––8 9
)
––9 :
{
—— 
return
““ 
Unauthorized
““ #
(
““# $
)
““$ %
;
““% &
}
”” 
var
’’ 
result
’’ 
=
’’ 
await
’’ 
_adminService
’’ ,
.
’’, -
UpdateUserRole
’’- ;
(
’’; <
values
’’< B
)
’’B C
;
’’C D
if
◊◊ 
(
◊◊ 
result
◊◊ 
.
◊◊ 
	Succeeded
◊◊  
)
◊◊  !
{
ÿÿ 
return
ŸŸ 
Ok
ŸŸ 
(
ŸŸ 
new
ŸŸ 
{
ŸŸ 
message
ŸŸ  '
=
ŸŸ( )
result
ŸŸ* 0
.
ŸŸ0 1
ToString
ŸŸ1 9
(
ŸŸ9 :
)
ŸŸ: ;
}
ŸŸ< =
)
ŸŸ= >
;
ŸŸ> ?
}
⁄⁄ 
if
‹‹ 
(
‹‹ 
!
‹‹ 
result
‹‹ 
.
‹‹ 
	Succeeded
‹‹ !
)
‹‹! "
{
›› 
return
ﬁﬁ 

BadRequest
ﬁﬁ !
(
ﬁﬁ! "
result
ﬁﬁ" (
.
ﬁﬁ( )
Errors
ﬁﬁ) /
)
ﬁﬁ/ 0
;
ﬁﬁ0 1
}
ﬂﬂ 
return
·· 

BadRequest
·· 
(
·· 
result
·· $
)
··$ %
;
··% &
}
‚‚ 	
[
‰‰ 	

HttpDelete
‰‰	 
]
‰‰ 
[
ÂÂ 	
Route
ÂÂ	 
(
ÂÂ 
$str
ÂÂ (
)
ÂÂ( )
]
ÂÂ) *
[
ÊÊ 	
	Authorize
ÊÊ	 
(
ÊÊ 
Policy
ÊÊ 
=
ÊÊ 
$str
ÊÊ 5
,
ÊÊ5 6
Roles
ÊÊ7 <
=
ÊÊ= >
$str
ÊÊ? Q
)
ÊÊQ R
]
ÊÊR S
public
ÁÁ 
async
ÁÁ 
Task
ÁÁ 
<
ÁÁ 
ActionResult
ÁÁ &
>
ÁÁ& '
DeleteUserRole
ÁÁ( 6
(
ÁÁ6 7
string
ÁÁ7 =
roleId
ÁÁ> D
)
ÁÁD E
{
ËË 	
var
ÈÈ 
userId
ÈÈ 
=
ÈÈ !
_userContextService
ÈÈ ,
.
ÈÈ, -
	GetUserId
ÈÈ- 6
(
ÈÈ6 7
)
ÈÈ7 8
;
ÈÈ8 9
RolesDeleteDto
ÔÔ 
values
ÔÔ !
=
ÔÔ" #
new
ÔÔ$ '
RolesDeleteDto
ÔÔ( 6
(
ÔÔ6 7
roleId
ÔÔ7 =
,
ÔÔ= >
userId
ÔÔ? E
!
ÔÔE F
)
ÔÔF G
;
ÔÔG H
var
ÒÒ 
result
ÒÒ 
=
ÒÒ 
await
ÒÒ 
_adminService
ÒÒ ,
.
ÒÒ, -
DeleteUserRole
ÒÒ- ;
(
ÒÒ; <
values
ÒÒ< B
)
ÒÒB C
;
ÒÒC D
if
ÛÛ 
(
ÛÛ 
result
ÛÛ 
.
ÛÛ 
	Succeeded
ÛÛ  
)
ÛÛ  !
{
ÙÙ 
return
ıı 
Ok
ıı 
(
ıı 
result
ıı  
.
ıı  !
ToString
ıı! )
(
ıı) *
)
ıı* +
)
ıı+ ,
;
ıı, -
}
ˆˆ 
if
¯¯ 
(
¯¯ 
!
¯¯ 
result
¯¯ 
.
¯¯ 
	Succeeded
¯¯ !
)
¯¯! "
{
˘˘ 
return
˙˙ 

BadRequest
˙˙ !
(
˙˙! "
result
˙˙" (
.
˙˙( )
Errors
˙˙) /
)
˙˙/ 0
;
˙˙0 1
}
˚˚ 
return
˝˝ 

BadRequest
˝˝ 
(
˝˝ 
result
˝˝ $
)
˝˝$ %
;
˝˝% &
}
˛˛ 	
[
ÑÑ 	
HttpPost
ÑÑ	 
]
ÑÑ 
[
ÖÖ 	
Route
ÖÖ	 
(
ÖÖ 
$str
ÖÖ !
)
ÖÖ! "
]
ÖÖ" #
[
ÜÜ 	
	Authorize
ÜÜ	 
(
ÜÜ 
Policy
ÜÜ 
=
ÜÜ 
$str
ÜÜ 9
)
ÜÜ9 :
]
ÜÜ: ;
public
áá 
async
áá 
Task
áá 
<
áá 
ActionResult
áá &
>
áá& '
AssignRoleToUser
áá( 8
(
áá8 9
[
áá9 :
FromBody
áá: B
]
ááB C
AssignUserRoleDto
ááD U
values
ááV \
)
áá\ ]
{
àà 	
var
èè 
result
èè 
=
èè 
await
èè 
_menuService
èè +
.
èè+ ,
AssignUserRole
èè, :
(
èè: ;
values
èè; A
)
èèA B
;
èèB C
if
ëë 
(
ëë 
result
ëë 
is
ëë 
null
ëë 
)
ëë 
{
íí 
return
ìì 

BadRequest
ìì !
(
ìì! "
$"
ìì" $
$str
ìì$ 2
{
ìì2 3
values
ìì3 9
.
ìì9 :
EmailAddress
ìì: F
}
ììF G
$str
ììG _
"
ìì_ `
)
ìì` a
;
ììa b
}
îî 
if
ññ 
(
ññ 
result
ññ 
!
ññ 
.
ññ 
	Succeeded
ññ !
)
ññ! "
{
óó 
return
òò 
Ok
òò 
(
òò 
result
òò  
)
òò  !
;
òò! "
}
ôô 
return
õõ 

BadRequest
õõ 
(
õõ 
result
õõ $
.
õõ$ %
Errors
õõ% +
)
õõ+ ,
;
õõ, -
}
ùù 	
[
†† 	
HttpPost
††	 
]
†† 
[
°° 	
Route
°°	 
(
°° 
$str
°° (
)
°°( )
]
°°) *
[
¢¢ 	
	Authorize
¢¢	 
(
¢¢ 
Policy
¢¢ 
=
¢¢ 
$str
¢¢ 9
)
¢¢9 :
]
¢¢: ;
public
££ 
async
££ 
Task
££ 
<
££ 
ActionResult
££ &
>
££& '%
AssignPermissionsToRole
££( ?
(
££? @
[
££@ A
FromBody
££A I
]
££I J)
PermissionsAccessModulesDto
££K f
values
££g m
)
££m n
{
§§ 	
return
•• 
Ok
•• 
(
•• 
await
•• 
_menuService
•• (
.
••( )$
AssignPermissionToRole
••) ?
(
••? @
values
••@ F
)
••F G
)
••G H
;
••H I
}
¶¶ 	
[
®® 	
HttpGet
®®	 
]
®® 
[
©© 	
Route
©©	 
(
©© 
$str
©© ,
)
©©, -
]
©©- .
public
™™ 
Task
™™ 
<
™™ 
IEnumerable
™™ 
<
™™  -
PermissionsAccessModulesReadDto
™™  ?
>
™™? @
>
™™@ A 
GetUserPermissions
™™B T
(
™™T U
string
™™U [
userId
™™\ b
)
™™b c
{
´´ 	
return
¨¨ 
null
¨¨ 
!
¨¨ 
;
¨¨ 
}
ÆÆ 	
[
∞∞ 	
HttpGet
∞∞	 
]
∞∞ 
[
±± 	
Route
±±	 
(
±± 
$str
±± ,
)
±±, -
]
±±- .
public
≤≤ 
async
≤≤ 
Task
≤≤ 
<
≤≤ -
PermissionsAccessModulesReadDto
≤≤ 9
>
≤≤9 : 
GetRolePermissions
≤≤; M
(
≤≤M N
string
≤≤N T
roleId
≤≤U [
)
≤≤[ \
{
≥≥ 	
return
¥¥ 
await
¥¥ 
_menuService
¥¥ %
.
¥¥% &!
GetRolesPermissions
¥¥& 9
(
¥¥9 :
roleId
¥¥: @
)
¥¥@ A
;
¥¥A B
}
µµ 	
[
∑∑ 	
HttpPut
∑∑	 
]
∑∑ 
[
∏∏ 	
Route
∏∏	 
(
∏∏ 
$str
∏∏ 0
)
∏∏0 1
]
∏∏1 2
private
ππ 
async
ππ 
Task
ππ 
<
ππ 
ActionResult
ππ '
>
ππ' (-
UpdatePermissionsAssignedToRole
ππ) H
(
ππH I
[
ππI J
FromBody
ππJ R
]
ππR S-
PermissionsAccessModulesReadDto
ππT s
values
ππt z
)
ππz {
{
∫∫ 	
return
ªª 
Ok
ªª 
(
ªª 
await
ªª 
_menuService
ªª (
.
ªª( )-
UpdatePermissionsAssignedToRole
ªª) H
(
ªªH I
values
ªªI O
)
ªªO P
)
ªªP Q
;
ªªQ R
}
ºº 	
[
øø 	
HttpPut
øø	 
]
øø 
[
¿¿ 	
Route
¿¿	 
(
¿¿ 
$str
¿¿ "
)
¿¿" #
]
¿¿# $
[
¡¡ 	
	Authorize
¡¡	 
(
¡¡ 
Policy
¡¡ 
=
¡¡ 
$str
¡¡ 5
)
¡¡5 6
]
¡¡6 7
public
¬¬ 
async
¬¬ 
Task
¬¬ 
<
¬¬ 
ActionResult
¬¬ &
>
¬¬& '
VerifyUserAccount
¬¬( 9
(
¬¬9 :
[
¬¬: ;
FromBody
¬¬; C
]
¬¬C D"
VerifyUserAccountDto
¬¬E Y
values
¬¬Z `
)
¬¬` a
{
√√ 	
var
ƒƒ 
userId
ƒƒ 
=
ƒƒ !
_userContextService
ƒƒ ,
.
ƒƒ, -
	GetUserId
ƒƒ- 6
(
ƒƒ6 7
)
ƒƒ7 8
;
ƒƒ8 9
if
≈≈ 
(
≈≈ 
!
≈≈ 
string
≈≈ 
.
≈≈ 
Equals
≈≈ 
(
≈≈ 
userId
≈≈ %
,
≈≈% &
values
≈≈' -
.
≈≈- .

verifiedBy
≈≈. 8
)
≈≈8 9
)
≈≈9 :
{
∆∆ 
return
«« 
Unauthorized
«« #
(
««# $
)
««$ %
;
««% &
}
»» 
var
   
result
   
=
   
await
   
_adminService
   ,
.
  , -#
VerifyCustomerAccount
  - B
(
  B C
values
  C I
)
  I J
;
  J K
if
ÃÃ 
(
ÃÃ 
result
ÃÃ 
.
ÃÃ 
	IsSuccess
ÃÃ 
)
ÃÃ  
{
ÕÕ 
return
ŒŒ 
Ok
ŒŒ 
(
ŒŒ 
result
ŒŒ  
.
ŒŒ  !
SuccessResponse
ŒŒ! 0
)
ŒŒ0 1
;
ŒŒ1 2
}
œœ 
var
—— 
status
—— 
=
—— 
result
—— 
.
——  
ErrorResponse
——  -
!
——- .
.
——. /

StatusCode
——/ 9
;
——9 :
return
”” 
status
”” 
switch
””  
{
‘‘ 
$num
’’ 
=>
’’ 
	NoContent
’’  
(
’’  !
)
’’! "
,
’’" #
$num
÷÷ 
=>
÷÷ 

BadRequest
÷÷ !
(
÷÷! "
result
÷÷" (
.
÷÷( )
ErrorResponse
÷÷) 6
)
÷÷6 7
,
÷÷7 8
$num
◊◊ 
=>
◊◊ 
NotFound
◊◊ 
(
◊◊  
result
◊◊  &
.
◊◊& '
ErrorResponse
◊◊' 4
)
◊◊4 5
,
◊◊5 6
$num
ÿÿ 
=>
ÿÿ 
Conflict
ÿÿ 
(
ÿÿ  
result
ÿÿ  &
.
ÿÿ& '
ErrorResponse
ÿÿ' 4
)
ÿÿ4 5
,
ÿÿ5 6
_
ŸŸ 
=>
ŸŸ 

StatusCode
ŸŸ 
(
ŸŸ  
$num
ŸŸ  #
,
ŸŸ# $
result
ŸŸ% +
)
ŸŸ+ ,
,
ŸŸ, -
}
⁄⁄ 
;
⁄⁄ 
}
€€ 	
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
ﬂﬂ 5
)
ﬂﬂ5 6
]
ﬂﬂ6 7
[
‡‡ 	
Obsolete
‡‡	 
]
‡‡ 
public
·· 
async
·· 
Task
·· 
<
·· 
ActionResult
·· &
>
··& '
RejectUserAccount
··( 9
(
··9 :
[
··: ;
FromBody
··; C
]
··C D"
RejectUserAccountDto
··E Y
values
··Z `
)
··` a
{
‚‚ 	
var
„„ 
userId
„„ 
=
„„ !
_userContextService
„„ ,
.
„„, -
	GetUserId
„„- 6
(
„„6 7
)
„„7 8
;
„„8 9
if
‰‰ 
(
‰‰ 
!
‰‰ 
string
‰‰ 
.
‰‰ 
Equals
‰‰ 
(
‰‰ 
userId
‰‰ %
,
‰‰% &
values
‰‰' -
.
‰‰- .

RejectedBy
‰‰. 8
)
‰‰8 9
)
‰‰9 :
{
ÂÂ 
return
ÊÊ 
Unauthorized
ÊÊ #
(
ÊÊ# $
)
ÊÊ$ %
;
ÊÊ% &
}
ÁÁ 
var
ÈÈ 
result
ÈÈ 
=
ÈÈ 
await
ÈÈ 
_adminService
ÈÈ ,
.
ÈÈ, -#
RejectCustomerAccount
ÈÈ- B
(
ÈÈB C
values
ÈÈC I
)
ÈÈI J
;
ÈÈJ K
if
ÎÎ 
(
ÎÎ 
result
ÎÎ 
.
ÎÎ 
	IsSuccess
ÎÎ  
)
ÎÎ  !
{
ÏÏ 
return
ÌÌ 
Ok
ÌÌ 
(
ÌÌ 
result
ÌÌ  
.
ÌÌ  !
SuccessResponse
ÌÌ! 0
)
ÌÌ0 1
;
ÌÌ1 2
}
ÓÓ 
var
 
status
 
=
 
result
 
.
  
ErrorResponse
  -
!
- .
.
. /

StatusCode
/ 9
;
9 :
return
ÚÚ 
status
ÚÚ 
switch
ÚÚ  
{
ÛÛ 
$num
ÙÙ 
=>
ÙÙ 
	NoContent
ÙÙ  
(
ÙÙ  !
)
ÙÙ! "
,
ÙÙ" #
$num
ıı 
=>
ıı 

BadRequest
ıı !
(
ıı! "
result
ıı" (
.
ıı( )
ErrorResponse
ıı) 6
)
ıı6 7
,
ıı7 8
$num
ˆˆ 
=>
ˆˆ 
NotFound
ˆˆ 
(
ˆˆ  
result
ˆˆ  &
.
ˆˆ& '
ErrorResponse
ˆˆ' 4
)
ˆˆ4 5
,
ˆˆ5 6
$num
˜˜ 
=>
˜˜ 
Conflict
˜˜ 
(
˜˜  
result
˜˜  &
.
˜˜& '
ErrorResponse
˜˜' 4
)
˜˜4 5
,
˜˜5 6
_
¯¯ 
=>
¯¯ 

StatusCode
¯¯ 
(
¯¯  
$num
¯¯  #
,
¯¯# $
result
¯¯% +
)
¯¯+ ,
,
¯¯, -
}
˘˘ 
;
˘˘ 
}
˙˙ 	
[
¸¸ 	
HttpPut
¸¸	 
]
¸¸ 
[
˝˝ 	
Route
˝˝	 
(
˝˝ 
$str
˝˝ #
)
˝˝# $
]
˝˝$ %
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
˛˛ 6
)
˛˛6 7
]
˛˛7 8
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
ApproveUserAccount
ˇˇ( :
(
ˇˇ: ;
[
ˇˇ; <
FromBody
ˇˇ< D
]
ˇˇD E#
ApproveUserAccountDto
ˇˇF [
values
ˇˇ\ b
)
ˇˇb c
{
ÄÄ 	
var
ÅÅ 
userId
ÅÅ 
=
ÅÅ !
_userContextService
ÅÅ ,
.
ÅÅ, -
	GetUserId
ÅÅ- 6
(
ÅÅ6 7
)
ÅÅ7 8
;
ÅÅ8 9
if
ÇÇ 
(
ÇÇ 
!
ÇÇ 
string
ÇÇ 
.
ÇÇ 
Equals
ÇÇ 
(
ÇÇ 
userId
ÇÇ %
,
ÇÇ% &
values
ÇÇ' -
.
ÇÇ- .

ApprovedBy
ÇÇ. 8
)
ÇÇ8 9
)
ÇÇ9 :
{
ÉÉ 
return
ÑÑ 
Unauthorized
ÑÑ #
(
ÑÑ# $
)
ÑÑ$ %
;
ÑÑ% &
}
ÖÖ 
var
áá 
result
áá 
=
áá 
await
áá 
_adminService
áá ,
.
áá, - 
ApproveUserAccount
áá- ?
(
áá? @
values
áá@ F
)
ááF G
;
ááG H
if
ââ 
(
ââ 
result
ââ 
.
ââ 
	IsSuccess
ââ  
)
ââ  !
{
ää 
return
ãã 
Ok
ãã 
(
ãã 
result
ãã  
.
ãã  !
SuccessResponse
ãã! 0
)
ãã0 1
;
ãã1 2
}
åå 
var
éé 
status
éé 
=
éé 
result
éé 
.
éé  
ErrorResponse
éé  -
!
éé- .
.
éé. /

StatusCode
éé/ 9
;
éé9 :
return
êê 
status
êê 
switch
êê  
{
ëë 
$num
íí 
=>
íí 
	NoContent
íí  
(
íí  !
)
íí! "
,
íí" #
$num
ìì 
=>
ìì 

BadRequest
ìì !
(
ìì! "
result
ìì" (
.
ìì( )
ErrorResponse
ìì) 6
)
ìì6 7
,
ìì7 8
$num
îî 
=>
îî 
NotFound
îî 
(
îî  
result
îî  &
.
îî& '
ErrorResponse
îî' 4
)
îî4 5
,
îî5 6
$num
ïï 
=>
ïï 
Conflict
ïï 
(
ïï  
result
ïï  &
.
ïï& '
ErrorResponse
ïï' 4
)
ïï4 5
,
ïï5 6
_
ññ 
=>
ññ 

StatusCode
ññ 
(
ññ  
$num
ññ  #
,
ññ# $
result
ññ% +
)
ññ+ ,
,
ññ, -
}
óó 
;
óó 
}
ôô 	
[
õõ 	
HttpPut
õõ	 
]
õõ 
[
úú 	
Route
úú	 
(
úú 
$str
úú &
)
úú& '
]
úú' (
[
ùù 	
	Authorize
ùù	 
(
ùù 
Policy
ùù 
=
ùù 
$str
ùù 9
)
ùù9 :
]
ùù: ;
public
ûû 
async
ûû 
Task
ûû 
<
ûû 
ActionResult
ûû &
>
ûû& '#
DisapproveUserAccount
ûû( =
(
ûû= >
[
ûû> ?
FromBody
ûû? G
]
ûûG H'
DisapprovedUserAccountDto
ûûI b
values
ûûc i
)
ûûi j
{
üü 	
var
†† 
userId
†† 
=
†† !
_userContextService
†† ,
.
††, -
	GetUserId
††- 6
(
††6 7
)
††7 8
;
††8 9
if
°° 
(
°° 
!
°° 
string
°° 
.
°° 
Equals
°° 
(
°° 
userId
°° %
,
°°% &
values
°°' -
.
°°- .
DisapprovedBy
°°. ;
)
°°; <
)
°°< =
{
¢¢ 
return
££ 
Unauthorized
££ #
(
££# $
)
££$ %
;
££% &
}
§§ 
var
¶¶ 
result
¶¶ 
=
¶¶ 
await
¶¶ 
_adminService
¶¶ ,
.
¶¶, -#
DisapproveUserAccount
¶¶- B
(
¶¶B C
values
¶¶C I
)
¶¶I J
;
¶¶J K
if
®® 
(
®® 
result
®® 
.
®® 
	IsSuccess
®®  
)
®®  !
{
©© 
return
™™ 
Ok
™™ 
(
™™ 
result
™™  
.
™™  !
SuccessResponse
™™! 0
)
™™0 1
;
™™1 2
}
´´ 
var
≠≠ 
status
≠≠ 
=
≠≠ 
result
≠≠ 
.
≠≠  
ErrorResponse
≠≠  -
!
≠≠- .
.
≠≠. /

StatusCode
≠≠/ 9
;
≠≠9 :
return
ØØ 
status
ØØ 
switch
ØØ  
{
∞∞ 
$num
±± 
=>
±± 
	NoContent
±±  
(
±±  !
)
±±! "
,
±±" #
$num
≤≤ 
=>
≤≤ 

BadRequest
≤≤ !
(
≤≤! "
result
≤≤" (
.
≤≤( )
ErrorResponse
≤≤) 6
)
≤≤6 7
,
≤≤7 8
$num
≥≥ 
=>
≥≥ 
NotFound
≥≥ 
(
≥≥  
result
≥≥  &
.
≥≥& '
ErrorResponse
≥≥' 4
)
≥≥4 5
,
≥≥5 6
$num
¥¥ 
=>
¥¥ 
Conflict
¥¥ 
(
¥¥  
result
¥¥  &
.
¥¥& '
ErrorResponse
¥¥' 4
)
¥¥4 5
,
¥¥5 6
_
µµ 
=>
µµ 

StatusCode
µµ 
(
µµ  
$num
µµ  #
,
µµ# $
result
µµ% +
)
µµ+ ,
,
µµ, -
}
∂∂ 
;
∂∂ 
}
∑∑ 	
[
ππ 	
HttpPut
ππ	 
]
ππ 
[
∫∫ 	
Route
∫∫	 
(
∫∫ 
$str
∫∫ $
)
∫∫$ %
]
∫∫% &
[
ªª 	
	Authorize
ªª	 
(
ªª 
Policy
ªª 
=
ªª 
$str
ªª 7
)
ªª7 8
]
ªª8 9
public
ºº 
async
ºº 
Task
ºº 
<
ºº 
ActionResult
ºº &
>
ºº& '!
ActivateUserAccount
ºº( ;
(
ºº; <
[
ºº< =
FromBody
ºº= E
]
ººE F$
ActivateUserAccountDto
ººG ]
values
ºº^ d
)
ººd e
{
ΩΩ 	
var
ææ 
userId
ææ 
=
ææ !
_userContextService
ææ ,
.
ææ, -
	GetUserId
ææ- 6
(
ææ6 7
)
ææ7 8
;
ææ8 9
if
øø 
(
øø 
!
øø 
string
øø 
.
øø 
Equals
øø 
(
øø 
userId
øø %
,
øø% &
values
øø' -
.
øø- .
activatedBy
øø. 9
)
øø9 :
)
øø: ;
{
¿¿ 
return
¡¡ 
Unauthorized
¡¡ #
(
¡¡# $
)
¡¡$ %
;
¡¡% &
}
¬¬ 
var
ƒƒ 
result
ƒƒ 
=
ƒƒ 
await
ƒƒ 
_adminService
ƒƒ ,
.
ƒƒ, -!
ActivateUserAccount
ƒƒ- @
(
ƒƒ@ A
values
ƒƒA G
)
ƒƒG H
;
ƒƒH I
if
∆∆ 
(
∆∆ 
result
∆∆ 
.
∆∆ 
	IsSuccess
∆∆  
)
∆∆  !
{
«« 
return
»» 
Ok
»» 
(
»» 
result
»»  
.
»»  !
SuccessResponse
»»! 0
)
»»0 1
;
»»1 2
}
…… 
var
ÀÀ 
status
ÀÀ 
=
ÀÀ 
result
ÀÀ 
.
ÀÀ  
ErrorResponse
ÀÀ  -
!
ÀÀ- .
.
ÀÀ. /

StatusCode
ÀÀ/ 9
;
ÀÀ9 :
return
ÕÕ 
status
ÕÕ 
switch
ÕÕ  
{
ŒŒ 
$num
œœ 
=>
œœ 
	NoContent
œœ  
(
œœ  !
)
œœ! "
,
œœ" #
$num
–– 
=>
–– 

BadRequest
–– !
(
––! "
result
––" (
.
––( )
ErrorResponse
––) 6
)
––6 7
,
––7 8
$num
—— 
=>
—— 
NotFound
—— 
(
——  
result
——  &
.
——& '
ErrorResponse
——' 4
)
——4 5
,
——5 6
$num
““ 
=>
““ 
Conflict
““ 
(
““  
result
““  &
.
““& '
ErrorResponse
““' 4
)
““4 5
,
““5 6
_
”” 
=>
”” 

StatusCode
”” 
(
””  
$num
””  #
,
””# $
result
””% +
)
””+ ,
,
””, -
}
‘‘ 
;
‘‘ 
}
’’ 	
[
◊◊ 	
HttpPut
◊◊	 
]
◊◊ 
[
ÿÿ 	
Route
ÿÿ	 
(
ÿÿ 
$str
ÿÿ &
)
ÿÿ& '
]
ÿÿ' (
[
ŸŸ 	
	Authorize
ŸŸ	 
(
ŸŸ 
Policy
ŸŸ 
=
ŸŸ 
$str
ŸŸ 9
)
ŸŸ9 :
]
ŸŸ: ;
public
⁄⁄ 
async
⁄⁄ 
Task
⁄⁄ 
<
⁄⁄ 
ActionResult
⁄⁄ &
>
⁄⁄& '"
DectivateUserAccount
⁄⁄( <
(
⁄⁄< =
[
⁄⁄= >
FromBody
⁄⁄> F
]
⁄⁄F G&
DeactivateUserAccountDto
⁄⁄H `
values
⁄⁄a g
)
⁄⁄g h
{
€€ 	
var
‹‹ 
userId
‹‹ 
=
‹‹ !
_userContextService
‹‹ ,
.
‹‹, -
	GetUserId
‹‹- 6
(
‹‹6 7
)
‹‹7 8
;
‹‹8 9
if
›› 
(
›› 
!
›› 
string
›› 
.
›› 
Equals
›› 
(
›› 
userId
›› %
,
››% &
values
››' -
.
››- .
DeactivatedBy
››. ;
)
››; <
)
››< =
{
ﬁﬁ 
return
ﬂﬂ 
Unauthorized
ﬂﬂ #
(
ﬂﬂ# $
)
ﬂﬂ$ %
;
ﬂﬂ% &
}
‡‡ 
var
‚‚ 
result
‚‚ 
=
‚‚ 
await
‚‚ 
_adminService
‚‚ ,
.
‚‚, -#
DeactivateUserAccount
‚‚- B
(
‚‚B C
values
‚‚C I
)
‚‚I J
;
‚‚J K
if
‰‰ 
(
‰‰ 
result
‰‰ 
.
‰‰ 
	IsSuccess
‰‰  
)
‰‰  !
{
ÂÂ 
return
ÊÊ 
Ok
ÊÊ 
(
ÊÊ 
result
ÊÊ  
.
ÊÊ  !
SuccessResponse
ÊÊ! 0
)
ÊÊ0 1
;
ÊÊ1 2
}
ÁÁ 
var
ÈÈ 
status
ÈÈ 
=
ÈÈ 
result
ÈÈ 
.
ÈÈ  
ErrorResponse
ÈÈ  -
!
ÈÈ- .
.
ÈÈ. /

StatusCode
ÈÈ/ 9
;
ÈÈ9 :
return
ÎÎ 
status
ÎÎ 
switch
ÎÎ  
{
ÏÏ 
$num
ÌÌ 
=>
ÌÌ 
	NoContent
ÌÌ  
(
ÌÌ  !
)
ÌÌ! "
,
ÌÌ" #
$num
ÓÓ 
=>
ÓÓ 

BadRequest
ÓÓ !
(
ÓÓ! "
result
ÓÓ" (
.
ÓÓ( )
ErrorResponse
ÓÓ) 6
)
ÓÓ6 7
,
ÓÓ7 8
$num
ÔÔ 
=>
ÔÔ 
NotFound
ÔÔ 
(
ÔÔ  
result
ÔÔ  &
.
ÔÔ& '
ErrorResponse
ÔÔ' 4
)
ÔÔ4 5
,
ÔÔ5 6
$num
 
=>
 
Conflict
 
(
  
result
  &
.
& '
ErrorResponse
' 4
)
4 5
,
5 6
_
ÒÒ 
=>
ÒÒ 

StatusCode
ÒÒ 
(
ÒÒ  
$num
ÒÒ  #
,
ÒÒ# $
result
ÒÒ% +
)
ÒÒ+ ,
,
ÒÒ, -
}
ÚÚ 
;
ÚÚ 
}
ÛÛ 	
[
˙˙ 	
HttpGet
˙˙	 
]
˙˙ 
[
˚˚ 	
Route
˚˚	 
(
˚˚ 
$str
˚˚ 
)
˚˚  
]
˚˚  !
public
¸¸ 
async
¸¸ 
Task
¸¸ 
<
¸¸ 
ActionResult
¸¸ &
<
¸¸& '
IEnumerable
¸¸' 2
<
¸¸2 3
DepartmentReadDto
¸¸3 D
>
¸¸D E
>
¸¸E F
>
¸¸F G
GetDepartments
¸¸H V
(
¸¸V W
)
¸¸W X
{
˝˝ 	
return
˛˛ 
Ok
˛˛ 
(
˛˛ 
await
˛˛  
_departmentService
˛˛ .
.
˛˛. / 
GetDepartmentAsync
˛˛/ A
(
˛˛A B
)
˛˛B C
)
˛˛C D
;
˛˛D E
}
ˇˇ 	
[
ÑÑ 	
HttpGet
ÑÑ	 
]
ÑÑ 
[
ÖÖ 	
Route
ÖÖ	 
(
ÖÖ 
$str
ÖÖ 2
)
ÖÖ2 3
]
ÖÖ3 4
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
<
ÜÜ& '
IEnumerable
ÜÜ' 2
<
ÜÜ2 3
UnitReadDto
ÜÜ3 >
>
ÜÜ> ?
>
ÜÜ? @
>
ÜÜ@ A 
GetDepartmentUnits
ÜÜB T
(
ÜÜT U
int
ÜÜU X
departmentId
ÜÜY e
)
ÜÜe f
{
áá 	
return
àà 
Ok
àà 
(
àà 
await
àà $
_departmentUnitService
àà 2
.
àà2 3
GetUnitAsync
àà3 ?
(
àà? @
departmentId
àà@ L
)
ààL M
)
ààM N
;
ààN O
}
ââ 	
[
ãã 	
HttpGet
ãã	 
]
ãã 
[
åå 	
Route
åå	 
(
åå 
$str
åå &
)
åå& '
]
åå' (
private
çç 
async
çç 
Task
çç 
<
çç 
ActionResult
çç '
<
çç' (
DepartmentReadDto
çç( 9
>
çç9 :
>
çç: ;
GetDepartment
çç< I
(
ççI J
string
ççJ P
value
ççQ V
)
ççV W
{
éé 	
return
èè 
Ok
èè 
(
èè 
await
èè  
_departmentService
èè .
.
èè. / 
GetDepartmentAsync
èè/ A
(
èèA B
value
èèB G
)
èèG H
)
èèH I
;
èèI J
}
êê 	
[
íí 	
HttpGet
íí	 
]
íí 
[
ìì 	
Route
ìì	 
(
ìì 
$str
ìì 1
)
ìì1 2
]
ìì2 3
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
GetDepartmentById
îî; L
(
îîL M
int
îîM P
departmentId
îîQ ]
)
îî] ^
{
ïï 	
return
ññ 
Ok
ññ 
(
ññ 
await
ññ  
_departmentService
ññ .
.
ññ. / 
GetDepartmentAsync
ññ/ A
(
ññA B
departmentId
ññB N
)
ññN O
)
ññO P
;
ññP Q
}
óó 	
[
ôô 	
HttpPost
ôô	 
]
ôô 
[
öö 	
Route
öö	 
(
öö 
$str
öö !
)
öö! "
]
öö" #
[
õõ 	
	Authorize
õõ	 
(
õõ 
Policy
õõ 
=
õõ 
$str
õõ 5
)
õõ5 6
]
õõ6 7
public
úú 
async
úú 
Task
úú 
<
úú 
ActionResult
úú &
<
úú& '
DepartmentReadDto
úú' 8
>
úú8 9
>
úú9 :
CreateDepartment
úú; K
(
úúK L
[
úúL M
FromBody
úúM U
]
úúU V!
DepartmentCreateDto
úúW j
values
úúk q
)
úúq r
{
ùù 	
try
ûû 
{
üü 
var
†† 
userId
†† 
=
†† !
_userContextService
†† 0
.
††0 1
	GetUserId
††1 :
(
††: ;
)
††; <
;
††< =
if
°° 
(
°° 
!
°° 
string
°° 
.
°° 
Equals
°° "
(
°°" #
userId
°°# )
,
°°) *
values
°°+ 1
.
°°1 2
	CreatedBy
°°2 ;
)
°°; <
)
°°< =
{
¢¢ 
return
££ 
Unauthorized
££ '
(
££' (
)
££( )
;
££) *
}
§§ 
var
¶¶ 
result
¶¶ 
=
¶¶ 
await
¶¶ " 
_departmentService
¶¶# 5
.
¶¶5 6 
AddDepartmentAsync
¶¶6 H
(
¶¶H I
values
¶¶I O
)
¶¶O P
;
¶¶P Q
if
ßß 
(
ßß 
result
ßß 
is
ßß 
null
ßß !
)
ßß! "
{
®® 
return
©© 

BadRequest
©© %
(
©©% &
result
©©& ,
)
©©, -
;
©©- .
}
™™ 
return
¨¨ 

StatusCode
¨¨ !
(
¨¨! "
StatusCodes
¨¨" -
.
¨¨- .
Status201Created
¨¨. >
,
¨¨> ?
result
¨¨@ F
)
¨¨F G
;
¨¨G H
}
ÆÆ 
catch
ØØ 
(
ØØ 
	Exception
ØØ 
ex
ØØ 
)
ØØ  
{
∞∞ 
return
±± 

StatusCode
±± !
(
±±! "
$num
±±" %
,
±±% &
ex
±±' )
.
±±) *
InnerException
±±* 8
!
±±8 9
.
±±9 :
Message
±±: A
)
±±A B
;
±±B C
}
≤≤ 
}
≥≥ 	
[
µµ 	
HttpPut
µµ	 
]
µµ 
[
∂∂ 	
Route
∂∂	 
(
∂∂ 
$str
∂∂ !
)
∂∂! "
]
∂∂" #
[
∑∑ 	
	Authorize
∑∑	 
(
∑∑ 
Policy
∑∑ 
=
∑∑ 
$str
∑∑ 5
)
∑∑5 6
]
∑∑6 7
public
∏∏ 
async
∏∏ 
Task
∏∏ 
<
∏∏ 
ActionResult
∏∏ &
<
∏∏& '
DepartmentReadDto
∏∏' 8
>
∏∏8 9
>
∏∏9 :
UpdateDepartment
∏∏; K
(
∏∏K L
[
∏∏L M
FromBody
∏∏M U
]
∏∏U V!
DepartmentUpdateDto
∏∏W j
values
∏∏k q
)
∏∏q r
{
ππ 	
var
∫∫ 
userId
∫∫ 
=
∫∫ !
_userContextService
∫∫ ,
.
∫∫, -
	GetUserId
∫∫- 6
(
∫∫6 7
)
∫∫7 8
;
∫∫8 9
if
ªª 
(
ªª 
!
ªª 
string
ªª 
.
ªª 
Equals
ªª 
(
ªª 
userId
ªª %
,
ªª% &
values
ªª' -
.
ªª- .

ModifiedBy
ªª. 8
)
ªª8 9
)
ªª9 :
{
ºº 
return
ΩΩ 
Unauthorized
ΩΩ #
(
ΩΩ# $
)
ΩΩ$ %
;
ΩΩ% &
}
ææ 
var
¿¿ 
result
¿¿ 
=
¿¿  
_departmentService
¿¿ +
.
¿¿+ , 
GetDepartmentAsync
¿¿, >
(
¿¿> ?
values
¿¿? E
.
¿¿E F
DepartmentId
¿¿F R
)
¿¿R S
;
¿¿S T
if
¡¡ 
(
¡¡ 
result
¡¡ 
is
¡¡ 
null
¡¡ 
)
¡¡ 
{
¬¬ 
return
√√ 

BadRequest
√√ !
(
√√! "
)
√√" #
;
√√# $
}
ƒƒ 
return
∆∆ 
Ok
∆∆ 
(
∆∆ 
await
∆∆  
_departmentService
∆∆ .
.
∆∆. /#
UpdateDepartmentAsync
∆∆/ D
(
∆∆D E
values
∆∆E K
)
∆∆K L
)
∆∆L M
;
∆∆M N
}
«« 	
[
…… 	

HttpDelete
……	 
(
…… 
$str
…… 5
)
……5 6
]
……6 7
public
   
async
   
Task
   
<
   
ActionResult
   &
>
  & '
DeleteDepartment
  ( 8
(
  8 9
int
  9 <
departmentId
  = I
)
  I J
{
ÀÀ 	
var
ÃÃ 
result
ÃÃ 
=
ÃÃ 
await
ÃÃ  
_departmentService
ÃÃ 1
.
ÃÃ1 2
DeleteDepartment
ÃÃ2 B
(
ÃÃB C
departmentId
ÃÃC O
)
ÃÃO P
;
ÃÃP Q
if
ÕÕ 
(
ÕÕ 
result
ÕÕ 
.
ÕÕ 
response
ÕÕ 
==
ÕÕ !
$str
ÕÕ" +
)
ÕÕ+ ,
{
ŒŒ 
return
œœ 
Ok
œœ 
(
œœ 
result
œœ  
)
œœ  !
;
œœ! "
}
–– 
return
—— 

BadRequest
—— 
(
—— 
result
—— $
)
——$ %
;
——% &
}
““ 	
[
ÿÿ 	
HttpGet
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
ŸŸ #
)
ŸŸ# $
]
ŸŸ$ %
public
⁄⁄ 
async
⁄⁄ 
Task
⁄⁄ 
<
⁄⁄ 
ActionResult
⁄⁄ &
<
⁄⁄& '
IEnumerable
⁄⁄' 2
<
⁄⁄2 3#
DepartmentUnitReadDto
⁄⁄3 H
>
⁄⁄H I
>
⁄⁄I J
>
⁄⁄J K 
GetDepartmentUnits
⁄⁄L ^
(
⁄⁄^ _
)
⁄⁄_ `
{
€€ 	
return
‹‹ 
Ok
‹‹ 
(
‹‹ 
await
‹‹ $
_departmentUnitService
‹‹ 2
.
‹‹2 3$
GetDepartmentUnitAsync
‹‹3 I
(
‹‹I J
)
‹‹J K
)
‹‹K L
;
‹‹L M
}
›› 	
[
ﬂﬂ 	
HttpGet
ﬂﬂ	 
]
ﬂﬂ 
[
‡‡ 	
Route
‡‡	 
(
‡‡ 
$str
‡‡ *
)
‡‡* +
]
‡‡+ ,
private
·· 
async
·· 
Task
·· 
<
·· 
ActionResult
·· '
<
··' (
DepartmentReadDto
··( 9
>
··9 :
>
··: ;
GetDepartmentUnit
··< M
(
··M N
string
··N T
value
··U Z
)
··Z [
{
‚‚ 	
return
„„ 
Ok
„„ 
(
„„ 
await
„„ $
_departmentUnitService
„„ 2
.
„„2 3$
GetDepartmentUnitAsync
„„3 I
(
„„I J
value
„„J O
)
„„O P
)
„„P Q
;
„„Q R
}
‰‰ 	
[
ÊÊ 	
HttpGet
ÊÊ	 
]
ÊÊ 
[
ÁÁ 	
Route
ÁÁ	 
(
ÁÁ 
$str
ÁÁ @
)
ÁÁ@ A
]
ÁÁA B
public
ËË 
async
ËË 
Task
ËË 
<
ËË 
ActionResult
ËË &
<
ËË& '
IEnumerable
ËË' 2
<
ËË2 3#
DepartmentUnitReadDto
ËË3 H
>
ËËH I
>
ËËI J
>
ËËJ K.
 GetDepartmentUnitsByDepartmentId
ËËL l
(
ËËl m
int
ËËm p
departmentId
ËËq }
)
ËË} ~
{
ÈÈ 	
return
ÍÍ 
Ok
ÍÍ 
(
ÍÍ 
await
ÍÍ $
_departmentUnitService
ÍÍ 2
.
ÍÍ2 3$
GetDepartmentUnitAsync
ÍÍ3 I
(
ÍÍI J
departmentId
ÍÍJ V
)
ÍÍV W
)
ÍÍW X
;
ÍÍX Y
}
ÎÎ 	
[
ÌÌ 	
HttpGet
ÌÌ	 
]
ÌÌ 
[
ÓÓ 	
Route
ÓÓ	 
(
ÓÓ 
$str
ÓÓ 9
)
ÓÓ9 :
]
ÓÓ: ;
private
ÔÔ 
async
ÔÔ 
Task
ÔÔ 
<
ÔÔ 
ActionResult
ÔÔ '
<
ÔÔ' (
DepartmentReadDto
ÔÔ( 9
>
ÔÔ9 :
>
ÔÔ: ;#
GetDepartmentUnitById
ÔÔ< Q
(
ÔÔQ R
int
ÔÔR U
departmentUnitId
ÔÔV f
)
ÔÔf g
{
 	
return
ÒÒ 
Ok
ÒÒ 
(
ÒÒ 
await
ÒÒ $
_departmentUnitService
ÒÒ 2
.
ÒÒ2 3$
GetDepartmentUnitAsync
ÒÒ3 I
(
ÒÒI J
departmentUnitId
ÒÒJ Z
)
ÒÒZ [
)
ÒÒ[ \
;
ÒÒ\ ]
}
ÚÚ 	
[
ÙÙ 	
HttpPost
ÙÙ	 
]
ÙÙ 
[
ıı 	
Route
ıı	 
(
ıı 
$str
ıı %
)
ıı% &
]
ıı& '
[
ˆˆ 	
	Authorize
ˆˆ	 
(
ˆˆ 
Policy
ˆˆ 
=
ˆˆ 
$str
ˆˆ 5
)
ˆˆ5 6
]
ˆˆ6 7
public
˜˜ 
async
˜˜ 
Task
˜˜ 
<
˜˜ 
ActionResult
˜˜ &
<
˜˜& '#
DepartmentUnitReadDto
˜˜' <
>
˜˜< =
>
˜˜= >"
CreateDepartmentUnit
˜˜? S
(
˜˜S T
[
˜˜T U
FromBody
˜˜U ]
]
˜˜] ^%
DepartmentUnitCreateDto
˜˜_ v
values
˜˜w }
)
˜˜} ~
{
¯¯ 	
try
˘˘ 
{
˙˙ 
var
˚˚ 
userId
˚˚ 
=
˚˚ !
_userContextService
˚˚ 0
.
˚˚0 1
	GetUserId
˚˚1 :
(
˚˚: ;
)
˚˚; <
;
˚˚< =
if
¸¸ 
(
¸¸ 
!
¸¸ 
string
¸¸ 
.
¸¸ 
Equals
¸¸ "
(
¸¸" #
userId
¸¸# )
,
¸¸) *
values
¸¸+ 1
.
¸¸1 2
	CreatedBy
¸¸2 ;
)
¸¸; <
)
¸¸< =
{
˝˝ 
return
˛˛ 
Unauthorized
˛˛ '
(
˛˛' (
)
˛˛( )
;
˛˛) *
}
ˇˇ 
var
ÅÅ 
result
ÅÅ 
=
ÅÅ 
await
ÅÅ "$
_departmentUnitService
ÅÅ# 9
.
ÅÅ9 :$
AddDepartmentUnitAsync
ÅÅ: P
(
ÅÅP Q
values
ÅÅQ W
)
ÅÅW X
;
ÅÅX Y
if
ÇÇ 
(
ÇÇ 
result
ÇÇ 
is
ÇÇ 
null
ÇÇ "
)
ÇÇ" #
{
ÉÉ 
return
ÑÑ 

BadRequest
ÑÑ %
(
ÑÑ% &
result
ÑÑ& ,
)
ÑÑ, -
;
ÑÑ- .
}
ÖÖ 
return
áá 

StatusCode
áá !
(
áá! "
StatusCodes
áá" -
.
áá- .
Status201Created
áá. >
,
áá> ?
result
áá@ F
)
ááF G
;
ááG H
}
ââ 
catch
ää 
(
ää 
	Exception
ää 
ex
ää 
)
ää  
{
ãã 
return
åå 

StatusCode
åå !
(
åå! "
$num
åå" %
,
åå% &
ex
åå' )
.
åå) *
InnerException
åå* 8
!
åå8 9
.
åå9 :
Message
åå: A
)
ååA B
;
ååB C
}
çç 
}
éé 	
[
êê 	
HttpPut
êê	 
]
êê 
[
ëë 	
Route
ëë	 
(
ëë 
$str
ëë %
)
ëë% &
]
ëë& '
public
íí 
async
íí 
Task
íí 
<
íí 
ActionResult
íí &
<
íí& '
DepartmentReadDto
íí' 8
>
íí8 9
>
íí9 :"
UpdateDepartmentUnit
íí; O
(
ííO P
[
ííP Q
FromBody
ííQ Y
]
ííY Z%
DepartmentUnitUpdateDto
íí[ r
values
íís y
)
ííy z
{
ìì 	
var
îî 
userId
îî 
=
îî !
_userContextService
îî ,
.
îî, -
	GetUserId
îî- 6
(
îî6 7
)
îî7 8
;
îî8 9
if
ïï 
(
ïï 
!
ïï 
string
ïï 
.
ïï 
Equals
ïï 
(
ïï 
userId
ïï %
,
ïï% &
values
ïï' -
.
ïï- .

ModifiedBy
ïï. 8
)
ïï8 9
)
ïï9 :
{
ññ 
return
óó 
Unauthorized
óó #
(
óó# $
)
óó$ %
;
óó% &
}
òò 
var
öö 
result
öö 
=
öö $
_departmentUnitService
öö /
.
öö/ 0$
GetDepartmentUnitAsync
öö0 F
(
ööF G
values
ööG M
.
ööM N
UnitId
ööN T
)
ööT U
;
ööU V
if
õõ 
(
õõ 
result
õõ 
is
õõ 
null
õõ 
)
õõ 
{
úú 
return
ùù 

BadRequest
ùù !
(
ùù! "
)
ùù" #
;
ùù# $
}
ûû 
return
†† 
Ok
†† 
(
†† 
await
†† $
_departmentUnitService
†† 2
.
††2 3'
UpdateDepartmentUnitAsync
††3 L
(
††L M
values
††M S
)
††S T
)
††T U
;
††U V
}
°° 	
[
££ 	

HttpDelete
££	 
(
££ 
$str
££ 3
)
££3 4
]
££4 5
public
§§ 
async
§§ 
Task
§§ 
<
§§ 
ActionResult
§§ &
>
§§& '"
DeleteDepartmentUnit
§§( <
(
§§< =
int
§§= @
unitId
§§A G
)
§§G H
{
•• 	
var
¶¶ 
result
¶¶ 
=
¶¶ 
await
¶¶ $
_departmentUnitService
¶¶ 5
.
¶¶5 6"
DeleteDepartmentUnit
¶¶6 J
(
¶¶J K
unitId
¶¶K Q
)
¶¶Q R
;
¶¶R S
if
ßß 
(
ßß 
result
ßß 
.
ßß 
response
ßß 
==
ßß  "
$str
ßß# ,
)
ßß, -
{
®® 
return
©© 
Ok
©© 
(
©© 
result
©©  
)
©©  !
;
©©! "
}
™™ 
return
´´ 

BadRequest
´´ 
(
´´ 
result
´´ $
)
´´$ %
;
´´% &
}
¨¨ 	
[
ÆÆ 	
HttpGet
ÆÆ	 
]
ÆÆ 
[
ØØ 	
Route
ØØ	 
(
ØØ 
$str
ØØ #
)
ØØ# $
]
ØØ$ %
[
∞∞ 	
AllowAnonymous
∞∞	 
]
∞∞ 
public
±± 
IActionResult
±± #
GetRegistrationStatus
±± 2
(
±±2 3
)
±±3 4
{
≤≤ 	
var
≥≥ 
types
≥≥ 
=
≥≥ 
Enum
≥≥ 
.
≥≥ 
	GetValues
≥≥ &
(
≥≥& '
typeof
≥≥' -
(
≥≥- . 
RegistrationStatus
≥≥. @
)
≥≥@ A
)
≥≥A B
.
¥¥# $
Cast
¥¥$ (
<
¥¥( ) 
RegistrationStatus
¥¥) ;
>
¥¥; <
(
¥¥< =
)
¥¥= >
.
µµ# $
Select
µµ$ *
(
µµ* +
e
µµ+ ,
=>
µµ- /
new
µµ0 3
{
∂∂# $
Id
∑∑' )
=
∑∑* +
(
∑∑, -
int
∑∑- 0
)
∑∑0 1
e
∑∑1 2
,
∑∑2 3
Name
∏∏' +
=
∏∏, -
e
∏∏. /
.
∏∏/ 0
ToString
∏∏0 8
(
∏∏8 9
)
∏∏9 :
,
∏∏: ;
DisplayName
ππ' 2
=
ππ3 4
e
ππ5 6
.
ππ6 7
GetType
ππ7 >
(
ππ> ?
)
ππ? @
.
∫∫5 6
GetField
∫∫6 >
(
∫∫> ?
e
∫∫? @
.
∫∫@ A
ToString
∫∫A I
(
∫∫I J
)
∫∫J K
)
∫∫K L
!
∫∫L M
.
ªª5 6 
GetCustomAttribute
ªª6 H
<
ªªH I"
DescriptionAttribute
ªªI ]
>
ªª] ^
(
ªª^ _
)
ªª_ `
?
ªª` a
.
ºº5 6
Description
ºº6 A
}
ææ# $
)
ææ$ %
;
ææ% &
return
øø 
Ok
øø 
(
øø 
types
øø 
)
øø 
;
øø 
}
¿¿ 	
[
∆∆ 	
HttpGet
∆∆	 
]
∆∆ 
[
«« 	
Route
««	 
(
«« 
$str
«« '
)
««' (
]
««( )
public
»» 
async
»» 
Task
»» 
<
»» 
ActionResult
»» &
<
»»& '
IEnumerable
»»' 2
<
»»2 3(
IIdentificationTypeService
»»3 M
>
»»M N
>
»»N O
>
»»O P$
GetIdentificationTypes
»»Q g
(
»»g h
)
»»h i
{
…… 	
return
   
Ok
   
(
   
await
   (
_identificationTypeService
   6
.
  6 7(
GetIdentificationTypeAsync
  7 Q
(
  Q R
)
  R S
)
  S T
;
  T U
}
ÀÀ 	
[
ŒŒ 	
HttpPost
ŒŒ	 
]
ŒŒ 
[
œœ 	
Route
œœ	 
(
œœ 
$str
œœ )
)
œœ) *
]
œœ* +
[
–– 	
	Authorize
––	 
(
–– 
Policy
–– 
=
–– 
$str
–– 5
)
––5 6
]
––6 7
public
—— 
async
—— 
Task
—— 
<
—— 
ActionResult
—— &
<
——& '
ChannelReadDto
——' 5
>
——5 6
>
——6 7&
CreateIdentificationType
——8 P
(
——P Q
[
——Q R
FromBody
——R Z
]
——Z [#
IdentificationTypeDto
——\ q
values
——r x
)
——x y
{
““ 	
try
”” 
{
‘‘ 
var
÷÷ 
result
÷÷ 
=
÷÷ 
await
÷÷ "(
_identificationTypeService
÷÷# =
.
÷÷= >(
AddIdentificationTypeAsync
÷÷> X
(
÷÷X Y
values
÷÷Y _
)
÷÷_ `
;
÷÷` a
if
◊◊ 
(
◊◊ 
result
◊◊ 
is
◊◊ 
null
◊◊ "
)
◊◊" #
{
ÿÿ 
return
ŸŸ 

BadRequest
ŸŸ %
(
ŸŸ% &
result
ŸŸ& ,
)
ŸŸ, -
;
ŸŸ- .
}
⁄⁄ 
return
‹‹ 

StatusCode
‹‹ !
(
‹‹! "
StatusCodes
‹‹" -
.
‹‹- .
Status201Created
‹‹. >
,
‹‹> ?
new
‹‹@ C
{
‹‹D E
response
‹‹F N
=
‹‹O P
result
‹‹Q W
}
‹‹X Y
)
‹‹Y Z
;
‹‹Z [
}
ﬁﬁ 
catch
ﬂﬂ 
(
ﬂﬂ 
	Exception
ﬂﬂ 
ex
ﬂﬂ 
)
ﬂﬂ  
{
‡‡ 
return
·· 

StatusCode
·· !
(
··! "
$num
··" %
,
··% &
ex
··' )
.
··) *
InnerException
··* 8
!
··8 9
.
··9 :
Message
··: A
)
··A B
;
··B C
}
‚‚ 
}
„„ 	
[
ÂÂ 	
HttpPut
ÂÂ	 
]
ÂÂ 
[
ÊÊ 	
Route
ÊÊ	 
(
ÊÊ 
$str
ÊÊ )
)
ÊÊ) *
]
ÊÊ* +
public
ÁÁ 
async
ÁÁ 
Task
ÁÁ 
<
ÁÁ 
ActionResult
ÁÁ &
<
ÁÁ& '
ChannelReadDto
ÁÁ' 5
>
ÁÁ5 6
>
ÁÁ6 7&
UpdateIdentificationType
ÁÁ8 P
(
ÁÁP Q
[
ÁÁQ R
FromBody
ÁÁR Z
]
ÁÁZ [#
IdentificationTypeDto
ÁÁ\ q
values
ÁÁr x
)
ÁÁx y
{
ËË 	
var
ÍÍ 
result
ÍÍ 
=
ÍÍ 
await
ÍÍ (
_identificationTypeService
ÍÍ 9
.
ÍÍ9 :+
UpdateIdentificationTypeAsync
ÍÍ: W
(
ÍÍW X
values
ÍÍX ^
)
ÍÍ^ _
;
ÍÍ_ `
if
ÏÏ 
(
ÏÏ 
result
ÏÏ 
is
ÏÏ 
null
ÏÏ 
)
ÏÏ 
{
ÌÌ 
return
ÓÓ 

BadRequest
ÓÓ !
(
ÓÓ! "
)
ÓÓ" #
;
ÓÓ# $
}
ÔÔ 
return
ÒÒ 
Ok
ÒÒ 
(
ÒÒ 
new
ÒÒ 
{
ÒÒ 
response
ÒÒ $
=
ÒÒ% &
result
ÒÒ' -
}
ÒÒ. /
)
ÒÒ/ 0
;
ÒÒ0 1
}
ÚÚ 	
[
ÙÙ 	

HttpDelete
ÙÙ	 
(
ÙÙ 
$str
ÙÙ E
)
ÙÙE F
]
ÙÙF G
public
ıı 
async
ıı 
Task
ıı 
<
ıı 
ActionResult
ıı &
>
ıı& '&
DeleteIdentificationType
ıı( @
(
ıı@ A
int
ııA D"
identificationTypeId
ııE Y
)
ııY Z
{
ˆˆ 	
var
˜˜ 
result
˜˜ 
=
˜˜ 
await
˜˜ (
_identificationTypeService
˜˜ 9
.
˜˜9 :+
DeleteIdentificationTypeAsync
˜˜: W
(
˜˜W X"
identificationTypeId
˜˜X l
)
˜˜l m
;
˜˜m n
if
˘˘ 
(
˘˘ 
result
˘˘ 
!=
˘˘ 
$str
˘˘ #
)
˘˘# $
return
˙˙ 

BadRequest
˙˙ !
(
˙˙! "
)
˙˙" #
;
˙˙# $
return
¸¸ 
Ok
¸¸ 
(
¸¸ 
new
¸¸ 
{
¸¸ 
response
¸¸ $
=
¸¸% &
result
¸¸' -
}
¸¸. /
)
¸¸/ 0
;
¸¸0 1
}
˝˝ 	
[
ÑÑ 	
HttpGet
ÑÑ	 
]
ÑÑ 
[
ÖÖ 	
Route
ÖÖ	 
(
ÖÖ 
$str
ÖÖ 
)
ÖÖ 
]
ÖÖ  
[
ÜÜ 	
	Authorize
ÜÜ	 
(
ÜÜ 
Roles
ÜÜ 
=
ÜÜ 
$str
ÜÜ :
)
ÜÜ: ;
]
ÜÜ; <
public
áá 
async
áá 
Task
áá 
<
áá 
ActionResult
áá &
<
áá& '
IEnumerable
áá' 2
<
áá2 3$
AdministrationStaffDto
áá3 I
>
ááI J
>
ááJ K
>
ááK L$
GetAdministrationStaff
ááM c
(
áác d
)
áád e
{
àà 	
return
ââ 
Ok
ââ 
(
ââ 
await
ââ 
_adminService
ââ )
.
ââ) *$
GetAdministrationStaff
ââ* @
(
ââ@ A
)
ââA B
)
ââB C
;
ââC D
}
ää 	
[
èè 	
HttpGet
èè	 
]
èè 
[
êê 	
Route
êê	 
(
êê 
$str
êê !
)
êê! "
]
êê" #
public
ëë 
async
ëë 
Task
ëë 
<
ëë 
ActionResult
ëë &
<
ëë& '
IEnumerable
ëë' 2
<
ëë2 3'
AdministrationCustomerDto
ëë3 L
>
ëëL M
>
ëëM N
>
ëëN O(
GetAdministrationCustomers
ëëP j
(
ëëj k
)
ëëk l
{
íí 	
return
ìì 
Ok
ìì 
(
ìì 
await
ìì 
_adminService
ìì )
.
ìì) *'
GetAdministrationCustomer
ìì* C
(
ììC D
)
ììD E
)
ììE F
;
ììF G
}
îî 	
[
ôô 	
HttpGet
ôô	 
]
ôô 
[
öö 	
Route
öö	 
(
öö 
$str
öö #
)
öö# $
]
öö$ %
[
õõ 	
	Authorize
õõ	 
(
õõ 
Roles
õõ 
=
õõ 
$str
õõ :
)
õõ: ;
]
õõ; <
public
úú 
async
úú 
Task
úú 
<
úú 
ActionResult
úú &
<
úú& '
IEnumerable
úú' 2
<
úú2 3'
AdministrationPartnersDto
úú3 L
>
úúL M
>
úúM N
>
úúN O&
GetAdministrationPartner
úúP h
(
úúh i
)
úúi j
{
ùù 	
return
ûû 
Ok
ûû 
(
ûû 
await
ûû 
_adminService
ûû )
.
ûû) *'
GetAdministrationPartners
ûû* C
(
ûûC D
)
ûûD E
)
ûûE F
;
ûûF G
}
üü 	
[
•• 	
HttpGet
••	 
]
•• 
[
¶¶ 	
Route
¶¶	 
(
¶¶ 
$str
¶¶ 7
)
¶¶7 8
]
¶¶8 9
public
ßß 
async
ßß 
Task
ßß 
<
ßß 
ActionResult
ßß &
<
ßß& '
IEnumerable
ßß' 2
<
ßß2 3$
AdministrationStaffDto
ßß3 I
>
ßßI J
>
ßßJ K
>
ßßK L.
 GetAdministrationDepartmentStaff
ßßM m
(
ßßm n
int
ßßn q
departmentId
ßßr ~
)
ßß~ 
{
®® 	
return
©© 
Ok
©© 
(
©© 
await
©© 
_adminService
©© )
.
©©) *.
 GetAdministrationDepartmentStaff
©©* J
(
©©J K
departmentId
©©K W
)
©©W X
)
©©X Y
;
©©Y Z
}
™™ 	
[
ØØ 	
HttpGet
ØØ	 
]
ØØ 
[
∞∞ 	
Route
∞∞	 
(
∞∞ 
$str
∞∞ 5
)
∞∞5 6
]
∞∞6 7
public
±± 
async
±± 
Task
±± 
<
±± 
ActionResult
±± &
<
±±& '
IEnumerable
±±' 2
<
±±2 3$
AdministrationStaffDto
±±3 I
>
±±I J
>
±±J K
>
±±K L2
$GetAdministrationDepartmentUnitStaff
±±M q
(
±±q r
int
±±r u
unitId
±±v |
)
±±| }
{
≤≤ 	
return
≥≥ 
Ok
≥≥ 
(
≥≥ 
await
≥≥ 
_adminService
≥≥ )
.
≥≥) *2
$GetAdministrationDepartmentUnitStaff
≥≥* N
(
≥≥N O
unitId
≥≥O U
)
≥≥U V
)
≥≥V W
;
≥≥W X
}
¥¥ 	
}
∑∑ 
}∏∏ ¬‹
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
ÚÚ 
HttpPost
ÚÚ 
]
ÚÚ 
[
ÛÛ 
AllowAnonymous
ÛÛ 
]
ÛÛ 
[
ÙÙ 
Route
ÙÙ 

(
ÙÙ
 
$str
ÙÙ 
)
ÙÙ 
]
ÙÙ 
public
ıı 

async
ıı 
Task
ıı 
<
ıı 
IActionResult
ıı #
>
ıı# $
ResetPassword
ıı% 2
(
ıı2 3
[
ıı3 4
FromBody
ıı4 <
]
ıı< =%
ResetPasswordRequestDto
ıı> U"
resetPasswordRequest
ııV j
)
ııj k
{
ˆˆ 
try
˜˜ 
{
¯¯ 	#
ResetPasswordResponse
˘˘ !
changeResult
˘˘" .
=
˘˘/ 0
null
˘˘1 5
!
˘˘5 6
;
˘˘7 8
if
˚˚ 
(
˚˚ 

ModelState
˚˚ 
.
˚˚ 
IsValid
˚˚ "
)
˚˚" #
{
¸¸ %
ResetPasswordRequestDto
˛˛ '
passwordRequest
˛˛( 7
=
˛˛8 9
new
˛˛: =%
ResetPasswordRequestDto
˛˛> U
{
ˇˇ 
Phone_OR_Email
ÄÄ "
=
ÄÄ# $"
resetPasswordRequest
ÄÄ% 9
.
ÄÄ9 :
Phone_OR_Email
ÄÄ: H
,
ÄÄH I
Token
ÅÅ 
=
ÅÅ "
resetPasswordRequest
ÅÅ 0
.
ÅÅ0 1
Token
ÅÅ1 6
,
ÅÅ6 7
NewPassword
ÇÇ 
=
ÇÇ  !"
resetPasswordRequest
ÇÇ" 6
.
ÇÇ6 7
NewPassword
ÇÇ7 B
,
ÇÇB C 
ConfirmNewPassword
ÉÉ &
=
ÉÉ' ("
resetPasswordRequest
ÉÉ) =
.
ÉÉ= > 
ConfirmNewPassword
ÉÉ> P
}
ÑÑ 
;
ÑÑ 
if
áá 
(
áá 

emailRegex
áá 
.
áá 
IsMatch
áá &
(
áá& '"
resetPasswordRequest
áá' ;
.
áá; <
Phone_OR_Email
áá< J
!
ááJ K
)
ááK L
)
ááL M
{
àà 
changeResult
ââ  
=
ââ! "
await
ââ# ("
_userAccountsService
ââ) =
.
ââ= >*
ResetPasswordViaEmailAddress
ââ> Z
(
ââZ [
passwordRequest
ââ[ j
)
ââj k
;
ââk l
}
ää 
if
çç 
(
çç 

phoneRegex
çç 
.
çç 
IsMatch
çç &
(
çç& '"
resetPasswordRequest
çç' ;
.
çç; <
Phone_OR_Email
çç< J
!
ççJ K
)
ççK L
)
ççL M
{
éé 
changeResult
èè  
=
èè! "
await
èè# ("
_userAccountsService
èè) =
.
èè= >/
!ResetPasswordViaMobilePhoneNumber
èè> _
(
èè_ `
passwordRequest
èè` o
)
èèo p
;
èèp q
}
êê 
if
íí 
(
íí 
changeResult
íí  
.
íí  !
	IsSuccess
íí! *
)
íí* +
{
ìì 
return
îî 
Ok
îî 
(
îî 
changeResult
îî *
.
îî* +
SuccessResponse
îî+ :
)
îî: ;
;
îî; <
}
ïï 
var
óó 
status
óó 
=
óó 
changeResult
óó )
.
óó) *
ErrorResponse
óó* 7
!
óó7 8
.
óó8 9

StatusCode
óó9 C
;
óóC D
switch
ôô 
(
ôô 
status
ôô 
)
ôô 
{
öö 
case
õõ 
$num
õõ 
:
õõ 
return
úú 
	NoContent
úú (
(
úú( )
)
úú) *
;
úú* +
case
ùù 
$num
ùù 
:
ùù 
return
ûû 

BadRequest
ûû )
(
ûû) *
changeResult
ûû* 6
.
ûû6 7
ErrorResponse
ûû7 D
)
ûûD E
;
ûûE F
case
üü 
$num
üü 
:
üü 
return
†† 
NotFound
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
††C D
case
°° 
$num
°° 
:
°° 
return
¢¢ 
Conflict
¢¢ '
(
¢¢' (
changeResult
¢¢( 4
.
¢¢4 5
ErrorResponse
¢¢5 B
)
¢¢B C
;
¢¢C D
default
££ 
:
££ 
return
§§ 

StatusCode
§§ )
(
§§) *
$num
§§* -
,
§§- .
changeResult
§§/ ;
)
§§; <
;
§§< =
}
•• 
;
•• 
}
ßß 
return
©© 

BadRequest
©© 
(
©© 
)
©© 
;
©©  
}
™™ 	
catch
´´ 
(
´´ 
	Exception
´´ 
ex
´´ 
)
´´ 
{
¨¨ 	
return
≠≠ 

StatusCode
≠≠ 
(
≠≠ 
$num
≠≠ !
,
≠≠! "
ex
≠≠# %
.
≠≠% &
Message
≠≠& -
)
≠≠- .
;
≠≠. /
}
ÆÆ 	
}
ØØ 
[
∑∑ 
HttpPost
∑∑ 
]
∑∑ 
[
∏∏ 
AllowAnonymous
∏∏ 
]
∏∏ 
[
ππ 
Route
ππ 

(
ππ
 
$str
ππ 
)
ππ 
]
ππ 
[
∫∫ "
ProducesResponseType
∫∫ 
(
∫∫ 
$num
∫∫ 
,
∫∫ 
Type
∫∫ #
=
∫∫$ %
typeof
∫∫& ,
(
∫∫, -
LoginResponseDto
∫∫- =
)
∫∫= >
)
∫∫> ?
]
∫∫? @
public
ªª 

async
ªª 
Task
ªª 
<
ªª 
IActionResult
ªª #
>
ªª# $
	UserLogin
ªª% .
(
ªª. /
[
ªª/ 0
FromBody
ªª0 8
]
ªª8 9
LoginRequestDto
ªª: I

loginModel
ªªJ T
)
ªªT U
{
ºº 
try
ΩΩ 
{
ææ 	
if
øø 
(
øø 

ModelState
øø 
.
øø 
IsValid
øø "
)
øø" #
{
¿¿ 
LoginRequestDto
¬¬ 
loginRequest
¬¬  ,
=
¬¬- .
new
¬¬/ 2
LoginRequestDto
¬¬3 B
{
√√ 
Phone_OR_Email
ƒƒ "
=
ƒƒ# $

loginModel
ƒƒ% /
.
ƒƒ/ 0
Phone_OR_Email
ƒƒ0 >
,
ƒƒ> ?
Password
≈≈ 
=
≈≈ 

loginModel
≈≈ )
.
≈≈) *
Password
≈≈* 2
}
∆∆ 
;
∆∆ 
if
»» 
(
»» 

emailRegex
»» 
.
»» 
IsMatch
»» &
(
»»& '

loginModel
»»' 1
.
»»1 2
Phone_OR_Email
»»2 @
!
»»@ A
)
»»A B
)
»»B C
{
…… 
var
   
result
   
=
    
await
  ! &"
_userAccountsService
  ' ;
.
  ; <#
LoginWithEmailAddress
  < Q
(
  Q R
loginRequest
  R ^
)
  ^ _
;
  _ `
switch
ÃÃ 
(
ÃÃ 
result
ÃÃ "
.
ÃÃ" #
LoginStatus
ÃÃ# .
)
ÃÃ. /
{
ÕÕ 
case
ŒŒ 
true
ŒŒ !
:
ŒŒ! "
return
œœ "
Ok
œœ# %
(
œœ% &
result
œœ& ,
)
œœ, -
;
œœ- .
case
–– 
false
–– "
:
––" #
var
—— 
status
——  &
=
——' (
result
——) /
.
——/ 0
errorResponse
——0 =
!
——= >
.
——> ?

StatusCode
——? I
;
——I J
return
”” "
status
””# )
switch
””* 0
{
‘‘ 
$num
’’  #
=>
’’$ &
	NoContent
’’' 0
(
’’0 1
)
’’1 2
,
’’2 3
$num
÷÷  #
=>
÷÷$ &

BadRequest
÷÷' 1
(
÷÷1 2
result
÷÷2 8
.
÷÷8 9
errorResponse
÷÷9 F
)
÷÷F G
,
÷÷G H
$num
◊◊  #
=>
◊◊$ &
NotFound
◊◊' /
(
◊◊/ 0
result
◊◊0 6
.
◊◊6 7
errorResponse
◊◊7 D
)
◊◊D E
,
◊◊E F
$num
ÿÿ  #
=>
ÿÿ$ &
Conflict
ÿÿ' /
(
ÿÿ/ 0
result
ÿÿ0 6
.
ÿÿ6 7
errorResponse
ÿÿ7 D
)
ÿÿD E
,
ÿÿE F
$num
ŸŸ  #
=>
ŸŸ$ &

StatusCode
ŸŸ' 1
(
ŸŸ1 2
$num
ŸŸ2 5
,
ŸŸ5 6
result
ŸŸ7 =
.
ŸŸ= >
errorResponse
ŸŸ> K
)
ŸŸK L
,
ŸŸL M
_
⁄⁄  !
=>
⁄⁄" $

StatusCode
⁄⁄% /
(
⁄⁄/ 0
$num
⁄⁄0 3
,
⁄⁄3 4
result
⁄⁄5 ;
)
⁄⁄; <
,
⁄⁄< =
}
€€ 
;
€€ 
}
ﬁﬁ 
}
ﬂﬂ 
if
·· 
(
·· 

phoneRegex
·· 
.
·· 
IsMatch
·· &
(
··& '

loginModel
··' 1
.
··1 2
Phone_OR_Email
··2 @
!
··@ A
)
··A B
)
··B C
{
‚‚ 
var
„„ 
result
„„ 
=
„„  
await
„„! &"
_userAccountsService
„„' ;
.
„„; <(
LoginWithMobilePhoneNumber
„„< V
(
„„V W
loginRequest
„„W c
)
„„c d
;
„„d e
switch
ÂÂ 
(
ÂÂ 
result
ÂÂ "
.
ÂÂ" #
LoginStatus
ÂÂ# .
)
ÂÂ. /
{
ÊÊ 
case
ÁÁ 
true
ÁÁ !
:
ÁÁ! "
return
ËË "
Ok
ËË# %
(
ËË% &
result
ËË& ,
)
ËË, -
;
ËË- .
case
ÈÈ 
false
ÈÈ "
:
ÈÈ" #
var
ÍÍ 
status
ÍÍ  &
=
ÍÍ' (
result
ÍÍ) /
.
ÍÍ/ 0
errorResponse
ÍÍ0 =
!
ÍÍ= >
.
ÍÍ> ?

StatusCode
ÍÍ? I
;
ÍÍI J
return
ÏÏ "
status
ÏÏ# )
switch
ÏÏ* 0
{
ÌÌ 
$num
ÓÓ  #
=>
ÓÓ$ &
	NoContent
ÓÓ' 0
(
ÓÓ0 1
)
ÓÓ1 2
,
ÓÓ2 3
$num
ÔÔ  #
=>
ÔÔ$ &

BadRequest
ÔÔ' 1
(
ÔÔ1 2
result
ÔÔ2 8
.
ÔÔ8 9
errorResponse
ÔÔ9 F
)
ÔÔF G
,
ÔÔG H
$num
  #
=>
$ &
NotFound
' /
(
/ 0
result
0 6
.
6 7
errorResponse
7 D
)
D E
,
E F
$num
ÒÒ  #
=>
ÒÒ$ &
Conflict
ÒÒ' /
(
ÒÒ/ 0
result
ÒÒ0 6
.
ÒÒ6 7
errorResponse
ÒÒ7 D
)
ÒÒD E
,
ÒÒE F
$num
ÚÚ  #
=>
ÚÚ$ &

StatusCode
ÚÚ' 1
(
ÚÚ1 2
$num
ÚÚ2 5
,
ÚÚ5 6
result
ÚÚ7 =
.
ÚÚ= >
errorResponse
ÚÚ> K
)
ÚÚK L
,
ÚÚL M
_
ÛÛ  !
=>
ÛÛ" $

StatusCode
ÛÛ% /
(
ÛÛ/ 0
$num
ÛÛ0 3
,
ÛÛ3 4
result
ÛÛ5 ;
)
ÛÛ; <
,
ÛÛ< =
}
ÙÙ 
;
ÙÙ 
}
ıı 
}
ˆˆ 
}
˘˘ 
return
˚˚ 

BadRequest
˚˚ 
(
˚˚ 
new
˚˚ !
{
˚˚" #

statusCode
˚˚# -
=
˚˚. /
$num
˚˚0 3
,
˚˚3 4
message
˚˚5 <
=
˚˚= >
$str
˚˚? q
}
˚˚r s
)
˚˚s t
;
˚˚t u
}
¸¸ 	
catch
˝˝ 
(
˝˝ 
	Exception
˝˝ 
ex
˝˝ 
)
˝˝ 
{
˛˛ 	
return
ˇˇ 

StatusCode
ˇˇ 
(
ˇˇ 
$num
ˇˇ !
,
ˇˇ! "
ex
ˇˇ# %
.
ˇˇ% &
Message
ˇˇ& -
)
ˇˇ- .
;
ˇˇ. /
}
ÄÄ 	
}
ÅÅ 
[
ÜÜ 
HttpPost
ÜÜ 
]
ÜÜ 
[
áá 
AllowAnonymous
áá 
]
áá 
[
àà 
Route
àà 

(
àà
 
$str
àà 
)
àà 
]
àà 
[
ââ "
ProducesResponseType
ââ 
(
ââ 
$num
ââ 
,
ââ 
Type
ââ #
=
ââ$ %
typeof
ââ& ,
(
ââ, -%
RefreshTokenResponseDto
ââ- D
)
ââD E
)
ââE F
]
ââF G
public
ää 

async
ää 
Task
ää 
<
ää 
IActionResult
ää #
>
ää# $
RefreshToken
ää% 1
(
ää1 2
[
ää2 3
FromBody
ää3 ;
]
ää; <$
RefreshTokenRequestDto
ää= S
request
ääT [
)
ää[ \
{
ãã 
try
åå 
{
çç 	
if
éé 
(
éé 

ModelState
éé 
.
éé 
IsValid
éé "
)
éé" #
{
èè 
var
êê 
result
êê 
=
êê 
await
êê #"
_userAccountsService
êê$ 8
.
êê8 9 
RefreshBearerToken
êê9 K
(
êêK L
request
êêL S
)
êêS T
;
êêT U
if
ëë 
(
ëë 
result
ëë 
.
ëë 
	IsSuccess
ëë $
)
ëë$ %
{
íí 
return
ìì 
Ok
ìì 
(
ìì 
result
ìì $
.
ìì$ %
SuccessResponse
ìì% 4
)
ìì4 5
;
ìì5 6
}
îî 
var
ññ 
status
ññ 
=
ññ 
result
ññ #
.
ññ# $
ErrorResponse
ññ$ 1
!
ññ1 2
.
ññ2 3

StatusCode
ññ3 =
;
ññ= >
return
óó 
status
óó 
switch
óó $
{
òò 
$num
ôô 
=>
ôô 

BadRequest
ôô %
(
ôô% &
result
ôô& ,
.
ôô, -
ErrorResponse
ôô- :
)
ôô: ;
,
ôô; <
$num
öö 
=>
öö 
NotFound
öö #
(
öö# $
result
öö$ *
.
öö* +
ErrorResponse
öö+ 8
)
öö8 9
,
öö9 :
$num
õõ 
=>
õõ 

StatusCode
õõ %
(
õõ% &
$num
õõ& )
,
õõ) *
result
õõ+ 1
.
õõ1 2
ErrorResponse
õõ2 ?
)
õõ? @
,
õõ@ A
_
úú 
=>
úú 

StatusCode
úú #
(
úú# $
$num
úú$ '
,
úú' (
result
úú) /
)
úú/ 0
,
úú0 1
}
ùù 
;
ùù 
}
ûû 
return
†† 

BadRequest
†† 
(
†† 
)
†† 
;
††  
}
°° 	
catch
¢¢ 
(
¢¢ 
	Exception
¢¢ 
ex
¢¢ 
)
¢¢ 
{
££ 	
return
§§ 

StatusCode
§§ 
(
§§ 
$num
§§ !
,
§§! "
ex
§§# %
.
§§% &
Message
§§& -
)
§§- .
;
§§. /
}
•• 	
}
¶¶ 
[
´´ 
HttpGet
´´ 
]
´´ 
[
¨¨ 
Route
¨¨ 

(
¨¨
 
$str
¨¨ 
)
¨¨ 
]
¨¨ 
public
ÆÆ 

async
ÆÆ 
Task
ÆÆ 
<
ÆÆ 
ActionResult
ÆÆ "
>
ÆÆ" #
UserDetails
ÆÆ$ /
(
ÆÆ/ 0
string
ÆÆ0 6
userId
ÆÆ7 =
)
ÆÆ= >
{
ØØ 
var
∞∞ 
user
∞∞ 
=
∞∞ 
await
∞∞ 
_unitOfWork
∞∞ $
.
∞∞$ %
Users
∞∞% *
.
∞∞* +
Get
∞∞+ .
(
∞∞. /
u
∞∞/ 0
=>
∞∞1 3
u
∞∞4 5
.
∞∞5 6
Id
∞∞6 8
==
∞∞9 ;
userId
∞∞< B
)
∞∞B C
;
∞∞C D
if
±± 

(
±± 
user
±± 
is
±± 
null
±± 
)
±± 
return
≤≤ 
NotFound
≤≤ 
(
≤≤ 
new
≤≤ 
{
≤≤  !
message
≤≤" )
=
≤≤* +
$str
≤≤, ?
}
≤≤@ A
)
≤≤A B
;
≤≤B C
return
¥¥ 
Ok
¥¥ 
(
¥¥ 
await
¥¥ "
_userAccountsService
¥¥ ,
.
¥¥, -
UserDetails
¥¥- 8
(
¥¥8 9
userId
¥¥9 ?
)
¥¥? @
)
¥¥@ A
;
¥¥A B
}
µµ 
[
∫∫ 
HttpPost
∫∫ 
]
∫∫ 
[
ªª 
AllowAnonymous
ªª 
]
ªª 
[
ºº 
Route
ºº 

(
ºº
 
$str
ºº 
)
ºº 
]
ºº 
[
ΩΩ "
ProducesResponseType
ΩΩ 
(
ΩΩ 
$num
ΩΩ 
,
ΩΩ 
Type
ΩΩ #
=
ΩΩ$ %
typeof
ΩΩ& ,
(
ΩΩ, -
TokenResponseDto
ΩΩ- =
)
ΩΩ= >
)
ΩΩ> ?
]
ΩΩ? @
public
ææ 

async
ææ 
Task
ææ 
<
ææ 
IActionResult
ææ #
>
ææ# $
SendOTPToken
ææ% 1
(
ææ1 2
[
ææ2 3
FromBody
ææ3 ;
]
ææ; <&
TokenRequestParameterDto
ææ= U
value
ææV [
)
ææ[ \
{
øø 
try
¿¿ 
{
¡¡ 	
if
¬¬ 
(
¬¬ 
string
¬¬ 
.
¬¬  
IsNullOrWhiteSpace
¬¬ )
(
¬¬) *
value
¬¬* /
.
¬¬/ 0
phone_OR_email
¬¬0 >
)
¬¬> ?
)
¬¬? @
{
√√ 
return
ƒƒ 

BadRequest
ƒƒ !
(
ƒƒ! "
)
ƒƒ" #
;
ƒƒ# $
}
≈≈ 
if
«« 
(
«« 

ModelState
«« 
.
«« 
IsValid
«« "
)
««" #
{
»» 
if
…… 
(
…… 

emailRegex
…… 
.
…… 
IsMatch
…… &
(
……& '
value
……' ,
.
……, -
phone_OR_email
……- ;
!
……; <
)
……< =
)
……= >
{
   
var
ÀÀ 
result
ÀÀ 
=
ÀÀ  
await
ÀÀ! &
_unitOfWork
ÀÀ' 2
.
ÀÀ2 3

TokenStore
ÀÀ3 =
.
ÀÀ= >
GetToken
ÀÀ> F
(
ÀÀF G
value
ÀÀG L
.
ÀÀL M
phone_OR_email
ÀÀM [
!
ÀÀ[ \
,
ÀÀ\ ]
$num
ÀÀ^ _
)
ÀÀ_ `
;
ÀÀ` a
if
ÃÃ 
(
ÃÃ 
result
ÃÃ 
.
ÃÃ 
Length
ÃÃ $
!=
ÃÃ% '
$num
ÃÃ( )
)
ÃÃ) *
{
ÕÕ 
return
ŒŒ 
NotFound
ŒŒ '
(
ŒŒ' (
new
ŒŒ( +
{
ŒŒ, -
message
ŒŒ. 5
=
ŒŒ6 7
result
ŒŒ8 >
}
ŒŒ? @
)
ŒŒ@ A
;
ŒŒA B
}
œœ 
return
–– 
Ok
–– 
(
–– 
new
–– !
TokenResponseDto
––" 2
(
––2 3
result
––3 9
)
––9 :
)
––: ;
;
––; <
}
—— 
if
‘‘ 
(
‘‘ 

phoneRegex
‘‘ 
.
‘‘ 
IsMatch
‘‘ &
(
‘‘& '
value
‘‘' ,
.
‘‘, -
phone_OR_email
‘‘- ;
!
‘‘; <
)
‘‘< =
)
‘‘= >
{
’’ 
var
÷÷ 
result
÷÷ 
=
÷÷  
await
÷÷! &
_unitOfWork
÷÷' 2
.
÷÷2 3

TokenStore
÷÷3 =
.
÷÷= >
GetToken
÷÷> F
(
÷÷F G
value
÷÷G L
.
÷÷L M
phone_OR_email
÷÷M [
!
÷÷[ \
,
÷÷\ ]
$num
÷÷^ _
)
÷÷_ `
;
÷÷` a
if
◊◊ 
(
◊◊ 
result
◊◊ 
.
◊◊ 
Length
◊◊ %
!=
◊◊& (
$num
◊◊) *
)
◊◊* +
{
ÿÿ 
return
ŸŸ 
NotFound
ŸŸ '
(
ŸŸ' (
new
ŸŸ( +
{
ŸŸ, -
message
ŸŸ. 5
=
ŸŸ6 7
result
ŸŸ8 >
}
ŸŸ? @
)
ŸŸ@ A
;
ŸŸA B
}
⁄⁄ 
return
€€ 
Ok
€€ 
(
€€ 
new
€€ !
TokenResponseDto
€€" 2
(
€€2 3
result
€€3 9
)
€€9 :
)
€€: ;
;
€€; <
}
‹‹ 
}
›› 
return
ﬂﬂ 
NotFound
ﬂﬂ 
(
ﬂﬂ 
new
ﬂﬂ 
{
ﬂﬂ  !
message
ﬂﬂ! (
=
ﬂﬂ) *
$str
ﬂﬂ+ b
}
ﬂﬂc d
)
ﬂﬂd e
;
ﬂﬂe f
}
‡‡ 	
catch
·· 
(
·· 
	Exception
·· 
ex
·· 
)
·· 
{
‚‚ 	
return
„„ 

StatusCode
„„ 
(
„„ 
$num
„„ !
,
„„! "
ex
„„# %
.
„„% &
Message
„„& -
)
„„- .
;
„„. /
}
‰‰ 	
}
ÂÂ 
[
ÍÍ 
HttpPost
ÍÍ 
]
ÍÍ 
[
ÎÎ 
AllowAnonymous
ÎÎ 
]
ÎÎ 
[
ÏÏ 
Route
ÏÏ 

(
ÏÏ
 
$str
ÏÏ 
)
ÏÏ 
]
ÏÏ 
[
ÌÌ "
ProducesResponseType
ÌÌ 
(
ÌÌ 
$num
ÌÌ 
,
ÌÌ 
Type
ÌÌ #
=
ÌÌ$ %
typeof
ÌÌ& ,
(
ÌÌ, -
TokenResponseDto
ÌÌ- =
)
ÌÌ= >
)
ÌÌ> ?
]
ÌÌ? @
public
ÓÓ 

async
ÓÓ 
Task
ÓÓ 
<
ÓÓ 
IActionResult
ÓÓ #
>
ÓÓ# $
VerifyOTPToken
ÓÓ% 3
(
ÓÓ3 4
[
ÓÓ4 5
FromBody
ÓÓ5 =
]
ÓÓ= >#
VerifyTokenRequestDto
ÓÓ? T 
verifyTokenRequest
ÓÓU g
)
ÓÓg h
{
ÔÔ 
try
 
{
ÒÒ 	
if
ÚÚ 
(
ÚÚ 
string
ÚÚ 
.
ÚÚ  
IsNullOrWhiteSpace
ÚÚ (
(
ÚÚ( ) 
verifyTokenRequest
ÚÚ) ;
.
ÚÚ; <
phone_OR_email
ÚÚ< J
)
ÚÚJ K
||
ÚÚL N
string
ÚÚO U
.
ÚÚU V 
IsNullOrWhiteSpace
ÚÚV h
(
ÚÚh i 
verifyTokenRequest
ÚÚi {
.
ÚÚ{ |
tokenÚÚ| Å
)ÚÚÅ Ç
)ÚÚÇ É
{
ÛÛ 
return
ÙÙ 

BadRequest
ÙÙ !
(
ÙÙ! "
)
ÙÙ" #
;
ÙÙ# $
}
ıı 
if
˜˜ 
(
˜˜ 

ModelState
˜˜ 
.
˜˜ 
IsValid
˜˜ "
)
˜˜" #
{
¯¯ 
if
˙˙ 
(
˙˙ 

emailRegex
˙˙ 
.
˙˙ 
IsMatch
˙˙ &
(
˙˙& ' 
verifyTokenRequest
˙˙' 9
.
˙˙9 :
phone_OR_email
˙˙: H
!
˙˙H I
)
˙˙I J
)
˙˙J K
{
˚˚ 
var
¸¸ 
result
¸¸ 
=
¸¸  
await
¸¸! &
_unitOfWork
¸¸' 2
.
¸¸2 3

TokenStore
¸¸3 =
.
¸¸= >
VerifyToken
¸¸> I
(
¸¸I J 
verifyTokenRequest
¸¸J \
.
¸¸\ ]
phone_OR_email
¸¸] k
,
¸¸k l 
verifyTokenRequest
¸¸m 
.¸¸ Ä
token¸¸Ä Ö
)¸¸Ö Ü
;¸¸Ü á
if
˝˝ 
(
˝˝ 
result
˝˝ 
!=
˝˝  
$str
˝˝! +
)
˝˝+ ,
{
˛˛ 
return
ˇˇ 

BadRequest
ˇˇ )
(
ˇˇ) *
new
ˇˇ* -
{
ˇˇ. /
message
ˇˇ0 7
=
ˇˇ8 9
result
ˇˇ: @
}
ˇˇA B
)
ˇˇB C
;
ˇˇC D
}
ÄÄ 
return
ÅÅ 
Ok
ÅÅ 
(
ÅÅ 
new
ÅÅ !
{
ÅÅ" #
message
ÅÅ$ +
=
ÅÅ, -
result
ÅÅ. 4
}
ÅÅ5 6
)
ÅÅ6 7
;
ÅÅ7 8
}
ÇÇ 
if
ÖÖ 
(
ÖÖ 

phoneRegex
ÖÖ 
.
ÖÖ 
IsMatch
ÖÖ &
(
ÖÖ& ' 
verifyTokenRequest
ÖÖ' 9
.
ÖÖ9 :
phone_OR_email
ÖÖ: H
!
ÖÖH I
)
ÖÖI J
)
ÖÖJ K
{
ÜÜ 
var
áá 
result
áá 
=
áá  
await
áá! &
_unitOfWork
áá' 2
.
áá2 3

TokenStore
áá3 =
.
áá= >
VerifyToken
áá> I
(
ááI J 
verifyTokenRequest
ááJ \
.
áá\ ]
phone_OR_email
áá] k
,
áák l 
verifyTokenRequest
áám 
.áá Ä
tokenááÄ Ö
)ááÖ Ü
;ááÜ á
if
àà 
(
àà 
result
àà 
!=
àà !
$str
àà" ,
)
àà, -
{
ââ 
return
ää 

BadRequest
ää )
(
ää) *
new
ää* -
{
ää. /
message
ää0 7
=
ää8 9
result
ää: @
}
ääA B
)
ääB C
;
ääC D
}
ãã 
return
åå 
Ok
åå 
(
åå 
new
åå !
{
åå" #
message
åå$ +
=
åå, -
result
åå. 4
}
åå5 6
)
åå6 7
;
åå7 8
}
çç 
}
èè 
return
ëë 
NotFound
ëë 
(
ëë 
)
ëë 
;
ëë 
}
íí 	
catch
ìì 
(
ìì 
	Exception
ìì 
ex
ìì 
)
ìì 
{
îî 	
return
ïï 

StatusCode
ïï 
(
ïï 
$num
ïï !
,
ïï! "
ex
ïï# %
.
ïï% &
Message
ïï& -
)
ïï- .
;
ïï. /
}
ññ 	
}
òò 
[
ùù 
HttpPut
ùù 
]
ùù 
[
ûû 
AllowAnonymous
ûû 
]
ûû 
[
üü 
Route
üü 

(
üü
 
$str
üü 
)
üü 
]
üü  
[
†† "
ProducesResponseType
†† 
(
†† 
$num
†† 
,
†† 
Type
†† #
=
††$ %
typeof
††& ,
(
††, - 
UserInformationDto
††- ?
)
††? @
)
††@ A
]
††A B
public
°° 

async
°° 
Task
°° 
<
°° 
IActionResult
°° #
>
°°# $
UpdateUserAccount
°°% 6
(
°°6 7
[
°°7 8
FromBody
°°8 @
]
°°@ A
UpdateUserDto
°°B O
UserUpdateRequest
°°P a
)
°°a b
{
¢¢ 
try
££ 
{
§§ 	
if
•• 
(
•• 

ModelState
•• 
.
•• 
IsValid
•• "
)
••" #
{
¶¶ 
var
ßß 
result
ßß 
=
ßß 
await
ßß ""
_userAccountsService
ßß# 7
.
ßß7 8"
UpdateAccountDetails
ßß8 L
(
ßßL M
UserUpdateRequest
ßßM ^
)
ßß^ _
;
ßß_ `
if
©© 
(
©© 
result
©© 
.
©© 
success
©© "
is
©©# %
not
©©& )
null
©©* .
)
©©. /
{
™™ 
return
´´ 
Ok
´´ 
(
´´ 
result
´´ $
.
´´$ %
success
´´% ,
)
´´, -
;
´´- .
}
¨¨ 
else
≠≠ 
{
ÆÆ 
return
ØØ 

BadRequest
ØØ %
(
ØØ% &
result
ØØ& ,
.
ØØ, -
error
ØØ- 2
)
ØØ2 3
;
ØØ3 4
}
∞∞ 
}
±± 
return
≥≥ 
NotFound
≥≥ 
(
≥≥ 
)
≥≥ 
;
≥≥ 
}
¥¥ 	
catch
µµ 
(
µµ 
	Exception
µµ 
ex
µµ 
)
µµ 
{
∂∂ 	
return
∑∑ 

StatusCode
∑∑ 
(
∑∑ 
$num
∑∑ !
,
∑∑! "
ex
∑∑# %
.
∑∑% &
Message
∑∑& -
)
∑∑- .
;
∑∑. /
}
∏∏ 	
}
∫∫ 
}ºº 