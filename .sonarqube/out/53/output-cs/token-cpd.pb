 

á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/PayPointDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class  
PayPointDtoValidator "
:# $
AbstractValidator% 6
<6 7
PaypointsCreateDto7 I
>I J
{ 
public  
PayPointDtoValidator	 
( 
) 
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 

PaypointId

 %
)

% &
.

& ' 
GreaterThanOrEqualTo

' ;
(

; <
$num

< =
)

= >
;

> ?
RuleFor 
( 
x 
=> 
x 
. 
Paypoint #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
Length0 6
(6 7
$num7 8
,8 9
$num: <
)< =
.= >
WithMessage> I
(I J
$str	J ñ
)
ñ ó
;
ó ò
} 	
} 
} ‹

ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/PaymentTypeDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class #
PaymentTypeDtoValidator %
:& '
AbstractValidator( 9
<9 : 
PaymentTypeCreateDto: N
>N O
{ 
public #
PaymentTypeDtoValidator	  
(  !
)! "
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
PaymentTypeId

 (
)

( )
.

) * 
GreaterThanOrEqualTo

* >
(

> ?
$num

? @
)

@ A
;

A B
RuleFor 
( 
x 
=> 
x 
. 
PaymentTypes '
)' (
.( )
NotEmpty) 1
(1 2
)2 3
.3 4
Length4 :
(: ;
$num; <
,< =
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N ò
)
ò ô
;
ô ö
} 	
} 
} ‹

ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/PaymentModeDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class #
PaymentModeDtoValidator %
:& '
AbstractValidator( 9
<9 : 
PaymentModeCreateDto: N
>N O
{ 
public #
PaymentModeDtoValidator	  
(  !
)! "
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
PaymentModeId

 (
)

( )
.

) * 
GreaterThanOrEqualTo

* >
(

> ?
$num

? @
)

@ A
;

A B
RuleFor 
( 
x 
=> 
x 
. 
PaymentModes '
)' (
.( )
NotEmpty) 1
(1 2
)2 3
.3 4
Length4 :
(: ;
$num; <
,< =
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N ò
)
ò ô
;
ô ö
} 	
} 
} ∑
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/InvoiceTypesDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class $
InvoiceTypesDtoValidator &
:& '
AbstractValidator( 9
<9 :!
InvoiceTypesCreateDto: O
>O P
{ 
public $
InvoiceTypesDtoValidator	 !
(! "
)" #
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
InvoiceInitials

 *
)

* +
.

+ ,
NotEmpty

, 4
(

4 5
)

5 6
.

6 7
Length

7 =
(

= >
$num

> ?
,

? @
$num

A B
)

B C
.

C D
WithMessage

D O
(

O P
$str	

P º
)


º Ω
;


Ω æ
RuleFor 
( 
x 
=> 
x 
. 
InvoiceAmount (
)( )
.) *
NotEmpty* 2
(2 3
)3 4
.4 5 
GreaterThanOrEqualTo5 I
(I J
$numJ K
)K L
.L M
WithMessageM X
(X Y
$str	Y Ñ
)
Ñ Ö
;
Ö Ü
RuleFor 
( 
x 
=> 
x 
. 
InvoiceDescriptions .
). /
./ 0
NotEmpty0 8
(8 9
)9 :
.: ;
Length; A
(A B
$numB C
,C D
$numE G
)G H
.H I
WithMessageI T
(T U
$str	U ©
)
© ™
;
™ ´
} 	
} 
} ≈
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/FormsDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class 
FormsDtoValidator 
:  
AbstractValidator! 2
<2 3
FormsCreateDto3 A
>A B
{ 
public 
FormsDtoValidator	 
( 
) 
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
FormCode

 #
)

# $
.

$ %
NotEmpty

% -
(

- .
)

. /
;

/ 0
RuleFor 
( 
x 
=> 
x 
. 
FormName #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
Length0 6
(6 7
$num7 8
,8 9
$num: <
)< =
.= >
WithMessage> I
(I J
$str	J ñ
)
ñ ó
;
ó ò
RuleFor 
( 
x 
=> 
x 
. 
Amount !
)! "
." #
NotEmpty# +
(+ ,
), -
.- . 
GreaterThanOrEqualTo. B
(B C
$numC D
)D E
.E F
WithMessageF Q
(Q R
$strR u
)u v
;v w
RuleFor 
( 
x 
=> 
x 
. 
AccountCode &
)& '
.' (
NotEmpty( 0
(0 1
)1 2
.2 3 
GreaterThanOrEqualTo3 G
(G H
$numH I
)I J
.J K
WithMessageK V
(V W
$str	W Ä
)
Ä Å
;
Å Ç
} 	
} 
} ©
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/CurrencyAndExchangeRateDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class /
#CurrencyAndExchangeRateDtoValidator 1
:2 3
AbstractValidator4 E
<E F,
 CurrencyAndExchangeRateCreateDtoF f
>f g
{ 
public /
#CurrencyAndExchangeRateDtoValidator	 ,
(, -
)- .
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 

CurrencyId

 %
)

% &
.

& '
NotEmpty

' /
(

/ 0
)

0 1
.

1 2 
GreaterThanOrEqualTo

2 F
(

F G
$num

G H
)

H I
;

I J
RuleFor 
( 
x 
=> 
x 
. 
CurrencyInitial *
)* +
.+ ,
NotEmpty, 4
(4 5
)5 6
.6 7
Length7 =
(= >
$num> ?
,? @
$numA B
)B C
.C D
WithMessageD O
(O P
$str	P ü
)
ü †
;
† °
RuleFor 
( 
x 
=> 
x 
. 
CurrencyName '
)' (
.( )
NotEmpty) 1
(1 2
)2 3
.3 4
Length4 :
(: ;
$num; <
,< =
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N ô
)
ô ö
;
ö õ
RuleFor 
( 
x 
=> 
x 
. 

BuyingRate %
)% &
.& '
NotEmpty' /
(/ 0
)0 1
.1 2 
GreaterThanOrEqualTo2 F
(F G
$numG H
)H I
.I J
WithMessageJ U
(U V
$strV ~
)~ 
;	 Ä
RuleFor 
( 
x 
=> 
x 
. 
SellingRate &
)& '
.' (
NotEmpty( 0
(0 1
)1 2
.2 3 
GreaterThanOrEqualTo3 G
(G H
$numH I
)I J
.J K
WithMessageK V
(V W
$str	W Ä
)
Ä Å
;
Å Ç
} 	
} 
} Ü
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/ChartOfAccountsDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class '
ChartOfAccountsDtoValidator )
:) *
AbstractValidator+ <
<< =$
ChartOfAccountsCreateDto= U
>U V
{ 
public '
ChartOfAccountsDtoValidator	 $
($ %
)% &
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
AccountCode

 &
)

& '
.

' (
NotEmpty

( 0
(

0 1
)

1 2
.

2 3
LessThanOrEqualTo

3 D
(

D E
$num

E F
)

F G
.

G H
WithMessage

H S
(

S T
$str	

T Ü
)


Ü á
;


á à
RuleFor 
( 
x 
=> 
x 
. 
AccountName &
)& '
.' (
NotEmpty( 0
(0 1
)1 2
.2 3
Length3 9
(9 :
$num: ;
,; <
$num= ?
)? @
.@ A
WithMessageA L
(L M
$str	M ü
)
ü †
;
† °
} 	
} 
} ü
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/BankSortCodesDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class %
BankSortCodesDtoValidator '
:( )
AbstractValidator* ;
<; <"
BankSortCodesCreateDto< R
>R S
{ 
public %
BankSortCodesDtoValidator	 "
(" #
)# $
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
SortCode

 #
)

# $
.

$ %
NotEmpty

% -
(

- .
)

. /
.

/ 0
MinimumLength

0 =
(

= >
$num

> ?
)

? @
.

