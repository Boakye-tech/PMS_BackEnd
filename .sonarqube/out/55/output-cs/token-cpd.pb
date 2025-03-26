≠,
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/UnitOfWork.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
;5 6
public 
class 

UnitOfWork 
: 
IUnitOfWork %
{ 
private 
bool 
disposedValue 
; 
private 
readonly 
FinanceDbContext %

_dbContext& 0
;0 1
public 


UnitOfWork 
( 
FinanceDbContext &
	dbContext' 0
)0 1
{		 

_dbContext

 
=

 
	dbContext

 
;

 
Bank 
= 
new 
BankRepository !
(! "
	dbContext" +
)+ ,
;, -

BankBranch 
= 
new  
BankBranchRepository -
(- .
	dbContext. 7
)7 8
;8 9
BankSortCodes 
= 
new #
BankSortCodesRepository 3
(3 4
	dbContext4 =
)= >
;> ?
ChartOfAccounts 
= 
new %
ChartOfAccountsRepository 7
(7 8
	dbContext8 A
)A B
;B C#
CurrencyAndExchangeRate 
=  !
new" %-
!CurrencyAndExchangeRateRepository& G
(G H
	dbContextH Q
)Q R
;R S
Forms 
= 
new 
FormsRepository #
(# $
	dbContext$ -
)- .
;. /
PaymentMode 
= 
new !
PaymentModeRepository /
(/ 0
	dbContext0 9
)9 :
;: ;
PaymentType 
= 
new !
PaymentTypeRepository /
(/ 0
	dbContext0 9
)9 :
;: ;
	Paypoints 
= 
new  
PaypointsRespository ,
(, -
	dbContext- 6
)6 7
;7 8
InvoiceTypes 
= 
new "
InvoiceTypesRepository 1
(1 2
	dbContext2 ;
); <
;< =
} 
public 

IBankRepository 
Bank 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 
!
IBankBranchRepository  

BankBranch! +
{, -
get. 1
;1 2
private3 :
set; >
;> ?
}@ A
public 
$
IBankSortCodesRepository #
BankSortCodes$ 1
{2 3
get4 7
;7 8
private9 @
setA D
;D E
}F G
public 
&
IChartOfAccountsRepository %
ChartOfAccounts& 5
{6 7
get8 ;
;; <
private= D
setE H
;H I
}J K
public 
.
"ICurrencyAndExchangeRateRepository -#
CurrencyAndExchangeRate. E
{F G
getH K
;K L
privateM T
setU X
;X Y
}Z [
public!! 

IFormsRepository!! 
Forms!! !
{!!" #
get!!$ '
;!!' (
private!!) 0
set!!1 4
;!!4 5
}!!6 7
public## 
"
IPaymentModeRepository## !
PaymentMode##" -
{##. /
get##0 3
;##3 4
private##5 <
set##= @
;##@ A
}##B C
public%% 
"
IPaymentTypeRepository%% !
PaymentType%%" -
{%%. /
get%%0 3
;%%3 4
private%%5 <
set%%= @
;%%@ A
}%%B C
public'' 
!
IPaypointsRespository''  
	Paypoints''! *
{''+ ,
get''- 0
;''0 1
private''2 9
set'': =
;''= >
}''? @
public)) 
#
IInvoiceTypesRepository)) "
InvoiceTypes))# /
{))0 1
get))2 5
;))5 6
private))7 >
set))? B
;))B C
}))D E
public++ 

Task++ 
<++ 
int++ 
>++ 
Complete++ 
(++ 
)++ 
{,, 
return-- 

_dbContext-- 
.-- 
SaveChangesAsync-- *
(--* +
)--+ ,
;--, -
}.. 
	protected00 
virtual00 
void00 
Dispose00 "
(00" #
bool00# '
	disposing00( 1
)001 2
{11 
if22 

(22 
!22 
disposedValue22 
)22 
{33 	
if44 
(44 
	disposing44 
)44 
{55 

_dbContext77 
.77 
Dispose77 "
(77" #
)77# $
;77$ %
}88 
disposedValue<< 
=<< 
true<<  
;<<  !
}== 	
}>> 
public@@ 

void@@ 
Dispose@@ 
(@@ 
)@@ 
{AA 
DisposeCC 
(CC 
	disposingCC 
:CC 
trueCC 
)CC  
;CC  !
GCDD 

.DD
 
SuppressFinalizeDD 
(DD 
thisDD  
)DD  !
;DD! "
}EE 
}FF l
j/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Usings.cs“@
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Repository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
;5 6
public 
class 

