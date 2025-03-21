ß
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Property/LocalityDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Property8 @
;@ A
public 
class  
LocalityDtoValidator !
:" #
AbstractValidator$ 5
<5 6
LocalityCreateDto6 G
>G H
{ 
public 
 
LocalityDtoValidator 
(  
)  !
{		 
RuleFor

 
(

 
x

 
=>

 
x

 
.

 

LocalityId

 !
)

! "
.

" # 
GreaterThanOrEqualTo

# 7
(

7 8
$num

8 9
)

9 :
;

: ;
RuleFor 
( 
x 
=> 
x 
. 
LocalityInitial &
)& '
.' (
NotEmpty( 0
(0 1
)1 2
.2 3
MaximumLength3 @
(@ A
$numA B
)B C
.C D
WithMessageD O
(O P
$str	P ã
)
ã å
;
å ç
RuleFor 
( 
x 
=> 
x 
. 
LocalityName #
)# $
.$ %
NotEmpty% -
(- .
). /
./ 0
MaximumLength0 =
(= >
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N Ä
)
Ä Å
;
Å Ç
RuleFor 
( 
x 
=> 
x 
. 
	CreatedBy  
)  !
.! "
Length" (
(( )
$num) +
)+ ,
., -
WithMessage- 8
(8 9
$str9 p
)p q
;q r
} 
} Û
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/TitleDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class 
TitleDtoValidator 
:  !
AbstractValidator" 3
<3 4
TitleCreateDto4 B
>B C
{ 
public 
TitleDtoValidator	 
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
 
titleId

 "
)

" #
.

# $ 
GreaterThanOrEqualTo

$ 8
(

8 9
$num

9 :
)

: ;
;

; <
RuleFor 
( 
x 
=> 
x 
. 
titles !
)! "
." #
NotEmpty# +
(+ ,
), -
.- .
WithMessage. 9
(9 :
$str: M
)M N
;N O
RuleFor 
( 
x 
=> 
x 
. 
titles !
)! "
." #
MaximumLength# 0
(0 1
$num1 3
)3 4
.4 5
WithMessage5 @
(@ A
$strA k
)k l
;l m
RuleFor 
( 
x 
=> 
x 
. 
	createdby $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} Æ
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/SocialMediaDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class #
SocialMediaDtoValidator %
:& '
AbstractValidator( 9
<9 : 
SocialMediaCreateDto: N
>N O
{ 
public #
SocialMediaDtoValidator	  
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
SocialMediaId
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
. 
SocialMediaPlatform .
). /
./ 0
NotEmpty0 8
(8 9
)9 :
.: ;
WithMessage; F
(F G
$strG a
)a b
;b c
RuleFor 
( 
x 
=> 
x 
. 
SocialMediaPlatform .
). /
./ 0
MaximumLength0 =
(= >
$num> @
)@ A
.A B
WithMessageB M
(M N
$strN 
)	 Ä
;
Ä Å
RuleFor 
( 
x 
=> 
x 
. 
	CreatedBy $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} §
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/ResidentTypeDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class $
ResidentTypeDtoValidator &
:' (
AbstractValidator) :
<: ;!
ResidentTypeCreateDto; P
>P Q
{ 
public $
ResidentTypeDtoValidator	 !
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
 
residentTypeId

 )
)

) *
.

* + 
GreaterThanOrEqualTo

+ ?
(

? @
$num

@ A
)

A B
;

B C
RuleFor 
( 
x 
=> 
x 
. 
residentTypes (
)( )
.) *
NotEmpty* 2
(2 3
)3 4
.4 5
WithMessage5 @
(@ A
$strA \
)\ ]
;] ^
RuleFor 
( 
x 
=> 
x 
. 
residentTypes (
)( )
.) *
MaximumLength* 7
(7 8
$num8 :
): ;
.; <
WithMessage< G
(G H
$strH z
)z {
;{ |
RuleFor 
( 
x 
=> 
x 
. 
	createdBy $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} ¨
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/OwnershipTypeDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class %
OwnershipTypeDtoValidator '
:( )
AbstractValidator* ;
<; <"
OwnershipTypeCreateDto< R
>R S
{ 
public %
OwnershipTypeDtoValidator	 "
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
 
ownershipTypeId

 *
)

* +
.

+ , 
GreaterThanOrEqualTo

, @
(

@ A
$num

A B
)

B C
;

C D
RuleFor 
( 
x 
=> 
x 
. 
ownershipTypeId *
)* +
.+ ,
NotEmpty, 4
(4 5
)5 6
.6 7
WithMessage7 B
(B C
$strC _
)_ `
;` a
RuleFor 
( 
x 
=> 
x 
. 
ownershipTypes )
)) *
.* +
MaximumLength+ 8
(8 9
$num9 ;
); <
.< =
WithMessage= H
(H I
$strI |
)| }
;} ~
RuleFor 
( 
x 
=> 
x 
. 
	createdby $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} ü
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/NationalityDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class #
NationalityDtoValidator %
:& '
AbstractValidator( 9
<9 : 
NationalityCreateDto: N
>N O
{ 
public #
NationalityDtoValidator	  
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
nationalityId
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
. 
nationalities (
)( )
.) *
NotEmpty* 2
(2 3
)3 4
.4 5
WithMessage5 @
(@ A
$strA Z
)Z [
;[ \
RuleFor 
( 
x 
=> 
x 
. 
nationalities (
)( )
.) *
MaximumLength* 7
(7 8
$num8 :
): ;
.; <
WithMessage< G
(G H
$strH x
)x y
;y z
RuleFor 
( 
x 
=> 
x 
. 
	createdby $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} ”
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/IdentificationTypeDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class *
IdentificationTypeDtoValidator ,
:- .
AbstractValidator/ @
<@ A'
IdentificationTypeCreateDtoA \
>\ ]
{ 
public *
IdentificationTypeDtoValidator	 '
(' (
)( )
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
  
identificationTypeId

 /
)

/ 0
.

0 1 
GreaterThanOrEqualTo

1 E
(

E F
$num

F G
)

G H
;

H I
RuleFor 
( 
x 
=> 
x 
. 
identificationTypes .
). /
./ 0
NotEmpty0 8
(8 9
)9 :
.: ;
WithMessage; F
(F G
$strG h
)h i
;i j
RuleFor 
( 
x 
=> 
x 
. 
identificationTypes .
). /
./ 0
MaximumLength0 =
(= >
$num> @
)@ A
.A B
WithMessageB M
(M N
$str	N Ü
)
Ü á
;
á à
RuleFor 
( 
x 
=> 
x 
. 
	createdBy $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} Ä
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/GenderDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class 
GenderDtoValidator  
:! "
AbstractValidator# 4
<4 5
GenderCreateDto5 D
>D E
{ 
public 
GenderDtoValidator	 
( 
) 
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
genderId

 #
)

# $
.

$ % 
GreaterThanOrEqualTo

% 9
(

9 :
$num

: ;
)

; <
;

< =
RuleFor 
( 
x 
=> 
x 
. 

genderType %
)% &
.& '
NotEmpty' /
(/ 0
)0 1
.1 2
WithMessage2 =
(= >
$str> R
)R S
;S T
RuleFor 
( 
x 
=> 
x 
. 

genderType %
)% &
.& '
MaximumLength' 4
(4 5
$num5 7
)7 8
.8 9
WithMessage9 D
(D E
$strE p
)p q
;q r
RuleFor 
( 
x 
=> 
x 
. 
	createdBy $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} §
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Validations/Setup/Customer/CustomerTypeDtoValidator.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Validations& 1
.1 2
Setup2 7
.7 8
Customer8 @
{ 
public 
class $
CustomerTypeDtoValidator &
:' (
AbstractValidator) :
<: ;!
CustomerTypeCreateDto; P
>P Q
{ 
public $
CustomerTypeDtoValidator	 !
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
 
customerTypeId

 )
)

) *
.

* + 
GreaterThanOrEqualTo

+ ?
(

? @
$num

@ A
)

A B
;

B C
RuleFor 
( 
x 
=> 
x 
. 
customerTypes (
)( )
.) *
NotEmpty* 2
(2 3
)3 4
.4 5
WithMessage5 @
(@ A
$strA \
)\ ]
;] ^
RuleFor 
( 
x 
=> 
x 
. 
customerTypes (
)( )
.) *
MaximumLength* 7
(7 8
$num8 :
): ;
.; <
WithMessage< G
(G H
$strH z
)z {
;{ |
RuleFor 
( 
x 
=> 
x 
. 
	createdBy $
)$ %
.% &
Length& ,
(, -
$num- /
)/ 0
.0 1
WithMessage1 <
(< =
$str= t
)t u
;u v
} 	
} 
} i
g/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Usings.cs–/
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
PropertyTypeService  
:  ! 
IPropertyTypeService" 6
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

PropertyTypeService 
( 
IUnitOfWork *

unitOfWork+ 5
,5 6
IMapper7 >
mapper? E
)E F
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
PropertyTypeReadDto )
>) * 
AddPropertyTypeAsync+ ?
(? @!
PropertyTypeCreateDto@ U
valuesV \
)\ ]
{ 
PropertyType 
propertyType !
=" #
new$ '
(' (
values( .
.. /
PropertyTypeId/ =
,= >
values? E
.E F
PropertyTypesF S
!S T
)T U
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
PropertyType  
.  !
Insert! '
(' (
propertyType( 4
)4 5
;5 6
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
PropertyTypeReadDto &
(& '
propertyType' 3
.3 4
PropertyTypeId4 B
,B C
propertyTypeD P
.P Q
PropertyTypesQ ^
!^ _
)_ `
;` a
} 
public 

async 
Task 
< 
IEnumerable !
<! "
PropertyTypeReadDto" 5
>5 6
>6 7 
GetPropertyTypeAsync8 L
(L M
)M N
{ 
var 
propertyType 
= 
await  
_unitOfWork! ,
., -
PropertyType- 9
.9 :
GetAll: @
(@ A
)A B
;B C
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
PropertyTypeReadDto' :
>: ;
>; <
(< =
propertyType= I
)I J
;J K
}   
public"" 

async"" 
Task"" 
<"" 
PropertyTypeReadDto"" )
>"") * 
GetPropertyTypeAsync""+ ?
(""? @
int""@ C
value""D I
)""I J
{## 
var$$ 
propertyType$$ 
=$$ 
await$$  
_unitOfWork$$! ,
.$$, -
PropertyType$$- 9
.$$9 :
Get$$: =
($$= >
value$$> C
)$$C D
;$$D E
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
PropertyTypeReadDto%% .
>%%. /
(%%/ 0
propertyType%%0 <
)%%< =
;%%= >
}&& 
public(( 

async(( 
Task(( 
<(( 
PropertyTypeReadDto(( )
>(() * 
GetPropertyTypeAsync((+ ?
(((? @
string((@ F
value((G L
)((L M
{)) 
var** 
propertyType** 
=** 
await**  
_unitOfWork**! ,
.**, -
PropertyType**- 9
.**9 :
Get**: =
(**= >
p**> ?
=>**@ B
p**C D
.**D E
PropertyTypes**E R
==**S U
value**V [
)**[ \
;**\ ]
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
PropertyTypeReadDto++ .
>++. /
(++/ 0
propertyType++0 <
)++< =
;++= >
},, 
public.. 

async.. 
Task.. 
<.. 
PropertyTypeReadDto.. )
>..) *#
UpdatePropertyTypeAsync..+ B
(..B C!
PropertyTypeUpdateDto..C X
values..Y _
).._ `
{// 
PropertyType11 
propertyType11 !
=11" #
new11$ '
(11' (
values11( .
.11. /
PropertyTypeId11/ =
,11= >
values11? E
.11E F
PropertyTypes11F S
!11S T
)11T U
{22 	

ModifiedBy33 
=33 
values33 
.33  

ModifiedBy33  *
,33* +

ModifiedOn44 
=44 
DateTime44 !
.44! "
Now44" %
}55 	
;55	 

_unitOfWork77 
.77 
PropertyType77  
.77  !
Update77! '
(77' (
propertyType77( 4
)774 5
;775 6
await88 
_unitOfWork88 
.88 
Complete88 "
(88" #
)88# $
;88$ %
return:: 
new:: 
PropertyTypeReadDto:: &
(::& '
propertyType::' 3
.::3 4
PropertyTypeId::4 B
,::B C
propertyType::D P
.::P Q
PropertyTypes::Q ^
!::^ _
)::_ `
;::` a
};; 
}>> Ñ0
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyHeightService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class !
PropertyHeightService "
:" #"
IPropertyHeightService$ :
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 
!
PropertyHeightService  
(  !
IUnitOfWork! ,

unitOfWork- 7
,7 8
IMapper9 @
mapperA G
)G H
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< !
PropertyHeightReadDto +
>+ ,"
AddPropertyHeightAsync- C
(C D#
PropertyHeightCreateDtoD [
values\ b
)b c
{ 
PropertyHeight 
input_values #
=$ %
new& )
() *
values* 0
.0 1
propertyHeightId1 A
,A B
valuesC I
.I J
propertyHeightsJ Y
!Y Z
)Z [
{ 	
	CreatedBy 
= 
values 
. 
	createdBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
PropertyHeight "
." #
Insert# )
() *
input_values* 6
)6 7
;7 8
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new !
PropertyHeightReadDto (
(( )
input_values) 5
.5 6
PropertyHeightId6 F
,F G
input_valuesH T
.T U
PropertyHeightsU d
!d e
)e f
;f g
} 
public 

async 
Task 
< 
IEnumerable !
<! "!
PropertyHeightReadDto" 7
>7 8
>8 9"
GetPropertyHeightAsync: P
(P Q
)Q R
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
PropertyHeight) 7
.7 8
GetAll8 >
(> ?
)? @
;@ A
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '!
PropertyHeightReadDto' <
>< =
>= >
(> ?
response? G
)G H
;H I
}   
public"" 

async"" 
Task"" 
<"" !
PropertyHeightReadDto"" +
>""+ ,"
GetPropertyHeightAsync""- C
(""C D
int""D G
value""H M
)""M N
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
PropertyHeight$$) 7
.$$7 8
Get$$8 ;
($$; <
value$$< A
)$$A B
;$$B C
return%% 
_mapper%% 
.%% 
Map%% 
<%% !
PropertyHeightReadDto%% 0
>%%0 1
(%%1 2
response%%2 :
)%%: ;
;%%; <
}&& 
public(( 

async(( 
Task(( 
<(( !
PropertyHeightReadDto(( +
>((+ ,"
GetPropertyHeightAsync((- C
(((C D
string((D J
value((K P
)((P Q
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )
PropertyHeight**) 7
.**7 8
Get**8 ;
(**; <
ph**< >
=>**? A
ph**B D
.**D E
PropertyHeights**E T
==**U W
value**X ]
)**] ^
;**^ _
return++ 
_mapper++ 
.++ 
Map++ 
<++ !
PropertyHeightReadDto++ 0
>++0 1
(++1 2
response++2 :
)++: ;
;++; <
},, 
public.. 

async.. 
Task.. 
<.. !
PropertyHeightReadDto.. +
>..+ ,%
UpdatePropertyHeightAsync..- F
(..F G#
PropertyHeightUpdateDto..G ^
values.._ e
)..e f
{// 
PropertyHeight00 
input_values00 #
=00$ %
new00& )
(00) *
values00* 0
.000 1
propertyHeightId001 A
,00A B
values00C I
.00I J
propertyHeights00J Y
!00Y Z
)00Z [
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedBy22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
PropertyHeight66 "
.66" #
Update66# )
(66) *
input_values66* 6
)666 7
;667 8
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 !
PropertyHeightReadDto99 (
(99( )
input_values99) 5
.995 6
PropertyHeightId996 F
,99F G
input_values99H T
.99T U
PropertyHeights99U d
!99d e
)99e f
;99f g
}:: 
};; Ñ.
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PlotSizeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
PlotSizeService 
: 
IPlotSizeService /
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

PlotSizeService 
( 
IUnitOfWork &

unitOfWork' 1
,1 2
IMapper3 :
mapper; A
)A B
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
PlotSizeReadDto %
>% &
AddPlotSizeAsync' 7
(7 8
PlotSizeCreateDto8 I
valuesJ P
)P Q
{ 
PlotSize 
plotSize 
= 
new 
(  
values  &
.& '

PlotSizeId' 1
,1 2
values3 9
.9 :
	PlotSizes: C
!C D
)D E
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
PlotSize 
. 
Insert #
(# $
plotSize$ ,
), -
;- .
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
PlotSizeReadDto "
(" #
plotSize# +
.+ ,

PlotSizeId, 6
,6 7
plotSize8 @
.@ A
	PlotSizesA J
!J K
)K L
;L M
} 
public 

async 
Task 
< 
IEnumerable !
<! "
PlotSizeReadDto" 1
>1 2
>2 3
GetPlotSizeAsync4 D
(D E
)E F
{ 
var 
plotSize 
= 
await 
_unitOfWork (
.( )
PlotSize) 1
.1 2
GetAll2 8
(8 9
)9 :
;: ;
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
PlotSizeReadDto' 6
>6 7
>7 8
(8 9
plotSize9 A
)A B
;B C
}   
public"" 

async"" 
Task"" 
<"" 
PlotSizeReadDto"" %
>""% &
GetPlotSizeAsync""' 7
(""7 8
int""8 ;
value""< A
)""A B
{## 
var$$ 
plotSize$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
PlotSize$$) 1
.$$1 2
Get$$2 5
($$5 6
value$$6 ;
)$$; <
;$$< =
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
PlotSizeReadDto%% *
>%%* +
(%%+ ,
plotSize%%, 4
)%%4 5
;%%5 6
}&& 
public(( 

async(( 
Task(( 
<(( 
PlotSizeReadDto(( %
>((% &
GetPlotSizeAsync((' 7
(((7 8
string((8 >
value((? D
)((D E
{)) 
var** 
plotSize** 
=** 
await** 
_unitOfWork** (
.**( )
PlotSize**) 1
.**1 2
Get**2 5
(**5 6
p**6 7
=>**8 :
p**; <
.**< =
	PlotSizes**= F
==**G I
value**J O
)**O P
;**P Q
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
PlotSizeReadDto++ *
>++* +
(+++ ,
plotSize++, 4
)++4 5
;++5 6
},, 
public.. 

async.. 
Task.. 
<.. 
PlotSizeReadDto.. %
>..% &
UpdatePlotSizeAsync..' :
(..: ;
PlotSizeUpdateDto..; L
values..M S
)..S T
{// 
PlotSize00 
plotSize00 
=00 
new00 
(00  
values00  &
.00& '

PlotSizeId00' 1
,001 2
values003 9
.009 :
	PlotSizes00: C
!00C D
)00D E
{11 	

ModifiedBy22 
=22 
values22 
.22  

ModifiedBy22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
PlotSize66 
.66 
Update66 #
(66# $
plotSize66$ ,
)66, -
;66- .
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
PlotSizeReadDto99 "
(99" #
plotSize99# +
.99+ ,

PlotSizeId99, 6
,996 7
plotSize998 @
.99@ A
	PlotSizes99A J
!99J K
)99K L
;99L M
}:: 
};; í=
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LocalityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
LocalityService 
: 
ILocalityService /
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

LocalityService 
( 
IUnitOfWork &

unitOfWork' 1
,1 2
IMapper3 :
mapper; A
)A B
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
LocalityReadDto %
>% &
CreateLocalityAsync' :
(: ;
LocalityCreateDto; L
valuesM S
)S T
{ 
Locality 
locality 
= 
new 
(  
values  &
.& '

LocalityId' 1
,1 2
values3 9
.9 :
LocalityInitial: I
!I J
,J K
valuesL R
.R S
LocalityNameS _
!_ `
,` a
valuesa g
.g h
CustomerCodeh t
,t u
valuesv |
.| } 
CustomerCodeCounter	} ê
)
ê ë
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
Locality 
. 
Insert #
(# $
locality$ ,
), -
;- .
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
LocalityReadDto "
(" #
locality# +
.+ ,

LocalityId, 6
,6 7
locality8 @
.@ A
LocalityInitialA P
!P Q
,Q R
localityS [
.[ \
LocalityName\ h
!h i
,i j
localityk s
.s t
CustomerCode	t Ä
!
Ä Å
,
Å Ç
locality
É ã
.
ã å!
CustomerCodeCounter
å ü
)
ü †
;
† °
} 
public 

async 
Task 
< 
IEnumerable !
<! "
LocalityReadDto" 1
>1 2
>2 3
GetLocalityAsync4 D
(D E
)E F
{ 
var 

localities 
= 
await 
_unitOfWork *
.* +
Locality+ 3
.3 4
GetAll4 :
(: ;
); <
;< =
return   
_mapper   
.   
Map   
<   
IEnumerable   &
<  & '
LocalityReadDto  ' 6
>  6 7
>  7 8
(  8 9

localities  9 C
)  C D
;  D E
}!! 
public## 

async## 
Task## 
<## 
LocalityReadDto## %
>##% &
GetLocalityAsync##' 7
(##7 8
int##8 ;
value##< A
)##A B
{$$ 
var%% 

localities%% 
=%% 
await%% 
_unitOfWork%% *
.%%* +
Locality%%+ 3
.%%3 4
Get%%4 7
(%%7 8
value%%8 =
)%%= >
;%%> ?
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
LocalityReadDto&& *
>&&* +
(&&+ ,

localities&&, 6
)&&6 7
;&&7 8
}'' 
public)) 

async)) 
Task)) 
<)) 
LocalityReadDto)) %
>))% &
GetLocalityAsync))' 7
())7 8
string))8 >
value))? D
)))D E
{** 
var++ 

localities++ 
=++ 
await++ 
_unitOfWork++ *
.++* +
Locality+++ 3
.++3 4
Get++4 7
(++7 8
l++8 9
=>++: <
l++= >
.++> ?
LocalityInitial++? N
==++O Q
value++R W
||++X Z
l++[ \
.++\ ]
LocalityName++] i
==++j l
value++m r
)++r s
;++s t
return,, 
_mapper,, 
.,, 
Map,, 
<,, 
LocalityReadDto,, *
>,,* +
(,,+ ,

localities,,, 6
),,6 7
;,,7 8
}-- 
public// 

async// 
Task// 
<// 
LocalityReadDto// %
>//% &
UpdateLocalityAsync//' :
(//: ;
LocalityUpdateDto//; L
values//M S
)//S T
{00 
Locality11 
locality11 
=11 
new11 
(11  
values11  &
.11& '

LocalityId11' 1
,111 2
values113 9
.119 :
LocalityInitial11: I
!11I J
,11J K
values11L R
.11R S
LocalityName11S _
!11_ `
,11` a
values11b h
.11h i
CustomerCode11i u
,11u v
values11w }
.11} ~ 
CustomerCodeCounter	11~ ë
)
11ë í
{22 	

ModifiedBy33 
=33 
values33 
.33  

ModifiedBy33  *
,33* +

ModifiedOn44 
=44 
DateTime44 !
.44! "
Now44" %
}55 	
;55	 

_unitOfWork77 
.77 
Locality77 
.77 
Update77 #
(77# $
locality77$ ,
)77, -
;77- .
await88 
_unitOfWork88 
.88 
Complete88 "
(88" #
)88# $
;88$ %
return:: 
new:: 
LocalityReadDto:: "
(::" #
locality::# +
.::+ ,

LocalityId::, 6
,::6 7
locality::8 @
.::@ A
LocalityInitial::A P
!::P Q
,::Q R
locality::S [
.::[ \
LocalityName::\ h
!::h i
,::i j
locality::k s
.::s t
CustomerCode	::t Ä
!
::Ä Å
,
::Å Ç
locality
::É ã
.
::ã å!
CustomerCodeCounter
::å ü
)
::ü †
;
::† °
}<< 
public>> 

async>> 
Task>> 
<>> 
string>> 
>>> 
DeleteLocality>> ,
(>>, -
int>>- 0

localityId>>1 ;
)>>; <
{?? 
var@@ 
locality@@ 
=@@ 
await@@ 
_unitOfWork@@ (
.@@( )
Locality@@) 1
.@@1 2
Get@@2 5
(@@5 6

localityId@@6 @
)@@@ A
;@@A B
_unitOfWorkAA 
.AA 
LocalityAA 
.AA 
DeleteAA #
(AA# $
localityAA$ ,
!AA, -
)AA- .
;AA. /
returnBB 
$strBB 
;BB 
}CC 
}EE ˇ5
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LandUseTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
LandUseTypeService 
:  !
ILandUseTypeService" 5
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

LandUseTypeService 
( 
IUnitOfWork )

unitOfWork* 4
,4 5
IMapper6 =
mapper> D
)D E
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
LandUseTypeReadDto (
>( )
AddLandUseTypeAsync* =
(= > 
LandUseTypeCreateDto> R
valuesS Y
)Y Z
{ 
LandUseType 
landuseType 
=  !
new" %
(% &
values& ,
., -
	LandUseId- 6
,6 7
values8 >
.> ?
LandUseTypeId? L
,L M
valuesN T
.T U
LandUseTypeInitialU g
!g h
,h i
valuesj p
.p q
LandUseTypeName	q Ä
!
Ä Å
)
Å Ç
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
LandUseType 
.  
Insert  &
(& '
landuseType' 2
)2 3
;3 4
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
LandUseTypeReadDto %
(% &
landuseType& 1
.1 2
	LandUseId2 ;
,; <
landuseType= H
.H I
LandUseTypeIdI V
,V W
landuseTypeX c
.c d
LandUseTypeInitiald v
!v w
,w x
landuseType	y Ñ
.
Ñ Ö
LandUseTypeName
Ö î
!
î ï
)
ï ñ
;
ñ ó
} 
public 

async 
Task 
< 
IEnumerable !
<! "
LandUseTypeReadDto" 4
>4 5
>5 6
GetLandUseTypeAsync7 J
(J K
)K L
{ 
var 
landuseType 
= 
await 
_unitOfWork  +
.+ ,
LandUseType, 7
.7 8
GetAll8 >
(> ?
)? @
;@ A
return   
_mapper   
.   
Map   
<   
IEnumerable   &
<  & '
LandUseTypeReadDto  ' 9
>  9 :
>  : ;
(  ; <
landuseType  < G
)  G H
;  H I
}!! 
public## 

async## 
Task## 
<## 
LandUseTypeReadDto## (
>##( )
GetLandUseTypeAsync##* =
(##= >
int##> A
value##B G
)##G H
{$$ 
var%% 
landuseType%% 
=%% 
await%% 
_unitOfWork%%  +
.%%+ ,
LandUseType%%, 7
.%%7 8
Get%%8 ;
(%%; <
value%%< A
)%%A B
;%%B C
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
LandUseTypeReadDto&& -
>&&- .
(&&. /
landuseType&&/ :
)&&: ;
;&&; <
}'' 
public)) 

async)) 
Task)) 
<)) 
LandUseTypeReadDto)) (
>))( )
GetLandUseTypeAsync))* =
())= >
string))> D
value))E J
)))J K
{** 
var++ 
landuseType++ 
=++ 
await++ 
_unitOfWork++  +
.+++ ,
LandUseType++, 7
.++7 8
Get++8 ;
(++; <
lt++< >
=>++? A
lt++B D
.++D E
LandUseTypeInitial++E W
==++X Z
value++[ `
||++a c
lt++d f
.++f g
LandUseTypeName++g v
==++w y
value++z 
)	++ Ä
;
++Ä Å
return,, 
_mapper,, 
.,, 
Map,, 
<,, 
LandUseTypeReadDto,, -
>,,- .
(,,. /
landuseType,,/ :
),,: ;
;,,; <
}-- 
public// 

async// 
Task// 
<// 
LandUseTypeReadDto// (
>//( )"
UpdateLandUseTypeAsync//* @
(//@ A 
LandUseTypeUpdateDto//A U
values//V \
)//\ ]
{00 
LandUseType11 
landuseType11 
=11  !
new11" %
(11% &
values11& ,
.11, -
	LandUseId11- 6
,116 7
values118 >
.11> ?
LandUseTypeId11? L
,11L M
values11N T
.11T U
LandUseTypeInitial11U g
!11g h
,11h i
values11j p
.11p q
LandUseTypeName	11q Ä
!
11Ä Å
)
11Å Ç
{22 	

ModifiedBy33 
=33 
values33 
.33  

ModifiedBy33  *
,33* +

ModifiedOn44 
=44 
DateTime44 !
.44! "
Now44" %
}55 	
;55	 

_unitOfWork77 
.77 
LandUseType77 
.77  
Update77  &
(77& '
landuseType77' 2
)772 3
;773 4
await88 
_unitOfWork88 
.88 
Complete88 "
(88" #
)88# $
;88$ %
return:: 
new:: 
LandUseTypeReadDto:: %
(::% &
landuseType::& 1
.::1 2
	LandUseId::2 ;
,::; <
landuseType::= H
.::H I
LandUseTypeId::I V
,::V W
landuseType::X c
.::c d
LandUseTypeInitial::d v
!::v w
,::w x
landuseType	::y Ñ
.
::Ñ Ö
LandUseTypeName
::Ö î
!
::î ï
)
::ï ñ
;
::ñ ó
};; 
}== √1
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LandUseService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
LandUseService 
: 
ILandUseService -
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

LandUseService 
( 
IUnitOfWork %

unitOfWork& 0
,0 1
IMapper2 9
mapper: @
)@ A
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
LandUseReadDto $
>$ %
AddLandUseAsync& 5
(5 6
LandUseCreateDto6 F
valuesG M
)M N
{ 
LandUse 
landUse 
= 
new 
( 
values $
.$ %
	LandUseId% .
,. /
values0 6
.6 7
LandUseInitial7 E
!E F
,F G
valuesH N
.N O
LandUseNameO Z
!Z [
)[ \
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
LandUse 
. 
Insert "
(" #
landUse# *
)* +
;+ ,
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
LandUseReadDto !
(! "
landUse" )
.) *
	LandUseId* 3
,3 4
landUse5 <
.< =
LandUseInitial= K
!K L
,L M
landUseN U
.U V
LandUseNameV a
!a b
)b c
;c d
} 
public 

async 
Task 
< 
IEnumerable !
<! "
LandUseReadDto" 0
>0 1
>1 2
GetLandUseAsync3 B
(B C
)C D
{ 
var 
landuse 
= 
await 
_unitOfWork '
.' (
LandUse( /
./ 0
GetAll0 6
(6 7
)7 8
;8 9
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
LandUseReadDto' 5
>5 6
>6 7
(7 8
landuse8 ?
)? @
;@ A
}   
public"" 

async"" 
Task"" 
<"" 
LandUseReadDto"" $
>""$ %
GetLandUseAsync""& 5
(""5 6
int""6 9
value"": ?
)""? @
{## 
var$$ 
landuse$$ 
=$$ 
await$$ 
_unitOfWork$$ '
.$$' (
LandUse$$( /
.$$/ 0
Get$$0 3
($$3 4
value$$4 9
)$$9 :
;$$: ;
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
LandUseReadDto%% )
>%%) *
(%%* +
landuse%%+ 2
)%%2 3
;%%3 4
}&& 
public(( 

async(( 
Task(( 
<(( 
LandUseReadDto(( $
>(($ %
GetLandUseAsync((& 5
(((5 6
string((6 <
value((= B
)((B C
{)) 
var** 
landuse** 
=** 
await** 
_unitOfWork** '
.**' (
LandUse**( /
.**/ 0
Get**0 3
(**3 4
l**4 5
=>**6 8
l**9 :
.**: ;
LandUseInitial**; I
==**J L
value**M R
||**S U
l**V W
.**W X
LandUseName**X c
==**d f
value**g l
)**l m
;**m n
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
LandUseReadDto++ )
>++) *
(++* +
landuse+++ 2
)++2 3
;++3 4
},, 
public.. 

async.. 
Task.. 
<.. 
LandUseReadDto.. $
>..$ %
UpdateLandUseAsync..& 8
(..8 9
LandUseUpdateDto..9 I
values..J P
)..P Q
{// 
LandUse00 
landUse00 
=00 
new00 
(00 
values00 $
.00$ %
	LandUseId00% .
,00. /
values000 6
.006 7
LandUseInitial007 E
!00E F
,00F G
values00H N
.00N O
LandUseName00O Z
!00Z [
)00[ \
{11 	

ModifiedBy22 
=22 
values22 
.22  

ModifiedBy22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
LandUse66 
.66 
Update66 "
(66" #
landUse66# *
)66* +
;66+ ,
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
LandUseReadDto99 !
(99! "
landUse99" )
.99) *
	LandUseId99* 3
,993 4
landUse995 <
.99< =
LandUseInitial99= K
!99K L
,99L M
landUse99N U
.99U V
LandUseName99V a
!99a b
)99b c
;99c d
};; 
}>> ‚/
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FloorNumberingService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class !
FloorNumberingService "
:" #"
IFloorNumberingService$ :
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 
!
FloorNumberingService  
(  !
IUnitOfWork! ,

unitOfWork- 7
,7 8
IMapper9 @
mapperA G
)G H
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< !
FloorNumberingReadDto +
>+ ,"
AddFloorNumberingAsync- C
(C D#
FloorNumberingCreateDtoD [
values\ b
)b c
{ 
FloorNumbering 
input_values #
=$ %
new& )
() *
values* 0
.0 1
floorNumberId1 >
,> ?
values@ F
.F G
floorNumberG R
!R S
)S T
{ 	
	CreatedBy 
= 
values 
. 
	createdby (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
FloorNumbering "
." #
Insert# )
() *
input_values* 6
)6 7
;7 8
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new !
FloorNumberingReadDto (
(( )
input_values) 5
.5 6
FloorNumberId6 C
,C D
input_valuesE Q
.Q R
FloorNumberR ]
!] ^
)^ _
;_ `
} 
public 

async 
Task 
< 
IEnumerable !
<! "!
FloorNumberingReadDto" 7
>7 8
>8 9"
GetFloorNumberingAsync: P
(P Q
)Q R
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
FloorNumbering) 7
.7 8
GetAll8 >
(> ?
)? @
;@ A
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '!
FloorNumberingReadDto' <
>< =
>= >
(> ?
response? G
)G H
;H I
}   
public"" 

async"" 
Task"" 
<"" !
FloorNumberingReadDto"" +
>""+ ,"
GetFloorNumberingAsync""- C
(""C D
int""D G
value""H M
)""M N
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
FloorNumbering$$) 7
.$$7 8
Get$$8 ;
($$; <
value$$< A
)$$A B
;$$B C
return%% 
_mapper%% 
.%% 
Map%% 
<%% !
FloorNumberingReadDto%% 0
>%%0 1
(%%1 2
response%%2 :
)%%: ;
;%%; <
}&& 
public(( 

async(( 
Task(( 
<(( !
FloorNumberingReadDto(( +
>((+ ,"
GetFloorNumberingAsync((- C
(((C D
string((D J
value((K P
)((P Q
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )
FloorNumbering**) 7
.**7 8
Get**8 ;
(**; <
fn**< >
=>**? A
fn**B D
.**D E
FloorNumber**E P
==**Q S
value**T Y
)**Y Z
;**Z [
return++ 
_mapper++ 
.++ 
Map++ 
<++ !
FloorNumberingReadDto++ 0
>++0 1
(++1 2
response++2 :
)++: ;
;++; <
},, 
public.. 

async.. 
Task.. 
<.. !
FloorNumberingReadDto.. +
>..+ ,%
UpdateFloorNumberingAsync..- F
(..F G#
FloorNumberingUpdateDto..G ^
values.._ e
)..e f
{// 
FloorNumbering00 
input_values00 #
=00$ %
new00& )
(00) *
values00* 0
.000 1
floorNumberId001 >
,00> ?
values00@ F
.00F G
floorNumber00G R
!00R S
)00S T
{11 	

ModifiedBy22 
=22 
values22 
.22  
modified22  (
,22( )

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
FloorNumbering66 "
.66" #
Update66# )
(66) *
input_values66* 6
)666 7
;667 8
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 !
FloorNumberingReadDto99 (
(99( )
input_values99) 5
.995 6
FloorNumberId996 C
,99C D
input_values99E Q
.99Q R
FloorNumber99R ]
!99] ^
)99^ _
;99_ `
}:: 
};; ◊.
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FacilitiesService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
FacilitiesService 
: 
IFacilitiesService  2
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

FacilitiesService 
( 
IUnitOfWork (

unitOfWork) 3
,3 4
IMapper5 <
mapper= C
)C D
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
FacilitiesReadDto '
>' (
AddFacilitiesAsync) ;
(; <
FacilitiesCreateDto< O
valuesP V
)V W
{ 

Facilities 
input_values 
=  !
new" %
(% &
values& ,
., -

facilityId- 7
,7 8
values9 ?
.? @
facility@ H
!H I
)I J
{ 	
	CreatedBy 
= 
values 
. 
	createdBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 

Facilities 
. 
Insert %
(% &
input_values& 2
)2 3
;3 4
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
FacilitiesReadDto $
($ %
input_values% 1
.1 2

FacilityId2 <
,< =
input_values> J
.J K
FacilityK S
!S T
)T U
;U V
} 
public 

async 
Task 
< 
IEnumerable !
<! "
FacilitiesReadDto" 3
>3 4
>4 5
GetFacilitiesAsync6 H
(H I
)I J
{ 
var 
response 
= 
await 
_unitOfWork (
.( )

Facilities) 3
.3 4
GetAll4 :
(: ;
); <
;< =
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
FacilitiesReadDto' 8
>8 9
>9 :
(: ;
response; C
)C D
;D E
}   
public"" 

async"" 
Task"" 
<"" 
FacilitiesReadDto"" '
>""' (
GetFacilitiesAsync"") ;
(""; <
int""< ?
value""@ E
)""E F
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )

Facilities$$) 3
.$$3 4
Get$$4 7
($$7 8
value$$8 =
)$$= >
;$$> ?
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
FacilitiesReadDto%% ,
>%%, -
(%%- .
response%%. 6
)%%6 7
;%%7 8
}&& 
public(( 

async(( 
Task(( 
<(( 
FacilitiesReadDto(( '
>((' (
GetFacilitiesAsync(() ;
(((; <
string((< B
value((C H
)((H I
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )

Facilities**) 3
.**3 4
Get**4 7
(**7 8
f**8 9
=>**: <
f**= >
.**> ?
Facility**? G
==**H J
value**K P
)**P Q
;**Q R
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
FacilitiesReadDto++ ,
>++, -
(++- .
response++. 6
)++6 7
;++7 8
},, 
public.. 

async.. 
Task.. 
<.. 
FacilitiesReadDto.. '
>..' (!
UpdateFacilitiesAsync..) >
(..> ?
FacilitiesUpdateDto..? R
values..S Y
)..Y Z
{// 

Facilities00 
input_values00 
=00  !
new00" %
(00% &
values00& ,
.00, -

facilityId00- 7
,007 8
values009 ?
.00? @
facility00@ H
!00H I
)00I J
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedBy22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 

Facilities66 
.66 
Update66 %
(66% &
input_values66& 2
)662 3
;663 4
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
FacilitiesReadDto99 $
(99$ %
input_values99% 1
.991 2

FacilityId992 <
,99< =
input_values99> J
.99J K
Facility99K S
!99S T
)99T U
;99U V
}:: 
};; ô.
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockUnitService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
BlockUnitService 
: 
IBlockUnitService 0
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public

 

BlockUnitService

 
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
{ 
_unitOfWork 
= 

unitOfWork  
;  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
BlockUnitReadDto &
>& '
AddBlockUnitAsync( 9
(9 :
BlockUnitCreateDto: L
valuesM S
)S T
{ 
	BlockUnit 
input_values 
=  
new! $
($ %
values% +
.+ ,
unitId, 2
,2 3
values4 :
.: ;
unit; ?
!? @
)@ A
{ 	
	CreatedBy 
= 
values 
. 
	createdby (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
	BlockUnit 
. 
Insert $
($ %
input_values% 1
)1 2
;2 3
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
BlockUnitReadDto #
(# $
input_values$ 0
.0 1
UnitId1 7
,7 8
input_values9 E
.E F
UnitF J
!J K
)K L
;L M
} 
public 

async 
Task 
< 
IEnumerable !
<! "
BlockUnitReadDto" 2
>2 3
>3 4
GetBlockUnitAsync5 F
(F G
)G H
{ 
var   
response   
=   
await   
_unitOfWork   (
.  ( )
	BlockUnit  ) 2
.  2 3
GetAll  3 9
(  9 :
)  : ;
;  ; <
return!! 
_mapper!! 
.!! 
Map!! 
<!! 
IEnumerable!! &
<!!& '
BlockUnitReadDto!!' 7
>!!7 8
>!!8 9
(!!9 :
response!!: B
)!!B C
;!!C D
}"" 
public$$ 

async$$ 
Task$$ 
<$$ 
BlockUnitReadDto$$ &
>$$& '
GetBlockUnitAsync$$( 9
($$9 :
int$$: =
value$$> C
)$$C D
{%% 
var&& 
response&& 
=&& 
await&& 
_unitOfWork&& (
.&&( )
	BlockUnit&&) 2
.&&2 3
Get&&3 6
(&&6 7
value&&7 <
)&&< =
;&&= >
return'' 
_mapper'' 
.'' 
Map'' 
<'' 
BlockUnitReadDto'' +
>''+ ,
('', -
response''- 5
)''5 6
;''6 7
}(( 
public** 

async** 
Task** 
<** 
BlockUnitReadDto** &
>**& '
GetBlockUnitAsync**( 9
(**9 :
string**: @
value**A F
)**F G
{++ 
var,, 
response,, 
=,, 
await,, 
_unitOfWork,, (
.,,( )
	BlockUnit,,) 2
.,,2 3
Get,,3 6
(,,6 7
bu,,7 9
=>,,: <
bu,,= ?
.,,? @
Unit,,@ D
==,,E G
value,,H M
),,M N
;,,N O
return-- 
_mapper-- 
.-- 
Map-- 
<-- 
BlockUnitReadDto-- +
>--+ ,
(--, -
response--- 5
)--5 6
;--6 7
}.. 
public00 

async00 
Task00 
<00 
BlockUnitReadDto00 &
>00& ' 
UpdateBlockUnitAsync00( <
(00< =
BlockUnitUpdateDto00= O
values00P V
)00V W
{11 
	BlockUnit22 
input_values22 
=22  
new22! $
(22$ %
values22% +
.22+ ,
unitId22, 2
,222 3
values224 :
.22: ;
unit22; ?
!22? @
)22@ A
{33 	

ModifiedBy44 
=44 
values44 
.44  

modifiedby44  *
,44* +

ModifiedOn55 
=55 
DateTime55 !
.55! "
Now55" %
}66 	
;66	 

_unitOfWork88 
.88 
	BlockUnit88 
.88 
Update88 $
(88$ %
input_values88% 1
)881 2
;882 3
await99 
_unitOfWork99 
.99 
Complete99 "
(99" #
)99# $
;99$ %
return;; 
new;; 
BlockUnitReadDto;; #
(;;# $
input_values;;$ 0
.;;0 1
UnitId;;1 7
,;;7 8
input_values;;9 E
.;;E F
Unit;;F J
!;;J K
);;K L
;;;L M
}<< 
}== ».
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
BlockTypeService 
: 
IBlockTypeService 0
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

BlockTypeService 
( 
IUnitOfWork '

unitOfWork( 2
,2 3
IMapper4 ;
mapper< B
)B C
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
BlockTypeReadDto &
>& '
AddBlockTypeAsync( 9
(9 :
BlockTypeCreateDto: L
valuesM S
)S T
{ 

BlockTypes 
input_values 
=  !
new" %
(% &
values& ,
., -
blockTypeId- 8
,8 9
values: @
.@ A
	blockTypeA J
!J K
)K L
{ 	
	CreatedBy 
= 
values 
. 
	createdby (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
	BlockType 
. 
Insert $
($ %
input_values% 1
)1 2
;2 3
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
BlockTypeReadDto #
(# $
input_values$ 0
.0 1
BlockTypeId1 <
,< =
input_values> J
.J K
	BlockTypeK T
!T U
)U V
;V W
} 
public 

async 
Task 
< 
IEnumerable !
<! "
BlockTypeReadDto" 2
>2 3
>3 4
GetBlockTypeAsync5 F
(F G
)G H
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
	BlockType) 2
.2 3
GetAll3 9
(9 :
): ;
;; <
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
BlockTypeReadDto' 7
>7 8
>8 9
(9 :
response: B
)B C
;C D
}   
public"" 

async"" 
Task"" 
<"" 
BlockTypeReadDto"" &
>""& '
GetBlockTypeAsync""( 9
(""9 :
int"": =
value""> C
)""C D
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
	BlockType$$) 2
.$$2 3
Get$$3 6
($$6 7
value$$7 <
)$$< =
;$$= >
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
BlockTypeReadDto%% +
>%%+ ,
(%%, -
response%%- 5
)%%5 6
;%%6 7
}&& 
public(( 

async(( 
Task(( 
<(( 
BlockTypeReadDto(( &
>((& '
GetBlockTypeAsync((( 9
(((9 :
string((: @
value((A F
)((F G
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )
	BlockType**) 2
.**2 3
Get**3 6
(**6 7
bt**7 9
=>**: <
bt**= ?
.**? @
	BlockType**@ I
==**J L
value**M R
)**R S
;**S T
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
BlockTypeReadDto++ +
>+++ ,
(++, -
response++- 5
)++5 6
;++6 7
},, 
public.. 

async.. 
Task.. 
<.. 
BlockTypeReadDto.. &
>..& ' 
UpdateBlockTypeAsync..( <
(..< =
BlockTypeUpdateDto..= O
values..P V
)..V W
{// 

BlockTypes00 
input_values00 
=00  !
new00" %
(00% &
values00& ,
.00, -
blockTypeId00- 8
,008 9
values00: @
.00@ A
	blockType00A J
!00J K
)00K L
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedby22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
	BlockType66 
.66 
Update66 $
(66$ %
input_values66% 1
)661 2
;662 3
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
BlockTypeReadDto99 #
(99# $
input_values99$ 0
.990 1
BlockTypeId991 <
,99< =
input_values99> J
.99J K
	BlockType99K T
!99T U
)99U V
;99V W
}:: 
};; †.
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockSideService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
BlockSideService 
: 
IBlockSideService 0
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

BlockSideService 
( 
IUnitOfWork '

unitOfWork( 2
,2 3
IMapper4 ;
mapper< B
)B C
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
BlockSideReadDto &
>& '
AddBlockSideAsync( 9
(9 :
BlockSideCreateDto: L
valuesM S
)S T
{ 

BlockSides 
input_values 
=  !
new" %
(% &
values& ,
., -
sideId- 3
,3 4
values5 ;
.; <
side< @
!@ A
)A B
{ 	
	CreatedBy 
= 
values 
. 
	createdby (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 

BlockSides 
. 
Insert %
(% &
input_values& 2
)2 3
;3 4
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
BlockSideReadDto #
(# $
input_values$ 0
.0 1
SideId1 7
,7 8
input_values9 E
.E F
SideF J
!J K
)K L
;L M
} 
public 

async 
Task 
< 
IEnumerable !
<! "
BlockSideReadDto" 2
>2 3
>3 4
GetBlockSideAsync5 F
(F G
)G H
{ 
var 
response 
= 
await 
_unitOfWork (
.( )

BlockSides) 3
.3 4
GetAll4 :
(: ;
); <
;< =
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
BlockSideReadDto' 7
>7 8
>8 9
(9 :
response: B
)B C
;C D
}   
public"" 

async"" 
Task"" 
<"" 
BlockSideReadDto"" &
>""& '
GetBlockSideAsync""( 9
(""9 :
int"": =
value""> C
)""C D
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )

BlockSides$$) 3
.$$3 4
Get$$4 7
($$7 8
value$$8 =
)$$= >
;$$> ?
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
BlockSideReadDto%% +
>%%+ ,
(%%, -
response%%- 5
)%%5 6
;%%6 7
}&& 
public(( 

async(( 
Task(( 
<(( 
BlockSideReadDto(( &
>((& '
GetBlockSideAsync((( 9
(((9 :
string((: @
value((A F
)((F G
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )

BlockSides**) 3
.**3 4
Get**4 7
(**7 8
bs**8 :
=>**; =
bs**> @
.**@ A
Side**A E
==**F H
value**I N
)**N O
;**O P
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
BlockSideReadDto++ +
>+++ ,
(++, -
response++- 5
)++5 6
;++6 7
},, 
public.. 

async.. 
Task.. 
<.. 
BlockSideReadDto.. &
>..& ' 
UpdateBlockSideAsync..( <
(..< =
BlockSideUpdateDto..= O
values..P V
)..V W
{// 

BlockSides00 
input_values00 
=00  !
new00" %
(00% &
values00& ,
.00, -
sideId00- 3
,003 4
values005 ;
.00; <
side00< @
!00@ A
)00A B
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedby22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 

BlockSides66 
.66 
Update66 %
(66% &
input_values66& 2
)662 3
;663 4
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
BlockSideReadDto99 #
(99# $
input_values99$ 0
.990 1
SideId991 7
,997 8
input_values999 E
.99E F
Side99F J
!99J K
)99K L
;99L M
}:: 
};; ï/
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/BlockNumberService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
BlockNumberService 
:  
IBlockNumberService! 4
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

BlockNumberService 
( 
IUnitOfWork )

unitOfWork* 4
,4 5
IMapper6 =
mapper> D
)D E
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
BlockNumberReadDto (
>( )
AddBlockNumberAsync* =
(= > 
BlockNumberCreateDto> R
valuesS Y
)Y Z
{ 
BlockNumber 
input_values  
=! "
new# &
(& '
values' -
.- .
blockNumberId. ;
,; <
values= C
.C D
blockNumbersD P
!P Q
)Q R
{ 	
	CreatedBy 
= 
values 
. 
	createdby (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
BlockNumber 
.  
Insert  &
(& '
input_values' 3
)3 4
;4 5
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
BlockNumberReadDto %
(% &
input_values& 2
.2 3
BlockNumberId3 @
,@ A
input_valuesB N
.N O
BlockNumbersO [
![ \
)\ ]
;] ^
} 
public 

async 
Task 
< 
IEnumerable !
<! "
BlockNumberReadDto" 4
>4 5
>5 6
GetBlockNumberAsync7 J
(J K
)K L
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
BlockNumber) 4
.4 5
GetAll5 ;
(; <
)< =
;= >
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
BlockNumberReadDto' 9
>9 :
>: ;
(; <
response< D
)D E
;E F
}   
public"" 

async"" 
Task"" 
<"" 
BlockNumberReadDto"" (
>""( )
GetBlockNumberAsync""* =
(""= >
int""> A
value""B G
)""G H
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
BlockNumber$$) 4
.$$4 5
Get$$5 8
($$8 9
value$$9 >
)$$> ?
;$$? @
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
BlockNumberReadDto%% -
>%%- .
(%%. /
response%%/ 7
)%%7 8
;%%8 9
}&& 
public(( 

async(( 
Task(( 
<(( 
BlockNumberReadDto(( (
>((( )
GetBlockNumberAsync((* =
(((= >
string((> D
value((E J
)((J K
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )
BlockNumber**) 4
.**4 5
Get**5 8
(**8 9
bn**9 ;
=>**< >
bn**? A
.**A B
BlockNumbers**B N
==**O Q
value**R W
)**W X
;**X Y
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
BlockNumberReadDto++ -
>++- .
(++. /
response++/ 7
)++7 8
;++8 9
},, 
public.. 

async.. 
Task.. 
<.. 
BlockNumberReadDto.. (
>..( )"
UpdateBlockNumberAsync..* @
(..@ A 
BlockNumberUpdateDto..A U
values..V \
)..\ ]
{// 
BlockNumber00 
input_values00  
=00! "
new00# &
(00& '
values00' -
.00- .
blockNumberId00. ;
,00; <
values00= C
.00C D
blockNumbers00D P
!00P Q
)00Q R
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedby22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
BlockNumber66 
.66  
Update66  &
(66& '
input_values66' 3
)663 4
;664 5
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99 
BlockNumberReadDto99 %
(99% &
input_values99& 2
.992 3
BlockNumberId993 @
,99@ A
input_values99B N
.99N O
BlockNumbers99O [
!99[ \
)99\ ]
;99] ^
}:: 
};; µ7
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ApartmentTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class  
ApartmentTypeService !
:! "!
IApartmentTypeService# 8
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 
 
ApartmentTypeService 
(  
IUnitOfWork  +

unitOfWork, 6
,6 7
IMapper8 ?
mapper@ F
)F G
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
<  
ApartmentTypeReadDto *
>* +!
AddApartmentTypeAsync, A
(A B"
ApartmentTypeCreateDtoB X
valuesY _
)_ `
{ 
ApartmentTypes 
input_values #
=$ %
new& )
() *
values* 0
.0 1
apartmentTypeId1 @
,@ A
valuesB H
.H I
apartmentTypeI V
!V W
,W X
valuesY _
._ `
sellingPrice` l
,l m
valuesn t
.t u

currencyIdu 
,	 Ä
values
Å á
.
á à
	floorArea
à ë
)
ë í
{ 	
	CreatedBy 
= 
values 
. 
	createdBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
ApartmentTypes "
." #
Insert# )
() *
input_values* 6
)6 7
;7 8
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new  
ApartmentTypeReadDto '
(' (
input_values( 4
.4 5
ApartmentTypeId5 D
,D E
input_valuesF R
.R S
ApartmentTypeS `
!` a
,a b
input_valuesc o
.o p
SellingPricep |
,| }
input_values	~ ä
.
ä ã

CurrencyId
ã ï
,
ï ñ
input_values
ó £
.
£ §
	FloorArea
§ ≠
)
≠ Æ
;
Æ Ø
} 
public 

async 
Task 
< 
IEnumerable !
<! " 
ApartmentTypeReadDto" 6
>6 7
>7 8!
GetApartmentTypeAsync9 N
(N O
)O P
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
ApartmentTypes) 7
.7 8
GetAll8 >
(> ?
)? @
;@ A
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& ' 
ApartmentTypeReadDto' ;
>; <
>< =
(= >
response> F
)F G
;G H
}   
public"" 

async"" 
Task"" 
<""  
ApartmentTypeReadDto"" *
>""* +!
GetApartmentTypeAsync"", A
(""A B
int""B E
value""F K
)""K L
{## 
var$$ 
response$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
ApartmentTypes$$) 7
.$$7 8
Get$$8 ;
($$; <
value$$< A
)$$A B
;$$B C
return%% 
_mapper%% 
.%% 
Map%% 
<%%  
ApartmentTypeReadDto%% /
>%%/ 0
(%%0 1
response%%1 9
)%%9 :
;%%: ;
}&& 
public(( 

async(( 
Task(( 
<((  
ApartmentTypeReadDto(( *
>((* +!
GetApartmentTypeAsync((, A
(((A B
string((B H
value((I N
)((N O
{)) 
var** 
response** 
=** 
await** 
_unitOfWork** (
.**( )
ApartmentTypes**) 7
.**7 8
Get**8 ;
(**; <
at**< >
=>**? A
at**B D
.**D E
ApartmentType**E R
==**S U
value**V [
)**[ \
;**\ ]
return++ 
_mapper++ 
.++ 
Map++ 
<++  
ApartmentTypeReadDto++ /
>++/ 0
(++0 1
response++1 9
)++9 :
;++: ;
},, 
public.. 

async.. 
Task.. 
<..  
ApartmentTypeReadDto.. *
>..* +$
UpdateApartmentTypeAsync.., D
(..D E"
ApartmentTypeUpdateDto..E [
values..\ b
)..b c
{// 
ApartmentTypes00 
input_values00 #
=00$ %
new00& )
(00) *
values00* 0
.000 1
apartmentTypeId001 @
,00@ A
values00B H
.00H I
apartmentType00I V
!00V W
,00W X
values00Y _
.00_ `
sellingPrice00` l
,00l m
values00n t
.00t u

currencyId00u 
,	00 Ä
values
00Å á
.
00á à
	floorArea
00à ë
)
00ë í
{11 	

ModifiedBy22 
=22 
values22 
.22  

modifiedBy22  *
,22* +

ModifiedOn33 
=33 
DateTime33 !
.33! "
Now33" %
}44 	
;44	 

_unitOfWork66 
.66 
ApartmentTypes66 "
.66" #
Update66# )
(66) *
input_values66* 6
)666 7
;667 8
await77 
_unitOfWork77 
.77 
Complete77 "
(77" #
)77# $
;77$ %
return99 
new99  
ApartmentTypeReadDto99 '
(99' (
input_values99( 4
.994 5
ApartmentTypeId995 D
,99D E
input_values99F R
.99R S
ApartmentType99S `
!99` a
,99a b
input_values99c o
.99o p
SellingPrice99p |
,99| }
input_values	99~ ä
.
99ä ã

CurrencyId
99ã ï
,
99ï ñ
input_values
99ó £
.
99£ §
	FloorArea
99§ ≠
)
99≠ Æ
;
99Æ Ø
}:: 
};; Í5
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/AllocationTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class !
AllocationTypeService "
:# $"
IAllocationTypeService% ;
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public		 
!
AllocationTypeService		  
(		  !
IUnitOfWork		! ,

unitOfWork		- 7
,		7 8
IMapper		9 @
mapper		A G
)		G H
{

 
_unitOfWork 
= 

unitOfWork  
;  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< !
AllocationTypeReadDto +
>+ ,"
AddAllocationTypeAsync- C
(C D#
AllocationTypeCreateDtoD [
values\ b
)b c
{ 
AllocationType 
allocationType %
=& '
AllocationType( 6
.6 7
Create7 =
(= >
values> D
.D E
AllocationTypeIdE U
,U V
valuesW ]
.] ^!
AllocationTypeInitial^ s
!s t
,t u
valuesv |
.| }
AllocationTypes	} å
!
å ç
)
ç é
;
é è
allocationType 
. 
	CreatedBy  
=! "
values# )
.) *
	CreatedBy* 3
;3 4
allocationType 
. 
	CreatedOn  
=! "
DateTime# +
.+ ,
Now, /
;/ 0
_unitOfWork 
. 
AllocationType "
." #
Insert# )
() *
allocationType* 8
)8 9
;9 :
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new !
AllocationTypeReadDto (
(( )
allocationType) 7
.7 8
AllocationTypeId8 H
,H I
allocationTypeJ X
.X Y!
AllocationTypeInitialY n
!n o
,o p
allocationTypeq 
.	 Ä
AllocationTypes
Ä è
!
è ê
)
ê ë
;
ë í
} 
public 

async 
Task 
< 
IEnumerable !
<! "!
AllocationTypeReadDto" 7
>7 8
>8 9"
GetAllocationTypeAsync: P
(P Q
)Q R
{ 
var 
allocationTypes 
= 
await #
_unitOfWork$ /
./ 0
AllocationType0 >
.> ?
GetAll? E
(E F
)F G
;G H
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '!
AllocationTypeReadDto' <
>< =
>= >
(> ?
allocationTypes? N
)N O
;O P
} 
public!! 

async!! 
Task!! 
<!! !
AllocationTypeReadDto!! +
>!!+ ,"
GetAllocationTypeAsync!!- C
(!!C D
int!!D G
value!!H M
)!!M N
{"" 
var## 
allocationTypes## 
=## 
await## #
_unitOfWork##$ /
.##/ 0
AllocationType##0 >
.##> ?
Get##? B
(##B C
value##C H
)##H I
;##I J
return$$ 
_mapper$$ 
.$$ 
Map$$ 
<$$ !
AllocationTypeReadDto$$ 0
>$$0 1
($$1 2
allocationTypes$$2 A
)$$A B
;$$B C
}%% 
public'' 

async'' 
Task'' 
<'' !
AllocationTypeReadDto'' +
>''+ ,"
GetAllocationTypeAsync''- C
(''C D
string''D J
value''K P
)''P Q
{(( 
var)) 
allocationTypes)) 
=)) 
await)) #
_unitOfWork))$ /
.))/ 0
AllocationType))0 >
.))> ?
Get))? B
())B C
at))C E
=>))F H
at))I K
.))K L!
AllocationTypeInitial))L a
==))b d
value))e j
||))k m
at))n p
.))p q
AllocationTypes	))q Ä
==
))Å É
value
))Ñ â
)
))â ä
;
))ä ã
return** 
_mapper** 
.** 
Map** 
<** !
AllocationTypeReadDto** 0
>**0 1
(**1 2
allocationTypes**2 A
)**A B
;**B C
}++ 
public-- 

async-- 
Task-- 
<-- !
AllocationTypeReadDto-- +
>--+ ,%
UpdateAllocationTypeAsync--- F
(--F G#
AllocationTypeUpdateDto--G ^
values--_ e
)--e f
{.. 
AllocationType// 
allocationType// %
=//& '
new//( +
(//+ ,
values//, 2
.//2 3
AllocationTypeId//3 C
,//C D
values//E K
.//K L!
AllocationTypeInitial//L a
!//a b
,//b c
values//d j
.//j k
AllocationTypes//k z
!//z {
)//{ |
{00 	

ModifiedBy11 
=11 
values11 
.11  

ModifiedBy11  *
,11* +

ModifiedOn22 
=22 
DateTime22 !
.22! "
Now22" %
}33 	
;33	 

_unitOfWork55 
.55 
AllocationType55 "
.55" #
Update55# )
(55) *
allocationType55* 8
)558 9
;559 :
await66 
_unitOfWork66 
.66 
Complete66 "
(66" #
)66# $
;66$ %
return88 
new88 !
AllocationTypeReadDto88 (
(88( )
allocationType88) 7
.887 8
AllocationTypeId888 H
,88H I
allocationType88J X
.88X Y!
AllocationTypeInitial88Y n
!88n o
,88o p
allocationType88q 
.	88 Ä
AllocationTypes
88Ä è
!
88è ê
)
88ê ë
;
88ë í
}99 
};; µ%
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ActivityTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
{ 
public 
class 
ActivityTypeService !
:" # 
IActivityTypeService$ 8
{ 
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
ActivityTypeService
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
ActivityTypeReadDto -
>- .#
CreateActivityTypeAsync/ F
(F G!
ActivityTypeCreateDtoG \
values] c
)c d
{ 	
ActivityType 
activityType %
=& '
ActivityType( 4
.4 5
Create5 ;
(; <
values< B
.B C

ActivityIdC M
,M N
valuesO U
.U V
ActivityTypeIdV d
,d e
valuesf l
.l m
ActivityTypeNamem }
,} ~
values	 Ö
.
Ö Ü%
ActivityTypeDescription
Ü ù
)
ù û
;
û ü
activityType 
. 
	CreatedBy "
=# $
values% +
.+ ,
	CreatedBy, 5
;5 6
activityType 
. 
	CreatedOn "
=# $
DateTime% -
.- .
Now. 1
;1 2
_unitOfWork 
. 
ActivityType $
.$ %
Insert% +
(+ ,
activityType, 8
)8 9
;9 :
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
ActivityTypeReadDto *
(* +
activityType+ 7
.7 8

ActivityId8 B
,B C
activityTypeD P
.P Q
ActivityTypeIdQ _
,_ `
activityTypea m
.m n
ActivityTypeNamen ~
!~ 
,	 Ä
activityType
Å ç
.
ç é%
ActivityTypeDescription
é •
!
• ¶
)
¶ ß
;
ß ®
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
ActivityTypeReadDto& 9
>9 :
>: ; 
GetActivityTypeAsync< P
(P Q
)Q R
{ 	
var 
activityTypes 
= 
await  %
_unitOfWork& 1
.1 2
ActivityType2 >
.> ?
GetAll? E
(E F
)F G
;G H
return   
_mapper   
.   
Map   
<   
IEnumerable   *
<  * +
ActivityTypeReadDto  + >
>  > ?
>  ? @
(  @ A
activityTypes  A N
)  N O
;  O P
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
ActivityTypeReadDto$$ -
>$$- . 
GetActivityTypeAsync$$/ C
($$C D
int$$D G
value$$H M
)$$M N
{%% 	
var&& 
activityTypes&& 
=&& 
await&&  %
_unitOfWork&&& 1
.&&1 2
ActivityType&&2 >
.&&> ?
Get&&? B
(&&B C
value&&C H
)&&H I
;&&I J
return'' 
_mapper'' 
.'' 
Map'' 
<'' 
ActivityTypeReadDto'' 2
>''2 3
(''3 4
activityTypes''4 A
)''A B
;''B C
}(( 	
public** 
Task** 
<** 
ActivityTypeReadDto** '
>**' (#
UpdateActivityTypeAsync**) @
(**@ A!
ActivityTypeUpdateDto**A V
values**W ]
)**] ^
{++ 	
throw,, 
new,, #
NotImplementedException,, -
(,,- .
),,. /
;,,/ 0
}-- 	
}.. 
}// ⁄"
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ActivityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Property5 =
;= >
public 
class 
ActivityService 
: 
IActivityService /
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

ActivityService 
( 
IUnitOfWork &

unitOfWork' 1
,1 2
IMapper3 :
mapper; A
)A B
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
ActivityReadDto %
>% &
CreateActivityAsync' :
(: ;
ActivityCreateDto; L
valuesM S
)S T
{ 
Activity 
activity 
= 
Activity $
.$ %
Create% +
(+ ,
values, 2
.2 3

ActivityId3 =
,= >
values? E
.E F
ActivityNameF R
,R S
valuesT Z
.Z [
ActivityDescription[ n
)n o
;o p
activity 
. 
	CreatedBy 
= 
values #
.# $
	CreatedBy$ -
;- .
activity 
. 
	CreatedOn 
= 
DateTime %
.% &
Now& )
;) *
_unitOfWork 
. 
Activity 
. 
Insert #
(# $
activity$ ,
), -
;- .
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
ActivityReadDto "
(" #
activity# +
.+ ,

ActivityId, 6
,6 7
activity8 @
.@ A
ActivityNameA M
!M N
,N O
activityP X
.X Y
ActivityDescriptionY l
!l m
)m n
;n o
} 
public 

async 
Task 
< 
IEnumerable !
<! "
ActivityReadDto" 1
>1 2
>2 3
GetActivitiesAsync4 F
(F G
)G H
{ 
var 

activities 
= 
await 
_unitOfWork *
.* +
Activity+ 3
.3 4
GetAll4 :
(: ;
); <
;< =
return 
_mapper 
. 
Map 
< 
IEnumerable &
<& '
ActivityReadDto' 6
>6 7
>7 8
(8 9

activities9 C
)C D
;D E
}   
public"" 

async"" 
Task"" 
<"" 
ActivityReadDto"" %
>""% &
GetActivityAsync""' 7
(""7 8
int""8 ;
value""< A
)""A B
{## 
var$$ 
activity$$ 
=$$ 
await$$ 
_unitOfWork$$ (
.$$( )
Activity$$) 1
.$$1 2
Get$$2 5
($$5 6
value$$6 ;
)$$; <
;$$< =
return%% 
_mapper%% 
.%% 
Map%% 
<%% 
ActivityReadDto%% *
>%%* +
(%%+ ,
activity%%, 4
)%%4 5
;%%5 6
}&& 
public(( 

Task(( 
<(( 
ActivityReadDto(( 
>((  
UpdateActivityAsync((! 4
(((4 5
ActivityUpdateDto((5 F
values((G M
)((M N
{)) 
throw** 
new** #
NotImplementedException** )
(**) *
)*** +
;**+ ,
}++ 
},, Ë4
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/TitleService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
{ 
public 
class 
TitleService 
: 
ITitleService )
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
TitleService
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
TitleReadDto &
>& '
AddTitleAsync( 5
(5 6
TitleCreateDto6 D
valuesE K
)K L
{ 	
Title 
title 
= 
new 
( 
values $
.$ %
titleId% ,
,, -
values. 4
.4 5
titles5 ;
!; <
)< =
{ 
	CreatedBy 
= 
values "
." #
	createdby# ,
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
Title 
. 
Insert $
($ %
title% *
)* +
;+ ,
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
TitleReadDto #
(# $
title$ )
.) *
TitleId* 1
,1 2
title3 8
.8 9
Titles9 ?
!? @
)@ A
;A B
} 	
public 
async 
Task 
< 
string  
>  !
DeleteTitleAsync" 2
(2 3
int3 6
value7 <
)< =
{ 	
var   
response   
=   
await    
_unitOfWork  ! ,
.  , -
Title  - 2
.  2 3
Get  3 6
(  6 7
value  7 <
)  < =
;  = >
if"" 
("" 
response"" 
is"" 
null""  
)""  !
{## 
return$$ 
$str$$ )
;$$) *
}%% 
_unitOfWork'' 
.'' 
Title'' 
.'' 
Delete'' $
(''$ %
response''% -
)''- .
;''. /
await(( 
_unitOfWork(( 
.(( 
Complete(( &
(((& '
)((' (
;((( )
return** 
$str** 
;** 
}++ 	
public-- 
async-- 
Task-- 
<-- 
IEnumerable-- %
<--% &
TitleReadDto--& 2
>--2 3
>--3 4
GetTitleAsync--5 B
(--B C
)--C D
{.. 	
var// 
response// 
=// 
await//  
_unitOfWork//! ,
.//, -
Title//- 2
.//2 3
GetAll//3 9
(//9 :
)//: ;
;//; <
return00 
_mapper00 
.00 
Map00 
<00 
IEnumerable00 *
<00* +
TitleReadDto00+ 7
>007 8
>008 9
(009 :
response00: B
)00B C
;00C D
}11 	
public33 
async33 
Task33 
<33 
TitleReadDto33 &
>33& '
GetTitleAsync33( 5
(335 6
int336 9
value33: ?
)33? @
{44 	
var55 
response55 
=55 
await55  
_unitOfWork55! ,
.55, -
Title55- 2
.552 3
Get553 6
(556 7
value557 <
)55< =
;55= >
return66 
_mapper66 
.66 
Map66 
<66 
TitleReadDto66 +
>66+ ,
(66, -
response66- 5
)665 6
;666 7
}77 	
public99 
async99 
Task99 
<99 
TitleReadDto99 &
>99& '
GetTitleAsync99( 5
(995 6
string996 <
value99= B
)99B C
{:: 	
var;; 
response;; 
=;; 
await;;  
_unitOfWork;;! ,
.;;, -
Title;;- 2
.;;2 3
Get;;3 6
(;;6 7
t;;7 8
=>;;9 ;
t;;< =
.;;= >
Titles;;> D
==;;E G
value;;H M
);;M N
;;;N O
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
TitleReadDto<< +
><<+ ,
(<<, -
response<<- 5
)<<5 6
;<<6 7
}== 	
public?? 
async?? 
Task?? 
<?? 
TitleReadDto?? &
>??& '
UpdateTitleAsync??( 8
(??8 9
TitleUpdateDto??9 G
values??H N
)??N O
{@@ 	
TitleAA 
titleAA 
=AA 
newAA 
(AA 
valuesAA $
.AA$ %
titleIdAA% ,
,AA, -
valuesAA. 4
.AA4 5
titlesAA5 ;
!AA; <
)AA< =
{BB 

ModifiedByCC 
=CC 
valuesCC #
.CC# $

modifiedbyCC$ .
,CC. /

ModifiedOnDD 
=DD 
DateTimeDD %
.DD% &
NowDD& )
}EE 
;EE 
_unitOfWorkGG 
.GG 
TitleGG 
.GG 
UpdateGG $
(GG$ %
titleGG% *
)GG* +
;GG+ ,
awaitHH 
_unitOfWorkHH 
.HH 
CompleteHH &
(HH& '
)HH' (
;HH( )
returnJJ 
newJJ 
TitleReadDtoJJ #
(JJ# $
titleJJ$ )
.JJ) *
TitleIdJJ* 1
,JJ1 2
titleJJ3 8
.JJ8 9
TitlesJJ9 ?
!JJ? @
)JJ@ A
;JJA B
}KK 	
}NN 
}OO ¸6
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/SocialMediaService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
;= >
public 
class 
SocialMediaService 
:  
ISocialMediaService! 4
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

SocialMediaService 
( 
IUnitOfWork )

unitOfWork* 4
,4 5
IMapper6 =
mapper> D
)D E
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
SocialMediaReadDto (
>( )
AddSocialMediaAsync* =
(= > 
SocialMediaCreateDto> R
valuesS Y
)Y Z
{ 
SocialMedia 
request 
= 
new !
(! "
values" (
.( )
SocialMediaId) 6
,6 7
values8 >
.> ?
SocialMediaPlatform? R
!R S
)S T
{ 	
	CreatedBy 
= 
values 
. 
	CreatedBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
SocialMedia 
.  
Insert  &
(& '
request' .
). /
;/ 0
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
SocialMediaReadDto %
(% &
request& -
.- .
SocialMediaId. ;
,; <
request= D
.D E
SocialMediaPlatformE X
!X Y
)Y Z
;Z [
} 
public 

async 
Task 
< 
string 
> "
DeleteSocialMediaAsync 4
(4 5
int5 8
value9 >
)> ?
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
SocialMedia) 4
.4 5
Get5 8
(8 9
value9 >
)> ?
;? @
if   

(   
response   
is   
null   
)   
{!! 	
return"" 
$str"" %
;""% &
}## 	
_unitOfWork%% 
.%% 
SocialMedia%% 
.%%  
Delete%%  &
(%%& '
response%%' /
)%%/ 0
;%%0 1
await&& 
_unitOfWork&& 
.&& 
Complete&& "
(&&" #
)&&# $
;&&$ %
return(( 
$str(( 
;(( 
})) 
public++ 

async++ 
Task++ 
<++ 
IEnumerable++ !
<++! "
SocialMediaReadDto++" 4
>++4 5
>++5 6
GetSocialMediaAsync++7 J
(++J K
)++K L
{,, 
var-- 
response-- 
=-- 
await-- 
_unitOfWork-- (
.--( )
SocialMedia--) 4
.--4 5
GetAll--5 ;
(--; <
)--< =
;--= >
return.. 
_mapper.. 
... 
Map.. 
<.. 
IEnumerable.. &
<..& '
SocialMediaReadDto..' 9
>..9 :
>..: ;
(..; <
response..< D
)..D E
;..E F
}// 
public11 

async11 
Task11 
<11 
SocialMediaReadDto11 (
>11( )
GetSocialMediaAsync11* =
(11= >
int11> A
value11B G
)11G H
{22 
var33 
response33 
=33 
await33 
_unitOfWork33 (
.33( )
SocialMedia33) 4
.334 5
Get335 8
(338 9
value339 >
)33> ?
;33? @
return44 
_mapper44 
.44 
Map44 
<44 
SocialMediaReadDto44 -
>44- .
(44. /
response44/ 7
)447 8
;448 9
}55 
public77 

async77 
Task77 
<77 
SocialMediaReadDto77 (
>77( )
GetSocialMediaAsync77* =
(77= >
string77> D
value77E J
)77J K
{88 
var99 
response99 
=99 
await99 
_unitOfWork99 (
.99( )
SocialMedia99) 4
.994 5
Get995 8
(998 9
sm999 ;
=>99< >
sm99? A
.99A B
SocialMediaPlatform99B U
==99V X
value99Y ^
)99^ _
;99_ `
return:: 
_mapper:: 
.:: 
Map:: 
<:: 
SocialMediaReadDto:: -
>::- .
(::. /
response::/ 7
)::7 8
;::8 9
};; 
public== 

async== 
Task== 
<== 
SocialMediaReadDto== (
>==( )"
UpdateSocialMediaAsync==* @
(==@ A 
SocialMediaUpdateDto==A U
values==V \
)==\ ]
{>> 
SocialMedia?? 
request?? 
=?? 
new?? !
(??! "
values??" (
.??( )
SocialMediaId??) 6
,??6 7
values??8 >
.??> ?
SocialMediaPlatform??? R
!??R S
)??S T
{@@ 	

ModifiedByAA 
=AA 
valuesAA 
.AA  

ModifiedByAA  *
,AA* +

ModifiedOnBB 
=BB 
DateTimeBB !
.BB! "
NowBB" %
}CC 	
;CC	 

_unitOfWorkEE 
.EE 
SocialMediaEE 
.EE  
UpdateEE  &
(EE& '
requestEE' .
)EE. /
;EE/ 0
awaitFF 
_unitOfWorkFF 
.FF 
CompleteFF "
(FF" #
)FF# $
;FF$ %
returnHH 
newHH 
SocialMediaReadDtoHH %
(HH% &
requestHH& -
.HH- .
SocialMediaIdHH. ;
,HH; <
requestHH= D
.HHD E
SocialMediaPlatformHHE X
!HHX Y
)HHY Z
;HHZ [
}II 
}JJ ê7
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/ResidentTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
{ 
public 
class 
ResidentTypeService !
:! " 
IResidentTypeService# 7
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
public 
ResidentTypeService "
(" #
IUnitOfWork# .

unitOfWork/ 9
,9 :
IMapper; B
mapperC I
)I J
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
ResidentTypeReadDto -
>- . 
AddResidentTypeAsync/ C
(C D!
ResidentTypeCreateDtoD Y
valuesZ `
)` a
{ 	
ResidentType 
request  
=! "
new# &
(& '
values' -
.- .
residentTypeId. <
,< =
values> D
.D E
residentTypesE R
!R S
)S T
{ 
	CreatedBy 
= 
values "
." #
	createdBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
ResidentType $
.$ %
Insert% +
(+ ,
request, 3
)3 4
;4 5
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
ResidentTypeReadDto *
(* +
request+ 2
.2 3
ResidentTypeId3 A
,A B
requestC J
.J K
ResidentTypesK X
!X Y
)Y Z
;Z [
} 	
public 
async 
Task 
< 
string  
>  !#
DeleteResidentTypeAsync" 9
(9 :
int: =
value> C
)C D
{   	
var!! 
response!! 
=!! 
await!!  
_unitOfWork!!! ,
.!!, -
ResidentType!!- 9
.!!9 :
Get!!: =
(!!= >
value!!> C
)!!C D
;!!D E
if## 
(## 
response## 
is## 
null##  
)##  !
{$$ 
return%% 
$str%% )
;%%) *
}&& 
_unitOfWork(( 
.(( 
ResidentType(( $
.(($ %
Delete((% +
(((+ ,
response((, 4
)((4 5
;((5 6
await)) 
_unitOfWork)) 
.)) 
Complete)) &
())& '
)))' (
;))( )
return++ 
$str++ 
;++ 
},, 	
public.. 
async.. 
Task.. 
<.. 
IEnumerable.. %
<..% &
ResidentTypeReadDto..& 9
>..9 :
>..: ; 
GetResidentTypeAsync..< P
(..P Q
)..Q R
{// 	
var00 
response00 
=00 
await00  
_unitOfWork00! ,
.00, -
ResidentType00- 9
.009 :
GetAll00: @
(00@ A
)00A B
;00B C
return11 
_mapper11 
.11 
Map11 
<11 
IEnumerable11 *
<11* +
ResidentTypeReadDto11+ >
>11> ?
>11? @
(11@ A
response11A I
)11I J
;11J K
}22 	
public44 
async44 
Task44 
<44 
ResidentTypeReadDto44 -
>44- . 
GetResidentTypeAsync44/ C
(44C D
int44D G
value44H M
)44M N
{55 	
var66 
response66 
=66 
await66  
_unitOfWork66! ,
.66, -
ResidentType66- 9
.669 :
Get66: =
(66= >
value66> C
)66C D
;66D E
return77 
_mapper77 
.77 
Map77 
<77 
ResidentTypeReadDto77 2
>772 3
(773 4
response774 <
)77< =
;77= >
}88 	
public:: 
async:: 
Task:: 
<:: 
ResidentTypeReadDto:: -
>::- . 
GetResidentTypeAsync::/ C
(::C D
string::D J
value::K P
)::P Q
{;; 	
var<< 
response<< 
=<< 
await<<  
_unitOfWork<<! ,
.<<, -
ResidentType<<- 9
.<<9 :
Get<<: =
(<<= >
r<<> ?
=><<@ B
r<<C D
.<<D E
ResidentTypes<<E R
==<<S U
value<<V [
)<<[ \
;<<\ ]
return== 
_mapper== 
.== 
Map== 
<== 
ResidentTypeReadDto== 2
>==2 3
(==3 4
response==4 <
)==< =
;=== >
}>> 	
public@@ 
async@@ 
Task@@ 
<@@ 
ResidentTypeReadDto@@ -
>@@- .#
UpdateResidentTypeAsync@@/ F
(@@F G!
ResidentTypeUpdateDto@@G \
values@@] c
)@@c d
{AA 	
ResidentTypeBB 
requestBB  
=BB! "
newBB# &
(BB& '
valuesBB' -
.BB- .
residentTypeIdBB. <
,BB< =
valuesBB> D
.BBD E
residentTypesBBE R
!BBR S
)BBS T
{CC 

ModifiedByDD 
=DD 
valuesDD #
.DD# $

modifiedByDD$ .
,DD. /

ModifiedOnEE 
=EE 
DateTimeEE %
.EE% &
NowEE& )
}FF 
;FF 
_unitOfWorkHH 
.HH 
ResidentTypeHH $
.HH$ %
UpdateHH% +
(HH+ ,
requestHH, 3
)HH3 4
;HH4 5
awaitII 
_unitOfWorkII 
.II 
CompleteII &
(II& '
)II' (
;II( )
returnKK 
newKK 
ResidentTypeReadDtoKK *
(KK* +
requestKK+ 2
.KK2 3
ResidentTypeIdKK3 A
,KKA B
requestKKC J
.KKJ K
ResidentTypesKKK X
!KKX Y
)KKY Z
;KKZ [
}LL 	
}MM 
}NN Ì6
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/NationalityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
{ 
public 
class 
NationalityService  
:  !
INationalityService" 5
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
NationalityService
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
NationalityReadDto ,
>, -
AddNationalityAsync. A
(A B 
NationalityCreateDtoB V
valuesW ]
)] ^
{ 	
Nationality 
request 
=  !
new" %
(% &
values& ,
., -
nationalityId- :
,: ;
values< B
.B C
nationalitiesC P
!P Q
)Q R
{ 
	CreatedBy 
= 
values "
." #
	createdby# ,
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
Nationality #
.# $
Insert$ *
(* +
request+ 2
)2 3
;3 4
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new 
NationalityReadDto )
() *
request* 1
.1 2
NationalityId2 ?
,? @
requestA H
.H I
NationalitiesI V
!V W
)W X
;X Y
} 	
public 
async 
Task 
< 
string  
>  !"
DeleteNationalityAsync" 8
(8 9
int9 <
value= B
)B C
{ 	
var   
response   
=   
await    
_unitOfWork  ! ,
.  , -
Nationality  - 8
.  8 9
Get  9 <
(  < =
value  = B
)  B C
;  C D
if"" 
("" 
response"" 
is"" 
null""  
)""  !
{## 
return$$ 
$str$$ )
;$$) *
}%% 
_unitOfWork'' 
.'' 
Nationality'' #
.''# $
Delete''$ *
(''* +
response''+ 3
)''3 4
;''4 5
await(( 
_unitOfWork(( 
.(( 
Complete(( &
(((& '
)((' (
;((( )
return** 
$str** 
;** 
}++ 	
public-- 
async-- 
Task-- 
<-- 
IEnumerable-- %
<--% &
NationalityReadDto--& 8
>--8 9
>--9 :
GetNationalityAsync--; N
(--N O
)--O P
{.. 	
var// 
response// 
=// 
await//  
_unitOfWork//! ,
.//, -
Nationality//- 8
.//8 9
GetAll//9 ?
(//? @
)//@ A
;//A B
return00 
_mapper00 
.00 
Map00 
<00 
IEnumerable00 *
<00* +
NationalityReadDto00+ =
>00= >
>00> ?
(00? @
response00@ H
)00H I
;00I J
}11 	
public33 
async33 
Task33 
<33 
NationalityReadDto33 ,
>33, -
GetNationalityAsync33. A
(33A B
int33B E
value33F K
)33K L
{44 	
var55 
response55 
=55 
await55  
_unitOfWork55! ,
.55, -
Nationality55- 8
.558 9
Get559 <
(55< =
value55= B
)55B C
;55C D
return66 
_mapper66 
.66 
Map66 
<66 
NationalityReadDto66 1
>661 2
(662 3
response663 ;
)66; <
;66< =
}77 	
public99 
async99 
Task99 
<99 
NationalityReadDto99 ,
>99, -
GetNationalityAsync99. A
(99A B
string99B H
value99I N
)99N O
{:: 	
var;; 
response;; 
=;; 
await;;  
_unitOfWork;;! ,
.;;, -
Nationality;;- 8
.;;8 9
Get;;9 <
(;;< =
n;;= >
=>;;? A
n;;B C
.;;C D
Nationalities;;D Q
==;;R T
value;;U Z
);;Z [
;;;[ \
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
NationalityReadDto<< 1
><<1 2
(<<2 3
response<<3 ;
)<<; <
;<<< =
}== 	
public?? 
async?? 
Task?? 
<?? 
NationalityReadDto?? ,
>??, -"
UpdateNationalityAsync??. D
(??D E 
NationalityUpdateDto??E Y
values??Z `
)??` a
{@@ 	
NationalityAA 
requestAA 
=AA  !
newAA" %
(AA% &
valuesAA& ,
.AA, -
nationalityIdAA- :
,AA: ;
valuesAA< B
.AAB C
nationalitiesAAC P
!AAP Q
)AAQ R
{BB 

ModifiedByCC 
=CC 
valuesCC #
.CC# $

modifiedbyCC$ .
,CC. /

ModifiedOnDD 
=DD 
DateTimeDD %
.DD% &
NowDD& )
}EE 
;EE 
_unitOfWorkGG 
.GG 
NationalityGG #
.GG# $
UpdateGG$ *
(GG* +
requestGG+ 2
)GG2 3
;GG3 4
awaitHH 
_unitOfWorkHH 
.HH 
CompleteHH &
(HH& '
)HH' (
;HH( )
returnJJ 
newJJ 
NationalityReadDtoJJ )
(JJ) *
requestJJ* 1
.JJ1 2
NationalityIdJJ2 ?
,JJ? @
requestJJA H
.JJH I
NationalitiesJJI V
!JJV W
)JJW X
;JJX Y
}KK 	
}LL 
}MM «7
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/OwnershipTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
{ 
public 
class  
OwnershipTypeService "
:# $!
IOwnershipTypeService% :
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
OwnershipTypeService
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
OwnershipTypeReadDto .
>. /!
AddOwnershipTypeAsync0 E
(E F"
OwnershipTypeCreateDtoF \
values] c
)c d
{ 	
OwnershipType 
request !
=" #
new$ '
(' (
values( .
.. /
ownershipTypeId/ >
,> ?
values@ F
.F G
ownershipTypesG U
!U V
)V W
{ 
	CreatedBy 
= 
values "
." #
	createdby# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
OwnershipType %
.% &
Insert& ,
(, -
request- 4
)4 5
;5 6
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
return 
new  
OwnershipTypeReadDto +
(+ ,
request, 3
.3 4
OwnershipTypeId4 C
,C D
requestE L
.L M
OwnershipTypesM [
![ \
)\ ]
;] ^
} 	
public 
async 
Task 
< 
string  
>  !$
DeleteOwnershipTypeAsync" :
(: ;
int; >
value? D
)D E
{   	
var!! 
ownershiptype!! 
=!! 
await!!  %
_unitOfWork!!& 1
.!!1 2
OwnershipType!!2 ?
.!!? @
Get!!@ C
(!!C D
value!!D I
)!!I J
;!!J K
if## 
(## 
ownershiptype## 
is##  
null##! %
)##% &
{$$ 
return%% 
$str%% )
;%%) *
}&& 
_unitOfWork(( 
.(( 
OwnershipType(( %
.((% &
Delete((& ,
(((, -
ownershiptype((- :
)((: ;
;((; <
await)) 
_unitOfWork)) 
.)) 
Complete)) &
())& '
)))' (
;))( )
return++ 
$str++ 
;++ 
}-- 	
public// 
async// 
Task// 
<// 
IEnumerable// %
<//% & 
OwnershipTypeReadDto//& :
>//: ;
>//; <!
GetOwnershipTypeAsync//= R
(//R S
)//S T
{00 	
var11 
response11 
=11 
await11  
_unitOfWork11! ,
.11, -
OwnershipType11- :
.11: ;
GetAll11; A
(11A B
)11B C
;11C D
return22 
_mapper22 
.22 
Map22 
<22 
IEnumerable22 *
<22* + 
OwnershipTypeReadDto22+ ?
>22? @
>22@ A
(22A B
response22B J
)22J K
;22K L
}44 	
public66 
async66 
Task66 
<66  
OwnershipTypeReadDto66 .
>66. /!
GetOwnershipTypeAsync660 E
(66E F
int66F I
value66J O
)66O P
{77 	
var88 
response88 
=88 
await88  
_unitOfWork88! ,
.88, -
OwnershipType88- :
.88: ;
Get88; >
(88> ?
value88? D
)88D E
;88E F
return99 
_mapper99 
.99 
Map99 
<99  
OwnershipTypeReadDto99 3
>993 4
(994 5
response995 =
)99= >
;99> ?
};; 	
public== 
async== 
Task== 
<==  
OwnershipTypeReadDto== .
>==. /!
GetOwnershipTypeAsync==0 E
(==E F
string==F L
value==M R
)==R S
{>> 	
var?? 
response?? 
=?? 
await??  
_unitOfWork??! ,
.??, -
OwnershipType??- :
.??: ;
Get??; >
(??> ?
o??? @
=>??A C
o??D E
.??E F
OwnershipTypes??F T
==??U W
value??X ]
)??] ^
;??^ _
return@@ 
_mapper@@ 
.@@ 
Map@@ 
<@@  
OwnershipTypeReadDto@@ 3
>@@3 4
(@@4 5
response@@5 =
)@@= >
;@@> ?
}AA 	
publicCC 
asyncCC 
TaskCC 
<CC  
OwnershipTypeReadDtoCC .
>CC. /$
UpdateOwnershipTypeAsyncCC0 H
(CCH I"
OwnershipTypeUpdateDtoCCI _
valuesCC` f
)CCf g
{DD 	
OwnershipTypeFF 
requestFF !
=FF" #
newFF$ '
(FF' (
valuesFF( .
.FF. /
ownershipTypeIdFF/ >
,FF> ?
valuesFF@ F
.FFF G
ownershipTypesFFG U
!FFU V
)FFV W
{GG 

ModifiedByHH 
=HH 
valuesHH #
.HH# $

modifiedbyHH$ .
,HH. /

ModifiedOnII 
=II 
DateTimeII %
.II% &
NowII& )
}JJ 
;JJ 
_unitOfWorkLL 
.LL 
OwnershipTypeLL %
.LL% &
UpdateLL& ,
(LL, -
requestLL- 4
)LL4 5
;LL5 6
awaitMM 
_unitOfWorkMM 
.MM 
CompleteMM &
(MM& '
)MM' (
;MM( )
returnOO 
newOO  
OwnershipTypeReadDtoOO +
(OO+ ,
requestOO, 3
.OO3 4
OwnershipTypeIdOO4 C
,OOC D
requestOOE L
.OOL M
OwnershipTypesOOM [
!OO[ \
)OO\ ]
;OO] ^
}PP 	
}QQ 
}RR •D
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/IdentificationTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
{ 
public 
class %
IdentificationTypeService '
:( )&
IIdentificationTypeService* D
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
( )
private 
readonly 

HttpClient #
_httpClient$ /
;/ 0
public %
IdentificationTypeService (
(( )
IUnitOfWork) 4

unitOfWork5 ?
,? @
IMapperA H
mapperI O
,O P

HttpClientQ [

httpClient\ f
)f g
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
_httpClient 
= 

httpClient $
;$ %
} 	
public 
async 
Task 
< %
IdentificationTypeReadDto 3
>3 4&
AddIdentificationTypeAsync5 O
(O P'
IdentificationTypeCreateDtoP k
valuesl r
)r s
{ 	
IdentificationType 
request &
=' (
new) ,
(, -
values- 3
.3 4 
identificationTypeId4 H
,H I
valuesJ P
.P Q
identificationTypesQ d
!d e
)e f
{ 
	CreatedBy 
= 
values "
." #
	createdBy# ,
,, -
	CreatedOn 
= 
DateTime $
.$ %
Now% (
} 
; 
_unitOfWork 
. 
IdentificationType *
.* +
Insert+ 1
(1 2
request2 9
)9 :
;: ;
await 
_unitOfWork 
. 
Complete &
(& '
)' (
;( )
var   
payload   
=   
new   !
IdentificationTypeDto   3
(  3 4
request  4 ;
.  ; < 
IdentificationTypeId  < P
,  P Q
request  R Y
.  Y Z
IdentificationTypes  Z m
!  m n
)  n o
;  o p
string!! 
json_payload!! 
=!!  !
JsonSerializer!!" 0
.!!0 1
	Serialize!!1 :
(!!: ;
payload!!; B
)!!B C
;!!C D
var"" 
_httpContent"" 
="" 
new"" "
StringContent""# 0
(""0 1
json_payload""1 =
,""= >
Encoding""? G
.""G H
UTF8""H L
,""L M
$str""N `
)""` a
;""a b
HttpResponseMessage## 
	_response##  )
=##* +
await##, 1
_httpClient##2 =
.##= >
	PostAsync##> G
(##G H
$str	##H £
,
##£ §
_httpContent
##• ±
)
##± ≤
;
##≤ ≥
var$$ 

result_sms$$ 
=$$ 
	_response$$ &
.$$& '
IsSuccessStatusCode$$' :
;$$: ;
return'' 
new'' %
IdentificationTypeReadDto'' 0
(''0 1
request''1 8
.''8 9 
IdentificationTypeId''9 M
,''M N
request''O V
.''V W
IdentificationTypes''W j
!''j k
)''k l
;''l m
}(( 	
public** 
async** 
Task** 
<** 
string**  
>**  !)
DeleteIdentificationTypeAsync**" ?
(**? @
int**@ C
value**D I
)**I J
{++ 	
var,, 
response,, 
=,, 
await,,  
_unitOfWork,,! ,
.,,, -
IdentificationType,,- ?
.,,? @
Get,,@ C
(,,C D
value,,D I
),,I J
;,,J K
if.. 
(.. 
response.. 
is.. 
null..  
)..  !
{// 
return00 
$str00 )
;00) *
}11 
_unitOfWork33 
.33 
IdentificationType33 *
.33* +
Delete33+ 1
(331 2
response332 :
)33: ;
;33; <
await44 
_unitOfWork44 
.44 
Complete44 &
(44& '
)44' (
;44( )
return66 
$str66 
;66 
}77 	
public99 
async99 
Task99 
<99 
IEnumerable99 %
<99% &%
IdentificationTypeReadDto99& ?
>99? @
>99@ A&
GetIdentificationTypeAsync99B \
(99\ ]
)99] ^
{:: 	
var;; 
response;; 
=;; 
await;;  
_unitOfWork;;! ,
.;;, -
IdentificationType;;- ?
.;;? @
GetAll;;@ F
(;;F G
);;G H
;;;H I
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +%
IdentificationTypeReadDto<<+ D
><<D E
><<E F
(<<F G
response<<G O
)<<O P
;<<P Q
}== 	
public?? 
async?? 
Task?? 
<?? %
IdentificationTypeReadDto?? 3
>??3 4&
GetIdentificationTypeAsync??5 O
(??O P
int??P S
value??T Y
)??Y Z
{@@ 	
varAA 
responseAA 
=AA 
awaitAA  
_unitOfWorkAA! ,
.AA, -
IdentificationTypeAA- ?
.AA? @
GetAA@ C
(AAC D
valueAAD I
)AAI J
;AAJ K
returnBB 
_mapperBB 
.BB 
MapBB 
<BB %
IdentificationTypeReadDtoBB 8
>BB8 9
(BB9 :
responseBB: B
)BBB C
;BBC D
}CC 	
publicEE 
asyncEE 
TaskEE 
<EE %
IdentificationTypeReadDtoEE 3
>EE3 4&
GetIdentificationTypeAsyncEE5 O
(EEO P
stringEEP V
valueEEW \
)EE\ ]
{FF 	
varGG 
responseGG 
=GG 
awaitGG  
_unitOfWorkGG! ,
.GG, -
IdentificationTypeGG- ?
.GG? @
GetGG@ C
(GGC D
iGGD E
=>GGF H
iGGI J
.GGJ K
IdentificationTypesGGK ^
==GG_ a
valueGGb g
)GGg h
;GGh i
returnHH 
_mapperHH 
.HH 
MapHH 
<HH %
IdentificationTypeReadDtoHH 8
>HH8 9
(HH9 :
responseHH: B
)HHB C
;HHC D
}II 	
publicKK 
asyncKK 
TaskKK 
<KK %
IdentificationTypeReadDtoKK 3
>KK3 4)
UpdateIdentificationTypeAsyncKK5 R
(KKR S'
IdentificationTypeUpdateDtoKKS n
valuesKKo u
)KKu v
{LL 	
IdentificationTypeMM 
requestMM &
=MM' (
newMM) ,
(MM, -
valuesMM- 3
.MM3 4 
identificationTypeIdMM4 H
,MMH I
valuesMMJ P
.MMP Q
identificationTypesMMQ d
!MMd e
)MMe f
{NN 

ModifiedByOO 
=OO 
valuesOO #
.OO# $

modifiedByOO$ .
,OO. /

ModifiedOnPP 
=PP 
DateTimePP %
.PP% &
NowPP& )
}QQ 
;QQ 
_unitOfWorkSS 
.SS 
IdentificationTypeSS *
.SS* +
UpdateSS+ 1
(SS1 2
requestSS2 9
)SS9 :
;SS: ;
awaitTT 
_unitOfWorkTT 
.TT 
CompleteTT &
(TT& '
)TT' (
;TT( )
returnVV 
newVV %
IdentificationTypeReadDtoVV 0
(VV0 1
requestVV1 8
.VV8 9 
IdentificationTypeIdVV9 M
,VVM N
requestVVO V
.VVV W
IdentificationTypesVVW j
!VVj k
)VVk l
;VVl m
}WW 	
}YY 
}\\ ñ5
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/GenderService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
;= >
public 
class 
GenderService 
: 
IGenderService +
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

GenderService 
( 
IUnitOfWork $

unitOfWork% /
,/ 0
IMapper1 8
mapper9 ?
)? @
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
GenderReadDto #
># $
AddGenderAsync% 3
(3 4
GenderCreateDto4 C
valuesD J
)J K
{ 
Gender 
gender 
= 
new 
( 
values "
." #
genderId# +
,+ ,
values- 3
.3 4

genderType4 >
!> ?
)? @
{ 	
	CreatedBy 
= 
values 
. 
	createdBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
Gender 
. 
Insert !
(! "
gender" (
)( )
;) *
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
GenderReadDto  
(  !
gender! '
.' (
GenderId( 0
,0 1
gender2 8
.8 9

GenderType9 C
!C D
)D E
;E F
} 
public 

async 
Task 
< 
string 
> 
DeleteGenderAsync /
(/ 0
int0 3
value4 9
)9 :
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
Gender) /
./ 0
Get0 3
(3 4
value4 9
)9 :
;: ;
if   

(   
response   
is   
null   
)   
{!! 	
return"" 
$str"" %
;""% &
}## 	
_unitOfWork%% 
.%% 
Gender%% 
.%% 
Delete%% !
(%%! "
response%%" *
)%%* +
;%%+ ,
await&& 
_unitOfWork&& 
.&& 
Complete&& "
(&&" #
)&&# $
;&&$ %
return(( 
$str(( 
;(( 
})) 
public++ 

async++ 
Task++ 
<++ 
IEnumerable++ !
<++! "
GenderReadDto++" /
>++/ 0
>++0 1
GetGenderAsync++2 @
(++@ A
)++A B
{,, 
var-- 
response-- 
=-- 
await-- 
_unitOfWork-- (
.--( )
Gender--) /
.--/ 0
GetAll--0 6
(--6 7
)--7 8
;--8 9
return.. 
_mapper.. 
... 
Map.. 
<.. 
IEnumerable.. &
<..& '
GenderReadDto..' 4
>..4 5
>..5 6
(..6 7
response..7 ?
)..? @
;..@ A
}// 
public11 

async11 
Task11 
<11 
GenderReadDto11 #
>11# $
GetGenderAsync11% 3
(113 4
int114 7
value118 =
)11= >
{22 
var33 
response33 
=33 
await33 
_unitOfWork33 (
.33( )
Gender33) /
.33/ 0
Get330 3
(333 4
value334 9
)339 :
;33: ;
return44 
_mapper44 
.44 
Map44 
<44 
GenderReadDto44 (
>44( )
(44) *
response44* 2
)442 3
;443 4
}55 
public77 

async77 
Task77 
<77 
GenderReadDto77 #
>77# $
GetGenderAsync77% 3
(773 4
string774 :
value77; @
)77@ A
{88 
var99 
response99 
=99 
await99 
_unitOfWork99 (
.99( )
Gender99) /
.99/ 0
Get990 3
(993 4
g994 5
=>996 8
g999 :
.99: ;

GenderType99; E
==99F H
value99I N
)99N O
;99O P
return:: 
_mapper:: 
.:: 
Map:: 
<:: 
GenderReadDto:: (
>::( )
(::) *
response::* 2
)::2 3
;::3 4
};; 
public== 

async== 
Task== 
<== 
GenderReadDto== #
>==# $
UpdateGenderAsync==% 6
(==6 7
GenderUpdateDto==7 F
values==G M
)==M N
{>> 
Gender?? 
gender?? 
=?? 
new?? 
(?? 
values?? "
.??" #
genderId??# +
,??+ ,
values??- 3
.??3 4

genderType??4 >
!??> ?
)??? @
{@@ 	

ModifiedByAA 
=AA 
valuesAA 
.AA  

modifiedByAA  *
,AA* +

ModifiedOnBB 
=BB 
DateTimeBB !
.BB! "
NowBB" %
}CC 	
;CC	 

_unitOfWorkEE 
.EE 
GenderEE 
.EE 
UpdateEE !
(EE! "
genderEE" (
)EE( )
;EE) *
awaitFF 
_unitOfWorkFF 
.FF 
CompleteFF "
(FF" #
)FF# $
;FF$ %
returnHH 
newHH 
GenderReadDtoHH  
(HH  !
genderHH! '
.HH' (
GenderIdHH( 0
,HH0 1
genderHH2 8
.HH8 9

GenderTypeHH9 C
!HHC D
)HHD E
;HHE F
}II 
}JJ ®7
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Customer/CustomerTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /
Setup/ 4
.4 5
Customer5 =
;= >
public 
class 
CustomerTypeService  
:! " 
ICustomerTypeService# 7
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
IMapper 
_mapper $
;$ %
public 

CustomerTypeService 
( 
IUnitOfWork *

unitOfWork+ 5
,5 6
IMapper7 >
mapper? E
)E F
{		 
_unitOfWork

 
=

 

unitOfWork

  
;

  !
_mapper 
= 
mapper 
; 
} 
public 

async 
Task 
< 
CustomerTypeReadDto )
>) * 
AddCustomerTypeAsync+ ?
(? @!
CustomerTypeCreateDto@ U
valuesV \
)\ ]
{ 
CustomerType 
customerType !
=" #
new$ '
(' (
values( .
.. /
customerTypeId/ =
,= >
values? E
.E F
customerTypesF S
!S T
)T U
{ 	
	CreatedBy 
= 
values 
. 
	createdBy (
,( )
	CreatedOn 
= 
DateTime  
.  !
Now! $
} 	
;	 

_unitOfWork 
. 
CustomerType  
.  !
Insert! '
(' (
customerType( 4
)4 5
;5 6
await 
_unitOfWork 
. 
Complete "
(" #
)# $
;$ %
return 
new 
CustomerTypeReadDto &
(& '
customerType' 3
.3 4
CustomerTypeId4 B
,B C
customerTypeD P
.P Q
CustomerTypesQ ^
!^ _
)_ `
;` a
} 
public 

async 
Task 
< 
string 
> "
DeleteCustomerTyeAsync 4
(4 5
int5 8
value9 >
)> ?
{ 
var 
response 
= 
await 
_unitOfWork (
.( )
CustomerType) 5
.5 6
Get6 9
(9 :
value: ?
)? @
;@ A
if   

(   
response   
is   
null   
)   
{!! 	
return"" 
$str"" 
;""  
}## 	
_unitOfWork%% 
.%% 
CustomerType%%  
.%%  !
Delete%%! '
(%%' (
response%%( 0
)%%0 1
;%%1 2
await&& 
_unitOfWork&& 
.&& 
Complete&& "
(&&" #
)&&# $
;&&$ %
return(( 
$str(( 
;(( 
})) 
public++ 

async++ 
Task++ 
<++ 
IEnumerable++ !
<++! "
CustomerTypeReadDto++" 5
>++5 6
>++6 7 
GetCustomerTypeAsync++8 L
(++L M
)++M N
{,, 
var-- 
response-- 
=-- 
await-- 
_unitOfWork-- (
.--( )
CustomerType--) 5
.--5 6
GetAll--6 <
(--< =
)--= >
;--> ?
return.. 
_mapper.. 
... 
Map.. 
<.. 
IEnumerable.. &
<..& '
CustomerTypeReadDto..' :
>..: ;
>..; <
(..< =
response..= E
)..E F
;..F G
}// 
public11 

async11 
Task11 
<11 
CustomerTypeReadDto11 )
>11) * 
GetCustomerTypeAsync11+ ?
(11? @
int11@ C
value11D I
)11I J
{22 
var33 
response33 
=33 
await33 
_unitOfWork33 (
.33( )
CustomerType33) 5
.335 6
Get336 9
(339 :
value33: ?
)33? @
;33@ A
return44 
_mapper44 
.44 
Map44 
<44 
CustomerTypeReadDto44 .
>44. /
(44/ 0
response440 8
)448 9
;449 :
}55 
public77 

async77 
Task77 
<77 
CustomerTypeReadDto77 )
>77) * 
GetCustomerTypeAsync77+ ?
(77? @
string77@ F
value77G L
)77L M
{88 
var99 
response99 
=99 
await99 
_unitOfWork99 (
.99( )
CustomerType99) 5
.995 6
Get996 9
(999 :
ct99: <
=>99= ?
ct99@ B
.99B C
CustomerTypes99C P
==99Q S
value99T Y
)99Y Z
;99Z [
return:: 
_mapper:: 
.:: 
Map:: 
<:: 
CustomerTypeReadDto:: .
>::. /
(::/ 0
response::0 8
)::8 9
;::9 :
};; 
public== 

async== 
Task== 
<== 
CustomerTypeReadDto== )
>==) *#
UpdateCustomerTypeAsync==+ B
(==B C!
CustomerTypeUpdateDto==C X
values==Y _
)==_ `
{>> 
CustomerType?? 
customerType?? !
=??" #
new??$ '
(??' (
values??( .
.??. /
customerTypeId??/ =
,??= >
values??? E
.??E F
customerTypes??F S
!??S T
)??T U
{@@ 	

ModifiedByAA 
=AA 
valuesAA 
.AA  

modifiedByAA  *
,AA* +

ModifiedOnBB 
=BB 
DateTimeBB !
.BB! "
NowBB" %
}CC 	
;CC	 

_unitOfWorkEE 
.EE 
CustomerTypeEE  
.EE  !
UpdateEE! '
(EE' (
customerTypeEE( 4
)EE4 5
;EE5 6
awaitFF 
_unitOfWorkFF 
.FF 
CompleteFF "
(FF" #
)FF# $
;FF$ %
returnHH 
newHH 
CustomerTypeReadDtoHH &
(HH& '
customerTypeHH' 3
.HH3 4
CustomerTypeIdHH4 B
,HHB C
customerTypeHHD P
.HHP Q
CustomerTypesHHQ ^
!HH^ _
)HH_ `
;HH` a
}II 
}JJ ¢)
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/ModuleServices/ModuleCommunicationServices.cs
	namespace		 	
Modules		
 
.		 
Estates		 
.		 
Application		 %
.		% &
UseCases		& .
.		. /
ModuleServices		/ =
{

 
public 
class '
ModuleCommunicationServices )
:* +(
IModuleCommunicationServices, H
{ 
private 
readonly 

HttpClient #
_httpClient$ /
;/ 0
private 
readonly 
ILogger  
<  !'
ModuleCommunicationServices! <
>< =
_logger> E
;E F
private 
readonly 
IConfiguration '
_config( /
;/ 0
public '
ModuleCommunicationServices *
(* +

HttpClient+ 5

httpClient6 @
,@ A
ILoggerB I
<I J'
ModuleCommunicationServicesJ e
>e f
loggerg m
,m n
IConfigurationo }
config	~ Ñ
)
Ñ Ö
{ 
_httpClient 
= 

httpClient $
;$ %
_logger 
= 
logger 
; 
_config 
= 
config 
; 
} 	
public 
async 
Task 
< 
bool 
> $
SendCustomerDetailsAsync  8
(8 9$
OnlineCustomerDetailsDto9 Q
payloadR Y
)Y Z
{ 	
return 
await 
SendDataAsync &
(& '
$str' J
,J K
payloadL S
)S T
;T U
} 	
public 
async 
Task 
< 
bool 
> '
SendIdentificationTypeAsync  ;
(; <!
IdentificationTypeDto< Q
payloadR Y
)Y Z
{   	
return"" 
await"" 
SendDataAsync"" &
(""& '
$str""' P
,""P Q
payload""R Y
)""Y Z
;""Z [
}$$ 	
public&& 
async&& 
Task&& 
<&& 
bool&& 
>&& $
SendPropertyDetailsAsync&&  8
(&&8 9$
OnlinePropertyDetailsDto&&9 Q
payload&&R Y
)&&Y Z
{'' 	
return)) 
await)) 
SendDataAsync)) &
())& '
$str))' J
,))J K
payload))L S
)))S T
;))T U
}** 	
private-- 
async-- 
Task-- 
<-- 
bool-- 
>--  
SendDataAsync--! .
<--. /
T--/ 0
>--0 1
(--1 2
string--2 8
endpoint--9 A
,--A B
T--C D
payload--E L
)--L M
{.. 	
var// 
baseurl// 
=// 
_config// !
.//! "

GetSection//" ,
(//, -
$str//- 8
)//8 9
.//9 :

GetSection//: D
(//D E
$str//E N
)//N O
.//O P
Value//P U
;//U V
var00 
Url00 
=00 
$"00 
{00 
baseurl00  
}00  !
{00! "
endpoint00" *
}00* +
"00+ ,
;00, -
try22 
{33 
string44 
jsonPayload44 "
=44# $
JsonSerializer44% 3
.443 4
	Serialize444 =
(44= >
payload44> E
)44E F
;44F G
using55 
var55 
httpContent55 %
=55& '
new55( +
StringContent55, 9
(559 :
jsonPayload55: E
,55E F
Encoding55G O
.55O P
UTF855P T
,55T U
$str55V h
)55h i
;55i j
using66 
var66 
response66 "
=66# $
await66% *
_httpClient66+ 6
.666 7
	PostAsync667 @
(66@ A
Url66A D
,66D E
httpContent66F Q
)66Q R
;66R S
if88 
(88 
!88 
response88 
.88 
IsSuccessStatusCode88 1
)881 2
{99 
_logger:: 
.:: 

LogWarning:: &
(::& '
$str::' |
,::| }
endpoint	::~ Ü
,
::Ü á
response
::à ê
.
::ê ë

StatusCode
::ë õ
)
::õ ú
;
::ú ù
};; 
return== 
response== 
.==  
IsSuccessStatusCode==  3
;==3 4
}>> 
catch?? 
(?? 
	Exception?? 
ex?? 
)??  
{@@ 
_loggerAA 
.AA 
LogErrorAA  
(AA  !
exAA! #
,AA# $
$strAA% c
,AAc d
endpointAAe m
)AAm n
;AAn o
returnBB 
falseBB 
;BB 
}CC 
}DD 	
}II 
}JJ æ1
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Property/PropertyMasterService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /

Management/ 9
.9 :
Property: B
{		 
public

 
class

 !
PropertyMasterService

 #
:

$ %"
IPropertyMasterService

& <
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
public !
PropertyMasterService $
($ %
IUnitOfWork% 0

unitOfWork1 ;
,; <
IMapper= D
mapperE K
)K L
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
public 
async 
Task 
< /
#PropertyMasterCreatePlotResponseDto =
>= >
CreateProperty? M
(M N'
PropertyMasterCreatePlotDtoN i
valuesj p
)p q
{ 	
PropertyMaster 
property #
=$ %
PropertyMaster& 4
.4 5
Create5 ;
(; <
values< B
.B C
PropertyMasterIdC S
,S T
valuesU [
.[ \
PropertyTypeId\ j
,j k
valuesl r
.r s
LandUseInitial	s Å
,
Å Ç
values
É â
.
â ä
	LandUseId
ä ì
,
ì î
values
ï õ
.
õ ú 
LandUseTypeInitial
ú Æ
,
Æ Ø
values
∞ ∂
.
∂ ∑
LandUseTypeId
∑ ƒ
,
ƒ ≈
values< B
.B C
LocalityInitialC R
,R S
valuesT Z
.Z [

LocalityId[ e
,e f
valuesg m
.m n"
AllocationTypeInitial	n É
,
É Ñ
values
Ö ã
.
ã å
AllocationTypeId
å ú
,
ú ù
values
û §
.
§ •
BlockNumber
• ∞
!
∞ ±
,
± ≤
values
≥ π
.
π ∫

PlotNumber
∫ ƒ
,
ƒ ≈
values
∆ Ã
.
Ã Õ

AcreageOne
Õ ◊
,
◊ ÿ
values< B
.B C

AcreageTwoC M
,M N
valuesO U
.U V
PropertyHeightIdV f
,f g
valuesh n
.n o

PlotSizeIdo y
,y z
values	{ Å
.
Å Ç
SitePlanNumber
Ç ê
!
ê ë
,
ë í
false
ì ò
)
ò ô
;
ô ö
property 
. 
	CreatedBy 
=  
values! '
.' (
	CreatedBy( 1
;1 2
property 
. 
	CreatedOn 
=  
DateTime! )
.) *
UtcNow* 0
;0 1
_unitOfWork   
.   
PropertyMaster   &
.  & '
Insert  ' -
(  - .
property  . 6
)  6 7
;  7 8
await!! 
_unitOfWork!! 
.!! 
Complete!! &
(!!& '
)!!' (
;!!( )
return## 
new## /
#PropertyMasterCreatePlotResponseDto## :
{$$ 
PropertyNumber%% 
=%%  
property%%! )
.%%) *
PropertyNumber%%* 8
,%%8 9
PropertyType&& 
=&& 
_unitOfWork&& *
.&&* +
PropertyType&&+ 7
.&&7 8
Get&&8 ;
(&&; <
pt&&< >
=>&&? A
pt&&B D
.&&D E
PropertyTypeId&&E S
==&&T V
property&&W _
.&&_ `
PropertyTypeId&&` n
)&&n o
.&&o p
Result&&p v
!&&v w
.&&w x
PropertyTypes	&&x Ö
,
&&Ö Ü
Locality'' 
='' 
_unitOfWork'' &
.''& '
Locality''' /
.''/ 0
Get''0 3
(''3 4
l''4 5
=>''6 8
l''9 :
.'': ;

LocalityId''; E
==''F H
property''I Q
.''Q R

LocalityId''R \
)''\ ]
.''] ^
Result''^ d
!''d e
.''e f
LocalityName''f r
,''r s
LandUse(( 
=(( 
$str(( 
,(( 
LandUseType)) 
=)) 
$str))  
,))  !
AllocationType++ 
=++  
$str++! #
,++# $
BlockNumber,, 
=,, 
$str,,  
,,,  !

PlotNumber.. 
=.. 
$str.. 
,..  

AcreageOne00 
=00 
$num00 
,00 

AcreageTwo22 
=22 
$num22 
,22 
PropertyHeight44 
=44  
$str44! #
,44# $
PlotSize66 
=66 
$str66 
,66 
SitePlanNumber88 
=88  
$str88! #
,88# $
CoordinateOne;; 
=;; 
$str;;  "
,;;" #
CoordinateTwo== 
=== 
$str==  "
,==" #
CoordinateThree?? 
=??  !
$str??" $
,??$ %
CoordinateFourAA 
=AA  
$strAA! #
,AA# $
CoordinateFiveCC 
=CC  
$strCC! #
,CC# $
CoordinateSixEE 
=EE 
$strEE  "
}GG 
;GG 
}II 	
publicKK 
TaskKK 
<KK 
IEnumerableKK 
<KK  
PropertyMasterDtoKK  1
>KK1 2
>KK2 3
GetPropertiesKK4 A
(KKA B
intKKB E

localityIdKKF P
)KKP Q
{LL 	
throwMM 
newMM #
NotImplementedExceptionMM -
(MM- .
)MM. /
;MM/ 0
}NN 	
}OO 
}PP øá
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Customer/CustomerMasterUpdateService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /

Management/ 9
.9 :
Customer: B
{ 
public 

partial 
class !
CustomerMasterService .
:/ 0"
ICustomerMasterService1 G
{ 
public 
async 
Task 
< +
CustomerRegistrationResponseDto 9
>9 :
UpdateCustomer; I
(I J$
UpdateCompanyCustomerDtoJ b
valuesc i
)i j
{ 	
string 
	_imageOne 
= 
string %
.% &
Empty& +
;+ ,
string- 3
	_imageTwo4 =
=> ?
string@ F
.F G
EmptyG L
;L M
stringN T
_imageThreeU `
=a b
stringc i
.i j
Emptyj o
;o p
stringq w

_imageFour	x Ç
=
É Ñ
string
Ö ã
.
ã å
Empty
å ë
;
ë í
string
ì ô

_imageFive
ö §
=
• ¶
string
ß ≠
.
≠ Æ
Empty
Æ ≥
;
≥ ¥
string 

c_imageOne 
= 
string  &
.& '
Empty' ,
;, -
string. 4

c_imageTwo5 ?
=@ A
stringB H
.H I
EmptyI N
;N O
int 

imageCount 
; 

imageCount 
= 
values 
.   
IdentificationImages  4
!4 5
.5 6
Count6 ;
(; <
)< =
;= >
switch 
( 

imageCount 
) 
{ 
case 
$num 
: 
	_imageOne 
= 
values  &
.& ' 
IdentificationImages' ;
!; <
[< =
$num= >
]> ?
;? @
break 
; 
case 
$num 
: 
	_imageOne   
=   
values    &
.  & ' 
IdentificationImages  ' ;
!  ; <
[  < =
$num  = >
]  > ?
;  ? @
	_imageTwo!! 
=!! 
values!!  &
.!!& ' 
IdentificationImages!!' ;
!!!; <
[!!< =
$num!!= >
]!!> ?
;!!? @
break"" 
;"" 
case$$ 
$num$$ 
:$$ 
	_imageOne%% 
=%% 
values%%  &
.%%& ' 
IdentificationImages%%' ;
!%%; <
[%%< =
$num%%= >
]%%> ?
;%%? @
	_imageTwo&& 
=&& 
values&&  &
.&&& ' 
IdentificationImages&&' ;
!&&; <
[&&< =
$num&&= >
]&&> ?
;&&? @
_imageThree'' 
=''  !
values''" (
.''( ) 
IdentificationImages'') =
!''= >
[''> ?
$num''? @
]''@ A
;''A B
break(( 
;(( 
case** 
$num** 
:** 
	_imageOne++ 
=++ 
values++  &
.++& ' 
IdentificationImages++' ;
!++; <
[++< =
$num++= >
]++> ?
;++? @
	_imageTwo,, 
=,, 
values,,  &
.,,& ' 
IdentificationImages,,' ;
!,,; <
[,,< =
$num,,= >
],,> ?
;,,? @
_imageThree-- 
=--  !
values--" (
.--( ) 
IdentificationImages--) =
!--= >
[--> ?
$num--? @
]--@ A
;--A B

_imageFour.. 
=..  
values..! '
...' ( 
IdentificationImages..( <
!..< =
[..= >
$num..> ?
]..? @
;..@ A
break// 
;// 
case11 
$num11 
:11 
	_imageOne22 
=22 
values22  &
.22& ' 
IdentificationImages22' ;
!22; <
[22< =
$num22= >
]22> ?
;22? @
	_imageTwo33 
=33 
values33  &
.33& ' 
IdentificationImages33' ;
!33; <
[33< =
$num33= >
]33> ?
;33? @
_imageThree44 
=44  !
values44" (
.44( ) 
IdentificationImages44) =
!44= >
[44> ?
$num44? @
]44@ A
;44A B

_imageFour55 
=55  
values55! '
.55' ( 
IdentificationImages55( <
!55< =
[55= >
$num55> ?
]55? @
;55@ A

_imageFive66 
=66  
values66! '
.66' ( 
IdentificationImages66( <
!66< =
[66= >
$num66> ?
]66? @
;66@ A
break77 
;77 
}88 

imageCount;; 
=;; 
values;; 
.;;  
ContactPerson;;  -
!;;- .
.;;. /.
"ContactPerson_IdentificationImages;;/ Q
!;;Q R
.;;R S
Count;;S X
(;;X Y
);;Y Z
;;;Z [
switch<< 
(<< 

imageCount<< 
)<< 
{== 
case>> 
$num>> 
:>> 

c_imageOne?? 
=??  
values??! '
.??' ( 
IdentificationImages??( <
!??< =
[??= >
$num??> ?
]??? @
;??@ A
break@@ 
;@@ 
caseBB 
$numBB 
:BB 

c_imageOneCC 
=CC  
valuesCC! '
.CC' ( 
IdentificationImagesCC( <
!CC< =
[CC= >
$numCC> ?
]CC? @
;CC@ A

c_imageTwoDD 
=DD  
valuesDD! '
.DD' ( 
IdentificationImagesDD( <
!DD< =
[DD= >
$numDD> ?
]DD? @
;DD@ A
breakEE 
;EE 
}FF 
tryII 
{JJ 
CustomerMasterKK 
customerKK '
=KK( )
awaitKK* /
CustomerMasterKK0 >
.KK> ?
UpdateCompanyAsyncKK? Q
(LL 
customerMasterIdMM (
:MM( )
valuesMM* 0
.MM0 1
CustomerMasterIdMM1 A
,MMA B
customerTypeIdNN &
:NN& '
valuesNN( .
.NN. /
CustomerTypeIdNN/ =
,NN= >
residentTypeIdOO &
:OO& '
valuesOO( .
.OO. /
ResidentTypeIdOO/ =
,OO= >

localityIdPP "
:PP" #
valuesPP$ *
.PP* +

LocalityIdPP+ 5
,PP5 6
customerCodeQQ $
:QQ$ %
valuesQQ& ,
.QQ, -
CustomerCodeQQ- 9
!QQ9 :
,QQ: ;
companyNameRR #
:RR# $
valuesRR% +
.RR+ ,
CompanyNameRR, 7
!RR7 8
,RR8 9
nationalityIdSS %
:SS% &
valuesSS' -
.SS- .
NationalityIdSS. ;
,SS; <
companyAddressTT &
:TT& '
valuesTT( .
.TT. /
CompanyAddressTT/ =
!TT= >
,TT> ?
digitalAddressUU &
:UU& '
valuesUU( .
.UU. /
DigitalAddressUU/ =
!UU= >
,UU> ?
primaryMobileNumberVV +
:VV+ ,
valuesVV- 3
.VV3 4
PrimaryMobileNumberVV4 G
!VVG H
,VVH I!
secondaryMobileNumberWW -
:WW- .
valuesWW/ 5
.WW5 6!
SecondaryMobileNumberWW6 K
!WWK L
,WWL M
officeNumberXX $
:XX$ %
valuesXX& ,
.XX, -
OfficeNumberXX- 9
!XX9 :
,XX: ;
whatsAppNumberYY &
:YY& '
valuesYY( .
.YY. /
WhatsAppNumberYY/ =
!YY= >
,YY> ?
emailAddressZZ $
:ZZ$ %
valuesZZ& ,
.ZZ, -
EmailAddressZZ- 9
!ZZ9 :
,ZZ: ;&
businessRegistrationNumber[[ 2
:[[2 3
values[[4 :
.[[: ;&
BusinessRegistrationNumber[[; U
![[U V
,[[V W
	tinNumber\\ !
:\\! "
values\\# )
.\\) *
	TinNumber\\* 3
!\\3 4
,\\4 5
socialMediaTypeId]] )
:]]) *
values]]+ 1
.]]1 2
SocialMediaTypeId]]2 C
,]]C D
socialMediaAccount^^ *
:^^* +
values^^, 2
.^^2 3
SocialMediaAccount^^3 E
!^^E F
,^^F G&
identificationTypeImageOne__ 2
:__2 3
	_imageOne__4 =
,__= >&
identificationTypeImageTwo`` 2
:``2 3
	_imageTwo``4 =
,``= >(
identificationTypeImageThreeaa 4
:aa4 5
_imageThreeaa6 A
,aaA B'
identificationTypeImageFourbb 3
:bb3 4

_imageFourbb5 ?
,bb? @'
identificationTypeImageFivecc 3
:cc3 4

_imageFivecc5 ?
,cc? @"
contactPerson_FullNamedd .
:dd. /
valuesdd0 6
.dd6 7
ContactPersondd7 D
!ddD E
.ddE F"
ContactPerson_FullNameddF \
!dd\ ]
,dd] ^%
contactPerson_PhoneNumberee 1
:ee1 2
valuesee3 9
.ee9 :
ContactPersonee: G
.eeG H%
ContactPerson_PhoneNumbereeH a
!eea b
,eeb c&
contactPerson_EmailAddressff 2
:ff2 3
valuesff4 :
.ff: ;
ContactPersonff; H
.ffH I&
ContactPerson_EmailAddressffI c
!ffc d
,ffd e!
contactPerson_Addressgg -
:gg- .
valuesgg/ 5
.gg5 6
ContactPersongg6 C
.ggC D!
ContactPerson_AddressggD Y
!ggY Z
,ggZ [.
"contactPerson_IdentificationTypeIdhh :
:hh: ;
valueshh< B
.hhB C
ContactPersonhhC P
.hhP Q.
"ContactPerson_IdentificationTypeIdhhQ s
,hhs t2
&contactPerson_IdentificationTypeNumberii >
:ii> ?
valuesii@ F
.iiF G
ContactPersoniiG T
.iiT U2
&ContactPerson_IdentificationTypeNumberiiU {
!ii{ |
,ii| }4
(contactPerson_IdentificationTypeImageOnejj @
:jj@ A

c_imageOnejjB L
,jjL M4
(contactPerson_IdentificationTypeImageTwokk @
:kk@ A

c_imageTwokkB L
,kkL M
commentsll  
:ll  !
valuesll" (
.ll( )
Commentsll) 1
!ll1 2
,ll2 3
_domainServicemm &
)nn 
;nn 
customeroo 
.oo 
PostalAddressoo &
=oo' (
valuesoo) /
.oo/ 0
CompanyAddressoo0 >
;oo> ?
customerpp 
.pp 
ResidentialAddresspp +
=pp, -
valuespp. 4
.pp4 5
CompanyAddresspp5 C
;ppC D
customerqq 
.qq 

ModifiedByqq #
=qq$ %
valuesqq& ,
.qq, -

ModifiedByqq- 7
;qq7 8
customerrr 
.rr 

ModifiedOnrr #
=rr$ %
DateTimerr& .
.rr. /
UtcNowrr/ 5
;rr5 6
_unitOfWorkuu 
.uu 
CustomerMasteruu *
.uu* +
Updateuu+ 1
(uu1 2
customeruu2 :
)uu: ;
;uu; <
awaitvv 
_unitOfWorkvv !
.vv! "
Completevv" *
(vv* +
)vv+ ,
;vv, -
varxx 
registeredCustomerxx &
=xx' (
newxx) ,2
&CustomerRegistrationSuccessResponseDtoxx- S
{yy 
CustomerCodezz  
=zz! "
customerzz# +
.zz+ ,
CustomerCodezz, 8
,zz8 9
FullName{{ 
={{ 
customer{{ '
.{{' (
CompanyName{{( 3
!{{3 4
.{{4 5
Trim{{5 9
({{9 :
){{: ;
,{{; <
PhoneNumber|| 
=||  !
customer||" *
.||* +
PrimaryMobileNumber||+ >
,||> ?
}}} 
;}} 
return 
new +
CustomerRegistrationResponseDto :
{; <
	IsSuccess= F
=G H
trueI M
,M N
SuccessResponseO ^
=_ `
registeredCustomera s
}t u
;u v
}
ÄÄ 
catch
ÅÅ 
(
ÅÅ 
	Exception
ÅÅ 
ex
ÅÅ 
)
ÅÅ  
{
ÇÇ 
var
ÉÉ 
err
ÉÉ 
=
ÉÉ 
new
ÉÉ 
BaseResponseDto
ÉÉ -
{
ÉÉ. /

StatusCode
ÉÉ0 :
=
ÉÉ; <
$num
ÉÉ= @
,
ÉÉ@ A
StatusMessage
ÉÉB O
=
ÉÉP Q
ex
ÉÉR T
.
ÉÉT U
InnerException
ÉÉU c
!
ÉÉc d
.
ÉÉd e
Message
ÉÉe l
}
ÉÉm n
;
ÉÉn o
return
ÑÑ 
new
ÑÑ -
CustomerRegistrationResponseDto
ÑÑ :
{
ÑÑ; <
	IsSuccess
ÑÑ= F
=
ÑÑG H
false
ÑÑI N
,
ÑÑN O
ErrorResponse
ÑÑP ]
=
ÑÑ^ _
err
ÑÑ` c
}
ÑÑd e
;
ÑÑe f
}
ÖÖ 
}
ÜÜ 	
public
àà 
async
àà 
Task
àà 
<
àà -
CustomerRegistrationResponseDto
àà 9
>
àà9 :
UpdateCustomer
àà; I
(
ààI J1
#UpdateIndividualResidentCustomerDto
ààJ m
values
ààn t
)
ààt u
{
ââ 	
string
ää 
	_imageOne
ää 
=
ää 
string
ää %
.
ää% &
Empty
ää& +
;
ää+ ,
string
ää- 3
	_imageTwo
ää4 =
=
ää> ?
string
ää@ F
.
ääF G
Empty
ääG L
;
ääL M
string
ääN T
_imageThree
ääU `
=
ääa b
string
ääc i
.
ääi j
Empty
ääj o
;
ääo p
string
ääq w

_imageFourääx Ç
=ääÉ Ñ
stringääÖ ã
.ääã å
Emptyääå ë
;ääë í
stringääì ô

_imageFiveääö §
=ää• ¶
stringääß ≠
.ää≠ Æ
EmptyääÆ ≥
;ää≥ ¥
string
ãã 

c_imageOne
ãã 
=
ãã 
string
ãã  &
.
ãã& '
Empty
ãã' ,
;
ãã, -
string
ãã. 4

c_imageTwo
ãã5 ?
=
ãã@ A
string
ããB H
.
ããH I
Empty
ããI N
;
ããN O
int
åå 

imageCount
åå 
;
åå 

imageCount
éé 
=
éé 
values
éé 
.
éé  "
IdentificationImages
éé  4
!
éé4 5
.
éé5 6
Count
éé6 ;
(
éé; <
)
éé< =
;
éé= >
switch
èè 
(
èè 

imageCount
èè 
)
èè 
{
êê 
case
ëë 
$num
ëë 
:
ëë 
	_imageOne
íí 
=
íí 
values
íí  &
.
íí& '"
IdentificationImages
íí' ;
!
íí; <
[
íí< =
$num
íí= >
]
íí> ?
;
íí? @
break
ìì 
;
ìì 
case
ïï 
$num
ïï 
:
ïï 
	_imageOne
ññ 
=
ññ 
values
ññ  &
.
ññ& '"
IdentificationImages
ññ' ;
!
ññ; <
[
ññ< =
$num
ññ= >
]
ññ> ?
;
ññ? @
	_imageTwo
óó 
=
óó 
values
óó  &
.
óó& '"
IdentificationImages
óó' ;
!
óó; <
[
óó< =
$num
óó= >
]
óó> ?
;
óó? @
break
òò 
;
òò 
case
öö 
$num
öö 
:
öö 
	_imageOne
õõ 
=
õõ 
values
õõ  &
.
õõ& '"
IdentificationImages
õõ' ;
!
õõ; <
[
õõ< =
$num
õõ= >
]
õõ> ?
;
õõ? @
	_imageTwo
úú 
=
úú 
values
úú  &
.
úú& '"
IdentificationImages
úú' ;
!
úú; <
[
úú< =
$num
úú= >
]
úú> ?
;
úú? @
_imageThree
ùù 
=
ùù  !
values
ùù" (
.
ùù( )"
IdentificationImages
ùù) =
!
ùù= >
[
ùù> ?
$num
ùù? @
]
ùù@ A
;
ùùA B
break
ûû 
;
ûû 
case
†† 
$num
†† 
:
†† 
	_imageOne
°° 
=
°° 
values
°°  &
.
°°& '"
IdentificationImages
°°' ;
!
°°; <
[
°°< =
$num
°°= >
]
°°> ?
;
°°? @
	_imageTwo
¢¢ 
=
¢¢ 
values
¢¢  &
.
¢¢& '"
IdentificationImages
¢¢' ;
!
¢¢; <
[
¢¢< =
$num
¢¢= >
]
¢¢> ?
;
¢¢? @
_imageThree
££ 
=
££  !
values
££" (
.
££( )"
IdentificationImages
££) =
!
££= >
[
££> ?
$num
££? @
]
££@ A
;
££A B

_imageFour
§§ 
=
§§  
values
§§! '
.
§§' ("
IdentificationImages
§§( <
!
§§< =
[
§§= >
$num
§§> ?
]
§§? @
;
§§@ A
break
•• 
;
•• 
case
ßß 
$num
ßß 
:
ßß 
	_imageOne
®® 
=
®® 
values
®®  &
.
®®& '"
IdentificationImages
®®' ;
!
®®; <
[
®®< =
$num
®®= >
]
®®> ?
;
®®? @
	_imageTwo
©© 
=
©© 
values
©©  &
.
©©& '"
IdentificationImages
©©' ;
!
©©; <
[
©©< =
$num
©©= >
]
©©> ?
;
©©? @
_imageThree
™™ 
=
™™  !
values
™™" (
.
™™( )"
IdentificationImages
™™) =
!
™™= >
[
™™> ?
$num
™™? @
]
™™@ A
;
™™A B

_imageFour
´´ 
=
´´  
values
´´! '
.
´´' ("
IdentificationImages
´´( <
!
´´< =
[
´´= >
$num
´´> ?
]
´´? @
;
´´@ A

_imageFive
¨¨ 
=
¨¨  
values
¨¨! '
.
¨¨' ("
IdentificationImages
¨¨( <
!
¨¨< =
[
¨¨= >
$num
¨¨> ?
]
¨¨? @
;
¨¨@ A
break
≠≠ 
;
≠≠ 
}
ÆÆ 

imageCount
∞∞ 
=
∞∞ 
values
∞∞ 
.
∞∞  
NonResident
∞∞  +
!
∞∞+ ,
.
∞∞, -0
"ContactPerson_IdentificationImages
∞∞- O
!
∞∞O P
.
∞∞P Q
Count
∞∞Q V
(
∞∞V W
)
∞∞W X
;
∞∞X Y
switch
±± 
(
±± 

imageCount
±± 
)
±± 
{
≤≤ 
case
≥≥ 
$num
≥≥ 
:
≥≥ 

c_imageOne
¥¥ 
=
¥¥  
values
¥¥! '
.
¥¥' ("
IdentificationImages
¥¥( <
!
¥¥< =
[
¥¥= >
$num
¥¥> ?
]
¥¥? @
;
¥¥@ A
break
µµ 
;
µµ 
case
∑∑ 
$num
∑∑ 
:
∑∑ 

c_imageOne
∏∏ 
=
∏∏  
values
∏∏! '
.
∏∏' ("
IdentificationImages
∏∏( <
!
∏∏< =
[
∏∏= >
$num
∏∏> ?
]
∏∏? @
;
∏∏@ A

c_imageTwo
ππ 
=
ππ  
values
ππ! '
.
ππ' ("
IdentificationImages
ππ( <
!
ππ< =
[
ππ= >
$num
ππ> ?
]
ππ? @
;
ππ@ A
break
∫∫ 
;
∫∫ 
}
ªª 
try
ΩΩ 
{
ææ 
CustomerMaster
øø 
customer
øø '
=
øø( )
await
øø* /
CustomerMaster
øø0 >
.
øø> ?#
UpdateIndividualAsync
øø? T
(
¿¿ 
customerMasterId
¡¡ (
:
¡¡( )
values
¡¡* 0
.
¡¡0 1
CustomerMasterId
¡¡1 A
,
¡¡A B
customerTypeId
¬¬ &
:
¬¬& '
values
¬¬( .
.
¬¬. /
CustomerTypeId
¬¬/ =
,
¬¬= >
residentTypeId
√√ &
:
√√& '
values
√√( .
.
√√. /
ResidentTypeId
√√/ =
,
√√= >

localityId
ƒƒ "
:
ƒƒ" #
values
ƒƒ$ *
.
ƒƒ* +

LocalityId
ƒƒ+ 5
,
ƒƒ5 6
customerCode
≈≈ $
:
≈≈$ %
values
≈≈& ,
.
≈≈, -
CustomerCode
≈≈- 9
!
≈≈9 :
,
≈≈: ;
titleId
∆∆ 
:
∆∆  
values
∆∆! '
.
∆∆' (
TitleId
∆∆( /
,
∆∆/ 0
surName
«« 
:
««  
values
««! '
.
««' (
SurName
««( /
,
««/ 0

otherNames
»» "
:
»»" #
values
»»$ *
.
»»* +

OtherNames
»»+ 5
,
»»5 6
dateOfBirth
   #
:
  # $
values
  % +
.
  + ,
DateOfBirth
  , 7
,
  7 8
	tinNumber
ÀÀ !
:
ÀÀ! "
values
ÀÀ# )
.
ÀÀ) *
	TinNumber
ÀÀ* 3
!
ÀÀ3 4
,
ÀÀ4 5
picture
ÃÃ 
:
ÃÃ  
values
ÃÃ! '
.
ÃÃ' (
Picture
ÃÃ( /
!
ÃÃ/ 0
,
ÃÃ0 1
genderId
ÕÕ  
:
ÕÕ  !
values
ÕÕ" (
.
ÕÕ( )
GenderId
ÕÕ) 1
,
ÕÕ1 2
nationalityId
ŒŒ %
:
ŒŒ% &
values
ŒŒ' -
.
ŒŒ- .
NationalityId
ŒŒ. ;
,
ŒŒ; <
postalAddress
œœ %
:
œœ% &
values
œœ' -
.
œœ- .
PostalAddress
œœ. ;
!
œœ; <
,
œœ< = 
residentialAddress
–– *
:
––* +
values
––, 2
.
––2 3 
ResidentialAddress
––3 E
!
––E F
,
––F G
digitalAddress
—— &
:
——& '
values
——( .
.
——. /
DigitalAddress
——/ =
!
——= >
,
——> ?!
primaryMobileNumber
““ +
:
““+ ,
values
““- 3
.
““3 4!
PrimaryMobileNumber
““4 G
!
““G H
,
““H I#
secondaryMobileNumber
”” -
:
””- .
values
””/ 5
.
””5 6#
SecondaryMobileNumber
””6 K
!
””K L
,
””L M
officeNumber
‘‘ $
:
‘‘$ %
values
‘‘& ,
.
‘‘, -
OfficeNumber
‘‘- 9
!
‘‘9 :
,
‘‘: ;
whatsAppNumber
’’ &
:
’’& '
values
’’( .
.
’’. /
WhatsAppNumber
’’/ =
!
’’= >
,
’’> ?
emailAddress
÷÷ $
:
÷÷$ %
values
÷÷& ,
.
÷÷, -
EmailAddress
÷÷- 9
,
÷÷9 :"
residentPermitNumber
◊◊ ,
:
◊◊, -
values
◊◊. 4
.
◊◊4 5

Expatriate
◊◊5 ?
!
◊◊? @
.
◊◊@ A"
ResidentPermitNumber
◊◊A U
!
◊◊U V
,
◊◊V W&
residentPermitDateIssued
ÿÿ 0
:
ÿÿ0 1
values
ÿÿ2 8
.
ÿÿ8 9

Expatriate
ÿÿ9 C
!
ÿÿC D
.
ÿÿD E&
ResidentPermitDateIssued
ÿÿE ]
!
ÿÿ] ^
,
ÿÿ^ _&
residentPermitExpiryDate
ŸŸ 0
:
ŸŸ0 1
values
ŸŸ2 8
.
ŸŸ8 9

Expatriate
ŸŸ9 C
!
ŸŸC D
.
ŸŸD E&
ResidentPermitExpiryDate
ŸŸE ]
!
ŸŸ] ^
,
ŸŸ^ _
socialMediaTypeId
⁄⁄ )
:
⁄⁄) *
values
⁄⁄+ 1
.
⁄⁄1 2
SocialMediaTypeId
⁄⁄2 C
,
⁄⁄C D 
socialMediaAccount
€€ *
:
€€* +
values
€€, 2
.
€€2 3 
SocialMediaAccount
€€3 E
!
€€E F
,
€€F G"
identificationTypeId
‹‹ ,
:
‹‹, -
values
‹‹. 4
.
‹‹4 5"
IdentificationTypeId
‹‹5 I
,
‹‹I J&
identificationTypeNumber
›› 0
:
››0 1
values
››2 8
.
››8 9&
IdentificationTypeNumber
››9 Q
!
››Q R
,
››R S(
identificationTypeImageOne
ﬁﬁ 2
:
ﬁﬁ2 3
	_imageOne
ﬁﬁ4 =
,
ﬁﬁ= >(
identificationTypeImageTwo
ﬂﬂ 2
:
ﬂﬂ2 3
	_imageTwo
ﬂﬂ4 =
,
ﬂﬂ= >*
identificationTypeImageThree
‡‡ 4
:
‡‡4 5
_imageThree
‡‡6 A
,
‡‡A B)
identificationTypeImageFour
·· 3
:
··3 4

_imageFour
··5 ?
,
··? @)
identificationTypeImageFive
‚‚ 3
:
‚‚3 4

_imageFive
‚‚5 ?
,
‚‚? @
comments
„„  
:
„„  !
values
„„" (
.
„„( )
Comments
„„) 1
!
„„1 2
,
„„2 3
interestExpressed
‰‰ )
:
‰‰) *
string
‰‰+ 1
.
‰‰1 2
Empty
‰‰2 7
,
‰‰7 8
debtorStatus
ÂÂ $
:
ÂÂ$ %
$num
ÂÂ& '
,
ÂÂ' (

parentCode
ÊÊ "
:
ÊÊ" #
string
ÊÊ$ *
.
ÊÊ* +
Empty
ÊÊ+ 0
,
ÊÊ0 1$
contactPerson_FullName
ÁÁ .
:
ÁÁ. /
values
ÁÁ0 6
.
ÁÁ6 7
NonResident
ÁÁ7 B
.
ÁÁB C$
ContactPerson_FullName
ÁÁC Y
!
ÁÁY Z
,
ÁÁZ ['
contactPerson_PhoneNumber
ËË 1
:
ËË1 2
values
ËË3 9
.
ËË9 :
NonResident
ËË: E
.
ËËE F'
ContactPerson_PhoneNumber
ËËF _
!
ËË_ `
,
ËË` a(
contactPerson_EmailAddress
ÈÈ 2
:
ÈÈ2 3
values
ÈÈ4 :
.
ÈÈ: ;
NonResident
ÈÈ; F
.
ÈÈF G(
ContactPerson_EmailAddress
ÈÈG a
!
ÈÈa b
,
ÈÈb c#
contactPerson_Address
ÍÍ -
:
ÍÍ- .
values
ÍÍ/ 5
.
ÍÍ5 6
NonResident
ÍÍ6 A
.
ÍÍA B#
ContactPerson_Address
ÍÍB W
!
ÍÍW X
,
ÍÍX Y0
"contactPerson_IdentificationTypeId
ÎÎ :
:
ÎÎ: ;
values
ÎÎ< B
.
ÎÎB C
NonResident
ÎÎC N
.
ÎÎN O0
"ContactPerson_IdentificationTypeId
ÎÎO q
,
ÎÎq r4
&contactPerson_IdentificationTypeNumber
ÏÏ >
:
ÏÏ> ?
values
ÏÏ@ F
.
ÏÏF G
NonResident
ÏÏG R
.
ÏÏR S4
&ContactPerson_IdentificationTypeNumber
ÏÏS y
!
ÏÏy z
,
ÏÏz {6
(contactPerson_IdentificationTypeImageOne
ÌÌ @
:
ÌÌ@ A

c_imageOne
ÌÌB L
,
ÌÌL M6
(contactPerson_IdentificationTypeImageTwo
ÓÓ @
:
ÓÓ@ A

c_imageOne
ÓÓB L
,
ÓÓL M
_domainService
ÔÔ &
)
 
;
 
customer
ÚÚ 
.
ÚÚ 
	CreatedBy
ÚÚ "
=
ÚÚ# $
values
ÚÚ% +
.
ÚÚ+ ,

ModifiedBy
ÚÚ, 6
;
ÚÚ6 7
customer
ÛÛ 
.
ÛÛ 
	CreatedOn
ÛÛ "
=
ÛÛ# $
DateTime
ÛÛ% -
.
ÛÛ- .
UtcNow
ÛÛ. 4
;
ÛÛ4 5
_unitOfWork
ıı 
.
ıı 
CustomerMaster
ıı *
.
ıı* +
Update
ıı+ 1
(
ıı1 2
customer
ıı2 :
)
ıı: ;
;
ıı; <
await
ˆˆ 
_unitOfWork
ˆˆ !
.
ˆˆ! "
Complete
ˆˆ" *
(
ˆˆ* +
)
ˆˆ+ ,
;
ˆˆ, -
var
˙˙ 
_title
˙˙ 
=
˙˙ 
(
˙˙ 
await
˙˙ #
_unitOfWork
˙˙$ /
.
˙˙/ 0
Title
˙˙0 5
.
˙˙5 6
Get
˙˙6 9
(
˙˙9 :
t
˙˙: ;
=>
˙˙< >
t
˙˙? @
.
˙˙@ A
TitleId
˙˙A H
==
˙˙I K
customer
˙˙L T
.
˙˙T U
TitleId
˙˙U \
)
˙˙\ ]
)
˙˙] ^
!
˙˙^ _
.
˙˙_ `
Titles
˙˙` f
;
˙˙f g
var
˚˚ 
customername
˚˚  
=
˚˚! "
string
˚˚# )
.
˚˚) *
Concat
˚˚* 0
(
˚˚0 1
_title
˚˚1 7
,
˚˚7 8
$str
˚˚9 <
,
˚˚< =
customer
˚˚> F
.
˚˚F G

OtherNames
˚˚G Q
,
˚˚Q R
$str
˚˚S V
,
˚˚V W
customer
˚˚X `
.
˚˚` a
SurName
˚˚a h
)
˚˚h i
.
˚˚i j
Trim
˚˚j n
(
˚˚n o
)
˚˚o p
;
˚˚p q
var
˝˝  
registeredCustomer
˝˝ &
=
˝˝' (
new
˝˝) ,4
&CustomerRegistrationSuccessResponseDto
˝˝- S
{
˛˛ 
CustomerCode
ˇˇ  
=
ˇˇ! "
customer
ˇˇ# +
.
ˇˇ+ ,
CustomerCode
ˇˇ, 8
,
ˇˇ8 9
FullName
ÄÄ 
=
ÄÄ 
customername
ÄÄ +
,
ÄÄ+ ,
PhoneNumber
ÅÅ 
=
ÅÅ  !
customer
ÅÅ" *
.
ÅÅ* +!
PrimaryMobileNumber
ÅÅ+ >
,
ÅÅ> ?
}
ÇÇ 
;
ÇÇ 
return
ÑÑ 
new
ÑÑ -
CustomerRegistrationResponseDto
ÑÑ :
{
ÑÑ; <
	IsSuccess
ÑÑ= F
=
ÑÑG H
true
ÑÑI M
,
ÑÑM N
SuccessResponse
ÑÑO ^
=
ÑÑ_ ` 
registeredCustomer
ÑÑa s
}
ÑÑt u
;
ÑÑu v
}
ÖÖ 
catch
ÜÜ 
(
ÜÜ 
	Exception
ÜÜ 
ex
ÜÜ 
)
ÜÜ  
{
áá 
var
àà 
err
àà 
=
àà 
new
àà 
BaseResponseDto
àà -
{
àà. /

StatusCode
àà0 :
=
àà; <
$num
àà= @
,
àà@ A
StatusMessage
ààB O
=
ààP Q
ex
ààR T
.
ààT U
InnerException
ààU c
!
ààc d
.
ààd e
Message
ààe l
}
ààm n
;
ààn o
return
ââ 
new
ââ -
CustomerRegistrationResponseDto
ââ :
{
ââ; <
	IsSuccess
ââ= F
=
ââG H
false
ââI N
,
ââN O
ErrorResponse
ââP ]
=
ââ^ _
err
ââ` c
}
ââd e
;
ââe f
}
ãã 
}
åå 	
public
éé 
async
éé 
Task
éé 
<
éé -
CustomerRegistrationResponseDto
éé 9
>
éé9 :
UpdateCustomer
éé; I
(
ééI J-
UpdateJointOwnershipCustomerDto
ééJ i
values
ééj p
)
éép q
{
èè 	
string
êê 
	_imageOne
êê 
=
êê 
string
êê %
.
êê% &
Empty
êê& +
;
êê+ ,
string
êê- 3
	_imageTwo
êê4 =
=
êê> ?
string
êê@ F
.
êêF G
Empty
êêG L
;
êêL M
string
êêN T
_imageThree
êêU `
=
êêa b
string
êêc i
.
êêi j
Empty
êêj o
;
êêo p
string
êêq w

_imageFourêêx Ç
=êêÉ Ñ
stringêêÖ ã
.êêã å
Emptyêêå ë
;êêë í
stringêêì ô

_imageFiveêêö §
=êê• ¶
stringêêß ≠
.êê≠ Æ
EmptyêêÆ ≥
;êê≥ ¥
string
ëë 

c_imageOne
ëë 
=
ëë 
string
ëë  &
.
ëë& '
Empty
ëë' ,
;
ëë, -
string
ëë. 4

c_imageTwo
ëë5 ?
=
ëë@ A
string
ëëB H
.
ëëH I
Empty
ëëI N
;
ëëN O
int
íí 

imageCount
íí 
;
íí 

imageCount
îî 
=
îî 
values
îî 
.
îî  "
IdentificationImages
îî  4
!
îî4 5
.
îî5 6
Count
îî6 ;
(
îî; <
)
îî< =
;
îî= >
switch
ïï 
(
ïï 

imageCount
ïï 
)
ïï 
{
ññ 
case
óó 
$num
óó 
:
óó 
	_imageOne
òò 
=
òò 
values
òò  &
.
òò& '"
IdentificationImages
òò' ;
!
òò; <
[
òò< =
$num
òò= >
]
òò> ?
;
òò? @
break
ôô 
;
ôô 
case
õõ 
$num
õõ 
:
õõ 
	_imageOne
úú 
=
úú 
values
úú  &
.
úú& '"
IdentificationImages
úú' ;
!
úú; <
[
úú< =
$num
úú= >
]
úú> ?
;
úú? @
	_imageTwo
ùù 
=
ùù 
values
ùù  &
.
ùù& '"
IdentificationImages
ùù' ;
!
ùù; <
[
ùù< =
$num
ùù= >
]
ùù> ?
;
ùù? @
break
ûû 
;
ûû 
case
†† 
$num
†† 
:
†† 
	_imageOne
°° 
=
°° 
values
°°  &
.
°°& '"
IdentificationImages
°°' ;
!
°°; <
[
°°< =
$num
°°= >
]
°°> ?
;
°°? @
	_imageTwo
¢¢ 
=
¢¢ 
values
¢¢  &
.
¢¢& '"
IdentificationImages
¢¢' ;
!
¢¢; <
[
¢¢< =
$num
¢¢= >
]
¢¢> ?
;
¢¢? @
_imageThree
££ 
=
££  !
values
££" (
.
££( )"
IdentificationImages
££) =
!
££= >
[
££> ?
$num
££? @
]
££@ A
;
££A B
break
§§ 
;
§§ 
case
¶¶ 
$num
¶¶ 
:
¶¶ 
	_imageOne
ßß 
=
ßß 
values
ßß  &
.
ßß& '"
IdentificationImages
ßß' ;
!
ßß; <
[
ßß< =
$num
ßß= >
]
ßß> ?
;
ßß? @
	_imageTwo
®® 
=
®® 
values
®®  &
.
®®& '"
IdentificationImages
®®' ;
!
®®; <
[
®®< =
$num
®®= >
]
®®> ?
;
®®? @
_imageThree
©© 
=
©©  !
values
©©" (
.
©©( )"
IdentificationImages
©©) =
!
©©= >
[
©©> ?
$num
©©? @
]
©©@ A
;
©©A B

_imageFour
™™ 
=
™™  
values
™™! '
.
™™' ("
IdentificationImages
™™( <
!
™™< =
[
™™= >
$num
™™> ?
]
™™? @
;
™™@ A
break
´´ 
;
´´ 
case
≠≠ 
$num
≠≠ 
:
≠≠ 
	_imageOne
ÆÆ 
=
ÆÆ 
values
ÆÆ  &
.
ÆÆ& '"
IdentificationImages
ÆÆ' ;
!
ÆÆ; <
[
ÆÆ< =
$num
ÆÆ= >
]
ÆÆ> ?
;
ÆÆ? @
	_imageTwo
ØØ 
=
ØØ 
values
ØØ  &
.
ØØ& '"
IdentificationImages
ØØ' ;
!
ØØ; <
[
ØØ< =
$num
ØØ= >
]
ØØ> ?
;
ØØ? @
_imageThree
∞∞ 
=
∞∞  !
values
∞∞" (
.
∞∞( )"
IdentificationImages
∞∞) =
!
∞∞= >
[
∞∞> ?
$num
∞∞? @
]
∞∞@ A
;
∞∞A B

_imageFour
±± 
=
±±  
values
±±! '
.
±±' ("
IdentificationImages
±±( <
!
±±< =
[
±±= >
$num
±±> ?
]
±±? @
;
±±@ A

_imageFive
≤≤ 
=
≤≤  
values
≤≤! '
.
≤≤' ("
IdentificationImages
≤≤( <
!
≤≤< =
[
≤≤= >
$num
≤≤> ?
]
≤≤? @
;
≤≤@ A
break
≥≥ 
;
≥≥ 
}
¥¥ 

imageCount
∑∑ 
=
∑∑ 
values
∑∑ 
.
∑∑  
NonResident
∑∑  +
!
∑∑+ ,
.
∑∑, -0
"ContactPerson_IdentificationImages
∑∑- O
!
∑∑O P
.
∑∑P Q
Count
∑∑Q V
(
∑∑V W
)
∑∑W X
;
∑∑X Y
switch
∏∏ 
(
∏∏ 

imageCount
∏∏ 
)
∏∏ 
{
ππ 
case
∫∫ 
$num
∫∫ 
:
∫∫ 

c_imageOne
ªª 
=
ªª  
values
ªª! '
.
ªª' ("
IdentificationImages
ªª( <
!
ªª< =
[
ªª= >
$num
ªª> ?
]
ªª? @
;
ªª@ A
break
ºº 
;
ºº 
case
ææ 
$num
ææ 
:
ææ 

c_imageOne
øø 
=
øø  
values
øø! '
.
øø' ("
IdentificationImages
øø( <
!
øø< =
[
øø= >
$num
øø> ?
]
øø? @
;
øø@ A

c_imageTwo
¿¿ 
=
¿¿  
values
¿¿! '
.
¿¿' ("
IdentificationImages
¿¿( <
!
¿¿< =
[
¿¿= >
$num
¿¿> ?
]
¿¿? @
;
¿¿@ A
break
¡¡ 
;
¡¡ 
}
¬¬ 
CustomerMaster
≈≈ 
customer
≈≈ #
=
≈≈$ %
await
≈≈& +
CustomerMaster
≈≈, :
.
≈≈: ;
UpdateJointAsync
≈≈; K
(
∆∆ 
customerMasterId
«« $
:
««$ %
values
««& ,
.
««, -
CustomerMasterId
««- =
,
««= >
customerTypeId
»» "
:
»»" #
values
»»$ *
.
»»* +
CustomerTypeId
»»+ 9
,
»»9 :
residentTypeId
…… "
:
……" #
values
……$ *
.
……* +
ResidentTypeId
……+ 9
,
……9 :

localityId
   
:
   
values
    &
.
  & '

LocalityId
  ' 1
,
  1 2
customerCode
ÀÀ  
:
ÀÀ  !
values
ÀÀ" (
.
ÀÀ( )
CustomerCode
ÀÀ) 5
!
ÀÀ5 6
,
ÀÀ6 7
titleId
ÃÃ 
:
ÃÃ 
values
ÃÃ #
.
ÃÃ# $
TitleId
ÃÃ$ +
,
ÃÃ+ ,
surName
ÕÕ 
:
ÕÕ 
values
ÕÕ #
.
ÕÕ# $
SurName
ÕÕ$ +
,
ÕÕ+ ,

otherNames
ŒŒ 
:
ŒŒ 
values
ŒŒ  &
.
ŒŒ& '

OtherNames
ŒŒ' 1
,
ŒŒ1 2
dateOfBirth
–– 
:
––  
values
––! '
.
––' (
DateOfBirth
––( 3
,
––3 4
	tinNumber
—— 
:
—— 
values
—— %
.
——% &
	TinNumber
——& /
!
——/ 0
,
——0 1
picture
““ 
:
““ 
values
““ #
.
““# $
Picture
““$ +
!
““+ ,
,
““, -
genderId
”” 
:
”” 
values
”” $
.
””$ %
GenderId
””% -
,
””- .
nationalityId
‘‘ !
:
‘‘! "
values
‘‘# )
.
‘‘) *
NationalityId
‘‘* 7
,
‘‘7 8
postalAddress
’’ !
:
’’! "
values
’’# )
.
’’) *
PostalAddress
’’* 7
!
’’7 8
,
’’8 9 
residentialAddress
÷÷ &
:
÷÷& '
values
÷÷( .
.
÷÷. / 
ResidentialAddress
÷÷/ A
!
÷÷A B
,
÷÷B C
digitalAddress
◊◊ "
:
◊◊" #
values
◊◊$ *
.
◊◊* +
DigitalAddress
◊◊+ 9
!
◊◊9 :
,
◊◊: ;!
primaryMobileNumber
ÿÿ '
:
ÿÿ' (
values
ÿÿ) /
.
ÿÿ/ 0!
PrimaryMobileNumber
ÿÿ0 C
!
ÿÿC D
,
ÿÿD E#
secondaryMobileNumber
ŸŸ )
:
ŸŸ) *
values
ŸŸ+ 1
.
ŸŸ1 2#
SecondaryMobileNumber
ŸŸ2 G
!
ŸŸG H
,
ŸŸH I
officeNumber
⁄⁄  
:
⁄⁄  !
values
⁄⁄" (
.
⁄⁄( )
OfficeNumber
⁄⁄) 5
!
⁄⁄5 6
,
⁄⁄6 7
whatsAppNumber
€€ "
:
€€" #
values
€€$ *
.
€€* +
WhatsAppNumber
€€+ 9
!
€€9 :
,
€€: ;
emailAddress
‹‹  
:
‹‹  !
values
‹‹" (
.
‹‹( )
EmailAddress
‹‹) 5
,
‹‹5 6"
residentPermitNumber
›› (
:
››( )
values
››* 0
.
››0 1

Expatriate
››1 ;
!
››; <
.
››< ="
ResidentPermitNumber
››= Q
!
››Q R
,
››R S&
residentPermitDateIssued
ﬁﬁ ,
:
ﬁﬁ, -
values
ﬁﬁ. 4
.
ﬁﬁ4 5

Expatriate
ﬁﬁ5 ?
!
ﬁﬁ? @
.
ﬁﬁ@ A&
ResidentPermitDateIssued
ﬁﬁA Y
!
ﬁﬁY Z
,
ﬁﬁZ [&
residentPermitExpiryDate
ﬂﬂ ,
:
ﬂﬂ, -
values
ﬂﬂ. 4
.
ﬂﬂ4 5

Expatriate
ﬂﬂ5 ?
!
ﬂﬂ? @
.
ﬂﬂ@ A&
ResidentPermitExpiryDate
ﬂﬂA Y
!
ﬂﬂY Z
,
ﬂﬂZ [
socialMediaTypeId
‡‡ %
:
‡‡% &
values
‡‡' -
.
‡‡- .
SocialMediaTypeId
‡‡. ?
,
‡‡? @ 
socialMediaAccount
·· &
:
··& '
values
··( .
.
··. / 
SocialMediaAccount
··/ A
!
··A B
,
··B C"
identificationTypeId
‚‚ (
:
‚‚( )
values
‚‚* 0
.
‚‚0 1"
IdentificationTypeId
‚‚1 E
,
‚‚E F&
identificationTypeNumber
„„ ,
:
„„, -
values
„„. 4
.
„„4 5&
IdentificationTypeNumber
„„5 M
!
„„M N
,
„„N O(
identificationTypeImageOne
‰‰ .
:
‰‰. /
	_imageOne
‰‰0 9
,
‰‰9 :(
identificationTypeImageTwo
ÂÂ .
:
ÂÂ. /
	_imageTwo
ÂÂ0 9
,
ÂÂ9 :*
identificationTypeImageThree
ÊÊ 0
:
ÊÊ0 1
_imageThree
ÊÊ2 =
,
ÊÊ= >)
identificationTypeImageFour
ÁÁ /
:
ÁÁ/ 0

_imageFour
ÁÁ1 ;
,
ÁÁ; <)
identificationTypeImageFive
ËË /
:
ËË/ 0

_imageFive
ËË1 ;
,
ËË; <
comments
ÈÈ 
:
ÈÈ 
values
ÈÈ $
.
ÈÈ$ %
Comments
ÈÈ% -
!
ÈÈ- .
,
ÈÈ. /
interestExpressed
ÍÍ %
:
ÍÍ% &
string
ÍÍ' -
.
ÍÍ- .
Empty
ÍÍ. 3
,
ÍÍ3 4
debtorStatus
ÎÎ  
:
ÎÎ  !
$num
ÎÎ" #
,
ÎÎ# $

parentCode
ÏÏ 
:
ÏÏ 
string
ÏÏ  &
.
ÏÏ& '
Empty
ÏÏ' ,
,
ÏÏ, -$
contactPerson_FullName
ÌÌ *
:
ÌÌ* +
values
ÌÌ, 2
.
ÌÌ2 3
NonResident
ÌÌ3 >
.
ÌÌ> ?$
ContactPerson_FullName
ÌÌ? U
!
ÌÌU V
,
ÌÌV W'
contactPerson_PhoneNumber
ÓÓ -
:
ÓÓ- .
values
ÓÓ/ 5
.
ÓÓ5 6
NonResident
ÓÓ6 A
.
ÓÓA B'
ContactPerson_PhoneNumber
ÓÓB [
!
ÓÓ[ \
,
ÓÓ\ ](
contactPerson_EmailAddress
ÔÔ .
:
ÔÔ. /
values
ÔÔ0 6
.
ÔÔ6 7
NonResident
ÔÔ7 B
.
ÔÔB C(
ContactPerson_EmailAddress
ÔÔC ]
!
ÔÔ] ^
,
ÔÔ^ _#
contactPerson_Address
 )
:
) *
values
+ 1
.
1 2
NonResident
2 =
.
= >#
ContactPerson_Address
> S
!
S T
,
T U0
"contactPerson_IdentificationTypeId
ÒÒ 6
:
ÒÒ6 7
values
ÒÒ8 >
.
ÒÒ> ?
NonResident
ÒÒ? J
.
ÒÒJ K0
"ContactPerson_IdentificationTypeId
ÒÒK m
,
ÒÒm n4
&contactPerson_IdentificationTypeNumber
ÚÚ :
:
ÚÚ: ;
values
ÚÚ< B
.
ÚÚB C
NonResident
ÚÚC N
.
ÚÚN O4
&ContactPerson_IdentificationTypeNumber
ÚÚO u
!
ÚÚu v
,
ÚÚv w6
(contactPerson_IdentificationTypeImageOne
ÛÛ <
:
ÛÛ< =

c_imageOne
ÛÛ> H
,
ÛÛH I6
(contactPerson_IdentificationTypeImageTwo
ÙÙ <
:
ÙÙ< =

c_imageTwo
ÙÙ> H
,
ÙÙH I
maritalStatus
ıı !
:
ıı! "
values
ıı# )
.
ıı) *
MaritalStatus
ıı* 7
!
ıı7 8
,
ıı8 9
dateOfMarriage
ˆˆ "
:
ˆˆ" #
values
ˆˆ$ *
.
ˆˆ* +
DateOfMarriage
ˆˆ+ 9
!
ˆˆ9 :
,
ˆˆ: ;
_domainService
˜˜ "
)
¯¯ 
;
¯¯ 
customer
˙˙ 
.
˙˙ 

ModifiedBy
˙˙ 
=
˙˙  !
values
˙˙" (
.
˙˙( )

ModifiedBy
˙˙) 3
;
˙˙3 4
customer
˚˚ 
.
˚˚ 

ModifiedOn
˚˚ 
=
˚˚  !
DateTime
˚˚" *
.
˚˚* +
UtcNow
˚˚+ 1
;
˚˚1 2
_unitOfWork
ˇˇ 
.
ˇˇ 
CustomerMaster
ˇˇ &
.
ˇˇ& '
Update
ˇˇ' -
(
ˇˇ- .
customer
ˇˇ. 6
)
ˇˇ6 7
;
ˇˇ7 8
await
ÄÄ 
_unitOfWork
ÄÄ 
.
ÄÄ 
Complete
ÄÄ &
(
ÄÄ& '
)
ÄÄ' (
;
ÄÄ( )
var
ÉÉ 
_title
ÉÉ 
=
ÉÉ 
(
ÉÉ 
await
ÉÉ 
_unitOfWork
ÉÉ  +
.
ÉÉ+ ,
Title
ÉÉ, 1
.
ÉÉ1 2
Get
ÉÉ2 5
(
ÉÉ5 6
t
ÉÉ6 7
=>
ÉÉ8 :
t
ÉÉ; <
.
ÉÉ< =
TitleId
ÉÉ= D
==
ÉÉE G
customer
ÉÉH P
.
ÉÉP Q
TitleId
ÉÉQ X
)
ÉÉX Y
)
ÉÉY Z
!
ÉÉZ [
.
ÉÉ[ \
Titles
ÉÉ\ b
;
ÉÉb c
var
ÑÑ 
customername
ÑÑ 
=
ÑÑ 
string
ÑÑ %
.
ÑÑ% &
Concat
ÑÑ& ,
(
ÑÑ, -
_title
ÑÑ- 3
,
ÑÑ3 4
$str
ÑÑ5 8
,
ÑÑ8 9
customer
ÑÑ: B
.
ÑÑB C

OtherNames
ÑÑC M
,
ÑÑM N
$str
ÑÑO R
,
ÑÑR S
customer
ÑÑT \
.
ÑÑ\ ]
SurName
ÑÑ] d
)
ÑÑd e
.
ÑÑe f
Trim
ÑÑf j
(
ÑÑj k
)
ÑÑk l
;
ÑÑl m
var
ÜÜ  
registeredCustomer
ÜÜ "
=
ÜÜ# $
new
ÜÜ% (4
&CustomerRegistrationSuccessResponseDto
ÜÜ) O
{
áá 
CustomerCode
àà 
=
àà 
customer
àà '
.
àà' (
CustomerCode
àà( 4
,
àà4 5
FullName
ââ 
=
ââ 
customername
ââ '
,
ââ' (
PhoneNumber
ää 
=
ää 
customer
ää &
.
ää& '!
PrimaryMobileNumber
ää' :
,
ää: ;
}
ãã 
;
ãã 
return
çç 
new
çç -
CustomerRegistrationResponseDto
çç 6
{
çç7 8
	IsSuccess
çç9 B
=
ççC D
true
ççE I
,
ççI J
SuccessResponse
ççK Z
=
çç[ \ 
registeredCustomer
çç] o
}
ççp q
;
ççq r
}
éé 	
public
êê 
async
êê 
Task
êê 
<
êê -
CustomerRegistrationResponseDto
êê 9
>
êê9 :
UpdateCustomer
êê; I
(
êêI J-
UpdateMultiOwnershipCustomerDto
êêJ i
values
êêj p
)
êêp q
{
ëë 	
string
íí 
	_imageOne
íí 
=
íí 
string
íí %
.
íí% &
Empty
íí& +
;
íí+ ,
string
íí- 3
	_imageTwo
íí4 =
=
íí> ?
string
íí@ F
.
ííF G
Empty
ííG L
;
ííL M
string
ííN T
_imageThree
ííU `
=
íía b
string
ííc i
.
ííi j
Empty
ííj o
;
íío p
string
ííq w

_imageFourííx Ç
=ííÉ Ñ
stringííÖ ã
.ííã å
Emptyííå ë
;ííë í
stringííì ô

_imageFiveííö §
=íí• ¶
stringííß ≠
.íí≠ Æ
EmptyííÆ ≥
;íí≥ ¥
string
ìì 

c_imageOne
ìì 
=
ìì 
string
ìì  &
.
ìì& '
Empty
ìì' ,
;
ìì, -
string
ìì. 4

c_imageTwo
ìì5 ?
=
ìì@ A
string
ììB H
.
ììH I
Empty
ììI N
;
ììN O
int
îî 

imageCount
îî 
;
îî 

imageCount
ññ 
=
ññ 
values
ññ 
.
ññ  "
IdentificationImages
ññ  4
!
ññ4 5
.
ññ5 6
Count
ññ6 ;
(
ññ; <
)
ññ< =
;
ññ= >
switch
óó 
(
óó 

imageCount
óó 
)
óó 
{
òò 
case
ôô 
$num
ôô 
:
ôô 
	_imageOne
öö 
=
öö 
values
öö  &
.
öö& '"
IdentificationImages
öö' ;
!
öö; <
[
öö< =
$num
öö= >
]
öö> ?
;
öö? @
break
õõ 
;
õõ 
case
ùù 
$num
ùù 
:
ùù 
	_imageOne
ûû 
=
ûû 
values
ûû  &
.
ûû& '"
IdentificationImages
ûû' ;
!
ûû; <
[
ûû< =
$num
ûû= >
]
ûû> ?
;
ûû? @
	_imageTwo
üü 
=
üü 
values
üü  &
.
üü& '"
IdentificationImages
üü' ;
!
üü; <
[
üü< =
$num
üü= >
]
üü> ?
;
üü? @
break
†† 
;
†† 
case
¢¢ 
$num
¢¢ 
:
¢¢ 
	_imageOne
££ 
=
££ 
values
££  &
.
££& '"
IdentificationImages
££' ;
!
££; <
[
££< =
$num
££= >
]
££> ?
;
££? @
	_imageTwo
§§ 
=
§§ 
values
§§  &
.
§§& '"
IdentificationImages
§§' ;
!
§§; <
[
§§< =
$num
§§= >
]
§§> ?
;
§§? @
_imageThree
•• 
=
••  !
values
••" (
.
••( )"
IdentificationImages
••) =
!
••= >
[
••> ?
$num
••? @
]
••@ A
;
••A B
break
¶¶ 
;
¶¶ 
case
®® 
$num
®® 
:
®® 
	_imageOne
©© 
=
©© 
values
©©  &
.
©©& '"
IdentificationImages
©©' ;
!
©©; <
[
©©< =
$num
©©= >
]
©©> ?
;
©©? @
	_imageTwo
™™ 
=
™™ 
values
™™  &
.
™™& '"
IdentificationImages
™™' ;
!
™™; <
[
™™< =
$num
™™= >
]
™™> ?
;
™™? @
_imageThree
´´ 
=
´´  !
values
´´" (
.
´´( )"
IdentificationImages
´´) =
!
´´= >
[
´´> ?
$num
´´? @
]
´´@ A
;
´´A B

_imageFour
¨¨ 
=
¨¨  
values
¨¨! '
.
¨¨' ("
IdentificationImages
¨¨( <
!
¨¨< =
[
¨¨= >
$num
¨¨> ?
]
¨¨? @
;
¨¨@ A
break
≠≠ 
;
≠≠ 
case
ØØ 
$num
ØØ 
:
ØØ 
	_imageOne
∞∞ 
=
∞∞ 
values
∞∞  &
.
∞∞& '"
IdentificationImages
∞∞' ;
!
∞∞; <
[
∞∞< =
$num
∞∞= >
]
∞∞> ?
;
∞∞? @
	_imageTwo
±± 
=
±± 
values
±±  &
.
±±& '"
IdentificationImages
±±' ;
!
±±; <
[
±±< =
$num
±±= >
]
±±> ?
;
±±? @
_imageThree
≤≤ 
=
≤≤  !
values
≤≤" (
.
≤≤( )"
IdentificationImages
≤≤) =
!
≤≤= >
[
≤≤> ?
$num
≤≤? @
]
≤≤@ A
;
≤≤A B

_imageFour
≥≥ 
=
≥≥  
values
≥≥! '
.
≥≥' ("
IdentificationImages
≥≥( <
!
≥≥< =
[
≥≥= >
$num
≥≥> ?
]
≥≥? @
;
≥≥@ A

_imageFive
¥¥ 
=
¥¥  
values
¥¥! '
.
¥¥' ("
IdentificationImages
¥¥( <
!
¥¥< =
[
¥¥= >
$num
¥¥> ?
]
¥¥? @
;
¥¥@ A
break
µµ 
;
µµ 
}
∂∂ 

imageCount
ππ 
=
ππ 
values
ππ 
.
ππ  
NonResident
ππ  +
!
ππ+ ,
.
ππ, -0
"ContactPerson_IdentificationImages
ππ- O
!
ππO P
.
ππP Q
Count
ππQ V
(
ππV W
)
ππW X
;
ππX Y
switch
∫∫ 
(
∫∫ 

imageCount
∫∫ 
)
∫∫ 
{
ªª 
case
ºº 
$num
ºº 
:
ºº 

c_imageOne
ΩΩ 
=
ΩΩ  
values
ΩΩ! '
.
ΩΩ' ("
IdentificationImages
ΩΩ( <
!
ΩΩ< =
[
ΩΩ= >
$num
ΩΩ> ?
]
ΩΩ? @
;
ΩΩ@ A
break
ææ 
;
ææ 
case
¿¿ 
$num
¿¿ 
:
¿¿ 

c_imageOne
¡¡ 
=
¡¡  
values
¡¡! '
.
¡¡' ("
IdentificationImages
¡¡( <
!
¡¡< =
[
¡¡= >
$num
¡¡> ?
]
¡¡? @
;
¡¡@ A

c_imageTwo
¬¬ 
=
¬¬  
values
¬¬! '
.
¬¬' ("
IdentificationImages
¬¬( <
!
¬¬< =
[
¬¬= >
$num
¬¬> ?
]
¬¬? @
;
¬¬@ A
break
√√ 
;
√√ 
}
ƒƒ 
CustomerMaster
∆∆ 
customer
∆∆ #
=
∆∆$ %
await
∆∆& +
CustomerMaster
∆∆, :
.
∆∆: ;
CreateJointAsync
∆∆; K
(
«« 
customerMasterId
»» $
:
»»$ %
values
»»& ,
.
»», -
CustomerMasterId
»»- =
,
»»= >
customerTypeId
…… "
:
……" #
values
……$ *
.
……* +
CustomerTypeId
……+ 9
,
……9 :
residentTypeId
   "
:
  " #
values
  $ *
.
  * +
ResidentTypeId
  + 9
,
  9 :

localityId
ÀÀ 
:
ÀÀ 
values
ÀÀ  &
.
ÀÀ& '

LocalityId
ÀÀ' 1
,
ÀÀ1 2
customerCode
ÃÃ  
:
ÃÃ  !
values
ÃÃ" (
.
ÃÃ( )
CustomerCode
ÃÃ) 5
!
ÃÃ5 6
,
ÃÃ6 7
titleId
ÕÕ 
:
ÕÕ 
values
ÕÕ #
.
ÕÕ# $
TitleId
ÕÕ$ +
,
ÕÕ+ ,
surName
ŒŒ 
:
ŒŒ 
values
ŒŒ #
.
ŒŒ# $
SurName
ŒŒ$ +
,
ŒŒ+ ,

otherNames
œœ 
:
œœ 
values
œœ  &
.
œœ& '

OtherNames
œœ' 1
,
œœ1 2
dateOfBirth
–– 
:
––  
values
––! '
.
––' (
DateOfBirth
––( 3
,
––3 4
	tinNumber
—— 
:
—— 
values
—— %
.
——% &
	TinNumber
——& /
!
——/ 0
,
——0 1
picture
““ 
:
““ 
values
““ #
.
““# $
Picture
““$ +
!
““+ ,
,
““, -
genderId
”” 
:
”” 
values
”” $
.
””$ %
GenderId
””% -
,
””- .
nationalityId
‘‘ !
:
‘‘! "
values
‘‘# )
.
‘‘) *
NationalityId
‘‘* 7
,
‘‘7 8
postalAddress
’’ !
:
’’! "
values
’’# )
.
’’) *
PostalAddress
’’* 7
!
’’7 8
,
’’8 9 
residentialAddress
÷÷ &
:
÷÷& '
values
÷÷( .
.
÷÷. / 
ResidentialAddress
÷÷/ A
!
÷÷A B
,
÷÷B C
digitalAddress
◊◊ "
:
◊◊" #
values
◊◊$ *
.
◊◊* +
DigitalAddress
◊◊+ 9
!
◊◊9 :
,
◊◊: ;!
primaryMobileNumber
ÿÿ '
:
ÿÿ' (
values
ÿÿ) /
.
ÿÿ/ 0!
PrimaryMobileNumber
ÿÿ0 C
!
ÿÿC D
,
ÿÿD E#
secondaryMobileNumber
ŸŸ )
:
ŸŸ) *
values
ŸŸ+ 1
.
ŸŸ1 2#
SecondaryMobileNumber
ŸŸ2 G
!
ŸŸG H
,
ŸŸH I
officeNumber
⁄⁄  
:
⁄⁄  !
values
⁄⁄" (
.
⁄⁄( )
OfficeNumber
⁄⁄) 5
!
⁄⁄5 6
,
⁄⁄6 7
whatsAppNumber
€€ "
:
€€" #
values
€€$ *
.
€€* +
WhatsAppNumber
€€+ 9
!
€€9 :
,
€€: ;
emailAddress
‹‹  
:
‹‹  !
values
‹‹" (
.
‹‹( )
EmailAddress
‹‹) 5
,
‹‹5 6"
residentPermitNumber
›› (
:
››( )
values
››* 0
.
››0 1

Expatriate
››1 ;
!
››; <
.
››< ="
ResidentPermitNumber
››= Q
!
››Q R
,
››R S&
residentPermitDateIssued
ﬁﬁ ,
:
ﬁﬁ, -
values
ﬁﬁ. 4
.
ﬁﬁ4 5

Expatriate
ﬁﬁ5 ?
!
ﬁﬁ? @
.
ﬁﬁ@ A&
ResidentPermitDateIssued
ﬁﬁA Y
!
ﬁﬁY Z
,
ﬁﬁZ [&
residentPermitExpiryDate
ﬂﬂ ,
:
ﬂﬂ, -
values
ﬂﬂ. 4
.
ﬂﬂ4 5

Expatriate
ﬂﬂ5 ?
!
ﬂﬂ? @
.
ﬂﬂ@ A&
ResidentPermitExpiryDate
ﬂﬂA Y
!
ﬂﬂY Z
,
ﬂﬂZ [
socialMediaTypeId
‡‡ %
:
‡‡% &
values
‡‡' -
.
‡‡- .
SocialMediaTypeId
‡‡. ?
,
‡‡? @ 
socialMediaAccount
·· &
:
··& '
values
··( .
.
··. / 
SocialMediaAccount
··/ A
!
··A B
,
··B C"
identificationTypeId
‚‚ (
:
‚‚( )
values
‚‚* 0
.
‚‚0 1"
IdentificationTypeId
‚‚1 E
,
‚‚E F&
identificationTypeNumber
„„ ,
:
„„, -
values
„„. 4
.
„„4 5&
IdentificationTypeNumber
„„5 M
!
„„M N
,
„„N O(
identificationTypeImageOne
‰‰ .
:
‰‰. /
	_imageOne
‰‰0 9
,
‰‰9 :(
identificationTypeImageTwo
ÂÂ .
:
ÂÂ. /
	_imageTwo
ÂÂ0 9
,
ÂÂ9 :*
identificationTypeImageThree
ÊÊ 0
:
ÊÊ0 1
_imageThree
ÊÊ2 =
,
ÊÊ= >)
identificationTypeImageFour
ÁÁ /
:
ÁÁ/ 0

_imageFour
ÁÁ1 ;
,
ÁÁ; <)
identificationTypeImageFive
ËË /
:
ËË/ 0

_imageFive
ËË1 ;
,
ËË; <
comments
ÈÈ 
:
ÈÈ 
values
ÈÈ $
.
ÈÈ$ %
Comments
ÈÈ% -
!
ÈÈ- .
,
ÈÈ. /
interestExpressed
ÍÍ %
:
ÍÍ% &
string
ÍÍ' -
.
ÍÍ- .
Empty
ÍÍ. 3
,
ÍÍ3 4
debtorStatus
ÎÎ  
:
ÎÎ  !
$num
ÎÎ" #
,
ÎÎ# $

parentCode
ÏÏ 
:
ÏÏ 
string
ÏÏ  &
.
ÏÏ& '
Empty
ÏÏ' ,
,
ÏÏ, -$
contactPerson_FullName
ÌÌ *
:
ÌÌ* +
values
ÌÌ, 2
.
ÌÌ2 3
NonResident
ÌÌ3 >
.
ÌÌ> ?$
ContactPerson_FullName
ÌÌ? U
!
ÌÌU V
,
ÌÌV W'
contactPerson_PhoneNumber
ÓÓ -
:
ÓÓ- .
values
ÓÓ/ 5
.
ÓÓ5 6
NonResident
ÓÓ6 A
.
ÓÓA B'
ContactPerson_PhoneNumber
ÓÓB [
!
ÓÓ[ \
,
ÓÓ\ ](
contactPerson_EmailAddress
ÔÔ .
:
ÔÔ. /
values
ÔÔ0 6
.
ÔÔ6 7
NonResident
ÔÔ7 B
.
ÔÔB C(
ContactPerson_EmailAddress
ÔÔC ]
!
ÔÔ] ^
,
ÔÔ^ _#
contactPerson_Address
 )
:
) *
values
+ 1
.
1 2
NonResident
2 =
.
= >#
ContactPerson_Address
> S
!
S T
,
T U0
"contactPerson_IdentificationTypeId
ÒÒ 6
:
ÒÒ6 7
values
ÒÒ8 >
.
ÒÒ> ?
NonResident
ÒÒ? J
.
ÒÒJ K0
"ContactPerson_IdentificationTypeId
ÒÒK m
,
ÒÒm n4
&contactPerson_IdentificationTypeNumber
ÚÚ :
:
ÚÚ: ;
values
ÚÚ< B
.
ÚÚB C
NonResident
ÚÚC N
.
ÚÚN O4
&ContactPerson_IdentificationTypeNumber
ÚÚO u
!
ÚÚu v
,
ÚÚv w6
(contactPerson_IdentificationTypeImageOne
ÛÛ <
:
ÛÛ< =

c_imageOne
ÛÛ> H
,
ÛÛH I6
(contactPerson_IdentificationTypeImageTwo
ÙÙ <
:
ÙÙ< =

c_imageTwo
ÙÙ> H
,
ÙÙH I
	isDeleted
ıı 
:
ıı 
false
ıı $
,
ıı$ %
	isPrimary
ˆˆ 
:
ˆˆ 
true
ˆˆ #
,
ˆˆ# $
maritalStatus
˜˜ !
:
˜˜! "
values
˜˜# )
.
˜˜) *
MaritalStatus
˜˜* 7
!
˜˜7 8
,
˜˜8 9
dateOfMarriage
¯¯ "
:
¯¯" #
values
¯¯$ *
.
¯¯* +
DateOfMarriage
¯¯+ 9
!
¯¯9 :
,
¯¯: ;
_domainService
˘˘ "
)
˙˙ 
;
˙˙ 
customer
¸¸ 
.
¸¸ 

ModifiedBy
¸¸ 
=
¸¸  !
values
¸¸" (
.
¸¸( )

ModifiedBy
¸¸) 3
;
¸¸3 4
customer
˝˝ 
.
˝˝ 

ModifiedOn
˝˝ 
=
˝˝  !
DateTime
˝˝" *
.
˝˝* +
UtcNow
˝˝+ 1
;
˝˝1 2
_unitOfWork
ˇˇ 
.
ˇˇ 
CustomerMaster
ˇˇ &
.
ˇˇ& '
Update
ˇˇ' -
(
ˇˇ- .
customer
ˇˇ. 6
)
ˇˇ6 7
;
ˇˇ7 8
await
ÄÄ 
_unitOfWork
ÄÄ 
.
ÄÄ 
Complete
ÄÄ &
(
ÄÄ& '
)
ÄÄ' (
;
ÄÄ( )
var
ÉÉ 
_title
ÉÉ 
=
ÉÉ 
(
ÉÉ 
await
ÉÉ 
_unitOfWork
ÉÉ  +
.
ÉÉ+ ,
Title
ÉÉ, 1
.
ÉÉ1 2
Get
ÉÉ2 5
(
ÉÉ5 6
t
ÉÉ6 7
=>
ÉÉ8 :
t
ÉÉ; <
.
ÉÉ< =
TitleId
ÉÉ= D
==
ÉÉE G
customer
ÉÉH P
.
ÉÉP Q
TitleId
ÉÉQ X
)
ÉÉX Y
)
ÉÉY Z
!
ÉÉZ [
.
ÉÉ[ \
Titles
ÉÉ\ b
;
ÉÉb c
var
ÑÑ 
customername
ÑÑ 
=
ÑÑ 
string
ÑÑ %
.
ÑÑ% &
Concat
ÑÑ& ,
(
ÑÑ, -
_title
ÑÑ- 3
,
ÑÑ3 4
$str
ÑÑ5 8
,
ÑÑ8 9
customer
ÑÑ: B
.
ÑÑB C

OtherNames
ÑÑC M
,
ÑÑM N
$str
ÑÑO R
,
ÑÑR S
customer
ÑÑT \
.
ÑÑ\ ]
SurName
ÑÑ] d
)
ÑÑd e
.
ÑÑe f
Trim
ÑÑf j
(
ÑÑj k
)
ÑÑk l
;
ÑÑl m
var
ÜÜ  
registeredCustomer
ÜÜ "
=
ÜÜ# $
new
ÜÜ% (4
&CustomerRegistrationSuccessResponseDto
ÜÜ) O
{
áá 
CustomerCode
àà 
=
àà 
customer
àà '
.
àà' (
CustomerCode
àà( 4
,
àà4 5
FullName
ââ 
=
ââ 
customername
ââ '
,
ââ' (
PhoneNumber
ää 
=
ää 
customer
ää &
.
ää& '!
PrimaryMobileNumber
ää' :
,
ää: ;
}
ãã 
;
ãã 
return
çç 
new
çç -
CustomerRegistrationResponseDto
çç 6
{
çç7 8
	IsSuccess
çç9 B
=
ççC D
true
ççE I
,
ççI J
SuccessResponse
ççK Z
=
çç[ \ 
registeredCustomer
çç] o
}
ççp q
;
ççq r
}
éé 	
public
êê 
async
êê 
Task
êê 
<
êê 
int
êê 
>
êê $
StopCustomerDebitAsync
êê 5
(
êê5 6!
StopDebitRequestDto
êê6 I
values
êêJ P
)
êêP Q
{
ëë 	
if
ìì 
(
ìì 
values
ìì 
is
ìì 
null
ìì 
)
ìì 
{
îî 
return
ïï 
$num
ïï 
;
ïï 
}
ññ 
var
ôô 
customer
ôô 
=
ôô 
await
ôô  
_unitOfWork
ôô! ,
.
ôô, -
CustomerMaster
ôô- ;
.
ôô; <
Get
ôô< ?
(
ôô? @
c
ôô@ A
=>
ôôB D
c
ôôE F
.
ôôF G
CustomerCode
ôôG S
==
ôôT V
values
ôôW ]
!
ôô] ^
.
ôô^ _
CustomerCode
ôô_ k
)
ôôk l
;
ôôl m
if
öö 
(
öö 
customer
öö 
is
öö 
null
öö 
)
öö  
{
õõ 
return
úú 
$num
úú 
;
úú 
}
ùù 
var
üü 
debitDetails
üü 
=
üü 
new
üü "
	StopDebit
üü# ,
{
†† 
StopDebitId
°° 
=
°° 
$num
°° 
,
°°  
CustomerCode
¢¢ 
=
¢¢ 
values
¢¢ %
!
¢¢% &
.
¢¢& '
CustomerCode
¢¢' 3
,
¢¢3 4
PropertyNumber
££ 
=
££  
values
££! '
.
££' (
PropertyNumber
££( 6
,
££6 7
DebtorStatus
§§ 
=
§§ 
values
§§ %
.
§§% &
DebtorStatus
§§& 2
,
§§2 3
ActionBy
•• 
=
•• 
values
•• !
.
••! "
ActionBy
••" *
,
••* +
ActionOn
¶¶ 
=
¶¶ 
DateTime
¶¶ #
.
¶¶# $
UtcNow
¶¶$ *
}
ßß 
;
ßß 
customer
™™ 
!
™™ 
.
™™ 
DebtorStatus
™™ "
=
™™# $
values
™™% +
.
™™+ ,
DebtorStatus
™™, 8
;
™™8 9
customer
´´ 
.
´´ 

ModifiedBy
´´ 
=
´´  !
values
´´" (
.
´´( )
ActionBy
´´) 1
;
´´1 2
customer
¨¨ 
.
¨¨ 

ModifiedOn
¨¨ 
=
¨¨  !
DateTime
¨¨" *
.
¨¨* +
UtcNow
¨¨+ 1
;
¨¨1 2
_unitOfWork
ÆÆ 
.
ÆÆ 
CustomerMaster
ÆÆ &
.
ÆÆ& '
Update
ÆÆ' -
(
ÆÆ- .
customer
ÆÆ. 6
)
ÆÆ6 7
;
ÆÆ7 8
_unitOfWork
ØØ 
.
ØØ 
	StopDebit
ØØ !
.
ØØ! "
Insert
ØØ" (
(
ØØ( )
debitDetails
ØØ) 5
)
ØØ5 6
;
ØØ6 7
await
±± 
_unitOfWork
±± 
.
±± 
Complete
±± &
(
±±& '
)
±±' (
;
±±( )
return
≥≥ 
$num
≥≥ 
;
≥≥ 
}
µµ 	
}
ºº 
}ΩΩ ¥√
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Customer/CustomerMasterService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /

Management/ 9
.9 :
Customer: B
{ 
public 

partial 
class !
CustomerMasterService .
:/ 0"
ICustomerMasterService1 G
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
;( )
private 
readonly "
ICustomerDomainService /
_domainService0 >
;> ?
private 
readonly (
IModuleCommunicationServices 5
_moduleComms6 B
;B C
private 
readonly 
ILogger  
<  !!
CustomerMasterService! 6
>6 7
_logger8 ?
;? @
private 
readonly "
IDomainEventDispatcher /"
_domainEventDispatcher0 F
;F G
public !
CustomerMasterService $
($ %
IUnitOfWork% 0

unitOfWork1 ;
,; <
IMapper= D
mapperE K
,K L"
ICustomerDomainServiceM c
domainServiced q
,q r)
IModuleCommunicationServices	s è
moduleComms
ê õ
,
õ ú
ILogger
ù §
<
§ •#
CustomerMasterService
• ∫
>
∫ ª
logger
º ¬
,
¬ √$
IDomainEventDispatcher
ƒ ⁄#
domainEventDispatcher
€ 
)
 Ò
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
_domainService 
= 
domainService *
;* +
_moduleComms 
= 
moduleComms &
;& '
_logger 
= 
logger 
; "
_domainEventDispatcher "
=# $!
domainEventDispatcher% :
;: ;
} 	
public 
async 
Task 
< +
CustomerRegistrationResponseDto 9
>9 :
CreateCustomer; I
(I J"
ProspectiveCustomerDtoJ `
valuesa g
)g h
{ 	
string 
_residentType  
=! "
string# )
.) *
Empty* /
;/ 0
string 
_title 
= 
string "
." #
Empty# (
;( )
string  
_socialMediaPlatform '
=( )
string* 0
.0 1
Empty1 6
;6 7
string   
_identificationType   &
=  ' (
string  ) /
.  / 0
Empty  0 5
;  5 6
try"" 
{## 
CustomerMaster$$ 
customer$$ '
=$$( )
await$$* /
CustomerMaster$$0 >
.$$> ?"
CreateProspectiveAsync$$? U
(%% 
customerMasterId&& (
:&&( )
values&&* 0
.&&0 1
CustomerMasterId&&1 A
,&&A B
customerTypeId'' &
:''& '
values''( .
.''. /
CustomerTypeId''/ =
,''= >
residentTypeId(( &
:((& '
values((( .
.((. /
ResidentTypeId((/ =
,((= >

localityId)) "
:))" #
values))$ *
.))* +

LocalityId))+ 5
,))5 6
customerCode** $
:**$ %
values**& ,
.**, -
CustomerCode**- 9
!**9 :
,**: ;
titleId++ 
:++  
values++! '
.++' (
TitleId++( /
,++/ 0
surName,, 
:,,  
values,,! '
.,,' (
SurName,,( /
!,,/ 0
,,,0 1

otherNames-- "
:--" #
values--$ *
.--* +

OtherNames--+ 5
!--5 6
,--6 7
companyName.. #
:..# $
values..% +
...+ ,
CompanyName.., 7
!..7 8
,..8 9
picture// 
://  
string//! '
.//' (
Empty//( -
,//- .
genderId00  
:00  !
values00" (
.00( )
GenderId00) 1
,001 2
nationalityId11 %
:11% &
values11' -
.11- .
NationalityId11. ;
,11; <
postalAddress22 %
:22% &
values22' -
.22- .
PostalAddress22. ;
!22; <
,22< =
residentialAddress33 *
:33* +
values33, 2
.332 3
ResidentialAddress333 E
!33E F
,33F G
digitalAddress44 &
:44& '
values44( .
.44. /
DigitalAddress44/ =
!44= >
,44> ?
primaryMobileNumber55 +
:55+ ,
values55- 3
.553 4
PrimaryMobileNumber554 G
!55G H
,55H I!
secondaryMobileNumber66 -
:66- .
values66/ 5
.665 6!
SecondaryMobileNumber666 K
!66K L
,66L M
officeNumber77 $
:77$ %
values77& ,
.77, -
OfficeNumber77- 9
!779 :
,77: ;
whatsAppNumber88 &
:88& '
values88( .
.88. /
WhatsAppNumber88/ =
!88= >
,88> ?
emailAddress99 $
:99$ %
values99& ,
.99, -
EmailAddress99- 9
,999 :
socialMediaTypeId:: )
:::) *
values::+ 1
.::1 2
SocialMediaTypeId::2 C
,::C D
socialMediaAccount;; *
:;;* +
values;;, 2
.;;2 3
SocialMediaAccount;;3 E
!;;E F
,;;F G
comments<<  
:<<  !
values<<" (
.<<( )
Comments<<) 1
!<<1 2
,<<2 3
interestExpressed== )
:==) *
values==+ 1
.==1 2
InterestExpressed==2 C
,==C D
	createdBy>> !
:>>! "
values>># )
.>>) *
	CreatedBy>>* 3
!>>3 4
,>>4 5
_domainService?? &
)@@ 
;@@ 
customerBB 
.BB 
	CreatedOnBB "
=BB# $
DateTimeBB% -
.BB- .
UtcNowBB. 4
;BB4 5
customerCC 
.CC 
DebtorStatusCC %
=CC& '
$numCC( )
;CC) *
_unitOfWorkEE 
.EE 
CustomerMasterEE *
.EE* +
InsertEE+ 1
(EE1 2
customerEE2 :
)EE: ;
;EE; <
awaitFF 
_unitOfWorkFF !
.FF! "
CompleteFF" *
(FF* +
)FF+ ,
;FF, -
foreachHH 
(HH 
varHH 
domainEventHH (
inHH) +
customerHH, 4
.HH4 5
DomainEventsHH5 A
)HHA B
{II 
awaitJJ "
_domainEventDispatcherJJ 0
.JJ0 1
DispatchAsyncJJ1 >
(JJ> ?
domainEventJJ? J
)JJJ K
;JJK L
}KK 
ifMM 
(MM 
valuesMM 
.MM 
TitleIdMM "
!=MM# %
$numMM& '
)MM' (
{NN 
_titleOO 
=OO 
(OO 
awaitOO #
_unitOfWorkOO$ /
.OO/ 0
TitleOO0 5
.OO5 6
GetOO6 9
(OO9 :
tOO: ;
=>OO< >
tOO? @
.OO@ A
TitleIdOOA H
==OOI K
customerOOL T
.OOT U
TitleIdOOU \
)OO\ ]
)OO] ^
!OO^ _
.OO_ `
TitlesOO` f
;OOf g
}PP 
ifRR 
(RR 
valuesRR 
.RR 
SocialMediaTypeIdRR ,
!=RR- /
$numRR0 1
)RR1 2
{SS  
_socialMediaPlatformTT (
=TT) *
(TT+ ,
awaitTT, 1
_unitOfWorkTT2 =
.TT= >
SocialMediaTT> I
.TTI J
GetTTJ M
(TTM N
sTTN O
=>TTP R
sTTS T
.TTT U
SocialMediaIdTTU b
==TTc e
customerTTf n
.TTn o
SocialMediaTypeId	TTo Ä
)
TTÄ Å
)
TTÅ Ç
!
TTÇ É
.
TTÉ Ñ!
SocialMediaPlatform
TTÑ ó
;
TTó ò
}UU 
varWW 
registeredCustomerWW &
=WW' (
newWW) ,2
&CustomerRegistrationSuccessResponseDtoWW- S
{XX 
CustomerCodeYY  
=YY! "
customerYY# +
.YY+ ,
CustomerCodeYY, 8
,YY8 9
FullNameZZ 
=ZZ 
stringZZ %
.ZZ% &
ConcatZZ& ,
(ZZ, -
_titleZZ- 3
,ZZ3 4
$strZZ5 8
,ZZ8 9
customerZZ: B
.ZZB C

OtherNamesZZC M
!ZZM N
,ZZN O
$strZZP S
,ZZS T
customerZZU ]
.ZZ] ^
SurNameZZ^ e
!ZZe f
,ZZf g
$strZZh k
,ZZk l
customerZZm u
.ZZu v
CompanyName	ZZv Å
!
ZZÅ Ç
)
ZZÇ É
.
ZZÉ Ñ
Trim
ZZÑ à
(
ZZà â
)
ZZâ ä
,
ZZä ã
PhoneNumber[[ 
=[[  !
customer[[" *
.[[* +
PrimaryMobileNumber[[+ >
,[[> ?
}\\ 
;\\ 
return^^ 
new^^ +
CustomerRegistrationResponseDto^^ :
{^^; <
	IsSuccess^^= F
=^^G H
true^^I M
,^^M N
SuccessResponse^^O ^
=^^_ `
registeredCustomer^^a s
}^^t u
;^^u v
}`` 
catchaa 
(aa 
	Exceptionaa 
exaa 
)aa  
{bb 
varcc 
errcc 
=cc 
newcc 
BaseResponseDtocc -
{cc. /

StatusCodecc0 :
=cc; <
$numcc= @
,cc@ A
StatusMessageccB O
=ccP Q
exccR T
.ccT U
InnerExceptionccU c
!ccc d
.ccd e
Messagecce l
}ccm n
;ccn o
returndd 
newdd +
CustomerRegistrationResponseDtodd :
{dd; <
	IsSuccessdd= F
=ddG H
falseddI N
,ddN O
ErrorResponseddP ]
=dd^ _
errdd` c
}ddd e
;dde f
}ff 
}gg 	
publicii 
asyncii 
Taskii 
<ii +
CustomerRegistrationResponseDtoii 9
>ii9 :
CreateCustomerii; I
(iiI J$
CreateCompanyCustomerDtoiiJ b
valuesiic i
)iii j
{jj 	
stringkk  
_socialMediaPlatformkk '
=kk( )
stringkk* 0
.kk0 1
Emptykk1 6
;kk6 7
stringkk8 >
_residentTypekk? L
=kkM N
stringkkO U
.kkU V
EmptykkV [
;kk[ \
stringll 
	_imageOnell 
=ll 
stringll %
.ll% &
Emptyll& +
;ll+ ,
stringll- 3
	_imageTwoll4 =
=ll> ?
stringll@ F
.llF G
EmptyllG L
;llL M
stringllN T
_imageThreellU `
=lla b
stringllc i
.lli j
Emptyllj o
;llo p
stringllq w

_imageFour	llx Ç
=
llÉ Ñ
string
llÖ ã
.
llã å
Empty
llå ë
;
llë í
string
llì ô

_imageFive
llö §
=
ll• ¶
string
llß ≠
.
ll≠ Æ
Empty
llÆ ≥
;
ll≥ ¥
stringmm 

c_imageOnemm 
=mm 
stringmm  &
.mm& '
Emptymm' ,
;mm, -
stringmm. 4

c_imageTwomm5 ?
=mm@ A
stringmmB H
.mmH I
EmptymmI N
;mmN O
intnn 

imageCountnn 
;nn 

imageCountpp 
=pp 
valuespp 
.pp   
IdentificationImagespp  4
!pp4 5
.pp5 6
Countpp6 ;
(pp; <
)pp< =
;pp= >
switchqq 
(qq 

imageCountqq 
)qq 
{rr 
casess 
$numss 
:ss 
	_imageOnett 
=tt 
valuestt  &
.tt& ' 
IdentificationImagestt' ;
!tt; <
[tt< =
$numtt= >
]tt> ?
;tt? @
breakuu 
;uu 
caseww 
$numww 
:ww 
	_imageOnexx 
=xx 
valuesxx  &
.xx& ' 
IdentificationImagesxx' ;
!xx; <
[xx< =
$numxx= >
]xx> ?
;xx? @
	_imageTwoyy 
=yy 
valuesyy  &
.yy& ' 
IdentificationImagesyy' ;
!yy; <
[yy< =
$numyy= >
]yy> ?
;yy? @
breakzz 
;zz 
case|| 
$num|| 
:|| 
	_imageOne}} 
=}} 
values}}  &
.}}& ' 
IdentificationImages}}' ;
!}}; <
[}}< =
$num}}= >
]}}> ?
;}}? @
	_imageTwo~~ 
=~~ 
values~~  &
.~~& ' 
IdentificationImages~~' ;
!~~; <
[~~< =
$num~~= >
]~~> ?
;~~? @
_imageThree 
=  !
values" (
.( ) 
IdentificationImages) =
!= >
[> ?
$num? @
]@ A
;A B
break
ÄÄ 
;
ÄÄ 
case
ÇÇ 
$num
ÇÇ 
:
ÇÇ 
	_imageOne
ÉÉ 
=
ÉÉ 
values
ÉÉ  &
.
ÉÉ& '"
IdentificationImages
ÉÉ' ;
!
ÉÉ; <
[
ÉÉ< =
$num
ÉÉ= >
]
ÉÉ> ?
;
ÉÉ? @
	_imageTwo
ÑÑ 
=
ÑÑ 
values
ÑÑ  &
.
ÑÑ& '"
IdentificationImages
ÑÑ' ;
!
ÑÑ; <
[
ÑÑ< =
$num
ÑÑ= >
]
ÑÑ> ?
;
ÑÑ? @
_imageThree
ÖÖ 
=
ÖÖ  !
values
ÖÖ" (
.
ÖÖ( )"
IdentificationImages
ÖÖ) =
!
ÖÖ= >
[
ÖÖ> ?
$num
ÖÖ? @
]
ÖÖ@ A
;
ÖÖA B

_imageFour
ÜÜ 
=
ÜÜ  
values
ÜÜ! '
.
ÜÜ' ("
IdentificationImages
ÜÜ( <
!
ÜÜ< =
[
ÜÜ= >
$num
ÜÜ> ?
]
ÜÜ? @
;
ÜÜ@ A
break
áá 
;
áá 
case
ââ 
$num
ââ 
:
ââ 
	_imageOne
ää 
=
ää 
values
ää  &
.
ää& '"
IdentificationImages
ää' ;
!
ää; <
[
ää< =
$num
ää= >
]
ää> ?
;
ää? @
	_imageTwo
ãã 
=
ãã 
values
ãã  &
.
ãã& '"
IdentificationImages
ãã' ;
!
ãã; <
[
ãã< =
$num
ãã= >
]
ãã> ?
;
ãã? @
_imageThree
åå 
=
åå  !
values
åå" (
.
åå( )"
IdentificationImages
åå) =
!
åå= >
[
åå> ?
$num
åå? @
]
åå@ A
;
ååA B

_imageFour
çç 
=
çç  
values
çç! '
.
çç' ("
IdentificationImages
çç( <
!
çç< =
[
çç= >
$num
çç> ?
]
çç? @
;
çç@ A

_imageFive
éé 
=
éé  
values
éé! '
.
éé' ("
IdentificationImages
éé( <
!
éé< =
[
éé= >
$num
éé> ?
]
éé? @
;
éé@ A
break
èè 
;
èè 
}
êê 

imageCount
ìì 
=
ìì 
values
ìì 
.
ìì  
ContactPerson
ìì  -
!
ìì- .
.
ìì. /0
"ContactPerson_IdentificationImages
ìì/ Q
!
ììQ R
.
ììR S
Count
ììS X
(
ììX Y
)
ììY Z
;
ììZ [
switch
îî 
(
îî 

imageCount
îî 
)
îî 
{
ïï 
case
ññ 
$num
ññ 
:
ññ 

c_imageOne
óó 
=
óó  
values
óó! '
.
óó' ("
IdentificationImages
óó( <
!
óó< =
[
óó= >
$num
óó> ?
]
óó? @
;
óó@ A
break
òò 
;
òò 
case
öö 
$num
öö 
:
öö 

c_imageOne
õõ 
=
õõ  
values
õõ! '
.
õõ' ("
IdentificationImages
õõ( <
!
õõ< =
[
õõ= >
$num
õõ> ?
]
õõ? @
;
õõ@ A

c_imageTwo
úú 
=
úú  
values
úú! '
.
úú' ("
IdentificationImages
úú( <
!
úú< =
[
úú= >
$num
úú> ?
]
úú? @
;
úú@ A
break
ùù 
;
ùù 
}
ûû 
try
°° 
{
¢¢ 
CustomerMaster
££ 
customer
££ '
=
££( )
await
££* /
CustomerMaster
££0 >
.
££> ? 
CreateCompanyAsync
££? Q
(
§§ 
customerMasterId
•• (
:
••( )
values
••* 0
.
••0 1
CustomerMasterId
••1 A
,
••A B
customerTypeId
¶¶ &
:
¶¶& '
values
¶¶( .
.
¶¶. /
CustomerTypeId
¶¶/ =
,
¶¶= >
residentTypeId
ßß &
:
ßß& '
values
ßß( .
.
ßß. /
ResidentTypeId
ßß/ =
,
ßß= >

localityId
®® "
:
®®" #
values
®®$ *
.
®®* +

LocalityId
®®+ 5
,
®®5 6
customerCode
©© $
:
©©$ %
values
©©& ,
.
©©, -
CustomerCode
©©- 9
!
©©9 :
,
©©: ;
companyName
™™ #
:
™™# $
values
™™% +
.
™™+ ,
CompanyName
™™, 7
!
™™7 8
,
™™8 9
nationalityId
´´ %
:
´´% &
values
´´' -
.
´´- .
NationalityId
´´. ;
,
´´; <
companyAddress
¨¨ &
:
¨¨& '
values
¨¨( .
.
¨¨. /
CompanyAddress
¨¨/ =
!
¨¨= >
,
¨¨> ?
digitalAddress
≠≠ &
:
≠≠& '
values
≠≠( .
.
≠≠. /
DigitalAddress
≠≠/ =
!
≠≠= >
,
≠≠> ?!
primaryMobileNumber
ÆÆ +
:
ÆÆ+ ,
values
ÆÆ- 3
.
ÆÆ3 4!
PrimaryMobileNumber
ÆÆ4 G
!
ÆÆG H
,
ÆÆH I#
secondaryMobileNumber
ØØ -
:
ØØ- .
values
ØØ/ 5
.
ØØ5 6#
SecondaryMobileNumber
ØØ6 K
!
ØØK L
,
ØØL M
officeNumber
∞∞ $
:
∞∞$ %
values
∞∞& ,
.
∞∞, -
OfficeNumber
∞∞- 9
!
∞∞9 :
,
∞∞: ;
whatsAppNumber
±± &
:
±±& '
values
±±( .
.
±±. /
WhatsAppNumber
±±/ =
!
±±= >
,
±±> ?
emailAddress
≤≤ $
:
≤≤$ %
values
≤≤& ,
.
≤≤, -
EmailAddress
≤≤- 9
!
≤≤9 :
,
≤≤: ;(
businessRegistrationNumber
≥≥ 2
:
≥≥2 3
values
≥≥4 :
.
≥≥: ;(
BusinessRegistrationNumber
≥≥; U
!
≥≥U V
,
≥≥V W
	tinNumber
¥¥ !
:
¥¥! "
values
¥¥# )
.
¥¥) *
	TinNumber
¥¥* 3
!
¥¥3 4
,
¥¥4 5
socialMediaTypeId
µµ )
:
µµ) *
values
µµ+ 1
.
µµ1 2
SocialMediaTypeId
µµ2 C
,
µµC D 
socialMediaAccount
∂∂ *
:
∂∂* +
values
∂∂, 2
.
∂∂2 3 
SocialMediaAccount
∂∂3 E
!
∂∂E F
,
∂∂F G(
identificationTypeImageOne
∑∑ 2
:
∑∑2 3
	_imageOne
∑∑4 =
,
∑∑= >(
identificationTypeImageTwo
∏∏ 2
:
∏∏2 3
	_imageTwo
∏∏4 =
,
∏∏= >*
identificationTypeImageThree
ππ 4
:
ππ4 5
_imageThree
ππ6 A
,
ππA B)
identificationTypeImageFour
∫∫ 3
:
∫∫3 4

_imageFour
∫∫5 ?
,
∫∫? @)
identificationTypeImageFive
ªª 3
:
ªª3 4

_imageFive
ªª5 ?
,
ªª? @$
contactPerson_FullName
ºº .
:
ºº. /
values
ºº0 6
.
ºº6 7
ContactPerson
ºº7 D
!
ººD E
.
ººE F$
ContactPerson_FullName
ººF \
!
ºº\ ]
,
ºº] ^'
contactPerson_PhoneNumber
ΩΩ 1
:
ΩΩ1 2
values
ΩΩ3 9
.
ΩΩ9 :
ContactPerson
ΩΩ: G
.
ΩΩG H'
ContactPerson_PhoneNumber
ΩΩH a
!
ΩΩa b
,
ΩΩb c(
contactPerson_EmailAddress
ææ 2
:
ææ2 3
values
ææ4 :
.
ææ: ;
ContactPerson
ææ; H
.
ææH I(
ContactPerson_EmailAddress
ææI c
!
ææc d
,
ææd e#
contactPerson_Address
øø -
:
øø- .
values
øø/ 5
.
øø5 6
ContactPerson
øø6 C
.
øøC D#
ContactPerson_Address
øøD Y
!
øøY Z
,
øøZ [0
"contactPerson_IdentificationTypeId
¿¿ :
:
¿¿: ;
values
¿¿< B
.
¿¿B C
ContactPerson
¿¿C P
.
¿¿P Q0
"ContactPerson_IdentificationTypeId
¿¿Q s
,
¿¿s t4
&contactPerson_IdentificationTypeNumber
¡¡ >
:
¡¡> ?
values
¡¡@ F
.
¡¡F G
ContactPerson
¡¡G T
.
¡¡T U4
&ContactPerson_IdentificationTypeNumber
¡¡U {
!
¡¡{ |
,
¡¡| }6
(contactPerson_IdentificationTypeImageOne
¬¬ @
:
¬¬@ A

c_imageOne
¬¬B L
,
¬¬L M6
(contactPerson_IdentificationTypeImageTwo
√√ @
:
√√@ A

c_imageTwo
√√B L
,
√√L M
comments
ƒƒ  
:
ƒƒ  !
values
ƒƒ" (
.
ƒƒ( )
Comments
ƒƒ) 1
!
ƒƒ1 2
,
ƒƒ2 3
	isDeleted
≈≈ !
:
≈≈! "
false
≈≈# (
,
≈≈( )
	isPrimary
∆∆ !
:
∆∆! "
true
∆∆# '
,
∆∆' (
_domainService
«« &
)
»» 
;
»» 
customer
…… 
.
…… 
PostalAddress
…… &
=
……' (
values
……) /
.
……/ 0
CompanyAddress
……0 >
;
……> ?
customer
   
.
    
ResidentialAddress
   +
=
  , -
values
  . 4
.
  4 5
CompanyAddress
  5 C
;
  C D
customer
ÀÀ 
.
ÀÀ 
	CreatedBy
ÀÀ "
=
ÀÀ# $
values
ÀÀ% +
.
ÀÀ+ ,
	CreatedBy
ÀÀ, 5
;
ÀÀ5 6
customer
ÃÃ 
.
ÃÃ 
	CreatedOn
ÃÃ "
=
ÃÃ# $
DateTime
ÃÃ% -
.
ÃÃ- .
UtcNow
ÃÃ. 4
;
ÃÃ4 5
customer
ÕÕ 
.
ÕÕ 
DebtorStatus
ÕÕ %
=
ÕÕ& '
$num
ÕÕ( )
;
ÕÕ) *
_unitOfWork
œœ 
.
œœ 
CustomerMaster
œœ *
.
œœ* +
Insert
œœ+ 1
(
œœ1 2
customer
œœ2 :
)
œœ: ;
;
œœ; <
var
““ 
	_locality
““ 
=
““ 
await
““  %
_unitOfWork
““& 1
.
““1 2
Locality
““2 :
.
““: ;
Get
““; >
(
““> ?
values
““? E
.
““E F

LocalityId
““F P
)
““P Q
;
““Q R
var
”” 
code
”” 
=
”” 
customer
”” #
.
””# $
CustomerCode
””$ 0
!
””0 1
.
””1 2
	Substring
””2 ;
(
””; <
Math
””< @
.
””@ A
Max
””A D
(
””D E
$num
””E F
,
””F G
customer
””H P
.
””P Q
CustomerCode
””Q ]
!
””] ^
.
””^ _
Length
””_ e
-
””f g
$num
””h i
)
””i j
)
””j k
;
””k l
	_locality
‘‘ 
!
‘‘ 
.
‘‘ !
CustomerCodeCounter
‘‘ .
=
‘‘/ 0
Convert
‘‘1 8
.
‘‘8 9
ToInt32
‘‘9 @
(
‘‘@ A
code
‘‘A E
)
‘‘E F
;
‘‘F G
_unitOfWork
’’ 
.
’’ 
Locality
’’ $
.
’’$ %
Update
’’% +
(
’’+ ,
	_locality
’’, 5
)
’’5 6
;
’’6 7
await
÷÷ 
_unitOfWork
÷÷ !
.
÷÷! "
Complete
÷÷" *
(
÷÷* +
)
÷÷+ ,
;
÷÷, -
var
ÿÿ  
registeredCustomer
ÿÿ &
=
ÿÿ' (
new
ÿÿ) ,4
&CustomerRegistrationSuccessResponseDto
ÿÿ- S
{
ŸŸ 
CustomerCode
⁄⁄  
=
⁄⁄! "
customer
⁄⁄# +
.
⁄⁄+ ,
CustomerCode
⁄⁄, 8
,
⁄⁄8 9
FullName
€€ 
=
€€ 
customer
€€ '
.
€€' (
CompanyName
€€( 3
!
€€3 4
.
€€4 5
Trim
€€5 9
(
€€9 :
)
€€: ;
,
€€; <
PhoneNumber
‹‹ 
=
‹‹  !
customer
‹‹" *
.
‹‹* +!
PrimaryMobileNumber
‹‹+ >
,
‹‹> ?
}
›› 
;
›› 
return
ﬂﬂ 
new
ﬂﬂ -
CustomerRegistrationResponseDto
ﬂﬂ :
{
ﬂﬂ; <
	IsSuccess
ﬂﬂ= F
=
ﬂﬂG H
true
ﬂﬂI M
,
ﬂﬂM N
SuccessResponse
ﬂﬂO ^
=
ﬂﬂ_ ` 
registeredCustomer
ﬂﬂa s
}
ﬂﬂt u
;
ﬂﬂu v
}
‡‡ 
catch
·· 
(
·· 
	Exception
·· 
ex
·· 
)
··  
{
‚‚ 
var
„„ 
err
„„ 
=
„„ 
new
„„ 
BaseResponseDto
„„ -
{
„„. /

StatusCode
„„0 :
=
„„; <
$num
„„= @
,
„„@ A
StatusMessage
„„B O
=
„„P Q
ex
„„R T
.
„„T U
InnerException
„„U c
!
„„c d
.
„„d e
Message
„„e l
}
„„m n
;
„„n o
return
‰‰ 
new
‰‰ -
CustomerRegistrationResponseDto
‰‰ :
{
‰‰; <
	IsSuccess
‰‰= F
=
‰‰G H
false
‰‰I N
,
‰‰N O
ErrorResponse
‰‰P ]
=
‰‰^ _
err
‰‰` c
}
‰‰d e
;
‰‰e f
}
ÂÂ 
}
ÊÊ 	
public
ËË 
async
ËË 
Task
ËË 
<
ËË -
CustomerRegistrationResponseDto
ËË 9
>
ËË9 :
CreateCustomer
ËË; I
(
ËËI J+
IndividualResidentCustomerDto
ËËJ g
values
ËËh n
)
ËËn o
{
ÈÈ 	
string
ÍÍ 
	_imageOne
ÍÍ 
=
ÍÍ 
string
ÍÍ %
.
ÍÍ% &
Empty
ÍÍ& +
;
ÍÍ+ ,
string
ÍÍ- 3
	_imageTwo
ÍÍ4 =
=
ÍÍ> ?
string
ÍÍ@ F
.
ÍÍF G
Empty
ÍÍG L
;
ÍÍL M
string
ÍÍN T
_imageThree
ÍÍU `
=
ÍÍa b
string
ÍÍc i
.
ÍÍi j
Empty
ÍÍj o
;
ÍÍo p
string
ÍÍq w

_imageFourÍÍx Ç
=ÍÍÉ Ñ
stringÍÍÖ ã
.ÍÍã å
EmptyÍÍå ë
;ÍÍë í
stringÍÍì ô

_imageFiveÍÍö §
=ÍÍ• ¶
stringÍÍß ≠
.ÍÍ≠ Æ
EmptyÍÍÆ ≥
;ÍÍ≥ ¥
string
ÎÎ 

c_imageOne
ÎÎ 
=
ÎÎ 
string
ÎÎ  &
.
ÎÎ& '
Empty
ÎÎ' ,
;
ÎÎ, -
string
ÎÎ. 4

c_imageTwo
ÎÎ5 ?
=
ÎÎ@ A
string
ÎÎB H
.
ÎÎH I
Empty
ÎÎI N
;
ÎÎN O
int
ÏÏ 

imageCount
ÏÏ 
;
ÏÏ 

imageCount
ÓÓ 
=
ÓÓ 
values
ÓÓ 
.
ÓÓ  "
IdentificationImages
ÓÓ  4
!
ÓÓ4 5
.
ÓÓ5 6
Count
ÓÓ6 ;
(
ÓÓ; <
)
ÓÓ< =
;
ÓÓ= >
switch
ÔÔ 
(
ÔÔ 

imageCount
ÔÔ 
)
ÔÔ 
{
 
case
ÒÒ 
$num
ÒÒ 
:
ÒÒ 
	_imageOne
ÚÚ 
=
ÚÚ 
values
ÚÚ  &
.
ÚÚ& '"
IdentificationImages
ÚÚ' ;
!
ÚÚ; <
[
ÚÚ< =
$num
ÚÚ= >
]
ÚÚ> ?
;
ÚÚ? @
break
ÛÛ 
;
ÛÛ 
case
ıı 
$num
ıı 
:
ıı 
	_imageOne
ˆˆ 
=
ˆˆ 
values
ˆˆ  &
.
ˆˆ& '"
IdentificationImages
ˆˆ' ;
!
ˆˆ; <
[
ˆˆ< =
$num
ˆˆ= >
]
ˆˆ> ?
;
ˆˆ? @
	_imageTwo
˜˜ 
=
˜˜ 
values
˜˜  &
.
˜˜& '"
IdentificationImages
˜˜' ;
!
˜˜; <
[
˜˜< =
$num
˜˜= >
]
˜˜> ?
;
˜˜? @
break
¯¯ 
;
¯¯ 
case
˙˙ 
$num
˙˙ 
:
˙˙ 
	_imageOne
˚˚ 
=
˚˚ 
values
˚˚  &
.
˚˚& '"
IdentificationImages
˚˚' ;
!
˚˚; <
[
˚˚< =
$num
˚˚= >
]
˚˚> ?
;
˚˚? @
	_imageTwo
¸¸ 
=
¸¸ 
values
¸¸  &
.
¸¸& '"
IdentificationImages
¸¸' ;
!
¸¸; <
[
¸¸< =
$num
¸¸= >
]
¸¸> ?
;
¸¸? @
_imageThree
˝˝ 
=
˝˝  !
values
˝˝" (
.
˝˝( )"
IdentificationImages
˝˝) =
!
˝˝= >
[
˝˝> ?
$num
˝˝? @
]
˝˝@ A
;
˝˝A B
break
˛˛ 
;
˛˛ 
case
ÄÄ 
$num
ÄÄ 
:
ÄÄ 
	_imageOne
ÅÅ 
=
ÅÅ 
values
ÅÅ  &
.
ÅÅ& '"
IdentificationImages
ÅÅ' ;
!
ÅÅ; <
[
ÅÅ< =
$num
ÅÅ= >
]
ÅÅ> ?
;
ÅÅ? @
	_imageTwo
ÇÇ 
=
ÇÇ 
values
ÇÇ  &
.
ÇÇ& '"
IdentificationImages
ÇÇ' ;
!
ÇÇ; <
[
ÇÇ< =
$num
ÇÇ= >
]
ÇÇ> ?
;
ÇÇ? @
_imageThree
ÉÉ 
=
ÉÉ  !
values
ÉÉ" (
.
ÉÉ( )"
IdentificationImages
ÉÉ) =
!
ÉÉ= >
[
ÉÉ> ?
$num
ÉÉ? @
]
ÉÉ@ A
;
ÉÉA B

_imageFour
ÑÑ 
=
ÑÑ  
values
ÑÑ! '
.
ÑÑ' ("
IdentificationImages
ÑÑ( <
!
ÑÑ< =
[
ÑÑ= >
$num
ÑÑ> ?
]
ÑÑ? @
;
ÑÑ@ A
break
ÖÖ 
;
ÖÖ 
case
áá 
$num
áá 
:
áá 
	_imageOne
àà 
=
àà 
values
àà  &
.
àà& '"
IdentificationImages
àà' ;
!
àà; <
[
àà< =
$num
àà= >
]
àà> ?
;
àà? @
	_imageTwo
ââ 
=
ââ 
values
ââ  &
.
ââ& '"
IdentificationImages
ââ' ;
!
ââ; <
[
ââ< =
$num
ââ= >
]
ââ> ?
;
ââ? @
_imageThree
ää 
=
ää  !
values
ää" (
.
ää( )"
IdentificationImages
ää) =
!
ää= >
[
ää> ?
$num
ää? @
]
ää@ A
;
ääA B

_imageFour
ãã 
=
ãã  
values
ãã! '
.
ãã' ("
IdentificationImages
ãã( <
!
ãã< =
[
ãã= >
$num
ãã> ?
]
ãã? @
;
ãã@ A

_imageFive
åå 
=
åå  
values
åå! '
.
åå' ("
IdentificationImages
åå( <
!
åå< =
[
åå= >
$num
åå> ?
]
åå? @
;
åå@ A
break
çç 
;
çç 
}
éé 

imageCount
êê 
=
êê 
values
êê 
.
êê  
NonResident
êê  +
!
êê+ ,
.
êê, -0
"ContactPerson_IdentificationImages
êê- O
!
êêO P
.
êêP Q
Count
êêQ V
(
êêV W
)
êêW X
;
êêX Y
switch
ëë 
(
ëë 

imageCount
ëë 
)
ëë 
{
íí 
case
ìì 
$num
ìì 
:
ìì 

c_imageOne
îî 
=
îî  
values
îî! '
.
îî' ("
IdentificationImages
îî( <
!
îî< =
[
îî= >
$num
îî> ?
]
îî? @
;
îî@ A
break
ïï 
;
ïï 
case
óó 
$num
óó 
:
óó 

c_imageOne
òò 
=
òò  
values
òò! '
.
òò' ("
IdentificationImages
òò( <
!
òò< =
[
òò= >
$num
òò> ?
]
òò? @
;
òò@ A

c_imageTwo
ôô 
=
ôô  
values
ôô! '
.
ôô' ("
IdentificationImages
ôô( <
!
ôô< =
[
ôô= >
$num
ôô> ?
]
ôô? @
;
ôô@ A
break
öö 
;
öö 
}
õõ 
try
ùù 
{
ûû 
CustomerMaster
üü 
customer
üü '
=
üü( )
await
üü* /
CustomerMaster
üü0 >
.
üü> ?#
CreateIndividualAsync
üü? T
(
†† 
customerMasterId
°° (
:
°°( )
values
°°* 0
.
°°0 1
CustomerMasterId
°°1 A
,
°°A B
customerTypeId
¢¢ &
:
¢¢& '
values
¢¢( .
.
¢¢. /
CustomerTypeId
¢¢/ =
,
¢¢= >
residentTypeId
££ &
:
££& '
values
££( .
.
££. /
ResidentTypeId
££/ =
,
££= >

localityId
§§ "
:
§§" #
values
§§$ *
.
§§* +

LocalityId
§§+ 5
,
§§5 6
customerCode
•• $
:
••$ %
values
••& ,
.
••, -
CustomerCode
••- 9
!
••9 :
,
••: ;
titleId
¶¶ 
:
¶¶  
values
¶¶! '
.
¶¶' (
TitleId
¶¶( /
,
¶¶/ 0
surName
ßß 
:
ßß  
values
ßß! '
.
ßß' (
SurName
ßß( /
,
ßß/ 0

otherNames
®® "
:
®®" #
values
®®$ *
.
®®* +

OtherNames
®®+ 5
,
®®5 6
dateOfBirth
™™ #
:
™™# $
values
™™% +
.
™™+ ,
DateOfBirth
™™, 7
,
™™7 8
	tinNumber
´´ !
:
´´! "
values
´´# )
.
´´) *
	TinNumber
´´* 3
!
´´3 4
,
´´4 5
picture
¨¨ 
:
¨¨  
values
¨¨! '
.
¨¨' (
Picture
¨¨( /
!
¨¨/ 0
,
¨¨0 1
genderId
≠≠  
:
≠≠  !
values
≠≠" (
.
≠≠( )
GenderId
≠≠) 1
,
≠≠1 2
nationalityId
ÆÆ %
:
ÆÆ% &
values
ÆÆ' -
.
ÆÆ- .
NationalityId
ÆÆ. ;
,
ÆÆ; <
postalAddress
ØØ %
:
ØØ% &
values
ØØ' -
.
ØØ- .
PostalAddress
ØØ. ;
!
ØØ; <
,
ØØ< = 
residentialAddress
∞∞ *
:
∞∞* +
values
∞∞, 2
.
∞∞2 3 
ResidentialAddress
∞∞3 E
!
∞∞E F
,
∞∞F G
digitalAddress
±± &
:
±±& '
values
±±( .
.
±±. /
DigitalAddress
±±/ =
!
±±= >
,
±±> ?!
primaryMobileNumber
≤≤ +
:
≤≤+ ,
values
≤≤- 3
.
≤≤3 4!
PrimaryMobileNumber
≤≤4 G
!
≤≤G H
,
≤≤H I#
secondaryMobileNumber
≥≥ -
:
≥≥- .
values
≥≥/ 5
.
≥≥5 6#
SecondaryMobileNumber
≥≥6 K
!
≥≥K L
,
≥≥L M
officeNumber
¥¥ $
:
¥¥$ %
values
¥¥& ,
.
¥¥, -
OfficeNumber
¥¥- 9
!
¥¥9 :
,
¥¥: ;
whatsAppNumber
µµ &
:
µµ& '
values
µµ( .
.
µµ. /
WhatsAppNumber
µµ/ =
!
µµ= >
,
µµ> ?
emailAddress
∂∂ $
:
∂∂$ %
values
∂∂& ,
.
∂∂, -
EmailAddress
∂∂- 9
,
∂∂9 :"
residentPermitNumber
∑∑ ,
:
∑∑, -
values
∑∑. 4
.
∑∑4 5

Expatriate
∑∑5 ?
!
∑∑? @
.
∑∑@ A"
ResidentPermitNumber
∑∑A U
!
∑∑U V
,
∑∑V W&
residentPermitDateIssued
∏∏ 0
:
∏∏0 1
values
∏∏2 8
.
∏∏8 9

Expatriate
∏∏9 C
!
∏∏C D
.
∏∏D E&
ResidentPermitDateIssued
∏∏E ]
!
∏∏] ^
,
∏∏^ _&
residentPermitExpiryDate
ππ 0
:
ππ0 1
values
ππ2 8
.
ππ8 9

Expatriate
ππ9 C
!
ππC D
.
ππD E&
ResidentPermitExpiryDate
ππE ]
!
ππ] ^
,
ππ^ _
socialMediaTypeId
∫∫ )
:
∫∫) *
values
∫∫+ 1
.
∫∫1 2
SocialMediaTypeId
∫∫2 C
,
∫∫C D 
socialMediaAccount
ªª *
:
ªª* +
values
ªª, 2
.
ªª2 3 
SocialMediaAccount
ªª3 E
!
ªªE F
,
ªªF G"
identificationTypeId
ºº ,
:
ºº, -
values
ºº. 4
.
ºº4 5"
IdentificationTypeId
ºº5 I
,
ººI J&
identificationTypeNumber
ΩΩ 0
:
ΩΩ0 1
values
ΩΩ2 8
.
ΩΩ8 9&
IdentificationTypeNumber
ΩΩ9 Q
!
ΩΩQ R
,
ΩΩR S(
identificationTypeImageOne
ææ 2
:
ææ2 3
	_imageOne
ææ4 =
,
ææ= >(
identificationTypeImageTwo
øø 2
:
øø2 3
	_imageTwo
øø4 =
,
øø= >*
identificationTypeImageThree
¿¿ 4
:
¿¿4 5
_imageThree
¿¿6 A
,
¿¿A B)
identificationTypeImageFour
¡¡ 3
:
¡¡3 4

_imageFour
¡¡5 ?
,
¡¡? @)
identificationTypeImageFive
¬¬ 3
:
¬¬3 4

_imageFive
¬¬5 ?
,
¬¬? @
comments
√√  
:
√√  !
values
√√" (
.
√√( )
Comments
√√) 1
!
√√1 2
,
√√2 3
interestExpressed
ƒƒ )
:
ƒƒ) *
string
ƒƒ+ 1
.
ƒƒ1 2
Empty
ƒƒ2 7
,
ƒƒ7 8
debtorStatus
≈≈ $
:
≈≈$ %
$num
≈≈& '
,
≈≈' (

parentCode
∆∆ "
:
∆∆" #
string
∆∆$ *
.
∆∆* +
Empty
∆∆+ 0
,
∆∆0 1$
contactPerson_FullName
«« .
:
««. /
values
««0 6
.
««6 7
NonResident
««7 B
.
««B C$
ContactPerson_FullName
««C Y
!
««Y Z
,
««Z ['
contactPerson_PhoneNumber
»» 1
:
»»1 2
values
»»3 9
.
»»9 :
NonResident
»»: E
.
»»E F'
ContactPerson_PhoneNumber
»»F _
!
»»_ `
,
»»` a(
contactPerson_EmailAddress
…… 2
:
……2 3
values
……4 :
.
……: ;
NonResident
……; F
.
……F G(
ContactPerson_EmailAddress
……G a
!
……a b
,
……b c#
contactPerson_Address
   -
:
  - .
values
  / 5
.
  5 6
NonResident
  6 A
.
  A B#
ContactPerson_Address
  B W
!
  W X
,
  X Y0
"contactPerson_IdentificationTypeId
ÀÀ :
:
ÀÀ: ;
values
ÀÀ< B
.
ÀÀB C
NonResident
ÀÀC N
.
ÀÀN O0
"ContactPerson_IdentificationTypeId
ÀÀO q
,
ÀÀq r4
&contactPerson_IdentificationTypeNumber
ÃÃ >
:
ÃÃ> ?
values
ÃÃ@ F
.
ÃÃF G
NonResident
ÃÃG R
.
ÃÃR S4
&ContactPerson_IdentificationTypeNumber
ÃÃS y
!
ÃÃy z
,
ÃÃz {6
(contactPerson_IdentificationTypeImageOne
ÕÕ @
:
ÕÕ@ A

c_imageOne
ÕÕB L
,
ÕÕL M6
(contactPerson_IdentificationTypeImageTwo
ŒŒ @
:
ŒŒ@ A

c_imageOne
ŒŒB L
,
ŒŒL M
	isDeleted
œœ !
:
œœ! "
false
œœ# (
,
œœ( )
	isPrimary
–– !
:
––! "
true
––# '
,
––' (
_domainService
—— &
)
““ 
;
““ 
customer
‘‘ 
.
‘‘ 
	CreatedBy
‘‘ "
=
‘‘# $
values
‘‘% +
.
‘‘+ ,
	CreatedBy
‘‘, 5
;
‘‘5 6
customer
’’ 
.
’’ 
	CreatedOn
’’ "
=
’’# $
DateTime
’’% -
.
’’- .
UtcNow
’’. 4
;
’’4 5
customer
÷÷ 
.
÷÷ 
DebtorStatus
÷÷ %
=
÷÷& '
$num
÷÷( )
;
÷÷) *
_unitOfWork
ÿÿ 
.
ÿÿ 
CustomerMaster
ÿÿ *
.
ÿÿ* +
Insert
ÿÿ+ 1
(
ÿÿ1 2
customer
ÿÿ2 :
)
ÿÿ: ;
;
ÿÿ; <
var
€€ 
	_locality
€€ 
=
€€ 
await
€€  %
_unitOfWork
€€& 1
.
€€1 2
Locality
€€2 :
.
€€: ;
Get
€€; >
(
€€> ?
values
€€? E
.
€€E F

LocalityId
€€F P
)
€€P Q
;
€€Q R
var
‹‹ 
code
‹‹ 
=
‹‹ 
customer
‹‹ #
.
‹‹# $
CustomerCode
‹‹$ 0
!
‹‹0 1
.
‹‹1 2
	Substring
‹‹2 ;
(
‹‹; <
Math
‹‹< @
.
‹‹@ A
Max
‹‹A D
(
‹‹D E
$num
‹‹E F
,
‹‹F G
customer
‹‹H P
.
‹‹P Q
CustomerCode
‹‹Q ]
!
‹‹] ^
.
‹‹^ _
Length
‹‹_ e
-
‹‹f g
$num
‹‹h i
)
‹‹i j
)
‹‹j k
;
‹‹k l
	_locality
›› 
!
›› 
.
›› !
CustomerCodeCounter
›› .
=
››/ 0
Convert
››1 8
.
››8 9
ToInt32
››9 @
(
››@ A
code
››A E
)
››E F
;
››F G
_unitOfWork
ﬁﬁ 
.
ﬁﬁ 
Locality
ﬁﬁ $
.
ﬁﬁ$ %
Update
ﬁﬁ% +
(
ﬁﬁ+ ,
	_locality
ﬁﬁ, 5
)
ﬁﬁ5 6
;
ﬁﬁ6 7
await
ﬂﬂ 
_unitOfWork
ﬂﬂ !
.
ﬂﬂ! "
Complete
ﬂﬂ" *
(
ﬂﬂ* +
)
ﬂﬂ+ ,
;
ﬂﬂ, -
var
„„ 
_title
„„ 
=
„„ 
(
„„ 
await
„„ #
_unitOfWork
„„$ /
.
„„/ 0
Title
„„0 5
.
„„5 6
Get
„„6 9
(
„„9 :
t
„„: ;
=>
„„< >
t
„„? @
.
„„@ A
TitleId
„„A H
==
„„I K
customer
„„L T
.
„„T U
TitleId
„„U \
)
„„\ ]
)
„„] ^
!
„„^ _
.
„„_ `
Titles
„„` f
;
„„f g
var
‰‰ 
customername
‰‰  
=
‰‰! "
string
‰‰# )
.
‰‰) *
Concat
‰‰* 0
(
‰‰0 1
_title
‰‰1 7
,
‰‰7 8
$str
‰‰9 <
,
‰‰< =
customer
‰‰> F
.
‰‰F G

OtherNames
‰‰G Q
,
‰‰Q R
$str
‰‰S V
,
‰‰V W
customer
‰‰X `
.
‰‰` a
SurName
‰‰a h
)
‰‰h i
.
‰‰i j
Trim
‰‰j n
(
‰‰n o
)
‰‰o p
;
‰‰p q
var
ÊÊ  
registeredCustomer
ÊÊ &
=
ÊÊ' (
new
ÊÊ) ,4
&CustomerRegistrationSuccessResponseDto
ÊÊ- S
{
ÁÁ 
CustomerCode
ËË  
=
ËË! "
customer
ËË# +
.
ËË+ ,
CustomerCode
ËË, 8
,
ËË8 9
FullName
ÈÈ 
=
ÈÈ 
customername
ÈÈ +
,
ÈÈ+ ,
PhoneNumber
ÍÍ 
=
ÍÍ  !
customer
ÍÍ" *
.
ÍÍ* +!
PrimaryMobileNumber
ÍÍ+ >
,
ÍÍ> ?
}
ÎÎ 
;
ÎÎ 
return
ÌÌ 
new
ÌÌ -
CustomerRegistrationResponseDto
ÌÌ :
{
ÌÌ; <
	IsSuccess
ÌÌ= F
=
ÌÌG H
true
ÌÌI M
,
ÌÌM N
SuccessResponse
ÌÌO ^
=
ÌÌ_ ` 
registeredCustomer
ÌÌa s
}
ÌÌt u
;
ÌÌu v
}
ÓÓ 
catch
ÔÔ 
(
ÔÔ 
	Exception
ÔÔ 
ex
ÔÔ 
)
ÔÔ  
{
 
var
ÒÒ 
err
ÒÒ 
=
ÒÒ 
new
ÒÒ 
BaseResponseDto
ÒÒ -
{
ÒÒ. /

StatusCode
ÒÒ0 :
=
ÒÒ; <
$num
ÒÒ= @
,
ÒÒ@ A
StatusMessage
ÒÒB O
=
ÒÒP Q
ex
ÒÒR T
.
ÒÒT U
InnerException
ÒÒU c
!
ÒÒc d
.
ÒÒd e
Message
ÒÒe l
}
ÒÒm n
;
ÒÒn o
return
ÚÚ 
new
ÚÚ -
CustomerRegistrationResponseDto
ÚÚ :
{
ÚÚ; <
	IsSuccess
ÚÚ= F
=
ÚÚG H
false
ÚÚI N
,
ÚÚN O
ErrorResponse
ÚÚP ]
=
ÚÚ^ _
err
ÚÚ` c
}
ÚÚd e
;
ÚÚe f
}
ÙÙ 
}
ıı 	
public
˜˜ 
async
˜˜ 
Task
˜˜ 
<
˜˜ -
CustomerRegistrationResponseDto
˜˜ 9
>
˜˜9 :
CreateCustomer
˜˜; I
(
˜˜I J'
JointOwnershipCustomerDto
˜˜J c
values
˜˜d j
)
˜˜j k
{
¯¯ 	
string
˙˙ 
	_imageOne
˙˙ 
=
˙˙ 
string
˙˙ %
.
˙˙% &
Empty
˙˙& +
;
˙˙+ ,
string
˙˙- 3
	_imageTwo
˙˙4 =
=
˙˙> ?
string
˙˙@ F
.
˙˙F G
Empty
˙˙G L
;
˙˙L M
string
˙˙N T
_imageThree
˙˙U `
=
˙˙a b
string
˙˙c i
.
˙˙i j
Empty
˙˙j o
;
˙˙o p
string
˙˙q w

_imageFour˙˙x Ç
=˙˙É Ñ
string˙˙Ö ã
.˙˙ã å
Empty˙˙å ë
;˙˙ë í
string˙˙ì ô

_imageFive˙˙ö §
=˙˙• ¶
string˙˙ß ≠
.˙˙≠ Æ
Empty˙˙Æ ≥
;˙˙≥ ¥
string
˚˚ 

c_imageOne
˚˚ 
=
˚˚ 
string
˚˚  &
.
˚˚& '
Empty
˚˚' ,
;
˚˚, -
string
˚˚. 4

c_imageTwo
˚˚5 ?
=
˚˚@ A
string
˚˚B H
.
˚˚H I
Empty
˚˚I N
;
˚˚N O
int
¸¸ 

imageCount
¸¸ 
;
¸¸ 

imageCount
˛˛ 
=
˛˛ 
values
˛˛ 
.
˛˛  "
IdentificationImages
˛˛  4
!
˛˛4 5
.
˛˛5 6
Count
˛˛6 ;
(
˛˛; <
)
˛˛< =
;
˛˛= >
switch
ˇˇ 
(
ˇˇ 

imageCount
ˇˇ 
)
ˇˇ 
{
ÄÄ 
case
ÅÅ 
$num
ÅÅ 
:
ÅÅ 
	_imageOne
ÇÇ 
=
ÇÇ 
values
ÇÇ  &
.
ÇÇ& '"
IdentificationImages
ÇÇ' ;
!
ÇÇ; <
[
ÇÇ< =
$num
ÇÇ= >
]
ÇÇ> ?
;
ÇÇ? @
break
ÉÉ 
;
ÉÉ 
case
ÖÖ 
$num
ÖÖ 
:
ÖÖ 
	_imageOne
ÜÜ 
=
ÜÜ 
values
ÜÜ  &
.
ÜÜ& '"
IdentificationImages
ÜÜ' ;
!
ÜÜ; <
[
ÜÜ< =
$num
ÜÜ= >
]
ÜÜ> ?
;
ÜÜ? @
	_imageTwo
áá 
=
áá 
values
áá  &
.
áá& '"
IdentificationImages
áá' ;
!
áá; <
[
áá< =
$num
áá= >
]
áá> ?
;
áá? @
break
àà 
;
àà 
case
ää 
$num
ää 
:
ää 
	_imageOne
ãã 
=
ãã 
values
ãã  &
.
ãã& '"
IdentificationImages
ãã' ;
!
ãã; <
[
ãã< =
$num
ãã= >
]
ãã> ?
;
ãã? @
	_imageTwo
åå 
=
åå 
values
åå  &
.
åå& '"
IdentificationImages
åå' ;
!
åå; <
[
åå< =
$num
åå= >
]
åå> ?
;
åå? @
_imageThree
çç 
=
çç  !
values
çç" (
.
çç( )"
IdentificationImages
çç) =
!
çç= >
[
çç> ?
$num
çç? @
]
çç@ A
;
ççA B
break
éé 
;
éé 
case
êê 
$num
êê 
:
êê 
	_imageOne
ëë 
=
ëë 
values
ëë  &
.
ëë& '"
IdentificationImages
ëë' ;
!
ëë; <
[
ëë< =
$num
ëë= >
]
ëë> ?
;
ëë? @
	_imageTwo
íí 
=
íí 
values
íí  &
.
íí& '"
IdentificationImages
íí' ;
!
íí; <
[
íí< =
$num
íí= >
]
íí> ?
;
íí? @
_imageThree
ìì 
=
ìì  !
values
ìì" (
.
ìì( )"
IdentificationImages
ìì) =
!
ìì= >
[
ìì> ?
$num
ìì? @
]
ìì@ A
;
ììA B

_imageFour
îî 
=
îî  
values
îî! '
.
îî' ("
IdentificationImages
îî( <
!
îî< =
[
îî= >
$num
îî> ?
]
îî? @
;
îî@ A
break
ïï 
;
ïï 
case
óó 
$num
óó 
:
óó 
	_imageOne
òò 
=
òò 
values
òò  &
.
òò& '"
IdentificationImages
òò' ;
!
òò; <
[
òò< =
$num
òò= >
]
òò> ?
;
òò? @
	_imageTwo
ôô 
=
ôô 
values
ôô  &
.
ôô& '"
IdentificationImages
ôô' ;
!
ôô; <
[
ôô< =
$num
ôô= >
]
ôô> ?
;
ôô? @
_imageThree
öö 
=
öö  !
values
öö" (
.
öö( )"
IdentificationImages
öö) =
!
öö= >
[
öö> ?
$num
öö? @
]
öö@ A
;
ööA B

_imageFour
õõ 
=
õõ  
values
õõ! '
.
õõ' ("
IdentificationImages
õõ( <
!
õõ< =
[
õõ= >
$num
õõ> ?
]
õõ? @
;
õõ@ A

_imageFive
úú 
=
úú  
values
úú! '
.
úú' ("
IdentificationImages
úú( <
!
úú< =
[
úú= >
$num
úú> ?
]
úú? @
;
úú@ A
break
ùù 
;
ùù 
}
ûû 

imageCount
°° 
=
°° 
values
°° 
.
°°  
NonResident
°°  +
!
°°+ ,
.
°°, -0
"ContactPerson_IdentificationImages
°°- O
!
°°O P
.
°°P Q
Count
°°Q V
(
°°V W
)
°°W X
;
°°X Y
switch
¢¢ 
(
¢¢ 

imageCount
¢¢ 
)
¢¢ 
{
££ 
case
§§ 
$num
§§ 
:
§§ 

c_imageOne
•• 
=
••  
values
••! '
.
••' ("
IdentificationImages
••( <
!
••< =
[
••= >
$num
••> ?
]
••? @
;
••@ A
break
¶¶ 
;
¶¶ 
case
®® 
$num
®® 
:
®® 

c_imageOne
©© 
=
©©  
values
©©! '
.
©©' ("
IdentificationImages
©©( <
!
©©< =
[
©©= >
$num
©©> ?
]
©©? @
;
©©@ A

c_imageTwo
™™ 
=
™™  
values
™™! '
.
™™' ("
IdentificationImages
™™( <
!
™™< =
[
™™= >
$num
™™> ?
]
™™? @
;
™™@ A
break
´´ 
;
´´ 
}
¨¨ 
CustomerMaster
ØØ 
customer
ØØ #
=
ØØ$ %
await
ØØ& +
CustomerMaster
ØØ, :
.
ØØ: ;
CreateJointAsync
ØØ; K
(
∞∞ 
customerMasterId
±± $
:
±±$ %
values
±±& ,
.
±±, -
CustomerMasterId
±±- =
,
±±= >
customerTypeId
≤≤ "
:
≤≤" #
values
≤≤$ *
.
≤≤* +
CustomerTypeId
≤≤+ 9
,
≤≤9 :
residentTypeId
≥≥ "
:
≥≥" #
values
≥≥$ *
.
≥≥* +
ResidentTypeId
≥≥+ 9
,
≥≥9 :

localityId
¥¥ 
:
¥¥ 
values
¥¥  &
.
¥¥& '

LocalityId
¥¥' 1
,
¥¥1 2
customerCode
µµ  
:
µµ  !
values
µµ" (
.
µµ( )
CustomerCode
µµ) 5
!
µµ5 6
,
µµ6 7
titleId
∂∂ 
:
∂∂ 
values
∂∂ #
.
∂∂# $
TitleId
∂∂$ +
,
∂∂+ ,
surName
∑∑ 
:
∑∑ 
values
∑∑ #
.
∑∑# $
SurName
∑∑$ +
,
∑∑+ ,

otherNames
∏∏ 
:
∏∏ 
values
∏∏  &
.
∏∏& '

OtherNames
∏∏' 1
,
∏∏1 2
dateOfBirth
∫∫ 
:
∫∫  
values
∫∫! '
.
∫∫' (
DateOfBirth
∫∫( 3
,
∫∫3 4
	tinNumber
ªª 
:
ªª 
values
ªª %
.
ªª% &
	TinNumber
ªª& /
!
ªª/ 0
,
ªª0 1
picture
ºº 
:
ºº 
values
ºº #
.
ºº# $
Picture
ºº$ +
!
ºº+ ,
,
ºº, -
genderId
ΩΩ 
:
ΩΩ 
values
ΩΩ $
.
ΩΩ$ %
GenderId
ΩΩ% -
,
ΩΩ- .
nationalityId
ææ !
:
ææ! "
values
ææ# )
.
ææ) *
NationalityId
ææ* 7
,
ææ7 8
postalAddress
øø !
:
øø! "
values
øø# )
.
øø) *
PostalAddress
øø* 7
!
øø7 8
,
øø8 9 
residentialAddress
¿¿ &
:
¿¿& '
values
¿¿( .
.
¿¿. / 
ResidentialAddress
¿¿/ A
!
¿¿A B
,
¿¿B C
digitalAddress
¡¡ "
:
¡¡" #
values
¡¡$ *
.
¡¡* +
DigitalAddress
¡¡+ 9
!
¡¡9 :
,
¡¡: ;!
primaryMobileNumber
¬¬ '
:
¬¬' (
values
¬¬) /
.
¬¬/ 0!
PrimaryMobileNumber
¬¬0 C
!
¬¬C D
,
¬¬D E#
secondaryMobileNumber
√√ )
:
√√) *
values
√√+ 1
.
√√1 2#
SecondaryMobileNumber
√√2 G
!
√√G H
,
√√H I
officeNumber
ƒƒ  
:
ƒƒ  !
values
ƒƒ" (
.
ƒƒ( )
OfficeNumber
ƒƒ) 5
!
ƒƒ5 6
,
ƒƒ6 7
whatsAppNumber
≈≈ "
:
≈≈" #
values
≈≈$ *
.
≈≈* +
WhatsAppNumber
≈≈+ 9
!
≈≈9 :
,
≈≈: ;
emailAddress
∆∆  
:
∆∆  !
values
∆∆" (
.
∆∆( )
EmailAddress
∆∆) 5
,
∆∆5 6"
residentPermitNumber
«« (
:
««( )
values
««* 0
.
««0 1

Expatriate
««1 ;
!
««; <
.
««< ="
ResidentPermitNumber
««= Q
!
««Q R
,
««R S&
residentPermitDateIssued
»» ,
:
»», -
values
»». 4
.
»»4 5

Expatriate
»»5 ?
!
»»? @
.
»»@ A&
ResidentPermitDateIssued
»»A Y
!
»»Y Z
,
»»Z [&
residentPermitExpiryDate
…… ,
:
……, -
values
……. 4
.
……4 5

Expatriate
……5 ?
!
……? @
.
……@ A&
ResidentPermitExpiryDate
……A Y
!
……Y Z
,
……Z [
socialMediaTypeId
   %
:
  % &
values
  ' -
.
  - .
SocialMediaTypeId
  . ?
,
  ? @ 
socialMediaAccount
ÀÀ &
:
ÀÀ& '
values
ÀÀ( .
.
ÀÀ. / 
SocialMediaAccount
ÀÀ/ A
!
ÀÀA B
,
ÀÀB C"
identificationTypeId
ÃÃ (
:
ÃÃ( )
values
ÃÃ* 0
.
ÃÃ0 1"
IdentificationTypeId
ÃÃ1 E
,
ÃÃE F&
identificationTypeNumber
ÕÕ ,
:
ÕÕ, -
values
ÕÕ. 4
.
ÕÕ4 5&
IdentificationTypeNumber
ÕÕ5 M
!
ÕÕM N
,
ÕÕN O(
identificationTypeImageOne
ŒŒ .
:
ŒŒ. /
	_imageOne
ŒŒ0 9
,
ŒŒ9 :(
identificationTypeImageTwo
œœ .
:
œœ. /
	_imageTwo
œœ0 9
,
œœ9 :*
identificationTypeImageThree
–– 0
:
––0 1
_imageThree
––2 =
,
––= >)
identificationTypeImageFour
—— /
:
——/ 0

_imageFour
——1 ;
,
——; <)
identificationTypeImageFive
““ /
:
““/ 0

_imageFive
““1 ;
,
““; <
comments
”” 
:
”” 
values
”” $
.
””$ %
Comments
””% -
!
””- .
,
””. /
interestExpressed
‘‘ %
:
‘‘% &
string
‘‘' -
.
‘‘- .
Empty
‘‘. 3
,
‘‘3 4
debtorStatus
’’  
:
’’  !
$num
’’" #
,
’’# $

parentCode
÷÷ 
:
÷÷ 
string
÷÷  &
.
÷÷& '
Empty
÷÷' ,
,
÷÷, -$
contactPerson_FullName
◊◊ *
:
◊◊* +
values
◊◊, 2
.
◊◊2 3
NonResident
◊◊3 >
.
◊◊> ?$
ContactPerson_FullName
◊◊? U
!
◊◊U V
,
◊◊V W'
contactPerson_PhoneNumber
ÿÿ -
:
ÿÿ- .
values
ÿÿ/ 5
.
ÿÿ5 6
NonResident
ÿÿ6 A
.
ÿÿA B'
ContactPerson_PhoneNumber
ÿÿB [
!
ÿÿ[ \
,
ÿÿ\ ](
contactPerson_EmailAddress
ŸŸ .
:
ŸŸ. /
values
ŸŸ0 6
.
ŸŸ6 7
NonResident
ŸŸ7 B
.
ŸŸB C(
ContactPerson_EmailAddress
ŸŸC ]
!
ŸŸ] ^
,
ŸŸ^ _#
contactPerson_Address
⁄⁄ )
:
⁄⁄) *
values
⁄⁄+ 1
.
⁄⁄1 2
NonResident
⁄⁄2 =
.
⁄⁄= >#
ContactPerson_Address
⁄⁄> S
!
⁄⁄S T
,
⁄⁄T U0
"contactPerson_IdentificationTypeId
€€ 6
:
€€6 7
values
€€8 >
.
€€> ?
NonResident
€€? J
.
€€J K0
"ContactPerson_IdentificationTypeId
€€K m
,
€€m n4
&contactPerson_IdentificationTypeNumber
‹‹ :
:
‹‹: ;
values
‹‹< B
.
‹‹B C
NonResident
‹‹C N
.
‹‹N O4
&ContactPerson_IdentificationTypeNumber
‹‹O u
!
‹‹u v
,
‹‹v w6
(contactPerson_IdentificationTypeImageOne
›› <
:
››< =

c_imageOne
››> H
,
››H I6
(contactPerson_IdentificationTypeImageTwo
ﬁﬁ <
:
ﬁﬁ< =

c_imageTwo
ﬁﬁ> H
,
ﬁﬁH I
	isDeleted
ﬂﬂ 
:
ﬂﬂ 
false
ﬂﬂ $
,
ﬂﬂ$ %
	isPrimary
‡‡ 
:
‡‡ 
true
‡‡ #
,
‡‡# $
maritalStatus
·· !
:
··! "
values
··# )
.
··) *
MaritalStatus
··* 7
!
··7 8
,
··8 9
dateOfMarriage
‚‚ "
:
‚‚" #
values
‚‚$ *
.
‚‚* +
DateOfMarriage
‚‚+ 9
!
‚‚9 :
,
‚‚: ;
_domainService
„„ "
)
‰‰ 
;
‰‰ 
customer
ÊÊ 
.
ÊÊ 
	CreatedBy
ÊÊ 
=
ÊÊ  
values
ÊÊ! '
.
ÊÊ' (
	CreatedBy
ÊÊ( 1
;
ÊÊ1 2
customer
ÁÁ 
.
ÁÁ 
	CreatedOn
ÁÁ 
=
ÁÁ  
DateTime
ÁÁ! )
.
ÁÁ) *
UtcNow
ÁÁ* 0
;
ÁÁ0 1
customer
ËË 
.
ËË 
DebtorStatus
ËË !
=
ËË" #
$num
ËË$ %
;
ËË% &
List
ÍÍ 
<
ÍÍ 
CustomerMaster
ÍÍ 
>
ÍÍ  
jointCustomers
ÍÍ! /
=
ÍÍ0 1
new
ÍÍ2 5
List
ÍÍ6 :
<
ÍÍ: ;
CustomerMaster
ÍÍ; I
>
ÍÍI J
{
ÎÎ 
customer
ÏÏ 
}
ÌÌ 
;
ÌÌ 
string
ÔÔ 
co_imageOne
ÔÔ 
=
ÔÔ  
string
ÔÔ! '
.
ÔÔ' (
Empty
ÔÔ( -
;
ÔÔ- .
string
ÔÔ/ 5
co_imageTwo
ÔÔ6 A
=
ÔÔB C
string
ÔÔD J
.
ÔÔJ K
Empty
ÔÔK P
;
ÔÔP Q
string
 
col_imageOne
 
=
  !
string
" (
.
( )
Empty
) .
;
. /
string
0 6
col_imageTwo
7 C
=
D E
string
F L
.
L M
Empty
M R
;
R S
int
ÒÒ 
co_imageCount
ÒÒ 
;
ÒÒ 
int
ıı 
count
ıı 
=
ıı 
$num
ıı 
;
ıı 
foreach
ˆˆ 
(
ˆˆ 
var
ˆˆ 
value
ˆˆ 
in
ˆˆ !
values
ˆˆ" (
.
ˆˆ( )
CoLesse
ˆˆ) 0
!
ˆˆ0 1
)
ˆˆ1 2
{
˜˜ 
co_imageCount
¯¯ 
=
¯¯ 
value
¯¯  %
.
¯¯% &"
IdentificationImages
¯¯& :
!
¯¯: ;
.
¯¯; <
Count
¯¯< A
(
¯¯A B
)
¯¯B C
;
¯¯C D
switch
˘˘ 
(
˘˘ 
co_imageCount
˘˘ %
)
˘˘% &
{
˙˙ 
case
˚˚ 
$num
˚˚ 
:
˚˚ 
co_imageOne
¸¸ #
=
¸¸$ %
value
¸¸& +
.
¸¸+ ,"
IdentificationImages
¸¸, @
!
¸¸@ A
[
¸¸A B
$num
¸¸B C
]
¸¸C D
;
¸¸D E
break
˝˝ 
;
˝˝ 
case
ˇˇ 
$num
ˇˇ 
:
ˇˇ 
co_imageOne
ÄÄ #
=
ÄÄ$ %
value
ÄÄ& +
.
ÄÄ+ ,"
IdentificationImages
ÄÄ, @
!
ÄÄ@ A
[
ÄÄA B
$num
ÄÄB C
]
ÄÄC D
;
ÄÄD E
co_imageTwo
ÅÅ #
=
ÅÅ$ %
value
ÅÅ& +
.
ÅÅ+ ,"
IdentificationImages
ÅÅ, @
!
ÅÅ@ A
[
ÅÅA B
$num
ÅÅB C
]
ÅÅC D
;
ÅÅD E
break
ÇÇ 
;
ÇÇ 
}
ÉÉ 
co_imageCount
ÜÜ 
=
ÜÜ 
value
ÜÜ  %
.
ÜÜ% &
NonResident
ÜÜ& 1
!
ÜÜ1 2
.
ÜÜ2 30
"ContactPerson_IdentificationImages
ÜÜ3 U
!
ÜÜU V
.
ÜÜV W
Count
ÜÜW \
(
ÜÜ\ ]
)
ÜÜ] ^
;
ÜÜ^ _
switch
áá 
(
áá 
co_imageCount
áá %
)
áá% &
{
àà 
case
ââ 
$num
ââ 
:
ââ 
col_imageOne
ää $
=
ää% &
value
ää' ,
.
ää, -"
IdentificationImages
ää- A
!
ääA B
[
ääB C
$num
ääC D
]
ääD E
;
ääE F
break
ãã 
;
ãã 
case
çç 
$num
çç 
:
çç 
col_imageOne
éé $
=
éé% &
value
éé' ,
.
éé, -"
IdentificationImages
éé- A
!
ééA B
[
ééB C
$num
ééC D
]
ééD E
;
ééE F
col_imageTwo
èè $
=
èè% &
value
èè' ,
.
èè, -"
IdentificationImages
èè- A
!
èèA B
[
èèB C
$num
èèC D
]
èèD E
;
èèE F
break
êê 
;
êê 
}
ëë 
count
íí 
++
íí 
;
íí 
CustomerMaster
îî 
co_customer
îî *
=
îî+ ,
await
îî- 2
CustomerMaster
îî3 A
.
îîA B
CreateJointAsync
îîB R
(
ïï 
customerMasterId
ññ (
:
ññ( )
values
ññ* 0
.
ññ0 1
CustomerMasterId
ññ1 A
,
ññA B
customerTypeId
óó &
:
óó& '
values
óó( .
.
óó. /
CustomerTypeId
óó/ =
,
óó= >
residentTypeId
òò &
:
òò& '
values
òò( .
.
òò. /
ResidentTypeId
òò/ =
,
òò= >

localityId
ôô "
:
ôô" #
values
ôô$ *
.
ôô* +

LocalityId
ôô+ 5
,
ôô5 6
customerCode
öö $
:
öö$ %
string
öö& ,
.
öö, -
Empty
öö- 2
,
öö2 3
titleId
õõ 
:
õõ  
value
õõ! &
.
õõ& '
TitleId
õõ' .
,
õõ. /
surName
úú 
:
úú  
value
úú! &
.
úú& '
SurName
úú' .
,
úú. /

otherNames
ùù "
:
ùù" #
value
ùù$ )
.
ùù) *

OtherNames
ùù* 4
,
ùù4 5
dateOfBirth
ûû #
:
ûû# $
value
ûû% *
.
ûû* +
DateOfBirth
ûû+ 6
,
ûû6 7
	tinNumber
üü !
:
üü! "
value
üü# (
.
üü( )
	TinNumber
üü) 2
!
üü2 3
,
üü3 4
picture
†† 
:
††  
value
††! &
.
††& '
Picture
††' .
!
††. /
,
††/ 0
genderId
°°  
:
°°  !
value
°°" '
.
°°' (
GenderId
°°( 0
,
°°0 1
nationalityId
¢¢ %
:
¢¢% &
value
¢¢' ,
.
¢¢, -
NationalityId
¢¢- :
,
¢¢: ;
postalAddress
££ %
:
££% &
value
££' ,
.
££, -
PostalAddress
££- :
!
££: ;
,
££; < 
residentialAddress
§§ *
:
§§* +
value
§§, 1
.
§§1 2 
ResidentialAddress
§§2 D
!
§§D E
,
§§E F
digitalAddress
•• &
:
••& '
value
••( -
.
••- .
DigitalAddress
••. <
!
••< =
,
••= >!
primaryMobileNumber
¶¶ +
:
¶¶+ ,
value
¶¶- 2
.
¶¶2 3!
PrimaryMobileNumber
¶¶3 F
!
¶¶F G
,
¶¶G H#
secondaryMobileNumber
ßß -
:
ßß- .
value
ßß/ 4
.
ßß4 5#
SecondaryMobileNumber
ßß5 J
!
ßßJ K
,
ßßK L
officeNumber
®® $
:
®®$ %
value
®®& +
.
®®+ ,
OfficeNumber
®®, 8
!
®®8 9
,
®®9 :
whatsAppNumber
©© &
:
©©& '
value
©©( -
.
©©- .
WhatsAppNumber
©©. <
!
©©< =
,
©©= >
emailAddress
™™ $
:
™™$ %
value
™™& +
.
™™+ ,
EmailAddress
™™, 8
,
™™8 9"
residentPermitNumber
´´ ,
:
´´, -
value
´´. 3
.
´´3 4

Expatriate
´´4 >
!
´´> ?
.
´´? @"
ResidentPermitNumber
´´@ T
!
´´T U
,
´´U V&
residentPermitDateIssued
¨¨ 0
:
¨¨0 1
value
¨¨2 7
.
¨¨7 8

Expatriate
¨¨8 B
!
¨¨B C
.
¨¨C D&
ResidentPermitDateIssued
¨¨D \
!
¨¨\ ]
,
¨¨] ^&
residentPermitExpiryDate
≠≠ 0
:
≠≠0 1
value
≠≠2 7
.
≠≠7 8

Expatriate
≠≠8 B
!
≠≠B C
.
≠≠C D&
ResidentPermitExpiryDate
≠≠D \
!
≠≠\ ]
,
≠≠] ^
socialMediaTypeId
ÆÆ )
:
ÆÆ) *
value
ÆÆ+ 0
.
ÆÆ0 1
SocialMediaTypeId
ÆÆ1 B
,
ÆÆB C 
socialMediaAccount
ØØ *
:
ØØ* +
value
ØØ, 1
.
ØØ1 2 
SocialMediaAccount
ØØ2 D
!
ØØD E
,
ØØE F"
identificationTypeId
∞∞ ,
:
∞∞, -
value
∞∞. 3
.
∞∞3 4"
IdentificationTypeId
∞∞4 H
,
∞∞H I&
identificationTypeNumber
±± 0
:
±±0 1
value
±±2 7
.
±±7 8&
IdentificationTypeNumber
±±8 P
!
±±P Q
,
±±Q R(
identificationTypeImageOne
≤≤ 2
:
≤≤2 3
co_imageOne
≤≤4 ?
,
≤≤? @(
identificationTypeImageTwo
≥≥ 2
:
≥≥2 3
co_imageTwo
≥≥4 ?
,
≥≥? @*
identificationTypeImageThree
¥¥ 4
:
¥¥4 5
_imageThree
¥¥6 A
,
¥¥A B)
identificationTypeImageFour
µµ 3
:
µµ3 4

_imageFour
µµ5 ?
,
µµ? @)
identificationTypeImageFive
∂∂ 3
:
∂∂3 4

_imageFive
∂∂5 ?
,
∂∂? @
comments
∑∑  
:
∑∑  !
values
∑∑" (
.
∑∑( )
Comments
∑∑) 1
!
∑∑1 2
,
∑∑2 3
interestExpressed
∏∏ )
:
∏∏) *
string
∏∏+ 1
.
∏∏1 2
Empty
∏∏2 7
,
∏∏7 8
debtorStatus
ππ $
:
ππ$ %
$num
ππ& '
,
ππ' (

parentCode
∫∫ "
:
∫∫" #
customer
∫∫$ ,
.
∫∫, -
CustomerCode
∫∫- 9
!
∫∫9 :
,
∫∫: ;$
contactPerson_FullName
ªª .
:
ªª. /
value
ªª0 5
.
ªª5 6
NonResident
ªª6 A
.
ªªA B$
ContactPerson_FullName
ªªB X
!
ªªX Y
,
ªªY Z'
contactPerson_PhoneNumber
ºº 1
:
ºº1 2
value
ºº3 8
.
ºº8 9
NonResident
ºº9 D
.
ººD E'
ContactPerson_PhoneNumber
ººE ^
!
ºº^ _
,
ºº_ `(
contactPerson_EmailAddress
ΩΩ 2
:
ΩΩ2 3
value
ΩΩ4 9
.
ΩΩ9 :
NonResident
ΩΩ: E
.
ΩΩE F(
ContactPerson_EmailAddress
ΩΩF `
!
ΩΩ` a
,
ΩΩa b#
contactPerson_Address
ææ -
:
ææ- .
value
ææ/ 4
.
ææ4 5
NonResident
ææ5 @
.
ææ@ A#
ContactPerson_Address
ææA V
!
ææV W
,
ææW X0
"contactPerson_IdentificationTypeId
øø :
:
øø: ;
value
øø< A
.
øøA B
NonResident
øøB M
.
øøM N0
"ContactPerson_IdentificationTypeId
øøN p
,
øøp q4
&contactPerson_IdentificationTypeNumber
¿¿ >
:
¿¿> ?
value
¿¿@ E
.
¿¿E F
NonResident
¿¿F Q
.
¿¿Q R4
&ContactPerson_IdentificationTypeNumber
¿¿R x
!
¿¿x y
,
¿¿y z6
(contactPerson_IdentificationTypeImageOne
¡¡ @
:
¡¡@ A
col_imageOne
¡¡B N
,
¡¡N O6
(contactPerson_IdentificationTypeImageTwo
¬¬ @
:
¬¬@ A
col_imageTwo
¬¬B N
,
¬¬N O
	isDeleted
√√ !
:
√√! "
false
√√# (
,
√√( )
	isPrimary
ƒƒ !
:
ƒƒ! "
false
ƒƒ# (
,
ƒƒ( )
maritalStatus
≈≈ %
:
≈≈% &
values
≈≈' -
.
≈≈- .
MaritalStatus
≈≈. ;
!
≈≈; <
,
≈≈< =
dateOfMarriage
∆∆ &
:
∆∆& '
values
∆∆( .
.
∆∆. /
DateOfMarriage
∆∆/ =
!
∆∆= >
,
∆∆> ?
_domainService
«« &
)
»» 
;
»» 
co_customer
   
.
   
CustomerCode
   (
=
  ) *
$"
  + -
{
  - .
customer
  . 6
.
  6 7
CustomerCode
  7 C
!
  C D
}
  D E
$str
  E F
{
  F G
count
  G L
.
  L M
ToString
  M U
(
  U V
$str
  V Z
)
  Z [
}
  [ \
"
  \ ]
;
  ] ^
co_customer
ÀÀ 
.
ÀÀ 
	CreatedBy
ÀÀ %
=
ÀÀ& '
values
ÀÀ( .
.
ÀÀ. /
	CreatedBy
ÀÀ/ 8
;
ÀÀ8 9
co_customer
ÃÃ 
.
ÃÃ 
	CreatedOn
ÃÃ %
=
ÃÃ& '
DateTime
ÃÃ( 0
.
ÃÃ0 1
UtcNow
ÃÃ1 7
;
ÃÃ7 8
co_customer
ÕÕ 
.
ÕÕ 
DebtorStatus
ÕÕ (
=
ÕÕ) *
$num
ÕÕ+ ,
;
ÕÕ, -
jointCustomers
œœ 
.
œœ 
Add
œœ "
(
œœ" #
co_customer
œœ# .
)
œœ. /
;
œœ/ 0
}
–– 
_unitOfWork
““ 
.
““ 
CustomerMaster
““ &
.
““& '
InsertRange
““' 2
(
““2 3
jointCustomers
““3 A
)
““A B
;
““B C
var
÷÷ 
	_locality
÷÷ 
=
÷÷ 
await
÷÷ !
_unitOfWork
÷÷" -
.
÷÷- .
Locality
÷÷. 6
.
÷÷6 7
Get
÷÷7 :
(
÷÷: ;
values
÷÷; A
.
÷÷A B

LocalityId
÷÷B L
)
÷÷L M
;
÷÷M N
var
◊◊ 
code
◊◊ 
=
◊◊ 
customer
◊◊ 
.
◊◊  
CustomerCode
◊◊  ,
!
◊◊, -
.
◊◊- .
	Substring
◊◊. 7
(
◊◊7 8
Math
◊◊8 <
.
◊◊< =
Max
◊◊= @
(
◊◊@ A
$num
◊◊A B
,
◊◊B C
customer
◊◊D L
.
◊◊L M
CustomerCode
◊◊M Y
!
◊◊Y Z
.
◊◊Z [
Length
◊◊[ a
-
◊◊b c
$num
◊◊d e
)
◊◊e f
)
◊◊f g
;
◊◊g h
	_locality
ÿÿ 
!
ÿÿ 
.
ÿÿ !
CustomerCodeCounter
ÿÿ *
=
ÿÿ+ ,
Convert
ÿÿ- 4
.
ÿÿ4 5
ToInt32
ÿÿ5 <
(
ÿÿ< =
code
ÿÿ= A
)
ÿÿA B
;
ÿÿB C
_unitOfWork
ŸŸ 
.
ŸŸ 
Locality
ŸŸ  
.
ŸŸ  !
Update
ŸŸ! '
(
ŸŸ' (
	_locality
ŸŸ( 1
)
ŸŸ1 2
;
ŸŸ2 3
await
⁄⁄ 
_unitOfWork
⁄⁄ 
.
⁄⁄ 
Complete
⁄⁄ &
(
⁄⁄& '
)
⁄⁄' (
;
⁄⁄( )
var
›› 
_title
›› 
=
›› 
(
›› 
await
›› 
_unitOfWork
››  +
.
››+ ,
Title
››, 1
.
››1 2
Get
››2 5
(
››5 6
t
››6 7
=>
››8 :
t
››; <
.
››< =
TitleId
››= D
==
››E G
customer
››H P
.
››P Q
TitleId
››Q X
)
››X Y
)
››Y Z
!
››Z [
.
››[ \
Titles
››\ b
;
››b c
var
ﬁﬁ 
customername
ﬁﬁ 
=
ﬁﬁ 
string
ﬁﬁ %
.
ﬁﬁ% &
Concat
ﬁﬁ& ,
(
ﬁﬁ, -
_title
ﬁﬁ- 3
,
ﬁﬁ3 4
$str
ﬁﬁ5 8
,
ﬁﬁ8 9
customer
ﬁﬁ: B
.
ﬁﬁB C

OtherNames
ﬁﬁC M
,
ﬁﬁM N
$str
ﬁﬁO R
,
ﬁﬁR S
customer
ﬁﬁT \
.
ﬁﬁ\ ]
SurName
ﬁﬁ] d
)
ﬁﬁd e
.
ﬁﬁe f
Trim
ﬁﬁf j
(
ﬁﬁj k
)
ﬁﬁk l
;
ﬁﬁl m
var
‡‡  
registeredCustomer
‡‡ "
=
‡‡# $
new
‡‡% (4
&CustomerRegistrationSuccessResponseDto
‡‡) O
{
·· 
CustomerCode
‚‚ 
=
‚‚ 
customer
‚‚ '
.
‚‚' (
CustomerCode
‚‚( 4
,
‚‚4 5
FullName
„„ 
=
„„ 
customername
„„ '
,
„„' (
PhoneNumber
‰‰ 
=
‰‰ 
customer
‰‰ &
.
‰‰& '!
PrimaryMobileNumber
‰‰' :
,
‰‰: ;
}
ÂÂ 
;
ÂÂ 
return
ÁÁ 
new
ÁÁ -
CustomerRegistrationResponseDto
ÁÁ 6
{
ÁÁ7 8
	IsSuccess
ÁÁ9 B
=
ÁÁC D
true
ÁÁE I
,
ÁÁI J
SuccessResponse
ÁÁK Z
=
ÁÁ[ \ 
registeredCustomer
ÁÁ] o
}
ÁÁp q
;
ÁÁq r
}
ËË 	
public
ÍÍ 
async
ÍÍ 
Task
ÍÍ 
<
ÍÍ -
CustomerRegistrationResponseDto
ÍÍ 9
>
ÍÍ9 :
CreateCustomer
ÍÍ; I
(
ÍÍI J'
MultiOwnershipCustomerDto
ÍÍJ c
values
ÍÍd j
)
ÍÍj k
{
ÎÎ 	
string
ÏÏ 
	_imageOne
ÏÏ 
=
ÏÏ 
string
ÏÏ %
.
ÏÏ% &
Empty
ÏÏ& +
;
ÏÏ+ ,
string
ÏÏ- 3
	_imageTwo
ÏÏ4 =
=
ÏÏ> ?
string
ÏÏ@ F
.
ÏÏF G
Empty
ÏÏG L
;
ÏÏL M
string
ÏÏN T
_imageThree
ÏÏU `
=
ÏÏa b
string
ÏÏc i
.
ÏÏi j
Empty
ÏÏj o
;
ÏÏo p
string
ÏÏq w

_imageFourÏÏx Ç
=ÏÏÉ Ñ
stringÏÏÖ ã
.ÏÏã å
EmptyÏÏå ë
;ÏÏë í
stringÏÏì ô

_imageFiveÏÏö §
=ÏÏ• ¶
stringÏÏß ≠
.ÏÏ≠ Æ
EmptyÏÏÆ ≥
;ÏÏ≥ ¥
string
ÌÌ 

c_imageOne
ÌÌ 
=
ÌÌ 
string
ÌÌ  &
.
ÌÌ& '
Empty
ÌÌ' ,
;
ÌÌ, -
string
ÌÌ. 4

c_imageTwo
ÌÌ5 ?
=
ÌÌ@ A
string
ÌÌB H
.
ÌÌH I
Empty
ÌÌI N
;
ÌÌN O
int
ÓÓ 

imageCount
ÓÓ 
;
ÓÓ 

imageCount
 
=
 
values
 
.
  "
IdentificationImages
  4
!
4 5
.
5 6
Count
6 ;
(
; <
)
< =
;
= >
switch
ÒÒ 
(
ÒÒ 

imageCount
ÒÒ 
)
ÒÒ 
{
ÚÚ 
case
ÛÛ 
$num
ÛÛ 
:
ÛÛ 
	_imageOne
ÙÙ 
=
ÙÙ 
values
ÙÙ  &
.
ÙÙ& '"
IdentificationImages
ÙÙ' ;
!
ÙÙ; <
[
ÙÙ< =
$num
ÙÙ= >
]
ÙÙ> ?
;
ÙÙ? @
break
ıı 
;
ıı 
case
˜˜ 
$num
˜˜ 
:
˜˜ 
	_imageOne
¯¯ 
=
¯¯ 
values
¯¯  &
.
¯¯& '"
IdentificationImages
¯¯' ;
!
¯¯; <
[
¯¯< =
$num
¯¯= >
]
¯¯> ?
;
¯¯? @
	_imageTwo
˘˘ 
=
˘˘ 
values
˘˘  &
.
˘˘& '"
IdentificationImages
˘˘' ;
!
˘˘; <
[
˘˘< =
$num
˘˘= >
]
˘˘> ?
;
˘˘? @
break
˙˙ 
;
˙˙ 
case
¸¸ 
$num
¸¸ 
:
¸¸ 
	_imageOne
˝˝ 
=
˝˝ 
values
˝˝  &
.
˝˝& '"
IdentificationImages
˝˝' ;
!
˝˝; <
[
˝˝< =
$num
˝˝= >
]
˝˝> ?
;
˝˝? @
	_imageTwo
˛˛ 
=
˛˛ 
values
˛˛  &
.
˛˛& '"
IdentificationImages
˛˛' ;
!
˛˛; <
[
˛˛< =
$num
˛˛= >
]
˛˛> ?
;
˛˛? @
_imageThree
ˇˇ 
=
ˇˇ  !
values
ˇˇ" (
.
ˇˇ( )"
IdentificationImages
ˇˇ) =
!
ˇˇ= >
[
ˇˇ> ?
$num
ˇˇ? @
]
ˇˇ@ A
;
ˇˇA B
break
ÄÄ 
;
ÄÄ 
case
ÇÇ 
$num
ÇÇ 
:
ÇÇ 
	_imageOne
ÉÉ 
=
ÉÉ 
values
ÉÉ  &
.
ÉÉ& '"
IdentificationImages
ÉÉ' ;
!
ÉÉ; <
[
ÉÉ< =
$num
ÉÉ= >
]
ÉÉ> ?
;
ÉÉ? @
	_imageTwo
ÑÑ 
=
ÑÑ 
values
ÑÑ  &
.
ÑÑ& '"
IdentificationImages
ÑÑ' ;
!
ÑÑ; <
[
ÑÑ< =
$num
ÑÑ= >
]
ÑÑ> ?
;
ÑÑ? @
_imageThree
ÖÖ 
=
ÖÖ  !
values
ÖÖ" (
.
ÖÖ( )"
IdentificationImages
ÖÖ) =
!
ÖÖ= >
[
ÖÖ> ?
$num
ÖÖ? @
]
ÖÖ@ A
;
ÖÖA B

_imageFour
ÜÜ 
=
ÜÜ  
values
ÜÜ! '
.
ÜÜ' ("
IdentificationImages
ÜÜ( <
!
ÜÜ< =
[
ÜÜ= >
$num
ÜÜ> ?
]
ÜÜ? @
;
ÜÜ@ A
break
áá 
;
áá 
case
ââ 
$num
ââ 
:
ââ 
	_imageOne
ää 
=
ää 
values
ää  &
.
ää& '"
IdentificationImages
ää' ;
!
ää; <
[
ää< =
$num
ää= >
]
ää> ?
;
ää? @
	_imageTwo
ãã 
=
ãã 
values
ãã  &
.
ãã& '"
IdentificationImages
ãã' ;
!
ãã; <
[
ãã< =
$num
ãã= >
]
ãã> ?
;
ãã? @
_imageThree
åå 
=
åå  !
values
åå" (
.
åå( )"
IdentificationImages
åå) =
!
åå= >
[
åå> ?
$num
åå? @
]
åå@ A
;
ååA B

_imageFour
çç 
=
çç  
values
çç! '
.
çç' ("
IdentificationImages
çç( <
!
çç< =
[
çç= >
$num
çç> ?
]
çç? @
;
çç@ A

_imageFive
éé 
=
éé  
values
éé! '
.
éé' ("
IdentificationImages
éé( <
!
éé< =
[
éé= >
$num
éé> ?
]
éé? @
;
éé@ A
break
èè 
;
èè 
}
êê 

imageCount
ìì 
=
ìì 
values
ìì 
.
ìì  
NonResident
ìì  +
!
ìì+ ,
.
ìì, -0
"ContactPerson_IdentificationImages
ìì- O
!
ììO P
.
ììP Q
Count
ììQ V
(
ììV W
)
ììW X
;
ììX Y
switch
îî 
(
îî 

imageCount
îî 
)
îî 
{
ïï 
case
ññ 
$num
ññ 
:
ññ 

c_imageOne
óó 
=
óó  
values
óó! '
.
óó' ("
IdentificationImages
óó( <
!
óó< =
[
óó= >
$num
óó> ?
]
óó? @
;
óó@ A
break
òò 
;
òò 
case
öö 
$num
öö 
:
öö 

c_imageOne
õõ 
=
õõ  
values
õõ! '
.
õõ' ("
IdentificationImages
õõ( <
!
õõ< =
[
õõ= >
$num
õõ> ?
]
õõ? @
;
õõ@ A

c_imageTwo
úú 
=
úú  
values
úú! '
.
úú' ("
IdentificationImages
úú( <
!
úú< =
[
úú= >
$num
úú> ?
]
úú? @
;
úú@ A
break
ùù 
;
ùù 
}
ûû 
CustomerMaster
†† 
customer
†† #
=
††$ %
await
††& +
CustomerMaster
††, :
.
††: ;
CreateJointAsync
††; K
(
°° 
customerMasterId
¢¢ $
:
¢¢$ %
values
¢¢& ,
.
¢¢, -
CustomerMasterId
¢¢- =
,
¢¢= >
customerTypeId
££ "
:
££" #
values
££$ *
.
££* +
CustomerTypeId
££+ 9
,
££9 :
residentTypeId
§§ "
:
§§" #
values
§§$ *
.
§§* +
ResidentTypeId
§§+ 9
,
§§9 :

localityId
•• 
:
•• 
values
••  &
.
••& '

LocalityId
••' 1
,
••1 2
customerCode
¶¶  
:
¶¶  !
values
¶¶" (
.
¶¶( )
CustomerCode
¶¶) 5
!
¶¶5 6
,
¶¶6 7
titleId
ßß 
:
ßß 
values
ßß #
.
ßß# $
TitleId
ßß$ +
,
ßß+ ,
surName
®® 
:
®® 
values
®® #
.
®®# $
SurName
®®$ +
,
®®+ ,

otherNames
©© 
:
©© 
values
©©  &
.
©©& '

OtherNames
©©' 1
,
©©1 2
dateOfBirth
™™ 
:
™™  
values
™™! '
.
™™' (
DateOfBirth
™™( 3
,
™™3 4
	tinNumber
´´ 
:
´´ 
values
´´ %
.
´´% &
	TinNumber
´´& /
!
´´/ 0
,
´´0 1
picture
¨¨ 
:
¨¨ 
values
¨¨ #
.
¨¨# $
Picture
¨¨$ +
!
¨¨+ ,
,
¨¨, -
genderId
≠≠ 
:
≠≠ 
values
≠≠ $
.
≠≠$ %
GenderId
≠≠% -
,
≠≠- .
nationalityId
ÆÆ !
:
ÆÆ! "
values
ÆÆ# )
.
ÆÆ) *
NationalityId
ÆÆ* 7
,
ÆÆ7 8
postalAddress
ØØ !
:
ØØ! "
values
ØØ# )
.
ØØ) *
PostalAddress
ØØ* 7
!
ØØ7 8
,
ØØ8 9 
residentialAddress
∞∞ &
:
∞∞& '
values
∞∞( .
.
∞∞. / 
ResidentialAddress
∞∞/ A
!
∞∞A B
,
∞∞B C
digitalAddress
±± "
:
±±" #
values
±±$ *
.
±±* +
DigitalAddress
±±+ 9
!
±±9 :
,
±±: ;!
primaryMobileNumber
≤≤ '
:
≤≤' (
values
≤≤) /
.
≤≤/ 0!
PrimaryMobileNumber
≤≤0 C
!
≤≤C D
,
≤≤D E#
secondaryMobileNumber
≥≥ )
:
≥≥) *
values
≥≥+ 1
.
≥≥1 2#
SecondaryMobileNumber
≥≥2 G
!
≥≥G H
,
≥≥H I
officeNumber
¥¥  
:
¥¥  !
values
¥¥" (
.
¥¥( )
OfficeNumber
¥¥) 5
!
¥¥5 6
,
¥¥6 7
whatsAppNumber
µµ "
:
µµ" #
values
µµ$ *
.
µµ* +
WhatsAppNumber
µµ+ 9
!
µµ9 :
,
µµ: ;
emailAddress
∂∂  
:
∂∂  !
values
∂∂" (
.
∂∂( )
EmailAddress
∂∂) 5
,
∂∂5 6"
residentPermitNumber
∑∑ (
:
∑∑( )
values
∑∑* 0
.
∑∑0 1

Expatriate
∑∑1 ;
!
∑∑; <
.
∑∑< ="
ResidentPermitNumber
∑∑= Q
!
∑∑Q R
,
∑∑R S&
residentPermitDateIssued
∏∏ ,
:
∏∏, -
values
∏∏. 4
.
∏∏4 5

Expatriate
∏∏5 ?
!
∏∏? @
.
∏∏@ A&
ResidentPermitDateIssued
∏∏A Y
!
∏∏Y Z
,
∏∏Z [&
residentPermitExpiryDate
ππ ,
:
ππ, -
values
ππ. 4
.
ππ4 5

Expatriate
ππ5 ?
!
ππ? @
.
ππ@ A&
ResidentPermitExpiryDate
ππA Y
!
ππY Z
,
ππZ [
socialMediaTypeId
∫∫ %
:
∫∫% &
values
∫∫' -
.
∫∫- .
SocialMediaTypeId
∫∫. ?
,
∫∫? @ 
socialMediaAccount
ªª &
:
ªª& '
values
ªª( .
.
ªª. / 
SocialMediaAccount
ªª/ A
!
ªªA B
,
ªªB C"
identificationTypeId
ºº (
:
ºº( )
values
ºº* 0
.
ºº0 1"
IdentificationTypeId
ºº1 E
,
ººE F&
identificationTypeNumber
ΩΩ ,
:
ΩΩ, -
values
ΩΩ. 4
.
ΩΩ4 5&
IdentificationTypeNumber
ΩΩ5 M
!
ΩΩM N
,
ΩΩN O(
identificationTypeImageOne
ææ .
:
ææ. /
	_imageOne
ææ0 9
,
ææ9 :(
identificationTypeImageTwo
øø .
:
øø. /
	_imageTwo
øø0 9
,
øø9 :*
identificationTypeImageThree
¿¿ 0
:
¿¿0 1
_imageThree
¿¿2 =
,
¿¿= >)
identificationTypeImageFour
¡¡ /
:
¡¡/ 0

_imageFour
¡¡1 ;
,
¡¡; <)
identificationTypeImageFive
¬¬ /
:
¬¬/ 0

_imageFive
¬¬1 ;
,
¬¬; <
comments
√√ 
:
√√ 
values
√√ $
.
√√$ %
Comments
√√% -
!
√√- .
,
√√. /
interestExpressed
ƒƒ %
:
ƒƒ% &
string
ƒƒ' -
.
ƒƒ- .
Empty
ƒƒ. 3
,
ƒƒ3 4
debtorStatus
≈≈  
:
≈≈  !
$num
≈≈" #
,
≈≈# $

parentCode
∆∆ 
:
∆∆ 
string
∆∆  &
.
∆∆& '
Empty
∆∆' ,
,
∆∆, -$
contactPerson_FullName
«« *
:
««* +
values
««, 2
.
««2 3
NonResident
««3 >
.
««> ?$
ContactPerson_FullName
««? U
!
««U V
,
««V W'
contactPerson_PhoneNumber
»» -
:
»»- .
values
»»/ 5
.
»»5 6
NonResident
»»6 A
.
»»A B'
ContactPerson_PhoneNumber
»»B [
!
»»[ \
,
»»\ ](
contactPerson_EmailAddress
…… .
:
……. /
values
……0 6
.
……6 7
NonResident
……7 B
.
……B C(
ContactPerson_EmailAddress
……C ]
!
……] ^
,
……^ _#
contactPerson_Address
   )
:
  ) *
values
  + 1
.
  1 2
NonResident
  2 =
.
  = >#
ContactPerson_Address
  > S
!
  S T
,
  T U0
"contactPerson_IdentificationTypeId
ÀÀ 6
:
ÀÀ6 7
values
ÀÀ8 >
.
ÀÀ> ?
NonResident
ÀÀ? J
.
ÀÀJ K0
"ContactPerson_IdentificationTypeId
ÀÀK m
,
ÀÀm n4
&contactPerson_IdentificationTypeNumber
ÃÃ :
:
ÃÃ: ;
values
ÃÃ< B
.
ÃÃB C
NonResident
ÃÃC N
.
ÃÃN O4
&ContactPerson_IdentificationTypeNumber
ÃÃO u
!
ÃÃu v
,
ÃÃv w6
(contactPerson_IdentificationTypeImageOne
ÕÕ <
:
ÕÕ< =

c_imageOne
ÕÕ> H
,
ÕÕH I6
(contactPerson_IdentificationTypeImageTwo
ŒŒ <
:
ŒŒ< =

c_imageTwo
ŒŒ> H
,
ŒŒH I
	isDeleted
œœ 
:
œœ 
false
œœ $
,
œœ$ %
	isPrimary
–– 
:
–– 
true
–– #
,
––# $
maritalStatus
—— !
:
——! "
values
——# )
.
——) *
MaritalStatus
——* 7
!
——7 8
,
——8 9
dateOfMarriage
““ "
:
““" #
values
““$ *
.
““* +
DateOfMarriage
““+ 9
!
““9 :
,
““: ;
_domainService
”” "
)
‘‘ 
;
‘‘ 
customer
÷÷ 
.
÷÷ 
	CreatedBy
÷÷ 
=
÷÷  
values
÷÷! '
.
÷÷' (
	CreatedBy
÷÷( 1
;
÷÷1 2
customer
◊◊ 
.
◊◊ 
	CreatedOn
◊◊ 
=
◊◊  
DateTime
◊◊! )
.
◊◊) *
UtcNow
◊◊* 0
;
◊◊0 1
customer
ÿÿ 
.
ÿÿ 
DebtorStatus
ÿÿ !
=
ÿÿ" #
$num
ÿÿ$ %
;
ÿÿ% &
List
⁄⁄ 
<
⁄⁄ 
CustomerMaster
⁄⁄ 
>
⁄⁄  
jointCustomers
⁄⁄! /
=
⁄⁄0 1
new
⁄⁄2 5
List
⁄⁄6 :
<
⁄⁄: ;
CustomerMaster
⁄⁄; I
>
⁄⁄I J
{
€€ 
customer
‹‹ 
}
›› 
;
›› 
string
ﬂﬂ 
co_imageOne
ﬂﬂ 
=
ﬂﬂ  
string
ﬂﬂ! '
.
ﬂﬂ' (
Empty
ﬂﬂ( -
;
ﬂﬂ- .
string
ﬂﬂ/ 5
co_imageTwo
ﬂﬂ6 A
=
ﬂﬂB C
string
ﬂﬂD J
.
ﬂﬂJ K
Empty
ﬂﬂK P
;
ﬂﬂP Q
int
‡‡ 
co_imageCount
‡‡ 
;
‡‡ 
int
‰‰ 
count
‰‰ 
=
‰‰ 
$num
‰‰ 
;
‰‰ 
foreach
ÂÂ 
(
ÂÂ 
var
ÂÂ 
value
ÂÂ 
in
ÂÂ !
values
ÂÂ" (
.
ÂÂ( )
	Dependent
ÂÂ) 2
!
ÂÂ2 3
)
ÂÂ3 4
{
ÊÊ 
co_imageCount
ÁÁ 
=
ÁÁ 
value
ÁÁ  %
.
ÁÁ% &"
IdentificationImages
ÁÁ& :
!
ÁÁ: ;
.
ÁÁ; <
Count
ÁÁ< A
(
ÁÁA B
)
ÁÁB C
;
ÁÁC D
switch
ËË 
(
ËË 
co_imageCount
ËË %
)
ËË% &
{
ÈÈ 
case
ÍÍ 
$num
ÍÍ 
:
ÍÍ 
co_imageOne
ÎÎ #
=
ÎÎ$ %
value
ÎÎ& +
.
ÎÎ+ ,"
IdentificationImages
ÎÎ, @
!
ÎÎ@ A
[
ÎÎA B
$num
ÎÎB C
]
ÎÎC D
;
ÎÎD E
break
ÏÏ 
;
ÏÏ 
case
ÓÓ 
$num
ÓÓ 
:
ÓÓ 
co_imageOne
ÔÔ #
=
ÔÔ$ %
value
ÔÔ& +
.
ÔÔ+ ,"
IdentificationImages
ÔÔ, @
!
ÔÔ@ A
[
ÔÔA B
$num
ÔÔB C
]
ÔÔC D
;
ÔÔD E
co_imageTwo
 #
=
$ %
value
& +
.
+ ,"
IdentificationImages
, @
!
@ A
[
A B
$num
B C
]
C D
;
D E
break
ÒÒ 
;
ÒÒ 
}
ÚÚ 
count
ÙÙ 
++
ÙÙ 
;
ÙÙ 
CustomerMaster
ˆˆ 
co_customer
ˆˆ *
=
ˆˆ+ ,
await
ˆˆ- 2
CustomerMaster
ˆˆ3 A
.
ˆˆA B
CreateJointAsync
ˆˆB R
(
˜˜ 
customerMasterId
¯¯ (
:
¯¯( )
values
¯¯* 0
.
¯¯0 1
CustomerMasterId
¯¯1 A
,
¯¯A B
customerTypeId
˘˘ &
:
˘˘& '
values
˘˘( .
.
˘˘. /
CustomerTypeId
˘˘/ =
,
˘˘= >
residentTypeId
˙˙ &
:
˙˙& '
values
˙˙( .
.
˙˙. /
ResidentTypeId
˙˙/ =
,
˙˙= >

localityId
˚˚ "
:
˚˚" #
values
˚˚$ *
.
˚˚* +

LocalityId
˚˚+ 5
,
˚˚5 6
customerCode
¸¸ $
:
¸¸$ %
string
¸¸& ,
.
¸¸, -
Empty
¸¸- 2
,
¸¸2 3
titleId
˝˝ 
:
˝˝  
value
˝˝! &
.
˝˝& '
TitleId
˝˝' .
,
˝˝. /
surName
˛˛ 
:
˛˛  
value
˛˛! &
.
˛˛& '
SurName
˛˛' .
,
˛˛. /

otherNames
ˇˇ "
:
ˇˇ" #
value
ˇˇ$ )
.
ˇˇ) *

OtherNames
ˇˇ* 4
,
ˇˇ4 5
dateOfBirth
ÄÄ #
:
ÄÄ# $
value
ÄÄ% *
.
ÄÄ* +
DateOfBirth
ÄÄ+ 6
,
ÄÄ6 7
	tinNumber
ÅÅ !
:
ÅÅ! "
value
ÅÅ# (
.
ÅÅ( )
	TinNumber
ÅÅ) 2
!
ÅÅ2 3
,
ÅÅ3 4
picture
ÇÇ 
:
ÇÇ  
value
ÇÇ! &
.
ÇÇ& '
Picture
ÇÇ' .
!
ÇÇ. /
,
ÇÇ/ 0
genderId
ÉÉ  
:
ÉÉ  !
value
ÉÉ" '
.
ÉÉ' (
GenderId
ÉÉ( 0
,
ÉÉ0 1
nationalityId
ÑÑ %
:
ÑÑ% &
value
ÑÑ' ,
.
ÑÑ, -
NationalityId
ÑÑ- :
,
ÑÑ: ;
postalAddress
ÖÖ %
:
ÖÖ% &
value
ÖÖ' ,
.
ÖÖ, -
PostalAddress
ÖÖ- :
!
ÖÖ: ;
,
ÖÖ; < 
residentialAddress
ÜÜ *
:
ÜÜ* +
value
ÜÜ, 1
.
ÜÜ1 2 
ResidentialAddress
ÜÜ2 D
!
ÜÜD E
,
ÜÜE F
digitalAddress
áá &
:
áá& '
value
áá( -
.
áá- .
DigitalAddress
áá. <
!
áá< =
,
áá= >!
primaryMobileNumber
àà +
:
àà+ ,
value
àà- 2
.
àà2 3!
PrimaryMobileNumber
àà3 F
!
ààF G
,
ààG H#
secondaryMobileNumber
ââ -
:
ââ- .
value
ââ/ 4
.
ââ4 5#
SecondaryMobileNumber
ââ5 J
!
ââJ K
,
ââK L
officeNumber
ää $
:
ää$ %
value
ää& +
.
ää+ ,
OfficeNumber
ää, 8
!
ää8 9
,
ää9 :
whatsAppNumber
ãã &
:
ãã& '
value
ãã( -
.
ãã- .
WhatsAppNumber
ãã. <
!
ãã< =
,
ãã= >
emailAddress
åå $
:
åå$ %
value
åå& +
.
åå+ ,
EmailAddress
åå, 8
,
åå8 9"
residentPermitNumber
çç ,
:
çç, -
values
çç. 4
.
çç4 5

Expatriate
çç5 ?
!
çç? @
.
çç@ A"
ResidentPermitNumber
ççA U
!
ççU V
,
ççV W&
residentPermitDateIssued
éé 0
:
éé0 1
values
éé2 8
.
éé8 9

Expatriate
éé9 C
!
ééC D
.
ééD E&
ResidentPermitDateIssued
ééE ]
!
éé] ^
,
éé^ _&
residentPermitExpiryDate
èè 0
:
èè0 1
values
èè2 8
.
èè8 9

Expatriate
èè9 C
!
èèC D
.
èèD E&
ResidentPermitExpiryDate
èèE ]
!
èè] ^
,
èè^ _
socialMediaTypeId
êê )
:
êê) *
value
êê+ 0
.
êê0 1
SocialMediaTypeId
êê1 B
,
êêB C 
socialMediaAccount
ëë *
:
ëë* +
value
ëë, 1
.
ëë1 2 
SocialMediaAccount
ëë2 D
!
ëëD E
,
ëëE F"
identificationTypeId
íí ,
:
íí, -
value
íí. 3
.
íí3 4"
IdentificationTypeId
íí4 H
,
ííH I&
identificationTypeNumber
ìì 0
:
ìì0 1
value
ìì2 7
.
ìì7 8&
IdentificationTypeNumber
ìì8 P
!
ììP Q
,
ììQ R(
identificationTypeImageOne
îî 2
:
îî2 3
co_imageOne
îî4 ?
,
îî? @(
identificationTypeImageTwo
ïï 2
:
ïï2 3
co_imageTwo
ïï4 ?
,
ïï? @*
identificationTypeImageThree
ññ 4
:
ññ4 5
_imageThree
ññ6 A
,
ññA B)
identificationTypeImageFour
óó 3
:
óó3 4

_imageFour
óó5 ?
,
óó? @)
identificationTypeImageFive
òò 3
:
òò3 4

_imageFive
òò5 ?
,
òò? @
comments
ôô  
:
ôô  !
values
ôô" (
.
ôô( )
Comments
ôô) 1
!
ôô1 2
,
ôô2 3
interestExpressed
öö )
:
öö) *
string
öö+ 1
.
öö1 2
Empty
öö2 7
,
öö7 8
debtorStatus
õõ $
:
õõ$ %
$num
õõ& '
,
õõ' (

parentCode
úú "
:
úú" #
customer
úú$ ,
.
úú, -
CustomerCode
úú- 9
!
úú9 :
,
úú: ;$
contactPerson_FullName
ùù .
:
ùù. /
values
ùù0 6
.
ùù6 7
NonResident
ùù7 B
.
ùùB C$
ContactPerson_FullName
ùùC Y
!
ùùY Z
,
ùùZ ['
contactPerson_PhoneNumber
ûû 1
:
ûû1 2
values
ûû3 9
.
ûû9 :
NonResident
ûû: E
.
ûûE F'
ContactPerson_PhoneNumber
ûûF _
!
ûû_ `
,
ûû` a(
contactPerson_EmailAddress
üü 2
:
üü2 3
values
üü4 :
.
üü: ;
NonResident
üü; F
.
üüF G(
ContactPerson_EmailAddress
üüG a
!
üüa b
,
üüb c#
contactPerson_Address
†† -
:
††- .
values
††/ 5
.
††5 6
NonResident
††6 A
.
††A B#
ContactPerson_Address
††B W
!
††W X
,
††X Y0
"contactPerson_IdentificationTypeId
°° :
:
°°: ;
values
°°< B
.
°°B C
NonResident
°°C N
.
°°N O0
"ContactPerson_IdentificationTypeId
°°O q
,
°°q r4
&contactPerson_IdentificationTypeNumber
¢¢ >
:
¢¢> ?
values
¢¢@ F
.
¢¢F G
NonResident
¢¢G R
.
¢¢R S4
&ContactPerson_IdentificationTypeNumber
¢¢S y
!
¢¢y z
,
¢¢z {6
(contactPerson_IdentificationTypeImageOne
££ @
:
££@ A

c_imageOne
££B L
,
££L M6
(contactPerson_IdentificationTypeImageTwo
§§ @
:
§§@ A

c_imageTwo
§§B L
,
§§L M
	isDeleted
•• !
:
••! "
false
••# (
,
••( )
	isPrimary
¶¶ !
:
¶¶! "
false
¶¶# (
,
¶¶( )
maritalStatus
ßß %
:
ßß% &
values
ßß' -
.
ßß- .
MaritalStatus
ßß. ;
!
ßß; <
,
ßß< =
dateOfMarriage
®® &
:
®®& '
values
®®( .
.
®®. /
DateOfMarriage
®®/ =
!
®®= >
,
®®> ?
_domainService
©© &
)
™™ 
;
™™ 
co_customer
¨¨ 
.
¨¨ 
CustomerCode
¨¨ (
=
¨¨) *
$"
¨¨+ -
{
¨¨- .
customer
¨¨. 6
.
¨¨6 7
CustomerCode
¨¨7 C
!
¨¨C D
}
¨¨D E
$str
¨¨E F
{
¨¨F G
count
¨¨G L
.
¨¨L M
ToString
¨¨M U
(
¨¨U V
$str
¨¨V Z
)
¨¨Z [
}
¨¨[ \
"
¨¨\ ]
;
¨¨] ^
co_customer
≠≠ 
.
≠≠ 
	CreatedBy
≠≠ %
=
≠≠& '
values
≠≠( .
.
≠≠. /
	CreatedBy
≠≠/ 8
;
≠≠8 9
co_customer
ÆÆ 
.
ÆÆ 
	CreatedOn
ÆÆ %
=
ÆÆ& '
DateTime
ÆÆ( 0
.
ÆÆ0 1
UtcNow
ÆÆ1 7
;
ÆÆ7 8
co_customer
ØØ 
.
ØØ 
DebtorStatus
ØØ (
=
ØØ) *
$num
ØØ+ ,
;
ØØ, -
jointCustomers
±± 
.
±± 
Add
±± "
(
±±" #
co_customer
±±# .
)
±±. /
;
±±/ 0
}
≤≤ 
_unitOfWork
¥¥ 
.
¥¥ 
CustomerMaster
¥¥ &
.
¥¥& '
InsertRange
¥¥' 2
(
¥¥2 3
jointCustomers
¥¥3 A
)
¥¥A B
;
¥¥B C
var
∑∑ 
	_locality
∑∑ 
=
∑∑ 
await
∑∑ !
_unitOfWork
∑∑" -
.
∑∑- .
Locality
∑∑. 6
.
∑∑6 7
Get
∑∑7 :
(
∑∑: ;
values
∑∑; A
.
∑∑A B

LocalityId
∑∑B L
)
∑∑L M
;
∑∑M N
var
∏∏ 
code
∏∏ 
=
∏∏ 
customer
∏∏ 
.
∏∏  
CustomerCode
∏∏  ,
!
∏∏, -
.
∏∏- .
	Substring
∏∏. 7
(
∏∏7 8
Math
∏∏8 <
.
∏∏< =
Max
∏∏= @
(
∏∏@ A
$num
∏∏A B
,
∏∏B C
customer
∏∏D L
.
∏∏L M
CustomerCode
∏∏M Y
!
∏∏Y Z
.
∏∏Z [
Length
∏∏[ a
-
∏∏b c
$num
∏∏d e
)
∏∏e f
)
∏∏f g
;
∏∏g h
	_locality
ππ 
!
ππ 
.
ππ !
CustomerCodeCounter
ππ *
=
ππ+ ,
Convert
ππ- 4
.
ππ4 5
ToInt32
ππ5 <
(
ππ< =
code
ππ= A
)
ππA B
;
ππB C
_unitOfWork
∫∫ 
.
∫∫ 
Locality
∫∫  
.
∫∫  !
Update
∫∫! '
(
∫∫' (
	_locality
∫∫( 1
)
∫∫1 2
;
∫∫2 3
await
ªª 
_unitOfWork
ªª 
.
ªª 
Complete
ªª &
(
ªª& '
)
ªª' (
;
ªª( )
var
ææ 
_title
ææ 
=
ææ 
(
ææ 
await
ææ 
_unitOfWork
ææ  +
.
ææ+ ,
Title
ææ, 1
.
ææ1 2
Get
ææ2 5
(
ææ5 6
t
ææ6 7
=>
ææ8 :
t
ææ; <
.
ææ< =
TitleId
ææ= D
==
ææE G
customer
ææH P
.
ææP Q
TitleId
ææQ X
)
ææX Y
)
ææY Z
!
ææZ [
.
ææ[ \
Titles
ææ\ b
;
ææb c
var
øø 
customername
øø 
=
øø 
string
øø %
.
øø% &
Concat
øø& ,
(
øø, -
_title
øø- 3
,
øø3 4
$str
øø5 8
,
øø8 9
customer
øø: B
.
øøB C

OtherNames
øøC M
,
øøM N
$str
øøO R
,
øøR S
customer
øøT \
.
øø\ ]
SurName
øø] d
)
øød e
.
øøe f
Trim
øøf j
(
øøj k
)
øøk l
;
øøl m
var
¡¡  
registeredCustomer
¡¡ "
=
¡¡# $
new
¡¡% (4
&CustomerRegistrationSuccessResponseDto
¡¡) O
{
¬¬ 
CustomerCode
√√ 
=
√√ 
customer
√√ '
.
√√' (
CustomerCode
√√( 4
,
√√4 5
FullName
ƒƒ 
=
ƒƒ 
customername
ƒƒ '
,
ƒƒ' (
PhoneNumber
≈≈ 
=
≈≈ 
customer
≈≈ &
.
≈≈& '!
PrimaryMobileNumber
≈≈' :
,
≈≈: ;
}
∆∆ 
;
∆∆ 
return
»» 
new
»» -
CustomerRegistrationResponseDto
»» 6
{
»»7 8
	IsSuccess
»»9 B
=
»»C D
true
»»E I
,
»»I J
SuccessResponse
»»K Z
=
»»[ \ 
registeredCustomer
»»] o
}
»»p q
;
»»q r
}
…… 	
public
ÕÕ 
async
ÕÕ 
Task
ÕÕ 
<
ÕÕ 
int
ÕÕ 
>
ÕÕ !
DeleteCustomerAsync
ÕÕ 2
(
ÕÕ2 3&
DeleteCustomerRequestDto
ÕÕ3 K
values
ÕÕL R
)
ÕÕR S
{
ŒŒ 	
var
—— 
customer
—— 
=
—— 
await
——  
_unitOfWork
——! ,
.
——, -
CustomerMaster
——- ;
.
——; <
Get
——< ?
(
——? @
c
——@ A
=>
——B D
c
——E F
.
——F G
CustomerCode
——G S
==
——T V
values
——W ]
.
——] ^
customerCode
——^ j
)
——j k
;
——k l
if
““ 
(
““ 
customer
““ 
is
““ 
null
““ 
)
““  
{
”” 
return
‘‘ 
$num
‘‘ 
;
‘‘ 
}
’’ 
customer
◊◊ 
!
◊◊ 
.
◊◊ 
	IsDeleted
◊◊ 
=
◊◊  !
true
◊◊" &
;
◊◊& '
customer
ÿÿ 
.
ÿÿ 
	DeletedBy
ÿÿ 
=
ÿÿ  
values
ÿÿ! '
.
ÿÿ' (
	deletedBy
ÿÿ( 1
;
ÿÿ1 2
customer
ŸŸ 
.
ŸŸ 
	DeletedOn
ŸŸ 
=
ŸŸ  
DateTime
ŸŸ! )
.
ŸŸ) *
UtcNow
ŸŸ* 0
;
ŸŸ0 1
_unitOfWork
€€ 
.
€€ 
CustomerMaster
€€ &
.
€€& '
Update
€€' -
(
€€- .
customer
€€. 6
)
€€6 7
;
€€7 8
var
›› 
co_customers
›› 
=
›› 
await
›› $
_unitOfWork
››% 0
.
››0 1
CustomerMaster
››1 ?
.
››? @
GetAll
››@ F
(
››F G
c
››G H
=>
››I K
c
››L M
.
››M N

ParentCode
››N X
==
››Y [
values
››\ b
.
››b c
customerCode
››c o
)
››o p
;
››p q
if
ﬁﬁ 
(
ﬁﬁ 
co_customers
ﬁﬁ 
is
ﬁﬁ 
not
ﬁﬁ "
null
ﬁﬁ# '
)
ﬁﬁ' (
{
ﬂﬂ 
foreach
‡‡ 
(
‡‡ 
var
‡‡ 
co_customer
‡‡ (
in
‡‡) +
co_customers
‡‡, 8
)
‡‡8 9
{
·· 
co_customer
‚‚ 
!
‚‚  
.
‚‚  !
	IsDeleted
‚‚! *
=
‚‚+ ,
true
‚‚- 1
;
‚‚1 2
co_customer
„„ 
.
„„  
	DeletedBy
„„  )
=
„„* +
values
„„, 2
.
„„2 3
	deletedBy
„„3 <
;
„„< =
co_customer
‰‰ 
.
‰‰  
	DeletedOn
‰‰  )
=
‰‰* +
DateTime
‰‰, 4
.
‰‰4 5
UtcNow
‰‰5 ;
;
‰‰; <
_unitOfWork
ÊÊ 
.
ÊÊ  
CustomerMaster
ÊÊ  .
.
ÊÊ. /
Update
ÊÊ/ 5
(
ÊÊ5 6
co_customer
ÊÊ6 A
)
ÊÊA B
;
ÊÊB C
}
ÁÁ 
}
ËË 
await
ÍÍ 
_unitOfWork
ÍÍ 
.
ÍÍ 
Complete
ÍÍ &
(
ÍÍ& '
)
ÍÍ' (
;
ÍÍ( )
return
ÏÏ 
$num
ÏÏ 
;
ÏÏ 
}
ÌÌ 	
}
 
}ÒÒ π¨
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Customer/CustomerMasterReadService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
UseCases& .
.. /

Management/ 9
.9 :
Customer: B
{ 
public 

partial 
class !
CustomerMasterService .
:/ 0"
ICustomerMasterService1 G
{ 
public 
async 
Task 
< 
CustomerMasterDto +
>+ ,
GetCustomer- 8
(8 9
string9 ?
customerCode@ L
)L M
{ 	
var 
result 
= 
await 
_unitOfWork *
.* +
CustomerMaster+ 9
.9 :
Get: =
(= >
cm> @
=>A C
cmD F
.F G
CustomerCodeG S
==T V
customerCodeW c
)c d
;d e
var 
response 
= 
_mapper "
." #
Map# &
<& '
CustomerMasterDto' 8
>8 9
(9 :
result: @
)@ A
;A B
return 
response 
; 
} 	
public 
async 
Task 
< *
ProspectiveCustomerResponseDto 8
>8 9)
GetProspectiveCustomerDetails: W
(W X
stringX ^
customerCode_ k
)k l
{ 	
var 
customer 
= 
await  
_unitOfWork! ,
., -
CustomerMaster- ;
.; <
Get< ?
(? @
cm@ B
=>C E
cmF H
.H I
CustomerCodeI U
==V X
customerCodeY e
)e f
;f g
string 
_residentType  
=! "
string# )
.) *
Empty* /
;/ 0
string1 7
_title8 >
=? @
stringA G
.G H
EmptyH M
;M N
stringO U 
_socialMediaPlatformV j
=k l
stringm s
.s t
Emptyt y
;y z
string	{ Å!
_identificationType
Ç ï
=
ñ ó
string
ò û
.
û ü
Empty
ü §
;
§ •
var 
_customerType 
= 
(  !
await! &
_unitOfWork' 2
.2 3
CustomerType3 ?
.? @
Get@ C
(C D
cD E
=>F H
cI J
.J K
CustomerTypeIdK Y
==Z \
customer] e
!e f
.f g
CustomerTypeIdg u
)u v
)v w
!w x
.x y
CustomerTypes	y Ü
;
Ü á
var 
	_locality 
= 
( 
await "
_unitOfWork# .
.. /
Locality/ 7
.7 8
Get8 ;
(; <
l< =
=>> @
lA B
.B C

LocalityIdC M
==N P
customerQ Y
!Y Z
.Z [

LocalityId[ e
)e f
)f g
!g h
.h i
LocalityNamei u
;u v
var   
_gender   
=   
(   
await    
_unitOfWork  ! ,
.  , -
Gender  - 3
.  3 4
Get  4 7
(  7 8
g  8 9
=>  : <
g  = >
.  > ?
GenderId  ? G
==  H J
customer  K S
!  S T
.  T U
GenderId  U ]
)  ] ^
)  ^ _
!  _ `
.  ` a

GenderType  a k
;  k l
var!! 
_nationality!! 
=!! 
(!!  
await!!  %
_unitOfWork!!& 1
.!!1 2
Nationality!!2 =
.!!= >
Get!!> A
(!!A B
n!!B C
=>!!D F
n!!G H
.!!H I
NationalityId!!I V
==!!W Y
customer!!Z b
!!!b c
.!!c d
NationalityId!!d q
)!!q r
)!!r s
!!!s t
.!!t u
Nationalities	!!u Ç
;
!!Ç É
if## 
(## 
customer## 
!## 
.## 
ResidentTypeId## (
!=##) +
$num##, -
)##- .
{$$ 
_residentType%% 
=%% 
(%%  !
await%%! &
_unitOfWork%%' 2
.%%2 3
ResidentType%%3 ?
.%%? @
Get%%@ C
(%%C D
r%%D E
=>%%F H
r%%I J
.%%J K
ResidentTypeId%%K Y
==%%Z \
customer%%] e
!%%e f
.%%f g
ResidentTypeId%%g u
)%%u v
)%%v w
!%%w x
.%%x y
ResidentTypes	%%y Ü
;
%%Ü á
}&& 
if(( 
((( 
customer(( 
!(( 
.(( 
TitleId(( !
!=((" $
$num((% &
)((& '
{)) 
_title** 
=** 
(** 
await** 
_unitOfWork**  +
.**+ ,
Title**, 1
.**1 2
Get**2 5
(**5 6
t**6 7
=>**8 :
t**; <
.**< =
TitleId**= D
==**E G
customer**H P
!**P Q
.**Q R
TitleId**R Y
)**Y Z
)**Z [
!**[ \
.**\ ]
Titles**] c
;**c d
}++ 
if-- 
(-- 
customer-- 
!-- 
.-- 
SocialMediaTypeId-- +
!=--, .
$num--/ 0
)--0 1
{..  
_socialMediaPlatform// $
=//% &
(//' (
await//( -
_unitOfWork//. 9
.//9 :
SocialMedia//: E
.//E F
Get//F I
(//I J
s//J K
=>//L N
s//O P
.//P Q
SocialMediaId//Q ^
==//_ a
customer//b j
!//j k
.//k l
SocialMediaTypeId//l }
)//} ~
)//~ 
!	// Ä
.
//Ä Å!
SocialMediaPlatform
//Å î
;
//î ï
}00 
var22 
registeredCustomer22 "
=22# $
new22% (*
ProspectiveCustomerResponseDto22) G
{33 
InterestExpressed44 !
=44" #
customer44$ ,
.44, -
InterestExpressed44- >
!44> ?
,44? @
CustomerType55 
=55 
_customerType55 ,
,55, -
ResidentType66 
=66 
_residentType66 ,
,66, -
Locality77 
=77 
	_locality77 $
,77$ %
CustomerCode88 
=88 
customer88 '
.88' (
CustomerCode88( 4
,884 5
Title99 
=99 
_title99 
,99 
SurName:: 
=:: 
customer:: "
.::" #
SurName::# *
!::* +
,::+ ,

OtherNames;; 
=;; 
customer;; %
.;;% &

OtherNames;;& 0
!;;0 1
,;;1 2
CompanyName<< 
=<< 
customer<< &
.<<& '
CompanyName<<' 2
!<<2 3
,<<3 4
Gender== 
=== 
_gender==  
,==  !
Nationality>> 
=>> 
_nationality>> *
,>>* +
PostalAddress?? 
=?? 
customer??  (
.??( )
PostalAddress??) 6
,??6 7
ResidentialAddress@@ "
=@@# $
customer@@% -
.@@- .
ResidentialAddress@@. @
,@@@ A
DigitalAddressAA 
=AA  
customerAA! )
.AA) *
DigitalAddressAA* 8
,AA8 9
PrimaryMobileNumberBB #
=BB$ %
customerBB& .
.BB. /
PrimaryMobileNumberBB/ B
,BBB C!
SecondaryMobileNumberCC %
=CC& '
customerCC( 0
.CC0 1!
SecondaryMobileNumberCC1 F
,CCF G
OfficeNumberDD 
=DD 
customerDD '
.DD' (
OfficeNumberDD( 4
,DD4 5
WhatsAppNumberEE 
=EE  
customerEE! )
.EE) *
WhatsAppNumberEE* 8
,EE8 9
EmailAddressFF 
=FF 
customerFF '
.FF' (
EmailAddressFF( 4
!FF4 5
,FF5 6
SocialMediaTypeGG 
=GG  ! 
_socialMediaPlatformGG" 6
,GG6 7
SocialMediaAccountHH "
=HH# $
customerHH% -
.HH- .
SocialMediaAccountHH. @
,HH@ A
CommentsJJ 
=JJ 
customerJJ #
.JJ# $
CommentsJJ$ ,
,JJ, -
}KK 
;KK 
returnMM 
registeredCustomerMM %
;MM% &
}NN 	
publicPP 
asyncPP 
TaskPP 
<PP &
CompanyCustomerResponseDtoPP 4
>PP4 5%
GetCompanyCustomerDetailsPP6 O
(PPO P
stringPPP V
customerCodePPW c
)PPc d
{QQ 	
varRR 
customerRR 
=RR 
awaitRR  
_unitOfWorkRR! ,
.RR, -
CustomerMasterRR- ;
.RR; <
GetRR< ?
(RR? @
cmRR@ B
=>RRC E
cmRRF H
.RRH I
CustomerCodeRRI U
==RRV X
customerCodeRRY e
)RRe f
;RRf g
stringTT 
_residentTypeTT  
=TT! "
stringTT# )
.TT) *
EmptyTT* /
;TT/ 0
stringTT1 7 
_socialMediaPlatformTT8 L
=TTM N
stringTTO U
.TTU V
EmptyTTV [
;TT[ \
varWW 
_customerTypeWW 
=WW 
(WW  !
awaitWW! &
_unitOfWorkWW' 2
.WW2 3
CustomerTypeWW3 ?
.WW? @
GetWW@ C
(WWC D
cWWD E
=>WWF H
cWWI J
.WWJ K
CustomerTypeIdWWK Y
==WWZ \
customerWW] e
!WWe f
.WWf g
CustomerTypeIdWWg u
)WWu v
)WWv w
!WWw x
.WWx y
CustomerTypes	WWy Ü
;
WWÜ á
varXX 
_localityNameXX 
=XX 
(XX  !
awaitXX! &
_unitOfWorkXX' 2
.XX2 3
LocalityXX3 ;
.XX; <
GetXX< ?
(XX? @
lXX@ A
=>XXB D
lXXE F
.XXF G

LocalityIdXXG Q
==XXR T
customerXXU ]
!XX] ^
.XX^ _

LocalityIdXX_ i
)XXi j
)XXj k
!XXk l
.XXl m
LocalityNameXXm y
;XXy z
varYY 
_nationalityYY 
=YY 
(YY  
awaitYY  %
_unitOfWorkYY& 1
.YY1 2
NationalityYY2 =
.YY= >
GetYY> A
(YYA B
nYYB C
=>YYD F
nYYG H
.YYH I
NationalityIdYYI V
==YYW Y
customerYYZ b
!YYb c
.YYc d
NationalityIdYYd q
)YYq r
)YYr s
!YYs t
.YYt u
Nationalities	YYu Ç
;
YYÇ É
varZZ 
_identificationTypeZZ #
=ZZ$ %
(ZZ& '
awaitZZ' ,
_unitOfWorkZZ- 8
.ZZ8 9
IdentificationTypeZZ9 K
.ZZK L
GetZZL O
(ZZO P
iZZP Q
=>ZZR T
iZZU V
.ZZV W 
IdentificationTypeIdZZW k
==ZZl n
customerZZo w
!ZZw x
.ZZx y/
"ContactPerson_IdentificationTypeId	ZZy õ
)
ZZõ ú
)
ZZú ù
!
ZZù û
.
ZZû ü!
IdentificationTypes
ZZü ≤
;
ZZ≤ ≥
if\\ 
(\\ 
customer\\ 
!\\ 
.\\ 
ResidentTypeId\\ (
>\\) *
$num\\+ ,
)\\, -
{]] 
_residentType^^ 
=^^ 
(^^  !
await^^! &
_unitOfWork^^' 2
.^^2 3
ResidentType^^3 ?
.^^? @
Get^^@ C
(^^C D
r^^D E
=>^^F H
r^^I J
.^^J K
ResidentTypeId^^K Y
==^^Z \
customer^^] e
!^^e f
.^^f g
ResidentTypeId^^g u
)^^u v
)^^v w
!^^w x
.^^x y
ResidentTypes	^^y Ü
;
^^Ü á
}__ 
ifaa 
(aa 
customeraa 
.aa 
SocialMediaTypeIdaa *
>aa+ ,
$numaa- .
)aa. /
{bb  
_socialMediaPlatformcc $
=cc% &
(cc' (
awaitcc( -
_unitOfWorkcc. 9
.cc9 :
SocialMediacc: E
.ccE F
GetccF I
(ccI J
sccJ K
=>ccL N
sccO P
.ccP Q
SocialMediaIdccQ ^
==cc_ a
customerccb j
!ccj k
.cck l
SocialMediaTypeIdccl }
)cc} ~
)cc~ 
!	cc Ä
.
ccÄ Å!
SocialMediaPlatform
ccÅ î
;
ccî ï
}dd 
varff 
registeredCustomerff "
=ff# $
newff% (&
CompanyCustomerResponseDtoff) C
{gg 
CustomerMasterIdhh  
=hh! "
customerhh# +
.hh+ ,
CustomerMasterIdhh, <
,hh< =
CustomerTypeIdii 
=ii  
customerii! )
.ii) *
CustomerTypeIdii* 8
,ii8 9
CustomerTypejj 
=jj 
_customerTypejj ,
,jj, -
ResidentTypeIdkk 
=kk  
customerkk! )
.kk) *
ResidentTypeIdkk* 8
,kk8 9
ResidentTypell 
=ll 
_residentTypell ,
,ll, -

LocalityIdmm 
=mm 
customermm %
.mm% &

LocalityIdmm& 0
,mm0 1
Localitynn 
=nn 
_localityNamenn (
,nn( )
CustomerCodeoo 
=oo 
customeroo '
.oo' (
CustomerCodeoo( 4
,oo4 5
CompanyNamepp 
=pp 
customerpp &
.pp& '
CompanyNamepp' 2
,pp2 3
EmailAddressqq 
=qq 
customerqq '
.qq' (
EmailAddressqq( 4
,qq4 5
CompanyAddressrr 
=rr  
customerrr! )
.rr) *
PostalAddressrr* 7
,rr7 8
DigitalAddressss 
=ss  
customerss! )
.ss) *
DigitalAddressss* 8
,ss8 9
PrimaryMobileNumbertt #
=tt$ %
customertt& .
.tt. /
PrimaryMobileNumbertt/ B
,ttB C!
SecondaryMobileNumberuu %
=uu& '
customeruu( 0
.uu0 1!
SecondaryMobileNumberuu1 F
,uuF G
OfficeNumbervv 
=vv 
customervv '
.vv' (
OfficeNumbervv( 4
,vv4 5
WhatsAppNumberww 
=ww  
customerww! )
.ww) *
WhatsAppNumberww* 8
,ww8 9&
BusinessRegistrationNumberxx *
=xx+ ,
customerxx- 5
.xx5 6$
IdentificationTypeNumberxx6 N
,xxN O
	TinNumberyy 
=yy 
customeryy $
.yy$ %
	TinNumberyy% .
,yy. /
Picturezz 
=zz 
customerzz "
.zz" #
Picturezz# *
,zz* +
SocialMediaTypeId{{ !
={{" #
customer{{$ ,
.{{, -
SocialMediaTypeId{{- >
,{{> ?
SocialMediaType|| 
=||  ! 
_socialMediaPlatform||" 6
,||6 7
SocialMediaAccount}} "
=}}# $
customer}}% -
.}}- .
SocialMediaAccount}}. @
,}}@ A 
IdentificationImages~~ $
=~~% &
new~~' *
string~~+ 1
[~~1 2
]~~2 3
{~~4 5
customer~~6 >
.~~> ?&
IdentificationTypeImageOne~~? Y
!~~Y Z
,~~Z [
customer~~\ d
.~~d e&
IdentificationTypeImageTwo~~e 
!	~~ Ä
}
~~Å Ç
,
~~Ç É
DebtorStatus 
= 
customer '
.' (
DebtorStatus( 4
==5 7
$num8 9
?: ;
$str< D
:E F
customer
ÄÄ '
.
ÄÄ' (
DebtorStatus
ÄÄ( 4
==
ÄÄ5 7
$num
ÄÄ8 9
?
ÄÄ: ;
$str
ÄÄ< E
:
ÄÄF G
customer
ÅÅ '
.
ÅÅ' (
DebtorStatus
ÅÅ( 4
==
ÅÅ5 7
$num
ÅÅ8 :
?
ÅÅ; <
$str
ÅÅ= I
:
ÅÅJ K
$str
ÅÅL U
,
ÅÅU V
Comments
ÇÇ 
=
ÇÇ 
customer
ÇÇ #
.
ÇÇ# $
Comments
ÇÇ$ ,
,
ÇÇ, -
ContactPerson
ÑÑ 
=
ÑÑ 
new
ÑÑ  #-
CompanyContactPersonResponseDto
ÑÑ$ C
{
ÖÖ $
ContactPerson_FullName
ÜÜ *
=
ÜÜ+ ,
customer
ÜÜ- 5
.
ÜÜ5 6$
ContactPerson_FullName
ÜÜ6 L
,
ÜÜL M#
ContactPerson_Address
áá )
=
áá* +
customer
áá, 4
.
áá4 5#
ContactPerson_Address
áá5 J
,
ááJ K(
ContactPerson_EmailAddress
àà .
=
àà/ 0
customer
àà1 9
.
àà9 :(
ContactPerson_EmailAddress
àà: T
,
ààT U'
ContactPerson_PhoneNumber
ââ -
=
ââ. /
customer
ââ0 8
.
ââ8 9'
ContactPerson_PhoneNumber
ââ9 R
,
ââR S0
"ContactPerson_IdentificationTypeId
ää 6
=
ää7 8
customer
ää9 A
.
ääA B0
"ContactPerson_IdentificationTypeId
ääB d
,
ääd e.
 ContactPerson_IdentificationType
ãã 4
=
ãã5 6!
_identificationType
ãã7 J
,
ããJ K4
&ContactPerson_IdentificationTypeNumber
åå :
=
åå; <
customer
åå= E
.
ååE F4
&ContactPerson_IdentificationTypeNumber
ååF l
,
åål m0
"ContactPerson_IdentificationImages
çç 6
=
çç7 8
new
çç9 <
string
çç= C
[
ççC D
]
ççD E
{
ççF G
customer
ççH P
.
ççP Q6
(ContactPerson_IdentificationTypeImageOne
ççQ y
!
ççy z
,
ççz {
customerçç| Ñ
.ççÑ Ö8
(ContactPerson_IdentificationTypeImageTwoççÖ ≠
!çç≠ Æ
}ççØ ∞
}
éé 
}
èè 
;
èè 
return
ëë  
registeredCustomer
ëë %
;
ëë% &
}
íí 	
public
îî 
async
îî 
Task
îî 
<
îî 3
%IndividualResidentCustomerResponseDto
îî ?
>
îî? @*
GetIndividualCustomerDetails
îîA ]
(
îî] ^
string
îî^ d
customerCode
îîe q
)
îîq r
{
ïï 	
var
ññ 
customer
ññ 
=
ññ 
await
ññ  
_unitOfWork
ññ! ,
.
ññ, -
CustomerMaster
ññ- ;
.
ññ; <
Get
ññ< ?
(
ññ? @
cm
ññ@ B
=>
ññC E
cm
ññF H
.
ññH I
CustomerCode
ññI U
==
ññV X
customerCode
ññY e
)
ññe f
;
ññf g
string
òò "
_socialMediaPlatform
òò '
=
òò( )
string
òò* 0
.
òò0 1
Empty
òò1 6
;
òò6 7
string
òò8 >+
_contactperson_identification
òò? \
=
òò] ^
string
òò_ e
.
òòe f
Empty
òòf k
;
òòk l
var
õõ 
_customerType
õõ 
=
õõ 
(
õõ  !
await
õõ! &
_unitOfWork
õõ' 2
.
õõ2 3
CustomerType
õõ3 ?
.
õõ? @
Get
õõ@ C
(
õõC D
c
õõD E
=>
õõF H
c
õõI J
.
õõJ K
CustomerTypeId
õõK Y
==
õõZ \
customer
õõ] e
!
õõe f
.
õõf g
CustomerTypeId
õõg u
)
õõu v
)
õõv w
!
õõw x
.
õõx y
CustomerTypesõõy Ü
;õõÜ á
var
úú 
_residentType
úú 
=
úú 
(
úú  !
await
úú! &
_unitOfWork
úú' 2
.
úú2 3
ResidentType
úú3 ?
.
úú? @
Get
úú@ C
(
úúC D
r
úúD E
=>
úúF H
r
úúI J
.
úúJ K
ResidentTypeId
úúK Y
==
úúZ \
customer
úú] e
!
úúe f
.
úúf g
ResidentTypeId
úúg u
)
úúu v
)
úúv w
!
úúw x
.
úúx y
ResidentTypesúúy Ü
;úúÜ á
var
ùù 
_localityName
ùù 
=
ùù 
(
ùù  !
await
ùù! &
_unitOfWork
ùù' 2
.
ùù2 3
Locality
ùù3 ;
.
ùù; <
Get
ùù< ?
(
ùù? @
l
ùù@ A
=>
ùùB D
l
ùùE F
.
ùùF G

LocalityId
ùùG Q
==
ùùR T
customer
ùùU ]
!
ùù] ^
.
ùù^ _

LocalityId
ùù_ i
)
ùùi j
)
ùùj k
!
ùùk l
.
ùùl m
LocalityName
ùùm y
;
ùùy z
var
ûû 
_title
ûû 
=
ûû 
(
ûû 
await
ûû 
_unitOfWork
ûû  +
.
ûû+ ,
Title
ûû, 1
.
ûû1 2
Get
ûû2 5
(
ûû5 6
t
ûû6 7
=>
ûû8 :
t
ûû; <
.
ûû< =
TitleId
ûû= D
==
ûûE G
customer
ûûH P
!
ûûP Q
.
ûûQ R
TitleId
ûûR Y
)
ûûY Z
)
ûûZ [
!
ûû[ \
.
ûû\ ]
Titles
ûû] c
;
ûûc d
var
üü 
_gender
üü 
=
üü 
(
üü 
await
üü  
_unitOfWork
üü! ,
.
üü, -
Gender
üü- 3
.
üü3 4
Get
üü4 7
(
üü7 8
g
üü8 9
=>
üü: <
g
üü= >
.
üü> ?
GenderId
üü? G
==
üüH J
customer
üüK S
!
üüS T
.
üüT U
GenderId
üüU ]
)
üü] ^
)
üü^ _
!
üü_ `
.
üü` a

GenderType
üüa k
;
üük l
var
†† 
_nationality
†† 
=
†† 
(
††  
await
††  %
_unitOfWork
††& 1
.
††1 2
Nationality
††2 =
.
††= >
Get
††> A
(
††A B
n
††B C
=>
††D F
n
††G H
.
††H I
NationalityId
††I V
==
††W Y
customer
††Z b
!
††b c
.
††c d
NationalityId
††d q
)
††q r
)
††r s
!
††s t
.
††t u
Nationalities††u Ç
;††Ç É
var
°° !
_identificationType
°° #
=
°°$ %
(
°°& '
await
°°' ,
_unitOfWork
°°- 8
.
°°8 9 
IdentificationType
°°9 K
.
°°K L
Get
°°L O
(
°°O P
i
°°P Q
=>
°°R T
i
°°U V
.
°°V W"
IdentificationTypeId
°°W k
==
°°l n
customer
°°o w
!
°°w x
.
°°x y#
IdentificationTypeId°°y ç
)°°ç é
)°°é è
!°°è ê
.°°ê ë#
IdentificationTypes°°ë §
;°°§ •
if
££ 
(
££ 
customer
££ 
!
££ 
.
££ 
SocialMediaTypeId
££ +
>
££, -
$num
££. /
)
££/ 0
{
§§ "
_socialMediaPlatform
•• $
=
••% &
(
••' (
await
••( -
_unitOfWork
••. 9
.
••9 :
SocialMedia
••: E
.
••E F
Get
••F I
(
••I J
s
••J K
=>
••L N
s
••O P
.
••P Q
SocialMediaId
••Q ^
==
••_ a
customer
••b j
.
••j k
SocialMediaTypeId
••k |
)
••| }
)
••} ~
!
••~ 
.•• Ä#
SocialMediaPlatform••Ä ì
;••ì î
}
¶¶ 
if
®® 
(
®® 
customer
®® 
.
®® 0
"ContactPerson_IdentificationTypeId
®® ;
!=
®®< >
$num
®®? @
)
®®@ A
{
©© +
_contactperson_identification
™™ -
=
™™. /
(
™™0 1
await
™™1 6
_unitOfWork
™™7 B
.
™™B C 
IdentificationType
™™C U
.
™™U V
Get
™™V Y
(
™™Y Z
i
™™Z [
=>
™™\ ^
i
™™_ `
.
™™` a"
IdentificationTypeId
™™a u
==
™™v x
customer™™y Å
.™™Å Ç2
"ContactPerson_IdentificationTypeId™™Ç §
)™™§ •
)™™• ¶
!™™¶ ß
.™™ß ®#
IdentificationTypes™™® ª
!™™ª º
;™™º Ω
}
´´ 
return
≠≠ 
new
≠≠ 3
%IndividualResidentCustomerResponseDto
≠≠ <
{
ÆÆ 
CustomerMasterId
ØØ  
=
ØØ! "
customer
ØØ# +
.
ØØ+ ,
CustomerMasterId
ØØ, <
,
ØØ< =
CustomerTypeId
∞∞ 
=
∞∞  
customer
∞∞! )
.
∞∞) *
CustomerTypeId
∞∞* 8
,
∞∞8 9
CustomerType
±± 
=
±± 
_customerType
±± ,
,
±±, -
ResidentTypeId
≤≤ 
=
≤≤  
customer
≤≤! )
.
≤≤) *
ResidentTypeId
≤≤* 8
,
≤≤8 9
ResidentType
≥≥ 
=
≥≥ 
_residentType
≥≥ ,
,
≥≥, -

LocalityId
¥¥ 
=
¥¥ 
customer
¥¥ %
.
¥¥% &

LocalityId
¥¥& 0
,
¥¥0 1
Locality
µµ 
=
µµ 
_localityName
µµ (
,
µµ( )
CustomerCode
∂∂ 
=
∂∂ 
customer
∂∂ '
.
∂∂' (
CustomerCode
∂∂( 4
,
∂∂4 5
TitleId
∑∑ 
=
∑∑ 
customer
∑∑ "
.
∑∑" #
TitleId
∑∑# *
,
∑∑* +
Title
∏∏ 
=
∏∏ 
_title
∏∏ 
,
∏∏ 
SurName
ππ 
=
ππ 
customer
ππ "
.
ππ" #
SurName
ππ# *
!
ππ* +
,
ππ+ ,

OtherNames
∫∫ 
=
∫∫ 
customer
∫∫ %
.
∫∫% &

OtherNames
∫∫& 0
!
∫∫0 1
,
∫∫1 2
DateOfBirth
ªª 
=
ªª 
customer
ªª &
.
ªª& '
DateOfBirth
ªª' 2
,
ªª2 3
	TinNumber
ºº 
=
ºº 
customer
ºº $
.
ºº$ %
	TinNumber
ºº% .
,
ºº. /
Picture
ΩΩ 
=
ΩΩ 
customer
ΩΩ "
.
ΩΩ" #
Picture
ΩΩ# *
,
ΩΩ* +
GenderId
ææ 
=
ææ 
customer
ææ #
.
ææ# $
GenderId
ææ$ ,
,
ææ, -
Gender
øø 
=
øø 
_gender
øø  
,
øø  !
NationalityId
¿¿ 
=
¿¿ 
customer
¿¿  (
.
¿¿( )
NationalityId
¿¿) 6
,
¿¿6 7
Nationality
¡¡ 
=
¡¡ 
_nationality
¡¡ *
,
¡¡* +
PostalAddress
¬¬ 
=
¬¬ 
customer
¬¬  (
.
¬¬( )
PostalAddress
¬¬) 6
,
¬¬6 7 
ResidentialAddress
√√ "
=
√√# $
customer
√√% -
.
√√- . 
ResidentialAddress
√√. @
,
√√@ A
DigitalAddress
ƒƒ 
=
ƒƒ  
customer
ƒƒ! )
.
ƒƒ) *
DigitalAddress
ƒƒ* 8
,
ƒƒ8 9!
PrimaryMobileNumber
≈≈ #
=
≈≈$ %
customer
≈≈& .
.
≈≈. /!
PrimaryMobileNumber
≈≈/ B
,
≈≈B C#
SecondaryMobileNumber
∆∆ %
=
∆∆& '
customer
∆∆( 0
.
∆∆0 1#
SecondaryMobileNumber
∆∆1 F
,
∆∆F G
OfficeNumber
«« 
=
«« 
customer
«« '
.
««' (
OfficeNumber
««( 4
,
««4 5
WhatsAppNumber
»» 
=
»»  
customer
»»! )
.
»») *
WhatsAppNumber
»»* 8
,
»»8 9
EmailAddress
…… 
=
…… 
customer
…… '
.
……' (
EmailAddress
……( 4
!
……4 5
,
……5 6
SocialMediaTypeId
   !
=
  " #
customer
  $ ,
.
  , -
SocialMediaTypeId
  - >
,
  > ?!
SocialMediaPlatform
ÀÀ #
=
ÀÀ$ %"
_socialMediaPlatform
ÀÀ& :
,
ÀÀ: ; 
SocialMediaAccount
ÃÃ "
=
ÃÃ# $
customer
ÃÃ% -
.
ÃÃ- . 
SocialMediaAccount
ÃÃ. @
,
ÃÃ@ A"
IdentificationTypeId
ÕÕ $
=
ÕÕ% &
customer
ÕÕ' /
.
ÕÕ/ 0"
IdentificationTypeId
ÕÕ0 D
,
ÕÕD E 
IdentificationType
ŒŒ "
=
ŒŒ# $!
_identificationType
ŒŒ% 8
,
ŒŒ8 9"
IdentificationImages
œœ $
=
œœ% &
new
œœ' *
string
œœ+ 1
[
œœ1 2
]
œœ2 3
{
œœ4 5
customer
œœ6 >
.
œœ> ?(
IdentificationTypeImageOne
œœ? Y
!
œœY Z
,
œœZ [
customer
œœ\ d
.
œœd e(
IdentificationTypeImageTwo
œœe 
!œœ Ä
,œœÄ Å
}œœÇ É
,œœÉ Ñ&
IdentificationTypeNumber
–– (
=
––) *
customer
––+ 3
.
––3 4&
IdentificationTypeNumber
––4 L
,
––L M
Comments
—— 
=
—— 
customer
—— #
.
——# $
Comments
——$ ,
,
——, -
DebtorStatus
““ 
=
““ 
customer
““ '
.
““' (
DebtorStatus
““( 4
==
““5 7
$num
““8 9
?
““: ;
$str
““< D
:
““E F
customer
”” '
.
””' (
DebtorStatus
””( 4
==
””5 7
$num
””8 9
?
””: ;
$str
””< E
:
””F G
customer
‘‘ '
.
‘‘' (
DebtorStatus
‘‘( 4
==
‘‘5 7
$num
‘‘8 :
?
‘‘; <
$str
‘‘= I
:
‘‘J K
$str
‘‘L U
,
‘‘U V
NonResident
’’ 
=
’’ 
new
’’ !6
(IndividualNonResidentCustomerResponseDto
’’" J
{
÷÷ $
ContactPerson_FullName
◊◊ *
=
◊◊+ ,
customer
◊◊- 5
.
◊◊5 6$
ContactPerson_FullName
◊◊6 L
,
◊◊L M#
ContactPerson_Address
ÿÿ )
=
ÿÿ* +
customer
ÿÿ, 4
.
ÿÿ4 5#
ContactPerson_Address
ÿÿ5 J
,
ÿÿJ K(
ContactPerson_EmailAddress
ŸŸ .
=
ŸŸ/ 0
customer
ŸŸ1 9
.
ŸŸ9 :(
ContactPerson_EmailAddress
ŸŸ: T
,
ŸŸT U'
ContactPerson_PhoneNumber
⁄⁄ -
=
⁄⁄. /
customer
⁄⁄0 8
.
⁄⁄8 9'
ContactPerson_PhoneNumber
⁄⁄9 R
,
⁄⁄R S0
"ContactPerson_IdentificationTypeId
€€ 6
=
€€7 8
customer
€€9 A
.
€€A B0
"ContactPerson_IdentificationTypeId
€€B d
,
€€d e4
&ContactPerson_IdentificationTypeNumber
‹‹ :
=
‹‹; <
customer
‹‹= E
.
‹‹E F4
&ContactPerson_IdentificationTypeNumber
‹‹F l
,
‹‹l m.
 ContactPerson_IdentificationType
›› 4
=
››5 6+
_contactperson_identification
››7 T
,
››T U0
"ContactPerson_IdentificationImages
ﬁﬁ 6
=
ﬁﬁ7 8
new
ﬁﬁ9 <
string
ﬁﬁ= C
[
ﬁﬁC D
]
ﬁﬁD E
{
ﬁﬁF G
customer
ﬁﬁH P
.
ﬁﬁP Q6
(ContactPerson_IdentificationTypeImageOne
ﬁﬁQ y
!
ﬁﬁy z
,
ﬁﬁz {
customerﬁﬁ| Ñ
.ﬁﬁÑ Ö8
(ContactPerson_IdentificationTypeImageTwoﬁﬁÖ ≠
!ﬁﬁ≠ Æ
}ﬁﬁØ ∞
}
ﬂﬂ 
,
ﬂﬂ 

Expatriate
‡‡ 
=
‡‡ 
new
‡‡  5
'IndividualExpatriateCustomerResponseDto
‡‡! H
{
‡‡I J"
ResidentPermitNumber
‡‡K _
=
‡‡` a
customer
‡‡b j
.
‡‡j k"
ResidentPermitNumber
‡‡k 
,‡‡ Ä(
ResidentPermitDateIssued‡‡Å ô
=‡‡ö õ
customer‡‡ú §
.‡‡§ •(
ResidentPermitDateIssued‡‡• Ω
!‡‡Ω æ
,‡‡æ ø(
ResidentPermitExpiryDate‡‡¿ ÿ
=‡‡Ÿ ⁄
customer‡‡€ „
.‡‡„ ‰(
ResidentPermitExpiryDate‡‡‰ ¸
}‡‡˝ ˛
}
·· 
;
·· 
}
‚‚ 	
public
‰‰ 
async
‰‰ 
Task
‰‰ 
<
‰‰ /
!JointOwnershipCustomerResponseDto
‰‰ ;
>
‰‰; <%
GetJointCustomerDetails
‰‰= T
(
‰‰T U
string
‰‰U [
customerCode
‰‰\ h
)
‰‰h i
{
ÂÂ 	
var
ÊÊ 
pr_customer
ÊÊ 
=
ÊÊ 
await
ÊÊ #
_unitOfWork
ÊÊ$ /
.
ÊÊ/ 0
CustomerMaster
ÊÊ0 >
.
ÊÊ> ?
Get
ÊÊ? B
(
ÊÊB C
cm
ÊÊC E
=>
ÊÊF H
cm
ÊÊI K
.
ÊÊK L
CustomerCode
ÊÊL X
==
ÊÊY [
customerCode
ÊÊ\ h
)
ÊÊh i
;
ÊÊi j
pr_customer
ÁÁ 
=
ÁÁ 
await
ÁÁ 
_unitOfWork
ÁÁ  +
.
ÁÁ+ ,
CustomerMaster
ÁÁ, :
.
ÁÁ: ;
Get
ÁÁ; >
(
ÁÁ> ?
cm
ÁÁ? A
=>
ÁÁB D
cm
ÁÁE G
.
ÁÁG H
CustomerCode
ÁÁH T
==
ÁÁU W
customerCode
ÁÁX d
)
ÁÁd e
;
ÁÁe f
string
ÈÈ "
_socialMediaPlatform
ÈÈ '
=
ÈÈ( )
string
ÈÈ* 0
.
ÈÈ0 1
Empty
ÈÈ1 6
;
ÈÈ6 7
string
ÈÈ8 >+
_contactperson_identification
ÈÈ? \
=
ÈÈ] ^
string
ÈÈ_ e
.
ÈÈe f
Empty
ÈÈf k
;
ÈÈk l
var
ÏÏ 
_customerType
ÏÏ 
=
ÏÏ 
(
ÏÏ  !
await
ÏÏ! &
_unitOfWork
ÏÏ' 2
.
ÏÏ2 3
CustomerType
ÏÏ3 ?
.
ÏÏ? @
Get
ÏÏ@ C
(
ÏÏC D
c
ÏÏD E
=>
ÏÏF H
c
ÏÏI J
.
ÏÏJ K
CustomerTypeId
ÏÏK Y
==
ÏÏZ \
pr_customer
ÏÏ] h
!
ÏÏh i
.
ÏÏi j
CustomerTypeId
ÏÏj x
)
ÏÏx y
)
ÏÏy z
!
ÏÏz {
.
ÏÏ{ |
CustomerTypesÏÏ| â
;ÏÏâ ä
var
ÌÌ 
_residentType
ÌÌ 
=
ÌÌ 
(
ÌÌ  !
await
ÌÌ! &
_unitOfWork
ÌÌ' 2
.
ÌÌ2 3
ResidentType
ÌÌ3 ?
.
ÌÌ? @
Get
ÌÌ@ C
(
ÌÌC D
r
ÌÌD E
=>
ÌÌF H
r
ÌÌI J
.
ÌÌJ K
ResidentTypeId
ÌÌK Y
==
ÌÌZ \
pr_customer
ÌÌ] h
!
ÌÌh i
.
ÌÌi j
ResidentTypeId
ÌÌj x
)
ÌÌx y
)
ÌÌy z
!
ÌÌz {
.
ÌÌ{ |
ResidentTypesÌÌ| â
;ÌÌâ ä
var
ÓÓ 
_localityName
ÓÓ 
=
ÓÓ 
(
ÓÓ  !
await
ÓÓ! &
_unitOfWork
ÓÓ' 2
.
ÓÓ2 3
Locality
ÓÓ3 ;
.
ÓÓ; <
Get
ÓÓ< ?
(
ÓÓ? @
l
ÓÓ@ A
=>
ÓÓB D
l
ÓÓE F
.
ÓÓF G

LocalityId
ÓÓG Q
==
ÓÓR T
pr_customer
ÓÓU `
!
ÓÓ` a
.
ÓÓa b

LocalityId
ÓÓb l
)
ÓÓl m
)
ÓÓm n
!
ÓÓn o
.
ÓÓo p
LocalityName
ÓÓp |
;
ÓÓ| }
var
ÔÔ 
_title
ÔÔ 
=
ÔÔ 
(
ÔÔ 
await
ÔÔ 
_unitOfWork
ÔÔ  +
.
ÔÔ+ ,
Title
ÔÔ, 1
.
ÔÔ1 2
Get
ÔÔ2 5
(
ÔÔ5 6
t
ÔÔ6 7
=>
ÔÔ8 :
t
ÔÔ; <
.
ÔÔ< =
TitleId
ÔÔ= D
==
ÔÔE G
pr_customer
ÔÔH S
!
ÔÔS T
.
ÔÔT U
TitleId
ÔÔU \
)
ÔÔ\ ]
)
ÔÔ] ^
!
ÔÔ^ _
.
ÔÔ_ `
Titles
ÔÔ` f
;
ÔÔf g
var
 
_gender
 
=
 
(
 
await
  
_unitOfWork
! ,
.
, -
Gender
- 3
.
3 4
Get
4 7
(
7 8
g
8 9
=>
: <
g
= >
.
> ?
GenderId
? G
==
H J
pr_customer
K V
!
V W
.
W X
GenderId
X `
)
` a
)
a b
!
b c
.
c d

GenderType
d n
;
n o
var
ÒÒ 
_nationality
ÒÒ 
=
ÒÒ 
(
ÒÒ  
await
ÒÒ  %
_unitOfWork
ÒÒ& 1
.
ÒÒ1 2
Nationality
ÒÒ2 =
.
ÒÒ= >
Get
ÒÒ> A
(
ÒÒA B
n
ÒÒB C
=>
ÒÒD F
n
ÒÒG H
.
ÒÒH I
NationalityId
ÒÒI V
==
ÒÒW Y
pr_customer
ÒÒZ e
!
ÒÒe f
.
ÒÒf g
NationalityId
ÒÒg t
)
ÒÒt u
)
ÒÒu v
!
ÒÒv w
.
ÒÒw x
NationalitiesÒÒx Ö
;ÒÒÖ Ü
var
ÚÚ !
_identificationType
ÚÚ #
=
ÚÚ$ %
(
ÚÚ& '
await
ÚÚ' ,
_unitOfWork
ÚÚ- 8
.
ÚÚ8 9 
IdentificationType
ÚÚ9 K
.
ÚÚK L
Get
ÚÚL O
(
ÚÚO P
i
ÚÚP Q
=>
ÚÚR T
i
ÚÚU V
.
ÚÚV W"
IdentificationTypeId
ÚÚW k
==
ÚÚl n
pr_customer
ÚÚo z
!
ÚÚz {
.
ÚÚ{ |#
IdentificationTypeIdÚÚ| ê
)ÚÚê ë
)ÚÚë í
!ÚÚí ì
.ÚÚì î#
IdentificationTypesÚÚî ß
;ÚÚß ®
if
ÙÙ 
(
ÙÙ 
pr_customer
ÙÙ 
!
ÙÙ 
.
ÙÙ 
SocialMediaTypeId
ÙÙ .
>
ÙÙ/ 0
$num
ÙÙ1 2
)
ÙÙ2 3
{
ıı "
_socialMediaPlatform
ˆˆ $
=
ˆˆ% &
(
ˆˆ' (
await
ˆˆ( -
_unitOfWork
ˆˆ. 9
.
ˆˆ9 :
SocialMedia
ˆˆ: E
.
ˆˆE F
Get
ˆˆF I
(
ˆˆI J
s
ˆˆJ K
=>
ˆˆL N
s
ˆˆO P
.
ˆˆP Q
SocialMediaId
ˆˆQ ^
==
ˆˆ_ a
pr_customer
ˆˆb m
.
ˆˆm n
SocialMediaTypeId
ˆˆn 
)ˆˆ Ä
)ˆˆÄ Å
!ˆˆÅ Ç
.ˆˆÇ É#
SocialMediaPlatformˆˆÉ ñ
;ˆˆñ ó
}
˜˜ 
if
˘˘ 
(
˘˘ 
pr_customer
˘˘ 
.
˘˘ 0
"ContactPerson_IdentificationTypeId
˘˘ >
!=
˘˘? A
$num
˘˘B C
)
˘˘C D
{
˙˙ +
_contactperson_identification
˚˚ -
=
˚˚. /
(
˚˚0 1
await
˚˚1 6
_unitOfWork
˚˚7 B
.
˚˚B C 
IdentificationType
˚˚C U
.
˚˚U V
Get
˚˚V Y
(
˚˚Y Z
i
˚˚Z [
=>
˚˚\ ^
i
˚˚_ `
.
˚˚` a"
IdentificationTypeId
˚˚a u
==
˚˚v x
pr_customer˚˚y Ñ
.˚˚Ñ Ö2
"ContactPerson_IdentificationTypeId˚˚Ö ß
)˚˚ß ®
)˚˚® ©
!˚˚© ™
.˚˚™ ´#
IdentificationTypes˚˚´ æ
!˚˚æ ø
;˚˚ø ¿
}
¸¸ 
var
˛˛ 
joint_customer
˛˛ 
=
˛˛  
new
˛˛! $/
!JointOwnershipCustomerResponseDto
˛˛% F
{
ˇˇ 
CustomerMasterId
ÄÄ  
=
ÄÄ! "
pr_customer
ÄÄ# .
.
ÄÄ. /
CustomerMasterId
ÄÄ/ ?
,
ÄÄ? @
CustomerTypeId
ÅÅ 
=
ÅÅ  
pr_customer
ÅÅ! ,
.
ÅÅ, -
CustomerTypeId
ÅÅ- ;
,
ÅÅ; <
CustomerType
ÇÇ 
=
ÇÇ 
_customerType
ÇÇ ,
,
ÇÇ, -
ResidentTypeId
ÉÉ 
=
ÉÉ  
pr_customer
ÉÉ! ,
.
ÉÉ, -
ResidentTypeId
ÉÉ- ;
,
ÉÉ; <
ResidentType
ÑÑ 
=
ÑÑ 
_residentType
ÑÑ ,
,
ÑÑ, -

LocalityId
ÖÖ 
=
ÖÖ 
pr_customer
ÖÖ (
.
ÖÖ( )

LocalityId
ÖÖ) 3
,
ÖÖ3 4
Locality
ÜÜ 
=
ÜÜ 
_localityName
ÜÜ (
,
ÜÜ( )
CustomerCode
áá 
=
áá 
pr_customer
áá *
.
áá* +
CustomerCode
áá+ 7
,
áá7 8
TitleId
àà 
=
àà 
pr_customer
àà %
.
àà% &
TitleId
àà& -
,
àà- .
Title
ââ 
=
ââ 
_title
ââ 
,
ââ 
SurName
ää 
=
ää 
pr_customer
ää %
.
ää% &
SurName
ää& -
!
ää- .
,
ää. /

OtherNames
ãã 
=
ãã 
pr_customer
ãã (
.
ãã( )

OtherNames
ãã) 3
!
ãã3 4
,
ãã4 5
DateOfBirth
åå 
=
åå 
pr_customer
åå )
.
åå) *
DateOfBirth
åå* 5
,
åå5 6
	TinNumber
çç 
=
çç 
pr_customer
çç '
.
çç' (
	TinNumber
çç( 1
,
çç1 2
Picture
éé 
=
éé 
pr_customer
éé %
.
éé% &
Picture
éé& -
,
éé- .
GenderId
èè 
=
èè 
pr_customer
èè &
.
èè& '
GenderId
èè' /
,
èè/ 0
Gender
êê 
=
êê 
_gender
êê  
,
êê  !
NationalityId
ëë 
=
ëë 
pr_customer
ëë  +
.
ëë+ ,
NationalityId
ëë, 9
,
ëë9 :
Nationality
íí 
=
íí 
_nationality
íí *
,
íí* +
PostalAddress
ìì 
=
ìì 
pr_customer
ìì  +
.
ìì+ ,
PostalAddress
ìì, 9
,
ìì9 : 
ResidentialAddress
îî "
=
îî# $
pr_customer
îî% 0
.
îî0 1 
ResidentialAddress
îî1 C
,
îîC D
DigitalAddress
ïï 
=
ïï  
pr_customer
ïï! ,
.
ïï, -
DigitalAddress
ïï- ;
,
ïï; <!
PrimaryMobileNumber
ññ #
=
ññ$ %
pr_customer
ññ& 1
.
ññ1 2!
PrimaryMobileNumber
ññ2 E
,
ññE F#
SecondaryMobileNumber
óó %
=
óó& '
pr_customer
óó( 3
.
óó3 4#
SecondaryMobileNumber
óó4 I
,
óóI J
OfficeNumber
òò 
=
òò 
pr_customer
òò *
.
òò* +
OfficeNumber
òò+ 7
,
òò7 8
WhatsAppNumber
ôô 
=
ôô  
pr_customer
ôô! ,
.
ôô, -
WhatsAppNumber
ôô- ;
,
ôô; <
EmailAddress
öö 
=
öö 
pr_customer
öö *
.
öö* +
EmailAddress
öö+ 7
!
öö7 8
,
öö8 9
SocialMediaTypeId
õõ !
=
õõ" #
pr_customer
õõ$ /
.
õõ/ 0
SocialMediaTypeId
õõ0 A
,
õõA B!
SocialMediaPlatform
úú #
=
úú$ %"
_socialMediaPlatform
úú& :
,
úú: ; 
SocialMediaAccount
ùù "
=
ùù# $
pr_customer
ùù% 0
.
ùù0 1 
SocialMediaAccount
ùù1 C
,
ùùC D"
IdentificationTypeId
ûû $
=
ûû% &
pr_customer
ûû' 2
.
ûû2 3"
IdentificationTypeId
ûû3 G
,
ûûG H 
IdentificationType
üü "
=
üü# $!
_identificationType
üü% 8
,
üü8 9"
IdentificationImages
†† $
=
††% &
new
††' *
string
††+ 1
[
††1 2
]
††2 3
{
††4 5
pr_customer
††6 A
.
††A B(
IdentificationTypeImageOne
††B \
!
††\ ]
,
††] ^
pr_customer
††_ j
.
††j k)
IdentificationTypeImageTwo††k Ö
!††Ö Ü
,††Ü á
}††à â
,††â ä&
IdentificationTypeNumber
°° (
=
°°) *
pr_customer
°°+ 6
.
°°6 7&
IdentificationTypeNumber
°°7 O
,
°°O P
MaritalStatus
¢¢ 
=
¢¢ 
pr_customer
¢¢  +
.
¢¢+ ,
MaritalStatus
¢¢, 9
,
¢¢9 :
DateOfMarriage
££ 
=
££  
pr_customer
££! ,
.
££, -
DateOfMarriage
££- ;
,
££; <
Comments
§§ 
=
§§ 
pr_customer
§§ &
.
§§& '
Comments
§§' /
,
§§/ 0
DebtorStatus
•• 
=
•• 
pr_customer
•• *
.
••* +
DebtorStatus
••+ 7
==
••8 :
$num
••; <
?
••= >
$str
••? G
:
••H I
pr_customer
¶¶ *
.
¶¶* +
DebtorStatus
¶¶+ 7
==
¶¶8 :
$num
¶¶; <
?
¶¶= >
$str
¶¶? H
:
¶¶I J
pr_customer
ßß *
.
ßß* +
DebtorStatus
ßß+ 7
==
ßß8 :
$num
ßß; =
?
ßß> ?
$str
ßß@ L
:
ßßM N
$str
ßßO X
,
ßßX Y
NonResident
®® 
=
®® 
new
®® !6
(IndividualNonResidentCustomerResponseDto
®®" J
{
©© $
ContactPerson_FullName
™™ *
=
™™+ ,
pr_customer
™™- 8
.
™™8 9$
ContactPerson_FullName
™™9 O
,
™™O P#
ContactPerson_Address
´´ )
=
´´* +
pr_customer
´´, 7
.
´´7 8#
ContactPerson_Address
´´8 M
,
´´M N(
ContactPerson_EmailAddress
¨¨ .
=
¨¨/ 0
pr_customer
¨¨1 <
.
¨¨< =(
ContactPerson_EmailAddress
¨¨= W
,
¨¨W X'
ContactPerson_PhoneNumber
≠≠ -
=
≠≠. /
pr_customer
≠≠0 ;
.
≠≠; <'
ContactPerson_PhoneNumber
≠≠< U
,
≠≠U V0
"ContactPerson_IdentificationTypeId
ÆÆ 6
=
ÆÆ7 8
pr_customer
ÆÆ9 D
.
ÆÆD E0
"ContactPerson_IdentificationTypeId
ÆÆE g
,
ÆÆg h4
&ContactPerson_IdentificationTypeNumber
ØØ :
=
ØØ; <
pr_customer
ØØ= H
.
ØØH I4
&ContactPerson_IdentificationTypeNumber
ØØI o
,
ØØo p.
 ContactPerson_IdentificationType
∞∞ 4
=
∞∞5 6+
_contactperson_identification
∞∞7 T
,
∞∞T U0
"ContactPerson_IdentificationImages
±± 6
=
±±7 8
new
±±9 <
string
±±= C
[
±±C D
]
±±D E
{
±±F G
pr_customer
±±H S
.
±±S T6
(ContactPerson_IdentificationTypeImageOne
±±T |
!
±±| }
,
±±} ~
pr_customer±± ä
.±±ä ã8
(ContactPerson_IdentificationTypeImageTwo±±ã ≥
!±±≥ ¥
}±±µ ∂
}
≤≤ 
,
≤≤ 

Expatriate
≥≥ 
=
≥≥ 
new
≥≥  5
'IndividualExpatriateCustomerResponseDto
≥≥! H
{
≥≥I J"
ResidentPermitNumber
≥≥K _
=
≥≥` a
pr_customer
≥≥b m
.
≥≥m n#
ResidentPermitNumber≥≥n Ç
,≥≥Ç É(
ResidentPermitDateIssued≥≥Ñ ú
=≥≥ù û
pr_customer≥≥ü ™
.≥≥™ ´(
ResidentPermitDateIssued≥≥´ √
!≥≥√ ƒ
,≥≥ƒ ≈(
ResidentPermitExpiryDate≥≥∆ ﬁ
=≥≥ﬂ ‡
pr_customer≥≥· Ï
.≥≥Ï Ì(
ResidentPermitExpiryDate≥≥Ì Ö
}≥≥Ü á
,≥≥á à
}
¥¥ 
;
¥¥ 
return
∑∑ 
joint_customer
∑∑ !
;
∑∑! "
}
∏∏ 	
public
∫∫ 
async
∫∫ 
Task
∫∫ 
<
∫∫ /
!MultiOwnershipCustomerResponseDto
∫∫ ;
>
∫∫; <%
GetMultiCustomerDetails
∫∫= T
(
∫∫T U
string
∫∫U [
customerCode
∫∫\ h
)
∫∫h i
{
ªª 	
var
ºº 
pr_customer
ºº 
=
ºº 
await
ºº #
_unitOfWork
ºº$ /
.
ºº/ 0
CustomerMaster
ºº0 >
.
ºº> ?
Get
ºº? B
(
ººB C
cm
ººC E
=>
ººF H
cm
ººI K
.
ººK L
CustomerCode
ººL X
==
ººY [
customerCode
ºº\ h
)
ººh i
;
ººi j
string
ææ "
_socialMediaPlatform
ææ '
=
ææ( )
string
ææ* 0
.
ææ0 1
Empty
ææ1 6
;
ææ6 7
string
ææ8 >+
_contactperson_identification
ææ? \
=
ææ] ^
string
ææ_ e
.
ææe f
Empty
ææf k
;
ææk l
var
¡¡ 
_customerType
¡¡ 
=
¡¡ 
(
¡¡  !
await
¡¡! &
_unitOfWork
¡¡' 2
.
¡¡2 3
CustomerType
¡¡3 ?
.
¡¡? @
Get
¡¡@ C
(
¡¡C D
c
¡¡D E
=>
¡¡F H
c
¡¡I J
.
¡¡J K
CustomerTypeId
¡¡K Y
==
¡¡Z \
pr_customer
¡¡] h
!
¡¡h i
.
¡¡i j
CustomerTypeId
¡¡j x
)
¡¡x y
)
¡¡y z
!
¡¡z {
.
¡¡{ |
CustomerTypes¡¡| â
;¡¡â ä
var
¬¬ 
_residentType
¬¬ 
=
¬¬ 
(
¬¬  !
await
¬¬! &
_unitOfWork
¬¬' 2
.
¬¬2 3
ResidentType
¬¬3 ?
.
¬¬? @
Get
¬¬@ C
(
¬¬C D
r
¬¬D E
=>
¬¬F H
r
¬¬I J
.
¬¬J K
ResidentTypeId
¬¬K Y
==
¬¬Z \
pr_customer
¬¬] h
!
¬¬h i
.
¬¬i j
ResidentTypeId
¬¬j x
)
¬¬x y
)
¬¬y z
!
¬¬z {
.
¬¬{ |
ResidentTypes¬¬| â
;¬¬â ä
var
√√ 
_localityName
√√ 
=
√√ 
(
√√  !
await
√√! &
_unitOfWork
√√' 2
.
√√2 3
Locality
√√3 ;
.
√√; <
Get
√√< ?
(
√√? @
l
√√@ A
=>
√√B D
l
√√E F
.
√√F G

LocalityId
√√G Q
==
√√R T
pr_customer
√√U `
!
√√` a
.
√√a b

LocalityId
√√b l
)
√√l m
)
√√m n
!
√√n o
.
√√o p
LocalityName
√√p |
;
√√| }
var
ƒƒ 
_title
ƒƒ 
=
ƒƒ 
(
ƒƒ 
await
ƒƒ 
_unitOfWork
ƒƒ  +
.
ƒƒ+ ,
Title
ƒƒ, 1
.
ƒƒ1 2
Get
ƒƒ2 5
(
ƒƒ5 6
t
ƒƒ6 7
=>
ƒƒ8 :
t
ƒƒ; <
.
ƒƒ< =
TitleId
ƒƒ= D
==
ƒƒE G
pr_customer
ƒƒH S
!
ƒƒS T
.
ƒƒT U
TitleId
ƒƒU \
)
ƒƒ\ ]
)
ƒƒ] ^
!
ƒƒ^ _
.
ƒƒ_ `
Titles
ƒƒ` f
;
ƒƒf g
var
≈≈ 
_gender
≈≈ 
=
≈≈ 
(
≈≈ 
await
≈≈  
_unitOfWork
≈≈! ,
.
≈≈, -
Gender
≈≈- 3
.
≈≈3 4
Get
≈≈4 7
(
≈≈7 8
g
≈≈8 9
=>
≈≈: <
g
≈≈= >
.
≈≈> ?
GenderId
≈≈? G
==
≈≈H J
pr_customer
≈≈K V
!
≈≈V W
.
≈≈W X
GenderId
≈≈X `
)
≈≈` a
)
≈≈a b
!
≈≈b c
.
≈≈c d

GenderType
≈≈d n
;
≈≈n o
var
∆∆ 
_nationality
∆∆ 
=
∆∆ 
(
∆∆  
await
∆∆  %
_unitOfWork
∆∆& 1
.
∆∆1 2
Nationality
∆∆2 =
.
∆∆= >
Get
∆∆> A
(
∆∆A B
n
∆∆B C
=>
∆∆D F
n
∆∆G H
.
∆∆H I
NationalityId
∆∆I V
==
∆∆W Y
pr_customer
∆∆Z e
!
∆∆e f
.
∆∆f g
NationalityId
∆∆g t
)
∆∆t u
)
∆∆u v
!
∆∆v w
.
∆∆w x
Nationalities∆∆x Ö
;∆∆Ö Ü
var
«« !
_identificationType
«« #
=
««$ %
(
««& '
await
««' ,
_unitOfWork
««- 8
.
««8 9 
IdentificationType
««9 K
.
««K L
Get
««L O
(
««O P
i
««P Q
=>
««R T
i
««U V
.
««V W"
IdentificationTypeId
««W k
==
««l n
pr_customer
««o z
!
««z {
.
««{ |#
IdentificationTypeId««| ê
)««ê ë
)««ë í
!««í ì
.««ì î#
IdentificationTypes««î ß
;««ß ®
if
…… 
(
…… 
pr_customer
…… 
!
…… 
.
…… 
SocialMediaTypeId
…… .
>
……/ 0
$num
……1 2
)
……2 3
{
   "
_socialMediaPlatform
ÀÀ $
=
ÀÀ% &
(
ÀÀ' (
await
ÀÀ( -
_unitOfWork
ÀÀ. 9
.
ÀÀ9 :
SocialMedia
ÀÀ: E
.
ÀÀE F
Get
ÀÀF I
(
ÀÀI J
s
ÀÀJ K
=>
ÀÀL N
s
ÀÀO P
.
ÀÀP Q
SocialMediaId
ÀÀQ ^
==
ÀÀ_ a
pr_customer
ÀÀb m
.
ÀÀm n
SocialMediaTypeId
ÀÀn 
)ÀÀ Ä
)ÀÀÄ Å
!ÀÀÅ Ç
.ÀÀÇ É#
SocialMediaPlatformÀÀÉ ñ
;ÀÀñ ó
}
ÃÃ 
if
ŒŒ 
(
ŒŒ 
pr_customer
ŒŒ 
.
ŒŒ 0
"ContactPerson_IdentificationTypeId
ŒŒ >
!=
ŒŒ? A
$num
ŒŒB C
)
ŒŒC D
{
œœ +
_contactperson_identification
–– -
=
––. /
(
––0 1
await
––1 6
_unitOfWork
––7 B
.
––B C 
IdentificationType
––C U
.
––U V
Get
––V Y
(
––Y Z
i
––Z [
=>
––\ ^
i
––_ `
.
––` a"
IdentificationTypeId
––a u
==
––v x
pr_customer––y Ñ
.––Ñ Ö2
"ContactPerson_IdentificationTypeId––Ö ß
)––ß ®
)––® ©
!––© ™
.––™ ´#
IdentificationTypes––´ æ
!––æ ø
;––ø ¿
}
—— 
var
”” 
multi_customer
”” 
=
””  
new
””! $/
!MultiOwnershipCustomerResponseDto
””% F
{
‘‘ 
CustomerMasterId
’’  
=
’’! "
pr_customer
’’# .
.
’’. /
CustomerMasterId
’’/ ?
,
’’? @
CustomerTypeId
÷÷ 
=
÷÷  
pr_customer
÷÷! ,
.
÷÷, -
CustomerTypeId
÷÷- ;
,
÷÷; <
CustomerType
◊◊ 
=
◊◊ 
_customerType
◊◊ ,
,
◊◊, -
ResidentTypeId
ÿÿ 
=
ÿÿ  
pr_customer
ÿÿ! ,
.
ÿÿ, -
ResidentTypeId
ÿÿ- ;
,
ÿÿ; <
ResidentType
ŸŸ 
=
ŸŸ 
_residentType
ŸŸ ,
,
ŸŸ, -

LocalityId
⁄⁄ 
=
⁄⁄ 
pr_customer
⁄⁄ (
.
⁄⁄( )

LocalityId
⁄⁄) 3
,
⁄⁄3 4
Locality
€€ 
=
€€ 
_localityName
€€ (
,
€€( )
CustomerCode
‹‹ 
=
‹‹ 
pr_customer
‹‹ *
.
‹‹* +
CustomerCode
‹‹+ 7
,
‹‹7 8
TitleId
›› 
=
›› 
pr_customer
›› %
.
››% &
TitleId
››& -
,
››- .
Title
ﬁﬁ 
=
ﬁﬁ 
_title
ﬁﬁ 
,
ﬁﬁ 
SurName
ﬂﬂ 
=
ﬂﬂ 
pr_customer
ﬂﬂ %
.
ﬂﬂ% &
SurName
ﬂﬂ& -
!
ﬂﬂ- .
,
ﬂﬂ. /

OtherNames
‡‡ 
=
‡‡ 
pr_customer
‡‡ (
.
‡‡( )

OtherNames
‡‡) 3
!
‡‡3 4
,
‡‡4 5
DateOfBirth
·· 
=
·· 
pr_customer
·· )
.
··) *
DateOfBirth
··* 5
,
··5 6
	TinNumber
‚‚ 
=
‚‚ 
pr_customer
‚‚ '
.
‚‚' (
	TinNumber
‚‚( 1
,
‚‚1 2
Picture
„„ 
=
„„ 
pr_customer
„„ %
.
„„% &
Picture
„„& -
,
„„- .
GenderId
‰‰ 
=
‰‰ 
pr_customer
‰‰ &
.
‰‰& '
GenderId
‰‰' /
,
‰‰/ 0
Gender
ÂÂ 
=
ÂÂ 
_gender
ÂÂ  
,
ÂÂ  !
NationalityId
ÊÊ 
=
ÊÊ 
pr_customer
ÊÊ  +
.
ÊÊ+ ,
NationalityId
ÊÊ, 9
,
ÊÊ9 :
Nationality
ÁÁ 
=
ÁÁ 
_nationality
ÁÁ *
,
ÁÁ* +
PostalAddress
ËË 
=
ËË 
pr_customer
ËË  +
.
ËË+ ,
PostalAddress
ËË, 9
,
ËË9 : 
ResidentialAddress
ÈÈ "
=
ÈÈ# $
pr_customer
ÈÈ% 0
.
ÈÈ0 1 
ResidentialAddress
ÈÈ1 C
,
ÈÈC D
DigitalAddress
ÍÍ 
=
ÍÍ  
pr_customer
ÍÍ! ,
.
ÍÍ, -
DigitalAddress
ÍÍ- ;
,
ÍÍ; <!
PrimaryMobileNumber
ÎÎ #
=
ÎÎ$ %
pr_customer
ÎÎ& 1
.
ÎÎ1 2!
PrimaryMobileNumber
ÎÎ2 E
,
ÎÎE F#
SecondaryMobileNumber
ÏÏ %
=
ÏÏ& '
pr_customer
ÏÏ( 3
.
ÏÏ3 4#
SecondaryMobileNumber
ÏÏ4 I
,
ÏÏI J
OfficeNumber
ÌÌ 
=
ÌÌ 
pr_customer
ÌÌ *
.
ÌÌ* +
OfficeNumber
ÌÌ+ 7
,
ÌÌ7 8
WhatsAppNumber
ÓÓ 
=
ÓÓ  
pr_customer
ÓÓ! ,
.
ÓÓ, -
WhatsAppNumber
ÓÓ- ;
,
ÓÓ; <
EmailAddress
ÔÔ 
=
ÔÔ 
pr_customer
ÔÔ *
.
ÔÔ* +
EmailAddress
ÔÔ+ 7
!
ÔÔ7 8
,
ÔÔ8 9
SocialMediaTypeId
 !
=
" #
pr_customer
$ /
.
/ 0
SocialMediaTypeId
0 A
,
A B!
SocialMediaPlatform
ÒÒ #
=
ÒÒ$ %"
_socialMediaPlatform
ÒÒ& :
,
ÒÒ: ; 
SocialMediaAccount
ÚÚ "
=
ÚÚ# $
pr_customer
ÚÚ% 0
.
ÚÚ0 1 
SocialMediaAccount
ÚÚ1 C
,
ÚÚC D"
IdentificationTypeId
ÛÛ $
=
ÛÛ% &
pr_customer
ÛÛ' 2
.
ÛÛ2 3"
IdentificationTypeId
ÛÛ3 G
,
ÛÛG H 
IdentificationType
ÙÙ "
=
ÙÙ# $!
_identificationType
ÙÙ% 8
,
ÙÙ8 9"
IdentificationImages
ıı $
=
ıı% &
new
ıı' *
string
ıı+ 1
[
ıı1 2
]
ıı2 3
{
ıı4 5
pr_customer
ıı6 A
.
ııA B(
IdentificationTypeImageOne
ııB \
!
ıı\ ]
,
ıı] ^
pr_customer
ıı_ j
.
ııj k)
IdentificationTypeImageTwoıık Ö
!ııÖ Ü
,ııÜ á
}ııà â
,ııâ ä&
IdentificationTypeNumber
ˆˆ (
=
ˆˆ) *
pr_customer
ˆˆ+ 6
.
ˆˆ6 7&
IdentificationTypeNumber
ˆˆ7 O
,
ˆˆO P
MaritalStatus
˜˜ 
=
˜˜ 
pr_customer
˜˜  +
.
˜˜+ ,
MaritalStatus
˜˜, 9
,
˜˜9 :
DateOfMarriage
¯¯ 
=
¯¯  
pr_customer
¯¯! ,
.
¯¯, -
DateOfMarriage
¯¯- ;
,
¯¯; <
Comments
˘˘ 
=
˘˘ 
pr_customer
˘˘ &
.
˘˘& '
Comments
˘˘' /
,
˘˘/ 0
DebtorStatus
˙˙ 
=
˙˙ 
pr_customer
˙˙ *
.
˙˙* +
DebtorStatus
˙˙+ 7
==
˙˙8 :
$num
˙˙; <
?
˙˙= >
$str
˙˙? G
:
˙˙H I
pr_customer
˚˚ *
.
˚˚* +
DebtorStatus
˚˚+ 7
==
˚˚8 :
$num
˚˚; <
?
˚˚= >
$str
˚˚? H
:
˚˚I J
pr_customer
¸¸ *
.
¸¸* +
DebtorStatus
¸¸+ 7
==
¸¸8 :
$num
¸¸; =
?
¸¸> ?
$str
¸¸@ L
:
¸¸M N
$str
¸¸O X
,
¸¸X Y
NonResident
˝˝ 
=
˝˝ 
new
˝˝ !6
(IndividualNonResidentCustomerResponseDto
˝˝" J
{
˛˛ $
ContactPerson_FullName
ˇˇ *
=
ˇˇ+ ,
pr_customer
ˇˇ- 8
.
ˇˇ8 9$
ContactPerson_FullName
ˇˇ9 O
,
ˇˇO P#
ContactPerson_Address
ÄÄ )
=
ÄÄ* +
pr_customer
ÄÄ, 7
.
ÄÄ7 8#
ContactPerson_Address
ÄÄ8 M
,
ÄÄM N(
ContactPerson_EmailAddress
ÅÅ .
=
ÅÅ/ 0
pr_customer
ÅÅ1 <
.
ÅÅ< =(
ContactPerson_EmailAddress
ÅÅ= W
,
ÅÅW X'
ContactPerson_PhoneNumber
ÇÇ -
=
ÇÇ. /
pr_customer
ÇÇ0 ;
.
ÇÇ; <'
ContactPerson_PhoneNumber
ÇÇ< U
,
ÇÇU V0
"ContactPerson_IdentificationTypeId
ÉÉ 6
=
ÉÉ7 8
pr_customer
ÉÉ9 D
.
ÉÉD E0
"ContactPerson_IdentificationTypeId
ÉÉE g
,
ÉÉg h4
&ContactPerson_IdentificationTypeNumber
ÑÑ :
=
ÑÑ; <
pr_customer
ÑÑ= H
.
ÑÑH I4
&ContactPerson_IdentificationTypeNumber
ÑÑI o
,
ÑÑo p.
 ContactPerson_IdentificationType
ÖÖ 4
=
ÖÖ5 6+
_contactperson_identification
ÖÖ7 T
,
ÖÖT U0
"ContactPerson_IdentificationImages
ÜÜ 6
=
ÜÜ7 8
new
ÜÜ9 <
string
ÜÜ= C
[
ÜÜC D
]
ÜÜD E
{
ÜÜF G
pr_customer
ÜÜH S
.
ÜÜS T6
(ContactPerson_IdentificationTypeImageOne
ÜÜT |
!
ÜÜ| }
,
ÜÜ} ~
pr_customerÜÜ ä
.ÜÜä ã8
(ContactPerson_IdentificationTypeImageTwoÜÜã ≥
!ÜÜ≥ ¥
}ÜÜµ ∂
}
áá 
,
áá 

Expatriate
àà 
=
àà 
new
àà  5
'IndividualExpatriateCustomerResponseDto
àà! H
{
ààI J"
ResidentPermitNumber
ààK _
=
àà` a
pr_customer
ààb m
.
ààm n#
ResidentPermitNumberààn Ç
,ààÇ É(
ResidentPermitDateIssuedààÑ ú
=ààù û
pr_customerààü ™
.àà™ ´(
ResidentPermitDateIssuedàà´ √
!àà√ ƒ
,ààƒ ≈(
ResidentPermitExpiryDateàà∆ ﬁ
=ààﬂ ‡
pr_customeràà· Ï
.ààÏ Ì(
ResidentPermitExpiryDateààÌ Ö
}ààÜ á
,ààá à
}
ââ 
;
ââ 
return
åå 
multi_customer
åå !
;
åå! "
}
çç 	
public
èè 
async
èè 
Task
èè 
<
èè 
IEnumerable
èè %
<
èè% &
CustomerListDto
èè& 5
>
èè5 6
>
èè6 7"
GetCustomerListAsync
èè8 L
(
èèL M
)
èèM N
{
êê 	
var
ëë 
customersQuery
ëë 
=
ëë  
from
ëë! %
a
ëë& '
in
ëë( *
await
ëë+ 0
_unitOfWork
ëë1 <
.
ëë< =
CustomerMaster
ëë= K
.
ëëK L
GetAll
ëëL R
(
ëëR S
cm
ëëS U
=>
ëëV X
cm
ëëY [
.
ëë[ \
	IsDeleted
ëë\ e
==
ëëf h
false
ëëi n
)
ëën o
join
íí! %
b
íí& '
in
íí( *
await
íí+ 0
_unitOfWork
íí1 <
.
íí< =
Title
íí= B
.
ííB C
GetAll
ííC I
(
ííI J
)
ííJ K
on
ìì! #
a
ìì$ %
.
ìì% &
TitleId
ìì& -
equals
ìì. 4
b
ìì5 6
.
ìì6 7
TitleId
ìì7 >
into
ìì? C

titleGroup
ììD N
from
îî! %
title
îî& +
in
îî, .

titleGroup
îî/ 9
.
îî9 :
DefaultIfEmpty
îî: H
(
îîH I
)
îîI J
join
ññ! %
c
ññ& '
in
ññ( *
await
ññ+ 0
_unitOfWork
ññ1 <
.
ññ< =
Locality
ññ= E
.
ññE F
GetAll
ññF L
(
ññL M
)
ññM N
on
óó! #
a
óó$ %
.
óó% &

LocalityId
óó& 0
equals
óó1 7
c
óó8 9
.
óó9 :

LocalityId
óó: D
into
óóE I
localityGroup
óóJ W
from
òò! %
locality
òò& .
in
òò/ 1
localityGroup
òò2 ?
.
òò? @
DefaultIfEmpty
òò@ N
(
òòN O
)
òòO P
orderby
ôô! (
a
ôô) *
.
ôô* +
	CreatedOn
ôô+ 4

descending
ôô5 ?
select
öö! '
new
öö( +
CustomerListDto
öö, ;
{
õõ! "
CustomerCode
úú% 1
=
úú2 3
a
úú4 5
.
úú5 6
CustomerCode
úú6 B
,
úúB C
FullName
ùù% -
=
ùù. /
string
ùù0 6
.
ùù6 7
Concat
ùù7 =
(
ùù= >
title
ùù> C
!=
ùùD F
null
ùùG K
?
ùùL M
title
ùùN S
.
ùùS T
Titles
ùùT Z
:
ùù[ \
null
ùù] a
,
ùùa b
$str
ùùc f
,
ùùf g
a
ùùh i
.
ùùi j
SurName
ùùj q
,
ùùq r
$str
ùùs v
,
ùùv w
a
ùùx y
.
ùùy z

OtherNamesùùz Ñ
,ùùÑ Ö
$strùùÜ â
,ùùâ ä
aùùã å
.ùùå ç
CompanyNameùùç ò
)ùùò ô
,ùùô ö
Locality
ûû% -
=
ûû. /
locality
ûû0 8
!=
ûû9 ;
null
ûû< @
?
ûûA B
locality
ûûC K
.
ûûK L
LocalityName
ûûL X
:
ûûY Z
string
ûû[ a
.
ûûa b
Empty
ûûb g
,
ûûg h
EmailAddress
üü% 1
=
üü2 3
a
üü4 5
.
üü5 6
EmailAddress
üü6 B
,
üüB C!
PrimaryMobileNumber
††% 8
=
††9 :
a
††; <
.
††< =!
PrimaryMobileNumber
††= P
,
††P Q
DebtorStatus
°°% 1
=
°°2 3
a
°°4 5
.
°°5 6
DebtorStatus
°°6 B
==
°°C E
$num
°°F G
?
°°H I
$str
°°J R
:
°°S T
a
¢¢4 5
.
¢¢5 6
DebtorStatus
¢¢6 B
==
¢¢C E
$num
¢¢F G
?
¢¢H I
$str
¢¢J S
:
¢¢T U
a
££4 5
.
££5 6
DebtorStatus
££6 B
==
££C E
$num
££F H
?
££I J
$str
££K W
:
££X Y
$str
££Z c
}
§§! "
;
§§" #
return
¶¶ 
customersQuery
¶¶ !
.
¶¶! "
ToList
¶¶" (
(
¶¶( )
)
¶¶) *
;
¶¶* +
}
®® 	
public
™™ 
async
™™ 
Task
™™ 
<
™™ 
IEnumerable
™™ %
<
™™% &
CustomerListDto
™™& 5
>
™™5 6
>
™™6 7)
GetPendingCustomerListAsync
™™8 S
(
™™S T
)
™™T U
{
´´ 	
var
¨¨ 
customersQuery
¨¨ 
=
¨¨  
from
¨¨! %
a
¨¨& '
in
¨¨( *
await
¨¨+ 0
_unitOfWork
¨¨1 <
.
¨¨< =
CustomerMaster
¨¨= K
.
¨¨K L
GetAll
¨¨L R
(
¨¨R S
cm
¨¨S U
=>
¨¨V X
cm
¨¨Y [
.
¨¨[ \
DebtorStatus
¨¨\ h
==
¨¨i k
$num
¨¨l m
&&
¨¨n p
cm
¨¨q s
.
¨¨s t
	IsDeleted
¨¨t }
==¨¨~ Ä
false¨¨Å Ü
)¨¨Ü á
join
≠≠! %
b
≠≠& '
in
≠≠( *
await
≠≠+ 0
_unitOfWork
≠≠1 <
.
≠≠< =
Title
≠≠= B
.
≠≠B C
GetAll
≠≠C I
(
≠≠I J
)
≠≠J K
on
ÆÆ! #
a
ÆÆ$ %
.
ÆÆ% &
TitleId
ÆÆ& -
equals
ÆÆ. 4
b
ÆÆ5 6
.
ÆÆ6 7
TitleId
ÆÆ7 >
into
ÆÆ? C

titleGroup
ÆÆD N
from
ØØ! %
title
ØØ& +
in
ØØ, .

titleGroup
ØØ/ 9
.
ØØ9 :
DefaultIfEmpty
ØØ: H
(
ØØH I
)
ØØI J
join
±±! %
c
±±& '
in
±±( *
await
±±+ 0
_unitOfWork
±±1 <
.
±±< =
Locality
±±= E
.
±±E F
GetAll
±±F L
(
±±L M
)
±±M N
on
≤≤! #
a
≤≤$ %
.
≤≤% &

LocalityId
≤≤& 0
equals
≤≤1 7
c
≤≤8 9
.
≤≤9 :

LocalityId
≤≤: D
into
≤≤E I
localityGroup
≤≤J W
from
≥≥! %
locality
≥≥& .
in
≥≥/ 1
localityGroup
≥≥2 ?
.
≥≥? @
DefaultIfEmpty
≥≥@ N
(
≥≥N O
)
≥≥O P
orderby
¥¥! (
a
¥¥) *
.
¥¥* +
	CreatedOn
¥¥+ 4

descending
¥¥5 ?
select
µµ! '
new
µµ( +
CustomerListDto
µµ, ;
{
∂∂! "
CustomerCode
∑∑% 1
=
∑∑2 3
a
∑∑4 5
.
∑∑5 6
CustomerCode
∑∑6 B
,
∑∑B C
FullName
∏∏% -
=
∏∏. /
string
∏∏0 6
.
∏∏6 7
Concat
∏∏7 =
(
∏∏= >
title
∏∏> C
!=
∏∏D F
null
∏∏G K
?
∏∏L M
title
∏∏N S
.
∏∏S T
Titles
∏∏T Z
:
∏∏[ \
null
∏∏] a
,
∏∏a b
$str
∏∏c f
,
∏∏f g
a
∏∏h i
.
∏∏i j
SurName
∏∏j q
,
∏∏q r
$str
∏∏s v
,
∏∏v w
a
∏∏x y
.
∏∏y z

OtherNames∏∏z Ñ
,∏∏Ñ Ö
$str∏∏Ü â
,∏∏â ä
a∏∏ã å
.∏∏å ç
CompanyName∏∏ç ò
)∏∏ò ô
,∏∏ô ö
Locality
ππ% -
=
ππ. /
locality
ππ0 8
!=
ππ9 ;
null
ππ< @
?
ππA B
locality
ππC K
.
ππK L
LocalityName
ππL X
:
ππY Z
string
ππ[ a
.
ππa b
Empty
ππb g
,
ππg h
EmailAddress
∫∫% 1
=
∫∫2 3
a
∫∫4 5
.
∫∫5 6
EmailAddress
∫∫6 B
,
∫∫B C!
PrimaryMobileNumber
ªª% 8
=
ªª9 :
a
ªª; <
.
ªª< =!
PrimaryMobileNumber
ªª= P
,
ªªP Q
DebtorStatus
ºº% 1
=
ºº2 3
a
ºº4 5
.
ºº5 6
DebtorStatus
ºº6 B
==
ººC E
$num
ººF G
?
ººH I
$str
ººJ R
:
ººS T
a
ΩΩ4 5
.
ΩΩ5 6
DebtorStatus
ΩΩ6 B
==
ΩΩC E
$num
ΩΩF G
?
ΩΩH I
$str
ΩΩJ S
:
ΩΩT U
a
ææ4 5
.
ææ5 6
DebtorStatus
ææ6 B
==
ææC E
$num
ææF H
?
ææI J
$str
ææK W
:
ææX Y
$str
ææZ c
}
øø! "
;
øø" #
return
¡¡ 
customersQuery
¡¡ !
.
¡¡! "
ToList
¡¡" (
(
¡¡( )
)
¡¡) *
;
¡¡* +
}
√√ 	
}
∆∆ 
}«« É

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/PropertyTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class 
PropertyTypeProfile  
:! "
Profile# *
{ 
public 
PropertyTypeProfile 
( 
) 
{ 
	CreateMap 
< 
PropertyType 
, 
PropertyTypeReadDto  3
>3 4
(4 5
)5 6
;6 7
	CreateMap

 
<

 !
PropertyTypeCreateDto

 '
,

' (
PropertyType

) 5
>

5 6
(

6 7
)

7 8
;

8 9
	CreateMap 
< !
PropertyTypeUpdateDto '
,' (
PropertyType) 5
>5 6
(6 7
)7 8
;8 9
	CreateMap 
< !
PropertyTypeDeleteDto '
,' (
PropertyType) 5
>5 6
(6 7
)7 8
;8 9
} 
} ô

à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/PropertyHeightProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class !
PropertyHeightProfile "
:# $
Profile% ,
{ 
public !
PropertyHeightProfile 
( 
) 
{ 
	CreateMap 
< 
PropertyHeight 
, !
PropertyHeightReadDto 1
>1 2
(2 3
)3 4
;4 5
	CreateMap 
< #
PropertyHeightCreateDto #
,# $
PropertyHeight% 3
>3 4
(4 5
)5 6
;6 7
	CreateMap		 
<		 #
PropertyHeightUpdateDto		 )
,		) *
PropertyHeight		+ 9
>		9 :
(		: ;
)		; <
;		< =
	CreateMap

 
<

 #
PropertyHeightDeleteDto

 )
,

) *
PropertyHeight

+ 9
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
< =
} 
} ±
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/PlotSizeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class 
PlotSizeProfile 
: 
Profile &
{ 
public 
PlotSizeProfile 
( 
) 
{		 
	CreateMap

 
<

 
PlotSize

 
,

 
PlotSizeReadDto

 +
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
	CreateMap 
< 
PlotSizeCreateDto #
,# $
PlotSize% -
>- .
(. /
)/ 0
;0 1
	CreateMap 
< 
PlotSizeUpdateDto #
,# $
PlotSize% -
>- .
(. /
)/ 0
;0 1
} 
} ÿ	
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/LocalityProfile.cs
	namespace 	
Modules
 
. 
Property 
. 
Application &
.& '
Profiles' /
./ 0
Property0 8
;8 9
public 
class 
LocalityProfile 
: 
Profile &
{ 
public 
LocalityProfile 
( 
) 
{ 
	CreateMap 
< 
Locality 
, 
LocalityReadDto %
>% &
(& '
)' (
;( )
	CreateMap 
< 
LocalityCreateDto #
,# $
Locality% -
>- .
(. /
)/ 0
;0 1
	CreateMap		 
<		 
LocalityUpdateDto		 #
,		# $
Locality		% -
>		- .
(		. /
)		/ 0
;		0 1
	CreateMap

 
<

 
LocalityDeleteDto

 #
,

# $
Locality

% -
>

- .
(

. /
)

/ 0
;

0 1
} 
} ˘	
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/LandUseTypeProfile.cs
	namespace 	
Modules
 
. 
Property 
. 
Application &
.& '
Profiles' /
./ 0
Property0 8
;8 9
public 
class 
LandUseTypeProfile 
:  !
Profile" )
{ 
public 
LandUseTypeProfile 
( 
) 
{ 
	CreateMap 
< 
LandUseType 
, 
LandUseTypeReadDto 1
>1 2
(2 3
)3 4
;4 5
	CreateMap		 
<		  
LandUseTypeCreateDto		 &
,		& '
LandUseType		( 3
>		3 4
(		4 5
)		5 6
;		6 7
	CreateMap

 
<

  
LandUseTypeUpdateDto

 &
,

& '
LandUseType

( 3
>

3 4
(

4 5
)

5 6
;

6 7
	CreateMap 
<  
LandUseTypeDeleteDto &
,& '
LandUseType( 3
>3 4
(4 5
)5 6
;6 7
} 
} Õ	
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/LandUseProfile.cs
	namespace 	
Modules
 
. 
Property 
. 
Application &
.& '
Profiles' /
./ 0
Property0 8
;8 9
public 
class 
LandUseProfile 
: 
Profile %
{ 
public 
LandUseProfile 
( 
) 
{ 
	CreateMap 
< 
LandUse 
, 
LandUseReadDto #
># $
($ %
)% &
;& '
	CreateMap		 
<		 
LandUseCreateDto		 "
,		" #
LandUse		$ +
>		+ ,
(		, -
)		- .
;		. /
	CreateMap

 
<

 
LandUseUpdateDto

 "
,

" #
LandUse

$ +
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
	CreateMap 
< 
LandUseDeleteDto "
," #
LandUse$ +
>+ ,
(, -
)- .
;. /
} 
} ô

à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/FloorNumberingProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class !
FloorNumberingProfile "
:# $
Profile% ,
{ 
public !
FloorNumberingProfile 
( 
) 
{ 
	CreateMap 
< 
FloorNumbering 
, !
FloorNumberingReadDto 1
>1 2
(2 3
)3 4
;4 5
	CreateMap		 
<		 #
FloorNumberingCreateDto		 #
,		# $
FloorNumbering		% 3
>		3 4
(		4 5
)		5 6
;		6 7
	CreateMap

 
<

 #
FloorNumberingUpdateDto

 )
,

) *
FloorNumbering

+ 9
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
	CreateMap 
< #
FloorNumberingDeleteDto )
,) *
FloorNumbering+ 9
>9 :
(: ;
); <
;< =
} 
} Ì	
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/FacilitiesProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class 
FacilitiesProfile 
:  
Profile! (
{ 
public 
FacilitiesProfile 
( 
) 
{ 
	CreateMap 
< 

Facilities 
, 
FacilitiesReadDto )
>) *
(* +
)+ ,
;, -
	CreateMap		 
<		 
FacilitiesCreateDto		 %
,		% &

Facilities		' 1
>		1 2
(		2 3
)		3 4
;		4 5
	CreateMap

 
<

 
FacilitiesUpdateDto

 %
,

% &

Facilities

' 1
>

1 2
(

2 3
)

3 4
;

4 5
	CreateMap 
< 
FacilitiesDeleteDto %
,% &

Facilities' 1
>1 2
(2 3
)3 4
;4 5
} 
} Û	
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockUnitProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
BlockUnitProfile 
:  
Profile! (
{ 
public 
BlockUnitProfile	 
( 
) 
{ 
	CreateMap 
< 
	BlockUnit 
,  
BlockUnitReadDto! 1
>1 2
(2 3
)3 4
;4 5
	CreateMap		 
<		 
BlockUnitCreateDto		 (
,		( )
	BlockUnit		* 3
>		3 4
(		4 5
)		5 6
;		6 7
	CreateMap

 
<

 
BlockUnitUpdateDto

 (
,

( )
	BlockUnit

* 3
>

3 4
(

4 5
)

5 6
;

6 7
	CreateMap 
< 
BlockUnitDeleteDto (
,( )
	BlockUnit* 3
>3 4
(4 5
)5 6
;6 7
} 	
} 
} ˜	
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
BlockTypeProfile 
:  
Profile! (
{ 
public 
BlockTypeProfile	 
( 
) 
{ 
	CreateMap 
< 

BlockTypes  
,  !
BlockTypeReadDto" 2
>2 3
(3 4
)4 5
;5 6
	CreateMap		 
<		 
BlockTypeCreateDto		 (
,		( )

BlockTypes		* 4
>		4 5
(		5 6
)		6 7
;		7 8
	CreateMap

 
<

 
BlockTypeUpdateDto

 (
,

( )

BlockTypes

* 4
>

4 5
(

5 6
)

6 7
;

7 8
	CreateMap 
< 
BlockTypeDeleteDto (
,( )

BlockTypes* 4
>4 5
(5 6
)6 7
;7 8
} 	
} 
} ˜	
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockSideProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
BlockSideProfile 
:  
Profile! (
{ 
public 
BlockSideProfile	 
( 
) 
{ 
	CreateMap 
< 

BlockSides  
,  !
BlockSideReadDto" 2
>2 3
(3 4
)4 5
;5 6
	CreateMap		 
<		 
BlockSideCreateDto		 (
,		( )

BlockSides		* 4
>		4 5
(		5 6
)		6 7
;		7 8
	CreateMap

 
<

 
BlockSideUpdateDto

 (
,

( )

BlockSides

* 4
>

4 5
(

5 6
)

6 7
;

7 8
	CreateMap 
< 
BlockSideDeleteDto (
,( )

BlockSides* 4
>4 5
(5 6
)6 7
;7 8
} 	
} 
} â

Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/BlockNumberProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
BlockNumberProfile  
:! "
Profile# *
{ 
public 
BlockNumberProfile	 
( 
) 
{ 
	CreateMap 
< 
BlockNumber !
,! "
BlockNumberReadDto# 5
>5 6
(6 7
)7 8
;8 9
	CreateMap		 
<		  
BlockNumberCreateDto		 *
,		* +
BlockNumber		, 7
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
BlockNumberUpdateDto

 *
,

* +
BlockNumber
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
BlockNumberDeleteDto *
,* +
BlockNumber, 7
>7 8
(8 9
)9 :
;: ;
} 	
} 
} í

á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ApartmentTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class  
ApartmentTypeProfile !
:" #
Profile$ +
{ 
public  
ApartmentTypeProfile 
( 
) 
{ 
	CreateMap 
< 
ApartmentTypes 
,  
ApartmentTypeReadDto 0
>0 1
(1 2
)2 3
;3 4
	CreateMap 
< "
ApartmentTypeCreateDto "
," #
ApartmentTypes$ 2
>2 3
(3 4
)4 5
;5 6
	CreateMap		 
<		 "
ApartmentTypeUpdateDto		 (
,		( )
ApartmentTypes		* 8
>		8 9
(		9 :
)		: ;
;		; <
	CreateMap

 
<

 "
ApartmentTypeDeleteDto

 (
,

( )
ApartmentTypes

* 8
>

8 9
(

9 :
)

: ;
;

; <
} 
} ô

à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/AllocationTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
;7 8
public 
class !
AllocationTypeProfile "
:# $
Profile% ,
{ 
public !
AllocationTypeProfile 
( 
) 
{ 
	CreateMap 
< 
AllocationType  
,  !!
AllocationTypeReadDto" 7
>7 8
(8 9
)9 :
;: ;
	CreateMap

 
<

 #
AllocationTypeCreateDto

 )
,

) *
AllocationType

+ 9
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
	CreateMap 
< #
AllocationTypeUpdateDto )
,) *
AllocationType+ 9
>9 :
(: ;
); <
;< =
	CreateMap 
< #
AllocationTypeDeleteDto )
,) *
AllocationType+ 9
>9 :
(: ;
); <
;< =
} 
} î

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ActivityTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
ActivityTypeProfile !
:" #
Profile$ +
{ 
public 
ActivityTypeProfile	 
( 
) 
{ 
	CreateMap 
< 
ActivityType "
," #
ActivityTypeReadDto$ 7
>7 8
(8 9
)9 :
;: ;
	CreateMap

 
<

 !
ActivityTypeCreateDto

 +
,

+ ,
ActivityType
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
ActivityTypeUpdateDto +
,+ ,
ActivityType- 9
>9 :
(: ;
); <
;< =
	CreateMap 
< !
ActivityTypeDeleteDto +
,+ ,
ActivityType- 9
>9 :
(: ;
); <
;< =
} 	
} 
} Ë	
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ActivityProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Property/ 7
{ 
public 
class 
ActivityProfile 
: 
Profile  '
{ 
public 
ActivityProfile	 
( 
) 
{ 
	CreateMap 
< 
Activity 
, 
ActivityReadDto  /
>/ 0
(0 1
)1 2
;2 3
	CreateMap

 
<

 
ActivityCreateDto

 '
,

' (
Activity

) 1
>

1 2
(

2 3
)

3 4
;

4 5
	CreateMap 
< 
ActivityUpdateDto '
,' (
Activity) 1
>1 2
(2 3
)3 4
;4 5
	CreateMap 
< 
ActivityDeleteDto '
,' (
Activity) 1
>1 2
(2 3
)3 4
;4 5
} 	
} 
} Ã

ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Management/PropertyMasterProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /

Management/ 9
{ 
public 
class !
PropertyMasterProfile #
:$ %
Profile& -
{		 
public

 !
PropertyMasterProfile

	 
(

 
)

  
{ 
	CreateMap 
< 
PropertyMaster $
,$ %/
#PropertyMasterCreatePlotResponseDto& I
>I J
(J K
)K L
;L M
	CreateMap 
< '
PropertyMasterCreatePlotDto 1
,1 2
PropertyMaster3 A
>A B
(B C
)C D
;D E
	CreateMap 
< #
PropertyMasterUpdateDto -
,- .
PropertyMaster/ =
>= >
(> ?
)? @
;@ A
	CreateMap 
< /
#PropertyMasterUpdateLeaseDetailsDto 9
,9 :
PropertyMaster; I
>I J
(J K
)K L
;L M
} 	
} 
} ™

ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Management/CustomerMasterProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /

Management/ 9
{ 
public 
class !
CustomerMasterProfile #
:$ %
Profile& -
{ 
public		 !
CustomerMasterProfile			 
(		 
)		  
{

 
	CreateMap 
< 
CustomerMaster $
,$ %
CustomerMasterDto& 7
>7 8
(8 9
)9 :
;: ;
	CreateMap 
< #
CustomerMasterCreateDto -
,- .
CustomerMaster/ =
>= >
(> ?
)? @
;@ A
	CreateMap 
< #
CustomerMasterUpdateDto -
,- .
CustomerMaster/ =
>= >
(> ?
)? @
;@ A
	CreateMap 
< #
CustomerMasterDeleteDto -
,- .
CustomerMaster/ =
>= >
(> ?
)? @
;@ A
} 	
} 
} ∆	
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/TitleProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
{ 
public 
class 
TitleProfile 
: 
Profile $
{ 
public 
TitleProfile	 
( 
) 
{ 
	CreateMap 
< 
Title 
, 
TitleReadDto  
>  !
(! "
)" #
;# $
	CreateMap		 
<		 
TitleCreateDto		 $
,		$ %
Title		& +
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
TitleUpdateDto

 $
,

$ %
Title
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
TitleDeleteDto $
,$ %
Title& +
>+ ,
(, -
)- .
;. /
} 	
} 
} â

Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/SocialMediaProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
{ 
public 
class 
SocialMediaProfile  
:! "
Profile# *
{ 
public 
SocialMediaProfile	 
( 
) 
{ 
	CreateMap 
< 
SocialMedia !
,! "
SocialMediaReadDto# 5
>5 6
(6 7
)7 8
;8 9
	CreateMap

 
<

  
SocialMediaCreateDto

 *
,

* +
SocialMedia
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
SocialMediaUpdateDto *
,* +
SocialMedia, 7
>7 8
(8 9
)9 :
;: ;
	CreateMap 
<  
SocialMediaDeleteDto *
,* +
SocialMedia, 7
>7 8
(8 9
)9 :
;: ;
} 	
} 
} É

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/ResidentTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
;7 8
public 
class 
ResidentTypeProfile  
:! "
Profile# *
{ 
public 
ResidentTypeProfile 
( 
) 
{ 
	CreateMap 
< 
ResidentType 
, 
ResidentTypeReadDto  3
>3 4
(4 5
)5 6
;6 7
	CreateMap		 
<		 !
ResidentTypeCreateDto		 '
,		' (
ResidentType		) 5
>		5 6
(		6 7
)		7 8
;		8 9
	CreateMap

 
<

 !
ResidentTypeUpdateDto

 '
,

' (
ResidentType

) 5
>

5 6
(

6 7
)

7 8
;

8 9
	CreateMap 
< !
ResidentTypeDeleteDto '
,' (
ResidentType) 5
>5 6
(6 7
)7 8
;8 9
} 
} ü

á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/OwnershipTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
{ 
public 
class  
OwnershipTypeProfile "
:# $
Profile% ,
{ 
public  
OwnershipTypeProfile	 
( 
) 
{ 
	CreateMap 
< 
OwnershipType #
,# $ 
OwnershipTypeReadDto% 9
>9 :
(: ;
); <
;< =
	CreateMap		 
<		 "
OwnershipTypeCreateDto		 ,
,		, -
OwnershipType		. ;
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
OwnershipTypeUpdateDto

 ,
,

, -
OwnershipType
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
OwnershipTypeDeleteDto ,
,, -
OwnershipType. ;
>; <
(< =
)= >
;> ?
} 	
} 
} ¯	
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/NationalityProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
;7 8
public 
class 
NationalityProfile 
:  !
Profile" )
{ 
public 
NationalityProfile 
( 
) 
{ 
	CreateMap 
< 
Nationality 
, 
NationalityReadDto 1
>1 2
(2 3
)3 4
;4 5
	CreateMap		 
<		  
NationalityCreateDto		 &
,		& '
Nationality		( 3
>		3 4
(		4 5
)		5 6
;		6 7
	CreateMap

 
<

  
NationalityUpdateDto

 &
,

& '
Nationality

( 3
>

3 4
(

4 5
)

5 6
;

6 7
	CreateMap 
<  
NationalityDeleteDto &
,& '
Nationality( 3
>3 4
(4 5
)5 6
;6 7
} 
} ≈

å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/IdentificationTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
;7 8
public 
class %
IdentificationTypeProfile &
:' (
Profile) 0
{ 
public %
IdentificationTypeProfile !
(! "
)" #
{ 
	CreateMap 
< 
IdentificationType $
,$ %%
IdentificationTypeReadDto& ?
>? @
(@ A
)A B
;B C
	CreateMap		 
<		 '
IdentificationTypeCreateDto		 -
,		- .
IdentificationType		/ A
>		A B
(		B C
)		C D
;		D E
	CreateMap

 
<

 '
IdentificationTypeUpdateDto

 -
,

- .
IdentificationType

/ A
>

A B
(

B C
)

C D
;

D E
	CreateMap 
< '
IdentificationTypeDeleteDto -
,- .
IdentificationType/ A
>A B
(B C
)C D
;D E
} 
} ¡	
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/GenderProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
;7 8
public 
class 
GenderProfile 
: 
Profile $
{ 
public 
GenderProfile 
( 
) 
{ 
	CreateMap 
< 
Gender 
, 
GenderReadDto '
>' (
(( )
)) *
;* +
	CreateMap		 
<		 
GenderCreateDto		 !
,		! "
Gender		# )
>		) *
(		* +
)		+ ,
;		, -
	CreateMap

 
<

 
GenderUpdateDto

 !
,

! "
Gender

# )
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
	CreateMap 
< 
GenderDeleteDto !
,! "
Gender# )
>) *
(* +
)+ ,
;, -
} 
} É

Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Customer/CustomerTypeProfile.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Profiles& .
.. /
Customer/ 7
;7 8
public 
class 
CustomerTypeProfile  
:! "
Profile# *
{ 
public 
CustomerTypeProfile 
( 
) 
{ 
	CreateMap 
< 
CustomerType 
, 
CustomerTypeReadDto  3
>3 4
(4 5
)5 6
;6 7
	CreateMap 
< !
CustomerTypeCreateDto '
,' (
CustomerType) 5
>5 6
(6 7
)7 8
;8 9
	CreateMap		 
<		 !
CustomerTypeUpdateDto		 '
,		' (
CustomerType		) 5
>		5 6
(		6 7
)		7 8
;		8 9
	CreateMap

 
<

 !
CustomerTypeDeleteDto

 '
,

' (
CustomerType

) 5
>

5 6
(

6 7
)

7 8
;

8 9
} 
} ﬂ
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ModuleServices/IModuleCommunicationServices.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
ModuleServices1 ?
{ 
public 
	interface (
IModuleCommunicationServices .
{ 
Task 
< 
bool 
> '
SendIdentificationTypeAsync .
(. /!
IdentificationTypeDto/ D
payloadE L
)L M
;M N
Task

 
<

 
bool

 
>

 $
SendCustomerDetailsAsync

 +
(

+ ,$
OnlineCustomerDetailsDto

, D
payload

E L
)

L M
;

M N
Task 
< 
bool 
> $
SendPropertyDetailsAsync +
(+ ,$
OnlinePropertyDetailsDto, D
payloadE L
)L M
;M N
} 
} Á
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/Property/IPropertyMasterService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1

Management1 ;
.; <
Property< D
{ 
public 
	interface "
IPropertyMasterService (
{		 
Task

 
<

 /
#PropertyMasterCreatePlotResponseDto

 0
>

0 1
CreateProperty

2 @
(

@ A'
PropertyMasterCreatePlotDto

A \
values

] c
)

c d
;

d e
Task 
< 
IEnumerable 
< 
PropertyMasterDto *
>* +
>+ ,
GetProperties- :
(: ;
int; >

localityId? I
)I J
;J K
} 
} È$
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/Customer/ICustomerMasterService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1

Management1 ;
.; <
Customer< D
{ 
public 
	interface "
ICustomerMasterService (
{ 
Task		 
<		 +
CustomerRegistrationResponseDto		 ,
>		, -
CreateCustomer		. <
(		< ="
ProspectiveCustomerDto		= S
values		T Z
)		Z [
;		[ \
Task

 
<

 +
CustomerRegistrationResponseDto

 ,
>

, -
CreateCustomer

. <
(

< =$
CreateCompanyCustomerDto

= U
values

V \
)

\ ]
;

] ^
Task 
< +
CustomerRegistrationResponseDto ,
>, -
CreateCustomer. <
(< =)
IndividualResidentCustomerDto= Z
values[ a
)a b
;b c
Task 
< +
CustomerRegistrationResponseDto ,
>, -
CreateCustomer. <
(< =%
JointOwnershipCustomerDto= V
valuesW ]
)] ^
;^ _
Task 
< +
CustomerRegistrationResponseDto ,
>, -
CreateCustomer. <
(< =%
MultiOwnershipCustomerDto= V
valuesW ]
)] ^
;^ _
Task 
< 
CustomerMasterDto 
> 
GetCustomer  +
(+ ,
string, 2
customerCode3 ?
)? @
;@ A
Task 
< *
ProspectiveCustomerResponseDto +
>+ ,)
GetProspectiveCustomerDetails- J
(J K
stringK Q
customerCodeR ^
)^ _
;_ `
Task 
< &
CompanyCustomerResponseDto '
>' (%
GetCompanyCustomerDetails) B
(B C
stringC I
customerCodeJ V
)V W
;W X
Task 
< 1
%IndividualResidentCustomerResponseDto 2
>2 3(
GetIndividualCustomerDetails4 P
(P Q
stringQ W
customerCodeX d
)d e
;e f
Task 
< -
!JointOwnershipCustomerResponseDto .
>. /#
GetJointCustomerDetails0 G
(G H
stringH N
customerCodeO [
)[ \
;\ ]
Task 
< -
!MultiOwnershipCustomerResponseDto .
>. /#
GetMultiCustomerDetails0 G
(G H
stringH N
customerCodeO [
)[ \
;\ ]
Task 
< 
IEnumerable 
< 
CustomerListDto (
>( )
>) * 
GetCustomerListAsync+ ?
(? @
)@ A
;A B
Task 
< 
IEnumerable 
< 
CustomerListDto (
>( )
>) *'
GetPendingCustomerListAsync+ F
(F G
)G H
;H I
Task 
< +
CustomerRegistrationResponseDto ,
>, -
UpdateCustomer. <
(< =$
UpdateCompanyCustomerDto= U
valuesV \
)\ ]
;] ^
Task 
< +
CustomerRegistrationResponseDto ,
>, -
UpdateCustomer. <
(< =/
#UpdateIndividualResidentCustomerDto= `
valuesa g
)g h
;h i
Task 
< +
CustomerRegistrationResponseDto ,
>, -
UpdateCustomer. <
(< =+
UpdateJointOwnershipCustomerDto= \
values] c
)c d
;d e
Task 
< +
CustomerRegistrationResponseDto ,
>, -
UpdateCustomer. <
(< =+
UpdateMultiOwnershipCustomerDto= \
values] c
)c d
;d e
Task   
<   
int   
>   
DeleteCustomerAsync   %
(  % &$
DeleteCustomerRequestDto  & >
values  ? E
)  E F
;  F G
Task"" 
<"" 
int"" 
>"" "
StopCustomerDebitAsync"" (
(""( )
StopDebitRequestDto"") <
values""= C
)""C D
;""D E
}$$ 
}%% ´
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPropertyTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface  
IPropertyTypeService %
{ 
Task 
< 	
PropertyTypeReadDto	 
>  
AddPropertyTypeAsync 2
(2 3!
PropertyTypeCreateDto3 H
valuesI O
)O P
;P Q
Task 
< 	
PropertyTypeReadDto	 
> #
UpdatePropertyTypeAsync 5
(5 6!
PropertyTypeUpdateDto6 K
valuesL R
)R S
;S T
Task 
< 	
IEnumerable	 
< 
PropertyTypeReadDto (
>( )
>) * 
GetPropertyTypeAsync+ ?
(? @
)@ A
;A B
Task 
< 	
PropertyTypeReadDto	 
>  
GetPropertyTypeAsync 2
(2 3
int3 6
value7 <
)< =
;= >
Task		 
<		 	
PropertyTypeReadDto			 
>		  
GetPropertyTypeAsync		 2
(		2 3
string		3 9
value		: ?
)		? @
;		@ A
}

 «
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPropertyHeightService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface "
IPropertyHeightService '
{ 
Task 
< 	!
PropertyHeightReadDto	 
> "
AddPropertyHeightAsync  6
(6 7#
PropertyHeightCreateDto7 N
valuesO U
)U V
;V W
Task 
< 	!
PropertyHeightReadDto	 
> %
UpdatePropertyHeightAsync  9
(9 :#
PropertyHeightUpdateDto: Q
valuesR X
)X Y
;Y Z
Task 
< 	
IEnumerable	 
< !
PropertyHeightReadDto *
>* +
>+ ,"
GetPropertyHeightAsync- C
(C D
)D E
;E F
Task 
< 	!
PropertyHeightReadDto	 
> "
GetPropertyHeightAsync  6
(6 7
int7 :
value; @
)@ A
;A B
Task		 
<		 	!
PropertyHeightReadDto			 
>		 "
GetPropertyHeightAsync		  6
(		6 7
string		7 =
value		> C
)		C D
;		D E
}

 Û
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPlotSizeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IPlotSizeService !
{ 
Task 
< 	
PlotSizeReadDto	 
> 
AddPlotSizeAsync *
(* +
PlotSizeCreateDto+ <
values= C
)C D
;D E
Task 
< 	
PlotSizeReadDto	 
> 
UpdatePlotSizeAsync -
(- .
PlotSizeUpdateDto. ?
values@ F
)F G
;G H
Task 
< 	
IEnumerable	 
< 
PlotSizeReadDto $
>$ %
>% &
GetPlotSizeAsync' 7
(7 8
)8 9
;9 :
Task		 
<		 	
PlotSizeReadDto			 
>		 
GetPlotSizeAsync		 *
(		* +
int		+ .
value		/ 4
)		4 5
;		5 6
Task

 
<

 	
PlotSizeReadDto

	 
>

 
GetPlotSizeAsync

 *
(

* +
string

+ 1
value

2 7
)

7 8
;

8 9
} ¨
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILocalityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
ILocalityService !
{ 
Task 
< 	
LocalityReadDto	 
> 
CreateLocalityAsync -
(- .
LocalityCreateDto. ?
values@ F
)F G
;G H
Task 
< 	
LocalityReadDto	 
> 
UpdateLocalityAsync -
(- .
LocalityUpdateDto. ?
values@ F
)F G
;G H
Task 
< 	
IEnumerable	 
< 
LocalityReadDto $
>$ %
>% &
GetLocalityAsync' 7
(7 8
)8 9
;9 :
Task		 
<		 	
LocalityReadDto			 
>		 
GetLocalityAsync		 *
(		* +
int		+ .
value		/ 4
)		4 5
;		5 6
Task

 
<

 	
LocalityReadDto

	 
>

 
GetLocalityAsync

 *
(

* +
string

+ 1
value

2 7
)

7 8
;

8 9
Task 
< 	
string	 
> 
DeleteLocality 
(  
int  #

localityId$ .
). /
;/ 0
} ù
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILandUseTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
ILandUseTypeService $
{ 
Task 
< 	
LandUseTypeReadDto	 
> 
AddLandUseTypeAsync 0
(0 1 
LandUseTypeCreateDto1 E
valuesF L
)L M
;M N
Task 
< 	
LandUseTypeReadDto	 
> "
UpdateLandUseTypeAsync 3
(3 4 
LandUseTypeUpdateDto4 H
valuesI O
)O P
;P Q
Task 
< 	
IEnumerable	 
< 
LandUseTypeReadDto '
>' (
>( )
GetLandUseTypeAsync* =
(= >
)> ?
;? @
Task		 
<		 	
LandUseTypeReadDto			 
>		 
GetLandUseTypeAsync		 0
(		0 1
int		1 4
value		5 :
)		: ;
;		; <
Task

 
<

 	
LandUseTypeReadDto

	 
>

 
GetLandUseTypeAsync

 0
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
} Â
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/ILandUseService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
ILandUseService  
{ 
Task 
< 
LandUseReadDto 
> 
AddLandUseAsync %
(% &
LandUseCreateDto& 6
values7 =
)= >
;> ?
Task 
< 	
LandUseReadDto	 
> 
UpdateLandUseAsync +
(+ ,
LandUseUpdateDto, <
values= C
)C D
;D E
Task 
< 	
IEnumerable	 
< 
LandUseReadDto #
># $
>$ %
GetLandUseAsync& 5
(5 6
)6 7
;7 8
Task 
< 	
LandUseReadDto	 
> 
GetLandUseAsync (
(( )
int) ,
value- 2
)2 3
;3 4
Task		 
<		 	
LandUseReadDto			 
>		 
GetLandUseAsync		 (
(		( )
string		) /
value		0 5
)		5 6
;		6 7
}

 «
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFloorNumberingService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface "
IFloorNumberingService '
{ 
Task 
< 	!
FloorNumberingReadDto	 
> "
AddFloorNumberingAsync  6
(6 7#
FloorNumberingCreateDto7 N
valuesO U
)U V
;V W
Task 
< 	!
FloorNumberingReadDto	 
> %
UpdateFloorNumberingAsync  9
(9 :#
FloorNumberingUpdateDto: Q
valuesR X
)X Y
;Y Z
Task 
< 	
IEnumerable	 
< !
FloorNumberingReadDto *
>* +
>+ ,"
GetFloorNumberingAsync- C
(C D
)D E
;E F
Task 
< 	!
FloorNumberingReadDto	 
> "
GetFloorNumberingAsync  6
(6 7
int7 :
value; @
)@ A
;A B
Task		 
<		 	!
FloorNumberingReadDto			 
>		 "
GetFloorNumberingAsync		  6
(		6 7
string		7 =
value		> C
)		C D
;		D E
}

 è
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IFacilitiesService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IFacilitiesService #
{ 
Task 
< 	
FacilitiesReadDto	 
> 
AddFacilitiesAsync .
(. /
FacilitiesCreateDto/ B
valuesC I
)I J
;J K
Task 
< 	
FacilitiesReadDto	 
> !
UpdateFacilitiesAsync 1
(1 2
FacilitiesUpdateDto2 E
valuesF L
)L M
;M N
Task 
< 	
IEnumerable	 
< 
FacilitiesReadDto &
>& '
>' (
GetFacilitiesAsync) ;
(; <
)< =
;= >
Task 
< 	
FacilitiesReadDto	 
> 
GetFacilitiesAsync .
(. /
int/ 2
value3 8
)8 9
;9 :
Task		 
<		 	
FacilitiesReadDto			 
>		 
GetFacilitiesAsync		 .
(		. /
string		/ 5
value		6 ;
)		; <
;		< =
}

 Å
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IBlockUnitService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IBlockUnitService "
{ 
Task 
< 	
BlockUnitReadDto	 
> 
AddBlockUnitAsync ,
(, -
BlockUnitCreateDto- ?
values@ F
)F G
;G H
Task 
< 	
BlockUnitReadDto	 
>  
UpdateBlockUnitAsync /
(/ 0
BlockUnitUpdateDto0 B
valuesC I
)I J
;J K
Task 
< 	
IEnumerable	 
< 
BlockUnitReadDto %
>% &
>& '
GetBlockUnitAsync( 9
(9 :
): ;
;; <
Task 
< 	
BlockUnitReadDto	 
> 
GetBlockUnitAsync ,
(, -
int- 0
value1 6
)6 7
;7 8
Task		 
<		 	
BlockUnitReadDto			 
>		 
GetBlockUnitAsync		 ,
(		, -
string		- 3
value		4 9
)		9 :
;		: ;
}

 Å
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IBlockTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IBlockTypeService "
{ 
Task 
< 	
BlockTypeReadDto	 
> 
AddBlockTypeAsync ,
(, -
BlockTypeCreateDto- ?
values@ F
)F G
;G H
Task 
< 	
BlockTypeReadDto	 
>  
UpdateBlockTypeAsync /
(/ 0
BlockTypeUpdateDto0 B
valuesC I
)I J
;J K
Task 
< 	
IEnumerable	 
< 
BlockTypeReadDto %
>% &
>& '
GetBlockTypeAsync( 9
(9 :
): ;
;; <
Task 
< 	
BlockTypeReadDto	 
> 
GetBlockTypeAsync ,
(, -
int- 0
value1 6
)6 7
;7 8
Task		 
<		 	
BlockTypeReadDto			 
>		 
GetBlockTypeAsync		 ,
(		, -
string		- 3
value		4 9
)		9 :
;		: ;
}

 Å
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IBlockSideService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IBlockSideService "
{ 
Task 
< 	
BlockSideReadDto	 
> 
AddBlockSideAsync ,
(, -
BlockSideCreateDto- ?
values@ F
)F G
;G H
Task 
< 	
BlockSideReadDto	 
>  
UpdateBlockSideAsync /
(/ 0
BlockSideUpdateDto0 B
valuesC I
)I J
;J K
Task 
< 	
IEnumerable	 
< 
BlockSideReadDto %
>% &
>& '
GetBlockSideAsync( 9
(9 :
): ;
;; <
Task 
< 	
BlockSideReadDto	 
> 
GetBlockSideAsync ,
(, -
int- 0
value1 6
)6 7
;7 8
Task		 
<		 	
BlockSideReadDto			 
>		 
GetBlockSideAsync		 ,
(		, -
string		- 3
value		4 9
)		9 :
;		: ;
}

 ù
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IBlockNumberService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface 
IBlockNumberService $
{ 
Task 
< 	
BlockNumberReadDto	 
> 
AddBlockNumberAsync 0
(0 1 
BlockNumberCreateDto1 E
valuesF L
)L M
;M N
Task 
< 	
BlockNumberReadDto	 
> "
UpdateBlockNumberAsync 3
(3 4 
BlockNumberUpdateDto4 H
valuesI O
)O P
;P Q
Task 
< 	
IEnumerable	 
< 
BlockNumberReadDto '
>' (
>( )
GetBlockNumberAsync* =
(= >
)> ?
;? @
Task 
< 	
BlockNumberReadDto	 
> 
GetBlockNumberAsync 0
(0 1
int1 4
value5 :
): ;
;; <
Task		 
<		 	
BlockNumberReadDto			 
>		 
GetBlockNumberAsync		 0
(		0 1
string		1 7
value		8 =
)		= >
;		> ?
}

 π
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IApartmentTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface !
IApartmentTypeService &
{ 
Task 
< 	 
ApartmentTypeReadDto	 
> !
AddApartmentTypeAsync 4
(4 5"
ApartmentTypeCreateDto5 K
valuesL R
)R S
;S T
Task 
< 	 
ApartmentTypeReadDto	 
> $
UpdateApartmentTypeAsync 7
(7 8"
ApartmentTypeUpdateDto8 N
valuesO U
)U V
;V W
Task 
< 	
IEnumerable	 
<  
ApartmentTypeReadDto )
>) *
>* +!
GetApartmentTypeAsync, A
(A B
)B C
;C D
Task 
< 	 
ApartmentTypeReadDto	 
> !
GetApartmentTypeAsync 4
(4 5
int5 8
value9 >
)> ?
;? @
Task		 
<		 	 
ApartmentTypeReadDto			 
>		 !
GetApartmentTypeAsync		 4
(		4 5
string		5 ;
value		< A
)		A B
;		B C
}

 «
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IAllocationTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
;H I
public 
	interface "
IAllocationTypeService '
{ 
Task 
< 	!
AllocationTypeReadDto	 
> "
AddAllocationTypeAsync  6
(6 7#
AllocationTypeCreateDto7 N
valuesO U
)U V
;V W
Task 
< 	!
AllocationTypeReadDto	 
> %
UpdateAllocationTypeAsync  9
(9 :#
AllocationTypeUpdateDto: Q
valuesR X
)X Y
;Y Z
Task 
< 	
IEnumerable	 
< !
AllocationTypeReadDto *
>* +
>+ ,"
GetAllocationTypeAsync- C
(C D
)D E
;E F
Task 
< 	!
AllocationTypeReadDto	 
> "
GetAllocationTypeAsync  6
(6 7
int7 :
value; @
)@ A
;A B
Task		 
<		 	!
AllocationTypeReadDto			 
>		 "
GetAllocationTypeAsync		  6
(		6 7
string		7 =
value		> C
)		C D
;		D E
}

 ¯

ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IActivityTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
{ 
public 
	interface  
IActivityTypeService &
{ 
Task 
< 
ActivityTypeReadDto  
>  !#
CreateActivityTypeAsync" 9
(9 :!
ActivityTypeCreateDto: O
valuesP V
)V W
;W X
Task 
< 
ActivityTypeReadDto  
>  !#
UpdateActivityTypeAsync" 9
(9 :!
ActivityTypeUpdateDto: O
valuesP V
)V W
;W X
Task 
< 
IEnumerable 
< 
ActivityTypeReadDto ,
>, -
>- . 
GetActivityTypeAsync/ C
(C D
)D E
;E F
Task		 
<		 
ActivityTypeReadDto		  
>		  ! 
GetActivityTypeAsync		" 6
(		6 7
int		7 :
value		; @
)		@ A
;		A B
} 
}  

î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IActivityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Property@ H
{ 
public 
	interface 
IActivityService "
{ 
Task 
< 
ActivityReadDto 
> 
CreateActivityAsync 1
(1 2
ActivityCreateDto2 C
valuesD J
)J K
;K L
Task 
< 
ActivityReadDto 
> 
UpdateActivityAsync 1
(1 2
ActivityUpdateDto2 C
valuesD J
)J K
;K L
Task 
< 
IEnumerable 
< 
ActivityReadDto (
>( )
>) *
GetActivitiesAsync+ =
(= >
)> ?
;? @
Task		 
<		 
ActivityReadDto		 
>		 
GetActivityAsync		 .
(		. /
int		/ 2
value		3 8
)		8 9
;		9 :
} 
} ¸
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/ITitleService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface 
ITitleService 
{ 
Task 
< 	
TitleReadDto	 
> 
AddTitleAsync $
($ %
TitleCreateDto% 3
values4 :
): ;
;; <
Task 
< 	
TitleReadDto	 
> 
UpdateTitleAsync '
(' (
TitleUpdateDto( 6
values7 =
)= >
;> ?
Task 
< 	
IEnumerable	 
< 
TitleReadDto !
>! "
>" #
GetTitleAsync$ 1
(1 2
)2 3
;3 4
Task 
< 	
TitleReadDto	 
> 
GetTitleAsync $
($ %
int% (
value) .
). /
;/ 0
Task		 
<		 	
TitleReadDto			 
>		 
GetTitleAsync		 $
(		$ %
string		% +
value		, 1
)		1 2
;		2 3
Task 
< 	
string	 
> 
DeleteTitleAsync !
(! "
int" %
value& +
)+ ,
;, -
} ÷
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/ISocialMediaService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface 
ISocialMediaService $
{ 
Task 
< 	
SocialMediaReadDto	 
> 
AddSocialMediaAsync 0
(0 1 
SocialMediaCreateDto1 E
valuesF L
)L M
;M N
Task 
< 	
SocialMediaReadDto	 
> "
UpdateSocialMediaAsync 3
(3 4 
SocialMediaUpdateDto4 H
valuesI O
)O P
;P Q
Task 
< 	
IEnumerable	 
< 
SocialMediaReadDto '
>' (
>( )
GetSocialMediaAsync* =
(= >
)> ?
;? @
Task 
< 	
SocialMediaReadDto	 
> 
GetSocialMediaAsync 0
(0 1
int1 4
value5 :
): ;
;; <
Task		 
<		 	
SocialMediaReadDto			 
>		 
GetSocialMediaAsync		 0
(		0 1
string		1 7
value		8 =
)		= >
;		> ?
Task 
< 	
string	 
> "
DeleteSocialMediaAsync '
(' (
int( +
value, 1
)1 2
;2 3
} Â
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/IResidentTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface  
IResidentTypeService %
{ 
Task 
< 	
ResidentTypeReadDto	 
>  
AddResidentTypeAsync 2
(2 3!
ResidentTypeCreateDto3 H
valuesI O
)O P
;P Q
Task 
< 	
ResidentTypeReadDto	 
> #
UpdateResidentTypeAsync 5
(5 6!
ResidentTypeUpdateDto6 K
valuesL R
)R S
;S T
Task 
< 	
IEnumerable	 
< 
ResidentTypeReadDto (
>( )
>) * 
GetResidentTypeAsync+ ?
(? @
)@ A
;A B
Task 
< 	
ResidentTypeReadDto	 
>  
GetResidentTypeAsync 2
(2 3
int3 6
value7 <
)< =
;= >
Task		 
<		 	
ResidentTypeReadDto			 
>		  
GetResidentTypeAsync		 2
(		2 3
string		3 9
value		: ?
)		? @
;		@ A
Task 
< 	
string	 
> #
DeleteResidentTypeAsync (
(( )
int) ,
value- 2
)2 3
;3 4
} Ö
ô/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/IOwnershipTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
{ 
public 
	interface !
IOwnershipTypeService '
{ 
Task 
<  
OwnershipTypeReadDto !
>! "!
AddOwnershipTypeAsync# 8
(8 9"
OwnershipTypeCreateDto9 O
valuesP V
)V W
;W X
Task 
<  
OwnershipTypeReadDto !
>! "$
UpdateOwnershipTypeAsync# ;
(; <"
OwnershipTypeUpdateDto< R
valuesS Y
)Y Z
;Z [
Task 
< 
IEnumerable 
<  
OwnershipTypeReadDto -
>- .
>. /!
GetOwnershipTypeAsync0 E
(E F
)F G
;G H
Task

 
<

  
OwnershipTypeReadDto

 !
>

! "!
GetOwnershipTypeAsync

# 8
(

8 9
int

9 <
value

= B
)

B C
;

C D
Task 
<  
OwnershipTypeReadDto !
>! "!
GetOwnershipTypeAsync# 8
(8 9
string9 ?
value@ E
)E F
;F G
Task 
< 
string 
> $
DeleteOwnershipTypeAsync -
(- .
int. 1
value2 7
)7 8
;8 9
} 
} ÷
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/INationalityService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface 
INationalityService $
{ 
Task 
< 	
NationalityReadDto	 
> 
AddNationalityAsync 0
(0 1 
NationalityCreateDto1 E
valuesF L
)L M
;M N
Task 
< 	
NationalityReadDto	 
> "
UpdateNationalityAsync 3
(3 4 
NationalityUpdateDto4 H
valuesI O
)O P
;P Q
Task 
< 	
IEnumerable	 
< 
NationalityReadDto '
>' (
>( )
GetNationalityAsync* =
(= >
)> ?
;? @
Task 
< 	
NationalityReadDto	 
> 
GetNationalityAsync 0
(0 1
int1 4
value5 :
): ;
;; <
Task		 
<		 	
NationalityReadDto			 
>		 
GetNationalityAsync		 0
(		0 1
string		1 7
value		8 =
)		= >
;		> ?
Task 
< 	
string	 
> "
DeleteNationalityAsync '
(' (
int( +
value, 1
)1 2
;2 3
} ø
û/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/IIdentificationTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface &
IIdentificationTypeService +
{ 
Task 
< 	%
IdentificationTypeReadDto	 "
>" #&
AddIdentificationTypeAsync$ >
(> ?'
IdentificationTypeCreateDto? Z
values[ a
)a b
;b c
Task 
< 	%
IdentificationTypeReadDto	 "
>" #)
UpdateIdentificationTypeAsync$ A
(A B'
IdentificationTypeUpdateDtoB ]
values^ d
)d e
;e f
Task 
< 	
IEnumerable	 
< %
IdentificationTypeReadDto .
>. /
>/ 0&
GetIdentificationTypeAsync1 K
(K L
)L M
;M N
Task 
< 	%
IdentificationTypeReadDto	 "
>" #&
GetIdentificationTypeAsync$ >
(> ?
int? B
valueC H
)H I
;I J
Task		 
<		 	%
IdentificationTypeReadDto			 "
>		" #&
GetIdentificationTypeAsync		$ >
(		> ?
string		? E
value		F K
)		K L
;		L M
Task 
< 	
string	 
> )
DeleteIdentificationTypeAsync .
(. /
int/ 2
value3 8
)8 9
;9 :
} ã
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/IGenderService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface 
IGenderService 
{ 
Task 
< 	
GenderReadDto	 
> 
AddGenderAsync &
(& '
GenderCreateDto' 6
values7 =
)= >
;> ?
Task 
< 	
GenderReadDto	 
> 
UpdateGenderAsync )
() *
GenderUpdateDto* 9
values: @
)@ A
;A B
Task 
< 	
IEnumerable	 
< 
GenderReadDto "
>" #
># $
GetGenderAsync% 3
(3 4
)4 5
;5 6
Task 
< 	
GenderReadDto	 
> 
GetGenderAsync &
(& '
int' *
value+ 0
)0 1
;1 2
Task		 
<		 	
GenderReadDto			 
>		 
GetGenderAsync		 &
(		& '
string		' -
value		. 3
)		3 4
;		4 5
Task 
< 	
string	 
> 
DeleteGenderAsync "
(" #
int# &
value' ,
), -
;- .
} ‰
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Customer/ICustomerTypeService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &

Interfaces& 0
.0 1
Entities1 9
.9 :
Setup: ?
.? @
Customer@ H
;H I
public 
	interface  
ICustomerTypeService %
{ 
Task 
< 	
CustomerTypeReadDto	 
>  
AddCustomerTypeAsync 2
(2 3!
CustomerTypeCreateDto3 H
valuesI O
)O P
;P Q
Task 
< 	
CustomerTypeReadDto	 
> #
UpdateCustomerTypeAsync 5
(5 6!
CustomerTypeUpdateDto6 K
valuesL R
)R S
;S T
Task 
< 	
IEnumerable	 
< 
CustomerTypeReadDto (
>( )
>) * 
GetCustomerTypeAsync+ ?
(? @
)@ A
;A B
Task 
< 	
CustomerTypeReadDto	 
>  
GetCustomerTypeAsync 2
(2 3
int3 6
value7 <
)< =
;= >
Task		 
<		 	
CustomerTypeReadDto			 
>		  
GetCustomerTypeAsync		 2
(		2 3
string		3 9
value		: ?
)		? @
;		@ A
Task 
< 	
string	 
> "
DeleteCustomerTyeAsync '
(' (
int( +
value, 1
)1 2
;2 3
} ã
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Enums/ResidentTypeEnum.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Enums& +
{ 
public 
enum 
ResidentTypeEnum 
{ 
[ 	
Description	 
( 
$str !
)! "
]" #

EXPATRIATE		 
=		 
$num		 
,		 
[ 	
Description	 
( 
$str #
)# $
]$ %
NON_RESIDENT 
= 
$num 
, 
[ 	
Description	 
( 
$str 
)  
]  !
RESIDENT 
= 
$num 
} 
} ·
x/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Enums/MaritalStatusEnum.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Enums& +
{ 
public 
enum 
MaritalStatusEnum 
{ 
[ 	
Description	 
( 
$str 
) 
]  
MARRIED		 
=		 
$num		 
,		 
[ 	
Description	 
( 
$str (
)( )
]) *
CIVIL_PARTNERSHI 
= 
$num 
} 
} Ò	
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Enums/CustomerTypeEnum.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Enums& +
{ 
public 
enum 
CustomerTypeEnum 
{ 
[ 	
Description	 
( 
$str 
) 
]  
COMPANY		 
=		 
$num		 
,		 
[ 	
Description	 
( 
$str !
)! "
]" #

INDIVIDUAL 
= 
$num 
, 
[ 	
Description	 
( 
$str &
)& '
]' (
JOINT_OWNERSHIP 
= 
$num 
, 
[ 	
Description	 
( 
$str &
)& '
]' (
MULTI_OWNERSHIP 
= 
$num 
, 
[ 	
Description	 
( 
$str "
)" #
]# $
PROSPECTIVE 
= 
$num 
} 
} ´

É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PropertyTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
PropertyTypeReadDto !
(! "
int" %
PropertyTypeId& 4
,4 5
string6 <
PropertyTypes= J
)J K
;K L
public 
record !
PropertyTypeCreateDto #
(# $
int$ '
PropertyTypeId( 6
,6 7
string8 >
PropertyTypes? L
,L M
stringN T
	CreatedByU ^
)^ _
;_ `
public 
record !
PropertyTypeUpdateDto #
(# $
int$ '
PropertyTypeId( 6
,6 7
string8 >
PropertyTypes? L
,L M
stringN T

ModifiedByU _
)_ `
;` a
public 
record !
PropertyTypeDeleteDto #
(# $
int$ '
PropertyTypeId( 6
)6 7
;7 8√

Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PropertyHeightDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record !
PropertyHeightReadDto #
(# $
int$ '
propertyHeightId( 8
,8 9
string: @
propertyHeightsA P
)P Q
;Q R
public 
record #
PropertyHeightCreateDto %
(% &
int& )
propertyHeightId* :
,: ;
string< B
propertyHeightsC R
,R S
stringT Z
	createdBy[ d
)d e
;e f
public 
record #
PropertyHeightUpdateDto %
(% &
int& )
propertyHeightId* :
,: ;
string< B
propertyHeightsC R
,R S
stringT Z

modifiedBy[ e
)e f
;f g
public 
record #
PropertyHeightDeleteDto %
(% &
int& )
propertyHeightId* :
): ;
;; <˘	
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PlotSizeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
PlotSizeReadDto 
( 
int !

PlotSizeId" ,
,, -
string. 4
	PlotSizes5 >
)> ?
;? @
public 
record 
PlotSizeCreateDto 
(  
int  #

PlotSizeId$ .
,. /
string0 6
	PlotSizes7 @
,@ A
stringB H
	CreatedByI R
)R S
;S T
public 
record 
PlotSizeUpdateDto 
(  
int  #

PlotSizeId$ .
,. /
string0 6
	PlotSizes7 @
,@ A
stringB H

ModifiedByI S
)S T
;T U
public 
record 
PlotSizDeleteDto 
( 
int "

PlotSizeId# -
)- .
;. /ÿ
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/LocalityDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
LocalityReadDto 
( 
int !

LocalityId" ,
,, -
string. 4
LocalityInitial5 D
,D E
stringF L
LocalityNameM Y
,Y Z
string[ a
CustomerCodeb n
,n o
intp s 
CustomerCodeCounter	t á
)
á à
;
à â
public 
record 
LocalityCreateDto 
(  
int  #

LocalityId$ .
,. /
string0 6
LocalityInitial7 F
,F G
stringH N
LocalityNameO [
,[ \
string] c
CustomerCoded p
,p q
intr u 
CustomerCodeCounter	v â
,
â ä
string
ã ë
	CreatedBy
í õ
)
õ ú
;
ú ù
public 
record 
LocalityUpdateDto 
(  
int  #

LocalityId$ .
,. /
string0 6
LocalityInitial7 F
,F G
stringH N
LocalityNameO [
,[ \
string] c
CustomerCoded p
,p q
intr u 
CustomerCodeCounter	v â
,
â ä
string
ã ë

ModifiedBy
í ú
)
ú ù
;
ù û
public 
record 
LocalityDeleteDto 
(  
int  #

LocalityId$ .
). /
;/ 0ú
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/LandUseTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
LandUseTypeReadDto  
(  !
int! $
	LandUseId% .
,. /
int0 3
LandUseTypeId4 A
,A B
stringC I
LandUseTypeInitialJ \
,\ ]
string^ d
LandUseTypeNamee t
)t u
;u v
public 
record  
LandUseTypeCreateDto "
(" #
int# &
	LandUseId' 0
,0 1
int2 5
LandUseTypeId6 C
,C D
stringE K
LandUseTypeInitialL ^
,^ _
string` f
LandUseTypeNameg v
,v w
stringx ~
	CreatedBy	 à
)
à â
;
â ä
public 
record  
LandUseTypeUpdateDto "
(" #
int# &
	LandUseId' 0
,0 1
int2 5
LandUseTypeId6 C
,C D
stringE K
LandUseTypeInitialL ^
,^ _
string` f
LandUseTypeNameg v
,v w
stringx ~

ModifiedBy	 â
)
â ä
;
ä ã
public 
record  
LandUseTypeDeleteDto "
(" #
int# &
	LandUseId' 0
)0 1
;1 2
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/LandUseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
LandUseReadDto 
( 
int  
	LandUseId! *
,* +
string, 2
LandUseInitial3 A
,A B
stringC I
LandUseNameJ U
)U V
;V W
public 
record 
LandUseCreateDto 
( 
int "
	LandUseId# ,
,, -
string. 4
?4 5
LandUseInitial6 D
,D E
stringF L
?L M
LandUseNameN Y
,Y Z
string[ a
	CreatedByb k
)k l
;l m
public 
record 
LandUseUpdateDto 
( 
int "
	LandUseId# ,
,, -
string. 4
?4 5
LandUseInitial6 D
,D E
stringF L
?L M
LandUseNameN Y
,Y Z
string[ a

ModifiedByb l
)l m
;m n
public 
record 
LandUseDeleteDto 
( 
int "
	LandUseId# ,
), -
;- .©

Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/FloorNumberingDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record !
FloorNumberingReadDto #
(# $
int$ '
floorNumberId( 5
,5 6
string7 =
floorNumber> I
)I J
;J K
public 
record #
FloorNumberingCreateDto %
(% &
int& )
floorNumberId* 7
,7 8
string9 ?
floorNumber@ K
,K L
stringM S
	createdbyT ]
)] ^
;^ _
public 
record #
FloorNumberingUpdateDto %
(% &
int& )
floorNumberId* 7
,7 8
string9 ?
floorNumber@ K
,K L
stringM S
modifiedT \
)\ ]
;] ^
public 
record #
FloorNumberingDeleteDto %
(% &
int& )
floorNumberId* 7
)7 8
;8 9Ç

Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/FacilitiesDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
FacilitiesReadDto 
(  
int  #

facilityId$ .
,. /
string0 6
facility7 ?
)? @
;@ A
public 
record 
FacilitiesCreateDto !
(! "
int" %

facilityId& 0
,0 1
string2 8
facility9 A
,A B
stringC I
	createdByJ S
)S T
;T U
public 
record 
FacilitiesUpdateDto !
(! "
int" %

facilityId& 0
,0 1
string2 8
facility9 A
,A B
stringC I

modifiedByJ T
)T U
;U V
public 
record 
FacilitiesDeleteDto !
(! "
int" %

facilityId& 0
)0 1
;1 2·	
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/BlockUnitDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
BlockUnitReadDto 
( 
int "
unitId# )
,) *
string+ 1
unit2 6
)6 7
;7 8
public 
record 
BlockUnitCreateDto  
(  !
int! $
unitId% +
,+ ,
string- 3
unit4 8
,8 9
string: @
	createdbyA J
)J K
;K L
public 
record 
BlockUnitUpdateDto  
(  !
int! $
unitId% +
,+ ,
string- 3
unit4 8
,8 9
string: @

modifiedbyA K
)K L
;L M
public 
record 
BlockUnitDeleteDto  
(  !
int! $
unitId% +
)+ ,
;, -Ñ

Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/BlockTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
BlockTypeReadDto 
( 
int "
blockTypeId# .
,. /
string0 6
	blockType7 @
)@ A
;A B
public 
record 
BlockTypeCreateDto  
(  !
int! $
blockTypeId% 0
,0 1
string2 8
	blockType9 B
,B C
stringD J
	createdbyK T
)T U
;U V
public 
record 
BlockTypeUpdateDto  
(  !
int! $
blockTypeId% 0
,0 1
string2 8
	blockType9 B
,B C
stringD J

modifiedbyK U
)U V
;V W
public 
record 
BlockTypeDeleteDto  
(  !
int! $
blockTypeId% 0
)0 1
;1 2·	
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/BlockSideDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
BlockSideReadDto 
( 
int "
sideId# )
,) *
string+ 1
side2 6
)6 7
;7 8
public 
record 
BlockSideCreateDto  
(  !
int! $
sideId% +
,+ ,
string- 3
side4 8
,8 9
string: @
	createdbyA J
)J K
;K L
public 
record 
BlockSideUpdateDto  
(  !
int! $
sideId% +
,+ ,
string- 3
side4 8
,8 9
string: @

modifiedbyA K
)K L
;L M
public 
record 
BlockSideDeleteDto  
(  !
int! $
sideId% +
)+ ,
;, -ü

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/BlockNumberDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record 
BlockNumberReadDto  
(  !
int! $
blockNumberId% 2
,2 3
string4 :
blockNumbers; G
)G H
;H I
public 
record  
BlockNumberCreateDto "
(" #
int# &
blockNumberId' 4
,4 5
string6 <
blockNumbers= I
,I J
stringK Q
	createdbyR [
)[ \
;\ ]
public 
record  
BlockNumberUpdateDto "
(" #
int# &
blockNumberId' 4
,4 5
string6 <
blockNumbers= I
,I J
stringK Q

modifiedbyR \
)\ ]
;] ^
public 
record  
BlockNumberDeleteDto "
(" #
int# &
blockNumberId' 4
)4 5
;5 6Ÿ
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ApartmentTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record  
ApartmentTypeReadDto "
(" #
int# &
apartmentTypeId' 6
,6 7
string8 >
apartmentType? L
,L M
floatN S
sellingPriceT `
,` a
intb e

currencyIdf p
,p q
doubler x
	floorArea	y Ç
)
Ç É
;
É Ñ
public 
record "
ApartmentTypeCreateDto $
($ %
int% (
apartmentTypeId) 8
,8 9
string: @
apartmentTypeA N
,N O
floatP U
sellingPriceV b
,b c
intd g

currencyIdh r
,r s
doublet z
	floorArea	{ Ñ
,
Ñ Ö
string
Ü å
	createdBy
ç ñ
)
ñ ó
;
ó ò
public 
record "
ApartmentTypeUpdateDto $
($ %
int% (
apartmentTypeId) 8
,8 9
string: @
apartmentTypeA N
,N O
floatP U
sellingPriceV b
,b c
intd g

currencyIdh r
,r s
doublet z
	floorArea	{ Ñ
,
Ñ Ö
string
Ü å

modifiedBy
ç ó
)
ó ò
;
ò ô
public 
record "
ApartmentTypeDeleteDto $
($ %
int% (
apartmentTypeId) 8
)8 9
;9 :ü
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/AllocationTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
record !
AllocationTypeReadDto #
(# $
int$ '
AllocationTypeId( 8
,8 9
string: @!
AllocationTypeInitialA V
,V W
stringX ^
AllocationTypes_ n
)n o
;o p
public 
record #
AllocationTypeCreateDto %
(% &
int& )
AllocationTypeId* :
,: ;
string< B!
AllocationTypeInitialC X
,X Y
stringZ `
AllocationTypesa p
,p q
stringr x
	CreatedBy	y Ç
)
Ç É
;
É Ñ
public 
record #
AllocationTypeUpdateDto %
(% &
int& )
AllocationTypeId* :
,: ;
string< B!
AllocationTypeInitialC X
,X Y
stringZ `
AllocationTypesa p
,p q
stringr x

ModifiedBy	y É
)
É Ñ
;
Ñ Ö
public 
record #
AllocationTypeDeleteDto %
(% &
int& )
AllocationTypeId* :
): ;
;; <ﬁ
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ActivityTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
{ 
public 

record 
ActivityTypeReadDto %
(% &
int& )

ActivityId* 4
,4 5
int6 9
ActivityTypeId: H
,H I
stringJ P
ActivityTypeNameQ a
,a b
stringc i$
ActivityTypeDescription	j Å
)
Å Ç
;
Ç É
public 

record !
ActivityTypeCreateDto '
(' (
int( +

ActivityId, 6
,6 7
int8 ;
ActivityTypeId< J
,J K
stringL R
ActivityTypeNameS c
,c d
stringe k$
ActivityTypeDescription	l É
,
É Ñ
string
Ö ã
	CreatedBy
å ï
)
ï ñ
;
ñ ó
public 

record !
ActivityTypeUpdateDto '
(' (
int( +

ActivityId, 6
,6 7
int8 ;
ActivityTypeId< J
,J K
stringL R
ActivityTypeNameS c
,c d
stringe k$
ActivityTypeDescription	l É
,
É Ñ
string
Ö ã

ModifiedBy
å ñ
)
ñ ó
;
ó ò
public 

record !
ActivityTypeDeleteDto '
(' (
int( +

ActivityId, 6
)6 7
;7 8
} ‚
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/ActivityDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
record 
ActivityReadDto 
( 
int "

ActivityId# -
,- .
string/ 5
ActivityName6 B
,B C
stringD J
ActivityDescriptionK ^
)^ _
;_ `
public 

record 
ActivityCreateDto #
(# $
int$ '

ActivityId( 2
,2 3
string4 :
ActivityName; G
,G H
stringI O
ActivityDescriptionP c
,c d
stringe k
	CreatedByl u
)u v
;v w
public 

record 
ActivityUpdateDto #
(# $
int$ '

ActivityId( 2
,2 3
string4 :
ActivityName; G
,G H
stringI O
ActivityDescriptionP c
,c d
stringe k

ModifiedByl v
)v w
;w x
public 

record 
ActivityDeleteDto #
(# $
int$ '

ActivityId( 2
)2 3
;3 4
}		 ÷	
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/TitleDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
TitleReadDto 
( 
int 
titleId &
,& '
string( .
titles/ 5
)5 6
;6 7
public 
record 
TitleCreateDto 
( 
int  
titleId! (
,( )
string* 0
titles1 7
,7 8
string9 ?
	createdby@ I
)I J
;J K
public 
record 
TitleUpdateDto 
( 
int  
titleId! (
,( )
string* 0
titles1 7
,7 8
string9 ?

modifiedby@ J
)J K
;K L
public 
record 
TitleDeleteDto 
( 
int  
titleId! (
)( )
;) *¥

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/SocialMediaDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
SocialMediaReadDto  
(  !
int! $
SocialMediaId% 2
,2 3
string4 :
SocialMediaPlatform; N
)N O
;O P
public 
record  
SocialMediaCreateDto "
(" #
int# &
SocialMediaId' 4
,4 5
string6 <
SocialMediaPlatform= P
,P Q
stringR X
	CreatedByY b
)b c
;c d
public 
record  
SocialMediaUpdateDto "
(" #
int# &
SocialMediaId' 4
,4 5
string6 <
SocialMediaPlatform= P
,P Q
stringR X

ModifiedByY c
)c d
;d e
public 
record  
SocialMediaDeleteDto "
(" #
int# &
SocialMediaId' 4
)4 5
;5 6´

É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/ResidentTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
ResidentTypeReadDto !
(! "
int" %
residentTypeId& 4
,4 5
string6 <
residentTypes= J
)J K
;K L
public 
record !
ResidentTypeCreateDto #
(# $
int$ '
residentTypeId( 6
,6 7
string8 >
residentTypes? L
,L M
stringM S
	createdByT ]
)] ^
;^ _
public 
record !
ResidentTypeUpdateDto #
(# $
int$ '
residentTypeId( 6
,6 7
string8 >
residentTypes? L
,L M
stringM S

modifiedByT ^
)^ _
;_ `
public 
record !
ResidentTypeDeleteDto #
(# $
int$ '
residentTypeId( 6
)6 7
;7 8∑

Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/OwnershipTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record  
OwnershipTypeReadDto "
(" #
int# &
ownershipTypeId' 6
,6 7
string8 >
ownershipTypes? M
)M N
;N O
public 
record "
OwnershipTypeCreateDto $
($ %
int% (
ownershipTypeId) 8
,8 9
string: @
ownershipTypesA O
,O P
stringQ W
	createdbyX a
)a b
;b c
public 
record "
OwnershipTypeUpdateDto $
($ %
int% (
ownershipTypeId) 8
,8 9
string: @
ownershipTypesA O
,O P
stringQ W

modifiedbyX b
)b c
;c d
public 
record "
OwnershipTypeDeleteDto $
($ %
int% (
ownershipTypeId) 8
)8 9
;9 :¢

Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/NationalityDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
NationalityReadDto  
(  !
int! $
nationalityId% 2
,2 3
string4 :
nationalities; H
)H I
;I J
public 
record  
NationalityCreateDto "
(" #
int# &
nationalityId' 4
,4 5
string6 <
nationalities= J
,J K
stringL R
	createdbyS \
)\ ]
;] ^
public 
record  
NationalityUpdateDto "
(" #
int# &
nationalityId' 4
,4 5
string6 <
nationalities= J
,J K
stringL R

modifiedbyS ]
)] ^
;^ _
public 
record  
NationalityDeleteDto "
(" #
int# &
nationalityId' 4
)4 5
;5 6‡
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/IdentificationTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record %
IdentificationTypeReadDto '
(' (
int( + 
identificationTypeId, @
,@ A
stringB H
identificationTypesI \
)\ ]
;] ^
public 
record '
IdentificationTypeCreateDto )
() *
int* - 
identificationTypeId. B
,B C
stringD J
identificationTypesK ^
,^ _
string` f
	createdByg p
)p q
;q r
public 
record '
IdentificationTypeUpdateDto )
() *
int* - 
identificationTypeId. B
,B C
stringD J
identificationTypesK ^
,^ _
string` f

modifiedByg q
)q r
;r s
public 
record '
IdentificationTypeDeleteDto )
() *
int* - 
identificationTypeId. B
)B C
;C D
public		 
record		 !
IdentificationTypeDto		 #
(		# $
int		$ ' 
identificationTypeId		( <
,		< =
string		> D
identificationTypes		E X
)		X Y
;		Y ZÎ	
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/GenderDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
GenderReadDto 
( 
int 
genderId  (
,( )
string* 0

genderType1 ;
); <
;< =
public 
record 
GenderCreateDto 
( 
int !
genderId" *
,* +
string, 2

genderType3 =
,= >
string? E
	createdByF O
)O P
;P Q
public 
record 
GenderUpdateDto 
( 
int !
genderId" *
,* +
string, 2

genderType3 =
,= >
string? E

modifiedByF P
)P Q
;Q R
public 
record 
GenderDeleteDto 
( 
int !
genderId" *
)* +
;+ ,´

É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Customer/CustomerTypeDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
record 
CustomerTypeReadDto !
(! "
int" %
customerTypeId& 4
,4 5
string6 <
customerTypes= J
)J K
;K L
public 
record !
CustomerTypeCreateDto #
(# $
int$ '
customerTypeId( 6
,6 7
string8 >
customerTypes? L
,L M
stringN T
	createdByU ^
)^ _
;_ `
public 
record !
CustomerTypeUpdateDto #
(# $
int$ '
customerTypeId( 6
,6 7
string8 >
customerTypes? L
,L M
stringN T

modifiedByU _
)_ `
;` a
public 
record !
CustomerTypeDeleteDto #
(# $
int$ '
customerTypeId( 6
)6 7
;7 8ùb
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/PropertyMasterDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
{ 
public 
record 
PropertyMasterDto  
{ 
[ 	
Key	 
] 
public		 
int		 
PropertyMasterId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
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
 
[ 	
Required	 
] 
public 
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
PropertyTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
public 
int 
	LandUseId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
LandUseTypeId  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
] 
public 
int 
AllocationTypeId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BlockNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

PlotNumber !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 

AcreageOne !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
decimal 

AcreageTwo !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
PropertyHeightId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 

PlotSizeId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
double 
SellingPrice "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 

CurrencyId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
public   
string   
?   

RentalType   !
{  " #
get  $ '
;  ' (
set  ) ,
;  , -
}  . /
public!! 
int!! 
TotalNumberOfRooms!! %
{!!& '
get!!( +
;!!+ ,
set!!- 0
;!!0 1
}!!2 3
public"" 
int"" 
RoomsOccupied""  
{""! "
get""# &
;""& '
set""( +
;""+ ,
}""- .
public## 
int## 
ApartmentTypeId## "
{### $
get##% (
;##( )
set##* -
;##- .
}##/ 0
public$$ 
int$$ 
SchemeTypeId$$ 
{$$  !
get$$" %
;$$% &
set$$' *
;$$* +
}$$, -
public%% 
int%% "
ApartmentBlockNumberId%% )
{%%* +
get%%, /
;%%/ 0
set%%1 4
;%%4 5
}%%6 7
public&& 
int&& 
BlockTypeId&& 
{&&  
get&&! $
;&&$ %
set&&& )
;&&) *
}&&+ ,
public'' 
int'' 
FloorNumberId''  
{''! "
get''# &
;''& '
set''( +
;''+ ,
}''- .
public(( 
int(( 
BlockUnitId(( 
{((  
get((! $
;(($ %
set((& )
;(() *
}((+ ,
public)) 
int)) 
BlockSideId)) 
{))  
get))! $
;))$ %
set))& )
;))) *
}))+ ,
[** 	
StringLength**	 
(** 
$num** 
)** 
]** 
public++ 
string++ 
?++ 
	FloorArea++  
{++! "
get++# &
;++& '
set++( +
;+++ ,
}++- .
public,, 
int,, 

RoomNumber,, 
{,, 
get,,  #
;,,# $
set,,% (
;,,( )
},,* +
public-- 
DateTime-- 
RightOfEntry-- $
{--% &
get--' *
;--* +
set--, /
;--/ 0
}--1 2
public.. 
int.. 
	LeaseTerm.. 
{.. 
get.. "
;.." #
set..$ '
;..' (
}..) *
public// 
DateTime// 
LeaseExpiryDate// '
{//( )
get//* -
;//- .
set/// 2
;//2 3
}//4 5
public00 
int00 

DebtorType00 
{00 
get00  #
;00# $
set00% (
;00( )
}00* +
public11 
int11 
GroupNumber11 
{11  
get11! $
;11$ %
set11& )
;11) *
}11+ ,
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 
CustomerCode33 #
{33$ %
get33& )
;33) *
set33+ .
;33. /
}330 1
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
SitePlanNumber55 %
{55& '
get55( +
;55+ ,
set55- 0
;550 1
}552 3
[66 	
StringLength66	 
(66 
$num66 
)66 
]66 
public77 
string77 
?77 
CadastralPlanNumber77 *
{77+ ,
get77- 0
;770 1
set772 5
;775 6
}777 8
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
CoordinateOne99 $
{99% &
get99' *
;99* +
set99, /
;99/ 0
}991 2
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
CoordinateTwo;; $
{;;% &
get;;' *
;;;* +
set;;, /
;;;/ 0
};;1 2
[<< 	
StringLength<<	 
(<< 
$num<< 
)<< 
]<< 
public== 
string== 
?== 
CoordinateThree== &
{==' (
get==) ,
;==, -
set==. 1
;==1 2
}==3 4
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? 
CoordinateFour?? %
{??& '
get??( +
;??+ ,
set??- 0
;??0 1
}??2 3
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA 
CoordinateFiveAA %
{AA& '
getAA( +
;AA+ ,
setAA- 0
;AA0 1
}AA2 3
[BB 	
StringLengthBB	 
(BB 
$numBB 
)BB 
]BB 
publicCC 
stringCC 
?CC 
CoordinateSixCC $
{CC% &
getCC' *
;CC* +
setCC, /
;CC/ 0
}CC1 2
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE  
MotherPropertyNumberEE +
{EE, -
getEE. 1
;EE1 2
setEE3 6
;EE6 7
}EE8 9
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG 
CommentsGG 
{GG  !
getGG" %
;GG% &
setGG' *
;GG* +
}GG, -
publicHH 
boolHH 
IsLargeScaleHH  
{HH! "
getHH# &
;HH& '
setHH( +
;HH+ ,
}HH- .
publicII 
boolII 
	IsDeletedII 
{II 
getII  #
;II# $
setII% (
;II( )
}II* +
}JJ 
public~~ 

record~~ #
PropertyMasterUpdateDto~~ )
{ 
[
ÄÄ 	
Key
ÄÄ	 
]
ÄÄ 
public
ÅÅ 
int
ÅÅ 
PropertyMasterId
ÅÅ #
{
ÅÅ$ %
get
ÅÅ& )
;
ÅÅ) *
set
ÅÅ+ .
;
ÅÅ. /
}
ÅÅ0 1
[
ÇÇ 	
StringLength
ÇÇ	 
(
ÇÇ 
$num
ÇÇ 
)
ÇÇ 
]
ÇÇ 
[
ÉÉ 	
Required
ÉÉ	 
]
ÉÉ 
public
ÑÑ 
string
ÑÑ 
?
ÑÑ 
PropertyNumber
ÑÑ %
{
ÑÑ& '
get
ÑÑ( +
;
ÑÑ+ ,
set
ÑÑ- 0
;
ÑÑ0 1
}
ÑÑ2 3
}
ÖÖ 
public
áá 

record
áá 1
#PropertyMasterUpdateLeaseDetailsDto
áá 5
{
àà 
[
ââ 	
Key
ââ	 
]
ââ 
public
ää 
int
ää 
PropertyMasterId
ää #
{
ää$ %
get
ää& )
;
ää) *
set
ää+ .
;
ää. /
}
ää0 1
[
åå 	
Required
åå	 
]
åå 
[
çç 	
StringLength
çç	 
(
çç 
$num
çç 
)
çç 
]
çç 
public
éé 
string
éé 
?
éé 
PropertyNumber
éé %
{
éé& '
get
éé( +
;
éé+ ,
set
éé- 0
;
éé0 1
}
éé2 3
public
êê 
DateTime
êê 
RightOfEntry
êê $
{
êê% &
get
êê' *
;
êê* +
set
êê, /
;
êê/ 0
}
êê1 2
public
íí 
int
íí 
	LeaseTerm
íí 
{
íí 
get
íí "
;
íí" #
set
íí$ '
;
íí' (
}
íí) *
public
îî 
DateTime
îî 
LeaseExpiryDate
îî '
{
îî( )
get
îî* -
;
îî- .
set
îî/ 2
;
îî2 3
}
îî4 5
}
ïï 
public
óó 

record
óó %
PropertyMasterDeleteDto
óó )
{
óó* +
}
óó, -
public
öö 

record
öö &
AssignPropertyToCustomer
öö *
{
õõ 
public
úú 
string
úú 
?
úú 
PropertyNumber
úú %
{
úú& '
get
úú( +
;
úú+ ,
set
úú- 0
;
úú0 1
}
úú2 3
public
ùù 
string
ùù 
?
ùù 
CustomerCode
ùù #
{
ùù$ %
get
ùù& )
;
ùù) *
set
ùù+ .
;
ùù. /
}
ùù0 1
public
ûû 
string
ûû 
?
ûû 

AssignedBy
ûû !
{
ûû" #
get
ûû$ '
;
ûû' (
set
ûû) ,
;
ûû, -
}
ûû. /
}
üü 
}¢¢ ≠&
ú/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyMasterCreatePlotResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Property5 =
{ 
public 

record /
#PropertyMasterCreatePlotResponseDto 5
{ 
[		 	
Key			 
]		 
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
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
? 
PropertyType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
? 
LandUse 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
? 
LandUseType "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 
AllocationType %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
BlockNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

PlotNumber !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
double 

AcreageOne  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
double 

AcreageTwo  
{! "
get# &
;& '
set( +
;+ ,
}- .
public!! 
string!! 
?!! 
PropertyHeight!! %
{!!& '
get!!( +
;!!+ ,
set!!- 0
;!!0 1
}!!2 3
public## 
string## 
?## 
PlotSize## 
{##  !
get##" %
;##% &
set##' *
;##* +
}##, -
[%% 	
StringLength%%	 
(%% 
$num%% 
)%% 
]%% 
public&& 
string&& 
?&& 
SitePlanNumber&& %
{&&& '
get&&( +
;&&+ ,
set&&- 0
;&&0 1
}&&2 3
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
string)) 
?)) 
CoordinateOne)) $
{))% &
get))' *
;))* +
set)), /
;))/ 0
}))1 2
[** 	
StringLength**	 
(** 
$num** 
)** 
]** 
public++ 
string++ 
?++ 
CoordinateTwo++ $
{++% &
get++' *
;++* +
set++, /
;++/ 0
}++1 2
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
CoordinateThree-- &
{--' (
get--) ,
;--, -
set--. 1
;--1 2
}--3 4
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// 
CoordinateFour// %
{//& '
get//( +
;//+ ,
set//- 0
;//0 1
}//2 3
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
string11 
?11 
CoordinateFive11 %
{11& '
get11( +
;11+ ,
set11- 0
;110 1
}112 3
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 
CoordinateSix33 $
{33% &
get33' *
;33* +
set33, /
;33/ 0
}331 2
}66 
}77 ª0
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyMasterCreatePlotDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Property5 =
{ 
public 

record '
PropertyMasterCreatePlotDto -
{ 
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
0 1
public 
required 
int 
PropertyTypeId *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LocalityInitial .
{/ 0
get1 4
;4 5
set7 :
;: ;
}< =
public 
required 
int 
	LandUseId %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUseInitial -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 
required 
int 
LandUseTypeId )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
LandUseTypeInitial 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public 
required 
int 
AllocationTypeId ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
[ 	
StringLength	 
( 
$num 
) 
] 
public   
required   
string   !
AllocationTypeInitial   4
{  5 6
get  7 :
;  : ;
set  < ?
;  ? @
}  A B
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
public&& 
required&& 
string&& 

PlotNumber&& )
{&&* +
get&&, /
;&&/ 0
set&&1 4
;&&4 5
}&&6 7
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
}**- .
public,, 
int,, 
PropertyHeightId,, #
{,,$ %
get,,& )
;,,) *
set,,+ .
;,,. /
},,0 1
public.. 
int.. 

PlotSizeId.. 
{.. 
get..  #
;..# $
set..% (
;..( )
}..* +
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
string11 
?11 
SitePlanNumber11 %
{11& '
get11( +
;11+ ,
set11- 0
;110 1
}112 3
[33 	
StringLength33	 
(33 
$num33 
)33 
]33 
public44 
string44 
?44 
CoordinateOne44 $
{44% &
get44' *
;44* +
set44, /
;44/ 0
}441 2
[55 	
StringLength55	 
(55 
$num55 
)55 
]55 
public66 
string66 
?66 
CoordinateTwo66 $
{66% &
get66' *
;66* +
set66, /
;66/ 0
}661 2
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 
CoordinateThree88 &
{88' (
get88) ,
;88, -
set88. 1
;881 2
}883 4
[99 	
StringLength99	 
(99 
$num99 
)99 
]99 
public:: 
string:: 
?:: 
CoordinateFour:: %
{::& '
get::( +
;::+ ,
set::- 0
;::0 1
}::2 3
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 
CoordinateFive<< %
{<<& '
get<<( +
;<<+ ,
set<<- 0
;<<0 1
}<<2 3
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 
CoordinateSix>> $
{>>% &
get>>' *
;>>* +
set>>, /
;>>/ 0
}>>1 2
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
requiredAA 
stringAA 
	CreatedByAA (
{AA) *
getAA+ .
;AA. /
setAA0 3
;AA3 4
}AA5 6
}BB 
}CC ãQ
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/ModuleServices/OnlinePropertyDetailsDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
ModuleServices5 C
{ 
public 

class $
OnlinePropertyDetailsDto )
{ 
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
}uu „%
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/ModuleServices/OnlineCustomerDetailsDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
ModuleServices5 C
{ 
public 
record $
OnlineCustomerDetailsDto '
{ 
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
}77 ˚M
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/CustomerMasterDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
{ 
public 
record 
CustomerMasterDto  
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
}		0 1
public

 
int

 
CustomerTypeId
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
. /
public 
int 
ResidentTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
[ 	
Required	 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
TitleId 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
LastName 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

MiddleName !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
	FirstName  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CompanyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
DateTime 
DateOfBirth #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
	TinNumber  
{! "
get# &
;& '
set( +
;+ ,
}- .
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
public 
int 
GenderId 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
NationalityId  
{! "
get# &
;& '
set( +
;+ ,
}- .
[   	
StringLength  	 
(   
$num   
)   
]   
public!! 
string!! 
?!! 
PostalAddress!! $
{!!% &
get!!' *
;!!* +
set!!, /
;!!/ 0
}!!1 2
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## 
?## 
ResidentialAddress## )
{##* +
get##, /
;##/ 0
set##1 4
;##4 5
}##6 7
[$$ 	
StringLength$$	 
($$ 
$num$$ 
)$$ 
]$$ 
public%% 
string%% 
?%% 
DigitalAddress%% %
{%%& '
get%%( +
;%%+ ,
set%%- 0
;%%0 1
}%%2 3
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
['' 	
Required''	 
]'' 
public(( 
string(( 
?(( 
PrimaryMobileNumber(( *
{((+ ,
get((- 0
;((0 1
set((2 5
;((5 6
}((7 8
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** !
SecondaryMobileNumber** ,
{**- .
get**/ 2
;**2 3
set**4 7
;**7 8
}**9 :
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
string,, 
?,, 
OfficeNumber,, #
{,,$ %
get,,& )
;,,) *
set,,+ .
;,,. /
},,0 1
[-- 	
StringLength--	 
(-- 
$num-- 
)-- 
]-- 
public.. 
string.. 
?.. 
WhatsAppNumber.. %
{..& '
get..( +
;..+ ,
set..- 0
;..0 1
}..2 3
[// 	
EmailAddress//	 
]// 
public00 
string00 
?00 
EmailAddress00 #
{00$ %
get00& )
;00) *
set00+ .
;00. /
}000 1
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22  
ResidentPermitNumber22 +
{22, -
get22. 1
;221 2
set223 6
;226 7
}228 9
public33 
DateTime33 

DateIssued33 "
{33# $
get33% (
;33( )
set33* -
;33- .
}33/ 0
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
ContactPerson55 $
{55% &
get55' *
;55* +
set55, /
;55/ 0
}551 2
[66 	
StringLength66	 
(66 
$num66 
)66 
]66 
public77 
string77 
?77 $
ContactPersonPhoneNumber77 /
{770 1
get772 5
;775 6
set777 :
;77: ;
}77< =
public88 
int88 
SocialMediaTypeId88 $
{88% &
get88' *
;88* +
set88, /
;88/ 0
}881 2
[99 	
StringLength99	 
(99 
$num99 
)99 
]99 
public:: 
string:: 
?:: 
SocialMediaAccount:: )
{::* +
get::, /
;::/ 0
set::1 4
;::4 5
}::6 7
public;; 
int;;  
IdentificationTypeId;; '
{;;( )
get;;* -
;;;- .
set;;/ 2
;;;2 3
};;4 5
[<< 	
StringLength<<	 
(<< 
$num<< 
)<< 
]<< 
public== 
string== 
?== $
IdentificationTypeNumber== /
{==0 1
get==2 5
;==5 6
set==7 :
;==: ;
}==< =
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? &
IdentificationTypeImageOne?? 1
{??2 3
get??4 7
;??7 8
set??9 <
;??< =
}??> ?
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA &
IdentificationTypeImageTwoAA 1
{AA2 3
getAA4 7
;AA7 8
setAA9 <
;AA< =
}AA> ?
[BB 	
StringLengthBB	 
(BB 
$numBB 
)BB 
]BB 
publicCC 
stringCC 
?CC 
CommentsCC 
{CC  !
getCC" %
;CC% &
setCC' *
;CC* +
}CC, -
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
InterestExpressedEE (
{EE) *
getEE+ .
;EE. /
setEE0 3
;EE3 4
}EE5 6
publicFF 
intFF 
DebtorStatusFF 
{FF  !
getFF" %
;FF% &
setFF' *
;FF* +
}FF, -
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 

ParentCodeHH !
{HH" #
getHH$ '
;HH' (
setHH) ,
;HH, -
}HH. /
publicII 
boolII 
	IsDeletedII 
{II 
getII  #
;II# $
setII% (
;II( )
}II* +
}JJ 
publicLL 

recordLL #
CustomerMasterCreateDtoLL )
{MM 
}NN 
publicPP 

recordPP #
CustomerMasterUpdateDtoPP )
{PP* +
}PP, -
publicRR 

recordRR #
CustomerMasterDeleteDtoRR )
{RR* +
}RR, -
}TT ‰
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/StopDebitRequestDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record 
StopDebitRequestDto "
{ 
[ 
StringLength 
( 
$num 
) 
] 
public 
string	 
? 
CustomerCode 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string	 
? 
Reasons 
{ 
get 
; 
set  #
;# $
}% &
public 
int 
DebtorStatus 
{  !
get" %
;% &
set' *
;* +
}, -
[ 
StringLength 
( 
$num 
) 
] 
public 
string	 
? 
ActionBy 
{ 
get 
;  
set! $
;$ %
}& '
} 
} Ω0
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/ProspectiveCustomerResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 

record *
ProspectiveCustomerResponseDto 0
{ 
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
}		0 1
public 
string 
? 
CustomerType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
ResidentType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
Title 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
SurName 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

OtherNames !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CompanyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
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
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
PrimaryMobileNumber-- *
{--+ ,
get--- 0
;--0 1
set--2 5
;--5 6
}--7 8
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
?00 !
SecondaryMobileNumber00 ,
{00- .
get00/ 2
;002 3
set004 7
;007 8
}009 :
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 
OfficeNumber33 #
{33$ %
get33& )
;33) *
set33+ .
;33. /
}330 1
[55 	
StringLength55	 
(55 
$num55 
)55 
]55 
public66 
string66 
?66 
WhatsAppNumber66 %
{66& '
get66( +
;66+ ,
set66- 0
;660 1
}662 3
[88 	
EmailAddress88	 
]88 
public99 
string99 
?99 
EmailAddress99 #
{99$ %
get99& )
;99) *
set99+ .
;99. /
}990 1
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 
SocialMediaType<< &
{<<' (
get<<) ,
;<<, -
set<<. 1
;<<1 2
}<<3 4
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? 
SocialMediaAccount?? )
{??* +
get??, /
;??/ 0
set??1 4
;??4 5
}??6 7
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 
InterestExpressedBB (
{BB) *
getBB+ .
;BB. /
setBB0 3
;BB3 4
}BB5 6
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
CommentsEE 
{EE  !
getEE" %
;EE% &
setEE' *
;EE* +
}EE, -
}GG 
}HH Ì1
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/ProspectiveCustomerDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record "
ProspectiveCustomerDto %
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
}		0 1
public 
required 
int 
CustomerTypeId *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
required 
int 
ResidentTypeId *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
required 
int 

LocalityId &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
TitleId 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
SurName 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

OtherNames !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CompanyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
GenderId 
{ 
get !
;! "
set# &
;& '
}( )
public!! 
int!! 
NationalityId!!  
{!!! "
get!!# &
;!!& '
set!!( +
;!!+ ,
}!!- .
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
[99 	
Required99	 
]99 
[:: 	
EmailAddress::	 
]:: 
public;; 
required;; 
string;; 
EmailAddress;; +
{;;, -
get;;. 1
;;;1 2
set;;3 6
;;;6 7
};;8 9
public== 
int== 
SocialMediaTypeId== $
{==% &
get==' *
;==* +
set==, /
;==/ 0
}==1 2
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
}@@6 7
[BB 	
RequiredBB	 
]BB 
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
requiredDD 
stringDD 
InterestExpressedDD 0
{DD1 2
getDD3 6
;DD6 7
setDD8 ;
;DD; <
}DD= >
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG 
CommentsGG 
{GG  !
getGG" %
;GG% &
setGG' *
;GG* +
}GG, -
publicII 
stringII 
?II 
	CreatedByII  
{II! "
getII# &
;II& '
setII( +
;II+ ,
}II- .
}JJ 
}LL ¶B
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/MultiOwnershipCustomerResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record -
!MultiOwnershipCustomerResponseDto 0
:1 2)
IndividualCustomerResponseDto3 P
{ 
public 
string 
? 
MaritalStatus $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public		 
DateTime		 
?		 
DateOfMarriage		 '
{		( )
get		* -
;		- .
set		/ 2
;		2 3
}		4 5
public 4
(IndividualNonResidentCustomerResponseDto 7
?7 8
NonResident9 D
{E F
getG J
;J K
setL O
;O P
}Q R
public 3
'IndividualExpatriateCustomerResponseDto 6
?6 7

Expatriate8 B
{C D
getE H
;H I
setJ M
;M N
}O P
} 
public 

record (
DependantCustomerResponseDto .
:/ 0$
MultiCustomerResponseDto1 I
{ 
public 4
(IndividualNonResidentCustomerResponseDto 7
?7 8
NonResident9 D
{E F
getG J
;J K
setL O
;O P
}Q R
public 3
'IndividualExpatriateCustomerResponseDto 6
?6 7

Expatriate8 B
{C D
getE H
;H I
setJ M
;M N
}O P
} 
public 

record $
MultiCustomerResponseDto *
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public   
int   
TitleId   
{   
get    
;    !
set  " %
;  % &
}  ' (
public"" 
required"" 
string"" 
Title"" $
{""% &
get""' *
;""* +
set"", /
;""/ 0
}""1 2
[$$ 	
StringLength$$	 
($$ 
$num$$ 
)$$ 
]$$ 
public%% 
required%% 
string%% 
SurName%% &
{%%' (
get%%) ,
;%%, -
set%%. 1
;%%1 2
}%%3 4
['' 	
StringLength''	 
('' 
$num'' 
)'' 
]'' 
public(( 
required(( 
string(( 

OtherNames(( )
{((* +
get((, /
;((/ 0
set((1 4
;((4 5
}((6 7
public** 
DateTime** 
DateOfBirth** #
{**$ %
get**& )
;**) *
set**+ .
;**. /
}**0 1
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
	TinNumber--  
{--! "
get--# &
;--& '
set--( +
;--+ ,
}--- .
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
?00 
Picture00 
{00  
get00! $
;00$ %
set00& )
;00) *
}00+ ,
public22 
int22 
GenderId22 
{22 
get22 !
;22! "
set22# &
;22& '
}22( )
public44 
string44 
?44 
Gender44 
{44 
get44  #
;44# $
set44% (
;44( )
}44* +
public66 
int66 
NationalityId66  
{66! "
get66# &
;66& '
set66( +
;66+ ,
}66- .
public88 
string88 
?88 
Nationality88 "
{88# $
get88% (
;88( )
set88* -
;88- .
}88/ 0
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
PostalAddress;; $
{;;% &
get;;' *
;;;* +
set;;, /
;;;/ 0
};;1 2
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 
ResidentialAddress>> )
{>>* +
get>>, /
;>>/ 0
set>>1 4
;>>4 5
}>>6 7
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA 
DigitalAddressAA %
{AA& '
getAA( +
;AA+ ,
setAA- 0
;AA0 1
}AA2 3
[CC 	
RequiredCC	 
]CC 
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
PrimaryMobileNumberEE *
{EE+ ,
getEE- 0
;EE0 1
setEE2 5
;EE5 6
}EE7 8
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH !
SecondaryMobileNumberHH ,
{HH- .
getHH/ 2
;HH2 3
setHH4 7
;HH7 8
}HH9 :
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
OfficeNumberKK #
{KK$ %
getKK& )
;KK) *
setKK+ .
;KK. /
}KK0 1
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
WhatsAppNumberNN %
{NN& '
getNN( +
;NN+ ,
setNN- 0
;NN0 1
}NN2 3
[PP 	
EmailAddressPP	 
]PP 
publicQQ 
requiredQQ 
stringQQ 
EmailAddressQQ +
{QQ, -
getQQ. 1
;QQ1 2
setQQ3 6
;QQ6 7
}QQ8 9
publicSS 
intSS 
SocialMediaTypeIdSS $
{SS% &
getSS' *
;SS* +
setSS, /
;SS/ 0
}SS1 2
publicUU 
stringUU 
?UU 
SocialMediaPlatformUU *
{UU+ ,
getUU- 0
;UU0 1
setUU2 5
;UU5 6
}UU7 8
[WW 	
StringLengthWW	 
(WW 
$numWW 
)WW 
]WW 
publicXX 
stringXX 
?XX 
SocialMediaAccountXX )
{XX* +
getXX, /
;XX/ 0
setXX1 4
;XX4 5
}XX6 7
publicZZ 
intZZ  
IdentificationTypeIdZZ '
{ZZ( )
getZZ* -
;ZZ- .
setZZ/ 2
;ZZ2 3
}ZZ4 5
public\\ 
string\\ 
?\\ 
IdentificationType\\ )
{\\* +
get\\, /
;\\/ 0
set\\1 4
;\\4 5
}\\6 7
[^^ 	
StringLength^^	 
(^^ 
$num^^ 
)^^ 
]^^ 
public__ 
string__ 
?__ $
IdentificationTypeNumber__ /
{__0 1
get__2 5
;__5 6
set__7 :
;__: ;
}__< =
publicaa 
stringaa 
[aa 
]aa 
?aa  
IdentificationImagesaa -
{aa. /
getaa0 3
;aa3 4
setaa5 8
;aa8 9
}aa: ;
}cc 
}ee ¸>
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/MultiOwnershipCustomerDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 

record %
MultiOwnershipCustomerDto +
:, -!
IndividualCustomerDto. C
{ 
public 
string 
? 
	CreatedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
string		 
?		 
MaritalStatus		 $
{		% &
get		' *
;		* +
set		, /
;		/ 0
}		1 2
public

 
DateTime

 
?

 
DateOfMarriage

 '
{

( )
get

* -
;

- .
set

/ 2
;

2 3
}

4 5
public ,
 IndividualNonResidentCustomerDto /
?/ 0
NonResident1 <
{= >
get? B
;B C
setD G
;G H
}I J
public +
IndividualExpatriateCustomerDto .
?. /

Expatriate0 :
{; <
get= @
;@ A
setB E
;E F
}G H
public 
IEnumerable 
< 
MultiCustomerDto +
>+ ,
?, -
	Dependent. 7
{8 9
get: =
;= >
set? B
;B C
}D E
} 
public 

record +
UpdateMultiOwnershipCustomerDto 1
:2 3!
IndividualCustomerDto4 I
{ 
public 
string 
? 

ModifiedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
MaritalStatus $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
DateTime 
? 
DateOfMarriage '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public ,
 IndividualNonResidentCustomerDto /
?/ 0
NonResident1 <
{= >
get? B
;B C
setD G
;G H
}I J
public +
IndividualExpatriateCustomerDto .
?. /

Expatriate0 :
{; <
get= @
;@ A
setB E
;E F
}G H
} 
public   

record   
MultiCustomerDto   "
{!! 
public"" 
required"" 
int"" 
TitleId"" #
{""$ %
get""& )
;"") *
set""+ .
;"". /
}""0 1
[$$ 	
StringLength$$	 
($$ 
$num$$ 
)$$ 
]$$ 
public%% 
required%% 
string%% 
SurName%% &
{%%' (
get%%) ,
;%%, -
set%%. 1
;%%1 2
}%%3 4
['' 	
StringLength''	 
('' 
$num'' 
)'' 
]'' 
public(( 
required(( 
string(( 

OtherNames(( )
{((* +
get((, /
;((/ 0
set((1 4
;((4 5
}((6 7
public** 
DateTime** 
DateOfBirth** #
{**$ %
get**& )
;**) *
set**+ .
;**. /
}**0 1
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
	TinNumber--  
{--! "
get--# &
;--& '
set--( +
;--+ ,
}--- .
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
?00 
Picture00 
{00  
get00! $
;00$ %
set00& )
;00) *
}00+ ,
public22 
int22 
GenderId22 
{22 
get22 !
;22! "
set22# &
;22& '
}22( )
public44 
int44 
NationalityId44  
{44! "
get44# &
;44& '
set44( +
;44+ ,
}44- .
[66 	
StringLength66	 
(66 
$num66 
)66 
]66 
public77 
string77 
?77 
PostalAddress77 $
{77% &
get77' *
;77* +
set77, /
;77/ 0
}771 2
[99 	
StringLength99	 
(99 
$num99 
)99 
]99 
public:: 
string:: 
?:: 
ResidentialAddress:: )
{::* +
get::, /
;::/ 0
set::1 4
;::4 5
}::6 7
[<< 	
StringLength<<	 
(<< 
$num<< 
)<< 
]<< 
public== 
string== 
?== 
DigitalAddress== %
{==& '
get==( +
;==+ ,
set==- 0
;==0 1
}==2 3
[?? 	
Required??	 
]?? 
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA 
PrimaryMobileNumberAA *
{AA+ ,
getAA- 0
;AA0 1
setAA2 5
;AA5 6
}AA7 8
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
stringDD 
?DD !
SecondaryMobileNumberDD ,
{DD- .
getDD/ 2
;DD2 3
setDD4 7
;DD7 8
}DD9 :
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG 
OfficeNumberGG #
{GG$ %
getGG& )
;GG) *
setGG+ .
;GG. /
}GG0 1
[II 	
StringLengthII	 
(II 
$numII 
)II 
]II 
publicJJ 
stringJJ 
?JJ 
WhatsAppNumberJJ %
{JJ& '
getJJ( +
;JJ+ ,
setJJ- 0
;JJ0 1
}JJ2 3
[LL 	
EmailAddressLL	 
]LL 
publicMM 
requiredMM 
stringMM 
EmailAddressMM +
{MM, -
getMM. 1
;MM1 2
setMM3 6
;MM6 7
}MM8 9
publicOO 
intOO 
SocialMediaTypeIdOO $
{OO% &
getOO' *
;OO* +
setOO, /
;OO/ 0
}OO1 2
[QQ 	
StringLengthQQ	 
(QQ 
$numQQ 
)QQ 
]QQ 
publicRR 
stringRR 
?RR 
SocialMediaAccountRR )
{RR* +
getRR, /
;RR/ 0
setRR1 4
;RR4 5
}RR6 7
publicTT 
intTT  
IdentificationTypeIdTT '
{TT( )
getTT* -
;TT- .
setTT/ 2
;TT2 3
}TT4 5
[VV 	
StringLengthVV	 
(VV 
$numVV 
)VV 
]VV 
publicWW 
stringWW 
?WW $
IdentificationTypeNumberWW /
{WW0 1
getWW2 5
;WW5 6
setWW7 :
;WW: ;
}WW< =
publicYY 
stringYY 
[YY 
]YY 
?YY  
IdentificationImagesYY -
{YY. /
getYY0 3
;YY3 4
setYY5 8
;YY8 9
}YY: ;
}[[ 
}\\ §B
ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/JointOwnershipCustomerResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record -
!JointOwnershipCustomerResponseDto 0
:1 2)
IndividualCustomerResponseDto3 P
{ 
public 
string 
? 
MaritalStatus $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public		 
DateTime		 
?		 
DateOfMarriage		 '
{		( )
get		* -
;		- .
set		/ 2
;		2 3
}		4 5
public 4
(IndividualNonResidentCustomerResponseDto 7
?7 8
NonResident9 D
{E F
getG J
;J K
setL O
;O P
}Q R
public 3
'IndividualExpatriateCustomerResponseDto 6
?6 7

Expatriate8 B
{C D
getE H
;H I
setJ M
;M N
}O P
} 
public 

record &
CoLesseCustomerResponseDto ,
:- .$
JointCustomerResponseDto/ G
{ 
public 4
(IndividualNonResidentCustomerResponseDto 7
?7 8
NonResident9 D
{E F
getG J
;J K
setL O
;O P
}Q R
public 3
'IndividualExpatriateCustomerResponseDto 6
?6 7

Expatriate8 B
{C D
getE H
;H I
setJ M
;M N
}O P
} 
public 

record $
JointCustomerResponseDto *
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
TitleId 
{ 
get  
;  !
set" %
;% &
}' (
public 
required 
string 
Title $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[!! 	
StringLength!!	 
(!! 
$num!! 
)!! 
]!! 
public"" 
required"" 
string"" 
SurName"" &
{""' (
get"") ,
;"", -
set"". 1
;""1 2
}""3 4
[$$ 	
StringLength$$	 
($$ 
$num$$ 
)$$ 
]$$ 
public%% 
required%% 
string%% 

OtherNames%% )
{%%* +
get%%, /
;%%/ 0
set%%1 4
;%%4 5
}%%6 7
public'' 
DateTime'' 
DateOfBirth'' #
{''$ %
get''& )
;'') *
set''+ .
;''. /
}''0 1
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** 
	TinNumber**  
{**! "
get**# &
;**& '
set**( +
;**+ ,
}**- .
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
Picture-- 
{--  
get--! $
;--$ %
set--& )
;--) *
}--+ ,
public// 
int// 
GenderId// 
{// 
get// !
;//! "
set//# &
;//& '
}//( )
public11 
string11 
?11 
Gender11 
{11 
get11  #
;11# $
set11% (
;11( )
}11* +
public33 
int33 
NationalityId33  
{33! "
get33# &
;33& '
set33( +
;33+ ,
}33- .
public55 
string55 
?55 
Nationality55 "
{55# $
get55% (
;55( )
set55* -
;55- .
}55/ 0
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 
PostalAddress88 $
{88% &
get88' *
;88* +
set88, /
;88/ 0
}881 2
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
ResidentialAddress;; )
{;;* +
get;;, /
;;;/ 0
set;;1 4
;;;4 5
};;6 7
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 
DigitalAddress>> %
{>>& '
get>>( +
;>>+ ,
set>>- 0
;>>0 1
}>>2 3
[@@ 	
Required@@	 
]@@ 
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB 
PrimaryMobileNumberBB *
{BB+ ,
getBB- 0
;BB0 1
setBB2 5
;BB5 6
}BB7 8
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE !
SecondaryMobileNumberEE ,
{EE- .
getEE/ 2
;EE2 3
setEE4 7
;EE7 8
}EE9 :
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
OfficeNumberHH #
{HH$ %
getHH& )
;HH) *
setHH+ .
;HH. /
}HH0 1
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
WhatsAppNumberKK %
{KK& '
getKK( +
;KK+ ,
setKK- 0
;KK0 1
}KK2 3
[MM 	
EmailAddressMM	 
]MM 
publicNN 
requiredNN 
stringNN 
EmailAddressNN +
{NN, -
getNN. 1
;NN1 2
setNN3 6
;NN6 7
}NN8 9
publicPP 
intPP 
SocialMediaTypeIdPP $
{PP% &
getPP' *
;PP* +
setPP, /
;PP/ 0
}PP1 2
publicRR 
stringRR 
?RR 
SocialMediaPlatformRR *
{RR+ ,
getRR- 0
;RR0 1
setRR2 5
;RR5 6
}RR7 8
[TT 	
StringLengthTT	 
(TT 
$numTT 
)TT 
]TT 
publicUU 
stringUU 
?UU 
SocialMediaAccountUU )
{UU* +
getUU, /
;UU/ 0
setUU1 4
;UU4 5
}UU6 7
publicWW 
intWW  
IdentificationTypeIdWW '
{WW( )
getWW* -
;WW- .
setWW/ 2
;WW2 3
}WW4 5
publicYY 
stringYY 
?YY 
IdentificationTypeYY )
{YY* +
getYY, /
;YY/ 0
setYY1 4
;YY4 5
}YY6 7
[[[ 	
StringLength[[	 
([[ 
$num[[ 
)[[ 
][[ 
public\\ 
string\\ 
?\\ $
IdentificationTypeNumber\\ /
{\\0 1
get\\2 5
;\\5 6
set\\7 :
;\\: ;
}\\< =
public^^ 
string^^ 
[^^ 
]^^ 
?^^  
IdentificationImages^^ -
{^^. /
get^^0 3
;^^3 4
set^^5 8
;^^8 9
}^^: ;
}`` 
}bb ùC
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/JointOwnershipCustomerDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record %
JointOwnershipCustomerDto (
:) *!
IndividualCustomerDto+ @
{ 
public 
string 
? 
	CreatedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
string		 
?		 
MaritalStatus		 $
{		% &
get		' *
;		* +
set		, /
;		/ 0
}		1 2
public

 
DateTime

 
?

 
DateOfMarriage

 '
{

( )
get

* -
;

- .
set

/ 2
;

2 3
}

4 5
public ,
 IndividualNonResidentCustomerDto /
?/ 0
NonResident1 <
{= >
get? B
;B C
setD G
;G H
}I J
public +
IndividualExpatriateCustomerDto .
?. /

Expatriate0 :
{; <
get= @
;@ A
setB E
;E F
}G H
public 
IEnumerable 
< 
CoLesseCustomerDto -
>- .
?. /
CoLesse0 7
{8 9
get: =
;= >
set? B
;B C
}D E
} 
public 

record +
UpdateJointOwnershipCustomerDto 1
:2 3!
IndividualCustomerDto4 I
{ 
public 
string 
? 

ModifiedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
MaritalStatus $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
DateTime 
? 
DateOfMarriage '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public ,
 IndividualNonResidentCustomerDto /
?/ 0
NonResident1 <
{= >
get? B
;B C
setD G
;G H
}I J
public +
IndividualExpatriateCustomerDto .
?. /

Expatriate0 :
{; <
get= @
;@ A
setB E
;E F
}G H
} 
public 

record 
CoLesseCustomerDto $
:% &
JointCustomerDto' 7
{ 
public ,
 IndividualNonResidentCustomerDto /
?/ 0
NonResident1 <
{= >
get? B
;B C
setD G
;G H
}I J
public   +
IndividualExpatriateCustomerDto   .
?  . /

Expatriate  0 :
{  ; <
get  = @
;  @ A
set  B E
;  E F
}  G H
}!! 
public$$ 

record$$ 
JointCustomerDto$$ "
{%% 
public&& 
required&& 
int&& 
TitleId&& #
{&&$ %
get&&& )
;&&) *
set&&+ .
;&&. /
}&&0 1
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
required)) 
string)) 
SurName)) &
{))' (
get))) ,
;)), -
set)). 1
;))1 2
}))3 4
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
required,, 
string,, 

OtherNames,, )
{,,* +
get,,, /
;,,/ 0
set,,1 4
;,,4 5
},,6 7
public.. 
DateTime.. 
DateOfBirth.. #
{..$ %
get..& )
;..) *
set..+ .
;... /
}..0 1
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
string11 
?11 
	TinNumber11  
{11! "
get11# &
;11& '
set11( +
;11+ ,
}11- .
[33 	
StringLength33	 
(33 
$num33 
)33 
]33 
public44 
string44 
?44 
Picture44 
{44  
get44! $
;44$ %
set44& )
;44) *
}44+ ,
public66 
int66 
GenderId66 
{66 
get66 !
;66! "
set66# &
;66& '
}66( )
public88 
int88 
NationalityId88  
{88! "
get88# &
;88& '
set88( +
;88+ ,
}88- .
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
PostalAddress;; $
{;;% &
get;;' *
;;;* +
set;;, /
;;;/ 0
};;1 2
[== 	
StringLength==	 
(== 
$num== 
)== 
]== 
public>> 
string>> 
?>> 
ResidentialAddress>> )
{>>* +
get>>, /
;>>/ 0
set>>1 4
;>>4 5
}>>6 7
[@@ 	
StringLength@@	 
(@@ 
$num@@ 
)@@ 
]@@ 
publicAA 
stringAA 
?AA 
DigitalAddressAA %
{AA& '
getAA( +
;AA+ ,
setAA- 0
;AA0 1
}AA2 3
[CC 	
RequiredCC	 
]CC 
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
PrimaryMobileNumberEE *
{EE+ ,
getEE- 0
;EE0 1
setEE2 5
;EE5 6
}EE7 8
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH !
SecondaryMobileNumberHH ,
{HH- .
getHH/ 2
;HH2 3
setHH4 7
;HH7 8
}HH9 :
[JJ 	
StringLengthJJ	 
(JJ 
$numJJ 
)JJ 
]JJ 
publicKK 
stringKK 
?KK 
OfficeNumberKK #
{KK$ %
getKK& )
;KK) *
setKK+ .
;KK. /
}KK0 1
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
WhatsAppNumberNN %
{NN& '
getNN( +
;NN+ ,
setNN- 0
;NN0 1
}NN2 3
[PP 	
EmailAddressPP	 
]PP 
publicQQ 
requiredQQ 
stringQQ 
EmailAddressQQ +
{QQ, -
getQQ. 1
;QQ1 2
setQQ3 6
;QQ6 7
}QQ8 9
publicSS 
intSS 
SocialMediaTypeIdSS $
{SS% &
getSS' *
;SS* +
setSS, /
;SS/ 0
}SS1 2
[UU 	
StringLengthUU	 
(UU 
$numUU 
)UU 
]UU 
publicVV 
stringVV 
?VV 
SocialMediaAccountVV )
{VV* +
getVV, /
;VV/ 0
setVV1 4
;VV4 5
}VV6 7
publicXX 
intXX  
IdentificationTypeIdXX '
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
?[[ $
IdentificationTypeNumber[[ /
{[[0 1
get[[2 5
;[[5 6
set[[7 :
;[[: ;
}[[< =
public]] 
string]] 
[]] 
]]] 
?]]  
IdentificationImages]] -
{]]. /
get]]0 3
;]]3 4
set]]5 8
;]]8 9
}]]: ;
}__ 
}aa ±_
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/IndividualCustomerResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 

record )
IndividualCustomerResponseDto /
{ 
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
}		0 1
public 
int 
CustomerTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
CustomerType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
ResidentTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
ResidentType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
? 
CustomerCode  ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
int 
TitleId 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
? 
Title 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
SurName &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[!! 	
StringLength!!	 
(!! 
$num!! 
)!! 
]!! 
public"" 
required"" 
string"" 

OtherNames"" )
{""* +
get"", /
;""/ 0
set""1 4
;""4 5
}""6 7
public$$ 
DateTime$$ 
DateOfBirth$$ #
{$$$ %
get$$& )
;$$) *
set$$+ .
;$$. /
}$$0 1
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
	TinNumber''  
{''! "
get''# &
;''& '
set''( +
;''+ ,
}''- .
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** 
Picture** 
{**  
get**! $
;**$ %
set**& )
;**) *
}**+ ,
public,, 
int,, 
GenderId,, 
{,, 
get,, !
;,,! "
set,,# &
;,,& '
},,( )
public.. 
string.. 
?.. 
Gender.. 
{.. 
get..  #
;..# $
set..% (
;..( )
}..* +
public00 
int00 
NationalityId00  
{00! "
get00# &
;00& '
set00( +
;00+ ,
}00- .
public22 
string22 
?22 
Nationality22 "
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
PostalAddress55 $
{55% &
get55' *
;55* +
set55, /
;55/ 0
}551 2
[77 	
StringLength77	 
(77 
$num77 
)77 
]77 
public88 
string88 
?88 
ResidentialAddress88 )
{88* +
get88, /
;88/ 0
set881 4
;884 5
}886 7
[:: 	
StringLength::	 
(:: 
$num:: 
):: 
]:: 
public;; 
string;; 
?;; 
DigitalAddress;; %
{;;& '
get;;( +
;;;+ ,
set;;- 0
;;;0 1
};;2 3
[== 	
Required==	 
]== 
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? 
PrimaryMobileNumber?? *
{??+ ,
get??- 0
;??0 1
set??2 5
;??5 6
}??7 8
[AA 	
StringLengthAA	 
(AA 
$numAA 
)AA 
]AA 
publicBB 
stringBB 
?BB !
SecondaryMobileNumberBB ,
{BB- .
getBB/ 2
;BB2 3
setBB4 7
;BB7 8
}BB9 :
[DD 	
StringLengthDD	 
(DD 
$numDD 
)DD 
]DD 
publicEE 
stringEE 
?EE 
OfficeNumberEE #
{EE$ %
getEE& )
;EE) *
setEE+ .
;EE. /
}EE0 1
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
WhatsAppNumberHH %
{HH& '
getHH( +
;HH+ ,
setHH- 0
;HH0 1
}HH2 3
[JJ 	
EmailAddressJJ	 
]JJ 
publicKK 
requiredKK 
stringKK 
EmailAddressKK +
{KK, -
getKK. 1
;KK1 2
setKK3 6
;KK6 7
}KK8 9
publicMM 
intMM 
SocialMediaTypeIdMM $
{MM% &
getMM' *
;MM* +
setMM, /
;MM/ 0
}MM1 2
publicOO 
stringOO 
?OO 
SocialMediaPlatformOO *
{OO+ ,
getOO- 0
;OO0 1
setOO2 5
;OO5 6
}OO7 8
[QQ 	
StringLengthQQ	 
(QQ 
$numQQ 
)QQ 
]QQ 
publicRR 
stringRR 
?RR 
SocialMediaAccountRR )
{RR* +
getRR, /
;RR/ 0
setRR1 4
;RR4 5
}RR6 7
publicTT 
intTT  
IdentificationTypeIdTT '
{TT( )
getTT* -
;TT- .
setTT/ 2
;TT2 3
}TT4 5
publicVV 
stringVV 
?VV 
IdentificationTypeVV )
{VV* +
getVV, /
;VV/ 0
setVV1 4
;VV4 5
}VV6 7
[XX 	
StringLengthXX	 
(XX 
$numXX 
)XX 
]XX 
publicYY 
stringYY 
?YY $
IdentificationTypeNumberYY /
{YY0 1
getYY2 5
;YY5 6
setYY7 :
;YY: ;
}YY< =
public[[ 
string[[ 
[[[ 
][[ 
?[[  
IdentificationImages[[ -
{[[. /
get[[0 3
;[[3 4
set[[5 8
;[[8 9
}[[: ;
[]] 	
StringLength]]	 
(]] 
$num]] 
)]] 
]]] 
public^^ 
string^^ 
?^^ 
Comments^^ 
{^^  !
get^^" %
;^^% &
set^^' *
;^^* +
}^^, -
public`` 
string`` 
?`` 
DebtorStatus`` #
{``$ %
get``& )
;``) *
set``+ .
;``. /
}``0 1
}bb 
publicdd 

recorddd 1
%IndividualResidentCustomerResponseDtodd 7
:dd8 9)
IndividualCustomerResponseDtodd: W
{ee 
publicff 4
(IndividualNonResidentCustomerResponseDtoff 7
?ff7 8
NonResidentff9 D
{ffE F
getffG J
;ffJ K
setffL O
;ffO P
}ffQ R
publicgg 3
'IndividualExpatriateCustomerResponseDtogg 6
?gg6 7

Expatriategg8 B
{ggC D
getggE H
;ggH I
setggJ M
;ggM N
}ggO P
}ii 
publickk 

recordkk 4
(IndividualNonResidentCustomerResponseDtokk :
{ll 
[mm 	
StringLengthmm	 
(mm 
$nummm 
)mm 
]mm 
publicnn 
stringnn 
?nn "
ContactPerson_FullNamenn -
{nn. /
getnn0 3
;nn3 4
setnn5 8
;nn8 9
}nn: ;
[pp 	
StringLengthpp	 
(pp 
$numpp 
)pp 
]pp 
publicqq 
stringqq 
?qq %
ContactPerson_PhoneNumberqq 0
{qq1 2
getqq3 6
;qq6 7
setqq8 ;
;qq; <
}qq= >
[ss 	
StringLengthss	 
(ss 
$numss 
)ss 
]ss 
[tt 	
EmailAddresstt	 
]tt 
publicuu 
stringuu 
?uu &
ContactPerson_EmailAddressuu 1
{uu2 3
getuu4 7
;uu7 8
setuu9 <
;uu< =
}uu> ?
[ww 	
StringLengthww	 
(ww 
$numww 
)ww 
]ww 
publicxx 
stringxx 
?xx !
ContactPerson_Addressxx ,
{xx- .
getxx/ 2
;xx2 3
setxx4 7
;xx7 8
}xx9 :
publiczz 
intzz .
"ContactPerson_IdentificationTypeIdzz 5
{zz6 7
getzz8 ;
;zz; <
setzz= @
;zz@ A
}zzB C
public|| 
string|| 
?|| ,
 ContactPerson_IdentificationType|| 7
{||8 9
get||: =
;||= >
set||? B
;||B C
}||D E
[~~ 	
StringLength~~	 
(~~ 
$num~~ 
)~~ 
]~~ 
public 
string 
? 2
&ContactPerson_IdentificationTypeNumber =
{> ?
get@ C
;C D
setE H
;H I
}J K
public
ÅÅ 
string
ÅÅ 
[
ÅÅ 
]
ÅÅ 
?
ÅÅ 0
"ContactPerson_IdentificationImages
ÅÅ ;
{
ÅÅ< =
get
ÅÅ> A
;
ÅÅA B
set
ÅÅC F
;
ÅÅF G
}
ÅÅH I
}
ÇÇ 
public
ÑÑ 

record
ÑÑ 5
'IndividualExpatriateCustomerResponseDto
ÑÑ 9
{
ÖÖ 
[
ÜÜ 	
StringLength
ÜÜ	 
(
ÜÜ 
$num
ÜÜ 
)
ÜÜ 
]
ÜÜ 
public
áá 
string
áá 
?
áá "
ResidentPermitNumber
áá +
{
áá, -
get
áá. 1
;
áá1 2
set
áá3 6
;
áá6 7
}
áá8 9
public
ââ 
DateTime
ââ 
?
ââ &
ResidentPermitDateIssued
ââ 1
{
ââ2 3
get
ââ4 7
;
ââ7 8
set
ââ9 <
;
ââ< =
}
ââ> ?
public
ãã 
DateTime
ãã 
?
ãã &
ResidentPermitExpiryDate
ãã 1
{
ãã2 3
get
ãã4 7
;
ãã7 8
set
ãã9 <
;
ãã< =
}
ãã> ?
}
åå 
}èè ôX
é/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/IndividualCustomerDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record !
IndividualCustomerDto $
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
}		0 1
public 
required 
int 
CustomerTypeId *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
required 
int 
ResidentTypeId *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
required 
int 

LocalityId &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
required 
int 
TitleId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 
SurName &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[ 	
StringLength	 
( 
$num 
) 
] 
public 
required 
string 

OtherNames )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
DateTime 
DateOfBirth #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
	TinNumber  
{! "
get# &
;& '
set( +
;+ ,
}- .
[!! 	
StringLength!!	 
(!! 
$num!! 
)!! 
]!! 
public"" 
string"" 
?"" 
Picture"" 
{""  
get""! $
;""$ %
set""& )
;"") *
}""+ ,
public$$ 
int$$ 
GenderId$$ 
{$$ 
get$$ !
;$$! "
set$$# &
;$$& '
}$$( )
public&& 
int&& 
NationalityId&&  
{&&! "
get&&# &
;&&& '
set&&( +
;&&+ ,
}&&- .
[(( 	
StringLength((	 
((( 
$num(( 
)(( 
](( 
public)) 
string)) 
?)) 
PostalAddress)) $
{))% &
get))' *
;))* +
set)), /
;))/ 0
}))1 2
[++ 	
StringLength++	 
(++ 
$num++ 
)++ 
]++ 
public,, 
string,, 
?,, 
ResidentialAddress,, )
{,,* +
get,,, /
;,,/ 0
set,,1 4
;,,4 5
},,6 7
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// 
DigitalAddress// %
{//& '
get//( +
;//+ ,
set//- 0
;//0 1
}//2 3
[11 	
Required11	 
]11 
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 
PrimaryMobileNumber33 *
{33+ ,
get33- 0
;330 1
set332 5
;335 6
}337 8
[55 	
StringLength55	 
(55 
$num55 
)55 
]55 
public66 
string66 
?66 !
SecondaryMobileNumber66 ,
{66- .
get66/ 2
;662 3
set664 7
;667 8
}669 :
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
OfficeNumber99 #
{99$ %
get99& )
;99) *
set99+ .
;99. /
}990 1
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 
WhatsAppNumber<< %
{<<& '
get<<( +
;<<+ ,
set<<- 0
;<<0 1
}<<2 3
[>> 	
EmailAddress>>	 
]>> 
public?? 
required?? 
string?? 
EmailAddress?? +
{??, -
get??. 1
;??1 2
set??3 6
;??6 7
}??8 9
publicAA 
intAA 
SocialMediaTypeIdAA $
{AA% &
getAA' *
;AA* +
setAA, /
;AA/ 0
}AA1 2
[CC 	
StringLengthCC	 
(CC 
$numCC 
)CC 
]CC 
publicDD 
stringDD 
?DD 
SocialMediaAccountDD )
{DD* +
getDD, /
;DD/ 0
setDD1 4
;DD4 5
}DD6 7
publicFF 
intFF  
IdentificationTypeIdFF '
{FF( )
getFF* -
;FF- .
setFF/ 2
;FF2 3
}FF4 5
[HH 	
StringLengthHH	 
(HH 
$numHH 
)HH 
]HH 
publicII 
stringII 
?II $
IdentificationTypeNumberII /
{II0 1
getII2 5
;II5 6
setII7 :
;II: ;
}II< =
publicKK 
stringKK 
[KK 
]KK 
?KK  
IdentificationImagesKK -
{KK. /
getKK0 3
;KK3 4
setKK5 8
;KK8 9
}KK: ;
[MM 	
StringLengthMM	 
(MM 
$numMM 
)MM 
]MM 
publicNN 
stringNN 
?NN 
CommentsNN 
{NN  !
getNN" %
;NN% &
setNN' *
;NN* +
}NN, -
publicPP 
intPP 
DebtorStatusPP 
{PP  !
getPP" %
;PP% &
setPP' *
;PP* +
}PP, -
}RR 
publicTT 

recordTT )
IndividualResidentCustomerDtoTT /
:TT0 1!
IndividualCustomerDtoTT2 G
{UU 
publicVV 
stringVV 
?VV 
	CreatedByVV  
{VV! "
getVV# &
;VV& '
setVV( +
;VV+ ,
}VV- .
publicXX ,
 IndividualNonResidentCustomerDtoXX /
?XX/ 0
NonResidentXX1 <
{XX= >
getXX? B
;XXB C
setXXD G
;XXG H
}XXI J
publicYY +
IndividualExpatriateCustomerDtoYY .
?YY. /

ExpatriateYY0 :
{YY; <
getYY= @
;YY@ A
setYYB E
;YYE F
}YYG H
}ZZ 
public]] 

record]] /
#UpdateIndividualResidentCustomerDto]] 5
:]]6 7!
IndividualCustomerDto]]8 M
{^^ 
public__ 
string__ 
?__ 

ModifiedBy__ !
{__" #
get__$ '
;__' (
set__) ,
;__, -
}__. /
publicaa ,
 IndividualNonResidentCustomerDtoaa /
?aa/ 0
NonResidentaa1 <
{aa= >
getaa? B
;aaB C
setaaD G
;aaG H
}aaI J
publicbb +
IndividualExpatriateCustomerDtobb .
?bb. /

Expatriatebb0 :
{bb; <
getbb= @
;bb@ A
setbbB E
;bbE F
}bbG H
}cc 
publicee 

recordee ,
 IndividualNonResidentCustomerDtoee 2
{ff 
[gg 	
StringLengthgg	 
(gg 
$numgg 
)gg 
]gg 
publichh 
stringhh 
?hh "
ContactPerson_FullNamehh -
{hh. /
gethh0 3
;hh3 4
sethh5 8
;hh8 9
}hh: ;
[jj 	
StringLengthjj	 
(jj 
$numjj 
)jj 
]jj 
publickk 
stringkk 
?kk %
ContactPerson_PhoneNumberkk 0
{kk1 2
getkk3 6
;kk6 7
setkk8 ;
;kk; <
}kk= >
[mm 	
StringLengthmm	 
(mm 
$nummm 
)mm 
]mm 
publicoo 
stringoo 
?oo &
ContactPerson_EmailAddressoo 1
{oo2 3
getoo4 7
;oo7 8
setoo9 <
;oo< =
}oo> ?
[qq 	
StringLengthqq	 
(qq 
$numqq 
)qq 
]qq 
publicrr 
stringrr 
?rr !
ContactPerson_Addressrr ,
{rr- .
getrr/ 2
;rr2 3
setrr4 7
;rr7 8
}rr9 :
publictt 
inttt .
"ContactPerson_IdentificationTypeIdtt 5
{tt6 7
gettt8 ;
;tt; <
settt= @
;tt@ A
}ttB C
publicvv 
stringvv 
?vv 2
&ContactPerson_IdentificationTypeNumbervv =
{vv> ?
getvv@ C
;vvC D
setvvE H
;vvH I
}vvJ K
publicxx 
stringxx 
[xx 
]xx 
?xx .
"ContactPerson_IdentificationImagesxx ;
{xx< =
getxx> A
;xxA B
setxxC F
;xxF G
}xxH I
}yy 
public|| 

record|| +
IndividualExpatriateCustomerDto|| 1
{}} 
[~~ 	
StringLength~~	 
(~~ 
$num~~ 
)~~ 
]~~ 
public 
string 
?  
ResidentPermitNumber +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public
ÅÅ 
DateTime
ÅÅ 
?
ÅÅ &
ResidentPermitDateIssued
ÅÅ 1
{
ÅÅ2 3
get
ÅÅ4 7
;
ÅÅ7 8
set
ÅÅ9 <
;
ÅÅ< =
}
ÅÅ> ?
public
ÉÉ 
DateTime
ÉÉ 
?
ÉÉ &
ResidentPermitExpiryDate
ÉÉ 1
{
ÉÉ2 3
get
ÉÉ4 7
;
ÉÉ7 8
set
ÉÉ9 <
;
ÉÉ< =
}
ÉÉ> ?
}
ÑÑ 
}ÜÜ Û
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/DeleteCustomerRequestDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record $
DeleteCustomerRequestDto '
(' (
string( .
customerCode/ ;
,; <
string= C
	deletedByD M
)M N
;N O
} ø
ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/CustomerRegistrationSuccessResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 

class 2
&CustomerRegistrationSuccessResponseDto 7
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
 
?

 
CustomerCode
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
0 1
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
FullName 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PhoneNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} ∞
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/CustomerRegistrationResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record +
CustomerRegistrationResponseDto .
{ 
public 
bool 
	IsSuccess 
{ 
get  #
;# $
set% (
;( )
}* +
public 2
&CustomerRegistrationSuccessResponseDto 5
?5 6
SuccessResponse7 F
{G H
getI L
;L M
setN Q
;Q R
}S T
public 
BaseResponseDto 
? 
ErrorResponse  -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
}		 
}

 Û
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/CustomerListDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record 
CustomerListDto 
{ 
[ 	
StringLength	 
( 
$num 
) 
] 
public		 
string		 
?		 
CustomerCode		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
FullName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PrimaryMobileNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
[ 	
EmailAddress	 
] 
public 
string 
? 
EmailAddress #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
? 
DebtorStatus #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
} ¡D
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/CompanyCustomerResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 

record &
CompanyCustomerResponseDto ,
{ 
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
}		0 1
public 
int 
CustomerTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
CustomerType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
ResidentTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
ResidentType #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
Locality 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
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
public 
string 
? 
CompanyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
EmailAddress	 
] 
public 
string 
? 
EmailAddress #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[   	
StringLength  	 
(   
$num   
)   
]   
public!! 
string!! 
?!! 
CompanyAddress!! %
{!!& '
get!!( +
;!!+ ,
set!!- 0
;!!0 1
}!!2 3
[## 	
StringLength##	 
(## 
$num## 
)## 
]## 
public$$ 
string$$ 
?$$ 
DigitalAddress$$ %
{$$& '
get$$( +
;$$+ ,
set$$- 0
;$$0 1
}$$2 3
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
PrimaryMobileNumber'' *
{''+ ,
get''- 0
;''0 1
set''2 5
;''5 6
}''7 8
[)) 	
StringLength))	 
()) 
$num)) 
))) 
])) 
public** 
string** 
?** !
SecondaryMobileNumber** ,
{**- .
get**/ 2
;**2 3
set**4 7
;**7 8
}**9 :
[,, 	
StringLength,,	 
(,, 
$num,, 
),, 
],, 
public-- 
string-- 
?-- 
OfficeNumber-- #
{--$ %
get--& )
;--) *
set--+ .
;--. /
}--0 1
[// 	
StringLength//	 
(// 
$num// 
)// 
]// 
public00 
string00 
?00 
WhatsAppNumber00 %
{00& '
get00( +
;00+ ,
set00- 0
;000 1
}002 3
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 &
BusinessRegistrationNumber33 1
{332 3
get334 7
;337 8
set339 <
;33< =
}33> ?
[55 	
StringLength55	 
(55 
$num55 
)55 
]55 
public66 
string66 
?66 
	TinNumber66  
{66! "
get66# &
;66& '
set66( +
;66+ ,
}66- .
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
Picture99 
{99  
get99! $
;99$ %
set99& )
;99) *
}99+ ,
public;; 
int;; 
SocialMediaTypeId;; $
{;;% &
get;;' *
;;;* +
set;;, /
;;;/ 0
};;1 2
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
publicBB 
stringBB 
[BB 
]BB 
?BB  
IdentificationImagesBB -
{BB. /
getBB0 3
;BB3 4
setBB5 8
;BB8 9
}BB: ;
publicDD 
stringDD 
?DD 
DebtorStatusDD #
{DD$ %
getDD& )
;DD) *
setDD+ .
;DD. /
}DD0 1
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG 
CommentsGG 
{GG  !
getGG" %
;GG% &
setGG' *
;GG* +
}GG, -
publicII +
CompanyContactPersonResponseDtoII .
?II. /
ContactPersonII0 =
{II> ?
getII@ C
;IIC D
setIIE H
;IIH I
}IIJ K
}KK 
publicMM 

recordMM +
CompanyContactPersonResponseDtoMM 1
{NN 
[OO 	
StringLengthOO	 
(OO 
$numOO 
)OO 
]OO 
publicPP 
stringPP 
?PP "
ContactPerson_FullNamePP -
{PP. /
getPP0 3
;PP3 4
setPP5 8
;PP8 9
}PP: ;
[RR 	
StringLengthRR	 
(RR 
$numRR 
)RR 
]RR 
publicSS 
stringSS 
?SS %
ContactPerson_PhoneNumberSS 0
{SS1 2
getSS3 6
;SS6 7
setSS8 ;
;SS; <
}SS= >
[UU 	
StringLengthUU	 
(UU 
$numUU 
)UU 
]UU 
[VV 	
EmailAddressVV	 
]VV 
publicWW 
stringWW 
?WW &
ContactPerson_EmailAddressWW 1
{WW2 3
getWW4 7
;WW7 8
setWW9 <
;WW< =
}WW> ?
[YY 	
StringLengthYY	 
(YY 
$numYY 
)YY 
]YY 
publicZZ 
stringZZ 
?ZZ !
ContactPerson_AddressZZ ,
{ZZ- .
getZZ/ 2
;ZZ2 3
setZZ4 7
;ZZ7 8
}ZZ9 :
public\\ 
int\\ .
"ContactPerson_IdentificationTypeId\\ 5
{\\6 7
get\\8 ;
;\\; <
set\\= @
;\\@ A
}\\B C
public^^ 
string^^ 
?^^ ,
 ContactPerson_IdentificationType^^ 7
{^^8 9
get^^: =
;^^= >
set^^? B
;^^B C
}^^D E
[`` 	
StringLength``	 
(`` 
$num`` 
)`` 
]`` 
publicaa 
stringaa 
?aa 2
&ContactPerson_IdentificationTypeNumberaa =
{aa> ?
getaa@ C
;aaC D
setaaE H
;aaH I
}aaJ K
publiccc 
stringcc 
[cc 
]cc 
?cc .
"ContactPerson_IdentificationImagescc ;
{cc< =
getcc> A
;ccA B
setccC F
;ccF G
}ccH I
}dd 
}ee àE
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Customer/CompanyCustomerDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
.) *

Management* 4
.4 5
Customer5 =
{ 
public 
record 
CompanyCustomerDto !
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
}		0 1
public 
int 
CustomerTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
ResidentTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CompanyName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
NationalityId  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
EmailAddress	 
] 
public 
string 
? 
EmailAddress #
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
? 
CompanyAddress %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
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
public## 
string## 
?## 
PrimaryMobileNumber## *
{##+ ,
get##- 0
;##0 1
set##2 5
;##5 6
}##7 8
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
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// &
BusinessRegistrationNumber// 1
{//2 3
get//4 7
;//7 8
set//9 <
;//< =
}//> ?
[11 	
StringLength11	 
(11 
$num11 
)11 
]11 
public22 
string22 
?22 
	TinNumber22  
{22! "
get22# &
;22& '
set22( +
;22+ ,
}22- .
[44 	
StringLength44	 
(44 
$num44 
)44 
]44 
public55 
string55 
?55 
Picture55 
{55  
get55! $
;55$ %
set55& )
;55) *
}55+ ,
public77 
int77 
SocialMediaTypeId77 $
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
?:: 
SocialMediaAccount:: )
{::* +
get::, /
;::/ 0
set::1 4
;::4 5
}::6 7
public<< 
int<< 
DebtorStatus<< 
{<<  !
get<<" %
;<<% &
set<<' *
;<<* +
}<<, -
[>> 	
StringLength>>	 
(>> 
$num>> 
)>> 
]>> 
public?? 
string?? 
??? 
Comments?? 
{??  !
get??" %
;??% &
set??' *
;??* +
}??, -
publicAA 
stringAA 
[AA 
]AA 
?AA  
IdentificationImagesAA -
{AA. /
getAA0 3
;AA3 4
setAA5 8
;AA8 9
}AA: ;
publicCC  
CompanyContactPersonCC #
?CC# $
ContactPersonCC% 2
{CC3 4
getCC5 8
;CC8 9
setCC: =
;CC= >
}CC? @
}DD 
publicFF 

recordFF $
CreateCompanyCustomerDtoFF *
:FF* +
CompanyCustomerDtoFF, >
{GG 
[HH 	
StringLengthHH	 
(HH 
$numHH 
)HH 
]HH 
publicII 
stringII 
?II 
	CreatedByII  
{II! "
getII# &
;II& '
setII( +
;II+ ,
}II- .
}JJ 
publicLL 

recordLL $
UpdateCompanyCustomerDtoLL *
:LL* +
CompanyCustomerDtoLL, >
{MM 
[NN 	
StringLengthNN	 
(NN 
$numNN 
)NN 
]NN 
publicOO 
stringOO 
?OO 

ModifiedByOO !
{OO" #
getOO$ '
;OO' (
setOO) ,
;OO, -
}OO. /
}PP 
publicSS 

recordSS  
CompanyContactPersonSS &
{TT 
[UU 	
StringLengthUU	 
(UU 
$numUU 
)UU 
]UU 
publicVV 
stringVV 
?VV "
ContactPerson_FullNameVV -
{VV. /
getVV0 3
;VV3 4
setVV5 8
;VV8 9
}VV: ;
[XX 	
StringLengthXX	 
(XX 
$numXX 
)XX 
]XX 
publicYY 
stringYY 
?YY %
ContactPerson_PhoneNumberYY 0
{YY1 2
getYY3 6
;YY6 7
setYY8 ;
;YY; <
}YY= >
[[[ 	
StringLength[[	 
([[ 
$num[[ 
)[[ 
][[ 
[\\ 	
EmailAddress\\	 
]\\ 
public]] 
string]] 
?]] &
ContactPerson_EmailAddress]] 1
{]]2 3
get]]4 7
;]]7 8
set]]9 <
;]]< =
}]]> ?
[__ 	
StringLength__	 
(__ 
$num__ 
)__ 
]__ 
public`` 
string`` 
?`` !
ContactPerson_Address`` ,
{``- .
get``/ 2
;``2 3
set``4 7
;``7 8
}``9 :
publicbb 
intbb .
"ContactPerson_IdentificationTypeIdbb 5
{bb6 7
getbb8 ;
;bb; <
setbb= @
;bb@ A
}bbB C
[dd 	
StringLengthdd	 
(dd 
$numdd 
)dd 
]dd 
publicee 
stringee 
?ee 2
&ContactPerson_IdentificationTypeNumberee =
{ee> ?
getee@ C
;eeC D
seteeE H
;eeH I
}eeJ K
publicgg 
stringgg 
[gg 
]gg 
?gg .
"ContactPerson_IdentificationImagesgg ;
{gg< =
getgg> A
;ggA B
setggC F
;ggF G
}ggH I
}hh 
}jj Ò
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/BaseResponseDto.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DTO& )
{ 
public 
record 
BaseResponseDto 
{ 
public 
required 
int 

StatusCode &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
required 
string 
StatusMessage ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
}		 
}

 °
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DomainServices/PropertyDomainServices.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DomainServices& 4
{ 
public 
class "
PropertyDomainServices $
{ 
public "
PropertyDomainServices	 
(  
)  !
{ 
} 
}		 
}

 ™
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DomainServices/DomainEventDispatcher.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
Services& .
{		 
public

 

class

 !
DomainEventDispatcher

 &
:

' ("
IDomainEventDispatcher

) ?
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
ILogger  
<  !!
DomainEventDispatcher! 6
>6 7
_logger8 ?
;? @
public !
DomainEventDispatcher $
($ %
IUnitOfWork% 0

unitOfWork1 ;
,; <
ILogger= D
<D E!
DomainEventDispatcherE Z
>Z [
logger\ b
)b c
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_logger 
= 
logger 
; 
} 	
public 
async 
Task 
DispatchAsync '
(' (
DomainEvent( 3
domainEvent4 ?
)? @
{ 	
if 
( 
domainEvent 
is  
CustomerCreatedEvent 3
customerCreated4 C
)C D
{ 
await &
HandleCustomerCreatedEvent 0
(0 1
customerCreated1 @
)@ A
;A B
} 
} 	
private 
async 
Task &
HandleCustomerCreatedEvent 5
(5 6 
CustomerCreatedEvent6 J
@eventK Q
)Q R
{ 	
try   
{!! 
_logger## 
.## 
LogInformation## &
(##& '
$"##' )
$str##) -
{##- .
@event##. 4
.##4 5
CustomerType##5 A
}##A B
$str##B U
{##U V
@event##V \
.##\ ]
CustomerCode##] i
}##i j
"##j k
)##k l
;##l m
}44 
catch55 
(55 
	Exception55 
ex55 
)55  
{66 
_logger77 
.77 
LogError77  
(77  !
ex77! #
,77# $
$"77% '
$str77' R
{77R S
@event77S Y
.77Y Z
CustomerCode77Z f
}77f g
"77g h
)77h i
;77i j
throw88 
;88 
}99 
}:: 	
};; 
}<< …>
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DomainServices/CustomerDomainService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Application %
.% &
DomainServices& 4
{ 
public 
class !
CustomerDomainService #
:$ %"
ICustomerDomainService& <
{ 
private		 
readonly		 
IUnitOfWork		 $
_unitOfWork		% 0
;		0 1
public !
CustomerDomainService	 
( 
IUnitOfWork *

unitOfWork+ 5
)5 6
{ 
_unitOfWork 
= 

unitOfWork $
;$ %
} 
public 
async 
Task 
< 
bool 
> 
CustomerTypeExists  2
(2 3
int3 6
customerTypeId7 E
)E F
{ 	
var 
result 
= 
await 
_unitOfWork *
.* +
CustomerType+ 7
.7 8
Get8 ;
(; <
customerTypeId< J
)J K
;K L
if 
( 
result 
is 
null 
) 
{ 
return 
false 
; 
} 
return 
true 
; 
} 	
public 
async 
Task 
< 
bool 
> 
GenderExists  ,
(, -
int- 0
genderId1 9
)9 :
{ 	
var 
result 
= 
await 
_unitOfWork *
.* +
Gender+ 1
.1 2
Get2 5
(5 6
genderId6 >
)> ?
;? @
if 
( 
result 
is 
null 
) 
{ 
return   
false   
;   
}!! 
return## 
true## 
;## 
}$$ 	
public&& 
async&& 
Task&& 
<&& 
Locality&& "
>&&" #
GetLocalityDetails&&$ 6
(&&6 7
int&&7 :

localityId&&; E
)&&E F
{'' 	
var(( 
result(( 
=(( 
await(( 
_unitOfWork(( *
.((* +
Locality((+ 3
.((3 4
Get((4 7
(((7 8

localityId((8 B
)((B C
;((C D
if)) 
()) 
result)) 
is)) 
null)) 
))) 
{** 
return++ 
null++ 
!++ 
;++ 
},, 
return.. 
result.. 
;.. 
}// 	
public11 
async11 
Task11 
<11 
bool11 
>11 $
IdentificationTypeExists11  8
(118 9
int119 < 
identificationTypeId11= Q
)11Q R
{22 	
var33 
result33 
=33 
await33 
_unitOfWork33 *
.33* +
IdentificationType33+ =
.33= >
Get33> A
(33A B 
identificationTypeId33B V
)33V W
;33W X
if44 
(44 
result44 
is44 
null44 
)44 
{55 
return66 
false66 
;66 
}77 
return99 
true99 
;99 
}:: 	
public<< 
async<< 
Task<< 
<<< 
bool<< 
><< 
LocalityExists<<  .
(<<. /
int<</ 2

localityId<<3 =
)<<= >
{== 	
var>> 
result>> 
=>> 
await>> 
_unitOfWork>> *
.>>* +
Locality>>+ 3
.>>3 4
Get>>4 7
(>>7 8

localityId>>8 B
)>>B C
;>>C D
if?? 
(?? 
result?? 
is?? 
null?? 
)?? 
{@@ 
returnAA 
falseAA 
;AA 
}BB 
returnDD 
trueDD 
;DD 
}EE 	
publicGG 
asyncGG 
TaskGG 
<GG 
boolGG 
>GG 
NationalityExistsGG  1
(GG1 2
intGG2 5
nationalityIdGG6 C
)GGC D
{HH 	
varII 
resultII 
=II 
awaitII 
_unitOfWorkII *
.II* +
NationalityII+ 6
.II6 7
GetII7 :
(II: ;
nationalityIdII; H
)IIH I
;III J
ifJJ 
(JJ 
resultJJ 
isJJ 
nullJJ 
)JJ 
{KK 
returnLL 
falseLL 
;LL 
}MM 
returnOO 
trueOO 
;OO 
}PP 	
publicRR 
asyncRR 
TaskRR 
<RR 
boolRR 
>RR 
ResidentTypeExistsRR  2
(RR2 3
intRR3 6
residentTypeIdRR7 E
)RRE F
{SS 	
varTT 
resultTT 
=TT 
awaitTT 
_unitOfWorkTT *
.TT* +
ResidentTypeTT+ 7
.TT7 8
GetTT8 ;
(TT; <
residentTypeIdTT< J
)TTJ K
;TTK L
ifUU 
(UU 
resultUU 
isUU 
nullUU 
)UU 
{VV 
returnWW 
falseWW 
;WW 
}XX 
returnZZ 
trueZZ 
;ZZ 
}[[ 	
public]] 
async]] 
Task]] 
<]] 
bool]] 
>]] 
SocialMediaExists]]  1
(]]1 2
int]]2 5
socialMediaTypeId]]6 G
)]]G H
{^^ 	
var__ 
result__ 
=__ 
await__ 
_unitOfWork__ *
.__* +
SocialMedia__+ 6
.__6 7
Get__7 :
(__: ;
socialMediaTypeId__; L
)__L M
;__M N
if`` 
(`` 
result`` 
is`` 
null`` 
)`` 
{aa 
returnbb 
falsebb 
;bb 
}cc 
returnee 
trueee 
;ee 
}ff 	
publichh 
asynchh 
Taskhh 
<hh 
boolhh 
>hh 
TitleExistshh  +
(hh+ ,
inthh, /
titleIdhh0 7
)hh7 8
{ii 	
varjj 
resultjj 
=jj 
awaitjj 
_unitOfWorkjj *
.jj* +
Titlejj+ 0
.jj0 1
Getjj1 4
(jj4 5
titleIdjj5 <
)jj< =
;jj= >
ifkk 
(kk 
resultkk 
iskk 
nullkk 
)kk 
{ll 
returnmm 
falsemm 
;mm 
}nn 
returnpp 
truepp 
;pp 
}qq 	
publicss 
asyncss 
Taskss 
<ss 
boolss 
>ss 
CustomerExistsss  .
(ss. /
intss/ 2
CustomerMasterIdss3 C
)ssC D
{tt 	
varuu 
resultuu 
=uu 
awaituu 
_unitOfWorkuu *
.uu* +
CustomerMasteruu+ 9
.uu9 :
Getuu: =
(uu= >
CustomerMasterIduu> N
)uuN O
;uuO P
ifvv 
(vv 
resultvv 
isvv 
nullvv 
)vv 
{ww 
returnxx 
falsexx 
;xx 
}yy 
return{{ 
true{{ 
;{{ 
}|| 	
}
ÅÅ 
}ÇÇ 