@ A
WithMessage

A L
(

L M
$str	

M ì
)


ì î
;


î ï
RuleFor 
( 
x 
=> 
x 
. 
BankName #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
Length0 6
(6 7
$num7 8
,8 9
$num: <
)< =
.= >
WithMessage> I
(I J
$str	J ê
)
ê ë
;
ë í
RuleFor 
( 
x 
=> 
x 
. 

BranchName %
)% &
.& '
NotEmpty' /
(/ 0
)0 1
.1 2
Length2 8
(8 9
$num9 ;
,; <
$num= @
)@ A
.A B
WithMessageB M
(M N
$str	N ®
)
® ©
;
© ™
} 	
} 
} Œ
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/BankDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class 
BankDtoValidator 
:  
AbstractValidator! 2
<2 3
BankCreateDto3 @
>@ A
{ 
public 
BankDtoValidator	 
( 
) 
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
BankId

 !
)

! "
.

" #
NotEmpty

# +
(

+ ,
)

, -
.

- .
MinimumLength

. ;
(

; <
$num

< >
)

> ?
.

? @
WithMessage

@ K
(

K L
$str	

L ë
)


ë í
;


í ì
RuleFor 
( 
x 
=> 
x 
. 
BankName #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
Length0 6
(6 7
$num7 8
,8 9
$num: <
)< =
.= >
WithMessage> I
(I J
$str	J ê
)
ê ë
;
ë í
} 	
} 
} ˜
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Validations/Setup/BankBranchDtoValidator.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
{ 
public 
class "
BankBranchDtoValidator $
:% &
AbstractValidator' 8
<8 9
BankBranchCreateDto9 L
>L M
{ 
public "
BankBranchDtoValidator	 
(  
)  !
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 
BankId

 !
)

! "
.

" #
NotEmpty

# +
(

+ ,
)

, -
.

- .
MinimumLength

. ;
(

; <
$num

< >
)

> ?
.

? @
WithMessage

@ K
(

K L
$str	

L ë
)


ë í
;


í ì
RuleFor 
( 
x 
=> 
x 
. 
BranchId #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
MinimumLength0 =
(= >
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N ï
)
ï ñ
;
ñ ó
RuleFor 
( 
x 
=> 
x 
. 

BranchName %
)% &
.& '
NotEmpty' /
(/ 0
)0 1
.1 2
Length2 8
(8 9
$num9 ;
,; <
$num= @
)@ A
.A B
WithMessageB M
(M N
$str	N ®
)
® ©
;
© ™
} 	
} 
} i
g/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Usings.csú 
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/PayPointsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
PayPointsService 
:  
IPayPointsService! 2
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
PayPointsService

 
(

  
IUnitOfWork

  +

unitOfWork

, 6
,

6 7
IMapper

8 ?
mapper

@ F
)

F G
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
PaypointsReadDto *
>* +
AddPaypointsAsync, =
(= >
PaypointsCreateDto> P
valuesQ W
)W X
{ 	
	Paypoints 
paypoint 
=  
new! $
($ %
values% +
.+ ,

PaypointId, 6
,6 7
values8 >
.> ?
Paypoint? G
!G H
)H I
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
	Paypoints !
.! "
Insert" (
(( )
paypoint) 1
)1 2
;2 3
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
PaypointsReadDto '
(' (
paypoint( 0
.0 1

PaypointId1 ;
,; <
paypoint= E
.E F
PaypointF N
!N O
)O P
;P Q
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
PaypointsReadDto& 6
>6 7
>7 8
GetPaypointsAsync9 J
(J K
)K L
{ 	
var   
	paypoints   
=   
await   !
_unitOfWork  " -
.  - .
	Paypoints  . 7
.  7 8
GetAll  8 >
(  > ?
)  ? @
;  @ A
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +
PaypointsReadDto!!+ ;
>!!; <
>!!< =
(!!= >
	paypoints!!> G
)!!G H
;!!H I
}"" 	
public$$ 
Task$$ 
<$$ 
PaypointsReadDto$$ $
>$$$ %
GetPaypointsAsync$$& 7
($$7 8
int$$8 ;
value$$< A
)$$A B
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) 
PaypointsReadDto)) $
>))$ %
GetPaypointsAsync))& 7
())7 8
string))8 >
value))? D
)))D E
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. 
PaypointsReadDto.. $
>..$ % 
UpdatePaypointsAsync..& :
(..: ;
PaypointsUpdateDto..; M
values..N T
)..T U
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 ¿ 
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/PaymentTypeService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
PaymentTypeService  
:! "
IPaymentTypeService# 6
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
PaymentTypeService

 !
(

! "
IUnitOfWork

" -

unitOfWork

. 8
,

8 9
IMapper

: A
mapper

B H
)

