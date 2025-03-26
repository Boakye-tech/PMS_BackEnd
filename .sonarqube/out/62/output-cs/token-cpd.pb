�
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/ResidentPermit.cs
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
} �
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/Identification.cs
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
} �
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
}$$ �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Customer/ContactInformation.cs
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
}"" �
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
b/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Usings.cs�
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Registration/IPropertyMasterRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Registration/ICustomerMasterRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Management/IStopDebitRepository.cs
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
 �
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
}.. �
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
}!! �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPropertyTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPropertyHeightRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IPlotSizeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILocalityRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILandUseTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/ILandUseRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IFloorNumberingRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IFacilitiesRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockUnitRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockSidesRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockPurchaseTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IBlockNumberRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IApartmentTypesRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IAllocationTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IActivityTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Property/IActivityRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ITitleRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ISocialMediaRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IResidentTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IOwnershipTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/INationalityRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IIdentificationTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/IGenderRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/Entities/Setup/Customer/ICustomerTypeRepository.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/DomainServices/IPropertyDomainService.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/DomainServices/ICustomerDomainService.cs
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
} �
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
}		 �
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerUpdatedEvent.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerStatusChangedEvent.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerDeletedEvent.cs
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Events/Customer/CustomerCreatedEvent.cs
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
} �
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
} �
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ShopOfficeTypeAndDescription.cs
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
 �"
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyType.cs
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
}44 �#
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyHeight.cs
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
}77 �!
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
}44 �L
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
customerCodeCounter	m �
)
� �
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
customerCodeCounter	!!x �
)
!!� �
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
customerCode	## �
)
##� �
||
##� �

localityId
##� �
<
##� �
$num
##� �
)
##� �
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
customerCodeCounter	DDw �
)
DD� �
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
customerCode	FF �
)
FF� �
||
FF� �

localityId
FF� �
<
FF� �
$num
FF� �
||
FF� �!
customerCodeCounter
FF� �
<
FF� �
$num
FF� �
)
FF� �
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
}gg �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LeaseTypeAndPeriod.cs
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
 �=
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
landUseTypeId	| �
<
� �
$num
� �
)
� �
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
landUseTypeId	>>| �
<
>>� �
$num
>>� �
)
>>� �
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
}ZZ �3
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
}[[ �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/HouseTypeAndDescription.cs
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
 �"
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/FloorNumbering.cs
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
}44 �!
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
}55 �!
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
}66 �"
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
}66 �!
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
}44 �!
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
}66 �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/BlockPurchaseType.cs
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
} �"
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
}88 �@
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentTypes.cs
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
double	!!{ �
	floorArea
!!� �
)
!!� �
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
	floorArea	##| �
<=
##� �
$num
##� �
)
##� �
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
double	DD{ �
	floorArea
DD� �
)
DD� �
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
	floorArea	FF| �
<=
FF� �
$num
FF� �
)
FF� �
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
}kk �

�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentFacilities.cs
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
} �3
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/AllocationType.cs
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
<	 �
$num
� �
)
� �
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
<	22 �
$num
22� �
)
22� �
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
}CC �#
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ActivityType.cs
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
activityTypeDescription	  o �
)
  � �
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
}:: �
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
}// �!
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
}44 �#
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
}55 �"
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/ResidentType.cs
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
}77 �$
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/OwnershipType.cs
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
}:: �!
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
}55 �"
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
}77 �$
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/IdentificationType.cs
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
}22 �#
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Customer/CustomerType.cs
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
}:: �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/PropertyMaster.cs
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
string	z �
blockNumber
� �
,
� �
string
� �

plotNumber
� �
,
� �
double
� �

acreageOne
� �
,
� �
double
� �

acreageTwo
� �
,
� �
int
� �
propertyHeightId
� �
,
� �
int
� �

plotSizeId
� �
,
� �
string
� �
sitePlanNumber
� �
,
� �
bool
� �
isLargeScale
� �
=
� �
false
� �
)
� �
{
�� 	
}
�� 	
public
�� 
static
�� 
PropertyMaster
�� $
Create
��% +
(
��+ ,
int
��, /
propertyMasterId
��0 @
,
��@ A
int
��B E
propertyTypeId
��F T
,
��T U
string
��V \
landUseInitial
��] k
,
��k l
int
��m p
	landUseId
��q z
,
��z {
string��| �"
landUseTypeInitial��� �
,��� �
int��� �
landUseTypeId��� �
,��� �
string��� �
localityInitial��� �
,��� �
int��� �

localityId��� �
,��� �
string��� �%
allocationTypeInitial��� �
,��� �
int��� � 
allocationTypeId��� �
,��� �
string��� �
blockNumber��� �
,��� �
string��� �

plotNumber��� �
,��� �
double��� �

acreageOne��� �
,��� �
double��� �

acreageTwo��� �
,��� �
int��� � 
propertyHeightId��� �
,��� �
int��� �

plotSizeId��� �
,��� �
string��� �
sitePlanNumber��� �
,��� �
bool��� �
isLargeScale��� �
=��� �
false��� �
)��� �
{
�� 	
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
landUseInitial
��* 8
)
��8 9
||
��; =
string
��> D
.
��D E 
IsNullOrWhiteSpace
��E W
(
��W X
localityInitial
��X g
)
��g h
||
��i k
string
��l r
.
��r s!
IsNullOrWhiteSpace��s �
(��� �%
allocationTypeInitial��� �
)��� �
||��� �
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *

plotNumber
��* 4
)
��4 5
||
��6 8
	landUseId
��9 B
<=
��C E
$num
��F G
||
��H J
landUseTypeId
��K X
<=
��Y [
$num
��\ ]
||
��^ `

localityId
��a k
<=
��l n
$num
��o p
||
��q s
allocationTypeId��t �
<=��� �
$num��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Q
)
��Q R
;
��R S
}
�� 
if
�� 
(
�� 
	landUseId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, T
)
��T U
;
��U V
}
�� 
if
�� 
(
�� 
landUseTypeId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Y
)
��Y Z
;
��Z [
}
�� 
if
�� 
(
�� 

localityId
�� 
<=
�� 
$num
�� 
)
��  
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, T
)
��T U
;
��U V
}
�� 
if
�� 
(
�� 
allocationTypeId
��  
<=
��! #
$num
��$ %
)
��% &
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, [
)
��[ \
;
��\ ]
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
landUseInitial
��* 8
)
��8 9
||
��: <
landUseInitial
��= K
.
��K L
Length
��L R
>
��S T
$num
��U V
)
��V W
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, g
)
��g h
;
��h i
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
localityInitial
��* 9
)
��9 :
||
��; =
localityInitial
��> M
.
��M N
Length
��N T
>
��U V
$num
��W X
)
��X Y
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, g
)
��g h
;
��h i
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *#
allocationTypeInitial
��* ?
)
��? @
||
��A C#
allocationTypeInitial
��D Y
.
��Y Z
Length
��Z `
>
��a b
$num
��c d
)
��d e
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, n
)
��n o
;
��o p
}
�� 
if
�� 
(
�� 

plotNumber
�� 
==
�� 
$str
�� !
)
��! "
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, K
)
��K L
;
��L M
}
�� 
string
�� 
strPropertyNumber
�� $
=
��% &
string
��' -
.
��- .
Empty
��. 3
;
��3 4
string
�� 
	delimiter
�� 
=
�� 
$str
�� "
;
��" #
if
�� 
(
�� 
propertyTypeId
�� 
==
�� !
$num
��" #
||
��$ &
propertyTypeId
��' 5
==
��6 8
$num
��9 :
||
��; =
propertyTypeId
��> L
==
��M O
$num
��P Q
)
��Q R
{
�� 
}
�� 
switch
�� 
(
�� 
isLargeScale
��  
)
��  !
{
�� 
case
�� 
false
�� 
:
�� 
if
�� 
(
�� 
landUseInitial
�� %
==
��& (
$str
��) .
&&
��/ 1
string
��2 8
.
��8 9 
IsNullOrWhiteSpace
��9 K
(
��K L
blockNumber
��L W
)
��W X
)
��X Y
{
�� 
strPropertyNumber
�� )
=
��* +
string
��, 2
.
��2 3
Concat
��3 9
(
��9 : 
landUseTypeInitial
��: L
,
��L M
	delimiter
��N W
,
��W X
localityInitial
��Y h
,
��h i
	delimiter
��j s
,
��s t$
allocationTypeInitial��u �
,��� �
	delimiter��� �
,��� �

plotNumber��� �
)��� �
;��� �
}
�� 
if
�� 
(
�� 
landUseInitial
�� &
==
��' )
$str
��* /
&&
��0 2
!
��3 4
string
��4 :
.
��: ; 
IsNullOrWhiteSpace
��; M
(
��M N
blockNumber
��N Y
)
��Y Z
)
��Z [
{
�� 
strPropertyNumber
�� )
=
��* +
string
��, 2
.
��2 3
Concat
��3 9
(
��9 : 
landUseTypeInitial
��: L
,
��L M
	delimiter
��N W
,
��W X
localityInitial
��Y h
,
��h i
	delimiter
��j s
,
��s t$
allocationTypeInitial��u �
,��� �
	delimiter��� �
,��� �
blockNumber��� �
,��� �
	delimiter��� �
,��� �

plotNumber��� �
)��� �
;��� �
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� 1
(
��1 2
blockNumber
��2 =
)
��= >
)
��> ?
{
�� 
strPropertyNumber
�� )
=
��* +
string
��, 2
.
��2 3
Concat
��3 9
(
��9 :
landUseInitial
��: H
,
��H I
	delimiter
��J S
,
��S T
localityInitial
��U d
,
��d e
	delimiter
��f o
,
��o p$
allocationTypeInitial��q �
,��� �
	delimiter��� �
,��� �

plotNumber��� �
)��� �
;��� �
}
�� 
if
�� 
(
�� 
!
�� 
string
�� 
.
��   
IsNullOrWhiteSpace
��  2
(
��2 3
blockNumber
��3 >
)
��> ?
)
��? @
{
�� 
strPropertyNumber
�� )
=
��* +
string
��, 2
.
��2 3
Concat
��3 9
(
��9 :
landUseInitial
��: H
,
��H I
	delimiter
��J S
,
��S T
localityInitial
��U d
,
��d e
	delimiter
��f o
,
��o p$
allocationTypeInitial��q �
,��� �
	delimiter��� �
,��� �
blockNumber��� �
,��� �
	delimiter��� �
,��� �

plotNumber��� �
)��� �
;��� �
}
�� 
break
�� 
;
�� 
case
�� 
true
�� 
:
�� 
break
�� 
;
�� 
}
�� 
return
�� 
new
�� 
PropertyMaster
�� %
{
�� 
PropertyMasterId
��  
=
��! "
propertyMasterId
��# 3
,
��3 4
PropertyNumber
�� 
=
��  
strPropertyNumber
��! 2
,
��2 3
PropertyTypeId
�� 
=
��  
propertyTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
	LandUseId
�� 
=
�� 
	landUseId
�� %
,
��% &
LandUseTypeId
�� 
=
�� 
landUseTypeId
��  -
,
��- .
AllocationTypeId
��  
=
��! "
allocationTypeId
��# 3
,
��3 4
BlockNumber
�� 
=
�� 
blockNumber
�� )
,
��) *

