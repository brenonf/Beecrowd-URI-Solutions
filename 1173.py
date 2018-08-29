N=[0,0,0,0,0,0,0,0,0,0]
v= int(input())

for i in range(len(N)):
    N[i] = v
    v = v*2
    print('N[{}] = {}'.format(i,N[i]))
