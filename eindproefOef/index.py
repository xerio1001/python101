import pcinput

goederenBestellijst = [['P016235',14,'CA100'],['P016231',93,'CB23'],['PD235',2,'PR14'],
                      ['P016231',13,'CB48'],['PD235',5,'PR01'],['P016235',62,'CA101'],['P016231',42,'CB21']]

stockoverzichtDictionary = {'P016235':[25,20,100,0,'LEV01',14],'P016231':[243,100,500,0,'LEV25',5],'PD235':[3,4,20,0,'LEV156',14]}

gereedzetten = []
noneOrder = []
backOrder = []
bijBestellen = []

leverbaarAantal = 0
nietLeverbaarAantal = 0

for best in goederenBestellijst:
    #uitlezen van elke bestelling en waarden in een eigen variabelen steken
    naam = best[0]
    aantal = best[1]
    klant = best[2]
    #lijst uitpikken op basis van de bestelling
    stock_voor_product = stockoverzichtDictionary[naam]

    #aantal bestellingen aftrekken van de stock
    oldStockAantal = stock_voor_product[0]
    stock_voor_product[0] = stock_voor_product[0] - aantal

    #lijst aanmaken voor bestellingen gereed te zetten
    if(oldStockAantal <= 0):
        #kan niets leveren
        noneOrder.append([naam, aantal, klant])

    elif(stock_voor_product[0] > 0):
        #kan alles leveren
        gereedzetten.append([naam, aantal, klant])

    else:
        #kan een deel leveren
        leverbaarAantal = oldStockAantal        
        gereedzetten.append([naam, leverbaarAantal, klant])

        nietLeverbaarAantal = aantal - leverbaarAantal
        backOrder.append([naam, nietLeverbaarAantal, klant, stock_voor_product[5]])
    

# loop over stock en bestel bij indien nodig => als stock hoev lager dan min hoev
for item in stockoverzichtDictionary.keys(): 
    stock_voor_item = stockoverzichtDictionary[item]
    while True:  
        if(stock_voor_item[0] < stock_voor_item[1]):
            stock_voor_item[0] = stock_voor_item[0] + stock_voor_item[2]
            bijBestellen.append([naam, stock_voor_item[2], stock_voor_item[5]])
        else:
            break

        



print("Het volgende kan nog niet geleverd worden:")
print(noneOrder)
print()
print('Het volgende kan wel geleverd worden:')
print(gereedzetten)
print()
print("Het volgende is nog in backorder:")
print(backOrder)
print()
print("De huidige stuk is nu:")
print(stockoverzichtDictionary)
print()
print("Bij te bestellen")
print(bijBestellen)