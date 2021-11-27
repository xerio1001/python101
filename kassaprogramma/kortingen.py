def bereken(prijs, aantal_mosFriet):
    korting = 0
    if((prijs >= 150) and (aantal_mosFriet >= 2)):
        korting = 20
    elif((prijs >= 100) and (aantal_mosFriet >= 2)):
        korting = 10
    elif((prijs >= 50) and (aantal_mosFriet >= 2)):
        korting = 5
    return korting



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
            print(f'{int(berekening1):>22} {"briefjes van 500":<30}')

        if(berekening2 != 0):
            print(f'{int(berekening2):>22} {"briefjes van 200":<30}')

        if(berekening3 != 0):
            print(f'{int(berekening3):>22} {"briefjes van 100":<30}')

        if(berekening4 != 0):
            print(f'{int(berekening4):>22} {"briefjes van 50":<30}')

        if(berekening5 != 0):
            print(f'{int(berekening5):>22} {"briefjes van 20":<30}')

        if(berekening6 != 0):
            print(f'{int(berekening6):>22} {"briefjes van 10":<30}')

        if(berekening7 != 0):
            print(f'{int(berekening7):>22} {"briefjes van 5":<30}')

        if(berekening8 != 0):
            print(f'{int(berekening8):>22} {"munstukken van 2":<30}')

        if(berekening9 != 0):
            print(f'{int(berekening9):>22} {"munstukken van 1":<30}')

        if(berekening10 != 0):
            print(f'{int(berekening10):>22} {"munstukken van 0.5":<30}')

        if(berekening11 != 0):
            print(f'{int(berekening11):>22} {"munstukken van 0.2":<30}')

        if(berekening12 != 0):
            print(f'{int(berekening12):>22} {"munstukken van 0.1":<30}')

        if(berekening13 != 0):
            print(f'{int(berekening13):>22} {"munstukken van 0.05":<30}')

        if(berekening14 != 0):
            print(f'{int(berekening14):>22} {"munstukken van 0.02":<30}')

        if(berekening15 != 0):
            print(f'{int(berekening15):>22} {"munstukken van 0.01":<30}')
    