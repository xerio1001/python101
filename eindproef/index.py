goederenBestellijst = [['P016235',14,'CA100'],['P016231',93,'CB23'],['PD235',2,'PR14'],
['P016231',13,'CB48'],['PD235',5,'PR01'],['P016235',62,'CA101'],['P016231',42,'CB21']]

stockoverzichtDictionary = {'P016235':[25,20,100,0,'LEV01',14],'P016231':[243,100,500,0,'LEV25',5],'PD235':[3,4,20,0,'LEV156',14]}

PrepareProducts = []
ShortOnProducts = []
upcommingOrder = []

for bestelling in goederenBestellijst:
    productCode = bestelling[0]
    productQuantity = bestelling[1]
    productAddress = bestelling[2]

    listByProduct = stockoverzichtDictionary[productCode]

    currentSupply = listByProduct[0]
    QuantityByOrder = listByProduct[2]
    isOrdered = listByProduct[3]
    Firm = listByProduct[4]
    dateByDelivery = listByProduct[5]

    listByProduct[0] = currentSupply - productQuantity
    
    achterstallig = listByProduct[0] - productQuantity
    achterstallig = abs(achterstallig)
    upcommingOrder = [productCode, achterstallig, Firm, dateByDelivery]
    
    if(listByProduct[0] < 0):
        if(not isOrdered):
            ShortOnProducts.append([productCode, Firm, QuantityByOrder])
            listByProduct[3] = 1
        else:
            if(listByProduct[0] + listByProduct[2] < listByProduct[1]):
                for item in ShortOnProducts:
                    if(item[0] == productCode):
                        item[2] += QuantityByOrder
    else:
        PrepareProducts.append(bestelling)

for item in stockoverzichtDictionary:
    if(stockoverzichtDictionary[0] < stockoverzichtDictionary[1]):
        stockoverzichtDictionary[0] + stockoverzichtDictionary[2]

print()
print("You need to order:")
print(ShortOnProducts)
print()
print("You can prepare:")
print(PrepareProducts)