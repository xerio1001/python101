import functiesOXO


bord = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]

player = "O"

while True:
    functiesOXO.winnaar(bord, player)
    waardeRij, waardeKolom = functiesOXO.getRijKolom()

    checked = functiesOXO.GetSpace(bord, waardeRij, waardeKolom)

    if(checked == True):
        functiesOXO.getDraw(bord, player)


        if(player == "X"):
            bord[waardeRij][waardeKolom] = "X"
        if(player == "O"):
            bord[waardeRij][waardeKolom] = "O"
    else:
        print("Dit vak is al inguvuld. Probeer nog eens")
        continue
    
    functiesOXO.toon_bord(bord)