H I
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
PaymentTypeReadDto ,
>, -
AddPaymentTypeAsync. A
(A B 
PaymentTypeCreateDtoB V
valuesW ]
)] ^
{ 	
PaymentType 
types 
= 
new  #
(# $
values$ *
.* +
PaymentTypeId+ 8
,8 9
values: @
.@ A
PaymentTypesA M
!M N
)N O
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
PaymentType #
.# $
Insert$ *
(* +
types+ 0
)0 1
;1 2
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
PaymentTypeReadDto )
() *
types* /
./ 0
PaymentTypeId0 =
,= >
types? D
.D E
PaymentTypesE Q
!Q R
)R S
;S T
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
PaymentTypeReadDto& 8
>8 9
>9 :
GetPaymentTypeAsync; N
(N O
)O P
{ 	
var   
types   
=   
await   
_unitOfWork   )
.  ) *
PaymentType  * 5
.  5 6
GetAll  6 <
(  < =
)  = >
;  > ?
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +
PaymentTypeReadDto!!+ =
>!!= >
>!!> ?
(!!? @
types!!@ E
)!!E F
;!!F G
}"" 	
public$$ 
Task$$ 
<$$ 
PaymentTypeReadDto$$ &
>$$& '
GetPaymentTypeAsync$$( ;
($$; <
int$$< ?
value$$@ E
)$$E F
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) 
PaymentTypeReadDto)) &
>))& '
GetPaymentTypeAsync))( ;
()); <
string))< B
value))C H
)))H I
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. 
PaymentTypeReadDto.. &
>..& '"
UpdatePaymentTypeAsync..( >
(..> ? 
PaymentTypeUpdateDto..? S
values..T Z
)..Z [
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 º 
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/PaymentModeService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
PaymentModeService  
:! "
IPaymentModeService# 6
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
PaymentModeService

 !
(

! "
IUnitOfWork

" -

unitOfWork

. 8
,

8 9
IMapper

: A
mapper

B H
)

H I
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
PaymentModeReadDto ,
>, -
AddPaymentModeAsync. A
(A B 
PaymentModeCreateDtoB V
valuesW ]
)] ^
{ 	
PaymentMode 
mode 
= 
new "
(" #
values# )
.) *
PaymentModeId* 7
,7 8
values9 ?
.? @
PaymentModes@ L
!L M
)M N
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
PaymentMode #
.# $
Insert$ *
(* +
mode+ /
)/ 0
;0 1
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
PaymentModeReadDto )
() *
mode* .
.. /
PaymentModeId/ <
,< =
mode> B
.B C
PaymentModesC O
!O P
)P Q
;Q R
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
PaymentModeReadDto& 8
>8 9
>9 :
GetPaymentModeAsync; N
(N O
)O P
{ 	
var   
modes   
=   
await   
_unitOfWork   )
.  ) *
PaymentMode  * 5
.  5 6
GetAll  6 <
(  < =
)  = >
;  > ?
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +
PaymentModeReadDto!!+ =
>!!= >
>!!> ?
(!!? @
modes!!@ E
)!!E F
;!!F G
}"" 	
public$$ 
Task$$ 
<$$ 
PaymentModeReadDto$$ &
>$$& '
GetPaymentModeAsync$$( ;
($$; <
int$$< ?
value$$@ E
)$$E F
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) 
PaymentModeReadDto)) &
>))& '
GetPaymentModeAsync))( ;
()); <
string))< B
value))C H
)))H I
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. 
PaymentModeReadDto.. &
>..& '"
UpdatePaymentModeAsync..( >
(..> ? 
PaymentModeUpdateDto..? S
values..T Z
)..Z [
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 §!
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/InvoiceTypesService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
InvoiceTypesService !
:" # 
IInvoiceTypesService$ 8
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
InvoiceTypesService

 "
(

" #
IUnitOfWork

# .

unitOfWork

/ 9
,

9 :
IMapper

; B
mapper

C I
)

I J
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
InvoiceTypesReadDto -
>- . 
AddInvoiceTypesAsync/ C
(C D!
InvoiceTypesCreateDtoD Y
valuesZ `
)` a
{ 	
InvoiceTypes 
invoiceTypes %
=& '
new( +
InvoiceTypes, 8
(8 9
values9 ?
.? @
InvoiceTypesId@ N
,N O
valuesP V
.V W
InvoiceInitialsW f
,f g
valuesh n
.n o 
InvoiceDescriptions	o Ç
,
Ç É
values
Ñ ä
.
ä ã
InvoiceAmount
ã ò
)
ò ô
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
UtcNow% +
} 
; 
_unitOfWork 
. 
InvoiceTypes $
.$ %
Insert% +
(+ ,
invoiceTypes, 8
)8 9
;9 :
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
InvoiceTypesReadDto *
(* +
invoiceTypes+ 7
.7 8
InvoiceTypesId8 F
,F G
invoiceTypesH T
.T U
InvoiceInitialsU d
!d e
,e f
invoiceTypesg s
.s t 
InvoiceDescriptions	t á
!
á à
,
à â
invoiceTypes
ä ñ
.
ñ ó
InvoiceAmount
ó §
)
§ •
;
• ¶
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
InvoiceTypesReadDto& 9
>9 :
>: ; 
GetInvoiceTypesAsync< P
(P Q
)Q R
{ 	
var!! 
	inv_types!! 
=!! 
await!! !
_unitOfWork!!" -
.!!- .
InvoiceTypes!!. :
.!!: ;
GetAll!!; A
(!!A B
)!!B C
;!!C D
return"" 
_mapper"" 
."" 
Map"" 
<"" 
IEnumerable"" *
<""* +
InvoiceTypesReadDto""+ >
>""> ?
>""? @
(""@ A
	inv_types""A J
)""J K
;""K L
}$$ 	
public&& 
Task&& 
<&& 
InvoiceTypesReadDto&& '
>&&' ( 
GetInvoiceTypesAsync&&) =
(&&= >
int&&> A
value&&B G
)&&G H
{'' 	
throw(( 
new(( #
NotImplementedException(( -
(((- .
)((. /
;((/ 0
})) 	
public++ 
Task++ 
<++ 
InvoiceTypesReadDto++ '
>++' (#
UpdateInvoiceTypesAsync++) @
(++@ A!
InvoiceTypesUpdateDto++A V
values++W ]
)++] ^
{,, 	
throw-- 
new-- #
NotImplementedException-- -
(--- .
)--. /
;--/ 0
}.. 	
}// 
}00 Ë!
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/FormsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
FormsService 
: 
IFormsService *
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
FormsService

 
(

 
IUnitOfWork

 '

unitOfWork

( 2
,

2 3
IMapper

4 ;
mapper

< B
)

B C
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
FormsReadDto &
>& '
AddFormsAsync( 5
(5 6
FormsCreateDto6 D
valuesE K
)K L
{ 	
Forms 
form 
= 
new 
( 
values #
.# $
FormCode$ ,
!, -
,- .
values/ 5
.5 6
FormName6 >
!> ?
,? @
valuesA G
.G H
AmountH N
,N O
valuesP V
.V W
AccountCodeW b
)b c
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
Forms 
. 
Insert $
($ %
form% )
)) *
;* +
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
FormsReadDto #
(# $
form$ (
.( )
FormCode) 1
!1 2
,2 3
form4 8
.8 9
FormName9 A
!A B
,B C
formD H
.H I
AmountI O
,O P
formQ U
.U V
AccountCodeV a
)a b
;b c
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
FormsReadDto& 2
>2 3
>3 4
GetFormsAsync5 B
(B C
)C D
{ 	
var   
forms   
=   
await   
_unitOfWork   )
.  ) *
Forms  * /
.  / 0
GetAll  0 6
(  6 7
)  7 8
;  8 9
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +
FormsReadDto!!+ 7
>!!7 8
>!!8 9
(!!9 :
forms!!: ?
)!!? @
;!!@ A
}"" 	
public$$ 
Task$$ 
<$$ 
FormsReadDto$$  
>$$  !
GetFormsAsync$$" /
($$/ 0
int$$0 3
value$$4 9
)$$9 :
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) 
FormsReadDto))  
>))  !
GetFormsAsync))" /
())/ 0
string))0 6
value))7 <
)))< =
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. 
FormsReadDto..  
>..  !
UpdateFormsAsync.." 2
(..2 3
FormsUpdateDto..3 A
values..B H
)..H I
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 ò*
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/CurrencyAndExchangeRateService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class *
CurrencyAndExchangeRateService ,
:- .+
ICurrencyAndExchangeRateService/ N
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 *
CurrencyAndExchangeRateService

 -
(

- .
IUnitOfWork

. 9

unitOfWork

: D
,

D E
IMapper

F M
mapper

N T
)

