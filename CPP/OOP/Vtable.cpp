struct Foo { virtual ~Foo(); virtual int a() { return 1; } };
struct Bar: public Foo { int a() { return 2; } };
void f(Foo& arg) {
  Foo x; x.a(); // non-virtual: always calls Foo::a()
  Bar y; y.a(); // non-virtual: always calls Bar::a()
  arg.a();      // virtual: must dispatch via vtable
  Foo z = arg;  // copy constructor Foo::Foo(const Foo&) will convert to Foo
  z.a();        // non-virtual Foo::a, since z is a Foo, even if arg was not
}

typedef struct Foo_t Foo;   // forward declaration
struct slotsFoo {           // list all virtual functions of Foo
  const void *parentVtable; // (single) inheritance
  void (*destructor)(Foo*); // virtual destructor Foo::~Foo
  int (*a)(Foo*);           // virtual function Foo::a
};
struct Foo_t {                      // class Foo
  const struct slotsFoo* vtable;    // each instance points to vtable
};
void destructFoo(Foo* self) { }     // Foo::~Foo
int aFoo(Foo* self) { return 1; }   // Foo::a()
const struct slotsFoo vtableFoo = { // only one constant table
  0,                                // no parent class
  destructFoo,
  aFoo
};
void constructFoo(Foo* self) {      // Foo::Foo()
  self->vtable = &vtableFoo;        // object points to class vtable
}
void copyConstructFoo(Foo* self,
                      Foo* other) { // Foo::Foo(const Foo&)
  self->vtable = &vtableFoo;        // don't copy from other!
}

typedef struct Bar_t {              // class Bar
  Foo base;                         // inherit all members of Foo
} Bar;
void destructBar(Bar* self) { }     // Bar::~Bar
int aBar(Bar* self) { return 2; }   // Bar::a()
const struct slotsFoo vtableBar = { // one more constant table
  &vtableFoo,                       // can dynamic_cast to Foo
  (void(*)(Foo*)) destructBar,      // must cast type to avoid errors
  (int(*)(Foo*)) aBar
};
void constructBar(Bar* self) {      // Bar::Bar()
  self->base.vtable = &vtableBar;   // point to Bar vtable
}

void f(Foo* arg) {                  // same functionality as above
  Foo x; constructFoo(&x); aFoo(&x);
  Bar y; constructBar(&y); aBar(&y);
  arg->vtable->a(arg);              // virtual function call
  Foo z; copyConstructFoo(&z, arg);
  aFoo(&z);
  destructFoo(&z);
  destructBar(&y);
  destructFoo(&x);
}

//https://pt.stackoverflow.com/q/577815/101
