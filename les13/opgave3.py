fp = open("pc_writetest.tmp", "w")
while True:
    tekst = input("Geef een regel tekst: ")
    if tekst == "":
        break
    fp.write(tekst)
    fp.write("\n")
fp.close()

fp = open("pc_writetest.tmp")
print()
buffer = fp.read()
fp.close()
print(buffer)