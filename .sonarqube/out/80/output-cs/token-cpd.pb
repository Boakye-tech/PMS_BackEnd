n
l/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Usings.cs¬*
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Services/Azure/AzureBlobService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Services+ 3
.3 4
Azure4 9
{ 
public 

class 
AzureBlobService !
:" #
IAzureBlobService$ 5
{ 
private		 
readonly		 
BlobServiceClient		 *
_blobServiceClient		+ =
;		= >
public 
AzureBlobService 
(  
BlobServiceClient  1
blobServiceClient2 C
)C D
{ 	
_blobServiceClient 
=  
blobServiceClient! 2
;2 3
} 	
private 
BlobContainerClient #
GetContainerClient$ 6
(6 7
string7 =
blobContainerName> O
)O P
{ 	
var 
containerClient 
=  !
_blobServiceClient" 4
.4 5"
GetBlobContainerClient5 K
(K L
blobContainerNameL ]
)] ^
;^ _
containerClient 
. 
CreateIfNotExists -
(- .
PublicAccessType. >
.> ?
Blob? C
)C D
;D E
return 
containerClient "
;" #
} 	
static 
string 
ExtractBlobName %
(% &
string& ,
blobContainerName- >
,> ?
string@ F
blobUrlG N
)N O
{ 	
blobUrl 
= 
HttpUtility !
.! "
	UrlDecode" +
(+ ,
blobUrl, 3
)3 4
;4 5
Uri 
uri 
= 
new 
Uri 
( 
blobUrl %
)% &
;& '
string 
path 
= 
uri 
. 
AbsolutePath *
;* +
string 
blobName 
= 
path "
." #
Replace# *
(* +
$"+ -
$str- .
{. /
blobContainerName/ @
}@ A
$strA B
"B C
,C D
$strE G
)G H
;H I
blobName!! 
=!! 
HttpUtility!! "
.!!" #
	UrlDecode!!# ,
(!!, -
blobName!!- 5
)!!5 6
;!!6 7
return"" 
blobName"" 
;"" 
}## 	
public%% 
async%% 
Task%% 
<%% 
Uri%% 
>%% 
UploadFileBlobAsync%% 2
(%%2 3
string%%3 9
blobContainerName%%: K
,%%K L
Stream%%M S
content%%T [
,%%[ \
string%%] c
contentType%%d o
,%%o p
string%%q w
fileName	%%x Ä
)
%%Ä Å
{&& 	
var'' 
containerClient'' 
=''  !
GetContainerClient''" 4
(''4 5
blobContainerName''5 F
)''F G
;''G H
var(( 

blobClient(( 
=(( 
containerClient(( ,
.((, -
GetBlobClient((- :
(((: ;
fileName((; C
)((C D
;((D E
await)) 

blobClient)) 
.)) 
UploadAsync)) (
())( )
content))) 0
,))0 1
new))2 5
BlobHttpHeaders))6 E
{))F G
ContentType))H S
=))T U
contentType))V a
}))b c
)))c d
;))d e
return** 

