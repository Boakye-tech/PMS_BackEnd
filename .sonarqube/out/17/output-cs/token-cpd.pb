j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Usings.csˆ_
o/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/UserDbContext.cs
	namespace

 	
Modules


 
.

 
Users

 
.

 
Infrastructure

 &
{ 
public 
class 
UserDbContext 
: 
IdentityDbContext /
</ 0#
ApplicationIdentityUser0 G
,G H#
ApplicationIdentityRoleI `
,` a
stringb h
,h i
IdentityUserClaimj {
<{ |
string	| Ç
>
Ç É
,
É Ñ)
ApplicationIdentityUserRole
Ö †
,
† °
IdentityUserLogin
¢ ≥
<
≥ ¥
string
¥ ∫
>
∫ ª
,
ª º
IdentityRoleClaim
Ω Œ
<
Œ œ
string
œ ’
>
’ ÷
,
÷ ◊
IdentityUserToken
ÿ È
<
È Í
string
Í 
>
 Ò
>
Ò Ú
{ 
public 
UserDbContext	 
( 
DbContextOptions '
<' (
UserDbContext( 5
>5 6
options7 >
)> ?
:@ A
baseB F
(F G
optionsG N
)N O
{ 	
} 
public 
DbSet 
< #
ApplicationIdentityUser ,
>, -
UserDetails. 9
{: ;
get< ?
;? @
setA D
;D E
}F G
public 
DbSet 
< #
ApplicationIdentityRole ,
>, -
roles. 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
public 
DbSet 
< '
ApplicationIdentityUserRole 0
>0 1
	userRoles2 ;
{< =
get> A
;A B
setC F
;F G
}H I
public 
DbSet 
< 
Channels 
> 
Channels '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
DbSet 
< 

Department 
>  

Department! +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
DbSet 
< 
DepartmentUnit #
># $
DepartmentUnit% 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
public 
DbSet 
< 

TokenStore 
>  

TokenStore! +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
DbSet 
< 
Menus 
> 
Menus !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DbSet 
< 
SubMenus 
> 
SubMenus '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
DbSet 
< 
SubMenuItems !
>! "
SubMenuItems# /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public   
DbSet   
<   
AccessPermissions   &
>  & '
Permissions  ( 3
{  4 5
get  6 9
;  9 :
set  ; >
;  > ?
}  @ A
public!! 
DbSet!! 
<!! 
SubPermissions!! #
>!!# $
SubPermissions!!% 3
{!!4 5
get!!6 9
;!!9 :
set!!; >
;!!> ?
}!!@ A
public"" 
DbSet"" 
<"" 
SubPermissionsItems"" (
>""( )
SubPermissionsItems""* =
{""> ?
get""@ C
;""C D
set""E H
;""H I
}""J K
public$$ 
DbSet$$ 
<$$ 
StaffAccounts$$ "
>$$" #
StaffAccounts$$$ 1
{$$2 3
get$$4 7
;$$7 8
set$$9 <
;$$< =
}$$> ?
public&& 
DbSet&& 
<&& 
ApplicationModules&& '
>&&' (
ApplicationModules&&) ;
{&&< =
get&&> A
;&&A B
set&&C F
;&&F G
}&&H I
public'' 
DbSet'' 
<'' )
ApplicationModulesPermissions'' 2
>''2 3)
ApplicationModulesPermissions''4 Q
{''R S
get''T W
;''W X
set''Y \
;''\ ]
}''^ _
public)) 
DbSet)) 
<)) 
IdentificationType)) '
>))' (
IdentificationType))) ;
{))< =
get))> A
;))A B
set))C F
;))F G
}))H I
	protected.. 
override.. 
void.. 
OnModelCreating..  /
(../ 0
ModelBuilder..0 <
builder..= D
)..D E
{// 	
base11 
.11 
OnModelCreating11  
(11  !
builder11! (
)11( )
;11) *
builder33 
.33 
Entity33 
<33 
IdentityRoleClaim33 ,
<33, -
string33- 3
>333 4
>334 5
(335 6
)336 7
.337 8
ToTable338 ?
(33? @
$str33@ L
,33L M
$str33N S
)33S T
;33T U
builder44 
.44 
Entity44 
<44 #
ApplicationIdentityRole44 2
>442 3
(443 4
)444 5
.445 6
ToTable446 =
(44= >
$str44> E
,44E F
$str44G L
)44L M
;44M N
builder55 
.55 
Entity55 
<55 
IdentityUserClaim55 ,
<55, -
string55- 3
>553 4
>554 5
(555 6
)556 7
.557 8
ToTable558 ?
(55? @
$str55@ L
,55L M
$str55N S
)55S T
;55T U
builder66 
.66 
Entity66 
<66 
IdentityUserLogin66 ,
<66, -
string66- 3
>663 4
>664 5
(665 6
)666 7
.667 8
ToTable668 ?
(66? @
$str66@ L
,66L M
$str66N S
)66S T
;66T U
builder77 
.77 
Entity77 
<77 '
ApplicationIdentityUserRole77 6
>776 7
(777 8
)778 9
.779 :
ToTable77: A
(77A B
$str77B M
,77M N
$str77O T
)77T U
;77U V
builder88 
.88 
Entity88 
<88 #
ApplicationIdentityUser88 2
>882 3
(883 4
)884 5
.885 6
ToTable886 =
(88= >
$str88> E
,88E F
$str88G L
)88L M
;88M N
builder99 
.99 
Entity99 
<99 
IdentityUserToken99 ,
<99, -
string99- 3
>993 4
>994 5
(995 6
)996 7
.997 8
ToTable998 ?
(99? @
$str99@ L
,99L M
$str99N S
)99S T
;99T U
builder;; 
.;; 
Entity;; 
<;; 
Channels;; #
>;;# $
(;;$ %
);;% &
.<< 
HasIndex<< 
(<< 
c<< 
=><< 
c<<  
.<<  !
ChannelName<<! ,
)<<, -
.== 
IsUnique== 
(== 
true== 
)== 
;==  
builder?? 
.?? 
Entity?? 
<?? 

Department?? %
>??% &
(??& '
)??' (
.@@ 
HasIndex@@ 
(@@ 
d@@ 
=>@@ 
d@@  
.@@  !
DepartmentName@@! /
)@@/ 0
.AA 
IsUniqueAA 
(AA 
trueAA 
)AA 
;AA  
builderCC 
.CC 
EntityCC 
<CC 
DepartmentUnitCC )
>CC) *
(CC* +
)CC+ ,
.DD 
HasIndexDD 
(DD 
duDD 
=>DD 
duDD  "
.DD" #
UnitNameDD# +
)DD+ ,
.EE 
IsUniqueEE 
(EE 
trueEE 
)EE 
;EE  
builderGG 
.GG 
EntityGG 
<GG 

