inputLijst = []

while True:
    naam = input("Geef de naam in van de atleet: ")
    tijd = input("Geef de tijd in van de atleet: ")

    inputLijst.append([naam, tijd])

    stop = input("Wilt u stoppen?")
    if stop == "ja":
        break;

for item in inputLijst:
    print(item[0], item[1])