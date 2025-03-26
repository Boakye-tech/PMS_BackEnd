�\
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
�� 
	protected
�� 
virtual
�� 
void
�� 
Dispose
�� "
(
��" #
bool
��# '
	disposing
��( 1
)
��1 2
{
�� 
if
�� 

(
�� 
!
�� 
disposedValue
�� 
)
�� 
{
�� 	
if
�� 
(
�� 
	disposing
�� 
)
�� 
{
�� 

_dbContext
�� 
.
�� 
Dispose
�� "
(
��" #
)
��# $
;
��$ %
}
�� 
disposedValue
�� 
=
�� 
true
��  
;
��  !
}
�� 	
}
�� 
public
�� 

void
�� 
Dispose
�� 
(
�� 
)
�� 
{
�� 
Dispose
�� 
(
�� 
	disposing
�� 
:
�� 
true
�� 
)
��  
;
��  !
GC
�� 

.
��
 
SuppressFinalize
�� 
(
�� 
this
��  
)
��  !
;
��! "
}
�� 
}�� l
j/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Usings.cs�A
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
IOrderedQueryable	(( �
<
((� �
TEntity
((� �
>
((� �
>
((� �
?
((� �
orderBy
((� �
=
((� �
null
((� �
,
((� �
List
((� �
<
((� �
string
((� �
>
((� �
?
((� �
includes
((� �
=
((� �
null
((� �
)
((� �
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
;	?? �
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
}EE �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Registration/PropertyMasterRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Registration/CustomerMasterRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Management/StopDebitRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyHeightRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PlotSizeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LocalityRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LandUseTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/LandUseRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/FloorNumberingRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/FacilitiesRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockUnitRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockSidesRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/BlockNumberRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ApartmentTypesRepository.cs
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
}		 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/AllocationTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ActivityTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ActivityRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/TitleRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/SocialMediaRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/ResidentTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/OwnershipTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/NationalityRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/IdentificationTypeRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/GenderRepository.cs
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
 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Customer/CustomerTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250313154632_Modify_CustomerMaster.cs
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
}88 �$
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310190204_Modified_CustomerMaster.cs
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
};; �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310140046_ModifiedCustomerMaster.cs
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
}** �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Migrations/20250310133202_ModifyCustomerMaster.cs
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
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
SideId
�� 
=
�� 
table
�� "
.
��" #
Column
��# )
<
��) *
int
��* -
>
��- .
(
��. /
type
��/ 3
:
��3 4
$str
��5 :
,
��: ;
nullable
��< D
:
��D E
false
��F K
)
��K L
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
Side
�� 
=
�� 
table
��  
.
��  !
Column
��! '
<
��' (
string
��( .
>
��. /
(
��/ 0
type
��0 4
:
��4 5
$str
��6 D
,
��D E
	maxLength
��F O
:
��O P
$num
��Q S
,
��S T
nullable
��U ]
:
��] ^
false
��_ d
)
��d e
,
��e f
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 4
,
��4 5
x
��6 7
=>
��8 :
x
��; <
.
��< =
SideId
��= C
)
��C D
;
��D E
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
BlockStatusId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
BlockStatusType
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
string
��3 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A O
,
��O P
	maxLength
��Q Z
:
��Z [
$num
��\ ^
,
��^ _
nullable
��` h
:
��h i
true
��j n
)
��n o
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 5
,
��5 6
x
��7 8
=>
��9 ;
x
��< =
.
��= >
BlockStatusId
��> K
)
��K L
;
��L M
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� "
,
��" #
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
BlockTypeId
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
int
��/ 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: ?
,
��? @
nullable
��A I
:
��I J
false
��K P
)
��P Q
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
	BlockType
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; I
,
��I J
	maxLength
��K T
:
��T U
$num
��V X
,
��X Y
nullable
��Z b
:
��b c
false
��d i
)
��i j
,
��j k
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 4
,
��4 5
x
��6 7
=>
��8 :
x
��; <
.
��< =
BlockTypeId
��= H
)
��H I
;
��I J
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� !
,
��! "
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
UnitId
�� 
=
�� 
table
�� "
.
��" #
Column
��# )
<
��) *
int
��* -
>
��- .
(
��. /
type
��/ 3
:
��3 4
$str
��5 :
,
��: ;
nullable
��< D
:
��D E
false
��F K
)
��K L
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
Unit
�� 
=
�� 
table
��  
.
��  !
Column
��! '
<
��' (
string
��( .
>
��. /
(
��/ 0
type
��0 4
:
��4 5
$str
��6 C
,
��C D
	maxLength
��E N
:
��N O
$num
��P Q
,
��Q R
nullable
��S [
:
��[ \
false
��] b
)
��b c
,
��c d
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 3
,
��3 4
x
��5 6
=>
��7 9
x
��: ;
.
��; <
UnitId
��< B
)
��B C
;
��C D
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
CustomerMasterId
�� $
=
��% &
table
��' ,
.
��, -
Column
��- 3
<
��3 4
int
��4 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? D
,
��D E
nullable
��F N
:
��N O
false
��P U
)
��U V
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
CustomerTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
,
��T U
ResidentTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
,
��T U

LocalityId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
CustomerCode
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> L
,
��L M
	maxLength
��N W
:
��W X
$num
��Y [
,
��[ \
nullable
��] e
:
��e f
false
��g l
)
��l m
,
��m n
TitleId
�� 
=
�� 
table
�� #
.
��# $
Column
��$ *
<
��* +
int
��+ .
>
��. /
(
��/ 0
type
��0 4
:
��4 5
$str
��6 ;
,
��; <
nullable
��= E
:
��E F
false
��G L
)
��L M
,
��M N
SurName
�� 
=
�� 
table
�� #
.
��# $
Column
��$ *
<
��* +
string
��+ 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 H
,
��H I
	maxLength
��J S
:
��S T
$num
��U X
,
��X Y
nullable
��Z b
:
��b c
true
��d h
)
��h i
,
��i j

OtherNames
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< J
,
��J K
	maxLength
��L U
:
��U V
$num
��W Y
,
��Y Z
nullable
��[ c
:
��c d
true
��e i
)
��i j
,
��j k
CompanyName
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
string
��/ 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= L
,
��L M
	maxLength
��N W
:
��W X
$num
��Y \
,
��\ ]
nullable
��^ f
:
��f g
true
��h l
)
��l m
,
��m n
DateOfBirth
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
DateTime
��/ 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? J
,
��J K
nullable
��L T
:
��T U
false
��V [
)
��[ \
,
��\ ]
	TinNumber
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; I
,
��I J
	maxLength
��K T
:
��T U
$num
��V X
,
��X Y
nullable
��Z b
:
��b c
true
��d h
)
��h i
,
��i j
Picture
�� 
=
�� 
table
�� #
.
��# $
Column
��$ *
<
��* +
string
��+ 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 H
,
��H I
	maxLength
��J S
:
��S T
$num
��U X
,
��X Y
nullable
��Z b
:
��b c
true
��d h
)
��h i
,
��i j
GenderId
�� 
=
�� 
table
�� $
.
��$ %
Column
��% +
<
��+ ,
int
��, /
>
��/ 0
(
��0 1
type
��1 5
:
��5 6
$str
��7 <
,
��< =
nullable
��> F
:
��F G
false
��H M
)
��M N
,
��N O
NationalityId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
,
��S T
PostalAddress
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ^
,
��^ _
nullable
��` h
:
��h i
true
��j n
)
��n o
,
��o p 
ResidentialAddress
�� &
=
��' (
table
��) .
.
��. /
Column
��/ 5
<
��5 6
string
��6 <
>
��< =
(
��= >
type
��> B
:
��B C
$str
��D S
,
��S T
	maxLength
��U ^
:
��^ _
$num
��` c
,
��c d
nullable
��e m
:
��m n
true
��o s
)
��s t
,
��t u
DigitalAddress
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o!
PrimaryMobileNumber
�� '
=
��( )
table
��* /
.
��/ 0
Column
��0 6
<
��6 7
string
��7 =
>
��= >
(
��> ?
type
��? C
:
��C D
$str
��E S
,
��S T
	maxLength
��U ^
:
��^ _
$num
��` b
,
��b c
nullable
��d l
:
��l m
false
��n s
)
��s t
,
��t u#
SecondaryMobileNumber
�� )
=
��* +
table
��, 1
.
��1 2
Column
��2 8
<
��8 9
string
��9 ?
>
��? @
(
��@ A
type
��A E
:
��E F
$str
��G U
,
��U V
	maxLength
��W `
:
��` a
$num
��b d
,
��d e
nullable
��f n
:
��n o
true
��p t
)
��t u
,
��u v
OfficeNumber
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> L
,
��L M
	maxLength
��N W
:
��W X
$num
��Y [
,
��[ \
nullable
��] e
:
��e f
true
��g k
)
��k l
,
��l m
WhatsAppNumber
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o
EmailAddress
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o"
ResidentPermitNumber
�� (
=
��) *
table
��+ 0
.
��0 1
Column
��1 7
<
��7 8
string
��8 >
>
��> ?
(
��? @
type
��@ D
:
��D E
$str
��F T
,
��T U
	maxLength
��V _
:
��_ `
$num
��a c
,
��c d
nullable
��e m
:
��m n
true
��o s
)
��s t
,
��t u&
ResidentPermitDateIssued
�� ,
=
��- .
table
��/ 4
.
��4 5
Column
��5 ;
<
��; <
DateTime
��< D
>
��D E
(
��E F
type
��F J
:
��J K
$str
��L W
,
��W X
nullable
��Y a
:
��a b
false
��c h
)
��h i
,
��i j&
ResidentPermitExpiryDate
�� ,
=
��- .
table
��/ 4
.
��4 5
Column
��5 ;
<
��; <
DateTime
��< D
>
��D E
(
��E F
type
��F J
:
��J K
$str
��L W
,
��W X
nullable
��Y a
:
��a b
false
��c h
)
��h i
,
��i j
SocialMediaTypeId
�� %
=
��& '
table
��( -
.
��- .
Column
��. 4
<
��4 5
int
��5 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ E
,
��E F
nullable
��G O
:
��O P
false
��Q V
)
��V W
,
��W X 
SocialMediaAccount
�� &
=
��' (
table
��) .
.
��. /
Column
��/ 5
<
��5 6
string
��6 <
>
��< =
(
��= >
type
��> B
:
��B C
$str
��D R
,
��R S
	maxLength
��T ]
:
��] ^
$num
��_ a
,
��a b
nullable
��c k
:
��k l
true
��m q
)
��q r
,
��r s"
IdentificationTypeId
�� (
=
��) *
table
��+ 0
.
��0 1
Column
��1 7
<
��7 8
int
��8 ;
>
��; <
(
��< =
type
��= A
:
��A B
$str
��C H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [&
IdentificationTypeNumber
�� ,
=
��- .
table
��/ 4
.
��4 5
Column
��5 ;
<
��; <
string
��< B
>
��B C
(
��C D
type
��D H
:
��H I
$str
��J X
,
��X Y
	maxLength
��Z c
:
��c d
$num
��e g
,
��g h
nullable
��i q
:
��q r
true
��s w
)
��w x
,
��x y(
IdentificationTypeImageOne
�� .
=
��/ 0
table
��1 6
.
��6 7
Column
��7 =
<
��= >
string
��> D
>
��D E
(
��E F
type
��F J
:
��J K
$str
��L [
,
��[ \
	maxLength
��] f
:
��f g
$num
��h k
,
��k l
nullable
��m u
:
��u v
true
��w {
)
��{ |
,
��| }(
IdentificationTypeImageTwo
�� .
=
��/ 0
table
��1 6
.
��6 7
Column
��7 =
<
��= >
string
��> D
>
��D E
(
��E F
type
��F J
:
��J K
$str
��L [
,
��[ \
	maxLength
��] f
:
��f g
$num
��h k
,
��k l
nullable
��m u
:
��u v
true
��w {
)
��{ |
,
��| }*
IdentificationTypeImageThree
�� 0
=
��1 2
table
��3 8
.
��8 9
Column
��9 ?
<
��? @
string
��@ F
>
��F G
(
��G H
type
��H L
:
��L M
$str
��N ]
,
��] ^
	maxLength
��_ h
:
��h i
$num
��j m
,
��m n
nullable
��o w
:
��w x
true
��y }
)
��} ~
,
��~ )
IdentificationTypeImageFour
�� /
=
��0 1
table
��2 7
.
��7 8
Column
��8 >
<
��> ?
string
��? E
>
��E F
(
��F G
type
��G K
:
��K L
$str
��M \
,
��\ ]
	maxLength
��^ g
:
��g h
$num
��i l
,
��l m
nullable
��n v
:
��v w
true
��x |
)
��| }
,
��} ~)
IdentificationTypeImageFive
�� /
=
��0 1
table
��2 7
.
��7 8
Column
��8 >
<
��> ?
string
��? E
>
��E F
(
��F G
type
��G K
:
��K L
$str
��M \
,
��\ ]
	maxLength
��^ g
:
��g h
$num
��i l
,
��l m
nullable
��n v
:
��v w
true
��x |
)
��| }
,
��} ~
Comments
�� 
=
�� 
table
�� $
.
��$ %
Column
��% +
<
��+ ,
string
��, 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: I
,
��I J
	maxLength
��K T
:
��T U
$num
��V Y
,
��Y Z
nullable
��[ c
:
��c d
true
��e i
)
��i j
,
��j k
InterestExpressed
�� %
=
��& '
table
��( -
.
��- .
Column
��. 4
<
��4 5
string
��5 ;
>
��; <
(
��< =
type
��= A
:
��A B
$str
��C R
,
��R S
	maxLength
��T ]
:
��] ^
$num
��_ b
,
��b c
nullable
��d l
:
��l m
true
��n r
)
��r s
,
��s t
DebtorStatus
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
int
��0 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; @
,
��@ A
nullable
��B J
:
��J K
false
��L Q
)
��Q R
,
��R S

ParentCode
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< J
,
��J K
	maxLength
��L U
:
��U V
$num
��W Y
,
��Y Z
nullable
��[ c
:
��c d
true
��e i
)
��i j
,
��j k$
ContactPerson_FullName
�� *
=
��+ ,
table
��- 2
.
��2 3
Column
��3 9
<
��9 :
string
��: @
>
��@ A
(
��A B
type
��B F
:
��F G
$str
��H W
,
��W X
	maxLength
��Y b
:
��b c
$num
��d g
,
��g h
nullable
��i q
:
��q r
true
��s w
)
��w x
,
��x y'
ContactPerson_PhoneNumber
�� -
=
��. /
table
��0 5
.
��5 6
Column
��6 <
<
��< =
string
��= C
>
��C D
(
��D E
type
��E I
:
��I J
$str
��K Y
,
��Y Z
	maxLength
��[ d
:
��d e
$num
��f h
,
��h i
nullable
��j r
:
��r s
true
��t x
)
��x y
,
��y z(
ContactPerson_EmailAddress
�� .
=
��/ 0
table
��1 6
.
��6 7
Column
��7 =
<
��= >
string
��> D
>
��D E
(
��E F
type
��F J
:
��J K
$str
��L [
,
��[ \
	maxLength
��] f
:
��f g
$num
��h k
,
��k l
nullable
��m u
:
��u v
true
��w {
)
��{ |
,
��| }#
ContactPerson_Address
�� )
=
��* +
table
��, 1
.
��1 2
Column
��2 8
<
��8 9
string
��9 ?
>
��? @
(
��@ A
type
��A E
:
��E F
$str
��G U
,
��U V
	maxLength
��W `
:
��` a
$num
��b d
,
��d e
nullable
��f n
:
��n o
true
��p t
)
��t u
,
��u v0
"ContactPerson_IdentificationTypeId
�� 6
=
��7 8
table
��9 >
.
��> ?
Column
��? E
<
��E F
int
��F I
>
��I J
(
��J K
type
��K O
:
��O P
$str
��Q V
,
��V W
nullable
��X `
:
��` a
false
��b g
)
��g h
,
��h i4
&ContactPerson_IdentificationTypeNumber
�� :
=
��; <
table
��= B
.
��B C
Column
��C I
<
��I J
string
��J P
>
��P Q
(
��Q R
type
��R V
:
��V W
$str
��X f
,
��f g
	maxLength
��h q
:
��q r
$num
��s u
,
��u v
nullable
��w 
:�� �
true��� �
)��� �
,��� �6
(ContactPerson_IdentificationTypeImageOne
�� <
=
��= >
table
��? D
.
��D E
Column
��E K
<
��K L
string
��L R
>
��R S
(
��S T
type
��T X
:
��X Y
$str
��Z i
,
��i j
	maxLength
��k t
:
��t u
$num
��v y
,
��y z
nullable��{ �
:��� �
true��� �
)��� �
,��� �6
(ContactPerson_IdentificationTypeImageTwo
�� <
=
��= >
table
��? D
.
��D E
Column
��E K
<
��K L
string
��L R
>
��R S
(
��S T
type
��T X
:
��X Y
$str
��Z i
,
��i j
	maxLength
��k t
:
��t u
$num
��v y
,
��y z
nullable��{ �
:��� �
true��� �
)��� �
,��� �
	IsDeleted
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
bool
��- 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ApprovedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ApprovedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 8
,
��8 9
x
��: ;
=>
��< >
x
��? @
.
��@ A
CustomerMasterId
��A Q
)
��Q R
;
��R S
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
CustomerTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
CustomerTypes
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
false
��h m
)
��m n
,
��n o
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 6
,
��6 7
x
��8 9
=>
��: <
x
��= >
.
��> ?
CustomerTypeId
��? M
)
��M N
;
��N O
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� "
,
��" #
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 

FacilityId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
Facility
�� 
=
�� 
table
�� $
.
��$ %
Column
��% +
<
��+ ,
string
��, 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: H
,
��H I
	maxLength
��J S
:
��S T
$num
��U W
,
��W X
nullable
��Y a
:
��a b
false
��c h
)
��h i
,
��i j
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 4
,
��4 5
x
��6 7
=>
��8 :
x
��; <
.
��< =

FacilityId
��= G
)
��G H
;
��H I
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
FloorNumberId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
FloorNumber
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
string
��/ 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= K
,
��K L
	maxLength
��M V
:
��V W
$num
��X Z
,
��Z [
nullable
��\ d
:
��d e
false
��f k
)
��k l
,
��l m
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 8
,
��8 9
x
��: ;
=>
��< >
x
��? @
.
��@ A
FloorNumberId
��A N
)
��N O
;
��O P
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� 
,
�� 
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
GenderId
�� 
=
�� 
table
�� $
.
��$ %
Column
��% +
<
��+ ,
int
��, /
>
��/ 0
(
��0 1
type
��1 5
:
��5 6
$str
��7 <
,
��< =
nullable
��> F
:
��F G
false
��H M
)
��M N
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B

GenderType
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< J
,
��J K
	maxLength
��L U
:
��U V
$num
��W Y
,
��Y Z
nullable
��[ c
:
��c d
false
��e j
)
��j k
,
��k l
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 0
,
��0 1
x
��2 3
=>
��4 6
x
��7 8
.
��8 9
GenderId
��9 A
)
��A B
;
��B C
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� *
,
��* +
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� "
IdentificationTypeId
�� (
=
��) *
table
��+ 0
.
��0 1
Column
��1 7
<
��7 8
int
��8 ;
>
��; <
(
��< =
type
��= A
:
��A B
$str
��C H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B!
IdentificationTypes
�� '
=
��( )
table
��* /
.
��/ 0
Column
��0 6
<
��6 7
string
��7 =
>
��= >
(
��> ?
type
��? C
:
��C D
$str
��E S
,
��S T
	maxLength
��U ^
:
��^ _
$num
��` b
,
��b c
nullable
��d l
:
��l m
false
��n s
)
��s t
,
��t u
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% <
,
��< =
x
��> ?
=>
��@ B
x
��C D
.
��D E"
IdentificationTypeId
��E Y
)
��Y Z
;
��Z [
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� 
,
��  
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
	LandUseId
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
int
��- 0
>
��0 1
(
��1 2
type
��2 6
:
��6 7
$str
��8 =
,
��= >
nullable
��? G
:
��G H
false
��I N
)
��N O
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
LandUseInitial
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z [
,
��[ \
nullable
��] e
:
��e f
false
��g l
)
��l m
,
��m n
LandUseName
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
string
��/ 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= K
,
��K L
	maxLength
��M V
:
��V W
$num
��X Z
,
��Z [
nullable
��\ d
:
��d e
false
��f k
)
��k l
,
��l m
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 1
,
��1 2
x
��3 4
=>
��5 7
x
��8 9
.
��9 :
	LandUseId
��: C
)
��C D
;
��D E
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
LandUseTypeId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
	LandUseId
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
int
��- 0
>
��0 1
(
��1 2
type
��2 6
:
��6 7
$str
��8 =
,
��= >
nullable
��? G
:
��G H
false
��I N
)
��N O
,
��O P 
LandUseTypeInitial
�� &
=
��' (
table
��) .
.
��. /
Column
��/ 5
<
��5 6
string
��6 <
>
��< =
(
��= >
type
��> B
:
��B C
$str
��D Q
,
��Q R
	maxLength
��S \
:
��\ ]
$num
��^ _
,
��_ `
nullable
��a i
:
��i j
false
��k p
)
��p q
,
��q r
LandUseTypeName
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
string
��3 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A O
,
��O P
	maxLength
��Q Z
:
��Z [
$num
��\ ^
,
��^ _
nullable
��` h
:
��h i
false
��j o
)
��o p
,
��p q
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 5
,
��5 6
x
��7 8
=>
��9 ;
x
��< =
.
��= >
LandUseTypeId
��> K
)
��K L
;
��L M
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
��  
,
��  !
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 

LocalityId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
LocalityInitial
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
string
��3 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A O
,
��O P
	maxLength
��Q Z
:
��Z [
$num
��\ ^
,
��^ _
nullable
��` h
:
��h i
false
��j o
)
��o p
,
��p q
LocalityName
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> L
,
��L M
	maxLength
��N W
:
��W X
$num
��Y [
,
��[ \
nullable
��] e
:
��e f
false
��g l
)
��l m
,
��m n
CustomerCode
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> K
,
��K L
	maxLength
��M V
:
��V W
$num
��X Y
,
��Y Z
nullable
��[ c
:
��c d
false
��e j
)
��j k
,
��k l!
CustomerCodeCounter
�� '
=
��( )
table
��* /
.
��/ 0
Column
��0 6
<
��6 7
int
��7 :
>
��: ;
(
��; <
type
��< @
:
��@ A
$str
��B G
,
��G H
nullable
��I Q
:
��Q R
false
��S X
)
��X Y
,
��Y Z
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 2
,
��2 3
x
��4 5
=>
��6 8
x
��9 :
.
��: ;

LocalityId
��; E
)
��E F
;
��F G
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
NationalityId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
Nationalities
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
false
��h m
)
��m n
,
��n o
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 5
,
��5 6
x
��7 8
=>
��9 ;
x
��< =
.
��= >
NationalityId
��> K
)
��K L
;
��L M
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� %
,
��% &
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
OwnershipTypeId
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
int
��3 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> C
,
��C D
nullable
��E M
:
��M N
false
��O T
)
��T U
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
OwnershipTypes
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
false
��i n
)
��n o
,
��o p
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 7
,
��7 8
x
��9 :
=>
��; =
x
��> ?
.
��? @
OwnershipTypeId
��@ O
)
��O P
;
��P Q
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
��  
,
��  !
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 

PlotSizeId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
	PlotSizes
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; I
,
��I J
	maxLength
��K T
:
��T U
$num
��V X
,
��X Y
nullable
��Z b
:
��b c
false
��d i
)
��i j
,
��j k
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 2
,
��2 3
x
��4 5
=>
��6 8
x
��9 :
.
��: ;

PlotSizeId
��; E
)
��E F
;
��F G
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
PropertyHeightId
�� $
=
��% &
table
��' ,
.
��, -
Column
��- 3
<
��3 4
int
��4 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? D
,
��D E
nullable
��F N
:
��N O
false
��P U
)
��U V
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
PropertyHeights
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
string
��3 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A O
,
��O P
	maxLength
��Q Z
:
��Z [
$num
��\ ^
,
��^ _
nullable
��` h
:
��h i
false
��j o
)
��o p
,
��p q
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 8
,
��8 9
x
��: ;
=>
��< >
x
��? @
.
��@ A
PropertyHeightId
��A Q
)
��Q R
;
��R S
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
PropertyMasterId
�� $
=
��% &
table
��' ,
.
��, -
Column
��- 3
<
��3 4
int
��4 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? D
,
��D E
nullable
��F N
:
��N O
false
��P U
)
��U V
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
PropertyNumber
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
false
��i n
)
��n o
,
��o p
PropertyTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
,
��T U

LocalityId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
	LandUseId
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
int
��- 0
>
��0 1
(
��1 2
type
��2 6
:
��6 7
$str
��8 =
,
��= >
nullable
��? G
:
��G H
false
��I N
)
��N O
,
��O P
LandUseTypeId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
,
��S T
AllocationTypeId
�� $
=
��% &
table
��' ,
.
��, -
Column
��- 3
<
��3 4
int
��4 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? D
,
��D E
nullable
��F N
:
��N O
false
��P U
)
��U V
,
��V W
BlockNumber
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
string
��/ 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= J
,
��J K
	maxLength
��L U
:
��U V
$num
��W X
,
��X Y
nullable
��Z b
:
��b c
true
��d h
)
��h i
,
��i j

PlotNumber
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< I
,
��I J
	maxLength
��K T
:
��T U
$num
��V W
,
��W X
nullable
��Y a
:
��a b
true
��c g
)
��g h
,
��h i

AcreageOne
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
double
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< C
,
��C D
nullable
��E M
:
��M N
false
��O T
)
��T U
,
��U V

AcreageTwo
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
double
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< C
,
��C D
nullable
��E M
:
��M N
false
��O T
)
��T U
,
��U V
PropertyHeightId
�� $
=
��% &
table
��' ,
.
��, -
Column
��- 3
<
��3 4
int
��4 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? D
,
��D E
nullable
��F N
:
��N O
false
��P U
)
��U V
,
��V W

PlotSizeId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
SellingPrice
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
double
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> E
,
��E F
nullable
��G O
:
��O P
false
��Q V
)
��V W
,
��W X

CurrencyId
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q

RentalType
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< J
,
��J K
	maxLength
��L U
:
��U V
$num
��W Y
,
��Y Z
nullable
��[ c
:
��c d
true
��e i
)
��i j
,
��j k 
TotalNumberOfRooms
�� &
=
��' (
table
��) .
.
��. /
Column
��/ 5
<
��5 6
int
��6 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A F
,
��F G
nullable
��H P
:
��P Q
false
��R W
)
��W X
,
��X Y
RoomsOccupied
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
,
��S T
ApartmentTypeId
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
int
��3 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> C
,
��C D
nullable
��E M
:
��M N
false
��O T
)
��T U
,
��U V
SchemeTypeId
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
int
��0 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; @
,
��@ A
nullable
��B J
:
��J K
false
��L Q
)
��Q R
,
��R S$
ApartmentBlockNumberId
�� *
=
��+ ,
table
��- 2
.
��2 3
Column
��3 9
<
��9 :
int
��: =
>
��= >
(
��> ?
type
��? C
:
��C D
$str
��E J
,
��J K
nullable
��L T
:
��T U
false
��V [
)
��[ \
,
��\ ]
BlockTypeId
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
int
��/ 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: ?
,
��? @
nullable
��A I
:
��I J
false
��K P
)
��P Q
,
��Q R
FloorNumberId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
,
��S T
BlockUnitId
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
int
��/ 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: ?
,
��? @
nullable
��A I
:
��I J
false
��K P
)
��P Q
,
��Q R
BlockSideId
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
int
��/ 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: ?
,
��? @
nullable
��A I
:
��I J
false
��K P
)
��P Q
,
��Q R
	FloorArea
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; I
,
��I J
	maxLength
��K T
:
��T U
$num
��V X
,
��X Y
nullable
��Z b
:
��b c
true
��d h
)
��h i
,
��i j

RoomNumber
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
RightOfEntry
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
DateTime
��0 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ K
,
��K L
nullable
��M U
:
��U V
false
��W \
)
��\ ]
,
��] ^
	LeaseTerm
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
int
��- 0
>
��0 1
(
��1 2
type
��2 6
:
��6 7
$str
��8 =
,
��= >
nullable
��? G
:
��G H
false
��I N
)
��N O
,
��O P
LeaseExpiryDate
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
DateTime
��3 ;
>
��; <
(
��< =
type
��= A
:
��A B
$str
��C N
,
��N O
nullable
��P X
:
��X Y
false
��Z _
)
��_ `
,
��` a

DebtorType
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
int
��. 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
GroupNumber
�� 
=
��  !
table
��" '
.
��' (
Column
��( .
<
��. /
int
��/ 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: ?
,
��? @
nullable
��A I
:
��I J
false
��K P
)
��P Q
,
��Q R
CustomerCode
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
string
��0 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> L
,
��L M
	maxLength
��N W
:
��W X
$num
��Y [
,
��[ \
nullable
��] e
:
��e f
true
��g k
)
��k l
,
��l m
SitePlanNumber
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o!
CadastralPlanNumber
�� '
=
��( )
table
��* /
.
��/ 0
Column
��0 6
<
��6 7
string
��7 =
>
��= >
(
��> ?
type
��? C
:
��C D
$str
��E S
,
��S T
	maxLength
��U ^
:
��^ _
$num
��` b
,
��b c
nullable
��d l
:
��l m
true
��n r
)
��r s
,
��s t
CoordinateOne
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
true
��h l
)
��l m
,
��m n
CoordinateTwo
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
true
��h l
)
��l m
,
��m n
CoordinateThree
�� #
=
��$ %
table
��& +
.
��+ ,
Column
��, 2
<
��2 3
string
��3 9
>
��9 :
(
��: ;
type
��; ?
:
��? @
$str
��A O
,
��O P
	maxLength
��Q Z
:
��Z [
$num
��\ ^
,
��^ _
nullable
��` h
:
��h i
true
��j n
)
��n o
,
��o p
CoordinateFour
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o
CoordinateFive
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
string
��2 8
>
��8 9
(
��9 :
type
��: >
:
��> ?
$str
��@ N
,
��N O
	maxLength
��P Y
:
��Y Z
$num
��[ ]
,
��] ^
nullable
��_ g
:
��g h
true
��i m
)
��m n
,
��n o
CoordinateSix
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
true
��h l
)
��l m
,
��m n"
MotherPropertyNumber
�� (
=
��) *
table
��+ 0
.
��0 1
Column
��1 7
<
��7 8
string
��8 >
>
��> ?
(
��? @
type
��@ D
:
��D E
$str
��F T
,
��T U
	maxLength
��V _
:
��_ `
$num
��a c
,
��c d
nullable
��e m
:
��m n
true
��o s
)
��s t
,
��t u
Comments
�� 
=
�� 
table
�� $
.
��$ %
Column
��% +
<
��+ ,
string
��, 2
>
��2 3
(
��3 4
type
��4 8
:
��8 9
$str
��: I
,
��I J
	maxLength
��K T
:
��T U
$num
��V Y
,
��Y Z
nullable
��[ c
:
��c d
true
��e i
)
��i j
,
��j k
IsLargeScale
��  
=
��! "
table
��# (
.
��( )
Column
��) /
<
��/ 0
bool
��0 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
,
��S T
	IsDeleted
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
bool
��- 1
>
��1 2
(
��2 3
type
��3 7
:
��7 8
$str
��9 >
,
��> ?
nullable
��@ H
:
��H I
false
��J O
)
��O P
,
��P Q
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ApprovedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ApprovedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 8
,
��8 9
x
��: ;
=>
��< >
x
��? @
.
��@ A
PropertyMasterId
��A Q
)
��Q R
;
��R S
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
PropertyTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
PropertyTypes
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
false
��h m
)
��m n
,
��n o
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 6
,
��6 7
x
��8 9
=>
��: <
x
��= >
.
��> ?
PropertyTypeId
��? M
)
��M N
;
��N O
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
ResidentTypeId
�� "
=
��# $
table
��% *
.
��* +
Column
��+ 1
<
��1 2
int
��2 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= B
,
��B C
nullable
��D L
:
��L M
false
��N S
)
��S T
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
ResidentTypes
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
string
��1 7
>
��7 8
(
��8 9
type
��9 =
:
��= >
$str
��? M
,
��M N
	maxLength
��O X
:
��X Y
$num
��Z \
,
��\ ]
nullable
��^ f
:
��f g
false
��h m
)
��m n
,
��n o
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 6
,
��6 7
x
��8 9
=>
��: <
x
��= >
.
��> ?
ResidentTypeId
��? M
)
��M N
;
��N O
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
SocialMediaId
�� !
=
��" #
table
��$ )
.
��) *
Column
��* 0
<
��0 1
int
��1 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< A
,
��A B
nullable
��C K
:
��K L
false
��M R
)
��R S
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B!
SocialMediaPlatform
�� '
=
��( )
table
��* /
.
��/ 0
Column
��0 6
<
��6 7
string
��7 =
>
��= >
(
��> ?
type
��? C
:
��C D
$str
��E S
,
��S T
	maxLength
��U ^
:
��^ _
$num
��` b
,
��b c
nullable
��d l
:
��l m
false
��n s
)
��s t
,
��t u
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% 5
,
��5 6
x
��7 8
=>
��9 ;
x
��< =
.
��= >
SocialMediaId
��> K
)
��K L
;
��L M
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateTable
�� (
(
��( )
name
�� 
:
�� 
$str
�� 
,
�� 
schema
�� 
:
�� 
$str
�� 
,
�� 
columns
�� 
:
�� 
table
�� 
=>
�� !
new
��" %
{
�� 
TitleId
�� 
=
�� 
table
�� #
.
��# $
Column
��$ *
<
��* +
int
��+ .
>
��. /
(
��/ 0
type
��0 4
:
��4 5
$str
��6 ;
,
��; <
nullable
��= E
:
��E F
false
��G L
)
��L M
.
�� 

Annotation
�� #
(
��# $
$str
��$ 8
,
��8 9
$str
��: @
)
��@ A
,
��A B
Titles
�� 
=
�� 
table
�� "
.
��" #
Column
��# )
<
��) *
string
��* 0
>
��0 1
(
��1 2
type
��2 6
:
��6 7
$str
��8 F
,
��F G
	maxLength
��H Q
:
��Q R
$num
��S U
,
��U V
nullable
��W _
:
��_ `
false
��a f
)
��f g
,
��g h
	CreatedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	CreatedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
,
��[ \

ModifiedOn
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
DateTime
��. 6
>
��6 7
(
��7 8
type
��8 <
:
��< =
$str
��> I
,
��I J
nullable
��K S
:
��S T
false
��U Z
)
��Z [
,
��[ \

ModifiedBy
�� 
=
��  
table
��! &
.
��& '
Column
��' -
<
��- .
string
��. 4
>
��4 5
(
��5 6
type
��6 :
:
��: ;
$str
��< K
,
��K L
nullable
��M U
:
��U V
true
��W [
)
��[ \
,
��\ ]
	DeletedOn
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
DateTime
��- 5
>
��5 6
(
��6 7
type
��7 ;
:
��; <
$str
��= H
,
��H I
nullable
��J R
:
��R S
false
��T Y
)
��Y Z
,
��Z [
	DeletedBy
�� 
=
�� 
table
��  %
.
��% &
Column
��& ,
<
��, -
string
��- 3
>
��3 4
(
��4 5
type
��5 9
:
��9 :
$str
��; J
,
��J K
nullable
��L T
:
��T U
true
��V Z
)
��Z [
}
�� 
,
�� 
constraints
�� 
:
�� 
table
�� "
=>
��# %
{
�� 
table
�� 
.
�� 

PrimaryKey
�� $
(
��$ %
$str
��% /
,
��/ 0
x
��1 2
=>
��3 5
x
��6 7
.
��7 8
TitleId
��8 ?
)
��? @
;
��@ A
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� !
,
��! "
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! -
,
��- .
$str
��/ D
,
��D E
$str
��F T
,
��T U
$str
��V a
,
��a b
$str
��c n
,
��n o
$str
��p {
,
��{ |
$str��} �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
$str
�� 6
,
��6 7
$str
��8 A
,
��A B
null
��C G
,
��G H
new
��I L
DateTime
��M U
(
��U V
$num
��V W
,
��W X
$num
��Y Z
,
��Z [
$num
��\ ]
,
��] ^
$num
��_ `
,
��` a
$num
��b c
,
��c d
$num
��e f
,
��f g
$num
��h i
,
��i j
DateTimeKind
��k w
.
��w x
Unspecified��x �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� B
,
��B C
$str
��D N
,
��N O
null
��P T
,
��T U
new
��V Y
DateTime
��Z b
(
��b c
$num
��c d
,
��d e
$num
��f g
,
��g h
$num
��i j
,
��j k
$num
��l m
,
��m n
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
DateTimeKind��x �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 1
,
��1 2
$str
��3 ?
,
��? @
$str
��A Z
,
��Z [
$str
��\ n
,
��n o
$str
��p {
,
��{ |
$str��} �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
$num
�� 
,
�� 
$str
�� ,
,
��, -
$str
��. B
,
��B C
null
��D H
,
��H I
new
��J M
DateTime
��N V
(
��V W
$num
��W X
,
��X Y
$num
��Z [
,
��[ \
$num
��] ^
,
��^ _
$num
��` a
,
��a b
$num
��c d
,
��d e
$num
��f g
,
��g h
$num
��i j
,
��j k
DateTimeKind
��l x
.
��x y
Unspecified��y �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$num
�� 
,
�� 
$str
�� C
,
��C D
$str
��E X
,
��X Y
null
��Z ^
,
��^ _
new
��` c
DateTime
��d l
(
��l m
$num
��m n
,
��n o
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$num
�� 
,
�� 
$str
�� ;
,
��; <
$str
��= K
,
��K L
null
��M Q
,
��Q R
new
��S V
DateTime
��W _
(
��_ `
$num
��` a
,
��a b
$num
��c d
,
��d e
$num
��f g
,
��g h
$num
��i j
,
��j k
$num
��l m
,
��m n
$num
��o p
,
��p q
$num
��r s
,
��s t
DateTimeKind��u �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$num
�� 
,
�� 
$str
�� E
,
��E F
$str
��G V
,
��V W
null
��X \
,
��\ ]
new
��^ a
DateTime
��b j
(
��j k
$num
��k l
,
��l m
$num
��n o
,
��o p
$num
��q r
,
��r s
$num
��t u
,
��u v
$num
��w x
,
��x y
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$num
�� 
,
�� 
$str
�� E
,
��E F
$str
��G W
,
��W X
null
��Y ]
,
��] ^
new
��_ b
DateTime
��c k
(
��k l
$num
��l m
,
��m n
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 3
,
��3 4
$str
��5 L
,
��L M
$str
��N _
,
��_ `
$str
��a l
,
��l m
$str
��n y
,
��y z
$str��{ �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  3
,
��3 4
null
��5 9
,
��9 :
new
��; >
DateTime
��? G
(
��G H
$num
��H I
,
��I J
$num
��K L
,
��L M
$num
��N O
,
��O P
$num
��Q R
,
��R S
$num
��T U
,
��U V
$num
��W X
,
��X Y
$num
��Z [
,
��[ \
DateTimeKind
��] i
.
��i j
Unspecified
��j u
)
��u v
,
��v w
null
��x |
,
��| }
new��~ �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  -
,
��- .
null
��/ 3
,
��3 4
new
��5 8
DateTime
��9 A
(
��A B
$num
��B C
,
��C D
$num
��E F
,
��F G
$num
��H I
,
��I J
$num
��K L
,
��L M
$num
��N O
,
��O P
$num
��Q R
,
��R S
$num
��T U
,
��U V
DateTimeKind
��W c
.
��c d
Unspecified
��d o
)
��o p
,
��p q
null
��r v
,
��v w
new
��x {
DateTime��| �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  0
,
��0 1
null
��2 6
,
��6 7
new
��8 ;
DateTime
��< D
(
��D E
$num
��E F
,
��F G
$num
��H I
,
��I J
$num
��K L
,
��L M
$num
��N O
,
��O P
$num
��Q R
,
��R S
$num
��T U
,
��U V
$num
��W X
,
��X Y
DateTimeKind
��Z f
.
��f g
Unspecified
��g r
)
��r s
,
��s t
null
��u y
,
��y z
new
��{ ~
DateTime�� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  6
,
��6 7
null
��8 <
,
��< =
new
��> A
DateTime
��B J
(
��J K
$num
��K L
,
��L M
$num
��N O
,
��O P
$num
��Q R
,
��R S
$num
��T U
,
��U V
$num
��W X
,
��X Y
$num
��Z [
,
��[ \
$num
��] ^
,
��^ _
DateTimeKind
��` l
.
��l m
Unspecified
��m x
)
��x y
,
��y z
null
��{ 
,�� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  :
,
��: ;
null
��< @
,
��@ A
new
��B E
DateTime
��F N
(
��N O
$num
��O P
,
��P Q
$num
��R S
,
��S T
$num
��U V
,
��V W
$num
��X Y
,
��Y Z
$num
��[ \
,
��\ ]
$num
��^ _
,
��_ `
$num
��a b
,
��b c
DateTimeKind
��d p
.
��p q
Unspecified
��q |
)
��| }
,
��} ~
null�� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  <
,
��< =
null
��> B
,
��B C
new
��D G
DateTime
��H P
(
��P Q
$num
��Q R
,
��R S
$num
��T U
,
��U V
$num
��W X
,
��X Y
$num
��Z [
,
��[ \
$num
��] ^
,
��^ _
$num
��` a
,
��a b
$num
��c d
,
��d e
DateTimeKind
��f r
.
��r s
Unspecified
��s ~
)
��~ 
,�� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 
,
�� 
$str
��  ;
,
��; <
null
��= A
,
��A B
new
��C F
DateTime
��G O
(
��O P
$num
��P Q
,
��Q R
$num
��S T
,
��T U
$num
��V W
,
��W X
$num
��Y Z
,
��Z [
$num
��\ ]
,
��] ^
$num
��_ `
,
��` a
$num
��b c
,
��c d
DateTimeKind
��e q
.
��q r
Unspecified
��r }
)
��} ~
,
��~ 
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 2
,
��2 3
$str
��4 C
,
��C D
$str
��E P
,
��P Q
$str
��R ]
,
��] ^
$str
��_ k
,
��k l
$str
��m x
,
��x y
$str��z �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
$str
�� !
,
��! "
null
��# '
,
��' (
new
��) ,
DateTime
��- 5
(
��5 6
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
$num
��B C
,
��C D
$num
��E F
,
��F G
$num
��H I
,
��I J
DateTimeKind
��K W
.
��W X
Unspecified
��X c
)
��c d
,
��d e
$num
��f g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� &
,
��& '
null
��( ,
,
��, -
new
��. 1
DateTime
��2 :
(
��: ;
$num
��; <
,
��< =
$num
��> ?
,
��? @
$num
��A B
,
��B C
$num
��D E
,
��E F
$num
��G H
,
��H I
$num
��J K
,
��K L
$num
��M N
,
��N O
DateTimeKind
��P \
.
��\ ]
Unspecified
��] h
)
��h i
,
��i j
$num
��k l
,
��l m
null
��n r
,
��r s
new
��t w
DateTime��x �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� 0
,
��0 1
null
��2 6
,
��6 7
new
��8 ;
DateTime
��< D
(
��D E
$num
��E F
,
��F G
$num
��H I
,
��I J
$num
��K L
,
��L M
$num
��N O
,
��O P
$num
��Q R
,
��R S
$num
��T U
,
��U V
$num
��W X
,
��X Y
DateTimeKind
��Z f
.
��f g
Unspecified
��g r
)
��r s
,
��s t
$num
��u v
,
��v w
null
��x |
,
��| }
new��~ �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
$str
�� '
,
��' (
null
��) -
,
��- .
new
��/ 2
DateTime
��3 ;
(
��; <
$num
��< =
,
��= >
$num
��? @
,
��@ A
$num
��B C
,
��C D
$num
��E F
,
��F G
$num
��H I
,
��I J
$num
��K L
,
��L M
$num
��N O
,
��O P
DateTimeKind
��Q ]
.
��] ^
Unspecified
��^ i
)
��i j
,
��j k
$num
��l m
,
��m n
null
��o s
,
��s t
new
��u x
DateTime��y �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 1
,
��1 2
$str
��3 >
,
��> ?
$str
��@ K
,
��K L
$str
��M \
,
��\ ]
$str
��^ i
,
��i j
$str
��k v
,
��v w
$str��x �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ h
,
��h i
null
��j n
,
��n o
new
��p s
DateTime
��t |
(
��| }
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ m
,
��m n
null
��o s
,
��s t
new
��u x
DateTime��y �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ m
,
��m n
null
��o s
,
��s t
new
��u x
DateTime��y �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ i
,
��i j
null
��k o
,
��o p
new
��q t
DateTime
��u }
(
��} ~
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
��  
,
��  !
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! ,
,
��, -
$str
��. 9
,
��9 :
$str
��; F
,
��F G
$str
��H S
,
��S T
$str
��U `
,
��` a
$str
��b r
,
��r s
$str��t �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� $
,
��$ %
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 0
,
��0 1
$str
��2 =
,
��= >
$str
��? J
,
��J K
$str
��L W
,
��W X
$str
��Y d
,
��d e
$str
��f q
,
��q r
$str��s �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
null
��] a
,
��a b
new
��c f
DateTime
��g o
(
��o p
$num
��p q
,
��q r
$num
��s t
,
��t u
$num
��v w
,
��w x
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$num��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� !
,
��! "
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! -
,
��- .
$str
��/ :
,
��: ;
$str
��< G
,
��G H
$str
��I W
,
��W X
$str
��Y n
,
��n o
$str
��p {
,
��{ |
$str��} �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
$str
��\ `
,
��` a
$num
��b d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c d
,
��d e
null
��f j
,
��j k
new
��l o
DateTime
��p x
(
��x y
$num
��y z
,
��z {
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] a
,
��a b
$num
��c e
,
��e f
null
��g k
,
��k l
new
��m p
DateTime
��q y
(
��y z
$num
��z {
,
��{ |
$num
��} ~
,
��~ 
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d f
,
��f g
null
��h l
,
��l m
new
��n q
DateTime
��r z
(
��z {
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
��  #
DateTime
��$ ,
(
��, -
$num
��- .
,
��. /
$num
��0 1
,
��1 2
$num
��3 4
,
��4 5
$num
��6 7
,
��7 8
$num
��9 :
,
��: ;
$num
��< =
,
��= >
$num
��? @
,
��@ A
DateTimeKind
��B N
.
��N O
Unspecified
��O Z
)
��Z [
,
��[ \
$str
��] b
,
��b c
$num
��d g
,
��g h
null
��i m
,
��m n
new
��o r
DateTime
��s {
(
��{ |
$num
��| }
,
��} ~
$num�� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
,��� �
$str��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 1
,
��1 2
$str
��3 >
,
��> ?
$str
��@ K
,
��K L
$str
��M X
,
��X Y
$str
��Z e
,
��e f
$str
��g s
,
��s t
$str��u �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 

InsertData
�� '
(
��' (
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 1
,
��1 2
$str
��3 >
,
��> ?
$str
��@ K
,
��K L
$str
��M X
,
��X Y
$str
��Z e
,
��e f
$str
��g s
,
��s t
$str��u �
,��� �
$str��� �
}��� �
,��� �
values
�� 
:
�� 
new
�� 
object
�� "
[
��" #
,
��# $
]
��$ %
{
�� 
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
,��� �
{
�� 
$num
�� 
,
�� 
null
�� 
,
�� 
new
�� "
DateTime
��# +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 0
,
��0 1
$num
��2 3
,
��3 4
$num
��5 6
,
��6 7
$num
��8 9
,
��9 :
$num
��; <
,
��< =
$num
��> ?
,
��? @
DateTimeKind
��A M
.
��M N
Unspecified
��N Y
)
��Y Z
,
��Z [
null
��\ `
,
��` a
new
��b e
DateTime
��f n
(
��n o
$num
��o p
,
��p q
$num
��r s
,
��s t
$num
��u v
,
��v w
$num
��x y
,
��y z
$num
��{ |
,
��| }
$num
��~ 
,�� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
null��� �
,��� �
new��� �
DateTime��� �
(��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
$num��� �
,��� �
DateTimeKind��� �
.��� �
Unspecified��� �
)��� �
,��� �
$str��� �
}��� �
}
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 0
,
��0 1
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� !
,
��! "
column
�� 
:
�� 
$str
�� &
,
��& '
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 8
,
��8 9
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
column
�� 
:
�� 
$str
�� *
,
��* +
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� O
,
��O P
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 8
,
��8 9
$str
��: K
}
��L M
,
��M N
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 7
,
��7 8
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
column
�� 
:
�� 
$str
�� '
,
��' (
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 6
,
��6 7
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
column
�� 
:
�� 
$str
�� &
,
��& '
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 5
,
��5 6
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
column
�� 
:
�� 
$str
�� '
,
��' (
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 1
,
��1 2
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
��  
,
��  !
column
�� 
:
�� 
$str
�� (
,
��( )
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� .
,
��. /
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
��  
,
��  !
column
�� 
:
�� 
$str
�� %
,
��% &
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� I
,
��I J
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� $
,
��$ %
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 5
,
��5 6
$str
��7 H
}
��I J
,
��J K
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� @
,
��@ A
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� !
,
��! "
columns
�� 
:
�� 
new
�� 
[
�� 
]
�� 
{
��  
$str
��! 2
,
��2 3
$str
��4 B
}
��C D
,
��D E
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 8
,
��8 9
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� '
,
��' (
column
�� 
:
�� 
$str
�� (
,
��( )
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 5
,
��5 6
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
column
�� 
:
�� 
$str
�� '
,
��' (
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
CreateIndex
�� (
(
��( )
name
�� 
:
�� 
$str
�� 5
,
��5 6
schema
�� 
:
�� 
$str
�� 
,
�� 
table
�� 
:
�� 
$str
�� %
,
��% &
column
�� 
:
�� 
$str
�� '
,
��' (
unique
�� 
:
�� 
true
�� 
)
�� 
;
�� 
}
�� 	
	protected
�� 
override
�� 
void
�� 
Down
��  $
(
��$ %
MigrationBuilder
��% 5
migrationBuilder
��6 F
)
��F G
{
�� 	
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
��  
,
��  !
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� "
,
��" #
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� "
,
��" #
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� !
,
��! "
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� "
,
��" #
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� 
,
�� 
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� *
,
��* +
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� 
,
��  
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
��  
,
��  !
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� %
,
��% &
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
��  
,
��  !
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� &
,
��& '
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� $
,
��$ %
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� #
,
��# $
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
migrationBuilder
�� 
.
�� 
	DropTable
�� &
(
��& '
name
�� 
:
�� 
$str
�� 
,
�� 
schema
�� 
:
�� 
$str
�� 
)
�� 
;
�� 
}
�� 	
}
�� 
}�� �	
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Extensions/ServiceCollectionExtensions.cs
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
;	 �
return 
services 
; 
} 
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ResidentTypeConfiguration.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/PropertyTypeConfiguration.cs
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
} �d
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LocalityConfiguration.cs
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
}AA �3
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LandUseTypeConfiguration.cs
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
}.. �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/LandUseConfiguration.cs
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
}.. �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/CustomerTypeConfiguration.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ApartmentTypesConfiguration.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/AllocationTypeConfiguration.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ActivityTypeConfiguration.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ActivityConfiguration.cs
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
} �D
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