PlotNumber
�� 
=
�� 

plotNumber
�� '
,
��' (

AcreageOne
�� 
=
�� 

acreageOne
�� '
,
��' (

AcreageTwo
�� 
=
�� 

acreageTwo
�� '
,
��' (
PropertyHeightId
��  
=
��! "
propertyHeightId
��# 3
,
��3 4

PlotSizeId
�� 
=
�� 

plotSizeId
�� '
,
��' (
SitePlanNumber
�� 
=
��  
sitePlanNumber
��! /
,
��/ 0
IsLargeScale
�� 
=
�� 
isLargeScale
�� +
,
��+ ,
	IsDeleted
�� 
=
�� 
false
�� !
}
�� 
;
�� 
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/CustomerUpdatesMaster.cs
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
r �
,


� �
int


� �

localityId


� �
,


� �
string


� �
customerCode


� �
,


� �
string


� �
companyName


� �
,


� �
int


� �
nationalityId


� �
,


� �
string


� �
companyAddress


� �
,


� �
string


� �
digitalAddress


� �
,


� �
string


� �!
primaryMobileNumber


� �
,


� �
stringD J!
secondaryMobileNumberK `
,` a
stringb h
officeNumberi u
,u v
stringw }
whatsAppNumber	~ �
,
� �
string
� �
emailAddress
� �
,
� �
string
� �(
businessRegistrationNumber
� �
,
� �
string
� �
	tinNumber
� �
,
� �
int
� �
socialMediaTypeId
� �
,
� �
string
� � 
socialMediaAccount
� �
,
� �
stringD J&
identificationTypeImageOneK e
,e f
stringg m'
identificationTypeImageTwo	n �
,
� �
string
� �*
identificationTypeImageThree
� �
,
� �
string
� �)
identificationTypeImageFour
� �
,
� �
string
� �)
identificationTypeImageFive
� �
,
� �
stringD J"
contactPerson_FullNameK a
,a b
stringc i&
contactPerson_PhoneNumber	j �
,
� �
string
� �(
contactPerson_EmailAddress
� �
,
� �
string
� �#
contactPerson_Address
� �
,
� �
int
� �0
"contactPerson_IdentificationTypeId
� �
,
� �
string
� �4
&contactPerson_IdentificationTypeNumber
� �
,
� �
stringD J4
(contactPerson_IdentificationTypeImageOneK s
,s t
stringu {5
(contactPerson_IdentificationTypeImageTwo	| �
,
� �
string
� �
comments
� �
,
� �$
ICustomerDomainService
� �#
customerDomainService
� �
)
� �
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
string	z �
.
� � 
IsNullOrWhiteSpace
� �
(
� �
companyAddress
� �
)
� �
||
� �
string
� �
.
� � 
IsNullOrWhiteSpace
� �
(
� �!
primaryMobileNumber
� �
)
� �
||
� �
string
� �
.
� � 
IsNullOrWhiteSpace
� �
(
� �
emailAddress
� �
)
� �
)
� �
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
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
string
��$ *
.
��* +
Empty
��+ 0
,
��0 1
DebtorStatus
�� 
=
�� 
$num
��  
,
��  !

ParentCode
�� 
=
�� 
string
�� #
.
��# $
Empty
��$ )
,
��) *$
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
true
��  
,
��  !
MaritalStatus
�� 
=
�� 
string
��  &
.
��& '
Empty
��' ,
,
��, -
DateOfMarriage
�� 
=
��  
Convert
��! (
.
��( )

ToDateTime
��) 3
(
��3 4
$str
��4 @
)
��@ A
}
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0#
UpdateIndividualAsync
��1 F
(
��F G
int
��G J
customerMasterId
��K [
,
��[ \
int
��] `
customerTypeId
��a o
,
��o p
int
��q t
residentTypeId��u �
,��� �
int��� �

localityId��� �
,��� �
string��� �
customerCode��� �
,��� �
int��� �
titleId��� �
,��� �
string��� �
surName��� �
,��� �
string��� �

otherNames��� �
,��� �
DateTime��� �
dateOfBirth��� �
,��� �
string��� �
	tinNumber��� �
,��� �
string��� �
picture��� �
,��� �
int��� �
genderId��� �
,��� �
int
��G J
nationalityId
��K X
,
��X Y
string
��Z `
postalAddress
��a n
,
��n o
string
��p v!
residentialAddress��w �
,��� �
string��� �
digitalAddress��� �
,��� �
string��� �#
primaryMobileNumber��� �
,��� �
string��� �%
secondaryMobileNumber��� �
,��� �
string��� �
officeNumber��� �
,��� �
string��� �
whatsAppNumber��� �
,��� �
string��� �
emailAddress��� �
,��� �
string
��G M"
residentPermitNumber
��N b
,
��b c
DateTime
��d l
?
��l m'
residentPermitDateIssued��n �
,��� �
DateTime��� �
?��� �(
residentPermitExpiryDate��� �
,��� �
int��� �!
socialMediaTypeId��� �
,��� �
string��� �"
socialMediaAccount��� �
,��� �
int��� �$
identificationTypeId��� �
,��� �
string��� �(
identificationTypeNumber��� �
,��� �
string
��G M(
identificationTypeImageOne
��N h
,
��h i
string
��j p)
identificationTypeImageTwo��q �
,��� �
string��� �,
identificationTypeImageThree��� �
,��� �
string��� �+
identificationTypeImageFour��� �
,��� �
string��� �+
identificationTypeImageFive��� �
,��� �
string��� �
comments��� �
,��� �
string��� �!
interestExpressed��� �
,��� �
int��� �
debtorStatus��� �
,��� �
string��� �

parentCode��� �
,��� �
string��� �&
contactPerson_FullName��� �
,��� �
string��� �)
contactPerson_PhoneNumber��� �
,��� �
string
��G M(
contactPerson_EmailAddress
��N h
,
��h i
string
��j p$
contactPerson_Address��q �
,��� �
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string��� �6
&contactPerson_IdentificationTypeNumber��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageOne��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageTwo��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
CustomerExists
��- ;
(
��; <
customerMasterId
��< L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, F
)
��F G
;
��G H
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &
residentTypeId
��' 5
<=
��6 8
$num
��9 :
||
��; =

localityId
��> H
<=
��I K
$num
��L M
||
��N P
nationalityId
��Q ^
<=
��_ a
$num
��b c
||
��d f"
identificationTypeId
��g {
<=
��| ~
$num�� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
surName��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �

otherNames��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �(
identificationTypeNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
ResidentTypeExists
��- ?
(
��? @
residentTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, B
)
��B C
;
��C D
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
GenderExists
��- 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, @
)
��@ A
;
��A B
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, E
)
��E F
;
��F G
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -&
IdentificationTypeExists
��- E
(
��E F"
identificationTypeId
��F Z
)
��Z [
)
��[ \
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, M
)
��M N
;
��N O
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &
NON_RESIDENT
��& 2
==
��3 5
residentTypeId
��6 D
)
��D E
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .$
contactPerson_FullName
��. D
)
��D E
)
��E F
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 c
)
��c d
;
��d e
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .'
contactPerson_PhoneNumber
��. G
)
��G H
)
��H I
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 g
)
��g h
;
��h i
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .(
contactPerson_EmailAddress
��. H
)
��H I
)
��I J
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 h
)
��h i
;
��i j
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .#
contactPerson_Address
��. C
)
��C D
)
��D E
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 b
)
��b c
;
��c d
}
�� 
if
�� 
(
�� 0
"contactPerson_IdentificationTypeId
�� 6
<=
��7 9
$num
��: ;
)
��; <
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .4
&contactPerson_IdentificationTypeNumber
��. T
)
��T U
)
��U V
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 s
)
��s t
;
��t u
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .6
(contactPerson_IdentificationTypeImageOne
��. V
)
��V W
)
��W X
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
}
�� 
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &

