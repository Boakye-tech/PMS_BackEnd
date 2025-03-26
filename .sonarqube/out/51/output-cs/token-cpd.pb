h
f/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Usings.cs�k
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
GetConnectionString	66o �
(
66� �
$str
66� �
)
66� �
)
66� �
.
66� �"
EnableDetailedErrors
66� �
(
66� �
)
66� �
.
66� �(
EnableSensitiveDataLogging
66� �
(
66� �
)
66� �
)
66� �
;
66� �
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
GetConnectionString	DDo �
(
DD� �
$str
DD� �
)
DD� �
)
DD� �
)
DD� �
;
DD� �
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
;	mm �
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
�� 
UseRateLimiter
�� 
(
�� 
)
�� 
;
�� 
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
�
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
}22 �K
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
(	dd �
)
dd� �
;
dd� �
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
�� 
.
�� 
AddAutoMapper
�� "
(
��" #
	AppDomain
��# ,
.
��, -
CurrentDomain
��- :
.
��: ;
GetAssemblies
��; H
(
��H I
)
��I J
)
��J K
;
��K L
return
�� 
services
�� 
;
�� 
}
�� 	
}
�� 
}�� �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Filters/HttpGlobalExceptionFilter.cs
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
cancellationToken	t �
)
� �
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
}## �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v2/AccountController.cs
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
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -
LoginResponseDto
��- =
)
��= >
)
��> ?
]
��? @
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
	UserLogin
