j
h/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Usings.csц_
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
string	| ‚
>
‚ ѓ
,
ѓ „)
ApplicationIdentityUserRole
…  
,
  Ў
IdentityUserLogin
ў і
<
і ґ
string
ґ є
>
є »
,
» ј
IdentityRoleClaim
Ѕ О
<
О П
string
П Х
>
Х Ц
,
Ц Ч
IdentityUserToken
Ш й
<
й к
string
к р
>
р с
>
с т
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
}nn Б
ѓ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/UsersRolesRepository.cs
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
 ¤
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
 шH
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
configuration	u ‚
,
‚ ѓ

HttpClient
„ Ћ

httpClient
Џ ™
)
™ љ
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
}pp ї
†/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/StaffAccountsRepository.cs
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
 Ё
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
 ю@
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
IOrderedQueryable	&& ђ
<
&&ђ ‘
TEntity
&&‘ 
>
&& ™
>
&&™ љ
?
&&љ ›
orderBy
&&њ Ј
=
&&¤ Ґ
null
&&¦ Є
,
&&Є «
List
&&¬ °
<
&&° ±
string
&&± ·
>
&&· ё
?
&&ё №
includes
&&є В
=
&&Г Д
null
&&Е Й
)
&&Й К
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
;	== Ђ
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
}DD ‰Ў
Њ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/TokenStoreRepository.cs
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
configuration	## Њ
,
##Њ Ќ

HttpClient
##Ћ 

httpClient
##™ Ј
)
##Ј ¤
:
##Ґ ¦
base
##§ «
(
##« ¬
	dbContext
##¬ µ
)
##µ ¶
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
$str	>> №
"
>>№ є
)
>>є »
;
>>» ј
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
$str	BB ‹
"
BB‹ Њ
)
BBЊ Ќ
;
BBЌ Ћ
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
$str	DD ‚
"
DD‚ ѓ
)
DDѓ „
;
DD„ …
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
OOЂ Ѓ
sb
OO‚ „
.
OO„ …
ToString
OO… Ќ
(
OOЌ Ћ
)
OOЋ Џ
,
OOЏ ђ
type
OO‘ •
=
OO– —
$num
OO ™
}
OOљ ›
;
OO› њ
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
$str	PP Ћ
{
PPЋ Џ
token
PPЏ ”
}
PP” •
$str
PP• У
"
PPУ Ф
,
PPХ Ц
type
PPЧ Ы
=
PPЬ Э
$num
PPЮ Я
}
PPа б
;
PPб в
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
$str	UUK њ
,
UUњ ќ
sms_httpContent
UUћ ­
)
UU­ ®
;
UU® Ї
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
$str	ZZG 
,
ZZ ™
email_httpContent
ZZљ «
)
ZZ« ¬
;
ZZ¬ ­
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
ЂЂ 
$str
ЂЂ N
;
ЂЂN O
}
ЃЃ 

TokenStore
„„ 

tokenStore
„„ !
=
„„" #
new
„„$ '

TokenStore
„„( 2
(
„„2 3
)
„„3 4
{
…… 
TokenStoreId
†† 
=
†† 
$num
††  
,
††  !
EmailAddress
‡‡ 
=
‡‡ 
emailAddress
‡‡ +
,
‡‡+ ,
MobilePhoneNumber
€€ !
=
€€" #
mobilePhoneNumber
€€$ 5
,
€€5 6
Token
‰‰ 
=
‰‰ 
token
‰‰ 
,
‰‰ 
CreatedDate
ЉЉ 
=
ЉЉ 
DateTime
ЉЉ &
.
ЉЉ& '
Now
ЉЉ' *
,
ЉЉ* +

ExpiryDate
‹‹ 
=
‹‹ 
DateTime
‹‹ %
.
‹‹% &
Now
‹‹& )
.
‹‹) *

AddMinutes
‹‹* 4
(
‹‹4 5
ExpiryMinutes
‹‹5 B
)
‹‹B C
,
‹‹C D

IsVerified
ЊЊ 
=
ЊЊ 
false
ЊЊ "
}
ЌЌ 
;
ЌЌ 
_userDbContext
ЏЏ 
.
ЏЏ 

TokenStore
ЏЏ %
.
ЏЏ% &
Add
ЏЏ& )
(
ЏЏ) *

tokenStore
ЏЏ* 4
)
ЏЏ4 5
;
ЏЏ5 6
await
ђђ 
_userDbContext
ђђ  
.
ђђ  !
SaveChangesAsync
ђђ! 1
(
ђђ1 2
)
ђђ2 3
;
ђђ3 4
await
’’ 
this
’’ 
.
’’ &
SendTokenViaNotification
’’ /
(
’’/ 0/
!mobilePhoneNumber_OR_emailAddress
’’0 Q
,
’’Q R
token
’’S X
)
’’X Y
;
’’Y Z
return
”” 
token
”” 
;
”” 
}
•• 	
public
—— 
async
—— 
Task
—— 
<
—— 
string
——  
>
——  !
VerifyToken
——" -
(
——- .
string
——. 4/
!mobilePhoneNumber_OR_emailAddress
——5 V
,
——V W
string
——X ^
	tokenCode
——_ h
)
——h i
{
 	
try
™™ 
{
љљ 
if
›› 
(
›› 
string
›› 
.
››  
IsNullOrWhiteSpace
›› -
(
››- ./
!mobilePhoneNumber_OR_emailAddress
››. O
)
››O P
is
››Q S
true
››T X
&&
››Y [
string
››\ b
.
››b c 
IsNullOrWhiteSpace
››c u
(
››u v
	tokenCode
››v 
)›› Ђ
is››Ѓ ѓ
true››„ €
)››€ ‰
{
њњ 
return
ќќ 
$str
ќќ R
;
ќќR S
}
ћћ 
if
   
(
   

emailRegex
   
.
   
IsMatch
   &
(
  & '/
!mobilePhoneNumber_OR_emailAddress
  ' H
)
  H I
)
  I J
{
ЎЎ 
emailAddress
ўў  
=
ўў! "/
!mobilePhoneNumber_OR_emailAddress
ўў# D
;
ўўD E
}
ЈЈ 
if
ҐҐ 
(
ҐҐ 
emailAddress
ҐҐ  
==
ҐҐ! #
string
ҐҐ$ *
.
ҐҐ* +
Empty
ҐҐ+ 0
&&
ҐҐ1 3
!
ҐҐ4 5

phoneRegex
ҐҐ5 ?
.
ҐҐ? @
IsMatch
ҐҐ@ G
(
ҐҐG H/
!mobilePhoneNumber_OR_emailAddress
ҐҐH i
)
ҐҐi j
)
ҐҐj k
{
¦¦ 
return
§§ 
$str
§§ A
;
§§A B
}
ЁЁ 
if
ЄЄ 
(
ЄЄ 

phoneRegex
ЄЄ 
.
ЄЄ 
IsMatch
ЄЄ &
(
ЄЄ& '/
!mobilePhoneNumber_OR_emailAddress
ЄЄ' H
)
ЄЄH I
)
ЄЄI J
{
«« 
mobilePhoneNumber
¬¬ %
=
¬¬& '/
!mobilePhoneNumber_OR_emailAddress
¬¬( I
;
¬¬I J
}
­­ 
if
ЇЇ 
(
ЇЇ 
emailAddress
ЇЇ  
==
ЇЇ! #
string
ЇЇ$ *
.
ЇЇ* +
Empty
ЇЇ+ 0
&&
ЇЇ1 3
mobilePhoneNumber
ЇЇ4 E
==
ЇЇF H
string
ЇЇI O
.
ЇЇO P
Empty
ЇЇP U
)
ЇЇU V
{
°° 
return
±± 
$str
±± R
;
±±R S
}
ІІ 
var
ґґ 

checkToken
ґґ 
=
ґґ  
_userDbContext
ґґ! /
.
ґґ/ 0

TokenStore
ґґ0 :
.
ґґ: ;
SingleOrDefault
ґґ; J
(
ґґJ K
t
ґґK L
=>
ґґM O
t
ґґP Q
.
ґґQ R
Token
ґґR W
==
ґґX Z
	tokenCode
ґґ[ d
)
ґґd e
;
ґґe f
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
¶¶ 
return
·· 
$str
·· G
;
··G H
}
ёё 
var
»» 
checkTokenExpiry
»» $
=
»»% &
_userDbContext
»»' 5
.
»»5 6

TokenStore
»»6 @
.
»»@ A
SingleOrDefault
»»A P
(
»»P Q
t
»»Q R
=>
»»S U
t
»»V W
.
»»W X
Token
»»X ]
==
»»^ `
	tokenCode
»»a j
&&
»»k m
t
»»n o
.
»»o p

ExpiryDate
»»p z
<=
»»{ }
DateTime»»~ †
.»»† ‡
UtcNow»»‡ Ќ
)»»Ќ Ћ
;»»Ћ Џ
if
јј 
(
јј 
checkTokenExpiry
јј $
is
јј% '
not
јј( +
null
јј, 0
)
јј0 1
{
ЅЅ 
return
ѕѕ 
$str
ѕѕ ^
;
ѕѕ^ _
}
її 
var
ББ 
checkVerified
ББ !
=
ББ" #
_userDbContext
ББ$ 2
.
ББ2 3

TokenStore
ББ3 =
.
ББ= >
SingleOrDefault
ББ> M
(
ББM N
t
ББN O
=>
ББP R
t
ББS T
.
ББT U
Token
ББU Z
==
ББ[ ]
	tokenCode
ББ^ g
&&
ББh j
t
ББk l
.
ББl m

IsVerified
ББm w
==
ББx z
true
ББ{ 
)ББ Ђ
;ББЂ Ѓ
if
ВВ 
(
ВВ 
checkVerified
ВВ !
is
ВВ" $
not
ВВ% (
null
ВВ) -
)
ВВ- .
{
ГГ 
return
ДД 
$str
ДД h
;
ДДh i
}
ЕЕ 
var
ИИ 
result
ИИ 
=
ИИ 
_userDbContext
ИИ +
.
ИИ+ ,

TokenStore
ИИ, 6
.
ИИ6 7
FirstOrDefault
ИИ7 E
(
ИИE F
t
ИИF G
=>
ИИH J
t
ИИK L
.
ИИL M
Token
ИИM R
==
ИИS U
	tokenCode
ИИV _
&&
ИИ` b
t
ИИc d
.
ИИd e

IsVerified
ИИe o
==
ИИp r
false
ИИs x
&&
ИИy {
t
ИИ| }
.
ИИ} ~ 
MobilePhoneNumberИИ~ Џ
==ИИђ ’1
!mobilePhoneNumber_OR_emailAddressИИ“ ґ
||ИИµ ·
tИИё №
.ИИ№ є
EmailAddressИИє Ж
==ИИЗ Й1
!mobilePhoneNumber_OR_emailAddressИИК л
)ИИл м
;ИИм н
if
ЙЙ 
(
ЙЙ 
result
ЙЙ 
is
ЙЙ 
null
ЙЙ "
)
ЙЙ" #
{
КК 
return
ЛЛ 
$str
ЛЛ )
;
ЛЛ) *
}
ММ 
result
ОО 
!
ОО 
.
ОО 

IsVerified
ОО "
=
ОО# $
true
ОО% )
;
ОО) *
result
ПП 
.
ПП 
VerifiedDate
ПП #
=
ПП$ %
DateTime
ПП& .
.
ПП. /
UtcNow
ПП/ 5
;
ПП5 6
_userDbContext
СС 
.
СС 

