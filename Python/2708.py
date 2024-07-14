cont=0
jipe=0
while True:

    c= input()
    if c=='ABEND':
        break
    a,b=c.split()
    
    if a =='SALIDA':
        cont+=(int(b))
        jipe+=1
    elif a =='VUELTA':
        cont-=(int(b))
        jipe-=1
    elif a=='ABEND':
        break
print(cont)
print(jipe)