TokenStoreGG %
>GG% &
(GG& '
)GG' (
.HH 
HasIndexHH 
(HH 
tsHH 
=>HH 
tsHH  "
.HH" #
TokenHH# (
)HH( )
.II 
IsUniqueII 
(II 
)II 
;II 
builderKK 
.KK 
EntityKK 
<KK 
MenusKK  
>KK  !
(KK! "
)KK" #
.LL 
HasIndexLL 
(LL 
mLL 
=>LL 
mLL  
.LL  !
MenuNameLL! )
)LL) *
.MM 
IsUniqueMM 
(MM 
trueMM 
)MM 
;MM  
builderOO 
.OO 
EntityOO 
<OO 
SubMenuItemsOO '
>OO' (
(OO( )
)OO) *
.PP 
HasIndexPP 
(PP 
smiPP 
=>PP  
smiPP! $
.PP$ %
SubMenuItemNamePP% 4
)PP4 5
.QQ 
IsUniqueQQ 
(QQ 
trueQQ 
)QQ 
;QQ  
builderSS 
.SS 
EntitySS 
<SS 
ApplicationModulesSS -
>SS- .
(SS. /
)SS/ 0
.TT 
HasIndexTT 
(TT 
amTT 
=>TT 
newTT  #
{TT$ %
amTT& (
.TT( )
ModuleIdTT) 1
,TT1 2
amTT3 5
.TT5 6

ModuleNameTT6 @
}TTA B
)TTB C
.UU 
IsUniqueUU 
(UU 
trueUU 
)UU 
;UU  
builderWW 
.WW 
EntityWW 
<WW 
IdentificationTypeWW -
>WW- .
(WW. /
)WW/ 0
.XX 
HasKeyXX 
(XX 
eXX 
=>XX 
eXX 
.XX  
IdentificationTypeIdXX 3
)XX3 4
;XX4 5
builderZZ 
.ZZ 
EntityZZ 
<ZZ 
IdentificationTypeZZ -
>ZZ- .
(ZZ. /
)ZZ/ 0
.[[ 
Property[[ 
([[ 
e[[ 
=>[[ 
e[[  
.[[  ! 
IdentificationTypeId[[! 5
)[[5 6
.\\ 
ValueGeneratedNever\\ $
(\\$ %
)\\% &
;\\& '
builder^^ 
.^^ 
Entity^^ 
<^^ 
IdentificationType^^ -
>^^- .
(^^. /
)^^/ 0
.__ 
HasIndex__ 
(__ 
e__ 
=>__ 
new__ "
{__# $
e__% &
.__& ' 
IdentificationTypeId__' ;
,__; <
e__= >
.__> ?
IdentificationTypes__? R
}__S T
)__T U
.`` 
IsUnique`` 
(`` 
true`` 
)`` 
;``  
buildergg 
.gg 
ApplyConfigurationgg &
(gg& '
newgg' * 
ChannelConfigurationgg+ ?
(gg? @
)gg@ A
)ggA B
;ggB C
builderhh 
.hh 
ApplyConfigurationhh &
(hh& '
newhh' *$
DepartmentsConfigurationhh+ C
(hhC D
)hhD E
)hhE F
;hhF G
builderii 
.ii 
ApplyConfigurationii &
(ii& '
newii' *)
DepartmentsUnitsConfigurationii+ H
(iiH I
)iiI J
)iiJ K
;iiK L
}ll 	
}mm 
}nn ¡
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/UsersRolesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
{ 
public 
class  
UsersRolesRepository "
:# $

Repository% /
</ 0'
ApplicationIdentityUserRole0 K
>K L
,L M!
IUsersRolesRepositoryN c
{ 
public  
UsersRolesRepository	 
( 
UserDbContext +
	dbContext, 5
)5 6
:7 8
base9 =
(= >
	dbContext> G
)G H
{ 
} 
}		 
}

 §
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/UserRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
{ 
public 
class 
UserRepository 
: 

Repository )
<) *#
ApplicationIdentityUser* A
>A B
,B C
IUserRepositoryD S
{ 
public 
UserRepository	 
( 
UserDbContext %
	dbContext& /
)/ 0
:1 2
base3 7
(7 8
	dbContext8 A
)A B
{ 
} 
}		 
}

 ¯H
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/UnitOfWork.cs
	namespace

 	
Modules


 
.

 
Users

 
.

 
Infrastructure

 &
.

& '
Repositories

' 3
{ 
public 
class 

UnitOfWork 
: 
IUnitOfWork &
{ 
private 
bool 
disposedValue "
;" #
private 
IConfiguration 
_configuration -
{. /
get0 3
;3 4
}5 6
private 
readonly 
UserDbContext &

_dbContext' 1
;1 2
readonly 
UserManager 
< #
ApplicationIdentityUser 4
>4 5
_userManager6 B
;B C
private 
readonly 

HttpClient #
_httpClient$ /
;/ 0
public 

UnitOfWork 
( 
UserDbContext '
	dbContext( 1
,1 2
UserManager3 >
<> ?#
ApplicationIdentityUser? V
>V W
userManagerX c
,c d
IConfigurationf t
configuration	u Ç
,
Ç É

HttpClient
Ñ é

httpClient
è ô
)
ô ö
{ 	

_dbContext 
= 
	dbContext "
;" #
_userManager 
= 
userManager &
;& '
_configuration 
= 
configuration *
;* +
_httpClient 
= 

httpClient $
;$ %

Department 
= 
new  
DepartmentRepository 1
(1 2
	dbContext2 ;
); <
;< =
DepartmentUnit   
=   
new    $
DepartmentUnitRepository  ! 9
(  9 :
	dbContext  : C
)  C D
;  D E
Channels!! 
=!! 
new!! 
ChannelsRepository!! -
(!!- .
	dbContext!!. 7
)!!7 8
;!!8 9

TokenStore"" 
="" 
new""  
TokenStoreRepository"" 1
(""1 2
	dbContext""2 ;
,""; <
_userManager""= I
!""I J
,""J K
_configuration""L Z
!""Z [
,""[ \
_httpClient""] h
)""h i
;""i j
Users$$ 
=$$ 
new$$ 
UserRepository$$ &
($$& '
	dbContext$$' 0
)$$0 1
;$$1 2
Roles%% 
=%% 
new%% 
RolesRepository%% '
(%%' (
	dbContext%%( 1
)%%1 2
;%%2 3

UsersRoles&& 
=&& 
new&&  
UsersRolesRepository&& 1
(&&1 2
	dbContext&&2 ;
)&&; <
;&&< =
Menus(( 
=(( 
new(( 
MenusRepository(( '
(((' (
	dbContext((( 1
)((1 2
;((2 3
SubMenus)) 
=)) 
new)) 
SubMenusRepository)) -
())- .
	dbContext)). 7
)))7 8
;))8 9
SubMenuItems** 
=** 
new** "
SubMenuItemsRepository** 5
(**5 6
	dbContext**6 ?
)**? @
;**@ A
AcccessPermissions,, 
=,,  
new,,! $!
PermissionsRepository,,% :
(,,: ;
	dbContext,,; D
),,D E
;,,E F
SubPermissions-- 
=-- 
new--  $
SubPermissionsRepository--! 9
(--9 :
	dbContext--: C
)--C D
;--D E
SubPermissionsItems.. 
=..  !
new.." %)
SubPermissionsItemsRepository..& C
(..C D
	dbContext..D M
)..M N
;..N O
StaffAccounts// 
=// 
new// #
StaffAccountsRepository//  7
(//7 8
	dbContext//8 A
)//A B
;//B C
ApplicationModules11 
=11  
new11! $(
ApplicationModulesRepository11% A
(11A B
	dbContext11B K
)11K L
;11L M)
ApplicationModulesPermissions22 )
=22* +
new22, /3
'ApplicationModulesPermissionsRepository220 W
(22W X
	dbContext22X a
)22a b
;22b c
IdentificationType44 
=44  
new44! $(
IdentificationTypeRepository44% A
(44A B
	dbContext44B K
)44K L
;44L M
}77 	
public:: !
IDepartmentRepository:: $

Department::% /
{::0 1
get::2 5
;::5 6
private::7 >
set::? B
;::B C
}::D E
public;; %
IDepartmentUnitRepository;; (
DepartmentUnit;;) 7
{;;8 9
get;;: =
;;;= >
private;;? F
set;;G J
;;;J K
};;L M
public<< 
IChannelsRepository<< "
Channels<<# +
{<<, -
get<<. 1
;<<1 2
private<<3 :
set<<; >
;<<> ?
}<<@ A
public== !
ITokenStoreRepository== $

TokenStore==% /
{==0 1
get==2 5
;==5 6
private==7 >
set==? B
;==B C
}==D E
public?? 
IUserRepository?? 
Users?? $
{??% &
get??' *
;??* +
private??, 3
set??4 7
;??7 8
}??9 :
public@@ 
IRolesRepository@@ 
Roles@@  %
{@@& '
get@@( +
;@@+ ,
private@@- 4
set@@5 8
;@@8 9
}@@: ;
publicAA !
IUsersRolesRepositoryAA $

UsersRolesAA% /
{AA0 1
getAA2 5
;AA5 6
privateAA7 >
setAA? B
;AAB C
}AAD E
publicCC 
IMenusRepositoryCC 
MenusCC  %
{CC& '
getCC( +
;CC+ ,
privateCC- 4
setCC5 8
;CC8 9
}CC: ;
publicDD 
ISubMenusRepositoryDD "
SubMenusDD# +
{DD, -
getDD. 1
;DD1 2
privateDD3 :
setDD; >
;DD> ?
}DD@ A
publicEE #
ISubMenuItemsRepositoryEE &
SubMenuItemsEE' 3
{EE4 5
getEE6 9
;EE9 :
privateEE; B
setEEC F
;EEF G
}EEH I
publicGG "
IPermissionsRepositoryGG %
AcccessPermissionsGG& 8
{GG9 :
getGG; >
;GG> ?
privateGG@ G
setGGH K
;GGK L
}GGM N
publicHH %
ISubPermissionsRepositoryHH (
SubPermissionsHH) 7
{HH8 9
getHH: =
;HH= >
privateHH? F
setHHG J
;HHJ K
}HHL M
publicII *
ISubPermissionsItemsRepositoryII -
SubPermissionsItemsII. A
{IIB C
getIID G
;IIG H
privateIII P
setIIQ T
;IIT U
}IIV W
publicKK $
IStaffAccountsRepositoryKK '
StaffAccountsKK( 5
{KK6 7
getKK8 ;
;KK; <
privateKK= D
setKKE H
;KKH I
}KKJ K
publicMM )
IApplicationModulesRepositoryMM ,
ApplicationModulesMM- ?
{MM@ A
getMMB E
;MME F
privateMMG N
setMMO R
;MMR S
}MMT U
publicNN 4
(IApplicationModulesPermissionsRepositoryNN 7)
ApplicationModulesPermissionsNN8 U
{NNV W
getNNX [
;NN[ \
privateNN] d
setNNe h
;NNh i
}NNj k
publicPP )
IIdentificationTypeRepositoryPP ,
IdentificationTypePP- ?
{PP@ A
getPPB E
;PPE F
privatePPG N
setPPO R
;PPR S
}PPT U
publicTT 
TaskTT 
<TT 
intTT 
>TT 
CompleteTT !
(TT! "
)TT" #
{UU 	
returnVV 

_dbContextVV 
.VV 
SaveChangesAsyncVV .
(VV. /
)VV/ 0
;VV0 1
}WW 	
	protectedYY 
virtualYY 
voidYY 
DisposeYY &
(YY& '
boolYY' +
	disposingYY, 5
)YY5 6
{ZZ 	
if[[ 
([[ 
![[ 
disposedValue[[ 
)[[ 
{\\ 
if]] 
(]] 
	disposing]] 
)]] 
{^^ 

_dbContext`` 
.`` 
Dispose`` &
(``& '
)``' (
;``( )
}aa 
disposedValueee 
=ee 
trueee  $
;ee$ %
}ff 
}gg 	
publicii 
voidii 
Disposeii 
(ii 
)ii 
{jj 	
Disposell 
(ll 
	disposingll 
:ll 
truell #
)ll# $
;ll$ %
GCmm 
.mm 
SuppressFinalizemm 
(mm  
thismm  $
)mm$ %
;mm% &
}nn 	
}oo 
}pp ø
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/StaffAccountsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
{ 
public 
class #
StaffAccountsRepository %
:& '

Repository( 2
<2 3
StaffAccounts3 @
>@ A
,A B$
IStaffAccountsRepositoryC [
{ 
public #
StaffAccountsRepository	  
(  !
UserDbContext! .
	dbContext/ 8
)8 9
:: ;
base< @
(@ A
	dbContextA J
)J K
{ 	
} 
}		 
}

 ®
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/RolesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
{ 
public 
class 
RolesRepository 
: 

Repository  *
<* +#
ApplicationIdentityRole+ B
>B C
,C D
IRolesRepositoryE U
{ 
public 
RolesRepository	 
( 
UserDbContext &
	dbContext' 0
)0 1
:2 3
base4 8
(8 9
	dbContext9 B
)B C
{ 
} 
}		 
}

 ˛@
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Repository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
{ 
public 

class 

Repository 
< 
TEntity #
># $
:% &
IRepository' 2
<2 3
TEntity3 :
>: ;
where< A
TEntityB I
:J K
classL Q
{		 
	protected

 
readonly

 
	DbContext

 $

_dbContext

% /
;

/ 0
public 

Repository 
( 
	DbContext #
	dbContext$ -
)- .
{ 	

_dbContext 
= 
	dbContext "
;" #
} 	
public 
void 
Delete 
( 
TEntity "
entity# )
)) *
=>+ -

_dbContext. 8
.8 9
Set9 <
<< =
TEntity= D
>D E
(E F
)F G
.G H
RemoveH N
(N O
entityO U
)U V
;V W
public 
void 
DeleteRange 
(  
IEnumerable  +
<+ ,
TEntity, 3
>3 4
entities5 =
)= >
=>? A

_dbContextB L
.L M
SetM P
<P Q
TEntityQ X
>X Y
(Y Z
)Z [
.[ \
RemoveRange\ g
(g h
entitiesh p
)p q
;q r
public 
async 
Task 
< 
TEntity !
?! "
>" #
Get$ '
(' (
int( +
id, .
). /
=>0 2
await3 8

_dbContext9 C
.C D
SetD G
<G H
TEntityH O
>O P
(P Q
)Q R
.R S
	FindAsyncS \
(\ ]
id] _
)_ `
;` a
public 
async 
Task 
< 
TEntity !
?! "
>" #
Get$ '
(' (

Expression( 2
<2 3
Func3 7
<7 8
TEntity8 ?
,? @
boolA E
>E F
>F G

expressionH R
,R S
ListT X
<X Y
stringY _
>_ `
?` a
includesb j
=k l
nullm q
)q r
{ 	

IQueryable 
< 
TEntity 
> 
entities  (
=) *

_dbContext+ 5
.5 6
Set6 9
<9 :
TEntity: A
>A B
(B C
)C D
;D E
if 
( 
includes 
!= 
null  
)  !
{ 
foreach 
( 
var 
includeProp (
in) +
includes, 4
)4 5
{ 
entities 
= 
entities '
.' (
Include( /
(/ 0
includeProp0 ;
); <
;< =
}   
}!! 
return## 
await## 
entities## !
.##! "
AsNoTracking##" .
(##. /
)##/ 0
.##0 1
FirstOrDefaultAsync##1 D
(##D E

expression##E O
)##O P
;##P Q
}$$ 	
public&& 
async&& 
Task&& 
<&& 
IList&& 
<&&  
TEntity&&  '
>&&' (
>&&( )
GetAll&&* 0
(&&0 1

Expression&&1 ;
<&&; <
Func&&< @
<&&@ A
TEntity&&A H
,&&H I
bool&&J N
>&&N O
>&&O P
?&&P Q

expression&&R \
=&&] ^
null&&_ c
,&&c d
Func&&e i
<&&i j

IQueryable&&j t
<&&t u
TEntity&&u |
>&&| }
,&&} ~
IOrderedQueryable	&& ê
<
&&ê ë
TEntity
&&ë ò
>
&&ò ô
>
&&ô ö
?
&&ö õ
orderBy
&&ú £
=
&&§ •
null
&&¶ ™
,
&&™ ´
List
&&¨ ∞
<
&&∞ ±
string
&&± ∑
>
&&∑ ∏
?
&&∏ π
includes
&&∫ ¬
=
&&√ ƒ
null
&&≈ …
)
&&…  
{'' 	

IQueryable(( 
<(( 
TEntity(( 
>(( 
query((  %
=((& '

_dbContext((( 2
.((2 3
Set((3 6
<((6 7
TEntity((7 >
>((> ?
(((? @
)((@ A
;((A B
if** 
(** 

expression** 
!=** 
null** "
)**" #
query++ 
=++ 
query++ 
.++ 
Where++ #
(++# $

expression++$ .
)++. /
;++/ 0
if-- 
(-- 
includes-- 
!=-- 
null--  
)--  !
{.. 
foreach// 
(// 
var// 
includeProperty// ,
in//- /
includes//0 8
)//8 9
query00 
=00 
query00 !
.00! "
Include00" )
(00) *
includeProperty00* 9
)009 :
;00: ;
}11 
if33 
(33 
orderBy33 
!=33 
null33 
)33  
query44 
=44 
orderBy44 
(44  
query44  %
)44% &
;44& '
return66 
await66 
query66 
.66 
AsNoTracking66 +
(66+ ,
)66, -
.66- .
ToListAsync66. 9
(669 :
)66: ;
;66; <
}77 	
public99 
async99 
Task99 
<99 
IList99 
<99  
TEntity99  '
>99' (
>99( )
GetAll99* 0
(990 1
)991 2
=>993 5
await996 ;

_dbContext99< F
.99F G
Set99G J
<99J K
TEntity99K R
>99R S
(99S T
)99T U
.99U V
ToListAsync99V a
(99a b
)99b c
;99c d
public;; 
async;; 
void;; 
Insert;;  
(;;  !
TEntity;;! (
entity;;) /
);;/ 0
=>;;1 3
await;;4 9

_dbContext;;: D
.;;D E
Set;;E H
<;;H I
TEntity;;I P
>;;P Q
(;;Q R
);;R S
.;;S T
AddAsync;;T \
(;;\ ]
entity;;] c
);;c d
;;;d e
public== 
async== 
void== 
InsertRange== %
(==% &
IEnumerable==& 1
<==1 2
TEntity==2 9
>==9 :
entities==; C
)==C D
=>==E G
await==H M

_dbContext==N X
.==X Y
Set==Y \
<==\ ]
TEntity==] d
>==d e
(==e f
)==f g
.==g h
AddRangeAsync==h u
(==u v
entities==v ~
)==~ 
;	== Ä
public?? 
void?? 
Update?? 
(?? 
TEntity?? "
entity??# )
)??) *
=>??+ -

_dbContext??. 8
.??8 9
Set??9 <
<??< =
TEntity??= D
>??D E
(??E F
)??F G
.??G H
Update??H N
(??N O
entity??O U
)??U V
;??V W
publicAA 
voidAA 
UpdateRangeAA 
(AA  
IEnumerableAA  +
<AA+ ,
TEntityAA, 3
>AA3 4
entitiesAA5 =
)AA= >
=>AA? A

_dbContextAAB L
.AAL M
SetAAM P
<AAP Q
TEntityAAQ X
>AAX Y
(AAY Z
)AAZ [
.AA[ \
UpdateRangeAA\ g
(AAg h
entitiesAAh p
)AAp q
;AAq r
}BB 
}DD â°
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/TokenStoreRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class  
TokenStoreRepository "
:# $

Repository% /
</ 0

TokenStore0 :
>: ;
,; <!
ITokenStoreRepository= R
{ 
string 
mobilePhoneNumber  
=! "
string# )
.) *
Empty* /
,/ 0
emailAddress1 =
=> ?
string@ F
.F G
EmptyG L
;L M
Regex 

emailRegex 
= 
new 
Regex $
($ %
$str% B
)B C
;C D
Regex 

phoneRegex 
= 
new 
Regex $
($ %
$str% h
)h i
;i j
private 
IConfiguration 
_configuration -
{. /
get0 3
;3 4
}5 6
private 
readonly 
UserDbContext &
_userDbContext' 5
;5 6
readonly 
UserManager 
< #
ApplicationIdentityUser 4
>4 5
_userManager6 B
;B C
private   
readonly   

HttpClient   #
_httpClient  $ /
;  / 0
public##  
TokenStoreRepository## #
(### $
UserDbContext##$ 1
	dbContext##2 ;
,##; <
UserManager##= H
<##H I#
ApplicationIdentityUser##I `
>##` a
userManager##b m
,##m n
IConfiguration##p ~
configuration	## å
,
##å ç

HttpClient
##é ò

httpClient
##ô £
)
##£ §
:
##• ¶
base
##ß ´
(
##´ ¨
	dbContext
##¨ µ
)
##µ ∂
{$$ 	
_userDbContext%% 
=%% 
	dbContext%% &
;%%& '
_userManager&& 
=&& 
userManager&& &
;&&& '
_configuration(( 
=(( 
configuration(( *
;((* +
_httpClient)) 
=)) 

httpClient)) $
;))$ %
}** 	
private,, 
async,, 
Task,, $
SendTokenViaNotification,, 3
(,,3 4
string,,4 :
userid,,; A
,,,A B
string,,C I
token,,J O
),,O P
{-- 	#
ApplicationIdentityUser.. #
?..# $
user..% )
=..* +
null.., 0
;..0 1
if00 
(00 

emailRegex00 
.00 
IsMatch00 "
(00" #
userid00# )
)00) *
)00* +
{11 
user22 
=22 
_userDbContext22 %
.22% &
Users22& +
.22+ ,
FirstOrDefault22, :
(22: ;
e22; <
=>22= ?
e22@ A
.22A B
Email22B G
==22H J
userid22K Q
)22Q R
;22R S
}33 
if55 
(55 

phoneRegex55 
.55 
IsMatch55 "
(55" #
userid55# )
)55) *
)55* +
{66 
user77 
=77 
_userDbContext77 %
.77% &
Users77& +
.77+ ,
FirstOrDefault77, :
(77: ;
e77; <
=>77= ?
e77@ A
.77A B
PhoneNumber77B M
==77N P
userid77Q W
)77W X
;77X Y
}88 
var:: 
sb:: 
=:: 
new:: 
StringBuilder:: &
(::& '
)::' (
;::( )
sb<< 
.<< 

AppendLine<< 
(<< 
$"<< 
$str<< !
{<<! "
user<<" &
!<<& '
.<<' (
	FirstName<<( 1
}<<1 2
$str<<2 3
{<<3 4
user<<4 8
.<<8 9
LastName<<9 A
}<<A B
$str<<B G
"<<G H
)<<H I
;<<I J
sb== 
.== 

AppendLine== 
(== 
$str==  
)==  !
;==! "
sb>> 
.>> 

AppendLine>> 
(>> 
$">> 
$str	>> π
"
>>π ∫
)
>>∫ ª
;
>>ª º
sb?? 
.?? 

AppendLine?? 
(?? 
$str??  
)??  !
;??! "
sb@@ 
.@@ 

AppendLine@@ 
(@@ 
$"@@ 
$str@@ )
{@@) *
token@@* /
}@@/ 0
$str@@0 8
"@@8 9
)@@9 :
;@@: ;
sbAA 
.AA 

AppendLineAA 
(AA 
$strAA  
)AA  !
;AA! "
sbBB 
.BB 

AppendLineBB 
(BB 
$"BB 
$str	BB ã
"
BBã å
)
BBå ç
;
BBç é
sbCC 
.CC 

AppendLineCC 
(CC 
$strCC  
)CC  !
;CC! "
sbDD 
.DD 

AppendLineDD 
(DD 
$"DD 
$str	DD Ç
"
DDÇ É
)
DDÉ Ñ
;
DDÑ Ö
sbEE 
.EE 

AppendLineEE 
(EE 
$strEE  
)EE  !
;EE! "
sbFF 
.FF 

AppendLineFF 
(FF 
$"FF 
$strFF =
"FF= >
)FF> ?
;FF? @
sbGG 
.GG 

AppendLineGG 
(GG 
$strGG  
)GG  !
;GG! "
sbHH 
.HH 

AppendLineHH 
(HH 
$"HH 
$strHH -
"HH- .
)HH. /
;HH/ 0
sbII 
.II 

AppendLineII 
(II 
$strII  
)II  !
;II! "
sbJJ 
.JJ 

AppendLineJJ 
(JJ 
$"JJ 
$strJJ ,
"JJ, -
)JJ- .
;JJ. /
sbKK 
.KK 

AppendLineKK 
(KK 
$"KK 
$strKK .
"KK. /
)KK/ 0
;KK0 1
sbLL 
.LL 

AppendLineLL 
(LL 
$"LL 
$strLL *
"LL* +
)LL+ ,
;LL, -
varOO 
email_payloadOO 
=OO 
newOO  #
{OO$ %
userIdOO& ,
=OO- .
userOO/ 3
.OO3 4
EmailOO4 9
,OO9 :
displayNameOO; F
=OOG H
$strOOI X
,OOX Y
subjectOOZ a
=OOb c
$strOOd v
,OOv w
messageOOx 
=
OOÄ Å
sb
OOÇ Ñ
.
OOÑ Ö
ToString
OOÖ ç
(
OOç é
)
OOé è
,
OOè ê
type
OOë ï
=
OOñ ó
$num
OOò ô
}
OOö õ
;
OOõ ú
varPP 
sms_payloadPP 
=PP 
newPP !
{PP" #
userIdPP$ *
=PP+ ,
userPP- 1
.PP1 2
PhoneNumberPP2 =
,PP= >
displayNamePP? J
=PPK L
stringPPM S
.PPS T
EmptyPPT Y
,PPY Z
subjectPP[ b
=PPc d
stringPPe k
.PPk l
EmptyPPl q
,PPq r
messagePPs z
=PP{ |
$"PP} 
$str	PP é
{
PPé è
token
PPè î
}
PPî ï
$str
PPï ”
"
PP” ‘
,
PP’ ÷
type
PP◊ €
=
PP‹ ›
$num
PPﬁ ﬂ
}
PP‡ ·
;
PP· ‚
stringSS 
json_smspayloadSS "
=SS# $
JsonSerializerSS% 3
.SS3 4
	SerializeSS4 =
(SS= >
sms_payloadSS> I
)SSI J
;SSJ K
varTT 
sms_httpContentTT 
=TT  !
newTT" %
StringContentTT& 3
(TT3 4
json_smspayloadTT4 C
,TTC D
EncodingTTE M
.TTM N
UTF8TTN R
,TTR S
$strTTT f
)TTf g
;TTg h
HttpResponseMessageUU 
sms_responseUU  ,
=UU- .
awaitUU/ 4
_httpClientUU5 @
.UU@ A
	PostAsyncUUA J
(UUJ K
$str	UUK ú
,
UUú ù
sms_httpContent
UUû ≠
)
UU≠ Æ
;
UUÆ Ø
varVV 

result_smsVV 
=VV 
sms_responseVV )
.VV) *
IsSuccessStatusCodeVV* =
;VV= >
stringXX 
json_emailpayloadXX $
=XX% &
JsonSerializerXX' 5
.XX5 6
	SerializeXX6 ?
(XX? @
email_payloadXX@ M
)XXM N
;XXN O
varYY 
email_httpContentYY !
=YY" #
newYY$ '
StringContentYY( 5
(YY5 6
json_emailpayloadYY6 G
,YYG H
EncodingYYI Q
.YYQ R
UTF8YYR V
,YYV W
$strYYX j
)YYj k
;YYk l
HttpResponseMessageZZ 
responseZZ  (
=ZZ) *
awaitZZ+ 0
_httpClientZZ1 <
.ZZ< =
	PostAsyncZZ= F
(ZZF G
$str	ZZG ò
,
ZZò ô
email_httpContent
ZZö ´
)
ZZ´ ¨
;
ZZ¨ ≠
var[[ 
result[[ 
=[[ 
response[[ !
.[[! "
IsSuccessStatusCode[[" 5
;[[5 6
}]] 	
public__ 
async__ 
Task__ 
<__ 
string__  
>__  !
GetToken__" *
(__* +
string__+ 1-
!mobilePhoneNumber_OR_emailAddress__2 S
,__S T
int__U X
ExpiryMinutes__Y f
)__f g
{`` 	
stringaa 
tokenaa 
=aa 
Applicationaa &
.aa& '
Helpersaa' .
.aa. /
NumberGeneratoraa/ >
.aa> ?
	Generatoraa? H
(aaH I
$numaaI J
)aaJ K
;aaK L
ifdd 
(dd 

emailRegexdd 
.dd 
IsMatchdd "
(dd" #-
!mobilePhoneNumber_OR_emailAddressdd# D
)ddD E
)ddE F
{ee 
emailAddressff 
=ff -
!mobilePhoneNumber_OR_emailAddressff @
;ff@ A
vargg 
usergg 
=gg 
awaitgg  
_userManagergg! -
.gg- .
FindByEmailAsyncgg. >
(gg> ?
emailAddressgg? K
)ggK L
;ggL M
ifhh 
(hh 
userhh 
ishh 
nullhh 
)hh  
{ii 
returnjj 
$"jj 
$strjj 1
{jj1 2
emailAddressjj2 >
}jj> ?
$strjj? Y
"jjY Z
;jjZ [
}kk 
}ll 
ifnn 
(nn 
emailAddressnn 
==nn 
stringnn  &
.nn& '
Emptynn' ,
&&nn- /
!nn0 1

phoneRegexnn1 ;
.nn; <
IsMatchnn< C
(nnC D-
!mobilePhoneNumber_OR_emailAddressnnD e
)nne f
)nnf g
{oo 
returnpp 
$strpp =
;pp= >
}qq 
ifss 
(ss 

phoneRegexss 
.ss 
IsMatchss "
(ss" #-
!mobilePhoneNumber_OR_emailAddressss# D
)ssD E
)ssE F
{tt 
mobilePhoneNumberuu !
=uu" #-
!mobilePhoneNumber_OR_emailAddressuu$ E
;uuE F
varvv 
uservv 
=vv 
_userDbContextvv )
.vv) *
Usersvv* /
.vv/ 0
FirstOrDefaultvv0 >
(vv> ?
uvv? @
=>vvA C
uvvD E
.vvE F
PhoneNumbervvF Q
==vvR T
mobilePhoneNumbervvU f
)vvf g
;vvg h
ifww 
(ww 
userww 
isww 
nullww  
)ww  !
{xx 
returnyy 
$"yy 
$stryy 7
{yy7 8
mobilePhoneNumberyy8 I
}yyI J
$stryyJ d
"yyd e
;yye f
}zz 
}|| 
if~~ 
(~~ 
emailAddress~~ 
==~~ 
string~~ %
.~~% &
Empty~~& +
&&~~, .
mobilePhoneNumber~~/ @
==~~A C
string~~D J
.~~J K
Empty~~K P
)~~P Q
{ 
return
ÄÄ 
$str
ÄÄ N
;
ÄÄN O
}
ÅÅ 

TokenStore
ÑÑ 

tokenStore
ÑÑ !
=
ÑÑ" #
new
ÑÑ$ '

TokenStore
ÑÑ( 2
(
ÑÑ2 3
)
ÑÑ3 4
{
ÖÖ 
TokenStoreId
ÜÜ 
=
ÜÜ 
$num
ÜÜ  
,
ÜÜ  !
EmailAddress
áá 
=
áá 
emailAddress
áá +
,
áá+ ,
MobilePhoneNumber
àà !
=
àà" #
mobilePhoneNumber
àà$ 5
,
àà5 6
Token
ââ 
=
ââ 
token
ââ 
,
ââ 
CreatedDate
ää 
=
ää 
DateTime
ää &
.
ää& '
Now
ää' *
,
ää* +

ExpiryDate
ãã 
=
ãã 
DateTime
ãã %
.
ãã% &
Now
ãã& )
.
ãã) *

AddMinutes
ãã* 4
(
ãã4 5
ExpiryMinutes
ãã5 B
)
ããB C
,
ããC D

IsVerified
åå 
=
åå 
false
åå "
}
çç 
;
çç 
_userDbContext
èè 
.
èè 

TokenStore
èè %
.
èè% &
Add
èè& )
(
èè) *

tokenStore
èè* 4
)
èè4 5
;
èè5 6
await
êê 
_userDbContext
êê  
.
êê  !
SaveChangesAsync
êê! 1
(
êê1 2
)
êê2 3
;
êê3 4
await
íí 
this
íí 
.
íí &
SendTokenViaNotification
íí /
(
íí/ 0/
!mobilePhoneNumber_OR_emailAddress
íí0 Q
,
ííQ R
token
ííS X
)
ííX Y
;
ííY Z
return
îî 
token
îî 
;
îî 
}
ïï 	
public
óó 
async
óó 
Task
óó 
<
óó 
string
óó  
>
óó  !
VerifyToken
óó" -
(
óó- .
string
óó. 4/
!mobilePhoneNumber_OR_emailAddress
óó5 V
,
óóV W
string
óóX ^
	tokenCode
óó_ h
)
óóh i
{
òò 	
try
ôô 
{
öö 
if
õõ 
(
õõ 
string
õõ 
.
õõ  
IsNullOrWhiteSpace
õõ -
(
õõ- ./
!mobilePhoneNumber_OR_emailAddress
õõ. O
)
õõO P
is
õõQ S
true
õõT X
&&
õõY [
string
õõ\ b
.
õõb c 
IsNullOrWhiteSpace
õõc u
(
õõu v
	tokenCode
õõv 
)õõ Ä
isõõÅ É
trueõõÑ à
)õõà â
{
úú 
return
ùù 
$str
ùù R
;
ùùR S
}
ûû 
if
†† 
(
†† 

emailRegex
†† 
.
†† 
IsMatch
†† &
(
††& '/
!mobilePhoneNumber_OR_emailAddress
††' H
)
††H I
)
††I J
{
°° 
emailAddress
¢¢  
=
¢¢! "/
!mobilePhoneNumber_OR_emailAddress
¢¢# D
;
¢¢D E
}
££ 
if
•• 
(
•• 
emailAddress
••  
==
••! #
string
••$ *
.
••* +
Empty
••+ 0
&&
••1 3
!
••4 5

phoneRegex
••5 ?
.
••? @
IsMatch
••@ G
(
••G H/
!mobilePhoneNumber_OR_emailAddress
••H i
)
••i j
)
••j k
{
¶¶ 
return
ßß 
$str
ßß A
;
ßßA B
}
®® 
if
™™ 
(
™™ 

phoneRegex
™™ 
.
™™ 
IsMatch
™™ &
(
™™& '/
!mobilePhoneNumber_OR_emailAddress
™™' H
)
™™H I
)
™™I J
{
´´ 
mobilePhoneNumber
¨¨ %
=
¨¨& '/
!mobilePhoneNumber_OR_emailAddress
¨¨( I
;
¨¨I J
}
≠≠ 
if
ØØ 
(
ØØ 
emailAddress
ØØ  
==
ØØ! #
string
ØØ$ *
.
ØØ* +
Empty
ØØ+ 0
&&
ØØ1 3
mobilePhoneNumber
ØØ4 E
==
ØØF H
string
ØØI O
.
ØØO P
Empty
ØØP U
)
ØØU V
{
∞∞ 
return
±± 
$str
±± R
;
±±R S
}
≤≤ 
var
¥¥ 

checkToken
¥¥ 
=
¥¥  
_userDbContext
¥¥! /
.
¥¥/ 0

TokenStore
¥¥0 :
.
¥¥: ;
SingleOrDefault
¥¥; J
(
¥¥J K
t
¥¥K L
=>
¥¥M O
t
¥¥P Q
.
¥¥Q R
Token
¥¥R W
==
¥¥X Z
	tokenCode
¥¥[ d
)
¥¥d e
;
¥¥e f
if
µµ 
(
µµ 

checkToken
µµ 
is
µµ !
null
µµ" &
)
µµ& '
{
∂∂ 
return
∑∑ 
$str
∑∑ G
;
∑∑G H
}
∏∏ 
var
ªª 
checkTokenExpiry
ªª $
=
ªª% &
_userDbContext
ªª' 5
.
ªª5 6

TokenStore
ªª6 @
.
ªª@ A
SingleOrDefault
ªªA P
(
ªªP Q
t
ªªQ R
=>
ªªS U
t
ªªV W
.
ªªW X
Token
ªªX ]
==
ªª^ `
	tokenCode
ªªa j
&&
ªªk m
t
ªªn o
.
ªªo p

ExpiryDate
ªªp z
<=
ªª{ }
DateTimeªª~ Ü
.ªªÜ á
UtcNowªªá ç
)ªªç é
;ªªé è
if
ºº 
(
ºº 
checkTokenExpiry
ºº $
is
ºº% '
not
ºº( +
null
ºº, 0
)
ºº0 1
{
ΩΩ 
return
ææ 
$str
ææ ^
;
ææ^ _
}
øø 
var
¡¡ 
checkVerified
¡¡ !
=
¡¡" #
_userDbContext
¡¡$ 2
.
¡¡2 3

TokenStore
¡¡3 =
.
¡¡= >
SingleOrDefault
¡¡> M
(
¡¡M N
t
¡¡N O
=>
¡¡P R
t
¡¡S T
.
¡¡T U
Token
¡¡U Z
==
¡¡[ ]
	tokenCode
¡¡^ g
&&
¡¡h j
t
¡¡k l
.
¡¡l m

IsVerified
¡¡m w
==
¡¡x z
true
¡¡{ 
)¡¡ Ä
;¡¡Ä Å
if
¬¬ 
(
¬¬ 
checkVerified
¬¬ !
is
¬¬" $
not
¬¬% (
null
¬¬) -
)
¬¬- .
{
√√ 
return
ƒƒ 
$str
ƒƒ h
;
ƒƒh i
}
≈≈ 
var
»» 
result
»» 
=
»» 
_userDbContext
»» +
.
»»+ ,

TokenStore
»», 6
.
»»6 7
FirstOrDefault
»»7 E
(
»»E F
t
»»F G
=>
»»H J
t
»»K L
.
»»L M
Token
»»M R
==
»»S U
	tokenCode
»»V _
&&
»»` b
t
»»c d
.
»»d e

IsVerified
»»e o
==
»»p r
false
»»s x
&&
»»y {
t
»»| }
.
»»} ~ 
MobilePhoneNumber»»~ è
==»»ê í1
!mobilePhoneNumber_OR_emailAddress»»ì ¥
||»»µ ∑
t»»∏ π
.»»π ∫
EmailAddress»»∫ ∆
==»»« …1
!mobilePhoneNumber_OR_emailAddress»»  Î
)»»Î Ï
;»»Ï Ì
if
…… 
(
…… 
result
…… 
is
…… 
null
…… "
)
……" #
{
   
return
ÀÀ 
$str
ÀÀ )
;
ÀÀ) *
}
ÃÃ 
result
ŒŒ 
!
ŒŒ 
.
ŒŒ 

IsVerified
ŒŒ "
=
ŒŒ# $
true
ŒŒ% )
;
ŒŒ) *
result
œœ 
.
œœ 
VerifiedDate
œœ #
=
œœ$ %
DateTime
œœ& .
.
œœ. /
UtcNow
œœ/ 5
;
œœ5 6
_userDbContext
—— 
.
—— 

TokenStore
—— )
.
——) *
Update
——* 0
(
——0 1
result
——1 7
)
——7 8
;
——8 9
await
““ 
_userDbContext
““ $
.
““$ %
SaveChangesAsync
““% 5
(
““5 6
)
““6 7
;
““7 8
return
‘‘ 
$str
‘‘ !
;
‘‘! "
}
’’ 
catch
÷÷ 
(
÷÷ 
	Exception
÷÷ 
ex
÷÷ 
)
÷÷  
{
◊◊ 
return
ÿÿ 
$"
ÿÿ 
$str
ÿÿ 
{
ÿÿ  
ex
ÿÿ  "
.
ÿÿ" #
InnerException
ÿÿ# 1
!
ÿÿ1 2
.
ÿÿ2 3
Message
ÿÿ3 :
}
ÿÿ: ;
"
ÿÿ; <
;
ÿÿ< =
}
ŸŸ 
}
⁄⁄ 	
public
‹‹ 
string
‹‹ 
VerifyTokenExpiry
‹‹ '
(
‹‹' (
string
‹‹( ./
!mobilePhoneNumber_OR_emailAddress
‹‹/ P
,
‹‹P Q
string
‹‹R X
	tokenCode
‹‹Y b
)
‹‹b c
{
›› 	
if
ﬁﬁ 
(
ﬁﬁ 
string
ﬁﬁ 
.
ﬁﬁ  
IsNullOrWhiteSpace
ﬁﬁ )
(
ﬁﬁ) */
!mobilePhoneNumber_OR_emailAddress
ﬁﬁ* K
)
ﬁﬁK L
is
ﬁﬁM O
true
ﬁﬁP T
&&
ﬁﬁU W
string
ﬁﬁX ^
.
ﬁﬁ^ _ 
IsNullOrWhiteSpace
ﬁﬁ_ q
(
ﬁﬁq r
	tokenCode
ﬁﬁr {
)
ﬁﬁ{ |
is
ﬁﬁ} 
trueﬁﬁÄ Ñ
)ﬁﬁÑ Ö
{
ﬂﬂ 
return
‡‡ 
$str
‡‡ N
;
‡‡N O
}
·· 
if
„„ 
(
„„ 

emailRegex
„„ 
.
„„ 
IsMatch
„„ "
(
„„" #/
!mobilePhoneNumber_OR_emailAddress
„„# D
)
„„D E
)
„„E F
{
‰‰ 
emailAddress
ÂÂ 
=
ÂÂ /
!mobilePhoneNumber_OR_emailAddress
ÂÂ @
;
ÂÂ@ A
}
ÊÊ 
if
ËË 
(
ËË 
emailAddress
ËË 
==
ËË 
string
ËË  &
.
ËË& '
Empty
ËË' ,
&&
ËË- /
!
ËË0 1

phoneRegex
ËË1 ;
.
ËË; <
IsMatch
ËË< C
(
ËËC D/
!mobilePhoneNumber_OR_emailAddress
ËËD e
)
ËËe f
)
ËËf g
{
ÈÈ 
return
ÍÍ 
$str
ÍÍ =
;
ÍÍ= >
}
ÎÎ 
if
ÌÌ 
(
ÌÌ 

phoneRegex
ÌÌ 
.
ÌÌ 
IsMatch
ÌÌ "
(
ÌÌ" #/
!mobilePhoneNumber_OR_emailAddress
ÌÌ# D
)
ÌÌD E
)
ÌÌE F
{
ÓÓ 
mobilePhoneNumber
ÔÔ !
=
ÔÔ" #/
!mobilePhoneNumber_OR_emailAddress
ÔÔ$ E
;
ÔÔE F
}
 
if
ÚÚ 
(
ÚÚ 
emailAddress
ÚÚ 
==
ÚÚ 
string
ÚÚ  &
.
ÚÚ& '
Empty
ÚÚ' ,
&&
ÚÚ- /
mobilePhoneNumber
ÚÚ0 A
==
ÚÚB D
string
ÚÚE K
.
ÚÚK L
Empty
ÚÚL Q
)
ÚÚQ R
{
ÛÛ 
return
ÙÙ 
$str
ÙÙ N
;
ÙÙN O
}
ıı 
var
¯¯ 
result
¯¯ 
=
¯¯ 
_userDbContext
¯¯ '
.
¯¯' (

TokenStore
¯¯( 2
.
˘˘ 
SingleOrDefault
˘˘  
(
˘˘  !
t
˘˘! "
=>
˘˘# %
(
˙˙ 
t
˙˙ 
.
˙˙ 
MobilePhoneNumber
˙˙ (
==
˙˙) +/
!mobilePhoneNumber_OR_emailAddress
˙˙, M
||
˙˙N P
t
˙˙Q R
.
˙˙R S
EmailAddress
˙˙S _
==
˙˙` b0
!mobilePhoneNumber_OR_emailAddress˙˙c Ñ
)˙˙Ñ Ö
&&˙˙Ü à
t
˚˚ 
.
˚˚ 
Token
˚˚ 
==
˚˚ 
	tokenCode
˚˚  )
&&
˚˚* ,
t
˚˚- .
.
˚˚. /

ExpiryDate
˚˚/ 9
>=
˚˚: <
DateTime
˚˚= E
.
˚˚E F
UtcNow
˚˚F L
)
˚˚L M
;
˚˚M N
if
˝˝ 
(
˝˝ 
result
˝˝ 
is
˝˝ 
null
˝˝ 
)
˝˝ 
{
˛˛ 
return
ˇˇ 
$str
ˇˇ %
;
ˇˇ% &
}
ÄÄ 
return
ÉÉ 
$str
ÉÉ 
;
ÉÉ 
}
ÑÑ 	
public
ÜÜ 
JwTokenResponse
ÜÜ 

GetJwToken
ÜÜ )
(
ÜÜ) *%
ApplicationIdentityUser
ÜÜ* A
user
ÜÜB F
,
ÜÜF G
int
ÜÜH K
validityInHours
ÜÜL [
)
ÜÜ[ \
{
áá 	
var
àà 
	userRoles
àà 
=
àà 
_userManager
àà (
.
àà( )
GetRolesAsync
àà) 6
(
àà6 7
user
àà7 ;
)
àà; <
.
àà< =
Result
àà= C
.
ààC D
FirstOrDefault
ààD R
(
ààR S
)
ààS T
;
ààT U
var
ââ 
roleId
ââ 
=
ââ 
_userDbContext
ââ '
.
ââ' (
roles
ââ( -
.
ää' (
Where
ää( -
(
ää- .
r
ää. /
=>
ää0 2
r
ää3 4
.
ää4 5
Name
ää5 9
==
ää: <
	userRoles
ää= F
!
ääF G
)
ääG H
.
ãã' (
Select
ãã( .
(
ãã. /
r
ãã/ 0
=>
ãã1 3
r
ãã4 5
.
ãã5 6
Id
ãã6 8
)
ãã8 9
.
åå' (
FirstOrDefault
åå( 6
(
åå6 7
)
åå7 8
;
åå8 9
var
éé 
claims
éé 
=
éé 
this
éé 
.
éé #
GetModulesPermissions
éé 3
(
éé3 4
roleId
éé4 :
!
éé: ;
)
éé; <
;
éé< =
var
êê 
	allClaims
êê 
=
êê 
new
êê 
List
êê  $
<
êê$ %
Claim
êê% *
>
êê* +
{
ëë 
new
íí 
Claim
íí !
(
íí! "

ClaimTypes
íí" ,
.
íí, -
NameIdentifier
íí- ;
,
íí; <
user
íí= A
.
ííA B
Id
ííB D
)
ííD E
,
ííE F
new
ìì 
Claim
ìì !
(
ìì! "

ClaimTypes
ìì" ,
.
ìì, -
Role
ìì- 1
,
ìì1 2
	userRoles
ìì3 <
!
ìì< =
)
ìì= >
,
ìì> ?
new
îî 
Claim
îî !
(
îî! "

ClaimTypes
îî" ,
.
îî, -
Email
îî- 2
,
îî2 3
user
îî4 8
.
îî8 9
Email
îî9 >
!
îî> ?
)
îî? @
,
îî@ A
new
ïï 
Claim
ïï !
(
ïï! "

ClaimTypes
ïï" ,
.
ïï, -
MobilePhone
ïï- 8
,
ïï8 9
user
ïï: >
.
ïï> ?
PhoneNumber
ïï? J
!
ïïJ K
)
ïïK L
}
ññ 
;
ññ 
foreach
òò 
(
òò 
var
òò 

permission
òò #
in
òò$ &
claims
òò' -
)
òò- .
{
ôô 
	allClaims
öö 
.
öö 
Add
öö 
(
öö 
new
öö !
Claim
öö" '
(
öö' (
$"
öö( *
$str
öö* 5
{
öö5 6

permission
öö6 @
.
öö@ A

ModuleName
ööA K
}
ööK L
$str
ööL M
{
ööM N

permission
ööN X
.
ööX Y
ModulePermission
ööY i
}
ööi j
"
ööj k
,
öök l

permission
ööm w
.
ööw x
ModulePermissionööx à
!ööà â
)ööâ ä
)ööä ã
;ööã å
}
õõ 
var
üü 
tokenHandler
üü 
=
üü 
new
üü "%
JwtSecurityTokenHandler
üü# :
(
üü: ;
)
üü; <
;
üü< =
var
†† 
key
†† 
=
†† 
Encoding
†† 
.
†† 
ASCII
†† $
.
††$ %
GetBytes
††% -
(
††- .
_configuration
††. <
[
††< =
$str
††= R
]
††R S
!
††S T
)
††T U
;
††U V
var
¢¢ 
tokenDescriptor
¢¢ 
=
¢¢  !
new
¢¢" %%
SecurityTokenDescriptor
¢¢& =
{
££ 
Subject
§§ 
=
§§ 
new
§§ 
ClaimsIdentity
§§ ,
(
§§, -
	allClaims
§§- 6
)
§§6 7
,
§§7 8
Expires
•• 
=
•• 
DateTime
•• "
.
••" #
UtcNow
••# )
.
••) *
AddHours
••* 2
(
••2 3
validityInHours
••3 B
)
••B C
,
••C D 
SigningCredentials
¶¶ "
=
¶¶# $
new
¶¶% ( 
SigningCredentials
¶¶) ;
(
¶¶; <
new
¶¶< ?"
SymmetricSecurityKey
¶¶@ T
(
¶¶T U
key
¶¶U X
)
¶¶X Y
,
¶¶Y Z 
SecurityAlgorithms
¶¶[ m
.
¶¶m n

HmacSha256
¶¶n x
)
¶¶x y
}
ßß 
;
ßß 
var
®® 
token
®® 
=
®® 
tokenHandler
®® $
.
®®$ %
CreateToken
®®% 0
(
®®0 1
tokenDescriptor
®®1 @
)
®®@ A
;
®®A B
var
©© 
tokenString
©© 
=
©© 
tokenHandler
©© *
.
©©* +

WriteToken
©©+ 5
(
©©5 6
token
©©6 ;
)
©©; <
;
©©< =
return
´´ 
new
´´ 
JwTokenResponse
´´ &
{
¨¨ 
Token
≠≠ 
=
≠≠ 
tokenString
≠≠ #
.
≠≠# $
ToString
≠≠$ ,
(
≠≠, -
)
≠≠- .
,
≠≠. /
	ExpiresAt
ÆÆ 
=
ÆÆ 
tokenDescriptor
ÆÆ +
.
ÆÆ+ ,
Expires
ÆÆ, 3
}
ØØ 
;
ØØ 
}
∞∞ 	
public
≤≤ 
RefreshToken
≤≤ 
GetJwRefreshToken
≤≤ -
(
≤≤- .
)
≤≤. /
{
≥≥ 	
var
¥¥ 
randomNumber
¥¥ 
=
¥¥ 
new
¥¥ "
byte
¥¥# '
[
¥¥' (
$num
¥¥( *
]
¥¥* +
;
¥¥+ ,
using
µµ 
(
µµ 
var
µµ 
rng
µµ 
=
µµ #
RandomNumberGenerator
µµ 2
.
µµ2 3
Create
µµ3 9
(
µµ9 :
)
µµ: ;
)
µµ; <
{
∂∂ 
rng
∑∑ 
.
∑∑ 
GetBytes
∑∑ 
(
∑∑ 
randomNumber
∑∑ )
)
∑∑) *
;
∑∑* +
return
∏∏ 
new
∏∏ 
RefreshToken
∏∏ '
{
ππ 
Token
∫∫ 
=
∫∫ 
Convert
∫∫ #
.
∫∫# $
ToBase64String
∫∫$ 2
(
∫∫2 3
randomNumber
∫∫3 ?
)
∫∫? @
,
∫∫@ A
Expires
ªª 
=
ªª 
DateTime
ªª &
.
ªª& '
UtcNow
ªª' -
.
ªª- .
AddDays
ªª. 5
(
ªª5 6
$num
ªª6 7
)
ªª7 8
,
ªª8 9
Created
ºº 
=
ºº 
DateTime
ºº &
.
ºº& '
UtcNow
ºº' -
}
ΩΩ 
;
ΩΩ 
}
ææ 
}
øø 	
public
¬¬ 
ClaimsPrincipal
¬¬ 6
(GetClaimsPrincipalFromExpiredBearerToken
¬¬ G
(
¬¬G H
string
¬¬H N
bearerToken
¬¬O Z
)
¬¬Z [
{
√√ 	
var
ƒƒ 
key
ƒƒ 
=
ƒƒ 
Encoding
ƒƒ 
.
ƒƒ 
ASCII
ƒƒ $
.
ƒƒ$ %
GetBytes
ƒƒ% -
(
ƒƒ- .
_configuration
ƒƒ. <
[
ƒƒ< =
$str
ƒƒ= R
]
ƒƒR S
!
ƒƒS T
)
ƒƒT U
;
ƒƒU V
var
≈≈ '
tokenValidationParameters
≈≈ )
=
≈≈* +
new
≈≈, /'
TokenValidationParameters
≈≈0 I
{
∆∆ 
ValidateIssuer
«« 
=
««  
false
««! &
,
««& '
ValidateAudience
»»  
=
»»! "
false
»»# (
,
»»( )
ValidateLifetime
……  
=
……! "
false
……# (
,
……( )&
ValidateIssuerSigningKey
   (
=
  ) *
true
  + /
,
  / 0
IssuerSigningKey
ÀÀ  
=
ÀÀ! "
new
ÀÀ# &"
SymmetricSecurityKey
ÀÀ' ;
(
ÀÀ; <
key
ÀÀ< ?
)
ÀÀ? @
,
ÀÀ@ A
	ClockSkew
ÃÃ 
=
ÃÃ 
TimeSpan
ÃÃ $
.
ÃÃ$ %
Zero
ÃÃ% )
}
ÕÕ 
;
ÕÕ 
var
œœ 
tokenHandler
œœ 
=
œœ 
new
œœ "%
JwtSecurityTokenHandler
œœ# :
(
œœ: ;
)
œœ; <
;
œœ< =
var
–– 
	principal
–– 
=
–– 
tokenHandler
–– (
.
––( )
ValidateToken
––) 6
(
––6 7
bearerToken
––7 B
,
––B C'
tokenValidationParameters
––D ]
,
––] ^
out
––_ b
SecurityToken
––c p
securityToken
––q ~
)
––~ 
;–– Ä
JwtSecurityToken
—— 
?
—— 
jwtSecurityToken
—— .
=
——/ 0
securityToken
——1 >
as
——? A
JwtSecurityToken
——B R
;
——R S
if
““ 
(
““ 
jwtSecurityToken
““  
==
““! #
null
““$ (
||
““) +
!
““, -
jwtSecurityToken
““- =
.
““= >
Header
““> D
.
““D E
Alg
““E H
.
““H I
Equals
““I O
(
““O P 
SecurityAlgorithms
““P b
.
““b c

HmacSha256
““c m
,
““m n
StringComparison
““o 
.““ Ä*
InvariantCultureIgnoreCase““Ä ö
)““ö õ
)““õ ú
{
”” 
throw
‘‘ 
new
‘‘ $
SecurityTokenException
‘‘ 0
(
‘‘0 1
$str
‘‘1 @
)
‘‘@ A
;
‘‘A B
}
’’ 
return
◊◊ 
	principal
◊◊ 
;
◊◊ 
}
ÿÿ 	
private
⁄⁄ 
IEnumerable
⁄⁄ 
<
⁄⁄ '
RoleModulesPermissionsDto
⁄⁄ 5
>
⁄⁄5 6#
GetModulesPermissions
⁄⁄7 L
(
⁄⁄L M
string
⁄⁄M S
roleId
⁄⁄T Z
)
⁄⁄Z [
{
€€ 	
var
›› 
modulePermissions
›› !
=
››" #
(
››$ %
from
››% )
a
››* +
in
››, .
_userDbContext
››/ =
.
››= >+
ApplicationModulesPermissions
››> [
join
ﬁﬁ% )
b
ﬁﬁ* +
in
ﬁﬁ, .
_userDbContext
ﬁﬁ/ =
.
ﬁﬁ= > 
ApplicationModules
ﬁﬁ> P
on
ﬂﬂ) +
a
ﬂﬂ, -
.
ﬂﬂ- .
ModuleId
ﬂﬂ. 6
equals
ﬂﬂ7 =
b
ﬂﬂ> ?
.
ﬂﬂ? @
ModuleId
ﬂﬂ@ H
into
ﬂﬂI M
modules
ﬂﬂN U
from
‡‡% )
module
‡‡* 0
in
‡‡1 3
modules
‡‡4 ;
.
‡‡; <
DefaultIfEmpty
‡‡< J
(
‡‡J K
)
‡‡K L
join
··% )
c
··* +
in
··, .
_userDbContext
··/ =
.
··= >
Roles
··> C
on
‚‚) +
a
‚‚, -
.
‚‚- .
RoleId
‚‚. 4
equals
‚‚5 ;
c
‚‚< =
.
‚‚= >
Id
‚‚> @
into
‚‚A E
roles
‚‚F K
from
„„% )
role
„„* .
in
„„/ 1
roles
„„2 7
.
„„7 8
DefaultIfEmpty
„„8 F
(
„„F G
)
„„G H
where
‰‰% *
a
‰‰+ ,
.
‰‰, -
RoleId
‰‰- 3
==
‰‰4 6
roleId
‰‰7 =
select
ÂÂ% +
new
ÂÂ, /'
RoleModulesPermissionsDto
ÂÂ0 I
{
ÊÊ% & 
ModulePermissionId
ÁÁ) ;
=
ÁÁ< =
a
ÁÁ> ?
.
ÁÁ? @ 
ModulePermissionId
ÁÁ@ R
,
ÁÁR S
RoleId
ËË) /
=
ËË0 1
a
ËË2 3
.
ËË3 4
RoleId
ËË4 :
,
ËË: ;
RoleName
ÈÈ) 1
=
ÈÈ2 3
role
ÈÈ4 8
!=
ÈÈ9 ;
null
ÈÈ< @
?
ÈÈA B
role
ÈÈC G
.
ÈÈG H
Name
ÈÈH L
:
ÈÈM N
$str
ÈÈO X
,
ÈÈX Y
ModuleId
ÍÍ) 1
=
ÍÍ2 3
a
ÍÍ4 5
.
ÍÍ5 6
ModuleId
ÍÍ6 >
,
ÍÍ> ?

ModuleName
ÎÎ) 3
=
ÎÎ4 5
module
ÎÎ6 <
!=
ÎÎ= ?
null
ÎÎ@ D
?
ÎÎE F
module
ÎÎG M
.
ÎÎM N

ModuleName
ÎÎN X
:
ÎÎY Z
$str
ÎÎ[ f
,
ÎÎf g
ModulePermission
ÏÏ) 9
=
ÏÏ: ;
a
ÏÏ< =
.
ÏÏ= >
ModulePermission
ÏÏ> N
}
ÌÌ% &
)
ÌÌ& '
.
ÌÌ' (
ToList
ÌÌ( .
(
ÌÌ. /
)
ÌÌ/ 0
;
ÌÌ0 1
return
ÔÔ 
modulePermissions
ÔÔ $
;
ÔÔ$ %
}
ÒÒ 	
}
ÛÛ 
}ÙÙ ¶
ú/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/SubPermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Permissions= H
{ 
public 
class $
SubPermissionsRepository &
:& '

Repository( 2
<2 3
SubPermissions3 A
>A B
,B C%
ISubPermissionsRepositoryD ]
{ 
public $
SubPermissionsRepository	 !
(! "
UserDbContext" /
	dbContext0 9
)9 :
:; <
base= A
(A B
	dbContextB K
)K L
{ 
} 
}		 
}

 ø
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/SubPermissionsItemsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Permissions= H
{ 
public 
class )
SubPermissionsItemsRepository +
:+ ,

Repository- 7
<7 8
SubPermissionsItems8 K
>K L
,L M*
ISubPermissionsItemsRepositoryN l
{ 
public )
SubPermissionsItemsRepository	 &
(& '
UserDbContext' 4
	dbContext5 >
)> ?
:@ A
baseB F
(F G
	dbContextG P
)P Q
{ 
} 
}		 
}

 ù
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/PermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Permissions= H
{ 
public 
class !
PermissionsRepository #
:# $

Repository% /
</ 0
AccessPermissions0 A
>A B
,B C"
IPermissionsRepositoryD Z
{ 
public !
PermissionsRepository	 
( 
UserDbContext ,
	dbContext- 6
)6 7
:8 9
base: >
(> ?
	dbContext? H
)H I
{		 	
}

 
} 
} ˙
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/SubMenusRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Menu= A
{ 
public 

class 
SubMenusRepository #
:$ %

Repository& 0
<0 1
SubMenus1 9
>9 :
,: ;
ISubMenusRepository< O
{		 
public

 
SubMenusRepository

	 
(

 
UserDbContext

 )
	dbContext

* 3
)

3 4
:

5 6
base

7 ;
(

; <
	dbContext

< E
)

E F
{ 	
} 
} 
} é
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/SubMenuItemsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Menu= A
{ 
public 

class "
SubMenuItemsRepository '
:( )

Repository* 4
<4 5
SubMenuItems5 A
>A B
,B C#
ISubMenuItemsRepositoryD [
{		 
public

 "
SubMenuItemsRepository

	 
(

  
UserDbContext

  -
	dbContext

. 7
)

7 8
:

9 :
base

; ?
(

? @
	dbContext

@ I
)

I J
{ 	
} 
} 
} Î
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/MenusRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Menu= A
{ 
public 
class 
MenusRepository 
: 

Repository  *
<* +
Menus+ 0
>0 1
,1 2
IMenusRepository3 C
{ 
public		 
MenusRepository			 
(		 
UserDbContext		 &
	dbContext		' 0
)		0 1
:		2 3
base		4 8
(		8 9
	dbContext		9 B
)		B C
{

 
} 
} 
} ï
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/MenuActionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
.< =
Menu= A
{ 
} Ü
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/IdentificationTypeRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 

class (
IdentificationTypeRepository -
:. /

Repository0 :
<: ;
IdentificationType; M
>M N
,N O)
IIdentificationTypeRepositoryP m
{ 
public (
IdentificationTypeRepository +
(+ ,
UserDbContext, 9
	dbContext: C
)C D
:E F
baseG K
(K L
	dbContextL U
)U V
{ 	
} 	
}		 
}

 Ú
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/DepartmentUnitRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class $
DepartmentUnitRepository &
:' (

Repository) 3
<3 4
DepartmentUnit4 B
>B C
,C D%
IDepartmentUnitRepositoryE ^
{ 
public $
DepartmentUnitRepository	 !
(! "
UserDbContext" /
	dbContext0 9
)9 :
:; <
base= A
(A B
	dbContextB K
)K L
{		 
}

 
} 
} ﬁ
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/DepartmentRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class  
DepartmentRepository "
:# $

Repository% /
</ 0

Department0 :
>: ;
,; <!
IDepartmentRepository= R
{ 
public  
DepartmentRepository	 
( 
UserDbContext +
	dbContext, 5
)5 6
:7 8
base9 =
(= >
	dbContext> G
)G H
{		 
}

 
} 
} ‘
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ChannelsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class 
ChannelsRepository  
:! "

Repository# -
<- .
Channels. 6
>6 7
,7 8
IChannelsRepository9 L
{ 
public 
ChannelsRepository	 
( 
UserDbContext )
	dbContext* 3
)3 4
:5 6
base7 ;
(; <
	dbContext< E
)E F
{ 	
} 
}		 
}

 Ü
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ApplicationModulesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class (
ApplicationModulesRepository *
:+ ,

Repository- 7
<7 8
ApplicationModules8 J
>J K
,K L)
IApplicationModulesRepositoryM j
{ 
public (
ApplicationModulesRepository	 %
(% &
UserDbContext& 3
	dbContext4 =
)= >
:? @
baseA E
(E F
	dbContextF O
)O P
{ 	
} 
}		 
}

 æ
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ApplicationModulesPermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Repositories' 3
.3 4
Entities4 <
{ 
public 
class 3
'ApplicationModulesPermissionsRepository 5
:6 7

Repository8 B
<B C)
ApplicationModulesPermissionsC `
>` a
,a b5
(IApplicationModulesPermissionsRepository	c ã
{ 
public 3
'ApplicationModulesPermissionsRepository	 0
(0 1
UserDbContext1 >
	dbContext? H
)H I
:J K
baseL P
(P Q
	dbContextQ Z
)Z [
{ 	
} 
}		 
}

 ∆	
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Extensions/ServiceCollectionExtensions.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '

Extensions' 1
{ 
public 

static 
class '
ServiceCollectionExtensions 3
{		 
public

 
static

 
IServiceCollection

 (!
AddUserInfrastructure

) >
(

> ?
this

? C
IServiceCollection

D V
services

W _
,

_ `
IConfiguration

a o
config

p v
)

v w
{ 	
services 
. 
AddDbContext 
< 
UserDbContext +
>+ ,
(, -
options- 4
=>5 7
options8 ?
.? @
UseSqlServer@ L
(L M
configM S
.S T
GetConnectionStringT g
(g h
$strh y
)y z
)z {
){ |
;| }
return 
services 
; 
} 	
} 
} ∫I
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/UserAndRolesConfiguration.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Configuration' 4
{ 
public 
static 
class %
UserAndRolesConfiguration .
{		 
public

 
static

 
async

 
Task

  
SeedUserAndRoles

! 1
(

1 2
IServiceProvider

2 B
_serviceProvider

C S
)

S T
{ 	
using 
var 
scope 
= 
_serviceProvider .
.. /
CreateScope/ :
(: ;
); <
;< =
var 
	dbContext 
= 
scope !
.! "
ServiceProvider" 1
.1 2
GetRequiredService2 D
<D E
UserDbContextE R
>R S
(S T
)T U
;U V
var 
userManager 
= 
scope #
.# $
ServiceProvider$ 3
.3 4
GetRequiredService4 F
<F G
UserManagerG R
<R S#
ApplicationIdentityUserS j
>j k
>k l
(l m
)m n
;n o
var 
roleManager 
= 
scope #
.# $
ServiceProvider$ 3
.3 4
GetRequiredService4 F
<F G
RoleManagerG R
<R S#
ApplicationIdentityRoleS j
>j k
>k l
(l m
)m n
;n o
if 
( 
! 
await 
	dbContext  
.  !
Database! )
.) *
CanConnectAsync* 9
(9 :
): ;
); <
{ 
await 
	dbContext 
.  
Database  (
.( )
MigrateAsync) 5
(5 6
)6 7
;7 8
} 
if 
( 
! 
roleManager 
. 
RoleExistsAsync ,
(, -
$str- <
)< =
.= >
Result> D
)D E
{ 
await 
roleManager !
.! "
CreateAsync" -
(- .
new. 1#
ApplicationIdentityRole2 I
{ 
Name   
=   
$str   *
,  * +
NormalizedName!! "
=!!# $
$str!!% 4
,!!4 5

ApprovedBy"" 
=""  
$str""! &
,""& '

ApprovedOn## 
=##  
DateTime##! )
.##) *
UtcNow##* 0
,##0 1
	CreatedBy$$ 
=$$ 
$str$$  %
,$$% &
	CreatedOn%% 
=%% 
DateTime%%  (
.%%( )
UtcNow%%) /
,%%/ 0
Status&& 
=&& 
$num&& 
}'' 
)'' 
;'' 
await)) 
roleManager)) !
.))! "
CreateAsync))" -
())- .
new)). 1#
ApplicationIdentityRole))2 I
{** 
Name++ 
=++ 
$str++ -
,++- .
NormalizedName,, "
=,,# $
$str,,% 7
,,,7 8

ApprovedBy-- 
=--  
$str--! &
,--& '

ApprovedOn.. 
=..  
DateTime..! )
...) *
UtcNow..* 0
,..0 1
	CreatedBy// 
=// 
$str//  %
,//% &
	CreatedOn00 
=00 
DateTime00  (
.00( )
UtcNow00) /
,00/ 0
Status11 
=11 
$num11 
}22 
)22 
;22 
}33 
var55 
_email55 
=55 
$str55 -
;55- .
var66 
misadmin_email66 
=66  
$str66! 9
;669 :
if88 
(88 
userManager88 
.88 
FindByEmailAsync88 ,
(88, -
_email88- 3
)883 4
.884 5
Result885 ;
==88< >
null88? C
)88C D
{99 
var;; 
_user;; 
=;; 
new;; #
ApplicationIdentityUser;;  7
{<< 
Id== 
=== 
$str== ?
,==? @ 
IdentificationNumber>> (
=>>) *
$str>>+ 1
,>>1 2
	FirstName?? 
=?? 
$str??  (
,??( )

MiddleName@@ 
=@@  
$str@@! #
,@@# $
LastNameAA 
=AA 
$strAA .
,AA. /
DepartmentIdBB  
=BB! "
$numBB# $
,BB$ %
UnitIdCC 
=CC 
$numCC 
,CC 
	ChannelIdDD 
=DD 
$numDD  #
,DD# $
StatusEE 
=EE 
$numEE 
,EE 
	CreatedByFF 
=FF 
$strFF  %
,FF% &
CreatedDateGG 
=GG  !
DateTimeGG" *
.GG* +
UtcNowGG+ 1
,GG1 2
UserNameHH 
=HH 
_emailHH %
,HH% &
NormalizedUserNameII &
=II' (
_emailII) /
.II/ 0
ToUpperII0 7
(II7 8
)II8 9
,II9 :
EmailJJ 
=JJ 
_emailJJ "
,JJ" #
NormalizedEmailKK #
=KK$ %
_emailKK& ,
.KK, -
ToUpperKK- 4
(KK4 5
)KK5 6
,KK6 7
PhoneNumberLL 
=LL  !
$strLL" .
,LL. /
EmailConfirmedMM "
=MM# $
trueMM% )
,MM) *

FirebaseIdNN 
=NN  
stringNN! '
.NN' (
EmptyNN( -
,NN- .
RegistrationDateOO $
=OO% &
DateTimeOO' /
.OO/ 0
UtcNowOO0 6
,OO6 7
IsFirstTimePP 
=PP  !
falsePP" '
,PP' (
UserTypeQQ 
=QQ 
$numQQ  
}RR 
;RR 
varVV 
_misUserVV 
=VV 
newVV "#
ApplicationIdentityUserVV# :
{WW 
IdXX 
=XX 
$strXX ?
,XX? @ 
IdentificationNumberYY (
=YY) *
$strYY+ 3
,YY3 4
	FirstNameZZ 
=ZZ 
$strZZ  (
,ZZ( )

MiddleName[[ 
=[[  
$str[[  "
,[[" #
LastName\\ 
=\\ 
$str\\ *
,\\* +
DepartmentId]]  
=]]! "
$num]]# &
,]]& '
UnitId^^ 
=^^ 
$num^^  
,^^  !
	ChannelId__ 
=__ 
$num__  #
,__# $
Status`` 
=`` 
$num`` 
,`` 
	CreatedByaa 
=aa 
$straa  %
,aa% &
CreatedDatebb 
=bb  !
DateTimebb" *
.bb* +
UtcNowbb+ 1
,bb1 2
UserNamecc 
=cc 
misadmin_emailcc -
,cc- .
NormalizedUserNamedd &
=dd' (
misadmin_emaildd) 7
.dd7 8
ToUpperdd8 ?
(dd? @
)dd@ A
,ddA B
Emailee 
=ee 
misadmin_emailee *
,ee* +
NormalizedEmailff #
=ff$ %
misadmin_emailff& 4
.ff4 5
ToUpperff5 <
(ff< =
)ff= >
,ff> ?
PhoneNumbergg 
=gg  !
$strgg" .
,gg. /
EmailConfirmedhh "
=hh# $
truehh% )
,hh) *

FirebaseIdii 
=ii  
stringii! '
.ii' (
Emptyii( -
,ii- .
RegistrationDatejj $
=jj% &
DateTimejj' /
.jj/ 0
UtcNowjj0 6
,jj6 7
IsFirstTimekk 
=kk  !
falsekk" '
,kk' (
UserTypell 
=ll 
$numll  
}mm 
;mm 
IdentityResultoo 
identityResultoo -
=oo. /
userManageroo0 ;
.oo; <
CreateAsyncoo< G
(ooG H
_userooH M
,ooM N
$strooO _
)oo_ `
.oo` a
Resultooa g
;oog h
ifpp 
(pp 
identityResultpp "
.pp" #
	Succeededpp# ,
)pp, -
awaitqq 
userManagerqq %
.qq% &
AddToRoleAsyncqq& 4
(qq4 5
_userqq5 :
,qq: ;
$strqq< K
)qqK L
;qqL M
identityResultss 
=ss  
userManagerss! ,
.ss, -
CreateAsyncss- 8
(ss8 9
_misUserss9 A
,ssA B
$strssC S
)ssS T
.ssT U
ResultssU [
;ss[ \
iftt 
(tt 
identityResulttt "
.tt" #
	Succeededtt# ,
)tt, -
awaituu 
userManageruu %
.uu% &
AddToRoleAsyncuu& 4
(uu4 5
_misUseruu5 =
,uu= >
$struu? Q
)uuQ R
;uuR S
}ww 
}zz 	
}{{ 
}|| ≈
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/MenuActionConfiguration.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Configuration' 4
{ 
} ˜
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/DepartmentsAndUnitsConfiguration.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Configuration' 4
{ 
public 
class $
DepartmentsConfiguration &
:' ($
IEntityTypeConfiguration) A
<A B

DepartmentB L
>L M
{		 
public

 
void

 
	Configure

 
(

 
EntityTypeBuilder

 /
<

/ 0

Department

0 :
>

: ;
builder

< C
)

C D
{ 	
builder 
. 
HasIndex 
( 
d 
=> !
d" #
.# $
DepartmentName$ 2
)2 3
;3 4
builder 
. 
HasData 
( 
new 

Department 
( 
$num "
," #
$str# ,
), -
,- .
new 

Department 
( 
$num "
," #
$str# ,
), -
) 
; 
} 	
} 
public 

class )
DepartmentsUnitsConfiguration .
:/ 0$
IEntityTypeConfiguration1 I
<I J
DepartmentUnitJ X
>X Y
{ 
public 
void 
	Configure 
( 
EntityTypeBuilder /
</ 0
DepartmentUnit0 >
>> ?
builder@ G
)G H
{ 	
builder 
. 
HasIndex 
( 
u 
=> !
u" #
.# $
UnitName$ ,
), -
;- .
builder 
. 
HasData 
( 
new 
DepartmentUnit "
(" #
$num# &
,& '
$num' *
,* +
$str+ 2
)2 3
,3 4
new 
DepartmentUnit "
(" #
$num# &
,& '
$num' *
,* +
$str+ 4
)4 5
,5 6
new 
DepartmentUnit "
(" #
$num# &
,& '
$num' *
,* +
$str+ 6
)6 7
,7 8
new!! 
DepartmentUnit!! "
(!!" #
$num!!# &
,!!& '
$num!!' *
,!!* +
$str!!+ 7
)!!7 8
,!!8 9
new"" 
DepartmentUnit"" "
(""" #
$num""# &
,""& '
$num""' *
,""* +
$str"", 5
)""5 6
,""6 7
new## 
DepartmentUnit## "
(##" #
$num### &
,##& '
$num##' *
,##* +
$str##, 3
)##3 4
,##4 5
new$$ 
DepartmentUnit$$ "
($$" #
$num$$# &
,$$& '
$num$$' *
,$$* +
$str$$, 4
)$$4 5
,$$5 6
new%% 
DepartmentUnit%% "
(%%" #
$num%%# &
,%%& '
$num%%' *
,%%* +
$str%%, 3
)%%3 4
)'' 
;'' 
}(( 	
})) 
}** ï

Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/ChannelConfiguration.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '
Configuration' 4
{ 
public 
class  
ChannelConfiguration "
:# $$
IEntityTypeConfiguration% =
<= >
Channels> F
>F G
{		 
public

 
void

 
	Configure

 
(

 
EntityTypeBuilder

 /
<

/ 0
Channels

0 8
>

8 9
builder

: A
)

A B
{ 	
builder 
. 
HasIndex 
( 
c 
=> !
c" #
.# $
ChannelName$ /
)/ 0
;0 1
builder 
. 
HasData 
( 
new 
Channels 
( 
$num  
,  !
$str" '
)' (
,( )
new 
Channels 
( 
$num  
,  !
$str" *
)* +
) 
; 
} 	
} 
} 