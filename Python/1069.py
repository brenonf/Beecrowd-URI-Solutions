n = int(input())
for i in range(n):
    a=input()
    cont = 0
    while True:
        a=a.replace('.','')
        if '<>' in a:
           cont+=a.count('<>')
           a=a.replace('<>','')
        else:
            break
    print(cont)
