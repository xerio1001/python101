get1 = 0
get2 = 1

stop = 1

print(get1)

while stop < 10:
    print(get2)
    som = get1 + get2
    get1 = get2
    get2 = som
    stop += 1