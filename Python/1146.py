x=1
t=[]

while x != 0:
    x = int(input())
    for i in range(1, x + 1):
        t.append(i)
        t[i-1] = str(t[i-1])
        i = i + i
    t=' '.join(t)
    if x!= 0:       
        print(t)
        t =[]
        
