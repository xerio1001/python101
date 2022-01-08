import pcinput
import funcPrijzen

def AddMenu(allProducts):
    # een lijst van het alfabet voor als key te gebruiken bij de dictionary van de stock
    alphabet_list = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]
    
    Get_nieuw_product = pcinput.getString("Geef een nieuw product in: ").lower()

    if(Get_nieuw_product == ""):
        print("Probeer opnieuw!")
        Get_nieuw_product = pcinput.getString("Geef een nieuw product in (X bij naam om te stoppen): ").lower()
    else:
        Get_nieuw_prijs = pcinput.getFloat("Wat is de prijs van dit product?: ")
        Get_nieuw_stock = pcinput.getInteger("Hoeveel is er in stock van het nieuwe product?: ")

        if(Get_nieuw_prijs < 0):
            print("De prijs kan niet lager dan 0 zijn")
            Get_nieuw_prijs = pcinput.getFloat("Wat is de prijs van dit product?: ")
        if(Get_nieuw_stock <= 0):
            print("De stock kan niet lager of gelijk zijn aan 0 zijn")
            Get_nieuw_stock = pcinput.getInteger("Hoeveel is er in stock van het nieuwe product?: ")
        else:

            if(Get_nieuw_product != "" and Get_nieuw_prijs != "" and Get_nieuw_stock != ""):
                allProducts["E"] = ({"Naam":Get_nieuw_product, "Prijs":Get_nieuw_prijs, "Stock":Get_nieuw_stock})
                # kreeg dit niet aan de praat
                
                #i = 0
                #for key in allProducts.keys():
                    #while True:
                        #if(key == alphabet_list[i]):
                            #i += 1
                        #elif(key != alphabet_list[i]):
                            #allProducts[alphabet_list[i]] = ({"Naam":Get_nieuw_product, "Prijs":Get_nieuw_prijs, "Stock":Get_nieuw_stock})
                            #break"""
            else:
                return



def ShowMenu(allProducts):
    print()
    print("*"*70)
    print("=-"*35)
    print(f'{"Producten":^70}')
    print("=-"*35)
    print(f'| {"Code":<5} | {"Naam":<21} | {"Prijs":<10} | {"Beschikbaar aantal":<21} |')
    print("=-"*35)
    for key, value in allProducts.items():
        
        naam = value["Naam"]
        prijs = value["Prijs"]
        stock = value["Stock"]

        print(f'| {key:<5} | {naam:<21} |{"€":<} {prijs:<9} | {stock:<21} |')
    print("=-"*35)
    print("*"*70)
    print()




def GetOrder(allOrders, allProducts):
    total = 0
    while True:
        # Toon de beschikbare producten
        ShowMenu(allProducts)

        Get_bestelling = pcinput.getString("Wat had u graag gehad? (Geef de code van het product of 'stop' om te stoppen): ").upper()
        if(Get_bestelling != "STOP"):

            # lees het gevraagde product uit de dictionary
            for key, value in allProducts.items():
                if(key == Get_bestelling):
                    naam = value["Naam"]
                    prijs = value["Prijs"]
                    stock = value["Stock"]
            # controleer of er nog in stock is van het gevraagde product
            if(stock <= 0):
                print("Onze excuses maar dit product is op!")
            else:
                print("Gewenst product:", naam, ", De eenheidsprijs:", prijs, "euro. Het aantal nog in stock:", stock)
                Get_aantal_bestelling = pcinput.getInteger("Hoeveel had u graag gehad?: ")

                # Controleer of een juist aantal besteld
                if(Get_aantal_bestelling > stock):
                    print("U heeft meer besteld dan dat er beschikbaar is. Probeer nog eens!")
                    Get_aantal_bestelling = pcinput.getInteger("Hoeveel had u graag gehad?: ")
                else:
                    # pas stock aan als alles klopt en voeg daarna alle bestellingen toe aan een lijst
                    total = stock - Get_aantal_bestelling
                    stock = total
                    allOrders.append([Get_bestelling, naam, Get_aantal_bestelling, prijs])

        else:
            print(allOrders)
            break




def showTicket(allOrders, naam_bediende, gegeven_bedrag, prijs, teruggave):

    print('='*60)
    print(f'{naam_bediende:^60}')
    print('*'*60)
    print(f'{"Uw bestelling + aantal":<20} | {"Alle kosten":<21} | {"Aantal":<9}')
    print('*'*60)

    for item in allOrders:
        naam = item[1]
        aantal = item[2]
        eenheidsprijs = item[3]
        print(f'| {naam:<20} | €{eenheidsprijs:<20} | {aantal:<9} |')

    print('*'*60)

    print(f'{"UW totaal":<30}{prijs:>29.2f}€')
    print(f'{"Betaald":<30}{gegeven_bedrag:>29.2f}€')
    
    if(gegeven_bedrag == prijs):
        print(f'{"Terug gehad":<30}{"0":>29}€')
    else:
        print(f'{"Terug gehad":<30}{teruggave:>29.2f}€')
        print('*'*60)

    # uitbreiding 2 (welke munstukken/biljetten) v
    funcPrijzen.biljet(teruggave)
    
    print("*"*60)
    print(f'{"Smakelijk eten!!!":^60}')
    print('='*60)