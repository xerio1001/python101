class Punt:   
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def translatie(self, deltaX, deltaY):
        self.x += deltaX
        self.y += deltaY


class rechthoek:
    def __init__(self, loHoek, rbHoek):
        self.loHoek = loHoek
        self.rbHoek = rbHoek

    def getSize(self):
        hoogte = self.loHoek.y - self.rbHoek.y
        breedte = self.loHoek.x - self.rbHoek.x
        return f'breedte = {abs(breedte)}, hoogte = {abs(hoogte)}'

    def verplaats(self, deltaX , deltaY):
        self.loHoek.translatie(deltaX, deltaY)
        self.rbHoek.translatie(deltaX, deltaY)

        

p1 = Punt(3, 1)
p2 = Punt(1, 12)

r = rechthoek(p1, p2)

r.verplaats(1, 1)
print(r.loHoek.x,r.loHoek.y, "", r.rbHoek.x,r.rbHoek.y)
print(r.getSize())