b
`/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Usings.csá
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IUsersRolesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 
	interface !
IUsersRolesRepository '
:( )
IRepository* 5
<5 6'
ApplicationIdentityUserRole6 Q
>Q R
{ 
} 
} ˜
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IUserRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 
	interface 
IUserRepository !
:" #
IRepository$ /
</ 0#
ApplicationIdentityUser0 G
>G H
{ 
} 
} ç
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IUnitOfWork.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 

	interface 
IUnitOfWork  
:! "
IDisposable# .
{ !
IDepartmentRepository 

Department (
{) *
get+ .
;. /
}0 1%
IDepartmentUnitRepository !
DepartmentUnit" 0
{1 2
get3 6
;6 7
}8 9!
ITokenStoreRepository		 

TokenStore		 (
{		) *
get		+ .
;		. /
}		0 1
IChannelsRepository

 
Channels

 $
{

% &
get

' *
;

* +
}

, -
IUserRepository 
Users 
{ 
get  #
;# $
}% &
IRolesRepository 
Roles 
{  
get  #
;# $
}% &!
IUsersRolesRepository 

UsersRoles (
{) *
get+ .
;. /
}0 1
IMenusRepository 
Menus 
{  
get! $
;$ %
}& '
ISubMenusRepository 
SubMenus $
{% &
get' *
;* +
}, -#
ISubMenuItemsRepository 
SubMenuItems  ,
{- .
get/ 2
;2 3
}4 5"
IPermissionsRepository 
AcccessPermissions 1
{2 3
get4 7
;7 8
}9 :%
ISubPermissionsRepository !
SubPermissions" 0
{1 2
get3 6
;6 7
}8 9*
ISubPermissionsItemsRepository &
SubPermissionsItems' :
{; <
get= @
;@ A
}B C$
IStaffAccountsRepository  
StaffAccounts! .
{/ 0
get1 4
;4 5
}6 7)
IApplicationModulesRepository %
ApplicationModules& 8
{9 :
get; >
;> ?
}@ A4
(IApplicationModulesPermissionsRepository 0)
ApplicationModulesPermissions1 N
{O P
getQ T
;T U
}V W)
IIdentificationTypeRepository %
IdentificationType& 8
{9 :
get; >
;> ?
}@ A
Task!! 
<!! 
int!! 
>!! 
Complete!! 
(!! 
)!! 
;!! 
}"" 
}## ˇ
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IStaffAccountsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 
	interface $
IStaffAccountsRepository *
:+ ,
IRepository- 8
<8 9
StaffAccounts9 F
>F G
{ 
} 
} ˘
u/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IRolesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 
	interface 
IRolesRepository "
:# $
IRepository% 0
<0 1#
ApplicationIdentityRole1 H
>H I
{ 
} 
} –
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/IRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
{ 
public 

	interface 
IRepository  
<  !
TEntity! (
>( )
where* /
TEntity0 7
:8 9
class: ?
{ 
Task 
< 
TEntity 
? 
> 
Get 
( 
int 
id !
)! "
;" #
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
? 
> 
Get 
( 

Expression %
<% &
Func& *
<* +
TEntity+ 2
,2 3
bool4 8
>8 9
>9 :

expression; E
,E F
ListG K
<K L
stringL R
>R S
?S T
includesU ]
=^ _
null` d
)d e
;e f
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
}   Â
ì/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Permissions/ISubPermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Permissions3 >
{ 
public 
	interface %
ISubPermissionsRepository +
:, -
IRepository. 9
<9 :
SubPermissions: H
>H I
{ 
} 
}		 Ù
ò/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Permissions/ISubPermissionsItemsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Permissions3 >
{ 
public 
	interface *
ISubPermissionsItemsRepository 0
:1 2
IRepository3 >
<> ?
SubPermissionsItems? R
>R S
{ 
} 
} ‚
ê/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Permissions/IPermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Permissions3 >
{ 
public 
	interface "
IPermissionsRepository (
:) *
IRepository+ 6
<6 7
AccessPermissions7 H
>H I
{ 
} 
} ≈
Ü/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Menu/ISubMenusRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Menu3 7
{ 
public 
	interface 
ISubMenusRepository %
:& '
IRepository( 3
<3 4
SubMenus4 <
>< =
{ 
} 
}		 —
ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Menu/ISubMenuItemsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Menu3 7
{ 
public 
	interface #
ISubMenuItemsRepository )
:* +
IRepository, 7
<7 8
SubMenuItems8 D
>D E
{ 
} 
}		 º
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Menu/IMenusRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Menu3 7
{ 
public 
	interface 
IMenusRepository "
:# $
IRepository% 0
<0 1
Menus1 6
>6 7
{ 
} 
}		 Ç
â/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/Menu/IMenuActionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
.2 3
Menu3 7
{ 
}		 ˜
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/ITokenStoreRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface !
ITokenStoreRepository '
:( )
IRepository* 5
<5 6

