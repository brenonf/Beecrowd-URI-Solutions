def entrada():
    p,n = map(int,input().split())
    x = input().split()
    for i in range(len(x)):
        x[i] = int(x[i])
    
        
    return p,n,x


def verifica(a,b,p):
    if abs(a-b) > p:
        return True
    else:
        return False


def main():
    p,n,x = entrada()
    a = False
    for i in range(n-1):
        a = verifica(x[i],x[i+1],p)
        if a == True:
            print('GAME OVER')
            break
    if a == False:
        print('YOU WIN')

    



main()

