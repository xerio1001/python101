# functie voor het uitprinten van de huidige stock na elke order
def PrinStock(dictProduct):
    print()
    print("="*47)
    print(f'| {"Code":<3} | {"Product":<10} | {"Prijs/kg":^10} | {"voorraad":^10} |')
    print("="*47)
    for key, item in dictProduct.items():
        
        naam = item[0]
        eenheidsprijs = item[1]
        voorraad = item[2]
        
        print(f'| {key:<4} | {naam:<10} | {eenheidsprijs:>10} | {voorraad:>10} |')
    print("="*47)
    print()


# functie voor het uitprinten van de uiteindelijke totale bestelling
def PrintOrder(volledigeBestelling):
    totalPrice = 0

    print()
    print("="*49)
    print(f'| {"BESTELLING":^45} |')
    print("="*49)
    print(f'| {"Product":<7} | {"Prijs/kg":>9} | {"Bestelling":>10} | {"Bedrag":>10} |')
    print("="*49)
    for item in volledigeBestelling:

        product = item[0]
        priceUnit = item[1]
        order = item[2]
        price = item[3]

        totalPrice = totalPrice + price
        print(f'| {product:<7} | {priceUnit:>9} | {order:>10} | {price:>10.2f} |')

    print("="*49)
    print(f'| {"Totaal te betalen":>32} | {totalPrice:>10.2f} |')
    print("="*49)
    print()