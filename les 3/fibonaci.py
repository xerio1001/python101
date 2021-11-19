import pcinput

getal1 = pcinput.getInteger('Geef een eerste getal: ')
getal2 = pcinput.getInteger('Geef een tweede getal: ')
getal3 = pcinput.getInteger('Geef een derde getal: ')
stoppen = 0

while stoppen < 10:
    print(getal1)
    print(getal2)
    print(getal3)
    getal1 = getal2 + getal3
    getal2 = getal1 + getal3
    getal3 = getal1 +  getal2
    stoppen += 1