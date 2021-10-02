;99 Bottles of Beer generator
;For ARM processors running RISCOS
;Using built in BASIC assembler
;

MOV R7, #99              ;bottle count kept in R7
MOV R12, R14             ;store caller return address

.beginverse              ;(_prints verses then returns to caller_)
BL  bottlesofbeer
ADR R0, onthewall
SWI "OS_Write0"          ;prints string at address in R0
BL  bottlesofbeer
SWI "OS_NewLine"
ADR R0, take
SWI "OS_Write0"
SUBS R7,R7,#1            
BLNE bottlesofbeer       ;beer left
BLEQ nobeer              ;no beer left
ADR R0, onthewall
SWI "OS_Write0"
SWI "OS_NewLine"
SWI "OS_NewLine"
BNE beginverse           ;go again if there's beer left
BL buymorebeer           ;print last verse
MOV PC, R12              ;exit to caller

.bottlesofbeer           ;(_prints "x bottle(s) of beer"_)
MOV R0, R7               ;arg1- number of bottles
ADR R1, bottlenum        ;arg2- buffer address
MOV R2, #3               ;arg3- buffer length
SWI "OS_ConvertInteger3" ;convert number of beers to string
SWI "OS_Write0"          ;and print it
CMP R7, #1             
ADR R0, bottles          ;
ADREQ R0, bottle         ;bottles is replaced with bottle if 1 bottle left
SWI "OS_Write0"
ADR R0, ofbeer
SWI "OS_Write0"
CMP R1, #0               ;unset zero flag so "nobeer" doesnt execute after return
MOV PC, R14              ;return

.buymorebeer             ;(_prints final verse_)
MOV R11, R14             ;save return address
BL nobeer
ADR R0, onthewall
SWI "OS_Write0"
ADR R0, comma
SWI "OS_Write0"
BL nobeer
SWI "OS_NewLine"
ADR R0, gotostore
SWI "OS_Write0"
MOV PC, R11              ;return to saved address

.nobeer                  ;(_prints "no more bottles of beer"_)
ADR R0, nomore
SWI "OS_Write0"
ADR R0, bottles
SWI "OS_Write0"
ADR R0, ofbeer
SWI "OS_Write0"
MOV PC, R14

;string components

.ofbeer
EQUS "of beer"           ;string contents
EQUB 0                   ;zero terminator

.onthewall
EQUS " on the wall "
EQUB 0

.bottle
EQUS " bottle "
EQUB 0

.bottles
EQUS " bottles "
EQUB 0

.take
EQUS "Take one down and pass it around, "
EQUB 0

.nomore
EQUS "no more"
EQUB 0

.bottlenum
EQUS "  "
EQUB 0

.comma
EQUS ","
EQUB 0

.gotostore
EQUS "Go to the store and buy some more...99 bottles of beer."
EQUB 0

;https://pt.stackoverflow.com/q/178804/101
