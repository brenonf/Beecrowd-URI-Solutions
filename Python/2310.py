n = int(input())
s = [0,0,0,0,0,0]
for i in range(n):
    nome = input()
    x = map(int,input().split())
    y = map(int,input().split())
    k = 0
    for j in x:
        s[k] += j
        k += 1
    k = 3
    for j in y:
        s[k] += j
        k += 1


print('Pontos de Saque: {:.2f} %.'.format(100*s[3]/s[0]))       
print('Pontos de Bloqueio: {:.2f} %.'.format(100*s[4]/s[1]))
print('Pontos de Ataque: {:.2f} %.'.format(100*s[5]/s[2]))    
