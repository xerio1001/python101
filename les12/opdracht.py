tekst='appel,peer,banaan,kers,appel,kers,kers,mango,appel,appel,kers,tomaat,banaan,appel,appel,appel,appel,kers,banaan,appel,banaan,kers,tomaat,mango'

fruit = {}
tekst_list = tekst.split(",")
tekst_list.sort()

for item in tekst_list:
    if(fruit.get(item)):
        fruit[item] = fruit[item] + 1
    else:
        fruit[item] = 1


for item in fruit:
    print(f'{item:<7}{":":^}{fruit[item]:>6}')