TokenStore6 @
>@ A
{ 
Task 
< 
string 
> 
GetToken 
( 
string $-
!mobilePhoneNumber_OR_emailAddress% F
,F G
intH K
ExpiryMinutesL Y
)Y Z
;Z [
Task

 
<

 
string

 
>

 
VerifyToken

  
(

  !
string

! '-
!mobilePhoneNumber_OR_emailAddress

( I
,

I J
string

K Q
	tokenCode

R [
)

[ \
;

\ ]
string 
VerifyTokenExpiry  
(  !
string! '-
!mobilePhoneNumber_OR_emailAddress( I
,I J
stringK Q
	tokenCodeR [
)[ \
;\ ]
JwTokenResponse 

GetJwToken "
(" ##
ApplicationIdentityUser# :
user; ?
,? @
intA D
validityInHoursE T
)T U
;U V
RefreshToken 
GetJwRefreshToken &
(& '
)' (
;( )
ClaimsPrincipal 4
(GetClaimsPrincipalFromExpiredBearerToken @
(@ A
stringA G
bearerTokenH S
)S T
;T U
} 
} Ω
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IIdentificationTypeRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 

	interface )
IIdentificationTypeRepository 2
:3 4
IRepository5 @
<@ A
IdentificationTypeA S
>S T
{ 
} 
} ±
á/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IDepartmentUnitRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface %
IDepartmentUnitRepository +
:, -
IRepository. 9
<9 :
DepartmentUnit: H
>H I
{ 
} 
} •
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IDepartmentRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface !
IDepartmentRepository '
:( )
IRepository* 5
<5 6

Department6 @
>@ A
{ 
} 
} ü
Å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IChannelsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface 
IChannelsRepository %
:& '
IRepository( 3
<3 4
Channels4 <
>< =
{ 
} 
} Ω
ã/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IApplicationModulesRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface )
IApplicationModulesRepository /
:0 1
IRepository2 =
<= >
ApplicationModules> P
>P Q
{ 
} 
} ﬁ
ñ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Interfaces/Entities/IApplicationModulesPermissionsRepository.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 

Interfaces )
.) *
Entities* 2
{ 
public 
	interface 4
(IApplicationModulesPermissionsRepository :
:; <
IRepository= H
<H I)
ApplicationModulesPermissionsI f
>f g
{ 
} 
} π
m/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/TokenStore.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class 

TokenStore 
{ 
[ 	
Key	 
] 
public		 
int		 
TokenStoreId		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
MobilePhoneNumber (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
EmailAddress #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
Token 
{ 
get "
;" #
set$ '
;' (
}) *
public 
DateTime 
CreatedDate #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
DateTime 

ExpiryDate "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
bool 

IsVerified 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
false/ 4
;4 5
public 
DateTime 
VerifiedDate $
{% &
get' *
;* +
set, /
;/ 0
}1 2
} 
} ≠
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/StaffAccounts.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
[ 
Keyless 
] 
public 
class 
StaffAccounts 
{		 
public 
string 
? 
Id 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
?  
IdentificationNumber +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
string 
? 
	FirstName  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
? 

MiddleName !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
LastName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
? 
DepartmentName %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
? 
UnitName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
? 
Email 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
? 
PhoneNumber "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 
RoleName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
Status 
{ 
get 
;  
set! $
;$ %
}& '
public 
DateTime 
RegistrationDate (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
} 
} √
o/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/RefreshToken.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
[ 
	NotMapped 
] 
public 
class 
RefreshToken 
{ 
public		 
string		 
?		 
Token		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
public

 
DateTime

 
Expires

 
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
public 
bool 
	IsExpired 
=>  
DateTime! )
.) *
UtcNow* 0
>=1 3
Expires4 ;
;; <
public 
DateTime 
Created 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime 
? 
Revoked  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
IsActive 
=> 
Revoked  '
==( *
null+ /
&&0 2
!3 4
	IsExpired4 =
;= >
} 
} ø/
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/SubPermissionsItems.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
SubPermissionsItems !
{ 
[ 	
Required	 
] 
public		 
int		 
PermissionsId		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
[ 	
Required	 
] 
public 
int 
SubPermissionsId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Key	 
] 
[ 
Required 
] 
public 
int	 !
SubPermissionsItemsId "
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
string 
RoleId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
ItemName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
bool 
NoAccess 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
Create 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Read 
{ 
get 
; 
set  #
;# $
}% &
public 
bool 
Update 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Delete 
{ 
get !
;! "
set# &
;& '
}( )
public   
bool   
Approve   
{   
get   "
;  " #
set  $ '
;  ' (
}  ) *
public$$ 
SubPermissionsItems$$ "
($$" #
int$$# &
permissionsId$$' 4
,$$4 5
int$$6 9
subPermissionsId$$: J
,$$J K
int$$L O!
subPermissionsItemsId$$P e
,$$e f
string$$g m
roleId$$n t
,$$t u
string$$v |
itemName	$$} Ö
,
$$Ö Ü
bool
$$á ã
noAccess
$$å î
,
$$î ï
bool
$$ñ ö
create
$$õ °
,
$$° ¢
bool
$$£ ß
read
$$® ¨
,
$$¨ ≠
bool
$$Æ ≤
update
$$≥ π
,
$$π ∫
bool
$$ª ø
delete
$$¿ ∆
,
$$∆ «
bool
$$» Ã
approve
$$Õ ‘
)
$$‘ ’
{%% 
PermissionsId&& 
=&& 
permissionsId&& )
;&&) *
SubPermissionsId'' 
='' 
subPermissionsId'' /
;''/ 0!
SubPermissionsItemsId(( !
=((" #!
subPermissionsItemsId(($ 9
;((9 :
RoleId)) 	
=))
 
roleId)) 
;)) 
ItemName** 
=** 
itemName** 
;** 
NoAccess++ 
=++ 
noAccess++ 
;++  
Create,, 
=,, 
create,, 
;,, 
Read-- 
=-- 
read-- 
;-- 
Update.. 
=.. 
update.. 
;.. 
Delete// 
=// 
delete// 
;// 
Approve00 
=00 
approve00 
;00 
}11 
public33 
static33 
SubPermissionsItems33 )%
CreateSubPermissionsItems33* C
(33C D
int33D G
permissionsId33H U
,33U V
int33W Z
subPermissionsId33[ k
,33k l
int33m p"
subPermissionsItemsId	33q Ü
,
33Ü á
string
33à é
roleId
33è ï
,
33ï ñ
string
33ó ù
itemName
33û ¶
,
33¶ ß
bool
33® ¨
noAccess
33≠ µ
,
33µ ∂
bool
33∑ ª
create
33º ¬
,
33¬ √
bool
33ƒ »
read
33… Õ
,
33Õ Œ
bool
33œ ”
update
33‘ ⁄
,
33⁄ €
bool
33‹ ‡
delete
33· Á
,
33Á Ë
bool
33È Ì
approve
33Ó ı
)
33ı ˆ
{44 	
if55 
(55 
string55 
.55 
IsNullOrWhiteSpace55 )
(55) *
roleId55* 0
)550 1
||552 4
string555 ;
.55; <
IsNullOrWhiteSpace55< N
(55N O
itemName55O W
)55W X
)55X Y
{66 
throw77 
new77 
ArgumentException77 +
(77+ ,
$str77, Q
)77Q R
;77R S
}88 
return:: 
new:: 
SubPermissionsItems:: *
(::* +
permissionsId::+ 8
,::8 9
subPermissionsId::: J
,::J K!
subPermissionsItemsId::L a
,::a b
roleId::c i
,::i j
itemName::k s
,::s t
noAccess::u }
,::} ~
create	:: Ö
,
::Ö Ü
read
::á ã
,
::ã å
update
::é î
,
::î ï
delete
::ó ù
,
::ù û
approve
::† ß
)
::ß ®
;
::® ©
};; 	
}<< 
}== ú+
v/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/SubPermissions.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
SubPermissions 
{ 
[ 	
Required	 
] 
public		 
int		 
PermissionsId		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
[ 	
Key	 
] 
[ 
Required 
] 
public 
int	 
SubPermissionsId 
{ 
get  #
;# $
set% (
;( )
}* +
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
string 
RoleId 
{ 
get "
;" #
set$ '
;' (
}) *
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
string 
SectionName !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
NoAccess 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
Create 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Read 
{ 
get 
; 
set  #
;# $
}% &
public 
bool 
Update 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Delete 
{ 
get !
;! "
set# &
;& '
}( )
public 
bool 
Approve 
{ 
get "
;" #
set$ '
;' (
}) *
public   
SubPermissions   
(   
int   !
permissionsId  " /
,  / 0
int  1 4
subPermissionsId  5 E
,  E F
string  G M
roleId  N T
,  T U
string  V \
sectionName  ] h
,  h i
bool  j n
noAccess  o w
,  w x
bool  y }
create	  ~ Ñ
,
  Ñ Ö
