a =list(map(int, input().split()))
b= list(map(int, input().split()))

if a[0]>b[0] or a[1]>b[1] or a[2]>b[2]:
    qtd=0
else:
    qtd= (b[0]//a[0])*(b[1]//a[1])*(b[2]//a[2])
print(qtd)