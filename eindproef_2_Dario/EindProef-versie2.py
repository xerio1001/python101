import pcinput, GetKlantOrder


dictProduct = {
    "B": ["Bloem",2.35,15600],
    "K": ["Koffie",13.75,15230],
    "S": ["Suiker",2.99,72500],
    "P": ["Pasta",4.95,48500],
    "R": ["Rijst",6.95,92000]
    }


volledigeBestelling = []

while True:
    GetKlantOrder.PrinStock(dictProduct)
    bestelling = pcinput.getString("Wat wilt u bestellen? (Geef 'X' in om te stoppen): ").upper()


    if(bestelling == "X"):
        # print de volledige bestelling na de stop
        GetKlantOrder.PrintOrder(volledigeBestelling)
        break

    
    elif(bestelling in dictProduct.keys()):
        stockProduct = dictProduct[bestelling]
        
        if(stockProduct[2] == 0):
            print("Dit product is momenteel op. Probeer nog eens")
        else:
            # print de gegevens van het opgevraagde product
            stockProduct = dictProduct[bestelling]
            print(stockProduct[0], "met Prijs/kg = ", stockProduct[1], "en voorraad = ", stockProduct[2] )

            # vraag het aantal in gram en pas aan in stock
            aantal = pcinput.getInteger("Hoeveel van dit product wilt u hebben in gram?: ")
            
            if(aantal <= stockProduct[2]):
                stockProduct[2] = stockProduct[2] - aantal
            else:
                print("We kunnen dit niet leveren, de bestelling wordt niet verwerkt.")
                continue

            # Bereken de prijs per besteld product
            aantalKG = aantal / 1000
            prijs = aantalKG * stockProduct[1]

            productNaam = stockProduct[0]
            priceUnit = stockProduct[1]

            # voeg na elke bestelling de bestelling toe aan een lijst
            volledigeBestelling.append([productNaam, priceUnit, aantal, prijs])


    else:
        print("Product bestaat niet! Probeer opnieuw.")