m=n=1

while m > 0 and n > 0:
    t=[]
    x = input().split()
    m,n = x
    m = int(m)
    n = int(n)
    if m < n and m > 0 and n > 0:
        for i in range(m,n + 1):
            t.append(i)
            s = sum(t)
        a = ' '.join(map(str,t))
        print('{} Sum={}'.format(a,s))
    
    if m > n and m > 0 and n > 0:
        for i in range(n,m + 1):
            t.append(i)
            s = sum(t)
        a = ' '.join(map(str,t))
        print('{} Sum={}'.format(a,s))

    if m == n and m > 0 and n > 0:
        print('{} Sum={}'.format(m,m))
