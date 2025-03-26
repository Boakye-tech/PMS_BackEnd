k
i/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Usings.csÅm
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/PropertyDetailsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class "
PropertyDetailsService $
:% &#
IPropertyDetailsService' >
{ 
private		 
readonly		 
IUnitOfWork		 $
_unitOfWork		% 0
;		0 1
private

 
readonly

 
IMapper

  
_mapper

! (
;

( )
public "
PropertyDetailsService %
(% &
IUnitOfWork& 1

unitOfWork2 <
,< =
IMapper> E
mapperF L
)L M
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
GenericResponseDto ,
>, -!
AddNewPropertyDetails. C
(C D
PropertyDetailsDtoD V
valuesW ]
)] ^
{ 	
PropertyDetails 
property $
=% &
PropertyDetails' 6
.6 7
AddPropertyDetails7 I
(I J
valuesJ P
.P Q
PropertyMasterIdQ a
,a b
valuesc i
.i j
PropertyNumberj x
,x y
values	z Ä
.
Ä Å
PropertyType
Å ç
,
ç é
values
è ï
.
ï ñ
LandUse
ñ ù
,
ù û
values
ü •
.
• ¶
LandUseType
¶ ±
,
± ≤
values
≥ π
.
π ∫
Locality
∫ ¬
,
¬ √
values
ƒ  
.
  À
AllocationType
À Ÿ
,
Ÿ ⁄
valuesJ P
.P Q
BlockNumberQ \
!\ ]
,] ^
values_ e
.e f

PlotNumberf p
,p q
valuesr x
.x y

AcreageOne	y É
,
É Ñ
values
Ö ã
.
ã å

AcreageTwo
å ñ
,
ñ ó
values
ò û
.
û ü
PropertyHeight
ü ≠
!
≠ Æ
,
Æ Ø
values
∞ ∂
.
∂ ∑
PlotSize
∑ ø
!
ø ¿
,
¿ ¡
values
¡ «
.
« »
SellingPrice
» ‘
,
‘ ’
values
’ €
.
€ ‹
Currency
‹ ‰
,
‰ Â
valuesJ P
.P Q
CustomerCodeQ ]
!] ^
,^ _
values` f
.f g
PropertyImagesg u
!u v
[v w
$numw x
]x y
.y z
ImageOne	z Ç
!
Ç É
,
É Ñ
values
Ö ã
.
ã å
PropertyImages
å ö
[
ö õ
$num
õ ú
]
ú ù
.
ù û
ImageTwo
û ¶
!
¶ ß
,
ß ®
values
© Ø
.
Ø ∞
PropertyImages
∞ æ
[
æ ø
$num
ø ¿
]
¿ ¡
.
¡ ¬

ImageThree
¬ Ã
!
Ã Õ
,
Õ Œ
values
œ ’
.
’ ÷
PropertyImages
÷ ‰
[
‰ Â
$num
Â Ê
]
Ê Á
.
Á Ë
	ImageFour
Ë Ò
!
Ò Ú
,
Ú Û
valuesJ P
.P Q
PropertyImagesQ _
[_ `
$num` a
]a b
.b c
	ImageFivec l
!l m
,m n
falsen s
)s t
;t u
_unitOfWork 
. 
PropertyDetails '
.' (
Insert( .
(. /
property/ 7
)7 8
;8 9
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
GenericResponseDto )
{* +
response, 4
=5 6
$str7 <
}= >
;> ?
}   	
public"" 
async"" 
Task"" 
<"" 
IEnumerable"" %
<""% &+
AvailablePropertySummaryViewDto""& E
>""E F
>""F G&
AvailablePropertiesSummary""H b
(""b c
)""c d
{## 	
var$$ 
propertyDetails$$ 
=$$  !
await$$" '
_unitOfWork$$( 3
.$$3 4
PropertyDetails$$4 C
.$$C D
GetAll$$D J
($$J K
pd$$K M
=>$$N P
pd$$Q S
.$$S T
CustomerCode$$T `
==$$a c
string$$d j
.$$j k
Empty$$k p
)$$p q
;$$q r
var%% 
summary%% 
=%% 
propertyDetails%% )
.%%) *
Select%%* 0
(%%0 1
pd%%1 3
=>%%4 6
new%%7 :+
AvailablePropertySummaryViewDto%%; Z
{&& 
PropertyNumber'' 
=''  
pd''! #
.''# $
PropertyNumber''$ 2
,''2 3
LandUse(( 
=(( 
pd(( 
.(( 
LandUse(( $
,(($ %
Address)) 
=)) 
$")) 
{)) 
pd)) 
.))  
Locality))  (
}))( )
$str))) 2
{))2 3
pd))3 5
.))5 6
BlockNumber))6 A
}))A B
$str))B P
{))P Q
pd))Q S
.))S T

