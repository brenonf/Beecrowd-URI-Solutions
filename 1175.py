N=[]
for i in range(20):
    x=int(input())
    N.append(x)
a=N[::-1]
for j in range(20):
    print('N[{}] = {}'.format(j,a[j]))