T U
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< *
CurrencyAndExchangeRateReadDto 8
>8 9+
AddCurrencyAndExchangeRateAsync: Y
(Y Z,
 CurrencyAndExchangeRateCreateDtoZ z
values	{ Å
)
Å Ç
{ 	#
CurrencyAndExchangeRate #
currency$ ,
=- .
new/ 2
(2 3
values3 9
.9 :

CurrencyId: D
,D E
valuesF L
.L M
CurrencyInitialM \
,\ ]
values^ d
.d e
CurrencyNamee q
,q r
valuess y
.y z

BuyingRate	z Ñ
,
Ñ Ö
values
Ü å
.
å ç
SellingRate
ç ò
,
ò ô
values
ö †
.
† °
BaseCurrency
° ≠
,
≠ Æ
values
Ø µ
.
µ ∂
ApplicableDate
∂ ƒ
,
ƒ ≈
values
∆ Ã
.
Ã Õ
	IsCurrent
Õ ÷
)
÷ ◊
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. #
CurrencyAndExchangeRate /
./ 0
Insert0 6
(6 7
currency7 ?
)? @
;@ A
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new *
CurrencyAndExchangeRateReadDto 5
(5 6
currency6 >
.> ?

CurrencyId? I
,I J
currencyK S
.S T
CurrencyInitialT c
,c d
currencye m
.m n
CurrencyNamen z
,z {
currency	| Ñ
.
Ñ Ö

BuyingRate
Ö è
,
è ê
currency
ë ô
.
ô ö
SellingRate
ö •
,
• ¶
currency
ß Ø
.
Ø ∞
BaseCurrency
∞ º
,
º Ω
currency
æ ∆
.
∆ «
ApplicableDate
« ’
,
’ ÷
currency
◊ ﬂ
.
ﬂ ‡
	IsCurrent
‡ È
)
È Í
;
Í Î
} 	
public 
async 
Task 
< 
IEnumerable %
<% &*
CurrencyAndExchangeRateReadDto& D
>D E
>E F+
GetCurrencyAndExchangeRateAsyncG f
(f g
)g h
{ 	
var   

currencies   
=   
await   "
_unitOfWork  # .
.  . /#
CurrencyAndExchangeRate  / F
.  F G
GetAll  G M
(  M N
)  N O
;  O P
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +*
CurrencyAndExchangeRateReadDto!!+ I
>!!I J
>!!J K
(!!K L

currencies!!L V
)!!V W
;!!W X
}"" 	
public$$ 
Task$$ 
<$$ *
CurrencyAndExchangeRateReadDto$$ 2
>$$2 3+
GetCurrencyAndExchangeRateAsync$$4 S
($$S T
int$$T W
value$$X ]
)$$] ^
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) *
CurrencyAndExchangeRateReadDto)) 2
>))2 3+
GetCurrencyAndExchangeRateAsync))4 S
())S T
string))T Z
value))[ `
)))` a
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. *
CurrencyAndExchangeRateReadDto.. 2
>..2 3.
"UpdateCurrencyAndExchangeRateAsync..4 V
(..V W,
 CurrencyAndExchangeRateUpdateDto..W w
values..x ~
)..~ 
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 À!
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/ChartOfAccountsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class "
ChartOfAccountsService $
:% &#
IChartOfAccountsService' >
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 "
ChartOfAccountsService

 %
(

% &
IUnitOfWork

& 1

unitOfWork

2 <
,

< =
IMapper

> E
mapper

F L
)

L M
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< "
ChartOfAccountsReadDto 0
>0 1#
AddChartOfAccountsAsync2 I
(I J$
ChartOfAccountsCreateDtoJ b
valuesc i
)i j
{ 	
ChartOfAccounts 
chartOfAccounts +
=, -
new. 1
(1 2
values2 8
.8 9
AccountCode9 D
,D E
valuesF L
.L M
AccountNameM X
!X Y
)Y Z
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
ChartOfAccounts '
.' (
Insert( .
(. /
chartOfAccounts/ >
)> ?
;? @
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new "
ChartOfAccountsReadDto -
(- .
chartOfAccounts. =
.= >
AccountCode> I
,I J
chartOfAccountsK Z
.Z [
AccountName[ f
!f g
)g h
;h i
} 	
public 
async 
Task 
< 
IEnumerable %
<% &"
ChartOfAccountsReadDto& <
>< =
>= >#
GetChartOfAccountsAsync? V
(V W
)W X
{ 	
var   
chartOfAccounts   
=    !
await  " '
_unitOfWork  ( 3
.  3 4
ChartOfAccounts  4 C
.  C D
GetAll  D J
(  J K
)  K L
;  L M
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +"
ChartOfAccountsReadDto!!+ A
>!!A B
>!!B C
(!!C D
chartOfAccounts!!D S
)!!S T
;!!T U
}"" 	
public$$ 
Task$$ 
<$$ "
ChartOfAccountsReadDto$$ *
>$$* +#
GetChartOfAccountsAsync$$, C
($$C D
int$$D G
value$$H M
)$$M N
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<)) "
ChartOfAccountsReadDto)) *
>))* +#
GetChartOfAccountsAsync)), C
())C D
string))D J
value))K P
)))P Q
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<.. "
ChartOfAccountsReadDto.. *
>..* +&
UpdateChartOfAccountsAsync.., F
(..F G$
ChartOfAccountsUpdateDto..G _
values..` f
)..f g
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 ª#
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/BankSortCodesService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class  
BankSortCodesService "
:# $!
IBankSortCodesService% :
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

  
BankSortCodesService

 #
(

# $
IUnitOfWork

$ /

unitOfWork

0 :
,

: ;
IMapper

< C
mapper

D J
)

J K
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
<  
BankSortCodesReadDto .
>. /!
AddBankSortCodesAsync0 E
(E F"
BankSortCodesCreateDtoF \
values] c
)c d
{ 	
BankSortCodes 
	sortCodes #
=$ %
new& )
() *
values* 0
.0 1
Id1 3
,3 4
values4 :
.: ;
SortCode; C
,C D
valuesE K
.K L
BankNameL T
!T U
,U V
valuesV \
.\ ]

BranchName] g
!g h
)h i
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
BankSortCodes %
.% &
Insert& ,
(, -
	sortCodes- 6
)6 7
;7 8
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new  
BankSortCodesReadDto +
(+ ,
	sortCodes, 5
.5 6
Id6 8
,8 9
	sortCodes: C
.C D
SortCodeD L
!L M
,M N
	sortCodesO X
.X Y
BankNameY a
!a b
,b c
	sortCodesd m
.m n

BranchNamen x
!x y
)y z
;z {
} 	
public 
async 
Task 
< 
IEnumerable %
<% & 
BankSortCodesReadDto& :
>: ;
>; <!
GetBankSortCodesAsync= R
(R S
)S T
{ 	
var   
	sortcodes   
=   
await   !
_unitOfWork  " -
.  - .
BankSortCodes  . ;
.  ; <
GetAll  < B
(  B C
)  C D
;  D E
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* + 
BankSortCodesReadDto!!+ ?
>!!? @
>!!@ A
(!!A B
	sortcodes!!B K
)!!K L
;!!L M
}"" 	
public$$ 
Task$$ 
<$$  
BankSortCodesReadDto$$ (
>$$( )!
GetBankSortCodesAsync$$* ?
($$? @
int$$@ C
value$$D I
)$$I J
{%% 	
throw&& 
new&& #
NotImplementedException&& -
(&&- .
)&&. /
;&&/ 0
}'' 	
public)) 
Task)) 
<))  
BankSortCodesReadDto)) (
>))( )!
GetBankSortCodesAsync))* ?
())? @
string))@ F
value))G L
)))L M
{** 	
throw++ 
new++ #
NotImplementedException++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
Task.. 
<..  
BankSortCodesReadDto.. (
>..( )$
UpdateBankSortCodesAsync..* B
(..B C"
BankSortCodesUpdateDto..C Y
values..Z `
)..` a
{// 	
throw00 
new00 #
NotImplementedException00 -
(00- .
)00. /
;00/ 0
}11 	
}22 
}33 Â(
u/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/BankService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
BankService 
: 
IBankService (
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
BankService

 
(

 
IUnitOfWork

 &

unitOfWork

' 1
,

1 2
IMapper

3 :
mapper

; A
)

A B
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
BankReadDto %
>% &
AddBankAsync' 3
(3 4
BankCreateDto4 A
valuesB H
)H I
{ 	
Bank 
bank 
= 
new 
( 
values "
." #
BankId# )
,) *
values+ 1
.1 2
BankName2 :
!: ;
); <
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
Bank 
. 
Insert #
(# $
bank$ (
)( )
;) *
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
BankReadDto "
(" #
bank# '
.' (
BankId( .
,. /
bank0 4
.4 5
BankName5 =
!= >
)> ?
;? @
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
BankReadDto& 1
>1 2
>2 3
GetBankAsync4 @
(@ A
)A B
{ 	
var   
banks   
=   
await   
_unitOfWork   )
.  ) *
Bank  * .
.  . /
GetAll  / 5
(  5 6
)  6 7
;  7 8
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! *
<!!* +
BankReadDto!!+ 6
>!!6 7
>!!7 8
(!!8 9
banks!!9 >
)!!> ?
;!!? @
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
BankReadDto$$ %
>$$% &
GetBankAsync$$' 3
($$3 4
int$$4 7
value$$8 =
)$$= >
{%% 	
var&& 
bank&& 
=&& 
await&& 
_unitOfWork&& (
.&&( )
Bank&&) -
.&&- .
Get&&. 1
(&&1 2
value&&2 7
)&&7 8
;&&8 9
return'' 
_mapper'' 
.'' 
Map'' 
<'' 
BankReadDto'' *
>''* +
(''+ ,
bank'', 0
)''0 1
;''1 2
}(( 	
public** 
Task** 
<** 
BankReadDto** 
>**  
GetBankAsync**! -
(**- .
string**. 4
value**5 :
)**: ;
{++ 	
throw,, 
new,, #
NotImplementedException,, -
(,,- .
),,. /
;,,/ 0
}-- 	
public// 
async// 
Task// 
<// 
BankReadDto// %
>//% &
UpdateBankAsync//' 6
(//6 7
BankUpdateDto//7 D
values//E K
)//K L
{00 	
Bank22 
bank22 
=22 
new22 
(22 
values22 "
.22" #
BankId22# )
,22) *
values22+ 1
.221 2
BankName222 :
!22: ;
)22; <
{33 

ModifiedBy44 
=44 
values44 #
.44# $

ModifiedBy44$ .
,44. /

ModifiedOn55 
=55 
DateTime55 %
.55% &
Now55& )
}66 
;66 
_unitOfWork88 
.88 
Bank88 
.88 
Update88 #
(88# $
bank88$ (
)88( )
;88) *
await99 
_unitOfWork99 
.99 
Complete99 &
(99& '
)99' (
;99( )
return;; 
new;; 
BankReadDto;; "
(;;" #
bank;;# '
.;;' (
BankId;;( .
,;;. /
bank;;0 4
.;;4 5
BankName;;5 =
!;;= >
);;> ?
;;;? @
}<< 	
}== 
}>> æ!
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/BankBranchService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
UseCases& .
{ 
public 
class 
BankBranchService 
:  !
IBankBranchService" 4
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public

 
BankBranchService

  
(

  !
IUnitOfWork

! ,

unitOfWork

- 7
,

7 8
IMapper

9 @
mapper

A G
)

G H
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< 
BankBranchReadDto +
>+ ,!
CreateBankBranchAsync- B
(B C
BankBranchCreateDtoC V
valuesW ]
)] ^
{ 	

BankBranch 
branch 
= 
new  #
(# $
values$ *
.* +
BankId+ 1
,1 2
values3 9
.9 :
BranchId: B
,B C
valuesD J
.J K

BranchNameK U
!U V
)V W
{ 
	CreatedBy 
= 
values "
." #
	CreatedBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 

BankBranch "
." #
Insert# )
() *
branch* 0
)0 1
;1 2
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
BankBranchReadDto (
(( )
branch) /
./ 0
BankId0 6
,6 7
branch8 >
.> ?
BranchId? G
,G H
branchI O
.O P

BranchNameP Z
!Z [
)[ \
;\ ]
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
BankBranchReadDto& 7
>7 8
>8 9
GetBankBranchAsync: L
(L M
)M N
{ 	
var!! 
bankbranches!! 
=!! 
await!! $
_unitOfWork!!% 0
.!!0 1

BankBranch!!1 ;
.!!; <
GetAll!!< B
(!!B C
)!!C D
;!!D E
return"" 
_mapper"" 
."" 
Map"" 
<"" 
IEnumerable"" *
<""* +
BankBranchReadDto""+ <
>""< =
>""= >
(""> ?
bankbranches""? K
)""K L
;""L M
}## 	
public%% 
Task%% 
<%% 
BankBranchReadDto%% %
>%%% &
GetBankBranchAsync%%' 9
(%%9 :
int%%: =
value%%> C
)%%C D
{&& 	
throw'' 
new'' #
NotImplementedException'' -
(''- .
)''. /
;''/ 0
}(( 	
public** 
Task** 
<** 
BankBranchReadDto** %
>**% &
GetBankBranchAsync**' 9
(**9 :
string**: @
value**A F
)**F G
{++ 	
throw,, 
new,, #
NotImplementedException,, -
(,,- .
),,. /
;,,/ 0
}-- 	
public// 
Task// 
<// 
BankBranchReadDto// %
>//% &!
UpdateBankBranchAsync//' <
(//< =
BankBranchUpdateDto//= P
values//Q W
)//W X
{00 	
throw11 
new11 #
NotImplementedException11 -
(11- .
)11. /
;11/ 0
}22 	
}33 
}44 È	
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/PaypointProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
PaypointProfile 
: 
Profile  '
{ 
public 
PaypointProfile	 
( 
) 
{ 
	CreateMap 
< 
	Paypoints 
, 
PaypointsReadDto (
>( )
() *
)* +
;+ ,
	CreateMap		 
<		 
PaypointsCreateDto		 
,		  
	Paypoints		! *
>		* +
(		+ ,
)		, -
;		- .
	CreateMap

 
<

 
PaypointsUpdateDto

 
,

  
	Paypoints

! *
>

* +
(

+ ,
)

, -
;

- .
	CreateMap 
< 
PaypointsDeleteDto 
,  
	Paypoints! *
>* +
(+ ,
), -
;- .
} 
} 
} É

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/PaymentTypeProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
PaymentTypeProfile  
:! "
Profile# *
{ 
public 
PaymentTypeProfile	 
( 
) 
{ 
	CreateMap		 
<		 
PaymentType		 
,		 
PaymentTypeReadDto		 ,
>		, -
(		- .
)		. /
;		/ 0
	CreateMap

 
<

  
PaymentTypeCreateDto

 *
,

* +
PaymentType

, 7
>

7 8
(

8 9
)

9 :
;

: ;
	CreateMap 
<  
PaymentTypeUpdateDto *
,* +
PaymentType, 7
>7 8
(8 9
)9 :
;: ;
	CreateMap 
<  
PaymentTypeDeleteDto *
,* +
PaymentType, 7
>7 8
(8 9
)9 :
;: ;
} 	
} 
} É

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/PaymentModeProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
PaymentModeProfile  
:! "
Profile# *
{ 
public 
PaymentModeProfile	 
( 
) 
{ 
	CreateMap 
< 
PaymentMode !
,! "
PaymentModeReadDto# 5
>5 6
(6 7
)7 8
;8 9
	CreateMap		 
<		  
PaymentModeCreateDto		 *
,		* +
PaymentMode		, 7
>		7 8
(		8 9
)		9 :
;		: ;
	CreateMap

 
<

  
PaymentModeUpdateDto

 *
,

* +
PaymentMode

, 7
>

7 8
(

8 9
)

9 :
;

: ;
	CreateMap 
<  
PaymentModeDeleteDto *
,* +
PaymentMode, 7
>7 8
(8 9
)9 :
;: ;
} 	
} 
} é

É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/InvoiceTypesProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
InvoiceTypesProfile !
:" #
Profile$ +
{ 
public 
InvoiceTypesProfile	 
( 
) 
{ 
	CreateMap 
< 
InvoiceTypes "
," #
InvoiceTypesReadDto$ 7
>7 8
(8 9
)9 :
;: ;
	CreateMap		 
<		 !
InvoiceTypesCreateDto		 +
,		+ ,
InvoiceTypes		- 9
>		9 :
(		: ;
)		; <
;		< =
	CreateMap

 
<

 !
InvoiceTypesUpdateDto

 +
,

+ ,
InvoiceTypes

- 9
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
< !
InvoiceTypesDeleteDto +
,+ ,
InvoiceTypes- 9
>9 :
(: ;
); <
;< =
} 	
} 
} Ω	
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/FormProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
FormProfile 
: 
Profile #
{ 
public 
FormProfile	 
( 
) 
{ 
	CreateMap 
< 
Forms 
, 
FormsReadDto )
>) *
(* +
)+ ,
;, -
	CreateMap		 
<		 
FormsCreateDto		 $
,		$ %
Forms		& +
>		+ ,
(		, -
)		- .
;		. /
	CreateMap

 
<

 
FormsUpdateDto

 $
,

$ %
Forms

& +
>

+ ,
(

, -
)

- .
;

. /
	CreateMap 
< 
FormsDeleteDto $
,$ %
Forms& +
>+ ,
(, -
)- .
;. /
} 	
} 
} á
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/CurrencyAndExchangeRateProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class *
CurrencyAndExchangeRateProfile ,
:- .
Profile/ 6
{ 
public *
CurrencyAndExchangeRateProfile	 '
(' (
)( )
{ 
	CreateMap 
< #
CurrencyAndExchangeRate -
,- .*
CurrencyAndExchangeRateReadDto/ M
>M N
(N O
)O P
;P Q
	CreateMap		 
<		 ,
 CurrencyAndExchangeRateCreateDto		 6
,		6 7#
CurrencyAndExchangeRate		8 O
>		O P
(		P Q
)		Q R
;		R S
	CreateMap

 
<

 ,
 CurrencyAndExchangeRateUpdateDto

 6
,

6 7#
CurrencyAndExchangeRate

8 O
>

O P
(

P Q
)

Q R
;

R S
	CreateMap 
< ,
 CurrencyAndExchangeRateDeleteDto 6
,6 7#
CurrencyAndExchangeRate8 O
>O P
(P Q
)Q R
;R S
} 	
} 
} Ø

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/ChartOfAccountsProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class "
ChartOfAccountsProfile $
:% &
Profile' .
{ 
public "
ChartOfAccountsProfile	 
(  
)  !
{ 
	CreateMap 
< 
ChartOfAccounts %
,% &"
ChartOfAccountsReadDto' =
>= >
(> ?
)? @
;@ A
	CreateMap		 
<		 $
ChartOfAccountsCreateDto		 .
,		. /
ChartOfAccounts		0 ?
>		? @
(		@ A
)		A B
;		B C
	CreateMap

 
<

 $
ChartOfAccountsUpdateDto

 .
,

. /
ChartOfAccounts
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
B C
	CreateMap 
< $
ChartOfAccountsDeleteDto .
,. /
ChartOfAccounts0 ?
>? @
(@ A
)A B
;B C
} 	
} 
} ô

Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/BankSortCodesProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class  
BankSortCodesProfile "
:# $
Profile% ,
{ 
public  
BankSortCodesProfile	 
( 
) 
{ 
	CreateMap 
< 
BankSortCodes #
,# $ 
BankSortCodesReadDto% 9
>9 :
(: ;
); <
;< =
	CreateMap		 
<		 "
BankSortCodesCreateDto		 ,
,		, -
BankSortCodes		. ;
>		; <
(		< =
)		= >
;		> ?
	CreateMap

 
<

 "
BankSortCodesUpdateDto

 ,
,

, -
BankSortCodes

. ;
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
< "
BankSortCodesDeleteDto ,
,, -
BankSortCodes. ;
>; <
(< =
)= >
;> ?
} 	
} 
} µ	
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/BankProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
BankProfile 
: 
Profile #
{ 
public 
BankProfile	 
( 
) 
{ 
	CreateMap 
< 
Bank 
, 
BankReadDto '
>' (
(( )
)) *
;* +
	CreateMap		 
<		 
BankCreateDto		 #
,		# $
Bank		% )
>		) *
(		* +
)		+ ,
;		, -
	CreateMap

 
<

 
BankUpdateDto

 #
,

# $
Bank

% )
>

) *
(

* +
)

+ ,
;

, -
	CreateMap 
< 
BankDeleteDto #
,# $
Bank% )
>) *
(* +
)+ ,
;, -
} 	
} 
} ˚	
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Profiles/Setup/BankBranchProfile.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Profiles& .
.. /
Setup/ 4
{ 
public 
class 
BankBranchProfile 
:  !
Profile" )
{ 
public 
BankBranchProfile	 
( 
) 
{ 
	CreateMap 
< 

BankBranch  
,  !
BankBranchReadDto" 3
>3 4
(4 5
)5 6
;6 7
	CreateMap		 
<		  
PaymentTypeCreateDto		 *
,		* +

BankBranch		, 6
>		6 7
(		7 8
)		8 9
;		9 :
	CreateMap

 
<

  
PaymentTypeUpdateDto

 *
,

* +

BankBranch

, 6
>

6 7
(

7 8
)

8 9
;

9 :
	CreateMap 
<  
PaymentTypeDeleteDto *
,* +

BankBranch, 6
>6 7
(7 8
)8 9
;9 :
} 	
} 
} ∂
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IPayPointsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IPayPointsService #
{ 
Task 
< 
PaypointsReadDto 
> 
AddPaypointsAsync 0
(0 1
PaypointsCreateDto1 C
valuesD J
)J K
;K L
Task 
< 
PaypointsReadDto 
>  
UpdatePaypointsAsync 3
(3 4
PaypointsUpdateDto4 F
valuesG M
)M N
;N O
Task 
< 
IEnumerable 
< 
PaypointsReadDto )
>) *
>* +
GetPaypointsAsync, =
(= >
)> ?
;? @
Task		 
<		 
PaypointsReadDto		 
>		 
GetPaypointsAsync		 0
(		0 1
int		1 4
value		5 :
)		: ;
;		; <
Task

 
<

 
PaypointsReadDto

 
>

 
GetPaypointsAsync

 0
(

0 1
string

1 7
value

8 =
)

= >
;

> ?
} 
} “
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IPaymentTypeService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IPaymentTypeService %
{ 
Task 
< 
PaymentTypeReadDto 
>  
AddPaymentTypeAsync! 4
(4 5 
PaymentTypeCreateDto5 I
valuesJ P
)P Q
;Q R
Task 
< 
PaymentTypeReadDto 
>  "
UpdatePaymentTypeAsync! 7
(7 8 
PaymentTypeUpdateDto8 L
valuesM S
)S T
;T U
Task 
< 
IEnumerable 
< 
PaymentTypeReadDto +
>+ ,
>, -
GetPaymentTypeAsync. A
(A B
)B C
;C D
Task		 
<		 
PaymentTypeReadDto		 
>		  
GetPaymentTypeAsync		! 4
(		4 5
int		5 8
value		9 >
)		> ?
;		? @
Task

 
<

 
PaymentTypeReadDto

 
>

  
GetPaymentTypeAsync

! 4
(

4 5
string

5 ;
value

< A
)

A B
;

B C
} 
} “
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IPaymentModeService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IPaymentModeService %
{ 
Task 
< 
PaymentModeReadDto 
>  
AddPaymentModeAsync! 4
(4 5 
PaymentModeCreateDto5 I
valuesJ P
)P Q
;Q R
Task 
< 
PaymentModeReadDto 
>  "
UpdatePaymentModeAsync! 7
(7 8 
PaymentModeUpdateDto8 L
valuesM S
)S T
;T U
Task 
< 
IEnumerable 
< 
PaymentModeReadDto +
>+ ,
>, -
GetPaymentModeAsync. A
(A B
)B C
;C D
Task		 
<		 
PaymentModeReadDto		 
>		  
GetPaymentModeAsync		! 4
(		4 5
int		5 8
value		9 >
)		> ?
;		? @
Task

 
<

 
PaymentModeReadDto

 
>

  
GetPaymentModeAsync

! 4
(

4 5
string

5 ;
value

< A
)

A B
;

B C
} 
} ô

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IInvoiceTypesService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface  
IInvoiceTypesService &
{ 
Task 
< 
InvoiceTypesReadDto  
>  ! 
AddInvoiceTypesAsync" 6
(6 7!
InvoiceTypesCreateDto7 L
valuesM S
)S T
;T U
Task 
< 
InvoiceTypesReadDto  
>  !#
UpdateInvoiceTypesAsync" 9
(9 :!
InvoiceTypesUpdateDto: O
valuesP V
)V W
;W X
Task 
< 
IEnumerable 
< 
InvoiceTypesReadDto ,
>, -
>- . 
GetInvoiceTypesAsync/ C
(C D
)D E
;E F
Task		 
<		 
InvoiceTypesReadDto		  
>		  ! 
GetInvoiceTypesAsync		" 6
(		6 7
int		7 :
value		; @
)		@ A
;		A B
} 
} ˝

/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IFormsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IFormsService 
{ 
Task 
< 
FormsReadDto 
> 
AddFormsAsync (
(( )
FormsCreateDto) 7
values8 >
)> ?
;? @
Task 
< 
FormsReadDto 
> 
UpdateFormsAsync +
(+ ,
FormsUpdateDto, :
values; A
)A B
;B C
Task 
< 
IEnumerable 
< 
FormsReadDto %
>% &
>& '
GetFormsAsync( 5
(5 6
)6 7
;7 8
Task		 
<		 
FormsReadDto		 
>		 
GetFormsAsync		 (
(		( )
int		) ,
value		- 2
)		2 3
;		3 4
Task

 
<

 
FormsReadDto

 
>

 
GetFormsAsync

 (
(

( )
string

) /
value

0 5
)

5 6
;

6 7
} 
} ˙
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/ICurrencyAndExchangeRateService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface +
ICurrencyAndExchangeRateService 1
{ 
Task 
< *
CurrencyAndExchangeRateReadDto +
>+ ,+
AddCurrencyAndExchangeRateAsync- L
(L M,
 CurrencyAndExchangeRateCreateDtoM m
valuesn t
)t u
;u v
Task 
< *
CurrencyAndExchangeRateReadDto +
>+ ,.
"UpdateCurrencyAndExchangeRateAsync- O
(O P,
 CurrencyAndExchangeRateUpdateDtoP p
valuesq w
)w x
;x y
Task 
< 
IEnumerable 
< *
CurrencyAndExchangeRateReadDto 7
>7 8
>8 9+
GetCurrencyAndExchangeRateAsync: Y
(Y Z
)Z [
;[ \
Task		 
<		 *
CurrencyAndExchangeRateReadDto		 +
>		+ ,+
GetCurrencyAndExchangeRateAsync		- L
(		L M
int		M P
value		Q V
)		V W
;		W X
Task

 
<

 *
CurrencyAndExchangeRateReadDto

 +
>

+ ,+
GetCurrencyAndExchangeRateAsync

- L
(

L M
string

M S
value

T Y
)

Y Z
;

Z [
} 
} ä
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IChartOfAccountsService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface #
IChartOfAccountsService )
{ 
Task 
< "
ChartOfAccountsReadDto #
># $#
AddChartOfAccountsAsync% <
(< =$
ChartOfAccountsCreateDto= U
valuesV \
)\ ]
;] ^
Task 
< "
ChartOfAccountsReadDto #
># $&
UpdateChartOfAccountsAsync% ?
(? @$
ChartOfAccountsUpdateDto@ X
valuesY _
)_ `
;` a
Task 
< 
IEnumerable 
< "
ChartOfAccountsReadDto /
>/ 0
>0 1#
GetChartOfAccountsAsync2 I
(I J
)J K
;K L
Task		 
<		 "
ChartOfAccountsReadDto		 #
>		# $#
GetChartOfAccountsAsync		% <
(		< =
int		= @
value		A F
)		F G
;		G H
Task

 
<

 "
ChartOfAccountsReadDto

 #
>

# $#
GetChartOfAccountsAsync

% <
(

< =
string

= C
value

D I
)

I J
;

J K
} 
} Ó
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IBankSortCodesService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface !
IBankSortCodesService '
{ 
Task 
<  
BankSortCodesReadDto !
>! "!
AddBankSortCodesAsync# 8
(8 9"
BankSortCodesCreateDto9 O
valuesP V
)V W
;W X
Task 
<  
BankSortCodesReadDto !
>! "$
UpdateBankSortCodesAsync# ;
(; <"
BankSortCodesUpdateDto< R
valuesS Y
)Y Z
;Z [
Task 
< 
IEnumerable 
<  
BankSortCodesReadDto -
>- .
>. /!
GetBankSortCodesAsync0 E
(E F
)F G
;G H
Task		 
<		  
BankSortCodesReadDto		 !
>		! "!
GetBankSortCodesAsync		# 8
(		8 9
int		9 <
value		= B
)		B C
;		C D
Task

 
<

  
BankSortCodesReadDto

 !
>

! "!
GetBankSortCodesAsync

# 8
(

8 9
string

9 ?
value

@ E
)

E F
;

F G
} 
} Ô

~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IBankService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IBankService 
{ 
Task 
< 
BankReadDto 
> 
AddBankAsync &
(& '
BankCreateDto' 4
values5 ;
); <
;< =
Task 
< 
BankReadDto 
> 
UpdateBankAsync )
() *
BankUpdateDto* 7
values8 >
)> ?
;? @
Task 
< 
IEnumerable 
< 
BankReadDto $
>$ %
>% &
GetBankAsync' 3
(3 4
)4 5
;5 6
Task		 
<		 
BankReadDto		 
>		 
GetBankAsync		 &
(		& '
int		' *
value		+ 0
)		0 1
;		1 2
Task

 
<

 
BankReadDto

 
>

 
GetBankAsync

 &
(

& '
string

' -
value

. 3
)

3 4
;

4 5
} 
} «
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/Setup/IBankBranchService.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &

Interfaces& 0
.0 1
Setup1 6
{ 
public 
	interface 
IBankBranchService $
{ 
Task 
< 
BankBranchReadDto 
> !
CreateBankBranchAsync  5
(5 6
BankBranchCreateDto6 I
valuesJ P
)P Q
;Q R
Task 
< 
BankBranchReadDto 
> !
UpdateBankBranchAsync  5
(5 6
BankBranchUpdateDto6 I
valuesJ P
)P Q
;Q R
Task 
< 
IEnumerable 
< 
BankBranchReadDto *
>* +
>+ ,
GetBankBranchAsync- ?
(? @
)@ A
;A B
Task		 
<		 
BankBranchReadDto		 
>		 
GetBankBranchAsync		  2
(		2 3
int		3 6
value		7 <
)		< =
;		= >
Task

 
<

 
BankBranchReadDto

 
>

 
GetBankBranchAsync

  2
(

2 3
string

3 9
value

: ?
)

? @
;

@ A
} 
} ≠
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/ServicesDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
ServicesDto 
( 
) 
; –	
x/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PaypointsDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
PaypointsReadDto 
( 
int "

PaypointId# -
,- .
string/ 5
Paypoint6 >
)> ?
;? @
public 
record 
PaypointsCreateDto  
(  !
int! $

PaypointId% /
,/ 0
string1 7
Paypoint8 @
,@ A
stringB H
	CreatedByI R
)R S
;S T
public 
record 
PaypointsUpdateDto  
(  !
int! $

PaypointId% /
,/ 0
string1 7
Paypoint8 @
,@ A
stringB H

ModifiedByI S
)S T
;T U
public 
record 
PaypointsDeleteDto  
(  !
int! $

PaypointId% /
)/ 0
;0 1Ú	
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PaymentTypeDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
PaymentTypeReadDto  
(  !
int! $
PaymentTypeId% 2
,2 3
string4 :
PaymentTypes; G
)G H
;H I
public 
record  
PaymentTypeCreateDto "
(" #
int# &
PaymentTypeId' 4
,4 5
string6 <
PaymentTypes= I
,I J
stringK Q
	CreatedByR [
)[ \
;\ ]
public 
record  
PaymentTypeUpdateDto "
(" #
int# &
PaymentTypeId' 4
,4 5
string6 <
PaymentTypes= I
,I J
stringK Q

ModifiedByR \
)\ ]
;] ^
public 
record  
PaymentTypeDeleteDto "
(" #
int# &
PaymentTypeId' 4
)4 5
;5 6ù

z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PaymentModeDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
PaymentModeReadDto  
(  !
int! $
PaymentModeId% 2
,2 3
string4 :
?: ;
PaymentModes< H
)H I
;I J
public 
record  
PaymentModeCreateDto "
(" #
int# &
PaymentModeId' 4
,4 5
string6 <
?< =
PaymentModes> J
,J K
stringL R
	CreatedByS \
)\ ]
;] ^
public 
record  
PaymentModeUpdateDto "
(" #
int# &
PaymentModeId' 4
,4 5
string6 <
?< =
PaymentModes> J
,J K
stringL R
ModifiedS [
)[ \
;\ ]
public 
record  
PaymentModeDeleteDto "
(" #
int# &
PaymentModeId' 4
)4 5
;5 6∏
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/InvoiceTypesDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
{ 
public 

record 
InvoiceTypesReadDto %
(% &
int& )
InvoiceTypesId* 8
,8 9
string: @
InvoiceInitialsA P
,P Q
stringR X
InvoiceDescriptionsY l
,l m
doublen t
InvoiceAmount	u Ç
)
Ç É
;
É Ñ
public 

record !
InvoiceTypesCreateDto '
(' (
int( +
InvoiceTypesId, :
,: ;
string< B
InvoiceInitialsC R
,R S
stringT Z
InvoiceDescriptions[ n
,n o
doublep v
InvoiceAmount	w Ñ
,
Ñ Ö
string
Ü å
	CreatedBy
ç ñ
)
ñ ó
;
ó ò
public 

record !
InvoiceTypesUpdateDto '
(' (
int( +
InvoiceTypesId, :
,: ;
string< B
InvoiceInitialsC R
,R S
stringT Z
InvoiceDescriptions[ n
,n o
doublep v
InvoiceAmount	w Ñ
,
Ñ Ö
string
Ü å

ModifiedBy
ç ó
)
ó ò
;
ò ô
public 

record !
InvoiceTypesDeleteDto '
(' (
int( +
InvoiceTypesId, :
): ;
;; <
}		 æ
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/CurrencyAndExchangeRateDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record *
CurrencyAndExchangeRateReadDto ,
(, -
int- 0

CurrencyId1 ;
,; <
string= C
CurrencyInitialD S
,S T
stringU [
CurrencyName\ h
,h i
doublej p

BuyingRateq {
,{ |
double	} É
SellingRate
Ñ è
,
è ê
bool
ë ï
BaseCurrency
ñ ¢
,
¢ £
DateTime
§ ¨
ApplicableDate
≠ ª
,
ª º
short
Ω ¬
	IsCurrent
√ Ã
)
Ã Õ
;
Õ Œ
public 
record ,
 CurrencyAndExchangeRateCreateDto .
(. /
int/ 2

CurrencyId3 =
,= >
string? E
CurrencyInitialF U
,U V
stringW ]
CurrencyName^ j
,j k
doublel r

BuyingRates }
,} ~
double	 Ö
SellingRate
Ü ë
,
ë í
bool
ì ó
BaseCurrency
ò §
,
§ •
DateTime
¶ Æ
ApplicableDate
Ø Ω
,
Ω æ
short
ø ƒ
	IsCurrent
≈ Œ
,
Œ œ
string
– ÷
	CreatedBy
◊ ‡
)
‡ ·
;
· ‚
public 
record ,
 CurrencyAndExchangeRateUpdateDto .
(. /
int/ 2

CurrencyId3 =
,= >
string? E
CurrencyInitialF U
,U V
stringW ]
CurrencyName^ j
,j k
doublel r

BuyingRates }
,} ~
double	 Ö
SellingRate
Ü ë
,
ë í
bool
ì ó
BaseCurrency
ò §
,
§ •
DateTime
¶ Æ
ApplicableDate
Ø Ω
,
Ω æ
short
ø ƒ
	IsCurrent
≈ Œ
,
Œ œ
string
– ÷

ModifiedBy
◊ ·
)
· ‚
;
‚ „
public 
record ,
 CurrencyAndExchangeRateDeleteDto .
(. /
int/ 2

CurrencyId3 =
)= >
;> ?ü
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/FormsDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
FormsReadDto 
( 
string !
FormCode" *
,* +
string, 2
FormName3 ;
,; <
double= C
AmountD J
,J K
intL O
AccountCodeP [
)[ \
;\ ]
public 
record 
FormsCreateDto 
( 
string #
?# $
FormCode% -
,- .
string/ 5
FormName6 >
,> ?
double@ F
AmountG M
,M N
intO R
AccountCodeS ^
,^ _
string` f
	CreatedByg p
)p q
;q r
public 
record 
FormsUpdateDto 
( 
string #
FormCode$ ,
,, -
string. 4
FormName5 =
,= >
double? E
AmountF L
,L M
intN Q
AccountCodeR ]
,] ^
string_ e