PlotNumber))T ^
}))^ _
"))_ `
,))` a
Image** 
=** 
pd** 
.** 
ImageOne** #
,**# $
Currency++ 
=++ 
pd++ 
.++ 
Currency++ &
,++& '
SellingPrice,, 
=,, 
pd,, !
.,,! "
SellingPrice,," .
}-- 
)-- 
.-- 
ToList-- 
(-- 
)-- 
;-- 
return00 
summary00 
;00 
}11 	
public33 
Task33 
<33 
GenericResponseDto33 &
>33& '!
DeletePropertyDetails33( =
(33= >
string33> D
value33E J
)33J K
{44 	
throw55 
new55 #
NotImplementedException55 -
(55- .
)55. /
;55/ 0
}66 	
public88 
async88 
Task88 
<88 "
PropertyDetailsReadDto88 0
>880 1
GetPropertyDetails882 D
(88D E
string88E K
propertyNumber88L Z
)88Z [
{99 	
var;; 
propertydetails;; 
=;;  !
await;;" '
_unitOfWork;;( 3
.;;3 4
PropertyDetails;;4 C
.;;C D
Get;;D G
(;;G H
pd;;H J
=>;;K M
pd;;N P
.;;P Q
PropertyNumber;;Q _
==;;` b
propertyNumber;;c q
);;q r
;;;r s
string== 
[== 
]== 
images== 
=== 
new== !
string==" (
[==( )
]==) *
{==+ ,
propertydetails==- <
!==< =
.=== >
ImageOne==> F
!==F G
,==G H
propertydetails==I X
.==X Y
ImageTwo==Y a
!==a b
,==b c
propertydetails==d s
.==s t

ImageThree==t ~
!==~ 
,	== Ä
propertydetails
==Å ê
.
==ê ë
	ImageFour
==ë ö
!
==ö õ
,
==õ ú
propertydetails
==ù ¨
.
==¨ ≠
	ImageFive
==≠ ∂
!
==∂ ∑
}
==∏ π
;
==π ∫"
PropertyDetailsReadDto>> "
propertyDetails>># 2
=>>3 4
_mapper>>5 <
.>>< =
Map>>= @
<>>@ A"
PropertyDetailsReadDto>>A W
>>>W X
(>>X Y
propertydetails>>Y h
)>>h i
;>>i j
propertyDetails?? 
.?? 
PropertyImages?? *
=??+ ,
images??- 3
;??3 4
propertyDetails@@ 
.@@ 
Address@@ #
=@@$ %
$"@@& (
{@@( )
propertyDetails@@) 8
.@@8 9
Locality@@9 A
}@@A B
$str@@B K
{@@K L
propertyDetails@@L [
.@@[ \
BlockNumber@@\ g
}@@g h
$str@@h v
{@@v w
propertyDetails	@@w Ü
.
@@Ü á

PlotNumber
@@á ë
}
@@ë í
"
@@í ì
;
@@ì î
returnBB 
propertyDetailsBB "
;BB" #
}DD 	
publicFF 
asyncFF 
TaskFF 
<FF 
IEnumerableFF &
<FF& '(
PropertySummaryMobileViewDtoFF' C
>FFC D
>FFD E$
GetPropertySummaryMobileFFF ^
(FF^ _
stringFF_ e
customerCodeFFf r
)FFr s
{GG 	
varHH 
summaryHH 
=HH 
(HH 
awaitHH  
_unitOfWorkHH! ,
.HH, -
CustomerTransactionHH- @
.HH@ A
GetAllHHA G
(HHG H
ctHHH J
=>HHK M
ctHHN P
.HHP Q
CustomerCodeHHQ ]
==HH^ `
customerCodeHHa m
)HHm n
)HHn o
.II 
JoinII 
(II 
awaitII !
_unitOfWorkII" -
.II- .
PropertyDetailsII. =
.II= >
GetAllII> D
(IID E
pdIIE G
=>IIH J
pdIIK M
.IIM N
CustomerCodeIIN Z
==II[ ]
customerCodeII^ j
)IIj k
,IIk l
transactionJJ  +
=>JJ, .
transactionJJ/ :
.JJ: ;
PropertyNumberJJ; I
,JJI J
propertyKK  (
=>KK) +
propertyKK, 4
.KK4 5
PropertyNumberKK5 C
,KKC D
(LL  !
transactionLL! ,
,LL, -
propertyLL. 6
)LL6 7
=>LL8 :
newLL; >(
PropertySummaryMobileViewDtoLL? [
{MM  !
PropertyNumberNN$ 2
=NN3 4
transactionNN5 @
.NN@ A
PropertyNumberNNA O
,NNO P
LandUseOO$ +
=OO, -
propertyOO. 6
.OO6 7
LandUseOO7 >
,OO> ?
BalancePP$ +
=PP, -
transactionPP. 9
.PP9 :
AmountPP: @
,PP@ A
ImageQQ$ )
=QQ* +
propertyQQ, 4
.QQ4 5
ImageOneQQ5 =
}RR  !
)RR! "
.SS 
GroupBySS $
(SS$ %
tSS% &
=>SS' )
newSS* -
{SS. /
tSS0 1
.SS1 2
PropertyNumberSS2 @
,SS@ A
tSSB C
.SSC D
LandUseSSD K
,SSK L
tSSM N
.SSN O
ImageSSO T
}SSU V
)SSV W
.TT 
SelectTT #
(TT# $
gTT$ %
=>TT& (
newTT) ,(
PropertySummaryMobileViewDtoTT- I
{UU 
PropertyNumberVV  .
=VV/ 0
gVV1 2
.VV2 3
KeyVV3 6
.VV6 7
PropertyNumberVV7 E
,VVE F
LandUseWW  '
=WW( )
gWW* +
.WW+ ,
KeyWW, /
.WW/ 0
LandUseWW0 7
,WW7 8
BalanceXX  '
=XX( )
gXX* +
.XX+ ,
SumXX, /
(XX/ 0
tXX0 1
=>XX2 4
tXX5 6
.XX6 7
BalanceXX7 >
)XX> ?
,XX? @
ImageYY  %
=YY& '
gYY( )
.YY) *
KeyYY* -
.YY- .
ImageYY. 3
}ZZ 
)ZZ 
.[[ 
ToList[[ #
([[# $
)[[$ %
;[[% &
return]] 
summary]] 
;]] 
}__ 	
publicaa 
asyncaa 
Taskaa 
<aa 
IEnumerableaa %
<aa% &%
PropertySummaryWebViewDtoaa& ?
>aa? @
>aa@ A!
GetPropertySummaryWebaaB W
(aaW X
stringaaX ^
customerCodeaa_ k
)aak l
{bb 	
varcc 
propertyDetailscc 
=cc  !
awaitcc" '
_unitOfWorkcc( 3
.cc3 4
PropertyDetailscc4 C
.ccC D
GetAllccD J
(ccJ K
pdccK M
=>ccN P
pdccQ S
.ccS T
CustomerCodeccT `
==cca c
customerCodeccd p
)ccp q
;ccq r
vardd 
summarydd 
=dd 
propertyDetailsdd )
.dd) *
Selectdd* 0
(dd0 1
pddd1 3
=>dd4 6
newdd7 :%
PropertySummaryWebViewDtodd; T
{ee 
PropertyNumberff 
=ff  
pdff! #
.ff# $
PropertyNumberff$ 2
,ff2 3
LandUsegg 
=gg 
pdgg 
.gg 
LandUsegg $
,gg$ %
Addresshh 
=hh 
pdhh 
.hh 
Localityhh %
,hh% &
Imageii 
=ii 
pdii 
.ii 
ImageOneii #
}jj 
)jj 
.jj 
ToListjj 
(jj 
)jj 
;jj 
returnmm 
summarymm 
;mm 
}oo 	
publicqq 
Taskqq 
<qq 
GenericResponseDtoqq &
>qq& '!
UpdatePropertyDetailsqq( =
(qq= >
PropertyDetailsDtoqq> P
valuesqqQ W
)qqW X
{rr 	
throwss 
newss #
NotImplementedExceptionss -
(ss- .
)ss. /
;ss/ 0
}tt 	
}uu 
}vv ﬂ`
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerTransactionsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class '
CustomerTransactionsService )
:* +(
ICustomerTransactionsService, H
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
public		 '
CustomerTransactionsService		 *
(		* +
IUnitOfWork		+ 6

unitOfWork		7 A
)		A B
{

 	
_unitOfWork 
= 

unitOfWork $
;$ %
} 	
public 
async 
Task 
< 
GenericResponseDto ,
>, -,
 AddNewCustomerTransactionDetails. N
(N O#
CustomerTransactionsDtoO f
valuesg m
)m n
{ 	 
CustomerTransactions  
transactions! -
=. / 
CustomerTransactions0 D
.D E"
AddCustomerTransactionE [
([ \
$num\ ]
,] ^
values_ e
.e f
VoucherNumberf s
,s t
valuesu {
.{ |
PropertyNumber	| ä
,
ä ã
values
å í
.
í ì
CustomerCode
ì ü
,
ü †
values
° ß
.
ß ®
TransactionDate
® ∑
,
∑ ∏
values
π ø
.
ø ¿
ReferenceNumber
¿ œ
,
œ –
values
— ◊
.
◊ ÿ
ChequeNumber
ÿ ‰
,
‰ Â
values
Ê Ï
.
Ï Ì
	Narration
Ì ˆ
,
˜ ¯
values
¯ ˛
.
˛ ˇ
Amount
ˇ Ö
,
Ö Ü
values
á ç
.
ç é
AccountCode
é ô
,
ô ö
values
õ °
.
° ¢
TransactionType
¢ ±
,
± ≤
values
≤ ∏
.
∏ π
VoucherType
π ƒ
)
ƒ ≈
;
≈ ∆
_unitOfWork 
. 
CustomerTransaction +
.+ ,
Insert, 2
(2 3
transactions3 ?
)? @
;@ A
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
GenericResponseDto )
{* +
response, 4
=5 6
$str7 <
}= >
;> ?
} 	
public 
async 
Task 
< 
IEnumerable %
<% &'
CustomerTransactionsReadDto& A
>A B
>B C&
CustomerTransactionDetailsD ^
(^ _
string_ e
customerCodef r
,r s
stringt z
propertyNumber	{ â
)
â ä
{ 	
var 
transactionsQuery !
=" #
($ %
await% *
_unitOfWork+ 6
.6 7
CustomerTransaction7 J
.J K
GetAllK Q
(Q R
)R S
)S T
.$ %
OrderByDescending% 6
(6 7
t7 8
=>9 ;
t< =
.= >
TransactionDate> M
)M N
.$ %
Select% +
(+ ,
t, -
=>. 0
new1 4'
CustomerTransactionsReadDto5 P
{$ %
VoucherNumber  ( 5
=  6 7
t  8 9
.  9 :
VoucherNumber  : G
,  G H
CustomerCode!!( 4
=!!5 6
t!!7 8
.!!8 9
CustomerCode!!9 E
,!!E F
PropertyNumber""( 6
=""7 8
t""9 :
."": ;
PropertyNumber""; I
,""I J
TransactionDate##( 7
=##8 9
t##: ;
.##; <
TransactionDate##< K
,##K L
ChequeNumber$$( 4
=$$5 6
t$$7 8
.$$8 9
ChequeNumber$$9 E
,$$E F
ReferenceNumber%%( 7
=%%8 9
t%%: ;
.%%; <
ReferenceNumber%%< K
,%%K L
	Narration&&( 1
=&&2 3
t&&4 5
.&&5 6
	Narration&&6 ?
,&&? @
Amount''( .
=''/ 0
t''1 2
.''2 3
Amount''3 9
,''9 :
PaymentMethod((( 5
=((6 7
string((8 >
.((> ?
IsNullOrEmpty((? L
(((L M
t((M N
.((N O
ChequeNumber((O [
)(([ \
?)), -
()). /
!))/ 0
string))0 6
.))6 7
IsNullOrEmpty))7 D
())D E
t))E F
.))F G
ReferenceNumber))G V
)))V W
?))X Y
$str))Z e
:))f g
$str))h n
)))n o
:**, -
$str**. 6
,**6 7
VoucherType++( 3
=++4 5
t++6 7
.++7 8
VoucherType++8 C
,++C D
TransactionType,,( 7
=,,8 9
t,,: ;
.,,; <
TransactionType,,< K
}--$ %
)--% &
.--& '
AsQueryable--' 2
(--2 3
)--3 4
;--4 5
if// 
(// 
!// 
string// 
.// 
IsNullOrEmpty// %
(//% &
customerCode//& 2
)//2 3
)//3 4
transactionsQuery00 !
=00" #
transactionsQuery00$ 5
.005 6
Where006 ;
(00; <
t00< =
=>00> @
t00A B
.00B C
CustomerCode00C O
==00P R
customerCode00S _
)00_ `
;00` a
if22 
(22 
!22 
string22 
.22 
IsNullOrEmpty22 %
(22% &
propertyNumber22& 4
)224 5
)225 6
transactionsQuery33 !
=33" #
transactionsQuery33$ 5
.335 6
Where336 ;
(33; <
t33< =
=>33> @
t33A B
.33B C
PropertyNumber33C Q
==33R T
propertyNumber33U c
)33c d
;33d e
transactionsQuery66 
.66 
OrderByDescending66 /
(66/ 0
t660 1
=>662 4
t665 6
.666 7
TransactionDate667 F
)66F G
;66G H
return88 
transactionsQuery88 $
!88$ %
;88% &
}:: 	
public<< 
async<< 
Task<< 
<<< 
IEnumerable<< %
<<<% &'
CustomerTransactionsReadDto<<& A
><<A B
><<B C
CustomerStatement<<D U
(<<U V
string<<V \
customerCode<<] i
,<<i j
string<<k q
propertyNumber	<<r Ä
,
<<Ä Å
string
<<Ç à&
receipt_or_invoiceNumber
<<â °
,
<<° ¢
string
<<£ ©
transactionType
<<™ π
,
<<π ∫
int
<<ª æ
year
<<ø √
)
<<√ ƒ
{== 	
var?? 
transactionsQuery?? !
=??" #
(??$ %
await??% *
_unitOfWork??+ 6
.??6 7
CustomerTransaction??7 J
.??J K
GetAll??K Q
(??Q R
)??R S
)??S T
.??T U
AsQueryable??U `
(??` a
)??a b
;??b c
ifCC 
(CC 
!CC 
stringCC 
.CC 
IsNullOrEmptyCC %
(CC% &
customerCodeCC& 2
)CC2 3
)CC3 4
transactionsQueryDD !
=DD" #
transactionsQueryDD$ 5
.DD5 6
WhereDD6 ;
(DD; <
tDD< =
=>DD> @
tDDA B
.DDB C
CustomerCodeDDC O
==DDP R
customerCodeDDS _
)DD_ `
;DD` a
ifFF 
(FF 
!FF 
stringFF 
.FF 
IsNullOrEmptyFF %
(FF% &
propertyNumberFF& 4
)FF4 5
)FF5 6
transactionsQueryGG !
=GG" #
transactionsQueryGG$ 5
.GG5 6
WhereGG6 ;
(GG; <
tGG< =
=>GG> @
tGGA B
.GGB C
PropertyNumberGGC Q
==GGR T
propertyNumberGGU c
)GGc d
;GGd e
ifII 
(II 
!II 
stringII 
.II 
IsNullOrEmptyII %
(II% &$
receipt_or_invoiceNumberII& >
)II> ?
)II? @
transactionsQueryJJ !
=JJ" #
transactionsQueryJJ$ 5
.JJ5 6
WhereJJ6 ;
(JJ; <
tJJ< =
=>JJ> @
tJJA B
.JJB C
VoucherNumberJJC P
==JJQ S$
receipt_or_invoiceNumberJJT l
)JJl m
;JJm n
ifLL 
(LL 
!LL 
stringLL 
.LL 
IsNullOrEmptyLL %
(LL% &
transactionTypeLL& 5
)LL5 6
)LL6 7
transactionsQueryMM !
=MM" #
transactionsQueryMM$ 5
.MM5 6
WhereMM6 ;
(MM; <
tMM< =
=>MM> @
tMMA B
.MMB C
TransactionTypeMMC R
==MMS U
transactionTypeMMV e
)MMe f
;MMf g
ifOO 
(OO 
!OO 
stringOO 
.OO 
IsNullOrEmptyOO %
(OO% &
yearOO& *
.OO* +
ToStringOO+ 3
(OO3 4
)OO4 5
)OO5 6
)OO6 7
{PP 
transactionsQueryQQ !
=QQ" #
transactionsQueryQQ$ 5
.QQ5 6
WhereQQ6 ;
(QQ; <
tQQ< =
=>QQ> @
tQQA B
.QQB C
TransactionDateQQC R
.QQR S
YearQQS W
>=QQX Z
yearQQ[ _
)QQ_ `
;QQ` a
}RR 
transactionsQueryUU 
=UU 
transactionsQueryUU  1
.UU1 2
OrderByDescendingUU2 C
(UUC D
tUUD E
=>UUF H
tUUI J
.UUJ K
TransactionDateUUK Z
)UUZ [
;UU[ \
varXX 
transactionsXX 
=XX 
transactionsQueryXX 0
.XX0 1
SelectXX1 7
(XX7 8
tXX8 9
=>XX: <
newXX= @'
CustomerTransactionsReadDtoXXA \
{YY 
VoucherNumberZZ 
=ZZ 
tZZ  !
.ZZ! "
VoucherNumberZZ" /
,ZZ/ 0
CustomerCode[[ 
=[[ 
t[[  
.[[  !
CustomerCode[[! -
,[[- .
PropertyNumber\\ 
=\\  
t\\! "
.\\" #
PropertyNumber\\# 1
,\\1 2
TransactionDate]] 
=]]  !
t]]" #
.]]# $
TransactionDate]]$ 3
,]]3 4
ChequeNumber^^ 
=^^ 
t^^  
.^^  !
ChequeNumber^^! -
,^^- .
ReferenceNumber__ 
=__  !
t__" #
.__# $
ReferenceNumber__$ 3
,__3 4
	Narration`` 
=`` 
t`` 
.`` 
	Narration`` '
,``' (
Amountaa 
=aa 
taa 
.aa 
Amountaa !
,aa! "
PaymentMethodbb 
=bb 
stringbb  &
.bb& '
IsNullOrEmptybb' 4
(bb4 5
tbb5 6
.bb6 7
ChequeNumberbb7 C
)bbC D
?cc 
(cc 
!cc 
stringcc 
.cc 
IsNullOrEmptycc ,
(cc, -
tcc- .
.cc. /
ReferenceNumbercc/ >
)cc> ?
?cc@ A
$strccB M
:ccN O
$strccP V
)ccV W
:dd 
$strdd 
,dd 
VoucherTypeee 
=ee 
tee 
.ee  
VoucherTypeee  +
,ee+ ,
TransactionTypeff 
=ff  !
tff" #
.ff# $
TransactionTypeff$ 3
}gg 
)gg 
.gg 
ToListgg 
(gg 
)gg 
;gg 
returnii 
transactionsii 
!ii  
;ii  !
}ll 	
}rr 
}ss ˝e
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerPaymentsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class #
CustomerPaymentsService %
:% &$
ICustomerPaymentsService' ?
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private		 
readonly		 
IMapper		  
_mapper		! (
;		( )
public #
CustomerPaymentsService &
(& '
IUnitOfWork' 2

unitOfWork3 =
,= >
IMapper? F
mapperG M
)M N
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
GenericResponseDto ,
>, -(
AddNewCustomerPaymentDetails. J
(J K
CustomerPaymentsDtoK ^
values_ e
)e f
{ 	
CustomerPayments 
payments %
=& '
CustomerPayments( 8
.8 9
AddPaymentDetails9 J
(J K
valuesK Q
.Q R
ReceiptNumberR _
,_ `
valuesa g
.g h
PropertyNumberh v
,v w
valuesx ~
.~ 
CustomerCode	 ã
,
ã å
values
ç ì
.
ì î
CustomerName
î †
,
† °
values
¢ ®
.
® ©
DateOfPayment
© ∂
,
∂ ∑
values
∏ æ
.
æ ø
PaymentMode
ø  
,
  À
values
Ã “
.
“ ”
PaymentType
” ﬁ
!
ﬁ ﬂ
,
ﬂ ‡
values
· Á
.
Á Ë
InvoiceCurrency
Ë ˜
!
˜ ¯
,
¯ ˘
values
˙ Ä
.
Ä Å
PaymentCurrency
Å ê
!
ê ë
,
ë í
values
ì ô
.
ô ö
Amount
ö †
,
† °
valuesK Q
.Q R

AmountPaidR \
,\ ]
values^ d
.d e
IssuingBanke p
!p q
,q r
valuess y
.y z
IssuingBranch	z á
!
á à
,
à â
values
â è
.
è ê
ReceivingBank
ê ù
!
ù û
,
û ü
values
ü •
.
• ¶
ProcessingBranch
¶ ∂
!
∂ ∑
,
∑ ∏
values
∏ æ
.
æ ø
ReceivingBranch
ø Œ
!
Œ œ
,
œ –
values
– ÷
.
÷ ◊
PayPoint
◊ ﬂ
!
ﬂ ‡
,
‡ ·
values
· Á
.
Á Ë
ChequeNumber
Ë Ù
!
Ù ı
,
ı ˆ
values
ˆ ¸
.
¸ ˝
ReferenceNumber
˝ å
!
å ç
,
ç é
values
é î
.
î ï
	PayeeName
