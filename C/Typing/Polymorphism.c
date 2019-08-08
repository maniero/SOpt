typedef struct {
   data member_x;
} base;

typedef struct {
   struct base;
   data member_y;
} derived;

//esta função pertence à base e pode ser usada com estruturas derived
void function_on_base(struct base * a);

//esta função só pode receber derived de forma segura   
void function_on_derived(struct derived * b);

struct inode_operations {
    int (*create) (struct inode *,struct dentry *,int, struct nameidata *);
    struct dentry * (*lookup) (struct inode *,struct dentry *, struct nameidata *);
    ...
};

//chamada
struct inode_operations   *i_op;
i_op -> create(...);

typedef struct {
   int (*SomeFunction)(TheClass* this, int i);
   void (*OtherFunction)(TheClass* this, char* c);
} VTable;

typedef struct {
   VTable* pVTable;
   int member;
} TheClass;

//chamada
int CallSomeFunction(TheClass* this, int i) {
  (this->SomeFunction)(this, i);
}

func Base()
    var objeto = { => }
    objeto["dado"] = 1
    objeto["teste"] = &Base_teste
    return objeto
func Base_teste()
    return "base"
func Derivada()
    var objeto = { => }
    objeto["dado"] = 1
    objeto["dado2"] = "dado"
    objeto["teste"] = &Berivada_teste
    return objeto
func Derivada_teste()
    return "derivada"
//chamada
var base = Base()
var derivada = Derivada()
//imprime base porque a variável base possui um membro "teste" que contem &Base_teste
print base.teste()
//imprime derivada porque a variável base possui um membro "teste" que contem &Derivada_teste
print derivada.teste()

//https://pt.stackoverflow.com/q/53108/101
