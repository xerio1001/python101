from typing import ValuesView
import pcinput

products = [
    { 
        "naam": "noten brood",
        "gewicht": (800,"gr"), 
        "recept": {
            "suiker": (10,"gr"),
            "meel": (600, "gr"),
            "water": (300, "ml"),
            "zout": (5, "gr"),
            "gist": (2, "gr"),
            "noten": (5, "el")
        }
    },
    { 
        "naam": "bruin brood",
        "gewicht": (800,"gr"), 
        "recept": {
            "suiker": (10,"gr"),
            "donker_meel": (600, "gr"),
            "water": (300, "ml"),
            "zout": (5, "gr"),
            "gist": (2, "gr"),
            "noten": (5, "el")
        }
    },
    { 
        "naam": "wit brood",
        "gewicht": (600,"gr"), 
        "recept": {
            "suiker": (10,"gr"),
            "meel": (500, "gr"),
            "water": (200, "ml"),
            "zout": (5, "gr"),
            "gist": (2, "gr")
        }
    },
    { 
        "naam": "sandwich",
        "gewicht": (50,"gr"), 
        "recept": {
            "suiker": (5,"gr"),
            "meel": (40, "gr"),
            "water": (5, "ml"),
            "gist": (0.5, "gr"),
        }
    },
    { 
        "naam": "noten sandwich",
        "gewicht": (50,"gr"), 
        "recept": {
            "suiker": (5,"gr"),
            "meel": (40, "gr"),
            "water": (5, "ml"),
            "gist": (0.5, "gr"),
            "noten": (1, "el")
        }
    }
]

stock = {
    "suiker": [5000, 1000, "gr"],
    "meel": [100000, 10000, "gr"], 
    "donker_meel": [100000, 10000, "gr"],          
    "gist": [5000, 1000, "gr"],
    "zout": [5000, 1000, "gr"],
    "noten": [50, 20, "el"],    
}


## vraag de bestellingen

# bereken de totalen van de bestelde producten en print

# bereken de totalen per ingredient en druk af

# print de nieuwe stock af

orderList = []

#bestelling vragen en controleren op errors
while True:
    order = pcinput.getString("Wat wilt u hebben?: ")
    order = order.lower()

    if(order == "wit brood" or order == "bruin brood" or order == "noten brood" or order == "sandwich" or order == "noten sandwich"):
        orderList.append(order)

    elif(order == ""):
        break

    else:
        print("Dit product bestaat niet. Probeer opnieuw.")

#uitlezen van de bestellingen
for itemPerOrder in orderList:
    
    #over elke eerste dictionary loopen
    for itemProducts in products:
       
        #over elk item in de dictionary loopen
        for itemDicts in itemProducts:
            
            if(itemPerOrder == itemProducts[itemDicts]):
                print(itemProducts.values())

    for itemStock, itemStockList in stock.items():
        print(itemStock, itemStockList)
        
        for index in range(len(itemStockList)):
            print(itemStockList[index])