EXPATRIATE
��& 0
==
��1 3
residentTypeId
��4 B
)
��B C
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- ."
residentPermitNumber
��. B
)
��B C
)
��C D
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� &
residentPermitDateIssued
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� &
residentPermitExpiryDate
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
customerCode
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
if
�� 
(
�� 
titleId
�� 
>
�� 
$num
�� 
)
�� 
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
TitleExists
��1 <
(
��< =
titleId
��= D
)
��D E
)
��E F
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 C
)
��C D
;
��D E
}
�� 
if
�� 
(
�� 
genderId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
nationalityId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 O
)
��O P
;
��P Q
}
�� 
if
�� 
(
�� "
identificationTypeId
�� $
<=
��% '
$num
��( )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, _
)
��_ `
;
��` a
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
surName
��* 1
)
��1 2
||
��3 5
string
��6 <
.
��< = 
IsNullOrWhiteSpace
��= O
(
��O P

otherNames
��P Z
)
��Z [
)
��[ \
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
dateOfBirth
�� 
==
�� 
DateTime
�� '
.
��' (
MinValue
��( 0
)
��0 1
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, X
)
��X Y
;
��Y Z
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
postalAddress
��* 7
)
��7 8
)
��8 9
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, V
)
��V W
;
��W X
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) * 
residentialAddress
��* <
)
��< =
)
��= >
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, [
)
��[ \
;
��\ ]
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
if
�� 
(
�� 
customer_locality
�� !
is
��" $
null
��% )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
return
�� 
new
�� 
CustomerMaster
�� %
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
customerCode
�� +
,
��+ ,
TitleId
�� 
=
�� 
titleId
�� !
,
��! "
SurName
�� 
=
�� 
surName
�� !
,
��! "

OtherNames
�� 
=
�� 

otherNames
�� '
,
��' (
CompanyName
�� 
=
�� 
string
�� $
.
��$ %
Empty
��% *
,
��* +
DateOfBirth
�� 
=
�� 
dateOfBirth
�� )
,
��) *
	TinNumber
�� 
=
�� 
	tinNumber
�� %
,
��% &
Picture
�� 
=
�� 
picture
�� !
,
��! "
GenderId
�� 
=
�� 
genderId
�� #
,
��# $
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
postalAddress
��  -
,
��- . 
ResidentialAddress
�� "
=
��# $ 
residentialAddress
��% 7
,
��7 8
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &"
residentPermitNumber
��' ;
,
��; <&
ResidentPermitDateIssued
�� (
=
��) *&
residentPermitDateIssued
��+ C
,
��C D&
ResidentPermitExpiryDate
�� (
=
��) *&
residentPermitExpiryDate
��+ C
,
��C D
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &"
identificationTypeId
��' ;
,
��; <&
IdentificationTypeNumber
�� (
=
��) *&
identificationTypeNumber
��+ C
,
��C D(
IdentificationTypeImageOne
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
interestExpressed
��$ 5
,
��5 6
DebtorStatus
�� 
=
�� 
debtorStatus
�� +
,
��+ ,

ParentCode
�� 
=
�� 

parentCode
�� '
,
��' ($
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
true
��  
,
��  !
MaritalStatus
�� 
=
�� 
string
��  &
.
��& '
Empty
��' ,
,
��, -
DateOfMarriage
�� 
=
��  
Convert
��! (
.
��( )

ToDateTime
��) 3
(
��3 4
$str
��4 @
)
��@ A
}
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0
UpdateJointAsync
��1 A
(
��A B
int
��B E
customerMasterId
��F V
,
��V W
int
��X [
customerTypeId
��\ j
,
��j k
int
��l o
residentTypeId
��p ~
,
��~ 
int��� �

localityId��� �
,��� �
string��� �
customerCode��� �
,��� �
int��� �
titleId��� �
,��� �
string��� �
surName��� �
,��� �
string��� �

otherNames��� �
,��� �
DateTime��� �
dateOfBirth��� �
,��� �
string��� �
	tinNumber��� �
,��� �
string��� �
picture��� �
,��� �
int��� �
genderId��� �
,��� �
int
��? B
nationalityId
��C P
,
��P Q
string
��R X
postalAddress
��Y f
,
��f g
string
��h n!
residentialAddress��o �
,��� �
string��� �
digitalAddress��� �
,��� �
string��� �#
primaryMobileNumber��� �
,��� �
string��� �%
secondaryMobileNumber��� �
,��� �
string��� �
officeNumber��� �
,��� �
string��� �
whatsAppNumber��� �
,��� �
string��� �
emailAddress��� �
,��� �
string
��? E"
residentPermitNumber
��F Z
,
��Z [
DateTime
��\ d
?
��d e&
residentPermitDateIssued
��f ~
,
��~ 
DateTime��� �
?��� �(
residentPermitExpiryDate��� �
,��� �
int��� �!
socialMediaTypeId��� �
,��� �
string��� �"
socialMediaAccount��� �
,��� �
int��� �$
identificationTypeId��� �
,��� �
string��� �(
identificationTypeNumber��� �
,��� �
string
��? E(
identificationTypeImageOne
��F `
,
��` a
string
��b h)
identificationTypeImageTwo��i �
,��� �
string��� �,
identificationTypeImageThree��� �
,��� �
string��� �+
identificationTypeImageFour��� �
,��� �
string��� �+
identificationTypeImageFive��� �
,��� �
string��� �
comments��� �
,��� �
string��� �!
interestExpressed��� �
,��� �
int��� �
debtorStatus��� �
,��� �
string��� �

parentCode��� �
,��� �
string��� �&
contactPerson_FullName��� �
,��� �
string��� �)
contactPerson_PhoneNumber��� �
,��� �
string
��? E(
contactPerson_EmailAddress
��F `
,
��` a
string
��b h#
contactPerson_Address
��i ~
,
��~ 
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string��� �6
&contactPerson_IdentificationTypeNumber��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageOne��� �
,��� �
string
��? E6
(contactPerson_IdentificationTypeImageTwo
��F n
,
��n o
string
��p v
maritalStatus��w �
,��� �
DateTime��� �
?��� �
dateOfMarriage��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
CustomerExists
��- ;
(
��; <
customerMasterId
��< L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, F
)
��F G
;
��G H
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &
residentTypeId
��' 5
<=
��6 8
$num
��9 :
||
��; =

localityId
��> H
<=
��I K
$num
��L M
||
��N P
nationalityId
��Q ^
<=
��_ a
$num
��b c
||
��d f"
identificationTypeId
��g {
<=
��| ~
$num�� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
surName��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �

otherNames��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �(
identificationTypeNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Q
)
��Q R
;
��R S
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
ResidentTypeExists
��- ?
(
��? @
residentTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, B
)
��B C
;
��C D
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
GenderExists
��- 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, @
)
��@ A
;
��A B
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, E
)
��E F
;
��F G
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -&
IdentificationTypeExists
��- E
(
��E F"
identificationTypeId
��F Z
)
��Z [
)
��[ \
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, M
)
��M N
;
��N O
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &
NON_RESIDENT
��& 2
==
��3 5
residentTypeId
��6 D
)
��D E
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .$
contactPerson_FullName
��. D
)
��D E
)
��E F
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 c
)
��c d
;
��d e
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .'
contactPerson_PhoneNumber
��. G
)
��G H
)
��H I
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 e
)
��e f
;
��f g
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .(
contactPerson_EmailAddress
��. H
)
��H I
)
��I J
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 f
)
��f g
;
��g h
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .#
contactPerson_Address
��. C
)
��C D
)
��D E
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� 0
"contactPerson_IdentificationTypeId
�� 6
<=
��7 9
$num
��: ;
)
��; <
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .4
&contactPerson_IdentificationTypeNumber
��. T
)
��T U
)
��U V
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 s
)
��s t
;
��t u
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .6
(contactPerson_IdentificationTypeImageOne
��. V
)
��V W
)
��W X
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
}
�� 
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &

EXPATRIATE
��& 0
==
��1 3
residentTypeId
��4 B
)
��B C
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- ."
residentPermitNumber
��. B
)
��B C
)
��C D
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� &
residentPermitDateIssued
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� &
residentPermitExpiryDate
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
customerCode
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
if
�� 
(
�� 
titleId
�� 
>
�� 
$num
�� 
)
�� 
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
TitleExists
��1 <
(
��< =
titleId
��= D
)
��D E
)
��E F
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 C
)
��C D
;
��D E
}
�� 
if
�� 
(
�� 
genderId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
nationalityId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 O
)
��O P
;
��P Q
}
�� 
if
�� 
(
�� "
identificationTypeId
�� $
<=
��% '
$num
��( )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, _
)
��_ `
;
��` a
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
surName
��* 1
)
��1 2
||
��3 5
string
��6 <
.
��< = 
IsNullOrWhiteSpace
��= O
(
��O P

otherNames
��P Z
)
��Z [
)
��[ \
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
dateOfBirth
�� 
==
�� 
DateTime
�� '
.
��' (
MinValue
��( 0
)
��0 1
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, X
)
��X Y
;
��Y Z
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
postalAddress
��* 7
)
��7 8
)
��8 9
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, V
)
��V W
;
��W X
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) * 
residentialAddress
��* <
)
��< =
)
��= >
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, [
)
��[ \
;
��\ ]
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
if
�� 
(
�� 
customer_locality
�� !
is
��" $
null
��% )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
return
�� 
new
�� 
CustomerMaster
�� %
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
customerCode
�� +
,
��+ ,
TitleId
�� 
=
�� 
titleId
�� !
,
��! "
SurName
�� 
=
�� 
surName
�� !
,
��! "

OtherNames
�� 
=
�� 

otherNames
�� '
,
��' (
CompanyName
�� 
=
�� 
string
�� $
.
��$ %
Empty
��% *
,
��* +
DateOfBirth
�� 
=
�� 
dateOfBirth
�� )
,
��) *
	TinNumber
�� 
=
�� 
	tinNumber
