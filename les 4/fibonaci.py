get1 = 0
get2 = 1

print(get1)

for teller in range(9):
    print(get2)
    som = get1 + get2
    get1 = get2
    get2 = som
print("Finished", "\n")