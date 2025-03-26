÷
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/ResidentPermit.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 
ResidentPermit 
{ 
public 

string 
Number 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
public 

DateTime 

DateIssued 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
public 

DateTime 

ExpiryDate 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
private		 
ResidentPermit		 
(		 
)		 
{		 
}		  
public 

static 
ResidentPermit  
Create! '
(' (
string( .
number/ 5
,5 6
DateTime7 ?

dateIssued@ J
,J K
DateTimeL T

expiryDateU _
)_ `
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
number& ,
), -
)- .
throw 
new 
ArgumentException '
(' (
$str( G
)G H
;H I
if 

( 

expiryDate 
<= 

dateIssued $
)$ %
throw 
new 
ArgumentException '
(' (
$str( N
)N O
;O P
return 
new 
ResidentPermit !
{ 	
Number 
= 
number 
. 
Trim  
(  !
)! "
," #

DateIssued 
= 

dateIssued #
,# $

ExpiryDate 
= 

expiryDate #
} 	
;	 

} 
public 

bool 
IsValid 
( 
) 
=> 
DateTime %
.% &
UtcNow& ,
<=- /

ExpiryDate0 :
;: ;
} ¬
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/PersonName.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 

PersonName 
{ 
public 

int 
TitleId 
{ 
get 
; 
private %
set& )
;) *
}+ ,
public 

string 
SurName 
{ 
get 
;  
private! (
set) ,
;, -
}. /
public 

string 

OtherNames 
{ 
get "
;" #
private$ +
set, /
;/ 0
}1 2
private		 

PersonName		 
(		 
)		 
{		 
}		 
public 

static 

PersonName 
Create #
(# $
int$ '
titleId( /
,/ 0
string1 7
surName8 ?
,? @
stringA G

otherNamesH R
)R S
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
surName& -
)- .
). /
throw 
new 
ArgumentException '
(' (
$str( A
)A B
;B C
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &

otherNames& 0
)0 1
)1 2
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
return 
new 

PersonName 
{ 	
TitleId 
= 
titleId 
, 
SurName 
= 
surName 
. 
Trim "
(" #
)# $
,$ %

OtherNames 
= 

otherNames #
.# $
Trim$ (
(( )
)) *
} 	
;	 

} 
public 

string 
FullName 
=> 
$"  
{  !
SurName! (
}( )
$str) +
{+ ,

OtherNames, 6
}6 7
"7 8
;8 9
}  
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/Identification.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 
Identification 
{ 
public 

int 
TypeId 
{ 
get 
; 
private $
set% (
;( )
}* +
public 

string 
Number 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
public 

IReadOnlyList 
< 
string 
>  
Images! '
{( )
get* -
;- .
private/ 6
set7 :
;: ;
}< =
private		 
Identification		 
(		 
)		 
{		 
}		  
public 

static 
Identification  
Create! '
(' (
int( +
typeId, 2
,2 3
string4 :
number; A
,A B
ListC G
<G H
stringH N
>N O
imagesP V
)V W
{ 
if 

( 
typeId 
<= 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
number& ,
), -
)- .
throw 
new 
ArgumentException '
(' (
$str( O
)O P
;P Q
return 
new 
Identification !
{ 	
TypeId 
= 
typeId 
, 
Number 
= 
number 
. 
Trim  
(  !
)! "
," #
Images 
= 
images 
? 
. 

AsReadOnly '
(' (
)( )
??* ,
new- 0
List1 5
<5 6
string6 <
>< =
(= >
)> ?
.? @

AsReadOnly@ J
(J K
)K L
} 	
;	 

} 
} ¶
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/ContactPerson.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 
ContactPerson 
{ 
public 

string 
FullName 
{ 
get  
;  !
private" )
set* -
;- .
}/ 0
public 

string 
PhoneNumber 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
public		 

string		 
EmailAddress		 
{		  
get		! $
;		$ %
private		& -
set		. 1
;		1 2
}		3 4
public

 

string

 
Address

 
{

 
get

 
;

  
private

! (
set

) ,
;

, -
}

. /
public 

Identification 
Identification (
{) *
get+ .
;. /
private0 7
set8 ;
;; <
}= >
private 
ContactPerson 
( 
) 
{ 
} 
public 

static 
ContactPerson 
Create  &
(& '
string 
fullName 
, 
string 
phoneNumber 
, 
string 
emailAddress 
, 
string 
address 
, 
Identification 
identification %
)% &
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
fullName& .
). /
)/ 0
throw 
new 
ArgumentException '
(' (
$str( M
)M N
;N O
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
phoneNumber& 1
)1 2
)2 3
throw 
new 
ArgumentException '
(' (
$str( N
)N O
;O P
return 
new 
ContactPerson  
{ 	
FullName 
= 
fullName 
.  
Trim  $
($ %
)% &
,& '
PhoneNumber 
= 
phoneNumber %
.% &
Trim& *
(* +
)+ ,
,, -
EmailAddress 
= 
emailAddress '
?' (
.( )
Trim) -
(- .
). /
,/ 0
Address   
=   
address   
?   
.   
Trim   #
(  # $
)  $ %
,  % &
Identification!! 
=!! 
identification!! +
}"" 	
;""	 

}## 
}$$ •
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/ContactInformation.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 
ContactInformation 
{ 
public 

string 
PrimaryMobileNumber %
{& '
get( +
;+ ,
private- 4
set5 8
;8 9
}: ;
public 

string !
SecondaryMobileNumber '
{( )
get* -
;- .
private/ 6
set7 :
;: ;
}< =
public 

string 
OfficeNumber 
{  
get! $
;$ %
private& -
set. 1
;1 2
}3 4
public 

string 
WhatsAppNumber  
{! "
get# &
;& '
private( /
set0 3
;3 4
}5 6
public		 

string		 
EmailAddress		 
{		  
get		! $
;		$ %
private		& -
set		. 1
;		1 2
}		3 4
private 
ContactInformation 
( 
)  
{! "
}# $
public 

static 
ContactInformation $
Create% +
(+ ,
string 
primaryMobileNumber "
," #
string 
emailAddress 
, 
string !
secondaryMobileNumber $
=% &
null' +
,+ ,
string 
officeNumber 
= 
null "
," #
string 
whatsAppNumber 
= 
null  $
)$ %
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
primaryMobileNumber& 9
)9 :
): ;
throw 
new 
ArgumentException '
(' (
$str( O
)O P
;P Q
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
emailAddress& 2
)2 3
||4 6
!7 8
emailAddress8 D
.D E
ContainsE M
(M N
$strN Q
)Q R
)R S
throw 
new 
ArgumentException '
(' (
$str( ?
)? @
;@ A
return 
new 
ContactInformation %
{ 	
PrimaryMobileNumber 
=  !
primaryMobileNumber" 5
.5 6
Trim6 :
(: ;
); <
,< =!
SecondaryMobileNumber !
=" #!
secondaryMobileNumber$ 9
?9 :
.: ;
Trim; ?
(? @
)@ A
,A B
OfficeNumber 
= 
officeNumber '
?' (
.( )
Trim) -
(- .
). /
,/ 0
WhatsAppNumber 
= 
whatsAppNumber +
?+ ,
., -
Trim- 1
(1 2
)2 3
,3 4
EmailAddress 
= 
emailAddress '
.' (
Trim( ,
(, -
)- .
.. /
ToLower/ 6
(6 7
)7 8
}   	
;  	 

}!! 
}"" Ú
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/Address.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
ValueObjects! -
.- .
Customer. 6
;6 7
public 
class 
Address 
{ 
public 

string 
PostalAddress 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 

string 
ResidentialAddress $
{% &
get' *
;* +
private, 3
set4 7
;7 8
}9 :
public 

string 
DigitalAddress  
{! "
get# &
;& '
private( /
set0 3
;3 4
}5 6
private

 
Address

 
(

 
)

 
{

 
}

 
public 

static 
Address 
Create  
(  !
string! '
postalAddress( 5
,5 6
string7 =
residentialAddress> P
,P Q
stringR X
digitalAddressY g
)g h
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
postalAddress& 3
)3 4
)4 5
throw 
new 
ArgumentException '
(' (
$str( H
)H I
;I J
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
residentialAddress& 8
)8 9
)9 :
throw 
new 
ArgumentException '
(' (
$str( M
)M N
;N O
return 
new 
Address 
{ 	
PostalAddress 
= 
postalAddress )
.) *
Trim* .
(. /
)/ 0
,0 1
ResidentialAddress 
=  
residentialAddress! 3
.3 4
Trim4 8
(8 9
)9 :
,: ;
DigitalAddress 
= 
digitalAddress +
?+ ,
., -
Trim- 1
(1 2
)2 3
} 	
;	 

} 
} d
b/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Usings.csΩ
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Registration/IPropertyMasterRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Registration, 8
{ 
public 
	interface %
IPropertyMasterRepository +
:, -
IRepository. 9
<9 :
PropertyMaster: H
>H I
{ 
} 
} Ω
ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Registration/ICustomerMasterRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Registration, 8
{ 
public 
	interface %
ICustomerMasterRepository +
:, -
IRepository. 9
<9 :
CustomerMaster: H
>H I
{ 
} 
} ™
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Management/IStopDebitRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,

Management, 6
{ 
public 
	interface  
IStopDebitRepository &
:' (
IRepository) 4
<4 5
	StopDebit5 >
>> ?
{ 
}		 
}

 Û
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/IUnitOfWork.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
;  !
public 
	interface 
IUnitOfWork 
: 
IDisposable *
{ #
ICustomerTypeRepository 
CustomerType (
{) *
get+ .
;. /
}0 1
IGenderRepository		 
Gender		 
{		 
get		 "
;		" #
}		$ %)
IIdentificationTypeRepository

 !
IdentificationType

" 4
{

5 6
get

7 :
;

: ;
}

< ="
INationalityRepository 
Nationality &
{' (
get) ,
;, -
}. /#
IResidentTypeRepository 
ResidentType (
{) *
get+ .
;. /
}0 1"
ISocialMediaRepository 
SocialMedia &
{' (
get) ,
;, -
}. /
ITitleRepository 
Title 
{ 
get  
;  !
}" #%
IAllocationTypeRepository 
AllocationType ,
{- .
get/ 2
;2 3
}4 5%
IApartmentTypesRepository 
ApartmentTypes ,
{- .
get/ 2
;2 3
}4 5"
IBlockNumberRepository 
BlockNumber &
{' (
get) ,
;, -
}. /!
IBlockSidesRepository 

BlockSides $
{% &
get' *
;* +
}, - 
IBlockTypeRepository 
	BlockType "
{# $
get% (
;( )
}* + 
IBlockUnitRepository 
	BlockUnit "
{# $
get% (
;( )
}* +!
IFacilitiesRepository 

Facilities $
{% &
get' *
;* +
}, -%
IFloorNumberingRepository 
FloorNumbering ,
{- .
get/ 2
;2 3
}4 5
ILandUseRepository 
LandUse 
{  
get! $
;$ %
}& '"
ILandUseTypeRepository 
LandUseType &
{' (
get) ,
;, -
}. /
ILocalityRepository 
Locality  
{! "
get# &
;& '
}( )
IPlotSizeRepository 
PlotSize  
{! "
get# &
;& '
}( )%
IPropertyHeightRepository 
PropertyHeight ,
{- .
get/ 2
;2 3
}4 5#
IPropertyTypeRepository 
PropertyType (
{) *
get+ .
;. /
}0 1%
ICustomerMasterRepository!! 
CustomerMaster!! ,
{!!- .
get!!/ 2
;!!2 3
}!!4 5%
IPropertyMasterRepository"" 
PropertyMaster"" ,
{""- .
get""/ 2
;""2 3
}""4 5
IActivityRepository%% 
Activity%%  
{%%! "
get%%# &
;%%& '
}%%( )#
IActivityTypeRepository&& 
ActivityType&& (
{&&) *
get&&+ .
;&&. /
}&&0 1$
IOwnershipTypeRepository(( 
OwnershipType(( *
{((+ ,
get((- 0
;((0 1
}((2 3 
IStopDebitRepository++ 
	StopDebit++ "
{++# $
get++% (
;++( )
}++* +
Task-- 
<-- 	
int--	 
>-- 
Complete-- 
(-- 
)-- 
;-- 
}.. ú
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/IRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
;  !
public 
	interface 
IRepository 
< 
TEntity $
>$ %
where& +
TEntity, 3
:4 5
class6 ;
{ 
Task 
< 	
TEntity	 
? 
> 
Get 
( 
int 
id 
) 
; 
Task 
< 	
IList	 
< 
TEntity 
> 
> 
GetAll 
(  

Expression 
< 
Func 
<  
TEntity  '
,' (
bool) -
>- .
>. /
?/ 0

expression1 ;
=< =
null> B
,B C
Func 
< 

IQueryable 
<  
TEntity  '
>' (
,( )
IOrderedQueryable* ;
<; <
TEntity< C
>C D
>D E
?E F
orderByG N
=O P
nullQ U
,U V
List 
< 
string 
> 
? 
includes &
=' (
null) -
) 
; 
Task 
< 	
IList	 
< 
TEntity 
> 
> 
GetAll 
(  
)  !
;! "
Task 
< 	
TEntity	 
? 
> 
Get 
( 

Expression !
<! "
Func" &
<& '
TEntity' .
,. /
bool0 4
>4 5
>5 6

expression7 A
,A B
ListC G
<G H
stringH N
>N O
?O P
includesQ Y
=Z [
null\ `
)` a
;a b
void 
Insert	 
( 
TEntity 
entity 
) 
;  
void 
InsertRange	 
( 
IEnumerable  
<  !
TEntity! (
>( )
entities* 2
)2 3
;3 4
void 
Delete	 
( 
TEntity 
entity 
) 
;  
void 
DeleteRange	 
( 
IEnumerable  
<  !
TEntity! (
>( )
entities* 2
)2 3
;3 4
void 
Update	 
( 
TEntity 
entity 
) 
;  
void   
UpdateRange  	 
(   
IEnumerable    
<    !
TEntity  ! (
>  ( )
entities  * 2
)  2 3
;  3 4
}!! Ù
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPropertyTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface #
IPropertyTypeRepository (
:) *
IRepository+ 6
<6 7
PropertyType7 C
>C D
{ 
} ˙
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPropertyHeightRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface %
IPropertyHeightRepository *
:+ ,
IRepository- 8
<8 9
PropertyHeight9 G
>G H
{ 
} Ë
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPlotSizeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface 
IPlotSizeRepository $
:$ %
IRepository& 1
<1 2
PlotSize2 :
>: ;
{ 
} Ë
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILocalityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface 
ILocalityRepository $
:% &
IRepository' 2
<2 3
Locality3 ;
>; <
{ 
} Ò
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILandUseTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface "
ILandUseTypeRepository '
:( )
IRepository* 5
<5 6
LandUseType6 A
>A B
{ 
} Â
ë/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILandUseRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface 
ILandUseRepository #
:$ %
IRepository& 1
<1 2
LandUse2 9
>9 :
{ 
} ˙
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IFloorNumberingRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface %
IFloorNumberingRepository *
:+ ,
IRepository- 8
<8 9
FloorNumbering9 G
>G H
{ 
} Ó
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IFacilitiesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface !
IFacilitiesRepository &
:' (
IRepository) 4
<4 5

Facilities5 ?
>? @
{ 
} Î
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockUnitRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface  
IBlockUnitRepository %
:& '
IRepository( 3
<3 4
	BlockUnit4 =
>= >
{ 
} Ï
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface  
IBlockTypeRepository %
:& '
IRepository( 3
<3 4

BlockTypes4 >
>> ?
{ 
} Ó
î/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockSidesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface !
IBlockSidesRepository &
:' (
IRepository) 4
<4 5

BlockSides5 ?
>? @
{ 
} É
õ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockPurchaseTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface (
IBlockPurchaseTypeRepository -
:. /
IRepository0 ;
<; <
BlockPurchaseType< M
>M N
{ 
} Ò
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockNumberRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface "
IBlockNumberRepository '
:( )
IRepository* 5
<5 6
BlockNumber6 A
>A B
{ 
} ˙
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IApartmentTypesRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface %
IApartmentTypesRepository *
:+ ,
IRepository- 8
<8 9
ApartmentTypes9 G
>G H
{ 
} ˙
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IAllocationTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
;C D
public 
	interface %
IAllocationTypeRepository *
:+ ,
IRepository- 8
<8 9
AllocationType9 G
>G H
{ 
} Ö
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IActivityTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
{ 
public 
	interface #
IActivityTypeRepository )
:* +
IRepository, 7
<7 8
ActivityType8 D
>D E
{ 
} 
} ˘
í/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IActivityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Property; C
{ 
public 
	interface 
IActivityRepository %
:& '
IRepository( 3
<3 4
Activity4 <
>< =
{ 
} 
} ﬂ
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ITitleRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface 
ITitleRepository !
:" #
IRepository$ /
</ 0
Title0 5
>5 6
{ 
} Ò
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ISocialMediaRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface "
ISocialMediaRepository '
:( )
IRepository* 5
<5 6
SocialMedia6 A
>A B
{ 
} Ù
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IResidentTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface #
IResidentTypeRepository (
:) *
IRepository+ 6
<6 7
ResidentType7 C
>C D
{ 
} à
ó/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IOwnershipTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
{ 
public 
	interface $
IOwnershipTypeRepository *
:+ ,
IRepository- 8
<8 9
OwnershipType9 F
>F G
{ 
} 
} Ò
ï/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/INationalityRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface "
INationalityRepository '
:( )
IRepository* 5
<5 6
Nationality6 A
>A B
{ 
} Ü
ú/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IIdentificationTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface )
IIdentificationTypeRepository .
:/ 0
IRepository1 <
<< =
IdentificationType= O
>O P
{ 
} ‚
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IGenderRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface 
IGenderRepository "
:# $
IRepository% 0
<0 1
Gender1 7
>7 8
{ 
} Ù
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ICustomerTypeRepository.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
Entities, 4
.4 5
Setup5 :
.: ;
Customer; C
;C D
public 
	interface #
ICustomerTypeRepository (
:) *
IRepository+ 6
<6 7
CustomerType7 C
>C D
{ 
} Ÿ
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/DomainServices/IPropertyDomainService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
DomainServices, :
{ 
public 
	interface "
IPropertyDomainService (
{ 
} 
} ô
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/DomainServices/ICustomerDomainService.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !

Interfaces! +
.+ ,
DomainServices, :
{ 
public 
	interface "
ICustomerDomainService (
{ 
Task 
< 
bool 
> 
LocalityExists !
(! "
int" %

localityId& 0
)0 1
;1 2
Task 
< 
bool 
> 
CustomerTypeExists %
(% &
int& )
customerTypeId* 8
)8 9
;9 :
Task 
< 
bool 
> 
ResidentTypeExists %
(% &
int& )
residentTypeId* 8
)8 9
;9 :
Task		 
<		 
bool		 
>		 
TitleExists		 
(		 
int		 "
titleId		# *
)		* +
;		+ ,
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
 
GenderExists

 
(

  
int

  #
genderId

$ ,
)

, -
;

- .
Task 
< 
bool 
> 
NationalityExists $
($ %
int% (
nationalityId) 6
)6 7
;7 8
Task 
< 
bool 
> 
SocialMediaExists $
($ %
int% (
socialMediaTypeId) :
): ;
;; <
Task 
< 
bool 
> $
IdentificationTypeExists +
(+ ,
int, / 
identificationTypeId0 D
)D E
;E F
Task 
< 
bool 
> 
CustomerExists !
(! "
int" %
CustomerMasterId& 6
)6 7
;7 8
Task 
< 
Locality 
> 
GetLocalityDetails )
() *
int* -

localityId. 8
)8 9
;9 :
} 
} ¢
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/IDomainEventDispatcher.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
{ 
public 

	interface "
IDomainEventDispatcher +
{ 
Task 
DispatchAsync 
( 
DomainEvent &
domainEvent' 2
)2 3
;3 4
} 
}		 ¶
n/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/DomainEvent.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
{ 
[ 
Keyless 
] 
public 

abstract 
class 
DomainEvent %
{ 
public		 
DateTime		 

OccurredOn		 "
{		# $
get		% (
;		( )
}		* +
public

 
string

 
	EventType

 
{

  !
get

" %
;

% &
}

' (
	protected 
DomainEvent 
( 
) 
{ 	

OccurredOn 
= 
DateTime !
.! "
UtcNow" (
;( )
	EventType 
= 
GetType 
(  
)  !
.! "
Name" &
;& '
} 	
} 
} ˙
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerUpdatedEvent.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
.' (
Customer( 0
{ 
public 

class  
CustomerUpdatedEvent %
:& '
DomainEvent( 3
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
}+ ,
public 
string 
CustomerCode "
{# $
get% (
;( )
}* +
public		 
string		 
	UpdatedBy		 
{		  !
get		" %
;		% &
}		' (
public

 
string

 

UpdateType

  
{

! "
get

# &
;

& '
}

( )
public  
CustomerUpdatedEvent #
(# $
int$ '
customerMasterId( 8
,8 9
string: @
customerCodeA M
,M N
stringO U
	updatedByV _
,_ `
stringa g

updateTypeh r
)r s
{ 	
CustomerMasterId 
= 
customerMasterId /
;/ 0
CustomerCode 
= 
customerCode '
;' (
	UpdatedBy 
= 
	updatedBy !
;! "

UpdateType 
= 

updateType #
;# $
} 	
} 
} ©
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerStatusChangedEvent.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
.' (
Customer( 0
{ 
public 

class &
CustomerStatusChangedEvent +
:, -
DomainEvent. 9
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
}+ ,
public 
string 
CustomerCode "
{# $
get% (
;( )
}* +
public		 
string		 
	OldStatus		 
{		  !
get		" %
;		% &
}		' (
public

 
string

 
	NewStatus

 
{

  !
get

" %
;

% &
}

' (
public 
string 
	ChangedBy 
{  !
get" %
;% &
}' (
public &
CustomerStatusChangedEvent )
() *
int 
customerMasterId  
,  !
string 
? 
customerCode  
,  !
string 
	oldStatus 
, 
string 
	newStatus 
, 
string 
	changedBy 
) 
{ 	
CustomerMasterId 
= 
customerMasterId /
;/ 0
CustomerCode 
= 
customerCode '
!' (
;( )
	OldStatus 
= 
	oldStatus !
;! "
	NewStatus 
= 
	newStatus !
;! "
	ChangedBy 
= 
	changedBy !
;! "
} 	
} 
} Í
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerDeletedEvent.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
.' (
Customer( 0
{ 
public 

class  
CustomerDeletedEvent %
:& '
DomainEvent( 3
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
}+ ,
public 
string 
CustomerCode "
{# $
get% (
;( )
}* +
public		 
string		 
	DeletedBy		 
{		  !
get		" %
;		% &
}		' (
public

 
string

 
Reason
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
" #
}

$ %
public  
CustomerDeletedEvent #
(# $
int$ '
customerMasterId( 8
,8 9
string: @
customerCodeA M
,M N
stringO U
	deletedByV _
,_ `
stringa g
reasonh n
)n o
{ 	
CustomerMasterId 
= 
customerMasterId /
;/ 0
CustomerCode 
= 
customerCode '
;' (
	DeletedBy 
= 
	deletedBy !
;! "
Reason 
= 
reason 
; 
} 	
} 
} Ç
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerCreatedEvent.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Events! '
.' (
Customer( 0
{ 
public 

class  
CustomerCreatedEvent %
:& '
DomainEvent( 3
{ 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
}+ ,
public 
string 
CustomerCode "
{# $
get% (
;( )
}* +
public		 
string		 
CustomerType		 "
{		# $
get		% (
;		( )
}		* +
public

 
string

 
	CreatedBy

 
{

  !
get

" %
;

% &
}

' (
public  
CustomerCreatedEvent #
(# $
int$ '
customerMasterId( 8
,8 9
string: @
customerCodeA M
,M N
stringO U
customerTypeV b
,b c
stringd j
	createdByk t
)t u
{ 	
CustomerMasterId 
= 
customerMasterId /
;/ 0
CustomerCode 
= 
customerCode '
;' (
CustomerType 
= 
customerType '
;' (
	CreatedBy 
= 
	createdBy !
;! "
} 	
} 
} ≥
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/ResidentTypeEnum.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Enums! &
{ 
public 

enum 
ResidentTypeEnum  
{ 

EXPATRIATE 
= 
$num 
, 
[

 	
Description

	 
(

 
$str

 #
)

# $
]

$ %
NON_RESIDENT 
= 
$num 
, 
RESIDENT 
= 
$num 
} 
} ≤
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/CustomerTypeEnum.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Enums! &
{ 
public 

enum 
CustomerTypeEnum  
{ 
COMPANY 
= 
$num 
, 

INDIVIDUAL

 
=

 
$num

 
,

 
[ 	
Description	 
( 
$str #
)# $
]$ %
JOINT_OWNERSHIP 
= 
$num 
, 
[ 	
Description	 
( 
$str #
)# $
]$ %
MULTI_OWNERSHIP 
= 
$num 
, 
PROSPECTIVE 
= 
$num 
} 
} Û
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ShopOfficeTypeAndDescription.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class (
ShopOfficeTypeAndDescription *
{ 
public (
ShopOfficeTypeAndDescription	 %
(% &
)& '
{ 
} 
}		 
}

 ˇ"
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
PropertyType 
: 
AuditableEntity +
{ 
[ 
Key 
] 	
public 

int 
PropertyTypeId 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
[ 
Required 
] 
[		 
	MaxLength		 
(		 
$num		 
)		 
]		 
public

 

string

 
?

 
PropertyTypes
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
5 6
public 

PropertyType 
( 
int 
propertyTypeId *
,* +
string, 2
?2 3
propertyTypes4 A
)A B
{ 
PropertyTypeId 
= 
propertyTypeId '
;' (
PropertyTypes 
= 
propertyTypes %
;% &
} 
public 

static 
PropertyType 
Create %
(% &
int& )
propertyTypeId* 8
,8 9
string: @
propertyTypesA N
)N O
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
propertyTypes& 3
)3 4
||5 7
propertyTypeId8 F
<G H
$numI J
)J K
{ 	
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
} 	
if 

( 
propertyTypeId 
<= 
- 
$num  
)  !
throw 
new 
ArgumentException '
(' (
$str( U
)U V
;V W
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
propertyTypes& 3
)3 4
||5 7
propertyTypes8 E
.E F
LengthF L
>M N
$numO Q
)Q R
throw 
new 
ArgumentException '
(' (
$str( a
)a b
;b c
return   
new   
PropertyType   
(    
propertyTypeId    .
,  . /
propertyTypes  0 =
)  = >
;  > ?
}!! 
public$$ 

static$$ 
PropertyType$$ 
Update$$ %
($$% &
int$$& )
propertyTypeId$$* 8
,$$8 9
string$$: @
propertyTypes$$A N
)$$N O
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &
propertyTypes&&& 3
)&&3 4
||&&5 7
propertyTypeId&&8 F
<&&G H
$num&&I J
)&&J K
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( E
)((E F
;((F G
})) 	
if++ 

(++ 
propertyTypeId++ 
<=++ 
-++ 
$num++  
)++  !
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( U
),,U V
;,,V W
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
propertyTypes..& 3
)..3 4
||..5 7
propertyTypes..8 E
...E F
Length..F L
>..M N
$num..O Q
)..Q R
throw// 
new// 
ArgumentException// '
(//' (
$str//( a
)//a b
;//b c
return22 
new22 
PropertyType22 
(22  
propertyTypeId22  .
,22. /
propertyTypes220 =
)22= >
;22> ?
}33 
}44 ≤#
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyHeight.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
PropertyHeight 
: 
AuditableEntity -
{ 
[ 
Key 
] 	
public 

int 
PropertyHeightId 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
[		 
Required		 
]		 
[

 
	MaxLength

 
(

 
$num

 
)

 
]

 
public 

string 
? 
PropertyHeights "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public 

PropertyHeight 
( 
int 
propertyHeightId .
,. /
string0 6
propertyHeights7 F
)F G
{ 
PropertyHeightId 
= 
propertyHeightId +
;+ ,
PropertyHeights 
= 
propertyHeights )
;) *
} 
public 

static 
PropertyHeight  
Create! '
(' (
int( +
propertyHeightId, <
,< =
string> D
propertyHeightsE T
)T U
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
propertyHeights& 5
)5 6
||7 9
propertyHeightId: J
<K L
$numM N
)N O
{ 	
throw 
new 
ArgumentException '
(' (
$str( G
)G H
;H I
} 	
if 

( 
propertyHeightId 
<= 
-  !
$num! "
)" #
throw 
new 
ArgumentException '
(' (
$str( W
)W X
;X Y
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
propertyHeights& 5
)5 6
||7 9
propertyHeights: I
.I J
LengthJ P
>Q R
$numS U
)U V
throw   
new   
ArgumentException   '
(  ' (
$str  ( a
)  a b
;  b c
return## 
new## 
PropertyHeight## !
(##! "
propertyHeightId##" 2
,##2 3
propertyHeights##4 C
)##C D
;##D E
}$$ 
public&& 

static&& 
PropertyHeight&&  
Update&&! '
(&&' (
int&&( +
propertyHeightId&&, <
,&&< =
string&&> D
propertyHeights&&E T
)&&T U
{'' 
if(( 

((( 
string(( 
.(( 
IsNullOrWhiteSpace(( %
(((% &
propertyHeights((& 5
)((5 6
||((7 9
propertyHeightId((: J
<((K L
$num((M N
)((N O
{)) 	
throw** 
new** 
ArgumentException** '
(**' (
$str**( G
)**G H
;**H I
}++ 	
if-- 

(-- 
propertyHeightId-- 
<=-- 
---  !
$num--! "
)--" #
throw.. 
new.. 
ArgumentException.. '
(..' (
$str..( W
)..W X
;..X Y
if00 

(00 
string00 
.00 
IsNullOrWhiteSpace00 %
(00% &
propertyHeights00& 5
)005 6
||007 9
propertyHeights00: I
.00I J
Length00J P
>00Q R
$num00S U
)00U V
throw11 
new11 
ArgumentException11 '
(11' (
$str11( a
)11a b
;11b c
return44 
new44 
PropertyHeight44 !
(44! "
propertyHeightId44" 2
,442 3
propertyHeights444 C
)44C D
;44D E
}55 
}77 –!
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PlotSize.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
PlotSize 
: 
AuditableEntity '
{ 
[ 
Key 
] 	
public 

int 

PlotSizeId 
{ 
get 
;  
set! $
;$ %
}& '
[ 
Required 
] 
[		 
	MaxLength		 
(		 
$num		 
)		 
]		 
public

 

string

 
?

 
	PlotSizes

 
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
) *
public 

PlotSize 
( 
int 

plotSizeId "
," #
string$ *
?* +
	plotSizes, 5
)5 6
{ 

PlotSizeId 
= 

plotSizeId 
;  
	PlotSizes 
= 
	plotSizes 
; 
} 
public 

static 
PlotSize 
Create !
(! "
int" %

plotSizeId& 0
,0 1
string2 8
	plotSizes9 B
)B C
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
	plotSizes& /
)/ 0
||1 3

plotSizeId4 >
<? @
$numA B
)B C
{ 	
throw 
new 
ArgumentException '
(' (
$str( A
)A B
;B C
} 	
if 

( 

plotSizeId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( Q
)Q R
;R S
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
	plotSizes& /
)/ 0
||1 3
	plotSizes4 =
.= >
Length> D
>E F
$numG I
)I J
throw 
new 
ArgumentException '
(' (
$str( ^
)^ _
;_ `
return   
new   
PlotSize   
(   

plotSizeId   &
,  & '
	plotSizes  ( 1
)  1 2
;  2 3
}!! 
public## 

static## 
PlotSize## 
Update## !
(##! "
int##" %

plotSizeId##& 0
,##0 1
string##2 8
	PlotSizes##9 B
)##B C
{$$ 
if%% 

(%% 
string%% 
.%% 
IsNullOrWhiteSpace%% %
(%%% &
	PlotSizes%%& /
)%%/ 0
||%%1 3

plotSizeId%%4 >
<%%? @
$num%%A B
)%%B C
{&& 	
throw'' 
new'' 
ArgumentException'' '
(''' (
$str''( A
)''A B
;''B C
}(( 	
if** 

(** 

plotSizeId** 
<=** 
-** 
$num** 
)** 
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( Q
)++Q R
;++R S
if-- 

(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- %
(--% &
	PlotSizes--& /
)--/ 0
||--1 3
	PlotSizes--4 =
.--= >
Length--> D
>--E F
$num--G I
)--I J
throw.. 
new.. 
ArgumentException.. '
(..' (
$str..( ^
)..^ _
;.._ `
return11 
new11 
PlotSize11 
(11 

plotSizeId11 &
,11& '
	PlotSizes11( 1
)111 2
;112 3
}22 
}44 öL
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Locality.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
Locality 
: 
AuditableEntity '
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 

LocalityId 
{ 
get 
;  
private! (
set) ,
;, -
}. /
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
? 
LocalityInitial "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
LocalityName 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
CustomerCode 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public 

int 
CustomerCodeCounter "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 

Locality 
( 
int 

localityId "
," #
string$ *
?* +
localityInitial, ;
,; <
string= C
?C D
localityNameE Q
,Q R
stringS Y
?Y Z
customerCode[ g
,g h
inti l 
customerCodeCounter	m Ä
)
Ä Å
{ 

LocalityId 
= 

localityId 
;  
LocalityInitial 
= 
localityInitial )
;) *
LocalityName 
= 
localityName #
;# $
CustomerCode 
= 
customerCode #
;# $
CustomerCodeCounter 
= 
customerCodeCounter 1
;1 2
} 
public!! 

static!! 
Locality!! 
Create!! !
(!!! "
int!!" %

localityId!!& 0
,!!0 1
string!!2 8
localityInitial!!9 H
,!!H I
string!!J P
localityName!!Q ]
,!!] ^
string!!_ e
customerCode!!f r
,!!r s
int!!t w 
customerCodeCounter	!!x ã
)
!!ã å
{"" 
if## 

(## 
string## 
.## 
IsNullOrWhiteSpace## %
(##% &
localityInitial##& 5
)##5 6
||##7 9
string##: @
.##@ A
IsNullOrWhiteSpace##A S
(##S T
localityName##T `
)##` a
||##b d
string##e k
.##k l
IsNullOrWhiteSpace##l ~
(##~ 
customerCode	## ã
)
##ã å
||
##ç è

localityId
##ê ö
<
##õ ú
$num
##ù û
)
##û ü
{$$ 	
throw%% 
new%% 
ArgumentException%% '
(%%' (
$str%%( @
)%%@ A
;%%A B
}&& 	
if(( 

((( 

localityId(( 
<=(( 
-(( 
$num(( 
)(( 
{)) 	
throw** 
new** 
ArgumentException** '
(**' (
$str**( P
)**P Q
;**Q R
}++ 	
if-- 

(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- %
(--% &
localityInitial--& 5
)--5 6
||--7 9
localityInitial--: I
.--I J
Length--J P
>--Q R
$num--S T
)--T U
{.. 	
throw// 
new// 
ArgumentException// '
(//' (
$str//( c
)//c d
;//d e
}00 	
if22 

(22 
string22 
.22 
IsNullOrWhiteSpace22 %
(22% &
localityName22& 2
)222 3
||224 6
localityName227 C
.22C D
Length22D J
>22K L
$num22M O
)22O P
{33 	
throw44 
new44 
ArgumentException44 '
(44' (
$str44( a
)44a b
;44b c
}55 	
if77 

(77 
string77 
.77 
IsNullOrWhiteSpace77 %
(77% &
localityInitial77& 5
)775 6
||777 9
localityInitial77: I
.77I J
Length77J P
>77Q R
$num77S T
)77T U
{88 	
throw99 
new99 
ArgumentException99 '
(99' (
$str99( c
)99c d
;99d e
}:: 	
if<< 

(<< 
string<< 
.<< 
IsNullOrWhiteSpace<< %
(<<% &
customerCode<<& 2
)<<2 3
||<<4 6
customerCode<<7 C
.<<C D
Length<<D J
><<K L
$num<<M N
)<<N O
{== 	
throw>> 
new>> 
ArgumentException>> '
(>>' (
$str>>( `
)>>` a
;>>a b
}?? 	
returnAA 
newAA 
LocalityAA 
(AA 

localityIdAA &
,AA& '
localityInitialAA( 7
,AA7 8
localityNameAA9 E
,AAE F
customerCodeAAG S
,AAS T
customerCodeCounterAAU h
)AAh i
;AAi j
}BB 
publicDD 

staticDD 
LocalityDD 
UpdateDD !
(DD! "
intDD" %

localityIdDD& 0
,DD0 1
stringDD2 8
localityInitialDD9 H
,DDH I
stringDDJ P
localityNameDDQ ]
,DD] ^
stringDD_ e
customerCodeDDf r
,DDr s
intDDs v 
customerCodeCounter	DDw ä
)
DDä ã
{EE 
ifFF 

(FF 
stringFF 
.FF 
IsNullOrWhiteSpaceFF %
(FF% &
localityInitialFF& 5
)FF5 6
||FF7 9
stringFF: @
.FF@ A
IsNullOrWhiteSpaceFFA S
(FFS T
localityNameFFT `
)FF` a
||FFb d
stringFFe k
.FFk l
IsNullOrWhiteSpaceFFl ~
(FF~ 
customerCode	FF ã
)
FFã å
||
FFç è

localityId
FFê ö
<
FFõ ú
$num
FFù û
||
FFü °!
customerCodeCounter
FF¢ µ
<
FF∂ ∑
$num
FF∏ π
)
FFπ ∫
{GG 	
throwHH 
newHH 
ArgumentExceptionHH '
(HH' (
$strHH( @
)HH@ A
;HHA B
}II 	
ifKK 

(KK 

localityIdKK 
<=KK 
-KK 
$numKK 
)KK 
{LL 	
throwMM 
newMM 
ArgumentExceptionMM '
(MM' (
$strMM( P
)MMP Q
;MMQ R
}NN 	
ifPP 

(PP 
stringPP 
.PP 
IsNullOrWhiteSpacePP %
(PP% &
localityInitialPP& 5
)PP5 6
||PP7 9
localityInitialPP: I
.PPI J
LengthPPJ P
>PPQ R
$numPPS T
)PPT U
{QQ 	
throwRR 
newRR 
ArgumentExceptionRR '
(RR' (
$strRR( c
)RRc d
;RRd e
}SS 	
ifUU 

(UU 
stringUU 
.UU 
IsNullOrWhiteSpaceUU %
(UU% &
localityNameUU& 2
)UU2 3
||UU4 6
localityNameUU7 C
.UUC D
LengthUUD J
>UUK L
$numUUM O
)UUO P
{VV 	
throwWW 
newWW 
ArgumentExceptionWW '
(WW' (
$strWW( a
)WWa b
;WWb c
}XX 	
ifZZ 

(ZZ 
stringZZ 
.ZZ 
IsNullOrWhiteSpaceZZ %
(ZZ% &
customerCodeZZ& 2
)ZZ2 3
||ZZ4 6
customerCodeZZ7 C
.ZZC D
LengthZZD J
>ZZK L
$numZZM N
)ZZN O
{[[ 	
throw\\ 
new\\ 
ArgumentException\\ '
(\\' (
$str\\( `
)\\` a
;\\a b
}]] 	
if__ 

(__ 
customerCodeCounter__ 
<=__  "
-__# $
$num__$ %
)__% &
{`` 	
throwaa 
newaa 
ArgumentExceptionaa '
(aa' (
$straa( Z
)aaZ [
;aa[ \
}bb 	
returndd 
newdd 
Localitydd 
(dd 

localityIddd &
,dd& '
localityInitialdd( 7
,dd7 8
localityNamedd9 E
,ddE F
customerCodeddG S
,ddS T
customerCodeCounterddU h
)ddh i
;ddi j
}ee 
}gg ’
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LeaseTypeAndPeriod.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class 
LeaseTypeAndPeriod  
{ 
public 
LeaseTypeAndPeriod	 
( 
) 
{ 
} 
}		 
}

 ¬=
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LandUseType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
LandUseType 
: 
AuditableEntity *
{ 
[ 
Required 
] 
public 

int 
	LandUseId 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
[ 
Key 
] 	
[		 
Required		 
]		 
public

 

int

 
LandUseTypeId

 
{

 
get

 "
;

" #
private

$ +
set

, /
;

/ 0
}

1 2
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
LandUseTypeInitial %
{& '
get( +
;+ ,
private- 4
set5 8
;8 9
}: ;
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
LandUseTypeName "
{# $
get% (
;( )
private* 1
set2 5
;5 6
}7 8
public 

LandUseType 
( 
int 
	landUseId $
,$ %
int& )
landUseTypeId* 7
,7 8
string9 ?
?? @
landUseTypeInitialA S
,S T
stringU [
?[ \
landUseTypeName] l
)l m
{ 
	LandUseId 
= 
	landUseId 
; 
LandUseTypeId 
= 
landUseTypeId %
;% &
LandUseTypeInitial 
= 
landUseTypeInitial /
;/ 0
LandUseTypeName 
= 
landUseTypeName )
;) *
} 
public 

static 
LandUseType 
Create $
($ %
int% (
	landUseId) 2
,2 3
int4 7
landUseTypeId8 E
,E F
stringG M
landUseTypeInitialN `
,` a
stringb h
landUseTypeNamei x
)x y
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
landUseTypeInitial& 8
)8 9
||: <
string= C
.C D
IsNullOrWhiteSpaceD V
(V W
landUseTypeNameW f
)f g
||h j
	landUseIdk t
<u v
$numw x
||y {
landUseTypeId	| â
<
ä ã
$num
å ç
)
ç é
{   	
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( E
)!!E F
;!!F G
}"" 	
if$$ 

($$ 
	landUseId$$ 
<=$$ 
-$$ 
$num$$ 
)$$ 
{%% 	
throw&& 
new&& 
ArgumentException&& '
(&&' (
$str&&( P
)&&P Q
;&&Q R
}'' 	
if)) 

()) 
landUseTypeId)) 
<=)) 
-)) 
$num)) 
)))  
{** 	
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( U
)++U V
;++V W
},, 	
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
landUseTypeInitial..& 8
)..8 9
||..: <
landUseTypeInitial..= O
...O P
Length..P V
>..W X
$num..Y Z
)..Z [
{// 	
throw00 
new00 
ArgumentException00 '
(00' (
$str00( h
)00h i
;00i j
}11 	
if33 

(33 
string33 
.33 
IsNullOrWhiteSpace33 %
(33% &
landUseTypeName33& 5
)335 6
||337 9
landUseTypeName33: I
.33I J
Length33J P
>33Q R
$num33S U
)33U V
{44 	
throw55 
new55 
ArgumentException55 '
(55' (
$str55( a
)55a b
;55b c
}66 	
return88 
new88 
LandUseType88 
(88 
	landUseId88 (
,88( )
landUseTypeId88* 7
,887 8
landUseTypeInitial889 K
,88K L
landUseTypeName88M \
)88\ ]
;88] ^
}99 
public<< 

static<< 
LandUseType<< 
Update<< $
(<<$ %
int<<% (
	landUseId<<) 2
,<<2 3
int<<4 7
landUseTypeId<<8 E
,<<E F
string<<G M
landUseTypeInitial<<N `
,<<` a
string<<b h
landUseTypeName<<i x
)<<x y
{== 
if>> 

(>> 
string>> 
.>> 
IsNullOrWhiteSpace>> %
(>>% &
landUseTypeInitial>>& 8
)>>8 9
||>>: <
string>>= C
.>>C D
IsNullOrWhiteSpace>>D V
(>>V W
landUseTypeName>>W f
)>>f g
||>>h j
	landUseId>>k t
<>>u v
$num>>w x
||>>y {
landUseTypeId	>>| â
<
>>ä ã
$num
>>å ç
)
>>ç é
{?? 	
throw@@ 
new@@ 
ArgumentException@@ '
(@@' (
$str@@( E
)@@E F
;@@F G
}AA 	
ifCC 

(CC 
	landUseIdCC 
<=CC 
-CC 
$numCC 
)CC 
{DD 	
throwEE 
newEE 
ArgumentExceptionEE '
(EE' (
$strEE( P
)EEP Q
;EEQ R
}FF 	
ifHH 

(HH 
landUseTypeIdHH 
<=HH 
-HH 
$numHH 
)HH  
{II 	
throwJJ 
newJJ 
ArgumentExceptionJJ '
(JJ' (
$strJJ( U
)JJU V
;JJV W
}KK 	
ifMM 

(MM 
stringMM 
.MM 
IsNullOrWhiteSpaceMM %
(MM% &
landUseTypeInitialMM& 8
)MM8 9
||MM: <
landUseTypeInitialMM= O
.MMO P
LengthMMP V
>MMW X
$numMMY Z
)MMZ [
{NN 	
throwOO 
newOO 
ArgumentExceptionOO '
(OO' (
$strOO( h
)OOh i
;OOi j
}PP 	
ifRR 

(RR 
stringRR 
.RR 
IsNullOrWhiteSpaceRR %
(RR% &
landUseTypeNameRR& 5
)RR5 6
||RR7 9
landUseTypeNameRR: I
.RRI J
LengthRRJ P
>RRQ R
$numRRS U
)RRU V
{SS 	
throwTT 
newTT 
ArgumentExceptionTT '
(TT' (
$strTT( a
)TTa b
;TTb c
}UU 	
returnWW 
newWW 
LandUseTypeWW 
(WW 
	landUseIdWW (
,WW( )
landUseTypeIdWW* 7
,WW7 8
landUseTypeInitialWW9 K
,WWK L
landUseTypeNameWWM \
)WW\ ]
;WW] ^
}XX 
}ZZ π3
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LandUse.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
LandUse 
: 
AuditableEntity &
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
	LandUseId 
{ 
get 
; 
private  '
set( +
;+ ,
}- .
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public   

string   
?   
LandUseInitial   !
{  " #
get  $ '
;  ' (
private  ) 0
set  1 4
;  4 5
}  6 7
["" 
Required"" 
]"" 
[## 
StringLength## 
(## 
$num## 
)## 
]## 
public$$ 

string$$ 
?$$ 
LandUseName$$ 
{$$  
get$$! $
;$$$ %
private$$& -
set$$. 1
;$$1 2
}$$3 4
public-- 

LandUse-- 
(-- 
int-- 
	landUseId--  
,--  !
string--" (
landUseInitial--) 7
,--7 8
string--9 ?
landUseName--@ K
)--K L
{.. 
	LandUseId// 
=// 
	landUseId// 
;// 
LandUseInitial00 
=00 
landUseInitial00 '
??00( *
throw00+ 0
new001 4!
ArgumentNullException005 J
(00J K
nameof00K Q
(00Q R
landUseInitial00R `
)00` a
)00a b
;00b c
LandUseName11 
=11 
landUseName11 !
??11" $
throw11% *
new11+ .!
ArgumentNullException11/ D
(11D E
nameof11E K
(11K L
landUseName11L W
)11W X
)11X Y
;11Y Z
}22 
public55 

static55 
LandUse55 
Create55  
(55  !
int55! $
	landUseId55% .
,55. /
string550 6
landUseInitial557 E
,55E F
string55G M
landUseName55N Y
)55Y Z
{66 
if77 

(77 
string77 
.77 
IsNullOrWhiteSpace77 %
(77% &
landUseInitial77& 4
)774 5
||776 8
string779 ?
.77? @
IsNullOrWhiteSpace77@ R
(77R S
landUseName77S ^
)77^ _
||77` b
	landUseId77c l
<77m n
$num77o p
)77p q
{88 	
throw99 
new99 
ArgumentException99 '
(99' (
$str99( @
)99@ A
;99A B
}:: 	
if<< 

(<< 
	landUseId<< 
<=<< 
-<< 
$num<< 
)<< 
throw== 
new== 
ArgumentException== '
(==' (
$str==( P
)==P Q
;==Q R
if?? 

(?? 
string?? 
.?? 
IsNullOrWhiteSpace?? %
(??% &
landUseInitial??& 4
)??4 5
||??6 8
landUseInitial??9 G
.??G H
Length??H N
>??O P
$num??Q R
)??R S
throw@@ 
new@@ 
ArgumentException@@ '
(@@' (
$str@@( c
)@@c d
;@@d e
ifBB 

(BB 
stringBB 
.BB 
IsNullOrWhiteSpaceBB %
(BB% &
landUseNameBB& 1
)BB1 2
||BB3 5
landUseNameBB6 A
.BBA B
LengthBBB H
>BBI J
$numBBK M
)BBM N
throwCC 
newCC 
ArgumentExceptionCC '
(CC' (
$strCC( a
)CCa b
;CCb c
returnEE 
newEE 
LandUseEE 
(EE 
	landUseIdEE $
,EE$ %
landUseInitialEE% 3
,EE3 4
landUseNameEE5 @
)EE@ A
;EEA B
}FF 
publicHH 

LandUseHH 
UpdateHH 
(HH 
intHH 
	landUseIdHH '
,HH' (
stringHH) /
landUseInitialHH0 >
,HH> ?
stringHH@ F
landUseNameHHG R
)HHR S
{II 
ifJJ 

(JJ 
stringJJ 
.JJ 
IsNullOrWhiteSpaceJJ %
(JJ% &
landUseInitialJJ& 4
)JJ4 5
||JJ6 8
stringJJ9 ?
.JJ? @
IsNullOrWhiteSpaceJJ@ R
(JJR S
landUseNameJJS ^
)JJ^ _
||JJ` b
	landUseIdJJc l
<JJm n
$numJJo p
)JJp q
{KK 	
throwLL 
newLL 
ArgumentExceptionLL '
(LL' (
$strLL( @
)LL@ A
;LLA B
}MM 	
ifOO 

(OO 
	landUseIdOO 
<=OO 
-OO 
$numOO 
)OO 
throwPP 
newPP 
ArgumentExceptionPP '
(PP' (
$strPP( P
)PPP Q
;PPQ R
ifRR 

(RR 
stringRR 
.RR 
IsNullOrWhiteSpaceRR %
(RR% &
landUseInitialRR& 4
)RR4 5
||RR6 8
landUseInitialRR9 G
.RRG H
LengthRRH N
>RRO P
$numRRQ R
)RRR S
throwSS 
newSS 
ArgumentExceptionSS '
(SS' (
$strSS( c
)SSc d
;SSd e
ifUU 

(UU 
stringUU 
.UU 
IsNullOrWhiteSpaceUU %
(UU% &
landUseNameUU& 1
)UU1 2
||UU3 5
landUseNameUU6 A
.UUA B
LengthUUB H
>UUI J
$numUUK M
)UUM N
throwVV 
newVV 
ArgumentExceptionVV '
(VV' (
$strVV( a
)VVa b
;VVb c
returnXX 
newXX 
LandUseXX 
(XX 
	landUseIdXX $
,XX$ %
landUseInitialXX& 4
,XX4 5
landUseNameXX6 A
)XXA B
;XXB C
}YY 
}[[ ‰
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/HouseTypeAndDescription.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class #
HouseTypeAndDescription %
{ 
public #
HouseTypeAndDescription	  
(  !
)! "
{ 
} 
}		 
}

 „"
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/FloorNumbering.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
FloorNumbering 
: 
AuditableEntity -
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
FloorNumberId 
{ 
get "
;" #
set$ '
;' (
}) *
[		 
StringLength		 
(		 
$num		 
)		 
]		 
[

 
Required

 
]

 
public 

string 
? 
FloorNumber 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

FloorNumbering 
( 
int 
floorNumberId +
,+ ,
string- 3
floorNumber4 ?
)? @
{ 
FloorNumberId 
= 
floorNumberId %
;% &
FloorNumber 
= 
floorNumber !
;! "
} 
public 

static 
FloorNumbering  
Create! '
(' (
int( +
floorNumberId, 9
,9 :
string; A
floorNumberB M
)M N
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
floorNumber& 1
)1 2
||3 5
floorNumberId6 C
<D E
$numF G
)G H
{ 	
throw 
new 
ArgumentException '
(' (
$str( D
)D E
;E F
} 	
if 

( 
floorNumberId 
<= 
- 
$num 
)  
throw 
new 
ArgumentException '
(' (
$str( T
)T U
;U V
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
floorNumber& 1
)1 2
||3 5
floorNumber6 A
.A B
LengthB H
>I J
$numK M
)M N
throw 
new 
ArgumentException '
(' (
$str( `
)` a
;a b
return!! 
new!! 
FloorNumbering!! !
(!!! "
floorNumberId!!" /
,!!/ 0
floorNumber!!1 <
)!!< =
;!!= >
}"" 
public$$ 

static$$ 
FloorNumbering$$  
Update$$! '
($$' (
int$$( +
floorNumberId$$, 9
,$$9 :
string$$; A
floorNumber$$B M
)$$M N
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &
floorNumber&&& 1
)&&1 2
||&&3 5
floorNumberId&&6 C
<&&D E
$num&&F G
)&&G H
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( D
)((D E
;((E F
})) 	
if++ 

(++ 
floorNumberId++ 
<=++ 
-++ 
$num++ 
)++  
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( T
),,T U
;,,U V
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
floorNumber..& 1
)..1 2
||..3 5
floorNumber..6 A
...A B
Length..B H
>..I J
$num..K M
)..M N
throw// 
new// 
ArgumentException// '
(//' (
$str//( `
)//` a
;//a b
return22 
new22 
FloorNumbering22 !
(22! "
floorNumberId22" /
,22/ 0
floorNumber221 <
)22< =
;22= >
}33 
}44 µ!
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Facilities.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 

Facilities 
: 
AuditableEntity )
{ 
[ 
Key 
] 	
public 

int 

FacilityId 
{ 
get 
;  
set! $
;$ %
}& '
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
Facility 
{ 
get  
;  !
set" %
;% &
}' (
public 


Facilities 
( 
int 

facilityId $
,$ %
string& ,
facility- 5
)5 6
{ 

FacilityId 
= 

facilityId 
;  
Facility 
= 
facility 
; 
} 
public 

static 

Facilities 
Create #
(# $
int$ '

facilityId( 2
,2 3
string4 :
facility; C
)C D
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
facility& .
). /
||0 2

facilityId3 =
<> ?
$num@ A
)A B
{ 	
throw 
new 
ArgumentException '
(' (
$str( @
)@ A
;A B
} 	
if 

( 

facilityId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( P
)P Q
;Q R
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
facility& .
). /
||0 2
facility3 ;
.; <
Length< B
>C D
$numE G
)G H
throw 
new 
ArgumentException '
(' (
$str( \
)\ ]
;] ^
return!! 
new!! 

Facilities!! 
(!! 

facilityId!! (
,!!( )
facility!!* 2
)!!2 3
;!!3 4
}"" 
public%% 

static%% 

Facilities%% 
Update%% #
(%%# $
int%%$ '

facilityId%%( 2
,%%2 3
string%%4 :
facility%%; C
)%%C D
{&& 
if'' 

('' 
string'' 
.'' 
IsNullOrWhiteSpace'' %
(''% &
facility''& .
)''. /
||''0 2

facilityId''3 =
<''> ?
$num''@ A
)''A B
{(( 	
throw)) 
new)) 
ArgumentException)) '
())' (
$str))( @
)))@ A
;))A B
}** 	
if,, 

(,, 

facilityId,, 
<=,, 
-,, 
$num,, 
),, 
throw-- 
new-- 
ArgumentException-- '
(--' (
$str--( P
)--P Q
;--Q R
if// 

(// 
string// 
.// 
IsNullOrWhiteSpace// %
(//% &
facility//& .
)//. /
||//0 2
facility//3 ;
.//; <
Length//< B
>//C D
$num//E G
)//G H
throw00 
new00 
ArgumentException00 '
(00' (
$str00( \
)00\ ]
;00] ^
return33 
new33 

Facilities33 
(33 

facilityId33 (
,33( )
facility33* 2
)332 3
;333 4
}44 
}55 â!
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockUnit.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
	BlockUnit 
: 
AuditableEntity (
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
UnitId 
{ 
get 
; 
set  
;  !
}" #
[

 
Required

 
]

 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
Unit 
{ 
get 
; 
set "
;" #
}$ %
public 

	BlockUnit 
( 
int 
unitId 
,  
string! '
unit( ,
), -
{ 
UnitId 
= 
unitId 
; 
Unit 
= 
unit 
; 
} 
public 

static 
	BlockUnit 
Create "
(" #
int# &
unitId' -
,- .
string/ 5
unit6 :
): ;
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
unit& *
)* +
||, .
unitId/ 5
<6 7
$num8 9
)9 :
{ 	
throw 
new 
ArgumentException '
(' (
$str( B
)B C
;C D
} 	
if 

( 
unitId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( R
)R S
;S T
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
unit& *
)* +
||, .
unit/ 3
.3 4
Length4 :
>; <
$num= >
)> ?
throw 
new 
ArgumentException '
(' (
$str( ]
)] ^
;^ _
return"" 
new"" 
	BlockUnit"" 
("" 
unitId"" #
,""# $
unit""% )
)"") *
;""* +
}## 
public%% 

static%% 
	BlockUnit%% 
Update%% "
(%%" #
int%%# &
unitId%%' -
,%%- .
string%%/ 5
unit%%6 :
)%%: ;
{&& 
if'' 

('' 
string'' 
.'' 
IsNullOrWhiteSpace'' %
(''% &
unit''& *
)''* +
||'', .
unitId''/ 5
<''6 7
$num''8 9
)''9 :
{(( 	
throw)) 
new)) 
ArgumentException)) '
())' (
$str))( B
)))B C
;))C D
}** 	
if,, 

(,, 
unitId,, 
<=,, 
-,, 
$num,, 
),, 
throw-- 
new-- 
ArgumentException-- '
(--' (
$str--( R
)--R S
;--S T
if// 

(// 
string// 
.// 
IsNullOrWhiteSpace// %
(//% &
unit//& *
)//* +
||//, .
unit/// 3
.//3 4
Length//4 :
>//; <
$num//= >
)//> ?
throw00 
new00 
ArgumentException00 '
(00' (
$str00( ]
)00] ^
;00^ _
return33 
new33 
	BlockUnit33 
(33 
unitId33 #
,33# $
unit33% )
)33) *
;33* +
}44 
}66 É"
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockTypes.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 

BlockTypes 
: 
AuditableEntity )
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
BlockTypeId 
{ 
get  
;  !
set" %
;% &
}' (
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
	BlockType 
{ 
get !
;! "
set# &
;& '
}( )
public 


BlockTypes 
( 
int 
blockTypeId %
,% &
string' -
	blockType. 7
)7 8
{ 
BlockTypeId 
= 
blockTypeId !
;! "
	BlockType 
= 
	blockType 
; 
} 
public 

static 

BlockTypes 
Create #
(# $
int$ '
blockTypeId( 3
,3 4
string5 ;
	blockType< E
)E F
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
	blockType& /
)/ 0
||1 3
blockTypeId4 ?
<@ A
$numB C
)C D
{ 	
throw 
new 
ArgumentException '
(' (
$str( B
)B C
;C D
} 	
if 

( 
blockTypeId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( R
)R S
;S T
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
	blockType& /
)/ 0
||1 3
	blockType4 =
.= >
Length> D
>E F
$numG I
)I J
throw 
new 
ArgumentException '
(' (
$str( _
)_ `
;` a
return!! 
new!! 

BlockTypes!! 
(!! 
blockTypeId!! )
,!!) *
	blockType!!+ 4
)!!4 5
;!!5 6
}"" 
public$$ 

static$$ 

BlockTypes$$ 
Update$$ #
($$# $
int$$$ '
blockTypeId$$( 3
,$$3 4
string$$5 ;
	blockType$$< E
)$$E F
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &
	blockType&&& /
)&&/ 0
||&&1 3
blockTypeId&&4 ?
<&&@ A
$num&&B C
)&&C D
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( B
)((B C
;((C D
})) 	
if++ 

(++ 
blockTypeId++ 
<=++ 
-++ 
$num++ 
)++ 
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( R
),,R S
;,,S T
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
	blockType..& /
)../ 0
||..1 3
	blockType..4 =
...= >
Length..> D
>..E F
$num..G I
)..I J
throw// 
new// 
ArgumentException// '
(//' (
$str//( _
)//_ `
;//` a
return22 
new22 

BlockTypes22 
(22 
blockTypeId22 )
,22) *
	blockType22+ 4
)224 5
;225 6
}33 
}66 Ò!
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockStatus.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
BlockStatus 
{ 
[ 
Key 
] 	
public 

int 
BlockStatusId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 
StringLength 
( 
$num 
) 
] 
public		 

string		 
?		 
BlockStatusType		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
public 

BlockStatus 
( 
int 
blockStatusId (
,( )
string* 0
blockStatusType1 @
)@ A
{ 
BlockStatusId 
= 
blockStatusId %
;% &
BlockStatusType 
= 
blockStatusType )
;) *
} 
public 

static 
BlockStatus 
Create $
($ %
int% (
blockStatusId) 6
,6 7
string8 >
blockStatusType? N
)N O
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
blockStatusType& 5
)5 6
||7 9
blockStatusId: G
<H I
$numJ K
)K L
{ 	
throw 
new 
ArgumentException '
(' (
$str( D
)D E
;E F
} 	
if 

( 
blockStatusId 
<= 
- 
$num 
)  
throw 
new 
ArgumentException '
(' (
$str( T
)T U
;U V
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
blockStatusType& 5
)5 6
||7 9
blockStatusType: I
.I J
LengthJ P
>Q R
$numS U
)U V
throw 
new 
ArgumentException '
(' (
$str( `
)` a
;a b
return   
new   
BlockStatus   
(   
blockStatusId   ,
,  , -
blockStatusType  . =
)  = >
;  > ?
}!! 
public## 

static## 
BlockStatus## 
Update## $
(##$ %
int##% (
blockStatusId##) 6
,##6 7
string##8 >
blockStatusType##? N
)##N O
{$$ 
if%% 

(%% 
string%% 
.%% 
IsNullOrWhiteSpace%% %
(%%% &
blockStatusType%%& 5
)%%5 6
||%%7 9
blockStatusId%%: G
<%%H I
$num%%J K
)%%K L
{&& 	
throw'' 
new'' 
ArgumentException'' '
(''' (
$str''( D
)''D E
;''E F
}(( 	
if** 

(** 
blockStatusId** 
<=** 
-** 
$num** 
)**  
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( T
)++T U
;++U V
if-- 

(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- %
(--% &
blockStatusType--& 5
)--5 6
||--7 9
blockStatusType--: I
.--I J
Length--J P
>--Q R
$num--S U
)--U V
throw.. 
new.. 
ArgumentException.. '
(..' (
$str..( `
)..` a
;..a b
return11 
new11 
BlockStatus11 
(11 
blockStatusId11 ,
,11, -
blockStatusType11. =
)11= >
;11> ?
}22 
}44 ê!
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockSides.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 

BlockSides 
: 
AuditableEntity )
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
SideId 
{ 
get 
; 
set  
;  !
}" #
[

 
Required

 
]

 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
? 
Side 
{ 
get 
; 
set "
;" #
}$ %
public 


BlockSides 
( 
int 
sideId  
,  !
string" (
side) -
)- .
{ 
SideId 
= 
sideId 
; 
Side 
= 
side 
; 
} 
public 

static 

BlockSides 
Create #
(# $
int$ '
sideId( .
,. /
string0 6
side7 ;
); <
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
side& *
)* +
||, .
sideId/ 5
<6 7
$num8 9
)9 :
{ 	
throw 
new 
ArgumentException '
(' (
$str( B
)B C
;C D
} 	
if 

( 
sideId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( R
)R S
;S T
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
side& *
)* +
||, .
side/ 3
.3 4
Length4 :
>; <
$num= ?
)? @
throw 
new 
ArgumentException '
(' (
$str( ^
)^ _
;_ `
return"" 
new"" 

BlockSides"" 
("" 
sideId"" $
,""$ %
side""& *
)""* +
;""+ ,
}## 
public%% 

static%% 

BlockSides%% 
Update%% #
(%%# $
int%%$ '
sideId%%( .
,%%. /
string%%0 6
side%%7 ;
)%%; <
{&& 
if'' 

('' 
string'' 
.'' 
IsNullOrWhiteSpace'' %
(''% &
side''& *
)''* +
||'', .
sideId''/ 5
<''6 7
$num''8 9
)''9 :
{(( 	
throw)) 
new)) 
ArgumentException)) '
())' (
$str))( B
)))B C
;))C D
}** 	
if,, 

(,, 
sideId,, 
<=,, 
-,, 
$num,, 
),, 
throw-- 
new-- 
ArgumentException-- '
(--' (
$str--( R
)--R S
;--S T
if// 

(// 
string// 
.// 
IsNullOrWhiteSpace// %
(//% &
side//& *
)//* +
||//, .
side/// 3
.//3 4
Length//4 :
>//; <
$num//= ?
)//? @
throw00 
new00 
ArgumentException00 '
(00' (
$str00( ^
)00^ _
;00_ `
return33 
new33 

BlockSides33 
(33 
sideId33 $
,33$ %
side33& *
)33* +
;33+ ,
}44 
}66 ˛
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockPurchaseType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
BlockPurchaseType 
:  
AuditableEntity! 0
{ 
} Ã"
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockNumber.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
BlockNumber 
: 
AuditableEntity )
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
BlockNumberId 
{ 
get "
;" #
set$ '
;' (
}) *
[

 
Required

 
]

 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
BlockNumbers 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

BlockNumber 
( 
int 
blockNumberId (
,( )
string* 0
blockNumbers1 =
)= >
{ 
BlockNumberId 
= 
blockNumberId %
;% &
BlockNumbers 
= 
blockNumbers #
;# $
} 
public 

static 
BlockNumber 
Create $
($ %
int% (
blockNumberId) 6
,6 7
string8 >
blockNumbers? K
)K L
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
blockNumbers& 2
)2 3
||4 6
blockNumberId7 D
<E F
$numG H
)H I
{ 	
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
} 	
if 

( 
blockNumberId 
<= 
- 
$num 
)  
throw 
new 
ArgumentException '
(' (
$str( T
)T U
;U V
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
blockNumbers& 2
)2 3
||4 6
blockNumbers7 C
.C D
LengthD J
>K L
$numM N
)N O
throw 
new 
ArgumentException '
(' (
$str( `
)` a
;a b
return"" 
new"" 
BlockNumber"" 
("" 
blockNumberId"" ,
,"", -
blockNumbers"". :
)"": ;
;""; <
}## 
public&& 

static&& 
BlockNumber&& 
Update&& $
(&&$ %
int&&% (
blockNumberId&&) 6
,&&6 7
string&&8 >
blockNumbers&&? K
)&&K L
{'' 
if(( 

((( 
string(( 
.(( 
IsNullOrWhiteSpace(( %
(((% &
blockNumbers((& 2
)((2 3
||((4 6
blockNumberId((7 D
<((E F
$num((G H
)((H I
{)) 	
throw** 
new** 
ArgumentException** '
(**' (
$str**( E
)**E F
;**F G
}++ 	
if-- 

(-- 
blockNumberId-- 
<=-- 
--- 
$num-- 
)--  
throw.. 
new.. 
ArgumentException.. '
(..' (
$str..( T
)..T U
;..U V
if00 

(00 
string00 
.00 
IsNullOrWhiteSpace00 %
(00% &
blockNumbers00& 2
)002 3
||004 6
blockNumbers007 C
.00C D
Length00D J
>00K L
$num00M N
)00N O
throw11 
new11 
ArgumentException11 '
(11' (
$str11( `
)11` a
;11a b
return44 
new44 
BlockNumber44 
(44 
blockNumberId44 ,
,44, -
blockNumbers44. :
)44: ;
;44; <
}55 
}88 Á@
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentTypes.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class 
ApartmentTypes 
: 
AuditableEntity .
{ 
[ 	
Key	 
] 
public 
int 
ApartmentTypeId "
{# $
get% (
;( )
set* -
;- .
}/ 0
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
ApartmentType $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
] 
public 
float 
SellingPrice !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
int 

CurrencyId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
public 
double 
	FloorArea 
{  !
get" %
;% &
set' *
;* +
}, -
public 
ApartmentTypes 
( 
int !
apartmentTypeId" 1
,1 2
string3 9
apartmentType: G
,G H
floatI N
sellingPriceO [
,[ \
int] `

currencyIda k
,k l
doublem s
	floorAreat }
)} ~
{ 	
ApartmentTypeId 
= 
apartmentTypeId -
;- .
ApartmentType 
= 
apartmentType )
;) *
SellingPrice 
= 
sellingPrice '
;' (

CurrencyId 
= 

currencyId #
;# $
	FloorArea 
= 
	floorArea !
;! "
} 	
public!! 
static!! 
ApartmentTypes!! $
Create!!% +
(!!+ ,
int!!, /
apartmentTypeId!!0 ?
,!!? @
string!!A G
apartmentType!!H U
,!!U V
float!!W \
sellingPrice!!] i
,!!i j
int!!k n

currencyId!!o y
,!!y z
double	!!{ Å
	floorArea
!!Ç ã
)
!!ã å
{"" 	
if## 
(## 
string## 
.## 
IsNullOrWhiteSpace## )
(##) *
apartmentType##* 7
)##7 8
||##9 ;
apartmentTypeId##< K
<=##L N
-##O P
$num##P Q
||##R T
sellingPrice##U a
<=##b d
$num##e f
||##g i

currencyId##j t
<##u v
$num##w x
||##y {
	floorArea	##| Ö
<=
##Ü à
$num
##â ä
)
##ä ã
{$$ 
throw%% 
new%% 
ArgumentException%% +
(%%+ ,
$str%%, J
)%%J K
;%%K L
}&& 
if(( 
((( 
apartmentTypeId(( 
<=((  "
-((# $
$num(($ %
)((% &
{)) 
throw** 
new** 
ArgumentException** +
(**+ ,
$str**, Z
)**Z [
;**[ \
}++ 
if-- 
(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- )
(--) *
apartmentType--* 7
)--7 8
||--9 ;
apartmentType--< I
.--I J
Length--J P
>--Q R
$num--S U
)--U V
{.. 
throw// 
new// 
ArgumentException// +
(//+ ,
$str//, f
)//f g
;//g h
}00 
if22 
(22 
sellingPrice22 
<=22 
$num22  !
)22! "
{33 
throw44 
new44 
ArgumentException44 +
(44+ ,
$str44, V
)44V W
;44W X
}55 
if77 
(77 

currencyId77 
<=77 
$num77 
)77  
{88 
throw99 
new99 
ArgumentException99 +
(99+ ,
$str99, T
)99T U
;99U V
}:: 
if<< 
(<< 
	floorArea<< 
<=<< 
$num<<  
)<<  !
{== 
throw>> 
new>> 
ArgumentException>> +
(>>+ ,
$str>>, S
)>>S T
;>>T U
}?? 
returnAA 
newAA 
ApartmentTypesAA %
(AA% &
apartmentTypeIdAA& 5
,AA5 6
apartmentTypeAA7 D
,AAD E
sellingPriceAAF R
,AAR S

currencyIdAAT ^
,AA^ _
	floorAreaAA` i
)AAi j
;AAj k
}BB 	
publicDD 
staticDD 
ApartmentTypesDD $
UpdateDD% +
(DD+ ,
intDD, /
apartmentTypeIdDD0 ?
,DD? @
stringDDA G
apartmentTypeDDH U
,DDU V
floatDDW \
sellingPriceDD] i
,DDi j
intDDk n

currencyIdDDo y
,DDy z
double	DD{ Å
	floorArea
DDÇ ã
)
DDã å
{EE 	
ifFF 
(FF 
stringFF 
.FF 
IsNullOrWhiteSpaceFF )
(FF) *
apartmentTypeFF* 7
)FF7 8
||FF9 ;
apartmentTypeIdFF< K
<=FFL N
-FFO P
$numFFP Q
||FFR T
sellingPriceFFU a
<=FFb d
$numFFe f
||FFg i

currencyIdFFj t
<FFu v
$numFFw x
||FFy {
	floorArea	FF| Ö
<=
FFÜ à
$num
FFâ ä
)
FFä ã
{GG 
throwHH 
newHH 
ArgumentExceptionHH +
(HH+ ,
$strHH, J
)HHJ K
;HHK L
}II 
ifKK 
(KK 
apartmentTypeIdKK 
<=KK  "
-KK# $
$numKK$ %
)KK% &
{LL 
throwMM 
newMM 
ArgumentExceptionMM +
(MM+ ,
$strMM, Z
)MMZ [
;MM[ \
}NN 
ifPP 
(PP 
stringPP 
.PP 
IsNullOrWhiteSpacePP )
(PP) *
apartmentTypePP* 7
)PP7 8
||PP9 ;
apartmentTypePP< I
.PPI J
LengthPPJ P
>PPQ R
$numPPS U
)PPU V
{QQ 
throwRR 
newRR 
ArgumentExceptionRR +
(RR+ ,
$strRR, f
)RRf g
;RRg h
}SS 
ifUU 
(UU 
sellingPriceUU 
<=UU 
$numUU  !
)UU! "
{VV 
throwWW 
newWW 
ArgumentExceptionWW +
(WW+ ,
$strWW, V
)WWV W
;WWW X
}XX 
ifZZ 
(ZZ 

currencyIdZZ 
<=ZZ 
$numZZ 
)ZZ  
{[[ 
throw\\ 
new\\ 
ArgumentException\\ +
(\\+ ,
$str\\, T
)\\T U
;\\U V
}]] 
if__ 
(__ 
	floorArea__ 
<=__ 
$num__ 
)__ 
{`` 
throwaa 
newaa 
ArgumentExceptionaa +
(aa+ ,
$straa, S
)aaS T
;aaT U
}bb 
returndd 
newdd 
ApartmentTypesdd %
(dd% &
apartmentTypeIddd& 5
,dd5 6
apartmentTypedd7 D
,ddD E
sellingPriceddF R
,ddR S

currencyIdddT ^
,dd^ _
	floorAreadd` i
)ddi j
;ddj k
}ee 	
}gg 
}kk Ü

á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentFacilities.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class 
ApartmentFacilities !
{ 
[ 	
Key	 
] 
public		 
int		 !
ApartmentFacilitiesId		 (
{		) *
get		+ .
;		. /
set		0 3
;		3 4
}		5 6
public 
int 
ApartmentTypeId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 

FacilityId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
decimal 
	FloorArea  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
ApartmentFacilities "
(" #
)# $
{ 
} 
} 
} ˛3
Ç/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/AllocationType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
;8 9
public 
class 
AllocationType 
: 
AuditableEntity -
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
AllocationTypeId 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
[		 
StringLength		 
(		 
$num		 
)		 
]		 
[

 
Required

 
]

 
public 

string 
? !
AllocationTypeInitial (
{) *
get+ .
;. /
private0 7
set9 <
;< =
}> ?
[ 
StringLength 
( 
$num 
) 
] 
[ 
Required 
] 
public 

string 
? 
AllocationTypes "
{# $
get% (
;( )
private* 1
set3 6
;6 7
}8 9
public 

AllocationType 
( 
) 
{ 
} 
public 

AllocationType 
( 
int 
allocationTypeId .
,. /
string0 6
?6 7!
allocationTypeInitial8 M
,M N
stringO U
?U V
allocationTypesW f
)f g
{ 
AllocationTypeId 
= 
allocationTypeId +
;+ ,!
AllocationTypeInitial 
= !
allocationTypeInitial  5
;5 6
AllocationTypes 
= 
allocationTypes )
;) *
} 
public 

static 
AllocationType  
Create! '
(' (
int( +
allocationTypeId, <
,< =
string> D!
allocationTypeInitialE Z
,Z [
string\ b
allocationTypesc r
)r s
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &!
allocationTypeInitial& ;
); <
||= ?
string@ F
.F G
IsNullOrWhiteSpaceG Y
(Y Z
allocationTypesZ i
)i j
||k m
allocationTypeIdn ~
<	 Ä
$num
Å Ç
)
Ç É
{   	
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( G
)!!G H
;!!H I
}"" 	
if$$ 

($$ 
allocationTypeId$$ 
<=$$ 
-$$  !
$num$$! "
)$$" #
throw%% 
new%% 
ArgumentException%% '
(%%' (
$str%%( W
)%%W X
;%%X Y
if'' 

('' 
string'' 
.'' 
IsNullOrWhiteSpace'' %
(''% &!
allocationTypeInitial''& ;
)''; <
||''= ?!
allocationTypeInitial''@ U
.''U V
Length''V \
>''] ^
$num''_ `
)''` a
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( j
)((j k
;((k l
if** 

(** 
string** 
.** 
IsNullOrWhiteSpace** %
(**% &
allocationTypes**& 5
)**5 6
||**7 9
allocationTypes**: I
.**I J
Length**J P
>**Q R
$num**S U
)**U V
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( c
)++c d
;++d e
return-- 
new-- 
AllocationType-- !
(--! "
allocationTypeId--" 2
,--2 3!
allocationTypeInitial--4 I
,--I J
allocationTypes--K Z
)--Z [
;--[ \
}.. 
public00 

static00 
AllocationType00  
Update00! '
(00' (
int00( +
allocationTypeId00, <
,00< =
string00> D!
allocationTypeInitial00E Z
,00Z [
string00\ b
allocationTypes00c r
)00r s
{11 
if22 

(22 
string22 
.22 
IsNullOrWhiteSpace22 %
(22% &!
allocationTypeInitial22& ;
)22; <
||22= ?
string22@ F
.22F G
IsNullOrWhiteSpace22G Y
(22Y Z
allocationTypes22Z i
)22i j
||22k m
allocationTypeId22n ~
<	22 Ä
$num
22Å Ç
)
22Ç É
{33 	
throw44 
new44 
ArgumentException44 '
(44' (
$str44( G
)44G H
;44H I
}55 	
if77 

(77 
allocationTypeId77 
<=77 
-77  !
$num77! "
)77" #
throw88 
new88 
ArgumentException88 '
(88' (
$str88( W
)88W X
;88X Y
if:: 

(:: 
string:: 
.:: 
IsNullOrWhiteSpace:: %
(::% &!
allocationTypeInitial::& ;
)::; <
||::= ?!
allocationTypeInitial::@ U
.::U V
Length::V \
>::] ^
$num::_ `
)::` a
throw;; 
new;; 
ArgumentException;; '
(;;' (
$str;;( j
);;j k
;;;k l
if== 

(== 
string== 
.== 
IsNullOrWhiteSpace== %
(==% &
allocationTypes==& 5
)==5 6
||==7 9
allocationTypes==: I
.==I J
Length==J P
>==Q R
$num==S U
)==U V
throw>> 
new>> 
ArgumentException>> '
(>>' (
$str>>( c
)>>c d
;>>d e
return@@ 
new@@ 
AllocationType@@ !
(@@! "
allocationTypeId@@" 2
,@@2 3!
allocationTypeInitial@@4 I
,@@I J
allocationTypes@@K Z
)@@Z [
;@@[ \
}AA 
}CC ∞#
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ActivityType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class 
ActivityType 
: 
AuditableEntity ,
{ 
[ 	
Required	 
] 
public 
int 

ActivityId 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
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
 
public 
int 
ActivityTypeId !
{" #
get$ '
;' (
private) 0
set1 4
;4 5
}6 7
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
? 
ActivityTypeName '
{( )
get* -
;- .
private/ 6
set7 :
;: ;
}< =
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? #
ActivityTypeDescription .
{/ 0
get1 4
;4 5
private6 =
set> A
;A B
}C D
public 
ActivityType 
( 
) 
{ 
} 
public 
ActivityType 
( 
int 

activityId  *
,* +
int, /
activityTypeId0 >
,> ?
string@ F
activityTypeNameG W
,W X
stringY _#
activityTypeDescription` w
)w x
{ 	

ActivityId 
= 

activityId #
;# $
ActivityTypeId 
= 
activityTypeId +
;+ ,
ActivityTypeName 
= 
activityTypeName /
;/ 0#
ActivityTypeDescription #
=$ %#
activityTypeDescription& =
;= >
} 	
public   
static   
ActivityType   "
Create  $ *
(  * +
int  + .

activityId  / 9
,  9 :
int  ; >
activityTypeId  ? M
,  M N
string  O U
activityTypeName  V f
,  f g
string  h n$
activityTypeDescription	  o Ü
)
  Ü á
{!! 	
if"" 
("" 
string"" 
."" 
IsNullOrWhiteSpace"" )
("") *
activityTypeName""* :
)"": ;
||""< >
activityTypeId""? M
<""N O
$num""P Q
||""R T

activityId""U _
<""` a
$num""b c
)""c d
{## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, I
)$$I J
;$$J K
}%% 
if'' 
('' 

activityId'' 
<'' 
$num'' 
)'' 
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, T
)((T U
;((U V
if** 
(** 
activityTypeId** 
<**  
$num**! "
)**" #
throw++ 
new++ 
ArgumentException++ +
(+++ ,
$str++, Y
)++Y Z
;++Z [
if.. 
(.. 
string.. 
... 
IsNullOrWhiteSpace.. )
(..) *
activityTypeName..* :
)..: ;
||..< >
activityTypeName..? O
...O P
Length..P V
>..W X
$num..Y [
)..[ \
throw// 
new// 
ArgumentException// +
(//+ ,
$str//, j
)//j k
;//k l
return11 
new11 
ActivityType11 #
(11# $

activityId11$ .
,11. /
activityTypeId110 >
,11> ?
activityTypeName11@ P
,11P Q#
activityTypeDescription11R i
)11i j
;11j k
}22 	
}44 
}:: Ω
|/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Activity.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Property0 8
{ 
public 
class 
Activity 
: 
AuditableEntity (
{ 
[ 	
Key	 
] 
[ 	
Required	 
] 
public 
int 

ActivityId 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
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
? 
ActivityName #
{$ %
get& )
;) *
private+ 2
set3 6
;6 7
}8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ActivityDescription *
{+ ,
get- 0
;0 1
private2 9
set: =
;= >
}? @
public 
Activity 
( 
) 
{ 
} 
public 
Activity 
( 
int 

activityId &
,& '
string( .
activityName/ ;
,; <
string= C
activityDescriptionD W
)W X
{ 	

ActivityId 
= 

activityId #
;# $
ActivityName 
= 
activityName '
;' (
ActivityDescription 
=  !
activityDescription" 5
;5 6
} 	
public 
static 
Activity 
Create %
(% &
int& )

activityId* 4
,4 5
string6 <
activityName= I
,I J
stringK Q
activityDescriptionR e
)e f
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
activityName* 6
)6 7
||8 :

activityId; E
<F G
$numH I
)I J
{ 
throw   
new   
ArgumentException   +
(  + ,
$str  , D
)  D E
;  E F
}!! 
if## 
(## 

activityId## 
<## 
$num## 
)## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, T
)$$T U
;$$U V
if&& 
(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& )
(&&) *
activityName&&* 6
)&&6 7
||&&8 :
activityName&&; G
.&&G H
Length&&H N
>&&O P
$num&&Q S
)&&S T
throw'' 
new'' 
ArgumentException'' +
(''+ ,
$str'', e
)''e f
;''f g
return)) 
new)) 
Activity)) 
())  

activityId))  *
,))* +
activityName)), 8
,))8 9
activityDescription)): M
)))M N
;))N O
}** 	
}.. 
}// Ü!
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/Title.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
Title 
: 
AuditableEntity $
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
TitleId 
{ 
get 
; 
set !
;! "
}# $
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
Titles 
{ 
get 
; 
set  #
;# $
}% &
public 

Title 
( 
int 
titleId 
, 
string $
titles% +
)+ ,
{ 
TitleId 
= 
titleId 
; 
Titles 
= 
titles 
; 
} 
public 

static 
Title 
Create 
( 
int "
titleId# *
,* +
string, 2
titles3 9
)9 :
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
titles& ,
), -
||. 0
titleId1 8
<9 :
$num; <
)< =
{ 	
throw 
new 
ArgumentException '
(' (
$str( =
)= >
;> ?
} 	
if 

( 
titleId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( M
)M N
;N O
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
titles& ,
), -
||. 0
titles1 7
.7 8
Length8 >
>? @
$numA C
)C D
throw 
new 
ArgumentException '
(' (
$str( Y
)Y Z
;Z [
return!! 
new!! 
Title!! 
(!! 
titleId!!  
,!!  !
titles!!" (
)!!( )
;!!) *
}"" 
public$$ 

static$$ 
Title$$ 
Update$$ 
($$ 
int$$ "
titleId$$# *
,$$* +
string$$, 2
titles$$3 9
)$$9 :
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &
titles&&& ,
)&&, -
||&&. 0
titleId&&1 8
<&&9 :
$num&&; <
)&&< =
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( =
)((= >
;((> ?
})) 	
if++ 

(++ 
titleId++ 
<=++ 
-++ 
$num++ 
)++ 
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( M
),,M N
;,,N O
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
titles..& ,
).., -
||... 0
titles..1 7
...7 8
Length..8 >
>..? @
$num..A C
)..C D
throw// 
new// 
ArgumentException// '
(//' (
$str//( Y
)//Y Z
;//Z [
return22 
new22 
Title22 
(22 
titleId22  
,22  !
titles22" (
)22( )
;22) *
}33 
}44 Æ#
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/SocialMedia.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
SocialMedia 
: 
AuditableEntity *
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
SocialMediaId 
{ 
get "
;" #
set$ '
;' (
}) *
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
SocialMediaPlatform %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

SocialMedia 
( 
int 
socialMediaId (
,( )
string* 0
socialMediaPlatform1 D
)D E
{ 
SocialMediaId 
= 
socialMediaId %
;% &
SocialMediaPlatform 
= 
socialMediaPlatform 1
;1 2
} 
public 

static 
SocialMedia 
Create $
($ %
int% (
socialmediaId) 6
,6 7
string8 >
socialmediaPlatform? R
)R S
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
socialmediaPlatform& 9
)9 :
||; =
socialmediaId> K
<L M
$numN O
)O P
{ 	
throw 
new 
ArgumentException '
(' (
$str( D
)D E
;E F
} 	
if 

( 
socialmediaId 
<= 
- 
$num 
)  
throw 
new 
ArgumentException '
(' (
$str( T
)T U
;U V
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
socialmediaPlatform& 9
)9 :
||; =
socialmediaPlatform> Q
.Q R
LengthR X
>Y Z
$num[ ]
)] ^
throw 
new 
ArgumentException '
(' (
$str( `
)` a
;a b
return!! 
new!! 
SocialMedia!! 
(!! 
socialmediaId!! ,
,!!, -
socialmediaPlatform!!. A
)!!A B
;!!B C
}"" 
public$$ 

static$$ 
SocialMedia$$ 
Update$$ $
($$$ %
int$$% (
socialmediaId$$) 6
,$$6 7
string$$8 >
socialmediaPlatform$$? R
)$$R S
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &
socialmediaPlatform&&& 9
)&&9 :
||&&; =
socialmediaId&&> K
<&&L M
$num&&N O
)&&O P
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( D
)((D E
;((E F
})) 	
if++ 

(++ 
socialmediaId++ 
<=++ 
-++ 
$num++ 
)++  
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( T
),,T U
;,,U V
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &
socialmediaPlatform..& 9
)..9 :
||..; =
socialmediaPlatform..> Q
...Q R
Length..R X
>..Y Z
$num..[ ]
)..] ^
throw// 
new// 
ArgumentException// '
(//' (
$str//( `
)//` a
;//a b
return22 
new22 
SocialMedia22 
(22 
socialmediaId22 ,
,22, -
socialmediaPlatform22. A
)22A B
;22B C
}33 
}55 Ó"
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/ResidentType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
ResidentType 
: 
AuditableEntity +
{ 
[ 
Key 
] 	
[		 
Required		 
]		 
public

 

int

 
ResidentTypeId

 
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
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
ResidentTypes 
{  !
get" %
;% &
set' *
;* +
}, -
public 

ResidentType 
( 
int 
residentTypeId *
,* +
string, 2
residentTypes3 @
)@ A
{ 
ResidentTypeId 
= 
residentTypeId '
;' (
ResidentTypes 
= 
residentTypes %
;% &
} 
public 

static 
ResidentType 
Create %
(% &
int& )
residentTypeId* 8
,8 9
string: @
residentTypesA N
)N O
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
residentTypes& 3
)3 4
||5 7
residentTypeId8 F
<G H
$numI J
)J K
{ 	
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
} 	
if 

( 
residentTypeId 
<= 
- 
$num  
)  !
throw 
new 
ArgumentException '
(' (
$str( U
)U V
;V W
if   

(   
string   
.   
IsNullOrWhiteSpace   %
(  % &
residentTypes  & 3
)  3 4
||  5 7
residentTypes  8 E
.  E F
Length  F L
>  M N
$num  O Q
)  Q R
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( a
)!!a b
;!!b c
return$$ 
new$$ 
ResidentType$$ 
($$  
residentTypeId$$  .
,$$. /
residentTypes$$0 =
)$$= >
;$$> ?
}%% 
public'' 

static'' 
ResidentType'' 
Update'' %
(''% &
int''& )
residentTypeId''* 8
,''8 9
string'': @
residentTypes''A N
)''N O
{(( 
if)) 

()) 
string)) 
.)) 
IsNullOrWhiteSpace)) %
())% &
residentTypes))& 3
)))3 4
||))5 7
residentTypeId))8 F
<))G H
$num))I J
)))J K
{** 	
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( E
)++E F
;++F G
},, 	
if.. 

