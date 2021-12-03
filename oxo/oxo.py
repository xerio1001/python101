import functiesOXO


bord = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]

player1 = "O"

while True:
    waardeRij, waardeKolom = functiesOXO.getRijKolom()

    checked = functiesOXO.GetSpace(bord, waardeRij, waardeKolom)

    if(checked == True):

        if(player1 == "X"):
            player1 = "O"
        else:
            player1 = "X"


        if(player1 == "X"):
            bord[waardeRij][waardeKolom] = "X"
        if(player1 == "O"):
            bord[waardeRij][waardeKolom] = "O"
    else:
        print("Dit vak is al inguvuld. Probeer nog eens")
        continue
    
    functiesOXO.toon_bord(bord)