bool
  Ü ä
read
  ã è
,
  è ê
bool
  ë ï
update
  ñ ú
,
  ú ù
bool
  û ¢
delete
  £ ©
,
  © ™
bool
  ´ Ø
approve
  ∞ ∑
)
  ∑ ∏
{!! 
PermissionsId"" 
="" 
permissionsId"" )
;"") *
SubPermissionsId## 
=## 
subPermissionsId## /
;##/ 0
RoleId$$ 	
=$$
 
roleId$$ 
;$$ 
SectionName%% 
=%% 
sectionName%% %
;%%% &
NoAccess&& 
=&& 
noAccess&& 
;&&  
Create'' 
='' 
create'' 
;'' 
Read(( 
=(( 
read(( 
;(( 
Update)) 
=)) 
update)) 
;)) 
Delete** 
=** 
delete** 
;** 
Approve++ 
=++ 
approve++ 
;++ 
},, 
public.. 
static.. 
SubPermissions.. $ 
CreateSubPermissions..% 9
(..9 :
int..: =
permissionsId..> K
,..K L
int..M P
subPermissionsId..Q a
,..a b
string..c i
roleId..j p
,..p q
string..r x
sectionName	..y Ñ
,
..Ñ Ö
bool
..Ü ä
noAccess
..ã ì
,
..ì î
bool
..ï ô
create
..ö †
,
..† °
bool
..¢ ¶
read
..ß ´
,
..´ ¨
bool
..≠ ±
update
..≤ ∏
,
..∏ π
bool
..∫ æ
delete
..ø ≈
,
..≈ ∆
bool
..« À
approve
..Ã ”
)
..” ‘
{// 	
if00 
(00 
string00 
.00 
IsNullOrWhiteSpace00 )
(00) *
roleId00* 0
)000 1
||002 4
string005 ;
.00; <
IsNullOrWhiteSpace00< N
(00N O
sectionName00O Z
)00Z [
)00[ \
{11 
throw22 
new22 
ArgumentException22 +
(22+ ,
$str22, K
)22K L
;22L M
}33 
return55 
new55 
SubPermissions55 %
(55% &
permissionsId55& 3
,553 4
subPermissionsId555 E
,55F G
roleId55G M
,55M N
sectionName55O Z
,55Z [
noAccess55\ d
,55d e
create55f l
,55l m
read55n r
,55r s
update55u {
,55{ |
delete	55~ Ñ
,
55Ñ Ö
approve
55á é
)
55é è
;
55è ê
}66 	
}77 
}88 ˙
p/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/SubMenus.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
SubMenus 
{ 
public 
int	 
MenuId 
{ 
get 
; 
set 
; 
}  !
[

 	
Key

	 
]

 
[ 	
Required	 
] 
public 
int 
	SubMenuId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
SubMenuName !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
IsOpen 
{ 
get  
;  !
set" %
;% &
}' (
public 
SubMenus 
( 
int 
menuId "
," #
int$ '
	subMenuId( 1
,1 2
string3 9
subMenuName: E
,E F
stringG M
descriptionN Y
,Y Z
bool[ _
isOpen` f
)f g
{ 
MenuId 	
=
 
menuId 
; 
	SubMenuId 
= 
	subMenuId 
; 
SubMenuName 
= 
subMenuName 
; 
Description 
= 
description 
; 
IsOpen 
= 
isOpen 
; 
} 
public   
static   
SubMenus   
CreateSubMenus   -
(  - .
int  . 1
menuId  2 8
,  8 9
int  : =
	subMenuId  > G
,  G H
string  I O
subMenuName  P [
,  [ \
string  ] c
description  d o
,  o p
bool  q u
isOpen  v |
)  | }
{!! 	
if"" 
("" 
string"" 
."" 
IsNullOrWhiteSpace"" )
("") *
subMenuName""* 5
)""5 6
||""7 9
menuId"": @
<""A B
$num""C D
||""E G
	subMenuId""H Q
<""R S
$num""T U
)""U V
{## 
throw$$ 
new$$ 
ArgumentException$$ +
($$+ ,
$str$$, E
)$$E F
;$$F G
}%% 
return'' 
new'' 
SubMenus'' 
(''  
menuId''  &
,''& '
	subMenuId''( 1
,''1 2
subMenuName''3 >
,''> ?
description''@ K
,''K L
isOpen''M S
)''S T
;''T U
}(( 	
}++ 
},, ⁄
t/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/SubMenuItems.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
SubMenuItems 
{ 
public 
int	 
MenuId 
{ 
get 
; 
set 
; 
}  !
public 
int 
	SubMenuId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Key	 
] 
[ 	
Required	 
] 
public 
int 
SubMenuItemId  
{! "
get# &
;& '
set( +
;+ ,
}- .
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
string 
SubMenuItemName %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
SubMenuItems 
( 
int 
menuId  &
,& '
int( +
	subMenuId, 5
,5 6
int7 :
subMenuItemId; H
,H I
stringJ P
subMenuItemNameQ `
,` a
stringb h
descriptioni t
)t u
{ 	
MenuId 	
=
 
menuId 
; 
	SubMenuId 
= 
	subMenuId 
; 
SubMenuItemId 
= 
subMenuItemId )
;) *
SubMenuItemName 
= 
subMenuItemName -
;- .
Description 
= 
description 
; 
}!! 
public## 
static## 
SubMenuItems## "
CreateSubMenuItems### 5
(##5 6
int##6 9
menuId##: @
,##@ A
int##B E
	subMenuId##F O
,##O P
int##Q T
subMenuItemId##U b
,##b c
string##d j
subMenuItemName##k z
,##z {
string	##| Ç
description
##É é
)
##é è
{$$ 	
if%% 
(%% 
string%% 
.%% 
IsNullOrWhiteSpace%% )
(%%) *
subMenuItemName%%* 9
)%%9 :
||%%; =
menuId%%> D
<%%E F
$num%%G H
||%%I K
	subMenuId%%L U
<%%V W
$num%%X Y
)%%Y Z
{&& 
throw'' 
new'' 
ArgumentException'' +
(''+ ,
$str'', J
)''J K
;''K L
}(( 
return** 
new** 
SubMenuItems** #
(**# $
menuId**$ *
,*** +
	subMenuId**, 5
,**5 6
subMenuItemId**7 D
,**D E
subMenuItemName**F U
,**U V
description**W b
)**b c
;**c d
}++ 	
}.. 
}// ë
m/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/Menus.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
Menus 
{ 
[ 
Key 
] 
[		 
Required		 
]		 
public

 
int

	 
MenuId

 
{

 
get

 
;

 
set

 
;

 
}

  !
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
string 
MenuName 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
bool 
IsOpen 
{ 
get  
;  !
set" %
;% &
}' (
public 
Menus 
( 
int 
menuId 
,  
string! '
menuName( 0
,0 1
string2 8
description9 D
,D E
boolF J
isOpenK Q
)Q R
{ 
MenuId 	
=
 
menuId 
; 
MenuName 
= 
menuName 
; 
Description 
= 
description %
;% &
IsOpen 
= 
isOpen 
; 
} 
public 
static 
Menus 
CreateMenus '
(' (
int( +
menuId, 2
,2 3
string4 :
menuName; C
,C D
stringE K
descriptionL W
,W X
boolY ]
isOpen^ d
)d e
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
menuName* 2
)2 3
||4 6
menuId7 =
<> ?
$num@ A
)A B
{   
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, A
)!!A B
;!!B C
}"" 
return$$ 
new$$ 
Menus$$ 
($$ 
menuId$$ #
,$$# $
menuName$$% -
,$$- .
description$$/ :
,$$: ;
isOpen$$< B
)$$B C
;$$C D
}%% 	
}&& 
}'' ƒ
s/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/MenuActions.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
}$$ ≠'
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Menu/AccessPermissions.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
.' (
Menu( ,
{ 
public 
class 
AccessPermissions 
{ 
[ 
Key 
] 
[		 
Required		 
]		 
public

 
int

	 
PermissionsId

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
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
string 
RoleId 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 

ModuleName  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
NoAccess 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
Create 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Read 
{ 
get 
; 
set  #
;# $
}% &
public 
bool 
Update 
{ 
get  
;  !
set" %
;% &
}' (
public 
bool 
Delete 
{ 
get !
;! "
set# &
;& '
}( )
public 
bool 
Approve 
{ 
get "
;" #
set$ '
;' (
}) *
public 
AccessPermissions  
(  !
int! $
permissionsId% 2
,2 3
string4 :
roleId; A
,A B
stringC I

moduleNameJ T
,T U
boolV Z
noAccess[ c
,c d
boole i
createj p
,p q
boolr v
readw {
,{ |
bool	} Å
update
Ç à
,
à â
bool
ä é
delete
è ï
,
ï ñ
bool
ó õ
approve
ú £
)
£ §
{ 
PermissionsId 
= 
permissionsId )
;) *
RoleId   
=   
roleId   
;   

ModuleName!! 
=!! 

moduleName!! "
;!!" #
NoAccess"" 
="" 
noAccess"" 
;""  
Create## 
=## 
create## 
;## 
Read$$ 
=$$ 
read$$ 
;$$ 
Update%% 
=%% 
update%% 
;%% 
Delete&& 
=&& 
delete&& 
;&& 
Approve'' 
='' 
approve'' 
;'' 
}(( 
public** 
static** 
AccessPermissions** '
CreatePermissions**( 9
(**9 :
int**: =
permissionsId**> K
,**K L
string**M S
roleId**T Z
,**Z [
string**\ b

moduleName**c m
,**m n
bool**o s
noAccess**t |
,**| }
bool	**~ Ç
create
**É â
,
**â ä
bool
**ã è
read
**ê î
,
**î ï
bool
**ñ ö
update
**õ °
,
**° ¢
bool
**£ ß
delete
**® Æ
,
**Æ Ø
bool
**∞ ¥
approve
**µ º
)
**º Ω
{++ 	
if,, 
(,, 
string,, 
.,, 
IsNullOrWhiteSpace,, )
(,,) *
roleId,,* 0
),,0 1
||,,2 4
string,,5 ;
.,,; <
IsNullOrWhiteSpace,,< N
(,,N O

moduleName,,O Y
),,Y Z
),,Z [
{-- 
throw.. 
new.. 
ArgumentException.. +
(..+ ,
$str.., G
)..G H
;..H I
}// 
return11 
new11 
AccessPermissions11 (
(11( )
permissionsId11) 6
,116 7
roleId118 >
,11> ?

moduleName11@ J
,11J K
noAccess11L T
,11T U
create11V \
,11\ ]
read11^ b
,11b c
update11e k
,11k l
delete11n t
,11t u
approve11w ~
)11~ 
;	11 Ä
}22 	
}33 
}44 ¯
u/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/IdentificationType.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
[ 
Keyless 
] 
public		 
class		 
IdentificationType		  
{

 
[ 	
Key	 
] 
[ 	
DatabaseGenerated	 
( #
DatabaseGeneratedOption 2
.2 3
None3 7
)7 8
]8 9
[ 	
Required	 
] 
public 
int  
IdentificationTypeId '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
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
IdentificationTypes *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
IdentificationType !
(! "
int" % 
identificationTypeId& :
,: ;
string< B
identificationTypesC V
)V W
{ 	 
IdentificationTypeId  
=! " 
identificationTypeId# 7
;7 8
IdentificationTypes 
=  !
identificationTypes" 5
;5 6
} 	
public 
static 
IdentificationType (
InsertUpdate) 5
(5 6
int6 9 
identificationTypeId: N
,N O
stringP V
identificationTypesW j
)j k
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
identificationTypes* =
)= >
||? A 
identificationTypeIdB V
<=W Y
$numZ [
)[ \
{ 
throw 
new 
ArgumentException +
(+ ,
$str, O
)O P
;P Q
} 
if!! 
(!!  
identificationTypeId!! $
<!!% &
$num!!' (
)!!( )
throw"" 
new"" 
ArgumentException"" +
(""+ ,
$str"", _
)""_ `
;""` a
if$$ 
($$ 
string$$ 
.$$ 
IsNullOrWhiteSpace$$ )
($$) *
identificationTypes$$* =
)$$= >
||$$? A
identificationTypes$$B U
.$$U V
Length$$V \
>$$] ^
$num$$_ a
)$$a b
throw%% 
new%% 
ArgumentException%% +
(%%+ ,
$str%%, k
)%%k l
;%%l m
return'' 
new'' 
IdentificationType'' )
('') * 
identificationTypeId''* >
,''> ?
identificationTypes''@ S
)''S T
;''T U
}(( 	
}** 
}++ —
q/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/DepartmentUnit.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class 
DepartmentUnit 
: 
AuditableEntity .
{ 
[ 
Required 
] 
public		 
int			 
DepartmentId		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
[ 
Key 
] 
[ 
Required 
] 
public 
int 
UnitId 
{ 
get 
;  
set! $
;$ %
}& '
[ 
Required 
] 
[ 
StringLength 
( 
$num 
) 
] 
public 
string 
UnitName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
DepartmentUnit	 
( 
int 
departmentId (
,( )
int* -
unitId. 4
,4 5
string6 <
unitName= E
)E F
{ 
DepartmentId 
= 
departmentId 
; 
UnitId 	
=
 
unitId 
; 
UnitName 
= 
unitName 
; 
} 	
public 
static 
DepartmentUnit $
CreateUpdate% 1
(1 2
int2 5
departmentId6 B
,B C
intD G
unitIdH N
,N O
stringP V
unitNameW _
)_ `
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
unitName* 2
)2 3
||4 6
departmentId7 C
<D E
$numF G
||H J
unitIdK Q
<R S
$numT U
)U V
{ 
throw 
new 
ArgumentException +
(+ ,
$str, K
)K L
;L M
} 
if!! 
(!! 
departmentId!! 
<=!! 
$num!!  !
)!!! "
throw"" 
new"" 
ArgumentException"" +
(""+ ,
$str"", Z
)""Z [
;""[ \
if$$ 
($$ 
unitId$$ 
<=$$ 
$num$$ 
)$$ 
throw%% 
new%% 
ArgumentException%% +
(%%+ ,
$str%%, _
)%%_ `
;%%` a
if'' 
('' 
string'' 
.'' 
IsNullOrWhiteSpace'' )
('') *
unitName''* 2
)''2 3
||''4 6
unitName''7 ?
.''? @
Length''@ F
>''G H
$num''I K
)''K L
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, p
)((p q
;((q r
return** 
new** 
DepartmentUnit** %
(**% &
departmentId**& 2
,**2 3
unitId**4 :
,**: ;
unitName**< D
)**D E
;**E F
}++ 	
},, 
}-- ⁄
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/JwTokenResponse.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class 
JwTokenResponse 
{ 
public 
string	 
? 
Token 
{ 
get 
; 
set !
;! "
}# $
public 
DateTime	 
? 
	ExpiresAt 
{ 
get "
;" #
set$ '
;' (
}) *
} 
}		 ¨
m/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Department.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 

class 

Department 
: 
AuditableEntity -
{ 
[ 	
Key	 
] 
[ 	
Required	 
] 
public		 
int		 
DepartmentId		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
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
string 
DepartmentName $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 

Department 
( 
int 
departmentId *
,* +
string, 2
departmentName3 A
)A B
{ 	
DepartmentId 
= 
departmentId '
;' (
DepartmentName 
= 
departmentName +
;+ ,
} 	
public 
static 

Department  
CreateUpdate! -
(- .
int. 1
departmentId2 >
,> ?
string@ F
departmentNameG U
)U V
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
departmentName* 8
)8 9
||: <
departmentId= I
<J K
$numL M
)M N
{ 
throw 
new 
ArgumentException +
(+ ,
$str, F
)F G
;G H
} 
if 
( 
departmentId 
<= 
$num  !
)! "
throw 
new 
ArgumentException +
(+ ,
$str, Z
)Z [
;[ \
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
departmentName* 8
)8 9
||: <
departmentName= K
.K L
LengthL R
>S T
$numU W
)W X
throw   
new   
ArgumentException   +
(  + ,
$str  , k
)  k l
;  l m
return"" 
new"" 