ï û
,
û ü
valuesK Q
.Q R
	NarrationR [
,[ \
values\ b
.b c
InvoiceNumberc p
,p q
valuesr x
.x y
InvoiceItemId	y Ü
,
Ü á
values
à é
.
é è
Cashier
è ñ
)
ñ ó
;
ó ò
_unitOfWork 
. 
CustomerPayment '
.' (
Insert( .
(. /
payments/ 7
)7 8
;8 9
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
GenericResponseDto )
{* +
response, 4
=5 6
$str7 <
}= >
;> ?
} 	
public   
async   
Task   
<   
IEnumerable   %
<  % &
CustomerPaymentsDto  & 9
>  9 :
>  : ;"
CustomerPaymentDetails  < R
(  R S
string  S Y
?  Y Z
customerCode  [ g
,  g h
string  h n
propertyNumber  o }
,  } ~
string	   Ö
?
  Ö Ü
receiptNumber
  á î
,
  î ï
string
  ñ ú
paymentMode
  ù ®
,
  ® ©
int
  ™ ≠
?
  ≠ Æ
paymentYear
  Ø ∫
)
  ∫ ª
{!! 	
var$$ 
transactionsQuery$$ !
=$$" #
($$$ %
await$$% *
_unitOfWork$$+ 6
.$$6 7
CustomerPayment$$7 F
.$$F G
GetAll$$G M
($$M N
)$$N O
)$$O P
.$$P Q
AsQueryable$$Q \
($$\ ]
)$$] ^
;$$^ _
if&& 
(&& 
!&& 
string&& 
.&& 
IsNullOrEmpty&& %
(&&% &
customerCode&&& 2
)&&2 3
)&&3 4
transactionsQuery'' !
=''" #
transactionsQuery''$ 5
.''5 6
Where''6 ;
(''; <
t''< =
=>''> @
t''A B
.''B C
CustomerCode''C O
==''P R
customerCode''S _
)''_ `
;''` a
if)) 
()) 
!)) 
string)) 
.)) 
IsNullOrEmpty)) %
())% &
propertyNumber))& 4
)))4 5
)))5 6
transactionsQuery** !
=**" #
transactionsQuery**$ 5
.**5 6
Where**6 ;
(**; <
t**< =
=>**> @
t**A B
.**B C
PropertyNumber**C Q
==**R T
propertyNumber**U c
)**c d
;**d e
if,, 
(,, 
!,, 
string,, 
.,, 
IsNullOrEmpty,, %
(,,% &
receiptNumber,,& 3
),,3 4
),,4 5
transactionsQuery-- !
=--" #
transactionsQuery--$ 5
.--5 6
Where--6 ;
(--; <
t--< =
=>--> @
t--A B
.--B C
ReceiptNumber--C P
!--P Q
.--Q R
Contains--R Z
(--Z [
receiptNumber--[ h
)--h i
)--i j
;--j k
if// 
(// 
!// 
string// 
.// 
IsNullOrEmpty// %
(//% &
paymentMode//& 1
)//1 2
)//2 3
transactionsQuery00 !
=00" #
transactionsQuery00$ 5
.005 6
Where006 ;
(00; <
t00< =
=>00> @
t00A B
.00B C
PaymentMode00C N
==00O Q
paymentMode00R ]
)00] ^
;00^ _
if22 
(22 
!22 
string22 
.22 
IsNullOrEmpty22 %
(22% &
paymentYear22& 1
.221 2
ToString222 :
(22: ;
)22; <
)22< =
)22= >
transactionsQuery33 !
=33" #
transactionsQuery33$ 5
.335 6
Where336 ;
(33; <
t33< =
=>33> @
t33A B
.33B C
DateOfPayment33C P
.33P Q
Year33Q U
>=33V X
paymentYear33Y d
)33d e
;33e f
transactionsQuery55 
=55 
transactionsQuery55  1
.551 2
OrderByDescending552 C
(55C D
t55D E
=>55F H
t55I J
.55J K
DateOfPayment55K X
)55X Y
;55Y Z
return88 
_mapper88 
.88 
Map88 
<88 
IEnumerable88 *
<88* +
CustomerPaymentsDto88+ >
>88> ?
>88? @
(88@ A
transactionsQuery88A R
.88R S
ToList88S Y
(88Y Z
)88Z [
)88[ \
;88\ ]
}99 	
public== 
async== 
Task== 
<== 
IEnumerable== %
<==% &&
CustomerPaymentsSummaryDto==& @
>==@ A
>==A B"
CustomerPaymentSummary==C Y
(==Y Z
string==Z `
?==` a
customerCode==b n
,==n o
string==p v
?==v w
propertyNumber	==x Ü
,
==Ü á
string
==à é
?
==é è
receiptNumber
==ê ù
,
==ù û
string
==ü •
paymentMode
==¶ ±
,
==± ≤
int
==≥ ∂
?
==∂ ∑
paymentYear
==∏ √
)
==√ ƒ
{>> 	
var?? 
transactionsQuery?? !
=??" #
(??$ %
await??% *
_unitOfWork??+ 6
.??6 7
CustomerPayment??7 F
.??F G
GetAll??G M
(??M N
)??N O
)??O P
.??P Q
AsQueryable??Q \
(??\ ]
)??] ^
;??^ _
ifBB 
(BB 
!BB 
stringBB 
.BB 
IsNullOrEmptyBB %
(BB% &
customerCodeBB& 2
)BB2 3
)BB3 4
transactionsQueryCC !
=CC" #
transactionsQueryCC$ 5
.CC5 6
WhereCC6 ;
(CC; <
tCC< =
=>CC> @
tCCA B
.CCB C
CustomerCodeCCC O
==CCP R
customerCodeCCS _
)CC_ `
;CC` a
ifEE 
(EE 
!EE 
stringEE 
.EE 
IsNullOrEmptyEE %
(EE% &
propertyNumberEE& 4
)EE4 5
)EE5 6
transactionsQueryFF !
=FF" #
transactionsQueryFF$ 5
.FF5 6
WhereFF6 ;
(FF; <
tFF< =
=>FF> @
tFFA B
.FFB C
PropertyNumberFFC Q
==FFR T
propertyNumberFFU c
)FFc d
;FFd e
ifHH 
(HH 
!HH 
stringHH 
.HH 
IsNullOrEmptyHH %
(HH% &
receiptNumberHH& 3
)HH3 4
)HH4 5
transactionsQueryII !
=II" #
transactionsQueryII$ 5
.II5 6
WhereII6 ;
(II; <
tII< =
=>II> @
tIIA B
.IIB C
ReceiptNumberIIC P
==IIQ S
receiptNumberIIT a
)IIa b
;IIb c
ifKK 
(KK 
!KK 
stringKK 
.KK 
IsNullOrEmptyKK %
(KK% &
paymentModeKK& 1
)KK1 2
)KK2 3
transactionsQueryLL !
=LL" #
transactionsQueryLL$ 5
.LL5 6
WhereLL6 ;
(LL; <
tLL< =
=>LL> @
tLLA B
.LLB C
PaymentModeLLC N
==LLO Q
paymentModeLLR ]
)LL^ _
;LL_ `
ifNN 
(NN 
!NN 
stringNN 
.NN 
IsNullOrEmptyNN %
(NN% &
paymentYearNN& 1
.NN1 2
ToStringNN2 :
(NN: ;
)NN; <
)NN< =
)NN= >
transactionsQueryOO !
=OO" #
transactionsQueryOO$ 5
.OO5 6
WhereOO6 ;
(OO; <
tOO< =
=>OO> @
tOOA B
.OOB C
DateOfPaymentOOC P
.OOP Q
YearOOQ U
>=OOV X
paymentYearOOY d
)OOd e
;OOe f
transactionsQueryRR 
=RR 
transactionsQueryRR  1
.RR1 2
OrderByDescendingRR2 C
(RRC D
tRRD E
=>RRF H
tRRI J
.RRJ K
DateOfPaymentRRK X
)RRX Y
;RRY Z
varUU 
customerPaymentsUU  
=UU! "
transactionsQueryUU# 4
.UU4 5
SelectUU5 ;
(UU; <
pUU< =
=>UU> @
newUUA D&
CustomerPaymentsSummaryDtoUUE _
{VV 
ReceiptNumberWW 
=WW 
pWW  !
.WW! "
ReceiptNumberWW" /
!WW/ 0
,WW0 1
	NarrationXX 
=XX 
pXX 
.XX 
	NarrationXX '
!XX' (
,XX( )
DateOfPaymentYY 
=YY 
pYY  !
.YY! "
DateOfPaymentYY" /
,YY/ 0
PaymentModeZZ 
=ZZ 
pZZ 
.ZZ  
PaymentModeZZ  +
!ZZ+ ,
,ZZ, -
PaymentCurrency[[ 
=[[  !
p[[" #
.[[# $
PaymentCurrency[[$ 3
,[[3 4

AmountPaid\\ 
=\\ 
p\\ 
.\\ 

AmountPaid\\ )
,\\) *
ChequeNumber]] 
=]] 
p]]  
.]]  !
ChequeNumber]]! -
}^^ 
)^^ 
.^^ 
ToList^^ 
(^^ 
)^^ 
;^^ 
return`` 
customerPayments`` #
!``# $
;``$ %
}bb 	
}ll 
}mm æÑ
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerInvoiceService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class "
CustomerInvoiceService $
:% &#
ICustomerInvoiceService' >
{		 
private

 
readonly

 
IUnitOfWork

 $
_unitOfWork

% 0
;

0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public "
CustomerInvoiceService %
(% &
IUnitOfWork& 1

unitOfWork2 <
,< =
IMapper> E
mapperF L
)L M
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
GenericResponseDto ,
>, -%
AddCustomerInvoiceDetails. G
(G H
CustomerInvoiceDtoH Z
values[ a
)a b
{ 	
CustomerInvoice 
invoices $
=% &
CustomerInvoice' 6
.6 7
AddInvoiceDetails7 H
(H I
valuesI O
.O P
InvoiceNumberP ]
,] ^
values_ e
.e f
InvoiceDatef q
,q r
valuess y
.y z
PropertyNumber	z à
,
à â
values
ä ê
.
ê ë
Acreage
ë ò
,
ò ô
values
ö †
.
† °
TransactionCode
° ∞
,
∞ ±
values
≤ ∏
.
∏ π
TransactionNumber
π  
,
  À
values
Ã “
.
“ ”
ExpirationDate
” ·
,
· ‚
values
„ È
.
È Í
CustomerCode
Í ˆ
,
ˆ ˜
values
¯ ˛
.
˛ ˇ
CustomerName
ˇ ã
,
ã å
valuesI O
.O P
CustomerAddressP _
,_ `
valuesa g
.g h 
CustomerEmailAddressh |
,| }
values	~ Ñ
.
Ñ Ö!
CustomerPhoneNumber
Ö ò
,
ò ô
values
ö †
.
† °
InvoiceAmount
° Æ
,
Æ Ø
values
∞ ∂
.
∂ ∑

AmountPaid
∑ ¡
,
¡ ¬
values
√ …
.
…  

BalanceDue
  ‘