ModifiedByf p
)p q
;q r
public 
record 
FormsDeleteDto 
( 
string #
FormCode$ ,
), -
;- .˚	
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/ChartOfAccountsDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record "
ChartOfAccountsReadDto $
($ %
int% (
AccountCode) 4
,4 5
string6 <
AccountName= H
)H I
;I J
public 
record $
ChartOfAccountsCreateDto &
(& '
int' *
AccountCode+ 6
,6 7
string8 >
AccountName? J
,J K
stringL R
	CreatedByS \
)\ ]
;] ^
public 
record $
ChartOfAccountsUpdateDto &
(& '
int' *
AccountCode+ 6
,6 7
string8 >
AccountName? J
,J K
stringL R

ModifiedByS ]
)] ^
;^ _
public 
record $
ChartOfAccountsDeleteDto &
(& '
int' *
AccountCode+ 6
)6 7
;7 8†
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/BankSortCodesDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record  
BankSortCodesReadDto "
(" #
int# &
Id' )
,) *
string+ 1
SortCode2 :
,: ;
string< B
BankNameC K
,K L
stringM S

BranchNameT ^
)^ _
;_ `
public 
record "
BankSortCodesCreateDto $
($ %
int% (
Id) +
,+ ,
string- 3
SortCode4 <
,< =
string> D
BankNameE M
,M N
stringO U

BranchNameV `
,` a
stringb h
	CreatedByi r
)r s
;s t
public 
record "
BankSortCodesUpdateDto $
($ %
int% (
Id) +
,+ ,
string- 3
SortCode4 <
,< =
string> D
BankNameE M
,M N
stringO U

BranchNameV `
,` a
stringb h

ModifiedByi s
)s t
;t u
public 
record "
BankSortCodesDeleteDto $
($ %
int% (
Id) +
)+ ,
;, -≥	
s/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/BankDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
BankReadDto 
( 
string  
BankId! '
,' (
string) /
BankName0 8
)8 9
;: ;
public 
record 
BankCreateDto 
( 
string "
BankId# )
,) *
string+ 1
BankName2 :
,: ;
string< B
	CreatedByC L
)L M
;M N
public 
record 
BankUpdateDto 
( 
string "
BankId# )
,) *
string+ 1
BankName2 :
,: ;
string< B

ModifiedByC M
)M N
;N O
public 
record 
BankDeleteDto 
( 
string "
BankId# )
)) *
;* +Ç
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/BankBranchDto.cs
	namespace 	
Modules
 
. 
Finance 
. 
Application %
.% &
Dtos& *
.* +
Setup+ 0
;0 1
public 
record 
BankBranchReadDto 
(  
string  &
BankId' -
,- .
string/ 5
BranchId6 >
,> ?
string@ F

BranchNameG Q
)Q R
;S T
public 
record 
BankBranchCreateDto !
(! "
string" (
BankId) /
,/ 0
string1 7
BranchId8 @
,@ A
stringB H

BranchNameI S
,S T
stringT Z
	CreatedBy[ d
)d e
;e f
public 
record 
BankBranchUpdateDto !
(! "
string" (
BankId) /
,/ 0
string1 7
BranchId8 @
,@ A
stringB H

BranchNameI S
,S T
stringT Z

ModifiedBy[ e
)e f
;f g
public 
record 
BankBranchDeleteDto !
(! "
string" (
BankId) /
)/ 0
;0 1