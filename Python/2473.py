aposta = set(map(int, input().split()))
resultado = set(map(int, input().split()))

aposta.intersection_update(resultado)
cont = len(aposta)

if cont < 3:
    print("azar")
elif cont == 3:
    print("terno")
elif cont == 4:
    print("quadra")
elif cont == 5:
    print("quina")
else:
    print("sena")
