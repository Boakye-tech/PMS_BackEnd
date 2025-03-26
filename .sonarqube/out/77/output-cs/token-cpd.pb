Œ\
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/UnitOfWork/UnitOfWork.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

UnitOfWork) 3
;3 4
public 
class 

UnitOfWork 
: 
IUnitOfWork $
{ 
private 
bool 
disposedValue 
; 
private 
readonly  
ApplicationDbContext )

_dbContext* 4
;4 5
public		 


UnitOfWork		 
(		  
ApplicationDbContext		 *
	dbContext		+ 4
)		4 5
{

 

_dbContext 
= 
	dbContext 
; 
AllocationType 
= 
new $
AllocationTypeRepository 5
(5 6

_dbContext6 @
)@ A
;A B
LandUse 
= 
new 
LandUseRepository '
(' (

_dbContext( 2
)2 3
;3 4
LandUseType 
= 
new !
LandUseTypeRepository /
(/ 0

_dbContext0 :
): ;
;; <
Locality 
= 
new 
LocalityRepository )
() *

_dbContext* 4
)4 5
;5 6
PropertyType 
= 
new "
PropertyTypeRepository 1
(1 2

_dbContext2 <
)< =
;= >
PlotSize 
= 
new 
PlotSizeRepository )
() *

_dbContext* 4
)4 5
;5 6
CustomerType 
= 
new "
CustomerTypeRepository 1
(1 2

_dbContext2 <
)< =
;= >
Gender 
= 
new 
GenderRepository %
(% &

_dbContext& 0
)0 1
;1 2
IdentificationType 
= 
new  (
IdentificationTypeRepository! =
(= >

_dbContext> H
)H I
;I J
Nationality 
= 
new !
NationalityRepository /
(/ 0

_dbContext0 :
): ;
;; <
ResidentType!! 
=!! 
new!! "
ResidentTypeRepository!! 1
(!!1 2

_dbContext!!2 <
)!!< =
;!!= >
SocialMedia## 
=## 
new## !
SocialMediaRepository## /
(##/ 0

_dbContext##0 :
)##: ;
;##; <
Title%% 
=%% 
new%% 
TitleRepository%% #
(%%# $

_dbContext%%$ .
)%%. /
;%%/ 0
ApartmentTypes'' 
='' 
new'' $
ApartmentTypesRepository'' 5
(''5 6

_dbContext''6 @
)''@ A
;''A B
BlockNumber)) 
=)) 
new)) !
BlockNumberRepository)) /
())/ 0

_dbContext))0 :
))): ;
;)); <

BlockSides++ 
=++ 
new++  
BlockSidesRepository++ -
(++- .

_dbContext++. 8
)++8 9
;++9 :
	BlockType-- 
=-- 
new-- 
BlockTypeRepository-- +
(--+ ,

_dbContext--, 6
)--6 7
;--7 8
	BlockUnit// 
=// 
new// 
BlockUnitRepository// +
(//+ ,

_dbContext//, 6
)//6 7
;//7 8

Facilities11 
=11 
new11  
FacilitiesRepository11 -
(11- .

_dbContext11. 8
)118 9
;119 :
FloorNumbering33 
=33 
new33 $
FloorNumberingRepository33 5
(335 6

_dbContext336 @
)33@ A
;33A B
PropertyHeight55 
=55 
new55 $
PropertyHeightRepository55 5
(555 6

_dbContext556 @
)55@ A
;55A B
CustomerMaster77 
=77 
new77 $
CustomerMasterRepository77 5
(775 6

_dbContext776 @
)77@ A
;77A B
PropertyMaster99 
=99 
new99 $
PropertyMasterRepository99 5
(995 6

_dbContext996 @
)99@ A
;99A B
Activity;; 
=;; 
new;; 
ActivityRepository;; )
(;;) *

_dbContext;;* 4
);;4 5
;;;5 6
ActivityType<< 
=<< 
new<< "
ActivityTypeRepository<< 1
(<<1 2

_dbContext<<2 <
)<<< =
;<<= >
OwnershipType>> 
=>> 
new>> #
OwnershipTypeRepository>> 3
(>>3 4

_dbContext>>4 >
)>>> ?
;>>? @
	StopDebit@@ 
=@@ 
new@@ 
StopDebitRepository@@ +
(@@+ ,

_dbContext@@, 6
)@@6 7
;@@7 8
}BB 
publicEE 
%
IAllocationTypeRepositoryEE $
AllocationTypeEE% 3
{EE4 5
getEE6 9
;EE9 :
privateEE; B
setEEC F
;EEF G
}EEH I
publicGG 

ILandUseRepositoryGG 
LandUseGG %
{GG& '
getGG( +
;GG+ ,
privateGG- 4
setGG5 8
;GG8 9
}GG: ;
publicII 
"
ILandUseTypeRepositoryII !
LandUseTypeII" -
{II. /
getII0 3
;II3 4
privateII5 <
setII= @
;II@ A
}IIB C
publicKK 

ILocalityRepositoryKK 
LocalityKK '
{KK( )
getKK* -
;KK- .
privateKK/ 6
setKK7 :
;KK: ;
}KK< =
publicMM 
#
IPropertyTypeRepositoryMM "
PropertyTypeMM# /
{MM0 1
getMM2 5
;MM5 6
privateMM7 >
setMM? B
;MMB C
}MMD E
publicOO 

IPlotSizeRepositoryOO 
PlotSizeOO '
{OO( )
getOO* -
;OO- .
privateOO/ 6
setOO7 :
;OO: ;
}OO< =
publicQQ 
#
ICustomerTypeRepositoryQQ "
CustomerTypeQQ# /
{QQ0 1
getQQ2 5
;QQ5 6
privateQQ7 >
setQQ? B
;QQB C
}QQD E
publicSS 

IGenderRepositorySS 
GenderSS #
{SS$ %
getSS& )
;SS) *
privateSS+ 2
setSS3 6
;SS6 7
}SS8 9
publicUU 
)
IIdentificationTypeRepositoryUU (
IdentificationTypeUU) ;
{UU< =
getUU> A
;UUA B
privateUUC J
setUUK N
;UUN O
}UUP Q
publicWW 
"
INationalityRepositoryWW !
NationalityWW" -
{WW. /
getWW0 3
;WW3 4
privateWW5 <
setWW= @
;WW@ A
}WWB C
publicYY 
#
IResidentTypeRepositoryYY "
ResidentTypeYY# /
{YY0 1
getYY2 5
;YY5 6
privateYY7 >
setYY? B
;YYB C
}YYD E
public[[ 
"
ISocialMediaRepository[[ !
SocialMedia[[" -
{[[. /
get[[0 3
;[[3 4
private[[5 <
set[[= @
;[[@ A
}[[B C
public]] 

ITitleRepository]] 
Title]] !
{]]" #
get]]$ '
;]]' (
private]]) 0
set]]1 4
;]]4 5
}]]6 7
public__ 
%
IApartmentTypesRepository__ $
ApartmentTypes__% 3
{__4 5
get__6 9
;__9 :
private__; B
set__C F
;__F G
}__H I
publicaa 
"
IBlockNumberRepositoryaa !
BlockNumberaa" -
{aa. /
getaa0 3
;aa3 4
privateaa5 <
setaa= @
;aa@ A
}aaB C
publiccc 
!
IBlockSidesRepositorycc  

BlockSidescc! +
{cc, -
getcc. 1
;cc1 2
privatecc3 :
setcc; >
;cc> ?
}cc@ A
publicee 
 
IBlockTypeRepositoryee 
	BlockTypeee  )
{ee* +
getee, /
;ee/ 0
privateee1 8
setee9 <
;ee< =
}ee> ?
publicgg 
 
IBlockUnitRepositorygg 
	BlockUnitgg  )
{gg* +
getgg, /
;gg/ 0
privategg1 8
setgg9 <
;gg< =
}gg> ?
publicii 
!
IFacilitiesRepositoryii  

Facilitiesii! +
{ii, -
getii. 1
;ii1 2
privateii3 :
setii; >
;ii> ?
}ii@ A
publickk 
%
IFloorNumberingRepositorykk $
FloorNumberingkk% 3
{kk4 5
getkk6 9
;kk9 :
privatekk; B
setkkC F
;kkF G
}kkH I
publicmm 
%
IPropertyHeightRepositorymm $
PropertyHeightmm% 3
{mm4 5
getmm6 9
;mm9 :
privatemm; B
setmmC F
;mmF G
}mmH I
publicoo 
%
ICustomerMasterRepositoryoo $
CustomerMasteroo% 3
{oo4 5
getoo6 9
;oo9 :
privateoo; B
setooC F
;ooF G
}ooH I
publicqq 
%
IPropertyMasterRepositoryqq $
PropertyMasterqq% 3
{qq4 5
getqq6 9
;qq9 :
privateqq; B
setqqC F
;qqF G
}qqH I
publictt 

IActivityRepositorytt 
Activitytt '
{tt( )
gettt* -
;tt- .
privatett/ 6
settt7 :
;tt: ;
}tt< =
publicuu 
#
IActivityTypeRepositoryuu "
ActivityTypeuu# /
{uu0 1
getuu2 5
;uu5 6
privateuu7 >
setuu? B
;uuB C
}uuD E
publicww 
$
IOwnershipTypeRepositoryww #
OwnershipTypeww$ 1
{ww2 3
getww4 7
;ww7 8
privateww9 @
setwwA D
;wwD E
}wwF G
publiczz 
 
IStopDebitRepositoryzz 
	StopDebitzz  )
{zz* +
getzz, /
;zz/ 0
privatezz1 8
setzz9 <
;zz< =
}zz> ?
public}} 

Task}} 
<}} 
int}} 
>}} 
Complete}} 
(}} 
)}} 
{~~ 
return 

_dbContext 
. 
SaveChangesAsync *
(* +
)+ ,
;, -
}
ÄÄ 
	protected
ÇÇ 
virtual
ÇÇ 
void
ÇÇ 
Dispose
ÇÇ "
(
ÇÇ" #
bool
ÇÇ# '
	disposing
ÇÇ( 1
)
ÇÇ1 2
{
ÉÉ 
if
ÑÑ 

(
ÑÑ 
!
ÑÑ 
disposedValue
ÑÑ 
)
ÑÑ 
{
ÖÖ 	
if
ÜÜ 
(
ÜÜ 
	disposing
ÜÜ 
)
ÜÜ 
{
áá 

_dbContext
ââ 
.
ââ 
Dispose
ââ "
(
ââ" #
)
ââ# $
;
ââ$ %
}
ää 
disposedValue
éé 
=
éé 
true
éé  
;
éé  !
}
èè 	
}
êê 
public
íí 

void
íí 
Dispose
íí 
(
íí 
)
íí 
{
ìì 
Dispose
ïï 
(
ïï 
	disposing
ïï 
:
ïï 
true
ïï 
)
ïï  
;
ïï  !
GC
ññ 

.
ññ
 
SuppressFinalize
ññ 
(
ññ 
this
ññ  
)
ññ  !
;
ññ! "
}
óó 
}òò l
j/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Usings.csÇA
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Repository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastrcuture (
.( )
Repositories) 5
{ 
public 
class 

Repository 
< 
TEntity  
>  !
:" #
IRepository$ /
</ 0
TEntity0 7
>7 8
where9 >
TEntity? F
:F G
classH M
{		 
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
{ 

_dbContext 
= 
	dbContext "
;" #
} 
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
public 
async 
Task 
< 
TEntity !
?! "
>" #
Get$ '
(' (

Expression( 2
<2 3
Func3 7
<7 8
TEntity8 ?
,? @
boolA E
>E F
>F G

expressionH R
,R S
ListT X
<X Y
stringY _
>_ `
?` a
includesb j
=k l
nullm q
)q r
{ 	

IQueryable 
< 
TEntity 
> 
entities  (
=) *

_dbContext+ 5
.5 6
Set6 9
<9 :
TEntity: A
>A B
(B C
)C D
;D E
if 
( 
includes 
!= 
null  
)  !
{ 
foreach 
( 
var 
includeProp (
in) +
includes, 4
)4 5
{   
entities!! 
=!! 
entities!! '
.!!' (
Include!!( /
(!!/ 0
includeProp!!0 ;
)!!; <
;!!< =
}"" 
}## 
return%% 
await%% 
entities%% !
.%%! "
AsNoTracking%%" .
(%%. /
)%%/ 0
.%%0 1
FirstOrDefaultAsync%%1 D
(%%D E

expression%%E O
)%%O P
;%%P Q
}&& 	
public(( 
async(( 
Task(( 
<(( 
IList(( 
<((  
TEntity((  '
>((' (
>((( )
GetAll((* 0
(((0 1

Expression((1 ;
<((; <
Func((< @
<((@ A
TEntity((A H
,((H I
bool((J N
>((N O
>((O P
?((P Q

expression((R \
=((] ^
null((_ c
,((c d
Func((e i
<((i j

IQueryable((j t
<((t u
TEntity((u |
>((| }
,((} ~
IOrderedQueryable	(( ê
<
((ê ë
TEntity
((ë ò
>
((ò ô
>
((ô ö
?
((ö õ
orderBy
((ú £
=
((§ •
null
((¶ ™
,
((™ ´
List
((¨ ∞
<
((∞ ±
string
((± ∑
>
((∑ ∏
?
((∏ π
includes
((∫ ¬
=
((√ ƒ
null
((≈ …
)
((…  
{)) 	

IQueryable** 
<** 
TEntity** 
>** 
query**  %
=**& '

_dbContext**( 2
.**2 3
Set**3 6
<**6 7
TEntity**7 >
>**> ?
(**? @
)**@ A
;**A B
if,, 
(,, 

expression,, 
!=,, 
null,, "
),," #
query-- 
=-- 
query-- 
.-- 
Where-- #
(--# $

expression--$ .
)--. /
;--/ 0
if// 
(// 
includes// 
!=// 
null//  
)//  !
{00 
foreach11 
(11 
var11 
includeProperty11 ,
in11- /
includes110 8
)118 9
query22 
=22 
query22 !
.22! "
Include22" )
(22) *
includeProperty22* 9
)229 :
;22: ;
}33 
if55 
(55 
orderBy55 
!=55 
null55 
)55  
query66 
=66 
orderBy66 
(66  
query66  %
)66% &
;66& '
return88 
await88 
query88 
.88 
AsNoTracking88 +
(88+ ,
)88, -
.88- .
ToListAsync88. 9
(889 :
)88: ;
;88; <
}99 	
public;; 
async;; 
Task;; 
<;; 
IList;; 
<;;  
TEntity;;  '
>;;' (
>;;( )
GetAll;;* 0
(;;0 1
);;1 2
=>;;3 5
await;;6 ;

_dbContext;;< F
.;;F G
Set;;G J
<;;J K
TEntity;;K R
>;;R S
(;;S T
);;T U
.;;U V
ToListAsync;;V a
(;;a b
);;b c
;;;c d
public== 
async== 
void== 
Insert==  
(==  !
TEntity==! (
entity==) /
)==/ 0
=>==1 3
await==4 9

_dbContext==: D
.==D E
Set==E H
<==H I
TEntity==I P
>==P Q
(==Q R
)==R S
.==S T
AddAsync==T \
(==\ ]
entity==] c
)==c d
;==d e
public?? 
async?? 
void?? 
InsertRange?? %
(??% &
IEnumerable??& 1
<??1 2
TEntity??2 9
>??9 :
entities??; C
)??C D
=>??E G
await??H M

_dbContext??N X
.??X Y
Set??Y \
<??\ ]
TEntity??] d
>??d e
(??e f
)??f g
.??g h
AddRangeAsync??h u
(??u v
entities??v ~
)??~ 
;	?? Ä
publicAA 
voidAA 
UpdateAA 
(AA 
TEntityAA "
entityAA# )
)AA) *
=>AA+ -

_dbContextAA. 8
.AA8 9
SetAA9 <
<AA< =
TEntityAA= D
>AAD E
(AAE F
)AAF G
.AAG H
UpdateAAH N
(AAN O
entityAAO U
)AAU V
;AAV W
publicCC 
voidCC 
UpdateRangeCC 
(CC  
IEnumerableCC  +
<CC+ ,
TEntityCC, 3
>CC3 4
entitiesCC5 =
)CC= >
=>CC? A

_dbContextCCB L
.CCL M
SetCCM P
<CCP Q
TEntityCCQ X
>CCX Y
(CCY Z
)CCZ [
.CC[ \
UpdateRangeCC\ g
(CCg h
entitiesCCh p
)CCp q
;CCq r
}DD 
}EE Ö
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Registration/PropertyMasterRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Registration6 B
{ 
public 
class $
PropertyMasterRepository &
:' (

Repository) 3
<3 4
PropertyMaster4 B
>B C
,C D%
IPropertyMasterRepositoryE ^
{ 
public $
PropertyMasterRepository	 !
(! " 
ApplicationDbContext" 6
	dbContext7 @
)A B
:C D
baseE I
(I J
	dbContextJ S
)S T
{ 
} 
}		 
}

 Ö
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Registration/CustomerMasterRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Registration6 B
{ 
public 
class $
CustomerMasterRepository &
:' (

Repository) 3
<3 4
CustomerMaster4 B
>B C
,C D%
ICustomerMasterRepositoryE ^
{ 
public $
CustomerMasterRepository	 !
(! " 
ApplicationDbContext" 6
	dbContext7 @
)@ A
:B C
baseD H
(H I
	dbContextI R
)R S
{ 	
}		 
}

 
} Ë
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Management/StopDebitRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6

Management6 @
{ 
public 
class 
StopDebitRepository !
:! "

Repository# -
<- .
	StopDebit. 7
>7 8
,8 9 
IStopDebitRepository: N
{ 
public 
StopDebitRepository	 
(  
ApplicationDbContext 1
	dbContext2 ;
); <
:= >
base? C
(C D
	dbContextD M
)M N
{ 	
}		 
}

 
} …
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class "
PropertyTypeRepository $
:% &

Repository' 1
<1 2
PropertyType2 >
>> ?
,? @#
IPropertyTypeRepositoryA X
{ 
public "
PropertyTypeRepository	 
(   
ApplicationDbContext  4
	dbContext5 >
)> ?
:@ A
baseB F
(F G
	dbContextG P
)P Q
{ 	
} 
}		 
}

 ”
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyHeightRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class $
PropertyHeightRepository &
:' (

Repository) 3
<3 4
PropertyHeight4 B
>B C
,C D%
IPropertyHeightRepositoryE ^
{ 
public $
PropertyHeightRepository	 !
(! " 
ApplicationDbContext" 6
	dbContext7 @
)@ A
:B C
baseD H
(H I
	dbContextI R
)R S
{ 	
} 
}		 
}

 µ
õ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PlotSizeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class 
PlotSizeRepository  
:! "

Repository# -
<- .
PlotSize. 6
>6 7
,7 8
IPlotSizeRepository9 L
{ 
public 
PlotSizeRepository	 
(  
ApplicationDbContext 0
	dbContext1 :
): ;
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
 §
õ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LocalityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
;M N
public 
class 
LocalityRepository 
:  

Repository! +
<+ ,
Locality, 4
>4 5
,5 6
ILocalityRepository7 J
{ 
public 
LocalityRepository 
(  
ApplicationDbContext /
	dbContext0 9
)9 :
:; <
base= A
(A B
	dbContextB K
)K L
{ 
} 
} ≥
û/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LandUseTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
;M N
public 
class !
LandUseTypeRepository "
:# $

Repository% /
</ 0
LandUseType0 ;
>; <
,< ="
ILandUseTypeRepository> T
{ 
public !
LandUseTypeRepository 
(  
ApplicationDbContext 2
	dbContext3 <
)< =
:> ?
base@ D
(D E
	dbContextE N
)N O
{ 
} 
} ü
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LandUseRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
;M N
public 
class 
LandUseRepository 
:  

Repository! +
<+ ,
LandUse, 3
>3 4
,4 5
ILandUseRepository6 H
{ 
public 

LandUseRepository 
(  
ApplicationDbContext 1
	dbContext2 ;
); <
:= >
base? C
(C D
	dbContextD M
)M N
{ 
} 
} ”
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/FloorNumberingRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class $
FloorNumberingRepository &
:' (

Repository) 3
<3 4
FloorNumbering4 B
>B C
,C D%
IFloorNumberingRepositoryE ^
{ 
public $
FloorNumberingRepository	 !
(! " 
ApplicationDbContext" 6
	dbContext7 @
)@ A
:B C
baseD H
(H I
	dbContextI R
)R S
{ 	
} 
}		 
}

 ø
ù/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/FacilitiesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class  
FacilitiesRepository "
:# $

Repository% /
</ 0

Facilities0 :
>: ;
,; <!
IFacilitiesRepository= R
{ 
public  
FacilitiesRepository	 
(  
ApplicationDbContext 2
	dbContext3 <
)< =
:> ?
base@ D
(D E
	dbContextE N
)N O
{ 	
} 
}		 
}

 ∫
ú/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockUnitRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class 
BlockUnitRepository !
:" #

Repository$ .
<. /
	BlockUnit/ 8
>8 9
,9 : 
IBlockUnitRepository; O
{ 
public 
BlockUnitRepository	 
(  
ApplicationDbContext 1
	dbContext2 ;
); <
:= >
base? C
(C D
	dbContextD M
)M N
{ 	
} 
}		 
}

 ª
ú/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class 
BlockTypeRepository !
:" #

Repository$ .
<. /

BlockTypes/ 9
>9 :
,: ; 
IBlockTypeRepository< P
{ 
public 
BlockTypeRepository	 
(  
ApplicationDbContext 1
	dbContext2 ;
); <
:= >
base? C
(C D
	dbContextD M
)M N
{ 	
} 
}		 
}

 ø
ù/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockSidesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class  
BlockSidesRepository "
:# $

Repository% /
</ 0

BlockSides0 :
>: ;
,; <!
IBlockSidesRepository= R
{ 
public  
BlockSidesRepository	 
(  
ApplicationDbContext 2
	dbContext3 <
)< =
:> ?
base@ D
(D E
	dbContextE N
)N O
{ 	
} 
}		 
}

 ƒ
û/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockNumberRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class !
BlockNumberRepository #
:$ %

Repository& 0
<0 1
BlockNumber1 <
>< =
,= >"
IBlockNumberRepository? U
{ 
public !
BlockNumberRepository	 
(  
ApplicationDbContext 3
	dbContext4 =
)= >
:? @
baseA E
(E F
	dbContextF O
)O P
{ 
} 
}		 
}

 ¬
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ApartmentTypesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
;M N
public 
class $
ApartmentTypesRepository %
:& '

Repository( 2
<2 3
ApartmentTypes3 A
>A B
,B C%
IApartmentTypesRepositoryD ]
{ 
public $
ApartmentTypesRepository  
(  ! 
ApplicationDbContext! 5
	dbContext6 ?
)? @
:A B
baseC G
(G H
	dbContextH Q
)Q R
{ 
} 
}		 ¬
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/AllocationTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
;M N
public 
class $
AllocationTypeRepository %
:% &

Repository' 1
<1 2
AllocationType2 @
>@ A
,A B%
IAllocationTypeRepositoryC \
{ 
public $
AllocationTypeRepository  
(  ! 
ApplicationDbContext! 5
	dbContext6 ?
)? @
:A B
baseC G
(G H
	dbContextH Q
)Q R
{ 
} 
} …
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ActivityTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class "
ActivityTypeRepository $
:% &

Repository' 1
<1 2
ActivityType2 >
>> ?
,? @#
IActivityTypeRepositoryA X
{ 
public "
ActivityTypeRepository	 
(   
ApplicationDbContext  4
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
 µ
õ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ActivityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
PropertyE M
{ 
public 
class 
ActivityRepository  
:! "

Repository# -
<- .
Activity. 6
>6 7
,7 8
IActivityRepository9 L
{ 
public 
ActivityRepository	 
(  
ApplicationDbContext 0
	dbContext1 :
): ;
:< =
base> B
(B C
	dbContextC L
)L M
{ 
} 
}		 
}

 ¶
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/TitleRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class 
TitleRepository 
: 

Repository  *
<* +
Title+ 0
>0 1
,1 2
ITitleRepository3 C
{ 
public 
TitleRepository	 
(  
ApplicationDbContext -
	dbContext. 7
)7 8
:9 :
base; ?
(? @
	dbContext@ I
)I J
{ 	
} 
}		 
}

 ƒ
û/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/SocialMediaRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class !
SocialMediaRepository #
:$ %

Repository& 0
<0 1
SocialMedia1 <
>< =
,= >"
ISocialMediaRepository? U
{ 
public !
SocialMediaRepository	 
(  
ApplicationDbContext 3
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
 …
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/ResidentTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class "
ResidentTypeRepository $
:% &

Repository' 1
<1 2
ResidentType2 >
>> ?
,? @#
IResidentTypeRepositoryA X
{ 
public "
ResidentTypeRepository	 
(   
ApplicationDbContext  4
	dbContext5 >
)> ?
:@ A
baseB F
(F G
	dbContextG P
)P Q
{ 	
} 
}		 
}

 Œ
†/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/OwnershipTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class #
OwnershipTypeRepository %
:& '

Repository( 2
<2 3
OwnershipType3 @
>@ A
,A B$
IOwnershipTypeRepositoryC [
{ 
public #
OwnershipTypeRepository	  
(  ! 
ApplicationDbContext! 5
	dbContext6 ?
)? @
:A B
baseC G
(G H
	dbContextH Q
)Q R
{ 	
} 
}		 
}

 ƒ
û/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/NationalityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class !
NationalityRepository #
:$ %

Repository& 0
<0 1
Nationality1 <
>< =
,= >"
INationalityRepository? U
{ 
public !
NationalityRepository	 
(  
ApplicationDbContext 3
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
 Á
•/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/IdentificationTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class (
IdentificationTypeRepository *
:+ ,

Repository- 7
<7 8
IdentificationType8 J
>J K
,K L)
IIdentificationTypeRepositoryM j
{ 
public (
IdentificationTypeRepository	 %
(% & 
ApplicationDbContext& :
	dbContext; D
)D E
:F G
baseH L
(L M
	dbContextM V
)V W
{ 	
} 
}		 
}

 ´
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/GenderRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
{ 
public 
class 
GenderRepository 
:  

Repository! +
<+ ,
Gender, 2
>2 3
,3 4
IGenderRepository5 F
{ 
public 
GenderRepository	 
(  
ApplicationDbContext .
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
 ∏
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/CustomerTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
.D E
CustomerE M
;M N
public 
class "
CustomerTypeRepository #
:$ %

Repository& 0
<0 1
CustomerType1 =
>= >
,> ?#
ICustomerTypeRepository@ W
{ 
public "
CustomerTypeRepository 
(  
ApplicationDbContext 3
	dbContext4 =
)= >
:? @
baseA E
(E F
	dbContextF O
)O P
{ 
} 
} Ç
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250313154632_Modify_CustomerMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

Migrations) 3
{ 
public		 

partial		 
class		 !
Modify_CustomerMaster		 .
:		/ 0
	Migration		1 :
{

 
	protected 
override 
void 
Up  "
(" #
MigrationBuilder# 3
migrationBuilder4 D
)D E
{ 	
migrationBuilder 
. 
	AddColumn &
<& '
DateTime' /
>/ 0
(0 1
name 
: 
$str &
,& '
schema 
: 
$str 
, 
table 
: 
$str '
,' (
type 
: 
$str !
,! "
nullable 
: 
true 
) 
;  
migrationBuilder 
. 
	AddColumn &
<& '
bool' +
>+ ,
(, -
name 
: 
$str !
,! "
schema 
: 
$str 
, 
table 
: 
$str '
,' (
type 
: 
$str 
, 
nullable 
: 
false 
,  
defaultValue 
: 
false #
)# $
;$ %
migrationBuilder 
. 
	AddColumn &
<& '
string' -
>- .
(. /
name 
: 
$str %
,% &
schema 
: 
$str 
, 
table   
:   
$str   '
,  ' (
type!! 
:!! 
$str!! %
,!!% &
nullable"" 
:"" 
true"" 
)"" 
;""  
}## 	
	protected&& 
override&& 
void&& 
Down&&  $
(&&$ %
MigrationBuilder&&% 5
migrationBuilder&&6 F
)&&F G
{'' 	
migrationBuilder(( 
.(( 

DropColumn(( '
(((' (
name)) 
:)) 
$str)) &
,))& '
schema** 
:** 
$str** 
,** 
table++ 
:++ 
$str++ '
)++' (
;++( )
migrationBuilder-- 
.-- 

DropColumn-- '
(--' (
name.. 
:.. 
$str.. !
,..! "
schema// 
:// 
$str// 
,// 
table00 
:00 
$str00 '
)00' (
;00( )
migrationBuilder22 
.22 

DropColumn22 '
(22' (
name33 
:33 
$str33 %
,33% &
schema44 
:44 
$str44 
,44 
table55 
:55 
$str55 '
)55' (
;55( )
}66 	
}77 
}88 ó$
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310190204_Modified_CustomerMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

Migrations) 3
{ 
public		 

partial		 
class		 #
Modified_CustomerMaster		 0
:		1 2
	Migration		3 <
{

 
	protected 
override 
void 
Up  "
(" #
MigrationBuilder# 3
migrationBuilder4 D
)D E
{ 	
migrationBuilder 
. 
AlterColumn (
<( )
DateTime) 1
>1 2
(2 3
name 
: 
$str 0
,0 1
schema 
: 
$str 
, 
table 
: 
$str '
,' (
type 
: 
$str !
,! "
nullable 
: 
true 
, 

oldClrType 
: 
typeof "
(" #
DateTime# +
)+ ,
,, -
oldType 
: 
$str $
)$ %
;% &
migrationBuilder 
. 
AlterColumn (
<( )
DateTime) 1
>1 2
(2 3
name 
: 
$str 0
,0 1
schema 
: 
$str 
, 
table 
: 
$str '
,' (
type 
: 
$str !
,! "
nullable 
: 
true 
, 

oldClrType 
: 
typeof "
(" #
DateTime# +
)+ ,
,, -
oldType 
: 
$str $
)$ %
;% &
} 	
	protected"" 
override"" 
void"" 
Down""  $
(""$ %
MigrationBuilder""% 5
migrationBuilder""6 F
)""F G
{## 	
migrationBuilder$$ 
.$$ 
AlterColumn$$ (
<$$( )
DateTime$$) 1
>$$1 2
($$2 3
name%% 
:%% 
$str%% 0
,%%0 1
schema&& 
:&& 
$str&& 
,&& 
table'' 
:'' 
$str'' '
,''' (
type(( 
:(( 
$str(( !
,((! "
nullable)) 
:)) 
false)) 
,))  
defaultValue** 
:** 
new** !
DateTime**" *
(*** +
$num**+ ,
,**, -
$num**. /
,**/ 0
$num**1 2
,**2 3
$num**4 5
,**5 6
$num**7 8
,**8 9
$num**: ;
,**; <
$num**= >
,**> ?
DateTimeKind**@ L
.**L M
Unspecified**M X
)**X Y
,**Y Z

oldClrType++ 
:++ 
typeof++ "
(++" #
DateTime++# +
)+++ ,
,++, -
oldType,, 
:,, 
$str,, $
,,,$ %
oldNullable-- 
:-- 
true-- !
)--! "
;--" #
migrationBuilder// 
.// 
AlterColumn// (
<//( )
DateTime//) 1
>//1 2
(//2 3
name00 
:00 
$str00 0
,000 1
schema11 
:11 
$str11 
,11 
table22 
:22 
$str22 '
,22' (
type33 
:33 
$str33 !
,33! "
nullable44 
:44 
false44 
,44  
defaultValue55 
:55 
new55 !
DateTime55" *
(55* +
$num55+ ,
,55, -
$num55. /
,55/ 0
$num551 2
,552 3
$num554 5
,555 6
$num557 8
,558 9
$num55: ;
,55; <
$num55= >
,55> ?
DateTimeKind55@ L
.55L M
Unspecified55M X
)55X Y
,55Y Z

oldClrType66 
:66 
typeof66 "
(66" #
DateTime66# +
)66+ ,
,66, -
oldType77 
:77 
$str77 $
,77$ %
oldNullable88 
:88 
true88 !
)88! "
;88" #
}99 	
}:: 
};; â
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310140046_ModifiedCustomerMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

Migrations) 3
{ 
public 

partial 
class "
ModifiedCustomerMaster /
:0 1
	Migration2 ;
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
. 
AlterColumn (
<( )
string) /
>/ 0
(0 1
name 
: 
$str -
,- .
schema 
: 
$str 
, 
table 
: 
$str '
,' (
type 
: 
$str %
,% &
	maxLength 
: 
$num 
, 
nullable 
: 
true 
, 

oldClrType 
: 
typeof "
(" #
string# )
)) *
,* +
oldType 
: 
$str '
,' (
oldMaxLength 
: 
$num  
,  !
oldNullable 
: 
true !
)! "
;" #
} 	
	protected 
override 
void 
Down  $
($ %
MigrationBuilder% 5
migrationBuilder6 F
)F G
{ 	
migrationBuilder 
. 
AlterColumn (
<( )
string) /
>/ 0
(0 1
name 
: 
$str -
,- .
schema 
: 
$str 
, 
table   
:   
$str   '
,  ' (
type!! 
:!! 
$str!! $
,!!$ %
	maxLength"" 
:"" 
$num"" 
,"" 
nullable## 
:## 
true## 
,## 

oldClrType$$ 
:$$ 
typeof$$ "
($$" #
string$$# )
)$$) *
,$$* +
oldType%% 
:%% 
$str%% (
,%%( )
oldMaxLength&& 
:&& 
$num&& !
,&&! "
oldNullable'' 
:'' 
true'' !
)''! "
;''" #
}(( 	
})) 
}** Âò
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310133202_ModifyCustomerMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

Migrations) 3
{		 
public 

partial 
class  
ModifyCustomerMaster -
:. /
	Migration0 9
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
$str  
,  !
schema 
: 
$str 
, 
columns 
: 
table 
=> !
new" %
{ 

ActivityId 
=  
table! &
.& '
Column' -
<- .
int. 1
>1 2
(2 3
type3 7
:7 8
$str9 >
,> ?
nullable@ H
:H I
falseJ O
)O P
. 

Annotation #
(# $
$str$ 8
,8 9
$str: @
)@ A
,A B
ActivityName  
=! "
table# (
.( )
Column) /
</ 0
string0 6
>6 7
(7 8
type8 <
:< =
$str> L
,L M
	maxLengthN W
:W X
$numY [
,[ \
nullable] e
:e f
falseg l
)l m
,m n
ActivityDescription '
=( )
table* /
./ 0
Column0 6
<6 7
string7 =
>= >
(> ?
type? C
:C D
$strE S
,S T
	maxLengthU ^
:^ _
$num` b
,b c
nullabled l
:l m
truen r
)r s
,s t
	CreatedOn 
= 
table  %
.% &
Column& ,
<, -
DateTime- 5
>5 6
(6 7
type7 ;
:; <
$str= H
,H I
nullableJ R
:R S
falseT Y
)Y Z
,Z [
	CreatedBy 
= 
table  %
.% &
Column& ,
<, -
string- 3
>3 4
(4 5
type5 9
:9 :
$str; J
,J K
nullableL T
:T U
trueV Z
)Z [
,[ \

ModifiedOn 
=  
table! &
.& '
Column' -
<- .
DateTime. 6
>6 7
(7 8
type8 <
:< =
$str> I
,I J
nullableK S
:S T
falseU Z
)Z [
,[ \

ModifiedBy 
=  
table! &
.& '
Column' -
<- .
string. 4
>4 5
(5 6
type6 :
:: ;
$str< K
,K L
nullableM U
:U V
trueW [
)[ \
,\ ]
	DeletedOn   
=   
table    %
.  % &
Column  & ,
<  , -
DateTime  - 5
>  5 6
(  6 7
type  7 ;
:  ; <
$str  = H
,  H I
nullable  J R
:  R S
false  T Y
)  Y Z
,  Z [
	DeletedBy!! 
=!! 
table!!  %
.!!% &
Column!!& ,
<!!, -
string!!- 3
>!!3 4
(!!4 5
type!!5 9
:!!9 :
$str!!; J
,!!J K
nullable!!L T
:!!T U
true!!V Z
)!!Z [
}"" 
,"" 
constraints## 
:## 
table## "
=>### %
{$$ 
table%% 
.%% 

PrimaryKey%% $
(%%$ %
$str%%% 2
,%%2 3
x%%4 5
=>%%6 8
x%%9 :
.%%: ;

ActivityId%%; E
)%%E F
;%%F G
}&& 
)&& 
;&& 
migrationBuilder(( 
.(( 
CreateTable(( (
(((( )
name)) 
:)) 
$str)) $
,))$ %
schema** 
:** 
$str** 
,** 
columns++ 
:++ 
table++ 
=>++ !
new++" %
{,, 
ActivityTypeId-- "
=--# $
table--% *
.--* +
Column--+ 1
<--1 2
int--2 5
>--5 6
(--6 7
type--7 ;
:--; <
$str--= B
,--B C
nullable--D L
:--L M
false--N S
)--S T
... 

Annotation.. #
(..# $
$str..$ 8
,..8 9
$str..: @
)..@ A
,..A B

ActivityId// 
=//  
table//! &
.//& '
Column//' -
<//- .
int//. 1
>//1 2
(//2 3
type//3 7
://7 8
$str//9 >
,//> ?
nullable//@ H
://H I
false//J O
)//O P
,//P Q
ActivityTypeName00 $
=00% &
table00' ,
.00, -
Column00- 3
<003 4
string004 :
>00: ;
(00; <
type00< @
:00@ A
$str00B P
,00P Q
	maxLength00R [
:00[ \
$num00] _
,00_ `
nullable00a i
:00i j
false00k p
)00p q
,00q r#
ActivityTypeDescription11 +
=11, -
table11. 3
.113 4
Column114 :
<11: ;
string11; A
>11A B
(11B C
type11C G
:11G H
$str11I W
,11W X
	maxLength11Y b
:11b c
$num11d f
,11f g
nullable11h p
:11p q
true11r v
)11v w
,11w x
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
$str;;% 6
,;;6 7
x;;8 9
=>;;: <
x;;= >
.;;> ?
ActivityTypeId;;? M
);;M N
;;;N O
}<< 
)<< 
;<< 
migrationBuilder>> 
.>> 
CreateTable>> (
(>>( )
name?? 
:?? 
$str?? &
,??& '
schema@@ 
:@@ 
$str@@ 
,@@ 
columnsAA 
:AA 
tableAA 
=>AA !
newAA" %
{BB 
AllocationTypeIdCC $
=CC% &
tableCC' ,
.CC, -
ColumnCC- 3
<CC3 4
intCC4 7
>CC7 8
(CC8 9
typeCC9 =
:CC= >
$strCC? D
,CCD E
nullableCCF N
:CCN O
falseCCP U
)CCU V
.DD 

AnnotationDD #
(DD# $
$strDD$ 8
,DD8 9
$strDD: @
)DD@ A
,DDA B!
AllocationTypeInitialEE )
=EE* +
tableEE, 1
.EE1 2
ColumnEE2 8
<EE8 9
stringEE9 ?
>EE? @
(EE@ A
typeEEA E
:EEE F
$strEEG T
,EET U
	maxLengthEEV _
:EE_ `
$numEEa b
,EEb c
nullableEEd l
:EEl m
falseEEn s
)EEs t
,EEt u
AllocationTypesFF #
=FF$ %
tableFF& +
.FF+ ,
ColumnFF, 2
<FF2 3
stringFF3 9
>FF9 :
(FF: ;
typeFF; ?
:FF? @
$strFFA O
,FFO P
	maxLengthFFQ Z
:FFZ [
$numFF\ ^
,FF^ _
nullableFF` h
:FFh i
falseFFj o
)FFo p
,FFp q
	CreatedOnGG 
=GG 
tableGG  %
.GG% &
ColumnGG& ,
<GG, -
DateTimeGG- 5
>GG5 6
(GG6 7
typeGG7 ;
:GG; <
$strGG= H
,GGH I
nullableGGJ R
:GGR S
falseGGT Y
)GGY Z
,GGZ [
	CreatedByHH 
=HH 
tableHH  %
.HH% &
ColumnHH& ,
<HH, -
stringHH- 3
>HH3 4
(HH4 5
typeHH5 9
:HH9 :
$strHH; J
,HHJ K
nullableHHL T
:HHT U
trueHHV Z
)HHZ [
,HH[ \

ModifiedOnII 
=II  
tableII! &
.II& '
ColumnII' -
<II- .
DateTimeII. 6
>II6 7
(II7 8
typeII8 <
:II< =
$strII> I
,III J
nullableIIK S
:IIS T
falseIIU Z
)IIZ [
,II[ \

ModifiedByJJ 
=JJ  
tableJJ! &
.JJ& '
ColumnJJ' -
<JJ- .
stringJJ. 4
>JJ4 5
(JJ5 6
typeJJ6 :
:JJ: ;
$strJJ< K
,JJK L
nullableJJM U
:JJU V
trueJJW [
)JJ[ \
,JJ\ ]
	DeletedOnKK 
=KK 
tableKK  %
.KK% &
ColumnKK& ,
<KK, -
DateTimeKK- 5
>KK5 6
(KK6 7
typeKK7 ;
:KK; <
$strKK= H
,KKH I
nullableKKJ R
:KKR S
falseKKT Y
)KKY Z
,KKZ [
	DeletedByLL 
=LL 
tableLL  %
.LL% &
ColumnLL& ,
<LL, -
stringLL- 3
>LL3 4
(LL4 5
typeLL5 9
:LL9 :
$strLL; J
,LLJ K
nullableLLL T
:LLT U
trueLLV Z
)LLZ [
}MM 
,MM 
constraintsNN 
:NN 
tableNN "
=>NN# %
{OO 
tablePP 
.PP 

PrimaryKeyPP $
(PP$ %
$strPP% 8
,PP8 9
xPP: ;
=>PP< >
xPP? @
.PP@ A
AllocationTypeIdPPA Q
)PPQ R
;PPR S
}QQ 
)QQ 
;QQ 
migrationBuilderSS 
.SS 
CreateTableSS (
(SS( )
nameTT 
:TT 
$strTT &
,TT& '
schemaUU 
:UU 
$strUU 
,UU 
columnsVV 
:VV 
tableVV 
=>VV !
newVV" %
{WW 
ApartmentTypeIdXX #
=XX$ %
tableXX& +
.XX+ ,
ColumnXX, 2
<XX2 3
intXX3 6
>XX6 7
(XX7 8
typeXX8 <
:XX< =
$strXX> C
,XXC D
nullableXXE M
:XXM N
falseXXO T
)XXT U
.YY 

AnnotationYY #
(YY# $
$strYY$ 8
,YY8 9
$strYY: @
)YY@ A
,YYA B
ApartmentTypeZZ !
=ZZ" #
tableZZ$ )
.ZZ) *
ColumnZZ* 0
<ZZ0 1
stringZZ1 7
>ZZ7 8
(ZZ8 9
typeZZ9 =
:ZZ= >
$strZZ? M
,ZZM N
	maxLengthZZO X
:ZZX Y
$numZZZ \
,ZZ\ ]
nullableZZ^ f
:ZZf g
falseZZh m
)ZZm n
,ZZn o
SellingPrice[[  
=[[! "
table[[# (
.[[( )
Column[[) /
<[[/ 0
float[[0 5
>[[5 6
([[6 7
type[[7 ;
:[[; <
$str[[= C
,[[C D
nullable[[E M
:[[M N
false[[O T
)[[T U
,[[U V

CurrencyId\\ 
=\\  
table\\! &
.\\& '
Column\\' -
<\\- .
int\\. 1
>\\1 2
(\\2 3
type\\3 7
:\\7 8
$str\\9 >
,\\> ?
nullable\\@ H
:\\H I
false\\J O
)\\O P
,\\P Q
	FloorArea]] 
=]] 
table]]  %
.]]% &
Column]]& ,
<]], -
double]]- 3
>]]3 4
(]]4 5
type]]5 9
:]]9 :
$str]]; B
,]]B C
nullable]]D L
:]]L M
false]]N S
)]]S T
,]]T U
	CreatedOn^^ 
=^^ 
table^^  %
.^^% &
Column^^& ,
<^^, -
DateTime^^- 5
>^^5 6
(^^6 7
type^^7 ;
:^^; <
$str^^= H
,^^H I
nullable^^J R
:^^R S
false^^T Y
)^^Y Z
,^^Z [
	CreatedBy__ 
=__ 
table__  %
.__% &
Column__& ,
<__, -
string__- 3
>__3 4
(__4 5
type__5 9
:__9 :
$str__; J
,__J K
nullable__L T
:__T U
true__V Z
)__Z [
,__[ \

ModifiedOn`` 
=``  
table``! &
.``& '
Column``' -
<``- .
DateTime``. 6
>``6 7
(``7 8
type``8 <
:``< =
$str``> I
,``I J
nullable``K S
:``S T
false``U Z
)``Z [
,``[ \

ModifiedByaa 
=aa  
tableaa! &
.aa& '
Columnaa' -
<aa- .
stringaa. 4
>aa4 5
(aa5 6
typeaa6 :
:aa: ;
$straa< K
,aaK L
nullableaaM U
:aaU V
trueaaW [
)aa[ \
,aa\ ]
	DeletedOnbb 
=bb 
tablebb  %
.bb% &
Columnbb& ,
<bb, -
DateTimebb- 5
>bb5 6
(bb6 7
typebb7 ;
:bb; <
$strbb= H
,bbH I
nullablebbJ R
:bbR S
falsebbT Y
)bbY Z
,bbZ [
	DeletedBycc 
=cc 
tablecc  %
.cc% &
Columncc& ,
<cc, -
stringcc- 3
>cc3 4
(cc4 5
typecc5 9
:cc9 :
$strcc; J
,ccJ K
nullableccL T
:ccT U
trueccV Z
)ccZ [
}dd 
,dd 
constraintsee 
:ee 
tableee "
=>ee# %
{ff 
tablegg 
.gg 

PrimaryKeygg $
(gg$ %
$strgg% 8
,gg8 9
xgg: ;
=>gg< >
xgg? @
.gg@ A
ApartmentTypeIdggA P
)ggP Q
;ggQ R
}hh 
)hh 
;hh 
migrationBuilderjj 
.jj 
CreateTablejj (
(jj( )
namekk 
:kk 
$strkk #
,kk# $
schemall 
:ll 
$strll 
,ll 
columnsmm 
:mm 
tablemm 
=>mm !
newmm" %
{nn 
BlockNumberIdoo !
=oo" #
tableoo$ )
.oo) *
Columnoo* 0
<oo0 1
intoo1 4
>oo4 5
(oo5 6
typeoo6 :
:oo: ;
$stroo< A
,ooA B
nullableooC K
:ooK L
falseooM R
)ooR S
.pp 

Annotationpp #
(pp# $
$strpp$ 8
,pp8 9
$strpp: @
)pp@ A
,ppA B
BlockNumbersqq  
=qq! "
tableqq# (
.qq( )
Columnqq) /
<qq/ 0
stringqq0 6
>qq6 7
(qq7 8
typeqq8 <
:qq< =
$strqq> K
,qqK L
	maxLengthqqM V
:qqV W
$numqqX Y
,qqY Z
nullableqq[ c
:qqc d
falseqqe j
)qqj k
,qqk l
	CreatedOnrr 
=rr 
tablerr  %
.rr% &
Columnrr& ,
<rr, -
DateTimerr- 5
>rr5 6
(rr6 7
typerr7 ;
:rr; <
$strrr= H
,rrH I
nullablerrJ R
:rrR S
falserrT Y
)rrY Z
,rrZ [
	CreatedByss 
=ss 
tabless  %
.ss% &
Columnss& ,
<ss, -
stringss- 3
>ss3 4
(ss4 5
typess5 9
:ss9 :
$strss; J
,ssJ K
nullablessL T
:ssT U
truessV Z
)ssZ [
,ss[ \

ModifiedOntt 
=tt  
tablett! &
.tt& '
Columntt' -
<tt- .
DateTimett. 6
>tt6 7
(tt7 8
typett8 <
:tt< =
$strtt> I
,ttI J
nullablettK S
:ttS T
falsettU Z
)ttZ [
,tt[ \

ModifiedByuu 
=uu  
tableuu! &
.uu& '
Columnuu' -
<uu- .
stringuu. 4
>uu4 5
(uu5 6
typeuu6 :
:uu: ;
$struu< K
,uuK L
nullableuuM U
:uuU V
trueuuW [
)uu[ \
,uu\ ]
	DeletedOnvv 
=vv 
tablevv  %
.vv% &
Columnvv& ,
<vv, -
DateTimevv- 5
>vv5 6
(vv6 7
typevv7 ;
:vv; <
$strvv= H
,vvH I
nullablevvJ R
:vvR S
falsevvT Y
)vvY Z
,vvZ [
	DeletedByww 
=ww 
tableww  %
.ww% &
Columnww& ,
<ww, -
stringww- 3
>ww3 4
(ww4 5
typeww5 9
:ww9 :
$strww; J
,wwJ K
nullablewwL T
:wwT U
truewwV Z
)wwZ [
}xx 
,xx 
constraintsyy 
:yy 
tableyy "
=>yy# %
{zz 
table{{ 
.{{ 

PrimaryKey{{ $
({{$ %
$str{{% 5
,{{5 6
x{{7 8
=>{{9 ;
x{{< =
.{{= >
BlockNumberId{{> K
){{K L
;{{L M
}|| 
)|| 
;|| 
migrationBuilder~~ 
.~~ 
CreateTable~~ (
(~~( )
name 
: 
$str "
," #
schema
ÄÄ 
:
ÄÄ 
$str
ÄÄ 
,
ÄÄ 
columns
ÅÅ 
:
ÅÅ 
table
ÅÅ 
=>
ÅÅ !
new
ÅÅ" %
{
ÇÇ 
SideId
ÉÉ 
=
ÉÉ 
table
ÉÉ "
.
ÉÉ" #
Column
ÉÉ# )
<
ÉÉ) *
int
ÉÉ* -
>
ÉÉ- .
(
ÉÉ. /
type
ÉÉ/ 3
:
ÉÉ3 4
$str
ÉÉ5 :
,
ÉÉ: ;
nullable
ÉÉ< D
:
ÉÉD E
false
ÉÉF K
)
ÉÉK L
.
ÑÑ 

Annotation
ÑÑ #
(
ÑÑ# $
$str
ÑÑ$ 8
,
ÑÑ8 9
$str
ÑÑ: @
)
ÑÑ@ A
,
ÑÑA B
Side
ÖÖ 
=
ÖÖ 
table
ÖÖ  
.
ÖÖ  !
Column
ÖÖ! '
<
ÖÖ' (
string
ÖÖ( .
>
ÖÖ. /
(
ÖÖ/ 0
type
ÖÖ0 4
:
ÖÖ4 5
$str
ÖÖ6 D
,
ÖÖD E
	maxLength
ÖÖF O
:
ÖÖO P
$num
ÖÖQ S
,
ÖÖS T
nullable
ÖÖU ]
:
ÖÖ] ^
false
ÖÖ_ d
)
ÖÖd e
,
ÖÖe f
	CreatedOn
ÜÜ 
=
ÜÜ 
table
ÜÜ  %
.
ÜÜ% &
Column
ÜÜ& ,
<
ÜÜ, -
DateTime
ÜÜ- 5
>
ÜÜ5 6
(
ÜÜ6 7
type
ÜÜ7 ;
:
ÜÜ; <
$str
ÜÜ= H
,
ÜÜH I
nullable
ÜÜJ R
:
ÜÜR S
false
ÜÜT Y
)
ÜÜY Z
,
ÜÜZ [
	CreatedBy
áá 
=
áá 
table
áá  %
.
áá% &
Column
áá& ,
<
áá, -
string
áá- 3
>
áá3 4
(
áá4 5
type
áá5 9
:
áá9 :
$str
áá; J
,
ááJ K
nullable
ááL T
:
ááT U
true
ááV Z
)
ááZ [
,
áá[ \

ModifiedOn
àà 
=
àà  
table
àà! &
.
àà& '
Column
àà' -
<
àà- .
DateTime
àà. 6
>
àà6 7
(
àà7 8
type
àà8 <
:
àà< =
$str
àà> I
,
ààI J
nullable
ààK S
:
ààS T
false
ààU Z
)
ààZ [
,
àà[ \

ModifiedBy
ââ 
=
ââ  
table
ââ! &
.
ââ& '
Column
ââ' -
<
ââ- .
string
ââ. 4
>
ââ4 5
(
ââ5 6
type
ââ6 :
:
ââ: ;
$str
ââ< K
,
ââK L
nullable
ââM U
:
ââU V
true
ââW [
)
ââ[ \
,
ââ\ ]
	DeletedOn
ää 
=
ää 
table
ää  %
.
ää% &
Column
ää& ,
<
ää, -
DateTime
ää- 5
>
ää5 6
(
ää6 7
type
ää7 ;
:
ää; <
$str
ää= H
,
ääH I
nullable
ääJ R
:
ääR S
false
ääT Y
)
ääY Z
,
ääZ [
	DeletedBy
ãã 
=
ãã 
table
ãã  %
.
ãã% &
Column
ãã& ,
<
ãã, -
string
ãã- 3
>
ãã3 4
(
ãã4 5
type
ãã5 9
:
ãã9 :
$str
ãã; J
,
ããJ K
nullable
ããL T
:
ããT U
true
ããV Z
)
ããZ [
}
åå 
,
åå 
constraints
çç 
:
çç 
table
çç "
=>
çç# %
{
éé 
table
èè 
.
èè 

PrimaryKey
èè $
(
èè$ %
$str
èè% 4
,
èè4 5
x
èè6 7
=>
èè8 :
x
èè; <
.
èè< =
SideId
èè= C
)
èèC D
;
èèD E
}
êê 
)
êê 
;
êê 
migrationBuilder
íí 
.
íí 
CreateTable
íí (
(
íí( )
name
ìì 
:
ìì 
$str
ìì #
,
ìì# $
schema
îî 
:
îî 
$str
îî 
,
îî 
columns
ïï 
:
ïï 
table
ïï 
=>
ïï !
new
ïï" %
{
ññ 
BlockStatusId
óó !
=
óó" #
table
óó$ )
.
óó) *
Column
óó* 0
<
óó0 1
int
óó1 4
>
óó4 5
(
óó5 6
type
óó6 :
:
óó: ;
$str
óó< A
,
óóA B
nullable
óóC K
:
óóK L
false
óóM R
)
óóR S
.
òò 

Annotation
òò #
(
òò# $
$str
òò$ 8
,
òò8 9
$str
òò: @
)
òò@ A
,
òòA B
BlockStatusType
ôô #
=
ôô$ %
table
ôô& +
.
ôô+ ,
Column
ôô, 2
<
ôô2 3
string
ôô3 9
>
ôô9 :
(
ôô: ;
type
ôô; ?
:
ôô? @
$str
ôôA O
,
ôôO P
	maxLength
ôôQ Z
:
ôôZ [
$num
ôô\ ^
,
ôô^ _
nullable
ôô` h
:
ôôh i
true
ôôj n
)
ôôn o
}
öö 
,
öö 
constraints
õõ 
:
õõ 
table
õõ "
=>
õõ# %
{
úú 
table
ùù 
.
ùù 

PrimaryKey
ùù $
(
ùù$ %
$str
ùù% 5
,
ùù5 6
x
ùù7 8
=>
ùù9 ;
x
ùù< =
.
ùù= >
BlockStatusId
ùù> K
)
ùùK L
;
ùùL M
}
ûû 
)
ûû 
;
ûû 
migrationBuilder
†† 
.
†† 
CreateTable
†† (
(
††( )
name
°° 
:
°° 
$str
°° "
,
°°" #
schema
¢¢ 
:
¢¢ 
$str
¢¢ 
,
¢¢ 
columns
££ 
:
££ 
table
££ 
=>
££ !
new
££" %
{
§§ 
BlockTypeId
•• 
=
••  !
table
••" '
.
••' (
Column
••( .
<
••. /
int
••/ 2
>
••2 3
(
••3 4
type
••4 8
:
••8 9
$str
••: ?
,
••? @
nullable
••A I
:
••I J
false
••K P
)
••P Q
.
¶¶ 

Annotation
¶¶ #
(
¶¶# $
$str
¶¶$ 8
,
¶¶8 9
$str
¶¶: @
)
¶¶@ A
,
¶¶A B
	BlockType
ßß 
=
ßß 
table
ßß  %
.
ßß% &
Column
ßß& ,
<
ßß, -
string
ßß- 3
>
ßß3 4
(
ßß4 5
type
ßß5 9
:
ßß9 :
$str
ßß; I
,
ßßI J
	maxLength
ßßK T
:
ßßT U
$num
ßßV X
,
ßßX Y
nullable
ßßZ b
:
ßßb c
false
ßßd i
)
ßßi j
,
ßßj k
	CreatedOn
®® 
=
®® 
table
®®  %
.
®®% &
Column
®®& ,
<
®®, -
DateTime
®®- 5
>
®®5 6
(
®®6 7
type
®®7 ;
:
®®; <
$str
®®= H
,
®®H I
nullable
®®J R
:
®®R S
false
®®T Y
)
®®Y Z
,
®®Z [
	CreatedBy
©© 
=
©© 
table
©©  %
.
©©% &
Column
©©& ,
<
©©, -
string
©©- 3
>
©©3 4
(
©©4 5
type
©©5 9
:
©©9 :
$str
©©; J
,
©©J K
nullable
©©L T
:
©©T U
true
©©V Z
)
©©Z [
,
©©[ \

ModifiedOn
™™ 
=
™™  
table
™™! &
.
™™& '
Column
™™' -
<
™™- .
DateTime
™™. 6
>
™™6 7
(
™™7 8
type
™™8 <
:
™™< =
$str
™™> I
,
™™I J
nullable
™™K S
:
™™S T
false
™™U Z
)
™™Z [
,
™™[ \

ModifiedBy
´´ 
=
´´  
table
´´! &
.
´´& '
Column
´´' -
<
´´- .
string
´´. 4
>
´´4 5
(
´´5 6
type
´´6 :
:
´´: ;
$str
´´< K
,
´´K L
nullable
´´M U
:
´´U V
true
´´W [
)
´´[ \
,
´´\ ]
	DeletedOn
¨¨ 
=
¨¨ 
table
¨¨  %
.
¨¨% &
Column
¨¨& ,
<
¨¨, -
DateTime
¨¨- 5
>
¨¨5 6
(
¨¨6 7
type
¨¨7 ;
:
¨¨; <
$str
¨¨= H
,
¨¨H I
nullable
¨¨J R
:
¨¨R S
false
¨¨T Y
)
¨¨Y Z
,
¨¨Z [
	DeletedBy
≠≠ 
=
≠≠ 
table
≠≠  %
.
≠≠% &
Column
≠≠& ,
<
≠≠, -
string
≠≠- 3
>
≠≠3 4
(
≠≠4 5
type
≠≠5 9
:
≠≠9 :
$str
≠≠; J
,
≠≠J K
nullable
≠≠L T
:
≠≠T U
true
≠≠V Z
)
≠≠Z [
}
ÆÆ 
,
ÆÆ 
constraints
ØØ 
:
ØØ 
table
ØØ "
=>
ØØ# %
{
∞∞ 
table
±± 
.
±± 

PrimaryKey
±± $
(
±±$ %
$str
±±% 4
,
±±4 5
x
±±6 7
=>
±±8 :
x
±±; <
.
±±< =
BlockTypeId
±±= H
)
±±H I
;
±±I J
}
≤≤ 
)
≤≤ 
;
≤≤ 
migrationBuilder
¥¥ 
.
¥¥ 
CreateTable
¥¥ (
(
¥¥( )
name
µµ 
:
µµ 
$str
µµ !
,
µµ! "
schema
∂∂ 
:
∂∂ 
$str
∂∂ 
,
∂∂ 
columns
∑∑ 
:
∑∑ 
table
∑∑ 
=>
∑∑ !
new
∑∑" %
{
∏∏ 
UnitId
ππ 
=
ππ 
table
ππ "
.
ππ" #
Column
ππ# )
<
ππ) *
int
ππ* -
>
ππ- .
(
ππ. /
type
ππ/ 3
:
ππ3 4
$str
ππ5 :
,
ππ: ;
nullable
ππ< D
:
ππD E
false
ππF K
)
ππK L
.
∫∫ 

Annotation
∫∫ #
(
∫∫# $
$str
∫∫$ 8
,
∫∫8 9
$str
∫∫: @
)
∫∫@ A
,
∫∫A B
Unit
ªª 
=
ªª 
table
ªª  
.
ªª  !
Column
ªª! '
<
ªª' (
string
ªª( .
>
ªª. /
(
ªª/ 0
type
ªª0 4
:
ªª4 5
$str
ªª6 C
,
ªªC D
	maxLength
ªªE N
:
ªªN O
$num
ªªP Q
,
ªªQ R
nullable
ªªS [
:
ªª[ \
false
ªª] b
)
ªªb c
,
ªªc d
	CreatedOn
ºº 
=
ºº 
table
ºº  %
.
ºº% &
Column
ºº& ,
<
ºº, -
DateTime
ºº- 5
>
ºº5 6
(
ºº6 7
type
ºº7 ;
:
ºº; <
$str
ºº= H
,
ººH I
nullable
ººJ R
:
ººR S
false
ººT Y
)
ººY Z
,
ººZ [
	CreatedBy
ΩΩ 
=
ΩΩ 
table
ΩΩ  %
.
ΩΩ% &
Column
ΩΩ& ,
<
ΩΩ, -
string
ΩΩ- 3
>
ΩΩ3 4
(
ΩΩ4 5
type
ΩΩ5 9
:
ΩΩ9 :
$str
ΩΩ; J
,
ΩΩJ K
nullable
ΩΩL T
:
ΩΩT U
true
ΩΩV Z
)
ΩΩZ [
,
ΩΩ[ \

ModifiedOn
ææ 
=
ææ  
table
ææ! &
.
ææ& '
Column
ææ' -
<
ææ- .
DateTime
ææ. 6
>
ææ6 7
(
ææ7 8
type
ææ8 <
:
ææ< =
$str
ææ> I
,
ææI J
nullable
ææK S
:
ææS T
false
ææU Z
)
ææZ [
,
ææ[ \

ModifiedBy
øø 
=
øø  
table
øø! &
.
øø& '
Column
øø' -
<
øø- .
string
øø. 4
>
øø4 5
(
øø5 6
type
øø6 :
:
øø: ;
$str
øø< K
,
øøK L
nullable
øøM U
:
øøU V
true
øøW [
)
øø[ \
,
øø\ ]
	DeletedOn
¿¿ 
=
¿¿ 
table
¿¿  %
.
¿¿% &
Column
¿¿& ,
<
¿¿, -
DateTime
¿¿- 5
>
¿¿5 6
(
¿¿6 7
type
¿¿7 ;
:
¿¿; <
$str
¿¿= H
,
¿¿H I
nullable
¿¿J R
:
¿¿R S
false
¿¿T Y
)
¿¿Y Z
,
¿¿Z [
	DeletedBy
¡¡ 
=
¡¡ 
table
¡¡  %
.
¡¡% &
Column
¡¡& ,
<
¡¡, -
string
¡¡- 3
>
¡¡3 4
(
¡¡4 5
type
¡¡5 9
:
¡¡9 :
$str
¡¡; J
,
¡¡J K
nullable
¡¡L T
:
¡¡T U
true
¡¡V Z
)
¡¡Z [
}
¬¬ 
,
¬¬ 
constraints
√√ 
:
√√ 
table
√√ "
=>
√√# %
{
ƒƒ 
table
≈≈ 
.
≈≈ 

PrimaryKey
≈≈ $
(
≈≈$ %
$str
≈≈% 3
,
≈≈3 4
x
≈≈5 6
=>
≈≈7 9
x
≈≈: ;
.
≈≈; <
UnitId
≈≈< B
)
≈≈B C
;
≈≈C D
}
∆∆ 
)
∆∆ 
;
∆∆ 
migrationBuilder
»» 
.
»» 
CreateTable
»» (
(
»»( )
name
…… 
:
…… 
$str
…… &
,
……& '
schema
   
:
   
$str
   
,
   
columns
ÀÀ 
:
ÀÀ 
table
ÀÀ 
=>
ÀÀ !
new
ÀÀ" %
{
ÃÃ 
CustomerMasterId
ÕÕ $
=
ÕÕ% &
table
ÕÕ' ,
.
ÕÕ, -
Column
ÕÕ- 3
<
ÕÕ3 4
int
ÕÕ4 7
>
ÕÕ7 8
(
ÕÕ8 9
type
ÕÕ9 =
:
ÕÕ= >
$str
ÕÕ? D
,
ÕÕD E
nullable
ÕÕF N
:
ÕÕN O
false
ÕÕP U
)
ÕÕU V
.
ŒŒ 

Annotation
ŒŒ #
(
ŒŒ# $
$str
ŒŒ$ 8
,
ŒŒ8 9
$str
ŒŒ: @
)
ŒŒ@ A
,
ŒŒA B
CustomerTypeId
œœ "
=
œœ# $
table
œœ% *
.
œœ* +
Column
œœ+ 1
<
œœ1 2
int
œœ2 5
>
œœ5 6
(
œœ6 7
type
œœ7 ;
:
œœ; <
$str
œœ= B
,
œœB C
nullable
œœD L
:
œœL M
false
œœN S
)
œœS T
,
œœT U
ResidentTypeId
–– "
=
––# $
table
––% *
.
––* +
Column
––+ 1
<
––1 2
int
––2 5
>
––5 6
(
––6 7
type
––7 ;
:
––; <
$str
––= B
,
––B C
nullable
––D L
:
––L M
false
––N S
)
––S T
,
––T U

LocalityId
—— 
=
——  
table
——! &
.
——& '
Column
——' -
<
——- .
int
——. 1
>
——1 2
(
——2 3
type
——3 7
:
——7 8
$str
——9 >
,
——> ?
nullable
——@ H
:
——H I
false
——J O
)
——O P
,
——P Q
CustomerCode
““  
=
““! "
table
““# (
.
““( )
Column
““) /
<
““/ 0
string
““0 6
>
““6 7
(
““7 8
type
““8 <
:
““< =
$str
““> L
,
““L M
	maxLength
““N W
:
““W X
$num
““Y [
,
““[ \
nullable
““] e
:
““e f
false
““g l
)
““l m
,
““m n
TitleId
”” 
=
”” 
table
”” #
.
””# $
Column
””$ *
<
””* +
int
””+ .
>
””. /
(
””/ 0
type
””0 4
:
””4 5
$str
””6 ;
,
””; <
nullable
””= E
:
””E F
false
””G L
)
””L M
,
””M N
SurName
‘‘ 
=
‘‘ 
table
‘‘ #
.
‘‘# $
Column
‘‘$ *
<
‘‘* +
string
‘‘+ 1
>
‘‘1 2
(
‘‘2 3
type
‘‘3 7
:
‘‘7 8
$str
‘‘9 H
,
‘‘H I
	maxLength
‘‘J S
:
‘‘S T
$num
‘‘U X
,
‘‘X Y
nullable
‘‘Z b
:
‘‘b c
true
‘‘d h
)
‘‘h i
,
‘‘i j

OtherNames
’’ 
=
’’  
table
’’! &
.
’’& '
Column
’’' -
<
’’- .
string
’’. 4
>
’’4 5
(
’’5 6
type
’’6 :
:
’’: ;
$str
’’< J
,
’’J K
	maxLength
’’L U
:
’’U V
$num
’’W Y
,
’’Y Z
nullable
’’[ c
:
’’c d
true
’’e i
)
’’i j
,
’’j k
CompanyName
÷÷ 
=
÷÷  !
table
÷÷" '
.
÷÷' (
Column
÷÷( .
<
÷÷. /
string
÷÷/ 5
>
÷÷5 6
(
÷÷6 7
type
÷÷7 ;
:
÷÷; <
$str
÷÷= L
,
÷÷L M
	maxLength
÷÷N W
:
÷÷W X
$num
÷÷Y \
,
÷÷\ ]
nullable
÷÷^ f
:
÷÷f g
true
÷÷h l
)
÷÷l m
,
÷÷m n
DateOfBirth
◊◊ 
=
◊◊  !
table
◊◊" '
.
◊◊' (
Column
◊◊( .
<
◊◊. /
DateTime
◊◊/ 7
>
◊◊7 8
(
◊◊8 9
type
◊◊9 =
:
◊◊= >
$str
◊◊? J
,
◊◊J K
nullable
◊◊L T
:
◊◊T U
false
◊◊V [
)
◊◊[ \
,
◊◊\ ]
	TinNumber
ÿÿ 
=
ÿÿ 
table
ÿÿ  %
.
ÿÿ% &
Column
ÿÿ& ,
<
ÿÿ, -
string
ÿÿ- 3
>
ÿÿ3 4
(
ÿÿ4 5
type
ÿÿ5 9
:
ÿÿ9 :
$str
ÿÿ; I
,
ÿÿI J
	maxLength
ÿÿK T
:
ÿÿT U
$num
ÿÿV X
,
ÿÿX Y
nullable
ÿÿZ b
:
ÿÿb c
true
ÿÿd h
)
ÿÿh i
,
ÿÿi j
Picture
ŸŸ 
=
ŸŸ 
table
ŸŸ #
.
ŸŸ# $
Column
ŸŸ$ *
<
ŸŸ* +
string
ŸŸ+ 1
>
ŸŸ1 2
(
ŸŸ2 3
type
ŸŸ3 7
:
ŸŸ7 8
$str
ŸŸ9 H
,
ŸŸH I
	maxLength
ŸŸJ S
:
ŸŸS T
$num
ŸŸU X
,
ŸŸX Y
nullable
ŸŸZ b
:
ŸŸb c
true
ŸŸd h
)
ŸŸh i
,
ŸŸi j
GenderId
⁄⁄ 
=
⁄⁄ 
table
⁄⁄ $
.
⁄⁄$ %
Column
⁄⁄% +
<
⁄⁄+ ,
int
⁄⁄, /
>
⁄⁄/ 0
(
⁄⁄0 1
type
⁄⁄1 5
:
⁄⁄5 6
$str
⁄⁄7 <
,
⁄⁄< =
nullable
⁄⁄> F
:
⁄⁄F G
false
⁄⁄H M
)
⁄⁄M N
,
⁄⁄N O
NationalityId
€€ !
=
€€" #
table
€€$ )
.
€€) *
Column
€€* 0
<
€€0 1
int
€€1 4
>
€€4 5
(
€€5 6
type
€€6 :
:
€€: ;
$str
€€< A
,
€€A B
nullable
€€C K
:
€€K L
false
€€M R
)
€€R S
,
€€S T
PostalAddress
‹‹ !
=
‹‹" #
table
‹‹$ )
.
‹‹) *
Column
‹‹* 0
<
‹‹0 1
string
‹‹1 7
>
‹‹7 8
(
‹‹8 9
type
‹‹9 =
:
‹‹= >
$str
‹‹? N
,
‹‹N O
	maxLength
‹‹P Y
:
‹‹Y Z
$num
‹‹[ ^
,
‹‹^ _
nullable
‹‹` h
:
‹‹h i
true
‹‹j n
)
‹‹n o
,
‹‹o p 
ResidentialAddress
›› &
=
››' (
table
››) .
.
››. /
Column
››/ 5
<
››5 6
string
››6 <
>
››< =
(
››= >
type
››> B
:
››B C
$str
››D S
,
››S T
	maxLength
››U ^
:
››^ _
$num
››` c
,
››c d
nullable
››e m
:
››m n
true
››o s
)
››s t
,
››t u
DigitalAddress
ﬁﬁ "
=
ﬁﬁ# $
table
ﬁﬁ% *
.
ﬁﬁ* +
Column
ﬁﬁ+ 1
<
ﬁﬁ1 2
string
ﬁﬁ2 8
>
ﬁﬁ8 9
(
ﬁﬁ9 :
type
ﬁﬁ: >
:
ﬁﬁ> ?
$str
ﬁﬁ@ N
,
ﬁﬁN O
	maxLength
ﬁﬁP Y
:
ﬁﬁY Z
$num
ﬁﬁ[ ]
,
ﬁﬁ] ^
nullable
ﬁﬁ_ g
:
ﬁﬁg h
true
ﬁﬁi m
)
ﬁﬁm n
,
ﬁﬁn o!
PrimaryMobileNumber
ﬂﬂ '
=
ﬂﬂ( )
table
ﬂﬂ* /
.
ﬂﬂ/ 0
Column
ﬂﬂ0 6
<
ﬂﬂ6 7
string
ﬂﬂ7 =
>
ﬂﬂ= >
(
ﬂﬂ> ?
type
ﬂﬂ? C
:
ﬂﬂC D
$str
ﬂﬂE S
,
ﬂﬂS T
	maxLength
ﬂﬂU ^
:
ﬂﬂ^ _
$num
ﬂﬂ` b
,
ﬂﬂb c
nullable
ﬂﬂd l
:
ﬂﬂl m
false
ﬂﬂn s
)
ﬂﬂs t
,
ﬂﬂt u#
SecondaryMobileNumber
‡‡ )
=
‡‡* +
table
‡‡, 1
.
‡‡1 2
Column
‡‡2 8
<
‡‡8 9
string
‡‡9 ?
>
‡‡? @
(
‡‡@ A
type
‡‡A E
:
‡‡E F
$str
‡‡G U
,
‡‡U V
	maxLength
‡‡W `
:
‡‡` a
$num
‡‡b d
,
‡‡d e
nullable
‡‡f n
:
‡‡n o
true
‡‡p t
)
‡‡t u
,
‡‡u v
OfficeNumber
··  
=
··! "
table
··# (
.
··( )
Column
··) /
<
··/ 0
string
··0 6
>
··6 7
(
··7 8
type
··8 <
:
··< =
$str
··> L
,
··L M
	maxLength
··N W
:
··W X
$num
··Y [
,
··[ \
nullable
··] e
:
··e f
true
··g k
)
··k l
,
··l m
WhatsAppNumber
‚‚ "
=
‚‚# $
table
‚‚% *
.
‚‚* +
Column
‚‚+ 1
<
‚‚1 2
string
‚‚2 8
>
‚‚8 9
(
‚‚9 :
type
‚‚: >
:
‚‚> ?
$str
‚‚@ N
,
‚‚N O
	maxLength
‚‚P Y
:
‚‚Y Z
$num
‚‚[ ]
,
‚‚] ^
nullable
‚‚_ g
:
‚‚g h
true
‚‚i m
)
‚‚m n
,
‚‚n o
EmailAddress
„„  
=
„„! "
table
„„# (
.
„„( )
Column
„„) /
<
„„/ 0
string
„„0 6
>
„„6 7
(
„„7 8
type
„„8 <
:
„„< =
$str
„„> M
,
„„M N
	maxLength
„„O X
:
„„X Y
$num
„„Z ]
,
„„] ^
nullable
„„_ g
:
„„g h
true
„„i m
)
„„m n
,
„„n o"
ResidentPermitNumber
‰‰ (
=
‰‰) *
table
‰‰+ 0
.
‰‰0 1
Column
‰‰1 7
<
‰‰7 8
string
‰‰8 >
>
‰‰> ?
(
‰‰? @
type
‰‰@ D
:
‰‰D E
$str
‰‰F T
,
‰‰T U
	maxLength
‰‰V _
:
‰‰_ `
$num
‰‰a c
,
‰‰c d
nullable
‰‰e m
:
‰‰m n
true
‰‰o s
)
‰‰s t
,
‰‰t u&
ResidentPermitDateIssued
ÂÂ ,
=
ÂÂ- .
table
ÂÂ/ 4
.
ÂÂ4 5
Column
ÂÂ5 ;
<
ÂÂ; <
DateTime
ÂÂ< D
>
ÂÂD E
(
ÂÂE F
type
ÂÂF J
:
ÂÂJ K
$str
ÂÂL W
,
ÂÂW X
nullable
ÂÂY a
:
ÂÂa b
false
ÂÂc h
)
ÂÂh i
,
ÂÂi j&
ResidentPermitExpiryDate
ÊÊ ,
=
ÊÊ- .
table
ÊÊ/ 4
.
ÊÊ4 5
Column
ÊÊ5 ;
<
ÊÊ; <
DateTime
ÊÊ< D
>
ÊÊD E
(
ÊÊE F
type
ÊÊF J
:
ÊÊJ K
$str
ÊÊL W
,
ÊÊW X
nullable
ÊÊY a
:
ÊÊa b
false
ÊÊc h
)
ÊÊh i
,
ÊÊi j
SocialMediaTypeId
ÁÁ %
=
ÁÁ& '
table
ÁÁ( -
.
ÁÁ- .
Column
ÁÁ. 4
<
ÁÁ4 5
int
ÁÁ5 8
>
ÁÁ8 9
(
ÁÁ9 :
type
ÁÁ: >
:
ÁÁ> ?
$str
ÁÁ@ E
,
ÁÁE F
nullable
ÁÁG O
:
ÁÁO P
false
ÁÁQ V
)
ÁÁV W
,
ÁÁW X 
SocialMediaAccount
ËË &
=
ËË' (
table
ËË) .
.
ËË. /
Column
ËË/ 5
<
ËË5 6
string
ËË6 <
>
ËË< =
(
ËË= >
type
ËË> B
:
ËËB C
$str
ËËD R
,
ËËR S
	maxLength
ËËT ]
:
ËË] ^
$num
ËË_ a
,
ËËa b
nullable
ËËc k
:
ËËk l
true
ËËm q
)
ËËq r
,
ËËr s"
IdentificationTypeId
ÈÈ (
=
ÈÈ) *
table
ÈÈ+ 0
.
ÈÈ0 1
Column
ÈÈ1 7
<
ÈÈ7 8
int
ÈÈ8 ;
>
ÈÈ; <
(
ÈÈ< =
type
ÈÈ= A
:
ÈÈA B
$str
ÈÈC H
,
ÈÈH I
nullable
ÈÈJ R
:
ÈÈR S
false
ÈÈT Y
)
ÈÈY Z
,
ÈÈZ [&
IdentificationTypeNumber
ÍÍ ,
=
ÍÍ- .
table
ÍÍ/ 4
.
ÍÍ4 5
Column
ÍÍ5 ;
<
ÍÍ; <
string
ÍÍ< B
>
ÍÍB C
(
ÍÍC D
type
ÍÍD H
:
ÍÍH I
$str
ÍÍJ X
,
ÍÍX Y
	maxLength
ÍÍZ c
:
ÍÍc d
$num
ÍÍe g
,
ÍÍg h
nullable
ÍÍi q
:
ÍÍq r
true
ÍÍs w
)
ÍÍw x
,
ÍÍx y(
IdentificationTypeImageOne
ÎÎ .
=
ÎÎ/ 0
table
ÎÎ1 6
.
ÎÎ6 7
Column
ÎÎ7 =
<
ÎÎ= >
string
ÎÎ> D
>
ÎÎD E
(
ÎÎE F
type
ÎÎF J
:
ÎÎJ K
$str
ÎÎL [
,
ÎÎ[ \
	maxLength
ÎÎ] f
:
ÎÎf g
$num
ÎÎh k
,
ÎÎk l
nullable
ÎÎm u
:
ÎÎu v
true
ÎÎw {
)
ÎÎ{ |
,
ÎÎ| }(
IdentificationTypeImageTwo
ÏÏ .
=
ÏÏ/ 0
table
ÏÏ1 6
.
ÏÏ6 7
Column
ÏÏ7 =
<
ÏÏ= >
string
ÏÏ> D
>
ÏÏD E
(
ÏÏE F
type
ÏÏF J
:
ÏÏJ K
$str
ÏÏL [
,
ÏÏ[ \
	maxLength
ÏÏ] f
:
ÏÏf g
$num
ÏÏh k
,
ÏÏk l
nullable
ÏÏm u
:
ÏÏu v
true
ÏÏw {
)
ÏÏ{ |
,
ÏÏ| }*
IdentificationTypeImageThree
ÌÌ 0
=
ÌÌ1 2
table
ÌÌ3 8
.
ÌÌ8 9
Column
ÌÌ9 ?
<
ÌÌ? @
string
ÌÌ@ F
>
ÌÌF G
(
ÌÌG H
type
ÌÌH L
:
ÌÌL M
$str
ÌÌN ]
,
ÌÌ] ^
	maxLength
ÌÌ_ h
:
ÌÌh i
$num
ÌÌj m
,
ÌÌm n
nullable
ÌÌo w
:
ÌÌw x
true
ÌÌy }
)
ÌÌ} ~
,
ÌÌ~ )
IdentificationTypeImageFour
ÓÓ /
=
ÓÓ0 1
table
ÓÓ2 7
.
ÓÓ7 8
Column
ÓÓ8 >
<
ÓÓ> ?
string
ÓÓ? E
>
ÓÓE F
(
ÓÓF G
type
ÓÓG K
:
ÓÓK L
$str
ÓÓM \
,
ÓÓ\ ]
	maxLength
ÓÓ^ g
:
ÓÓg h
$num
ÓÓi l
,
ÓÓl m
nullable
ÓÓn v
:
ÓÓv w
true
ÓÓx |
)
ÓÓ| }
,
ÓÓ} ~)
IdentificationTypeImageFive
ÔÔ /
=
ÔÔ0 1
table
ÔÔ2 7
.
ÔÔ7 8
Column
ÔÔ8 >
<
ÔÔ> ?
string
ÔÔ? E
>
ÔÔE F
(
ÔÔF G
type
ÔÔG K
:
ÔÔK L
$str
ÔÔM \
,
ÔÔ\ ]
	maxLength
ÔÔ^ g
:
ÔÔg h
$num
ÔÔi l
,
ÔÔl m
nullable
ÔÔn v
:
ÔÔv w
true
ÔÔx |
)
ÔÔ| }
,
ÔÔ} ~
Comments
 
=
 
table
 $
.
$ %
Column
% +
<
+ ,
string
, 2
>
2 3
(
3 4
type
4 8
:
8 9
$str
: I
,
I J
	maxLength
K T
:
T U
$num
V Y
,
Y Z
nullable
[ c
:
c d
true
e i
)
i j
,
j k
InterestExpressed
ÒÒ %
=
ÒÒ& '
table
ÒÒ( -
.
ÒÒ- .
Column
ÒÒ. 4
<
ÒÒ4 5
string
ÒÒ5 ;
>
ÒÒ; <
(
ÒÒ< =
type
ÒÒ= A
:
ÒÒA B
$str
ÒÒC R
,
ÒÒR S
	maxLength
ÒÒT ]
:
ÒÒ] ^
$num
ÒÒ_ b
,
ÒÒb c
nullable
ÒÒd l
:
ÒÒl m
true
ÒÒn r
)
ÒÒr s
,
ÒÒs t
DebtorStatus
ÚÚ  
=
ÚÚ! "
table
ÚÚ# (
.
ÚÚ( )
Column
ÚÚ) /
<
ÚÚ/ 0
int
ÚÚ0 3
>
ÚÚ3 4
(
ÚÚ4 5
type
ÚÚ5 9
:
ÚÚ9 :
$str
ÚÚ; @
,
ÚÚ@ A
nullable
ÚÚB J
:
ÚÚJ K
false
ÚÚL Q
)
ÚÚQ R
,
ÚÚR S

ParentCode
ÛÛ 
=
ÛÛ  
table
ÛÛ! &
.
ÛÛ& '
Column
ÛÛ' -
<
ÛÛ- .
string
ÛÛ. 4
>
ÛÛ4 5
(
ÛÛ5 6
type
ÛÛ6 :
:
ÛÛ: ;
$str
ÛÛ< J
,
ÛÛJ K
	maxLength
ÛÛL U
:
ÛÛU V
$num
ÛÛW Y
,
ÛÛY Z
nullable
ÛÛ[ c
:
ÛÛc d
true
ÛÛe i
)
ÛÛi j
,
ÛÛj k$
ContactPerson_FullName
ÙÙ *
=
ÙÙ+ ,
table
ÙÙ- 2
.
ÙÙ2 3
Column
ÙÙ3 9
<
ÙÙ9 :
string
ÙÙ: @
>
ÙÙ@ A
(
ÙÙA B
type
ÙÙB F
:
ÙÙF G
$str
ÙÙH W
,
ÙÙW X
	maxLength
ÙÙY b
:
ÙÙb c
$num
ÙÙd g
,
ÙÙg h
nullable
ÙÙi q
:
ÙÙq r
true
ÙÙs w
)
ÙÙw x
,
ÙÙx y'
ContactPerson_PhoneNumber
ıı -
=
ıı. /
table
ıı0 5
.
ıı5 6
Column
ıı6 <
<
ıı< =
string
ıı= C
>
ııC D
(
ııD E
type
ııE I
:
ııI J
$str
ııK Y
,
ııY Z
	maxLength
ıı[ d
:
ııd e
$num
ııf h
,
ııh i
nullable
ııj r
:
ıır s
true
ııt x
)
ııx y
,
ııy z(
ContactPerson_EmailAddress
ˆˆ .
=
ˆˆ/ 0
table
ˆˆ1 6
.
ˆˆ6 7
Column
ˆˆ7 =
<
ˆˆ= >
string
ˆˆ> D
>
ˆˆD E
(
ˆˆE F
type
ˆˆF J
:
ˆˆJ K
$str
ˆˆL [
,
ˆˆ[ \
	maxLength
ˆˆ] f
:
ˆˆf g
$num
ˆˆh k
,
ˆˆk l
nullable
ˆˆm u
:
ˆˆu v
true
ˆˆw {
)
ˆˆ{ |
,
ˆˆ| }#
ContactPerson_Address
˜˜ )
=
˜˜* +
table
˜˜, 1
.
˜˜1 2
Column
˜˜2 8
<
˜˜8 9
string
˜˜9 ?
>
˜˜? @
(
˜˜@ A
type
˜˜A E
:
˜˜E F
$str
˜˜G U
,
˜˜U V
	maxLength
˜˜W `
:
˜˜` a
$num
˜˜b d
,
˜˜d e
nullable
˜˜f n
:
˜˜n o
true
˜˜p t
)
˜˜t u
,
˜˜u v0
"ContactPerson_IdentificationTypeId
¯¯ 6
=
¯¯7 8
table
¯¯9 >
.
¯¯> ?
Column
¯¯? E
<
¯¯E F
int
¯¯F I
>
¯¯I J
(
¯¯J K
type
¯¯K O
:
¯¯O P
$str
¯¯Q V
,
¯¯V W
nullable
¯¯X `
:
¯¯` a
false
¯¯b g
)
¯¯g h
,
¯¯h i4
&ContactPerson_IdentificationTypeNumber
˘˘ :
=
˘˘; <
table
˘˘= B
.
˘˘B C
Column
˘˘C I
<
˘˘I J
string
˘˘J P
>
˘˘P Q
(
˘˘Q R
type
˘˘R V
:
˘˘V W
$str
˘˘X f
,
˘˘f g
	maxLength
˘˘h q
:
˘˘q r
$num
˘˘s u
,
˘˘u v
nullable
˘˘w 
:˘˘ Ä
true˘˘Å Ö
)˘˘Ö Ü
,˘˘Ü á6
(ContactPerson_IdentificationTypeImageOne
˙˙ <
=
˙˙= >
table
˙˙? D
.
˙˙D E
Column
˙˙E K
<
˙˙K L
string
˙˙L R
>
˙˙R S
(
˙˙S T
type
˙˙T X
:
˙˙X Y
$str
˙˙Z i
,
˙˙i j
	maxLength
˙˙k t
:
˙˙t u
$num
˙˙v y
,
˙˙y z
nullable˙˙{ É
:˙˙É Ñ
true˙˙Ö â
)˙˙â ä
,˙˙ä ã6
(ContactPerson_IdentificationTypeImageTwo
˚˚ <
=
˚˚= >
table
˚˚? D
.
˚˚D E
Column
˚˚E K
<
˚˚K L
string
˚˚L R
>
˚˚R S
(
˚˚S T
type
˚˚T X
:
˚˚X Y
$str
˚˚Z i
,
˚˚i j
	maxLength
˚˚k t
:
˚˚t u
$num
˚˚v y
,
˚˚y z
nullable˚˚{ É
:˚˚É Ñ
true˚˚Ö â
)˚˚â ä
,˚˚ä ã
	IsDeleted
¸¸ 
=
¸¸ 
table
¸¸  %
.
¸¸% &
Column
¸¸& ,
<
¸¸, -
bool
¸¸- 1
>
¸¸1 2
(
¸¸2 3
type
¸¸3 7
:
¸¸7 8
$str
¸¸9 >
,
¸¸> ?
nullable
¸¸@ H
:
¸¸H I
false
¸¸J O
)
¸¸O P
,
¸¸P Q
	CreatedOn
˝˝ 
=
˝˝ 
table
˝˝  %
.
˝˝% &
Column
˝˝& ,
<
˝˝, -
DateTime
˝˝- 5
>
˝˝5 6
(
˝˝6 7
type
˝˝7 ;
:
˝˝; <
$str
˝˝= H
,
˝˝H I
nullable
˝˝J R
:
˝˝R S
false
˝˝T Y
)
˝˝Y Z
,
˝˝Z [
	CreatedBy
˛˛ 
=
˛˛ 
table
˛˛  %
.
˛˛% &
Column
˛˛& ,
<
˛˛, -
string
˛˛- 3
>
˛˛3 4
(
˛˛4 5
type
˛˛5 9
:
˛˛9 :
$str
˛˛; J
,
˛˛J K
nullable
˛˛L T
:
˛˛T U
true
˛˛V Z
)
˛˛Z [
,
˛˛[ \

ModifiedOn
ˇˇ 
=
ˇˇ  
table
ˇˇ! &
.
ˇˇ& '
Column
ˇˇ' -
<
ˇˇ- .
DateTime
ˇˇ. 6
>
ˇˇ6 7
(
ˇˇ7 8
type
ˇˇ8 <
:
ˇˇ< =
$str
ˇˇ> I
,
ˇˇI J
nullable
ˇˇK S
:
ˇˇS T
false
ˇˇU Z
)
ˇˇZ [
,
ˇˇ[ \

ModifiedBy
ÄÄ 
=
ÄÄ  
table
ÄÄ! &
.
ÄÄ& '
Column
ÄÄ' -
<
ÄÄ- .
string
ÄÄ. 4
>
ÄÄ4 5
(
ÄÄ5 6
type
ÄÄ6 :
:
ÄÄ: ;
$str
ÄÄ< K
,
ÄÄK L
nullable
ÄÄM U
:
ÄÄU V
true
ÄÄW [
)
ÄÄ[ \
,
ÄÄ\ ]
	DeletedOn
ÅÅ 
=
ÅÅ 
table
ÅÅ  %
.
ÅÅ% &
Column
ÅÅ& ,
<
ÅÅ, -
DateTime
ÅÅ- 5
>
ÅÅ5 6
(
ÅÅ6 7
type
ÅÅ7 ;
:
ÅÅ; <
$str
ÅÅ= H
,
ÅÅH I
nullable
ÅÅJ R
:
ÅÅR S
false
ÅÅT Y
)
ÅÅY Z
,
ÅÅZ [
	DeletedBy
ÇÇ 
=
ÇÇ 
table
ÇÇ  %
.
ÇÇ% &
Column
ÇÇ& ,
<
ÇÇ, -
string
ÇÇ- 3
>
ÇÇ3 4
(
ÇÇ4 5
type
ÇÇ5 9
:
ÇÇ9 :
$str
ÇÇ; J
,
ÇÇJ K
nullable
ÇÇL T
:
ÇÇT U
true
ÇÇV Z
)
ÇÇZ [
,
ÇÇ[ \

ApprovedOn
ÉÉ 
=
ÉÉ  
table
ÉÉ! &
.
ÉÉ& '
Column
ÉÉ' -
<
ÉÉ- .
DateTime
ÉÉ. 6
>
ÉÉ6 7
(
ÉÉ7 8
type
ÉÉ8 <
:
ÉÉ< =
$str
ÉÉ> I
,
ÉÉI J
nullable
ÉÉK S
:
ÉÉS T
false
ÉÉU Z
)
ÉÉZ [
,
ÉÉ[ \

ApprovedBy
ÑÑ 
=
ÑÑ  
table
ÑÑ! &
.
ÑÑ& '
Column
ÑÑ' -
<
ÑÑ- .
string
ÑÑ. 4
>
ÑÑ4 5
(
ÑÑ5 6
type
ÑÑ6 :
:
ÑÑ: ;
$str
ÑÑ< K
,
ÑÑK L
nullable
ÑÑM U
:
ÑÑU V
true
ÑÑW [
)
ÑÑ[ \
}
ÖÖ 
,
ÖÖ 
constraints
ÜÜ 
:
ÜÜ 
table
ÜÜ "
=>
ÜÜ# %
{
áá 
table
àà 
.
àà 

PrimaryKey
àà $
(
àà$ %
$str
àà% 8
,
àà8 9
x
àà: ;
=>
àà< >
x
àà? @
.
àà@ A
CustomerMasterId
ààA Q
)
ààQ R
;
ààR S
}
ââ 
)
ââ 
;
ââ 
migrationBuilder
ãã 
.
ãã 
CreateTable
ãã (
(
ãã( )
name
åå 
:
åå 
$str
åå $
,
åå$ %
schema
çç 
:
çç 
$str
çç 
,
çç 
columns
éé 
:
éé 
table
éé 
=>
éé !
new
éé" %
{
èè 
CustomerTypeId
êê "
=
êê# $
table
êê% *
.
êê* +
Column
êê+ 1
<
êê1 2
int
êê2 5
>
êê5 6
(
êê6 7
type
êê7 ;
:
êê; <
$str
êê= B
,
êêB C
nullable
êêD L
:
êêL M
false
êêN S
)
êêS T
.
ëë 

Annotation
ëë #
(
ëë# $
$str
ëë$ 8
,
ëë8 9
$str
ëë: @
)
ëë@ A
,
ëëA B
CustomerTypes
íí !
=
íí" #
table
íí$ )
.
íí) *
Column
íí* 0
<
íí0 1
string
íí1 7
>
íí7 8
(
íí8 9
type
íí9 =
:
íí= >
$str
íí? M
,
ííM N
	maxLength
ííO X
:
ííX Y
$num
ííZ \
,
íí\ ]
nullable
íí^ f
:
ííf g
false
ííh m
)
íím n
,
íín o
	CreatedOn
ìì 
=
ìì 
table
ìì  %
.
ìì% &
Column
ìì& ,
<
ìì, -
DateTime
ìì- 5
>
ìì5 6
(
ìì6 7
type
ìì7 ;
:
ìì; <
$str
ìì= H
,
ììH I
nullable
ììJ R
:
ììR S
false
ììT Y
)
ììY Z
,
ììZ [
	CreatedBy
îî 
=
îî 
table
îî  %
.
îî% &
Column
îî& ,
<
îî, -
string
îî- 3
>
îî3 4
(
îî4 5
type
îî5 9
:
îî9 :
$str
îî; J
,
îîJ K
nullable
îîL T
:
îîT U
true
îîV Z
)
îîZ [
,
îî[ \

ModifiedOn
ïï 
=
ïï  
table
ïï! &
.
ïï& '
Column
ïï' -
<
ïï- .
DateTime
ïï. 6
>
ïï6 7
(
ïï7 8
type
ïï8 <
:
ïï< =
$str
ïï> I
,
ïïI J
nullable
ïïK S
:
ïïS T
false
ïïU Z
)
ïïZ [
,
ïï[ \

ModifiedBy
ññ 
=
ññ  
table
ññ! &
.
ññ& '
Column
ññ' -
<
ññ- .
string
ññ. 4
>
ññ4 5
(
ññ5 6
type
ññ6 :
:
ññ: ;
$str
ññ< K
,
ññK L
nullable
ññM U
:
ññU V
true
ññW [
)
ññ[ \
,
ññ\ ]
	DeletedOn
óó 
=
óó 
table
óó  %
.
óó% &
Column
óó& ,
<
óó, -
DateTime
óó- 5
>
óó5 6
(
óó6 7
type
óó7 ;
:
óó; <
$str
óó= H
,
óóH I
nullable
óóJ R
:
óóR S
false
óóT Y
)
óóY Z
,
óóZ [
	DeletedBy
òò 
=
òò 
table
òò  %
.
òò% &
Column
òò& ,
<
òò, -
string
òò- 3
>
òò3 4
(
òò4 5
type
òò5 9
:
òò9 :
$str
òò; J
,
òòJ K
nullable
òòL T
:
òòT U
true
òòV Z
)
òòZ [
}
ôô 
,
ôô 
constraints
öö 
:
öö 
table
öö "
=>
öö# %
{
õõ 
table
úú 
.
úú 

PrimaryKey
úú $
(
úú$ %
$str
úú% 6
,
úú6 7
x
úú8 9
=>
úú: <
x
úú= >
.
úú> ?
CustomerTypeId
úú? M
)
úúM N
;
úúN O
}
ùù 
)
ùù 
;
ùù 
migrationBuilder
üü 
.
üü 
CreateTable
üü (
(
üü( )
name
†† 
:
†† 
$str
†† "
,
††" #
schema
°° 
:
°° 
$str
°° 
,
°° 
columns
¢¢ 
:
¢¢ 
table
¢¢ 
=>
¢¢ !
new
¢¢" %
{
££ 

FacilityId
§§ 
=
§§  
table
§§! &
.
§§& '
Column
§§' -
<
§§- .
int
§§. 1
>
§§1 2
(
§§2 3
type
§§3 7
:
§§7 8
$str
§§9 >
,
§§> ?
nullable
§§@ H
:
§§H I
false
§§J O
)
§§O P
.
•• 

Annotation
•• #
(
••# $
$str
••$ 8
,
••8 9
$str
••: @
)
••@ A
,
••A B
Facility
¶¶ 
=
¶¶ 
table
¶¶ $
.
¶¶$ %
Column
¶¶% +
<
¶¶+ ,
string
¶¶, 2
>
¶¶2 3
(
¶¶3 4
type
¶¶4 8
:
¶¶8 9
$str
¶¶: H
,
¶¶H I
	maxLength
¶¶J S
:
¶¶S T
$num
¶¶U W
,
¶¶W X
nullable
¶¶Y a
:
¶¶a b
false
¶¶c h
)
¶¶h i
,
¶¶i j
	CreatedOn
ßß 
=
ßß 
table
ßß  %
.
ßß% &
Column
ßß& ,
<
ßß, -
DateTime
ßß- 5
>
ßß5 6
(
ßß6 7
type
ßß7 ;
:
ßß; <
$str
ßß= H
,
ßßH I
nullable
ßßJ R
:
ßßR S
false
ßßT Y
)
ßßY Z
,
ßßZ [
	CreatedBy
®® 
=
®® 
table
®®  %
.
®®% &
Column
®®& ,
<
®®, -
string
®®- 3
>
®®3 4
(
®®4 5
type
®®5 9
:
®®9 :
$str
®®; J
,
®®J K
nullable
®®L T
:
®®T U
true
®®V Z
)
®®Z [
,
®®[ \

ModifiedOn
©© 
=
©©  
table
©©! &
.
©©& '
Column
©©' -
<
©©- .
DateTime
©©. 6
>
©©6 7
(
©©7 8
type
©©8 <
:
©©< =
$str
©©> I
,
©©I J
nullable
©©K S
:
©©S T
false
©©U Z
)
©©Z [
,
©©[ \

ModifiedBy
™™ 
=
™™  
table
™™! &
.
™™& '
Column
™™' -
<
™™- .
string
™™. 4
>
™™4 5
(
™™5 6
type
™™6 :
:
™™: ;
$str
™™< K
,
™™K L
nullable
™™M U
:
™™U V
true
™™W [
)
™™[ \
,
™™\ ]
	DeletedOn
´´ 
=
´´ 
table
´´  %
.
´´% &
Column
´´& ,
<
´´, -
DateTime
´´- 5
>
´´5 6
(
´´6 7
type
´´7 ;
:
´´; <
$str
´´= H
,
´´H I
nullable
´´J R
:
´´R S
false
´´T Y
)
´´Y Z
,
´´Z [
	DeletedBy
¨¨ 
=
¨¨ 
table
¨¨  %
.
¨¨% &
Column
¨¨& ,
<
¨¨, -
string
¨¨- 3
>
¨¨3 4
(
¨¨4 5
type
¨¨5 9
:
¨¨9 :
$str
¨¨; J
,
¨¨J K
nullable
¨¨L T
:
¨¨T U
true
¨¨V Z
)
¨¨Z [
}
≠≠ 
,
≠≠ 
constraints
ÆÆ 
:
ÆÆ 
table
ÆÆ "
=>
ÆÆ# %
{
ØØ 
table
∞∞ 
.
∞∞ 

PrimaryKey
∞∞ $
(
∞∞$ %
$str
∞∞% 4
,
∞∞4 5
x
∞∞6 7
=>
∞∞8 :
x
∞∞; <
.
∞∞< =

FacilityId
∞∞= G
)
∞∞G H
;
∞∞H I
}
±± 
)
±± 
;
±± 
migrationBuilder
≥≥ 
.
≥≥ 
CreateTable
≥≥ (
(
≥≥( )
name
¥¥ 
:
¥¥ 
$str
¥¥ &
,
¥¥& '
schema
µµ 
:
µµ 
$str
µµ 
,
µµ 
columns
∂∂ 
:
∂∂ 
table
∂∂ 
=>
∂∂ !
new
∂∂" %
{
∑∑ 
FloorNumberId
∏∏ !
=
∏∏" #
table
∏∏$ )
.
∏∏) *
Column
∏∏* 0
<
∏∏0 1
int
∏∏1 4
>
∏∏4 5
(
∏∏5 6
type
∏∏6 :
:
∏∏: ;
$str
∏∏< A
,
∏∏A B
nullable
∏∏C K
:
∏∏K L
false
∏∏M R
)
∏∏R S
.
ππ 

Annotation
ππ #
(
ππ# $
$str
ππ$ 8
,
ππ8 9
$str
ππ: @
)
ππ@ A
,
ππA B
FloorNumber
∫∫ 
=
∫∫  !
table
∫∫" '
.
∫∫' (
Column
∫∫( .
<
∫∫. /
string
∫∫/ 5
>
∫∫5 6
(
∫∫6 7
type
∫∫7 ;
:
∫∫; <
$str
∫∫= K
,
∫∫K L
	maxLength
∫∫M V
:
∫∫V W
$num
∫∫X Z
,
∫∫Z [
nullable
∫∫\ d
:
∫∫d e
false
∫∫f k
)
∫∫k l
,
∫∫l m
	CreatedOn
ªª 
=
ªª 
table
ªª  %
.
ªª% &
Column
ªª& ,
<
ªª, -
DateTime
ªª- 5
>
ªª5 6
(
ªª6 7
type
ªª7 ;
:
ªª; <
$str
ªª= H
,
ªªH I
nullable
ªªJ R
:
ªªR S
false
ªªT Y
)
ªªY Z
,
ªªZ [
	CreatedBy
ºº 
=
ºº 
table
ºº  %
.
ºº% &
Column
ºº& ,
<
ºº, -
string
ºº- 3
>
ºº3 4
(
ºº4 5
type
ºº5 9
:
ºº9 :
$str
ºº; J
,
ººJ K
nullable
ººL T
:
ººT U
true
ººV Z
)
ººZ [
,
ºº[ \

ModifiedOn
ΩΩ 
=
ΩΩ  
table
ΩΩ! &
.
ΩΩ& '
Column
ΩΩ' -
<
ΩΩ- .
DateTime
ΩΩ. 6
>
ΩΩ6 7
(
ΩΩ7 8
type
ΩΩ8 <
:
ΩΩ< =
$str
ΩΩ> I
,
ΩΩI J
nullable
ΩΩK S
:
ΩΩS T
false
ΩΩU Z
)
ΩΩZ [
,
ΩΩ[ \

ModifiedBy
ææ 
=
ææ  
table
ææ! &
.
ææ& '
Column
ææ' -
<
ææ- .
string
ææ. 4
>
ææ4 5
(
ææ5 6
type
ææ6 :
:
ææ: ;
$str
ææ< K
,
ææK L
nullable
ææM U
:
ææU V
true
ææW [
)
ææ[ \
,
ææ\ ]
	DeletedOn
øø 
=
øø 
table
øø  %
.
øø% &
Column
øø& ,
<
øø, -
DateTime
øø- 5
>
øø5 6
(
øø6 7
type
øø7 ;
:
øø; <
$str
øø= H
,
øøH I
nullable
øøJ R
:
øøR S
false
øøT Y
)
øøY Z
,
øøZ [
	DeletedBy
¿¿ 
=
¿¿ 
table
¿¿  %
.
¿¿% &
Column
¿¿& ,
<
¿¿, -
string
¿¿- 3
>
¿¿3 4
(
¿¿4 5
type
¿¿5 9
:
¿¿9 :
$str
¿¿; J
,
¿¿J K
nullable
¿¿L T
:
¿¿T U
true
¿¿V Z
)
¿¿Z [
}
¡¡ 
,
¡¡ 
constraints
¬¬ 
:
¬¬ 
table
¬¬ "
=>
¬¬# %
{
√√ 
table
ƒƒ 
.
ƒƒ 

PrimaryKey
ƒƒ $
(
ƒƒ$ %
$str
ƒƒ% 8
,
ƒƒ8 9
x
ƒƒ: ;
=>
ƒƒ< >
x
ƒƒ? @
.
ƒƒ@ A
FloorNumberId
ƒƒA N
)
ƒƒN O
;
ƒƒO P
}
≈≈ 
)
≈≈ 
;
≈≈ 
migrationBuilder
«« 
.
«« 
CreateTable
«« (
(
««( )
name
»» 
:
»» 
$str
»» 
,
»» 
schema
…… 
:
…… 
$str
…… 
,
…… 
columns
   
:
   
table
   
=>
   !
new
  " %
{
ÀÀ 
GenderId
ÃÃ 
=
ÃÃ 
table
ÃÃ $
.
ÃÃ$ %
Column
ÃÃ% +
<
ÃÃ+ ,
int
ÃÃ, /
>
ÃÃ/ 0
(
ÃÃ0 1
type
ÃÃ1 5
:
ÃÃ5 6
$str
ÃÃ7 <
,
ÃÃ< =
nullable
ÃÃ> F
:
ÃÃF G
false
ÃÃH M
)
ÃÃM N
.
ÕÕ 

Annotation
ÕÕ #
(
ÕÕ# $
$str
ÕÕ$ 8
,
ÕÕ8 9
$str
ÕÕ: @
)
ÕÕ@ A
,
ÕÕA B

GenderType
ŒŒ 
=
ŒŒ  
table
ŒŒ! &
.
ŒŒ& '
Column
ŒŒ' -
<
ŒŒ- .
string
ŒŒ. 4
>
ŒŒ4 5
(
ŒŒ5 6
type
ŒŒ6 :
:
ŒŒ: ;
$str
ŒŒ< J
,
ŒŒJ K
	maxLength
ŒŒL U
:
ŒŒU V
$num
ŒŒW Y
,
ŒŒY Z
nullable
ŒŒ[ c
:
ŒŒc d
false
ŒŒe j
)
ŒŒj k
,
ŒŒk l
	CreatedOn
œœ 
=
œœ 
table
œœ  %
.
œœ% &
Column
œœ& ,
<
œœ, -
DateTime
œœ- 5
>
œœ5 6
(
œœ6 7
type
œœ7 ;
:
œœ; <
$str
œœ= H
,
œœH I
nullable
œœJ R
:
œœR S
false
œœT Y
)
œœY Z
,
œœZ [
	CreatedBy
–– 
=
–– 
table
––  %
.
––% &
Column
––& ,
<
––, -
string
––- 3
>
––3 4
(
––4 5
type
––5 9
:
––9 :
$str
––; J
,
––J K
nullable
––L T
:
––T U
true
––V Z
)
––Z [
,
––[ \

ModifiedOn
—— 
=
——  
table
——! &
.
——& '
Column
——' -
<
——- .
DateTime
——. 6
>
——6 7
(
——7 8
type
——8 <
:
——< =
$str
——> I
,
——I J
nullable
——K S
:
——S T
false
——U Z
)
——Z [
,
——[ \

ModifiedBy
““ 
=
““  
table
““! &
.
““& '
Column
““' -
<
““- .
string
““. 4
>
““4 5
(
““5 6
type
““6 :
:
““: ;
$str
““< K
,
““K L
nullable
““M U
:
““U V
true
““W [
)
““[ \
,
““\ ]
	DeletedOn
”” 
=
”” 
table
””  %
.
””% &
Column
””& ,
<
””, -
DateTime
””- 5
>
””5 6
(
””6 7
type
””7 ;
:
””; <
$str
””= H
,
””H I
nullable
””J R
:
””R S
false
””T Y
)
””Y Z
,
””Z [
	DeletedBy
‘‘ 
=
‘‘ 
table
‘‘  %
.
‘‘% &
Column
‘‘& ,
<
‘‘, -
string
‘‘- 3
>
‘‘3 4
(
‘‘4 5
type
‘‘5 9
:
‘‘9 :
$str
‘‘; J
,
‘‘J K
nullable
‘‘L T
:
‘‘T U
true
‘‘V Z
)
‘‘Z [
}
’’ 
,
’’ 
constraints
÷÷ 
:
÷÷ 
table
÷÷ "
=>
÷÷# %
{
◊◊ 
table
ÿÿ 
.
ÿÿ 

PrimaryKey
ÿÿ $
(
ÿÿ$ %
$str
ÿÿ% 0
,
ÿÿ0 1
x
ÿÿ2 3
=>
ÿÿ4 6
x
ÿÿ7 8
.
ÿÿ8 9
GenderId
ÿÿ9 A
)
ÿÿA B
;
ÿÿB C
}
ŸŸ 
)
ŸŸ 
;
ŸŸ 
migrationBuilder
€€ 
.
€€ 
CreateTable
€€ (
(
€€( )
name
‹‹ 
:
‹‹ 
$str
‹‹ *
,
‹‹* +
schema
›› 
:
›› 
$str
›› 
,
›› 
columns
ﬁﬁ 
:
ﬁﬁ 
table
ﬁﬁ 
=>
ﬁﬁ !
new
ﬁﬁ" %
{
ﬂﬂ "
IdentificationTypeId
‡‡ (
=
‡‡) *
table
‡‡+ 0
.
‡‡0 1
Column
‡‡1 7
<
‡‡7 8
int
‡‡8 ;
>
‡‡; <
(
‡‡< =
type
‡‡= A
:
‡‡A B
$str
‡‡C H
,
‡‡H I
nullable
‡‡J R
:
‡‡R S
false
‡‡T Y
)
‡‡Y Z
.
·· 

Annotation
·· #
(
··# $
$str
··$ 8
,
··8 9
$str
··: @
)
··@ A
,
··A B!
IdentificationTypes
‚‚ '
=
‚‚( )
table
‚‚* /
.
‚‚/ 0
Column
‚‚0 6
<
‚‚6 7
string
‚‚7 =
>
‚‚= >
(
‚‚> ?
type
‚‚? C
:
‚‚C D
$str
‚‚E S
,
‚‚S T
	maxLength
‚‚U ^
:
‚‚^ _
$num
‚‚` b
,
‚‚b c
nullable
‚‚d l
:
‚‚l m
false
‚‚n s
)
‚‚s t
,
‚‚t u
	CreatedOn
„„ 
=
„„ 
table
„„  %
.
„„% &
Column
„„& ,
<
„„, -
DateTime
„„- 5
>
„„5 6
(
„„6 7
type
„„7 ;
:
„„; <
$str
„„= H
,
„„H I
nullable
„„J R
:
„„R S
false
„„T Y
)
„„Y Z
,
„„Z [
	CreatedBy
‰‰ 
=
‰‰ 
table
‰‰  %
.
‰‰% &
Column
‰‰& ,
<
‰‰, -
string
‰‰- 3
>
‰‰3 4
(
‰‰4 5
type
‰‰5 9
:
‰‰9 :
$str
‰‰; J
,
‰‰J K
nullable
‰‰L T
:
‰‰T U
true
‰‰V Z
)
‰‰Z [
,
‰‰[ \

ModifiedOn
ÂÂ 
=
ÂÂ  
table
ÂÂ! &
.
ÂÂ& '
Column
ÂÂ' -
<
ÂÂ- .
DateTime
ÂÂ. 6
>
ÂÂ6 7
(
ÂÂ7 8
type
ÂÂ8 <
:
ÂÂ< =
$str
ÂÂ> I
,
ÂÂI J
nullable
ÂÂK S
:
ÂÂS T
false
ÂÂU Z
)
ÂÂZ [
,
ÂÂ[ \

ModifiedBy
ÊÊ 
=
ÊÊ  
table
ÊÊ! &
.
ÊÊ& '
Column
ÊÊ' -
<
ÊÊ- .
string
ÊÊ. 4
>
ÊÊ4 5
(
ÊÊ5 6
type
ÊÊ6 :
:
ÊÊ: ;
$str
ÊÊ< K
,
ÊÊK L
nullable
ÊÊM U
:
ÊÊU V
true
ÊÊW [
)
ÊÊ[ \
,
ÊÊ\ ]
	DeletedOn
ÁÁ 
=
ÁÁ 
table
ÁÁ  %
.
ÁÁ% &
Column
ÁÁ& ,
<
ÁÁ, -
DateTime
ÁÁ- 5
>
ÁÁ5 6
(
ÁÁ6 7
type
ÁÁ7 ;
:
ÁÁ; <
$str
ÁÁ= H
,
ÁÁH I
nullable
ÁÁJ R
:
ÁÁR S
false
ÁÁT Y
)
ÁÁY Z
,
ÁÁZ [
	DeletedBy
ËË 
=
ËË 
table
ËË  %
.
ËË% &
Column
ËË& ,
<
ËË, -
string
ËË- 3
>
ËË3 4
(
ËË4 5
type
ËË5 9
:
ËË9 :
$str
ËË; J
,
ËËJ K
nullable
ËËL T
:
ËËT U
true
ËËV Z
)
ËËZ [
}
ÈÈ 
,
ÈÈ 
constraints
ÍÍ 
:
ÍÍ 
table
ÍÍ "
=>
ÍÍ# %
{
ÎÎ 
table
ÏÏ 
.
ÏÏ 

PrimaryKey
ÏÏ $
(
ÏÏ$ %
$str
ÏÏ% <
,
ÏÏ< =
x
ÏÏ> ?
=>
ÏÏ@ B
x
ÏÏC D
.
ÏÏD E"
IdentificationTypeId
ÏÏE Y
)
ÏÏY Z
;
ÏÏZ [
}
ÌÌ 
)
ÌÌ 
;
ÌÌ 
migrationBuilder
ÔÔ 
.
ÔÔ 
CreateTable
ÔÔ (
(
ÔÔ( )
name
 
:
 
$str
 
,
  
schema
ÒÒ 
:
ÒÒ 
$str
ÒÒ 
,
ÒÒ 
columns
ÚÚ 
:
ÚÚ 
table
ÚÚ 
=>
ÚÚ !
new
ÚÚ" %
{
ÛÛ 
	LandUseId
ÙÙ 
=
ÙÙ 
table
ÙÙ  %
.
ÙÙ% &
Column
ÙÙ& ,
<
ÙÙ, -
int
ÙÙ- 0
>
ÙÙ0 1
(
ÙÙ1 2
type
ÙÙ2 6
:
ÙÙ6 7
$str
ÙÙ8 =
,
ÙÙ= >
nullable
ÙÙ? G
:
ÙÙG H
false
ÙÙI N
)
ÙÙN O
.
ıı 

Annotation
ıı #
(
ıı# $
$str
ıı$ 8
,
ıı8 9
$str
ıı: @
)
ıı@ A
,
ııA B
LandUseInitial
ˆˆ "
=
ˆˆ# $
table
ˆˆ% *
.
ˆˆ* +
Column
ˆˆ+ 1
<
ˆˆ1 2
string
ˆˆ2 8
>
ˆˆ8 9
(
ˆˆ9 :
type
ˆˆ: >
:
ˆˆ> ?
$str
ˆˆ@ M
,
ˆˆM N
	maxLength
ˆˆO X
:
ˆˆX Y
$num
ˆˆZ [
,
ˆˆ[ \
nullable
ˆˆ] e
:
ˆˆe f
false
ˆˆg l
)
ˆˆl m
,
ˆˆm n
LandUseName
˜˜ 
=
˜˜  !
table
˜˜" '
.
˜˜' (
Column
˜˜( .
<
˜˜. /
string
˜˜/ 5
>
˜˜5 6
(
˜˜6 7
type
˜˜7 ;
:
˜˜; <
$str
˜˜= K
,
˜˜K L
	maxLength
˜˜M V
:
˜˜V W
$num
˜˜X Z
,
˜˜Z [
nullable
˜˜\ d
:
˜˜d e
false
˜˜f k
)
˜˜k l
,
˜˜l m
	CreatedOn
¯¯ 
=
¯¯ 
table
¯¯  %
.
¯¯% &
Column
¯¯& ,
<
¯¯, -
DateTime
¯¯- 5
>
¯¯5 6
(
¯¯6 7
type
¯¯7 ;
:
¯¯; <
$str
¯¯= H
,
¯¯H I
nullable
¯¯J R
:
¯¯R S
false
¯¯T Y
)
¯¯Y Z
,
¯¯Z [
	CreatedBy
˘˘ 
=
˘˘ 
table
˘˘  %
.
˘˘% &
Column
˘˘& ,
<
˘˘, -
string
˘˘- 3
>
˘˘3 4
(
˘˘4 5
type
˘˘5 9
:
˘˘9 :
$str
˘˘; J
,
˘˘J K
nullable
˘˘L T
:
˘˘T U
true
˘˘V Z
)
˘˘Z [
,
˘˘[ \

ModifiedOn
˙˙ 
=
˙˙  
table
˙˙! &
.
˙˙& '
Column
˙˙' -
<
˙˙- .
DateTime
˙˙. 6
>
˙˙6 7
(
˙˙7 8
type
˙˙8 <
:
˙˙< =
$str
˙˙> I
,
˙˙I J
nullable
˙˙K S
:
˙˙S T
false
˙˙U Z
)
˙˙Z [
,
˙˙[ \

ModifiedBy
˚˚ 
=
˚˚  
table
˚˚! &
.
˚˚& '
Column
˚˚' -
<
˚˚- .
string
˚˚. 4
>
˚˚4 5
(
˚˚5 6
type
˚˚6 :
:
˚˚: ;
$str
˚˚< K
,
˚˚K L
nullable
˚˚M U
:
˚˚U V
true
˚˚W [
)
˚˚[ \
,
˚˚\ ]
	DeletedOn
¸¸ 
=
¸¸ 
table
¸¸  %
.
¸¸% &
Column
¸¸& ,
<
¸¸, -
DateTime
¸¸- 5
>
¸¸5 6
(
¸¸6 7
type
¸¸7 ;
:
¸¸; <
$str
¸¸= H
,
¸¸H I
nullable
¸¸J R
:
¸¸R S
false
¸¸T Y
)
¸¸Y Z
,
¸¸Z [
	DeletedBy
˝˝ 
=
˝˝ 
table
˝˝  %
.
˝˝% &
Column
˝˝& ,
<
˝˝, -
string
˝˝- 3
>
˝˝3 4
(
˝˝4 5
type
˝˝5 9
:
˝˝9 :
$str
˝˝; J
,
˝˝J K
nullable
˝˝L T
:
˝˝T U
true
˝˝V Z
)
˝˝Z [
}
˛˛ 
,
˛˛ 
constraints
ˇˇ 
:
ˇˇ 
table
ˇˇ "
=>
ˇˇ# %
{
ÄÄ 
table
ÅÅ 
.
ÅÅ 

PrimaryKey
ÅÅ $
(
ÅÅ$ %
$str
ÅÅ% 1
,
ÅÅ1 2
x
ÅÅ3 4
=>
ÅÅ5 7
x
ÅÅ8 9
.
ÅÅ9 :
	LandUseId
ÅÅ: C
)
ÅÅC D
;
ÅÅD E
}
ÇÇ 
)
ÇÇ 
;
ÇÇ 
migrationBuilder
ÑÑ 
.
ÑÑ 
CreateTable
ÑÑ (
(
ÑÑ( )
name
ÖÖ 
:
ÖÖ 
$str
ÖÖ #
,
ÖÖ# $
schema
ÜÜ 
:
ÜÜ 
$str
ÜÜ 
,
ÜÜ 
columns
áá 
:
áá 
table
áá 
=>
áá !
new
áá" %
{
àà 
LandUseTypeId
ââ !
=
ââ" #
table
ââ$ )
.
ââ) *
Column
ââ* 0
<
ââ0 1
int
ââ1 4
>
ââ4 5
(
ââ5 6
type
ââ6 :
:
ââ: ;
$str
ââ< A
,
ââA B
nullable
ââC K
:
ââK L
false
ââM R
)
ââR S
.
ää 

Annotation
ää #
(
ää# $
$str
ää$ 8
,
ää8 9
$str
ää: @
)
ää@ A
,
ääA B
	LandUseId
ãã 
=
ãã 
table
ãã  %
.
ãã% &
Column
ãã& ,
<
ãã, -
int
ãã- 0
>
ãã0 1
(
ãã1 2
type
ãã2 6
:
ãã6 7
$str
ãã8 =
,
ãã= >
nullable
ãã? G
:
ããG H
false
ããI N
)
ããN O
,
ããO P 
LandUseTypeInitial
åå &
=
åå' (
table
åå) .
.
åå. /
Column
åå/ 5
<
åå5 6
string
åå6 <
>
åå< =
(
åå= >
type
åå> B
:
ååB C
$str
ååD Q
,
ååQ R
	maxLength
ååS \
:
åå\ ]
$num
åå^ _
,
åå_ `
nullable
ååa i
:
ååi j
false
ååk p
)
ååp q
,
ååq r
LandUseTypeName
çç #
=
çç$ %
table
çç& +
.
çç+ ,
Column
çç, 2
<
çç2 3
string
çç3 9
>
çç9 :
(
çç: ;
type
çç; ?
:
çç? @
$str
ççA O
,
ççO P
	maxLength
ççQ Z
:
ççZ [
$num
çç\ ^
,
çç^ _
nullable
çç` h
:
ççh i
false
ççj o
)
çço p
,
ççp q
	CreatedOn
éé 
=
éé 
table
éé  %
.
éé% &
Column
éé& ,
<
éé, -
DateTime
éé- 5
>
éé5 6
(
éé6 7
type
éé7 ;
:
éé; <
$str
éé= H
,
ééH I
nullable
ééJ R
:
ééR S
false
ééT Y
)
ééY Z
,
ééZ [
	CreatedBy
èè 
=
èè 
table
èè  %
.
èè% &
Column
èè& ,
<
èè, -
string
èè- 3
>
èè3 4
(
èè4 5
type
èè5 9
:
èè9 :
$str
èè; J
,
èèJ K
nullable
èèL T
:
èèT U
true
èèV Z
)
èèZ [
,
èè[ \

ModifiedOn
êê 
=
êê  
table
êê! &
.
êê& '
Column
êê' -
<
êê- .
DateTime
êê. 6
>
êê6 7
(
êê7 8
type
êê8 <
:
êê< =
$str
êê> I
,
êêI J
nullable
êêK S
:
êêS T
false
êêU Z
)
êêZ [
,
êê[ \

ModifiedBy
ëë 
=
ëë  
table
ëë! &
.
ëë& '
Column
ëë' -
<
ëë- .
string
ëë. 4
>
ëë4 5
(
ëë5 6
type
ëë6 :
:
ëë: ;
$str
ëë< K
,
ëëK L
nullable
ëëM U
:
ëëU V
true
ëëW [
)
ëë[ \
,
ëë\ ]
	DeletedOn
íí 
=
íí 
table
íí  %
.
íí% &
Column
íí& ,
<
íí, -
DateTime
íí- 5
>
íí5 6
(
íí6 7
type
íí7 ;
:
íí; <
$str
íí= H
,
ííH I
nullable
ííJ R
:
ííR S
false
ííT Y
)
ííY Z
,
ííZ [
	DeletedBy
ìì 
=
ìì 
table
ìì  %
.
ìì% &
Column
ìì& ,
<
ìì, -
string
ìì- 3
>
ìì3 4
(
ìì4 5
type
ìì5 9
:
ìì9 :
$str
ìì; J
,
ììJ K
nullable
ììL T
:
ììT U
true
ììV Z
)
ììZ [
}
îî 
,
îî 
constraints
ïï 
:
ïï 
table
ïï "
=>
ïï# %
{
ññ 
table
óó 
.
óó 

PrimaryKey
óó $
(
óó$ %
$str
óó% 5
,
óó5 6
x
óó7 8
=>
óó9 ;
x
óó< =
.
óó= >
LandUseTypeId
óó> K
)
óóK L
;
óóL M
}
òò 
)
òò 
;
òò 
migrationBuilder
öö 
.
öö 
CreateTable
öö (
(
öö( )
name
õõ 
:
õõ 
$str
õõ  
,
õõ  !
schema
úú 
:
úú 
$str
úú 
,
úú 
columns
ùù 
:
ùù 
table
ùù 
=>
ùù !
new
ùù" %
{
ûû 

LocalityId
üü 
=
üü  
table
üü! &
.
üü& '
Column
üü' -
<
üü- .
int
üü. 1
>
üü1 2
(
üü2 3
type
üü3 7
:
üü7 8
$str
üü9 >
,
üü> ?
nullable
üü@ H
:
üüH I
false
üüJ O
)
üüO P
.
†† 

Annotation
†† #
(
††# $
$str
††$ 8
,
††8 9
$str
††: @
)
††@ A
,
††A B
LocalityInitial
°° #
=
°°$ %
table
°°& +
.
°°+ ,
Column
°°, 2
<
°°2 3
string
°°3 9
>
°°9 :
(
°°: ;
type
°°; ?
:
°°? @
$str
°°A O
,
°°O P
	maxLength
°°Q Z
:
°°Z [
$num
°°\ ^
,
°°^ _
nullable
°°` h
:
°°h i
false
°°j o
)
°°o p
,
°°p q
LocalityName
¢¢  
=
¢¢! "
table
¢¢# (
.
¢¢( )
Column
¢¢) /
<
¢¢/ 0
string
¢¢0 6
>
¢¢6 7
(
¢¢7 8
type
¢¢8 <
:
¢¢< =
$str
¢¢> L
,
¢¢L M
	maxLength
¢¢N W
:
¢¢W X
$num
¢¢Y [
,
¢¢[ \
nullable
¢¢] e
:
¢¢e f
false
¢¢g l
)
¢¢l m
,
¢¢m n
CustomerCode
££  
=
££! "
table
££# (
.
££( )
Column
££) /
<
££/ 0
string
££0 6
>
££6 7
(
££7 8
type
££8 <
:
££< =
$str
££> K
,
££K L
	maxLength
££M V
:
££V W
$num
££X Y
,
££Y Z
nullable
££[ c
:
££c d
false
££e j
)
££j k
,
££k l!
CustomerCodeCounter
§§ '
=
§§( )
table
§§* /
.
§§/ 0
Column
§§0 6
<
§§6 7
int
§§7 :
>
§§: ;
(
§§; <
type
§§< @
:
§§@ A
$str
§§B G
,
§§G H
nullable
§§I Q
:
§§Q R
false
§§S X
)
§§X Y
,
§§Y Z
	CreatedOn
•• 
=
•• 
table
••  %
.
••% &
Column
••& ,
<
••, -
DateTime
••- 5
>
••5 6
(
••6 7
type
••7 ;
:
••; <
$str
••= H
,
••H I
nullable
••J R
:
••R S
false
••T Y
)
••Y Z
,
••Z [
	CreatedBy
¶¶ 
=
¶¶ 
table
¶¶  %
.
¶¶% &
Column
¶¶& ,
<
¶¶, -
string
¶¶- 3
>
¶¶3 4
(
¶¶4 5
type
¶¶5 9
:
¶¶9 :
$str
¶¶; J
,
¶¶J K
nullable
¶¶L T
:
¶¶T U
true
¶¶V Z
)
¶¶Z [
,
¶¶[ \

ModifiedOn
ßß 
=
ßß  
table
ßß! &
.
ßß& '
Column
ßß' -
<
ßß- .
DateTime
ßß. 6
>
ßß6 7
(
ßß7 8
type
ßß8 <
:
ßß< =
$str
ßß> I
,
ßßI J
nullable
ßßK S
:
ßßS T
false
ßßU Z
)
ßßZ [
,
ßß[ \

ModifiedBy
®® 
=
®®  
table
®®! &
.
®®& '
Column
®®' -
<
®®- .
string
®®. 4
>
®®4 5
(
®®5 6
type
®®6 :
:
®®: ;
$str
®®< K
,
®®K L
nullable
®®M U
:
®®U V
true
®®W [
)
®®[ \
,
®®\ ]
	DeletedOn
©© 
=
©© 
table
©©  %
.
©©% &
Column
©©& ,
<
©©, -
DateTime
©©- 5
>
©©5 6
(
©©6 7
type
©©7 ;
:
©©; <
$str
©©= H
,
©©H I
nullable
©©J R
:
©©R S
false
©©T Y
)
©©Y Z
,
©©Z [
	DeletedBy
™™ 
=
™™ 
table
™™  %
.
™™% &
Column
™™& ,
<
™™, -
string
™™- 3
>
™™3 4
(
™™4 5
type
™™5 9
:
™™9 :
$str
™™; J
,
™™J K
nullable
™™L T
:
™™T U
true
™™V Z
)
™™Z [
}
´´ 
,
´´ 
constraints
¨¨ 
:
¨¨ 
table
¨¨ "
=>
¨¨# %
{
≠≠ 
table
ÆÆ 
.
ÆÆ 

PrimaryKey
ÆÆ $
(
ÆÆ$ %
$str
ÆÆ% 2
,
ÆÆ2 3
x
ÆÆ4 5
=>
ÆÆ6 8
x
ÆÆ9 :
.
ÆÆ: ;

LocalityId
ÆÆ; E
)
ÆÆE F
;
ÆÆF G
}
ØØ 
)
ØØ 
;
ØØ 
migrationBuilder
±± 
.
±± 
CreateTable
±± (
(
±±( )
name
≤≤ 
:
≤≤ 
$str
≤≤ #
,
≤≤# $
schema
≥≥ 
:
≥≥ 
$str
≥≥ 
,
≥≥ 
columns
¥¥ 
:
¥¥ 
table
¥¥ 
=>
¥¥ !
new
¥¥" %
{
µµ 
NationalityId
∂∂ !
=
∂∂" #
table
∂∂$ )
.
∂∂) *
Column
∂∂* 0
<
∂∂0 1
int
∂∂1 4
>
∂∂4 5
(
∂∂5 6
type
∂∂6 :
:
∂∂: ;
$str
∂∂< A
,
∂∂A B
nullable
∂∂C K
:
∂∂K L
false
∂∂M R
)
∂∂R S
.
∑∑ 

Annotation
∑∑ #
(
∑∑# $
$str
∑∑$ 8
,
∑∑8 9
$str
∑∑: @
)
∑∑@ A
,
∑∑A B
Nationalities
∏∏ !
=
∏∏" #
table
∏∏$ )
.
∏∏) *
Column
∏∏* 0
<
∏∏0 1
string
∏∏1 7
>
∏∏7 8
(
∏∏8 9
type
∏∏9 =
:
∏∏= >
$str
∏∏? M
,
∏∏M N
	maxLength
∏∏O X
:
∏∏X Y
$num
∏∏Z \
,
∏∏\ ]
nullable
∏∏^ f
:
∏∏f g
false
∏∏h m
)
∏∏m n
,
∏∏n o
	CreatedOn
ππ 
=
ππ 
table
ππ  %
.
ππ% &
Column
ππ& ,
<
ππ, -
DateTime
ππ- 5
>
ππ5 6
(
ππ6 7
type
ππ7 ;
:
ππ; <
$str
ππ= H
,
ππH I
nullable
ππJ R
:
ππR S
false
ππT Y
)
ππY Z
,
ππZ [
	CreatedBy
∫∫ 
=
∫∫ 
table
∫∫  %
.
∫∫% &
Column
∫∫& ,
<
∫∫, -
string
∫∫- 3
>
∫∫3 4
(
∫∫4 5
type
∫∫5 9
:
∫∫9 :
$str
∫∫; J
,
∫∫J K
nullable
∫∫L T
:
∫∫T U
true
∫∫V Z
)
∫∫Z [
,
∫∫[ \

ModifiedOn
ªª 
=
ªª  
table
ªª! &
.
ªª& '
Column
ªª' -
<
ªª- .
DateTime
ªª. 6
>
ªª6 7
(
ªª7 8
type
ªª8 <
:
ªª< =
$str
ªª> I
,
ªªI J
nullable
ªªK S
:
ªªS T
false
ªªU Z
)
ªªZ [
,
ªª[ \

ModifiedBy
ºº 
=
ºº  
table
ºº! &
.
ºº& '
Column
ºº' -
<
ºº- .
string
ºº. 4
>
ºº4 5
(
ºº5 6
type
ºº6 :
:
ºº: ;
$str
ºº< K
,
ººK L
nullable
ººM U
:
ººU V
true
ººW [
)
ºº[ \
,
ºº\ ]
	DeletedOn
ΩΩ 
=
ΩΩ 
table
ΩΩ  %
.
ΩΩ% &
Column
ΩΩ& ,
<
ΩΩ, -
DateTime
ΩΩ- 5
>
ΩΩ5 6
(
ΩΩ6 7
type
ΩΩ7 ;
:
ΩΩ; <
$str
ΩΩ= H
,
ΩΩH I
nullable
ΩΩJ R
:
ΩΩR S
false
ΩΩT Y
)
ΩΩY Z
,
ΩΩZ [
	DeletedBy
ææ 
=
ææ 
table
ææ  %
.
ææ% &
Column
ææ& ,
<
ææ, -
string
ææ- 3
>
ææ3 4
(
ææ4 5
type
ææ5 9
:
ææ9 :
$str
ææ; J
,
ææJ K
nullable
ææL T
:
ææT U
true
ææV Z
)
ææZ [
}
øø 
,
øø 
constraints
¿¿ 
:
¿¿ 
table
¿¿ "
=>
¿¿# %
{
¡¡ 
table
¬¬ 
.
¬¬ 

PrimaryKey
¬¬ $
(
¬¬$ %
$str
¬¬% 5
,
¬¬5 6
x
¬¬7 8
=>
¬¬9 ;
x
¬¬< =
.
¬¬= >
NationalityId
¬¬> K
)
¬¬K L
;
¬¬L M
}
√√ 
)
√√ 
;
√√ 
migrationBuilder
≈≈ 
.
≈≈ 
CreateTable
≈≈ (
(
≈≈( )
name
∆∆ 
:
∆∆ 
$str
∆∆ %
,
∆∆% &
schema
«« 
:
«« 
$str
«« 
,
«« 
columns
»» 
:
»» 
table
»» 
=>
»» !
new
»»" %
{
…… 
OwnershipTypeId
   #
=
  $ %
table
  & +
.
  + ,
Column
  , 2
<
  2 3
int
  3 6
>
  6 7
(
  7 8
type
  8 <
:
  < =
$str
  > C
,
  C D
nullable
  E M
:
  M N
false
  O T
)
  T U
.
ÀÀ 

Annotation
ÀÀ #
(
ÀÀ# $
$str
ÀÀ$ 8
,
ÀÀ8 9
$str
ÀÀ: @
)
ÀÀ@ A
,
ÀÀA B
OwnershipTypes
ÃÃ "
=
ÃÃ# $
table
ÃÃ% *
.
ÃÃ* +
Column
ÃÃ+ 1
<
ÃÃ1 2
string
ÃÃ2 8
>
ÃÃ8 9
(
ÃÃ9 :
type
ÃÃ: >
:
ÃÃ> ?
$str
ÃÃ@ N
,
ÃÃN O
	maxLength
ÃÃP Y
:
ÃÃY Z
$num
ÃÃ[ ]
,
ÃÃ] ^
nullable
ÃÃ_ g
:
ÃÃg h
false
ÃÃi n
)
ÃÃn o
,
ÃÃo p
	CreatedOn
ÕÕ 
=
ÕÕ 
table
ÕÕ  %
.
ÕÕ% &
Column
ÕÕ& ,
<
ÕÕ, -
DateTime
ÕÕ- 5
>
ÕÕ5 6
(
ÕÕ6 7
type
ÕÕ7 ;
:
ÕÕ; <
$str
ÕÕ= H
,
ÕÕH I
nullable
ÕÕJ R
:
ÕÕR S
false
ÕÕT Y
)
ÕÕY Z
,
ÕÕZ [
	CreatedBy
ŒŒ 
=
ŒŒ 
table
ŒŒ  %
.
ŒŒ% &
Column
ŒŒ& ,
<
ŒŒ, -
string
ŒŒ- 3
>
ŒŒ3 4
(
ŒŒ4 5
type
ŒŒ5 9
:
ŒŒ9 :
$str
ŒŒ; J
,
ŒŒJ K
nullable
ŒŒL T
:
ŒŒT U
true
ŒŒV Z
)
ŒŒZ [
,
ŒŒ[ \

ModifiedOn
œœ 
=
œœ  
table
œœ! &
.
œœ& '
Column
œœ' -
<
œœ- .
DateTime
œœ. 6
>
œœ6 7
(
œœ7 8
type
œœ8 <
:
œœ< =
$str
œœ> I
,
œœI J
nullable
œœK S
:
œœS T
false
œœU Z
)
œœZ [
,
œœ[ \

ModifiedBy
–– 
=
––  
table
––! &
.
––& '
Column
––' -
<
––- .
string
––. 4
>
––4 5
(
––5 6
type
––6 :
:
––: ;
$str
––< K
,
––K L
nullable
––M U
:
––U V
true
––W [
)
––[ \
,
––\ ]
	DeletedOn
—— 
=
—— 
table
——  %
.
——% &
Column
——& ,
<
——, -
DateTime
——- 5
>
——5 6
(
——6 7
type
——7 ;
:
——; <
$str
——= H
,
——H I
nullable
——J R
:
——R S
false
——T Y
)
——Y Z
,
——Z [
	DeletedBy
““ 
=
““ 
table
““  %
.
““% &
Column
““& ,
<
““, -
string
““- 3
>
““3 4
(
““4 5
type
““5 9
:
““9 :
$str
““; J
,
““J K
nullable
““L T
:
““T U
true
““V Z
)
““Z [
}
”” 
,
”” 
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
÷÷ 
.
÷÷ 

PrimaryKey
÷÷ $
(
÷÷$ %
$str
÷÷% 7
,
÷÷7 8
x
÷÷9 :
=>
÷÷; =
x
÷÷> ?
.
÷÷? @
OwnershipTypeId
÷÷@ O
)
÷÷O P
;
÷÷P Q
}
◊◊ 
)
◊◊ 
;
◊◊ 
migrationBuilder
ŸŸ 
.
ŸŸ 
CreateTable
ŸŸ (
(
ŸŸ( )
name
⁄⁄ 
:
⁄⁄ 
$str
⁄⁄  
,
⁄⁄  !
schema
€€ 
:
€€ 
$str
€€ 
,
€€ 
columns
‹‹ 
:
‹‹ 
table
‹‹ 
=>
‹‹ !
new
‹‹" %
{
›› 

PlotSizeId
ﬁﬁ 
=
ﬁﬁ  
table
ﬁﬁ! &
.
ﬁﬁ& '
Column
ﬁﬁ' -
<
ﬁﬁ- .
int
ﬁﬁ. 1
>
ﬁﬁ1 2
(
ﬁﬁ2 3
type
ﬁﬁ3 7
:
ﬁﬁ7 8
$str
ﬁﬁ9 >
,
ﬁﬁ> ?
nullable
ﬁﬁ@ H
:
ﬁﬁH I
false
ﬁﬁJ O
)
ﬁﬁO P
.
ﬂﬂ 

Annotation
ﬂﬂ #
(
ﬂﬂ# $
$str
ﬂﬂ$ 8
,
ﬂﬂ8 9
$str
ﬂﬂ: @
)
ﬂﬂ@ A
,
ﬂﬂA B
	PlotSizes
‡‡ 
=
‡‡ 
table
‡‡  %
.
‡‡% &
Column
‡‡& ,
<
‡‡, -
string
‡‡- 3
>
‡‡3 4
(
‡‡4 5
type
‡‡5 9
:
‡‡9 :
$str
‡‡; I
,
‡‡I J
	maxLength
‡‡K T
:
‡‡T U
$num
‡‡V X
,
‡‡X Y
nullable
‡‡Z b
:
‡‡b c
false
‡‡d i
)
‡‡i j
,
‡‡j k
	CreatedOn
·· 
=
·· 
table
··  %
.
··% &
Column
··& ,
<
··, -
DateTime
··- 5
>
··5 6
(
··6 7
type
··7 ;
:
··; <
$str
··= H
,
··H I
nullable
··J R
:
··R S
false
··T Y
)
··Y Z
,
··Z [
	CreatedBy
‚‚ 
=
‚‚ 
table
‚‚  %
.
‚‚% &
Column
‚‚& ,
<
‚‚, -
string
‚‚- 3
>
‚‚3 4
(
‚‚4 5
type
‚‚5 9
:
‚‚9 :
$str
‚‚; J
,
‚‚J K
nullable
‚‚L T
:
‚‚T U
true
‚‚V Z
)
‚‚Z [
,
‚‚[ \

ModifiedOn
„„ 
=
„„  
table
„„! &
.
„„& '
Column
„„' -
<
„„- .
DateTime
„„. 6
>
„„6 7
(
„„7 8
type
„„8 <
:
„„< =
$str
„„> I
,
„„I J
nullable
„„K S
:
„„S T
false
„„U Z
)
„„Z [
,
„„[ \

ModifiedBy
‰‰ 
=
‰‰  
table
‰‰! &
.
‰‰& '
Column
‰‰' -
<
‰‰- .
string
‰‰. 4
>
‰‰4 5
(
‰‰5 6
type
‰‰6 :
:
‰‰: ;
$str
‰‰< K
,
‰‰K L
nullable
‰‰M U
:
‰‰U V
true
‰‰W [
)
‰‰[ \
,
‰‰\ ]
	DeletedOn
ÂÂ 
=
ÂÂ 
table
ÂÂ  %
.
ÂÂ% &
Column
ÂÂ& ,
<
ÂÂ, -
DateTime
ÂÂ- 5
>
ÂÂ5 6
(
ÂÂ6 7
type
ÂÂ7 ;
:
ÂÂ; <
$str
ÂÂ= H
,
ÂÂH I
nullable
ÂÂJ R
:
ÂÂR S
false
ÂÂT Y
)
ÂÂY Z
,
ÂÂZ [
	DeletedBy
ÊÊ 
=
ÊÊ 
table
ÊÊ  %
.
ÊÊ% &
Column
ÊÊ& ,
<
ÊÊ, -
string
ÊÊ- 3
>
ÊÊ3 4
(
ÊÊ4 5
type
ÊÊ5 9
:
ÊÊ9 :
$str
ÊÊ; J
,
ÊÊJ K
nullable
ÊÊL T
:
ÊÊT U
true
ÊÊV Z
)
ÊÊZ [
}
ÁÁ 
,
ÁÁ 
constraints
ËË 
:
ËË 
table
ËË "
=>
ËË# %
{
ÈÈ 
table
ÍÍ 
.
ÍÍ 

PrimaryKey
ÍÍ $
(
ÍÍ$ %
$str
ÍÍ% 2
,
ÍÍ2 3
x
ÍÍ4 5
=>
ÍÍ6 8
x
ÍÍ9 :
.
ÍÍ: ;

PlotSizeId
ÍÍ; E
)
ÍÍE F
;
ÍÍF G
}
ÎÎ 
)
ÎÎ 
;
ÎÎ 
migrationBuilder
ÌÌ 
.
ÌÌ 
CreateTable
ÌÌ (
(
ÌÌ( )
name
ÓÓ 
:
ÓÓ 
$str
ÓÓ &
,
ÓÓ& '
schema
ÔÔ 
:
ÔÔ 
$str
ÔÔ 
,
ÔÔ 
columns
 
:
 
table
 
=>
 !
new
" %
{
ÒÒ 
PropertyHeightId
ÚÚ $
=
ÚÚ% &
table
ÚÚ' ,
.
ÚÚ, -
Column
ÚÚ- 3
<
ÚÚ3 4
int
ÚÚ4 7
>
ÚÚ7 8
(
ÚÚ8 9
type
ÚÚ9 =
:
ÚÚ= >
$str
ÚÚ? D
,
ÚÚD E
nullable
ÚÚF N
:
ÚÚN O
false
ÚÚP U
)
ÚÚU V
.
ÛÛ 

Annotation
ÛÛ #
(
ÛÛ# $
$str
ÛÛ$ 8
,
ÛÛ8 9
$str
ÛÛ: @
)
ÛÛ@ A
,
ÛÛA B
PropertyHeights
ÙÙ #
=
ÙÙ$ %
table
ÙÙ& +
.
ÙÙ+ ,
Column
ÙÙ, 2
<
ÙÙ2 3
string
ÙÙ3 9
>
ÙÙ9 :
(
ÙÙ: ;
type
ÙÙ; ?
:
ÙÙ? @
$str
ÙÙA O
,
ÙÙO P
	maxLength
ÙÙQ Z
:
ÙÙZ [
$num
ÙÙ\ ^
,
ÙÙ^ _
nullable
ÙÙ` h
:
ÙÙh i
false
ÙÙj o
)
ÙÙo p
,
ÙÙp q
	CreatedOn
ıı 
=
ıı 
table
ıı  %
.
ıı% &
Column
ıı& ,
<
ıı, -
DateTime
ıı- 5
>
ıı5 6
(
ıı6 7
type
ıı7 ;
:
ıı; <
$str
ıı= H
,
ııH I
nullable
ııJ R
:
ııR S
false
ııT Y
)
ııY Z
,
ııZ [
	CreatedBy
ˆˆ 
=
ˆˆ 
table
ˆˆ  %
.
ˆˆ% &
Column
ˆˆ& ,
<
ˆˆ, -
string
ˆˆ- 3
>
ˆˆ3 4
(
ˆˆ4 5
type
ˆˆ5 9
:
ˆˆ9 :
$str
ˆˆ; J
,
ˆˆJ K
nullable
ˆˆL T
:
ˆˆT U
true
ˆˆV Z
)
ˆˆZ [
,
ˆˆ[ \

ModifiedOn
˜˜ 
=
˜˜  
table
˜˜! &
.
˜˜& '
Column
˜˜' -
<
˜˜- .
DateTime
˜˜. 6
>
˜˜6 7
(
˜˜7 8
type
˜˜8 <
:
˜˜< =
$str
˜˜> I
,
˜˜I J
nullable
˜˜K S
:
˜˜S T
false
˜˜U Z
)
˜˜Z [
,
˜˜[ \

ModifiedBy
¯¯ 
=
¯¯  
table
¯¯! &
.
¯¯& '
Column
¯¯' -
<
¯¯- .
string
¯¯. 4
>
¯¯4 5
(
¯¯5 6
type
¯¯6 :
:
¯¯: ;
$str
¯¯< K
,
¯¯K L
nullable
¯¯M U
:
¯¯U V
true
¯¯W [
)
¯¯[ \
,
¯¯\ ]
	DeletedOn
˘˘ 
=
˘˘ 
table
˘˘  %
.
˘˘% &
Column
˘˘& ,
<
˘˘, -
DateTime
˘˘- 5
>
˘˘5 6
(
˘˘6 7
type
˘˘7 ;
:
˘˘; <
$str
˘˘= H
,
˘˘H I
nullable
˘˘J R
:
˘˘R S
false
˘˘T Y
)
˘˘Y Z
,
˘˘Z [
	DeletedBy
˙˙ 
=
˙˙ 
table
˙˙  %
.
˙˙% &
Column
˙˙& ,
<
˙˙, -
string
˙˙- 3
>
˙˙3 4
(
˙˙4 5
type
˙˙5 9
:
˙˙9 :
$str
˙˙; J
,
˙˙J K
nullable
˙˙L T
:
˙˙T U
true
˙˙V Z
)
˙˙Z [
}
˚˚ 
,
˚˚ 
constraints
¸¸ 
:
¸¸ 
table
¸¸ "
=>
¸¸# %
{
˝˝ 
table
˛˛ 
.
˛˛ 

PrimaryKey
˛˛ $
(
˛˛$ %
$str
˛˛% 8
,
˛˛8 9
x
˛˛: ;
=>
˛˛< >
x
˛˛? @
.
˛˛@ A
PropertyHeightId
˛˛A Q
)
˛˛Q R
;
˛˛R S
}
ˇˇ 
)
ˇˇ 
;
ˇˇ 
migrationBuilder
ÅÅ 
.
ÅÅ 
CreateTable
ÅÅ (
(
ÅÅ( )
name
ÇÇ 
:
ÇÇ 
$str
ÇÇ &
,
ÇÇ& '
schema
ÉÉ 
:
ÉÉ 
$str
ÉÉ 
,
ÉÉ 
columns
ÑÑ 
:
ÑÑ 
table
ÑÑ 
=>
ÑÑ !
new
ÑÑ" %
{
ÖÖ 
PropertyMasterId
ÜÜ $
=
ÜÜ% &
table
ÜÜ' ,
.
ÜÜ, -
Column
ÜÜ- 3
<
ÜÜ3 4
int
ÜÜ4 7
>
ÜÜ7 8
(
ÜÜ8 9
type
ÜÜ9 =
:
ÜÜ= >
$str
ÜÜ? D
,
ÜÜD E
nullable
ÜÜF N
:
ÜÜN O
false
ÜÜP U
)
ÜÜU V
.
áá 

Annotation
áá #
(
áá# $
$str
áá$ 8
,
áá8 9
$str
áá: @
)
áá@ A
,
ááA B
PropertyNumber
àà "
=
àà# $
table
àà% *
.
àà* +
Column
àà+ 1
<
àà1 2
string
àà2 8
>
àà8 9
(
àà9 :
type
àà: >
:
àà> ?
$str
àà@ N
,
ààN O
	maxLength
ààP Y
:
ààY Z
$num
àà[ ]
,
àà] ^
nullable
àà_ g
:
ààg h
false
àài n
)
ààn o
,
àào p
PropertyTypeId
ââ "
=
ââ# $
table
ââ% *
.
ââ* +
Column
ââ+ 1
<
ââ1 2
int
ââ2 5
>
ââ5 6
(
ââ6 7
type
ââ7 ;
:
ââ; <
$str
ââ= B
,
ââB C
nullable
ââD L
:
ââL M
false
ââN S
)
ââS T
,
ââT U

LocalityId
ää 
=
ää  
table
ää! &
.
ää& '
Column
ää' -
<
ää- .
int
ää. 1
>
ää1 2
(
ää2 3
type
ää3 7
:
ää7 8
$str
ää9 >
,
ää> ?
nullable
ää@ H
:
ääH I
false
ääJ O
)
ääO P
,
ääP Q
	LandUseId
ãã 
=
ãã 
table
ãã  %
.
ãã% &
Column
ãã& ,
<
ãã, -
int
ãã- 0
>
ãã0 1
(
ãã1 2
type
ãã2 6
:
ãã6 7
$str
ãã8 =
,
ãã= >
nullable
ãã? G
:
ããG H
false
ããI N
)
ããN O
,
ããO P
LandUseTypeId
åå !
=
åå" #
table
åå$ )
.
åå) *
Column
åå* 0
<
åå0 1
int
åå1 4
>
åå4 5
(
åå5 6
type
åå6 :
:
åå: ;
$str
åå< A
,
ååA B
nullable
ååC K
:
ååK L
false
ååM R
)
ååR S
,
ååS T
AllocationTypeId
çç $
=
çç% &
table
çç' ,
.
çç, -
Column
çç- 3
<
çç3 4
int
çç4 7
>
çç7 8
(
çç8 9
type
çç9 =
:
çç= >
$str
çç? D
,
ççD E
nullable
ççF N
:
ççN O
false
ççP U
)
ççU V
,
ççV W
BlockNumber
éé 
=
éé  !
table
éé" '
.
éé' (
Column
éé( .
<
éé. /
string
éé/ 5
>
éé5 6
(
éé6 7
type
éé7 ;
:
éé; <
$str
éé= J
,
ééJ K
	maxLength
ééL U
:
ééU V
$num
ééW X
,
ééX Y
nullable
ééZ b
:
ééb c
true
ééd h
)
ééh i
,
ééi j

PlotNumber
èè 
=
èè  
table
èè! &
.
èè& '
Column
èè' -
<
èè- .
string
èè. 4
>
èè4 5
(
èè5 6
type
èè6 :
:
èè: ;
$str
èè< I
,
èèI J
	maxLength
èèK T
:
èèT U
$num
èèV W
,
èèW X
nullable
èèY a
:
èèa b
true
èèc g
)
èèg h
,
èèh i

AcreageOne
êê 
=
êê  
table
êê! &
.
êê& '
Column
êê' -
<
êê- .
double
êê. 4
>
êê4 5
(
êê5 6
type
êê6 :
:
êê: ;
$str
êê< C
,
êêC D
nullable
êêE M
:
êêM N
false
êêO T
)
êêT U
,
êêU V

AcreageTwo
ëë 
=
ëë  
table
ëë! &
.
ëë& '
Column
ëë' -
<
ëë- .
double
ëë. 4
>
ëë4 5
(
ëë5 6
type
ëë6 :
:
ëë: ;
$str
ëë< C
,
ëëC D
nullable
ëëE M
:
ëëM N
false
ëëO T
)
ëëT U
,
ëëU V
PropertyHeightId
íí $
=
íí% &
table
íí' ,
.
íí, -
Column
íí- 3
<
íí3 4
int
íí4 7
>
íí7 8
(
íí8 9
type
íí9 =
:
íí= >
$str
íí? D
,
ííD E
nullable
ííF N
:
ííN O
false
ííP U
)
ííU V
,
ííV W

PlotSizeId
ìì 
=
ìì  
table
ìì! &
.
ìì& '
Column
ìì' -
<
ìì- .
int
ìì. 1
>
ìì1 2
(
ìì2 3
type
ìì3 7
:
ìì7 8
$str
ìì9 >
,
ìì> ?
nullable
ìì@ H
:
ììH I
false
ììJ O
)
ììO P
,
ììP Q
SellingPrice
îî  
=
îî! "
table
îî# (
.
îî( )
Column
îî) /
<
îî/ 0
double
îî0 6
>
îî6 7
(
îî7 8
type
îî8 <
:
îî< =
$str
îî> E
,
îîE F
nullable
îîG O
:
îîO P
false
îîQ V
)
îîV W
,
îîW X

CurrencyId
ïï 
=
ïï  
table
ïï! &
.
ïï& '
Column
ïï' -
<
ïï- .
int
ïï. 1
>
ïï1 2
(
ïï2 3
type
ïï3 7
:
ïï7 8
$str
ïï9 >
,
ïï> ?
nullable
ïï@ H
:
ïïH I
false
ïïJ O
)
ïïO P
,
ïïP Q

RentalType
ññ 
=
ññ  
table
ññ! &
.
ññ& '
Column
ññ' -
<
ññ- .
string
ññ. 4
>
ññ4 5
(
ññ5 6
type
ññ6 :
:
ññ: ;
$str
ññ< J
,
ññJ K
	maxLength
ññL U
:
ññU V
$num
ññW Y
,
ññY Z
nullable
ññ[ c
:
ññc d
true
ññe i
)
ññi j
,
ññj k 
TotalNumberOfRooms
óó &
=
óó' (
table
óó) .
.
óó. /
Column
óó/ 5
<
óó5 6
int
óó6 9
>
óó9 :
(
óó: ;
type
óó; ?
:
óó? @
$str
óóA F
,
óóF G
nullable
óóH P
:
óóP Q
false
óóR W
)
óóW X
,
óóX Y
RoomsOccupied
òò !
=
òò" #
table
òò$ )
.
òò) *
Column
òò* 0
<
òò0 1
int
òò1 4
>
òò4 5
(
òò5 6
type
òò6 :
:
òò: ;
$str
òò< A
,
òòA B
nullable
òòC K
:
òòK L
false
òòM R
)
òòR S
,
òòS T
ApartmentTypeId
ôô #
=
ôô$ %
table
ôô& +
.
ôô+ ,
Column
ôô, 2
<
ôô2 3
int
ôô3 6
>
ôô6 7
(
ôô7 8
type
ôô8 <
:
ôô< =
$str
ôô> C
,
ôôC D
nullable
ôôE M
:
ôôM N
false
ôôO T
)
ôôT U
,
ôôU V
SchemeTypeId
öö  
=
öö! "
table
öö# (
.
öö( )
Column
öö) /
<
öö/ 0
int
öö0 3
>
öö3 4
(
öö4 5
type
öö5 9
:
öö9 :
$str
öö; @
,
öö@ A
nullable
ööB J
:
ööJ K
false
ööL Q
)
ööQ R
,
ööR S$
ApartmentBlockNumberId
õõ *
=
õõ+ ,
table
õõ- 2
.
õõ2 3
Column
õõ3 9
<
õõ9 :
int
õõ: =
>
õõ= >
(
õõ> ?
type
õõ? C
:
õõC D
$str
õõE J
,
õõJ K
nullable
õõL T
:
õõT U
false
õõV [
)
õõ[ \
,
õõ\ ]
BlockTypeId
úú 
=
úú  !
table
úú" '
.
úú' (
Column
úú( .
<
úú. /
int
úú/ 2
>
úú2 3
(
úú3 4
type
úú4 8
:
úú8 9
$str
úú: ?
,
úú? @
nullable
úúA I
:
úúI J
false
úúK P
)
úúP Q
,
úúQ R
FloorNumberId
ùù !
=
ùù" #
table
ùù$ )
.
ùù) *
Column
ùù* 0
<
ùù0 1
int
ùù1 4
>
ùù4 5
(
ùù5 6
type
ùù6 :
:
ùù: ;
$str
ùù< A
,
ùùA B
nullable
ùùC K
:
ùùK L
false
ùùM R
)
ùùR S
,
ùùS T
BlockUnitId
ûû 
=
ûû  !
table
ûû" '
.
ûû' (
Column
ûû( .
<
ûû. /
int
ûû/ 2
>
ûû2 3
(
ûû3 4
type
ûû4 8
:
ûû8 9
$str
ûû: ?
,
ûû? @
nullable
ûûA I
:
ûûI J
false
ûûK P
)
ûûP Q
,
ûûQ R
BlockSideId
üü 
=
üü  !
table
üü" '
.
üü' (
Column
üü( .
<
üü. /
int
üü/ 2
>
üü2 3
(
üü3 4
type
üü4 8
:
üü8 9
$str
üü: ?
,
üü? @
nullable
üüA I
:
üüI J
false
üüK P
)
üüP Q
,
üüQ R
	FloorArea
†† 
=
†† 
table
††  %
.
††% &
Column
††& ,
<
††, -
string
††- 3
>
††3 4
(
††4 5
type
††5 9
:
††9 :
$str
††; I
,
††I J
	maxLength
††K T
:
††T U
$num
††V X
,
††X Y
nullable
††Z b
:
††b c
true
††d h
)
††h i
,
††i j

RoomNumber
°° 
=
°°  
table
°°! &
.
°°& '
Column
°°' -
<
°°- .
int
°°. 1
>
°°1 2
(
°°2 3
type
°°3 7
:
°°7 8
$str
°°9 >
,
°°> ?
nullable
°°@ H
:
°°H I
false
°°J O
)
°°O P
,
°°P Q
RightOfEntry
¢¢  
=
¢¢! "
table
¢¢# (
.
¢¢( )
Column
¢¢) /
<
¢¢/ 0
DateTime
¢¢0 8
>
¢¢8 9
(
¢¢9 :
type
¢¢: >
:
¢¢> ?
$str
¢¢@ K
,
¢¢K L
nullable
¢¢M U
:
¢¢U V
false
¢¢W \
)
¢¢\ ]
,
¢¢] ^
	LeaseTerm
££ 
=
££ 
table
££  %
.
££% &
Column
££& ,
<
££, -
int
££- 0
>
££0 1
(
££1 2
type
££2 6
:
££6 7
$str
££8 =
,
££= >
nullable
££? G
:
££G H
false
££I N
)
££N O
,
££O P
LeaseExpiryDate
§§ #
=
§§$ %
table
§§& +
.
§§+ ,
Column
§§, 2
<
§§2 3
DateTime
§§3 ;
>
§§; <
(
§§< =
type
§§= A
:
§§A B
$str
§§C N
,
§§N O
nullable
§§P X
:
§§X Y
false
§§Z _
)
§§_ `
,
§§` a

DebtorType
•• 
=
••  
table
••! &
.
••& '
Column
••' -
<
••- .
int
••. 1
>
••1 2
(
••2 3
type
••3 7
:
••7 8
$str
••9 >
,
••> ?
nullable
••@ H
:
••H I
false
••J O
)
••O P
,
••P Q
GroupNumber
¶¶ 
=
¶¶  !
table
¶¶" '
.
¶¶' (
Column
¶¶( .
<
¶¶. /
int
¶¶/ 2
>
¶¶2 3
(
¶¶3 4
type
¶¶4 8
:
¶¶8 9
$str
¶¶: ?
,
¶¶? @
nullable
¶¶A I
:
¶¶I J
false
¶¶K P
)
¶¶P Q
,
¶¶Q R
CustomerCode
ßß  
=
ßß! "
table
ßß# (
.
ßß( )
Column
ßß) /
<
ßß/ 0
string
ßß0 6
>
ßß6 7
(
ßß7 8
type
ßß8 <
:
ßß< =
$str
ßß> L
,
ßßL M
	maxLength
ßßN W
:
ßßW X
$num
ßßY [
,
ßß[ \
nullable
ßß] e
:
ßße f
true
ßßg k
)
ßßk l
,
ßßl m
SitePlanNumber
®® "
=
®®# $
table
®®% *
.
®®* +
Column
®®+ 1
<
®®1 2
string
®®2 8
>
®®8 9
(
®®9 :
type
®®: >
:
®®> ?
$str
®®@ N
,
®®N O
	maxLength
®®P Y
:
®®Y Z
$num
®®[ ]
,
®®] ^
nullable
®®_ g
:
®®g h
true
®®i m
)
®®m n
,
®®n o!
CadastralPlanNumber
©© '
=
©©( )
table
©©* /
.
©©/ 0
Column
©©0 6
<
©©6 7
string
©©7 =
>
©©= >
(
©©> ?
type
©©? C
:
©©C D
$str
©©E S
,
©©S T
	maxLength
©©U ^
:
©©^ _
$num
©©` b
,
©©b c
nullable
©©d l
:
©©l m
true
©©n r
)
©©r s
,
©©s t
CoordinateOne
™™ !
=
™™" #
table
™™$ )
.
™™) *
Column
™™* 0
<
™™0 1
string
™™1 7
>
™™7 8
(
™™8 9
type
™™9 =
:
™™= >
$str
™™? M
,
™™M N
	maxLength
™™O X
:
™™X Y
$num
™™Z \
,
™™\ ]
nullable
™™^ f
:
™™f g
true
™™h l
)
™™l m
,
™™m n
CoordinateTwo
´´ !
=
´´" #
table
´´$ )
.
´´) *
Column
´´* 0
<
´´0 1
string
´´1 7
>
´´7 8
(
´´8 9
type
´´9 =
:
´´= >
$str
´´? M
,
´´M N
	maxLength
´´O X
:
´´X Y
$num
´´Z \
,
´´\ ]
nullable
´´^ f
:
´´f g
true
´´h l
)
´´l m
,
´´m n
CoordinateThree
¨¨ #
=
¨¨$ %
table
¨¨& +
.
¨¨+ ,
Column
¨¨, 2
<
¨¨2 3
string
¨¨3 9
>
¨¨9 :
(
¨¨: ;
type
¨¨; ?
:
¨¨? @
$str
¨¨A O
,
¨¨O P
	maxLength
¨¨Q Z
:
¨¨Z [
$num
¨¨\ ^
,
¨¨^ _
nullable
¨¨` h
:
¨¨h i
true
¨¨j n
)
¨¨n o
,
¨¨o p
CoordinateFour
≠≠ "
=
≠≠# $
table
≠≠% *
.
≠≠* +
Column
≠≠+ 1
<
≠≠1 2
string
≠≠2 8
>
≠≠8 9
(
≠≠9 :
type
≠≠: >
:
≠≠> ?
$str
≠≠@ N
,
≠≠N O
	maxLength
≠≠P Y
:
≠≠Y Z
$num
≠≠[ ]
,
≠≠] ^
nullable
≠≠_ g
:
≠≠g h
true
≠≠i m
)
≠≠m n
,
≠≠n o
CoordinateFive
ÆÆ "
=
ÆÆ# $
table
ÆÆ% *
.
ÆÆ* +
Column
ÆÆ+ 1
<
ÆÆ1 2
string
ÆÆ2 8
>
ÆÆ8 9
(
ÆÆ9 :
type
ÆÆ: >
:
ÆÆ> ?
$str
ÆÆ@ N
,
ÆÆN O
	maxLength
ÆÆP Y
:
ÆÆY Z
$num
ÆÆ[ ]
,
ÆÆ] ^
nullable
ÆÆ_ g
:
ÆÆg h
true
ÆÆi m
)
ÆÆm n
,
ÆÆn o
CoordinateSix
ØØ !
=
ØØ" #
table
ØØ$ )
.
ØØ) *
Column
ØØ* 0
<
ØØ0 1
string
ØØ1 7
>
ØØ7 8
(
ØØ8 9
type
ØØ9 =
:
ØØ= >
$str
ØØ? M
,
ØØM N
	maxLength
ØØO X
:
ØØX Y
$num
ØØZ \
,
ØØ\ ]
nullable
ØØ^ f
:
ØØf g
true
ØØh l
)
ØØl m
,
ØØm n"
MotherPropertyNumber
∞∞ (
=
∞∞) *
table
∞∞+ 0
.
∞∞0 1
Column
∞∞1 7
<
∞∞7 8
string
∞∞8 >
>
∞∞> ?
(
∞∞? @
type
∞∞@ D
:
∞∞D E
$str
∞∞F T
,
∞∞T U
	maxLength
∞∞V _
:
∞∞_ `
$num
∞∞a c
,
∞∞c d
nullable
∞∞e m
:
∞∞m n
true
∞∞o s
)
∞∞s t
,
∞∞t u
Comments
±± 
=
±± 
table
±± $
.
±±$ %
Column
±±% +
<
±±+ ,
string
±±, 2
>
±±2 3
(
±±3 4
type
±±4 8
:
±±8 9
$str
±±: I
,
±±I J
	maxLength
±±K T
:
±±T U
$num
±±V Y
,
±±Y Z
nullable
±±[ c
:
±±c d
true
±±e i
)
±±i j
,
±±j k
IsLargeScale
≤≤  
=
≤≤! "
table
≤≤# (
.
≤≤( )
Column
≤≤) /
<
≤≤/ 0
bool
≤≤0 4
>
≤≤4 5
(
≤≤5 6
type
≤≤6 :
:
≤≤: ;
$str
≤≤< A
,
≤≤A B
nullable
≤≤C K
:
≤≤K L
false
≤≤M R
)
≤≤R S
,
≤≤S T
	IsDeleted
≥≥ 
=
≥≥ 
table
≥≥  %
.
≥≥% &
Column
≥≥& ,
<
≥≥, -
bool
≥≥- 1
>
≥≥1 2
(
≥≥2 3
type
≥≥3 7
:
≥≥7 8
$str
≥≥9 >
,
≥≥> ?
nullable
≥≥@ H
:
≥≥H I
false
≥≥J O
)
≥≥O P
,
≥≥P Q
	CreatedOn
¥¥ 
=
¥¥ 
table
¥¥  %
.
¥¥% &
Column
¥¥& ,
<
¥¥, -
DateTime
¥¥- 5
>
¥¥5 6
(
¥¥6 7
type
¥¥7 ;
:
¥¥; <
$str
¥¥= H
,
¥¥H I
nullable
¥¥J R
:
¥¥R S
false
¥¥T Y
)
¥¥Y Z
,
¥¥Z [
	CreatedBy
µµ 
=
µµ 
table
µµ  %
.
µµ% &
Column
µµ& ,
<
µµ, -
string
µµ- 3
>
µµ3 4
(
µµ4 5
type
µµ5 9
:
µµ9 :
$str
µµ; J
,
µµJ K
nullable
µµL T
:
µµT U
true
µµV Z
)
µµZ [
,
µµ[ \

ModifiedOn
∂∂ 
=
∂∂  
table
∂∂! &
.
∂∂& '
Column
∂∂' -
<
∂∂- .
DateTime
∂∂. 6
>
∂∂6 7
(
∂∂7 8
type
∂∂8 <
:
∂∂< =
$str
∂∂> I
,
∂∂I J
nullable
∂∂K S
:
∂∂S T
false
∂∂U Z
)
∂∂Z [
,
∂∂[ \

ModifiedBy
∑∑ 
=
∑∑  
table
∑∑! &
.
∑∑& '
Column
∑∑' -
<
∑∑- .
string
∑∑. 4
>
∑∑4 5
(
∑∑5 6
type
∑∑6 :
:
∑∑: ;
$str
∑∑< K
,
∑∑K L
nullable
∑∑M U
:
∑∑U V
true
∑∑W [
)
∑∑[ \
,
∑∑\ ]
	DeletedOn
∏∏ 
=
∏∏ 
table
∏∏  %
.
∏∏% &
Column
∏∏& ,
<
∏∏, -
DateTime
∏∏- 5
>
∏∏5 6
(
∏∏6 7
type
∏∏7 ;
:
∏∏; <
$str
∏∏= H
,
∏∏H I
nullable
∏∏J R
:
∏∏R S
false
∏∏T Y
)
∏∏Y Z
,
∏∏Z [
	DeletedBy
ππ 
=
ππ 
table
ππ  %
.
ππ% &
Column
ππ& ,
<
ππ, -
string
ππ- 3
>
ππ3 4
(
ππ4 5
type
ππ5 9
:
ππ9 :
$str
ππ; J
,
ππJ K
nullable
ππL T
:
ππT U
true
ππV Z
)
ππZ [
,
ππ[ \

ApprovedOn
∫∫ 
=
∫∫  
table
∫∫! &
.
∫∫& '
Column
∫∫' -
<
∫∫- .
DateTime
∫∫. 6
>
∫∫6 7
(
∫∫7 8
type
∫∫8 <
:
∫∫< =
$str
∫∫> I
,
∫∫I J
nullable
∫∫K S
:
∫∫S T
false
∫∫U Z
)
∫∫Z [
,
∫∫[ \

ApprovedBy
ªª 
=
ªª  
table
ªª! &
.
ªª& '
Column
ªª' -
<
ªª- .
string
ªª. 4
>
ªª4 5
(
ªª5 6
type
ªª6 :
:
ªª: ;
$str
ªª< K
,
ªªK L
nullable
ªªM U
:
ªªU V
true
ªªW [
)
ªª[ \
}
ºº 
,
ºº 
constraints
ΩΩ 
:
ΩΩ 
table
ΩΩ "
=>
ΩΩ# %
{
ææ 
table
øø 
.
øø 

PrimaryKey
øø $
(
øø$ %
$str
øø% 8
,
øø8 9
x
øø: ;
=>
øø< >
x
øø? @
.
øø@ A
PropertyMasterId
øøA Q
)
øøQ R
;
øøR S
}
¿¿ 
)
¿¿ 
;
¿¿ 
migrationBuilder
¬¬ 
.
¬¬ 
CreateTable
¬¬ (
(
¬¬( )
name
√√ 
:
√√ 
$str
√√ $
,
√√$ %
schema
ƒƒ 
:
ƒƒ 
$str
ƒƒ 
,
ƒƒ 
columns
≈≈ 
:
≈≈ 
table
≈≈ 
=>
≈≈ !
new
≈≈" %
{
∆∆ 
PropertyTypeId
«« "
=
««# $
table
««% *
.
««* +
Column
««+ 1
<
««1 2
int
««2 5
>
««5 6
(
««6 7
type
««7 ;
:
««; <
$str
««= B
,
««B C
nullable
««D L
:
««L M
false
««N S
)
««S T
.
»» 

Annotation
»» #
(
»»# $
$str
»»$ 8
,
»»8 9
$str
»»: @
)
»»@ A
,
»»A B
PropertyTypes
…… !
=
……" #
table
……$ )
.
……) *
Column
……* 0
<
……0 1
string
……1 7
>
……7 8
(
……8 9
type
……9 =
:
……= >
$str
……? M
,
……M N
	maxLength
……O X
:
……X Y
$num
……Z \
,
……\ ]
nullable
……^ f
:
……f g
false
……h m
)
……m n
,
……n o
	CreatedOn
   
=
   
table
    %
.
  % &
Column
  & ,
<
  , -
DateTime
  - 5
>
  5 6
(
  6 7
type
  7 ;
:
  ; <
$str
  = H
,
  H I
nullable
  J R
:
  R S
false
  T Y
)
  Y Z
,
  Z [
	CreatedBy
ÀÀ 
=
ÀÀ 
table
ÀÀ  %
.
ÀÀ% &
Column
ÀÀ& ,
<
ÀÀ, -
string
ÀÀ- 3
>
ÀÀ3 4
(
ÀÀ4 5
type
ÀÀ5 9
:
ÀÀ9 :
$str
ÀÀ; J
,
ÀÀJ K
nullable
ÀÀL T
:
ÀÀT U
true
ÀÀV Z
)
ÀÀZ [
,
ÀÀ[ \

ModifiedOn
ÃÃ 
=
ÃÃ  
table
ÃÃ! &
.
ÃÃ& '
Column
ÃÃ' -
<
ÃÃ- .
DateTime
ÃÃ. 6
>
ÃÃ6 7
(
ÃÃ7 8
type
ÃÃ8 <
:
ÃÃ< =
$str
ÃÃ> I
,
ÃÃI J
nullable
ÃÃK S
:
ÃÃS T
false
ÃÃU Z
)
ÃÃZ [
,
ÃÃ[ \

ModifiedBy
ÕÕ 
=
ÕÕ  
table
ÕÕ! &
.
ÕÕ& '
Column
ÕÕ' -
<
ÕÕ- .
string
ÕÕ. 4
>
ÕÕ4 5
(
ÕÕ5 6
type
ÕÕ6 :
:
ÕÕ: ;
$str
ÕÕ< K
,
ÕÕK L
nullable
ÕÕM U
:
ÕÕU V
true
ÕÕW [
)
ÕÕ[ \
,
ÕÕ\ ]
	DeletedOn
ŒŒ 
=
ŒŒ 
table
ŒŒ  %
.
ŒŒ% &
Column
ŒŒ& ,
<
ŒŒ, -
DateTime
ŒŒ- 5
>
ŒŒ5 6
(
ŒŒ6 7
type
ŒŒ7 ;
:
ŒŒ; <
$str
ŒŒ= H
,
ŒŒH I
nullable
ŒŒJ R
:
ŒŒR S
false
ŒŒT Y
)
ŒŒY Z
,
ŒŒZ [
	DeletedBy
œœ 
=
œœ 
table
œœ  %
.
œœ% &
Column
œœ& ,
<
œœ, -
string
œœ- 3
>
œœ3 4
(
œœ4 5
type
œœ5 9
:
œœ9 :
$str
œœ; J
,
œœJ K
nullable
œœL T
:
œœT U
true
œœV Z
)
œœZ [
}
–– 
,
–– 
constraints
—— 
:
—— 
table
—— "
=>
——# %
{
““ 
table
”” 
.
”” 

PrimaryKey
”” $
(
””$ %
$str
””% 6
,
””6 7
x
””8 9
=>
””: <
x
””= >
.
””> ?
PropertyTypeId
””? M
)
””M N
;
””N O
}
‘‘ 
)
‘‘ 
;
‘‘ 
migrationBuilder
÷÷ 
.
÷÷ 
CreateTable
÷÷ (
(
÷÷( )
name
◊◊ 
:
◊◊ 
$str
◊◊ $
,
◊◊$ %
schema
ÿÿ 
:
ÿÿ 
$str
ÿÿ 
,
ÿÿ 
columns
ŸŸ 
:
ŸŸ 
table
ŸŸ 
=>
ŸŸ !
new
ŸŸ" %
{
⁄⁄ 
ResidentTypeId
€€ "
=
€€# $
table
€€% *
.
€€* +
Column
€€+ 1
<
€€1 2
int
€€2 5
>
€€5 6
(
€€6 7
type
€€7 ;
:
€€; <
$str
€€= B
,
€€B C
nullable
€€D L
:
€€L M
false
€€N S
)
€€S T
.
‹‹ 

Annotation
‹‹ #
(
‹‹# $
$str
‹‹$ 8
,
‹‹8 9
$str
‹‹: @
)
‹‹@ A
,
‹‹A B
ResidentTypes
›› !
=
››" #
table
››$ )
.
››) *
Column
››* 0
<
››0 1
string
››1 7
>
››7 8
(
››8 9
type
››9 =
:
››= >
$str
››? M
,
››M N
	maxLength
››O X
:
››X Y
$num
››Z \
,
››\ ]
nullable
››^ f
:
››f g
false
››h m
)
››m n
,
››n o
	CreatedOn
ﬁﬁ 
=
ﬁﬁ 
table
ﬁﬁ  %
.
ﬁﬁ% &
Column
ﬁﬁ& ,
<
ﬁﬁ, -
DateTime
ﬁﬁ- 5
>
ﬁﬁ5 6
(
ﬁﬁ6 7
type
ﬁﬁ7 ;
:
ﬁﬁ; <
$str
ﬁﬁ= H
,
ﬁﬁH I
nullable
ﬁﬁJ R
:
ﬁﬁR S
false
ﬁﬁT Y
)
ﬁﬁY Z
,
ﬁﬁZ [
	CreatedBy
ﬂﬂ 
=
ﬂﬂ 
table
ﬂﬂ  %
.
ﬂﬂ% &
Column
ﬂﬂ& ,
<
ﬂﬂ, -
string
ﬂﬂ- 3
>
ﬂﬂ3 4
(
ﬂﬂ4 5
type
ﬂﬂ5 9
:
ﬂﬂ9 :
$str
ﬂﬂ; J
,
ﬂﬂJ K
nullable
ﬂﬂL T
:
ﬂﬂT U
true
ﬂﬂV Z
)
ﬂﬂZ [
,
ﬂﬂ[ \

ModifiedOn
‡‡ 
=
‡‡  
table
‡‡! &
.
‡‡& '
Column
‡‡' -
<
‡‡- .
DateTime
‡‡. 6
>
‡‡6 7
(
‡‡7 8
type
‡‡8 <
:
‡‡< =
$str
‡‡> I
,
‡‡I J
nullable
‡‡K S
:
‡‡S T
false
‡‡U Z
)
‡‡Z [
,
‡‡[ \

ModifiedBy
·· 
=
··  
table
··! &
.
··& '
Column
··' -
<
··- .
string
··. 4
>
··4 5
(
··5 6
type
··6 :
:
··: ;
$str
··< K
,
··K L
nullable
··M U
:
··U V
true
··W [
)
··[ \
,
··\ ]
	DeletedOn
‚‚ 
=
‚‚ 
table
‚‚  %
.
‚‚% &
Column
‚‚& ,
<
‚‚, -
DateTime
‚‚- 5
>
‚‚5 6
(
‚‚6 7
type
‚‚7 ;
:
‚‚; <
$str
‚‚= H
,
‚‚H I
nullable
‚‚J R
:
‚‚R S
false
‚‚T Y
)
‚‚Y Z
,
‚‚Z [
	DeletedBy
„„ 
=
„„ 
table
„„  %
.
„„% &
Column
„„& ,
<
„„, -
string
„„- 3
>
„„3 4
(
„„4 5
type
„„5 9
:
„„9 :
$str
„„; J
,
„„J K
nullable
„„L T
:
„„T U
true
„„V Z
)
„„Z [
}
‰‰ 
,
‰‰ 
constraints
ÂÂ 
:
ÂÂ 
table
ÂÂ "
=>
ÂÂ# %
{
ÊÊ 
table
ÁÁ 
.
ÁÁ 

PrimaryKey
ÁÁ $
(
ÁÁ$ %
$str
ÁÁ% 6
,
ÁÁ6 7
x
ÁÁ8 9
=>
ÁÁ: <
x
ÁÁ= >
.
ÁÁ> ?
ResidentTypeId
ÁÁ? M
)
ÁÁM N
;
ÁÁN O
}
ËË 
)
ËË 
;
ËË 
migrationBuilder
ÍÍ 
.
ÍÍ 
CreateTable
ÍÍ (
(
ÍÍ( )
name
ÎÎ 
:
ÎÎ 
$str
ÎÎ #
,
ÎÎ# $
schema
ÏÏ 
:
ÏÏ 
$str
ÏÏ 
,
ÏÏ 
columns
ÌÌ 
:
ÌÌ 
table
ÌÌ 
=>
ÌÌ !
new
ÌÌ" %
{
ÓÓ 
SocialMediaId
ÔÔ !
=
ÔÔ" #
table
ÔÔ$ )
.
ÔÔ) *
Column
ÔÔ* 0
<
ÔÔ0 1
int
ÔÔ1 4
>
ÔÔ4 5
(
ÔÔ5 6
type
ÔÔ6 :
:
ÔÔ: ;
$str
ÔÔ< A
,
ÔÔA B
nullable
ÔÔC K
:
ÔÔK L
false
ÔÔM R
)
ÔÔR S
.
 

Annotation
 #
(
# $
$str
$ 8
,
8 9
$str
: @
)
@ A
,
A B!
SocialMediaPlatform
ÒÒ '
=
ÒÒ( )
table
ÒÒ* /
.
ÒÒ/ 0
Column
ÒÒ0 6
<
ÒÒ6 7
string
ÒÒ7 =
>
ÒÒ= >
(
ÒÒ> ?
type
ÒÒ? C
:
ÒÒC D
$str
ÒÒE S
,
ÒÒS T
	maxLength
ÒÒU ^
:
ÒÒ^ _
$num
ÒÒ` b
,
ÒÒb c
nullable
ÒÒd l
:
ÒÒl m
false
ÒÒn s
)
ÒÒs t
,
ÒÒt u
	CreatedOn
ÚÚ 
=
ÚÚ 
table
ÚÚ  %
.
ÚÚ% &
Column
ÚÚ& ,
<
ÚÚ, -
DateTime
ÚÚ- 5
>
ÚÚ5 6
(
ÚÚ6 7
type
ÚÚ7 ;
:
ÚÚ; <
$str
ÚÚ= H
,
ÚÚH I
nullable
ÚÚJ R
:
ÚÚR S
false
ÚÚT Y
)
ÚÚY Z
,
ÚÚZ [
	CreatedBy
ÛÛ 
=
ÛÛ 
table
ÛÛ  %
.
ÛÛ% &
Column
ÛÛ& ,
<
ÛÛ, -
string
ÛÛ- 3
>
ÛÛ3 4
(
ÛÛ4 5
type
ÛÛ5 9
:
ÛÛ9 :
$str
ÛÛ; J
,
ÛÛJ K
nullable
ÛÛL T
:
ÛÛT U
true
ÛÛV Z
)
ÛÛZ [
,
ÛÛ[ \

ModifiedOn
ÙÙ 
=
ÙÙ  
table
ÙÙ! &
.
ÙÙ& '
Column
ÙÙ' -
<
ÙÙ- .
DateTime
ÙÙ. 6
>
ÙÙ6 7
(
ÙÙ7 8
type
ÙÙ8 <
:
ÙÙ< =
$str
ÙÙ> I
,
ÙÙI J
nullable
ÙÙK S
:
ÙÙS T
false
ÙÙU Z
)
ÙÙZ [
,
ÙÙ[ \

ModifiedBy
ıı 
=
ıı  
table
ıı! &
.
ıı& '
Column
ıı' -
<
ıı- .
string
ıı. 4
>
ıı4 5
(
ıı5 6
type
ıı6 :
:
ıı: ;
$str
ıı< K
,
ııK L
nullable
ııM U
:
ııU V
true
ııW [
)
ıı[ \
,
ıı\ ]
	DeletedOn
ˆˆ 
=
ˆˆ 
table
ˆˆ  %
.
ˆˆ% &
Column
ˆˆ& ,
<
ˆˆ, -
DateTime
ˆˆ- 5
>
ˆˆ5 6
(
ˆˆ6 7
type
ˆˆ7 ;
:
ˆˆ; <
$str
ˆˆ= H
,
ˆˆH I
nullable
ˆˆJ R
:
ˆˆR S
false
ˆˆT Y
)
ˆˆY Z
,
ˆˆZ [
	DeletedBy
˜˜ 
=
˜˜ 
table
˜˜  %
.
˜˜% &
Column
˜˜& ,
<
˜˜, -
string
˜˜- 3
>
˜˜3 4
(
˜˜4 5
type
˜˜5 9
:
˜˜9 :
$str
˜˜; J
,
˜˜J K
nullable
˜˜L T
:
˜˜T U
true
˜˜V Z
)
˜˜Z [
}
¯¯ 
,
¯¯ 
constraints
˘˘ 
:
˘˘ 
table
˘˘ "
=>
˘˘# %
{
˙˙ 
table
˚˚ 
.
˚˚ 

PrimaryKey
˚˚ $
(
˚˚$ %
$str
˚˚% 5
,
˚˚5 6
x
˚˚7 8
=>
˚˚9 ;
x
˚˚< =
.
˚˚= >
SocialMediaId
˚˚> K
)
˚˚K L
;
˚˚L M
}
¸¸ 
)
¸¸ 
;
¸¸ 
migrationBuilder
˛˛ 
.
˛˛ 
CreateTable
˛˛ (
(
˛˛( )
name
ˇˇ 
:
ˇˇ 
$str
ˇˇ 
,
ˇˇ 
schema
ÄÄ 
:
ÄÄ 
$str
ÄÄ 
,
ÄÄ 
columns
ÅÅ 
:
ÅÅ 
table
ÅÅ 
=>
ÅÅ !
new
ÅÅ" %
{
ÇÇ 
TitleId
ÉÉ 
=
ÉÉ 
table
ÉÉ #
.
ÉÉ# $
Column
ÉÉ$ *
<
ÉÉ* +
int
ÉÉ+ .
>
ÉÉ. /
(
ÉÉ/ 0
type
ÉÉ0 4
:
ÉÉ4 5
$str
ÉÉ6 ;
,
ÉÉ; <
nullable
ÉÉ= E
:
ÉÉE F
false
ÉÉG L
)
ÉÉL M
.
ÑÑ 

Annotation
ÑÑ #
(
ÑÑ# $
$str
ÑÑ$ 8
,
ÑÑ8 9
$str
ÑÑ: @
)
ÑÑ@ A
,
ÑÑA B
Titles
ÖÖ 
=
ÖÖ 
table
ÖÖ "
.
ÖÖ" #
Column
ÖÖ# )
<
ÖÖ) *
string
ÖÖ* 0
>
ÖÖ0 1
(
ÖÖ1 2
type
ÖÖ2 6
:
ÖÖ6 7
$str
ÖÖ8 F
,
ÖÖF G
	maxLength
ÖÖH Q
:
ÖÖQ R
$num
ÖÖS U
,
ÖÖU V
nullable
ÖÖW _
:
ÖÖ_ `
false
ÖÖa f
)
ÖÖf g
,
ÖÖg h
	CreatedOn
ÜÜ 
=
ÜÜ 
table
ÜÜ  %
.
ÜÜ% &
Column
ÜÜ& ,
<
ÜÜ, -
DateTime
ÜÜ- 5
>
ÜÜ5 6
(
ÜÜ6 7
type
ÜÜ7 ;
:
ÜÜ; <
$str
ÜÜ= H
,
ÜÜH I
nullable
ÜÜJ R
:
ÜÜR S
false
ÜÜT Y
)
ÜÜY Z
,
ÜÜZ [
	CreatedBy
áá 
=
áá 
table
áá  %
.
áá% &
Column
áá& ,
<
áá, -
string
áá- 3
>
áá3 4
(
áá4 5
type
áá5 9
:
áá9 :
$str
áá; J
,
ááJ K
nullable
ááL T
:
ááT U
true
ááV Z
)
ááZ [
,
áá[ \

ModifiedOn
àà 
=
àà  
table
àà! &
.
àà& '
Column
àà' -
<
àà- .
DateTime
àà. 6
>
àà6 7
(
àà7 8
type
àà8 <
:
àà< =
$str
àà> I
,
ààI J
nullable
ààK S
:
ààS T
false
ààU Z
)
ààZ [
,
àà[ \

ModifiedBy
ââ 
=
ââ  
table
ââ! &
.
ââ& '
Column
ââ' -
<
ââ- .
string
ââ. 4
>
ââ4 5
(
ââ5 6
type
ââ6 :
:
ââ: ;
$str
ââ< K
,
ââK L
nullable
ââM U
:
ââU V
true
ââW [
)
ââ[ \
,
ââ\ ]
	DeletedOn
ää 
=
ää 
table
ää  %
.
ää% &
Column
ää& ,
<
ää, -
DateTime
ää- 5
>
ää5 6
(
ää6 7
type
ää7 ;
:
ää; <
$str
ää= H
,
ääH I
nullable
ääJ R
:
ääR S
false
ääT Y
)
ääY Z
,
ääZ [
	DeletedBy
ãã 
=
ãã 
table
ãã  %
.
ãã% &
Column
ãã& ,
<
ãã, -
string
ãã- 3
>
ãã3 4
(
ãã4 5
type
ãã5 9
:
ãã9 :
$str
ãã; J
,
ããJ K
nullable
ããL T
:
ããT U
true
ããV Z
)
ããZ [
}
åå 
,
åå 
constraints
çç 
:
çç 
table
çç "
=>
çç# %
{
éé 
table
èè 
.
èè 

PrimaryKey
èè $
(
èè$ %
$str
èè% /
,
èè/ 0
x
èè1 2
=>
èè3 5
x
èè6 7
.
èè7 8
TitleId
èè8 ?
)
èè? @
;
èè@ A
}
êê 
)
êê 
;
êê 
migrationBuilder
íí 
.
íí 

InsertData
íí '
(
íí' (
schema
ìì 
:
ìì 
$str
ìì 
,
ìì 
table
îî 
:
îî 
$str
îî !
,
îî! "
columns
ïï 
:
ïï 
new
ïï 
[
ïï 
]
ïï 
{
ïï  
$str
ïï! -
,
ïï- .
$str
ïï/ D
,
ïïD E
$str
ïïF T
,
ïïT U
$str
ïïV a
,
ïïa b
$str
ïïc n
,
ïïn o
$str
ïïp {
,
ïï{ |
$strïï} à
,ïïà â
$strïïä ñ
,ïïñ ó
$strïïò §
}ïï• ¶
,ïï¶ ß
values
ññ 
:
ññ 
new
ññ 
object
ññ "
[
ññ" #
,
ññ# $
]
ññ$ %
{
óó 
{
òò 
$num
òò 
,
òò 
$str
òò 6
,
òò6 7
$str
òò8 A
,
òòA B
null
òòC G
,
òòG H
new
òòI L
DateTime
òòM U
(
òòU V
$num
òòV W
,
òòW X
$num
òòY Z
,
òòZ [
$num
òò\ ]
,
òò] ^
$num
òò_ `
,
òò` a
$num
òòb c
,
òòc d
$num
òòe f
,
òòf g
$num
òòh i
,
òòi j
DateTimeKind
òòk w
.
òòw x
Unspecifiedòòx É
)òòÉ Ñ
,òòÑ Ö
nullòòÜ ä
,òòä ã
newòòå è
DateTimeòòê ò
(òòò ô
$numòòô ö
,òòö õ
$numòòú ù
,òòù û
$numòòü †
,òò† °
$numòò¢ £
,òò£ §
$numòò• ¶
,òò¶ ß
$numòò® ©
,òò© ™
$numòò´ ¨
,òò¨ ≠
DateTimeKindòòÆ ∫
.òò∫ ª
Unspecifiedòòª ∆
)òò∆ «
,òò« »
nullòò… Õ
,òòÕ Œ
newòòœ “
DateTimeòò” €
(òò€ ‹
$numòò‹ ›
,òò› ﬁ
$numòòﬂ ‡
,òò‡ ·
$numòò‚ „
,òò„ ‰
$numòòÂ Ê
,òòÊ Á
$numòòË È
,òòÈ Í
$numòòÎ Ï
,òòÏ Ì
$numòòÓ Ô
,òòÔ 
DateTimeKindòòÒ ˝
.òò˝ ˛
Unspecifiedòò˛ â
)òòâ ä
}òòã å
,òòå ç
{
ôô 
$num
ôô 
,
ôô 
$str
ôô B
,
ôôB C
$str
ôôD N
,
ôôN O
null
ôôP T
,
ôôT U
new
ôôV Y
DateTime
ôôZ b
(
ôôb c
$num
ôôc d
,
ôôd e
$num
ôôf g
,
ôôg h
$num
ôôi j
,
ôôj k
$num
ôôl m
,
ôôm n
$num
ôôo p
,
ôôp q
$num
ôôr s
,
ôôs t
$num
ôôu v
,
ôôv w
DateTimeKindôôx Ñ
.ôôÑ Ö
UnspecifiedôôÖ ê
)ôôê ë
,ôôë í
nullôôì ó
,ôôó ò
newôôô ú
DateTimeôôù •
(ôô• ¶
$numôô¶ ß
,ôôß ®
$numôô© ™
,ôô™ ´
$numôô¨ ≠
,ôô≠ Æ
$numôôØ ∞
,ôô∞ ±
$numôô≤ ≥
,ôô≥ ¥
$numôôµ ∂
,ôô∂ ∑
$numôô∏ π
,ôôπ ∫
DateTimeKindôôª «
.ôô« »
Unspecifiedôô» ”
)ôô” ‘
,ôô‘ ’
nullôô÷ ⁄
,ôô⁄ €
newôô‹ ﬂ
DateTimeôô‡ Ë
(ôôË È
$numôôÈ Í
,ôôÍ Î
$numôôÏ Ì
,ôôÌ Ó
$numôôÔ 
,ôô Ò
$numôôÚ Û
,ôôÛ Ù
$numôôı ˆ
,ôôˆ ˜
$numôô¯ ˘
,ôô˘ ˙
$numôô˚ ¸
,ôô¸ ˝
DateTimeKindôô˛ ä
.ôôä ã
Unspecifiedôôã ñ
)ôôñ ó
}ôôò ô
}
öö 
)
öö 
;
öö 
migrationBuilder
úú 
.
úú 

InsertData
úú '
(
úú' (
schema
ùù 
:
ùù 
$str
ùù 
,
ùù 
table
ûû 
:
ûû 
$str
ûû %
,
ûû% &
columns
üü 
:
üü 
new
üü 
[
üü 
]
üü 
{
üü  
$str
üü! 1
,
üü1 2
$str
üü3 ?
,
üü? @
$str
üüA Z
,
üüZ [
$str
üü\ n
,
üün o
$str
üüp {
,
üü{ |
$strüü} à
,üüà â
$strüüä ï
,üüï ñ
$strüüó ¢
,üü¢ £
$strüü§ ∞
,üü∞ ±
$strüü≤ æ
}üüø ¿
,üü¿ ¡
values
†† 
:
†† 
new
†† 
object
†† "
[
††" #
,
††# $
]
††$ %
{
°° 
{
¢¢ 
$num
¢¢ 
,
¢¢ 
$num
¢¢ 
,
¢¢ 
$str
¢¢ ,
,
¢¢, -
$str
¢¢. B
,
¢¢B C
null
¢¢D H
,
¢¢H I
new
¢¢J M
DateTime
¢¢N V
(
¢¢V W
$num
¢¢W X
,
¢¢X Y
$num
¢¢Z [
,
¢¢[ \
$num
¢¢] ^
,
¢¢^ _
$num
¢¢` a
,
¢¢a b
$num
¢¢c d
,
¢¢d e
$num
¢¢f g
,
¢¢g h
$num
¢¢i j
,
¢¢j k
DateTimeKind
¢¢l x
.
¢¢x y
Unspecified¢¢y Ñ
)¢¢Ñ Ö
,¢¢Ö Ü
null¢¢á ã
,¢¢ã å
new¢¢ç ê
DateTime¢¢ë ô
(¢¢ô ö
$num¢¢ö õ
,¢¢õ ú
$num¢¢ù û
,¢¢û ü
$num¢¢† °
,¢¢° ¢
$num¢¢£ §
,¢¢§ •
$num¢¢¶ ß
,¢¢ß ®
$num¢¢© ™
,¢¢™ ´
$num¢¢¨ ≠
,¢¢≠ Æ
DateTimeKind¢¢Ø ª
.¢¢ª º
Unspecified¢¢º «
)¢¢« »
,¢¢» …
null¢¢  Œ
,¢¢Œ œ
new¢¢– ”
DateTime¢¢‘ ‹
(¢¢‹ ›
$num¢¢› ﬁ
,¢¢ﬁ ﬂ
$num¢¢‡ ·
,¢¢· ‚
$num¢¢„ ‰
,¢¢‰ Â
$num¢¢Ê Á
,¢¢Á Ë
$num¢¢È Í
,¢¢Í Î
$num¢¢Ï Ì
,¢¢Ì Ó
$num¢¢Ô 
,¢¢ Ò
DateTimeKind¢¢Ú ˛
.¢¢˛ ˇ
Unspecified¢¢ˇ ä
)¢¢ä ã
}¢¢å ç
,¢¢ç é
{
££ 
$num
££ 
,
££ 
$num
££ 
,
££ 
$str
££ C
,
££C D
$str
££E X
,
££X Y
null
££Z ^
,
££^ _
new
££` c
DateTime
££d l
(
££l m
$num
££m n
,
££n o
$num
££p q
,
££q r
$num
££s t
,
££t u
$num
££v w
,
££w x
$num
££y z
,
££z {
$num
££| }
,
££} ~
$num££ Ä
,££Ä Å
DateTimeKind££Ç é
.££é è
Unspecified££è ö
)££ö õ
,££õ ú
null££ù °
,££° ¢
new£££ ¶
DateTime££ß Ø
(££Ø ∞
$num££∞ ±
,££± ≤
$num££≥ ¥
,££¥ µ
$num££∂ ∑
,££∑ ∏
$num££π ∫
,££∫ ª
$num££º Ω
,££Ω æ
$num££ø ¿
,££¿ ¡
$num££¬ √
,££√ ƒ
DateTimeKind££≈ —
.££— “
Unspecified££“ ›
)££› ﬁ
,££ﬁ ﬂ
null££‡ ‰
,££‰ Â
new££Ê È
DateTime££Í Ú
(££Ú Û
$num££Û Ù
,££Ù ı
$num££ˆ ˜
,££˜ ¯
$num££˘ ˙
,££˙ ˚
$num££¸ ˝
,££˝ ˛
$num££ˇ Ä
,££Ä Å
$num££Ç É
,££É Ñ
$num££Ö Ü
,££Ü á
DateTimeKind££à î
.££î ï
Unspecified££ï †
)££† °
}££¢ £
,£££ §
{
§§ 
$num
§§ 
,
§§ 
$num
§§ 
,
§§ 
$str
§§ ;
,
§§; <
$str
§§= K
,
§§K L
null
§§M Q
,
§§Q R
new
§§S V
DateTime
§§W _
(
§§_ `
$num
§§` a
,
§§a b
$num
§§c d
,
§§d e
$num
§§f g
,
§§g h
$num
§§i j
,
§§j k
$num
§§l m
,
§§m n
$num
§§o p
,
§§p q
$num
§§r s
,
§§s t
DateTimeKind§§u Å
.§§Å Ç
Unspecified§§Ç ç
)§§ç é
,§§é è
null§§ê î
,§§î ï
new§§ñ ô
DateTime§§ö ¢
(§§¢ £
$num§§£ §
,§§§ •
$num§§¶ ß
,§§ß ®
$num§§© ™
,§§™ ´
$num§§¨ ≠
,§§≠ Æ
$num§§Ø ∞
,§§∞ ±
$num§§≤ ≥
,§§≥ ¥
$num§§µ ∂
,§§∂ ∑
DateTimeKind§§∏ ƒ
.§§ƒ ≈
Unspecified§§≈ –
)§§– —
,§§— “
null§§” ◊
,§§◊ ÿ
new§§Ÿ ‹
DateTime§§› Â
(§§Â Ê
$num§§Ê Á
,§§Á Ë
$num§§È Í
,§§Í Î
$num§§Ï Ì
,§§Ì Ó
$num§§Ô 
,§§ Ò
$num§§Ú Û
,§§Û Ù
$num§§ı ˆ
,§§ˆ ˜
$num§§¯ ˘
,§§˘ ˙
DateTimeKind§§˚ á
.§§á à
Unspecified§§à ì
)§§ì î
}§§ï ñ
,§§ñ ó
{
•• 
$num
•• 
,
•• 
$num
•• 
,
•• 
$str
•• E
,
••E F
$str
••G V
,
••V W
null
••X \
,
••\ ]
new
••^ a
DateTime
••b j
(
••j k
$num
••k l
,
••l m
$num
••n o
,
••o p
$num
••q r
,
••r s
$num
••t u
,
••u v
$num
••w x
,
••x y
$num
••z {
,
••{ |
$num
••} ~
,
••~ 
DateTimeKind••Ä å
.••å ç
Unspecified••ç ò
)••ò ô
,••ô ö
null••õ ü
,••ü †
new••° §
DateTime••• ≠
(••≠ Æ
$num••Æ Ø
,••Ø ∞
$num••± ≤
,••≤ ≥
$num••¥ µ
,••µ ∂
$num••∑ ∏
,••∏ π
$num••∫ ª
,••ª º
$num••Ω æ
,••æ ø
$num••¿ ¡
,••¡ ¬
DateTimeKind••√ œ
.••œ –
Unspecified••– €
)••€ ‹
,••‹ ›
null••ﬁ ‚
,••‚ „
new••‰ Á
DateTime••Ë 
(•• Ò
$num••Ò Ú
,••Ú Û
$num••Ù ı
,••ı ˆ
$num••˜ ¯
,••¯ ˘
$num••˙ ˚
,••˚ ¸
$num••˝ ˛
,••˛ ˇ
$num••Ä Å
,••Å Ç
$num••É Ñ
,••Ñ Ö
DateTimeKind••Ü í
.••í ì
Unspecified••ì û
)••û ü
}••† °
,••° ¢
{
¶¶ 
$num
¶¶ 
,
¶¶ 
$num
¶¶ 
,
¶¶ 
$str
¶¶ E
,
¶¶E F
$str
¶¶G W
,
¶¶W X
null
¶¶Y ]
,
¶¶] ^
new
¶¶_ b
DateTime
¶¶c k
(
¶¶k l
$num
¶¶l m
,
¶¶m n
$num
¶¶o p
,
¶¶p q
$num
¶¶r s
,
¶¶s t
$num
¶¶u v
,
¶¶v w
$num
¶¶x y
,
¶¶y z
$num
¶¶{ |
,
¶¶| }
$num
¶¶~ 
,¶¶ Ä
DateTimeKind¶¶Å ç
.¶¶ç é
Unspecified¶¶é ô
)¶¶ô ö
,¶¶ö õ
null¶¶ú †
,¶¶† °
new¶¶¢ •
DateTime¶¶¶ Æ
(¶¶Æ Ø
$num¶¶Ø ∞
,¶¶∞ ±
$num¶¶≤ ≥
,¶¶≥ ¥
$num¶¶µ ∂
,¶¶∂ ∑
$num¶¶∏ π
,¶¶π ∫
$num¶¶ª º
,¶¶º Ω
$num¶¶æ ø
,¶¶ø ¿
$num¶¶¡ ¬
,¶¶¬ √
DateTimeKind¶¶ƒ –
.¶¶– —
Unspecified¶¶— ‹
)¶¶‹ ›
,¶¶› ﬁ
null¶¶ﬂ „
,¶¶„ ‰
new¶¶Â Ë
DateTime¶¶È Ò
(¶¶Ò Ú
$num¶¶Ú Û
,¶¶Û Ù
$num¶¶ı ˆ
,¶¶ˆ ˜
$num¶¶¯ ˘
,¶¶˘ ˙
$num¶¶˚ ¸
,¶¶¸ ˝
$num¶¶˛ ˇ
,¶¶ˇ Ä
$num¶¶Å Ç
,¶¶Ç É
$num¶¶Ñ Ö
,¶¶Ö Ü
DateTimeKind¶¶á ì
.¶¶ì î
Unspecified¶¶î ü
)¶¶ü †
}¶¶° ¢
}
ßß 
)
ßß 
;
ßß 
migrationBuilder
©© 
.
©© 

InsertData
©© '
(
©©' (
schema
™™ 
:
™™ 
$str
™™ 
,
™™ 
table
´´ 
:
´´ 
$str
´´ '
,
´´' (
columns
¨¨ 
:
¨¨ 
new
¨¨ 
[
¨¨ 
]
¨¨ 
{
¨¨  
$str
¨¨! 3
,
¨¨3 4
$str
¨¨5 L
,
¨¨L M
$str
¨¨N _
,
¨¨_ `
$str
¨¨a l
,
¨¨l m
$str
¨¨n y
,
¨¨y z
$str¨¨{ Ü
,¨¨Ü á
$str¨¨à ì
,¨¨ì î
$str¨¨ï °
,¨¨° ¢
$str¨¨£ Ø
}¨¨∞ ±
,¨¨± ≤
values
≠≠ 
:
≠≠ 
new
≠≠ 
object
≠≠ "
[
≠≠" #
,
≠≠# $
]
≠≠$ %
{
ÆÆ 
{
ØØ 
$num
ØØ 
,
ØØ 
$str
ØØ 
,
ØØ 
$str
ØØ  3
,
ØØ3 4
null
ØØ5 9
,
ØØ9 :
new
ØØ; >
DateTime
ØØ? G
(
ØØG H
$num
ØØH I
,
ØØI J
$num
ØØK L
,
ØØL M
$num
ØØN O
,
ØØO P
$num
ØØQ R
,
ØØR S
$num
ØØT U
,
ØØU V
$num
ØØW X
,
ØØX Y
$num
ØØZ [
,
ØØ[ \
DateTimeKind
ØØ] i
.
ØØi j
Unspecified
ØØj u
)
ØØu v
,
ØØv w
null
ØØx |
,
ØØ| }
newØØ~ Å
DateTimeØØÇ ä
(ØØä ã
$numØØã å
,ØØå ç
$numØØé è
,ØØè ê
$numØØë í
,ØØí ì
$numØØî ï
,ØØï ñ
$numØØó ò
,ØØò ô
$numØØö õ
,ØØõ ú
$numØØù û
,ØØû ü
DateTimeKindØØ† ¨
.ØØ¨ ≠
UnspecifiedØØ≠ ∏
)ØØ∏ π
,ØØπ ∫
nullØØª ø
,ØØø ¿
newØØ¡ ƒ
DateTimeØØ≈ Õ
(ØØÕ Œ
$numØØŒ œ
,ØØœ –
$numØØ— “
,ØØ“ ”
$numØØ‘ ’
,ØØ’ ÷
$numØØ◊ ÿ
,ØØÿ Ÿ
$numØØ⁄ €
,ØØ€ ‹
$numØØ› ﬁ
,ØØﬁ ﬂ
$numØØ‡ ·
,ØØ· ‚
DateTimeKindØØ„ Ô
.ØØÔ 
UnspecifiedØØ ˚
)ØØ˚ ¸
}ØØ˝ ˛
,ØØ˛ ˇ
{
∞∞ 
$num
∞∞ 
,
∞∞ 
$str
∞∞ 
,
∞∞ 
$str
∞∞  -
,
∞∞- .
null
∞∞/ 3
,
∞∞3 4
new
∞∞5 8
DateTime
∞∞9 A
(
∞∞A B
$num
∞∞B C
,
∞∞C D
$num
∞∞E F
,
∞∞F G
$num
∞∞H I
,
∞∞I J
$num
∞∞K L
,
∞∞L M
$num
∞∞N O
,
∞∞O P
$num
∞∞Q R
,
∞∞R S
$num
∞∞T U
,
∞∞U V
DateTimeKind
∞∞W c
.
∞∞c d
Unspecified
∞∞d o
)
∞∞o p
,
∞∞p q
null
∞∞r v
,
∞∞v w
new
∞∞x {
DateTime∞∞| Ñ
(∞∞Ñ Ö
$num∞∞Ö Ü
,∞∞Ü á
$num∞∞à â
,∞∞â ä
$num∞∞ã å
,∞∞å ç
$num∞∞é è
,∞∞è ê
$num∞∞ë í
,∞∞í ì
$num∞∞î ï
,∞∞ï ñ
$num∞∞ó ò
,∞∞ò ô
DateTimeKind∞∞ö ¶
.∞∞¶ ß
Unspecified∞∞ß ≤
)∞∞≤ ≥
,∞∞≥ ¥
null∞∞µ π
,∞∞π ∫
new∞∞ª æ
DateTime∞∞ø «
(∞∞« »
$num∞∞» …
,∞∞…  
$num∞∞À Ã
,∞∞Ã Õ
$num∞∞Œ œ
,∞∞œ –
$num∞∞— “
,∞∞“ ”
$num∞∞‘ ’
,∞∞’ ÷
$num∞∞◊ ÿ
,∞∞ÿ Ÿ
$num∞∞⁄ €
,∞∞€ ‹
DateTimeKind∞∞› È
.∞∞È Í
Unspecified∞∞Í ı
)∞∞ı ˆ
}∞∞˜ ¯
,∞∞¯ ˘
{
±± 
$num
±± 
,
±± 
$str
±± 
,
±± 
$str
±±  0
,
±±0 1
null
±±2 6
,
±±6 7
new
±±8 ;
DateTime
±±< D
(
±±D E
$num
±±E F
,
±±F G
$num
±±H I
,
±±I J
$num
±±K L
,
±±L M
$num
±±N O
,
±±O P
$num
±±Q R
,
±±R S
$num
±±T U
,
±±U V
$num
±±W X
,
±±X Y
DateTimeKind
±±Z f
.
±±f g
Unspecified
±±g r
)
±±r s
,
±±s t
null
±±u y
,
±±y z
new
±±{ ~
DateTime±± á
(±±á à
$num±±à â
,±±â ä
$num±±ã å
,±±å ç
$num±±é è
,±±è ê
$num±±ë í
,±±í ì
$num±±î ï
,±±ï ñ
$num±±ó ò
,±±ò ô
$num±±ö õ
,±±õ ú
DateTimeKind±±ù ©
.±±© ™
Unspecified±±™ µ
)±±µ ∂
,±±∂ ∑
null±±∏ º
,±±º Ω
new±±æ ¡
DateTime±±¬  
(±±  À
$num±±À Ã
,±±Ã Õ
$num±±Œ œ
,±±œ –
$num±±— “
,±±“ ”
$num±±‘ ’
,±±’ ÷
$num±±◊ ÿ
,±±ÿ Ÿ
$num±±⁄ €
,±±€ ‹
$num±±› ﬁ
,±±ﬁ ﬂ
DateTimeKind±±‡ Ï
.±±Ï Ì
Unspecified±±Ì ¯
)±±¯ ˘
}±±˙ ˚
,±±˚ ¸
{
≤≤ 
$num
≤≤ 
,
≤≤ 
$str
≤≤ 
,
≤≤ 
$str
≤≤  6
,
≤≤6 7
null
≤≤8 <
,
≤≤< =
new
≤≤> A
DateTime
≤≤B J
(
≤≤J K
$num
≤≤K L
,
≤≤L M
$num
≤≤N O
,
≤≤O P
$num
≤≤Q R
,
≤≤R S
$num
≤≤T U
,
≤≤U V
$num
≤≤W X
,
≤≤X Y
$num
≤≤Z [
,
≤≤[ \
$num
≤≤] ^
,
≤≤^ _
DateTimeKind
≤≤` l
.
≤≤l m
Unspecified
≤≤m x
)
≤≤x y
,
≤≤y z
null
≤≤{ 
,≤≤ Ä
new≤≤Å Ñ
DateTime≤≤Ö ç
(≤≤ç é
$num≤≤é è
,≤≤è ê
$num≤≤ë í
,≤≤í ì
$num≤≤î ï
,≤≤ï ñ
$num≤≤ó ò
,≤≤ò ô
$num≤≤ö õ
,≤≤õ ú
$num≤≤ù û
,≤≤û ü
$num≤≤† °
,≤≤° ¢
DateTimeKind≤≤£ Ø
.≤≤Ø ∞
Unspecified≤≤∞ ª
)≤≤ª º
,≤≤º Ω
null≤≤æ ¬
,≤≤¬ √
new≤≤ƒ «
DateTime≤≤» –
(≤≤– —
$num≤≤— “
,≤≤“ ”
$num≤≤‘ ’
,≤≤’ ÷
$num≤≤◊ ÿ
,≤≤ÿ Ÿ
$num≤≤⁄ €
,≤≤€ ‹
$num≤≤› ﬁ
,≤≤ﬁ ﬂ
$num≤≤‡ ·
,≤≤· ‚
$num≤≤„ ‰
,≤≤‰ Â
DateTimeKind≤≤Ê Ú
.≤≤Ú Û
Unspecified≤≤Û ˛
)≤≤˛ ˇ
}≤≤Ä Å
,≤≤Å Ç
{
≥≥ 
$num
≥≥ 
,
≥≥ 
$str
≥≥ 
,
≥≥ 
$str
≥≥  :
,
≥≥: ;
null
≥≥< @
,
≥≥@ A
new
≥≥B E
DateTime
≥≥F N
(
≥≥N O
$num
≥≥O P
,
≥≥P Q
$num
≥≥R S
,
≥≥S T
$num
≥≥U V
,
≥≥V W
$num
≥≥X Y
,
≥≥Y Z
$num
≥≥[ \
,
≥≥\ ]
$num
≥≥^ _
,
≥≥_ `
$num
≥≥a b
,
≥≥b c
DateTimeKind
≥≥d p
.
≥≥p q
Unspecified
≥≥q |
)
≥≥| }
,
≥≥} ~
null≥≥ É
,≥≥É Ñ
new≥≥Ö à
DateTime≥≥â ë
(≥≥ë í
$num≥≥í ì
,≥≥ì î
$num≥≥ï ñ
,≥≥ñ ó
$num≥≥ò ô
,≥≥ô ö
$num≥≥õ ú
,≥≥ú ù
$num≥≥û ü
,≥≥ü †
$num≥≥° ¢
,≥≥¢ £
$num≥≥§ •
,≥≥• ¶
DateTimeKind≥≥ß ≥
.≥≥≥ ¥
Unspecified≥≥¥ ø
)≥≥ø ¿
,≥≥¿ ¡
null≥≥¬ ∆
,≥≥∆ «
new≥≥» À
DateTime≥≥Ã ‘
(≥≥‘ ’
$num≥≥’ ÷
,≥≥÷ ◊
$num≥≥ÿ Ÿ
,≥≥Ÿ ⁄
$num≥≥€ ‹
,≥≥‹ ›
$num≥≥ﬁ ﬂ
,≥≥ﬂ ‡
$num≥≥· ‚
,≥≥‚ „
$num≥≥‰ Â
,≥≥Â Ê
$num≥≥Á Ë
,≥≥Ë È
DateTimeKind≥≥Í ˆ
.≥≥ˆ ˜
Unspecified≥≥˜ Ç
)≥≥Ç É
}≥≥Ñ Ö
,≥≥Ö Ü
{
¥¥ 
$num
¥¥ 
,
¥¥ 
$str
¥¥ 
,
¥¥ 
$str
¥¥  <
,
¥¥< =
null
¥¥> B
,
¥¥B C
new
¥¥D G
DateTime
¥¥H P
(
¥¥P Q
$num
¥¥Q R
,
¥¥R S
$num
¥¥T U
,
¥¥U V
$num
¥¥W X
,
¥¥X Y
$num
¥¥Z [
,
¥¥[ \
$num
¥¥] ^
,
¥¥^ _
$num
¥¥` a
,
¥¥a b
$num
¥¥c d
,
¥¥d e
DateTimeKind
¥¥f r
.
¥¥r s
Unspecified
¥¥s ~
)
¥¥~ 
,¥¥ Ä
null¥¥Å Ö
,¥¥Ö Ü
new¥¥á ä
DateTime¥¥ã ì
(¥¥ì î
$num¥¥î ï
,¥¥ï ñ
$num¥¥ó ò
,¥¥ò ô
$num¥¥ö õ
,¥¥õ ú
$num¥¥ù û
,¥¥û ü
$num¥¥† °
,¥¥° ¢
$num¥¥£ §
,¥¥§ •
$num¥¥¶ ß
,¥¥ß ®
DateTimeKind¥¥© µ
.¥¥µ ∂
Unspecified¥¥∂ ¡
)¥¥¡ ¬
,¥¥¬ √
null¥¥ƒ »
,¥¥» …
new¥¥  Õ
DateTime¥¥Œ ÷
(¥¥÷ ◊
$num¥¥◊ ÿ
,¥¥ÿ Ÿ
$num¥¥⁄ €
,¥¥€ ‹
$num¥¥› ﬁ
,¥¥ﬁ ﬂ
$num¥¥‡ ·
,¥¥· ‚
$num¥¥„ ‰
,¥¥‰ Â
$num¥¥Ê Á
,¥¥Á Ë
$num¥¥È Í
,¥¥Í Î
DateTimeKind¥¥Ï ¯
.¥¥¯ ˘
Unspecified¥¥˘ Ñ
)¥¥Ñ Ö
}¥¥Ü á
,¥¥á à
{
µµ 
$num
µµ 
,
µµ 
$str
µµ 
,
µµ 
$str
µµ  ;
,
µµ; <
null
µµ= A
,
µµA B
new
µµC F
DateTime
µµG O
(
µµO P
$num
µµP Q
,
µµQ R
$num
µµS T
,
µµT U
$num
µµV W
,
µµW X
$num
µµY Z
,
µµZ [
$num
µµ\ ]
,
µµ] ^
$num
µµ_ `
,
µµ` a
$num
µµb c
,
µµc d
DateTimeKind
µµe q
.
µµq r
Unspecified
µµr }
)
µµ} ~
,
µµ~ 
nullµµÄ Ñ
,µµÑ Ö
newµµÜ â
DateTimeµµä í
(µµí ì
$numµµì î
,µµî ï
$numµµñ ó
,µµó ò
$numµµô ö
,µµö õ
$numµµú ù
,µµù û
$numµµü †
,µµ† °
$numµµ¢ £
,µµ£ §
$numµµ• ¶
,µµ¶ ß
DateTimeKindµµ® ¥
.µµ¥ µ
Unspecifiedµµµ ¿
)µµ¿ ¡
,µµ¡ ¬
nullµµ√ «
,µµ« »
newµµ… Ã
DateTimeµµÕ ’
(µµ’ ÷
$numµµ÷ ◊
,µµ◊ ÿ
$numµµŸ ⁄
,µµ⁄ €
$numµµ‹ ›
,µµ› ﬁ
$numµµﬂ ‡
,µµ‡ ·
$numµµ‚ „
,µµ„ ‰
$numµµÂ Ê
,µµÊ Á
$numµµË È
,µµÈ Í
DateTimeKindµµÎ ˜
.µµ˜ ¯
Unspecifiedµµ¯ É
)µµÉ Ñ
}µµÖ Ü
}
∂∂ 
)
∂∂ 
;
∂∂ 
migrationBuilder
∏∏ 
.
∏∏ 

InsertData
∏∏ '
(
∏∏' (
schema
ππ 
:
ππ 
$str
ππ 
,
ππ 
table
∫∫ 
:
∫∫ 
$str
∫∫ '
,
∫∫' (
columns
ªª 
:
ªª 
new
ªª 
[
ªª 
]
ªª 
{
ªª  
$str
ªª! 2
,
ªª2 3
$str
ªª4 C
,
ªªC D
$str
ªªE P
,
ªªP Q
$str
ªªR ]
,
ªª] ^
$str
ªª_ k
,
ªªk l
$str
ªªm x
,
ªªx y
$strªªz Ö
,ªªÖ Ü
$strªªá í
,ªªí ì
$strªªî †
,ªª† °
$strªª¢ Æ
,ªªÆ Ø
$strªª∞ æ
}ªªø ¿
,ªª¿ ¡
values
ºº 
:
ºº 
new
ºº 
object
ºº "
[
ºº" #
,
ºº# $
]
ºº$ %
{
ΩΩ 
{
ææ 
$num
ææ 
,
ææ 
$str
ææ !
,
ææ! "
null
ææ# '
,
ææ' (
new
ææ) ,
DateTime
ææ- 5
(
ææ5 6
$num
ææ6 7
,
ææ7 8
$num
ææ9 :
,
ææ: ;
$num
ææ< =
,
ææ= >
$num
ææ? @
,
ææ@ A
$num
ææB C
,
ææC D
$num
ææE F
,
ææF G
$num
ææH I
,
ææI J
DateTimeKind
ææK W
.
ææW X
Unspecified
ææX c
)
ææc d
,
ææd e
$num
ææf g
,
ææg h
null
ææi m
,
ææm n
new
ææo r
DateTime
ææs {
(
ææ{ |
$num
ææ| }
,
ææ} ~
$numææ Ä
,ææÄ Å
$numææÇ É
,ææÉ Ñ
$numææÖ Ü
,ææÜ á
$numææà â
,ææâ ä
$numææã å
,ææå ç
$numææé è
,ææè ê
DateTimeKindææë ù
.ææù û
Unspecifiedææû ©
)ææ© ™
,ææ™ ´
$numææ¨ ±
,ææ± ≤
nullææ≥ ∑
,ææ∑ ∏
newææπ º
DateTimeææΩ ≈
(ææ≈ ∆
$numææ∆ «
,ææ« »
$numææ…  
,ææ  À
$numææÃ Õ
,ææÕ Œ
$numææœ –
,ææ– —
$numææ“ ”
,ææ” ‘
$numææ’ ÷
,ææ÷ ◊
$numææÿ Ÿ
,ææŸ ⁄
DateTimeKindææ€ Á
.ææÁ Ë
UnspecifiedææË Û
)ææÛ Ù
,ææÙ ı
$numææˆ ˚
}ææ¸ ˝
,ææ˝ ˛
{
øø 
$num
øø 
,
øø 
$str
øø &
,
øø& '
null
øø( ,
,
øø, -
new
øø. 1
DateTime
øø2 :
(
øø: ;
$num
øø; <
,
øø< =
$num
øø> ?
,
øø? @
$num
øøA B
,
øøB C
$num
øøD E
,
øøE F
$num
øøG H
,
øøH I
$num
øøJ K
,
øøK L
$num
øøM N
,
øøN O
DateTimeKind
øøP \
.
øø\ ]
Unspecified
øø] h
)
øøh i
,
øøi j
$num
øøk l
,
øøl m
null
øøn r
,
øør s
new
øøt w
DateTimeøøx Ä
(øøÄ Å
$numøøÅ Ç
,øøÇ É
$numøøÑ Ö
,øøÖ Ü
$numøøá à
,øøà â
$numøøä ã
,øøã å
$numøøç é
,øøé è
$numøøê ë
,øøë í
$numøøì î
,øøî ï
DateTimeKindøøñ ¢
.øø¢ £
Unspecifiedøø£ Æ
)øøÆ Ø
,øøØ ∞
$numøø± √
,øø√ ƒ
nulløø≈ …
,øø…  
newøøÀ Œ
DateTimeøøœ ◊
(øø◊ ÿ
$numøøÿ Ÿ
,øøŸ ⁄
$numøø€ ‹
,øø‹ ›
$numøøﬁ ﬂ
,øøﬂ ‡
$numøø· ‚
,øø‚ „
$numøø‰ Â
,øøÂ Ê
$numøøÁ Ë
,øøË È
$numøøÍ Î
,øøÎ Ï
DateTimeKindøøÌ ˘
.øø˘ ˙
Unspecifiedøø˙ Ö
)øøÖ Ü
,øøÜ á
$numøøà é
}øøè ê
,øøê ë
{
¿¿ 
$num
¿¿ 
,
¿¿ 
$str
¿¿ 0
,
¿¿0 1
null
¿¿2 6
,
¿¿6 7
new
¿¿8 ;
DateTime
¿¿< D
(
¿¿D E
$num
¿¿E F
,
¿¿F G
$num
¿¿H I
,
¿¿I J
$num
¿¿K L
,
¿¿L M
$num
¿¿N O
,
¿¿O P
$num
¿¿Q R
,
¿¿R S
$num
¿¿T U
,
¿¿U V
$num
¿¿W X
,
¿¿X Y
DateTimeKind
¿¿Z f
.
¿¿f g
Unspecified
¿¿g r
)
¿¿r s
,
¿¿s t
$num
¿¿u v
,
¿¿v w
null
¿¿x |
,
¿¿| }
new¿¿~ Å
DateTime¿¿Ç ä
(¿¿ä ã
$num¿¿ã å
,¿¿å ç
$num¿¿é è
,¿¿è ê
$num¿¿ë í
,¿¿í ì
$num¿¿î ï
,¿¿ï ñ
$num¿¿ó ò
,¿¿ò ô
$num¿¿ö õ
,¿¿õ ú
$num¿¿ù û
,¿¿û ü
DateTimeKind¿¿† ¨
.¿¿¨ ≠
Unspecified¿¿≠ ∏
)¿¿∏ π
,¿¿π ∫
$num¿¿ª Õ
,¿¿Õ Œ
null¿¿œ ”
,¿¿” ‘
new¿¿’ ÿ
DateTime¿¿Ÿ ·
(¿¿· ‚
$num¿¿‚ „
,¿¿„ ‰
$num¿¿Â Ê
,¿¿Ê Á
$num¿¿Ë È
,¿¿È Í
$num¿¿Î Ï
,¿¿Ï Ì
$num¿¿Ó Ô
,¿¿Ô 
$num¿¿Ò Ú
,¿¿Ú Û
$num¿¿Ù ı
,¿¿ı ˆ
DateTimeKind¿¿˜ É
.¿¿É Ñ
Unspecified¿¿Ñ è
)¿¿è ê
,¿¿ê ë
$num¿¿í ò
}¿¿ô ö
,¿¿ö õ
{
¡¡ 
$num
¡¡ 
,
¡¡ 
$str
¡¡ '
,
¡¡' (
null
¡¡) -
,
¡¡- .
new
¡¡/ 2
DateTime
¡¡3 ;
(
¡¡; <
$num
¡¡< =
,
¡¡= >
$num
¡¡? @
,
¡¡@ A
$num
¡¡B C
,
¡¡C D
$num
¡¡E F
,
¡¡F G
$num
¡¡H I
,
¡¡I J
$num
¡¡K L
,
¡¡L M
$num
¡¡N O
,
¡¡O P
DateTimeKind
¡¡Q ]
.
¡¡] ^
Unspecified
¡¡^ i
)
¡¡i j
,
¡¡j k
$num
¡¡l m
,
¡¡m n
null
¡¡o s
,
¡¡s t
new
¡¡u x
DateTime¡¡y Å
(¡¡Å Ç
$num¡¡Ç É
,¡¡É Ñ
$num¡¡Ö Ü
,¡¡Ü á
$num¡¡à â
,¡¡â ä
$num¡¡ã å
,¡¡å ç
$num¡¡é è
,¡¡è ê
$num¡¡ë í
,¡¡í ì
$num¡¡î ï
,¡¡ï ñ
DateTimeKind¡¡ó £
.¡¡£ §
Unspecified¡¡§ Ø
)¡¡Ø ∞
,¡¡∞ ±
$num¡¡≤ ƒ
,¡¡ƒ ≈
null¡¡∆  
,¡¡  À
new¡¡Ã œ
DateTime¡¡– ÿ
(¡¡ÿ Ÿ
$num¡¡Ÿ ⁄
,¡¡⁄ €
$num¡¡‹ ›
,¡¡› ﬁ
$num¡¡ﬂ ‡
,¡¡‡ ·
$num¡¡‚ „
,¡¡„ ‰
$num¡¡Â Ê
,¡¡Ê Á
$num¡¡Ë È
,¡¡È Í
$num¡¡Î Ï
,¡¡Ï Ì
DateTimeKind¡¡Ó ˙
.¡¡˙ ˚
Unspecified¡¡˚ Ü
)¡¡Ü á
,¡¡á à
$num¡¡â è
}¡¡ê ë
}
¬¬ 
)
¬¬ 
;
¬¬ 
migrationBuilder
ƒƒ 
.
ƒƒ 

InsertData
ƒƒ '
(
ƒƒ' (
schema
≈≈ 
:
≈≈ 
$str
≈≈ 
,
≈≈ 
table
∆∆ 
:
∆∆ 
$str
∆∆ %
,
∆∆% &
columns
«« 
:
«« 
new
«« 
[
«« 
]
«« 
{
««  
$str
««! 1
,
««1 2
$str
««3 >
,
««> ?
$str
««@ K
,
««K L
$str
««M \
,
««\ ]
$str
««^ i
,
««i j
$str
««k v
,
««v w
$str««x Ñ
,««Ñ Ö
$str««Ü í
}««ì î
,««î ï
values
»» 
:
»» 
new
»» 
object
»» "
[
»»" #
,
»»# $
]
»»$ %
{
…… 
{
   
$num
   
,
   
null
   
,
   
new
   "
DateTime
  # +
(
  + ,
$num
  , -
,
  - .
$num
  / 0
,
  0 1
$num
  2 3
,
  3 4
$num
  5 6
,
  6 7
$num
  8 9
,
  9 :
$num
  ; <
,
  < =
$num
  > ?
,
  ? @
DateTimeKind
  A M
.
  M N
Unspecified
  N Y
)
  Y Z
,
  Z [
$str
  \ e
,
  e f
null
  g k
,
  k l
new
  m p
DateTime
  q y
(
  y z
$num
  z {
,
  { |
$num
  } ~
,
  ~ 
$num  Ä Å
,  Å Ç
$num  É Ñ
,  Ñ Ö
$num  Ü á
,  á à
$num  â ä
,  ä ã
$num  å ç
,  ç é
DateTimeKind  è õ
.  õ ú
Unspecified  ú ß
)  ß ®
,  ® ©
null  ™ Æ
,  Æ Ø
new  ∞ ≥
DateTime  ¥ º
(  º Ω
$num  Ω æ
,  æ ø
$num  ¿ ¡
,  ¡ ¬
$num  √ ƒ
,  ƒ ≈
$num  ∆ «
,  « »
$num  …  
,    À
$num  Ã Õ
,  Õ Œ
$num  œ –
,  – —
DateTimeKind  “ ﬁ
.  ﬁ ﬂ
Unspecified  ﬂ Í
)  Í Î
}  Ï Ì
,  Ì Ó
{
ÀÀ 
$num
ÀÀ 
,
ÀÀ 
null
ÀÀ 
,
ÀÀ 
new
ÀÀ "
DateTime
ÀÀ# +
(
ÀÀ+ ,
$num
ÀÀ, -
,
ÀÀ- .
$num
ÀÀ/ 0
,
ÀÀ0 1
$num
ÀÀ2 3
,
ÀÀ3 4
$num
ÀÀ5 6
,
ÀÀ6 7
$num
ÀÀ8 9
,
ÀÀ9 :
$num
ÀÀ; <
,
ÀÀ< =
$num
ÀÀ> ?
,
ÀÀ? @
DateTimeKind
ÀÀA M
.
ÀÀM N
Unspecified
ÀÀN Y
)
ÀÀY Z
,
ÀÀZ [
$str
ÀÀ\ h
,
ÀÀh i
null
ÀÀj n
,
ÀÀn o
new
ÀÀp s
DateTime
ÀÀt |
(
ÀÀ| }
$num
ÀÀ} ~
,
ÀÀ~ 
$numÀÀÄ Å
,ÀÀÅ Ç
$numÀÀÉ Ñ
,ÀÀÑ Ö
$numÀÀÜ á
,ÀÀá à
$numÀÀâ ä
,ÀÀä ã
$numÀÀå ç
,ÀÀç é
$numÀÀè ê
,ÀÀê ë
DateTimeKindÀÀí û
.ÀÀû ü
UnspecifiedÀÀü ™
)ÀÀ™ ´
,ÀÀ´ ¨
nullÀÀ≠ ±
,ÀÀ± ≤
newÀÀ≥ ∂
DateTimeÀÀ∑ ø
(ÀÀø ¿
$numÀÀ¿ ¡
,ÀÀ¡ ¬
$numÀÀ√ ƒ
,ÀÀƒ ≈
$numÀÀ∆ «
,ÀÀ« »
$numÀÀ…  
,ÀÀ  À
$numÀÀÃ Õ
,ÀÀÕ Œ
$numÀÀœ –
,ÀÀ– —
$numÀÀ“ ”
,ÀÀ” ‘
DateTimeKindÀÀ’ ·
.ÀÀ· ‚
UnspecifiedÀÀ‚ Ì
)ÀÀÌ Ó
}ÀÀÔ 
,ÀÀ Ò
{
ÃÃ 
$num
ÃÃ 
,
ÃÃ 
null
ÃÃ 
,
ÃÃ 
new
ÃÃ "
DateTime
ÃÃ# +
(
ÃÃ+ ,
$num
ÃÃ, -
,
ÃÃ- .
$num
ÃÃ/ 0
,
ÃÃ0 1
$num
ÃÃ2 3
,
ÃÃ3 4
$num
ÃÃ5 6
,
ÃÃ6 7
$num
ÃÃ8 9
,
ÃÃ9 :
$num
ÃÃ; <
,
ÃÃ< =
$num
ÃÃ> ?
,
ÃÃ? @
DateTimeKind
ÃÃA M
.
ÃÃM N
Unspecified
ÃÃN Y
)
ÃÃY Z
,
ÃÃZ [
$str
ÃÃ\ m
,
ÃÃm n
null
ÃÃo s
,
ÃÃs t
new
ÃÃu x
DateTimeÃÃy Å
(ÃÃÅ Ç
$numÃÃÇ É
,ÃÃÉ Ñ
$numÃÃÖ Ü
,ÃÃÜ á
$numÃÃà â
,ÃÃâ ä
$numÃÃã å
,ÃÃå ç
$numÃÃé è
,ÃÃè ê
$numÃÃë í
,ÃÃí ì
$numÃÃî ï
,ÃÃï ñ
DateTimeKindÃÃó £
.ÃÃ£ §
UnspecifiedÃÃ§ Ø
)ÃÃØ ∞
,ÃÃ∞ ±
nullÃÃ≤ ∂
,ÃÃ∂ ∑
newÃÃ∏ ª
DateTimeÃÃº ƒ
(ÃÃƒ ≈
$numÃÃ≈ ∆
,ÃÃ∆ «
$numÃÃ» …
,ÃÃ…  
$numÃÃÀ Ã
,ÃÃÃ Õ
$numÃÃŒ œ
,ÃÃœ –
$numÃÃ— “
,ÃÃ“ ”
$numÃÃ‘ ’
,ÃÃ’ ÷
$numÃÃ◊ ÿ
,ÃÃÿ Ÿ
DateTimeKindÃÃ⁄ Ê
.ÃÃÊ Á
UnspecifiedÃÃÁ Ú
)ÃÃÚ Û
}ÃÃÙ ı
,ÃÃı ˆ
{
ÕÕ 
$num
ÕÕ 
,
ÕÕ 
null
ÕÕ 
,
ÕÕ 
new
ÕÕ "
DateTime
ÕÕ# +
(
ÕÕ+ ,
$num
ÕÕ, -
,
ÕÕ- .
$num
ÕÕ/ 0
,
ÕÕ0 1
$num
ÕÕ2 3
,
ÕÕ3 4
$num
ÕÕ5 6
,
ÕÕ6 7
$num
ÕÕ8 9
,
ÕÕ9 :
$num
ÕÕ; <
,
ÕÕ< =
$num
ÕÕ> ?
,
ÕÕ? @
DateTimeKind
ÕÕA M
.
ÕÕM N
Unspecified
ÕÕN Y
)
ÕÕY Z
,
ÕÕZ [
$str
ÕÕ\ m
,
ÕÕm n
null
ÕÕo s
,
ÕÕs t
new
ÕÕu x
DateTimeÕÕy Å
(ÕÕÅ Ç
$numÕÕÇ É
,ÕÕÉ Ñ
$numÕÕÖ Ü
,ÕÕÜ á
$numÕÕà â
,ÕÕâ ä
$numÕÕã å
,ÕÕå ç
$numÕÕé è
,ÕÕè ê
$numÕÕë í
,ÕÕí ì
$numÕÕî ï
,ÕÕï ñ
DateTimeKindÕÕó £
.ÕÕ£ §
UnspecifiedÕÕ§ Ø
)ÕÕØ ∞
,ÕÕ∞ ±
nullÕÕ≤ ∂
,ÕÕ∂ ∑
newÕÕ∏ ª
DateTimeÕÕº ƒ
(ÕÕƒ ≈
$numÕÕ≈ ∆
,ÕÕ∆ «
$numÕÕ» …
,ÕÕ…  
$numÕÕÀ Ã
,ÕÕÃ Õ
$numÕÕŒ œ
,ÕÕœ –
$numÕÕ— “
,ÕÕ“ ”
$numÕÕ‘ ’
,ÕÕ’ ÷
$numÕÕ◊ ÿ
,ÕÕÿ Ÿ
DateTimeKindÕÕ⁄ Ê
.ÕÕÊ Á
UnspecifiedÕÕÁ Ú
)ÕÕÚ Û
}ÕÕÙ ı
,ÕÕı ˆ
{
ŒŒ 
$num
ŒŒ 
,
ŒŒ 
null
ŒŒ 
,
ŒŒ 
new
ŒŒ "
DateTime
ŒŒ# +
(
ŒŒ+ ,
$num
ŒŒ, -
,
ŒŒ- .
$num
ŒŒ/ 0
,
ŒŒ0 1
$num
ŒŒ2 3
,
ŒŒ3 4
$num
ŒŒ5 6
,
ŒŒ6 7
$num
ŒŒ8 9
,
ŒŒ9 :
$num
ŒŒ; <
,
ŒŒ< =
$num
ŒŒ> ?
,
ŒŒ? @
DateTimeKind
ŒŒA M
.
ŒŒM N
Unspecified
ŒŒN Y
)
ŒŒY Z
,
ŒŒZ [
$str
ŒŒ\ i
,
ŒŒi j
null
ŒŒk o
,
ŒŒo p
new
ŒŒq t
DateTime
ŒŒu }
(
ŒŒ} ~
$num
ŒŒ~ 
,ŒŒ Ä
$numŒŒÅ Ç
,ŒŒÇ É
$numŒŒÑ Ö
,ŒŒÖ Ü
$numŒŒá à
,ŒŒà â
$numŒŒä ã
,ŒŒã å
$numŒŒç é
,ŒŒé è
$numŒŒê ë
,ŒŒë í
DateTimeKindŒŒì ü
.ŒŒü †
UnspecifiedŒŒ† ´
)ŒŒ´ ¨
,ŒŒ¨ ≠
nullŒŒÆ ≤
,ŒŒ≤ ≥
newŒŒ¥ ∑
DateTimeŒŒ∏ ¿
(ŒŒ¿ ¡
$numŒŒ¡ ¬
,ŒŒ¬ √
$numŒŒƒ ≈
,ŒŒ≈ ∆
$numŒŒ« »
,ŒŒ» …
$numŒŒ  À
,ŒŒÀ Ã
$numŒŒÕ Œ
,ŒŒŒ œ
$numŒŒ– —
,ŒŒ— “
$numŒŒ” ‘
,ŒŒ‘ ’
DateTimeKindŒŒ÷ ‚
.ŒŒ‚ „
UnspecifiedŒŒ„ Ó
)ŒŒÓ Ô
}ŒŒ Ò
}
œœ 
)
œœ 
;
œœ 
migrationBuilder
—— 
.
—— 

InsertData
—— '
(
——' (
schema
““ 
:
““ 
$str
““ 
,
““ 
table
”” 
:
”” 
$str
””  
,
””  !
columns
‘‘ 
:
‘‘ 
new
‘‘ 
[
‘‘ 
]
‘‘ 
{
‘‘  
$str
‘‘! ,
,
‘‘, -
$str
‘‘. 9
,
‘‘9 :
$str
‘‘; F
,
‘‘F G
$str
‘‘H S
,
‘‘S T
$str
‘‘U `
,
‘‘` a
$str
‘‘b r
,
‘‘r s
$str‘‘t Å
,‘‘Å Ç
$str‘‘É è
,‘‘è ê
$str‘‘ë ù
}‘‘û ü
,‘‘ü †
values
’’ 
:
’’ 
new
’’ 
object
’’ "
[
’’" #
,
’’# $
]
’’$ %
{
÷÷ 
{
◊◊ 
$num
◊◊ 
,
◊◊ 
null
◊◊ 
,
◊◊ 
new
◊◊ "
DateTime
◊◊# +
(
◊◊+ ,
$num
◊◊, -
,
◊◊- .
$num
◊◊/ 0
,
◊◊0 1
$num
◊◊2 3
,
◊◊3 4
$num
◊◊5 6
,
◊◊6 7
$num
◊◊8 9
,
◊◊9 :
$num
◊◊; <
,
◊◊< =
$num
◊◊> ?
,
◊◊? @
DateTimeKind
◊◊A M
.
◊◊M N
Unspecified
◊◊N Y
)
◊◊Y Z
,
◊◊Z [
null
◊◊\ `
,
◊◊` a
new
◊◊b e
DateTime
◊◊f n
(
◊◊n o
$num
◊◊o p
,
◊◊p q
$num
◊◊r s
,
◊◊s t
$num
◊◊u v
,
◊◊v w
$num
◊◊x y
,
◊◊y z
$num
◊◊{ |
,
◊◊| }
$num
◊◊~ 
,◊◊ Ä
$num◊◊Å Ç
,◊◊Ç É
DateTimeKind◊◊Ñ ê
.◊◊ê ë
Unspecified◊◊ë ú
)◊◊ú ù
,◊◊ù û
$str◊◊ü §
,◊◊§ •
$str◊◊¶ ≥
,◊◊≥ ¥
null◊◊µ π
,◊◊π ∫
new◊◊ª æ
DateTime◊◊ø «
(◊◊« »
$num◊◊» …
,◊◊…  
$num◊◊À Ã
,◊◊Ã Õ
$num◊◊Œ œ
,◊◊œ –
$num◊◊— “
,◊◊“ ”
$num◊◊‘ ’
,◊◊’ ÷
$num◊◊◊ ÿ
,◊◊ÿ Ÿ
$num◊◊⁄ €
,◊◊€ ‹
DateTimeKind◊◊› È
.◊◊È Í
Unspecified◊◊Í ı
)◊◊ı ˆ
}◊◊˜ ¯
,◊◊¯ ˘
{
ÿÿ 
$num
ÿÿ 
,
ÿÿ 
null
ÿÿ 
,
ÿÿ 
new
ÿÿ "
DateTime
ÿÿ# +
(
ÿÿ+ ,
$num
ÿÿ, -
,
ÿÿ- .
$num
ÿÿ/ 0
,
ÿÿ0 1
$num
ÿÿ2 3
,
ÿÿ3 4
$num
ÿÿ5 6
,
ÿÿ6 7
$num
ÿÿ8 9
,
ÿÿ9 :
$num
ÿÿ; <
,
ÿÿ< =
$num
ÿÿ> ?
,
ÿÿ? @
DateTimeKind
ÿÿA M
.
ÿÿM N
Unspecified
ÿÿN Y
)
ÿÿY Z
,
ÿÿZ [
null
ÿÿ\ `
,
ÿÿ` a
new
ÿÿb e
DateTime
ÿÿf n
(
ÿÿn o
$num
ÿÿo p
,
ÿÿp q
$num
ÿÿr s
,
ÿÿs t
$num
ÿÿu v
,
ÿÿv w
$num
ÿÿx y
,
ÿÿy z
$num
ÿÿ{ |
,
ÿÿ| }
$num
ÿÿ~ 
,ÿÿ Ä
$numÿÿÅ Ç
,ÿÿÇ É
DateTimeKindÿÿÑ ê
.ÿÿê ë
Unspecifiedÿÿë ú
)ÿÿú ù
,ÿÿù û
$strÿÿü §
,ÿÿ§ •
$strÿÿ¶ æ
,ÿÿæ ø
nullÿÿ¿ ƒ
,ÿÿƒ ≈
newÿÿ∆ …
DateTimeÿÿ  “
(ÿÿ“ ”
$numÿÿ” ‘
,ÿÿ‘ ’
$numÿÿ÷ ◊
,ÿÿ◊ ÿ
$numÿÿŸ ⁄
,ÿÿ⁄ €
$numÿÿ‹ ›
,ÿÿ› ﬁ
$numÿÿﬂ ‡
,ÿÿ‡ ·
$numÿÿ‚ „
,ÿÿ„ ‰
$numÿÿÂ Ê
,ÿÿÊ Á
DateTimeKindÿÿË Ù
.ÿÿÙ ı
Unspecifiedÿÿı Ä
)ÿÿÄ Å
}ÿÿÇ É
,ÿÿÉ Ñ
{
ŸŸ 
$num
ŸŸ 
,
ŸŸ 
null
ŸŸ 
,
ŸŸ 
new
ŸŸ "
DateTime
ŸŸ# +
(
ŸŸ+ ,
$num
ŸŸ, -
,
ŸŸ- .
$num
ŸŸ/ 0
,
ŸŸ0 1
$num
ŸŸ2 3
,
ŸŸ3 4
$num
ŸŸ5 6
,
ŸŸ6 7
$num
ŸŸ8 9
,
ŸŸ9 :
$num
ŸŸ; <
,
ŸŸ< =
$num
ŸŸ> ?
,
ŸŸ? @
DateTimeKind
ŸŸA M
.
ŸŸM N
Unspecified
ŸŸN Y
)
ŸŸY Z
,
ŸŸZ [
null
ŸŸ\ `
,
ŸŸ` a
new
ŸŸb e
DateTime
ŸŸf n
(
ŸŸn o
$num
ŸŸo p
,
ŸŸp q
$num
ŸŸr s
,
ŸŸs t
$num
ŸŸu v
,
ŸŸv w
$num
ŸŸx y
,
ŸŸy z
$num
ŸŸ{ |
,
ŸŸ| }
$num
ŸŸ~ 
,ŸŸ Ä
$numŸŸÅ Ç
,ŸŸÇ É
DateTimeKindŸŸÑ ê
.ŸŸê ë
UnspecifiedŸŸë ú
)ŸŸú ù
,ŸŸù û
$strŸŸü §
,ŸŸ§ •
$strŸŸ¶ ø
,ŸŸø ¿
nullŸŸ¡ ≈
,ŸŸ≈ ∆
newŸŸ«  
DateTimeŸŸÀ ”
(ŸŸ” ‘
$numŸŸ‘ ’
,ŸŸ’ ÷
$numŸŸ◊ ÿ
,ŸŸÿ Ÿ
$numŸŸ⁄ €
,ŸŸ€ ‹
$numŸŸ› ﬁ
,ŸŸﬁ ﬂ
$numŸŸ‡ ·
,ŸŸ· ‚
$numŸŸ„ ‰
,ŸŸ‰ Â
$numŸŸÊ Á
,ŸŸÁ Ë
DateTimeKindŸŸÈ ı
.ŸŸı ˆ
UnspecifiedŸŸˆ Å
)ŸŸÅ Ç
}ŸŸÉ Ñ
,ŸŸÑ Ö
{
⁄⁄ 
$num
⁄⁄ 
,
⁄⁄ 
null
⁄⁄ 
,
⁄⁄ 
new
⁄⁄ "
DateTime
⁄⁄# +
(
⁄⁄+ ,
$num
⁄⁄, -
,
⁄⁄- .
$num
⁄⁄/ 0
,
⁄⁄0 1
$num
⁄⁄2 3
,
⁄⁄3 4
$num
⁄⁄5 6
,
⁄⁄6 7
$num
⁄⁄8 9
,
⁄⁄9 :
$num
⁄⁄; <
,
⁄⁄< =
$num
⁄⁄> ?
,
⁄⁄? @
DateTimeKind
⁄⁄A M
.
⁄⁄M N
Unspecified
⁄⁄N Y
)
⁄⁄Y Z
,
⁄⁄Z [
null
⁄⁄\ `
,
⁄⁄` a
new
⁄⁄b e
DateTime
⁄⁄f n
(
⁄⁄n o
$num
⁄⁄o p
,
⁄⁄p q
$num
⁄⁄r s
,
⁄⁄s t
$num
⁄⁄u v
,
⁄⁄v w
$num
⁄⁄x y
,
⁄⁄y z
$num
⁄⁄{ |
,
⁄⁄| }
$num
⁄⁄~ 
,⁄⁄ Ä
$num⁄⁄Å Ç
,⁄⁄Ç É
DateTimeKind⁄⁄Ñ ê
.⁄⁄ê ë
Unspecified⁄⁄ë ú
)⁄⁄ú ù
,⁄⁄ù û
$str⁄⁄ü §
,⁄⁄§ •
$str⁄⁄¶ ≠
,⁄⁄≠ Æ
null⁄⁄Ø ≥
,⁄⁄≥ ¥
new⁄⁄µ ∏
DateTime⁄⁄π ¡
(⁄⁄¡ ¬
$num⁄⁄¬ √
,⁄⁄√ ƒ
$num⁄⁄≈ ∆
,⁄⁄∆ «
$num⁄⁄» …
,⁄⁄…  
$num⁄⁄À Ã
,⁄⁄Ã Õ
$num⁄⁄Œ œ
,⁄⁄œ –
$num⁄⁄— “
,⁄⁄“ ”
$num⁄⁄‘ ’
,⁄⁄’ ÷
DateTimeKind⁄⁄◊ „
.⁄⁄„ ‰
Unspecified⁄⁄‰ Ô
)⁄⁄Ô 
}⁄⁄Ò Ú
,⁄⁄Ú Û
{
€€ 
$num
€€ 
,
€€ 
null
€€ 
,
€€ 
new
€€ "
DateTime
€€# +
(
€€+ ,
$num
€€, -
,
€€- .
$num
€€/ 0
,
€€0 1
$num
€€2 3
,
€€3 4
$num
€€5 6
,
€€6 7
$num
€€8 9
,
€€9 :
$num
€€; <
,
€€< =
$num
€€> ?
,
€€? @
DateTimeKind
€€A M
.
€€M N
Unspecified
€€N Y
)
€€Y Z
,
€€Z [
null
€€\ `
,
€€` a
new
€€b e
DateTime
€€f n
(
€€n o
$num
€€o p
,
€€p q
$num
€€r s
,
€€s t
$num
€€u v
,
€€v w
$num
€€x y
,
€€y z
$num
€€{ |
,
€€| }
$num
€€~ 
,€€ Ä
$num€€Å Ç
,€€Ç É
DateTimeKind€€Ñ ê
.€€ê ë
Unspecified€€ë ú
)€€ú ù
,€€ù û
$str€€ü §
,€€§ •
$str€€¶ ¨
,€€¨ ≠
null€€Æ ≤
,€€≤ ≥
new€€¥ ∑
DateTime€€∏ ¿
(€€¿ ¡
$num€€¡ ¬
,€€¬ √
$num€€ƒ ≈
,€€≈ ∆
$num€€« »
,€€» …
$num€€  À
,€€À Ã
$num€€Õ Œ
,€€Œ œ
$num€€– —
,€€— “
$num€€” ‘
,€€‘ ’
DateTimeKind€€÷ ‚
.€€‚ „
Unspecified€€„ Ó
)€€Ó Ô
}€€ Ò
,€€Ò Ú
{
‹‹ 
$num
‹‹ 
,
‹‹ 
null
‹‹ 
,
‹‹ 
new
‹‹ "
DateTime
‹‹# +
(
‹‹+ ,
$num
‹‹, -
,
‹‹- .
$num
‹‹/ 0
,
‹‹0 1
$num
‹‹2 3
,
‹‹3 4
$num
‹‹5 6
,
‹‹6 7
$num
‹‹8 9
,
‹‹9 :
$num
‹‹; <
,
‹‹< =
$num
‹‹> ?
,
‹‹? @
DateTimeKind
‹‹A M
.
‹‹M N
Unspecified
‹‹N Y
)
‹‹Y Z
,
‹‹Z [
null
‹‹\ `
,
‹‹` a
new
‹‹b e
DateTime
‹‹f n
(
‹‹n o
$num
‹‹o p
,
‹‹p q
$num
‹‹r s
,
‹‹s t
$num
‹‹u v
,
‹‹v w
$num
‹‹x y
,
‹‹y z
$num
‹‹{ |
,
‹‹| }
$num
‹‹~ 
,‹‹ Ä
$num‹‹Å Ç
,‹‹Ç É
DateTimeKind‹‹Ñ ê
.‹‹ê ë
Unspecified‹‹ë ú
)‹‹ú ù
,‹‹ù û
$str‹‹ü §
,‹‹§ •
$str‹‹¶ ≤
,‹‹≤ ≥
null‹‹¥ ∏
,‹‹∏ π
new‹‹∫ Ω
DateTime‹‹æ ∆
(‹‹∆ «
$num‹‹« »
,‹‹» …
$num‹‹  À
,‹‹À Ã
$num‹‹Õ Œ
,‹‹Œ œ
$num‹‹– —
,‹‹— “
$num‹‹” ‘
,‹‹‘ ’
$num‹‹÷ ◊
,‹‹◊ ÿ
$num‹‹Ÿ ⁄
,‹‹⁄ €
DateTimeKind‹‹‹ Ë
.‹‹Ë È
Unspecified‹‹È Ù
)‹‹Ù ı
}‹‹ˆ ˜
,‹‹˜ ¯
{
›› 
$num
›› 
,
›› 
null
›› 
,
›› 
new
›› "
DateTime
››# +
(
››+ ,
$num
››, -
,
››- .
$num
››/ 0
,
››0 1
$num
››2 3
,
››3 4
$num
››5 6
,
››6 7
$num
››8 9
,
››9 :
$num
››; <
,
››< =
$num
››> ?
,
››? @
DateTimeKind
››A M
.
››M N
Unspecified
››N Y
)
››Y Z
,
››Z [
null
››\ `
,
››` a
new
››b e
DateTime
››f n
(
››n o
$num
››o p
,
››p q
$num
››r s
,
››s t
$num
››u v
,
››v w
$num
››x y
,
››y z
$num
››{ |
,
››| }
$num
››~ 
,›› Ä
$num››Å Ç
,››Ç É
DateTimeKind››Ñ ê
.››ê ë
Unspecified››ë ú
)››ú ù
,››ù û
$str››ü §
,››§ •
$str››¶ ∑
,››∑ ∏
null››π Ω
,››Ω æ
new››ø ¬
DateTime››√ À
(››À Ã
$num››Ã Õ
,››Õ Œ
$num››œ –
,››– —
$num››“ ”
,››” ‘
$num››’ ÷
,››÷ ◊
$num››ÿ Ÿ
,››Ÿ ⁄
$num››€ ‹
,››‹ ›
$num››ﬁ ﬂ
,››ﬂ ‡
DateTimeKind››· Ì
.››Ì Ó
Unspecified››Ó ˘
)››˘ ˙
}››˚ ¸
,››¸ ˝
{
ﬁﬁ 
$num
ﬁﬁ 
,
ﬁﬁ 
null
ﬁﬁ 
,
ﬁﬁ 
new
ﬁﬁ "
DateTime
ﬁﬁ# +
(
ﬁﬁ+ ,
$num
ﬁﬁ, -
,
ﬁﬁ- .
$num
ﬁﬁ/ 0
,
ﬁﬁ0 1
$num
ﬁﬁ2 3
,
ﬁﬁ3 4
$num
ﬁﬁ5 6
,
ﬁﬁ6 7
$num
ﬁﬁ8 9
,
ﬁﬁ9 :
$num
ﬁﬁ; <
,
ﬁﬁ< =
$num
ﬁﬁ> ?
,
ﬁﬁ? @
DateTimeKind
ﬁﬁA M
.
ﬁﬁM N
Unspecified
ﬁﬁN Y
)
ﬁﬁY Z
,
ﬁﬁZ [
null
ﬁﬁ\ `
,
ﬁﬁ` a
new
ﬁﬁb e
DateTime
ﬁﬁf n
(
ﬁﬁn o
$num
ﬁﬁo p
,
ﬁﬁp q
$num
ﬁﬁr s
,
ﬁﬁs t
$num
ﬁﬁu v
,
ﬁﬁv w
$num
ﬁﬁx y
,
ﬁﬁy z
$num
ﬁﬁ{ |
,
ﬁﬁ| }
$num
ﬁﬁ~ 
,ﬁﬁ Ä
$numﬁﬁÅ Ç
,ﬁﬁÇ É
DateTimeKindﬁﬁÑ ê
.ﬁﬁê ë
Unspecifiedﬁﬁë ú
)ﬁﬁú ù
,ﬁﬁù û
$strﬁﬁü §
,ﬁﬁ§ •
$strﬁﬁ¶ Ø
,ﬁﬁØ ∞
nullﬁﬁ± µ
,ﬁﬁµ ∂
newﬁﬁ∑ ∫
DateTimeﬁﬁª √
(ﬁﬁ√ ƒ
$numﬁﬁƒ ≈
,ﬁﬁ≈ ∆
$numﬁﬁ« »
,ﬁﬁ» …
$numﬁﬁ  À
,ﬁﬁÀ Ã
$numﬁﬁÕ Œ
,ﬁﬁŒ œ
$numﬁﬁ– —
,ﬁﬁ— “
$numﬁﬁ” ‘
,ﬁﬁ‘ ’
$numﬁﬁ÷ ◊
,ﬁﬁ◊ ÿ
DateTimeKindﬁﬁŸ Â
.ﬁﬁÂ Ê
UnspecifiedﬁﬁÊ Ò
)ﬁﬁÒ Ú
}ﬁﬁÛ Ù
,ﬁﬁÙ ı
{
ﬂﬂ 
$num
ﬂﬂ 
,
ﬂﬂ 
null
ﬂﬂ 
,
ﬂﬂ 
new
ﬂﬂ "
DateTime
ﬂﬂ# +
(
ﬂﬂ+ ,
$num
ﬂﬂ, -
,
ﬂﬂ- .
$num
ﬂﬂ/ 0
,
ﬂﬂ0 1
$num
ﬂﬂ2 3
,
ﬂﬂ3 4
$num
ﬂﬂ5 6
,
ﬂﬂ6 7
$num
ﬂﬂ8 9
,
ﬂﬂ9 :
$num
ﬂﬂ; <
,
ﬂﬂ< =
$num
ﬂﬂ> ?
,
ﬂﬂ? @
DateTimeKind
ﬂﬂA M
.
ﬂﬂM N
Unspecified
ﬂﬂN Y
)
ﬂﬂY Z
,
ﬂﬂZ [
null
ﬂﬂ\ `
,
ﬂﬂ` a
new
ﬂﬂb e
DateTime
ﬂﬂf n
(
ﬂﬂn o
$num
ﬂﬂo p
,
ﬂﬂp q
$num
ﬂﬂr s
,
ﬂﬂs t
$num
ﬂﬂu v
,
ﬂﬂv w
$num
ﬂﬂx y
,
ﬂﬂy z
$num
ﬂﬂ{ |
,
ﬂﬂ| }
$num
ﬂﬂ~ 
,ﬂﬂ Ä
$numﬂﬂÅ Ç
,ﬂﬂÇ É
DateTimeKindﬂﬂÑ ê
.ﬂﬂê ë
Unspecifiedﬂﬂë ú
)ﬂﬂú ù
,ﬂﬂù û
$strﬂﬂü §
,ﬂﬂ§ •
$strﬂﬂ¶ ≤
,ﬂﬂ≤ ≥
nullﬂﬂ¥ ∏
,ﬂﬂ∏ π
newﬂﬂ∫ Ω
DateTimeﬂﬂæ ∆
(ﬂﬂ∆ «
$numﬂﬂ« »
,ﬂﬂ» …
$numﬂﬂ  À
,ﬂﬂÀ Ã
$numﬂﬂÕ Œ
,ﬂﬂŒ œ
$numﬂﬂ– —
,ﬂﬂ— “
$numﬂﬂ” ‘
,ﬂﬂ‘ ’
$numﬂﬂ÷ ◊
,ﬂﬂ◊ ÿ
$numﬂﬂŸ ⁄
,ﬂﬂ⁄ €
DateTimeKindﬂﬂ‹ Ë
.ﬂﬂË È
UnspecifiedﬂﬂÈ Ù
)ﬂﬂÙ ı
}ﬂﬂˆ ˜
,ﬂﬂ˜ ¯
{
‡‡ 
$num
‡‡ 
,
‡‡ 
null
‡‡ 
,
‡‡ 
new
‡‡  #
DateTime
‡‡$ ,
(
‡‡, -
$num
‡‡- .
,
‡‡. /
$num
‡‡0 1
,
‡‡1 2
$num
‡‡3 4
,
‡‡4 5
$num
‡‡6 7
,
‡‡7 8
$num
‡‡9 :
,
‡‡: ;
$num
‡‡< =
,
‡‡= >
$num
‡‡? @
,
‡‡@ A
DateTimeKind
‡‡B N
.
‡‡N O
Unspecified
‡‡O Z
)
‡‡Z [
,
‡‡[ \
null
‡‡] a
,
‡‡a b
new
‡‡c f
DateTime
‡‡g o
(
‡‡o p
$num
‡‡p q
,
‡‡q r
$num
‡‡s t
,
‡‡t u
$num
‡‡v w
,
‡‡w x
$num
‡‡y z
,
‡‡z {
$num
‡‡| }
,
‡‡} ~
$num‡‡ Ä
,‡‡Ä Å
$num‡‡Ç É
,‡‡É Ñ
DateTimeKind‡‡Ö ë
.‡‡ë í
Unspecified‡‡í ù
)‡‡ù û
,‡‡û ü
$str‡‡† •
,‡‡• ¶
$str‡‡ß ±
,‡‡± ≤
null‡‡≥ ∑
,‡‡∑ ∏
new‡‡π º
DateTime‡‡Ω ≈
(‡‡≈ ∆
$num‡‡∆ «
,‡‡« »
$num‡‡…  
,‡‡  À
$num‡‡Ã Õ
,‡‡Õ Œ
$num‡‡œ –
,‡‡– —
$num‡‡“ ”
,‡‡” ‘
$num‡‡’ ÷
,‡‡÷ ◊
$num‡‡ÿ Ÿ
,‡‡Ÿ ⁄
DateTimeKind‡‡€ Á
.‡‡Á Ë
Unspecified‡‡Ë Û
)‡‡Û Ù
}‡‡ı ˆ
,‡‡ˆ ˜
{
·· 
$num
·· 
,
·· 
null
·· 
,
·· 
new
··  #
DateTime
··$ ,
(
··, -
$num
··- .
,
··. /
$num
··0 1
,
··1 2
$num
··3 4
,
··4 5
$num
··6 7
,
··7 8
$num
··9 :
,
··: ;
$num
··< =
,
··= >
$num
··? @
,
··@ A
DateTimeKind
··B N
.
··N O
Unspecified
··O Z
)
··Z [
,
··[ \
null
··] a
,
··a b
new
··c f
DateTime
··g o
(
··o p
$num
··p q
,
··q r
$num
··s t
,
··t u
$num
··v w
,
··w x
$num
··y z
,
··z {
$num
··| }
,
··} ~
$num·· Ä
,··Ä Å
$num··Ç É
,··É Ñ
DateTimeKind··Ö ë
.··ë í
Unspecified··í ù
)··ù û
,··û ü
$str··† •
,··• ¶
$str··ß ∂
,··∂ ∑
null··∏ º
,··º Ω
new··æ ¡
DateTime··¬  
(··  À
$num··À Ã
,··Ã Õ
$num··Œ œ
,··œ –
$num··— “
,··“ ”
$num··‘ ’
,··’ ÷
$num··◊ ÿ
,··ÿ Ÿ
$num··⁄ €
,··€ ‹
$num··› ﬁ
,··ﬁ ﬂ
DateTimeKind··‡ Ï
.··Ï Ì
Unspecified··Ì ¯
)··¯ ˘
}··˙ ˚
,··˚ ¸
{
‚‚ 
$num
‚‚ 
,
‚‚ 
null
‚‚ 
,
‚‚ 
new
‚‚  #
DateTime
‚‚$ ,
(
‚‚, -
$num
‚‚- .
,
‚‚. /
$num
‚‚0 1
,
‚‚1 2
$num
‚‚3 4
,
‚‚4 5
$num
‚‚6 7
,
‚‚7 8
$num
‚‚9 :
,
‚‚: ;
$num
‚‚< =
,
‚‚= >
$num
‚‚? @
,
‚‚@ A
DateTimeKind
‚‚B N
.
‚‚N O
Unspecified
‚‚O Z
)
‚‚Z [
,
‚‚[ \
null
‚‚] a
,
‚‚a b
new
‚‚c f
DateTime
‚‚g o
(
‚‚o p
$num
‚‚p q
,
‚‚q r
$num
‚‚s t
,
‚‚t u
$num
‚‚v w
,
‚‚w x
$num
‚‚y z
,
‚‚z {
$num
‚‚| }
,
‚‚} ~
$num‚‚ Ä
,‚‚Ä Å
$num‚‚Ç É
,‚‚É Ñ
DateTimeKind‚‚Ö ë
.‚‚ë í
Unspecified‚‚í ù
)‚‚ù û
,‚‚û ü
$str‚‚† •
,‚‚• ¶
$str‚‚ß µ
,‚‚µ ∂
null‚‚∑ ª
,‚‚ª º
new‚‚Ω ¿
DateTime‚‚¡ …
(‚‚…  
$num‚‚  À
,‚‚À Ã
$num‚‚Õ Œ
,‚‚Œ œ
$num‚‚– —
,‚‚— “
$num‚‚” ‘
,‚‚‘ ’
$num‚‚÷ ◊
,‚‚◊ ÿ
$num‚‚Ÿ ⁄
,‚‚⁄ €
$num‚‚‹ ›
,‚‚› ﬁ
DateTimeKind‚‚ﬂ Î
.‚‚Î Ï
Unspecified‚‚Ï ˜
)‚‚˜ ¯
}‚‚˘ ˙
}
„„ 
)
„„ 
;
„„ 
migrationBuilder
ÂÂ 
.
ÂÂ 

InsertData
ÂÂ '
(
ÂÂ' (
schema
ÊÊ 
:
ÊÊ 
$str
ÊÊ 
,
ÊÊ 
table
ÁÁ 
:
ÁÁ 
$str
ÁÁ $
,
ÁÁ$ %
columns
ËË 
:
ËË 
new
ËË 
[
ËË 
]
ËË 
{
ËË  
$str
ËË! 0
,
ËË0 1
$str
ËË2 =
,
ËË= >
$str
ËË? J
,
ËËJ K
$str
ËËL W
,
ËËW X
$str
ËËY d
,
ËËd e
$str
ËËf q
,
ËËq r
$strËËs á
,ËËá à
$strËËâ ö
,ËËö õ
$strËËú ®
,ËË® ©
$strËË™ ∂
}ËË∑ ∏
,ËË∏ π
values
ÈÈ 
:
ÈÈ 
new
ÈÈ 
object
ÈÈ "
[
ÈÈ" #
,
ÈÈ# $
]
ÈÈ$ %
{
ÍÍ 
{
ÎÎ 
$num
ÎÎ 
,
ÎÎ 
null
ÎÎ 
,
ÎÎ 
new
ÎÎ "
DateTime
ÎÎ# +
(
ÎÎ+ ,
$num
ÎÎ, -
,
ÎÎ- .
$num
ÎÎ/ 0
,
ÎÎ0 1
$num
ÎÎ2 3
,
ÎÎ3 4
$num
ÎÎ5 6
,
ÎÎ6 7
$num
ÎÎ8 9
,
ÎÎ9 :
$num
ÎÎ; <
,
ÎÎ< =
$num
ÎÎ> ?
,
ÎÎ? @
DateTimeKind
ÎÎA M
.
ÎÎM N
Unspecified
ÎÎN Y
)
ÎÎY Z
,
ÎÎZ [
null
ÎÎ\ `
,
ÎÎ` a
new
ÎÎb e
DateTime
ÎÎf n
(
ÎÎn o
$num
ÎÎo p
,
ÎÎp q
$num
ÎÎr s
,
ÎÎs t
$num
ÎÎu v
,
ÎÎv w
$num
ÎÎx y
,
ÎÎy z
$num
ÎÎ{ |
,
ÎÎ| }
$num
ÎÎ~ 
,ÎÎ Ä
$numÎÎÅ Ç
,ÎÎÇ É
DateTimeKindÎÎÑ ê
.ÎÎê ë
UnspecifiedÎÎë ú
)ÎÎú ù
,ÎÎù û
$numÎÎü †
,ÎÎ† °
$strÎÎ¢ §
,ÎÎ§ •
$strÎÎ¶ æ
,ÎÎæ ø
nullÎÎ¿ ƒ
,ÎÎƒ ≈
newÎÎ∆ …
DateTimeÎÎ  “
(ÎÎ“ ”
$numÎÎ” ‘
,ÎÎ‘ ’
$numÎÎ÷ ◊
,ÎÎ◊ ÿ
$numÎÎŸ ⁄
,ÎÎ⁄ €
$numÎÎ‹ ›
,ÎÎ› ﬁ
$numÎÎﬂ ‡
,ÎÎ‡ ·
$numÎÎ‚ „
,ÎÎ„ ‰
$numÎÎÂ Ê
,ÎÎÊ Á
DateTimeKindÎÎË Ù
.ÎÎÙ ı
UnspecifiedÎÎı Ä
)ÎÎÄ Å
}ÎÎÇ É
,ÎÎÉ Ñ
{
ÏÏ 
$num
ÏÏ 
,
ÏÏ 
null
ÏÏ 
,
ÏÏ 
new
ÏÏ "
DateTime
ÏÏ# +
(
ÏÏ+ ,
$num
ÏÏ, -
,
ÏÏ- .
$num
ÏÏ/ 0
,
ÏÏ0 1
$num
ÏÏ2 3
,
ÏÏ3 4
$num
ÏÏ5 6
,
ÏÏ6 7
$num
ÏÏ8 9
,
ÏÏ9 :
$num
ÏÏ; <
,
ÏÏ< =
$num
ÏÏ> ?
,
ÏÏ? @
DateTimeKind
ÏÏA M
.
ÏÏM N
Unspecified
ÏÏN Y
)
ÏÏY Z
,
ÏÏZ [
null
ÏÏ\ `
,
ÏÏ` a
new
ÏÏb e
DateTime
ÏÏf n
(
ÏÏn o
$num
ÏÏo p
,
ÏÏp q
$num
ÏÏr s
,
ÏÏs t
$num
ÏÏu v
,
ÏÏv w
$num
ÏÏx y
,
ÏÏy z
$num
ÏÏ{ |
,
ÏÏ| }
$num
ÏÏ~ 
,ÏÏ Ä
$numÏÏÅ Ç
,ÏÏÇ É
DateTimeKindÏÏÑ ê
.ÏÏê ë
UnspecifiedÏÏë ú
)ÏÏú ù
,ÏÏù û
$numÏÏü †
,ÏÏ† °
$strÏÏ¢ §
,ÏÏ§ •
$strÏÏ¶ ª
,ÏÏª º
nullÏÏΩ ¡
,ÏÏ¡ ¬
newÏÏ√ ∆
DateTimeÏÏ« œ
(ÏÏœ –
$numÏÏ– —
,ÏÏ— “
$numÏÏ” ‘
,ÏÏ‘ ’
$numÏÏ÷ ◊
,ÏÏ◊ ÿ
$numÏÏŸ ⁄
,ÏÏ⁄ €
$numÏÏ‹ ›
,ÏÏ› ﬁ
$numÏÏﬂ ‡
,ÏÏ‡ ·
$numÏÏ‚ „
,ÏÏ„ ‰
DateTimeKindÏÏÂ Ò
.ÏÏÒ Ú
UnspecifiedÏÏÚ ˝
)ÏÏ˝ ˛
}ÏÏˇ Ä
,ÏÏÄ Å
{
ÌÌ 
$num
ÌÌ 
,
ÌÌ 
null
ÌÌ 
,
ÌÌ 
new
ÌÌ "
DateTime
ÌÌ# +
(
ÌÌ+ ,
$num
ÌÌ, -
,
ÌÌ- .
$num
ÌÌ/ 0
,
ÌÌ0 1
$num
ÌÌ2 3
,
ÌÌ3 4
$num
ÌÌ5 6
,
ÌÌ6 7
$num
ÌÌ8 9
,
ÌÌ9 :
$num
ÌÌ; <
,
ÌÌ< =
$num
ÌÌ> ?
,
ÌÌ? @
DateTimeKind
ÌÌA M
.
ÌÌM N
Unspecified
ÌÌN Y
)
ÌÌY Z
,
ÌÌZ [
null
ÌÌ\ `
,
ÌÌ` a
new
ÌÌb e
DateTime
ÌÌf n
(
ÌÌn o
$num
ÌÌo p
,
ÌÌp q
$num
ÌÌr s
,
ÌÌs t
$num
ÌÌu v
,
ÌÌv w
$num
ÌÌx y
,
ÌÌy z
$num
ÌÌ{ |
,
ÌÌ| }
$num
ÌÌ~ 
,ÌÌ Ä
$numÌÌÅ Ç
,ÌÌÇ É
DateTimeKindÌÌÑ ê
.ÌÌê ë
UnspecifiedÌÌë ú
)ÌÌú ù
,ÌÌù û
$numÌÌü †
,ÌÌ† °
$strÌÌ¢ §
,ÌÌ§ •
$strÌÌ¶ ≤
,ÌÌ≤ ≥
nullÌÌ¥ ∏
,ÌÌ∏ π
newÌÌ∫ Ω
DateTimeÌÌæ ∆
(ÌÌ∆ «
$numÌÌ« »
,ÌÌ» …
$numÌÌ  À
,ÌÌÀ Ã
$numÌÌÕ Œ
,ÌÌŒ œ
$numÌÌ– —
,ÌÌ— “
$numÌÌ” ‘
,ÌÌ‘ ’
$numÌÌ÷ ◊
,ÌÌ◊ ÿ
$numÌÌŸ ⁄
,ÌÌ⁄ €
DateTimeKindÌÌ‹ Ë
.ÌÌË È
UnspecifiedÌÌÈ Ù
)ÌÌÙ ı
}ÌÌˆ ˜
,ÌÌ˜ ¯
{
ÓÓ 
$num
ÓÓ 
,
ÓÓ 
null
ÓÓ 
,
ÓÓ 
new
ÓÓ "
DateTime
ÓÓ# +
(
ÓÓ+ ,
$num
ÓÓ, -
,
ÓÓ- .
$num
ÓÓ/ 0
,
ÓÓ0 1
$num
ÓÓ2 3
,
ÓÓ3 4
$num
ÓÓ5 6
,
ÓÓ6 7
$num
ÓÓ8 9
,
ÓÓ9 :
$num
ÓÓ; <
,
ÓÓ< =
$num
ÓÓ> ?
,
ÓÓ? @
DateTimeKind
ÓÓA M
.
ÓÓM N
Unspecified
ÓÓN Y
)
ÓÓY Z
,
ÓÓZ [
null
ÓÓ\ `
,
ÓÓ` a
new
ÓÓb e
DateTime
ÓÓf n
(
ÓÓn o
$num
ÓÓo p
,
ÓÓp q
$num
ÓÓr s
,
ÓÓs t
$num
ÓÓu v
,
ÓÓv w
$num
ÓÓx y
,
ÓÓy z
$num
ÓÓ{ |
,
ÓÓ| }
$num
ÓÓ~ 
,ÓÓ Ä
$numÓÓÅ Ç
,ÓÓÇ É
DateTimeKindÓÓÑ ê
.ÓÓê ë
UnspecifiedÓÓë ú
)ÓÓú ù
,ÓÓù û
$numÓÓü †
,ÓÓ† °
$strÓÓ¢ §
,ÓÓ§ •
$strÓÓ¶ √
,ÓÓ√ ƒ
nullÓÓ≈ …
,ÓÓ…  
newÓÓÀ Œ
DateTimeÓÓœ ◊
(ÓÓ◊ ÿ
$numÓÓÿ Ÿ
,ÓÓŸ ⁄
$numÓÓ€ ‹
,ÓÓ‹ ›
$numÓÓﬁ ﬂ
,ÓÓﬂ ‡
$numÓÓ· ‚
,ÓÓ‚ „
$numÓÓ‰ Â
,ÓÓÂ Ê
$numÓÓÁ Ë
,ÓÓË È
$numÓÓÍ Î
,ÓÓÎ Ï
DateTimeKindÓÓÌ ˘
.ÓÓ˘ ˙
UnspecifiedÓÓ˙ Ö
)ÓÓÖ Ü
}ÓÓá à
,ÓÓà â
{
ÔÔ 
$num
ÔÔ 
,
ÔÔ 
null
ÔÔ 
,
ÔÔ 
new
ÔÔ "
DateTime
ÔÔ# +
(
ÔÔ+ ,
$num
ÔÔ, -
,
ÔÔ- .
$num
ÔÔ/ 0
,
ÔÔ0 1
$num
ÔÔ2 3
,
ÔÔ3 4
$num
ÔÔ5 6
,
ÔÔ6 7
$num
ÔÔ8 9
,
ÔÔ9 :
$num
ÔÔ; <
,
ÔÔ< =
$num
ÔÔ> ?
,
ÔÔ? @
DateTimeKind
ÔÔA M
.
ÔÔM N
Unspecified
ÔÔN Y
)
ÔÔY Z
,
ÔÔZ [
null
ÔÔ\ `
,
ÔÔ` a
new
ÔÔb e
DateTime
ÔÔf n
(
ÔÔn o
$num
ÔÔo p
,
ÔÔp q
$num
ÔÔr s
,
ÔÔs t
$num
ÔÔu v
,
ÔÔv w
$num
ÔÔx y
,
ÔÔy z
$num
ÔÔ{ |
,
ÔÔ| }
$num
ÔÔ~ 
,ÔÔ Ä
$numÔÔÅ Ç
,ÔÔÇ É
DateTimeKindÔÔÑ ê
.ÔÔê ë
UnspecifiedÔÔë ú
)ÔÔú ù
,ÔÔù û
$numÔÔü †
,ÔÔ† °
$strÔÔ¢ ß
,ÔÔß ®
$strÔÔ© ∫
,ÔÔ∫ ª
nullÔÔº ¿
,ÔÔ¿ ¡
newÔÔ¬ ≈
DateTimeÔÔ∆ Œ
(ÔÔŒ œ
$numÔÔœ –
,ÔÔ– —
$numÔÔ“ ”
,ÔÔ” ‘
$numÔÔ’ ÷
,ÔÔ÷ ◊
$numÔÔÿ Ÿ
,ÔÔŸ ⁄
$numÔÔ€ ‹
,ÔÔ‹ ›
$numÔÔﬁ ﬂ
,ÔÔﬂ ‡
$numÔÔ· ‚
,ÔÔ‚ „
DateTimeKindÔÔ‰ 
.ÔÔ Ò
UnspecifiedÔÔÒ ¸
)ÔÔ¸ ˝
}ÔÔ˛ ˇ
,ÔÔˇ Ä
{
 
$num
 
,
 
null
 
,
 
new
 "
DateTime
# +
(
+ ,
$num
, -
,
- .
$num
/ 0
,
0 1
$num
2 3
,
3 4
$num
5 6
,
6 7
$num
8 9
,
9 :
$num
; <
,
< =
$num
> ?
,
? @
DateTimeKind
A M
.
M N
Unspecified
N Y
)
Y Z
,
Z [
null
\ `
,
` a
new
b e
DateTime
f n
(
n o
$num
o p
,
p q
$num
r s
,
s t
$num
u v
,
v w
$num
x y
,
y z
$num
{ |
,
| }
$num
~ 
, Ä
$numÅ Ç
,Ç É
DateTimeKindÑ ê
.ê ë
Unspecifiedë ú
)ú ù
,ù û
$numü †
,† °
$str¢ ß
,ß ®
$str© º
,º Ω
nullæ ¬
,¬ √
newƒ «
DateTime» –
(– —
$num— “
,“ ”
$num‘ ’
,’ ÷
$num◊ ÿ
,ÿ Ÿ
$num⁄ €
,€ ‹
$num› ﬁ
,ﬁ ﬂ
$num‡ ·
,· ‚
$num„ ‰
,‰ Â
DateTimeKindÊ Ú
.Ú Û
UnspecifiedÛ ˛
)˛ ˇ
}Ä Å
,Å Ç
{
ÒÒ 
$num
ÒÒ 
,
ÒÒ 
null
ÒÒ 
,
ÒÒ 
new
ÒÒ "
DateTime
ÒÒ# +
(
ÒÒ+ ,
$num
ÒÒ, -
,
ÒÒ- .
$num
ÒÒ/ 0
,
ÒÒ0 1
$num
ÒÒ2 3
,
ÒÒ3 4
$num
ÒÒ5 6
,
ÒÒ6 7
$num
ÒÒ8 9
,
ÒÒ9 :
$num
ÒÒ; <
,
ÒÒ< =
$num
ÒÒ> ?
,
ÒÒ? @
DateTimeKind
ÒÒA M
.
ÒÒM N
Unspecified
ÒÒN Y
)
ÒÒY Z
,
ÒÒZ [
null
ÒÒ\ `
,
ÒÒ` a
new
ÒÒb e
DateTime
ÒÒf n
(
ÒÒn o
$num
ÒÒo p
,
ÒÒp q
$num
ÒÒr s
,
ÒÒs t
$num
ÒÒu v
,
ÒÒv w
$num
ÒÒx y
,
ÒÒy z
$num
ÒÒ{ |
,
ÒÒ| }
$num
ÒÒ~ 
,ÒÒ Ä
$numÒÒÅ Ç
,ÒÒÇ É
DateTimeKindÒÒÑ ê
.ÒÒê ë
UnspecifiedÒÒë ú
)ÒÒú ù
,ÒÒù û
$numÒÒü †
,ÒÒ† °
$strÒÒ¢ ß
,ÒÒß ®
$strÒÒ© ø
,ÒÒø ¿
nullÒÒ¡ ≈
,ÒÒ≈ ∆
newÒÒ«  
DateTimeÒÒÀ ”
(ÒÒ” ‘
$numÒÒ‘ ’
,ÒÒ’ ÷
$numÒÒ◊ ÿ
,ÒÒÿ Ÿ
$numÒÒ⁄ €
,ÒÒ€ ‹
$numÒÒ› ﬁ
,ÒÒﬁ ﬂ
$numÒÒ‡ ·
,ÒÒ· ‚
$numÒÒ„ ‰
,ÒÒ‰ Â
$numÒÒÊ Á
,ÒÒÁ Ë
DateTimeKindÒÒÈ ı
.ÒÒı ˆ
UnspecifiedÒÒˆ Å
)ÒÒÅ Ç
}ÒÒÉ Ñ
,ÒÒÑ Ö
{
ÚÚ 
$num
ÚÚ 
,
ÚÚ 
null
ÚÚ 
,
ÚÚ 
new
ÚÚ "
DateTime
ÚÚ# +
(
ÚÚ+ ,
$num
ÚÚ, -
,
ÚÚ- .
$num
ÚÚ/ 0
,
ÚÚ0 1
$num
ÚÚ2 3
,
ÚÚ3 4
$num
ÚÚ5 6
,
ÚÚ6 7
$num
ÚÚ8 9
,
ÚÚ9 :
$num
ÚÚ; <
,
ÚÚ< =
$num
ÚÚ> ?
,
ÚÚ? @
DateTimeKind
ÚÚA M
.
ÚÚM N
Unspecified
ÚÚN Y
)
ÚÚY Z
,
ÚÚZ [
null
ÚÚ\ `
,
ÚÚ` a
new
ÚÚb e
DateTime
ÚÚf n
(
ÚÚn o
$num
ÚÚo p
,
ÚÚp q
$num
ÚÚr s
,
ÚÚs t
$num
ÚÚu v
,
ÚÚv w
$num
ÚÚx y
,
ÚÚy z
$num
ÚÚ{ |
,
ÚÚ| }
$num
ÚÚ~ 
,ÚÚ Ä
$numÚÚÅ Ç
,ÚÚÇ É
DateTimeKindÚÚÑ ê
.ÚÚê ë
UnspecifiedÚÚë ú
)ÚÚú ù
,ÚÚù û
$numÚÚü †
,ÚÚ† °
$strÚÚ¢ ß
,ÚÚß ®
$strÚÚ© ¡
,ÚÚ¡ ¬
nullÚÚ√ «
,ÚÚ« »
newÚÚ… Ã
DateTimeÚÚÕ ’
(ÚÚ’ ÷
$numÚÚ÷ ◊
,ÚÚ◊ ÿ
$numÚÚŸ ⁄
,ÚÚ⁄ €
$numÚÚ‹ ›
,ÚÚ› ﬁ
$numÚÚﬂ ‡
,ÚÚ‡ ·
$numÚÚ‚ „
,ÚÚ„ ‰
$numÚÚÂ Ê
,ÚÚÊ Á
$numÚÚË È
,ÚÚÈ Í
DateTimeKindÚÚÎ ˜
.ÚÚ˜ ¯
UnspecifiedÚÚ¯ É
)ÚÚÉ Ñ
}ÚÚÖ Ü
,ÚÚÜ á
{
ÛÛ 
$num
ÛÛ 
,
ÛÛ 
null
ÛÛ 
,
ÛÛ 
new
ÛÛ "
DateTime
ÛÛ# +
(
ÛÛ+ ,
$num
ÛÛ, -
,
ÛÛ- .
$num
ÛÛ/ 0
,
ÛÛ0 1
$num
ÛÛ2 3
,
ÛÛ3 4
$num
ÛÛ5 6
,
ÛÛ6 7
$num
ÛÛ8 9
,
ÛÛ9 :
$num
ÛÛ; <
,
ÛÛ< =
$num
ÛÛ> ?
,
ÛÛ? @
DateTimeKind
ÛÛA M
.
ÛÛM N
Unspecified
ÛÛN Y
)
ÛÛY Z
,
ÛÛZ [
null
ÛÛ\ `
,
ÛÛ` a
new
ÛÛb e
DateTime
ÛÛf n
(
ÛÛn o
$num
ÛÛo p
,
ÛÛp q
$num
ÛÛr s
,
ÛÛs t
$num
ÛÛu v
,
ÛÛv w
$num
ÛÛx y
,
ÛÛy z
$num
ÛÛ{ |
,
ÛÛ| }
$num
ÛÛ~ 
,ÛÛ Ä
$numÛÛÅ Ç
,ÛÛÇ É
DateTimeKindÛÛÑ ê
.ÛÛê ë
UnspecifiedÛÛë ú
)ÛÛú ù
,ÛÛù û
$numÛÛü †
,ÛÛ† °
$strÛÛ¢ ß
,ÛÛß ®
$strÛÛ© ∏
,ÛÛ∏ π
nullÛÛ∫ æ
,ÛÛæ ø
newÛÛ¿ √
DateTimeÛÛƒ Ã
(ÛÛÃ Õ
$numÛÛÕ Œ
,ÛÛŒ œ
$numÛÛ– —
,ÛÛ— “
$numÛÛ” ‘
,ÛÛ‘ ’
$numÛÛ÷ ◊
,ÛÛ◊ ÿ
$numÛÛŸ ⁄
,ÛÛ⁄ €
$numÛÛ‹ ›
,ÛÛ› ﬁ
$numÛÛﬂ ‡
,ÛÛ‡ ·
DateTimeKindÛÛ‚ Ó
.ÛÛÓ Ô
UnspecifiedÛÛÔ ˙
)ÛÛ˙ ˚
}ÛÛ¸ ˝
,ÛÛ˝ ˛
{
ÙÙ 
$num
ÙÙ 
,
ÙÙ 
null
ÙÙ 
,
ÙÙ 
new
ÙÙ  #
DateTime
ÙÙ$ ,
(
ÙÙ, -
$num
ÙÙ- .
,
ÙÙ. /
$num
ÙÙ0 1
,
ÙÙ1 2
$num
ÙÙ3 4
,
ÙÙ4 5
$num
ÙÙ6 7
,
ÙÙ7 8
$num
ÙÙ9 :
,
ÙÙ: ;
$num
ÙÙ< =
,
ÙÙ= >
$num
ÙÙ? @
,
ÙÙ@ A
DateTimeKind
ÙÙB N
.
ÙÙN O
Unspecified
ÙÙO Z
)
ÙÙZ [
,
ÙÙ[ \
null
ÙÙ] a
,
ÙÙa b
new
ÙÙc f
DateTime
ÙÙg o
(
ÙÙo p
$num
ÙÙp q
,
ÙÙq r
$num
ÙÙs t
,
ÙÙt u
$num
ÙÙv w
,
ÙÙw x
$num
ÙÙy z
,
ÙÙz {
$num
ÙÙ| }
,
ÙÙ} ~
$numÙÙ Ä
,ÙÙÄ Å
$numÙÙÇ É
,ÙÙÉ Ñ
DateTimeKindÙÙÖ ë
.ÙÙë í
UnspecifiedÙÙí ù
)ÙÙù û
,ÙÙû ü
$numÙÙ† °
,ÙÙ° ¢
$strÙÙ£ ®
,ÙÙ® ©
$strÙÙ™ ∑
,ÙÙ∑ ∏
nullÙÙπ Ω
,ÙÙΩ æ
newÙÙø ¬
DateTimeÙÙ√ À
(ÙÙÀ Ã
$numÙÙÃ Õ
,ÙÙÕ Œ
$numÙÙœ –
,ÙÙ– —
$numÙÙ“ ”
,ÙÙ” ‘
$numÙÙ’ ÷
,ÙÙ÷ ◊
$numÙÙÿ Ÿ
,ÙÙŸ ⁄
$numÙÙ€ ‹
,ÙÙ‹ ›
$numÙÙﬁ ﬂ
,ÙÙﬂ ‡
DateTimeKindÙÙ· Ì
.ÙÙÌ Ó
UnspecifiedÙÙÓ ˘
)ÙÙ˘ ˙
}ÙÙ˚ ¸
,ÙÙ¸ ˝
{
ıı 
$num
ıı 
,
ıı 
null
ıı 
,
ıı 
new
ıı  #
DateTime
ıı$ ,
(
ıı, -
$num
ıı- .
,
ıı. /
$num
ıı0 1
,
ıı1 2
$num
ıı3 4
,
ıı4 5
$num
ıı6 7
,
ıı7 8
$num
ıı9 :
,
ıı: ;
$num
ıı< =
,
ıı= >
$num
ıı? @
,
ıı@ A
DateTimeKind
ııB N
.
ııN O
Unspecified
ııO Z
)
ııZ [
,
ıı[ \
null
ıı] a
,
ııa b
new
ııc f
DateTime
ııg o
(
ııo p
$num
ııp q
,
ııq r
$num
ııs t
,
ııt u
$num
ııv w
,
ııw x
$num
ııy z
,
ıız {
$num
ıı| }
,
ıı} ~
$numıı Ä
,ııÄ Å
$numııÇ É
,ııÉ Ñ
DateTimeKindııÖ ë
.ııë í
Unspecifiedııí ù
)ııù û
,ııû ü
$numıı† °
,ıı° ¢
$strıı£ ®
,ıı® ©
$strıı™ ∑
,ıı∑ ∏
nullııπ Ω
,ııΩ æ
newııø ¬
DateTimeıı√ À
(ııÀ Ã
$numııÃ Õ
,ııÕ Œ
$numııœ –
,ıı– —
$numıı“ ”
,ıı” ‘
$numıı’ ÷
,ıı÷ ◊
$numııÿ Ÿ
,ııŸ ⁄
$numıı€ ‹
,ıı‹ ›
$numııﬁ ﬂ
,ııﬂ ‡
DateTimeKindıı· Ì
.ııÌ Ó
UnspecifiedııÓ ˘
)ıı˘ ˙
}ıı˚ ¸
,ıı¸ ˝
{
ˆˆ 
$num
ˆˆ 
,
ˆˆ 
null
ˆˆ 
,
ˆˆ 
new
ˆˆ  #
DateTime
ˆˆ$ ,
(
ˆˆ, -
$num
ˆˆ- .
,
ˆˆ. /
$num
ˆˆ0 1
,
ˆˆ1 2
$num
ˆˆ3 4
,
ˆˆ4 5
$num
ˆˆ6 7
,
ˆˆ7 8
$num
ˆˆ9 :
,
ˆˆ: ;
$num
ˆˆ< =
,
ˆˆ= >
$num
ˆˆ? @
,
ˆˆ@ A
DateTimeKind
ˆˆB N
.
ˆˆN O
Unspecified
ˆˆO Z
)
ˆˆZ [
,
ˆˆ[ \
null
ˆˆ] a
,
ˆˆa b
new
ˆˆc f
DateTime
ˆˆg o
(
ˆˆo p
$num
ˆˆp q
,
ˆˆq r
$num
ˆˆs t
,
ˆˆt u
$num
ˆˆv w
,
ˆˆw x
$num
ˆˆy z
,
ˆˆz {
$num
ˆˆ| }
,
ˆˆ} ~
$numˆˆ Ä
,ˆˆÄ Å
$numˆˆÇ É
,ˆˆÉ Ñ
DateTimeKindˆˆÖ ë
.ˆˆë í
Unspecifiedˆˆí ù
)ˆˆù û
,ˆˆû ü
$numˆˆ† °
,ˆˆ° ¢
$strˆˆ£ ®
,ˆˆ® ©
$strˆˆ™ ∫
,ˆˆ∫ ª
nullˆˆº ¿
,ˆˆ¿ ¡
newˆˆ¬ ≈
DateTimeˆˆ∆ Œ
(ˆˆŒ œ
$numˆˆœ –
,ˆˆ– —
$numˆˆ“ ”
,ˆˆ” ‘
$numˆˆ’ ÷
,ˆˆ÷ ◊
$numˆˆÿ Ÿ
,ˆˆŸ ⁄
$numˆˆ€ ‹
,ˆˆ‹ ›
$numˆˆﬁ ﬂ
,ˆˆﬂ ‡
$numˆˆ· ‚
,ˆˆ‚ „
DateTimeKindˆˆ‰ 
.ˆˆ Ò
UnspecifiedˆˆÒ ¸
)ˆˆ¸ ˝
}ˆˆ˛ ˇ
,ˆˆˇ Ä
{
˜˜ 
$num
˜˜ 
,
˜˜ 
null
˜˜ 
,
˜˜ 
new
˜˜  #
DateTime
˜˜$ ,
(
˜˜, -
$num
˜˜- .
,
˜˜. /
$num
˜˜0 1
,
˜˜1 2
$num
˜˜3 4
,
˜˜4 5
$num
˜˜6 7
,
˜˜7 8
$num
˜˜9 :
,
˜˜: ;
$num
˜˜< =
,
˜˜= >
$num
˜˜? @
,
˜˜@ A
DateTimeKind
˜˜B N
.
˜˜N O
Unspecified
˜˜O Z
)
˜˜Z [
,
˜˜[ \
null
˜˜] a
,
˜˜a b
new
˜˜c f
DateTime
˜˜g o
(
˜˜o p
$num
˜˜p q
,
˜˜q r
$num
˜˜s t
,
˜˜t u
$num
˜˜v w
,
˜˜w x
$num
˜˜y z
,
˜˜z {
$num
˜˜| }
,
˜˜} ~
$num˜˜ Ä
,˜˜Ä Å
$num˜˜Ç É
,˜˜É Ñ
DateTimeKind˜˜Ö ë
.˜˜ë í
Unspecified˜˜í ù
)˜˜ù û
,˜˜û ü
$num˜˜† °
,˜˜° ¢
$str˜˜£ ®
,˜˜® ©
$str˜˜™ ≥
,˜˜≥ ¥
null˜˜µ π
,˜˜π ∫
new˜˜ª æ
DateTime˜˜ø «
(˜˜« »
$num˜˜» …
,˜˜…  
$num˜˜À Ã
,˜˜Ã Õ
$num˜˜Œ œ
,˜˜œ –
$num˜˜— “
,˜˜“ ”
$num˜˜‘ ’
,˜˜’ ÷
$num˜˜◊ ÿ
,˜˜ÿ Ÿ
$num˜˜⁄ €
,˜˜€ ‹
DateTimeKind˜˜› È
.˜˜È Í
Unspecified˜˜Í ı
)˜˜ı ˆ
}˜˜˜ ¯
,˜˜¯ ˘
{
¯¯ 
$num
¯¯ 
,
¯¯ 
null
¯¯ 
,
¯¯ 
new
¯¯  #
DateTime
¯¯$ ,
(
¯¯, -
$num
¯¯- .
,
¯¯. /
$num
¯¯0 1
,
¯¯1 2
$num
¯¯3 4
,
¯¯4 5
$num
¯¯6 7
,
¯¯7 8
$num
¯¯9 :
,
¯¯: ;
$num
¯¯< =
,
¯¯= >
$num
¯¯? @
,
¯¯@ A
DateTimeKind
¯¯B N
.
¯¯N O
Unspecified
¯¯O Z
)
¯¯Z [
,
¯¯[ \
null
¯¯] a
,
¯¯a b
new
¯¯c f
DateTime
¯¯g o
(
¯¯o p
$num
¯¯p q
,
¯¯q r
$num
¯¯s t
,
¯¯t u
$num
¯¯v w
,
¯¯w x
$num
¯¯y z
,
¯¯z {
$num
¯¯| }
,
¯¯} ~
$num¯¯ Ä
,¯¯Ä Å
$num¯¯Ç É
,¯¯É Ñ
DateTimeKind¯¯Ö ë
.¯¯ë í
Unspecified¯¯í ù
)¯¯ù û
,¯¯û ü
$num¯¯† °
,¯¯° ¢
$str¯¯£ ®
,¯¯® ©
$str¯¯™ «
,¯¯« »
null¯¯… Õ
,¯¯Õ Œ
new¯¯œ “
DateTime¯¯” €
(¯¯€ ‹
$num¯¯‹ ›
,¯¯› ﬁ
$num¯¯ﬂ ‡
,¯¯‡ ·
$num¯¯‚ „
,¯¯„ ‰
$num¯¯Â Ê
,¯¯Ê Á
$num¯¯Ë È
,¯¯È Í
$num¯¯Î Ï
,¯¯Ï Ì
$num¯¯Ó Ô
,¯¯Ô 
DateTimeKind¯¯Ò ˝
.¯¯˝ ˛
Unspecified¯¯˛ â
)¯¯â ä
}¯¯ã å
,¯¯å ç
{
˘˘ 
$num
˘˘ 
,
˘˘ 
null
˘˘ 
,
˘˘ 
new
˘˘  #
DateTime
˘˘$ ,
(
˘˘, -
$num
˘˘- .
,
˘˘. /
$num
˘˘0 1
,
˘˘1 2
$num
˘˘3 4
,
˘˘4 5
$num
˘˘6 7
,
˘˘7 8
$num
˘˘9 :
,
˘˘: ;
$num
˘˘< =
,
˘˘= >
$num
˘˘? @
,
˘˘@ A
DateTimeKind
˘˘B N
.
˘˘N O
Unspecified
˘˘O Z
)
˘˘Z [
,
˘˘[ \
null
˘˘] a
,
˘˘a b
new
˘˘c f
DateTime
˘˘g o
(
˘˘o p
$num
˘˘p q
,
˘˘q r
$num
˘˘s t
,
˘˘t u
$num
˘˘v w
,
˘˘w x
$num
˘˘y z
,
˘˘z {
$num
˘˘| }
,
˘˘} ~
$num˘˘ Ä
,˘˘Ä Å
$num˘˘Ç É
,˘˘É Ñ
DateTimeKind˘˘Ö ë
.˘˘ë í
Unspecified˘˘í ù
)˘˘ù û
,˘˘û ü
$num˘˘† °
,˘˘° ¢
$str˘˘£ ®
,˘˘® ©
$str˘˘™ «
,˘˘« »
null˘˘… Õ
,˘˘Õ Œ
new˘˘œ “
DateTime˘˘” €
(˘˘€ ‹
$num˘˘‹ ›
,˘˘› ﬁ
$num˘˘ﬂ ‡
,˘˘‡ ·
$num˘˘‚ „
,˘˘„ ‰
$num˘˘Â Ê
,˘˘Ê Á
$num˘˘Ë È
,˘˘È Í
$num˘˘Î Ï
,˘˘Ï Ì
$num˘˘Ó Ô
,˘˘Ô 
DateTimeKind˘˘Ò ˝
.˘˘˝ ˛
Unspecified˘˘˛ â
)˘˘â ä
}˘˘ã å
,˘˘å ç
{
˙˙ 
$num
˙˙ 
,
˙˙ 
null
˙˙ 
,
˙˙ 
new
˙˙  #
DateTime
˙˙$ ,
(
˙˙, -
$num
˙˙- .
,
˙˙. /
$num
˙˙0 1
,
˙˙1 2
$num
˙˙3 4
,
˙˙4 5
$num
˙˙6 7
,
˙˙7 8
$num
˙˙9 :
,
˙˙: ;
$num
˙˙< =
,
˙˙= >
$num
˙˙? @
,
˙˙@ A
DateTimeKind
˙˙B N
.
˙˙N O
Unspecified
˙˙O Z
)
˙˙Z [
,
˙˙[ \
null
˙˙] a
,
˙˙a b
new
˙˙c f
DateTime
˙˙g o
(
˙˙o p
$num
˙˙p q
,
˙˙q r
$num
˙˙s t
,
˙˙t u
$num
˙˙v w
,
˙˙w x
$num
˙˙y z
,
˙˙z {
$num
˙˙| }
,
˙˙} ~
$num˙˙ Ä
,˙˙Ä Å
$num˙˙Ç É
,˙˙É Ñ
DateTimeKind˙˙Ö ë
.˙˙ë í
Unspecified˙˙í ù
)˙˙ù û
,˙˙û ü
$num˙˙† °
,˙˙° ¢
$str˙˙£ ®
,˙˙® ©
$str˙˙™ ∆
,˙˙∆ «
null˙˙» Ã
,˙˙Ã Õ
new˙˙Œ —
DateTime˙˙“ ⁄
(˙˙⁄ €
$num˙˙€ ‹
,˙˙‹ ›
$num˙˙ﬁ ﬂ
,˙˙ﬂ ‡
$num˙˙· ‚
,˙˙‚ „
$num˙˙‰ Â
,˙˙Â Ê
$num˙˙Á Ë
,˙˙Ë È
$num˙˙Í Î
,˙˙Î Ï
$num˙˙Ì Ó
,˙˙Ó Ô
DateTimeKind˙˙ ¸
.˙˙¸ ˝
Unspecified˙˙˝ à
)˙˙à â
}˙˙ä ã
,˙˙ã å
{
˚˚ 
$num
˚˚ 
,
˚˚ 
null
˚˚ 
,
˚˚ 
new
˚˚  #
DateTime
˚˚$ ,
(
˚˚, -
$num
˚˚- .
,
˚˚. /
$num
˚˚0 1
,
˚˚1 2
$num
˚˚3 4
,
˚˚4 5
$num
˚˚6 7
,
˚˚7 8
$num
˚˚9 :
,
˚˚: ;
$num
˚˚< =
,
˚˚= >
$num
˚˚? @
,
˚˚@ A
DateTimeKind
˚˚B N
.
˚˚N O
Unspecified
˚˚O Z
)
˚˚Z [
,
˚˚[ \
null
˚˚] a
,
˚˚a b
new
˚˚c f
DateTime
˚˚g o
(
˚˚o p
$num
˚˚p q
,
˚˚q r
$num
˚˚s t
,
˚˚t u
$num
˚˚v w
,
˚˚w x
$num
˚˚y z
,
˚˚z {
$num
˚˚| }
,
˚˚} ~
$num˚˚ Ä
,˚˚Ä Å
$num˚˚Ç É
,˚˚É Ñ
DateTimeKind˚˚Ö ë
.˚˚ë í
Unspecified˚˚í ù
)˚˚ù û
,˚˚û ü
$num˚˚† °
,˚˚° ¢
$str˚˚£ ®
,˚˚® ©
$str˚˚™ ¥
,˚˚¥ µ
null˚˚∂ ∫
,˚˚∫ ª
new˚˚º ø
DateTime˚˚¿ »
(˚˚» …
$num˚˚…  
,˚˚  À
$num˚˚Ã Õ
,˚˚Õ Œ
$num˚˚œ –
,˚˚– —
$num˚˚“ ”
,˚˚” ‘
$num˚˚’ ÷
,˚˚÷ ◊
$num˚˚ÿ Ÿ
,˚˚Ÿ ⁄
$num˚˚€ ‹
,˚˚‹ ›
DateTimeKind˚˚ﬁ Í
.˚˚Í Î
Unspecified˚˚Î ˆ
)˚˚ˆ ˜
}˚˚¯ ˘
,˚˚˘ ˙
{
¸¸ 
$num
¸¸ 
,
¸¸ 
null
¸¸ 
,
¸¸ 
new
¸¸  #
DateTime
¸¸$ ,
(
¸¸, -
$num
¸¸- .
,
¸¸. /
$num
¸¸0 1
,
¸¸1 2
$num
¸¸3 4
,
¸¸4 5
$num
¸¸6 7
,
¸¸7 8
$num
¸¸9 :
,
¸¸: ;
$num
¸¸< =
,
¸¸= >
$num
¸¸? @
,
¸¸@ A
DateTimeKind
¸¸B N
.
¸¸N O
Unspecified
¸¸O Z
)
¸¸Z [
,
¸¸[ \
null
¸¸] a
,
¸¸a b
new
¸¸c f
DateTime
¸¸g o
(
¸¸o p
$num
¸¸p q
,
¸¸q r
$num
¸¸s t
,
¸¸t u
$num
¸¸v w
,
¸¸w x
$num
¸¸y z
,
¸¸z {
$num
¸¸| }
,
¸¸} ~
$num¸¸ Ä
,¸¸Ä Å
$num¸¸Ç É
,¸¸É Ñ
DateTimeKind¸¸Ö ë
.¸¸ë í
Unspecified¸¸í ù
)¸¸ù û
,¸¸û ü
$num¸¸† ¢
,¸¸¢ £
$str¸¸§ ©
,¸¸© ™
$str¸¸´ ¥
,¸¸¥ µ
null¸¸∂ ∫
,¸¸∫ ª
new¸¸º ø
DateTime¸¸¿ »
(¸¸» …
$num¸¸…  
,¸¸  À
$num¸¸Ã Õ
,¸¸Õ Œ
$num¸¸œ –
,¸¸– —
$num¸¸“ ”
,¸¸” ‘
$num¸¸’ ÷
,¸¸÷ ◊
$num¸¸ÿ Ÿ
,¸¸Ÿ ⁄
$num¸¸€ ‹
,¸¸‹ ›
DateTimeKind¸¸ﬁ Í
.¸¸Í Î
Unspecified¸¸Î ˆ
)¸¸ˆ ˜
}¸¸¯ ˘
,¸¸˘ ˙
{
˝˝ 
$num
˝˝ 
,
˝˝ 
null
˝˝ 
,
˝˝ 
new
˝˝  #
DateTime
˝˝$ ,
(
˝˝, -
$num
˝˝- .
,
˝˝. /
$num
˝˝0 1
,
˝˝1 2
$num
˝˝3 4
,
˝˝4 5
$num
˝˝6 7
,
˝˝7 8
$num
˝˝9 :
,
˝˝: ;
$num
˝˝< =
,
˝˝= >
$num
˝˝? @
,
˝˝@ A
DateTimeKind
˝˝B N
.
˝˝N O
Unspecified
˝˝O Z
)
˝˝Z [
,
˝˝[ \
null
˝˝] a
,
˝˝a b
new
˝˝c f
DateTime
˝˝g o
(
˝˝o p
$num
˝˝p q
,
˝˝q r
$num
˝˝s t
,
˝˝t u
$num
˝˝v w
,
˝˝w x
$num
˝˝y z
,
˝˝z {
$num
˝˝| }
,
˝˝} ~
$num˝˝ Ä
,˝˝Ä Å
$num˝˝Ç É
,˝˝É Ñ
DateTimeKind˝˝Ö ë
.˝˝ë í
Unspecified˝˝í ù
)˝˝ù û
,˝˝û ü
$num˝˝† ¢
,˝˝¢ £
$str˝˝§ ©
,˝˝© ™
$str˝˝´ µ
,˝˝µ ∂
null˝˝∑ ª
,˝˝ª º
new˝˝Ω ¿
DateTime˝˝¡ …
(˝˝…  
$num˝˝  À
,˝˝À Ã
$num˝˝Õ Œ
,˝˝Œ œ
$num˝˝– —
,˝˝— “
$num˝˝” ‘
,˝˝‘ ’
$num˝˝÷ ◊
,˝˝◊ ÿ
$num˝˝Ÿ ⁄
,˝˝⁄ €
$num˝˝‹ ›
,˝˝› ﬁ
DateTimeKind˝˝ﬂ Î
.˝˝Î Ï
Unspecified˝˝Ï ˜
)˝˝˜ ¯
}˝˝˘ ˙
,˝˝˙ ˚
{
˛˛ 
$num
˛˛ 
,
˛˛ 
null
˛˛ 
,
˛˛ 
new
˛˛  #
DateTime
˛˛$ ,
(
˛˛, -
$num
˛˛- .
,
˛˛. /
$num
˛˛0 1
,
˛˛1 2
$num
˛˛3 4
,
˛˛4 5
$num
˛˛6 7
,
˛˛7 8
$num
˛˛9 :
,
˛˛: ;
$num
˛˛< =
,
˛˛= >
$num
˛˛? @
,
˛˛@ A
DateTimeKind
˛˛B N
.
˛˛N O
Unspecified
˛˛O Z
)
˛˛Z [
,
˛˛[ \
null
˛˛] a
,
˛˛a b
new
˛˛c f
DateTime
˛˛g o
(
˛˛o p
$num
˛˛p q
,
˛˛q r
$num
˛˛s t
,
˛˛t u
$num
˛˛v w
,
˛˛w x
$num
˛˛y z
,
˛˛z {
$num
˛˛| }
,
˛˛} ~
$num˛˛ Ä
,˛˛Ä Å
$num˛˛Ç É
,˛˛É Ñ
DateTimeKind˛˛Ö ë
.˛˛ë í
Unspecified˛˛í ù
)˛˛ù û
,˛˛û ü
$num˛˛† ¢
,˛˛¢ £
$str˛˛§ ©
,˛˛© ™
$str˛˛´ ¥
,˛˛¥ µ
null˛˛∂ ∫
,˛˛∫ ª
new˛˛º ø
DateTime˛˛¿ »
(˛˛» …
$num˛˛…  
,˛˛  À
$num˛˛Ã Õ
,˛˛Õ Œ
$num˛˛œ –
,˛˛– —
$num˛˛“ ”
,˛˛” ‘
$num˛˛’ ÷
,˛˛÷ ◊
$num˛˛ÿ Ÿ
,˛˛Ÿ ⁄
$num˛˛€ ‹
,˛˛‹ ›
DateTimeKind˛˛ﬁ Í
.˛˛Í Î
Unspecified˛˛Î ˆ
)˛˛ˆ ˜
}˛˛¯ ˘
,˛˛˘ ˙
{
ˇˇ 
$num
ˇˇ 
,
ˇˇ 
null
ˇˇ 
,
ˇˇ 
new
ˇˇ  #
DateTime
ˇˇ$ ,
(
ˇˇ, -
$num
ˇˇ- .
,
ˇˇ. /
$num
ˇˇ0 1
,
ˇˇ1 2
$num
ˇˇ3 4
,
ˇˇ4 5
$num
ˇˇ6 7
,
ˇˇ7 8
$num
ˇˇ9 :
,
ˇˇ: ;
$num
ˇˇ< =
,
ˇˇ= >
$num
ˇˇ? @
,
ˇˇ@ A
DateTimeKind
ˇˇB N
.
ˇˇN O
Unspecified
ˇˇO Z
)
ˇˇZ [
,
ˇˇ[ \
null
ˇˇ] a
,
ˇˇa b
new
ˇˇc f
DateTime
ˇˇg o
(
ˇˇo p
$num
ˇˇp q
,
ˇˇq r
$num
ˇˇs t
,
ˇˇt u
$num
ˇˇv w
,
ˇˇw x
$num
ˇˇy z
,
ˇˇz {
$num
ˇˇ| }
,
ˇˇ} ~
$numˇˇ Ä
,ˇˇÄ Å
$numˇˇÇ É
,ˇˇÉ Ñ
DateTimeKindˇˇÖ ë
.ˇˇë í
Unspecifiedˇˇí ù
)ˇˇù û
,ˇˇû ü
$numˇˇ† ¢
,ˇˇ¢ £
$strˇˇ§ ©
,ˇˇ© ™
$strˇˇ´ ¥
,ˇˇ¥ µ
nullˇˇ∂ ∫
,ˇˇ∫ ª
newˇˇº ø
DateTimeˇˇ¿ »
(ˇˇ» …
$numˇˇ…  
,ˇˇ  À
$numˇˇÃ Õ
,ˇˇÕ Œ
$numˇˇœ –
,ˇˇ– —
$numˇˇ“ ”
,ˇˇ” ‘
$numˇˇ’ ÷
,ˇˇ÷ ◊
$numˇˇÿ Ÿ
,ˇˇŸ ⁄
$numˇˇ€ ‹
,ˇˇ‹ ›
DateTimeKindˇˇﬁ Í
.ˇˇÍ Î
UnspecifiedˇˇÎ ˆ
)ˇˇˆ ˜
}ˇˇ¯ ˘
,ˇˇ˘ ˙
{
ÄÄ 
$num
ÄÄ 
,
ÄÄ 
null
ÄÄ 
,
ÄÄ 
new
ÄÄ  #
DateTime
ÄÄ$ ,
(
ÄÄ, -
$num
ÄÄ- .
,
ÄÄ. /
$num
ÄÄ0 1
,
ÄÄ1 2
$num
ÄÄ3 4
,
ÄÄ4 5
$num
ÄÄ6 7
,
ÄÄ7 8
$num
ÄÄ9 :
,
ÄÄ: ;
$num
ÄÄ< =
,
ÄÄ= >
$num
ÄÄ? @
,
ÄÄ@ A
DateTimeKind
ÄÄB N
.
ÄÄN O
Unspecified
ÄÄO Z
)
ÄÄZ [
,
ÄÄ[ \
null
ÄÄ] a
,
ÄÄa b
new
ÄÄc f
DateTime
ÄÄg o
(
ÄÄo p
$num
ÄÄp q
,
ÄÄq r
$num
ÄÄs t
,
ÄÄt u
$num
ÄÄv w
,
ÄÄw x
$num
ÄÄy z
,
ÄÄz {
$num
ÄÄ| }
,
ÄÄ} ~
$numÄÄ Ä
,ÄÄÄ Å
$numÄÄÇ É
,ÄÄÉ Ñ
DateTimeKindÄÄÖ ë
.ÄÄë í
UnspecifiedÄÄí ù
)ÄÄù û
,ÄÄû ü
$numÄÄ† ¢
,ÄÄ¢ £
$strÄÄ§ ©
,ÄÄ© ™
$strÄÄ´ ¿
,ÄÄ¿ ¡
nullÄÄ¬ ∆
,ÄÄ∆ «
newÄÄ» À
DateTimeÄÄÃ ‘
(ÄÄ‘ ’
$numÄÄ’ ÷
,ÄÄ÷ ◊
$numÄÄÿ Ÿ
,ÄÄŸ ⁄
$numÄÄ€ ‹
,ÄÄ‹ ›
$numÄÄﬁ ﬂ
,ÄÄﬂ ‡
$numÄÄ· ‚
,ÄÄ‚ „
$numÄÄ‰ Â
,ÄÄÂ Ê
$numÄÄÁ Ë
,ÄÄË È
DateTimeKindÄÄÍ ˆ
.ÄÄˆ ˜
UnspecifiedÄÄ˜ Ç
)ÄÄÇ É
}ÄÄÑ Ö
,ÄÄÖ Ü
{
ÅÅ 
$num
ÅÅ 
,
ÅÅ 
null
ÅÅ 
,
ÅÅ 
new
ÅÅ  #
DateTime
ÅÅ$ ,
(
ÅÅ, -
$num
ÅÅ- .
,
ÅÅ. /
$num
ÅÅ0 1
,
ÅÅ1 2
$num
ÅÅ3 4
,
ÅÅ4 5
$num
ÅÅ6 7
,
ÅÅ7 8
$num
ÅÅ9 :
,
ÅÅ: ;
$num
ÅÅ< =
,
ÅÅ= >
$num
ÅÅ? @
,
ÅÅ@ A
DateTimeKind
ÅÅB N
.
ÅÅN O
Unspecified
ÅÅO Z
)
ÅÅZ [
,
ÅÅ[ \
null
ÅÅ] a
,
ÅÅa b
new
ÅÅc f
DateTime
ÅÅg o
(
ÅÅo p
$num
ÅÅp q
,
ÅÅq r
$num
ÅÅs t
,
ÅÅt u
$num
ÅÅv w
,
ÅÅw x
$num
ÅÅy z
,
ÅÅz {
$num
ÅÅ| }
,
ÅÅ} ~
$numÅÅ Ä
,ÅÅÄ Å
$numÅÅÇ É
,ÅÅÉ Ñ
DateTimeKindÅÅÖ ë
.ÅÅë í
UnspecifiedÅÅí ù
)ÅÅù û
,ÅÅû ü
$numÅÅ† ¢
,ÅÅ¢ £
$strÅÅ§ ©
,ÅÅ© ™
$strÅÅ´ ¿
,ÅÅ¿ ¡
nullÅÅ¬ ∆
,ÅÅ∆ «
newÅÅ» À
DateTimeÅÅÃ ‘
(ÅÅ‘ ’
$numÅÅ’ ÷
,ÅÅ÷ ◊
$numÅÅÿ Ÿ
,ÅÅŸ ⁄
$numÅÅ€ ‹
,ÅÅ‹ ›
$numÅÅﬁ ﬂ
,ÅÅﬂ ‡
$numÅÅ· ‚
,ÅÅ‚ „
$numÅÅ‰ Â
,ÅÅÂ Ê
$numÅÅÁ Ë
,ÅÅË È
DateTimeKindÅÅÍ ˆ
.ÅÅˆ ˜
UnspecifiedÅÅ˜ Ç
)ÅÅÇ É
}ÅÅÑ Ö
,ÅÅÖ Ü
{
ÇÇ 
$num
ÇÇ 
,
ÇÇ 
null
ÇÇ 
,
ÇÇ 
new
ÇÇ  #
DateTime
ÇÇ$ ,
(
ÇÇ, -
$num
ÇÇ- .
,
ÇÇ. /
$num
ÇÇ0 1
,
ÇÇ1 2
$num
ÇÇ3 4
,
ÇÇ4 5
$num
ÇÇ6 7
,
ÇÇ7 8
$num
ÇÇ9 :
,
ÇÇ: ;
$num
ÇÇ< =
,
ÇÇ= >
$num
ÇÇ? @
,
ÇÇ@ A
DateTimeKind
ÇÇB N
.
ÇÇN O
Unspecified
ÇÇO Z
)
ÇÇZ [
,
ÇÇ[ \
null
ÇÇ] a
,
ÇÇa b
new
ÇÇc f
DateTime
ÇÇg o
(
ÇÇo p
$num
ÇÇp q
,
ÇÇq r
$num
ÇÇs t
,
ÇÇt u
$num
ÇÇv w
,
ÇÇw x
$num
ÇÇy z
,
ÇÇz {
$num
ÇÇ| }
,
ÇÇ} ~
$numÇÇ Ä
,ÇÇÄ Å
$numÇÇÇ É
,ÇÇÉ Ñ
DateTimeKindÇÇÖ ë
.ÇÇë í
UnspecifiedÇÇí ù
)ÇÇù û
,ÇÇû ü
$numÇÇ† ¢
,ÇÇ¢ £
$strÇÇ§ ©
,ÇÇ© ™
$strÇÇ´ ∏
,ÇÇ∏ π
nullÇÇ∫ æ
,ÇÇæ ø
newÇÇ¿ √
DateTimeÇÇƒ Ã
(ÇÇÃ Õ
$numÇÇÕ Œ
,ÇÇŒ œ
$numÇÇ– —
,ÇÇ— “
$numÇÇ” ‘
,ÇÇ‘ ’
$numÇÇ÷ ◊
,ÇÇ◊ ÿ
$numÇÇŸ ⁄
,ÇÇ⁄ €
$numÇÇ‹ ›
,ÇÇ› ﬁ
$numÇÇﬂ ‡
,ÇÇ‡ ·
DateTimeKindÇÇ‚ Ó
.ÇÇÓ Ô
UnspecifiedÇÇÔ ˙
)ÇÇ˙ ˚
}ÇÇ¸ ˝
,ÇÇ˝ ˛
{
ÉÉ 
$num
ÉÉ 
,
ÉÉ 
null
ÉÉ 
,
ÉÉ 
new
ÉÉ  #
DateTime
ÉÉ$ ,
(
ÉÉ, -
$num
ÉÉ- .
,
ÉÉ. /
$num
ÉÉ0 1
,
ÉÉ1 2
$num
ÉÉ3 4
,
ÉÉ4 5
$num
ÉÉ6 7
,
ÉÉ7 8
$num
ÉÉ9 :
,
ÉÉ: ;
$num
ÉÉ< =
,
ÉÉ= >
$num
ÉÉ? @
,
ÉÉ@ A
DateTimeKind
ÉÉB N
.
ÉÉN O
Unspecified
ÉÉO Z
)
ÉÉZ [
,
ÉÉ[ \
null
ÉÉ] a
,
ÉÉa b
new
ÉÉc f
DateTime
ÉÉg o
(
ÉÉo p
$num
ÉÉp q
,
ÉÉq r
$num
ÉÉs t
,
ÉÉt u
$num
ÉÉv w
,
ÉÉw x
$num
ÉÉy z
,
ÉÉz {
$num
ÉÉ| }
,
ÉÉ} ~
$numÉÉ Ä
,ÉÉÄ Å
$numÉÉÇ É
,ÉÉÉ Ñ
DateTimeKindÉÉÖ ë
.ÉÉë í
UnspecifiedÉÉí ù
)ÉÉù û
,ÉÉû ü
$numÉÉ† ¢
,ÉÉ¢ £
$strÉÉ§ ©
,ÉÉ© ™
$strÉÉ´ ∑
,ÉÉ∑ ∏
nullÉÉπ Ω
,ÉÉΩ æ
newÉÉø ¬
DateTimeÉÉ√ À
(ÉÉÀ Ã
$numÉÉÃ Õ
,ÉÉÕ Œ
$numÉÉœ –
,ÉÉ– —
$numÉÉ“ ”
,ÉÉ” ‘
$numÉÉ’ ÷
,ÉÉ÷ ◊
$numÉÉÿ Ÿ
,ÉÉŸ ⁄
$numÉÉ€ ‹
,ÉÉ‹ ›
$numÉÉﬁ ﬂ
,ÉÉﬂ ‡
DateTimeKindÉÉ· Ì
.ÉÉÌ Ó
UnspecifiedÉÉÓ ˘
)ÉÉ˘ ˙
}ÉÉ˚ ¸
,ÉÉ¸ ˝
{
ÑÑ 
$num
ÑÑ 
,
ÑÑ 
null
ÑÑ 
,
ÑÑ 
new
ÑÑ  #
DateTime
ÑÑ$ ,
(
ÑÑ, -
$num
ÑÑ- .
,
ÑÑ. /
$num
ÑÑ0 1
,
ÑÑ1 2
$num
ÑÑ3 4
,
ÑÑ4 5
$num
ÑÑ6 7
,
ÑÑ7 8
$num
ÑÑ9 :
,
ÑÑ: ;
$num
ÑÑ< =
,
ÑÑ= >
$num
ÑÑ? @
,
ÑÑ@ A
DateTimeKind
ÑÑB N
.
ÑÑN O
Unspecified
ÑÑO Z
)
ÑÑZ [
,
ÑÑ[ \
null
ÑÑ] a
,
ÑÑa b
new
ÑÑc f
DateTime
ÑÑg o
(
ÑÑo p
$num
ÑÑp q
,
ÑÑq r
$num
ÑÑs t
,
ÑÑt u
$num
ÑÑv w
,
ÑÑw x
$num
ÑÑy z
,
ÑÑz {
$num
ÑÑ| }
,
ÑÑ} ~
$numÑÑ Ä
,ÑÑÄ Å
$numÑÑÇ É
,ÑÑÉ Ñ
DateTimeKindÑÑÖ ë
.ÑÑë í
UnspecifiedÑÑí ù
)ÑÑù û
,ÑÑû ü
$numÑÑ† ¢
,ÑÑ¢ £
$strÑÑ§ ©
,ÑÑ© ™
$strÑÑ´ π
,ÑÑπ ∫
nullÑÑª ø
,ÑÑø ¿
newÑÑ¡ ƒ
DateTimeÑÑ≈ Õ
(ÑÑÕ Œ
$numÑÑŒ œ
,ÑÑœ –
$numÑÑ— “
,ÑÑ“ ”
$numÑÑ‘ ’
,ÑÑ’ ÷
$numÑÑ◊ ÿ
,ÑÑÿ Ÿ
$numÑÑ⁄ €
,ÑÑ€ ‹
$numÑÑ› ﬁ
,ÑÑﬁ ﬂ
$numÑÑ‡ ·
,ÑÑ· ‚
DateTimeKindÑÑ„ Ô
.ÑÑÔ 
UnspecifiedÑÑ ˚
)ÑÑ˚ ¸
}ÑÑ˝ ˛
}
ÖÖ 
)
ÖÖ 
;
ÖÖ 
migrationBuilder
áá 
.
áá 

InsertData
áá '
(
áá' (
schema
àà 
:
àà 
$str
àà 
,
àà 
table
ââ 
:
ââ 
$str
ââ !
,
ââ! "
columns
ää 
:
ää 
new
ää 
[
ää 
]
ää 
{
ää  
$str
ää! -
,
ää- .
$str
ää/ :
,
ää: ;
$str
ää< G
,
ääG H
$str
ääI W
,
ääW X
$str
ääY n
,
ään o
$str
ääp {
,
ää{ |
$strää} à
,ääà â
$sträää õ
,ääõ ú
$strääù ´
,ää´ ¨
$strää≠ π
,ääπ ∫
$strääª «
}ää» …
,ää…  
values
ãã 
:
ãã 
new
ãã 
object
ãã "
[
ãã" #
,
ãã# $
]
ãã$ %
{
åå 
{
çç 
$num
çç 
,
çç 
null
çç 
,
çç 
new
çç "
DateTime
çç# +
(
çç+ ,
$num
çç, -
,
çç- .
$num
çç/ 0
,
çç0 1
$num
çç2 3
,
çç3 4
$num
çç5 6
,
çç6 7
$num
çç8 9
,
çç9 :
$num
çç; <
,
çç< =
$num
çç> ?
,
çç? @
DateTimeKind
ççA M
.
ççM N
Unspecified
ççN Y
)
ççY Z
,
ççZ [
$str
çç\ `
,
çç` a
$num
ççb f
,
ççf g
null
ççh l
,
ççl m
new
ççn q
DateTime
ççr z
(
ççz {
$num
çç{ |
,
çç| }
$num
çç~ 
,çç Ä
$numççÅ Ç
,ççÇ É
$numççÑ Ö
,ççÖ Ü
$numççá à
,ççà â
$numççä ã
,ççã å
$numççç é
,ççé è
DateTimeKindççê ú
.ççú ù
Unspecifiedççù ®
)çç® ©
,çç© ™
$strçç´ ∞
,çç∞ ±
$strçç≤ ø
,ççø ¿
nullçç¡ ≈
,çç≈ ∆
newçç«  
DateTimeççÀ ”
(çç” ‘
$numçç‘ ’
,çç’ ÷
$numçç◊ ÿ
,ççÿ Ÿ
$numçç⁄ €
,çç€ ‹
$numçç› ﬁ
,ççﬁ ﬂ
$numçç‡ ·
,çç· ‚
$numçç„ ‰
,çç‰ Â
$numççÊ Á
,ççÁ Ë
DateTimeKindççÈ ı
.ççı ˆ
Unspecifiedççˆ Å
)ççÅ Ç
}ççÉ Ñ
,ççÑ Ö
{
éé 
$num
éé 
,
éé 
null
éé 
,
éé 
new
éé "
DateTime
éé# +
(
éé+ ,
$num
éé, -
,
éé- .
$num
éé/ 0
,
éé0 1
$num
éé2 3
,
éé3 4
$num
éé5 6
,
éé6 7
$num
éé8 9
,
éé9 :
$num
éé; <
,
éé< =
$num
éé> ?
,
éé? @
DateTimeKind
ééA M
.
ééM N
Unspecified
ééN Y
)
ééY Z
,
ééZ [
$str
éé\ `
,
éé` a
$num
ééb e
,
éée f
null
éég k
,
éék l
new
éém p
DateTime
ééq y
(
ééy z
$num
ééz {
,
éé{ |
$num
éé} ~
,
éé~ 
$numééÄ Å
,ééÅ Ç
$numééÉ Ñ
,ééÑ Ö
$numééÜ á
,ééá à
$numééâ ä
,ééä ã
$numééå ç
,ééç é
DateTimeKindééè õ
.ééõ ú
Unspecifiedééú ß
)ééß ®
,éé® ©
$stréé™ Ø
,ééØ ∞
$stréé± æ
,ééæ ø
nulléé¿ ƒ
,ééƒ ≈
newéé∆ …
DateTimeéé  “
(éé“ ”
$numéé” ‘
,éé‘ ’
$numéé÷ ◊
,éé◊ ÿ
$numééŸ ⁄
,éé⁄ €
$numéé‹ ›
,éé› ﬁ
$numééﬂ ‡
,éé‡ ·
$numéé‚ „
,éé„ ‰
$numééÂ Ê
,ééÊ Á
DateTimeKindééË Ù
.ééÙ ı
Unspecifiedééı Ä
)ééÄ Å
}ééÇ É
,ééÉ Ñ
{
èè 
$num
èè 
,
èè 
null
èè 
,
èè 
new
èè "
DateTime
èè# +
(
èè+ ,
$num
èè, -
,
èè- .
$num
èè/ 0
,
èè0 1
$num
èè2 3
,
èè3 4
$num
èè5 6
,
èè6 7
$num
èè8 9
,
èè9 :
$num
èè; <
,
èè< =
$num
èè> ?
,
èè? @
DateTimeKind
èèA M
.
èèM N
Unspecified
èèN Y
)
èèY Z
,
èèZ [
$str
èè\ `
,
èè` a
$num
èèb e
,
èèe f
null
èèg k
,
èèk l
new
èèm p
DateTime
èèq y
(
èèy z
$num
èèz {
,
èè{ |
$num
èè} ~
,
èè~ 
$numèèÄ Å
,èèÅ Ç
$numèèÉ Ñ
,èèÑ Ö
$numèèÜ á
,èèá à
$numèèâ ä
,èèä ã
$numèèå ç
,èèç é
DateTimeKindèèè õ
.èèõ ú
Unspecifiedèèú ß
)èèß ®
,èè® ©
$strèè™ Ø
,èèØ ∞
$strèè± æ
,èèæ ø
nullèè¿ ƒ
,èèƒ ≈
newèè∆ …
DateTimeèè  “
(èè“ ”
$numèè” ‘
,èè‘ ’
$numèè÷ ◊
,èè◊ ÿ
$numèèŸ ⁄
,èè⁄ €
$numèè‹ ›
,èè› ﬁ
$numèèﬂ ‡
,èè‡ ·
$numèè‚ „
,èè„ ‰
$numèèÂ Ê
,èèÊ Á
DateTimeKindèèË Ù
.èèÙ ı
Unspecifiedèèı Ä
)èèÄ Å
}èèÇ É
,èèÉ Ñ
{
êê 
$num
êê 
,
êê 
null
êê 
,
êê 
new
êê "
DateTime
êê# +
(
êê+ ,
$num
êê, -
,
êê- .
$num
êê/ 0
,
êê0 1
$num
êê2 3
,
êê3 4
$num
êê5 6
,
êê6 7
$num
êê8 9
,
êê9 :
$num
êê; <
,
êê< =
$num
êê> ?
,
êê? @
DateTimeKind
êêA M
.
êêM N
Unspecified
êêN Y
)
êêY Z
,
êêZ [
$str
êê\ `
,
êê` a
$num
êêb d
,
êêd e
null
êêf j
,
êêj k
new
êêl o
DateTime
êêp x
(
êêx y
$num
êêy z
,
êêz {
$num
êê| }
,
êê} ~
$numêê Ä
,êêÄ Å
$numêêÇ É
,êêÉ Ñ
$numêêÖ Ü
,êêÜ á
$numêêà â
,êêâ ä
$numêêã å
,êêå ç
DateTimeKindêêé ö
.êêö õ
Unspecifiedêêõ ¶
)êê¶ ß
,êêß ®
$strêê© Æ
,êêÆ Ø
$strêê∞ Ω
,êêΩ æ
nullêêø √
,êê√ ƒ
newêê≈ »
DateTimeêê… —
(êê— “
$numêê“ ”
,êê” ‘
$numêê’ ÷
,êê÷ ◊
$numêêÿ Ÿ
,êêŸ ⁄
$numêê€ ‹
,êê‹ ›
$numêêﬁ ﬂ
,êêﬂ ‡
$numêê· ‚
,êê‚ „
$numêê‰ Â
,êêÂ Ê
DateTimeKindêêÁ Û
.êêÛ Ù
UnspecifiedêêÙ ˇ
)êêˇ Ä
}êêÅ Ç
,êêÇ É
{
ëë 
$num
ëë 
,
ëë 
null
ëë 
,
ëë 
new
ëë "
DateTime
ëë# +
(
ëë+ ,
$num
ëë, -
,
ëë- .
$num
ëë/ 0
,
ëë0 1
$num
ëë2 3
,
ëë3 4
$num
ëë5 6
,
ëë6 7
$num
ëë8 9
,
ëë9 :
$num
ëë; <
,
ëë< =
$num
ëë> ?
,
ëë? @
DateTimeKind
ëëA M
.
ëëM N
Unspecified
ëëN Y
)
ëëY Z
,
ëëZ [
$str
ëë\ `
,
ëë` a
$num
ëëb e
,
ëëe f
null
ëëg k
,
ëëk l
new
ëëm p
DateTime
ëëq y
(
ëëy z
$num
ëëz {
,
ëë{ |
$num
ëë} ~
,
ëë~ 
$numëëÄ Å
,ëëÅ Ç
$numëëÉ Ñ
,ëëÑ Ö
$numëëÜ á
,ëëá à
$numëëâ ä
,ëëä ã
$numëëå ç
,ëëç é
DateTimeKindëëè õ
.ëëõ ú
Unspecifiedëëú ß
)ëëß ®
,ëë® ©
$strëë™ Ø
,ëëØ ∞
$strëë± æ
,ëëæ ø
nullëë¿ ƒ
,ëëƒ ≈
newëë∆ …
DateTimeëë  “
(ëë“ ”
$numëë” ‘
,ëë‘ ’
$numëë÷ ◊
,ëë◊ ÿ
$numëëŸ ⁄
,ëë⁄ €
$numëë‹ ›
,ëë› ﬁ
$numëëﬂ ‡
,ëë‡ ·
$numëë‚ „
,ëë„ ‰
$numëëÂ Ê
,ëëÊ Á
DateTimeKindëëË Ù
.ëëÙ ı
Unspecifiedëëı Ä
)ëëÄ Å
}ëëÇ É
,ëëÉ Ñ
{
íí 
$num
íí 
,
íí 
null
íí 
,
íí 
new
íí "
DateTime
íí# +
(
íí+ ,
$num
íí, -
,
íí- .
$num
íí/ 0
,
íí0 1
$num
íí2 3
,
íí3 4
$num
íí5 6
,
íí6 7
$num
íí8 9
,
íí9 :
$num
íí; <
,
íí< =
$num
íí> ?
,
íí? @
DateTimeKind
ííA M
.
ííM N
Unspecified
ííN Y
)
ííY Z
,
ííZ [
$str
íí\ `
,
íí` a
$num
ííb d
,
ííd e
null
ííf j
,
ííj k
new
ííl o
DateTime
ííp x
(
ííx y
$num
ííy z
,
ííz {
$num
íí| }
,
íí} ~
$numíí Ä
,ííÄ Å
$numííÇ É
,ííÉ Ñ
$numííÖ Ü
,ííÜ á
$numííà â
,ííâ ä
$numííã å
,ííå ç
DateTimeKindííé ö
.ííö õ
Unspecifiedííõ ¶
)íí¶ ß
,ííß ®
$stríí© Æ
,ííÆ Ø
$stríí∞ Ω
,ííΩ æ
nullííø √
,íí√ ƒ
newíí≈ »
DateTimeíí… —
(íí— “
$numíí“ ”
,íí” ‘
$numíí’ ÷
,íí÷ ◊
$numííÿ Ÿ
,ííŸ ⁄
$numíí€ ‹
,íí‹ ›
$numííﬁ ﬂ
,ííﬂ ‡
$numíí· ‚
,íí‚ „
$numíí‰ Â
,ííÂ Ê
DateTimeKindííÁ Û
.ííÛ Ù
UnspecifiedííÙ ˇ
)ííˇ Ä
}ííÅ Ç
,ííÇ É
{
ìì 
$num
ìì 
,
ìì 
null
ìì 
,
ìì 
new
ìì "
DateTime
ìì# +
(
ìì+ ,
$num
ìì, -
,
ìì- .
$num
ìì/ 0
,
ìì0 1
$num
ìì2 3
,
ìì3 4
$num
ìì5 6
,
ìì6 7
$num
ìì8 9
,
ìì9 :
$num
ìì; <
,
ìì< =
$num
ìì> ?
,
ìì? @
DateTimeKind
ììA M
.
ììM N
Unspecified
ììN Y
)
ììY Z
,
ììZ [
$str
ìì\ `
,
ìì` a
$num
ììb d
,
ììd e
null
ììf j
,
ììj k
new
ììl o
DateTime
ììp x
(
ììx y
$num
ììy z
,
ììz {
$num
ìì| }
,
ìì} ~
$numìì Ä
,ììÄ Å
$numììÇ É
,ììÉ Ñ
$numììÖ Ü
,ììÜ á
$numììà â
,ììâ ä
$numììã å
,ììå ç
DateTimeKindììé ö
.ììö õ
Unspecifiedììõ ¶
)ìì¶ ß
,ììß ®
$strìì© Æ
,ììÆ Ø
$strìì∞ Ω
,ììΩ æ
nullììø √
,ìì√ ƒ
newìì≈ »
DateTimeìì… —
(ìì— “
$numìì“ ”
,ìì” ‘
$numìì’ ÷
,ìì÷ ◊
$numììÿ Ÿ
,ììŸ ⁄
$numìì€ ‹
,ìì‹ ›
$numììﬁ ﬂ
,ììﬂ ‡
$numìì· ‚
,ìì‚ „
$numìì‰ Â
,ììÂ Ê
DateTimeKindììÁ Û
.ììÛ Ù
UnspecifiedììÙ ˇ
)ììˇ Ä
}ììÅ Ç
,ììÇ É
{
îî 
$num
îî 
,
îî 
null
îî 
,
îî 
new
îî "
DateTime
îî# +
(
îî+ ,
$num
îî, -
,
îî- .
$num
îî/ 0
,
îî0 1
$num
îî2 3
,
îî3 4
$num
îî5 6
,
îî6 7
$num
îî8 9
,
îî9 :
$num
îî; <
,
îî< =
$num
îî> ?
,
îî? @
DateTimeKind
îîA M
.
îîM N
Unspecified
îîN Y
)
îîY Z
,
îîZ [
$str
îî\ `
,
îî` a
$num
îîb d
,
îîd e
null
îîf j
,
îîj k
new
îîl o
DateTime
îîp x
(
îîx y
$num
îîy z
,
îîz {
$num
îî| }
,
îî} ~
$numîî Ä
,îîÄ Å
$numîîÇ É
,îîÉ Ñ
$numîîÖ Ü
,îîÜ á
$numîîà â
,îîâ ä
$numîîã å
,îîå ç
DateTimeKindîîé ö
.îîö õ
Unspecifiedîîõ ¶
)îî¶ ß
,îîß ®
$strîî© Æ
,îîÆ Ø
$strîî∞ Ω
,îîΩ æ
nullîîø √
,îî√ ƒ
newîî≈ »
DateTimeîî… —
(îî— “
$numîî“ ”
,îî” ‘
$numîî’ ÷
,îî÷ ◊
$numîîÿ Ÿ
,îîŸ ⁄
$numîî€ ‹
,îî‹ ›
$numîîﬁ ﬂ
,îîﬂ ‡
$numîî· ‚
,îî‚ „
$numîî‰ Â
,îîÂ Ê
DateTimeKindîîÁ Û
.îîÛ Ù
UnspecifiedîîÙ ˇ
)îîˇ Ä
}îîÅ Ç
,îîÇ É
{
ïï 
$num
ïï 
,
ïï 
null
ïï 
,
ïï 
new
ïï "
DateTime
ïï# +
(
ïï+ ,
$num
ïï, -
,
ïï- .
$num
ïï/ 0
,
ïï0 1
$num
ïï2 3
,
ïï3 4
$num
ïï5 6
,
ïï6 7
$num
ïï8 9
,
ïï9 :
$num
ïï; <
,
ïï< =
$num
ïï> ?
,
ïï? @
DateTimeKind
ïïA M
.
ïïM N
Unspecified
ïïN Y
)
ïïY Z
,
ïïZ [
$str
ïï\ `
,
ïï` a
$num
ïïb d
,
ïïd e
null
ïïf j
,
ïïj k
new
ïïl o
DateTime
ïïp x
(
ïïx y
$num
ïïy z
,
ïïz {
$num
ïï| }
,
ïï} ~
$numïï Ä
,ïïÄ Å
$numïïÇ É
,ïïÉ Ñ
$numïïÖ Ü
,ïïÜ á
$numïïà â
,ïïâ ä
$numïïã å
,ïïå ç
DateTimeKindïïé ö
.ïïö õ
Unspecifiedïïõ ¶
)ïï¶ ß
,ïïß ®
$strïï© Æ
,ïïÆ Ø
$strïï∞ Ω
,ïïΩ æ
nullïïø √
,ïï√ ƒ
newïï≈ »
DateTimeïï… —
(ïï— “
$numïï“ ”
,ïï” ‘
$numïï’ ÷
,ïï÷ ◊
$numïïÿ Ÿ
,ïïŸ ⁄
$numïï€ ‹
,ïï‹ ›
$numïïﬁ ﬂ
,ïïﬂ ‡
$numïï· ‚
,ïï‚ „
$numïï‰ Â
,ïïÂ Ê
DateTimeKindïïÁ Û
.ïïÛ Ù
UnspecifiedïïÙ ˇ
)ïïˇ Ä
}ïïÅ Ç
,ïïÇ É
{
ññ 
$num
ññ 
,
ññ 
null
ññ 
,
ññ 
new
ññ  #
DateTime
ññ$ ,
(
ññ, -
$num
ññ- .
,
ññ. /
$num
ññ0 1
,
ññ1 2
$num
ññ3 4
,
ññ4 5
$num
ññ6 7
,
ññ7 8
$num
ññ9 :
,
ññ: ;
$num
ññ< =
,
ññ= >
$num
ññ? @
,
ññ@ A
DateTimeKind
ññB N
.
ññN O
Unspecified
ññO Z
)
ññZ [
,
ññ[ \
$str
ññ] a
,
ñña b
$num
ññc e
,
ññe f
null
ññg k
,
ññk l
new
ññm p
DateTime
ññq y
(
ññy z
$num
ññz {
,
ññ{ |
$num
ññ} ~
,
ññ~ 
$numññÄ Å
,ññÅ Ç
$numññÉ Ñ
,ññÑ Ö
$numññÜ á
,ññá à
$numññâ ä
,ññä ã
$numññå ç
,ññç é
DateTimeKindññè õ
.ññõ ú
Unspecifiedññú ß
)ññß ®
,ññ® ©
$strññ™ Ø
,ññØ ∞
$strññ± ø
,ññø ¿
nullññ¡ ≈
,ññ≈ ∆
newññ«  
DateTimeññÀ ”
(ññ” ‘
$numññ‘ ’
,ññ’ ÷
$numññ◊ ÿ
,ññÿ Ÿ
$numññ⁄ €
,ññ€ ‹
$numññ› ﬁ
,ññﬁ ﬂ
$numññ‡ ·
,ññ· ‚
$numññ„ ‰
,ññ‰ Â
$numññÊ Á
,ññÁ Ë
DateTimeKindññÈ ı
.ññı ˆ
Unspecifiedññˆ Å
)ññÅ Ç
}ññÉ Ñ
,ññÑ Ö
{
óó 
$num
óó 
,
óó 
null
óó 
,
óó 
new
óó  #
DateTime
óó$ ,
(
óó, -
$num
óó- .
,
óó. /
$num
óó0 1
,
óó1 2
$num
óó3 4
,
óó4 5
$num
óó6 7
,
óó7 8
$num
óó9 :
,
óó: ;
$num
óó< =
,
óó= >
$num
óó? @
,
óó@ A
DateTimeKind
óóB N
.
óóN O
Unspecified
óóO Z
)
óóZ [
,
óó[ \
$str
óó] a
,
óóa b
$num
óóc e
,
óóe f
null
óóg k
,
óók l
new
óóm p
DateTime
óóq y
(
óóy z
$num
óóz {
,
óó{ |
$num
óó} ~
,
óó~ 
$numóóÄ Å
,óóÅ Ç
$numóóÉ Ñ
,óóÑ Ö
$numóóÜ á
,óóá à
$numóóâ ä
,óóä ã
$numóóå ç
,óóç é
DateTimeKindóóè õ
.óóõ ú
Unspecifiedóóú ß
)óóß ®
,óó® ©
$stróó™ Ø
,óóØ ∞
$stróó± ø
,óóø ¿
nullóó¡ ≈
,óó≈ ∆
newóó«  
DateTimeóóÀ ”
(óó” ‘
$numóó‘ ’
,óó’ ÷
$numóó◊ ÿ
,óóÿ Ÿ
$numóó⁄ €
,óó€ ‹
$numóó› ﬁ
,óóﬁ ﬂ
$numóó‡ ·
,óó· ‚
$numóó„ ‰
,óó‰ Â
$numóóÊ Á
,óóÁ Ë
DateTimeKindóóÈ ı
.óóı ˆ
Unspecifiedóóˆ Å
)óóÅ Ç
}óóÉ Ñ
,óóÑ Ö
{
òò 
$num
òò 
,
òò 
null
òò 
,
òò 
new
òò  #
DateTime
òò$ ,
(
òò, -
$num
òò- .
,
òò. /
$num
òò0 1
,
òò1 2
$num
òò3 4
,
òò4 5
$num
òò6 7
,
òò7 8
$num
òò9 :
,
òò: ;
$num
òò< =
,
òò= >
$num
òò? @
,
òò@ A
DateTimeKind
òòB N
.
òòN O
Unspecified
òòO Z
)
òòZ [
,
òò[ \
$str
òò] a
,
òòa b
$num
òòc e
,
òòe f
null
òòg k
,
òòk l
new
òòm p
DateTime
òòq y
(
òòy z
$num
òòz {
,
òò{ |
$num
òò} ~
,
òò~ 
$numòòÄ Å
,òòÅ Ç
$numòòÉ Ñ
,òòÑ Ö
$numòòÜ á
,òòá à
$numòòâ ä
,òòä ã
$numòòå ç
,òòç é
DateTimeKindòòè õ
.òòõ ú
Unspecifiedòòú ß
)òòß ®
,òò® ©
$stròò™ Ø
,òòØ ∞
$stròò± ø
,òòø ¿
nullòò¡ ≈
,òò≈ ∆
newòò«  
DateTimeòòÀ ”
(òò” ‘
$numòò‘ ’
,òò’ ÷
$numòò◊ ÿ
,òòÿ Ÿ
$numòò⁄ €
,òò€ ‹
$numòò› ﬁ
,òòﬁ ﬂ
$numòò‡ ·
,òò· ‚
$numòò„ ‰
,òò‰ Â
$numòòÊ Á
,òòÁ Ë
DateTimeKindòòÈ ı
.òòı ˆ
Unspecifiedòòˆ Å
)òòÅ Ç
}òòÉ Ñ
,òòÑ Ö
{
ôô 
$num
ôô 
,
ôô 
null
ôô 
,
ôô 
new
ôô  #
DateTime
ôô$ ,
(
ôô, -
$num
ôô- .
,
ôô. /
$num
ôô0 1
,
ôô1 2
$num
ôô3 4
,
ôô4 5
$num
ôô6 7
,
ôô7 8
$num
ôô9 :
,
ôô: ;
$num
ôô< =
,
ôô= >
$num
ôô? @
,
ôô@ A
DateTimeKind
ôôB N
.
ôôN O
Unspecified
ôôO Z
)
ôôZ [
,
ôô[ \
$str
ôô] a
,
ôôa b
$num
ôôc d
,
ôôd e
null
ôôf j
,
ôôj k
new
ôôl o
DateTime
ôôp x
(
ôôx y
$num
ôôy z
,
ôôz {
$num
ôô| }
,
ôô} ~
$numôô Ä
,ôôÄ Å
$numôôÇ É
,ôôÉ Ñ
$numôôÖ Ü
,ôôÜ á
$numôôà â
,ôôâ ä
$numôôã å
,ôôå ç
DateTimeKindôôé ö
.ôôö õ
Unspecifiedôôõ ¶
)ôô¶ ß
,ôôß ®
$strôô© Æ
,ôôÆ Ø
$strôô∞ æ
,ôôæ ø
nullôô¿ ƒ
,ôôƒ ≈
newôô∆ …
DateTimeôô  “
(ôô“ ”
$numôô” ‘
,ôô‘ ’
$numôô÷ ◊
,ôô◊ ÿ
$numôôŸ ⁄
,ôô⁄ €
$numôô‹ ›
,ôô› ﬁ
$numôôﬂ ‡
,ôô‡ ·
$numôô‚ „
,ôô„ ‰
$numôôÂ Ê
,ôôÊ Á
DateTimeKindôôË Ù
.ôôÙ ı
Unspecifiedôôı Ä
)ôôÄ Å
}ôôÇ É
,ôôÉ Ñ
{
öö 
$num
öö 
,
öö 
null
öö 
,
öö 
new
öö  #
DateTime
öö$ ,
(
öö, -
$num
öö- .
,
öö. /
$num
öö0 1
,
öö1 2
$num
öö3 4
,
öö4 5
$num
öö6 7
,
öö7 8
$num
öö9 :
,
öö: ;
$num
öö< =
,
öö= >
$num
öö? @
,
öö@ A
DateTimeKind
ööB N
.
ööN O
Unspecified
ööO Z
)
ööZ [
,
öö[ \
$str
öö] a
,
ööa b
$num
ööc e
,
ööe f
null
öög k
,
öök l
new
ööm p
DateTime
ööq y
(
ööy z
$num
ööz {
,
öö{ |
$num
öö} ~
,
öö~ 
$numööÄ Å
,ööÅ Ç
$numööÉ Ñ
,ööÑ Ö
$numööÜ á
,ööá à
$numööâ ä
,ööä ã
$numööå ç
,ööç é
DateTimeKindööè õ
.ööõ ú
Unspecifiedööú ß
)ööß ®
,öö® ©
$ströö™ Ø
,ööØ ∞
$ströö± ø
,ööø ¿
nullöö¡ ≈
,öö≈ ∆
newöö«  
DateTimeööÀ ”
(öö” ‘
$numöö‘ ’
,öö’ ÷
$numöö◊ ÿ
,ööÿ Ÿ
$numöö⁄ €
,öö€ ‹
$numöö› ﬁ
,ööﬁ ﬂ
$numöö‡ ·
,öö· ‚
$numöö„ ‰
,öö‰ Â
$numööÊ Á
,ööÁ Ë
DateTimeKindööÈ ı
.ööı ˆ
Unspecifiedööˆ Å
)ööÅ Ç
}ööÉ Ñ
,ööÑ Ö
{
õõ 
$num
õõ 
,
õõ 
null
õõ 
,
õõ 
new
õõ  #
DateTime
õõ$ ,
(
õõ, -
$num
õõ- .
,
õõ. /
$num
õõ0 1
,
õõ1 2
$num
õõ3 4
,
õõ4 5
$num
õõ6 7
,
õõ7 8
$num
õõ9 :
,
õõ: ;
$num
õõ< =
,
õõ= >
$num
õõ? @
,
õõ@ A
DateTimeKind
õõB N
.
õõN O
Unspecified
õõO Z
)
õõZ [
,
õõ[ \
$str
õõ] a
,
õõa b
$num
õõc e
,
õõe f
null
õõg k
,
õõk l
new
õõm p
DateTime
õõq y
(
õõy z
$num
õõz {
,
õõ{ |
$num
õõ} ~
,
õõ~ 
$numõõÄ Å
,õõÅ Ç
$numõõÉ Ñ
,õõÑ Ö
$numõõÜ á
,õõá à
$numõõâ ä
,õõä ã
$numõõå ç
,õõç é
DateTimeKindõõè õ
.õõõ ú
Unspecifiedõõú ß
)õõß ®
,õõ® ©
$strõõ™ Ø
,õõØ ∞
$strõõ± ø
,õõø ¿
nullõõ¡ ≈
,õõ≈ ∆
newõõ«  
DateTimeõõÀ ”
(õõ” ‘
$numõõ‘ ’
,õõ’ ÷
$numõõ◊ ÿ
,õõÿ Ÿ
$numõõ⁄ €
,õõ€ ‹
$numõõ› ﬁ
,õõﬁ ﬂ
$numõõ‡ ·
,õõ· ‚
$numõõ„ ‰
,õõ‰ Â
$numõõÊ Á
,õõÁ Ë
DateTimeKindõõÈ ı
.õõı ˆ
Unspecifiedõõˆ Å
)õõÅ Ç
}õõÉ Ñ
,õõÑ Ö
{
úú 
$num
úú 
,
úú 
null
úú 
,
úú 
new
úú  #
DateTime
úú$ ,
(
úú, -
$num
úú- .
,
úú. /
$num
úú0 1
,
úú1 2
$num
úú3 4
,
úú4 5
$num
úú6 7
,
úú7 8
$num
úú9 :
,
úú: ;
$num
úú< =
,
úú= >
$num
úú? @
,
úú@ A
DateTimeKind
úúB N
.
úúN O
Unspecified
úúO Z
)
úúZ [
,
úú[ \
$str
úú] a
,
úúa b
$num
úúc e
,
úúe f
null
úúg k
,
úúk l
new
úúm p
DateTime
úúq y
(
úúy z
$num
úúz {
,
úú{ |
$num
úú} ~
,
úú~ 
$numúúÄ Å
,úúÅ Ç
$numúúÉ Ñ
,úúÑ Ö
$numúúÜ á
,úúá à
$numúúâ ä
,úúä ã
$numúúå ç
,úúç é
DateTimeKindúúè õ
.úúõ ú
Unspecifiedúúú ß
)úúß ®
,úú® ©
$strúú™ Ø
,úúØ ∞
$strúú± ø
,úúø ¿
nullúú¡ ≈
,úú≈ ∆
newúú«  
DateTimeúúÀ ”
(úú” ‘
$numúú‘ ’
,úú’ ÷
$numúú◊ ÿ
,úúÿ Ÿ
$numúú⁄ €
,úú€ ‹
$numúú› ﬁ
,úúﬁ ﬂ
$numúú‡ ·
,úú· ‚
$numúú„ ‰
,úú‰ Â
$numúúÊ Á
,úúÁ Ë
DateTimeKindúúÈ ı
.úúı ˆ
Unspecifiedúúˆ Å
)úúÅ Ç
}úúÉ Ñ
,úúÑ Ö
{
ùù 
$num
ùù 
,
ùù 
null
ùù 
,
ùù 
new
ùù  #
DateTime
ùù$ ,
(
ùù, -
$num
ùù- .
,
ùù. /
$num
ùù0 1
,
ùù1 2
$num
ùù3 4
,
ùù4 5
$num
ùù6 7
,
ùù7 8
$num
ùù9 :
,
ùù: ;
$num
ùù< =
,
ùù= >
$num
ùù? @
,
ùù@ A
DateTimeKind
ùùB N
.
ùùN O
Unspecified
ùùO Z
)
ùùZ [
,
ùù[ \
$str
ùù] a
,
ùùa b
$num
ùùc e
,
ùùe f
null
ùùg k
,
ùùk l
new
ùùm p
DateTime
ùùq y
(
ùùy z
$num
ùùz {
,
ùù{ |
$num
ùù} ~
,
ùù~ 
$numùùÄ Å
,ùùÅ Ç
$numùùÉ Ñ
,ùùÑ Ö
$numùùÜ á
,ùùá à
$numùùâ ä
,ùùä ã
$numùùå ç
,ùùç é
DateTimeKindùùè õ
.ùùõ ú
Unspecifiedùùú ß
)ùùß ®
,ùù® ©
$strùù™ Ø
,ùùØ ∞
$strùù± ø
,ùùø ¿
nullùù¡ ≈
,ùù≈ ∆
newùù«  
DateTimeùùÀ ”
(ùù” ‘
$numùù‘ ’
,ùù’ ÷
$numùù◊ ÿ
,ùùÿ Ÿ
$numùù⁄ €
,ùù€ ‹
$numùù› ﬁ
,ùùﬁ ﬂ
$numùù‡ ·
,ùù· ‚
$numùù„ ‰
,ùù‰ Â
$numùùÊ Á
,ùùÁ Ë
DateTimeKindùùÈ ı
.ùùı ˆ
Unspecifiedùùˆ Å
)ùùÅ Ç
}ùùÉ Ñ
,ùùÑ Ö
{
ûû 
$num
ûû 
,
ûû 
null
ûû 
,
ûû 
new
ûû  #
DateTime
ûû$ ,
(
ûû, -
$num
ûû- .
,
ûû. /
$num
ûû0 1
,
ûû1 2
$num
ûû3 4
,
ûû4 5
$num
ûû6 7
,
ûû7 8
$num
ûû9 :
,
ûû: ;
$num
ûû< =
,
ûû= >
$num
ûû? @
,
ûû@ A
DateTimeKind
ûûB N
.
ûûN O
Unspecified
ûûO Z
)
ûûZ [
,
ûû[ \
$str
ûû] a
,
ûûa b
$num
ûûc e
,
ûûe f
null
ûûg k
,
ûûk l
new
ûûm p
DateTime
ûûq y
(
ûûy z
$num
ûûz {
,
ûû{ |
$num
ûû} ~
,
ûû~ 
$numûûÄ Å
,ûûÅ Ç
$numûûÉ Ñ
,ûûÑ Ö
$numûûÜ á
,ûûá à
$numûûâ ä
,ûûä ã
$numûûå ç
,ûûç é
DateTimeKindûûè õ
.ûûõ ú
Unspecifiedûûú ß
)ûûß ®
,ûû® ©
$strûû™ Ø
,ûûØ ∞
$strûû± ø
,ûûø ¿
nullûû¡ ≈
,ûû≈ ∆
newûû«  
DateTimeûûÀ ”
(ûû” ‘
$numûû‘ ’
,ûû’ ÷
$numûû◊ ÿ
,ûûÿ Ÿ
$numûû⁄ €
,ûû€ ‹
$numûû› ﬁ
,ûûﬁ ﬂ
$numûû‡ ·
,ûû· ‚
$numûû„ ‰
,ûû‰ Â
$numûûÊ Á
,ûûÁ Ë
DateTimeKindûûÈ ı
.ûûı ˆ
Unspecifiedûûˆ Å
)ûûÅ Ç
}ûûÉ Ñ
,ûûÑ Ö
{
üü 
$num
üü 
,
üü 
null
üü 
,
üü 
new
üü  #
DateTime
üü$ ,
(
üü, -
$num
üü- .
,
üü. /
$num
üü0 1
,
üü1 2
$num
üü3 4
,
üü4 5
$num
üü6 7
,
üü7 8
$num
üü9 :
,
üü: ;
$num
üü< =
,
üü= >
$num
üü? @
,
üü@ A
DateTimeKind
üüB N
.
üüN O
Unspecified
üüO Z
)
üüZ [
,
üü[ \
$str
üü] a
,
üüa b
$num
üüc e
,
üüe f
null
üüg k
,
üük l
new
üüm p
DateTime
üüq y
(
üüy z
$num
üüz {
,
üü{ |
$num
üü} ~
,
üü~ 
$numüüÄ Å
,üüÅ Ç
$numüüÉ Ñ
,üüÑ Ö
$numüüÜ á
,üüá à
$numüüâ ä
,üüä ã
$numüüå ç
,üüç é
DateTimeKindüüè õ
.üüõ ú
Unspecifiedüüú ß
)üüß ®
,üü® ©
$strüü™ Ø
,üüØ ∞
$strüü± ø
,üüø ¿
nullüü¡ ≈
,üü≈ ∆
newüü«  
DateTimeüüÀ ”
(üü” ‘
$numüü‘ ’
,üü’ ÷
$numüü◊ ÿ
,üüÿ Ÿ
$numüü⁄ €
,üü€ ‹
$numüü› ﬁ
,üüﬁ ﬂ
$numüü‡ ·
,üü· ‚
$numüü„ ‰
,üü‰ Â
$numüüÊ Á
,üüÁ Ë
DateTimeKindüüÈ ı
.üüı ˆ
Unspecifiedüüˆ Å
)üüÅ Ç
}üüÉ Ñ
,üüÑ Ö
{
†† 
$num
†† 
,
†† 
null
†† 
,
†† 
new
††  #
DateTime
††$ ,
(
††, -
$num
††- .
,
††. /
$num
††0 1
,
††1 2
$num
††3 4
,
††4 5
$num
††6 7
,
††7 8
$num
††9 :
,
††: ;
$num
††< =
,
††= >
$num
††? @
,
††@ A
DateTimeKind
††B N
.
††N O
Unspecified
††O Z
)
††Z [
,
††[ \
$str
††] a
,
††a b
$num
††c e
,
††e f
null
††g k
,
††k l
new
††m p
DateTime
††q y
(
††y z
$num
††z {
,
††{ |
$num
††} ~
,
††~ 
$num††Ä Å
,††Å Ç
$num††É Ñ
,††Ñ Ö
$num††Ü á
,††á à
$num††â ä
,††ä ã
$num††å ç
,††ç é
DateTimeKind††è õ
.††õ ú
Unspecified††ú ß
)††ß ®
,††® ©
$str††™ Ø
,††Ø ∞
$str††± ø
,††ø ¿
null††¡ ≈
,††≈ ∆
new††«  
DateTime††À ”
(††” ‘
$num††‘ ’
,††’ ÷
$num††◊ ÿ
,††ÿ Ÿ
$num††⁄ €
,††€ ‹
$num††› ﬁ
,††ﬁ ﬂ
$num††‡ ·
,††· ‚
$num††„ ‰
,††‰ Â
$num††Ê Á
,††Á Ë
DateTimeKind††È ı
.††ı ˆ
Unspecified††ˆ Å
)††Å Ç
}††É Ñ
,††Ñ Ö
{
°° 
$num
°° 
,
°° 
null
°° 
,
°° 
new
°°  #
DateTime
°°$ ,
(
°°, -
$num
°°- .
,
°°. /
$num
°°0 1
,
°°1 2
$num
°°3 4
,
°°4 5
$num
°°6 7
,
°°7 8
$num
°°9 :
,
°°: ;
$num
°°< =
,
°°= >
$num
°°? @
,
°°@ A
DateTimeKind
°°B N
.
°°N O
Unspecified
°°O Z
)
°°Z [
,
°°[ \
$str
°°] b
,
°°b c
$num
°°d f
,
°°f g
null
°°h l
,
°°l m
new
°°n q
DateTime
°°r z
(
°°z {
$num
°°{ |
,
°°| }
$num
°°~ 
,°° Ä
$num°°Å Ç
,°°Ç É
$num°°Ñ Ö
,°°Ö Ü
$num°°á à
,°°à â
$num°°ä ã
,°°ã å
$num°°ç é
,°°é è
DateTimeKind°°ê ú
.°°ú ù
Unspecified°°ù ®
)°°® ©
,°°© ™
$str°°´ ∞
,°°∞ ±
$str°°≤ ¿
,°°¿ ¡
null°°¬ ∆
,°°∆ «
new°°» À
DateTime°°Ã ‘
(°°‘ ’
$num°°’ ÷
,°°÷ ◊
$num°°ÿ Ÿ
,°°Ÿ ⁄
$num°°€ ‹
,°°‹ ›
$num°°ﬁ ﬂ
,°°ﬂ ‡
$num°°· ‚
,°°‚ „
$num°°‰ Â
,°°Â Ê
$num°°Á Ë
,°°Ë È
DateTimeKind°°Í ˆ
.°°ˆ ˜
Unspecified°°˜ Ç
)°°Ç É
}°°Ñ Ö
,°°Ö Ü
{
¢¢ 
$num
¢¢ 
,
¢¢ 
null
¢¢ 
,
¢¢ 
new
¢¢  #
DateTime
¢¢$ ,
(
¢¢, -
$num
¢¢- .
,
¢¢. /
$num
¢¢0 1
,
¢¢1 2
$num
¢¢3 4
,
¢¢4 5
$num
¢¢6 7
,
¢¢7 8
$num
¢¢9 :
,
¢¢: ;
$num
¢¢< =
,
¢¢= >
$num
¢¢? @
,
¢¢@ A
DateTimeKind
¢¢B N
.
¢¢N O
Unspecified
¢¢O Z
)
¢¢Z [
,
¢¢[ \
$str
¢¢] b
,
¢¢b c
$num
¢¢d f
,
¢¢f g
null
¢¢h l
,
¢¢l m
new
¢¢n q
DateTime
¢¢r z
(
¢¢z {
$num
¢¢{ |
,
¢¢| }
$num
¢¢~ 
,¢¢ Ä
$num¢¢Å Ç
,¢¢Ç É
$num¢¢Ñ Ö
,¢¢Ö Ü
$num¢¢á à
,¢¢à â
$num¢¢ä ã
,¢¢ã å
$num¢¢ç é
,¢¢é è
DateTimeKind¢¢ê ú
.¢¢ú ù
Unspecified¢¢ù ®
)¢¢® ©
,¢¢© ™
$str¢¢´ ∞
,¢¢∞ ±
$str¢¢≤ ¿
,¢¢¿ ¡
null¢¢¬ ∆
,¢¢∆ «
new¢¢» À
DateTime¢¢Ã ‘
(¢¢‘ ’
$num¢¢’ ÷
,¢¢÷ ◊
$num¢¢ÿ Ÿ
,¢¢Ÿ ⁄
$num¢¢€ ‹
,¢¢‹ ›
$num¢¢ﬁ ﬂ
,¢¢ﬂ ‡
$num¢¢· ‚
,¢¢‚ „
$num¢¢‰ Â
,¢¢Â Ê
$num¢¢Á Ë
,¢¢Ë È
DateTimeKind¢¢Í ˆ
.¢¢ˆ ˜
Unspecified¢¢˜ Ç
)¢¢Ç É
}¢¢Ñ Ö
,¢¢Ö Ü
{
££ 
$num
££ 
,
££ 
null
££ 
,
££ 
new
££  #
DateTime
££$ ,
(
££, -
$num
££- .
,
££. /
$num
££0 1
,
££1 2
$num
££3 4
,
££4 5
$num
££6 7
,
££7 8
$num
££9 :
,
££: ;
$num
££< =
,
££= >
$num
££? @
,
££@ A
DateTimeKind
££B N
.
££N O
Unspecified
££O Z
)
££Z [
,
££[ \
$str
££] b
,
££b c
$num
££d f
,
££f g
null
££h l
,
££l m
new
££n q
DateTime
££r z
(
££z {
$num
££{ |
,
££| }
$num
££~ 
,££ Ä
$num££Å Ç
,££Ç É
$num££Ñ Ö
,££Ö Ü
$num££á à
,££à â
$num££ä ã
,££ã å
$num££ç é
,££é è
DateTimeKind££ê ú
.££ú ù
Unspecified££ù ®
)££® ©
,££© ™
$str££´ ∞
,££∞ ±
$str££≤ ¿
,££¿ ¡
null££¬ ∆
,££∆ «
new££» À
DateTime££Ã ‘
(££‘ ’
$num££’ ÷
,££÷ ◊
$num££ÿ Ÿ
,££Ÿ ⁄
$num££€ ‹
,££‹ ›
$num££ﬁ ﬂ
,££ﬂ ‡
$num££· ‚
,££‚ „
$num££‰ Â
,££Â Ê
$num££Á Ë
,££Ë È
DateTimeKind££Í ˆ
.££ˆ ˜
Unspecified££˜ Ç
)££Ç É
}££Ñ Ö
,££Ö Ü
{
§§ 
$num
§§ 
,
§§ 
null
§§ 
,
§§ 
new
§§  #
DateTime
§§$ ,
(
§§, -
$num
§§- .
,
§§. /
$num
§§0 1
,
§§1 2
$num
§§3 4
,
§§4 5
$num
§§6 7
,
§§7 8
$num
§§9 :
,
§§: ;
$num
§§< =
,
§§= >
$num
§§? @
,
§§@ A
DateTimeKind
§§B N
.
§§N O
Unspecified
§§O Z
)
§§Z [
,
§§[ \
$str
§§] b
,
§§b c
$num
§§d f
,
§§f g
null
§§h l
,
§§l m
new
§§n q
DateTime
§§r z
(
§§z {
$num
§§{ |
,
§§| }
$num
§§~ 
,§§ Ä
$num§§Å Ç
,§§Ç É
$num§§Ñ Ö
,§§Ö Ü
$num§§á à
,§§à â
$num§§ä ã
,§§ã å
$num§§ç é
,§§é è
DateTimeKind§§ê ú
.§§ú ù
Unspecified§§ù ®
)§§® ©
,§§© ™
$str§§´ ∞
,§§∞ ±
$str§§≤ ¿
,§§¿ ¡
null§§¬ ∆
,§§∆ «
new§§» À
DateTime§§Ã ‘
(§§‘ ’
$num§§’ ÷
,§§÷ ◊
$num§§ÿ Ÿ
,§§Ÿ ⁄
$num§§€ ‹
,§§‹ ›
$num§§ﬁ ﬂ
,§§ﬂ ‡
$num§§· ‚
,§§‚ „
$num§§‰ Â
,§§Â Ê
$num§§Á Ë
,§§Ë È
DateTimeKind§§Í ˆ
.§§ˆ ˜
Unspecified§§˜ Ç
)§§Ç É
}§§Ñ Ö
,§§Ö Ü
{
•• 
$num
•• 
,
•• 
null
•• 
,
•• 
new
••  #
DateTime
••$ ,
(
••, -
$num
••- .
,
••. /
$num
••0 1
,
••1 2
$num
••3 4
,
••4 5
$num
••6 7
,
••7 8
$num
••9 :
,
••: ;
$num
••< =
,
••= >
$num
••? @
,
••@ A
DateTimeKind
••B N
.
••N O
Unspecified
••O Z
)
••Z [
,
••[ \
$str
••] b
,
••b c
$num
••d f
,
••f g
null
••h l
,
••l m
new
••n q
DateTime
••r z
(
••z {
$num
••{ |
,
••| }
$num
••~ 
,•• Ä
$num••Å Ç
,••Ç É
$num••Ñ Ö
,••Ö Ü
$num••á à
,••à â
$num••ä ã
,••ã å
$num••ç é
,••é è
DateTimeKind••ê ú
.••ú ù
Unspecified••ù ®
)••® ©
,••© ™
$str••´ ∞
,••∞ ±
$str••≤ ¿
,••¿ ¡
null••¬ ∆
,••∆ «
new••» À
DateTime••Ã ‘
(••‘ ’
$num••’ ÷
,••÷ ◊
$num••ÿ Ÿ
,••Ÿ ⁄
$num••€ ‹
,••‹ ›
$num••ﬁ ﬂ
,••ﬂ ‡
$num••· ‚
,••‚ „
$num••‰ Â
,••Â Ê
$num••Á Ë
,••Ë È
DateTimeKind••Í ˆ
.••ˆ ˜
Unspecified••˜ Ç
)••Ç É
}••Ñ Ö
,••Ö Ü
{
¶¶ 
$num
¶¶ 
,
¶¶ 
null
¶¶ 
,
¶¶ 
new
¶¶  #
DateTime
¶¶$ ,
(
¶¶, -
$num
¶¶- .
,
¶¶. /
$num
¶¶0 1
,
¶¶1 2
$num
¶¶3 4
,
¶¶4 5
$num
¶¶6 7
,
¶¶7 8
$num
¶¶9 :
,
¶¶: ;
$num
¶¶< =
,
¶¶= >
$num
¶¶? @
,
¶¶@ A
DateTimeKind
¶¶B N
.
¶¶N O
Unspecified
¶¶O Z
)
¶¶Z [
,
¶¶[ \
$str
¶¶] b
,
¶¶b c
$num
¶¶d f
,
¶¶f g
null
¶¶h l
,
¶¶l m
new
¶¶n q
DateTime
¶¶r z
(
¶¶z {
$num
¶¶{ |
,
¶¶| }
$num
¶¶~ 
,¶¶ Ä
$num¶¶Å Ç
,¶¶Ç É
$num¶¶Ñ Ö
,¶¶Ö Ü
$num¶¶á à
,¶¶à â
$num¶¶ä ã
,¶¶ã å
$num¶¶ç é
,¶¶é è
DateTimeKind¶¶ê ú
.¶¶ú ù
Unspecified¶¶ù ®
)¶¶® ©
,¶¶© ™
$str¶¶´ ∞
,¶¶∞ ±
$str¶¶≤ ¿
,¶¶¿ ¡
null¶¶¬ ∆
,¶¶∆ «
new¶¶» À
DateTime¶¶Ã ‘
(¶¶‘ ’
$num¶¶’ ÷
,¶¶÷ ◊
$num¶¶ÿ Ÿ
,¶¶Ÿ ⁄
$num¶¶€ ‹
,¶¶‹ ›
$num¶¶ﬁ ﬂ
,¶¶ﬂ ‡
$num¶¶· ‚
,¶¶‚ „
$num¶¶‰ Â
,¶¶Â Ê
$num¶¶Á Ë
,¶¶Ë È
DateTimeKind¶¶Í ˆ
.¶¶ˆ ˜
Unspecified¶¶˜ Ç
)¶¶Ç É
}¶¶Ñ Ö
,¶¶Ö Ü
{
ßß 
$num
ßß 
,
ßß 
null
ßß 
,
ßß 
new
ßß  #
DateTime
ßß$ ,
(
ßß, -
$num
ßß- .
,
ßß. /
$num
ßß0 1
,
ßß1 2
$num
ßß3 4
,
ßß4 5
$num
ßß6 7
,
ßß7 8
$num
ßß9 :
,
ßß: ;
$num
ßß< =
,
ßß= >
$num
ßß? @
,
ßß@ A
DateTimeKind
ßßB N
.
ßßN O
Unspecified
ßßO Z
)
ßßZ [
,
ßß[ \
$str
ßß] a
,
ßßa b
$num
ßßc f
,
ßßf g
null
ßßh l
,
ßßl m
new
ßßn q
DateTime
ßßr z
(
ßßz {
$num
ßß{ |
,
ßß| }
$num
ßß~ 
,ßß Ä
$numßßÅ Ç
,ßßÇ É
$numßßÑ Ö
,ßßÖ Ü
$numßßá à
,ßßà â
$numßßä ã
,ßßã å
$numßßç é
,ßßé è
DateTimeKindßßê ú
.ßßú ù
Unspecifiedßßù ®
)ßß® ©
,ßß© ™
$strßß´ ∞
,ßß∞ ±
$strßß≤ º
,ßßº Ω
nullßßæ ¬
,ßß¬ √
newßßƒ «
DateTimeßß» –
(ßß– —
$numßß— “
,ßß“ ”
$numßß‘ ’
,ßß’ ÷
$numßß◊ ÿ
,ßßÿ Ÿ
$numßß⁄ €
,ßß€ ‹
$numßß› ﬁ
,ßßﬁ ﬂ
$numßß‡ ·
,ßß· ‚
$numßß„ ‰
,ßß‰ Â
DateTimeKindßßÊ Ú
.ßßÚ Û
UnspecifiedßßÛ ˛
)ßß˛ ˇ
}ßßÄ Å
,ßßÅ Ç
{
®® 
$num
®® 
,
®® 
null
®® 
,
®® 
new
®®  #
DateTime
®®$ ,
(
®®, -
$num
®®- .
,
®®. /
$num
®®0 1
,
®®1 2
$num
®®3 4
,
®®4 5
$num
®®6 7
,
®®7 8
$num
®®9 :
,
®®: ;
$num
®®< =
,
®®= >
$num
®®? @
,
®®@ A
DateTimeKind
®®B N
.
®®N O
Unspecified
®®O Z
)
®®Z [
,
®®[ \
$str
®®] b
,
®®b c
$num
®®d f
,
®®f g
null
®®h l
,
®®l m
new
®®n q
DateTime
®®r z
(
®®z {
$num
®®{ |
,
®®| }
$num
®®~ 
,®® Ä
$num®®Å Ç
,®®Ç É
$num®®Ñ Ö
,®®Ö Ü
$num®®á à
,®®à â
$num®®ä ã
,®®ã å
$num®®ç é
,®®é è
DateTimeKind®®ê ú
.®®ú ù
Unspecified®®ù ®
)®®® ©
,®®© ™
$str®®´ Ø
,®®Ø ∞
$str®®± æ
,®®æ ø
null®®¿ ƒ
,®®ƒ ≈
new®®∆ …
DateTime®®  “
(®®“ ”
$num®®” ‘
,®®‘ ’
$num®®÷ ◊
,®®◊ ÿ
$num®®Ÿ ⁄
,®®⁄ €
$num®®‹ ›
,®®› ﬁ
$num®®ﬂ ‡
,®®‡ ·
$num®®‚ „
,®®„ ‰
$num®®Â Ê
,®®Ê Á
DateTimeKind®®Ë Ù
.®®Ù ı
Unspecified®®ı Ä
)®®Ä Å
}®®Ç É
,®®É Ñ
{
©© 
$num
©© 
,
©© 
null
©© 
,
©© 
new
©©  #
DateTime
©©$ ,
(
©©, -
$num
©©- .
,
©©. /
$num
©©0 1
,
©©1 2
$num
©©3 4
,
©©4 5
$num
©©6 7
,
©©7 8
$num
©©9 :
,
©©: ;
$num
©©< =
,
©©= >
$num
©©? @
,
©©@ A
DateTimeKind
©©B N
.
©©N O
Unspecified
©©O Z
)
©©Z [
,
©©[ \
$str
©©] b
,
©©b c
$num
©©d g
,
©©g h
null
©©i m
,
©©m n
new
©©o r
DateTime
©©s {
(
©©{ |
$num
©©| }
,
©©} ~
$num©© Ä
,©©Ä Å
$num©©Ç É
,©©É Ñ
$num©©Ö Ü
,©©Ü á
$num©©à â
,©©â ä
$num©©ã å
,©©å ç
$num©©é è
,©©è ê
DateTimeKind©©ë ù
.©©ù û
Unspecified©©û ©
)©©© ™
,©©™ ´
$str©©¨ ∞
,©©∞ ±
$str©©≤ ∏
,©©∏ π
null©©∫ æ
,©©æ ø
new©©¿ √
DateTime©©ƒ Ã
(©©Ã Õ
$num©©Õ Œ
,©©Œ œ
$num©©– —
,©©— “
$num©©” ‘
,©©‘ ’
$num©©÷ ◊
,©©◊ ÿ
$num©©Ÿ ⁄
,©©⁄ €
$num©©‹ ›
,©©› ﬁ
$num©©ﬂ ‡
,©©‡ ·
DateTimeKind©©‚ Ó
.©©Ó Ô
Unspecified©©Ô ˙
)©©˙ ˚
}©©¸ ˝
,©©˝ ˛
{
™™ 
$num
™™ 
,
™™ 
null
™™ 
,
™™ 
new
™™  #
DateTime
™™$ ,
(
™™, -
$num
™™- .
,
™™. /
$num
™™0 1
,
™™1 2
$num
™™3 4
,
™™4 5
$num
™™6 7
,
™™7 8
$num
™™9 :
,
™™: ;
$num
™™< =
,
™™= >
$num
™™? @
,
™™@ A
DateTimeKind
™™B N
.
™™N O
Unspecified
™™O Z
)
™™Z [
,
™™[ \
$str
™™] a
,
™™a b
$num
™™c e
,
™™e f
null
™™g k
,
™™k l
new
™™m p
DateTime
™™q y
(
™™y z
$num
™™z {
,
™™{ |
$num
™™} ~
,
™™~ 
$num™™Ä Å
,™™Å Ç
$num™™É Ñ
,™™Ñ Ö
$num™™Ü á
,™™á à
$num™™â ä
,™™ä ã
$num™™å ç
,™™ç é
DateTimeKind™™è õ
.™™õ ú
Unspecified™™ú ß
)™™ß ®
,™™® ©
$str™™™ Ø
,™™Ø ∞
$str™™± ª
,™™ª º
null™™Ω ¡
,™™¡ ¬
new™™√ ∆
DateTime™™« œ
(™™œ –
$num™™– —
,™™— “
$num™™” ‘
,™™‘ ’
$num™™÷ ◊
,™™◊ ÿ
$num™™Ÿ ⁄
,™™⁄ €
$num™™‹ ›
,™™› ﬁ
$num™™ﬂ ‡
,™™‡ ·
$num™™‚ „
,™™„ ‰
DateTimeKind™™Â Ò
.™™Ò Ú
Unspecified™™Ú ˝
)™™˝ ˛
}™™ˇ Ä
,™™Ä Å
{
´´ 
$num
´´ 
,
´´ 
null
´´ 
,
´´ 
new
´´  #
DateTime
´´$ ,
(
´´, -
$num
´´- .
,
´´. /
$num
´´0 1
,
´´1 2
$num
´´3 4
,
´´4 5
$num
´´6 7
,
´´7 8
$num
´´9 :
,
´´: ;
$num
´´< =
,
´´= >
$num
´´? @
,
´´@ A
DateTimeKind
´´B N
.
´´N O
Unspecified
´´O Z
)
´´Z [
,
´´[ \
$str
´´] b
,
´´b c
$num
´´d g
,
´´g h
null
´´i m
,
´´m n
new
´´o r
DateTime
´´s {
(
´´{ |
$num
´´| }
,
´´} ~
$num´´ Ä
,´´Ä Å
$num´´Ç É
,´´É Ñ
$num´´Ö Ü
,´´Ü á
$num´´à â
,´´â ä
$num´´ã å
,´´å ç
$num´´é è
,´´è ê
DateTimeKind´´ë ù
.´´ù û
Unspecified´´û ©
)´´© ™
,´´™ ´
$str´´¨ ≤
,´´≤ ≥
$str´´¥ Ω
,´´Ω æ
null´´ø √
,´´√ ƒ
new´´≈ »
DateTime´´… —
(´´— “
$num´´“ ”
,´´” ‘
$num´´’ ÷
,´´÷ ◊
$num´´ÿ Ÿ
,´´Ÿ ⁄
$num´´€ ‹
,´´‹ ›
$num´´ﬁ ﬂ
,´´ﬂ ‡
$num´´· ‚
,´´‚ „
$num´´‰ Â
,´´Â Ê
DateTimeKind´´Á Û
.´´Û Ù
Unspecified´´Ù ˇ
)´´ˇ Ä
}´´Å Ç
,´´Ç É
{
¨¨ 
$num
¨¨ 
,
¨¨ 
null
¨¨ 
,
¨¨ 
new
¨¨  #
DateTime
¨¨$ ,
(
¨¨, -
$num
¨¨- .
,
¨¨. /
$num
¨¨0 1
,
¨¨1 2
$num
¨¨3 4
,
¨¨4 5
$num
¨¨6 7
,
¨¨7 8
$num
¨¨9 :
,
¨¨: ;
$num
¨¨< =
,
¨¨= >
$num
¨¨? @
,
¨¨@ A
DateTimeKind
¨¨B N
.
¨¨N O
Unspecified
¨¨O Z
)
¨¨Z [
,
¨¨[ \
$str
¨¨] b
,
¨¨b c
$num
¨¨d g
,
¨¨g h
null
¨¨i m
,
¨¨m n
new
¨¨o r
DateTime
¨¨s {
(
¨¨{ |
$num
¨¨| }
,
¨¨} ~
$num¨¨ Ä
,¨¨Ä Å
$num¨¨Ç É
,¨¨É Ñ
$num¨¨Ö Ü
,¨¨Ü á
$num¨¨à â
,¨¨â ä
$num¨¨ã å
,¨¨å ç
$num¨¨é è
,¨¨è ê
DateTimeKind¨¨ë ù
.¨¨ù û
Unspecified¨¨û ©
)¨¨© ™
,¨¨™ ´
$str¨¨¨ ∞
,¨¨∞ ±
$str¨¨≤ Ω
,¨¨Ω æ
null¨¨ø √
,¨¨√ ƒ
new¨¨≈ »
DateTime¨¨… —
(¨¨— “
$num¨¨“ ”
,¨¨” ‘
$num¨¨’ ÷
,¨¨÷ ◊
$num¨¨ÿ Ÿ
,¨¨Ÿ ⁄
$num¨¨€ ‹
,¨¨‹ ›
$num¨¨ﬁ ﬂ
,¨¨ﬂ ‡
$num¨¨· ‚
,¨¨‚ „
$num¨¨‰ Â
,¨¨Â Ê
DateTimeKind¨¨Á Û
.¨¨Û Ù
Unspecified¨¨Ù ˇ
)¨¨ˇ Ä
}¨¨Å Ç
,¨¨Ç É
{
≠≠ 
$num
≠≠ 
,
≠≠ 
null
≠≠ 
,
≠≠ 
new
≠≠  #
DateTime
≠≠$ ,
(
≠≠, -
$num
≠≠- .
,
≠≠. /
$num
≠≠0 1
,
≠≠1 2
$num
≠≠3 4
,
≠≠4 5
$num
≠≠6 7
,
≠≠7 8
$num
≠≠9 :
,
≠≠: ;
$num
≠≠< =
,
≠≠= >
$num
≠≠? @
,
≠≠@ A
DateTimeKind
≠≠B N
.
≠≠N O
Unspecified
≠≠O Z
)
≠≠Z [
,
≠≠[ \
$str
≠≠] b
,
≠≠b c
$num
≠≠d f
,
≠≠f g
null
≠≠h l
,
≠≠l m
new
≠≠n q
DateTime
≠≠r z
(
≠≠z {
$num
≠≠{ |
,
≠≠| }
$num
≠≠~ 
,≠≠ Ä
$num≠≠Å Ç
,≠≠Ç É
$num≠≠Ñ Ö
,≠≠Ö Ü
$num≠≠á à
,≠≠à â
$num≠≠ä ã
,≠≠ã å
$num≠≠ç é
,≠≠é è
DateTimeKind≠≠ê ú
.≠≠ú ù
Unspecified≠≠ù ®
)≠≠® ©
,≠≠© ™
$str≠≠´ Ø
,≠≠Ø ∞
$str≠≠± Ω
,≠≠Ω æ
null≠≠ø √
,≠≠√ ƒ
new≠≠≈ »
DateTime≠≠… —
(≠≠— “
$num≠≠“ ”
,≠≠” ‘
$num≠≠’ ÷
,≠≠÷ ◊
$num≠≠ÿ Ÿ
,≠≠Ÿ ⁄
$num≠≠€ ‹
,≠≠‹ ›
$num≠≠ﬁ ﬂ
,≠≠ﬂ ‡
$num≠≠· ‚
,≠≠‚ „
$num≠≠‰ Â
,≠≠Â Ê
DateTimeKind≠≠Á Û
.≠≠Û Ù
Unspecified≠≠Ù ˇ
)≠≠ˇ Ä
}≠≠Å Ç
,≠≠Ç É
{
ÆÆ 
$num
ÆÆ 
,
ÆÆ 
null
ÆÆ 
,
ÆÆ 
new
ÆÆ  #
DateTime
ÆÆ$ ,
(
ÆÆ, -
$num
ÆÆ- .
,
ÆÆ. /
$num
ÆÆ0 1
,
ÆÆ1 2
$num
ÆÆ3 4
,
ÆÆ4 5
$num
ÆÆ6 7
,
ÆÆ7 8
$num
ÆÆ9 :
,
ÆÆ: ;
$num
ÆÆ< =
,
ÆÆ= >
$num
ÆÆ? @
,
ÆÆ@ A
DateTimeKind
ÆÆB N
.
ÆÆN O
Unspecified
ÆÆO Z
)
ÆÆZ [
,
ÆÆ[ \
$str
ÆÆ] b
,
ÆÆb c
$num
ÆÆd g
,
ÆÆg h
null
ÆÆi m
,
ÆÆm n
new
ÆÆo r
DateTime
ÆÆs {
(
ÆÆ{ |
$num
ÆÆ| }
,
ÆÆ} ~
$numÆÆ Ä
,ÆÆÄ Å
$numÆÆÇ É
,ÆÆÉ Ñ
$numÆÆÖ Ü
,ÆÆÜ á
$numÆÆà â
,ÆÆâ ä
$numÆÆã å
,ÆÆå ç
$numÆÆé è
,ÆÆè ê
DateTimeKindÆÆë ù
.ÆÆù û
UnspecifiedÆÆû ©
)ÆÆ© ™
,ÆÆ™ ´
$strÆÆ¨ ∞
,ÆÆ∞ ±
$strÆÆ≤ ¿
,ÆÆ¿ ¡
nullÆÆ¬ ∆
,ÆÆ∆ «
newÆÆ» À
DateTimeÆÆÃ ‘
(ÆÆ‘ ’
$numÆÆ’ ÷
,ÆÆ÷ ◊
$numÆÆÿ Ÿ
,ÆÆŸ ⁄
$numÆÆ€ ‹
,ÆÆ‹ ›
$numÆÆﬁ ﬂ
,ÆÆﬂ ‡
$numÆÆ· ‚
,ÆÆ‚ „
$numÆÆ‰ Â
,ÆÆÂ Ê
$numÆÆÁ Ë
,ÆÆË È
DateTimeKindÆÆÍ ˆ
.ÆÆˆ ˜
UnspecifiedÆÆ˜ Ç
)ÆÆÇ É
}ÆÆÑ Ö
,ÆÆÖ Ü
{
ØØ 
$num
ØØ 
,
ØØ 
null
ØØ 
,
ØØ 
new
ØØ  #
DateTime
ØØ$ ,
(
ØØ, -
$num
ØØ- .
,
ØØ. /
$num
ØØ0 1
,
ØØ1 2
$num
ØØ3 4
,
ØØ4 5
$num
ØØ6 7
,
ØØ7 8
$num
ØØ9 :
,
ØØ: ;
$num
ØØ< =
,
ØØ= >
$num
ØØ? @
,
ØØ@ A
DateTimeKind
ØØB N
.
ØØN O
Unspecified
ØØO Z
)
ØØZ [
,
ØØ[ \
$str
ØØ] b
,
ØØb c
$num
ØØd g
,
ØØg h
null
ØØi m
,
ØØm n
new
ØØo r
DateTime
ØØs {
(
ØØ{ |
$num
ØØ| }
,
ØØ} ~
$numØØ Ä
,ØØÄ Å
$numØØÇ É
,ØØÉ Ñ
$numØØÖ Ü
,ØØÜ á
$numØØà â
,ØØâ ä
$numØØã å
,ØØå ç
$numØØé è
,ØØè ê
DateTimeKindØØë ù
.ØØù û
UnspecifiedØØû ©
)ØØ© ™
,ØØ™ ´
$strØØ¨ ∞
,ØØ∞ ±
$strØØ≤ ƒ
,ØØƒ ≈
nullØØ∆  
,ØØ  À
newØØÃ œ
DateTimeØØ– ÿ
(ØØÿ Ÿ
$numØØŸ ⁄
,ØØ⁄ €
$numØØ‹ ›
,ØØ› ﬁ
$numØØﬂ ‡
,ØØ‡ ·
$numØØ‚ „
,ØØ„ ‰
$numØØÂ Ê
,ØØÊ Á
$numØØË È
,ØØÈ Í
$numØØÎ Ï
,ØØÏ Ì
DateTimeKindØØÓ ˙
.ØØ˙ ˚
UnspecifiedØØ˚ Ü
)ØØÜ á
}ØØà â
,ØØâ ä
{
∞∞ 
$num
∞∞ 
,
∞∞ 
null
∞∞ 
,
∞∞ 
new
∞∞  #
DateTime
∞∞$ ,
(
∞∞, -
$num
∞∞- .
,
∞∞. /
$num
∞∞0 1
,
∞∞1 2
$num
∞∞3 4
,
∞∞4 5
$num
∞∞6 7
,
∞∞7 8
$num
∞∞9 :
,
∞∞: ;
$num
∞∞< =
,
∞∞= >
$num
∞∞? @
,
∞∞@ A
DateTimeKind
∞∞B N
.
∞∞N O
Unspecified
∞∞O Z
)
∞∞Z [
,
∞∞[ \
$str
∞∞] b
,
∞∞b c
$num
∞∞d g
,
∞∞g h
null
∞∞i m
,
∞∞m n
new
∞∞o r
DateTime
∞∞s {
(
∞∞{ |
$num
∞∞| }
,
∞∞} ~
$num∞∞ Ä
,∞∞Ä Å
$num∞∞Ç É
,∞∞É Ñ
$num∞∞Ö Ü
,∞∞Ü á
$num∞∞à â
,∞∞â ä
$num∞∞ã å
,∞∞å ç
$num∞∞é è
,∞∞è ê
DateTimeKind∞∞ë ù
.∞∞ù û
Unspecified∞∞û ©
)∞∞© ™
,∞∞™ ´
$str∞∞¨ ±
,∞∞± ≤
$str∞∞≥ ∫
,∞∞∫ ª
null∞∞º ¿
,∞∞¿ ¡
new∞∞¬ ≈
DateTime∞∞∆ Œ
(∞∞Œ œ
$num∞∞œ –
,∞∞– —
$num∞∞“ ”
,∞∞” ‘
$num∞∞’ ÷
,∞∞÷ ◊
$num∞∞ÿ Ÿ
,∞∞Ÿ ⁄
$num∞∞€ ‹
,∞∞‹ ›
$num∞∞ﬁ ﬂ
,∞∞ﬂ ‡
$num∞∞· ‚
,∞∞‚ „
DateTimeKind∞∞‰ 
.∞∞ Ò
Unspecified∞∞Ò ¸
)∞∞¸ ˝
}∞∞˛ ˇ
,∞∞ˇ Ä
{
±± 
$num
±± 
,
±± 
null
±± 
,
±± 
new
±±  #
DateTime
±±$ ,
(
±±, -
$num
±±- .
,
±±. /
$num
±±0 1
,
±±1 2
$num
±±3 4
,
±±4 5
$num
±±6 7
,
±±7 8
$num
±±9 :
,
±±: ;
$num
±±< =
,
±±= >
$num
±±? @
,
±±@ A
DateTimeKind
±±B N
.
±±N O
Unspecified
±±O Z
)
±±Z [
,
±±[ \
$str
±±] b
,
±±b c
$num
±±d g
,
±±g h
null
±±i m
,
±±m n
new
±±o r
DateTime
±±s {
(
±±{ |
$num
±±| }
,
±±} ~
$num±± Ä
,±±Ä Å
$num±±Ç É
,±±É Ñ
$num±±Ö Ü
,±±Ü á
$num±±à â
,±±â ä
$num±±ã å
,±±å ç
$num±±é è
,±±è ê
DateTimeKind±±ë ù
.±±ù û
Unspecified±±û ©
)±±© ™
,±±™ ´
$str±±¨ ≤
,±±≤ ≥
$str±±¥ Ω
,±±Ω æ
null±±ø √
,±±√ ƒ
new±±≈ »
DateTime±±… —
(±±— “
$num±±“ ”
,±±” ‘
$num±±’ ÷
,±±÷ ◊
$num±±ÿ Ÿ
,±±Ÿ ⁄
$num±±€ ‹
,±±‹ ›
$num±±ﬁ ﬂ
,±±ﬂ ‡
$num±±· ‚
,±±‚ „
$num±±‰ Â
,±±Â Ê
DateTimeKind±±Á Û
.±±Û Ù
Unspecified±±Ù ˇ
)±±ˇ Ä
}±±Å Ç
,±±Ç É
{
≤≤ 
$num
≤≤ 
,
≤≤ 
null
≤≤ 
,
≤≤ 
new
≤≤  #
DateTime
≤≤$ ,
(
≤≤, -
$num
≤≤- .
,
≤≤. /
$num
≤≤0 1
,
≤≤1 2
$num
≤≤3 4
,
≤≤4 5
$num
≤≤6 7
,
≤≤7 8
$num
≤≤9 :
,
≤≤: ;
$num
≤≤< =
,
≤≤= >
$num
≤≤? @
,
≤≤@ A
DateTimeKind
≤≤B N
.
≤≤N O
Unspecified
≤≤O Z
)
≤≤Z [
,
≤≤[ \
$str
≤≤] b
,
≤≤b c
$num
≤≤d g
,
≤≤g h
null
≤≤i m
,
≤≤m n
new
≤≤o r
DateTime
≤≤s {
(
≤≤{ |
$num
≤≤| }
,
≤≤} ~
$num≤≤ Ä
,≤≤Ä Å
$num≤≤Ç É
,≤≤É Ñ
$num≤≤Ö Ü
,≤≤Ü á
$num≤≤à â
,≤≤â ä
$num≤≤ã å
,≤≤å ç
$num≤≤é è
,≤≤è ê
DateTimeKind≤≤ë ù
.≤≤ù û
Unspecified≤≤û ©
)≤≤© ™
,≤≤™ ´
$str≤≤¨ ∞
,≤≤∞ ±
$str≤≤≤ ø
,≤≤ø ¿
null≤≤¡ ≈
,≤≤≈ ∆
new≤≤«  
DateTime≤≤À ”
(≤≤” ‘
$num≤≤‘ ’
,≤≤’ ÷
$num≤≤◊ ÿ
,≤≤ÿ Ÿ
$num≤≤⁄ €
,≤≤€ ‹
$num≤≤› ﬁ
,≤≤ﬁ ﬂ
$num≤≤‡ ·
,≤≤· ‚
$num≤≤„ ‰
,≤≤‰ Â
$num≤≤Ê Á
,≤≤Á Ë
DateTimeKind≤≤È ı
.≤≤ı ˆ
Unspecified≤≤ˆ Å
)≤≤Å Ç
}≤≤É Ñ
,≤≤Ñ Ö
{
≥≥ 
$num
≥≥ 
,
≥≥ 
null
≥≥ 
,
≥≥ 
new
≥≥  #
DateTime
≥≥$ ,
(
≥≥, -
$num
≥≥- .
,
≥≥. /
$num
≥≥0 1
,
≥≥1 2
$num
≥≥3 4
,
≥≥4 5
$num
≥≥6 7
,
≥≥7 8
$num
≥≥9 :
,
≥≥: ;
$num
≥≥< =
,
≥≥= >
$num
≥≥? @
,
≥≥@ A
DateTimeKind
≥≥B N
.
≥≥N O
Unspecified
≥≥O Z
)
≥≥Z [
,
≥≥[ \
$str
≥≥] b
,
≥≥b c
$num
≥≥d g
,
≥≥g h
null
≥≥i m
,
≥≥m n
new
≥≥o r
DateTime
≥≥s {
(
≥≥{ |
$num
≥≥| }
,
≥≥} ~
$num≥≥ Ä
,≥≥Ä Å
$num≥≥Ç É
,≥≥É Ñ
$num≥≥Ö Ü
,≥≥Ü á
$num≥≥à â
,≥≥â ä
$num≥≥ã å
,≥≥å ç
$num≥≥é è
,≥≥è ê
DateTimeKind≥≥ë ù
.≥≥ù û
Unspecified≥≥û ©
)≥≥© ™
,≥≥™ ´
$str≥≥¨ ∞
,≥≥∞ ±
$str≥≥≤ √
,≥≥√ ƒ
null≥≥≈ …
,≥≥…  
new≥≥À Œ
DateTime≥≥œ ◊
(≥≥◊ ÿ
$num≥≥ÿ Ÿ
,≥≥Ÿ ⁄
$num≥≥€ ‹
,≥≥‹ ›
$num≥≥ﬁ ﬂ
,≥≥ﬂ ‡
$num≥≥· ‚
,≥≥‚ „
$num≥≥‰ Â
,≥≥Â Ê
$num≥≥Á Ë
,≥≥Ë È
$num≥≥Í Î
,≥≥Î Ï
DateTimeKind≥≥Ì ˘
.≥≥˘ ˙
Unspecified≥≥˙ Ö
)≥≥Ö Ü
}≥≥á à
,≥≥à â
{
¥¥ 
$num
¥¥ 
,
¥¥ 
null
¥¥ 
,
¥¥ 
new
¥¥  #
DateTime
¥¥$ ,
(
¥¥, -
$num
¥¥- .
,
¥¥. /
$num
¥¥0 1
,
¥¥1 2
$num
¥¥3 4
,
¥¥4 5
$num
¥¥6 7
,
¥¥7 8
$num
¥¥9 :
,
¥¥: ;
$num
¥¥< =
,
¥¥= >
$num
¥¥? @
,
¥¥@ A
DateTimeKind
¥¥B N
.
¥¥N O
Unspecified
¥¥O Z
)
¥¥Z [
,
¥¥[ \
$str
¥¥] b
,
¥¥b c
$num
¥¥d g
,
¥¥g h
null
¥¥i m
,
¥¥m n
new
¥¥o r
DateTime
¥¥s {
(
¥¥{ |
$num
¥¥| }
,
¥¥} ~
$num¥¥ Ä
,¥¥Ä Å
$num¥¥Ç É
,¥¥É Ñ
$num¥¥Ö Ü
,¥¥Ü á
$num¥¥à â
,¥¥â ä
$num¥¥ã å
,¥¥å ç
$num¥¥é è
,¥¥è ê
DateTimeKind¥¥ë ù
.¥¥ù û
Unspecified¥¥û ©
)¥¥© ™
,¥¥™ ´
$str¥¥¨ ∞
,¥¥∞ ±
$str¥¥≤ ƒ
,¥¥ƒ ≈
null¥¥∆  
,¥¥  À
new¥¥Ã œ
DateTime¥¥– ÿ
(¥¥ÿ Ÿ
$num¥¥Ÿ ⁄
,¥¥⁄ €
$num¥¥‹ ›
,¥¥› ﬁ
$num¥¥ﬂ ‡
,¥¥‡ ·
$num¥¥‚ „
,¥¥„ ‰
$num¥¥Â Ê
,¥¥Ê Á
$num¥¥Ë È
,¥¥È Í
$num¥¥Î Ï
,¥¥Ï Ì
DateTimeKind¥¥Ó ˙
.¥¥˙ ˚
Unspecified¥¥˚ Ü
)¥¥Ü á
}¥¥à â
,¥¥â ä
{
µµ 
$num
µµ 
,
µµ 
null
µµ 
,
µµ 
new
µµ  #
DateTime
µµ$ ,
(
µµ, -
$num
µµ- .
,
µµ. /
$num
µµ0 1
,
µµ1 2
$num
µµ3 4
,
µµ4 5
$num
µµ6 7
,
µµ7 8
$num
µµ9 :
,
µµ: ;
$num
µµ< =
,
µµ= >
$num
µµ? @
,
µµ@ A
DateTimeKind
µµB N
.
µµN O
Unspecified
µµO Z
)
µµZ [
,
µµ[ \
$str
µµ] b
,
µµb c
$num
µµd g
,
µµg h
null
µµi m
,
µµm n
new
µµo r
DateTime
µµs {
(
µµ{ |
$num
µµ| }
,
µµ} ~
$numµµ Ä
,µµÄ Å
$numµµÇ É
,µµÉ Ñ
$numµµÖ Ü
,µµÜ á
$numµµà â
,µµâ ä
$numµµã å
,µµå ç
$numµµé è
,µµè ê
DateTimeKindµµë ù
.µµù û
Unspecifiedµµû ©
)µµ© ™
,µµ™ ´
$strµµ¨ ±
,µµ± ≤
$strµµ≥ ≈
,µµ≈ ∆
nullµµ« À
,µµÀ Ã
newµµÕ –
DateTimeµµ— Ÿ
(µµŸ ⁄
$numµµ⁄ €
,µµ€ ‹
$numµµ› ﬁ
,µµﬁ ﬂ
$numµµ‡ ·
,µµ· ‚
$numµµ„ ‰
,µµ‰ Â
$numµµÊ Á
,µµÁ Ë
$numµµÈ Í
,µµÍ Î
$numµµÏ Ì
,µµÌ Ó
DateTimeKindµµÔ ˚
.µµ˚ ¸
Unspecifiedµµ¸ á
)µµá à
}µµâ ä
,µµä ã
{
∂∂ 
$num
∂∂ 
,
∂∂ 
null
∂∂ 
,
∂∂ 
new
∂∂  #
DateTime
∂∂$ ,
(
∂∂, -
$num
∂∂- .
,
∂∂. /
$num
∂∂0 1
,
∂∂1 2
$num
∂∂3 4
,
∂∂4 5
$num
∂∂6 7
,
∂∂7 8
$num
∂∂9 :
,
∂∂: ;
$num
∂∂< =
,
∂∂= >
$num
∂∂? @
,
∂∂@ A
DateTimeKind
∂∂B N
.
∂∂N O
Unspecified
∂∂O Z
)
∂∂Z [
,
∂∂[ \
$str
∂∂] b
,
∂∂b c
$num
∂∂d g
,
∂∂g h
null
∂∂i m
,
∂∂m n
new
∂∂o r
DateTime
∂∂s {
(
∂∂{ |
$num
∂∂| }
,
∂∂} ~
$num∂∂ Ä
,∂∂Ä Å
$num∂∂Ç É
,∂∂É Ñ
$num∂∂Ö Ü
,∂∂Ü á
$num∂∂à â
,∂∂â ä
$num∂∂ã å
,∂∂å ç
$num∂∂é è
,∂∂è ê
DateTimeKind∂∂ë ù
.∂∂ù û
Unspecified∂∂û ©
)∂∂© ™
,∂∂™ ´
$str∂∂¨ µ
,∂∂µ ∂
$str∂∂∑ ∆
,∂∂∆ «
null∂∂» Ã
,∂∂Ã Õ
new∂∂Œ —
DateTime∂∂“ ⁄
(∂∂⁄ €
$num∂∂€ ‹
,∂∂‹ ›
$num∂∂ﬁ ﬂ
,∂∂ﬂ ‡
$num∂∂· ‚
,∂∂‚ „
$num∂∂‰ Â
,∂∂Â Ê
$num∂∂Á Ë
,∂∂Ë È
$num∂∂Í Î
,∂∂Î Ï
$num∂∂Ì Ó
,∂∂Ó Ô
DateTimeKind∂∂ ¸
.∂∂¸ ˝
Unspecified∂∂˝ à
)∂∂à â
}∂∂ä ã
,∂∂ã å
{
∑∑ 
$num
∑∑ 
,
∑∑ 
null
∑∑ 
,
∑∑ 
new
∑∑  #
DateTime
∑∑$ ,
(
∑∑, -
$num
∑∑- .
,
∑∑. /
$num
∑∑0 1
,
∑∑1 2
$num
∑∑3 4
,
∑∑4 5
$num
∑∑6 7
,
∑∑7 8
$num
∑∑9 :
,
∑∑: ;
$num
∑∑< =
,
∑∑= >
$num
∑∑? @
,
∑∑@ A
DateTimeKind
∑∑B N
.
∑∑N O
Unspecified
∑∑O Z
)
∑∑Z [
,
∑∑[ \
$str
∑∑] b
,
∑∑b c
$num
∑∑d g
,
∑∑g h
null
∑∑i m
,
∑∑m n
new
∑∑o r
DateTime
∑∑s {
(
∑∑{ |
$num
∑∑| }
,
∑∑} ~
$num∑∑ Ä
,∑∑Ä Å
$num∑∑Ç É
,∑∑É Ñ
$num∑∑Ö Ü
,∑∑Ü á
$num∑∑à â
,∑∑â ä
$num∑∑ã å
,∑∑å ç
$num∑∑é è
,∑∑è ê
DateTimeKind∑∑ë ù
.∑∑ù û
Unspecified∑∑û ©
)∑∑© ™
,∑∑™ ´
$str∑∑¨ ∞
,∑∑∞ ±
$str∑∑≤ ¿
,∑∑¿ ¡
null∑∑¬ ∆
,∑∑∆ «
new∑∑» À
DateTime∑∑Ã ‘
(∑∑‘ ’
$num∑∑’ ÷
,∑∑÷ ◊
$num∑∑ÿ Ÿ
,∑∑Ÿ ⁄
$num∑∑€ ‹
,∑∑‹ ›
$num∑∑ﬁ ﬂ
,∑∑ﬂ ‡
$num∑∑· ‚
,∑∑‚ „
$num∑∑‰ Â
,∑∑Â Ê
$num∑∑Á Ë
,∑∑Ë È
DateTimeKind∑∑Í ˆ
.∑∑ˆ ˜
Unspecified∑∑˜ Ç
)∑∑Ç É
}∑∑Ñ Ö
,∑∑Ö Ü
{
∏∏ 
$num
∏∏ 
,
∏∏ 
null
∏∏ 
,
∏∏ 
new
∏∏  #
DateTime
∏∏$ ,
(
∏∏, -
$num
∏∏- .
,
∏∏. /
$num
∏∏0 1
,
∏∏1 2
$num
∏∏3 4
,
∏∏4 5
$num
∏∏6 7
,
∏∏7 8
$num
∏∏9 :
,
∏∏: ;
$num
∏∏< =
,
∏∏= >
$num
∏∏? @
,
∏∏@ A
DateTimeKind
∏∏B N
.
∏∏N O
Unspecified
∏∏O Z
)
∏∏Z [
,
∏∏[ \
$str
∏∏] b
,
∏∏b c
$num
∏∏d g
,
∏∏g h
null
∏∏i m
,
∏∏m n
new
∏∏o r
DateTime
∏∏s {
(
∏∏{ |
$num
∏∏| }
,
∏∏} ~
$num∏∏ Ä
,∏∏Ä Å
$num∏∏Ç É
,∏∏É Ñ
$num∏∏Ö Ü
,∏∏Ü á
$num∏∏à â
,∏∏â ä
$num∏∏ã å
,∏∏å ç
$num∏∏é è
,∏∏è ê
DateTimeKind∏∏ë ù
.∏∏ù û
Unspecified∏∏û ©
)∏∏© ™
,∏∏™ ´
$str∏∏¨ ∞
,∏∏∞ ±
$str∏∏≤ æ
,∏∏æ ø
null∏∏¿ ƒ
,∏∏ƒ ≈
new∏∏∆ …
DateTime∏∏  “
(∏∏“ ”
$num∏∏” ‘
,∏∏‘ ’
$num∏∏÷ ◊
,∏∏◊ ÿ
$num∏∏Ÿ ⁄
,∏∏⁄ €
$num∏∏‹ ›
,∏∏› ﬁ
$num∏∏ﬂ ‡
,∏∏‡ ·
$num∏∏‚ „
,∏∏„ ‰
$num∏∏Â Ê
,∏∏Ê Á
DateTimeKind∏∏Ë Ù
.∏∏Ù ı
Unspecified∏∏ı Ä
)∏∏Ä Å
}∏∏Ç É
,∏∏É Ñ
{
ππ 
$num
ππ 
,
ππ 
null
ππ 
,
ππ 
new
ππ  #
DateTime
ππ$ ,
(
ππ, -
$num
ππ- .
,
ππ. /
$num
ππ0 1
,
ππ1 2
$num
ππ3 4
,
ππ4 5
$num
ππ6 7
,
ππ7 8
$num
ππ9 :
,
ππ: ;
$num
ππ< =
,
ππ= >
$num
ππ? @
,
ππ@ A
DateTimeKind
ππB N
.
ππN O
Unspecified
ππO Z
)
ππZ [
,
ππ[ \
$str
ππ] b
,
ππb c
$num
ππd g
,
ππg h
null
ππi m
,
ππm n
new
ππo r
DateTime
ππs {
(
ππ{ |
$num
ππ| }
,
ππ} ~
$numππ Ä
,ππÄ Å
$numππÇ É
,ππÉ Ñ
$numππÖ Ü
,ππÜ á
$numππà â
,ππâ ä
$numππã å
,ππå ç
$numππé è
,ππè ê
DateTimeKindππë ù
.ππù û
Unspecifiedππû ©
)ππ© ™
,ππ™ ´
$strππ¨ ∞
,ππ∞ ±
$strππ≤ Ω
,ππΩ æ
nullππø √
,ππ√ ƒ
newππ≈ »
DateTimeππ… —
(ππ— “
$numππ“ ”
,ππ” ‘
$numππ’ ÷
,ππ÷ ◊
$numππÿ Ÿ
,ππŸ ⁄
$numππ€ ‹
,ππ‹ ›
$numππﬁ ﬂ
,ππﬂ ‡
$numππ· ‚
,ππ‚ „
$numππ‰ Â
,ππÂ Ê
DateTimeKindππÁ Û
.ππÛ Ù
UnspecifiedππÙ ˇ
)ππˇ Ä
}ππÅ Ç
,ππÇ É
{
∫∫ 
$num
∫∫ 
,
∫∫ 
null
∫∫ 
,
∫∫ 
new
∫∫  #
DateTime
∫∫$ ,
(
∫∫, -
$num
∫∫- .
,
∫∫. /
$num
∫∫0 1
,
∫∫1 2
$num
∫∫3 4
,
∫∫4 5
$num
∫∫6 7
,
∫∫7 8
$num
∫∫9 :
,
∫∫: ;
$num
∫∫< =
,
∫∫= >
$num
∫∫? @
,
∫∫@ A
DateTimeKind
∫∫B N
.
∫∫N O
Unspecified
∫∫O Z
)
∫∫Z [
,
∫∫[ \
$str
∫∫] b
,
∫∫b c
$num
∫∫d g
,
∫∫g h
null
∫∫i m
,
∫∫m n
new
∫∫o r
DateTime
∫∫s {
(
∫∫{ |
$num
∫∫| }
,
∫∫} ~
$num∫∫ Ä
,∫∫Ä Å
$num∫∫Ç É
,∫∫É Ñ
$num∫∫Ö Ü
,∫∫Ü á
$num∫∫à â
,∫∫â ä
$num∫∫ã å
,∫∫å ç
$num∫∫é è
,∫∫è ê
DateTimeKind∫∫ë ù
.∫∫ù û
Unspecified∫∫û ©
)∫∫© ™
,∫∫™ ´
$str∫∫¨ ∞
,∫∫∞ ±
$str∫∫≤ «
,∫∫« »
null∫∫… Õ
,∫∫Õ Œ
new∫∫œ “
DateTime∫∫” €
(∫∫€ ‹
$num∫∫‹ ›
,∫∫› ﬁ
$num∫∫ﬂ ‡
,∫∫‡ ·
$num∫∫‚ „
,∫∫„ ‰
$num∫∫Â Ê
,∫∫Ê Á
$num∫∫Ë È
,∫∫È Í
$num∫∫Î Ï
,∫∫Ï Ì
$num∫∫Ó Ô
,∫∫Ô 
DateTimeKind∫∫Ò ˝
.∫∫˝ ˛
Unspecified∫∫˛ â
)∫∫â ä
}∫∫ã å
,∫∫å ç
{
ªª 
$num
ªª 
,
ªª 
null
ªª 
,
ªª 
new
ªª  #
DateTime
ªª$ ,
(
ªª, -
$num
ªª- .
,
ªª. /
$num
ªª0 1
,
ªª1 2
$num
ªª3 4
,
ªª4 5
$num
ªª6 7
,
ªª7 8
$num
ªª9 :
,
ªª: ;
$num
ªª< =
,
ªª= >
$num
ªª? @
,
ªª@ A
DateTimeKind
ªªB N
.
ªªN O
Unspecified
ªªO Z
)
ªªZ [
,
ªª[ \
$str
ªª] b
,
ªªb c
$num
ªªd g
,
ªªg h
null
ªªi m
,
ªªm n
new
ªªo r
DateTime
ªªs {
(
ªª{ |
$num
ªª| }
,
ªª} ~
$numªª Ä
,ªªÄ Å
$numªªÇ É
,ªªÉ Ñ
$numªªÖ Ü
,ªªÜ á
$numªªà â
,ªªâ ä
$numªªã å
,ªªå ç
$numªªé è
,ªªè ê
DateTimeKindªªë ù
.ªªù û
Unspecifiedªªû ©
)ªª© ™
,ªª™ ´
$strªª¨ ∞
,ªª∞ ±
$strªª≤ Ω
,ªªΩ æ
nullªªø √
,ªª√ ƒ
newªª≈ »
DateTimeªª… —
(ªª— “
$numªª“ ”
,ªª” ‘
$numªª’ ÷
,ªª÷ ◊
$numªªÿ Ÿ
,ªªŸ ⁄
$numªª€ ‹
,ªª‹ ›
$numªªﬁ ﬂ
,ªªﬂ ‡
$numªª· ‚
,ªª‚ „
$numªª‰ Â
,ªªÂ Ê
DateTimeKindªªÁ Û
.ªªÛ Ù
UnspecifiedªªÙ ˇ
)ªªˇ Ä
}ªªÅ Ç
,ªªÇ É
{
ºº 
$num
ºº 
,
ºº 
null
ºº 
,
ºº 
new
ºº  #
DateTime
ºº$ ,
(
ºº, -
$num
ºº- .
,
ºº. /
$num
ºº0 1
,
ºº1 2
$num
ºº3 4
,
ºº4 5
$num
ºº6 7
,
ºº7 8
$num
ºº9 :
,
ºº: ;
$num
ºº< =
,
ºº= >
$num
ºº? @
,
ºº@ A
DateTimeKind
ººB N
.
ººN O
Unspecified
ººO Z
)
ººZ [
,
ºº[ \
$str
ºº] b
,
ººb c
$num
ººd g
,
ººg h
null
ººi m
,
ººm n
new
ººo r
DateTime
ººs {
(
ºº{ |
$num
ºº| }
,
ºº} ~
$numºº Ä
,ººÄ Å
$numººÇ É
,ººÉ Ñ
$numººÖ Ü
,ººÜ á
$numººà â
,ººâ ä
$numººã å
,ººå ç
$numººé è
,ººè ê
DateTimeKindººë ù
.ººù û
Unspecifiedººû ©
)ºº© ™
,ºº™ ´
$strºº¨ ±
,ºº± ≤
$strºº≥ æ
,ººæ ø
nullºº¿ ƒ
,ººƒ ≈
newºº∆ …
DateTimeºº  “
(ºº“ ”
$numºº” ‘
,ºº‘ ’
$numºº÷ ◊
,ºº◊ ÿ
$numººŸ ⁄
,ºº⁄ €
$numºº‹ ›
,ºº› ﬁ
$numººﬂ ‡
,ºº‡ ·
$numºº‚ „
,ºº„ ‰
$numººÂ Ê
,ººÊ Á
DateTimeKindººË Ù
.ººÙ ı
Unspecifiedººı Ä
)ººÄ Å
}ººÇ É
,ººÉ Ñ
{
ΩΩ 
$num
ΩΩ 
,
ΩΩ 
null
ΩΩ 
,
ΩΩ 
new
ΩΩ  #
DateTime
ΩΩ$ ,
(
ΩΩ, -
$num
ΩΩ- .
,
ΩΩ. /
$num
ΩΩ0 1
,
ΩΩ1 2
$num
ΩΩ3 4
,
ΩΩ4 5
$num
ΩΩ6 7
,
ΩΩ7 8
$num
ΩΩ9 :
,
ΩΩ: ;
$num
ΩΩ< =
,
ΩΩ= >
$num
ΩΩ? @
,
ΩΩ@ A
DateTimeKind
ΩΩB N
.
ΩΩN O
Unspecified
ΩΩO Z
)
ΩΩZ [
,
ΩΩ[ \
$str
ΩΩ] b
,
ΩΩb c
$num
ΩΩd g
,
ΩΩg h
null
ΩΩi m
,
ΩΩm n
new
ΩΩo r
DateTime
ΩΩs {
(
ΩΩ{ |
$num
ΩΩ| }
,
ΩΩ} ~
$numΩΩ Ä
,ΩΩÄ Å
$numΩΩÇ É
,ΩΩÉ Ñ
$numΩΩÖ Ü
,ΩΩÜ á
$numΩΩà â
,ΩΩâ ä
$numΩΩã å
,ΩΩå ç
$numΩΩé è
,ΩΩè ê
DateTimeKindΩΩë ù
.ΩΩù û
UnspecifiedΩΩû ©
)ΩΩ© ™
,ΩΩ™ ´
$strΩΩ¨ ±
,ΩΩ± ≤
$strΩΩ≥ Ω
,ΩΩΩ æ
nullΩΩø √
,ΩΩ√ ƒ
newΩΩ≈ »
DateTimeΩΩ… —
(ΩΩ— “
$numΩΩ“ ”
,ΩΩ” ‘
$numΩΩ’ ÷
,ΩΩ÷ ◊
$numΩΩÿ Ÿ
,ΩΩŸ ⁄
$numΩΩ€ ‹
,ΩΩ‹ ›
$numΩΩﬁ ﬂ
,ΩΩﬂ ‡
$numΩΩ· ‚
,ΩΩ‚ „
$numΩΩ‰ Â
,ΩΩÂ Ê
DateTimeKindΩΩÁ Û
.ΩΩÛ Ù
UnspecifiedΩΩÙ ˇ
)ΩΩˇ Ä
}ΩΩÅ Ç
,ΩΩÇ É
{
ææ 
$num
ææ 
,
ææ 
null
ææ 
,
ææ 
new
ææ  #
DateTime
ææ$ ,
(
ææ, -
$num
ææ- .
,
ææ. /
$num
ææ0 1
,
ææ1 2
$num
ææ3 4
,
ææ4 5
$num
ææ6 7
,
ææ7 8
$num
ææ9 :
,
ææ: ;
$num
ææ< =
,
ææ= >
$num
ææ? @
,
ææ@ A
DateTimeKind
ææB N
.
ææN O
Unspecified
ææO Z
)
ææZ [
,
ææ[ \
$str
ææ] b
,
ææb c
$num
ææd g
,
ææg h
null
ææi m
,
ææm n
new
ææo r
DateTime
ææs {
(
ææ{ |
$num
ææ| }
,
ææ} ~
$numææ Ä
,ææÄ Å
$numææÇ É
,ææÉ Ñ
$numææÖ Ü
,ææÜ á
$numææà â
,ææâ ä
$numææã å
,ææå ç
$numææé è
,ææè ê
DateTimeKindææë ù
.ææù û
Unspecifiedææû ©
)ææ© ™
,ææ™ ´
$strææ¨ ±
,ææ± ≤
$strææ≥ æ
,æææ ø
nullææ¿ ƒ
,ææƒ ≈
newææ∆ …
DateTimeææ  “
(ææ“ ”
$numææ” ‘
,ææ‘ ’
$numææ÷ ◊
,ææ◊ ÿ
$numææŸ ⁄
,ææ⁄ €
$numææ‹ ›
,ææ› ﬁ
$numææﬂ ‡
,ææ‡ ·
$numææ‚ „
,ææ„ ‰
$numææÂ Ê
,ææÊ Á
DateTimeKindææË Ù
.ææÙ ı
Unspecifiedææı Ä
)ææÄ Å
}ææÇ É
}
øø 
)
øø 
;
øø 
migrationBuilder
¡¡ 
.
¡¡ 

InsertData
¡¡ '
(
¡¡' (
schema
¬¬ 
:
¬¬ 
$str
¬¬ 
,
¬¬ 
table
√√ 
:
√√ 
$str
√√ %
,
√√% &
columns
ƒƒ 
:
ƒƒ 
new
ƒƒ 
[
ƒƒ 
]
ƒƒ 
{
ƒƒ  
$str
ƒƒ! 1
,
ƒƒ1 2
$str
ƒƒ3 >
,
ƒƒ> ?
$str
ƒƒ@ K
,
ƒƒK L
$str
ƒƒM X
,
ƒƒX Y
$str
ƒƒZ e
,
ƒƒe f
$str
ƒƒg s
,
ƒƒs t
$strƒƒu Å
,ƒƒÅ Ç
$strƒƒÉ í
}ƒƒì î
,ƒƒî ï
values
≈≈ 
:
≈≈ 
new
≈≈ 
object
≈≈ "
[
≈≈" #
,
≈≈# $
]
≈≈$ %
{
∆∆ 
{
«« 
$num
«« 
,
«« 
null
«« 
,
«« 
new
«« "
DateTime
««# +
(
««+ ,
$num
««, -
,
««- .
$num
««/ 0
,
««0 1
$num
««2 3
,
««3 4
$num
««5 6
,
««6 7
$num
««8 9
,
««9 :
$num
««; <
,
««< =
$num
««> ?
,
««? @
DateTimeKind
««A M
.
««M N
Unspecified
««N Y
)
««Y Z
,
««Z [
null
««\ `
,
««` a
new
««b e
DateTime
««f n
(
««n o
$num
««o p
,
««p q
$num
««r s
,
««s t
$num
««u v
,
««v w
$num
««x y
,
««y z
$num
««{ |
,
««| }
$num
««~ 
,«« Ä
$num««Å Ç
,««Ç É
DateTimeKind««Ñ ê
.««ê ë
Unspecified««ë ú
)««ú ù
,««ù û
null««ü £
,««£ §
new««• ®
DateTime««© ±
(««± ≤
$num««≤ ≥
,««≥ ¥
$num««µ ∂
,««∂ ∑
$num««∏ π
,««π ∫
$num««ª º
,««º Ω
$num««æ ø
,««ø ¿
$num««¡ ¬
,««¬ √
$num««ƒ ≈
,««≈ ∆
DateTimeKind««« ”
.««” ‘
Unspecified««‘ ﬂ
)««ﬂ ‡
,««‡ ·
$str««‚ Ò
}««Ú Û
,««Û Ù
{
»» 
$num
»» 
,
»» 
null
»» 
,
»» 
new
»» "
DateTime
»»# +
(
»»+ ,
$num
»», -
,
»»- .
$num
»»/ 0
,
»»0 1
$num
»»2 3
,
»»3 4
$num
»»5 6
,
»»6 7
$num
»»8 9
,
»»9 :
$num
»»; <
,
»»< =
$num
»»> ?
,
»»? @
DateTimeKind
»»A M
.
»»M N
Unspecified
»»N Y
)
»»Y Z
,
»»Z [
null
»»\ `
,
»»` a
new
»»b e
DateTime
»»f n
(
»»n o
$num
»»o p
,
»»p q
$num
»»r s
,
»»s t
$num
»»u v
,
»»v w
$num
»»x y
,
»»y z
$num
»»{ |
,
»»| }
$num
»»~ 
,»» Ä
$num»»Å Ç
,»»Ç É
DateTimeKind»»Ñ ê
.»»ê ë
Unspecified»»ë ú
)»»ú ù
,»»ù û
null»»ü £
,»»£ §
new»»• ®
DateTime»»© ±
(»»± ≤
$num»»≤ ≥
,»»≥ ¥
$num»»µ ∂
,»»∂ ∑
$num»»∏ π
,»»π ∫
$num»»ª º
,»»º Ω
$num»»æ ø
,»»ø ¿
$num»»¡ ¬
,»»¬ √
$num»»ƒ ≈
,»»≈ ∆
DateTimeKind»»« ”
.»»” ‘
Unspecified»»‘ ﬂ
)»»ﬂ ‡
,»»‡ ·
$str»»‚ ˚
}»»¸ ˝
,»»˝ ˛
{
…… 
$num
…… 
,
…… 
null
…… 
,
…… 
new
…… "
DateTime
……# +
(
……+ ,
$num
……, -
,
……- .
$num
……/ 0
,
……0 1
$num
……2 3
,
……3 4
$num
……5 6
,
……6 7
$num
……8 9
,
……9 :
$num
……; <
,
……< =
$num
……> ?
,
……? @
DateTimeKind
……A M
.
……M N
Unspecified
……N Y
)
……Y Z
,
……Z [
null
……\ `
,
……` a
new
……b e
DateTime
……f n
(
……n o
$num
……o p
,
……p q
$num
……r s
,
……s t
$num
……u v
,
……v w
$num
……x y
,
……y z
$num
……{ |
,
……| }
$num
……~ 
,…… Ä
$num……Å Ç
,……Ç É
DateTimeKind……Ñ ê
.……ê ë
Unspecified……ë ú
)……ú ù
,……ù û
null……ü £
,……£ §
new……• ®
DateTime……© ±
(……± ≤
$num……≤ ≥
,……≥ ¥
$num……µ ∂
,……∂ ∑
$num……∏ π
,……π ∫
$num……ª º
,……º Ω
$num……æ ø
,……ø ¿
$num……¡ ¬
,……¬ √
$num……ƒ ≈
,……≈ ∆
DateTimeKind……« ”
.……” ‘
Unspecified……‘ ﬂ
)……ﬂ ‡
,……‡ ·
$str……‚ Û
}……Ù ı
,……ı ˆ
{
   
$num
   
,
   
null
   
,
   
new
   "
DateTime
  # +
(
  + ,
$num
  , -
,
  - .
$num
  / 0
,
  0 1
$num
  2 3
,
  3 4
$num
  5 6
,
  6 7
$num
  8 9
,
  9 :
$num
  ; <
,
  < =
$num
  > ?
,
  ? @
DateTimeKind
  A M
.
  M N
Unspecified
  N Y
)
  Y Z
,
  Z [
null
  \ `
,
  ` a
new
  b e
DateTime
  f n
(
  n o
$num
  o p
,
  p q
$num
  r s
,
  s t
$num
  u v
,
  v w
$num
  x y
,
  y z
$num
  { |
,
  | }
$num
  ~ 
,   Ä
$num  Å Ç
,  Ç É
DateTimeKind  Ñ ê
.  ê ë
Unspecified  ë ú
)  ú ù
,  ù û
null  ü £
,  £ §
new  • ®
DateTime  © ±
(  ± ≤
$num  ≤ ≥
,  ≥ ¥
$num  µ ∂
,  ∂ ∑
$num  ∏ π
,  π ∫
$num  ª º
,  º Ω
$num  æ ø
,  ø ¿
$num  ¡ ¬
,  ¬ √
$num  ƒ ≈
,  ≈ ∆
DateTimeKind  « ”
.  ” ‘
Unspecified  ‘ ﬂ
)  ﬂ ‡
,  ‡ ·
$str  ‚ Ô
}   Ò
,  Ò Ú
{
ÀÀ 
$num
ÀÀ 
,
ÀÀ 
null
ÀÀ 
,
ÀÀ 
new
ÀÀ "
DateTime
ÀÀ# +
(
ÀÀ+ ,
$num
ÀÀ, -
,
ÀÀ- .
$num
ÀÀ/ 0
,
ÀÀ0 1
$num
ÀÀ2 3
,
ÀÀ3 4
$num
ÀÀ5 6
,
ÀÀ6 7
$num
ÀÀ8 9
,
ÀÀ9 :
$num
ÀÀ; <
,
ÀÀ< =
$num
ÀÀ> ?
,
ÀÀ? @
DateTimeKind
ÀÀA M
.
ÀÀM N
Unspecified
ÀÀN Y
)
ÀÀY Z
,
ÀÀZ [
null
ÀÀ\ `
,
ÀÀ` a
new
ÀÀb e
DateTime
ÀÀf n
(
ÀÀn o
$num
ÀÀo p
,
ÀÀp q
$num
ÀÀr s
,
ÀÀs t
$num
ÀÀu v
,
ÀÀv w
$num
ÀÀx y
,
ÀÀy z
$num
ÀÀ{ |
,
ÀÀ| }
$num
ÀÀ~ 
,ÀÀ Ä
$numÀÀÅ Ç
,ÀÀÇ É
DateTimeKindÀÀÑ ê
.ÀÀê ë
UnspecifiedÀÀë ú
)ÀÀú ù
,ÀÀù û
nullÀÀü £
,ÀÀ£ §
newÀÀ• ®
DateTimeÀÀ© ±
(ÀÀ± ≤
$numÀÀ≤ ≥
,ÀÀ≥ ¥
$numÀÀµ ∂
,ÀÀ∂ ∑
$numÀÀ∏ π
,ÀÀπ ∫
$numÀÀª º
,ÀÀº Ω
$numÀÀæ ø
,ÀÀø ¿
$numÀÀ¡ ¬
,ÀÀ¬ √
$numÀÀƒ ≈
,ÀÀ≈ ∆
DateTimeKindÀÀ« ”
.ÀÀ” ‘
UnspecifiedÀÀ‘ ﬂ
)ÀÀﬂ ‡
,ÀÀ‡ ·
$strÀÀ‚ Û
}ÀÀÙ ı
,ÀÀı ˆ
{
ÃÃ 
$num
ÃÃ 
,
ÃÃ 
null
ÃÃ 
,
ÃÃ 
new
ÃÃ "
DateTime
ÃÃ# +
(
ÃÃ+ ,
$num
ÃÃ, -
,
ÃÃ- .
$num
ÃÃ/ 0
,
ÃÃ0 1
$num
ÃÃ2 3
,
ÃÃ3 4
$num
ÃÃ5 6
,
ÃÃ6 7
$num
ÃÃ8 9
,
ÃÃ9 :
$num
ÃÃ; <
,
ÃÃ< =
$num
ÃÃ> ?
,
ÃÃ? @
DateTimeKind
ÃÃA M
.
ÃÃM N
Unspecified
ÃÃN Y
)
ÃÃY Z
,
ÃÃZ [
null
ÃÃ\ `
,
ÃÃ` a
new
ÃÃb e
DateTime
ÃÃf n
(
ÃÃn o
$num
ÃÃo p
,
ÃÃp q
$num
ÃÃr s
,
ÃÃs t
$num
ÃÃu v
,
ÃÃv w
$num
ÃÃx y
,
ÃÃy z
$num
ÃÃ{ |
,
ÃÃ| }
$num
ÃÃ~ 
,ÃÃ Ä
$numÃÃÅ Ç
,ÃÃÇ É
DateTimeKindÃÃÑ ê
.ÃÃê ë
UnspecifiedÃÃë ú
)ÃÃú ù
,ÃÃù û
nullÃÃü £
,ÃÃ£ §
newÃÃ• ®
DateTimeÃÃ© ±
(ÃÃ± ≤
$numÃÃ≤ ≥
,ÃÃ≥ ¥
$numÃÃµ ∂
,ÃÃ∂ ∑
$numÃÃ∏ π
,ÃÃπ ∫
$numÃÃª º
,ÃÃº Ω
$numÃÃæ ø
,ÃÃø ¿
$numÃÃ¡ ¬
,ÃÃ¬ √
$numÃÃƒ ≈
,ÃÃ≈ ∆
DateTimeKindÃÃ« ”
.ÃÃ” ‘
UnspecifiedÃÃ‘ ﬂ
)ÃÃﬂ ‡
,ÃÃ‡ ·
$strÃÃ‚ Ô
}ÃÃ Ò
,ÃÃÒ Ú
{
ÕÕ 
$num
ÕÕ 
,
ÕÕ 
null
ÕÕ 
,
ÕÕ 
new
ÕÕ "
DateTime
ÕÕ# +
(
ÕÕ+ ,
$num
ÕÕ, -
,
ÕÕ- .
$num
ÕÕ/ 0
,
ÕÕ0 1
$num
ÕÕ2 3
,
ÕÕ3 4
$num
ÕÕ5 6
,
ÕÕ6 7
$num
ÕÕ8 9
,
ÕÕ9 :
$num
ÕÕ; <
,
ÕÕ< =
$num
ÕÕ> ?
,
ÕÕ? @
DateTimeKind
ÕÕA M
.
ÕÕM N
Unspecified
ÕÕN Y
)
ÕÕY Z
,
ÕÕZ [
null
ÕÕ\ `
,
ÕÕ` a
new
ÕÕb e
DateTime
ÕÕf n
(
ÕÕn o
$num
ÕÕo p
,
ÕÕp q
$num
ÕÕr s
,
ÕÕs t
$num
ÕÕu v
,
ÕÕv w
$num
ÕÕx y
,
ÕÕy z
$num
ÕÕ{ |
,
ÕÕ| }
$num
ÕÕ~ 
,ÕÕ Ä
$numÕÕÅ Ç
,ÕÕÇ É
DateTimeKindÕÕÑ ê
.ÕÕê ë
UnspecifiedÕÕë ú
)ÕÕú ù
,ÕÕù û
nullÕÕü £
,ÕÕ£ §
newÕÕ• ®
DateTimeÕÕ© ±
(ÕÕ± ≤
$numÕÕ≤ ≥
,ÕÕ≥ ¥
$numÕÕµ ∂
,ÕÕ∂ ∑
$numÕÕ∏ π
,ÕÕπ ∫
$numÕÕª º
,ÕÕº Ω
$numÕÕæ ø
,ÕÕø ¿
$numÕÕ¡ ¬
,ÕÕ¬ √
$numÕÕƒ ≈
,ÕÕ≈ ∆
DateTimeKindÕÕ« ”
.ÕÕ” ‘
UnspecifiedÕÕ‘ ﬂ
)ÕÕﬂ ‡
,ÕÕ‡ ·
$strÕÕ‚ 
}ÕÕÒ Ú
,ÕÕÚ Û
{
ŒŒ 
$num
ŒŒ 
,
ŒŒ 
null
ŒŒ 
,
ŒŒ 
new
ŒŒ "
DateTime
ŒŒ# +
(
ŒŒ+ ,
$num
ŒŒ, -
,
ŒŒ- .
$num
ŒŒ/ 0
,
ŒŒ0 1
$num
ŒŒ2 3
,
ŒŒ3 4
$num
ŒŒ5 6
,
ŒŒ6 7
$num
ŒŒ8 9
,
ŒŒ9 :
$num
ŒŒ; <
,
ŒŒ< =
$num
ŒŒ> ?
,
ŒŒ? @
DateTimeKind
ŒŒA M
.
ŒŒM N
Unspecified
ŒŒN Y
)
ŒŒY Z
,
ŒŒZ [
null
ŒŒ\ `
,
ŒŒ` a
new
ŒŒb e
DateTime
ŒŒf n
(
ŒŒn o
$num
ŒŒo p
,
ŒŒp q
$num
ŒŒr s
,
ŒŒs t
$num
ŒŒu v
,
ŒŒv w
$num
ŒŒx y
,
ŒŒy z
$num
ŒŒ{ |
,
ŒŒ| }
$num
ŒŒ~ 
,ŒŒ Ä
$numŒŒÅ Ç
,ŒŒÇ É
DateTimeKindŒŒÑ ê
.ŒŒê ë
UnspecifiedŒŒë ú
)ŒŒú ù
,ŒŒù û
nullŒŒü £
,ŒŒ£ §
newŒŒ• ®
DateTimeŒŒ© ±
(ŒŒ± ≤
$numŒŒ≤ ≥
,ŒŒ≥ ¥
$numŒŒµ ∂
,ŒŒ∂ ∑
$numŒŒ∏ π
,ŒŒπ ∫
$numŒŒª º
,ŒŒº Ω
$numŒŒæ ø
,ŒŒø ¿
$numŒŒ¡ ¬
,ŒŒ¬ √
$numŒŒƒ ≈
,ŒŒ≈ ∆
DateTimeKindŒŒ« ”
.ŒŒ” ‘
UnspecifiedŒŒ‘ ﬂ
)ŒŒﬂ ‡
,ŒŒ‡ ·
$strŒŒ‚ Ì
}ŒŒÓ Ô
}
œœ 
)
œœ 
;
œœ 
migrationBuilder
—— 
.
—— 

InsertData
—— '
(
——' (
schema
““ 
:
““ 
$str
““ 
,
““ 
table
”” 
:
”” 
$str
”” %
,
””% &
columns
‘‘ 
:
‘‘ 
new
‘‘ 
[
‘‘ 
]
‘‘ 
{
‘‘  
$str
‘‘! 1
,
‘‘1 2
$str
‘‘3 >
,
‘‘> ?
$str
‘‘@ K
,
‘‘K L
$str
‘‘M X
,
‘‘X Y
$str
‘‘Z e
,
‘‘e f
$str
‘‘g s
,
‘‘s t
$str‘‘u Å
,‘‘Å Ç
$str‘‘É í
}‘‘ì î
,‘‘î ï
values
’’ 
:
’’ 
new
’’ 
object
’’ "
[
’’" #
,
’’# $
]
’’$ %
{
÷÷ 
{
◊◊ 
$num
◊◊ 
,
◊◊ 
null
◊◊ 
,
◊◊ 
new
◊◊ "
DateTime
◊◊# +
(
◊◊+ ,
$num
◊◊, -
,
◊◊- .
$num
◊◊/ 0
,
◊◊0 1
$num
◊◊2 3
,
◊◊3 4
$num
◊◊5 6
,
◊◊6 7
$num
◊◊8 9
,
◊◊9 :
$num
◊◊; <
,
◊◊< =
$num
◊◊> ?
,
◊◊? @
DateTimeKind
◊◊A M
.
◊◊M N
Unspecified
◊◊N Y
)
◊◊Y Z
,
◊◊Z [
null
◊◊\ `
,
◊◊` a
new
◊◊b e
DateTime
◊◊f n
(
◊◊n o
$num
◊◊o p
,
◊◊p q
$num
◊◊r s
,
◊◊s t
$num
◊◊u v
,
◊◊v w
$num
◊◊x y
,
◊◊y z
$num
◊◊{ |
,
◊◊| }
$num
◊◊~ 
,◊◊ Ä
$num◊◊Å Ç
,◊◊Ç É
DateTimeKind◊◊Ñ ê
.◊◊ê ë
Unspecified◊◊ë ú
)◊◊ú ù
,◊◊ù û
null◊◊ü £
,◊◊£ §
new◊◊• ®
DateTime◊◊© ±
(◊◊± ≤
$num◊◊≤ ≥
,◊◊≥ ¥
$num◊◊µ ∂
,◊◊∂ ∑
$num◊◊∏ π
,◊◊π ∫
$num◊◊ª º
,◊◊º Ω
$num◊◊æ ø
,◊◊ø ¿
$num◊◊¡ ¬
,◊◊¬ √
$num◊◊ƒ ≈
,◊◊≈ ∆
DateTimeKind◊◊« ”
.◊◊” ‘
Unspecified◊◊‘ ﬂ
)◊◊ﬂ ‡
,◊◊‡ ·
$str◊◊‚ Ó
}◊◊Ô 
,◊◊ Ò
{
ÿÿ 
$num
ÿÿ 
,
ÿÿ 
null
ÿÿ 
,
ÿÿ 
new
ÿÿ "
DateTime
ÿÿ# +
(
ÿÿ+ ,
$num
ÿÿ, -
,
ÿÿ- .
$num
ÿÿ/ 0
,
ÿÿ0 1
$num
ÿÿ2 3
,
ÿÿ3 4
$num
ÿÿ5 6
,
ÿÿ6 7
$num
ÿÿ8 9
,
ÿÿ9 :
$num
ÿÿ; <
,
ÿÿ< =
$num
ÿÿ> ?
,
ÿÿ? @
DateTimeKind
ÿÿA M
.
ÿÿM N
Unspecified
ÿÿN Y
)
ÿÿY Z
,
ÿÿZ [
null
ÿÿ\ `
,
ÿÿ` a
new
ÿÿb e
DateTime
ÿÿf n
(
ÿÿn o
$num
ÿÿo p
,
ÿÿp q
$num
ÿÿr s
,
ÿÿs t
$num
ÿÿu v
,
ÿÿv w
$num
ÿÿx y
,
ÿÿy z
$num
ÿÿ{ |
,
ÿÿ| }
$num
ÿÿ~ 
,ÿÿ Ä
$numÿÿÅ Ç
,ÿÿÇ É
DateTimeKindÿÿÑ ê
.ÿÿê ë
Unspecifiedÿÿë ú
)ÿÿú ù
,ÿÿù û
nullÿÿü £
,ÿÿ£ §
newÿÿ• ®
DateTimeÿÿ© ±
(ÿÿ± ≤
$numÿÿ≤ ≥
,ÿÿ≥ ¥
$numÿÿµ ∂
,ÿÿ∂ ∑
$numÿÿ∏ π
,ÿÿπ ∫
$numÿÿª º
,ÿÿº Ω
$numÿÿæ ø
,ÿÿø ¿
$numÿÿ¡ ¬
,ÿÿ¬ √
$numÿÿƒ ≈
,ÿÿ≈ ∆
DateTimeKindÿÿ« ”
.ÿÿ” ‘
Unspecifiedÿÿ‘ ﬂ
)ÿÿﬂ ‡
,ÿÿ‡ ·
$strÿÿ‚ 
}ÿÿÒ Ú
,ÿÿÚ Û
{
ŸŸ 
$num
ŸŸ 
,
ŸŸ 
null
ŸŸ 
,
ŸŸ 
new
ŸŸ "
DateTime
ŸŸ# +
(
ŸŸ+ ,
$num
ŸŸ, -
,
ŸŸ- .
$num
ŸŸ/ 0
,
ŸŸ0 1
$num
ŸŸ2 3
,
ŸŸ3 4
$num
ŸŸ5 6
,
ŸŸ6 7
$num
ŸŸ8 9
,
ŸŸ9 :
$num
ŸŸ; <
,
ŸŸ< =
$num
ŸŸ> ?
,
ŸŸ? @
DateTimeKind
ŸŸA M
.
ŸŸM N
Unspecified
ŸŸN Y
)
ŸŸY Z
,
ŸŸZ [
null
ŸŸ\ `
,
ŸŸ` a
new
ŸŸb e
DateTime
ŸŸf n
(
ŸŸn o
$num
ŸŸo p
,
ŸŸp q
$num
ŸŸr s
,
ŸŸs t
$num
ŸŸu v
,
ŸŸv w
$num
ŸŸx y
,
ŸŸy z
$num
ŸŸ{ |
,
ŸŸ| }
$num
ŸŸ~ 
,ŸŸ Ä
$numŸŸÅ Ç
,ŸŸÇ É
DateTimeKindŸŸÑ ê
.ŸŸê ë
UnspecifiedŸŸë ú
)ŸŸú ù
,ŸŸù û
nullŸŸü £
,ŸŸ£ §
newŸŸ• ®
DateTimeŸŸ© ±
(ŸŸ± ≤
$numŸŸ≤ ≥
,ŸŸ≥ ¥
$numŸŸµ ∂
,ŸŸ∂ ∑
$numŸŸ∏ π
,ŸŸπ ∫
$numŸŸª º
,ŸŸº Ω
$numŸŸæ ø
,ŸŸø ¿
$numŸŸ¡ ¬
,ŸŸ¬ √
$numŸŸƒ ≈
,ŸŸ≈ ∆
DateTimeKindŸŸ« ”
.ŸŸ” ‘
UnspecifiedŸŸ‘ ﬂ
)ŸŸﬂ ‡
,ŸŸ‡ ·
$strŸŸ‚ Ï
}ŸŸÌ Ó
}
⁄⁄ 
)
⁄⁄ 
;
⁄⁄ 
migrationBuilder
‹‹ 
.
‹‹ 
CreateIndex
‹‹ (
(
‹‹( )
name
›› 
:
›› 
$str
›› 0
,
››0 1
schema
ﬁﬁ 
:
ﬁﬁ 
$str
ﬁﬁ 
,
ﬁﬁ 
table
ﬂﬂ 
:
ﬂﬂ 
$str
ﬂﬂ !
,
ﬂﬂ! "
column
‡‡ 
:
‡‡ 
$str
‡‡ &
,
‡‡& '
unique
·· 
:
·· 
true
·· 
)
·· 
;
·· 
migrationBuilder
„„ 
.
„„ 
CreateIndex
„„ (
(
„„( )
name
‰‰ 
:
‰‰ 
$str
‰‰ 8
,
‰‰8 9
schema
ÂÂ 
:
ÂÂ 
$str
ÂÂ 
,
ÂÂ 
table
ÊÊ 
:
ÊÊ 
$str
ÊÊ %
,
ÊÊ% &
column
ÁÁ 
:
ÁÁ 
$str
ÁÁ *
,
ÁÁ* +
unique
ËË 
:
ËË 
true
ËË 
)
ËË 
;
ËË 
migrationBuilder
ÍÍ 
.
ÍÍ 
CreateIndex
ÍÍ (
(
ÍÍ( )
name
ÎÎ 
:
ÎÎ 
$str
ÎÎ O
,
ÎÎO P
schema
ÏÏ 
:
ÏÏ 
$str
ÏÏ 
,
ÏÏ 
table
ÌÌ 
:
ÌÌ 
$str
ÌÌ '
,
ÌÌ' (
columns
ÓÓ 
:
ÓÓ 
new
ÓÓ 
[
ÓÓ 
]
ÓÓ 
{
ÓÓ  
$str
ÓÓ! 8
,
ÓÓ8 9
$str
ÓÓ: K
}
ÓÓL M
,
ÓÓM N
unique
ÔÔ 
:
ÔÔ 
true
ÔÔ 
)
ÔÔ 
;
ÔÔ 
migrationBuilder
ÒÒ 
.
ÒÒ 
CreateIndex
ÒÒ (
(
ÒÒ( )
name
ÚÚ 
:
ÚÚ 
$str
ÚÚ 7
,
ÚÚ7 8
schema
ÛÛ 
:
ÛÛ 
$str
ÛÛ 
,
ÛÛ 
table
ÙÙ 
:
ÙÙ 
$str
ÙÙ '
,
ÙÙ' (
column
ıı 
:
ıı 
$str
ıı '
,
ıı' (
unique
ˆˆ 
:
ˆˆ 
true
ˆˆ 
)
ˆˆ 
;
ˆˆ 
migrationBuilder
¯¯ 
.
¯¯ 
CreateIndex
¯¯ (
(
¯¯( )
name
˘˘ 
:
˘˘ 
$str
˘˘ 6
,
˘˘6 7
schema
˙˙ 
:
˙˙ 
$str
˙˙ 
,
˙˙ 
table
˚˚ 
:
˚˚ 
$str
˚˚ '
,
˚˚' (
column
¸¸ 
:
¸¸ 
$str
¸¸ &
,
¸¸& '
unique
˝˝ 
:
˝˝ 
true
˝˝ 
)
˝˝ 
;
˝˝ 
migrationBuilder
ˇˇ 
.
ˇˇ 
CreateIndex
ˇˇ (
(
ˇˇ( )
name
ÄÄ 
:
ÄÄ 
$str
ÄÄ 5
,
ÄÄ5 6
schema
ÅÅ 
:
ÅÅ 
$str
ÅÅ 
,
ÅÅ 
table
ÇÇ 
:
ÇÇ 
$str
ÇÇ %
,
ÇÇ% &
column
ÉÉ 
:
ÉÉ 
$str
ÉÉ '
,
ÉÉ' (
unique
ÑÑ 
:
ÑÑ 
true
ÑÑ 
)
ÑÑ 
;
ÑÑ 
migrationBuilder
ÜÜ 
.
ÜÜ 
CreateIndex
ÜÜ (
(
ÜÜ( )
name
áá 
:
áá 
$str
áá 1
,
áá1 2
schema
àà 
:
àà 
$str
àà 
,
àà 
table
ââ 
:
ââ 
$str
ââ  
,
ââ  !
column
ää 
:
ää 
$str
ää (
,
ää( )
unique
ãã 
:
ãã 
true
ãã 
)
ãã 
;
ãã 
migrationBuilder
çç 
.
çç 
CreateIndex
çç (
(
çç( )
name
éé 
:
éé 
$str
éé .
,
éé. /
schema
èè 
:
èè 
$str
èè 
,
èè 
table
êê 
:
êê 
$str
êê  
,
êê  !
column
ëë 
:
ëë 
$str
ëë %
,
ëë% &
unique
íí 
:
íí 
true
íí 
)
íí 
;
íí 
migrationBuilder
îî 
.
îî 
CreateIndex
îî (
(
îî( )
name
ïï 
:
ïï 
$str
ïï I
,
ïïI J
schema
ññ 
:
ññ 
$str
ññ 
,
ññ 
table
óó 
:
óó 
$str
óó $
,
óó$ %
columns
òò 
:
òò 
new
òò 
[
òò 
]
òò 
{
òò  
$str
òò! 5
,
òò5 6
$str
òò7 H
}
òòI J
,
òòJ K
unique
ôô 
:
ôô 
true
ôô 
)
ôô 
;
ôô 
migrationBuilder
õõ 
.
õõ 
CreateIndex
õõ (
(
õõ( )
name
úú 
:
úú 
$str
úú @
,
úú@ A
schema
ùù 
:
ùù 
$str
ùù 
,
ùù 
table
ûû 
:
ûû 
$str
ûû !
,
ûû! "
columns
üü 
:
üü 
new
üü 
[
üü 
]
üü 
{
üü  
$str
üü! 2
,
üü2 3
$str
üü4 B
}
üüC D
,
üüD E
unique
†† 
:
†† 
true
†† 
)
†† 
;
†† 
migrationBuilder
¢¢ 
.
¢¢ 
CreateIndex
¢¢ (
(
¢¢( )
name
££ 
:
££ 
$str
££ 8
,
££8 9
schema
§§ 
:
§§ 
$str
§§ 
,
§§ 
table
•• 
:
•• 
$str
•• '
,
••' (
column
¶¶ 
:
¶¶ 
$str
¶¶ (
,
¶¶( )
unique
ßß 
:
ßß 
true
ßß 
)
ßß 
;
ßß 
migrationBuilder
©© 
.
©© 
CreateIndex
©© (
(
©©( )
name
™™ 
:
™™ 
$str
™™ 5
,
™™5 6
schema
´´ 
:
´´ 
$str
´´ 
,
´´ 
table
¨¨ 
:
¨¨ 
$str
¨¨ %
,
¨¨% &
column
≠≠ 
:
≠≠ 
$str
≠≠ '
,
≠≠' (
unique
ÆÆ 
:
ÆÆ 
true
ÆÆ 
)
ÆÆ 
;
ÆÆ 
migrationBuilder
∞∞ 
.
∞∞ 
CreateIndex
∞∞ (
(
∞∞( )
name
±± 
:
±± 
$str
±± 5
,
±±5 6
schema
≤≤ 
:
≤≤ 
$str
≤≤ 
,
≤≤ 
table
≥≥ 
:
≥≥ 
$str
≥≥ %
,
≥≥% &
column
¥¥ 
:
¥¥ 
$str
¥¥ '
,
¥¥' (
unique
µµ 
:
µµ 
true
µµ 
)
µµ 
;
µµ 
}
∂∂ 	
	protected
ππ 
override
ππ 
void
ππ 
Down
ππ  $
(
ππ$ %
MigrationBuilder
ππ% 5
migrationBuilder
ππ6 F
)
ππF G
{
∫∫ 	
migrationBuilder
ªª 
.
ªª 
	DropTable
ªª &
(
ªª& '
name
ºº 
:
ºº 
$str
ºº  
,
ºº  !
schema
ΩΩ 
:
ΩΩ 
$str
ΩΩ 
)
ΩΩ 
;
ΩΩ 
migrationBuilder
øø 
.
øø 
	DropTable
øø &
(
øø& '
name
¿¿ 
:
¿¿ 
$str
¿¿ $
,
¿¿$ %
schema
¡¡ 
:
¡¡ 
$str
¡¡ 
)
¡¡ 
;
¡¡ 
migrationBuilder
√√ 
.
√√ 
	DropTable
√√ &
(
√√& '
name
ƒƒ 
:
ƒƒ 
$str
ƒƒ &
,
ƒƒ& '
schema
≈≈ 
:
≈≈ 
$str
≈≈ 
)
≈≈ 
;
≈≈ 
migrationBuilder
«« 
.
«« 
	DropTable
«« &
(
««& '
name
»» 
:
»» 
$str
»» &
,
»»& '
schema
…… 
:
…… 
$str
…… 
)
…… 
;
…… 
migrationBuilder
ÀÀ 
.
ÀÀ 
	DropTable
ÀÀ &
(
ÀÀ& '
name
ÃÃ 
:
ÃÃ 
$str
ÃÃ #
,
ÃÃ# $
schema
ÕÕ 
:
ÕÕ 
$str
ÕÕ 
)
ÕÕ 
;
ÕÕ 
migrationBuilder
œœ 
.
œœ 
	DropTable
œœ &
(
œœ& '
name
–– 
:
–– 
$str
–– "
,
––" #
schema
—— 
:
—— 
$str
—— 
)
—— 
;
—— 
migrationBuilder
”” 
.
”” 
	DropTable
”” &
(
””& '
name
‘‘ 
:
‘‘ 
$str
‘‘ #
,
‘‘# $
schema
’’ 
:
’’ 
$str
’’ 
)
’’ 
;
’’ 
migrationBuilder
◊◊ 
.
◊◊ 
	DropTable
◊◊ &
(
◊◊& '
name
ÿÿ 
:
ÿÿ 
$str
ÿÿ "
,
ÿÿ" #
schema
ŸŸ 
:
ŸŸ 
$str
ŸŸ 
)
ŸŸ 
;
ŸŸ 
migrationBuilder
€€ 
.
€€ 
	DropTable
€€ &
(
€€& '
name
‹‹ 
:
‹‹ 
$str
‹‹ !
,
‹‹! "
schema
›› 
:
›› 
$str
›› 
)
›› 
;
›› 
migrationBuilder
ﬂﬂ 
.
ﬂﬂ 
	DropTable
ﬂﬂ &
(
ﬂﬂ& '
name
‡‡ 
:
‡‡ 
$str
‡‡ &
,
‡‡& '
schema
·· 
:
·· 
$str
·· 
)
·· 
;
·· 
migrationBuilder
„„ 
.
„„ 
	DropTable
„„ &
(
„„& '
name
‰‰ 
:
‰‰ 
$str
‰‰ $
,
‰‰$ %
schema
ÂÂ 
:
ÂÂ 
$str
ÂÂ 
)
ÂÂ 
;
ÂÂ 
migrationBuilder
ÁÁ 
.
ÁÁ 
	DropTable
ÁÁ &
(
ÁÁ& '
name
ËË 
:
ËË 
$str
ËË "
,
ËË" #
schema
ÈÈ 
:
ÈÈ 
$str
ÈÈ 
)
ÈÈ 
;
ÈÈ 
migrationBuilder
ÎÎ 
.
ÎÎ 
	DropTable
ÎÎ &
(
ÎÎ& '
name
ÏÏ 
:
ÏÏ 
$str
ÏÏ &
,
ÏÏ& '
schema
ÌÌ 
:
ÌÌ 
$str
ÌÌ 
)
ÌÌ 
;
ÌÌ 
migrationBuilder
ÔÔ 
.
ÔÔ 
	DropTable
ÔÔ &
(
ÔÔ& '
name
 
:
 
$str
 
,
 
schema
ÒÒ 
:
ÒÒ 
$str
ÒÒ 
)
ÒÒ 
;
ÒÒ 
migrationBuilder
ÛÛ 
.
ÛÛ 
	DropTable
ÛÛ &
(
ÛÛ& '
name
ÙÙ 
:
ÙÙ 
$str
ÙÙ *
,
ÙÙ* +
schema
ıı 
:
ıı 
$str
ıı 
)
ıı 
;
ıı 
migrationBuilder
˜˜ 
.
˜˜ 
	DropTable
˜˜ &
(
˜˜& '
name
¯¯ 
:
¯¯ 
$str
¯¯ 
,
¯¯  
schema
˘˘ 
:
˘˘ 
$str
˘˘ 
)
˘˘ 
;
˘˘ 
migrationBuilder
˚˚ 
.
˚˚ 
	DropTable
˚˚ &
(
˚˚& '
name
¸¸ 
:
¸¸ 
$str
¸¸ #
,
¸¸# $
schema
˝˝ 
:
˝˝ 
$str
˝˝ 
)
˝˝ 
;
˝˝ 
migrationBuilder
ˇˇ 
.
ˇˇ 
	DropTable
ˇˇ &
(
ˇˇ& '
name
ÄÄ 
:
ÄÄ 
$str
ÄÄ  
,
ÄÄ  !
schema
ÅÅ 
:
ÅÅ 
$str
ÅÅ 
)
ÅÅ 
;
ÅÅ 
migrationBuilder
ÉÉ 
.
ÉÉ 
	DropTable
ÉÉ &
(
ÉÉ& '
name
ÑÑ 
:
ÑÑ 
$str
ÑÑ #
,
ÑÑ# $
schema
ÖÖ 
:
ÖÖ 
$str
ÖÖ 
)
ÖÖ 
;
ÖÖ 
migrationBuilder
áá 
.
áá 
	DropTable
áá &
(
áá& '
name
àà 
:
àà 
$str
àà %
,
àà% &
schema
ââ 
:
ââ 
$str
ââ 
)
ââ 
;
ââ 
migrationBuilder
ãã 
.
ãã 
	DropTable
ãã &
(
ãã& '
name
åå 
:
åå 
$str
åå  
,
åå  !
schema
çç 
:
çç 
$str
çç 
)
çç 
;
çç 
migrationBuilder
èè 
.
èè 
	DropTable
èè &
(
èè& '
name
êê 
:
êê 
$str
êê &
,
êê& '
schema
ëë 
:
ëë 
$str
ëë 
)
ëë 
;
ëë 
migrationBuilder
ìì 
.
ìì 
	DropTable
ìì &
(
ìì& '
name
îî 
:
îî 
$str
îî &
,
îî& '
schema
ïï 
:
ïï 
$str
ïï 
)
ïï 
;
ïï 
migrationBuilder
óó 
.
óó 
	DropTable
óó &
(
óó& '
name
òò 
:
òò 
$str
òò $
,
òò$ %
schema
ôô 
:
ôô 
$str
ôô 
)
ôô 
;
ôô 
migrationBuilder
õõ 
.
õõ 
	DropTable
õõ &
(
õõ& '
name
úú 
:
úú 
$str
úú $
,
úú$ %
schema
ùù 
:
ùù 
$str
ùù 
)
ùù 
;
ùù 
migrationBuilder
üü 
.
üü 
	DropTable
üü &
(
üü& '
name
†† 
:
†† 
$str
†† #
,
††# $
schema
°° 
:
°° 
$str
°° 
)
°° 
;
°° 
migrationBuilder
££ 
.
££ 
	DropTable
££ &
(
££& '
name
§§ 
:
§§ 
$str
§§ 
,
§§ 
schema
•• 
:
•• 
$str
•• 
)
•• 
;
•• 
}
¶¶ 	
}
ßß 
}®® √	
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Extensions/ServiceCollectionExtensions.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )

Extensions) 3
;3 4
public 
static 
class '
ServiceCollectionExtensions /
{ 
public		 

static		 
IServiceCollection		 $#
AddEstateInfrastructure		% <
(		< =
this		= A
IServiceCollection		B T
services		U ]
,		] ^
IConfiguration		_ m
config		n t
)		t u
{

 
services 
. 
AddDbContext 
<  
ApplicationDbContext .
>. /
(/ 0
options0 7
=>8 :
options; B
.B C
UseSqlServerC O
(O P
configP V
.V W
GetConnectionStringW j
(j k
$strk |
)| }
)} ~
)~ 
;	 Ä
return 
services 
; 
} 
} ˙
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ResidentTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
{ 
public 
class %
ResidentTypeConfiguration '
:( )$
IEntityTypeConfiguration* B
<B C
ResidentTypeC O
>O P
{ 
public %
ResidentTypeConfiguration	 "
(" #
)# $
{ 
}		 
public 
void 
	Configure 
( 
EntityTypeBuilder /
</ 0
ResidentType0 <
>< =
builder> E
)E F
{ 	
builder 
. 
HasIndex 
( 
a 
=> !
a" #
.# $
ResidentTypes$ 1
)1 2
. 
IsUnique 
( 
) 
; 
builder 
. 
HasData 
( 
new 
ResidentType  
(  !
$num! "
," #
$str$ 0
)0 1
,1 2
new 
ResidentType  
(  !
$num! "
," #
$str$ 2
)2 3
,3 4
new 
ResidentType  
(  !
$num! "
," #
$str$ .
). /
) 
; 
} 	
} 
} ª
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/PropertyTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class %
PropertyTypeConfiguration &
:& '$
IEntityTypeConfiguration( @
<@ A
PropertyTypeA M
>M N
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
PropertyType, 8
>8 9
builder: A
)A B
{ 
builder 
. 
HasIndex 
( 
p 
=> 
p 
.  
PropertyTypes  -
)- .
. 
IsUnique 
( 
true 
) 
; 
builder

 
.

 
HasData

 
(

 
new 
PropertyType 
( 
$num 
, 
$str  /
)0 1
,1 2
new 
PropertyType 
( 
$num 
, 
$str  9
): ;
,; <
new 
PropertyType 
( 
$num 
, 
$str  1
)2 3
,3 4
new 
PropertyType 
( 
$num 
, 
$str  -
). /
,/ 0
new 
PropertyType 
( 
$num 
, 
$str  1
)1 2
,2 3
new 
PropertyType 
( 
$num 
, 
$str  -
). /
,/ 0
new 
PropertyType 
( 
$num 
, 
$str  .
)/ 0
,0 1
new 
PropertyType 
( 
$num 
, 
$str  +
), -
) 
; 
} 
} ˇd
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LocalityConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class !
LocalityConfiguration "
:# $$
IEntityTypeConfiguration% =
<= >
Locality> F
>F G
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
Locality, 4
>4 5
builder6 =
)= >
{ 
builder 
. 
HasIndex 
( 
c 
=> 
new !
{" #
c$ %
.% &
LocalityInitial& 5
,5 6
c7 8
.8 9
LocalityName9 E
}F G
)G H
. 
IsUnique 
( 
true 
) 
; 
builder 
. 
HasData 
( 
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num; ?
)? @
,@ A
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num< @
)@ A
,A B
new 
Locality 
( 
$num 
, 
$str  %
,% &
$str' 4
,4 5
$str6 :
,: ;
$num< @
)@ A
,A B
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str7 ;
,; <
$num= A
)A B
,B C
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new 
Locality 
( 
$num 
,  
$str! &
,& '
$str( 6
,6 7
$str8 <
,< =
$num> B
)B C
,C D
new   
Locality   
(   
$num   
,    
$str  ! &
,  & '
$str  ( 6
,  6 7
$str  8 =
,  = >
$num  > A
)  A B
,  B C
new!! 
Locality!! 
(!! 
$num!! 
,!!  
$str!!! &
,!!& '
$str!!( 6
,!!6 7
$str!!8 =
,!!= >
$num!!? B
)!!B C
,!!C D
new"" 
Locality"" 
("" 
$num"" 
,""  
$str""! &
,""& '
$str""( 6
,""6 7
$str""8 =
,""= >
$num""? B
)""B C
,""C D
new## 
Locality## 
(## 
$num## 
,##  
$str##! &
,##& '
$str##( 6
,##6 7
$str##8 =
,##= >
$num##? B
)##B C
,##C D
new$$ 
Locality$$ 
($$ 
$num$$ 
,$$  
$str$$! &
,$$& '
$str$$( 6
,$$6 7
$str$$8 =
,$$= >
$num$$? B
)$$B C
,$$C D
new%% 
Locality%% 
(%% 
$num%% 
,%%  
$str%%! &
,%%& '
$str%%( 6
,%%6 7
$str%%8 =
,%%= >
$num%%? B
)%%B C
,%%C D
new&& 
Locality&& 
(&& 
$num&& 
,&&  
$str&&! &
,&&& '
$str&&( 2
,&&2 3
$str&&4 8
,&&8 9
$num&&: >
)&&> ?
,&&? @
new'' 
Locality'' 
('' 
$num'' 
,''  
$str''! %
,''% &
$str''' 4
,''4 5
$str''6 ;
,''; <
$num''= @
)''@ A
,''A B
new(( 
Locality(( 
((( 
$num(( 
,((  
$str((! %
,((% &
$str((' -
,((- .
$str((/ 4
,((4 5
$num((6 :
)((: ;
,((; <
new)) 
Locality)) 
()) 
$num)) 
,))  
$str))! &
,))& '
$str))( 2
,))2 3
$str))4 8
,))8 9
$num)): =
)))= >
,))> ?
new** 
Locality** 
(** 
$num** 
,**  
$str**! '
,**' (
$str**) 2
,**2 3
$str**4 9
,**9 :
$num**; >
)**> ?
,**? @
new++ 
Locality++ 
(++ 
$num++ 
,++  
$str++! %
,++% &
$str++' 2
,++2 3
$str++4 9
,++9 :
$num++; >
)++> ?
,++? @
new,, 
Locality,, 
(,, 
$num,, 
,,,  
$str,,! %
,,,% &
$str,,' 3
,,,3 4
$str,,5 :
,,,: ;
$num,,< ?
),,? @
,,,@ A
new-- 
Locality-- 
(-- 
$num-- 
,--  
$str--! %
,--% &
$str--' 5
,--5 6
$str--7 <
,--< =
$num--> A
)--A B
,--B C
new.. 
Locality.. 
(.. 
$num.. 
,..  
$str..! %
,..% &
$str..' 9
,..9 :
$str..: ?
,..? @
$num..A D
)..D E
,..E F
new// 
Locality// 
(// 
$num// 
,//  
$str//! &
,//& '
$str//( /
,/// 0
$str//1 6
,//6 7
$num//8 ;
)//; <
,//< =
new00 
Locality00 
(00 
$num00 
,00  
$str00! '
,00' (
$str00) 2
,002 3
$str003 8
,008 9
$num00: =
)00= >
,00> ?
new11 
Locality11 
(11 
$num11 
,11  
$str11! %
,11% &
$str11' 4
,114 5
$str115 :
,11: ;
$num11< ?
)11? @
,11@ A
new22 
Locality22 
(22 
$num22 
,22  
$str22! %
,22% &
$str22' 8
,228 9
$str22: ?
,22? @
$num22A D
)22D E
,22E F
new33 
Locality33 
(33 
$num33 
,33  
$str33! %
,33% &
$str33' 9
,339 :
$str33; @
,33@ A
$num33B E
)33E F
,33F G
new44 
Locality44 
(44 
$num44 
,44  
$str44! &
,44& '
$str44( :
,44: ;
$str44< A
,44A B
$num44C F
)44F G
,44G H
new55 
Locality55 
(55 
$num55 
,55  
$str55! *
,55* +
$str55, ;
,55; <
$str55< A
,55A B
$num55C F
)55F G
,55G H
new66 
Locality66 
(66 
$num66 
,66  
$str66! %
,66% &
$str66' 5
,665 6
$str666 ;
,66; <
$num66< ?
)66? @
,66@ A
new77 
Locality77 
(77 
$num77 
,77  
$str77! %
,77% &
$str77' 3
,773 4
$str774 9
,779 :
$num77; >
)77> ?
,77? @
new88 
Locality88 
(88 
$num88 
,88  
$str88! %
,88% &
$str88' 2
,882 3
$str883 8
,888 9
$num88: =
)88= >
,88> ?
new99 
Locality99 
(99 
$num99 
,99  
$str99! %
,99% &
$str99' <
,99< =
$str99= B
,99B C
$num99D G
)99G H
,99H I
new:: 
Locality:: 
(:: 
$num:: 
,::  
$str::! %
,::% &
$str::' 2
,::2 3
$str::3 8
,::8 9
$num::: =
)::= >
,::> ?
new;; 
Locality;; 
(;; 
$num;; 
,;;  
$str;;! &
,;;& '
$str;;( 3
,;;3 4
$str;;5 :
,;;: ;
$num;;< ?
);;? @
,;;@ A
new<< 
Locality<< 
(<< 
$num<< 
,<<  
$str<<! &
,<<& '
$str<<( 2
,<<2 3
$str<<4 9
,<<9 :
$num<<; >
)<<> ?
,<<? @
new== 
Locality== 
(== 
$num== 
,==  
$str==! &
,==& '
$str==( 3
,==3 4
$str==5 :
,==: ;
$num==< ?
)==? @
)?? 
;?? 
}@@ 
}AA ò3
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LandUseTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class $
LandUseTypeConfiguration %
:& '$
IEntityTypeConfiguration( @
<@ A
LandUseTypeA L
>L M
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
LandUseType, 7
>7 8
builder9 @
)@ A
{ 
builder 
. 
HasIndex 
( 
lt 
=> 
new "
{# $
lt% '
.' (
LandUseTypeInitial( :
,: ;
lt< >
.> ?
LandUseTypeName? N
}O P
)P Q
. 
IsUnique 
( 
true 
) 
; 
builder 
. 
HasData 
( 
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" $
,$ %
$str& >
)> ?
,? @
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" $
,$ %
$str& ;
); <
,< =
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" $
,$ %
$str& 2
)2 3
,3 4
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" $
,$ %
$str& C
)C D
,D E
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" '
,' (
$str) :
): ;
,; <
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" '
,' (
$str) <
)< =
,= >
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" '
,' (
$str) ?
)? @
,@ A
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" '
,' (
$str) A
)A B
,B C
new 
LandUseType 
( 
$num 
, 
$num  
,  !
$str" '
,' (
$str) 8
)8 9
,9 :
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* 7
)7 8
,8 9
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* 7
)7 8
,8 9
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* :
): ;
,; <
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* 3
)3 4
,4 5
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* G
)G H
,H I
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* G
)G H
,H I
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* F
)F G
,G H
new 
LandUseType 
( 
$num 
, 
$num !
,! "
$str# (
,( )
$str* 4
)4 5
,5 6
new   
LandUseType   
(   
$num   
,   
$num    "
,  " #
$str  $ )
,  ) *
$str  + 4
)  4 5
,  5 6
new!! 
LandUseType!! 
(!! 
$num!! 
,!! 
$num!!  "
,!!" #
$str!!$ )
,!!) *
$str!!+ 5
)!!5 6
,!!6 7
new"" 
LandUseType"" 
("" 
$num"" 
,"" 
$num""  "
,""" #
$str""$ )
,"") *
$str""+ 4
)""4 5
,""5 6
new## 
LandUseType## 
(## 
$num## 
,## 
$num##  "
,##" #
$str##$ )
,##) *
$str##+ 4
)##4 5
,##5 6
new$$ 
LandUseType$$ 
($$ 
$num$$ 
,$$ 
$num$$  "
,$$" #
$str$$$ )
,$$) *
$str$$+ @
)$$@ A
,$$A B
new%% 
LandUseType%% 
(%% 
$num%% 
,%% 
$num%%  "
,%%" #
$str%%$ )
,%%) *
$str%%+ @
)%%@ A
,%%A B
new'' 
LandUseType'' 
('' 
$num'' 
,'' 
$num''  "
,''" #
$str''$ )
,'') *
$str''+ 8
)''8 9
,''9 :
new(( 
LandUseType(( 
((( 
$num(( 
,(( 
$num((  "
,((" #
$str(($ )
,(() *
$str((+ 7
)((7 8
,((8 9
new)) 
LandUseType)) 
()) 
$num)) 
,)) 
$num))  "
,))" #
$str))$ )
,))) *
$str))+ 9
)))9 :
)++ 
;++ 
}-- 
}.. í
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LandUseConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class  
LandUseConfiguration !
:" #$
IEntityTypeConfiguration$ <
<< =
LandUse= D
>D E
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
LandUse, 3
>3 4
builder5 <
)< =
{ 
builder 
. 
HasIndex 
( 
l 
=> 
l 
.  
LandUseInitial  .
). /
. 
IsUnique 
( 
) 
; 
builder

 
.

 
HasIndex

 
(

 
l

 
=>

 
l

 
.

  
LandUseName

  +
)

+ ,
. 
IsUnique 
( 
) 
; 
builder 
. 
HasData 
( 
new   
LandUse   
(   
$num   
,   
$str    
,    !
$str  " /
)  0 1
,  1 2
new!! 
LandUse!! 
(!! 
$num!! 
,!! 
$str!!  
,!!  !
$str!!" :
)!!; <
,!!< =
new"" 
LandUse"" 
("" 
$num"" 
,"" 
$str""  
,""  !
$str""" ;
)""< =
,""= >
new## 
LandUse## 
(## 
$num## 
,## 
$str##  
,##  !
$str##" )
)##* +
,##+ ,
new$$ 
LandUse$$ 
($$ 
$num$$ 
,$$ 
$str$$  
,$$  !
$str$$" (
)$$) *
,$$* +
new%% 
LandUse%% 
(%% 
$num%% 
,%% 
$str%%  
,%%  !
$str%%" .
)%%/ 0
,%%0 1
new&& 
LandUse&& 
(&& 
$num&& 
,&& 
$str&&  
,&&  !
$str&&" 3
)&&4 5
,&&5 6
new'' 
LandUse'' 
('' 
$num'' 
,'' 
$str''  
,''  !
$str''" +
)'', -
,''- .
new(( 
LandUse(( 
((( 
$num(( 
,(( 
$str((  
,((  !
$str((" .
)((/ 0
,((0 1
new)) 
LandUse)) 
()) 
$num)) 
,)) 
$str)) !
,))! "
$str))# -
))). /
,))/ 0
new** 
LandUse** 
(** 
$num** 
,** 
$str** !
,**! "
$str**# 2
)**3 4
,**4 5
new++ 
LandUse++ 
(++ 
$num++ 
,++ 
$str++ !
,++! "
$str++# 1
)++2 3
),, 	
;,,	 

}-- 
}.. ê
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/CustomerTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
{ 
public 
class %
CustomerTypeConfiguration '
:( )$
IEntityTypeConfiguration* B
<B C
CustomerTypeC O
>O P
{ 
public %
CustomerTypeConfiguration	 "
(" #
)# $
{ 
}		 
public 
void 
	Configure 
( 
EntityTypeBuilder /
</ 0
CustomerType0 <
>< =
builder> E
)E F
{ 	
builder 
. 
HasIndex 
( 
a 
=> !
a" #
.# $
CustomerTypes$ 1
)1 2
. 
IsUnique 
( 
) 
; 
builder 
. 
HasData 
( 
new 
CustomerType  
(  !
$num! "
," #
$str$ -
)- .
,. /
new 
CustomerType  
(  !
$num! "
," #
$str$ 0
)0 1
,1 2
new 
CustomerType  
(  !
$num! "
," #
$str$ 5
)5 6
,6 7
new 
CustomerType  
(  !
$num! "
," #
$str$ 5
)5 6
,6 7
new 
CustomerType  
(  !
$num! "
," #
$str$ 1
)1 2
) 
; 
} 	
} 
} ´
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ApartmentTypesConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class '
ApartmentTypesConfiguration (
:) *$
IEntityTypeConfiguration+ C
<C D
ApartmentTypesD R
>R S
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
ApartmentTypes, :
>: ;
builder< C
)C D
{ 
builder		 
.		 
HasIndex		 
(		 
a		 
=>		 
a		 
.		  
ApartmentType		  -
)		- .
.		. /
IsUnique		/ 7
(		7 8
true		8 <
)		< =
;		= >
builder 
. 
HasData 
( 
new 
ApartmentTypes 
( 
$num  
,  !
$str" *
,* +
$num, 0
,0 1
$num2 3
,3 4
$num5 :
): ;
,; <
new 
ApartmentTypes 
( 
$num  
,  !
$str" /
,/ 0
$num1 6
,6 7
$num8 9
,9 :
$num; @
)@ A
,A B
new 
ApartmentTypes 
( 
$num  
,  !
$str" 9
,9 :
$num; @
,@ A
$numB C
,C D
$numE J
)J K
,K L
new 
ApartmentTypes 
( 
$num  
,  !
$str" 0
,0 1
$num2 7
,7 8
$num9 :
,: ;
$num< A
)A B
) 
; 
} 
} ±
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/AllocationTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class '
AllocationTypeConfiguration (
:) *$
IEntityTypeConfiguration+ C
<C D
AllocationTypeD R
>R S
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
AllocationType, :
>: ;
builder< C
)C D
{ 
builder 
. 
HasIndex 
( 
at 
=> 
new "
{# $
at% '
.' (!
AllocationTypeInitial( =
,= >
at? A
.A B
AllocationTypesB Q
}R S
)S T
. 
IsUnique 
( 
true 
) 
; 
builder

 
.

 
HasData

 
(

 
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) <
)< =
,= >
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) 6
)6 7
,7 8
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) 9
)9 :
,: ;
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) ?
)? @
,@ A
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) C
)C D
,D E
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) E
)E F
,F G
new 
AllocationType 
( 
$num  
,  !
$str" '
,' (
$str) D
)D E
) 
; 
} 
} ’
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ActivityTypeConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class %
ActivityTypeConfiguration &
:' ($
IEntityTypeConfiguration) A
<A B
ActivityTypeB N
>N O
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
ActivityType, 8
>8 9
builder: A
)A B
{ 
builder 
. 
HasIndex 
( 
l 
=> 
l 
.  
ActivityTypeName  0
)0 1
. 
IsUnique 
( 
) 
; 
builder 
. 
HasData 
( 
new 
ActivityType 
( 
$num 
, 
$num  !
,! "
$str# 7
,7 8
$str9 I
)J K
,K L
new 
ActivityType 
( 
$num 
, 
$num  !
,! "
$str# 6
,6 7
$str8 _
)_ `
,` a
new 
ActivityType 
( 
$num 
, 
$num  !
,! "
$str# 1
,1 2
$str3 R
)R S
,S T
new 
ActivityType 
( 
$num 
, 
$num  !
,! "
$str# 2
,2 3
$str4 ]
)^ _
,_ `
new 
ActivityType 
( 
$num 
, 
$num  !
,! "
$str# 3
,3 4
$str5 ^
)^ _
) 	
;	 

} 
} ê
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ActivityConfiguration.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
.( )
Configuration) 6
;6 7
public 
class !
ActivityConfiguration "
:# $$
IEntityTypeConfiguration% =
<= >
Activity> F
>F G
{ 
public 

void 
	Configure 
( 
EntityTypeBuilder +
<+ ,
Activity, 4
>4 5
builder6 =
)= >
{ 
builder 
. 
HasIndex 
( 
a 
=> 
a 
.  
ActivityName  ,
), -
. 
IsUnique 
( 
) 
; 
builder 
. 
HasData 
( 
new 
Activity 
( 
$num 
, 
$str %
,% &
$str' D
)E F
,F G
new 
Activity 
( 
$num 
, 
$str &
,& '
$str( Q
)R S
) 	
;	 

} 
} ∞D
x/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/ApplicationDbContext.cs
	namespace 	
Modules
 
. 
Estates 
. 
Infrastructure (
;( )
public 
class  
ApplicationDbContext !
:" #
ModuleDbContext$ 3
{ 
	protected 
override 
string 
Schema $
=>% '
$str( -
;- .
public		 
 
ApplicationDbContext		 
(		  
DbContextOptions		  0
<		0 1 
ApplicationDbContext		1 E
>		E F
options		G N
)		N O
:		P Q
base		R V
(		V W
options		W ^
)		^ _
{

 
} 
public 

DbSet 
< 
CustomerType 
> 
CustomerType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 

DbSet 
< 
Gender 
> 
Gender 
{  !
get" %
;% &
set' *
;* +
}, -
public 

DbSet 
< 
IdentificationType #
># $
IdentificationType% 7
{8 9
get: =
;= >
set? B
;B C
}D E
public 

DbSet 
< 
Nationality 
> 
Nationality )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 
ResidentType 
> 
ResidentType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 

DbSet 
< 
SocialMedia 
> 
SocialMedia )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 
Title 
> 
Title 
{ 
get  #
;# $
set% (
;( )
}* +
public 

DbSet 
< 
AllocationType 
>  
AllocationType! /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 

DbSet 
< 
ApartmentTypes 
>  
ApartmentTypes! /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 

DbSet 
< 
BlockNumber 
> 
BlockNumber )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 

BlockSides 
> 

BlockSides '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

DbSet 
< 
BlockStatus 
> 
BlockStatus )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 

BlockTypes 
> 

BlockTypes '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

DbSet 
< 
	BlockUnit 
> 
	BlockUnit %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public   

DbSet   
<   

Facilities   
>   

Facilities   '
{  ( )
get  * -
;  - .
set  / 2
;  2 3
}  4 5
public!! 

DbSet!! 
<!! 
FloorNumbering!! 
>!!  
FloorNumbering!!! /
{!!0 1
get!!2 5
;!!5 6
set!!7 :
;!!: ;
}!!< =
public"" 

DbSet"" 
<"" 
LandUse"" 
>"" 
LandUse"" !
{""" #
get""$ '
;""' (
set"") ,
;"", -
}"". /
public## 

DbSet## 
<## 
LandUseType## 
>## 
LandUseType## )
{##* +
get##, /
;##/ 0
set##1 4
;##4 5
}##6 7
public$$ 

DbSet$$ 
<$$ 
Locality$$ 
>$$ 
Locality$$ #
{$$$ %
get$$& )
;$$) *
set$$+ .
;$$. /
}$$0 1
public%% 

DbSet%% 
<%% 
PlotSize%% 
>%% 
PlotSize%% #
{%%$ %
get%%& )
;%%) *
set%%+ .
;%%. /
}%%0 1
public&& 

DbSet&& 
<&& 
PropertyHeight&& 
>&&  
PropertyHeight&&! /
{&&0 1
get&&2 5
;&&5 6
set&&7 :
;&&: ;
}&&< =
public'' 

DbSet'' 
<'' 
PropertyType'' 
>'' 
PropertyType'' +
{'', -
get''. 1
;''1 2
set''3 6
;''6 7
}''8 9
public)) 

DbSet)) 
<)) 
Activity)) 
>)) 
Activity)) #
{))$ %
get))& )
;))) *
set))+ .
;)). /
}))0 1
public** 

DbSet** 
<** 
ActivityType** 
>** 
ActivityType** +
{**, -
get**. 1
;**1 2
set**3 6
;**6 7
}**8 9
public,, 

DbSet,, 
<,, 
CustomerMaster,, 
>,,  
CustomerMaster,,! /
{,,0 1
get,,2 5
;,,5 6
set,,7 :
;,,: ;
},,< =
public-- 

DbSet-- 
<-- 
PropertyMaster-- 
>--  
PropertyMaster--! /
{--0 1
get--2 5
;--5 6
set--7 :
;--: ;
}--< =
public// 

DbSet// 
<// 
OwnershipType// 
>// 
OwnershipType//  -
{//. /
get//0 3
;//3 4
set//5 8
;//8 9
}//: ;
public11 

DbSet11 
<11 
	StopDebit11 
>11 
	StopDebit11 %
{11& '
get11( +
;11+ ,
set11- 0
;110 1
}112 3
	protected44 
override44 
void44 
OnModelCreating44 +
(44+ ,
ModelBuilder44, 8
modelBuilder449 E
)44E F
{55 
base77 
.77 
OnModelCreating77 
(77 
modelBuilder77 )
)77) *
;77* +
modelBuilder:: 
.:: 
HasDefaultSchema:: %
(::% &
$str::& +
)::+ ,
;::, -
modelBuilder<< 
.<< 
Entity<< 
<<< 
PropertyMaster<< *
><<* +
(<<+ ,
)<<, -
.== 
HasIndex== 
(== 
pm== 
=>== 
pm== 
.== 
PropertyNumber== -
)==- .
.>> 
IsUnique>> 
(>> 
true>> 
)>> 
;>> 
modelBuilder@@ 
.@@ 
Entity@@ 
<@@ 
CustomerMaster@@ *
>@@* +
(@@+ ,
)@@, -
.AA 
HasIndexAA 
(AA 
cmAA 
=>AA 
cmAA 
.AA 
CustomerCodeAA +
)AA+ ,
.BB 
IsUniqueBB 
(BB 
trueBB 
)BB 
;BB 
modelBuilderDD 
.DD 
EntityDD 
<DD 
CustomerMasterDD *
>DD* +
(DD+ ,
)DD, -
.DD- .
IgnoreDD. 4
(DD4 5
xDD5 6
=>DD7 9
xDD: ;
.DD; <
DomainEventsDD< H
)DDH I
;DDI J
}SS 
	protectedUU 
overrideUU 
voidUU 
OnConfiguringUU )
(UU) *#
DbContextOptionsBuilderUU* A
optionsBuilderUUB P
)UUP Q
{VV 
optionsBuilderWW 
.WW &
EnableSensitiveDataLoggingWW 1
(WW1 2
)WW2 3
;WW3 4
}XX 
}ZZ 