�� %
,
��% &
Picture
�� 
=
�� 
picture
�� !
,
��! "
GenderId
�� 
=
�� 
genderId
�� #
,
��# $
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
postalAddress
��  -
,
��- . 
ResidentialAddress
�� "
=
��# $ 
residentialAddress
��% 7
,
��7 8
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &"
residentPermitNumber
��' ;
,
��; <&
ResidentPermitDateIssued
�� (
=
��) *&
residentPermitDateIssued
��+ C
,
��C D&
ResidentPermitExpiryDate
�� (
=
��) *&
residentPermitExpiryDate
��+ C
,
��C D
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &"
identificationTypeId
��' ;
,
��; <&
IdentificationTypeNumber
�� (
=
��) *&
identificationTypeNumber
��+ C
,
��C D(
IdentificationTypeImageOne
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
interestExpressed
��$ 5
,
��5 6
DebtorStatus
�� 
=
�� 
debtorStatus
�� +
,
��+ ,

ParentCode
�� 
=
�� 

parentCode
�� '
,
��' ($
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
true
��  
,
��  !
MaritalStatus
�� 
=
�� 
maritalStatus
��  -
,
��- .
DateOfMarriage
�� 
=
��  
dateOfMarriage
��! /
}
�� 
;
�� 
}
�� 	
public
�� 
void
�� &
UpdateContactInformation
�� ,
(
��, -
string
�� 
postalAddress
��  
,
��  !
string
��  
residentialAddress
�� %
,
��% &
string
�� 
digitalAddress
�� !
,
��! "
string
�� !
primaryMobileNumber
�� &
,
��& '
string
�� #
secondaryMobileNumber
�� (
,
��( )
string
�� 
officeNumber
�� 
,
��  
string
�� 
whatsAppNumber
�� !
,
��! "
string
�� 
emailAddress
�� 
,
��  
string
�� 
	updatedBy
�� 
)
�� 
{
�� 	
PostalAddress
�� 
=
�� 
postalAddress
�� )
;
��) * 
ResidentialAddress
�� 
=
��   
residentialAddress
��! 3
;
��3 4
DigitalAddress
�� 
=
�� 
digitalAddress
�� +
;
��+ ,!
PrimaryMobileNumber
�� 
=
��  !!
primaryMobileNumber
��" 5
;
��5 6#
SecondaryMobileNumber
�� !
=
��" ##
secondaryMobileNumber
��$ 9
;
��9 :
OfficeNumber
�� 
=
�� 
officeNumber
�� '
;
��' (
WhatsAppNumber
�� 
=
�� 
whatsAppNumber
�� +
;
��+ ,
EmailAddress
�� 
=
�� 
emailAddress
�� '
;
��' (

ModifiedOn
�� 
=
�� 
DateTime
�� !
.
��! "
UtcNow
��" (
;
��( )
_domainEvents
�� 
.
�� 
Add
�� 
(
�� 
new
�� !"
CustomerUpdatedEvent
��" 6
(
��6 7
CustomerMasterId
��  
,
��  !
CustomerCode
�� 
!
�� 
,
�� 
	updatedBy
�� 
,
�� 
$str
�� $
)
��$ %
)
��% &
;
��& '
}
�� 	
public
�� 
void
�� 
UpdateStatus
��  
(
��  !
int
��! $
	newStatus
��% .
,
��. /
string
��0 6
	changedBy
��7 @
)
��@ A
{
�� 	
var
�� 
	oldStatus
�� 
=
�� 
DebtorStatus
�� (
;
��( )
DebtorStatus
�� 
=
�� 
	newStatus
�� $
;
��$ %

ModifiedOn
�� 
=
�� 
DateTime
�� !
.
��! "
UtcNow
��" (
;
��( )
_domainEvents
�� 
.
�� 
Add
�� 
(
�� 
new
�� !(
CustomerStatusChangedEvent
��" <
(
��< =
CustomerMasterId
��  
,
��  !
CustomerCode
�� 
,
�� 
	oldStatus
�� 
.
�� 
ToString
�� "
(
��" #
)
��# $
,
��$ %
	newStatus
�� 
.
�� 
ToString
�� "
(
��" #
)
��# $
,
��$ %
	changedBy
�� 
)
�� 
)
�� 
;
�� 
}
�� 	
}
�� 
}�� ��
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/CustomerMaster.cs
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
�� 	
StringLength
��	 
(
�� 
$num
�� 
)
�� 
]
�� 
[
�� 	
EmailAddress
��	 
]
�� 
public
�� 
string
�� 
?
�� (
ContactPerson_EmailAddress
�� 1
{
��2 3
get
��4 7
;
��7 8
set
��9 <
;
��< =
}
��> ?
[
�� 	
StringLength
��	 
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
string
�� 
?
�� #
ContactPerson_Address
�� ,
{
��- .
get
��/ 2
;
��2 3
set
��4 7
;
��7 8
}
��9 :
public
�� 
int
�� 0
"ContactPerson_IdentificationTypeId
�� 5
{
��6 7
get
��8 ;
;
��; <
set
��= @
;
��@ A
}
��B C
[
�� 	
StringLength
��	 
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
string
�� 
?
�� 4
&ContactPerson_IdentificationTypeNumber
�� =
{
��> ?
get
��@ C
;
��C D
set
��E H
;
��H I
}
��J K
[
�� 	
StringLength
��	 
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
string
�� 
?
�� 6
(ContactPerson_IdentificationTypeImageOne
�� ?
{
��@ A
get
��B E
;
��E F
set
��G J
;
��J K
}
��L M
[
�� 	
StringLength
��	 
(
�� 
$num
�� 
)
�� 
]
�� 
public
�� 
string
�� 
?
�� 6
(ContactPerson_IdentificationTypeImageTwo
�� ?
{
��@ A
get
��B E
;
��E F
set
��G J
;
��J K
}
��L M
public
�� 
bool
�� 
	IsDeleted
�� 
{
�� 
get
��  #
;
��# $
set
��% (
;
��( )
}
��* +
public
�� 
bool
�� 
	IsPrimary
�� 
{
�� 
get
��  #
;
��# $
set
��% (
;
��( )
}
��* +
public
�� 
string
�� 
?
�� 
MaritalStatus
�� $
{
��% &
get
��' *
;
��* +
set
��, /
;
��/ 0
}
��1 2
public
�� 
DateTime
�� 
?
�� 
DateOfMarriage
�� '
{
��( )
get
��* -
;
��- .
set
��/ 2
;
��2 3
}
��4 5
public
�� 
CustomerMaster
�� 
(
�� 
)
�� 
{
�� 	
}
�� 	
public
�� 
CustomerMaster
�� 
(
�� 
int
�� !
customerMasterId
��" 2
,
��2 3
int
��4 7
customerTypeId
��8 F
,
��F G
int
��H K
residentTypeId
��L Z
,
��Z [
int
��\ _

localityId
��` j
,
��j k
string
��l r
customerCode
��s 
,�� �
string��� �
companyName��� �
,��� �
string��� �*
businessRegistrationNumber��� �
,��� �
string��� �
	tinNumber��� �
,��� �
string��� �
picture��� �
,��� �
int
�� 
nationalityId
�� 
,
�� 
string
�� %
postalAddress
��& 3
,
��3 4
string
��5 ; 
residentialAddress
��< N
,
��N O
string
��P V
digitalAddress
��W e
,
��e f
string
��g m"
primaryMobileNumber��n �
,��� �
string��� �%
secondaryMobileNumber��� �
,��� �
string��� �
officeNumber��� �
,��� �
string��� �
whatsAppNumber��� �
,��� �
string��� �
emailAddress��� �
,��� �
string��� �$
residentPermitNumber��� �
,��� �
DateTime
�� &
residentPermitDateIssued
�� -
,
��- .
DateTime
��/ 7&
residentPermitExpiryDate
��8 P
,
��P Q
int
��R U
socialMediaTypeId
��V g
,
��g h
string
��i o!
socialMediaAccount��p �
,��� �
int��� �$
identificationTypeId��� �
,��� �
string��� �(
identificationTypeNumber��� �
,��� �
string��� �*
identificationTypeImageOne��� �
,��� �
string��� �*
identificationTypeImageTwo��� �
,��� �
string
�� 
comments
�� 
,
�� 
string
�� #
interestExpressed
��$ 5
,
��5 6
int
��7 :
debtorStatus
��; G
,
��G H
string
��I O

parentCode
��P Z
,
��Z [
string
��\ b$
contactPerson_FullName
��c y
,
��y z
string��{ �)
contactPerson_PhoneNumber��� �
,��� �
string��� �*
contactPerson_EmailAddress��� �
,��� �
string��� �%
contactPerson_Address��� �
,��� �
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string
�� 4
&contactPerson_IdentificationTypeNumber
�� 9
,
��9 :
string
��; A3
%contactPerson_IdentificationTypeImage
��B g
,
��g h
bool
��i m
	isDeleted
��n w
,
��w x
bool
��y }
isParent��~ �
,��� �
string��� �
maritalStatus��� �
,��� �
DateTime��� �
dateOfMarriage��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0$
CreateProspectiveAsync
��1 G
(
��G H
int
�� 
customerMasterId
��  
,
��  !
int
�� 
customerTypeId
�� 
,
�� 
int
�� 
residentTypeId
�� 
,
�� 
int
�� 

localityId
�� 
,
�� 
string
�� 
customerCode
�� 
,
��  
int
�� 
titleId
�� 
,
�� 
string
�� 
surName
�� 
,
�� 
string
�� 

otherNames
�� 
,
�� 
string
�� 
companyName
�� 
,
�� 
string
�� 
picture
�� 
,
�� 
int
�� 
genderId
�� 
,
�� 
int
�� 
nationalityId
�� 
,
�� 
string
�� 
postalAddress
��  
,
��  !
string
��  
residentialAddress
�� %
,
��% &
string
�� 
digitalAddress
�� !
,
��! "
string
�� !
primaryMobileNumber
�� &
,
��& '
string
�� #
secondaryMobileNumber
�� (
,
��( )
string
�� 
officeNumber
�� 
,
��  
string
�� 
whatsAppNumber
�� !
,
��! "
string
�� 
emailAddress
�� 
,
��  
int
�� 
socialMediaTypeId
�� !
,
��! "
string
��  
socialMediaAccount
�� %
,
��% &
string
�� 
comments
�� 
,
�� 
string
�� 
interestExpressed
�� $
,
��$ %
string
�� 
	createdBy
�� 
,
�� $
ICustomerDomainService
�� "#
customerDomainService
��# 8
)
��8 9
{
�� 	
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &

localityId
��' 1
<=
��2 4
$num
��5 6
||
��7 9
string
��: @
.
��@ A 
IsNullOrWhiteSpace
��A S
(
��S T
surName
��T [
)
��[ \
&&
��] _
string
��` f
.
��f g 
IsNullOrWhiteSpace
��g y
(
��y z

otherNames��z �
)��� �
&&��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
companyName��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �!
interestExpressed��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :#
InvalidCustomerTypeId
��: O
)
��O P
;
��P Q
if
�� 
(
�� 
residentTypeId
�� 
>
��  
$num
��! "
)
��" #
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1 
ResidentTypeExists
��1 C
(
��C D
residentTypeId
��D R
)
��R S
)
��S T
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
ErrorMessages
��0 =
.
��= >#
InvalidResidentTypeId
��> S
)
��S T
;
��T U
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
InvalidLocalityId
��: K
)
��K L
;
��L M
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
GenderExists
��- 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :
InvalidGenderId
��: I
)
��I J
;
��J K
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
ErrorMessages
��, 9
.
��9 :"
InvalidNationalityId
��: N
)
��N O
;
��O P
if
�� 
(
�� 
titleId
�� 
>
�� 
$num
�� 
)
�� 
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
TitleExists
��1 <
(
��< =
titleId
��= D
)
��D E
)
��E F
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
ErrorMessages
��0 =
.
��= >
InvalidTitleId
��> L
)
��L M
;
��M N
}
�� 
if
�� 
(
�� 
genderId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
nationalityId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
ErrorMessages
��0 =
.
��= >&
InvalidSocialMediaTypeId
��> V
)
��V W
;
��W X
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
surName
��* 1
)
��1 2
&&
��3 5
string
��6 <
.
��< = 
IsNullOrWhiteSpace
��= O
(
��O P

otherNames
��P Z
)
��Z [
&&
��\ ^
string
��_ e
.
��e f 
IsNullOrWhiteSpace
��f x
(
��x y
companyName��y �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, j
)
��j k
;
��k l
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
interestExpressed
��* ;
)
��; <
)
��< =
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Z
)
��Z [
;
��[ \
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
comments
��* 2
)
��2 3
)
��3 4
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, P
)
��P Q
;
��Q R
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
var
�� 
locality
�� 
=
�� 
await
��  #
customerDomainService
��! 6
.
��6 7
LocalityExists
��7 E
(
��E F

localityId
��F P
)
��P Q
;
��Q R
if
�� 
(
�� 
locality
�� 
is
�� 
false
�� !
)
��! "
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
string
�� 
code
�� 
=
�� 
new
�� 
Random
�� $
(
��$ %
)
��% &
.
��& '
Next
��' +
(
��+ ,
$num
��, -
,
��- .
$num
��/ 4
)
��4 5
.
��5 6
ToString
��6 >
(
��> ?
)
��? @
;
��@ A
string
�� #
locality_customerCode
�� (
=
��) *
customer_locality
��+ <
.
��< =
LocalityInitial
��= L
!
��L M
;
��M N
string
�� 
_customercode
��  
=
��! "
$"
��# %
{
��% &#
locality_customerCode
��& ;
}
��; <
{
��< =
code
��= A
}
��A B
"
��B C
;
��C D
var
�� 
customer
�� 
=
�� 
new
�� 
CustomerMaster
�� -
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
_customercode
�� ,
,
��, -
TitleId
�� 
=
�� 
titleId
�� !
,
��! "
SurName
�� 
=
�� 
surName
�� !
,
��! "

