class C:
   def f(): pass
   class D:
     def g(): pass

print(C.__qualname__)
print(C.f.__qualname__)
print(C.D.__qualname__)
print(C.D.g.__qualname__)

def f():
   def g(): pass
   return g

print(f.__qualname__)
print(f().__qualname__)

#https://pt.stackoverflow.com/q/339502/101