Department"" !
(""! "
departmentId""" .
,"". /
departmentName""0 >
)""> ?
;""? @
}## 	
}%% 
}&& ˛
k/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Channels.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class 
Channels 
: 
AuditableEntity (
{ 
[ 
Key 
] 
[		 
Required		 
]		 
public

 
int

	 
	ChannelId

 
{

 
get

 
;

 
set

 !
;

! "
}

# $
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string	 
? 
ChannelName 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Channels	 
( 
int 
	channelId 
,  
string! '
channelName( 3
)3 4
{ 
	ChannelId 
= 
	channelId 
; 
ChannelName 
= 
channelName 
; 
} 
public 
static	 
Channels 
CreateUpdate %
(% &
int& )
	channelId* 3
,3 4
string5 ;
channelName< G
)G H
{ 
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
channelName* 5
)5 6
||7 9
	channelId: C
<D E
$numF G
)G H
{ 
throw 
new 
ArgumentException +
(+ ,
$str, D
)D E
;E F
} 
if 
( 
	channelId 
<= 
$num 
) 
throw 
new 
ArgumentException +
(+ ,
$str, W
)W X
;X Y
if   
(   
string   
.   
IsNullOrWhiteSpace   )
(  ) *
channelName  * 5
)  5 6
||  7 9
channelName  : E
.  E F
Length  F L
>  M N
$num  O Q
)  Q R
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, h
)!!h i
;!!i j
return## 
new## 
Channels## 
(##  
	channelId##  )
,##) *
channelName##+ 6
)##6 7
;##7 8
}$$ 	
}%% 
}(( Á

r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/AuditableEntity.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
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
} Ñ"
Ä/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationModulesPermissions.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class )
ApplicationModulesPermissions +
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
ModulePermissionId

 %
{

& '
get

( +
;

+ ,
set

- 0
;

0 1
}

2 3
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string	 
? 
RoleId 
{ 
get 
; 
set "
;" #
}$ %
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ModuleId 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ModulePermission '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public )
ApplicationModulesPermissions ,
(, -
string- 3
roleId4 :
,: ;
string< B
moduleIdC K
,K L
stringM S
modulePermissionT d
)d e
{ 	
RoleId 
= 
roleId 
; 
ModuleId 
= 
moduleId 
;  
ModulePermission 
= 
modulePermission /
;/ 0
} 	
public 
static )
ApplicationModulesPermissions 3
CreateUpdate4 @
(@ A
stringA G
roleIdH N
,N O
stringP V
moduleIdW _
,_ `
stringa g
modulePermissionh x
)x y
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
roleId* 0
)0 1
||2 4
string5 ;
.; <
IsNullOrWhiteSpace< N
(N O
moduleIdO W
)W X
||Y [
string\ b
.b c
IsNullOrWhiteSpacec u
(u v
modulePermission	v Ü
)
Ü á
)
á à
{   
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, O
)!!O P
;!!P Q
}"" 
if$$ 
($$ 
string$$ 
.$$ 
IsNullOrWhiteSpace$$ )
($$) *
roleId$$* 0
)$$0 1
||$$2 4
roleId$$5 ;
.$$; <
Length$$< B
>$$C D
$num$$E G
)$$G H
throw%% 
new%% 
ArgumentException%% +
(%%+ ,
$str%%, c
)%%c d
;%%d e
if'' 
('' 
string'' 
.'' 
IsNullOrWhiteSpace'' )
('') *
moduleId''* 2
)''2 3
||''4 6
moduleId''7 ?
.''? @
Length''@ F
>''G H
$num''I K
)''K L
throw(( 
new(( 
ArgumentException(( +
(((+ ,
$str((, f
)((f g
;((g h
if** 
(** 
string** 
.** 
IsNullOrWhiteSpace** )
(**) *
modulePermission*** :
)**: ;
||**< >
modulePermission**? O
.**O P
Length**P V
>**W X
$num**Y [
)**[ \
throw++ 
new++ 
ArgumentException++ +
(+++ ,
$str++, m
)++m n
;++n o
return-- 
new-- )
ApplicationModulesPermissions-- 4
(--4 5
roleId--5 ;
,--; <
moduleId--= E
,--E F
modulePermission--G W
)--W X
;--X Y
}.. 	
}// 
}00 Ù
u/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationModules.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class 
ApplicationModules  
{ 
[		 	
Key			 
]		 
[

 
StringLength

 
(

 
$num

 
)

 
]

 
public 
string	 
? 
ModuleId 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

ModuleName !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
ApplicationModules !
(! "
string" (
moduleId) 1
,1 2
string3 9

moduleName: D
)D E
{ 	
ModuleId 
= 
moduleId 
;  

ModuleName 
= 

moduleName #
;# $
} 	
public 
static 
ApplicationModules (
CreateUpdate) 5
(5 6
string6 <
moduleId= E
,E F
stringG M

moduleNameN X
)X Y
{ 	
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
moduleId* 2
)2 3
||4 6
string7 =
.= >
IsNullOrWhiteSpace> P
(P Q

moduleNameQ [
)[ \
)\ ]
{ 
throw 
new 
ArgumentException +
(+ ,
$str, O
)O P
;P Q
} 
if 
( 
string 
. 
IsNullOrWhiteSpace )
() *
moduleId* 2
)2 3
||4 6
moduleId7 ?
.? @
Length@ F
>G H
$numI K
)K L
throw 
new 
ArgumentException +
(+ ,
$str, q
)q r
;r s
if   
(   
string   
.   
IsNullOrWhiteSpace   )
(  ) *

moduleName  * 4
)  4 5
||  6 8

moduleName  9 C
.  C D
Length  D J
>  K L
$num  M O
)  O P
throw!! 
new!! 
ArgumentException!! +
(!!+ ,
$str!!, s
)!!s t
;!!t u
return## 
new## 
ApplicationModules## )
(##) *
moduleId##* 2
,##2 3

moduleName##4 >
)##> ?
;##? @
}$$ 	
}%% 
}(( ≥
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationIdentityUserRole.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class '
ApplicationIdentityUserRole )
:* +
IdentityUserRole, <
<< =
string= C
>C D
{		 
public

 
DateTime

 

AssignedOn

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
string 
? 

AssignedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 

ModifiedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 

ModifiedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 

ApprovedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 

ApprovedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
short 
Status 
{ 
get !
;! "
set# &
;& '
}( )
public '
ApplicationIdentityUserRole *
(* +
)+ ,
:- .
base/ 3
(3 4
)4 5
{ 
} 
} 
} Ú]
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationIdentityUser.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 

class #
ApplicationIdentityUser (
:) *
IdentityUser+ 7
{ 
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
  
IdentificationNumber

 +
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
8 9
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
	FirstName  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 

MiddleName !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
LastName 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
PartnerName "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
DepartmentId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
UnitId 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
StringLength	 
( 
$num 
) 
] 
public 
string 
? 
ProfilePicture %
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
?   
LastReceiptNumber   (
{  ) *
get  + .
;  . /
set  0 3
;  3 4
}  5 6
["" 	
StringLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## 
?## 
LastReceiptImage## '
{##( )
get##* -
;##- .
set##/ 2
;##2 3
}##4 5
public%% 
int%%  
IdentificationTypeId%% '
{%%( )
get%%* -
;%%- .
set%%/ 2
;%%2 3
}%%4 5
['' 	
StringLength''	 
('' 
$num'' 
)'' 
]'' 
public(( 
string(( 
?(( &
IdentificationUniqueNumber(( 1
{((2 3
get((4 7
;((7 8
set((9 <
;((< =
}((> ?
[** 	
StringLength**	 
(** 
$num** 
)** 
]** 
public++ 
string++ 
?++ 
IdentificationImage++ *
{+++ ,
get++- 0
;++0 1
set++2 5
;++5 6
}++7 8
[-- 	
StringLength--	 
(-- 
$num-- 
)-- 
]-- 
public.. 
string.. 
?.. "
IdentificationImageOne.. -
{... /
get..0 3
;..3 4
set..5 8
;..8 9
}..: ;
[00 	
StringLength00	 
(00 
$num00 
)00 
]00 
public11 
string11 
?11 
SelfieImage11 "
{11# $
get11% (
;11( )
set11* -
;11- .
}11/ 0
[33 	
StringLength33	 
(33 
$num33 
)33 
]33 
public44 
string44 
?44 
PassportPicture44 &
{44' (
get44) ,
;44, -
set44. 1
;441 2
}443 4
public66 
int66 
	ChannelId66 
{66 
get66 "
;66" #
set66$ '
;66' (
}66) *
public88 
DateTime88 
RegistrationDate88 (
{88) *
get88+ .
;88. /
set880 3
;883 4
}885 6
public:: 
int:: 
Status:: 
{:: 
get:: 
;::  
set::! $
;::$ %
}::& '
[<< 	
StringLength<<	 
(<< 
$num<< 
)<< 
]<< 
public== 
string== 
?== "
ContactPerson_FullName== -
{==. /
get==0 3
;==3 4
set==5 8
;==8 9
}==: ;
[?? 	
StringLength??	 
(?? 
$num?? 
)?? 
]?? 
[@@ 	
EmailAddress@@	 
]@@ 
publicAA 
stringAA 
?AA 
ContactPerson_EmailAA *
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
?DD %
ContactPerson_PhoneNumberDD 0
{DD1 2
getDD3 6
;DD6 7
setDD8 ;
;DD; <
}DD= >
[FF 	
StringLengthFF	 
(FF 
$numFF 
)FF 
]FF 
publicGG 
stringGG 
?GG "
ContactPerson_PositionGG -
{GG. /
getGG0 3
;GG3 4
setGG5 8
;GG8 9
}GG: ;
[II 	
StringLengthII	 
(II 
$numII 
)II 
]II 
publicJJ 
stringJJ 
?JJ 
	CreatedByJJ  
{JJ! "
getJJ# &
;JJ& '
setJJ( +
;JJ+ ,
}JJ- .
publicKK 
DateTimeKK 
CreatedDateKK #
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
?NN 

ModifiedByNN !
{NN" #
getNN$ '
;NN' (
setNN) ,
;NN, -
}NN. /
publicOO 
DateTimeOO 
ModifiedDateOO $
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
?RR 
	DeletedByRR  
{RR! "
getRR# &
;RR& '
setRR( +
;RR+ ,
}RR- .
publicSS 
DateTimeSS 
DeletedDateSS #
{SS$ %
getSS& )
;SS) *
setSS+ .
;SS. /
}SS0 1
[UU 	
StringLengthUU	 
(UU 
$numUU 
)UU 
]UU 
publicVV 
stringVV 
?VV 

VerifiedByVV !
{VV" #
getVV$ '
;VV' (
setVV) ,
;VV, -
}VV. /
publicWW 
DateTimeWW 
VerifiedDateWW $
{WW% &
getWW' *
;WW* +
setWW, /
;WW/ 0
}WW1 2
[YY 	
StringLengthYY	 
(YY 
$numYY 
)YY 
]YY 
publicZZ 
stringZZ 
?ZZ 

RejectedByZZ !
{ZZ" #
getZZ$ '
;ZZ' (
setZZ) ,
;ZZ, -
}ZZ. /
public[[ 
DateTime[[ 
RejectedDate[[ $
{[[% &
get[[' *
;[[* +
set[[, /
;[[/ 0
}[[1 2
[]] 	
StringLength]]	 
(]] 
$num]] 
)]] 
]]] 
public^^ 
string^^ 
?^^ 
RejectedReasons^^ &
{^^' (
get^^) ,
;^^, -
set^^. 1
;^^1 2
}^^3 4
[`` 	
StringLength``	 
(`` 
$num`` 
)`` 
]`` 
publicaa 
stringaa 
?aa 

ApprovedByaa !
{aa" #
getaa$ '
;aa' (
setaa) ,
;aa, -
}aa. /
publicbb 
DateTimebb 
ApprovedDatebb $
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
DisapprovedByee $
{ee% &
getee' *
;ee* +
setee, /
;ee/ 0
}ee1 2
publicff 
DateTimeff 
DisapprovedDateff '
{ff( )
getff* -
;ff- .
setff/ 2
;ff2 3
}ff4 5
[hh 	
StringLengthhh	 
(hh 
$numhh 
)hh 
]hh 
publicii 
stringii 
?ii 
DisapprovedReasonsii )
{ii* +
getii, /
;ii/ 0
setii1 4
;ii4 5
}ii6 7
[kk 	
StringLengthkk	 
(kk 
$numkk 
)kk 
]kk 
publicll 
stringll 
?ll 
ActivatedByll "
{ll# $
getll% (
;ll( )
setll* -
;ll- .
}ll/ 0
publicmm 
DateTimemm 
ActivatedDatemm %
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
?pp 
DeactivatedBypp $
{pp% &
getpp' *
;pp* +
setpp, /
;pp/ 0
}pp1 2
publicqq 
DateTimeqq 
DeactivatedDateqq '
{qq( )
getqq* -
;qq- .
setqq/ 2
;qq2 3
}qq4 5
[ss 	
StringLengthss	 
(ss 
$numss 
)ss 
]ss 
publictt 
stringtt 
?tt 
DeactivatedReasonstt )
{tt* +
gettt, /
;tt/ 0
settt1 4
;tt4 5
}tt6 7
[vv 	
StringLengthvv	 
(vv 
$numvv 
)vv 
]vv 
publicww 
stringww 
?ww 

FirebaseIdww !
{ww" #
getww$ '
;ww' (
setww) ,
;ww, -
}ww. /
publicyy 
boolyy 
IsFirstTimeyy 
{yy  !
getyy" %
;yy% &
setyy' *
;yy* +
}yy, -
public{{ 
int{{ 
UserType{{ 
{{{ 
get{{ !
;{{! "
set{{# &
;{{& '
}{{( )
public}} 
string}} 
?}} 
RefreshToken}} #
{}}$ %
get}}& )
;}}) *
set}}+ .
;}}. /
}}}0 1
public 
DateTime 
RefreshTokenExpires +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
}
ÅÅ 
}ÇÇ Ó
z/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationIdentityRole.cs
	namespace 	
Modules
 
. 
Users 
. 
Domain 
. 
Entities '
{ 
public 
class #
ApplicationIdentityRole %
:& '
IdentityRole( 4
{ 
public 
int 
DepartmentId 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
int		 
UnitId		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
public

 
DateTime

 
	CreatedOn
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
	CreatedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 

ModifiedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 

ModifiedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
	DeletedOn !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
? 
	DeletedBy  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 

ApprovedOn "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 

ApprovedBy !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
short 
Status 
{ 
get !
;! "
set# &
;& '
}( )
public #
ApplicationIdentityRole &
(& '
)' (
:) *
base+ /
(/ 0
)0 1
{ 
} 
} 
} 