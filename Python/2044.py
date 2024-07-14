while True:
    n= int(input())
    if n ==-1:
        break
    x=list(map(int,input().split()))
    soma=0
    idas=0
    for i in x:
        soma+=i
        if soma%100 ==0:
            idas+=1
    print(idas)
        
    
    

        
