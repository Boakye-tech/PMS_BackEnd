d
b/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Usings.csâ
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/IUnitOfWork.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
{ 
public 

	interface 
IUnitOfWork  
:! "
IDisposable# .
{ 
IBankRepository 
Bank 
{ 
get "
;" #
}$ %!
IBankBranchRepository 

BankBranch (
{) *
get+ .
;. /
}0 1$
IBankSortCodesRepository		  
BankSortCodes		! .
{		/ 0
get		1 4
;		4 5
}		6 7&
IChartOfAccountsRepository

 "
ChartOfAccounts

# 2
{

3 4
get

5 8
;

8 9
}

: ;.
"ICurrencyAndExchangeRateRepository *#
CurrencyAndExchangeRate+ B
{C D
getE H
;H I
}J K
IFormsRepository 
Forms 
{  
get! $
;$ %
}& '"
IPaymentModeRepository 
PaymentMode *
{+ ,
get- 0
;0 1
}2 3"
IPaymentTypeRepository 
PaymentType *
{+ ,
get- 0
;0 1
}2 3!
IPaypointsRespository 
	Paypoints '
{( )
get* -
;- .
}/ 0#
IInvoiceTypesRepository 
InvoiceTypes  ,
{- .
get/ 2
;2 3
}4 5
Task 
< 
int 
> 
Complete 
( 
) 
; 
} 
} ∂
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/IRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
{ 
public 
	interface 
IRepository 
< 
TEntity %
>% &
where' ,
TEntity- 4
:5 6
class7 <
{ 
Task 
< 
TEntity 
> 
Get 
( 
int 
id  
)  !
;! "
Task

 
<

 
IList

 
<

 
TEntity

 
>

 
>

 
GetAll

 #
(

# $

Expression 
< 
Func #
<# $
TEntity$ +
,+ ,
bool- 1
>1 2
>2 3
?3 4

expression5 ?
=@ A
nullB F
,F G
Func 
< 

IQueryable #
<# $
TEntity$ +
>+ ,
,, -
IOrderedQueryable. ?
<? @
TEntity@ G
>G H
>H I
?I J
orderByK R
=S T
nullU Y
,Y Z
List 
< 
string 
>  
?  !
includes" *
=+ ,
null- 1
) 
; 
Task 
< 
IList 
< 
TEntity 
> 
> 
GetAll #
(# $
)$ %
;% &
Task 
< 
TEntity 
> 
Get 
( 

Expression $
<$ %
Func% )
<) *
TEntity* 1
,1 2
bool3 7
>7 8
>8 9

expression: D
,D E
ListF J
<J K
stringK Q
>Q R
?R S
includesT \
=] ^
null_ c
)c d
;d e
void 
Insert 
( 
TEntity 
entity "
)" #
;# $
void 
InsertRange 
( 
IEnumerable $
<$ %
TEntity% ,
>, -
entities. 6
)6 7
;7 8
void 
Delete 
( 
TEntity 
entity "
)" #
;# $
void 
DeleteRange 
( 
IEnumerable $
<$ %
TEntity% ,
>, -
entities. 6
)6 7
;7 8
void 
Update 
( 
TEntity 
entity "
)" #
;# $
void 
UpdateRange 
( 
IEnumerable $
<$ %
TEntity% ,
>, -
entities. 6
)6 7
;7 8
} 
}   ø
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IPaypointsRespository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface !
IPaypointsRespository &
:& '
IRepository( 3
<3 4
	Paypoints4 =
>= >
{ 
} √
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IPaymentTypeRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface "
IPaymentTypeRepository '
:( )
IRepository* 5
<5 6
PaymentType6 A
>A B
{ 
} √
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IPaymentModeRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface "
IPaymentModeRepository '
:( )
IRepository* 5
<5 6
PaymentMode6 A
>A B
{ 
} ◊
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IInvoiceTypesRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
{ 
public 
	interface #
IInvoiceTypesRepository )
:* +
IRepository, 7
<7 8
InvoiceTypes8 D
>D E
{ 
} 
} ±
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IFormsRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface 
IFormsRepository !
:" #
IRepository$ /
</ 0
Forms0 5
>5 6
{ 
} Á
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/ICurrencyAndExchangeRateRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface .
"ICurrencyAndExchangeRateRepository 3
:4 5
IRepository6 A
<A B#
CurrencyAndExchangeRateB Y
>Y Z
{ 
} œ
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IChartOfAccountsRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface &
IChartOfAccountsRepository +
:, -
IRepository. 9
<9 :
ChartOfAccounts: I
>I J
{ 
} …
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IBankSortCodesRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface $
IBankSortCodesRepository )
:* +
IRepository, 7
<7 8
BankSortCodes8 E
>E F
{ 
} Æ
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IBankRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface 
IBankRepository  
:! "
IRepository# .
<. /
Bank/ 3
>3 4
{ 
} ¿
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Interfaces/Entities/Setup/IBankBranchRepository.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
;: ;
public 
	interface !
