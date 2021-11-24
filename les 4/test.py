for x in range(1,21):
    for y in range(1,11):
        print(("{:>02} x {:>02} = {:>03}").format(x,y,x*y), end=' ')
    print()