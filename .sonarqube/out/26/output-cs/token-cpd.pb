ÄQ
i/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Billing.Presentation/Program.cs
var		 
builder		 
=		 
WebApplication		 
.		 
CreateBuilder		 *
(		* +
args		+ /
)		/ 0
;		0 1
if 
( 
builder 
. 
Environment 
. 
IsDevelopment %
(% &
)& '
)' (
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB `
)` a
;a b
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
} 
} 
if 
( 
builder 
. 
Environment 
. 
IsProduction $
($ %
)% &
)& '
{ 
var 
currentDirectory 
= 
	Directory $
.$ %
GetCurrentDirectory% 8
(8 9
)9 :
;: ;
var 
solutionDirectory 
= 
	Directory %
.% &
	GetParent& /
(/ 0
currentDirectory0 @
)@ A
?A B
.B C
ParentC I
?I J
.J K
FullNameK S
??T V
$strW Y
;Y Z
var #
solutionLevelConfigPath 
=  !
Path" &
.& '
Combine' .
(. /
solutionDirectory/ @
,@ A
$strB T
)T U
;U V
if 
( 
File 
. 
Exists 
( #
solutionLevelConfigPath +
)+ ,
), -
{ 
builder 
. 
Configuration 
. 
AddJsonFile )
() *#
solutionLevelConfigPath* A
,A B
optionalC K
:K L
falseM R
,R S
reloadOnChangeT b
:b c
trued h
)h i
;i j
}   
}!! 
if(( 
((( 
builder(( 
.(( 
Environment(( 
.(( 
IsDevelopment(( %
(((% &
)((& '
)((' (
{)) 
switch** 

(** 
builder** 
.** 
Configuration** !
.**! "

GetSection**" ,
(**, -
$str**- 7
)**7 8
.**8 9

GetSection**9 C
(**C D
$str**D V
)**V W
.**W X
Value**X ]
)**] ^
{++ 
case,, 
$str,, 
:,, 
break.. 
;.. 
case// 
$str// 
:// 
break11 
;11 
}22 
}44 
if66 
(66 
builder66 
.66 
Environment66 
.66 
IsProduction66 $
(66$ %
)66% &
)66& '
{77 
switch88 

(88 
builder88 
.88 
Configuration88 !
.88! "

GetSection88" ,
(88, -
$str88- 7
)887 8
.888 9

GetSection889 C
(88C D
$str88D V
)88V W
.88W X
Value88X ]
)88] ^
{99 
case:: 
$str:: 
::: 
break<< 
;<< 
case== 
$str== 
:== 
break?? 
;?? 
}@@ 
}AA 
builderEE 
.EE 
ServicesEE 
.EE 
AddControllersEE 
(EE  
)EE  !
;EE! "
builderFF 
.FF 
ServicesFF 
.GG 
AddApiVersioningGG 
(GG 
optionsGG 
=>GG  
{HH 
optionsII 
.II 
DefaultApiVersionII !
=II" #
newII$ '

ApiVersionII( 2
(II2 3
$numII3 4
,II4 5
$numII6 7
)II7 8
;II8 9
optionsJJ 
.JJ /
#AssumeDefaultVersionWhenUnspecifiedJJ 3
=JJ4 5
trueJJ6 :
;JJ: ;
optionsKK 
.KK 
ReportApiVersionsKK !
=KK" #
trueKK$ (
;KK( )
}LL 
)LL 
.MM 
AddApiExplorerMM 
(MM 
optionsMM 
=>MM 
{NN 
optionsOO 
.OO 
GroupNameFormatOO 
=OO  !
$strOO" *
;OO* +
optionsPP 
.PP %
SubstituteApiVersionInUrlPP )
=PP* +
truePP, 0
;PP0 1
}QQ 
)QQ 
;QQ 
builderSS 
.SS 
ServicesSS 
.SS #
AddEndpointsApiExplorerSS (
(SS( )
)SS) *
;SS* +
builderTT 
.TT 
ServicesTT 
.TT 
AddTransientTT 
<TT 
IConfigureOptionsTT /
<TT/ 0
SwaggerGenOptionsTT0 A
>TTA B
,TTB C#
SwaggerConfigureOptionsTTD [
>TT[ \
(TT\ ]
)TT] ^
;TT^ _
builderUU 
.UU 
ServicesUU 
.UU 
AddSwaggerGenUU 
(UU 
optionsUU &
=>UU' )
{VV 
optionsWW 
.WW 
OperationFilterWW 
<WW  
SwaggerDefaultValuesWW 0
>WW0 1
(WW1 2
)WW2 3
;WW3 4
optionsXX 
.XX 
IncludeXmlCommentsXX 
(XX 
PathXX #
.XX# $
CombineXX$ +
(XX+ ,

AppContextXX, 6
.XX6 7
BaseDirectoryXX7 D
,XXD E
$"XXF H
{XXH I
AssemblyXXI Q
.XXQ R 
GetExecutingAssemblyXXR f
(XXf g
)XXg h
.XXh i
GetNameXXi p
(XXp q
)XXq r
.XXr s
NameXXs w
}XXw x
$strXXx |
"XX| }
)XX} ~
)XX~ 
;	XX €
}ZZ 
)ZZ 
;ZZ 
var\\ 
app\\ 
=\\ 	
builder\\
 
.\\ 
Build\\ 
(\\ 
)\\ 
;\\ 
if__ 
(__ 
app__ 
.__ 
Environment__ 
.__ 
IsDevelopment__ !
(__! "
)__" #
)__# $
{`` 
appcc 
.cc 

UseSwaggercc 
(cc 
optionscc 
=>cc 
{dd 
optionsee 
.ee 
PreSerializeFiltersee #
.ee# $
Addee$ '
(ee' (
(ee( )
swaggeree) 0
,ee0 1
reqee2 5
)ee5 6
=>ee7 9
{ff 	
swaggergg 
.gg 
Serversgg 
=gg 
newgg !
Listgg" &
<gg& '
OpenApiServergg' 4
>gg4 5
(gg5 6
)gg6 7
{gg8 9
newgg: =
OpenApiServergg> K
(ggK L
)ggL M
{ggN O
UrlggP S
=ggT U
$"ggV X
$strggX `
{gg` a
reqgga d
.ggd e
Hostgge i
}ggi j
"ggj k
}ggl m
}ggn o
;ggo p
}hh 	
)hh	 

;hh
 
}ii 
)ii 
;ii 
appll 
.ll 
UseSwaggerUIll 
(ll 
optionsll 
=>ll 
{mm 
varnn "
ApiVersionDescriptionsnn "
=nn# $
appnn% (
.nn( )
DescribeApiVersionsnn) <
(nn< =
)nn= >
;nn> ?
foreachpp 
(pp 
varpp 
descpp 
inpp "
ApiVersionDescriptionspp 3
)pp3 4
{qq 	
optionsrr 
.rr 
SwaggerEndpointrr #
(rr# $
$"rr$ &
$strrr& 1
{rr1 2
descrr2 6
.rr6 7
	GroupNamerr7 @
}rr@ A
$strrrA N
"rrN O
,rrO P
$"rrQ S
$strrrS d
{rrd e
descrre i
.rri j

ApiVersionrrj t
.rrt u
ToStringrru }
(rr} ~
)rr~ 
}	rr €
"
rr€ 
)
rr ‚
;
rr‚ ƒ
optionsss 
.ss $
DefaultModelsExpandDepthss ,
(ss, -
-ss- .
$numss. /
)ss/ 0
;ss0 1
optionstt 
.tt 
DocExpansiontt  
(tt  !
Swashbucklett! ,
.tt, -

AspNetCorett- 7
.tt7 8
	SwaggerUItt8 A
.ttA B
DocExpansionttB N
.ttN O
NonettO S
)ttS T
;ttT U
}uu 	
}vv 
)vv 
;vv 
}ww 
appyy 
.yy 
UseHttpsRedirectionyy 
(yy 
)yy 
;yy 
app{{ 
.{{ 
UseAuthorization{{ 
({{ 
){{ 
;{{ 
app}} 
.}} 
MapControllers}} 
(}} 
)}} 
;}} 
app 
. 
Run 
( 
) 	
;	 
Û%
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Billing.Presentation/OpenAPI/SwaggerDefaultValues.cs
	namespace 	
Modules
 
. 
Billing 
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
}88 ¤
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Billing.Presentation/OpenAPI/SwaggerConfigureOptions.cs
	namespace		 	
Modules		
 
.		 
Billing		 
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
$str	] ƒ
}
„ …
,
… †
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
}22 ·
‚/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Billing.Presentation/Controllers/v1/BillingController.cs
	namespace 	
Modules
 
. 
Billing 
. 
Presentation &
.& '
Controllers' 2
.2 3
v13 5
;5 6
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[		 
Produces		 	
(			 

$str		
 
)		 
]		 
public

 
class

 
BillingController

 
:

  
ControllerBase

! /
{ 
} ·
‚/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Billing.Presentation/Controllers/v2/BillingController.cs
	namespace 	
Modules
 
. 
Billing 
. 
Presentation &
.& '
Controllers' 2
.2 3
v23 5
;5 6
[ 
ApiController 
] 
[ 

ApiVersion 
( 
$str 
) 
] 
[ 
Route 
( 
$str /
)/ 0
]0 1
[		 
Produces		 	
(			 

$str		
 
)		 
]		 
public

 
class

 
BillingController

 
:

  
ControllerBase

! /
{ 
} 