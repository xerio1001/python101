from math import sqrt

class Punt:   
    def __init__(self, x, y):  # x, y zijn bv attributen      
        self.x = x
        self.y = y
        
    def __repr__(self):
        return f'x:{self.x}, y:{self.y}'

    def afstandTotOorsprong(self): # method is hier de functie
        return sqrt(self.x*self.x + self.y*self.y)

    def translatie(self, deltaX, deltaY):
        self.x += deltaX
        self.y += deltaY

    def invertX(self):
        self.y = self.y * -1

    def invertY(self):
        self.x = self.x * -1

    def invert(self):
        self.invertX
        self.invertY

    def __mul__(self, other):
        if(isinstance(other, Punt)):
            return self.x * other.y, self.y * other.x
        elif(isinstance(other, int)):
            return self.x * other, self.y * other

class Rechthoek:
    def __init__(self,lbHoek, breedte, hoogte):
        self.lbHoek = lbHoek
        self.breedte = breedte
        self.hoogte = hoogte

    def __repr__(self):
        return f'{self.lbHoek.x,self.lbHoek.y},b= {self.breedte},h= {self.hoogte}'

    def oppervlakte(self):
        self.totaalOppervlakte = self.breedte * self.hoogte
        return self.totaalOppervlakte

    def __eq__(self, other):
        return self.breedte == other.breedte and self.hoogte == other.hoogte

    def __lt__(self, other):
        return self.oppervlakte() < other.oppervlakte()

    def __gt__(self, other):
        return self.oppervlakte() > other.oppervlakte()

    def omtrek(self):
        totaalOmtrek = (self.breedte * 2) + (self.hoogte * 2)
        return f'Totale omtrek: {totaalOmtrek}'

    def rechterOnderHoek(self):
        roHoekX = self.lbHoek.x + self.breedte
        roHoekY = self.lbHoek.y + self.hoogte
        return f'Linksboven hoek = {self.lbHoek.x,self.lbHoek.y}, rechtonder hoek = {roHoekX,roHoekY}'


p1 = Punt(3, 4)
p2 = Punt(1, 12)
p3 = Punt(1, 2)
#p1.translatie(1, 2)
#p1.invertX()
#p1.invertY()

r1 = Rechthoek(p1, 10, 5)
r2 = Rechthoek(p2, 9, 4)

print(p1)
print(p2)
print()
print(r1)
print(r2)

print(r1.oppervlakte())
print(r1.omtrek())
print(r1.rechterOnderHoek())
print()
print(r2.oppervlakte())
print(r2.omtrek())
print(r2.rechterOnderHoek())

print("maal", p3*p1)
print("equals", r1 == r2)
print("gt", r1 > r2)