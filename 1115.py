y=x=1


while x != 0 and y != 0:
    x, y = map(int, input().split())
    if x > 0:
        if y > 0:
            print('primeiro')
        if y < 0:
            print('quarto')
    if x < 0:
        if y > 0:
            print('segundo')
        if y < 0:
            print('terceiro')
    
        