��% .
(
��. /
[
��/ 0
FromBody
��0 8
]
��8 9
LoginRequestDto
��: I

loginModel
��J T
)
��T U
{
�� 
try
�� 
{
�� 	
var
�� 

emailRegex
�� 
=
�� 
new
��  
Regex
��! &
(
��& '
$str
��' D
)
��D E
;
��E F
var
�� 

phoneRegex
�� 
=
�� 
new
��  
Regex
��! &
(
��& '
$str
��' 8
)
��8 9
;
��9 :
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
if
�� 
(
�� 

emailRegex
�� 
.
�� 
IsMatch
�� &
(
��& '

loginModel
��' 1
.
��1 2
Phone_OR_Email
��2 @
!
��@ A
)
��A B
)
��B C
{
�� 
LoginRequestDto
�� #
loginRequest
��$ 0
=
��1 2
new
��3 6
LoginRequestDto
��7 F
{
�� 
Phone_OR_Email
�� &
=
��' (

loginModel
��) 3
.
��3 4
Phone_OR_Email
��4 B
,
��B C
Password
��  
=
��! "

loginModel
��# -
.
��- .
Password
��. 6
}
�� 
;
�� 
var
�� 
result
�� 
=
��  
await
��! &"
_userAccountsService
��' ;
.
��; <#
LoginWithEmailAddress
��< Q
(
��Q R
loginRequest
��R ^
)
��^ _
;
��_ `
switch
�� 
(
�� 
result
�� "
.
��" #
LoginStatus
��# .
)
��. /
{
�� 
case
�� 
true
�� !
:
��! "
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
case
�� 
false
�� "
:
��" #
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
}
�� 
}
�� 
if
�� 
(
�� 

phoneRegex
�� 
.
�� 
IsMatch
�� &
(
��& '

loginModel
��' 1
.
��1 2
Phone_OR_Email
��2 @
!
��@ A
)
��A B
)
��B C
{
�� 
LoginRequestDto
�� #
loginRequest
��$ 0
=
��1 2
new
��3 6
LoginRequestDto
��7 F
{
�� 
Phone_OR_Email
�� &
=
��' (

loginModel
��) 3
.
��3 4
Phone_OR_Email
��4 B
,
��B C
Password
��  
=
��! "

loginModel
��# -
.
��- .
Password
��. 6
}
�� 
;
�� 
var
�� 
result
�� 
=
��  
await
��! &"
_userAccountsService
��' ;
.
��; <(
LoginWithMobilePhoneNumber
��< V
(
��V W
loginRequest
��W c
)
��c d
;
��d e
switch
�� 
(
�� 
result
�� "
.
��" #
LoginStatus
��# .
)
��. /
{
�� 
case
�� 
true
�� !
:
��! "
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
case
�� 
false
�� "
:
��" #
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
}
�� 
}
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -%
RefreshTokenResponseDto
��- D
)
��D E
)
��E F
]
��F G
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
RefreshToken
��% 1
(
��1 2
[
��2 3
FromBody
��3 ;
]
��; <$
RefreshTokenRequestDto
��= S
request
��T [
)
��[ \
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
	newTokens
�� 
=
�� 
await
��  %"
_userAccountsService
��& :
.
��: ; 
RefreshBearerToken
��; M
(
��M N
request
��N U
)
��U V
;
��V W
return
�� 
Ok
�� 
(
�� 
	newTokens
�� #
)
��# $
;
��$ %
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

IActionResult
�� 
SendSMSToken
�� %
(
��% &
[
��& '
FromBody
��' /
]
��/ 0&
TokenRequestParameterDto
��1 I
value
��J O
)
��O P
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
result
�� 
=
�� 
_unitOfWork
�� (
.
��( )

TokenStore
��) 3
.
��3 4
GetToken
��4 <
(
��< =
value
��= B
.
��B C
phone_OR_email
��C Q
!
��Q R
,
��R S
$num
��S T
)
��T U
;
��U V
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 
NotFound
�� 
(
�� 
)
�� 
;
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

IActionResult
�� 
SendEmailToken
�� '
(
��' (
[
��( )
FromBody
��) 1
]
��1 2&
TokenRequestParameterDto
��3 K
value
��L Q
)
��Q R
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
result
�� 
=
�� 
_unitOfWork
�� (
.
��( )

TokenStore
��) 3
.
��3 4
GetToken
��4 <
(
��< =
value
��= B
.
��B C
phone_OR_email
��C Q
!
��Q R
,
��R S
$num
��S T
)
��T U
;
��U V
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 
NotFound
�� 
(
�� 
)
�� 
;
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
}�� �%
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
}88 ϡ
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v2/AdministrationController.cs
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
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -
DeleteUserRole
��- ;
(
��; <
values
��< B
)
��B C
;
��C D
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
ToString
��! )
(
��) *
)
��* +
)
��+ ,
;
��, -
}
�� 
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
Errors
��) /
)
��/ 0
;
��0 1
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
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
>
��& '
AssignRoleToUser
��( 8
(
��8 9
[
��9 :
FromBody
��: B
]
��B C
AssignUserRoleDto
��D U
values
��V \
)
��\ ]
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_menuService
�� +
.
��+ ,
AssignUserRole
��, :
(
��: ;
values
��; A
)
��A B
;
��B C
if
�� 
(
�� 
result
�� 
is
�� 
null
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� !
(
��! "
$"
��" $
$str
��$ 2
{
��2 3
values
��3 9
.
��9 :
EmailAddress
��: F
}
��F G
$str
��G _
"
��_ `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� 
result
�� 
!
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
.
��$ %
Errors
��% +
)
��+ ,
;
��, -
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
�� (
)
��( )
]
��) *
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
��& '%
AssignPermissionsToRole
��( ?
(
��? @
[
��@ A
FromBody
��A I
]
��I J)
PermissionsAccessModulesDto
��K f
values
��g m
)
��m n
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( )$
AssignPermissionToRole
��) ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
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
�� ,
)
��, -
]
��- .
public
�� 
Task
�� 
<
�� 
IEnumerable
�� 
<
��  )
PermissionsAccessModulesDto
��  ;
>
��; <
>
��< = 
GetUserPermissions
��> P
(
��P Q
string
��Q W
userId
��X ^
)
��^ _
{
�� 	
return
�� 
null
�� 
!
�� 
;
�� 
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
�� ,
)
��, -
]
��- .
public
�� 
Task
�� 
<
�� 
IEnumerable
�� 
<
��  )
PermissionsAccessModulesDto
��  ;
>
��; <
>
��< = 
GetRolePermissions
��> P
(
��P Q
string
��Q W
roleId
��X ^
)
��^ _
{
�� 	
return
�� 
null
�� 
!
�� 
;
�� 
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
>
��& '
VerifyUserAccount
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D"
VerifyUserAccountDto
��E Y
values
��Z `
)
��` a
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
VerifyCustomerAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
�� 
)
��  
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
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
>
��& '
RejectUserAccount
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D"
RejectUserAccountDto
��E Y
values
��Z `
)
��` a
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
RejectCustomerAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
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
>
��& ' 
ApproveUserAccount
��( :
(
��: ;
[
��; <
FromBody
��< D
]
��D E#
ApproveUserAccountDto
��F [
values
��\ b
)
��b c
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, - 
ApproveUserAccount
��- ?
(
��? @
values
��@ F
)
��F G
;
��G H
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
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
>
��& '#
DisapproveUserAccount
��( =
(
��= >
[
��> ?
FromBody
��? G
]
��G H'
DisapprovedUserAccountDto
��I b
values
��c i
)
��i j
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
DisapproveUserAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
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
�� $
)
��$ %
]
��% &
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
��& '!
ActivateUserAccount
��( ;
(
��; <
[
��< =
FromBody
��= E
]
��E F$
ActivateUserAccountDto
��G ]
values
��^ d
)
��d e
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -!
ActivateUserAccount
��- @
(
��@ A
values
��A G
)
��G H
;
��H I
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
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
>
��& '"
DectivateUserAccount
��( <
(
��< =
[
��= >
FromBody
��> F
]
��F G&
DeactivateUserAccountDto
��H `
values
��a g
)
��g h
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
DeactivateUserAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
return
�� 
Problem
�� 
(
�� 
result
�� !
.
��! "
ErrorResponse
��" /
?
��/ 0
.
��0 1
StatusMessage
��1 >
??
��? A
$str
��B a
)
��a b
;
��b c
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v1/AdministrationController.cs
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
IDepartmentUnitService	s �#
departmentUnitService
� �
,
� �
IMenuService
� �
menuService
� �
,
� �
IChannelService
� �
channelService
� �
,
� �(
IIdentificationTypeService
� �'
identificationTypeService
� �
,
� �!
IUserContextService
� � 
userContextService
� �
)
� �
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
�� 
async
�� 
Task
�� 
<
�� 
IEnumerable
�� %
<
��% &
MenusDto
��& .
>
��. /
>
��/ 0
GetMenus
��1 9
(
��9 :
)
��: ;
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &
GetMenus
��& .
(
��. /
)
��/ 0
;
��0 1
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
�� 
)
�� 
]
�� 
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
�� 5
)
��5 6
]
��6 7
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
CreateMenus
��( 3
(
��3 4
[
��4 5
FromBody
��5 =
]
��= >
MenusDto
��? G
values
��H N
)
��N O
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_menuService
�� +
.
��+ ,

CreateMenu
��, 6
(
��6 7
values
��7 =
)
��= >
;
��> ?
return
�� 
Ok
�� 
(
�� 
result
�� 
)
�� 
;
�� 
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
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
IEnumerable
�� %
<
��% &
SubMenusDto
��& 1
>
��1 2
>
��2 3
GetSubMenus
��4 ?
(
��? @
)
��@ A
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &
GetSubMenus
��& 1
(
��1 2
)
��2 3
;
��3 4
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
��  !
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
�� 5
)
��5 6
]
��6 7
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
CreateSubMenus
��( 6
(
��6 7
[
��7 8
FromBody
��8 @
]
��@ A
SubMenusCreateDto
��B S
values
��T Z
)
��Z [
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_menuService
�� +
.
��+ ,
CreateSubMenu
��, 9
(
��9 :
values
��: @
)
��@ A
;
��A B
return
�� 
Ok
�� 
(
�� 
result
�� 
)
�� 
;
�� 
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
�� 
IEnumerable
�� %
<
��% &
SubMenuItemsDto
��& 5
>
��5 6
>
��6 7
GetSubMenuItems
��8 G
(
��G H
)
��H I
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &
GetSubMenuItems
��& 5
(
��5 6
)
��6 7
;
��7 8
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
��' (
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
�� 
IEnumerable
�� %
<
��% &#
ApplicationModulesDto
��& ;
>
��; <
>
��< =#
GetApplicationModules
��> S
(
��S T
)
��T U
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &

GetModules
��& 0
(
��0 1
)
��1 2
;
��2 3
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
��' (
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
��& '#
AddApplicationModules
��( =
(
��= >
[
��> ?
FromBody
��? G
]
��G H)
ApplicationModulesCreateDto
��I d
values
��e k
)
��k l
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( )

AddModules
��) 3
(
��3 4
values
��4 :
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
��* +
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
��& '&
UpdateApplicationModules
��( @
(
��@ A
[
��A B
FromBody
��B J
]
��J K#
ApplicationModulesDto
��L a
values
��b h
)
��h i
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( )
UpdateModules
��) 6
(
��6 7
values
��7 =
)
��= >
)
��> ?
;
��? @
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
�� '
)
��' (
]
��( )
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
��& '$
AssignModulePermission
��( >
(
��> ?
[
��? @
FromBody
��@ H
]
��H I.
 ApplicationModulesPermissionsDto
��J j
values
��k q
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
�� 
_menuService
�� (
.
��( )$
AssignModulePermission
��) ?
(
��? @
values
��@ F
)
��F G
)
��G H
;
��H I
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
�� 7
)
��7 8
]
��8 9
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
�� 
IEnumerable
�� %
<
��% &'
RoleModulesPermissionsDto
��& ?
>
��? @
>
��@ A.
 GetApplicationModulesPermissions
��B b
(
��b c
string
��c i
roleId
��j p
)
��p q
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &#
GetModulesPermissions
��& ;
(
��; <
roleId
��< B
)
��B C
;
��C D
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
�� #
)
��# $
]
��$ %
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
�� 5
)
��5 6
]
��6 7
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
CreateSubMenuItems
��( :
(
��: ;
[
��; <
FromBody
��< D
]
��D E#
SubMenuItemsCreateDto
��F [
values
��\ b
)
��b c
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( ) 
CreateSubMenuItems
��) ;
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
�� 
)
�� 
]
�� 
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
�� 6
,
��6 7
Roles
��8 =
=
��> ?
$str
��@ R
)
��R S
]
��S T
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
ApproveRole
��( 3
(
��3 4
[
��4 5
FromBody
��5 =
]
��= >
RolesApprovalDto
��? O
values
��P V
)
��V W
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

ApprovedBy
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
�� 
_adminService
�� )
.
��) *
ApproveUserRole
��* 9
(
��9 :
values
��: @
)
��@ A
)
��A B
;
��B C
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
��  !
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
,
��9 :
Roles
��; @
=
��A B
$str
��C U
)
��U V
]
��V W
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
DisapproveRole
��( 6
(
��6 7
[
��7 8
FromBody
��8 @
]
��@ A
RolesApprovalDto
��B R
values
��S Y
)
��Y Z
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

ApprovedBy
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
�� 
_adminService
�� )
.
��) *
ApproveUserRole
��* 9
(
��9 :
values
��: @
)
��@ A
)
��A B
;
��B C
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
�� 
List
�� 
<
�� 
RolesDto
�� '
>
��' (
>
��( )"
GetApprovedUserRoles
��* >
(
��> ?
)
��? @
{
�� 	
return
�� 
await
�� 
_adminService
�� &
.
��& '"
GetApprovedUserRoles
��' ;
(
��; <
)
��< =
;
��= >
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
�� 6
)
��6 7
]
��7 8
public
�� 
async
�� 
Task
�� 
<
�� 
List
�� 
<
�� 
RolesDto
�� '
>
��' (
>
��( )$
GetDepartmentUserRoles
��* @
(
��@ A
int
��A D
departmentId
��E Q
)
��Q R
{
�� 	
return
�� 
await
�� 
_adminService
�� &
.
��& '$
GetDepartmentUserRoles
��' =
(
��= >
departmentId
��> J
)
��J K
;
��K L
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
�� 4
)
��4 5
]
��5 6
public
�� 
async
�� 
Task
�� 
<
�� 
List
�� 
<
�� 
RolesDto
�� '
>
��' (
>
��( )(
GetDepartmentUnitUserRoles
��* D
(
��D E
int
��E H
unitId
��I O
)
��O P
{
�� 	
return
�� 
await
�� 
_adminService
�� &
.
��& '(
GetDepartmentUnitUserRoles
��' A
(
��A B
unitId
��B H
)
��H I
;
��I J
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
�� %
)
��% &
]
��& '
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
�� 
List
�� 
<
�� 
RolesDto
�� '
>
��' (
>
��( )"
GetRejectedUserRoles
��* >
(
��> ?
)
��? @
{
�� 	
return
�� 
await
�� 
_adminService
�� &
.
��& '"
GetRejectedUserRoles
��' ;
(
��; <
)
��< =
;
��= >
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
�� 
)
�� 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
List
�� 
<
�� 
RolesDto
�� '
>
��' (
>
��( )
GetUserRoles
��* 6
(
��6 7
)
��7 8
{
�� 	
return
�� 
await
�� 
_adminService
�� &
.
��& '
GetUserRoles
��' 3
(
��3 4
)
��4 5
;
��5 6
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
��  !
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
��& '
CreateUserRole
��( 6
(
��6 7
[
��7 8
FromBody
��8 @
]
��@ A
RolesCreateDto
��B P
values
��Q W
)
��W X
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
��- .
	CreatedBy
��. 7
)
��7 8
)
��8 9
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -
CreateUserRole
��- ;
(
��; <
values
��< B
)
��B C
;
��C D
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
new
�� 
{
��  
message
��! (
=
��) *
result
��+ 1
.
��1 2
ToString
��2 :
(
��: ;
)
��; <
}
��= >
)
��> ?
;
��? @
}
�� 
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
Errors
��) /
)
��/ 0
;
��0 1
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
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
�� 
)
��  
]
��  !
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
�� 5
)
��5 6
]
��6 7
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
��& '
UpdateUserRole
��( 6
(
��6 7
[
��7 8
FromBody
��8 @
]
��@ A
RolesUpdateDto
��B P
values
��Q W
)
��W X
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

ModifiedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -
UpdateUserRole
��- ;
(
��; <
values
��< B
)
��B C
;
��C D
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
new
�� 
{
�� 
message
��  '
=
��( )
result
��* 0
.
��0 1
ToString
��1 9
(
��9 :
)
��: ;
}
��< =
)
��= >
;
��> ?
}
�� 
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
Errors
��) /
)
��/ 0
;
��0 1
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
}
�� 	
[
�� 	

HttpDelete
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� (
)
��( )
]
��) *
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
�� 5
,
��5 6
Roles
��7 <
=
��= >
$str
��? Q
)
��Q R
]
��R S
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
��& '
DeleteUserRole
��( 6
(
��6 7
string
��7 =
roleId
��> D
)
��D E
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
��8 9
RolesDeleteDto
�� 
values
�� !
=
��" #
new
��$ '
RolesDeleteDto
��( 6
(
��6 7
roleId
��7 =
,
��= >
userId
��? E
!
��E F
)
��F G
;
��G H
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -
DeleteUserRole
��- ;
(
��; <
values
��< B
)
��B C
;
��C D
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
ToString
��! )
(
��) *
)
��* +
)
��+ ,
;
��, -
}
�� 
if
�� 
(
�� 
!
�� 
result
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
Errors
��) /
)
��/ 0
;
��0 1
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
}
�� 	
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
�� !
)
��! "
]
��" #
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
AssignRoleToUser
��( 8
(
��8 9
[
��9 :
FromBody
��: B
]
��B C
AssignUserRoleDto
��D U
values
��V \
)
��\ ]
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
_menuService
�� +
.
��+ ,
AssignUserRole
��, :
(
��: ;
values
��; A
)
��A B
;
��B C
if
�� 
(
�� 
result
�� 
is
�� 
null
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� !
(
��! "
$"
��" $
$str
��$ 2
{
��2 3
values
��3 9
.
��9 :
EmailAddress
��: F
}
��F G
$str
��G _
"
��_ `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� 
result
�� 
!
�� 
.
�� 
	Succeeded
�� !
)
��! "
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
.
��$ %
Errors
��% +
)
��+ ,
;
��, -
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
�� (
)
��( )
]
��) *
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
��& '%
AssignPermissionsToRole
��( ?
(
��? @
[
��@ A
FromBody
��A I
]
��I J)
PermissionsAccessModulesDto
��K f
values
��g m
)
��m n
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( )$
AssignPermissionToRole
��) ?
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
�� ,
)
��, -
]
��- .
public
�� 
Task
�� 
<
�� 
IEnumerable
�� 
<
��  -
PermissionsAccessModulesReadDto
��  ?
>
��? @
>
��@ A 
GetUserPermissions
��B T
(
��T U
string
��U [
userId
��\ b
)
��b c
{
�� 	
return
�� 
null
�� 
!
�� 
;
�� 
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
�� ,
)
��, -
]
��- .
public
�� 
async
�� 
Task
�� 
<
�� -
PermissionsAccessModulesReadDto
�� 9
>
��9 : 
GetRolePermissions
��; M
(
��M N
string
��N T
roleId
��U [
)
��[ \
{
�� 	
return
�� 
await
�� 
_menuService
�� %
.
��% &!
GetRolesPermissions
��& 9
(
��9 :
roleId
��: @
)
��@ A
;
��A B
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
�� 0
)
��0 1
]
��1 2
private
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� '
>
��' (-
UpdatePermissionsAssignedToRole
��) H
(
��H I
[
��I J
FromBody
��J R
]
��R S-
PermissionsAccessModulesReadDto
��T s
values
��t z
)
��z {
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_menuService
�� (
.
��( )-
UpdatePermissionsAssignedToRole
��) H
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
�� 5
)
��5 6
]
��6 7
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
VerifyUserAccount
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D"
VerifyUserAccountDto
��E Y
values
��Z `
)
��` a
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

verifiedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
VerifyCustomerAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
�� 
)
��  
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
�� 5
)
��5 6
]
��6 7
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
��& '
RejectUserAccount
��( 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D"
RejectUserAccountDto
��E Y
values
��Z `
)
��` a
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

RejectedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
RejectCustomerAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
�� 6
)
��6 7
]
��7 8
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
ApproveUserAccount
��( :
(
��: ;
[
��; <
FromBody
��< D
]
��D E#
ApproveUserAccountDto
��F [
values
��\ b
)
��b c
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

ApprovedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, - 
ApproveUserAccount
��- ?
(
��? @
values
��@ F
)
��F G
;
��G H
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
�� &
)
��& '
]
��' (
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
��& '#
DisapproveUserAccount
��( =
(
��= >
[
��> ?
FromBody
��? G
]
��G H'
DisapprovedUserAccountDto
��I b
values
��c i
)
��i j
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
��- .
DisapprovedBy
��. ;
)
��; <
)
��< =
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
DisapproveUserAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
�� 7
)
��7 8
]
��8 9
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
ActivateUserAccount
��( ;
(
��; <
[
��< =
FromBody
��= E
]
��E F$
ActivateUserAccountDto
��G ]
values
��^ d
)
��d e
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
��- .
activatedBy
��. 9
)
��9 :
)
��: ;
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -!
ActivateUserAccount
��- @
(
��@ A
values
��A G
)
��G H
;
��H I
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
�� &
)
��& '
]
��' (
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
��& '"
DectivateUserAccount
��( <
(
��< =
[
��= >
FromBody
��> F
]
��F G&
DeactivateUserAccountDto
��H `
values
��a g
)
��g h
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
��- .
DeactivatedBy
��. ;
)
��; <
)
��< =
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
�� 
var
�� 
result
�� 
=
�� 
await
�� 
_adminService
�� ,
.
��, -#
DeactivateUserAccount
��- B
(
��B C
values
��C I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
��  
)
��  !
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
.
��  !
SuccessResponse
��! 0
)
��0 1
;
��1 2
}
�� 
var
�� 
status
�� 
=
�� 
result
�� 
.
��  
ErrorResponse
��  -
!
��- .
.
��. /

StatusCode
��/ 9
;
��9 :
return
�� 
status
�� 
switch
��  
{
�� 
$num
�� 
=>
�� 
	NoContent
��  
(
��  !
)
��! "
,
��" #
$num
�� 
=>
�� 

BadRequest
�� !
(
��! "
result
��" (
.
��( )
ErrorResponse
��) 6
)
��6 7
,
��7 8
$num
�� 
=>
�� 
NotFound
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
$num
�� 
=>
�� 
Conflict
�� 
(
��  
result
��  &
.
��& '
ErrorResponse
��' 4
)
��4 5
,
��5 6
_
�� 
=>
�� 

StatusCode
�� 
(
��  
$num
��  #
,
��# $
result
��% +
)
��+ ,
,
��, -
}
�� 
;
�� 
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
DepartmentReadDto
��3 D
>
��D E
>
��E F
>
��F G
GetDepartments
��H V
(
��V W
)
��W X
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
_departmentService
�� .
.
��. / 
GetDepartmentAsync
��/ A
(
��A B
)
��B C
)
��C D
;
��D E
}
�� 	
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
�� 2
)
��2 3
]
��3 4
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
��2 3
UnitReadDto
��3 >
>
��> ?
>
��? @
>
��@ A 
GetDepartmentUnits
��B T
(
��T U
int
��U X
departmentId
��Y e
)
��e f
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
_departmentUnitService
�� 2
.
��2 3
GetUnitAsync
��3 ?
(
��? @
departmentId
��@ L
)
��L M
)
��M N
;
��N O
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
�� &
)
��& '
]
��' (
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
��' (
DepartmentReadDto
��( 9
>
��9 :
>
��: ;
GetDepartment
��< I
(
��I J
string
��J P
value
��Q V
)
��V W
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
��  
_departmentService
�� .
.
��. / 
GetDepartmentAsync
��/ A
(
��A B
value
��B G
)
��G H
)
��H I
;
��I J
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
�� 1
)
��1 2
]
��2 3
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
��& '
DepartmentReadDto
��' 8
>
��8 9
>
��9 :
GetDepartmentById
��; L
(
��L M
int
��M P
departmentId
��Q ]
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
��  
_departmentService
�� .
.
��. / 
GetDepartmentAsync
��/ A
(
��A B
departmentId
��B N
)
��N O
)
��O P
;
��P Q
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
�� !
)
��! "
]
��" #
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
�� 5
)
��5 6
]
��6 7
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
��& '
DepartmentReadDto
��' 8
>
��8 9
>
��9 :
CreateDepartment
��; K
(
��K L
[
��L M
FromBody
��M U
]
��U V!
DepartmentCreateDto
��W j
values
��k q
)
��q r
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
	CreatedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� " 
_departmentService
��# 5
.
��5 6 
AddDepartmentAsync
��6 H
(
��H I
values
��I O
)
��O P
;
��P Q
if
�� 
(
�� 
result
�� 
is
�� 
null
�� !
)
��! "
{
�� 
return
�� 

BadRequest
�� %
(
��% &
result
��& ,
)
��, -
;
��- .
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status201Created
��. >
,
��> ?
result
��@ F
)
��F G
;
��G H
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
�� !
)
��! "
]
��" #
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
�� 5
)
��5 6
]
��6 7
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
��& '
DepartmentReadDto
��' 8
>
��8 9
>
��9 :
UpdateDepartment
��; K
(
��K L
[
��L M
FromBody
��M U
]
��U V!
DepartmentUpdateDto
��W j
values
��k q
)
��q r
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

ModifiedBy
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
�� 
var
�� 
result
�� 
=
��  
_departmentService
�� +
.
��+ , 
GetDepartmentAsync
��, >
(
��> ?
values
��? E
.
��E F
DepartmentId
��F R
)
��R S
;
��S T
if
�� 
(
�� 
result
�� 
is
�� 
null
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
}
�� 
return
�� 
Ok
�� 
(
�� 
await
��  
_departmentService
�� .
.
��. /#
UpdateDepartmentAsync
��/ D
(
��D E
values
��E K
)
��K L
)
��L M
;
��M N
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 5
)
��5 6
]
��6 7
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
��& '
DeleteDepartment
��( 8
(
��8 9
int
��9 <
departmentId
��= I
)
��I J
{
�� 	
var
�� 
result
�� 
=
�� 
await
��  
_departmentService
�� 1
.
��1 2
DeleteDepartment
��2 B
(
��B C
departmentId
��C O
)
��O P
;
��P Q
if
�� 
(
�� 
result
�� 
.
�� 
response
�� 
==
�� !
$str
��" +
)
��+ ,
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
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
�� #
)
��# $
]
��$ %
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
��2 3#
DepartmentUnitReadDto
��3 H
>
��H I
>
��I J
>
��J K 
GetDepartmentUnits
��L ^
(
��^ _
)
��_ `
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
_departmentUnitService
�� 2
.
��2 3$
GetDepartmentUnitAsync
��3 I
(
��I J
)
��J K
)
��K L
;
��L M
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
��' (
DepartmentReadDto
��( 9
>
��9 :
>
��: ;
GetDepartmentUnit
��< M
(
��M N
string
��N T
value
��U Z
)
��Z [
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
_departmentUnitService
�� 2
.
��2 3$
GetDepartmentUnitAsync
��3 I
(
��I J
value
��J O
)
��O P
)
��P Q
;
��Q R
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
�� @
)
��@ A
]
��A B
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
��2 3#
DepartmentUnitReadDto
��3 H
>
��H I
>
��I J
>
��J K.
 GetDepartmentUnitsByDepartmentId