,
‘ ’
values
÷ ‹
.
‹ ›
InvoiceStatus
› Í
!
Í Î
)
Î Ï
;
Ï Ì
_unitOfWork 
. 
CustomerInvoice '
.' (
Insert( .
(. /
invoices/ 7
)7 8
;8 9
int 
counter 
= 
$num 
; 
foreach 
( 
var 
item 
in  
values! '
.' (
InvoiceItems( 4
)4 5
{  
CustomerInvoiceItems $
invoiceItems% 1
=2 3 
CustomerInvoiceItems4 H
.H I
AddInvoiceItemsI X
(X Y
counterY `
,` a
valuesa g
.g h
InvoiceNumberh u
,u v
itemv z
.z {
Description	{ Ü
,
Ü á
item
á ã
.
ã å
Amount
å í
,
í ì
item
ì ó
.
ó ò

AmountPaid
ò ¢
,
¢ £
item
£ ß
.
ß ®

BalanceDue
® ≤
,
≤ ≥
item
≥ ∑
.
∑ ∏
Status
∏ æ
!
æ ø
)
ø ¿
;
¿ ¡
_unitOfWork 
.  
CustomerInvoiceItems 0
.0 1
Insert1 7
(7 8
invoiceItems8 D
)D E
;E F
}   
await## 
_unitOfWork## 
.## 
Complete## &
(##& '
)##' (
;##( )
return%% 
new%% 
GenericResponseDto%% )
{%%* +
response%%, 4
=%%5 6
$str%%7 <
}%%= >
;%%> ?
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
CustomerInvoiceDto))& 8
>))8 9
>))9 :"
CustomerInvoiceDetails)); Q
())Q R
string))R X
invoiceNumber))Y f
,))f g
string))h n
customerCode))o {
,)){ |
string	))} É
propertyNumber
))Ñ í
,
))í ì
string
))î ö
status
))õ °
,
))° ¢
int
))£ ¶
year
))ß ´
)
))´ ¨
{** 	
var,, 
query,, 
=,, 
from,, 
invoice,, $
in,,% '
await,,( -
_unitOfWork,,. 9
.,,9 :
CustomerInvoice,,: I
.,,I J
GetAll,,J P
(,,P Q
),,Q R
join-- 
items-- "
in--# %
await--& +
_unitOfWork--, 7
.--7 8 
CustomerInvoiceItems--8 L
.--L M
GetAll--M S
(--S T
)--T U
on.. 
invoice.. &
...& '
InvoiceNumber..' 4
equals..5 ;
items..< A
...A B
InvoiceNumber..B O
into..P T
invoiceItems..U a
select// 
new// "
CustomerInvoiceDto//# 5
{00 
InvoiceNumber11 )
=11* +
invoice11, 3
.113 4
InvoiceNumber114 A
!11A B
,11B C
InvoiceDate22 '
=22( )
invoice22* 1
.221 2
InvoiceDate222 =
,22= >
PropertyNumber33 *
=33+ ,
invoice33- 4
.334 5
PropertyNumber335 C
!33C D
,33D E
Acreage44 #
=44$ %
invoice44& -
.44- .
Acreage44. 5
,445 6
TransactionCode55 +
=55, -
invoice55. 5
.555 6
TransactionCode556 E
,55E F
TransactionNumber66 -
=66. /
invoice660 7
.667 8
TransactionNumber668 I
,66I J
ExpirationDate77 *
=77+ ,
invoice77- 4
.774 5
ExpirationDate775 C
,77C D
CustomerCode88 (
=88) *
invoice88+ 2
.882 3
CustomerCode883 ?
!88? @
,88@ A
CustomerName99 (
=99) *
invoice99+ 2
.992 3
CustomerName993 ?
,99? @
CustomerAddress:: +
=::, -
invoice::. 5
.::5 6
CustomerAddress::6 E
,::E F 
CustomerEmailAddress;; 0
=;;1 2
invoice;;3 :
.;;: ; 
CustomerEmailAddress;;; O
,;;O P
CustomerPhoneNumber<< /
=<<0 1
invoice<<2 9
.<<9 :
CustomerPhoneNumber<<: M
,<<M N
InvoiceAmount== )
===* +
invoice==, 3
.==3 4
InvoiceAmount==4 A
,==A B

AmountPaid>> &
=>>' (
invoice>>) 0
.>>0 1

AmountPaid>>1 ;
,>>; <

BalanceDue?? &
=??' (
invoice??) 0
.??0 1

BalanceDue??1 ;
,??; <
InvoiceStatus@@ )
=@@* +
invoice@@, 3
.@@3 4
InvoiceStatus@@4 A
,@@A B
InvoiceItemsAA (
=AA) *
invoiceItemsAA+ 7
.AA7 8
SelectAA8 >
(AA> ?
itemAA? C
=>AAD F
newAAG J#
CustomerInvoiceItemsDtoAAK b
{BB 
DescriptionCC  +
=CC, -
itemCC. 2
.CC2 3
DescriptionCC3 >
!CC> ?
,CC? @
AmountDD  &
=DD' (
itemDD) -
.DD- .
AmountDD. 4
,DD4 5
StatusEE  &
=EE' (
itemEE) -
.EE- .
StatusEE. 4
,EE4 5

AmountPaidFF  *
=FF+ ,
itemFF- 1
.FF1 2

AmountPaidFF2 <
,FF< =

BalanceDueGG  *
=GG+ ,
itemGG- 1
.GG1 2

BalanceDueGG2 <
}HH 
)HH 
.HH 
ToListHH %
(HH% &
)HH& '
}II 
;II 
ifLL 
(LL 
!LL 
stringLL 
.LL 
IsNullOrEmptyLL %
(LL% &
invoiceNumberLL& 3
)LL3 4
)LL4 5
queryMM 
=MM 
queryMM 
.MM 
WhereMM #
(MM# $
iMM$ %
=>MM& (
iMM) *
.MM* +
InvoiceNumberMM+ 8
==MM9 ;
invoiceNumberMM< I
)MMI J
;MMJ K
ifOO 
(OO 
!OO 
stringOO 
.OO 
IsNullOrEmptyOO %
(OO% &
customerCodeOO& 2
)OO2 3
)OO3 4
queryPP 
=PP 
queryPP 
.PP 
WherePP #
(PP# $
iPP$ %
=>PP& (
iPP) *
.PP* +
CustomerCodePP+ 7
==PP8 :
customerCodePP; G
)PPG H
;PPH I
ifRR 
(RR 
!RR 
stringRR 
.RR 
IsNullOrEmptyRR %
(RR% &
statusRR& ,
)RR, -
)RR- .
querySS 
=SS 
querySS 
.SS 
WhereSS #
(SS# $
iSS$ %
=>SS& (
iSS) *
.SS* +
InvoiceStatusSS+ 8
==SS9 ;
statusSS< B
)SSB C
;SSC D
ifUU 
(UU 
!UU 
stringUU 
.UU 
IsNullOrEmptyUU %
(UU% &
yearUU& *
.UU* +
ToStringUU+ 3
(UU3 4
)UU4 5
)UU5 6
)UU6 7
queryVV 
=VV 
queryVV 
.VV 
WhereVV #
(VV# $
iVV$ %
=>VV& (
iVV) *
.VV* +
InvoiceDateVV+ 6
.VV6 7
YearVV7 ;
>=VV< >
yearVV? C
)VVC D
;VVD E
returnYY 
queryYY 
.YY 
ToListYY 
(YY  
)YY  !
;YY! "
}[[ 	
public]] 
async]] 
Task]] 
<]] 
IEnumerable]] %
<]]% &)
CustomerInvoiceSummaryReadDto]]& C
>]]C D
>]]D E"
CustomerInvoiceSummary]]F \
(]]\ ]
string]]] c
invoiceNumber]]d q
,]]q r
string]]s y
customerCode	]]z Ü
,
]]Ü á
string
]]à é
propertyNumber
]]è ù
,
]]ù û
string
]]ü •
status
]]¶ ¨
,
]]¨ ≠
int
]]Æ ±
year
]]≤ ∂
)
]]∂ ∑
{^^ 	
var`` 
invoiceItemsQuery`` !
=``" #
(``$ %
from``% )
a``* +
in``, .
await``/ 4
_unitOfWork``5 @
.``@ A 
CustomerInvoiceItems``A U
.``U V
GetAll``V \
(``\ ]
)``] ^
joinaa$ (
baa) *
inaa+ -
awaitaa. 3
_unitOfWorkaa4 ?
.aa? @
CustomerInvoiceaa@ O
.aaO P
GetAllaaP V
(aaV W
)aaW X
onbb$ &
abb' (
.bb( )
InvoiceNumberbb) 6
equalsbb7 =
bbb> ?
.bb? @
InvoiceNumberbb@ M
orderbycc$ +
bcc, -
.cc- .
InvoiceDatecc. 9

