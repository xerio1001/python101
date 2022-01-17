from math import sqrt

class Punt:   
    def __init__(self, x, y):  # x, y zijn bv attributen      
        self.x = x
        self.y = y

    def __repr__(self):
        return f'<Punt> x:{self.x}, y:{self.y}'

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

class rechthoek:
    def __init__(self, lbHoek, breedte, hoogte):
        self.lbHoek = lbHoek
        self.breedte = breedte
        self.hoogte = hoogte

    def __repr__(self):
        return f'Eerste hoek= {self.lbHoek.x,self.lbHoek.y},b= {self.breedte},h= {self.hoogte}'

    def oppervlakte(self):
        totaalOppervlakte = self.breedte * self.hoogte
        return f'De totale oppervlakte is {totaalOppervlakte}'

    def omtrek(self):
        totaalOmtrek = (self.breedte * 2) + (self.hoogte * 2)
        return f'De totale omtrek is {totaalOmtrek}'

    def rechterOnderHoek(self):
        roHoekX = self.lbHoek.x + self.breedte
        roHoekY = self.lbHoek.y + self.hoogte
        return f'De linksboven hoek = {self.lbHoek.x,self.lbHoek.y} en de rechtonder hoek = {roHoekX,roHoekY}'


p = Punt(3, 4)
p.translatie(1, 2)
p.invertX()
p.invertY()

r = rechthoek(p, 10, 5)

print(p)
print()
print(r)

print(r.oppervlakte())
print(r.omtrek())
print(r.rechterOnderHoek())

exit()

lijst = []

class Punt:
    def __init__(self, x=0, y=0, color=(0, 0, 255)):
        self.x = x
        self.y = y
        self.color = color

    def __repr__(self):
        return f'(<Punt> x:{self.x}, y:{self.y}, <color> {self.color})'


    def printCoords(self):
        print(self.x, self.y)

p = Punt(5,5,(5,5,255))
print(p)

#for x_val in range(4):
    #for y_val in range(4):
        #p = Punt(x_val, y_val)
        #lijst.append(p)

#for item in lijst:
    #item.printCoords()