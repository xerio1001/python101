import pcinput

getal = pcinput.getInteger('Geef een getal: ')
som = 0

for num in range(1,getal+1):
    som = som + num

print(som)