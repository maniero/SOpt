using (Font font1 = new Font("Arial", 10.0f)) {
    byte charset = font1.GdiCharSet;
}

//É o mesmo que:

{
  Font font1 = new Font("Arial", 10.0f);
  try {
    byte charset = font1.GdiCharSet;
  }
  finally {
    if (font1 != null)
      ((IDisposable)font1).Dispose();
  }
}

static int Test() {
    try {
        return SomeNumber();
    } finally {
        Foo();
    }
}

//Compila para o CIL:

.method private hidebysig static int32 Test() cil managed
{
    .maxstack 1
    .locals init (
        [0] int32 CS$1$0000)
    L_0000: call int32 Program::SomeNumber()
    L_0005: stloc.0 
    L_0006: leave.s L_000e
    L_0008: call void Program::Foo()
    L_000d: endfinally 
    L_000e: ldloc.0 
    L_000f: ret 
    .try L_0000 to L_0008 finally handler L_0008 to L_000e
}

//Que seria o mesmo que:

private static int Test()
{
    int CS$1$0000;
    try
    {
        CS$1$0000 = SomeNumber();
    }
    finally
    {
        Foo();
    }
    return CS$1$0000;
}

//http://pt.stackoverflow.com/q/16065/101
