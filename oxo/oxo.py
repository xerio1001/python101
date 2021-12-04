import functiesOXO


bord = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]

player = "O"

functiesOXO.toon_bord(bord)

while True:
    
    playerTurn = functiesOXO.getDraw(bord, player)
    functiesOXO.winnaar(bord, playerTurn)

    waardeRij, waardeKolom = functiesOXO.getRijKolom()

    checked = functiesOXO.GetSpace(bord, waardeRij, waardeKolom)

    if(checked == True):
        if(playerTurn == "X"):
            bord[waardeRij][waardeKolom] = "X"
        else:
            bord[waardeRij][waardeKolom] = "O"
    else:
        print("Dit vak is al inguvuld. Probeer nog eens")
        continue
    
    functiesOXO.toon_bord(bord)