blobClient** 
.** 
Uri** !
;**! "
}++ 	
public-- 
async-- 
Task-- 
<-- 
string--  
>--  !
DeleteFileBlobAsync--" 5
(--5 6
string--6 <
blobContainerName--= N
,--N O
string--P V
fileName--W _
)--_ `
{.. 	
fileName// 
=// 
ExtractBlobName// &
(//& '
blobContainerName//' 8
,//8 9
fileName//9 A
)//A B
;//B C
var11 
containerClient11 
=11  !
GetContainerClient11" 4
(114 5
blobContainerName115 F
)11F G
;11G H
var22 

blobClient22 
=22 
containerClient22 ,
.22, -
GetBlobClient22- :
(22: ;
fileName22; C
)22C D
;22D E
bool44 
exists44 
=44 
await44 

blobClient44  *
.44* +
DeleteIfExistsAsync44+ >
(44> ?
)44? @
;44@ A
if66 
(66 
exists66 
)66 
{77 
return88 
$"88 
$str88 #
{88# $
fileName88$ ,
}88, -
$str88- D
"88D E
;88E F
}99 
else:: 
{;; 
return<< 
$"<< 
$str<< #
{<<# $
fileName<<$ ,
}<<, -
$str<<- >
"<<> ?
;<<? @
}>> 
}AA 	
}DD 
}EE Ô"
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/UnitOfWork.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
{ 
public 
class 

UnitOfWork 
: 
IUnitOfWork &
{ 
private 
bool 
disposedValue "
;" #
private		 
readonly		  
ApplicationDBContext		 -

_dbContext		. 8
;		8 9
public 

UnitOfWork 
(  
ApplicationDBContext .
	dbContext/ 8
)8 9
{ 

_dbContext 
= 
	dbContext "
;" #
CustomerDetails 
= 
new !%
CustomerDetailsRepository" ;
(; <

_dbContext< F
)F G
;G H
PropertyDetails 
= 
new !%
PropertyDetailsRepository" ;
(; <

_dbContext< F
)F G
;G H
CustomerInvoice 
= 
new !%
CustomerInvoiceRepository" ;
(; <

_dbContext< F
)F G
;G H 
CustomerInvoiceItems  
=! "
new# &*
CustomerInvoiceItemsRepository' E
(E F

_dbContextF P
)P Q
;Q R
CustomerPayment 
= 
new !&
CustomerPaymentsRepository" <
(< =

_dbContext= G
)G H
;H I
CustomerTransaction 
=  !
new" %*
CustomerTransactionsRepository& D
(D E

_dbContextE O
)O P
;P Q
} 	
public &
ICustomerDetailsRepository )
CustomerDetails* 9
{: ;
get< ?
;? @
privateA H
setI L
;L M
}N O
public &
ICustomerInvoiceRepository )
CustomerInvoice* 9
{: ;
get< ?
;? @
privateA H
setI L
;L M
}N O
public +
ICustomerInvoiceItemsRepository . 
CustomerInvoiceItems/ C
{D E
getF I
;I J
privateK R
setS V
;V W
}X Y
public '
ICustomerPaymentsRepository *
CustomerPayment+ :
{; <
get= @
;@ A
privateB I
setJ M
;M N
}O P
public   +
ICustomerTransactionsRepository   .
CustomerTransaction  / B
{  C D
get  E H
;  H I
private  J Q
set  R U
;  U V
}  W X
public"" &
IPropertyDetailsRepository"" )
PropertyDetails""* 9
{"": ;
get""< ?
;""? @
private""A H
set""I L
;""L M
}""N O
public%% 
Task%% 
<%% 
int%% 
>%% 
Complete%% !
(%%! "
)%%" #
{&& 	
return'' 

_dbContext'' 
.'' 
SaveChangesAsync'' .
(''. /
)''/ 0
;''0 1
}(( 	
	protected** 
virtual** 
void** 
Dispose** &
(**& '
bool**' +
	disposing**, 5
)**5 6
{++ 	
if,, 
(,, 
!,, 
disposedValue,, 
),, 
{-- 
if.. 
(.. 
	disposing.. 
).. 
{// 

_dbContext11 
.11 
Dispose11 &
(11& '
)11' (
;11( )
}22 
disposedValue66 
=66 
true66  $
;66$ %
}77 
}88 	
public:: 
void:: 
Dispose:: 
(:: 
):: 
{;; 	
Dispose== 
(== 
	disposing== 
:== 
true== #
)==# $
;==$ %
GC>> 
.>> 
SuppressFinalize>> 
(>>  
this>>  $
)>>$ %
;>>% &
}?? 	
}@@ 
}AA úE
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Repository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
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
:G H
classI N
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
public 
async 
Task 
< 
TEntity !
?! "
>" #
Get$ '
(' (
string( .
name/ 3
)3 4
=>5 7
await8 =

_dbContext> H
.H I
SetI L
<L M
TEntityM T
>T U
(U V
)V W
.W X
	FindAsyncX a
(a b
nameb f
)f g
;g h
public 
async 
Task 
< 
TEntity !
?! "
>" #
Get$ '
(' (

Expression( 2
<2 3
Func3 7
<7 8
TEntity8 ?
,? @
boolA E
>E F
>F G

expressionH R
,R S
ListT X
<X Y
stringY _
>_ `
?` a
includesb j
=k l
nullm q
)q r
{ 	

IQueryable 
< 
TEntity 
> 
entities  (
=) *

_dbContext+ 5
.5 6
Set6 9
<9 :
TEntity: A
>A B
(B C
)C D
;D E
if 
( 
includes 
!= 
null  
)  !
{ 
foreach 
( 
var 
includeProp (
in) +
includes, 4
)4 5
{ 
entities   
=   
entities   '
.  ' (
Include  ( /
(  / 0
includeProp  0 ;
)  ; <
;  < =
}!! 
}"" 
return$$ 
await$$ 
entities$$ !
.$$! "
AsNoTracking$$" .
($$. /
)$$/ 0
.$$0 1
FirstOrDefaultAsync$$1 D
($$D E

expression$$E O
)$$O P
;$$P Q
}%% 	
public'' 
async'' 
Task'' 
<'' 
IList'' 
<''  
TEntity''  '
>''' (
>''( )
GetAll''* 0
(''0 1

Expression''1 ;
<''; <
Func''< @
<''@ A
TEntity''A H
,''H I
bool''J N
>''N O
>''O P
?''P Q

expression''R \
=''] ^
null''_ c
,''c d
Func''e i
<''i j

IQueryable''j t
<''t u
TEntity''u |
>''| }
,''} ~
IOrderedQueryable	'' ê
<
''ê ë
TEntity
''ë ò
>
''ò ô
>
''ô ö
?
''ö õ
orderBy
''ú £
=
''§ •
null
''¶ ™
,
''™ ´
List
''¨ ∞
<
''∞ ±
string
''± ∑
>
''∑ ∏
?
''∏ π
includes
''∫ ¬
=
''√ ƒ
null
''≈ …
)
''…  
{(( 	

IQueryable)) 
<)) 
TEntity)) 
>)) 
query))  %
=))& '

_dbContext))( 2
.))2 3
Set))3 6
<))6 7
TEntity))7 >
>))> ?
())? @
)))@ A
;))A B
if++ 
(++ 

expression++ 
!=++ 
null++ "
)++" #
query,, 
=,, 
query,, 
.,, 
Where,, #
(,,# $

expression,,$ .
),,. /
;,,/ 0
if.. 
(.. 
includes.. 
!=.. 
null..  
)..  !
{// 
foreach00 
(00 
var00 
includeProperty00 ,
in00- /
includes000 8
)008 9
query11 
=11 
query11 !
.11! "
Include11" )
(11) *
includeProperty11* 9
)119 :
;11: ;
}22 
if44 
(44 
orderBy44 
!=44 
null44 
)44  
query55 
=55 
orderBy55 
(55  
query55  %
)55% &
;55& '
return77 
await77 
query77 
.77 
AsNoTracking77 +
(77+ ,
)77, -
.77- .
ToListAsync77. 9
(779 :
)77: ;
;77; <
}88 	
public:: 
async:: 
Task:: 
<:: 
IList:: 
<::  
TEntity::  '
>::' (
>::( )
GetAll::* 0
(::0 1
)::1 2
=>::3 5
await::6 ;

_dbContext::< F
.::F G
Set::G J
<::J K
TEntity::K R
>::R S
(::S T
)::T U
.::U V
ToListAsync::V a
(::a b
)::b c
;::c d
public<< 
async<< 
void<< 
Insert<<  
(<<  !
TEntity<<! (
entity<<) /
)<</ 0
=><<1 3
await<<4 9

_dbContext<<: D
.<<D E
Set<<E H
<<<H I
TEntity<<I P
><<P Q
(<<Q R
)<<R S
.<<S T
AddAsync<<T \
(<<\ ]
entity<<] c
)<<c d
;<<d e
public>> 
async>> 
void>> 
InsertRange>> %
(>>% &
IEnumerable>>& 1
<>>1 2
TEntity>>2 9
>>>9 :
entities>>; C
)>>C D
=>>>E G
await>>H M

_dbContext>>N X
.>>X Y
Set>>Y \
<>>\ ]
TEntity>>] d
>>>d e
(>>e f
)>>f g
.>>g h
AddRangeAsync>>h u
(>>u v
entities>>v ~
)>>~ 
;	>> Ä
public@@ 
void@@ 
Update@@ 
(@@ 
TEntity@@ "
entity@@# )
)@@) *
=>@@+ -

_dbContext@@. 8
.@@8 9
Set@@9 <
<@@< =
TEntity@@= D
>@@D E
(@@E F
)@@F G
.@@G H
Update@@H N
(@@N O
entity@@O U
)@@U V
;@@V W
publicBB 
voidBB 
UpdateRangeBB 
(BB  
IEnumerableBB  +
<BB+ ,
TEntityBB, 3
>BB3 4
entitiesBB5 =
)BB= >
=>BB? A

_dbContextBBB L
.BBL M
SetBBM P
<BBP Q
TEntityBBQ X
>BBX Y
(BBY Z
)BBZ [
.BB[ \
UpdateRangeBB\ g
(BBg h
entitiesBBh p
)BBp q
;BBq r
}EE 
}FF ∫
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/PropertyDetailsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class %
PropertyDetailsRepository '
:( )

Repository* 4
<4 5
PropertyDetails5 D
>D E
,E F&
IPropertyDetailsRepositoryG a
{ 
public %
PropertyDetailsRepository	 "
(" # 
ApplicationDBContext# 7
	dbContext8 A
)A B
:C D
baseE I
(I J
	dbContextJ S
)S T
{ 	
} 
}		 
}

 ”
¶/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerTransactionsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class *
CustomerTransactionsRepository ,
:- .

Repository/ 9
<9 : 
CustomerTransactions: N
>N O
,O P+
ICustomerTransactionsRepositoryQ p
{ 
public *
CustomerTransactionsRepository	 '
(' ( 
ApplicationDBContext( <
	dbContext= F
)F G
:H I
baseJ N
(N O
	dbContextO X
)X Y
{ 	
} 
}		 
}

 ø
¢/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerPaymentsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class &
CustomerPaymentsRepository (
:) *

Repository+ 5
<5 6
CustomerPayments6 F
>F G
,G H'
ICustomerPaymentsRepositoryI d
{ 
public &
CustomerPaymentsRepository	 #
(# $ 
ApplicationDBContext$ 8
	dbContext9 B
)B C
:D E
baseF J
(J K
	dbContextK T
)T U
{ 	
} 
}		 
}

 ”
¶/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerInvoiceItemsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class *
CustomerInvoiceItemsRepository ,
:- .

Repository/ 9
<9 : 
CustomerInvoiceItems: N
>N O
,O P+
ICustomerInvoiceItemsRepositoryQ p
{ 
public *
CustomerInvoiceItemsRepository	 '
(' ( 
ApplicationDBContext( <
	dbContext= F
)F G
:H I
baseJ N
(N O
	dbContextO X
)X Y
{ 	
} 
}		 
}

 ∫
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerDetailsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class %
CustomerDetailsRepository '
:( )

Repository* 4
<4 5
CustomerDetails5 D
>D E
,E F&
ICustomerDetailsRepositoryG a
{ 
public %
CustomerDetailsRepository	 "
(" # 
ApplicationDBContext# 7
	dbContext8 A
)A B
:C D
baseE I
(I J
	dbContextJ S
)S T
{ 	
}		 
}

 
} ∫
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerInvoiceRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
.6 7
Repositories7 C
.C D
EntitiesD L
{ 
public 
class %
CustomerInvoiceRepository '
:( )

Repository* 4
<4 5
CustomerInvoice5 D
>D E
,E F&
ICustomerInvoiceRepositoryG a
{ 
public %
CustomerInvoiceRepository	 "
(" # 
ApplicationDBContext# 7
	dbContext8 A
)A B
:C D
baseE I
(I J
	dbContextJ S
)S T
{ 	
} 
}		 
}

 û3
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/ApplicationDBContext.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +
Persistence+ 6
;6 7
public 
class  
ApplicationDBContext !
:" #
ModuleDbContext$ 3
{ 
	protected 
override 
string 
Schema $
=>% '
$str( -
;- .
public

 
 
ApplicationDBContext

 
(

  
DbContextOptions

  0
<

0 1 
ApplicationDBContext

1 E
>

E F
options

G N
)

N O
:

P Q
base

R V
(

V W
options

W ^
)

^ _
{ 
} 
public 

DbSet 
< 
	Complaint 
> 
	Complaint %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

DbSet 
< 
CustomerDetails  
>  !
CustomerDetails" 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public 

DbSet 
< 
PropertyDetails  
>  !
PropertyDetails" 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public 

DbSet 
< 
CustomerInvoice  
>  !
CustomerInvoice" 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public 

DbSet 
<  
CustomerInvoiceItems %
>% & 
CustomerInvoiceItems' ;
{< =
get> A
;A B
setC F
;F G
}H I
public 

DbSet 
< 
CustomerPayments !
>! "
CustomerPayments# 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
public 

DbSet 
<  
CustomerTransactions %
>% & 
CustomerTransactions' ;
{< =
get> A
;A B
setC F
;F G
}H I
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{ 
base 
. 
OnModelCreating 
( 
modelBuilder )
)) *
;* +
modelBuilder 
. 
HasDefaultSchema %
(% &
Schema& ,
), -
;- .
modelBuilder!! 
.!! 
Entity!! 
<!! 
CustomerDetails!! +
>!!+ ,
(!!, -
)!!- .
."" 
HasIndex"" 
("" 
pm"" 
=>"" 
pm"" 
."" 
CustomerCode"" +
)""+ ,
.## 
IsUnique## 
(## 
true## 
)## 
;## 
modelBuilder%% 
.%% 
Entity%% 
<%% 
PropertyDetails%% +
>%%+ ,
(%%, -
)%%- .
.&& 
HasIndex&& 
(&& 
pm&& 
=>&& 
pm&& 
.&& 
PropertyNumber&& -
)&&- .
.'' 
IsUnique'' 
('' 
true'' 
)'' 
;'' 
modelBuilder)) 
.)) 
Entity)) 
<))  
CustomerTransactions)) 0
>))0 1
())1 2
)))2 3
.** 
HasIndex** 
(** 
pm** 
=>** 
pm** 
.** 
VoucherNumber** ,
)**, -
.++ 
IsUnique++ 
(++ 
true++ 
)++ 
;++ 
modelBuilder-- 
.-- 
Entity-- 
<-- 
CustomerInvoice-- +
>--+ ,
(--, -
)--- .
... 
HasIndex.. 
(.. 
pm.. 
=>.. 
pm.. 
... 
InvoiceNumber.. ,
).., -
.// 
IsUnique// 
(// 
true// 
)// 
;// 
modelBuilder11 
.11 
Entity11 
<11 
CustomerPayments11 ,
>11, -
(11- .
)11. /
.22 
HasIndex22 
(22 
pm22 
=>22 
pm22 
.22 
ReceiptNumber22 ,
)22, -
.33 
IsUnique33 
(33 
true33 
)33 
;33 
modelBuilder55 
.55 
Entity55 
<55  
CustomerTransactions55 0
>550 1
(551 2
)552 3
.66 
HasIndex66 
(66 
ct66 
=>66 
new66 
{66  !
ct66" $
.66$ %
VoucherNumber66% 2
,662 3
ct664 6
.666 7
CustomerCode667 C
}66D E
)66E F
.77 
IsUnique77 
(77 
true77 
)77 
;77 
modelBuilder99 
.99 
Entity99 
<99 
CustomerInvoice99 +
>99+ ,
(99, -
)99- .
.:: 
HasIndex:: 
(:: 
ct:: 
=>:: 
new:: 
{::  !
ct::" $
.::$ %
InvoiceNumber::% 2
,::2 3
ct::4 6
.::6 7
CustomerCode::7 C
}::D E
)::E F
.;; 
IsUnique;; 
(;; 
true;; 
);; 
;;; 
modelBuilder== 
.== 
Entity== 
<== 
CustomerPayments== ,
>==, -
(==- .
)==. /
.>> 
HasIndex>> 
(>> 
ct>> 
=>>> 
new>> 
{>>  !
ct>>" $
.>>$ %
ReceiptNumber>>% 2
,>>2 3
ct>>4 6
.>>6 7
CustomerCode>>7 C
}>>D E
)>>E F
.?? 
IsUnique?? 
(?? 
true?? 
)?? 
;?? 
}@@ 
}AA ‚	
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Extensions/ServiceCollectionExtensions.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Infrastructure *
.* +

Extensions+ 5
{ 
public		 

static		 
class		 '
ServiceCollectionExtensions		 3
{

 
public 
static 
IServiceCollection (%
AddCustomerInfrastructure) B
(B C
thisC G
IServiceCollectionH Z
services[ c
,c d
IConfiguratione s
configt z
)z {
{ 	
services 
. 
AddDbContext 
<  
ApplicationDBContext 2
>2 3
(3 4
options4 ;
=>< >
options? F
.F G
UseSqlServerG S
(S T
configT Z
.Z [
GetConnectionString[ n
(n o
$str	o Ä
)
Ä Å
)
Å Ç
)
Ç É
;
É Ñ
return 
services 
; 
} 	
} 
} 