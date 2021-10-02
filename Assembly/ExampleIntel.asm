; Assembler (x86) version of 99 Bottles of beer
; 
; This version is for NASM compiler but doesn't use any 
; macros, just all basic instructions for x86 assembler.
; Also only putchar() function is used to print character
; onto screen, and the whole rest is in code.
;
; nasm -fwin32 99.asm
; gcc -o 99.exe 99.obj

        global  _main
        extern  _putchar

        segment .data

_line_1_1        db ' bottles of beer on the wall, ', 0
_line_1_2        db ' bottles of beer.', 13, 10, 0
_line_2_1        db 'Take one down and pass it around, ', 0
_line_2_2        db ' bottles of beer on the wall.', 13, 10, 13, 10, 0
_line_2_2_one    db ' bottle of beer on the wall.', 13, 10, 13, 10, 0
_ending_lines    db '1 bottle of beer on the wall, 1 bottle of beer.', 13, 10
                 db 'Take one down and pass it around, no more bottles of beer on the wall.', 13,
10, 13, 10
                 db 'No more bottles of beer on the wall, no more bottles of beer. ', 13, 10
                 db 'Go to the store and buy some more, 99 bottles of beer on the wall.', 13, 10, 0

        segment .text

; this function converts integer in range 0-99 to string
_integer_to_string:
        mov     eax, dword [esp + 08h]    ; get the vavlue
        mov     ecx, 10                   ; 
        sub     edx, edx                  
        div     ecx                       ; divide it by 10
        mov     ecx, dword [esp + 04h]    ; get the output offset
        test    eax, eax                  ; is greater than 9
        jz      .skip_first_digit         ; skip saving 0 char if no
        add     al, 030h                  ; convert number to ascii char
        mov     byte [ecx], al            ; save
        inc     ecx                       ; increase pointer
        jmp     .dont_test_second_digit   ; 
     .skip_first_digit:                   ; only if less then 10
        test    edx, edx
        jz      .skip_second_digit
     .dont_test_second_digit:             ; if it was greater than 10
        add     dl, 030h                  ; than second digit must by 
        mov     byte [ecx], dl            ; written at no condition
        inc     ecx                     
     .skip_second_digit:                  ; only skip if value was 0
        mov     byte [ecx], ah            ; save the null ending char
        retn    4                         ; ret and restore stack
; function prints null-terminated line to stdout
_show_line:
        push    edi                       ; function save registers
        push    esi
        mov     edi, dword [esp + 0Ch]    ; get the pointer to string
        sub     eax, eax                  ; look for zeros
        sub     ecx, ecx                        
        dec     ecx                       ; set ecx to -1
        repnz   scasb                     ; search for 0 in string
        neg     ecx
        sub     ecx, 2                    ; get the string length w/o zero
        mov     esi, dword [esp + 0Ch]    ; get pointer once again
     .putchar_loop:
        push    ecx                       ; keep the counter
        lodsb                             ; get the char
        push    eax                       
        call    _putchar                  ; print char to stdout
        add     esp, 4                    ; correct stack 
        pop     ecx                       ; get back the counter
        dec     ecx                     
        jnz     .putchar_loop             ; if not last char then get next
        pop     esi                       ; restore registers
        pop     edi
        retn    4
; prints string for only one number
_bottles:
        push    ebp                       ; keep the offset to call params
        mov     ebp, esp
        sub     esp, 4                    ; reserve one local variable
        mov     eax, dword [ebp + 08h]    ; get number of bottles
        dec     eax                       ; is it 1?
        jnz     .more_than_one            ; nope, it's not
        push    _ending_lines             ; print the last lines
        call    _show_line
        jmp     .end                      ; exit function
     .more_than_one:
        inc     eax                       ; get the original value
        push    eax                       ; convert it to string
        lea     eax, [ebp - 04h]
        push    eax                       ; string will be stored here
        call    _integer_to_string
        lea     eax, [ebp - 04h]
        push    eax
        call    _show_line                ; 'xx'
        push    _line_1_1
        call    _show_line                ; ' bottles of beer on the wall, '
        lea     eax, [ebp - 04h]
        push    eax
        call    _show_line                ; 'xx'
        push    _line_1_2
        call    _show_line                ; ' bottles of beer.'
        mov     eax, dword [ebp + 08h]
        dec     eax                       ; in second line the value is one less
        push    eax
        lea     eax, [ebp - 04h]
        push    eax
        call    _integer_to_string        ; convert it to string
        push    _line_2_1
        call    _show_line                ; 'Take one down and pass it around, '
        lea     eax, [ebp - 04h]
        push    eax
        call    _show_line                ; 'xx'
        cmp     dword [ebp + 08h], 2
        jnz     .second_line_for_more_than_one
        push    _line_2_2_one             ; ' bottle of beer on the wall.'
        jmp     .show_line
     .second_line_for_more_than_one:   
        push    _line_2_2                 ; ' bottles of beer on the wall.'
     .show_line:
        call    _show_line
     .end:
        leave
        retn    4
; main function, the command line arguments are not important
_main:        
        pushad
        mov     ecx, 99                   ; printf from 99
     .main_loop:
        push    ecx
        push    ecx
        call    _bottles                  ; print lines for this value
        pop     ecx
        loop    .main_loop                ; if still greater than zero
        popad
        sub     eax, eax                  ; That's all folks!
        retn
        
;https://pt.stackoverflow.com/q/178804/101
