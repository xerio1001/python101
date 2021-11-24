#for loop

for getal in range(2,101):
    priem = True
    for deler in range(2,getal):
        if(getal % deler == 0):
            priem = False
            continue
    if(priem == True):
        print(getal)

print('\n')
print('For loop finished')

#while loop

getal = 2

while getal <= 100:
    priem = True
    control = 2

    while control < getal:
        if(getal % control == 0):
            priem = False
            break
        control += 1

    if(priem == True):
        print(getal)
    getal += 1

print('\n')
print('While loop finished')