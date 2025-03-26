f
d/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Usings.csﬁ

t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/IUnitOfWork.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
{ 
public 
	interface 
IUnitOfWork 
: 
IDisposable  +
{ &
ICustomerDetailsRepository "
CustomerDetails# 2
{3 4
get5 8
;8 9
}: ;&
ICustomerInvoiceRepository "
CustomerInvoice# 2
{3 4
get5 8
;8 9
}: ;+
ICustomerInvoiceItemsRepository ' 
CustomerInvoiceItems( <
{= >
get? B
;B C
}D E'
ICustomerPaymentsRepository		 #
CustomerPayment		$ 3
{		4 5
get		6 9
;		9 :
}		; <+
ICustomerTransactionsRepository

 '
CustomerTransaction

( ;
{

< =
get

> A
;

A B
}

C D&
IPropertyDetailsRepository "
PropertyDetails# 2
{3 4
get5 8
;8 9
}: ;
Task 
< 
int 
> 
Complete 
( 
) 
; 
} 
} ê
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/IRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
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
Task		 
<		 
TEntity		 
?		 
>		 
Get		 
(		 
int		 
id		 !
)		! "
;		" #
Task 
< 
TEntity 
? 
> 
Get 
( 
string !
name" &
)& '
;' (
Task 
< 
IList 
< 
TEntity 
> 
> 
GetAll #
(# $

Expression 
< 
Func #
<# $
TEntity$ +
,+ ,
bool- 1
>1 2
>2 3
?3 4

expression5 ?
=@ A
nullB F
,F G
Func 
< 

IQueryable #
<# $
TEntity$ +
>+ ,
,, -
IOrderedQueryable. ?
<? @
TEntity@ G
>G H
>H I
?I J
orderByK R
=S T
nullU Y
,Y Z
List 
< 
string 
>  
?  !
includes" *
=+ ,
null- 1
) 
; 
Task 
< 
IList 
< 
TEntity 
> 
> 
GetAll #
(# $
)$ %
;% &
Task 
< 
TEntity 
? 
> 
Get 
( 

Expression %
<% &
Func& *
<* +
TEntity+ 2
,2 3
bool4 8
>8 9
>9 :

expression; E
,E F
ListG K
<K L
stringL R
>R S
?S T
includesU ]
=^ _
null` d
)d e
;e f
void 
Insert 
( 
TEntity 
entity "
)" #
;# $
void 
InsertRange 
( 
IEnumerable $
<$ %
TEntity% ,
>, -
entities. 6
)6 7
;7 8
void 
Delete 
( 
TEntity 
entity "
)" #
;# $
void 
DeleteRange 
( 
IEnumerable $
<$ %
TEntity% ,
>, -
entities. 6
)6 7
;7 8
void 
Update 
( 
TEntity 
entity "
)" #
;# $
void!! 
UpdateRange!! 
(!! 
IEnumerable!! $
<!!$ %
TEntity!!% ,
>!!, -
entities!!. 6
)!!6 7
;!!7 8
}"" 
}## º
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/IPropertyDetailsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface &
IPropertyDetailsRepository ,
:- .
IRepository/ :
<: ;
PropertyDetails; J
>J K
{ 
} 
} À
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/ICustomerTransactionsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface +
ICustomerTransactionsRepository 1
:2 3
IRepository4 ?
<? @ 
CustomerTransactions@ T
>T U
{ 
} 
} ø
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/ICustomerPaymentsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface '
ICustomerPaymentsRepository -
:. /
IRepository0 ;
<; <
CustomerPayments< L
>L M
{ 
} 
} º
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/ICustomerInvoiceRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface &
ICustomerInvoiceRepository ,
:- .
IRepository/ :
<: ;
CustomerInvoice; J
>J K
{ 
} 
} À
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/ICustomerInvoiceItemsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface +
ICustomerInvoiceItemsRepository 1
:2 3
IRepository4 ?
<? @ 
CustomerInvoiceItems@ T
>T U
{ 
} 
} º
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/Entities/ICustomerDetailsRepository.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #

Interfaces# -
.- .
Entities. 6
{ 
public 
	interface &
ICustomerDetailsRepository ,
:- .
IRepository/ :
<: ;
CustomerDetails; J
>J K
{ 
} 
} “
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Enums/StatementTransactionType.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Enums# (
{ 
public 
enum $
StatementTransactionType %
{ 
All 
= 
$num 	
,	 

Bills 
= 	
$num
 
, 
Payments 

= 
$num 
}		 
}

 √
s/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Enums/StatementPeriod.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Enums# (
{ 
public 
enum 
StatementPeriod 
{ 
All 
= 
$num 
, 
ThisYear 
= 
$num 
, 
LastYear 
= 
$num 
}		 
}

 â
q/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Enums/InvoiceStatus.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Enums# (
{ 
public 
enum 
InvoiceStatus 
{ 
Pending 	
=	 

$num
 
, 
PartiallyPaid 
= 
$num 
, 
Paid 
= 
$num 
, 	
Overdue		 	
=			 

$num		
 
}

 
} Ú#
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/Complaint.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class 
	Complaint 
{ 
[ 
Key 
] 
public		 
int			 
ComplaintId		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
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
? 
ComplaintNumber &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
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
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
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
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string	 
? 
CustomerName 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PhoneNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
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
? 
EmailAddress #
{$ %
get& )
;) *
set+ .
;. /
}0 1
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
?## 
Locality## 
{##  !
get##" %
;##% &
set##' *
;##* +
}##, -
[%% 	
Required%%	 
]%% 
public&& 
string&& 
?&& 
DetailsOfComplaint&& )
{&&* +
get&&, /
;&&/ 0
set&&1 4
;&&4 5
}&&6 7
public(( 
bool((	 
IsTheMatterInCourt((  
{((! "
get((# &
;((& '
set((( +
;((+ ,
}((- .
public** 
DateTime**	 
ComplaintDate** 
{**  !
get**" %
;**% &
set**' *
;*** +
}**, -
public,, 
string,,	 
?,, 
SubmittedBy,, 
{,, 
get,, "
;,," #
set,,$ '
;,,' (
},,) *
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// 
DocumentOne// "
{//# $
get//% (
;//( )
set//* -
;//- .
}/// 0
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22 
DocumentTwo22 "
{22# $
get22% (
;22( )
set22* -
;22- .
}22/ 0
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
DocumentThree55 $
{55% &
get55' *
;55* +
set55, /
;55/ 0
}551 2
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 
	CreatedBy88  
{88! "
get88# &
;88& '
set88( +
;88+ ,
}88- .
}:: 
};; ‘]
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerInvoice.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class 
CustomerInvoice 
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
 
)

 
]

 
public 
string 
? 
InvoiceNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
public 
DateTime 
InvoiceDate #
{$ %
get& )
;) *
set+ .
;. /
}0 1
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
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
double 
Acreage 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
TransactionCode &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
? 
TransactionNumber (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
[ 	
Required	 
] 
public 
DateTime 
ExpirationDate &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
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
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[!! 	
Required!!	 
]!! 
public"" 
string"" 
?"" 
CustomerName"" #
{""$ %
get""& )
;"") *
set""+ .
;"". /
}""0 1
public$$ 
string$$ 
?$$ 
CustomerAddress$$ &
{$$' (
get$$) ,
;$$, -
set$$. 1
;$$1 2
}$$3 4
public&& 
string&& 
?&&  
CustomerEmailAddress&& +
{&&, -
get&&. 1
;&&1 2
set&&3 6
;&&6 7
}&&8 9
[(( 	
Required((	 
](( 
public)) 
string)) 
?)) 
CustomerPhoneNumber)) *
{))+ ,
get))- 0
;))0 1
set))2 5
;))5 6
}))7 8
[++ 	
Required++	 
]++ 
public,, 
double,, 
InvoiceAmount,, #
{,,$ %
get,,& )
;,,) *
set,,+ .
;,,. /
},,0 1
public// 
double// 

AmountPaid//  
{//! "
get//# &
;//& '
set//( +
;//+ ,
}//- .
public22 
double22 

BalanceDue22  
{22! "
get22# &
;22& '
set22( +
;22+ ,
}22- .
public44 
string44 
?44 
InvoiceStatus44 $
{44% &
get44' *
;44* +
set44, /
;44/ 0
}441 2
public66 
CustomerInvoice66 
(66 
)66  
{77 	
}99 	
public;; 
CustomerInvoice;; 
(;; 
string;; %
invoiceNumber;;& 3
,;;3 4
DateTime;;5 =
invoiceDate;;> I
,;;I J
string;;K Q
?;;Q R
propertyNumber;;S a
,;;a b
double;;c i
acreage;;j q
,;;q r
string;;s y
?;;y z
transactionCode	;;{ ä
,
;;ä ã
string
;;å í
?
;;í ì
transactionNumber
;;î •
,
;;• ¶
DateTime
;;ß Ø
expirationDate
;;∞ æ
,
;;æ ø
string
;;¿ ∆
?
;;∆ «
customerCode
;;» ‘
,
;;‘ ’
string
;;÷ ‹
?
;;‹ ›
customerName
;;ﬁ Í
,
;;Í Î
string
;;Ï Ú
?
;;Ú Û
customerAddress
;;Ù É
,
;;É Ñ
string
;;Ö ã
?
;;ã å"
customerEmailAddress
;;ç °
,
;;° ¢
string<< %
?<<% &
customerPhoneNumber<<' :
,<<: ;
double<<< B
invoiceAmount<<C P
,<<P Q
double<<R X

amountPaid<<Y c
,<<c d
double<<e k

balanceDue<<l v
,<<v w
string<<x ~
invoiceStatus	<< å
)
<<å ç
{== 	
}?? 	
publicAA 
staticAA 
CustomerInvoiceAA %
AddInvoiceDetailsAA& 7
(AA7 8
stringAA8 >
invoiceNumberAA? L
,AAL M
DateTimeAAN V
invoiceDateAAW b
,AAb c
stringAAd j
?AAj k
propertyNumberAAl z
,AAz {
double	AA| Ç
acreage
AAÉ ä
,
AAä ã
string
AAå í
?
AAí ì
transactionCode
AAî £
,
AA£ §
string
AA• ´
?
AA´ ¨
transactionNumber
AA≠ æ
,
AAæ ø
DateTime
AA¿ »
expirationDate
AA… ◊
,
AA◊ ÿ
string
AAŸ ﬂ
?
AAﬂ ‡
customerCode
AA· Ì
,
AAÌ Ó
string
AAÔ ı
?
AAı ˆ
customerName
AA˜ É
,
AAÉ Ñ
string
AAÖ ã
?
AAã å
customerAddress
AAç ú
,
AAú ù
stringBB8 >
?BB> ? 
customerEmailAddressBB@ T
,BBT U
stringBBU [
?BB[ \
customerPhoneNumberBB] p
,BBp q
doubleBBr x
invoiceAmount	BBy Ü
,
BBÜ á
double
BBà é

amountPaid
BBè ô
,
BBô ö
double
BBõ °

balanceDue
BB¢ ¨
,
BB¨ ≠
string
BBÆ ¥
invoiceStatus
BBµ ¬
)
BB¬ √
{CC 	
ifDD 
(DD 
stringDD 
.DD 
IsNullOrWhiteSpaceDD )
(DD) *
invoiceNumberDD* 7
)DD7 8
||DD9 ;
stringDD< B
.DDB C
IsNullOrWhiteSpaceDDC U
(DDU V
propertyNumberDDV d
)DDd e
||DDf h
stringDDi o
.DDo p
IsNullOrWhiteSpace	DDp Ç
(
DDÇ É
customerCode
DDÉ è
)
DDè ê
||
DDë ì
string
DDî ö
.
DDö õ 
IsNullOrWhiteSpace
DDõ ≠
(
DD≠ Æ
customerName
DDÆ ∫
)
DD∫ ª
||
DDΩ ø
string
DD¿ ∆
.
DD∆ « 
IsNullOrWhiteSpace
DD« Ÿ
(
DDŸ ⁄!
customerPhoneNumber
DD⁄ Ì
)
DDÌ Ó
||
DDÔ Ò
invoiceAmount
DDÚ ˇ
<
DDÄ Å
$num
DDÇ É
)
DDÑ Ö
{EE 
throwFF 
newFF 
ArgumentExceptionFF +
(FF+ ,
$strFF, T
)FFT U
;FFU V
}GG 
ifJJ 
(JJ 
stringJJ 
.JJ 
IsNullOrWhiteSpaceJJ )
(JJ) *
invoiceNumberJJ* 7
)JJ7 8
)JJ8 9
{KK 
throwLL 
newLL 
ArgumentExceptionLL +
(LL+ ,
$strLL, W
)LLW X
;LLX Y
}MM 
ifOO 
(OO 
stringOO 
.OO 
IsNullOrWhiteSpaceOO )
(OO) *
propertyNumberOO* 8
)OO8 9
)OO9 :
{PP 
throwQQ 
newQQ 
ArgumentExceptionQQ +
(QQ+ ,
$strQQ, X
)QQX Y
;QQY Z
}RR 
ifTT 
(TT 
stringTT 
.TT 
IsNullOrWhiteSpaceTT )
(TT) *
customerCodeTT* 6
)TT6 7
)TT7 8
{UU 
throwVV 
newVV 
ArgumentExceptionVV +
(VV+ ,
$strVV, V
)VVV W
;VVW X
}WW 
ifYY 
(YY 
stringYY 
.YY 
IsNullOrWhiteSpaceYY )
(YY) *
customerNameYY* 6
)YY6 7
)YY7 8
{ZZ 
throw[[ 
new[[ 
ArgumentException[[ +
([[+ ,
$str[[, V
)[[V W
;[[W X
}\\ 
if^^ 
(^^ 
string^^ 
.^^ 
IsNullOrWhiteSpace^^ )
(^^) *
customerPhoneNumber^^* =
)^^= >
)^^> ?
{__ 
throw`` 
new`` 
ArgumentException`` +
(``+ ,
$str``, ^
)``^ _
;``_ `
}aa 
ifcc 
(cc 
invoiceDatecc 
==cc 
DateTimecc '
.cc' (
MinValuecc( 0
)cc0 1
{dd 
throwee 
newee 
ArgumentExceptionee +
(ee+ ,
$stree, W
)eeW X
;eeX Y
}ff 
ifhh 
(hh 
expirationDatehh 
==hh !
DateTimehh" *
.hh* +
MinValuehh+ 3
)hh3 4
{ii 
throwjj 
newjj 
ArgumentExceptionjj +
(jj+ ,
$strjj, Z
)jjZ [
;jj[ \
}kk 
ifmm 
(mm 
expirationDatemm 
<=mm !
invoiceDatemm" -
)mm- .
{nn 
throwoo 
newoo 
ArgumentExceptionoo +
(oo+ ,
$stroo, j
)ooj k
;ook l
}pp 
ifrr 
(rr 
invoiceAmountrr 
<=rr  
$numrr! "
)rr" #
{ss 
throwtt 
newtt 
ArgumentExceptiontt +
(tt+ ,
$strtt, W
)ttW X
;ttX Y
}uu 
returnww 
newww 
CustomerInvoiceww &
{xx 
InvoiceNumberyy 
=yy 
invoiceNumberyy  -
,yy- .
InvoiceDatezz 
=zz 
invoiceDatezz )
,zz) *
PropertyNumber{{ 
={{  
propertyNumber{{! /
,{{/ 0
Acreage|| 
=|| 
acreage|| !
,||! "
TransactionCode}} 
=}}  !
transactionCode}}" 1
,}}1 2
TransactionNumber~~ !
=~~" #
transactionNumber~~$ 5
,~~5 6
ExpirationDate 
=  
expirationDate! /
,/ 0
CustomerCode
ÄÄ 
=
ÄÄ 
customerCode
ÄÄ +
,
ÄÄ+ ,
CustomerName
ÅÅ 
=
ÅÅ 
customerName
ÅÅ +
,
ÅÅ+ ,
CustomerAddress
ÇÇ 
=
ÇÇ  !
customerAddress
ÇÇ" 1
,
ÇÇ1 2"
CustomerEmailAddress
ÉÉ $
=
ÉÉ% &"
customerEmailAddress
ÉÉ' ;
,
ÉÉ; <!
CustomerPhoneNumber
ÑÑ #
=
ÑÑ$ %!
customerPhoneNumber
ÑÑ& 9
,
ÑÑ9 :
InvoiceAmount
ÖÖ 
=
ÖÖ 
invoiceAmount
ÖÖ  -
,
ÖÖ- .

AmountPaid
ÜÜ 
=
ÜÜ 

amountPaid
ÜÜ '
,
ÜÜ' (

BalanceDue
áá 
=
áá 

balanceDue
áá '
,
áá' (
InvoiceStatus
àà 
=
àà 
invoiceStatus
àà  -
}
ää 
;
ää 
}
åå 	
}
éé 
}ëë ÖV
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerTransactions.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class  
CustomerTransactions "
{		 
[

 	
Key

	 
]

 
public 
int !
CustomerTransactionId (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
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
string 
VoucherNumber ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyNumber -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
Required	 
] 
public 
required 
DateTime  
TransactionDate! 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ReferenceNumber &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public   
string   
?   
ChequeNumber   #
{  $ %
get  & )
;  ) *
set  + .
;  . /
}  0 1
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
required## 
string## 
	Narration## (
{##) *
get##+ .
;##. /
set##0 3
;##3 4
}##5 6
[%% 	
Required%%	 
]%% 
public&& 
required&& 
double&& 
Amount&& %
{&&& '
get&&( +
;&&+ ,
set&&- 0
;&&0 1
}&&2 3
public(( 
required(( 
int(( 
AccountCode(( '
{((( )
get((* -
;((- .
set((/ 2
;((2 3
}((4 5
[** 	
Required**	 
]** 
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
required,, 
string,, 
TransactionType,, .
{,,/ 0
get,,1 4
;,,4 5
set,,6 9
;,,9 :
},,; <
[.. 	
Required..	 
].. 
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
required00 
string00 
VoucherType00 *
{00+ ,
get00- 0
;000 1
set002 5
;005 6
}007 8
public77  
CustomerTransactions77 #
(77# $
)77$ %
{88 	
}99 	
public<<  
CustomerTransactions<< #
(<<# $
int<<$ '!
customerTransactionId<<( =
,<<= >
string<<? E
voucherNumber<<F S
,<<S T
string<<U [
propertyNumber<<\ j
,<<j k
string<<l r
customerCode<<s 
,	<< Ä
DateTime
<<Å â
transactionDate
<<ä ô
,
<<ô ö
string
<<õ °
?
<<° ¢
referenceNumber
<<£ ≤
,
<<≤ ≥
string
<<¥ ∫
?
<<∫ ª
chequeNumber
<<º »
,
<<» …
string
<<  –
	narration
<<— ⁄
,
<<⁄ €
double
<<‹ ‚
amount
<<„ È
,
<<È Í
int
<<Î Ó
accountCode
<<Ô ˙
,
<<˙ ˚
string
<<¸ Ç
transactionType
<<É í
,
<<í ì
string
<<î ö
voucherType
<<õ ¶
)
<<¶ ß
{== 	
}>> 	
public@@ 
static@@  
CustomerTransactions@@ *"
AddCustomerTransaction@@+ A
(@@A B
int@@B E!
customerTransactionId@@F [
,@@[ \
string@@] c
voucherNumber@@d q
,@@q r
string@@s y
propertyNumber	@@z à
,
@@à â
string
@@ä ê
customerCode
@@ë ù
,
@@ù û
DateTime
@@ü ß
transactionDate
@@® ∑
,
@@∑ ∏
string
@@π ø
?
@@ø ¿
referenceNumber
@@¡ –
,
@@– —
string
@@“ ÿ
?
@@ÿ Ÿ
chequeNumber
@@⁄ Ê
,
@@Ê Á
string
@@Ë Ó
	narration
@@Ô ¯
,
@@¯ ˘
double
@@˙ Ä
amount
@@Å á
,
@@á à
int
@@â å
accountCode
@@ç ò
,
@@ò ô
string
@@ö †
transactionType
@@° ∞
,
@@∞ ±
string
@@≤ ∏
voucherType
@@π ƒ
)
@@ƒ ≈
{AA 	
ifBB 
(BB 
stringBB 
.BB 
IsNullOrWhiteSpaceBB )
(BB) *
voucherNumberBB* 7
)BB7 8
||BB9 ;
stringBB< B
.BBB C
IsNullOrWhiteSpaceBBC U
(BBU V
propertyNumberBBV d
)BBd e
||BBf h
stringBBi o
.BBo p
IsNullOrWhiteSpace	BBp Ç
(
BBÇ É
customerCode
BBÉ è
)
BBè ê
||
BBë ì
string
BBî ö
.
BBö õ 
IsNullOrWhiteSpace
BBõ ≠
(
BB≠ Æ
transactionType
BBÆ Ω
)
BBΩ æ
||
BBø ¡
string
BB¬ »
.
BB» … 
IsNullOrWhiteSpace
BB… €
(
BB€ ‹
voucherType
BB‹ Á
)
BBÁ Ë
||
BBÈ Î
string
BBÏ Ú
.
BBÚ Û 
IsNullOrWhiteSpace
BBÛ Ö
(
BBÖ Ü
	narration
BBÜ è
)
BBè ê
||
BBë ì
amount
BBî ö
<
BBõ ú
$num
BBù û
||
BBü °
accountCode
BB¢ ≠
<
BBÆ Ø
$num
BB∞ ±
)
BB± ≤
{CC 
throwDD 
newDD 
ArgumentExceptionDD +
(DD+ ,
$strDD, X
)DDX Y
;DDY Z
}EE 
ifHH 
(HH 
stringHH 
.HH 
IsNullOrWhiteSpaceHH )
(HH) *
voucherNumberHH* 7
)HH7 8
)HH8 9
{II 
throwJJ 
newJJ 
ArgumentExceptionJJ +
(JJ+ ,
$strJJ, W
)JJW X
;JJX Y
}KK 
ifMM 
(MM 
stringMM 
.MM 
IsNullOrWhiteSpaceMM )
(MM) *
propertyNumberMM* 8
)MM8 9
)MM9 :
{NN 
throwOO 
newOO 
ArgumentExceptionOO +
(OO+ ,
$strOO, X
)OOX Y
;OOY Z
}PP 
ifRR 
(RR 
stringRR 
.RR 
IsNullOrWhiteSpaceRR )
(RR) *
customerCodeRR* 6
)RR6 7
)RR7 8
{SS 
throwTT 
newTT 
ArgumentExceptionTT +
(TT+ ,
$strTT, V
)TTV W
;TTW X
}UU 
ifWW 
(WW 
stringWW 
.WW 
IsNullOrWhiteSpaceWW )
(WW) *
	narrationWW* 3
)WW3 4
)WW4 5
{XX 
throwYY 
newYY 
ArgumentExceptionYY +
(YY+ ,
$strYY, R
)YYR S
;YYS T
}ZZ 
if\\ 
(\\ 
transactionDate\\ 
==\\  "
DateTime\\# +
.\\+ ,
MinValue\\, 4
)\\4 5
{]] 
throw^^ 
new^^ 
ArgumentException^^ +
(^^+ ,
$str^^, [
)^^[ \
;^^\ ]
}__ 
ifaa 
(aa 
amountaa 
<=aa 
$numaa 
)aa 
{bb 
throwcc 
newcc 
ArgumentExceptioncc +
(cc+ ,
$strcc, [
)cc[ \
;cc\ ]
}dd 
ifff 
(ff 
accountCodeff 
<=ff 
$numff  
)ff  !
{gg 
throwhh 
newhh 
ArgumentExceptionhh +
(hh+ ,
$strhh, U
)hhU V
;hhV W
}ii 
ifkk 
(kk 
stringkk 
.kk 
IsNullOrWhiteSpacekk )
(kk) *
transactionTypekk* 9
)kk9 :
)kk: ;
{ll 
throwmm 
newmm 
ArgumentExceptionmm +
(mm+ ,
$strmm, Y
)mmY Z
;mmZ [
}nn 
ifpp 
(pp 
stringpp 
.pp 
IsNullOrWhiteSpacepp )
(pp) *
voucherTypepp* 5
)pp5 6
)pp6 7
{qq 
throwrr 
newrr 
ArgumentExceptionrr +
(rr+ ,
$strrr, U
)rrU V
;rrV W
}ss 
returnvv 
newvv  
CustomerTransactionsvv +
{ww !
CustomerTransactionIdxx %
=xx& '!
customerTransactionIdxx( =
,xx= >
VoucherNumberyy 
=yy 
voucherNumberyy  -
,yy- .
PropertyNumberzz 
=zz  
propertyNumberzz! /
,zz/ 0
CustomerCode{{ 
={{ 
customerCode{{ +
,{{+ ,
TransactionDate|| 
=||  !
transactionDate||" 1
,||1 2
ReferenceNumber}} 
=}}  !
referenceNumber}}" 1
,}}1 2
ChequeNumber~~ 
=~~ 
chequeNumber~~ +
,~~+ ,
	Narration 
= 
	narration %
,% &
Amount
ÄÄ 
=
ÄÄ 
amount
ÄÄ 
,
ÄÄ  
AccountCode
ÅÅ 
=
ÅÅ 
accountCode
ÅÅ )
,
ÅÅ) *
TransactionType
ÇÇ 
=
ÇÇ  !
transactionType
ÇÇ" 1
,
ÇÇ1 2
VoucherType
ÉÉ 
=
ÉÉ 
voucherType
ÉÉ )
}
ÑÑ 
;
ÑÑ 
}
ÜÜ 	
}
áá 
}ãã ÎØ
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/PropertyDetails.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 

class 
PropertyDetails  
{ 
[		 	
Key			 
]		 
public

 
int

 
PropertyMasterId

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
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
string 
PropertyNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
PropertyType "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
Locality 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
LandUse 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
LandUseType !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public   
string   
AllocationType   $
{  % &
get  ' *
;  * +
set  , /
;  / 0
}  1 2
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## 
?## 
BlockNumber## "
{### $
get##% (
;##( )
set##* -
;##- .
}##/ 0
[%% 	
StringLength%%	 
(%% 
$num%% 
)%% 
]%% 
public&& 
string&& 
?&& 

PlotNumber&& !
{&&" #
get&&$ '
;&&' (
set&&) ,
;&&, -
}&&. /
public(( 
double(( 

AcreageOne((  
{((! "
get((# &
;((& '
set((( +
;((+ ,
}((- .
public** 
double** 

AcreageTwo**  
{**! "
get**# &
;**& '
set**( +
;**+ ,
}**- .
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
PropertyHeight-- %
{--& '
get--( +
;--+ ,
set--- 0
;--0 1
}--2 3
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
PlotSize00 
{00  
get00! $
;00$ %
set00& )
;00) *
}00+ ,
public22 
double22 
SellingPrice22 "
{22# $
get22% (
;22( )
set22* -
;22- .
}22/ 0
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
Currency55 
{55  
get55! $
;55$ %
set55& )
;55) *
}55+ ,
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 

RentalType88 !
{88" #
get88$ '
;88' (
set88) ,
;88, -
}88. /
public:: 
int:: 
TotalNumberOfRooms:: %
{::& '
get::( +
;::+ ,
set::- 0
;::0 1
}::2 3
public<< 
int<< 
RoomsOccupied<<  
{<<! "
get<<# &
;<<& '
set<<( +
;<<+ ,
}<<- .
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? 
ApartmentType?? $
{??% &
get??' *
;??* +
set??, /
;??/ 0
}??1 2
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 

SchemeTypeBB !
{BB" #
getBB$ '
;BB' (
setBB) ,
;BB, -
}BB. /
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE  
ApartmentBlockNumberEE +
{EE, -
getEE. 1
;EE1 2
setEE3 6
;EE6 7
}EE8 9
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
	BlockTypeHH  
{HH! "
getHH# &
;HH& '
setHH( +
;HH+ ,
}HH- .
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
FloorNumberKK "
{KK# $
getKK% (
;KK( )
setKK* -
;KK- .
}KK/ 0
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
	BlockUnitNN  
{NN! "
getNN# &
;NN& '
setNN( +
;NN+ ,
}NN- .
[PP 	
StringLengthPP	 
(PP 
$numPP 
)PP 
]PP 
publicQQ 
stringQQ 
?QQ 
	BlockSideQQ  
{QQ! "
getQQ# &
;QQ& '
setQQ( +
;QQ+ ,
}QQ- .
[SS 	
StringLengthSS	 
(SS 
$numSS 
)SS 
]SS 
publicTT 
stringTT 
?TT 
	FloorAreaTT  
{TT! "
getTT# &
;TT& '
setTT( +
;TT+ ,
}TT- .
publicVV 
intVV 

RoomNumberVV 
{VV 
getVV  #
;VV# $
setVV% (
;VV( )
}VV* +
publicXX 
DateTimeXX 
RightOfEntryXX $
{XX% &
getXX' *
;XX* +
setXX, /
;XX/ 0
}XX1 2
=XX3 4
ConvertXX5 <
.XX< =

ToDateTimeXX= G
(XXG H
$strXXH T
)XXT U
;XXU V
publicZZ 
intZZ 
	LeaseTermZZ 
{ZZ 
getZZ "
;ZZ" #
setZZ$ '
;ZZ' (
}ZZ) *
public\\ 
DateTime\\ 
LeaseExpiryDate\\ '
{\\( )
get\\* -
;\\- .
set\\/ 2
;\\2 3
}\\4 5
=\\6 7
Convert\\8 ?
.\\? @

ToDateTime\\@ J
(\\J K
$str\\K W
)\\W X
;\\X Y
[^^ 	
StringLength^^	 
(^^ 
$num^^ 
)^^ 
]^^ 
public__ 
string__ 
?__ 
CustomerCode__ #
{__$ %
get__& )
;__) *
set__+ .
;__. /
}__0 1
[aa 	
StringLengthaa	 
(aa 
$numaa 
)aa 
]aa 
publicbb 
stringbb 
?bb 
SitePlanNumberbb %
{bb& '
getbb( +
;bb+ ,
setbb- 0
;bb0 1
}bb2 3
[dd 	
StringLengthdd	 
(dd 
$numdd 
)dd 
]dd 
publicee 
stringee 
?ee 
CadastralPlanNumberee *
{ee+ ,
getee- 0
;ee0 1
setee2 5
;ee5 6
}ee7 8
[gg 	
StringLengthgg	 
(gg 
$numgg 
)gg 
]gg 
publichh 
stringhh 
?hh 
CoordinateOnehh $
{hh% &
gethh' *
;hh* +
sethh, /
;hh/ 0
}hh1 2
[jj 	
StringLengthjj	 
(jj 
$numjj 
)jj 
]jj 
publickk 
stringkk 
?kk 
CoordinateTwokk $
{kk% &
getkk' *
;kk* +
setkk, /
;kk/ 0
}kk1 2
[mm 	
StringLengthmm	 
(mm 
$nummm 
)mm 
]mm 
publicnn 
stringnn 
?nn 
CoordinateThreenn &
{nn' (
getnn) ,
;nn, -
setnn. 1
;nn1 2
}nn3 4
[pp 	
StringLengthpp	 
(pp 
$numpp 
)pp 
]pp 
publicqq 
stringqq 
?qq 
CoordinateFourqq %
{qq& '
getqq( +
;qq+ ,
setqq- 0
;qq0 1
}qq2 3
[ss 	
StringLengthss	 
(ss 
$numss 
)ss 
]ss 
publictt 
stringtt 
?tt 
CoordinateFivett %
{tt& '
gettt( +
;tt+ ,
settt- 0
;tt0 1
}tt2 3
[vv 	
StringLengthvv	 
(vv 
$numvv 
)vv 
]vv 
publicww 
stringww 
?ww 
CoordinateSixww $
{ww% &
getww' *
;ww* +
setww, /
;ww/ 0
}ww1 2
publicyy 
boolyy 
IsLargeScaleyy  
{yy! "
getyy# &
;yy& '
setyy( +
;yy+ ,
}yy- .
=yy/ 0
falseyy1 6
;yy6 7
[{{ 	
Required{{	 
]{{ 
[|| 	
StringLength||	 
(|| 
$num|| 
)|| 
]|| 
public}} 
string}} 
ImageOne}} 
{}}  
get}}! $
;}}$ %
set}}& )
;}}) *
}}}+ ,
[ 	
StringLength	 
( 
$num 
) 
] 
public
ÄÄ 
string
ÄÄ 
?
ÄÄ 
ImageTwo
ÄÄ 
{
ÄÄ  !
get
ÄÄ" %
;
ÄÄ% &
set
ÄÄ' *
;
ÄÄ* +
}
ÄÄ, -
[
ÇÇ 	
StringLength
ÇÇ	 
(
ÇÇ 
$num
ÇÇ 
)
ÇÇ 
]
ÇÇ 
public
ÉÉ 
string
ÉÉ 
?
ÉÉ 

ImageThree
ÉÉ !
{
ÉÉ" #
get
ÉÉ$ '
;
ÉÉ' (
set
ÉÉ) ,
;
ÉÉ, -
}
ÉÉ. /
[
ÖÖ 	
StringLength
ÖÖ	 
(
ÖÖ 
$num
ÖÖ 
)
ÖÖ 
]
ÖÖ 
public
ÜÜ 
string
ÜÜ 
?
ÜÜ 
	ImageFour
ÜÜ  
{
ÜÜ! "
get
ÜÜ# &
;
ÜÜ& '
set
ÜÜ( +
;
ÜÜ+ ,
}
ÜÜ- .
[
àà 	
StringLength
àà	 
(
àà 
$num
àà 
)
àà 
]
àà 
public
ââ 
string
ââ 
?
ââ 
	ImageFive
ââ  
{
ââ! "
get
ââ# &
;
ââ& '
set
ââ( +
;
ââ+ ,
}
ââ- .
public
åå 
PropertyDetails
åå 
(
åå 
)
åå  
{
çç 	
}
éé 	
public
ëë 
PropertyDetails
ëë 
(
ëë 
string
ëë %
propertyType
ëë& 2
,
ëë2 3
string
ëë4 :
landUse
ëë; B
,
ëëB C
string
ëëD J
landUseType
ëëK V
,
ëëV W
string
ëëX ^
locality
ëë_ g
,
ëëg h
string
ëëi o
allocationType
ëëp ~
,
ëë~ 
stringëëÄ Ü
blockNumberëëá í
,ëëí ì
stringëëî ö

plotNumberëëõ •
,ëë• ¶
doubleëëß ≠

acreageOneëëÆ ∏
,ëë∏ π
doubleëë∫ ¿

acreageTwoëë¡ À
,ëëÀ Ã
stringëëÕ ”
propertyHeightëë‘ ‚
,ëë‚ „
stringëë‰ Í
plotSizeëëÎ Û
,ëëÛ Ù
stringëëı ˚
sitePlanNumberëë¸ ä
,ëëä ã
string
íí %
imageOne
íí& .
,
íí. /
string
íí0 6
imageTwo
íí7 ?
,
íí? @
string
ííA G

imageThree
ííH R
,
ííR S
string
ííT Z
	imageFour
íí[ d
,
ííd e
string
ííf l
	imageFive
íím v
,
íív w
bool
ííx |
isLargeScaleíí} â
=ííä ã
falseííå ë
)ííë í
{
ìì 	
}
ïï 	
public
óó 
static
óó 
PropertyDetails
óó % 
AddPropertyDetails
óó& 8
(
óó8 9
int
óó9 <
propertyMasterId
óó= M
,
óóM N
string
óóO U
propertyNumber
óóV d
,
óód e
string
óóf l
propertyType
óóm y
,
óóy z
stringóó{ Å
landUseóóÇ â
,óóâ ä
stringóóã ë
landUseTypeóóí ù
,óóù û
stringóóü •
localityóó¶ Æ
,óóÆ Ø
stringóó∞ ∂
allocationTypeóó∑ ≈
,óó≈ ∆
stringóó« Õ
blockNumberóóŒ Ÿ
,óóŸ ⁄
stringóó€ ·

plotNumberóó‚ Ï
,óóÏ Ì
doubleóóÓ Ù

acreageOneóóı ˇ
,óóˇ Ä
double
òò9 ?

acreageTwo
òò@ J
,
òòJ K
string
òòL R
propertyHeight
òòS a
,
òòa b
string
òòc i
plotSize
òòj r
,
òòr s
double
òòt z
sellingPriceòò{ á
,òòà â
stringòòâ è
currencyòòê ò
,òòò ô
stringòòô ü
customerCodeòò† ¨
,òò¨ ≠
stringòòÆ ¥
imageOneòòµ Ω
,òòΩ æ
stringòòø ≈
imageTwoòò∆ Œ
,òòŒ œ
stringòò– ÷

imageThreeòò◊ ·
,òò· ‚
stringòò„ È
	imageFouròòÍ Û
,òòÛ Ù
stringòòı ˚
	imageFiveòò¸ Ö
,òòÖ Ü
bool
ôô9 =
isLargeScale
ôô> J
=
ôôK L
false
ôôM R
)
ôôR S
{
öö 	
if
õõ 
(
õõ 
string
õõ 
.
õõ  
IsNullOrWhiteSpace
õõ )
(
õõ) *
propertyNumber
õõ* 8
)
õõ8 9
||
õõ: <
string
õõ= C
.
õõC D 
IsNullOrWhiteSpace
õõD V
(
õõV W
propertyType
õõW c
)
õõc d
||
õõe g
string
õõh n
.
õõn o!
IsNullOrWhiteSpaceõõo Å
(õõÅ Ç
landUseõõÇ â
)õõâ ä
||õõã ç
stringõõé î
.õõî ï"
IsNullOrWhiteSpaceõõï ß
(õõß ®
landUseTypeõõ® ≥
)õõ≥ ¥
||õõµ ∑
stringõõ∏ æ
.õõæ ø"
IsNullOrWhiteSpaceõõø —
(õõ— “
localityõõ“ ⁄
)õõ⁄ €
||õõ‹ ﬁ
stringõõﬂ Â
.õõÂ Ê"
IsNullOrWhiteSpaceõõÊ ¯
(õõ¯ ˘
allocationTypeõõ˘ á
)õõá à
||
úú 
string
úú 
.
úú  
IsNullOrWhiteSpace
úú ,
(
úú, -

plotNumber
úú- 7
)
úú7 8
||
úú9 ;
string
úú< B
.
úúB C 
IsNullOrWhiteSpace
úúC U
(
úúU V
currency
úúV ^
)
úú^ _
||
úú` b
string
úúc i
.
úúi j 
IsNullOrWhiteSpace
úúj |
(
úú| }
imageOneúú} Ö
)úúÖ Ü
||úúá â
sellingPriceúúä ñ
<=úúó ô
$numúúö õ
)úúú ù
{
ùù 
throw
ûû 
new
ûû 
ArgumentException
ûû +
(
ûû+ ,
$str
ûû, L
)
ûûL M
;
ûûM N
}
üü 
if
°° 
(
°° 
string
°° 
.
°°  
IsNullOrWhiteSpace
°° )
(
°°) *
propertyNumber
°°* 8
)
°°8 9
)
°°9 :
{
¢¢ 
throw
££ 
new
££ 
ArgumentException
££ +
(
££+ ,
$str
££, X
)
££X Y
;
££Y Z
}
§§ 
if
¶¶ 
(
¶¶ 
string
¶¶ 
.
¶¶  
IsNullOrWhiteSpace
¶¶ )
(
¶¶) *
propertyType
¶¶* 6
)
¶¶6 7
)
¶¶7 8
{
ßß 
throw
®® 
new
®® 
ArgumentException
®® +
(
®®+ ,
$str
®®, V
)
®®V W
;
®®W X
}
©© 
if
¨¨ 
(
¨¨ 
string
¨¨ 
.
¨¨  
IsNullOrWhiteSpace
¨¨ )
(
¨¨) *
landUse
¨¨* 1
)
¨¨1 2
)
¨¨2 3
{
≠≠ 
throw
ÆÆ 
new
ÆÆ 
ArgumentException
ÆÆ +
(
ÆÆ+ ,
$str
ÆÆ, Q
)
ÆÆQ R
;
ÆÆR S
}
ØØ 
if
±± 
(
±± 
string
±± 
.
±±  
IsNullOrWhiteSpace
±± )
(
±±) *
landUseType
±±* 5
)
±±5 6
)
±±6 7
{
≤≤ 
throw
≥≥ 
new
≥≥ 
ArgumentException
≥≥ +
(
≥≥+ ,
$str
≥≥, V
)
≥≥V W
;
≥≥W X
}
¥¥ 
if
∂∂ 
(
∂∂ 
string
∂∂ 
.
∂∂  
IsNullOrWhiteSpace
∂∂ )
(
∂∂) *
locality
∂∂* 2
)
∂∂2 3
)
∂∂3 4
{
∑∑ 
throw
∏∏ 
new
∏∏ 
ArgumentException
∏∏ +
(
∏∏+ ,
$str
∏∏, Q
)
∏∏Q R
;
∏∏R S
}
ππ 
if
ªª 
(
ªª 
string
ªª 
.
ªª  
IsNullOrWhiteSpace
ªª )
(
ªª) *
allocationType
ªª* 8
)
ªª8 9
)
ªª9 :
{
ºº 
throw
ΩΩ 
new
ΩΩ 
ArgumentException
ΩΩ +
(
ΩΩ+ ,
$str
ΩΩ, X
)
ΩΩX Y
;
ΩΩY Z
}
ææ 
if
¿¿ 
(
¿¿ 
string
¿¿ 
.
¿¿  
IsNullOrWhiteSpace
¿¿ )
(
¿¿) *
currency
¿¿* 2
)
¿¿2 3
)
¿¿3 4
{
¡¡ 
throw
¬¬ 
new
¬¬ 
ArgumentException
¬¬ +
(
¬¬+ ,
$str
¬¬, Q
)
¬¬Q R
;
¬¬R S
}
√√ 
if
≈≈ 
(
≈≈ 
sellingPrice
≈≈ 
<=
≈≈ 
$num
≈≈  
)
≈≈  !
{
∆∆ 
throw
«« 
new
«« 
ArgumentException
«« +
(
««+ ,
$str
««, N
)
««N O
;
««O P
}
»» 
if
   
(
   
string
   
.
    
IsNullOrWhiteSpace
   )
(
  ) *
imageOne
  * 2
)
  2 3
)
  3 4
{
ÀÀ 
throw
ÃÃ 
new
ÃÃ 
ArgumentException
ÃÃ +
(
ÃÃ+ ,
$str
ÃÃ, O
)
ÃÃO P
;
ÃÃP Q
}
ÕÕ 
return
œœ 
new
œœ 
PropertyDetails
œœ &
{
–– 
PropertyMasterId
——  
=
——! "
propertyMasterId
——# 3
,
——3 4
PropertyNumber
““ 
=
““  
propertyNumber
““! /
,
““/ 0
PropertyType
”” 
=
”” 
propertyType
”” +
,
””+ ,
Locality
‘‘ 
=
‘‘ 
locality
‘‘ #
,
‘‘# $
LandUse
’’ 
=
’’ 
landUse
’’ !
,
’’! "
LandUseType
÷÷ 
=
÷÷ 
landUseType
÷÷ )
,
÷÷) *
AllocationType
◊◊ 
=
◊◊  
allocationType
◊◊! /
,
◊◊/ 0
BlockNumber
ÿÿ 
=
ÿÿ 
blockNumber
ÿÿ )
,
ÿÿ) *

PlotNumber
ŸŸ 
=
ŸŸ 

plotNumber
ŸŸ '
,
ŸŸ' (

AcreageOne
⁄⁄ 
=
⁄⁄ 

acreageOne
⁄⁄ '
,
⁄⁄' (

AcreageTwo
€€ 
=
€€ 

acreageTwo
€€ '
,
€€' (
PropertyHeight
‹‹ 
=
‹‹  
propertyHeight
‹‹! /
,
‹‹/ 0
PlotSize
›› 
=
›› 
plotSize
›› #
,
››# $
SitePlanNumber
ﬁﬁ 
=
ﬁﬁ  
string
ﬁﬁ! '
.
ﬁﬁ' (
Empty
ﬁﬁ( -
,
ﬁﬁ- .
Currency
ﬂﬂ 
=
ﬂﬂ 
currency
ﬂﬂ #
,
ﬂﬂ# $
SellingPrice
‡‡ 
=
‡‡ 
sellingPrice
‡‡ +
,
‡‡+ ,
CustomerCode
·· 
=
·· 
customerCode
·· +
,
··+ ,
IsLargeScale
‚‚ 
=
‚‚ 
isLargeScale
‚‚ +
,
‚‚+ ,
ImageOne
„„ 
=
„„ 
imageOne
„„ #
,
„„# $
ImageTwo
‰‰ 
=
‰‰ 
imageTwo
‰‰ #
,
‰‰# $

ImageThree
ÂÂ 
=
ÂÂ 

imageThree
ÂÂ '
,
ÂÂ' (
	ImageFour
ÊÊ 
=
ÊÊ 
	imageFour
ÊÊ %
,
ÊÊ% &
	ImageFive
ÁÁ 
=
ÁÁ 
	imageFive
ÁÁ %
}
ËË 
;
ËË 
}
ÈÈ 	
}
ÌÌ 
}ÚÚ ¨å
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerPayments.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class 
CustomerPayments 
{ 
[		 	
Key			 
]		 
[

 	
Required

	 
]

 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ReceiptNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
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
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
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
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerName #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
public 
DateTime 
DateOfPayment %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
public 
string 
? 
PaymentMode "
{# $
get% (
;( )
set* -
;- .
}/ 0
public   
string   
?   
PaymentType   "
{  # $
get  % (
;  ( )
set  * -
;  - .
}  / 0
["" 	
Required""	 
]"" 
public## 
string## 
?## 
InvoiceCurrency## &
{##' (
get##) ,
;##, -
set##. 1
;##1 2
}##3 4
[%% 	
Required%%	 
]%% 
public&& 
string&& 
?&& 
PaymentCurrency&& &
{&&' (
get&&) ,
;&&, -
set&&. 1
;&&1 2
}&&3 4
[(( 	
Required((	 
](( 
public)) 
double)) 
Amount)) 
{)) 
get)) "
;))" #
set))$ '
;))' (
}))) *
[++ 	
Required++	 
]++ 
public,, 
double,, 

AmountPaid,,  
{,,! "
get,,# &
;,,& '
set,,( +
;,,+ ,
},,- .
public.. 
string.. 
?.. 
IssuingBank.. "
{..# $
get..% (
;..( )
set..* -
;..- .
}../ 0
public00 
string00 
?00 
IssuingBranch00 $
{00% &
get00' *
;00* +
set00, /
;00/ 0
}001 2
public22 
string22 
?22 
ReceivingBank22 $
{22% &
get22' *
;22* +
set22, /
;22/ 0
}221 2
public44 
string44 
?44 
ProcessingBranch44 '
{44( )
get44* -
;44- .
set44/ 2
;442 3
}444 5
public66 
string66 
?66 
ReceivingBranch66 &
{66' (
get66) ,
;66, -
set66. 1
;661 2
}663 4
public88 
string88 
?88 
PayPoint88 
{88  !
get88" %
;88% &
set88' *
;88* +
}88, -
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
ChequeNumber;; #
{;;$ %
get;;& )
;;;) *
set;;+ .
;;;. /
};;0 1
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 
ReferenceNumber>> &
{>>' (
get>>) ,
;>>, -
set>>. 1
;>>1 2
}>>3 4
[@@ 	
Required@@	 
]@@ 
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 
	PayeeNameBB  
{BB! "
getBB# &
;BB& '
setBB( +
;BB+ ,
}BB- .
[DD 	
RequiredDD	 
]DD 
publicEE 
stringEE 
?EE 
	NarrationEE  
{EE! "
getEE# &
;EE& '
setEE( +
;EE+ ,
}EE- .
[GG 	
RequiredGG	 
]GG 
[HH 	
StringLengthHH	 
(HH 
$numHH 
)HH 
]HH 
publicII 
stringII 
?II 
InvoiceNumberII $
{II% &
getII' *
;II* +
setII, /
;II/ 0
}II1 2
publicKK 
intKK 
InvoiceItemsIdKK !
{KK" #
getKK$ '
;KK' (
setKK) ,
;KK, -
}KK. /
[MM 	
RequiredMM	 
]MM 
[NN 	
StringLengthNN	 
(NN 
$numNN 
)NN 
]NN 
publicOO 
stringOO 
?OO 
CashierOO 
{OO  
getOO! $
;OO$ %
setOO& )
;OO) *
}OO+ ,
publicRR 
CustomerPaymentsRR 
(RR  
)RR  !
{SS 
}TT 
publicVV 
CustomerPaymentsVV 
(VV  
stringVV  &
receiptNumberVV' 4
,VV4 5
stringVV6 <
propertyNumberVV= K
,VVK L
stringVVM S
customerCodeVVT `
,VV` a
stringVVb h
customerNameVVi u
,VVu v
DateTimeVVw 
dateOfPayment
VVÄ ç
,
VVç é
string
VVè ï
paymentMode
VVñ °
,
VV° ¢
string
VV£ ©
paymentType
VV™ µ
,
VVµ ∂
string
VV∑ Ω
invoiceCurrency
VVæ Õ
,
VVÕ Œ
string
VVœ ’
paymentCurrency
VV÷ Â
,
VVÂ Ê
double
VVÁ Ì
amount
VVÓ Ù
,
VVÙ ı
double
VVˆ ¸

AmountPaid
VV˝ á
,
VVá à
string
VVâ è
issuingBank
VVê õ
,
VVõ ú
stringWW  &
issuingBranchWW' 4
,WW4 5
stringWW6 <
receivingBankWW= J
,WWJ K
stringWWL R
processingBranchWWS c
,WWc d
stringWWe k
receivingBranchWWl {
,WW{ |
string	WW} É
payPoint
WWÑ å
,
WWå ç
string
WWé î
chequeNumber
WWï °
,
WW° ¢
string
WW£ ©
referenceNumber
WW™ π
,
WWπ ∫
string
WWª ¡
	payeeName
WW¬ À
,
WWÀ Ã
string
WWÕ ”

njarration
WW‘ ﬁ
,
WWﬁ ﬂ
string
WW‡ Ê
invoiceNumber
WWÁ Ù
,
WWÙ ı
int
WWˆ ˘
invoiceItemsId
WW˙ à
,
WWà â
string
WWä ê
cashier
WWë ò
)
WWò ô
{XX 	
}YY 	
public[[ 
static[[ 
CustomerPayments[[ &
AddPaymentDetails[[' 8
([[8 9
string[[9 ?
receiptNumber[[@ M
,[[M N
string[[O U
propertyNumber[[V d
,[[d e
string[[f l
customerCode[[m y
,[[y z
string	[[{ Å
customerName
[[Ç é
,
[[é è
DateTime
[[ê ò
dateOfPayment
[[ô ¶
,
[[¶ ß
string
[[® Æ
paymentMode
[[Ø ∫
,
[[∫ ª
string
[[º ¬
paymentType
[[√ Œ
,
[[Œ œ
string
[[– ÷
invoiceCurrency
[[◊ Ê
,
[[Ê Á
string
[[Ë Ó
paymentCurrency
[[Ô ˛
,
[[˛ ˇ
double
[[Ä Ü
amount
[[á ç
,
[[ç é
double
[[è ï

amountPaid
[[ñ †
,
[[† °
string\\9 ?
issuingBank\\@ K
,\\K L
string\\L R
issuingBranch\\S `
,\\` a
string\\b h
receivingBank\\i v
,\\v w
string\\x ~
processingBranch	\\ è
,
\\è ê
string
\\ë ó
receivingBranch
\\ò ß
,
\\ß ®
string
\\© Ø
payPoint
\\∞ ∏
,
\\∏ π
string
\\∫ ¿
chequeNumber
\\¡ Õ
,
\\Õ Œ
string
\\œ ’
referenceNumber
\\÷ Â
,
\\Â Ê
string
\\Á Ì
	payeeName
\\Ó ˜
,
\\˜ ¯
string
\\˘ ˇ
	narration
\\Ä â
,
\\â ä
string
\\ã ë
invoiceNumber
\\í ü
,
\\ü †
int
\\° §
invoiceItemsId
\\• ≥
,
\\≥ ¥
string
\\µ ª
cashier
\\º √
)
\\√ ƒ
{]] 	
if__ 
(__ 
string__ 
.__ 
IsNullOrWhiteSpace__ )
(__) *
receiptNumber__* 7
)__7 8
||__9 ;
string__< B
.__B C
IsNullOrWhiteSpace__C U
(__U V
propertyNumber__V d
)__d e
||__f h
string__i o
.__o p
IsNullOrWhiteSpace	__p Ç
(
__Ç É
customerCode
__É è
)
__è ê
||
__ë ì
string
__î ö
.
__ö õ 
IsNullOrWhiteSpace
__õ ≠
(
__≠ Æ
customerName
__Æ ∫
)
__∫ ª
||
__º æ
string
__ø ≈
.
__≈ ∆ 
IsNullOrWhiteSpace
__∆ ÿ
(
__ÿ Ÿ
invoiceNumber
__Ÿ Ê
)
__Ê Á
||
__Ë Í
string
__Î Ò
.
__Ò Ú 
IsNullOrWhiteSpace
__Ú Ñ
(
__Ñ Ö
	narration
__Ö é
)
__é è
||
__ê í
amount
__ì ô
<
__ö õ
$num
__ú ù
||
__û †

amountPaid
__° ´
<
__¨ ≠
$num
__Æ Ø
)
__Ø ∞
{`` 
throwaa 
newaa 
ArgumentExceptionaa +
(aa+ ,
$straa, T
)aaT U
;aaU V
}bb 
ifee 
(ee 
stringee 
.ee 
IsNullOrWhiteSpaceee )
(ee) *
receiptNumberee* 7
)ee7 8
)ee8 9
{ff 
throwgg 
newgg 
ArgumentExceptiongg +
(gg+ ,
$strgg, W
)ggW X
;ggX Y
}hh 
ifjj 
(jj 
stringjj 
.jj 
IsNullOrWhiteSpacejj )
(jj) *
propertyNumberjj* 8
)jj8 9
)jj9 :
{kk 
throwll 
newll 
ArgumentExceptionll +
(ll+ ,
$strll, X
)llX Y
;llY Z
}mm 
ifoo 
(oo 
stringoo 
.oo 
IsNullOrWhiteSpaceoo )
(oo) *
customerCodeoo* 6
)oo6 7
)oo7 8
{pp 
throwqq 
newqq 
ArgumentExceptionqq +
(qq+ ,
$strqq, V
)qqV W
;qqW X
}rr 
iftt 
(tt 
stringtt 
.tt 
IsNullOrWhiteSpacett )
(tt) *
customerNamett* 6
)tt6 7
)tt7 8
{uu 
throwvv 
newvv 
ArgumentExceptionvv +
(vv+ ,
$strvv, V
)vvV W
;vvW X
}ww 
ifyy 
(yy 
stringyy 
.yy 
IsNullOrWhiteSpaceyy )
(yy) *
invoiceNumberyy* 7
)yy7 8
)yy8 9
{zz 
throw{{ 
new{{ 
ArgumentException{{ +
({{+ ,
$str{{, W
){{W X
;{{X Y
}|| 
if~~ 
(~~ 
string~~ 
.~~ 
IsNullOrWhiteSpace~~ )
(~~) *
paymentMode~~* 5
)~~5 6
)~~6 7
{ 
throw
ÄÄ 
new
ÄÄ 
ArgumentException
ÄÄ +
(
ÄÄ+ ,
$str
ÄÄ, U
)
ÄÄU V
;
ÄÄV W
}
ÅÅ 
if
ÉÉ 
(
ÉÉ 
string
ÉÉ 
.
ÉÉ  
IsNullOrWhiteSpace
ÉÉ )
(
ÉÉ) *
invoiceCurrency
ÉÉ* 9
)
ÉÉ9 :
)
ÉÉ: ;
{
ÑÑ 
throw
ÖÖ 
new
ÖÖ 
ArgumentException
ÖÖ +
(
ÖÖ+ ,
$str
ÖÖ, Y
)
ÖÖY Z
;
ÖÖZ [
}
ÜÜ 
if
àà 
(
àà 
string
àà 
.
àà  
IsNullOrWhiteSpace
àà )
(
àà) *
paymentCurrency
àà* 9
)
àà9 :
)
àà: ;
{
ââ 
throw
ää 
new
ää 
ArgumentException
ää +
(
ää+ ,
$str
ää, Y
)
ääY Z
;
ääZ [
}
ãã 
if
çç 
(
çç 
string
çç 
.
çç  
IsNullOrWhiteSpace
çç )
(
çç) *
	payeeName
çç* 3
)
çç3 4
)
çç4 5
{
éé 
throw
èè 
new
èè 
ArgumentException
èè +
(
èè+ ,
$str
èè, S
)
èèS T
;
èèT U
}
êê 
if
íí 
(
íí 
string
íí 
.
íí  
IsNullOrWhiteSpace
íí )
(
íí) *
	narration
íí* 3
)
íí3 4
)
íí4 5
{
ìì 
throw
îî 
new
îî 
ArgumentException
îî +
(
îî+ ,
$str
îî, S
)
îîS T
;
îîT U
}
ïï 
if
óó 
(
óó 
string
óó 
.
óó  
IsNullOrWhiteSpace
óó )
(
óó) *
cashier
óó* 1
)
óó1 2
)
óó2 3
{
òò 
throw
ôô 
new
ôô 
ArgumentException
ôô +
(
ôô+ ,
$str
ôô, P
)
ôôP Q
;
ôôQ R
}
öö 
if
úú 
(
úú 
dateOfPayment
úú 
==
úú  
DateTime
úú! )
.
úú) *
MinValue
úú* 2
)
úú2 3
{
ùù 
throw
ûû 
new
ûû 
ArgumentException
ûû +
(
ûû+ ,
$str
ûû, W
)
ûûW X
;
ûûX Y
}
üü 
if
°° 
(
°° 
amount
°° 
<=
°° 
$num
°° 
)
°° 
{
¢¢ 
throw
££ 
new
££ 
ArgumentException
££ +
(
££+ ,
$str
££, W
)
££W X
;
££X Y
}
§§ 
if
¶¶ 
(
¶¶ 

amountPaid
¶¶ 
<=
¶¶ 
$num
¶¶ 
)
¶¶  
{
ßß 
throw
®® 
new
®® 
ArgumentException
®® +
(
®®+ ,
$str
®®, T
)
®®T U
;
®®U V
}
©© 
return
´´ 
new
´´ 
CustomerPayments
´´ '
{
¨¨ 
ReceiptNumber
≠≠ 
=
≠≠ 
receiptNumber
≠≠  -
,
≠≠- .
PropertyNumber
ÆÆ 
=
ÆÆ  
propertyNumber
ÆÆ! /
,
ÆÆ/ 0
CustomerCode
ØØ 
=
ØØ 
customerCode
ØØ +
,
ØØ+ ,
CustomerName
∞∞ 
=
∞∞ 
customerName
∞∞ +
,
∞∞+ ,
DateOfPayment
±± 
=
±± 
dateOfPayment
±±  -
,
±±- .
PaymentMode
≤≤ 
=
≤≤ 
paymentMode
≤≤ )
,
≤≤) *
PaymentType
≥≥ 
=
≥≥ 
paymentType
≥≥ )
,
≥≥) *
InvoiceCurrency
¥¥ 
=
¥¥  !
invoiceCurrency
¥¥" 1
,
¥¥1 2
PaymentCurrency
µµ 
=
µµ  !
paymentCurrency
µµ" 1
,
µµ1 2
Amount
∂∂ 
=
∂∂ 
amount
∂∂ 
,
∂∂  

AmountPaid
∑∑ 
=
∑∑ 

amountPaid
∑∑ '
,
∑∑' (
IssuingBank
∏∏ 
=
∏∏ 
issuingBank
∏∏ )
,
∏∏) *
IssuingBranch
ππ 
=
ππ 
issuingBranch
ππ  -
,
ππ- .
ReceivingBank
∫∫ 
=
∫∫ 
receivingBank
∫∫  -
,
∫∫- .
ProcessingBranch
ªª  
=
ªª! "
processingBranch
ªª# 3
,
ªª3 4
ReceivingBranch
ºº 
=
ºº  !
receivingBranch
ºº" 1
,
ºº1 2
PayPoint
ΩΩ 
=
ΩΩ 
payPoint
ΩΩ #
,
ΩΩ# $
ChequeNumber
ææ 
=
ææ 
chequeNumber
ææ +
,
ææ+ ,
ReferenceNumber
øø 
=
øø  !
referenceNumber
øø" 1
,
øø2 3
	PayeeName
¿¿ 
=
¿¿ 
	payeeName
¿¿ %
,
¿¿% &
	Narration
¡¡ 
=
¡¡ 
	narration
¡¡ %
,
¡¡% &
InvoiceNumber
¬¬ 
=
¬¬ 
invoiceNumber
¬¬  -
,
¬¬- .
InvoiceItemsId
√√ 
=
√√  
invoiceItemsId
√√! /
,
√√/ 0
Cashier
ƒƒ 
=
ƒƒ 
cashier
ƒƒ !
}
∆∆ 
;
∆∆ 
}
   	
}
ÃÃ 
}ÕÕ Ú(
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerInvoiceItems.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class  
CustomerInvoiceItems "
{ 
[ 	
Key	 
] 
public		 
int		 
InvoiceItemsId		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
[ 	
Required	 
] 
public 
string 
? 
InvoiceNumber $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
public 
string 
? 
Description "
{# $
get% (
;( )
set* -
;- .
}/ 0
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
}) *
public 
double 

AmountPaid  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
double 

BalanceDue  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
? 
Status 
{ 
get  #
;# $
set% (
;( )
}* +
public  
CustomerInvoiceItems #
(# $
)$ %
{ 
} 
public  
CustomerInvoiceItems #
(# $
int$ '
invoiceItemsId( 6
,6 7
string8 >
invoiceNumber? L
,L M
stringN T
descriptionU `
,` a
doubleb h
amounti o
,o p
doubleq w

amountPaid	x Ç
,
Ç É
double
Ñ ä

balanceDue
ã ï
,
ï ñ
string
ó ù
status
û §
)
§ •
{   	
}"" 	
public$$ 
static$$  
CustomerInvoiceItems$$ *
AddInvoiceItems$$+ :
($$: ;
int$$; >
invoiceItemsId$$? M
,$$M N
string$$O U
invoiceNumber$$V c
,$$c d
string$$e k
description$$l w
,$$w x
double$$y 
amount
$$Ä Ü
,
$$Ü á
double
$$à é

amountPaid
$$è ô
,
$$ô ö
double
$$õ °

balanceDue
$$¢ ¨
,
$$¨ ≠
string
$$Æ ¥
status
$$µ ª
)
$$ª º
{%% 	
if&& 
(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& )
(&&) *
invoiceNumber&&* 7
)&&7 8
||&&9 ;
string&&< B
.&&B C
IsNullOrWhiteSpace&&C U
(&&U V
invoiceNumber&&V c
)&&c d
||&&e g
string&&h n
.&&n o
IsNullOrWhiteSpace	&&o Å
(
&&Å Ç
description
&&Ç ç
)
&&ç é
||
&&è ë
amount
&&í ò
<
&&ô ö
$num
&&õ ú
)
&&ú ù
{'' 
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, Z
)((Z [
;(([ \
})) 
if,, 
(,, 
string,, 
.,, 
IsNullOrWhiteSpace,, )
(,,) *
invoiceNumber,,* 7
),,7 8
),,8 9
{-- 
throw.. 
new.. 
ArgumentException.. +
(..+ ,
$str.., W
)..W X
;..X Y
}// 
if11 
(11 
string11 
.11 
IsNullOrWhiteSpace11 )
(11) *
description11* 5
)115 6
)116 7
{22 
throw33 
new33 
ArgumentException33 +
(33+ ,
$str33, a
)33a b
;33b c
}44 
if66 
(66 
amount66 
<=66 
$num66 
)66 
{77 
throw88 
new88 
ArgumentException88 +
(88+ ,
$str88, \
)88\ ]
;88] ^
}99 
return;; 
new;;  
CustomerInvoiceItems;; +
{<< 
InvoiceItemsId== 
===  
invoiceItemsId==! /
,==/ 0
InvoiceNumber>> 
=>> 
invoiceNumber>>  -
,>>- .
Description?? 
=?? 
description?? )
,??) *
Amount@@ 
=@@ 
amount@@ 
,@@  

AmountPaidAA 
=AA 

amountPaidAA '
,AA' (

BalanceDueBB 
=BB 

balanceDueBB '
,BB' (
StatusCC 
=CC 
statusCC 
}DD 
;DD 
}FF 	
}II 
}JJ üj
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerDetails.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 
class 
CustomerDetails 
{ 
[ 	
Key	 
] 
public		 
int		 
CustomerMasterId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
[ 	
Required	 
] 
public 
string 
? 
CustomerType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
public 
string 
? 
ResidentType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerName #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Picture 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
Gender 
{ 
get  #
;# $
set% (
;( )
}* +
public!! 
string!! 
?!! 
Nationality!! "
{!!# $
get!!% (
;!!( )
set!!* -
;!!- .
}!!/ 0
[## 	
StringLength##	 
(## 
$num## 
)## 
]## 
public$$ 
string$$ 
?$$ 
PostalAddress$$ $
{$$% &
get$$' *
;$$* +
set$$, /
;$$/ 0
}$$1 2
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
ResidentialAddress'' )
{''* +
get'', /
;''/ 0
set''1 4
;''4 5
}''6 7
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** 
DigitalAddress** %
{**& '
get**( +
;**+ ,
set**- 0
;**0 1
}**2 3
[,, 	
Required,,	 
],, 
[-- 	
StringLength--	 
(-- 
$num-- 
)-- 
]-- 
public.. 
string.. 
?.. 
PrimaryMobileNumber.. *
{..+ ,
get..- 0
;..0 1
set..2 5
;..5 6
}..7 8
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
string11 
?11 !
SecondaryMobileNumber11 ,
{11- .
get11/ 2
;112 3
set114 7
;117 8
}119 :
[33 	
StringLength33	 
(33 
$num33 
)33 
]33 
public44 
string44 
?44 
OfficeNumber44 #
{44$ %
get44& )
;44) *
set44+ .
;44. /
}440 1
[66 	
StringLength66	 
(66 
$num66 
)66 
]66 
public77 
string77 
?77 
WhatsAppNumber77 %
{77& '
get77( +
;77+ ,
set77- 0
;770 1
}772 3
[99 	
EmailAddress99	 
]99 
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
EmailAddress;; #
{;;$ %
get;;& )
;;;) *
set;;+ .
;;;. /
};;0 1
public== 
string== 
?== 
SocialMediaType== &
{==' (
get==) ,
;==, -
set==. 1
;==1 2
}==3 4
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
public@@ 
string@@ 
?@@ 
SocialMediaAccount@@ )
{@@* +
get@@, /
;@@/ 0
set@@1 4
;@@4 5
}@@6 7
publicEE 
CustomerDetailsEE 
(EE 
)EE  
{FF 
}GG 
publicII 
CustomerDetailsII 
(II 
intII "
customerMasterIdII# 3
,II3 4
stringII5 ;
customerTypeII< H
,IIH I
stringIIJ P
residentTypeIIQ ]
,II] ^
stringII_ e
localityIIf n
,IIn o
stringIIp v
customerCode	IIw É
,
IIÉ Ñ
string
IIÖ ã
customerName
IIå ò
,
IIò ô
string
IIö †
picture
II° ®
,
II® ©
string
II™ ∞
gender
II± ∑
,
II∑ ∏
string
IIπ ø
nationality
II¿ À
,
IIÀ Ã
string
IIÕ ”
postalAddress
II‘ ·
,
II· ‚
string
II„ È 
residentialAddress
IIÍ ¸
,
II¸ ˝
string
II˛ Ñ
digitalAddress
IIÖ ì
,
IIì î
string
IIï õ!
primaryMobileNumber
IIú Ø
,
IIØ ∞
stringJJ !
secondaryMobileNumberJJ (
,JJ( )
stringJJ* 0
officeNumberJJ1 =
,JJ= >
stringJJ? E
whatsAppNumberJJF T
,JJT U
stringJJV \
emailAddressJJ] i
,JJi j
stringJJk q
socialMediaType	JJr Å
,
JJÅ Ç
string
JJÉ â 
socialMediaAccount
JJä ú
)
JJú ù
{KK 	
}MM 	
publicOO 
staticOO 
CustomerDetailsOO %
AddCustomerDetailsOO& 8
(OO8 9
intOO9 <
customerMasterIdOO= M
,OOM N
stringOOO U
customerTypeOOV b
,OOb c
stringOOd j
residentTypeOOk w
,OOw x
stringOOy 
locality
OOÄ à
,
OOà â
string
OOä ê
customerCode
OOë ù
,
OOù û
string
OOü •
customerName
OO¶ ≤
,
OO≤ ≥
string
OO¥ ∫
picture
OOª ¬
,
OO¬ √
string
OOƒ  
gender
OOÀ —
,
OO— “
string
OO” Ÿ
nationality
OO⁄ Â
,
OOÂ Ê
string
OOÁ Ì
postalAddress
OOÓ ˚
,
OO˚ ¸
string
OO˝ É 
residentialAddress
OOÑ ñ
,
OOñ ó
string
OOò û
digitalAddress
OOü ≠
,
OO≠ Æ
string
OOØ µ!
primaryMobileNumber
OO∂ …
,
OO…  
stringPP !
secondaryMobileNumberPP (
,PP( )
stringPP* 0
officeNumberPP1 =
,PP= >
stringPP? E
whatsAppNumberPPF T
,PPT U
stringPPV \
emailAddressPP] i
,PPi j
stringPPk q
socialMediaType	PPr Å
,
PPÅ Ç
string
PPÉ â 
socialMediaAccount
PPä ú
)
PPú ù
{QQ 	
ifRR 
(RR 
stringRR 
.RR 
IsNullOrWhiteSpaceRR )
(RR) *
customerTypeRR* 6
)RR6 7
||RR8 :
stringRR; A
.RRA B
IsNullOrWhiteSpaceRRB T
(RRT U
residentTypeRRU a
)RRa b
||RRc e
stringRRf l
.RRl m
IsNullOrWhiteSpaceRRm 
(	RR Ä
locality
RRÄ à
)
RRà â
||
RRä å
string
RRç ì
.
RRì î 
IsNullOrWhiteSpace
RRî ¶
(
RR¶ ß
customerCode
RRß ≥
)
RR≥ ¥
||
RRµ ∑
string
RR∏ æ
.
RRæ ø 
IsNullOrWhiteSpace
RRø —
(
RR— “
customerName
RR“ ﬁ
)
RRﬁ ﬂ
||
RR‡ ‚
string
RR„ È
.
RRÈ Í 
IsNullOrWhiteSpace
RRÍ ¸
(
RR¸ ˝!
primaryMobileNumber
RR˝ ê
)
RRê ë
||
RRí î
string
RRï õ
.
RRõ ú 
IsNullOrWhiteSpace
RRú Æ
(
RRÆ Ø
emailAddress
RRØ ª
)
RRª º
)
RRº Ω
{SS 
throwTT 
newTT 
ArgumentExceptionTT +
(TT+ ,
$strTT, L
)TTL M
;TTM N
}UU 
ifXX 
(XX 
stringXX 
.XX 
IsNullOrWhiteSpaceXX )
(XX) *
customerTypeXX* 6
)XX6 7
)XX7 8
{YY 
throwZZ 
newZZ 
ArgumentExceptionZZ +
(ZZ+ ,
$strZZ, V
)ZZV W
;ZZW X
}[[ 
if]] 
(]] 
string]] 
.]] 
IsNullOrWhiteSpace]] *
(]]* +
residentType]]+ 7
)]]7 8
)]]8 9
{^^ 
throw__ 
new__ 
ArgumentException__ +
(__+ ,
$str__, V
)__V W
;__W X
}`` 
ifbb 
(bb 
stringbb 
.bb 
IsNullOrWhiteSpacebb )
(bb) *
localitybb* 2
)bb2 3
)bb3 4
{cc 
throwdd 
newdd 
ArgumentExceptiondd +
(dd+ ,
$strdd, Q
)ddQ R
;ddR S
}ee 
ifgg 
(gg 
stringgg 
.gg 
IsNullOrWhiteSpacegg )
(gg) *
customerCodegg* 6
)gg6 7
)gg7 8
{hh 
throwii 
newii 
ArgumentExceptionii +
(ii+ ,
$strii, V
)iiV W
;iiW X
}jj 
ifll 
(ll 
stringll 
.ll 
IsNullOrWhiteSpacell )
(ll) *
customerNamell* 6
)ll6 7
)ll7 8
{mm 
thrownn 
newnn 
ArgumentExceptionnn +
(nn+ ,
$strnn, V
)nnV W
;nnW X
}oo 
ifqq 
(qq 
stringqq 
.qq 
IsNullOrWhiteSpaceqq )
(qq) *
primaryMobileNumberqq* =
)qq= >
)qq> ?
{rr 
throwss 
newss 
ArgumentExceptionss +
(ss+ ,
$strss, U
)ssU V
;ssV W
}tt 
ifvv 
(vv 
stringvv 
.vv 
IsNullOrWhiteSpacevv )
(vv) *
emailAddressvv* 6
)vv6 7
)vv7 8
{ww 
throwxx 
newxx 
ArgumentExceptionxx +
(xx+ ,
$strxx, _
)xx_ `
;xx` a
}yy 
return{{ 
new{{ 
CustomerDetails{{ &
{|| 
CustomerMasterId}}  
=}}! "
customerMasterId}}# 3
,}}3 4
CustomerType~~ 
=~~ 
customerType~~ +
,~~+ ,
ResidentType 
= 
residentType +
,+ ,
Locality
ÄÄ 
=
ÄÄ 
locality
ÄÄ #
,
ÄÄ# $
CustomerCode
ÅÅ 
=
ÅÅ 
customerCode
ÅÅ +
,
ÅÅ+ ,
CustomerName
ÇÇ 
=
ÇÇ 
customerName
ÇÇ +
,
ÇÇ+ ,
Picture
ÉÉ 
=
ÉÉ 
picture
ÉÉ !
,
ÉÉ! "
Gender
ÑÑ 
=
ÑÑ 
gender
ÑÑ 
,
ÑÑ  
Nationality
ÖÖ 
=
ÖÖ 
nationality
ÖÖ )
,
ÖÖ) *
PostalAddress
ÜÜ 
=
ÜÜ 
postalAddress
ÜÜ  -
,
ÜÜ- . 
ResidentialAddress
áá "
=
áá# $ 
residentialAddress
áá% 7
,
áá7 8
DigitalAddress
àà 
=
àà  
digitalAddress
àà! /
,
àà/ 0!
PrimaryMobileNumber
ââ #
=
ââ$ %!
primaryMobileNumber
ââ& 9
,
ââ9 :#
SecondaryMobileNumber
ää %
=
ää& '#
secondaryMobileNumber
ää( =
,
ää= >
OfficeNumber
ãã 
=
ãã 
officeNumber
ãã +
,
ãã+ ,
WhatsAppNumber
åå 
=
åå  
whatsAppNumber
åå! /
,
åå/ 0
EmailAddress
çç 
=
çç 
emailAddress
çç +
,
çç+ ,
SocialMediaType
éé 
=
éé  !
socialMediaType
éé" 1
,
éé1 2 
SocialMediaAccount
èè "
=
èè# $ 
socialMediaAccount
èè% 7
}
êê 
;
êê 
}
ëë 	
}
îî 
}ïï Ô

v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/AuditableEntity.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Domain "
." #
Entities# +
{ 
public 

class 
AuditableEntity  
{ 
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