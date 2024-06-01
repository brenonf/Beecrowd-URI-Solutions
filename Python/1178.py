x=float(input())
n=[]
x=x*2
for i in range(100):
    n.append(x)
    print('N[{}] = {:.4f}'.format(i,x/2))
    x=x/2
