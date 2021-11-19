import pcinput

getal = pcinput.getInteger('Geef een getal: ')
optelling = 1
som = 0

while optelling <= getal:
    som = som + optelling
    optelling += 1
    print(som)