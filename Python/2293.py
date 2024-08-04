maior = 0

n=list(map(int, input().split()))
normal=[[] for _ in range(n[0])]
transposta=[[] for _ in range(n[1])]

for i in range(n[0]):
    normal[i] = list(map(int, input().split()))

for i in range(n[1]):
    transposta[i] = [0] * n[0]
    for j in range(n[0]):
        transposta[i][j] = normal[j][i]
for i in range(n[0]):
    if sum(normal[i]) > maior:
        maior = sum(normal[i])
for i in range(n[1]):
    if sum(transposta[i]) > maior:
        maior = sum(transposta[i])

print(maior)
