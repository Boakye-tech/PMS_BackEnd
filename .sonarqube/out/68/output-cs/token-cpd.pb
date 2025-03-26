i
g/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Usings.csï
/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/INotificationSender.cs
	namespace 	
Modules
 
. 
Notification 
. 
Domain %
.% &

Interfaces& 0
{ 
public 
	interface 
INotificationSender %
{ 
Task 
< 
bool 
> 
	SendAsync 
( 
Notifications *
notification+ 7
)7 8
;8 9
Task 
< 
string 
> 
Send 
( 
Notifications '
notification( 4
)4 5
;5 6
}		 
}

 ·
É/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/INotificationRepository.cs
	namespace 	
Modules
 
. 
Notification 
. 
Domain %
.% &

Interfaces& 0
{ 
public 
	interface #
INotificationRepository )
{ 
Task 
AddAsync 
( 
Notifications #
notification_msg$ 4
)4 5
;5 6
Task		 
<		 
IEnumerable		 
<		 
Notifications		 &
>		& '
>		' ((
GetPendingNotificationsAsync		) E
(		E F
)		F G
;		G H
Task

 
UpdateStatusAsync

 
(

 
Guid

 #
notificationId

$ 2
,

2 3
NotificationStatus

4 F
status

G M
)

M N
;

N O
} 
} è
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Enums/NotificationType.cs
	namespace 	
Modules
 
. 
Notification 
. 
Domain %
.% &
Enums& +
{ 
public 
enum 
NotificationType 
{ 
Email 
= 
$num 
, 
SMS 
= 
$num 
, 
Push 
= 
$num 
, 
InApp		 
=		 
$num		 
}

 
public 

static 
class -
!RegistrationStatusEnumDescription 9
{ 
public 
static 
NotificationType & 
NotificationTypeEnum' ;
(; <
int< ?
input@ E
)E F
{ 	
if 
( 
Enum 
. 
	IsDefined 
( 
typeof %
(% &
NotificationType& 6
)6 7
,7 8
input9 >
)> ?
)? @
{ 
return 
( 
NotificationType (
)( )
input) .
;. /
} 
else 
{ 
throw 
new 
ArgumentException +
(+ ,
$str, S
)S T
;T U
} 
} 	
} 
} ›
y/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Enums/NotificationStatus.cs
	namespace 	
Modules
 
. 
Notification 
. 
Domain %
.% &
Enums& +
{ 
public 
enum 
NotificationStatus 
{ 
Pending 
= 
$num 
, 
Sent 
= 
$num 
, 
Failed 
= 
$num 
}		 
public 

static 
class -
!NotificationStatusEnumDescription 9
{ 
public 
static 
NotificationStatus ("
NotificationStatusEnum) ?
(? @
int@ C
inputD I
)I J
{ 	
if 
( 
Enum 
. 
	IsDefined 
( 
typeof %
(% &
NotificationStatus& 8
)8 9
,9 :
input; @
)@ A
)A B
{ 
return 
( 
NotificationStatus *
)* +
input+ 0
;0 1
} 
else 
{ 
throw 
new 
ArgumentException +
(+ ,
$str, T
)T U
;U V
} 
} 	
} 
} è
w/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Entities/Notifications.cs
	namespace 	
Modules
 
. 
Notification 
. 
Domain %
.% &
Entities& .
{ 
public 
class 
Notifications 
{ 
public 
Guid 
Id 
{ 
get 
; 
private %
set& )
;) *
}+ ,
public 
string 
? 
UserId 
{ 
get  #
;# $
private% ,
set- 0
;0 1
}2 3
public		 
string		 
?		 
Subject		 
{		  
get		! $
;		$ %
private		& -
set		. 1
;		1 2
}		3 4
public

 
string

 
?

 
Message

 
{

  
get

! $
;

$ %
private

& -
set

. 1
;

1 2
}

3 4
public 
NotificationType 
Type  $
{% &
get' *
;* +
private, 3
set4 7
;7 8
}9 :
public 
NotificationStatus !
Status" (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
DateTime 
	CreatedAt !
{" #
get$ '
;' (
private) 0
set1 4
;4 5
}6 7
private 
Notifications 
( 
) 
{  !
}" #
public 
Notifications 
( 
string #
userId$ *
,* +
string, 2
subject3 :
,: ;
string< B
messageC J
,J K
NotificationTypeL \
type] a
)a b
{ 	
Id 
= 
Guid 
. 
NewGuid 
( 
) 
;  
UserId 
= 
userId 
; 
Subject 
= 
subject 
; 
Message 
= 
message 
; 
Type 
= 
type 
; 
Status 
= 
NotificationStatus '
.' (
Pending( /
;/ 0
	CreatedAt 
= 
DateTime  
.  !
UtcNow! '
;' (
} 	
public 
void 

MarkAsSent 
( 
)  
=>! #
Status$ *
=+ ,
NotificationStatus- ?
.? @
Sent@ D
;D E
} 
} 