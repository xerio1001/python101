import pcinput
from random import randint

aantal_vragen = pcinput.getInteger('Hoeveel vragen wilt u: ')

score = 0

for x in range(aantal_vragen):
    getal1 = randint(1,1000)
    getal2 = randint(1,1000)

    print(getal1, '+', getal2, '=')
    antwoord = pcinput.getInteger('uitkomst ')

    if(antwoord == (getal1 + getal2)):
        score += 1

print('\nscore:', score,)

totaal = score / aantal_vragen * 100
print(totaal, '%')

if(totaal < 50):
    print('Niet geslaagd!')
else:
    print('Geslaagd!')