(.. 
residentTypeId.. 
<=.. 
-.. 
$num..  
)..  !
throw// 
new// 
ArgumentException// '
(//' (
$str//( U
)//U V
;//V W
if11 

(11 
string11 
.11 
IsNullOrWhiteSpace11 %
(11% &
residentTypes11& 3
)113 4
||115 7
residentTypes118 E
.11E F
Length11F L
>11M N
$num11O Q
)11Q R
throw22 
new22 
ArgumentException22 '
(22' (
$str22( a
)22a b
;22b c
return55 
new55 
ResidentType55 
(55  
residentTypeId55  .
,55. /
residentTypes550 =
)55= >
;55> ?
}66 
}77 á$
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/OwnershipType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
OwnershipType 
: 
AuditableEntity ,
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
OwnershipTypeId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
OwnershipTypes  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

OwnershipType 
( 
int 
ownershipTypeId ,
,, -
string. 4
ownershipTypes5 C
)C D
{ 
OwnershipTypeId 
= 
ownershipTypeId )
;) *
OwnershipTypes 
= 
ownershipTypes '
;' (
} 
public 

static 
OwnershipType 
Create  &
(& '
int' *
ownershipTypeId+ :
,: ;
string< B
ownershipTypesC Q
)Q R
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
ownershipTypes& 4
)4 5
||6 8
ownershipTypeId9 H
<I J
$numK L
)L M
{ 	
throw 
new 
ArgumentException '
(' (
$str( F
)F G
;G H
} 	
if 

( 
ownershipTypeId 
<= 
-  
$num  !
)! "
{ 	
throw 
new 
ArgumentException '
(' (
$str( V
)V W
;W X
} 	
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
ownershipTypes& 4
)4 5
||6 8
ownershipTypes9 G
.G H
LengthH N
>O P
$numQ S
)S T
{   	
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( b
)!!b c
;!!c d
}"" 	
return$$ 
new$$ 
OwnershipType$$  
($$  !
ownershipTypeId$$! 0
,$$0 1
ownershipTypes$$2 @
)$$@ A
;$$A B
}%% 
public'' 