Repository 
< 
TEntity 
>  
:! "
IRepository# .
<. /
TEntity/ 6
>6 7
where8 =
TEntity> E
:F G
classH M
{ 
	protected		 
readonly		 
	DbContext		  

_dbContext		! +
;		+ ,
public 


Repository 
( 
	DbContext 
	dbContext  )
)) *
{ 

_dbContext 
= 
	dbContext 
; 
} 
public 

void 
Delete 
( 
TEntity 
entity %
)% &
=>' )

_dbContext* 4
.4 5
Set5 8
<8 9
TEntity9 @
>@ A
(A B
)B C
.C D
RemoveD J
(J K
entityK Q
)Q R
;R S
public 

void 
DeleteRange 
( 
IEnumerable '
<' (
TEntity( /
>/ 0
entities1 9
)9 :
=>; =

_dbContext> H
.H I
SetI L
<L M
TEntityM T
>T U
(U V
)V W
.W X
RemoveRangeX c
(c d
entitiesd l
)l m
;m n
public 

async 
Task 
< 
TEntity 
> 
Get "
(" #
int# &
id' )
)) *
=>+ -
await. 3

_dbContext4 >
.> ?
Set? B
<B C
TEntityC J
>J K
(K L
)L M
.M N
	FindAsyncN W