descendingcc: D
selectdd$ *
newdd+ .%
CustomerInvoiceSummaryDtodd/ H
{ee$ %
InvoiceNumberff( 5
=ff6 7
$"ff8 :
{ff: ;
aff; <
.ff< =
InvoiceNumberff= J
}ffJ K
$strffK N
{ffN O
affO P
.ffP Q
InvoiceItemsIdffQ _
}ff_ `
"ff` a
,ffa b
InvoiceDescriptiongg( :
=gg; <
agg= >
.gg> ?
Descriptiongg? J
!ggJ K
,ggK L
CustomerCodehh( 4
=hh5 6
bhh7 8
.hh8 9
CustomerCodehh9 E
,hhE F
PropertyNumberii( 6
=ii7 8
bii9 :
.ii: ;
PropertyNumberii; I
,iiI J
InvoiceAmountjj( 5
=jj6 7
ajj8 9
.jj9 :
Amountjj: @
,jj@ A
InvoiceStatuskk( 5
=kk6 7
akk8 9
.kk9 :
Statuskk: @
,kk@ A
InvoiceDatell( 3
=ll4 5
bll6 7
.ll7 8
InvoiceDatell8 C
}mm$ %
)mm% &
.mm& '
AsQueryablemm' 2
(mm2 3
)mm3 4
;mm4 5
ifoo 
(oo 
!oo 
stringoo 
.oo 
IsNullOrEmptyoo %
(oo% &
invoiceNumberoo& 3
)oo3 4
)oo4 5
invoiceItemsQuerypp !
=pp" #
invoiceItemsQuerypp$ 5
.pp5 6
Wherepp6 ;
(pp; <
tpp< =
=>pp> @
tppA B
.ppB C
InvoiceNumberppC P
.ppP Q
ContainsppQ Y
(ppY Z
invoiceNumberppZ g
)ppg h
)pph i
;ppi j
ifrr 
(rr 
!rr 
stringrr 
.rr 
IsNullOrEmptyrr %
(rr% &
customerCoderr& 2
)rr2 3
)rr3 4
invoiceItemsQueryss !
=ss" #
invoiceItemsQueryss$ 5
.ss5 6
Wheress6 ;
(ss; <
tss< =
=>ss> @
tssA B
.ssB C
CustomerCodessC O
==ssP R
customerCodessS _
)ss_ `
;ss` a
ifuu 
(uu 
!uu 
stringuu 
.uu 
IsNullOrEmptyuu %
(uu% &
propertyNumberuu& 4
)uu4 5
)uu5 6
invoiceItemsQueryvv !
=vv" #
invoiceItemsQueryvv$ 5
.vv5 6
Wherevv6 ;
(vv; <
tvv< =
=>vv> @
tvvA B
.vvB C
PropertyNumbervvC Q
==vvR T
propertyNumbervvU c
)vvc d
;vvd e
ifxx 
(xx 
!xx 
stringxx 
.xx 
IsNullOrEmptyxx %
(xx% &
statusxx& ,
)xx, -
)xx- .
invoiceItemsQueryyy !
=yy" #
invoiceItemsQueryyy$ 5
.yy5 6
Whereyy6 ;
(yy; <
tyy< =
=>yy> @
tyyA B
.yyB C
InvoiceStatusyyC P
==yyQ S
statusyyT Z
)yyZ [
;yy[ \
if|| 
(|| 
!|| 
string|| 
.|| 
IsNullOrEmpty|| %
(||% &
year||& *
.||* +
ToString||+ 3
(||3 4
)||4 5
)||5 6
)||6 7
invoiceItemsQuery}} !
=}}" #
invoiceItemsQuery}}$ 5
.}}5 6
Where}}6 ;
(}}; <
t}}< =
=>}}> @
t}}A B
.}}B C
InvoiceDate}}C N
.}}N O
Year}}O S
>=}}T V
year}}W [
)}}[ \
;}}\ ]
invoiceItemsQuery
ÄÄ 
=
ÄÄ 
invoiceItemsQuery
ÄÄ  1
.
ÄÄ1 2
OrderByDescending
ÄÄ2 C
(
ÄÄC D
t
ÄÄD E
=>
ÄÄF H
t
ÄÄI J
.
ÄÄJ K
InvoiceDate
ÄÄK V
)
ÄÄV W
;
ÄÄW X
return
ÇÇ 
_mapper
ÇÇ 
.
ÇÇ 
Map
ÇÇ 
<
ÇÇ 
IEnumerable
ÇÇ *
<
ÇÇ* ++
CustomerInvoiceSummaryReadDto
ÇÇ+ H
>
ÇÇH I
>
ÇÇI J
(
ÇÇJ K
invoiceItemsQuery
ÇÇK \
.
ÇÇ\ ]
ToList
ÇÇ] c
(
ÇÇc d
)
ÇÇd e
)
ÇÇe f
;
ÇÇf g
}
ÑÑ 	
public
ÜÜ 
Task
ÜÜ 
<
ÜÜ 
IEnumerable
ÜÜ 
<
ÜÜ  +
CustomerInvoiceSummaryReadDto
ÜÜ  =
>
ÜÜ= >
>
ÜÜ> ?$
CustomerInvoiceSummary
ÜÜ@ V
(
ÜÜV W
string
ÜÜW ]
invoiceNumber
ÜÜ^ k
,
ÜÜk l
string
ÜÜm s
customerCodeÜÜt Ä
,ÜÜÄ Å
stringÜÜÇ à
propertyNumberÜÜâ ó
,ÜÜó ò
stringÜÜô ü
statusÜÜ† ¶
,ÜÜ¶ ß
intÜÜ® ´
?ÜÜ´ ¨
yearÜÜ≠ ±
)ÜÜ± ≤
{
áá 	
throw
àà 
new
àà %
NotImplementedException
àà -
(
àà- .
)
àà. /
;
àà/ 0
}
ââ 	
}
ää 
}ãã ®
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerInvoiceItemsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class '
CustomerInvoiceItemsService )
{ 
public '
CustomerInvoiceItemsService	 $
($ %
)% &
{ 
} 
}		 
}

 ™"
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerDetailsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
UseCases( 0
{ 
public 
class "
CustomerDetailsService $
:% &#
ICustomerDetailsService' >
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private		 
readonly		 
IMapper		  
_mapper		! (
;		( )
public "
CustomerDetailsService %
(% &
IUnitOfWork& 1

unitOfWork2 <
,< =
IMapper> E
mapperF L
)L M
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
GenericResponseDto ,
>, -!
AddNewCustomerDetails. C
(C D
CustomerDetailsDtoD V
valuesW ]
)] ^
{ 	
CustomerDetails 
customer $
=% &
CustomerDetails' 6
.6 7
AddCustomerDetails7 I
(I J
$numJ K
,K L
valuesM S
.S T
CustomerTypeT `
,` a
valuesb h
.h i
ResidentTypei u
,u v
valuesw }
.} ~
Locality	~ Ü
,
Ü á
values
à é
.
é è
CustomerCode
è õ
,
õ ú
values
ù £
.
£ §
CustomerName
§ ∞
,
∞ ±
values
≤ ∏
.
∏ π
Picture
π ¿
!
¿ ¡
,
¡ ¬
values
√ …
.
…  
Gender
  –
!
– —
,
— “
values
” Ÿ
.
Ÿ ⁄
Nationality
⁄ Â
!
Â Ê
,
Ê Á
values
Ë Ó
.
Ó Ô
PostalAddress
Ô ¸
!
¸ ˝
,
˝ ˛
values
ˇ Ö
.
Ö Ü 
ResidentialAddress
Ü ò
!
ò ô
,
ô ö
valuesJ P
.P Q
DigitalAddressQ _
!_ `
,` a
valuesb h
.h i
PrimaryMobileNumberi |
,| }
values	~ Ñ
.
Ñ Ö#
SecondaryMobileNumber
Ö ö
!
ö õ
,
õ ú
values
ù £
.
£ §
OfficeNumber
§ ∞
!
∞ ±
,
± ≤
values
≥ π
.
π ∫
WhatsAppNumber
∫ »
!
» …
,
…  
values
À —
.
— “
EmailAddress
“ ﬁ
,
ﬁ ﬂ
values
‡ Ê
.
Ê Á
SocialMediaType
Á ˆ
!
ˆ ˜
,
˜ ¯
values
˘ ˇ
.
ˇ Ä 
SocialMediaAccount
Ä í
!
í ì
)
ì î
;
î ï
_unitOfWork 
. 
CustomerDetails '
.' (
Insert( .
(. /
customer/ 7
)7 8
;8 9
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
GenericResponseDto )
{* +
response, 4
=5 6
$str7 <
}= >
;> ?
} 	
public 
Task 
< 
GenericResponseDto &
>& '!
DeleteCustomerDetails( =
(= >
string> D
customerCodeE Q
)Q R
{ 	
throw   
new   #
NotImplementedException   -
(  - .
)  . /
;  / 0
}!! 	
public## 
Task## 
<## 
GenericResponseDto## &
>##& '!
UpdateCustomerDetails##( =
(##= >
CustomerDetailsDto##> P
values##Q W
)##W X
{$$ 	
throw%% 
new%% #
NotImplementedException%% -
(%%- .
)%%. /
;%%/ 0
}&& 	
}'' 
}(( £
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/PropertyDetailsProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class "
PropertyDetailsProfile $
:% &
Profile' .
{ 
public "
PropertyDetailsProfile	 
(  
)  !
{ 
	CreateMap 
< 
PropertyDetails %
,% &"
PropertyDetailsReadDto' =
>= >
(> ?
)? @
;@ A
	CreateMap		 
<		 $
PropertyDetailsCreateDto		 .
,		. /
PropertyDetails		0 ?
>		? @
(		@ A
)		A B
;		B C
}

 	
} 
} º
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerTransactionsProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class '
CustomerTransactionsProfile )
:* +
Profile, 3
{ 
public '
CustomerTransactionsProfile	 $
($ %
)% &
{		 
	CreateMap

 
<

  
CustomerTransactions

 *
,

* +#
CustomerTransactionsDto

, C
>

C D
(

D E
)

E F
;

F G
	CreateMap 
< #
CustomerTransactionsDto -
,- . 
CustomerTransactions/ C
>C D
(D E
)E F
;F G
} 	
} 
} †
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerPaymentsProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class #
CustomerPaymentsProfile %
:& '
Profile( /
{ 
public #
CustomerPaymentsProfile	  
(  !
)! "
{		 
	CreateMap

 
<

 
CustomerPayments

 &
,

& '
CustomerPaymentsDto

( ;
>

; <
(

< =
)

= >
;

> ?
	CreateMap 
< 
CustomerPaymentsDto )
,) *
CustomerPayments+ ;
>; <
(< =
)= >
;> ?
} 	
} 
} ü

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerInvoiceProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class "
CustomerInvoiceProfile $
:% &
Profile' .
{ 
public "
CustomerInvoiceProfile	 
(  
)  !
{		 
	CreateMap

 
<

 
CustomerInvoice

 %
,

% &
CustomerInvoiceDto

' 9
>

9 :
(

: ;
)

; <
;

< =
	CreateMap 
< 
CustomerInvoiceDto (
,( )
CustomerInvoice* 9
>9 :
(: ;
); <
;< =
	CreateMap 
< %
CustomerInvoiceSummaryDto /
,/ 0)
CustomerInvoiceSummaryReadDto1 N
>N O
(O P
)P Q
;Q R
	CreateMap 
< )
CustomerInvoiceSummaryReadDto 3
,3 4%
CustomerInvoiceSummaryDto5 N
>N O
(O P
)P Q
;Q R
} 	
} 
} º
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerInvoiceItemsProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class '
CustomerInvoiceItemsProfile )
:* +
Profile, 3
{ 
public '
CustomerInvoiceItemsProfile	 $
($ %
)% &
{		 
	CreateMap

 
<

  
CustomerInvoiceItems

 *
,

* +#
CustomerInvoiceItemsDto

, C
>

C D
(

D E
)

E F
;

F G
	CreateMap 
< #
CustomerInvoiceItemsDto -
,- . 
CustomerInvoiceItems/ C
>C D
(D E
)E F
;F G
} 	
} 
} £
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerDetailsProfile.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Profiles( 0
{ 
public 
class "
CustomerDetailsProfile $
:% &
Profile' .
{ 
public "
CustomerDetailsProfile	 
(  
)  !
{ 
	CreateMap		 
<		 
CustomerDetails		 %
,		% &"
CustomerDetailsReadDto		' =
>		= >
(		> ?
)		? @
;		@ A
	CreateMap

 
<

 $
CustomerDetailsCreateDto

 .
,

. /
CustomerDetails

0 ?
>

? @
(

@ A
)

A B
;

B C
} 	
} 
} æ
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/Services/IAzureBlobService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
.2 3
Services3 ;
{ 
public 
	interface 
IAzureBlobService #
{ 
Task 
< 
Uri 
> 
UploadFileBlobAsync %
(% &
string& ,
blobContainerName- >
,> ?
Stream@ F
contentG N
,N O
stringP V
contentTypeW b
,b c
stringd j
fileNamek s
)s t
;t u
Task 
< 
string 
> 
DeleteFileBlobAsync (
(( )
string) /
blobContainerName0 A
,A B
stringC I
fileNameJ R
)R S
;S T
} 
}		 ˆ
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/IPropertyDetailsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface #
IPropertyDetailsService )
{ 
Task 
< 
GenericResponseDto 
>  !
AddNewPropertyDetails! 6
(6 7
PropertyDetailsDto7 I
valuesJ P
)P Q
;Q R
Task		 
<		 
GenericResponseDto		 
>		  !
UpdatePropertyDetails		! 6
(		6 7
PropertyDetailsDto		7 I
values		J P
)		P Q
;		Q R
Task

 
<

 
GenericResponseDto

 
>

  !
DeletePropertyDetails

! 6
(

6 7
string

7 =
value

> C
)

C D
;

D E
Task 
< 
IEnumerable 
< (
PropertySummaryMobileViewDto 5
>5 6
>6 7$
GetPropertySummaryMobile8 P
(P Q
stringQ W
customerCodeX d
)d e
;e f
Task 
< 
IEnumerable 
< %
PropertySummaryWebViewDto 2
>2 3
>3 4!
GetPropertySummaryWeb5 J
(J K
stringK Q
customerCodeR ^
)^ _
;_ `
Task 
< "
PropertyDetailsReadDto #
># $
GetPropertyDetails% 7
(7 8
string8 >
propertyNumber? M
)M N
;N O
Task 
< 
IEnumerable 
< +
AvailablePropertySummaryViewDto 8
>8 9
>9 :&
AvailablePropertiesSummary; U
(U V
)V W
;W X
} 
} Ñ
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerTransactionsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface (
ICustomerTransactionsService .
{ 
Task 
< 
GenericResponseDto 
>  ,
 AddNewCustomerTransactionDetails! A
(A B#
CustomerTransactionsDtoB Y
valuesZ `
)` a
;a b
Task 
< 
IEnumerable 
< '
CustomerTransactionsReadDto 4
>4 5
>5 6&
CustomerTransactionDetails7 Q
(Q R
stringR X
customerCodeY e
,e f
stringg m
propertyNumbern |
)| }
;} ~
Task

 
<

 
IEnumerable

 
<

 '
CustomerTransactionsReadDto

 4
>

4 5
>

5 6
CustomerStatement

7 H
(

H I
string

I O
customerCode

P \
,

\ ]
string

^ d
propertyNumber

e s
,

s t
string

u {%
receipt_or_invoiceNumber	

| î
,


î ï
string


ñ ú
transactionType


ù ¨
,


¨ ≠
int


Æ ±
year


≤ ∂
)


∂ ∑
;


∑ ∏
} 
} ô
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerPaymentsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface $
ICustomerPaymentsService *
{ 
Task 
< 
GenericResponseDto 
>  (
AddNewCustomerPaymentDetails! =
(= >
CustomerPaymentsDto> Q
valuesR X
)X Y
;Y Z
Task 
< 
IEnumerable 
< 
CustomerPaymentsDto ,
>, -
>- ."
CustomerPaymentDetails/ E
(E F
stringF L
?L M
customerCodeN Z
,Z [
string\ b
propertyNumberc q
,q r
strings y
?y z
receiptNumber	{ à
,
à â
string
ä ê
paymentMode
ë ú
,
ú ù
int
û °
?
° ¢
paymentYear
£ Æ
)
Æ Ø
;
Ø ∞
Task 
< 
IEnumerable 
< &
CustomerPaymentsSummaryDto 3
>3 4
>4 5"
CustomerPaymentSummary6 L
(L M
stringM S
?S T
customerCodeU a
,a b
stringc i
?i j
propertyNumberk y
,y z
string	{ Å
?
Å Ç
receiptNumber
É ê
,
ê ë
string
í ò
paymentMode
ô §
,
§ •
int
¶ ©
?
© ™
paymentYear
´ ∂
)
∂ ∑
;
∑ ∏
} 
} é
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerInvoiceService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface #
ICustomerInvoiceService )
{ 
Task 
< 
GenericResponseDto 
>  %
AddCustomerInvoiceDetails! :
(: ;
CustomerInvoiceDto; M
valuesN T
)T U
;U V
Task 
< 
IEnumerable 
< )
CustomerInvoiceSummaryReadDto 6
>6 7
>7 8"
CustomerInvoiceSummary9 O
(O P
stringP V
invoiceNumberW d
,d e
stringf l
customerCodem y
,y z
string	{ Å
propertyNumber
Ç ê
,
ê ë
string
í ò
status
ô ü
,
ü †
int
° §
year
• ©
)
© ™
;
™ ´
Task

 
<

 
IEnumerable

 
<

 
CustomerInvoiceDto

 +
>

+ ,
>

, -"
CustomerInvoiceDetails

. D
(

D E
string

E K
invoiceNumber

L Y
,

Y Z
string

[ a
customerCode

b n
,

n o
string

p v
propertyNumber	

w Ö
,


Ö Ü
string


á ç
status


é î
,


î ï
int


ñ ô
year


ö û
)


û ü
;


ü †
} 
} π
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerInvoiceItemsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface (
ICustomerInvoiceItemsService .
{ 
} 
} •
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerDetailsService.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (

Interfaces( 2
{ 
public 
	interface #
ICustomerDetailsService )
{ 
Task 
< 
GenericResponseDto 
>  !
AddNewCustomerDetails! 6
(6 7
CustomerDetailsDto7 I
valuesJ P
)P Q
;Q R
Task		 
<		 
GenericResponseDto		 
>		  !
UpdateCustomerDetails		! 6
(		6 7
CustomerDetailsDto		7 I
values		J P
)		P Q
;		Q R
Task

 
<

 
GenericResponseDto

 
>

  !
DeleteCustomerDetails

! 6
(

6 7
string

7 =
customerCode

> J
)

J K
;

K L
} 
} Ñ	
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertySummaryMobileViewDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
record (
PropertySummaryMobileViewDto +
{ 
public 
string 
? 
Image 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
? 
LandUse 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string	 
? 
PropertyNumber 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
double			 
Balance		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
} 
} ®

ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertySummaryWebViewDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
record %
PropertySummaryWebViewDto (
{ 
public 
string 
? 
LandUse 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
? 
Address 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 
string		 
?		 
Image		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public

 
double

 
Balance

 
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
} 
} ÷S
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertyDetailsReadDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
class "
PropertyDetailsReadDto $
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
required		 
string		 
PropertyNumber		 -
{		. /
get		0 3
;		3 4
set		5 8
;		8 9
}		: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
Locality '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
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
string 
LandUse &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUseType *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
AllocationType -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BlockNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public   
required   
string   

PlotNumber   )
{  * +
get  , /
;  / 0
set  1 4
;  4 5
}  6 7
public"" 
double"" 

AcreageOne""  
{""! "
get""# &
;""& '
set""( +
;""+ ,
}""- .
public$$ 
double$$ 

AcreageTwo$$  
{$$! "
get$$# &
;$$& '
set$$( +
;$$+ ,
}$$- .
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
PropertyHeight'' %
{''& '
get''( +
;''+ ,
set''- 0
;''0 1
}''2 3
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** 
PlotSize** 
{**  !
get**" %
;**% &
set**' *
;*** +
}**, -
public,, 
required,, 
double,, 
SellingPrice,, +
{,,, -
get,,. 1
;,,1 2
set,,3 6
;,,6 7
},,8 9
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
required// 
string// 
Currency// '
{//( )
get//* -
;//- .
set/// 2
;//2 3
}//4 5
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22 

RentalType22 !
{22" #
get22$ '
;22' (
set22) ,
;22, -
}22. /
public44 
int44 
TotalNumberOfRooms44 %
{44& '
get44( +
;44+ ,
set44- 0
;440 1
}442 3
public66 
int66 
RoomsOccupied66  
{66! "
get66# &
;66& '
set66( +
;66+ ,
}66- .
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
ApartmentType99 $
{99% &
get99' *
;99* +
set99, /
;99/ 0
}991 2
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 

SchemeType<< !
{<<" #
get<<$ '
;<<' (
set<<) ,
;<<, -
}<<. /
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
???  
ApartmentBlockNumber?? +
{??, -
get??. 1
;??1 2
set??3 6
;??6 7
}??8 9
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 
	BlockTypeBB  
{BB! "
getBB# &
;BB& '
setBB( +
;BB+ ,
}BB- .
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
FloorNumberEE "
{EE# $
getEE% (
;EE( )
setEE* -
;EE- .
}EE/ 0
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
	BlockUnitHH  
{HH! "
getHH# &
;HH& '
setHH( +
;HH+ ,
}HH- .
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
	BlockSideKK  
{KK! "
getKK# &
;KK& '
setKK( +
;KK+ ,
}KK- .
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
	FloorAreaNN  
{NN! "
getNN# &
;NN& '
setNN( +
;NN+ ,
}NN- .
publicPP 
intPP 

RoomNumberPP 
{PP 
getPP  #
;PP# $
setPP% (
;PP( )
}PP* +
publicRR 
DateTimeRR 
RightOfEntryRR $
{RR% &
getRR' *
;RR* +
setRR, /
;RR/ 0
}RR1 2
publicTT 
intTT 
	LeaseTermTT 
{TT 
getTT "
;TT" #
setTT$ '
;TT' (
}TT) *
publicVV 
DateTimeVV 
LeaseExpiryDateVV '
{VV( )
getVV* -
;VV- .
setVV/ 2
;VV2 3
}VV4 5
[XX 	
StringLengthXX	 
(XX 
$numXX 
)XX 
]XX 
publicYY 
stringYY 
?YY 
CustomerCodeYY #
{YY$ %
getYY& )
;YY) *
setYY+ .
;YY. /
}YY0 1
[[[ 	
StringLength[[	 
([[ 
$num[[ 
)[[ 
][[ 
public\\ 
string\\ 
?\\ 
SitePlanNumber\\ %
{\\& '
get\\( +
;\\+ ,
set\\- 0
;\\0 1
}\\2 3
[^^ 	
StringLength^^	 
(^^ 
$num^^ 
)^^ 
]^^ 
public__ 
string__ 
?__ 
CadastralPlanNumber__ *
{__+ ,
get__- 0
;__0 1
set__2 5
;__5 6
}__7 8
[aa 	
StringLengthaa	 
(aa 
$numaa 
)aa 
]aa 
publicbb 
stringbb 
?bb 
CoordinateOnebb $
{bb% &
getbb' *
;bb* +
setbb, /
;bb/ 0
}bb1 2
[dd 	
StringLengthdd	 
(dd 
$numdd 
)dd 
]dd 
publicee 
stringee 
?ee 
CoordinateTwoee $
{ee% &
getee' *
;ee* +
setee, /
;ee/ 0
}ee1 2
[gg 	
StringLengthgg	 
(gg 
$numgg 
)gg 
]gg 
publichh 
stringhh 
?hh 
CoordinateThreehh &
{hh' (
gethh) ,
;hh, -
sethh. 1
;hh1 2
}hh3 4
[jj 	
StringLengthjj	 
(jj 
$numjj 
)jj 
]jj 
publickk 
stringkk 
?kk 
CoordinateFourkk %
{kk& '
getkk( +
;kk+ ,
setkk- 0
;kk0 1
}kk2 3
[mm 	
StringLengthmm	 
(mm 
$nummm 
)mm 
]mm 
publicnn 
stringnn 
?nn 
CoordinateFivenn %
{nn& '
getnn( +
;nn+ ,
setnn- 0
;nn0 1
}nn2 3
[pp 	
StringLengthpp	 
(pp 
$numpp 
)pp 
]pp 
publicqq 
stringqq 
?qq 
CoordinateSixqq $
{qq% &
getqq' *
;qq* +
setqq, /
;qq/ 0
}qq1 2
publicss 
stringss 
[ss 
]ss 
?ss 
PropertyImagesss '
{ss( )
getss* -
;ss- .
setss/ 2
;ss2 3
}ss4 5
publicuu 
booluu 
IsLargeScaleuu  
{uu! "
getuu# &
;uu& '
setuu( +
;uu+ ,
}uu- .
publicww 
stringww 
?ww 
Addressww 
{ww  
getww! $
;ww$ %
setww& )
;ww) *
}ww+ ,
}xx 
}yy Î`
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertyDetailsDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
record 
PropertyDetailsDto !
{ 
public 
int 
PropertyMasterId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
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
public 
required 
string 
PropertyNumber -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
Locality '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUse &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUseType *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
AllocationType -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BlockNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
[!! 	
StringLength!!	 
(!! 
$num!! 
)!! 
]!! 
public"" 
required"" 
string"" 

PlotNumber"" )
{""* +
get"", /
;""/ 0
set""1 4
;""4 5
}""6 7
public$$ 
double$$ 

AcreageOne$$  
{$$! "
get$$# &
;$$& '
set$$( +
;$$+ ,
}$$- .
public&& 
double&& 

AcreageTwo&&  
{&&! "
get&&# &
;&&& '
set&&( +
;&&+ ,
}&&- .
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
string)) 
?)) 
PropertyHeight)) %
{))& '
get))( +
;))+ ,
set))- 0
;))0 1
}))2 3
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
string,, 
?,, 
PlotSize,, 
{,,  !
get,," %
;,,% &
set,,' *
;,,* +
},,, -
public.. 
required.. 
double.. 
SellingPrice.. +
{.., -
get... 1
;..1 2
set..3 6
;..6 7
}..8 9
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
required11 
string11 
Currency11 '
{11( )
get11* -
;11- .
set11/ 2
;112 3
}114 5
[33 	
StringLength33	 
(33 
$num33 
)33 
]33 
public44 
string44 
?44 

