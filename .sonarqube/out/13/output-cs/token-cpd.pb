n
l/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Usings.cs¿
†/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendNotificationHandler.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
UseCases+ 3
{ 
public 

class #
SendNotificationHandler (
:) *
IRequestHandler+ :
<: ;#
SendNotificationCommand; R
,R S
GuidT X
>X Y
{ 
private 
readonly #
INotificationRepository 0
_repository1 <
;< =
private 
readonly 
INotificationSender ,
_sender- 4
;4 5
public		 #
SendNotificationHandler		 &
(		& '#
INotificationRepository		' >

repository		? I
,		I J
INotificationSender		K ^
sender		_ e
)		e f
{

 	
_repository 
= 

repository $
;$ %
_sender 
= 
sender 
; 
} 	
public 
async 
Task 
< 
Guid 
> 
Handle  &
(& '#
SendNotificationCommand' >
command? F
,F G
CancellationTokenH Y
cancellationTokenZ k
)k l
{ 	
var 
notification_msg  
=! "
new# &
Notifications' 4
(4 5
command5 <
.< =
Request= D
.D E
UserIdE K
,K L
commandM T
.T U
RequestU \
.\ ]
Subject] d
,d e
commandf m
.m n
Requestn u
.u v
Messagev }
,} ~
command	 †
.
† ‡
Request
‡ Ž
.
Ž 
Type
 “
)
“ ”
;
” •
await 
_repository 
. 
AddAsync &
(& '
notification_msg' 7
)7 8
;8 9
var 
sent 
= 
await 
_sender $
.$ %
	SendAsync% .
(. /
notification_msg/ ?
)? @
;@ A
if 
( 
sent 
) 
notification_msg  
.  !

MarkAsSent! +
(+ ,
), -
;- .
await 
_repository 
. 
UpdateStatusAsync /
(/ 0
notification_msg0 @
.@ A
IdA C
,C D
notification_msgE U
.U V
StatusV \
)\ ]
;] ^
return 
notification_msg #
.# $
Id$ &
;& '
}   	
}!! 
}## ÷
†/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendNotificationCommand.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
UseCases+ 3
{ 
public 

class #
SendNotificationCommand (
:) *
IRequest+ 3
<3 4
Guid4 8
>8 9
{ 
public #
SendNotificationRequest &
Request' .
{/ 0
get1 4
;4 5
}6 7
public #
SendNotificationCommand &
(& '#
SendNotificationRequest' >
request? F
)F G
=>H J
RequestK R
=S T
requestU \
;\ ]
}		 
} ñ
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Interfaces/ISmsSender.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +

Interfaces+ 5
{ 
public 
	interface 

ISmsSender 
{ 
string 
SendMessage 
( 
SendSmsRequestDto ,

smsRequest- 7
)7 8
;8 9
Task		 
<		 
string		 
>		 
SendMessageAsync		 %
(		% &
SendSmsRequestDto		& 7

smsRequest		8 B
)		B C
;		C D
}

 
} Ì
€/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/BecsmsResponseDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
record 
BecsmsResponseDto  
{ 
public 
bool 
success 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 
code 
{ 
get 
; 
set "
;" #
}$ %
public !
BecsmsResponseDataDto $
?$ %
data& *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public		 
string		 
?		 
message		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
} 
} Ÿ
€/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/SendSmsRequestDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
record 
SendSmsRequestDto  
{ 
public 
string 
? 
message_content &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
? 
mobileNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
}		 ù
‹/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/MNotifySmsResponseSummaryDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
record (
MNotifySmsResponseSummaryDto +
{ 
public 
string 
? 
_id 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
? 
type 
{ 
get !
;! "
set# &
;& '
}( )
public 
int 

total_sent 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
int		 
contacts		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
public

 
int

 
total_rejected
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
public 
string 
[ 
] 
? 
numbers_sent %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
credit_used 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 
credit_left 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ÿ
„/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/MNotifySmsResponseDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
class !
MNotifySmsResponseDto #
{ 
public 
string 
? 
status 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
? 
code 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
? 
message 
{  
get! $
;$ %
set& )
;) *
}+ ,
public		 (
MNotifySmsResponseSummaryDto		 +
?		+ ,
summary		- 4
{		5 6
get		7 :
;		: ;
set		< ?
;		? @
}		A B
}

 
} ®

ƒ/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/MNotifySmsRequestDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
record  
MNotifySmsRequestDto #
{ 
public 
string 
[ 
] 
? 
	recipient "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
? 
sender 
{ 
get  #
;# $
set% (
;( )
}* +
public		 
string		 
?		 
message		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 
bool

 
is_schedule

 
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
string 
? 
schedule_date $
{% &
get' *
;* +
set, /
;/ 0
}1 2
} 
} ‘

„/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/BecsmsResponseDataDto.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
./ 0
Sms0 3
{ 
public 
record !
BecsmsResponseDataDto $
{ 
public 
string 
? 
key 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
? 
to 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
? 
msg 
{ 
get  
;  !
set" %
;% &
}' (
public		 
string		 
?		 
	sender_id		  
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
 
campaign_id

 "
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
/ 0
} 
} £
‚/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/SendNotificationRequest.cs
	namespace 	
Modules
 
. 
Notification 
. 
Application *
.* +
Dtos+ /
{ 
public 

record #
SendNotificationRequest )
() *
string* 0
UserId1 7
,7 8
string9 ?
Subject@ G
,H I
stringI O
MessageP W
,W X
NotificationTypeY i
Typej n
)n o
;o p
public 

record &
SendNotificationRequestDto ,
(, -
string- 3
UserId4 :
,: ;
string< B
DisplayNameC N
,N O
stringP V
SubjectW ^
,^ _
string` f
Messageg n
,n o
NotificationType	p €
Type
 …
)
… †
;
† ‡
}		 