OtherNames
�� 
=
�� 

otherNames
�� '
,
��' (
CompanyName
�� 
=
�� 
companyName
�� )
,
��) *
DateOfBirth
�� 
=
�� 
Convert
�� %
.
��% &

ToDateTime
��& 0
(
��0 1
$str
��1 =
)
��= >
,
��> ?
	TinNumber
�� 
=
�� 
string
�� "
.
��" #
Empty
��# (
,
��( )
Picture
�� 
=
�� 
picture
�� !
,
��! "
GenderId
�� 
=
�� 
genderId
�� #
,
��# $
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
postalAddress
��  -
,
��- . 
ResidentialAddress
�� "
=
��# $ 
residentialAddress
��% 7
,
��7 8
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &
string
��' -
.
��- .
Empty
��. 3
,
��3 4&
ResidentPermitDateIssued
�� (
=
��) *
Convert
��+ 2
.
��2 3

ToDateTime
��3 =
(
��= >
$str
��> J
)
��J K
,
��K L&
ResidentPermitExpiryDate
�� (
=
��) *
Convert
��+ 2
.
��2 3

ToDateTime
��3 =
(
��= >
$str
��> J
)
��J K
,
��K L
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &
$num
��' (
,
��( )&
IdentificationTypeNumber
�� (
=
��) *
string
��+ 1
.
��1 2
Empty
��2 7
,
��7 8(
IdentificationTypeImageOne
�� *
=
��+ ,
string
��- 3
.
��3 4
Empty
��4 9
,
��9 :(
IdentificationTypeImageTwo
�� *
=
��+ ,
string
��- 3
.
��3 4
Empty
��4 9
,
��9 :*
IdentificationTypeImageThree
�� ,
=
��- .
string
��/ 5
.
��5 6
Empty
��6 ;
,
��; <)
IdentificationTypeImageFour
�� +
=
��, -
string
��. 4
.
��4 5
Empty
��5 :
,
��: ;)
IdentificationTypeImageFive
�� +
=
��, -
string
��. 4
.
��4 5
Empty
��5 :
,
��: ;
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
interestExpressed
��$ 5
,
��5 6
DebtorStatus
�� 
=
�� 
$num
��  
,
��  !

ParentCode
�� 
=
�� 
string
�� #
.
��# $
Empty
��$ )
,
��) *$
ContactPerson_FullName
�� &
=
��' (
string
��) /
.
��/ 0
Empty
��0 5
,
��5 6'
ContactPerson_PhoneNumber
�� )
=
��* +
string
��, 2
.
��2 3
Empty
��3 8
,
��8 9(
ContactPerson_EmailAddress
�� *
=
��+ ,
string
��- 3
.
��3 4
Empty
��4 9
,
��9 :#
ContactPerson_Address
�� %
=
��& '
string
��( .
.
��. /
Empty
��/ 4
,
��4 50
"ContactPerson_IdentificationTypeId
�� 2
=
��3 4
$num
��5 6
,
��6 74
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 8
string
��9 ?
.
��? @
Empty
��@ E
,
��E F6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :
string
��; A
.
��A B
Empty
��B G
,
��G H6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :
string
��; A
.
��A B
Empty
��B G
,
��G H
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	CreatedBy
�� 
=
�� 
	createdBy
�� %
}
�� 
;
�� 
customer
�� 
.
�� 
_domainEvents
�� "
.
��" #
Add
��# &
(
��& '
new
��' *"
CustomerCreatedEvent
��+ ?
(
��? @
customerMasterId
��  
,
��  !
_customercode
�� 
,
�� 
$str
�� 
,
�� 
	createdBy
�� 
)
�� 
)
�� 
;
�� 
return
�� 
customer
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0 
CreateCompanyAsync
��1 C
(
��C D
int
��D G
customerMasterId
��H X
,
��X Y
int
��Z ]
customerTypeId
��^ l
,
��l m
int
��n q
residentTypeId��r �
,��� �
int��� �

localityId��� �
,��� �
string��� �
customerCode��� �
,��� �
string��� �
companyName��� �
,��� �
int��� �
nationalityId��� �
,��� �
string��� �
companyAddress��� �
,��� �
string��� �
digitalAddress��� �
,��� �
string��� �#
primaryMobileNumber��� �
,��� �
string
��D J#
secondaryMobileNumber
��K `
,
��` a
string
��b h
officeNumber
��i u
,
��u v
string
��w }
whatsAppNumber��~ �
,��� �
string��� �
emailAddress��� �
,��� �
string��� �*
businessRegistrationNumber��� �
,��� �
string��� �
	tinNumber��� �
