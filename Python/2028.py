cont = 0
while True:
    try:
        cont +=1
        string ='0'
        n = int(input())
        for i in range(1,n+1):
            for j in range(1,i+1):
                string += ' '+ str(i)
        leng = string.split()
        numeros = len(leng)
        if numeros == 1:
            print('Caso {}: {} numero'.format(cont,numeros))
        else:
            print('Caso {}: {} numeros'.format(cont,numeros))
        print(string)
        print()


    except EOFError:
        break