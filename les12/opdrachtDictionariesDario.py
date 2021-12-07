tekst='appel,peer,banaan,kers,appel,kers,kers,mango,appel,appel,kers,tomaat,banaan,appel,appel,appel,appel,kers,banaan,appel,banaan,kers,tomaat,mango'

fruit = {}
tekst_list = tekst.split(",")

for item in tekst_list:
    if(fruit.get(item)):
        fruit[item] = fruit[item] + 1
    else:
        fruit[item] = 1

sortedFruit = list(fruit.keys())
sortedFruit.sort()

for item in sortedFruit:
    print(f'{item:<7}{":":^}{fruit[item]:>3}')