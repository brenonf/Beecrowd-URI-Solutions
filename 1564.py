dilma = []
cont = 0
while True:
    try:
        x = int(input())
        dilma.append(x)
        cont = cont + 1
    except:
        break

for i in dilma[0:cont]:
    if i == 0:
        print('vai ter copa!')
    if i != 0:
        print('vai ter duas!')
