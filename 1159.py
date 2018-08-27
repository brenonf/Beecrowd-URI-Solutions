x = 999
while x !=0:
    x=int(input())
    soma = 0
    i = 1
    if x != 0:
        while i <= 5:
            
            if x % 2 == 0:
                soma = soma + x
                x = x + 1
                i = i+ 1
            else:
                x = x + 1
            
            
        print(soma)
    elif x ==0:
        break