��L l
(
��l m
int
��m p
departmentId
��q }
)
��} ~
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
_departmentUnitService
�� 2
.
��2 3$
GetDepartmentUnitAsync
��3 I
(
��I J
departmentId
��J V
)
��V W
)
��W X
;
��X Y
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
�� 9
)
��9 :
]
��: ;
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
��' (
DepartmentReadDto
��( 9
>
��9 :
>
��: ;#
GetDepartmentUnitById
��< Q
(
��Q R
int
��R U
departmentUnitId
��V f
)
��f g
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
_departmentUnitService
�� 2
.
��2 3$
GetDepartmentUnitAsync
��3 I
(
��I J
departmentUnitId
��J Z
)
��Z [
)
��[ \
;
��\ ]
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
�� %
)
��% &
]
��& '
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
�� 5
)
��5 6
]
��6 7
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
��& '#
DepartmentUnitReadDto
��' <
>
��< =
>
��= >"
CreateDepartmentUnit
��? S
(
��S T
[
��T U
FromBody
��U ]
]
��] ^%
DepartmentUnitCreateDto
��_ v
values
��w }
)
��} ~
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
	CreatedBy
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
�� 
var
�� 
result
�� 
=
�� 
await
�� "$
_departmentUnitService
��# 9
.
��9 :$
AddDepartmentUnitAsync
��: P
(
��P Q
values
��Q W
)
��W X
;
��X Y
if
�� 
(
�� 
result
�� 
is
�� 
null
�� "
)
��" #
{
�� 
return
�� 

BadRequest
�� %
(
��% &
result
��& ,
)
��, -
;
��- .
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status201Created
��. >
,
��> ?
result
��@ F
)
��F G
;
��G H
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
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
�� %
)
��% &
]
��& '
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
��& '
DepartmentReadDto
��' 8
>
��8 9
>
��9 :"
UpdateDepartmentUnit
��; O
(
��O P
[
��P Q
FromBody
��Q Y
]
��Y Z%
DepartmentUnitUpdateDto
��[ r
values
��s y
)
��y z
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

ModifiedBy
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
�� 
var
�� 
result
�� 
=
�� $
_departmentUnitService
�� /
.
��/ 0$
GetDepartmentUnitAsync
��0 F
(
��F G
values
��G M
.
��M N
UnitId
��N T
)
��T U
;
��U V
if
�� 
(
�� 
result
�� 
is
�� 
null
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
}
�� 
return
�� 
Ok
�� 
(
�� 
await
�� $
_departmentUnitService
�� 2
.
��2 3'
UpdateDepartmentUnitAsync
��3 L
(
��L M
values
��M S
)
��S T
)
��T U
;
��U V
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� 3
)
��3 4
]
��4 5
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
��& '"
DeleteDepartmentUnit
��( <
(
��< =
int
��= @
unitId
��A G
)
��G H
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� $
_departmentUnitService
�� 5
.
��5 6"
DeleteDepartmentUnit
��6 J
(
��J K
unitId
��K Q
)
��Q R
;
��R S
if
�� 
(
�� 
result
�� 
.
�� 
response
�� 
==
��  "
$str
��# ,
)
��, -
{
�� 
return
�� 
Ok
�� 
(
�� 
result
��  
)
��  !
;
��! "
}
�� 
return
�� 

BadRequest
�� 
(
�� 
result
�� $
)
��$ %
;
��% &
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
�� #
)
��# $
]
��$ %
[
�� 	
AllowAnonymous
��	 
]
�� 
public
�� 
IActionResult
�� #
GetRegistrationStatus
�� 2
(
��2 3
)
��3 4
{
�� 	
var
�� 
types
�� 
=
�� 
Enum
�� 
.
�� 
	GetValues
�� &
(
��& '
typeof
��' -
(
��- . 
RegistrationStatus
��. @
)
��@ A
)
��A B
.
��# $
Cast
��$ (
<
��( ) 
RegistrationStatus
��) ;
>
��; <
(
��< =
)
��= >
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
��5 6 
GetCustomAttribute
��6 H
<
��H I"
DescriptionAttribute
��I ]
>
��] ^
(
��^ _
)
��_ `
?
��` a
.
��5 6
Description
��6 A
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
�� 
types
�� 
)
�� 
;
�� 
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
�� '
)
��' (
]
��( )
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
��2 3(
IIdentificationTypeService
��3 M
>
��M N
>
��N O
>
��O P$
GetIdentificationTypes
��Q g
(
��g h
)
��h i
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� (
_identificationTypeService
�� 6
.
��6 7(
GetIdentificationTypeAsync
��7 Q
(
��Q R
)
��R S
)
��S T
;
��T U
}
�� 	
[
�� 	
HttpPost
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� )
)
��) *
]
��* +
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
�� 5
)
��5 6
]
��6 7
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
��& '
ChannelReadDto
��' 5
>
��5 6
>
��6 7&
CreateIdentificationType
��8 P
(
��P Q
[
��Q R
FromBody
��R Z
]
��Z [#
IdentificationTypeDto
��\ q
values
��r x
)
��x y
{
�� 	
try
�� 
{
�� 
var
�� 
result
�� 
=
�� 
await
�� "(
_identificationTypeService
��# =
.
��= >(
AddIdentificationTypeAsync
��> X
(
��X Y
values
��Y _
)
��_ `
;
��` a
if
�� 
(
�� 
result
�� 
is
�� 
null
�� "
)
��" #
{
�� 
return
�� 

BadRequest
�� %
(
��% &
result
��& ,
)
��, -
;
��- .
}
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status201Created
��. >
,
��> ?
new
��@ C
{
��D E
response
��F N
=
��O P
result
��Q W
}
��X Y
)
��Y Z
;
��Z [
}
�� 
catch
�� 
(
�� 
	Exception
�� 
ex
�� 
)
��  
{
�� 
return
�� 

StatusCode
�� !
(
��! "
$num
��" %
,
��% &
ex
��' )
.
��) *
InnerException
��* 8
!
��8 9
.
��9 :
Message
��: A
)
��A B
;
��B C
}
�� 
}
�� 	
[
�� 	
HttpPut
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
�� )
)
��) *
]
��* +
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
��& '
ChannelReadDto
��' 5
>
��5 6
>
��6 7&
UpdateIdentificationType
��8 P
(
��P Q
[
��Q R
FromBody
��R Z
]
��Z [#
IdentificationTypeDto
��\ q
values
��r x
)
��x y
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� (
_identificationTypeService
�� 9
.
��9 :+
UpdateIdentificationTypeAsync
��: W
(
��W X
values
��X ^
)
��^ _
;
��_ `
if
�� 
(
�� 
result
�� 
is
�� 
null
�� 
)
�� 
{
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
}
�� 
return
�� 
Ok
�� 
(
�� 
new
�� 
{
�� 
response
�� $
=
��% &
result
��' -
}
��. /
)
��/ 0
;
��0 1
}
�� 	
[
�� 	

HttpDelete
��	 
(
�� 
$str
�� E
)
��E F
]
��F G
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
��& '&
DeleteIdentificationType
��( @
(
��@ A
int
��A D"
identificationTypeId
��E Y
)
��Y Z
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� (
_identificationTypeService
�� 9
.
��9 :+
DeleteIdentificationTypeAsync
��: W
(
��W X"
identificationTypeId
��X l
)
��l m
;
��m n
if
�� 
(
�� 
result
�� 
!=
�� 
$str
�� #
)
��# $
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
return
�� 
Ok
�� 
(
�� 
new
�� 
{
�� 
response
�� $
=
��% &
result
��' -
}
��. /
)
��/ 0
;
��0 1
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
��  
[
�� 	
	Authorize
��	 
(
�� 
Roles
�� 
=
�� 
$str
�� :
)
��: ;
]
��; <
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3$
AdministrationStaffDto
��3 I
>
��I J
>
��J K
>
��K L$
GetAdministrationStaff
��M c
(
��c d
)
��d e
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_adminService
�� )
.
��) *$
GetAdministrationStaff
��* @
(
��@ A
)
��A B
)
��B C
;
��C D
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� !
)
��! "
]
��" #
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3'
AdministrationCustomerDto
��3 L
>
��L M
>
��M N
>
��N O(
GetAdministrationCustomers
��P j
(
��j k
)
��k l
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_adminService
�� )
.
��) *'
GetAdministrationCustomer
��* C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� #
)
��# $
]
��$ %
[
�� 	
	Authorize
��	 
(
�� 
Roles
�� 
=
�� 
$str
�� :
)
��: ;
]
��; <
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3'
AdministrationPartnersDto
��3 L
>
��L M
>
��M N
>
��N O&
GetAdministrationPartner
��P h
(
��h i
)
��i j
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_adminService
�� )
.
��) *'
GetAdministrationPartners
��* C
(
��C D
)
��D E
)
��E F
;
��F G
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 7
)
��7 8
]
��8 9
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3$
AdministrationStaffDto
��3 I
>
��I J
>
��J K
>
��K L.
 GetAdministrationDepartmentStaff
��M m
(
��m n
int
��n q
departmentId
��r ~
)
��~ 
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_adminService
�� )
.
��) *.
 GetAdministrationDepartmentStaff
��* J
(
��J K
departmentId
��K W
)
��W X
)
��X Y
;
��Y Z
}
�� 	
[
�� 	
HttpGet
��	 
]
�� 
[
�� 	
Route
��	 
(
�� 
$str
�� 5
)
��5 6
]
��6 7
public
�� 
async
�� 
Task
�� 
<
�� 
ActionResult
�� &
<
��& '
IEnumerable
��' 2
<
��2 3$
AdministrationStaffDto
��3 I
>
��I J
>
��J K
>
��K L2
$GetAdministrationDepartmentUnitStaff
��M q
(
��q r
int
��r u
unitId
��v |
)
��| }
{
�� 	
return
�� 
Ok
�� 
(
�� 
await
�� 
_adminService
�� )
.
��) *2
$GetAdministrationDepartmentUnitStaff
��* N
(
��N O
unitId
��O U
)
��U V
)
��V W
;
��W X
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Presentation/Controllers/v1/AccountController.cs
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
�� 
status
�� 
=
�� 
response
�� !
.
��! "
ErrorResponse
��" /
!
��/ 0
.
��0 1

StatusCode
��1 ;
;
��; <
switch
�� 
(
�� 
status
�� 
)
�� 
{
�� 
case
�� 
$num
�� 
:
�� 
return
�� 
	NoContent
�� $
(
��$ %
)
��% &
;
��& '
case
�� 
$num
�� 
:
�� 
return
�� 

BadRequest
�� %
(
��% &
response
��& .
.
��. /
ErrorResponse
��/ <
)
��< =
;
��= >
case
�� 
$num
�� 
:
�� 
return
�� 
NotFound
�� #
(
��# $
response
��$ ,
.
��, -
ErrorResponse
��- :
)
��: ;
;
��; <
case
�� 
$num
�� 
:
�� 
return
�� 
Conflict
�� #
(
��# $
response
��$ ,
.
��, -
ErrorResponse
��- :
)
��: ;
;
��; <
default
�� 
:
�� 
break
�� 
;
�� 
}
�� 
;
�� 
}
�� 	
return
�� 

BadRequest
�� 
(
�� 
)
�� 
;
�� 
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
�� 
)
�� 
]
�� 
[
�� 
	Authorize
�� 
(
�� 
Policy
�� 
=
�� 
$str
�� 1
)
��1 2
]
��2 3
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -)
RegistrationSuccessResponse
��- H
)
��H I
)
��I J
]
��J K
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -'
RegistrationErrorResponse
��- F
)
��F G
)
��G H
]
��H I
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -'
RegistrationErrorResponse
��- F
)
��F G
)
��G H
]
��H I
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -'
RegistrationErrorResponse
��- F
)
��F G
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
�� 
ActionResult
�� "
<
��" #"
RegistrationResponse
��# 7
>
��7 8
>
��8 9
Register
��: B
(
��B C
[
��C D
FromBody
��D L
]
��L M)
StaffRegistrationRequestDto
��N i
values
��j p
)
��p q
{
�� 
if
�� 

(
�� 

ModelState
�� 
.
�� 
IsValid
�� 
)
�� 
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
_userAccountsService
��! 5
.
��5 6#
StaffUserRegistration
��6 K
(
��K L
values
��L R
)
��R S
;
��S T
if
�� 
(
�� 
response
�� 
.
�� 
	IsSuccess
�� !
==
��" $
true
��% )
)
��) *
{
�� 
return
�� 

StatusCode
�� !
(
��! "
StatusCodes
��" -
.
��- .
Status201Created
��. >
,
��> ?
response
��@ H
.
��H I
SuccessResponse
��I X
)
��X Y
;
��Y Z
}
�� 
var
�� 
status
�� 
=
�� 
response
�� !
.
��! "
ErrorResponse
��" /
!
��/ 0
.
��0 1

StatusCode
��1 ;
;
��; <
switch
�� 
(
�� 
status
�� 
)
�� 
{
�� 
case
�� 
$num
�� 
:
�� 
return
�� 
	NoContent
�� $
(
��$ %
)
��% &
;
��& '
case
�� 
$num
�� 
:
�� 
return
�� 

BadRequest
�� %
(
��% &
response
��& .
.
��. /
ErrorResponse
��/ <
)
��< =
;
��= >
case
�� 
$num
�� 
:
�� 
return
�� 
NotFound
�� #
(
��# $
response
��$ ,
.
��, -
ErrorResponse
��- :
)
��: ;
;
��; <
case
�� 
$num
�� 
:
�� 
return
�� 
Conflict
�� #
(
��# $
response
��$ ,
.
��, -
ErrorResponse
��- :
)
��: ;
;
��; <
default
�� 
:
�� 
break
�� 
;
�� 
}
�� 
;
�� 
}
�� 	
return
�� 

BadRequest
�� 
(
�� 
)
�� 
;
�� 
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
ChangePassword
��% 3
(
��3 4
[
��4 5
FromBody
��5 =
]
��= >&
ChangePasswordRequestDto
��? W'
changeUserPasswordRequest
��X q
)
��q r
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
changeResult
��  
=
��! "
await
��# ("
_userAccountsService
��) =
.
��= >
ChangePassword
��> L
(
��L M'
changeUserPasswordRequest
��M f
)
��f g
;
��g h
if
�� 
(
�� 
changeResult
��  
.
��  !
	IsSuccess
��! *
)
��* +
{
�� 
return
�� 
Ok
�� 
(
�� 
changeResult
�� *
)
��* +
;
��+ ,
}
�� 
var
�� 
status
�� 
=
�� 
changeResult
�� )
.
��) *
ErrorResponse
��* 7
!
��7 8
.
��8 9

StatusCode
��9 C
;
��C D
switch
�� 
(
�� 
status
�� 
)
�� 
{
�� 
case
�� 
$num
�� 
:
�� 
return
�� 
	NoContent
�� (
(
��( )
)
��) *
;
��* +
case
�� 
$num
�� 
:
�� 
return
�� 

BadRequest
�� )
(
��) *
changeResult
��* 6
.
��6 7
ErrorResponse
��7 D
)
��D E
;
��E F
case
�� 
$num
�� 
:
�� 
return
�� 
NotFound
�� '
(
��' (
changeResult
��( 4
.
��4 5
ErrorResponse
��5 B
)
��B C
;
��C D
case
�� 
$num
�� 
:
�� 
return
�� 
Conflict
�� '
(
��' (
changeResult
��( 4
.
��4 5
ErrorResponse
��5 B
)
��B C
;
��C D
default
�� 
:
�� 
return
�� 

StatusCode
�� )
(
��) *
$num
��* -
,
��- .
changeResult
��/ ;
)
��; <
;
��< =
}
�� 
;
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
ResetPassword
��% 2
(
��2 3
[
��3 4
FromBody
��4 <
]
��< =%
ResetPasswordRequestDto
��> U"
resetPasswordRequest
��V j
)
��j k
{
�� 
try
�� 
{
�� 	#
ResetPasswordResponse
�� !
changeResult
��" .
=
��/ 0
null
��1 5
!
��5 6
;
��7 8
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� %
ResetPasswordRequestDto
�� '
passwordRequest
��( 7
=
��8 9
new
��: =%
ResetPasswordRequestDto
��> U
{
�� 
Phone_OR_Email
�� "
=
��# $"
resetPasswordRequest
��% 9
.
��9 :
Phone_OR_Email
��: H
,
��H I
Token
�� 
=
�� "
resetPasswordRequest
�� 0
.
��0 1
Token
��1 6
,
��6 7
NewPassword
�� 
=
��  !"
resetPasswordRequest
��" 6
.
��6 7
NewPassword
��7 B
,
��B C 
ConfirmNewPassword
�� &
=
��' ("
resetPasswordRequest
��) =
.
��= > 
ConfirmNewPassword
��> P
}
�� 
;
�� 
if
�� 
(
�� 

emailRegex
�� 
.
�� 
IsMatch
�� &
(
��& '"
resetPasswordRequest
��' ;
.
��; <
Phone_OR_Email
��< J
!
��J K
)
��K L
)
��L M
{
�� 
changeResult
��  
=
��! "
await
��# ("
_userAccountsService
��) =
.
��= >*
ResetPasswordViaEmailAddress
��> Z
(
��Z [
passwordRequest
��[ j
)
��j k
;
��k l
}
�� 
if
�� 
(
�� 

phoneRegex
�� 
.
�� 
IsMatch
�� &
(
��& '"
resetPasswordRequest
��' ;
.
��; <
Phone_OR_Email
��< J
!
��J K
)
��K L
)
��L M
{
�� 
changeResult
��  
=
��! "
await
��# ("
_userAccountsService
��) =
.
��= >/
!ResetPasswordViaMobilePhoneNumber
��> _
(
��_ `
passwordRequest
��` o
)
��o p
;
��p q
}
�� 
if
�� 
(
�� 
changeResult
��  
.
��  !
	IsSuccess
��! *
)
��* +
{
�� 
return
�� 
Ok
�� 
(
�� 
changeResult
�� *
.
��* +
SuccessResponse
��+ :
)
��: ;
;
��; <
}
�� 
var
�� 
status
�� 
=
�� 
changeResult
�� )
.
��) *
ErrorResponse
��* 7
!
��7 8
.
��8 9

StatusCode
��9 C
;
��C D
switch
�� 
(
�� 
status
�� 
)
�� 
{
�� 
case
�� 
$num
�� 
:
�� 
return
�� 
	NoContent
�� (
(
��( )
)
��) *
;
��* +
case
�� 
$num
�� 
:
�� 
return
�� 

BadRequest
�� )
(
��) *
changeResult
��* 6
.
��6 7
ErrorResponse
��7 D
)
��D E
;
��E F
case
�� 
$num
�� 
:
�� 
return
�� 
NotFound
�� '
(
��' (
changeResult
��( 4
.
��4 5
ErrorResponse
��5 B
)
��B C
;
��C D
case
�� 
$num
�� 
:
�� 
return
�� 
Conflict
�� '
(
��' (
changeResult
��( 4
.
��4 5
ErrorResponse
��5 B
)
��B C
;
��C D
default
�� 
:
�� 
return
�� 

StatusCode
�� )
(
��) *
$num
��* -
,
��- .
changeResult
��/ ;
)
��; <
;
��< =
}
�� 
;
�� 
}
�� 
return
�� 

BadRequest
�� 
(
�� 
)
�� 
;
��  
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -
LoginResponseDto
��- =
)
��= >
)
��> ?
]
��? @
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
	UserLogin
��% .
(
��. /
[
��/ 0
FromBody
��0 8
]
��8 9
LoginRequestDto
��: I

loginModel
��J T
)
��T U
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
LoginRequestDto
�� 
loginRequest
��  ,
=
��- .
new
��/ 2
LoginRequestDto
��3 B
{
�� 
Phone_OR_Email
�� "
=
��# $

loginModel
��% /
.
��/ 0
Phone_OR_Email
��0 >
,
��> ?
Password
�� 
=
�� 

loginModel
�� )
.
��) *
Password
��* 2
}
�� 
;
�� 
if
�� 
(
�� 

emailRegex
�� 
.
�� 
IsMatch
�� &
(
��& '

loginModel
��' 1
.
��1 2
Phone_OR_Email
��2 @
!
��@ A
)
��A B
)
��B C
{
�� 
var
�� 
result
�� 
=
��  
await
��! &"
_userAccountsService
��' ;
.
��; <#
LoginWithEmailAddress
��< Q
(
��Q R
loginRequest
��R ^
)
��^ _
;
��_ `
switch
�� 
(
�� 
result
�� "
.
��" #
LoginStatus
��# .
)
��. /
{
�� 
case
�� 
true
�� !
:
��! "
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
case
�� 
false
�� "
:
��" #
var
�� 
status
��  &
=
��' (
result
��) /
.
��/ 0
errorResponse
��0 =
!
��= >
.
��> ?

StatusCode
��? I
;
��I J
return
�� "
status
��# )
switch
��* 0
{
�� 
$num
��  #
=>
��$ &
	NoContent
��' 0
(
��0 1
)
��1 2
,
��2 3
$num
��  #
=>
��$ &

BadRequest
��' 1
(
��1 2
result
��2 8
.
��8 9
errorResponse
��9 F
)
��F G
,
��G H
$num
��  #
=>
��$ &
NotFound
��' /
(
��/ 0
result
��0 6
.
��6 7
errorResponse
��7 D
)
��D E
,
��E F
$num
��  #
=>
��$ &
Conflict
��' /
(
��/ 0
result
��0 6
.
��6 7
errorResponse
��7 D
)
��D E
,
��E F
$num
��  #
=>
��$ &

StatusCode
��' 1
(
��1 2
$num
��2 5
,
��5 6
result
��7 =
.
��= >
errorResponse
��> K
)
��K L
,
��L M
_
��  !
=>
��" $

StatusCode
��% /
(
��/ 0
$num
��0 3
,
��3 4
result
��5 ;
)
��; <
,
��< =
}
�� 
;
�� 
}
�� 
}
�� 
if
�� 
(
�� 

phoneRegex
�� 
.
�� 
IsMatch
�� &
(
��& '

loginModel
��' 1
.
��1 2
Phone_OR_Email
��2 @
!
��@ A
)
��A B
)
��B C
{
�� 
var
�� 
result
�� 
=
��  
await
��! &"
_userAccountsService
��' ;
.
��; <(
LoginWithMobilePhoneNumber
��< V
(
��V W
loginRequest
��W c
)
��c d
;
��d e
switch
�� 
(
�� 
result
�� "
.
��" #
LoginStatus
��# .
)
��. /
{
�� 
case
�� 
true
�� !
:
��! "
return
�� "
Ok
��# %
(
��% &
result
��& ,
)
��, -
;
��- .
case
�� 
false
�� "
:
��" #
var
�� 
status
��  &
=
��' (
result
��) /
.
��/ 0
errorResponse
��0 =
!
��= >
.
��> ?

StatusCode
��? I
;
��I J
return
�� "
status
��# )
switch
��* 0
{
�� 
$num
��  #
=>
��$ &
	NoContent
��' 0
(
��0 1
)
��1 2
,
��2 3
$num
��  #
=>
��$ &

BadRequest
��' 1
(
��1 2
result
��2 8
.
��8 9
errorResponse
��9 F
)
��F G
,
��G H
$num
��  #
=>
��$ &
NotFound
��' /
(
��/ 0
result
��0 6
.
��6 7
errorResponse
��7 D
)
��D E
,
��E F
$num
��  #
=>
��$ &
Conflict
��' /
(
��/ 0
result
��0 6
.
��6 7
errorResponse
��7 D
)
��D E
,
��E F
$num
��  #
=>
��$ &

StatusCode
��' 1
(
��1 2
$num
��2 5
,
��5 6
result
��7 =
.
��= >
errorResponse
��> K
)
��K L
,
��L M
_
��  !
=>
��" $

StatusCode
��% /
(
��/ 0
$num
��0 3
,
��3 4
result
��5 ;
)
��; <
,
��< =
}
�� 
;
�� 
}
�� 
}
�� 
}
�� 
return
�� 

