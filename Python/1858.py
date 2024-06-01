def pessoas():
    n = int(input())
    x = input().split()
    for i in range(n):
        x[i] = int(x[i])
    menor = min(x)
    y = x.index(menor) + 1
    
    return y

print(pessoas())

