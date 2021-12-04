import functiesOXO


bord = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]

player = "O"

while True:
    functiesOXO.winnaar(bord, player)
    playerTurn = functiesOXO.getDraw(bord, player)
    waardeRij, waardeKolom = functiesOXO.getRijKolom()

    checked = functiesOXO.GetSpace(bord, waardeRij, waardeKolom)

    if(checked == True):
        if(playerTurn == "X"):
            bord[waardeRij][waardeKolom] = "X"
        if(playerTurn == "O"):
            bord[waardeRij][waardeKolom] = "O"
    else:
        print("Dit vak is al inguvuld. Probeer nog eens")
        continue
    
    functiesOXO.toon_bord(bord)