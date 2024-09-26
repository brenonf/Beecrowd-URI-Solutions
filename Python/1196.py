letras = "`1234567890-=QWERTYUIOP[]\\ASDFGHJKL;'ZXCVBNM,./"

while True:
    try:
        x = input()
        if not x:
            break

        frase = list(x)

        for i in range(len(frase)):
            indice = letras.find(frase[i])
            
            if indice != -1:
                frase[i] = letras[indice - 1]

        print(''.join(frase))
    
    except EOFError:
        break