,��� �
int��� �!
socialMediaTypeId��� �
,��� �
string��� �"
socialMediaAccount��� �
,��� �
string
��D J(
identificationTypeImageOne
��K e
,
��e f
string
��g m)
identificationTypeImageTwo��n �
,��� �
string��� �,
identificationTypeImageThree��� �
,��� �
string��� �+
identificationTypeImageFour��� �
,��� �
string��� �+
identificationTypeImageFive��� �
,��� �
string
��D J$
contactPerson_FullName
��K a
,
��a b
string
��c i(
contactPerson_PhoneNumber��j �
,��� �
string��� �*
contactPerson_EmailAddress��� �
,��� �
string��� �%
contactPerson_Address��� �
,��� �
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string��� �6
&contactPerson_IdentificationTypeNumber��� �
,��� �
string
��D J6
(contactPerson_IdentificationTypeImageOne
��K s
,
��s t
string
��u {7
(contactPerson_IdentificationTypeImageTwo��| �
,��� �
string��� �
comments��� �
,��� �
bool��� �
	isDeleted��� �
,��� �
bool��� �
	isPrimary��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &

localityId
��' 1
<=
��2 4
$num
��5 6
||
��7 9
nationalityId
��: G
<=
��H J
$num
��K L
||
��M O
string
��P V
.
��V W 
IsNullOrWhiteSpace
��W i
(
��i j
companyName
��j u
)
��u v
||
��w y
string��z �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
companyAddress��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Y
)
��Y Z
;
��Z [
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
residentTypeId
�� 
>
��  
$num
��! "
)
��" #
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1 
ResidentTypeExists
��1 C
(
��C D
residentTypeId
��D R
)
��R S
)
��S T
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 K
)
��K L
;
��L M
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, B
)
��B C
;
��C D
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, E
)
��E F
;
��F G
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
companyName
��* 5
)
��5 6
)
��6 7
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
companyAddress
��* 8
)
��8 9
)
��9 :
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *(
businessRegistrationNumber
��* D
)
��D E
)
��E F
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, b
)
��b c
;
��c d
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
	tinNumber
��* 3
)
��3 4
)
��4 5
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, P
)
��P Q
;
��Q R
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 O
)
��O P
;
��P Q
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
companyAddress
��* 8
)
��8 9
)
��9 :
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
if
�� 
(
�� 
customer_locality
�� !
is
��" $
null
��% )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
int
�� 
counter
�� 
=
�� 
customer_locality
�� +
.
��+ ,!
CustomerCodeCounter
��, ?
;
��? @
counter
�� 
++
�� 
;
�� 
string
�� 
incrementedNumber
�� $
=
��% &
counter
��' .
.
��. /
ToString
��/ 7
(
��7 8
$str
��8 <
)
��< =
;
��= >
string
�� #
locality_customerCode
�� (
=
��) *
customer_locality
��+ <
.
��< =
CustomerCode
��= I
!
��I J
;
��J K
string
�� 
_customercode
��  
=
��! "
$"
��# %
{
��% &#
locality_customerCode
��& ;
}
��; <
{
��< =
incrementedNumber
��= N
}
��N O
"
��O P
;
��P Q
return
�� 
new
�� 
CustomerMaster
�� %
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
_customercode
�� ,
,
��, -
TitleId
�� 
=
�� 
$num
�� 
,
�� 
SurName
�� 
=
�� 
string
��  
.
��  !
Empty
��! &
,
��& '

OtherNames
�� 
=
�� 
string
�� #
.
��# $
Empty
��$ )
,
��) *
CompanyName
�� 
=
�� 
companyName
�� )
,
��) *
DateOfBirth
�� 
=
�� 
Convert
�� %
.
��% &

ToDateTime
��& 0
(
��0 1
$str
��1 =
)
��= >
,
��> ?
	TinNumber
�� 
=
�� 
	tinNumber
�� %
,
��% &
Picture
�� 
=
�� 
string
��  
.
��  !
Empty
��! &
,
��& '
GenderId
�� 
=
�� 
$num
�� 
,
�� 
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
companyAddress
��  .
,
��. / 
ResidentialAddress
�� "
=
��# $
companyAddress
��% 3
,
��3 4
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &
string
��' -
.
��- .
Empty
��. 3
,
��3 4&
ResidentPermitDateIssued
�� (
=
��) *
Convert
��+ 2
.
��2 3

ToDateTime
��3 =
(
��= >
$str
��> J
)
��J K
,
��K L&
ResidentPermitExpiryDate
�� (
=
��) *
Convert
��+ 2
.
��2 3

ToDateTime
��3 =
(
��= >
$str
��> J
)
��J K
,
��K L
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &
$num
��' (
,
��( )&
IdentificationTypeNumber
�� (
=
��) *(
businessRegistrationNumber
��+ E
,
��E F(
IdentificationTypeImageOne
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
string
��$ *
.
��* +
Empty
��+ 0
,
��0 1
DebtorStatus
�� 
=
�� 
$num
��  
,
��  !

ParentCode
�� 
=
�� 
string
�� #
.
��# $
Empty
��$ )
,
��) *$
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
true
��  
,
��  !
MaritalStatus
�� 
=
�� 
string
��  &
.
��& '
Empty
��' ,
,
��, -
DateOfMarriage
�� 
=
��  
Convert
��! (
.
��( )

ToDateTime
��) 3
(
��3 4
$str
��4 @
)
��@ A
}
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0#
CreateIndividualAsync
��1 F
(
��F G
int
��G J
customerMasterId
��K [
,
��[ \
int
��] `
customerTypeId
��a o
,
��o p
int
��q t
residentTypeId��u �
,��� �
int��� �

localityId��� �
,��� �
string��� �
customerCode��� �
,��� �
int��� �
titleId��� �
,��� �
string��� �
surName��� �
,��� �
string��� �

otherNames��� �
,��� �
DateTime��� �
dateOfBirth��� �
,��� �
string��� �
	tinNumber��� �
,��� �
string��� �
picture��� �
,��� �
int��� �
genderId��� �
,��� �
int
��G J
nationalityId
��K X
,
��X Y
string
��Z `
postalAddress
��a n
,
��n o
string
��p v!
residentialAddress��w �
,��� �
string��� �
digitalAddress��� �
,��� �
string��� �#
primaryMobileNumber��� �
,��� �
string��� �%
secondaryMobileNumber��� �
,��� �
string��� �
officeNumber��� �
,��� �
string��� �
whatsAppNumber��� �
,��� �
string��� �
emailAddress��� �
,��� �
string
��G M"
residentPermitNumber
��N b
,
��b c
DateTime
��d l
?
��l m'
residentPermitDateIssued��n �
,��� �
DateTime��� �
?��� �(
residentPermitExpiryDate��� �
,��� �
int��� �!
socialMediaTypeId��� �
,��� �
string��� �"
socialMediaAccount��� �
,��� �
int��� �$
identificationTypeId��� �
,��� �
string��� �(
identificationTypeNumber��� �
,��� �
string
��G M(
identificationTypeImageOne
��N h
,
��h i
string
��j p)
identificationTypeImageTwo��q �
,��� �
string��� �,
identificationTypeImageThree��� �
,��� �
string��� �+
identificationTypeImageFour��� �
,��� �
string��� �+
identificationTypeImageFive��� �
,��� �
string��� �
comments��� �
,��� �
string��� �!
interestExpressed��� �
,��� �
int��� �
debtorStatus��� �
,��� �
string��� �

parentCode��� �
,��� �
string��� �&
contactPerson_FullName��� �
,��� �
string��� �)
contactPerson_PhoneNumber��� �
,��� �
string
��G M(
contactPerson_EmailAddress
��N h
,
��h i
string
��j p$
contactPerson_Address��q �
,��� �
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string��� �6
&contactPerson_IdentificationTypeNumber��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageOne��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageTwo��� �
,��� �
bool��� �
	isDeleted��� �
,��� �
bool��� �
	isPrimary��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &
residentTypeId
��' 5
<=
��6 8
$num
��9 :
||
��; =

localityId
��> H
<=
��I K
$num
��L M
||
��N P
nationalityId
��Q ^
<=
��_ a
$num
��b c
||
��d f"
identificationTypeId
��g {
<=
��| ~
$num�� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
surName��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �

otherNames��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �(
identificationTypeNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
ResidentTypeExists
��- ?
(
��? @
residentTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, B
)
��B C
;
��C D
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
GenderExists
��- 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, @
)
��@ A
;
��A B
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, E
)
��E F
;
��F G
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -&
IdentificationTypeExists
��- E
(
��E F"
identificationTypeId
��F Z
)
��Z [
)
��[ \
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, M
)
��M N
;
��N O
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &
NON_RESIDENT
��& 2
==
��3 5
residentTypeId
��6 D
)
��D E
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .$
contactPerson_FullName
��. D
)
��D E
)
��E F
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 c
)
��c d
;
��d e
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .'
contactPerson_PhoneNumber
��. G
)
��G H
)
��H I
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 g
)
��g h
;
��h i
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .(
contactPerson_EmailAddress
��. H
)
��H I
)
��I J
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 h
)
��h i
;
��i j
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .#
contactPerson_Address
��. C
)
��C D
)
��D E
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 b
)
��b c
;
��c d
}
�� 
if
�� 
(
�� 0
"contactPerson_IdentificationTypeId
�� 6
<=
��7 9
$num
��: ;
)
��; <
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .4
&contactPerson_IdentificationTypeNumber
��. T
)
��T U
)
��U V
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 s
)
��s t
;
��t u
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .6
(contactPerson_IdentificationTypeImageOne
��. V
)
��V W
)
��W X
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
}
�� 
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &

