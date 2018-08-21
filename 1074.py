n = int(input())
x =['']
for i in range(1,n + 1):
    x.append(int(input()))
    
for i in range(1,n + 1):
    if x[i] == 0:
        print('NULL')
        
    if x[i] > 0:
        if x[i] % 2 == 0:
            print('EVEN POSITIVE')
        else:
            print('ODD POSITIVE')
            
    if x[i] < 0:
        if x[i] % 2 == 0:
            print('EVEN NEGATIVE')
        else:
            print('ODD NEGATIVE')