BadRequest
�� 
(
�� 
new
�� !
{
��" #

statusCode
��# -
=
��. /
$num
��0 3
,
��3 4
message
��5 <
=
��= >
$str
��? q
}
��r s
)
��s t
;
��t u
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -%
RefreshTokenResponseDto
��- D
)
��D E
)
��E F
]
��F G
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
RefreshToken
��% 1
(
��1 2
[
��2 3
FromBody
��3 ;
]
��; <$
RefreshTokenRequestDto
��= S
request
��T [
)
��[ \
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
result
�� 
=
�� 
await
�� #"
_userAccountsService
��$ 8
.
��8 9 
RefreshBearerToken
��9 K
(
��K L
request
��L S
)
��S T
;
��T U
if
�� 
(
�� 
result
�� 
.
�� 
	IsSuccess
�� $
)
��$ %
{
�� 
return
�� 
Ok
�� 
(
�� 
result
�� $
.
��$ %
SuccessResponse
��% 4
)
��4 5
;
��5 6
}
�� 
var
�� 
status
�� 
=
�� 
result
�� #
.
��# $
ErrorResponse
��$ 1
!
��1 2
.
��2 3

StatusCode
��3 =
;
��= >
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
�� 

BadRequest
�� %
(
��% &
result
��& ,
.
��, -
ErrorResponse
��- :
)
��: ;
,
��; <
$num
�� 
=>
�� 
NotFound
�� #
(
��# $
result
��$ *
.
��* +
ErrorResponse
��+ 8
)
��8 9
,
��9 :
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
��) *
result
��+ 1
.
��1 2
ErrorResponse
��2 ?
)
��? @
,
��@ A
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
��' (
result
��) /
)
��/ 0
,
��0 1
}
�� 
;
�� 
}
�� 
return
�� 

