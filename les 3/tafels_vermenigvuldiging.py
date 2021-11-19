import pcinput

getal = pcinput.getInteger('Geef een getal: ')
stoppen = 0
uitvoer = 1
uitkomst = getal

while uitvoer <= 10:
    uitkomst = uitvoer * getal
    uitvoer += 1
    print(uitkomst)