import functiesOXO


bord = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]

player = "O"

functiesOXO.toon_bord(bord)

while True:

    waardeRij, waardeKolom = functiesOXO.getRijKolom()

    checked = functiesOXO.GetSpace(bord, waardeRij, waardeKolom)
    if(checked == True):
        if(player == "X"):
            bord[waardeRij][waardeKolom] = "X"
        else:
            bord[waardeRij][waardeKolom] = "O"
    else:
        print("Dit vak is al inguvuld. Probeer nog eens")
        continue

    functiesOXO.winnaar(bord, player)
    player = functiesOXO.getDraw(bord, player)
    
    functiesOXO.toon_bord(bord)