TokenStore
СС )
.
СС) *
Update
СС* 0
(
СС0 1
result
СС1 7
)
СС7 8
;
СС8 9
await
ТТ 
_userDbContext
ТТ $
.
ТТ$ %
SaveChangesAsync
ТТ% 5
(
ТТ5 6
)
ТТ6 7
;
ТТ7 8
return
ФФ 
$str
ФФ !
;
ФФ! "
}
ХХ 
catch
ЦЦ 
(
ЦЦ 
	Exception
ЦЦ 
ex
ЦЦ 
)
ЦЦ  
{
ЧЧ 
return
ШШ 
$"
ШШ 
$str
ШШ 
{
ШШ  
ex
ШШ  "
.
ШШ" #
InnerException
ШШ# 1
!
ШШ1 2
.
ШШ2 3
Message
ШШ3 :
}
ШШ: ;
"
ШШ; <
;
ШШ< =
}
ЩЩ 
}
ЪЪ 	
public
ЬЬ 
string
ЬЬ 
VerifyTokenExpiry
ЬЬ '
(
ЬЬ' (
string
ЬЬ( ./
!mobilePhoneNumber_OR_emailAddress
ЬЬ/ P
,
ЬЬP Q
string
ЬЬR X
	tokenCode
ЬЬY b
)
ЬЬb c
{
ЭЭ 	
if
ЮЮ 
(
ЮЮ 
string
ЮЮ 
.
ЮЮ  
IsNullOrWhiteSpace
ЮЮ )
(
ЮЮ) */
!mobilePhoneNumber_OR_emailAddress
ЮЮ* K
)
ЮЮK L
is
ЮЮM O
true
ЮЮP T
&&
ЮЮU W
string
ЮЮX ^
.
ЮЮ^ _ 
IsNullOrWhiteSpace
ЮЮ_ q
(
ЮЮq r
	tokenCode
ЮЮr {
)
ЮЮ{ |
is
ЮЮ} 
trueЮЮЂ „
)ЮЮ„ …
{
ЯЯ 
return
аа 
$str
аа N
;
ааN O
}
бб 
if
гг 
(
гг 

emailRegex
гг 
.
гг 
IsMatch
гг "
(
гг" #/
!mobilePhoneNumber_OR_emailAddress
гг# D
)
ггD E
)
ггE F
{
дд 
emailAddress
ее 
=
ее /
!mobilePhoneNumber_OR_emailAddress
ее @
;
ее@ A
}
жж 
if
ии 
(
ии 
emailAddress
ии 
==
ии 
string
ии  &
.
ии& '
Empty
ии' ,
&&
ии- /
!
ии0 1

phoneRegex
ии1 ;
.
ии; <
IsMatch
ии< C
(
ииC D/
!mobilePhoneNumber_OR_emailAddress
ииD e
)
ииe f
)
ииf g
{
йй 
return
кк 
$str
кк =
;
кк= >
}
лл 
if
нн 
(
нн 

phoneRegex
нн 
.
нн 
IsMatch
нн "
(
нн" #/
!mobilePhoneNumber_OR_emailAddress
нн# D
)
ннD E
)
ннE F
{
оо 
mobilePhoneNumber
пп !
=
пп" #/
!mobilePhoneNumber_OR_emailAddress
пп$ E
;
ппE F
}
рр 
if
тт 
(
тт 
emailAddress
тт 
==
тт 
string
тт  &
.
тт& '
Empty
тт' ,
&&
тт- /
mobilePhoneNumber
тт0 A
==
ттB D
string
ттE K
.
ттK L
Empty
ттL Q
)
ттQ R
{
уу 
return
фф 
$str
фф N
;
ффN O
}
хх 
var
шш 
result
шш 
=
шш 
_userDbContext
шш '
.
шш' (

TokenStore
шш( 2
.
щщ 
SingleOrDefault
щщ  
(
щщ  !
t
щщ! "
=>
щщ# %
(
ъъ 
t
ъъ 
.
ъъ 
MobilePhoneNumber
ъъ (
==
ъъ) +/
!mobilePhoneNumber_OR_emailAddress
ъъ, M
||
ъъN P
t
ъъQ R
.
ъъR S
EmailAddress
ъъS _
==
ъъ` b0
!mobilePhoneNumber_OR_emailAddressъъc „
)ъъ„ …
&&ъъ† €
t
ыы 
.
ыы 
Token
ыы 
==
ыы 
	tokenCode
ыы  )
&&
ыы* ,
t
ыы- .
.
ыы. /

ExpiryDate
ыы/ 9
>=
ыы: <
DateTime
ыы= E
.
ыыE F
UtcNow
ыыF L
)
ыыL M
;
ыыM N
if
ээ 
(
ээ 
result
ээ 
is
ээ 
null
ээ 
)
ээ 
{
юю 
return
яя 
$str
яя %
;
яя% &
}
ЂЂ 
return
ѓѓ 
$str
ѓѓ 
;
ѓѓ 
}
„„ 	
public
†† 
JwTokenResponse
†† 

GetJwToken
†† )
(
††) *%
ApplicationIdentityUser
††* A
user
††B F
,
††F G
int
††H K
validityInHours
††L [
)
††[ \
{
‡‡ 	
var
€€ 
	userRoles
€€ 
=
€€ 
_userManager
€€ (
.
€€( )
GetRolesAsync
€€) 6
(
€€6 7
user
€€7 ;
)
€€; <
.
€€< =
Result
€€= C
.
€€C D
FirstOrDefault
€€D R
(
€€R S
)
€€S T
;
€€T U
var
‰‰ 
roleId
‰‰ 
=
‰‰ 
_userDbContext
‰‰ '
.
‰‰' (
roles
‰‰( -
.
ЉЉ' (
Where
ЉЉ( -
(
ЉЉ- .
r
ЉЉ. /
=>
ЉЉ0 2
r
ЉЉ3 4
.
ЉЉ4 5
Name
ЉЉ5 9
==
ЉЉ: <
	userRoles
ЉЉ= F
!
ЉЉF G
)
ЉЉG H
.
‹‹' (
Select
‹‹( .
(
‹‹. /
r
‹‹/ 0
=>
‹‹1 3
r
‹‹4 5
.
‹‹5 6
Id
‹‹6 8
)
‹‹8 9
.
ЊЊ' (
FirstOrDefault
ЊЊ( 6
(
ЊЊ6 7
)
ЊЊ7 8
;
ЊЊ8 9
var
ЋЋ 
claims
ЋЋ 
=
ЋЋ 
this
ЋЋ 
.
ЋЋ #
GetModulesPermissions
ЋЋ 3
(
ЋЋ3 4
roleId
ЋЋ4 :
!
ЋЋ: ;
)
ЋЋ; <
;
ЋЋ< =
var
ђђ 
	allClaims
ђђ 
=
ђђ 
new
ђђ 
List
ђђ  $
<
ђђ$ %
Claim
ђђ% *
>
ђђ* +
{
‘‘ 
new
’’ 
Claim
’’ !
(
’’! "

ClaimTypes
’’" ,
.
’’, -
NameIdentifier
’’- ;
,
’’; <
user
’’= A
.
’’A B
Id
’’B D
)
’’D E
,
’’E F
new
““ 
Claim
““ !
(
““! "

ClaimTypes
““" ,
.
““, -
Role
““- 1
,
““1 2
	userRoles
““3 <
!
““< =
)
““= >
,
““> ?
new
”” 
Claim
”” !
(
””! "

ClaimTypes
””" ,
.
””, -
Email
””- 2
,
””2 3
user
””4 8
.
””8 9
Email
””9 >
!
””> ?
)
””? @
,
””@ A
new
•• 
Claim
•• !
(
••! "

ClaimTypes
••" ,
.
••, -
MobilePhone
••- 8
,
••8 9
user
••: >
.
••> ?
PhoneNumber
••? J
!
••J K
)
••K L
}
–– 
;
–– 
foreach
 
(
 
var
 

permission
 #
in
$ &
claims
' -
)
- .
{
™™ 
	allClaims
љљ 
.
љљ 
Add
љљ 
(
љљ 
new
љљ !
Claim
љљ" '
(
љљ' (
$"
љљ( *
$str
љљ* 5
{
љљ5 6

permission
љљ6 @
.
љљ@ A

ModuleName
љљA K
}
љљK L
$str
љљL M
{
љљM N

permission
љљN X
.
љљX Y
ModulePermission
љљY i
}
љљi j
"
љљj k
,
љљk l

permission
љљm w
.
љљw x
ModulePermissionљљx €
!љљ€ ‰
)љљ‰ Љ
)љљЉ ‹
;љљ‹ Њ
}
›› 
var
џџ 
tokenHandler
џџ 
=
џџ 
new
џџ "%
JwtSecurityTokenHandler
џџ# :
(
џџ: ;
)
џџ; <
;
џџ< =
var
   
key
   
=
   
Encoding
   
.
   
ASCII
   $
.
  $ %
GetBytes
  % -
(
  - .
_configuration
  . <
[
  < =
$str
  = R
]
  R S
!
  S T
)
  T U
;
  U V
var
ўў 
tokenDescriptor
ўў 
=
ўў  !
new
ўў" %%
SecurityTokenDescriptor
ўў& =
{
ЈЈ 
Subject
¤¤ 
=
¤¤ 
new
¤¤ 
ClaimsIdentity
¤¤ ,
(
¤¤, -
	allClaims
¤¤- 6
)
¤¤6 7
,
¤¤7 8
Expires
ҐҐ 
=
ҐҐ 
DateTime
ҐҐ "
.
ҐҐ" #
UtcNow
ҐҐ# )
.
ҐҐ) *
AddHours
ҐҐ* 2
(
ҐҐ2 3
validityInHours
ҐҐ3 B
)
ҐҐB C
,
ҐҐC D 
SigningCredentials
¦¦ "
=
¦¦# $
new
¦¦% ( 
SigningCredentials
¦¦) ;
(
¦¦; <
new
¦¦< ?"
SymmetricSecurityKey
¦¦@ T
(
¦¦T U
key
¦¦U X
)
¦¦X Y
,
¦¦Y Z 
SecurityAlgorithms
¦¦[ m
.
¦¦m n

HmacSha256
¦¦n x
)
¦¦x y
}
§§ 
;
§§ 
var
ЁЁ 
token
ЁЁ 
=
ЁЁ 
tokenHandler
ЁЁ $
.
ЁЁ$ %
CreateToken
ЁЁ% 0
(
ЁЁ0 1
tokenDescriptor
ЁЁ1 @
)
ЁЁ@ A
;
ЁЁA B
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
«« 
new
«« 
JwTokenResponse
«« &
{
¬¬ 
Token
­­ 
=
­­ 
tokenString
­­ #
.
­­# $
ToString
­­$ ,
(
­­, -
)
­­- .
,
­­. /
	ExpiresAt
®® 
=
®® 
tokenDescriptor
®® +
.
®®+ ,
Expires
®®, 3
}
ЇЇ 
;
ЇЇ 
}
°° 	
public
ІІ 
RefreshToken
ІІ 
GetJwRefreshToken
ІІ -
(
ІІ- .
)
ІІ. /
{
іі 	
var
ґґ 
randomNumber
ґґ 
=
ґґ 
new
ґґ "
byte
ґґ# '
[
ґґ' (
$num
ґґ( *
]
ґґ* +
;
ґґ+ ,
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
¶¶ 
rng
·· 
.
·· 
GetBytes
·· 
(
·· 
randomNumber
·· )
)
··) *
;
··* +
return
ёё 
new
ёё 
RefreshToken
ёё '
{
№№ 
Token
єє 
=
єє 
Convert
єє #
.
єє# $
ToBase64String
єє$ 2
(
єє2 3
randomNumber
єє3 ?
)
єє? @
,
єє@ A
Expires
»» 
=
»» 
DateTime
»» &
.
»»& '
UtcNow
»»' -
.
»»- .
AddDays
»». 5
(
»»5 6
$num
»»6 7
)
»»7 8
,
»»8 9
Created
јј 
=
јј 
DateTime
јј &
.
јј& '
UtcNow
јј' -
}
ЅЅ 
;
ЅЅ 
}
ѕѕ 
}
її 	
public
ВВ 
ClaimsPrincipal
ВВ 6
(GetClaimsPrincipalFromExpiredBearerToken
ВВ G
(
ВВG H
string
ВВH N
bearerToken
ВВO Z
)
ВВZ [
{
ГГ 	
var
ДД 
key
ДД 
=
ДД 
Encoding
ДД 
.
ДД 
ASCII
ДД $
.
ДД$ %
GetBytes
ДД% -
(
ДД- .
_configuration
ДД. <
[
ДД< =
$str
ДД= R
]
ДДR S
!
ДДS T
)
ДДT U
;
ДДU V
var
ЕЕ '
tokenValidationParameters
ЕЕ )
=
ЕЕ* +
new
ЕЕ, /'
TokenValidationParameters
ЕЕ0 I
{
ЖЖ 
ValidateIssuer
ЗЗ 
=
ЗЗ  
false
ЗЗ! &
,
ЗЗ& '
ValidateAudience
ИИ  
=
ИИ! "
false
ИИ# (
,
ИИ( )
ValidateLifetime
ЙЙ  
=
ЙЙ! "
false
ЙЙ# (
,
ЙЙ( )&
ValidateIssuerSigningKey
КК (
=
КК) *
true
КК+ /
,
КК/ 0
IssuerSigningKey
ЛЛ  
=
ЛЛ! "
new
ЛЛ# &"
SymmetricSecurityKey
ЛЛ' ;
(
ЛЛ; <
key
ЛЛ< ?
)
ЛЛ? @
,
ЛЛ@ A
	ClockSkew
ММ 
=
ММ 
TimeSpan
ММ $
.
ММ$ %
Zero
ММ% )
}
НН 
;
НН 
var
ПП 
tokenHandler
ПП 
=
ПП 
new
ПП "%
JwtSecurityTokenHandler
ПП# :
(
ПП: ;
)
ПП; <
;
ПП< =
var
РР 
	principal
РР 
=
РР 
tokenHandler
РР (
.
РР( )
ValidateToken
РР) 6
(
РР6 7
bearerToken
РР7 B
,
РРB C'
tokenValidationParameters
РРD ]
,
РР] ^
out
РР_ b
SecurityToken
РРc p
securityToken
РРq ~
)
РР~ 
;РР Ђ
JwtSecurityToken
СС 
?
СС 
jwtSecurityToken
СС .
=
СС/ 0
securityToken
СС1 >
as
СС? A
JwtSecurityToken
ССB R
;
ССR S
if
ТТ 
(
ТТ 
jwtSecurityToken
ТТ  
==
ТТ! #
null
ТТ$ (
||
ТТ) +
!
ТТ, -
jwtSecurityToken
ТТ- =
.
ТТ= >
Header
ТТ> D
.
ТТD E
Alg
ТТE H
.
ТТH I
Equals
ТТI O
(
ТТO P 
SecurityAlgorithms
ТТP b
.
ТТb c

HmacSha256
ТТc m
,
ТТm n
StringComparison
ТТo 
.ТТ Ђ*
InvariantCultureIgnoreCaseТТЂ љ
)ТТљ ›
)ТТ› њ
{
УУ 
throw
ФФ 
new
ФФ $
SecurityTokenException
ФФ 0
(
ФФ0 1
$str
ФФ1 @
)
ФФ@ A
;
ФФA B
}
ХХ 
return
ЧЧ 
	principal
ЧЧ 
;
ЧЧ 
}
ШШ 	
private
ЪЪ 
IEnumerable
ЪЪ 
<
ЪЪ '
RoleModulesPermissionsDto
ЪЪ 5
>
ЪЪ5 6#
GetModulesPermissions
ЪЪ7 L
(
ЪЪL M
string
ЪЪM S
roleId
ЪЪT Z
)
ЪЪZ [
{
ЫЫ 	
var
ЭЭ 
modulePermissions
ЭЭ !
=
ЭЭ" #
(
ЭЭ$ %
from
ЭЭ% )
a
ЭЭ* +
in
ЭЭ, .
_userDbContext
ЭЭ/ =
.
ЭЭ= >+
ApplicationModulesPermissions
ЭЭ> [
join
ЮЮ% )
b
ЮЮ* +
in
ЮЮ, .
_userDbContext
ЮЮ/ =
.
ЮЮ= > 
ApplicationModules
ЮЮ> P
on
ЯЯ) +
a
ЯЯ, -
.
ЯЯ- .
ModuleId
ЯЯ. 6
equals
ЯЯ7 =
b
ЯЯ> ?
.
ЯЯ? @
ModuleId
ЯЯ@ H
into
ЯЯI M
modules
ЯЯN U
from
аа% )
module
аа* 0
in
аа1 3
modules
аа4 ;
.
аа; <
DefaultIfEmpty
аа< J
(
ааJ K
)
ааK L
join
бб% )
c
бб* +
in
бб, .
_userDbContext
бб/ =
.
бб= >
Roles
бб> C
on
вв) +
a
вв, -
.
вв- .
RoleId
вв. 4
equals
вв5 ;
c
вв< =
.
вв= >
Id
вв> @
into
ввA E
roles
ввF K
from
гг% )
role
гг* .
in
гг/ 1
roles
гг2 7
.
гг7 8
DefaultIfEmpty
гг8 F
(
ггF G
)
ггG H
where
дд% *
a
дд+ ,
.
дд, -
RoleId
дд- 3
==
дд4 6
roleId
дд7 =
select
ее% +
new
ее, /'
RoleModulesPermissionsDto
ее0 I
{
жж% & 
ModulePermissionId
зз) ;
=
зз< =
a
зз> ?
.
зз? @ 
ModulePermissionId
зз@ R
,
ззR S
RoleId
ии) /
=
ии0 1
a
ии2 3
.
ии3 4
RoleId
ии4 :
,
ии: ;
RoleName
йй) 1
=
йй2 3
role
йй4 8
!=
йй9 ;
null
йй< @
?
ййA B
role
ййC G
.
ййG H
Name
ййH L
:
ййM N
$str
ййO X
,
ййX Y
ModuleId
кк) 1
=
кк2 3
a
кк4 5
.
кк5 6
ModuleId
кк6 >
,
кк> ?

ModuleName
лл) 3
=
лл4 5
module
лл6 <
!=
лл= ?
null
лл@ D
?
ллE F
module
ллG M
.
ллM N

ModuleName
ллN X
:
ллY Z
$str
лл[ f
,
ллf g
ModulePermission
мм) 9
=
мм: ;
a
мм< =
.
мм= >
ModulePermission
мм> N
}
нн% &
)
нн& '
.
нн' (
ToList
нн( .
(
нн. /
)
нн/ 0
;
нн0 1
return
пп 
modulePermissions
пп $
;
пп$ %
}
сс 	
}
уу 
}фф ¦
њ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/SubPermissionsRepository.cs
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
 ї
Ў/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/SubPermissionsItemsRepository.cs
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
 ќ
™/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Permissions/PermissionsRepository.cs
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
} ъ
Џ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/SubMenusRepository.cs
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
} Ћ
“/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/SubMenuItemsRepository.cs
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
} л
Њ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/MenusRepository.cs
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
} •
’/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/Menu/MenuActionsRepository.cs
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
} †
”/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/IdentificationTypeRepository.cs
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
 т
ђ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/DepartmentUnitRepository.cs
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
} Ю
Њ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/DepartmentRepository.cs
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
} Ф
Љ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ChannelsRepository.cs
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
 †
”/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ApplicationModulesRepository.cs
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
 ѕ
џ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ApplicationModulesPermissionsRepository.cs
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
(IApplicationModulesPermissionsRepository	c ‹
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
 юH
Њ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Migrations/20250325154629_ModifyRolesTable.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '

Migrations' 1
{ 
public 

partial 
class 
ModifyRolesTable )
:* +
	Migration, 5
{		 
	protected 
override 
void 
Up  "
(" #
MigrationBuilder# 3
migrationBuilder4 D
)D E
{ 	
migrationBuilder 
. 
EnsureSchema )
() *
name 
: 
$str 
) 
; 
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str *
,* +
columns 
: 
table 
=> !
new" %
{ 
ModuleId 
= 
table $
.$ %
Column% +
<+ ,
string, 2
>2 3
(3 4
type4 8
:8 9
$str: H
,H I
	maxLengthJ S
:S T
$numU W
,W X
nullableY a
:a b
falsec h
)h i
,i j

ModuleName 
=  
table! &
.& '
Column' -
<- .
string. 4
>4 5
(5 6
type6 :
:: ;
$str< J
,J K
	maxLengthL U
:U V
$numW Y
,Y Z
nullable[ c
:c d
truee i
)i j
} 
, 
constraints 
: 
table "
=># %
{ 
table 
. 

PrimaryKey $
($ %
$str% <
,< =
x> ?
=>@ B
xC D
.D E
ModuleIdE M
)M N
;N O
} 
) 
; 
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str 5
,5 6
columns 
: 
table 
=> !
new" %
{ 
ModulePermissionId   &
=  ' (
table  ) .
.  . /
Column  / 5
<  5 6
int  6 9
>  9 :
(  : ;
type  ; ?
:  ? @
$str  A F
,  F G
nullable  H P
:  P Q
false  R W
)  W X
.!! 

Annotation!! #
(!!# $
$str!!$ 8
,!!8 9
$str!!: @
)!!@ A
,!!A B
RoleId"" 
="" 
table"" "
.""" #
Column""# )
<"") *
string""* 0
>""0 1
(""1 2
type""2 6
:""6 7
$str""8 F
,""F G
	maxLength""H Q
:""Q R
$num""S U
,""U V
nullable""W _
:""_ `
true""a e
)""e f
,""f g
ModuleId## 
=## 
table## $
.##$ %
Column##% +
<##+ ,
string##, 2
>##2 3
(##3 4
type##4 8
:##8 9
$str##: H
,##H I
	maxLength##J S
:##S T
$num##U W
,##W X
nullable##Y a
:##a b
true##c g
)##g h
,##h i
ModulePermission$$ $
=$$% &
table$$' ,
.$$, -
Column$$- 3
<$$3 4
string$$4 :
>$$: ;
($$; <
type$$< @
:$$@ A
$str$$B P
,$$P Q
	maxLength$$R [
:$$[ \
$num$$] _
,$$_ `
nullable$$a i
:$$i j
true$$k o
)$$o p
}%% 
,%% 
constraints&& 
:&& 
table&& "
=>&&# %
{'' 
table(( 
.(( 

PrimaryKey(( $
((($ %
$str((% G
,((G H
x((I J
=>((K M
x((N O
.((O P
ModulePermissionId((P b
)((b c
;((c d
})) 
))) 
;)) 
migrationBuilder++ 
.++ 
CreateTable++ (
(++( )
name,, 
:,, 
$str,,  
,,,  !
columns-- 
:-- 
table-- 
=>-- !
new--" %
{.. 
	ChannelId// 
=// 
table//  %
.//% &
Column//& ,
<//, -
int//- 0
>//0 1
(//1 2
type//2 6
://6 7
$str//8 =
,//= >
nullable//? G
://G H
false//I N
)//N O
.00 

Annotation00 #
(00# $
$str00$ 8
,008 9
$str00: @
)00@ A
,00A B
ChannelName11 
=11  !
table11" '
.11' (
Column11( .
<11. /
string11/ 5
>115 6
(116 7
type117 ;
:11; <
$str11= K
,11K L
	maxLength11M V
:11V W
$num11X Z
,11Z [
nullable11\ d
:11d e
false11f k
)11k l
,11l m
	CreatedOn22 
=22 
table22  %
.22% &
Column22& ,
<22, -
DateTime22- 5
>225 6
(226 7
type227 ;
:22; <
$str22= H
,22H I
nullable22J R
:22R S
false22T Y
)22Y Z
,22Z [
	CreatedBy33 
=33 
table33  %
.33% &
Column33& ,
<33, -
string33- 3
>333 4
(334 5
type335 9
:339 :
$str33; J
,33J K
nullable33L T
:33T U
true33V Z
)33Z [
,33[ \

ModifiedOn44 
=44  
table44! &
.44& '
Column44' -
<44- .
DateTime44. 6
>446 7
(447 8
type448 <
:44< =
$str44> I
,44I J
nullable44K S
:44S T
false44U Z
)44Z [
,44[ \

ModifiedBy55 
=55  
table55! &
.55& '
Column55' -
<55- .
string55. 4
>554 5
(555 6
type556 :
:55: ;
$str55< K
,55K L
nullable55M U
:55U V
true55W [
)55[ \
,55\ ]
	DeletedOn66 
=66 
table66  %
.66% &
Column66& ,
<66, -
DateTime66- 5
>665 6
(666 7
type667 ;
:66; <
$str66= H
,66H I
nullable66J R
:66R S
false66T Y
)66Y Z
,66Z [
	DeletedBy77 
=77 
table77  %
.77% &
Column77& ,
<77, -
string77- 3
>773 4
(774 5
type775 9
:779 :
$str77; J
,77J K
nullable77L T
:77T U
true77V Z
)77Z [
}88 
,88 
constraints99 
:99 
table99 "
=>99# %
{:: 
table;; 
.;; 

PrimaryKey;; $
(;;$ %
$str;;% 2
,;;2 3
x;;4 5
=>;;6 8
x;;9 :
.;;: ;
	ChannelId;;; D
);;D E
;;;E F
}<< 
)<< 
;<< 
migrationBuilder>> 
.>> 
CreateIndex>> (
(>>( )
name?? 
:?? 
$str?? @
,??@ A
table@@ 
:@@ 
$str@@ *
,@@* +
columnsAA 
:AA 
newAA 
[AA 
]AA 
{AA 
$strAA  *
,AA* +
$strAA, 8
}AA9 :
,AA: ;
uniqueBB 
:BB 
trueBB 
,BB 
filterCC 
:CC 
$strCC 1
)CC1 2
;CC2 3
migrationBuilderEE 
.EE 
CreateIndexEE (
(EE( )
nameFF 
:FF 
$strFF /
,FF/ 0
tableGG 
:GG 
$strGG !
,GG! "
columnHH 
:HH 
$strHH %
,HH% &
uniqueII 
:II 
trueII 
)II 
;II 
}JJ 	
	protectedMM 
overrideMM 
voidMM 
DownMM  $
(MM$ %
MigrationBuilderMM% 5
migrationBuilderMM6 F
)MMF G
{NN 	
migrationBuilderOO 
.OO 
	DropTableOO &
(OO& '
namePP 
:PP 
$strPP *
)PP* +
;PP+ ,
migrationBuilderRR 
.RR 
	DropTableRR &
(RR& '
nameSS 
:SS 
$strSS 5
)SS5 6
;SS6 7
migrationBuilderUU 
.UU 
	DropTableUU &
(UU& '
nameVV 
:VV 
$strVV  
)VV  !
;VV! "
}WW 	
}XX 
}YY Ъг
Ћ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Migrations/20250325154330_ModifiedRolesTable.cs
	namespace 	
Modules
 
. 
Users 
. 
Infrastructure &
.& '

Migrations' 1
{		 
public 

partial 
class 
ModifiedRolesTable +
:, -
	Migration. 7
{ 
	protected 
override 
void 
Up  "
(" #
MigrationBuilder# 3
migrationBuilder4 D
)D E
{ 	
migrationBuilder 
. 
EnsureSchema )
() *
name 
: 
$str 
) 
; 
migrationBuilder 
. 
CreateTable (
(( )
name 
: 
$str *
,* +
columns 
: 
table 
=> !
new" %
{ 
ModuleId 
= 
table $
.$ %
Column% +
<+ ,
string, 2
>2 3
(3 4
type4 8
:8 9
$str: H
,H I
	maxLengthJ S
:S T
$numU W
,W X
nullableY a
:a b
falsec h
)h i
,i j

ModuleName 
=  
table! &
.& '
Column' -
<- .
string. 4
>4 5
(5 6
type6 :
:: ;
$str< J
,J K
	maxLengthL U
:U V
$numW Y
,Y Z
nullable[ c
:c d
truee i
)i j
} 
, 
constraints 
: 
table "
=># %
{ 
table 
. 

PrimaryKey $
($ %
$str% <
,< =
x> ?
=>@ B
xC D
.D E
ModuleIdE M
)M N
;N O
} 
) 
; 
migrationBuilder 
. 
CreateTable (
(( )
name   
:   
$str   5
,  5 6
columns!! 
:!! 
table!! 
=>!! !
new!!" %
{"" 
ModulePermissionId## &
=##' (
table##) .
.##. /
Column##/ 5
<##5 6
int##6 9
>##9 :
(##: ;
type##; ?
:##? @
$str##A F
,##F G
nullable##H P
:##P Q
false##R W
)##W X
.$$ 

Annotation$$ #
($$# $
$str$$$ 8
,$$8 9
$str$$: @
)$$@ A
,$$A B
RoleId%% 
=%% 
table%% "
.%%" #
Column%%# )
<%%) *
string%%* 0
>%%0 1
(%%1 2
type%%2 6
:%%6 7
$str%%8 F
,%%F G
	maxLength%%H Q
:%%Q R
$num%%S U
,%%U V
nullable%%W _
:%%_ `
true%%a e
)%%e f
,%%f g
ModuleId&& 
=&& 
table&& $
.&&$ %
Column&&% +
<&&+ ,
string&&, 2
>&&2 3
(&&3 4
type&&4 8
:&&8 9
$str&&: H
,&&H I
	maxLength&&J S
:&&S T
$num&&U W
,&&W X
nullable&&Y a
:&&a b
true&&c g
)&&g h
,&&h i
ModulePermission'' $
=''% &
table''' ,
.'', -
Column''- 3
<''3 4
string''4 :
>'': ;
(''; <
type''< @
:''@ A
$str''B P
,''P Q
	maxLength''R [
:''[ \
$num''] _
,''_ `
nullable''a i
:''i j
true''k o
)''o p
}(( 
,(( 
constraints)) 
:)) 
table)) "
=>))# %
{** 
table++ 
.++ 

PrimaryKey++ $
(++$ %
$str++% G
,++G H
x++I J
=>++K M
x++N O
.++O P
ModulePermissionId++P b
)++b c
;++c d
},, 
),, 
;,, 
migrationBuilder.. 
... 
CreateTable.. (
(..( )
name// 
:// 
$str//  
,//  !
columns00 
:00 
table00 
=>00 !
new00" %
{11 
	ChannelId22 
=22 
table22  %
.22% &
Column22& ,
<22, -
int22- 0
>220 1
(221 2
type222 6
:226 7
$str228 =
,22= >
nullable22? G
:22G H
false22I N
)22N O
.33 

Annotation33 #
(33# $
$str33$ 8
,338 9
$str33: @
)33@ A
,33A B
ChannelName44 
=44  !
table44" '
.44' (
Column44( .
<44. /
string44/ 5
>445 6
(446 7
type447 ;
:44; <
$str44= K
,44K L
	maxLength44M V
:44V W
$num44X Z
,44Z [
nullable44\ d
:44d e
false44f k
)44k l
,44l m
	CreatedOn55 
=55 
table55  %
.55% &
Column55& ,
<55, -
DateTime55- 5
>555 6
(556 7
type557 ;
:55; <
$str55= H
,55H I
nullable55J R
:55R S
false55T Y
)55Y Z
,55Z [
	CreatedBy66 
=66 
table66  %
.66% &
Column66& ,
<66, -
string66- 3
>663 4
(664 5
type665 9
:669 :
$str66; J
,66J K
nullable66L T
:66T U
true66V Z
)66Z [
,66[ \

ModifiedOn77 
=77  
table77! &
.77& '
Column77' -
<77- .
DateTime77. 6
>776 7
(777 8
type778 <
:77< =
$str77> I
,77I J
nullable77K S
:77S T
false77U Z
)77Z [
,77[ \

ModifiedBy88 
=88  
table88! &
.88& '
Column88' -
<88- .
string88. 4
>884 5
(885 6
type886 :
:88: ;
$str88< K
,88K L
nullable88M U
:88U V
true88W [
)88[ \
,88\ ]
	DeletedOn99 
=99 
table99  %
.99% &
Column99& ,
<99, -
DateTime99- 5
>995 6
(996 7
type997 ;
:99; <
$str99= H
,99H I
nullable99J R
:99R S
false99T Y
)99Y Z
,99Z [
	DeletedBy:: 
=:: 
table::  %
.::% &
Column::& ,
<::, -
string::- 3
>::3 4
(::4 5
type::5 9
:::9 :
$str::; J
,::J K
nullable::L T
:::T U
true::V Z
)::Z [
};; 
,;; 
constraints<< 
:<< 
table<< "
=><<# %
{== 
table>> 
.>> 

PrimaryKey>> $
(>>$ %
$str>>% 2
,>>2 3
x>>4 5
=>>>6 8
x>>9 :
.>>: ;
	ChannelId>>; D
)>>D E
;>>E F
}?? 
)?? 
;?? 
migrationBuilderAA 
.AA 
CreateTableAA (
(AA( )
nameBB 
:BB 
$strBB "
,BB" #
columnsCC 
:CC 
tableCC 
=>CC !
newCC" %
{DD 
DepartmentIdEE  
=EE! "
tableEE# (
.EE( )
ColumnEE) /
<EE/ 0
intEE0 3
>EE3 4
(EE4 5
typeEE5 9
:EE9 :
$strEE; @
,EE@ A
nullableEEB J
:EEJ K
falseEEL Q
)EEQ R
.FF 

AnnotationFF #
(FF# $
$strFF$ 8
,FF8 9
$strFF: @
)FF@ A
,FFA B
DepartmentNameGG "
=GG# $
tableGG% *
.GG* +
ColumnGG+ 1
<GG1 2
stringGG2 8
>GG8 9
(GG9 :
typeGG: >
:GG> ?
$strGG@ N
,GGN O
	maxLengthGGP Y
:GGY Z
$numGG[ ]
,GG] ^
nullableGG_ g
:GGg h
falseGGi n
)GGn o
,GGo p
	CreatedOnHH 
=HH 
tableHH  %
.HH% &
ColumnHH& ,
<HH, -
DateTimeHH- 5
>HH5 6
(HH6 7
typeHH7 ;
:HH; <
$strHH= H
,HHH I
nullableHHJ R
:HHR S
falseHHT Y
)HHY Z
,HHZ [
	CreatedByII 
=II 
tableII  %
.II% &
ColumnII& ,
<II, -
stringII- 3
>II3 4
(II4 5
typeII5 9
:II9 :
$strII; J
,IIJ K
nullableIIL T
:IIT U
trueIIV Z
)IIZ [
,II[ \

ModifiedOnJJ 
=JJ  
tableJJ! &
.JJ& '
ColumnJJ' -
<JJ- .
DateTimeJJ. 6
>JJ6 7
(JJ7 8
typeJJ8 <
:JJ< =
$strJJ> I
,JJI J
nullableJJK S
:JJS T
falseJJU Z
)JJZ [
,JJ[ \

ModifiedByKK 
=KK  
tableKK! &
.KK& '
ColumnKK' -
<KK- .
stringKK. 4
>KK4 5
(KK5 6
typeKK6 :
:KK: ;
$strKK< K
,KKK L
nullableKKM U
:KKU V
trueKKW [
)KK[ \
,KK\ ]
	DeletedOnLL 
=LL 
tableLL  %
.LL% &
ColumnLL& ,
<LL, -
DateTimeLL- 5
>LL5 6
(LL6 7
typeLL7 ;
:LL; <
$strLL= H
,LLH I
nullableLLJ R
:LLR S
falseLLT Y
)LLY Z
,LLZ [
	DeletedByMM 
=MM 
tableMM  %
.MM% &
ColumnMM& ,
<MM, -
stringMM- 3
>MM3 4
(MM4 5
typeMM5 9
:MM9 :
$strMM; J
,MMJ K
nullableMML T
:MMT U
trueMMV Z
)MMZ [
}NN 
,NN 
constraintsOO 
:OO 
tableOO "
=>OO# %
{PP 
tableQQ 
.QQ 

PrimaryKeyQQ $
(QQ$ %
$strQQ% 4
,QQ4 5
xQQ6 7
=>QQ8 :
xQQ; <
.QQ< =
DepartmentIdQQ= I
)QQI J
;QQJ K
}RR 
)RR 
;RR 
migrationBuilderTT 
.TT 
CreateTableTT (
(TT( )
nameUU 
:UU 
$strUU &
,UU& '
columnsVV 
:VV 
tableVV 
=>VV !
newVV" %
{WW 
UnitIdXX 
=XX 
tableXX "
.XX" #
ColumnXX# )
<XX) *
intXX* -
>XX- .
(XX. /
typeXX/ 3
:XX3 4
$strXX5 :
,XX: ;
nullableXX< D
:XXD E
falseXXF K
)XXK L
.YY 

AnnotationYY #
(YY# $
$strYY$ 8
,YY8 9
$strYY: @
)YY@ A
,YYA B
DepartmentIdZZ  
=ZZ! "
tableZZ# (
.ZZ( )
ColumnZZ) /
<ZZ/ 0
intZZ0 3
>ZZ3 4
(ZZ4 5
typeZZ5 9
:ZZ9 :
$strZZ; @
,ZZ@ A
nullableZZB J
:ZZJ K
falseZZL Q
)ZZQ R
,ZZR S
UnitName[[ 
=[[ 
table[[ $
.[[$ %
Column[[% +
<[[+ ,
string[[, 2
>[[2 3
([[3 4
type[[4 8
:[[8 9
$str[[: H
,[[H I
	maxLength[[J S
:[[S T
$num[[U W
,[[W X
nullable[[Y a
:[[a b
false[[c h
)[[h i
,[[i j
	CreatedOn\\ 
=\\ 
table\\  %
.\\% &
Column\\& ,
<\\, -
DateTime\\- 5
>\\5 6
(\\6 7
type\\7 ;
:\\; <
$str\\= H
,\\H I
nullable\\J R
:\\R S
false\\T Y
)\\Y Z
,\\Z [
	CreatedBy]] 
=]] 
table]]  %
.]]% &
Column]]& ,
<]], -
string]]- 3
>]]3 4
(]]4 5
type]]5 9
:]]9 :
$str]]; J
,]]J K
nullable]]L T
:]]T U
true]]V Z
)]]Z [
,]][ \

ModifiedOn^^ 
=^^  
table^^! &
.^^& '
Column^^' -
<^^- .
DateTime^^. 6
>^^6 7
(^^7 8
type^^8 <
:^^< =
$str^^> I
,^^I J
nullable^^K S
:^^S T
false^^U Z
)^^Z [
,^^[ \

ModifiedBy__ 
=__  
table__! &
.__& '
Column__' -
<__- .
string__. 4
>__4 5
(__5 6
type__6 :
:__: ;
$str__< K
,__K L
nullable__M U
:__U V
true__W [
)__[ \
,__\ ]
	DeletedOn`` 
=`` 
table``  %
.``% &
Column``& ,
<``, -
DateTime``- 5
>``5 6
(``6 7
type``7 ;
:``; <
$str``= H
,``H I
nullable``J R
:``R S
false``T Y
)``Y Z
,``Z [
	DeletedByaa 
=aa 
tableaa  %
.aa% &
Columnaa& ,
<aa, -
stringaa- 3
>aa3 4
(aa4 5
typeaa5 9
:aa9 :
$straa; J
,aaJ K
nullableaaL T
:aaT U
trueaaV Z
)aaZ [
}bb 
,bb 
constraintscc 
:cc 
tablecc "
=>cc# %
{dd 
tableee 
.ee 

PrimaryKeyee $
(ee$ %
$stree% 8
,ee8 9
xee: ;
=>ee< >
xee? @
.ee@ A
UnitIdeeA G
)eeG H
;eeH I
}ff 
)ff 
;ff 
migrationBuilderhh 
.hh 
CreateTablehh (
(hh( )
nameii 
:ii 
$strii *
,ii* +
columnsjj 
:jj 
tablejj 
=>jj !
newjj" %
{kk  
IdentificationTypeIdll (
=ll) *
tablell+ 0
.ll0 1
Columnll1 7
<ll7 8
intll8 ;
>ll; <
(ll< =
typell= A
:llA B
$strllC H
,llH I
nullablellJ R
:llR S
falsellT Y
)llY Z
,llZ [
IdentificationTypesmm '
=mm( )
tablemm* /
.mm/ 0
Columnmm0 6
<mm6 7
stringmm7 =
>mm= >
(mm> ?
typemm? C
:mmC D
$strmmE S
,mmS T
	maxLengthmmU ^
:mm^ _
$nummm` b
,mmb c
nullablemmd l
:mml m
falsemmn s
)mms t
}nn 
,nn 
constraintsoo 
:oo 
tableoo "
=>oo# %
{pp 
tableqq 
.qq 

PrimaryKeyqq $
(qq$ %
$strqq% <
,qq< =
xqq> ?
=>qq@ B
xqqC D
.qqD E 
IdentificationTypeIdqqE Y
)qqY Z
;qqZ [
}rr 
)rr 
;rr 
migrationBuildertt 
.tt 
CreateTablett (
(tt( )
nameuu 
:uu 
$struu 
,uu 
columnsvv 
:vv 
tablevv 
=>vv !
newvv" %
{ww 
MenuIdxx 
=xx 
tablexx "
.xx" #
Columnxx# )
<xx) *
intxx* -
>xx- .
(xx. /
typexx/ 3
:xx3 4
$strxx5 :
,xx: ;
nullablexx< D
:xxD E
falsexxF K
)xxK L
.yy 

Annotationyy #
(yy# $
$stryy$ 8
,yy8 9
$stryy: @
)yy@ A
,yyA B
MenuNamezz 
=zz 
tablezz $
.zz$ %
Columnzz% +
<zz+ ,
stringzz, 2
>zz2 3
(zz3 4
typezz4 8
:zz8 9
$strzz: I
,zzI J
	maxLengthzzK T
:zzT U
$numzzV Y
,zzY Z
nullablezz[ c
:zzc d
falsezze j
)zzj k
,zzk l
Description{{ 
={{  !
table{{" '
.{{' (
Column{{( .
<{{. /
string{{/ 5
>{{5 6
({{6 7
type{{7 ;
:{{; <
$str{{= L
,{{L M
	maxLength{{N W
:{{W X
$num{{Y \
,{{\ ]
nullable{{^ f
:{{f g
false{{h m
){{m n
,{{n o
IsOpen|| 
=|| 
table|| "
.||" #
Column||# )
<||) *
bool||* .
>||. /
(||/ 0
type||0 4
:||4 5
$str||6 ;
,||; <
nullable||= E
:||E F
false||G L
)||L M
}}} 
,}} 
constraints~~ 
:~~ 
table~~ "
=>~~# %
{ 
table
ЂЂ 
.
ЂЂ 

PrimaryKey
ЂЂ $
(
ЂЂ$ %
$str
ЂЂ% /
,
ЂЂ/ 0
x
ЂЂ1 2
=>
ЂЂ3 5
x
ЂЂ6 7
.
ЂЂ7 8
MenuId
ЂЂ8 >
)
ЂЂ> ?
;
ЂЂ? @
}
ЃЃ 
)
ЃЃ 
;
ЃЃ 
migrationBuilder
ѓѓ 
.
ѓѓ 
CreateTable
ѓѓ (
(
ѓѓ( )
name
„„ 
:
„„ 
$str
„„ #
,
„„# $
columns
…… 
:
…… 
table
…… 
=>
…… !
new
……" %
{
†† 
PermissionsId
‡‡ !
=
‡‡" #
table
‡‡$ )
.
‡‡) *
Column
‡‡* 0
<
‡‡0 1
int
‡‡1 4
>
‡‡4 5
(
‡‡5 6
type
‡‡6 :
:
‡‡: ;
$str
‡‡< A
,
‡‡A B
nullable
‡‡C K
:
‡‡K L
false
‡‡M R
)
‡‡R S
.
€€ 

Annotation
€€ #
(
€€# $
$str
€€$ 8
,
€€8 9
$str
€€: @
)
€€@ A
,
€€A B
RoleId
‰‰ 
=
‰‰ 
table
‰‰ "
.
‰‰" #
Column
‰‰# )
<
‰‰) *
string
‰‰* 0
>
‰‰0 1
(
‰‰1 2
type
‰‰2 6
:
‰‰6 7
$str
‰‰8 F
,
‰‰F G
	maxLength
‰‰H Q
:
‰‰Q R
$num
‰‰S U
,
‰‰U V
nullable
‰‰W _
:
‰‰_ `
false
‰‰a f
)
‰‰f g
,
‰‰g h

ModuleName
ЉЉ 
=
ЉЉ  
table
ЉЉ! &
.
ЉЉ& '
Column
ЉЉ' -
<
ЉЉ- .
string
ЉЉ. 4
>
ЉЉ4 5
(
ЉЉ5 6
type
ЉЉ6 :
:
ЉЉ: ;
$str
ЉЉ< K
,
ЉЉK L
	maxLength
ЉЉM V
:
ЉЉV W
$num
ЉЉX [
,
ЉЉ[ \
nullable
ЉЉ] e
:
ЉЉe f
false
ЉЉg l
)
ЉЉl m
,
ЉЉm n
NoAccess
‹‹ 
=
‹‹ 
table
‹‹ $
.
‹‹$ %
Column
‹‹% +
<
‹‹+ ,
bool
‹‹, 0
>
‹‹0 1
(
‹‹1 2
type
‹‹2 6
:
‹‹6 7
$str
‹‹8 =
,
‹‹= >
nullable
‹‹? G
:
‹‹G H
false
‹‹I N
)
‹‹N O
,
‹‹O P
Create
ЊЊ 
=
ЊЊ 
table
ЊЊ "
.
ЊЊ" #
Column
ЊЊ# )
<
ЊЊ) *
bool
ЊЊ* .
>
ЊЊ. /
(
ЊЊ/ 0
type
ЊЊ0 4
:
ЊЊ4 5
$str
ЊЊ6 ;
,
ЊЊ; <
nullable
ЊЊ= E
:
ЊЊE F
false
ЊЊG L
)
ЊЊL M
,
ЊЊM N
Read
ЌЌ 
=
ЌЌ 
table
ЌЌ  
.
ЌЌ  !
Column
ЌЌ! '
<
ЌЌ' (
bool
ЌЌ( ,
>
ЌЌ, -
(
ЌЌ- .
type
ЌЌ. 2
:
ЌЌ2 3
$str
ЌЌ4 9
,
ЌЌ9 :
nullable
ЌЌ; C
:
ЌЌC D
false
ЌЌE J
)
ЌЌJ K
,
ЌЌK L
Update
ЋЋ 
=
ЋЋ 
table
ЋЋ "
.
ЋЋ" #
Column
ЋЋ# )
<
ЋЋ) *
bool
ЋЋ* .
>
ЋЋ. /
(
ЋЋ/ 0
type
ЋЋ0 4
:
ЋЋ4 5
$str
ЋЋ6 ;
,
ЋЋ; <
nullable
ЋЋ= E
:
ЋЋE F
false
ЋЋG L
)
ЋЋL M
,
ЋЋM N
Delete
ЏЏ 
=
ЏЏ 
table
ЏЏ "
.
ЏЏ" #
Column
ЏЏ# )
<
ЏЏ) *
bool
ЏЏ* .
>
ЏЏ. /
(
ЏЏ/ 0
type
ЏЏ0 4
:
ЏЏ4 5
$str
ЏЏ6 ;
,
ЏЏ; <
nullable
ЏЏ= E
:
ЏЏE F
false
ЏЏG L
)
ЏЏL M
,
ЏЏM N
Approve
ђђ 
=
ђђ 
table
ђђ #
.
ђђ# $
Column
ђђ$ *
<
ђђ* +
bool
ђђ+ /
>
ђђ/ 0
(
ђђ0 1
type
ђђ1 5
:
ђђ5 6
$str
ђђ7 <
,
ђђ< =
nullable
ђђ> F
:
ђђF G
false
ђђH M
)
ђђM N
}
‘‘ 
,
‘‘ 
constraints
’’ 
:
’’ 
table
’’ "
=>
’’# %
{
““ 
table
”” 
.
”” 

PrimaryKey
”” $
(
””$ %
$str
””% 5
,
””5 6
x
””7 8
=>
””9 ;
x
””< =
.
””= >
PermissionsId
””> K
)
””K L
;
””L M
}
•• 
)
•• 
;
•• 
migrationBuilder
—— 
.
—— 
CreateTable
—— (
(
——( )
name
 
:
 
$str
 
,
 
schema
™™ 
:
™™ 
$str
™™ 
,
™™ 
columns
љљ 
:
љљ 
table
љљ 
=>
љљ !
new
љљ" %
{
›› 
Id
њњ 
=
њњ 
table
њњ 
.
њњ 
Column
њњ %
<
њњ% &
string
њњ& ,
>
њњ, -
(
њњ- .
type
њњ. 2
:
њњ2 3
$str
њњ4 C
,
њњC D
nullable
њњE M
:
њњM N
false
њњO T
)
њњT U
,
њњU V
DepartmentId
ќќ  
=
ќќ! "
table
ќќ# (
.
ќќ( )
Column
ќќ) /
<
ќќ/ 0
int
ќќ0 3
>
ќќ3 4
(
ќќ4 5
type
ќќ5 9
:
ќќ9 :
$str
ќќ; @
,
ќќ@ A
nullable
ќќB J
:
ќќJ K
false
ќќL Q
)
ќќQ R
,
ќќR S
UnitId
ћћ 
=
ћћ 
table
ћћ "
.
ћћ" #
Column
ћћ# )
<
ћћ) *
int
ћћ* -
>
ћћ- .
(
ћћ. /
type
ћћ/ 3
:
ћћ3 4
$str
ћћ5 :
,
ћћ: ;
nullable
ћћ< D
:
ћћD E
false
ћћF K
)
ћћK L
,
ћћL M
	CreatedOn
џџ 
=
џџ 
table
џџ  %
.
џџ% &
Column
џџ& ,
<
џџ, -
DateTime
џџ- 5
>
џџ5 6
(
џџ6 7
type
џџ7 ;
:
џџ; <
$str
џџ= H
,
џџH I
nullable
џџJ R
:
џџR S
false
џџT Y
)
џџY Z
,
џџZ [
	CreatedBy
   
=
   
table
    %
.
  % &
Column
  & ,
<
  , -
string
  - 3
>
  3 4
(
  4 5
type
  5 9
:
  9 :
$str
  ; J
,
  J K
nullable
  L T
:
  T U
true
  V Z
)
  Z [
,
  [ \

ModifiedOn
ЎЎ 
=
ЎЎ  
table
ЎЎ! &
.
ЎЎ& '
Column
ЎЎ' -
<
ЎЎ- .
DateTime
ЎЎ. 6
>
ЎЎ6 7
(
ЎЎ7 8
type
ЎЎ8 <
:
ЎЎ< =
$str
ЎЎ> I
,
ЎЎI J
nullable
ЎЎK S
:
ЎЎS T
false
ЎЎU Z
)
ЎЎZ [
,
ЎЎ[ \

ModifiedBy
ўў 
=
ўў  
table
ўў! &
.
ўў& '
Column
ўў' -
<
ўў- .
string
ўў. 4
>
ўў4 5
(
ўў5 6
type
ўў6 :
:
ўў: ;
$str
ўў< K
,
ўўK L
nullable
ўўM U
:
ўўU V
true
ўўW [
)
ўў[ \
,
ўў\ ]
	DeletedOn
ЈЈ 
=
ЈЈ 
table
ЈЈ  %
.
ЈЈ% &
Column
ЈЈ& ,
<
ЈЈ, -
DateTime
ЈЈ- 5
>
ЈЈ5 6
(
ЈЈ6 7
type
ЈЈ7 ;
:
ЈЈ; <
$str
ЈЈ= H
,
ЈЈH I
nullable
ЈЈJ R
:
ЈЈR S
false
ЈЈT Y
)
ЈЈY Z
,
ЈЈZ [
	DeletedBy
¤¤ 
=
¤¤ 
table
¤¤  %
.
¤¤% &
Column
¤¤& ,
<
¤¤, -
string
¤¤- 3
>
¤¤3 4
(
¤¤4 5
type
¤¤5 9
:
¤¤9 :
$str
¤¤; J
,
¤¤J K
nullable
¤¤L T
:
¤¤T U
true
¤¤V Z
)
¤¤Z [
,
¤¤[ \

ApprovedOn
ҐҐ 
=
ҐҐ  
table
ҐҐ! &
.
ҐҐ& '
Column
ҐҐ' -
<
ҐҐ- .
DateTime
ҐҐ. 6
>
ҐҐ6 7
(
ҐҐ7 8
type
ҐҐ8 <
:
ҐҐ< =
$str
ҐҐ> I
,
ҐҐI J
nullable
ҐҐK S
:
ҐҐS T
false
ҐҐU Z
)
ҐҐZ [
,
ҐҐ[ \

ApprovedBy
¦¦ 
=
¦¦  
table
¦¦! &
.
¦¦& '
Column
¦¦' -
<
¦¦- .
string
¦¦. 4
>
¦¦4 5
(
¦¦5 6
type
¦¦6 :
:
¦¦: ;
$str
¦¦< K
,
¦¦K L
nullable
¦¦M U
:
¦¦U V
true
¦¦W [
)
¦¦[ \
,
¦¦\ ]
Status
§§ 
=
§§ 
table
§§ "
.
§§" #
Column
§§# )
<
§§) *
short
§§* /
>
§§/ 0
(
§§0 1
type
§§1 5
:
§§5 6
$str
§§7 A
,
§§A B
nullable
§§C K
:
§§K L
false
§§M R
)
§§R S
,
§§S T
Name
ЁЁ 
=
ЁЁ 
table
ЁЁ  
.
ЁЁ  !
Column
ЁЁ! '
<
ЁЁ' (
string
ЁЁ( .
>
ЁЁ. /
(
ЁЁ/ 0
type
ЁЁ0 4
:
ЁЁ4 5
$str
ЁЁ6 E
,
ЁЁE F
	maxLength
ЁЁG P
:
ЁЁP Q
$num
ЁЁR U
,
ЁЁU V
nullable
ЁЁW _
:
ЁЁ_ `
true
ЁЁa e
)
ЁЁe f
,
ЁЁf g
NormalizedName
©© "
=
©©# $
table
©©% *
.
©©* +
Column
©©+ 1
<
©©1 2
string
©©2 8
>
©©8 9
(
©©9 :
type
©©: >
:
©©> ?
$str
©©@ O
,
©©O P
	maxLength
©©Q Z
:
©©Z [
$num
©©\ _
,
©©_ `
nullable
©©a i
:
©©i j
true
©©k o
)
©©o p
,
©©p q
ConcurrencyStamp
ЄЄ $
=
ЄЄ% &
table
ЄЄ' ,
.
ЄЄ, -
Column
ЄЄ- 3
<
ЄЄ3 4
string
ЄЄ4 :
>
ЄЄ: ;
(
ЄЄ; <
type
ЄЄ< @
:
ЄЄ@ A
$str
ЄЄB Q
,
ЄЄQ R
nullable
ЄЄS [
:
ЄЄ[ \
true
ЄЄ] a
)
ЄЄa b
}
«« 
,
«« 
constraints
¬¬ 
:
¬¬ 
table
¬¬ "
=>
¬¬# %
{
­­ 
table
®® 
.
®® 

PrimaryKey
®® $
(
®®$ %
$str
®®% /
,
®®/ 0
x
®®1 2
=>
®®3 5
x
®®6 7
.
®®7 8
Id
®®8 :
)
®®: ;
;
®®; <
}
ЇЇ 
)
ЇЇ 
;
ЇЇ 
migrationBuilder
±± 
.
±± 
CreateTable
±± (
(
±±( )
name
ІІ 
:
ІІ 
$str
ІІ %
,
ІІ% &
columns
іі 
:
іі 
table
іі 
=>
іі !
new
іі" %
{
ґґ 
Id
µµ 
=
µµ 
table
µµ 
.
µµ 
Column
µµ %
<
µµ% &
string
µµ& ,
>
µµ, -
(
µµ- .
type
µµ. 2
:
µµ2 3
$str
µµ4 C
,
µµC D
nullable
µµE M
:
µµM N
true
µµO S
)
µµS T
,
µµT U"
IdentificationNumber
¶¶ (
=
¶¶) *
table
¶¶+ 0
.
¶¶0 1
Column
¶¶1 7
<
¶¶7 8
string
¶¶8 >
>
¶¶> ?
(
¶¶? @
type
¶¶@ D
:
¶¶D E
$str
¶¶F U
,
¶¶U V
nullable
¶¶W _
:
¶¶_ `
true
¶¶a e
)
¶¶e f
,
¶¶f g
	FirstName
·· 
=
·· 
table
··  %
.
··% &
Column
··& ,
<
··, -
string
··- 3
>
··3 4
(
··4 5
type
··5 9
:
··9 :
$str
··; J
,
··J K
nullable
··L T
:
··T U
true
··V Z
)
··Z [
,
··[ \

MiddleName
ёё 
=
ёё  
table
ёё! &
.
ёё& '
Column
ёё' -
<
ёё- .
string
ёё. 4
>
ёё4 5
(
ёё5 6
type
ёё6 :
:
ёё: ;
$str
ёё< K
,
ёёK L
nullable
ёёM U
:
ёёU V
true
ёёW [
)
ёё[ \
,
ёё\ ]
LastName
№№ 
=
№№ 
table
№№ $
.
№№$ %
Column
№№% +
<
№№+ ,
string
№№, 2
>
№№2 3
(
№№3 4
type
№№4 8
:
№№8 9
$str
№№: I
,
№№I J
nullable
№№K S
:
№№S T
true
№№U Y
)
№№Y Z
,
№№Z [
DepartmentName
єє "
=
єє# $
table
єє% *
.
єє* +
Column
єє+ 1
<
єє1 2
string
єє2 8
>
єє8 9
(
єє9 :
type
єє: >
:
єє> ?
$str
єє@ O
,
єєO P
nullable
єєQ Y
:
єєY Z
true
єє[ _
)
єє_ `
,
єє` a
UnitName
»» 
=
»» 
table
»» $
.
»»$ %
Column
»»% +
<
»»+ ,
string
»», 2
>
»»2 3
(
»»3 4
type
»»4 8
:
»»8 9
$str
»»: I
,
»»I J
nullable
»»K S
:
»»S T
true
»»U Y
)
»»Y Z
,
»»Z [
Email
јј 
=
јј 
table
јј !
.
јј! "
Column
јј" (
<
јј( )
string
јј) /
>
јј/ 0
(
јј0 1
type
јј1 5
:
јј5 6
$str
јј7 F
,
јјF G
nullable
јјH P
:
јјP Q
true
јјR V
)
јјV W
,
јјW X
PhoneNumber
ЅЅ 
=
ЅЅ  !
table
ЅЅ" '
.
ЅЅ' (
Column
ЅЅ( .
<
ЅЅ. /
string
ЅЅ/ 5
>
ЅЅ5 6
(
ЅЅ6 7
type
ЅЅ7 ;
:
ЅЅ; <
$str
ЅЅ= L
,
ЅЅL M
nullable
ЅЅN V
:
ЅЅV W
true
ЅЅX \
)
ЅЅ\ ]
,
ЅЅ] ^
RoleName
ѕѕ 
=
ѕѕ 
table
ѕѕ $
.
ѕѕ$ %
Column
ѕѕ% +
<
ѕѕ+ ,
string
ѕѕ, 2
>
ѕѕ2 3
(
ѕѕ3 4
type
ѕѕ4 8
:
ѕѕ8 9
$str
ѕѕ: I
,
ѕѕI J
nullable
ѕѕK S
:
ѕѕS T
true
ѕѕU Y
)
ѕѕY Z
,
ѕѕZ [
Status
її 
=
її 
table
її "
.
її" #
Column
її# )
<
її) *
int
її* -
>
її- .
(
її. /
type
її/ 3
:
її3 4
$str
її5 :
,
її: ;
nullable
її< D
:
їїD E
false
їїF K
)
їїK L
,
їїL M
RegistrationDate
АА $
=
АА% &
table
АА' ,
.
АА, -
Column
АА- 3
<
АА3 4
DateTime
АА4 <
>
АА< =
(
АА= >
type
АА> B
:
ААB C
$str
ААD O
,
ААO P
nullable
ААQ Y
:
ААY Z
false
АА[ `
)
АА` a
}
ББ 
,
ББ 
constraints
ВВ 
:
ВВ 
table
ВВ "
=>
ВВ# %
{
ГГ 
}
ДД 
)
ДД 
;
ДД 
migrationBuilder
ЖЖ 
.
ЖЖ 
CreateTable
ЖЖ (
(
ЖЖ( )
name
ЗЗ 
:
ЗЗ 
$str
ЗЗ $
,
ЗЗ$ %
columns
ИИ 
:
ИИ 
table
ИИ 
=>
ИИ !
new
ИИ" %
{
ЙЙ 
SubMenuItemId
КК !
=
КК" #
table
КК$ )
.
КК) *
Column
КК* 0
<
КК0 1
int
КК1 4
>
КК4 5
(
КК5 6
type
КК6 :
:
КК: ;
$str
КК< A
,
ККA B
nullable
ККC K
:
ККK L
false
ККM R
)
ККR S
.
ЛЛ 

Annotation
ЛЛ #
(
ЛЛ# $
$str
ЛЛ$ 8
,
ЛЛ8 9
$str
ЛЛ: @
)
ЛЛ@ A
,
ЛЛA B
MenuId
ММ 
=
ММ 
table
ММ "
.
ММ" #
Column
ММ# )
<
ММ) *
int
ММ* -
>
ММ- .
(
ММ. /
type
ММ/ 3
:
ММ3 4
$str
ММ5 :
,
ММ: ;
nullable
ММ< D
:
ММD E
false
ММF K
)
ММK L
,
ММL M
	SubMenuId
НН 
=
НН 
table
НН  %
.
НН% &
Column
НН& ,
<
НН, -
int
НН- 0
>
НН0 1
(
НН1 2
type
НН2 6
:
НН6 7
$str
НН8 =
,
НН= >
nullable
НН? G
:
ННG H
false
ННI N
)
ННN O
,
ННO P
SubMenuItemName
ОО #
=
ОО$ %
table
ОО& +
.
ОО+ ,
Column
ОО, 2
<
ОО2 3
string
ОО3 9
>
ОО9 :
(
ОО: ;
type
ОО; ?
:
ОО? @
$str
ООA P
,
ООP Q
	maxLength
ООR [
:
ОО[ \
$num
ОО] `
,
ОО` a
nullable
ООb j
:
ООj k
false
ООl q
)
ООq r
,
ООr s
Description
ПП 
=
ПП  !
table
ПП" '
.
ПП' (
Column
ПП( .
<
ПП. /
string
ПП/ 5
>
ПП5 6
(
ПП6 7
type
ПП7 ;
:
ПП; <
$str
ПП= L
,
ППL M
	maxLength
ППN W
:
ППW X
$num
ППY \
,
ПП\ ]
nullable
ПП^ f
:
ППf g
false
ППh m
)
ППm n
}
РР 
,
РР 
constraints
СС 
:
СС 
table
СС "
=>
СС# %
{
ТТ 
table
УУ 
.
УУ 

PrimaryKey
УУ $
(
УУ$ %
$str
УУ% 6
,
УУ6 7
x
УУ8 9
=>
УУ: <
x
УУ= >
.
УУ> ?
SubMenuItemId
УУ? L
)
УУL M
;
УУM N
}
ФФ 
)
ФФ 
;
ФФ 
migrationBuilder
ЦЦ 
.
ЦЦ 
CreateTable
ЦЦ (
(
ЦЦ( )
name
ЧЧ 
:
ЧЧ 
$str
ЧЧ  
,
ЧЧ  !
columns
ШШ 
:
ШШ 
table
ШШ 
=>
ШШ !
new
ШШ" %
{
ЩЩ 
	SubMenuId
ЪЪ 
=
ЪЪ 
table
ЪЪ  %
.
ЪЪ% &
Column
ЪЪ& ,
<
ЪЪ, -
int
ЪЪ- 0
>
ЪЪ0 1
(
ЪЪ1 2
type
ЪЪ2 6
:
ЪЪ6 7
$str
ЪЪ8 =
,
ЪЪ= >
nullable
ЪЪ? G
:
ЪЪG H
false
ЪЪI N
)
ЪЪN O
.
ЫЫ 

Annotation
ЫЫ #
(
ЫЫ# $
$str
ЫЫ$ 8
,
ЫЫ8 9
$str
ЫЫ: @
)
ЫЫ@ A
,
ЫЫA B
MenuId
ЬЬ 
=
ЬЬ 
table
ЬЬ "
.
ЬЬ" #
Column
ЬЬ# )
<
ЬЬ) *
int
ЬЬ* -
>
ЬЬ- .
(
ЬЬ. /
type
ЬЬ/ 3
:
ЬЬ3 4
$str
ЬЬ5 :
,
ЬЬ: ;
nullable
ЬЬ< D
:
ЬЬD E
false
ЬЬF K
)
ЬЬK L
,
ЬЬL M
SubMenuName
ЭЭ 
=
ЭЭ  !
table
ЭЭ" '
.
ЭЭ' (
Column
ЭЭ( .
<
ЭЭ. /
string
ЭЭ/ 5
>
ЭЭ5 6
(
ЭЭ6 7
type
ЭЭ7 ;
:
ЭЭ; <
$str
ЭЭ= L
,
ЭЭL M
	maxLength
ЭЭN W
:
ЭЭW X
$num
ЭЭY \
,
ЭЭ\ ]
nullable
ЭЭ^ f
:
ЭЭf g
false
ЭЭh m
)
ЭЭm n
,
ЭЭn o
Description
ЮЮ 
=
ЮЮ  !
table
ЮЮ" '
.
ЮЮ' (
Column
ЮЮ( .
<
ЮЮ. /
string
ЮЮ/ 5
>
ЮЮ5 6
(
ЮЮ6 7
type
ЮЮ7 ;
:
ЮЮ; <
$str
ЮЮ= L
,
ЮЮL M
	maxLength
ЮЮN W
:
ЮЮW X
$num
ЮЮY \
,
ЮЮ\ ]
nullable
ЮЮ^ f
:
ЮЮf g
false
ЮЮh m
)
ЮЮm n
,
ЮЮn o
IsOpen
ЯЯ 
=
ЯЯ 
table
ЯЯ "
.
ЯЯ" #
Column
ЯЯ# )
<
ЯЯ) *
bool
ЯЯ* .
>
ЯЯ. /
(
ЯЯ/ 0
type
ЯЯ0 4
:
ЯЯ4 5
$str
ЯЯ6 ;
,
ЯЯ; <
nullable
ЯЯ= E
:
ЯЯE F
false
ЯЯG L
)
ЯЯL M
}
аа 
,
аа 
constraints
бб 
:
бб 
table
бб "
=>
бб# %
{
вв 
table
гг 
.
гг 

PrimaryKey
гг $
(
гг$ %
$str
гг% 2
,
гг2 3
x
гг4 5
=>
гг6 8
x
гг9 :
.
гг: ;
	SubMenuId
гг; D
)
ггD E
;
ггE F
}
дд 
)
дд 
;
дд 
migrationBuilder
жж 
.
жж 
CreateTable
жж (
(
жж( )
name
зз 
:
зз 
$str
зз &
,
зз& '
columns
ии 
:
ии 
table
ии 
=>
ии !
new
ии" %
{
йй 
SubPermissionsId
кк $
=
кк% &
table
кк' ,
.
кк, -
Column
кк- 3
<
кк3 4
int
кк4 7
>
кк7 8
(
кк8 9
type
кк9 =
:
кк= >
$str
кк? D
,
ккD E
nullable
ккF N
:
ккN O
false
ккP U
)
ккU V
.
лл 

Annotation
лл #
(
лл# $
$str
лл$ 8
,
лл8 9
$str
лл: @
)
лл@ A
,
ллA B
PermissionsId
мм !
=
мм" #
table
мм$ )
.
мм) *
Column
мм* 0
<
мм0 1
int
мм1 4
>
мм4 5
(
мм5 6
type
мм6 :
:
мм: ;
$str
мм< A
,
ммA B
nullable
ммC K
:
ммK L
false
ммM R
)
ммR S
,
ммS T
RoleId
нн 
=
нн 
table
нн "
.
нн" #
Column
нн# )
<
нн) *
string
нн* 0
>
нн0 1
(
нн1 2
type
нн2 6
:
нн6 7
$str
нн8 F
,
ннF G
	maxLength
ннH Q
:
ннQ R
$num
ннS U
,
ннU V
nullable
ннW _
:
нн_ `
false
ннa f
)
ннf g
,
ннg h
SectionName
оо 
=
оо  !
table
оо" '
.
оо' (
Column
оо( .
<
оо. /
string
оо/ 5
>
оо5 6
(
оо6 7
type
оо7 ;
:
оо; <
$str
оо= L
,
ооL M
	maxLength
ооN W
:
ооW X
$num
ооY \
,
оо\ ]
nullable
оо^ f
:
ооf g
false
ооh m
)
ооm n
,
ооn o
NoAccess
пп 
=
пп 
table
пп $
.
пп$ %
Column
пп% +
<
пп+ ,
bool
пп, 0
>
пп0 1
(
пп1 2
type
пп2 6
:
пп6 7
$str
пп8 =
,
пп= >
nullable
пп? G
:
ппG H
false
ппI N
)
ппN O
,
ппO P
Create
рр 
=
рр 
table
рр "
.
рр" #
Column
рр# )
<
рр) *
bool
рр* .
>
рр. /
(
рр/ 0
type
рр0 4
:
рр4 5
$str
рр6 ;
,
рр; <
nullable
рр= E
:
ррE F
false
ррG L
)
ррL M
,
ррM N
Read
сс 
=
сс 
table
сс  
.
сс  !
Column
сс! '
<
сс' (
bool
сс( ,
>
сс, -
(
сс- .
type
сс. 2
:
сс2 3
$str
сс4 9
,
сс9 :
nullable
сс; C
:
ссC D
false
ссE J
)
ссJ K
,
ссK L
Update
тт 
=
тт 
table
тт "
.
тт" #
Column
тт# )
<
тт) *
bool
тт* .
>
тт. /
(
тт/ 0
type
тт0 4
:
тт4 5
$str
тт6 ;
,
тт; <
nullable
тт= E
:
ттE F
false
ттG L
)
ттL M
,
ттM N
Delete
уу 
=
уу 
table
уу "
.
уу" #
Column
уу# )
<
уу) *
bool
уу* .
>
уу. /
(
уу/ 0
type
уу0 4
:
уу4 5
$str
уу6 ;
,
уу; <
nullable
уу= E
:
ууE F
false
ууG L
)
ууL M
,
ууM N
Approve
фф 
=
фф 
table
фф #
.
фф# $
Column
фф$ *
<
фф* +
bool
фф+ /
>
фф/ 0
(
фф0 1
type
фф1 5
:
фф5 6
$str
фф7 <
,
фф< =
nullable
фф> F
:
ффF G
false
ффH M
)
ффM N
}
хх 
,
хх 
constraints
цц 
:
цц 
table
цц "
=>
цц# %
{
чч 
table
шш 
.
шш 

PrimaryKey
шш $
(
шш$ %
$str
шш% 8
,
шш8 9
x
шш: ;
=>
шш< >
x
шш? @
.
шш@ A
SubPermissionsId
шшA Q
)
шшQ R
;
шшR S
}
щщ 
)
щщ 
;
щщ 
migrationBuilder
ыы 
.
ыы 
CreateTable
ыы (
(
ыы( )
name
ьь 
:
ьь 
$str
ьь +
,
ьь+ ,
columns
ээ 
:
ээ 
table
ээ 
=>
ээ !
new
ээ" %
{
юю #
SubPermissionsItemsId
яя )
=
яя* +
table
яя, 1
.
яя1 2
Column
яя2 8
<
яя8 9
int
яя9 <
>
яя< =
(
яя= >
type
яя> B
:
яяB C
$str
яяD I
,
яяI J
nullable
яяK S
:
яяS T
false
яяU Z
)
яяZ [
.
ЂЂ 

Annotation
ЂЂ #
(
ЂЂ# $
$str
ЂЂ$ 8
,
ЂЂ8 9
$str
ЂЂ: @
)
ЂЂ@ A
,
ЂЂA B
PermissionsId
ЃЃ !
=
ЃЃ" #
table
ЃЃ$ )
.
ЃЃ) *
Column
ЃЃ* 0
<
ЃЃ0 1
int
ЃЃ1 4
>
ЃЃ4 5
(
ЃЃ5 6
type
ЃЃ6 :
:
ЃЃ: ;
$str
ЃЃ< A
,
ЃЃA B
nullable
ЃЃC K
:
ЃЃK L
false
ЃЃM R
)
ЃЃR S
,
ЃЃS T
SubPermissionsId
‚‚ $
=
‚‚% &
table
‚‚' ,
.
‚‚, -
Column
‚‚- 3
<
‚‚3 4
int
‚‚4 7
>
‚‚7 8
(
‚‚8 9
type
‚‚9 =
:
‚‚= >
$str
‚‚? D
,
‚‚D E
nullable
‚‚F N
:
‚‚N O
false
‚‚P U
)
‚‚U V
,
‚‚V W
RoleId
ѓѓ 
=
ѓѓ 
table
ѓѓ "
.
ѓѓ" #
Column
ѓѓ# )
<
ѓѓ) *
string
ѓѓ* 0
>
ѓѓ0 1
(
ѓѓ1 2
type
ѓѓ2 6
:
ѓѓ6 7
$str
ѓѓ8 F
,
ѓѓF G
	maxLength
ѓѓH Q
:
ѓѓQ R
$num
ѓѓS U
,
ѓѓU V
nullable
ѓѓW _
:
ѓѓ_ `
false
ѓѓa f
)
ѓѓf g
,
ѓѓg h
ItemName
„„ 
=
„„ 
table
„„ $
.
„„$ %
Column
„„% +
<
„„+ ,
string
„„, 2
>
„„2 3
(
„„3 4
type
„„4 8
:
„„8 9
$str
„„: I
,
„„I J
	maxLength
„„K T
:
„„T U
$num
„„V Y
,
„„Y Z
nullable
„„[ c
:
„„c d
false
„„e j
)
„„j k
,
„„k l
NoAccess
…… 
=
…… 
table
…… $
.
……$ %
Column
……% +
<
……+ ,
bool
……, 0
>
……0 1
(
……1 2
type
……2 6
:
……6 7
$str
……8 =
,
……= >
nullable
……? G
:
……G H
false
……I N
)
……N O
,
……O P
Create
†† 
=
†† 
table
†† "
.
††" #
Column
††# )
<
††) *
bool
††* .
>
††. /
(
††/ 0
type
††0 4
:
††4 5
$str
††6 ;
,
††; <
nullable
††= E
:
††E F
false
††G L
)
††L M
,
††M N
Read
‡‡ 
=
‡‡ 
table
‡‡  
.
‡‡  !
Column
‡‡! '
<
‡‡' (
bool
‡‡( ,
>
‡‡, -
(
‡‡- .
type
‡‡. 2
:
‡‡2 3
$str
‡‡4 9
,
‡‡9 :
nullable
‡‡; C
:
‡‡C D
false
‡‡E J
)
‡‡J K
,
‡‡K L
Update
€€ 
=
€€ 
table
€€ "
.
€€" #
Column
€€# )
<
€€) *
bool
€€* .
>
€€. /
(
€€/ 0
type
€€0 4
:
€€4 5
$str
€€6 ;
,
€€; <
nullable
€€= E
:
€€E F
false
€€G L
)
€€L M
,
€€M N
Delete
‰‰ 
=
‰‰ 
table
‰‰ "
.
‰‰" #
Column
‰‰# )
<
‰‰) *
bool
‰‰* .
>
‰‰. /
(
‰‰/ 0
type
‰‰0 4
:
‰‰4 5
$str
‰‰6 ;
,
‰‰; <
nullable
‰‰= E
:
‰‰E F
false
‰‰G L
)
‰‰L M
,
‰‰M N
Approve
ЉЉ 
=
ЉЉ 
table
ЉЉ #
.
ЉЉ# $
Column
ЉЉ$ *
<
ЉЉ* +
bool
ЉЉ+ /
>
ЉЉ/ 0
(
ЉЉ0 1
type
ЉЉ1 5
:
ЉЉ5 6
$str
ЉЉ7 <
,
ЉЉ< =
nullable
ЉЉ> F
:
ЉЉF G
false
ЉЉH M
)
ЉЉM N
}
‹‹ 
,
‹‹ 
constraints
ЊЊ 
:
ЊЊ 
table
ЊЊ "
=>
ЊЊ# %
{
ЌЌ 
table
ЋЋ 
.
ЋЋ 

PrimaryKey
ЋЋ $
(
ЋЋ$ %
$str
ЋЋ% =
,
ЋЋ= >
x
ЋЋ? @
=>
ЋЋA C
x
ЋЋD E
.
ЋЋE F#
SubPermissionsItemsId
ЋЋF [
)
ЋЋ[ \
;
ЋЋ\ ]
}
ЏЏ 
)
ЏЏ 
;
ЏЏ 
migrationBuilder
‘‘ 
.
‘‘ 
CreateTable
‘‘ (
(
‘‘( )
name
’’ 
:
’’ 
$str
’’ "
,
’’" #
columns
““ 
:
““ 
table
““ 
=>
““ !
new
““" %
{
”” 
TokenStoreId
••  
=
••! "
table
••# (
.
••( )
Column
••) /
<
••/ 0
int
••0 3
>
••3 4
(
••4 5
type
••5 9
:
••9 :
$str
••; @
,
••@ A
nullable
••B J
:
••J K
false
••L Q
)
••Q R
.
–– 

Annotation
–– #
(
––# $
$str
––$ 8
,
––8 9
$str
––: @
)
––@ A
,
––A B
MobilePhoneNumber
—— %
=
——& '
table
——( -
.
——- .
Column
——. 4
<
——4 5
string
——5 ;
>
——; <
(
——< =
type
——= A
:
——A B
$str
——C Q
,
——Q R
	maxLength
——S \
:
——\ ]
$num
——^ `
,
——` a
nullable
——b j
:
——j k
true
——l p
)
——p q
,
——q r
EmailAddress
  
=
! "
table
# (
.
( )
Column
) /
<
/ 0
string
0 6
>
6 7
(
7 8
type
8 <
:
< =
$str
> L
,
L M
	maxLength
N W
:
W X
$num
Y [
,
[ \
nullable
] e
:
e f
true
g k
)
k l
,
l m
Token
™™ 
=
™™ 
table
™™ !
.
™™! "
Column
™™" (
<
™™( )
string
™™) /
>
™™/ 0
(
™™0 1
type
™™1 5
:
™™5 6
$str
™™7 E
,
™™E F
	maxLength
™™G P
:
™™P Q
$num
™™R T
,
™™T U
nullable
™™V ^
:
™™^ _
true
™™` d
)
™™d e
,
™™e f
CreatedDate
љљ 
=
љљ  !
table
љљ" '
.
љљ' (
Column
љљ( .
<
љљ. /
DateTime
љљ/ 7
>
љљ7 8
(
љљ8 9
type
љљ9 =
:
љљ= >
$str
љљ? J
,
љљJ K
nullable
љљL T
:
љљT U
false
љљV [
)
љљ[ \
,
љљ\ ]

ExpiryDate
›› 
=
››  
table
››! &
.
››& '
Column
››' -
<
››- .
DateTime
››. 6
>
››6 7
(
››7 8
type
››8 <
:
››< =
$str
››> I
,
››I J
nullable
››K S
:
››S T
false
››U Z
)
››Z [
,
››[ \

IsVerified
њњ 
=
њњ  
table
њњ! &
.
њњ& '
Column
њњ' -
<
њњ- .
bool
њњ. 2
>
њњ2 3
(
њњ3 4
type
њњ4 8
:
њњ8 9
$str
њњ: ?
,
њњ? @
nullable
њњA I
:
њњI J
false
њњK P
)
њњP Q
,
њњQ R
VerifiedDate
ќќ  
=
ќќ! "
table
ќќ# (
.
ќќ( )
Column
ќќ) /
<
ќќ/ 0
DateTime
ќќ0 8
>
ќќ8 9
(
ќќ9 :
type
ќќ: >
:
ќќ> ?
$str
ќќ@ K
,
ќќK L
nullable
ќќM U
:
ќќU V
false
ќќW \
)
ќќ\ ]
}
ћћ 
,
ћћ 
constraints
џџ 
:
џџ 
table
џџ "
=>
џџ# %
{
   
table
ЎЎ 
.
ЎЎ 

PrimaryKey
ЎЎ $
(
ЎЎ$ %
$str
ЎЎ% 4
,
ЎЎ4 5
x
ЎЎ6 7
=>
ЎЎ8 :
x
ЎЎ; <
.
ЎЎ< =
TokenStoreId
ЎЎ= I
)
ЎЎI J
;
ЎЎJ K
}
ўў 
)
ўў 
;
ўў 
migrationBuilder
¤¤ 
.
¤¤ 
CreateTable
¤¤ (
(
¤¤( )
name
ҐҐ 
:
ҐҐ 
$str
ҐҐ 
,
ҐҐ 
schema
¦¦ 
:
¦¦ 
$str
¦¦ 
,
¦¦ 
columns
§§ 
:
§§ 
table
§§ 
=>
§§ !
new
§§" %
{
ЁЁ 
Id
©© 
=
©© 
table
©© 
.
©© 
Column
©© %
<
©©% &
string
©©& ,
>
©©, -
(
©©- .
type
©©. 2
:
©©2 3
$str
©©4 C
,
©©C D
nullable
©©E M
:
©©M N
false
©©O T
)
©©T U
,
©©U V"
IdentificationNumber
ЄЄ (
=
ЄЄ) *
table
ЄЄ+ 0
.
ЄЄ0 1
Column
ЄЄ1 7
<
ЄЄ7 8
string
ЄЄ8 >
>
ЄЄ> ?
(
ЄЄ? @
type
ЄЄ@ D
:
ЄЄD E
$str
ЄЄF T
,
ЄЄT U
	maxLength
ЄЄV _
:
ЄЄ_ `
$num
ЄЄa c
,
ЄЄc d
nullable
ЄЄe m
:
ЄЄm n
true
ЄЄo s
)
ЄЄs t
,
ЄЄt u
	FirstName
«« 
=
«« 
table
««  %
.
««% &
Column
««& ,
<
««, -
string
««- 3
>
««3 4
(
««4 5
type
««5 9
:
««9 :
$str
««; I
,
««I J
	maxLength
««K T
:
««T U
$num
««V X
,
««X Y
nullable
««Z b
:
««b c
true
««d h
)
««h i
,
««i j

MiddleName
¬¬ 
=
¬¬  
table
¬¬! &
.
¬¬& '
Column
¬¬' -
<
¬¬- .
string
¬¬. 4
>
¬¬4 5
(
¬¬5 6
type
¬¬6 :
:
¬¬: ;
$str
¬¬< J
,
¬¬J K
	maxLength
¬¬L U
:
¬¬U V
$num
¬¬W Y
,
¬¬Y Z
nullable
¬¬[ c
:
¬¬c d
true
¬¬e i
)
¬¬i j
,
¬¬j k
LastName
­­ 
=
­­ 
table
­­ $
.
­­$ %
Column
­­% +
<
­­+ ,
string
­­, 2
>
­­2 3
(
­­3 4
type
­­4 8
:
­­8 9
$str
­­: I
,
­­I J
	maxLength
­­K T
:
­­T U
$num
­­V Y
,
­­Y Z
nullable
­­[ c
:
­­c d
true
­­e i
)
­­i j
,
­­j k
PartnerName
®® 
=
®®  !
table
®®" '
.
®®' (
Column
®®( .
<
®®. /
string
®®/ 5
>
®®5 6
(
®®6 7
type
®®7 ;
:
®®; <
$str
®®= L
,
®®L M
	maxLength
®®N W
:
®®W X
$num
®®Y \
,
®®\ ]
nullable
®®^ f
:
®®f g
true
®®h l
)
®®l m
,
®®m n
DepartmentId
ЇЇ  
=
ЇЇ! "
table
ЇЇ# (
.
ЇЇ( )
Column
ЇЇ) /
<
ЇЇ/ 0
int
ЇЇ0 3
>
ЇЇ3 4
(
ЇЇ4 5
type
ЇЇ5 9
:
ЇЇ9 :
$str
ЇЇ; @
,
ЇЇ@ A
nullable
ЇЇB J
:
ЇЇJ K
false
ЇЇL Q
)
ЇЇQ R
,
ЇЇR S
UnitId
°° 
=
°° 
table
°° "
.
°°" #
Column
°°# )
<
°°) *
int
°°* -
>
°°- .
(
°°. /
type
°°/ 3
:
°°3 4
$str
°°5 :
,
°°: ;
nullable
°°< D
:
°°D E
false
°°F K
)
°°K L
,
°°L M
ProfilePicture
±± "
=
±±# $
table
±±% *
.
±±* +
Column
±±+ 1
<
±±1 2
string
±±2 8
>
±±8 9
(
±±9 :
type
±±: >
:
±±> ?
$str
±±@ O
,
±±O P
	maxLength
±±Q Z
:
±±Z [
$num
±±\ _
,
±±_ `
nullable
±±a i
:
±±i j
true
±±k o
)
±±o p
,
±±p q
LastReceiptNumber
ІІ %
=
ІІ& '
table
ІІ( -
.
ІІ- .
Column
ІІ. 4
<
ІІ4 5
string
ІІ5 ;
>
ІІ; <
(
ІІ< =
type
ІІ= A
:
ІІA B
$str
ІІC Q
,
ІІQ R
	maxLength
ІІS \
:
ІІ\ ]
$num
ІІ^ `
,
ІІ` a
nullable
ІІb j
:
ІІj k
true
ІІl p
)
ІІp q
,
ІІq r
LastReceiptImage
іі $
=
іі% &
table
іі' ,
.
іі, -
Column
іі- 3
<
іі3 4
string
іі4 :
>
іі: ;
(
іі; <
type
іі< @
:
іі@ A
$str
ііB Q
,
ііQ R
	maxLength
ііS \
:
іі\ ]
$num
іі^ a
,
ііa b
nullable
ііc k
:
ііk l
true
ііm q
)
ііq r
,
ііr s"
IdentificationTypeId
ґґ (
=
ґґ) *
table
ґґ+ 0
.
ґґ0 1
Column
ґґ1 7
<
ґґ7 8
int
ґґ8 ;
>
ґґ; <
(
ґґ< =
type
ґґ= A
:
ґґA B
$str
ґґC H
,
ґґH I
nullable
ґґJ R
:
ґґR S
false
ґґT Y
)
ґґY Z
,
ґґZ [(
IdentificationUniqueNumber
µµ .
=
µµ/ 0
table
µµ1 6
.
µµ6 7
Column
µµ7 =
<
µµ= >
string
µµ> D
>
µµD E
(
µµE F
type
µµF J
:
µµJ K
$str
µµL Z
,
µµZ [
	maxLength
µµ\ e
:
µµe f
$num
µµg i
,
µµi j
nullable
µµk s
:
µµs t
true
µµu y
)
µµy z
,
µµz {!
IdentificationImage
¶¶ '
=
¶¶( )
table
¶¶* /
.
¶¶/ 0
Column
¶¶0 6
<
¶¶6 7
string
¶¶7 =
>
¶¶= >
(
¶¶> ?
type
¶¶? C
:
¶¶C D
$str
¶¶E T
,
¶¶T U
	maxLength
¶¶V _
:
¶¶_ `
$num
¶¶a d
,
¶¶d e
nullable
¶¶f n
:
¶¶n o
true
¶¶p t
)
¶¶t u
,
¶¶u v$
IdentificationImageOne
·· *
=
··+ ,
table
··- 2
.
··2 3
Column
··3 9
<
··9 :
string
··: @
>
··@ A
(
··A B
type
··B F
:
··F G
$str
··H W
,
··W X
	maxLength
··Y b
:
··b c
$num
··d g
,
··g h
nullable
··i q
:
··q r
true
··s w
)
··w x
,
··x y
SelfieImage
ёё 
=
ёё  !
table
ёё" '
.
ёё' (
Column
ёё( .
<
ёё. /
string
ёё/ 5
>
ёё5 6
(
ёё6 7
type
ёё7 ;
:
ёё; <
$str
ёё= L
,
ёёL M
	maxLength
ёёN W
:
ёёW X
$num
ёёY \
,
ёё\ ]
nullable
ёё^ f
:
ёёf g
true
ёёh l
)
ёёl m
,
ёёm n
PassportPicture
№№ #
=
№№$ %
table
№№& +
.
№№+ ,
Column
№№, 2
<
№№2 3
string
№№3 9
>
№№9 :
(
№№: ;
type
№№; ?
:
№№? @
$str
№№A P
,
№№P Q
	maxLength
№№R [
:
№№[ \
$num
№№] `
,
№№` a
nullable
№№b j
:
№№j k
true
№№l p
)
№№p q
,
№№q r
	ChannelId
єє 
=
єє 
table
єє  %
.
єє% &
Column
єє& ,
<
єє, -
int
єє- 0
>
єє0 1
(
єє1 2
type
єє2 6
:
єє6 7
$str
єє8 =
,
єє= >
nullable
єє? G
:
єєG H
false
єєI N
)
єєN O
,
єєO P
RegistrationDate
»» $
=
»»% &
table
»»' ,
.
»», -
Column
»»- 3
<
»»3 4
DateTime
»»4 <
>
»»< =
(
»»= >
type
»»> B
:
»»B C
$str
»»D O
,
»»O P
nullable
»»Q Y
:
»»Y Z
false
»»[ `
)
»»` a
,
»»a b
Status
јј 
=
јј 
table
јј "
.
јј" #
Column
јј# )
<
јј) *
int
јј* -
>
јј- .
(
јј. /
type
јј/ 3
:
јј3 4
$str
јј5 :
,
јј: ;
nullable
јј< D
:
јјD E
false
јјF K
)
јјK L
,
јјL M$
ContactPerson_FullName
ЅЅ *
=
ЅЅ+ ,
table
ЅЅ- 2
.
ЅЅ2 3
Column
ЅЅ3 9
<
ЅЅ9 :
string
ЅЅ: @
>
ЅЅ@ A
(
ЅЅA B
type
ЅЅB F
:
ЅЅF G
$str
ЅЅH W
,
ЅЅW X
	maxLength
ЅЅY b
:
ЅЅb c
$num
ЅЅd g
,
ЅЅg h
nullable
ЅЅi q
:
ЅЅq r
true
ЅЅs w
)
ЅЅw x
,
ЅЅx y!
ContactPerson_Email
ѕѕ '
=
ѕѕ( )
table
ѕѕ* /
.
ѕѕ/ 0
Column
ѕѕ0 6
<
ѕѕ6 7
string
ѕѕ7 =
>
ѕѕ= >
(
ѕѕ> ?
type
ѕѕ? C
:
ѕѕC D
$str
ѕѕE T
,
ѕѕT U
	maxLength
ѕѕV _
:
ѕѕ_ `
$num
ѕѕa d
,
ѕѕd e
nullable
ѕѕf n
:
ѕѕn o
true
ѕѕp t
)
ѕѕt u
,
ѕѕu v'
ContactPerson_PhoneNumber
її -
=
її. /
table
її0 5
.
її5 6
Column
її6 <
<
її< =
string
її= C
>
їїC D
(
їїD E
type
їїE I
:
їїI J
$str
їїK Y
,
їїY Z
	maxLength
її[ d
:
їїd e
$num
їїf h
,
їїh i
nullable
їїj r
:
їїr s
true
їїt x
)
їїx y
,
їїy z$
ContactPerson_Position
АА *
=
АА+ ,
table
АА- 2
.
АА2 3
Column
АА3 9
<
АА9 :
string
АА: @
>
АА@ A
(
ААA B
type
ААB F
:
ААF G
$str
ААH V
,
ААV W
	maxLength
ААX a
:
ААa b
$num
ААc e
,
ААe f
nullable
ААg o
:
ААo p
true
ААq u
)
ААu v
,
ААv w
	CreatedBy
ББ 
=
ББ 
table
ББ  %
.
ББ% &
Column
ББ& ,
<
ББ, -
string
ББ- 3
>
ББ3 4
(
ББ4 5
type
ББ5 9
:
ББ9 :
$str
ББ; I
,
ББI J
	maxLength
ББK T
:
ББT U
$num
ББV X
,
ББX Y
nullable
ББZ b
:
ББb c
true
ББd h
)
ББh i
,
ББi j
CreatedDate
ВВ 
=
ВВ  !
table
ВВ" '
.
ВВ' (
Column
ВВ( .
<
ВВ. /
DateTime
ВВ/ 7
>
ВВ7 8
(
ВВ8 9
type
ВВ9 =
:
ВВ= >
$str
ВВ? J
,
ВВJ K
nullable
ВВL T
:
ВВT U
false
ВВV [
)
ВВ[ \
,
ВВ\ ]

ModifiedBy
ГГ 
=
ГГ  
table
ГГ! &
.
ГГ& '
Column
ГГ' -
<
ГГ- .
string
ГГ. 4
>
ГГ4 5
(
ГГ5 6
type
ГГ6 :
:
ГГ: ;
$str
ГГ< J
,
ГГJ K
	maxLength
ГГL U
:
ГГU V
$num
ГГW Y
,
ГГY Z
nullable
ГГ[ c
:
ГГc d
true
ГГe i
)
ГГi j
,
ГГj k
ModifiedDate
ДД  
=
ДД! "
table
ДД# (
.
ДД( )
Column
ДД) /
<
ДД/ 0
DateTime
ДД0 8
>
ДД8 9
(
ДД9 :
type
ДД: >
:
ДД> ?
$str
ДД@ K
,
ДДK L
nullable
ДДM U
:
ДДU V
false
ДДW \
)
ДД\ ]
,
ДД] ^
	DeletedBy
ЕЕ 
=
ЕЕ 
table
ЕЕ  %
.
ЕЕ% &
Column
ЕЕ& ,
<
ЕЕ, -
string
ЕЕ- 3
>
ЕЕ3 4
(
ЕЕ4 5
type
ЕЕ5 9
:
ЕЕ9 :
$str
ЕЕ; I
,
ЕЕI J
	maxLength
ЕЕK T
:
ЕЕT U
$num
ЕЕV X
,
ЕЕX Y
nullable
ЕЕZ b
:
ЕЕb c
true
ЕЕd h
)
ЕЕh i
,
ЕЕi j
DeletedDate
ЖЖ 
=
ЖЖ  !
table
ЖЖ" '
.
ЖЖ' (
Column
ЖЖ( .
<
ЖЖ. /
DateTime
ЖЖ/ 7
>
ЖЖ7 8
(
ЖЖ8 9
type
ЖЖ9 =
:
ЖЖ= >
$str
ЖЖ? J
,
ЖЖJ K
nullable
ЖЖL T
:
ЖЖT U
false
ЖЖV [
)
ЖЖ[ \
,
ЖЖ\ ]

VerifiedBy
ЗЗ 
=
ЗЗ  
table
ЗЗ! &
.
ЗЗ& '
Column
ЗЗ' -
<
ЗЗ- .
string
ЗЗ. 4
>
ЗЗ4 5
(
ЗЗ5 6
type
ЗЗ6 :
:
ЗЗ: ;
$str
ЗЗ< J
,
ЗЗJ K
	maxLength
ЗЗL U
:
ЗЗU V
$num
ЗЗW Y
,
ЗЗY Z
nullable
ЗЗ[ c
:
ЗЗc d
true
ЗЗe i
)
ЗЗi j
,
ЗЗj k
VerifiedDate
ИИ  
=
ИИ! "
table
ИИ# (
.
ИИ( )
Column
ИИ) /
<
ИИ/ 0
DateTime
ИИ0 8
>
ИИ8 9
(
ИИ9 :
type
ИИ: >
:
ИИ> ?
$str
ИИ@ K
,
ИИK L
nullable
ИИM U
:
ИИU V
false
ИИW \
)
ИИ\ ]
,
ИИ] ^

RejectedBy
ЙЙ 
=
ЙЙ  
table
ЙЙ! &
.
ЙЙ& '
Column
ЙЙ' -
<
ЙЙ- .
string
ЙЙ. 4
>
ЙЙ4 5
(
ЙЙ5 6
type
ЙЙ6 :
:
ЙЙ: ;
$str
ЙЙ< J
,
ЙЙJ K
	maxLength
ЙЙL U
:
ЙЙU V
$num
ЙЙW Y
,
ЙЙY Z
nullable
ЙЙ[ c
:
ЙЙc d
true
ЙЙe i
)
ЙЙi j
,
ЙЙj k
RejectedDate
КК  
=
КК! "
table
КК# (
.
КК( )
Column
КК) /
<
КК/ 0
DateTime
КК0 8
>
КК8 9
(
КК9 :
type
КК: >
:
КК> ?
$str
КК@ K
,
ККK L
nullable
ККM U
:
ККU V
false
ККW \
)
КК\ ]
,
КК] ^
RejectedReasons
ЛЛ #
=
ЛЛ$ %
table
ЛЛ& +
.
ЛЛ+ ,
Column
ЛЛ, 2
<
ЛЛ2 3
string
ЛЛ3 9
>
ЛЛ9 :
(
ЛЛ: ;
type
ЛЛ; ?
:
ЛЛ? @
$str
ЛЛA P
,
ЛЛP Q
	maxLength
ЛЛR [
:
ЛЛ[ \
$num
ЛЛ] `
,
ЛЛ` a
nullable
ЛЛb j
:
ЛЛj k
true
ЛЛl p
)
ЛЛp q
,
ЛЛq r

ApprovedBy
ММ 
=
ММ  
table
ММ! &
.
ММ& '
Column
ММ' -
<
ММ- .
string
ММ. 4
>
ММ4 5
(
ММ5 6
type
ММ6 :
:
ММ: ;
$str
ММ< J
,
ММJ K
	maxLength
ММL U
:
ММU V
$num
ММW Y
,
ММY Z
nullable
ММ[ c
:
ММc d
true
ММe i
)
ММi j
,
ММj k
ApprovedDate
НН  
=
НН! "
table
НН# (
.
НН( )
Column
НН) /
<
НН/ 0
DateTime
НН0 8
>
НН8 9
(
НН9 :
type
НН: >
:
НН> ?
$str
НН@ K
,
ННK L
nullable
ННM U
:
ННU V
false
ННW \
)
НН\ ]
,
НН] ^
DisapprovedBy
ОО !
=
ОО" #
table
ОО$ )
.
ОО) *
Column
ОО* 0
<
ОО0 1
string
ОО1 7
>
ОО7 8
(
ОО8 9
type
ОО9 =
:
ОО= >
$str
ОО? M
,
ООM N
	maxLength
ООO X
:
ООX Y
$num
ООZ \
,
ОО\ ]
nullable
ОО^ f
:
ООf g
true
ООh l
)
ООl m
,
ООm n
DisapprovedDate
ПП #
=
ПП$ %
table
ПП& +
.
ПП+ ,
Column
ПП, 2
<
ПП2 3
DateTime
ПП3 ;
>
ПП; <
(
ПП< =
type
ПП= A
:
ППA B
$str
ППC N
,
ППN O
nullable
ППP X
:
ППX Y
false
ППZ _
)
ПП_ `
,
ПП` a 
DisapprovedReasons
РР &
=
РР' (
table
РР) .
.
РР. /
Column
РР/ 5
<
РР5 6
string
РР6 <
>
РР< =
(
РР= >
type
РР> B
:
РРB C
$str
РРD S
,
РРS T
	maxLength
РРU ^
:
РР^ _
$num
РР` c
,
РРc d
nullable
РРe m
:
РРm n
true
РРo s
)
РРs t
,
РРt u
ActivatedBy
СС 
=
СС  !
table
СС" '
.
СС' (
Column
СС( .
<
СС. /
string
СС/ 5
>
СС5 6
(
СС6 7
type
СС7 ;
:
СС; <
$str
СС= K
,
ССK L
	maxLength
ССM V
:
ССV W
$num
ССX Z
,
ССZ [
nullable
СС\ d
:
ССd e
true
ССf j
)
ССj k
,
ССk l
ActivatedDate
ТТ !
=
ТТ" #
table
ТТ$ )
.
ТТ) *
Column
ТТ* 0
<
ТТ0 1
DateTime
ТТ1 9
>
ТТ9 :
(
ТТ: ;
type
ТТ; ?
:
ТТ? @
$str
ТТA L
,
ТТL M
nullable
ТТN V
:
ТТV W
false
ТТX ]
)
ТТ] ^
,
ТТ^ _
DeactivatedBy
УУ !
=
УУ" #
table
УУ$ )
.
УУ) *
Column
УУ* 0
<
УУ0 1
string
УУ1 7
>
УУ7 8
(
УУ8 9
type
УУ9 =
:
УУ= >
$str
УУ? M
,
УУM N
	maxLength
УУO X
:
УУX Y
$num
УУZ \
,
УУ\ ]
nullable
УУ^ f
:
УУf g
true
УУh l
)
УУl m
,
УУm n
DeactivatedDate
ФФ #
=
ФФ$ %
table
ФФ& +
.
ФФ+ ,
Column
ФФ, 2
<
ФФ2 3
DateTime
ФФ3 ;
>
ФФ; <
(
ФФ< =
type
ФФ= A
:
ФФA B
$str
ФФC N
,
ФФN O
nullable
ФФP X
:
ФФX Y
false
ФФZ _
)
ФФ_ `
,
ФФ` a 
DeactivatedReasons
ХХ &
=
ХХ' (
table
ХХ) .
.
ХХ. /
Column
ХХ/ 5
<
ХХ5 6
string
ХХ6 <
>
ХХ< =
(
ХХ= >
type
ХХ> B
:
ХХB C
$str
ХХD S
,
ХХS T
	maxLength
ХХU ^
:
ХХ^ _
$num
ХХ` c
,
ХХc d
nullable
ХХe m
:
ХХm n
true
ХХo s
)
ХХs t
,
ХХt u

FirebaseId
ЦЦ 
=
ЦЦ  
table
ЦЦ! &
.
ЦЦ& '
Column
ЦЦ' -
<
ЦЦ- .
string
ЦЦ. 4
>
ЦЦ4 5
(
ЦЦ5 6
type
ЦЦ6 :
:
ЦЦ: ;
$str
ЦЦ< K
,
ЦЦK L
	maxLength
ЦЦM V
:
ЦЦV W
$num
ЦЦX [
,
ЦЦ[ \
nullable
ЦЦ] e
:
ЦЦe f
true
ЦЦg k
)
ЦЦk l
,
ЦЦl m
IsFirstTime
ЧЧ 
=
ЧЧ  !
table
ЧЧ" '
.
ЧЧ' (
Column
ЧЧ( .
<
ЧЧ. /
bool
ЧЧ/ 3
>
ЧЧ3 4
(
ЧЧ4 5
type
ЧЧ5 9
:
ЧЧ9 :
$str
ЧЧ; @
,
ЧЧ@ A
nullable
ЧЧB J
:
ЧЧJ K
false
ЧЧL Q
)
ЧЧQ R
,
ЧЧR S
UserType
ШШ 
=
ШШ 
table
ШШ $
.
ШШ$ %
Column
ШШ% +
<
ШШ+ ,
int
ШШ, /
>
ШШ/ 0
(
ШШ0 1
type
ШШ1 5
:
ШШ5 6
$str
ШШ7 <
,
ШШ< =
nullable
ШШ> F
:
ШШF G
false
ШШH M
)
ШШM N
,
ШШN O
RefreshToken
ЩЩ  
=
ЩЩ! "
table
ЩЩ# (
.
ЩЩ( )
Column
ЩЩ) /
<
ЩЩ/ 0
string
ЩЩ0 6
>
ЩЩ6 7
(
ЩЩ7 8
type
ЩЩ8 <
:
ЩЩ< =
$str
ЩЩ> M
,
ЩЩM N
nullable
ЩЩO W
:
ЩЩW X
true
ЩЩY ]
)
ЩЩ] ^
,
ЩЩ^ _!
RefreshTokenExpires
ЪЪ '
=
ЪЪ( )
table
ЪЪ* /
.
ЪЪ/ 0
Column
ЪЪ0 6
<
ЪЪ6 7
DateTime
ЪЪ7 ?
>
ЪЪ? @
(
ЪЪ@ A
type
ЪЪA E
:
ЪЪE F
$str
ЪЪG R
,
ЪЪR S
nullable
ЪЪT \
:
ЪЪ\ ]
false
ЪЪ^ c
)
ЪЪc d
,
ЪЪd e
UserName
ЫЫ 
=
ЫЫ 
table
ЫЫ $
.
ЫЫ$ %
Column
ЫЫ% +
<
ЫЫ+ ,
string
ЫЫ, 2
>
ЫЫ2 3
(
ЫЫ3 4
type
ЫЫ4 8
:
ЫЫ8 9
$str
ЫЫ: I
,
ЫЫI J
	maxLength
ЫЫK T
:
ЫЫT U
$num
ЫЫV Y
,
ЫЫY Z
nullable
ЫЫ[ c
:
ЫЫc d
true
ЫЫe i
)
ЫЫi j
,
ЫЫj k 
NormalizedUserName
ЬЬ &
=
ЬЬ' (
table
ЬЬ) .
.
ЬЬ. /
Column
ЬЬ/ 5
<
ЬЬ5 6
string
ЬЬ6 <
>
ЬЬ< =
(
ЬЬ= >
type
ЬЬ> B
:
ЬЬB C
$str
ЬЬD S
,
ЬЬS T
	maxLength
ЬЬU ^
:
ЬЬ^ _
$num
ЬЬ` c
,
ЬЬc d
nullable
ЬЬe m
:
ЬЬm n
true
ЬЬo s
)
ЬЬs t
,
ЬЬt u
Email
ЭЭ 
=
ЭЭ 
table
ЭЭ !
.
ЭЭ! "
Column
ЭЭ" (
<
ЭЭ( )
string
ЭЭ) /
>
ЭЭ/ 0
(
ЭЭ0 1
type
ЭЭ1 5
:
ЭЭ5 6
$str
ЭЭ7 F
,
ЭЭF G
	maxLength
ЭЭH Q
:
ЭЭQ R
$num
ЭЭS V
,
ЭЭV W
nullable
ЭЭX `
:
ЭЭ` a
true
ЭЭb f
)
ЭЭf g
,
ЭЭg h
NormalizedEmail
ЮЮ #
=
ЮЮ$ %
table
ЮЮ& +
.
ЮЮ+ ,
Column
ЮЮ, 2
<
ЮЮ2 3
string
ЮЮ3 9
>
ЮЮ9 :
(
ЮЮ: ;
type
ЮЮ; ?
:
ЮЮ? @
$str
ЮЮA P
,
ЮЮP Q
	maxLength
ЮЮR [
:
ЮЮ[ \
$num
ЮЮ] `
,
ЮЮ` a
nullable
ЮЮb j
:
ЮЮj k
true
ЮЮl p
)
ЮЮp q
,
ЮЮq r
EmailConfirmed
ЯЯ "
=
ЯЯ# $
table
ЯЯ% *
.
ЯЯ* +
Column
ЯЯ+ 1
<
ЯЯ1 2
bool
ЯЯ2 6
>
ЯЯ6 7
(
ЯЯ7 8
type
ЯЯ8 <
:
ЯЯ< =
$str
ЯЯ> C
,
ЯЯC D
nullable
ЯЯE M
:
ЯЯM N
false
ЯЯO T
)
ЯЯT U
,
ЯЯU V
PasswordHash
аа  
=
аа! "
table
аа# (
.
аа( )
Column
аа) /
<
аа/ 0
string
аа0 6
>
аа6 7
(
аа7 8
type
аа8 <
:
аа< =
$str
аа> M
,
ааM N
nullable
ааO W
:
ааW X
true
ааY ]
)
аа] ^
,
аа^ _
SecurityStamp
бб !
=
бб" #
table
бб$ )
.
бб) *
Column
бб* 0
<
бб0 1
string
бб1 7
>
бб7 8
(
бб8 9
type
бб9 =
:
бб= >
$str
бб? N
,
ббN O
nullable
ббP X
:
ббX Y
true
ббZ ^
)
бб^ _
,
бб_ `
ConcurrencyStamp
вв $
=
вв% &
table
вв' ,
.
вв, -
Column
вв- 3
<
вв3 4
string
вв4 :
>
вв: ;
(
вв; <
type
вв< @
:
вв@ A
$str
ввB Q
,
ввQ R
nullable
ввS [
:
вв[ \
true
вв] a
)
ввa b
,
ввb c
PhoneNumber
гг 
=
гг  !
table
гг" '
.
гг' (
Column
гг( .
<
гг. /
string
гг/ 5
>
гг5 6
(
гг6 7
type
гг7 ;
:
гг; <
$str
гг= L
,
ггL M
nullable
ггN V
:
ггV W
true
ггX \
)
гг\ ]
,
гг] ^"
PhoneNumberConfirmed
дд (
=
дд) *
table
дд+ 0
.
дд0 1
Column
дд1 7
<
дд7 8
bool
дд8 <
>
дд< =
(
дд= >
type
дд> B
:
ддB C
$str
ддD I
,
ддI J
nullable
ддK S
:
ддS T
false
ддU Z
)
ддZ [
,
дд[ \
TwoFactorEnabled
ее $
=
ее% &
table
ее' ,
.
ее, -
Column
ее- 3
<
ее3 4
bool
ее4 8
>
ее8 9
(
ее9 :
type
ее: >
:
ее> ?
$str
ее@ E
,
ееE F
nullable
ееG O
:
ееO P
false
ееQ V
)
ееV W
,
ееW X

LockoutEnd
жж 
=
жж  
table
жж! &
.
жж& '
Column
жж' -
<
жж- .
DateTimeOffset
жж. <
>
жж< =
(
жж= >
type
жж> B
:
жжB C
$str
жжD T
,
жжT U
nullable
жжV ^
:
жж^ _
true
жж` d
)
жжd e
,
жжe f
LockoutEnabled
зз "
=
зз# $
table
зз% *
.
зз* +
Column
зз+ 1
<
зз1 2
bool
зз2 6
>
зз6 7
(
зз7 8
type
зз8 <
:
зз< =
$str
зз> C
,
ззC D
nullable
ззE M
:
ззM N
false
ззO T
)
ззT U
,
ззU V
AccessFailedCount
ии %
=
ии& '
table
ии( -
.
ии- .
Column
ии. 4
<
ии4 5
int
ии5 8
>
ии8 9
(
ии9 :
type
ии: >
:
ии> ?
$str
ии@ E
,
ииE F
nullable
ииG O
:
ииO P
false
ииQ V
)
ииV W
}
йй 
,
йй 
constraints
кк 
:
кк 
table
кк "
=>
кк# %
{
лл 
table
мм 
.
мм 

PrimaryKey
мм $
(
мм$ %
$str
мм% /
,
мм/ 0
x
мм1 2
=>
мм3 5
x
мм6 7
.
мм7 8
Id
мм8 :
)
мм: ;
;
мм; <
}
нн 
)
нн 
;
нн 
migrationBuilder
пп 
.
пп 
CreateTable
пп (
(
пп( )
name
рр 
:
рр 
$str
рр "
,
рр" #
schema
сс 
:
сс 
$str
сс 
,
сс 
columns
тт 
:
тт 
table
тт 
=>
тт !
new
тт" %
{
уу 
Id
фф 
=
фф 
table
фф 
.
фф 
Column
фф %
<
фф% &
int
фф& )
>
фф) *
(
фф* +
type
фф+ /
:
фф/ 0
$str
фф1 6
,
фф6 7
nullable
фф8 @
:
фф@ A
false
ффB G
)
ффG H
.
хх 

Annotation
хх #
(
хх# $
$str
хх$ 8
,
хх8 9
$str
хх: @
)
хх@ A
,
ххA B
RoleId
цц 
=
цц 
table
цц "
.
цц" #
Column
цц# )
<
цц) *
string
цц* 0
>
цц0 1
(
цц1 2
type
цц2 6
:
цц6 7
$str
цц8 G
,
ццG H
nullable
ццI Q
:
ццQ R
false
ццS X
)
ццX Y
,
ццY Z
	ClaimType
чч 
=
чч 
table
чч  %
.
чч% &
Column
чч& ,
<
чч, -
string
чч- 3
>
чч3 4
(
чч4 5
type
чч5 9
:
чч9 :
$str
чч; J
,
ччJ K
nullable
ччL T
:
ччT U
true
ччV Z
)
ччZ [
,
чч[ \

ClaimValue
шш 
=
шш  
table
шш! &
.
шш& '
Column
шш' -
<
шш- .
string
шш. 4
>
шш4 5
(
шш5 6
type
шш6 :
:
шш: ;
$str
шш< K
,
шшK L
nullable
шшM U
:
шшU V
true
шшW [
)
шш[ \
}
щщ 
,
щщ 
constraints
ъъ 
:
ъъ 
table
ъъ "
=>
ъъ# %
{
ыы 
table
ьь 
.
ьь 

PrimaryKey
ьь $
(
ьь$ %
$str
ьь% 4
,
ьь4 5
x
ьь6 7
=>
ьь8 :
x
ьь; <
.
ьь< =
Id
ьь= ?
)
ьь? @
;
ьь@ A
table
ээ 
.
ээ 

ForeignKey
ээ $
(
ээ$ %
name
юю 
:
юю 
$str
юю :
,
юю: ;
column
яя 
:
яя 
x
яя  !
=>
яя" $
x
яя% &
.
яя& '
RoleId
яя' -
,
яя- .
principalSchema
ЂЂ '
:
ЂЂ' (
$str
ЂЂ) .
,
ЂЂ. /
principalTable
ЃЃ &
:
ЃЃ& '
$str
ЃЃ( /
,
ЃЃ/ 0
principalColumn
‚‚ '
:
‚‚' (
$str
‚‚) -
,
‚‚- .
onDelete
ѓѓ  
:
ѓѓ  !
ReferentialAction
ѓѓ" 3
.
ѓѓ3 4
Cascade
ѓѓ4 ;
)
ѓѓ; <
;
ѓѓ< =
}
„„ 
)
„„ 
;
„„ 
migrationBuilder
†† 
.
†† 
CreateTable
†† (
(
††( )
name
‡‡ 
:
‡‡ 
$str
‡‡ "
,
‡‡" #
schema
€€ 
:
€€ 
$str
€€ 
,
€€ 
columns
‰‰ 
:
‰‰ 
table
‰‰ 
=>
‰‰ !
new
‰‰" %
{
ЉЉ 
Id
‹‹ 
=
‹‹ 
table
‹‹ 
.
‹‹ 
Column
‹‹ %
<
‹‹% &
int
‹‹& )
>
‹‹) *
(
‹‹* +
type
‹‹+ /
:
‹‹/ 0
$str
‹‹1 6
,
‹‹6 7
nullable
‹‹8 @
:
‹‹@ A
false
‹‹B G
)
‹‹G H
.
ЊЊ 

Annotation
ЊЊ #
(
ЊЊ# $
$str
ЊЊ$ 8
,
ЊЊ8 9
$str
ЊЊ: @
)
ЊЊ@ A
,
ЊЊA B
UserId
ЌЌ 
=
ЌЌ 
table
ЌЌ "
.
ЌЌ" #
Column
ЌЌ# )
<
ЌЌ) *
string
ЌЌ* 0
>
ЌЌ0 1
(
ЌЌ1 2
type
ЌЌ2 6
:
ЌЌ6 7
$str
ЌЌ8 G
,
ЌЌG H
nullable
ЌЌI Q
:
ЌЌQ R
false
ЌЌS X
)
ЌЌX Y
,
ЌЌY Z
	ClaimType
ЋЋ 
=
ЋЋ 
table
ЋЋ  %
.
ЋЋ% &
Column
ЋЋ& ,
<
ЋЋ, -
string
ЋЋ- 3
>
ЋЋ3 4
(
ЋЋ4 5
type
ЋЋ5 9
:
ЋЋ9 :
$str
ЋЋ; J
,
ЋЋJ K
nullable
ЋЋL T
:
ЋЋT U
true
ЋЋV Z
)
ЋЋZ [
,
ЋЋ[ \

ClaimValue
ЏЏ 
=
ЏЏ  
table
ЏЏ! &
.
ЏЏ& '
Column
ЏЏ' -
<
ЏЏ- .
string
ЏЏ. 4
>
ЏЏ4 5
(
ЏЏ5 6
type
ЏЏ6 :
:
ЏЏ: ;
$str
ЏЏ< K
,
ЏЏK L
nullable
ЏЏM U
:
ЏЏU V
true
ЏЏW [
)
ЏЏ[ \
}
ђђ 
,
ђђ 
constraints
‘‘ 
:
‘‘ 
table
‘‘ "
=>
‘‘# %
{
’’ 
table
““ 
.
““ 

PrimaryKey
““ $
(
““$ %
$str
““% 4
,
““4 5
x
““6 7
=>
““8 :
x
““; <
.
““< =
Id
““= ?
)
““? @
;
““@ A
table
”” 
.
”” 

ForeignKey
”” $
(
””$ %
name
•• 
:
•• 
$str
•• :
,
••: ;
column
–– 
:
–– 
x
––  !
=>
––" $
x
––% &
.
––& '
UserId
––' -
,
––- .
principalSchema
—— '
:
——' (
$str
——) .
,
——. /
principalTable
 &
:
& '
$str
( /
,
/ 0
principalColumn
™™ '
:
™™' (
$str
™™) -
,
™™- .
onDelete
љљ  
:
љљ  !
ReferentialAction
љљ" 3
.
љљ3 4
Cascade
љљ4 ;
)
љљ; <
;
љљ< =
}
›› 
)
›› 
;
›› 
migrationBuilder
ќќ 
.
ќќ 
CreateTable
ќќ (
(
ќќ( )
name
ћћ 
:
ћћ 
$str
ћћ "
,
ћћ" #
schema
џџ 
:
џџ 
$str
џџ 
,
џџ 
columns
   
:
   
table
   
=>
   !
new
  " %
{
ЎЎ 
LoginProvider
ўў !
=
ўў" #
table
ўў$ )
.
ўў) *
Column
ўў* 0
<
ўў0 1
string
ўў1 7
>
ўў7 8
(
ўў8 9
type
ўў9 =
:
ўў= >
$str
ўў? N
,
ўўN O
nullable
ўўP X
:
ўўX Y
false
ўўZ _
)
ўў_ `
,
ўў` a
ProviderKey
ЈЈ 
=
ЈЈ  !
table
ЈЈ" '
.
ЈЈ' (
Column
ЈЈ( .
<
ЈЈ. /
string
ЈЈ/ 5
>
ЈЈ5 6
(
ЈЈ6 7
type
ЈЈ7 ;
:
ЈЈ; <
$str
ЈЈ= L
,
ЈЈL M
nullable
ЈЈN V
:
ЈЈV W
false
ЈЈX ]
)
ЈЈ] ^
,
ЈЈ^ _!
ProviderDisplayName
¤¤ '
=
¤¤( )
table
¤¤* /
.
¤¤/ 0
Column
¤¤0 6
<
¤¤6 7
string
¤¤7 =
>
¤¤= >
(
¤¤> ?
type
¤¤? C
:
¤¤C D
$str
¤¤E T
,
¤¤T U
nullable
¤¤V ^
:
¤¤^ _
true
¤¤` d
)
¤¤d e
,
¤¤e f
UserId
ҐҐ 
=
ҐҐ 
table
ҐҐ "
.
ҐҐ" #
Column
ҐҐ# )
<
ҐҐ) *
string
ҐҐ* 0
>
ҐҐ0 1
(
ҐҐ1 2
type
ҐҐ2 6
:
ҐҐ6 7
$str
ҐҐ8 G
,
ҐҐG H
nullable
ҐҐI Q
:
ҐҐQ R
false
ҐҐS X
)
ҐҐX Y
}
¦¦ 
,
¦¦ 
constraints
§§ 
:
§§ 
table
§§ "
=>
§§# %
{
ЁЁ 
table
©© 
.
©© 

PrimaryKey
©© $
(
©©$ %
$str
©©% 4
,
©©4 5
x
©©6 7
=>
©©8 :
new
©©; >
{
©©? @
x
©©A B
.
©©B C
LoginProvider
©©C P
,
©©P Q
x
©©R S
.
©©S T
ProviderKey
©©T _
}
©©` a
)
©©a b
;
©©b c
table
ЄЄ 
.
ЄЄ 

ForeignKey
ЄЄ $
(
ЄЄ$ %
name
«« 
:
«« 
$str
«« :
,
««: ;
column
¬¬ 
:
¬¬ 
x
¬¬  !
=>
¬¬" $
x
¬¬% &
.
¬¬& '
UserId
¬¬' -
,
¬¬- .
principalSchema
­­ '
:
­­' (
$str
­­) .
,
­­. /
principalTable
®® &
:
®®& '
$str
®®( /
,
®®/ 0
principalColumn
ЇЇ '
:
ЇЇ' (
$str
ЇЇ) -
,
ЇЇ- .
onDelete
°°  
:
°°  !
ReferentialAction
°°" 3
.
°°3 4
Cascade
°°4 ;
)
°°; <
;
°°< =
}
±± 
)
±± 
;
±± 
migrationBuilder
іі 
.
іі 
CreateTable
іі (
(
іі( )
name
ґґ 
:
ґґ 
$str
ґґ !
,
ґґ! "
schema
µµ 
:
µµ 
$str
µµ 
,
µµ 
columns
¶¶ 
:
¶¶ 
table
¶¶ 
=>
¶¶ !
new
¶¶" %
{
·· 
UserId
ёё 
=
ёё 
table
ёё "
.
ёё" #
Column
ёё# )
<
ёё) *
string
ёё* 0
>
ёё0 1
(
ёё1 2
type
ёё2 6
:
ёё6 7
$str
ёё8 G
,
ёёG H
nullable
ёёI Q
:
ёёQ R
false
ёёS X
)
ёёX Y
,
ёёY Z
RoleId
№№ 
=
№№ 
table
№№ "
.
№№" #
Column
№№# )
<
№№) *
string
№№* 0
>
№№0 1
(
№№1 2
type
№№2 6
:
№№6 7
$str
№№8 G
,
№№G H
nullable
№№I Q
:
№№Q R
false
№№S X
)
№№X Y
,
№№Y Z

AssignedOn
єє 
=
єє  
table
єє! &
.
єє& '
Column
єє' -
<
єє- .
DateTime
єє. 6
>
єє6 7
(
єє7 8
type
єє8 <
:
єє< =
$str
єє> I
,
єєI J
nullable
єєK S
:
єєS T
false
єєU Z
)
єєZ [
,
єє[ \

AssignedBy
»» 
=
»»  
table
»»! &
.
»»& '
Column
»»' -
<
»»- .
string
»». 4
>
»»4 5
(
»»5 6
type
»»6 :
:
»»: ;
$str
»»< K
,
»»K L
nullable
»»M U
:
»»U V
true
»»W [
)
»»[ \
,
»»\ ]

ModifiedOn
јј 
=
јј  
table
јј! &
.
јј& '
Column
јј' -
<
јј- .
DateTime
јј. 6
>
јј6 7
(
јј7 8
type
јј8 <
:
јј< =
$str
јј> I
,
јјI J
nullable
јјK S
:
јјS T
false
јјU Z
)
јјZ [
,
јј[ \

ModifiedBy
ЅЅ 
=
ЅЅ  
table
ЅЅ! &
.
ЅЅ& '
Column
ЅЅ' -
<
ЅЅ- .
string
ЅЅ. 4
>
ЅЅ4 5
(
ЅЅ5 6
type
ЅЅ6 :
:
ЅЅ: ;
$str
ЅЅ< K
,
ЅЅK L
nullable
ЅЅM U
:
ЅЅU V
true
ЅЅW [
)
ЅЅ[ \
,
ЅЅ\ ]

ApprovedOn
ѕѕ 
=
ѕѕ  
table
ѕѕ! &
.
ѕѕ& '
Column
ѕѕ' -
<
ѕѕ- .
DateTime
ѕѕ. 6
>
ѕѕ6 7
(
ѕѕ7 8
type
ѕѕ8 <
:
ѕѕ< =
$str
ѕѕ> I
,
ѕѕI J
nullable
ѕѕK S
:
ѕѕS T
false
ѕѕU Z
)
ѕѕZ [
,
ѕѕ[ \

ApprovedBy
її 
=
її  
table
її! &
.
її& '
Column
її' -
<
її- .
string
її. 4
>
її4 5
(
її5 6
type
її6 :
:
її: ;
$str
її< K
,
їїK L
nullable
їїM U
:
їїU V
true
їїW [
)
її[ \
,
її\ ]
Status
АА 
=
АА 
table
АА "
.
АА" #
Column
АА# )
<
АА) *
short
АА* /
>
АА/ 0
(
АА0 1
type
АА1 5
:
АА5 6
$str
АА7 A
,
ААA B
nullable
ААC K
:
ААK L
false
ААM R
)
ААR S
}
ББ 
,
ББ 
constraints
ВВ 
:
ВВ 
table
ВВ "
=>
ВВ# %
{
ГГ 
table
ДД 
.
ДД 

PrimaryKey
ДД $
(
ДД$ %
$str
ДД% 3
,
ДД3 4
x
ДД5 6
=>
ДД7 9
new
ДД: =
{
ДД> ?
x
ДД@ A
.
ДДA B
UserId
ДДB H
,
ДДH I
x
ДДJ K
.
ДДK L
RoleId
ДДL R
}
ДДS T
)
ДДT U
;
ДДU V
table
ЕЕ 
.
ЕЕ 

ForeignKey
ЕЕ $
(
ЕЕ$ %
name
ЖЖ 
:
ЖЖ 
$str
ЖЖ 9
,
ЖЖ9 :
column
ЗЗ 
:
ЗЗ 
x
ЗЗ  !
=>
ЗЗ" $
x
ЗЗ% &
.
ЗЗ& '
RoleId
ЗЗ' -
,
ЗЗ- .
principalSchema
ИИ '
:
ИИ' (
$str
ИИ) .
,
ИИ. /
principalTable
ЙЙ &
:
ЙЙ& '
$str
ЙЙ( /
,
ЙЙ/ 0
principalColumn
КК '
:
КК' (
$str
КК) -
,
КК- .
onDelete
ЛЛ  
:
ЛЛ  !
ReferentialAction
ЛЛ" 3
.
ЛЛ3 4
Cascade
ЛЛ4 ;
)
ЛЛ; <
;
ЛЛ< =
table
ММ 
.
ММ 

ForeignKey
ММ $
(
ММ$ %
name
НН 
:
НН 
$str
НН 9
,
НН9 :
column
ОО 
:
ОО 
x
ОО  !
=>
ОО" $
x
ОО% &
.
ОО& '
UserId
ОО' -
,
ОО- .
principalSchema
ПП '
:
ПП' (
$str
ПП) .
,
ПП. /
principalTable
РР &
:
РР& '
$str
РР( /
,
РР/ 0
principalColumn
СС '
:
СС' (
$str
СС) -
,
СС- .
onDelete
ТТ  
:
ТТ  !
ReferentialAction
ТТ" 3
.
ТТ3 4
Cascade
ТТ4 ;
)
ТТ; <
;
ТТ< =
}
УУ 
)
УУ 
;
УУ 
migrationBuilder
ХХ 
.
ХХ 
CreateTable
ХХ (
(
ХХ( )
name
ЦЦ 
:
ЦЦ 
$str
ЦЦ "
,
ЦЦ" #
schema
ЧЧ 
:
ЧЧ 
$str
ЧЧ 
,
ЧЧ 
columns
ШШ 
:
ШШ 
table
ШШ 
=>
ШШ !
new
ШШ" %
{
ЩЩ 
UserId
ЪЪ 
=
ЪЪ 
table
ЪЪ "
.
ЪЪ" #
Column
ЪЪ# )
<
ЪЪ) *
string
ЪЪ* 0
>
ЪЪ0 1
(
ЪЪ1 2
type
ЪЪ2 6
:
ЪЪ6 7
$str
ЪЪ8 G
,
ЪЪG H
nullable
ЪЪI Q
:
ЪЪQ R
false
ЪЪS X
)
ЪЪX Y
,
ЪЪY Z
LoginProvider
ЫЫ !
=
ЫЫ" #
table
ЫЫ$ )
.
ЫЫ) *
Column
ЫЫ* 0
<
ЫЫ0 1
string
ЫЫ1 7
>
ЫЫ7 8
(
ЫЫ8 9
type
ЫЫ9 =
:
ЫЫ= >
$str
ЫЫ? N
,
ЫЫN O
nullable
ЫЫP X
:
ЫЫX Y
false
ЫЫZ _
)
ЫЫ_ `
,
ЫЫ` a
Name
ЬЬ 
=
ЬЬ 
table
ЬЬ  
.
ЬЬ  !
Column
ЬЬ! '
<
ЬЬ' (
string
ЬЬ( .
>
ЬЬ. /
(
ЬЬ/ 0
type
ЬЬ0 4
:
ЬЬ4 5
$str
ЬЬ6 E
,
ЬЬE F
nullable
ЬЬG O
:
ЬЬO P
false
ЬЬQ V
)
ЬЬV W
,
ЬЬW X
Value
ЭЭ 
=
ЭЭ 
table
ЭЭ !
.
ЭЭ! "
Column
ЭЭ" (
<
ЭЭ( )
string
ЭЭ) /
>
ЭЭ/ 0
(
ЭЭ0 1
type
ЭЭ1 5
:
ЭЭ5 6
$str
ЭЭ7 F
,
ЭЭF G
nullable
ЭЭH P
:
ЭЭP Q
true
ЭЭR V
)
ЭЭV W
}
ЮЮ 
,
ЮЮ 
constraints
ЯЯ 
:
ЯЯ 
table
ЯЯ "
=>
ЯЯ# %
{
аа 
table
бб 
.
бб 

PrimaryKey
бб $
(
бб$ %
$str
бб% 4
,
бб4 5
x
бб6 7
=>
бб8 :
new
бб; >
{
бб? @
x
ббA B
.
ббB C
UserId
ббC I
,
ббI J
x
ббK L
.
ббL M
LoginProvider
ббM Z
,
ббZ [
x
бб\ ]
.
бб] ^
Name
бб^ b
}
ббc d
)
ббd e
;
ббe f
table
вв 
.
вв 

ForeignKey
вв $
(
вв$ %
name
гг 
:
гг 
$str
гг :
,
гг: ;
column
дд 
:
дд 
x
дд  !
=>
дд" $
x
дд% &
.
дд& '
UserId
дд' -
,
дд- .
principalSchema
ее '
:
ее' (
$str
ее) .
,
ее. /
principalTable
жж &
:
жж& '
$str
жж( /
,
жж/ 0
principalColumn
зз '
:
зз' (
$str
зз) -
,
зз- .
onDelete
ии  
:
ии  !
ReferentialAction
ии" 3
.
ии3 4
Cascade
ии4 ;
)
ии; <
;
ии< =
}
йй 
)
йй 
;
йй 
migrationBuilder
лл 
.
лл 

InsertData
лл '
(
лл' (
table
мм 
:
мм 
$str
мм !
,
мм! "
columns
нн 
:
нн 
new
нн 
[
нн 
]
нн 
{
нн  
$str
нн! ,
,
нн, -
$str
нн. ;
,
нн; <
$str
нн= H
,
ннH I
$str
ннJ U
,
ннU V
$str
ннW b
,
ннb c
$str
ннd o
,
ннo p
$str
ннq }
,
нн} ~
$strнн ‹
}ннЊ Ќ
,ннЌ Ћ
values
оо 
:
оо 
new
оо 
object
оо "
[
оо" #
,
оо# $
]
оо$ %
{
пп 
{
рр 
$num
рр 
,
рр 
$str
рр  
,
рр  !
null
рр" &
,
рр& '
new
рр( +
DateTime
рр, 4
(
рр4 5
$num
рр5 6
,
рр6 7
$num
рр8 9
,
рр9 :
$num
рр; <
,
рр< =
$num
рр> ?
,
рр? @
$num
ррA B
,
ррB C
$num
ррD E
,
ррE F
$num
ррG H
,
ррH I
DateTimeKind
ррJ V
.
ррV W
Unspecified
ррW b
)
ррb c
,
ррc d
null
ррe i
,
ррi j
new
ррk n
DateTime
ррo w
(
ррw x
$num
ррx y
,
ррy z
$num
рр{ |
,
рр| }
$num
рр~ 
,рр Ђ
$numррЃ ‚
,рр‚ ѓ
$numрр„ …
,рр… †
$numрр‡ €
,рр€ ‰
$numррЉ ‹
,рр‹ Њ
DateTimeKindррЌ ™
.рр™ љ
Unspecifiedррљ Ґ
)ррҐ ¦
,рр¦ §
nullррЁ ¬
,рр¬ ­
newрр® ±
DateTimeррІ є
(ррє »
$numрр» ј
,ррј Ѕ
$numррѕ ї
,ррї А
$numррБ В
,ррВ Г
$numррД Е
,ррЕ Ж
$numррЗ И
,ррИ Й
$numррК Л
,ррЛ М
$numррН О
,ррО П
DateTimeKindррР Ь
.ррЬ Э
UnspecifiedррЭ и
)рри й
}ррк л
,ррл м
{
сс 
$num
сс 
,
сс 
$str
сс #
,
сс# $
null
сс% )
,
сс) *
new
сс+ .
DateTime
сс/ 7
(
сс7 8
$num
сс8 9
,
сс9 :
$num
сс; <
,
сс< =
$num
сс> ?
,
сс? @
$num
ссA B
,
ссB C
$num
ссD E
,
ссE F
$num
ссG H
,
ссH I
$num
ссJ K
,
ссK L
DateTimeKind
ссM Y
.
ссY Z
Unspecified
ссZ e
)
ссe f
,
ссf g
null
ссh l
,
ссl m
new
ссn q
DateTime
ссr z
(
ссz {
$num
сс{ |
,
сс| }
$num
сс~ 
,сс Ђ
$numссЃ ‚
,сс‚ ѓ
$numсс„ …
,сс… †
$numсс‡ €
,сс€ ‰
$numссЉ ‹
,сс‹ Њ
$numссЌ Ћ
,ссЋ Џ
DateTimeKindссђ њ
.ссњ ќ
Unspecifiedссќ Ё
)ссЁ ©
,сс© Є
nullсс« Ї
,ссЇ °
newсс± ґ
DateTimeссµ Ѕ
(ссЅ ѕ
$numссѕ ї
,ссї А
$numссБ В
,ссВ Г
$numссД Е
,ссЕ Ж
$numссЗ И
,ссИ Й
$numссК Л
,ссЛ М
$numссН О
,ссО П
$numссР С
,ссС Т
DateTimeKindссУ Я
.ссЯ а
Unspecifiedсса л
)ссл м
}ссн о
}
тт 
)
тт 
;
тт 
migrationBuilder
фф 
.
фф 

InsertData
фф '
(
фф' (
table
хх 
:
хх 
$str
хх #
,
хх# $
columns
цц 
:
цц 
new
цц 
[
цц 
]
цц 
{
цц  
$str
цц! /
,
цц/ 0
$str
цц1 <
,
цц< =
$str
цц> I
,
ццI J
$str
ццK V
,
ццV W
$str
ццX c
,
ццc d
$str
ццe u
,
ццu v
$strццw ѓ
,ццѓ „
$strцц… ‘
}цц’ “
,цц“ ”
values
чч 
:
чч 
new
чч 
object
чч "
[
чч" #
,
чч# $
]
чч$ %
{
шш 
{
щщ 
$num
щщ 
,
щщ 
null
щщ 
,
щщ  
new
щщ! $
DateTime
щщ% -
(
щщ- .
$num
щщ. /
,
щщ/ 0
$num
щщ1 2
,
щщ2 3
$num
щщ4 5
,
щщ5 6
$num
щщ7 8
,
щщ8 9
$num
щщ: ;
,
щщ; <
$num
щщ= >
,
щщ> ?
$num
щщ@ A
,
щщA B
DateTimeKind
щщC O
.
щщO P
Unspecified
щщP [
)
щщ[ \
,
щщ\ ]
null
щщ^ b
,
щщb c
new
щщd g
DateTime
щщh p
(
щщp q
$num
щщq r
,
щщr s
$num
щщt u
,
щщu v
$num
щщw x
,
щщx y
$num
щщz {
,
щщ{ |
$num
щщ} ~
,
щщ~ 
$numщщЂ Ѓ
,щщЃ ‚
$numщщѓ „
,щщ„ …
DateTimeKindщщ† ’
.щщ’ “
Unspecifiedщщ“ ћ
)щщћ џ
,щщџ  
$strщщЎ Є
,щщЄ «
nullщщ¬ °
,щщ° ±
newщщІ µ
DateTimeщщ¶ ѕ
(щщѕ ї
$numщщї А
,щщА Б
$numщщВ Г
,щщГ Д
$numщщЕ Ж
,щщЖ З
$numщщИ Й
,щщЙ К
$numщщЛ М
,щщМ Н
$numщщО П
,щщП Р
$numщщС Т
,щщТ У
DateTimeKindщщФ а
.щща б
Unspecifiedщщб м
)щщм н
}щщо п
,щщп р
{
ъъ 
$num
ъъ 
,
ъъ 
null
ъъ 
,
ъъ  
new
ъъ! $
DateTime
ъъ% -
(
ъъ- .
$num
ъъ. /
,
ъъ/ 0
$num
ъъ1 2
,
ъъ2 3
$num
ъъ4 5
,
ъъ5 6
$num
ъъ7 8
,
ъъ8 9
$num
ъъ: ;
,
ъъ; <
$num
ъъ= >
,
ъъ> ?
$num
ъъ@ A
,
ъъA B
DateTimeKind
ъъC O
.
ъъO P
Unspecified
ъъP [
)
ъъ[ \
,
ъъ\ ]
null
ъъ^ b
,
ъъb c
new
ъъd g
DateTime
ъъh p
(
ъъp q
$num
ъъq r
,
ъъr s
$num
ъъt u
,
ъъu v
$num
ъъw x
,
ъъx y
$num
ъъz {
,
ъъ{ |
$num
ъъ} ~
,
ъъ~ 
$numъъЂ Ѓ
,ъъЃ ‚
$numъъѓ „
,ъъ„ …
DateTimeKindъъ† ’
.ъъ’ “
Unspecifiedъъ“ ћ
)ъъћ џ
,ъъџ  
$strъъЎ Є
,ъъЄ «
nullъъ¬ °
,ъъ° ±
newъъІ µ
DateTimeъъ¶ ѕ
(ъъѕ ї
$numъъї А
,ъъА Б
$numъъВ Г
,ъъГ Д
$numъъЕ Ж
,ъъЖ З
$numъъИ Й
,ъъЙ К
$numъъЛ М
,ъъМ Н
$numъъО П
,ъъП Р
$numъъС Т
,ъъТ У
DateTimeKindъъФ а
.ъъа б
Unspecifiedъъб м
)ъъм н
}ъъо п
}
ыы 
)
ыы 
;
ыы 
migrationBuilder
ээ 
.
ээ 

InsertData
ээ '
(
ээ' (
table
юю 
:
юю 
$str
юю '
,
юю' (
columns
яя 
:
яя 
new
яя 
[
яя 
]
яя 
{
яя  
$str
яя! )
,
яя) *
$str
яя+ 6
,
яя6 7
$str
яя8 C
,
яяC D
$str
яяE P
,
яяP Q
$str
яяR ]
,
яя] ^
$str
яя_ m
,
яяm n
$str
яяo {
,
яя{ |
$strяя} ‰
,яя‰ Љ
$strяя‹ •
}яя– —
,яя— 
values
ЂЂ 
:
ЂЂ 
new
ЂЂ 
object
ЂЂ "
[
ЂЂ" #
,
ЂЂ# $
]
ЂЂ$ %
{
ЃЃ 
{
‚‚ 
$num
‚‚ 
,
‚‚ 
null
‚‚ 
,
‚‚  
new
‚‚! $
DateTime
‚‚% -
(
‚‚- .
$num
‚‚. /
,
‚‚/ 0
$num
‚‚1 2
,
‚‚2 3
$num
‚‚4 5
,
‚‚5 6
$num
‚‚7 8
,
‚‚8 9
$num
‚‚: ;
,
‚‚; <
$num
‚‚= >
,
‚‚> ?
$num
‚‚@ A
,
‚‚A B
DateTimeKind
‚‚C O
.
‚‚O P
Unspecified
‚‚P [
)
‚‚[ \
,
‚‚\ ]
null
‚‚^ b
,
‚‚b c
new
‚‚d g
DateTime
‚‚h p
(
‚‚p q
$num
‚‚q r
,
‚‚r s
$num
‚‚t u
,
‚‚u v
$num
‚‚w x
,
‚‚x y
$num
‚‚z {
,
‚‚{ |
$num
‚‚} ~
,
‚‚~ 
$num‚‚Ђ Ѓ
,‚‚Ѓ ‚
$num‚‚ѓ „
,‚‚„ …
DateTimeKind‚‚† ’
.‚‚’ “
Unspecified‚‚“ ћ
)‚‚ћ џ
,‚‚џ  
$num‚‚Ў ¤
,‚‚¤ Ґ
null‚‚¦ Є
,‚‚Є «
new‚‚¬ Ї
DateTime‚‚° ё
(‚‚ё №
$num‚‚№ є
,‚‚є »
$num‚‚ј Ѕ
,‚‚Ѕ ѕ
$num‚‚ї А
,‚‚А Б
$num‚‚В Г
,‚‚Г Д
$num‚‚Е Ж
,‚‚Ж З
$num‚‚И Й
,‚‚Й К
$num‚‚Л М
,‚‚М Н
DateTimeKind‚‚О Ъ
.‚‚Ъ Ы
Unspecified‚‚Ы ж
)‚‚ж з
,‚‚з и
$str‚‚й р
}‚‚с т
,‚‚т у
{
ѓѓ 
$num
ѓѓ 
,
ѓѓ 
null
ѓѓ 
,
ѓѓ  
new
ѓѓ! $
DateTime
ѓѓ% -
(
ѓѓ- .
$num
ѓѓ. /
,
ѓѓ/ 0
$num
ѓѓ1 2
,
ѓѓ2 3
$num
ѓѓ4 5
,
ѓѓ5 6
$num
ѓѓ7 8
,
ѓѓ8 9
$num
ѓѓ: ;
,
ѓѓ; <
$num
ѓѓ= >
,
ѓѓ> ?
$num
ѓѓ@ A
,
ѓѓA B
DateTimeKind
ѓѓC O
.
ѓѓO P
Unspecified
ѓѓP [
)
ѓѓ[ \
,
ѓѓ\ ]
null
ѓѓ^ b
,
ѓѓb c
new
ѓѓd g
DateTime
ѓѓh p
(
ѓѓp q
$num
ѓѓq r
,
ѓѓr s
$num
ѓѓt u
,
ѓѓu v
$num
ѓѓw x
,
ѓѓx y
$num
ѓѓz {
,
ѓѓ{ |
$num
ѓѓ} ~
,
ѓѓ~ 
$numѓѓЂ Ѓ
,ѓѓЃ ‚
$numѓѓѓ „
,ѓѓ„ …
DateTimeKindѓѓ† ’
.ѓѓ’ “
Unspecifiedѓѓ“ ћ
)ѓѓћ џ
,ѓѓџ  
$numѓѓЎ ¤
,ѓѓ¤ Ґ
nullѓѓ¦ Є
,ѓѓЄ «
newѓѓ¬ Ї
DateTimeѓѓ° ё
(ѓѓё №
$numѓѓ№ є
,ѓѓє »
$numѓѓј Ѕ
,ѓѓЅ ѕ
$numѓѓї А
,ѓѓА Б
$numѓѓВ Г
,ѓѓГ Д
$numѓѓЕ Ж
,ѓѓЖ З
$numѓѓИ Й
,ѓѓЙ К
$numѓѓЛ М
,ѓѓМ Н
DateTimeKindѓѓО Ъ
.ѓѓЪ Ы
UnspecifiedѓѓЫ ж
)ѓѓж з
,ѓѓз и
$strѓѓй т
}ѓѓу ф
,ѓѓф х
{
„„ 
$num
„„ 
,
„„ 
null
„„ 
,
„„  
new
„„! $
DateTime
„„% -
(
„„- .
$num
„„. /
,
„„/ 0
$num
„„1 2
,
„„2 3
$num
„„4 5
,
„„5 6
$num
„„7 8
,
„„8 9
$num
„„: ;
,
„„; <
$num
„„= >
,
„„> ?
$num
„„@ A
,
„„A B
DateTimeKind
„„C O
.
„„O P
Unspecified
„„P [
)
„„[ \
,
„„\ ]
null
„„^ b
,
„„b c
new
„„d g
DateTime
„„h p
(
„„p q
$num
„„q r
,
„„r s
$num
„„t u
,
„„u v
$num
„„w x
,
„„x y
$num
„„z {
,
„„{ |
$num
„„} ~
,
„„~ 
$num„„Ђ Ѓ
,„„Ѓ ‚
$num„„ѓ „
,„„„ …
DateTimeKind„„† ’
.„„’ “
Unspecified„„“ ћ
)„„ћ џ
,„„џ  
$num„„Ў ¤
,„„¤ Ґ
null„„¦ Є
,„„Є «
new„„¬ Ї
DateTime„„° ё
(„„ё №
$num„„№ є
,„„є »
$num„„ј Ѕ
,„„Ѕ ѕ
$num„„ї А
,„„А Б
$num„„В Г
,„„Г Д
$num„„Е Ж
,„„Ж З
$num„„И Й
,„„Й К
$num„„Л М
,„„М Н
DateTimeKind„„О Ъ
.„„Ъ Ы
Unspecified„„Ы ж
)„„ж з
,„„з и
$str„„й ф
}„„х ц
,„„ц ч
{
…… 
$num
…… 
,
…… 
null
…… 
,
……  
new
……! $
DateTime
……% -
(
……- .
$num
……. /
,
……/ 0
$num
……1 2
,
……2 3
$num
……4 5
,
……5 6
$num
……7 8
,
……8 9
$num
……: ;
,
……; <
$num
……= >
,
……> ?
$num
……@ A
,
……A B
DateTimeKind
……C O
.
……O P
Unspecified
……P [
)
……[ \
,
……\ ]
null
……^ b
,
……b c
new
……d g
DateTime
……h p
(
……p q
$num
……q r
,
……r s
$num
……t u
,
……u v
$num
……w x
,
……x y
$num
……z {
,
……{ |
$num
……} ~
,
……~ 
$num……Ђ Ѓ
,……Ѓ ‚
$num……ѓ „
,……„ …
DateTimeKind……† ’
.……’ “
Unspecified……“ ћ
)……ћ џ
,……џ  
$num……Ў ¤
,……¤ Ґ
null……¦ Є
,……Є «
new……¬ Ї
DateTime……° ё
(……ё №
$num……№ є
,……є »
$num……ј Ѕ
,……Ѕ ѕ
$num……ї А
,……А Б
$num……В Г
,……Г Д
$num……Е Ж
,……Ж З
$num……И Й
,……Й К
$num……Л М
,……М Н
DateTimeKind……О Ъ
.……Ъ Ы
Unspecified……Ы ж
)……ж з
,……з и
$str……й х
}……ц ч
,……ч ш
{
†† 
$num
†† 
,
†† 
null
†† 
,
††  
new
††! $
DateTime
††% -
(
††- .
$num
††. /
,
††/ 0
$num
††1 2
,
††2 3
$num
††4 5
,
††5 6
$num
††7 8
,
††8 9
$num
††: ;
,
††; <
$num
††= >
,
††> ?
$num
††@ A
,
††A B
DateTimeKind
††C O
.
††O P
Unspecified
††P [
)
††[ \
,
††\ ]
null
††^ b
,
††b c
new
††d g
DateTime
††h p
(
††p q
$num
††q r
,
††r s
$num
††t u
,
††u v
$num
††w x
,
††x y
$num
††z {
,
††{ |
$num
††} ~
,
††~ 
$num††Ђ Ѓ
,††Ѓ ‚
$num††ѓ „
,††„ …
DateTimeKind††† ’
.††’ “
Unspecified††“ ћ
)††ћ џ
,††џ  
$num††Ў ¤
,††¤ Ґ
null††¦ Є
,††Є «
new††¬ Ї
DateTime††° ё
(††ё №
$num††№ є
,††є »
$num††ј Ѕ
,††Ѕ ѕ
$num††ї А
,††А Б
$num††В Г
,††Г Д
$num††Е Ж
,††Ж З
$num††И Й
,††Й К
$num††Л М
,††М Н
DateTimeKind††О Ъ
.††Ъ Ы
Unspecified††Ы ж
)††ж з
,††з и
$str††й т
}††у ф
,††ф х
{
‡‡ 
$num
‡‡ 
,
‡‡ 
null
‡‡ 
,
‡‡  
new
‡‡! $
DateTime
‡‡% -
(
‡‡- .
$num
‡‡. /
,
‡‡/ 0
$num
‡‡1 2
,
‡‡2 3
$num
‡‡4 5
,
‡‡5 6
$num
‡‡7 8
,
‡‡8 9
$num
‡‡: ;
,
‡‡; <
$num
‡‡= >
,
‡‡> ?
$num
‡‡@ A
,
‡‡A B
DateTimeKind
‡‡C O
.
‡‡O P
Unspecified
‡‡P [
)
‡‡[ \
,
‡‡\ ]
null
‡‡^ b
,
‡‡b c
new
‡‡d g
DateTime
‡‡h p
(
‡‡p q
$num
‡‡q r
,
‡‡r s
$num
‡‡t u
,
‡‡u v
$num
‡‡w x
,
‡‡x y
$num
‡‡z {
,
‡‡{ |
$num
‡‡} ~
,
‡‡~ 
$num‡‡Ђ Ѓ
,‡‡Ѓ ‚
$num‡‡ѓ „
,‡‡„ …
DateTimeKind‡‡† ’
.‡‡’ “
Unspecified‡‡“ ћ
)‡‡ћ џ
,‡‡џ  
$num‡‡Ў ¤
,‡‡¤ Ґ
null‡‡¦ Є
,‡‡Є «
new‡‡¬ Ї
DateTime‡‡° ё
(‡‡ё №
$num‡‡№ є
,‡‡є »
$num‡‡ј Ѕ
,‡‡Ѕ ѕ
$num‡‡ї А
,‡‡А Б
$num‡‡В Г
,‡‡Г Д
$num‡‡Е Ж
,‡‡Ж З
$num‡‡И Й
,‡‡Й К
$num‡‡Л М
,‡‡М Н
DateTimeKind‡‡О Ъ
.‡‡Ъ Ы
Unspecified‡‡Ы ж
)‡‡ж з
,‡‡з и
$str‡‡й р
}‡‡с т
,‡‡т у
{
€€ 
$num
€€ 
,
€€ 
null
€€ 
,
€€  
new
€€! $
DateTime
€€% -
(
€€- .
$num
€€. /
,
€€/ 0
$num
€€1 2
,
€€2 3
$num
€€4 5
,
€€5 6
$num
€€7 8
,
€€8 9
$num
€€: ;
,
€€; <
$num
€€= >
,
€€> ?
$num
€€@ A
,
€€A B
DateTimeKind
€€C O
.
€€O P
Unspecified
€€P [
)
€€[ \
,
€€\ ]
null
€€^ b
,
€€b c
new
€€d g
DateTime
€€h p
(
€€p q
$num
€€q r
,
€€r s
$num
€€t u
,
€€u v
$num
€€w x
,
€€x y
$num
€€z {
,
€€{ |
$num
€€} ~
,
€€~ 
$num€€Ђ Ѓ
,€€Ѓ ‚
$num€€ѓ „
,€€„ …
DateTimeKind€€† ’
.€€’ “
Unspecified€€“ ћ
)€€ћ џ
,€€џ  
$num€€Ў ¤
,€€¤ Ґ
null€€¦ Є
,€€Є «
new€€¬ Ї
DateTime€€° ё
(€€ё №
$num€€№ є
,€€є »
$num€€ј Ѕ
,€€Ѕ ѕ
$num€€ї А
,€€А Б
$num€€В Г
,€€Г Д
$num€€Е Ж
,€€Ж З
$num€€И Й
,€€Й К
$num€€Л М
,€€М Н
DateTimeKind€€О Ъ
.€€Ъ Ы
Unspecified€€Ы ж
)€€ж з
,€€з и
$str€€й с
}€€т у
,€€у ф
{
‰‰ 
$num
‰‰ 
,
‰‰ 
null
‰‰ 
,
‰‰  
new
‰‰! $
DateTime
‰‰% -
(
‰‰- .
$num
‰‰. /
,
‰‰/ 0
$num
‰‰1 2
,
‰‰2 3
$num
‰‰4 5
,
‰‰5 6
$num
‰‰7 8
,
‰‰8 9
$num
‰‰: ;
,
‰‰; <
$num
‰‰= >
,
‰‰> ?
$num
‰‰@ A
,
‰‰A B
DateTimeKind
‰‰C O
.
‰‰O P
Unspecified
‰‰P [
)
‰‰[ \
,
‰‰\ ]
null
‰‰^ b
,
‰‰b c
new
‰‰d g
DateTime
‰‰h p
(
‰‰p q
$num
‰‰q r
,
‰‰r s
$num
‰‰t u
,
‰‰u v
$num
‰‰w x
,
‰‰x y
$num
‰‰z {
,
‰‰{ |
$num
‰‰} ~
,
‰‰~ 
$num‰‰Ђ Ѓ
,‰‰Ѓ ‚
$num‰‰ѓ „
,‰‰„ …
DateTimeKind‰‰† ’
.‰‰’ “
Unspecified‰‰“ ћ
)‰‰ћ џ
,‰‰џ  
$num‰‰Ў ¤
,‰‰¤ Ґ
null‰‰¦ Є
,‰‰Є «
new‰‰¬ Ї
DateTime‰‰° ё
(‰‰ё №
$num‰‰№ є
,‰‰є »
$num‰‰ј Ѕ
,‰‰Ѕ ѕ
$num‰‰ї А
,‰‰А Б
$num‰‰В Г
,‰‰Г Д
$num‰‰Е Ж
,‰‰Ж З
$num‰‰И Й
,‰‰Й К
$num‰‰Л М
,‰‰М Н
DateTimeKind‰‰О Ъ
.‰‰Ъ Ы
Unspecified‰‰Ы ж
)‰‰ж з
,‰‰з и
$str‰‰й р
}‰‰с т
}
ЉЉ 
)
ЉЉ 
;
ЉЉ 
migrationBuilder
ЊЊ 
.
ЊЊ 
CreateIndex
ЊЊ (
(
ЊЊ( )
name
ЌЌ 
:
ЌЌ 
$str
ЌЌ A
,
ЌЌA B
table
ЋЋ 
:
ЋЋ 
$str
ЋЋ +
,
ЋЋ+ ,
columns
ЏЏ 
:
ЏЏ 
new
ЏЏ 
[
ЏЏ 
]
ЏЏ 
{
ЏЏ  
$str
ЏЏ! +
,
ЏЏ+ ,
$str
ЏЏ- 9
}
ЏЏ: ;
,
ЏЏ; <
unique
ђђ 
:
ђђ 
true
ђђ 
,
ђђ 
filter
‘‘ 
:
‘‘ 
$str
‘‘ 2
)
‘‘2 3
;
‘‘3 4
migrationBuilder
““ 
.
““ 
CreateIndex
““ (
(
““( )
name
”” 
:
”” 
$str
”” /
,
””/ 0
table
•• 
:
•• 
$str
•• !
,
••! "
column
–– 
:
–– 
$str
–– %
,
––% &
unique
—— 
:
—— 
true
—— 
)
—— 
;
—— 
migrationBuilder
™™ 
.
™™ 
CreateIndex
™™ (
(
™™( )
name
љљ 
:
љљ 
$str
љљ 4
,
љљ4 5
table
›› 
:
›› 
$str
›› #
,
››# $
column
њњ 
:
њњ 
$str
њњ (
,
њњ( )
unique
ќќ 
:
ќќ 
true
ќќ 
)
ќќ 
;
ќќ 
migrationBuilder
џџ 
.
џџ 
CreateIndex
џџ (
(
џџ( )
name
   
:
   
$str
   2
,
  2 3
table
ЎЎ 
:
ЎЎ 
$str
ЎЎ '
,
ЎЎ' (
column
ўў 
:
ўў 
$str
ўў "
,
ўў" #
unique
ЈЈ 
:
ЈЈ 
true
ЈЈ 
)
ЈЈ 
;
ЈЈ 
migrationBuilder
ҐҐ 
.
ҐҐ 
CreateIndex
ҐҐ (
(
ҐҐ( )
name
¦¦ 
:
¦¦ 
$str
¦¦ V
,
¦¦V W
table
§§ 
:
§§ 
$str
§§ +
,
§§+ ,
columns
ЁЁ 
:
ЁЁ 
new
ЁЁ 
[
ЁЁ 
]
ЁЁ 
{
ЁЁ  
$str
ЁЁ! 7
,
ЁЁ7 8
$str
ЁЁ9 N
}
ЁЁO P
,
ЁЁP Q
unique
©© 
:
©© 
true
©© 
)
©© 
;
©© 
migrationBuilder
«« 
.
«« 
CreateIndex
«« (
(
««( )
name
¬¬ 
:
¬¬ 
$str
¬¬ )
,
¬¬) *
table
­­ 
:
­­ 
$str
­­ 
,
­­ 
column
®® 
:
®® 
$str
®® "
,
®®" #
unique
ЇЇ 
:
ЇЇ 
true
ЇЇ 
)
ЇЇ 
;
ЇЇ 
migrationBuilder
±± 
.
±± 
CreateIndex
±± (
(
±±( )
name
ІІ 
:
ІІ 
$str
ІІ ,
,
ІІ, -
schema
іі 
:
іі 
$str
іі 
,
іі 
table
ґґ 
:
ґґ 
$str
ґґ #
,
ґґ# $
column
µµ 
:
µµ 
$str
µµ  
)
µµ  !
;
µµ! "
migrationBuilder
·· 
.
·· 
CreateIndex
·· (
(
··( )
name
ёё 
:
ёё 
$str
ёё %
,
ёё% &
schema
№№ 
:
№№ 
$str
№№ 
,
№№ 
table
єє 
:
єє 
$str
єє 
,
єє 
column
»» 
:
»» 
$str
»» (
,
»»( )
unique
јј 
:
јј 
true
јј 
,
јј 
filter
ЅЅ 
:
ЅЅ 
$str
ЅЅ 6
)
ЅЅ6 7
;
ЅЅ7 8
migrationBuilder
її 
.
її 
CreateIndex
її (
(
її( )
name
АА 
:
АА 
$str
АА 7
,
АА7 8
table
ББ 
:
ББ 
$str
ББ %
,
ББ% &
column
ВВ 
:
ВВ 
$str
ВВ )
,
ВВ) *
unique
ГГ 
:
ГГ 
true
ГГ 
)
ГГ 
;
ГГ 
migrationBuilder
ЕЕ 
.
ЕЕ 
CreateIndex
ЕЕ (
(
ЕЕ( )
name
ЖЖ 
:
ЖЖ 
$str
ЖЖ +
,
ЖЖ+ ,
table
ЗЗ 
:
ЗЗ 
$str
ЗЗ #
,
ЗЗ# $
column
ИИ 
:
ИИ 
$str
ИИ 
,
ИИ  
unique
ЙЙ 
:
ЙЙ 
true
ЙЙ 
,
ЙЙ 
filter
КК 
:
КК 
$str
КК -
)
КК- .
;
КК. /
migrationBuilder
ММ 
.
ММ 
CreateIndex
ММ (
(
ММ( )
name
НН 
:
НН 
$str
НН ,
,
НН, -
schema
ОО 
:
ОО 
$str
ОО 
,
ОО 
table
ПП 
:
ПП 
$str
ПП #
,
ПП# $
column
РР 
:
РР 
$str
РР  
)
РР  !
;
РР! "
migrationBuilder
ТТ 
.
ТТ 
CreateIndex
ТТ (
(
ТТ( )
name
УУ 
:
УУ 
$str
УУ ,
,
УУ, -
schema
ФФ 
:
ФФ 
$str
ФФ 
,
ФФ 
table
ХХ 
:
ХХ 
$str
ХХ #
,
ХХ# $
column
ЦЦ 
:
ЦЦ 
$str
ЦЦ  
)
ЦЦ  !
;
ЦЦ! "
migrationBuilder
ШШ 
.
ШШ 
CreateIndex
ШШ (
(
ШШ( )
name
ЩЩ 
:
ЩЩ 
$str
ЩЩ +
,
ЩЩ+ ,
schema
ЪЪ 
:
ЪЪ 
$str
ЪЪ 
,
ЪЪ 
table
ЫЫ 
:
ЫЫ 
$str
ЫЫ "
,
ЫЫ" #
column
ЬЬ 
:
ЬЬ 
$str
ЬЬ  
)
ЬЬ  !
;
ЬЬ! "
migrationBuilder
ЮЮ 
.
ЮЮ 
CreateIndex
ЮЮ (
(
ЮЮ( )
name
ЯЯ 
:
ЯЯ 
$str
ЯЯ "
,
ЯЯ" #
schema
аа 
:
аа 
$str
аа 
,
аа 
table
бб 
:
бб 
$str
бб 
,
бб 
column
вв 
:
вв 
$str
вв )
)
вв) *
;
вв* +
migrationBuilder
дд 
.
дд 
CreateIndex
дд (
(
дд( )
name
ее 
:
ее 
$str
ее %
,
ее% &
schema
жж 
:
жж 
$str
жж 
,
жж 
table
зз 
:
зз 
$str
зз 
,
зз 
column
ии 
:
ии 
$str
ии ,
,
ии, -
unique
йй 
:
йй 
true
йй 
,
йй 
filter
кк 
:
кк 
$str
кк :
)
кк: ;
;
кк; <
}
лл 	
	protected
оо 
override
оо 
void
оо 
Down
оо  $
(
оо$ %
MigrationBuilder
оо% 5
migrationBuilder
оо6 F
)
ооF G
{
пп 	
migrationBuilder
рр 
.
рр 
	DropTable
рр &
(
рр& '
name
сс 
:
сс 
$str
сс *
)
сс* +
;
сс+ ,
migrationBuilder
уу 
.
уу 
	DropTable
уу &
(
уу& '
name
фф 
:
фф 
$str
фф 5
)
фф5 6
;
фф6 7
migrationBuilder
цц 
.
цц 
	DropTable
цц &
(
цц& '
name
чч 
:
чч 
$str
чч  
)
чч  !
;
чч! "
migrationBuilder
щщ 
.
щщ 
	DropTable
щщ &
(
щщ& '
name
ъъ 
:
ъъ 
$str
ъъ "
)
ъъ" #
;
ъъ# $
migrationBuilder
ьь 
.
ьь 
	DropTable
ьь &
(
ьь& '
name
ээ 
:
ээ 
$str
ээ &
)
ээ& '
;
ээ' (
migrationBuilder
яя 
.
яя 
	DropTable
яя &
(
яя& '
name
ЂЂ 
:
ЂЂ 
$str
ЂЂ *
)
ЂЂ* +
;
ЂЂ+ ,
migrationBuilder
‚‚ 
.
‚‚ 
	DropTable
‚‚ &
(
‚‚& '
name
ѓѓ 
:
ѓѓ 
$str
ѓѓ 
)
ѓѓ 
;
ѓѓ 
migrationBuilder
…… 
.
…… 
	DropTable
…… &
(
……& '
name
†† 
:
†† 
$str
†† #
)
††# $
;
††$ %
migrationBuilder
€€ 
.
€€ 
	DropTable
€€ &
(
€€& '
name
‰‰ 
:
‰‰ 
$str
‰‰ "
,
‰‰" #
schema
ЉЉ 
:
ЉЉ 
$str
ЉЉ 
)
ЉЉ 
;
ЉЉ 
migrationBuilder
ЊЊ 
.
ЊЊ 
	DropTable
ЊЊ &
(
ЊЊ& '
name
ЌЌ 
:
ЌЌ 
$str
ЌЌ %
)
ЌЌ% &
;
ЌЌ& '
migrationBuilder
ЏЏ 
.
ЏЏ 
	DropTable
ЏЏ &
(
ЏЏ& '
name
ђђ 
:
ђђ 
$str
ђђ $
)
ђђ$ %
;
ђђ% &
migrationBuilder
’’ 
.
’’ 
	DropTable
’’ &
(
’’& '
name
““ 
:
““ 
$str
““  
)
““  !
;
““! "
migrationBuilder
•• 
.
•• 
	DropTable
•• &
(
••& '
name
–– 
:
–– 
$str
–– &
)
––& '
;
––' (
migrationBuilder
 
.
 
	DropTable
 &
(
& '
name
™™ 
:
™™ 
$str
™™ +
)
™™+ ,
;
™™, -
migrationBuilder
›› 
.
›› 
	DropTable
›› &
(
››& '
name
њњ 
:
њњ 
$str
њњ "
)
њњ" #
;
њњ# $
migrationBuilder
ћћ 
.
ћћ 
	DropTable
ћћ &
(
ћћ& '
name
џџ 
:
џџ 
$str
џџ "
,
џџ" #
schema
   
:
   
$str
   
)
   
;
   
migrationBuilder
ўў 
.
ўў 
	DropTable
ўў &
(
ўў& '
name
ЈЈ 
:
ЈЈ 
$str
ЈЈ "
,
ЈЈ" #
schema
¤¤ 
:
¤¤ 
$str
¤¤ 
)
¤¤ 
;
¤¤ 
migrationBuilder
¦¦ 
.
¦¦ 
	DropTable
¦¦ &
(
¦¦& '
name
§§ 
:
§§ 
$str
§§ !
,
§§! "
schema
ЁЁ 
:
ЁЁ 
$str
ЁЁ 
)
ЁЁ 
;
ЁЁ 
migrationBuilder
ЄЄ 
.
ЄЄ 
	DropTable
ЄЄ &
(
ЄЄ& '
name
«« 
:
«« 
$str
«« "
,
««" #
schema
¬¬ 
:
¬¬ 
$str
¬¬ 
)
¬¬ 
;
¬¬ 
migrationBuilder
®® 
.
®® 
	DropTable
®® &
(
®®& '
name
ЇЇ 
:
ЇЇ 
$str
ЇЇ 
,
ЇЇ 
schema
°° 
:
°° 
$str
°° 
)
°° 
;
°° 
migrationBuilder
ІІ 
.
ІІ 
	DropTable
ІІ &
(
ІІ& '
name
іі 
:
іі 
$str
іі 
,
іі 
schema
ґґ 
:
ґґ 
$str
ґґ 
)
ґґ 
;
ґґ 
}
µµ 	
}
¶¶ 
}·· Ж	
€/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Extensions/ServiceCollectionExtensions.cs
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
} єI
‰/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/UserAndRolesConfiguration.cs
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
}|| Е
‡/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/MenuActionConfiguration.cs
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
} ч
ђ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/DepartmentsAndUnitsConfiguration.cs
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
}** •

„/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/ChannelConfiguration.cs
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