static'' 
OwnershipType'' 
Update''  &
(''& '
int''' *
ownershipTypeId''+ :
,'': ;
string''< B
ownershipTypes''C Q
)''Q R
{(( 
if)) 

()) 
string)) 
.)) 
IsNullOrWhiteSpace)) %
())% &
ownershipTypes))& 4
)))4 5
||))6 8
ownershipTypeId))9 H
<))I J
$num))K L
)))L M
{** 	
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( F
)++F G
;++G H
},, 	
if.. 

(.. 
ownershipTypeId.. 
<=.. 
-..  
$num..  !
)..! "
{// 	
throw00 
new00 
ArgumentException00 '
(00' (
$str00( V
)00V W
;00W X
}11 	
if33 

(33 
string33 
.33 
IsNullOrWhiteSpace33 %
(33% &
ownershipTypes33& 4
)334 5
||336 8
ownershipTypes339 G
.33G H
Length33H N
>33O P
$num33Q S
)33S T
{44 	
throw55 
new55 
ArgumentException55 '
(55' (
$str55( b
)55b c
;55c d
}66 	
return88 
new88 
OwnershipType88  
(88  !
ownershipTypeId88! 0
,880 1
ownershipTypes882 @
)88@ A
;88A B
}99 
}:: —!
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/Gender.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
Gender 
: 
AuditableEntity %
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
GenderId 
{ 
get 
; 
set "
;" #
}$ %
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 

GenderType 
{ 
get "
;" #
set$ '
;' (
}) *
public 

Gender 
( 
int 
genderId 
, 
string  &

genderType' 1
)1 2
{ 
GenderId 
= 
genderId 
; 

GenderType 
= 

genderType 
;  
} 
public 

static 
Gender 
Create 
(  
int  #
genderId$ ,
,, -
string. 4

genderType5 ?
)? @
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &

genderType& 0
)0 1
||2 4
genderId5 =
<> ?
$num@ A
)A B
{ 	
throw 
new 
ArgumentException '
(' (
$str( >
)> ?
;? @
} 	
if 

( 
genderId 
<= 
- 
$num 
) 
throw 
new 
ArgumentException '
(' (
$str( N
)N O
;O P
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &

genderType& 0
)0 1
||2 4

genderType5 ?
.? @
Length@ F
>G H
$numI K
)K L
throw 
new 
ArgumentException '
(' (
$str( Z
)Z [
;[ \
return!! 
new!! 
Gender!! 
(!! 
genderId!! "
,!!" #

genderType!!$ .
)!!. /
;!!/ 0
}"" 
public$$ 

static$$ 
Gender$$ 
Update$$ 
($$  
int$$  #
genderId$$$ ,
,$$, -
string$$. 4

genderType$$5 ?
)$$? @
{%% 
if&& 

(&& 
string&& 
.&& 
IsNullOrWhiteSpace&& %
(&&% &

genderType&&& 0
)&&0 1
||&&2 4
genderId&&5 =
<&&> ?
$num&&@ A
)&&A B
{'' 	
throw(( 
new(( 
ArgumentException(( '
(((' (
$str((( >
)((> ?
;((? @
})) 	
if++ 

(++ 
genderId++ 
<=++ 
-++ 
$num++ 
)++ 
throw,, 
new,, 
ArgumentException,, '
(,,' (
$str,,( N
),,N O
;,,O P
if.. 

(.. 
string.. 
... 
IsNullOrWhiteSpace.. %
(..% &

genderType..& 0
)..0 1
||..2 4

genderType..5 ?
...? @
Length..@ F
>..G H
$num..I K
)..K L
throw// 
new// 
ArgumentException// '
(//' (
$str//( Z
)//Z [
;//[ \
return22 
new22 
Gender22 
(22 
genderId22 "
,22" #

genderType22$ .
)22. /
;22/ 0
}33 
}55 ⁄"
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/Nationality.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
Nationality 
: 
AuditableEntity *
{ 
[ 
Key 
] 	
[		 
Required		 
]		 
public

 

int

 
NationalityId

 
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
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 

string 
Nationalities 
{  !
get" %
;% &
set' *
;* +
}, -
public 

Nationality 
( 
int 
nationalityId (
,( )
string* 0
nationalities1 >
)> ?
{ 
NationalityId 
= 
nationalityId %
;% &
Nationalities 
= 
nationalities %
;% &
} 
public 

static 
Nationality 
Create $
($ %
int% (
nationalityId) 6
,6 7
string8 >
nationalities? L
)L M
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
nationalities& 3
)3 4
||5 7
nationalityId8 E
<F G
$numH I
)I J
{ 	
throw 
new 
ArgumentException '
(' (
$str( C
)C D
;D E
} 	
if 

( 
nationalityId 
<= 
- 
$num 
)  
throw 
new 
ArgumentException '
(' (
$str( S
)S T
;T U
if   

(   
string   
.   
IsNullOrWhiteSpace   %
(  % &
nationalities  & 3
)  3 4
||  5 7
nationalities  8 E
.  E F
Length  F L
>  M N
$num  O Q
)  Q R
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( _
)!!_ `
;!!` a
return$$ 
new$$ 
Nationality$$ 
($$ 
nationalityId$$ ,
,$$, -
nationalities$$. ;
)$$; <
;$$< =
}%% 
public'' 

static'' 
Nationality'' 
Update'' $
(''$ %
int''% (
nationalityId'') 6
,''6 7
string''8 >
nationalities''? L
)''L M
{(( 
if)) 

()) 
string)) 
.)) 
IsNullOrWhiteSpace)) %
())% &
nationalities))& 3
)))3 4
||))5 7
nationalityId))8 E
<))F G
$num))H I
)))I J
{** 	
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( C
)++C D
;++D E
},, 	
if.. 

(.. 
nationalityId.. 
<=.. 
-.. 
$num.. 
)..  
throw// 
new// 
ArgumentException// '
(//' (
$str//( S
)//S T
;//T U
if11 

(11 
string11 
.11 
IsNullOrWhiteSpace11 %
(11% &
nationalities11& 3
)113 4
||115 7
nationalities118 E
.11E F
Length11F L
>11M N
$num11O Q
)11Q R
throw22 
new22 
ArgumentException22 '
(22' (
$str22( _
)22_ `
;22` a
return55 
new55 
Nationality55 
(55 
nationalityId55 ,
,55, -
nationalities55. ;
)55; <
;55< =
}66 
}77 •$
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/IdentificationType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
IdentificationType 
:  !
AuditableEntity" 1
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int  
IdentificationTypeId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
? 
IdentificationTypes &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 

IdentificationType 
( 
int ! 
identificationTypeId" 6
,6 7
string8 >
identificationTypes? R
)R S
{  
IdentificationTypeId 
=  
identificationTypeId 3
;3 4
IdentificationTypes 
= 
identificationTypes 1
;1 2
} 
public 

static 
IdentificationType $
Create% +
(+ ,
int, / 
identificationTypeId0 D
,D E
stringF L
identificationTypesM `
)` a
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
identificationTypes& 9
)9 :
||; = 
identificationTypeId> R
<S T
$numU V
)V W
{ 	
throw 
new 
ArgumentException '
(' (
$str( K
)K L
;L M
} 	
if 

(  
identificationTypeId  
<=! #
$num$ %
)% &
throw 
new 
ArgumentException '
(' (
$str( [
)[ \
;\ ]
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
identificationTypes& 9
)9 :
||; =
identificationTypes> Q
.Q R
LengthR X
>Y Z
$num[ ]
)] ^
throw 
new 
ArgumentException '
(' (
$str( g
)g h
;h i
return   
new   
IdentificationType   %
(  % & 
identificationTypeId  & :
,  : ;
identificationTypes  < O
)  O P
;  P Q
}!! 
public## 

static## 
IdentificationType## $
Update##% +
(##+ ,
int##, / 
identificationTypeId##0 D
,##D E
string##F L
identificationTypes##M `
)##` a
{$$ 
if%% 

(%% 
string%% 
.%% 
IsNullOrWhiteSpace%% %
(%%% &
identificationTypes%%& 9
)%%9 :
||%%; = 
identificationTypeId%%> R
<%%S T
$num%%U V
)%%V W
{&& 	
throw'' 
new'' 
ArgumentException'' '
(''' (
$str''( K
)''K L
;''L M
}(( 	
if** 

(**  
identificationTypeId**  
<=**! #
$num**$ %
)**% &
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( [
)++[ \
;++\ ]
if-- 

(-- 
string-- 
.-- 
IsNullOrWhiteSpace-- %
(--% &
identificationTypes--& 9
)--9 :
||--; =
identificationTypes--> Q
.--Q R
Length--R X
>--Y Z
$num--[ ]
)--] ^
throw.. 
new.. 
ArgumentException.. '
(..' (
$str..( g
)..g h
;..h i
return00 
new00 
IdentificationType00 %
(00% & 
identificationTypeId00& :
,00: ;
identificationTypes00< O
)00O P
;00P Q
}11 
}22 ∆#
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/CustomerType.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Setup* /
./ 0
Customer0 8
;8 9
public 
class 
CustomerType 
: 
AuditableEntity +
{ 
[ 
Key 
] 	
[ 
Required 
] 
public 

int 
CustomerTypeId 
{ 
get  #
;# $
set% (
;( )
}* +
[		 
Required		 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 

string 
CustomerTypes 
{  !
get" %
;% &
set' *
;* +
}, -
public 

CustomerType 
( 
int 
customerTypeId *
,* +
string, 2
customerTypes3 @
)@ A
{ 
CustomerTypeId 
= 
customerTypeId '
;' (
CustomerTypes 
= 
customerTypes %
;% &
} 
public 

static 
CustomerType 
Create %
(% &
int& )
customerTypeId* 8
,8 9
string: @
customerTypesA N
)N O
{ 
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
customerTypes& 3
)3 4
||5 7
customerTypeId8 F
<G H
$numI J
)J K
{ 	
throw 
new 
ArgumentException '
(' (
$str( E
)E F
;F G
} 	
if 

( 
customerTypeId 
< 
$num 
) 
{ 	
throw 
new 
ArgumentException '
(' (
$str( U
)U V
;V W
} 	
if 

( 
string 
. 
IsNullOrWhiteSpace %
(% &
customerTypes& 3
)3 4
||5 7
customerTypes8 E
.E F
LengthF L
>M N
$numO Q
)Q R
{   	
throw!! 
new!! 
ArgumentException!! '
(!!' (
$str!!( a
)!!a b
;!!b c
}"" 	
return$$ 
new$$ 
CustomerType$$ 
($$  
customerTypeId$$  .
,$$. /
customerTypes$$0 =
)$$= >
;$$> ?
}%% 
public'' 

static'' 
CustomerType'' 
Update'' %
(''% &
int''& )
customerTypeId''* 8
,''8 9
string'': @
customerTypes''A N
)''N O
{(( 
if)) 

()) 
string)) 
.)) 
IsNullOrWhiteSpace)) %
())% &
customerTypes))& 3
)))3 4
||))5 7
customerTypeId))8 F
<))G H
$num))I J
)))J K
{** 	
throw++ 
new++ 
ArgumentException++ '
(++' (
$str++( E
)++E F
;++F G
},, 	
if.. 

(.. 
customerTypeId.. 
<.. 
$num.. 
).. 
{// 	
throw00 
new00 
ArgumentException00 '
(00' (
$str00( U
)00U V
;00V W
}11 	
if33 

(33 
string33 
.33 
IsNullOrWhiteSpace33 %
(33% &
customerTypes33& 3
)333 4
||335 7
customerTypes338 E
.33E F
Length33F L
>33M N
$num33O Q
)33Q R
{44 	
throw55 
new55 
ArgumentException55 '
(55' (
$str55( a
)55a b
;55b c
}66 	
return88 
new88 
CustomerType88 
(88  
customerTypeId88  .
,88. /
customerTypes880 =
)88= >
;88> ?
}99 
}:: Ê¨
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/PropertyMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Registration* 6
{		 
public

 

class

 
PropertyMaster

 
:

  !

BaseEntity

" ,
{ 
[ 	
Key	 
] 
public 
int 
PropertyMasterId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
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
}2 3
public 
int 
PropertyTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
public 
int 
	LandUseId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
LandUseTypeId  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
] 
public 
int 
AllocationTypeId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[   	
StringLength  	 
(   
$num   
)   
]   
public!! 
string!! 
?!! 
BlockNumber!! "
{!!# $
get!!% (
;!!( )
set!!* -
;!!- .
}!!/ 0
[## 	
StringLength##	 
(## 
$num## 
)## 
]## 
public$$ 
string$$ 
?$$ 

PlotNumber$$ !
{$$" #
get$$$ '
;$$' (
set$$) ,
;$$, -
}$$. /
public&& 
double&& 

AcreageOne&&  
{&&! "
get&&# &
;&&& '
set&&( +
;&&+ ,
}&&- .
public(( 
double(( 

AcreageTwo((  
{((! "
get((# &
;((& '
set((( +
;((+ ,
}((- .
public** 
int** 
PropertyHeightId** #
{**$ %
get**& )
;**) *
set**+ .
;**. /
}**0 1
public,, 
int,, 

PlotSizeId,, 
{,, 
get,,  #
;,,# $
set,,% (
;,,( )
},,* +
public.. 
double.. 
SellingPrice.. "
{..# $
get..% (
;..( )
set..* -
;..- .
}../ 0
public00 
int00 

CurrencyId00 
{00 
get00  #
;00# $
set00% (
;00( )
}00* +
[22 	
StringLength22	 
(22 
$num22 
)22 
]22 
public33 
string33 
?33 

RentalType33 !
{33" #
get33$ '
;33' (
set33) ,
;33, -
}33. /
public55 
int55 
TotalNumberOfRooms55 %
{55& '
get55( +
;55+ ,
set55- 0
;550 1
}552 3
public77 
int77 
RoomsOccupied77  
{77! "
get77# &
;77& '
set77( +
;77+ ,
}77- .
public99 
int99 
ApartmentTypeId99 "
{99# $
get99% (
;99( )
set99* -
;99- .
}99/ 0
public;; 
int;; 
SchemeTypeId;; 
{;;  !
get;;" %
;;;% &
set;;' *
;;;* +
};;, -
public== 
int== "
ApartmentBlockNumberId== )
{==* +
get==, /
;==/ 0
set==1 4
;==4 5
}==6 7
public?? 
int?? 
BlockTypeId?? 
{??  
get??! $
;??$ %
set??& )
;??) *
}??+ ,
publicAA 
intAA 
FloorNumberIdAA  
{AA! "
getAA# &
;AA& '
setAA( +
;AA+ ,
}AA- .
publicCC 
intCC 
BlockUnitIdCC 
{CC  
getCC! $
;CC$ %
setCC& )
;CC) *
}CC+ ,
publicEE 
intEE 
BlockSideIdEE 
{EE  
getEE! $
;EE$ %
setEE& )
;EE) *
}EE+ ,
[GG 	
StringLengthGG	 
(GG 
$numGG 
)GG 
]GG 
publicHH 
stringHH 
?HH 
	FloorAreaHH  
{HH! "
getHH# &
;HH& '
setHH( +
;HH+ ,
}HH- .
publicJJ 
intJJ 

RoomNumberJJ 
{JJ 
getJJ  #
;JJ# $
setJJ% (
;JJ( )
}JJ* +
publicLL 
DateTimeLL 
RightOfEntryLL $
{LL% &
getLL' *
;LL* +
setLL, /
;LL/ 0
}LL1 2
publicNN 
intNN 
	LeaseTermNN 
{NN 
getNN "
;NN" #
setNN$ '
;NN' (
}NN) *
publicPP 
DateTimePP 
LeaseExpiryDatePP '
{PP( )
getPP* -
;PP- .
setPP/ 2
;PP2 3
}PP4 5
publicRR 
intRR 

DebtorTypeRR 
{RR 
getRR  #
;RR# $
setRR% (
;RR( )
}RR* +
publicTT 
intTT 
GroupNumberTT 
{TT  
getTT! $
;TT$ %
setTT& )
;TT) *
}TT+ ,
[VV 	
StringLengthVV	 
(VV 
$numVV 
)VV 
]VV 
publicWW 
stringWW 
?WW 
CustomerCodeWW #
{WW$ %
getWW& )
;WW) *
setWW+ .
;WW. /
}WW0 1
[YY 	
StringLengthYY	 
(YY 
$numYY 
)YY 
]YY 
publicZZ 
stringZZ 
?ZZ 
SitePlanNumberZZ %
{ZZ& '
getZZ( +
;ZZ+ ,
setZZ- 0
;ZZ0 1
}ZZ2 3
[\\ 	
StringLength\\	 
(\\ 
$num\\ 
)\\ 
]\\ 
public]] 
string]] 
?]] 
CadastralPlanNumber]] *
{]]+ ,
get]]- 0
;]]0 1
set]]2 5
;]]5 6
}]]7 8
[__ 	
StringLength__	 
(__ 
$num__ 
)__ 
]__ 
public`` 
string`` 
?`` 
CoordinateOne`` $
{``% &
get``' *
;``* +
set``, /
;``/ 0
}``1 2
[bb 	
StringLengthbb	 
(bb 
$numbb 
)bb 
]bb 
publiccc 
stringcc 
?cc 
CoordinateTwocc $
{cc% &
getcc' *
;cc* +
setcc, /
;cc/ 0
}cc1 2
[ee 	
StringLengthee	 
(ee 
$numee 
)ee 
]ee 
publicff 
stringff 
?ff 
CoordinateThreeff &
{ff' (
getff) ,
;ff, -
setff. 1
;ff1 2
}ff3 4
[hh 	
StringLengthhh	 
(hh 
$numhh 
)hh 
]hh 
publicii 
stringii 
?ii 
CoordinateFourii %
{ii& '
getii( +
;ii+ ,
setii- 0
;ii0 1
}ii2 3
[kk 	
StringLengthkk	 
(kk 
$numkk 
)kk 
]kk 
publicll 
stringll 
?ll 
CoordinateFivell %
{ll& '
getll( +
;ll+ ,
setll- 0
;ll0 1
}ll2 3
[nn 	
StringLengthnn	 
(nn 
$numnn 
)nn 
]nn 
publicoo 
stringoo 
?oo 
CoordinateSixoo $
{oo% &
getoo' *
;oo* +
setoo, /
;oo/ 0
}oo1 2
[qq 	
StringLengthqq	 
(qq 
$numqq 
)qq 
]qq 
publicrr 
stringrr 
?rr  
MotherPropertyNumberrr +
{rr, -
getrr. 1
;rr1 2
setrr3 6
;rr6 7
}rr8 9
[tt 	
StringLengthtt	 
(tt 
$numtt 
)tt 
]tt 
publicuu 
stringuu 
?uu 
Commentsuu 
{uu  !
getuu" %
;uu% &
setuu' *
;uu* +
}uu, -
publicww 
boolww 
IsLargeScaleww  
{ww! "
getww# &
;ww& '
setww( +
;ww+ ,
}ww- .
publicyy 
boolyy 
	IsDeletedyy 
{yy 
getyy  #
;yy# $
setyy% (
;yy( )
}yy* +
public{{ 
PropertyMaster{{ 
({{ 
){{ 
{|| 	
}}} 	
public 
PropertyMaster 
( 
int !
propertyTypeId" 0
,0 1
int2 5
	landUseId6 ?
,? @
intA D
landUseTypeIdE R
,R S
intT W

localityIdX b
,b c
intd g
allocationTypeIdh x
,x y
string	z Ä
blockNumber
Å å
,
å ç
string
é î

plotNumber
ï ü
,
ü †
double
° ß

acreageOne
® ≤
,
≤ ≥
double
¥ ∫

acreageTwo
ª ≈
,
≈ ∆
int
«  
propertyHeightId
À €
,
€ ‹
int
› ‡

plotSizeId
· Î
,
Î Ï
string
Ì Û
sitePlanNumber
Ù Ç
,
Ç É
bool
Ñ à
isLargeScale
â ï
=
ñ ó
false
ò ù
)
ù û
{
ÄÄ 	
}
ÇÇ 	
public
ÖÖ 
static
ÖÖ 
PropertyMaster
ÖÖ $
Create
ÖÖ% +
(
ÖÖ+ ,
int
ÖÖ, /
propertyMasterId
ÖÖ0 @
,
ÖÖ@ A
int
ÖÖB E
propertyTypeId
ÖÖF T
,
ÖÖT U
string
ÖÖV \
landUseInitial
ÖÖ] k
,
ÖÖk l
int
ÖÖm p
	landUseId
ÖÖq z
,
ÖÖz {
stringÖÖ| Ç"
landUseTypeInitialÖÖÉ ï
,ÖÖï ñ
intÖÖó ö
landUseTypeIdÖÖõ ®
,ÖÖ® ©
stringÖÖ™ ∞
localityInitialÖÖ± ¿
,ÖÖ¿ ¡
intÖÖ¬ ≈

localityIdÖÖ∆ –
,ÖÖ– —
stringÖÖ“ ÿ%
allocationTypeInitialÖÖŸ Ó
,ÖÖÓ Ô
intÖÖ Û 
allocationTypeIdÖÖÙ Ñ
,ÖÖÑ Ö
stringÖÖÜ å
blockNumberÖÖç ò
,ÖÖò ô
stringÖÖö †

plotNumberÖÖ° ´
,ÖÖ´ ¨
doubleÖÖ≠ ≥

acreageOneÖÖ¥ æ
,ÖÖæ ø
doubleÖÖ¿ ∆

acreageTwoÖÖ« —
,ÖÖ— “
intÖÖ” ÷ 
propertyHeightIdÖÖ◊ Á
,ÖÖÁ Ë
intÖÖÈ Ï

plotSizeIdÖÖÌ ˜
,ÖÖ˜ ¯
stringÖÖ˘ ˇ
sitePlanNumberÖÖÄ é
,ÖÖé è
boolÖÖê î
isLargeScaleÖÖï °
=ÖÖ¢ £
falseÖÖ§ ©
)ÖÖ© ™
{
ÜÜ 	
if
áá 
(
áá 
string
áá 
.
áá  
IsNullOrWhiteSpace
áá )
(
áá) *
landUseInitial
áá* 8
)
áá8 9
||
áá; =
string
áá> D
.
ááD E 
IsNullOrWhiteSpace
ááE W
(
ááW X
localityInitial
ááX g
)
áág h
||
áái k
string
áál r
.
áár s!
IsNullOrWhiteSpaceáás Ö
(ááÖ Ü%
allocationTypeInitialááÜ õ
)ááõ ú
||ááù ü
string
àà 
.
àà  
IsNullOrWhiteSpace
àà )
(
àà) *

plotNumber
àà* 4
)
àà4 5
||
àà6 8
	landUseId
àà9 B
<=
ààC E
$num
ààF G
||
ààH J
landUseTypeId
ààK X
<=
ààY [
$num
àà\ ]
||
àà^ `

localityId
ààa k
<=
ààl n
$num
àào p
||
ààq s
allocationTypeIdààt Ñ
<=ààÖ á
$numààà â
)ààâ ä
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
ää, Q
)
ääQ R
;
ääR S
}
ãã 
if
çç 
(
çç 
	landUseId
çç 
<=
çç 
$num
çç 
)
çç 
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
èè, T
)
èèT U
;
èèU V
}
êê 
if
íí 
(
íí 
landUseTypeId
íí 
<=
íí  
$num
íí! "
)
íí" #
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
îî, Y
)
îîY Z
;
îîZ [
}
ïï 
if
óó 
(
óó 

localityId
óó 
<=
óó 
$num
óó 
)
óó  
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
ôô, T
)
ôôT U
;
ôôU V
}
öö 
if
úú 
(
úú 
allocationTypeId
úú  
<=
úú! #
$num
úú$ %
)
úú% &
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
ûû, [
)
ûû[ \
;
ûû\ ]
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
landUseInitial
°°* 8
)
°°8 9
||
°°: <
landUseInitial
°°= K
.
°°K L
Length
°°L R
>
°°S T
$num
°°U V
)
°°V W
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
££, g
)
££g h
;
££h i
}
§§ 
if
´´ 
(
´´ 
string
´´ 
.
´´  
IsNullOrWhiteSpace
´´ )
(
´´) *
localityInitial
´´* 9
)
´´9 :
||
´´; =
localityInitial
´´> M
.
´´M N
Length
´´N T
>
´´U V
$num
´´W X
)
´´X Y
{
¨¨ 
throw
≠≠ 
new
≠≠ 
ArgumentException
≠≠ +
(
≠≠+ ,
$str
≠≠, g
)
≠≠g h
;
≠≠h i
}
ÆÆ 
if
∞∞ 
(
∞∞ 
string
∞∞ 
.
∞∞  
IsNullOrWhiteSpace
∞∞ )
(
∞∞) *#
allocationTypeInitial
∞∞* ?
)
∞∞? @
||
∞∞A C#
allocationTypeInitial
∞∞D Y
.
∞∞Y Z
Length
∞∞Z `
>
∞∞a b
$num
∞∞c d
)
∞∞d e
{
±± 
throw
≤≤ 
new
≤≤ 
ArgumentException
≤≤ +
(
≤≤+ ,
$str
≤≤, n
)
≤≤n o
;
≤≤o p
}
≥≥ 
if
µµ 
(
µµ 

plotNumber
µµ 
==
µµ 
$str
µµ !
)
µµ! "
{
∂∂ 
throw
∑∑ 
new
∑∑ 
ArgumentException
∑∑ +
(
∑∑+ ,
$str
∑∑, K
)
∑∑K L
;
∑∑L M
}
∏∏ 
string
∫∫ 
strPropertyNumber
∫∫ $
=
∫∫% &
string
∫∫' -
.
∫∫- .
Empty
∫∫. 3
;
∫∫3 4
string
ªª 
	delimiter
ªª 
=
ªª 
$str
ªª "
;
ªª" #
if
ΩΩ 
(
ΩΩ 
propertyTypeId
ΩΩ 
==
ΩΩ !
$num
ΩΩ" #
||
ΩΩ$ &
propertyTypeId
ΩΩ' 5
==
ΩΩ6 8
$num
ΩΩ9 :
||
ΩΩ; =
propertyTypeId
ΩΩ> L
==
ΩΩM O
$num
ΩΩP Q
)
ΩΩQ R
{
ææ 
}
øø 
switch
¬¬ 
(
¬¬ 
isLargeScale
¬¬  
)
¬¬  !
{
√√ 
case
ƒƒ 
false
ƒƒ 
:
ƒƒ 
if
∆∆ 
(
∆∆ 
landUseInitial
∆∆ %
==
∆∆& (
$str
∆∆) .
&&
∆∆/ 1
string
∆∆2 8
.
∆∆8 9 
IsNullOrWhiteSpace
∆∆9 K
(
∆∆K L
blockNumber
∆∆L W
)
∆∆W X
)
∆∆X Y
{
«« 
strPropertyNumber
»» )
=
»»* +
string
»», 2
.
»»2 3
Concat
»»3 9
(
»»9 : 
landUseTypeInitial
»»: L
,
»»L M
	delimiter
»»N W
,
»»W X
localityInitial
»»Y h
,
»»h i
	delimiter
»»j s
,
»»s t$
allocationTypeInitial»»u ä
,»»ä ã
	delimiter»»å ï
,»»ï ñ

plotNumber»»ó °
)»»° ¢
;»»¢ £
}
   
if
ÃÃ 
(
ÃÃ 
landUseInitial
ÃÃ &
==
ÃÃ' )
$str
ÃÃ* /
&&
ÃÃ0 2
!
ÃÃ3 4
string
ÃÃ4 :
.
ÃÃ: ; 
IsNullOrWhiteSpace
ÃÃ; M
(
ÃÃM N
blockNumber
ÃÃN Y
)
ÃÃY Z
)
ÃÃZ [
{
ÕÕ 
strPropertyNumber
ŒŒ )
=
ŒŒ* +
string
ŒŒ, 2
.
ŒŒ2 3
Concat
ŒŒ3 9
(
ŒŒ9 : 
landUseTypeInitial
ŒŒ: L
,
ŒŒL M
	delimiter
ŒŒN W
,
ŒŒW X
localityInitial
ŒŒY h
,
ŒŒh i
	delimiter
ŒŒj s
,
ŒŒs t$
allocationTypeInitialŒŒu ä
,ŒŒä ã
	delimiterŒŒå ï
,ŒŒï ñ
blockNumberŒŒó ¢
,ŒŒ¢ £
	delimiterŒŒ§ ≠
,ŒŒ≠ Æ

plotNumberŒŒØ π
)ŒŒπ ∫
;ŒŒ∫ ª
}
–– 
if
““ 
(
““ 
string
““ 
.
““  
IsNullOrWhiteSpace
““ 1
(
““1 2
blockNumber
““2 =
)
““= >
)
““> ?
{
”” 
strPropertyNumber
‘‘ )
=
‘‘* +
string
‘‘, 2
.
‘‘2 3
Concat
‘‘3 9
(
‘‘9 :
landUseInitial
‘‘: H
,
‘‘H I
	delimiter
‘‘J S
,
‘‘S T
localityInitial
‘‘U d
,
‘‘d e
	delimiter
‘‘f o
,
‘‘o p$
allocationTypeInitial‘‘q Ü
,‘‘Ü á
	delimiter‘‘à ë
,‘‘ë í

plotNumber‘‘ì ù
)‘‘ù û
;‘‘û ü
}
’’ 
if
÷÷ 
(
÷÷ 
!
÷÷ 
string
÷÷ 
.
÷÷   
IsNullOrWhiteSpace
÷÷  2
(
÷÷2 3
blockNumber
÷÷3 >
)
÷÷> ?
)
÷÷? @
{
◊◊ 
strPropertyNumber
ÿÿ )
=
ÿÿ* +
string
ÿÿ, 2
.
ÿÿ2 3
Concat
ÿÿ3 9
(
ÿÿ9 :
landUseInitial
ÿÿ: H
,
ÿÿH I
	delimiter
ÿÿJ S
,
ÿÿS T
localityInitial
ÿÿU d
,
ÿÿd e
	delimiter
ÿÿf o
,
ÿÿo p$
allocationTypeInitialÿÿq Ü
,ÿÿÜ á
	delimiterÿÿà ë
,ÿÿë í
blockNumberÿÿí ù
,ÿÿù û
	delimiterÿÿû ß
,ÿÿß ®

plotNumberÿÿ© ≥
)ÿÿ≥ ¥
;ÿÿ¥ µ
}
ŸŸ 
break
€€ 
;
€€ 
case
›› 
true
›› 
:
›› 
break
ﬁﬁ 
;
ﬁﬁ 
}
ﬂﬂ 
return
·· 
new
·· 
PropertyMaster
·· %
{
‚‚ 
PropertyMasterId
„„  
=
„„! "
propertyMasterId
„„# 3
,
„„3 4
PropertyNumber
‰‰ 
=
‰‰  
strPropertyNumber
‰‰! 2
,
‰‰2 3
PropertyTypeId
ÂÂ 
=
ÂÂ  
propertyTypeId
ÂÂ! /
,
ÂÂ/ 0

LocalityId
ÊÊ 
=
ÊÊ 

localityId
ÊÊ '
,
ÊÊ' (
	LandUseId
ÁÁ 
=
ÁÁ 
	landUseId
ÁÁ %
,
ÁÁ% &
LandUseTypeId
ËË 
=
ËË 
landUseTypeId
ËË  -
,
ËË- .
AllocationTypeId
ÈÈ  
=
ÈÈ! "
allocationTypeId
ÈÈ# 3
,
ÈÈ3 4
BlockNumber
ÍÍ 
=
ÍÍ 
blockNumber
ÍÍ )
,
ÍÍ) *

PlotNumber
ÎÎ 
=
ÎÎ 

plotNumber
ÎÎ '
,
ÎÎ' (

AcreageOne
ÏÏ 
=
ÏÏ 

acreageOne
ÏÏ '
,
ÏÏ' (

AcreageTwo
ÌÌ 
=
ÌÌ 

acreageTwo
ÌÌ '
,
ÌÌ' (
PropertyHeightId
ÓÓ  
=
ÓÓ! "
propertyHeightId
ÓÓ# 3
,
ÓÓ3 4

PlotSizeId
ÔÔ 
=
ÔÔ 

plotSizeId
ÔÔ '
,
ÔÔ' (
SitePlanNumber
 
=
  
sitePlanNumber
! /
,
/ 0
IsLargeScale
ÒÒ 
=
ÒÒ 
isLargeScale
ÒÒ +
,
ÒÒ+ ,
	IsDeleted
ÚÚ 
=
ÚÚ 
false
ÚÚ !
}
ÛÛ 
;
ÛÛ 
}
ıı 	
}
˘˘ 
}˙˙ ®Û
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/CustomerUpdatesMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Registration* 6
{ 
public 

partial 
class 
CustomerMaster '
:( )

BaseEntity* 4
{ 
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
<

  !
CustomerMaster

! /
>

/ 0
UpdateCompanyAsync

1 C
(

C D
int

D G
customerMasterId

H X
,

X Y
int

Z ]
customerTypeId

^ l
,

l m
int

n q
residentTypeId	

r Ä
,


Ä Å
int


Ç Ö

localityId


Ü ê
,


ê ë
string


í ò
customerCode


ô •
,


• ¶
string


ß ≠
companyName


Æ π
,


π ∫
int


ª æ
nationalityId


ø Ã
,


Ã Õ
string


Œ ‘
companyAddress


’ „
,


„ ‰
string


Â Î
digitalAddress


Ï ˙
,


˙ ˚
string


¸ Ç!
primaryMobileNumber


É ñ
,


ñ ó
stringD J!
secondaryMobileNumberK `
,` a
stringb h
officeNumberi u
,u v
stringw }
whatsAppNumber	~ å
,
å ç
string
é î
emailAddress
ï °
,
° ¢
string
£ ©(
businessRegistrationNumber
™ ƒ
,
ƒ ≈
string
∆ Ã
	tinNumber
Õ ÷
,
÷ ◊
int
ÿ €
socialMediaTypeId
‹ Ì
,
Ì Ó
string
Ô ı 
socialMediaAccount
ˆ à
,
à â
stringD J&
identificationTypeImageOneK e
,e f
stringg m'
identificationTypeImageTwo	n à
,
à â
string
ä ê*
identificationTypeImageThree
ë ≠
,
≠ Æ
string
Ø µ)
identificationTypeImageFour
∂ —
,
— “
string
” Ÿ)
identificationTypeImageFive
⁄ ı
,
ı ˆ
stringD J"
contactPerson_FullNameK a
,a b
stringc i&
contactPerson_PhoneNumber	j É
,
É Ñ
string
Ö ã(
contactPerson_EmailAddress
å ¶
,
¶ ß
string
® Æ#
contactPerson_Address
Ø ƒ
,
ƒ ≈
int
∆ …0
"contactPerson_IdentificationTypeId
  Ï
,
Ï Ì
string
Ó Ù4
&contactPerson_IdentificationTypeNumber
ı õ
,
õ ú
stringD J4
(contactPerson_IdentificationTypeImageOneK s
,s t
stringu {5
(contactPerson_IdentificationTypeImageTwo	| §
,
§ •
string
¶ ¨
comments
≠ µ
,
µ ∂$
ICustomerDomainService
∑ Õ#
customerDomainService
Œ „
)
„ ‰
{ 	
if 
( 
! 
await !
customerDomainService ,
., -
CustomerExists- ;
(; <
customerMasterId< L
)L M
)M N
throw 
new 
ArgumentException +
(+ ,
$str, F
)F G
;G H
if 
( 
customerTypeId 
<= !
$num" #
||$ &

localityId' 1
<=2 4
$num5 6
||7 9
nationalityId: G
<=H J
$numK L
||M O
stringP V
.V W
IsNullOrWhiteSpaceW i
(i j
companyNamej u
)u v
||w y
string	z Ä
.
Ä Å 
IsNullOrWhiteSpace
Å ì
(
ì î
companyAddress
î ¢
)
¢ £
||
§ ¶
string
ß ≠
.
≠ Æ 
IsNullOrWhiteSpace
Æ ¿
(
¿ ¡!
primaryMobileNumber
¡ ‘
)
‘ ’
||
÷ ÿ
string
Ÿ ﬂ
.
ﬂ ‡ 
IsNullOrWhiteSpace
‡ Ú
(
Ú Û
emailAddress
Û ˇ
)
ˇ Ä
)
Ä Å
{ 
throw 
new 
ArgumentException +
(+ ,
$str, Y
)Y Z
;Z [
} 
if 
( 
! 
await !
customerDomainService ,
., -
CustomerTypeExists- ?
(? @
customerTypeId@ N
)N O
)O P
throw 
new 
ArgumentException +
(+ ,
$str, G
)G H
;H I
if 
( 
residentTypeId 
>  
$num! "
)" #
{ 
if 
( 
! 
await !
customerDomainService 0
.0 1
ResidentTypeExists1 C
(C D
residentTypeIdD R
)R S
)S T
throw 
new 
ArgumentException /
(/ 0
$str0 K
)K L
;L M
}!! 
if## 
(## 
!## 
await## !
customerDomainService## ,
.##, -
LocalityExists##- ;
(##; <

localityId##< F
)##F G
)##G H
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, B
)$$B C
;$$C D
if'' 
('' 
!'' 
await'' !
customerDomainService'' ,
.'', -
NationalityExists''- >
(''> ?
nationalityId''? L
)''L M
)''M N
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, E
)((E F
;((F G
if++ 
(++ 
string++ 
.++ 
IsNullOrWhiteSpace++ )
(++) *
companyName++* 5
)++5 6
)++6 7
{,, 
throw-- 
new-- 
ArgumentException-- +
(--+ ,
$str--, R
)--R S
;--S T
}.. 
if00 
(00 
string00 
.00 
IsNullOrWhiteSpace00 )
(00) *
companyAddress00* 8
)008 9
)009 :
{11 
throw22 
new22 
ArgumentException22 +
(22+ ,
$str22, U
)22U V
;22V W
}33 
if55 
(55 
string55 
.55 
IsNullOrWhiteSpace55 )
(55) *&
businessRegistrationNumber55* D
)55D E
)55E F
{66 
throw77 
new77 
ArgumentException77 +
(77+ ,
$str77, b
)77b c
;77c d
}88 
if:: 
(:: 
string:: 
.:: 
IsNullOrWhiteSpace:: )
(::) *
	tinNumber::* 3
)::3 4
)::4 5
{;; 
throw<< 
new<< 
ArgumentException<< +
(<<+ ,
$str<<, P
)<<P Q
;<<Q R
}== 
if?? 
(?? 
socialMediaTypeId?? !
>??" #
$num??$ %
)??% &
{@@ 
ifAA 
(AA 
!AA 
awaitAA !
customerDomainServiceAA 0
.AA0 1
SocialMediaExistsAA1 B
(AAB C
socialMediaTypeIdAAC T
)AAT U
)AAU V
throwBB 
newBB 
ArgumentExceptionBB /
(BB/ 0
$strBB0 O
)BBO P
;BBP Q
}CC 
ifEE 
(EE 
stringEE 
.EE 
IsNullOrWhiteSpaceEE )
(EE) *
customerCodeEE* 6
)EE6 7
)EE7 8
{FF 
throwGG 
newGG 
ArgumentExceptionGG +
(GG+ ,
$strGG, U
)GGU V
;GGV W
}HH 
ifJJ 
(JJ 
stringJJ 
.JJ 
IsNullOrWhiteSpaceJJ )
(JJ) *
companyAddressJJ* 8
)JJ8 9
)JJ9 :
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
(OO) *
primaryMobileNumberOO* =
)OO= >
)OO> ?
{PP 
throwQQ 
newQQ 
ArgumentExceptionQQ +
(QQ+ ,
$strQQ, ]
)QQ] ^
;QQ^ _
}RR 
ifTT 
(TT 
stringTT 
.TT 
IsNullOrWhiteSpaceTT )
(TT) *
emailAddressTT* 6
)TT6 7
)TT7 8
{UU 
throwVV 
newVV 
ArgumentExceptionVV +
(VV+ ,
$strVV, U
)VVU V
;VVV W
}WW 
varYY 
customer_localityYY !
=YY" #
awaitYY$ )!
customerDomainServiceYY* ?
.YY? @
GetLocalityDetailsYY@ R
(YYR S

localityIdYYS ]
)YY] ^
;YY^ _
if[[ 
([[ 
customer_locality[[ !
is[[" $
null[[% )
)[[) *
{\\ 
throw]] 
new]] 
ArgumentException]] +
(]]+ ,
$str]], W
)]]W X
;]]X Y
}^^ 
returnaa 
newaa 
CustomerMasteraa %
{bb 
CustomerMasterIdcc  
=cc! "
customerMasterIdcc# 3
,cc3 4
CustomerTypeIddd 
=dd  
customerTypeIddd! /
,dd/ 0
ResidentTypeIdee 
=ee  
residentTypeIdee! /
,ee/ 0

LocalityIdff 
=ff 

localityIdff '
,ff' (
CustomerCodegg 
=gg 
customerCodegg +
,gg+ ,
TitleIdhh 
=hh 
$numhh 
,hh 
SurNameii 
=ii 
stringii  
.ii  !
Emptyii! &
,ii& '

OtherNamesjj 
=jj 
stringjj #
.jj# $
Emptyjj$ )
,jj) *
CompanyNamekk 
=kk 
companyNamekk )
,kk) *
DateOfBirthll 
=ll 
Convertll %
.ll% &

