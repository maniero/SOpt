int add(int i,int j) {
    int p = i + j;
    return p;
}


.globl add
add:
    pushl %ebp          //cabeçalho salvando em pilha o registrador que será manipulado
    movl %esp, %ebp     //joga o ponteiro da pilha em ebp
    subl $4, %esp      //aloca espaço (4 bytes) na pilha para a variável p
    movl 8(%ebp), %edx  //8(%ebp) é o i, só atribuição do que está na pilha + 8 bytes
    addl 12(%ebp), %edx //12(%ebp) é o j, aqui já faz a adição, edx é o outro operando
    movl %edx, -4(%ebp) //-4(%ebp) é o p, atribuição
    movl -4(%ebp), %eax //eax é o registrador de retorno
    leave               //é o mesmo que dar movl %ebp, %esp; popl %ebp ret, é o rodapé


add(1, 2)


pushl $2  //joga o segundo parâmetro na pilha
pushl $1  //joga o primeiro parâmetro na pilha
call add  //desvia para a função


push    rbp
mov     rbp, rsp
mov     DWORD PTR [rbp-20], edi
mov     DWORD PTR [rbp-24], esi
mov     edx, DWORD PTR [rbp-20]
mov     eax, DWORD PTR [rbp-24]
add     eax, edx
mov     DWORD PTR [rbp-4], eax
mov     eax, DWORD PTR [rbp-4]
pop     rbp
ret

//https://pt.stackoverflow.com/q/170372/101
