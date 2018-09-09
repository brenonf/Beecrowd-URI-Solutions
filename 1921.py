def entrada():
    n = int(input())
    return n

def laco(n):
    s = 0
    for i in range(n):
        s += i
    s -= n
    print(s)



laco(entrada())
        
