# 7 Iteraties
# ************************************
# from pcinput import getInteger
# num1 = getInteger("Nummer 1: ")
# num2 = getInteger("Nummer 2: ")
# num3 = getInteger("Nummer 3: ")
# num4 = getInteger("Nummer 4: ")
# num5 = getInteger("Nummer 5: ")
# print("Totaal is", num1 + num2 + num3 + num4 + num5)
# print("klaar 7 - iteraties")

# 7.1.1
# num = 1
# while num <= 5:
#     print(num)
#     num += 1
# print("Klaar 7.1.1")

# 7.1.2
# from pcinput import getInteger
# totaal = 0
# teller = 0
# while teller < 5:
#     totaal += getInteger("Geef een nummer: ")
#     teller += 1
# print("Totaal is", totaal)
# print("klaar 7.1.2")

# 7.1.3
# from pcinput import getInteger
# totaal = 0
# num = getInteger("Geef een nummer (0 om te stoppen): ")
# while num != 0:
#     totaal += num
#     num = getInteger("Geef een nummer (0 om te stoppen): ")
# print("Totaal is", totaal)
# print("klaar 7.1.3")

# 7.1.4
# from pcinput import getInteger
# totaal = 0
# teller = 0
# while teller < 5:
#     totaal += getInteger( "Geef een nummer: " )
# print( "Totaal is", totaal )
# print("klaar 7.1.4")


# 7.2.1
# for letter in "banaan":
#     print(letter)

# 7.2.2
# fruit ="banaan"
# for letter in fruit:
#     print(letter)
# print("Klaar 7.2.2")

# 7.2.2 B Collectie wordt enkel bepaald bij het begin van de loop
# fruit = "banaan"
# for letter in fruit:
# 	print(letter)
# 	if letter == "n":
# 	    fruit = "mango"
# print(fruit)
# print("Klaar 7.2.2 B")

# 7.2.3
# for x in range(10):
#     print(x)
# print("klaar 7.2.3")

# 7.2.4
# for x in ("aaa",111,"pol",234):
#     print(x)
# print("klaar 7.2.4")

# 7.3.1 Else
# i = 0
# while i < 5:
#     print(i)
#     i += 1
# print("De loop eindigt, i is nu", i)
# print("Klaar 7.3.1 (while)")
#
# for fruit in ("appel", "mango", "aardbei"):
#     print(fruit)
# else:
#     print("De loop eindigt, fruit is nu", fruit)
# print("Klaar 7.3.1 (for)")

# 7.3.2 Break
# i = 1
# while i <= 1000000:
#     num1 = int("1" + str(i))
#     num2 = int(str(i) + "1")
#     if num2 == 3 * num1:
#         print(num2, "is drie keer", num1)
#         break
#     i += 1
# else:
#     print("Geen antwoord gevonden")
#
# for x in range(1, 6):
#     if x % 7 == 0:
#         print("Getal", x, "is deelbaar door 7.")
#         break
# else:
#     print("Geen getal gevonden, dat door 7 deelbaar is.")
# print("einde loop 7.3.2")

# i = 1
# while i <= 1000000:
# 	num1 = int("1" + str(i))
# 	num2 = int(str(i) + "1")
# 	if num2 == 3 * num1:
# 		print(num2, "is drie keer", num1)
# 		break
# 	i += 1
# else:
# 	print("Geen antwoord gevonden")


# 7.3.3 Continue
# for x in (“aaa”,123,”bcde”,6789):
#     <acties>
#     if <boolean expressie>:
#         continue
#     <acties>

# i = 0
# while i < 10:
#     if i == 5:
#         continue
#     i += 1
#
# i = 0
# while i < 10:
#     i += 1
#     if i == 5:
#         continue

# num = 0
# while num < 100:
#     num += 1
#     if num % 2 == 0:
#         continue
#     if num % 3 == 0:
#         continue
#     if num % 10 == 7:
#         continue
#     if num % 10 == 9:
#         continue
#     print(num)

#7.4 Geneste loops
# for i in range( 3 ):
#     print( "Begin buitenste loop met i =", i)
#     for j in range( 3 ):
#         print("   Begin binnenste loop met j =", j )
#         print("        (i,j) = ({},{})".format( i, j ) )
#         print("   Einde binnenste loop met j =", j )
#         print("   -------------------------------")
#     print( "Einde buitenste loop met i =", i)
#     print( "*******************************")
# print("Klaar Geneste loops 7.4")

for x in range(1,11):
    for y in range(1,21):
        print(("{:>02}x{:>02}={:>03}").format(x,y,x*y))

# 7.5
# from pcinput import getLetter
# while True:
#     # doe_programma()
#     if getLetter("programma stoppen? J/N: ") == "J":
#         break
#
# from pcinput import getInteger
# from sys import exit
# while True:
#     x = getInteger("Geef nummer 1: ")
#     if x == 0:
#         break
#     y = getInteger("Geef nummer 2: ")
#     if y == 0:
#         break
#     if (x < 0 or x > 1000) or (y < 0 or y > 1000):
#         print("Nummers moeten tussen 0 en 1000 zijn")
#         continue
#     if x % y == 0 or y % x == 0:
#         print("Fout: de nummers mogen geen nul zijn")
#         exit()
#     print(x, "keer", y, "is", x * y)
# print("Klaar!")