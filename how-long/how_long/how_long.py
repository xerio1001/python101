naam = input("Geef uw naam: ")
naam.strip()

while True:
    if naam != "":
        print(naam)
        break
    else:
        print("Geen geldige naam")
        naam = input("Geef uw naam: ")
