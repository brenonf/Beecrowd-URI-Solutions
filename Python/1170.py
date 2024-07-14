for _ in range(int(input())):
    comida = float(input())
    count = 0
    while comida >1:
        comida/=2
        count+=1
    print(f'{count} dias')
        