EXPATRIATE
��& 0
==
��1 3
residentTypeId
��4 B
)
��B C
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- ."
residentPermitNumber
��. B
)
��B C
)
��C D
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� &
residentPermitDateIssued
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� &
residentPermitExpiryDate
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
}
�� 
if
�� 
(
�� 
titleId
�� 
>
�� 
$num
�� 
)
�� 
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
TitleExists
��1 <
(
��< =
titleId
��= D
)
��D E
)
��E F
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 C
)
��C D
;
��D E
}
�� 
if
�� 
(
�� 
genderId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
nationalityId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 O
)
��O P
;
��P Q
}
�� 
if
�� 
(
�� "
identificationTypeId
�� $
<=
��% '
$num
��( )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, _
)
��_ `
;
��` a
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
surName
��* 1
)
��1 2
||
��3 5
string
��6 <
.
��< = 
IsNullOrWhiteSpace
��= O
(
��O P

otherNames
��P Z
)
��Z [
)
��[ \
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
dateOfBirth
�� 
==
�� 
DateTime
�� '
.
��' (
MinValue
��( 0
)
��0 1
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, X
)
��X Y
;
��Y Z
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
postalAddress
��* 7
)
��7 8
)
��8 9
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, V
)
��V W
;
��W X
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) * 
residentialAddress
��* <
)
��< =
)
��= >
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, [
)
��[ \
;
��\ ]
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
if
�� 
(
�� 
customer_locality
�� !
is
��" $
null
��% )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
int
�� 
counter
�� 
=
�� 
customer_locality
�� +
.
��+ ,!
CustomerCodeCounter
��, ?
;
��? @
counter
�� 
++
�� 
;
�� 
string
�� 
incrementedNumber
�� $
=
��% &
counter
��' .
.
��. /
ToString
��/ 7
(
��7 8
$str
��8 <
)
��< =
;
��= >
string
�� #
locality_customerCode
�� (
=
��) *
customer_locality
��+ <
.
��< =
CustomerCode
��= I
!
��I J
;
��J K
string
�� 
_customercode
��  
=
��! "
$"
��# %
{
��% &#
locality_customerCode
��& ;
}
��; <
{
��< =
incrementedNumber
��= N
}
��N O
"
��O P
;
��P Q
return
�� 
new
�� 
CustomerMaster
�� %
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
_customercode
�� ,
,
��, -
TitleId
�� 
=
�� 
titleId
�� !
,
��! "
SurName
�� 
=
�� 
surName
�� !
,
��! "

OtherNames
�� 
=
�� 

otherNames
�� '
,
��' (
CompanyName
�� 
=
�� 
string
�� $
.
��$ %
Empty
��% *
,
��* +
DateOfBirth
�� 
=
�� 
dateOfBirth
�� )
,
��) *
	TinNumber
�� 
=
�� 
	tinNumber
�� %
,
��% &
Picture
�� 
=
�� 
picture
�� !
,
��! "
GenderId
�� 
=
�� 
genderId
�� #
,
��# $
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
postalAddress
��  -
,
��- . 
ResidentialAddress
�� "
=
��# $ 
residentialAddress
��% 7
,
��7 8
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &"
residentPermitNumber
��' ;
,
��; <&
ResidentPermitDateIssued
�� (
=
��) *&
residentPermitDateIssued
��+ C
,
��C D&
ResidentPermitExpiryDate
�� (
=
��) *&
residentPermitExpiryDate
��+ C
,
��C D
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &"
identificationTypeId
��' ;
,
��; <&
IdentificationTypeNumber
�� (
=
��) *&
identificationTypeNumber
��+ C
,
��C D(
IdentificationTypeImageOne
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
interestExpressed
��$ 5
,
��5 6
DebtorStatus
�� 
=
�� 
debtorStatus
�� +
,
��+ ,

ParentCode
�� 
=
�� 

parentCode
�� '
,
��' ($
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
true
��  
,
��  !
MaritalStatus
�� 
=
�� 
string
��  &
.
��& '
Empty
��' ,
,
��, -
DateOfMarriage
�� 
=
��  
Convert
��! (
.
��( )

ToDateTime
��) 3
(
��3 4
$str
��4 @
)
��@ A
}
�� 
;
�� 
}
�� 	
public
�� 
static
�� 
async
�� 
Task
��  
<
��  !
CustomerMaster
��! /
>
��/ 0
CreateJointAsync
��1 A
(
��A B
int
��B E
customerMasterId
��F V
,
��V W
int
��X [
customerTypeId
��\ j
,
��j k
int
��l o
residentTypeId
��p ~
,
��~ 
int��� �

localityId��� �
,��� �
string��� �
customerCode��� �
,��� �
int��� �
titleId��� �
,��� �
string��� �
surName��� �
,��� �
string��� �

otherNames��� �
,��� �
DateTime��� �
dateOfBirth��� �
,��� �
string��� �
	tinNumber��� �
,��� �
string��� �
picture��� �
,��� �
int��� �
genderId��� �
,��� �
int
��? B
nationalityId
��C P
,
��P Q
string
��R X
postalAddress
��Y f
,
��f g
string
��h n!
residentialAddress��o �
,��� �
string��� �
digitalAddress��� �
,��� �
string��� �#
primaryMobileNumber��� �
,��� �
string��� �%
secondaryMobileNumber��� �
,��� �
string��� �
officeNumber��� �
,��� �
string��� �
whatsAppNumber��� �
,��� �
string��� �
emailAddress��� �
,��� �
string
��? E"
residentPermitNumber
��F Z
,
��Z [
DateTime
��\ d
?
��d e&
residentPermitDateIssued
��f ~
,
��~ 
DateTime��� �
?��� �(
residentPermitExpiryDate��� �
,��� �
int��� �!
socialMediaTypeId��� �
,��� �
string��� �"
socialMediaAccount��� �
,��� �
int��� �$
identificationTypeId��� �
,��� �
string��� �(
identificationTypeNumber��� �
,��� �
string
��? E(
identificationTypeImageOne
��F `
,
��` a
string
��b h)
identificationTypeImageTwo��i �
,��� �
string��� �,
identificationTypeImageThree��� �
,��� �
string��� �+
identificationTypeImageFour��� �
,��� �
string��� �+
identificationTypeImageFive��� �
,��� �
string��� �
comments��� �
,��� �
string��� �!
interestExpressed��� �
,��� �
int��� �
debtorStatus��� �
,��� �
string��� �

parentCode��� �
,��� �
string��� �&
contactPerson_FullName��� �
,��� �
string��� �)
contactPerson_PhoneNumber��� �
,��� �
string
��? E(
contactPerson_EmailAddress
��F `
,
��` a
string
��b h#
contactPerson_Address
��i ~
,
��~ 
int��� �2
"contactPerson_IdentificationTypeId��� �
,��� �
string��� �6
&contactPerson_IdentificationTypeNumber��� �
,��� �
string��� �8
(contactPerson_IdentificationTypeImageOne��� �
,��� �
string
��? E6
(contactPerson_IdentificationTypeImageTwo
��F n
,
��n o
bool
��p t
	isDeleted
��u ~
,
��~ 
bool��� �
	isPrimary��� �
,��� �
string��� �
maritalStatus��� �
,��� �
DateTime��� �
?��� �
dateOfMarriage��� �
,��� �&
ICustomerDomainService��� �%
customerDomainService��� �
)��� �
{
�� 	
if
�� 
(
�� 
customerTypeId
�� 
<=
�� !
$num
��" #
||
��$ &
residentTypeId
��' 5
<=
��6 8
$num
��9 :
||
��; =

localityId
��> H
<=
��I K
$num
��L M
||
��N P
nationalityId
��Q ^
<=
��_ a
$num
��b c
||
��d f"
identificationTypeId
��g {
<=
��| ~
$num�� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
surName��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �

otherNames��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �(
identificationTypeNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �#
primaryMobileNumber��� �
)��� �
||��� �
string��� �
.��� �"
IsNullOrWhiteSpace��� �
(��� �
emailAddress��� �
)��� �
)��� �
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, Q
)
��Q R
;
��R S
}
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
CustomerTypeExists
��- ?
(
��? @
customerTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, - 
ResidentTypeExists
��- ?
(
��? @
residentTypeId
��@ N
)
��N O
)
��O P
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, G
)
��G H
;
��H I
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
LocalityExists
��- ;
(
��; <

localityId
��< F
)
��F G
)
��G H
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, B
)
��B C
;
��C D
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
GenderExists
��- 9
(
��9 :
genderId
��: B
)
��B C
)
��C D
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, @
)
��@ A
;
��A B
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -
NationalityExists
��- >
(
��> ?
nationalityId
��? L
)
��L M
)
��M N
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, E
)
��E F
;
��F G
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� ,
.
��, -&
IdentificationTypeExists
��- E
(
��E F"
identificationTypeId
��F Z
)
��Z [
)
��[ \
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, M
)
��M N
;
��N O
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &
NON_RESIDENT
��& 2
==
��3 5
residentTypeId
��6 D
)
��D E
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .$
contactPerson_FullName
��. D
)
��D E
)
��E F
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 c
)
��c d
;
��d e
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .'
contactPerson_PhoneNumber
��. G
)
��G H
)
��H I
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 e
)
��e f
;
��f g
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .(
contactPerson_EmailAddress
��. H
)
��H I
)
��I J
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 f
)
��f g
;
��g h
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .#
contactPerson_Address
��. C
)
��C D
)
��D E
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� 0
"contactPerson_IdentificationTypeId
�� 6
<=
��7 9
$num
��: ;
)
��; <
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .4
&contactPerson_IdentificationTypeNumber
��. T
)
��T U
)
��U V
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 s
)
��s t
;
��t u
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- .6
(contactPerson_IdentificationTypeImageOne
��. V
)
��V W
)
��W X
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 r
)
��r s
;
��s t
}
�� 
}
�� 
if
�� 
(
�� 
(
�� 
int
�� 
)
�� 
ResidentTypeEnum
�� %
.
��% &

EXPATRIATE
��& 0
==
��1 3
residentTypeId
��4 B
)
��B C
{
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� -
(
��- ."
residentPermitNumber
��. B
)
��B C
)
��C D
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 `
)
��` a
;
��a b
}
�� 
if
�� 
(
�� &
residentPermitDateIssued
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� &
residentPermitExpiryDate
�� ,
==
��- /
DateTime
��0 8
.
��8 9
MinValue
��9 A
)
��A B
{
�� 
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 \
)
��\ ]
;
��] ^
}
�� 
}
�� 
if
�� 
(
�� 
titleId
�� 
>
�� 
$num
�� 
)
�� 
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
TitleExists
��1 <
(
��< =
titleId
��= D
)
��D E
)
��E F
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 C
)
��C D
;
��D E
}
�� 
if
�� 
(
�� 
genderId
�� 
<=
�� 
$num
�� 
)
�� 
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, R
)
��R S
;
��S T
}
�� 
if
�� 
(
�� 
nationalityId
�� 
<=
��  
$num
��! "
)
��" #
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
if
�� 
(
�� 
socialMediaTypeId
�� !
>
��" #
$num
��$ %
)
��% &
{
�� 
if
�� 
(
�� 
!
�� 
await
�� #
customerDomainService
�� 0
.
��0 1
SocialMediaExists
��1 B
(
��B C
socialMediaTypeId
��C T
)
��T U
)
��U V
throw
�� 
new
�� 
ArgumentException
�� /
(
��/ 0
$str
��0 O
)
��O P
;
��P Q
}
�� 
if
�� 
(
�� "
identificationTypeId
�� $
<=
��% '
$num
��( )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, _
)
��_ `
;
��` a
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
surName
��* 1
)
��1 2
||
��3 5
string
��6 <
.
��< = 
IsNullOrWhiteSpace
��= O
(
��O P

otherNames
��P Z
)
��Z [
)
��[ \
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, \
)
��\ ]
;
��] ^
}
�� 
if
�� 
(
�� 
dateOfBirth
�� 
==
�� 
DateTime
�� '
.
��' (
MinValue
��( 0
)
��0 1
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, X
)
��X Y
;
��Y Z
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
postalAddress
��* 7
)
��7 8
)
��8 9
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, V
)
��V W
;
��W X
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) * 
residentialAddress
��* <
)
��< =
)
��= >
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, [
)
��[ \
;
��\ ]
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *!
primaryMobileNumber
��* =
)
��= >
)
��> ?
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, ]
)
��] ^
;
��^ _
}
�� 
if
�� 
(
�� 
string
�� 
.
��  
IsNullOrWhiteSpace
�� )
(
��) *
emailAddress
��* 6
)
��6 7
)
��7 8
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, U
)
��U V
;
��V W
}
�� 
var
�� 
customer_locality
�� !
=
��" #
await
��$ )#
customerDomainService
��* ?
.
��? @ 
GetLocalityDetails
��@ R
(
��R S

localityId
��S ]
)
��] ^
;
��^ _
if
�� 
(
�� 
customer_locality
�� !
is
��" $
null
��% )
)
��) *
{
�� 
throw
�� 
new
�� 
ArgumentException
�� +
(
��+ ,
$str
��, W
)
��W X
;
��X Y
}
�� 
int
�� 
counter
�� 
=
�� 
customer_locality
�� +
.
��+ ,!
CustomerCodeCounter
��, ?
;
��? @
counter
�� 
++
�� 
;
�� 
string
�� 
incrementedNumber
�� $
=
��% &
counter
��' .
.
��. /
ToString
��/ 7
(
��7 8
$str
��8 <
)
��< =
;
��= >
string
�� #
locality_customerCode
�� (
=
��) *
customer_locality
��+ <
.
��< =
CustomerCode
��= I
!
��I J
;
��J K
string
�� 
_customercode
��  
=
��! "
$"
��# %
{
��% &#
locality_customerCode
��& ;
}
��; <
{
��< =
incrementedNumber
��= N
}
��N O
"
��O P
;
��P Q
return
�� 
new
�� 
CustomerMaster
�� %
{
�� 
CustomerMasterId
��  
=
��! "
customerMasterId
��# 3
,
��3 4
CustomerTypeId
�� 
=
��  
customerTypeId
��! /
,
��/ 0
ResidentTypeId
�� 
=
��  
residentTypeId
��! /
,
��/ 0

LocalityId
�� 
=
�� 

localityId
�� '
,
��' (
CustomerCode
�� 
=
�� 
_customercode
�� ,
,
��, -
TitleId
�� 
=
�� 
titleId
�� !
,
��! "
SurName
�� 
=
�� 
surName
�� !
,
��! "

OtherNames
�� 
=
�� 

otherNames
�� '
,
��' (
CompanyName
�� 
=
�� 
string
�� $
.
��$ %
Empty
��% *
,
��* +
DateOfBirth
�� 
=
�� 
dateOfBirth
�� )
,
��) *
	TinNumber
