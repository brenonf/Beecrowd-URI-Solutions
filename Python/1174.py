A=[]
for i in range(100):
    x = float(input())
    A.append(x)
    if x <=10.0:
        print('A[{}] = {}'.format(i,x))
