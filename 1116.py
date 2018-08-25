n = int(input())

for i in range(1, n + 1):
    x, y = map(int,input().split())
    
    if y == 0:
        print('divisao impossivel')
        
    if y != 0:
        divisao = x / y
        print('{:.1f}'.format(divisao))
