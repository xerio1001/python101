import pcinput
from random import randint

aantal_vragen = pcinput.getInteger('Hoeveel vragen wilt u: ')

max = 0
score = 0

while max < aantal_vragen:
    getal1 = randint(1,1000)
    getal2 = randint(1,1000)

    print(getal1, '+', getal2, '=')
    antwoord = pcinput.getInteger('uitkomst ')

    if(antwoord == (getal1 + getal2)):
        score += 1
    max += 1

print(' ')
print('score:', score,)

totaal = score / aantal_vragen * 100
print(totaal, '%', '\n')

if(totaal < 50):
    print('Niet geslaagd!')
else:
    print('Geslaagd!')