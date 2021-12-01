import pcinput

nummer = pcinput.getString("Geef een nummer: ")

nummerList = []

while nummer != "":
    nummerList.append(int(nummer))
    nummer = pcinput.getString("geef een nummer: ")

nummerList.sort(key = abs)

for item in nummerList:
    item = item
    print(item)