import math



while True:
    x = input()
    if x == "0":
        break
    n = list(map(int, x.split()))
    
    q = n[0]
    d = n[1]
    p = n[2]
    
    
    paginas = math.floor((p * q * d) / (p - q))
    
    if paginas > 1:
        print(f"{paginas} paginas")
    else:
        print(f"{paginas} pagina")
