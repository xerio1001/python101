soorten = ["harten", "ruiten", "klaveren", "schoppen"]
waarden = [1, 2, 3, 4, 5, 6, 7, 8, 9, "Boer", "Vrouw", "Heer"]
kaarten = []


singleSoorten = str(soorten)

for soort in soorten:
    for waard in waarden:
        kaarten = (soort, waard)
        print(kaarten)
