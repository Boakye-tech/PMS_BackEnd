¡
r/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Common.Infrastructure/ModuleDbContext.cs
	namespace 	
Modules
 
. 
Common 
. 
Infrastructure '
;' (
public 
abstract 
class 
ModuleDbContext %
:& '
	DbContext( 1
{ 
	protected 
abstract 
string 
Schema $
{% &
get' *
;* +
}, -
	protected		 
ModuleDbContext		 
(		 
DbContextOptions		 .
options		/ 6
)		6 7
:		8 9
base		: >
(		> ?
options		? F
)		F G
{

 
} 
	protected 
override 
void 
OnModelCreating +
(+ ,
ModelBuilder, 8
modelBuilder9 E
)E F
{ 
if 

( 
! 
string 
. 
IsNullOrWhiteSpace &
(& '
Schema' -
)- .
). /
{ 	
modelBuilder 
. 
HasDefaultSchema )
() *
Schema* 0
)0 1
;1 2
} 	
base 
. 
OnModelCreating 
( 
modelBuilder )
)) *
;* +
modelBuilder 
. +
ApplyConfigurationsFromAssembly 4
(4 5
GetType5 <
(< =
)= >
.> ?
Assembly? G
)G H
;H I
} 
} ä
„/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Common.Infrastructure/Authentication/UserContextService.cs
	namespace 	
Modules
 
. 
Common 
. 
Infrastructure '
.' (
Authentication( 6
{ 
public 
class 
UserContextService  
:! "
IUserContextService# 6
{ 
private		 
readonly		  
IHttpContextAccessor		 - 
_httpContextAccessor		. B
;		B C
public 
UserContextService !
(! " 
IHttpContextAccessor" 6
httpContextAccessor7 J
)J K
{ 	 
_httpContextAccessor  
=! "
httpContextAccessor# 6
;6 7
} 	
public 
string 
? 
	GetUserId  
(  !
)! "
{ 	
var 
user 
=  
_httpContextAccessor +
.+ ,
HttpContext, 7
?7 8
.8 9
User9 =
;= >
return 
user 
? 
. 
	FindFirst "
(" #

ClaimTypes# -
.- .
NameIdentifier. <
)< =
?= >
.> ?
Value? D
?? 
user 
? 
. 
	FindFirst %
(% &
$str& +
)+ ,
?, -
.- .
Value. 3
;3 4
} 	
} 
} –
…/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Common.Infrastructure/Authentication/IUserContextService.cs
	namespace 	
Modules
 
. 
Common 
. 
Infrastructure '
.' (
Authentication( 6
{ 
public 
	interface 
IUserContextService %
{ 
string 
? 
	GetUserId 
( 
) 
; 
} 
} 