IBankBranchRepository &
:' (
IRepository) 4
<4 5

BankBranch5 ?
>? @
{ 
} Ω
s/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Services.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
Services 
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
[

 	
StringLength

	 
(

 
$num

 
)

 
]

 
public 
required 
string 
ServiceCode *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
ServiceName *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
public 
required 
double 
Amount %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
public 
required 
int 
AccountCode '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} ´
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Paypoints.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
	Paypoints 
: 
AuditableEntity )
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
public

 
int

 

PaypointId

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Paypoint 
{  !
get" %
;% &
set' *
;* +
}, -
public 
	Paypoints 
( 
int 

paypointId '
,' (
string) /
paypoint0 8
)8 9
{ 

PaypointId 
= 

paypointId #
;# $
Paypoint 
= 
paypoint 
;  
} 
public 
static 
	Paypoints 
CreateUpdate  ,
(, -
int- 0

paypointId1 ;
,; <
string= C
paypointD L
)L M
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
paypoint* 2
)2 3
||4 6

paypointId7 A
<B C
$numD E
)E F
{ 
throw 
new 
ArgumentException +
(+ ,
$str, E
)E F
;F G
} 
if 
( 

paypointId 
<= 
- 
$num  
)  !
throw 
new 
ArgumentException +
(+ ,
$str, Y
)Y Z
;Z [
if   
(   
string   
.   
IsNullOrWhiteSpace   )
(  ) *
paypoint  * 2
)  2 3
||  4 6
paypoint  7 ?
.  ? @
Length  @ F
>  G H
$num  I K
)  K L
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, e
)!!e f
;!!f g
return## 
new## 
	Paypoints##  