BadRequest
�� 
(
�� 
)
�� 
;
��  
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
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
�� 
)
�� 
]
�� 
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
>
��" #
UserDetails
��$ /
(
��/ 0
string
��0 6
userId
��7 =
)
��= >
{
�� 
var
�� 
user
�� 
=
�� 
await
�� 
_unitOfWork
�� $
.
��$ %
Users
��% *
.
��* +
Get
��+ .
(
��. /
u
��/ 0
=>
��1 3
u
��4 5
.
��5 6
Id
��6 8
==
��9 ;
userId
��< B
)
��B C
;
��C D
if
�� 

(
�� 
user
�� 
is
�� 
null
�� 
)
�� 
return
�� 
NotFound
�� 
(
�� 
new
�� 
{
��  !
message
��" )
=
��* +
$str
��, ?
}
��@ A
)
��A B
;
��B C
return
�� 
Ok
�� 
(
�� 
await
�� "
_userAccountsService
�� ,
.
��, -
UserDetails
��- 8
(
��8 9
userId
��9 ?
)
��? @
)
��@ A
;
��A B
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -
TokenResponseDto
��- =
)
��= >
)
��> ?
]
��? @
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
SendOTPToken
��% 1
(
��1 2
[
��2 3
FromBody
��3 ;
]
��; <&
TokenRequestParameterDto
��= U
value
��V [
)
��[ \
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
value
��* /
.
��/ 0
phone_OR_email
��0 >
)
��> ?
)
��? @
{
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
}
�� 
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
if
�� 
(
�� 

emailRegex
�� 
.
�� 
IsMatch
�� &
(
��& '
value
��' ,
.
��, -
phone_OR_email
��- ;
!
��; <
)
��< =
)
��= >
{
�� 
var
�� 
result
�� 
=
��  
await
��! &
_unitOfWork
��' 2
.
��2 3

TokenStore
��3 =
.
��= >
GetToken
��> F
(
��F G
value
��G L
.
��L M
phone_OR_email
��M [
!
��[ \
,
��\ ]
$num
��^ _
)
��_ `
;
��` a
if
�� 
(
�� 
result
�� 
.
�� 
Length
�� $
!=
��% '
$num
��( )
)
��) *
{
�� 
return
�� 
NotFound
�� '
(
��' (
new
��( +
{
��, -
message
��. 5
=
��6 7
result
��8 >
}
��? @
)
��@ A
;
��A B
}
�� 
return
�� 
Ok
�� 
(
�� 
new
�� !
TokenResponseDto
��" 2
(
��2 3
result
��3 9
)
��9 :
)
��: ;
;
��; <
}
�� 
if
�� 
(
�� 

phoneRegex
�� 
.
�� 
IsMatch
�� &
(
��& '
value
��' ,
.
��, -
phone_OR_email
��- ;
!
��; <
)
��< =
)
��= >
{
�� 
var
�� 
result
�� 
=
��  
await
��! &
_unitOfWork
��' 2
.
��2 3

TokenStore
��3 =
.
��= >
GetToken
��> F
(
��F G
value
��G L
.
��L M
phone_OR_email
��M [
!
��[ \
,
��\ ]
$num
��^ _
)
��_ `
;
��` a
if
�� 
(
�� 
result
�� 
.
�� 
Length
�� %
!=
��& (
$num
��) *
)
��* +
{
�� 
return
�� 
NotFound
�� '
(
��' (
new
��( +
{
��, -
message
��. 5
=
��6 7
result
��8 >
}
��? @
)
��@ A
;
��A B
}
�� 
return
�� 
Ok
�� 
(
�� 
new
�� !
TokenResponseDto
��" 2
(
��2 3
result
��3 9
)
��9 :
)
��: ;
;
��; <
}
�� 
}
�� 
return
�� 
NotFound
�� 
(
�� 
new
�� 
{
��  !
message
��! (
=
��) *
$str
��+ b
}
��c d
)
��d e
;
��e f
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
[
�� 
HttpPost
�� 
]
�� 
[
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
�� 
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, -
TokenResponseDto
��- =
)
��= >
)
��> ?
]
��? @
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
VerifyOTPToken
��% 3
(
��3 4
[
��4 5
FromBody
��5 =
]
��= >#
VerifyTokenRequestDto
��? T 
verifyTokenRequest
��U g
)
��g h
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� (
(
��( ) 
verifyTokenRequest
��) ;
.
��; <
phone_OR_email
��< J
)
��J K
||
��L N
string
��O U
.
��U V 
IsNullOrWhiteSpace
��V h
(
��h i 
verifyTokenRequest
��i {
.
��{ |
token��| �
)��� �
)��� �
{
�� 
return
�� 

BadRequest
�� !
(
��! "
)
��" #
;
��# $
}
�� 
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
if
�� 
(
�� 

emailRegex
�� 
.
�� 
IsMatch
�� &
(
��& ' 
verifyTokenRequest
��' 9
.
��9 :
phone_OR_email
��: H
!
��H I
)
��I J
)
��J K
{
�� 
var
�� 
result
�� 
=
��  
await
��! &
_unitOfWork
��' 2
.
��2 3

TokenStore
��3 =
.
��= >
VerifyToken
��> I
(
��I J 
verifyTokenRequest
��J \
.
��\ ]
phone_OR_email
��] k
,
��k l 
verifyTokenRequest
��m 
.�� �
token��� �
)��� �
;��� �
if
�� 
(
�� 
result
�� 
!=
��  
$str
��! +
)
��+ ,
{
�� 
return
�� 

BadRequest
�� )
(
��) *
new
��* -
{
��. /
message
��0 7
=
��8 9
result
��: @
}
��A B
)
��B C
;
��C D
}
�� 
return
�� 
Ok
�� 
(
�� 
new
�� !
{
��" #
message
��$ +
=
��, -
result
��. 4
}
��5 6
)
��6 7
;
��7 8
}
�� 
if
�� 
(
�� 

phoneRegex
�� 
.
�� 
IsMatch
�� &
(
��& ' 
verifyTokenRequest
��' 9
.
��9 :
phone_OR_email
��: H
!
��H I
)
��I J
)
��J K
{
�� 
var
�� 
result
�� 
=
��  
await
��! &
_unitOfWork
��' 2
.
��2 3

TokenStore
��3 =
.
��= >
VerifyToken
��> I
(
��I J 
verifyTokenRequest
��J \
.
��\ ]
phone_OR_email
��] k
,
��k l 
verifyTokenRequest
��m 
.�� �
token��� �
)��� �
;��� �
if
�� 
(
�� 
result
�� 
!=
�� !
$str
��" ,
)
��, -
{
�� 
return
�� 

BadRequest
�� )
(
��) *
new
��* -
{
��. /
message
��0 7
=
��8 9
result
��: @
}
��A B
)
��B C
;
��C D
}
�� 
return
�� 
Ok
�� 
(
�� 
new
�� !
{
��" #
message
��$ +
=
��, -
result
��. 4
}
��5 6
)
��6 7
;
��7 8
}
�� 
}
�� 
return
�� 
NotFound
�� 
(
�� 
)
�� 
;
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
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
�� 
AllowAnonymous
�� 
]
�� 
[
�� 
Route
�� 

(
��
 
$str
�� 
)
�� 
]
��  
[
�� "
ProducesResponseType
�� 
(
�� 
$num
�� 
,
�� 
Type
�� #
=
��$ %
typeof
��& ,
(
��, - 
UserInformationDto
��- ?
)
��? @
)
��@ A
]
��A B
public
�� 