�� 
=
�� 
	tinNumber
�� %
,
��% &
Picture
�� 
=
�� 
picture
�� !
,
��! "
GenderId
�� 
=
�� 
genderId
�� #
,
��# $
NationalityId
�� 
=
�� 
nationalityId
��  -
,
��- .
PostalAddress
�� 
=
�� 
postalAddress
��  -
,
��- . 
ResidentialAddress
�� "
=
��# $ 
residentialAddress
��% 7
,
��7 8
DigitalAddress
�� 
=
��  
digitalAddress
��! /
,
��/ 0!
PrimaryMobileNumber
�� #
=
��$ %!
primaryMobileNumber
��& 9
,
��9 :#
SecondaryMobileNumber
�� %
=
��& '#
secondaryMobileNumber
��( =
,
��= >
OfficeNumber
�� 
=
�� 
officeNumber
�� +
,
��+ ,
WhatsAppNumber
�� 
=
��  
whatsAppNumber
��! /
,
��/ 0
EmailAddress
�� 
=
�� 
emailAddress
�� +
,
��+ ,"
ResidentPermitNumber
�� $
=
��% &"
residentPermitNumber
��' ;
,
��; <&
ResidentPermitDateIssued
�� (
=
��) *&
residentPermitDateIssued
��+ C
,
��C D&
ResidentPermitExpiryDate
�� (
=
��) *&
residentPermitExpiryDate
��+ C
,
��C D
SocialMediaTypeId
�� !
=
��" #
socialMediaTypeId
��$ 5
,
��5 6 
SocialMediaAccount
�� "
=
��# $ 
socialMediaAccount
��% 7
,
��7 8"
IdentificationTypeId
�� $
=
��% &"
identificationTypeId
��' ;
,
��; <&
IdentificationTypeNumber
�� (
=
��) *&
identificationTypeNumber
��+ C
,
��C D(
IdentificationTypeImageOne
�� *
=
��+ ,(
identificationTypeImageOne
��- G
,
��G H(
IdentificationTypeImageTwo
�� *
=
��+ ,(
identificationTypeImageTwo
��- G
,
��G H*
IdentificationTypeImageThree
�� ,
=
��- .*
identificationTypeImageThree
��/ K
,
��K L)
IdentificationTypeImageFour
�� +
=
��, -)
identificationTypeImageFour
��. I
,
��I J)
IdentificationTypeImageFive
�� +
=
��, -)
identificationTypeImageFive
��. I
,
��I J
Comments
�� 
=
�� 
comments
�� #
,
��# $
InterestExpressed
�� !
=
��" #
interestExpressed
��$ 5
,
��5 6
DebtorStatus
�� 
=
�� 
debtorStatus
�� +
,
��+ ,

ParentCode
�� 
=
�� 

parentCode
�� '
,
��' ($
ContactPerson_FullName
�� &
=
��' ($
contactPerson_FullName
��) ?
,
��? @'
ContactPerson_PhoneNumber
�� )
=
��* +'
contactPerson_PhoneNumber
��, E
,
��E F(
ContactPerson_EmailAddress
�� *
=
��+ ,(
contactPerson_EmailAddress
��- G
,
��G H#
ContactPerson_Address
�� %
=
��& '#
contactPerson_Address
��( =
,
��= >0
"ContactPerson_IdentificationTypeId
�� 2
=
��3 40
"contactPerson_IdentificationTypeId
��5 W
,
��W X4
&ContactPerson_IdentificationTypeNumber
�� 6
=
��7 84
&contactPerson_IdentificationTypeNumber
��9 _
,
��_ `6
(ContactPerson_IdentificationTypeImageOne
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageOne
��; c
,
��c d6
(ContactPerson_IdentificationTypeImageTwo
�� 8
=
��9 :6
(contactPerson_IdentificationTypeImageTwo
��; c
,
��c d
	IsDeleted
�� 
=
�� 
false
�� !
,
��! "
	IsPrimary
�� 
=
�� 
	isPrimary
�� %
,
��% &
MaritalStatus
�� 
=
�� 
maritalStatus
��  -
,
��- .
DateOfMarriage
�� 
=
��  
dateOfMarriage
��! /
}
�� 
;
�� 
}
�� 	
public
�� 
void
�� 
Delete
�� 
(
�� 
string
�� !
	deletedBy
��" +
,
��+ ,
string
��- 3
reason
��4 :
)
��: ;
{
�� 	
	IsDeleted
�� 
=
�� 
true
�� 
;
�� 

ModifiedOn
�� 
=
�� 
DateTime
�� !
.
��! "
UtcNow
��" (
;
��( )
_domainEvents
�� 
.
�� 
Add
�� 
(
�� 
new
�� !"
CustomerDeletedEvent
��" 6
(
��6 7
CustomerMasterId
��  
,
��  !
CustomerCode
�� 
,
�� 
	deletedBy
�� 
,
�� 
reason
�� 
)
�� 
)
�� 
;
�� 
}
�� 	
public
�� 
void
�� 
ClearDomainEvents
�� %
(
��% &
)
��& '
{
�� 	
_domainEvents
�� 
.
�� 
Clear
�� 
(
��  
)
��  !
;
��! "
}
�� 	
}
�� 
}�� �
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
} �
�/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Management/ActivityTransactions.cs
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
} �
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
} �
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