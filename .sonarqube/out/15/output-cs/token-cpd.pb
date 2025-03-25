ê
å/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Repositories/NotificationRepository.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .
Repositories. :
{ 
public 
class "
NotificationRepository $
:% &#
INotificationRepository' >
{ 
private 	
readonly
 !
NotificationDbContext (

_dbContext) 3
;3 4
public "
NotificationRepository	 
(  !
NotificationDbContext  5
	dbContext6 ?
)? @
{		 

_dbContext

 
=

 
	dbContext

 "
;

" #
} 
public 
async 
Task 
AddAsync "
(" #
Notifications# 0
notification_msg1 A
)A B
{ 	

_dbContext 
. 
Notifications $
.$ %
Add% (
(( )
notification_msg) 9
)9 :
;: ;
await 

_dbContext 
. 
SaveChangesAsync -
(- .
). /
;/ 0
} 	
public 
async 
Task 
< 
IEnumerable %
<% &
Notifications& 3
>3 4
>4 5(
GetPendingNotificationsAsync6 R
(R S
)S T
{ 	
return 
await 

_dbContext #
.# $
Notifications$ 1
.1 2
Where2 7
(7 8
n8 9
=>: <
n= >
.> ?
Status? E
==F H
NotificationStatusI [
.[ \
Pending\ c
)c d
.d e
ToListAsynce p
(p q
)q r
;r s
} 	
public 
async 
Task 
UpdateStatusAsync +
(+ ,
Guid, 0
notificationId1 ?
,? @
NotificationStatusA S
statusT Z
)Z [
{ 	
var 
notification_msg  
=! "
await# (

_dbContext) 3
.3 4
Notifications4 A
.A B
	FindAsyncB K
(K L
notificationIdL Z
)Z [
;[ \
if 
( 
notification_msg  
!=! #
null$ (
)( )
{   
notification_msg!!  
.!!  !
Status!!! '
=!!( )
status!!* 0
;!!0 1
await"" 

_dbContext""  
.""  !
SaveChangesAsync""! 1
(""1 2
)""2 3
;""3 4
}## 
}$$ 	
}%% 
}&& ë
}/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/EmailSender.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .
Services. 6
{ 
public 
class 
EmailSender 
: 
IEmailSender (
{		 
private

 
string

 
_host

 
;

 
private 
int 
_port 
; 
private 
bool 

_enableSSL 
;  
private 
string 
	_userName  
;  !
private 
string 
	_password  
;  !
public 
EmailSender 
( 
string !
host" &
,& '
int( +
port, 0
,0 1
bool2 6
	enableSSL7 @
,@ A
stringB H
userNameI Q
,Q R
stringS Y
passwordZ b
)b c
{ 	
_host 
= 
host 
; 
_port 
= 
port 
; 

_enableSSL 
= 
	enableSSL "
;" #
	_userName 
= 
userName  
;  !
	_password 
= 
password  
;  !
} 	
public 
Task 
SendEmailAsync "
(" #
string# )
email* /
,/ 0
string1 7
subject8 ?
,? @
stringA G
htmlMessageH S
)S T
{ 	
var 
client 
= 
new 

SmtpClient '
(' (
_host( -
,- .
_port/ 4
)4 5
{ !
UseDefaultCredentials %
=& '
false( -
,- .
DeliveryMethod 
=  
SmtpDeliveryMethod! 3
.3 4
Network4 ;
,; <
Credentials 
= 
new !
NetworkCredential" 3
(3 4
	_userName4 =
,= >
	_password? H
)H I
,I J
	EnableSsl   
=   

_enableSSL   &
}!! 
;!! 
string## 
displayName## 
=##  
subject##! (
.##( )
Split##) .
(##. /
$str##/ 2
)##2 3
[##3 4
$num##4 5
]##5 6
;##6 7
string$$ 
emailSubject$$ 
=$$  !
subject$$" )
.$$) *
Split$$* /
($$/ 0
$str$$0 3
)$$3 4
[$$4 5
$num$$5 6
]$$6 7
;$$7 8
return&& 
client&& 
.&& 
SendMailAsync&& '
(&&' (
new&&( +
MailMessage&&, 7
(&&7 8
new&&8 ;
MailAddress&&< G
(&&G H
	_userName&&H Q
,&&Q R
displayName&&S ^
)&&^ _
.&&_ `
ToString&&` h
(&&h i
)&&i j
,&&j k
email&&l q
,&&q r
emailSubject&&s 
,	&& Ä
htmlMessage
&&Å å
)
&&å ç
{
&&é è

IsBodyHtml
&&ê ö
=
&&õ ú
true
&&ù °
}
&&¢ £
)
&&£ §
;
&&§ •
}(( 	
})) 
}** q
o/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Usings.cs∑N
{/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/SMSSender.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .
Services. 6
{ 
public 
class 
	SmsSender 
: 

ISmsSender $
{ 
public 
IConfiguration 
_configuration ,
{- .
get/ 2
;2 3
}4 5
public 
	SmsSender	 
( 
IConfiguration !
configuration" /
)/ 0
{ 
_configuration 
= 
configuration *
;* +
} 
public 
string 
SendMessage !
(! "
SendSmsRequestDto" 3

smsRequest4 >
)> ?
{ 	
try 
{ 
return 
sendSMS_Via_BECSMS )
() *

smsRequest* 4
.4 5
mobileNumber5 A
!A B
,B C

smsRequestD N
.N O
message_contentO ^
!^ _
)_ `
;` a
} 
catch 
( 
	Exception 
ex 
)  
{   
return!! 
ex!! 
.!! 
ToString!! "
(!!" #
)!!# $
;!!$ %
}"" 
}## 	
public%% 
async%% 
Task%% 
<%% 
string%%  
>%%  !
SendMessageAsync%%" 2
(%%2 3
SendSmsRequestDto%%3 D

smsRequest%%E O
)%%O P
{&& 	
try(( 
{)) 
return** 
await** 
sendSMS_Via_mNotify** 0
(**0 1

smsRequest**1 ;
.**; <
mobileNumber**< H
!**H I
,**I J

smsRequest**K U
.**U V
message_content**V e
!**e f
)**f g
;**g h
},, 
catch-- 
(-- 
	Exception-- 
ex-- 
)--  
{.. 
return// 
ex// 
.// 
ToString// "
(//" #
)//# $
;//$ %
}00 
}11 	
private55 
string55 
sendSMS_Via_BECSMS55 )
(55) *
string55* 0
mobileNumber551 =
,55= >
string55? E
message55F M
)55M N
{66 	
try77 
{88 
string99 
api_Key99 
=99  
_configuration99! /
[99/ 0
$str990 ?
]99? @
!99@ A
;99A B
string:: 
	sender_Id::  
=::! "
_configuration::# 1
[::1 2
$str::2 C
]::C D
!::D E
;::E F
string;; 
phone_Number;; #
=;;$ %
mobileNumber;;& 2
;;;2 3
string<< 
message_to_send<< &
=<<' (
message<<) 0
;<<0 1
string>> 
sendMessageUrl>> %
=>>& '
_configuration>>( 6
[>>6 7
$str>>7 G
]>>G H
+>>I J
$str>>K Y
+>>Z [
api_Key>>\ c
+>>d e
$str>>f l
+>>m n
phone_Number>>o {
+>>| }
$str	>>~ Ö
+
>>Ü á
HttpUtility
>>à ì
.
>>ì î
	UrlEncode
>>î ù
(
>>ù û
message_to_send
>>û ≠
)
>>≠ Æ
+
>>Ø ∞
$str
>>± æ
+
>>ø ¿
	sender_Id
>>¡  
;
>>  À
HttpWebRequest?? 
request?? &
=??' (
(??) *
HttpWebRequest??* 8
)??8 9

WebRequest??9 C
.??C D
Create??D J
(??J K
sendMessageUrl??K Y
)??Y Z
;??Z [
HttpWebResponseAA 
responseAA  (
=AA) *
(AA+ ,
HttpWebResponseAA, ;
)AA; <
requestAA< C
.AAC D
GetResponseAAD O
(AAO P
)AAP Q
;AAQ R
usingCC 
(CC 
StreamReaderCC #
readerCC$ *
=CC+ ,
newCC- 0
StreamReaderCC1 =
(CC= >
responseCC> F
.CCF G
GetResponseStreamCCG X
(CCX Y
)CCY Z
)CCZ [
)CC[ \
{DD 
stringEE 
	inputLineEE $
=EE% &
readerEE' -
.EE- .
ReadLineEE. 6
(EE6 7
)EE7 8
!EE8 9
.EE9 :
TrimEE: >
(EE> ?
)EE? @
;EE@ A
varGG 
sms_responseGG $
=GG% &
JsonSerializerGG' 5
.GG5 6
DeserializeGG6 A
<GGA B
BecsmsResponseDtoGGB S
>GGS T
(GGT U
	inputLineGGU ^
)GG^ _
;GG_ `
returnII 
sms_responseII '
!II' (
.II( )
messageII) 0
isII1 3
notII4 7
nullII8 <
?II= >
sms_responseII? K
.IIK L
codeIIL P
switchIIQ W
{JJ 
$numKK 
=>KK 
sms_responseKK  ,
.KK, -
messageKK- 4
,KK4 5
$numLL 
=>LL 
sms_responseLL  ,
.LL, -
messageLL- 4
,LL4 5
$numMM 
=>MM 
sms_responseMM  ,
.MM, -
messageMM- 4
,MM4 5
$numNN 
=>NN 
sms_responseNN  ,
.NN, -
messageNN- 4
,NN4 5
$numOO 
=>OO 
sms_responseOO  ,
.OO, -
messageOO- 4
,OO4 5
$numPP 
=>PP 
sms_responsePP  ,
.PP, -
messagePP- 4
,PP4 5
$numQQ 
=>QQ 
$strQQ  /
,QQ/ 0
_RR 
=>RR 
stringRR #
.RR# $
EmptyRR$ )
,RR) *
}TT 
:TT 
stringTT 
.TT 
EmptyTT $
;TT$ %
}WW 
}YY 
catchZZ 
(ZZ 
	ExceptionZZ 
exZZ 
)ZZ  
{[[ 
return\\ 
ex\\ 
.\\ 
ToString\\ "
(\\" #
)\\# $
;\\$ %
}]] 
}^^ 	
privateaa 
asyncaa 
Taskaa 
<aa 
stringaa !
>aa! "
sendSMS_Via_mNotifyaa# 6
(aa6 7
stringaa7 =
mobileNumberaa> J
,aaJ K
stringaaL R
messageaaS Z
)aaZ [
{bb 	
trycc 
{dd 
usingee 
(ee 
varee 
_clientee "
=ee# $
newee% (

HttpClientee) 3
(ee3 4
)ee4 5
)ee5 6
{ff 
stringgg 
[gg 
]gg 
receivingNumbergg ,
=gg- .
newgg/ 2
stringgg3 9
[gg9 :
]gg: ;
{gg< =
mobileNumbergg> J
}ggK L
;ggL M 
MNotifySmsRequestDtoii (
	sendModelii) 2
=ii3 4
newii5 8 
MNotifySmsRequestDtoii9 M
(iiM N
)iiN O
;iiO P
	sendModelll 
.ll 
	recipientll '
=ll( )
receivingNumberll* 9
;ll9 :
	sendModelmm 
.mm 
sendermm $
=mm% &
_configurationmm' 5
[mm5 6
$strmm6 K
]mmK L
;mmL M
	sendModelnn 
.nn 
messagenn %
=nn& '
messagenn( /
;nn/ 0
	sendModeloo 
.oo 
is_scheduleoo )
=oo* +
falseoo, 1
;oo1 2
	sendModelpp 
.pp 
schedule_datepp +
=pp, -
$strpp. 0
;pp0 1
varrr 
urlrr 
=rr 
$"rr  
{rr  !
_configurationrr! /
[rr/ 0
$strrr0 D
]rrD E
}rrE F
$strrrF K
{rrK L
_configurationrrL Z
[rrZ [
$strrr[ o
]rro p
}rrp q
"rrq r
;rrr s
StringContenttt !
contenttt" )
=tt* +
newtt, /
StringContenttt0 =
(tt= >
JsonSerializertt> L
.ttL M
	SerializettM V
(ttV W
	sendModelttW `
)tt` a
,tta b
encodingttc k
:ttk l
Systemttm s
.tts t
Textttt x
.ttx y
Encoding	tty Å
.
ttÅ Ç
UTF8
ttÇ Ü
,
ttÜ á
$str
ttà ö
)
ttö õ
;
ttõ ú
usingvv 
(vv 
varvv 
responsevv '
=vv( )
awaitvv* /
_clientvv0 7
.vv7 8
	PostAsyncvv8 A
(vvA B
urlvvB E
,vvE F
contentvvG N
)vvN O
)vvO P
{ww 
stringxx 
apiResponsexx *
=xx+ ,
awaitxx- 2
responsexx3 ;
.xx; <
Contentxx< C
.xxC D
ReadAsStringAsyncxxD U
(xxU V
)xxV W
;xxW X
varzz 
sendResponsezz (
=zz) *
JsonSerializerzz+ 9
.zz9 :
Deserializezz: E
<zzE F!
MNotifySmsResponseDtozzF [
>zz[ \
(zz\ ]
apiResponsezz] h
)zzh i
;zzi j
return{{ 
sendResponse{{ +
!{{+ ,
.{{, -
status{{- 3
!{{3 4
;{{4 5
}|| 
}}} 
}~~ 
catch 
( 
	Exception 
ex 
)  
{
ÄÄ 
return
ÅÅ 
ex
ÅÅ 
.
ÅÅ 
ToString
ÅÅ "
(
ÅÅ" #
)
ÅÅ# $
;
ÅÅ$ %
}
ÇÇ 
}
ÉÉ 	
}
ââ 
}ää ∆
~/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/NotificationDbContext.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
{ 
public 
class !
NotificationDbContext #
:$ %
ModuleDbContext& 5
{ 
	protected 
override 
string !
Schema" (
=>) +
$str, 1
;1 2
public		 !
NotificationDbContext		 $
(		$ %
DbContextOptions		% 5
<		5 6!
NotificationDbContext		6 K
>		K L
options		M T
)		T U
:		V W
base		X \
(		\ ]
options		] d
)		d e
{

 	
} 
public 
DbSet 
< 
Notifications "
>" #
Notifications$ 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
} 
} é
à/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/SmsNotificationService.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .
Services. 6
{ 
public 
class "
SmsNotificationService $
:% &
INotificationSender' :
{ 
private		 
readonly		 

ISmsSender		 #

_smsSender		$ .
;		. /
public "
SmsNotificationService %
(% &

ISmsSender& 0
	smsSender1 :
): ;
=>< >

_smsSender? I
=J K
	smsSenderL U
;U V
public 
Task 
< 
string 
> 
Send  
(  !
Notifications! .
values/ 5
)5 6
{ 	
if 
( 
values 
. 
Type 
!= 
NotificationType /
./ 0
SMS0 3
)3 4
return 
Task 
. 

FromResult &
(& '
false' ,
., -
ToString- 5
(5 6
)6 7
)7 8
;8 9
SendSmsRequestDto 
request %
=& '
new( +
SendSmsRequestDto, =
{> ?
mobileNumber@ L
=M N
valuesO U
.U V
UserIdV \
,\ ]
message_content^ m
=n o
valuesp v
.v w
Messagew ~
}	 Ä
;
Ä Å
var 
response 
= 

_smsSender %
.% &
SendMessage& 1
(1 2
request2 9
)9 :
;: ;
return 
Task 
. 

FromResult "
(" #
response# +
)+ ,
;, -
} 	
public 
async 
Task 
< 
bool 
> 
	SendAsync  )
() *
Notifications* 7
values8 >
)> ?
{ 	
if 
( 
values 
. 
Type 
!= 
NotificationType /
./ 0
SMS0 3
)3 4
return 
false 
; 
SendSmsRequestDto 
request %
=& '
new( +
SendSmsRequestDto, =
{> ?
mobileNumber@ L
=M N
valuesO U
.U V
UserIdV \
,\ ]
message_content^ m
=n o
valuesp v
.v w
Messagew ~
}	 Ä
;
Ä Å
var!! 
response!! 
=!! 
await!!  

_smsSender!!! +
.!!+ ,
SendMessageAsync!!, <
(!!< =
request!!= D
)!!D E
;!!E F
return"" 
true"" 
;"" 
}## 	
}$$ 
}%% æ$
Ö/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/NotificationService.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .
Services. 6
{ 
public 
class 
NotificationService !
:" #
INotificationSender$ 7
{ 
private		 
readonly		 
IEmailSender		 %
_emailSender		& 2
;		2 3
private

 
readonly

 

ISmsSender

 #

_smsSender

$ .
;

. /
public 
NotificationService "
(" #
IEmailSender# /
emailSender0 ;
,; <

ISmsSender= G
	smsSenderH Q
)Q R
{ 	
_emailSender 
= 
emailSender &
;& '

_smsSender 
= 
	smsSender "
;" #
} 	
public 
async 
Task 
< 
string  
>  !
Send" &
(& '
Notifications' 4
values5 ;
); <
{ 	
if 
( 
values 
. 
Type 
== 
NotificationType /
./ 0
Email0 5
)5 6
{ 
await 
_emailSender "
." #
SendEmailAsync# 1
(1 2
values2 8
.8 9
UserId9 ?
!? @
,@ A
valuesB H
.H I
SubjectI P
!P Q
,Q R
valuesS Y
.Y Z
MessageZ a
!a b
.b c
ToStringc k
(k l
)l m
)m n
;n o
return 
true 
. 
ToString $
($ %
)% &
;& '
} 
if 
( 
values 
. 
Type 
== 
NotificationType /
./ 0
SMS0 3
)3 4
{ 
var 
response 
= 

_smsSender )
.) *
SendMessage* 5
(5 6
new6 9
SendSmsRequestDto: K
{L M
mobileNumberN Z
=[ \
values] c
.c d
UserIdd j
,j k
message_contentl {
=| }
values	~ Ñ
.
Ñ Ö
Message
Ö å
}
ç é
)
é è
;
è ê
return   
response   
;    
}!! 
return## 
false## 
.## 
ToString## !
(##! "
)##" #
;### $
}$$ 	
public&& 
async&& 
Task&& 
<&& 
bool&& 
>&& 
	SendAsync&&  )
(&&) *
Notifications&&* 7
values&&8 >
)&&> ?
{'' 	
if)) 
()) 
values)) 
.)) 
Type)) 
==)) 
NotificationType)) /
.))/ 0
Email))0 5
)))5 6
{** 
await++ 
_emailSender++ "
.++" #
SendEmailAsync++# 1
(++1 2
values++2 8
.++8 9
UserId++9 ?
!++? @
,++@ A
values++B H
.++H I
Subject++I P
!++P Q
,++Q R
values++S Y
.++Y Z
Message++Z a
!++a b
.++b c
ToString++c k
(++k l
)++l m
)++m n
;++n o
return,, 
true,, 
;,, 
}.. 
if00 
(00 
values00 
.00 
Type00 
==00 
NotificationType00 .
.00. /
SMS00/ 2
)002 3
{11 
var22 
response22 
=22 
await22 $

_smsSender22% /
.22/ 0
SendMessageAsync220 @
(22@ A
new22A D
SendSmsRequestDto22E V
{22W X
mobileNumber22Y e
=22f g
values22h n
.22n o
UserId22o u
,22u v
message_content	22w Ü
=
22á à
values
22â è
.
22è ê
Message
22ê ó
}
22ó ò
)
22ò ô
;
22ô ö
return33 
true33 
;33 
}44 
return66 
false66 
;66 
}77 	
}88 
}99 Ô
è/Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Extensions/ServiceCollectionExtensions.cs
	namespace 	
Modules
 
. 
Notification 
. 
Infrastructure -
.- .

Extensions. 8
;8 9
public

 
static

 
class

 '
ServiceCollectionExtensions

 /
{ 
public 

static 
IServiceCollection $)
AddNotificationInfrastructure% B
(B C
thisC G
IServiceCollectionH Z
services[ c
,c d
IConfiguratione s
configt z
)z {
{ 
services 
. 
AddDbContext 
< !
NotificationDbContext /
>/ 0
(0 1
options1 8
=>9 ;
options< C
.C D
UseSqlServerD P
(P Q
configQ W
.W X
GetConnectionStringX k
(k l
$strl }
)} ~
)~ 
)	 Ä
;
Ä Å
services 
. 
AddTransient 
< 
IEmailSender *
,* +
EmailSender, 7
>7 8
(8 9
i9 :
=>; =
new> A
EmailSenderB M
(M N
config 
[ 
$str (
]( )
!) *
,* +
config 
. 
GetValue 
< 
int 
>  
(  !
$str! 6
)6 7
,7 8
config 
. 
GetValue 
< 
bool  
>  !
(! "
$str" <
)< =
,= >
config 
[ 
$str ,
], -
!- .
,. /
config 
[ 
$str ,
], -
!- .
) 
) 	
;	 

return 
services 
; 
} 
} 