import pcinput, string

naam = pcinput.getString("Geef een naam: ")

naamList = []

while naam != "":
    naamList.append(naam.lower())
    naam = pcinput.getString("geef een naam: ")

naamList.sort(reverse=False)

for item in naamList:
    item = item
    print(string.capwords(item))