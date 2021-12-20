fruitlist = ["appel", "banaan", "kers"]
while True:
    try:
        num = input("Geef een getal: ") 
        if "." in num:
            num = float(num)
        else:
            num = int(num)
        print(fruitlist[num])
        break

    except ValueError:
        print("U gaf een een verkeerde waarde")

    except IndexError:
        print("U gaf een te hoge waarde. \n waarde moet tussen 0 en 2")
        
    except TypeError:
        print("U gaf een waarde met komma.")