class Panzer():
   def __init__(self, name):
      self.name = name
      self.life = 100
      self.blin = 100

group = [Panzer("drogo"), Panzer("cabal"), Panzer("sirius")]
for i in group:
    print(i.name)

#https://pt.stackoverflow.com/q/461456/101