ToDateTimell& 0
(ll0 1
$strll1 =
)ll= >
,ll> ?
	TinNumbermm 
=mm 
	tinNumbermm %
,mm% &
Picturenn 
=nn 
stringnn  
.nn  !
Emptynn! &
,nn& '
GenderIdoo 
=oo 
$numoo 
,oo 
NationalityIdpp 
=pp 
nationalityIdpp  -
,pp- .
PostalAddressqq 
=qq 
companyAddressqq  .
,qq. /
ResidentialAddressrr "
=rr# $
companyAddressrr% 3
,rr3 4
DigitalAddressss 
=ss  
digitalAddressss! /
,ss/ 0
PrimaryMobileNumbertt #
=tt$ %
primaryMobileNumbertt& 9
,tt9 :!
SecondaryMobileNumberuu %
=uu& '!
secondaryMobileNumberuu( =
,uu= >
OfficeNumbervv 
=vv 
officeNumbervv +
,vv+ ,
WhatsAppNumberww 
=ww  
whatsAppNumberww! /
,ww/ 0
EmailAddressxx 
=xx 
emailAddressxx +
,xx+ , 
ResidentPermitNumberyy $
=yy% &
stringyy' -
.yy- .
Emptyyy. 3
,yy3 4$
ResidentPermitDateIssuedzz (
=zz) *
Convertzz+ 2
.zz2 3

ToDateTimezz3 =
(zz= >
$strzz> J
)zzJ K
,zzK L$
ResidentPermitExpiryDate{{ (
={{) *
Convert{{+ 2
.{{2 3

ToDateTime{{3 =
({{= >
$str{{> J
){{J K
,{{K L
SocialMediaTypeId|| !
=||" #
socialMediaTypeId||$ 5
,||5 6
SocialMediaAccount}} "
=}}# $
socialMediaAccount}}% 7
,}}7 8 
IdentificationTypeId~~ $
=~~% &
$num~~' (
,~~( )$
IdentificationTypeNumber (
=) *&
businessRegistrationNumber+ E
,E F(
IdentificationTypeImageOne
ÄÄ *
=
ÄÄ+ ,(
identificationTypeImageOne
ÄÄ- G
,
ÄÄG H(
IdentificationTypeImageTwo
ÅÅ *
=
ÅÅ+ ,(
identificationTypeImageTwo
ÅÅ- G
,
ÅÅG H*
IdentificationTypeImageThree
ÇÇ ,
=
ÇÇ- .*
identificationTypeImageThree
ÇÇ/ K
,
ÇÇK L)
IdentificationTypeImageFour
ÉÉ +
=
ÉÉ, -)
identificationTypeImageFour
ÉÉ. I
,
ÉÉI J)
IdentificationTypeImageFive
ÑÑ +
=
ÑÑ, -)
identificationTypeImageFive
ÑÑ. I
,
ÑÑI J
Comments
ÖÖ 
=
ÖÖ 
comments
ÖÖ #
,
ÖÖ# $
InterestExpressed
ÜÜ !
=
ÜÜ" #
string
ÜÜ$ *
.
ÜÜ* +
Empty
ÜÜ+ 0
,
ÜÜ0 1
DebtorStatus
áá 
=
áá 
$num
áá  
,
áá  !

ParentCode
àà 
=
àà 
string
àà #
.
àà# $
Empty
àà$ )
,
àà) *$
ContactPerson_FullName
ââ &
=
ââ' ($
contactPerson_FullName
ââ) ?
,
ââ? @'
ContactPerson_PhoneNumber
ää )
=
ää* +'
contactPerson_PhoneNumber
ää, E
,
ääE F(
ContactPerson_EmailAddress
ãã *
=
ãã+ ,(
contactPerson_EmailAddress
ãã- G
,
ããG H#
ContactPerson_Address
åå %
=
åå& '#
contactPerson_Address
åå( =
,
åå= >0
"ContactPerson_IdentificationTypeId
çç 2
=
çç3 40
"contactPerson_IdentificationTypeId
çç5 W
,
ççW X4
&ContactPerson_IdentificationTypeNumber
éé 6
=
éé7 84
&contactPerson_IdentificationTypeNumber
éé9 _
,
éé_ `6
(ContactPerson_IdentificationTypeImageOne
èè 8
=
èè9 :6
(contactPerson_IdentificationTypeImageOne
èè; c
,
èèc d6
(ContactPerson_IdentificationTypeImageTwo
êê 8
=
êê9 :6
(contactPerson_IdentificationTypeImageTwo
êê; c
,
êêc d
	IsDeleted
ëë 
=
ëë 
false
ëë !
,
ëë! "
	IsPrimary
íí 
=
íí 
true
íí  
,
íí  !
MaritalStatus
ìì 
=
ìì 
string
ìì  &
.
ìì& '
Empty
ìì' ,
,
ìì, -
DateOfMarriage
îî 
=
îî  
Convert
îî! (
.
îî( )

ToDateTime
îî) 3
(
îî3 4
$str
îî4 @
)
îî@ A
}
ïï 
;
ïï 
}
òò 	
public
úú 
static
úú 
async
úú 
Task
úú  
<
úú  !
CustomerMaster
úú! /
>
úú/ 0#
UpdateIndividualAsync
úú1 F
(
úúF G
int
úúG J
customerMasterId
úúK [
,
úú[ \
int
úú] `
customerTypeId
úúa o
,
úúo p
int
úúq t
residentTypeIdúúu É
,úúÉ Ñ
intúúÖ à

localityIdúúâ ì
,úúì î
stringúúï õ
customerCodeúúú ®
,úú® ©
intúú™ ≠
titleIdúúÆ µ
,úúµ ∂
stringúú∑ Ω
surNameúúæ ≈
,úú≈ ∆
stringúú« Õ

otherNamesúúŒ ÿ
,úúÿ Ÿ
DateTimeúú⁄ ‚
dateOfBirthúú„ Ó
,úúÓ Ô
stringúú ˆ
	tinNumberúú˜ Ä
,úúÄ Å
stringúúÇ à
pictureúúâ ê
,úúê ë
intúúí ï
genderIdúúñ û
,úúû ü
int
ùùG J
nationalityId
ùùK X
,
ùùX Y
string
ùùZ `
postalAddress
ùùa n
,
ùùn o
string
ùùp v!
residentialAddressùùw â
,ùùâ ä
stringùùã ë
digitalAddressùùí †
,ùù† °
stringùù¢ ®#
primaryMobileNumberùù© º
,ùùº Ω
stringùùæ ƒ%
secondaryMobileNumberùù≈ ⁄
,ùù⁄ €
stringùù‹ ‚
officeNumberùù„ Ô
,ùùÔ 
stringùùÒ ˜
whatsAppNumberùù¯ Ü
,ùùÜ á
stringùùà é
emailAddressùùè õ
,ùùõ ú
string
ûûG M"
residentPermitNumber
ûûN b
,
ûûb c
DateTime
ûûd l
?
ûûl m'
residentPermitDateIssuedûûn Ü
,ûûÜ á
DateTimeûûà ê
?ûûê ë(
residentPermitExpiryDateûûí ™
,ûû™ ´
intûû¨ Ø!
socialMediaTypeIdûû∞ ¡
,ûû¡ ¬
stringûû√ …"
socialMediaAccountûû  ‹
,ûû‹ ›
intûûﬁ ·$
identificationTypeIdûû‚ ˆ
,ûûˆ ˜
stringûû¯ ˛(
identificationTypeNumberûûˇ ó
,ûûó ò
string
üüG M(
identificationTypeImageOne
üüN h
,
üüh i
string
üüj p)
identificationTypeImageTwoüüq ã
,üüã å
stringüüç ì,
identificationTypeImageThreeüüî ∞
,üü∞ ±
stringüü≤ ∏+
identificationTypeImageFourüüπ ‘
,üü‘ ’
stringüü÷ ‹+
identificationTypeImageFiveüü› ¯
,üü¯ ˘
stringüü˙ Ä
commentsüüÅ â
,üüâ ä
stringüüã ë!
interestExpressedüüí £
,üü£ §
intüü• ®
debtorStatusüü© µ
,üüµ ∂
stringüü∑ Ω

parentCodeüüæ »
,üü» …
stringüü  –&
contactPerson_FullNameüü— Á
,üüÁ Ë
stringüüÈ Ô)
contactPerson_PhoneNumberüü â
,üüâ ä
string
††G M(
contactPerson_EmailAddress
††N h
,
††h i
string
††j p$
contactPerson_Address††q Ü
,††Ü á
int††à ã2
"contactPerson_IdentificationTypeId††å Æ
,††Æ Ø
string††∞ ∂6
&contactPerson_IdentificationTypeNumber††∑ ›
,††› ﬁ
string††ﬂ Â8
(contactPerson_IdentificationTypeImageOne††Ê é
,††é è
string††ê ñ8
(contactPerson_IdentificationTypeImageTwo††ó ø
,††ø ¿&
ICustomerDomainService††¡ ◊%
customerDomainService††ÿ Ì
)††Ì Ó
{
°° 	
if
¢¢ 
(
¢¢ 
!
¢¢ 
await
¢¢ #
customerDomainService
¢¢ ,
.
¢¢, -
CustomerExists
¢¢- ;
(
¢¢; <
customerMasterId
¢¢< L
)
¢¢L M
)
¢¢M N
throw
££ 
new
££ 
ArgumentException
££ +
(
££+ ,
$str
££, F
)
££F G
;
££G H
if
•• 
(
•• 
customerTypeId
•• 
<=
•• !
$num
••" #
||
••$ &
residentTypeId
••' 5
<=
••6 8
$num
••9 :
||
••; =

localityId
••> H
<=
••I K
$num
••L M
||
••N P
nationalityId
••Q ^
<=
••_ a
$num
••b c
||
••d f"
identificationTypeId
••g {
<=
••| ~
$num•• Ä
||••Å É
string••Ñ ä
.••ä ã"
IsNullOrWhiteSpace••ã ù
(••ù û
surName••û •
)••• ¶
||••ß ©
string••™ ∞
.••∞ ±"
IsNullOrWhiteSpace••± √
(••√ ƒ

otherNames••ƒ Œ
)••Œ œ
||••– “
string••” Ÿ
.••Ÿ ⁄"
IsNullOrWhiteSpace••⁄ Ï
(••Ï Ì(
identificationTypeNumber••Ì Ö
)••Ö Ü
||••á â
string••ä ê
.••ê ë"
IsNullOrWhiteSpace••ë £
(••£ §#
primaryMobileNumber••§ ∑
)••∑ ∏
||••π ª
string••º ¬
.••¬ √"
IsNullOrWhiteSpace••√ ’
(••’ ÷
emailAddress••÷ ‚
)••‚ „
)••„ ‰
{
¶¶ 
throw
ßß 
new
ßß 
ArgumentException
ßß +
(
ßß+ ,
$str
ßß, \
)
ßß\ ]
;
ßß] ^
}
®® 
if
™™ 
(
™™ 
!
™™ 
await
™™ #
customerDomainService
™™ ,
.
™™, - 
CustomerTypeExists
™™- ?
(
™™? @
customerTypeId
™™@ N
)
™™N O
)
™™O P
throw
´´ 
new
´´ 
ArgumentException
´´ +
(
´´+ ,
$str
´´, G
)
´´G H
;
´´H I
if
≠≠ 
(
≠≠ 
!
≠≠ 
await
≠≠ #
customerDomainService
≠≠ ,
.
≠≠, - 
ResidentTypeExists
≠≠- ?
(
≠≠? @
residentTypeId
≠≠@ N
)
≠≠N O
)
≠≠O P
throw
ÆÆ 
new
ÆÆ 
ArgumentException
ÆÆ +
(
ÆÆ+ ,
$str
ÆÆ, G
)
ÆÆG H
;
ÆÆH I
if
∞∞ 
(
∞∞ 
!
∞∞ 
await
∞∞ #
customerDomainService
∞∞ ,
.
∞∞, -
LocalityExists
∞∞- ;
(
∞∞; <

localityId
∞∞< F
)
∞∞F G
)
∞∞G H
throw
±± 
new
±± 
ArgumentException
±± +
(
±±+ ,
$str
±±, B
)
±±B C
;
±±C D
if
≥≥ 
(
≥≥ 
!
≥≥ 
await
≥≥ #
customerDomainService
≥≥ ,
.
≥≥, -
GenderExists
≥≥- 9
(
≥≥9 :
genderId
≥≥: B
)
≥≥B C
)
≥≥C D
throw
¥¥ 
new
¥¥ 
ArgumentException
¥¥ +
(
¥¥+ ,
$str
¥¥, @
)
¥¥@ A
;
¥¥A B
if
∂∂ 
(
∂∂ 
!
∂∂ 
await
∂∂ #
customerDomainService
∂∂ ,
.
∂∂, -
NationalityExists
∂∂- >
(
∂∂> ?
nationalityId
∂∂? L
)
∂∂L M
)
∂∂M N
throw
∑∑ 
new
∑∑ 
ArgumentException
∑∑ +
(
∑∑+ ,
$str
∑∑, E
)
∑∑E F
;
∑∑F G
if
ππ 
(
ππ 
!
ππ 
await
ππ #
customerDomainService
ππ ,
.
ππ, -&
IdentificationTypeExists
ππ- E
(
ππE F"
identificationTypeId
ππF Z
)
ππZ [
)
ππ[ \
throw
∫∫ 
new
∫∫ 
ArgumentException
∫∫ +
(
∫∫+ ,
$str
∫∫, M
)
∫∫M N
;
∫∫N O
if
ΩΩ 
(
ΩΩ 
(
ΩΩ 
int
ΩΩ 
)
ΩΩ 
ResidentTypeEnum
ΩΩ %
.
ΩΩ% &
NON_RESIDENT
ΩΩ& 2
==
ΩΩ3 5
residentTypeId
ΩΩ6 D
)
ΩΩD E
{
ææ 
if
øø 
(
øø 
string
øø 
.
øø  
IsNullOrWhiteSpace
øø -
(
øø- .$
contactPerson_FullName
øø. D
)
øøD E
)
øøE F
{
¿¿ 
throw
¡¡ 
new
¡¡ 
ArgumentException
¡¡ /
(
¡¡/ 0
$str
¡¡0 c
)
¡¡c d
;
¡¡d e
}
¬¬ 
if
ƒƒ 
(
ƒƒ 
string
ƒƒ 
.
ƒƒ  
IsNullOrWhiteSpace
ƒƒ -
(
ƒƒ- .'
contactPerson_PhoneNumber
ƒƒ. G
)
ƒƒG H
)
ƒƒH I
{
≈≈ 
throw
∆∆ 
new
∆∆ 
ArgumentException
∆∆ /
(
∆∆/ 0
$str
∆∆0 g
)
∆∆g h
;
∆∆h i
}
«« 
if
…… 
(
…… 
string
…… 
.
……  
IsNullOrWhiteSpace
…… -
(
……- .(
contactPerson_EmailAddress
……. H
)
……H I
)
……I J
{
   
throw
ÀÀ 
new
ÀÀ 
ArgumentException
ÀÀ /
(
ÀÀ/ 0
$str
ÀÀ0 h
)
ÀÀh i
;
ÀÀi j
}
ÃÃ 
if
ŒŒ 
(
ŒŒ 
string
ŒŒ 
.
ŒŒ  
IsNullOrWhiteSpace
ŒŒ -
(
ŒŒ- .#
contactPerson_Address
ŒŒ. C
)
ŒŒC D
)
ŒŒD E
{
œœ 
throw
–– 
new
–– 
ArgumentException
–– /
(
––/ 0
$str
––0 b
)
––b c
;
––c d
}
—— 
if
”” 
(
”” 0
"contactPerson_IdentificationTypeId
”” 6
<=
””7 9
$num
””: ;
)
””; <
{
‘‘ 
throw
’’ 
new
’’ 
ArgumentException
’’ /
(
’’/ 0
$str
’’0 r
)
’’r s
;
’’s t
}
÷÷ 
if
ÿÿ 
(
ÿÿ 
string
ÿÿ 
.
ÿÿ  
IsNullOrWhiteSpace
ÿÿ -
(
ÿÿ- .4
&contactPerson_IdentificationTypeNumber
ÿÿ. T
)
ÿÿT U
)
ÿÿU V
{
ŸŸ 
throw
⁄⁄ 
new
⁄⁄ 
ArgumentException
⁄⁄ /
(
⁄⁄/ 0
$str
⁄⁄0 s
)
⁄⁄s t
;
⁄⁄t u
}
€€ 
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
››- .6
(contactPerson_IdentificationTypeImageOne
››. V
)
››V W
)
››W X
{
ﬁﬁ 
throw
ﬂﬂ 
new
ﬂﬂ 
ArgumentException
ﬂﬂ /
(
ﬂﬂ/ 0
$str
ﬂﬂ0 r
)
ﬂﬂr s
;
ﬂﬂs t
}
‡‡ 
}
‚‚ 
if
ÂÂ 
(
ÂÂ 
(
ÂÂ 
int
ÂÂ 
)
ÂÂ 
ResidentTypeEnum
ÂÂ %
.
ÂÂ% &

EXPATRIATE
ÂÂ& 0
==
ÂÂ1 3
residentTypeId
ÂÂ4 B
)
ÂÂB C
{
ÊÊ 
if
ÁÁ 
(
ÁÁ 
string
ÁÁ 
.
ÁÁ  
IsNullOrWhiteSpace
ÁÁ -
(
ÁÁ- ."
residentPermitNumber
ÁÁ. B
)
ÁÁB C
)
ÁÁC D
{
ËË 
throw
ÈÈ 
new
ÈÈ 
ArgumentException
ÈÈ /
(
ÈÈ/ 0
$str
ÈÈ0 `
)
ÈÈ` a
;
ÈÈa b
}
ÍÍ 
if
ÏÏ 
(
ÏÏ &
residentPermitDateIssued
ÏÏ ,
==
ÏÏ- /
DateTime
ÏÏ0 8
.
ÏÏ8 9
MinValue
ÏÏ9 A
)
ÏÏA B
{
ÌÌ 
throw
ÓÓ 
new
ÓÓ 
ArgumentException
ÓÓ /
(
ÓÓ/ 0
$str
ÓÓ0 \
)
ÓÓ\ ]
;
ÓÓ] ^
}
ÔÔ 
if
ÒÒ 
(
ÒÒ &
residentPermitExpiryDate
ÒÒ ,
==
ÒÒ- /
DateTime
ÒÒ0 8
.
ÒÒ8 9
MinValue
ÒÒ9 A
)
ÒÒA B
{
ÚÚ 
throw
ÛÛ 
new
ÛÛ 
ArgumentException
ÛÛ /
(
ÛÛ/ 0
$str
ÛÛ0 \
)
ÛÛ\ ]
;
ÛÛ] ^
}
ÙÙ 
}
ˆˆ 
if
¯¯ 
(
¯¯ 
string
¯¯ 
.
¯¯  
IsNullOrWhiteSpace
¯¯ )
(
¯¯) *
customerCode
¯¯* 6
)
¯¯6 7
)
¯¯7 8
{
˘˘ 
throw
˙˙ 
new
˙˙ 
ArgumentException
˙˙ +
(
˙˙+ ,
$str
˙˙, U
)
˙˙U V
;
˙˙V W
}
˚˚ 
if
˝˝ 
(
˝˝ 
titleId
˝˝ 
>
˝˝ 
$num
˝˝ 
)
˝˝ 
{
˛˛ 
if
ˇˇ 
(
ˇˇ 
!
ˇˇ 
await
ˇˇ #
customerDomainService
ˇˇ 0
.
ˇˇ0 1
TitleExists
ˇˇ1 <
(
ˇˇ< =
titleId
ˇˇ= D
)
ˇˇD E
)
ˇˇE F
throw
ÄÄ 
new
ÄÄ 
ArgumentException
ÄÄ /
(
ÄÄ/ 0
$str
ÄÄ0 C
)
ÄÄC D
;
ÄÄD E
}
ÅÅ 
if
ÉÉ 
(
ÉÉ 
genderId
ÉÉ 
<=
ÉÉ 
$num
ÉÉ 
)
ÉÉ 
{
ÑÑ 
throw
ÖÖ 
new
ÖÖ 
ArgumentException
ÖÖ +
(
ÖÖ+ ,
$str
ÖÖ, R
)
ÖÖR S
;
ÖÖS T
}
ÜÜ 
if
àà 
(
àà 
nationalityId
àà 
<=
àà  
$num
àà! "
)
àà" #
{
ââ 
throw
ää 
new
ää 
ArgumentException
ää +
(
ää+ ,
$str
ää, W
)
ääW X
;
ääX Y
}
ãã 
if
çç 
(
çç 
socialMediaTypeId
çç !
>
çç" #
$num
çç$ %
)
çç% &
{
éé 
if
èè 
(
èè 
!
èè 
await
èè #
customerDomainService
èè 0
.
èè0 1
SocialMediaExists
èè1 B
(
èèB C
socialMediaTypeId
èèC T
)
èèT U
)
èèU V
throw
êê 
new
êê 
ArgumentException
êê /
(
êê/ 0
$str
êê0 O
)
êêO P
;
êêP Q
}
ëë 
if
ìì 
(
ìì "
identificationTypeId
ìì $
<=
ìì% '
$num
ìì( )
)
ìì) *
{
îî 
throw
ïï 
new
ïï 
ArgumentException
ïï +
(
ïï+ ,
$str
ïï, _
)
ïï_ `
;
ïï` a
}
ññ 
if
òò 
(
òò 
string
òò 
.
òò  
IsNullOrWhiteSpace
òò )
(
òò) *
surName
òò* 1
)
òò1 2
||
òò3 5
string
òò6 <
.
òò< = 
IsNullOrWhiteSpace
òò= O
(
òòO P

otherNames
òòP Z
)
òòZ [
)
òò[ \
{
ôô 
throw
öö 
new
öö 
ArgumentException
öö +
(
öö+ ,
$str
öö, \
)
öö\ ]
;
öö] ^
}
õõ 
if
ùù 
(
ùù 
dateOfBirth
ùù 
==
ùù 
DateTime
ùù '
.
ùù' (
MinValue
ùù( 0
)
ùù0 1
{
ûû 
throw
üü 
new
üü 
ArgumentException
üü +
(
üü+ ,
$str
üü, X
)
üüX Y
;
üüY Z
}
†† 
if
¢¢ 
(
¢¢ 
string
¢¢ 
.
¢¢  
IsNullOrWhiteSpace
¢¢ )
(
¢¢) *
postalAddress
¢¢* 7
)
¢¢7 8
)
¢¢8 9
{
££ 
throw
§§ 
new
§§ 
ArgumentException
§§ +
(
§§+ ,
$str
§§, V
)
§§V W
;
§§W X
}
•• 
if
ßß 
(
ßß 
string
ßß 
.
ßß  
IsNullOrWhiteSpace
ßß )
(
ßß) * 
residentialAddress
ßß* <
)
ßß< =
)
ßß= >
{
®® 
throw
©© 
new
©© 
ArgumentException
©© +
(
©©+ ,
$str
©©, [
)
©©[ \
;
©©\ ]
}
™™ 
if
¨¨ 
(
¨¨ 
string
¨¨ 
.
¨¨  
IsNullOrWhiteSpace
¨¨ )
(
¨¨) *!
primaryMobileNumber
¨¨* =
)
¨¨= >
)
¨¨> ?
{
≠≠ 
throw
ÆÆ 
new
ÆÆ 
ArgumentException
ÆÆ +
(
ÆÆ+ ,
$str
ÆÆ, ]
)
ÆÆ] ^
;
ÆÆ^ _
}
ØØ 
if
±± 
(
±± 
string
±± 
.
±±  
IsNullOrWhiteSpace
±± )
(
±±) *
emailAddress
±±* 6
)
±±6 7
)
±±7 8
{
≤≤ 
throw
≥≥ 
new
≥≥ 
ArgumentException
≥≥ +
(
≥≥+ ,
$str
≥≥, U
)
≥≥U V
;
≥≥V W
}
¥¥ 
var
∑∑ 
customer_locality
∑∑ !
=
∑∑" #
await
∑∑$ )#
customerDomainService
∑∑* ?
.
∑∑? @ 
GetLocalityDetails
∑∑@ R
(
∑∑R S

localityId
∑∑S ]
)
∑∑] ^
;
∑∑^ _
if
ππ 
(
ππ 
customer_locality
ππ !
is
ππ" $
null
ππ% )
)
ππ) *
{
∫∫ 
throw
ªª 
new
ªª 
ArgumentException
ªª +
(
ªª+ ,
$str
ªª, W
)
ªªW X
;
ªªX Y
}
ºº 
return
øø 
new
øø 
CustomerMaster
øø %
{
¿¿ 
CustomerMasterId
¡¡  
=
¡¡! "
customerMasterId
¡¡# 3
,
¡¡3 4
CustomerTypeId
¬¬ 
=
¬¬  
customerTypeId
¬¬! /
,
¬¬/ 0
ResidentTypeId
√√ 
=
√√  
residentTypeId
√√! /
,
√√/ 0

LocalityId
ƒƒ 
=
ƒƒ 

localityId
ƒƒ '
,
ƒƒ' (
CustomerCode
≈≈ 
=
≈≈ 
customerCode
≈≈ +
,
≈≈+ ,
TitleId
∆∆ 
=
∆∆ 
titleId
∆∆ !
,
∆∆! "
SurName
«« 
=
«« 
surName
«« !
,
««! "

OtherNames
»» 
=
»» 

otherNames
»» '
,
»»' (
CompanyName
…… 
=
…… 
string
…… $
.
……$ %
Empty
……% *
,
……* +
DateOfBirth
   
=
   
dateOfBirth
   )
,
  ) *
	TinNumber
ÀÀ 
=
ÀÀ 
	tinNumber
ÀÀ %
,
ÀÀ% &
Picture
ÃÃ 
=
ÃÃ 
picture
ÃÃ !
,
ÃÃ! "
GenderId
ÕÕ 
=
ÕÕ 
genderId
ÕÕ #
,
ÕÕ# $
NationalityId
ŒŒ 
=
ŒŒ 
nationalityId
ŒŒ  -
,
ŒŒ- .
PostalAddress
œœ 
=
œœ 
postalAddress
œœ  -
,
œœ- . 
ResidentialAddress
–– "
=
––# $ 
residentialAddress
––% 7
,
––7 8
DigitalAddress
—— 
=
——  
digitalAddress
——! /
,
——/ 0!
PrimaryMobileNumber
““ #
=
““$ %!
primaryMobileNumber
““& 9
,
““9 :#
SecondaryMobileNumber
”” %
=
””& '#
secondaryMobileNumber
””( =
,
””= >
OfficeNumber
‘‘ 
=
‘‘ 
officeNumber
‘‘ +
,
‘‘+ ,
WhatsAppNumber
’’ 
=
’’  
whatsAppNumber
’’! /
,
’’/ 0
EmailAddress
÷÷ 
=
÷÷ 
emailAddress
÷÷ +
,
÷÷+ ,"
ResidentPermitNumber
◊◊ $
=
◊◊% &"
residentPermitNumber
◊◊' ;
,
◊◊; <&
ResidentPermitDateIssued
ÿÿ (
=
ÿÿ) *&
residentPermitDateIssued
ÿÿ+ C
,
ÿÿC D&
ResidentPermitExpiryDate
ŸŸ (
=
ŸŸ) *&
residentPermitExpiryDate
ŸŸ+ C
,
ŸŸC D
SocialMediaTypeId
⁄⁄ !
=
⁄⁄" #
socialMediaTypeId
⁄⁄$ 5
,
⁄⁄5 6 
SocialMediaAccount
€€ "
=
€€# $ 
socialMediaAccount
€€% 7
,
€€7 8"
IdentificationTypeId
‹‹ $
=
‹‹% &"
identificationTypeId
‹‹' ;
,
‹‹; <&
IdentificationTypeNumber
›› (
=
››) *&
identificationTypeNumber
››+ C
,
››C D(
IdentificationTypeImageOne
ﬁﬁ *
=
ﬁﬁ+ ,(
identificationTypeImageOne
ﬁﬁ- G
,
ﬁﬁG H(
IdentificationTypeImageTwo
ﬂﬂ *
=
ﬂﬂ+ ,(
identificationTypeImageTwo
ﬂﬂ- G
,
ﬂﬂG H*
IdentificationTypeImageThree
‡‡ ,
=
‡‡- .*
identificationTypeImageThree
‡‡/ K
,
‡‡K L)
IdentificationTypeImageFour
·· +
=
··, -)
identificationTypeImageFour
··. I
,
··I J)
IdentificationTypeImageFive
‚‚ +
=
‚‚, -)
identificationTypeImageFive
‚‚. I
,
‚‚I J
Comments
„„ 
=
„„ 
comments
„„ #
,
„„# $
InterestExpressed
‰‰ !
=
‰‰" #
interestExpressed
‰‰$ 5
,
‰‰5 6
DebtorStatus
ÂÂ 
=
ÂÂ 
debtorStatus
ÂÂ +
,
ÂÂ+ ,

ParentCode
ÊÊ 
=
ÊÊ 

parentCode
ÊÊ '
,
ÊÊ' ($
ContactPerson_FullName
ÁÁ &
=
ÁÁ' ($
contactPerson_FullName
ÁÁ) ?
,
ÁÁ? @'
ContactPerson_PhoneNumber
ËË )
=
ËË* +'
contactPerson_PhoneNumber
ËË, E
,
ËËE F(
ContactPerson_EmailAddress
ÈÈ *
=
ÈÈ+ ,(
contactPerson_EmailAddress
ÈÈ- G
,
ÈÈG H#
ContactPerson_Address
ÍÍ %
=
ÍÍ& '#
contactPerson_Address
ÍÍ( =
,
ÍÍ= >0
"ContactPerson_IdentificationTypeId
ÎÎ 2
=
ÎÎ3 40
"contactPerson_IdentificationTypeId
ÎÎ5 W
,
ÎÎW X4
&ContactPerson_IdentificationTypeNumber
ÏÏ 6
=
ÏÏ7 84
&contactPerson_IdentificationTypeNumber
ÏÏ9 _
,
ÏÏ_ `6
(ContactPerson_IdentificationTypeImageOne
ÌÌ 8
=
ÌÌ9 :6
(contactPerson_IdentificationTypeImageOne
ÌÌ; c
,
ÌÌc d6
(ContactPerson_IdentificationTypeImageTwo
ÓÓ 8
=
ÓÓ9 :6
(contactPerson_IdentificationTypeImageTwo
ÓÓ; c
,
ÓÓc d
	IsDeleted
ÔÔ 
=
ÔÔ 
false
ÔÔ !
,
ÔÔ! "
	IsPrimary
 
=
 
true
  
,
  !
MaritalStatus
ÒÒ 
=
ÒÒ 
string
ÒÒ  &
.
ÒÒ& '
Empty
ÒÒ' ,
,
ÒÒ, -
DateOfMarriage
ÚÚ 
=
ÚÚ  
Convert
ÚÚ! (
.
ÚÚ( )

ToDateTime
ÚÚ) 3
(
ÚÚ3 4
$str
ÚÚ4 @
)
ÚÚ@ A
}
ÛÛ 
;
ÛÛ 
}
ÙÙ 	
public
˘˘ 
static
˘˘ 
async
˘˘ 
Task
˘˘  
<
˘˘  !
CustomerMaster
˘˘! /
>
˘˘/ 0
UpdateJointAsync
˘˘1 A
(
˘˘A B
int
˘˘B E
customerMasterId
˘˘F V
,
˘˘V W
int
˘˘X [
customerTypeId
˘˘\ j
,
˘˘j k
int
˘˘l o
residentTypeId
˘˘p ~
,
˘˘~ 
int˘˘Ä É

localityId˘˘Ñ é
,˘˘é è
string˘˘ê ñ
customerCode˘˘ó £
,˘˘£ §
int˘˘• ®
titleId˘˘© ∞
,˘˘∞ ±
string˘˘≤ ∏
surName˘˘π ¿
,˘˘¿ ¡
string˘˘¬ »

otherNames˘˘… ”
,˘˘” ‘
DateTime˘˘’ ›
dateOfBirth˘˘ﬁ È
,˘˘È Í
string˘˘Î Ò
	tinNumber˘˘Ú ˚
,˘˘˚ ¸
string˘˘˝ É
picture˘˘Ñ ã
,˘˘ã å
int˘˘ç ê
genderId˘˘ë ô
,˘˘ô ö
int
˙˙? B
nationalityId
˙˙C P
,
˙˙P Q
string
˙˙R X
postalAddress
˙˙Y f
,
˙˙f g
string
˙˙h n!
residentialAddress˙˙o Å
,˙˙Å Ç
string˙˙É â
digitalAddress˙˙ä ò
,˙˙ò ô
string˙˙ö †#
primaryMobileNumber˙˙° ¥
,˙˙¥ µ
string˙˙∂ º%
secondaryMobileNumber˙˙Ω “
,˙˙“ ”
string˙˙‘ ⁄
officeNumber˙˙€ Á
,˙˙Á Ë
string˙˙È Ô
whatsAppNumber˙˙ ˛
,˙˙˛ ˇ
string˙˙Ä Ü
emailAddress˙˙á ì
,˙˙ì î
string
˚˚? E"
residentPermitNumber
˚˚F Z
,
˚˚Z [
DateTime
˚˚\ d
?
˚˚d e&
residentPermitDateIssued
˚˚f ~
,
˚˚~ 
DateTime˚˚Ä à
?˚˚à â(
residentPermitExpiryDate˚˚ä ¢
,˚˚¢ £
int˚˚§ ß!
socialMediaTypeId˚˚® π
,˚˚π ∫
string˚˚ª ¡"
socialMediaAccount˚˚¬ ‘
,˚˚‘ ’
int˚˚÷ Ÿ$
identificationTypeId˚˚⁄ Ó
,˚˚Ó Ô
string˚˚ ˆ(
identificationTypeNumber˚˚˜ è
,˚˚è ê
string
¸¸? E(
identificationTypeImageOne
¸¸F `
,
¸¸` a
string
¸¸b h)
identificationTypeImageTwo¸¸i É
,¸¸É Ñ
string¸¸Ö ã,
identificationTypeImageThree¸¸å ®
,¸¸® ©
string¸¸™ ∞+
identificationTypeImageFour¸¸± Ã
,¸¸Ã Õ
string¸¸Œ ‘+
identificationTypeImageFive¸¸’ 
,¸¸ Ò
string¸¸Ú ¯
comments¸¸˘ Å
,¸¸Å Ç
string¸¸É â!
interestExpressed¸¸ä õ
,¸¸õ ú
int¸¸ù †
debtorStatus¸¸° ≠
,¸¸≠ Æ
string¸¸Ø µ

parentCode¸¸∂ ¿
,¸¸¿ ¡
string¸¸¬ »&
contactPerson_FullName¸¸… ﬂ
,¸¸ﬂ ‡
string¸¸· Á)
contactPerson_PhoneNumber¸¸Ë Å
,¸¸Å Ç
string
˝˝? E(
contactPerson_EmailAddress
˝˝F `
,
˝˝` a
string
˝˝b h#
contactPerson_Address
˝˝i ~
,
˝˝~ 
int˝˝Ä É2
"contactPerson_IdentificationTypeId˝˝Ñ ¶
,˝˝¶ ß
string˝˝® Æ6
&contactPerson_IdentificationTypeNumber˝˝Ø ’
,˝˝’ ÷
string˝˝◊ ›8
(contactPerson_IdentificationTypeImageOne˝˝ﬁ Ü
,˝˝Ü á
string
˛˛? E6
(contactPerson_IdentificationTypeImageTwo
˛˛F n
,
˛˛n o
string
˛˛p v
maritalStatus˛˛w Ñ
,˛˛Ñ Ö
DateTime˛˛Ü é
?˛˛é è
dateOfMarriage˛˛ê û
,˛˛û ü&
ICustomerDomainService˛˛† ∂%
customerDomainService˛˛∑ Ã
)˛˛Ã Õ
{
ˇˇ 	
if
ÄÄ 
(
ÄÄ 
!
ÄÄ 
await
ÄÄ #
customerDomainService
ÄÄ ,
.
ÄÄ, -
CustomerExists
ÄÄ- ;
(
ÄÄ; <
customerMasterId
ÄÄ< L
)
ÄÄL M
)
ÄÄM N
throw
ÅÅ 
new
ÅÅ 
ArgumentException
ÅÅ +
(
ÅÅ+ ,
$str
ÅÅ, F
)
ÅÅF G
;
ÅÅG H
if
ÉÉ 
(
ÉÉ 
customerTypeId
ÉÉ 
<=
ÉÉ !
$num
ÉÉ" #
||
ÉÉ$ &
residentTypeId
ÉÉ' 5
<=
ÉÉ6 8
$num
ÉÉ9 :
||
ÉÉ; =

localityId
ÉÉ> H
<=
ÉÉI K
$num
ÉÉL M
||
ÉÉN P
nationalityId
ÉÉQ ^
<=
ÉÉ_ a
$num
ÉÉb c
||
ÉÉd f"
identificationTypeId
ÉÉg {
<=
ÉÉ| ~
$numÉÉ Ä
||ÉÉÅ É
stringÉÉÑ ä
.ÉÉä ã"
IsNullOrWhiteSpaceÉÉã ù
(ÉÉù û
surNameÉÉû •
)ÉÉ• ¶
||ÉÉß ©
stringÉÉ™ ∞
.ÉÉ∞ ±"
IsNullOrWhiteSpaceÉÉ± √
(ÉÉ√ ƒ

otherNamesÉÉƒ Œ
)ÉÉŒ œ
||ÉÉ– “
stringÉÉ” Ÿ
.ÉÉŸ ⁄"
IsNullOrWhiteSpaceÉÉ⁄ Ï
(ÉÉÏ Ì(
identificationTypeNumberÉÉÌ Ö
)ÉÉÖ Ü
||ÉÉá â
stringÉÉä ê
.ÉÉê ë"
IsNullOrWhiteSpaceÉÉë £
(ÉÉ£ §#
primaryMobileNumberÉÉ§ ∑
)ÉÉ∑ ∏
||ÉÉπ ª
stringÉÉº ¬
.ÉÉ¬ √"
IsNullOrWhiteSpaceÉÉ√ ’
(ÉÉ’ ÷
emailAddressÉÉ÷ ‚
)ÉÉ‚ „
)ÉÉ„ ‰
{
ÑÑ 
throw
ÖÖ 
new
ÖÖ 
ArgumentException
ÖÖ +
(
ÖÖ+ ,
$str
ÖÖ, Q
)
ÖÖQ R
;
ÖÖR S
}
ÜÜ 
if
àà 
(
àà 
!
àà 
await
àà #
customerDomainService
àà ,
.
àà, - 
CustomerTypeExists
àà- ?
(
àà? @
customerTypeId
àà@ N
)
ààN O
)
ààO P
throw
ââ 
new
ââ 
ArgumentException
ââ +
(
ââ+ ,
$str
ââ, G
)
ââG H
;
ââH I
if
ãã 
(
ãã 
!
ãã 
await
ãã #
customerDomainService
ãã ,
.
ãã, - 
ResidentTypeExists
ãã- ?
(
ãã? @
residentTypeId
ãã@ N
)
ããN O
)
ããO P
throw
åå 
new
åå 
ArgumentException
åå +
(
åå+ ,
$str
åå, G
)
ååG H
;
ååH I
if
éé 
(
éé 
!
éé 
await
éé #
customerDomainService
éé ,
.
éé, -
LocalityExists
éé- ;
(
éé; <

localityId
éé< F
)
ééF G
)
ééG H
throw
èè 
new
èè 
ArgumentException
èè +
(
èè+ ,
$str
èè, B
)
èèB C
;
èèC D
if
ëë 
(
ëë 
!
ëë 
await
ëë #
customerDomainService
ëë ,
.
ëë, -
GenderExists
ëë- 9
(
ëë9 :
genderId
ëë: B
)
ëëB C
)
ëëC D
throw
íí 
new
íí 
ArgumentException
íí +
(
íí+ ,
$str
íí, @
)
íí@ A
;
ííA B
if
îî 
(
îî 
!
îî 
await
îî #
customerDomainService
îî ,
.
îî, -
NationalityExists
îî- >
(
îî> ?
nationalityId
îî? L
)
îîL M
)
îîM N
throw
ïï 
new
ïï 
ArgumentException
ïï +
(
ïï+ ,
$str
ïï, E
)
ïïE F
;
ïïF G
if
óó 
(
óó 
!
óó 
await
óó #
customerDomainService
óó ,
.
óó, -&
IdentificationTypeExists
óó- E
(
óóE F"
identificationTypeId
óóF Z
)
óóZ [
)
óó[ \
throw
òò 
new
òò 
ArgumentException
òò +
(
òò+ ,
$str
òò, M
)
òòM N
;
òòN O
if
õõ 
(
õõ 
(
õõ 
int
õõ 
)
õõ 
ResidentTypeEnum
õõ %
.
õõ% &
NON_RESIDENT
õõ& 2
==
õõ3 5
residentTypeId
õõ6 D
)
õõD E
{
úú 
if
ùù 
(
ùù 
string
ùù 
.
ùù  
IsNullOrWhiteSpace
ùù -
(
ùù- .$
contactPerson_FullName
ùù. D
)
ùùD E
)
ùùE F
{
ûû 
throw
üü 
new
üü 
ArgumentException
üü /
(
üü/ 0
$str
üü0 c
)
üüc d
;
üüd e
}
†† 
if
¢¢ 
(
¢¢ 
string
¢¢ 
.
¢¢  
IsNullOrWhiteSpace
¢¢ -
(
¢¢- .'
contactPerson_PhoneNumber
¢¢. G
)
¢¢G H
)
¢¢H I
{
££ 
throw
§§ 
new
§§ 
ArgumentException
§§ /
(
§§/ 0
$str
§§0 e
)
§§e f
;
§§f g
}
•• 
if
ßß 
(
ßß 
string
ßß 
.
ßß  
IsNullOrWhiteSpace
ßß -
(
ßß- .(
contactPerson_EmailAddress
ßß. H
)
ßßH I
)
ßßI J
{
®® 
throw
©© 
new
©© 
ArgumentException
©© /
(
©©/ 0
$str
©©0 f
)
©©f g
;
©©g h
}
™™ 
if
¨¨ 
(
¨¨ 
string
¨¨ 
.
¨¨  
IsNullOrWhiteSpace
¨¨ -
(
¨¨- .#
contactPerson_Address
¨¨. C
)
¨¨C D
)
¨¨D E
{
≠≠ 
throw
ÆÆ 
new
ÆÆ 
ArgumentException
ÆÆ /
(
ÆÆ/ 0
$str
ÆÆ0 `
)
ÆÆ` a
;
ÆÆa b
}
ØØ 
if
±± 
(
±± 0
"contactPerson_IdentificationTypeId
±± 6
<=
±±7 9
$num
±±: ;
)
±±; <
{
≤≤ 
throw
≥≥ 
new
≥≥ 
ArgumentException
≥≥ /
(
≥≥/ 0
$str
≥≥0 r
)
≥≥r s
;
≥≥s t
}
¥¥ 
if
∂∂ 
(
∂∂ 
string
∂∂ 
.
∂∂  
IsNullOrWhiteSpace
∂∂ -
(
∂∂- .4
&contactPerson_IdentificationTypeNumber
∂∂. T
)
∂∂T U
)
∂∂U V
{
∑∑ 
throw
∏∏ 
new
∏∏ 
ArgumentException
∏∏ /
(
∏∏/ 0
$str
∏∏0 s
)
∏∏s t
;
∏∏t u
}
ππ 
if
ºº 
(
ºº 
string
ºº 
.
ºº  
IsNullOrWhiteSpace
ºº -
(
ºº- .6
(contactPerson_IdentificationTypeImageOne
ºº. V
)
ººV W
)
ººW X
{
ΩΩ 
throw
ææ 
new
ææ 
ArgumentException
ææ /
(
ææ/ 0
$str
ææ0 r
)
æær s
;
ææs t
}
øø 
}
¡¡ 
if
ƒƒ 
(
ƒƒ 
(
ƒƒ 
int
ƒƒ 
)
ƒƒ 
ResidentTypeEnum
ƒƒ %
.
ƒƒ% &

EXPATRIATE
ƒƒ& 0
==
ƒƒ1 3
residentTypeId
ƒƒ4 B
)
ƒƒB C
{
≈≈ 
if
∆∆ 
(
∆∆ 
string
∆∆ 
.
∆∆  
IsNullOrWhiteSpace
∆∆ -
(
∆∆- ."
residentPermitNumber
∆∆. B
)
∆∆B C
)
∆∆C D
{
«« 
throw
»» 
new
»» 
ArgumentException
»» /
(
»»/ 0
$str
»»0 `
)
»»` a
;
»»a b
}
…… 
if
ÀÀ 
(
ÀÀ &
residentPermitDateIssued
ÀÀ ,
==
ÀÀ- /
DateTime
ÀÀ0 8
.
ÀÀ8 9
MinValue
ÀÀ9 A
)
ÀÀA B
{
ÃÃ 
throw
ÕÕ 
new
ÕÕ 
ArgumentException
ÕÕ /
(
ÕÕ/ 0
$str
ÕÕ0 \
)
ÕÕ\ ]
;
ÕÕ] ^
}
ŒŒ 
if
–– 
(
–– &
residentPermitExpiryDate
–– ,
==
––- /
DateTime
––0 8
.
––8 9
MinValue
––9 A
)
––A B
{
—— 
throw
““ 
new
““ 
ArgumentException
““ /
(
““/ 0
$str
““0 \
)
““\ ]
;
““] ^
}
”” 
}
’’ 
if
◊◊ 
(
◊◊ 
string
◊◊ 
.
◊◊  
IsNullOrWhiteSpace
◊◊ )
(
◊◊) *
customerCode
◊◊* 6
)
◊◊6 7
)
◊◊7 8
{
ÿÿ 
throw
ŸŸ 
new
ŸŸ 
ArgumentException
ŸŸ +
(
ŸŸ+ ,
$str
ŸŸ, U
)
ŸŸU V
;
ŸŸV W
}
⁄⁄ 
if
‹‹ 
(
‹‹ 
titleId
‹‹ 
>
‹‹ 
$num
‹‹ 
)
‹‹ 
{
›› 
if
ﬁﬁ 
(
ﬁﬁ 
!
ﬁﬁ 
await
ﬁﬁ #
customerDomainService
ﬁﬁ 0
.
ﬁﬁ0 1
TitleExists
ﬁﬁ1 <
(
ﬁﬁ< =
titleId
ﬁﬁ= D
)
ﬁﬁD E
)
ﬁﬁE F
throw
ﬂﬂ 
new
ﬂﬂ 
ArgumentException
ﬂﬂ /
(
ﬂﬂ/ 0
$str
ﬂﬂ0 C
)
ﬂﬂC D
;
ﬂﬂD E
}
‡‡ 
if
‚‚ 
(
‚‚ 
genderId
‚‚ 
<=
‚‚ 
$num
‚‚ 
)
‚‚ 
{
„„ 
throw
‰‰ 
new
‰‰ 
ArgumentException
‰‰ +
(
‰‰+ ,
$str
‰‰, R
)
‰‰R S
;
‰‰S T
}
ÂÂ 
if
ÁÁ 
(
ÁÁ 
nationalityId
ÁÁ 
<=
ÁÁ  
$num
ÁÁ! "
)
ÁÁ" #
{
ËË 
throw
ÈÈ 
new
ÈÈ 
ArgumentException
ÈÈ +
(
ÈÈ+ ,
$str
ÈÈ, W
)
ÈÈW X
;
ÈÈX Y
}
ÍÍ 
if
ÏÏ 
(
ÏÏ 
socialMediaTypeId
ÏÏ !
>
ÏÏ" #
$num
ÏÏ$ %
)
ÏÏ% &
{
ÌÌ 
if
ÓÓ 
(
ÓÓ 
!
ÓÓ 
await
ÓÓ #
customerDomainService
ÓÓ 0
.
ÓÓ0 1
SocialMediaExists
ÓÓ1 B
(
ÓÓB C
socialMediaTypeId
ÓÓC T
)
ÓÓT U
)
ÓÓU V
throw
ÔÔ 
new
ÔÔ 
ArgumentException
ÔÔ /
(
ÔÔ/ 0
$str
ÔÔ0 O
)
ÔÔO P
;
ÔÔP Q
}
 
if
ÚÚ 
(
ÚÚ "
identificationTypeId
ÚÚ $
<=
ÚÚ% '
$num
ÚÚ( )
)
ÚÚ) *
{
ÛÛ 
throw
ÙÙ 
new
ÙÙ 
ArgumentException
ÙÙ +
(
ÙÙ+ ,
$str
ÙÙ, _
)
ÙÙ_ `
;
ÙÙ` a
}
ıı 
if
˜˜ 
(
˜˜ 
string
˜˜ 
.
˜˜  
IsNullOrWhiteSpace
˜˜ )
(
˜˜) *
surName
˜˜* 1
)
˜˜1 2
||
˜˜3 5
string
˜˜6 <
.
˜˜< = 
IsNullOrWhiteSpace
˜˜= O
(
˜˜O P

otherNames
˜˜P Z
)
˜˜Z [
)
˜˜[ \
{
¯¯ 
throw
˘˘ 
new
˘˘ 
ArgumentException
˘˘ +
(
˘˘+ ,
$str
˘˘, \
)
˘˘\ ]
;
˘˘] ^
}
˙˙ 
if
¸¸ 
(
¸¸ 
dateOfBirth
¸¸ 
==
¸¸ 
DateTime
¸¸ '
.
¸¸' (
MinValue
¸¸( 0
)
¸¸0 1
{
˝˝ 
throw
˛˛ 
new
˛˛ 
ArgumentException
˛˛ +
(
˛˛+ ,
$str
˛˛, X
)
˛˛X Y
;
˛˛Y Z
}
ˇˇ 
if
ÅÅ 
(
ÅÅ 
string
ÅÅ 
.
ÅÅ  
IsNullOrWhiteSpace
ÅÅ )
(
ÅÅ) *
postalAddress
ÅÅ* 7
)
ÅÅ7 8
)
ÅÅ8 9
{
ÇÇ 
throw
ÉÉ 
new
ÉÉ 
ArgumentException
ÉÉ +
(
ÉÉ+ ,
$str
ÉÉ, V
)
ÉÉV W
;
ÉÉW X
}
ÑÑ 
if
ÜÜ 
(
ÜÜ 
string
ÜÜ 
.
ÜÜ  
IsNullOrWhiteSpace
ÜÜ )
(
ÜÜ) * 
residentialAddress
ÜÜ* <
)
ÜÜ< =
)
ÜÜ= >
{
áá 
throw
àà 
new
àà 
ArgumentException
àà +
(
àà+ ,
$str
àà, [
)
àà[ \
;
àà\ ]
}
ââ 
if
ãã 
(
ãã 
string
ãã 
.
ãã  
IsNullOrWhiteSpace
ãã )
(
ãã) *!
primaryMobileNumber
ãã* =
)
ãã= >
)
ãã> ?
{
åå 
throw
çç 
new
çç 
ArgumentException
çç +
(
çç+ ,
$str
çç, ]
)
çç] ^
;
çç^ _
}
éé 
if
êê 
(
êê 
string
êê 
.
êê  
IsNullOrWhiteSpace
êê )
(
êê) *
emailAddress
êê* 6
)
êê6 7
)
êê7 8
{
ëë 
throw
íí 
new
íí 
ArgumentException
íí +
(
íí+ ,
$str
íí, U
)
ííU V
;
ííV W
}
ìì 
var
ññ 
customer_locality
ññ !
=
ññ" #
await
ññ$ )#
customerDomainService
ññ* ?
.
ññ? @ 
GetLocalityDetails
ññ@ R
(
ññR S

localityId
ññS ]
)
ññ] ^
;
ññ^ _
if
òò 
(
òò 
customer_locality
òò !
is
òò" $
null
òò% )
)
òò) *
{
ôô 
throw
öö 
new
öö 
ArgumentException
öö +
(
öö+ ,
$str
öö, W
)
ööW X
;
ööX Y
}
õõ 
return
ùù 
new
ùù 
CustomerMaster
ùù %
{
ûû 
CustomerMasterId
üü  
=
üü! "
customerMasterId
üü# 3
,
üü3 4
CustomerTypeId
†† 
=
††  
customerTypeId
††! /
,
††/ 0
ResidentTypeId
°° 
=
°°  
residentTypeId
°°! /
,
°°/ 0

LocalityId
¢¢ 
=
¢¢ 

localityId
¢¢ '
,
¢¢' (
CustomerCode
££ 
=
££ 
customerCode
££ +
,
££+ ,
TitleId
§§ 
=
§§ 
titleId
§§ !
,
§§! "
SurName
•• 
=
•• 
surName
•• !
,
••! "

OtherNames
¶¶ 
=
¶¶ 

otherNames
¶¶ '
,
¶¶' (
CompanyName
ßß 
=
ßß 
string
ßß $
.
ßß$ %
Empty
ßß% *
,
ßß* +
DateOfBirth
®® 
=
®® 
dateOfBirth
®® )
,
®®) *
	TinNumber
©© 
=
©© 
	tinNumber
©© %
,
©©% &
Picture
™™ 
=
™™ 
picture
™™ !
,
™™! "
GenderId
´´ 
=
´´ 
genderId
´´ #
,
´´# $
NationalityId
¨¨ 
=
¨¨ 
nationalityId
¨¨  -
,
¨¨- .
PostalAddress
≠≠ 
=
≠≠ 
postalAddress
≠≠  -
,
≠≠- . 
ResidentialAddress
ÆÆ "
=
ÆÆ# $ 
residentialAddress
ÆÆ% 7
,
ÆÆ7 8
DigitalAddress
ØØ 
=
ØØ  
digitalAddress
ØØ! /
,
ØØ/ 0!
PrimaryMobileNumber
∞∞ #
=
∞∞$ %!
primaryMobileNumber
∞∞& 9
,
∞∞9 :#
SecondaryMobileNumber
±± %
=
±±& '#
secondaryMobileNumber
±±( =
,
±±= >
OfficeNumber
≤≤ 
=
≤≤ 
officeNumber
≤≤ +
,
≤≤+ ,
WhatsAppNumber
≥≥ 
=
≥≥  
whatsAppNumber
≥≥! /
,
≥≥/ 0
EmailAddress
¥¥ 
=
¥¥ 
emailAddress
¥¥ +
,
¥¥+ ,"
ResidentPermitNumber
µµ $
=
µµ% &"
residentPermitNumber
µµ' ;
,
µµ; <&
ResidentPermitDateIssued
∂∂ (
=
∂∂) *&
residentPermitDateIssued
∂∂+ C
,
∂∂C D&
ResidentPermitExpiryDate
∑∑ (
=
∑∑) *&
residentPermitExpiryDate
∑∑+ C
,
∑∑C D
SocialMediaTypeId
∏∏ !
=
∏∏" #
socialMediaTypeId
∏∏$ 5
,
∏∏5 6 
SocialMediaAccount
ππ "
=
ππ# $ 
socialMediaAccount
ππ% 7
,
ππ7 8"
IdentificationTypeId
∫∫ $
=
∫∫% &"
identificationTypeId
∫∫' ;
,
∫∫; <&
IdentificationTypeNumber
ªª (
=
ªª) *&
identificationTypeNumber
ªª+ C
,
ªªC D(
IdentificationTypeImageOne
ºº *
=
ºº+ ,(
identificationTypeImageOne
ºº- G
,
ººG H(
IdentificationTypeImageTwo
ΩΩ *
=
ΩΩ+ ,(
identificationTypeImageTwo
ΩΩ- G
,
ΩΩG H*
IdentificationTypeImageThree
ææ ,
=
ææ- .*
identificationTypeImageThree
ææ/ K
,
ææK L)
IdentificationTypeImageFour
øø +
=
øø, -)
identificationTypeImageFour
øø. I
,
øøI J)
IdentificationTypeImageFive
¿¿ +
=
¿¿, -)
identificationTypeImageFive
¿¿. I
,
¿¿I J
Comments
¡¡ 
=
¡¡ 
comments
¡¡ #
,
¡¡# $
InterestExpressed
¬¬ !
=
¬¬" #
interestExpressed
¬¬$ 5
,
¬¬5 6
DebtorStatus
√√ 
=
√√ 
debtorStatus
√√ +
,
√√+ ,

ParentCode
ƒƒ 
=
ƒƒ 

parentCode
ƒƒ '
,
ƒƒ' ($
ContactPerson_FullName
≈≈ &
=
≈≈' ($
contactPerson_FullName
≈≈) ?
,
≈≈? @'
ContactPerson_PhoneNumber
∆∆ )
=
∆∆* +'
contactPerson_PhoneNumber
∆∆, E
,
∆∆E F(
ContactPerson_EmailAddress
«« *
=
««+ ,(
contactPerson_EmailAddress
««- G
,
««G H#
ContactPerson_Address
»» %
=
»»& '#
contactPerson_Address
»»( =
,
»»= >0
"ContactPerson_IdentificationTypeId
…… 2
=
……3 40
"contactPerson_IdentificationTypeId
……5 W
,
……W X4
&ContactPerson_IdentificationTypeNumber
   6
=
  7 84
&contactPerson_IdentificationTypeNumber
  9 _
,
  _ `6
(ContactPerson_IdentificationTypeImageOne
ÀÀ 8
=
ÀÀ9 :6
(contactPerson_IdentificationTypeImageOne
ÀÀ; c
,
ÀÀc d6
(ContactPerson_IdentificationTypeImageTwo
ÃÃ 8
=
ÃÃ9 :6
(contactPerson_IdentificationTypeImageTwo
ÃÃ; c
,
ÃÃc d
	IsDeleted
ÕÕ 
=
ÕÕ 
false
ÕÕ !
,
ÕÕ! "
	IsPrimary
ŒŒ 
=
ŒŒ 
true
ŒŒ  
,
ŒŒ  !
MaritalStatus
œœ 
=
œœ 
maritalStatus
œœ  -
,
œœ- .
DateOfMarriage
–– 
=
––  
dateOfMarriage
––! /
}
—— 
;
—— 
}
““ 	
public
‘‘ 
void
‘‘ &
UpdateContactInformation
‘‘ ,
(
‘‘, -
string
’’ 
postalAddress
’’  
,
’’  !
string
÷÷  
residentialAddress
÷÷ %
,
÷÷% &
string
◊◊ 
digitalAddress
◊◊ !
,
◊◊! "
string
ÿÿ !
primaryMobileNumber
ÿÿ &
,
ÿÿ& '
string
ŸŸ #
secondaryMobileNumber
ŸŸ (
,
ŸŸ( )
string
⁄⁄ 
officeNumber
⁄⁄ 
,
⁄⁄  
string
€€ 
whatsAppNumber
€€ !
,
€€! "
string
‹‹ 
emailAddress
‹‹ 
,
‹‹  
string
›› 
	updatedBy
›› 
)
›› 
{
ﬁﬁ 	
PostalAddress
ﬂﬂ 
=
ﬂﬂ 
postalAddress
ﬂﬂ )
;
ﬂﬂ) * 
ResidentialAddress
‡‡ 
=
‡‡   
residentialAddress
‡‡! 3
;
‡‡3 4
DigitalAddress
·· 
=
·· 
digitalAddress
·· +
;
··+ ,!
PrimaryMobileNumber
‚‚ 
=
‚‚  !!
primaryMobileNumber
‚‚" 5
;
‚‚5 6#
SecondaryMobileNumber
„„ !
=
„„" ##
secondaryMobileNumber
„„$ 9
;
„„9 :
OfficeNumber
‰‰ 
=
‰‰ 
officeNumber
‰‰ '
;
‰‰' (
WhatsAppNumber
ÂÂ 
=
ÂÂ 
whatsAppNumber
ÂÂ +
;
ÂÂ+ ,
EmailAddress
ÊÊ 
=
ÊÊ 
emailAddress
ÊÊ '
;
ÊÊ' (

ModifiedOn
ÁÁ 
=
ÁÁ 
DateTime
ÁÁ !
.
ÁÁ! "
UtcNow
ÁÁ" (
;
ÁÁ( )
_domainEvents
ÈÈ 
.
ÈÈ 
Add
ÈÈ 
(
ÈÈ 
new
ÈÈ !"
CustomerUpdatedEvent
ÈÈ" 6
(
ÈÈ6 7
CustomerMasterId
ÍÍ  
,
ÍÍ  !
CustomerCode
ÎÎ 
!
ÎÎ 
,
ÎÎ 
	updatedBy
ÏÏ 
,
ÏÏ 
$str
ÌÌ $
)
ÌÌ$ %
)
ÌÌ% &
;
ÌÌ& '
}
ÓÓ 	
public
 
void
 
UpdateStatus
  
(
  !
int
! $
	newStatus
% .
,
. /
string
0 6
	changedBy
7 @
)
@ A
{
ÒÒ 	
var
ÚÚ 
	oldStatus
ÚÚ 
=
ÚÚ 
DebtorStatus
ÚÚ (
;
ÚÚ( )
DebtorStatus
ÛÛ 
=
ÛÛ 
	newStatus
ÛÛ $
;
ÛÛ$ %

ModifiedOn
ÙÙ 
=
ÙÙ 
DateTime
ÙÙ !
.
ÙÙ! "
UtcNow
ÙÙ" (
;
ÙÙ( )
_domainEvents
ˆˆ 
.
ˆˆ 
Add
ˆˆ 
(
ˆˆ 
new
ˆˆ !(
CustomerStatusChangedEvent
ˆˆ" <
(
ˆˆ< =
CustomerMasterId
˜˜  
,
˜˜  !
CustomerCode
¯¯ 
,
¯¯ 
	oldStatus
˘˘ 
.
˘˘ 
ToString
˘˘ "
(
˘˘" #
)
˘˘# $
,
˘˘$ %
	newStatus
˙˙ 
.
˙˙ 
ToString
˙˙ "
(
˙˙" #
)
˙˙# $
,
˙˙$ %
	changedBy
˚˚ 
)
˚˚ 
)
˚˚ 
;
˚˚ 
}
¸¸ 	
}
ˇˇ 
}ÄÄ ù¸
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/CustomerMaster.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *
Registration* 6
{ 
public 

partial 
class 
CustomerMaster '
:( )

BaseEntity* 4
{ 
private		 
readonly		 
List		 
<		 
DomainEvent		 )
>		) *
_domainEvents		+ 8
=		9 :
new		; >
(		> ?
)		? @
;		@ A
[ 	
	NotMapped	 
] 
public 
IReadOnlyCollection "
<" #
DomainEvent# .
>. /
DomainEvents0 <
=>= ?
_domainEvents@ M
.M N

AsReadOnlyN X
(X Y
)Y Z
;Z [
[ 	
Key	 
] 
public 
int 
CustomerMasterId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
public 
int 
CustomerTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
int 
ResidentTypeId !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
public 
int 

LocalityId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
CustomerCode #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
TitleId 
{ 
get  
;  !
set" %
;% &
}' (
[   	
StringLength  	 
(   
$num   
)   
]   
public!! 
string!! 
?!! 
SurName!! 
{!!  
get!!! $
;!!$ %
set!!& )
;!!) *
}!!+ ,
[## 	
StringLength##	 
(## 
$num## 
)## 
]## 
public$$ 
string$$ 
?$$ 

OtherNames$$ !
{$$" #
get$$$ '
;$$' (
set$$) ,
;$$, -
}$$. /
[&& 	
StringLength&&	 
(&& 
$num&& 
)&& 
]&& 
public'' 
string'' 
?'' 
CompanyName'' "
{''# $
get''% (
;''( )
set''* -
;''- .
}''/ 0
public)) 
DateTime)) 
DateOfBirth)) #
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
?,, 
	TinNumber,,  
{,,! "
get,,# &
;,,& '
set,,( +
;,,+ ,
},,- .
[.. 	
StringLength..	 
(.. 
$num.. 
).. 
].. 
public// 
string// 
?// 
Picture// 
{//  
get//! $
;//$ %
set//& )
;//) *
}//+ ,
public11 
int11 
GenderId11 
{11 
get11 !
;11! "
set11# &
;11& '
}11( )
public33 
int33 
NationalityId33  
{33! "
get33# &
;33& '
set33( +
;33+ ,
}33- .
[55 	
StringLength55	 
(55 
$num55 
)55 
]55 
public66 
string66 
?66 
PostalAddress66 $
{66% &
get66' *
;66* +
set66, /
;66/ 0
}661 2
[88 	
StringLength88	 
(88 
$num88 
)88 
]88 
public99 
string99 
?99 
ResidentialAddress99 )
{99* +
get99, /
;99/ 0
set991 4
;994 5
}996 7
[;; 	
StringLength;;	 
(;; 
$num;; 
);; 
];; 
public<< 
string<< 
?<< 
DigitalAddress<< %
{<<& '
get<<( +
;<<+ ,
set<<- 0
;<<0 1
}<<2 3
[>> 	
Required>>	 
]>> 
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
public@@ 
string@@ 
?@@ 
PrimaryMobileNumber@@ *
{@@+ ,
get@@- 0
;@@0 1
set@@2 5
;@@5 6
}@@7 8
[BB 	
StringLengthBB	 
(BB 
$numBB 
)BB 
]BB 
publicCC 
stringCC 
?CC !
SecondaryMobileNumberCC ,
{CC- .
getCC/ 2
;CC2 3
setCC4 7
;CC7 8
}CC9 :
[EE 	
StringLengthEE	 
(EE 
$numEE 
)EE 
]EE 
publicFF 
stringFF 
?FF 
OfficeNumberFF #
{FF$ %
getFF& )
;FF) *
setFF+ .
;FF. /
}FF0 1
[HH 	
StringLengthHH	 
(HH 
$numHH 
)HH 
]HH 
publicII 
stringII 
?II 
WhatsAppNumberII %
{II& '
getII( +
;II+ ,
setII- 0
;II0 1
}II2 3
[KK 	
EmailAddressKK	 
]KK 
[LL 	
StringLengthLL	 
(LL 
$numLL 
)LL 
]LL 
publicMM 
stringMM 
?MM 
EmailAddressMM #
{MM$ %
getMM& )
;MM) *
setMM+ .
;MM. /
}MM0 1
[OO 	
StringLengthOO	 
(OO 
$numOO 
)OO 
]OO 
publicPP 
stringPP 
?PP  
ResidentPermitNumberPP +
{PP, -
getPP. 1
;PP1 2
setPP3 6
;PP6 7
}PP8 9
publicRR 
DateTimeRR 
?RR $
ResidentPermitDateIssuedRR 1
{RR2 3
getRR4 7
;RR7 8
setRR9 <
;RR< =
}RR> ?
publicTT 
DateTimeTT 
?TT $
ResidentPermitExpiryDateTT 1
{TT2 3
getTT4 7
;TT7 8
setTT9 <
;TT< =
}TT> ?
publicVV 
intVV 
SocialMediaTypeIdVV $
{VV% &
getVV' *
;VV* +
setVV, /
;VV/ 0
}VV1 2
[XX 	
StringLengthXX	 
(XX 
$numXX 
)XX 
]XX 
publicYY 
stringYY 
?YY 
SocialMediaAccountYY )
{YY* +
getYY, /
;YY/ 0
setYY1 4
;YY4 5
}YY6 7
public[[ 
int[[  
IdentificationTypeId[[ '
{[[( )
get[[* -
;[[- .
set[[/ 2
;[[2 3
}[[4 5
[]] 	
StringLength]]	 
(]] 
$num]] 
)]] 
]]] 
public^^ 
string^^ 
?^^ $
IdentificationTypeNumber^^ /
{^^0 1
get^^2 5
;^^5 6
set^^7 :
;^^: ;
}^^< =
[`` 	
StringLength``	 
(`` 
$num`` 
)`` 
]`` 
publicaa 
stringaa 
?aa &
IdentificationTypeImageOneaa 1
{aa2 3
getaa4 7
;aa7 8
setaa9 <
;aa< =
}aa> ?
[cc 	
StringLengthcc	 
(cc 
$numcc 
)cc 
]cc 
publicdd 
stringdd 
?dd &
IdentificationTypeImageTwodd 1
{dd2 3
getdd4 7
;dd7 8
setdd9 <
;dd< =
}dd> ?
[ff 	
StringLengthff	 
(ff 
$numff 
)ff 
]ff 
publicgg 
stringgg 
?gg (
IdentificationTypeImageThreegg 3
{gg4 5
getgg6 9
;gg9 :
setgg; >
;gg> ?
}gg@ A
[ii 	
StringLengthii	 
(ii 
$numii 
)ii 
]ii 
publicjj 
stringjj 
?jj '
IdentificationTypeImageFourjj 2
{jj3 4
getjj5 8
;jj8 9
setjj: =
;jj= >
}jj? @
[ll 	
StringLengthll	 
(ll 
$numll 
)ll 
]ll 
publicmm 
stringmm 
?mm '
IdentificationTypeImageFivemm 2
{mm3 4
getmm5 8
;mm8 9
setmm: =
;mm= >
}mm? @
[oo 	
StringLengthoo	 
(oo 
$numoo 
)oo 
]oo 
publicpp 
stringpp 
?pp 
Commentspp 
{pp  !
getpp" %
;pp% &
setpp' *
;pp* +
}pp, -
[rr 	
StringLengthrr	 
(rr 
$numrr 
)rr 
]rr 
publicss 
stringss 
?ss 
InterestExpressedss (
{ss) *
getss+ .
;ss. /
setss0 3
;ss3 4
}ss5 6
publicuu 
intuu 
DebtorStatusuu 
{uu  !
getuu" %
;uu% &
setuu' *
;uu* +
}uu, -
[ww 	
StringLengthww	 
(ww 
$numww 
)ww 
]ww 
publicxx 
stringxx 
?xx 

ParentCodexx !
{xx" #
getxx$ '
;xx' (
setxx) ,
;xx, -
}xx. /
[zz 	
StringLengthzz	 
(zz 
$numzz 
)zz 
]zz 
public{{ 
string{{ 
?{{ "
ContactPerson_FullName{{ -
{{{. /
get{{0 3
;{{3 4
set{{5 8
;{{8 9
}{{: ;
[}} 	
StringLength}}	 
(}} 
$num}} 
)}} 
]}} 
public~~ 
string~~ 
?~~ %
ContactPerson_PhoneNumber~~ 0
{~~1 2
get~~3 6
;~~6 7
set~~8 ;
;~~; <
}~~= >
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
ÄÄ 
[
ÅÅ 	
EmailAddress
ÅÅ	 
]
ÅÅ 
public
ÇÇ 
string
ÇÇ 
?
ÇÇ (
ContactPerson_EmailAddress
ÇÇ 1
{
ÇÇ2 3
get
ÇÇ4 7
;
ÇÇ7 8
set
ÇÇ9 <
;
ÇÇ< =
}
ÇÇ> ?
[
ÑÑ 	
StringLength
ÑÑ	 
(
ÑÑ 
$num
ÑÑ 
)
ÑÑ 
]
ÑÑ 
public
ÖÖ 
string
ÖÖ 
?
ÖÖ #
ContactPerson_Address
ÖÖ ,
{
ÖÖ- .
get
ÖÖ/ 2
;
ÖÖ2 3
set
ÖÖ4 7
;
ÖÖ7 8
}
ÖÖ9 :
public
áá 
int
áá 0
"ContactPerson_IdentificationTypeId
áá 5
{
áá6 7
get
áá8 ;
;
áá; <
set
áá= @
;
áá@ A
}
ááB C
[
ââ 	
StringLength
ââ	 
(
ââ 
$num
ââ 
)
ââ 
]
ââ 
public
ää 
string
ää 
?
ää 4
&ContactPerson_IdentificationTypeNumber
ää =
{
ää> ?
get
ää@ C
;
ääC D
set
ääE H
;
ääH I
}
ääJ K
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
çç 6
(ContactPerson_IdentificationTypeImageOne
çç ?
{
çç@ A
get
ççB E
;
ççE F
set
ççG J
;
ççJ K
}
ççL M
[
èè 	
StringLength
èè	 
(
èè 
$num
èè 
)
èè 
]
èè 
public
êê 
string
êê 
?
êê 6
(ContactPerson_IdentificationTypeImageTwo
êê ?
{
êê@ A
get
êêB E
;
êêE F
set
êêG J
;
êêJ K
}
êêL M
public
íí 
bool
íí 
	IsDeleted
íí 
{
íí 
get
íí  #
;
íí# $
set
íí% (
;
íí( )
}
íí* +
public
îî 
bool
îî 
	IsPrimary
îî 
{
îî 
get
îî  #
;
îî# $
set
îî% (
;
îî( )
}
îî* +
public
ññ 
string
ññ 
?
ññ 
MaritalStatus
ññ $
{
ññ% &
get
ññ' *
;
ññ* +
set
ññ, /
;
ññ/ 0
}
ññ1 2
public
òò 
DateTime
òò 
?
òò 
DateOfMarriage
òò '
{
òò( )
get
òò* -
;
òò- .
set
òò/ 2
;
òò2 3
}
òò4 5
public
õõ 
CustomerMaster
õõ 
(
õõ 
)
õõ 
{
úú 	
}
ùù 	
public
üü 
CustomerMaster
üü 
(
üü 
int
üü !
customerMasterId
üü" 2
,
üü2 3
int
üü4 7
customerTypeId
üü8 F
,
üüF G
int
üüH K
residentTypeId
üüL Z
,
üüZ [
int
üü\ _

localityId
üü` j
,
üüj k
string
üül r
customerCode
üüs 
,üü Ä
stringüüÅ á
companyNameüüà ì
,üüì î
stringüüï õ*
businessRegistrationNumberüüú ∂
,üü∂ ∑
stringüü∏ æ
	tinNumberüüø »
,üü» …
stringüü  –
pictureüü— ÿ
,üüÿ Ÿ
int
†† 
nationalityId
†† 
,
†† 
string
†† %
postalAddress
††& 3
,
††3 4
string
††5 ; 
residentialAddress
††< N
,
††N O
string
††P V
digitalAddress
††W e
,
††e f
string
††g m"
primaryMobileNumber††n Å
,††Å Ç
string††É â%
secondaryMobileNumber††ä ü
,††ü †
string††° ß
officeNumber††® ¥
,††¥ µ
string††∂ º
whatsAppNumber††Ω À
,††À Ã
string††Õ ”
emailAddress††‘ ‡
,††‡ ·
string††‚ Ë$
residentPermitNumber††È ˝
,††˝ ˛
DateTime
°° &
residentPermitDateIssued
°° -
,
°°- .
DateTime
°°/ 7&
residentPermitExpiryDate
°°8 P
,
°°P Q
int
°°R U
socialMediaTypeId
°°V g
,
°°g h
string
°°i o!
socialMediaAccount°°p Ç
,°°Ç É
int°°Ñ á$
identificationTypeId°°à ú
,°°ú ù
string°°û §(
identificationTypeNumber°°• Ω
,°°Ω æ
string°°ø ≈*
identificationTypeImageOne°°∆ ‡
,°°‡ ·
string°°‚ Ë*
identificationTypeImageTwo°°È É
,°°É Ñ
string
¢¢ 
comments
¢¢ 
,
¢¢ 
string
¢¢ #
interestExpressed
¢¢$ 5
,
¢¢5 6
int
¢¢7 :
debtorStatus
¢¢; G
,
¢¢G H
string
¢¢I O

parentCode
¢¢P Z
,
¢¢Z [
string
¢¢\ b$
contactPerson_FullName
¢¢c y
,
¢¢y z
string¢¢{ Å)
contactPerson_PhoneNumber¢¢Ç õ
,¢¢õ ú
string¢¢ù £*
contactPerson_EmailAddress¢¢§ æ
,¢¢æ ø
string¢¢¿ ∆%
contactPerson_Address¢¢« ‹
,¢¢‹ ›
int¢¢ﬁ ·2
"contactPerson_IdentificationTypeId¢¢‚ Ñ
,¢¢Ñ Ö
string
££ 4
&contactPerson_IdentificationTypeNumber
££ 9
,
££9 :
string
££; A3
%contactPerson_IdentificationTypeImage
££B g
,
££g h
bool
££i m
	isDeleted
££n w
,
££w x
bool
££y }
isParent££~ Ü
,££Ü á
string££à é
maritalStatus££è ú
,££ú ù
DateTime££û ¶
dateOfMarriage££ß µ
,££µ ∂&
ICustomerDomainService££∑ Õ%
customerDomainService££Œ „
)££„ ‰
{
§§ 	
}
•• 	
public
ßß 
static
ßß 
async
ßß 
Task
ßß  
<
ßß  !
CustomerMaster
ßß! /
>
ßß/ 0$
CreateProspectiveAsync
ßß1 G
(
ßßG H
int
®® 
customerMasterId
®®  
,
®®  !
int
©© 
customerTypeId
©© 
,
©© 
int
™™ 
residentTypeId
™™ 
,
™™ 
int
´´ 

localityId
´´ 
,
´´ 
string
¨¨ 
customerCode
¨¨ 
,
¨¨  
int
≠≠ 
titleId
≠≠ 
,
≠≠ 
string
ÆÆ 
surName
ÆÆ 
,
ÆÆ 
string
ØØ 

otherNames
ØØ 
,
ØØ 
string
∞∞ 
companyName
∞∞ 
,
∞∞ 
string
±± 
picture
±± 
,
±± 
int
≤≤ 
genderId
≤≤ 
,
≤≤ 
int
≥≥ 
nationalityId
≥≥ 
,
≥≥ 
string
¥¥ 
postalAddress
¥¥  
,
¥¥  !
string
µµ  
residentialAddress
µµ %
,
µµ% &
string
∂∂ 
digitalAddress
∂∂ !
,
∂∂! "
string
∑∑ !
primaryMobileNumber
∑∑ &
,
∑∑& '
string
∏∏ #
secondaryMobileNumber
∏∏ (
,
∏∏( )
string
ππ 
officeNumber
ππ 
,
ππ  
string
∫∫ 
whatsAppNumber
∫∫ !
,
∫∫! "
string
ªª 
emailAddress
ªª 
,
ªª  
int
ºº 
socialMediaTypeId
ºº !
,
ºº! "
string
ΩΩ  
socialMediaAccount
ΩΩ %
,
ΩΩ% &
string
ææ 
comments
ææ 
,
ææ 
string
øø 
interestExpressed
øø $
,
øø$ %
string
¿¿ 
	createdBy
¿¿ 
,
¿¿ $
ICustomerDomainService
¡¡ "#
customerDomainService
¡¡# 8
)
¡¡8 9
{
¬¬ 	
if
ƒƒ 
(
ƒƒ 
customerTypeId
ƒƒ 
<=
ƒƒ !
$num
ƒƒ" #
||
ƒƒ$ &

localityId
ƒƒ' 1
<=
ƒƒ2 4
$num
ƒƒ5 6
||
ƒƒ7 9
string
ƒƒ: @
.
ƒƒ@ A 
IsNullOrWhiteSpace
ƒƒA S
(
ƒƒS T
surName
ƒƒT [
)
ƒƒ[ \
&&
ƒƒ] _
string
ƒƒ` f
.
ƒƒf g 
IsNullOrWhiteSpace
ƒƒg y
(
ƒƒy z

otherNamesƒƒz Ñ
)ƒƒÑ Ö
&&ƒƒÜ à
stringƒƒâ è
.ƒƒè ê"
IsNullOrWhiteSpaceƒƒê ¢
(ƒƒ¢ £
companyNameƒƒ£ Æ
)ƒƒÆ Ø
||ƒƒ∞ ≤
stringƒƒ≥ π
.ƒƒπ ∫"
IsNullOrWhiteSpaceƒƒ∫ Ã
(ƒƒÃ Õ#
primaryMobileNumberƒƒÕ ‡
)ƒƒ‡ ·
||ƒƒ‚ ‰
stringƒƒÂ Î
.ƒƒÎ Ï"
IsNullOrWhiteSpaceƒƒÏ ˛
(ƒƒ˛ ˇ
emailAddressƒƒˇ ã
)ƒƒã å
||ƒƒç è
stringƒƒê ñ
.ƒƒñ ó"
IsNullOrWhiteSpaceƒƒó ©
(ƒƒ© ™!
interestExpressedƒƒ™ ª
)ƒƒª º
)ƒƒº Ω
{
≈≈ 
throw
∆∆ 
new
∆∆ 
ArgumentException
∆∆ +
(
∆∆+ ,
$str
∆∆, ]
)
∆∆] ^
;
∆∆^ _
}
«« 
if
…… 
(
…… 
!
…… 
await
…… #
customerDomainService
…… ,
.
……, - 
CustomerTypeExists
……- ?
(
……? @
customerTypeId
……@ N
)
……N O
)
……O P
throw
   
new
   
ArgumentException
   +
(
  + ,
ErrorMessages
  , 9
.
  9 :#
InvalidCustomerTypeId
  : O
)
  O P
;
  P Q
if
ÃÃ 
(
ÃÃ 
residentTypeId
ÃÃ 
>
ÃÃ  
$num
ÃÃ! "
)
ÃÃ" #
{
ÕÕ 
if
ŒŒ 
(
ŒŒ 
!
ŒŒ 
await
ŒŒ #
customerDomainService
ŒŒ 0
.
ŒŒ0 1 
ResidentTypeExists
ŒŒ1 C
(
ŒŒC D
residentTypeId
ŒŒD R
)
ŒŒR S
)
ŒŒS T
throw
œœ 
new
œœ 
ArgumentException
œœ /
(
œœ/ 0
ErrorMessages
œœ0 =
.
œœ= >#
InvalidResidentTypeId
œœ> S
)
œœS T
;
œœT U
}
–– 
if
““ 
(
““ 
!
““ 
await
““ #
customerDomainService
““ ,
.
““, -
LocalityExists
““- ;
(
““; <

localityId
““< F
)
““F G
)
““G H
throw
”” 
new
”” 
ArgumentException
”” +
(
””+ ,
ErrorMessages
””, 9
.
””9 :
InvalidLocalityId
””: K
)
””K L
;
””L M
if
’’ 
(
’’ 
!
’’ 
await
’’ #
customerDomainService
’’ ,
.
’’, -
GenderExists
’’- 9
(
’’9 :
genderId
’’: B
)
’’B C
)
’’C D
throw
÷÷ 
new
÷÷ 
ArgumentException
÷÷ +
(
÷÷+ ,
ErrorMessages
÷÷, 9
.
÷÷9 :
InvalidGenderId
÷÷: I
)
÷÷I J
;
÷÷J K
if
ÿÿ 
(
ÿÿ 
!
ÿÿ 
await
ÿÿ #
customerDomainService
ÿÿ ,
.
ÿÿ, -
NationalityExists
ÿÿ- >
(
ÿÿ> ?
nationalityId
ÿÿ? L
)
ÿÿL M
)
ÿÿM N
throw
ŸŸ 
new
ŸŸ 
ArgumentException
ŸŸ +
(
ŸŸ+ ,
ErrorMessages
ŸŸ, 9
.
ŸŸ9 :"
InvalidNationalityId
ŸŸ: N
)
ŸŸN O
;
ŸŸO P
if
€€ 
(
€€ 
titleId
€€ 
>
€€ 
$num
€€ 
)
€€ 
{
‹‹ 
if
›› 
(
›› 
!
›› 
await
›› #
customerDomainService
›› 0
.
››0 1
TitleExists
››1 <
(
››< =
titleId
››= D
)
››D E
)
››E F
throw
ﬁﬁ 
new
ﬁﬁ 
ArgumentException
ﬁﬁ /
(
ﬁﬁ/ 0
ErrorMessages
ﬁﬁ0 =
.
ﬁﬁ= >
InvalidTitleId
ﬁﬁ> L
)
ﬁﬁL M
;
ﬁﬁM N
}
ﬂﬂ 
if
·· 
(
·· 
genderId
·· 
<=
·· 
$num
·· 
)
·· 
{
‚‚ 
throw
„„ 
new
„„ 
ArgumentException
„„ +
(
„„+ ,
$str
„„, R
)
„„R S
;
„„S T
}
‰‰ 
if
ÊÊ 
(
ÊÊ 
nationalityId
ÊÊ 
<=
ÊÊ  
$num
ÊÊ! "
)
ÊÊ" #
{
ÁÁ 
throw
ËË 
new
ËË 
ArgumentException
ËË +
(
ËË+ ,
$str
ËË, W
)
ËËW X
;
ËËX Y
}
ÈÈ 
if
ÎÎ 
(
ÎÎ 
socialMediaTypeId
ÎÎ !
>
ÎÎ" #
$num
ÎÎ$ %
)
ÎÎ% &
{
ÏÏ 
if
ÌÌ 
(
ÌÌ 
!
ÌÌ 
await
ÌÌ #
customerDomainService
ÌÌ 0
.
ÌÌ0 1
SocialMediaExists
ÌÌ1 B
(
ÌÌB C
socialMediaTypeId
ÌÌC T
)
ÌÌT U
)
ÌÌU V
throw
ÓÓ 
new
ÓÓ 
ArgumentException
ÓÓ /
(
ÓÓ/ 0
ErrorMessages
ÓÓ0 =
.
ÓÓ= >&
InvalidSocialMediaTypeId
ÓÓ> V
)
ÓÓV W
;
ÓÓW X
}
ÔÔ 
if
ÒÒ 
(
ÒÒ 
string
ÒÒ 
.
ÒÒ  
IsNullOrWhiteSpace
ÒÒ )
(
ÒÒ) *
surName
ÒÒ* 1
)
ÒÒ1 2
&&
ÒÒ3 5
string
ÒÒ6 <
.
ÒÒ< = 
IsNullOrWhiteSpace
ÒÒ= O
(
ÒÒO P

otherNames
ÒÒP Z
)
ÒÒZ [
&&
ÒÒ\ ^
string
ÒÒ_ e
.
ÒÒe f 
IsNullOrWhiteSpace
ÒÒf x
(
ÒÒx y
companyNameÒÒy Ñ
)ÒÒÑ Ö
)ÒÒÖ Ü
{
ÚÚ 
throw
ÛÛ 
new
ÛÛ 
ArgumentException
ÛÛ +
(
ÛÛ+ ,
$str
ÛÛ, j
)
ÛÛj k
;
ÛÛk l
}
ÙÙ 
if
ˆˆ 
(
ˆˆ 
string
ˆˆ 
.
ˆˆ  
IsNullOrWhiteSpace
ˆˆ )
(
ˆˆ) *!
primaryMobileNumber
ˆˆ* =
)
ˆˆ= >
)
ˆˆ> ?
{
˜˜ 
throw
¯¯ 
new
¯¯ 
ArgumentException
¯¯ +
(
¯¯+ ,
$str
¯¯, ]
)
¯¯] ^
;
¯¯^ _
}
˘˘ 
if
˚˚ 
(
˚˚ 
string
˚˚ 
.
˚˚  
IsNullOrWhiteSpace
˚˚ )
(
˚˚) *
emailAddress
˚˚* 6
)
˚˚6 7
)
˚˚7 8
{
¸¸ 
throw
˝˝ 
new
˝˝ 
ArgumentException
˝˝ +
(
˝˝+ ,
$str
˝˝, U
)
˝˝U V
;
˝˝V W
}
˛˛ 
if
ÄÄ 
(
ÄÄ 
string
ÄÄ 
.
ÄÄ  
IsNullOrWhiteSpace
ÄÄ )
(
ÄÄ) *
interestExpressed
ÄÄ* ;
)
ÄÄ; <
)
ÄÄ< =
{
ÅÅ 
throw
ÇÇ 
new
ÇÇ 
ArgumentException
ÇÇ +
(
ÇÇ+ ,
$str
ÇÇ, Z
)
ÇÇZ [
;
ÇÇ[ \
}
ÉÉ 
if
ÖÖ 
(
ÖÖ 
string
ÖÖ 
.
ÖÖ  
IsNullOrWhiteSpace
ÖÖ )
(
ÖÖ) *
comments
ÖÖ* 2
)
ÖÖ2 3
)
ÖÖ3 4
{
ÜÜ 
throw
áá 
new
áá 
ArgumentException
áá +
(
áá+ ,
$str
áá, P
)
ááP Q
;
ááQ R
}
àà 
var
ââ 
customer_locality
ââ !
=
ââ" #
await
ââ$ )#
customerDomainService
ââ* ?
.
ââ? @ 
GetLocalityDetails
ââ@ R
(
ââR S

localityId
ââS ]
)
ââ] ^
;
ââ^ _
var
ää 
locality
ää 
=
ää 
await
ää  #
customerDomainService
ää! 6
.
ää6 7
LocalityExists
ää7 E
(
ääE F

localityId
ääF P
)
ääP Q
;
ääQ R
if
ãã 
(
ãã 
locality
ãã 
is
ãã 
false
ãã !
)
ãã! "
{
åå 
throw
çç 
new
çç 
ArgumentException
çç +
(
çç+ ,
$str
çç, W
)
ççW X
;
ççX Y
}
éé 
string
êê 
code
êê 
=
êê 
new
êê 
Random
êê $
(
êê$ %
)
êê% &
.
êê& '
Next
êê' +
(
êê+ ,
$num
êê, -
,
êê- .
$num
êê/ 4
)
êê4 5
.
êê5 6
ToString
êê6 >
(
êê> ?
)
êê? @
;
êê@ A
string
íí #
locality_customerCode
íí (
=
íí) *
customer_locality
íí+ <
.
íí< =
LocalityInitial
íí= L
!
ííL M
;
ííM N
string
ìì 
_customercode
ìì  
=
ìì! "
$"
ìì# %
{
ìì% &#
locality_customerCode
ìì& ;
}
ìì; <
{
ìì< =
code
ìì= A
}
ììA B
"
ììB C
;
ììC D
var
ïï 
customer
ïï 
=
ïï 
new
ïï 
CustomerMaster
ïï -
{
ññ 
CustomerMasterId
óó  
=
óó! "
customerMasterId
óó# 3
,
óó3 4
CustomerTypeId
òò 
=
òò  
customerTypeId
òò! /
,
òò/ 0
ResidentTypeId
ôô 
=
ôô  
residentTypeId
ôô! /
,
ôô/ 0

LocalityId
öö 
=
öö 

localityId
öö '
,
öö' (
CustomerCode
õõ 
=
õõ 
_customercode
õõ ,
,
õõ, -
TitleId
úú 
=
úú 
titleId
úú !
,
úú! "
SurName
ùù 
=
ùù 
surName
ùù !
,
ùù! "

OtherNames
ûû 
=
ûû 

otherNames
ûû '
,
ûû' (
CompanyName
üü 
=
üü 
companyName
üü )
,
üü) *
DateOfBirth
†† 
=
†† 
Convert
†† %
.
††% &

ToDateTime
††& 0
(
††0 1
$str
††1 =
)
††= >
,
††> ?
	TinNumber
°° 
=
°° 
string
°° "
.
°°" #
Empty
°°# (
,
°°( )
Picture
¢¢ 
=
¢¢ 
picture
¢¢ !
,
¢¢! "
GenderId
££ 
=
££ 
genderId
££ #
,
££# $
NationalityId
§§ 
=
§§ 
nationalityId
§§  -
,
§§- .
PostalAddress
•• 
=
•• 
postalAddress
••  -
,
••- . 
ResidentialAddress
¶¶ "
=
¶¶# $ 
residentialAddress
¶¶% 7
,
¶¶7 8
DigitalAddress
ßß 
=
ßß  
digitalAddress
ßß! /
,
ßß/ 0!
PrimaryMobileNumber
®® #
=
®®$ %!
primaryMobileNumber
®®& 9
,
®®9 :#
SecondaryMobileNumber
©© %
=
©©& '#
secondaryMobileNumber
©©( =
,
©©= >
OfficeNumber
™™ 
=
™™ 
officeNumber
™™ +
,
™™+ ,
WhatsAppNumber
´´ 
=
´´  
whatsAppNumber
´´! /
,
´´/ 0
EmailAddress
¨¨ 
=
¨¨ 
emailAddress
¨¨ +
,
¨¨+ ,"
ResidentPermitNumber
≠≠ $
=
≠≠% &
string
≠≠' -
.
≠≠- .
Empty
≠≠. 3
,
≠≠3 4&
ResidentPermitDateIssued
ÆÆ (
=
ÆÆ) *
Convert
ÆÆ+ 2
.
ÆÆ2 3

ToDateTime
ÆÆ3 =
(
ÆÆ= >
$str
ÆÆ> J
)
ÆÆJ K
,
ÆÆK L&
ResidentPermitExpiryDate
ØØ (
=
ØØ) *
Convert
ØØ+ 2
.
ØØ2 3

ToDateTime
ØØ3 =
(
ØØ= >
$str
ØØ> J
)
ØØJ K
,
ØØK L
SocialMediaTypeId
∞∞ !
=
∞∞" #
socialMediaTypeId
∞∞$ 5
,
∞∞5 6 
SocialMediaAccount
±± "
=
±±# $ 
socialMediaAccount
±±% 7
,
±±7 8"
IdentificationTypeId
≤≤ $
=
≤≤% &
$num
≤≤' (
,
≤≤( )&
IdentificationTypeNumber
≥≥ (
=
≥≥) *
string
≥≥+ 1
.
≥≥1 2
Empty
≥≥2 7
,
≥≥7 8(
IdentificationTypeImageOne
¥¥ *
=
¥¥+ ,
string
¥¥- 3
.
¥¥3 4
Empty
¥¥4 9
,
¥¥9 :(
IdentificationTypeImageTwo
µµ *
=
µµ+ ,
string
µµ- 3
.
µµ3 4
Empty
µµ4 9
,
µµ9 :*
IdentificationTypeImageThree
∂∂ ,
=
∂∂- .
string
∂∂/ 5
.
∂∂5 6
Empty
∂∂6 ;
,
∂∂; <)
IdentificationTypeImageFour
∑∑ +
=
∑∑, -
string
∑∑. 4
.
∑∑4 5
Empty
∑∑5 :
,
∑∑: ;)
IdentificationTypeImageFive
∏∏ +
=
∏∏, -
string
∏∏. 4
.
∏∏4 5
Empty
∏∏5 :
,
∏∏: ;
Comments
ππ 
=
ππ 
comments
ππ #
,
ππ# $
InterestExpressed
∫∫ !
=
∫∫" #
interestExpressed
∫∫$ 5
,
∫∫5 6
DebtorStatus
ªª 
=
ªª 
$num
ªª  
,
ªª  !

ParentCode
ºº 
=
ºº 
string
ºº #
.
ºº# $
Empty
ºº$ )
,
ºº) *$
ContactPerson_FullName
ΩΩ &
=
ΩΩ' (
string
ΩΩ) /
.
ΩΩ/ 0
Empty
ΩΩ0 5
,
ΩΩ5 6'
ContactPerson_PhoneNumber
ææ )
=
ææ* +
string
ææ, 2
.
ææ2 3
Empty
ææ3 8
,
ææ8 9(
ContactPerson_EmailAddress
øø *
=
øø+ ,
string
øø- 3
.
øø3 4
Empty
øø4 9
,
øø9 :#
ContactPerson_Address
¿¿ %
=
¿¿& '
string
¿¿( .
.
¿¿. /
Empty
¿¿/ 4
,
¿¿4 50
"ContactPerson_IdentificationTypeId
¡¡ 2
=
¡¡3 4
$num
¡¡5 6
,
¡¡6 74
&ContactPerson_IdentificationTypeNumber
¬¬ 6
=
¬¬7 8
string
¬¬9 ?
.
¬¬? @
Empty
¬¬@ E
,
¬¬E F6
(ContactPerson_IdentificationTypeImageOne
√√ 8
=
√√9 :
string
√√; A
.
√√A B
Empty
√√B G
,
√√G H6
(ContactPerson_IdentificationTypeImageTwo
ƒƒ 8
=
ƒƒ9 :
string
ƒƒ; A
.
ƒƒA B
Empty
ƒƒB G
,
ƒƒG H
	IsDeleted
≈≈ 
=
≈≈ 
false
≈≈ !
,
≈≈! "
	CreatedBy
∆∆ 
=
∆∆ 
	createdBy
∆∆ %
}
«« 
;
«« 
customer
…… 
.
…… 
_domainEvents
…… "
.
……" #
Add
……# &
(
……& '
new
……' *"
CustomerCreatedEvent
……+ ?
(
……? @
customerMasterId
    
,
    !
_customercode
ÀÀ 
,
ÀÀ 
$str
ÃÃ 
,
ÃÃ 
	createdBy
ÕÕ 
)
ÕÕ 
)
ÕÕ 
;
ÕÕ 
return
œœ 
customer
œœ 
;
œœ 
}
—— 	
public
”” 
static
”” 
async
”” 
Task
””  
<
””  !
CustomerMaster
””! /
>
””/ 0 
CreateCompanyAsync
””1 C
(
””C D
int
””D G
customerMasterId
””H X
,
””X Y
int
””Z ]
customerTypeId
””^ l
,
””l m
int
””n q
residentTypeId””r Ä
,””Ä Å
int””Ç Ö

localityId””Ü ê
,””ê ë
string””í ò
customerCode””ô •
,””• ¶
string””ß ≠
companyName””Æ π
,””π ∫
int””ª æ
nationalityId””ø Ã
,””Ã Õ
string””Œ ‘
companyAddress””’ „
,””„ ‰
string””Â Î
digitalAddress””Ï ˙
,””˙ ˚
string””¸ Ç#
primaryMobileNumber””É ñ
,””ñ ó
string
‘‘D J#
secondaryMobileNumber
‘‘K `
,
‘‘` a
string
‘‘b h
officeNumber
‘‘i u
,
‘‘u v
string
‘‘w }
whatsAppNumber‘‘~ å
,‘‘å ç
string‘‘é î
emailAddress‘‘ï °
,‘‘° ¢
string‘‘£ ©*
businessRegistrationNumber‘‘™ ƒ
,‘‘ƒ ≈
string‘‘∆ Ã
	tinNumber‘‘Õ ÷
,‘‘÷ ◊
int‘‘ÿ €!
socialMediaTypeId‘‘‹ Ì
,‘‘Ì Ó
string‘‘Ô ı"
socialMediaAccount‘‘ˆ à
,‘‘à â
string
’’D J(
identificationTypeImageOne
’’K e
,
’’e f
string
’’g m)
identificationTypeImageTwo’’n à
,’’à â
string’’ä ê,
identificationTypeImageThree’’ë ≠
,’’≠ Æ
string’’Ø µ+
identificationTypeImageFour’’∂ —
,’’— “
string’’” Ÿ+
identificationTypeImageFive’’⁄ ı
,’’ı ˆ
string
÷÷D J$
contactPerson_FullName
÷÷K a
,
÷÷a b
string
÷÷c i(
contactPerson_PhoneNumber÷÷j É
,÷÷É Ñ
string÷÷Ö ã*
contactPerson_EmailAddress÷÷å ¶
,÷÷¶ ß
string÷÷® Æ%
contactPerson_Address÷÷Ø ƒ
,÷÷ƒ ≈
int÷÷∆ …2
"contactPerson_IdentificationTypeId÷÷  Ï
,÷÷Ï Ì
string÷÷Ó Ù6
&contactPerson_IdentificationTypeNumber÷÷ı õ
,÷÷õ ú
string
◊◊D J6
(contactPerson_IdentificationTypeImageOne
◊◊K s
,
◊◊s t
string
◊◊u {7
(contactPerson_IdentificationTypeImageTwo◊◊| §
,◊◊§ •
string◊◊¶ ¨
comments◊◊≠ µ
,◊◊µ ∂
bool◊◊∑ ª
	isDeleted◊◊º ≈
,◊◊≈ ∆
bool◊◊« À
	isPrimary◊◊Ã ’
,◊◊’ ÷&
ICustomerDomainService◊◊◊ Ì%
customerDomainService◊◊Ó É
)◊◊É Ñ
{
ÿÿ 	
if
ŸŸ 
(
ŸŸ 
customerTypeId
ŸŸ 
<=
ŸŸ !
$num
ŸŸ" #
||
ŸŸ$ &

localityId
ŸŸ' 1
<=
ŸŸ2 4
$num
ŸŸ5 6
||
ŸŸ7 9
nationalityId
ŸŸ: G
<=
ŸŸH J
$num
ŸŸK L
||
ŸŸM O
string
ŸŸP V
.
ŸŸV W 
IsNullOrWhiteSpace
ŸŸW i
(
ŸŸi j
companyName
ŸŸj u
)
ŸŸu v
||
ŸŸw y
stringŸŸz Ä
.ŸŸÄ Å"
IsNullOrWhiteSpaceŸŸÅ ì
(ŸŸì î
companyAddressŸŸî ¢
)ŸŸ¢ £
||ŸŸ§ ¶
stringŸŸß ≠
.ŸŸ≠ Æ"
IsNullOrWhiteSpaceŸŸÆ ¿
(ŸŸ¿ ¡#
primaryMobileNumberŸŸ¡ ‘
)ŸŸ‘ ’
||ŸŸ÷ ÿ
stringŸŸŸ ﬂ
.ŸŸﬂ ‡"
IsNullOrWhiteSpaceŸŸ‡ Ú
(ŸŸÚ Û
emailAddressŸŸÛ ˇ
)ŸŸˇ Ä
)ŸŸÄ Å
{
⁄⁄ 
throw
€€ 
new
€€ 
ArgumentException
€€ +
(
€€+ ,
$str
€€, Y
)
€€Y Z
;
€€Z [
}
‹‹ 
if
ﬁﬁ 
(
ﬁﬁ 
!
ﬁﬁ 
await
ﬁﬁ #
customerDomainService
ﬁﬁ ,
.
ﬁﬁ, - 
CustomerTypeExists
ﬁﬁ- ?
(
ﬁﬁ? @
customerTypeId
ﬁﬁ@ N
)
ﬁﬁN O
)
ﬁﬁO P
throw
ﬂﬂ 
new
ﬂﬂ 
ArgumentException
ﬂﬂ +
(
ﬂﬂ+ ,
$str
ﬂﬂ, G
)
ﬂﬂG H
;
ﬂﬂH I
if
·· 
(
·· 
residentTypeId
·· 
>
··  
$num
··! "
)
··" #
{
‚‚ 
if
„„ 
(
„„ 
!
„„ 
await
„„ #
customerDomainService
„„ 0
.
„„0 1 
ResidentTypeExists
„„1 C
(
„„C D
residentTypeId
„„D R
)
„„R S
)
„„S T
throw
‰‰ 
new
‰‰ 
ArgumentException
‰‰ /
(
‰‰/ 0
$str
‰‰0 K
)
‰‰K L
;
‰‰L M
}
ÊÊ 
if
ËË 
(
ËË 
!
ËË 
await
ËË #
customerDomainService
ËË ,
.
ËË, -
LocalityExists
ËË- ;
(
ËË; <

localityId
ËË< F
)
ËËF G
)
ËËG H
throw
ÈÈ 
new
ÈÈ 
ArgumentException
ÈÈ +
(
ÈÈ+ ,
$str
ÈÈ, B
)
ÈÈB C
;
ÈÈC D
if
ÏÏ 
(
ÏÏ 
!
ÏÏ 
await
ÏÏ #
customerDomainService
ÏÏ ,
.
ÏÏ, -
NationalityExists
ÏÏ- >
(
ÏÏ> ?
nationalityId
ÏÏ? L
)
ÏÏL M
)
ÏÏM N
throw
ÌÌ 
new
ÌÌ 
ArgumentException
ÌÌ +
(
ÌÌ+ ,
$str
ÌÌ, E
)
ÌÌE F
;
ÌÌF G
if
 
(
 
string
 
.
  
IsNullOrWhiteSpace
 )
(
) *
companyName
* 5
)
5 6
)
6 7
{
ÒÒ 
throw
ÚÚ 
new
ÚÚ 
ArgumentException
ÚÚ +
(
ÚÚ+ ,
$str
ÚÚ, R
)
ÚÚR S
;
ÚÚS T
}
ÛÛ 
if
ıı 
(
ıı 
string
ıı 
.
ıı  
IsNullOrWhiteSpace
ıı )
(
ıı) *
companyAddress
ıı* 8
)
ıı8 9
)
ıı9 :
{
ˆˆ 
throw
˜˜ 
new
˜˜ 
ArgumentException
˜˜ +
(
˜˜+ ,
$str
˜˜, U
)
˜˜U V
;
˜˜V W
}
¯¯ 
if
˙˙ 
(
˙˙ 
string
˙˙ 
.
˙˙  
IsNullOrWhiteSpace
˙˙ )
(
˙˙) *(
businessRegistrationNumber
˙˙* D
)
˙˙D E
)
˙˙E F
{
˚˚ 
throw
¸¸ 
new
¸¸ 
ArgumentException
¸¸ +
(
¸¸+ ,
$str
¸¸, b
)
¸¸b c
;
¸¸c d
}
˝˝ 
if
ˇˇ 
(
ˇˇ 
string
ˇˇ 
.
ˇˇ  
IsNullOrWhiteSpace
ˇˇ )
(
ˇˇ) *
	tinNumber
ˇˇ* 3
)
ˇˇ3 4
)
ˇˇ4 5
{
ÄÄ 
throw
ÅÅ 
new
ÅÅ 
ArgumentException
ÅÅ +
(
ÅÅ+ ,
$str
ÅÅ, P
)
ÅÅP Q
;
ÅÅQ R
}
ÇÇ 
if
ÑÑ 
(
ÑÑ 
socialMediaTypeId
ÑÑ !
>
ÑÑ" #
$num
ÑÑ$ %
)
ÑÑ% &
{
ÖÖ 
if
ÜÜ 
(
ÜÜ 
!
ÜÜ 
await
ÜÜ #
customerDomainService
ÜÜ 0
.
ÜÜ0 1
SocialMediaExists
ÜÜ1 B
(
ÜÜB C
socialMediaTypeId
ÜÜC T
)
ÜÜT U
)
ÜÜU V
throw
áá 
new
áá 
ArgumentException
áá /
(
áá/ 0
$str
áá0 O
)
ááO P
;
ááP Q
}
àà 
if
ää 
(
ää 
string
ää 
.
ää  
IsNullOrWhiteSpace
ää )
(
ää) *
companyAddress
ää* 8
)
ää8 9
)
ää9 :
{
ãã 
throw
åå 
new
åå 
ArgumentException
åå +
(
åå+ ,
$str
åå, W
)
ååW X
;
ååX Y
}
çç 
if
èè 
(
èè 
string
èè 
.
èè  
IsNullOrWhiteSpace
èè )
(
èè) *!
primaryMobileNumber
èè* =
)
èè= >
)
èè> ?
{
êê 
throw
ëë 
new
ëë 
ArgumentException
ëë +
(
ëë+ ,
$str
ëë, ]
)
ëë] ^
;
ëë^ _
}
íí 
if
îî 
(
îî 
string
îî 
.
îî  
IsNullOrWhiteSpace
îî )
(
îî) *
emailAddress
îî* 6
)
îî6 7
)
îî7 8
{
ïï 
throw
ññ 
new
ññ 
ArgumentException
ññ +
(
ññ+ ,
$str
ññ, U
)
ññU V
;
ññV W
}
óó 
var
ôô 
customer_locality
ôô !
=
ôô" #
await
ôô$ )#
customerDomainService
ôô* ?
.
ôô? @ 
GetLocalityDetails
ôô@ R
(
ôôR S

localityId
ôôS ]
)
ôô] ^
;
ôô^ _
if
õõ 
(
õõ 
customer_locality
õõ !
is
õõ" $
null
õõ% )
)
õõ) *
{
úú 
throw
ùù 
new
ùù 
ArgumentException
ùù +
(
ùù+ ,
$str
ùù, W
)
ùùW X
;
ùùX Y
}
ûû 
int
°° 
counter
°° 
=
°° 
customer_locality
°° +
.
°°+ ,!
CustomerCodeCounter
°°, ?
;
°°? @
counter
¢¢ 
++
¢¢ 
;
¢¢ 
string
§§ 
incrementedNumber
§§ $
=
§§% &
counter
§§' .
.
§§. /
ToString
§§/ 7
(
§§7 8
$str
§§8 <
)
§§< =
;
§§= >
string
•• #
locality_customerCode
•• (
=
••) *
customer_locality
••+ <
.
••< =
CustomerCode
••= I
!
••I J
;
••J K
string
¶¶ 
_customercode
¶¶  
=
¶¶! "
$"
¶¶# %
{
¶¶% &#
locality_customerCode
¶¶& ;
}
¶¶; <
{
¶¶< =
incrementedNumber
¶¶= N
}
¶¶N O
"
¶¶O P
;
¶¶P Q
return
©© 
new
©© 
CustomerMaster
©© %
{
™™ 
CustomerMasterId
´´  
=
´´! "
customerMasterId
´´# 3
,
´´3 4
CustomerTypeId
¨¨ 
=
¨¨  
customerTypeId
¨¨! /
,
¨¨/ 0
ResidentTypeId
≠≠ 
=
≠≠  
residentTypeId
≠≠! /
,
≠≠/ 0

LocalityId
ÆÆ 
=
ÆÆ 

localityId
ÆÆ '
,
ÆÆ' (
CustomerCode
ØØ 
=
ØØ 
_customercode
ØØ ,
,
ØØ, -
TitleId
∞∞ 
=
∞∞ 
$num
∞∞ 
,
∞∞ 
SurName
±± 
=
±± 
string
±±  
.
±±  !
Empty
±±! &
,
±±& '

OtherNames
≤≤ 
=
≤≤ 
string
≤≤ #
.
≤≤# $
Empty
≤≤$ )
,
≤≤) *
CompanyName
≥≥ 
=
≥≥ 
companyName
≥≥ )
,
≥≥) *
DateOfBirth
¥¥ 
=
¥¥ 
Convert
¥¥ %
.
¥¥% &

ToDateTime
¥¥& 0
(
¥¥0 1
$str
¥¥1 =
)
¥¥= >
,
¥¥> ?
	TinNumber
µµ 
=
µµ 
	tinNumber
µµ %
,
µµ% &
Picture
∂∂ 
=
∂∂ 
string
∂∂  
.
∂∂  !
Empty
∂∂! &
,
∂∂& '
GenderId
∑∑ 
=
∑∑ 
$num
∑∑ 
,
∑∑ 
NationalityId
∏∏ 
=
∏∏ 
nationalityId
∏∏  -
,
∏∏- .
PostalAddress
ππ 
=
ππ 
companyAddress
ππ  .
,
ππ. / 
ResidentialAddress
∫∫ "
=
∫∫# $
companyAddress
∫∫% 3
,
∫∫3 4
DigitalAddress
ªª 
=
ªª  
digitalAddress
ªª! /
,
ªª/ 0!
PrimaryMobileNumber
ºº #
=
ºº$ %!
primaryMobileNumber
ºº& 9
,
ºº9 :#
SecondaryMobileNumber
ΩΩ %
=
ΩΩ& '#
secondaryMobileNumber
ΩΩ( =
,
ΩΩ= >
OfficeNumber
ææ 
=
ææ 
officeNumber
ææ +
,
ææ+ ,
WhatsAppNumber
øø 
=
øø  
whatsAppNumber
øø! /
,
øø/ 0
EmailAddress
¿¿ 
=
¿¿ 
emailAddress
¿¿ +
,
¿¿+ ,"
ResidentPermitNumber
¡¡ $
=
¡¡% &
string
¡¡' -
.
¡¡- .
Empty
¡¡. 3
,
¡¡3 4&
ResidentPermitDateIssued
¬¬ (
=
¬¬) *
Convert
¬¬+ 2
.
¬¬2 3

ToDateTime
¬¬3 =
(
¬¬= >
$str
¬¬> J
)
¬¬J K
,
¬¬K L&
ResidentPermitExpiryDate
√√ (
=
√√) *
Convert
√√+ 2
.
√√2 3

ToDateTime
√√3 =
(
√√= >
$str
√√> J
)
√√J K
,
√√K L
SocialMediaTypeId
ƒƒ !
=
ƒƒ" #
socialMediaTypeId
ƒƒ$ 5
,
ƒƒ5 6 
SocialMediaAccount
≈≈ "
=
≈≈# $ 
socialMediaAccount
≈≈% 7
,
≈≈7 8"
IdentificationTypeId
∆∆ $
=
∆∆% &
$num
∆∆' (
,
∆∆( )&
IdentificationTypeNumber
«« (
=
««) *(
businessRegistrationNumber
««+ E
,
««E F(
IdentificationTypeImageOne
»» *
=
»»+ ,(
identificationTypeImageOne
»»- G
,
»»G H(
IdentificationTypeImageTwo
…… *
=
……+ ,(
identificationTypeImageTwo
……- G
,
……G H*
IdentificationTypeImageThree
   ,
=
  - .*
identificationTypeImageThree
  / K
,
  K L)
IdentificationTypeImageFour
ÀÀ +
=
ÀÀ, -)
identificationTypeImageFour
ÀÀ. I
,
ÀÀI J)
IdentificationTypeImageFive
ÃÃ +
=
ÃÃ, -)
identificationTypeImageFive
ÃÃ. I
,
ÃÃI J
Comments
ÕÕ 
=
ÕÕ 
comments
ÕÕ #
,
ÕÕ# $
InterestExpressed
ŒŒ !
=
ŒŒ" #
string
ŒŒ$ *
.
ŒŒ* +
Empty
ŒŒ+ 0
,
ŒŒ0 1
DebtorStatus
œœ 
=
œœ 
$num
œœ  
,
œœ  !

ParentCode
–– 
=
–– 
string
–– #
.
––# $
Empty
––$ )
,
––) *$
ContactPerson_FullName
—— &
=
——' ($
contactPerson_FullName
——) ?
,
——? @'
ContactPerson_PhoneNumber
““ )
=
““* +'
contactPerson_PhoneNumber
““, E
,
““E F(
ContactPerson_EmailAddress
”” *
=
””+ ,(
contactPerson_EmailAddress
””- G
,
””G H#
ContactPerson_Address
‘‘ %
=
‘‘& '#
contactPerson_Address
‘‘( =
,
‘‘= >0
"ContactPerson_IdentificationTypeId
’’ 2
=
’’3 40
"contactPerson_IdentificationTypeId
’’5 W
,
’’W X4
&ContactPerson_IdentificationTypeNumber
÷÷ 6
=
÷÷7 84
&contactPerson_IdentificationTypeNumber
÷÷9 _
,
÷÷_ `6
(ContactPerson_IdentificationTypeImageOne
◊◊ 8
=
◊◊9 :6
(contactPerson_IdentificationTypeImageOne
◊◊; c
,
◊◊c d6
(ContactPerson_IdentificationTypeImageTwo
ÿÿ 8
=
ÿÿ9 :6
(contactPerson_IdentificationTypeImageTwo
ÿÿ; c
,
ÿÿc d
	IsDeleted
ŸŸ 
=
ŸŸ 
false
ŸŸ !
,
ŸŸ! "
	IsPrimary
⁄⁄ 
=
⁄⁄ 
true
⁄⁄  
,
⁄⁄  !
MaritalStatus
€€ 
=
€€ 
string
€€  &
.
€€& '
Empty
€€' ,
,
€€, -
DateOfMarriage
‹‹ 
=
‹‹  
Convert
‹‹! (
.
‹‹( )

ToDateTime
‹‹) 3
(
‹‹3 4
$str
‹‹4 @
)
‹‹@ A
}
›› 
;
›› 
}
‡‡ 	
public
‰‰ 
static
‰‰ 
async
‰‰ 
Task
‰‰  
<
‰‰  !
CustomerMaster
‰‰! /
>
‰‰/ 0#
CreateIndividualAsync
‰‰1 F
(
‰‰F G
int
‰‰G J
customerMasterId
‰‰K [
,
‰‰[ \
int
‰‰] `
customerTypeId
‰‰a o
,
‰‰o p
int
‰‰q t
residentTypeId‰‰u É
,‰‰É Ñ
int‰‰Ö à

localityId‰‰â ì
,‰‰ì î
string‰‰ï õ
customerCode‰‰ú ®
,‰‰® ©
int‰‰™ ≠
titleId‰‰Æ µ
,‰‰µ ∂
string‰‰∑ Ω
surName‰‰æ ≈
,‰‰≈ ∆
string‰‰« Õ

otherNames‰‰Œ ÿ
,‰‰ÿ Ÿ
DateTime‰‰⁄ ‚
dateOfBirth‰‰„ Ó
,‰‰Ó Ô
string‰‰ ˆ
	tinNumber‰‰˜ Ä
,‰‰Ä Å
string‰‰Ç à
picture‰‰â ê
,‰‰ê ë
int‰‰í ï
genderId‰‰ñ û
,‰‰û ü
int
ÂÂG J
nationalityId
ÂÂK X
,
ÂÂX Y
string
ÂÂZ `
postalAddress
ÂÂa n
,
ÂÂn o
string
ÂÂp v!
residentialAddressÂÂw â
,ÂÂâ ä
stringÂÂã ë
digitalAddressÂÂí †
,ÂÂ† °
stringÂÂ¢ ®#
primaryMobileNumberÂÂ© º
,ÂÂº Ω
stringÂÂæ ƒ%
secondaryMobileNumberÂÂ≈ ⁄
,ÂÂ⁄ €
stringÂÂ‹ ‚
officeNumberÂÂ„ Ô
,ÂÂÔ 
stringÂÂÒ ˜
whatsAppNumberÂÂ¯ Ü
,ÂÂÜ á
stringÂÂà é
emailAddressÂÂè õ
,ÂÂõ ú
string
ÊÊG M"
residentPermitNumber
ÊÊN b
,
ÊÊb c
DateTime
ÊÊd l
?
ÊÊl m'
residentPermitDateIssuedÊÊn Ü
,ÊÊÜ á
DateTimeÊÊà ê
?ÊÊê ë(
residentPermitExpiryDateÊÊí ™
,ÊÊ™ ´
intÊÊ¨ Ø!
socialMediaTypeIdÊÊ∞ ¡
,ÊÊ¡ ¬
stringÊÊ√ …"
socialMediaAccountÊÊ  ‹
,ÊÊ‹ ›
intÊÊﬁ ·$
identificationTypeIdÊÊ‚ ˆ
,ÊÊˆ ˜
stringÊÊ¯ ˛(
identificationTypeNumberÊÊˇ ó
,ÊÊó ò
string
ÁÁG M(
identificationTypeImageOne
ÁÁN h
,
ÁÁh i
string
ÁÁj p)
identificationTypeImageTwoÁÁq ã
,ÁÁã å
stringÁÁç ì,
identificationTypeImageThreeÁÁî ∞
,ÁÁ∞ ±
stringÁÁ≤ ∏+
identificationTypeImageFourÁÁπ ‘
,ÁÁ‘ ’
stringÁÁ÷ ‹+
identificationTypeImageFiveÁÁ› ¯
,ÁÁ¯ ˘
stringÁÁ˙ Ä
commentsÁÁÅ â
,ÁÁâ ä
stringÁÁã ë!
interestExpressedÁÁí £
,ÁÁ£ §
intÁÁ• ®
debtorStatusÁÁ© µ
,ÁÁµ ∂
stringÁÁ∑ Ω

parentCodeÁÁæ »
,ÁÁ» …
stringÁÁ  –&
contactPerson_FullNameÁÁ— Á
,ÁÁÁ Ë
stringÁÁÈ Ô)
contactPerson_PhoneNumberÁÁ â
,ÁÁâ ä
string
ËËG M(
contactPerson_EmailAddress
ËËN h
,
ËËh i
string
ËËj p$
contactPerson_AddressËËq Ü
,ËËÜ á
intËËà ã2
"contactPerson_IdentificationTypeIdËËå Æ
,ËËÆ Ø
stringËË∞ ∂6
&contactPerson_IdentificationTypeNumberËË∑ ›
,ËË› ﬁ
stringËËﬂ Â8
(contactPerson_IdentificationTypeImageOneËËÊ é
,ËËé è
stringËËê ñ8
(contactPerson_IdentificationTypeImageTwoËËó ø
,ËËø ¿
boolËË¡ ≈
	isDeletedËË∆ œ
,ËËœ –
boolËË— ’
	isPrimaryËË÷ ﬂ
,ËËﬂ ‡&
ICustomerDomainServiceËË· ˜%
customerDomainServiceËË¯ ç
)ËËç é
{
ÈÈ 	
if
ÍÍ 
(
ÍÍ 
customerTypeId
ÍÍ 
<=
ÍÍ !
$num
ÍÍ" #
||
ÍÍ$ &
residentTypeId
ÍÍ' 5
<=
ÍÍ6 8
$num
ÍÍ9 :
||
ÍÍ; =

localityId
ÍÍ> H
<=
ÍÍI K
$num
ÍÍL M
||
ÍÍN P
nationalityId
ÍÍQ ^
<=
ÍÍ_ a
$num
ÍÍb c
||
ÍÍd f"
identificationTypeId
ÍÍg {
<=
ÍÍ| ~
$numÍÍ Ä
||ÍÍÅ É
stringÍÍÑ ä
.ÍÍä ã"
IsNullOrWhiteSpaceÍÍã ù
(ÍÍù û
surNameÍÍû •
)ÍÍ• ¶
||ÍÍß ©
stringÍÍ™ ∞
.ÍÍ∞ ±"
IsNullOrWhiteSpaceÍÍ± √
(ÍÍ√ ƒ

otherNamesÍÍƒ Œ
)ÍÍŒ œ
||ÍÍ– “
stringÍÍ” Ÿ
.ÍÍŸ ⁄"
IsNullOrWhiteSpaceÍÍ⁄ Ï
(ÍÍÏ Ì(
identificationTypeNumberÍÍÌ Ö
)ÍÍÖ Ü
||ÍÍá â
stringÍÍä ê
.ÍÍê ë"
IsNullOrWhiteSpaceÍÍë £
(ÍÍ£ §#
primaryMobileNumberÍÍ§ ∑
)ÍÍ∑ ∏
||ÍÍπ ª
stringÍÍº ¬
.ÍÍ¬ √"
IsNullOrWhiteSpaceÍÍ√ ’
(ÍÍ’ ÷
emailAddressÍÍ÷ ‚
)ÍÍ‚ „
)ÍÍ„ ‰
{
ÎÎ 
throw
ÏÏ 
new
ÏÏ 
ArgumentException
ÏÏ +
(
ÏÏ+ ,
$str
ÏÏ, \
)
ÏÏ\ ]
;
ÏÏ] ^
}
ÌÌ 
if
ÔÔ 
(
ÔÔ 
!
ÔÔ 
await
ÔÔ #
customerDomainService
ÔÔ ,
.
ÔÔ, - 
CustomerTypeExists
ÔÔ- ?
(
ÔÔ? @
customerTypeId
ÔÔ@ N
)
ÔÔN O
)
ÔÔO P
throw
 
new
 
ArgumentException
 +
(
+ ,
$str
, G
)
G H
;
H I
if
ÚÚ 
(
ÚÚ 
!
ÚÚ 
await
ÚÚ #
customerDomainService
ÚÚ ,
.
ÚÚ, - 
ResidentTypeExists
ÚÚ- ?
(
ÚÚ? @
residentTypeId
ÚÚ@ N
)
ÚÚN O
)
ÚÚO P
throw
ÛÛ 
new
ÛÛ 
ArgumentException
ÛÛ +
(
ÛÛ+ ,
$str
ÛÛ, G
)
ÛÛG H
;
ÛÛH I
if
ıı 
(
ıı 
!
ıı 
await
ıı #
customerDomainService
ıı ,
.
ıı, -
LocalityExists
ıı- ;
(
ıı; <

localityId
ıı< F
)
ııF G
)
ııG H
throw
ˆˆ 
new
ˆˆ 
ArgumentException
ˆˆ +
(
ˆˆ+ ,
$str
ˆˆ, B
)
ˆˆB C
;
ˆˆC D
if
¯¯ 
(
¯¯ 
!
¯¯ 
await
¯¯ #
customerDomainService
¯¯ ,
.
¯¯, -
GenderExists
¯¯- 9
(
¯¯9 :
genderId
¯¯: B
)
¯¯B C
)
¯¯C D
throw
˘˘ 
new
˘˘ 
ArgumentException
˘˘ +
(
˘˘+ ,
$str
˘˘, @
)
˘˘@ A
;
˘˘A B
if
˚˚ 
(
˚˚ 
!
˚˚ 
await
˚˚ #
customerDomainService
˚˚ ,
.
˚˚, -
NationalityExists
˚˚- >
(
˚˚> ?
nationalityId
˚˚? L
)
˚˚L M
)
˚˚M N
throw
¸¸ 
new
¸¸ 
ArgumentException
¸¸ +
(
¸¸+ ,
$str
¸¸, E
)
¸¸E F
;
¸¸F G
if
˛˛ 
(
˛˛ 
!
˛˛ 
await
˛˛ #
customerDomainService
˛˛ ,
.
˛˛, -&
IdentificationTypeExists
˛˛- E
(
˛˛E F"
identificationTypeId
˛˛F Z
)
˛˛Z [
)
˛˛[ \
throw
ˇˇ 
new
ˇˇ 
ArgumentException
ˇˇ +
(
ˇˇ+ ,
$str
ˇˇ, M
)
ˇˇM N
;
ˇˇN O
if
ÇÇ 
(
ÇÇ 
(
ÇÇ 
int
ÇÇ 
)
ÇÇ 
ResidentTypeEnum
ÇÇ %
.
ÇÇ% &
NON_RESIDENT
ÇÇ& 2
==
ÇÇ3 5
residentTypeId
ÇÇ6 D
)
ÇÇD E
{
ÉÉ 
if
ÑÑ 
(
ÑÑ 
string
ÑÑ 
.
ÑÑ  
IsNullOrWhiteSpace
ÑÑ -
(
ÑÑ- .$
contactPerson_FullName
ÑÑ. D
)
ÑÑD E
)
ÑÑE F
{
ÖÖ 
throw
ÜÜ 
new
ÜÜ 
ArgumentException
ÜÜ /
(
ÜÜ/ 0
$str
ÜÜ0 c
)
ÜÜc d
;
ÜÜd e
}
áá 
if
ââ 
(
ââ 
string
ââ 
.
ââ  
IsNullOrWhiteSpace
ââ -
(
ââ- .'
contactPerson_PhoneNumber
ââ. G
)
ââG H
)
ââH I
{
ää 
throw
ãã 
new
ãã 
ArgumentException
ãã /
(
ãã/ 0
$str
ãã0 g
)
ããg h
;
ããh i
}
åå 
if
éé 
(
éé 
string
éé 
.
éé  
IsNullOrWhiteSpace
éé -
(
éé- .(
contactPerson_EmailAddress
éé. H
)
ééH I
)
ééI J
{
èè 
throw
êê 
new
êê 
ArgumentException
êê /
(
êê/ 0
$str
êê0 h
)
êêh i
;
êêi j
}
ëë 
if
ìì 
(
ìì 
string
ìì 
.
ìì  
IsNullOrWhiteSpace
ìì -
(
ìì- .#
contactPerson_Address
ìì. C
)
ììC D
)
ììD E
{
îî 
throw
ïï 
new
ïï 
ArgumentException
ïï /
(
ïï/ 0
$str
ïï0 b
)
ïïb c
;
ïïc d
}
ññ 
if
òò 
(
òò 0
"contactPerson_IdentificationTypeId
òò 6
<=
òò7 9
$num
òò: ;
)
òò; <
{
ôô 
throw
öö 
new
öö 
ArgumentException
öö /
(
öö/ 0
$str
öö0 r
)
öör s
;
öös t
}
õõ 
if
ùù 
(
ùù 
string
ùù 
.
ùù  
IsNullOrWhiteSpace
ùù -
(
ùù- .4
&contactPerson_IdentificationTypeNumber
ùù. T
)
ùùT U
)
ùùU V
{
ûû 
throw
üü 
new
üü 
ArgumentException
üü /
(
üü/ 0
$str
üü0 s
)
üüs t
;
üüt u
}
†† 
if
¢¢ 
(
¢¢ 
string
¢¢ 
.
¢¢  
IsNullOrWhiteSpace
¢¢ -
(
¢¢- .6
(contactPerson_IdentificationTypeImageOne
¢¢. V
)
¢¢V W
)
¢¢W X
{
££ 
throw
§§ 
new
§§ 
ArgumentException
§§ /
(
§§/ 0
$str
§§0 r
)
§§r s
;
§§s t
}
•• 
}
ßß 
if
™™ 
(
™™ 
(
™™ 
int
™™ 
)
™™ 
ResidentTypeEnum
™™ %
.
™™% &

EXPATRIATE
™™& 0
==
™™1 3
residentTypeId
™™4 B
)
™™B C
{
´´ 
if
¨¨ 
(
¨¨ 
string
¨¨ 
.
¨¨  
IsNullOrWhiteSpace
¨¨ -
(
¨¨- ."
residentPermitNumber
¨¨. B
)
¨¨B C
)
¨¨C D
{
≠≠ 
throw
ÆÆ 
new
ÆÆ 
ArgumentException
ÆÆ /
(
ÆÆ/ 0
$str
ÆÆ0 `
)
ÆÆ` a
;
ÆÆa b
}
ØØ 
if
±± 
(
±± &
residentPermitDateIssued
±± ,
==
±±- /
DateTime
±±0 8
.
±±8 9
MinValue
±±9 A
)
±±A B
{
≤≤ 
throw
≥≥ 
new
≥≥ 
ArgumentException
≥≥ /
(
≥≥/ 0
$str
≥≥0 \
)
≥≥\ ]
;
≥≥] ^
}
¥¥ 
if
∂∂ 
(
∂∂ &
residentPermitExpiryDate
∂∂ ,
==
∂∂- /
DateTime
∂∂0 8
.
∂∂8 9
MinValue
∂∂9 A
)
∂∂A B
{
∑∑ 
throw
∏∏ 
new
∏∏ 
ArgumentException
∏∏ /
(
∏∏/ 0
$str
∏∏0 \
)
∏∏\ ]
;
∏∏] ^
}
ππ 
}
ªª 
if
ΩΩ 
(
ΩΩ 
titleId
ΩΩ 
>
ΩΩ 
$num
ΩΩ 
)
ΩΩ 
{
ææ 
if
øø 
(
øø 
!
øø 
await
øø #
customerDomainService
øø 0
.
øø0 1
TitleExists
øø1 <
(
øø< =
titleId
øø= D
)
øøD E
)
øøE F
throw
¿¿ 
new
¿¿ 
ArgumentException
¿¿ /
(
¿¿/ 0
$str
¿¿0 C
)
¿¿C D
;
¿¿D E
}
¡¡ 
if
√√ 
(
√√ 
genderId
√√ 
<=
√√ 
$num
√√ 
)
√√ 
{
ƒƒ 
throw
≈≈ 
new
≈≈ 
ArgumentException
≈≈ +
(
≈≈+ ,
$str
≈≈, R
)
≈≈R S
;
≈≈S T
}
∆∆ 
if
»» 
(
»» 
nationalityId
»» 
<=
»»  
$num
»»! "
)
»»" #
{
…… 
throw
   
new
   
ArgumentException
   +
(
  + ,
$str
  , W
)
  W X
;
  X Y
}
ÀÀ 
if
ÕÕ 
(
ÕÕ 
socialMediaTypeId
ÕÕ !
>
ÕÕ" #
$num
ÕÕ$ %
)
ÕÕ% &
{
ŒŒ 
if
œœ 
(
œœ 
!
œœ 
await
œœ #
customerDomainService
œœ 0
.
œœ0 1
SocialMediaExists
œœ1 B
(
œœB C
socialMediaTypeId
œœC T
)
œœT U
)
œœU V
throw
–– 
new
–– 
ArgumentException
–– /
(
––/ 0
$str
––0 O
)
––O P
;
––P Q
}
—— 
if
”” 
(
”” "
identificationTypeId
”” $
<=
””% '
$num
””( )
)
””) *
{
‘‘ 
throw
’’ 
new
’’ 
ArgumentException
’’ +
(
’’+ ,
$str
’’, _
)
’’_ `
;
’’` a
}
÷÷ 
if
ÿÿ 
(
ÿÿ 
string
ÿÿ 
.
ÿÿ  
IsNullOrWhiteSpace
ÿÿ )
(
ÿÿ) *
surName
ÿÿ* 1
)
ÿÿ1 2
||
ÿÿ3 5
string
ÿÿ6 <
.
ÿÿ< = 
IsNullOrWhiteSpace
ÿÿ= O
(
ÿÿO P

otherNames
ÿÿP Z
)
ÿÿZ [
)
ÿÿ[ \
{
ŸŸ 
throw
⁄⁄ 
new
⁄⁄ 
ArgumentException
⁄⁄ +
(
⁄⁄+ ,
$str
⁄⁄, \
)
⁄⁄\ ]
;
⁄⁄] ^
}
€€ 
if
›› 
(
›› 
dateOfBirth
›› 
==
›› 
DateTime
›› '
.
››' (
MinValue
››( 0
)
››0 1
{
ﬁﬁ 
throw
ﬂﬂ 
new
ﬂﬂ 
ArgumentException
ﬂﬂ +
(
ﬂﬂ+ ,
$str
ﬂﬂ, X
)
ﬂﬂX Y
;
ﬂﬂY Z
}
‡‡ 
if
‚‚ 
(
‚‚ 
string
‚‚ 
.
‚‚  
IsNullOrWhiteSpace
‚‚ )
(
‚‚) *
postalAddress
‚‚* 7
)
‚‚7 8
)
‚‚8 9
{
„„ 
throw
‰‰ 
new
‰‰ 
ArgumentException
‰‰ +
(
‰‰+ ,
$str
‰‰, V
)
‰‰V W
;
‰‰W X
}
ÂÂ 
if
ÁÁ 
(
ÁÁ 
string
ÁÁ 
.
ÁÁ  
IsNullOrWhiteSpace
ÁÁ )
(
ÁÁ) * 
residentialAddress
ÁÁ* <
)
ÁÁ< =
)
ÁÁ= >
{
ËË 
throw
ÈÈ 
new
ÈÈ 
ArgumentException
ÈÈ +
(
ÈÈ+ ,
$str
ÈÈ, [
)
ÈÈ[ \
;
ÈÈ\ ]
}
ÍÍ 
if
ÏÏ 
(
ÏÏ 
string
ÏÏ 
.
ÏÏ  
IsNullOrWhiteSpace
ÏÏ )
(
ÏÏ) *!
primaryMobileNumber
ÏÏ* =
)
ÏÏ= >
)
ÏÏ> ?
{
ÌÌ 
throw
ÓÓ 
new
ÓÓ 
ArgumentException
ÓÓ +
(
ÓÓ+ ,
$str
ÓÓ, ]
)
ÓÓ] ^
;
ÓÓ^ _
}
ÔÔ 
if
ÒÒ 
(
ÒÒ 
string
ÒÒ 
.
ÒÒ  
IsNullOrWhiteSpace
ÒÒ )
(
ÒÒ) *
emailAddress
ÒÒ* 6
)
ÒÒ6 7
)
ÒÒ7 8
{
ÚÚ 
throw
ÛÛ 
new
ÛÛ 
ArgumentException
ÛÛ +
(
ÛÛ+ ,
$str
ÛÛ, U
)
ÛÛU V
;
ÛÛV W
}
ÙÙ 
var
˜˜ 
customer_locality
˜˜ !
=
˜˜" #
await
˜˜$ )#
customerDomainService
˜˜* ?
.
˜˜? @ 
GetLocalityDetails
˜˜@ R
(
˜˜R S

localityId
˜˜S ]
)
˜˜] ^
;
˜˜^ _
if
˘˘ 
(
˘˘ 
customer_locality
˘˘ !
is
˘˘" $
null
˘˘% )
)
˘˘) *
{
˙˙ 
throw
˚˚ 
new
˚˚ 
ArgumentException
˚˚ +
(
˚˚+ ,
$str
˚˚, W
)
˚˚W X
;
˚˚X Y
}
¸¸ 
int
ˇˇ 
counter
ˇˇ 
=
ˇˇ 
customer_locality
ˇˇ +
.
ˇˇ+ ,!
CustomerCodeCounter
ˇˇ, ?
;
ˇˇ? @
counter
ÄÄ 
++
ÄÄ 
;
ÄÄ 
string
ÇÇ 
incrementedNumber
ÇÇ $
=
ÇÇ% &
counter
ÇÇ' .
.
ÇÇ. /
ToString
ÇÇ/ 7
(
ÇÇ7 8
$str
ÇÇ8 <
)
ÇÇ< =
;
ÇÇ= >
string
ÉÉ #
locality_customerCode
ÉÉ (
=
ÉÉ) *
customer_locality
ÉÉ+ <
.
ÉÉ< =
CustomerCode
ÉÉ= I
!
ÉÉI J
;
ÉÉJ K
string
ÑÑ 
_customercode
ÑÑ  
=
ÑÑ! "
$"
ÑÑ# %
{
ÑÑ% &#
locality_customerCode
ÑÑ& ;
}
ÑÑ; <
{
ÑÑ< =
incrementedNumber
ÑÑ= N
}
ÑÑN O
"
ÑÑO P
;
ÑÑP Q
return
áá 
new
áá 
CustomerMaster
áá %
{
àà 
CustomerMasterId
ââ  
=
ââ! "
customerMasterId
ââ# 3
,
ââ3 4
CustomerTypeId
ää 
=
ää  
customerTypeId
ää! /
,
ää/ 0
ResidentTypeId
ãã 
=
ãã  
residentTypeId
ãã! /
,
ãã/ 0

LocalityId
åå 
=
åå 

localityId
åå '
,
åå' (
CustomerCode
çç 
=
çç 
_customercode
çç ,
,
çç, -
TitleId
éé 
=
éé 
titleId
éé !
,
éé! "
SurName
èè 
=
èè 
surName
èè !
,
èè! "

OtherNames
êê 
=
êê 

otherNames
êê '
,
êê' (
CompanyName
ëë 
=
ëë 
string
ëë $
.
ëë$ %
Empty
ëë% *
,
ëë* +
DateOfBirth
íí 
=
íí 
dateOfBirth
íí )
,
íí) *
	TinNumber
ìì 
=
ìì 
	tinNumber
ìì %
,
ìì% &
Picture
îî 
=
îî 
picture
îî !
,
îî! "
GenderId
ïï 
=
ïï 
genderId
ïï #
,
ïï# $
NationalityId
ññ 
=
ññ 
nationalityId
ññ  -
,
ññ- .
PostalAddress
óó 
=
óó 
postalAddress
óó  -
,
óó- . 
ResidentialAddress
òò "
=
òò# $ 
residentialAddress
òò% 7
,
òò7 8
DigitalAddress
ôô 
=
ôô  
digitalAddress
ôô! /
,
ôô/ 0!
PrimaryMobileNumber
öö #
=
öö$ %!
primaryMobileNumber
öö& 9
,
öö9 :#
SecondaryMobileNumber
õõ %
=
õõ& '#
secondaryMobileNumber
õõ( =
,
õõ= >
OfficeNumber
úú 
=
úú 
officeNumber
úú +
,
úú+ ,
WhatsAppNumber
ùù 
=
ùù  
whatsAppNumber
ùù! /
,
ùù/ 0
EmailAddress
ûû 
=
ûû 
emailAddress
ûû +
,
ûû+ ,"
ResidentPermitNumber
üü $
=
üü% &"
residentPermitNumber
üü' ;
,
üü; <&
ResidentPermitDateIssued
†† (
=
††) *&
residentPermitDateIssued
††+ C
,
††C D&
ResidentPermitExpiryDate
°° (
=
°°) *&
residentPermitExpiryDate
°°+ C
,
°°C D
SocialMediaTypeId
¢¢ !
=
¢¢" #
socialMediaTypeId
¢¢$ 5
,
¢¢5 6 
SocialMediaAccount
££ "
=
££# $ 
socialMediaAccount
££% 7
,
££7 8"
IdentificationTypeId
§§ $
=
§§% &"
identificationTypeId
§§' ;
,
§§; <&
IdentificationTypeNumber
•• (
=
••) *&
identificationTypeNumber
••+ C
,
••C D(
IdentificationTypeImageOne
¶¶ *
=
¶¶+ ,(
identificationTypeImageOne
¶¶- G
,
¶¶G H(
IdentificationTypeImageTwo
ßß *
=
ßß+ ,(
identificationTypeImageTwo
ßß- G
,
ßßG H*
IdentificationTypeImageThree
®® ,
=
®®- .*
identificationTypeImageThree
®®/ K
,
®®K L)
IdentificationTypeImageFour
©© +
=
©©, -)
identificationTypeImageFour
©©. I
,
©©I J)
IdentificationTypeImageFive
™™ +
=
™™, -)
identificationTypeImageFive
™™. I
,
™™I J
Comments
´´ 
=
´´ 
comments
´´ #
,
´´# $
InterestExpressed
¨¨ !
=
¨¨" #
interestExpressed
¨¨$ 5
,
¨¨5 6
DebtorStatus
≠≠ 
=
≠≠ 
debtorStatus
≠≠ +
,
≠≠+ ,

ParentCode
ÆÆ 
=
ÆÆ 

parentCode
ÆÆ '
,
ÆÆ' ($
ContactPerson_FullName
ØØ &
=
ØØ' ($
contactPerson_FullName
ØØ) ?
,
ØØ? @'
ContactPerson_PhoneNumber
∞∞ )
=
∞∞* +'
contactPerson_PhoneNumber
∞∞, E
,
∞∞E F(
ContactPerson_EmailAddress
±± *
=
±±+ ,(
contactPerson_EmailAddress
±±- G
,
±±G H#
ContactPerson_Address
≤≤ %
=
≤≤& '#
contactPerson_Address
≤≤( =
,
≤≤= >0
"ContactPerson_IdentificationTypeId
≥≥ 2
=
≥≥3 40
"contactPerson_IdentificationTypeId
≥≥5 W
,
≥≥W X4
&ContactPerson_IdentificationTypeNumber
¥¥ 6
=
¥¥7 84
&contactPerson_IdentificationTypeNumber
¥¥9 _
,
¥¥_ `6
(ContactPerson_IdentificationTypeImageOne
µµ 8
=
µµ9 :6
(contactPerson_IdentificationTypeImageOne
µµ; c
,
µµc d6
(ContactPerson_IdentificationTypeImageTwo
∂∂ 8
=
∂∂9 :6
(contactPerson_IdentificationTypeImageTwo
∂∂; c
,
∂∂c d
	IsDeleted
∑∑ 
=
∑∑ 
false
∑∑ !
,
∑∑! "
	IsPrimary
∏∏ 
=
∏∏ 
true
∏∏  
,
∏∏  !
MaritalStatus
ππ 
=
ππ 
string
ππ  &
.
ππ& '
Empty
ππ' ,
,
ππ, -
DateOfMarriage
∫∫ 
=
∫∫  
Convert
∫∫! (
.
∫∫( )

ToDateTime
∫∫) 3
(
∫∫3 4
$str
∫∫4 @
)
∫∫@ A
}
ªª 
;
ªª 
}
ºº 	
public
¡¡ 
static
¡¡ 
async
¡¡ 
Task
¡¡  
<
¡¡  !
CustomerMaster
¡¡! /
>
¡¡/ 0
CreateJointAsync
¡¡1 A
(
¡¡A B
int
¡¡B E
customerMasterId
¡¡F V
,
¡¡V W
int
¡¡X [
customerTypeId
¡¡\ j
,
¡¡j k
int
¡¡l o
residentTypeId
¡¡p ~
,
¡¡~ 
int¡¡Ä É

localityId¡¡Ñ é
,¡¡é è
string¡¡ê ñ
customerCode¡¡ó £
,¡¡£ §
int¡¡• ®
titleId¡¡© ∞
,¡¡∞ ±
string¡¡≤ ∏
surName¡¡π ¿
,¡¡¿ ¡
string¡¡¬ »

otherNames¡¡… ”
,¡¡” ‘
DateTime¡¡’ ›
dateOfBirth¡¡ﬁ È
,¡¡È Í
string¡¡Î Ò
	tinNumber¡¡Ú ˚
,¡¡˚ ¸
string¡¡˝ É
picture¡¡Ñ ã
,¡¡ã å
int¡¡ç ê
genderId¡¡ë ô
,¡¡ô ö
int
¬¬? B
nationalityId
¬¬C P
,
¬¬P Q
string
¬¬R X
postalAddress
¬¬Y f
,
¬¬f g
string
¬¬h n!
residentialAddress¬¬o Å
,¬¬Å Ç
string¬¬É â
digitalAddress¬¬ä ò
,¬¬ò ô
string¬¬ö †#
primaryMobileNumber¬¬° ¥
,¬¬¥ µ
string¬¬∂ º%
secondaryMobileNumber¬¬Ω “
,¬¬“ ”
string¬¬‘ ⁄
officeNumber¬¬€ Á
,¬¬Á Ë
string¬¬È Ô
whatsAppNumber¬¬ ˛
,¬¬˛ ˇ
string¬¬Ä Ü
emailAddress¬¬á ì
,¬¬ì î
string
√√? E"
residentPermitNumber
√√F Z
,
√√Z [
DateTime
√√\ d
?
√√d e&
residentPermitDateIssued
√√f ~
,
√√~ 
DateTime√√Ä à
?√√à â(
residentPermitExpiryDate√√ä ¢
,√√¢ £
int√√§ ß!
socialMediaTypeId√√® π
,√√π ∫
string√√ª ¡"
socialMediaAccount√√¬ ‘
,√√‘ ’
int√√÷ Ÿ$
identificationTypeId√√⁄ Ó
,√√Ó Ô
string√√ ˆ(
identificationTypeNumber√√˜ è
,√√è ê
string
ƒƒ? E(
identificationTypeImageOne
ƒƒF `
,
ƒƒ` a
string
ƒƒb h)
identificationTypeImageTwoƒƒi É
,ƒƒÉ Ñ
stringƒƒÖ ã,
identificationTypeImageThreeƒƒå ®
,ƒƒ® ©
stringƒƒ™ ∞+
identificationTypeImageFourƒƒ± Ã
,ƒƒÃ Õ
stringƒƒŒ ‘+
identificationTypeImageFiveƒƒ’ 
,ƒƒ Ò
stringƒƒÚ ¯
commentsƒƒ˘ Å
,ƒƒÅ Ç
stringƒƒÉ â!
interestExpressedƒƒä õ
,ƒƒõ ú
intƒƒù †
debtorStatusƒƒ° ≠
,ƒƒ≠ Æ
stringƒƒØ µ

parentCodeƒƒ∂ ¿
,ƒƒ¿ ¡
stringƒƒ¬ »&
contactPerson_FullNameƒƒ… ﬂ
,ƒƒﬂ ‡
stringƒƒ· Á)
contactPerson_PhoneNumberƒƒË Å
,ƒƒÅ Ç
string
≈≈? E(
contactPerson_EmailAddress
≈≈F `
,
≈≈` a
string
≈≈b h#
contactPerson_Address
≈≈i ~
,
≈≈~ 
int≈≈Ä É2
"contactPerson_IdentificationTypeId≈≈Ñ ¶
,≈≈¶ ß
string≈≈® Æ6
&contactPerson_IdentificationTypeNumber≈≈Ø ’
,≈≈’ ÷
string≈≈◊ ›8
(contactPerson_IdentificationTypeImageOne≈≈ﬁ Ü
,≈≈Ü á
string
∆∆? E6
(contactPerson_IdentificationTypeImageTwo
∆∆F n
,
∆∆n o
bool
∆∆p t
	isDeleted
∆∆u ~
,
∆∆~ 
bool∆∆Ä Ñ
	isPrimary∆∆Ö é
,∆∆é è
string∆∆ê ñ
maritalStatus∆∆ó §
,∆∆§ •
DateTime∆∆¶ Æ
?∆∆Æ Ø
dateOfMarriage∆∆∞ æ
,∆∆æ ø&
ICustomerDomainService∆∆¿ ÷%
customerDomainService∆∆◊ Ï
)∆∆Ï Ì
{
«« 	
if
»» 
(
»» 
customerTypeId
»» 
<=
»» !
$num
»»" #
||
»»$ &
residentTypeId
»»' 5
<=
»»6 8
$num
»»9 :
||
»»; =

localityId
»»> H
<=
»»I K
$num
»»L M
||
»»N P
nationalityId
»»Q ^
<=
»»_ a
$num
»»b c
||
»»d f"
identificationTypeId
»»g {
<=
»»| ~
$num»» Ä
||»»Å É
string»»Ñ ä
.»»ä ã"
IsNullOrWhiteSpace»»ã ù
(»»ù û
surName»»û •
)»»• ¶
||»»ß ©
string»»™ ∞
.»»∞ ±"
IsNullOrWhiteSpace»»± √
(»»√ ƒ

otherNames»»ƒ Œ
)»»Œ œ
||»»– “
string»»” Ÿ
.»»Ÿ ⁄"
IsNullOrWhiteSpace»»⁄ Ï
(»»Ï Ì(
identificationTypeNumber»»Ì Ö
)»»Ö Ü
||»»á â
string»»ä ê
.»»ê ë"
IsNullOrWhiteSpace»»ë £
(»»£ §#
primaryMobileNumber»»§ ∑
)»»∑ ∏
||»»π ª
string»»º ¬
.»»¬ √"
IsNullOrWhiteSpace»»√ ’
(»»’ ÷
emailAddress»»÷ ‚
)»»‚ „
)»»„ ‰
{
…… 
throw
   
new
   
ArgumentException
   +
(
  + ,
$str
  , Q
)
  Q R
;
  R S
}
ÀÀ 
if
ÕÕ 
(
ÕÕ 
!
ÕÕ 
await
ÕÕ #
customerDomainService
ÕÕ ,
.
ÕÕ, - 
CustomerTypeExists
ÕÕ- ?
(
ÕÕ? @
customerTypeId
ÕÕ@ N
)
ÕÕN O
)
ÕÕO P
throw
ŒŒ 
new
ŒŒ 
ArgumentException
ŒŒ +
(
ŒŒ+ ,
$str
ŒŒ, G
)
ŒŒG H
;
ŒŒH I
if
–– 
(
–– 
!
–– 
await
–– #
customerDomainService
–– ,
.
––, - 
ResidentTypeExists
––- ?
(
––? @
residentTypeId
––@ N
)
––N O
)
––O P
throw
—— 
new
—— 
ArgumentException
—— +
(
——+ ,
$str
——, G
)
——G H
;
——H I
if
”” 
(
”” 
!
”” 
await
”” #
customerDomainService
”” ,
.
””, -
LocalityExists
””- ;
(
””; <

localityId
””< F
)
””F G
)
””G H
throw
‘‘ 
new
‘‘ 
ArgumentException
‘‘ +
(
‘‘+ ,
$str
‘‘, B
)
‘‘B C
;
‘‘C D
if
÷÷ 
(
÷÷ 
!
÷÷ 
await
÷÷ #
customerDomainService
÷÷ ,
.
÷÷, -
GenderExists
÷÷- 9
(
÷÷9 :
genderId
÷÷: B
)
÷÷B C
)
÷÷C D
throw
◊◊ 
new
◊◊ 
ArgumentException
◊◊ +
(
◊◊+ ,
$str
◊◊, @
)
◊◊@ A
;
◊◊A B
if
ŸŸ 
(
ŸŸ 
!
ŸŸ 
await
ŸŸ #
customerDomainService
ŸŸ ,
.
ŸŸ, -
NationalityExists
ŸŸ- >
(
ŸŸ> ?
nationalityId
ŸŸ? L
)
ŸŸL M
)
ŸŸM N
throw
⁄⁄ 
new
⁄⁄ 
ArgumentException
⁄⁄ +
(
⁄⁄+ ,
$str
⁄⁄, E
)
⁄⁄E F
;
⁄⁄F G
if
‹‹ 
(
‹‹ 
!
‹‹ 
await
‹‹ #
customerDomainService
‹‹ ,
.
‹‹, -&
IdentificationTypeExists
‹‹- E
(
‹‹E F"
identificationTypeId
‹‹F Z
)
‹‹Z [
)
‹‹[ \
throw
›› 
new
›› 
ArgumentException
›› +
(
››+ ,
$str
››, M
)
››M N
;
››N O
if
‡‡ 
(
‡‡ 
(
‡‡ 
int
‡‡ 
)
‡‡ 
ResidentTypeEnum
‡‡ %
.
‡‡% &
NON_RESIDENT
‡‡& 2
==
‡‡3 5
residentTypeId
‡‡6 D
)
‡‡D E
{
·· 
if
‚‚ 
(
‚‚ 
string
‚‚ 
.
‚‚  
IsNullOrWhiteSpace
‚‚ -
(
‚‚- .$
contactPerson_FullName
‚‚. D
)
‚‚D E
)
‚‚E F
{
„„ 
throw
‰‰ 
new
‰‰ 
ArgumentException
‰‰ /
(
‰‰/ 0
$str
‰‰0 c
)
‰‰c d
;
‰‰d e
}
ÂÂ 
if
ÁÁ 
(
ÁÁ 
string
ÁÁ 
.
ÁÁ  
IsNullOrWhiteSpace
ÁÁ -
(
ÁÁ- .'
contactPerson_PhoneNumber
ÁÁ. G
)
ÁÁG H
)
ÁÁH I
{
ËË 
throw
ÈÈ 
new
ÈÈ 
ArgumentException
ÈÈ /
(
ÈÈ/ 0
$str
ÈÈ0 e
)
ÈÈe f
;
ÈÈf g
}
ÍÍ 
if
ÏÏ 
(
ÏÏ 
string
ÏÏ 
.
ÏÏ  
IsNullOrWhiteSpace
ÏÏ -
(
ÏÏ- .(
contactPerson_EmailAddress
ÏÏ. H
)
ÏÏH I
)
ÏÏI J
{
ÌÌ 
throw
ÓÓ 
new
ÓÓ 
ArgumentException
ÓÓ /
(
ÓÓ/ 0
$str
ÓÓ0 f
)
ÓÓf g
;
ÓÓg h
}
ÔÔ 
if
ÒÒ 
(
ÒÒ 
string
ÒÒ 
.
ÒÒ  
IsNullOrWhiteSpace
ÒÒ -
(
ÒÒ- .#
contactPerson_Address
ÒÒ. C
)
ÒÒC D
)
ÒÒD E
{
ÚÚ 
throw
ÛÛ 
new
ÛÛ 
ArgumentException
ÛÛ /
(
ÛÛ/ 0
$str
ÛÛ0 `
)
ÛÛ` a
;
ÛÛa b
}
ÙÙ 
if
ˆˆ 
(
ˆˆ 0
"contactPerson_IdentificationTypeId
ˆˆ 6
<=
ˆˆ7 9
$num
ˆˆ: ;
)
ˆˆ; <
{
˜˜ 
throw
¯¯ 
new
¯¯ 
ArgumentException
¯¯ /
(
¯¯/ 0
$str
¯¯0 r
)
¯¯r s
;
¯¯s t
}
˘˘ 
if
˚˚ 
(
˚˚ 
string
˚˚ 
.
˚˚  
IsNullOrWhiteSpace
˚˚ -
(
˚˚- .4
&contactPerson_IdentificationTypeNumber
˚˚. T
)
˚˚T U
)
˚˚U V
{
¸¸ 
throw
˝˝ 
new
˝˝ 
ArgumentException
˝˝ /
(
˝˝/ 0
$str
˝˝0 s
)
˝˝s t
;
˝˝t u
}
˛˛ 
if
ÅÅ 
(
ÅÅ 
string
ÅÅ 
.
ÅÅ  
IsNullOrWhiteSpace
ÅÅ -
(
ÅÅ- .6
(contactPerson_IdentificationTypeImageOne
ÅÅ. V
)
ÅÅV W
)
ÅÅW X
{
ÇÇ 
throw
ÉÉ 
new
ÉÉ 
ArgumentException
ÉÉ /
(
ÉÉ/ 0
$str
ÉÉ0 r
)
ÉÉr s
;
ÉÉs t
}
ÑÑ 
}
ÜÜ 
if
ââ 
(
ââ 
(
ââ 
int
ââ 
)
ââ 
ResidentTypeEnum
ââ %
.
ââ% &

EXPATRIATE
ââ& 0
==
ââ1 3
residentTypeId
ââ4 B
)
ââB C
{
ää 
if
ãã 
(
ãã 
string
ãã 
.
ãã  
IsNullOrWhiteSpace
ãã -
(
ãã- ."
residentPermitNumber
ãã. B
)
ããB C
)
ããC D
{
åå 
throw
çç 
new
çç 
ArgumentException
çç /
(
çç/ 0
$str
çç0 `
)
çç` a
;
çça b
}
éé 
if
êê 
(
êê &
residentPermitDateIssued
êê ,
==
êê- /
DateTime
êê0 8
.
êê8 9
MinValue
êê9 A
)
êêA B
{
ëë 
throw
íí 
new
íí 
ArgumentException
íí /
(
íí/ 0
$str
íí0 \
)
íí\ ]
;
íí] ^
}
ìì 
if
ïï 
(
ïï &
residentPermitExpiryDate
ïï ,
==
ïï- /
DateTime
ïï0 8
.
ïï8 9
MinValue
ïï9 A
)
ïïA B
{
ññ 
throw
óó 
new
óó 
ArgumentException
óó /
(
óó/ 0
$str
óó0 \
)
óó\ ]
;
óó] ^
}
òò 
}
öö 
if
úú 
(
úú 
titleId
úú 
>
úú 
$num
úú 
)
úú 
{
ùù 
if
ûû 
(
ûû 
!
ûû 
await
ûû #
customerDomainService
ûû 0
.
ûû0 1
TitleExists
ûû1 <
(
ûû< =
titleId
ûû= D
)
ûûD E
)
ûûE F
throw
üü 
new
üü 
ArgumentException
üü /
(
üü/ 0
$str
üü0 C
)
üüC D
;
üüD E
}
†† 
if
¢¢ 
(
¢¢ 
genderId
¢¢ 
<=
¢¢ 
$num
¢¢ 
)
¢¢ 
{
££ 
throw
§§ 
new
§§ 
ArgumentException
§§ +
(
§§+ ,
$str
§§, R
)
§§R S
;
§§S T
}
•• 
if
ßß 
(
ßß 
nationalityId
ßß 
<=
ßß  
$num
ßß! "
)
ßß" #
{
®® 
throw
©© 
new
©© 
ArgumentException
©© +
(
©©+ ,
$str
©©, W
)
©©W X
;
©©X Y
}
™™ 
if
¨¨ 
(
¨¨ 
socialMediaTypeId
¨¨ !
>
¨¨" #
$num
¨¨$ %
)
¨¨% &
{
≠≠ 
if
ÆÆ 
(
ÆÆ 
!
ÆÆ 
await
ÆÆ #
customerDomainService
ÆÆ 0
.
ÆÆ0 1
SocialMediaExists
ÆÆ1 B
(
ÆÆB C
socialMediaTypeId
ÆÆC T
)
ÆÆT U
)
ÆÆU V
throw
ØØ 
new
ØØ 
ArgumentException
ØØ /
(
ØØ/ 0
$str
ØØ0 O
)
ØØO P
;
ØØP Q
}
∞∞ 
if
≤≤ 
(
≤≤ "
identificationTypeId
≤≤ $
<=
≤≤% '
$num
≤≤( )
)
≤≤) *
{
≥≥ 
throw
¥¥ 
new
¥¥ 
ArgumentException
¥¥ +
(
¥¥+ ,
$str
¥¥, _
)
¥¥_ `
;
¥¥` a
}
µµ 
if
∑∑ 
(
∑∑ 
string
∑∑ 
.
∑∑  
IsNullOrWhiteSpace
∑∑ )
(
∑∑) *
surName
∑∑* 1
)
∑∑1 2
||
∑∑3 5
string
∑∑6 <
.
∑∑< = 
IsNullOrWhiteSpace
∑∑= O
(
∑∑O P

otherNames
∑∑P Z
)
∑∑Z [
)
∑∑[ \
{
∏∏ 
throw
ππ 
new
ππ 
ArgumentException
ππ +
(
ππ+ ,
$str
ππ, \
)
ππ\ ]
;
ππ] ^
}
∫∫ 
if
ºº 
(
ºº 
dateOfBirth
ºº 
==
ºº 
DateTime
ºº '
.
ºº' (
MinValue
ºº( 0
)
ºº0 1
{
ΩΩ 
throw
ææ 
new
ææ 
ArgumentException
ææ +
(
ææ+ ,
$str
ææ, X
)
ææX Y
;
ææY Z
}
øø 
if
¡¡ 
(
¡¡ 
string
¡¡ 
.
¡¡  
IsNullOrWhiteSpace
¡¡ )
(
¡¡) *
postalAddress
¡¡* 7
)
¡¡7 8
)
¡¡8 9
{
¬¬ 
throw
√√ 
new
√√ 
ArgumentException
√√ +
(
√√+ ,
$str
√√, V
)
√√V W
;
√√W X
}
ƒƒ 
if
∆∆ 
(
∆∆ 
string
∆∆ 
.
∆∆  
IsNullOrWhiteSpace
∆∆ )
(
∆∆) * 
residentialAddress
∆∆* <
)
∆∆< =
)
∆∆= >
{
«« 
throw
»» 
new
»» 
ArgumentException
»» +
(
»»+ ,
$str
»», [
)
»»[ \
;
»»\ ]
}
…… 
if
ÀÀ 
(
ÀÀ 
string
ÀÀ 
.
ÀÀ  
IsNullOrWhiteSpace
ÀÀ )
(
ÀÀ) *!
primaryMobileNumber
ÀÀ* =
)
ÀÀ= >
)
ÀÀ> ?
{
ÃÃ 
throw
ÕÕ 
new
ÕÕ 
ArgumentException
ÕÕ +
(
ÕÕ+ ,
$str
ÕÕ, ]
)
ÕÕ] ^
;
ÕÕ^ _
}
ŒŒ 
if
–– 
(
–– 
string
–– 
.
––  
IsNullOrWhiteSpace
–– )
(
––) *
emailAddress
––* 6
)
––6 7
)
––7 8
{
—— 
throw
““ 
new
““ 
ArgumentException
““ +
(
““+ ,
$str
““, U
)
““U V
;
““V W
}
”” 
var
÷÷ 
customer_locality
÷÷ !
=
÷÷" #
await
÷÷$ )#
customerDomainService
÷÷* ?
.
÷÷? @ 
GetLocalityDetails
÷÷@ R
(
÷÷R S

localityId
÷÷S ]
)
÷÷] ^
;
÷÷^ _
if
ÿÿ 
(
ÿÿ 
customer_locality
ÿÿ !
is
ÿÿ" $
null
ÿÿ% )
)
ÿÿ) *
{
ŸŸ 
throw
⁄⁄ 
new
⁄⁄ 
ArgumentException
⁄⁄ +
(
⁄⁄+ ,
$str
⁄⁄, W
)
⁄⁄W X
;
⁄⁄X Y
}
€€ 
int
ﬁﬁ 
counter
ﬁﬁ 
=
ﬁﬁ 
customer_locality
ﬁﬁ +
.
ﬁﬁ+ ,!
CustomerCodeCounter
ﬁﬁ, ?
;
ﬁﬁ? @
counter
ﬂﬂ 
++
ﬂﬂ 
;
ﬂﬂ 
string
·· 
incrementedNumber
·· $
=
··% &
counter
··' .
.
··. /
ToString
··/ 7
(
··7 8
$str
··8 <
)
··< =
;
··= >
string
‚‚ #
locality_customerCode
‚‚ (
=
‚‚) *
customer_locality
‚‚+ <
.
‚‚< =
CustomerCode
‚‚= I
!
‚‚I J
;
‚‚J K
string
„„ 
_customercode
„„  
=
„„! "
$"
„„# %
{
„„% &#
locality_customerCode
„„& ;
}
„„; <
{
„„< =
incrementedNumber
„„= N
}
„„N O
"
„„O P
;
„„P Q
return
ÊÊ 
new
ÊÊ 
CustomerMaster
ÊÊ %
{
ÁÁ 
CustomerMasterId
ËË  
=
ËË! "
customerMasterId
ËË# 3
,
ËË3 4
CustomerTypeId
ÈÈ 
=
ÈÈ  
customerTypeId
ÈÈ! /
,
ÈÈ/ 0
ResidentTypeId
ÍÍ 
=
ÍÍ  
residentTypeId
ÍÍ! /
,
ÍÍ/ 0

LocalityId
ÎÎ 
=
ÎÎ 

localityId
ÎÎ '
,
ÎÎ' (
CustomerCode
ÏÏ 
=
ÏÏ 
_customercode
ÏÏ ,
,
ÏÏ, -
TitleId
ÌÌ 
=
ÌÌ 
titleId
ÌÌ !
,
ÌÌ! "
SurName
ÓÓ 
=
ÓÓ 
surName
ÓÓ !
,
ÓÓ! "

OtherNames
ÔÔ 
=
ÔÔ 

otherNames
ÔÔ '
,
ÔÔ' (
CompanyName
 
=
 
string
 $
.
$ %
Empty
% *
,
* +
DateOfBirth
ÒÒ 
=
ÒÒ 
dateOfBirth
ÒÒ )
,
ÒÒ) *
	TinNumber
ÚÚ 
=
ÚÚ 
	tinNumber
ÚÚ %
,
ÚÚ% &
Picture
ÛÛ 
=
ÛÛ 
picture
ÛÛ !
,
ÛÛ! "
GenderId
ÙÙ 
=
ÙÙ 
genderId
ÙÙ #
,
ÙÙ# $
NationalityId
ıı 
=
ıı 
nationalityId
ıı  -
,
ıı- .
PostalAddress
ˆˆ 
=
ˆˆ 
postalAddress
ˆˆ  -
,
ˆˆ- . 
ResidentialAddress
˜˜ "
=
˜˜# $ 
residentialAddress
˜˜% 7
,
˜˜7 8
DigitalAddress
¯¯ 
=
¯¯  
digitalAddress
¯¯! /
,
¯¯/ 0!
PrimaryMobileNumber
˘˘ #
=
˘˘$ %!
primaryMobileNumber
˘˘& 9
,
˘˘9 :#
SecondaryMobileNumber
˙˙ %
=
˙˙& '#
secondaryMobileNumber
˙˙( =
,
˙˙= >
OfficeNumber
˚˚ 
=
˚˚ 
officeNumber
˚˚ +
,
˚˚+ ,
WhatsAppNumber
¸¸ 
=
¸¸  
whatsAppNumber
¸¸! /
,
¸¸/ 0
EmailAddress
˝˝ 
=
˝˝ 
emailAddress
˝˝ +
,
˝˝+ ,"
ResidentPermitNumber
˛˛ $
=
˛˛% &"
residentPermitNumber
˛˛' ;
,
˛˛; <&
ResidentPermitDateIssued
ˇˇ (
=
ˇˇ) *&
residentPermitDateIssued
ˇˇ+ C
,
ˇˇC D&
ResidentPermitExpiryDate
ÄÄ (
=
ÄÄ) *&
residentPermitExpiryDate
ÄÄ+ C
,
ÄÄC D
SocialMediaTypeId
ÅÅ !
=
ÅÅ" #
socialMediaTypeId
ÅÅ$ 5
,
ÅÅ5 6 
SocialMediaAccount
ÇÇ "
=
ÇÇ# $ 
socialMediaAccount
ÇÇ% 7
,
ÇÇ7 8"
IdentificationTypeId
ÉÉ $
=
ÉÉ% &"
identificationTypeId
ÉÉ' ;
,
ÉÉ; <&
IdentificationTypeNumber
ÑÑ (
=
ÑÑ) *&
identificationTypeNumber
ÑÑ+ C
,
ÑÑC D(
IdentificationTypeImageOne
ÖÖ *
=
ÖÖ+ ,(
identificationTypeImageOne
ÖÖ- G
,
ÖÖG H(
IdentificationTypeImageTwo
ÜÜ *
=
ÜÜ+ ,(
identificationTypeImageTwo
ÜÜ- G
,
ÜÜG H*
IdentificationTypeImageThree
áá ,
=
áá- .*
identificationTypeImageThree
áá/ K
,
ááK L)
IdentificationTypeImageFour
àà +
=
àà, -)
identificationTypeImageFour
àà. I
,
ààI J)
IdentificationTypeImageFive
ââ +
=
ââ, -)
identificationTypeImageFive
ââ. I
,
ââI J
Comments
ää 
=
ää 
comments
ää #
,
ää# $
InterestExpressed
ãã !
=
ãã" #
interestExpressed
ãã$ 5
,
ãã5 6
DebtorStatus
åå 
=
åå 
debtorStatus
åå +
,
åå+ ,

ParentCode
çç 
=
çç 

parentCode
çç '
,
çç' ($
ContactPerson_FullName
éé &
=
éé' ($
contactPerson_FullName
éé) ?
,
éé? @'
ContactPerson_PhoneNumber
èè )
=
èè* +'
contactPerson_PhoneNumber
èè, E
,
èèE F(
ContactPerson_EmailAddress
êê *
=
êê+ ,(
contactPerson_EmailAddress
êê- G
,
êêG H#
ContactPerson_Address
ëë %
=
ëë& '#
contactPerson_Address
ëë( =
,
ëë= >0
"ContactPerson_IdentificationTypeId
íí 2
=
íí3 40
"contactPerson_IdentificationTypeId
íí5 W
,
ííW X4
&ContactPerson_IdentificationTypeNumber
ìì 6
=
ìì7 84
&contactPerson_IdentificationTypeNumber
ìì9 _
,
ìì_ `6
(ContactPerson_IdentificationTypeImageOne
îî 8
=
îî9 :6
(contactPerson_IdentificationTypeImageOne
îî; c
,
îîc d6
(ContactPerson_IdentificationTypeImageTwo
ïï 8
=
ïï9 :6
(contactPerson_IdentificationTypeImageTwo
ïï; c
,
ïïc d
	IsDeleted
ññ 
=
ññ 
false
ññ !
,
ññ! "
	IsPrimary
óó 
=
óó 
	isPrimary
óó %
,
óó% &
MaritalStatus
òò 
=
òò 
maritalStatus
òò  -
,
òò- .
DateOfMarriage
ôô 
=
ôô  
dateOfMarriage
ôô! /
}
öö 
;
öö 
}
õõ 	
public
«« 
void
«« 
Delete
«« 
(
«« 
string
«« !
	deletedBy
««" +
,
««+ ,
string
««- 3
reason
««4 :
)
««: ;
{
»» 	
	IsDeleted
…… 
=
…… 
true
…… 
;
…… 

ModifiedOn
   
=
   
DateTime
   !
.
  ! "
UtcNow
  " (
;
  ( )
_domainEvents
ÃÃ 
.
ÃÃ 
Add
ÃÃ 
(
ÃÃ 
new
ÃÃ !"
CustomerDeletedEvent
ÃÃ" 6
(
ÃÃ6 7
CustomerMasterId
ÕÕ  
,
ÕÕ  !
CustomerCode
ŒŒ 
,
ŒŒ 
	deletedBy
œœ 
,
œœ 
reason
–– 
)
–– 
)
–– 
;
–– 
}
—— 	
public
”” 
void
”” 
ClearDomainEvents
”” %
(
””% &
)
””& '
{
‘‘ 	
_domainEvents
’’ 
.
’’ 
Clear
’’ 
(
’’  
)
’’  !
;
’’! "
}
÷÷ 	
}
◊◊ 
}ÿÿ â
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Management/StopDebit.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class 
	StopDebit 
{ 
[ 	
Key	 
] 
public 
int 
StopDebitId 
{  
get! $
;$ %
set& )
;) *
}+ ,
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
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PropertyNumber %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Reasons 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 
DebtorStatus 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime 
ActionOn  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ActionBy 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} Û
Ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Management/ActivityTransactions.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
.) *

