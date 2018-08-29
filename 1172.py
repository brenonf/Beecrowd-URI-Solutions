X=[1,2,3,4,5,6,7,8,9,10]
for i in range(len(X)):
    X[i]=int(input())
    if X[i] <=0:
        X[i] = 1
    print('X[{}] = {}'.format(i,X[i]))