(W X
idX Z
)Z [
;[ \
public 

async 
Task 
< 
TEntity 
> 
Get "
(" #

Expression# -
<- .
Func. 2
<2 3
TEntity3 :
,: ;
bool< @
>@ A
>A B

expressionC M
,M N
ListO S
<S T
stringT Z
>Z [
?[ \
includes] e
=f g
nullh l
)l m
{ 

IQueryable 
< 
TEntity 
> 
entities $
=% &

_dbContext' 1
.1 2
Set2 5
<5 6
TEntity6 =
>= >
(> ?
)? @
;@ A
if 

( 
includes 
!= 
null 
) 
{ 	
foreach 
( 
var 
includeProp $
in% '
includes( 0
)0 1
{ 
entities   
=   
entities   #
.  # $
Include  $ +
(  + ,
includeProp  , 7
)  7 8
;  8 9
}!! 
}"" 	
return$$ 
await$$ 
entities$$ 
.$$ 
AsNoTracking$$ *
($$* +
)$$+ ,
.$$, -
FirstOrDefaultAsync$$- @
($$@ A

expression$$A K
)$$K L
;$$L M
}%% 
public'' 

async'' 
Task'' 
<'' 
IList'' 
<'' 
TEntity'' #
>''# $
>''$ %
GetAll''& ,
('', -

Expression''- 7
<''7 8
Func''8 <
<''< =
TEntity''= D
,''D E
bool''F J
>''J K
>''K L
?''L M

expression''N X
=''Y Z
null''[ _
,''_ `
Func''a e
<''e f

IQueryable''f p
<''p q
TEntity''q x
>''x y
,''y z
IOrderedQueryable	''{ å
<
''å ç
TEntity
''ç î
>
''î ï
>
''ï ñ
?
''ñ ó
orderBy
''ò ü
=
''† °
null
''¢ ¶
,
''¶ ß
List
''® ¨
<
''¨ ≠
string
''≠ ≥
>
''≥ ¥
?
''¥ µ
includes
''∂ æ
=
''ø ¿
null
''¡ ≈
)
''≈ ∆
{(( 

IQueryable)) 
<)) 
TEntity)) 
>)) 
query)) !
=))" #

_dbContext))$ .
.)). /
Set))/ 2
<))2 3
TEntity))3 :
>)): ;
()); <
)))< =
;))= >
if++ 

(++ 

expression++ 
!=++ 
null++ 
)++ 
query,, 
=,, 
query,, 
.,, 
Where,, 
(,,  

expression,,  *
),,* +
;,,+ ,
if.. 

(.. 
includes.. 
!=.. 
null.. 
).. 
{// 	
foreach00 
(00 
var00 
includeProperty00 (
in00) +
includes00, 4
)004 5
query11 
=11 
query11 
.11 
Include11 %
(11% &
includeProperty11& 5
)115 6
;116 7
}22 	
if44 

(44 
orderBy44 
!=44 
null44 
)44 
query55 
=55 
orderBy55 
(55 
query55 !
)55! "
;55" #
return77 
await77 
query77 
.77 
AsNoTracking77 '
(77' (
)77( )
.77) *
ToListAsync77* 5
(775 6
)776 7
;777 8
}88 
public:: 

async:: 
Task:: 
<:: 
IList:: 
<:: 
TEntity:: #
>::# $
>::$ %
GetAll::& ,
(::, -
)::- .
=>::/ 1
await::2 7

_dbContext::8 B
.::B C
Set::C F
<::F G
TEntity::G N
>::N O
(::O P
)::P Q
.::Q R
ToListAsync::R ]
(::] ^
)::^ _
;::_ `
public<< 

async<< 
void<< 
Insert<< 
(<< 
TEntity<< $
entity<<% +
)<<+ ,
=><<- /
await<<0 5

_dbContext<<6 @
.<<@ A
Set<<A D
<<<D E
TEntity<<E L
><<L M
(<<M N
)<<N O
.<<O P
AddAsync<<P X
(<<X Y
entity<<Y _
)<<_ `
;<<` a
public>> 

async>> 
void>> 
InsertRange>> !
(>>! "
IEnumerable>>" -
<>>- .
TEntity>>. 5
>>>5 6
entities>>7 ?
)>>? @
=>>>A C
await>>D I

_dbContext>>J T
.>>T U
Set>>U X
<>>X Y
TEntity>>Y `
>>>` a
(>>a b
)>>b c
.>>c d
AddRangeAsync>>d q
(>>q r
entities>>r z
)>>z {
;>>{ |
public@@ 

void@@ 
Update@@ 
(@@ 
TEntity@@ 
entity@@ %
)@@% &
=>@@' )

_dbContext@@* 4
.@@4 5
Set@@5 8
<@@8 9
TEntity@@9 @
>@@@ A
(@@A B
)@@B C
.@@C D
Update@@D J
(@@J K
entity@@K Q
)@@Q R
;@@R S
publicBB 

voidBB 
UpdateRangeBB 
(BB 
IEnumerableBB '
<BB' (
TEntityBB( /
>BB/ 0
entitiesBB1 9
)BB9 :
=>BB; =

_dbContextBB> H
.BBH I
SetBBI L
<BBL M
TEntityBBM T
>BBT U
(BBU V
)BBV W
.BBW X
UpdateRangeBBX c
(BBc d
entitiesBBd l
)BBl m
;BBm n
}CC å
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/PaypointsRespository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class  
PaypointsRespository "
:# $

Repository% /
</ 0
	Paypoints0 9
>9 :
,: ;!
IPaypointsRespository< Q
{ 
public  
PaypointsRespository	 
( 
FinanceDbContext .
	dbContext/ 8
)8 9
:: ;
base< @
(@ A
	dbContextA J
)J K
{ 	
}		 
}

 
} í
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/PaymentTypeRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class !
PaymentTypeRepository #
:$ %

Repository& 0
<0 1
PaymentType1 <
>< =
,= >"
IPaymentTypeRepository? U
{ 
public !
PaymentTypeRepository	 
( 
FinanceDbContext /
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
 í
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/PaymentModeRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class !
PaymentModeRepository #
:$ %

Repository& 0
<0 1
PaymentMode1 <
>< =
,= >"
IPaymentModeRepository? U
{ 
public !
PaymentModeRepository	 
( 
FinanceDbContext /
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
 ó
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/InvoiceTypesRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class "
InvoiceTypesRepository $
:% &

Repository' 1
<1 2
InvoiceTypes2 >
>> ?
,? @#
IInvoiceTypesRepositoryA X
{ 
public "
InvoiceTypesRepository	 
(  
FinanceDbContext  0
	dbContext1 :
): ;
:< =
base> B
(B C
	dbContextC L
)L M
{ 	
} 
}		 
}

 Ù
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/FormsRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class 
FormsRepository 
: 

Repository  *
<* +
Forms+ 0
>0 1
,1 2
IFormsRepository3 C
{ 
public 
FormsRepository	 
( 
FinanceDbContext )
	dbContext* 3
)3 4
:5 6
base7 ;
(; <
	dbContext< E
)E F
{ 
} 
}		 
}

 Œ
°/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/CurrencyAndExchangeRateRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class -
!CurrencyAndExchangeRateRepository /
:0 1

Repository2 <
<< =#
CurrencyAndExchangeRate= T
>T U
,U V.
"ICurrencyAndExchangeRateRepositoryW y
{ 
public -
!CurrencyAndExchangeRateRepository	 *
(* +
FinanceDbContext+ ;
	dbContext< E
)E F
:G H
baseI M
(M N
	dbContextN W
)W X
{ 
} 
}		 
}

 ¶
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/ChartOfAccountsRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class %
ChartOfAccountsRepository '
:( )

Repository* 4
<4 5
ChartOfAccounts5 D
>D E
,E F&
IChartOfAccountsRepositoryG a
{ 
public %
ChartOfAccountsRepository	 "
(" #
FinanceDbContext# 3
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
 ú
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/BankSortCodesRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class #
BankSortCodesRepository %
:& '

Repository( 2
<2 3
BankSortCodes3 @
>@ A
,A B$
IBankSortCodesRepositoryC [
{ 
public #
BankSortCodesRepository	  
(  !
FinanceDbContext! 1
	dbContext2 ;
); <
:= >
base? C
(C D
	dbContextD M
)M N
{ 
} 
}		 
}

 Ô
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/BankRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class 
BankRepository 
: 

Repository )
<) *
Bank* .
>. /
,/ 0
IBankRepository1 @
{ 
public 
BankRepository	 
( 
FinanceDbContext (
	dbContext) 2
)2 3
:4 5
base6 :
(: ;
	dbContext; D
)D E
{ 
} 
}		 
}

 ç
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/BankBranchRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Repositories) 5
.5 6
Entities6 >
.> ?
Setup? D
{ 
public 
class  
BankBranchRepository "
:# $

Repository% /
</ 0

BankBranch0 :
>: ;
,; <!
IBankBranchRepository= R
{ 
public  
BankBranchRepository	 
( 
FinanceDbContext .
	dbContext/ 8
)8 9
:: ;
base< @
(@ A
	dbContextA J
)J K
{ 
} 
}		 
}

 ø	
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Extensions/ServiceCollectionExtensions.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )

Extensions) 3
;3 4
public 
static 
class '
ServiceCollectionExtensions /
{		 
public

 

static

 
IServiceCollection

 $$
AddFinanceInfrastructure

% =
(

= >
this

> B
IServiceCollection

C U
services

V ^
,

^ _
IConfiguration

` n
config

o u
)

u v
{ 
services 
. 
AddDbContext 
< 
FinanceDbContext *
>* +
(+ ,
options, 3
=>4 6
options7 >
.> ?
UseSqlServer? K
(K L
configL R
.R S
GetConnectionStringS f
(f g
$strg x
)x y
)y z
)z {
;{ |
return 
services 
; 
} 
} ‹
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Data/FinanceDbContext.cs
	namespace 	
Modules
 
. 
Finance 
. 
Infrastructure (
.( )
Data) -
;- .
public 
class 
FinanceDbContext 
: 
ModuleDbContext  /
{		 
	protected

 
override

 
string

 
Schema

 $
=>

% '
$str

( -
;

- .
public 

FinanceDbContext 
( 
DbContextOptions ,
<, -
FinanceDbContext- =
>= >
options? F
)F G
:H I
baseJ N
(N O
optionsO V
)V W
{ 
} 
public 

DbSet 
< 
Bank 
> 
Bank 
{ 
get !
;! "
set# &
;& '
}( )
public 

DbSet 
< 

BankBranch 
> 

BankBranch '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 

DbSet 
< 
BankSortCodes 
> 
BankSortCodes  -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 

DbSet 
< 
ChartOfAccounts  
>  !
ChartOfAccounts" 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public 

DbSet 
< #
CurrencyAndExchangeRate (
>( )#
CurrencyAndExchangeRate* A
{B C
getD G
;G H
setI L
;L M
}N O
public 

DbSet 
< 
Forms 
> 
Forms 
{ 
get  #
;# $
set% (
;( )
}* +
public 

DbSet 
< 
PaymentMode 
> 
PaymentMode )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 
PaymentType 
> 
PaymentType )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 

DbSet 
< 
	Paypoints 
> 
	Paypoints %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

DbSet 
< 
Services 
> 
Services #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 

DbSet 
< 
InvoiceTypes 
> 
InvoiceTypes +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{ 
base 
. 
OnModelCreating 
( 
modelBuilder )
)) *
;* +
} 
}!! 