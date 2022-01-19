# Functie om de totaalprijs te berekenen
def CalcPrice(allOrders):
    Get_totaal_prijs = 0
    for item in allOrders:

        aantal = item[2]
        eenheidsprijs = item[3]

        Get_prijs = eenheidsprijs * aantal
        Get_prijs = float(Get_prijs)
    
        Get_totaal_prijs = Get_totaal_prijs + Get_prijs

    return Get_totaal_prijs


# Functie voor het berekenen welke biljetten de klant moet terug krijgen
def biljet(teruggave):
    
        berekening1 = teruggave // 500
        rest_ber1 = teruggave % 500

        berekening2 = rest_ber1 // 200
        rest_ber2 = rest_ber1 % 200

        berekening3 = rest_ber2 // 100
        rest_ber3 = rest_ber2 % 100

        berekening4 = rest_ber3 // 50
        rest_ber4 = rest_ber3 % 50

        berekening5 = rest_ber4 // 20
        rest_ber5 = rest_ber4 % 20

        berekening6 = rest_ber5 // 10
        rest_ber6 = rest_ber5 % 10

        berekening7 = rest_ber6 // 5
        rest_ber7 = rest_ber6 % 5

        berekening8 = rest_ber7 // 2
        rest_ber8 = rest_ber7 % 2

        berekening9 = rest_ber8 // 1
        rest_ber9 = rest_ber8 % 1

        berekening10 = rest_ber9 // 0.5
        rest_ber10 = rest_ber9 % 0.5

        berekening11 = rest_ber10 // 0.2
        rest_ber11 = rest_ber10 % 0.2

        berekening12 = rest_ber11 // 0.1
        rest_ber12 = rest_ber11 % 0.1

        berekening13 = rest_ber12 // 0.05
        rest_ber13 = rest_ber12 % 0.05

        berekening14 = rest_ber13 // 0.02
        rest_ber14 = rest_ber13 % 0.02

        berekening15 = rest_ber14 // 0.01
        rest_ber15 = rest_ber14 % 0.01


        if(berekening1 != 0):
            print(f'{int(berekening1):>17} {"briefjes van 500 euro":<25}')

        if(berekening2 != 0):
            print(f'{int(berekening2):>17} {"briefjes van 200 euro":<25}')

        if(berekening3 != 0):
            print(f'{int(berekening3):>17} {"briefjes van 100 euro":<25}')

        if(berekening4 != 0):
            print(f'{int(berekening4):>17} {"briefjes van 50 euro":<25}')

        if(berekening5 != 0):
            print(f'{int(berekening5):>17} {"briefjes van 20 euro":<25}')

        if(berekening6 != 0):
            print(f'{int(berekening6):>17} {"briefjes van 10 euro":<25}')

        if(berekening7 != 0):
            print(f'{int(berekening7):>17} {"briefjes van 5 euro":<25}')

        if(berekening8 != 0):
            print(f'{int(berekening8):>17} {"munstukken van 2 euro":<25}')

        if(berekening9 != 0):
            print(f'{int(berekening9):>17} {"munstukken van 1 euro":<25}')

        if(berekening10 != 0):
            print(f'{int(berekening10):>17} {"munstukken van 0.5 euro":<25}')

        if(berekening11 != 0):
            print(f'{int(berekening11):>17} {"munstukken van 0.2 euro":<25}')

        if(berekening12 != 0):
            print(f'{int(berekening12):>17} {"munstukken van 0.1 euro":<25}')

        if(berekening13 != 0):
            print(f'{int(berekening13):>17} {"munstukken van 0.05 euro":<25}')

        if(berekening14 != 0):
            print(f'{int(berekening14):>17} {"munstukken van 0.02 euro":<25}')

        if(berekening15 != 0):
            print(f'{int(berekening15):>17} {"munstukken van 0.01 euro":<25}')
    