(##  !

paypointId##! +
,##+ ,
paypoint##- 5
)##5 6
;##6 7
}$$ 	
}&& 
}** …
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PaymentType.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
PaymentType 
: 
AuditableEntity +
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
public

 
int

 
PaymentTypeId

  
{

! "
get

# &
;

& '
private

( /
set

0 3
;

3 4
}

5 6
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
PaymentTypes "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public 
PaymentType 
( 
int 
PaymentTypeId ,
,, -
string. 4
PaymentTypes5 A
)A B
{ 	
this 
. 
PaymentTypeId 
=  
PaymentTypeId! .
;. /
this 
. 
PaymentTypes 
= 
PaymentTypes  ,
;, -
} 	
public 
static 
PaymentType !
CreateUpdate" .
(. /
int/ 2
paymentTypeId3 @
,@ A
stringB H
paymentTypeI T
)T U
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
paymentType* 5
)5 6
||7 9
paymentTypeId: G
<H I
$numJ K
)K L
{ 
throw 
new 
ArgumentException +
(+ ,
$str, H
)H I
;I J
} 
if 
( 
paymentTypeId 
<=  
-! "
$num" #
)# $
throw 
new 
ArgumentException +
(+ ,
$str, \
)\ ]
;] ^
if!! 
(!! 
string!! 
.!! 
IsNullOrWhiteSpace!! )
(!!) *
paymentType!!* 5
)!!5 6
||!!7 9
paymentType!!: E
.!!E F
Length!!F L
>!!M N
$num!!O Q
)!!Q R
throw"" 
new"" 
ArgumentException"" +
(""+ ,
$str"", h
)""h i
;""i j
return$$ 
new$$ 
PaymentType$$ "
($$" #
paymentTypeId$$# 0
,$$0 1
paymentType$$2 =
)$$= >
;$$> ?
}%% 	
}&& 
}'' …
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PaymentMode.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
PaymentMode 
: 
AuditableEntity +
{ 
[ 	
Key	 
] 
[ 	
Required	 
] 
public		 
int		 
PaymentModeId		  
{		! "
get		# &
;		& '
private		( /
set		0 3
;		3 4
}		5 6
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PaymentModes #
{$ %
get& )
;) *
private+ 2
set3 6
;6 7
}8 9
public 
PaymentMode 
( 
int 
PaymentModeId ,
,, -
string. 4
PaymentModes5 A
)A B
{ 	
this 
. 
PaymentModeId 
=  
PaymentModeId! .
;. /
this 
. 
PaymentModes 
= 
PaymentModes  ,
;, -
} 	
public 
static 
PaymentMode !
CreateUpdate" .
(. /
int/ 2
paymentModeId3 @
,@ A
stringB H
paymentModeI T
)T U
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
paymentMode* 5
)5 6
||7 9
paymentModeId: G
<H I
$numJ K
)K L
{ 
throw 
new 
ArgumentException +
(+ ,
$str, H
)H I
;I J
} 
if 
( 
paymentModeId 
<=  
$num! "
)" #
throw 
new 
ArgumentException +
(+ ,
$str, \
)\ ]
;] ^
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
paymentMode* 5
)5 6
||7 9
paymentMode: E
.E F
LengthF L
>M N
$numO Q
)Q R
throw   
new   
ArgumentException   +
(  + ,
$str  , h
)  h i
;  i j
return"" 
new"" 
PaymentMode"" "
(""" #
paymentModeId""# 0
,""0 1
paymentMode""2 =
)""= >
;""> ?
}## 	
}$$ 
}%% Å$
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/InvoiceTypes.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
InvoiceTypes 
: 
AuditableEntity ,
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
public

 
int

 
InvoiceTypesId

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
InvoiceInitials &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
InvoiceDescriptions *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
public 
double 
InvoiceAmount #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
InvoiceTypes 
( 
int 
invoiceTypesId  .
,. /
string/ 5
invoiceInitials6 E
,E F
stringG M
invoiceDescriptionsN a
,a b
doublec i
invoiceAmountj w
)w x
{ 	
InvoiceTypesId 
= 
invoiceTypesId +
;+ ,
InvoiceInitials 
= 
invoiceInitials -
;- .
InvoiceDescriptions 
=  !
invoiceDescriptions" 5
;5 6
InvoiceAmount 
= 
invoiceAmount )
;) *
} 	
public   
static   
InvoiceTypes   "
CreateUpdate  # /
(  / 0
int  0 3
invoiceTypesId  4 B
,  B C
string  D J
invoiceInitials  K Z
,  Z [
string  \ b
invoiceDescriptions  c v
,  v w
double  x ~
invoiceAmount	   å
)
  å ç
{!! 	
if"" 
("" 
string"" 
."" 
IsNullOrWhiteSpace"" )
("") *
invoiceInitials""* 9
)""9 :
||""; =
string""> D
.""D E
IsNullOrWhiteSpace""E W
(""W X
invoiceDescriptions""X k
)""k l
||""m o
invoiceAmount""p }
<""~ 
$num
""Ä Å
)
""Ç É
{## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, H
)$$H I
;$$I J
}%% 
if'' 
('' 
string'' 
.'' 
IsNullOrWhiteSpace'' )
('') *
invoiceInitials''* 9
)''9 :
||''; =
invoiceInitials''> M
.''M N
Length''N T
>''U V
$num''W X
)''X Y
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, l
)((l m
;((m n
if** 
(** 
invoiceAmount** 
<=**  
$num**! "
)**" #
throw++ 
new++ 
ArgumentException++ +
(+++ ,
$str++, \
)++\ ]
;++] ^
if.. 
(.. 
string.. 
... 
IsNullOrWhiteSpace.. )
(..) *
invoiceDescriptions..* =
)..= >
||..? A
invoiceDescriptions..B U
...U V
Length..V \
>..] ^
$num.._ a
)..a b
throw// 
new// 
ArgumentException// +
(//+ ,
$str//, p
)//p q
;//q r
return11 
new11 
InvoiceTypes11 #
(11# $
invoiceTypesId11$ 2
,112 3
invoiceInitials114 C
,11C D
invoiceDescriptions11E X
,11X Y
invoiceAmount11Z g
)11g h
;11h i
}22 	
}66 
}<< †$
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Forms.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
Forms 
: 
AuditableEntity %
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
[

 	
StringLength

	 
(

 
$num

 
)

 
]

 
public 
string 
? 
FormCode 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
FormName 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
public 
double 
Amount 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
] 
public 
int 
AccountCode 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Forms 
( 
string 
formCode $
,$ %
string& ,
formName- 5
,5 6
double7 =
amount> D
,D E
intF I
accountCodeJ U
)U V
{ 	
FormCode 
= 
formCode 
;  
FormName 
= 
formName 
;  
Amount 
= 
amount 
; 
AccountCode 
= 
accountCode %
;% &
} 	
public   
static   
Forms   
CreateUpdate   (
(  ( )
string  ) /
formCode  0 8
,  8 9
string  : @
formName  A I
,  I J
double  K Q
amount  R X
,  X Y
int  Z ]
accountCode  ^ i
)  i j
{!! 	
if"" 
("" 
string"" 
."" 
IsNullOrWhiteSpace"" )
("") *
formCode""* 2
)""2 3
||""4 6
string""7 =
.""= >
IsNullOrWhiteSpace""> P
(""P Q
formName""Q Y
)""Y Z
||""[ ]
amount""^ d
<""e f
$num""g h
||""i k
accountCode""l w
<""x y
$num""z {
)""{ |
{## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, A
)$$A B
;$$B C
}%% 
if'' 
('' 
string'' 
.'' 
IsNullOrWhiteSpace'' )
('') *
formCode''* 2
)''2 3
||''4 6
formName''7 ?
.''? @
Length''@ F
>''G H
$num''I J
)''J K
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, `
)((` a
;((a b
if** 
(** 
amount** 
<=** 
$num** 
)** 
throw++ 
new++ 
ArgumentException++ +
(+++ ,
$str++, U
)++U V
;++V W
if-- 
(-- 
accountCode-- 
<=-- 
$num--  
)--  !
throw.. 
new.. 
ArgumentException.. +
(..+ ,
$str.., [
)..[ \
;..\ ]
if00 
(00 
string00 
.00 
IsNullOrWhiteSpace00 )
(00) *
formName00* 2
)002 3
||004 6
formName007 ?
.00? @
Length00@ F
>00G H
$num00I K
)00K L
throw11 
new11 
ArgumentException11 +
(11+ ,
$str11, b
)11b c
;11c d
return33 
new33 
Forms33 
(33 
formCode33 %
,33% &
formName33' /
,33/ 0
amount331 7
,337 8
accountCode339 D
)33D E
;33E F
}44 	
}55 
}66 Ñ5
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/CurrencyAndExchangeRate.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class #
CurrencyAndExchangeRate %
:& '
AuditableEntity( 7
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
public

 
int

 

CurrencyId

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
CurrencyInitial %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
CurrencyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
] 
public 
double 

BuyingRate  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
] 
public 
double 
SellingRate !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
bool 
BaseCurrency  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
] 
public 
DateTime 
ApplicableDate &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[   	
Required  	 
]   
public!! 
short!! 
	IsCurrent!! 
{!!  
get!!! $
;!!$ %
set!!& )
;!!) *
}!!+ ,
public$$ #
CurrencyAndExchangeRate$$ &
($$& '
int$$' *

currencyId$$+ 5
,$$5 6
string$$7 =
currencyInitial$$> M
,$$M N
string$$O U
currencyName$$V b
,$$b c
double$$d j

buyingRate$$k u
,$$u v
double$$w }
sellingRate	$$~ â
,
$$â ä
bool
$$ã è
baseCurrency
$$ê ú
,
$$ú ù
DateTime
$$û ¶
applicableDate
$$ß µ
,
$$µ ∂
short
$$∑ º
	isCurrent
$$Ω ∆
)
$$∆ «
{%% 	

CurrencyId&& 
=&& 

currencyId&& #
;&&# $
CurrencyInitial'' 
='' 
currencyInitial'' -
;''- .
CurrencyName(( 
=(( 
currencyName(( '
;((' (

BuyingRate)) 
=)) 

buyingRate)) #
;))# $
SellingRate** 
=** 
sellingRate** %
;**% &
BaseCurrency++ 
=++ 
baseCurrency++ '
;++' (
ApplicableDate,, 
=,, 
applicableDate,, +
;,,+ ,
	IsCurrent-- 
=-- 
	isCurrent-- !
;--! "
}.. 	
public11 
static11 #
CurrencyAndExchangeRate11 -
CreateUpdate11. :
(11: ;
int11; >

currencyId11? I
,11I J
string11K Q
currencyInitial11R a
,11a b
string11c i
currencyName11j v
,11v w
double11x ~

buyingRate	11 â
,
11â ä
double
11ã ë
sellingRate
11í ù
,
11ù û
bool
11ü £
baseCurrency
11§ ∞
,
11∞ ±
DateTime
11≤ ∫
applicableDate
11ª …
,
11…  
short
11À –
	isCurrent
11— ⁄
)
11⁄ €
{22 	
if33 
(33 

currencyId33 
<33 
$num33 
||33 !
string33" (
.33( )
IsNullOrWhiteSpace33) ;
(33; <
currencyInitial33< K
)33K L
||33M O
string33P V
.33V W
IsNullOrWhiteSpace33W i
(33i j
currencyName33j v
)33v w
||33x z

buyingRate	33{ Ö
<
33Ü á
$num
33à â
||
33ä å
sellingRate
33ç ò
<
33ô ö
$num
33õ ú
)
33ú ù
{44 
throw55 
new55 
ArgumentException55 +
(55+ ,
$str55, S
)55S T
;55T U
}66 
if88 
(88 
string88 
.88 
IsNullOrWhiteSpace88 )
(88) *
currencyInitial88* 9
)889 :
||88; =
currencyInitial88> M
.88M N
Length88N T
>88U V
$num88W X
)88X Y
throw99 
new99 
ArgumentException99 +
(99+ ,
$str99, l
)99l m
;99m n
if;; 
(;; 
string;; 
.;; 
IsNullOrWhiteSpace;; )
(;;) *
currencyName;;* 6
);;6 7
||;;8 :
currencyName;;; G
.;;G H
Length;;H N
>;;O P
$num;;Q S
);;S T
throw<< 
new<< 
ArgumentException<< +
(<<+ ,
$str<<, i
)<<i j
;<<j k
if>> 
(>> 

buyingRate>> 
<=>> 
$num>> 
)>>  
throw?? 
new?? 
ArgumentException?? +
(??+ ,
$str??, X
)??X Y
;??Y Z
ifAA 
(AA 
sellingRateAA 
<=AA 
$numAA  
)AA  !
throwBB 
newBB 
ArgumentExceptionBB +
(BB+ ,
$strBB, Y
)BBY Z
;BBZ [
returnEE 
newEE #
CurrencyAndExchangeRateEE .
(EE. /

currencyIdEE/ 9
,EE9 :
currencyInitialEE< K
,EEK L
currencyNameEEN Z
,EEZ [

buyingRateEE] g
,EEg h
sellingRateEEj u
,EEu v
baseCurrency	EEx Ñ
,
EEÑ Ö
applicableDate
EEá ï
,
EEï ñ
	isCurrent
EEó †
)
EE† °
;
EE° ¢
}FF 	
}HH 
}II Ã
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/ChartOfAccounts.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
;/ 0
public 
class 
ChartOfAccounts 
: 
AuditableEntity .
{ 
[ 
Key 
] 	
[ 
Required 
] 
public		 

int		 
AccountCode		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
[ 
StringLength 
( 
$num 
) 
] 
[ 
Required 
] 
public 

string 
? 
AccountName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

ChartOfAccounts 
( 
int 
accountCode *
,* +
string, 2
accountName3 >
)> ?
{ 
AccountCode 
= 
accountCode !
;! "
AccountName 
= 
accountName !
;! "
} 
public 

static 
ChartOfAccounts !
CreateUpdate" .
(. /
int/ 2
accountCode3 >
,> ?
string@ F
accountNameG R
)R S
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
accountName& 1
)1 2
||3 5
accountCode6 A
<B C
$numD E
)E F
{ 	
throw 
new 
ArgumentException '
(' (
$str( I
)I J
;J K
} 	
if 

( 
accountCode 
<= 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( ^
)^ _
;_ `
if   

(   
string   
.   
IsNullOrWhiteSpace   %
(  % &
accountName  & 1
)  1 2
||  3 5
accountName  6 A
.  A B
Length  B H
>  I J
$num  K M
)  M N
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( m
)!!m n
;!!n o
return$$ 
new$$ 
ChartOfAccounts$$ "
($$" #
accountCode$$# .
,$$. /
accountName$$0 ;
)$$; <
;$$< =
}%% 
}&& ∞$
x/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/BankSortCodes.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
BankSortCodes 
: 
AuditableEntity ,
{ 
[ 	
Key	 
] 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
SortCode 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BankName 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

BranchName !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
BankSortCodes 
( 
int  
id! #
,# $
string& ,
sortCode- 5
,5 6
string7 =
bankName> F
,F G
stringH N

branchNameO Y
)Y Z
{ 	
Id 
= 
id 
; 
SortCode 
= 
sortCode 
;  
BankName 
= 
bankName 
;  

BranchName 
= 

branchName #
;# $
} 	
public   
static   
BankSortCodes   #
CreateUpdate  $ 0
(  0 1
int  1 4
id  5 7
,  7 8
string  9 ?
sortCode  @ H
,  H I
string  J P
bankName  Q Y
,  Y Z
string  [ a

branchName  b l
)  l m
{!! 	
if"" 
("" 
string"" 
."" 
IsNullOrWhiteSpace"" )
("") *
sortCode""* 2
)""2 3
||""4 6
string""7 =
.""= >
IsNullOrWhiteSpace""> P
(""P Q
bankName""Q Y
)""Y Z
||""[ ]
string""^ d
.""d e
IsNullOrWhiteSpace""e w
(""w x

branchName	""x Ç
)
""Ç É
)
""É Ñ
{## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, J
)$$J K
;$$K L
}%% 
if'' 
('' 
string'' 
.'' 
IsNullOrWhiteSpace'' )
('') *
sortCode''* 2
)''2 3
||''4 6
sortCode''7 ?
.''? @
Length''@ F
>''G H
$num''I J
)''J K
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, d
)((d e
;((e f
if** 
(** 
string** 
.** 
IsNullOrWhiteSpace** )
(**) *
bankName*** 2
)**2 3
||**4 6
bankName**7 ?
.**? @
Length**@ F
>**G H
$num**I K
)**K L
throw++ 
new++ 
ArgumentException++ +
(+++ ,
$str++, e
)++e f
;++f g
if-- 
(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- )
(--) *

branchName--* 4
)--4 5
||--6 8

branchName--9 C
.--C D
Length--D J
>--K L
$num--M P
)--P Q
throw.. 
new.. 
ArgumentException.. +
(..+ ,
$str.., m
)..m n
;..n o
return00 
new00 
BankSortCodes00 $
(00$ %
id00% '
,00' (
sortCode00) 1
,001 2
bankName003 ;
,00; <

branchName00= G
)00G H
;00H I
}11 	
}44 
}55 í!
u/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/BankBranch.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 

BankBranch 
: 
AuditableEntity *
{ 
[ 	
Required	 
] 
[		 	
StringLength			 
(		 
$num		 
)		 
]		 
public

 
string

 
BankId

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
[ 	
Key	 
] 
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
BranchId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 

BranchName  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

BankBranch 
( 
string  
bankId! '
,' (
string) /
branchId0 8
,8 9
string: @

branchNameA K
)K L
{ 	
BankId 
= 
bankId 
; 
BranchId 
= 
branchId 
;  

BranchName 
= 

branchName #
;# $
} 	
public 
static 

BankBranch  
CreateUpdate! -
(- .
string. 4
bankId5 ;
,; <
string= C
branchIdD L
,L M
stringN T

branchNameU _
)_ `
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
bankId* 0
)0 1
||2 4
string5 ;
.; <
IsNullOrWhiteSpace< N
(N O
branchIdO W
)W X
||Y [
string\ b
.b c
IsNullOrWhiteSpacec u
(u v

branchName	v Ä
)
Ä Å
)
Å Ç
{ 
throw   
new   
ArgumentException   +
(  + ,
$str  , G
)  G H
;  H I
}!! 
if## 
(## 
string## 
.## 
IsNullOrWhiteSpace## )
(##) *
bankId##* 0
)##0 1
||##2 4
bankId##5 ;
.##; <
Length##< B
<##C D
$num##E G
)##G H
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, Z
)$$Z [
;$$[ \
if&& 
(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& )
(&&) *
branchId&&* 2
)&&2 3
||&&4 6
branchId&&7 ?
.&&? @
Length&&@ F
<&&G H
$num&&I K
)&&K L
throw'' 
new'' 
ArgumentException'' +
(''+ ,
$str'', a
)''a b
;''b c
if)) 
()) 
string)) 
.)) 
IsNullOrWhiteSpace)) )
())) *

branchName))* 4
)))4 5
||))6 8

branchName))9 C
.))C D
Length))D J
>))K L
$num))M P
)))P Q
throw** 
new** 
ArgumentException** +
(**+ ,
$str**, m
)**m n
;**n o
return,, 
new,, 

BankBranch,, !
(,,! "
bankId,," (
,,,( )
branchId,,* 2
,,,2 3

branchName,,4 >
),,> ?
;,,? @
}-- 	
}// 
}00 ê
o/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Bank.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
{ 
public 
class 
Bank 
: 
AuditableEntity $
{ 
[ 	
Key	 
] 
[		 	
Required			 
]		 
[

 	
StringLength

	 
(

 
$num

 
)

 
]

 
public 
string 
BankId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
BankName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Bank 
( 
string 
bankId !
,! "
string# )
bankName* 2
)2 3
{ 	
BankId 
= 
bankId 
; 
BankName 
= 
bankName 
;  
} 	
public 
static 
Bank 
CreateUpdate '
(' (
string( .
bankId/ 5
,5 6
string7 =
bankName> F
)F G
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
bankId* 0
)0 1
||2 4
string5 ;
.; <
IsNullOrWhiteSpace< N
(N O
bankNameO W
)W X
)X Y
throw 
new 
ArgumentException +
(+ ,
$str, @
)@ A
;A B
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
bankId* 0
)0 1
||2 4
bankName5 =
.= >
Length> D
<E F
$numG I
)I J
throw 
new 
ArgumentException +
(+ ,
$str, V
)V W
;W X
if   
(   
string   
.   
IsNullOrWhiteSpace   )
(  ) *
bankName  * 2
)  2 3
||  4 6
bankName  7 ?
.  ? @
Length  @ F
>  G H
$num  I K
)  K L
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, a
)!!a b
;!!b c
return## 
new## 
Bank## 
(## 
bankId## "
,##" #
bankName##$ ,
)##, -
;##- .
}$$ 	
}66 
}99 ‘,
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/DebitNote.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class 
	DebitNote 
{ 
[ 	
Key	 
] 
public		 
int		 
DebitNoteId		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
[ 	
Required	 
] 
public 
int 
AccountCode 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
PropertyNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
CustomerCode "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
DebitNoteNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
public 
int 
ContraAccountCode $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string  
ContraPropertyNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[!! 	
Required!!	 
]!! 
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## 
ContraCustomerCode## (
{##) *
get##+ .
;##. /
set##0 3
;##3 4
}##5 6
[%% 	
Required%%	 
]%% 
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' !
ContraDebitNoteNumber'' +
{'', -
get''. 1
;''1 2
set''3 6
;''6 7
}''8 9
[)) 	
Required))	 
])) 
public** 
DateTime** 
TransactionDate** '
{**( )
get*** -
;**- .
set**/ 2
;**2 3
}**4 5
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
SiteCode-- 
{--  
get--! $
;--$ %
set--& )
;--) *
}--+ ,
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
CurrencyInitial00 %
{00& '
get00( +
;00+ ,
set00- 0
;000 1
}002 3
public33 
double33 

BaseAmount33  
{33! "
get33# &
;33& '
set33( +
;33+ ,
}33- .
public55 
double55 
Amount55 
{55 
get55 "
;55" #
set55$ '
;55' (
}55) *
public77 
double77 
	ForexRate77 
{77  !
get77" %
;77% &
set77' *
;77* +
}77, -
[99 	
Required99	 
]99 
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
	Narration;; 
{;;  !
get;;" %
;;;% &
set;;' *
;;;* +
};;, -
[>> 	
Required>>	 
]>> 
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
public@@ 
string@@ 
TransactionType@@ %
{@@& '
get@@( +
;@@+ ,
set@@- 0
;@@0 1
}@@2 3
[BB 	
RequiredBB	 
]BB 
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
stringDD 
SourceDocumentDD $
{DD% &
getDD' *
;DD* +
setDD, /
;DD/ 0
}DD1 2
publicFF 
shortFF 
IsCancelledFF  
{FF! "
getFF# &
;FF& '
setFF( +
;FF+ ,
}FF- .
[HH 	
RequiredHH	 
]HH 
[II 	
StringLengthII	 
(II 
$numII 
)II 
]II 
publicJJ 
stringJJ 
	CreatedByJJ 
{JJ  !
getJJ" %
;JJ% &
setJJ' *
;JJ* +
}JJ, -
publicLL 
	DebitNoteLL 
(LL 
)LL 
{MM 
}NN 
}OO 
}PP Æ

|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/InvoiceItems.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class 
InvoiceItems 
{ 
public 
int 
InvoiceItemsId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
InvoiceNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public

 
string

 
Description

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
double 
Amount 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
Status 
{ 
get 
;  
set! $
;$ %
}& '
public 
InvoiceItems 
( 
) 
{ 
} 
} 
}  
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/Invoice.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class 
Invoice 
{ 
[ 	
Key	 
] 
public		 
int		 
	InvoiceId		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public 
string 
InvoiceNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
DateTime	 
InvoiceDate 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
PropertyNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
double 
Acreage 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
TransactionCode %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
TransactionNumber '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
DateTime 
ExpirationDate &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
CustomerCode "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
CustomerName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
CustomerAddress %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string  
CustomerEmailAddress *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public!! 
string!! 
CustomerPhoneNumber!! )
{!!* +
get!!, /
;!!/ 0
set!!1 4
;!!4 5
}!!6 7
public## 
double## 
InvoiceAmount## #
{##$ %
get##& )
;##) *
set##+ .
;##. /
}##0 1
public%% 
int%% 
Status%% 
{%% 
get%% 
;%%  
set%%! $
;%%$ %
}%%& '
public'' 
string'' 
	CreatedBy'' 
{''  !
get''" %
;''% &
set''' *
;''* +
}'', -
public++ 
Invoice++ 
(++ 
)++ 
{,, 
}-- 
}.. 
}22 ⁄,
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/CreditNote.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class 

CreditNote 
{ 
[ 
Key 
] 
public		 
int			 
CreditNoteId		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
[ 
Required 
] 
public 
int	 
AccountCode 
{ 
get 
; 
set  #
;# $
}% &
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 
string	 
PropertyNumber 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
CustomerCode "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
CreditNoteNumber &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
Required	 
] 
public 
int 
ContraAccountCode $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string  
ContraPropertyNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[!! 	
Required!!	 
]!! 
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## 
ContraCustomerCode## (
{##) *
get##+ .
;##. /
set##0 3
;##3 4
}##5 6
[%% 	
Required%%	 
]%% 
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' "
ContraCreditNoteNumber'' ,
{''- .
get''/ 2
;''2 3
set''4 7
;''7 8
}''9 :
[)) 	
Required))	 
])) 
public** 
DateTime** 
TransactionDate** '
{**( )
get*** -
;**- .
set**/ 2
;**2 3
}**4 5
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
SiteCode-- 
{--  
get--! $
;--$ %
set--& )
;--) *
}--+ ,
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
CurrencyInitial00 %
{00& '
get00( +
;00+ ,
set00- 0
;000 1
}002 3
public33 
double33 

BaseAmount33  
{33! "
get33# &
;33& '
set33( +
;33+ ,
}33- .
public55 
double55 
Amount55 
{55 
get55 "
;55" #
set55$ '
;55' (
}55) *
public77 
double77 
	ForexRate77 
{77  !
get77" %
;77% &
set77' *
;77* +
}77, -
[99 	
Required99	 
]99 
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
	Narration;; 
{;;  !
get;;" %
;;;% &
set;;' *
;;;* +
};;, -
[>> 	
Required>>	 
]>> 
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
public@@ 
string@@ 
TransactionType@@ %
{@@& '
get@@( +
;@@+ ,
set@@- 0
;@@0 1
}@@2 3
[BB 	
RequiredBB	 
]BB 
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
stringDD 
SourceDocumentDD $
{DD% &
getDD' *
;DD* +
setDD, /
;DD/ 0
}DD1 2
publicFF 
shortFF 
IsCancelledFF  
{FF! "
getFF# &
;FF& '
setFF( +
;FF+ ,
}FF- .
[HH 	
RequiredHH	 
]HH 
[II 	
StringLengthII	 
(II 
$numII 
)II 
]II 
publicJJ 
stringJJ 
	CreatedByJJ 
{JJ  !
getJJ" %
;JJ% &
setJJ' *
;JJ* +
}JJ, -
publicMM 

CreditNoteMM 
(MM 
)MM 
{NN 
}OO 
}PP 
}QQ Î

t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/AuditableEntity.cs
	namespace 	
Modules
 
. 
Finance 
. 
Domain  
.  !
Entities! )
{ 
public 
class 
AuditableEntity 
{ 
public 
DateTime 
	CreatedOn !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
	CreatedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 

ModifiedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
public		 
string		 
?		 

ModifiedBy		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public

 
DateTime

 
	DeletedOn

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
string 
? 
	DeletedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} 