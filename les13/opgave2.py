numlist = [100, 101, 0, "103", 104]
while True:
    try:
        i1 = int(input("Geef een index: "))

        print("100 /", numlist[i1], "=", 100 / numlist[i1])
        break

    except ValueError:
        print("U gaf geen getal in.")

    except IndexError:
        print("U gaf een te hoge of een te lage waarde in.")
    
    except ZeroDivisionError:
        print("Wie deelt door nul is een snul.")
    
    except TypeError:
        print("De waarde op deze plek is geen juist type.")