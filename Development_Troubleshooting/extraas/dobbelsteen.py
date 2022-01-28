from random import choice
class Dobbelsteen:
    def __init__(self):
        self.waarden = []
    def __repr__(self):
        return 'Dobbelsteen interface class'
    def rol(self):
        return NotImplemented

class D10 (Dobbelsteen):
    def __init__(self):
        self.waarden = [1,2,3,4,5,6,7,8,9,10]
    def __repr__(self):
        return "6 zijdige dobbelsteen."
    def rol(self):
        return choice(self.waarden)


d10 = D10()
for i in range(11):
    print('rol',i, d10.rol())