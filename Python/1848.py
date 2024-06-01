def piscada_bin(piscada):
    piscada = piscada.replace('-','0')
    piscada = piscada.replace('*','1')
    return piscada


def bin_int(piscada):
    piscada = int(piscada,2)
    return piscada


def soma(piscada,s):
    s += piscada
    return s

def main():
    for i in range(3):
        s = 0
        while True:
            piscada = input()
            if piscada != 'caw caw':
                piscada = piscada_bin(piscada)
                piscada = bin_int(piscada)
                s = soma(piscada,s)
            else:
                print(s)
                break

main()
    
