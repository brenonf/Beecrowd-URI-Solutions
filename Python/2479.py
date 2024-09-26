lista = []
n = int(input())
cont = 0

for i in range(n):
    nome = input().split()
    if nome[0] == "+":
        cont += 1
    lista.append(nome[1])
lista.sort()

for nome in lista:
    print(nome)

print(f"Se comportaram: {cont} | Nao se comportaram: {n - cont}")