async
�� 
Task
�� 
<
�� 
IActionResult
�� #
>
��# $
UpdateUserAccount
��% 6
(
��6 7
[
��7 8
FromBody
��8 @
]
��@ A
UpdateUserDto
��B O
UserUpdateRequest
��P a
)
��a b
{
�� 
try
�� 
{
�� 	
if
�� 
(
�� 

ModelState
�� 
.
�� 
IsValid
�� "
)
��" #
{
�� 
var
�� 
result
�� 
=
�� 
await
�� ""
_userAccountsService
��# 7
.
��7 8"
UpdateAccountDetails
��8 L
(
��L M
UserUpdateRequest
��M ^
)
��^ _
;
��_ `
if
�� 
(
�� 
result
�� 
.
�� 
success
�� "
is
��# %
not
��& )
null
��* .
)
��. /
{
�� 
return
�� 
Ok
�� 
(
�� 
result
�� $
.
��$ %
success
��% ,
)
��, -
;
��- .
}
�� 
else
�� 
{
�� 
return
�� 

BadRequest
�� %
(
��% &
result
��& ,
.
��, -
error
��- 2
)
��2 3
;
��3 4
}
�� 
}
�� 
return
�� 
NotFound
�� 
(
�� 
)
�� 
;
�� 
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
��% &
Message
��& -
)
��- .
;
��. /
}
�� 	
}
�� 
}�� 