Management* 4
{ 
public 
class  
ActivityTransactions "
{ 
[ 
Key 
] 
public 
int	 !
ActivityTransactionId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public		 
string			 
?		 
CustomerCode		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public 
string	 
? 
PropertyNumber 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime	 
ActivityDate 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int	 

ActivityId 
{ 
get 
; 
set "
;" #
}$ %
public 
int	 
ActivityTypeId 
{ 
get !
;! "
set# &
;& '
}( )
public 
string	 
? 
Comments 
{ 
get 
;  
set! $
;$ %
}& '
public  
ActivityTransactions	 
( 
) 
{ 
} 
} 
} ™
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/AuditableEntity.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
Entities! )
;) *
public 
class 
AuditableEntity 
{ 
public 

DateTime 
	CreatedOn 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
? 
	CreatedBy 
{ 
get "
;" #
set$ '
;' (
}) *
public 

DateTime 

ModifiedOn 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 

string		 
?		 

ModifiedBy		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public

 

DateTime

 
	DeletedOn

 
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
* +
public 

string 
? 
	DeletedBy 
{ 
get "
;" #
set$ '
;' (
}) *
} 
public 
class 

BaseEntity 
: 
AuditableEntity )
{ 
public 

DateTime 

ApprovedOn 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

string 
? 

ApprovedBy 
{ 
get  #
;# $
set% (
;( )
}* +
} Å
s/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Constants/ErrorMessages.cs
	namespace 	
Modules
 
. 
Estates 
. 
Domain  
.  !
	Constants! *
{ 
public 

static 
class 
ErrorMessages %
{ 
public 
const 
string !
InvalidCustomerTypeId 1
=2 3
$str4 O
;O P
public 
const 
string !
InvalidResidentTypeId 1
=2 3
$str4 O
;O P
public 
const 
string 
InvalidLocalityId -
=. /
$str0 F
;F G
public 
const 
string 
InvalidGenderId +
=, -
$str. B
;B C
public		 
const		 
string		  
InvalidNationalityId		 0
=		1 2
$str		3 L
;		L M
public

 
const

 
string

 
InvalidTitleId

 *
=

+ ,
$str

- @
;

@ A
public 
const 
string $
InvalidSocialMediaTypeId 4
=5 6
$str7 V
;V W
public 
const 
string '
InvalidIdentificationTypeId 7
=8 9
$str: [
;[ \
} 
} 