RentalType44 !
{44" #
get44$ '
;44' (
set44) ,
;44, -
}44. /
public66 
int66 
TotalNumberOfRooms66 %
{66& '
get66( +
;66+ ,
set66- 0
;660 1
}662 3
public88 
int88 
RoomsOccupied88  
{88! "
get88# &
;88& '
set88( +
;88+ ,
}88- .
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
ApartmentType;; $
{;;% &
get;;' *
;;;* +
set;;, /
;;;/ 0
};;1 2
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 

SchemeType>> !
{>>" #
get>>$ '
;>>' (
set>>) ,
;>>, -
}>>. /
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA  
ApartmentBlockNumberAA +
{AA, -
getAA. 1
;AA1 2
setAA3 6
;AA6 7
}AA8 9
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
stringDD 
?DD 
	BlockTypeDD  
{DD! "
getDD# &
;DD& '
setDD( +
;DD+ ,
}DD- .
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG 
FloorNumberGG "
{GG# $
getGG% (
;GG( )
setGG* -
;GG- .
}GG/ 0
[II 	
StringLengthII	 
(II 
$numII 
)II 
]II 
publicJJ 
stringJJ 
?JJ 
	BlockUnitJJ  
{JJ! "
getJJ# &
;JJ& '
setJJ( +
;JJ+ ,
}JJ- .
[LL 	
StringLengthLL	 
(LL 
$numLL 
)LL 
]LL 
publicMM 
stringMM 
?MM 
	BlockSideMM  
{MM! "
getMM# &
;MM& '
setMM( +
;MM+ ,
}MM- .
[OO 	
StringLengthOO	 
(OO 
$numOO 
)OO 
]OO 
publicPP 
stringPP 
?PP 
	FloorAreaPP  
{PP! "
getPP# &
;PP& '
setPP( +
;PP+ ,
}PP- .
publicRR 
intRR 

RoomNumberRR 
{RR 
getRR  #
;RR# $
setRR% (
;RR( )
}RR* +
publicTT 
DateTimeTT 
RightOfEntryTT $
{TT% &
getTT' *
;TT* +
setTT, /
;TT/ 0
}TT1 2
publicVV 
intVV 
	LeaseTermVV 
{VV 
getVV "
;VV" #
setVV$ '
;VV' (
}VV) *
publicXX 
DateTimeXX 
LeaseExpiryDateXX '
{XX( )
getXX* -
;XX- .
setXX/ 2
;XX2 3
}XX4 5
[ZZ 	
StringLengthZZ	 
(ZZ 
$numZZ 
)ZZ 
]ZZ 
public[[ 
string[[ 
?[[ 
CustomerCode[[ #
{[[$ %
get[[& )
;[[) *
set[[+ .
;[[. /
}[[0 1
[]] 	
StringLength]]	 
(]] 
$num]] 
)]] 
]]] 
public^^ 
string^^ 
?^^ 
SitePlanNumber^^ %
{^^& '
get^^( +
;^^+ ,
set^^- 0
;^^0 1
}^^2 3
[`` 	
StringLength``	 
(`` 
$num`` 
)`` 
]`` 
publicaa 
stringaa 
?aa 
CadastralPlanNumberaa *
{aa+ ,
getaa- 0
;aa0 1
setaa2 5
;aa5 6
}aa7 8
[cc 	
StringLengthcc	 
(cc 
$numcc 
)cc 
]cc 
publicdd 
stringdd 
?dd 
CoordinateOnedd $
{dd% &
getdd' *
;dd* +
setdd, /
;dd/ 0
}dd1 2
[ff 	
StringLengthff	 
(ff 
$numff 
)ff 
]ff 
publicgg 
stringgg 
?gg 
CoordinateTwogg $
{gg% &
getgg' *
;gg* +
setgg, /
;gg/ 0
}gg1 2
[ii 	
StringLengthii	 
(ii 
$numii 
)ii 
]ii 
publicjj 
stringjj 
?jj 
CoordinateThreejj &
{jj' (
getjj) ,
;jj, -
setjj. 1
;jj1 2
}jj3 4
[ll 	
StringLengthll	 
(ll 
$numll 
)ll 
]ll 
publicmm 
stringmm 
?mm 
CoordinateFourmm %
{mm& '
getmm( +
;mm+ ,
setmm- 0
;mm0 1
}mm2 3
[oo 	
StringLengthoo	 
(oo 
$numoo 
)oo 
]oo 
publicpp 
stringpp 
?pp 
CoordinateFivepp %
{pp& '
getpp( +
;pp+ ,
setpp- 0
;pp0 1
}pp2 3
[rr 	
StringLengthrr	 
(rr 
$numrr 
)rr 
]rr 
publicss 
stringss 
?ss 
CoordinateSixss $
{ss% &
getss' *
;ss* +
setss, /
;ss/ 0
}ss1 2
publicuu 
PropertyImagesuu 
[uu 
]uu 
?uu  
PropertyImagesuu! /
{uu0 1
getuu2 5
;uu5 6
setuu7 :
;uu: ;
}uu< =
publicww 
boolww 
IsLargeScaleww  
{ww! "
getww# &
;ww& '
setww( +
;ww+ ,
}ww- .
}xx 
public}} 

record}} 
PropertyImages}}  
{~~ 
[ 	
Required	 
] 
[
ÄÄ 	
StringLength
ÄÄ	 
(
ÄÄ 
$num
ÄÄ 
)
ÄÄ 
]
ÄÄ 
public
ÅÅ 
string
ÅÅ 
?
ÅÅ 
ImageOne
ÅÅ 
{
ÅÅ  !
get
ÅÅ" %
;
ÅÅ% &
set
ÅÅ' *
;
ÅÅ* +
}
ÅÅ, -
[
ÉÉ 	
StringLength
ÉÉ	 
(
ÉÉ 
$num
ÉÉ 
)
ÉÉ 
]
ÉÉ 
public
ÑÑ 
string
ÑÑ 
?
ÑÑ 
ImageTwo
ÑÑ 
{
ÑÑ  !
get
ÑÑ" %
;
ÑÑ% &
set
ÑÑ' *
;
ÑÑ* +
}
ÑÑ, -
[
ÜÜ 	
StringLength
ÜÜ	 
(
ÜÜ 
$num
ÜÜ 
)
ÜÜ 
]
ÜÜ 
public
áá 
string
áá 
?
áá 

ImageThree
áá !
{
áá" #
get
áá$ '
;
áá' (
set
áá) ,
;
áá, -
}
áá. /
[
ââ 	
StringLength
ââ	 
(
ââ 
$num
ââ 
)
ââ 
]
ââ 
public
ää 
string
ää 
?
ää 
	ImageFour
ää  
{
ää! "
get
ää# &
;
ää& '
set
ää( +
;
ää+ ,
}
ää- .
[
åå 	
StringLength
åå	 
(
åå 
$num
åå 
)
åå 
]
åå 
public
çç 
string
çç 
?
çç 
	ImageFive
çç  
{
çç! "
get
çç# &
;
çç& '
set
çç( +
;
çç+ ,
}
çç- .
}
éé 
}èè ·P
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/PropertyDetailsCreateDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
class $
PropertyDetailsCreateDto &
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
required		 
string		 
PropertyNumber		 -
{		. /
get		0 3
;		3 4
set		5 8
;		8 9
}		: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
Locality '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
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
string 
LandUse &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUseType *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
AllocationType -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BlockNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public   
required   
string   

PlotNumber   )
{  * +
get  , /
;  / 0
set  1 4
;  4 5
}  6 7
public"" 
double"" 

AcreageOne""  
{""! "
get""# &
;""& '
set""( +
;""+ ,
}""- .
public$$ 
double$$ 

AcreageTwo$$  
{$$! "
get$$# &
;$$& '
set$$( +
;$$+ ,
}$$- .
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
PropertyHeight'' %
{''& '
get''( +
;''+ ,
set''- 0
;''0 1
}''2 3
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** 
PlotSize** 
{**  !
get**" %
;**% &
set**' *
;*** +
}**, -
public,, 
required,, 
double,, 
SellingPrice,, +
{,,, -
get,,. 1
;,,1 2
set,,3 6
;,,6 7
},,8 9
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
required// 
string// 
Currency// '
{//( )
get//* -
;//- .
set/// 2
;//2 3
}//4 5
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22 

RentalType22 !
{22" #
get22$ '
;22' (
set22) ,
;22, -
}22. /
public44 
int44 
TotalNumberOfRooms44 %
{44& '
get44( +
;44+ ,
set44- 0
;440 1
}442 3
public66 
int66 
RoomsOccupied66  
{66! "
get66# &
;66& '
set66( +
;66+ ,
}66- .
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
ApartmentType99 $
{99% &
get99' *
;99* +
set99, /
;99/ 0
}991 2
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 

SchemeType<< !
{<<" #
get<<$ '
;<<' (
set<<) ,
;<<, -
}<<. /
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
???  
ApartmentBlockNumber?? +
{??, -
get??. 1
;??1 2
set??3 6
;??6 7
}??8 9
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 
	BlockTypeBB  
{BB! "
getBB# &
;BB& '
setBB( +
;BB+ ,
}BB- .
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
FloorNumberEE "
{EE# $
getEE% (
;EE( )
setEE* -
;EE- .
}EE/ 0
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
	BlockUnitHH  
{HH! "
getHH# &
;HH& '
setHH( +
;HH+ ,
}HH- .
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
	BlockSideKK  
{KK! "
getKK# &
;KK& '
setKK( +
;KK+ ,
}KK- .
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
	FloorAreaNN  
{NN! "
getNN# &
;NN& '
setNN( +
;NN+ ,
}NN- .
publicPP 
intPP 

RoomNumberPP 
{PP 
getPP  #
;PP# $
setPP% (
;PP( )
}PP* +
publicRR 
DateTimeRR 
RightOfEntryRR $
{RR% &
getRR' *
;RR* +
setRR, /
;RR/ 0
}RR1 2
publicTT 
intTT 
	LeaseTermTT 
{TT 
getTT "
;TT" #
setTT$ '
;TT' (
}TT) *
publicVV 
DateTimeVV 
LeaseExpiryDateVV '
{VV( )
getVV* -
;VV- .
setVV/ 2
;VV2 3
}VV4 5
[XX 	
StringLengthXX	 
(XX 
$numXX 
)XX 
]XX 
publicYY 
stringYY 
?YY 
CustomerCodeYY #
{YY$ %
getYY& )
;YY) *
setYY+ .
;YY. /
}YY0 1
[[[ 	
StringLength[[	 
([[ 
$num[[ 
)[[ 
][[ 
public\\ 
string\\ 
?\\ 
SitePlanNumber\\ %
{\\& '
get\\( +
;\\+ ,
set\\- 0
;\\0 1
}\\2 3
[^^ 	
StringLength^^	 
(^^ 
$num^^ 
)^^ 
]^^ 
public__ 
string__ 
?__ 
CadastralPlanNumber__ *
{__+ ,
get__- 0
;__0 1
set__2 5
;__5 6
}__7 8
[aa 	
StringLengthaa	 
(aa 
$numaa 
)aa 
]aa 
publicbb 
stringbb 
?bb 
CoordinateOnebb $
{bb% &
getbb' *
;bb* +
setbb, /
;bb/ 0
}bb1 2
[dd 	
StringLengthdd	 
(dd 
$numdd 
)dd 
]dd 
publicee 
stringee 
?ee 
CoordinateTwoee $
{ee% &
getee' *
;ee* +
setee, /
;ee/ 0
}ee1 2
[gg 	
StringLengthgg	 
(gg 
$numgg 
)gg 
]gg 
publichh 
stringhh 
?hh 
CoordinateThreehh &
{hh' (
gethh) ,
;hh, -
sethh. 1
;hh1 2
}hh3 4
[jj 	
StringLengthjj	 
(jj 
$numjj 
)jj 
]jj 
publickk 
stringkk 
?kk 
CoordinateFourkk %
{kk& '
getkk( +
;kk+ ,
setkk- 0
;kk0 1
}kk2 3
[mm 	
StringLengthmm	 
(mm 
$nummm 
)mm 
]mm 
publicnn 
stringnn 
?nn 
CoordinateFivenn %
{nn& '
getnn( +
;nn+ ,
setnn- 0
;nn0 1
}nn2 3
[pp 	
StringLengthpp	 
(pp 
$numpp 
)pp 
]pp 
publicqq 
stringqq 
?qq 
CoordinateSixqq $
{qq% &
getqq' *
;qq* +
setqq, /
;qq/ 0
}qq1 2
publicss 
boolss 
IsLargeScaless  
{ss! "
getss# &
;ss& '
setss( +
;ss+ ,
}ss- .
}tt 
}uu ‰
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/PropertyDetails/AvailablePropertySummaryViewDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
PropertyDetails- <
{ 
public 
record +
AvailablePropertySummaryViewDto .
{ 
public 
string 
? 
LandUse 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
? 
Address 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 
string		 
?		 
Image		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public

 
string

 
?

 
Currency

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
double 
SellingPrice "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} ¿
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/GenericResponseDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
{ 
public 
record 
GenericResponseDto !
{ 
public 
string	 
? 
response 
{ 
get 
;  
set! $
;$ %
}& '
} 
} ¸0
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerTransactionsDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
{ 
public 
record #
CustomerTransactionsDto &
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
required		 
string		 
VoucherNumber		 ,
{		- .
get		/ 2
;		2 3
set		4 7
;		7 8
}		9 :
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyNumber -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
Required	 
] 
public 
required 
DateTime  
TransactionDate! 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ReferenceNumber &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ChequeNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
	Narration (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
required 
double 
Amount %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
required 
int 
AccountCode '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[!! 	
StringLength!!	 
(!! 
$num!! 
)!! 
]!! 
public"" 
required"" 
string"" 
TransactionType"" .
{""/ 0
get""1 4
;""4 5
set""6 9
;""9 :
}""; <
[$$ 	
StringLength$$	 
($$ 
$num$$ 
)$$ 
]$$ 
public%% 
required%% 
string%% 
VoucherType%% *
{%%+ ,
get%%- 0
;%%0 1
set%%2 5
;%%5 6
}%%7 8
}&& 
public)) 

record)) '
CustomerTransactionsReadDto)) -
{** 
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
required,, 
string,, 
VoucherNumber,, ,
{,,- .
get,,/ 2
;,,2 3
set,,4 7
;,,7 8
},,9 :
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
required// 
string// 
PropertyNumber// -
{//. /
get//0 3
;//3 4
set//5 8
;//8 9
}//: ;
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
required22 
string22 
CustomerCode22 +
{22, -
get22. 1
;221 2
set223 6
;226 7
}228 9
[44 	
Required44	 
]44 
public55 
required55 
DateTime55  
TransactionDate55! 0
{551 2
get553 6
;556 7
set558 ;
;55; <
}55= >
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 
ReferenceNumber88 &
{88' (
get88) ,
;88, -
set88. 1
;881 2
}883 4
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
$num== 
)== 
]== 
public>> 
required>> 
string>> 
	Narration>> (
{>>) *
get>>+ .
;>>. /
set>>0 3
;>>3 4
}>>5 6
public@@ 
required@@ 
double@@ 
Amount@@ %
{@@& '
get@@( +
;@@+ ,
set@@- 0
;@@0 1
}@@2 3
publicBB 
stringBB 
?BB 
PaymentMethodBB $
{BB% &
getBB' *
;BB* +
setBB, /
;BB/ 0
}BB1 2
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
requiredEE 
stringEE 
TransactionTypeEE .
{EE/ 0
getEE1 4
;EE4 5
setEE6 9
;EE9 :
}EE; <
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
requiredHH 
stringHH 
VoucherTypeHH *
{HH+ ,
getHH- 0
;HH0 1
setHH2 5
;HH5 6
}HH7 8
}II 
}MM ¸8
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerPaymentsDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
{ 
public 
record 
CustomerPaymentsDto "
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
required		 
string		 
ReceiptNumber		 ,
{		- .
get		/ 2
;		2 3
set		4 7
;		7 8
}		9 :
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyNumber -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
CustomerName +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
required 
DateTime  
DateOfPayment! .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
required 
string 
PaymentMode *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
string 
? 
PaymentType "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 
InvoiceCurrency &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
? 
PaymentCurrency &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
required 
double 
Amount %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public   
required   
double   

AmountPaid   )
{  * +
get  , /
;  / 0
set  1 4
;  4 5
}  6 7
public"" 
string"" 
?"" 
IssuingBank"" "
{""# $
get""% (
;""( )
set""* -
;""- .
}""/ 0
public$$ 
string$$ 
?$$ 
IssuingBranch$$ $
{$$% &
get$$' *
;$$* +
set$$, /
;$$/ 0
}$$1 2
public&& 
string&& 
?&& 
ReceivingBank&& $
{&&% &
get&&' *
;&&* +
set&&, /
;&&/ 0
}&&1 2
public(( 
string(( 
?(( 
ProcessingBranch(( '
{((( )
get((* -
;((- .
set((/ 2
;((2 3
}((4 5
public** 
string** 
?** 
ReceivingBranch** &
{**' (
get**) ,
;**, -
set**. 1
;**1 2
}**3 4
public,, 
string,, 
?,, 
PayPoint,, 
{,,  !
get,," %
;,,% &
set,,' *
;,,* +
},,, -
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// 
ChequeNumber// #
{//$ %
get//& )
;//) *
set//+ .
;//. /
}//0 1
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22 
ReferenceNumber22 &
{22' (
get22) ,
;22, -
set22. 1
;221 2
}223 4
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
required55 
string55 
	PayeeName55 (
{55) *
get55+ .
;55. /
set550 3
;553 4
}555 6
[77 	
Required77	 
]77 
public88 
required88 
string88 
	Narration88 (
{88) *
get88+ .
;88. /
set880 3
;883 4
}885 6
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
required;; 
string;; 
InvoiceNumber;; ,
{;;- .
get;;/ 2
;;;2 3
set;;4 7
;;;7 8
};;9 :
public== 
int== 
InvoiceItemId==  
{==! "
get==# &
;==& '
set==( +
;==+ ,
}==- .
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
public@@ 
required@@ 
string@@ 
Cashier@@ &
{@@' (
get@@) ,
;@@, -
set@@. 1
;@@1 2
}@@3 4
}AA 
publicCC 

recordCC &
CustomerPaymentsSummaryDtoCC ,
{DD 
[EE 	
StringLengthEE	 
(EE 
$numEE 
)EE 
]EE 
publicFF 
requiredFF 
stringFF 
ReceiptNumberFF ,
{FF- .
getFF/ 2
;FF2 3
setFF4 7
;FF7 8
}FF9 :
[HH 	
RequiredHH	 
]HH 
publicII 
requiredII 
stringII 
	NarrationII (
{II) *
getII+ .
;II. /
setII0 3
;II3 4
}II5 6
publicKK 
requiredKK 
DateTimeKK  
DateOfPaymentKK! .
{KK/ 0
getKK1 4
;KK4 5
setKK6 9
;KK9 :
}KK; <
publicMM 
requiredMM 
stringMM 
PaymentModeMM *
{MM+ ,
getMM- 0
;MM0 1
setMM2 5
;MM5 6
}MM7 8
publicOO 
stringOO 
?OO 
PaymentCurrencyOO &
{OO' (
getOO) ,
;OO, -
setOO. 1
;OO1 2
}OO3 4
publicQQ 
requiredQQ 
doubleQQ 

AmountPaidQQ )
{QQ* +
getQQ, /
;QQ/ 0
setQQ1 4
;QQ4 5
}QQ6 7
[SS 	
StringLengthSS	 
(SS 
$numSS 
)SS 
]SS 
publicTT 
stringTT 
?TT 
ChequeNumberTT #
{TT$ %
getTT& )
;TT) *
setTT+ .
;TT. /
}TT0 1
}VV 
}XX È	
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerInvoiceItemsDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
{ 
public 
record #
CustomerInvoiceItemsDto &
{ 
public 
required 
string 
Description *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
required 
double 
Amount %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
double 

AmountPaid  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
double		 

BalanceDue		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
public

 
string

 
?

 
Status

 
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
} 
} ·4
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerInvoiceDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
{ 
public 
record 
CustomerInvoiceDto !
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
required		 
string		 
InvoiceNumber		 ,
{		- .
get		/ 2
;		2 3
set		4 7
;		7 8
}		9 :
public 
DateTime 
InvoiceDate #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
PropertyNumber -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
double 
Acreage 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
TransactionCode &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
? 
TransactionNumber (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
required 
DateTime  
ExpirationDate! /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
string 
? 
CustomerName #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
CustomerAddress &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
?  
CustomerEmailAddress +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public!! 
string!! 
?!! 
CustomerPhoneNumber!! *
{!!+ ,
get!!- 0
;!!0 1
set!!2 5
;!!5 6
}!!7 8
public## 
required## 
double## 
InvoiceAmount## ,
{##- .
get##/ 2
;##2 3
set##4 7
;##7 8
}##9 :
public%% 
double%% 

AmountPaid%%  
{%%! "
get%%# &
;%%& '
set%%( +
;%%+ ,
}%%- .
public'' 
double'' 

BalanceDue''  
{''! "
get''# &
;''& '
set''( +
;''+ ,
}''- .
public)) 
string)) 
?)) 
InvoiceStatus)) $
{))% &
get))' *
;))* +
set)), /
;))/ 0
}))1 2
public++ 
required++ 
IEnumerable++ #
<++# $#
CustomerInvoiceItemsDto++$ ;
>++; <
InvoiceItems++= I
{++J K
get++L O
;++O P
set++Q T
;++T U
}++V W
},, 
public// 

record// %
CustomerInvoiceSummaryDto// +
{00 
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
required22 
string22 
InvoiceNumber22 ,
{22- .
get22/ 2
;222 3
set224 7
;227 8
}229 :
public44 
DateTime44 
InvoiceDate44 #
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
string77 
?77 
CustomerCode77 $
{77% &
get77' *
;77* +
set77, /
;77/ 0
}771 2
[99 	
StringLength99	 
(99 
$num99 
)99 
]99 
public:: 
string:: 
?:: 
PropertyNumber:: %
{::& '
get::( +
;::+ ,
set::- 0
;::0 1
}::2 3
[<< 	
StringLength<<	 
(<< 
$num<< 
)<< 
]<< 
public== 
required== 
string== 
InvoiceDescription== 1
{==2 3
get==4 7
;==7 8
set==9 <
;==< =
}==> ?
public?? 
required?? 
double?? 
InvoiceAmount?? ,
{??- .
get??/ 2
;??2 3
set??4 7
;??7 8
}??9 :
publicAA 
stringAA 
?AA 
InvoiceStatusAA $
{AA% &
getAA' *
;AA* +
setAA, /
;AA/ 0
}AA1 2
}CC 
publicEE 

recordEE )
CustomerInvoiceSummaryReadDtoEE /
{FF 
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
requiredHH 
stringHH 
InvoiceNumberHH ,
{HH- .
getHH/ 2
;HH2 3
setHH4 7
;HH7 8
}HH9 :
publicJJ 
DateTimeJJ 
InvoiceDateJJ #
{JJ$ %
getJJ& )
;JJ) *
setJJ+ .
;JJ. /
}JJ0 1
[LL 	
StringLengthLL	 
(LL 
$numLL 
)LL 
]LL 
publicMM 
requiredMM 
stringMM 
InvoiceDescriptionMM 1
{MM2 3
getMM4 7
;MM7 8
setMM9 <
;MM< =
}MM> ?
publicOO 
requiredOO 
doubleOO 
InvoiceAmountOO ,
{OO- .
getOO/ 2
;OO2 3
setOO4 7
;OO7 8
}OO9 :
publicQQ 
stringQQ 
?QQ 
InvoiceStatusQQ $
{QQ% &
getQQ' *
;QQ* +
setQQ, /
;QQ/ 0
}QQ1 2
}SS 
}TT Ù
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerDetails/CustomerDetailsReadDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
CustomerDetails- <
{ 
public 

record "
CustomerDetailsReadDto (
{ 
public 
string 
? 
CustomerType #
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
 
?

 
ResidentType

 #
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
0 1
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
CustomerName #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
Picture 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
Gender 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
Nationality "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 
PostalAddress $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
? 
ResidentialAddress )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
string 
? 
DigitalAddress %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
? 
PrimaryMobileNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public   
string   
?   !
SecondaryMobileNumber   ,
{  - .
get  / 2
;  2 3
set  4 7
;  7 8
}  9 :
public"" 
string"" 
?"" 
OfficeNumber"" #
{""$ %
get""& )
;"") *
set""+ .
;"". /
}""0 1
public$$ 
string$$ 
?$$ 
WhatsAppNumber$$ %
{$$& '
get$$( +
;$$+ ,
set$$- 0
;$$0 1
}$$2 3
[&& 	
EmailAddress&&	 
]&& 
public'' 
string'' 
?'' 
EmailAddress'' #
{''$ %
get''& )
;'') *
set''+ .
;''. /
}''0 1
public)) 
string)) 
?)) 
SocialMediaType)) &
{))' (
get))) ,
;)), -
set)). 1
;))1 2
}))3 4
public++ 
string++ 
?++ 
SocialMediaAccount++ )
{++* +
get++, /
;++/ 0
set++1 4
;++4 5
}++6 7
},, 
}-- ≠%
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerDetails/CustomerDetailsDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
CustomerDetails- <
{ 
public 

record 
CustomerDetailsDto $
{ 
public 
required 
string 
CustomerType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public

 
required

 
string

 
ResidentType

 +
{

, -
get

. 1
;

1 2
set

3 6
;

6 7
}

8 9
public 
required 
string 
Locality '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
required 
string 
CustomerName +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Picture 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
Gender 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
Nationality "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PostalAddress $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ResidentialAddress )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
[ 	
StringLength	 
( 
$num 
) 
] 
public   
string   
?   
DigitalAddress   %
{  & '
get  ( +
;  + ,
set  - 0
;  0 1
}  2 3
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
required## 
string## 
PrimaryMobileNumber## 2
{##3 4
get##5 8
;##8 9
set##: =
;##= >
}##? @
[%% 	
StringLength%%	 
(%% 
$num%% 
)%% 
]%% 
public&& 
string&& 
?&& !
SecondaryMobileNumber&& ,
{&&- .
get&&/ 2
;&&2 3
set&&4 7
;&&7 8
}&&9 :
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
string)) 
?)) 
OfficeNumber)) #
{))$ %
get))& )
;))) *
set))+ .
;)). /
}))0 1
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
string,, 
?,, 
WhatsAppNumber,, %
{,,& '
get,,( +
;,,+ ,
set,,- 0
;,,0 1
},,2 3
[.. 	
EmailAddress..	 
].. 
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
required00 
string00 
EmailAddress00 +
{00, -
get00. 1
;001 2
set003 6
;006 7
}008 9
public22 
string22 
?22 
SocialMediaType22 &
{22' (
get22) ,
;22, -
set22. 1
;221 2
}223 4
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
SocialMediaAccount55 )
{55* +
get55, /
;55/ 0
set551 4
;554 5
}556 7
}66 
}77 π%
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerDetails/CustomerDetailsCreateDto.cs
	namespace 	
