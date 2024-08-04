letra=input()
frase=input().split()
cont=0

for i in range(len(frase)):
    if letra in frase[i]:
        cont+=1
print(f'{100*(cont/len(frase)):.1f}')