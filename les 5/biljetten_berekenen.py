def funBiljet(teruggave):
    
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

        if(berekening1 != 0):
            print(f'{berekening1:>22} {"briefjes van 500":<30}')

        if(berekening2 != 0):
            print(f'{berekening2:>22} {"briefjes van 200":<30}')

        if(berekening3 != 0):
            print(f'{berekening3:>22} {"briefjes van 100":<30}')

        if(berekening4 != 0):
            print(f'{berekening4:>22} {"briefjes van 50":<30}')

        if(berekening5 != 0):
            print(f'{berekening5:>22} {"briefjes van 20":<30}')

        if(berekening6 != 0):
            print(f'{berekening6:>22} {"briefjes van 10":<30}')

        if(berekening7 != 0):
            print(f'{berekening7:>22} {"briefjes van 5":<30}')

        if(berekening8 != 0):
            print(f'{berekening8:>22} {"munstukken van 2":<30}')

        if(berekening9 != 0):
            print(f'{berekening9:>22} {"munstukken van 1":<30}')
    