Modules
 
. 
	Customers 
. 
Application '
.' (
Dtos( ,
., -
CustomerDetails- <
{ 
public 

record $
CustomerDetailsCreateDto *
{ 
public 
required 
string 
CustomerType +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public

 
required

 
string

 
ResidentType

 +
{

, -
get

. 1
;

1 2
set

3 6
;

6 7
}

8 9
public 
required 
string 
Locality '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
required 
string 
CustomerCode +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
required 
string 
CustomerName +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Picture 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
Gender 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
Nationality "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PostalAddress $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ResidentialAddress )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
[ 	
StringLength	 
( 
$num 
) 
] 
public   
string   
?   
DigitalAddress   %
{  & '
get  ( +
;  + ,
set  - 0
;  0 1
}  2 3
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
required## 
string## 
PrimaryMobileNumber## 2
{##3 4
get##5 8
;##8 9
set##: =
;##= >
}##? @
[%% 	
StringLength%%	 
(%% 
$num%% 
)%% 
]%% 
public&& 
string&& 
?&& !
SecondaryMobileNumber&& ,
{&&- .
get&&/ 2
;&&2 3
set&&4 7
;&&7 8
}&&9 :
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
string)) 
?)) 
OfficeNumber)) #
{))$ %
get))& )
;))) *
set))+ .
;)). /
}))0 1
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
string,, 
?,, 
WhatsAppNumber,, %
{,,& '
get,,( +
;,,+ ,
set,,- 0
;,,0 1
},,2 3
[.. 	
EmailAddress..	 
].. 
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
required00 
string00 
EmailAddress00 +
{00, -
get00. 1
;001 2
set003 6
;006 7
}008 9
public22 
string22 
?22 
SocialMediaType22 &
{22' (
get22) ,
;22, -
set22. 1
;221 2
}223 4
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
SocialMediaAccount55 )
{55* +
get55, /
;55/ 0
set551 4
;554 5
}556 7
}66 
}77 